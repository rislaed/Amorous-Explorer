using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class SetStageEvent : AbstractEvent<SetStageEventData>
{ // _UpYZWFVBvOmj4qJYiMDsoZcNEBl
	public string Quest { get; private set; }
	public int Stage { get; private set; }

	public SetStageEvent(Cutscene cutscene)
		: base(cutscene) {}

	public override void SetData(SetStageEventData eventData)
	{
		base.SetData(eventData);
		Quest = eventData.Quest;
		Stage = eventData.Stage;
	}

	public override void Start()
	{
		base.Start();
		PlayerPreferences.GetPlayerData().SetStage(Quest, Stage);
		base.Cutscene.Game.Achievements.SetStage(Quest, Stage);
	}

	public override void Update(GameTime gameTime)
	{
		base.Completable = true;
	}
}
