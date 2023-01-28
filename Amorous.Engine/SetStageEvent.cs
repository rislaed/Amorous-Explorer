using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class SetStageEvent : AbstractEvent<SetStageEventData>
{
	public string Quest { get; private set; }
	public int Stage { get; private set; }

	public SetStageEvent(Cutscene _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
		: base(_nR8eroJOHehP0ZGyyTveo6aMTHg_0) {}

	public override void SetData(SetStageEventData eventData)
	{
		base.SetData(eventData);
		Quest = eventData.Quest;
		Stage = eventData.Stage;
	}

	public override void Begin()
	{
		base.Begin();
		PlayerPreferences.GetPlayerData().SetDecimal(Quest, Stage);
		base.Cutscene.Game.Achievements.SetDecimal(Quest, Stage);
	}

	public override void Update(GameTime gameTime)
	{
		base.Completable = true;
	}
}
