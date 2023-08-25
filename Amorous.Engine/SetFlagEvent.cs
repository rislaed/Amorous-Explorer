using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class SetFlagEvent : AbstractEvent<SetFlagEventData>
{ // _KxfXNCPP3dNfGOZBuSyD82CAbxp
	public string Flag { get; private set; }
	public bool Value { get; private set; }

	public SetFlagEvent(Cutscene cutscene) : base(cutscene) {}

	public override void SetData(SetFlagEventData eventData)
	{
		base.SetData(eventData);
		Flag = eventData.Flag;
		Value = eventData.Value;
	}

	public override void Start()
	{
		base.Start();
		PlayerPreferences.GetPlayerData().InsertFlag(Flag, Value);
		base.Cutscene.Game.Achievements.InsertFlag(Flag, Value);
	}

	public override void Update(GameTime gameTime)
	{
		base.IsCompleted = true;
	}
}
