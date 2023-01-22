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
			while (true)
			{
				int num = -375146974;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCDBCF6A8u) % 3u)
					{
					case 2u:
						goto IL_0008;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_0008:
					_WJT1PtSst4BMDPVrhqxz2VnJrOC = string_0;
					_lToB8ouR2ppZvt0Yb49qzPAAZJS = string_1;
					num = (int)((num2 * 382895471) ^ 0x2D497383);
				}
			}
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
		while (true)
		{
			int num = 2134404640;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x642C8409u) % 7u)
				{
				case 4u:
					_3t4w2BwPGr8GQDmJlQU929IFD8f = new PlayerDataProxy(PlayerCustomizationScene.smethod_17());
					_3t4w2BwPGr8GQDmJlQU929IFD8f._jCsrJ38OEkr542qwd48oa3BLDIB += delegate
					{
						if (PlayerCustomizationScene.smethod_52(PlayerCustomizationScene.smethod_20((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)) != null)
						{
							while (true)
							{
								int num3 = -1808072291;
								while (true)
								{
									uint num4;
									switch ((num4 = (uint)num3 ^ 0x8AC7F9BAu) % 3u)
									{
									case 2u:
										goto IL_000f;
									default:
										return;
									case 0u:
										break;
									case 1u:
										return;
									}
									break;
									IL_000f:
									PlayerCustomizationScene.smethod_53(PlayerCustomizationScene.smethod_52(PlayerCustomizationScene.smethod_20((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)));
									num3 = (int)((num4 * 1793340020) ^ 0x2AEECD45);
								}
							}
						}
					};
					PlayerCustomizationScene.smethod_18("Assets/Music/Blazing Dragon - Midnight Sizzle", 0.4f);
					num = ((int)num2 * -1128340300) ^ -973436775;
					continue;
				case 3u:
					_9jklVVcQQYcyqOYrkPiht2VP0IG = PlayerCustomizationScene.smethod_19(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0).Load<Effect>("Assets/Shaders/Breathing");
					num = (int)((num2 * 906925602) ^ 0x454F9DF2);
					continue;
				case 2u:
				{
					_fAUddQEKfZyemRb327NhM3GGlmzA fAUddQEKfZyemRb327NhM3GGlmzA = PlayerCustomizationScene.smethod_15((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Custom");
					PlayerCustomizationScene.smethod_16(fAUddQEKfZyemRb327NhM3GGlmzA, (Action<SpriteBatch>)_KkwafXXLVg1QfQgqqCAojg2ySyZ);
					_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(fAUddQEKfZyemRb327NhM3GGlmzA, 0);
					num = ((int)num2 * -505070451) ^ 0x80C611C;
					continue;
				}
				case 1u:
					PlayerCustomizationScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Bedroom/Bedroom", -458, 0);
					num = (int)(num2 * 795753875) ^ -669383527;
					continue;
				case 0u:
					_LTwaEzSn23m9dquR3WwhTVRbJiG = _7VjfLBpTQsFudLfKhPWefSex1UC.Select((SexsceneData sexsceneData_0) => sexsceneData_0._RB8fRXeQvK5vs7JEA0XfVCEpg1i).ToArray();
					num = 1800291138;
					continue;
				default:
					return;
				case 6u:
					break;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	public override void _4hlxzMzKSbVTbZUrEsP3dfw4x0h()
	{
		_q9fwz0K4rjUrAm9v3Dn6azqJaIN = new _MqMsYrF1I2ghuKhx3f6aKuRGquq(PlayerCustomizationScene.smethod_20((_7UlnfykmEmZDFt3BmCKZekI43Ih)this));
		_hI8MfcRDpV9Q45afjBJe8lA5sbr();
		while (true)
		{
			int num = 883904236;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x59DC1FA7u) % 4u)
				{
				case 3u:
					PlayerCustomizationScene.smethod_21((_21uBmerICJi18moE2gpxlEipBgz)_q9fwz0K4rjUrAm9v3Dn6azqJaIN);
					num = (int)(num2 * 484582111) ^ -2136722408;
					continue;
				case 2u:
					_dJMkrCEG7sVmAlGOM9PfNSkFZZC();
					num = ((int)num2 * -491336562) ^ -626259846;
					continue;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	protected virtual void _hI8MfcRDpV9Q45afjBJe8lA5sbr()
	{
		if (_q9fwz0K4rjUrAm9v3Dn6azqJaIN._I6gsCHlb2BKFCJSAk9Cn5fCMAPu.Any())
		{
			while (true)
			{
				int num = -78347638;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8712A87Bu) % 5u)
					{
					case 4u:
						_3t4w2BwPGr8GQDmJlQU929IFD8f._RB8fRXeQvK5vs7JEA0XfVCEpg1i = _q9fwz0K4rjUrAm9v3Dn6azqJaIN._6qwooGF3jWmbG9887Y5IKZ8fJ0E(0);
						num = (int)(num2 * 2007038883) ^ -294326357;
						continue;
					case 2u:
						_q9fwz0K4rjUrAm9v3Dn6azqJaIN._BCRMBb9uhQZrQlfdXPidu27yb8C(0);
						num = (int)((num2 * 1102869803) ^ 0x771D7A1E);
						continue;
					case 3u:
						break;
					case 0u:
						_QjFuG8JMGq8rGnavgUdgnBEKBfD = 0;
						return;
					default:
						goto end_IL_0078;
					}
					break;
				}
				continue;
				end_IL_0078:
				break;
			}
		}
		_q9fwz0K4rjUrAm9v3Dn6azqJaIN._BwV21jdCpo4YpIp6x74bJ0H7hut(0);
		_3t4w2BwPGr8GQDmJlQU929IFD8f._RB8fRXeQvK5vs7JEA0XfVCEpg1i = "Player";
		_QjFuG8JMGq8rGnavgUdgnBEKBfD = -1;
	}

	private void _dJMkrCEG7sVmAlGOM9PfNSkFZZC()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		Window obj = PlayerCustomizationScene.smethod_22();
		PlayerCustomizationScene.smethod_23((Control)(object)obj, (DockStyle)3);
		((Control)obj).set_Size(new Point(512, 0));
		((Control)obj).set_Margin(new Margin(8));
		((Control)obj).set_Padding(new Margin(8));
		Window val = obj;
		Panel val2 = new Panel();
		((Control)val2).set_Dock((DockStyle)5);
		_0jH3FoV36utxuSLivmD6IZNwppA = val2;
		while (true)
		{
			int num = 1824129948;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE5DA9A9u) % 10u)
				{
				case 9u:
					_kG9DrP49ggNdZOvVMMUPjfqdzZ4.Add(_cvldkRXLM8Toadgv6nPx5QH1EES("Feet", delegate
					{
						_PBEdYyzYEWcXAodjVf58ocOQ3Jf(PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_TbkP67ntBpYJu1M27pBfsYAHmgJ)));
					}));
					num = (int)(num2 * 813470576) ^ -20523846;
					continue;
				case 8u:
				{
					Panel val3 = new Panel();
					((Control)val3).set_Dock((DockStyle)5);
					((Control)val3.get_ClipFrame()).set_Margin(new Margin(8));
					_TbkP67ntBpYJu1M27pBfsYAHmgJ = val3;
					num = (int)(num2 * 745714333) ^ -798259104;
					continue;
				}
				case 7u:
					((ActiveList<Control>)(object)val.get_Controls()).Add((Control)(object)_0jH3FoV36utxuSLivmD6IZNwppA);
					num = (int)((num2 * 286066467) ^ 0x71BBCF0);
					continue;
				case 6u:
					_kG9DrP49ggNdZOvVMMUPjfqdzZ4.Add(_cvldkRXLM8Toadgv6nPx5QH1EES("Tail", delegate
					{
						_7JR6eL4D0qdIJNOwfInnlg2HEgZ(PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_TbkP67ntBpYJu1M27pBfsYAHmgJ)));
					}));
					num = 2110214540;
					continue;
				case 5u:
					_kG9DrP49ggNdZOvVMMUPjfqdzZ4 = new List<Button>
					{
						_cvldkRXLM8Toadgv6nPx5QH1EES("Fursona", delegate
						{
							_OBIbaNO8X49ahEZ5n3Ta8HUK7mO(PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_TbkP67ntBpYJu1M27pBfsYAHmgJ)));
						}),
						_cvldkRXLM8Toadgv6nPx5QH1EES("Body", delegate
						{
							_jiNxMIzuA8Rrc2ULsrob5A7UNDe(PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_TbkP67ntBpYJu1M27pBfsYAHmgJ)));
						}),
						_cvldkRXLM8Toadgv6nPx5QH1EES("Arms", delegate
						{
							_1qIQUjhrbk5WA7C7mYs93gXLOIe(PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_TbkP67ntBpYJu1M27pBfsYAHmgJ)));
						}),
						_cvldkRXLM8Toadgv6nPx5QH1EES("Legs", delegate
						{
							_VCrdQDifkN8NHlzPICTmtbgWFwp(PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_TbkP67ntBpYJu1M27pBfsYAHmgJ)));
						}),
						_cvldkRXLM8Toadgv6nPx5QH1EES("Head", delegate
						{
							_vXrWU56trsuFNc9CNcHuctfkI2S(PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_TbkP67ntBpYJu1M27pBfsYAHmgJ)));
						}),
						_cvldkRXLM8Toadgv6nPx5QH1EES("Muzzle", delegate
						{
							_vg6ASaP7xNqc0jerF3mcrXv4dn7(PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_TbkP67ntBpYJu1M27pBfsYAHmgJ)));
						}),
						_cvldkRXLM8Toadgv6nPx5QH1EES("Ears and Horns", delegate
						{
							_Xhurp3mVVoR5kNlnxgLoDDkeQxM(PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_TbkP67ntBpYJu1M27pBfsYAHmgJ)));
						}),
						_cvldkRXLM8Toadgv6nPx5QH1EES("Hair and Fringes", delegate
						{
							_gHA9C0CRN2NaRMtfTrvlotJOd0T(PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_TbkP67ntBpYJu1M27pBfsYAHmgJ)));
						}),
						_cvldkRXLM8Toadgv6nPx5QH1EES("Eyes and Brows", delegate
						{
							_hNo7o9fG9jvwcKyMq1nYl4q7cXc(PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_TbkP67ntBpYJu1M27pBfsYAHmgJ)));
						})
					};
					num = ((int)num2 * -696332396) ^ 0x4063A495;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
					{
						num3 = 627032333;
						num4 = 627032333;
					}
					else
					{
						num3 = 648028759;
						num4 = 648028759;
					}
					num = num3 ^ (int)(num2 * 2104333533);
					continue;
				}
				case 3u:
					val.Show(base._PnkAlVnMv0SZvRBFexqzE5DF9tp);
					((Control)_kG9DrP49ggNdZOvVMMUPjfqdzZ4[0]).Click(0);
					num = ((int)num2 * -1205499566) ^ -1677354404;
					continue;
				case 0u:
					_kG9DrP49ggNdZOvVMMUPjfqdzZ4.Add(_cvldkRXLM8Toadgv6nPx5QH1EES("Breasts, Cock and Balls", delegate
					{
						_mWS8UuA4xcT1bSdjDObiubOE0wH(PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_TbkP67ntBpYJu1M27pBfsYAHmgJ)));
					}));
					num = ((int)num2 * -1529334595) ^ 0x7AB2CEA3;
					continue;
				default:
					return;
				case 2u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	private void _OBIbaNO8X49ahEZ5n3Ta8HUK7mO(ControlCollection controlCollection_0)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected O, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected O, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected O, but got Unknown
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected O, but got Unknown
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected O, but got Unknown
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected O, but got Unknown
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fb: Expected O, but got Unknown
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Expected O, but got Unknown
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Expected O, but got Unknown
		Button val8 = default(Button);
		TextBox _Z0ib1EsNAOHar3w2AfvKgeb8s2BA = default(TextBox);
		PlayerCustomizationScene _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = default(PlayerCustomizationScene);
		ControlCollection _7y2pwnzdnnIdP3bK7MDiAAyPF9BA = default(ControlCollection);
		Button val6 = default(Button);
		Button val4 = default(Button);
		Button val7 = default(Button);
		Button val10 = default(Button);
		Button val2 = default(Button);
		while (true)
		{
			int num = 1591735462;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x16090D17u) % 25u)
				{
				case 24u:
					((Control)val8).add_MouseClick((MouseEvent)delegate
					{
						if (_003C_003Ec__DisplayClass20_0.smethod_6(_003C_003Ec__DisplayClass20_0.smethod_0(_Z0ib1EsNAOHar3w2AfvKgeb8s2BA)))
						{
							goto IL_00cb;
						}
						goto IL_0141;
						IL_0141:
						int num20;
						int num21;
						if (_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._QjFuG8JMGq8rGnavgUdgnBEKBfD < 0)
						{
							num20 = 572002048;
							num21 = 572002048;
						}
						else
						{
							num20 = 1335512211;
							num21 = 1335512211;
						}
						goto IL_0101;
						IL_0101:
						while (true)
						{
							uint num22;
							switch ((num22 = (uint)num20 ^ 0x5431D787u) % 8u)
							{
							case 7u:
								_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._yA2ISabBQiVKBxMt5AXSybmkG5o(_003C_003Ec__DisplayClass20_0.smethod_9("No template has been selected yet, do you wish to create a new template with the name '{0}', based on the current character?", (object)_003C_003Ec__DisplayClass20_0.smethod_0(_Z0ib1EsNAOHar3w2AfvKgeb8s2BA)), delegate
								{
									_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._q9fwz0K4rjUrAm9v3Dn6azqJaIN._0S3oMrwxDtOTcbzkglSllPfRq53(_003C_003Ec__DisplayClass20_0.smethod_0(_Z0ib1EsNAOHar3w2AfvKgeb8s2BA), _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3t4w2BwPGr8GQDmJlQU929IFD8f._dxo6sBOpjEUiw2JBMikbutXK44t());
									_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._QjFuG8JMGq8rGnavgUdgnBEKBfD = _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._q9fwz0K4rjUrAm9v3Dn6azqJaIN._I6gsCHlb2BKFCJSAk9Cn5fCMAPu.Count() - 1;
									while (true)
									{
										int num23 = 269009522;
										while (true)
										{
											uint num24;
											switch ((num24 = (uint)num23 ^ 0x399C3FCFu) % 4u)
											{
											case 3u:
												((ActiveList<Control>)(object)_003C_003Ec__DisplayClass20_0.smethod_2(_003C_003Ec__DisplayClass20_0.smethod_1(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._TbkP67ntBpYJu1M27pBfsYAHmgJ))).Clear();
												_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._OBIbaNO8X49ahEZ5n3Ta8HUK7mO(_7y2pwnzdnnIdP3bK7MDiAAyPF9BA);
												num23 = (int)(num24 * 1083684230) ^ -1479024381;
												continue;
											case 1u:
												_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._q9fwz0K4rjUrAm9v3Dn6azqJaIN._BCRMBb9uhQZrQlfdXPidu27yb8C(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._QjFuG8JMGq8rGnavgUdgnBEKBfD);
												_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3t4w2BwPGr8GQDmJlQU929IFD8f._RB8fRXeQvK5vs7JEA0XfVCEpg1i = _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._q9fwz0K4rjUrAm9v3Dn6azqJaIN._6qwooGF3jWmbG9887Y5IKZ8fJ0E(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._QjFuG8JMGq8rGnavgUdgnBEKBfD);
												num23 = (int)((num24 * 449726136) ^ 0x4A519C60);
												continue;
											default:
												return;
											case 0u:
												break;
											case 2u:
												return;
											}
											break;
										}
									}
								});
								num20 = 1986733588;
								continue;
							case 4u:
								_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._yA2ISabBQiVKBxMt5AXSybmkG5o(_003C_003Ec__DisplayClass20_0.smethod_9("Are you sure you wish to save the currect character to the selected template '{0}'?", (object)_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._q9fwz0K4rjUrAm9v3Dn6azqJaIN._6qwooGF3jWmbG9887Y5IKZ8fJ0E(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._QjFuG8JMGq8rGnavgUdgnBEKBfD)), delegate
								{
									_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._q9fwz0K4rjUrAm9v3Dn6azqJaIN._WfRAwdaNcmrDEhMe1AHPq7egPcw(_003C_003Ec__DisplayClass20_0.smethod_0(_Z0ib1EsNAOHar3w2AfvKgeb8s2BA), _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._QjFuG8JMGq8rGnavgUdgnBEKBfD, _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3t4w2BwPGr8GQDmJlQU929IFD8f._dxo6sBOpjEUiw2JBMikbutXK44t());
									((ActiveList<Control>)(object)_003C_003Ec__DisplayClass20_0.smethod_2(_003C_003Ec__DisplayClass20_0.smethod_1(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._TbkP67ntBpYJu1M27pBfsYAHmgJ))).Clear();
									_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._OBIbaNO8X49ahEZ5n3Ta8HUK7mO(_7y2pwnzdnnIdP3bK7MDiAAyPF9BA);
								});
								num20 = 1291035369;
								continue;
							case 2u:
								break;
							case 1u:
								_003C_003Ec__DisplayClass20_0.smethod_8(_003C_003Ec__DisplayClass20_0.smethod_7((_7UlnfykmEmZDFt3BmCKZekI43Ih)_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA), "You did not enter a name!", 500, "OK", (Action)null);
								num20 = ((int)num22 * -1527022989) ^ -805579967;
								continue;
							default:
								return;
							case 0u:
								goto IL_0141;
							case 3u:
								return;
							case 5u:
								return;
							case 6u:
								return;
							}
							break;
						}
						goto IL_00cb;
						IL_00cb:
						num20 = 73510174;
						goto IL_0101;
					});
					((ActiveList<Control>)(object)_7y2pwnzdnnIdP3bK7MDiAAyPF9BA).Add((Control)(object)val8);
					num = (int)(num2 * 1677517880) ^ -1402549990;
					continue;
				case 23u:
					_YemBTJprwfbd3mpg5Gy9uyEJWwI(_7y2pwnzdnnIdP3bK7MDiAAyPF9BA, "Your Templates", _q9fwz0K4rjUrAm9v3Dn6azqJaIN._I6gsCHlb2BKFCJSAk9Cn5fCMAPu.Select((_xJL9E6vKdg1LYZtKQU5RQKikpvE _xJL9E6vKdg1LYZtKQU5RQKikpvE_0) => _xJL9E6vKdg1LYZtKQU5RQKikpvE_0._RB8fRXeQvK5vs7JEA0XfVCEpg1i).ToArray(), _QjFuG8JMGq8rGnavgUdgnBEKBfD, delegate(int int_0)
					{
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._QjFuG8JMGq8rGnavgUdgnBEKBfD = int_0;
						while (true)
						{
							int num25 = 685317980;
							while (true)
							{
								uint num26;
								switch ((num26 = (uint)num25 ^ 0x40BDFE2u) % 7u)
								{
								case 5u:
									_003C_003Ec__DisplayClass20_0.smethod_5(_003C_003Ec__DisplayClass20_0.smethod_4(_003C_003Ec__DisplayClass20_0.smethod_3((_7UlnfykmEmZDFt3BmCKZekI43Ih)_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA)));
									num25 = ((int)num26 * -314244089) ^ 0x50DAB121;
									continue;
								case 4u:
									_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3t4w2BwPGr8GQDmJlQU929IFD8f._RB8fRXeQvK5vs7JEA0XfVCEpg1i = _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._q9fwz0K4rjUrAm9v3Dn6azqJaIN._6qwooGF3jWmbG9887Y5IKZ8fJ0E(int_0);
									num25 = ((int)num26 * -16735296) ^ -1519916521;
									continue;
								case 3u:
								{
									int num27;
									int num28;
									if (_003C_003Ec__DisplayClass20_0.smethod_4(_003C_003Ec__DisplayClass20_0.smethod_3((_7UlnfykmEmZDFt3BmCKZekI43Ih)_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA)) != null)
									{
										num27 = -1741791309;
										num28 = -1741791309;
									}
									else
									{
										num27 = -1723308250;
										num28 = -1723308250;
									}
									num25 = num27 ^ ((int)num26 * -1334562883);
									continue;
								}
								case 2u:
									((ActiveList<Control>)(object)_003C_003Ec__DisplayClass20_0.smethod_2(_003C_003Ec__DisplayClass20_0.smethod_1(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._TbkP67ntBpYJu1M27pBfsYAHmgJ))).Clear();
									_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._OBIbaNO8X49ahEZ5n3Ta8HUK7mO(_7y2pwnzdnnIdP3bK7MDiAAyPF9BA);
									num25 = ((int)num26 * -1790931179) ^ -494968655;
									continue;
								case 1u:
									_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._q9fwz0K4rjUrAm9v3Dn6azqJaIN._BCRMBb9uhQZrQlfdXPidu27yb8C(int_0);
									num25 = (int)(num26 * 288835094) ^ -1838091723;
									continue;
								default:
									return;
								case 6u:
									break;
								case 0u:
									return;
								}
								break;
							}
						}
					});
					num = 148539872;
					continue;
				case 22u:
				{
					Skin skin = base._PnkAlVnMv0SZvRBFexqzE5DF9tp.get_Skin();
					ControlStyle val11 = new ControlStyle(((Dictionary<string, ControlStyle>)(object)base._PnkAlVnMv0SZvRBFexqzE5DF9tp.get_Skin())["button"]);
					val11.set_Tint(ColorInt.ARGB(1f, 0f, 1f, 0f));
					((Dictionary<string, ControlStyle>)(object)skin).Add("button2", val11);
					num = (int)(num2 * 2074726580) ^ -776181958;
					continue;
				}
				case 21u:
					((Control)val6).add_MouseClick((MouseEvent)delegate
					{
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._q9fwz0K4rjUrAm9v3Dn6azqJaIN._BlScjiyHDsZk3jkAZbAbjUxn87sA();
					});
					num = (int)(num2 * 1605863505) ^ -1872381034;
					continue;
				case 19u:
				{
					int num5;
					if (((Dictionary<string, ControlStyle>)(object)base._PnkAlVnMv0SZvRBFexqzE5DF9tp.get_Skin()).ContainsKey("button2"))
					{
						num = 178852998;
						num5 = 178852998;
					}
					else
					{
						num = 1326790172;
						num5 = 1326790172;
					}
					continue;
				}
				case 18u:
				{
					Button val14 = new Button();
					((Control)val14).set_Dock((DockStyle)2);
					((Label)val14).set_Text("Save Template");
					val8 = val14;
					num = (int)((num2 * 815166298) ^ 0x25D64490);
					continue;
				}
				case 17u:
					((ActiveList<Control>)(object)_7y2pwnzdnnIdP3bK7MDiAAyPF9BA).Add((Control)(object)val4);
					num = ((int)num2 * -622104474) ^ -664754491;
					continue;
				case 16u:
					((Control)val4).add_MouseClick((MouseEvent)delegate
					{
						if (_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._jIGpzoYLVPw8SPxmJcha832nCXR)
						{
							while (true)
							{
								int num6 = -244070531;
								while (true)
								{
									uint num7;
									switch ((num7 = (uint)num6 ^ 0x8B2D414Cu) % 4u)
									{
									case 1u:
									{
										int num8;
										int num9;
										if (_003C_003Ec__DisplayClass20_0.smethod_6(_003C_003Ec__DisplayClass20_0.smethod_0(_Z0ib1EsNAOHar3w2AfvKgeb8s2BA)))
										{
											num8 = 1709078159;
											num9 = 1709078159;
										}
										else
										{
											num8 = 357801650;
											num9 = 357801650;
										}
										num6 = num8 ^ ((int)num7 * -1096809991);
										continue;
									}
									case 0u:
										break;
									case 2u:
										_003C_003Ec__DisplayClass20_0.smethod_8(_003C_003Ec__DisplayClass20_0.smethod_7((_7UlnfykmEmZDFt3BmCKZekI43Ih)_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA), "You did not enter a name!", 500, "OK", (Action)null);
										return;
									default:
										goto end_IL_0064;
									}
									break;
								}
								continue;
								end_IL_0064:
								break;
							}
						}
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._n3b8BstkorCsu4TW0U2YVdFbdGp();
					});
					num = ((int)num2 * -1181558599) ^ 0x5A6806D1;
					continue;
				case 15u:
				{
					Control val12 = _z5npzs7mj5H3zJ1PF64BFNsXBmm(_7y2pwnzdnnIdP3bK7MDiAAyPF9BA, "Phone", _3t4w2BwPGr8GQDmJlQU929IFD8f._uOkbmfW26QVAvyEMQakki9kTMDbA, delegate(Color color_0)
					{
						//IL_000b: Unknown result type (might be due to invalid IL or missing references)
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3t4w2BwPGr8GQDmJlQU929IFD8f._uOkbmfW26QVAvyEMQakki9kTMDbA = color_0;
					});
					val12.set_Margin(new Margin(0, 5, 0, 0));
					Button val13 = new Button();
					((Control)val13).set_Margin(new Margin(0, 10, 0, 0));
					((Control)val13).set_Dock((DockStyle)2);
					((Label)val13).set_Text("New Template");
					val7 = val13;
					num = ((int)num2 * -2016457519) ^ -734953302;
					continue;
				}
				case 13u:
					_YemBTJprwfbd3mpg5Gy9uyEJWwI(_7y2pwnzdnnIdP3bK7MDiAAyPF9BA, "Stock Templates", _q9fwz0K4rjUrAm9v3Dn6azqJaIN._A088aXIdbVflSYtbl7vA5RjQOjXA.Select((_xJL9E6vKdg1LYZtKQU5RQKikpvE _xJL9E6vKdg1LYZtKQU5RQKikpvE_0) => _xJL9E6vKdg1LYZtKQU5RQKikpvE_0._RB8fRXeQvK5vs7JEA0XfVCEpg1i).ToArray(), _3yqpoxOljKnrj7mGlnrA0eOUMAk, delegate(int int_0)
					{
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3yqpoxOljKnrj7mGlnrA0eOUMAk = int_0;
						while (true)
						{
							int num10 = -223100544;
							while (true)
							{
								uint num11;
								switch ((num11 = (uint)num10 ^ 0x98CF8E9Cu) % 5u)
								{
								case 4u:
									_003C_003Ec__DisplayClass20_0.smethod_5(_003C_003Ec__DisplayClass20_0.smethod_4(_003C_003Ec__DisplayClass20_0.smethod_3((_7UlnfykmEmZDFt3BmCKZekI43Ih)_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA)));
									num10 = (int)(num11 * 1579985895) ^ -226354439;
									continue;
								case 2u:
									_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._q9fwz0K4rjUrAm9v3Dn6azqJaIN._BwV21jdCpo4YpIp6x74bJ0H7hut(int_0);
									((ActiveList<Control>)(object)_003C_003Ec__DisplayClass20_0.smethod_2(_003C_003Ec__DisplayClass20_0.smethod_1(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._TbkP67ntBpYJu1M27pBfsYAHmgJ))).Clear();
									_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._OBIbaNO8X49ahEZ5n3Ta8HUK7mO(_7y2pwnzdnnIdP3bK7MDiAAyPF9BA);
									num10 = ((int)num11 * -876922536) ^ -1501304779;
									continue;
								case 1u:
								{
									int num12;
									int num13;
									if (_003C_003Ec__DisplayClass20_0.smethod_4(_003C_003Ec__DisplayClass20_0.smethod_3((_7UlnfykmEmZDFt3BmCKZekI43Ih)_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA)) != null)
									{
										num12 = -59464203;
										num13 = -59464203;
									}
									else
									{
										num12 = -771672410;
										num13 = -771672410;
									}
									num10 = num12 ^ (int)(num11 * 1628060036);
									continue;
								}
								default:
									return;
								case 3u:
									break;
								case 0u:
									return;
								}
								break;
							}
						}
					});
					num = 1669582376;
					continue;
				case 12u:
					_YemBTJprwfbd3mpg5Gy9uyEJWwI(_7y2pwnzdnnIdP3bK7MDiAAyPF9BA, "Preview Sexscene", _LTwaEzSn23m9dquR3WwhTVRbJiG, _IyCJr9wgsrQgOUaXQco1I00YF7B, delegate(int int_0)
					{
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._IyCJr9wgsrQgOUaXQco1I00YF7B = int_0;
						if (int_0 == 0)
						{
							goto IL_000f;
						}
						goto IL_0081;
						IL_0081:
						_003C_003Ec__DisplayClass20_0.smethod_11(_003C_003Ec__DisplayClass20_0.smethod_3((_7UlnfykmEmZDFt3BmCKZekI43Ih)_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA), _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._7VjfLBpTQsFudLfKhPWefSex1UC[int_0]._XbOXR6AypLIdJ3gBMGseGi3Wi2i);
						int num14 = 1275475932;
						goto IL_0058;
						IL_0058:
						while (true)
						{
							uint num15;
							switch ((num15 = (uint)num14 ^ 0x5D1C2ADCu) % 6u)
							{
							case 5u:
								break;
							case 1u:
								_003C_003Ec__DisplayClass20_0.smethod_10(_003C_003Ec__DisplayClass20_0.smethod_3((_7UlnfykmEmZDFt3BmCKZekI43Ih)_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA));
								num14 = (int)((num15 * 108126844) ^ 0x3FDA1A42);
								continue;
							case 0u:
								_003C_003Ec__DisplayClass20_0.smethod_12(_003C_003Ec__DisplayClass20_0.smethod_4(_003C_003Ec__DisplayClass20_0.smethod_3((_7UlnfykmEmZDFt3BmCKZekI43Ih)_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA)), bool_0: true);
								num14 = ((int)num15 * -265813316) ^ 0x36672E2F;
								continue;
							default:
								return;
							case 2u:
								goto IL_0081;
							case 3u:
								return;
							case 4u:
								return;
							}
							break;
						}
						goto IL_000f;
						IL_000f:
						num14 = 255547501;
						goto IL_0058;
					});
					num = (int)((num2 * 1465110361) ^ 0x53056A4D);
					continue;
				case 11u:
				{
					ControlCollection obj2 = _7y2pwnzdnnIdP3bK7MDiAAyPF9BA;
					Label obj3 = PlayerCustomizationScene.smethod_24();
					PlayerCustomizationScene.smethod_23((Control)(object)obj3, (DockStyle)2);
					PlayerCustomizationScene.smethod_25(obj3, "Name");
					((ActiveList<Control>)(object)obj2).Add((Control)(object)obj3);
					num = (int)((num2 * 489150529) ^ 0x256F9CA5);
					continue;
				}
				case 10u:
					((Control)val10).add_MouseClick((MouseEvent)delegate
					{
						if (_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._QjFuG8JMGq8rGnavgUdgnBEKBfD >= 0)
						{
							goto IL_000e;
						}
						goto IL_0080;
						IL_0080:
						int num16 = -177029547;
						goto IL_0085;
						IL_0085:
						while (true)
						{
							uint num17;
							switch ((num17 = (uint)num16 ^ 0xF1D4AD33u) % 5u)
							{
							case 4u:
								break;
							case 1u:
								_003C_003Ec__DisplayClass20_0.smethod_8(_003C_003Ec__DisplayClass20_0.smethod_7((_7UlnfykmEmZDFt3BmCKZekI43Ih)_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA), "You did not select a template!", 500, "OK", (Action)null);
								num16 = ((int)num17 * -1260685864) ^ -2036454597;
								continue;
							case 0u:
								goto IL_0080;
							default:
								return;
							case 2u:
								return;
							case 3u:
								return;
							}
							break;
						}
						goto IL_000e;
						IL_000e:
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._yA2ISabBQiVKBxMt5AXSybmkG5o(_003C_003Ec__DisplayClass20_0.smethod_9("Are you sure you wish to delete the selected template '{0}'?", (object)_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._q9fwz0K4rjUrAm9v3Dn6azqJaIN._6qwooGF3jWmbG9887Y5IKZ8fJ0E(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._QjFuG8JMGq8rGnavgUdgnBEKBfD)), delegate
						{
							_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._q9fwz0K4rjUrAm9v3Dn6azqJaIN._FzyCgzYhOXEADaijk8VbcLulpcBA(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._QjFuG8JMGq8rGnavgUdgnBEKBfD);
							_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._QjFuG8JMGq8rGnavgUdgnBEKBfD = -1;
							((ActiveList<Control>)(object)_003C_003Ec__DisplayClass20_0.smethod_2(_003C_003Ec__DisplayClass20_0.smethod_1(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._TbkP67ntBpYJu1M27pBfsYAHmgJ))).Clear();
							while (true)
							{
								int num18 = 682732931;
								while (true)
								{
									uint num19;
									switch ((num19 = (uint)num18 ^ 0x3465CA5Du) % 3u)
									{
									case 1u:
										goto IL_0043;
									default:
										return;
									case 0u:
										break;
									case 2u:
										return;
									}
									break;
									IL_0043:
									_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._OBIbaNO8X49ahEZ5n3Ta8HUK7mO(_7y2pwnzdnnIdP3bK7MDiAAyPF9BA);
									num18 = ((int)num19 * -1439551341) ^ 0x24D5417;
								}
							}
						});
						num16 = -261246755;
						goto IL_0085;
					});
					((ActiveList<Control>)(object)_7y2pwnzdnnIdP3bK7MDiAAyPF9BA).Add((Control)(object)val10);
					num = (int)(num2 * 306684514) ^ -80996753;
					continue;
				case 9u:
				{
					((ActiveList<Control>)(object)_7y2pwnzdnnIdP3bK7MDiAAyPF9BA).Add((Control)(object)val2);
					Button val9 = new Button();
					((Control)val9).set_Dock((DockStyle)2);
					((Label)val9).set_Text("Delete Template");
					val10 = val9;
					num = (int)((num2 * 133272619) ^ 0x166F5D23);
					continue;
				}
				case 8u:
				{
					((ActiveList<Control>)(object)_7y2pwnzdnnIdP3bK7MDiAAyPF9BA).Add((Control)(object)val6);
					int num3;
					int num4;
					if (!_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
					{
						num3 = 238051712;
						num4 = 238051712;
					}
					else
					{
						num3 = 1128898346;
						num4 = 1128898346;
					}
					num = num3 ^ ((int)num2 * -1977176145);
					continue;
				}
				case 7u:
					((ActiveList<Control>)(object)_7y2pwnzdnnIdP3bK7MDiAAyPF9BA).Add((Control)(object)val7);
					num = (int)(num2 * 254945313) ^ -1304791305;
					continue;
				case 6u:
					((Control)val7).add_MouseClick((MouseEvent)delegate
					{
						if (_003C_003Ec__DisplayClass20_0.smethod_6(_003C_003Ec__DisplayClass20_0.smethod_0(_Z0ib1EsNAOHar3w2AfvKgeb8s2BA)))
						{
							while (true)
							{
								int num29 = 1567108392;
								while (true)
								{
									uint num30;
									switch ((num30 = (uint)num29 ^ 0x3A936FF6u) % 4u)
									{
									case 2u:
										_003C_003Ec__DisplayClass20_0.smethod_8(_003C_003Ec__DisplayClass20_0.smethod_7((_7UlnfykmEmZDFt3BmCKZekI43Ih)_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA), "You did not enter a name!", 500, "OK", (Action)null);
										num29 = ((int)num30 * -1556883230) ^ 0x11424F29;
										continue;
									case 0u:
										break;
									case 3u:
										return;
									default:
										goto end_IL_0064;
									}
									break;
								}
								continue;
								end_IL_0064:
								break;
							}
						}
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._yA2ISabBQiVKBxMt5AXSybmkG5o(_003C_003Ec__DisplayClass20_0.smethod_9("Are you sure you wish to create a new template with the name '{0}', based on the current character?", (object)_003C_003Ec__DisplayClass20_0.smethod_0(_Z0ib1EsNAOHar3w2AfvKgeb8s2BA)), delegate
						{
							_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._q9fwz0K4rjUrAm9v3Dn6azqJaIN._0S3oMrwxDtOTcbzkglSllPfRq53(_003C_003Ec__DisplayClass20_0.smethod_0(_Z0ib1EsNAOHar3w2AfvKgeb8s2BA), _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3t4w2BwPGr8GQDmJlQU929IFD8f._dxo6sBOpjEUiw2JBMikbutXK44t());
							while (true)
							{
								int num31 = 1371107812;
								while (true)
								{
									uint num32;
									switch ((num32 = (uint)num31 ^ 0x6410769Fu) % 6u)
									{
									case 4u:
										_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._q9fwz0K4rjUrAm9v3Dn6azqJaIN._BCRMBb9uhQZrQlfdXPidu27yb8C(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._QjFuG8JMGq8rGnavgUdgnBEKBfD);
										_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3t4w2BwPGr8GQDmJlQU929IFD8f._RB8fRXeQvK5vs7JEA0XfVCEpg1i = _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._q9fwz0K4rjUrAm9v3Dn6azqJaIN._6qwooGF3jWmbG9887Y5IKZ8fJ0E(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._QjFuG8JMGq8rGnavgUdgnBEKBfD);
										num31 = ((int)num32 * -889995323) ^ -573530605;
										continue;
									case 2u:
										_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._OBIbaNO8X49ahEZ5n3Ta8HUK7mO(_7y2pwnzdnnIdP3bK7MDiAAyPF9BA);
										num31 = ((int)num32 * -172084625) ^ 0x14A663DC;
										continue;
									case 1u:
										_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._QjFuG8JMGq8rGnavgUdgnBEKBfD = _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._q9fwz0K4rjUrAm9v3Dn6azqJaIN._I6gsCHlb2BKFCJSAk9Cn5fCMAPu.Count() - 1;
										num31 = (int)(num32 * 1363657772) ^ -1075958165;
										continue;
									case 0u:
										((ActiveList<Control>)(object)_003C_003Ec__DisplayClass20_0.smethod_2(_003C_003Ec__DisplayClass20_0.smethod_1(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._TbkP67ntBpYJu1M27pBfsYAHmgJ))).Clear();
										num31 = (int)(num32 * 1953342902) ^ -314852817;
										continue;
									default:
										return;
									case 3u:
										break;
									case 5u:
										return;
									}
									break;
								}
							}
						});
					});
					num = (int)(num2 * 321137249) ^ -140429816;
					continue;
				case 5u:
					_7y2pwnzdnnIdP3bK7MDiAAyPF9BA = controlCollection_0;
					num = (int)((num2 * 1335942038) ^ 0x3C627FF);
					continue;
				case 4u:
				{
					Button val5 = new Button();
					((Control)val5).set_Margin(new Margin(0, 10, 0, 0));
					((Control)val5).set_Dock((DockStyle)2);
					((Label)val5).set_Text("Toggle zoom");
					val6 = val5;
					num = ((int)num2 * -421587204) ^ 0x7396994D;
					continue;
				}
				case 3u:
				{
					Button val3 = new Button();
					((Control)val3).set_Margin(new Margin(0, 10, 0, 0));
					((Control)val3).set_Dock((DockStyle)2);
					((Label)val3).set_Text(Amorous_002EGame_002EScenes_002EPlayerCustomizationScene_002E_l3SUNsFudHnZpYO0ErWgbTaz1DF);
					((Control)val3).set_Style("button2");
					val4 = val3;
					num = 51341724;
					continue;
				}
				case 2u:
					_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = this;
					num = (int)(num2 * 1269514041) ^ -1850388228;
					continue;
				case 1u:
				{
					TextBox obj = PlayerCustomizationScene.smethod_26();
					PlayerCustomizationScene.smethod_23((Control)(object)obj, (DockStyle)2);
					PlayerCustomizationScene.smethod_27(obj, _3t4w2BwPGr8GQDmJlQU929IFD8f._RB8fRXeQvK5vs7JEA0XfVCEpg1i);
					((Control)obj).set_Margin(new Margin(0, 0, 0, 5));
					_Z0ib1EsNAOHar3w2AfvKgeb8s2BA = obj;
					_Z0ib1EsNAOHar3w2AfvKgeb8s2BA.add_TextChanged((VoidEvent)delegate
					{
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3t4w2BwPGr8GQDmJlQU929IFD8f._RB8fRXeQvK5vs7JEA0XfVCEpg1i = _003C_003Ec__DisplayClass20_0.smethod_0(_Z0ib1EsNAOHar3w2AfvKgeb8s2BA);
					});
					((ActiveList<Control>)(object)_7y2pwnzdnnIdP3bK7MDiAAyPF9BA).Add((Control)(object)_Z0ib1EsNAOHar3w2AfvKgeb8s2BA);
					num = ((int)num2 * -450799333) ^ 0x583E88A;
					continue;
				}
				case 0u:
				{
					Button val = new Button();
					((Control)val).set_Dock((DockStyle)2);
					((Label)val).set_Text("Reset Template");
					val2 = val;
					((Control)val2).add_MouseClick((MouseEvent)delegate
					{
						if (_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._QjFuG8JMGq8rGnavgUdgnBEKBfD >= 0)
						{
							goto IL_000e;
						}
						goto IL_0080;
						IL_0080:
						int num33 = 1404571358;
						goto IL_0085;
						IL_0085:
						while (true)
						{
							uint num34;
							switch ((num34 = (uint)num33 ^ 0x7EE006AFu) % 5u)
							{
							case 3u:
								break;
							case 4u:
								_003C_003Ec__DisplayClass20_0.smethod_8(_003C_003Ec__DisplayClass20_0.smethod_7((_7UlnfykmEmZDFt3BmCKZekI43Ih)_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA), "You did not select a template!", 500, "OK", (Action)null);
								num33 = ((int)num34 * -724998382) ^ -382658402;
								continue;
							case 2u:
								goto IL_0080;
							default:
								return;
							case 0u:
								return;
							case 1u:
								return;
							}
							break;
						}
						goto IL_000e;
						IL_000e:
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._yA2ISabBQiVKBxMt5AXSybmkG5o(_003C_003Ec__DisplayClass20_0.smethod_9("Are you sure you wish to reset the current character back to selected template '{0}'? All changes will be lost!", (object)_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._q9fwz0K4rjUrAm9v3Dn6azqJaIN._6qwooGF3jWmbG9887Y5IKZ8fJ0E(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._QjFuG8JMGq8rGnavgUdgnBEKBfD)), delegate
						{
							_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._q9fwz0K4rjUrAm9v3Dn6azqJaIN._JC60lfB4LT6VifObN1Ynm6iARlc(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._QjFuG8JMGq8rGnavgUdgnBEKBfD);
							_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3t4w2BwPGr8GQDmJlQU929IFD8f._RB8fRXeQvK5vs7JEA0XfVCEpg1i = _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._q9fwz0K4rjUrAm9v3Dn6azqJaIN._6qwooGF3jWmbG9887Y5IKZ8fJ0E(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._QjFuG8JMGq8rGnavgUdgnBEKBfD);
							((ActiveList<Control>)(object)_003C_003Ec__DisplayClass20_0.smethod_2(_003C_003Ec__DisplayClass20_0.smethod_1(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._TbkP67ntBpYJu1M27pBfsYAHmgJ))).Clear();
							_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._OBIbaNO8X49ahEZ5n3Ta8HUK7mO(_7y2pwnzdnnIdP3bK7MDiAAyPF9BA);
						});
						num33 = 514981595;
						goto IL_0085;
					});
					num = ((int)num2 * -1658693159) ^ -663796946;
					continue;
				}
				default:
					return;
				case 14u:
					break;
				case 20u:
					return;
				}
				break;
			}
		}
	}

	private void _yA2ISabBQiVKBxMt5AXSybmkG5o(string string_0, Action action_0)
	{
		PlayerCustomizationScene.smethod_29(PlayerCustomizationScene.smethod_28((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), string_0, new string[2] { "No way!", "Yes please!" }, 500, (Action<int>)delegate(int int_0)
		{
			if (int_0 == 1)
			{
				while (true)
				{
					int num = 1161806028;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x2EC557F6u) % 3u)
						{
						case 2u:
							goto IL_0006;
						default:
							return;
						case 0u:
							break;
						case 1u:
							return;
						}
						break;
						IL_0006:
						action_0();
						num = (int)(num2 * 1865086227) ^ -1445889731;
					}
				}
			}
		});
	}

	protected virtual void _n3b8BstkorCsu4TW0U2YVdFbdGp()
	{
		PlayerCustomizationScene.smethod_29(PlayerCustomizationScene.smethod_28((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "Are you sure you wish to exit? All unsaved changes will be lost!", new string[2] { "Oops, my bad!", "Yes please!" }, 500, (Action<int>)delegate(int int_0)
		{
			if (int_0 == 1)
			{
				while (true)
				{
					int num = -1119413093;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0xF405B827u) % 3u)
						{
						case 2u:
							goto IL_0006;
						default:
							return;
						case 0u:
							break;
						case 1u:
							return;
						}
						break;
						IL_0006:
						PlayerCustomizationScene.smethod_20((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._k9wUPeU1Ga7cygiuGP8TT6aPLWF<MainMenuScene>();
						num = (int)(num2 * 257050640) ^ -437346073;
					}
				}
			}
		});
	}

	private void _jiNxMIzuA8Rrc2ULsrob5A7UNDe(ControlCollection controlCollection_0)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Body", _3t4w2BwPGr8GQDmJlQU929IFD8f._8CtoV1bqn0CwCzb1tuoNppBt0Gg, delegate(_opIJo2jLUqdOL5yAFP4yzXce0DG.EBodyType ebodyType_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._8CtoV1bqn0CwCzb1tuoNppBt0Gg = ebodyType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Body Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._6f1rvTENt5XWmHTE22zxBIwbH9G, delegate(Color color_0)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._6f1rvTENt5XWmHTE22zxBIwbH9G = color_0;
		});
		while (true)
		{
			int num = -647171186;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD4772671u) % 6u)
				{
				case 4u:
					_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Underthigh Marking", _opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Underthigh, _3t4w2BwPGr8GQDmJlQU929IFD8f._zBv1cYqPRU7uDCALpBlBSgObUcbA, delegate(Color color_0)
					{
						//IL_0006: Unknown result type (might be due to invalid IL or missing references)
						_3t4w2BwPGr8GQDmJlQU929IFD8f._zBv1cYqPRU7uDCALpBlBSgObUcbA = color_0;
					});
					num = ((int)num2 * -330293909) ^ 0x1EE7F59B;
					continue;
				case 3u:
					_HdTJZZGoOMNi89T0yAdBraCZMjc(controlCollection_0, "Nails", _3t4w2BwPGr8GQDmJlQU929IFD8f._VmNLhqrIwSnE6JnCYiBcxnSqnEV, _3t4w2BwPGr8GQDmJlQU929IFD8f._in5HHYmrdLTFpkgc8aimJpXqAXB, delegate(bool bool_0)
					{
						_3t4w2BwPGr8GQDmJlQU929IFD8f._VmNLhqrIwSnE6JnCYiBcxnSqnEV = bool_0;
					}, delegate(Color color_0)
					{
						//IL_0006: Unknown result type (might be due to invalid IL or missing references)
						_3t4w2BwPGr8GQDmJlQU929IFD8f._in5HHYmrdLTFpkgc8aimJpXqAXB = color_0;
					});
					num = ((int)num2 * -1327976391) ^ 0x5E8D94C1;
					continue;
				case 2u:
					_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Stripes Marking", _opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Stripes, _3t4w2BwPGr8GQDmJlQU929IFD8f._TxfCqloeyiHpsXka6B46iqCZNsZ, delegate(Color color_0)
					{
						//IL_0006: Unknown result type (might be due to invalid IL or missing references)
						_3t4w2BwPGr8GQDmJlQU929IFD8f._TxfCqloeyiHpsXka6B46iqCZNsZ = color_0;
					});
					num = ((int)num2 * -1573795245) ^ 0x50C44824;
					continue;
				case 1u:
					_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Underbelly Marking", _opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Underbelly, _3t4w2BwPGr8GQDmJlQU929IFD8f._PeK36AvFxEQCvX3fS62hNV7rpuJ, delegate(Color color_0)
					{
						//IL_0006: Unknown result type (might be due to invalid IL or missing references)
						_3t4w2BwPGr8GQDmJlQU929IFD8f._PeK36AvFxEQCvX3fS62hNV7rpuJ = color_0;
					});
					num = (int)(num2 * 1220090018) ^ -1594547889;
					continue;
				default:
					return;
				case 0u:
					break;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	private void _1qIQUjhrbk5WA7C7mYs93gXLOIe(ControlCollection controlCollection_0)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
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
		while (true)
		{
			int num = 1506633110;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1EC3711Fu) % 3u)
				{
				case 2u:
					goto IL_0051;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0051:
				_9x3XvoSKr9dMOykq9pl8AKFzwJ(controlCollection_0, "Avian Shin Marking", _opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.AvianShin, _3t4w2BwPGr8GQDmJlQU929IFD8f._meyNS02iTIxo212B6c5eoKns2wj, delegate(Color color_0)
				{
					//IL_0006: Unknown result type (might be due to invalid IL or missing references)
					_3t4w2BwPGr8GQDmJlQU929IFD8f._meyNS02iTIxo212B6c5eoKns2wj = color_0;
				});
				num = (int)(num2 * 816261125) ^ -302905168;
			}
		}
	}

	private void _vXrWU56trsuFNc9CNcHuctfkI2S(ControlCollection controlCollection_0)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		PlayerCustomizationScene _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = default(PlayerCustomizationScene);
		Panel _5DnedRtrhRxc4WXg7XVOkddr43f = default(Panel);
		Panel _KH5vstJZR49J3eWlwNclJbU5SDe = default(Panel);
		while (true)
		{
			int num = -446248248;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAAA1B2CFu) % 11u)
				{
				case 10u:
					_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Head Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._1qfGl3Oc2JyQEpnQtdOxMeMkqhi, delegate(Color color_0)
					{
						//IL_000b: Unknown result type (might be due to invalid IL or missing references)
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3t4w2BwPGr8GQDmJlQU929IFD8f._1qfGl3Oc2JyQEpnQtdOxMeMkqhi = color_0;
					});
					num = (int)((num2 * 476479877) ^ 0x17D39B6E);
					continue;
				case 9u:
					_h7MUbT306Ju5xwvamN8SatTR2Mo(PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_5DnedRtrhRxc4WXg7XVOkddr43f)), "Snout Marking", _opIJo2jLUqdOL5yAFP4yzXce0DG._iDe3W6qb7jKTPuJV79yf2i7UoIq.Snout, _3t4w2BwPGr8GQDmJlQU929IFD8f._lUyqwDvFCoXEZ6VM9PVCQ970jps, delegate(Color color_0)
					{
						//IL_000b: Unknown result type (might be due to invalid IL or missing references)
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3t4w2BwPGr8GQDmJlQU929IFD8f._lUyqwDvFCoXEZ6VM9PVCQ970jps = color_0;
					});
					num = (int)((num2 * 290136431) ^ 0x2EE8B3AF);
					continue;
				case 8u:
					_h7MUbT306Ju5xwvamN8SatTR2Mo(PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_5DnedRtrhRxc4WXg7XVOkddr43f)), "Gaunt Marking", _opIJo2jLUqdOL5yAFP4yzXce0DG._iDe3W6qb7jKTPuJV79yf2i7UoIq.Gaunt, _3t4w2BwPGr8GQDmJlQU929IFD8f._Fn7Kt1UvxcXOmJ1gIeWdJnRbaQt, delegate(Color color_0)
					{
						//IL_000b: Unknown result type (might be due to invalid IL or missing references)
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3t4w2BwPGr8GQDmJlQU929IFD8f._Fn7Kt1UvxcXOmJ1gIeWdJnRbaQt = color_0;
					});
					_h7MUbT306Ju5xwvamN8SatTR2Mo(PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_5DnedRtrhRxc4WXg7XVOkddr43f)), "Scruffy Marking", _opIJo2jLUqdOL5yAFP4yzXce0DG._iDe3W6qb7jKTPuJV79yf2i7UoIq.Scruffy, _3t4w2BwPGr8GQDmJlQU929IFD8f._WvoLJ4MA4gYEsgOmmIQvfK3xFlu, delegate(Color color_0)
					{
						//IL_000b: Unknown result type (might be due to invalid IL or missing references)
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3t4w2BwPGr8GQDmJlQU929IFD8f._WvoLJ4MA4gYEsgOmmIQvfK3xFlu = color_0;
					});
					num = ((int)num2 * -1205282038) ^ 0x36D160DD;
					continue;
				case 7u:
					_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Head", _3t4w2BwPGr8GQDmJlQU929IFD8f._UjtZovBCLAtBZnUfbTvRFsaf5mx, delegate(_opIJo2jLUqdOL5yAFP4yzXce0DG.EHeadType eheadType_0)
					{
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3t4w2BwPGr8GQDmJlQU929IFD8f._UjtZovBCLAtBZnUfbTvRFsaf5mx = eheadType_0;
						int num3;
						switch (eheadType_0)
						{
						case _opIJo2jLUqdOL5yAFP4yzXce0DG.EHeadType.Humanoid:
							_003C_003Ec__DisplayClass26_0.smethod_0((Control)(object)_5DnedRtrhRxc4WXg7XVOkddr43f, bool_0: false);
							num3 = 1487123266;
							goto IL_00a1;
						case _opIJo2jLUqdOL5yAFP4yzXce0DG.EHeadType.Default:
							goto IL_0089;
						default:
							goto IL_009c;
						case _opIJo2jLUqdOL5yAFP4yzXce0DG.EHeadType.PaperBag:
							goto IL_00df;
							IL_00a1:
							while (true)
							{
								uint num4;
								switch ((num4 = (uint)num3 ^ 0x3FB380A7u) % 11u)
								{
								case 9u:
									break;
								case 7u:
									_003C_003Ec__DisplayClass26_0.smethod_0((Control)(object)_KH5vstJZR49J3eWlwNclJbU5SDe, bool_0: false);
									num3 = (int)((num4 * 1393511867) ^ 0x3CBBB89C);
									continue;
								case 6u:
									_003C_003Ec__DisplayClass26_0.smethod_0((Control)(object)_KH5vstJZR49J3eWlwNclJbU5SDe, bool_0: false);
									num3 = ((int)num4 * -2103991609) ^ 0x6185960D;
									continue;
								case 5u:
									_003C_003Ec__DisplayClass26_0.smethod_0((Control)(object)_KH5vstJZR49J3eWlwNclJbU5SDe, bool_0: true);
									num3 = ((int)num4 * -1921383276) ^ 0x659E0807;
									continue;
								case 4u:
									goto IL_0089;
								case 0u:
									goto IL_009c;
								default:
									return;
								case 8u:
									goto IL_00df;
								case 1u:
									return;
								case 2u:
									return;
								case 3u:
									return;
								case 10u:
									return;
								}
								break;
							}
							goto case _opIJo2jLUqdOL5yAFP4yzXce0DG.EHeadType.Humanoid;
							IL_00df:
							_003C_003Ec__DisplayClass26_0.smethod_0((Control)(object)_5DnedRtrhRxc4WXg7XVOkddr43f, bool_0: false);
							num3 = 1083410484;
							goto IL_00a1;
							IL_009c:
							num3 = 977229671;
							goto IL_00a1;
							IL_0089:
							_003C_003Ec__DisplayClass26_0.smethod_0((Control)(object)_5DnedRtrhRxc4WXg7XVOkddr43f, bool_0: true);
							num3 = 1025335555;
							goto IL_00a1;
						}
					});
					num = (int)((num2 * 1600450992) ^ 0x24403A90);
					continue;
				case 5u:
					_z5npzs7mj5H3zJ1PF64BFNsXBmm(PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_KH5vstJZR49J3eWlwNclJbU5SDe)), "Eyesholes Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._sbSAaAmkhONcFX6f0JtHbVQbEfG, delegate(Color color_0)
					{
						//IL_000b: Unknown result type (might be due to invalid IL or missing references)
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3t4w2BwPGr8GQDmJlQU929IFD8f._sbSAaAmkhONcFX6f0JtHbVQbEfG = color_0;
					});
					((ActiveList<Control>)(object)controlCollection_0).Add((Control)(object)_5DnedRtrhRxc4WXg7XVOkddr43f);
					((ActiveList<Control>)(object)controlCollection_0).Add((Control)(object)_KH5vstJZR49J3eWlwNclJbU5SDe);
					num = (int)(num2 * 1356144737) ^ -1446726226;
					continue;
				case 3u:
					_h7MUbT306Ju5xwvamN8SatTR2Mo(PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_5DnedRtrhRxc4WXg7XVOkddr43f)), "Stripes Marking", _opIJo2jLUqdOL5yAFP4yzXce0DG._iDe3W6qb7jKTPuJV79yf2i7UoIq.Stripes, _3t4w2BwPGr8GQDmJlQU929IFD8f._qKGefHxdjIUD6ObjxrxnLwbBEsh, delegate(Color color_0)
					{
						//IL_000b: Unknown result type (might be due to invalid IL or missing references)
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3t4w2BwPGr8GQDmJlQU929IFD8f._qKGefHxdjIUD6ObjxrxnLwbBEsh = color_0;
					});
					num = (int)(num2 * 581255072) ^ -1051160619;
					continue;
				case 2u:
				{
					Panel obj = PlayerCustomizationScene.smethod_30();
					PlayerCustomizationScene.smethod_23((Control)(object)obj, (DockStyle)5);
					PlayerCustomizationScene.smethod_31((Control)(object)obj, _3t4w2BwPGr8GQDmJlQU929IFD8f._UjtZovBCLAtBZnUfbTvRFsaf5mx == _opIJo2jLUqdOL5yAFP4yzXce0DG.EHeadType.Default);
					_5DnedRtrhRxc4WXg7XVOkddr43f = obj;
					Panel obj2 = PlayerCustomizationScene.smethod_30();
					PlayerCustomizationScene.smethod_23((Control)(object)obj2, (DockStyle)5);
					PlayerCustomizationScene.smethod_31((Control)(object)obj2, _3t4w2BwPGr8GQDmJlQU929IFD8f._UjtZovBCLAtBZnUfbTvRFsaf5mx == _opIJo2jLUqdOL5yAFP4yzXce0DG.EHeadType.PaperBag);
					_KH5vstJZR49J3eWlwNclJbU5SDe = obj2;
					num = (int)((num2 * 1569567760) ^ 0x41B8A697);
					continue;
				}
				case 1u:
					_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = this;
					num = ((int)num2 * -1051481546) ^ -696687821;
					continue;
				case 0u:
					_z5npzs7mj5H3zJ1PF64BFNsXBmm(PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_KH5vstJZR49J3eWlwNclJbU5SDe)), "Paper Bag Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._VWdlqWB4z2wNtm197Oiv32QGVbE, delegate(Color color_0)
					{
						//IL_000b: Unknown result type (might be due to invalid IL or missing references)
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3t4w2BwPGr8GQDmJlQU929IFD8f._VWdlqWB4z2wNtm197Oiv32QGVbE = color_0;
					});
					num = (int)((num2 * 1719623581) ^ 0x40EEC2FD);
					continue;
				default:
					return;
				case 4u:
					break;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	private void _vg6ASaP7xNqc0jerF3mcrXv4dn7(ControlCollection controlCollection_0)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Muzzle", _3t4w2BwPGr8GQDmJlQU929IFD8f._4QUr9lDqmNxEuy7B4xgb7Lj1HU0, delegate(_opIJo2jLUqdOL5yAFP4yzXce0DG.EMuzzleType emuzzleType_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._4QUr9lDqmNxEuy7B4xgb7Lj1HU0 = emuzzleType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Muzzle Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._VsEYbNSam3IFYYWY4QC2lb4ia61, delegate(Color color_0)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._VsEYbNSam3IFYYWY4QC2lb4ia61 = color_0;
		});
		while (true)
		{
			int num = -154804897;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCCEC0A40u) % 4u)
				{
				case 3u:
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
					num = ((int)num2 * -1708515340) ^ -621933188;
					continue;
				case 0u:
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
					num = ((int)num2 * -733152232) ^ 0x3F4C4A1D;
					continue;
				default:
					return;
				case 2u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	private void _Xhurp3mVVoR5kNlnxgLoDDkeQxM(ControlCollection controlCollection_0)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
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
		while (true)
		{
			int num = -857074191;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE492274Eu) % 3u)
				{
				case 2u:
					goto IL_0070;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0070:
				_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Ear Inner Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._uaBF7rEib15d42vH8AzoXWFMMkE, delegate(Color color_0)
				{
					//IL_0006: Unknown result type (might be due to invalid IL or missing references)
					_3t4w2BwPGr8GQDmJlQU929IFD8f._uaBF7rEib15d42vH8AzoXWFMMkE = color_0;
				});
				num = (int)(num2 * 836641766) ^ -1432348187;
			}
		}
	}

	private void _gHA9C0CRN2NaRMtfTrvlotJOd0T(ControlCollection controlCollection_0)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Hair", _3t4w2BwPGr8GQDmJlQU929IFD8f._03h2I0mTkGTzIA5R48rgwJh7JZA, delegate(_opIJo2jLUqdOL5yAFP4yzXce0DG.EHairstyleType ehairstyleType_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._03h2I0mTkGTzIA5R48rgwJh7JZA = ehairstyleType_0;
		});
		while (true)
		{
			int num = -1538341005;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB391C99Eu) % 4u)
				{
				case 1u:
					_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Hair Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._bJmvnPs69aVDXxG48lmruYZFHKt, delegate(Color color_0)
					{
						//IL_0006: Unknown result type (might be due to invalid IL or missing references)
						_3t4w2BwPGr8GQDmJlQU929IFD8f._bJmvnPs69aVDXxG48lmruYZFHKt = color_0;
					});
					_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Fringe", _3t4w2BwPGr8GQDmJlQU929IFD8f._fzMbZCCd7imnrcrYWkSj5u8UZ2J, delegate(_opIJo2jLUqdOL5yAFP4yzXce0DG.EFringeType efringeType_0)
					{
						_3t4w2BwPGr8GQDmJlQU929IFD8f._fzMbZCCd7imnrcrYWkSj5u8UZ2J = efringeType_0;
					});
					num = ((int)num2 * -1895455439) ^ -2030303005;
					continue;
				case 0u:
					_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Fringe Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._EvdUMrkAAdTeMv6fOpGrOLCAMq8A, delegate(Color color_0)
					{
						//IL_0006: Unknown result type (might be due to invalid IL or missing references)
						_3t4w2BwPGr8GQDmJlQU929IFD8f._EvdUMrkAAdTeMv6fOpGrOLCAMq8A = color_0;
					});
					num = (int)((num2 * 1379364939) ^ 0x3799D8FC);
					continue;
				default:
					return;
				case 3u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private void _hNo7o9fG9jvwcKyMq1nYl4q7cXc(ControlCollection controlCollection_0)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Eyes", _3t4w2BwPGr8GQDmJlQU929IFD8f._c0ThYURHAGN0Wzlzw9Ibh3Z8qyo, delegate(_opIJo2jLUqdOL5yAFP4yzXce0DG.EEyesType eeyesType_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._c0ThYURHAGN0Wzlzw9Ibh3Z8qyo = eeyesType_0;
		});
		while (true)
		{
			int num = -1535839515;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDB859BE1u) % 5u)
				{
				case 2u:
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
					num = ((int)num2 * -1382836480) ^ -896115478;
					continue;
				case 1u:
					_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Brows", _3t4w2BwPGr8GQDmJlQU929IFD8f._KBOJ0qhM8C5evPQxibgX74m2WHg, delegate(_opIJo2jLUqdOL5yAFP4yzXce0DG.EBrowType ebrowType_0)
					{
						_3t4w2BwPGr8GQDmJlQU929IFD8f._KBOJ0qhM8C5evPQxibgX74m2WHg = ebrowType_0;
					});
					num = ((int)num2 * -1752776231) ^ 0x5521BF2D;
					continue;
				case 0u:
					_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Brows Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._HRPv5rzDY5zNiP4NADDEGhrzGTe, delegate(Color color_0)
					{
						//IL_0006: Unknown result type (might be due to invalid IL or missing references)
						_3t4w2BwPGr8GQDmJlQU929IFD8f._HRPv5rzDY5zNiP4NADDEGhrzGTe = color_0;
					});
					num = (int)((num2 * 2128053924) ^ 0x67B3CE93);
					continue;
				default:
					return;
				case 4u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	private void _mWS8UuA4xcT1bSdjDObiubOE0wH(ControlCollection controlCollection_0)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		Control _Jhlc8lMI1rq07omae9xc6uig5tv = default(Control);
		Panel _TLsIePSD9UbEwlT0HwKiF2xZX87 = default(Panel);
		PlayerCustomizationScene _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = default(PlayerCustomizationScene);
		Panel _63PX0QXRoq6jeUvG5xheRABNwsg = default(Panel);
		Panel _s9TeQxnG80yYnmcOHHr4bw9fWCh = default(Panel);
		while (true)
		{
			int num = -1462017842;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE017D15Au) % 14u)
				{
				case 13u:
					_Jhlc8lMI1rq07omae9xc6uig5tv = _z5npzs7mj5H3zJ1PF64BFNsXBmm(PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_TLsIePSD9UbEwlT0HwKiF2xZX87)), "Cock Tip Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._o6OnmHi5rZIQPHESokp9rTaO1ei, delegate(Color color_0)
					{
						//IL_000b: Unknown result type (might be due to invalid IL or missing references)
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3t4w2BwPGr8GQDmJlQU929IFD8f._o6OnmHi5rZIQPHESokp9rTaO1ei = color_0;
					});
					num = (int)(num2 * 1298059900) ^ -2031765222;
					continue;
				case 12u:
					((ActiveList<Control>)(object)controlCollection_0).Add((Control)(object)_TLsIePSD9UbEwlT0HwKiF2xZX87);
					num = (int)((num2 * 1508786066) ^ 0x7A14DADC);
					continue;
				case 11u:
					_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Breasts", _3t4w2BwPGr8GQDmJlQU929IFD8f._BCncLn6BIYiBX6NdFByAquBYGpH, delegate(_opIJo2jLUqdOL5yAFP4yzXce0DG.EBreastsType ebreastsType_0)
					{
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3t4w2BwPGr8GQDmJlQU929IFD8f._BCncLn6BIYiBX6NdFByAquBYGpH = ebreastsType_0;
						_003C_003Ec__DisplayClass31_0.smethod_0((Control)(object)_63PX0QXRoq6jeUvG5xheRABNwsg, _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3t4w2BwPGr8GQDmJlQU929IFD8f._BCncLn6BIYiBX6NdFByAquBYGpH != _opIJo2jLUqdOL5yAFP4yzXce0DG.EBreastsType.None);
					});
					num = ((int)num2 * -307169426) ^ -146634053;
					continue;
				case 9u:
					_Jhlc8lMI1rq07omae9xc6uig5tv = null;
					num = ((int)num2 * -245047076) ^ 0x63795493;
					continue;
				case 8u:
				{
					Panel obj3 = PlayerCustomizationScene.smethod_30();
					PlayerCustomizationScene.smethod_23((Control)(object)obj3, (DockStyle)2);
					PlayerCustomizationScene.smethod_31((Control)(object)obj3, _3t4w2BwPGr8GQDmJlQU929IFD8f._rtyJgfViJdXL2Ela5APpDlk99dI != _opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType.None);
					_TLsIePSD9UbEwlT0HwKiF2xZX87 = obj3;
					num = ((int)num2 * -529031821) ^ -1499439126;
					continue;
				}
				case 7u:
					_z5npzs7mj5H3zJ1PF64BFNsXBmm(PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_63PX0QXRoq6jeUvG5xheRABNwsg)), "Breasts Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._pigzqi6DgcSToQkL9g7Ns2QrLfp, delegate(Color color_0)
					{
						//IL_000b: Unknown result type (might be due to invalid IL or missing references)
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3t4w2BwPGr8GQDmJlQU929IFD8f._pigzqi6DgcSToQkL9g7Ns2QrLfp = color_0;
					});
					num = ((int)num2 * -445094049) ^ 0x4C72F389;
					continue;
				case 6u:
				{
					_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = this;
					Panel obj2 = PlayerCustomizationScene.smethod_30();
					PlayerCustomizationScene.smethod_23((Control)(object)obj2, (DockStyle)2);
					PlayerCustomizationScene.smethod_31((Control)(object)obj2, _3t4w2BwPGr8GQDmJlQU929IFD8f._BCncLn6BIYiBX6NdFByAquBYGpH != _opIJo2jLUqdOL5yAFP4yzXce0DG.EBreastsType.None);
					_63PX0QXRoq6jeUvG5xheRABNwsg = obj2;
					num = (int)((num2 * 763924720) ^ 0x28D58C28);
					continue;
				}
				case 5u:
					((ActiveList<Control>)(object)controlCollection_0).Add((Control)(object)_63PX0QXRoq6jeUvG5xheRABNwsg);
					num = ((int)num2 * -512819727) ^ 0x47AE572A;
					continue;
				case 4u:
					_HdTJZZGoOMNi89T0yAdBraCZMjc(PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_63PX0QXRoq6jeUvG5xheRABNwsg)), "Nipples", _3t4w2BwPGr8GQDmJlQU929IFD8f._Q2AbpMWcrhtCW9MLTtT5gwoleu7, _3t4w2BwPGr8GQDmJlQU929IFD8f._2yydfEIrSiLPTti2dT8JXGoIaM3, delegate(bool bool_0)
					{
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3t4w2BwPGr8GQDmJlQU929IFD8f._Q2AbpMWcrhtCW9MLTtT5gwoleu7 = bool_0;
					}, delegate(Color color_0)
					{
						//IL_000b: Unknown result type (might be due to invalid IL or missing references)
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3t4w2BwPGr8GQDmJlQU929IFD8f._2yydfEIrSiLPTti2dT8JXGoIaM3 = color_0;
					});
					num = (int)(num2 * 910600747) ^ -2046150147;
					continue;
				case 2u:
					PlayerCustomizationScene.smethod_31(_Jhlc8lMI1rq07omae9xc6uig5tv, _3t4w2BwPGr8GQDmJlQU929IFD8f._rtyJgfViJdXL2Ela5APpDlk99dI == _opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType.Cut || _3t4w2BwPGr8GQDmJlQU929IFD8f._rtyJgfViJdXL2Ela5APpDlk99dI == _opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType.Uncut);
					num = -1221509930;
					continue;
				case 1u:
					_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Cock", _3t4w2BwPGr8GQDmJlQU929IFD8f._rtyJgfViJdXL2Ela5APpDlk99dI, delegate(_opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType ecockType_0)
					{
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3t4w2BwPGr8GQDmJlQU929IFD8f._rtyJgfViJdXL2Ela5APpDlk99dI = ecockType_0;
						_003C_003Ec__DisplayClass31_0.smethod_0((Control)(object)_TLsIePSD9UbEwlT0HwKiF2xZX87, _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3t4w2BwPGr8GQDmJlQU929IFD8f._rtyJgfViJdXL2Ela5APpDlk99dI != _opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType.None);
						while (true)
						{
							int num3 = -792820908;
							while (true)
							{
								Control control_;
								bool bool_;
								switch ((uint)(num3 ^ -1747759453) % 3u)
								{
								case 2u:
									control_ = _Jhlc8lMI1rq07omae9xc6uig5tv;
									bool_ = _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3t4w2BwPGr8GQDmJlQU929IFD8f._rtyJgfViJdXL2Ela5APpDlk99dI == _opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType.Cut || _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3t4w2BwPGr8GQDmJlQU929IFD8f._rtyJgfViJdXL2Ela5APpDlk99dI == _opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType.Uncut;
									goto IL_0060;
								default:
									return;
								case 0u:
									break;
								case 1u:
									return;
								}
								break;
								IL_0060:
								_003C_003Ec__DisplayClass31_0.smethod_0(control_, bool_);
								num3 = -1811111283;
							}
						}
					});
					_z5npzs7mj5H3zJ1PF64BFNsXBmm(PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_TLsIePSD9UbEwlT0HwKiF2xZX87)), "Cock Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._XnNREK59QnV1onFFWfSUaS9WK0E, delegate(Color color_0)
					{
						//IL_000b: Unknown result type (might be due to invalid IL or missing references)
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3t4w2BwPGr8GQDmJlQU929IFD8f._XnNREK59QnV1onFFWfSUaS9WK0E = color_0;
					});
					num = ((int)num2 * -1594379362) ^ -1683838733;
					continue;
				case 0u:
				{
					Panel obj = PlayerCustomizationScene.smethod_30();
					PlayerCustomizationScene.smethod_23((Control)(object)obj, (DockStyle)2);
					PlayerCustomizationScene.smethod_31((Control)(object)obj, _3t4w2BwPGr8GQDmJlQU929IFD8f._7OCMpsMmozHsAG0GDljMMAlGLJBA != _opIJo2jLUqdOL5yAFP4yzXce0DG.EBallsType.None);
					_s9TeQxnG80yYnmcOHHr4bw9fWCh = obj;
					num = ((int)num2 * -1606227056) ^ 0x7B2C3715;
					continue;
				}
				case 3u:
					break;
				default:
					_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Balls", _3t4w2BwPGr8GQDmJlQU929IFD8f._7OCMpsMmozHsAG0GDljMMAlGLJBA, delegate(_opIJo2jLUqdOL5yAFP4yzXce0DG.EBallsType eballsType_0)
					{
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3t4w2BwPGr8GQDmJlQU929IFD8f._7OCMpsMmozHsAG0GDljMMAlGLJBA = eballsType_0;
						_003C_003Ec__DisplayClass31_0.smethod_0((Control)(object)_s9TeQxnG80yYnmcOHHr4bw9fWCh, _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3t4w2BwPGr8GQDmJlQU929IFD8f._7OCMpsMmozHsAG0GDljMMAlGLJBA != _opIJo2jLUqdOL5yAFP4yzXce0DG.EBallsType.None);
					});
					_z5npzs7mj5H3zJ1PF64BFNsXBmm(PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_s9TeQxnG80yYnmcOHHr4bw9fWCh)), "Balls Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._8qQ7XVlyRYW4icBFxPQCJqgueYD, delegate(Color color_0)
					{
						//IL_000b: Unknown result type (might be due to invalid IL or missing references)
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3t4w2BwPGr8GQDmJlQU929IFD8f._8qQ7XVlyRYW4icBFxPQCJqgueYD = color_0;
					});
					((ActiveList<Control>)(object)controlCollection_0).Add((Control)(object)_s9TeQxnG80yYnmcOHHr4bw9fWCh);
					return;
				}
				break;
			}
		}
	}

	private void _7JR6eL4D0qdIJNOwfInnlg2HEgZ(ControlCollection controlCollection_0)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Tail", _3t4w2BwPGr8GQDmJlQU929IFD8f._NrFEKLWh80bQXi9PujCBTqm01AA, delegate(_opIJo2jLUqdOL5yAFP4yzXce0DG.ETailType etailType_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._NrFEKLWh80bQXi9PujCBTqm01AA = etailType_0;
		});
		_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Tail Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._qsK1J3jktKH3eJ2i8sL1oaxXtLc, delegate(Color color_0)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			_3t4w2BwPGr8GQDmJlQU929IFD8f._qsK1J3jktKH3eJ2i8sL1oaxXtLc = color_0;
		});
		while (true)
		{
			int num = 1865668885;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7AF9A7Cu) % 4u)
				{
				case 3u:
					_HdTJZZGoOMNi89T0yAdBraCZMjc(controlCollection_0, "Tail Part B", _3t4w2BwPGr8GQDmJlQU929IFD8f._tEXwTuSRSq5JaaFE4W8edEHxS9q, _3t4w2BwPGr8GQDmJlQU929IFD8f._LufmRsAZrlyDgRKYocQXPzANMaF, delegate(bool bool_0)
					{
						_3t4w2BwPGr8GQDmJlQU929IFD8f._tEXwTuSRSq5JaaFE4W8edEHxS9q = bool_0;
					}, delegate(Color color_0)
					{
						//IL_0006: Unknown result type (might be due to invalid IL or missing references)
						_3t4w2BwPGr8GQDmJlQU929IFD8f._LufmRsAZrlyDgRKYocQXPzANMaF = color_0;
					});
					num = (int)(num2 * 791703359) ^ -250827927;
					continue;
				case 1u:
					_HdTJZZGoOMNi89T0yAdBraCZMjc(controlCollection_0, "Tail Part A", _3t4w2BwPGr8GQDmJlQU929IFD8f._PVQfhwHODkR6bzHmfeCK4L8riIG, _3t4w2BwPGr8GQDmJlQU929IFD8f._62dl1HYYkor3TZL58k5Y33Tj83, delegate(bool bool_0)
					{
						_3t4w2BwPGr8GQDmJlQU929IFD8f._PVQfhwHODkR6bzHmfeCK4L8riIG = bool_0;
					}, delegate(Color color_0)
					{
						//IL_0006: Unknown result type (might be due to invalid IL or missing references)
						_3t4w2BwPGr8GQDmJlQU929IFD8f._62dl1HYYkor3TZL58k5Y33Tj83 = color_0;
					});
					num = (int)((num2 * 762039619) ^ 0x39866DF4);
					continue;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	private void _PBEdYyzYEWcXAodjVf58ocOQ3Jf(ControlCollection controlCollection_0)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		_bABf372CnRI0x85NIaTEbIUNZ10(controlCollection_0, "Feet", _3t4w2BwPGr8GQDmJlQU929IFD8f._LZ8c6hRMRYKjnlLOPhbZHcWqUGG, delegate(_opIJo2jLUqdOL5yAFP4yzXce0DG.EFeetType efeetType_0)
		{
			_3t4w2BwPGr8GQDmJlQU929IFD8f._LZ8c6hRMRYKjnlLOPhbZHcWqUGG = efeetType_0;
		});
		while (true)
		{
			int num = 442110591;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7291AB0Cu) % 3u)
				{
				case 1u:
					goto IL_0026;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0026:
				_z5npzs7mj5H3zJ1PF64BFNsXBmm(controlCollection_0, "Feet Color", _3t4w2BwPGr8GQDmJlQU929IFD8f._LZfuQybASevOsCykEWqdvA5GqUF, delegate(Color color_0)
				{
					//IL_0006: Unknown result type (might be due to invalid IL or missing references)
					_3t4w2BwPGr8GQDmJlQU929IFD8f._LZfuQybASevOsCykEWqdvA5GqUF = color_0;
				});
				num = ((int)num2 * -41021263) ^ -397216774;
			}
		}
	}

	public void _KkwafXXLVg1QfQgqqCAojg2ySyZ(SpriteBatch spriteBatch_0)
	{
		PlayerCustomizationScene.smethod_36(PlayerCustomizationScene.smethod_35(PlayerCustomizationScene.smethod_34(_9jklVVcQQYcyqOYrkPiht2VP0IG), "Time"), _boyt8NIMtKsAGSTcjHeL0WMbFxs._AmIUCcrmrrQiiirja7DoiZSjXuv);
		while (true)
		{
			int num = -1530364818;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF7BD2591u) % 3u)
				{
				case 1u:
					goto IL_0022;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0022:
				PlayerCustomizationScene.smethod_38(PlayerCustomizationScene.smethod_37(), spriteBatch_0, _9jklVVcQQYcyqOYrkPiht2VP0IG);
				num = (int)(num2 * 721460408) ^ -714498080;
			}
		}
	}

	private void _9x3XvoSKr9dMOykq9pl8AKFzwJ(ControlCollection controlCollection_0, string string_0, _opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U _VzIdKOJ1Gq1YccwwHcwhrVV5V4U_0, Color color_0, Action<Color> action_0)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		PlayerCustomizationScene _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = default(PlayerCustomizationScene);
		_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U _1oNesdxfncPLwc6V3AdXJQ32yUf = default(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U);
		Action<Color> _qhAM4Wrvf8c5jzKBQqLfosAE9D = default(Action<Color>);
		while (true)
		{
			int num = -2007847425;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA76FD901u) % 4u)
				{
				case 2u:
					_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = this;
					_1oNesdxfncPLwc6V3AdXJQ32yUf = _VzIdKOJ1Gq1YccwwHcwhrVV5V4U_0;
					_qhAM4Wrvf8c5jzKBQqLfosAE9D = action_0;
					num = ((int)num2 * -1446005566) ^ -2072023484;
					continue;
				case 1u:
					_HdTJZZGoOMNi89T0yAdBraCZMjc(controlCollection_0, string_0, PlayerCustomizationScene.smethod_39((Enum)_3t4w2BwPGr8GQDmJlQU929IFD8f._Mz7LwHZqoGBscApFXmff1kEQnGY, (Enum)_1oNesdxfncPLwc6V3AdXJQ32yUf), color_0, delegate(bool bool_0)
					{
						if (bool_0)
						{
							goto IL_0003;
						}
						goto IL_0059;
						IL_0059:
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3t4w2BwPGr8GQDmJlQU929IFD8f._Mz7LwHZqoGBscApFXmff1kEQnGY &= ~_1oNesdxfncPLwc6V3AdXJQ32yUf;
						int num5 = -1929303753;
						goto IL_0034;
						IL_0034:
						while (true)
						{
							uint num6;
							switch ((num6 = (uint)num5 ^ 0xA14BB2C2u) % 5u)
							{
							case 4u:
								break;
							case 1u:
								_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3t4w2BwPGr8GQDmJlQU929IFD8f._Mz7LwHZqoGBscApFXmff1kEQnGY |= _1oNesdxfncPLwc6V3AdXJQ32yUf;
								num5 = ((int)num6 * -711031392) ^ -1172674283;
								continue;
							default:
								return;
							case 2u:
								goto IL_0059;
							case 0u:
								return;
							case 3u:
								return;
							}
							break;
						}
						goto IL_0003;
						IL_0003:
						num5 = -279221972;
						goto IL_0034;
					}, delegate(Color color_0)
					{
						//IL_0006: Unknown result type (might be due to invalid IL or missing references)
						_qhAM4Wrvf8c5jzKBQqLfosAE9D(color_0);
						while (true)
						{
							int num3 = -658362797;
							while (true)
							{
								uint num4;
								switch ((num4 = (uint)num3 ^ 0x941B1B64u) % 3u)
								{
								case 2u:
									goto IL_000e;
								default:
									return;
								case 0u:
									break;
								case 1u:
									return;
								}
								break;
								IL_000e:
								_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._q9fwz0K4rjUrAm9v3Dn6azqJaIN._0cFb48aKbcbREkHm9Jwptl6r6Vi();
								num3 = (int)(num4 * 113398246) ^ -182847014;
							}
						}
					});
					num = ((int)num2 * -1190213901) ^ -2019157230;
					continue;
				default:
					return;
				case 3u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	private void _h7MUbT306Ju5xwvamN8SatTR2Mo(ControlCollection controlCollection_0, string string_0, _opIJo2jLUqdOL5yAFP4yzXce0DG._iDe3W6qb7jKTPuJV79yf2i7UoIq _iDe3W6qb7jKTPuJV79yf2i7UoIq_0, Color color_0, Action<Color> action_0)
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		PlayerCustomizationScene _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = default(PlayerCustomizationScene);
		_opIJo2jLUqdOL5yAFP4yzXce0DG._iDe3W6qb7jKTPuJV79yf2i7UoIq _1oNesdxfncPLwc6V3AdXJQ32yUf = default(_opIJo2jLUqdOL5yAFP4yzXce0DG._iDe3W6qb7jKTPuJV79yf2i7UoIq);
		Action<Color> _qhAM4Wrvf8c5jzKBQqLfosAE9D = default(Action<Color>);
		while (true)
		{
			int num = -1267115602;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x93C8006Fu) % 4u)
				{
				case 1u:
					_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = this;
					_1oNesdxfncPLwc6V3AdXJQ32yUf = _iDe3W6qb7jKTPuJV79yf2i7UoIq_0;
					num = ((int)num2 * -1794569504) ^ -739748313;
					continue;
				case 0u:
					_qhAM4Wrvf8c5jzKBQqLfosAE9D = action_0;
					num = ((int)num2 * -280782203) ^ -268783595;
					continue;
				case 3u:
					break;
				default:
					_HdTJZZGoOMNi89T0yAdBraCZMjc(controlCollection_0, string_0, PlayerCustomizationScene.smethod_39((Enum)_3t4w2BwPGr8GQDmJlQU929IFD8f._SnnHu3P4lDDxgkL6cuUt7y07yxG, (Enum)_1oNesdxfncPLwc6V3AdXJQ32yUf), color_0, delegate(bool bool_0)
					{
						if (bool_0)
						{
							goto IL_0003;
						}
						goto IL_0027;
						IL_0027:
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3t4w2BwPGr8GQDmJlQU929IFD8f._SnnHu3P4lDDxgkL6cuUt7y07yxG &= ~_1oNesdxfncPLwc6V3AdXJQ32yUf;
						int num5 = -15291334;
						goto IL_0008;
						IL_0008:
						switch ((uint)(num5 ^ -1240324562) % 4u)
						{
						case 3u:
							break;
						default:
							return;
						case 1u:
							goto IL_0027;
						case 0u:
							return;
						case 2u:
							_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3t4w2BwPGr8GQDmJlQU929IFD8f._SnnHu3P4lDDxgkL6cuUt7y07yxG |= _1oNesdxfncPLwc6V3AdXJQ32yUf;
							return;
						}
						goto IL_0003;
						IL_0003:
						num5 = -54056892;
						goto IL_0008;
					}, delegate(Color color_0)
					{
						//IL_0006: Unknown result type (might be due to invalid IL or missing references)
						_qhAM4Wrvf8c5jzKBQqLfosAE9D(color_0);
						while (true)
						{
							int num3 = 2073673336;
							while (true)
							{
								uint num4;
								switch ((num4 = (uint)num3 ^ 0x68BA29FFu) % 3u)
								{
								case 1u:
									goto IL_000e;
								default:
									return;
								case 0u:
									break;
								case 2u:
									return;
								}
								break;
								IL_000e:
								_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._q9fwz0K4rjUrAm9v3Dn6azqJaIN._0cFb48aKbcbREkHm9Jwptl6r6Vi();
								num3 = ((int)num4 * -136759003) ^ 0x3E167B8B;
							}
						}
					});
					return;
				}
				break;
			}
		}
	}

	private void _HdTJZZGoOMNi89T0yAdBraCZMjc(ControlCollection controlCollection_0, string string_0, bool bool_0, Color color_0, Action<bool> action_0, Action<Color> action_1)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		PlayerCustomizationScene _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = default(PlayerCustomizationScene);
		CheckBox _SbG09NUiMRUtR5nySpplBTa1qug = default(CheckBox);
		Control _XXaN99sI8FddBJPpuffIrCZZ49q = default(Control);
		while (true)
		{
			int num = 1771140677;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4C4166D1u) % 5u)
				{
				case 4u:
				{
					_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = this;
					CheckBox obj = PlayerCustomizationScene.smethod_40();
					PlayerCustomizationScene.smethod_23((Control)(object)obj, (DockStyle)2);
					PlayerCustomizationScene.smethod_41(obj, string_0);
					PlayerCustomizationScene.smethod_42(obj, bool_0);
					((Control)obj).set_Margin(new Margin(0, 0, 0, 5));
					_SbG09NUiMRUtR5nySpplBTa1qug = obj;
					_XXaN99sI8FddBJPpuffIrCZZ49q = _lV0oshnYavLGLHyogGNxv60JpoM(string_0 + " Color", color_0, action_1);
					num = (int)((num2 * 1373050834) ^ 0x24DC31A7);
					continue;
				}
				case 3u:
					_XXaN99sI8FddBJPpuffIrCZZ49q.set_Visible(_SbG09NUiMRUtR5nySpplBTa1qug.get_Checked());
					((ActiveList<Control>)(object)controlCollection_0).Add((Control)(object)_SbG09NUiMRUtR5nySpplBTa1qug);
					num = ((int)num2 * -1078994298) ^ 0x487382CC;
					continue;
				case 0u:
					((ActiveList<Control>)(object)controlCollection_0).Add(_XXaN99sI8FddBJPpuffIrCZZ49q);
					_SbG09NUiMRUtR5nySpplBTa1qug.add_CheckedChanged((VoidEvent)delegate
					{
						_003C_003Ec__DisplayClass37_0.smethod_1(_XXaN99sI8FddBJPpuffIrCZZ49q, _003C_003Ec__DisplayClass37_0.smethod_0(_SbG09NUiMRUtR5nySpplBTa1qug));
						action_0(_003C_003Ec__DisplayClass37_0.smethod_0(_SbG09NUiMRUtR5nySpplBTa1qug));
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._q9fwz0K4rjUrAm9v3Dn6azqJaIN._0cFb48aKbcbREkHm9Jwptl6r6Vi();
					});
					num = ((int)num2 * -1097321839) ^ 0x1062A61C;
					continue;
				default:
					return;
				case 2u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	private Control _z5npzs7mj5H3zJ1PF64BFNsXBmm(ControlCollection controlCollection_0, string string_0, Color color_0, Action<Color> action_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		Control val = _lV0oshnYavLGLHyogGNxv60JpoM(string_0, color_0, action_0);
		while (true)
		{
			int num = -296219705;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFF42F511u) % 3u)
				{
				case 1u:
					goto IL_000d;
				case 0u:
					break;
				default:
					return val;
				}
				break;
				IL_000d:
				((ActiveList<Control>)(object)controlCollection_0).Add(val);
				num = (int)(num2 * 1998697220) ^ -376049599;
			}
		}
	}

	private Control _lV0oshnYavLGLHyogGNxv60JpoM(string string_0, Color color_0, Action<Color> action_0)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		PlayerCustomizationScene _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = default(PlayerCustomizationScene);
		string _hzqOBkJhJBhsTRNARxHLctcvhN0 = default(string);
		ImageControl _UI1mLnvMX5jk5cl6WgxFoVZi1ne = default(ImageControl);
		Color _l278Ds1vZy3Ru3ca0ydk2C0iLve = default(Color);
		Action<Color> _cUX3uJBm4PHduUlr4bX7NQw8QyK = default(Action<Color>);
		Control val = default(Control);
		Label val2 = default(Label);
		while (true)
		{
			int num = 762494967;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x757A014Cu) % 5u)
				{
				case 3u:
					_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = this;
					_hzqOBkJhJBhsTRNARxHLctcvhN0 = string_0;
					num = (int)(num2 * 939914998) ^ -626751965;
					continue;
				case 1u:
					((Control)_UI1mLnvMX5jk5cl6WgxFoVZi1ne).add_MouseClick((MouseEvent)delegate
					{
						//IL_000d: Unknown result type (might be due to invalid IL or missing references)
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._gaKeabKyjzz2jeJCEYxHW9Gc8CGA(_hzqOBkJhJBhsTRNARxHLctcvhN0, _l278Ds1vZy3Ru3ca0ydk2C0iLve, delegate(Color color_0)
						{
							//IL_0001: Unknown result type (might be due to invalid IL or missing references)
							//IL_0002: Unknown result type (might be due to invalid IL or missing references)
							//IL_0010: Unknown result type (might be due to invalid IL or missing references)
							_l278Ds1vZy3Ru3ca0ydk2C0iLve = color_0;
							while (true)
							{
								int num3 = 1889245731;
								while (true)
								{
									uint num4;
									switch ((num4 = (uint)num3 ^ 0x30129CEu) % 4u)
									{
									case 2u:
										_cUX3uJBm4PHduUlr4bX7NQw8QyK(_l278Ds1vZy3Ru3ca0ydk2C0iLve);
										num3 = (int)(num4 * 1833870209) ^ -251372289;
										continue;
									case 1u:
										_UI1mLnvMX5jk5cl6WgxFoVZi1ne.set_Color(ColorInt.ARGB((int)((Color)(ref color_0)).get_A(), (int)((Color)(ref color_0)).get_R(), (int)((Color)(ref color_0)).get_G(), (int)((Color)(ref color_0)).get_B()));
										num3 = (int)((num4 * 345325664) ^ 0x3B1C3BF0);
										continue;
									case 0u:
										break;
									default:
										_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._q9fwz0K4rjUrAm9v3Dn6azqJaIN._0cFb48aKbcbREkHm9Jwptl6r6Vi();
										return;
									}
									break;
								}
							}
						});
					});
					num = (int)((num2 * 340512351) ^ 0x7A676D07);
					continue;
				case 0u:
				{
					_l278Ds1vZy3Ru3ca0ydk2C0iLve = color_0;
					_cUX3uJBm4PHduUlr4bX7NQw8QyK = action_0;
					Control obj = PlayerCustomizationScene.smethod_43();
					PlayerCustomizationScene.smethod_23(obj, (DockStyle)2);
					obj.set_Margin(new Margin(0, 0, 0, 5));
					val = obj;
					ImageControl val3 = new ImageControl();
					((Control)val3).set_Dock((DockStyle)1);
					((Control)val3).set_Size(new Point(29, 30));
					val3.set_Color(ColorInt.ARGB((int)((Color)(ref _l278Ds1vZy3Ru3ca0ydk2C0iLve)).get_A(), (int)((Color)(ref _l278Ds1vZy3Ru3ca0ydk2C0iLve)).get_R(), (int)((Color)(ref _l278Ds1vZy3Ru3ca0ydk2C0iLve)).get_G(), (int)((Color)(ref _l278Ds1vZy3Ru3ca0ydk2C0iLve)).get_B()));
					_UI1mLnvMX5jk5cl6WgxFoVZi1ne = val3;
					Label val4 = new Label();
					((Control)val4).set_Dock((DockStyle)5);
					val4.set_Text(_hzqOBkJhJBhsTRNARxHLctcvhN0);
					((Control)val4).set_Margin(new Margin(5, 0, 0, 0));
					val2 = val4;
					num = ((int)num2 * -496562445) ^ -954867896;
					continue;
				}
				case 4u:
					break;
				default:
					((ActiveList<Control>)(object)val.GetElements()).Add((Control)(object)_UI1mLnvMX5jk5cl6WgxFoVZi1ne);
					((ActiveList<Control>)(object)val.GetElements()).Add((Control)(object)val2);
					return val;
				}
				break;
			}
		}
	}

	private void _WPOv8yATDl2g7nDSf8itt8V399K(Button button_0)
	{
		int num4 = default(int);
		int num5 = default(int);
		int num3 = default(int);
		Button _u0Xt0uZRA6nEpUColLBccMdwezW = default(Button);
		while (true)
		{
			int num = 1575319393;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x59DD14E4u) % 14u)
				{
				case 13u:
				{
					int num7;
					if (num4 <= num5)
					{
						num = 944520485;
						num7 = 944520485;
					}
					else
					{
						num = 416306082;
						num7 = 416306082;
					}
					continue;
				}
				case 12u:
				{
					int num6;
					if (num3 > num5)
					{
						num = 432985083;
						num6 = 432985083;
					}
					else
					{
						num = 752916272;
						num6 = 752916272;
					}
					continue;
				}
				case 10u:
					num5 = _kG9DrP49ggNdZOvVMMUPjfqdzZ4.FindIndex((Button button_0) => _003C_003Ec__DisplayClass40_0.smethod_0((object)button_0, (object)_u0Xt0uZRA6nEpUColLBccMdwezW));
					num4 = 0;
					num = (int)(num2 * 1928066177) ^ -148970105;
					continue;
				case 9u:
					PlayerCustomizationScene.smethod_23((Control)(object)_kG9DrP49ggNdZOvVMMUPjfqdzZ4[num4], (DockStyle)2);
					num = 334916008;
					continue;
				case 8u:
					((ActiveList<Control>)(object)PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_0jH3FoV36utxuSLivmD6IZNwppA))).Add((Control)(object)_kG9DrP49ggNdZOvVMMUPjfqdzZ4[num4]);
					num = (int)((num2 * 34633646) ^ 0x2C5777A9);
					continue;
				case 7u:
					num4++;
					num = ((int)num2 * -1076070441) ^ -1601277186;
					continue;
				case 6u:
					num = (int)(num2 * 1991996189) ^ -1097097414;
					continue;
				case 5u:
					PlayerCustomizationScene.smethod_23((Control)(object)_kG9DrP49ggNdZOvVMMUPjfqdzZ4[num3], (DockStyle)4);
					num = 1952719445;
					continue;
				case 4u:
					num3 = _kG9DrP49ggNdZOvVMMUPjfqdzZ4.Count - 1;
					num = ((int)num2 * -880234638) ^ 0x14EC8932;
					continue;
				case 3u:
					((ActiveList<Control>)(object)PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_0jH3FoV36utxuSLivmD6IZNwppA))).Add((Control)(object)_kG9DrP49ggNdZOvVMMUPjfqdzZ4[num3]);
					num = (int)(num2 * 1194096289) ^ -65150377;
					continue;
				case 1u:
					_u0Xt0uZRA6nEpUColLBccMdwezW = button_0;
					((ActiveList<Control>)(object)PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_0jH3FoV36utxuSLivmD6IZNwppA))).Clear();
					num = (int)((num2 * 2026923916) ^ 0x4762AE72);
					continue;
				case 0u:
					num3--;
					num = ((int)num2 * -745475325) ^ -734085938;
					continue;
				case 11u:
					break;
				default:
					((ActiveList<Control>)(object)PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_0jH3FoV36utxuSLivmD6IZNwppA))).Add((Control)(object)_TbkP67ntBpYJu1M27pBfsYAHmgJ);
					return;
				}
				break;
			}
		}
	}

	private Button _cvldkRXLM8Toadgv6nPx5QH1EES(string string_0, Action action_0)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		Button _u0Xt0uZRA6nEpUColLBccMdwezW = default(Button);
		Action _qhAM4Wrvf8c5jzKBQqLfosAE9D = default(Action);
		while (true)
		{
			int num = -273369908;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCF074E44u) % 5u)
				{
				case 3u:
					PlayerCustomizationScene.smethod_47((Control)(object)_u0Xt0uZRA6nEpUColLBccMdwezW, (MouseEvent)delegate
					{
						((ActiveList<Control>)(object)_003C_003Ec__DisplayClass41_0.smethod_1(_003C_003Ec__DisplayClass41_0.smethod_0(_TbkP67ntBpYJu1M27pBfsYAHmgJ))).Clear();
						_003C_003Ec__DisplayClass41_0.smethod_3(_003C_003Ec__DisplayClass41_0.smethod_2(_TbkP67ntBpYJu1M27pBfsYAHmgJ), 0f);
						_WPOv8yATDl2g7nDSf8itt8V399K(_u0Xt0uZRA6nEpUColLBccMdwezW);
						_qhAM4Wrvf8c5jzKBQqLfosAE9D();
					});
					num = (int)(num2 * 1489141286) ^ -1778667702;
					continue;
				case 2u:
					_qhAM4Wrvf8c5jzKBQqLfosAE9D = action_0;
					num = (int)(num2 * 1021459363) ^ -1150788454;
					continue;
				case 1u:
				{
					Button obj = PlayerCustomizationScene.smethod_44();
					PlayerCustomizationScene.smethod_23((Control)(object)obj, (DockStyle)2);
					PlayerCustomizationScene.smethod_45((Label)(object)obj, (Alignment)4);
					PlayerCustomizationScene.smethod_25((Label)(object)obj, string_0);
					PlayerCustomizationScene.smethod_46((Control)(object)obj, "buttonOpaque");
					_u0Xt0uZRA6nEpUColLBccMdwezW = obj;
					int num3;
					int num4;
					if (_qhAM4Wrvf8c5jzKBQqLfosAE9D != null)
					{
						num3 = -1932105432;
						num4 = -1932105432;
					}
					else
					{
						num3 = -1885749782;
						num4 = -1885749782;
					}
					num = num3 ^ (int)(num2 * 941599556);
					continue;
				}
				case 0u:
					break;
				default:
					((ActiveList<Control>)(object)PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_0jH3FoV36utxuSLivmD6IZNwppA))).Add((Control)(object)_u0Xt0uZRA6nEpUColLBccMdwezW);
					return _u0Xt0uZRA6nEpUColLBccMdwezW;
				}
				break;
			}
		}
	}

	private void _YemBTJprwfbd3mpg5Gy9uyEJWwI(ControlCollection controlCollection_0, string string_0, string[] string_1, int int_0, Action<int> action_0)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		DropDownList val2 = default(DropDownList);
		int num3 = default(int);
		Action<int> _qhAM4Wrvf8c5jzKBQqLfosAE9D = default(Action<int>);
		PlayerCustomizationScene _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = default(PlayerCustomizationScene);
		Label val = default(Label);
		while (true)
		{
			int num = -926783503;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCFD8ADABu) % 13u)
				{
				case 12u:
					((Control)val2.get_Listbox().get_Scrollbar().get_ButtonDown()).set_Visible(false);
					num3 = 0;
					num = (int)(num2 * 1289162110) ^ -1872445505;
					continue;
				case 11u:
					val2.add_SelectedItemChanged((SelectedItemChangedEventHandler)delegate(Control control_0, ListBoxItem listBoxItem_0)
					{
						_qhAM4Wrvf8c5jzKBQqLfosAE9D((int)_003C_003Ec__DisplayClass42_0.smethod_0(listBoxItem_0));
						while (true)
						{
							int num5 = 47898160;
							while (true)
							{
								uint num6;
								switch ((num6 = (uint)num5 ^ 0x15E6A7E0u) % 3u)
								{
								case 1u:
									goto IL_0018;
								default:
									return;
								case 0u:
									break;
								case 2u:
									return;
								}
								break;
								IL_0018:
								_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._q9fwz0K4rjUrAm9v3Dn6azqJaIN._0cFb48aKbcbREkHm9Jwptl6r6Vi();
								num5 = (int)((num6 * 1828621613) ^ 0x964D23E);
							}
						}
					});
					num = (int)(num2 * 356427048) ^ -919490456;
					continue;
				case 10u:
					((Control)val2.get_Listbox().get_Scrollbar().get_ButtonUp()).set_Visible(false);
					num = (int)((num2 * 1323860367) ^ 0x18B482F1);
					continue;
				case 9u:
				{
					DropDownList obj2 = PlayerCustomizationScene.smethod_48();
					PlayerCustomizationScene.smethod_23((Control)(object)obj2, (DockStyle)2);
					PlayerCustomizationScene.smethod_46((Control)(object)obj2, "button");
					((Control)PlayerCustomizationScene.smethod_49(obj2)).set_Margin(new Margin(10, 0, 0, 0));
					obj2.get_Dropdown().set_Resizable(false);
					((Control)obj2).set_Margin(new Margin(0, 0, 0, 5));
					val2 = obj2;
					num = ((int)num2 * -425189357) ^ -2101405923;
					continue;
				}
				case 8u:
					((ActiveList<Control>)(object)controlCollection_0).Add((Control)(object)val2);
					num = (int)(num2 * 1306448186) ^ -516453647;
					continue;
				case 6u:
				{
					ActiveList<ListBoxItem> items = val2.get_Items();
					ListBoxItem val3 = new ListBoxItem();
					((Label)val3).set_Text(string_1[num3]);
					val3.set_Value((object)num3);
					val3.set_Selected(num3 == int_0);
					((Control)val3).set_Size(new Point(0, 30));
					items.Add(val3);
					num3++;
					num = -43866419;
					continue;
				}
				case 5u:
				{
					_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = this;
					Label obj = PlayerCustomizationScene.smethod_24();
					PlayerCustomizationScene.smethod_25(obj, string_0);
					PlayerCustomizationScene.smethod_23((Control)(object)obj, (DockStyle)2);
					val = obj;
					num = (int)(num2 * 1544226112) ^ -441255993;
					continue;
				}
				case 4u:
					_qhAM4Wrvf8c5jzKBQqLfosAE9D = action_0;
					num = ((int)num2 * -890427125) ^ 0x38DEE31;
					continue;
				case 3u:
				{
					int num4;
					if (num3 < string_1.Length)
					{
						num = -1627655675;
						num4 = -1627655675;
					}
					else
					{
						num = -1627613891;
						num4 = -1627613891;
					}
					continue;
				}
				case 2u:
					num = ((int)num2 * -2088657018) ^ 0x675CF585;
					continue;
				case 1u:
					((ActiveList<Control>)(object)controlCollection_0).Add((Control)(object)val);
					num = (int)((num2 * 248000923) ^ 0x50D599A5);
					continue;
				default:
					return;
				case 7u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	private void _bABf372CnRI0x85NIaTEbIUNZ10<T>(ControlCollection controlCollection_0, string string_0, T gparam_0, Action<T> action_0)
	{
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		PlayerCustomizationScene _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = default(PlayerCustomizationScene);
		int num3 = default(int);
		string[] names = default(string[]);
		DropDownList val = default(DropDownList);
		Array values = default(Array);
		Label val3 = default(Label);
		int num5 = default(int);
		while (true)
		{
			int num = 1099466107;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6273E2BAu) % 13u)
				{
				case 10u:
					_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = this;
					num = ((int)num2 * -1478923823) ^ 0x46F5D0C7;
					continue;
				case 9u:
					num3 = 0;
					num = (int)(num2 * 2003562551) ^ -727114789;
					continue;
				case 8u:
				{
					int num6;
					if (num3 < names.Length)
					{
						num = 604981913;
						num6 = 604981913;
					}
					else
					{
						num = 2108855264;
						num6 = 2108855264;
					}
					continue;
				}
				case 7u:
					num = (int)((num2 * 1217292154) ^ 0x7093B2D8);
					continue;
				case 6u:
					((Control)val.get_Listbox().get_Scrollbar().get_ButtonDown()).set_Visible(false);
					names = Enum.GetNames(typeof(T));
					num = (int)((num2 * 1517733317) ^ 0x342B73B);
					continue;
				case 5u:
					values = Enum.GetValues(typeof(T));
					num = (int)((num2 * 51289108) ^ 0x74C4B77A);
					continue;
				case 4u:
					((Control)val.get_Listbox().get_Scrollbar().get_ButtonUp()).set_Visible(false);
					num = ((int)num2 * -385149204) ^ 0x1376A3E6;
					continue;
				case 3u:
					((ActiveList<Control>)(object)controlCollection_0).Add((Control)(object)val3);
					((ActiveList<Control>)(object)controlCollection_0).Add((Control)(object)val);
					num = (int)((num2 * 1011888391) ^ 0x5876A96C);
					continue;
				case 2u:
				{
					num5 = (int)(object)gparam_0;
					Label obj = PlayerCustomizationScene.smethod_24();
					PlayerCustomizationScene.smethod_25(obj, string_0);
					PlayerCustomizationScene.smethod_23((Control)(object)obj, (DockStyle)2);
					val3 = obj;
					DropDownList obj2 = PlayerCustomizationScene.smethod_48();
					PlayerCustomizationScene.smethod_23((Control)(object)obj2, (DockStyle)2);
					PlayerCustomizationScene.smethod_46((Control)(object)obj2, "button");
					((Control)PlayerCustomizationScene.smethod_49(obj2)).set_Margin(new Margin(10, 0, 0, 0));
					obj2.get_Dropdown().set_Resizable(false);
					((Control)obj2).set_Margin(new Margin(0, 0, 0, 5));
					val = obj2;
					num = (int)((num2 * 1237272308) ^ 0x40DD9B7B);
					continue;
				}
				case 1u:
					val.add_SelectedItemChanged((SelectedItemChangedEventHandler)delegate(Control control_0, ListBoxItem listBoxItem_0)
					{
						action_0((T)_003C_003Ec__DisplayClass43_0<T>.smethod_0(listBoxItem_0));
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._q9fwz0K4rjUrAm9v3Dn6azqJaIN._0cFb48aKbcbREkHm9Jwptl6r6Vi();
					});
					num = ((int)num2 * -460861221) ^ 0x6C9084D;
					continue;
				case 0u:
				{
					string text = names[num3];
					int num4 = (int)values.GetValue(num3);
					ActiveList<ListBoxItem> items = val.get_Items();
					ListBoxItem val2 = new ListBoxItem();
					((Label)val2).set_Text(text);
					val2.set_Value(values.GetValue(num3));
					val2.set_Selected(num4 == num5);
					((Control)val2).set_Size(new Point(0, 30));
					items.Add(val2);
					num3++;
					num = 135635114;
					continue;
				}
				default:
					return;
				case 12u:
					break;
				case 11u:
					return;
				}
				break;
			}
		}
	}

	private void _gaKeabKyjzz2jeJCEYxHW9Gc8CGA(string string_0, Color color_0, Action<Color> action_0)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected O, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected O, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected O, but got Unknown
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Expected O, but got Unknown
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Expected O, but got Unknown
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Expected O, but got Unknown
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected O, but got Unknown
		//IL_056d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Unknown result type (might be due to invalid IL or missing references)
		//IL_0579: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Expected O, but got Unknown
		//IL_05da: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fc: Expected O, but got Unknown
		//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Unknown result type (might be due to invalid IL or missing references)
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_0615: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Unknown result type (might be due to invalid IL or missing references)
		//IL_062f: Expected O, but got Unknown
		//IL_066c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Unknown result type (might be due to invalid IL or missing references)
		//IL_0684: Expected O, but got Unknown
		//IL_06e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_071d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0722: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Unknown result type (might be due to invalid IL or missing references)
		//IL_0731: Unknown result type (might be due to invalid IL or missing references)
		//IL_073b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0740: Unknown result type (might be due to invalid IL or missing references)
		//IL_074c: Expected O, but got Unknown
		//IL_074c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0751: Unknown result type (might be due to invalid IL or missing references)
		//IL_0758: Unknown result type (might be due to invalid IL or missing references)
		//IL_0764: Unknown result type (might be due to invalid IL or missing references)
		//IL_076b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Unknown result type (might be due to invalid IL or missing references)
		//IL_077c: Expected O, but got Unknown
		//IL_0831: Unknown result type (might be due to invalid IL or missing references)
		//IL_0832: Unknown result type (might be due to invalid IL or missing references)
		//IL_0875: Unknown result type (might be due to invalid IL or missing references)
		//IL_087a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0881: Unknown result type (might be due to invalid IL or missing references)
		//IL_0886: Unknown result type (might be due to invalid IL or missing references)
		//IL_0890: Unknown result type (might be due to invalid IL or missing references)
		//IL_089c: Expected O, but got Unknown
		//IL_089c: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cc: Expected O, but got Unknown
		//IL_0938: Unknown result type (might be due to invalid IL or missing references)
		//IL_093d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0944: Unknown result type (might be due to invalid IL or missing references)
		//IL_0950: Expected O, but got Unknown
		//IL_0988: Unknown result type (might be due to invalid IL or missing references)
		//IL_098d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0990: Unknown result type (might be due to invalid IL or missing references)
		//IL_099a: Unknown result type (might be due to invalid IL or missing references)
		//IL_09be: Expected O, but got Unknown
		//IL_0a40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a70: Expected O, but got Unknown
		//IL_0a71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a89: Expected O, but got Unknown
		//IL_0ad3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b03: Expected O, but got Unknown
		//IL_0beb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1d: Expected O, but got Unknown
		//IL_0c2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c49: Expected O, but got Unknown
		//IL_0c83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb3: Expected O, but got Unknown
		//IL_0cb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdb: Expected O, but got Unknown
		//IL_0d50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8a: Expected O, but got Unknown
		//IL_0dc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dcb: Expected O, but got Unknown
		Panel val = default(Panel);
		Panel val6 = default(Panel);
		Texture2D val4 = default(Texture2D);
		int[] array = default(int[]);
		Texture2D _3PAjrCP0TE07YQ22X6EIpPwOlib = default(Texture2D);
		ImageControl _wbSWz1LplcReMBnbKlnmd0UzxRP = default(ImageControl);
		Panel val3 = default(Panel);
		ImageControl _UI1mLnvMX5jk5cl6WgxFoVZi1ne = default(ImageControl);
		bool _FxCuMzbCIAsYKlL8DmmchjsMpir = default(bool);
		Action _XDKgJpkUD4lIN2K7ysMOtqO5gMA = default(Action);
		float _46o2iZ9juR1nNURyrP41h9vxpGA = default(float);
		float _xX4CfdHl6arem4v3fUgbDUIK2gM = default(float);
		Color _9ycmcfwZ9EbmXanrFe7pEfGAAUi = default(Color);
		float _kyexzK2VL0y9etRuX79HInHIsIb = default(float);
		bool _a7vdsaGCzLloXi7sntZm1rCdbZK = default(bool);
		ImageControl _nTvWggfVqVEF25GV4NOsfpNhR4C = default(ImageControl);
		int[] _Vo3fFvvroxYzfCOI5F4PqiMr0Gb = default(int[]);
		Window _L7VColD35B3sDgJdUnjTeXGa7pv = default(Window);
		Button val23 = default(Button);
		Panel val17 = default(Panel);
		ImageControl _G6zJYvyBSALAHUJm6qCEvtL6WRp = default(ImageControl);
		int num7 = default(int);
		int num3 = default(int);
		TextBox _ZP3psbb9CVMMjGn5SgszZo0zGpF = default(TextBox);
		Panel val24 = default(Panel);
		Label val43 = default(Label);
		TextBox _hOIb3XNfIEDsngLrYzmNfLTPVAS = default(TextBox);
		int num4 = default(int);
		Panel val2 = default(Panel);
		TextBox _gY2uTDE0FADy52ltQdJ1AO9nRcf = default(TextBox);
		int num5 = default(int);
		Label val22 = default(Label);
		ImageControl _OWUGVcx9djtc19hjFfxkac019iL = default(ImageControl);
		TextBox _8lboaaRLcpJoVxfwF1kBCisgrjL = default(TextBox);
		Color val5 = default(Color);
		Label val11 = default(Label);
		Label val7 = default(Label);
		TextBox _E3KHmDW9haZynE9ZamZBVdveWgk = default(TextBox);
		Label val25 = default(Label);
		TextBox _qCKGqUjXlMolAESPmB7a59OrelQ = default(TextBox);
		Label val15 = default(Label);
		Label val8 = default(Label);
		Label val9 = default(Label);
		TextBox _8vFoRw3vIHPno8g3WIeCBRRueVP = default(TextBox);
		while (true)
		{
			int num = -1243899923;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAFBD8A5Au) % 72u)
				{
				case 71u:
					((ActiveList<Control>)(object)val.get_Content().get_Controls()).Add((Control)(object)val6);
					num = ((int)num2 * -769250585) ^ 0x5CC78AEA;
					continue;
				case 69u:
					val4.SetData<int>(array);
					Gui.get_Renderer().SetTexture("ColorPickerBox", (object)_3PAjrCP0TE07YQ22X6EIpPwOlib);
					num = (int)(num2 * 1163883532) ^ -203824253;
					continue;
				case 68u:
				{
					ImageControl val37 = new ImageControl();
					((Control)val37).set_Size(new Point(25, 6));
					val37.set_Color(ColorInt.ARGB(0.9f, 1f, 1f, 1f));
					_wbSWz1LplcReMBnbKlnmd0UzxRP = val37;
					num = ((int)num2 * -149314025) ^ -2044180853;
					continue;
				}
				case 67u:
				{
					Panel val36 = new Panel();
					((Control)val36).set_Dock((DockStyle)2);
					((Control)val36).set_Size(new Point(275, 30));
					((Control)val36).set_Margin(new Margin(0, 0, 0, 8));
					val3 = val36;
					num = (int)((num2 * 386293586) ^ 0x7F5DE912);
					continue;
				}
				case 66u:
					((Control)_UI1mLnvMX5jk5cl6WgxFoVZi1ne).add_Update((VoidEvent)delegate
					{
						//IL_0068: Unknown result type (might be due to invalid IL or missing references)
						//IL_006d: Unknown result type (might be due to invalid IL or missing references)
						//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
						//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
						//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
						//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
						//IL_010d: Unknown result type (might be due to invalid IL or missing references)
						//IL_0112: Unknown result type (might be due to invalid IL or missing references)
						//IL_0141: Unknown result type (might be due to invalid IL or missing references)
						//IL_0146: Unknown result type (might be due to invalid IL or missing references)
						//IL_0154: Unknown result type (might be due to invalid IL or missing references)
						//IL_0159: Unknown result type (might be due to invalid IL or missing references)
						//IL_0187: Unknown result type (might be due to invalid IL or missing references)
						//IL_0192: Unknown result type (might be due to invalid IL or missing references)
						//IL_0197: Unknown result type (might be due to invalid IL or missing references)
						//IL_019c: Unknown result type (might be due to invalid IL or missing references)
						//IL_021b: Unknown result type (might be due to invalid IL or missing references)
						//IL_0220: Unknown result type (might be due to invalid IL or missing references)
						//IL_0269: Unknown result type (might be due to invalid IL or missing references)
						//IL_026e: Unknown result type (might be due to invalid IL or missing references)
						//IL_0292: Unknown result type (might be due to invalid IL or missing references)
						//IL_0297: Unknown result type (might be due to invalid IL or missing references)
						//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
						//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
						//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
						//IL_02db: Unknown result type (might be due to invalid IL or missing references)
						//IL_0308: Unknown result type (might be due to invalid IL or missing references)
						if (_FxCuMzbCIAsYKlL8DmmchjsMpir)
						{
							goto IL_001d;
						}
						goto IL_0394;
						IL_0394:
						int num32;
						int num33;
						if (!_003C_003Ec__DisplayClass44_0.smethod_3(_003C_003Ec__DisplayClass44_0.smethod_2(_003C_003Ec__DisplayClass44_0.smethod_1((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), _PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton))
						{
							num32 = -1864649358;
							num33 = -1864649358;
						}
						else
						{
							num32 = -434561393;
							num33 = -434561393;
						}
						goto IL_031f;
						IL_031f:
						Point val49 = default(Point);
						Point val50 = default(Point);
						while (true)
						{
							uint num34;
							switch ((num34 = (uint)num32 ^ 0xAE4B9678u) % 21u)
							{
							case 20u:
								break;
							case 19u:
								goto IL_0027;
							case 16u:
								_XDKgJpkUD4lIN2K7ysMOtqO5gMA();
								num32 = ((int)num34 * -1503195744) ^ 0x67953F0;
								continue;
							case 14u:
								val49 = Gui.get_MousePosition();
								num32 = (int)(num34 * 1037355872) ^ -63024582;
								continue;
							case 12u:
								goto IL_0080;
							case 11u:
								val49 = Gui.get_MousePosition();
								num32 = ((int)num34 * -1926127748) ^ -130390511;
								continue;
							case 10u:
								((Point)(ref val50)).set_x((int)MathHelper.Clamp((float)((Point)(ref val50)).get_x(), 0f, 250f));
								num32 = (int)((num34 * 1523204081) ^ 0x587EA725);
								continue;
							case 9u:
							{
								int y5 = ((Point)(ref val49)).get_y();
								val49 = ((Control)_UI1mLnvMX5jk5cl6WgxFoVZi1ne).get_Location();
								int y6 = ((Point)(ref val49)).get_y();
								val49 = ((Control)_UI1mLnvMX5jk5cl6WgxFoVZi1ne).get_Size();
								int num41;
								int num42;
								if (y5 > y6 + ((Point)(ref val49)).get_y())
								{
									num41 = -1342180469;
									num42 = -1342180469;
								}
								else
								{
									num41 = -1988229591;
									num42 = -1988229591;
								}
								num32 = num41 ^ (int)(num34 * 172099482);
								continue;
							}
							case 8u:
							{
								val49 = Gui.get_MousePosition();
								int y4 = ((Point)(ref val49)).get_y();
								val49 = ((Control)_UI1mLnvMX5jk5cl6WgxFoVZi1ne).get_Location();
								int num37;
								int num38;
								if (y4 >= ((Point)(ref val49)).get_y())
								{
									num37 = -1863283411;
									num38 = -1863283411;
								}
								else
								{
									num37 = -561588585;
									num38 = -561588585;
								}
								num32 = num37 ^ ((int)num34 * -720333743);
								continue;
							}
							case 7u:
								val50 = Gui.get_MousePosition() - ((Control)_UI1mLnvMX5jk5cl6WgxFoVZi1ne).get_Location();
								num32 = ((int)num34 * -724073402) ^ -1941937319;
								continue;
							case 6u:
								((Point)(ref val50)).set_y((int)MathHelper.Clamp((float)((Point)(ref val50)).get_y(), 0f, 250f));
								_46o2iZ9juR1nNURyrP41h9vxpGA = (float)((Point)(ref val50)).get_x() / 250f;
								_xX4CfdHl6arem4v3fUgbDUIK2gM = (250f - (float)((Point)(ref val50)).get_y()) / 250f;
								num32 = (int)(num34 * 616442991) ^ -1737797050;
								continue;
							case 5u:
							{
								int x6 = ((Point)(ref val49)).get_x();
								val49 = ((Control)_UI1mLnvMX5jk5cl6WgxFoVZi1ne).get_Location();
								int num39;
								int num40;
								if (x6 < ((Point)(ref val49)).get_x())
								{
									num39 = -1504097677;
									num40 = -1504097677;
								}
								else
								{
									num39 = -436241138;
									num40 = -436241138;
								}
								num32 = num39 ^ (int)(num34 * 898295495);
								continue;
							}
							case 4u:
								_9ycmcfwZ9EbmXanrFe7pEfGAAUi = _lAdyiyyWQrRKWYduTPacHqdzOmj(_kyexzK2VL0y9etRuX79HInHIsIb, _46o2iZ9juR1nNURyrP41h9vxpGA, _xX4CfdHl6arem4v3fUgbDUIK2gM, 1f);
								num32 = (int)((num34 * 962625771) ^ 0x36A0B1AD);
								continue;
							case 3u:
							{
								int x4 = ((Point)(ref val49)).get_x();
								val49 = ((Control)_UI1mLnvMX5jk5cl6WgxFoVZi1ne).get_Location();
								int x5 = ((Point)(ref val49)).get_x();
								val49 = ((Control)_UI1mLnvMX5jk5cl6WgxFoVZi1ne).get_Size();
								int num35;
								int num36;
								if (x4 <= x5 + ((Point)(ref val49)).get_x())
								{
									num35 = 17584627;
									num36 = 17584627;
								}
								else
								{
									num35 = 1774579356;
									num36 = 1774579356;
								}
								num32 = num35 ^ (int)(num34 * 858497811);
								continue;
							}
							case 2u:
								val49 = _003C_003Ec__DisplayClass44_0.smethod_4();
								num32 = ((int)num34 * -1085510744) ^ 0x5825DA64;
								continue;
							case 1u:
								_a7vdsaGCzLloXi7sntZm1rCdbZK = true;
								num32 = ((int)num34 * -1454729510) ^ 0x37FB6D7D;
								continue;
							case 0u:
								action_0(_9ycmcfwZ9EbmXanrFe7pEfGAAUi);
								num32 = (int)(num34 * 1111130226) ^ -632228818;
								continue;
							default:
								return;
							case 15u:
								goto IL_0394;
							case 13u:
								return;
							case 17u:
								_a7vdsaGCzLloXi7sntZm1rCdbZK = false;
								return;
							case 18u:
								return;
							}
							break;
							IL_0080:
							int num43;
							if (_a7vdsaGCzLloXi7sntZm1rCdbZK)
							{
								num32 = -516654337;
								num43 = -516654337;
							}
							else
							{
								num32 = -2099940411;
								num43 = -2099940411;
							}
							continue;
							IL_0027:
							int num44;
							if (_a7vdsaGCzLloXi7sntZm1rCdbZK)
							{
								num32 = -1768855881;
								num44 = -1768855881;
							}
							else
							{
								num32 = -30678018;
								num44 = -30678018;
							}
						}
						goto IL_001d;
						IL_001d:
						num32 = -79831668;
						goto IL_031f;
					});
					((Control)_nTvWggfVqVEF25GV4NOsfpNhR4C).add_Update((VoidEvent)delegate
					{
						//IL_0070: Unknown result type (might be due to invalid IL or missing references)
						//IL_0075: Unknown result type (might be due to invalid IL or missing references)
						//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
						//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
						//IL_011e: Unknown result type (might be due to invalid IL or missing references)
						//IL_0123: Unknown result type (might be due to invalid IL or missing references)
						//IL_0131: Unknown result type (might be due to invalid IL or missing references)
						//IL_0136: Unknown result type (might be due to invalid IL or missing references)
						//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
						//IL_01be: Unknown result type (might be due to invalid IL or missing references)
						//IL_01df: Unknown result type (might be due to invalid IL or missing references)
						//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
						//IL_021d: Unknown result type (might be due to invalid IL or missing references)
						//IL_0222: Unknown result type (might be due to invalid IL or missing references)
						//IL_0230: Unknown result type (might be due to invalid IL or missing references)
						//IL_0235: Unknown result type (might be due to invalid IL or missing references)
						//IL_0243: Unknown result type (might be due to invalid IL or missing references)
						//IL_0248: Unknown result type (might be due to invalid IL or missing references)
						//IL_0285: Unknown result type (might be due to invalid IL or missing references)
						//IL_028a: Unknown result type (might be due to invalid IL or missing references)
						//IL_0298: Unknown result type (might be due to invalid IL or missing references)
						//IL_029d: Unknown result type (might be due to invalid IL or missing references)
						//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
						//IL_031d: Unknown result type (might be due to invalid IL or missing references)
						//IL_0322: Unknown result type (might be due to invalid IL or missing references)
						//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
						//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
						//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
						//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
						if (_a7vdsaGCzLloXi7sntZm1rCdbZK)
						{
							goto IL_0213;
						}
						goto IL_0482;
						IL_0482:
						int num15;
						int num16;
						if (!_003C_003Ec__DisplayClass44_0.smethod_3(_003C_003Ec__DisplayClass44_0.smethod_2(_003C_003Ec__DisplayClass44_0.smethod_1((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), _PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton))
						{
							num15 = 1190842757;
							num16 = 1190842757;
						}
						else
						{
							num15 = 1767112252;
							num16 = 1767112252;
						}
						goto IL_03f8;
						IL_03f8:
						int num21 = default(int);
						int num18 = default(int);
						Point val47 = default(Point);
						Point val46 = default(Point);
						while (true)
						{
							uint num17;
							switch ((num17 = (uint)num15 ^ 0x1E12EA21u) % 26u)
							{
							case 25u:
								num21++;
								num15 = ((int)num17 * -1369747713) ^ -1492397499;
								continue;
							case 24u:
							{
								Color val48 = _lAdyiyyWQrRKWYduTPacHqdzOmj(_kyexzK2VL0y9etRuX79HInHIsIb, (float)num18 / (float)_3PAjrCP0TE07YQ22X6EIpPwOlib.get_Width(), ((float)_3PAjrCP0TE07YQ22X6EIpPwOlib.get_Height() - (float)num21) / (float)_3PAjrCP0TE07YQ22X6EIpPwOlib.get_Height(), 1f);
								_Vo3fFvvroxYzfCOI5F4PqiMr0Gb[num21 * _3PAjrCP0TE07YQ22X6EIpPwOlib.get_Width() + num18] = (int)((Color)(ref val48)).get_PackedValue();
								num15 = 1686684984;
								continue;
							}
							case 23u:
								break;
							case 22u:
								val47 = Gui.get_MousePosition();
								num15 = ((int)num17 * -337844194) ^ 0x3890E085;
								continue;
							case 21u:
								_XDKgJpkUD4lIN2K7ysMOtqO5gMA();
								num15 = (int)((num17 * 13377561) ^ 0x5F9CB912);
								continue;
							case 20u:
								num18 = 0;
								num15 = 1734742468;
								continue;
							case 19u:
								num15 = (int)(num17 * 1111591396) ^ -245442291;
								continue;
							case 18u:
							{
								val47 = _003C_003Ec__DisplayClass44_0.smethod_4();
								int x = ((Point)(ref val47)).get_x();
								val47 = ((Control)_nTvWggfVqVEF25GV4NOsfpNhR4C).get_Location();
								int num22;
								int num23;
								if (x >= ((Point)(ref val47)).get_x())
								{
									num22 = -592034232;
									num23 = -592034232;
								}
								else
								{
									num22 = -41731545;
									num23 = -41731545;
								}
								num15 = num22 ^ (int)(num17 * 74247264);
								continue;
							}
							case 17u:
								((Point)(ref val46)).set_y((int)MathHelper.Clamp((float)((Point)(ref val46)).get_y(), 0f, 250f));
								_kyexzK2VL0y9etRuX79HInHIsIb = 360f - (float)((Point)(ref val46)).get_y() / 250f * 360f;
								num21 = 0;
								num15 = ((int)num17 * -1382157670) ^ -149871500;
								continue;
							case 16u:
								val47 = Gui.get_MousePosition();
								num15 = ((int)num17 * -664056918) ^ 0x12DC7EE2;
								continue;
							case 14u:
							{
								int y3 = ((Point)(ref val47)).get_y();
								val47 = ((Control)_nTvWggfVqVEF25GV4NOsfpNhR4C).get_Location();
								int num26;
								int num27;
								if (y3 >= ((Point)(ref val47)).get_y())
								{
									num26 = -816485069;
									num27 = -816485069;
								}
								else
								{
									num26 = -33494745;
									num27 = -33494745;
								}
								num15 = num26 ^ ((int)num17 * -395551680);
								continue;
							}
							case 12u:
								goto end_IL_03f8;
							case 11u:
							{
								val47 = Gui.get_MousePosition();
								int x2 = ((Point)(ref val47)).get_x();
								val47 = ((Control)_nTvWggfVqVEF25GV4NOsfpNhR4C).get_Location();
								int x3 = ((Point)(ref val47)).get_x();
								val47 = ((Control)_nTvWggfVqVEF25GV4NOsfpNhR4C).get_Size();
								int num24;
								int num25;
								if (x2 <= x3 + ((Point)(ref val47)).get_x())
								{
									num24 = 26890101;
									num25 = 26890101;
								}
								else
								{
									num24 = 1254406415;
									num25 = 1254406415;
								}
								num15 = num24 ^ ((int)num17 * -911823640);
								continue;
							}
							case 9u:
							{
								int y = ((Point)(ref val47)).get_y();
								val47 = ((Control)_nTvWggfVqVEF25GV4NOsfpNhR4C).get_Location();
								int y2 = ((Point)(ref val47)).get_y();
								val47 = ((Control)_nTvWggfVqVEF25GV4NOsfpNhR4C).get_Size();
								int num19;
								int num20;
								if (y <= y2 + ((Point)(ref val47)).get_y())
								{
									num19 = 70731468;
									num20 = 70731468;
								}
								else
								{
									num19 = 1397703782;
									num20 = 1397703782;
								}
								num15 = num19 ^ ((int)num17 * -972184505);
								continue;
							}
							case 8u:
								action_0(_9ycmcfwZ9EbmXanrFe7pEfGAAUi);
								num15 = (int)(num17 * 412734200) ^ -2111629299;
								continue;
							case 7u:
								_3PAjrCP0TE07YQ22X6EIpPwOlib.SetData<int>(_Vo3fFvvroxYzfCOI5F4PqiMr0Gb);
								_9ycmcfwZ9EbmXanrFe7pEfGAAUi = _lAdyiyyWQrRKWYduTPacHqdzOmj(_kyexzK2VL0y9etRuX79HInHIsIb, _46o2iZ9juR1nNURyrP41h9vxpGA, _xX4CfdHl6arem4v3fUgbDUIK2gM, 1f);
								num15 = (int)((num17 * 852706390) ^ 0x2830FDA2);
								continue;
							case 6u:
								goto IL_033a;
							case 5u:
								num18++;
								num15 = ((int)num17 * -267937315) ^ -2121030548;
								continue;
							case 4u:
								_FxCuMzbCIAsYKlL8DmmchjsMpir = true;
								num15 = ((int)num17 * -1101904271) ^ -737689653;
								continue;
							case 3u:
								goto IL_038c;
							case 1u:
								val46 = Gui.get_MousePosition() - ((Control)_nTvWggfVqVEF25GV4NOsfpNhR4C).get_Location();
								num15 = (int)((num17 * 2103436652) ^ 0x50000764);
								continue;
							case 0u:
								goto IL_03d3;
							default:
								return;
							case 15u:
								goto IL_0482;
							case 2u:
								return;
							case 10u:
								_FxCuMzbCIAsYKlL8DmmchjsMpir = false;
								return;
							case 13u:
								return;
							}
							int num28;
							if (num21 >= _3PAjrCP0TE07YQ22X6EIpPwOlib.get_Height())
							{
								num15 = 1616059638;
								num28 = 1616059638;
							}
							else
							{
								num15 = 630790101;
								num28 = 630790101;
							}
							continue;
							IL_03d3:
							int num29;
							if (num18 >= _3PAjrCP0TE07YQ22X6EIpPwOlib.get_Width())
							{
								num15 = 1350154196;
								num29 = 1350154196;
							}
							else
							{
								num15 = 297259681;
								num29 = 297259681;
							}
							continue;
							IL_033a:
							int num30;
							if (_FxCuMzbCIAsYKlL8DmmchjsMpir)
							{
								num15 = 1010092430;
								num30 = 1010092430;
							}
							else
							{
								num15 = 260287741;
								num30 = 260287741;
							}
							continue;
							IL_038c:
							int num31;
							if (_FxCuMzbCIAsYKlL8DmmchjsMpir)
							{
								num15 = 1790259751;
								num31 = 1790259751;
							}
							else
							{
								num15 = 990496993;
								num31 = 990496993;
							}
							continue;
							end_IL_03f8:
							break;
						}
						goto IL_0213;
						IL_0213:
						num15 = 963471518;
						goto IL_03f8;
					});
					num = ((int)num2 * -2145740795) ^ 0x82A2A;
					continue;
				case 65u:
				{
					((ActiveList<Control>)(object)_L7VColD35B3sDgJdUnjTeXGa7pv.get_Controls()).Add((Control)(object)_wbSWz1LplcReMBnbKlnmd0UzxRP);
					Button val28 = new Button();
					((Control)val28).set_Dock((DockStyle)5);
					((Label)val28).set_Text("Close");
					((Label)val28).set_TextAlign((Alignment)4);
					val23 = val28;
					((Control)val23).add_MouseClick((MouseEvent)delegate
					{
						_003C_003Ec__DisplayClass44_0.smethod_0(_hSPLyBveOIKpCKgimgpgcMUDdRz);
					});
					num = (int)((num2 * 256249335) ^ 0x4CA19527);
					continue;
				}
				case 64u:
					_XDKgJpkUD4lIN2K7ysMOtqO5gMA();
					_a7vdsaGCzLloXi7sntZm1rCdbZK = false;
					num = (int)(num2 * 71275501) ^ -1819313771;
					continue;
				case 63u:
				{
					ImageControl val16 = new ImageControl();
					((Control)val16).set_Dock((DockStyle)5);
					val16.set_Texture("ColorPickerSlider");
					((Control)val16).set_Size(new Point(25, 250));
					_nTvWggfVqVEF25GV4NOsfpNhR4C = val16;
					((ActiveList<Control>)(object)val17.get_Content().get_Controls()).Add((Control)(object)_UI1mLnvMX5jk5cl6WgxFoVZi1ne);
					((ActiveList<Control>)(object)val17.get_Content().get_Controls()).Add((Control)(object)_nTvWggfVqVEF25GV4NOsfpNhR4C);
					ImageControl val18 = new ImageControl();
					((Control)val18).set_Dock((DockStyle)2);
					((Control)val18).set_Size(new Point(275, 25));
					val18.set_Color(ColorInt.ARGB((int)((Color)(ref color_0)).get_A(), (int)((Color)(ref color_0)).get_R(), (int)((Color)(ref color_0)).get_G(), (int)((Color)(ref color_0)).get_B()));
					((Control)val18).set_Margin(new Margin(0, 0, 0, 8));
					_G6zJYvyBSALAHUJm6qCEvtL6WRp = val18;
					num = (int)((num2 * 1203243920) ^ 0x75449C91);
					continue;
				}
				case 62u:
					num = ((int)num2 * -654117671) ^ -1639898091;
					continue;
				case 61u:
					_L7VColD35B3sDgJdUnjTeXGa7pv.Show(base._PnkAlVnMv0SZvRBFexqzE5DF9tp);
					num = ((int)num2 * -976105682) ^ -340422480;
					continue;
				case 60u:
					num = ((int)num2 * -1080850217) ^ 0x2AC812C9;
					continue;
				case 59u:
				{
					Color val45 = _lAdyiyyWQrRKWYduTPacHqdzOmj(_kyexzK2VL0y9etRuX79HInHIsIb, (float)num7 / (float)_3PAjrCP0TE07YQ22X6EIpPwOlib.get_Width(), ((float)_3PAjrCP0TE07YQ22X6EIpPwOlib.get_Height() - (float)num3) / (float)_3PAjrCP0TE07YQ22X6EIpPwOlib.get_Height(), 1f);
					_Vo3fFvvroxYzfCOI5F4PqiMr0Gb[num3 * _3PAjrCP0TE07YQ22X6EIpPwOlib.get_Width() + num7] = (int)((Color)(ref val45)).get_PackedValue();
					num = -545281459;
					continue;
				}
				case 58u:
				{
					TextBox val44 = new TextBox();
					((Control)val44).set_Dock((DockStyle)5);
					((Control)val44).set_TabIndex(5);
					_ZP3psbb9CVMMjGn5SgszZo0zGpF = val44;
					((ActiveList<Control>)(object)val24.get_Content().get_Controls()).Add((Control)(object)val43);
					((ActiveList<Control>)(object)val24.get_Content().get_Controls()).Add((Control)(object)_hOIb3XNfIEDsngLrYzmNfLTPVAS);
					num = ((int)num2 * -2005272525) ^ 0x4C6C627;
					continue;
				}
				case 57u:
					val4 = new Texture2D(base._ZzBuoSDMWwerejOO9Goyv2OCKgE._2yepMkVENnecIsduggABaU2qhXW, 25, 250, false, (SurfaceFormat)0);
					array = new int[val4.get_Width() * val4.get_Height()];
					num4 = 0;
					num = ((int)num2 * -886668934) ^ 0x13BD4876;
					continue;
				case 56u:
				{
					Window obj = PlayerCustomizationScene.smethod_22();
					PlayerCustomizationScene.smethod_23((Control)(object)obj, (DockStyle)3);
					PlayerCustomizationScene.smethod_51((Control)(object)obj, (AutoSize)3);
					((Control)obj).set_Margin(new Margin(8, 8, 0, 8));
					_L7VColD35B3sDgJdUnjTeXGa7pv = obj;
					num = -1184729622;
					continue;
				}
				case 55u:
					num7++;
					num = ((int)num2 * -23977311) ^ 0x49C9E841;
					continue;
				case 54u:
				{
					Label val42 = new Label();
					((Control)val42).set_Dock((DockStyle)1);
					val42.set_Text("S:");
					val42.set_TextAlign((Alignment)4);
					((Control)val42).set_Size(new Point(30, 30));
					val43 = val42;
					num = ((int)num2 * -346498094) ^ -926272444;
					continue;
				}
				case 53u:
					((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)_gY2uTDE0FADy52ltQdJ1AO9nRcf);
					num = ((int)num2 * -1643114988) ^ 0x7C9D4726;
					continue;
				case 52u:
					num5++;
					num = (int)((num2 * 931893714) ^ 0x733A0D7D);
					continue;
				case 51u:
				{
					Panel val39 = new Panel();
					((Control)val39).set_Dock((DockStyle)2);
					((Control)val39).set_Size(new Point(275, 30));
					((Control)val39).set_Margin(new Margin(0, 0, 0, 8));
					val2 = val39;
					Label val40 = new Label();
					((Control)val40).set_Dock((DockStyle)1);
					val40.set_Text("V:");
					val40.set_TextAlign((Alignment)4);
					((Control)val40).set_Size(new Point(30, 30));
					val22 = val40;
					TextBox val41 = new TextBox();
					((Control)val41).set_Dock((DockStyle)1);
					((Control)val41).set_Size(new Point(107, 30));
					((Control)val41).set_TabIndex(3);
					_gY2uTDE0FADy52ltQdJ1AO9nRcf = val41;
					num = ((int)num2 * -2059778785) ^ 0x328303B7;
					continue;
				}
				case 49u:
				{
					int num12;
					if (num4 < val4.get_Height())
					{
						num = -390203200;
						num12 = -390203200;
					}
					else
					{
						num = -1220964841;
						num12 = -1220964841;
					}
					continue;
				}
				case 48u:
				{
					Panel val38 = new Panel();
					((Control)val38).set_Dock((DockStyle)2);
					((Control)val38).set_Size(new Point(275, 30));
					((Control)val38).set_Margin(new Margin(0, 0, 0, 8));
					val24 = val38;
					num = (int)((num2 * 1339684073) ^ 0x5D7EE3C4);
					continue;
				}
				case 47u:
				{
					int num11;
					if (num3 >= _3PAjrCP0TE07YQ22X6EIpPwOlib.get_Height())
					{
						num = -1767004225;
						num11 = -1767004225;
					}
					else
					{
						num = -1314684261;
						num11 = -1314684261;
					}
					continue;
				}
				case 46u:
				{
					Panel val34 = new Panel();
					((Control)val34).set_Dock((DockStyle)2);
					((Control)val34).set_Size(new Point(275, 250));
					val17 = val34;
					ImageControl val35 = new ImageControl();
					((Control)val35).set_Dock((DockStyle)1);
					val35.set_Texture("ColorPickerBox");
					((Control)val35).set_Size(new Point(250, 250));
					_UI1mLnvMX5jk5cl6WgxFoVZi1ne = val35;
					num = (int)(num2 * 87424960) ^ -1252332843;
					continue;
				}
				case 45u:
					((ActiveList<Control>)(object)_L7VColD35B3sDgJdUnjTeXGa7pv.get_Controls()).Add((Control)(object)_OWUGVcx9djtc19hjFfxkac019iL);
					num = ((int)num2 * -589586011) ^ -1622487310;
					continue;
				case 44u:
				{
					TextBox val33 = new TextBox();
					((Control)val33).set_Dock((DockStyle)5);
					((Control)val33).set_TabIndex(7);
					_8lboaaRLcpJoVxfwF1kBCisgrjL = val33;
					num = ((int)num2 * -212891173) ^ 0x508FA6B3;
					continue;
				}
				case 43u:
					num3++;
					num = (int)((num2 * 1299703886) ^ 0x194BB1B7);
					continue;
				case 42u:
					val5 = _lAdyiyyWQrRKWYduTPacHqdzOmj(((float)val4.get_Height() - (float)num4) / (float)val4.get_Height() * 360f, 1.0, 1.0, 1f);
					num5 = 0;
					num = -1259492034;
					continue;
				case 41u:
					((ActiveList<Control>)(object)val3.get_Content().get_Controls()).Add((Control)(object)val11);
					num = ((int)num2 * -1807998276) ^ 0x786D3994;
					continue;
				case 40u:
				{
					Panel val31 = new Panel();
					((Control)val31).set_Dock((DockStyle)2);
					((Control)val31).set_Size(new Point(275, 30));
					((Control)val31).set_Margin(new Margin(0, 0, 0, 8));
					val6 = val31;
					Label val32 = new Label();
					((Control)val32).set_Dock((DockStyle)1);
					val32.set_Text("Hex:");
					val32.set_TextAlign((Alignment)4);
					((Control)val32).set_Size(new Point(45, 30));
					val7 = val32;
					num = ((int)num2 * -390394775) ^ -1025133082;
					continue;
				}
				case 39u:
					((ActiveList<Control>)(object)val.get_Content().get_Controls()).Add((Control)(object)_G6zJYvyBSALAHUJm6qCEvtL6WRp);
					((ActiveList<Control>)(object)val.get_Content().get_Controls()).Add((Control)(object)val3);
					((ActiveList<Control>)(object)val.get_Content().get_Controls()).Add((Control)(object)val24);
					num = ((int)num2 * -1294133973) ^ -1912649529;
					continue;
				case 38u:
					((ActiveList<Control>)(object)val24.get_Content().get_Controls()).Add((Control)(object)_ZP3psbb9CVMMjGn5SgszZo0zGpF);
					num = (int)((num2 * 1801859635) ^ 0x1DD6CAF3);
					continue;
				case 37u:
					_E3KHmDW9haZynE9ZamZBVdveWgk.add_TextCommit((EventHandler)delegate
					{
						//IL_0049: Unknown result type (might be due to invalid IL or missing references)
						//IL_006c: Unknown result type (might be due to invalid IL or missing references)
						if (int.TryParse(_003C_003Ec__DisplayClass44_0.smethod_5(_E3KHmDW9haZynE9ZamZBVdveWgk), out var result))
						{
							while (true)
							{
								int num13 = 63270690;
								while (true)
								{
									uint num14;
									switch ((num14 = (uint)num13 ^ 0x57CA865Du) % 4u)
									{
									case 3u:
										((Color)(ref _9ycmcfwZ9EbmXanrFe7pEfGAAUi)).set_B((byte)_003C_003Ec__DisplayClass44_0.smethod_7(0, _003C_003Ec__DisplayClass44_0.smethod_6(result, 255)));
										num13 = ((int)num14 * -531668391) ^ 0x72B777DF;
										continue;
									case 1u:
										_fA3AcauqZZ0ncWKv9QA3iklruOI(_9ycmcfwZ9EbmXanrFe7pEfGAAUi, out _kyexzK2VL0y9etRuX79HInHIsIb, out _46o2iZ9juR1nNURyrP41h9vxpGA, out _xX4CfdHl6arem4v3fUgbDUIK2gM);
										action_0(_9ycmcfwZ9EbmXanrFe7pEfGAAUi);
										num13 = ((int)num14 * -6029964) ^ -879958585;
										continue;
									case 0u:
										break;
									default:
										goto end_IL_00a4;
									}
									break;
								}
								continue;
								end_IL_00a4:
								break;
							}
						}
						_XDKgJpkUD4lIN2K7ysMOtqO5gMA();
					});
					num = ((int)num2 * -1212671749) ^ -71089889;
					continue;
				case 36u:
					_9ycmcfwZ9EbmXanrFe7pEfGAAUi = color_0;
					num = ((int)num2 * -1838020617) ^ 0x4E852555;
					continue;
				case 35u:
					((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)_E3KHmDW9haZynE9ZamZBVdveWgk);
					num = ((int)num2 * -1324323679) ^ 0x4DEE4FA1;
					continue;
				case 34u:
				{
					TextBox val29 = new TextBox();
					((Control)val29).set_Dock((DockStyle)1);
					((Control)val29).set_Size(new Point(107, 30));
					((Control)val29).set_TabIndex(2);
					_hOIb3XNfIEDsngLrYzmNfLTPVAS = val29;
					Label val30 = new Label();
					((Control)val30).set_Dock((DockStyle)1);
					val30.set_Text("G:");
					val30.set_TextAlign((Alignment)4);
					((Control)val30).set_Size(new Point(30, 30));
					val25 = val30;
					num = (int)((num2 * 679139100) ^ 0x7940218);
					continue;
				}
				case 33u:
					num7 = 0;
					num = -1732324298;
					continue;
				case 32u:
					PlayerCustomizationScene.smethod_50(_hSPLyBveOIKpCKgimgpgcMUDdRz);
					num = (int)(num2 * 230663066) ^ -1208376182;
					continue;
				case 31u:
				{
					int num9;
					int num10;
					if (_hSPLyBveOIKpCKgimgpgcMUDdRz != null)
					{
						num9 = -2094723230;
						num10 = -2094723230;
					}
					else
					{
						num9 = -128309758;
						num10 = -128309758;
					}
					num = num9 ^ ((int)num2 * -1416390120);
					continue;
				}
				case 30u:
				{
					TextBox val27 = new TextBox();
					((Control)val27).set_Dock((DockStyle)5);
					((Control)val27).set_TabIndex(4);
					_qCKGqUjXlMolAESPmB7a59OrelQ = val27;
					num = ((int)num2 * -1670622216) ^ 0xED47C83;
					continue;
				}
				case 29u:
					_3PAjrCP0TE07YQ22X6EIpPwOlib.SetData<int>(_Vo3fFvvroxYzfCOI5F4PqiMr0Gb);
					num = (int)((num2 * 827323) ^ 0x3B10F1B4);
					continue;
				case 28u:
				{
					ImageControl val26 = new ImageControl();
					((Control)val26).set_Size(new Point(6, 6));
					val26.set_Color(ColorInt.ARGB(0.9f, 1f, 1f, 1f));
					_OWUGVcx9djtc19hjFfxkac019iL = val26;
					num = ((int)num2 * -1218000919) ^ -1971276246;
					continue;
				}
				case 27u:
					((ActiveList<Control>)(object)val24.get_Content().get_Controls()).Add((Control)(object)val25);
					num = (int)(num2 * 884295212) ^ -918621752;
					continue;
				case 26u:
					((ActiveList<Control>)(object)val.get_Content().get_Controls()).Add((Control)(object)val15);
					num = (int)((num2 * 1293960814) ^ 0x171A51C9);
					continue;
				case 25u:
					((ActiveList<Control>)(object)val.get_Content().get_Controls()).Add((Control)(object)val23);
					num = (int)(num2 * 1680987920) ^ -1891313033;
					continue;
				case 24u:
				{
					Label val20 = new Label();
					((Control)val20).set_Dock((DockStyle)1);
					val20.set_Text("B:");
					val20.set_TextAlign((Alignment)4);
					((Control)val20).set_Size(new Point(30, 30));
					val8 = val20;
					TextBox val21 = new TextBox();
					((Control)val21).set_Dock((DockStyle)5);
					((Control)val21).set_TabIndex(6);
					_E3KHmDW9haZynE9ZamZBVdveWgk = val21;
					((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)val22);
					num = ((int)num2 * -1810204323) ^ 0x4FA92477;
					continue;
				}
				case 23u:
					((ActiveList<Control>)(object)val.get_Content().get_Controls()).Add((Control)(object)val17);
					num = (int)(num2 * 337375848) ^ -261743371;
					continue;
				case 22u:
				{
					Label val19 = new Label();
					((Control)val19).set_Dock((DockStyle)1);
					val19.set_Text("R:");
					val19.set_TextAlign((Alignment)4);
					((Control)val19).set_Size(new Point(30, 30));
					val9 = val19;
					num = ((int)num2 * -849410472) ^ 0x6B27D4CC;
					continue;
				}
				case 21u:
					((ActiveList<Control>)(object)val6.get_Content().get_Controls()).Add((Control)(object)_8lboaaRLcpJoVxfwF1kBCisgrjL);
					num = (int)(num2 * 365913266) ^ -863350524;
					continue;
				case 20u:
				{
					int num8;
					if (num7 < _3PAjrCP0TE07YQ22X6EIpPwOlib.get_Width())
					{
						num = -1243717023;
						num8 = -1243717023;
					}
					else
					{
						num = -590192535;
						num8 = -590192535;
					}
					continue;
				}
				case 19u:
					_XDKgJpkUD4lIN2K7ysMOtqO5gMA = delegate
					{
						//IL_002c: Unknown result type (might be due to invalid IL or missing references)
						//IL_005d: Unknown result type (might be due to invalid IL or missing references)
						((Control)_OWUGVcx9djtc19hjFfxkac019iL).set_Position(new Point(13 + (int)(_46o2iZ9juR1nNURyrP41h9vxpGA * 250f), 35 + (int)(250f - _xX4CfdHl6arem4v3fUgbDUIK2gM * 250f)));
						((Control)_wbSWz1LplcReMBnbKlnmd0UzxRP).set_Position(new Point(266, 35 + (int)(250f - 250f * (_kyexzK2VL0y9etRuX79HInHIsIb / 360f))));
						_G6zJYvyBSALAHUJm6qCEvtL6WRp.set_Color(ColorInt.ARGB((int)((Color)(ref _9ycmcfwZ9EbmXanrFe7pEfGAAUi)).get_A(), (int)((Color)(ref _9ycmcfwZ9EbmXanrFe7pEfGAAUi)).get_R(), (int)((Color)(ref _9ycmcfwZ9EbmXanrFe7pEfGAAUi)).get_G(), (int)((Color)(ref _9ycmcfwZ9EbmXanrFe7pEfGAAUi)).get_B()));
						while (true)
						{
							int num45 = 1586698986;
							while (true)
							{
								uint num46;
								switch ((num46 = (uint)num45 ^ 0xE5EE5C8u) % 5u)
								{
								case 4u:
									_8vFoRw3vIHPno8g3WIeCBRRueVP.set_Text(((int)_kyexzK2VL0y9etRuX79HInHIsIb).ToString());
									_hOIb3XNfIEDsngLrYzmNfLTPVAS.set_Text(((int)(_46o2iZ9juR1nNURyrP41h9vxpGA * 100f)).ToString());
									num45 = ((int)num46 * -954357002) ^ -1063860872;
									continue;
								case 2u:
									_qCKGqUjXlMolAESPmB7a59OrelQ.set_Text(((Color)(ref _9ycmcfwZ9EbmXanrFe7pEfGAAUi)).get_R().ToString());
									_ZP3psbb9CVMMjGn5SgszZo0zGpF.set_Text(((Color)(ref _9ycmcfwZ9EbmXanrFe7pEfGAAUi)).get_G().ToString());
									_E3KHmDW9haZynE9ZamZBVdveWgk.set_Text(((Color)(ref _9ycmcfwZ9EbmXanrFe7pEfGAAUi)).get_B().ToString());
									num45 = ((int)num46 * -2061899538) ^ 0x52C2C6E2;
									continue;
								case 0u:
									_gY2uTDE0FADy52ltQdJ1AO9nRcf.set_Text(((int)(_xX4CfdHl6arem4v3fUgbDUIK2gM * 100f)).ToString());
									num45 = ((int)num46 * -1781626899) ^ 0x5979E693;
									continue;
								case 3u:
									break;
								default:
									_8lboaaRLcpJoVxfwF1kBCisgrjL.set_Text($"#{((Color)(ref _9ycmcfwZ9EbmXanrFe7pEfGAAUi)).get_R():X2}{((Color)(ref _9ycmcfwZ9EbmXanrFe7pEfGAAUi)).get_G():X2}{((Color)(ref _9ycmcfwZ9EbmXanrFe7pEfGAAUi)).get_B():X2}");
									return;
								}
								break;
							}
						}
					};
					num = (int)(num2 * 536562996) ^ -289244634;
					continue;
				case 18u:
					_8vFoRw3vIHPno8g3WIeCBRRueVP.add_TextCommit((EventHandler)delegate
					{
						//IL_0051: Unknown result type (might be due to invalid IL or missing references)
						//IL_0056: Unknown result type (might be due to invalid IL or missing references)
						//IL_0062: Unknown result type (might be due to invalid IL or missing references)
						if (int.TryParse(_003C_003Ec__DisplayClass44_0.smethod_5(_8vFoRw3vIHPno8g3WIeCBRRueVP), out var result2))
						{
							goto IL_0017;
						}
						goto IL_009a;
						IL_009a:
						_XDKgJpkUD4lIN2K7ysMOtqO5gMA();
						int num47 = -1012734870;
						goto IL_0079;
						IL_0079:
						while (true)
						{
							uint num48;
							switch ((num48 = (uint)num47 ^ 0xD3854D85u) % 4u)
							{
							case 2u:
								break;
							case 1u:
								_kyexzK2VL0y9etRuX79HInHIsIb = _003C_003Ec__DisplayClass44_0.smethod_7(0, _003C_003Ec__DisplayClass44_0.smethod_6(result2, 360));
								_9ycmcfwZ9EbmXanrFe7pEfGAAUi = _lAdyiyyWQrRKWYduTPacHqdzOmj(_kyexzK2VL0y9etRuX79HInHIsIb, _46o2iZ9juR1nNURyrP41h9vxpGA, _xX4CfdHl6arem4v3fUgbDUIK2gM, 1f);
								action_0(_9ycmcfwZ9EbmXanrFe7pEfGAAUi);
								num47 = ((int)num48 * -695356150) ^ -1323185505;
								continue;
							default:
								return;
							case 0u:
								goto IL_009a;
							case 3u:
								return;
							}
							break;
						}
						goto IL_0017;
						IL_0017:
						num47 = -409497152;
						goto IL_0079;
					});
					num = (int)(num2 * 995461342) ^ -469065473;
					continue;
				case 17u:
					((ActiveList<Control>)(object)val.get_Content().get_Controls()).Add((Control)(object)val6);
					num = ((int)num2 * -340667165) ^ 0xCBA71F0;
					continue;
				case 16u:
				{
					_hSPLyBveOIKpCKgimgpgcMUDdRz = _L7VColD35B3sDgJdUnjTeXGa7pv;
					Panel val13 = new Panel();
					((Control)val13).set_Size(new Point(307, 519));
					((Control)val13.get_ClipFrame()).set_Margin(new Margin(16, 8, 16, 16));
					val = val13;
					((ActiveList<Control>)(object)_L7VColD35B3sDgJdUnjTeXGa7pv.get_Controls()).Add((Control)(object)val);
					Label val14 = new Label();
					((Control)val14).set_Dock((DockStyle)2);
					val14.set_Text(string_0);
					val14.set_TextAlign((Alignment)4);
					val15 = val14;
					num = ((int)num2 * -1144673459) ^ 0x37A4FB1C;
					continue;
				}
				case 15u:
				{
					int num6;
					if (num5 < val4.get_Width())
					{
						num = -1372417519;
						num6 = -1372417519;
					}
					else
					{
						num = -349496540;
						num6 = -349496540;
					}
					continue;
				}
				case 14u:
				{
					Label val10 = new Label();
					((Control)val10).set_Dock((DockStyle)1);
					val10.set_Text("H:");
					val10.set_TextAlign((Alignment)4);
					((Control)val10).set_Size(new Point(30, 30));
					val11 = val10;
					TextBox val12 = new TextBox();
					((Control)val12).set_Dock((DockStyle)1);
					((Control)val12).set_Size(new Point(107, 30));
					((Control)val12).set_TabIndex(1);
					_8vFoRw3vIHPno8g3WIeCBRRueVP = val12;
					num = ((int)num2 * -1797986814) ^ 0x14D12B40;
					continue;
				}
				case 13u:
					Gui.get_Renderer().SetTexture("ColorPickerSlider", (object)val4);
					num = (int)(num2 * 688914403) ^ -1928411394;
					continue;
				case 12u:
					((ActiveList<Control>)(object)val3.get_Content().get_Controls()).Add((Control)(object)val9);
					((ActiveList<Control>)(object)val3.get_Content().get_Controls()).Add((Control)(object)_qCKGqUjXlMolAESPmB7a59OrelQ);
					num = ((int)num2 * -783691176) ^ -1587624014;
					continue;
				case 11u:
					_fA3AcauqZZ0ncWKv9QA3iklruOI(color_0, out _kyexzK2VL0y9etRuX79HInHIsIb, out _46o2iZ9juR1nNURyrP41h9vxpGA, out _xX4CfdHl6arem4v3fUgbDUIK2gM);
					_3PAjrCP0TE07YQ22X6EIpPwOlib = new Texture2D(base._ZzBuoSDMWwerejOO9Goyv2OCKgE._2yepMkVENnecIsduggABaU2qhXW, 250, 250, false, (SurfaceFormat)0);
					num = ((int)num2 * -1898152280) ^ 0xE320013;
					continue;
				case 10u:
					_8lboaaRLcpJoVxfwF1kBCisgrjL.add_TextCommit((EventHandler)delegate
					{
						//IL_0050: Unknown result type (might be due to invalid IL or missing references)
						//IL_00de: Unknown result type (might be due to invalid IL or missing references)
						if (_003C_003Ec__DisplayClass44_0.smethod_8(_003C_003Ec__DisplayClass44_0.smethod_5(_8lboaaRLcpJoVxfwF1kBCisgrjL), "#") && _003C_003Ec__DisplayClass44_0.smethod_9(_003C_003Ec__DisplayClass44_0.smethod_5(_8lboaaRLcpJoVxfwF1kBCisgrjL)) <= 7)
						{
							try
							{
								int num51 = _003C_003Ec__DisplayClass44_0.smethod_11(_003C_003Ec__DisplayClass44_0.smethod_10(_003C_003Ec__DisplayClass44_0.smethod_5(_8lboaaRLcpJoVxfwF1kBCisgrjL), 1), 16);
								while (true)
								{
									IL_011e:
									int num52 = -440240185;
									while (true)
									{
										uint num53;
										switch ((num53 = (uint)num52 ^ 0xBB86C14Eu) % 6u)
										{
										case 4u:
											_fA3AcauqZZ0ncWKv9QA3iklruOI(_9ycmcfwZ9EbmXanrFe7pEfGAAUi, out _kyexzK2VL0y9etRuX79HInHIsIb, out _46o2iZ9juR1nNURyrP41h9vxpGA, out _xX4CfdHl6arem4v3fUgbDUIK2gM);
											num52 = (int)((num53 * 860467247) ^ 0x1D7F534);
											continue;
										case 2u:
											((Color)(ref _9ycmcfwZ9EbmXanrFe7pEfGAAUi)).set_G((byte)((uint)(num51 >> 8) & 0xFFu));
											((Color)(ref _9ycmcfwZ9EbmXanrFe7pEfGAAUi)).set_R((byte)((uint)(num51 >> 16) & 0xFFu));
											num52 = (int)(num53 * 1895977284) ^ -2124789904;
											continue;
										case 1u:
											((Color)(ref _9ycmcfwZ9EbmXanrFe7pEfGAAUi)).set_B((byte)((uint)num51 & 0xFFu));
											num52 = ((int)num53 * -359658037) ^ -5384611;
											continue;
										case 0u:
											action_0(_9ycmcfwZ9EbmXanrFe7pEfGAAUi);
											num52 = ((int)num53 * -483044069) ^ 0x25C9BE43;
											continue;
										default:
											goto end_IL_00f5;
										case 5u:
											break;
										case 3u:
											goto end_IL_00f5;
										}
										goto IL_011e;
										continue;
										end_IL_00f5:
										break;
									}
									break;
								}
							}
							catch
							{
							}
						}
						_XDKgJpkUD4lIN2K7ysMOtqO5gMA();
					});
					((Control)_L7VColD35B3sDgJdUnjTeXGa7pv).add_Update((VoidEvent)delegate
					{
						if (_003C_003Ec__DisplayClass44_0.smethod_12(_003C_003Ec__DisplayClass44_0.smethod_2(_003C_003Ec__DisplayClass44_0.smethod_1((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), (Keys)27))
						{
							while (true)
							{
								int num49 = -984861461;
								while (true)
								{
									uint num50;
									switch ((num50 = (uint)num49 ^ 0xCE399B56u) % 4u)
									{
									case 3u:
										_hSPLyBveOIKpCKgimgpgcMUDdRz = null;
										num49 = (int)((num50 * 805424333) ^ 0x1E80785);
										continue;
									case 1u:
										_003C_003Ec__DisplayClass44_0.smethod_0(_L7VColD35B3sDgJdUnjTeXGa7pv);
										num49 = ((int)num50 * -1642417934) ^ -305003809;
										continue;
									default:
										return;
									case 2u:
										break;
									case 0u:
										return;
									}
									break;
								}
							}
						}
					});
					num = ((int)num2 * -827909655) ^ 0x69FF2FCE;
					continue;
				case 9u:
					_hOIb3XNfIEDsngLrYzmNfLTPVAS.add_TextCommit((EventHandler)delegate
					{
						//IL_0023: Unknown result type (might be due to invalid IL or missing references)
						//IL_0081: Unknown result type (might be due to invalid IL or missing references)
						//IL_0086: Unknown result type (might be due to invalid IL or missing references)
						if (int.TryParse(_003C_003Ec__DisplayClass44_0.smethod_5(_hOIb3XNfIEDsngLrYzmNfLTPVAS), out var result4))
						{
							while (true)
							{
								int num56 = 450635357;
								while (true)
								{
									uint num57;
									switch ((num57 = (uint)num56 ^ 0x7AA78BBu) % 5u)
									{
									case 2u:
										action_0(_9ycmcfwZ9EbmXanrFe7pEfGAAUi);
										num56 = ((int)num57 * -603047013) ^ -99697514;
										continue;
									case 1u:
										_46o2iZ9juR1nNURyrP41h9vxpGA = (float)_003C_003Ec__DisplayClass44_0.smethod_7(0, _003C_003Ec__DisplayClass44_0.smethod_6(result4, 100)) / 100f;
										num56 = (int)(num57 * 503109061) ^ -989666960;
										continue;
									case 0u:
										_9ycmcfwZ9EbmXanrFe7pEfGAAUi = _lAdyiyyWQrRKWYduTPacHqdzOmj(_kyexzK2VL0y9etRuX79HInHIsIb, _46o2iZ9juR1nNURyrP41h9vxpGA, _xX4CfdHl6arem4v3fUgbDUIK2gM, 1f);
										num56 = ((int)num57 * -574447271) ^ 0x663408C;
										continue;
									case 3u:
										break;
									default:
										goto end_IL_00bd;
									}
									break;
								}
								continue;
								end_IL_00bd:
								break;
							}
						}
						_XDKgJpkUD4lIN2K7ysMOtqO5gMA();
					});
					_gY2uTDE0FADy52ltQdJ1AO9nRcf.add_TextCommit((EventHandler)delegate
					{
						//IL_0037: Unknown result type (might be due to invalid IL or missing references)
						//IL_003c: Unknown result type (might be due to invalid IL or missing references)
						//IL_0048: Unknown result type (might be due to invalid IL or missing references)
						if (int.TryParse(_003C_003Ec__DisplayClass44_0.smethod_5(_gY2uTDE0FADy52ltQdJ1AO9nRcf), out var result3))
						{
							while (true)
							{
								int num54 = 1169488434;
								while (true)
								{
									uint num55;
									switch ((num55 = (uint)num54 ^ 0x5DC45Fu) % 4u)
									{
									case 2u:
										_9ycmcfwZ9EbmXanrFe7pEfGAAUi = _lAdyiyyWQrRKWYduTPacHqdzOmj(_kyexzK2VL0y9etRuX79HInHIsIb, _46o2iZ9juR1nNURyrP41h9vxpGA, _xX4CfdHl6arem4v3fUgbDUIK2gM, 1f);
										action_0(_9ycmcfwZ9EbmXanrFe7pEfGAAUi);
										num54 = ((int)num55 * -1551464075) ^ -1086537286;
										continue;
									case 1u:
										_xX4CfdHl6arem4v3fUgbDUIK2gM = (float)_003C_003Ec__DisplayClass44_0.smethod_7(0, _003C_003Ec__DisplayClass44_0.smethod_6(result3, 100)) / 100f;
										num54 = ((int)num55 * -1333661509) ^ 0x3E336ED2;
										continue;
									case 0u:
										break;
									default:
										goto end_IL_00aa;
									}
									break;
								}
								continue;
								end_IL_00aa:
								break;
							}
						}
						_XDKgJpkUD4lIN2K7ysMOtqO5gMA();
					});
					num = (int)(num2 * 406089604) ^ -967927750;
					continue;
				case 8u:
					((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)val8);
					num = (int)((num2 * 376898430) ^ 0xD79DC9);
					continue;
				case 7u:
					_FxCuMzbCIAsYKlL8DmmchjsMpir = false;
					num = (int)((num2 * 1688691832) ^ 0x76683F8);
					continue;
				case 6u:
					num4++;
					num = ((int)num2 * -549382875) ^ 0x6F8EB295;
					continue;
				case 5u:
					((ActiveList<Control>)(object)val6.get_Content().get_Controls()).Add((Control)(object)val7);
					num = ((int)num2 * -1153970641) ^ -2136290580;
					continue;
				case 4u:
					_qCKGqUjXlMolAESPmB7a59OrelQ.add_TextCommit((EventHandler)delegate
					{
						//IL_0049: Unknown result type (might be due to invalid IL or missing references)
						//IL_006c: Unknown result type (might be due to invalid IL or missing references)
						if (int.TryParse(_003C_003Ec__DisplayClass44_0.smethod_5(_qCKGqUjXlMolAESPmB7a59OrelQ), out var result6))
						{
							while (true)
							{
								int num60 = -915638740;
								while (true)
								{
									uint num61;
									switch ((num61 = (uint)num60 ^ 0x8144BB65u) % 4u)
									{
									case 1u:
										((Color)(ref _9ycmcfwZ9EbmXanrFe7pEfGAAUi)).set_R((byte)_003C_003Ec__DisplayClass44_0.smethod_7(0, _003C_003Ec__DisplayClass44_0.smethod_6(result6, 255)));
										num60 = ((int)num61 * -713886635) ^ -1300425624;
										continue;
									case 0u:
										_fA3AcauqZZ0ncWKv9QA3iklruOI(_9ycmcfwZ9EbmXanrFe7pEfGAAUi, out _kyexzK2VL0y9etRuX79HInHIsIb, out _46o2iZ9juR1nNURyrP41h9vxpGA, out _xX4CfdHl6arem4v3fUgbDUIK2gM);
										action_0(_9ycmcfwZ9EbmXanrFe7pEfGAAUi);
										num60 = (int)((num61 * 1571509991) ^ 0x78EBFA0F);
										continue;
									case 3u:
										break;
									default:
										goto end_IL_00a4;
									}
									break;
								}
								continue;
								end_IL_00a4:
								break;
							}
						}
						_XDKgJpkUD4lIN2K7ysMOtqO5gMA();
					});
					_ZP3psbb9CVMMjGn5SgszZo0zGpF.add_TextCommit((EventHandler)delegate
					{
						//IL_001a: Unknown result type (might be due to invalid IL or missing references)
						//IL_007f: Unknown result type (might be due to invalid IL or missing references)
						if (int.TryParse(_003C_003Ec__DisplayClass44_0.smethod_5(_ZP3psbb9CVMMjGn5SgszZo0zGpF), out var result5))
						{
							goto IL_0045;
						}
						goto IL_00bf;
						IL_00bf:
						_XDKgJpkUD4lIN2K7ysMOtqO5gMA();
						int num58 = -301097777;
						goto IL_0096;
						IL_0096:
						while (true)
						{
							uint num59;
							switch ((num59 = (uint)num58 ^ 0x8E992273u) % 6u)
							{
							case 5u:
								_fA3AcauqZZ0ncWKv9QA3iklruOI(_9ycmcfwZ9EbmXanrFe7pEfGAAUi, out _kyexzK2VL0y9etRuX79HInHIsIb, out _46o2iZ9juR1nNURyrP41h9vxpGA, out _xX4CfdHl6arem4v3fUgbDUIK2gM);
								num58 = ((int)num59 * -288197906) ^ -1192248399;
								continue;
							case 3u:
								break;
							case 2u:
								((Color)(ref _9ycmcfwZ9EbmXanrFe7pEfGAAUi)).set_G((byte)_003C_003Ec__DisplayClass44_0.smethod_7(0, _003C_003Ec__DisplayClass44_0.smethod_6(result5, 255)));
								num58 = ((int)num59 * -679133173) ^ -1076205096;
								continue;
							case 0u:
								action_0(_9ycmcfwZ9EbmXanrFe7pEfGAAUi);
								num58 = ((int)num59 * -205755697) ^ 0x7B106410;
								continue;
							default:
								return;
							case 1u:
								goto IL_00bf;
							case 4u:
								return;
							}
							break;
						}
						goto IL_0045;
						IL_0045:
						num58 = -180501459;
						goto IL_0096;
					});
					num = ((int)num2 * -1376307480) ^ -436645521;
					continue;
				case 3u:
					array[num4 * val4.get_Width() + num5] = (int)((Color)(ref val5)).get_PackedValue();
					num = -1412716450;
					continue;
				case 2u:
					((ActiveList<Control>)(object)val3.get_Content().get_Controls()).Add((Control)(object)_8vFoRw3vIHPno8g3WIeCBRRueVP);
					num = (int)((num2 * 1264282618) ^ 0x483B0452);
					continue;
				case 1u:
					_Vo3fFvvroxYzfCOI5F4PqiMr0Gb = new int[_3PAjrCP0TE07YQ22X6EIpPwOlib.get_Width() * _3PAjrCP0TE07YQ22X6EIpPwOlib.get_Height()];
					num3 = 0;
					num = (int)((num2 * 1274509550) ^ 0x4B801933);
					continue;
				case 0u:
					((ActiveList<Control>)(object)val.get_Content().get_Controls()).Add((Control)(object)val2);
					num = ((int)num2 * -139246553) ^ 0x7DB8B9BD;
					continue;
				default:
					return;
				case 50u:
					break;
				case 70u:
					return;
				}
				break;
			}
		}
	}

	public static void _fA3AcauqZZ0ncWKv9QA3iklruOI(Color color_0, out float float_0, out float float_1, out float float_2)
	{
		float num = 0f;
		float num2 = (int)Math.Min(Math.Min(((Color)(ref color_0)).get_R(), ((Color)(ref color_0)).get_G()), ((Color)(ref color_0)).get_B());
		float num6 = default(float);
		float num8 = default(float);
		float num5 = default(float);
		while (true)
		{
			int num3 = 909649603;
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)num3 ^ 0x546498D3u) % 21u)
				{
				case 20u:
					float_0 = num;
					float_1 = (float)Math.Round(num6, 2);
					float_2 = num8 / 255f;
					num3 = 406017622;
					continue;
				case 19u:
					num = 360f;
					num3 = ((int)num4 * -1911234327) ^ -1554369755;
					continue;
				case 18u:
				{
					int num9;
					int num10;
					if ((double)num8 <= 0.0)
					{
						num9 = -876892685;
						num10 = -876892685;
					}
					else
					{
						num9 = -567888491;
						num10 = -567888491;
					}
					num3 = num9 ^ (int)(num4 * 888894247);
					continue;
				}
				case 17u:
				{
					int num13;
					if ((float)(int)((Color)(ref color_0)).get_R() <= num8)
					{
						num3 = 72447669;
						num13 = 72447669;
					}
					else
					{
						num3 = 1277678856;
						num13 = 1277678856;
					}
					continue;
				}
				case 16u:
					num6 = num5 / num8;
					num3 = 344457304;
					continue;
				case 15u:
					num8 = (int)Math.Max(Math.Max(((Color)(ref color_0)).get_R(), ((Color)(ref color_0)).get_G()), ((Color)(ref color_0)).get_B());
					num3 = ((int)num4 * -596194274) ^ -346115191;
					continue;
				case 14u:
				{
					int num14;
					if ((float)(int)((Color)(ref color_0)).get_B() > num8)
					{
						num3 = 1238983974;
						num14 = 1238983974;
					}
					else
					{
						num3 = 1665779249;
						num14 = 1665779249;
					}
					continue;
				}
				case 13u:
					num5 = num8 - num2;
					num3 = (int)((num4 * 497796698) ^ 0x36E60BAB);
					continue;
				case 12u:
					num = 4f + (float)(((Color)(ref color_0)).get_R() - ((Color)(ref color_0)).get_G()) / num5;
					num3 = ((int)num4 * -827588543) ^ -679185852;
					continue;
				case 11u:
					num3 = ((int)num4 * -105188006) ^ -1298004234;
					continue;
				case 9u:
				{
					int num12;
					if (num6 > 0f)
					{
						num3 = 986286566;
						num12 = 986286566;
					}
					else
					{
						num3 = 360945297;
						num12 = 360945297;
					}
					continue;
				}
				case 8u:
					num = (float)(((Color)(ref color_0)).get_G() - ((Color)(ref color_0)).get_B()) / num5;
					num3 = (int)((num4 * 1809827897) ^ 0x5E72034E);
					continue;
				case 7u:
					num3 = ((int)num4 * -625826552) ^ -1732633186;
					continue;
				case 6u:
				{
					int num11;
					if ((float)(int)((Color)(ref color_0)).get_G() <= num8)
					{
						num3 = 1509909282;
						num11 = 1509909282;
					}
					else
					{
						num3 = 1733788195;
						num11 = 1733788195;
					}
					continue;
				}
				case 5u:
				{
					num *= 60f;
					int num7;
					if ((double)num <= 0.0)
					{
						num3 = 1276095503;
						num7 = 1276095503;
					}
					else
					{
						num3 = 1136101687;
						num7 = 1136101687;
					}
					continue;
				}
				case 4u:
					num6 = 0f;
					num3 = (int)((num4 * 2060250160) ^ 0x821D080);
					continue;
				case 3u:
					num3 = (int)((num4 * 749120478) ^ 0x3BD5256C);
					continue;
				case 1u:
					num += 360f;
					num3 = (int)((num4 * 317852637) ^ 0x5C7D9CDB);
					continue;
				case 0u:
					num = 2f + (float)(((Color)(ref color_0)).get_B() - ((Color)(ref color_0)).get_R()) / num5;
					num3 = ((int)num4 * -391116270) ^ -1566291818;
					continue;
				default:
					return;
				case 2u:
					break;
				case 10u:
					return;
				}
				break;
			}
		}
	}

	private static Color _lAdyiyyWQrRKWYduTPacHqdzOmj(double double_0, double double_1, double double_2, float float_0)
	{
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		if (double_1 <= 0.0)
		{
			goto IL_0113;
		}
		goto IL_02bc;
		IL_02bc:
		int num;
		int num2;
		if (!(double_0 >= 360.0))
		{
			num = -835690099;
			num2 = -835690099;
		}
		else
		{
			num = -1598825147;
			num2 = -1598825147;
		}
		goto IL_0232;
		IL_0232:
		double num6 = default(double);
		double num4 = default(double);
		double num5 = default(double);
		double num11 = default(double);
		double num7 = default(double);
		double num8 = default(double);
		int num10 = default(int);
		double num9 = default(double);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0xC12F029Cu) % 26u)
			{
			case 25u:
				num6 = double_2;
				num = (int)(num3 * 995467817) ^ -876575947;
				continue;
			case 24u:
				num = ((int)num3 * -1412866497) ^ 0x9B0B30F;
				continue;
			case 23u:
				num4 = double_2;
				num5 = num11;
				num6 = num7;
				num = -760078688;
				continue;
			case 21u:
				num4 = num8;
				num5 = num11;
				num = -372340975;
				continue;
			case 20u:
				goto IL_006e;
			case 19u:
				goto IL_0080;
			case 18u:
				num6 = double_2;
				num = (int)((num3 * 8677853) ^ 0x5774C90E);
				continue;
			case 17u:
				goto IL_00a2;
			case 16u:
				num10 = (int)double_0;
				num9 = double_0 - (double)num10;
				num = -2068134799;
				continue;
			case 15u:
				double_0 /= 60.0;
				num = -268967942;
				continue;
			case 14u:
				num = ((int)num3 * -1881293337) ^ 0x2634E940;
				continue;
			case 13u:
				num11 = double_2 * (1.0 - double_1);
				num = ((int)num3 * -1044247663) ^ -594222125;
				continue;
			case 11u:
				break;
			case 10u:
				num6 = double_2;
				num = ((int)num3 * -494737884) ^ 0x6DB584AB;
				continue;
			case 9u:
				num = (int)((num3 * 2068857513) ^ 0x6759258F);
				continue;
			case 8u:
				num4 = double_2;
				num = ((int)num3 * -1199203899) ^ 0x44840DAD;
				continue;
			case 7u:
				double_0 = 0.0;
				num = (int)(num3 * 1011061349) ^ -82671561;
				continue;
			case 6u:
				num7 = double_2 * (1.0 - double_1 * num9);
				num8 = double_2 * (1.0 - double_1 * (1.0 - num9));
				switch (num10)
				{
				case 4:
					break;
				case 1:
					goto IL_006e;
				case 2:
					goto IL_0080;
				case 0:
					goto IL_00a2;
				default:
					goto IL_01c0;
				case 3:
					goto IL_01d0;
				}
				goto case 21u;
			case 0u:
				goto IL_01d0;
			case 5u:
				num5 = double_2;
				num = ((int)num3 * -1443163305) ^ 0x1F92D19B;
				continue;
			case 4u:
				num6 = num8;
				num = ((int)num3 * -265799960) ^ -867561264;
				continue;
			case 3u:
				num5 = double_2;
				num = (int)((num3 * 73329338) ^ 0x62D141A8);
				continue;
			case 2u:
				num = ((int)num3 * -758028869) ^ 0x7AC1D40C;
				continue;
			case 1u:
				num5 = num7;
				num = ((int)num3 * -1602126933) ^ 0x761C0535;
				continue;
			case 12u:
				goto IL_02bc;
			default:
				{
					return new Color((float)num4, (float)num5, (float)num6, float_0);
				}
				IL_01d0:
				num4 = num11;
				num = -1967482177;
				continue;
				IL_01c0:
				num = ((int)num3 * -727957896) ^ 0x10B3484E;
				continue;
				IL_00a2:
				num4 = double_2;
				num5 = num8;
				num6 = num11;
				num = -1461158440;
				continue;
				IL_0080:
				num4 = num11;
				num = -446467621;
				continue;
				IL_006e:
				num4 = num7;
				num5 = double_2;
				num6 = num11;
				num = -760078688;
				continue;
			}
			break;
		}
		goto IL_0113;
		IL_0113:
		num = -1944129168;
		goto IL_0232;
	}

	[CompilerGenerated]
	private void _PbAre2mvcfhjcz2aGEBHyQxjoABA()
	{
		if (PlayerCustomizationScene.smethod_52(PlayerCustomizationScene.smethod_20((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)) == null)
		{
			return;
		}
		while (true)
		{
			int num = -1808072291;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8AC7F9BAu) % 3u)
				{
				case 2u:
					goto IL_000f;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_000f:
				PlayerCustomizationScene.smethod_53(PlayerCustomizationScene.smethod_52(PlayerCustomizationScene.smethod_20((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)));
				num = (int)((num2 * 1793340020) ^ 0x2AEECD45);
			}
		}
	}

	[CompilerGenerated]
	private void _ChpMy0SmbTQ1KKcG7mq5rKoRm8E()
	{
		_OBIbaNO8X49ahEZ5n3Ta8HUK7mO(PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_TbkP67ntBpYJu1M27pBfsYAHmgJ)));
	}

	[CompilerGenerated]
	private void _i9Xj1KSWViEd71ALYa9ApJ2Gc9y()
	{
		_jiNxMIzuA8Rrc2ULsrob5A7UNDe(PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_TbkP67ntBpYJu1M27pBfsYAHmgJ)));
	}

	[CompilerGenerated]
	private void _3VjzhxKSwnPtdk4XhY3iFmHrG1H()
	{
		_1qIQUjhrbk5WA7C7mYs93gXLOIe(PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_TbkP67ntBpYJu1M27pBfsYAHmgJ)));
	}

	[CompilerGenerated]
	private void _pKgyzskaeOQ1TRYcUjxy3zMiF5T()
	{
		_VCrdQDifkN8NHlzPICTmtbgWFwp(PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_TbkP67ntBpYJu1M27pBfsYAHmgJ)));
	}

	[CompilerGenerated]
	private void _VIr0RlSCz9V0frZhjT6BsMYn28U()
	{
		_vXrWU56trsuFNc9CNcHuctfkI2S(PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_TbkP67ntBpYJu1M27pBfsYAHmgJ)));
	}

	[CompilerGenerated]
	private void _1KOufZWxXAv4lBCHX0VbC5pdIhN()
	{
		_vg6ASaP7xNqc0jerF3mcrXv4dn7(PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_TbkP67ntBpYJu1M27pBfsYAHmgJ)));
	}

	[CompilerGenerated]
	private void _w91LaUOFTCMT9AffWnTo1PJ3EMr()
	{
		_Xhurp3mVVoR5kNlnxgLoDDkeQxM(PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_TbkP67ntBpYJu1M27pBfsYAHmgJ)));
	}

	[CompilerGenerated]
	private void _BZPbyIJWfbmS1NEIAww1KgTP1vg()
	{
		_gHA9C0CRN2NaRMtfTrvlotJOd0T(PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_TbkP67ntBpYJu1M27pBfsYAHmgJ)));
	}

	[CompilerGenerated]
	private void _kgalrc04EwTy7lf17UuFH8tkWJe()
	{
		_hNo7o9fG9jvwcKyMq1nYl4q7cXc(PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_TbkP67ntBpYJu1M27pBfsYAHmgJ)));
	}

	[CompilerGenerated]
	private void _AkTV7h3XKguAhStEd33YiNZJ7Re()
	{
		_mWS8UuA4xcT1bSdjDObiubOE0wH(PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_TbkP67ntBpYJu1M27pBfsYAHmgJ)));
	}

	[CompilerGenerated]
	private void _V87FuhPcqj5irT0Wrn5TCo9Ae9B()
	{
		_7JR6eL4D0qdIJNOwfInnlg2HEgZ(PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_TbkP67ntBpYJu1M27pBfsYAHmgJ)));
	}

	[CompilerGenerated]
	private void _ybtbM3zRgg2shH5mHioQuMHwlaBA()
	{
		_PBEdYyzYEWcXAodjVf58ocOQ3Jf(PlayerCustomizationScene.smethod_33(PlayerCustomizationScene.smethod_32(_TbkP67ntBpYJu1M27pBfsYAHmgJ)));
	}

	[CompilerGenerated]
	private void _dG9yFv0qkL01EP97OGwo3r3q2IC(int int_0)
	{
		if (int_0 != 1)
		{
			return;
		}
		while (true)
		{
			int num = -1119413093;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF405B827u) % 3u)
				{
				case 2u:
					goto IL_0006;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0006:
				PlayerCustomizationScene.smethod_20((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._k9wUPeU1Ga7cygiuGP8TT6aPLWF<MainMenuScene>();
				num = (int)(num2 * 257050640) ^ -437346073;
			}
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
