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

	private CustomizablePlayerSkin playerSkin;
	private Panel categoriesContainer;
	private List<Button> categories;
	private Panel overlayContainer;
	private readonly PlayerDataProxy playerDataProxy;
	private Window colorPickerOverlay;
	private readonly Effect effect;

	private readonly List<SexsceneData> sexscenes = new List<SexsceneData>
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

	private readonly string[] sexsceneNames;
	private int selectedSexscene;
	private int selectedStockTemplate;
	private int selectedCustomTemplate;

	protected virtual string ReturnToGameText => "Exit";

	public PlayerCustomizationScene(IAmorous game) : base(game)
	{
		AddSpriteLayer("Background", "Assets/Scenes/Bedroom/Bedroom", -458, 0);
		AddLayer(new DrawableLayer(this, "Custom")
		{
			OnDraw = DrawSkin
		}, 0);
		sexsceneNames = sexscenes.Select((SexsceneData sexscene) => sexscene.Name).ToArray();
		playerDataProxy = new PlayerDataProxy(PlayerPreferences.GetPlayerData());
		playerDataProxy.DataChanged += delegate
		{
			if (base.Game.Sexscene != null)
			{
				base.Game.Sexscene.Refresh();
			}
		};
		FadingMediaPlayer.PlayOnRepeat(AmorousData.MidnightSizzleTrack, 0.4f);
		effect = Game.Content.Load<Effect>("Assets/Shaders/Breathing");
	}

	public override void Start()
	{
		playerSkin = new CustomizablePlayerSkin(base.Game);
		FetchTemplates();
		PlayerPreferences.SetPlayerOverlay(playerSkin);
		ShowOverlay();
	}

	protected virtual void FetchTemplates()
	{
		if (playerSkin.CustomTemplates.Any())
		{
			playerSkin.CloneCustomTemplate(0);
			playerDataProxy.Name = playerSkin.GetCustomTemplateName(0);
			selectedCustomTemplate = 0;
		}
		else
		{
			playerSkin.CloneStockTemplate(0);
			playerDataProxy.Name = "Player";
			selectedCustomTemplate = -1;
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
		categoriesContainer = new Panel
		{
			Dock = DockStyle.Fill
		};
		container.Controls.Add(categoriesContainer);
		overlayContainer = new Panel();
		overlayContainer.Dock = DockStyle.Fill;
		overlayContainer.ClipFrame.Margin = new Margin(8);
		categories = new List<Button>
		{
			NewCategory("Fursona", delegate
			{
				AttachFursonaCategory(overlayContainer.Content.Controls);
			}),
			NewCategory("Body", delegate
			{
				AttachBodyCategory(overlayContainer.Content.Controls);
			}),
			NewCategory("Arms", delegate
			{
				AttachArmsCategory(overlayContainer.Content.Controls);
			}),
			NewCategory("Legs", delegate
			{
				AttachLegsCategory(overlayContainer.Content.Controls);
			}),
			NewCategory("Head", delegate
			{
				AttachHeadCategory(overlayContainer.Content.Controls);
			}),
			NewCategory("Muzzle", delegate
			{
				AttachMuzzleCategory(overlayContainer.Content.Controls);
			}),
			NewCategory("Ears and Horns", delegate
			{
				AttachEarsAndHornsCategory(overlayContainer.Content.Controls);
			}),
			NewCategory("Hair and Fringes", delegate
			{
				AttachHairAndFringesCategory(overlayContainer.Content.Controls);
			}),
			NewCategory("Eyes and Brows", delegate
			{
				AttachEyesAndBrowsCategory(overlayContainer.Content.Controls);
			})
		};
		if (!Censorship.Censored)
		{
			categories.Add(NewCategory("Breasts, Cock and Balls", delegate
			{
				AttachGenitaliaCategory(overlayContainer.Content.Controls);
			}));
		}
		categories.Add(NewCategory("Tail", delegate
		{
			AttachTailCategory(overlayContainer.Content.Controls);
		}));
		categories.Add(NewCategory("Feet", delegate
		{
			AttachFeetCategory(overlayContainer.Content.Controls);
		}));
		container.Show(base.Desktop);
		categories[0].Click(0);
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
			Text = playerDataProxy.Name,
			Margin = new Margin(0, 0, 0, 5)
		};
		templateName.TextChanged += delegate
		{
			playerDataProxy.Name = templateName.Text;
		};
		container.Add(templateName);
		AttachDropDown(container, "Stock Templates", playerSkin.StockTemplates.Select((PlayerCustomizationData configuration) => configuration.Name).ToArray(), selectedStockTemplate, delegate(int answer)
		{
			selectedStockTemplate = answer;
			playerSkin.CloneStockTemplate(answer);
			overlayContainer.Content.Controls.Clear();
			AttachFursonaCategory(container);
			if (base.Game.Sexscene != null)
			{
				base.Game.Sexscene.Refresh();
			}
		});
		AttachDropDown(container, "Your Templates", playerSkin.CustomTemplates.Select((PlayerCustomizationData configuration) => configuration.Name).ToArray(), selectedCustomTemplate, delegate(int index)
		{
			selectedCustomTemplate = index;
			playerSkin.CloneCustomTemplate(index);
			playerDataProxy.Name = playerSkin.GetCustomTemplateName(index);
			overlayContainer.Content.Controls.Clear();
			AttachFursonaCategory(container);
			if (base.Game.Sexscene != null)
			{
				base.Game.Sexscene.Refresh();
			}
		});
		Control phoneColorControl = AttachColorPicker(container, "Phone", playerDataProxy.PhoneColor, delegate(Color color)
		{
			playerDataProxy.PhoneColor = color;
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
				base.Desktop.ShowConfirm("You did not enter a name!", AmorousData.WideDialogueWidth);
			}
			else
			{
				ShowQuestion($"Are you sure you wish to create a new template with the name '{templateName.Text}', based on the current character?", delegate
				{
					playerSkin.AddCustomTemplate(templateName.Text, playerDataProxy.GetPlayerData());
					selectedCustomTemplate = playerSkin.CustomTemplates.Count() - 1;
					playerSkin.CloneCustomTemplate(selectedCustomTemplate);
					playerDataProxy.Name = playerSkin.GetCustomTemplateName(selectedCustomTemplate);
					overlayContainer.Content.Controls.Clear();
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
				base.Desktop.ShowConfirm("You did not enter a name!", AmorousData.WideDialogueWidth);
			}
			else if (selectedCustomTemplate >= 0)
			{
				ShowQuestion($"Are you sure you wish to save the currect character to the selected template '{playerSkin.GetCustomTemplateName(selectedCustomTemplate)}'?", delegate
				{
					playerSkin.AddCustomTemplateAtIndex(templateName.Text, selectedCustomTemplate, playerDataProxy.GetPlayerData());
					overlayContainer.Content.Controls.Clear();
					AttachFursonaCategory(container);
				});
			}
			else
			{
				ShowQuestion($"No template has been selected yet, do you wish to create a new template with the name '{templateName.Text}', based on the current character?", delegate
				{
					playerSkin.AddCustomTemplate(templateName.Text, playerDataProxy.GetPlayerData());
					selectedCustomTemplate = playerSkin.CustomTemplates.Count() - 1;
					playerSkin.CloneCustomTemplate(selectedCustomTemplate);
					playerDataProxy.Name = playerSkin.GetCustomTemplateName(selectedCustomTemplate);
					overlayContainer.Content.Controls.Clear();
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
			if (selectedCustomTemplate >= 0)
			{
				ShowQuestion($"Are you sure you wish to reset the current character back to selected template '{playerSkin.GetCustomTemplateName(selectedCustomTemplate)}'? All changes will be lost!", delegate
				{
					playerSkin.ResetCustomTemplate(selectedCustomTemplate);
					playerDataProxy.Name = playerSkin.GetCustomTemplateName(selectedCustomTemplate);
					overlayContainer.Content.Controls.Clear();
					AttachFursonaCategory(container);
				});
			}
			else
			{
				base.Desktop.ShowConfirm("You did not select a template!", AmorousData.WideDialogueWidth);
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
			if (selectedCustomTemplate >= 0)
			{
				ShowQuestion($"Are you sure you wish to delete the selected template '{playerSkin.GetCustomTemplateName(selectedCustomTemplate)}'?", delegate
				{
					playerSkin.RemoveCustomTemplate(selectedCustomTemplate);
					selectedCustomTemplate = -1;
					overlayContainer.Content.Controls.Clear();
					AttachFursonaCategory(container);
				});
			}
			else
			{
				base.Desktop.ShowConfirm("You did not select a template!", AmorousData.WideDialogueWidth);
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
			playerSkin.ToggleZoom();
		};
		container.Add(zoomButton);
		if (!Censorship.Censored)
		{
			AttachDropDown(container, "Preview Sexscene", sexsceneNames, selectedSexscene, delegate(int index)
			{
				selectedSexscene = index;
				if (index == 0)
				{
					base.Game.ResetSexscene();
				}
				else
				{
					base.Game.PlaySexscene(sexscenes[index].Scene);
					base.Game.Sexscene.Muted = true;
				}
			});
		}
		if (!base.Desktop.Skin.ContainsKey("button2"))
		{
			base.Desktop.Skin.Add("button2", new ControlStyle(base.Desktop.Skin["button"])
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
				base.Desktop.ShowConfirm("You did not enter a name!", AmorousData.WideDialogueWidth);
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
		base.Desktop.ShowSelection(question, new string[2] { "No way!", "Yes please!" }, AmorousData.WideDialogueWidth, delegate(int answer)
		{
			if (answer == 1)
			{
				then();
			}
		});
	}

	protected virtual void ShowExit()
	{
		base.Desktop.ShowSelection("Are you sure you wish to exit? All unsaved changes will be lost!", new string[2] { "Oops, my bad!", "Yes please!" }, AmorousData.WideDialogueWidth, delegate(int answer)
		{
			if (answer == 1)
			{
				base.Game.StartScene<MainMenuScene>();
			}
		});
	}

	private void AttachBodyCategory(ControlCollection container)
	{
		AttachTypesDropDown(container, "Body", playerDataProxy.BodyType, delegate(PlayerData.EBodyType type)
		{
			playerDataProxy.BodyType = type;
		});
		AttachColorPicker(container, "Body Color", playerDataProxy.BodyColor, delegate(Color color)
		{
			playerDataProxy.BodyColor = color;
		});
		AttachMarkingsColorPicker(container, "Underbelly Marking", PlayerData.EMarkingsType.Underbelly, playerDataProxy.UnderbellyColor, delegate(Color color)
		{
			playerDataProxy.UnderbellyColor = color;
		});
		AttachMarkingsColorPicker(container, "Underthigh Marking", PlayerData.EMarkingsType.Underthigh, playerDataProxy.UnderthighColor, delegate(Color color)
		{
			playerDataProxy.UnderthighColor = color;
		});
		AttachMarkingsColorPicker(container, "Stripes Marking", PlayerData.EMarkingsType.Stripes, playerDataProxy.StripesColor, delegate(Color color)
		{
			playerDataProxy.StripesColor = color;
		});
		AttachSwitchableColorPicker(container, "Nails", playerDataProxy.ShowNails, playerDataProxy.NailColor, delegate(bool enabled)
		{
			playerDataProxy.ShowNails = enabled;
		}, delegate(Color color)
		{
			playerDataProxy.NailColor = color;
		});
	}

	private void AttachArmsCategory(ControlCollection container)
	{
		AttachMarkingsColorPicker(container, "Long Forearm Marking", PlayerData.EMarkingsType.LongForearm, playerDataProxy.LongForearmColor, delegate(Color color)
		{
			playerDataProxy.LongForearmColor = color;
		});
		AttachMarkingsColorPicker(container, "Short Forearm Marking", PlayerData.EMarkingsType.ShortForearm, playerDataProxy.ShortForearmColor, delegate(Color color)
		{
			playerDataProxy.ShortForearmColor = color;
		});
		AttachMarkingsColorPicker(container, "Avian Forearm Marking", PlayerData.EMarkingsType.AvianForearm, playerDataProxy.AvianForearmColor, delegate(Color color)
		{
			playerDataProxy.AvianForearmColor = color;
		});
	}

	private void AttachLegsCategory(ControlCollection container)
	{
		AttachMarkingsColorPicker(container, "Long Shin Marking", PlayerData.EMarkingsType.LongShin, playerDataProxy.LongShinColor, delegate(Color color)
		{
			playerDataProxy.LongShinColor = color;
		});
		AttachMarkingsColorPicker(container, "Short Shin Marking", PlayerData.EMarkingsType.ShortShin, playerDataProxy.ShortShinColor, delegate(Color color)
		{
			playerDataProxy.ShortShinColor = color;
		});
		AttachMarkingsColorPicker(container, "Avian Shin Marking", PlayerData.EMarkingsType.AvianShin, playerDataProxy.AvianShinColor, delegate(Color color)
		{
			playerDataProxy.AvianShinColor = color;
		});
	}

	private void AttachHeadCategory(ControlCollection container)
	{
		Panel headPanel = new Panel
		{
			Dock = DockStyle.Fill,
			Visible = (playerDataProxy.HeadType == PlayerData.EHeadType.Default)
		};
		Panel paperBagPanel = new Panel
		{
			Dock = DockStyle.Fill,
			Visible = (playerDataProxy.HeadType == PlayerData.EHeadType.PaperBag)
		};
		AttachTypesDropDown(container, "Head", playerDataProxy.HeadType, delegate(PlayerData.EHeadType type)
		{
			playerDataProxy.HeadType = type;
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
		AttachColorPicker(container, "Head Color", playerDataProxy.HeadColor, delegate(Color color)
		{
			playerDataProxy.HeadColor = color;
		});
		AttachHeadMarkingsColorPicker(headPanel.Content.Controls, "Gaunt Marking", PlayerData.EHeadMarkingsType.Gaunt, playerDataProxy.HeadGauntColor, delegate(Color color)
		{
			playerDataProxy.HeadGauntColor = color;
		});
		AttachHeadMarkingsColorPicker(headPanel.Content.Controls, "Scruffy Marking", PlayerData.EHeadMarkingsType.Scruffy, playerDataProxy.HeadScruffyColor, delegate(Color color)
		{
			playerDataProxy.HeadScruffyColor = color;
		});
		AttachHeadMarkingsColorPicker(headPanel.Content.Controls, "Snout Marking", PlayerData.EHeadMarkingsType.Snout, playerDataProxy.HeadSnoutColor, delegate(Color color)
		{
			playerDataProxy.HeadSnoutColor = color;
		});
		AttachHeadMarkingsColorPicker(headPanel.Content.Controls, "Stripes Marking", PlayerData.EHeadMarkingsType.Stripes, playerDataProxy.HeadStripesColor, delegate(Color color)
		{
			playerDataProxy.HeadStripesColor = color;
		});
		AttachColorPicker(paperBagPanel.Content.Controls, "Paper Bag Color", playerDataProxy.PaperBagColor, delegate(Color color)
		{
			playerDataProxy.PaperBagColor = color;
		});
		AttachColorPicker(paperBagPanel.Content.Controls, "Eyesholes Color", playerDataProxy.PaperBagEyesColor, delegate(Color color)
		{
			playerDataProxy.PaperBagEyesColor = color;
		});
		container.Add(headPanel);
		container.Add(paperBagPanel);
	}

	private void AttachMuzzleCategory(ControlCollection container)
	{
		AttachTypesDropDown(container, "Muzzle", playerDataProxy.MuzzleType, delegate(PlayerData.EMuzzleType type)
		{
			playerDataProxy.MuzzleType = type;
		});
		AttachColorPicker(container, "Muzzle Color", playerDataProxy.MuzzleColor, delegate(Color color)
		{
			playerDataProxy.MuzzleColor = color;
		});
		AttachColorPicker(container, "Nose Color", playerDataProxy.NoseColor, delegate(Color color)
		{
			playerDataProxy.NoseColor = color;
		});
		AttachColorPicker(container, "Teeth Color", playerDataProxy.TeethColor, delegate(Color color)
		{
			playerDataProxy.TeethColor = color;
		});
		AttachSwitchableColorPicker(container, "Muzzle Horn", playerDataProxy.ShowMuzzleHorn, playerDataProxy.MuzzleHornColor, delegate(bool enabled)
		{
			playerDataProxy.ShowMuzzleHorn = enabled;
		}, delegate(Color color)
		{
			playerDataProxy.MuzzleHornColor = color;
		});
		AttachSwitchableColorPicker(container, "Muzzle Mask", playerDataProxy.ShowMuzzleMask, playerDataProxy.MuzzleMaskColor, delegate(bool enabled)
		{
			playerDataProxy.ShowMuzzleMask = enabled;
		}, delegate(Color color)
		{
			playerDataProxy.MuzzleMaskColor = color;
		});
	}

	private void AttachEarsAndHornsCategory(ControlCollection container)
	{
		AttachTypesDropDown(container, "Ears and Horns", playerDataProxy.HeadAccessoriesType, delegate(PlayerData.EHeadAccessoriesType type)
		{
			playerDataProxy.HeadAccessoriesType = type;
		});
		AttachColorPicker(container, "Horns Color", playerDataProxy.HeadHornsColor, delegate(Color color)
		{
			playerDataProxy.HeadHornsColor = color;
		});
		AttachColorPicker(container, "Ear Color", playerDataProxy.EarColor, delegate(Color color)
		{
			playerDataProxy.EarColor = color;
		});
		AttachColorPicker(container, "Ear Inner Color", playerDataProxy.EarInnerColor, delegate(Color color)
		{
			playerDataProxy.EarInnerColor = color;
		});
	}

	private void AttachHairAndFringesCategory(ControlCollection container)
	{
		AttachTypesDropDown(container, "Hair", playerDataProxy.HairstyleType, delegate(PlayerData.EHairstyleType type)
		{
			playerDataProxy.HairstyleType = type;
		});
		AttachColorPicker(container, "Hair Color", playerDataProxy.HairColor, delegate(Color color)
		{
			playerDataProxy.HairColor = color;
		});
		AttachTypesDropDown(container, "Fringe", playerDataProxy.FringeType, delegate(PlayerData.EFringeType type)
		{
			playerDataProxy.FringeType = type;
		});
		AttachColorPicker(container, "Fringe Color", playerDataProxy.FringeColor, delegate(Color color)
		{
			playerDataProxy.FringeColor = color;
		});
	}

	private void AttachEyesAndBrowsCategory(ControlCollection container)
	{
		AttachTypesDropDown(container, "Eyes", playerDataProxy.EyesType, delegate(PlayerData.EEyesType type)
		{
			playerDataProxy.EyesType = type;
		});
		AttachColorPicker(container, "Eyes Back Color", playerDataProxy.EyesBackColor, delegate(Color color)
		{
			playerDataProxy.EyesBackColor = color;
		});
		AttachColorPicker(container, "Eyes Front Color", playerDataProxy.EyesFrontColor, delegate(Color color)
		{
			playerDataProxy.EyesFrontColor = color;
		});
		AttachTypesDropDown(container, "Brows", playerDataProxy.BrowType, delegate(PlayerData.EBrowType type)
		{
			playerDataProxy.BrowType = type;
		});
		AttachColorPicker(container, "Brows Color", playerDataProxy.BrowColor, delegate(Color color)
		{
			playerDataProxy.BrowColor = color;
		});
	}

	private void AttachGenitaliaCategory(ControlCollection container)
	{
		Panel breastPanel = new Panel
		{
			Dock = DockStyle.Top,
			Visible = (playerDataProxy.BreastsType != PlayerData.EBreastsType.None)
		};
		Panel cockPanel = new Panel
		{
			Dock = DockStyle.Top,
			Visible = (playerDataProxy.CockType != PlayerData.ECockType.None)
		};
		Panel ballsPanel = new Panel
		{
			Dock = DockStyle.Top,
			Visible = (playerDataProxy.BallsType != PlayerData.EBallsType.None)
		};
		AttachTypesDropDown(container, "Breasts", playerDataProxy.BreastsType, delegate(PlayerData.EBreastsType type)
		{
			playerDataProxy.BreastsType = type;
			breastPanel.Visible = playerDataProxy.BreastsType != PlayerData.EBreastsType.None;
		});
		AttachColorPicker(breastPanel.Content.Controls, "Breasts Color", playerDataProxy.BreastsColor, delegate(Color color)
		{
			playerDataProxy.BreastsColor = color;
		});
		AttachSwitchableColorPicker(breastPanel.Content.Controls, "Nipples", playerDataProxy.ShowNipples, playerDataProxy.NipplesColor, delegate(bool enabled)
		{
			playerDataProxy.ShowNipples = enabled;
		}, delegate(Color color)
		{
			playerDataProxy.NipplesColor = color;
		});
		container.Add(breastPanel);
		Control cockColorControl = null;
		AttachTypesDropDown(container, "Cock", playerDataProxy.CockType, delegate(PlayerData.ECockType type)
		{
			playerDataProxy.CockType = type;
			cockPanel.Visible = playerDataProxy.CockType != PlayerData.ECockType.None;
			cockColorControl.Visible = playerDataProxy.CockType == PlayerData.ECockType.Cut || playerDataProxy.CockType == PlayerData.ECockType.Uncut;
		});
		AttachColorPicker(cockPanel.Content.Controls, "Cock Color", playerDataProxy.GenitaliaColor, delegate(Color color)
		{
			playerDataProxy.GenitaliaColor = color;
		});
		cockColorControl = AttachColorPicker(cockPanel.Content.Controls, "Cock Tip Color", playerDataProxy.GenitaliaFleshColor, delegate(Color color)
		{
			playerDataProxy.GenitaliaFleshColor = color;
		});
		cockColorControl.Visible = playerDataProxy.CockType == PlayerData.ECockType.Cut || playerDataProxy.CockType == PlayerData.ECockType.Uncut;
		container.Add(cockPanel);
		AttachTypesDropDown(container, "Balls", playerDataProxy.BallsType, delegate(PlayerData.EBallsType balls)
		{
			playerDataProxy.BallsType = balls;
			ballsPanel.Visible = playerDataProxy.BallsType != PlayerData.EBallsType.None;
		});
		AttachColorPicker(ballsPanel.Content.Controls, "Balls Color", playerDataProxy.BallsColor, delegate(Color color)
		{
			playerDataProxy.BallsColor = color;
		});
		container.Add(ballsPanel);
	}

	private void AttachTailCategory(ControlCollection container)
	{
		AttachTypesDropDown(container, "Tail", playerDataProxy.TailType, delegate(PlayerData.ETailType type)
		{
			playerDataProxy.TailType = type;
		});
		AttachColorPicker(container, "Tail Color", playerDataProxy.TailColor, delegate(Color color)
		{
			playerDataProxy.TailColor = color;
		});
		AttachSwitchableColorPicker(container, "Tail Part A", playerDataProxy.ShowTailPartOne, playerDataProxy.TailPartOneColor, delegate(bool enabled)
		{
			playerDataProxy.ShowTailPartOne = enabled;
		}, delegate(Color color)
		{
			playerDataProxy.TailPartOneColor = color;
		});
		AttachSwitchableColorPicker(container, "Tail Part B", playerDataProxy.ShowTailPartTwo, playerDataProxy.TailPartTwoColor, delegate(bool enabled)
		{
			playerDataProxy.ShowTailPartTwo = enabled;
		}, delegate(Color color)
		{
			playerDataProxy.TailPartTwoColor = color;
		});
	}

	private void AttachFeetCategory(ControlCollection container)
	{
		AttachTypesDropDown(container, "Feet", playerDataProxy.FeetType, delegate(PlayerData.EFeetType type)
		{
			playerDataProxy.FeetType = type;
		});
		AttachColorPicker(container, "Feet Color", playerDataProxy.FeetColor, delegate(Color color)
		{
			playerDataProxy.FeetColor = color;
		});
	}

	public void DrawSkin(SpriteBatch spriteBatch)
	{
		effect.Parameters["Time"].SetValue(Utils.Date);
		PlayerPreferences.Singleton.Draw(spriteBatch, effect);
	}

	private void AttachMarkingsColorPicker(ControlCollection container, string name, PlayerData.EMarkingsType type, Color color, Action<Color> then)
	{
		AttachSwitchableColorPicker(container, name, playerDataProxy.MarkingsType.HasFlag(type), color, delegate(bool enabled)
		{
			if (enabled)
			{
				playerDataProxy.MarkingsType |= type;
			}
			else
			{
				playerDataProxy.MarkingsType &= ~type;
			}
		}, delegate(Color color)
		{
			then(color);
			playerSkin.Refresh();
		});
	}

	private void AttachHeadMarkingsColorPicker(ControlCollection container, string name, PlayerData.EHeadMarkingsType type, Color color, Action<Color> then)
	{
		AttachSwitchableColorPicker(container, name, playerDataProxy.HeadMarkingsType.HasFlag(type), color, delegate(bool enabled)
		{
			if (enabled)
			{
				playerDataProxy.HeadMarkingsType |= type;
			}
			else
			{
				playerDataProxy.HeadMarkingsType &= ~type;
			}
		}, delegate(Color color)
		{
			then(color);
			playerSkin.Refresh();
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
			playerSkin.Refresh();
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
				playerSkin.Refresh();
			});
		};
		container.GetElements().Add(colorImage);
		container.GetElements().Add(nameLabel);
		return container;
	}

	private void SwitchToCategory(Button categoryButton)
	{
		categoriesContainer.Content.Controls.Clear();
		int currently = categories.FindIndex((Button button) => object.Equals(button, categoryButton));
		for (int i = 0; i <= currently; i++)
		{
			categories[i].Dock = DockStyle.Top;
			categoriesContainer.Content.Controls.Add(categories[i]);
		}
		for (int num2 = categories.Count - 1; num2 > currently; num2--)
		{
			categories[num2].Dock = DockStyle.Bottom;
			categoriesContainer.Content.Controls.Add(categories[num2]);
		}
		categoriesContainer.Content.Controls.Add(overlayContainer);
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
				overlayContainer.Content.Controls.Clear();
				overlayContainer.VScroll.Value = 0f;
				SwitchToCategory(button);
				click();
			};
		}
		categoriesContainer.Content.Controls.Add(button);
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
			playerSkin.Refresh();
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
			playerSkin.Refresh();
		};
		container.Add(nameLabel);
		container.Add(dropDown);
	}

	private void ShowColorPicker(string name, Color color, Action<Color> then)
	{
		if (colorPickerOverlay != null)
		{
			colorPickerOverlay.Close();
		}
		Window container = new Window
		{
			Dock = DockStyle.Right,
			AutoSize = AutoSize.HorizontalVertical,
			Margin = new Margin(8, 8, 0, 8)
		};
		colorPickerOverlay = container;
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
			colorPickerOverlay.Close();
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
		container.Show(base.Desktop);
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
				colorPickerOverlay = null;
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
