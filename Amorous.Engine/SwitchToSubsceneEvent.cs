using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class SwitchToSubsceneEvent : AbstractEvent<SwitchToSubsceneEventData>
{ // _ZXdfBmHEapkc67visJnDe1hgtuz
	public string SubsceneName { get; private set; }

	public SwitchToSubsceneEvent(Cutscene cutscene) : base(cutscene) {}

	public override void SetData(SwitchToSubsceneEventData eventData)
	{
		base.SetData(eventData);
		SubsceneName = eventData.SubsceneName;
	}

	public override void Start()
	{
		base.Start();
		base.Cutscene.Game.Scene.SwitchToSubscene(SubsceneName);
	}

	public override void Update(GameTime gameTime)
	{
		base.IsCompleted = true;
	}
}
