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
		FadingMediaPlayer._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/Biggyzoom - The Night Sky", 0.4f);
	}

	public override void Begin()
	{
		CoupleANPC coupleANPC = base.Game.GetNPCLayerAt<CoupleANPC>(LayerOrder.Background);
		coupleANPC.X = 350f;
		coupleANPC.Y = 1090f;
		coupleANPC.SetPose(CoupleANPC.EPoses.Waving);
		coupleANPC.SetClothes(CoupleANPC.EClothes.Shirt, CoupleANPC.EClothes.Pants);
		CoupleBNPC coupleBNPC = base.Game.GetNPCLayerAt<CoupleBNPC>(LayerOrder.Background);
		coupleBNPC.X = 550f;
		coupleBNPC.Y = 1090f;
		coupleBNPC.SetPose(CoupleBNPC.EPoses.Waving);
		coupleBNPC.SetClothes(CoupleBNPC.EClothes.Shirt, CoupleBNPC.EClothes.Pants);
		if (_BMUFdD4GwdBkg2lksa43USTpcIz != null)
		{
			base.Game.StartCutscene(_BMUFdD4GwdBkg2lksa43USTpcIz);
		}
	}

	public override void Update(GameTime gameTime)
	{
		base.Update(gameTime);
		if (!_OvbescGEY3Lfk7RmD2smIoB5Es2A && !base.Game.InScenePending && base.Game.Cutscene == null)
		{
			_OvbescGEY3Lfk7RmD2smIoB5Es2A = true;
			base.Game.StartScene(_Z8BClcChRJrlB6tR1VPJcycVpHN);
		}
	}
}
