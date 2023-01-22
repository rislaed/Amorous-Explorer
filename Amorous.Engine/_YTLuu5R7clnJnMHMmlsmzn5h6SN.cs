using System;
using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class _YTLuu5R7clnJnMHMmlsmzn5h6SN : _5EDaN9V3lc2jRRTcL6GvzBbV7kU<UnlockContactEventData>
{
	public _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts _A5GfNJXqRoYNfziIY4iJDirt1y { get; private set; }

	public _YTLuu5R7clnJnMHMmlsmzn5h6SN(_nR8eroJOHehP0ZGyyTveo6aMTHg _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
		: base(_nR8eroJOHehP0ZGyyTveo6aMTHg_0)
	{
	}

	public override void _dCiaLpIow7UQ0MLMp2O4J0yeVfF(UnlockContactEventData unlockContactEventData_0)
	{
		base._dCiaLpIow7UQ0MLMp2O4J0yeVfF(unlockContactEventData_0);
		_A5GfNJXqRoYNfziIY4iJDirt1y = (Enum.TryParse<_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts>(unlockContactEventData_0._A5GfNJXqRoYNfziIY4iJDirt1y, out var result) ? result : _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.None);
	}

	public override void _4hlxzMzKSbVTbZUrEsP3dfw4x0h()
	{
		base._4hlxzMzKSbVTbZUrEsP3dfw4x0h();
		while (true)
		{
			int num = -794898463;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9F4BC6CCu) % 3u)
				{
				case 1u:
					goto IL_0008;
				case 2u:
					break;
				default:
					base._5zNdOw7qHmuCAPJFMr3SsZdBlCr._ZzBuoSDMWwerejOO9Goyv2OCKgE._aJh9CibG5YKhkExxgRyVopdfSeJ._rGMDL1kMYXSwaZiIoINCo5AqZuM(_A5GfNJXqRoYNfziIY4iJDirt1y);
					return;
				}
				break;
				IL_0008:
				_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t()._modEEaw3I1w8Mt0usyRNoa4Ri0H(_A5GfNJXqRoYNfziIY4iJDirt1y);
				num = (int)(num2 * 1476843581) ^ -1878690831;
			}
		}
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime)
	{
		base._xJZUPxDatEzfPQc0nRHR2D1Vwke = true;
	}
}
