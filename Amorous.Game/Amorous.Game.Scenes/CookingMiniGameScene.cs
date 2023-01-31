using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spine;

namespace Amorous.Game.Scenes;

public class CookingMiniGameScene : AbstractScene
{
	private class GUI : InteractableOverlay
	{
		private readonly ButtonInteractable _completeButton;

		public bool IsVisible
		{
			set
			{
				_completeButton.Visible = value;
			}
		}

		public GUI(IAmorous game, Action click)
			: base(game)
		{
			_completeButton = AddButtonInteractable("Assets/Scenes/Cooking/Button", "Assets/Scenes/Cooking/Button hover", "Assets/Gui/Fonts/Bold-26", "Stop cooking!", Color.White, 832, 970, new Rectangle(832, 970, 256, 102), click);
			_completeButton.Visible = false;
		}
	}

	private enum EIngrediants
	{
		OnionsGarlic,
		GroundBeef,
		Carrots,
		TinnedTomatoes,
		Herbs,
		Pasta,
		None
	}

	private const int IngrediantCount = 5;
	private const float ColdTime = 2.5f;
	private const float FryTime = 4.5f;

	private readonly GUI _overlay;
	private readonly SpineRenderer _spine;
	private readonly RandomSoundEffect _soundsOfSpan;
	private readonly RandomSoundEffect _soundsOfAdd;
	private readonly RandomSoundEffect _soundsOfOnion;
	private readonly RandomSoundEffect _soundsOfBeef;
	private readonly RandomSoundEffect _soundsOfCarrots;
	private readonly RandomSoundEffect _soundsOfTomatoe;
	private readonly RandomSoundEffect _soundsOfBay;
	private readonly RandomSoundEffect _soundsOfBurning;
	private readonly RandomSoundEffect _soundsOfDrum;
	private readonly RandomSoundEffect _soundsOfBad;
	private readonly RandomSoundEffect _soundsOfOkay;
	private readonly RandomSoundEffect _soundsOfGreat;
	private readonly AbstractLayer _backgroundBad;
	private readonly AbstractLayer _backgroundOkay;
	private readonly AbstractLayer _backgroundGreat;
	private bool _pastaAppeared;
	private bool _addedOnions;
	private bool _addedBeef;
	private bool _addedCarrots;
	private bool _addedTomatoe;
	private bool _addedBayleaves;
	private EIngrediants _pendingIngrediant;
	private bool _burned;
	private float _ticks;
	private bool _spawning;
	private bool _mixing;
	private bool _requestedResult;
	private float _fadingOut;
	private List<EIngrediants> _ingrediants;
	private float _time;

	public bool IsSelectingIngredient { get; set; }
	public bool Completable { get; set; }
	public bool IsDone { get; set; }

	public CookingMiniGameScene(IAmorous game)
		: base(game)
	{
		_overlay = new GUI(game, Click);
		base.Game.SetOverlay(_overlay);
		AddSpriteLayer("Background", "Assets/Scenes/Cooking/Background", 0, 0);
		_backgroundBad = AddForegroundSpriteLayer("Background", "Assets/Scenes/Cooking/Bad", 0, 0);
		_backgroundBad.Visible = false;
		_backgroundOkay = AddForegroundSpriteLayer("Background", "Assets/Scenes/Cooking/Okay", 0, 0);
		_backgroundOkay.Visible = false;
		_backgroundGreat = AddForegroundSpriteLayer("Background", "Assets/Scenes/Cooking/Excellent", 0, 0);
		_backgroundGreat.Visible = false;
		SpineDrawableLayer spineLayer = new SpineDrawableLayer(this, "Cooking");
		_spine = game.Content.LoadSkeleton("Assets/Scenes/Cooking/Cooking");
		_spine.X = 960f;
		_spine.Y = 540f;
		_soundsOfSpan = new RandomSoundEffect(game.Content);
		_soundsOfSpan.Append("Assets/Sounds/MiniGames/Cooking/Pan spawn");
		_soundsOfAdd = new RandomSoundEffect(game.Content);
		_soundsOfAdd.Append("Assets/Sounds/MiniGames/Cooking/Add ingrediant");
		_soundsOfOnion = new RandomSoundEffect(game.Content);
		_soundsOfOnion.Append("Assets/Sounds/MiniGames/Cooking/Onion");
		_soundsOfBeef = new RandomSoundEffect(game.Content);
		_soundsOfBeef.Append("Assets/Sounds/MiniGames/Cooking/Beef");
		_soundsOfCarrots = new RandomSoundEffect(game.Content);
		_soundsOfCarrots.Append("Assets/Sounds/MiniGames/Cooking/Carrots");
		_soundsOfTomatoe = new RandomSoundEffect(game.Content);
		_soundsOfTomatoe.Append("Assets/Sounds/MiniGames/Cooking/Tomatoe");
		_soundsOfBay = new RandomSoundEffect(game.Content);
		_soundsOfBay.Append("Assets/Sounds/MiniGames/Cooking/Bay leaves");
		_soundsOfBurning = new RandomSoundEffect(game.Content);
		_soundsOfBurning.Append("Assets/Sounds/MiniGames/Cooking/Burning");
		_soundsOfDrum = new RandomSoundEffect(game.Content);
		_soundsOfDrum.Append("Assets/Sounds/MiniGames/Cooking/Drum roll");
		_soundsOfBad = new RandomSoundEffect(game.Content);
		_soundsOfBad.Append("Assets/Sounds/MiniGames/Cooking/Bad food");
		_soundsOfOkay = new RandomSoundEffect(game.Content);
		_soundsOfOkay.Append("Assets/Sounds/MiniGames/Cooking/Ok food");
		_soundsOfGreat = new RandomSoundEffect(game.Content);
		_soundsOfGreat.Append("Assets/Sounds/MiniGames/Cooking/Great food");
		RefreshSubscene();
		spineLayer.OnUpdate = delegate(GameTime gameTime)
		{
			_spine.Update(gameTime);
		};
		spineLayer.OnSpineDraw = delegate(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer)
		{
			_spine.Draw(skeletonMeshRenderer, null, BeforeRenderSlot);
		};
		AddLayer(spineLayer, 0);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.FreeFloatingTrack, 0.1f);
	}

	private bool BeforeRenderSlot(int index, string bone)
	{
		switch (bone)
		{
			case "Pasta":
				return _pastaAppeared;
			case "Onions bowl shadow":
			case "Onions bowl glow":
			case "Onions bowl":
				return !_addedOnions;
			default:
				return true;
			case "BayThyme 1":
			case "BayThyme 2":
				return _addedBayleaves;
			case "Bayleaves bowl shadow":
			case "Bayleaves bowl glow":
			case "Bayleaves bowl":
				return !_addedBayleaves;
			case "Sauce 1":
			case "Sauce 2":
				return _addedTomatoe;
			case "Tomatoe bowl shadow":
			case "Tomatoe bowl glow":
			case "Tomatoe bowl":
				return !_addedTomatoe;
			case "Carrots 1":
			case "Carrots 2":
				return _addedCarrots;
			case "Carrot bowl shadow":
			case "Carrot bowl glow":
			case "Carrot bowl":
				return !_addedCarrots;
			case "Ground Beef 1":
			case "Ground Beef 2":
				return _addedBeef;
			case "Ground beef bowl shadow":
			case "Ground beef bowl glow":
			case "Ground beef bowl":
				return !_addedBeef;
			case "OnionsGarlic 1":
			case "OnionsGarlic 2":
				return _addedOnions;
		}
	}

	private void RefreshSubscene()
	{
		_spawning = true;
		_pastaAppeared = false;
		_addedOnions = false;
		_addedBeef = false;
		_addedCarrots = false;
		_addedTomatoe = false;
		_addedBayleaves = false;
		_ingrediants = new List<EIngrediants>();
		_spine.SetVisibility(0f);
		_soundsOfSpan.PlayNext();
		_spine.StartAnimation("Pan spawn", delegate
		{
			_spawning = false;
		});
		_pendingIngrediant = EIngrediants.None;
	}

	public override void Update(GameTime gameTime)
	{
		base.Update(gameTime);
		if (_requestedResult)
		{
			_fadingOut += (float)gameTime.ElapsedGameTime.Milliseconds / 1000f;
			if (_fadingOut > 3f)
			{
				_requestedResult = false;
				ApplyResultWithFade();
			}
		}
		if (Completable || !IsSelectingIngredient)
		{
			return;
		}
		if (_burned)
		{
			_ticks += (float)gameTime.ElapsedGameTime.Milliseconds / 1000f;
		}
		if (_spawning || _mixing || _pastaAppeared)
		{
			return;
		}
		Point point = base.Game.Canvas.GlobalToContent(base.Game.Controller.Cursor);
		if (_addedOnions || !_spine.InAttachment("Onions bowl glow", point.X, point.Y))
		{
			_spine.SetAlpha("Onions bowl glow", 0f);
		}
		else
		{
			SelectIngrediant("OnionsGarlic highlight", EIngrediants.OnionsGarlic, _soundsOfOnion);
			if (base.Game.Controller.IsPressed(ControllerButtonType.LeftButton))
			{
				AddOnions();
			}
		}
		if (_addedBeef || !_spine.InAttachment("Ground beef bowl glow", point.X, point.Y))
		{
			_spine.SetAlpha("Ground beef bowl glow", 0f);
		}
		else
		{
			SelectIngrediant("Ground beef highlight", EIngrediants.GroundBeef, _soundsOfBeef);
			if (base.Game.Controller.IsPressed(ControllerButtonType.LeftButton))
			{
				AddBeef();
			}
		}
		if (_addedCarrots || !_spine.InAttachment("Carrot bowl gold", point.X, point.Y))
		{
			_spine.SetAlpha("Carrot bowl gold", 0f);
		}
		else
		{
			SelectIngrediant("Carrot highlight", EIngrediants.Carrots, _soundsOfCarrots);
			if (base.Game.Controller.IsPressed(ControllerButtonType.LeftButton))
			{
				AddCarrots();
			}
		}
		if (!_addedTomatoe && _spine.InAttachment("Tomatoe bowl gold", point.X, point.Y))
		{
			SelectIngrediant("Tomatoe highlight", EIngrediants.TinnedTomatoes, _soundsOfTomatoe);
			if (base.Game.Controller.IsPressed(ControllerButtonType.LeftButton))
			{
				AddTomatoe();
			}
		}
		else
		{
			_spine.SetAlpha("Tomatoe bowl gold", 0f);
		}
		if (!_addedBayleaves && _spine.InAttachment("Bayleaves bowl glow", point.X, point.Y))
		{
			SelectIngrediant("Bay highlight", EIngrediants.Herbs, _soundsOfBay);
			if (base.Game.Controller.IsPressed(ControllerButtonType.LeftButton))
			{
				AddBayleaves();
			}
		}
		else
		{
			_spine.SetAlpha("Bayleaves bowl glow", 0f);
		}
	}

	private void SelectIngrediant(string animation, EIngrediants ingrediant, RandomSoundEffect sounds)
	{
		if (_pendingIngrediant != ingrediant)
		{
			sounds.PlayNext();
			_spine.StartAnimation(animation);
		}
		_pendingIngrediant = ingrediant;
	}

	public void AddOnions()
	{
		if (!_mixing && !_addedOnions)
		{
			_mixing = true;
			_soundsOfAdd.PlayNext();
			_spine.StartAnimation("OnionsGarlic toss", delegate
			{
				_addedOnions = true;
				MixIngrediant(EIngrediants.OnionsGarlic);
			});
		}
	}

	public void AddBeef()
	{
		if (!_mixing && !_addedBeef)
		{
			_mixing = true;
			_soundsOfAdd.PlayNext();
			_spine.StartAnimation("Ground beef toss", delegate
			{
				_addedBeef = true;
				MixIngrediant(EIngrediants.GroundBeef);
			});
		}
	}

	public void AddCarrots()
	{
		if (!_mixing && !_addedCarrots)
		{
			_mixing = true;
			_soundsOfAdd.PlayNext();
			_spine.StartAnimation("Carrot toss", delegate
			{
				_addedCarrots = true;
				MixIngrediant(EIngrediants.Carrots);
			});
		}
	}

	public void AddTomatoe()
	{
		if (!_mixing && !_addedTomatoe)
		{
			_mixing = true;
			_soundsOfAdd.PlayNext();
			_spine.StartAnimation("Tomatoe toss", delegate
			{
				_addedTomatoe = true;
				MixIngrediant(EIngrediants.TinnedTomatoes);
			});
		}
	}

	public void AddBayleaves()
	{
		if (!_mixing && !_addedBayleaves)
		{
			_mixing = true;
			_soundsOfAdd.PlayNext();
			_spine.StartAnimation("Bay toss", delegate
			{
				_addedBayleaves = true;
				MixIngrediant(EIngrediants.Herbs);
			});
		}
	}

	private void MixIngrediant(EIngrediants ingrediant)
	{
		_spine.RestartAnimation();
		if (ingrediant == EIngrediants.Pasta)
		{
			_spine.StartAnimation("Ingrediant mixing", delegate
			{
				MakeBurned();
				_spine.StartAnimation("Shits burning", Click);
			});
		}
		else
		{
			_ingrediants.Add(ingrediant);
			_spine.StartAnimation("Ingrediant mixing", EndAnimation);
		}
	}

	private void MakeBurned()
	{
		_soundsOfBurning.PlayNext();
		_burned = true;
		_ticks = 0f;
		_overlay.IsVisible = true;
	}

	private void Click()
	{
		_burned = false;
		_overlay.IsVisible = false;
		_time = _ticks;
		_spine.ResetAnimation();
		EndAnimation();
	}

	private void EndAnimation()
	{
		if (_pastaAppeared)
		{
			Completable = true;
		}
		else if (_ingrediants.Count >= IngrediantCount)
		{
			AddPasta();
		}
		else
		{
			_mixing = false;
		}
	}

	private void AddPasta()
	{
		_pastaAppeared = true;
		_soundsOfAdd.PlayNext();
		MixIngrediant(EIngrediants.Pasta);
	}

	public void ShowResult()
	{
		IsDone = false;
		FadingMediaPlayer.ApplyNow(0f);
		base.Game.Fader.FadeOut(delegate
		{
			_soundsOfDrum.PlayNext();
			_requestedResult = true;
		});
	}

	private void ApplyResultWithFade()
	{
		int fails = 0;
		for (int i = 0, j = 0; i < _ingrediants.Count; i++)
		{
			EIngrediants ingrediant = _ingrediants[i];
			if (ingrediant == (EIngrediants)j)
			{
				j++;
			}
			else
			{
				fails++;
			}
		}
		bool isPoor;
		bool isPerfect;
		if (!(_time < ColdTime) && _time <= FryTime)
		{
			switch (fails)
			{
				default:
					isPoor = true;
					isPerfect = false;
					break;
				case 1:
				case 2:
					isPoor = false;
					isPerfect = false;
					break;
				case 0:
					isPoor = false;
					isPerfect = true;
					break;
			}
		}
		else
		{
			isPoor = true;
			isPerfect = false;
		}
		PlayerPreferences.GetPlayerData().SetFlag("Pasta.Poor", isPoor);
		PlayerPreferences.GetPlayerData().SetFlag("Pasta.Perfect", isPerfect);
		_backgroundBad.Visible = isPoor;
		_backgroundOkay.Visible = !isPoor && !isPerfect;
		_backgroundGreat.Visible = isPerfect;
		base.Game.Fader.FadeIn(delegate
		{
			if (isPerfect)
			{
				base.Game.Achievements.TriggerAchievement(Achievements.AchievementGeneric11);
				_soundsOfGreat.PlayNext();
			}
			else if (isPoor)
			{
				_soundsOfBad.PlayNext();
			}
			else
			{
				_soundsOfOkay.PlayNext();
			}
			IsDone = true;
		});
	}
}
