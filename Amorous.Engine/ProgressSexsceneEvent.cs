using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class ProgressSexsceneEvent : AbstractEvent<ProgressSexsceneEventData>
{ // _ca2ECa4c2Ix3gwR2CqVdbvPB4AC
	public ProgressSexsceneEvent(Cutscene cutscene) : base(cutscene) {}

	public override void Start()
	{
		base.Start();
		base.Cutscene.Game.Sexscene.Progress();
	}

	public override void Update(GameTime gameTime)
	{
		base.IsCompleted = true;
	}
}
