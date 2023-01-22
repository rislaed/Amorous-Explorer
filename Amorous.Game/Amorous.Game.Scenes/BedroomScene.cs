using System;
using Microsoft.Xna.Framework;

namespace Amorous.Game.Scenes;

public class BedroomScene : TimeOfDayScene
{
	private readonly _dvyBDFOZwoBLf9qqHSfHYLLXVwP _phoneNag;

	public BedroomScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Background", "Assets/Scenes/Bedroom/Bedroom", -458, 0);
		_2CHUZ5vSi5NbJYJ4gGtr3C2VVEo("Background", "Assets/Scenes/Bedroom/Door", 1008, 186, OnDoorClick);
		if (_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t()._fvTKDuNATrUxfXZVvltePz3vYkK("Prologue") >= 40)
		{
			_2CHUZ5vSi5NbJYJ4gGtr3C2VVEo("Background", "Assets/Scenes/Bedroom/Closet", 1551, 112, OnClosetClick);
		}
		else
		{
			_2VwdavpaoNVxohFKsz1eYBmnxyh("Background", "Assets/Scenes/Bedroom/Closet", 1551, 112, "Assets/Scenes/Bedroom/Closet active", 1517, 102, "Most of his clothes have been taken to his boyfriend's house. I can still see his ass hugging swim trunks that I'm pretty sure were designed for girls, and a dress for, well... he liked to wear a dress at one point. I don't judge.");
		}
		_2VwdavpaoNVxohFKsz1eYBmnxyh("Background", "Assets/Scenes/Bedroom/Matress", -446, 447, null, 0, 0, "My brother's bed. The springs are a little worn out but otherwise still leagues better than mine. If you're wondering why I'm sleeping here, it's for a fresher perspective. Everytime I look over at his corner of the bedroom from mine, I just think of them going at it.");
		_2VwdavpaoNVxohFKsz1eYBmnxyh("Background", "Assets/Scenes/Bedroom/Photo frame", 496, 156, null, 0, 0, "Thats Coby's Australian boyfriend Marty. Apparently he is making plans to visit sometime. I guess he understands my brother can't keep his pants on for that long.");
		_2VwdavpaoNVxohFKsz1eYBmnxyh("Background", "Assets/Scenes/Bedroom/Poster", 96, 217, null, 0, 0, "Coby's still got the hots for Marsupials after meeting his penpal. Apparently he was the thunder down under and then some.");
		_2VwdavpaoNVxohFKsz1eYBmnxyh("Background", "Assets/Scenes/Bedroom/Con badges", 410, 310, null, 0, 0, "Badges Coby has collected from going to cons.");
		_2VwdavpaoNVxohFKsz1eYBmnxyh("Background", "Assets/Scenes/Bedroom/Alarm clock", 672, 493, "Assets/Scenes/Bedroom/Alarm clock active", 672, 493, "Never something I used often myself, but it's been at least getting me up before noon.");
		if (!_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
		{
			_2VwdavpaoNVxohFKsz1eYBmnxyh("Background", "Assets/Scenes/Bedroom/Drawer", 531, 568, "Assets/Scenes/Bedroom/Drawer active", 454, 538, "It's a struggle just to get this thing open. Always keeping the emergency supply at arms' reach I guess.");
		}
		_2VwdavpaoNVxohFKsz1eYBmnxyh("Background", "Assets/Scenes/Bedroom/Kangaroo Plush", 359, 159, null, 0, 0, "A little something my brother bought as a reminder of his long-distance boyfriend. It must be a pretty open relationship.");
		_2VwdavpaoNVxohFKsz1eYBmnxyh("Background", "Assets/Scenes/Bedroom/Laptop", 1153, 662, null, 0, 0, "My entertainment centre for the last few weeks.");
		_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._vsceSzSIjBy2nZrCxAzKZbUiwLq._wFfc7xL7eKxed7i9gWtao7pgsnm(-458, 458, 0, 0);
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/DanMasterFlash - Sun Funk", 0.4f);
		_phoneNag = new _dvyBDFOZwoBLf9qqHSfHYLLXVwP(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0);
		Reset();
	}

	private void Reset()
	{
		if (_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t()._fvTKDuNATrUxfXZVvltePz3vYkK("Prologue") == 40)
		{
			base._ZzBuoSDMWwerejOO9Goyv2OCKgE._aJh9CibG5YKhkExxgRyVopdfSeJ._0Y1BTbSbP9IopfJXfeA4x02PifL("MessageTutorial1");
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
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
		if (opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("Prologue") == 30 && opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("LexDate") == 40)
		{
			opIJo2jLUqdOL5yAFP4yzXce0DG._modEEaw3I1w8Mt0usyRNoa4Ri0H(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Coby);
			opIJo2jLUqdOL5yAFP4yzXce0DG._fPyIv5zbbSj5sjZlbAwQTFXnJ5G("Prologue", 40);
			opIJo2jLUqdOL5yAFP4yzXce0DG._4Fscz8ryB3hm0NmL5xw39HHiPd1("CobyLeftClub", bool_0: true);
			base._ZzBuoSDMWwerejOO9Goyv2OCKgE._aJh9CibG5YKhkExxgRyVopdfSeJ._rGMDL1kMYXSwaZiIoINCo5AqZuM(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Coby);
			base._ZzBuoSDMWwerejOO9Goyv2OCKgE._aJh9CibG5YKhkExxgRyVopdfSeJ._vVZVLriSGPExpn1KeobglMabsoi("AchievementGeneric4");
		}
		if (opIJo2jLUqdOL5yAFP4yzXce0DG._Oms9lumBodLGrGZ09YJaEuzmlAf("LexLeftClub") && (opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("LexPreDate") == 20 || opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("LexDate") == 40))
		{
			opIJo2jLUqdOL5yAFP4yzXce0DG._Qd7anWdHpZ5AgaUbbEv07BnnI6Q(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Lex);
		}
		if (opIJo2jLUqdOL5yAFP4yzXce0DG._Oms9lumBodLGrGZ09YJaEuzmlAf("RemyLeftClub") && opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("RemyPreDate") == 10)
		{
			opIJo2jLUqdOL5yAFP4yzXce0DG._Qd7anWdHpZ5AgaUbbEv07BnnI6Q(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Remy);
		}
		if (opIJo2jLUqdOL5yAFP4yzXce0DG._Oms9lumBodLGrGZ09YJaEuzmlAf("SethLeftClub") && opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("SethPreDate") == 10)
		{
			opIJo2jLUqdOL5yAFP4yzXce0DG._Qd7anWdHpZ5AgaUbbEv07BnnI6Q(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Seth);
		}
		if (opIJo2jLUqdOL5yAFP4yzXce0DG._Oms9lumBodLGrGZ09YJaEuzmlAf("SkyeLeftClub") && opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("SkyePreDate") == 10)
		{
			opIJo2jLUqdOL5yAFP4yzXce0DG._Qd7anWdHpZ5AgaUbbEv07BnnI6Q(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Skye);
		}
		if (opIJo2jLUqdOL5yAFP4yzXce0DG._Oms9lumBodLGrGZ09YJaEuzmlAf("ZenithLeftClub") && opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("ZenithDate") == 10)
		{
			opIJo2jLUqdOL5yAFP4yzXce0DG._Qd7anWdHpZ5AgaUbbEv07BnnI6Q(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Zenith);
		}
	}

	private void ResetDeletedContacts()
	{
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
		if (opIJo2jLUqdOL5yAFP4yzXce0DG._uVBbxOT5AbKoffINIsfdTnEGd3xA.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Coby))
		{
			opIJo2jLUqdOL5yAFP4yzXce0DG._fPyIv5zbbSj5sjZlbAwQTFXnJ5G("CobyDate", 10);
			opIJo2jLUqdOL5yAFP4yzXce0DG._aedbmRW9PZZduyLA3PVVHtafNAGA("Coby");
			opIJo2jLUqdOL5yAFP4yzXce0DG._modEEaw3I1w8Mt0usyRNoa4Ri0H(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Coby);
		}
		if (opIJo2jLUqdOL5yAFP4yzXce0DG._uVBbxOT5AbKoffINIsfdTnEGd3xA.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Dustin))
		{
			opIJo2jLUqdOL5yAFP4yzXce0DG._fPyIv5zbbSj5sjZlbAwQTFXnJ5G("DustinDate", 10);
			opIJo2jLUqdOL5yAFP4yzXce0DG._aedbmRW9PZZduyLA3PVVHtafNAGA("Dustin");
			opIJo2jLUqdOL5yAFP4yzXce0DG._aedbmRW9PZZduyLA3PVVHtafNAGA("Club_Dustin_");
			opIJo2jLUqdOL5yAFP4yzXce0DG._aedbmRW9PZZduyLA3PVVHtafNAGA("First_Dustin_");
		}
		if (opIJo2jLUqdOL5yAFP4yzXce0DG._uVBbxOT5AbKoffINIsfdTnEGd3xA.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Jax))
		{
			opIJo2jLUqdOL5yAFP4yzXce0DG._fPyIv5zbbSj5sjZlbAwQTFXnJ5G("JaxPreDate", 10);
			opIJo2jLUqdOL5yAFP4yzXce0DG._fPyIv5zbbSj5sjZlbAwQTFXnJ5G("JaxDate", 10);
			opIJo2jLUqdOL5yAFP4yzXce0DG._aedbmRW9PZZduyLA3PVVHtafNAGA("Jax");
			opIJo2jLUqdOL5yAFP4yzXce0DG._aedbmRW9PZZduyLA3PVVHtafNAGA("SimpleOrder", bool_0: false);
		}
		if (opIJo2jLUqdOL5yAFP4yzXce0DG._uVBbxOT5AbKoffINIsfdTnEGd3xA.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Lex))
		{
			opIJo2jLUqdOL5yAFP4yzXce0DG._fPyIv5zbbSj5sjZlbAwQTFXnJ5G("LexPreDate", 10);
			opIJo2jLUqdOL5yAFP4yzXce0DG._fPyIv5zbbSj5sjZlbAwQTFXnJ5G("LexDate", 10);
			opIJo2jLUqdOL5yAFP4yzXce0DG._aedbmRW9PZZduyLA3PVVHtafNAGA("Lex");
			opIJo2jLUqdOL5yAFP4yzXce0DG._aedbmRW9PZZduyLA3PVVHtafNAGA("Player.Dork", bool_0: false);
		}
		if (opIJo2jLUqdOL5yAFP4yzXce0DG._uVBbxOT5AbKoffINIsfdTnEGd3xA.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Mercy))
		{
			opIJo2jLUqdOL5yAFP4yzXce0DG._fPyIv5zbbSj5sjZlbAwQTFXnJ5G("MercyPreDate", 10);
			opIJo2jLUqdOL5yAFP4yzXce0DG._fPyIv5zbbSj5sjZlbAwQTFXnJ5G("MercyDate", 10);
			opIJo2jLUqdOL5yAFP4yzXce0DG._aedbmRW9PZZduyLA3PVVHtafNAGA("Mercy");
		}
		if (opIJo2jLUqdOL5yAFP4yzXce0DG._uVBbxOT5AbKoffINIsfdTnEGd3xA.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Remy))
		{
			opIJo2jLUqdOL5yAFP4yzXce0DG._fPyIv5zbbSj5sjZlbAwQTFXnJ5G("RemyPreDate", 10);
			opIJo2jLUqdOL5yAFP4yzXce0DG._fPyIv5zbbSj5sjZlbAwQTFXnJ5G("RemyDate", 10);
			opIJo2jLUqdOL5yAFP4yzXce0DG._aedbmRW9PZZduyLA3PVVHtafNAGA("Remy");
			opIJo2jLUqdOL5yAFP4yzXce0DG._aedbmRW9PZZduyLA3PVVHtafNAGA("Rip.");
			opIJo2jLUqdOL5yAFP4yzXce0DG._aedbmRW9PZZduyLA3PVVHtafNAGA("Chef.");
			opIJo2jLUqdOL5yAFP4yzXce0DG._aedbmRW9PZZduyLA3PVVHtafNAGA("Strip.");
		}
		if (opIJo2jLUqdOL5yAFP4yzXce0DG._uVBbxOT5AbKoffINIsfdTnEGd3xA.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Seth))
		{
			opIJo2jLUqdOL5yAFP4yzXce0DG._fPyIv5zbbSj5sjZlbAwQTFXnJ5G("SethPreDate", 10);
			opIJo2jLUqdOL5yAFP4yzXce0DG._fPyIv5zbbSj5sjZlbAwQTFXnJ5G("SethDate", 10);
			opIJo2jLUqdOL5yAFP4yzXce0DG._aedbmRW9PZZduyLA3PVVHtafNAGA("Seth");
		}
		if (opIJo2jLUqdOL5yAFP4yzXce0DG._uVBbxOT5AbKoffINIsfdTnEGd3xA.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Skye))
		{
			opIJo2jLUqdOL5yAFP4yzXce0DG._fPyIv5zbbSj5sjZlbAwQTFXnJ5G("SkyePreDate", 10);
			opIJo2jLUqdOL5yAFP4yzXce0DG._fPyIv5zbbSj5sjZlbAwQTFXnJ5G("SkyeDate", 10);
			opIJo2jLUqdOL5yAFP4yzXce0DG._aedbmRW9PZZduyLA3PVVHtafNAGA("Skye");
		}
		if (opIJo2jLUqdOL5yAFP4yzXce0DG._uVBbxOT5AbKoffINIsfdTnEGd3xA.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Zenith))
		{
			opIJo2jLUqdOL5yAFP4yzXce0DG._fPyIv5zbbSj5sjZlbAwQTFXnJ5G("ZenithPreDate", 10);
			opIJo2jLUqdOL5yAFP4yzXce0DG._fPyIv5zbbSj5sjZlbAwQTFXnJ5G("ZenithDate", 10);
			opIJo2jLUqdOL5yAFP4yzXce0DG._aedbmRW9PZZduyLA3PVVHtafNAGA("Zenith");
		}
		opIJo2jLUqdOL5yAFP4yzXce0DG._Xwcp3PcmrSeqc3MSVH0tfLbcwXA();
	}

	public override void Update(GameTime gameTime)
	{
		_tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime);
		_phoneNag._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime);
	}

	public override void End()
	{
		base._tO46aYSBLFIuhFNlhbrAeWbFDSf();
		_phoneNag._tO46aYSBLFIuhFNlhbrAeWbFDSf();
	}

	private void OnClosetClick()
	{
		base._ZzBuoSDMWwerejOO9Goyv2OCKgE._xyl3Tv5KdR5eezDgagxbBcS3cwt("Clothes");
	}

	private void OnDoorClick()
	{
		if (_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t()._fvTKDuNATrUxfXZVvltePz3vYkK("Prologue") >= 40)
		{
			base._ZzBuoSDMWwerejOO9Goyv2OCKgE._k9wUPeU1Ga7cygiuGP8TT6aPLWF<LivingRoomScene>();
		}
		else
		{
			base._ZzBuoSDMWwerejOO9Goyv2OCKgE._xyl3Tv5KdR5eezDgagxbBcS3cwt("Prologue");
		}
	}
}
