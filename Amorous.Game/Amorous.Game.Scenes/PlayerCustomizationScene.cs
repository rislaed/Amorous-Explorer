using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Squid;

namespace Amorous.Game.Scenes;

public class PlayerCustomizationScene : AbstractScene
{
	private class SexsceneData
	{
		public string Name { get; }
		public string Scene { get; }

		public SexsceneData(string name, string scene)
		{
			Name = name;
			Scene = scene;
		}
	}

	protected bool MightEnterName;

	private CustomizablePlayerSkin _skin;
	private Panel _backgroundContainer;
	private List<Button> _categories;
	private Panel _foregroundContainer;
	private readonly PlayerDataProxy _data;
	private Window _colorPicker;
	private readonly Effect _effect;

	private readonly List<SexsceneData> _sexscenes = new List<SexsceneData>
	{
		new SexsceneData("None", null),
		new SexsceneData("Coby", "CobySexscene"),
		new SexsceneData("Dustin", "DustinSexscene"),
		new SexsceneData("Jax", "JaxSexscene"),
		new SexsceneData("Lex", "LexSexscene"),
		new SexsceneData("Mercy", "MercySexscene"),
		new SexsceneData("Remy", "RemySexscene"),
		new SexsceneData("Seth", "SethSexscene"),
		new SexsceneData("Skye", "SkyeSexscene"),
		new SexsceneData("Zenith", "ZenithSexscene")
	};

	private readonly string[] _sexsceneNames;
	private int _sexsceneIndex;
	private int _templateStockIndex;
	private int _templateCustomIndex;

	protected virtual string ReturnToGameText => "Exit";

	public PlayerCustomizationScene(IAmorous game)
		: base(game)
	{
		AddSpriteLayer("Background", "Assets/Scenes/Bedroom/Bedroom", -458, 0);
		AddLayer(new DrawableLayer(this, "Custom")
		{
			OnDraw = DrawSkin
		}, 0);
		_sexsceneNames = _sexscenes.Select((SexsceneData sexscene) => sexscene.Name).ToArray();
		_data = new PlayerDataProxy(PlayerPreferences.GetPlayerData());
		_data.OnChange += delegate
		{
			if (base.Game.Sexscene != null)
			{
				base.Game.Sexscene.RefreshSubscene();
			}
		};
		FadingMediaPlayer.PlayOnRepeat(AmorousData.MidnightSizzleTrack, 0.4f);
		_effect = Game.Content.Load<Effect>("Assets/Shaders/Breathing");
	}

	public override void Start()
	{
		_skin = new CustomizablePlayerSkin(base.Game);
		FetchTemplates();
		PlayerPreferences.SetPlayerOverlay(_skin);
		ShowOverlay();
	}

	protected virtual void FetchTemplates()
	{
		if (_skin.CustomTemplates.Any())
		{
			_skin.CloneCustomTemplate(0);
			_data.Name = _skin.GetCustomTemplateName(0);
			_templateCustomIndex = 0;
		}
		else
		{
			_skin.CloneStockTemplate(0);
			_data.Name = "Player";
			_templateCustomIndex = -1;
		}
	}

	private void ShowOverlay()
	{
		Window container = new Window
		{
			Dock = DockStyle.Right,
			Size = new Squid.Point(512, 0),
			Margin = new Margin(8),
			Padding = new Margin(8)
		};
		_backgroundContainer = new Panel
		{
			Dock = DockStyle.Fill
		};
		container.Controls.Add(_backgroundContainer);
		_foregroundContainer = new Panel();
		_foregroundContainer.Dock = DockStyle.Fill;
		_foregroundContainer.ClipFrame.Margin = new Margin(8);
		_categories = new List<Button>
		{
			NewCategory("Fursona", delegate
			{
				AttachFursonaCategory(_foregroundContainer.Content.Controls);
			}),
			NewCategory("Body", delegate
			{
				AttachBodyCategory(_foregroundContainer.Content.Controls);
			}),
			NewCategory("Arms", delegate
			{
				AttachArmsCategory(_foregroundContainer.Content.Controls);
			}),
			NewCategory("Legs", delegate
			{
				AttachLegsCategory(_foregroundContainer.Content.Controls);
			}),
			NewCategory("Head", delegate
			{
				AttachHeadCategory(_foregroundContainer.Content.Controls);
			}),
			NewCategory("Muzzle", delegate
			{
				AttachMuzzleCategory(_foregroundContainer.Content.Controls);
			}),
			NewCategory("Ears and Horns", delegate
			{
				AttachEarsAndHornsCategory(_foregroundContainer.Content.Controls);
			}),
			NewCategory("Hair and Fringes", delegate
			{
				AttachHairAndFringesCategory(_foregroundContainer.Content.Controls);
			}),
			NewCategory("Eyes and Brows", delegate
			{
				AttachEyesAndBrowsCategory(_foregroundContainer.Content.Controls);
			})
		};
		if (!Censorship.Censored)
		{
			_categories.Add(NewCategory("Breasts, Cock and Balls", delegate
			{
				AttachBreastsCockAndBallsCategory(_foregroundContainer.Content.Controls);
			}));
		}
		_categories.Add(NewCategory("Tail", delegate
		{
			AttachTailCategory(_foregroundContainer.Content.Controls);
		}));
		_categories.Add(NewCategory("Feet", delegate
		{
			AttachFeetCategory(_foregroundContainer.Content.Controls);
		}));
		container.Show(base.Squid);
		_categories[0].Click(0);
	}

	private void AttachFursonaCategory(ControlCollection container)
	{
		container.Add(new Label
		{
			Dock = DockStyle.Top,
			Text = "Name"
		});
		TextBox templateName = new TextBox
		{
			Dock = DockStyle.Top,
			Text = _data.Name,
			Margin = new Margin(0, 0, 0, 5)
		};
		templateName.TextChanged += delegate
		{
			_data.Name = templateName.Text;
		};
		container.Add(templateName);
		AttachDropDown(container, "Stock Templates", _skin.StockTemplates.Select((PlayerCustomizationData configuration) => configuration.Name).ToArray(), _templateStockIndex, delegate(int int_0)
		{
			_templateStockIndex = int_0;
			_skin.CloneStockTemplate(int_0);
			_foregroundContainer.Content.Controls.Clear();
			AttachFursonaCategory(container);
			if (base.Game.Sexscene != null)
			{
				base.Game.Sexscene.RefreshSubscene();
			}
		});
		AttachDropDown(container, "Your Templates", _skin.CustomTemplates.Select((PlayerCustomizationData configuration) => configuration.Name).ToArray(), _templateCustomIndex, delegate(int index)
		{
			_templateCustomIndex = index;
			_skin.CloneCustomTemplate(index);
			_data.Name = _skin.GetCustomTemplateName(index);
			_foregroundContainer.Content.Controls.Clear();
			AttachFursonaCategory(container);
			if (base.Game.Sexscene != null)
			{
				base.Game.Sexscene.RefreshSubscene();
			}
		});
		Control phoneColorControl = AttachColorPicker(container, "Phone", _data.PhoneColor, delegate(Color color)
		{
			_data.PhoneColor = color;
		});
		phoneColorControl.Margin = new Margin(0, 5, 0, 0);
		Button createButton = new Button
		{
			Margin = new Margin(0, 10, 0, 0),
			Dock = DockStyle.Top,
			Text = "New Template"
		};
		createButton.MouseClick += delegate
		{
			if (string.IsNullOrWhiteSpace(templateName.Text))
			{
				base.Squid.ShowConfirm("You did not enter a name!", AmorousData.ShortDialogueOffset);
			}
			else
			{
				ShowQuestion($"Are you sure you wish to create a new template with the name '{templateName.Text}', based on the current character?", delegate
				{
					_skin.AddCustomTemplate(templateName.Text, _data.GetPlayerData());
					_templateCustomIndex = _skin.CustomTemplates.Count() - 1;
					_skin.CloneCustomTemplate(_templateCustomIndex);
					_data.Name = _skin.GetCustomTemplateName(_templateCustomIndex);
					_foregroundContainer.Content.Controls.Clear();
					AttachFursonaCategory(container);
				});
			}
		};
		container.Add(createButton);
		Button saveButton = new Button
		{
			Dock = DockStyle.Top,
			Text = "Save Template"
		};
		saveButton.MouseClick += delegate
		{
			if (string.IsNullOrWhiteSpace(templateName.Text))
			{
				base.Squid.ShowConfirm("You did not enter a name!", AmorousData.ShortDialogueOffset);
			}
			else if (_templateCustomIndex >= 0)
			{
				ShowQuestion($"Are you sure you wish to save the currect character to the selected template '{_skin.GetCustomTemplateName(_templateCustomIndex)}'?", delegate
				{
					_skin.AddCustomTemplateAtIndex(templateName.Text, _templateCustomIndex, _data.GetPlayerData());
					_foregroundContainer.Content.Controls.Clear();
					AttachFursonaCategory(container);
				});
			}
			else
			{
				ShowQuestion($"No template has been selected yet, do you wish to create a new template with the name '{templateName.Text}', based on the current character?", delegate
				{
					_skin.AddCustomTemplate(templateName.Text, _data.GetPlayerData());
					_templateCustomIndex = _skin.CustomTemplates.Count() - 1;
					_skin.CloneCustomTemplate(_templateCustomIndex);
					_data.Name = _skin.GetCustomTemplateName(_templateCustomIndex);
					_foregroundContainer.Content.Controls.Clear();
					AttachFursonaCategory(container);
				});
			}
		};
		container.Add(saveButton);
		Button resetButton = new Button
		{
			Dock = DockStyle.Top,
			Text = "Reset Template"
		};
		resetButton.MouseClick += delegate
		{
			if (_templateCustomIndex >= 0)
			{
				ShowQuestion($"Are you sure you wish to reset the current character back to selected template '{_skin.GetCustomTemplateName(_templateCustomIndex)}'? All changes will be lost!", delegate
				{
					_skin.ResetCustomTemplate(_templateCustomIndex);
					_data.Name = _skin.GetCustomTemplateName(_templateCustomIndex);
					_foregroundContainer.Content.Controls.Clear();
					AttachFursonaCategory(container);
				});
			}
			else
			{
				base.Squid.ShowConfirm("You did not select a template!", AmorousData.ShortDialogueOffset);
			}
		};
		container.Add(resetButton);
		Button button4 = new Button
		{
			Dock = DockStyle.Top,
			Text = "Delete Template"
		};
		button4.MouseClick += delegate
		{
			if (_templateCustomIndex >= 0)
			{
				ShowQuestion($"Are you sure you wish to delete the selected template '{_skin.GetCustomTemplateName(_templateCustomIndex)}'?", delegate
				{
					_skin.RemoveCustomTemplate(_templateCustomIndex);
					_templateCustomIndex = -1;
					_foregroundContainer.Content.Controls.Clear();
					AttachFursonaCategory(container);
				});
			}
			else
			{
				base.Squid.ShowConfirm("You did not select a template!", AmorousData.ShortDialogueOffset);
			}
		};
		container.Add(button4);
		Button zoomButton = new Button
		{
			Margin = new Margin(0, 10, 0, 0),
			Dock = DockStyle.Top,
			Text = "Toggle zoom"
		};
		zoomButton.MouseClick += delegate
		{
			_skin.ToggleZoom();
		};
		container.Add(zoomButton);
		if (!Censorship.Censored)
		{
			AttachDropDown(container, "Preview Sexscene", _sexsceneNames, _sexsceneIndex, delegate(int index)
			{
				_sexsceneIndex = index;
				if (index == 0)
				{
					base.Game.ResetSexscene();
				}
				else
				{
					base.Game.PlaySexscene(_sexscenes[index].Scene);
					base.Game.Sexscene.Muted = true;
				}
			});
		}
		if (!base.Squid.Skin.ContainsKey("button2"))
		{
			base.Squid.Skin.Add("button2", new ControlStyle(base.Squid.Skin["button"])
			{
				Tint = ColorInt.ARGB(1f, 0f, 1f, 0f)
			});
		}
		Button returnToGameButton = new Button
		{
			Margin = new Margin(0, 10, 0, 0),
			Dock = DockStyle.Top,
			Text = ReturnToGameText,
			Style = "button2"
		};
		returnToGameButton.MouseClick += delegate
		{
			if (MightEnterName && string.IsNullOrWhiteSpace(templateName.Text))
			{
				base.Squid.ShowConfirm("You did not enter a name!", AmorousData.ShortDialogueOffset);
			}
			else
			{
				ShowExit();
			}
		};
		container.Add(returnToGameButton);
	}

	private void ShowQuestion(string question, Action then)
	{
		base.Squid.ShowSelection(question, new string[2] { "No way!", "Yes please!" }, AmorousData.ShortDialogueOffset, delegate(int answer)
		{
			if (answer == 1)
			{
				then();
			}
		});
	}

	protected virtual void ShowExit()
	{
		base.Squid.ShowSelection("Are you sure you wish to exit? All unsaved changes will be lost!", new string[2] { "Oops, my bad!", "Yes please!" }, AmorousData.ShortDialogueOffset, delegate(int answer)
		{
			if (answer == 1)
			{
				base.Game.StartScene<MainMenuScene>();
			}
		});
	}

	private void AttachBodyCategory(ControlCollection container)
	{
		AttachTypesDropDown(container, "Body", _data.BodyType, delegate(PlayerData.EBodyType type)
		{
			_data.BodyType = type;
		});
		AttachColorPicker(container, "Body Color", _data.BodyColor, delegate(Color color)
		{
			_data.BodyColor = color;
		});
		AttachMarkingsColorPicker(container, "Underbelly Marking", PlayerData.EMarkingsType.Underbelly, _data.UnderbellyColor, delegate(Color color)
		{
			_data.UnderbellyColor = color;
		});
		AttachMarkingsColorPicker(container, "Underthigh Marking", PlayerData.EMarkingsType.Underthigh, _data.UnderthighColor, delegate(Color color)
		{
			_data.UnderthighColor = color;
		});
		AttachMarkingsColorPicker(container, "Stripes Marking", PlayerData.EMarkingsType.Stripes, _data.StripesColor, delegate(Color color)
		{
			_data.StripesColor = color;
		});
		AttachSwitchableColorPicker(container, "Nails", _data.ShowNails, _data.NailColor, delegate(bool enabled)
		{
			_data.ShowNails = enabled;
		}, delegate(Color color)
		{
			_data.NailColor = color;
		});
	}

	private void AttachArmsCategory(ControlCollection container)
	{
		AttachMarkingsColorPicker(container, "Long Forearm Marking", PlayerData.EMarkingsType.LongForearm, _data.LongForearmColor, delegate(Color color)
		{
			_data.LongForearmColor = color;
		});
		AttachMarkingsColorPicker(container, "Short Forearm Marking", PlayerData.EMarkingsType.ShortForearm, _data.ShortForearmColor, delegate(Color color)
		{
			_data.ShortForearmColor = color;
		});
		AttachMarkingsColorPicker(container, "Avian Forearm Marking", PlayerData.EMarkingsType.AvianForearm, _data.AvianForearmColor, delegate(Color color)
		{
			_data.AvianForearmColor = color;
		});
	}

	private void AttachLegsCategory(ControlCollection container)
	{
		AttachMarkingsColorPicker(container, "Long Shin Marking", PlayerData.EMarkingsType.LongShin, _data.LongShinColor, delegate(Color color)
		{
			_data.LongShinColor = color;
		});
		AttachMarkingsColorPicker(container, "Short Shin Marking", PlayerData.EMarkingsType.ShortShin, _data.ShortShinColor, delegate(Color color)
		{
			_data.ShortShinColor = color;
		});
		AttachMarkingsColorPicker(container, "Avian Shin Marking", PlayerData.EMarkingsType.AvianShin, _data.AvianShinColor, delegate(Color color)
		{
			_data.AvianShinColor = color;
		});
	}

	private void AttachHeadCategory(ControlCollection container)
	{
		Panel headPanel = new Panel
		{
			Dock = DockStyle.Fill,
			Visible = (_data.HeadType == PlayerData.EHeadType.Default)
		};
		Panel paperBagPanel = new Panel
		{
			Dock = DockStyle.Fill,
			Visible = (_data.HeadType == PlayerData.EHeadType.PaperBag)
		};
		AttachTypesDropDown(container, "Head", _data.HeadType, delegate(PlayerData.EHeadType type)
		{
			_data.HeadType = type;
			switch (type)
			{
				case PlayerData.EHeadType.Default:
					headPanel.Visible = true;
					paperBagPanel.Visible = false;
					break;
				case PlayerData.EHeadType.Humanoid:
					headPanel.Visible = false;
					paperBagPanel.Visible = false;
					break;
				case PlayerData.EHeadType.PaperBag:
					headPanel.Visible = false;
					paperBagPanel.Visible = true;
					break;
			}
		});
		AttachColorPicker(container, "Head Color", _data.HeadColor, delegate(Color color)
		{
			_data.HeadColor = color;
		});
		AttachHeadMarkingsColorPicker(headPanel.Content.Controls, "Gaunt Marking", PlayerData.EHeadMarkingsType.Gaunt, _data.HeadGauntColor, delegate(Color color)
		{
			_data.HeadGauntColor = color;
		});
		AttachHeadMarkingsColorPicker(headPanel.Content.Controls, "Scruffy Marking", PlayerData.EHeadMarkingsType.Scruffy, _data.HeadScruffyColor, delegate(Color color)
		{
			_data.HeadScruffyColor = color;
		});
		AttachHeadMarkingsColorPicker(headPanel.Content.Controls, "Snout Marking", PlayerData.EHeadMarkingsType.Snout, _data.HeadSnoutColor, delegate(Color color)
		{
			_data.HeadSnoutColor = color;
		});
		AttachHeadMarkingsColorPicker(headPanel.Content.Controls, "Stripes Marking", PlayerData.EHeadMarkingsType.Stripes, _data.HeadStripesColor, delegate(Color color)
		{
			_data.HeadStripesColor = color;
		});
		AttachColorPicker(paperBagPanel.Content.Controls, "Paper Bag Color", _data.PaperBagColor, delegate(Color color)
		{
			_data.PaperBagColor = color;
		});
		AttachColorPicker(paperBagPanel.Content.Controls, "Eyesholes Color", _data.PaperBagEyesColor, delegate(Color color)
		{
			_data.PaperBagEyesColor = color;
		});
		container.Add(headPanel);
		container.Add(paperBagPanel);
	}

	private void AttachMuzzleCategory(ControlCollection container)
	{
		AttachTypesDropDown(container, "Muzzle", _data.MuzzleType, delegate(PlayerData.EMuzzleType type)
		{
			_data.MuzzleType = type;
		});
		AttachColorPicker(container, "Muzzle Color", _data.MuzzleColor, delegate(Color color)
		{
			_data.MuzzleColor = color;
		});
		AttachColorPicker(container, "Nose Color", _data.NoseColor, delegate(Color color)
		{
			_data.NoseColor = color;
		});
		AttachColorPicker(container, "Teeth Color", _data.TeethColor, delegate(Color color)
		{
			_data.TeethColor = color;
		});
		AttachSwitchableColorPicker(container, "Muzzle Horn", _data.ShowMuzzleHorn, _data.MuzzleHornColor, delegate(bool enabled)
		{
			_data.ShowMuzzleHorn = enabled;
		}, delegate(Color color)
		{
			_data.MuzzleHornColor = color;
		});
		AttachSwitchableColorPicker(container, "Muzzle Mask", _data.ShowMuzzleMask, _data.MuzzleMaskColor, delegate(bool enabled)
		{
			_data.ShowMuzzleMask = enabled;
		}, delegate(Color color)
		{
			_data.MuzzleMaskColor = color;
		});
	}

	private void AttachEarsAndHornsCategory(ControlCollection container)
	{
		AttachTypesDropDown(container, "Ears and Horns", _data.HeadAccessoriesType, delegate(PlayerData.EHeadAccessoriesType type)
		{
			_data.HeadAccessoriesType = type;
		});
		AttachColorPicker(container, "Horns Color", _data.HeadHornsColor, delegate(Color color)
		{
			_data.HeadHornsColor = color;
		});
		AttachColorPicker(container, "Ear Color", _data.EarColor, delegate(Color color)
		{
			_data.EarColor = color;
		});
		AttachColorPicker(container, "Ear Inner Color", _data.EarInnerColor, delegate(Color color)
		{
			_data.EarInnerColor = color;
		});
	}

	private void AttachHairAndFringesCategory(ControlCollection container)
	{
		AttachTypesDropDown(container, "Hair", _data.HairstyleType, delegate(PlayerData.EHairstyleType type)
		{
			_data.HairstyleType = type;
		});
		AttachColorPicker(container, "Hair Color", _data.HairColor, delegate(Color color)
		{
			_data.HairColor = color;
		});
		AttachTypesDropDown(container, "Fringe", _data.FringeType, delegate(PlayerData.EFringeType type)
		{
			_data.FringeType = type;
		});
		AttachColorPicker(container, "Fringe Color", _data.FringeColor, delegate(Color color)
		{
			_data.FringeColor = color;
		});
	}

	private void AttachEyesAndBrowsCategory(ControlCollection container)
	{
		AttachTypesDropDown(container, "Eyes", _data.EyesType, delegate(PlayerData.EEyesType type)
		{
			_data.EyesType = type;
		});
		AttachColorPicker(container, "Eyes Back Color", _data.EyesBackColor, delegate(Color color)
		{
			_data.EyesBackColor = color;
		});
		AttachColorPicker(container, "Eyes Front Color", _data.EyesFrontColor, delegate(Color color)
		{
			_data.EyesFrontColor = color;
		});
		AttachTypesDropDown(container, "Brows", _data.BrowType, delegate(PlayerData.EBrowType type)
		{
			_data.BrowType = type;
		});
		AttachColorPicker(container, "Brows Color", _data.BrowColor, delegate(Color color)
		{
			_data.BrowColor = color;
		});
	}

	private void AttachBreastsCockAndBallsCategory(ControlCollection container)
	{
		Panel breastPanel = new Panel
		{
			Dock = DockStyle.Top,
			Visible = (_data.BreastsType != PlayerData.EBreastsType.None)
		};
		Panel cockPanel = new Panel
		{
			Dock = DockStyle.Top,
			Visible = (_data.CockType != PlayerData.ECockType.None)
		};
		Panel ballsPanel = new Panel
		{
			Dock = DockStyle.Top,
			Visible = (_data.BallsType != PlayerData.EBallsType.None)
		};
		AttachTypesDropDown(container, "Breasts", _data.BreastsType, delegate(PlayerData.EBreastsType type)
		{
			_data.BreastsType = type;
			breastPanel.Visible = _data.BreastsType != PlayerData.EBreastsType.None;
		});
		AttachColorPicker(breastPanel.Content.Controls, "Breasts Color", _data.BreastsColor, delegate(Color color)
		{
			_data.BreastsColor = color;
		});
		AttachSwitchableColorPicker(breastPanel.Content.Controls, "Nipples", _data.ShowNipples, _data.NipplesColor, delegate(bool enabled)
		{
			_data.ShowNipples = enabled;
		}, delegate(Color color)
		{
			_data.NipplesColor = color;
		});
		container.Add(breastPanel);
		Control cockColorControl = null;
		AttachTypesDropDown(container, "Cock", _data.CockType, delegate(PlayerData.ECockType type)
		{
			_data.CockType = type;
			cockPanel.Visible = _data.CockType != PlayerData.ECockType.None;
			cockColorControl.Visible = _data.CockType == PlayerData.ECockType.Cut || _data.CockType == PlayerData.ECockType.Uncut;
		});
		AttachColorPicker(cockPanel.Content.Controls, "Cock Color", _data.GenitaliaColor, delegate(Color color)
		{
			_data.GenitaliaColor = color;
		});
		cockColorControl = AttachColorPicker(cockPanel.Content.Controls, "Cock Tip Color", _data.GenitaliaFleshColor, delegate(Color color)
		{
			_data.GenitaliaFleshColor = color;
		});
		cockColorControl.Visible = _data.CockType == PlayerData.ECockType.Cut || _data.CockType == PlayerData.ECockType.Uncut;
		container.Add(cockPanel);
		AttachTypesDropDown(container, "Balls", _data.BallsType, delegate(PlayerData.EBallsType eballsType_0)
		{
			_data.BallsType = eballsType_0;
			ballsPanel.Visible = _data.BallsType != PlayerData.EBallsType.None;
		});
		AttachColorPicker(ballsPanel.Content.Controls, "Balls Color", _data.BallsColor, delegate(Color color_0)
		{
			_data.BallsColor = color_0;
		});
		container.Add(ballsPanel);
	}

	private void AttachTailCategory(ControlCollection container)
	{
		AttachTypesDropDown(container, "Tail", _data.TailType, delegate(PlayerData.ETailType type)
		{
			_data.TailType = type;
		});
		AttachColorPicker(container, "Tail Color", _data.TailColor, delegate(Color color)
		{
			_data.TailColor = color;
		});
		AttachSwitchableColorPicker(container, "Tail Part A", _data.ShowTailPartOne, _data.TailPartOneColor, delegate(bool enabled)
		{
			_data.ShowTailPartOne = enabled;
		}, delegate(Color color)
		{
			_data.TailPartOneColor = color;
		});
		AttachSwitchableColorPicker(container, "Tail Part B", _data.ShowTailPartTwo, _data.TailPartTwoColor, delegate(bool enabled)
		{
			_data.ShowTailPartTwo = enabled;
		}, delegate(Color color)
		{
			_data.TailPartTwoColor = color;
		});
	}

	private void AttachFeetCategory(ControlCollection container)
	{
		AttachTypesDropDown(container, "Feet", _data.FeetType, delegate(PlayerData.EFeetType type)
		{
			_data.FeetType = type;
		});
		AttachColorPicker(container, "Feet Color", _data.FeetColor, delegate(Color color)
		{
			_data.FeetColor = color;
		});
	}

	public void DrawSkin(SpriteBatch spriteBatch)
	{
		_effect.Parameters["Time"].SetValue(Utils.Date);
		PlayerPreferences.Singleton.Draw(spriteBatch, _effect);
	}

	private void AttachMarkingsColorPicker(ControlCollection container, string name, PlayerData.EMarkingsType type, Color color, Action<Color> then)
	{
		AttachSwitchableColorPicker(container, name, _data.MarkingsType.HasFlag(type), color, delegate(bool enabled)
		{
			if (enabled)
			{
				_data.MarkingsType |= type;
			}
			else
			{
				_data.MarkingsType &= ~type;
			}
		}, delegate(Color color)
		{
			then(color);
			_skin.Refresh();
		});
	}

	private void AttachHeadMarkingsColorPicker(ControlCollection container, string name, PlayerData.EHeadMarkingsType type, Color color, Action<Color> then)
	{
		AttachSwitchableColorPicker(container, name, _data.HeadMarkingsType.HasFlag(type), color, delegate(bool enabled)
		{
			if (enabled)
			{
				_data.HeadMarkingsType |= type;
			}
			else
			{
				_data.HeadMarkingsType &= ~type;
			}
		}, delegate(Color color)
		{
			then(color);
			_skin.Refresh();
		});
	}

	private void AttachSwitchableColorPicker(ControlCollection container, string name, bool enabled, Color color, Action<bool> onCheck, Action<Color> onPick)
	{
		CheckBox enabledBox = new CheckBox
		{
			Dock = DockStyle.Top,
			Text = name,
			Checked = enabled,
			Margin = new Margin(0, 0, 0, 5)
		};
		Control pickerControl = NewColorPicker(name + " Color", color, onPick);
		pickerControl.Visible = enabledBox.Checked;
		container.Add(enabledBox);
		container.Add(pickerControl);
		enabledBox.CheckedChanged += delegate
		{
			pickerControl.Visible = enabledBox.Checked;
			onCheck(enabledBox.Checked);
			_skin.Refresh();
		};
	}

	private Control AttachColorPicker(ControlCollection container, string name, Color color, Action<Color> then)
	{
		Control control = NewColorPicker(name, color, then);
		container.Add(control);
		return control;
	}

	private Control NewColorPicker(string name, Color color, Action<Color> then)
	{
		Control container = new Control
		{
			Dock = DockStyle.Top,
			Margin = new Margin(0, 0, 0, 5)
		};
		ImageControl colorImage = new ImageControl
		{
			Dock = DockStyle.Left,
			Size = new Squid.Point(29, AmorousData.ButtonHeight),
			Color = ColorInt.ARGB(color.A, color.R, color.G, color.B)
		};
		Label nameLabel = new Label
		{
			Dock = DockStyle.Fill,
			Text = name,
			Margin = new Margin(5, 0, 0, 0)
		};
		colorImage.MouseClick += delegate
		{
			ShowColorPicker(name, color, delegate(Color color)
			{
				colorImage.Color = ColorInt.ARGB(color.A, color.R, color.G, color.B);
				then(color);
				_skin.Refresh();
			});
		};
		container.GetElements().Add(colorImage);
		container.GetElements().Add(nameLabel);
		return container;
	}

	private void SwitchToCategory(Button categoryButton)
	{
		_backgroundContainer.Content.Controls.Clear();
		int currently = _categories.FindIndex((Button button) => object.Equals(button, categoryButton));
		for (int i = 0; i <= currently; i++)
		{
			_categories[i].Dock = DockStyle.Top;
			_backgroundContainer.Content.Controls.Add(_categories[i]);
		}
		for (int num2 = _categories.Count - 1; num2 > currently; num2--)
		{
			_categories[num2].Dock = DockStyle.Bottom;
			_backgroundContainer.Content.Controls.Add(_categories[num2]);
		}
		_backgroundContainer.Content.Controls.Add(_foregroundContainer);
	}

	private Button NewCategory(string name, Action click)
	{
		Button button = new Button
		{
			Dock = DockStyle.Top,
			TextAlign = Alignment.MiddleCenter,
			Text = name,
			Style = "buttonOpaque"
		};
		if (click != null)
		{
			button.MouseClick += delegate
			{
				_foregroundContainer.Content.Controls.Clear();
				_foregroundContainer.VScroll.Value = 0f;
				SwitchToCategory(button);
				click();
			};
		}
		_backgroundContainer.Content.Controls.Add(button);
		return button;
	}

	private void AttachDropDown(ControlCollection container, string name, string[] variants, int selected, Action<int> then)
	{
		Label nameLabel = new Label
		{
			Text = name,
			Dock = DockStyle.Top
		};
		DropDownList dropDown = new DropDownList();
		dropDown.Dock = DockStyle.Top;
		dropDown.Style = "button";
		dropDown.Label.Margin = new Margin(10, 0, 0, 0);
		dropDown.Dropdown.Resizable = false;
		dropDown.Margin = new Margin(0, 0, 0, 5);
		dropDown.Listbox.Scrollbar.ButtonUp.Visible = false;
		dropDown.Listbox.Scrollbar.ButtonDown.Visible = false;
		for (int i = 0; i < variants.Length; i++)
		{
			dropDown.Items.Add(new ListBoxItem
			{
				Text = variants[i],
				Value = i,
				Selected = (i == selected),
				Size = new Squid.Point(0, AmorousData.ButtonHeight)
			});
		}
		dropDown.SelectedItemChanged += delegate(Control container, ListBoxItem box)
		{
			then((int)box.Value);
			_skin.Refresh();
		};
		container.Add(nameLabel);
		container.Add(dropDown);
	}

	private void AttachTypesDropDown<T>(ControlCollection container, string name, T value, Action<T> then)
	{
		int enumValue = (int)(object)value;
		Label nameLabel = new Label
		{
			Text = name,
			Dock = DockStyle.Top
		};
		DropDownList dropDown = new DropDownList();
		dropDown.Dock = DockStyle.Top;
		dropDown.Style = "button";
		dropDown.Label.Margin = new Margin(10, 0, 0, 0);
		dropDown.Dropdown.Resizable = false;
		dropDown.Margin = new Margin(0, 0, 0, 5);
		dropDown.Listbox.Scrollbar.ButtonUp.Visible = false;
		dropDown.Listbox.Scrollbar.ButtonDown.Visible = false;
		string[] names = Enum.GetNames(typeof(T));
		Array values = Enum.GetValues(typeof(T));
		for (int i = 0; i < names.Length; i++)
		{
			int index = (int)values.GetValue(i);
			dropDown.Items.Add(new ListBoxItem
			{
				Text = names[i],
				Value = values.GetValue(i),
				Selected = (index == enumValue),
				Size = new Squid.Point(0, AmorousData.ButtonHeight)
			});
		}
		dropDown.SelectedItemChanged += delegate(Control container, ListBoxItem box)
		{
			then((T)box.Value);
			_skin.Refresh();
		};
		container.Add(nameLabel);
		container.Add(dropDown);
	}

	private void ShowColorPicker(string name, Color color, Action<Color> then)
	{
		if (_colorPicker != null)
		{
			_colorPicker.Close();
		}
		Window container = new Window
		{
			Dock = DockStyle.Right,
			AutoSize = AutoSize.HorizontalVertical,
			Margin = new Margin(8, 8, 0, 8)
		};
		_colorPicker = container;
		Panel panel = new Panel();
		panel.Size = new Squid.Point(307, 519);
		panel.ClipFrame.Margin = new Margin(16, 8, 16, 16);
		container.Controls.Add(panel);
		Label nameLabel = new Label
		{
			Dock = DockStyle.Top,
			Text = name,
			TextAlign = Alignment.MiddleCenter
		};
		Panel pickerContainer = new Panel
		{
			Dock = DockStyle.Top,
			Size = new Squid.Point(275, 250)
		};
		ImageControl pickerBoxImage = new ImageControl
		{
			Dock = DockStyle.Left,
			Texture = "ColorPickerBox",
			Size = new Squid.Point(250, 250)
		};
		ImageControl pickerSliderImage = new ImageControl
		{
			Dock = DockStyle.Fill,
			Texture = "ColorPickerSlider",
			Size = new Squid.Point(25, 250)
		};
		pickerContainer.Content.Controls.Add(pickerBoxImage);
		pickerContainer.Content.Controls.Add(pickerSliderImage);
		ImageControl colorImage = new ImageControl
		{
			Dock = DockStyle.Top,
			Size = new Squid.Point(275, 25),
			Color = ColorInt.ARGB(color.A, color.R, color.G, color.B),
			Margin = new Margin(0, 0, 0, 8)
		};
		Panel boxesContainer1 = new Panel
		{
			Dock = DockStyle.Top,
			Size = new Squid.Point(275, AmorousData.ButtonHeight),
			Margin = new Margin(0, 0, 0, 8)
		};
		Label hueLabel = new Label
		{
			Dock = DockStyle.Left,
			Text = "H:",
			TextAlign = Alignment.MiddleCenter,
			Size = new Squid.Point(AmorousData.ButtonHeight, AmorousData.ButtonHeight)
		};
		TextBox hueBox = new TextBox
		{
			Dock = DockStyle.Left,
			Size = new Squid.Point(107, AmorousData.ButtonHeight),
			TabIndex = 1
		};
		Label redLabel = new Label
		{
			Dock = DockStyle.Left,
			Text = "R:",
			TextAlign = Alignment.MiddleCenter,
			Size = new Squid.Point(AmorousData.ButtonHeight, AmorousData.ButtonHeight)
		};
		TextBox redBox = new TextBox
		{
			Dock = DockStyle.Fill,
			TabIndex = 4
		};
		boxesContainer1.Content.Controls.Add(hueLabel);
		boxesContainer1.Content.Controls.Add(hueBox);
		boxesContainer1.Content.Controls.Add(redLabel);
		boxesContainer1.Content.Controls.Add(redBox);
		Panel boxesContainer2 = new Panel
		{
			Dock = DockStyle.Top,
			Size = new Squid.Point(275, AmorousData.ButtonHeight),
			Margin = new Margin(0, 0, 0, 8)
		};
		Label saturationLabel = new Label
		{
			Dock = DockStyle.Left,
			Text = "S:",
			TextAlign = Alignment.MiddleCenter,
			Size = new Squid.Point(AmorousData.ButtonHeight, AmorousData.ButtonHeight)
		};
		TextBox saturationBox = new TextBox
		{
			Dock = DockStyle.Left,
			Size = new Squid.Point(107, AmorousData.ButtonHeight),
			TabIndex = 2
		};
		Label greenLabel = new Label
		{
			Dock = DockStyle.Left,
			Text = "G:",
			TextAlign = Alignment.MiddleCenter,
			Size = new Squid.Point(AmorousData.ButtonHeight, AmorousData.ButtonHeight)
		};
		TextBox greenBox = new TextBox
		{
			Dock = DockStyle.Fill,
			TabIndex = 5
		};
		boxesContainer2.Content.Controls.Add(saturationLabel);
		boxesContainer2.Content.Controls.Add(saturationBox);
		boxesContainer2.Content.Controls.Add(greenLabel);
		boxesContainer2.Content.Controls.Add(greenBox);
		Panel boxesContainer3 = new Panel
		{
			Dock = DockStyle.Top,
			Size = new Squid.Point(275, AmorousData.ButtonHeight),
			Margin = new Margin(0, 0, 0, 8)
		};
		Label valueLabel = new Label
		{
			Dock = DockStyle.Left,
			Text = "V:",
			TextAlign = Alignment.MiddleCenter,
			Size = new Squid.Point(AmorousData.ButtonHeight, AmorousData.ButtonHeight)
		};
		TextBox valueBox = new TextBox
		{
			Dock = DockStyle.Left,
			Size = new Squid.Point(107, AmorousData.ButtonHeight),
			TabIndex = 3
		};
		Label blueLabel = new Label
		{
			Dock = DockStyle.Left,
			Text = "B:",
			TextAlign = Alignment.MiddleCenter,
			Size = new Squid.Point(AmorousData.ButtonHeight, AmorousData.ButtonHeight)
		};
		TextBox blueBox = new TextBox
		{
			Dock = DockStyle.Fill,
			TabIndex = 6
		};
		boxesContainer3.Content.Controls.Add(valueLabel);
		boxesContainer3.Content.Controls.Add(valueBox);
		boxesContainer3.Content.Controls.Add(blueLabel);
		boxesContainer3.Content.Controls.Add(blueBox);
		Panel hexContainer = new Panel
		{
			Dock = DockStyle.Top,
			Size = new Squid.Point(275, AmorousData.ButtonHeight),
			Margin = new Margin(0, 0, 0, 8)
		};
		Label hexLabel = new Label
		{
			Dock = DockStyle.Left,
			Text = "Hex:",
			TextAlign = Alignment.MiddleCenter,
			Size = new Squid.Point(45, AmorousData.ButtonHeight)
		};
		TextBox hexBox = new TextBox
		{
			Dock = DockStyle.Fill,
			TabIndex = 7
		};
		hexContainer.Content.Controls.Add(hexLabel);
		hexContainer.Content.Controls.Add(hexBox);
		ImageControl cursorPoint = new ImageControl
		{
			Size = new Squid.Point(6, 6),
			Color = ColorInt.ARGB(0.9f, 1f, 1f, 1f)
		};
		ImageControl cursorPointer = new ImageControl
		{
			Size = new Squid.Point(25, 6),
			Color = ColorInt.ARGB(0.9f, 1f, 1f, 1f)
		};
		container.Controls.Add(cursorPoint);
		container.Controls.Add(cursorPointer);
		Button closeButton = new Button
		{
			Dock = DockStyle.Fill,
			Text = "Close",
			TextAlign = Alignment.MiddleCenter
		};
		closeButton.MouseClick += delegate
		{
			_colorPicker.Close();
		};
		panel.Content.Controls.Add(nameLabel);
		panel.Content.Controls.Add(pickerContainer);
		panel.Content.Controls.Add(colorImage);
		panel.Content.Controls.Add(boxesContainer1);
		panel.Content.Controls.Add(boxesContainer2);
		panel.Content.Controls.Add(boxesContainer3);
		panel.Content.Controls.Add(hexContainer);
		panel.Content.Controls.Add(hexContainer);
		panel.Content.Controls.Add(closeButton);
		container.Show(base.Squid);
		RGBToHSV(color, out var hueComponent, out var saturationComponent, out var valueComponent);
		Texture2D colorPickerBackground = new Texture2D(base.Game.Graphics, 250, 250, mipMap: false, SurfaceFormat.Color);
		int[] colorBackgroundGradient = new int[colorPickerBackground.Width * colorPickerBackground.Height];
		for (int i = 0; i < colorPickerBackground.Height; i++)
		{
			for (int j = 0; j < colorPickerBackground.Width; j++)
			{
				Color packedColor = HSVToColor(hueComponent, (float)j / (float)colorPickerBackground.Width, ((float)colorPickerBackground.Height - (float)i) / (float)colorPickerBackground.Height, 1f);
				colorBackgroundGradient[i * colorPickerBackground.Width + j] = (int)packedColor.PackedValue;
			}
		}
		colorPickerBackground.SetData(colorBackgroundGradient);
		Texture2D colorPickerSlider = new Texture2D(base.Game.Graphics, 25, 250, mipMap: false, SurfaceFormat.Color);
		int[] colorSliderGradient = new int[colorPickerSlider.Width * colorPickerSlider.Height];
		for (int k = 0; k < colorPickerSlider.Height; k++)
		{
			Color packedColor = HSVToColor(((float)colorPickerSlider.Height - (float)k) / (float)colorPickerSlider.Height * 360f, 1.0, 1.0, 1f);
			for (int l = 0; l < colorPickerSlider.Width; l++)
			{
				colorSliderGradient[k * colorPickerSlider.Width + l] = (int)packedColor.PackedValue;
			}
		}
		colorPickerSlider.SetData(colorSliderGradient);
		Gui.Renderer.SetTexture("ColorPickerBox", colorPickerBackground);
		Gui.Renderer.SetTexture("ColorPickerSlider", colorPickerSlider);
		Action updateData = delegate
		{
			cursorPoint.Position = new Squid.Point(13 + (int)(saturationComponent * 250f), 35 + (int)(250f - valueComponent * 250f));
			cursorPointer.Position = new Squid.Point(266, 35 + (int)(250f - 250f * (hueComponent / 360f)));
			colorImage.Color = ColorInt.ARGB(color.A, color.R, color.G, color.B);
			hueBox.Text = ((int)hueComponent).ToString();
			saturationBox.Text = ((int)(saturationComponent * 100f)).ToString();
			valueBox.Text = ((int)(valueComponent * 100f)).ToString();
			redBox.Text = color.R.ToString();
			greenBox.Text = color.G.ToString();
			blueBox.Text = color.B.ToString();
			hexBox.Text = $"#{color.R:X2}{color.G:X2}{color.B:X2}";
		};
		updateData();
		bool isGliding = false;
		bool isSliding = false;
		pickerBoxImage.Update += delegate
		{
			if (!isSliding)
			{
				if (base.Game.Controller.IsHolding(ControllerButtonType.LeftButton))
				{
					if (!isGliding && Gui.MousePosition.x >= pickerBoxImage.Location.x && Gui.MousePosition.x <= pickerBoxImage.Location.x + pickerBoxImage.Size.x && Gui.MousePosition.y >= pickerBoxImage.Location.y && Gui.MousePosition.y <= pickerBoxImage.Location.y + pickerBoxImage.Size.y)
					{
						isGliding = true;
					}
					if (isGliding)
					{
						Squid.Point offset = Gui.MousePosition - pickerBoxImage.Location;
						offset.x = (int)MathHelper.Clamp(offset.x, 0f, 250f);
						offset.y = (int)MathHelper.Clamp(offset.y, 0f, 250f);
						saturationComponent = (float)offset.x / 250f;
						valueComponent = (250f - (float)offset.y) / 250f;
						color = HSVToColor(hueComponent, saturationComponent, valueComponent, 1f);
						updateData();
						then(color);
					}
				}
				else
				{
					isGliding = false;
				}
			}
		};
		pickerSliderImage.Update += delegate
		{
			if (!isGliding)
			{
				if (base.Game.Controller.IsHolding(ControllerButtonType.LeftButton))
				{
					if (!isSliding && Gui.MousePosition.x >= pickerSliderImage.Location.x && Gui.MousePosition.x <= pickerSliderImage.Location.x + pickerSliderImage.Size.x && Gui.MousePosition.y >= pickerSliderImage.Location.y && Gui.MousePosition.y <= pickerSliderImage.Location.y + pickerSliderImage.Size.y)
					{
						isSliding = true;
					}
					if (isSliding)
					{
						Squid.Point offset = Gui.MousePosition - pickerSliderImage.Location;
						offset.y = (int)MathHelper.Clamp(offset.y, 0f, 250f);
						hueComponent = 360f - (float)offset.y / 250f * 360f;
						for (int m = 0; m < colorPickerBackground.Height; m++)
						{
							for (int n = 0; n < colorPickerBackground.Width; n++)
							{
								Color packedColor = HSVToColor(hueComponent, (float)n / (float)colorPickerBackground.Width, ((float)colorPickerBackground.Height - (float)m) / (float)colorPickerBackground.Height, 1f);
								colorBackgroundGradient[m * colorPickerBackground.Width + n] = (int)packedColor.PackedValue;
							}
						}
						colorPickerBackground.SetData(colorBackgroundGradient);
						color = HSVToColor(hueComponent, saturationComponent, valueComponent, 1f);
						updateData();
						then(color);
					}
				}
				else
				{
					isSliding = false;
				}
			}
		};
		hueBox.TextCommit += delegate
		{
			if (int.TryParse(hueBox.Text, out var hue))
			{
				hueComponent = Math.Max(0, Math.Min(hue, 360));
				color = HSVToColor(hueComponent, saturationComponent, valueComponent, 1f);
				then(color);
			}
			updateData();
		};
		saturationBox.TextCommit += delegate
		{
			if (int.TryParse(saturationBox.Text, out var saturation))
			{
				saturationComponent = (float)Math.Max(0, Math.Min(saturation, 100)) / 100f;
				color = HSVToColor(hueComponent, saturationComponent, valueComponent, 1f);
				then(color);
			}
			updateData();
		};
		valueBox.TextCommit += delegate
		{
			if (int.TryParse(valueBox.Text, out var value))
			{
				valueComponent = (float)Math.Max(0, Math.Min(value, 100)) / 100f;
				color = HSVToColor(hueComponent, saturationComponent, valueComponent, 1f);
				then(color);
			}
			updateData();
		};
		redBox.TextCommit += delegate
		{
			if (int.TryParse(redBox.Text, out var red))
			{
				color.R = (byte)Math.Max(0, Math.Min(red, 255));
				RGBToHSV(color, out hueComponent, out saturationComponent, out valueComponent);
				then(color);
			}
			updateData();
		};
		greenBox.TextCommit += delegate
		{
			if (int.TryParse(greenBox.Text, out var green))
			{
				color.G = (byte)Math.Max(0, Math.Min(green, 255));
				RGBToHSV(color, out hueComponent, out saturationComponent, out valueComponent);
				then(color);
			}
			updateData();
		};
		blueBox.TextCommit += delegate
		{
			if (int.TryParse(blueBox.Text, out var blue))
			{
				color.B = (byte)Math.Max(0, Math.Min(blue, 255));
				RGBToHSV(color, out hueComponent, out saturationComponent, out valueComponent);
				then(color);
			}
			updateData();
		};
		hexBox.TextCommit += delegate
		{
			if (hexBox.Text.StartsWith("#") && hexBox.Text.Length <= 7)
			{
				try
				{
					int packedColor = Convert.ToInt32(hexBox.Text.Substring(1), 16);
					color.B = (byte)((uint)packedColor & 0xFFu);
					color.G = (byte)((uint)(packedColor >> 8) & 0xFFu);
					color.R = (byte)((uint)(packedColor >> 16) & 0xFFu);
					RGBToHSV(color, out hueComponent, out saturationComponent, out valueComponent);
					then(color);
				}
				catch
				{
				}
			}
			updateData();
		};
		container.Update += delegate
		{
			if (base.Game.Controller.IsPressed(Microsoft.Xna.Framework.Input.Keys.Escape))
			{
				container.Close();
				_colorPicker = null;
			}
		};
	}

	public static void RGBToHSV(Color color, out float h, out float s, out float v)
	{
		float hue = 0f;
		float min = (int)Math.Min(Math.Min(color.R, color.G), color.B);
		float value = (int)Math.Max(Math.Max(color.R, color.G), color.B);
		float range = value - min;
		float saturation = ((!((double)value <= 0.0)) ? (range / value) : 0f);
		if (saturation > 0f)
		{
			if ((float)(int)color.R <= value)
			{
				hue = (float)(color.G - color.B) / range;
			}
			else if ((float)(int)color.G <= value)
			{
				hue = 2f + (float)(color.B - color.R) / range;
			}
			else if ((float)(int)color.B <= value)
			{
				hue = 4f + (float)(color.R - color.G) / range;
			}
			hue *= 60f;
			if ((double)hue <= 0.0)
			{
				hue += 360f;
			}
		}
		else
		{
			hue = 360f;
		}
		h = hue;
		s = (float)Math.Round(saturation, 2);
		v = value / 255f;
	}

	private static Color HSVToColor(double h, double s, double v, float a)
	{
		double r, g, b;
		if (s <= 0.0)
		{
			r = v;
			g = v;
			b = v;
		}
		else
		{
			h = ((!(h >= 360.0)) ? (h / 60.0) : 0.0);
			int direction = (int)h;
			double modifier = h - (double)direction;
			double x = v * (1.0 - s);
			double y = v * (1.0 - s * modifier);
			double z = v * (1.0 - s * (1.0 - modifier));
			switch (direction)
			{
				default:
					r = v;
					g = x;
					b = y;
					break;
				case 0:
					r = v;
					g = z;
					b = x;
					break;
				case 1:
					r = y;
					g = v;
					b = x;
					break;
				case 2:
					r = x;
					g = v;
					b = z;
					break;
				case 3:
					r = x;
					g = y;
					b = v;
					break;
				case 4:
					r = z;
					g = x;
					b = v;
					break;
			}
		}
		return new Color((float)r, (float)g, (float)b, a);
	}
}
