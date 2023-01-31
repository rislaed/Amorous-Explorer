using Microsoft.Xna.Framework;

namespace Amorous.Game.Scenes;

public class SkipProloguePlayerCustomizationScene : PlayerCustomizationScene
{
	private bool _pendingEntering;
	override protected string ReturnToGameText => "Back to Club";

	public SkipProloguePlayerCustomizationScene(IAmorous game)
		: base(game)
	{
		MightEnterName = true;
	}

	protected override void ShowExit()
	{
		base.Squid.ShowSelection("Are you sure this how you want to look in the Game?", new string[2] { "Oops, my bad!", "Yes please!" }, AmorousData.WideDialogueOffset, delegate(int index)
		{
			if (index == 1)
			{
				base.Game.Achievements.TriggerAchievement(Achievements.AchievementGeneric1);
				base.Game.PlayCutscene(AmorousData.Gender);
				_pendingEntering = true;
			}
		});
	}

	public override void Update(GameTime gameTime)
	{
		base.Update(gameTime);
		if (_pendingEntering && !base.Game.InPendingScene && base.Game.Cutscene == null)
		{
			_pendingEntering = false;
			PlayerData data = PlayerPreferences.GetPlayerData();
			data.UnlockContact(PlayerData.EPhoneContacts.Coby);
			data.SetStage(AmorousData.Prologue, AmorousData.PrologueStateCompleted);
			data.SetFlag(AmorousData.CobyLeftClub, flag: true);
			PhoneOverlay.Enabled = true;
			PhoneOverlay.Get().RefreshSkin();
			base.Game.Achievements.UnlockContact(PlayerData.EPhoneContacts.Coby);
			base.Game.Achievements.TriggerAchievement(Achievements.AchievementGeneric4);
			base.Game.StartScene<ClubEntranceScene>();
		}
	}
}
