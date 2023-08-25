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
		private readonly ButtonInteractable interactable;

		public bool IsVisible
		{
			set
			{
				interactable.IsVisible = value;
			}
		}

		public GUI(IAmorous game, Action action) : base(game)
		{
			interactable = AddButtonInteractable("Assets/Scenes/Cooking/Button", "Assets/Scenes/Cooking/Button hover", "Assets/Gui/Fonts/Bold-26", "Stop cooking!", Color.White, 832, 970, new Rectangle(832, 970, 256, 102), action);
			interactable.IsVisible = false;
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

	private const int INGREDIANTS = 5;
	private const float COLD_TIME = 2.5f;
	private const float FRY_TIME = 4.5f;

	private readonly GUI overlay;
	private readonly SkeletonRenderer skeleton;
	private readonly RandomSoundEffect soundsOfSpan;
	private readonly RandomSoundEffect soundsOfAdd;
	private readonly RandomSoundEffect soundsOfOnion;
	private readonly RandomSoundEffect soundsOfBeef;
	private readonly RandomSoundEffect soundsOfCarrots;
	private readonly RandomSoundEffect soundsOfTomatoe;
	private readonly RandomSoundEffect soundsOfBay;
	private readonly RandomSoundEffect soundsOfBurning;
	private readonly RandomSoundEffect soundsOfDrum;
	private readonly RandomSoundEffect soundsOfBad;
	private readonly RandomSoundEffect soundsOfOkay;
	private readonly RandomSoundEffect soundsOfGreat;
	private readonly AbstractLayer badOverlayLayer;
	private readonly AbstractLayer okayOverlayLayer;
	private readonly AbstractLayer greatOverlayLayer;
	private bool pastaAppeared;
	private bool addedOnions;
	private bool addedBeef;
	private bool addedCarrots;
	private bool addedTomatoe;
	private bool addedBayleaves;
	private EIngrediants pendingIngrediant;
	private bool burned;
	private float ticks;
	private bool spawning;
	private bool mixing;
	private bool requestedResult;
	private float fadingOut;
	private List<EIngrediants> ingrediants;
	private float seconds;

	public bool IsSelectingIngredient { get; set; }
	public bool IsSelectingIngredientCompleted { get; set; }
	public bool IsShowingResultCompleted { get; set; }

	public CookingMiniGameScene(IAmorous game) : base(game)
	{
		overlay = new GUI(game, Click);
		base.Game.SetOverlay(overlay);
		AddSpriteLayer("Background", "Assets/Scenes/Cooking/Background", 0, 0);
		badOverlayLayer = AddSpriteLayerAbove("Background", "Assets/Scenes/Cooking/Bad", 0, 0);
		badOverlayLayer.Visible = false;
		okayOverlayLayer = AddSpriteLayerAbove("Background", "Assets/Scenes/Cooking/Okay", 0, 0);
		okayOverlayLayer.Visible = false;
		greatOverlayLayer = AddSpriteLayerAbove("Background", "Assets/Scenes/Cooking/Excellent", 0, 0);
		greatOverlayLayer.Visible = false;
		SpineDrawableLayer spineLayer = new SpineDrawableLayer(this, "Cooking");
		skeleton = game.Content.LoadSkeleton("Assets/Scenes/Cooking/Cooking");
		skeleton.X = 960f;
		skeleton.Y = 540f;
		soundsOfSpan = new RandomSoundEffect(game.Content);
		soundsOfSpan.Append("Assets/Sounds/MiniGames/Cooking/Pan spawn");
		soundsOfAdd = new RandomSoundEffect(game.Content);
		soundsOfAdd.Append("Assets/Sounds/MiniGames/Cooking/Add ingrediant");
		soundsOfOnion = new RandomSoundEffect(game.Content);
		soundsOfOnion.Append("Assets/Sounds/MiniGames/Cooking/Onion");
		soundsOfBeef = new RandomSoundEffect(game.Content);
		soundsOfBeef.Append("Assets/Sounds/MiniGames/Cooking/Beef");
		soundsOfCarrots = new RandomSoundEffect(game.Content);
		soundsOfCarrots.Append("Assets/Sounds/MiniGames/Cooking/Carrots");
		soundsOfTomatoe = new RandomSoundEffect(game.Content);
		soundsOfTomatoe.Append("Assets/Sounds/MiniGames/Cooking/Tomatoe");
		soundsOfBay = new RandomSoundEffect(game.Content);
		soundsOfBay.Append("Assets/Sounds/MiniGames/Cooking/Bay leaves");
		soundsOfBurning = new RandomSoundEffect(game.Content);
		soundsOfBurning.Append("Assets/Sounds/MiniGames/Cooking/Burning");
		soundsOfDrum = new RandomSoundEffect(game.Content);
		soundsOfDrum.Append("Assets/Sounds/MiniGames/Cooking/Drum roll");
		soundsOfBad = new RandomSoundEffect(game.Content);
		soundsOfBad.Append("Assets/Sounds/MiniGames/Cooking/Bad food");
		soundsOfOkay = new RandomSoundEffect(game.Content);
		soundsOfOkay.Append("Assets/Sounds/MiniGames/Cooking/Ok food");
		soundsOfGreat = new RandomSoundEffect(game.Content);
		soundsOfGreat.Append("Assets/Sounds/MiniGames/Cooking/Great food");
		RefreshSubscene();
		spineLayer.OnUpdate = delegate(GameTime gameTime)
		{
			skeleton.Update(gameTime);
		};
		spineLayer.OnSpineDraw = delegate(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer)
		{
			skeleton.Draw(skeletonMeshRenderer, null, BeforeRenderSlot);
		};
		AddLayer(spineLayer, 0);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.FreeFloatingTrack, 0.1f);
	}

	private bool BeforeRenderSlot(int index, string slotName)
	{
		switch (slotName)
		{
			case "Pasta":
				return pastaAppeared;
			case "Onions bowl shadow":
			case "Onions bowl glow":
			case "Onions bowl":
				return !addedOnions;
			default:
				return true;
			case "BayThyme 1":
			case "BayThyme 2":
				return addedBayleaves;
			case "Bayleaves bowl shadow":
			case "Bayleaves bowl glow":
			case "Bayleaves bowl":
				return !addedBayleaves;
			case "Sauce 1":
			case "Sauce 2":
				return addedTomatoe;
			case "Tomatoe bowl shadow":
			case "Tomatoe bowl glow":
			case "Tomatoe bowl":
				return !addedTomatoe;
			case "Carrots 1":
			case "Carrots 2":
				return addedCarrots;
			case "Carrot bowl shadow":
			case "Carrot bowl glow":
			case "Carrot bowl":
				return !addedCarrots;
			case "Ground Beef 1":
			case "Ground Beef 2":
				return addedBeef;
			case "Ground beef bowl shadow":
			case "Ground beef bowl glow":
			case "Ground beef bowl":
				return !addedBeef;
			case "OnionsGarlic 1":
			case "OnionsGarlic 2":
				return addedOnions;
		}
	}

	private void RefreshSubscene()
	{
		spawning = true;
		pastaAppeared = false;
		addedOnions = false;
		addedBeef = false;
		addedCarrots = false;
		addedTomatoe = false;
		addedBayleaves = false;
		ingrediants = new List<EIngrediants>();
		skeleton.SetVisibility(0f);
		soundsOfSpan.PlayNext();
		skeleton.StartAnimation("Pan spawn", delegate
		{
			spawning = false;
		});
		pendingIngrediant = EIngrediants.None;
	}

	public override void Update(GameTime gameTime)
	{
		base.Update(gameTime);
		if (requestedResult)
		{
			fadingOut += (float)gameTime.ElapsedGameTime.Milliseconds / 1000f;
			if (fadingOut > 3f)
			{
				requestedResult = false;
				ApplyResultWithFade();
			}
		}
		if (IsSelectingIngredientCompleted || !IsSelectingIngredient)
		{
			return;
		}
		if (burned)
		{
			ticks += (float)gameTime.ElapsedGameTime.Milliseconds / 1000f;
		}
		if (spawning || mixing || pastaAppeared)
		{
			return;
		}
		Point cursor = base.Game.Canvas.GlobalToContent(base.Game.Controller.Cursor);
		if (addedOnions || !skeleton.Innersects("Onions bowl glow", cursor.X, cursor.Y))
		{
			skeleton.SetAlpha("Onions bowl glow", 0f);
		}
		else
		{
			SelectIngrediant("OnionsGarlic highlight", EIngrediants.OnionsGarlic, soundsOfOnion);
			if (base.Game.Controller.IsPressed(ControllerButtonType.LeftButton))
			{
				AddOnions();
			}
		}
		if (addedBeef || !skeleton.Innersects("Ground beef bowl glow", cursor.X, cursor.Y))
		{
			skeleton.SetAlpha("Ground beef bowl glow", 0f);
		}
		else
		{
			SelectIngrediant("Ground beef highlight", EIngrediants.GroundBeef, soundsOfBeef);
			if (base.Game.Controller.IsPressed(ControllerButtonType.LeftButton))
			{
				AddBeef();
			}
		}
		if (addedCarrots || !skeleton.Innersects("Carrot bowl gold", cursor.X, cursor.Y))
		{
			skeleton.SetAlpha("Carrot bowl gold", 0f);
		}
		else
		{
			SelectIngrediant("Carrot highlight", EIngrediants.Carrots, soundsOfCarrots);
			if (base.Game.Controller.IsPressed(ControllerButtonType.LeftButton))
			{
				AddCarrots();
			}
		}
		if (!addedTomatoe && skeleton.Innersects("Tomatoe bowl gold", cursor.X, cursor.Y))
		{
			SelectIngrediant("Tomatoe highlight", EIngrediants.TinnedTomatoes, soundsOfTomatoe);
			if (base.Game.Controller.IsPressed(ControllerButtonType.LeftButton))
			{
				AddTomatoe();
			}
		}
		else
		{
			skeleton.SetAlpha("Tomatoe bowl gold", 0f);
		}
		if (!addedBayleaves && skeleton.Innersects("Bayleaves bowl glow", cursor.X, cursor.Y))
		{
			SelectIngrediant("Bay highlight", EIngrediants.Herbs, soundsOfBay);
			if (base.Game.Controller.IsPressed(ControllerButtonType.LeftButton))
			{
				AddBayleaves();
			}
		}
		else
		{
			skeleton.SetAlpha("Bayleaves bowl glow", 0f);
		}
	}

	private void SelectIngrediant(string animation, EIngrediants ingrediant, RandomSoundEffect sounds)
	{
		if (pendingIngrediant != ingrediant)
		{
			sounds.PlayNext();
			skeleton.StartAnimation(animation);
		}
		pendingIngrediant = ingrediant;
	}

	public void AddOnions()
	{
		if (!mixing && !addedOnions)
		{
			mixing = true;
			soundsOfAdd.PlayNext();
			skeleton.StartAnimation("OnionsGarlic toss", delegate
			{
				addedOnions = true;
				MixIngrediant(EIngrediants.OnionsGarlic);
			});
		}
	}

	public void AddBeef()
	{
		if (!mixing && !addedBeef)
		{
			mixing = true;
			soundsOfAdd.PlayNext();
			skeleton.StartAnimation("Ground beef toss", delegate
			{
				addedBeef = true;
				MixIngrediant(EIngrediants.GroundBeef);
			});
		}
	}

	public void AddCarrots()
	{
		if (!mixing && !addedCarrots)
		{
			mixing = true;
			soundsOfAdd.PlayNext();
			skeleton.StartAnimation("Carrot toss", delegate
			{
				addedCarrots = true;
				MixIngrediant(EIngrediants.Carrots);
			});
		}
	}

	public void AddTomatoe()
	{
		if (!mixing && !addedTomatoe)
		{
			mixing = true;
			soundsOfAdd.PlayNext();
			skeleton.StartAnimation("Tomatoe toss", delegate
			{
				addedTomatoe = true;
				MixIngrediant(EIngrediants.TinnedTomatoes);
			});
		}
	}

	public void AddBayleaves()
	{
		if (!mixing && !addedBayleaves)
		{
			mixing = true;
			soundsOfAdd.PlayNext();
			skeleton.StartAnimation("Bay toss", delegate
			{
				addedBayleaves = true;
				MixIngrediant(EIngrediants.Herbs);
			});
		}
	}

	private void MixIngrediant(EIngrediants ingrediant)
	{
		skeleton.RestartAnimation();
		if (ingrediant == EIngrediants.Pasta)
		{
			skeleton.StartAnimation("Ingrediant mixing", delegate
			{
				MakeBurned();
				skeleton.StartAnimation("Shits burning", Click);
			});
		}
		else
		{
			ingrediants.Add(ingrediant);
			skeleton.StartAnimation("Ingrediant mixing", EndAnimation);
		}
	}

	private void MakeBurned()
	{
		soundsOfBurning.PlayNext();
		burned = true;
		ticks = 0f;
		overlay.IsVisible = true;
	}

	private void Click()
	{
		burned = false;
		overlay.IsVisible = false;
		seconds = ticks;
		skeleton.ResetAnimation();
		EndAnimation();
	}

	private void EndAnimation()
	{
		if (pastaAppeared)
		{
			IsSelectingIngredientCompleted = true;
		}
		else if (ingrediants.Count >= INGREDIANTS)
		{
			AddPasta();
		}
		else
		{
			mixing = false;
		}
	}

	private void AddPasta()
	{
		pastaAppeared = true;
		soundsOfAdd.PlayNext();
		MixIngrediant(EIngrediants.Pasta);
	}

	public void ShowResult()
	{
		IsShowingResultCompleted = false;
		FadingMediaPlayer.ApplyWithoutFading(0f);
		base.Game.Fader.FadeOut(delegate
		{
			soundsOfDrum.PlayNext();
			requestedResult = true;
		});
	}

	private void ApplyResultWithFade()
	{
		int fails = 0;
		for (int i = 0, j = 0; i < ingrediants.Count; i++)
		{
			EIngrediants ingrediant = ingrediants[i];
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
		if (!(seconds < COLD_TIME) && seconds <= FRY_TIME)
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
		PlayerPreferences.GetPlayerData().InsertFlag("Pasta.Poor", isPoor);
		PlayerPreferences.GetPlayerData().InsertFlag("Pasta.Perfect", isPerfect);
		badOverlayLayer.Visible = isPoor;
		okayOverlayLayer.Visible = !isPoor && !isPerfect;
		greatOverlayLayer.Visible = isPerfect;
		base.Game.Fader.FadeIn(delegate
		{
			if (isPerfect)
			{
				base.Game.Achievements.TriggerAchievement(Achievements.AchievementGeneric11);
				soundsOfGreat.PlayNext();
			}
			else if (isPoor)
			{
				soundsOfBad.PlayNext();
			}
			else
			{
				soundsOfOkay.PlayNext();
			}
			IsShowingResultCompleted = true;
		});
	}
}
