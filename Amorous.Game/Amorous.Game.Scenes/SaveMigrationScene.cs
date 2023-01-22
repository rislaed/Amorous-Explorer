using Amorous.Game.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.Scenes;

public class SaveMigrationScene : _7UlnfykmEmZDFt3BmCKZekI43Ih
{
	private readonly string _BMUFdD4GwdBkg2lksa43USTpcIz;

	private readonly string _Z8BClcChRJrlB6tR1VPJcycVpHN;

	private bool _OvbescGEY3Lfk7RmD2smIoB5Es2A;

	public SaveMigrationScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, string string_0, string string_1)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		while (true)
		{
			int num = -389794903;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFABA92FEu) % 6u)
				{
				case 5u:
					_BMUFdD4GwdBkg2lksa43USTpcIz = string_0;
					num = (int)((num2 * 1977004589) ^ 0x3CF82504);
					continue;
				case 4u:
					SaveMigrationScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Intro/Background", 0, -540);
					num = (int)((num2 * 1221340939) ^ 0x149C9F38);
					continue;
				case 2u:
					SaveMigrationScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Intro/Scenery", 0, -170);
					SaveMigrationScene.smethod_15((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Title", "Assets/Scenes/MainMenu/Logo", 616, 50);
					SaveMigrationScene.smethod_16("Assets/Music/Biggyzoom - The Night Sky", 0.4f);
					num = ((int)num2 * -1628247473) ^ -1587653125;
					continue;
				case 1u:
					_Z8BClcChRJrlB6tR1VPJcycVpHN = string_1;
					num = ((int)num2 * -870846477) ^ 0x75FD8685;
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public override void _4hlxzMzKSbVTbZUrEsP3dfw4x0h()
	{
		CoupleANPC coupleANPC = SaveMigrationScene.smethod_17((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<CoupleANPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
		SaveMigrationScene.smethod_18((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)coupleANPC, 350f);
		CoupleBNPC coupleBNPC = default(CoupleBNPC);
		while (true)
		{
			int num = -1340250929;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDCFAD04Bu) % 9u)
				{
				case 6u:
					coupleBNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(CoupleBNPC.EPoses.Waving);
					num = (int)((num2 * 225492522) ^ 0x110383F5);
					continue;
				case 5u:
					SaveMigrationScene.smethod_19((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)coupleBNPC, 1090f);
					num = ((int)num2 * -874534318) ^ 0x177F1A2C;
					continue;
				case 4u:
					SaveMigrationScene.smethod_18((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)coupleBNPC, 550f);
					num = ((int)num2 * -951974968) ^ -1266915846;
					continue;
				case 3u:
					SaveMigrationScene.smethod_19((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)coupleANPC, 1090f);
					coupleANPC._tDFvus0ZCanjp81eOiDzoMXJiuf(CoupleANPC.EPoses.Waving);
					coupleANPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(CoupleANPC.EClothes.Shirt, CoupleANPC.EClothes.Pants);
					num = (int)(num2 * 300829435) ^ -483583974;
					continue;
				case 2u:
					coupleBNPC = SaveMigrationScene.smethod_17((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<CoupleBNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
					num = (int)(num2 * 1387011910) ^ -624824842;
					continue;
				case 1u:
				{
					coupleBNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(CoupleBNPC.EClothes.Shirt, CoupleBNPC.EClothes.Pants);
					int num3;
					int num4;
					if (_BMUFdD4GwdBkg2lksa43USTpcIz != null)
					{
						num3 = -1434186091;
						num4 = -1434186091;
					}
					else
					{
						num3 = -1259144459;
						num4 = -1259144459;
					}
					num = num3 ^ (int)(num2 * 761344900);
					continue;
				}
				case 0u:
					SaveMigrationScene.smethod_20(SaveMigrationScene.smethod_17((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), _BMUFdD4GwdBkg2lksa43USTpcIz);
					num = ((int)num2 * -1824134681) ^ -1418579705;
					continue;
				default:
					return;
				case 8u:
					break;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		this.method_0(gameTime_0);
		if (_OvbescGEY3Lfk7RmD2smIoB5Es2A)
		{
			return;
		}
		while (true)
		{
			int num = 1152829309;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x68C3BAB2u) % 6u)
				{
				case 5u:
					_OvbescGEY3Lfk7RmD2smIoB5Es2A = true;
					num = ((int)num2 * -49827792) ^ 0x2EB3A292;
					continue;
				case 4u:
					SaveMigrationScene.smethod_23(SaveMigrationScene.smethod_17((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), _Z8BClcChRJrlB6tR1VPJcycVpHN);
					num = (int)(num2 * 1060025584) ^ -1837449675;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (SaveMigrationScene.smethod_22(SaveMigrationScene.smethod_17((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)) == null)
					{
						num5 = 699727307;
						num6 = 699727307;
					}
					else
					{
						num5 = 1409836697;
						num6 = 1409836697;
					}
					num = num5 ^ ((int)num2 * -948141199);
					continue;
				}
				case 1u:
				{
					int num3;
					int num4;
					if (SaveMigrationScene.smethod_21(SaveMigrationScene.smethod_17((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)))
					{
						num3 = -54358416;
						num4 = -54358416;
					}
					else
					{
						num3 = -743489125;
						num4 = -743489125;
					}
					num = num3 ^ ((int)num2 * -589248853);
					continue;
				}
				default:
					return;
				case 0u:
					break;
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

	static _uqydQVaCmCvK7zzWs5W4gZFpKBu smethod_15(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._NC5VT77x8y2iH2pW56TBN1eyomA(string_0, string_1, int_0, int_1);
	}

	static void smethod_16(string string_0, float float_0)
	{
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc(string_0, float_0);
	}

	static _JbeCmOie0phb2cbgG6DdGZrbs3pB smethod_17(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._ZzBuoSDMWwerejOO9Goyv2OCKgE;
	}

	static void smethod_18(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_19(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}

	static void smethod_20(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, string string_0)
	{
		_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._xyl3Tv5KdR5eezDgagxbBcS3cwt(string_0);
	}

	void method_0(GameTime gameTime_0)
	{
		base._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
	}

	static bool smethod_21(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._NdzU0m9x8QDKpVv3DrQmzY5KduB;
	}

	static _nR8eroJOHehP0ZGyyTveo6aMTHg smethod_22(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._5zNdOw7qHmuCAPJFMr3SsZdBlCr;
	}

	static void smethod_23(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, string string_0)
	{
		_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._k9wUPeU1Ga7cygiuGP8TT6aPLWF(string_0);
	}
}
