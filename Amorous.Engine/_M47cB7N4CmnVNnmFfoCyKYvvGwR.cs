using System.Runtime.CompilerServices;
using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class _M47cB7N4CmnVNnmFfoCyKYvvGwR : AbstractEvent<FadeInEventData>
{
	public _M47cB7N4CmnVNnmFfoCyKYvvGwR(Cutscene _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
		: base(_nR8eroJOHehP0ZGyyTveo6aMTHg_0)
	{
	}

	public override void Begin()
	{
		base.Begin();
		base.Cutscene.Game.Fading.Hide(delegate
		{
			base.Completable = true;
		});
	}

	public override void Update(GameTime gameTime)
	{
	}
}
