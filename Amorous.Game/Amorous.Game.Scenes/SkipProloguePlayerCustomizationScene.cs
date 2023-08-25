using Microsoft.Xna.Framework;

namespace Amorous.Game.Scenes;

public class SkipProloguePlayerCustomizationScene : PlayerCustomizationScene
{
	private bool completed;

	protected override string ReturnToGameText => "Back to Club";

	public SkipProloguePlayerCustomizationScene(IAmorous game) : base(game)
	{
		MightEnterName = true;
	}

	protected override void ShowExit()
	{
		base.Desktop.ShowSelection("Are you sure this how you want to look in the Game?", new string[2] { "Oops, my bad!", "Yes please!" }, AmorousData.ShortDialogueWidth, delegate(int index)
		{
			if (index == 1)
			{
				base.Game.Achievements.TriggerAchievement(Achievements.AchievementGeneric1);
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
			PlayerData data = PlayerPreferences.GetPlayerData();
			data.UnlockContact(PlayerData.EPhoneContacts.Coby);
			data.InsertStage(AmorousData.Prologue, AmorousData.PrologueStateCompleted);
			data.InsertFlag(AmorousData.CobyLeftClub, flag: true);
			PhoneOverlay.Enabled = true;
			PhoneOverlay.GetSingleton().RefreshSkin();
			base.Game.Achievements.UnlockContact(PlayerData.EPhoneContacts.Coby);
			base.Game.Achievements.TriggerAchievement(Achievements.AchievementGeneric4);
			base.Game.StartScene<ClubEntranceScene>();
		}
	}
}
