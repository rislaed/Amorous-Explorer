using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
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

	protected bool _jIGpzoYLVPw8SPxmJcha832nCXR;
	private CustomizablePlayerSkin CustomizableSkin;
	private Panel _0jH3FoV36utxuSLivmD6IZNwppA;
	private List<Button> _kG9DrP49ggNdZOvVMMUPjfqdzZ4;
	private Panel _TbkP67ntBpYJu1M27pBfsYAHmgJ;
	private readonly PlayerDataProxy Data;
	private Window _hSPLyBveOIKpCKgimgpgcMUDdRz;
	private readonly Effect _9jklVVcQQYcyqOYrkPiht2VP0IG;

	private readonly List<SexsceneData> Sexscenes = new List<SexsceneData>
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

	private readonly string[] _LTwaEzSn23m9dquR3WwhTVRbJiG;
	private int _IyCJr9wgsrQgOUaXQco1I00YF7B;
	private int _3yqpoxOljKnrj7mGlnrA0eOUMAk;
	private int _QjFuG8JMGq8rGnavgUdgnBEKBfD;

	protected virtual string ReturnToGameText => "Exit";

	public PlayerCustomizationScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/Bedroom/Bedroom", -458, 0);
		AddLayer(new _fAUddQEKfZyemRb327NhM3GGlmzA(this, "Custom")
		{
			_B6VrMlmWofCGqEzjzgFJiAliCge = _KkwafXXLVg1QfQgqqCAojg2ySyZ
		}, 0);
		_LTwaEzSn23m9dquR3WwhTVRbJiG = Sexscenes.Select((SexsceneData sexsceneData_0) => sexsceneData_0.Name).ToArray();
		Data = new PlayerDataProxy(PlayerPreferences.GetPlayerData());
		Data.OnChange += delegate
		{
			if (base.Game.Sexscene != null)
			{
				base.Game.Sexscene._0cFb48aKbcbREkHm9Jwptl6r6Vi();
			}
		};
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/Blazing Dragon - Midnight Sizzle", 0.4f);
		_9jklVVcQQYcyqOYrkPiht2VP0IG = Game.Content.Load<Effect>("Assets/Shaders/Breathing");
	}

	public override void StopCutscene()
	{
		CustomizableSkin = new CustomizablePlayerSkin(base.Game);
		_hI8MfcRDpV9Q45afjBJe8lA5sbr();
		PlayerPreferences.SetPlayerSkin(CustomizableSkin);
		_dJMkrCEG7sVmAlGOM9PfNSkFZZC();
	}

	protected virtual void _hI8MfcRDpV9Q45afjBJe8lA5sbr()
	{
		if (CustomizableSkin._I6gsCHlb2BKFCJSAk9Cn5fCMAPu.Any())
		{
			CustomizableSkin._BCRMBb9uhQZrQlfdXPidu27yb8C(0);
			Data.Name = CustomizableSkin._6qwooGF3jWmbG9887Y5IKZ8fJ0E(0);
			_QjFuG8JMGq8rGnavgUdgnBEKBfD = 0;
		}
		else
		{
			CustomizableSkin._BwV21jdCpo4YpIp6x74bJ0H7hut(0);
			Data.Name = "Player";
			_QjFuG8JMGq8rGnavgUdgnBEKBfD = -1;
		}
	}

	private void _dJMkrCEG7sVmAlGOM9PfNSkFZZC()
	{
		Window window = new Window
		{
			Dock = DockStyle.Right,
			Size = new Squid.Point(512, 0),
			Margin = new Margin(8),
			Padding = new Margin(8)
		};
		_0jH3FoV36utxuSLivmD6IZNwppA = new Panel
		{
			Dock = DockStyle.Fill
		};
		window.Controls.Add(_0jH3FoV36utxuSLivmD6IZNwppA);
		Panel panel = new Panel();
		panel.Dock = DockStyle.Fill;
		panel.ClipFrame.Margin = new Margin(8);
		_TbkP67ntBpYJu1M27pBfsYAHmgJ = panel;
		_kG9DrP49ggNdZOvVMMUPjfqdzZ4 = new List<Button>
		{
			_cvldkRXLM8Toadgv6nPx5QH1EES("Fursona", delegate
			{
				_OBIbaNO8X49ahEZ5n3Ta8HUK7mO(_TbkP67ntBpYJu1M27pBfsYAHmgJ.Content.Controls);
			}),
			_cvldkRXLM8Toadgv6nPx5QH1EES("Body", delegate
			{
				_jiNxMIzuA8Rrc2ULsrob5A7UNDe(_TbkP67ntBpYJu1M27pBfsYAHmgJ.Content.Controls);
			}),
			_cvldkRXLM8Toadgv6nPx5QH1EES("Arms", delegate
			{
				_1qIQUjhrbk5WA7C7mYs93gXLOIe(_TbkP67ntBpYJu1M27pBfsYAHmgJ.Content.Controls);
			}),
			_cvldkRXLM8Toadgv6nPx5QH1EES("Legs", delegate
			{
				_VCrdQDifkN8NHlzPICTmtbgWFwp(_TbkP67ntBpYJu1M27pBfsYAHmgJ.Content.Controls);
			}),
			_cvldkRXLM8Toadgv6nPx5QH1EES("Head", delegate
			{
				_vXrWU56trsuFNc9CNcHuctfkI2S(_TbkP67ntBpYJu1M27pBfsYAHmgJ.Content.Controls);
			}),
			_cvldkRXLM8Toadgv6nPx5QH1EES("Muzzle", delegate
			{
				_vg6ASaP7xNqc0jerF3mcrXv4dn7(_TbkP67ntBpYJu1M27pBfsYAHmgJ.Content.Controls);
			}),
			_cvldkRXLM8Toadgv6nPx5QH1EES("Ears and Horns", delegate
			{
				_Xhurp3mVVoR5kNlnxgLoDDkeQxM(_TbkP67ntBpYJu1M27pBfsYAHmgJ.Content.Controls);
			}),
			_cvldkRXLM8Toadgv6nPx5QH1EES("Hair and Fringes", delegate
			{
				_gHA9C0CRN2NaRMtfTrvlotJOd0T(_TbkP67ntBpYJu1M27pBfsYAHmgJ.Content.Controls);
			}),
			_cvldkRXLM8Toadgv6nPx5QH1EES("Eyes and Brows", delegate
			{
				_hNo7o9fG9jvwcKyMq1nYl4q7cXc(_TbkP67ntBpYJu1M27pBfsYAHmgJ.Content.Controls);
			})
		};
		if (!Censorship.Censored)
		{
			_kG9DrP49ggNdZOvVMMUPjfqdzZ4.Add(_cvldkRXLM8Toadgv6nPx5QH1EES("Breasts, Cock and Balls", delegate
			{
				_mWS8UuA4xcT1bSdjDObiubOE0wH(_TbkP67ntBpYJu1M27pBfsYAHmgJ.Content.Controls);
			}));
		}
		_kG9DrP49ggNdZOvVMMUPjfqdzZ4.Add(_cvldkRXLM8Toadgv6nPx5QH1EES("Tail", delegate
		{
			_7JR6eL4D0qdIJNOwfInnlg2HEgZ(_TbkP67ntBpYJu1M27pBfsYAHmgJ.Content.Controls);
		}));
		_kG9DrP49ggNdZOvVMMUPjfqdzZ4.Add(_cvldkRXLM8Toadgv6nPx5QH1EES("Feet", delegate
		{
			_PBEdYyzYEWcXAodjVf58ocOQ3Jf(_TbkP67ntBpYJu1M27pBfsYAHmgJ.Content.Controls);
		}));
		window.Show(base.Squid);
		_kG9DrP49ggNdZOvVMMUPjfqdzZ4[0].Click(0);
	}

	private void _OBIbaNO8X49ahEZ5n3Ta8HUK7mO(ControlCollection controlCollection_0)
	{
		controlCollection_0.Add(new Label
		{
			Dock = DockStyle.Top,
			Text = "Name"
		});
		TextBox _Z0ib1EsNAOHar3w2AfvKgeb8s2BA = new TextBox
		{
			Dock = DockStyle.Top,
			Text = Data.Name,
			Margin = new Margin(0, 0, 0, 5)
		};
		_Z0ib1EsNAOHar3w2AfvKgeb8s2BA.TextChanged += delegate
		{
			Data.Name = _Z0ib1EsNAOHar3w2AfvKgeb8s2BA.Text;
		};
		controlCollection_0.Add(_Z0ib1EsNAOHar3w2AfvKgeb8s2BA);
		_YemBTJprwfbd3mpg5Gy9uyEJWwI(controlCollection_0, "Stock Templates", CustomizableSkin._A088aXIdbVflSYtbl7vA5RjQOjXA.Select((PlayerConfiguration configuration) => configuration.Name).ToArray(), _3yqpoxOljKnrj7mGlnrA0eOUMAk, delegate(int int_0)
		{
			_3yqpoxOljKnrj7mGlnrA0eOUMAk = int_0;
			CustomizableSkin._BwV21jdCpo4YpIp6x74bJ0H7hut(int_0);
			_TbkP67ntBpYJu1M27pBfsYAHmgJ.Content.Controls.Clear();
			_OBIbaNO8X49ahEZ5n3Ta8HUK7mO(controlCollection_0);
			if (base.Game.Sexscene != null)
			{
				base.Game.Sexscene._0cFb48aKbcbREkHm9Jwptl6r6Vi();
			}
		});
		_YemBTJprwfbd3mpg5Gy9uyEJWwI(controlCollection_0, "Your Templates", CustomizableSkin._I6gsCHlb2BKFCJSAk9Cn5fCMAPu.Select((PlayerConfiguration configuration) => configuration.Name).ToArray(), _QjFuG8JMGq8rGnavgUdgnBEKBfD, delegate(int int_0)
		{
			_QjFuG8JMGq8rGnavgUdgnBEKBfD = int_0;
			CustomizableSkin._BCRMBb9uhQZrQlfdXPidu27yb8C(int_0);
			Data.Name = CustomizableSkin._6qwooGF3jWmbG9887Y5IKZ8fJ0E(int_0);
			_TbkP67ntBpYJu1M27pBfsYAHmgJ.Content.Controls.Clear();
			_OBIbaNO8X49ahEZ5n3Ta8HUK7mO(controlCollection_0);
			if (base.Game.Sexscene != null)
			{
				base.Game.Sexscene._0cFb48aKbcbREkHm9Jwptl6r6Vi();
			}
		});
		Control control = _z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Phone", Data.PhoneColor, delegate(Color color_0)
		{
			Data.PhoneColor = color_0;
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
			if (string.IsNullOrWhiteSpace(_Z0ib1EsNAOHar3w2AfvKgeb8s2BA.Text))
			{
				base.Squid.ShowConfirm("You did not enter a name!", 500);
			}
			else
			{
				_yA2ISabBQiVKBxMt5AXSybmkG5o($"Are you sure you wish to create a new template with the name '{_Z0ib1EsNAOHar3w2AfvKgeb8s2BA.Text}', based on the current character?", delegate
				{
					CustomizableSkin._0S3oMrwxDtOTcbzkglSllPfRq53(_Z0ib1EsNAOHar3w2AfvKgeb8s2BA.Text, Data.GetPlayerData());
					_QjFuG8JMGq8rGnavgUdgnBEKBfD = CustomizableSkin._I6gsCHlb2BKFCJSAk9Cn5fCMAPu.Count() - 1;
					CustomizableSkin._BCRMBb9uhQZrQlfdXPidu27yb8C(_QjFuG8JMGq8rGnavgUdgnBEKBfD);
					Data.Name = CustomizableSkin._6qwooGF3jWmbG9887Y5IKZ8fJ0E(_QjFuG8JMGq8rGnavgUdgnBEKBfD);
					_TbkP67ntBpYJu1M27pBfsYAHmgJ.Content.Controls.Clear();
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
			if (string.IsNullOrWhiteSpace(_Z0ib1EsNAOHar3w2AfvKgeb8s2BA.Text))
			{
				base.Squid.ShowConfirm("You did not enter a name!", 500);
			}
			else if (_QjFuG8JMGq8rGnavgUdgnBEKBfD >= 0)
			{
				_yA2ISabBQiVKBxMt5AXSybmkG5o($"Are you sure you wish to save the currect character to the selected template '{CustomizableSkin._6qwooGF3jWmbG9887Y5IKZ8fJ0E(_QjFuG8JMGq8rGnavgUdgnBEKBfD)}'?", delegate
				{
					CustomizableSkin._WfRAwdaNcmrDEhMe1AHPq7egPcw(_Z0ib1EsNAOHar3w2AfvKgeb8s2BA.Text, _QjFuG8JMGq8rGnavgUdgnBEKBfD, Data.GetPlayerData());
					_TbkP67ntBpYJu1M27pBfsYAHmgJ.Content.Controls.Clear();
					_OBIbaNO8X49ahEZ5n3Ta8HUK7mO(controlCollection_0);
				});
			}
			else
			{
				_yA2ISabBQiVKBxMt5AXSybmkG5o($"No template has been selected yet, do you wish to create a new template with the name '{_Z0ib1EsNAOHar3w2AfvKgeb8s2BA.Text}', based on the current character?", delegate
				{
					CustomizableSkin._0S3oMrwxDtOTcbzkglSllPfRq53(_Z0ib1EsNAOHar3w2AfvKgeb8s2BA.Text, Data.GetPlayerData());
					_QjFuG8JMGq8rGnavgUdgnBEKBfD = CustomizableSkin._I6gsCHlb2BKFCJSAk9Cn5fCMAPu.Count() - 1;
					CustomizableSkin._BCRMBb9uhQZrQlfdXPidu27yb8C(_QjFuG8JMGq8rGnavgUdgnBEKBfD);
					Data.Name = CustomizableSkin._6qwooGF3jWmbG9887Y5IKZ8fJ0E(_QjFuG8JMGq8rGnavgUdgnBEKBfD);
					_TbkP67ntBpYJu1M27pBfsYAHmgJ.Content.Controls.Clear();
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
			if (_QjFuG8JMGq8rGnavgUdgnBEKBfD >= 0)
			{
				_yA2ISabBQiVKBxMt5AXSybmkG5o($"Are you sure you wish to reset the current character back to selected template '{CustomizableSkin._6qwooGF3jWmbG9887Y5IKZ8fJ0E(_QjFuG8JMGq8rGnavgUdgnBEKBfD)}'? All changes will be lost!", delegate
				{
					CustomizableSkin._JC60lfB4LT6VifObN1Ynm6iARlc(_QjFuG8JMGq8rGnavgUdgnBEKBfD);
					Data.Name = CustomizableSkin._6qwooGF3jWmbG9887Y5IKZ8fJ0E(_QjFuG8JMGq8rGnavgUdgnBEKBfD);
					_TbkP67ntBpYJu1M27pBfsYAHmgJ.Content.Controls.Clear();
					_OBIbaNO8X49ahEZ5n3Ta8HUK7mO(controlCollection_0);
				});
			}
			else
			{
				base.Squid.ShowConfirm("You did not select a template!", 500);
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
			if (_QjFuG8JMGq8rGnavgUdgnBEKBfD >= 0)
			{
				_yA2ISabBQiVKBxMt5AXSybmkG5o($"Are you sure you wish to delete the selected template '{CustomizableSkin._6qwooGF3jWmbG9887Y5IKZ8fJ0E(_QjFuG8JMGq8rGnavgUdgnBEKBfD)}'?", delegate
				{
					CustomizableSkin._FzyCgzYhOXEADaijk8VbcLulpcBA(_QjFuG8JMGq8rGnavgUdgnBEKBfD);
					_QjFuG8JMGq8rGnavgUdgnBEKBfD = -1;
					_TbkP67ntBpYJu1M27pBfsYAHmgJ.Content.Controls.Clear();
					_OBIbaNO8X49ahEZ5n3Ta8HUK7mO(controlCollection_0);
				});
			}
			else
			{
				base.Squid.ShowConfirm("You did not select a template!", 500);
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
			CustomizableSkin._BlScjiyHDsZk3jkAZbAbjUxn87sA();
		};
		controlCollection_0.Add(button5);
		if (!Censorship.Censored)
		{
			_YemBTJprwfbd3mpg5Gy9uyEJWwI(controlCollection_0, "Preview Sexscene", _LTwaEzSn23m9dquR3WwhTVRbJiG, _IyCJr9wgsrQgOUaXQco1I00YF7B, delegate(int int_0)
			{
				_IyCJr9wgsrQgOUaXQco1I00YF7B = int_0;
				if (int_0 == 0)
				{
					base.Game._Ec0fhBrUGmjaIKjUfJioigVc65x();
				}
				else
				{
					base.Game._gYGB98heFqsLp9tgJbdCP01IKV2(Sexscenes[int_0].Scene);
					base.Game.Sexscene._7BfTap1TnZXk1aaAXnFODowTQCp = true;
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
			if (_jIGpzoYLVPw8SPxmJcha832nCXR && string.IsNullOrWhiteSpace(_Z0ib1EsNAOHar3w2AfvKgeb8s2BA.Text))
			{
				base.Squid.ShowConfirm("You did not enter a name!", 500);
			}
			else
			{
				_n3b8BstkorCsu4TW0U2YVdFbdGp();
			}
		};
		controlCollection_0.Add(button6);
	}

	private void _yA2ISabBQiVKBxMt5AXSybmkG5o(string string_0, Action action_0)
	{
		base.Squid.ShowSelection(string_0, new string[2] { "No way!", "Yes please!" }, 500, delegate(int int_0)
		{
			if (int_0 == 1)
			{
				action_0();
			}
		});
	}

	protected virtual void _n3b8BstkorCsu4TW0U2YVdFbdGp()
	{
		base.Squid.ShowSelection("Are you sure you wish to exit? All unsaved changes will be lost!", new string[2] { "Oops, my bad!", "Yes please!" }, 500, delegate(int int_0)
		{
			if (int_0 == 1)
			{
				base.Game.StartScene<MainMenuScene>();
			}
		});
	}

	private void _jiNxMIzuA8Rrc2ULsrob5A7UNDe(ControlCollection controlCollection_0)
	{
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Body", Data.BodyType, delegate(PlayerData.EBodyType ebodyType_0)
		{
			Data.BodyType = ebodyType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Body Color", Data.BodyColor, delegate(Color color_0)
		{
			Data.BodyColor = color_0;
		});
		_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Underbelly Marking", PlayerData.EMarkingsType.Underbelly, Data.UnderbellyColor, delegate(Color color_0)
		{
			Data.UnderbellyColor = color_0;
		});
		_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Underthigh Marking", PlayerData.EMarkingsType.Underthigh, Data.UnderthighColor, delegate(Color color_0)
		{
			Data.UnderthighColor = color_0;
		});
		_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Stripes Marking", PlayerData.EMarkingsType.Stripes, Data.StripesColor, delegate(Color color_0)
		{
			Data.StripesColor = color_0;
		});
		_HdTJZZGoOMNi89T0yAdBraCZMjc(controlCollection_0, "Nails", Data.ShowNails, Data.NailColor, delegate(bool bool_0)
		{
			Data.ShowNails = bool_0;
		}, delegate(Color color_0)
		{
			Data.NailColor = color_0;
		});
	}

	private void _1qIQUjhrbk5WA7C7mYs93gXLOIe(ControlCollection controlCollection_0)
	{
		_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Long Forearm Marking", PlayerData.EMarkingsType.LongForearm, Data.LongForearmColor, delegate(Color color_0)
		{
			Data.LongForearmColor = color_0;
		});
		_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Short Forearm Marking", PlayerData.EMarkingsType.ShortForearm, Data.ShortForearmColor, delegate(Color color_0)
		{
			Data.ShortForearmColor = color_0;
		});
		_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Avian Forearm Marking", PlayerData.EMarkingsType.AvianForearm, Data.AvianForearmColor, delegate(Color color_0)
		{
			Data.AvianForearmColor = color_0;
		});
	}

	private void _VCrdQDifkN8NHlzPICTmtbgWFwp(ControlCollection controlCollection_0)
	{
		_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Long Shin Marking", PlayerData.EMarkingsType.LongShin, Data.LongShinColor, delegate(Color color_0)
		{
			Data.LongShinColor = color_0;
		});
		_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Short Shin Marking", PlayerData.EMarkingsType.ShortShin, Data.ShortShinColor, delegate(Color color_0)
		{
			Data.ShortShinColor = color_0;
		});
		_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Avian Shin Marking", PlayerData.EMarkingsType.AvianShin, Data.AvianShinColor, delegate(Color color_0)
		{
			Data.AvianShinColor = color_0;
		});
	}

	private void _vXrWU56trsuFNc9CNcHuctfkI2S(ControlCollection controlCollection_0)
	{
		Panel _5DnedRtrhRxc4WXg7XVOkddr43f = new Panel
		{
			Dock = DockStyle.Fill,
			Visible = (Data.HeadType == PlayerData.EHeadType.Default)
		};
		Panel _KH5vstJZR49J3eWlwNclJbU5SDe = new Panel
		{
			Dock = DockStyle.Fill,
			Visible = (Data.HeadType == PlayerData.EHeadType.PaperBag)
		};
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Head", Data.HeadType, delegate(PlayerData.EHeadType eheadType_0)
		{
			Data.HeadType = eheadType_0;
			switch (eheadType_0)
			{
			case PlayerData.EHeadType.Default:
				_5DnedRtrhRxc4WXg7XVOkddr43f.Visible = true;
				_KH5vstJZR49J3eWlwNclJbU5SDe.Visible = false;
				break;
			case PlayerData.EHeadType.Humanoid:
				_5DnedRtrhRxc4WXg7XVOkddr43f.Visible = false;
				_KH5vstJZR49J3eWlwNclJbU5SDe.Visible = false;
				break;
			case PlayerData.EHeadType.PaperBag:
				_5DnedRtrhRxc4WXg7XVOkddr43f.Visible = false;
				_KH5vstJZR49J3eWlwNclJbU5SDe.Visible = true;
				break;
			}
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Head Color", Data.HeadColor, delegate(Color color_0)
		{
			Data.HeadColor = color_0;
		});
		_h7MUbT306Ju5xwvamN8SatTR2Mo(_5DnedRtrhRxc4WXg7XVOkddr43f.Content.Controls, "Gaunt Marking", PlayerData.EHeadMarkingsType.Gaunt, Data.HeadGauntColor, delegate(Color color_0)
		{
			Data.HeadGauntColor = color_0;
		});
		_h7MUbT306Ju5xwvamN8SatTR2Mo(_5DnedRtrhRxc4WXg7XVOkddr43f.Content.Controls, "Scruffy Marking", PlayerData.EHeadMarkingsType.Scruffy, Data.HeadScruffyColor, delegate(Color color_0)
		{
			Data.HeadScruffyColor = color_0;
		});
		_h7MUbT306Ju5xwvamN8SatTR2Mo(_5DnedRtrhRxc4WXg7XVOkddr43f.Content.Controls, "Snout Marking", PlayerData.EHeadMarkingsType.Snout, Data.HeadSnoutColor, delegate(Color color_0)
		{
			Data.HeadSnoutColor = color_0;
		});
		_h7MUbT306Ju5xwvamN8SatTR2Mo(_5DnedRtrhRxc4WXg7XVOkddr43f.Content.Controls, "Stripes Marking", PlayerData.EHeadMarkingsType.Stripes, Data.HeadStripesColor, delegate(Color color_0)
		{
			Data.HeadStripesColor = color_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(_KH5vstJZR49J3eWlwNclJbU5SDe.Content.Controls, "Paper Bag Color", Data.PaperBagColor, delegate(Color color_0)
		{
			Data.PaperBagColor = color_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(_KH5vstJZR49J3eWlwNclJbU5SDe.Content.Controls, "Eyesholes Color", Data.PaperBagEyesColor, delegate(Color color_0)
		{
			Data.PaperBagEyesColor = color_0;
		});
		controlCollection_0.Add(_5DnedRtrhRxc4WXg7XVOkddr43f);
		controlCollection_0.Add(_KH5vstJZR49J3eWlwNclJbU5SDe);
	}

	private void _vg6ASaP7xNqc0jerF3mcrXv4dn7(ControlCollection controlCollection_0)
	{
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Muzzle", Data.MuzzleType, delegate(PlayerData.EMuzzleType emuzzleType_0)
		{
			Data.MuzzleType = emuzzleType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Muzzle Color", Data.MuzzleColor, delegate(Color color_0)
		{
			Data.MuzzleColor = color_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Nose Color", Data.NoseColor, delegate(Color color_0)
		{
			Data.NoseColor = color_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Teeth Color", Data.TeethColor, delegate(Color color_0)
		{
			Data.TeethColor = color_0;
		});
		_HdTJZZGoOMNi89T0yAdBraCZMjc(controlCollection_0, "Muzzle Horn", Data.ShowMuzzleHorn, Data.MuzzleHornColor, delegate(bool bool_0)
		{
			Data.ShowMuzzleHorn = bool_0;
		}, delegate(Color color_0)
		{
			Data.MuzzleHornColor = color_0;
		});
		_HdTJZZGoOMNi89T0yAdBraCZMjc(controlCollection_0, "Muzzle Mask", Data.ShowMuzzleMask, Data.MuzzleMaskColor, delegate(bool bool_0)
		{
			Data.ShowMuzzleMask = bool_0;
		}, delegate(Color color_0)
		{
			Data.MuzzleMaskColor = color_0;
		});
	}

	private void _Xhurp3mVVoR5kNlnxgLoDDkeQxM(ControlCollection controlCollection_0)
	{
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Ears and Horns", Data.HeadAccessoriesType, delegate(PlayerData.EHeadAccessoriesType eheadAccessoriesType_0)
		{
			Data.HeadAccessoriesType = eheadAccessoriesType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Horns Color", Data.HeadHornsColor, delegate(Color color_0)
		{
			Data.HeadHornsColor = color_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Ear Color", Data.EarColor, delegate(Color color_0)
		{
			Data.EarColor = color_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Ear Inner Color", Data.EarInnerColor, delegate(Color color_0)
		{
			Data.EarInnerColor = color_0;
		});
	}

	private void _gHA9C0CRN2NaRMtfTrvlotJOd0T(ControlCollection controlCollection_0)
	{
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Hair", Data.HairstyleType, delegate(PlayerData.EHairstyleType ehairstyleType_0)
		{
			Data.HairstyleType = ehairstyleType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Hair Color", Data.HairColor, delegate(Color color_0)
		{
			Data.HairColor = color_0;
		});
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Fringe", Data.FringeType, delegate(PlayerData.EFringeType efringeType_0)
		{
			Data.FringeType = efringeType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Fringe Color", Data.FringeColor, delegate(Color color_0)
		{
			Data.FringeColor = color_0;
		});
	}

	private void _hNo7o9fG9jvwcKyMq1nYl4q7cXc(ControlCollection controlCollection_0)
	{
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Eyes", Data.EyesType, delegate(PlayerData.EEyesType eeyesType_0)
		{
			Data.EyesType = eeyesType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Eyes Back Color", Data.EyesBackColor, delegate(Color color_0)
		{
			Data.EyesBackColor = color_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Eyes Front Color", Data.EyesFrontColor, delegate(Color color_0)
		{
			Data.EyesFrontColor = color_0;
		});
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Brows", Data.BrowType, delegate(PlayerData.EBrowType ebrowType_0)
		{
			Data.BrowType = ebrowType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Brows Color", Data.BrowColor, delegate(Color color_0)
		{
			Data.BrowColor = color_0;
		});
	}

	private void _mWS8UuA4xcT1bSdjDObiubOE0wH(ControlCollection controlCollection_0)
	{
		Panel _63PX0QXRoq6jeUvG5xheRABNwsg = new Panel
		{
			Dock = DockStyle.Top,
			Visible = (Data.BreastsType != PlayerData.EBreastsType.None)
		};
		Panel _TLsIePSD9UbEwlT0HwKiF2xZX87 = new Panel
		{
			Dock = DockStyle.Top,
			Visible = (Data.CockType != PlayerData.ECockType.None)
		};
		Panel _s9TeQxnG80yYnmcOHHr4bw9fWCh = new Panel
		{
			Dock = DockStyle.Top,
			Visible = (Data.BallsType != PlayerData.EBallsType.None)
		};
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Breasts", Data.BreastsType, delegate(PlayerData.EBreastsType ebreastsType_0)
		{
			Data.BreastsType = ebreastsType_0;
			_63PX0QXRoq6jeUvG5xheRABNwsg.Visible = Data.BreastsType != PlayerData.EBreastsType.None;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(_63PX0QXRoq6jeUvG5xheRABNwsg.Content.Controls, "Breasts Color", Data.BreastsColor, delegate(Color color_0)
		{
			Data.BreastsColor = color_0;
		});
		_HdTJZZGoOMNi89T0yAdBraCZMjc(_63PX0QXRoq6jeUvG5xheRABNwsg.Content.Controls, "Nipples", Data.ShowNipples, Data.NipplesColor, delegate(bool bool_0)
		{
			Data.ShowNipples = bool_0;
		}, delegate(Color color_0)
		{
			Data.NipplesColor = color_0;
		});
		controlCollection_0.Add(_63PX0QXRoq6jeUvG5xheRABNwsg);
		Control _Jhlc8lMI1rq07omae9xc6uig5tv = null;
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Cock", Data.CockType, delegate(PlayerData.ECockType ecockType_0)
		{
			Data.CockType = ecockType_0;
			_TLsIePSD9UbEwlT0HwKiF2xZX87.Visible = Data.CockType != PlayerData.ECockType.None;
			_Jhlc8lMI1rq07omae9xc6uig5tv.Visible = Data.CockType == PlayerData.ECockType.Cut || Data.CockType == PlayerData.ECockType.Uncut;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(_TLsIePSD9UbEwlT0HwKiF2xZX87.Content.Controls, "Cock Color", Data.GenitaliaColor, delegate(Color color_0)
		{
			Data.GenitaliaColor = color_0;
		});
		_Jhlc8lMI1rq07omae9xc6uig5tv = _z5npzs7mj5H3zJ1PF64BFNsXBmm(_TLsIePSD9UbEwlT0HwKiF2xZX87.Content.Controls, "Cock Tip Color", Data.GenitaliaFleshColor, delegate(Color color_0)
		{
			Data.GenitaliaFleshColor = color_0;
		});
		_Jhlc8lMI1rq07omae9xc6uig5tv.Visible = Data.CockType == PlayerData.ECockType.Cut || Data.CockType == PlayerData.ECockType.Uncut;
		controlCollection_0.Add(_TLsIePSD9UbEwlT0HwKiF2xZX87);
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Balls", Data.BallsType, delegate(PlayerData.EBallsType eballsType_0)
		{
			Data.BallsType = eballsType_0;
			_s9TeQxnG80yYnmcOHHr4bw9fWCh.Visible = Data.BallsType != PlayerData.EBallsType.None;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(_s9TeQxnG80yYnmcOHHr4bw9fWCh.Content.Controls, "Balls Color", Data.BallsColor, delegate(Color color_0)
		{
			Data.BallsColor = color_0;
		});
		controlCollection_0.Add(_s9TeQxnG80yYnmcOHHr4bw9fWCh);
	}

	private void _7JR6eL4D0qdIJNOwfInnlg2HEgZ(ControlCollection controlCollection_0)
	{
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Tail", Data.TailType, delegate(PlayerData.ETailType etailType_0)
		{
			Data.TailType = etailType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Tail Color", Data.TailColor, delegate(Color color_0)
		{
			Data.TailColor = color_0;
		});
		_HdTJZZGoOMNi89T0yAdBraCZMjc(controlCollection_0, "Tail Part A", Data.ShowTailPartOne, Data.TailPartOneColor, delegate(bool bool_0)
		{
			Data.ShowTailPartOne = bool_0;
		}, delegate(Color color_0)
		{
			Data.TailPartOneColor = color_0;
		});
		_HdTJZZGoOMNi89T0yAdBraCZMjc(controlCollection_0, "Tail Part B", Data.ShowTailPartTwo, Data.TailPartTwoColor, delegate(bool bool_0)
		{
			Data.ShowTailPartTwo = bool_0;
		}, delegate(Color color_0)
		{
			Data.TailPartTwoColor = color_0;
		});
	}

	private void _PBEdYyzYEWcXAodjVf58ocOQ3Jf(ControlCollection controlCollection_0)
	{
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Feet", Data.FeetType, delegate(PlayerData.EFeetType efeetType_0)
		{
			Data.FeetType = efeetType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Feet Color", Data.FeetColor, delegate(Color color_0)
		{
			Data.FeetColor = color_0;
		});
	}

	public void _KkwafXXLVg1QfQgqqCAojg2ySyZ(SpriteBatch spriteBatch)
	{
		_9jklVVcQQYcyqOYrkPiht2VP0IG.Parameters["Time"].SetValue(_boyt8NIMtKsAGSTcjHeL0WMbFxs._AmIUCcrmrrQiiirja7DoiZSjXuv);
		PlayerPreferences.Self.Draw(spriteBatch, _9jklVVcQQYcyqOYrkPiht2VP0IG);
	}

	private void _9x3XvoSKr9dMOykq9pl8AKFzwJ(ControlCollection controlCollection_0, string string_0, PlayerData.EMarkingsType EMarkingsType_0, Color color_0, Action<Color> action_0)
	{
		_HdTJZZGoOMNi89T0yAdBraCZMjc(controlCollection_0, string_0, Data.MarkingsType.HasFlag(EMarkingsType_0), color_0, delegate(bool bool_0)
		{
			if (bool_0)
			{
				Data.MarkingsType |= EMarkingsType_0;
			}
			else
			{
				Data.MarkingsType &= ~EMarkingsType_0;
			}
		}, delegate(Color color_0)
		{
			action_0(color_0);
			CustomizableSkin._0cFb48aKbcbREkHm9Jwptl6r6Vi();
		});
	}

	private void _h7MUbT306Ju5xwvamN8SatTR2Mo(ControlCollection controlCollection_0, string string_0, PlayerData.EHeadMarkingsType _iDe3W6qb7jKTPuJV79yf2i7UoIq_0, Color color_0, Action<Color> action_0)
	{
		_HdTJZZGoOMNi89T0yAdBraCZMjc(controlCollection_0, string_0, Data.HeadMarkingsType.HasFlag(_iDe3W6qb7jKTPuJV79yf2i7UoIq_0), color_0, delegate(bool bool_0)
		{
			if (bool_0)
			{
				Data.HeadMarkingsType |= _iDe3W6qb7jKTPuJV79yf2i7UoIq_0;
			}
			else
			{
				Data.HeadMarkingsType &= ~_iDe3W6qb7jKTPuJV79yf2i7UoIq_0;
			}
		}, delegate(Color color_0)
		{
			action_0(color_0);
			CustomizableSkin._0cFb48aKbcbREkHm9Jwptl6r6Vi();
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
			CustomizableSkin._0cFb48aKbcbREkHm9Jwptl6r6Vi();
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
		ImageControl _UI1mLnvMX5jk5cl6WgxFoVZi1ne = new ImageControl
		{
			Dock = DockStyle.Left,
			Size = new Squid.Point(29, 30),
			Color = ColorInt.ARGB(color_0.A, color_0.R, color_0.G, color_0.B)
		};
		Label item = new Label
		{
			Dock = DockStyle.Fill,
			Text = string_0,
			Margin = new Margin(5, 0, 0, 0)
		};
		_UI1mLnvMX5jk5cl6WgxFoVZi1ne.MouseClick += delegate
		{
			_gaKeabKyjzz2jeJCEYxHW9Gc8CGA(string_0, color_0, delegate(Color color_0)
			{
				_UI1mLnvMX5jk5cl6WgxFoVZi1ne.Color = ColorInt.ARGB(color_0.A, color_0.R, color_0.G, color_0.B);
				action_0(color_0);
				CustomizableSkin._0cFb48aKbcbREkHm9Jwptl6r6Vi();
			});
		};
		control.GetElements().Add(_UI1mLnvMX5jk5cl6WgxFoVZi1ne);
		control.GetElements().Add(item);
		return control;
	}

	private void _WPOv8yATDl2g7nDSf8itt8V399K(Button button_0)
	{
		_0jH3FoV36utxuSLivmD6IZNwppA.Content.Controls.Clear();
		int num = _kG9DrP49ggNdZOvVMMUPjfqdzZ4.FindIndex((Button button_0) => object.Equals(button_0, button_0));
		for (int i = 0; i <= num; i++)
		{
			_kG9DrP49ggNdZOvVMMUPjfqdzZ4[i].Dock = DockStyle.Top;
			_0jH3FoV36utxuSLivmD6IZNwppA.Content.Controls.Add(_kG9DrP49ggNdZOvVMMUPjfqdzZ4[i]);
		}
		for (int num2 = _kG9DrP49ggNdZOvVMMUPjfqdzZ4.Count - 1; num2 > num; num2--)
		{
			_kG9DrP49ggNdZOvVMMUPjfqdzZ4[num2].Dock = DockStyle.Bottom;
			_0jH3FoV36utxuSLivmD6IZNwppA.Content.Controls.Add(_kG9DrP49ggNdZOvVMMUPjfqdzZ4[num2]);
		}
		_0jH3FoV36utxuSLivmD6IZNwppA.Content.Controls.Add(_TbkP67ntBpYJu1M27pBfsYAHmgJ);
	}

	private Button _cvldkRXLM8Toadgv6nPx5QH1EES(string string_0, Action action_0)
	{
		Button _u0Xt0uZRA6nEpUColLBccMdwezW = new Button
		{
			Dock = DockStyle.Top,
			TextAlign = Alignment.MiddleCenter,
			Text = string_0,
			Style = "buttonOpaque"
		};
		if (action_0 != null)
		{
			_u0Xt0uZRA6nEpUColLBccMdwezW.MouseClick += delegate
			{
				_TbkP67ntBpYJu1M27pBfsYAHmgJ.Content.Controls.Clear();
				_TbkP67ntBpYJu1M27pBfsYAHmgJ.VScroll.Value = 0f;
				_WPOv8yATDl2g7nDSf8itt8V399K(_u0Xt0uZRA6nEpUColLBccMdwezW);
				action_0();
			};
		}
		_0jH3FoV36utxuSLivmD6IZNwppA.Content.Controls.Add(_u0Xt0uZRA6nEpUColLBccMdwezW);
		return _u0Xt0uZRA6nEpUColLBccMdwezW;
	}

	private void _YemBTJprwfbd3mpg5Gy9uyEJWwI(ControlCollection controlCollection_0, string string_0, string[] string_1, int int_0, Action<int> action_0)
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
				Size = new Squid.Point(0, 30)
			});
		}
		dropDownList2.SelectedItemChanged += delegate(Control control_0, ListBoxItem listBoxItem_0)
		{
			action_0((int)listBoxItem_0.Value);
			CustomizableSkin._0cFb48aKbcbREkHm9Jwptl6r6Vi();
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
				Size = new Squid.Point(0, 30)
			});
		}
		dropDownList2.SelectedItemChanged += delegate(Control control_0, ListBoxItem listBoxItem_0)
		{
			action_0((T)listBoxItem_0.Value);
			CustomizableSkin._0cFb48aKbcbREkHm9Jwptl6r6Vi();
		};
		controlCollection_0.Add(item);
		controlCollection_0.Add(dropDownList2);
	}

	private void _gaKeabKyjzz2jeJCEYxHW9Gc8CGA(string string_0, Color color_0, Action<Color> action_0)
	{
		if (_hSPLyBveOIKpCKgimgpgcMUDdRz != null)
		{
			_hSPLyBveOIKpCKgimgpgcMUDdRz.Close();
		}
		Window _L7VColD35B3sDgJdUnjTeXGa7pv = new Window
		{
			Dock = DockStyle.Right,
			AutoSize = AutoSize.HorizontalVertical,
			Margin = new Margin(8, 8, 0, 8)
		};
		_hSPLyBveOIKpCKgimgpgcMUDdRz = _L7VColD35B3sDgJdUnjTeXGa7pv;
		Panel panel = new Panel();
		panel.Size = new Squid.Point(307, 519);
		panel.ClipFrame.Margin = new Margin(16, 8, 16, 16);
		Panel panel2 = panel;
		_L7VColD35B3sDgJdUnjTeXGa7pv.Controls.Add(panel2);
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
		ImageControl _UI1mLnvMX5jk5cl6WgxFoVZi1ne = new ImageControl
		{
			Dock = DockStyle.Left,
			Texture = "ColorPickerBox",
			Size = new Squid.Point(250, 250)
		};
		ImageControl _nTvWggfVqVEF25GV4NOsfpNhR4C = new ImageControl
		{
			Dock = DockStyle.Fill,
			Texture = "ColorPickerSlider",
			Size = new Squid.Point(25, 250)
		};
		panel3.Content.Controls.Add(_UI1mLnvMX5jk5cl6WgxFoVZi1ne);
		panel3.Content.Controls.Add(_nTvWggfVqVEF25GV4NOsfpNhR4C);
		ImageControl _G6zJYvyBSALAHUJm6qCEvtL6WRp = new ImageControl
		{
			Dock = DockStyle.Top,
			Size = new Squid.Point(275, 25),
			Color = ColorInt.ARGB(color_0.A, color_0.R, color_0.G, color_0.B),
			Margin = new Margin(0, 0, 0, 8)
		};
		Panel panel4 = new Panel
		{
			Dock = DockStyle.Top,
			Size = new Squid.Point(275, 30),
			Margin = new Margin(0, 0, 0, 8)
		};
		Label item2 = new Label
		{
			Dock = DockStyle.Left,
			Text = "H:",
			TextAlign = Alignment.MiddleCenter,
			Size = new Squid.Point(30, 30)
		};
		TextBox _8vFoRw3vIHPno8g3WIeCBRRueVP = new TextBox
		{
			Dock = DockStyle.Left,
			Size = new Squid.Point(107, 30),
			TabIndex = 1
		};
		Label item3 = new Label
		{
			Dock = DockStyle.Left,
			Text = "R:",
			TextAlign = Alignment.MiddleCenter,
			Size = new Squid.Point(30, 30)
		};
		TextBox _qCKGqUjXlMolAESPmB7a59OrelQ = new TextBox
		{
			Dock = DockStyle.Fill,
			TabIndex = 4
		};
		panel4.Content.Controls.Add(item2);
		panel4.Content.Controls.Add(_8vFoRw3vIHPno8g3WIeCBRRueVP);
		panel4.Content.Controls.Add(item3);
		panel4.Content.Controls.Add(_qCKGqUjXlMolAESPmB7a59OrelQ);
		Panel panel5 = new Panel
		{
			Dock = DockStyle.Top,
			Size = new Squid.Point(275, 30),
			Margin = new Margin(0, 0, 0, 8)
		};
		Label item4 = new Label
		{
			Dock = DockStyle.Left,
			Text = "S:",
			TextAlign = Alignment.MiddleCenter,
			Size = new Squid.Point(30, 30)
		};
		TextBox _hOIb3XNfIEDsngLrYzmNfLTPVAS = new TextBox
		{
			Dock = DockStyle.Left,
			Size = new Squid.Point(107, 30),
			TabIndex = 2
		};
		Label item5 = new Label
		{
			Dock = DockStyle.Left,
			Text = "G:",
			TextAlign = Alignment.MiddleCenter,
			Size = new Squid.Point(30, 30)
		};
		TextBox _ZP3psbb9CVMMjGn5SgszZo0zGpF = new TextBox
		{
			Dock = DockStyle.Fill,
			TabIndex = 5
		};
		panel5.Content.Controls.Add(item4);
		panel5.Content.Controls.Add(_hOIb3XNfIEDsngLrYzmNfLTPVAS);
		panel5.Content.Controls.Add(item5);
		panel5.Content.Controls.Add(_ZP3psbb9CVMMjGn5SgszZo0zGpF);
		Panel panel6 = new Panel
		{
			Dock = DockStyle.Top,
			Size = new Squid.Point(275, 30),
			Margin = new Margin(0, 0, 0, 8)
		};
		Label item6 = new Label
		{
			Dock = DockStyle.Left,
			Text = "V:",
			TextAlign = Alignment.MiddleCenter,
			Size = new Squid.Point(30, 30)
		};
		TextBox _gY2uTDE0FADy52ltQdJ1AO9nRcf = new TextBox
		{
			Dock = DockStyle.Left,
			Size = new Squid.Point(107, 30),
			TabIndex = 3
		};
		Label item7 = new Label
		{
			Dock = DockStyle.Left,
			Text = "B:",
			TextAlign = Alignment.MiddleCenter,
			Size = new Squid.Point(30, 30)
		};
		TextBox _E3KHmDW9haZynE9ZamZBVdveWgk = new TextBox
		{
			Dock = DockStyle.Fill,
			TabIndex = 6
		};
		panel6.Content.Controls.Add(item6);
		panel6.Content.Controls.Add(_gY2uTDE0FADy52ltQdJ1AO9nRcf);
		panel6.Content.Controls.Add(item7);
		panel6.Content.Controls.Add(_E3KHmDW9haZynE9ZamZBVdveWgk);
		Panel panel7 = new Panel
		{
			Dock = DockStyle.Top,
			Size = new Squid.Point(275, 30),
			Margin = new Margin(0, 0, 0, 8)
		};
		Label item8 = new Label
		{
			Dock = DockStyle.Left,
			Text = "Hex:",
			TextAlign = Alignment.MiddleCenter,
			Size = new Squid.Point(45, 30)
		};
		TextBox _8lboaaRLcpJoVxfwF1kBCisgrjL = new TextBox
		{
			Dock = DockStyle.Fill,
			TabIndex = 7
		};
		panel7.Content.Controls.Add(item8);
		panel7.Content.Controls.Add(_8lboaaRLcpJoVxfwF1kBCisgrjL);
		ImageControl _OWUGVcx9djtc19hjFfxkac019iL = new ImageControl
		{
			Size = new Squid.Point(6, 6),
			Color = ColorInt.ARGB(0.9f, 1f, 1f, 1f)
		};
		ImageControl _wbSWz1LplcReMBnbKlnmd0UzxRP = new ImageControl
		{
			Size = new Squid.Point(25, 6),
			Color = ColorInt.ARGB(0.9f, 1f, 1f, 1f)
		};
		_L7VColD35B3sDgJdUnjTeXGa7pv.Controls.Add(_OWUGVcx9djtc19hjFfxkac019iL);
		_L7VColD35B3sDgJdUnjTeXGa7pv.Controls.Add(_wbSWz1LplcReMBnbKlnmd0UzxRP);
		Button button = new Button
		{
			Dock = DockStyle.Fill,
			Text = "Close",
			TextAlign = Alignment.MiddleCenter
		};
		button.MouseClick += delegate
		{
			_hSPLyBveOIKpCKgimgpgcMUDdRz.Close();
		};
		panel2.Content.Controls.Add(item);
		panel2.Content.Controls.Add(panel3);
		panel2.Content.Controls.Add(_G6zJYvyBSALAHUJm6qCEvtL6WRp);
		panel2.Content.Controls.Add(panel4);
		panel2.Content.Controls.Add(panel5);
		panel2.Content.Controls.Add(panel6);
		panel2.Content.Controls.Add(panel7);
		panel2.Content.Controls.Add(panel7);
		panel2.Content.Controls.Add(button);
		_L7VColD35B3sDgJdUnjTeXGa7pv.Show(base.Squid);
		Color _9ycmcfwZ9EbmXanrFe7pEfGAAUi = color_0;
		_fA3AcauqZZ0ncWKv9QA3iklruOI(color_0, out var _kyexzK2VL0y9etRuX79HInHIsIb, out var _46o2iZ9juR1nNURyrP41h9vxpGA, out var _xX4CfdHl6arem4v3fUgbDUIK2gM);
		Texture2D _3PAjrCP0TE07YQ22X6EIpPwOlib = new Texture2D(base.Game._2yepMkVENnecIsduggABaU2qhXW, 250, 250, mipMap: false, SurfaceFormat.Color);
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
		Texture2D texture2D = new Texture2D(base.Game._2yepMkVENnecIsduggABaU2qhXW, 25, 250, mipMap: false, SurfaceFormat.Color);
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
			_OWUGVcx9djtc19hjFfxkac019iL.Position = new Squid.Point(13 + (int)(_46o2iZ9juR1nNURyrP41h9vxpGA * 250f), 35 + (int)(250f - _xX4CfdHl6arem4v3fUgbDUIK2gM * 250f));
			_wbSWz1LplcReMBnbKlnmd0UzxRP.Position = new Squid.Point(266, 35 + (int)(250f - 250f * (_kyexzK2VL0y9etRuX79HInHIsIb / 360f)));
			_G6zJYvyBSALAHUJm6qCEvtL6WRp.Color = ColorInt.ARGB(_9ycmcfwZ9EbmXanrFe7pEfGAAUi.A, _9ycmcfwZ9EbmXanrFe7pEfGAAUi.R, _9ycmcfwZ9EbmXanrFe7pEfGAAUi.G, _9ycmcfwZ9EbmXanrFe7pEfGAAUi.B);
			_8vFoRw3vIHPno8g3WIeCBRRueVP.Text = ((int)_kyexzK2VL0y9etRuX79HInHIsIb).ToString();
			_hOIb3XNfIEDsngLrYzmNfLTPVAS.Text = ((int)(_46o2iZ9juR1nNURyrP41h9vxpGA * 100f)).ToString();
			_gY2uTDE0FADy52ltQdJ1AO9nRcf.Text = ((int)(_xX4CfdHl6arem4v3fUgbDUIK2gM * 100f)).ToString();
			_qCKGqUjXlMolAESPmB7a59OrelQ.Text = _9ycmcfwZ9EbmXanrFe7pEfGAAUi.R.ToString();
			_ZP3psbb9CVMMjGn5SgszZo0zGpF.Text = _9ycmcfwZ9EbmXanrFe7pEfGAAUi.G.ToString();
			_E3KHmDW9haZynE9ZamZBVdveWgk.Text = _9ycmcfwZ9EbmXanrFe7pEfGAAUi.B.ToString();
			_8lboaaRLcpJoVxfwF1kBCisgrjL.Text = $"#{_9ycmcfwZ9EbmXanrFe7pEfGAAUi.R:X2}{_9ycmcfwZ9EbmXanrFe7pEfGAAUi.G:X2}{_9ycmcfwZ9EbmXanrFe7pEfGAAUi.B:X2}";
		};
		_XDKgJpkUD4lIN2K7ysMOtqO5gMA();
		bool _a7vdsaGCzLloXi7sntZm1rCdbZK = false;
		bool _FxCuMzbCIAsYKlL8DmmchjsMpir = false;
		_UI1mLnvMX5jk5cl6WgxFoVZi1ne.Update += delegate
		{
			if (!_FxCuMzbCIAsYKlL8DmmchjsMpir)
			{
				if (base.Game._RbWJ7YGnYHCSoD44MRW1h5X6E7E._WZ4xYI5Q3hoCNX9QFzE3jfDwZBJ(_PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton))
				{
					if (!_a7vdsaGCzLloXi7sntZm1rCdbZK && Gui.MousePosition.x >= _UI1mLnvMX5jk5cl6WgxFoVZi1ne.Location.x && Gui.MousePosition.x <= _UI1mLnvMX5jk5cl6WgxFoVZi1ne.Location.x + _UI1mLnvMX5jk5cl6WgxFoVZi1ne.Size.x && Gui.MousePosition.y >= _UI1mLnvMX5jk5cl6WgxFoVZi1ne.Location.y && Gui.MousePosition.y <= _UI1mLnvMX5jk5cl6WgxFoVZi1ne.Location.y + _UI1mLnvMX5jk5cl6WgxFoVZi1ne.Size.y)
					{
						_a7vdsaGCzLloXi7sntZm1rCdbZK = true;
					}
					if (_a7vdsaGCzLloXi7sntZm1rCdbZK)
					{
						Squid.Point point2 = Gui.MousePosition - _UI1mLnvMX5jk5cl6WgxFoVZi1ne.Location;
						point2.x = (int)MathHelper.Clamp(point2.x, 0f, 250f);
						point2.y = (int)MathHelper.Clamp(point2.y, 0f, 250f);
						_46o2iZ9juR1nNURyrP41h9vxpGA = (float)point2.x / 250f;
						_xX4CfdHl6arem4v3fUgbDUIK2gM = (250f - (float)point2.y) / 250f;
						_9ycmcfwZ9EbmXanrFe7pEfGAAUi = _lAdyiyyWQrRKWYduTPacHqdzOmj(_kyexzK2VL0y9etRuX79HInHIsIb, _46o2iZ9juR1nNURyrP41h9vxpGA, _xX4CfdHl6arem4v3fUgbDUIK2gM, 1f);
						_XDKgJpkUD4lIN2K7ysMOtqO5gMA();
						action_0(_9ycmcfwZ9EbmXanrFe7pEfGAAUi);
					}
				}
				else
				{
					_a7vdsaGCzLloXi7sntZm1rCdbZK = false;
				}
			}
		};
		_nTvWggfVqVEF25GV4NOsfpNhR4C.Update += delegate
		{
			if (!_a7vdsaGCzLloXi7sntZm1rCdbZK)
			{
				if (base.Game._RbWJ7YGnYHCSoD44MRW1h5X6E7E._WZ4xYI5Q3hoCNX9QFzE3jfDwZBJ(_PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton))
				{
					if (!_FxCuMzbCIAsYKlL8DmmchjsMpir && Gui.MousePosition.x >= _nTvWggfVqVEF25GV4NOsfpNhR4C.Location.x && Gui.MousePosition.x <= _nTvWggfVqVEF25GV4NOsfpNhR4C.Location.x + _nTvWggfVqVEF25GV4NOsfpNhR4C.Size.x && Gui.MousePosition.y >= _nTvWggfVqVEF25GV4NOsfpNhR4C.Location.y && Gui.MousePosition.y <= _nTvWggfVqVEF25GV4NOsfpNhR4C.Location.y + _nTvWggfVqVEF25GV4NOsfpNhR4C.Size.y)
					{
						_FxCuMzbCIAsYKlL8DmmchjsMpir = true;
					}
					if (_FxCuMzbCIAsYKlL8DmmchjsMpir)
					{
						Squid.Point point = Gui.MousePosition - _nTvWggfVqVEF25GV4NOsfpNhR4C.Location;
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
						_9ycmcfwZ9EbmXanrFe7pEfGAAUi = _lAdyiyyWQrRKWYduTPacHqdzOmj(_kyexzK2VL0y9etRuX79HInHIsIb, _46o2iZ9juR1nNURyrP41h9vxpGA, _xX4CfdHl6arem4v3fUgbDUIK2gM, 1f);
						_XDKgJpkUD4lIN2K7ysMOtqO5gMA();
						action_0(_9ycmcfwZ9EbmXanrFe7pEfGAAUi);
					}
				}
				else
				{
					_FxCuMzbCIAsYKlL8DmmchjsMpir = false;
				}
			}
		};
		_8vFoRw3vIHPno8g3WIeCBRRueVP.TextCommit += delegate
		{
			if (int.TryParse(_8vFoRw3vIHPno8g3WIeCBRRueVP.Text, out var result6))
			{
				_kyexzK2VL0y9etRuX79HInHIsIb = Math.Max(0, Math.Min(result6, 360));
				_9ycmcfwZ9EbmXanrFe7pEfGAAUi = _lAdyiyyWQrRKWYduTPacHqdzOmj(_kyexzK2VL0y9etRuX79HInHIsIb, _46o2iZ9juR1nNURyrP41h9vxpGA, _xX4CfdHl6arem4v3fUgbDUIK2gM, 1f);
				action_0(_9ycmcfwZ9EbmXanrFe7pEfGAAUi);
			}
			_XDKgJpkUD4lIN2K7ysMOtqO5gMA();
		};
		_hOIb3XNfIEDsngLrYzmNfLTPVAS.TextCommit += delegate
		{
			if (int.TryParse(_hOIb3XNfIEDsngLrYzmNfLTPVAS.Text, out var result5))
			{
				_46o2iZ9juR1nNURyrP41h9vxpGA = (float)Math.Max(0, Math.Min(result5, 100)) / 100f;
				_9ycmcfwZ9EbmXanrFe7pEfGAAUi = _lAdyiyyWQrRKWYduTPacHqdzOmj(_kyexzK2VL0y9etRuX79HInHIsIb, _46o2iZ9juR1nNURyrP41h9vxpGA, _xX4CfdHl6arem4v3fUgbDUIK2gM, 1f);
				action_0(_9ycmcfwZ9EbmXanrFe7pEfGAAUi);
			}
			_XDKgJpkUD4lIN2K7ysMOtqO5gMA();
		};
		_gY2uTDE0FADy52ltQdJ1AO9nRcf.TextCommit += delegate
		{
			if (int.TryParse(_gY2uTDE0FADy52ltQdJ1AO9nRcf.Text, out var result4))
			{
				_xX4CfdHl6arem4v3fUgbDUIK2gM = (float)Math.Max(0, Math.Min(result4, 100)) / 100f;
				_9ycmcfwZ9EbmXanrFe7pEfGAAUi = _lAdyiyyWQrRKWYduTPacHqdzOmj(_kyexzK2VL0y9etRuX79HInHIsIb, _46o2iZ9juR1nNURyrP41h9vxpGA, _xX4CfdHl6arem4v3fUgbDUIK2gM, 1f);
				action_0(_9ycmcfwZ9EbmXanrFe7pEfGAAUi);
			}
			_XDKgJpkUD4lIN2K7ysMOtqO5gMA();
		};
		_qCKGqUjXlMolAESPmB7a59OrelQ.TextCommit += delegate
		{
			if (int.TryParse(_qCKGqUjXlMolAESPmB7a59OrelQ.Text, out var result3))
			{
				_9ycmcfwZ9EbmXanrFe7pEfGAAUi.R = (byte)Math.Max(0, Math.Min(result3, 255));
				_fA3AcauqZZ0ncWKv9QA3iklruOI(_9ycmcfwZ9EbmXanrFe7pEfGAAUi, out _kyexzK2VL0y9etRuX79HInHIsIb, out _46o2iZ9juR1nNURyrP41h9vxpGA, out _xX4CfdHl6arem4v3fUgbDUIK2gM);
				action_0(_9ycmcfwZ9EbmXanrFe7pEfGAAUi);
			}
			_XDKgJpkUD4lIN2K7ysMOtqO5gMA();
		};
		_ZP3psbb9CVMMjGn5SgszZo0zGpF.TextCommit += delegate
		{
			if (int.TryParse(_ZP3psbb9CVMMjGn5SgszZo0zGpF.Text, out var result2))
			{
				_9ycmcfwZ9EbmXanrFe7pEfGAAUi.G = (byte)Math.Max(0, Math.Min(result2, 255));
				_fA3AcauqZZ0ncWKv9QA3iklruOI(_9ycmcfwZ9EbmXanrFe7pEfGAAUi, out _kyexzK2VL0y9etRuX79HInHIsIb, out _46o2iZ9juR1nNURyrP41h9vxpGA, out _xX4CfdHl6arem4v3fUgbDUIK2gM);
				action_0(_9ycmcfwZ9EbmXanrFe7pEfGAAUi);
			}
			_XDKgJpkUD4lIN2K7ysMOtqO5gMA();
		};
		_E3KHmDW9haZynE9ZamZBVdveWgk.TextCommit += delegate
		{
			if (int.TryParse(_E3KHmDW9haZynE9ZamZBVdveWgk.Text, out var result))
			{
				_9ycmcfwZ9EbmXanrFe7pEfGAAUi.B = (byte)Math.Max(0, Math.Min(result, 255));
				_fA3AcauqZZ0ncWKv9QA3iklruOI(_9ycmcfwZ9EbmXanrFe7pEfGAAUi, out _kyexzK2VL0y9etRuX79HInHIsIb, out _46o2iZ9juR1nNURyrP41h9vxpGA, out _xX4CfdHl6arem4v3fUgbDUIK2gM);
				action_0(_9ycmcfwZ9EbmXanrFe7pEfGAAUi);
			}
			_XDKgJpkUD4lIN2K7ysMOtqO5gMA();
		};
		_8lboaaRLcpJoVxfwF1kBCisgrjL.TextCommit += delegate
		{
			if (_8lboaaRLcpJoVxfwF1kBCisgrjL.Text.StartsWith("#") && _8lboaaRLcpJoVxfwF1kBCisgrjL.Text.Length <= 7)
			{
				try
				{
					int num = Convert.ToInt32(_8lboaaRLcpJoVxfwF1kBCisgrjL.Text.Substring(1), 16);
					_9ycmcfwZ9EbmXanrFe7pEfGAAUi.B = (byte)((uint)num & 0xFFu);
					_9ycmcfwZ9EbmXanrFe7pEfGAAUi.G = (byte)((uint)(num >> 8) & 0xFFu);
					_9ycmcfwZ9EbmXanrFe7pEfGAAUi.R = (byte)((uint)(num >> 16) & 0xFFu);
					_fA3AcauqZZ0ncWKv9QA3iklruOI(_9ycmcfwZ9EbmXanrFe7pEfGAAUi, out _kyexzK2VL0y9etRuX79HInHIsIb, out _46o2iZ9juR1nNURyrP41h9vxpGA, out _xX4CfdHl6arem4v3fUgbDUIK2gM);
					action_0(_9ycmcfwZ9EbmXanrFe7pEfGAAUi);
				}
				catch
				{
				}
			}
			_XDKgJpkUD4lIN2K7ysMOtqO5gMA();
		};
		_L7VColD35B3sDgJdUnjTeXGa7pv.Update += delegate
		{
			if (base.Game._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(Microsoft.Xna.Framework.Input.Keys.Escape))
			{
				_L7VColD35B3sDgJdUnjTeXGa7pv.Close();
				_hSPLyBveOIKpCKgimgpgcMUDdRz = null;
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

	private static Color _lAdyiyyWQrRKWYduTPacHqdzOmj(double double_0, double double_1, double double_2, float float_0)
	{
		double num;
		double num2;
		double num3;
		if (double_1 <= 0.0)
		{
			num = double_2;
			num2 = double_2;
			num3 = double_2;
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
				num = double_2;
				num2 = num6;
				num3 = num7;
				break;
			case 0:
				num = double_2;
				num2 = num8;
				num3 = num6;
				break;
			case 1:
				num = num7;
				num2 = double_2;
				num3 = num6;
				break;
			case 2:
				num = num6;
				num2 = double_2;
				num3 = num8;
				break;
			case 3:
				num = num6;
				num2 = num7;
				num3 = double_2;
				break;
			case 4:
				num = num8;
				num2 = num6;
				num3 = double_2;
				break;
			}
		}
		return new Color((float)num, (float)num2, (float)num3, float_0);
	}
}
