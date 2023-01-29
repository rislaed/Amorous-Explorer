using Amorous.Game.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class JaxContactsCheckEvent : AbstractEvent<JaxContactsCheckEventData>
{ // _ruYqFXOuzASxQLRDZQH6mm7soaA
	public int OnlyJaxID { get; set; }
	public int OneOrTwoID { get; set; }
	public int ThreeOrMoreID { get; set; }

	public JaxContactsCheckEvent(Cutscene cutscene)
		: base(cutscene) {}

	public override void SetData(JaxContactsCheckEventData eventData)
	{
		base.SetData(eventData);
		OnlyJaxID = eventData.OnlyJaxID;
		OneOrTwoID = eventData.OneOrTwoID;
		ThreeOrMoreID = eventData.ThreeOrMoreID;
	}

	public override void Update(GameTime gameTime)
	{
		PlayerData data = PlayerPreferences.GetPlayerData();
		int num = data.GetContactCount();
		if (num > 1)
		{
			if (num >= 1 && num <= 2)
			{
				base.NextID = OneOrTwoID;
			}
			else
			{
				base.NextID = ThreeOrMoreID;
			}
		}
		else
		{
			base.NextID = OnlyJaxID;
		}
		base.Completable = true;
	}
}
