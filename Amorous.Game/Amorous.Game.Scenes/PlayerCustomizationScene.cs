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
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		Window val = new Window();
		((Control)val).set_Dock((DockStyle)3);
		((Control)val).set_Size(new Point(512, 0));
		((Control)val).set_Margin(new Margin(8));
		((Control)val).set_Padding(new Margin(8));
		Window val2 = val;
		Panel val3 = new Panel();
		((Control)val3).set_Dock((DockStyle)5);
		_0jH3FoV36utxuSLivmD6IZNwppA = val3;
		((ActiveList<Control>)(object)val2.get_Controls()).Add((Control)(object)_0jH3FoV36utxuSLivmD6IZNwppA);
		Panel val4 = new Panel();
		((Control)val4).set_Dock((DockStyle)5);
		((Control)val4.get_ClipFrame()).set_Margin(new Margin(8));
		_TbkP67ntBpYJu1M27pBfsYAHmgJ = val4;
		_kG9DrP49ggNdZOvVMMUPjfqdzZ4 = new List<Button>
		{
			_cvldkRXLM8Toadgv6nPx5QH1EES("Fursona", delegate
			{
				_OBIbaNO8X49ahEZ5n3Ta8HUK7mO(_TbkP67ntBpYJu1M27pBfsYAHmgJ.get_Content().get_Controls());
			}),
			_cvldkRXLM8Toadgv6nPx5QH1EES("Body", delegate
			{
				_jiNxMIzuA8Rrc2ULsrob5A7UNDe(_TbkP67ntBpYJu1M27pBfsYAHmgJ.get_Content().get_Controls());
			}),
			_cvldkRXLM8Toadgv6nPx5QH1EES("Arms", delegate
			{
				_1qIQUjhrbk5WA7C7mYs93gXLOIe(_TbkP67ntBpYJu1M27pBfsYAHmgJ.get_Content().get_Controls());
			}),
			_cvldkRXLM8Toadgv6nPx5QH1EES("Legs", delegate
			{
				_VCrdQDifkN8NHlzPICTmtbgWFwp(_TbkP67ntBpYJu1M27pBfsYAHmgJ.get_Content().get_Controls());
			}),
			_cvldkRXLM8Toadgv6nPx5QH1EES("Head", delegate
			{
				_vXrWU56trsuFNc9CNcHuctfkI2S(_TbkP67ntBpYJu1M27pBfsYAHmgJ.get_Content().get_Controls());
			}),
			_cvldkRXLM8Toadgv6nPx5QH1EES("Muzzle", delegate
			{
				_vg6ASaP7xNqc0jerF3mcrXv4dn7(_TbkP67ntBpYJu1M27pBfsYAHmgJ.get_Content().get_Controls());
			}),
			_cvldkRXLM8Toadgv6nPx5QH1EES("Ears and Horns", delegate
			{
				_Xhurp3mVVoR5kNlnxgLoDDkeQxM(_TbkP67ntBpYJu1M27pBfsYAHmgJ.get_Content().get_Controls());
			}),
			_cvldkRXLM8Toadgv6nPx5QH1EES("Hair and Fringes", delegate
			{
				_gHA9C0CRN2NaRMtfTrvlotJOd0T(_TbkP67ntBpYJu1M27pBfsYAHmgJ.get_Content().get_Controls());
			}),
			_cvldkRXLM8Toadgv6nPx5QH1EES("Eyes and Brows", delegate
			{
				_hNo7o9fG9jvwcKyMq1nYl4q7cXc(_TbkP67ntBpYJu1M27pBfsYAHmgJ.get_Content().get_Controls());
			})
		};
		if (!_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
		{
			_kG9DrP49ggNdZOvVMMUPjfqdzZ4.Add(_cvldkRXLM8Toadgv6nPx5QH1EES("Breasts, Cock and Balls", delegate
			{
				_mWS8UuA4xcT1bSdjDObiubOE0wH(_TbkP67ntBpYJu1M27pBfsYAHmgJ.get_Content().get_Controls());
			}));
		}
		_kG9DrP49ggNdZOvVMMUPjfqdzZ4.Add(_cvldkRXLM8Toadgv6nPx5QH1EES("Tail", delegate
		{
			_7JR6eL4D0qdIJNOwfInnlg2HEgZ(_TbkP67ntBpYJu1M27pBfsYAHmgJ.get_Content().get_Controls());
		}));
		_kG9DrP49ggNdZOvVMMUPjfqdzZ4.Add(_cvldkRXLM8Toadgv6nPx5QH1EES("Feet", delegate
		{
			_PBEdYyzYEWcXAodjVf58ocOQ3Jf(_TbkP67ntBpYJu1M27pBfsYAHmgJ.get_Content().get_Controls());
		}));
		val2.Show(base._PnkAlVnMv0SZvRBFexqzE5DF9tp);
		((Control)_kG9DrP49ggNdZOvVMMUPjfqdzZ4[0]).Click(0);
	}

	private void _OBIbaNO8X49ahEZ5n3Ta8HUK7mO(ControlCollection controlCollection_0)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected O, but got Unknown
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected O, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected O, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected O, but got Unknown
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected O, but got Unknown
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected O, but got Unknown
		ControlCollection obj = controlCollection_0;
		Label val = new Label();
		((Control)val).set_Dock((DockStyle)2);
		val.set_Text("Name");
		((ActiveList<Control>)(object)obj).Add((Control)val);
		TextBox val2 = new TextBox();
		((Control)val2).set_Dock((DockStyle)2);
		val2.set_Text(_3t4w2BwPGr8GQDmJlQU929IFD8f._RB8fRXeQvK5vs7JEA0XfVCEpg1i);
		((Control)val2).set_Margin(new Margin(0, 0, 0, 5));
		TextBox _Z0ib1EsNAOHar3w2AfvKgeb8s2BA = val2;
		_Z0ib1EsNAOHar3w2AfvKgeb8s2BA.add_TextChanged((VoidEvent)delegate
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._RB8fRXeQvK5vs7JEA0XfVCEpg1i = _Z0ib1EsNAOHar3w2AfvKgeb8s2BA.get_Text();
		});
		((ActiveList<Control>)(object)controlCollection_0).Add((Control)(object)_Z0ib1EsNAOHar3w2AfvKgeb8s2BA);
		_YemBTJprwfbd3mpg5Gy9uyEJWwI(controlCollection_0, "Stock Templates", _q9fwz0K4rjUrAm9v3Dn6azqJaIN._A088aXIdbVflSYtbl7vA5RjQOjXA.Select((_xJL9E6vKdg1LYZtKQU5RQKikpvE _xJL9E6vKdg1LYZtKQU5RQKikpvE_0) => _xJL9E6vKdg1LYZtKQU5RQKikpvE_0._RB8fRXeQvK5vs7JEA0XfVCEpg1i).ToArray(), _3yqpoxOljKnrj7mGlnrA0eOUMAk, delegate(int int_0)
		{
			_3yqpoxOljKnrj7mGlnrA0eOUMAk = int_0;
			_q9fwz0K4rjUrAm9v3Dn6azqJaIN._BwV21jdCpo4YpIp6x74bJ0H7hut(int_0);
			((ActiveList<Control>)(object)_TbkP67ntBpYJu1M27pBfsYAHmgJ.get_Content().get_Controls()).Clear();
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
			((ActiveList<Control>)(object)_TbkP67ntBpYJu1M27pBfsYAHmgJ.get_Content().get_Controls()).Clear();
			_OBIbaNO8X49ahEZ5n3Ta8HUK7mO(controlCollection_0);
			if (base._ZzBuoSDMWwerejOO9Goyv2OCKgE._KVSwpLj0RvURRswHn7ogRy4BRfd != null)
			{
				base._ZzBuoSDMWwerejOO9Goyv2OCKgE._KVSwpLj0RvURRswHn7ogRy4BRfd._0cFb48aKbcbREkHm9Jwptl6r6Vi();
			}
		});
		Control val3 = _z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Phone", _3t4w2BwPGr8GQDmJlQU929IFD8f._uOkbmfW26QVAvyEMQakki9kTMDbA, delegate(Color color_0)
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._uOkbmfW26QVAvyEMQakki9kTMDbA = color_0;
		});
		val3.set_Margin(new Margin(0, 5, 0, 0));
		Button val4 = new Button();
		((Control)val4).set_Margin(new Margin(0, 10, 0, 0));
		((Control)val4).set_Dock((DockStyle)2);
		((Label)val4).set_Text("New Template");
		Button val5 = val4;
		((Control)val5).add_MouseClick((MouseEvent)delegate
		{
			if (string.IsNullOrWhiteSpace(_Z0ib1EsNAOHar3w2AfvKgeb8s2BA.get_Text()))
			{
				base._PnkAlVnMv0SZvRBFexqzE5DF9tp._0pVU36wp9GYD1jM18raZtVEbA9q("You did not enter a name!", 500);
			}
			else
			{
				_yA2ISabBQiVKBxMt5AXSybmkG5o($"Are you sure you wish to create a new template with the name '{_Z0ib1EsNAOHar3w2AfvKgeb8s2BA.get_Text()}', based on the current character?", delegate
				{
					_q9fwz0K4rjUrAm9v3Dn6azqJaIN._0S3oMrwxDtOTcbzkglSllPfRq53(_Z0ib1EsNAOHar3w2AfvKgeb8s2BA.get_Text(), _3t4w2BwPGr8GQDmJlQU929IFD8f._dxo6sBOpjEUiw2JBMikbutXK44t());
					_QjFuG8JMGq8rGnavgUdgnBEKBfD = _q9fwz0K4rjUrAm9v3Dn6azqJaIN._I6gsCHlb2BKFCJSAk9Cn5fCMAPu.Count() - 1;
					_q9fwz0K4rjUrAm9v3Dn6azqJaIN._BCRMBb9uhQZrQlfdXPidu27yb8C(_QjFuG8JMGq8rGnavgUdgnBEKBfD);
					_3t4w2BwPGr8GQDmJlQU929IFD8f._RB8fRXeQvK5vs7JEA0XfVCEpg1i = _q9fwz0K4rjUrAm9v3Dn6azqJaIN._6qwooGF3jWmbG9887Y5IKZ8fJ0E(_QjFuG8JMGq8rGnavgUdgnBEKBfD);
					((ActiveList<Control>)(object)_TbkP67ntBpYJu1M27pBfsYAHmgJ.get_Content().get_Controls()).Clear();
					_OBIbaNO8X49ahEZ5n3Ta8HUK7mO(controlCollection_0);
				});
			}
		});
		((ActiveList<Control>)(object)controlCollection_0).Add((Control)(object)val5);
		Button val6 = new Button();
		((Control)val6).set_Dock((DockStyle)2);
		((Label)val6).set_Text("Save Template");
		Button val7 = val6;
		((Control)val7).add_MouseClick((MouseEvent)delegate
		{
			if (string.IsNullOrWhiteSpace(_Z0ib1EsNAOHar3w2AfvKgeb8s2BA.get_Text()))
			{
				base._PnkAlVnMv0SZvRBFexqzE5DF9tp._0pVU36wp9GYD1jM18raZtVEbA9q("You did not enter a name!", 500);
			}
			else if (_QjFuG8JMGq8rGnavgUdgnBEKBfD >= 0)
			{
				_yA2ISabBQiVKBxMt5AXSybmkG5o($"Are you sure you wish to save the currect character to the selected template '{_q9fwz0K4rjUrAm9v3Dn6azqJaIN._6qwooGF3jWmbG9887Y5IKZ8fJ0E(_QjFuG8JMGq8rGnavgUdgnBEKBfD)}'?", delegate
				{
					_q9fwz0K4rjUrAm9v3Dn6azqJaIN._WfRAwdaNcmrDEhMe1AHPq7egPcw(_Z0ib1EsNAOHar3w2AfvKgeb8s2BA.get_Text(), _QjFuG8JMGq8rGnavgUdgnBEKBfD, _3t4w2BwPGr8GQDmJlQU929IFD8f._dxo6sBOpjEUiw2JBMikbutXK44t());
					((ActiveList<Control>)(object)_TbkP67ntBpYJu1M27pBfsYAHmgJ.get_Content().get_Controls()).Clear();
					_OBIbaNO8X49ahEZ5n3Ta8HUK7mO(controlCollection_0);
				});
			}
			else
			{
				_yA2ISabBQiVKBxMt5AXSybmkG5o($"No template has been selected yet, do you wish to create a new template with the name '{_Z0ib1EsNAOHar3w2AfvKgeb8s2BA.get_Text()}', based on the current character?", delegate
				{
					_q9fwz0K4rjUrAm9v3Dn6azqJaIN._0S3oMrwxDtOTcbzkglSllPfRq53(_Z0ib1EsNAOHar3w2AfvKgeb8s2BA.get_Text(), _3t4w2BwPGr8GQDmJlQU929IFD8f._dxo6sBOpjEUiw2JBMikbutXK44t());
					_QjFuG8JMGq8rGnavgUdgnBEKBfD = _q9fwz0K4rjUrAm9v3Dn6azqJaIN._I6gsCHlb2BKFCJSAk9Cn5fCMAPu.Count() - 1;
					_q9fwz0K4rjUrAm9v3Dn6azqJaIN._BCRMBb9uhQZrQlfdXPidu27yb8C(_QjFuG8JMGq8rGnavgUdgnBEKBfD);
					_3t4w2BwPGr8GQDmJlQU929IFD8f._RB8fRXeQvK5vs7JEA0XfVCEpg1i = _q9fwz0K4rjUrAm9v3Dn6azqJaIN._6qwooGF3jWmbG9887Y5IKZ8fJ0E(_QjFuG8JMGq8rGnavgUdgnBEKBfD);
					((ActiveList<Control>)(object)_TbkP67ntBpYJu1M27pBfsYAHmgJ.get_Content().get_Controls()).Clear();
					_OBIbaNO8X49ahEZ5n3Ta8HUK7mO(controlCollection_0);
				});
			}
		});
		((ActiveList<Control>)(object)controlCollection_0).Add((Control)(object)val7);
		Button val8 = new Button();
		((Control)val8).set_Dock((DockStyle)2);
		((Label)val8).set_Text("Reset Template");
		Button val9 = val8;
		((Control)val9).add_MouseClick((MouseEvent)delegate
		{
			if (_QjFuG8JMGq8rGnavgUdgnBEKBfD >= 0)
			{
				_yA2ISabBQiVKBxMt5AXSybmkG5o($"Are you sure you wish to reset the current character back to selected template '{_q9fwz0K4rjUrAm9v3Dn6azqJaIN._6qwooGF3jWmbG9887Y5IKZ8fJ0E(_QjFuG8JMGq8rGnavgUdgnBEKBfD)}'? All changes will be lost!", delegate
				{
					_q9fwz0K4rjUrAm9v3Dn6azqJaIN._JC60lfB4LT6VifObN1Ynm6iARlc(_QjFuG8JMGq8rGnavgUdgnBEKBfD);
					_3t4w2BwPGr8GQDmJlQU929IFD8f._RB8fRXeQvK5vs7JEA0XfVCEpg1i = _q9fwz0K4rjUrAm9v3Dn6azqJaIN._6qwooGF3jWmbG9887Y5IKZ8fJ0E(_QjFuG8JMGq8rGnavgUdgnBEKBfD);
					((ActiveList<Control>)(object)_TbkP67ntBpYJu1M27pBfsYAHmgJ.get_Content().get_Controls()).Clear();
					_OBIbaNO8X49ahEZ5n3Ta8HUK7mO(controlCollection_0);
				});
			}
			else
			{
				base._PnkAlVnMv0SZvRBFexqzE5DF9tp._0pVU36wp9GYD1jM18raZtVEbA9q("You did not select a template!", 500);
			}
		});
		((ActiveList<Control>)(object)controlCollection_0).Add((Control)(object)val9);
		Button val10 = new Button();
		((Control)val10).set_Dock((DockStyle)2);
		((Label)val10).set_Text("Delete Template");
		Button val11 = val10;
		((Control)val11).add_MouseClick((MouseEvent)delegate
		{
			if (_QjFuG8JMGq8rGnavgUdgnBEKBfD >= 0)
			{
				_yA2ISabBQiVKBxMt5AXSybmkG5o($"Are you sure you wish to delete the selected template '{_q9fwz0K4rjUrAm9v3Dn6azqJaIN._6qwooGF3jWmbG9887Y5IKZ8fJ0E(_QjFuG8JMGq8rGnavgUdgnBEKBfD)}'?", delegate
				{
					_q9fwz0K4rjUrAm9v3Dn6azqJaIN._FzyCgzYhOXEADaijk8VbcLulpcBA(_QjFuG8JMGq8rGnavgUdgnBEKBfD);
					_QjFuG8JMGq8rGnavgUdgnBEKBfD = -1;
					((ActiveList<Control>)(object)_TbkP67ntBpYJu1M27pBfsYAHmgJ.get_Content().get_Controls()).Clear();
					_OBIbaNO8X49ahEZ5n3Ta8HUK7mO(controlCollection_0);
				});
			}
			else
			{
				base._PnkAlVnMv0SZvRBFexqzE5DF9tp._0pVU36wp9GYD1jM18raZtVEbA9q("You did not select a template!", 500);
			}
		});
		((ActiveList<Control>)(object)controlCollection_0).Add((Control)(object)val11);
		Button val12 = new Button();
		((Control)val12).set_Margin(new Margin(0, 10, 0, 0));
		((Control)val12).set_Dock((DockStyle)2);
		((Label)val12).set_Text("Toggle zoom");
		Button val13 = val12;
		((Control)val13).add_MouseClick((MouseEvent)delegate
		{
			_q9fwz0K4rjUrAm9v3Dn6azqJaIN._BlScjiyHDsZk3jkAZbAbjUxn87sA();
		});
		((ActiveList<Control>)(object)controlCollection_0).Add((Control)(object)val13);
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
		if (!((Dictionary<string, ControlStyle>)(object)base._PnkAlVnMv0SZvRBFexqzE5DF9tp.get_Skin()).ContainsKey("button2"))
		{
			Skin skin = base._PnkAlVnMv0SZvRBFexqzE5DF9tp.get_Skin();
			ControlStyle val14 = new ControlStyle(((Dictionary<string, ControlStyle>)(object)base._PnkAlVnMv0SZvRBFexqzE5DF9tp.get_Skin())["button"]);
			val14.set_Tint(ColorInt.ARGB(1f, 0f, 1f, 0f));
			((Dictionary<string, ControlStyle>)(object)skin).Add("button2", val14);
		}
		Button val15 = new Button();
		((Control)val15).set_Margin(new Margin(0, 10, 0, 0));
		((Control)val15).set_Dock((DockStyle)2);
		((Label)val15).set_Text(Amorous_002EGame_002EScenes_002EPlayerCustomizationScene_002E_l3SUNsFudHnZpYO0ErWgbTaz1DF);
		((Control)val15).set_Style("button2");
		Button val16 = val15;
		((Control)val16).add_MouseClick((MouseEvent)delegate
		{
			if (_jIGpzoYLVPw8SPxmJcha832nCXR && string.IsNullOrWhiteSpace(_Z0ib1EsNAOHar3w2AfvKgeb8s2BA.get_Text()))
			{
				base._PnkAlVnMv0SZvRBFexqzE5DF9tp._0pVU36wp9GYD1jM18raZtVEbA9q("You did not enter a name!", 500);
			}
			else
			{
				_n3b8BstkorCsu4TW0U2YVdFbdGp();
			}
		});
		((ActiveList<Control>)(object)controlCollection_0).Add((Control)(object)val16);
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
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Body", _3t4w2BwPGr8GQDmJlQU929IFD8f._8CtoV1bqn0CwCzb1tuoNppBt0Gg, delegate(_opIJo2jLUqdOL5yAFP4yzXce0DG.EBodyType ebodyType_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._8CtoV1bqn0CwCzb1tuoNppBt0Gg = ebodyType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Body Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._6f1rvTENt5XWmHTE22zxBIwbH9G, delegate(Color color_0)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._6f1rvTENt5XWmHTE22zxBIwbH9G = color_0;
		});
		_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Underbelly Marking", _opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Underbelly, _3t4w2BwPGr8GQDmJlQU929IFD8f._PeK36AvFxEQCvX3fS62hNV7rpuJ, delegate(Color color_0)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._PeK36AvFxEQCvX3fS62hNV7rpuJ = color_0;
		});
		_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Underthigh Marking", _opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Underthigh, _3t4w2BwPGr8GQDmJlQU929IFD8f._zBv1cYqPRU7uDCALpBlBSgObUcbA, delegate(Color color_0)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._zBv1cYqPRU7uDCALpBlBSgObUcbA = color_0;
		});
		_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Stripes Marking", _opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Stripes, _3t4w2BwPGr8GQDmJlQU929IFD8f._TxfCqloeyiHpsXka6B46iqCZNsZ, delegate(Color color_0)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._TxfCqloeyiHpsXka6B46iqCZNsZ = color_0;
		});
		_HdTJZZGoOMNi89T0yAdBraCZMjc(controlCollection_0, "Nails", _3t4w2BwPGr8GQDmJlQU929IFD8f._VmNLhqrIwSnE6JnCYiBcxnSqnEV, _3t4w2BwPGr8GQDmJlQU929IFD8f._in5HHYmrdLTFpkgc8aimJpXqAXB, delegate(bool bool_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._VmNLhqrIwSnE6JnCYiBcxnSqnEV = bool_0;
		}, delegate(Color color_0)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._in5HHYmrdLTFpkgc8aimJpXqAXB = color_0;
		});
	}

	private void _1qIQUjhrbk5WA7C7mYs93gXLOIe(ControlCollection controlCollection_0)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Long Forearm Marking", _opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.LongForearm, _3t4w2BwPGr8GQDmJlQU929IFD8f._1ZKGQXLRAHEJR8v7jhlDsyOVLcz, delegate(Color color_0)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._1ZKGQXLRAHEJR8v7jhlDsyOVLcz = color_0;
		});
		_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Short Forearm Marking", _opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.ShortForearm, _3t4w2BwPGr8GQDmJlQU929IFD8f._8rDSn6e9Ip9WdOogjhIn8YlL1oM, delegate(Color color_0)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._8rDSn6e9Ip9WdOogjhIn8YlL1oM = color_0;
		});
		_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Avian Forearm Marking", _opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.AvianForearm, _3t4w2BwPGr8GQDmJlQU929IFD8f._FrsyMDX7TebzFk8nSLTyRDPi1QH, delegate(Color color_0)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._FrsyMDX7TebzFk8nSLTyRDPi1QH = color_0;
		});
	}

	private void _VCrdQDifkN8NHlzPICTmtbgWFwp(ControlCollection controlCollection_0)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Long Shin Marking", _opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.LongShin, _3t4w2BwPGr8GQDmJlQU929IFD8f._cUtgkG5qDvgFmI8c29I9xsLVNON, delegate(Color color_0)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._cUtgkG5qDvgFmI8c29I9xsLVNON = color_0;
		});
		_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Short Shin Marking", _opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.ShortShin, _3t4w2BwPGr8GQDmJlQU929IFD8f._LcOPiDaC2j5vzxOEYhvW4vRoaRX, delegate(Color color_0)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._LcOPiDaC2j5vzxOEYhvW4vRoaRX = color_0;
		});
		_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Avian Shin Marking", _opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.AvianShin, _3t4w2BwPGr8GQDmJlQU929IFD8f._meyNS02iTIxo212B6c5eoKns2wj, delegate(Color color_0)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._meyNS02iTIxo212B6c5eoKns2wj = color_0;
		});
	}

	private void _vXrWU56trsuFNc9CNcHuctfkI2S(ControlCollection controlCollection_0)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		Panel val = new Panel();
		((Control)val).set_Dock((DockStyle)5);
		((Control)val).set_Visible(_3t4w2BwPGr8GQDmJlQU929IFD8f._UjtZovBCLAtBZnUfbTvRFsaf5mx == _opIJo2jLUqdOL5yAFP4yzXce0DG.EHeadType.Default);
		Panel _5DnedRtrhRxc4WXg7XVOkddr43f = val;
		Panel val2 = new Panel();
		((Control)val2).set_Dock((DockStyle)5);
		((Control)val2).set_Visible(_3t4w2BwPGr8GQDmJlQU929IFD8f._UjtZovBCLAtBZnUfbTvRFsaf5mx == _opIJo2jLUqdOL5yAFP4yzXce0DG.EHeadType.PaperBag);
		Panel _KH5vstJZR49J3eWlwNclJbU5SDe = val2;
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Head", _3t4w2BwPGr8GQDmJlQU929IFD8f._UjtZovBCLAtBZnUfbTvRFsaf5mx, delegate(_opIJo2jLUqdOL5yAFP4yzXce0DG.EHeadType eheadType_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._UjtZovBCLAtBZnUfbTvRFsaf5mx = eheadType_0;
			switch (eheadType_0)
			{
			case _opIJo2jLUqdOL5yAFP4yzXce0DG.EHeadType.Default:
				((Control)_5DnedRtrhRxc4WXg7XVOkddr43f).set_Visible(true);
				((Control)_KH5vstJZR49J3eWlwNclJbU5SDe).set_Visible(false);
				break;
			case _opIJo2jLUqdOL5yAFP4yzXce0DG.EHeadType.Humanoid:
				((Control)_5DnedRtrhRxc4WXg7XVOkddr43f).set_Visible(false);
				((Control)_KH5vstJZR49J3eWlwNclJbU5SDe).set_Visible(false);
				break;
			case _opIJo2jLUqdOL5yAFP4yzXce0DG.EHeadType.PaperBag:
				((Control)_5DnedRtrhRxc4WXg7XVOkddr43f).set_Visible(false);
				((Control)_KH5vstJZR49J3eWlwNclJbU5SDe).set_Visible(true);
				break;
			}
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Head Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._1qfGl3Oc2JyQEpnQtdOxMeMkqhi, delegate(Color color_0)
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._1qfGl3Oc2JyQEpnQtdOxMeMkqhi = color_0;
		});
		_h7MUbT306Ju5xwvamN8SatTR2Mo(_5DnedRtrhRxc4WXg7XVOkddr43f.get_Content().get_Controls(), "Gaunt Marking", _opIJo2jLUqdOL5yAFP4yzXce0DG._iDe3W6qb7jKTPuJV79yf2i7UoIq.Gaunt, _3t4w2BwPGr8GQDmJlQU929IFD8f._Fn7Kt1UvxcXOmJ1gIeWdJnRbaQt, delegate(Color color_0)
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._Fn7Kt1UvxcXOmJ1gIeWdJnRbaQt = color_0;
		});
		_h7MUbT306Ju5xwvamN8SatTR2Mo(_5DnedRtrhRxc4WXg7XVOkddr43f.get_Content().get_Controls(), "Scruffy Marking", _opIJo2jLUqdOL5yAFP4yzXce0DG._iDe3W6qb7jKTPuJV79yf2i7UoIq.Scruffy, _3t4w2BwPGr8GQDmJlQU929IFD8f._WvoLJ4MA4gYEsgOmmIQvfK3xFlu, delegate(Color color_0)
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._WvoLJ4MA4gYEsgOmmIQvfK3xFlu = color_0;
		});
		_h7MUbT306Ju5xwvamN8SatTR2Mo(_5DnedRtrhRxc4WXg7XVOkddr43f.get_Content().get_Controls(), "Snout Marking", _opIJo2jLUqdOL5yAFP4yzXce0DG._iDe3W6qb7jKTPuJV79yf2i7UoIq.Snout, _3t4w2BwPGr8GQDmJlQU929IFD8f._lUyqwDvFCoXEZ6VM9PVCQ970jps, delegate(Color color_0)
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._lUyqwDvFCoXEZ6VM9PVCQ970jps = color_0;
		});
		_h7MUbT306Ju5xwvamN8SatTR2Mo(_5DnedRtrhRxc4WXg7XVOkddr43f.get_Content().get_Controls(), "Stripes Marking", _opIJo2jLUqdOL5yAFP4yzXce0DG._iDe3W6qb7jKTPuJV79yf2i7UoIq.Stripes, _3t4w2BwPGr8GQDmJlQU929IFD8f._qKGefHxdjIUD6ObjxrxnLwbBEsh, delegate(Color color_0)
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._qKGefHxdjIUD6ObjxrxnLwbBEsh = color_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(_KH5vstJZR49J3eWlwNclJbU5SDe.get_Content().get_Controls(), "Paper Bag Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._VWdlqWB4z2wNtm197Oiv32QGVbE, delegate(Color color_0)
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._VWdlqWB4z2wNtm197Oiv32QGVbE = color_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(_KH5vstJZR49J3eWlwNclJbU5SDe.get_Content().get_Controls(), "Eyesholes Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._sbSAaAmkhONcFX6f0JtHbVQbEfG, delegate(Color color_0)
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._sbSAaAmkhONcFX6f0JtHbVQbEfG = color_0;
		});
		((ActiveList<Control>)(object)controlCollection_0).Add((Control)(object)_5DnedRtrhRxc4WXg7XVOkddr43f);
		((ActiveList<Control>)(object)controlCollection_0).Add((Control)(object)_KH5vstJZR49J3eWlwNclJbU5SDe);
	}

	private void _vg6ASaP7xNqc0jerF3mcrXv4dn7(ControlCollection controlCollection_0)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Muzzle", _3t4w2BwPGr8GQDmJlQU929IFD8f._4QUr9lDqmNxEuy7B4xgb7Lj1HU0, delegate(_opIJo2jLUqdOL5yAFP4yzXce0DG.EMuzzleType emuzzleType_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._4QUr9lDqmNxEuy7B4xgb7Lj1HU0 = emuzzleType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Muzzle Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._VsEYbNSam3IFYYWY4QC2lb4ia61, delegate(Color color_0)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._VsEYbNSam3IFYYWY4QC2lb4ia61 = color_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Nose Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._y1SiMmRVXWDhDtY17knDpitt46F, delegate(Color color_0)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._y1SiMmRVXWDhDtY17knDpitt46F = color_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Teeth Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._T98drEOtEEZKeB5tXzsuPrhb5Xk, delegate(Color color_0)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._T98drEOtEEZKeB5tXzsuPrhb5Xk = color_0;
		});
		_HdTJZZGoOMNi89T0yAdBraCZMjc(controlCollection_0, "Muzzle Horn", _3t4w2BwPGr8GQDmJlQU929IFD8f._hkFDGB5pWIuOVcIyDAFqHrDdSpjA, _3t4w2BwPGr8GQDmJlQU929IFD8f._q2iDxJYfqribHB1bD8aSkSjqrfnA, delegate(bool bool_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._hkFDGB5pWIuOVcIyDAFqHrDdSpjA = bool_0;
		}, delegate(Color color_0)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._q2iDxJYfqribHB1bD8aSkSjqrfnA = color_0;
		});
		_HdTJZZGoOMNi89T0yAdBraCZMjc(controlCollection_0, "Muzzle Mask", _3t4w2BwPGr8GQDmJlQU929IFD8f._UAZhvJ3a9BGOBM0CLiDkKLwUFC9, _3t4w2BwPGr8GQDmJlQU929IFD8f._phJrpk3rql5MfNJxPQ9X7nC8aAk, delegate(bool bool_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._UAZhvJ3a9BGOBM0CLiDkKLwUFC9 = bool_0;
		}, delegate(Color color_0)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._phJrpk3rql5MfNJxPQ9X7nC8aAk = color_0;
		});
	}

	private void _Xhurp3mVVoR5kNlnxgLoDDkeQxM(ControlCollection controlCollection_0)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Ears and Horns", _3t4w2BwPGr8GQDmJlQU929IFD8f._pmr0FnBBvgaggpusBKMWplUa63c, delegate(_opIJo2jLUqdOL5yAFP4yzXce0DG.EHeadAccessoriesType eheadAccessoriesType_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._pmr0FnBBvgaggpusBKMWplUa63c = eheadAccessoriesType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Horns Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._9b2asKZDwVM1TcSfmfeFCuk0TJZb, delegate(Color color_0)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._9b2asKZDwVM1TcSfmfeFCuk0TJZb = color_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Ear Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._vUhBAXEgvpGKopOUkDJFoc4EYQ3, delegate(Color color_0)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._vUhBAXEgvpGKopOUkDJFoc4EYQ3 = color_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Ear Inner Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._uaBF7rEib15d42vH8AzoXWFMMkE, delegate(Color color_0)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._uaBF7rEib15d42vH8AzoXWFMMkE = color_0;
		});
	}

	private void _gHA9C0CRN2NaRMtfTrvlotJOd0T(ControlCollection controlCollection_0)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Hair", _3t4w2BwPGr8GQDmJlQU929IFD8f._03h2I0mTkGTzIA5R48rgwJh7JZA, delegate(_opIJo2jLUqdOL5yAFP4yzXce0DG.EHairstyleType ehairstyleType_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._03h2I0mTkGTzIA5R48rgwJh7JZA = ehairstyleType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Hair Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._bJmvnPs69aVDXxG48lmruYZFHKt, delegate(Color color_0)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._bJmvnPs69aVDXxG48lmruYZFHKt = color_0;
		});
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Fringe", _3t4w2BwPGr8GQDmJlQU929IFD8f._fzMbZCCd7imnrcrYWkSj5u8UZ2J, delegate(_opIJo2jLUqdOL5yAFP4yzXce0DG.EFringeType efringeType_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._fzMbZCCd7imnrcrYWkSj5u8UZ2J = efringeType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Fringe Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._EvdUMrkAAdTeMv6fOpGrOLCAMq8A, delegate(Color color_0)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._EvdUMrkAAdTeMv6fOpGrOLCAMq8A = color_0;
		});
	}

	private void _hNo7o9fG9jvwcKyMq1nYl4q7cXc(ControlCollection controlCollection_0)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Eyes", _3t4w2BwPGr8GQDmJlQU929IFD8f._c0ThYURHAGN0Wzlzw9Ibh3Z8qyo, delegate(_opIJo2jLUqdOL5yAFP4yzXce0DG.EEyesType eeyesType_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._c0ThYURHAGN0Wzlzw9Ibh3Z8qyo = eeyesType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Eyes Back Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._GXnDb1oaJlPbAQV2mjAwCQFK0nmb, delegate(Color color_0)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._GXnDb1oaJlPbAQV2mjAwCQFK0nmb = color_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Eyes Front Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._0K4lcN7iwo5q0iP1YlkpY9GdayR, delegate(Color color_0)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._0K4lcN7iwo5q0iP1YlkpY9GdayR = color_0;
		});
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Brows", _3t4w2BwPGr8GQDmJlQU929IFD8f._KBOJ0qhM8C5evPQxibgX74m2WHg, delegate(_opIJo2jLUqdOL5yAFP4yzXce0DG.EBrowType ebrowType_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._KBOJ0qhM8C5evPQxibgX74m2WHg = ebrowType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Brows Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._HRPv5rzDY5zNiP4NADDEGhrzGTe, delegate(Color color_0)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._HRPv5rzDY5zNiP4NADDEGhrzGTe = color_0;
		});
	}

	private void _mWS8UuA4xcT1bSdjDObiubOE0wH(ControlCollection controlCollection_0)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		Panel val = new Panel();
		((Control)val).set_Dock((DockStyle)2);
		((Control)val).set_Visible(_3t4w2BwPGr8GQDmJlQU929IFD8f._BCncLn6BIYiBX6NdFByAquBYGpH != _opIJo2jLUqdOL5yAFP4yzXce0DG.EBreastsType.None);
		Panel _63PX0QXRoq6jeUvG5xheRABNwsg = val;
		Panel val2 = new Panel();
		((Control)val2).set_Dock((DockStyle)2);
		((Control)val2).set_Visible(_3t4w2BwPGr8GQDmJlQU929IFD8f._rtyJgfViJdXL2Ela5APpDlk99dI != _opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType.None);
		Panel _TLsIePSD9UbEwlT0HwKiF2xZX87 = val2;
		Panel val3 = new Panel();
		((Control)val3).set_Dock((DockStyle)2);
		((Control)val3).set_Visible(_3t4w2BwPGr8GQDmJlQU929IFD8f._7OCMpsMmozHsAG0GDljMMAlGLJBA != _opIJo2jLUqdOL5yAFP4yzXce0DG.EBallsType.None);
		Panel _s9TeQxnG80yYnmcOHHr4bw9fWCh = val3;
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Breasts", _3t4w2BwPGr8GQDmJlQU929IFD8f._BCncLn6BIYiBX6NdFByAquBYGpH, delegate(_opIJo2jLUqdOL5yAFP4yzXce0DG.EBreastsType ebreastsType_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._BCncLn6BIYiBX6NdFByAquBYGpH = ebreastsType_0;
			((Control)_63PX0QXRoq6jeUvG5xheRABNwsg).set_Visible(_3t4w2BwPGr8GQDmJlQU929IFD8f._BCncLn6BIYiBX6NdFByAquBYGpH != _opIJo2jLUqdOL5yAFP4yzXce0DG.EBreastsType.None);
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(_63PX0QXRoq6jeUvG5xheRABNwsg.get_Content().get_Controls(), "Breasts Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._pigzqi6DgcSToQkL9g7Ns2QrLfp, delegate(Color color_0)
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._pigzqi6DgcSToQkL9g7Ns2QrLfp = color_0;
		});
		_HdTJZZGoOMNi89T0yAdBraCZMjc(_63PX0QXRoq6jeUvG5xheRABNwsg.get_Content().get_Controls(), "Nipples", _3t4w2BwPGr8GQDmJlQU929IFD8f._Q2AbpMWcrhtCW9MLTtT5gwoleu7, _3t4w2BwPGr8GQDmJlQU929IFD8f._2yydfEIrSiLPTti2dT8JXGoIaM3, delegate(bool bool_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._Q2AbpMWcrhtCW9MLTtT5gwoleu7 = bool_0;
		}, delegate(Color color_0)
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._2yydfEIrSiLPTti2dT8JXGoIaM3 = color_0;
		});
		((ActiveList<Control>)(object)controlCollection_0).Add((Control)(object)_63PX0QXRoq6jeUvG5xheRABNwsg);
		Control _Jhlc8lMI1rq07omae9xc6uig5tv = null;
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Cock", _3t4w2BwPGr8GQDmJlQU929IFD8f._rtyJgfViJdXL2Ela5APpDlk99dI, delegate(_opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType ecockType_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._rtyJgfViJdXL2Ela5APpDlk99dI = ecockType_0;
			((Control)_TLsIePSD9UbEwlT0HwKiF2xZX87).set_Visible(_3t4w2BwPGr8GQDmJlQU929IFD8f._rtyJgfViJdXL2Ela5APpDlk99dI != _opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType.None);
			_Jhlc8lMI1rq07omae9xc6uig5tv.set_Visible(_3t4w2BwPGr8GQDmJlQU929IFD8f._rtyJgfViJdXL2Ela5APpDlk99dI == _opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType.Cut || _3t4w2BwPGr8GQDmJlQU929IFD8f._rtyJgfViJdXL2Ela5APpDlk99dI == _opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType.Uncut);
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(_TLsIePSD9UbEwlT0HwKiF2xZX87.get_Content().get_Controls(), "Cock Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._XnNREK59QnV1onFFWfSUaS9WK0E, delegate(Color color_0)
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._XnNREK59QnV1onFFWfSUaS9WK0E = color_0;
		});
		_Jhlc8lMI1rq07omae9xc6uig5tv = _z5npzs7mj5H3zJ1PF64BFNsXBmm(_TLsIePSD9UbEwlT0HwKiF2xZX87.get_Content().get_Controls(), "Cock Tip Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._o6OnmHi5rZIQPHESokp9rTaO1ei, delegate(Color color_0)
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._o6OnmHi5rZIQPHESokp9rTaO1ei = color_0;
		});
		_Jhlc8lMI1rq07omae9xc6uig5tv.set_Visible(_3t4w2BwPGr8GQDmJlQU929IFD8f._rtyJgfViJdXL2Ela5APpDlk99dI == _opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType.Cut || _3t4w2BwPGr8GQDmJlQU929IFD8f._rtyJgfViJdXL2Ela5APpDlk99dI == _opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType.Uncut);
		((ActiveList<Control>)(object)controlCollection_0).Add((Control)(object)_TLsIePSD9UbEwlT0HwKiF2xZX87);
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Balls", _3t4w2BwPGr8GQDmJlQU929IFD8f._7OCMpsMmozHsAG0GDljMMAlGLJBA, delegate(_opIJo2jLUqdOL5yAFP4yzXce0DG.EBallsType eballsType_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._7OCMpsMmozHsAG0GDljMMAlGLJBA = eballsType_0;
			((Control)_s9TeQxnG80yYnmcOHHr4bw9fWCh).set_Visible(_3t4w2BwPGr8GQDmJlQU929IFD8f._7OCMpsMmozHsAG0GDljMMAlGLJBA != _opIJo2jLUqdOL5yAFP4yzXce0DG.EBallsType.None);
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(_s9TeQxnG80yYnmcOHHr4bw9fWCh.get_Content().get_Controls(), "Balls Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._8qQ7XVlyRYW4icBFxPQCJqgueYD, delegate(Color color_0)
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._8qQ7XVlyRYW4icBFxPQCJqgueYD = color_0;
		});
		((ActiveList<Control>)(object)controlCollection_0).Add((Control)(object)_s9TeQxnG80yYnmcOHHr4bw9fWCh);
	}

	private void _7JR6eL4D0qdIJNOwfInnlg2HEgZ(ControlCollection controlCollection_0)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Tail", _3t4w2BwPGr8GQDmJlQU929IFD8f._NrFEKLWh80bQXi9PujCBTqm01AA, delegate(_opIJo2jLUqdOL5yAFP4yzXce0DG.ETailType etailType_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._NrFEKLWh80bQXi9PujCBTqm01AA = etailType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Tail Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._qsK1J3jktKH3eJ2i8sL1oaxXtLc, delegate(Color color_0)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._qsK1J3jktKH3eJ2i8sL1oaxXtLc = color_0;
		});
		_HdTJZZGoOMNi89T0yAdBraCZMjc(controlCollection_0, "Tail Part A", _3t4w2BwPGr8GQDmJlQU929IFD8f._PVQfhwHODkR6bzHmfeCK4L8riIG, _3t4w2BwPGr8GQDmJlQU929IFD8f._62dl1HYYkor3TZL58k5Y33Tj83, delegate(bool bool_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._PVQfhwHODkR6bzHmfeCK4L8riIG = bool_0;
		}, delegate(Color color_0)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._62dl1HYYkor3TZL58k5Y33Tj83 = color_0;
		});
		_HdTJZZGoOMNi89T0yAdBraCZMjc(controlCollection_0, "Tail Part B", _3t4w2BwPGr8GQDmJlQU929IFD8f._tEXwTuSRSq5JaaFE4W8edEHxS9q, _3t4w2BwPGr8GQDmJlQU929IFD8f._LufmRsAZrlyDgRKYocQXPzANMaF, delegate(bool bool_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._tEXwTuSRSq5JaaFE4W8edEHxS9q = bool_0;
		}, delegate(Color color_0)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._LufmRsAZrlyDgRKYocQXPzANMaF = color_0;
		});
	}

	private void _PBEdYyzYEWcXAodjVf58ocOQ3Jf(ControlCollection controlCollection_0)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Feet", _3t4w2BwPGr8GQDmJlQU929IFD8f._LZ8c6hRMRYKjnlLOPhbZHcWqUGG, delegate(_opIJo2jLUqdOL5yAFP4yzXce0DG.EFeetType efeetType_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._LZ8c6hRMRYKjnlLOPhbZHcWqUGG = efeetType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Feet Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._LZfuQybASevOsCykEWqdvA5GqUF, delegate(Color color_0)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._LZfuQybASevOsCykEWqdvA5GqUF = color_0;
		});
	}

	public void _KkwafXXLVg1QfQgqqCAojg2ySyZ(SpriteBatch spriteBatch_0)
	{
		_9jklVVcQQYcyqOYrkPiht2VP0IG.get_Parameters().get_Item("Time").SetValue(_boyt8NIMtKsAGSTcjHeL0WMbFxs._AmIUCcrmrrQiiirja7DoiZSjXuv);
		_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._yuFBJdi7mxrwMFQ57BjLjSq6ESj._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0, _9jklVVcQQYcyqOYrkPiht2VP0IG);
	}

	private void _9x3XvoSKr9dMOykq9pl8AKFzwJ(ControlCollection controlCollection_0, string string_0, _opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U _VzIdKOJ1Gq1YccwwHcwhrVV5V4U_0, Color color_0, Action<Color> action_0)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
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
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			action_0(color_0);
			_q9fwz0K4rjUrAm9v3Dn6azqJaIN._0cFb48aKbcbREkHm9Jwptl6r6Vi();
		});
	}

	private void _h7MUbT306Ju5xwvamN8SatTR2Mo(ControlCollection controlCollection_0, string string_0, _opIJo2jLUqdOL5yAFP4yzXce0DG._iDe3W6qb7jKTPuJV79yf2i7UoIq _iDe3W6qb7jKTPuJV79yf2i7UoIq_0, Color color_0, Action<Color> action_0)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
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
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			action_0(color_0);
			_q9fwz0K4rjUrAm9v3Dn6azqJaIN._0cFb48aKbcbREkHm9Jwptl6r6Vi();
		});
	}

	private void _HdTJZZGoOMNi89T0yAdBraCZMjc(ControlCollection controlCollection_0, string string_0, bool bool_0, Color color_0, Action<bool> action_0, Action<Color> action_1)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		CheckBox val = new CheckBox();
		((Control)val).set_Dock((DockStyle)2);
		val.set_Text(string_0);
		val.set_Checked(bool_0);
		((Control)val).set_Margin(new Margin(0, 0, 0, 5));
		CheckBox _SbG09NUiMRUtR5nySpplBTa1qug = val;
		Control _XXaN99sI8FddBJPpuffIrCZZ49q = _lV0oshnYavLGLHyogGNxv60JpoM(string_0 + " Color", color_0, action_1);
		_XXaN99sI8FddBJPpuffIrCZZ49q.set_Visible(_SbG09NUiMRUtR5nySpplBTa1qug.get_Checked());
		((ActiveList<Control>)(object)controlCollection_0).Add((Control)(object)_SbG09NUiMRUtR5nySpplBTa1qug);
		((ActiveList<Control>)(object)controlCollection_0).Add(_XXaN99sI8FddBJPpuffIrCZZ49q);
		_SbG09NUiMRUtR5nySpplBTa1qug.add_CheckedChanged((VoidEvent)delegate
		{
			_XXaN99sI8FddBJPpuffIrCZZ49q.set_Visible(_SbG09NUiMRUtR5nySpplBTa1qug.get_Checked());
			action_0(_SbG09NUiMRUtR5nySpplBTa1qug.get_Checked());
			_q9fwz0K4rjUrAm9v3Dn6azqJaIN._0cFb48aKbcbREkHm9Jwptl6r6Vi();
		});
	}

	private Control _z5npzs7mj5H3zJ1PF64BFNsXBmm(ControlCollection controlCollection_0, string string_0, Color color_0, Action<Color> action_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		Control val = _lV0oshnYavLGLHyogGNxv60JpoM(string_0, color_0, action_0);
		((ActiveList<Control>)(object)controlCollection_0).Add(val);
		return val;
	}

	private Control _lV0oshnYavLGLHyogGNxv60JpoM(string string_0, Color color_0, Action<Color> action_0)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		Control val = new Control();
		val.set_Dock((DockStyle)2);
		val.set_Margin(new Margin(0, 0, 0, 5));
		Control val2 = val;
		ImageControl val3 = new ImageControl();
		((Control)val3).set_Dock((DockStyle)1);
		((Control)val3).set_Size(new Point(29, 30));
		val3.set_Color(ColorInt.ARGB((int)((Color)(ref color_0)).get_A(), (int)((Color)(ref color_0)).get_R(), (int)((Color)(ref color_0)).get_G(), (int)((Color)(ref color_0)).get_B()));
		ImageControl _UI1mLnvMX5jk5cl6WgxFoVZi1ne = val3;
		Label val4 = new Label();
		((Control)val4).set_Dock((DockStyle)5);
		val4.set_Text(string_0);
		((Control)val4).set_Margin(new Margin(5, 0, 0, 0));
		Label val5 = val4;
		((Control)_UI1mLnvMX5jk5cl6WgxFoVZi1ne).add_MouseClick((MouseEvent)delegate
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			_gaKeabKyjzz2jeJCEYxHW9Gc8CGA(string_0, color_0, delegate(Color color_0)
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				color_0 = color_0;
				_UI1mLnvMX5jk5cl6WgxFoVZi1ne.set_Color(ColorInt.ARGB((int)((Color)(ref color_0)).get_A(), (int)((Color)(ref color_0)).get_R(), (int)((Color)(ref color_0)).get_G(), (int)((Color)(ref color_0)).get_B()));
				action_0(color_0);
				_q9fwz0K4rjUrAm9v3Dn6azqJaIN._0cFb48aKbcbREkHm9Jwptl6r6Vi();
			});
		});
		((ActiveList<Control>)(object)val2.GetElements()).Add((Control)(object)_UI1mLnvMX5jk5cl6WgxFoVZi1ne);
		((ActiveList<Control>)(object)val2.GetElements()).Add((Control)(object)val5);
		return val2;
	}

	private void _WPOv8yATDl2g7nDSf8itt8V399K(Button button_0)
	{
		((ActiveList<Control>)(object)_0jH3FoV36utxuSLivmD6IZNwppA.get_Content().get_Controls()).Clear();
		int num = _kG9DrP49ggNdZOvVMMUPjfqdzZ4.FindIndex((Button button_0) => object.Equals(button_0, button_0));
		for (int i = 0; i <= num; i++)
		{
			((Control)_kG9DrP49ggNdZOvVMMUPjfqdzZ4[i]).set_Dock((DockStyle)2);
			((ActiveList<Control>)(object)_0jH3FoV36utxuSLivmD6IZNwppA.get_Content().get_Controls()).Add((Control)(object)_kG9DrP49ggNdZOvVMMUPjfqdzZ4[i]);
		}
		for (int num2 = _kG9DrP49ggNdZOvVMMUPjfqdzZ4.Count - 1; num2 > num; num2--)
		{
			((Control)_kG9DrP49ggNdZOvVMMUPjfqdzZ4[num2]).set_Dock((DockStyle)4);
			((ActiveList<Control>)(object)_0jH3FoV36utxuSLivmD6IZNwppA.get_Content().get_Controls()).Add((Control)(object)_kG9DrP49ggNdZOvVMMUPjfqdzZ4[num2]);
		}
		((ActiveList<Control>)(object)_0jH3FoV36utxuSLivmD6IZNwppA.get_Content().get_Controls()).Add((Control)(object)_TbkP67ntBpYJu1M27pBfsYAHmgJ);
	}

	private Button _cvldkRXLM8Toadgv6nPx5QH1EES(string string_0, Action action_0)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		Button val = new Button();
		((Control)val).set_Dock((DockStyle)2);
		((Label)val).set_TextAlign((Alignment)4);
		((Label)val).set_Text(string_0);
		((Control)val).set_Style("buttonOpaque");
		Button _u0Xt0uZRA6nEpUColLBccMdwezW = val;
		if (action_0 != null)
		{
			((Control)_u0Xt0uZRA6nEpUColLBccMdwezW).add_MouseClick((MouseEvent)delegate
			{
				((ActiveList<Control>)(object)_TbkP67ntBpYJu1M27pBfsYAHmgJ.get_Content().get_Controls()).Clear();
				_TbkP67ntBpYJu1M27pBfsYAHmgJ.get_VScroll().set_Value(0f);
				_WPOv8yATDl2g7nDSf8itt8V399K(_u0Xt0uZRA6nEpUColLBccMdwezW);
				action_0();
			});
		}
		((ActiveList<Control>)(object)_0jH3FoV36utxuSLivmD6IZNwppA.get_Content().get_Controls()).Add((Control)(object)_u0Xt0uZRA6nEpUColLBccMdwezW);
		return _u0Xt0uZRA6nEpUColLBccMdwezW;
	}

	private void _YemBTJprwfbd3mpg5Gy9uyEJWwI(ControlCollection controlCollection_0, string string_0, string[] string_1, int int_0, Action<int> action_0)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		Label val = new Label();
		val.set_Text(string_0);
		((Control)val).set_Dock((DockStyle)2);
		Label val2 = val;
		DropDownList val3 = new DropDownList();
		((Control)val3).set_Dock((DockStyle)2);
		((Control)val3).set_Style("button");
		((Control)val3.get_Label()).set_Margin(new Margin(10, 0, 0, 0));
		val3.get_Dropdown().set_Resizable(false);
		((Control)val3).set_Margin(new Margin(0, 0, 0, 5));
		DropDownList val4 = val3;
		((Control)val4.get_Listbox().get_Scrollbar().get_ButtonUp()).set_Visible(false);
		((Control)val4.get_Listbox().get_Scrollbar().get_ButtonDown()).set_Visible(false);
		for (int i = 0; i < string_1.Length; i++)
		{
			ActiveList<ListBoxItem> items = val4.get_Items();
			ListBoxItem val5 = new ListBoxItem();
			((Label)val5).set_Text(string_1[i]);
			val5.set_Value((object)i);
			val5.set_Selected(i == int_0);
			((Control)val5).set_Size(new Point(0, 30));
			items.Add(val5);
		}
		val4.add_SelectedItemChanged((SelectedItemChangedEventHandler)delegate(Control control_0, ListBoxItem listBoxItem_0)
		{
			action_0((int)listBoxItem_0.get_Value());
			_q9fwz0K4rjUrAm9v3Dn6azqJaIN._0cFb48aKbcbREkHm9Jwptl6r6Vi();
		});
		((ActiveList<Control>)(object)controlCollection_0).Add((Control)(object)val2);
		((ActiveList<Control>)(object)controlCollection_0).Add((Control)(object)val4);
	}

	private void _bABf372CnRI0x85NIaTEbIUNZ10<T>(ControlCollection controlCollection_0, string string_0, T gparam_0, Action<T> action_0)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		int num = (int)(object)gparam_0;
		Label val = new Label();
		val.set_Text(string_0);
		((Control)val).set_Dock((DockStyle)2);
		Label val2 = val;
		DropDownList val3 = new DropDownList();
		((Control)val3).set_Dock((DockStyle)2);
		((Control)val3).set_Style("button");
		((Control)val3.get_Label()).set_Margin(new Margin(10, 0, 0, 0));
		val3.get_Dropdown().set_Resizable(false);
		((Control)val3).set_Margin(new Margin(0, 0, 0, 5));
		DropDownList val4 = val3;
		((Control)val4.get_Listbox().get_Scrollbar().get_ButtonUp()).set_Visible(false);
		((Control)val4.get_Listbox().get_Scrollbar().get_ButtonDown()).set_Visible(false);
		string[] names = Enum.GetNames(typeof(T));
		Array values = Enum.GetValues(typeof(T));
		for (int i = 0; i < names.Length; i++)
		{
			string text = names[i];
			int num2 = (int)values.GetValue(i);
			ActiveList<ListBoxItem> items = val4.get_Items();
			ListBoxItem val5 = new ListBoxItem();
			((Label)val5).set_Text(text);
			val5.set_Value(values.GetValue(i));
			val5.set_Selected(num2 == num);
			((Control)val5).set_Size(new Point(0, 30));
			items.Add(val5);
		}
		val4.add_SelectedItemChanged((SelectedItemChangedEventHandler)delegate(Control control_0, ListBoxItem listBoxItem_0)
		{
			action_0((T)_003C_003Ec__DisplayClass43_0<T>.smethod_0(listBoxItem_0));
			_q9fwz0K4rjUrAm9v3Dn6azqJaIN._0cFb48aKbcbREkHm9Jwptl6r6Vi();
		});
		((ActiveList<Control>)(object)controlCollection_0).Add((Control)(object)val2);
		((ActiveList<Control>)(object)controlCollection_0).Add((Control)(object)val4);
	}

	private void _gaKeabKyjzz2jeJCEYxHW9Gc8CGA(string string_0, Color color_0, Action<Color> action_0)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected O, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected O, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected O, but got Unknown
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected O, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected O, but got Unknown
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected O, but got Unknown
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected O, but got Unknown
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected O, but got Unknown
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected O, but got Unknown
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected O, but got Unknown
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected O, but got Unknown
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Expected O, but got Unknown
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Expected O, but got Unknown
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Expected O, but got Unknown
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_056e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0575: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Expected O, but got Unknown
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Expected O, but got Unknown
		//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0600: Expected O, but got Unknown
		//IL_0601: Unknown result type (might be due to invalid IL or missing references)
		//IL_0606: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0614: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Expected O, but got Unknown
		//IL_0664: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_0670: Unknown result type (might be due to invalid IL or missing references)
		//IL_067b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0684: Expected O, but got Unknown
		//IL_068d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0697: Expected O, but got Unknown
		//IL_074d: Unknown result type (might be due to invalid IL or missing references)
		//IL_074e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0753: Unknown result type (might be due to invalid IL or missing references)
		//IL_0783: Unknown result type (might be due to invalid IL or missing references)
		//IL_078d: Expected O, but got Unknown
		//IL_07f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_086f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0876: Expected O, but got Unknown
		//IL_08c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0970: Unknown result type (might be due to invalid IL or missing references)
		//IL_097a: Expected O, but got Unknown
		//IL_0987: Unknown result type (might be due to invalid IL or missing references)
		//IL_0991: Expected O, but got Unknown
		//IL_0a3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a49: Expected O, but got Unknown
		if (_hSPLyBveOIKpCKgimgpgcMUDdRz != null)
		{
			_hSPLyBveOIKpCKgimgpgcMUDdRz.Close();
		}
		Window val = new Window();
		((Control)val).set_Dock((DockStyle)3);
		((Control)val).set_AutoSize((AutoSize)3);
		((Control)val).set_Margin(new Margin(8, 8, 0, 8));
		Window _L7VColD35B3sDgJdUnjTeXGa7pv = val;
		_hSPLyBveOIKpCKgimgpgcMUDdRz = _L7VColD35B3sDgJdUnjTeXGa7pv;
		Panel val2 = new Panel();
		((Control)val2).set_Size(new Point(307, 519));
		((Control)val2.get_ClipFrame()).set_Margin(new Margin(16, 8, 16, 16));
		Panel val3 = val2;
		((ActiveList<Control>)(object)_L7VColD35B3sDgJdUnjTeXGa7pv.get_Controls()).Add((Control)(object)val3);
		Label val4 = new Label();
		((Control)val4).set_Dock((DockStyle)2);
		val4.set_Text(string_0);
		val4.set_TextAlign((Alignment)4);
		Label val5 = val4;
		Panel val6 = new Panel();
		((Control)val6).set_Dock((DockStyle)2);
		((Control)val6).set_Size(new Point(275, 250));
		Panel val7 = val6;
		ImageControl val8 = new ImageControl();
		((Control)val8).set_Dock((DockStyle)1);
		val8.set_Texture("ColorPickerBox");
		((Control)val8).set_Size(new Point(250, 250));
		ImageControl _UI1mLnvMX5jk5cl6WgxFoVZi1ne = val8;
		ImageControl val9 = new ImageControl();
		((Control)val9).set_Dock((DockStyle)5);
		val9.set_Texture("ColorPickerSlider");
		((Control)val9).set_Size(new Point(25, 250));
		ImageControl _nTvWggfVqVEF25GV4NOsfpNhR4C = val9;
		((ActiveList<Control>)(object)val7.get_Content().get_Controls()).Add((Control)(object)_UI1mLnvMX5jk5cl6WgxFoVZi1ne);
		((ActiveList<Control>)(object)val7.get_Content().get_Controls()).Add((Control)(object)_nTvWggfVqVEF25GV4NOsfpNhR4C);
		ImageControl val10 = new ImageControl();
		((Control)val10).set_Dock((DockStyle)2);
		((Control)val10).set_Size(new Point(275, 25));
		val10.set_Color(ColorInt.ARGB((int)((Color)(ref color_0)).get_A(), (int)((Color)(ref color_0)).get_R(), (int)((Color)(ref color_0)).get_G(), (int)((Color)(ref color_0)).get_B()));
		((Control)val10).set_Margin(new Margin(0, 0, 0, 8));
		ImageControl _G6zJYvyBSALAHUJm6qCEvtL6WRp = val10;
		Panel val11 = new Panel();
		((Control)val11).set_Dock((DockStyle)2);
		((Control)val11).set_Size(new Point(275, 30));
		((Control)val11).set_Margin(new Margin(0, 0, 0, 8));
		Panel val12 = val11;
		Label val13 = new Label();
		((Control)val13).set_Dock((DockStyle)1);
		val13.set_Text("H:");
		val13.set_TextAlign((Alignment)4);
		((Control)val13).set_Size(new Point(30, 30));
		Label val14 = val13;
		TextBox val15 = new TextBox();
		((Control)val15).set_Dock((DockStyle)1);
		((Control)val15).set_Size(new Point(107, 30));
		((Control)val15).set_TabIndex(1);
		TextBox _8vFoRw3vIHPno8g3WIeCBRRueVP = val15;
		Label val16 = new Label();
		((Control)val16).set_Dock((DockStyle)1);
		val16.set_Text("R:");
		val16.set_TextAlign((Alignment)4);
		((Control)val16).set_Size(new Point(30, 30));
		Label val17 = val16;
		TextBox val18 = new TextBox();
		((Control)val18).set_Dock((DockStyle)5);
		((Control)val18).set_TabIndex(4);
		TextBox _qCKGqUjXlMolAESPmB7a59OrelQ = val18;
		((ActiveList<Control>)(object)val12.get_Content().get_Controls()).Add((Control)(object)val14);
		((ActiveList<Control>)(object)val12.get_Content().get_Controls()).Add((Control)(object)_8vFoRw3vIHPno8g3WIeCBRRueVP);
		((ActiveList<Control>)(object)val12.get_Content().get_Controls()).Add((Control)(object)val17);
		((ActiveList<Control>)(object)val12.get_Content().get_Controls()).Add((Control)(object)_qCKGqUjXlMolAESPmB7a59OrelQ);
		Panel val19 = new Panel();
		((Control)val19).set_Dock((DockStyle)2);
		((Control)val19).set_Size(new Point(275, 30));
		((Control)val19).set_Margin(new Margin(0, 0, 0, 8));
		Panel val20 = val19;
		Label val21 = new Label();
		((Control)val21).set_Dock((DockStyle)1);
		val21.set_Text("S:");
		val21.set_TextAlign((Alignment)4);
		((Control)val21).set_Size(new Point(30, 30));
		Label val22 = val21;
		TextBox val23 = new TextBox();
		((Control)val23).set_Dock((DockStyle)1);
		((Control)val23).set_Size(new Point(107, 30));
		((Control)val23).set_TabIndex(2);
		TextBox _hOIb3XNfIEDsngLrYzmNfLTPVAS = val23;
		Label val24 = new Label();
		((Control)val24).set_Dock((DockStyle)1);
		val24.set_Text("G:");
		val24.set_TextAlign((Alignment)4);
		((Control)val24).set_Size(new Point(30, 30));
		Label val25 = val24;
		TextBox val26 = new TextBox();
		((Control)val26).set_Dock((DockStyle)5);
		((Control)val26).set_TabIndex(5);
		TextBox _ZP3psbb9CVMMjGn5SgszZo0zGpF = val26;
		((ActiveList<Control>)(object)val20.get_Content().get_Controls()).Add((Control)(object)val22);
		((ActiveList<Control>)(object)val20.get_Content().get_Controls()).Add((Control)(object)_hOIb3XNfIEDsngLrYzmNfLTPVAS);
		((ActiveList<Control>)(object)val20.get_Content().get_Controls()).Add((Control)(object)val25);
		((ActiveList<Control>)(object)val20.get_Content().get_Controls()).Add((Control)(object)_ZP3psbb9CVMMjGn5SgszZo0zGpF);
		Panel val27 = new Panel();
		((Control)val27).set_Dock((DockStyle)2);
		((Control)val27).set_Size(new Point(275, 30));
		((Control)val27).set_Margin(new Margin(0, 0, 0, 8));
		Panel val28 = val27;
		Label val29 = new Label();
		((Control)val29).set_Dock((DockStyle)1);
		val29.set_Text("V:");
		val29.set_TextAlign((Alignment)4);
		((Control)val29).set_Size(new Point(30, 30));
		Label val30 = val29;
		TextBox val31 = new TextBox();
		((Control)val31).set_Dock((DockStyle)1);
		((Control)val31).set_Size(new Point(107, 30));
		((Control)val31).set_TabIndex(3);
		TextBox _gY2uTDE0FADy52ltQdJ1AO9nRcf = val31;
		Label val32 = new Label();
		((Control)val32).set_Dock((DockStyle)1);
		val32.set_Text("B:");
		val32.set_TextAlign((Alignment)4);
		((Control)val32).set_Size(new Point(30, 30));
		Label val33 = val32;
		TextBox val34 = new TextBox();
		((Control)val34).set_Dock((DockStyle)5);
		((Control)val34).set_TabIndex(6);
		TextBox _E3KHmDW9haZynE9ZamZBVdveWgk = val34;
		((ActiveList<Control>)(object)val28.get_Content().get_Controls()).Add((Control)(object)val30);
		((ActiveList<Control>)(object)val28.get_Content().get_Controls()).Add((Control)(object)_gY2uTDE0FADy52ltQdJ1AO9nRcf);
		((ActiveList<Control>)(object)val28.get_Content().get_Controls()).Add((Control)(object)val33);
		((ActiveList<Control>)(object)val28.get_Content().get_Controls()).Add((Control)(object)_E3KHmDW9haZynE9ZamZBVdveWgk);
		Panel val35 = new Panel();
		((Control)val35).set_Dock((DockStyle)2);
		((Control)val35).set_Size(new Point(275, 30));
		((Control)val35).set_Margin(new Margin(0, 0, 0, 8));
		Panel val36 = val35;
		Label val37 = new Label();
		((Control)val37).set_Dock((DockStyle)1);
		val37.set_Text("Hex:");
		val37.set_TextAlign((Alignment)4);
		((Control)val37).set_Size(new Point(45, 30));
		Label val38 = val37;
		TextBox val39 = new TextBox();
		((Control)val39).set_Dock((DockStyle)5);
		((Control)val39).set_TabIndex(7);
		TextBox _8lboaaRLcpJoVxfwF1kBCisgrjL = val39;
		((ActiveList<Control>)(object)val36.get_Content().get_Controls()).Add((Control)(object)val38);
		((ActiveList<Control>)(object)val36.get_Content().get_Controls()).Add((Control)(object)_8lboaaRLcpJoVxfwF1kBCisgrjL);
		ImageControl val40 = new ImageControl();
		((Control)val40).set_Size(new Point(6, 6));
		val40.set_Color(ColorInt.ARGB(0.9f, 1f, 1f, 1f));
		ImageControl _OWUGVcx9djtc19hjFfxkac019iL = val40;
		ImageControl val41 = new ImageControl();
		((Control)val41).set_Size(new Point(25, 6));
		val41.set_Color(ColorInt.ARGB(0.9f, 1f, 1f, 1f));
		ImageControl _wbSWz1LplcReMBnbKlnmd0UzxRP = val41;
		((ActiveList<Control>)(object)_L7VColD35B3sDgJdUnjTeXGa7pv.get_Controls()).Add((Control)(object)_OWUGVcx9djtc19hjFfxkac019iL);
		((ActiveList<Control>)(object)_L7VColD35B3sDgJdUnjTeXGa7pv.get_Controls()).Add((Control)(object)_wbSWz1LplcReMBnbKlnmd0UzxRP);
		Button val42 = new Button();
		((Control)val42).set_Dock((DockStyle)5);
		((Label)val42).set_Text("Close");
		((Label)val42).set_TextAlign((Alignment)4);
		Button val43 = val42;
		((Control)val43).add_MouseClick((MouseEvent)delegate
		{
			_hSPLyBveOIKpCKgimgpgcMUDdRz.Close();
		});
		((ActiveList<Control>)(object)val3.get_Content().get_Controls()).Add((Control)(object)val5);
		((ActiveList<Control>)(object)val3.get_Content().get_Controls()).Add((Control)(object)val7);
		((ActiveList<Control>)(object)val3.get_Content().get_Controls()).Add((Control)(object)_G6zJYvyBSALAHUJm6qCEvtL6WRp);
		((ActiveList<Control>)(object)val3.get_Content().get_Controls()).Add((Control)(object)val12);
		((ActiveList<Control>)(object)val3.get_Content().get_Controls()).Add((Control)(object)val20);
		((ActiveList<Control>)(object)val3.get_Content().get_Controls()).Add((Control)(object)val28);
		((ActiveList<Control>)(object)val3.get_Content().get_Controls()).Add((Control)(object)val36);
		((ActiveList<Control>)(object)val3.get_Content().get_Controls()).Add((Control)(object)val36);
		((ActiveList<Control>)(object)val3.get_Content().get_Controls()).Add((Control)(object)val43);
		_L7VColD35B3sDgJdUnjTeXGa7pv.Show(base._PnkAlVnMv0SZvRBFexqzE5DF9tp);
		Color _9ycmcfwZ9EbmXanrFe7pEfGAAUi = color_0;
		_fA3AcauqZZ0ncWKv9QA3iklruOI(color_0, out var _kyexzK2VL0y9etRuX79HInHIsIb, out var _46o2iZ9juR1nNURyrP41h9vxpGA, out var _xX4CfdHl6arem4v3fUgbDUIK2gM);
		Texture2D _3PAjrCP0TE07YQ22X6EIpPwOlib = new Texture2D(base._ZzBuoSDMWwerejOO9Goyv2OCKgE._2yepMkVENnecIsduggABaU2qhXW, 250, 250, false, (SurfaceFormat)0);
		int[] _Vo3fFvvroxYzfCOI5F4PqiMr0Gb = new int[_3PAjrCP0TE07YQ22X6EIpPwOlib.get_Width() * _3PAjrCP0TE07YQ22X6EIpPwOlib.get_Height()];
		for (int i = 0; i < _3PAjrCP0TE07YQ22X6EIpPwOlib.get_Height(); i++)
		{
			for (int j = 0; j < _3PAjrCP0TE07YQ22X6EIpPwOlib.get_Width(); j++)
			{
				Color val44 = _lAdyiyyWQrRKWYduTPacHqdzOmj(_kyexzK2VL0y9etRuX79HInHIsIb, (float)j / (float)_3PAjrCP0TE07YQ22X6EIpPwOlib.get_Width(), ((float)_3PAjrCP0TE07YQ22X6EIpPwOlib.get_Height() - (float)i) / (float)_3PAjrCP0TE07YQ22X6EIpPwOlib.get_Height(), 1f);
				_Vo3fFvvroxYzfCOI5F4PqiMr0Gb[i * _3PAjrCP0TE07YQ22X6EIpPwOlib.get_Width() + j] = (int)((Color)(ref val44)).get_PackedValue();
			}
		}
		_3PAjrCP0TE07YQ22X6EIpPwOlib.SetData<int>(_Vo3fFvvroxYzfCOI5F4PqiMr0Gb);
		Texture2D val45 = new Texture2D(base._ZzBuoSDMWwerejOO9Goyv2OCKgE._2yepMkVENnecIsduggABaU2qhXW, 25, 250, false, (SurfaceFormat)0);
		int[] array = new int[val45.get_Width() * val45.get_Height()];
		for (int k = 0; k < val45.get_Height(); k++)
		{
			Color val46 = _lAdyiyyWQrRKWYduTPacHqdzOmj(((float)val45.get_Height() - (float)k) / (float)val45.get_Height() * 360f, 1.0, 1.0, 1f);
			for (int l = 0; l < val45.get_Width(); l++)
			{
				array[k * val45.get_Width() + l] = (int)((Color)(ref val46)).get_PackedValue();
			}
		}
		val45.SetData<int>(array);
		Gui.get_Renderer().SetTexture("ColorPickerBox", (object)_3PAjrCP0TE07YQ22X6EIpPwOlib);
		Gui.get_Renderer().SetTexture("ColorPickerSlider", (object)val45);
		Action _XDKgJpkUD4lIN2K7ysMOtqO5gMA = delegate
		{
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			((Control)_OWUGVcx9djtc19hjFfxkac019iL).set_Position(new Point(13 + (int)(_46o2iZ9juR1nNURyrP41h9vxpGA * 250f), 35 + (int)(250f - _xX4CfdHl6arem4v3fUgbDUIK2gM * 250f)));
			((Control)_wbSWz1LplcReMBnbKlnmd0UzxRP).set_Position(new Point(266, 35 + (int)(250f - 250f * (_kyexzK2VL0y9etRuX79HInHIsIb / 360f))));
			_G6zJYvyBSALAHUJm6qCEvtL6WRp.set_Color(ColorInt.ARGB((int)((Color)(ref _9ycmcfwZ9EbmXanrFe7pEfGAAUi)).get_A(), (int)((Color)(ref _9ycmcfwZ9EbmXanrFe7pEfGAAUi)).get_R(), (int)((Color)(ref _9ycmcfwZ9EbmXanrFe7pEfGAAUi)).get_G(), (int)((Color)(ref _9ycmcfwZ9EbmXanrFe7pEfGAAUi)).get_B()));
			_8vFoRw3vIHPno8g3WIeCBRRueVP.set_Text(((int)_kyexzK2VL0y9etRuX79HInHIsIb).ToString());
			_hOIb3XNfIEDsngLrYzmNfLTPVAS.set_Text(((int)(_46o2iZ9juR1nNURyrP41h9vxpGA * 100f)).ToString());
			_gY2uTDE0FADy52ltQdJ1AO9nRcf.set_Text(((int)(_xX4CfdHl6arem4v3fUgbDUIK2gM * 100f)).ToString());
			_qCKGqUjXlMolAESPmB7a59OrelQ.set_Text(((Color)(ref _9ycmcfwZ9EbmXanrFe7pEfGAAUi)).get_R().ToString());
			_ZP3psbb9CVMMjGn5SgszZo0zGpF.set_Text(((Color)(ref _9ycmcfwZ9EbmXanrFe7pEfGAAUi)).get_G().ToString());
			_E3KHmDW9haZynE9ZamZBVdveWgk.set_Text(((Color)(ref _9ycmcfwZ9EbmXanrFe7pEfGAAUi)).get_B().ToString());
			_8lboaaRLcpJoVxfwF1kBCisgrjL.set_Text($"#{((Color)(ref _9ycmcfwZ9EbmXanrFe7pEfGAAUi)).get_R():X2}{((Color)(ref _9ycmcfwZ9EbmXanrFe7pEfGAAUi)).get_G():X2}{((Color)(ref _9ycmcfwZ9EbmXanrFe7pEfGAAUi)).get_B():X2}");
		};
		_XDKgJpkUD4lIN2K7ysMOtqO5gMA();
		bool _a7vdsaGCzLloXi7sntZm1rCdbZK = false;
		bool _FxCuMzbCIAsYKlL8DmmchjsMpir = false;
		((Control)_UI1mLnvMX5jk5cl6WgxFoVZi1ne).add_Update((VoidEvent)delegate
		{
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			//IL_0191: Unknown result type (might be due to invalid IL or missing references)
			//IL_0196: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
			if (!_FxCuMzbCIAsYKlL8DmmchjsMpir)
			{
				if (base._ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._WZ4xYI5Q3hoCNX9QFzE3jfDwZBJ(_PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton))
				{
					if (!_a7vdsaGCzLloXi7sntZm1rCdbZK)
					{
						Point val50 = Gui.get_MousePosition();
						int x4 = ((Point)(ref val50)).get_x();
						val50 = ((Control)_UI1mLnvMX5jk5cl6WgxFoVZi1ne).get_Location();
						if (x4 >= ((Point)(ref val50)).get_x())
						{
							val50 = Gui.get_MousePosition();
							int x5 = ((Point)(ref val50)).get_x();
							val50 = ((Control)_UI1mLnvMX5jk5cl6WgxFoVZi1ne).get_Location();
							int x6 = ((Point)(ref val50)).get_x();
							val50 = ((Control)_UI1mLnvMX5jk5cl6WgxFoVZi1ne).get_Size();
							if (x5 <= x6 + ((Point)(ref val50)).get_x())
							{
								val50 = Gui.get_MousePosition();
								int y4 = ((Point)(ref val50)).get_y();
								val50 = ((Control)_UI1mLnvMX5jk5cl6WgxFoVZi1ne).get_Location();
								if (y4 >= ((Point)(ref val50)).get_y())
								{
									val50 = Gui.get_MousePosition();
									int y5 = ((Point)(ref val50)).get_y();
									val50 = ((Control)_UI1mLnvMX5jk5cl6WgxFoVZi1ne).get_Location();
									int y6 = ((Point)(ref val50)).get_y();
									val50 = ((Control)_UI1mLnvMX5jk5cl6WgxFoVZi1ne).get_Size();
									if (y5 <= y6 + ((Point)(ref val50)).get_y())
									{
										_a7vdsaGCzLloXi7sntZm1rCdbZK = true;
									}
								}
							}
						}
					}
					if (_a7vdsaGCzLloXi7sntZm1rCdbZK)
					{
						Point val51 = Gui.get_MousePosition() - ((Control)_UI1mLnvMX5jk5cl6WgxFoVZi1ne).get_Location();
						((Point)(ref val51)).set_x((int)MathHelper.Clamp((float)((Point)(ref val51)).get_x(), 0f, 250f));
						((Point)(ref val51)).set_y((int)MathHelper.Clamp((float)((Point)(ref val51)).get_y(), 0f, 250f));
						_46o2iZ9juR1nNURyrP41h9vxpGA = (float)((Point)(ref val51)).get_x() / 250f;
						_xX4CfdHl6arem4v3fUgbDUIK2gM = (250f - (float)((Point)(ref val51)).get_y()) / 250f;
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
		});
		((Control)_nTvWggfVqVEF25GV4NOsfpNhR4C).add_Update((VoidEvent)delegate
		{
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0201: Unknown result type (might be due to invalid IL or missing references)
			//IL_0206: Unknown result type (might be due to invalid IL or missing references)
			//IL_021d: Unknown result type (might be due to invalid IL or missing references)
			if (!_a7vdsaGCzLloXi7sntZm1rCdbZK)
			{
				if (base._ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._WZ4xYI5Q3hoCNX9QFzE3jfDwZBJ(_PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton))
				{
					if (!_FxCuMzbCIAsYKlL8DmmchjsMpir)
					{
						Point val47 = Gui.get_MousePosition();
						int x = ((Point)(ref val47)).get_x();
						val47 = ((Control)_nTvWggfVqVEF25GV4NOsfpNhR4C).get_Location();
						if (x >= ((Point)(ref val47)).get_x())
						{
							val47 = Gui.get_MousePosition();
							int x2 = ((Point)(ref val47)).get_x();
							val47 = ((Control)_nTvWggfVqVEF25GV4NOsfpNhR4C).get_Location();
							int x3 = ((Point)(ref val47)).get_x();
							val47 = ((Control)_nTvWggfVqVEF25GV4NOsfpNhR4C).get_Size();
							if (x2 <= x3 + ((Point)(ref val47)).get_x())
							{
								val47 = Gui.get_MousePosition();
								int y = ((Point)(ref val47)).get_y();
								val47 = ((Control)_nTvWggfVqVEF25GV4NOsfpNhR4C).get_Location();
								if (y >= ((Point)(ref val47)).get_y())
								{
									val47 = Gui.get_MousePosition();
									int y2 = ((Point)(ref val47)).get_y();
									val47 = ((Control)_nTvWggfVqVEF25GV4NOsfpNhR4C).get_Location();
									int y3 = ((Point)(ref val47)).get_y();
									val47 = ((Control)_nTvWggfVqVEF25GV4NOsfpNhR4C).get_Size();
									if (y2 <= y3 + ((Point)(ref val47)).get_y())
									{
										_FxCuMzbCIAsYKlL8DmmchjsMpir = true;
									}
								}
							}
						}
					}
					if (_FxCuMzbCIAsYKlL8DmmchjsMpir)
					{
						Point val48 = Gui.get_MousePosition() - ((Control)_nTvWggfVqVEF25GV4NOsfpNhR4C).get_Location();
						((Point)(ref val48)).set_y((int)MathHelper.Clamp((float)((Point)(ref val48)).get_y(), 0f, 250f));
						_kyexzK2VL0y9etRuX79HInHIsIb = 360f - (float)((Point)(ref val48)).get_y() / 250f * 360f;
						for (int m = 0; m < _3PAjrCP0TE07YQ22X6EIpPwOlib.get_Height(); m++)
						{
							for (int n = 0; n < _3PAjrCP0TE07YQ22X6EIpPwOlib.get_Width(); n++)
							{
								Color val49 = _lAdyiyyWQrRKWYduTPacHqdzOmj(_kyexzK2VL0y9etRuX79HInHIsIb, (float)n / (float)_3PAjrCP0TE07YQ22X6EIpPwOlib.get_Width(), ((float)_3PAjrCP0TE07YQ22X6EIpPwOlib.get_Height() - (float)m) / (float)_3PAjrCP0TE07YQ22X6EIpPwOlib.get_Height(), 1f);
								_Vo3fFvvroxYzfCOI5F4PqiMr0Gb[m * _3PAjrCP0TE07YQ22X6EIpPwOlib.get_Width() + n] = (int)((Color)(ref val49)).get_PackedValue();
							}
						}
						_3PAjrCP0TE07YQ22X6EIpPwOlib.SetData<int>(_Vo3fFvvroxYzfCOI5F4PqiMr0Gb);
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
		});
		_8vFoRw3vIHPno8g3WIeCBRRueVP.add_TextCommit((EventHandler)delegate
		{
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			if (int.TryParse(_8vFoRw3vIHPno8g3WIeCBRRueVP.get_Text(), out var result6))
			{
				_kyexzK2VL0y9etRuX79HInHIsIb = Math.Max(0, Math.Min(result6, 360));
				_9ycmcfwZ9EbmXanrFe7pEfGAAUi = _lAdyiyyWQrRKWYduTPacHqdzOmj(_kyexzK2VL0y9etRuX79HInHIsIb, _46o2iZ9juR1nNURyrP41h9vxpGA, _xX4CfdHl6arem4v3fUgbDUIK2gM, 1f);
				action_0(_9ycmcfwZ9EbmXanrFe7pEfGAAUi);
			}
			_XDKgJpkUD4lIN2K7ysMOtqO5gMA();
		});
		_hOIb3XNfIEDsngLrYzmNfLTPVAS.add_TextCommit((EventHandler)delegate
		{
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			if (int.TryParse(_hOIb3XNfIEDsngLrYzmNfLTPVAS.get_Text(), out var result5))
			{
				_46o2iZ9juR1nNURyrP41h9vxpGA = (float)Math.Max(0, Math.Min(result5, 100)) / 100f;
				_9ycmcfwZ9EbmXanrFe7pEfGAAUi = _lAdyiyyWQrRKWYduTPacHqdzOmj(_kyexzK2VL0y9etRuX79HInHIsIb, _46o2iZ9juR1nNURyrP41h9vxpGA, _xX4CfdHl6arem4v3fUgbDUIK2gM, 1f);
				action_0(_9ycmcfwZ9EbmXanrFe7pEfGAAUi);
			}
			_XDKgJpkUD4lIN2K7ysMOtqO5gMA();
		});
		_gY2uTDE0FADy52ltQdJ1AO9nRcf.add_TextCommit((EventHandler)delegate
		{
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			if (int.TryParse(_gY2uTDE0FADy52ltQdJ1AO9nRcf.get_Text(), out var result4))
			{
				_xX4CfdHl6arem4v3fUgbDUIK2gM = (float)Math.Max(0, Math.Min(result4, 100)) / 100f;
				_9ycmcfwZ9EbmXanrFe7pEfGAAUi = _lAdyiyyWQrRKWYduTPacHqdzOmj(_kyexzK2VL0y9etRuX79HInHIsIb, _46o2iZ9juR1nNURyrP41h9vxpGA, _xX4CfdHl6arem4v3fUgbDUIK2gM, 1f);
				action_0(_9ycmcfwZ9EbmXanrFe7pEfGAAUi);
			}
			_XDKgJpkUD4lIN2K7ysMOtqO5gMA();
		});
		_qCKGqUjXlMolAESPmB7a59OrelQ.add_TextCommit((EventHandler)delegate
		{
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			if (int.TryParse(_qCKGqUjXlMolAESPmB7a59OrelQ.get_Text(), out var result3))
			{
				((Color)(ref _9ycmcfwZ9EbmXanrFe7pEfGAAUi)).set_R((byte)Math.Max(0, Math.Min(result3, 255)));
				_fA3AcauqZZ0ncWKv9QA3iklruOI(_9ycmcfwZ9EbmXanrFe7pEfGAAUi, out _kyexzK2VL0y9etRuX79HInHIsIb, out _46o2iZ9juR1nNURyrP41h9vxpGA, out _xX4CfdHl6arem4v3fUgbDUIK2gM);
				action_0(_9ycmcfwZ9EbmXanrFe7pEfGAAUi);
			}
			_XDKgJpkUD4lIN2K7ysMOtqO5gMA();
		});
		_ZP3psbb9CVMMjGn5SgszZo0zGpF.add_TextCommit((EventHandler)delegate
		{
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			if (int.TryParse(_ZP3psbb9CVMMjGn5SgszZo0zGpF.get_Text(), out var result2))
			{
				((Color)(ref _9ycmcfwZ9EbmXanrFe7pEfGAAUi)).set_G((byte)Math.Max(0, Math.Min(result2, 255)));
				_fA3AcauqZZ0ncWKv9QA3iklruOI(_9ycmcfwZ9EbmXanrFe7pEfGAAUi, out _kyexzK2VL0y9etRuX79HInHIsIb, out _46o2iZ9juR1nNURyrP41h9vxpGA, out _xX4CfdHl6arem4v3fUgbDUIK2gM);
				action_0(_9ycmcfwZ9EbmXanrFe7pEfGAAUi);
			}
			_XDKgJpkUD4lIN2K7ysMOtqO5gMA();
		});
		_E3KHmDW9haZynE9ZamZBVdveWgk.add_TextCommit((EventHandler)delegate
		{
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			if (int.TryParse(_E3KHmDW9haZynE9ZamZBVdveWgk.get_Text(), out var result))
			{
				((Color)(ref _9ycmcfwZ9EbmXanrFe7pEfGAAUi)).set_B((byte)Math.Max(0, Math.Min(result, 255)));
				_fA3AcauqZZ0ncWKv9QA3iklruOI(_9ycmcfwZ9EbmXanrFe7pEfGAAUi, out _kyexzK2VL0y9etRuX79HInHIsIb, out _46o2iZ9juR1nNURyrP41h9vxpGA, out _xX4CfdHl6arem4v3fUgbDUIK2gM);
				action_0(_9ycmcfwZ9EbmXanrFe7pEfGAAUi);
			}
			_XDKgJpkUD4lIN2K7ysMOtqO5gMA();
		});
		_8lboaaRLcpJoVxfwF1kBCisgrjL.add_TextCommit((EventHandler)delegate
		{
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			if (_8lboaaRLcpJoVxfwF1kBCisgrjL.get_Text().StartsWith("#") && _8lboaaRLcpJoVxfwF1kBCisgrjL.get_Text().Length <= 7)
			{
				try
				{
					int num = Convert.ToInt32(_8lboaaRLcpJoVxfwF1kBCisgrjL.get_Text().Substring(1), 16);
					((Color)(ref _9ycmcfwZ9EbmXanrFe7pEfGAAUi)).set_B((byte)((uint)num & 0xFFu));
					((Color)(ref _9ycmcfwZ9EbmXanrFe7pEfGAAUi)).set_G((byte)((uint)(num >> 8) & 0xFFu));
					((Color)(ref _9ycmcfwZ9EbmXanrFe7pEfGAAUi)).set_R((byte)((uint)(num >> 16) & 0xFFu));
					_fA3AcauqZZ0ncWKv9QA3iklruOI(_9ycmcfwZ9EbmXanrFe7pEfGAAUi, out _kyexzK2VL0y9etRuX79HInHIsIb, out _46o2iZ9juR1nNURyrP41h9vxpGA, out _xX4CfdHl6arem4v3fUgbDUIK2gM);
					action_0(_9ycmcfwZ9EbmXanrFe7pEfGAAUi);
				}
				catch
				{
				}
			}
			_XDKgJpkUD4lIN2K7ysMOtqO5gMA();
		});
		((Control)_L7VColD35B3sDgJdUnjTeXGa7pv).add_Update((VoidEvent)delegate
		{
			if (base._ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH((Keys)27))
			{
				_L7VColD35B3sDgJdUnjTeXGa7pv.Close();
				_hSPLyBveOIKpCKgimgpgcMUDdRz = null;
			}
		});
	}

	public static void _fA3AcauqZZ0ncWKv9QA3iklruOI(Color color_0, out float float_0, out float float_1, out float float_2)
	{
		float num = 0f;
		float num2 = (int)Math.Min(Math.Min(((Color)(ref color_0)).get_R(), ((Color)(ref color_0)).get_G()), ((Color)(ref color_0)).get_B());
		float num3 = (int)Math.Max(Math.Max(((Color)(ref color_0)).get_R(), ((Color)(ref color_0)).get_G()), ((Color)(ref color_0)).get_B());
		float num4 = num3 - num2;
		float num5 = ((!((double)num3 <= 0.0)) ? (num4 / num3) : 0f);
		if (num5 > 0f)
		{
			if ((float)(int)((Color)(ref color_0)).get_R() <= num3)
			{
				num = (float)(((Color)(ref color_0)).get_G() - ((Color)(ref color_0)).get_B()) / num4;
			}
			else if ((float)(int)((Color)(ref color_0)).get_G() <= num3)
			{
				num = 2f + (float)(((Color)(ref color_0)).get_B() - ((Color)(ref color_0)).get_R()) / num4;
			}
			else if ((float)(int)((Color)(ref color_0)).get_B() <= num3)
			{
				num = 4f + (float)(((Color)(ref color_0)).get_R() - ((Color)(ref color_0)).get_G()) / num4;
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
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
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
		_OBIbaNO8X49ahEZ5n3Ta8HUK7mO(_TbkP67ntBpYJu1M27pBfsYAHmgJ.get_Content().get_Controls());
	}

	[CompilerGenerated]
	private void _i9Xj1KSWViEd71ALYa9ApJ2Gc9y()
	{
		_jiNxMIzuA8Rrc2ULsrob5A7UNDe(_TbkP67ntBpYJu1M27pBfsYAHmgJ.get_Content().get_Controls());
	}

	[CompilerGenerated]
	private void _3VjzhxKSwnPtdk4XhY3iFmHrG1H()
	{
		_1qIQUjhrbk5WA7C7mYs93gXLOIe(_TbkP67ntBpYJu1M27pBfsYAHmgJ.get_Content().get_Controls());
	}

	[CompilerGenerated]
	private void _pKgyzskaeOQ1TRYcUjxy3zMiF5T()
	{
		_VCrdQDifkN8NHlzPICTmtbgWFwp(_TbkP67ntBpYJu1M27pBfsYAHmgJ.get_Content().get_Controls());
	}

	[CompilerGenerated]
	private void _VIr0RlSCz9V0frZhjT6BsMYn28U()
	{
		_vXrWU56trsuFNc9CNcHuctfkI2S(_TbkP67ntBpYJu1M27pBfsYAHmgJ.get_Content().get_Controls());
	}

	[CompilerGenerated]
	private void _1KOufZWxXAv4lBCHX0VbC5pdIhN()
	{
		_vg6ASaP7xNqc0jerF3mcrXv4dn7(_TbkP67ntBpYJu1M27pBfsYAHmgJ.get_Content().get_Controls());
	}

	[CompilerGenerated]
	private void _w91LaUOFTCMT9AffWnTo1PJ3EMr()
	{
		_Xhurp3mVVoR5kNlnxgLoDDkeQxM(_TbkP67ntBpYJu1M27pBfsYAHmgJ.get_Content().get_Controls());
	}

	[CompilerGenerated]
	private void _BZPbyIJWfbmS1NEIAww1KgTP1vg()
	{
		_gHA9C0CRN2NaRMtfTrvlotJOd0T(_TbkP67ntBpYJu1M27pBfsYAHmgJ.get_Content().get_Controls());
	}

	[CompilerGenerated]
	private void _kgalrc04EwTy7lf17UuFH8tkWJe()
	{
		_hNo7o9fG9jvwcKyMq1nYl4q7cXc(_TbkP67ntBpYJu1M27pBfsYAHmgJ.get_Content().get_Controls());
	}

	[CompilerGenerated]
	private void _AkTV7h3XKguAhStEd33YiNZJ7Re()
	{
		_mWS8UuA4xcT1bSdjDObiubOE0wH(_TbkP67ntBpYJu1M27pBfsYAHmgJ.get_Content().get_Controls());
	}

	[CompilerGenerated]
	private void _V87FuhPcqj5irT0Wrn5TCo9Ae9B()
	{
		_7JR6eL4D0qdIJNOwfInnlg2HEgZ(_TbkP67ntBpYJu1M27pBfsYAHmgJ.get_Content().get_Controls());
	}

	[CompilerGenerated]
	private void _ybtbM3zRgg2shH5mHioQuMHwlaBA()
	{
		_PBEdYyzYEWcXAodjVf58ocOQ3Jf(_TbkP67ntBpYJu1M27pBfsYAHmgJ.get_Content().get_Controls());
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
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		_3t4w2BwPGr8GQDmJlQU929IFD8f._6f1rvTENt5XWmHTE22zxBIwbH9G = color_0;
	}

	[CompilerGenerated]
	private void _cgQk2a8YpQxbltiCp0ND31sel1AA(Color color_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		_3t4w2BwPGr8GQDmJlQU929IFD8f._PeK36AvFxEQCvX3fS62hNV7rpuJ = color_0;
	}

	[CompilerGenerated]
	private void _GqZTDO1N9LdbZBpsbC4MlEJe6U7(Color color_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		_3t4w2BwPGr8GQDmJlQU929IFD8f._zBv1cYqPRU7uDCALpBlBSgObUcbA = color_0;
	}

	[CompilerGenerated]
	private void _VuvgAhyavuApBE7oChue41hK7PB(Color color_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		_3t4w2BwPGr8GQDmJlQU929IFD8f._in5HHYmrdLTFpkgc8aimJpXqAXB = color_0;
	}

	[CompilerGenerated]
	private void _E2lBd1QEjBj0REiMHNqMwMsx4wr(Color color_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		_3t4w2BwPGr8GQDmJlQU929IFD8f._1ZKGQXLRAHEJR8v7jhlDsyOVLcz = color_0;
	}

	[CompilerGenerated]
	private void _ofZZDYP56EomSmzWRc6x3CWW6Wb(Color color_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		_3t4w2BwPGr8GQDmJlQU929IFD8f._8rDSn6e9Ip9WdOogjhIn8YlL1oM = color_0;
	}

	[CompilerGenerated]
	private void _I7brQQRUAHsa7dWHr3Y85NUX8Mh(Color color_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		_3t4w2BwPGr8GQDmJlQU929IFD8f._FrsyMDX7TebzFk8nSLTyRDPi1QH = color_0;
	}

	[CompilerGenerated]
	private void _lITvn0PjmR9QBbQsWGhjawYbGvg(Color color_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		_3t4w2BwPGr8GQDmJlQU929IFD8f._cUtgkG5qDvgFmI8c29I9xsLVNON = color_0;
	}

	[CompilerGenerated]
	private void _GnNbyYmrPdLBOTz1TtzPXJy3KJN(Color color_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		_3t4w2BwPGr8GQDmJlQU929IFD8f._LcOPiDaC2j5vzxOEYhvW4vRoaRX = color_0;
	}

	[CompilerGenerated]
	private void _3alfnfUF4KoAk2bzwFTDkAQltQw(Color color_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		_3t4w2BwPGr8GQDmJlQU929IFD8f._VsEYbNSam3IFYYWY4QC2lb4ia61 = color_0;
	}

	[CompilerGenerated]
	private void _dxIbqa9HjkRksCyotm88DRZfbcf(Color color_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		_3t4w2BwPGr8GQDmJlQU929IFD8f._y1SiMmRVXWDhDtY17knDpitt46F = color_0;
	}

	[CompilerGenerated]
	private void _RsPDhjE4m0UaI7A3gRporMFinGW(Color color_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		_3t4w2BwPGr8GQDmJlQU929IFD8f._9b2asKZDwVM1TcSfmfeFCuk0TJZb = color_0;
	}

	[CompilerGenerated]
	private void _JtLlhMY7INQCnLA7U1TQgbc2UVb(Color color_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		_3t4w2BwPGr8GQDmJlQU929IFD8f._vUhBAXEgvpGKopOUkDJFoc4EYQ3 = color_0;
	}

	[CompilerGenerated]
	private void _gQB9HFUA9OEd3wBEq8bYACMkZNE(Color color_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		_3t4w2BwPGr8GQDmJlQU929IFD8f._GXnDb1oaJlPbAQV2mjAwCQFK0nmb = color_0;
	}

	[CompilerGenerated]
	private void _xVyppYNITOEbySGX3Ysrf7X0CDL(Color color_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		_3t4w2BwPGr8GQDmJlQU929IFD8f._LZfuQybASevOsCykEWqdvA5GqUF = color_0;
	}

	static _uqydQVaCmCvK7zzWs5W4gZFpKBu smethod_14(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._0O8D0mBgmrh0sLOGcLVvGNOHKLCA(string_0, string_1, int_0, int_1);
	}

	static _fAUddQEKfZyemRb327NhM3GGlmzA smethod_15(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0)
	{
		return new _fAUddQEKfZyemRb327NhM3GGlmzA(_7UlnfykmEmZDFt3BmCKZekI43Ih_0, string_0);
	}

	static void smethod_16(_fAUddQEKfZyemRb327NhM3GGlmzA _fAUddQEKfZyemRb327NhM3GGlmzA_0, Action<SpriteBatch> action_0)
	{
		_fAUddQEKfZyemRb327NhM3GGlmzA_0._B6VrMlmWofCGqEzjzgFJiAliCge = action_0;
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG smethod_17()
	{
		return _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
	}

	static void smethod_18(string string_0, float float_0)
	{
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc(string_0, float_0);
	}

	static ContentManager smethod_19(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8;
	}

	static _JbeCmOie0phb2cbgG6DdGZrbs3pB smethod_20(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._ZzBuoSDMWwerejOO9Goyv2OCKgE;
	}

	static void smethod_21(_21uBmerICJi18moE2gpxlEipBgz _21uBmerICJi18moE2gpxlEipBgz_0)
	{
		_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._Wrz1IORok7yBtsQA3czQUmnP6Yl(_21uBmerICJi18moE2gpxlEipBgz_0);
	}

	static Window smethod_22()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Window();
	}

	static void smethod_23(Control control_0, DockStyle dockStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Dock(dockStyle_0);
	}

	static Label smethod_24()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static void smethod_25(Label label_0, string string_0)
	{
		label_0.set_Text(string_0);
	}

	static TextBox smethod_26()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static void smethod_27(TextBox textBox_0, string string_0)
	{
		textBox_0.set_Text(string_0);
	}

	static Desktop smethod_28(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._PnkAlVnMv0SZvRBFexqzE5DF9tp;
	}

	static void smethod_29(Desktop desktop_0, string string_0, string[] string_1, int int_0, Action<int> action_0)
	{
		desktop_0._GtkWDtXwQHwgWY4aFkacjfUDyzb(string_0, string_1, int_0, action_0);
	}

	static Panel smethod_30()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Panel();
	}

	static void smethod_31(Control control_0, bool bool_0)
	{
		control_0.set_Visible(bool_0);
	}

	static Frame smethod_32(Panel panel_0)
	{
		return panel_0.get_Content();
	}

	static ControlCollection smethod_33(Frame frame_0)
	{
		return frame_0.get_Controls();
	}

	static EffectParameterCollection smethod_34(Effect effect_0)
	{
		return effect_0.get_Parameters();
	}

	static EffectParameter smethod_35(EffectParameterCollection effectParameterCollection_0, string string_0)
	{
		return effectParameterCollection_0.get_Item(string_0);
	}

	static void smethod_36(EffectParameter effectParameter_0, float float_0)
	{
		effectParameter_0.SetValue(float_0);
	}

	static _Z6EKIW3ycAwV2npYuxbFLcnCTrJ smethod_37()
	{
		return _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._yuFBJdi7mxrwMFQ57BjLjSq6ESj;
	}

	static void smethod_38(_Z6EKIW3ycAwV2npYuxbFLcnCTrJ _Z6EKIW3ycAwV2npYuxbFLcnCTrJ_0, SpriteBatch spriteBatch_0, Effect effect_0)
	{
		_Z6EKIW3ycAwV2npYuxbFLcnCTrJ_0._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0, effect_0);
	}

	static bool smethod_39(Enum enum_0, Enum enum_1)
	{
		return enum_0.HasFlag(enum_1);
	}

	static CheckBox smethod_40()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new CheckBox();
	}

	static void smethod_41(CheckBox checkBox_0, string string_0)
	{
		checkBox_0.set_Text(string_0);
	}

	static void smethod_42(CheckBox checkBox_0, bool bool_0)
	{
		checkBox_0.set_Checked(bool_0);
	}

	static Control smethod_43()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Control();
	}

	static Button smethod_44()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static void smethod_45(Label label_0, Alignment alignment_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		label_0.set_TextAlign(alignment_0);
	}

	static void smethod_46(Control control_0, string string_0)
	{
		control_0.set_Style(string_0);
	}

	static void smethod_47(Control control_0, MouseEvent mouseEvent_0)
	{
		control_0.add_MouseClick(mouseEvent_0);
	}

	static DropDownList smethod_48()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new DropDownList();
	}

	static Label smethod_49(DropDownList dropDownList_0)
	{
		return dropDownList_0.get_Label();
	}

	static void smethod_50(Window window_0)
	{
		window_0.Close();
	}

	static void smethod_51(Control control_0, AutoSize autoSize_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_AutoSize(autoSize_0);
	}

	static _TwlwMC1hhdSzamwGWEBxuUkz1gH smethod_52(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._KVSwpLj0RvURRswHn7ogRy4BRfd;
	}

	static void smethod_53(_TwlwMC1hhdSzamwGWEBxuUkz1gH _TwlwMC1hhdSzamwGWEBxuUkz1gH_0)
	{
		_TwlwMC1hhdSzamwGWEBxuUkz1gH_0._0cFb48aKbcbREkHm9Jwptl6r6Vi();
	}
}
