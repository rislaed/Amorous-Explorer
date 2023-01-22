using System;
using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class _RXkY1nA34kgK019S1RLCVdAAPPD : _5EDaN9V3lc2jRRTcL6GvzBbV7kU<DisableContactEventData>
{
	public _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts _A5GfNJXqRoYNfziIY4iJDirt1y { get; private set; }

	public _RXkY1nA34kgK019S1RLCVdAAPPD(_nR8eroJOHehP0ZGyyTveo6aMTHg _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
		: base(_nR8eroJOHehP0ZGyyTveo6aMTHg_0)
	{
	}

	public override void _dCiaLpIow7UQ0MLMp2O4J0yeVfF(DisableContactEventData disableContactEventData_0)
	{
		base._dCiaLpIow7UQ0MLMp2O4J0yeVfF(disableContactEventData_0);
		_A5GfNJXqRoYNfziIY4iJDirt1y = (Enum.TryParse<_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts>(disableContactEventData_0._A5GfNJXqRoYNfziIY4iJDirt1y, out var result) ? result : _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.None);
	}

	public override void _4hlxzMzKSbVTbZUrEsP3dfw4x0h()
	{
		base._4hlxzMzKSbVTbZUrEsP3dfw4x0h();
		_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t()._Qd7anWdHpZ5AgaUbbEv07BnnI6Q(_A5GfNJXqRoYNfziIY4iJDirt1y);
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime)
	{
		base._xJZUPxDatEzfPQc0nRHR2D1Vwke = true;
	}
}
