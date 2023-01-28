using System;
using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public abstract class _0feLylFvn7NOajSXvkEDMJIATof<T> : AbstractEvent<T> where T : UnlockContactEventData
{
	protected PlayerData.EPhoneContacts Contact;

	protected _0feLylFvn7NOajSXvkEDMJIATof(Cutscene _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
		: base(_nR8eroJOHehP0ZGyyTveo6aMTHg_0)
	{
	}

	public override void SetData(T eventData)
	{
		base.SetData(eventData);
		Contact = (Enum.TryParse<PlayerData.EPhoneContacts>(((UnlockContactEventData)eventData).Contact, out var result) ? result : PlayerData.EPhoneContacts.None);
	}

	public override void Update(GameTime gameTime)
	{
		base.Completable = true;
	}
}
