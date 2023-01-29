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

	protected bool MightConfigurateEverything;

	private CustomizablePlayerSkin _skin;
	private Panel _backgroundPanel;
	private List<Button> _categories;
	private Panel _foregroundPanel;
	private readonly PlayerDataProxy _data;
	private Window _colorPicker;
	private readonly Effect _shader;

	private readonly List<SexsceneData> _sexscenes = new List<SexsceneData>
	{
		new SexsceneData("None", null),
		new SexsceneData("Coby", AmorousData.CobySexscene),
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
	private int _templatePlayerIndex;

	protected virtual string ReturnToGameText => "Exit";

	public PlayerCustomizationScene(IAmorous game)
		: base(game)
	{
		AddSpriteLayer("Background", "Assets/Scenes/Bedroom/Bedroom", -458, 0);
		AddLayer(new DrawableLayer(this, "Custom")
		{
			OnDraw = DrawPlayer
		}, 0);
		_sexsceneNames = _sexscenes.Select((SexsceneData sexscene) => sexscene.Name).ToArray();
		_data = new PlayerDataProxy(PlayerPreferences.GetPlayerData());
		_data.OnChange += delegate
		{
			if (base.Game.Sexscene != null)
			{
				base.Game.Sexscene.RefreshData();
			}
		};
		FadingMediaPlayer.PlayOnRepeat(AmorousData.MidnightSizzleTrack, 0.4f);
		_shader = Game.Content.Load<Effect>("Assets/Shaders/Breathing");
	}

	public override void Start()
	{
		_skin = new CustomizablePlayerSkin(base.Game);
		_hI8MfcRDpV9Q45afjBJe8lA5sbr();
		PlayerPreferences.SetPlayerSkin(_skin);
		DisplayCreator();
	}

	protected virtual void _hI8MfcRDpV9Q45afjBJe8lA5sbr()
	{
		if (_skin._I6gsCHlb2BKFCJSAk9Cn5fCMAPu.Any())
		{
			_skin._BCRMBb9uhQZrQlfdXPidu27yb8C(0);
			_data.Name = _skin._6qwooGF3jWmbG9887Y5IKZ8fJ0E(0);
			_templatePlayerIndex = 0;
		}
		else
		{
			_skin._BwV21jdCpo4YpIp6x74bJ0H7hut(0);
			_data.Name = "Player";
			_templatePlayerIndex = -1;
		}
	}

	private void DisplayCreator()
	{
		Window window = new Window
		{
			Dock = DockStyle.Right,
			Size = new Squid.Point(512, 0),
			Margin = new Margin(8),
			Padding = new Margin(8)
		};
		_backgroundPanel = new Panel
		{
			Dock = DockStyle.Fill
		};
		window.Controls.Add(_backgroundPanel);
		Panel panel = new Panel();
		panel.Dock = DockStyle.Fill;
		panel.ClipFrame.Margin = new Margin(8);
		_foregroundPanel = panel;
		_categories = new List<Button>
		{
			NewCategory("Fursona", delegate
			{
				_OBIbaNO8X49ahEZ5n3Ta8HUK7mO(_foregroundPanel.Content.Controls);
			}),
			NewCategory("Body", delegate
			{
				_jiNxMIzuA8Rrc2ULsrob5A7UNDe(_foregroundPanel.Content.Controls);
			}),
			NewCategory("Arms", delegate
			{
				_1qIQUjhrbk5WA7C7mYs93gXLOIe(_foregroundPanel.Content.Controls);
			}),
			NewCategory("Legs", delegate
			{
				_VCrdQDifkN8NHlzPICTmtbgWFwp(_foregroundPanel.Content.Controls);
			}),
			NewCategory("Head", delegate
			{
				_vXrWU56trsuFNc9CNcHuctfkI2S(_foregroundPanel.Content.Controls);
			}),
			NewCategory("Muzzle", delegate
			{
				_vg6ASaP7xNqc0jerF3mcrXv4dn7(_foregroundPanel.Content.Controls);
			}),
			NewCategory("Ears and Horns", delegate
			{
				_Xhurp3mVVoR5kNlnxgLoDDkeQxM(_foregroundPanel.Content.Controls);
			}),
			NewCategory("Hair and Fringes", delegate
			{
				_gHA9C0CRN2NaRMtfTrvlotJOd0T(_foregroundPanel.Content.Controls);
			}),
			NewCategory("Eyes and Brows", delegate
			{
				_hNo7o9fG9jvwcKyMq1nYl4q7cXc(_foregroundPanel.Content.Controls);
			})
		};
		if (!Censorship.Censored)
		{
			_categories.Add(NewCategory("Breasts, Cock and Balls", delegate
			{
				_mWS8UuA4xcT1bSdjDObiubOE0wH(_foregroundPanel.Content.Controls);
			}));
		}
		_categories.Add(NewCategory("Tail", delegate
		{
			_7JR6eL4D0qdIJNOwfInnlg2HEgZ(_foregroundPanel.Content.Controls);
		}));
		_categories.Add(NewCategory("Feet", delegate
		{
			_PBEdYyzYEWcXAodjVf58ocOQ3Jf(_foregroundPanel.Content.Controls);
		}));
		window.Show(base.Squid);
		_categories[0].Click(0);
	}

	private void _OBIbaNO8X49ahEZ5n3Ta8HUK7mO(ControlCollection controlCollection_0)
	{
		controlCollection_0.Add(new Label
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
		controlCollection_0.Add(templateName);
		AttachDropDownList(controlCollection_0, "Stock Templates", _skin._A088aXIdbVflSYtbl7vA5RjQOjXA.Select((PlayerCustomizationData configuration) => configuration.Name).ToArray(), _templateStockIndex, delegate(int int_0)
		{
			_templateStockIndex = int_0;
			_skin._BwV21jdCpo4YpIp6x74bJ0H7hut(int_0);
			_foregroundPanel.Content.Controls.Clear();
			_OBIbaNO8X49ahEZ5n3Ta8HUK7mO(controlCollection_0);
			if (base.Game.Sexscene != null)
			{
				base.Game.Sexscene.RefreshData();
			}
		});
		AttachDropDownList(controlCollection_0, "Your Templates", _skin._I6gsCHlb2BKFCJSAk9Cn5fCMAPu.Select((PlayerCustomizationData configuration) => configuration.Name).ToArray(), _templatePlayerIndex, delegate(int index)
		{
			_templatePlayerIndex = index;
			_skin._BCRMBb9uhQZrQlfdXPidu27yb8C(index);
			_data.Name = _skin._6qwooGF3jWmbG9887Y5IKZ8fJ0E(index);
			_foregroundPanel.Content.Controls.Clear();
			_OBIbaNO8X49ahEZ5n3Ta8HUK7mO(controlCollection_0);
			if (base.Game.Sexscene != null)
			{
				base.Game.Sexscene.RefreshData();
			}
		});
		Control control = _z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Phone", _data.PhoneColor, delegate(Color color)
		{
			_data.PhoneColor = color;
		});
		control.Margin = new Margin(0, 5, 0, 0);
		Button button = new Button
		{
			Margin = new Margin(0, 10, 0, 0),
			Dock = DockStyle.Top,
			Text = "New Template"
		};
		button.MouseClick += delegate
		{
			if (string.IsNullOrWhiteSpace(templateName.Text))
			{
				base.Squid.ShowConfirm("You did not enter a name!", AmorousData.ShortDialogueOffset);
			}
			else
			{
				_yA2ISabBQiVKBxMt5AXSybmkG5o($"Are you sure you wish to create a new template with the name '{templateName.Text}', based on the current character?", delegate
				{
					_skin._0S3oMrwxDtOTcbzkglSllPfRq53(templateName.Text, _data.GetPlayerData());
					_templatePlayerIndex = _skin._I6gsCHlb2BKFCJSAk9Cn5fCMAPu.Count() - 1;
					_skin._BCRMBb9uhQZrQlfdXPidu27yb8C(_templatePlayerIndex);
					_data.Name = _skin._6qwooGF3jWmbG9887Y5IKZ8fJ0E(_templatePlayerIndex);
					_foregroundPanel.Content.Controls.Clear();
					_OBIbaNO8X49ahEZ5n3Ta8HUK7mO(controlCollection_0);
				});
			}
		};
		controlCollection_0.Add(button);
		Button button2 = new Button
		{
			Dock = DockStyle.Top,
			Text = "Save Template"
		};
		button2.MouseClick += delegate
		{
			if (string.IsNullOrWhiteSpace(templateName.Text))
			{
				base.Squid.ShowConfirm("You did not enter a name!", AmorousData.ShortDialogueOffset);
			}
			else if (_templatePlayerIndex >= 0)
			{
				_yA2ISabBQiVKBxMt5AXSybmkG5o($"Are you sure you wish to save the currect character to the selected template '{_skin._6qwooGF3jWmbG9887Y5IKZ8fJ0E(_templatePlayerIndex)}'?", delegate
				{
					_skin._WfRAwdaNcmrDEhMe1AHPq7egPcw(templateName.Text, _templatePlayerIndex, _data.GetPlayerData());
					_foregroundPanel.Content.Controls.Clear();
					_OBIbaNO8X49ahEZ5n3Ta8HUK7mO(controlCollection_0);
				});
			}
			else
			{
				_yA2ISabBQiVKBxMt5AXSybmkG5o($"No template has been selected yet, do you wish to create a new template with the name '{templateName.Text}', based on the current character?", delegate
				{
					_skin._0S3oMrwxDtOTcbzkglSllPfRq53(templateName.Text, _data.GetPlayerData());
					_templatePlayerIndex = _skin._I6gsCHlb2BKFCJSAk9Cn5fCMAPu.Count() - 1;
					_skin._BCRMBb9uhQZrQlfdXPidu27yb8C(_templatePlayerIndex);
					_data.Name = _skin._6qwooGF3jWmbG9887Y5IKZ8fJ0E(_templatePlayerIndex);
					_foregroundPanel.Content.Controls.Clear();
					_OBIbaNO8X49ahEZ5n3Ta8HUK7mO(controlCollection_0);
				});
			}
		};
		controlCollection_0.Add(button2);
		Button button3 = new Button
		{
			Dock = DockStyle.Top,
			Text = "Reset Template"
		};
		button3.MouseClick += delegate
		{
			if (_templatePlayerIndex >= 0)
			{
				_yA2ISabBQiVKBxMt5AXSybmkG5o($"Are you sure you wish to reset the current character back to selected template '{_skin._6qwooGF3jWmbG9887Y5IKZ8fJ0E(_templatePlayerIndex)}'? All changes will be lost!", delegate
				{
					_skin._JC60lfB4LT6VifObN1Ynm6iARlc(_templatePlayerIndex);
					_data.Name = _skin._6qwooGF3jWmbG9887Y5IKZ8fJ0E(_templatePlayerIndex);
					_foregroundPanel.Content.Controls.Clear();
					_OBIbaNO8X49ahEZ5n3Ta8HUK7mO(controlCollection_0);
				});
			}
			else
			{
				base.Squid.ShowConfirm("You did not select a template!", AmorousData.ShortDialogueOffset);
			}
		};
		controlCollection_0.Add(button3);
		Button button4 = new Button
		{
			Dock = DockStyle.Top,
			Text = "Delete Template"
		};
		button4.MouseClick += delegate
		{
			if (_templatePlayerIndex >= 0)
			{
				_yA2ISabBQiVKBxMt5AXSybmkG5o($"Are you sure you wish to delete the selected template '{_skin._6qwooGF3jWmbG9887Y5IKZ8fJ0E(_templatePlayerIndex)}'?", delegate
				{
					_skin._FzyCgzYhOXEADaijk8VbcLulpcBA(_templatePlayerIndex);
					_templatePlayerIndex = -1;
					_foregroundPanel.Content.Controls.Clear();
					_OBIbaNO8X49ahEZ5n3Ta8HUK7mO(controlCollection_0);
				});
			}
			else
			{
				base.Squid.ShowConfirm("You did not select a template!", AmorousData.ShortDialogueOffset);
			}
		};
		controlCollection_0.Add(button4);
		Button button5 = new Button
		{
			Margin = new Margin(0, 10, 0, 0),
			Dock = DockStyle.Top,
			Text = "Toggle zoom"
		};
		button5.MouseClick += delegate
		{
			_skin.ToggleZoom();
		};
		controlCollection_0.Add(button5);
		if (!Censorship.Censored)
		{
			AttachDropDownList(controlCollection_0, "Preview Sexscene", _sexsceneNames, _sexsceneIndex, delegate(int index)
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
		Button button6 = new Button
		{
			Margin = new Margin(0, 10, 0, 0),
			Dock = DockStyle.Top,
			Text = ReturnToGameText,
			Style = "button2"
		};
		button6.MouseClick += delegate
		{
			if (MightConfigurateEverything && string.IsNullOrWhiteSpace(templateName.Text))
			{
				base.Squid.ShowConfirm("You did not enter a name!", AmorousData.ShortDialogueOffset);
			}
			else
			{
				ConfirmEverything();
			}
		};
		controlCollection_0.Add(button6);
	}

	private void _yA2ISabBQiVKBxMt5AXSybmkG5o(string string_0, Action action_0)
	{
		base.Squid.ShowSelection(string_0, new string[2] { "No way!", "Yes please!" }, AmorousData.ShortDialogueOffset, delegate(int int_0)
		{
			if (int_0 == 1)
			{
				action_0();
			}
		});
	}

	protected virtual void ConfirmEverything()
	{
		base.Squid.ShowSelection("Are you sure you wish to exit? All unsaved changes will be lost!", new string[2] { "Oops, my bad!", "Yes please!" }, AmorousData.ShortDialogueOffset, delegate(int int_0)
		{
			if (int_0 == 1)
			{
				base.Game.StartScene<MainMenuScene>();
			}
		});
	}

	private void _jiNxMIzuA8Rrc2ULsrob5A7UNDe(ControlCollection controlCollection_0)
	{
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Body", _data.BodyType, delegate(PlayerData.EBodyType ebodyType_0)
		{
			_data.BodyType = ebodyType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Body Color", _data.BodyColor, delegate(Color color_0)
		{
			_data.BodyColor = color_0;
		});
		_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Underbelly Marking", PlayerData.EMarkingsType.Underbelly, _data.UnderbellyColor, delegate(Color color_0)
		{
			_data.UnderbellyColor = color_0;
		});
		_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Underthigh Marking", PlayerData.EMarkingsType.Underthigh, _data.UnderthighColor, delegate(Color color_0)
		{
			_data.UnderthighColor = color_0;
		});
		_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Stripes Marking", PlayerData.EMarkingsType.Stripes, _data.StripesColor, delegate(Color color_0)
		{
			_data.StripesColor = color_0;
		});
		_HdTJZZGoOMNi89T0yAdBraCZMjc(controlCollection_0, "Nails", _data.ShowNails, _data.NailColor, delegate(bool bool_0)
		{
			_data.ShowNails = bool_0;
		}, delegate(Color color_0)
		{
			_data.NailColor = color_0;
		});
	}

	private void _1qIQUjhrbk5WA7C7mYs93gXLOIe(ControlCollection controlCollection_0)
	{
		_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Long Forearm Marking", PlayerData.EMarkingsType.LongForearm, _data.LongForearmColor, delegate(Color color_0)
		{
			_data.LongForearmColor = color_0;
		});
		_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Short Forearm Marking", PlayerData.EMarkingsType.ShortForearm, _data.ShortForearmColor, delegate(Color color_0)
		{
			_data.ShortForearmColor = color_0;
		});
		_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Avian Forearm Marking", PlayerData.EMarkingsType.AvianForearm, _data.AvianForearmColor, delegate(Color color_0)
		{
			_data.AvianForearmColor = color_0;
		});
	}

	private void _VCrdQDifkN8NHlzPICTmtbgWFwp(ControlCollection controlCollection_0)
	{
		_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Long Shin Marking", PlayerData.EMarkingsType.LongShin, _data.LongShinColor, delegate(Color color_0)
		{
			_data.LongShinColor = color_0;
		});
		_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Short Shin Marking", PlayerData.EMarkingsType.ShortShin, _data.ShortShinColor, delegate(Color color_0)
		{
			_data.ShortShinColor = color_0;
		});
		_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Avian Shin Marking", PlayerData.EMarkingsType.AvianShin, _data.AvianShinColor, delegate(Color color_0)
		{
			_data.AvianShinColor = color_0;
		});
	}

	private void _vXrWU56trsuFNc9CNcHuctfkI2S(ControlCollection controlCollection_0)
	{
		Panel defaultHeadPanel = new Panel
		{
			Dock = DockStyle.Fill,
			Visible = (_data.HeadType == PlayerData.EHeadType.Default)
		};
		Panel extraHeadPanel = new Panel
		{
			Dock = DockStyle.Fill,
			Visible = (_data.HeadType == PlayerData.EHeadType.PaperBag)
		};
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Head", _data.HeadType, delegate(PlayerData.EHeadType eheadType_0)
		{
			_data.HeadType = eheadType_0;
			switch (eheadType_0)
			{
			case PlayerData.EHeadType.Default:
				defaultHeadPanel.Visible = true;
				extraHeadPanel.Visible = false;
				break;
			case PlayerData.EHeadType.Humanoid:
				defaultHeadPanel.Visible = false;
				extraHeadPanel.Visible = false;
				break;
			case PlayerData.EHeadType.PaperBag:
				defaultHeadPanel.Visible = false;
				extraHeadPanel.Visible = true;
				break;
			}
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Head Color", _data.HeadColor, delegate(Color color_0)
		{
			_data.HeadColor = color_0;
		});
		_h7MUbT306Ju5xwvamN8SatTR2Mo(defaultHeadPanel.Content.Controls, "Gaunt Marking", PlayerData.EHeadMarkingsType.Gaunt, _data.HeadGauntColor, delegate(Color color_0)
		{
			_data.HeadGauntColor = color_0;
		});
		_h7MUbT306Ju5xwvamN8SatTR2Mo(defaultHeadPanel.Content.Controls, "Scruffy Marking", PlayerData.EHeadMarkingsType.Scruffy, _data.HeadScruffyColor, delegate(Color color_0)
		{
			_data.HeadScruffyColor = color_0;
		});
		_h7MUbT306Ju5xwvamN8SatTR2Mo(defaultHeadPanel.Content.Controls, "Snout Marking", PlayerData.EHeadMarkingsType.Snout, _data.HeadSnoutColor, delegate(Color color_0)
		{
			_data.HeadSnoutColor = color_0;
		});
		_h7MUbT306Ju5xwvamN8SatTR2Mo(defaultHeadPanel.Content.Controls, "Stripes Marking", PlayerData.EHeadMarkingsType.Stripes, _data.HeadStripesColor, delegate(Color color_0)
		{
			_data.HeadStripesColor = color_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(extraHeadPanel.Content.Controls, "Paper Bag Color", _data.PaperBagColor, delegate(Color color_0)
		{
			_data.PaperBagColor = color_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(extraHeadPanel.Content.Controls, "Eyesholes Color", _data.PaperBagEyesColor, delegate(Color color_0)
		{
			_data.PaperBagEyesColor = color_0;
		});
		controlCollection_0.Add(defaultHeadPanel);
		controlCollection_0.Add(extraHeadPanel);
	}

	private void _vg6ASaP7xNqc0jerF3mcrXv4dn7(ControlCollection controlCollection_0)
	{
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Muzzle", _data.MuzzleType, delegate(PlayerData.EMuzzleType emuzzleType_0)
		{
			_data.MuzzleType = emuzzleType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Muzzle Color", _data.MuzzleColor, delegate(Color color_0)
		{
			_data.MuzzleColor = color_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Nose Color", _data.NoseColor, delegate(Color color_0)
		{
			_data.NoseColor = color_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Teeth Color", _data.TeethColor, delegate(Color color_0)
		{
			_data.TeethColor = color_0;
		});
		_HdTJZZGoOMNi89T0yAdBraCZMjc(controlCollection_0, "Muzzle Horn", _data.ShowMuzzleHorn, _data.MuzzleHornColor, delegate(bool bool_0)
		{
			_data.ShowMuzzleHorn = bool_0;
		}, delegate(Color color_0)
		{
			_data.MuzzleHornColor = color_0;
		});
		_HdTJZZGoOMNi89T0yAdBraCZMjc(controlCollection_0, "Muzzle Mask", _data.ShowMuzzleMask, _data.MuzzleMaskColor, delegate(bool bool_0)
		{
			_data.ShowMuzzleMask = bool_0;
		}, delegate(Color color_0)
		{
			_data.MuzzleMaskColor = color_0;
		});
	}

	private void _Xhurp3mVVoR5kNlnxgLoDDkeQxM(ControlCollection controlCollection_0)
	{
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Ears and Horns", _data.HeadAccessoriesType, delegate(PlayerData.EHeadAccessoriesType eheadAccessoriesType_0)
		{
			_data.HeadAccessoriesType = eheadAccessoriesType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Horns Color", _data.HeadHornsColor, delegate(Color color_0)
		{
			_data.HeadHornsColor = color_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Ear Color", _data.EarColor, delegate(Color color_0)
		{
			_data.EarColor = color_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Ear Inner Color", _data.EarInnerColor, delegate(Color color_0)
		{
			_data.EarInnerColor = color_0;
		});
	}

	private void _gHA9C0CRN2NaRMtfTrvlotJOd0T(ControlCollection controlCollection_0)
	{
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Hair", _data.HairstyleType, delegate(PlayerData.EHairstyleType ehairstyleType_0)
		{
			_data.HairstyleType = ehairstyleType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Hair Color", _data.HairColor, delegate(Color color_0)
		{
			_data.HairColor = color_0;
		});
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Fringe", _data.FringeType, delegate(PlayerData.EFringeType efringeType_0)
		{
			_data.FringeType = efringeType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Fringe Color", _data.FringeColor, delegate(Color color_0)
		{
			_data.FringeColor = color_0;
		});
	}

	private void _hNo7o9fG9jvwcKyMq1nYl4q7cXc(ControlCollection controlCollection_0)
	{
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Eyes", _data.EyesType, delegate(PlayerData.EEyesType eeyesType_0)
		{
			_data.EyesType = eeyesType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Eyes Back Color", _data.EyesBackColor, delegate(Color color_0)
		{
			_data.EyesBackColor = color_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Eyes Front Color", _data.EyesFrontColor, delegate(Color color_0)
		{
			_data.EyesFrontColor = color_0;
		});
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Brows", _data.BrowType, delegate(PlayerData.EBrowType ebrowType_0)
		{
			_data.BrowType = ebrowType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Brows Color", _data.BrowColor, delegate(Color color_0)
		{
			_data.BrowColor = color_0;
		});
	}

	private void _mWS8UuA4xcT1bSdjDObiubOE0wH(ControlCollection controlCollection_0)
	{
		Panel _63PX0QXRoq6jeUvG5xheRABNwsg = new Panel
		{
			Dock = DockStyle.Top,
			Visible = (_data.BreastsType != PlayerData.EBreastsType.None)
		};
		Panel _TLsIePSD9UbEwlT0HwKiF2xZX87 = new Panel
		{
			Dock = DockStyle.Top,
			Visible = (_data.CockType != PlayerData.ECockType.None)
		};
		Panel _s9TeQxnG80yYnmcOHHr4bw9fWCh = new Panel
		{
			Dock = DockStyle.Top,
			Visible = (_data.BallsType != PlayerData.EBallsType.None)
		};
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Breasts", _data.BreastsType, delegate(PlayerData.EBreastsType ebreastsType_0)
		{
			_data.BreastsType = ebreastsType_0;
			_63PX0QXRoq6jeUvG5xheRABNwsg.Visible = _data.BreastsType != PlayerData.EBreastsType.None;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(_63PX0QXRoq6jeUvG5xheRABNwsg.Content.Controls, "Breasts Color", _data.BreastsColor, delegate(Color color_0)
		{
			_data.BreastsColor = color_0;
		});
		_HdTJZZGoOMNi89T0yAdBraCZMjc(_63PX0QXRoq6jeUvG5xheRABNwsg.Content.Controls, "Nipples", _data.ShowNipples, _data.NipplesColor, delegate(bool bool_0)
		{
			_data.ShowNipples = bool_0;
		}, delegate(Color color_0)
		{
			_data.NipplesColor = color_0;
		});
		controlCollection_0.Add(_63PX0QXRoq6jeUvG5xheRABNwsg);
		Control _Jhlc8lMI1rq07omae9xc6uig5tv = null;
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Cock", _data.CockType, delegate(PlayerData.ECockType ecockType_0)
		{
			_data.CockType = ecockType_0;
			_TLsIePSD9UbEwlT0HwKiF2xZX87.Visible = _data.CockType != PlayerData.ECockType.None;
			_Jhlc8lMI1rq07omae9xc6uig5tv.Visible = _data.CockType == PlayerData.ECockType.Cut || _data.CockType == PlayerData.ECockType.Uncut;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(_TLsIePSD9UbEwlT0HwKiF2xZX87.Content.Controls, "Cock Color", _data.GenitaliaColor, delegate(Color color_0)
		{
			_data.GenitaliaColor = color_0;
		});
		_Jhlc8lMI1rq07omae9xc6uig5tv = _z5npzs7mj5H3zJ1PF64BFNsXBmm(_TLsIePSD9UbEwlT0HwKiF2xZX87.Content.Controls, "Cock Tip Color", _data.GenitaliaFleshColor, delegate(Color color_0)
		{
			_data.GenitaliaFleshColor = color_0;
		});
		_Jhlc8lMI1rq07omae9xc6uig5tv.Visible = _data.CockType == PlayerData.ECockType.Cut || _data.CockType == PlayerData.ECockType.Uncut;
		controlCollection_0.Add(_TLsIePSD9UbEwlT0HwKiF2xZX87);
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Balls", _data.BallsType, delegate(PlayerData.EBallsType eballsType_0)
		{
			_data.BallsType = eballsType_0;
			_s9TeQxnG80yYnmcOHHr4bw9fWCh.Visible = _data.BallsType != PlayerData.EBallsType.None;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(_s9TeQxnG80yYnmcOHHr4bw9fWCh.Content.Controls, "Balls Color", _data.BallsColor, delegate(Color color_0)
		{
			_data.BallsColor = color_0;
		});
		controlCollection_0.Add(_s9TeQxnG80yYnmcOHHr4bw9fWCh);
	}

	private void _7JR6eL4D0qdIJNOwfInnlg2HEgZ(ControlCollection controlCollection_0)
	{
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Tail", _data.TailType, delegate(PlayerData.ETailType etailType_0)
		{
			_data.TailType = etailType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Tail Color", _data.TailColor, delegate(Color color_0)
		{
			_data.TailColor = color_0;
		});
		_HdTJZZGoOMNi89T0yAdBraCZMjc(controlCollection_0, "Tail Part A", _data.ShowTailPartOne, _data.TailPartOneColor, delegate(bool bool_0)
		{
			_data.ShowTailPartOne = bool_0;
		}, delegate(Color color_0)
		{
			_data.TailPartOneColor = color_0;
		});
		_HdTJZZGoOMNi89T0yAdBraCZMjc(controlCollection_0, "Tail Part B", _data.ShowTailPartTwo, _data.TailPartTwoColor, delegate(bool bool_0)
		{
			_data.ShowTailPartTwo = bool_0;
		}, delegate(Color color_0)
		{
			_data.TailPartTwoColor = color_0;
		});
	}

	private void _PBEdYyzYEWcXAodjVf58ocOQ3Jf(ControlCollection controlCollection_0)
	{
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Feet", _data.FeetType, delegate(PlayerData.EFeetType efeetType_0)
		{
			_data.FeetType = efeetType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Feet Color", _data.FeetColor, delegate(Color color_0)
		{
			_data.FeetColor = color_0;
		});
	}

	public void DrawPlayer(SpriteBatch spriteBatch)
	{
		_shader.Parameters["Time"].SetValue(Randoms.Date);
		PlayerPreferences.Singleton.Draw(spriteBatch, _shader);
	}

	private void _9x3XvoSKr9dMOykq9pl8AKFzwJ(ControlCollection controlCollection_0, string string_0, PlayerData.EMarkingsType EMarkingsType_0, Color color_0, Action<Color> action_0)
	{
		_HdTJZZGoOMNi89T0yAdBraCZMjc(controlCollection_0, string_0, _data.MarkingsType.HasFlag(EMarkingsType_0), color_0, delegate(bool bool_0)
		{
			if (bool_0)
			{
				_data.MarkingsType |= EMarkingsType_0;
			}
			else
			{
				_data.MarkingsType &= ~EMarkingsType_0;
			}
		}, delegate(Color color_0)
		{
			action_0(color_0);
			_skin.RefreshData();
		});
	}

	private void _h7MUbT306Ju5xwvamN8SatTR2Mo(ControlCollection controlCollection_0, string string_0, PlayerData.EHeadMarkingsType _iDe3W6qb7jKTPuJV79yf2i7UoIq_0, Color color_0, Action<Color> action_0)
	{
		_HdTJZZGoOMNi89T0yAdBraCZMjc(controlCollection_0, string_0, _data.HeadMarkingsType.HasFlag(_iDe3W6qb7jKTPuJV79yf2i7UoIq_0), color_0, delegate(bool bool_0)
		{
			if (bool_0)
			{
				_data.HeadMarkingsType |= _iDe3W6qb7jKTPuJV79yf2i7UoIq_0;
			}
			else
			{
				_data.HeadMarkingsType &= ~_iDe3W6qb7jKTPuJV79yf2i7UoIq_0;
			}
		}, delegate(Color color_0)
		{
			action_0(color_0);
			_skin.RefreshData();
		});
	}

	private void _HdTJZZGoOMNi89T0yAdBraCZMjc(ControlCollection controlCollection_0, string string_0, bool bool_0, Color color_0, Action<bool> action_0, Action<Color> action_1)
	{
		CheckBox _SbG09NUiMRUtR5nySpplBTa1qug = new CheckBox
		{
			Dock = DockStyle.Top,
			Text = string_0,
			Checked = bool_0,
			Margin = new Margin(0, 0, 0, 5)
		};
		Control _XXaN99sI8FddBJPpuffIrCZZ49q = _lV0oshnYavLGLHyogGNxv60JpoM(string_0 + " Color", color_0, action_1);
		_XXaN99sI8FddBJPpuffIrCZZ49q.Visible = _SbG09NUiMRUtR5nySpplBTa1qug.Checked;
		controlCollection_0.Add(_SbG09NUiMRUtR5nySpplBTa1qug);
		controlCollection_0.Add(_XXaN99sI8FddBJPpuffIrCZZ49q);
		_SbG09NUiMRUtR5nySpplBTa1qug.CheckedChanged += delegate
		{
			_XXaN99sI8FddBJPpuffIrCZZ49q.Visible = _SbG09NUiMRUtR5nySpplBTa1qug.Checked;
			action_0(_SbG09NUiMRUtR5nySpplBTa1qug.Checked);
			_skin.RefreshData();
		};
	}

	private Control _z5npzs7mj5H3zJ1PF64BFNsXBmm(ControlCollection controlCollection_0, string string_0, Color color_0, Action<Color> action_0)
	{
		Control control = _lV0oshnYavLGLHyogGNxv60JpoM(string_0, color_0, action_0);
		controlCollection_0.Add(control);
		return control;
	}

	private Control _lV0oshnYavLGLHyogGNxv60JpoM(string string_0, Color color_0, Action<Color> action_0)
	{
		Control control = new Control
		{
			Dock = DockStyle.Top,
			Margin = new Margin(0, 0, 0, 5)
		};
		ImageControl image = new ImageControl
		{
			Dock = DockStyle.Left,
			Size = new Squid.Point(29, AmorousData.ButtonHeight),
			Color = ColorInt.ARGB(color_0.A, color_0.R, color_0.G, color_0.B)
		};
		Label item = new Label
		{
			Dock = DockStyle.Fill,
			Text = string_0,
			Margin = new Margin(5, 0, 0, 0)
		};
		image.MouseClick += delegate
		{
			_gaKeabKyjzz2jeJCEYxHW9Gc8CGA(string_0, color_0, delegate(Color color_0)
			{
				image.Color = ColorInt.ARGB(color_0.A, color_0.R, color_0.G, color_0.B);
				action_0(color_0);
				_skin.RefreshData();
			});
		};
		control.GetElements().Add(image);
		control.GetElements().Add(item);
		return control;
	}

	private void _WPOv8yATDl2g7nDSf8itt8V399K(Button button_0)
	{
		_backgroundPanel.Content.Controls.Clear();
		int num = _categories.FindIndex((Button button_0) => object.Equals(button_0, button_0));
		for (int i = 0; i <= num; i++)
		{
			_categories[i].Dock = DockStyle.Top;
			_backgroundPanel.Content.Controls.Add(_categories[i]);
		}
		for (int num2 = _categories.Count - 1; num2 > num; num2--)
		{
			_categories[num2].Dock = DockStyle.Bottom;
			_backgroundPanel.Content.Controls.Add(_categories[num2]);
		}
		_backgroundPanel.Content.Controls.Add(_foregroundPanel);
	}

	private Button NewCategory(string string_0, Action action_0)
	{
		Button button = new Button
		{
			Dock = DockStyle.Top,
			TextAlign = Alignment.MiddleCenter,
			Text = string_0,
			Style = "buttonOpaque"
		};
		if (action_0 != null)
		{
			button.MouseClick += delegate
			{
				_foregroundPanel.Content.Controls.Clear();
				_foregroundPanel.VScroll.Value = 0f;
				_WPOv8yATDl2g7nDSf8itt8V399K(button);
				action_0();
			};
		}
		_backgroundPanel.Content.Controls.Add(button);
		return button;
	}

	private void AttachDropDownList(ControlCollection controlCollection_0, string string_0, string[] string_1, int int_0, Action<int> action_0)
	{
		Label item = new Label
		{
			Text = string_0,
			Dock = DockStyle.Top
		};
		DropDownList dropDownList = new DropDownList();
		dropDownList.Dock = DockStyle.Top;
		dropDownList.Style = "button";
		dropDownList.Label.Margin = new Margin(10, 0, 0, 0);
		dropDownList.Dropdown.Resizable = false;
		dropDownList.Margin = new Margin(0, 0, 0, 5);
		DropDownList dropDownList2 = dropDownList;
		dropDownList2.Listbox.Scrollbar.ButtonUp.Visible = false;
		dropDownList2.Listbox.Scrollbar.ButtonDown.Visible = false;
		for (int i = 0; i < string_1.Length; i++)
		{
			dropDownList2.Items.Add(new ListBoxItem
			{
				Text = string_1[i],
				Value = i,
				Selected = (i == int_0),
				Size = new Squid.Point(0, AmorousData.ButtonHeight)
			});
		}
		dropDownList2.SelectedItemChanged += delegate(Control control_0, ListBoxItem listBoxItem_0)
		{
			action_0((int)listBoxItem_0.Value);
			_skin.RefreshData();
		};
		controlCollection_0.Add(item);
		controlCollection_0.Add(dropDownList2);
	}

	private void _bABf372CnRI0x85NIaTEbIUNZ10<T>(ControlCollection controlCollection_0, string string_0, T gparam_0, Action<T> action_0)
	{
		int num = (int)(object)gparam_0;
		Label item = new Label
		{
			Text = string_0,
			Dock = DockStyle.Top
		};
		DropDownList dropDownList = new DropDownList();
		dropDownList.Dock = DockStyle.Top;
		dropDownList.Style = "button";
		dropDownList.Label.Margin = new Margin(10, 0, 0, 0);
		dropDownList.Dropdown.Resizable = false;
		dropDownList.Margin = new Margin(0, 0, 0, 5);
		DropDownList dropDownList2 = dropDownList;
		dropDownList2.Listbox.Scrollbar.ButtonUp.Visible = false;
		dropDownList2.Listbox.Scrollbar.ButtonDown.Visible = false;
		string[] names = Enum.GetNames(typeof(T));
		Array values = Enum.GetValues(typeof(T));
		for (int i = 0; i < names.Length; i++)
		{
			string text = names[i];
			int num2 = (int)values.GetValue(i);
			dropDownList2.Items.Add(new ListBoxItem
			{
				Text = text,
				Value = values.GetValue(i),
				Selected = (num2 == num),
				Size = new Squid.Point(0, AmorousData.ButtonHeight)
			});
		}
		dropDownList2.SelectedItemChanged += delegate(Control control_0, ListBoxItem listBoxItem_0)
		{
			action_0((T)listBoxItem_0.Value);
			_skin.RefreshData();
		};
		controlCollection_0.Add(item);
		controlCollection_0.Add(dropDownList2);
	}

	private void _gaKeabKyjzz2jeJCEYxHW9Gc8CGA(string string_0, Color color_0, Action<Color> action_0)
	{
		if (_colorPicker != null)
		{
			_colorPicker.Close();
		}
		Window pickerWindow = new Window
		{
			Dock = DockStyle.Right,
			AutoSize = AutoSize.HorizontalVertical,
			Margin = new Margin(8, 8, 0, 8)
		};
		_colorPicker = pickerWindow;
		Panel panel = new Panel();
		panel.Size = new Squid.Point(307, 519);
		panel.ClipFrame.Margin = new Margin(16, 8, 16, 16);
		Panel panel2 = panel;
		pickerWindow.Controls.Add(panel2);
		Label item = new Label
		{
			Dock = DockStyle.Top,
			Text = string_0,
			TextAlign = Alignment.MiddleCenter
		};
		Panel panel3 = new Panel
		{
			Dock = DockStyle.Top,
			Size = new Squid.Point(275, 250)
		};
		ImageControl image = new ImageControl
		{
			Dock = DockStyle.Left,
			Texture = "ColorPickerBox",
			Size = new Squid.Point(250, 250)
		};
		ImageControl image2 = new ImageControl
		{
			Dock = DockStyle.Fill,
			Texture = "ColorPickerSlider",
			Size = new Squid.Point(25, 250)
		};
		panel3.Content.Controls.Add(image);
		panel3.Content.Controls.Add(image2);
		ImageControl image3 = new ImageControl
		{
			Dock = DockStyle.Top,
			Size = new Squid.Point(275, 25),
			Color = ColorInt.ARGB(color_0.A, color_0.R, color_0.G, color_0.B),
			Margin = new Margin(0, 0, 0, 8)
		};
		Panel panel4 = new Panel
		{
			Dock = DockStyle.Top,
			Size = new Squid.Point(275, AmorousData.ButtonHeight),
			Margin = new Margin(0, 0, 0, 8)
		};
		Label item2 = new Label
		{
			Dock = DockStyle.Left,
			Text = "H:",
			TextAlign = Alignment.MiddleCenter,
			Size = new Squid.Point(AmorousData.ButtonHeight, AmorousData.ButtonHeight)
		};
		TextBox text = new TextBox
		{
			Dock = DockStyle.Left,
			Size = new Squid.Point(107, AmorousData.ButtonHeight),
			TabIndex = 1
		};
		Label item3 = new Label
		{
			Dock = DockStyle.Left,
			Text = "R:",
			TextAlign = Alignment.MiddleCenter,
			Size = new Squid.Point(AmorousData.ButtonHeight, AmorousData.ButtonHeight)
		};
		TextBox text2 = new TextBox
		{
			Dock = DockStyle.Fill,
			TabIndex = 4
		};
		panel4.Content.Controls.Add(item2);
		panel4.Content.Controls.Add(text);
		panel4.Content.Controls.Add(item3);
		panel4.Content.Controls.Add(text2);
		Panel panel5 = new Panel
		{
			Dock = DockStyle.Top,
			Size = new Squid.Point(275, AmorousData.ButtonHeight),
			Margin = new Margin(0, 0, 0, 8)
		};
		Label item4 = new Label
		{
			Dock = DockStyle.Left,
			Text = "S:",
			TextAlign = Alignment.MiddleCenter,
			Size = new Squid.Point(AmorousData.ButtonHeight, AmorousData.ButtonHeight)
		};
		TextBox text3 = new TextBox
		{
			Dock = DockStyle.Left,
			Size = new Squid.Point(107, AmorousData.ButtonHeight),
			TabIndex = 2
		};
		Label item5 = new Label
		{
			Dock = DockStyle.Left,
			Text = "G:",
			TextAlign = Alignment.MiddleCenter,
			Size = new Squid.Point(AmorousData.ButtonHeight, AmorousData.ButtonHeight)
		};
		TextBox text4 = new TextBox
		{
			Dock = DockStyle.Fill,
			TabIndex = 5
		};
		panel5.Content.Controls.Add(item4);
		panel5.Content.Controls.Add(text3);
		panel5.Content.Controls.Add(item5);
		panel5.Content.Controls.Add(text4);
		Panel panel6 = new Panel
		{
			Dock = DockStyle.Top,
			Size = new Squid.Point(275, AmorousData.ButtonHeight),
			Margin = new Margin(0, 0, 0, 8)
		};
		Label item6 = new Label
		{
			Dock = DockStyle.Left,
			Text = "V:",
			TextAlign = Alignment.MiddleCenter,
			Size = new Squid.Point(AmorousData.ButtonHeight, AmorousData.ButtonHeight)
		};
		TextBox text5 = new TextBox
		{
			Dock = DockStyle.Left,
			Size = new Squid.Point(107, AmorousData.ButtonHeight),
			TabIndex = 3
		};
		Label item7 = new Label
		{
			Dock = DockStyle.Left,
			Text = "B:",
			TextAlign = Alignment.MiddleCenter,
			Size = new Squid.Point(AmorousData.ButtonHeight, AmorousData.ButtonHeight)
		};
		TextBox text6 = new TextBox
		{
			Dock = DockStyle.Fill,
			TabIndex = 6
		};
		panel6.Content.Controls.Add(item6);
		panel6.Content.Controls.Add(text5);
		panel6.Content.Controls.Add(item7);
		panel6.Content.Controls.Add(text6);
		Panel panel7 = new Panel
		{
			Dock = DockStyle.Top,
			Size = new Squid.Point(275, AmorousData.ButtonHeight),
			Margin = new Margin(0, 0, 0, 8)
		};
		Label item8 = new Label
		{
			Dock = DockStyle.Left,
			Text = "Hex:",
			TextAlign = Alignment.MiddleCenter,
			Size = new Squid.Point(45, AmorousData.ButtonHeight)
		};
		TextBox text7 = new TextBox
		{
			Dock = DockStyle.Fill,
			TabIndex = 7
		};
		panel7.Content.Controls.Add(item8);
		panel7.Content.Controls.Add(text7);
		ImageControl image4 = new ImageControl
		{
			Size = new Squid.Point(6, 6),
			Color = ColorInt.ARGB(0.9f, 1f, 1f, 1f)
		};
		ImageControl image5 = new ImageControl
		{
			Size = new Squid.Point(25, 6),
			Color = ColorInt.ARGB(0.9f, 1f, 1f, 1f)
		};
		pickerWindow.Controls.Add(image4);
		pickerWindow.Controls.Add(image5);
		Button button = new Button
		{
			Dock = DockStyle.Fill,
			Text = "Close",
			TextAlign = Alignment.MiddleCenter
		};
		button.MouseClick += delegate
		{
			_colorPicker.Close();
		};
		panel2.Content.Controls.Add(item);
		panel2.Content.Controls.Add(panel3);
		panel2.Content.Controls.Add(image3);
		panel2.Content.Controls.Add(panel4);
		panel2.Content.Controls.Add(panel5);
		panel2.Content.Controls.Add(panel6);
		panel2.Content.Controls.Add(panel7);
		panel2.Content.Controls.Add(panel7);
		panel2.Content.Controls.Add(button);
		pickerWindow.Show(base.Squid);
		Color color3 = color_0;
		_fA3AcauqZZ0ncWKv9QA3iklruOI(color_0, out var _kyexzK2VL0y9etRuX79HInHIsIb, out var _46o2iZ9juR1nNURyrP41h9vxpGA, out var _xX4CfdHl6arem4v3fUgbDUIK2gM);
		Texture2D _3PAjrCP0TE07YQ22X6EIpPwOlib = new Texture2D(base.Game.GLES, 250, 250, mipMap: false, SurfaceFormat.Color);
		int[] _Vo3fFvvroxYzfCOI5F4PqiMr0Gb = new int[_3PAjrCP0TE07YQ22X6EIpPwOlib.Width * _3PAjrCP0TE07YQ22X6EIpPwOlib.Height];
		for (int i = 0; i < _3PAjrCP0TE07YQ22X6EIpPwOlib.Height; i++)
		{
			for (int j = 0; j < _3PAjrCP0TE07YQ22X6EIpPwOlib.Width; j++)
			{
				Color color = _lAdyiyyWQrRKWYduTPacHqdzOmj(_kyexzK2VL0y9etRuX79HInHIsIb, (float)j / (float)_3PAjrCP0TE07YQ22X6EIpPwOlib.Width, ((float)_3PAjrCP0TE07YQ22X6EIpPwOlib.Height - (float)i) / (float)_3PAjrCP0TE07YQ22X6EIpPwOlib.Height, 1f);
				_Vo3fFvvroxYzfCOI5F4PqiMr0Gb[i * _3PAjrCP0TE07YQ22X6EIpPwOlib.Width + j] = (int)color.PackedValue;
			}
		}
		_3PAjrCP0TE07YQ22X6EIpPwOlib.SetData(_Vo3fFvvroxYzfCOI5F4PqiMr0Gb);
		Texture2D texture2D = new Texture2D(base.Game.GLES, 25, 250, mipMap: false, SurfaceFormat.Color);
		int[] array = new int[texture2D.Width * texture2D.Height];
		for (int k = 0; k < texture2D.Height; k++)
		{
			Color color2 = _lAdyiyyWQrRKWYduTPacHqdzOmj(((float)texture2D.Height - (float)k) / (float)texture2D.Height * 360f, 1.0, 1.0, 1f);
			for (int l = 0; l < texture2D.Width; l++)
			{
				array[k * texture2D.Width + l] = (int)color2.PackedValue;
			}
		}
		texture2D.SetData(array);
		Gui.Renderer.SetTexture("ColorPickerBox", _3PAjrCP0TE07YQ22X6EIpPwOlib);
		Gui.Renderer.SetTexture("ColorPickerSlider", texture2D);
		Action _XDKgJpkUD4lIN2K7ysMOtqO5gMA = delegate
		{
			image4.Position = new Squid.Point(13 + (int)(_46o2iZ9juR1nNURyrP41h9vxpGA * 250f), 35 + (int)(250f - _xX4CfdHl6arem4v3fUgbDUIK2gM * 250f));
			image5.Position = new Squid.Point(266, 35 + (int)(250f - 250f * (_kyexzK2VL0y9etRuX79HInHIsIb / 360f)));
			image3.Color = ColorInt.ARGB(color3.A, color3.R, color3.G, color3.B);
			text.Text = ((int)_kyexzK2VL0y9etRuX79HInHIsIb).ToString();
			text3.Text = ((int)(_46o2iZ9juR1nNURyrP41h9vxpGA * 100f)).ToString();
			text5.Text = ((int)(_xX4CfdHl6arem4v3fUgbDUIK2gM * 100f)).ToString();
			text2.Text = color3.R.ToString();
			text4.Text = color3.G.ToString();
			text6.Text = color3.B.ToString();
			text7.Text = $"#{color3.R:X2}{color3.G:X2}{color3.B:X2}";
		};
		_XDKgJpkUD4lIN2K7ysMOtqO5gMA();
		bool _a7vdsaGCzLloXi7sntZm1rCdbZK = false;
		bool _FxCuMzbCIAsYKlL8DmmchjsMpir = false;
		image.Update += delegate
		{
			if (!_FxCuMzbCIAsYKlL8DmmchjsMpir)
			{
				if (base.Game.Controller.IsHolding(ControllerButtonType.LeftButton))
				{
					if (!_a7vdsaGCzLloXi7sntZm1rCdbZK && Gui.MousePosition.x >= image.Location.x && Gui.MousePosition.x <= image.Location.x + image.Size.x && Gui.MousePosition.y >= image.Location.y && Gui.MousePosition.y <= image.Location.y + image.Size.y)
					{
						_a7vdsaGCzLloXi7sntZm1rCdbZK = true;
					}
					if (_a7vdsaGCzLloXi7sntZm1rCdbZK)
					{
						Squid.Point point2 = Gui.MousePosition - image.Location;
						point2.x = (int)MathHelper.Clamp(point2.x, 0f, 250f);
						point2.y = (int)MathHelper.Clamp(point2.y, 0f, 250f);
						_46o2iZ9juR1nNURyrP41h9vxpGA = (float)point2.x / 250f;
						_xX4CfdHl6arem4v3fUgbDUIK2gM = (250f - (float)point2.y) / 250f;
						color3 = _lAdyiyyWQrRKWYduTPacHqdzOmj(_kyexzK2VL0y9etRuX79HInHIsIb, _46o2iZ9juR1nNURyrP41h9vxpGA, _xX4CfdHl6arem4v3fUgbDUIK2gM, 1f);
						_XDKgJpkUD4lIN2K7ysMOtqO5gMA();
						action_0(color3);
					}
				}
				else
				{
					_a7vdsaGCzLloXi7sntZm1rCdbZK = false;
				}
			}
		};
		image2.Update += delegate
		{
			if (!_a7vdsaGCzLloXi7sntZm1rCdbZK)
			{
				if (base.Game.Controller.IsHolding(ControllerButtonType.LeftButton))
				{
					if (!_FxCuMzbCIAsYKlL8DmmchjsMpir && Gui.MousePosition.x >= image2.Location.x && Gui.MousePosition.x <= image2.Location.x + image2.Size.x && Gui.MousePosition.y >= image2.Location.y && Gui.MousePosition.y <= image2.Location.y + image2.Size.y)
					{
						_FxCuMzbCIAsYKlL8DmmchjsMpir = true;
					}
					if (_FxCuMzbCIAsYKlL8DmmchjsMpir)
					{
						Squid.Point point = Gui.MousePosition - image2.Location;
						point.y = (int)MathHelper.Clamp(point.y, 0f, 250f);
						_kyexzK2VL0y9etRuX79HInHIsIb = 360f - (float)point.y / 250f * 360f;
						for (int m = 0; m < _3PAjrCP0TE07YQ22X6EIpPwOlib.Height; m++)
						{
							for (int n = 0; n < _3PAjrCP0TE07YQ22X6EIpPwOlib.Width; n++)
							{
								Color color3 = _lAdyiyyWQrRKWYduTPacHqdzOmj(_kyexzK2VL0y9etRuX79HInHIsIb, (float)n / (float)_3PAjrCP0TE07YQ22X6EIpPwOlib.Width, ((float)_3PAjrCP0TE07YQ22X6EIpPwOlib.Height - (float)m) / (float)_3PAjrCP0TE07YQ22X6EIpPwOlib.Height, 1f);
								_Vo3fFvvroxYzfCOI5F4PqiMr0Gb[m * _3PAjrCP0TE07YQ22X6EIpPwOlib.Width + n] = (int)color3.PackedValue;
							}
						}
						_3PAjrCP0TE07YQ22X6EIpPwOlib.SetData(_Vo3fFvvroxYzfCOI5F4PqiMr0Gb);
						color3 = _lAdyiyyWQrRKWYduTPacHqdzOmj(_kyexzK2VL0y9etRuX79HInHIsIb, _46o2iZ9juR1nNURyrP41h9vxpGA, _xX4CfdHl6arem4v3fUgbDUIK2gM, 1f);
						_XDKgJpkUD4lIN2K7ysMOtqO5gMA();
						action_0(color3);
					}
				}
				else
				{
					_FxCuMzbCIAsYKlL8DmmchjsMpir = false;
				}
			}
		};
		text.TextCommit += delegate
		{
			if (int.TryParse(text.Text, out var result6))
			{
				_kyexzK2VL0y9etRuX79HInHIsIb = Math.Max(0, Math.Min(result6, 360));
				color3 = _lAdyiyyWQrRKWYduTPacHqdzOmj(_kyexzK2VL0y9etRuX79HInHIsIb, _46o2iZ9juR1nNURyrP41h9vxpGA, _xX4CfdHl6arem4v3fUgbDUIK2gM, 1f);
				action_0(color3);
			}
			_XDKgJpkUD4lIN2K7ysMOtqO5gMA();
		};
		text3.TextCommit += delegate
		{
			if (int.TryParse(text3.Text, out var result5))
			{
				_46o2iZ9juR1nNURyrP41h9vxpGA = (float)Math.Max(0, Math.Min(result5, 100)) / 100f;
				color3 = _lAdyiyyWQrRKWYduTPacHqdzOmj(_kyexzK2VL0y9etRuX79HInHIsIb, _46o2iZ9juR1nNURyrP41h9vxpGA, _xX4CfdHl6arem4v3fUgbDUIK2gM, 1f);
				action_0(color3);
			}
			_XDKgJpkUD4lIN2K7ysMOtqO5gMA();
		};
		text5.TextCommit += delegate
		{
			if (int.TryParse(text5.Text, out var result4))
			{
				_xX4CfdHl6arem4v3fUgbDUIK2gM = (float)Math.Max(0, Math.Min(result4, 100)) / 100f;
				color3 = _lAdyiyyWQrRKWYduTPacHqdzOmj(_kyexzK2VL0y9etRuX79HInHIsIb, _46o2iZ9juR1nNURyrP41h9vxpGA, _xX4CfdHl6arem4v3fUgbDUIK2gM, 1f);
				action_0(color3);
			}
			_XDKgJpkUD4lIN2K7ysMOtqO5gMA();
		};
		text2.TextCommit += delegate
		{
			if (int.TryParse(text2.Text, out var result3))
			{
				color3.R = (byte)Math.Max(0, Math.Min(result3, 255));
				_fA3AcauqZZ0ncWKv9QA3iklruOI(color3, out _kyexzK2VL0y9etRuX79HInHIsIb, out _46o2iZ9juR1nNURyrP41h9vxpGA, out _xX4CfdHl6arem4v3fUgbDUIK2gM);
				action_0(color3);
			}
			_XDKgJpkUD4lIN2K7ysMOtqO5gMA();
		};
		text4.TextCommit += delegate
		{
			if (int.TryParse(text4.Text, out var result2))
			{
				color3.G = (byte)Math.Max(0, Math.Min(result2, 255));
				_fA3AcauqZZ0ncWKv9QA3iklruOI(color3, out _kyexzK2VL0y9etRuX79HInHIsIb, out _46o2iZ9juR1nNURyrP41h9vxpGA, out _xX4CfdHl6arem4v3fUgbDUIK2gM);
				action_0(color3);
			}
			_XDKgJpkUD4lIN2K7ysMOtqO5gMA();
		};
		text6.TextCommit += delegate
		{
			if (int.TryParse(text6.Text, out var result))
			{
				color3.B = (byte)Math.Max(0, Math.Min(result, 255));
				_fA3AcauqZZ0ncWKv9QA3iklruOI(color3, out _kyexzK2VL0y9etRuX79HInHIsIb, out _46o2iZ9juR1nNURyrP41h9vxpGA, out _xX4CfdHl6arem4v3fUgbDUIK2gM);
				action_0(color3);
			}
			_XDKgJpkUD4lIN2K7ysMOtqO5gMA();
		};
		text7.TextCommit += delegate
		{
			if (text7.Text.StartsWith("#") && text7.Text.Length <= 7)
			{
				try
				{
					int num = Convert.ToInt32(text7.Text.Substring(1), 16);
					color3.B = (byte)((uint)num & 0xFFu);
					color3.G = (byte)((uint)(num >> 8) & 0xFFu);
					color3.R = (byte)((uint)(num >> 16) & 0xFFu);
					_fA3AcauqZZ0ncWKv9QA3iklruOI(color3, out _kyexzK2VL0y9etRuX79HInHIsIb, out _46o2iZ9juR1nNURyrP41h9vxpGA, out _xX4CfdHl6arem4v3fUgbDUIK2gM);
					action_0(color3);
				}
				catch
				{
				}
			}
			_XDKgJpkUD4lIN2K7ysMOtqO5gMA();
		};
		pickerWindow.Update += delegate
		{
			if (base.Game.Controller.IsPressed(Microsoft.Xna.Framework.Input.Keys.Escape))
			{
				pickerWindow.Close();
				_colorPicker = null;
			}
		};
	}

	public static void _fA3AcauqZZ0ncWKv9QA3iklruOI(Color color_0, out float float_0, out float float_1, out float float_2)
	{
		float num = 0f;
		float num2 = (int)Math.Min(Math.Min(color_0.R, color_0.G), color_0.B);
		float num3 = (int)Math.Max(Math.Max(color_0.R, color_0.G), color_0.B);
		float num4 = num3 - num2;
		float num5 = ((!((double)num3 <= 0.0)) ? (num4 / num3) : 0f);
		if (num5 > 0f)
		{
			if ((float)(int)color_0.R <= num3)
			{
				num = (float)(color_0.G - color_0.B) / num4;
			}
			else if ((float)(int)color_0.G <= num3)
			{
				num = 2f + (float)(color_0.B - color_0.R) / num4;
			}
			else if ((float)(int)color_0.B <= num3)
			{
				num = 4f + (float)(color_0.R - color_0.G) / num4;
			}
			num *= 60f;
			if ((double)num <= 0.0)
			{
				num += 360f;
			}
		}
		else
		{
			num = 360f;
		}
		float_0 = num;
		float_1 = (float)Math.Round(num5, 2);
		float_2 = num3 / 255f;
	}

	private static Color _lAdyiyyWQrRKWYduTPacHqdzOmj(double double_0, double double_1, double double_2, float a)
	{
		double r;
		double g;
		double b;
		if (double_1 <= 0.0)
		{
			r = double_2;
			g = double_2;
			b = double_2;
		}
		else
		{
			double_0 = ((!(double_0 >= 360.0)) ? (double_0 / 60.0) : 0.0);
			int num4 = (int)double_0;
			double num5 = double_0 - (double)num4;
			double num6 = double_2 * (1.0 - double_1);
			double num7 = double_2 * (1.0 - double_1 * num5);
			double num8 = double_2 * (1.0 - double_1 * (1.0 - num5));
			switch (num4)
			{
				default:
					r = double_2;
					g = num6;
					b = num7;
					break;
				case 0:
					r = double_2;
					g = num8;
					b = num6;
					break;
				case 1:
					r = num7;
					g = double_2;
					b = num6;
					break;
				case 2:
					r = num6;
					g = double_2;
					b = num8;
					break;
				case 3:
					r = num6;
					g = num7;
					b = double_2;
					break;
				case 4:
					r = num8;
					g = num6;
					b = double_2;
					break;
			}
		}
		return new Color((float)r, (float)g, (float)b, a);
	}
}
