using System;
using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public abstract class AbstractContactEvent<T> : AbstractEvent<T> where T : UnlockContactEventData
{ // _0feLylFvn7NOajSXvkEDMJIATof
	protected PlayerData.EPhoneContacts Contact;

	protected AbstractContactEvent(Cutscene cutscene) : base(cutscene) {}

	public override void SetData(T eventData)
	{
		base.SetData(eventData);
		Contact = (Enum.TryParse<PlayerData.EPhoneContacts>(((UnlockContactEventData)eventData).Contact, out var contact) ? contact : PlayerData.EPhoneContacts.None);
	}

	public override void Update(GameTime gameTime)
	{
		base.IsCompleted = true;
	}
}
