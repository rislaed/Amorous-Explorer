using System;
using Amorous.Game.NPC;

namespace Amorous.Game.Scenes;

public class ClubBackScene : _7UlnfykmEmZDFt3BmCKZekI43Ih
{
	private ClubStaticLexNPC _lex;

	private readonly bool _showLex;

	public ClubBackScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		ClubBackScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/ClubBack/Club back main", -535, 0);
		ClubBackScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/ClubBack/Club back bodies", 1313, 486);
		if (!ClubBackScene.smethod_15())
		{
			ClubBackScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/ClubBack/Club back shirts", 1313, 486);
		}
		if (!ClubBackScene.smethod_16())
		{
			ClubBackScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/ClubBack/Club back pants", 1313, 486);
		}
		ClubBackScene.smethod_17((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Door", "Assets/Scenes/ClubBack/Door to lounge selectable", -217, 120, (Action)OnDoorClick);
		ClubBackScene.smethod_17((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Side", "Assets/Scenes/ClubBack/Front of Club Selectable", 608, 0, (Action)OnClubFrontClick);
		ClubBackScene.smethod_18((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Fan", "Assets/Scenes/ClubBack/Fan", 524, 75, 10f, 68, 75);
		ClubBackScene.smethod_20(ClubBackScene.smethod_19(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0), -535, 535, 0, 0);
		ClubBackScene.smethod_21(_KZ7hNP1K5E99Xfup1lTZ9UDrxPE._oCy13KHJxLHriH7TwMiQ1qKJ8Uc, 0.4f, bool_0: true, bool_1: true);
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG_ = ClubBackScene.smethod_22();
		_showLex = !ClubBackScene.smethod_23(opIJo2jLUqdOL5yAFP4yzXce0DG_, "LexLeftClub");
	}

	public override void Start()
	{
		if (_showLex)
		{
			_lex = ClubBackScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubStaticLexNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
			ClubBackScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_lex, -535f);
			ClubBackScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_lex, 250f);
			ClubBackScene.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_lex, (Action)OnLexClick);
		}
	}

	private void OnDoorClick()
	{
		ClubBackScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._k9wUPeU1Ga7cygiuGP8TT6aPLWF<ClubLoungeScene>();
	}

	private void OnClubFrontClick()
	{
		ClubBackScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._k9wUPeU1Ga7cygiuGP8TT6aPLWF<ClubEntranceScene>();
	}

	private void OnLexClick()
	{
		ClubBackScene.smethod_28(ClubBackScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "LexPreDate");
	}

	static _uqydQVaCmCvK7zzWs5W4gZFpKBu smethod_14(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._0O8D0mBgmrh0sLOGcLVvGNOHKLCA(string_0, string_1, int_0, int_1);
	}

	static bool smethod_15()
	{
		return _iExD93IWLlzVfXsU9wyrEvWgJsg._b52DDz3MN1kD8sgdQhCNO1tJRNn;
	}

	static bool smethod_16()
	{
		return _iExD93IWLlzVfXsU9wyrEvWgJsg._pKBiGAgDu5WqoykkGBaEGnP7oMj;
	}

	static _z20t8IpBINiJtljSeTIkNoKUOkx smethod_17(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1, Action action_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._2CHUZ5vSi5NbJYJ4gGtr3C2VVEo(string_0, string_1, int_0, int_1, action_0);
	}

	static _C9DhEciuJHkReX4htI9sP6cbqzF smethod_18(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1, float float_0, int int_2, int int_3)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._t1wBwPCrsAvA30GB26t9oLVcGfU(string_0, string_1, int_0, int_1, float_0, int_2, int_3);
	}

	static _wRd4nHuQQlAPEwrHOGkBfut6Uip smethod_19(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._vsceSzSIjBy2nZrCxAzKZbUiwLq;
	}

	static void smethod_20(_wRd4nHuQQlAPEwrHOGkBfut6Uip _wRd4nHuQQlAPEwrHOGkBfut6Uip_0, int int_0, int int_1, int int_2, int int_3)
	{
		_wRd4nHuQQlAPEwrHOGkBfut6Uip_0._wFfc7xL7eKxed7i9gWtao7pgsnm(int_0, int_1, int_2, int_3);
	}

	static void smethod_21(string[] string_0, float float_0, bool bool_0, bool bool_1)
	{
		_UmxbIbk7pgaod0bD7pS309P3Lns._QrgbXEg7MMeD9Ybz12fFVsbmAd9(string_0, float_0, bool_0, bool_1);
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG smethod_22()
	{
		return _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
	}

	static bool smethod_23(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0, string string_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Oms9lumBodLGrGZ09YJaEuzmlAf(string_0);
	}

	static _JbeCmOie0phb2cbgG6DdGZrbs3pB smethod_24(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._ZzBuoSDMWwerejOO9Goyv2OCKgE;
	}

	static void smethod_25(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_26(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}

	static void smethod_27(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, Action action_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._ZVpZ5Oing5kbbVhbmbOHyrofGH7 = action_0;
	}

	static void smethod_28(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, string string_0)
	{
		_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._xyl3Tv5KdR5eezDgagxbBcS3cwt(string_0);
	}
}
