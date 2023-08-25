using System;
using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class UnlockContactEvent : AbstractEvent<UnlockContactEventData>
{ // _YTLuu5R7clnJnMHMmlsmzn5h6SN
	public PlayerData.EPhoneContacts Contact { get; private set; }

	public UnlockContactEvent(Cutscene cutscene) : base(cutscene) {}

	public override void SetData(UnlockContactEventData eventData)
	{
		base.SetData(eventData);
		Contact = (Enum.TryParse<PlayerData.EPhoneContacts>(eventData.Contact, out var contact) ? contact : PlayerData.EPhoneContacts.None);
	}

	public override void Start()
	{
		base.Start();
		PlayerPreferences.GetPlayerData().UnlockContact(Contact);
		base.Cutscene.Game.Achievements.UnlockContact(Contact);
	}

	public override void Update(GameTime gameTime)
	{
		base.IsCompleted = true;
	}
}
