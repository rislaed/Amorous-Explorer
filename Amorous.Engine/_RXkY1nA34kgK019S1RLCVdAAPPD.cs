using System;
using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class _RXkY1nA34kgK019S1RLCVdAAPPD : AbstractEvent<DisableContactEventData>
{
	public PlayerData.EPhoneContacts Contact { get; private set; }

	public _RXkY1nA34kgK019S1RLCVdAAPPD(_nR8eroJOHehP0ZGyyTveo6aMTHg _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
		: base(_nR8eroJOHehP0ZGyyTveo6aMTHg_0)
	{
	}

	public override void SetData(DisableContactEventData disableContactEventData_0)
	{
		base.SetData(disableContactEventData_0);
		Contact = (Enum.TryParse<PlayerData.EPhoneContacts>(disableContactEventData_0.Contact, out var result) ? result : PlayerData.EPhoneContacts.None);
	}

	public override void _4hlxzMzKSbVTbZUrEsP3dfw4x0h()
	{
		base._4hlxzMzKSbVTbZUrEsP3dfw4x0h();
		_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t().ResetContact(Contact);
	}

	public override void Update(GameTime gameTime)
	{
		base._xJZUPxDatEzfPQc0nRHR2D1Vwke = true;
	}
}
