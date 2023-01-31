using Microsoft.Xna.Framework;

namespace Amorous.Game.Scenes;

public class BackToPlayerCustomizationScene : PlayerCustomizationScene
{
	private bool _updatable;

	override protected string ReturnToGameText => "Back to Club";

	public BackToPlayerCustomizationScene(IAmorous game)
		: base(game)
	{
		MightEnterName = true;
		PhoneOverlay.Enabled = false;
	}

	protected override void FetchTemplates() {}

	protected override void ShowExit()
	{
		base.Squid.ShowSelection("Are you sure this how you want to look in the Game?", new string[2] { "Oops, my bad!", "Yes please!" }, AmorousData.WideDialogueOffset, delegate(int answer)
		{
			if (answer == 1)
			{
				base.Game.Achievements.TriggerAchievement(Achievements.AchievementGeneric1);
				PlayerPreferences.GetPlayerData().SetStage(AmorousData.Gender, 10);
				PlayerPreferences.GetPlayerData().Remove("Player.Gender");
				PlayerPreferences.GetPlayerData().Remove("Player.No");
				base.Game.PlayCutscene(AmorousData.Gender);
				_updatable = true;
			}
		});
	}

	public override void Update(GameTime gameTime)
	{
		base.Update(gameTime);
		if (_updatable && !base.Game.InPendingScene && base.Game.Cutscene == null)
		{
			_updatable = false;
			PhoneOverlay.Enabled = true;
			PhoneOverlay.Get().RefreshSkin();
			base.Game.StartScene<ClubEntranceScene>();
		}
	}
}
