using Amorous.Game.Data.Cutscenes;

public class AcceptCallEvent : AbstractContactEvent<AcceptCallEventData>
{ // _6ru28LDcBzLFWNEnOMeKzGLR4qL
	public AcceptCallEvent(Cutscene cutscene) : base(cutscene) {}

	public override void Start()
	{
		base.Start();
		PhoneOverlay.GetSingleton().AcceptCall(Contact);
	}
}
