using System;
using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class _YTLuu5R7clnJnMHMmlsmzn5h6SN : AbstractEvent<UnlockContactEventData>
{
	public PlayerData.EPhoneContacts Contact { get; private set; }

	public _YTLuu5R7clnJnMHMmlsmzn5h6SN(Cutscene _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
		: base(_nR8eroJOHehP0ZGyyTveo6aMTHg_0)
	{
	}

	public override void SetData(UnlockContactEventData unlockContactEventData_0)
	{
		base.SetData(unlockContactEventData_0);
		Contact = (Enum.TryParse<PlayerData.EPhoneContacts>(unlockContactEventData_0.Contact, out var result) ? result : PlayerData.EPhoneContacts.None);
	}

	public override void Begin()
	{
		base.Begin();
		PlayerPreferences.GetPlayerData().AddContact(Contact);
		base.Cutscene.Game.Achievements.GainContact(Contact);
	}

	public override void Update(GameTime gameTime)
	{
		base.Completable = true;
	}
}
