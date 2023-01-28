using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class _mLFPVyMd2qINchMJaXDDCacB1B5 : AbstractEvent<SwitchToSceneEventData>
{
	public string SceneName { get; private set; }

	public _mLFPVyMd2qINchMJaXDDCacB1B5(Cutscene _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
		: base(_nR8eroJOHehP0ZGyyTveo6aMTHg_0)
	{
	}

	public override void SetData(SwitchToSceneEventData switchToSceneEventData_0)
	{
		base.SetData(switchToSceneEventData_0);
		SceneName = switchToSceneEventData_0.SceneName;
	}

	public override void Begin()
	{
		base.Begin();
		base.Cutscene.Game.SwitchScene(SceneName);
	}

	public override void Update(GameTime gameTime)
	{
		base.Completable = !base.Cutscene.Game.InScenePending;
	}
}
