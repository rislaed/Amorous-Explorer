using Microsoft.Xna.Framework;

namespace Amorous.Game.Scenes;

public class LivingRoomScene : TimeOfDayScene
{
	private readonly _dvyBDFOZwoBLf9qqHSfHYLLXVwP _phoneNag;

	public LivingRoomScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/LivingRoom/Foyer", 0, 0);
		FadingMediaPlayer._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/DanMasterFlash - Sun Funk", 0.4f);
		_phoneNag = new _dvyBDFOZwoBLf9qqHSfHYLLXVwP(Game);
	}

	public override void Update(GameTime gameTime)
	{
		Update(gameTime);
		_phoneNag.Update(gameTime);
	}

	public override void End()
	{
		base.End();
		_phoneNag.End();
	}
}
