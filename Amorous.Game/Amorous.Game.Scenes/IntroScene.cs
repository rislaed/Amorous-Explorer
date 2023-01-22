using System;
using Amorous.Game.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.Scenes;

public class IntroScene : _7UlnfykmEmZDFt3BmCKZekI43Ih
{
	private int _Q7Kx7ErHf3u1QIUDKfFCKSXbznG;

	private readonly float _PbBEddQtI9iZg1ocIlBafUuVdrO;

	public _ujAkjlfN5TywwbLAUDzPvtab6uJ _h29gtnqEWLAa5qsliRXuXiPwY2o { get; private set; }

	public _ujAkjlfN5TywwbLAUDzPvtab6uJ _agB6DEyENfHFg1x2I4KsJqoQUpg { get; private set; }

	public CoupleANPC _4BkRUyoqu3iKk7SRvIVoP35EcKA { get; private set; }

	public CoupleBNPC _ZCUbMPsnW0SgjlADsYyZVasibXM { get; private set; }

	public IntroScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		while (true)
		{
			int num = 314675817;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5E51D434u) % 4u)
				{
				case 2u:
					_agB6DEyENfHFg1x2I4KsJqoQUpg = IntroScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, _003CModule_003E.smethod_25<string>(2902776559u), _003CModule_003E.smethod_27<string>(1850067112u), 0, 1250);
					IntroScene.smethod_15(_003CModule_003E.smethod_25<string>(1311283570u), 0.4f);
					num = ((int)num2 * -1066748878) ^ 0x3FE031B8;
					continue;
				case 1u:
					_h29gtnqEWLAa5qsliRXuXiPwY2o = IntroScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, _003CModule_003E.smethod_24<string>(1416131465u), _003CModule_003E.smethod_24<string>(1981564010u), 0, 0);
					num = ((int)num2 * -1501514041) ^ -2130596183;
					continue;
				case 3u:
					break;
				default:
					_PbBEddQtI9iZg1ocIlBafUuVdrO = 1f;
					return;
				}
				break;
			}
		}
	}

	public override void _4hlxzMzKSbVTbZUrEsP3dfw4x0h()
	{
		_ZCUbMPsnW0SgjlADsYyZVasibXM = IntroScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<CoupleBNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
		IntroScene.smethod_17((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_ZCUbMPsnW0SgjlADsYyZVasibXM, 1280f);
		IntroScene.smethod_18((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_ZCUbMPsnW0SgjlADsYyZVasibXM, 1090f);
		while (true)
		{
			int num = 502768949;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3913BD30u) % 5u)
				{
				case 3u:
					_ZCUbMPsnW0SgjlADsYyZVasibXM._tDFvus0ZCanjp81eOiDzoMXJiuf(CoupleBNPC.EPoses.Waving);
					_ZCUbMPsnW0SgjlADsYyZVasibXM._09vxUzgOn7J7DFZEwsTh7lgEIhB(CoupleBNPC.EClothes.Shirt, CoupleBNPC.EClothes.Pants);
					num = (int)(num2 * 218144739) ^ -1421023268;
					continue;
				case 1u:
					_4BkRUyoqu3iKk7SRvIVoP35EcKA._tDFvus0ZCanjp81eOiDzoMXJiuf(CoupleANPC.EPoses.Waving);
					num = (int)((num2 * 910955454) ^ 0x2385D91A);
					continue;
				case 0u:
					_4BkRUyoqu3iKk7SRvIVoP35EcKA = IntroScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<CoupleANPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
					IntroScene.smethod_17((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_4BkRUyoqu3iKk7SRvIVoP35EcKA, -800f);
					IntroScene.smethod_18((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_4BkRUyoqu3iKk7SRvIVoP35EcKA, 1090f);
					num = ((int)num2 * -27016754) ^ -1680089928;
					continue;
				case 4u:
					break;
				default:
					_4BkRUyoqu3iKk7SRvIVoP35EcKA._09vxUzgOn7J7DFZEwsTh7lgEIhB(CoupleANPC.EClothes.Shirt, CoupleANPC.EClothes.Pants);
					return;
				}
				break;
			}
		}
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		this.method_0(gameTime_0);
		_Q7Kx7ErHf3u1QIUDKfFCKSXbznG += IntroScene.smethod_19(gameTime_0).Milliseconds;
		_EZKvqbHbBzrIsmIefNbwSVvgrP5A(_h29gtnqEWLAa5qsliRXuXiPwY2o, 0f, 18000f * _PbBEddQtI9iZg1ocIlBafUuVdrO, 0, 0, 0, -540);
		_EZKvqbHbBzrIsmIefNbwSVvgrP5A(_agB6DEyENfHFg1x2I4KsJqoQUpg, 10000f * _PbBEddQtI9iZg1ocIlBafUuVdrO, 8000f * _PbBEddQtI9iZg1ocIlBafUuVdrO, 0, 1250, 0, -170);
		while (true)
		{
			int num = -1306974959;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE36ADFCBu) % 3u)
				{
				case 1u:
					goto IL_007c;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_007c:
				_nuSr558RHFkx9d2QBs2DeGUB1wX(_4BkRUyoqu3iKk7SRvIVoP35EcKA, 14000f * _PbBEddQtI9iZg1ocIlBafUuVdrO, 4000f * _PbBEddQtI9iZg1ocIlBafUuVdrO, -800, 1090, 600, 1090);
				_nuSr558RHFkx9d2QBs2DeGUB1wX(_ZCUbMPsnW0SgjlADsYyZVasibXM, 14000f * _PbBEddQtI9iZg1ocIlBafUuVdrO, 4000f * _PbBEddQtI9iZg1ocIlBafUuVdrO, 1280, 1090, 450, 1090);
				num = ((int)num2 * -514915332) ^ 0x4AF0306F;
			}
		}
	}

	private void _EZKvqbHbBzrIsmIefNbwSVvgrP5A(_ujAkjlfN5TywwbLAUDzPvtab6uJ _ujAkjlfN5TywwbLAUDzPvtab6uJ_0, float float_0, float float_1, int int_0, int int_1, int int_2, int int_3)
	{
		if ((float)_Q7Kx7ErHf3u1QIUDKfFCKSXbznG < float_0)
		{
			return;
		}
		float float_2 = default(float);
		while (true)
		{
			int num = 1489835815;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x312EDF3Cu) % 6u)
				{
				case 4u:
					float_2 = ((float)_Q7Kx7ErHf3u1QIUDKfFCKSXbznG - float_0) / float_1;
					IntroScene.smethod_21(_ujAkjlfN5TywwbLAUDzPvtab6uJ_0, IntroScene.smethod_20((float)int_0, (float)int_2, float_2));
					num = 629106768;
					continue;
				case 2u:
					IntroScene.smethod_22(_ujAkjlfN5TywwbLAUDzPvtab6uJ_0, IntroScene.smethod_20((float)int_1, (float)int_3, float_2));
					num = (int)((num2 * 1988585606) ^ 0x38BFDBE7);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if ((float)_Q7Kx7ErHf3u1QIUDKfFCKSXbznG >= float_0 + float_1)
					{
						num3 = 3050193;
						num4 = 3050193;
					}
					else
					{
						num3 = 1658357404;
						num4 = 1658357404;
					}
					num = num3 ^ (int)(num2 * 1390520284);
					continue;
				}
				default:
					return;
				case 0u:
					break;
				case 3u:
					return;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	private void _nuSr558RHFkx9d2QBs2DeGUB1wX(_tfDAeR6npiqJMLRSXPO1DxGA0TgA _tfDAeR6npiqJMLRSXPO1DxGA0TgA_0, float float_0, float float_1, int int_0, int int_1, int int_2, int int_3)
	{
		if ((float)_Q7Kx7ErHf3u1QIUDKfFCKSXbznG < float_0)
		{
			return;
		}
		while (true)
		{
			int num = -1132909993;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD38399DCu) % 5u)
				{
				case 4u:
				{
					int num3;
					int num4;
					if ((float)_Q7Kx7ErHf3u1QIUDKfFCKSXbznG >= float_0 + float_1)
					{
						num3 = 2104894221;
						num4 = 2104894221;
					}
					else
					{
						num3 = 2010803683;
						num4 = 2010803683;
					}
					num = num3 ^ (int)(num2 * 1217427273);
					continue;
				}
				case 0u:
				{
					float float_2 = ((float)_Q7Kx7ErHf3u1QIUDKfFCKSXbznG - float_0) / float_1;
					IntroScene.smethod_17((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_tfDAeR6npiqJMLRSXPO1DxGA0TgA_0, IntroScene.smethod_20((float)int_0, (float)int_2, float_2));
					IntroScene.smethod_18((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_tfDAeR6npiqJMLRSXPO1DxGA0TgA_0, IntroScene.smethod_20((float)int_1, (float)int_3, float_2));
					num = -1412991775;
					continue;
				}
				default:
					return;
				case 2u:
					break;
				case 1u:
					return;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	static _uqydQVaCmCvK7zzWs5W4gZFpKBu smethod_14(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._0O8D0mBgmrh0sLOGcLVvGNOHKLCA(string_0, string_1, int_0, int_1);
	}

	static void smethod_15(string string_0, float float_0)
	{
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc(string_0, float_0);
	}

	static _JbeCmOie0phb2cbgG6DdGZrbs3pB smethod_16(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._ZzBuoSDMWwerejOO9Goyv2OCKgE;
	}

	static void smethod_17(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_18(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}

	void method_0(GameTime gameTime_0)
	{
		base._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
	}

	static TimeSpan smethod_19(GameTime gameTime_0)
	{
		return gameTime_0.get_ElapsedGameTime();
	}

	static float smethod_20(float float_0, float float_1, float float_2)
	{
		return MathHelper.Lerp(float_0, float_1, float_2);
	}

	static void smethod_21(_ujAkjlfN5TywwbLAUDzPvtab6uJ _ujAkjlfN5TywwbLAUDzPvtab6uJ_0, float float_0)
	{
		_ujAkjlfN5TywwbLAUDzPvtab6uJ_0._7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_22(_ujAkjlfN5TywwbLAUDzPvtab6uJ _ujAkjlfN5TywwbLAUDzPvtab6uJ_0, float float_0)
	{
		_ujAkjlfN5TywwbLAUDzPvtab6uJ_0._bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}
}
