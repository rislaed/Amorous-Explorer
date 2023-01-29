using Amorous.Game.Data.Cutscenes;

public class OutgoingCallEvent : AbstractContactEvent<OutgoingCallEventData>
{ // _fc8db7UrtPmFbaoLyjzI60bVx9qA
	public OutgoingCallEvent(Cutscene cutscene)
		: base(cutscene) {}

	public override void Begin()
	{
		base.Begin();
		PhoneOverlay.Get().OutgoingCall(Contact);
	}
}
