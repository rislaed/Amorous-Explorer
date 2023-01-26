using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class _nUSn1S5NdjAJAimBJlnnGXnz2o8 : AbstractEvent<ConditionalBranchEventData>
{
	public string Flag { get; private set; }

	public int TrueID { get; private set; }

	public int FalseID { get; private set; }

	public _nUSn1S5NdjAJAimBJlnnGXnz2o8(_nR8eroJOHehP0ZGyyTveo6aMTHg _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
		: base(_nR8eroJOHehP0ZGyyTveo6aMTHg_0)
	{
	}

	public override void SetData(ConditionalBranchEventData conditionalBranchEventData_0)
	{
		base.SetData(conditionalBranchEventData_0);
		Flag = conditionalBranchEventData_0.Flag;
		TrueID = conditionalBranchEventData_0.TrueID;
		FalseID = conditionalBranchEventData_0.FalseID;
	}

	public override void Update(GameTime gameTime)
	{
		base._xJZUPxDatEzfPQc0nRHR2D1Vwke = true;
		bool flag = PlayerPreferences.GetPlayerData().GetBit(Flag);
		base.NextID = (flag ? TrueID : FalseID);
	}
}
