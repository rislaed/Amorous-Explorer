using System;
using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class DisableContactEvent : AbstractEvent<DisableContactEventData>
{ // _RXkY1nA34kgK019S1RLCVdAAPPD
	public PlayerData.EPhoneContacts Contact { get; private set; }

	public DisableContactEvent(Cutscene cutscene)
		: base(cutscene) {}

	public override void SetData(DisableContactEventData eventData)
	{
		base.SetData(eventData);
		Contact = (Enum.TryParse<PlayerData.EPhoneContacts>(eventData.Contact, out var contact) ? contact : PlayerData.EPhoneContacts.None);
	}

	public override void Begin()
	{
		base.Begin();
		PlayerPreferences.GetPlayerData().DisableContact(Contact);
	}

	public override void Update(GameTime gameTime)
	{
		base.Completable = true;
	}
}
