using Amorous.Game.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class ShowPhoneEvent : AbstractEvent<ShowPhoneEventData>
{ // _Q8uv6FtAfllzZwWOqNrz1xt5PqB
	public ShowPhoneEvent(Cutscene cutscene) : base(cutscene) {}

	public override void Update(GameTime gameTime)
	{
		if (PhoneOverlay.GetSingleton().ArmPose == PhoneOverlay.EArmPose.ArmDown)
		{
			PhoneOverlay.Show();
		}
		base.IsCompleted = PhoneOverlay.GetSingleton().ArmPose == PhoneOverlay.EArmPose.ArmUp;
	}
}
