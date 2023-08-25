namespace Amorous.Game.Scenes;

public class DateCreditsMenuScene : CreditsMenuScene
{
	public DateCreditsMenuScene(IAmorous game) : base(game)
	{
		base.PendingScene = typeof(ClubInsideScene);
		base.ReturnToSceneText = "Press Escape or Left-click here to return to the club.";
		PhoneOverlay.Enabled = false;
	}

	public override void End()
	{
		base.End();
		PhoneOverlay.Enabled = true;
	}
}
