using Amorous.Game.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.Scenes;

public class SaveMigrationScene : AbstractScene
{
	private readonly string _BMUFdD4GwdBkg2lksa43USTpcIz;

	private readonly string _Z8BClcChRJrlB6tR1VPJcycVpHN;

	private bool _OvbescGEY3Lfk7RmD2smIoB5Es2A;

	public SaveMigrationScene(IAmorous game, string string_0, string string_1)
		: base(game)
	{
		_BMUFdD4GwdBkg2lksa43USTpcIz = string_0;
		_Z8BClcChRJrlB6tR1VPJcycVpHN = string_1;
		_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Background", "Assets/Scenes/Intro/Background", 0, -540);
		_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Background", "Assets/Scenes/Intro/Scenery", 0, -170);
		_NC5VT77x8y2iH2pW56TBN1eyomA("Title", "Assets/Scenes/MainMenu/Logo", 616, 50);
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/Biggyzoom - The Night Sky", 0.4f);
	}

	public override void _4hlxzMzKSbVTbZUrEsP3dfw4x0h()
	{
		CoupleANPC coupleANPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<CoupleANPC>(LayerOrder.Background);
		coupleANPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 350f;
		coupleANPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 1090f;
		coupleANPC._tDFvus0ZCanjp81eOiDzoMXJiuf(CoupleANPC.EPoses.Waving);
		coupleANPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(CoupleANPC.EClothes.Shirt, CoupleANPC.EClothes.Pants);
		CoupleBNPC coupleBNPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<CoupleBNPC>(LayerOrder.Background);
		coupleBNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 550f;
		coupleBNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 1090f;
		coupleBNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(CoupleBNPC.EPoses.Waving);
		coupleBNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(CoupleBNPC.EClothes.Shirt, CoupleBNPC.EClothes.Pants);
		if (_BMUFdD4GwdBkg2lksa43USTpcIz != null)
		{
			base.Game.RequestScene(_BMUFdD4GwdBkg2lksa43USTpcIz);
		}
	}

	public override void Update(GameTime gameTime_0)
	{
		base.Update(gameTime_0);
		if (!_OvbescGEY3Lfk7RmD2smIoB5Es2A && !base.Game._NdzU0m9x8QDKpVv3DrQmzY5KduB && base.Game._5zNdOw7qHmuCAPJFMr3SsZdBlCr == null)
		{
			_OvbescGEY3Lfk7RmD2smIoB5Es2A = true;
			base.Game.StartScene(_Z8BClcChRJrlB6tR1VPJcycVpHN);
		}
	}
}
