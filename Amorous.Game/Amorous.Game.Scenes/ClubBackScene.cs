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
		ClubBackScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, _003CModule_003E.smethod_27<string>(3171999506u), _003CModule_003E.smethod_26<string>(4021356539u), -535, 0);
		ClubBackScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, _003CModule_003E.smethod_25<string>(2395767488u), _003CModule_003E.smethod_24<string>(4181535368u), 1313, 486);
		if (!ClubBackScene.smethod_15())
		{
			ClubBackScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, _003CModule_003E.smethod_27<string>(3171999506u), _003CModule_003E.smethod_27<string>(4258926352u), 1313, 486);
		}
		if (!ClubBackScene.smethod_16())
		{
			ClubBackScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, _003CModule_003E.smethod_25<string>(2395767488u), _003CModule_003E.smethod_27<string>(4026546773u), 1313, 486);
		}
		ClubBackScene.smethod_17((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, _003CModule_003E.smethod_28<string>(1554470145u), _003CModule_003E.smethod_25<string>(1548721716u), -217, 120, (Action)OnDoorClick);
		ClubBackScene.smethod_17((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, _003CModule_003E.smethod_27<string>(3550935853u), _003CModule_003E.smethod_26<string>(3768565184u), 608, 0, (Action)OnClubFrontClick);
		ClubBackScene.smethod_18((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, _003CModule_003E.smethod_28<string>(2245770657u), _003CModule_003E.smethod_25<string>(3292021198u), 524, 75, 10f, 68, 75);
		ClubBackScene.smethod_20(ClubBackScene.smethod_19(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0), -535, 535, 0, 0);
		ClubBackScene.smethod_21(_KZ7hNP1K5E99Xfup1lTZ9UDrxPE._oCy13KHJxLHriH7TwMiQ1qKJ8Uc, 0.4f, bool_0: true, bool_1: true);
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG_ = ClubBackScene.smethod_22();
		_showLex = !ClubBackScene.smethod_23(opIJo2jLUqdOL5yAFP4yzXce0DG_, _003CModule_003E.smethod_26<string>(3356641799u));
	}

	public override void Start()
	{
		if (!_showLex)
		{
			return;
		}
		while (true)
		{
			int num = 50588526;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x776E17E8u) % 4u)
				{
				case 2u:
					_lex = ClubBackScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubStaticLexNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
					ClubBackScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_lex, -535f);
					num = (int)(num2 * 464451840) ^ -1349106803;
					continue;
				case 1u:
					ClubBackScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_lex, 250f);
					ClubBackScene.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_lex, (Action)OnLexClick);
					num = (int)((num2 * 1374661108) ^ 0x51993EAB);
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
					return;
				}
				break;
			}
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
		ClubBackScene.smethod_28(ClubBackScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), _003CModule_003E.smethod_25<string>(2344197568u));
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
