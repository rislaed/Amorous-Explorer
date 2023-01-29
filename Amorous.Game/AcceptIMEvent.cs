using Amorous.Game.Data.Cutscenes;

public class AcceptIMEvent : AbstractContactEvent<AcceptIMEventData>
{ // _VRytu7PQHrCSnlldjNfLtYOf9uA
	public AcceptIMEvent(Cutscene cutscene)
		: base(cutscene) {}

	public override void Begin()
	{
		base.Begin();
		PhoneOverlay.Get().AcceptIM(Contact);
	}
}
