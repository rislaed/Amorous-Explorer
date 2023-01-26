using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class _mLFPVyMd2qINchMJaXDDCacB1B5 : AbstractEvent<SwitchToSceneEventData>
{
	public string SceneName { get; private set; }

	public _mLFPVyMd2qINchMJaXDDCacB1B5(_nR8eroJOHehP0ZGyyTveo6aMTHg _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
		: base(_nR8eroJOHehP0ZGyyTveo6aMTHg_0)
	{
	}

	public override void SetData(SwitchToSceneEventData switchToSceneEventData_0)
	{
		base.SetData(switchToSceneEventData_0);
		SceneName = switchToSceneEventData_0.SceneName;
	}

	public override void ResetVariation()
	{
		base.ResetVariation();
		base._5zNdOw7qHmuCAPJFMr3SsZdBlCr.Game._OxLRmpxixplTKChiTPUKAx4uTLG(SceneName);
	}

	public override void Update(GameTime gameTime)
	{
		base._xJZUPxDatEzfPQc0nRHR2D1Vwke = !base._5zNdOw7qHmuCAPJFMr3SsZdBlCr.Game._NdzU0m9x8QDKpVv3DrQmzY5KduB;
	}
}
