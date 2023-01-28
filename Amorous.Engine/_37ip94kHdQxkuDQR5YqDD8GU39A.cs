using System.Runtime.CompilerServices;
using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class _37ip94kHdQxkuDQR5YqDD8GU39A : AbstractEvent<FadeOutEventData>
{
	public _37ip94kHdQxkuDQR5YqDD8GU39A(Cutscene _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
		: base(_nR8eroJOHehP0ZGyyTveo6aMTHg_0) {}

	public override void Begin()
	{
		base.Begin();
		base.Cutscene.Game.Fading.Show(delegate
		{
			base.Completable = true;
		});
	}

	public override void Update(GameTime gameTime) {}
}
