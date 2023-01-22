using System;
using Microsoft.Xna.Framework;

namespace Amorous.Game.Scenes;

public class BedroomScene : TimeOfDayScene
{
	private readonly _dvyBDFOZwoBLf9qqHSfHYLLXVwP _phoneNag;

	public BedroomScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		BedroomScene.smethod_18((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Bedroom/Bedroom", -458, 0);
		BedroomScene.smethod_19((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Bedroom/Door", 1008, 186, (Action)OnDoorClick);
		if (BedroomScene.smethod_21(BedroomScene.smethod_20(), "Prologue") >= 40)
		{
			BedroomScene.smethod_19((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Bedroom/Closet", 1551, 112, (Action)OnClosetClick);
		}
		else
		{
			BedroomScene.smethod_22((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Bedroom/Closet", 1551, 112, "Assets/Scenes/Bedroom/Closet active", 1517, 102, "Most of his clothes have been taken to his boyfriend's house. I can still see his ass hugging swim trunks that I'm pretty sure were designed for girls, and a dress for, well... he liked to wear a dress at one point. I don't judge.");
		}
		BedroomScene.smethod_22((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Bedroom/Matress", -446, 447, (string)null, 0, 0, "My brother's bed. The springs are a little worn out but otherwise still leagues better than mine. If you're wondering why I'm sleeping here, it's for a fresher perspective. Everytime I look over at his corner of the bedroom from mine, I just think of them going at it.");
		BedroomScene.smethod_22((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Bedroom/Photo frame", 496, 156, (string)null, 0, 0, "Thats Coby's Australian boyfriend Marty. Apparently he is making plans to visit sometime. I guess he understands my brother can't keep his pants on for that long.");
		BedroomScene.smethod_22((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Bedroom/Poster", 96, 217, (string)null, 0, 0, "Coby's still got the hots for Marsupials after meeting his penpal. Apparently he was the thunder down under and then some.");
		BedroomScene.smethod_22((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Bedroom/Con badges", 410, 310, (string)null, 0, 0, "Badges Coby has collected from going to cons.");
		BedroomScene.smethod_22((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Bedroom/Alarm clock", 672, 493, "Assets/Scenes/Bedroom/Alarm clock active", 672, 493, "Never something I used often myself, but it's been at least getting me up before noon.");
		if (!BedroomScene.smethod_23())
		{
			BedroomScene.smethod_22((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Bedroom/Drawer", 531, 568, "Assets/Scenes/Bedroom/Drawer active", 454, 538, "It's a struggle just to get this thing open. Always keeping the emergency supply at arms' reach I guess.");
		}
		BedroomScene.smethod_22((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Bedroom/Kangaroo Plush", 359, 159, (string)null, 0, 0, "A little something my brother bought as a reminder of his long-distance boyfriend. It must be a pretty open relationship.");
		BedroomScene.smethod_22((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Bedroom/Laptop", 1153, 662, (string)null, 0, 0, "My entertainment centre for the last few weeks.");
		BedroomScene.smethod_25(BedroomScene.smethod_24(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0), -458, 458, 0, 0);
		BedroomScene.smethod_26("Assets/Music/DanMasterFlash - Sun Funk", 0.4f);
		_phoneNag = new _dvyBDFOZwoBLf9qqHSfHYLLXVwP(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0);
		Reset();
	}

	private void Reset()
	{
		if (BedroomScene.smethod_21(BedroomScene.smethod_20(), "Prologue") == 40)
		{
			BedroomScene.smethod_29(BedroomScene.smethod_28(BedroomScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), "MessageTutorial1");
		}
		ResetFailedDates();
		ResetDeletedContacts();
	}

	public override void StopCutscene()
	{
		Reset();
	}

	public void ResetFailedDates()
	{
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG_ = BedroomScene.smethod_20();
		if (BedroomScene.smethod_21(opIJo2jLUqdOL5yAFP4yzXce0DG_, "Prologue") == 30 && BedroomScene.smethod_21(opIJo2jLUqdOL5yAFP4yzXce0DG_, "LexDate") == 40)
		{
			BedroomScene.smethod_30(opIJo2jLUqdOL5yAFP4yzXce0DG_, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Coby);
			BedroomScene.smethod_31(opIJo2jLUqdOL5yAFP4yzXce0DG_, "Prologue", 40);
			BedroomScene.smethod_32(opIJo2jLUqdOL5yAFP4yzXce0DG_, "CobyLeftClub", bool_0: true);
			BedroomScene.smethod_33(BedroomScene.smethod_28(BedroomScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Coby);
			BedroomScene.smethod_34(BedroomScene.smethod_28(BedroomScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), "AchievementGeneric4");
		}
		if (BedroomScene.smethod_35(opIJo2jLUqdOL5yAFP4yzXce0DG_, "LexLeftClub") && (BedroomScene.smethod_21(opIJo2jLUqdOL5yAFP4yzXce0DG_, "LexPreDate") == 20 || BedroomScene.smethod_21(opIJo2jLUqdOL5yAFP4yzXce0DG_, "LexDate") == 40))
		{
			BedroomScene.smethod_36(opIJo2jLUqdOL5yAFP4yzXce0DG_, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Lex);
		}
		if (BedroomScene.smethod_35(opIJo2jLUqdOL5yAFP4yzXce0DG_, "RemyLeftClub") && BedroomScene.smethod_21(opIJo2jLUqdOL5yAFP4yzXce0DG_, "RemyPreDate") == 10)
		{
			BedroomScene.smethod_36(opIJo2jLUqdOL5yAFP4yzXce0DG_, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Remy);
		}
		if (BedroomScene.smethod_35(opIJo2jLUqdOL5yAFP4yzXce0DG_, "SethLeftClub") && BedroomScene.smethod_21(opIJo2jLUqdOL5yAFP4yzXce0DG_, "SethPreDate") == 10)
		{
			BedroomScene.smethod_36(opIJo2jLUqdOL5yAFP4yzXce0DG_, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Seth);
		}
		if (BedroomScene.smethod_35(opIJo2jLUqdOL5yAFP4yzXce0DG_, "SkyeLeftClub") && BedroomScene.smethod_21(opIJo2jLUqdOL5yAFP4yzXce0DG_, "SkyePreDate") == 10)
		{
			BedroomScene.smethod_36(opIJo2jLUqdOL5yAFP4yzXce0DG_, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Skye);
		}
		if (BedroomScene.smethod_35(opIJo2jLUqdOL5yAFP4yzXce0DG_, "ZenithLeftClub") && BedroomScene.smethod_21(opIJo2jLUqdOL5yAFP4yzXce0DG_, "ZenithDate") == 10)
		{
			BedroomScene.smethod_36(opIJo2jLUqdOL5yAFP4yzXce0DG_, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Zenith);
		}
	}

	private void ResetDeletedContacts()
	{
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG_ = BedroomScene.smethod_20();
		if (BedroomScene.smethod_38((Enum)BedroomScene.smethod_37(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Coby))
		{
			BedroomScene.smethod_31(opIJo2jLUqdOL5yAFP4yzXce0DG_, "CobyDate", 10);
			BedroomScene.smethod_39(opIJo2jLUqdOL5yAFP4yzXce0DG_, "Coby", bool_0: true);
			BedroomScene.smethod_30(opIJo2jLUqdOL5yAFP4yzXce0DG_, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Coby);
		}
		if (BedroomScene.smethod_38((Enum)BedroomScene.smethod_37(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Dustin))
		{
			BedroomScene.smethod_31(opIJo2jLUqdOL5yAFP4yzXce0DG_, "DustinDate", 10);
			BedroomScene.smethod_39(opIJo2jLUqdOL5yAFP4yzXce0DG_, "Dustin", bool_0: true);
			BedroomScene.smethod_39(opIJo2jLUqdOL5yAFP4yzXce0DG_, "Club_Dustin_", bool_0: true);
			BedroomScene.smethod_39(opIJo2jLUqdOL5yAFP4yzXce0DG_, "First_Dustin_", bool_0: true);
		}
		if (BedroomScene.smethod_38((Enum)BedroomScene.smethod_37(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Jax))
		{
			BedroomScene.smethod_31(opIJo2jLUqdOL5yAFP4yzXce0DG_, "JaxPreDate", 10);
			BedroomScene.smethod_31(opIJo2jLUqdOL5yAFP4yzXce0DG_, "JaxDate", 10);
			BedroomScene.smethod_39(opIJo2jLUqdOL5yAFP4yzXce0DG_, "Jax", bool_0: true);
			BedroomScene.smethod_39(opIJo2jLUqdOL5yAFP4yzXce0DG_, "SimpleOrder", bool_0: false);
		}
		if (BedroomScene.smethod_38((Enum)BedroomScene.smethod_37(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Lex))
		{
			BedroomScene.smethod_31(opIJo2jLUqdOL5yAFP4yzXce0DG_, "LexPreDate", 10);
			BedroomScene.smethod_31(opIJo2jLUqdOL5yAFP4yzXce0DG_, "LexDate", 10);
			BedroomScene.smethod_39(opIJo2jLUqdOL5yAFP4yzXce0DG_, "Lex", bool_0: true);
			BedroomScene.smethod_39(opIJo2jLUqdOL5yAFP4yzXce0DG_, "Player.Dork", bool_0: false);
		}
		if (BedroomScene.smethod_38((Enum)BedroomScene.smethod_37(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Mercy))
		{
			BedroomScene.smethod_31(opIJo2jLUqdOL5yAFP4yzXce0DG_, "MercyPreDate", 10);
			BedroomScene.smethod_31(opIJo2jLUqdOL5yAFP4yzXce0DG_, "MercyDate", 10);
			BedroomScene.smethod_39(opIJo2jLUqdOL5yAFP4yzXce0DG_, "Mercy", bool_0: true);
		}
		if (BedroomScene.smethod_38((Enum)BedroomScene.smethod_37(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Remy))
		{
			BedroomScene.smethod_31(opIJo2jLUqdOL5yAFP4yzXce0DG_, "RemyPreDate", 10);
			BedroomScene.smethod_31(opIJo2jLUqdOL5yAFP4yzXce0DG_, "RemyDate", 10);
			BedroomScene.smethod_39(opIJo2jLUqdOL5yAFP4yzXce0DG_, "Remy", bool_0: true);
			BedroomScene.smethod_39(opIJo2jLUqdOL5yAFP4yzXce0DG_, "Rip.", bool_0: true);
			BedroomScene.smethod_39(opIJo2jLUqdOL5yAFP4yzXce0DG_, "Chef.", bool_0: true);
			BedroomScene.smethod_39(opIJo2jLUqdOL5yAFP4yzXce0DG_, "Strip.", bool_0: true);
		}
		if (BedroomScene.smethod_38((Enum)BedroomScene.smethod_37(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Seth))
		{
			BedroomScene.smethod_31(opIJo2jLUqdOL5yAFP4yzXce0DG_, "SethPreDate", 10);
			BedroomScene.smethod_31(opIJo2jLUqdOL5yAFP4yzXce0DG_, "SethDate", 10);
			BedroomScene.smethod_39(opIJo2jLUqdOL5yAFP4yzXce0DG_, "Seth", bool_0: true);
		}
		if (BedroomScene.smethod_38((Enum)BedroomScene.smethod_37(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Skye))
		{
			BedroomScene.smethod_31(opIJo2jLUqdOL5yAFP4yzXce0DG_, "SkyePreDate", 10);
			BedroomScene.smethod_31(opIJo2jLUqdOL5yAFP4yzXce0DG_, "SkyeDate", 10);
			BedroomScene.smethod_39(opIJo2jLUqdOL5yAFP4yzXce0DG_, "Skye", bool_0: true);
		}
		if (BedroomScene.smethod_38((Enum)BedroomScene.smethod_37(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Zenith))
		{
			BedroomScene.smethod_31(opIJo2jLUqdOL5yAFP4yzXce0DG_, "ZenithPreDate", 10);
			BedroomScene.smethod_31(opIJo2jLUqdOL5yAFP4yzXce0DG_, "ZenithDate", 10);
			BedroomScene.smethod_39(opIJo2jLUqdOL5yAFP4yzXce0DG_, "Zenith", bool_0: true);
		}
		BedroomScene.smethod_40(opIJo2jLUqdOL5yAFP4yzXce0DG_);
	}

	public override void Update(GameTime gameTime)
	{
		_tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime);
		_phoneNag._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime);
	}

	public override void End()
	{
		this.method_3();
		_phoneNag._tO46aYSBLFIuhFNlhbrAeWbFDSf();
	}

	private void OnClosetClick()
	{
		BedroomScene.smethod_41(BedroomScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "Clothes");
	}

	private void OnDoorClick()
	{
		if (BedroomScene.smethod_21(BedroomScene.smethod_20(), "Prologue") >= 40)
		{
			BedroomScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._k9wUPeU1Ga7cygiuGP8TT6aPLWF<LivingRoomScene>();
		}
		else
		{
			BedroomScene.smethod_41(BedroomScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "Prologue");
		}
	}

	static _uqydQVaCmCvK7zzWs5W4gZFpKBu smethod_18(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._0O8D0mBgmrh0sLOGcLVvGNOHKLCA(string_0, string_1, int_0, int_1);
	}

	static _z20t8IpBINiJtljSeTIkNoKUOkx smethod_19(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1, Action action_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._2CHUZ5vSi5NbJYJ4gGtr3C2VVEo(string_0, string_1, int_0, int_1, action_0);
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG smethod_20()
	{
		return _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
	}

	static int smethod_21(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0, string string_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._fvTKDuNATrUxfXZVvltePz3vYkK(string_0);
	}

	static _x1wxbalqqw8qtEqHC1UaGdv59Od smethod_22(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1, string string_2, int int_2, int int_3, string string_3)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._2VwdavpaoNVxohFKsz1eYBmnxyh(string_0, string_1, int_0, int_1, string_2, int_2, int_3, string_3);
	}

	static bool smethod_23()
	{
		return _iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF;
	}

	static _wRd4nHuQQlAPEwrHOGkBfut6Uip smethod_24(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._vsceSzSIjBy2nZrCxAzKZbUiwLq;
	}

	static void smethod_25(_wRd4nHuQQlAPEwrHOGkBfut6Uip _wRd4nHuQQlAPEwrHOGkBfut6Uip_0, int int_0, int int_1, int int_2, int int_3)
	{
		_wRd4nHuQQlAPEwrHOGkBfut6Uip_0._wFfc7xL7eKxed7i9gWtao7pgsnm(int_0, int_1, int_2, int_3);
	}

	static void smethod_26(string string_0, float float_0)
	{
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc(string_0, float_0);
	}

	static _JbeCmOie0phb2cbgG6DdGZrbs3pB smethod_27(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._ZzBuoSDMWwerejOO9Goyv2OCKgE;
	}

	static _691ooXdgg17CWFkMkjedKBBBfYw smethod_28(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._aJh9CibG5YKhkExxgRyVopdfSeJ;
	}

	static void smethod_29(_691ooXdgg17CWFkMkjedKBBBfYw _691ooXdgg17CWFkMkjedKBBBfYw_0, string string_0)
	{
		_691ooXdgg17CWFkMkjedKBBBfYw_0._0Y1BTbSbP9IopfJXfeA4x02PifL(string_0);
	}

	static void smethod_30(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts ephoneContacts_0)
	{
		_opIJo2jLUqdOL5yAFP4yzXce0DG_0._modEEaw3I1w8Mt0usyRNoa4Ri0H(ephoneContacts_0);
	}

	static void smethod_31(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0, string string_0, int int_0)
	{
		_opIJo2jLUqdOL5yAFP4yzXce0DG_0._fPyIv5zbbSj5sjZlbAwQTFXnJ5G(string_0, int_0);
	}

	static void smethod_32(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0, string string_0, bool bool_0)
	{
		_opIJo2jLUqdOL5yAFP4yzXce0DG_0._4Fscz8ryB3hm0NmL5xw39HHiPd1(string_0, bool_0);
	}

	static void smethod_33(_691ooXdgg17CWFkMkjedKBBBfYw _691ooXdgg17CWFkMkjedKBBBfYw_0, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts ephoneContacts_0)
	{
		_691ooXdgg17CWFkMkjedKBBBfYw_0._rGMDL1kMYXSwaZiIoINCo5AqZuM(ephoneContacts_0);
	}

	static void smethod_34(_691ooXdgg17CWFkMkjedKBBBfYw _691ooXdgg17CWFkMkjedKBBBfYw_0, string string_0)
	{
		_691ooXdgg17CWFkMkjedKBBBfYw_0._vVZVLriSGPExpn1KeobglMabsoi(string_0);
	}

	static bool smethod_35(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0, string string_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Oms9lumBodLGrGZ09YJaEuzmlAf(string_0);
	}

	static void smethod_36(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts ephoneContacts_0)
	{
		_opIJo2jLUqdOL5yAFP4yzXce0DG_0._Qd7anWdHpZ5AgaUbbEv07BnnI6Q(ephoneContacts_0);
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts smethod_37(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._uVBbxOT5AbKoffINIsfdTnEGd3xA;
	}

	static bool smethod_38(Enum enum_0, Enum enum_1)
	{
		return enum_0.HasFlag(enum_1);
	}

	static void smethod_39(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0, string string_0, bool bool_0)
	{
		_opIJo2jLUqdOL5yAFP4yzXce0DG_0._aedbmRW9PZZduyLA3PVVHtafNAGA(string_0, bool_0);
	}

	static void smethod_40(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		_opIJo2jLUqdOL5yAFP4yzXce0DG_0._Xwcp3PcmrSeqc3MSVH0tfLbcwXA();
	}

	void method_3()
	{
		base._tO46aYSBLFIuhFNlhbrAeWbFDSf();
	}

	static void smethod_41(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, string string_0)
	{
		_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._xyl3Tv5KdR5eezDgagxbBcS3cwt(string_0);
	}
}
