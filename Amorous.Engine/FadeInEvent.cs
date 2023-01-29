using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class FadeInEvent : AbstractEvent<FadeInEventData>
{ // _M47cB7N4CmnVNnmFfoCyKYvvGwR
	public FadeInEvent(Cutscene cutscene)
		: base(cutscene) {}

	public override void Begin()
	{
		base.Begin();
		base.Cutscene.Game.Fading.FadeIn(delegate
		{
			base.Completable = true;
		});
	}

	public override void Update(GameTime gameTime) {}
}
