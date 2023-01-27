using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class _UpYZWFVBvOmj4qJYiMDsoZcNEBl : AbstractEvent<SetStageEventData>
{
	public string Quest { get; private set; }

	public int Stage { get; private set; }

	public _UpYZWFVBvOmj4qJYiMDsoZcNEBl(_nR8eroJOHehP0ZGyyTveo6aMTHg _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
		: base(_nR8eroJOHehP0ZGyyTveo6aMTHg_0)
	{
	}

	public override void SetData(SetStageEventData setStageEventData_0)
	{
		base.SetData(setStageEventData_0);
		Quest = setStageEventData_0.Quest;
		Stage = setStageEventData_0.Stage;
	}

	public override void StopCutscene()
	{
		base.StopCutscene();
		PlayerPreferences.GetPlayerData().SetDecimal(Quest, Stage);
		base._5zNdOw7qHmuCAPJFMr3SsZdBlCr.Game._aJh9CibG5YKhkExxgRyVopdfSeJ.SetDecimal(Quest, Stage);
	}

	public override void Update(GameTime gameTime)
	{
		base._xJZUPxDatEzfPQc0nRHR2D1Vwke = true;
	}
}
