using Amorous.Game.Data.Cutscenes;

public class DeclineIMEvent : AbstractContactEvent<DeclineIMEventData>
{ // _I6q0n2KWLioIBLgZcgING9wxAAJ
	public DeclineIMEvent(Cutscene cutscene) : base(cutscene) {}

	public override void Start()
	{
		base.Start();
		PhoneOverlay.GetSingleton().DeclineIM(Contact);
	}
}
