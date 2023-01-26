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
		AddTexturedLayer("Background", "Assets/Scenes/Intro/Background", 0, -540);
		AddTexturedLayer("Background", "Assets/Scenes/Intro/Scenery", 0, -170);
		AddForegroundTexturedLayer("Title", "Assets/Scenes/MainMenu/Logo", 616, 50);
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/Biggyzoom - The Night Sky", 0.4f);
	}

	public override void ResetVariation()
	{
		CoupleANPC coupleANPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<CoupleANPC>(LayerOrder.Background);
		coupleANPC.X = 350f;
		coupleANPC.Y = 1090f;
		coupleANPC.SetPose(CoupleANPC.EPoses.Waving);
		coupleANPC.SetClothes(CoupleANPC.EClothes.Shirt, CoupleANPC.EClothes.Pants);
		CoupleBNPC coupleBNPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<CoupleBNPC>(LayerOrder.Background);
		coupleBNPC.X = 550f;
		coupleBNPC.Y = 1090f;
		coupleBNPC.SetPose(CoupleBNPC.EPoses.Waving);
		coupleBNPC.SetClothes(CoupleBNPC.EClothes.Shirt, CoupleBNPC.EClothes.Pants);
		if (_BMUFdD4GwdBkg2lksa43USTpcIz != null)
		{
			base.Game.RequestScene(_BMUFdD4GwdBkg2lksa43USTpcIz);
		}
	}

	public override void Update(GameTime gameTime)
	{
		base.Update(gameTime);
		if (!_OvbescGEY3Lfk7RmD2smIoB5Es2A && !base.Game._NdzU0m9x8QDKpVv3DrQmzY5KduB && base.Game._5zNdOw7qHmuCAPJFMr3SsZdBlCr == null)
		{
			_OvbescGEY3Lfk7RmD2smIoB5Es2A = true;
			base.Game.StartScene(_Z8BClcChRJrlB6tR1VPJcycVpHN);
		}
	}
}
