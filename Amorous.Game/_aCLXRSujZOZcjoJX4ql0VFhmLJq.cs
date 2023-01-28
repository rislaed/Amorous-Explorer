using Amorous.Game.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class _aCLXRSujZOZcjoJX4ql0VFhmLJq : AbstractEvent<HideGameBoxEventData>
{
	public _aCLXRSujZOZcjoJX4ql0VFhmLJq(Cutscene _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
		: base(_nR8eroJOHehP0ZGyyTveo6aMTHg_0)
	{
	}

	public override void Begin()
	{
		base.Begin();
		PhoneOverlay.Get()._TfR4rAxaOpP26NUkiRO1hT0Q3Ib();
	}

	public override void Update(GameTime gameTime)
	{
		base.Completable = true;
	}
}
