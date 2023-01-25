namespace Amorous.Game.Scenes;

public class CoffeeShopScene : AbstractScene
{
	public const string _vLvbLLrZzgMrRgmxcYHzDgEDnpt = "Jax";

	public const string _sE7NN5MXeclpNhlb9x1hC61G2sQ = "Seth";

	public const string _x8Ym16HTsmyDDdsJK37LoYtDAli = "Default";

	private readonly _uqydQVaCmCvK7zzWs5W4gZFpKBu _f2oPpgipLb2rTkpm5SVN7YrkJvd;

	private readonly _uqydQVaCmCvK7zzWs5W4gZFpKBu _pewCVYjuuHIu8ihhqBs4FHREuPB;

	private readonly _uqydQVaCmCvK7zzWs5W4gZFpKBu _Fcr13ys9cm66KFhUCRnmKKCOHQA;

	public CoffeeShopScene(IAmorous game)
		: base(Game)
	{
		_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Background", "Assets/Scenes/CoffeeShop/Background", 0, 0);
		_f2oPpgipLb2rTkpm5SVN7YrkJvd = _NC5VT77x8y2iH2pW56TBN1eyomA("Background", "Assets/Scenes/CoffeeShop/Jax coffee", 0, 0);
		_pewCVYjuuHIu8ihhqBs4FHREuPB = _NC5VT77x8y2iH2pW56TBN1eyomA("Background", "Assets/Scenes/CoffeeShop/Seth coffee", 0, 0);
		_Fcr13ys9cm66KFhUCRnmKKCOHQA = _NC5VT77x8y2iH2pW56TBN1eyomA("Background", "Assets/Scenes/CoffeeShop/Remy coffee", 0, 0);
		_6hE3geqxrB1vCirtSWHxIJjlTQB("Default");
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/Steampianist - O Morro Nao Tem Vez", 0.4f);
	}

	public override void _6hE3geqxrB1vCirtSWHxIJjlTQB(string string_0)
	{
		base._6hE3geqxrB1vCirtSWHxIJjlTQB(string_0);
		_f2oPpgipLb2rTkpm5SVN7YrkJvd._Fxy2SlgceW90FloFw6a1AEJODYA = false;
		_pewCVYjuuHIu8ihhqBs4FHREuPB._Fxy2SlgceW90FloFw6a1AEJODYA = false;
		_Fcr13ys9cm66KFhUCRnmKKCOHQA._Fxy2SlgceW90FloFw6a1AEJODYA = false;
		if (!(string_0 == "Jax"))
		{
			if (!(string_0 == "Seth"))
			{
				_Fcr13ys9cm66KFhUCRnmKKCOHQA._Fxy2SlgceW90FloFw6a1AEJODYA = true;
			}
			else
			{
				_pewCVYjuuHIu8ihhqBs4FHREuPB._Fxy2SlgceW90FloFw6a1AEJODYA = true;
			}
		}
		else
		{
			_f2oPpgipLb2rTkpm5SVN7YrkJvd._Fxy2SlgceW90FloFw6a1AEJODYA = true;
		}
	}
}
