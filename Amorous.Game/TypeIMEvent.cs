using Amorous.Game.Data.Cutscenes;

public class TypeIMEvent : AbstractContactEvent<TypeIMEventData>
{ // _5JvBKF1vuoXxsGsAU4bquGFNMgk
	public TypeIMEvent(Cutscene cutscene)
		: base(cutscene) {}

	public override void Start()
	{
		base.Start();
		PhoneOverlay.Get().TypeIM(Contact);
	}
}
