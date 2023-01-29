using Amorous.Game.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class HidePhoneEvent : AbstractEvent<HidePhoneEventData>
{ // _4l0mqwkGwpWhRXWDbil9hVRfzvH
	public HidePhoneEvent(Cutscene cutscene)
		: base(cutscene) {}

	public override void Update(GameTime gameTime)
	{
		if (PhoneOverlay.Get().Phase == PhoneOverlay.PhonePhase.ArmUp)
		{
			PhoneOverlay.Hide();
		}
		base.Completable = PhoneOverlay.Get().Phase == PhoneOverlay.PhonePhase.ArmDown;
	}
}
