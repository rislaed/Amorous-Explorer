using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class FadeInEvent : AbstractEvent<FadeInEventData>
{ // _M47cB7N4CmnVNnmFfoCyKYvvGwR
	public FadeInEvent(Cutscene cutscene) : base(cutscene) {}

	public override void Start()
	{
		base.Start();
		base.Cutscene.Game.Fader.FadeIn(delegate
		{
			base.IsCompleted = true;
		});
	}

	public override void Update(GameTime gameTime) {}
}
