using Amorous.Game.Data.Cutscenes;

public class IncomingCallEvent : AbstractContactEvent<IncomingCallEventData>
{ // _UAk3prPEJY0oR9vawY870oFAXs
	public IncomingCallEvent(Cutscene cutscene)
		: base(cutscene) {}

	public override void Start()
	{
		base.Start();
		PhoneOverlay.Get().IncomingCall(Contact);
	}
}
