using Microsoft.Xna.Framework;

namespace Amorous.Game.Scenes;

public class LivingRoomScene : TimeOfDayScene
{
	private readonly PhoneUrgentlyRinging _phoneNag;

	public LivingRoomScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/LivingRoom/Foyer", 0, 0);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.SunFunkTrack, 0.4f);
		_phoneNag = new PhoneUrgentlyRinging(Game);
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
