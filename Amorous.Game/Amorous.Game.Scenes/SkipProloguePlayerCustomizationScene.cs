using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Squid;

namespace Amorous.Game.Scenes;

public class SkipProloguePlayerCustomizationScene : PlayerCustomizationScene
{
	private bool _e1Kru66UIN1SkWkBreRDCF5RsWA;

	string PlayerCustomizationScene._l3SUNsFudHnZpYO0ErWgbTaz1DF => "Back to Club";

	public SkipProloguePlayerCustomizationScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		_jIGpzoYLVPw8SPxmJcha832nCXR = true;
	}

	protected override void _n3b8BstkorCsu4TW0U2YVdFbdGp()
	{
		base._PnkAlVnMv0SZvRBFexqzE5DF9tp._GtkWDtXwQHwgWY4aFkacjfUDyzb("Are you sure this how you want to look in the game?", new string[2] { "Oops, my bad!", "Yes please!" }, 250, delegate(int int_0)
		{
			if (int_0 == 1)
			{
				base._ZzBuoSDMWwerejOO9Goyv2OCKgE._aJh9CibG5YKhkExxgRyVopdfSeJ._vVZVLriSGPExpn1KeobglMabsoi("AchievementGeneric1");
				base._ZzBuoSDMWwerejOO9Goyv2OCKgE._xyl3Tv5KdR5eezDgagxbBcS3cwt("Gender");
				_e1Kru66UIN1SkWkBreRDCF5RsWA = true;
			}
		});
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		base._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
		if (_e1Kru66UIN1SkWkBreRDCF5RsWA && !base._ZzBuoSDMWwerejOO9Goyv2OCKgE._NdzU0m9x8QDKpVv3DrQmzY5KduB && base._ZzBuoSDMWwerejOO9Goyv2OCKgE._5zNdOw7qHmuCAPJFMr3SsZdBlCr == null)
		{
			_e1Kru66UIN1SkWkBreRDCF5RsWA = false;
			_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
			opIJo2jLUqdOL5yAFP4yzXce0DG._modEEaw3I1w8Mt0usyRNoa4Ri0H(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Coby);
			opIJo2jLUqdOL5yAFP4yzXce0DG._fPyIv5zbbSj5sjZlbAwQTFXnJ5G("Prologue", 40);
			opIJo2jLUqdOL5yAFP4yzXce0DG._4Fscz8ryB3hm0NmL5xw39HHiPd1("CobyLeftClub", bool_0: true);
			_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = true;
			_poenyHBGUusBcnNcTFB9MQBV72R._AZrO8MxMUE7cKsFYTQ4k9O3q7yC()._Xrfjrxr72hHh4bDdQB7HzEbJUCb();
			base._ZzBuoSDMWwerejOO9Goyv2OCKgE._aJh9CibG5YKhkExxgRyVopdfSeJ._rGMDL1kMYXSwaZiIoINCo5AqZuM(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Coby);
			base._ZzBuoSDMWwerejOO9Goyv2OCKgE._aJh9CibG5YKhkExxgRyVopdfSeJ._vVZVLriSGPExpn1KeobglMabsoi("AchievementGeneric4");
			base._ZzBuoSDMWwerejOO9Goyv2OCKgE._k9wUPeU1Ga7cygiuGP8TT6aPLWF<ClubEntranceScene>();
		}
	}

	[CompilerGenerated]
	private void _uT0nhPqOYeKCBWg0fkE9TeKYm4l(int int_0)
	{
		if (int_0 == 1)
		{
			base._ZzBuoSDMWwerejOO9Goyv2OCKgE._aJh9CibG5YKhkExxgRyVopdfSeJ._vVZVLriSGPExpn1KeobglMabsoi("AchievementGeneric1");
			base._ZzBuoSDMWwerejOO9Goyv2OCKgE._xyl3Tv5KdR5eezDgagxbBcS3cwt("Gender");
			_e1Kru66UIN1SkWkBreRDCF5RsWA = true;
		}
	}
}
