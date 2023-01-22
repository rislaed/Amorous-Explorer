using System;
using System.Runtime.CompilerServices;
using Squid;

namespace Amorous.Game.Scenes;

public class ProloguePlayerCustomizationScene : PlayerCustomizationScene
{
	string PlayerCustomizationScene._l3SUNsFudHnZpYO0ErWgbTaz1DF => "Back to Prologue";

	public ProloguePlayerCustomizationScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
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
				_poenyHBGUusBcnNcTFB9MQBV72R._AZrO8MxMUE7cKsFYTQ4k9O3q7yC()._Xrfjrxr72hHh4bDdQB7HzEbJUCb();
				base._ZzBuoSDMWwerejOO9Goyv2OCKgE._aJh9CibG5YKhkExxgRyVopdfSeJ._vVZVLriSGPExpn1KeobglMabsoi("AchievementGeneric1");
				base._ZzBuoSDMWwerejOO9Goyv2OCKgE._xyl3Tv5KdR5eezDgagxbBcS3cwt("Prologue");
			}
		});
	}

	[CompilerGenerated]
	private void _HmcC92wrccEn9iOEGKt7s7lfxJx(int int_0)
	{
		if (int_0 == 1)
		{
			_poenyHBGUusBcnNcTFB9MQBV72R._AZrO8MxMUE7cKsFYTQ4k9O3q7yC()._Xrfjrxr72hHh4bDdQB7HzEbJUCb();
			base._ZzBuoSDMWwerejOO9Goyv2OCKgE._aJh9CibG5YKhkExxgRyVopdfSeJ._vVZVLriSGPExpn1KeobglMabsoi("AchievementGeneric1");
			base._ZzBuoSDMWwerejOO9Goyv2OCKgE._xyl3Tv5KdR5eezDgagxbBcS3cwt("Prologue");
		}
	}
}
