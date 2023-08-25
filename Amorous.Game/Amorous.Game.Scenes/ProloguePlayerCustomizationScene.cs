namespace Amorous.Game.Scenes;

public class ProloguePlayerCustomizationScene : PlayerCustomizationScene
{
	override protected string ReturnToGameText => "Back to Prologue";

	public ProloguePlayerCustomizationScene(IAmorous game) : base(game)
	{
		MightEnterName = true;
	}

	protected override void ShowExit()
	{
		base.Desktop.ShowSelection("Are you sure this how you want to look in the Game?", new string[2] { "Oops, my bad!", "Yes please!" }, AmorousData.ShortDialogueWidth, delegate(int answer)
		{
			if (answer == 1)
			{
				PhoneOverlay.GetSingleton().RefreshSkin();
				base.Game.Achievements.TriggerAchievement(Achievements.AchievementGeneric1);
				base.Game.PlayCutscene(AmorousData.Prologue);
			}
		});
	}
}
