using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class _KxfXNCPP3dNfGOZBuSyD82CAbxp : AbstractEvent<SetFlagEventData>
{
	public string Flag { get; private set; }

	public bool Value { get; private set; }

	public _KxfXNCPP3dNfGOZBuSyD82CAbxp(_nR8eroJOHehP0ZGyyTveo6aMTHg _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
		: base(_nR8eroJOHehP0ZGyyTveo6aMTHg_0)
	{
	}

	public override void SetData(SetFlagEventData setFlagEventData_0)
	{
		base.SetData(setFlagEventData_0);
		Flag = setFlagEventData_0.Flag;
		Value = setFlagEventData_0.Value;
	}

	public override void ResetVariation()
	{
		base.ResetVariation();
		PlayerPreferences.GetPlayerData().SetBit(Flag, Value);
		base._5zNdOw7qHmuCAPJFMr3SsZdBlCr.Game._aJh9CibG5YKhkExxgRyVopdfSeJ.SetBit(Flag, Value);
	}

	public override void Update(GameTime gameTime)
	{
		base._xJZUPxDatEzfPQc0nRHR2D1Vwke = true;
	}
}
