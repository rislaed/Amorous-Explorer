using Amorous.Game.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class _4l0mqwkGwpWhRXWDbil9hVRfzvH : AbstractEvent<HidePhoneEventData>
{
	public _4l0mqwkGwpWhRXWDbil9hVRfzvH(Cutscene _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
		: base(_nR8eroJOHehP0ZGyyTveo6aMTHg_0)
	{
	}

	public override void Update(GameTime gameTime)
	{
		if (PhoneOverlay.Get().Phase == PhoneOverlay.PhonePhase.ArmUp)
		{
			PhoneOverlay.Hide();
		}
		base.Completable = PhoneOverlay.Get().Phase == PhoneOverlay.PhonePhase.ArmDown;
	}
}
