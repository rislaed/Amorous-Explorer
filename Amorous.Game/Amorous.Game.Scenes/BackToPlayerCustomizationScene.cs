using Microsoft.Xna.Framework;

namespace Amorous.Game.Scenes;

public class BackToPlayerCustomizationScene : PlayerCustomizationScene
{
	private bool completed;

	protected override string ReturnToGameText => "Back to Club";

	public BackToPlayerCustomizationScene(IAmorous game) : base(game)
	{
		MightEnterName = true;
		PhoneOverlay.Enabled = false;
	}

	protected override void FetchTemplates() {}

	protected override void ShowExit()
	{
		base.Desktop.ShowSelection("Are you sure this how you want to look in the Game?", new string[2] { "Oops, my bad!", "Yes please!" }, AmorousData.ShortDialogueWidth, delegate(int answer)
		{
			if (answer == 1)
			{
				base.Game.Achievements.TriggerAchievement(Achievements.AchievementGeneric1);
				PlayerPreferences.GetPlayerData().InsertStage(AmorousData.Gender, 10);
				PlayerPreferences.GetPlayerData().Remove("Player.Gender");
				PlayerPreferences.GetPlayerData().Remove("Player.No");
				base.Game.PlayCutscene(AmorousData.Gender);
				completed = true;
			}
		});
	}

	public override void Update(GameTime gameTime)
	{
		base.Update(gameTime);
		if (completed && !base.Game.IsScenePending && base.Game.Cutscene == null)
		{
			completed = false;
			PhoneOverlay.Enabled = true;
			PhoneOverlay.GetSingleton().RefreshSkin();
			base.Game.StartScene<ClubEntranceScene>();
		}
	}
}
