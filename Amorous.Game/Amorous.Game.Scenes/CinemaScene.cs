namespace Amorous.Game.Scenes;

public class CinemaScene : _7UlnfykmEmZDFt3BmCKZekI43Ih
{
	public const string _x8Ym16HTsmyDDdsJK37LoYtDAli = "None";

	public const string _2RxpujJnprLRk5VJUJEweM6P5Pi = "Western";

	public const string _lBew7wP0gzyjzQM1BVL3qbqmK4e = "Romantic";

	public const string _yLedXS7yinSiQlB3WvEFxqVTXCS = "Horror";

	private _uqydQVaCmCvK7zzWs5W4gZFpKBu _cDOKpatcramNDb8aZK14Rc6Y91p;

	private _uqydQVaCmCvK7zzWs5W4gZFpKBu _28AfW2C2UvwyhrjsUQU4Sq4LV0c;

	private _uqydQVaCmCvK7zzWs5W4gZFpKBu _AaYP9AZ7ZvHeMGXs5FNl1sIar5E;

	private _uqydQVaCmCvK7zzWs5W4gZFpKBu _g14D6v9FBXiZihegPw9BIGlBConA;

	public CinemaScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		while (true)
		{
			int num = 17208425;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4D35E695u) % 6u)
				{
				case 4u:
					_cDOKpatcramNDb8aZK14Rc6Y91p = CinemaScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Cinema/Movie None", 0, 0);
					num = ((int)num2 * -1208130352) ^ -527628063;
					continue;
				case 3u:
					_AaYP9AZ7ZvHeMGXs5FNl1sIar5E = CinemaScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Cinema/Movie Comedy-Romantic", 0, 0);
					num = (int)(num2 * 67494193) ^ -1778372855;
					continue;
				case 1u:
					_g14D6v9FBXiZihegPw9BIGlBConA = CinemaScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Cinema/Movie Noire Gloomy", 0, 0);
					num = (int)((num2 * 1325299162) ^ 0x38ECF6B7);
					continue;
				case 0u:
					_28AfW2C2UvwyhrjsUQU4Sq4LV0c = CinemaScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Cinema/Movie Action-Western", 0, 0);
					num = ((int)num2 * -475379084) ^ 0x193DE9CA;
					continue;
				case 5u:
					break;
				default:
					CinemaScene.smethod_15((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "None");
					CinemaScene.smethod_16("Assets/Music/DJ-ZEK - Simulate", 0.4f);
					return;
				}
				break;
			}
		}
	}

	public override void _6hE3geqxrB1vCirtSWHxIJjlTQB(string string_0)
	{
		this.method_0(string_0);
		CinemaScene.smethod_17((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_28AfW2C2UvwyhrjsUQU4Sq4LV0c, bool_0: false);
		while (true)
		{
			int num = -1208970887;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFE8449D4u) % 12u)
				{
				case 9u:
					num = (int)((num2 * 1643289745) ^ 0x69ADD039);
					continue;
				case 8u:
					CinemaScene.smethod_17((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_cDOKpatcramNDb8aZK14Rc6Y91p, bool_0: true);
					num = -1513446906;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (CinemaScene.smethod_18(string_0, "Romantic"))
					{
						num5 = 2026769026;
						num6 = 2026769026;
					}
					else
					{
						num5 = 857596279;
						num6 = 857596279;
					}
					num = num5 ^ ((int)num2 * -1491938694);
					continue;
				}
				case 5u:
					CinemaScene.smethod_17((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_AaYP9AZ7ZvHeMGXs5FNl1sIar5E, bool_0: false);
					CinemaScene.smethod_17((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_g14D6v9FBXiZihegPw9BIGlBConA, bool_0: false);
					num = (int)(num2 * 23157191) ^ -1664029608;
					continue;
				case 3u:
				{
					CinemaScene.smethod_17((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_cDOKpatcramNDb8aZK14Rc6Y91p, bool_0: false);
					int num7;
					int num8;
					if (!CinemaScene.smethod_18(string_0, "Western"))
					{
						num7 = -576399066;
						num8 = -576399066;
					}
					else
					{
						num7 = -1528428543;
						num8 = -1528428543;
					}
					num = num7 ^ ((int)num2 * -77627913);
					continue;
				}
				case 1u:
				{
					int num3;
					int num4;
					if (!CinemaScene.smethod_18(string_0, "Horror"))
					{
						num3 = -734977066;
						num4 = -734977066;
					}
					else
					{
						num3 = -1856251211;
						num4 = -1856251211;
					}
					num = num3 ^ (int)(num2 * 1829972203);
					continue;
				}
				case 0u:
					CinemaScene.smethod_17((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_28AfW2C2UvwyhrjsUQU4Sq4LV0c, bool_0: true);
					num = -1728263445;
					continue;
				default:
					return;
				case 6u:
					break;
				case 2u:
					return;
				case 4u:
					CinemaScene.smethod_17((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_AaYP9AZ7ZvHeMGXs5FNl1sIar5E, bool_0: true);
					return;
				case 10u:
					CinemaScene.smethod_17((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_g14D6v9FBXiZihegPw9BIGlBConA, bool_0: true);
					return;
				case 11u:
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

	static void smethod_15(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0)
	{
		_7UlnfykmEmZDFt3BmCKZekI43Ih_0._6hE3geqxrB1vCirtSWHxIJjlTQB(string_0);
	}

	static void smethod_16(string string_0, float float_0)
	{
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc(string_0, float_0);
	}

	void method_0(string string_0)
	{
		base._6hE3geqxrB1vCirtSWHxIJjlTQB(string_0);
	}

	static void smethod_17(_ujAkjlfN5TywwbLAUDzPvtab6uJ _ujAkjlfN5TywwbLAUDzPvtab6uJ_0, bool bool_0)
	{
		_ujAkjlfN5TywwbLAUDzPvtab6uJ_0._Fxy2SlgceW90FloFw6a1AEJODYA = bool_0;
	}

	static bool smethod_18(string string_0, string string_1)
	{
		return string_0 == string_1;
	}
}
