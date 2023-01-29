using Amorous.Game.Data.Cutscenes;

public class OutgoingIMEvent : AbstractContactEvent<OutgoingIMEventData>
{ // _wRBaYZysXLXKiRB5DUQqoCj6UJh
	public OutgoingIMEvent(Cutscene cutscene)
		: base(cutscene) {}

	public override void Begin()
	{
		base.Begin();
		PhoneOverlay.Get().OutgoingIM(Contact);
	}
}
