using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class ConditionalBranchEvent : AbstractEvent<ConditionalBranchEventData>
{ // _nUSn1S5NdjAJAimBJlnnGXnz2o8
	public string Flag { get; private set; }
	public int TrueID { get; private set; }
	public int FalseID { get; private set; }

	public ConditionalBranchEvent(Cutscene cutscene)
		: base(cutscene) {}

	public override void SetData(ConditionalBranchEventData eventData)
	{
		base.SetData(eventData);
		Flag = eventData.Flag;
		TrueID = eventData.TrueID;
		FalseID = eventData.FalseID;
	}

	public override void Update(GameTime gameTime)
	{
		base.Completable = true;
		bool flag = PlayerPreferences.GetPlayerData().GetFlag(Flag);
		base.NextID = (flag ? TrueID : FalseID);
	}
}
