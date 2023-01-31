namespace Amorous.Game.Scenes;

public class ProloguePlayerCustomizationScene : PlayerCustomizationScene
{
	override protected string ReturnToGameText => "Back to Prologue";

	public ProloguePlayerCustomizationScene(IAmorous game)
		: base(game)
	{
		MightEnterName = true;
	}

	protected override void ShowExit()
	{
		base.Squid.ShowSelection("Are you sure this how you want to look in the Game?", new string[2] { "Oops, my bad!", "Yes please!" }, AmorousData.WideDialogueOffset, delegate(int int_0)
		{
			if (int_0 == 1)
			{
				PhoneOverlay.Get().RefreshSkin();
				base.Game.Achievements.TriggerAchievement(Achievements.AchievementGeneric1);
				base.Game.PlayCutscene(AmorousData.Prologue);
			}
		});
	}
}
