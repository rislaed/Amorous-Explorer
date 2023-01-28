using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Squid;

namespace Amorous.Game.Scenes;

public class BackToPlayerCustomizationScene : PlayerCustomizationScene
{
	private bool _e1Kru66UIN1SkWkBreRDCF5RsWA;
	override protected string ReturnToGameText => "Back to Club";

	public BackToPlayerCustomizationScene(IAmorous game)
		: base(game)
	{
		MightConfigurateEverything = true;
		PhoneOverlay._kf3EbE0B70xGe1szklqAZyCqoLj = false;
	}

	protected override void _hI8MfcRDpV9Q45afjBJe8lA5sbr()
	{
	}

	protected override void ConfirmEverything()
	{
		base.Squid.ShowSelection("Are you sure this how you want to look in the Game?", new string[2] { "Oops, my bad!", "Yes please!" }, 250, delegate(int int_0)
		{
			if (int_0 == 1)
			{
				base.Game.Achievements.GainAchievement(Achievements.AchievementGeneric1);
				PlayerPreferences.GetPlayerData().SetDecimal("Gender", 10);
				PlayerPreferences.GetPlayerData().Remove("Player.Gender");
				PlayerPreferences.GetPlayerData().Remove("Player.No");
				base.Game.StartCutscene("Gender");
				_e1Kru66UIN1SkWkBreRDCF5RsWA = true;
			}
		});
	}

	public override void Update(GameTime gameTime)
	{
		base.Update(gameTime);
		if (_e1Kru66UIN1SkWkBreRDCF5RsWA && !base.Game.InScenePending && base.Game.Cutscene == null)
		{
			_e1Kru66UIN1SkWkBreRDCF5RsWA = false;
			PhoneOverlay._kf3EbE0B70xGe1szklqAZyCqoLj = true;
			PhoneOverlay.Get()._Xrfjrxr72hHh4bDdQB7HzEbJUCb();
			base.Game.StartScene<ClubEntranceScene>();
		}
	}
}
