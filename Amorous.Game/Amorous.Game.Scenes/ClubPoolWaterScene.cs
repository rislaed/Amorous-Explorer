using Microsoft.Xna.Framework;

namespace Amorous.Game.Scenes;

public class ClubPoolWaterScene : AbstractScene
{
	public ClubPoolWaterScene(IAmorous game)
		: base(Game)
	{
		_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Background", "Assets/Scenes/ClubPoolWater/Background", 0, 0);
		_jOXcj4HBkU5j6LOJprpiXLCcLR0 gparam_ = new _jOXcj4HBkU5j6LOJprpiXLCcLR0(this, 700f, new Rectangle(0, -190, 1920, 1080), bool_0: true)
		{
			_WBXNT6eIVGk6ZKExRBJ6JxXE6zb_002E_GDeKFFD8Rxnpsjzy36lUBxAEopc = 600f,
			_WBXNT6eIVGk6ZKExRBJ6JxXE6zb_002E_JpSvHH1W0gFCpaNEH5zB1qsDJXY = 750f,
			_fO7gSlrDDNMoHR4FO5QXAq8fUyA = 2f
		};
		_jOXcj4HBkU5j6LOJprpiXLCcLR0 gparam_2 = new _jOXcj4HBkU5j6LOJprpiXLCcLR0(this, 700f, new Rectangle(0, 0, 1920, 1080), bool_0: true)
		{
			_WBXNT6eIVGk6ZKExRBJ6JxXE6zb_002E_GDeKFFD8Rxnpsjzy36lUBxAEopc = 1200f,
			_WBXNT6eIVGk6ZKExRBJ6JxXE6zb_002E_JpSvHH1W0gFCpaNEH5zB1qsDJXY = 750f,
			_fO7gSlrDDNMoHR4FO5QXAq8fUyA = 2f
		};
		_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(gparam_, 0);
		_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(gparam_2, 2);
		_UmxbIbk7pgaod0bD7pS309P3Lns._QrgbXEg7MMeD9Ybz12fFVsbmAd9(_KZ7hNP1K5E99Xfup1lTZ9UDrxPE._oCy13KHJxLHriH7TwMiQ1qKJ8Uc, 0.4f, bool_0: true, bool_1: true);
	}
}
