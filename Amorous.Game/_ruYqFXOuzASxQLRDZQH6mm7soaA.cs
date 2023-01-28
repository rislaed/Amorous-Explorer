using Amorous.Game.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class _ruYqFXOuzASxQLRDZQH6mm7soaA : AbstractEvent<JaxContactsCheckEventData>
{
	public int OnlyJaxID { get; set; }

	public int OneOrTwoID { get; set; }

	public int ThreeOrMoreID { get; set; }

	public _ruYqFXOuzASxQLRDZQH6mm7soaA(Cutscene _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
		: base(_nR8eroJOHehP0ZGyyTveo6aMTHg_0)
	{
	}

	public override void SetData(JaxContactsCheckEventData jaxContactsCheckEventData_0)
	{
		base.SetData(jaxContactsCheckEventData_0);
		OnlyJaxID = jaxContactsCheckEventData_0.OnlyJaxID;
		OneOrTwoID = jaxContactsCheckEventData_0.OneOrTwoID;
		ThreeOrMoreID = jaxContactsCheckEventData_0.ThreeOrMoreID;
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
