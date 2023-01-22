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
		_cDOKpatcramNDb8aZK14Rc6Y91p = CinemaScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Cinema/Movie None", 0, 0);
		_28AfW2C2UvwyhrjsUQU4Sq4LV0c = CinemaScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Cinema/Movie Action-Western", 0, 0);
		_AaYP9AZ7ZvHeMGXs5FNl1sIar5E = CinemaScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Cinema/Movie Comedy-Romantic", 0, 0);
		_g14D6v9FBXiZihegPw9BIGlBConA = CinemaScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Cinema/Movie Noire Gloomy", 0, 0);
		CinemaScene.smethod_15((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "None");
		CinemaScene.smethod_16("Assets/Music/DJ-ZEK - Simulate", 0.4f);
	}

	public override void _6hE3geqxrB1vCirtSWHxIJjlTQB(string string_0)
	{
		this.method_0(string_0);
		CinemaScene.smethod_17((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_28AfW2C2UvwyhrjsUQU4Sq4LV0c, bool_0: false);
		CinemaScene.smethod_17((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_AaYP9AZ7ZvHeMGXs5FNl1sIar5E, bool_0: false);
		CinemaScene.smethod_17((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_g14D6v9FBXiZihegPw9BIGlBConA, bool_0: false);
		CinemaScene.smethod_17((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_cDOKpatcramNDb8aZK14Rc6Y91p, bool_0: false);
		if (!CinemaScene.smethod_18(string_0, "Western"))
		{
			if (CinemaScene.smethod_18(string_0, "Romantic"))
			{
				CinemaScene.smethod_17((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_AaYP9AZ7ZvHeMGXs5FNl1sIar5E, bool_0: true);
			}
			else if (!CinemaScene.smethod_18(string_0, "Horror"))
			{
				CinemaScene.smethod_17((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_cDOKpatcramNDb8aZK14Rc6Y91p, bool_0: true);
			}
			else
			{
				CinemaScene.smethod_17((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_g14D6v9FBXiZihegPw9BIGlBConA, bool_0: true);
			}
		}
		else
		{
			CinemaScene.smethod_17((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_28AfW2C2UvwyhrjsUQU4Sq4LV0c, bool_0: true);
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
