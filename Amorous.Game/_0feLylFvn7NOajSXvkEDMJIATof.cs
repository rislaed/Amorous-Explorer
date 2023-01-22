using System;
using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public abstract class _0feLylFvn7NOajSXvkEDMJIATof<T> : _5EDaN9V3lc2jRRTcL6GvzBbV7kU<T> where T : UnlockContactEventData
{
	protected _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts _A5GfNJXqRoYNfziIY4iJDirt1y;

	protected _0feLylFvn7NOajSXvkEDMJIATof(_nR8eroJOHehP0ZGyyTveo6aMTHg _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
		: base(_nR8eroJOHehP0ZGyyTveo6aMTHg_0)
	{
	}

	public override void _dCiaLpIow7UQ0MLMp2O4J0yeVfF(T gparam_0)
	{
		base._dCiaLpIow7UQ0MLMp2O4J0yeVfF(gparam_0);
		_A5GfNJXqRoYNfziIY4iJDirt1y = (Enum.TryParse<_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts>(_0feLylFvn7NOajSXvkEDMJIATof<T>.smethod_0((UnlockContactEventData)gparam_0), out var result) ? result : _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.None);
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime)
	{
		base._xJZUPxDatEzfPQc0nRHR2D1Vwke = true;
	}

	static string smethod_0(UnlockContactEventData unlockContactEventData_0)
	{
		return unlockContactEventData_0._A5GfNJXqRoYNfziIY4iJDirt1y;
	}
}
