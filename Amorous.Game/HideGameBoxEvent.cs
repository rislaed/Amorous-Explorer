using Amorous.Game.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class HideGameBoxEvent : AbstractEvent<HideGameBoxEventData>
{ // _aCLXRSujZOZcjoJX4ql0VFhmLJq
	public HideGameBoxEvent(Cutscene cutscene)
		: base(cutscene) {}

	public override void Begin()
	{
		base.Begin();
		PhoneOverlay.Get().HideGameBox();
	}

	public override void Update(GameTime gameTime)
	{
		base.Completable = true;
	}
}
