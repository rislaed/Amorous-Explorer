using Amorous.Game.Data.Cutscenes;

public class IncomingIMEvent : AbstractContactEvent<IncomingIMEventData>
{ // _wwfAgZUHJowQ86tf0jaOFwETyS
	public IncomingIMEvent(Cutscene cutscene)
		: base(cutscene) {}

	public override void Begin()
	{
		base.Begin();
		PhoneOverlay.Get().IncomingIM(Contact);
	}
}
