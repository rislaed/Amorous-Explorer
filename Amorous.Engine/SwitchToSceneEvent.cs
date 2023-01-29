using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class SwitchToSceneEvent : AbstractEvent<SwitchToSceneEventData>
{ // _mLFPVyMd2qINchMJaXDDCacB1B5
	public string SceneName { get; private set; }

	public SwitchToSceneEvent(Cutscene cutscene)
		: base(cutscene) {}

	public override void SetData(SwitchToSceneEventData eventData)
	{
		base.SetData(eventData);
		SceneName = eventData.SceneName;
	}

	public override void Start()
	{
		base.Start();
		base.Cutscene.Game.SwitchToScene(SceneName);
	}

	public override void Update(GameTime gameTime)
	{
		base.Completable = !base.Cutscene.Game.InScenePending;
	}
}
