using System;
using System.Runtime.CompilerServices;
using Squid;

namespace Amorous.Game.Scenes;

public class ProloguePlayerCustomizationScene : PlayerCustomizationScene
{
	override protected string ReturnToGameText => "Back to Prologue";

	public ProloguePlayerCustomizationScene(IAmorous game)
		: base(game)
	{
		MightConfigurateEverything = true;
	}

	protected override void ConfirmEverything()
	{
		base.Squid.ShowSelection("Are you sure this how you want to look in the Game?", new string[2] { "Oops, my bad!", "Yes please!" }, AmorousData.WideDialogueOffset, delegate(int int_0)
		{
			if (int_0 == 1)
			{
				PhoneOverlay.Get().RefreshSkin();
				base.Game.Achievements.GainAchievement(Achievements.AchievementGeneric1);
				base.Game.StartCutscene(AmorousData.Prologue);
			}
		});
	}
}
