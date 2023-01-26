namespace Amorous.Game.Scenes;

public class BeachScene : AbstractScene
{
	public BeachScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/Beach/Beach Background", 0, 0);
		if (base.Game._5zNdOw7qHmuCAPJFMr3SsZdBlCr != null && base.Game._5zNdOw7qHmuCAPJFMr3SsZdBlCr.Data.Name == "DustinDate" && base.Game._5zNdOw7qHmuCAPJFMr3SsZdBlCr._VQZivNSvg2tVi52cTTAQKYhamQK.Data.Stage == 60)
		{
			_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/Hopeku - In A Finger Blink", 0.4f);
		}
		else
		{
			_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/Warhector - Free Floating", 0.4f);
		}
	}
}
