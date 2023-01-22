using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Amorous.Game.Scenes;

public class PlayerSexScene : _7UlnfykmEmZDFt3BmCKZekI43Ih
{
	private bool _jOJQdqVUTXcPDmuOqViqC8pczW;

	private SpriteFont _xnYepZuegigJCU2jcbZsfVIakzF;

	public PlayerSexScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		_jOJQdqVUTXcPDmuOqViqC8pczW = true;
		_xnYepZuegigJCU2jcbZsfVIakzF = PlayerSexScene.smethod_14(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0).Load<SpriteFont>(_003CModule_003E.smethod_27<string>(470142692u));
		PlayerSexScene.smethod_15();
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		this.method_0(gameTime_0);
		string[] array = default(string[]);
		int num11 = default(int);
		while (true)
		{
			int num = -1742840305;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9A361302u) % 33u)
				{
				case 32u:
					array = PlayerSexScene.smethod_20(PlayerSexScene.smethod_17(PlayerSexScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)));
					num = (int)(num2 * 1663958595) ^ -335303894;
					continue;
				case 31u:
				{
					int num10;
					if (!PlayerSexScene.smethod_19(PlayerSexScene.smethod_18(PlayerSexScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), (Keys)32))
					{
						num = -1856812993;
						num10 = -1856812993;
					}
					else
					{
						num = -1969255008;
						num10 = -1969255008;
					}
					continue;
				}
				case 30u:
				{
					int num16;
					if (PlayerSexScene.smethod_25(PlayerSexScene.smethod_17(PlayerSexScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this))))
					{
						num = -2084138377;
						num16 = -2084138377;
					}
					else
					{
						num = -275184241;
						num16 = -275184241;
					}
					continue;
				}
				case 28u:
				{
					int num14;
					if (PlayerSexScene.smethod_25(PlayerSexScene.smethod_17(PlayerSexScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this))))
					{
						num = -1336420214;
						num14 = -1336420214;
					}
					else
					{
						num = -670112439;
						num14 = -670112439;
					}
					continue;
				}
				case 27u:
				{
					int num20;
					if (!PlayerSexScene.smethod_19(PlayerSexScene.smethod_18(PlayerSexScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), (Keys)27))
					{
						num = -192259789;
						num20 = -192259789;
					}
					else
					{
						num = -1503575010;
						num20 = -1503575010;
					}
					continue;
				}
				case 26u:
					num11 = 0;
					num = (int)((num2 * 1741380232) ^ 0xCBF7B9C);
					continue;
				case 24u:
					num11 = Array.IndexOf(array, PlayerSexScene.smethod_21(PlayerSexScene.smethod_17(PlayerSexScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this))));
					num = -559899340;
					continue;
				case 23u:
				{
					int num4;
					int num5;
					if (array.Length == 0)
					{
						num4 = 871164809;
						num5 = 871164809;
					}
					else
					{
						num4 = 524828716;
						num5 = 524828716;
					}
					num = num4 ^ ((int)num2 * -1612687050);
					continue;
				}
				case 22u:
					PlayerSexScene.smethod_28(PlayerSexScene.smethod_17(PlayerSexScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)));
					num = (int)(num2 * 1541601564) ^ -58352558;
					continue;
				case 21u:
					PlayerSexScene.smethod_24(PlayerSexScene.smethod_17(PlayerSexScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), -1, bool_0: false);
					num = (int)(num2 * 1153737705) ^ -199484983;
					continue;
				case 19u:
					_poenyHBGUusBcnNcTFB9MQBV72R._Oewx0FJJ8VX41Prmv0htvGQZhUf();
					num = (int)((num2 * 1883988848) ^ 0x693A973);
					continue;
				case 18u:
					_jOJQdqVUTXcPDmuOqViqC8pczW = !_jOJQdqVUTXcPDmuOqViqC8pczW;
					num = (int)(num2 * 324254468) ^ -428730429;
					continue;
				case 17u:
				{
					int num21;
					if (!PlayerSexScene.smethod_23())
					{
						num = -744571897;
						num21 = -744571897;
					}
					else
					{
						num = -1363198156;
						num21 = -1363198156;
					}
					continue;
				}
				case 16u:
				{
					int num15;
					if (PlayerSexScene.smethod_19(PlayerSexScene.smethod_18(PlayerSexScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), (Keys)83))
					{
						num = -1441844630;
						num15 = -1441844630;
					}
					else
					{
						num = -1314318591;
						num15 = -1314318591;
					}
					continue;
				}
				case 14u:
				{
					int num8;
					int num9;
					if (PlayerSexScene.smethod_19(PlayerSexScene.smethod_18(PlayerSexScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), (Keys)88))
					{
						num8 = -2008818832;
						num9 = -2008818832;
					}
					else
					{
						num8 = -1992306388;
						num9 = -1992306388;
					}
					num = num8 ^ (int)(num2 * 740703704);
					continue;
				}
				case 12u:
					PlayerSexScene.smethod_22(PlayerSexScene.smethod_17(PlayerSexScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), array[num11]);
					num = -1314318591;
					continue;
				case 11u:
				{
					int num24;
					if (!PlayerSexScene.smethod_19(PlayerSexScene.smethod_18(PlayerSexScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), (Keys)90))
					{
						num = -750405825;
						num24 = -750405825;
					}
					else
					{
						num = -1506179587;
						num24 = -1506179587;
					}
					continue;
				}
				case 10u:
					PlayerSexScene.smethod_26(PlayerSexScene.smethod_17(PlayerSexScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)));
					num = (int)(num2 * 1240858794) ^ -537876375;
					continue;
				case 9u:
				{
					int num22;
					int num23;
					if (PlayerSexScene.smethod_17(PlayerSexScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)) != null)
					{
						num22 = 1886872676;
						num23 = 1886872676;
					}
					else
					{
						num22 = 428692622;
						num23 = 428692622;
					}
					num = num22 ^ (int)(num2 * 970740542);
					continue;
				}
				case 8u:
				{
					int num18;
					int num19;
					if (!PlayerSexScene.smethod_19(PlayerSexScene.smethod_18(PlayerSexScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), (Keys)86))
					{
						num18 = -1399888170;
						num19 = -1399888170;
					}
					else
					{
						num18 = -752648380;
						num19 = -752648380;
					}
					num = num18 ^ ((int)num2 * -1567477356);
					continue;
				}
				case 6u:
				{
					int num17;
					if (!PlayerSexScene.smethod_25(PlayerSexScene.smethod_17(PlayerSexScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this))))
					{
						num = -285596348;
						num17 = -285596348;
					}
					else
					{
						num = -1640519339;
						num17 = -1640519339;
					}
					continue;
				}
				case 5u:
				{
					int num12;
					int num13;
					if (num11 >= array.Length)
					{
						num12 = 1383126226;
						num13 = 1383126226;
					}
					else
					{
						num12 = 1329268618;
						num13 = 1329268618;
					}
					num = num12 ^ (int)(num2 * 1137923606);
					continue;
				}
				case 4u:
					PlayerSexScene.smethod_24(PlayerSexScene.smethod_17(PlayerSexScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), 1, bool_0: false);
					num = ((int)num2 * -2032810966) ^ -213825877;
					continue;
				case 3u:
					num11++;
					num = (int)(num2 * 1739173396) ^ -1063163165;
					continue;
				case 2u:
				{
					int num6;
					int num7;
					if (PlayerSexScene.smethod_19(PlayerSexScene.smethod_18(PlayerSexScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), (Keys)67))
					{
						num6 = 213967828;
						num7 = 213967828;
					}
					else
					{
						num6 = 137969375;
						num7 = 137969375;
					}
					num = num6 ^ (int)(num2 * 921168200);
					continue;
				}
				case 0u:
				{
					int num3;
					if (PlayerSexScene.smethod_19(PlayerSexScene.smethod_18(PlayerSexScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), (Keys)162))
					{
						num = -1286458607;
						num3 = -1286458607;
					}
					else
					{
						num = -217754750;
						num3 = -217754750;
					}
					continue;
				}
				default:
					return;
				case 20u:
					break;
				case 1u:
					PlayerSexScene.smethod_27(PlayerSexScene.smethod_17(PlayerSexScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)));
					return;
				case 7u:
					return;
				case 13u:
					return;
				case 15u:
					return;
				case 25u:
					return;
				case 29u:
					return;
				}
				break;
			}
		}
	}

	public override void _Z70nK2EA1n5FNJxjWP0TzHQ0Lzb(SpriteBatch spriteBatch_0)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		this.method_1(spriteBatch_0);
		if (!PlayerSexScene.smethod_29(PlayerSexScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)))
		{
			goto IL_0149;
		}
		goto IL_0427;
		IL_0427:
		PlayerSexScene.smethod_30(spriteBatch_0);
		int num;
		int num2;
		if (!PlayerSexScene.smethod_23())
		{
			num = 1321112229;
			num2 = 1321112229;
		}
		else
		{
			num = 636362123;
			num2 = 636362123;
		}
		goto IL_03b2;
		IL_03b2:
		int num6 = default(int);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0x7E55E8ADu) % 21u)
			{
			case 20u:
				break;
			case 19u:
				spriteBatch_0._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, _003CModule_003E.smethod_24<string>(57184713u), new Vector2(10f, (float)num6), Color.get_White());
				num6 += 40;
				num = (int)(num3 * 1781450043) ^ -93400351;
				continue;
			case 18u:
				spriteBatch_0._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, _003CModule_003E.smethod_25<string>(2561873802u), new Vector2(10f, 10f), Color.get_White());
				num = (int)(num3 * 104529466) ^ -1293755235;
				continue;
			case 17u:
			{
				int num11;
				int num12;
				if (base._ZzBuoSDMWwerejOO9Goyv2OCKgE._KVSwpLj0RvURRswHn7ogRy4BRfd == null)
				{
					num11 = 1148385012;
					num12 = 1148385012;
				}
				else
				{
					num11 = 1441121044;
					num12 = 1441121044;
				}
				num = num11 ^ ((int)num3 * -1531485580);
				continue;
			}
			case 16u:
				num = (int)((num3 * 1470318196) ^ 0x66A82F1);
				continue;
			case 15u:
				spriteBatch_0._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, _003CModule_003E.smethod_28<string>(2659562065u), new Vector2(10f, 250f), Color.get_White());
				num = (int)((num3 * 1005202226) ^ 0x570C158A);
				continue;
			case 14u:
				goto end_IL_03b2;
			case 13u:
			{
				int num7;
				int num8;
				if (PlayerSexScene.smethod_17(PlayerSexScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)) != null)
				{
					num7 = -1173172339;
					num8 = -1173172339;
				}
				else
				{
					num7 = -1773047182;
					num8 = -1773047182;
				}
				num = num7 ^ (int)(num3 * 465305437);
				continue;
			}
			case 11u:
				spriteBatch_0._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, _003CModule_003E.smethod_25<string>(10205988u), new Vector2(10f, 170f), Color.get_White());
				num = ((int)num3 * -269018047) ^ -1256017448;
				continue;
			case 10u:
				spriteBatch_0._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, _003CModule_003E.smethod_25<string>(2091829731u), new Vector2(10f, (float)num6), Color.get_White());
				num = 1731638365;
				continue;
			case 9u:
				spriteBatch_0._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, _003CModule_003E.smethod_24<string>(2617887195u), new Vector2(10f, 90f), Color.get_White());
				num = ((int)num3 * -746965212) ^ -1698621788;
				continue;
			case 8u:
			{
				int num9;
				int num10;
				if (PlayerSexScene.smethod_20(PlayerSexScene.smethod_17(PlayerSexScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this))).Length == 0)
				{
					num9 = 2081371934;
					num10 = 2081371934;
				}
				else
				{
					num9 = 522147920;
					num10 = 522147920;
				}
				num = num9 ^ (int)(num3 * 1648558130);
				continue;
			}
			case 7u:
				spriteBatch_0._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, _003CModule_003E.smethod_27<string>(3268442155u), new Vector2(10f, 130f), Color.get_White());
				num = (int)(num3 * 995289692) ^ -1175551968;
				continue;
			case 6u:
				num6 = 10;
				num = ((int)num3 * -504693121) ^ 0x60759B83;
				continue;
			case 5u:
			{
				int num4;
				int num5;
				if (base._ZzBuoSDMWwerejOO9Goyv2OCKgE._KVSwpLj0RvURRswHn7ogRy4BRfd._tCw3HO9jqoEm2Ad1hqdKsA8vS7b().Length == 0)
				{
					num4 = 457424666;
					num5 = 457424666;
				}
				else
				{
					num4 = 1637752540;
					num5 = 1637752540;
				}
				num = num4 ^ (int)(num3 * 83208526);
				continue;
			}
			case 4u:
				spriteBatch_0._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, _003CModule_003E.smethod_27<string>(3987284416u), new Vector2(10f, 10f), Color.get_White());
				num = 1731638365;
				continue;
			case 3u:
				spriteBatch_0._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, _003CModule_003E.smethod_27<string>(403924873u), new Vector2(10f, 290f), Color.get_White());
				spriteBatch_0._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, _003CModule_003E.smethod_28<string>(1590504138u), new Vector2(10f, 330f), Color.get_White());
				num = 962614602;
				continue;
			case 0u:
				spriteBatch_0._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, _003CModule_003E.smethod_28<string>(3734865188u), new Vector2(10f, 50f), Color.get_White());
				num = ((int)num3 * -1841367806) ^ -597590710;
				continue;
			case 1u:
				goto IL_0427;
			case 2u:
				return;
			default:
				spriteBatch_0.End();
				return;
			}
			int num13;
			if (!_jOJQdqVUTXcPDmuOqViqC8pczW)
			{
				num = 1594144391;
				num13 = 1594144391;
			}
			else
			{
				num = 1863616310;
				num13 = 1863616310;
			}
			continue;
			end_IL_03b2:
			break;
		}
		goto IL_0149;
		IL_0149:
		num = 1533583273;
		goto IL_03b2;
	}

	static ContentManager smethod_14(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8;
	}

	static void smethod_15()
	{
		_UmxbIbk7pgaod0bD7pS309P3Lns._h0KfaNiikKlJV2KkRPIdVDKVJnC();
	}

	void method_0(GameTime gameTime_0)
	{
		base._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
	}

	static _JbeCmOie0phb2cbgG6DdGZrbs3pB smethod_16(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._ZzBuoSDMWwerejOO9Goyv2OCKgE;
	}

	static _TwlwMC1hhdSzamwGWEBxuUkz1gH smethod_17(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._KVSwpLj0RvURRswHn7ogRy4BRfd;
	}

	static _3FFZvGWTAe7rsviKkDPTXEVjxWf smethod_18(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._RbWJ7YGnYHCSoD44MRW1h5X6E7E;
	}

	static bool smethod_19(_3FFZvGWTAe7rsviKkDPTXEVjxWf _3FFZvGWTAe7rsviKkDPTXEVjxWf_0, Keys keys_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _3FFZvGWTAe7rsviKkDPTXEVjxWf_0._fy5ebLnmRsRXv9v7RKTFU5CGMaH(keys_0);
	}

	static string[] smethod_20(_TwlwMC1hhdSzamwGWEBxuUkz1gH _TwlwMC1hhdSzamwGWEBxuUkz1gH_0)
	{
		return _TwlwMC1hhdSzamwGWEBxuUkz1gH_0._tCw3HO9jqoEm2Ad1hqdKsA8vS7b();
	}

	static string smethod_21(_TwlwMC1hhdSzamwGWEBxuUkz1gH _TwlwMC1hhdSzamwGWEBxuUkz1gH_0)
	{
		return _TwlwMC1hhdSzamwGWEBxuUkz1gH_0._jztzokSobPJKyleCHypP9HS4OhbA;
	}

	static void smethod_22(_TwlwMC1hhdSzamwGWEBxuUkz1gH _TwlwMC1hhdSzamwGWEBxuUkz1gH_0, string string_0)
	{
		_TwlwMC1hhdSzamwGWEBxuUkz1gH_0._GGyEXu1JJKcG2X3txvtCwyZAylK(string_0);
	}

	static bool smethod_23()
	{
		return _iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF;
	}

	static void smethod_24(_TwlwMC1hhdSzamwGWEBxuUkz1gH _TwlwMC1hhdSzamwGWEBxuUkz1gH_0, int int_0, bool bool_0)
	{
		_TwlwMC1hhdSzamwGWEBxuUkz1gH_0._4XV5xPzQUH5ABIwpxH3yf5EIAyL(int_0, bool_0);
	}

	static bool smethod_25(_TwlwMC1hhdSzamwGWEBxuUkz1gH _TwlwMC1hhdSzamwGWEBxuUkz1gH_0)
	{
		return _TwlwMC1hhdSzamwGWEBxuUkz1gH_0._p3lU5oxIaFTVHUNFxJRnaHkXdsA;
	}

	static void smethod_26(_TwlwMC1hhdSzamwGWEBxuUkz1gH _TwlwMC1hhdSzamwGWEBxuUkz1gH_0)
	{
		_TwlwMC1hhdSzamwGWEBxuUkz1gH_0._paoLItUYkFWaGSDnCAvBagJ1F5T();
	}

	static void smethod_27(_TwlwMC1hhdSzamwGWEBxuUkz1gH _TwlwMC1hhdSzamwGWEBxuUkz1gH_0)
	{
		_TwlwMC1hhdSzamwGWEBxuUkz1gH_0._JHfBnmyItvKJDQtdUPp2yLsm4yR();
	}

	static void smethod_28(_TwlwMC1hhdSzamwGWEBxuUkz1gH _TwlwMC1hhdSzamwGWEBxuUkz1gH_0)
	{
		_TwlwMC1hhdSzamwGWEBxuUkz1gH_0._oHE0dGUBNplXQia6K85vMaNc8jp();
	}

	void method_1(SpriteBatch spriteBatch_0)
	{
		base._Z70nK2EA1n5FNJxjWP0TzHQ0Lzb(spriteBatch_0);
	}

	static bool smethod_29(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._ezjxb7tsh6Db1xblB74OYX4vVK;
	}

	static void smethod_30(SpriteBatch spriteBatch_0)
	{
		spriteBatch_0.Begin();
	}
}
