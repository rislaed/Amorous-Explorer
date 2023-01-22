namespace Amorous.Game.Scenes;

public class CoffeeShopScene : _7UlnfykmEmZDFt3BmCKZekI43Ih
{
	public const string _vLvbLLrZzgMrRgmxcYHzDgEDnpt = "Jax";

	public const string _sE7NN5MXeclpNhlb9x1hC61G2sQ = "Seth";

	public const string _x8Ym16HTsmyDDdsJK37LoYtDAli = "Default";

	private readonly _uqydQVaCmCvK7zzWs5W4gZFpKBu _f2oPpgipLb2rTkpm5SVN7YrkJvd;

	private readonly _uqydQVaCmCvK7zzWs5W4gZFpKBu _pewCVYjuuHIu8ihhqBs4FHREuPB;

	private readonly _uqydQVaCmCvK7zzWs5W4gZFpKBu _Fcr13ys9cm66KFhUCRnmKKCOHQA;

	public CoffeeShopScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		while (true)
		{
			int num = -1728049967;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB194F58Bu) % 6u)
				{
				case 5u:
					_f2oPpgipLb2rTkpm5SVN7YrkJvd = CoffeeShopScene.smethod_15((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/CoffeeShop/Jax coffee", 0, 0);
					_pewCVYjuuHIu8ihhqBs4FHREuPB = CoffeeShopScene.smethod_15((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/CoffeeShop/Seth coffee", 0, 0);
					num = ((int)num2 * -799159557) ^ 0x3EED23D0;
					continue;
				case 4u:
					CoffeeShopScene.smethod_17("Assets/Music/Steampianist - O Morro Nao Tem Vez", 0.4f);
					num = (int)(num2 * 1245822215) ^ -905307378;
					continue;
				case 2u:
					CoffeeShopScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/CoffeeShop/Background", 0, 0);
					num = (int)(num2 * 1217756209) ^ -1118219824;
					continue;
				case 0u:
					_Fcr13ys9cm66KFhUCRnmKKCOHQA = CoffeeShopScene.smethod_15((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/CoffeeShop/Remy coffee", 0, 0);
					CoffeeShopScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Default");
					num = (int)((num2 * 198831689) ^ 0x6821D417);
					continue;
				default:
					return;
				case 3u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public override void _6hE3geqxrB1vCirtSWHxIJjlTQB(string string_0)
	{
		this.method_0(string_0);
		while (true)
		{
			int num = -1333266998;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE25F008Bu) % 11u)
				{
				case 9u:
				{
					int num5;
					int num6;
					if (!CoffeeShopScene.smethod_19(string_0, "Seth"))
					{
						num5 = -834512956;
						num6 = -834512956;
					}
					else
					{
						num5 = -690775130;
						num6 = -690775130;
					}
					num = num5 ^ (int)(num2 * 767955579);
					continue;
				}
				case 8u:
					CoffeeShopScene.smethod_18((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_f2oPpgipLb2rTkpm5SVN7YrkJvd, bool_0: false);
					num = ((int)num2 * -655404493) ^ 0x672A4E29;
					continue;
				case 7u:
					CoffeeShopScene.smethod_18((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_f2oPpgipLb2rTkpm5SVN7YrkJvd, bool_0: true);
					num = -169631616;
					continue;
				case 4u:
					CoffeeShopScene.smethod_18((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_pewCVYjuuHIu8ihhqBs4FHREuPB, bool_0: false);
					num = ((int)num2 * -1400335911) ^ -1981186896;
					continue;
				case 3u:
				{
					CoffeeShopScene.smethod_18((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_Fcr13ys9cm66KFhUCRnmKKCOHQA, bool_0: false);
					int num3;
					int num4;
					if (!CoffeeShopScene.smethod_19(string_0, "Jax"))
					{
						num3 = 582861834;
						num4 = 582861834;
					}
					else
					{
						num3 = 685019116;
						num4 = 685019116;
					}
					num = num3 ^ (int)(num2 * 1409558287);
					continue;
				}
				case 2u:
					num = ((int)num2 * -1769622047) ^ -736972467;
					continue;
				case 1u:
					CoffeeShopScene.smethod_18((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_pewCVYjuuHIu8ihhqBs4FHREuPB, bool_0: true);
					num = -495270636;
					continue;
				case 0u:
					break;
				case 5u:
					return;
				default:
					CoffeeShopScene.smethod_18((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_Fcr13ys9cm66KFhUCRnmKKCOHQA, bool_0: true);
					return;
				case 10u:
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

	static void smethod_16(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0)
	{
		_7UlnfykmEmZDFt3BmCKZekI43Ih_0._6hE3geqxrB1vCirtSWHxIJjlTQB(string_0);
	}

	static void smethod_17(string string_0, float float_0)
	{
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc(string_0, float_0);
	}

	void method_0(string string_0)
	{
		base._6hE3geqxrB1vCirtSWHxIJjlTQB(string_0);
	}

	static void smethod_18(_ujAkjlfN5TywwbLAUDzPvtab6uJ _ujAkjlfN5TywwbLAUDzPvtab6uJ_0, bool bool_0)
	{
		_ujAkjlfN5TywwbLAUDzPvtab6uJ_0._Fxy2SlgceW90FloFw6a1AEJODYA = bool_0;
	}

	static bool smethod_19(string string_0, string string_1)
	{
		return string_0 == string_1;
	}
}
