using System;

namespace Amorous.Game.Scenes;

public class DateCreditsMenuScene : CreditsMenuScene
{
	public DateCreditsMenuScene(IAmorous game)
		: base(game)
	{
		base._t76cjDKppsRdw5nUq3tnNw3ypAv = typeof(ClubInsideScene);
		base._ICAb9QUE8hnbl0uKD8fBpEB1kSV = "Press Escape or Left-click here to return to the club.";
		PhoneOverlay._kf3EbE0B70xGe1szklqAZyCqoLj = false;
	}

	public override void End()
	{
		base.End();
		PhoneOverlay._kf3EbE0B70xGe1szklqAZyCqoLj = true;
	}
}
