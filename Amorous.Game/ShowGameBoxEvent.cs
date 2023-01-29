using Amorous.Game.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class ShowGameBoxEvent : AbstractEvent<ShowGameBoxEventData>
{ // _4oLylSYIsuljNZSlkquQd6azTzG
	public ShowGameBoxEvent(Cutscene cutscene)
		: base(cutscene) {}

	public override void Begin()
	{
		base.Begin();
		PhoneOverlay.Get().ShowGameBox();
	}

	public override void Update(GameTime gameTime)
	{
		base.Completable = true;
	}
}
