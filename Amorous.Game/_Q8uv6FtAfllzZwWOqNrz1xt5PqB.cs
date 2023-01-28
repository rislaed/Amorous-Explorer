using Amorous.Game.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class _Q8uv6FtAfllzZwWOqNrz1xt5PqB : AbstractEvent<ShowPhoneEventData>
{
	public _Q8uv6FtAfllzZwWOqNrz1xt5PqB(Cutscene _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
		: base(_nR8eroJOHehP0ZGyyTveo6aMTHg_0)
	{
	}

	public override void Update(GameTime gameTime)
	{
		if (PhoneOverlay.Get().Phase == PhoneOverlay.PhonePhase.ArmDown)
		{
			PhoneOverlay.Show();
		}
		base.Completable = PhoneOverlay.Get().Phase == PhoneOverlay.PhonePhase.ArmUp;
	}
}
