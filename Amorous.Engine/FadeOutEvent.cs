using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class FadeOutEvent : AbstractEvent<FadeOutEventData>
{ // _37ip94kHdQxkuDQR5YqDD8GU39A
	public FadeOutEvent(Cutscene cutscene) : base(cutscene) {}

	public override void Start()
	{
		base.Start();
		base.Cutscene.Game.Fader.FadeOut(delegate
		{
			base.IsCompleted = true;
		});
	}

	public override void Update(GameTime gameTime) {}
}
