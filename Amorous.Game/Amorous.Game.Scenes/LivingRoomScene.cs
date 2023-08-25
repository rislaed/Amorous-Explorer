using Microsoft.Xna.Framework;

namespace Amorous.Game.Scenes;

public class LivingRoomScene : TimeOfDayScene
{
	private readonly PhoneUrgentlyRinging phoneRinging;

	public LivingRoomScene(IAmorous game) : base(game)
	{
		AddSpriteLayer("Background", "Assets/Scenes/LivingRoom/Foyer", 0, 0);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.SunFunkTrack, 0.4f);
		phoneRinging = new PhoneUrgentlyRinging(Game);
	}

	public override void Update(GameTime gameTime)
	{
		base.Update(gameTime);
		phoneRinging.Update(gameTime);
	}

	public override void End()
	{
		base.End();
		phoneRinging.End();
	}
}
