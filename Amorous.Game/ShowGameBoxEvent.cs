using Amorous.Game.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class ShowGameBoxEvent : AbstractEvent<ShowGameBoxEventData>
{ // _4oLylSYIsuljNZSlkquQd6azTzG
	public ShowGameBoxEvent(Cutscene cutscene) : base(cutscene) {}

	public override void Start()
	{
		base.Start();
		PhoneOverlay.GetSingleton().ShowGameBox();
	}

	public override void Update(GameTime gameTime)
	{
		base.IsCompleted = true;
	}
}
