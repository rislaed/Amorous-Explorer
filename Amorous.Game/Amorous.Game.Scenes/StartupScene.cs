using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using Amorous.Game.NPC;
using Newtonsoft.Json;
using Squid;

namespace Amorous.Game.Scenes;

public class StartupScene : _7UlnfykmEmZDFt3BmCKZekI43Ih
{
	private class ApiLogin
	{
		[JsonProperty("username")]
		public string _LG9P2ATIfMzK27guq7fnGxxILwD { get; set; }

		[JsonProperty("password")]
		public string _zGqOm5iY9wKtyOLEu81UskKVggC { get; set; }
	}

	private class ApiReponse
	{
		[JsonProperty("error")]
		public bool _0rEYVY1cDKfLPVuLw54UlaIts2m { get; set; }

		[JsonProperty("message")]
		public string _NvMJ5jDaeRR7HysERrVDtSlxaI5 { get; set; }

		[JsonProperty("userGroups")]
		public string[] _U5SWg5Bx5R0vX25DxhWQ0Twb1eh { get; set; }

		[JsonProperty("timestamp")]
		public string _3QVueTX1TxhBB03hZbnibQdussEb { get; set; }

		[JsonProperty("hash")]
		public string _uNi8yrQVBFzFdV8f7FGmr8Vhobf { get; set; }
	}

	private static readonly string _Pxncvon3rRvuowKL1yYBOZjpf2y = StartupScene.smethod_26(StartupScene.smethod_25(StartupScene.smethod_24()), "username.txt");

	private readonly TextBox _njC7ZfEM6PTCffwkw18LisM3W9E;

	private readonly CheckBox _9nCiJkYgPYczxXJNlo8Z7BbfdsB;

	public StartupScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected O, but got Unknown
		StartupScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Intro/Background", 0, -540);
		StartupScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Intro/Scenery", 0, -170);
		StartupScene.smethod_15((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Title", "Assets/Scenes/MainMenu/Logo", 616, 50);
		StartupScene.smethod_16("Assets/Music/Biggyzoom - The Night Sky", 0.4f);
		Window obj = StartupScene.smethod_17();
		((Control)obj).set_Position(new Point(704, 412));
		((Control)obj).set_Size(new Point(512, 285));
		Window val = obj;
		Label val2 = new Label();
		((Control)val2).set_Position(new Point(15, 15));
		((Control)val2).set_AutoSize((AutoSize)3);
		val2.set_Text("Thank you for playing Amorous!\n\nThis release is for patrons only. To verify this, please\nlogin using your forum credentials below:");
		Label val3 = val2;
		Label val4 = new Label();
		((Control)val4).set_Position(new Point(15, 135));
		((Control)val4).set_AutoSize((AutoSize)3);
		val4.set_Text("Username:");
		Label val5 = val4;
		TextBox val6 = new TextBox();
		((Control)val6).set_Position(new Point(140, 130));
		((Control)val6).set_Size(new Point(200, 30));
		((Control)val6).set_TabIndex(1);
		_njC7ZfEM6PTCffwkw18LisM3W9E = val6;
		if (File.Exists(_Pxncvon3rRvuowKL1yYBOZjpf2y))
		{
			_njC7ZfEM6PTCffwkw18LisM3W9E.set_Text(File.ReadAllText(_Pxncvon3rRvuowKL1yYBOZjpf2y));
		}
		Label val7 = new Label();
		((Control)val7).set_Position(new Point(15, 170));
		((Control)val7).set_AutoSize((AutoSize)3);
		val7.set_Text("Password:");
		Label val8 = val7;
		TextBox val9 = new TextBox();
		((Control)val9).set_Position(new Point(140, 165));
		((Control)val9).set_Size(new Point(200, 30));
		((Control)val9).set_TabIndex(2);
		val9.set_IsPassword(true);
		TextBox _mzwWNbSlBetGnbEr0j6IpMenjkp = val9;
		CheckBox val10 = new CheckBox();
		((Control)val10).set_Position(new Point(15, 200));
		((Control)val10).set_Size(new Point(300, 30));
		val10.set_Text("Remember username");
		val10.set_Checked(true);
		_9nCiJkYgPYczxXJNlo8Z7BbfdsB = val10;
		Button val11 = new Button();
		((Control)val11).set_Position(new Point(15, 240));
		((Label)val11).set_Text("Login");
		Button val12 = val11;
		((Control)val12).add_MouseClick((MouseEvent)delegate
		{
			try
			{
				WebRequest webRequest_ = _003C_003Ec__DisplayClass5_0.smethod_0("https://download.amorousgame.com/api/v4/launcherLogin");
				while (true)
				{
					int num = -437185949;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x869C7D9Au) % 3u)
						{
						case 1u:
							goto IL_000e;
						case 2u:
							break;
						default:
						{
							StreamWriter streamWriter = _003C_003Ec__DisplayClass5_0.smethod_3(_003C_003Ec__DisplayClass5_0.smethod_2(webRequest_));
							try
							{
								_003C_003Ec__DisplayClass5_0.smethod_6((TextWriter)streamWriter, _003C_003Ec__DisplayClass5_0.smethod_5((object)new ApiLogin
								{
									_LG9P2ATIfMzK27guq7fnGxxILwD = _003C_003Ec__DisplayClass5_0.smethod_4(_njC7ZfEM6PTCffwkw18LisM3W9E),
									_zGqOm5iY9wKtyOLEu81UskKVggC = _003C_003Ec__DisplayClass5_0.smethod_4(_mzwWNbSlBetGnbEr0j6IpMenjkp)
								}));
							}
							finally
							{
								if (streamWriter != null)
								{
									while (true)
									{
										IL_00c5:
										int num3 = -1691695578;
										while (true)
										{
											switch ((num2 = (uint)num3 ^ 0x869C7D9Au) % 3u)
											{
											case 1u:
												goto IL_0095;
											default:
												goto end_IL_00a8;
											case 0u:
												break;
											case 2u:
												goto end_IL_00a8;
											}
											goto IL_00c5;
											IL_0095:
											_003C_003Ec__DisplayClass5_0.smethod_7((IDisposable)streamWriter);
											num3 = (int)(num2 * 613339861) ^ -1184267403;
											continue;
											end_IL_00a8:
											break;
										}
										break;
									}
								}
							}
							StreamReader streamReader = _003C_003Ec__DisplayClass5_0.smethod_10(_003C_003Ec__DisplayClass5_0.smethod_9(_003C_003Ec__DisplayClass5_0.smethod_8(webRequest_)));
							try
							{
								ApiReponse apiReponse = JsonConvert.DeserializeObject<ApiReponse>(_003C_003Ec__DisplayClass5_0.smethod_11((TextReader)streamReader));
								while (true)
								{
									int num4 = -808294528;
									while (true)
									{
										switch ((num2 = (uint)num4 ^ 0x869C7D9Au) % 8u)
										{
										case 7u:
											_003C_003Ec__DisplayClass5_0.smethod_13(_003C_003Ec__DisplayClass5_0.smethod_12((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), apiReponse._NvMJ5jDaeRR7HysERrVDtSlxaI5, 500, "OK", (Action)null);
											num4 = (int)(num2 * 1944003615) ^ -1579978723;
											continue;
										case 5u:
											_x8adRt6rvrXniPFYijbzqvPFr4j();
											num4 = (int)(num2 * 1041979734) ^ -1549281700;
											continue;
										case 3u:
											_003C_003Ec__DisplayClass5_0.smethod_13(_003C_003Ec__DisplayClass5_0.smethod_12((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "Sorry, please try again!", 250, "OK", (Action)null);
											num4 = -1458244276;
											continue;
										case 2u:
										{
											int num6;
											int num7;
											if (!apiReponse._0rEYVY1cDKfLPVuLw54UlaIts2m)
											{
												num6 = -1544626045;
												num7 = -1544626045;
											}
											else
											{
												num6 = -1985841515;
												num7 = -1985841515;
											}
											num4 = num6 ^ (int)(num2 * 1586276544);
											continue;
										}
										case 1u:
										{
											string string_ = _003C_003Ec__DisplayClass5_0.smethod_15(_003C_003Ec__DisplayClass5_0.smethod_14(_003C_003Ec__DisplayClass5_0.smethod_4(_njC7ZfEM6PTCffwkw18LisM3W9E), _003C_003Ec__DisplayClass5_0.smethod_4(_mzwWNbSlBetGnbEr0j6IpMenjkp), apiReponse._NvMJ5jDaeRR7HysERrVDtSlxaI5, apiReponse._3QVueTX1TxhBB03hZbnibQdussEb));
											int num5;
											if (_003C_003Ec__DisplayClass5_0.smethod_16(string_, apiReponse._uNi8yrQVBFzFdV8f7FGmr8Vhobf))
											{
												num4 = -2128223729;
												num5 = -2128223729;
											}
											else
											{
												num4 = -161076639;
												num5 = -161076639;
											}
											continue;
										}
										case 0u:
											num4 = ((int)num2 * -2061249757) ^ 0x27CB8C14;
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
							finally
							{
								if (streamReader != null)
								{
									while (true)
									{
										IL_0272:
										int num8 = -574922076;
										while (true)
										{
											switch ((num2 = (uint)num8 ^ 0x869C7D9Au) % 3u)
											{
											case 1u:
												goto IL_0242;
											default:
												goto end_IL_0255;
											case 0u:
												break;
											case 2u:
												goto end_IL_0255;
											}
											goto IL_0272;
											IL_0242:
											_003C_003Ec__DisplayClass5_0.smethod_7((IDisposable)streamReader);
											num8 = ((int)num2 * -1148353869) ^ -713398814;
											continue;
											end_IL_0255:
											break;
										}
										break;
									}
								}
							}
						}
						}
						break;
						IL_000e:
						_003C_003Ec__DisplayClass5_0.smethod_1(webRequest_, "POST");
						num = (int)((num2 * 544097791) ^ 0x2A3C6730);
					}
				}
			}
			catch (Exception)
			{
				_003C_003Ec__DisplayClass5_0.smethod_13(_003C_003Ec__DisplayClass5_0.smethod_12((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "Sorry, an unexpected exception occured, see log-file for more details!", 500, "OK", (Action)null);
			}
		});
		Button val13 = new Button();
		((Control)val13).set_Position(new Point(120, 240));
		((Control)val13).set_Size(new Point(180, 30));
		((Label)val13).set_Text("Forgot password?");
		Button val14 = val13;
		((Control)val14).add_MouseClick((MouseEvent)delegate
		{
			StartupScene.smethod_27(StartupScene.smethod_18((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "https://forums.amorousgame.com/lost-password/");
		});
		((ActiveList<Control>)(object)val.get_Controls()).Add((Control)(object)val3);
		((ActiveList<Control>)(object)val.get_Controls()).Add((Control)(object)val5);
		((ActiveList<Control>)(object)val.get_Controls()).Add((Control)(object)_njC7ZfEM6PTCffwkw18LisM3W9E);
		((ActiveList<Control>)(object)val.get_Controls()).Add((Control)(object)val8);
		((ActiveList<Control>)(object)val.get_Controls()).Add((Control)(object)_mzwWNbSlBetGnbEr0j6IpMenjkp);
		((ActiveList<Control>)(object)val.get_Controls()).Add((Control)(object)_9nCiJkYgPYczxXJNlo8Z7BbfdsB);
		((ActiveList<Control>)(object)val.get_Controls()).Add((Control)(object)val12);
		((ActiveList<Control>)(object)val.get_Controls()).Add((Control)(object)val14);
		((ActiveList<Control>)(object)base._PnkAlVnMv0SZvRBFexqzE5DF9tp.get_Controls()).Add((Control)(object)val);
	}

	public override void _4hlxzMzKSbVTbZUrEsP3dfw4x0h()
	{
		CoupleANPC coupleANPC = StartupScene.smethod_18((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<CoupleANPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
		CoupleBNPC coupleBNPC = default(CoupleBNPC);
		while (true)
		{
			int num = -14711584;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDA4DCFF1u) % 8u)
				{
				case 7u:
					coupleBNPC = StartupScene.smethod_18((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<CoupleBNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
					StartupScene.smethod_19((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)coupleBNPC, 550f);
					num = (int)((num2 * 839937122) ^ 0x240BA35D);
					continue;
				case 4u:
					coupleBNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(CoupleBNPC.EClothes.Shirt, CoupleBNPC.EClothes.Pants);
					num = (int)((num2 * 1146500409) ^ 0x69277F5B);
					continue;
				case 3u:
					coupleANPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(CoupleANPC.EClothes.Shirt, CoupleANPC.EClothes.Pants);
					num = (int)((num2 * 388787959) ^ 0x12431C0B);
					continue;
				case 2u:
					StartupScene.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)coupleBNPC, 1090f);
					coupleBNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(CoupleBNPC.EPoses.Waving);
					num = ((int)num2 * -431074657) ^ 0x288BA05B;
					continue;
				case 1u:
					StartupScene.smethod_19((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)coupleANPC, 350f);
					num = (int)(num2 * 363542561) ^ -1818447544;
					continue;
				case 0u:
					StartupScene.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)coupleANPC, 1090f);
					coupleANPC._tDFvus0ZCanjp81eOiDzoMXJiuf(CoupleANPC.EPoses.Waving);
					num = ((int)num2 * -1165224046) ^ -1283536262;
					continue;
				default:
					return;
				case 5u:
					break;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	private void _x8adRt6rvrXniPFYijbzqvPFr4j()
	{
		if (StartupScene.smethod_21(_9nCiJkYgPYczxXJNlo8Z7BbfdsB))
		{
			goto IL_0033;
		}
		goto IL_0059;
		IL_0059:
		StartupScene.smethod_18((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._k9wUPeU1Ga7cygiuGP8TT6aPLWF<MainMenuScene>();
		int num = -1957975650;
		goto IL_0038;
		IL_0038:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xB90485F9u) % 4u)
			{
			case 2u:
				StartupScene.smethod_23(_Pxncvon3rRvuowKL1yYBOZjpf2y, StartupScene.smethod_22(_njC7ZfEM6PTCffwkw18LisM3W9E));
				num = (int)(num2 * 260091322) ^ -2110397400;
				continue;
			case 0u:
				break;
			default:
				return;
			case 1u:
				goto IL_0059;
			case 3u:
				return;
			}
			break;
		}
		goto IL_0033;
		IL_0033:
		num = -2013978765;
		goto IL_0038;
	}

	[CompilerGenerated]
	private void _bC7RVqWYAiAlsTmOwh7DNLQdIat(Control control_0, MouseEventArgs mouseEventArgs_0)
	{
		StartupScene.smethod_27(StartupScene.smethod_18((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "https://forums.amorousgame.com/lost-password/");
	}

	static _uqydQVaCmCvK7zzWs5W4gZFpKBu smethod_14(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._0O8D0mBgmrh0sLOGcLVvGNOHKLCA(string_0, string_1, int_0, int_1);
	}

	static _uqydQVaCmCvK7zzWs5W4gZFpKBu smethod_15(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._NC5VT77x8y2iH2pW56TBN1eyomA(string_0, string_1, int_0, int_1);
	}

	static void smethod_16(string string_0, float float_0)
	{
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc(string_0, float_0);
	}

	static Window smethod_17()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Window();
	}

	static _JbeCmOie0phb2cbgG6DdGZrbs3pB smethod_18(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._ZzBuoSDMWwerejOO9Goyv2OCKgE;
	}

	static void smethod_19(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_20(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}

	static bool smethod_21(CheckBox checkBox_0)
	{
		return checkBox_0.get_Checked();
	}

	static string smethod_22(TextBox textBox_0)
	{
		return textBox_0.get_Text();
	}

	static void smethod_23(string string_0, string string_1)
	{
		File.WriteAllText(string_0, string_1);
	}

	static AppDomain smethod_24()
	{
		return AppDomain.CurrentDomain;
	}

	static string smethod_25(AppDomain appDomain_0)
	{
		return appDomain_0.BaseDirectory;
	}

	static string smethod_26(string string_0, string string_1)
	{
		return Path.Combine(string_0, string_1);
	}

	static bool smethod_27(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, string string_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._fDSidqggP063WGf2vzkdlA1UDkn(string_0);
	}
}
