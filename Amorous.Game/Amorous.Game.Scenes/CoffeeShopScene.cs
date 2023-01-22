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
		CoffeeShopScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/CoffeeShop/Background", 0, 0);
		_f2oPpgipLb2rTkpm5SVN7YrkJvd = CoffeeShopScene.smethod_15((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/CoffeeShop/Jax coffee", 0, 0);
		_pewCVYjuuHIu8ihhqBs4FHREuPB = CoffeeShopScene.smethod_15((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/CoffeeShop/Seth coffee", 0, 0);
		_Fcr13ys9cm66KFhUCRnmKKCOHQA = CoffeeShopScene.smethod_15((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/CoffeeShop/Remy coffee", 0, 0);
		CoffeeShopScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Default");
		CoffeeShopScene.smethod_17("Assets/Music/Steampianist - O Morro Nao Tem Vez", 0.4f);
	}

	public override void _6hE3geqxrB1vCirtSWHxIJjlTQB(string string_0)
	{
		this.method_0(string_0);
		CoffeeShopScene.smethod_18((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_f2oPpgipLb2rTkpm5SVN7YrkJvd, bool_0: false);
		CoffeeShopScene.smethod_18((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_pewCVYjuuHIu8ihhqBs4FHREuPB, bool_0: false);
		CoffeeShopScene.smethod_18((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_Fcr13ys9cm66KFhUCRnmKKCOHQA, bool_0: false);
		if (!CoffeeShopScene.smethod_19(string_0, "Jax"))
		{
			if (!CoffeeShopScene.smethod_19(string_0, "Seth"))
			{
				CoffeeShopScene.smethod_18((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_Fcr13ys9cm66KFhUCRnmKKCOHQA, bool_0: true);
			}
			else
			{
				CoffeeShopScene.smethod_18((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_pewCVYjuuHIu8ihhqBs4FHREuPB, bool_0: true);
			}
		}
		else
		{
			CoffeeShopScene.smethod_18((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_f2oPpgipLb2rTkpm5SVN7YrkJvd, bool_0: true);
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
