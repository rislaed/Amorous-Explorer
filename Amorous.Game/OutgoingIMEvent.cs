using Amorous.Game.Data.Cutscenes;

public class OutgoingIMEvent : AbstractContactEvent<OutgoingIMEventData>
{ // _wRBaYZysXLXKiRB5DUQqoCj6UJh
	public OutgoingIMEvent(Cutscene cutscene) : base(cutscene) {}

	public override void Start()
	{
		base.Start();
		PhoneOverlay.GetSingleton().OutgoingIM(Contact);
	}
}
