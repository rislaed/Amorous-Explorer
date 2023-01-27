using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Squid;

namespace Amorous.Game.Scenes;

public class BackToPlayerCustomizationScene : PlayerCustomizationScene
{
	private bool _e1Kru66UIN1SkWkBreRDCF5RsWA;
	override protected string ReturnToGameText => "Back to Club";

	public BackToPlayerCustomizationScene(IAmorous game)
		: base(game)
	{
		_jIGpzoYLVPw8SPxmJcha832nCXR = true;
		_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = false;
	}

	protected override void _hI8MfcRDpV9Q45afjBJe8lA5sbr()
	{
	}

	protected override void _n3b8BstkorCsu4TW0U2YVdFbdGp()
	{
		base.Squid.ShowSelection("Are you sure this how you want to look in the Game?", new string[2] { "Oops, my bad!", "Yes please!" }, 250, delegate(int int_0)
		{
			if (int_0 == 1)
			{
				base.Game._aJh9CibG5YKhkExxgRyVopdfSeJ._vVZVLriSGPExpn1KeobglMabsoi("AchievementGeneric1");
				PlayerPreferences.GetPlayerData().SetDecimal("Gender", 10);
				PlayerPreferences.GetPlayerData().Remove("Player.Gender");
				PlayerPreferences.GetPlayerData().Remove("Player.No");
				base.Game.RequestScene("Gender");
				_e1Kru66UIN1SkWkBreRDCF5RsWA = true;
			}
		});
	}

	public override void Update(GameTime gameTime)
	{
		base.Update(gameTime);
		if (_e1Kru66UIN1SkWkBreRDCF5RsWA && !base.Game._NdzU0m9x8QDKpVv3DrQmzY5KduB && base.Game._5zNdOw7qHmuCAPJFMr3SsZdBlCr == null)
		{
			_e1Kru66UIN1SkWkBreRDCF5RsWA = false;
			_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = true;
			_poenyHBGUusBcnNcTFB9MQBV72R._AZrO8MxMUE7cKsFYTQ4k9O3q7yC()._Xrfjrxr72hHh4bDdQB7HzEbJUCb();
			base.Game.StartScene<ClubEntranceScene>();
		}
	}
}
