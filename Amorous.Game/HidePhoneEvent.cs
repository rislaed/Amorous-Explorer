using Amorous.Game.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class HidePhoneEvent : AbstractEvent<HidePhoneEventData>
{ // _4l0mqwkGwpWhRXWDbil9hVRfzvH
	public HidePhoneEvent(Cutscene cutscene) : base(cutscene) {}

	public override void Update(GameTime gameTime)
	{
		if (PhoneOverlay.GetSingleton().ArmPose == PhoneOverlay.EArmPose.ArmUp)
		{
			PhoneOverlay.Hide();
		}
		base.IsCompleted = PhoneOverlay.GetSingleton().ArmPose == PhoneOverlay.EArmPose.ArmDown;
	}
}
