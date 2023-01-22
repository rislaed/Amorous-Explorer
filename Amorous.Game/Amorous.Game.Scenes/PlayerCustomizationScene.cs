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

public class PlayerCustomizationScene : _7UlnfykmEmZDFt3BmCKZekI43Ih
{
	private class SexsceneData
	{
		public string _RB8fRXeQvK5vs7JEA0XfVCEpg1i { get; }

		public string _XbOXR6AypLIdJ3gBMGseGi3Wi2i { get; }

		public SexsceneData(string string_0, string string_1)
		{
			_WJT1PtSst4BMDPVrhqxz2VnJrOC = string_0;
			_lToB8ouR2ppZvt0Yb49qzPAAZJS = string_1;
		}
	}

	protected bool _jIGpzoYLVPw8SPxmJcha832nCXR;

	private _MqMsYrF1I2ghuKhx3f6aKuRGquq _q9fwz0K4rjUrAm9v3Dn6azqJaIN;

	private Panel _0jH3FoV36utxuSLivmD6IZNwppA;

	private List<Button> _kG9DrP49ggNdZOvVMMUPjfqdzZ4;

	private Panel _TbkP67ntBpYJu1M27pBfsYAHmgJ;

	private readonly PlayerDataProxy _3t4w2BwPGr8GQDmJlQU929IFD8f;

	private Window _hSPLyBveOIKpCKgimgpgcMUDdRz;

	private readonly Effect _9jklVVcQQYcyqOYrkPiht2VP0IG;

	private readonly List<SexsceneData> _7VjfLBpTQsFudLfKhPWefSex1UC = new List<SexsceneData>
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

	protected virtual string Amorous_002EGame_002EScenes_002EPlayerCustomizationScene_002E_l3SUNsFudHnZpYO0ErWgbTaz1DF => "Exit";

	public PlayerCustomizationScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Background", "Assets/Scenes/Bedroom/Bedroom", -458, 0);
		_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(new _fAUddQEKfZyemRb327NhM3GGlmzA(this, "Custom")
		{
			_B6VrMlmWofCGqEzjzgFJiAliCge = _KkwafXXLVg1QfQgqqCAojg2ySyZ
		}, 0);
		_LTwaEzSn23m9dquR3WwhTVRbJiG = _7VjfLBpTQsFudLfKhPWefSex1UC.Select((SexsceneData sexsceneData_0) => sexsceneData_0._RB8fRXeQvK5vs7JEA0XfVCEpg1i).ToArray();
		_3t4w2BwPGr8GQDmJlQU929IFD8f = new PlayerDataProxy(_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t());
		_3t4w2BwPGr8GQDmJlQU929IFD8f._jCsrJ38OEkr542qwd48oa3BLDIB += delegate
		{
			if (base._ZzBuoSDMWwerejOO9Goyv2OCKgE._KVSwpLj0RvURRswHn7ogRy4BRfd != null)
			{
				base._ZzBuoSDMWwerejOO9Goyv2OCKgE._KVSwpLj0RvURRswHn7ogRy4BRfd._0cFb48aKbcbREkHm9Jwptl6r6Vi();
			}
		};
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/Blazing Dragon - Midnight Sizzle", 0.4f);
		_9jklVVcQQYcyqOYrkPiht2VP0IG = _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Effect>("Assets/Shaders/Breathing");
	}

	public override void _4hlxzMzKSbVTbZUrEsP3dfw4x0h()
	{
		_q9fwz0K4rjUrAm9v3Dn6azqJaIN = new _MqMsYrF1I2ghuKhx3f6aKuRGquq(base._ZzBuoSDMWwerejOO9Goyv2OCKgE);
		_hI8MfcRDpV9Q45afjBJe8lA5sbr();
		_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._Wrz1IORok7yBtsQA3czQUmnP6Yl(_q9fwz0K4rjUrAm9v3Dn6azqJaIN);
		_dJMkrCEG7sVmAlGOM9PfNSkFZZC();
	}

	protected virtual void _hI8MfcRDpV9Q45afjBJe8lA5sbr()
	{
		if (_q9fwz0K4rjUrAm9v3Dn6azqJaIN._I6gsCHlb2BKFCJSAk9Cn5fCMAPu.Any())
		{
			_q9fwz0K4rjUrAm9v3Dn6azqJaIN._BCRMBb9uhQZrQlfdXPidu27yb8C(0);
			_3t4w2BwPGr8GQDmJlQU929IFD8f._RB8fRXeQvK5vs7JEA0XfVCEpg1i = _q9fwz0K4rjUrAm9v3Dn6azqJaIN._6qwooGF3jWmbG9887Y5IKZ8fJ0E(0);
			_QjFuG8JMGq8rGnavgUdgnBEKBfD = 0;
		}
		else
		{
			_q9fwz0K4rjUrAm9v3Dn6azqJaIN._BwV21jdCpo4YpIp6x74bJ0H7hut(0);
			_3t4w2BwPGr8GQDmJlQU929IFD8f._RB8fRXeQvK5vs7JEA0XfVCEpg1i = "Player";
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
		if (!_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
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
		window.Show(base._PnkAlVnMv0SZvRBFexqzE5DF9tp);
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
			Text = _3t4w2BwPGr8GQDmJlQU929IFD8f._RB8fRXeQvK5vs7JEA0XfVCEpg1i,
			Margin = new Margin(0, 0, 0, 5)
		};
		_Z0ib1EsNAOHar3w2AfvKgeb8s2BA.TextChanged += delegate
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._RB8fRXeQvK5vs7JEA0XfVCEpg1i = _Z0ib1EsNAOHar3w2AfvKgeb8s2BA.Text;
		};
		controlCollection_0.Add(_Z0ib1EsNAOHar3w2AfvKgeb8s2BA);
		_YemBTJprwfbd3mpg5Gy9uyEJWwI(controlCollection_0, "Stock Templates", _q9fwz0K4rjUrAm9v3Dn6azqJaIN._A088aXIdbVflSYtbl7vA5RjQOjXA.Select((_xJL9E6vKdg1LYZtKQU5RQKikpvE _xJL9E6vKdg1LYZtKQU5RQKikpvE_0) => _xJL9E6vKdg1LYZtKQU5RQKikpvE_0._RB8fRXeQvK5vs7JEA0XfVCEpg1i).ToArray(), _3yqpoxOljKnrj7mGlnrA0eOUMAk, delegate(int int_0)
		{
			_3yqpoxOljKnrj7mGlnrA0eOUMAk = int_0;
			_q9fwz0K4rjUrAm9v3Dn6azqJaIN._BwV21jdCpo4YpIp6x74bJ0H7hut(int_0);
			_TbkP67ntBpYJu1M27pBfsYAHmgJ.Content.Controls.Clear();
			_OBIbaNO8X49ahEZ5n3Ta8HUK7mO(controlCollection_0);
			if (base._ZzBuoSDMWwerejOO9Goyv2OCKgE._KVSwpLj0RvURRswHn7ogRy4BRfd != null)
			{
				base._ZzBuoSDMWwerejOO9Goyv2OCKgE._KVSwpLj0RvURRswHn7ogRy4BRfd._0cFb48aKbcbREkHm9Jwptl6r6Vi();
			}
		});
		_YemBTJprwfbd3mpg5Gy9uyEJWwI(controlCollection_0, "Your Templates", _q9fwz0K4rjUrAm9v3Dn6azqJaIN._I6gsCHlb2BKFCJSAk9Cn5fCMAPu.Select((_xJL9E6vKdg1LYZtKQU5RQKikpvE _xJL9E6vKdg1LYZtKQU5RQKikpvE_0) => _xJL9E6vKdg1LYZtKQU5RQKikpvE_0._RB8fRXeQvK5vs7JEA0XfVCEpg1i).ToArray(), _QjFuG8JMGq8rGnavgUdgnBEKBfD, delegate(int int_0)
		{
			_QjFuG8JMGq8rGnavgUdgnBEKBfD = int_0;
			_q9fwz0K4rjUrAm9v3Dn6azqJaIN._BCRMBb9uhQZrQlfdXPidu27yb8C(int_0);
			_3t4w2BwPGr8GQDmJlQU929IFD8f._RB8fRXeQvK5vs7JEA0XfVCEpg1i = _q9fwz0K4rjUrAm9v3Dn6azqJaIN._6qwooGF3jWmbG9887Y5IKZ8fJ0E(int_0);
			_TbkP67ntBpYJu1M27pBfsYAHmgJ.Content.Controls.Clear();
			_OBIbaNO8X49ahEZ5n3Ta8HUK7mO(controlCollection_0);
			if (base._ZzBuoSDMWwerejOO9Goyv2OCKgE._KVSwpLj0RvURRswHn7ogRy4BRfd != null)
			{
				base._ZzBuoSDMWwerejOO9Goyv2OCKgE._KVSwpLj0RvURRswHn7ogRy4BRfd._0cFb48aKbcbREkHm9Jwptl6r6Vi();
			}
		});
		Control control = _z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Phone", _3t4w2BwPGr8GQDmJlQU929IFD8f._uOkbmfW26QVAvyEMQakki9kTMDbA, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._uOkbmfW26QVAvyEMQakki9kTMDbA = color_0;
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
				base._PnkAlVnMv0SZvRBFexqzE5DF9tp._0pVU36wp9GYD1jM18raZtVEbA9q("You did not enter a name!", 500);
			}
			else
			{
				_yA2ISabBQiVKBxMt5AXSybmkG5o($"Are you sure you wish to create a new template with the name '{_Z0ib1EsNAOHar3w2AfvKgeb8s2BA.Text}', based on the current character?", delegate
				{
					_q9fwz0K4rjUrAm9v3Dn6azqJaIN._0S3oMrwxDtOTcbzkglSllPfRq53(_Z0ib1EsNAOHar3w2AfvKgeb8s2BA.Text, _3t4w2BwPGr8GQDmJlQU929IFD8f._dxo6sBOpjEUiw2JBMikbutXK44t());
					_QjFuG8JMGq8rGnavgUdgnBEKBfD = _q9fwz0K4rjUrAm9v3Dn6azqJaIN._I6gsCHlb2BKFCJSAk9Cn5fCMAPu.Count() - 1;
					_q9fwz0K4rjUrAm9v3Dn6azqJaIN._BCRMBb9uhQZrQlfdXPidu27yb8C(_QjFuG8JMGq8rGnavgUdgnBEKBfD);
					_3t4w2BwPGr8GQDmJlQU929IFD8f._RB8fRXeQvK5vs7JEA0XfVCEpg1i = _q9fwz0K4rjUrAm9v3Dn6azqJaIN._6qwooGF3jWmbG9887Y5IKZ8fJ0E(_QjFuG8JMGq8rGnavgUdgnBEKBfD);
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
				base._PnkAlVnMv0SZvRBFexqzE5DF9tp._0pVU36wp9GYD1jM18raZtVEbA9q("You did not enter a name!", 500);
			}
			else if (_QjFuG8JMGq8rGnavgUdgnBEKBfD >= 0)
			{
				_yA2ISabBQiVKBxMt5AXSybmkG5o($"Are you sure you wish to save the currect character to the selected template '{_q9fwz0K4rjUrAm9v3Dn6azqJaIN._6qwooGF3jWmbG9887Y5IKZ8fJ0E(_QjFuG8JMGq8rGnavgUdgnBEKBfD)}'?", delegate
				{
					_q9fwz0K4rjUrAm9v3Dn6azqJaIN._WfRAwdaNcmrDEhMe1AHPq7egPcw(_Z0ib1EsNAOHar3w2AfvKgeb8s2BA.Text, _QjFuG8JMGq8rGnavgUdgnBEKBfD, _3t4w2BwPGr8GQDmJlQU929IFD8f._dxo6sBOpjEUiw2JBMikbutXK44t());
					_TbkP67ntBpYJu1M27pBfsYAHmgJ.Content.Controls.Clear();
					_OBIbaNO8X49ahEZ5n3Ta8HUK7mO(controlCollection_0);
				});
			}
			else
			{
				_yA2ISabBQiVKBxMt5AXSybmkG5o($"No template has been selected yet, do you wish to create a new template with the name '{_Z0ib1EsNAOHar3w2AfvKgeb8s2BA.Text}', based on the current character?", delegate
				{
					_q9fwz0K4rjUrAm9v3Dn6azqJaIN._0S3oMrwxDtOTcbzkglSllPfRq53(_Z0ib1EsNAOHar3w2AfvKgeb8s2BA.Text, _3t4w2BwPGr8GQDmJlQU929IFD8f._dxo6sBOpjEUiw2JBMikbutXK44t());
					_QjFuG8JMGq8rGnavgUdgnBEKBfD = _q9fwz0K4rjUrAm9v3Dn6azqJaIN._I6gsCHlb2BKFCJSAk9Cn5fCMAPu.Count() - 1;
					_q9fwz0K4rjUrAm9v3Dn6azqJaIN._BCRMBb9uhQZrQlfdXPidu27yb8C(_QjFuG8JMGq8rGnavgUdgnBEKBfD);
					_3t4w2BwPGr8GQDmJlQU929IFD8f._RB8fRXeQvK5vs7JEA0XfVCEpg1i = _q9fwz0K4rjUrAm9v3Dn6azqJaIN._6qwooGF3jWmbG9887Y5IKZ8fJ0E(_QjFuG8JMGq8rGnavgUdgnBEKBfD);
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
				_yA2ISabBQiVKBxMt5AXSybmkG5o($"Are you sure you wish to reset the current character back to selected template '{_q9fwz0K4rjUrAm9v3Dn6azqJaIN._6qwooGF3jWmbG9887Y5IKZ8fJ0E(_QjFuG8JMGq8rGnavgUdgnBEKBfD)}'? All changes will be lost!", delegate
				{
					_q9fwz0K4rjUrAm9v3Dn6azqJaIN._JC60lfB4LT6VifObN1Ynm6iARlc(_QjFuG8JMGq8rGnavgUdgnBEKBfD);
					_3t4w2BwPGr8GQDmJlQU929IFD8f._RB8fRXeQvK5vs7JEA0XfVCEpg1i = _q9fwz0K4rjUrAm9v3Dn6azqJaIN._6qwooGF3jWmbG9887Y5IKZ8fJ0E(_QjFuG8JMGq8rGnavgUdgnBEKBfD);
					_TbkP67ntBpYJu1M27pBfsYAHmgJ.Content.Controls.Clear();
					_OBIbaNO8X49ahEZ5n3Ta8HUK7mO(controlCollection_0);
				});
			}
			else
			{
				base._PnkAlVnMv0SZvRBFexqzE5DF9tp._0pVU36wp9GYD1jM18raZtVEbA9q("You did not select a template!", 500);
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
				_yA2ISabBQiVKBxMt5AXSybmkG5o($"Are you sure you wish to delete the selected template '{_q9fwz0K4rjUrAm9v3Dn6azqJaIN._6qwooGF3jWmbG9887Y5IKZ8fJ0E(_QjFuG8JMGq8rGnavgUdgnBEKBfD)}'?", delegate
				{
					_q9fwz0K4rjUrAm9v3Dn6azqJaIN._FzyCgzYhOXEADaijk8VbcLulpcBA(_QjFuG8JMGq8rGnavgUdgnBEKBfD);
					_QjFuG8JMGq8rGnavgUdgnBEKBfD = -1;
					_TbkP67ntBpYJu1M27pBfsYAHmgJ.Content.Controls.Clear();
					_OBIbaNO8X49ahEZ5n3Ta8HUK7mO(controlCollection_0);
				});
			}
			else
			{
				base._PnkAlVnMv0SZvRBFexqzE5DF9tp._0pVU36wp9GYD1jM18raZtVEbA9q("You did not select a template!", 500);
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
			_q9fwz0K4rjUrAm9v3Dn6azqJaIN._BlScjiyHDsZk3jkAZbAbjUxn87sA();
		};
		controlCollection_0.Add(button5);
		if (!_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
		{
			_YemBTJprwfbd3mpg5Gy9uyEJWwI(controlCollection_0, "Preview Sexscene", _LTwaEzSn23m9dquR3WwhTVRbJiG, _IyCJr9wgsrQgOUaXQco1I00YF7B, delegate(int int_0)
			{
				_IyCJr9wgsrQgOUaXQco1I00YF7B = int_0;
				if (int_0 == 0)
				{
					base._ZzBuoSDMWwerejOO9Goyv2OCKgE._Ec0fhBrUGmjaIKjUfJioigVc65x();
				}
				else
				{
					base._ZzBuoSDMWwerejOO9Goyv2OCKgE._gYGB98heFqsLp9tgJbdCP01IKV2(_7VjfLBpTQsFudLfKhPWefSex1UC[int_0]._XbOXR6AypLIdJ3gBMGseGi3Wi2i);
					base._ZzBuoSDMWwerejOO9Goyv2OCKgE._KVSwpLj0RvURRswHn7ogRy4BRfd._7BfTap1TnZXk1aaAXnFODowTQCp = true;
				}
			});
		}
		if (!base._PnkAlVnMv0SZvRBFexqzE5DF9tp.Skin.ContainsKey("button2"))
		{
			base._PnkAlVnMv0SZvRBFexqzE5DF9tp.Skin.Add("button2", new ControlStyle(base._PnkAlVnMv0SZvRBFexqzE5DF9tp.Skin["button"])
			{
				Tint = ColorInt.ARGB(1f, 0f, 1f, 0f)
			});
		}
		Button button6 = new Button
		{
			Margin = new Margin(0, 10, 0, 0),
			Dock = DockStyle.Top,
			Text = Amorous_002EGame_002EScenes_002EPlayerCustomizationScene_002E_l3SUNsFudHnZpYO0ErWgbTaz1DF,
			Style = "button2"
		};
		button6.MouseClick += delegate
		{
			if (_jIGpzoYLVPw8SPxmJcha832nCXR && string.IsNullOrWhiteSpace(_Z0ib1EsNAOHar3w2AfvKgeb8s2BA.Text))
			{
				base._PnkAlVnMv0SZvRBFexqzE5DF9tp._0pVU36wp9GYD1jM18raZtVEbA9q("You did not enter a name!", 500);
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
		base._PnkAlVnMv0SZvRBFexqzE5DF9tp._GtkWDtXwQHwgWY4aFkacjfUDyzb(string_0, new string[2] { "No way!", "Yes please!" }, 500, delegate(int int_0)
		{
			if (int_0 == 1)
			{
				action_0();
			}
		});
	}

	protected virtual void _n3b8BstkorCsu4TW0U2YVdFbdGp()
	{
		base._PnkAlVnMv0SZvRBFexqzE5DF9tp._GtkWDtXwQHwgWY4aFkacjfUDyzb("Are you sure you wish to exit? All unsaved changes will be lost!", new string[2] { "Oops, my bad!", "Yes please!" }, 500, delegate(int int_0)
		{
			if (int_0 == 1)
			{
				base._ZzBuoSDMWwerejOO9Goyv2OCKgE._k9wUPeU1Ga7cygiuGP8TT6aPLWF<MainMenuScene>();
			}
		});
	}

	private void _jiNxMIzuA8Rrc2ULsrob5A7UNDe(ControlCollection controlCollection_0)
	{
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Body", _3t4w2BwPGr8GQDmJlQU929IFD8f._8CtoV1bqn0CwCzb1tuoNppBt0Gg, delegate(_opIJo2jLUqdOL5yAFP4yzXce0DG.EBodyType ebodyType_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._8CtoV1bqn0CwCzb1tuoNppBt0Gg = ebodyType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Body Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._6f1rvTENt5XWmHTE22zxBIwbH9G, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._6f1rvTENt5XWmHTE22zxBIwbH9G = color_0;
		});
		_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Underbelly Marking", _opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Underbelly, _3t4w2BwPGr8GQDmJlQU929IFD8f._PeK36AvFxEQCvX3fS62hNV7rpuJ, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._PeK36AvFxEQCvX3fS62hNV7rpuJ = color_0;
		});
		_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Underthigh Marking", _opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Underthigh, _3t4w2BwPGr8GQDmJlQU929IFD8f._zBv1cYqPRU7uDCALpBlBSgObUcbA, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._zBv1cYqPRU7uDCALpBlBSgObUcbA = color_0;
		});
		_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Stripes Marking", _opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Stripes, _3t4w2BwPGr8GQDmJlQU929IFD8f._TxfCqloeyiHpsXka6B46iqCZNsZ, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._TxfCqloeyiHpsXka6B46iqCZNsZ = color_0;
		});
		_HdTJZZGoOMNi89T0yAdBraCZMjc(controlCollection_0, "Nails", _3t4w2BwPGr8GQDmJlQU929IFD8f._VmNLhqrIwSnE6JnCYiBcxnSqnEV, _3t4w2BwPGr8GQDmJlQU929IFD8f._in5HHYmrdLTFpkgc8aimJpXqAXB, delegate(bool bool_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._VmNLhqrIwSnE6JnCYiBcxnSqnEV = bool_0;
		}, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._in5HHYmrdLTFpkgc8aimJpXqAXB = color_0;
		});
	}

	private void _1qIQUjhrbk5WA7C7mYs93gXLOIe(ControlCollection controlCollection_0)
	{
		_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Long Forearm Marking", _opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.LongForearm, _3t4w2BwPGr8GQDmJlQU929IFD8f._1ZKGQXLRAHEJR8v7jhlDsyOVLcz, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._1ZKGQXLRAHEJR8v7jhlDsyOVLcz = color_0;
		});
		_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Short Forearm Marking", _opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.ShortForearm, _3t4w2BwPGr8GQDmJlQU929IFD8f._8rDSn6e9Ip9WdOogjhIn8YlL1oM, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._8rDSn6e9Ip9WdOogjhIn8YlL1oM = color_0;
		});
		_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Avian Forearm Marking", _opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.AvianForearm, _3t4w2BwPGr8GQDmJlQU929IFD8f._FrsyMDX7TebzFk8nSLTyRDPi1QH, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._FrsyMDX7TebzFk8nSLTyRDPi1QH = color_0;
		});
	}

	private void _VCrdQDifkN8NHlzPICTmtbgWFwp(ControlCollection controlCollection_0)
	{
		_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Long Shin Marking", _opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.LongShin, _3t4w2BwPGr8GQDmJlQU929IFD8f._cUtgkG5qDvgFmI8c29I9xsLVNON, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._cUtgkG5qDvgFmI8c29I9xsLVNON = color_0;
		});
		_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Short Shin Marking", _opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.ShortShin, _3t4w2BwPGr8GQDmJlQU929IFD8f._LcOPiDaC2j5vzxOEYhvW4vRoaRX, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._LcOPiDaC2j5vzxOEYhvW4vRoaRX = color_0;
		});
		_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Avian Shin Marking", _opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.AvianShin, _3t4w2BwPGr8GQDmJlQU929IFD8f._meyNS02iTIxo212B6c5eoKns2wj, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._meyNS02iTIxo212B6c5eoKns2wj = color_0;
		});
	}

	private void _vXrWU56trsuFNc9CNcHuctfkI2S(ControlCollection controlCollection_0)
	{
		Panel _5DnedRtrhRxc4WXg7XVOkddr43f = new Panel
		{
			Dock = DockStyle.Fill,
			Visible = (_3t4w2BwPGr8GQDmJlQU929IFD8f._UjtZovBCLAtBZnUfbTvRFsaf5mx == _opIJo2jLUqdOL5yAFP4yzXce0DG.EHeadType.Default)
		};
		Panel _KH5vstJZR49J3eWlwNclJbU5SDe = new Panel
		{
			Dock = DockStyle.Fill,
			Visible = (_3t4w2BwPGr8GQDmJlQU929IFD8f._UjtZovBCLAtBZnUfbTvRFsaf5mx == _opIJo2jLUqdOL5yAFP4yzXce0DG.EHeadType.PaperBag)
		};
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Head", _3t4w2BwPGr8GQDmJlQU929IFD8f._UjtZovBCLAtBZnUfbTvRFsaf5mx, delegate(_opIJo2jLUqdOL5yAFP4yzXce0DG.EHeadType eheadType_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._UjtZovBCLAtBZnUfbTvRFsaf5mx = eheadType_0;
			switch (eheadType_0)
			{
			case _opIJo2jLUqdOL5yAFP4yzXce0DG.EHeadType.Default:
				_5DnedRtrhRxc4WXg7XVOkddr43f.Visible = true;
				_KH5vstJZR49J3eWlwNclJbU5SDe.Visible = false;
				break;
			case _opIJo2jLUqdOL5yAFP4yzXce0DG.EHeadType.Humanoid:
				_5DnedRtrhRxc4WXg7XVOkddr43f.Visible = false;
				_KH5vstJZR49J3eWlwNclJbU5SDe.Visible = false;
				break;
			case _opIJo2jLUqdOL5yAFP4yzXce0DG.EHeadType.PaperBag:
				_5DnedRtrhRxc4WXg7XVOkddr43f.Visible = false;
				_KH5vstJZR49J3eWlwNclJbU5SDe.Visible = true;
				break;
			}
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Head Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._1qfGl3Oc2JyQEpnQtdOxMeMkqhi, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._1qfGl3Oc2JyQEpnQtdOxMeMkqhi = color_0;
		});
		_h7MUbT306Ju5xwvamN8SatTR2Mo(_5DnedRtrhRxc4WXg7XVOkddr43f.Content.Controls, "Gaunt Marking", _opIJo2jLUqdOL5yAFP4yzXce0DG._iDe3W6qb7jKTPuJV79yf2i7UoIq.Gaunt, _3t4w2BwPGr8GQDmJlQU929IFD8f._Fn7Kt1UvxcXOmJ1gIeWdJnRbaQt, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._Fn7Kt1UvxcXOmJ1gIeWdJnRbaQt = color_0;
		});
		_h7MUbT306Ju5xwvamN8SatTR2Mo(_5DnedRtrhRxc4WXg7XVOkddr43f.Content.Controls, "Scruffy Marking", _opIJo2jLUqdOL5yAFP4yzXce0DG._iDe3W6qb7jKTPuJV79yf2i7UoIq.Scruffy, _3t4w2BwPGr8GQDmJlQU929IFD8f._WvoLJ4MA4gYEsgOmmIQvfK3xFlu, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._WvoLJ4MA4gYEsgOmmIQvfK3xFlu = color_0;
		});
		_h7MUbT306Ju5xwvamN8SatTR2Mo(_5DnedRtrhRxc4WXg7XVOkddr43f.Content.Controls, "Snout Marking", _opIJo2jLUqdOL5yAFP4yzXce0DG._iDe3W6qb7jKTPuJV79yf2i7UoIq.Snout, _3t4w2BwPGr8GQDmJlQU929IFD8f._lUyqwDvFCoXEZ6VM9PVCQ970jps, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._lUyqwDvFCoXEZ6VM9PVCQ970jps = color_0;
		});
		_h7MUbT306Ju5xwvamN8SatTR2Mo(_5DnedRtrhRxc4WXg7XVOkddr43f.Content.Controls, "Stripes Marking", _opIJo2jLUqdOL5yAFP4yzXce0DG._iDe3W6qb7jKTPuJV79yf2i7UoIq.Stripes, _3t4w2BwPGr8GQDmJlQU929IFD8f._qKGefHxdjIUD6ObjxrxnLwbBEsh, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._qKGefHxdjIUD6ObjxrxnLwbBEsh = color_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(_KH5vstJZR49J3eWlwNclJbU5SDe.Content.Controls, "Paper Bag Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._VWdlqWB4z2wNtm197Oiv32QGVbE, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._VWdlqWB4z2wNtm197Oiv32QGVbE = color_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(_KH5vstJZR49J3eWlwNclJbU5SDe.Content.Controls, "Eyesholes Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._sbSAaAmkhONcFX6f0JtHbVQbEfG, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._sbSAaAmkhONcFX6f0JtHbVQbEfG = color_0;
		});
		controlCollection_0.Add(_5DnedRtrhRxc4WXg7XVOkddr43f);
		controlCollection_0.Add(_KH5vstJZR49J3eWlwNclJbU5SDe);
	}

	private void _vg6ASaP7xNqc0jerF3mcrXv4dn7(ControlCollection controlCollection_0)
	{
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Muzzle", _3t4w2BwPGr8GQDmJlQU929IFD8f._4QUr9lDqmNxEuy7B4xgb7Lj1HU0, delegate(_opIJo2jLUqdOL5yAFP4yzXce0DG.EMuzzleType emuzzleType_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._4QUr9lDqmNxEuy7B4xgb7Lj1HU0 = emuzzleType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Muzzle Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._VsEYbNSam3IFYYWY4QC2lb4ia61, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._VsEYbNSam3IFYYWY4QC2lb4ia61 = color_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Nose Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._y1SiMmRVXWDhDtY17knDpitt46F, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._y1SiMmRVXWDhDtY17knDpitt46F = color_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Teeth Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._T98drEOtEEZKeB5tXzsuPrhb5Xk, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._T98drEOtEEZKeB5tXzsuPrhb5Xk = color_0;
		});
		_HdTJZZGoOMNi89T0yAdBraCZMjc(controlCollection_0, "Muzzle Horn", _3t4w2BwPGr8GQDmJlQU929IFD8f._hkFDGB5pWIuOVcIyDAFqHrDdSpjA, _3t4w2BwPGr8GQDmJlQU929IFD8f._q2iDxJYfqribHB1bD8aSkSjqrfnA, delegate(bool bool_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._hkFDGB5pWIuOVcIyDAFqHrDdSpjA = bool_0;
		}, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._q2iDxJYfqribHB1bD8aSkSjqrfnA = color_0;
		});
		_HdTJZZGoOMNi89T0yAdBraCZMjc(controlCollection_0, "Muzzle Mask", _3t4w2BwPGr8GQDmJlQU929IFD8f._UAZhvJ3a9BGOBM0CLiDkKLwUFC9, _3t4w2BwPGr8GQDmJlQU929IFD8f._phJrpk3rql5MfNJxPQ9X7nC8aAk, delegate(bool bool_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._UAZhvJ3a9BGOBM0CLiDkKLwUFC9 = bool_0;
		}, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._phJrpk3rql5MfNJxPQ9X7nC8aAk = color_0;
		});
	}

	private void _Xhurp3mVVoR5kNlnxgLoDDkeQxM(ControlCollection controlCollection_0)
	{
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Ears and Horns", _3t4w2BwPGr8GQDmJlQU929IFD8f._pmr0FnBBvgaggpusBKMWplUa63c, delegate(_opIJo2jLUqdOL5yAFP4yzXce0DG.EHeadAccessoriesType eheadAccessoriesType_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._pmr0FnBBvgaggpusBKMWplUa63c = eheadAccessoriesType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Horns Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._9b2asKZDwVM1TcSfmfeFCuk0TJZb, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._9b2asKZDwVM1TcSfmfeFCuk0TJZb = color_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Ear Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._vUhBAXEgvpGKopOUkDJFoc4EYQ3, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._vUhBAXEgvpGKopOUkDJFoc4EYQ3 = color_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Ear Inner Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._uaBF7rEib15d42vH8AzoXWFMMkE, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._uaBF7rEib15d42vH8AzoXWFMMkE = color_0;
		});
	}

	private void _gHA9C0CRN2NaRMtfTrvlotJOd0T(ControlCollection controlCollection_0)
	{
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Hair", _3t4w2BwPGr8GQDmJlQU929IFD8f._03h2I0mTkGTzIA5R48rgwJh7JZA, delegate(_opIJo2jLUqdOL5yAFP4yzXce0DG.EHairstyleType ehairstyleType_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._03h2I0mTkGTzIA5R48rgwJh7JZA = ehairstyleType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Hair Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._bJmvnPs69aVDXxG48lmruYZFHKt, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._bJmvnPs69aVDXxG48lmruYZFHKt = color_0;
		});
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Fringe", _3t4w2BwPGr8GQDmJlQU929IFD8f._fzMbZCCd7imnrcrYWkSj5u8UZ2J, delegate(_opIJo2jLUqdOL5yAFP4yzXce0DG.EFringeType efringeType_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._fzMbZCCd7imnrcrYWkSj5u8UZ2J = efringeType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Fringe Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._EvdUMrkAAdTeMv6fOpGrOLCAMq8A, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._EvdUMrkAAdTeMv6fOpGrOLCAMq8A = color_0;
		});
	}

	private void _hNo7o9fG9jvwcKyMq1nYl4q7cXc(ControlCollection controlCollection_0)
	{
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Eyes", _3t4w2BwPGr8GQDmJlQU929IFD8f._c0ThYURHAGN0Wzlzw9Ibh3Z8qyo, delegate(_opIJo2jLUqdOL5yAFP4yzXce0DG.EEyesType eeyesType_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._c0ThYURHAGN0Wzlzw9Ibh3Z8qyo = eeyesType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Eyes Back Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._GXnDb1oaJlPbAQV2mjAwCQFK0nmb, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._GXnDb1oaJlPbAQV2mjAwCQFK0nmb = color_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Eyes Front Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._0K4lcN7iwo5q0iP1YlkpY9GdayR, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._0K4lcN7iwo5q0iP1YlkpY9GdayR = color_0;
		});
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Brows", _3t4w2BwPGr8GQDmJlQU929IFD8f._KBOJ0qhM8C5evPQxibgX74m2WHg, delegate(_opIJo2jLUqdOL5yAFP4yzXce0DG.EBrowType ebrowType_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._KBOJ0qhM8C5evPQxibgX74m2WHg = ebrowType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Brows Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._HRPv5rzDY5zNiP4NADDEGhrzGTe, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._HRPv5rzDY5zNiP4NADDEGhrzGTe = color_0;
		});
	}

	private void _mWS8UuA4xcT1bSdjDObiubOE0wH(ControlCollection controlCollection_0)
	{
		Panel _63PX0QXRoq6jeUvG5xheRABNwsg = new Panel
		{
			Dock = DockStyle.Top,
			Visible = (_3t4w2BwPGr8GQDmJlQU929IFD8f._BCncLn6BIYiBX6NdFByAquBYGpH != _opIJo2jLUqdOL5yAFP4yzXce0DG.EBreastsType.None)
		};
		Panel _TLsIePSD9UbEwlT0HwKiF2xZX87 = new Panel
		{
			Dock = DockStyle.Top,
			Visible = (_3t4w2BwPGr8GQDmJlQU929IFD8f._rtyJgfViJdXL2Ela5APpDlk99dI != _opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType.None)
		};
		Panel _s9TeQxnG80yYnmcOHHr4bw9fWCh = new Panel
		{
			Dock = DockStyle.Top,
			Visible = (_3t4w2BwPGr8GQDmJlQU929IFD8f._7OCMpsMmozHsAG0GDljMMAlGLJBA != _opIJo2jLUqdOL5yAFP4yzXce0DG.EBallsType.None)
		};
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Breasts", _3t4w2BwPGr8GQDmJlQU929IFD8f._BCncLn6BIYiBX6NdFByAquBYGpH, delegate(_opIJo2jLUqdOL5yAFP4yzXce0DG.EBreastsType ebreastsType_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._BCncLn6BIYiBX6NdFByAquBYGpH = ebreastsType_0;
			_63PX0QXRoq6jeUvG5xheRABNwsg.Visible = _3t4w2BwPGr8GQDmJlQU929IFD8f._BCncLn6BIYiBX6NdFByAquBYGpH != _opIJo2jLUqdOL5yAFP4yzXce0DG.EBreastsType.None;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(_63PX0QXRoq6jeUvG5xheRABNwsg.Content.Controls, "Breasts Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._pigzqi6DgcSToQkL9g7Ns2QrLfp, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._pigzqi6DgcSToQkL9g7Ns2QrLfp = color_0;
		});
		_HdTJZZGoOMNi89T0yAdBraCZMjc(_63PX0QXRoq6jeUvG5xheRABNwsg.Content.Controls, "Nipples", _3t4w2BwPGr8GQDmJlQU929IFD8f._Q2AbpMWcrhtCW9MLTtT5gwoleu7, _3t4w2BwPGr8GQDmJlQU929IFD8f._2yydfEIrSiLPTti2dT8JXGoIaM3, delegate(bool bool_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._Q2AbpMWcrhtCW9MLTtT5gwoleu7 = bool_0;
		}, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._2yydfEIrSiLPTti2dT8JXGoIaM3 = color_0;
		});
		controlCollection_0.Add(_63PX0QXRoq6jeUvG5xheRABNwsg);
		Control _Jhlc8lMI1rq07omae9xc6uig5tv = null;
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Cock", _3t4w2BwPGr8GQDmJlQU929IFD8f._rtyJgfViJdXL2Ela5APpDlk99dI, delegate(_opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType ecockType_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._rtyJgfViJdXL2Ela5APpDlk99dI = ecockType_0;
			_TLsIePSD9UbEwlT0HwKiF2xZX87.Visible = _3t4w2BwPGr8GQDmJlQU929IFD8f._rtyJgfViJdXL2Ela5APpDlk99dI != _opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType.None;
			_Jhlc8lMI1rq07omae9xc6uig5tv.Visible = _3t4w2BwPGr8GQDmJlQU929IFD8f._rtyJgfViJdXL2Ela5APpDlk99dI == _opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType.Cut || _3t4w2BwPGr8GQDmJlQU929IFD8f._rtyJgfViJdXL2Ela5APpDlk99dI == _opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType.Uncut;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(_TLsIePSD9UbEwlT0HwKiF2xZX87.Content.Controls, "Cock Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._XnNREK59QnV1onFFWfSUaS9WK0E, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._XnNREK59QnV1onFFWfSUaS9WK0E = color_0;
		});
		_Jhlc8lMI1rq07omae9xc6uig5tv = _z5npzs7mj5H3zJ1PF64BFNsXBmm(_TLsIePSD9UbEwlT0HwKiF2xZX87.Content.Controls, "Cock Tip Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._o6OnmHi5rZIQPHESokp9rTaO1ei, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._o6OnmHi5rZIQPHESokp9rTaO1ei = color_0;
		});
		_Jhlc8lMI1rq07omae9xc6uig5tv.Visible = _3t4w2BwPGr8GQDmJlQU929IFD8f._rtyJgfViJdXL2Ela5APpDlk99dI == _opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType.Cut || _3t4w2BwPGr8GQDmJlQU929IFD8f._rtyJgfViJdXL2Ela5APpDlk99dI == _opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType.Uncut;
		controlCollection_0.Add(_TLsIePSD9UbEwlT0HwKiF2xZX87);
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Balls", _3t4w2BwPGr8GQDmJlQU929IFD8f._7OCMpsMmozHsAG0GDljMMAlGLJBA, delegate(_opIJo2jLUqdOL5yAFP4yzXce0DG.EBallsType eballsType_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._7OCMpsMmozHsAG0GDljMMAlGLJBA = eballsType_0;
			_s9TeQxnG80yYnmcOHHr4bw9fWCh.Visible = _3t4w2BwPGr8GQDmJlQU929IFD8f._7OCMpsMmozHsAG0GDljMMAlGLJBA != _opIJo2jLUqdOL5yAFP4yzXce0DG.EBallsType.None;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(_s9TeQxnG80yYnmcOHHr4bw9fWCh.Content.Controls, "Balls Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._8qQ7XVlyRYW4icBFxPQCJqgueYD, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._8qQ7XVlyRYW4icBFxPQCJqgueYD = color_0;
		});
		controlCollection_0.Add(_s9TeQxnG80yYnmcOHHr4bw9fWCh);
	}

	private void _7JR6eL4D0qdIJNOwfInnlg2HEgZ(ControlCollection controlCollection_0)
	{
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Tail", _3t4w2BwPGr8GQDmJlQU929IFD8f._NrFEKLWh80bQXi9PujCBTqm01AA, delegate(_opIJo2jLUqdOL5yAFP4yzXce0DG.ETailType etailType_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._NrFEKLWh80bQXi9PujCBTqm01AA = etailType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Tail Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._qsK1J3jktKH3eJ2i8sL1oaxXtLc, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._qsK1J3jktKH3eJ2i8sL1oaxXtLc = color_0;
		});
		_HdTJZZGoOMNi89T0yAdBraCZMjc(controlCollection_0, "Tail Part A", _3t4w2BwPGr8GQDmJlQU929IFD8f._PVQfhwHODkR6bzHmfeCK4L8riIG, _3t4w2BwPGr8GQDmJlQU929IFD8f._62dl1HYYkor3TZL58k5Y33Tj83, delegate(bool bool_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._PVQfhwHODkR6bzHmfeCK4L8riIG = bool_0;
		}, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._62dl1HYYkor3TZL58k5Y33Tj83 = color_0;
		});
		_HdTJZZGoOMNi89T0yAdBraCZMjc(controlCollection_0, "Tail Part B", _3t4w2BwPGr8GQDmJlQU929IFD8f._tEXwTuSRSq5JaaFE4W8edEHxS9q, _3t4w2BwPGr8GQDmJlQU929IFD8f._LufmRsAZrlyDgRKYocQXPzANMaF, delegate(bool bool_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._tEXwTuSRSq5JaaFE4W8edEHxS9q = bool_0;
		}, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._LufmRsAZrlyDgRKYocQXPzANMaF = color_0;
		});
	}

	private void _PBEdYyzYEWcXAodjVf58ocOQ3Jf(ControlCollection controlCollection_0)
	{
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Feet", _3t4w2BwPGr8GQDmJlQU929IFD8f._LZ8c6hRMRYKjnlLOPhbZHcWqUGG, delegate(_opIJo2jLUqdOL5yAFP4yzXce0DG.EFeetType efeetType_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._LZ8c6hRMRYKjnlLOPhbZHcWqUGG = efeetType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Feet Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._LZfuQybASevOsCykEWqdvA5GqUF, delegate(Color color_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._LZfuQybASevOsCykEWqdvA5GqUF = color_0;
		});
	}

	public void _KkwafXXLVg1QfQgqqCAojg2ySyZ(SpriteBatch spriteBatch_0)
	{
		_9jklVVcQQYcyqOYrkPiht2VP0IG.Parameters["Time"].SetValue(_boyt8NIMtKsAGSTcjHeL0WMbFxs._AmIUCcrmrrQiiirja7DoiZSjXuv);
		_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._yuFBJdi7mxrwMFQ57BjLjSq6ESj._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0, _9jklVVcQQYcyqOYrkPiht2VP0IG);
	}

	private void _9x3XvoSKr9dMOykq9pl8AKFzwJ(ControlCollection controlCollection_0, string string_0, _opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U _VzIdKOJ1Gq1YccwwHcwhrVV5V4U_0, Color color_0, Action<Color> action_0)
	{
		_HdTJZZGoOMNi89T0yAdBraCZMjc(controlCollection_0, string_0, _3t4w2BwPGr8GQDmJlQU929IFD8f._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_VzIdKOJ1Gq1YccwwHcwhrVV5V4U_0), color_0, delegate(bool bool_0)
		{
			if (bool_0)
			{
				_3t4w2BwPGr8GQDmJlQU929IFD8f._Mz7LwHZqoGBscApFXmff1kEQnGY |= _VzIdKOJ1Gq1YccwwHcwhrVV5V4U_0;
			}
			else
			{
				_3t4w2BwPGr8GQDmJlQU929IFD8f._Mz7LwHZqoGBscApFXmff1kEQnGY &= ~_VzIdKOJ1Gq1YccwwHcwhrVV5V4U_0;
			}
		}, delegate(Color color_0)
		{
			action_0(color_0);
			_q9fwz0K4rjUrAm9v3Dn6azqJaIN._0cFb48aKbcbREkHm9Jwptl6r6Vi();
		});
	}

	private void _h7MUbT306Ju5xwvamN8SatTR2Mo(ControlCollection controlCollection_0, string string_0, _opIJo2jLUqdOL5yAFP4yzXce0DG._iDe3W6qb7jKTPuJV79yf2i7UoIq _iDe3W6qb7jKTPuJV79yf2i7UoIq_0, Color color_0, Action<Color> action_0)
	{
		_HdTJZZGoOMNi89T0yAdBraCZMjc(controlCollection_0, string_0, _3t4w2BwPGr8GQDmJlQU929IFD8f._SnnHu3P4lDDxgkL6cuUt7y07yxG.HasFlag(_iDe3W6qb7jKTPuJV79yf2i7UoIq_0), color_0, delegate(bool bool_0)
		{
			if (bool_0)
			{
				_3t4w2BwPGr8GQDmJlQU929IFD8f._SnnHu3P4lDDxgkL6cuUt7y07yxG |= _iDe3W6qb7jKTPuJV79yf2i7UoIq_0;
			}
			else
			{
				_3t4w2BwPGr8GQDmJlQU929IFD8f._SnnHu3P4lDDxgkL6cuUt7y07yxG &= ~_iDe3W6qb7jKTPuJV79yf2i7UoIq_0;
			}
		}, delegate(Color color_0)
		{
			action_0(color_0);
			_q9fwz0K4rjUrAm9v3Dn6azqJaIN._0cFb48aKbcbREkHm9Jwptl6r6Vi();
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
			_q9fwz0K4rjUrAm9v3Dn6azqJaIN._0cFb48aKbcbREkHm9Jwptl6r6Vi();
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
				_q9fwz0K4rjUrAm9v3Dn6azqJaIN._0cFb48aKbcbREkHm9Jwptl6r6Vi();
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
			_q9fwz0K4rjUrAm9v3Dn6azqJaIN._0cFb48aKbcbREkHm9Jwptl6r6Vi();
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
			_q9fwz0K4rjUrAm9v3Dn6azqJaIN._0cFb48aKbcbREkHm9Jwptl6r6Vi();
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
		_L7VColD35B3sDgJdUnjTeXGa7pv.Show(base._PnkAlVnMv0SZvRBFexqzE5DF9tp);
		Color _9ycmcfwZ9EbmXanrFe7pEfGAAUi = color_0;
		_fA3AcauqZZ0ncWKv9QA3iklruOI(color_0, out var _kyexzK2VL0y9etRuX79HInHIsIb, out var _46o2iZ9juR1nNURyrP41h9vxpGA, out var _xX4CfdHl6arem4v3fUgbDUIK2gM);
		Texture2D _3PAjrCP0TE07YQ22X6EIpPwOlib = new Texture2D(base._ZzBuoSDMWwerejOO9Goyv2OCKgE._2yepMkVENnecIsduggABaU2qhXW, 250, 250, mipMap: false, SurfaceFormat.Color);
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
		Texture2D texture2D = new Texture2D(base._ZzBuoSDMWwerejOO9Goyv2OCKgE._2yepMkVENnecIsduggABaU2qhXW, 25, 250, mipMap: false, SurfaceFormat.Color);
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
				if (base._ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._WZ4xYI5Q3hoCNX9QFzE3jfDwZBJ(_PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton))
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
				if (base._ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._WZ4xYI5Q3hoCNX9QFzE3jfDwZBJ(_PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton))
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
			if (base._ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(Microsoft.Xna.Framework.Input.Keys.Escape))
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

	[CompilerGenerated]
	private void _PbAre2mvcfhjcz2aGEBHyQxjoABA()
	{
		if (base._ZzBuoSDMWwerejOO9Goyv2OCKgE._KVSwpLj0RvURRswHn7ogRy4BRfd != null)
		{
			base._ZzBuoSDMWwerejOO9Goyv2OCKgE._KVSwpLj0RvURRswHn7ogRy4BRfd._0cFb48aKbcbREkHm9Jwptl6r6Vi();
		}
	}

	[CompilerGenerated]
	private void _ChpMy0SmbTQ1KKcG7mq5rKoRm8E()
	{
		_OBIbaNO8X49ahEZ5n3Ta8HUK7mO(_TbkP67ntBpYJu1M27pBfsYAHmgJ.Content.Controls);
	}

	[CompilerGenerated]
	private void _i9Xj1KSWViEd71ALYa9ApJ2Gc9y()
	{
		_jiNxMIzuA8Rrc2ULsrob5A7UNDe(_TbkP67ntBpYJu1M27pBfsYAHmgJ.Content.Controls);
	}

	[CompilerGenerated]
	private void _3VjzhxKSwnPtdk4XhY3iFmHrG1H()
	{
		_1qIQUjhrbk5WA7C7mYs93gXLOIe(_TbkP67ntBpYJu1M27pBfsYAHmgJ.Content.Controls);
	}

	[CompilerGenerated]
	private void _pKgyzskaeOQ1TRYcUjxy3zMiF5T()
	{
		_VCrdQDifkN8NHlzPICTmtbgWFwp(_TbkP67ntBpYJu1M27pBfsYAHmgJ.Content.Controls);
	}

	[CompilerGenerated]
	private void _VIr0RlSCz9V0frZhjT6BsMYn28U()
	{
		_vXrWU56trsuFNc9CNcHuctfkI2S(_TbkP67ntBpYJu1M27pBfsYAHmgJ.Content.Controls);
	}

	[CompilerGenerated]
	private void _1KOufZWxXAv4lBCHX0VbC5pdIhN()
	{
		_vg6ASaP7xNqc0jerF3mcrXv4dn7(_TbkP67ntBpYJu1M27pBfsYAHmgJ.Content.Controls);
	}

	[CompilerGenerated]
	private void _w91LaUOFTCMT9AffWnTo1PJ3EMr()
	{
		_Xhurp3mVVoR5kNlnxgLoDDkeQxM(_TbkP67ntBpYJu1M27pBfsYAHmgJ.Content.Controls);
	}

	[CompilerGenerated]
	private void _BZPbyIJWfbmS1NEIAww1KgTP1vg()
	{
		_gHA9C0CRN2NaRMtfTrvlotJOd0T(_TbkP67ntBpYJu1M27pBfsYAHmgJ.Content.Controls);
	}

	[CompilerGenerated]
	private void _kgalrc04EwTy7lf17UuFH8tkWJe()
	{
		_hNo7o9fG9jvwcKyMq1nYl4q7cXc(_TbkP67ntBpYJu1M27pBfsYAHmgJ.Content.Controls);
	}

	[CompilerGenerated]
	private void _AkTV7h3XKguAhStEd33YiNZJ7Re()
	{
		_mWS8UuA4xcT1bSdjDObiubOE0wH(_TbkP67ntBpYJu1M27pBfsYAHmgJ.Content.Controls);
	}

	[CompilerGenerated]
	private void _V87FuhPcqj5irT0Wrn5TCo9Ae9B()
	{
		_7JR6eL4D0qdIJNOwfInnlg2HEgZ(_TbkP67ntBpYJu1M27pBfsYAHmgJ.Content.Controls);
	}

	[CompilerGenerated]
	private void _ybtbM3zRgg2shH5mHioQuMHwlaBA()
	{
		_PBEdYyzYEWcXAodjVf58ocOQ3Jf(_TbkP67ntBpYJu1M27pBfsYAHmgJ.Content.Controls);
	}

	[CompilerGenerated]
	private void _dG9yFv0qkL01EP97OGwo3r3q2IC(int int_0)
	{
		if (int_0 == 1)
		{
			base._ZzBuoSDMWwerejOO9Goyv2OCKgE._k9wUPeU1Ga7cygiuGP8TT6aPLWF<MainMenuScene>();
		}
	}

	[CompilerGenerated]
	private void _6SSzSJCWnTXdgyuAx7FQHIaqTOq(_opIJo2jLUqdOL5yAFP4yzXce0DG.EBodyType ebodyType_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._8CtoV1bqn0CwCzb1tuoNppBt0Gg = ebodyType_0;
	}

	[CompilerGenerated]
	private void _BCxgLiZMu3SFvsv9YNuAC41jR3E(Color color_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._6f1rvTENt5XWmHTE22zxBIwbH9G = color_0;
	}

	[CompilerGenerated]
	private void _cgQk2a8YpQxbltiCp0ND31sel1AA(Color color_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._PeK36AvFxEQCvX3fS62hNV7rpuJ = color_0;
	}

	[CompilerGenerated]
	private void _GqZTDO1N9LdbZBpsbC4MlEJe6U7(Color color_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._zBv1cYqPRU7uDCALpBlBSgObUcbA = color_0;
	}

	[CompilerGenerated]
	private void _VuvgAhyavuApBE7oChue41hK7PB(Color color_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._TxfCqloeyiHpsXka6B46iqCZNsZ = color_0;
	}

	[CompilerGenerated]
	private void _2nwMujcCGDhZ6jVHiUjmqtZi7qb(bool bool_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._VmNLhqrIwSnE6JnCYiBcxnSqnEV = bool_0;
	}

	[CompilerGenerated]
	private void _DXkhLYrH891ME3qfEK0CMmYUTfO(Color color_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._in5HHYmrdLTFpkgc8aimJpXqAXB = color_0;
	}

	[CompilerGenerated]
	private void _E2lBd1QEjBj0REiMHNqMwMsx4wr(Color color_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._1ZKGQXLRAHEJR8v7jhlDsyOVLcz = color_0;
	}

	[CompilerGenerated]
	private void _ofZZDYP56EomSmzWRc6x3CWW6Wb(Color color_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._8rDSn6e9Ip9WdOogjhIn8YlL1oM = color_0;
	}

	[CompilerGenerated]
	private void _I7brQQRUAHsa7dWHr3Y85NUX8Mh(Color color_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._FrsyMDX7TebzFk8nSLTyRDPi1QH = color_0;
	}

	[CompilerGenerated]
	private void _lITvn0PjmR9QBbQsWGhjawYbGvg(Color color_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._cUtgkG5qDvgFmI8c29I9xsLVNON = color_0;
	}

	[CompilerGenerated]
	private void _GnNbyYmrPdLBOTz1TtzPXJy3KJN(Color color_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._LcOPiDaC2j5vzxOEYhvW4vRoaRX = color_0;
	}

	[CompilerGenerated]
	private void _3alfnfUF4KoAk2bzwFTDkAQltQw(Color color_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._meyNS02iTIxo212B6c5eoKns2wj = color_0;
	}

	[CompilerGenerated]
	private void _3vjoq1o2D7lFC6NkENzBUDlofd8(_opIJo2jLUqdOL5yAFP4yzXce0DG.EMuzzleType emuzzleType_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._4QUr9lDqmNxEuy7B4xgb7Lj1HU0 = emuzzleType_0;
	}

	[CompilerGenerated]
	private void _zGgwaozb2TEqIfwm8ZxryWlMp9q(Color color_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._VsEYbNSam3IFYYWY4QC2lb4ia61 = color_0;
	}

	[CompilerGenerated]
	private void _dxIbqa9HjkRksCyotm88DRZfbcf(Color color_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._y1SiMmRVXWDhDtY17knDpitt46F = color_0;
	}

	[CompilerGenerated]
	private void _RsPDhjE4m0UaI7A3gRporMFinGW(Color color_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._T98drEOtEEZKeB5tXzsuPrhb5Xk = color_0;
	}

	[CompilerGenerated]
	private void _exxBpmQvyqAP12CuxH29bfVbC5K(bool bool_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._hkFDGB5pWIuOVcIyDAFqHrDdSpjA = bool_0;
	}

	[CompilerGenerated]
	private void _8cD4YFYMAsKebeAiz8zAOfahIai(Color color_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._q2iDxJYfqribHB1bD8aSkSjqrfnA = color_0;
	}

	[CompilerGenerated]
	private void _DAxyzRAWwyQKTh6D7z7H9f0FxoC(bool bool_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._UAZhvJ3a9BGOBM0CLiDkKLwUFC9 = bool_0;
	}

	[CompilerGenerated]
	private void _MceDXNzBCDQ0dVl46rGK9AZrVNN(Color color_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._phJrpk3rql5MfNJxPQ9X7nC8aAk = color_0;
	}

	[CompilerGenerated]
	private void _srPp1hhBv7UMAODauYz9YxMYY2H(_opIJo2jLUqdOL5yAFP4yzXce0DG.EHeadAccessoriesType eheadAccessoriesType_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._pmr0FnBBvgaggpusBKMWplUa63c = eheadAccessoriesType_0;
	}

	[CompilerGenerated]
	private void _XM16SOVx4UdzPFdeMgIchAIGOsI(Color color_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._9b2asKZDwVM1TcSfmfeFCuk0TJZb = color_0;
	}

	[CompilerGenerated]
	private void _JtLlhMY7INQCnLA7U1TQgbc2UVb(Color color_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._vUhBAXEgvpGKopOUkDJFoc4EYQ3 = color_0;
	}

	[CompilerGenerated]
	private void _gQB9HFUA9OEd3wBEq8bYACMkZNE(Color color_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._uaBF7rEib15d42vH8AzoXWFMMkE = color_0;
	}

	[CompilerGenerated]
	private void _RUmStX3RK6MiX6R7HucoB5XHFhH(_opIJo2jLUqdOL5yAFP4yzXce0DG.EHairstyleType ehairstyleType_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._03h2I0mTkGTzIA5R48rgwJh7JZA = ehairstyleType_0;
	}

	[CompilerGenerated]
	private void _DP16aSw2oeo57fi3Kl3BXui3jtP(Color color_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._bJmvnPs69aVDXxG48lmruYZFHKt = color_0;
	}

	[CompilerGenerated]
	private void _Xm0QEg372QuBvhBXsN0Npj3G2mF(_opIJo2jLUqdOL5yAFP4yzXce0DG.EFringeType efringeType_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._fzMbZCCd7imnrcrYWkSj5u8UZ2J = efringeType_0;
	}

	[CompilerGenerated]
	private void _osQFj7MLIYln62eGi789EJDgcnB(Color color_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._EvdUMrkAAdTeMv6fOpGrOLCAMq8A = color_0;
	}

	[CompilerGenerated]
	private void _oJCDJVfE4fgCelaXBlMtB6KUyMK(_opIJo2jLUqdOL5yAFP4yzXce0DG.EEyesType eeyesType_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._c0ThYURHAGN0Wzlzw9Ibh3Z8qyo = eeyesType_0;
	}

	[CompilerGenerated]
	private void _Ecl5k5tuS0psgn2HXshwzRNbJ1i(Color color_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._GXnDb1oaJlPbAQV2mjAwCQFK0nmb = color_0;
	}

	[CompilerGenerated]
	private void _xVyppYNITOEbySGX3Ysrf7X0CDL(Color color_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._0K4lcN7iwo5q0iP1YlkpY9GdayR = color_0;
	}

	[CompilerGenerated]
	private void _vqM1ysggF3rZBK19cjbWyzhRvKg(_opIJo2jLUqdOL5yAFP4yzXce0DG.EBrowType ebrowType_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._KBOJ0qhM8C5evPQxibgX74m2WHg = ebrowType_0;
	}

	[CompilerGenerated]
	private void _IRfaf09wZiguwTJdhMCwroUNcCj(Color color_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._HRPv5rzDY5zNiP4NADDEGhrzGTe = color_0;
	}

	[CompilerGenerated]
	private void _G4nluPeJiVLppBICzSz1j07idSF(_opIJo2jLUqdOL5yAFP4yzXce0DG.ETailType etailType_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._NrFEKLWh80bQXi9PujCBTqm01AA = etailType_0;
	}

	[CompilerGenerated]
	private void _9DXYnHXBxCCBoKLCbMJWx2jngqN(Color color_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._qsK1J3jktKH3eJ2i8sL1oaxXtLc = color_0;
	}

	[CompilerGenerated]
	private void _ao5AzrWQlWPHYUIvWqzvouixKiK(bool bool_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._PVQfhwHODkR6bzHmfeCK4L8riIG = bool_0;
	}

	[CompilerGenerated]
	private void _HYTGc5xcnUqTuYPyMmFxPv7aQBh(Color color_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._62dl1HYYkor3TZL58k5Y33Tj83 = color_0;
	}

	[CompilerGenerated]
	private void _j0Kpu8UuSH6SLAknxwGr7x8veYB(bool bool_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._tEXwTuSRSq5JaaFE4W8edEHxS9q = bool_0;
	}

	[CompilerGenerated]
	private void _OGc5MERKRwtEk9zuNJ4Ao37pWRf(Color color_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._LufmRsAZrlyDgRKYocQXPzANMaF = color_0;
	}

	[CompilerGenerated]
	private void _yajA48kcW18LP5dOb9MNb4pAxpM(_opIJo2jLUqdOL5yAFP4yzXce0DG.EFeetType efeetType_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._LZ8c6hRMRYKjnlLOPhbZHcWqUGG = efeetType_0;
	}

	[CompilerGenerated]
	private void _M8CYXYkYJmMbvLUn3nNfmpghPCL(Color color_0)
	{
		_3t4w2BwPGr8GQDmJlQU929IFD8f._LZfuQybASevOsCykEWqdvA5GqUF = color_0;
	}
}
