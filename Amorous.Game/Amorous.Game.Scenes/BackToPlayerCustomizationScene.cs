using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Squid;

namespace Amorous.Game.Scenes;

public class BackToPlayerCustomizationScene : PlayerCustomizationScene
{
	private bool _e1Kru66UIN1SkWkBreRDCF5RsWA;

	string PlayerCustomizationScene._l3SUNsFudHnZpYO0ErWgbTaz1DF => "Back to Club";

	public BackToPlayerCustomizationScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		_jIGpzoYLVPw8SPxmJcha832nCXR = true;
		_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = false;
	}

	protected override void _hI8MfcRDpV9Q45afjBJe8lA5sbr()
	{
	}

	protected override void _n3b8BstkorCsu4TW0U2YVdFbdGp()
	{
		BackToPlayerCustomizationScene.smethod_55(BackToPlayerCustomizationScene.smethod_54((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "Are you sure this how you want to look in the game?", new string[2] { "Oops, my bad!", "Yes please!" }, 250, (Action<int>)delegate(int int_0)
		{
			if (int_0 == 1)
			{
				BackToPlayerCustomizationScene.smethod_60(BackToPlayerCustomizationScene.smethod_59(BackToPlayerCustomizationScene.smethod_56((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), "AchievementGeneric1");
				BackToPlayerCustomizationScene.smethod_62(BackToPlayerCustomizationScene.smethod_61(), "Gender", 10);
				BackToPlayerCustomizationScene.smethod_63(BackToPlayerCustomizationScene.smethod_61(), "Player.Gender", bool_0: true);
				BackToPlayerCustomizationScene.smethod_63(BackToPlayerCustomizationScene.smethod_61(), "Player.No", bool_0: true);
				BackToPlayerCustomizationScene.smethod_64(BackToPlayerCustomizationScene.smethod_56((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "Gender");
				_e1Kru66UIN1SkWkBreRDCF5RsWA = true;
			}
		});
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		this.method_0(gameTime_0);
		if (_e1Kru66UIN1SkWkBreRDCF5RsWA && !BackToPlayerCustomizationScene.smethod_57(BackToPlayerCustomizationScene.smethod_56((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)) && BackToPlayerCustomizationScene.smethod_58(BackToPlayerCustomizationScene.smethod_56((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)) == null)
		{
			_e1Kru66UIN1SkWkBreRDCF5RsWA = false;
			_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = true;
			_poenyHBGUusBcnNcTFB9MQBV72R._AZrO8MxMUE7cKsFYTQ4k9O3q7yC()._Xrfjrxr72hHh4bDdQB7HzEbJUCb();
			BackToPlayerCustomizationScene.smethod_56((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._k9wUPeU1Ga7cygiuGP8TT6aPLWF<ClubEntranceScene>();
		}
	}

	[CompilerGenerated]
	private void _fTIM8HHDf1dAB7gLwN34Fjcjf0qA(int int_0)
	{
		if (int_0 == 1)
		{
			BackToPlayerCustomizationScene.smethod_60(BackToPlayerCustomizationScene.smethod_59(BackToPlayerCustomizationScene.smethod_56((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), "AchievementGeneric1");
			BackToPlayerCustomizationScene.smethod_62(BackToPlayerCustomizationScene.smethod_61(), "Gender", 10);
			BackToPlayerCustomizationScene.smethod_63(BackToPlayerCustomizationScene.smethod_61(), "Player.Gender", bool_0: true);
			BackToPlayerCustomizationScene.smethod_63(BackToPlayerCustomizationScene.smethod_61(), "Player.No", bool_0: true);
			BackToPlayerCustomizationScene.smethod_64(BackToPlayerCustomizationScene.smethod_56((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "Gender");
			_e1Kru66UIN1SkWkBreRDCF5RsWA = true;
		}
	}

	static Desktop smethod_54(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._PnkAlVnMv0SZvRBFexqzE5DF9tp;
	}

	static void smethod_55(Desktop desktop_0, string string_0, string[] string_1, int int_0, Action<int> action_0)
	{
		desktop_0._GtkWDtXwQHwgWY4aFkacjfUDyzb(string_0, string_1, int_0, action_0);
	}

	void method_0(GameTime gameTime_0)
	{
		base._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
	}

	static _JbeCmOie0phb2cbgG6DdGZrbs3pB smethod_56(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._ZzBuoSDMWwerejOO9Goyv2OCKgE;
	}

	static bool smethod_57(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._NdzU0m9x8QDKpVv3DrQmzY5KduB;
	}

	static _nR8eroJOHehP0ZGyyTveo6aMTHg smethod_58(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._5zNdOw7qHmuCAPJFMr3SsZdBlCr;
	}

	static _691ooXdgg17CWFkMkjedKBBBfYw smethod_59(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._aJh9CibG5YKhkExxgRyVopdfSeJ;
	}

	static void smethod_60(_691ooXdgg17CWFkMkjedKBBBfYw _691ooXdgg17CWFkMkjedKBBBfYw_0, string string_0)
	{
		_691ooXdgg17CWFkMkjedKBBBfYw_0._vVZVLriSGPExpn1KeobglMabsoi(string_0);
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG smethod_61()
	{
		return _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
	}

	static void smethod_62(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0, string string_0, int int_0)
	{
		_opIJo2jLUqdOL5yAFP4yzXce0DG_0._fPyIv5zbbSj5sjZlbAwQTFXnJ5G(string_0, int_0);
	}

	static void smethod_63(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0, string string_0, bool bool_0)
	{
		_opIJo2jLUqdOL5yAFP4yzXce0DG_0._aedbmRW9PZZduyLA3PVVHtafNAGA(string_0, bool_0);
	}

	static void smethod_64(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, string string_0)
	{
		_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._xyl3Tv5KdR5eezDgagxbBcS3cwt(string_0);
	}
}
