using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Squid;

namespace Amorous.Game.Scenes;

public class BackToPlayerCustomizationScene : PlayerCustomizationScene
{
	private bool _e1Kru66UIN1SkWkBreRDCF5RsWA;

	string PlayerCustomizationScene._l3SUNsFudHnZpYO0ErWgbTaz1DF => "Back to Club";

	public BackToPlayerCustomizationScene(IAmorous game)
		: base(Game)
	{
		_jIGpzoYLVPw8SPxmJcha832nCXR = true;
		_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = false;
	}

	protected override void _hI8MfcRDpV9Q45afjBJe8lA5sbr()
	{
	}

	protected override void _n3b8BstkorCsu4TW0U2YVdFbdGp()
	{
		base._PnkAlVnMv0SZvRBFexqzE5DF9tp.ShowSelection("Are you sure this how you want to look in the Game?", new string[2] { "Oops, my bad!", "Yes please!" }, 250, delegate(int int_0)
		{
			if (int_0 == 1)
			{
				base.Game._aJh9CibG5YKhkExxgRyVopdfSeJ._vVZVLriSGPExpn1KeobglMabsoi("AchievementGeneric1");
				_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t().SetDecimal("Gender", 10);
				_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t().Remove("Player.Gender");
				_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t().Remove("Player.No");
				base.Game.RequestScene("Gender");
				_e1Kru66UIN1SkWkBreRDCF5RsWA = true;
			}
		});
	}

	public override void Update(GameTime gameTime_0)
	{
		base.Update(gameTime_0);
		if (_e1Kru66UIN1SkWkBreRDCF5RsWA && !base.Game._NdzU0m9x8QDKpVv3DrQmzY5KduB && base.Game._5zNdOw7qHmuCAPJFMr3SsZdBlCr == null)
		{
			_e1Kru66UIN1SkWkBreRDCF5RsWA = false;
			_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = true;
			_poenyHBGUusBcnNcTFB9MQBV72R._AZrO8MxMUE7cKsFYTQ4k9O3q7yC()._Xrfjrxr72hHh4bDdQB7HzEbJUCb();
			base.Game.StartScene<ClubEntranceScene>();
		}
	}
}
