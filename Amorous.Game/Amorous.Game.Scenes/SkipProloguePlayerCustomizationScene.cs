using Microsoft.Xna.Framework;

namespace Amorous.Game.Scenes;

public class SkipProloguePlayerCustomizationScene : PlayerCustomizationScene
{
	private bool _pendingEntering;
	override protected string ReturnToGameText => "Back to Club";

	public SkipProloguePlayerCustomizationScene(IAmorous game)
		: base(game)
	{
		MightConfigurateEverything = true;
	}

	protected override void ConfirmEverything()
	{
		base.Squid.ShowSelection("Are you sure this how you want to look in the Game?", new string[2] { "Oops, my bad!", "Yes please!" }, 250, delegate(int index)
		{
			if (index == 1)
			{
				base.Game.Achievements.GainAchievement(Achievements.AchievementGeneric1);
				base.Game.StartCutscene("Gender");
				_pendingEntering = true;
			}
		});
	}

	public override void Update(GameTime gameTime)
	{
		base.Update(gameTime);
		if (_pendingEntering && !base.Game.InScenePending && base.Game.Cutscene == null)
		{
			_pendingEntering = false;
			PlayerData data = PlayerPreferences.GetPlayerData();
			data.AddContact(PlayerData.EPhoneContacts.Coby);
			data.SetDecimal("Prologue", 40);
			data.SetBit("CobyLeftClub", bool_0: true);
			PhoneOverlay._kf3EbE0B70xGe1szklqAZyCqoLj = true;
			PhoneOverlay.Get()._Xrfjrxr72hHh4bDdQB7HzEbJUCb();
			base.Game.Achievements.GainContact(PlayerData.EPhoneContacts.Coby);
			base.Game.Achievements.GainAchievement(Achievements.AchievementGeneric4);
			base.Game.StartScene<ClubEntranceScene>();
		}
	}
}
