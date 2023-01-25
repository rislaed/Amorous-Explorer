using System;
using Microsoft.Xna.Framework;

namespace Amorous.Game.Scenes;

public class BedroomScene : TimeOfDayScene
{
	private readonly _dvyBDFOZwoBLf9qqHSfHYLLXVwP _phoneNag;

	public BedroomScene(IAmorous game)
		: base(Game)
	{
		_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Background", "Assets/Scenes/Bedroom/Bedroom", -458, 0);
		_2CHUZ5vSi5NbJYJ4gGtr3C2VVEo("Background", "Assets/Scenes/Bedroom/Door", 1008, 186, OnDoorClick);
		if (_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t().GetDecimal("Prologue") >= 40)
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
		Game._vsceSzSIjBy2nZrCxAzKZbUiwLq._wFfc7xL7eKxed7i9gWtao7pgsnm(-458, 458, 0, 0);
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/DanMasterFlash - Sun Funk", 0.4f);
		_phoneNag = new _dvyBDFOZwoBLf9qqHSfHYLLXVwP(Game);
		Reset();
	}

	private void Reset()
	{
		if (_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t().GetDecimal("Prologue") == 40)
		{
			base.Game._aJh9CibG5YKhkExxgRyVopdfSeJ._0Y1BTbSbP9IopfJXfeA4x02PifL("MessageTutorial1");
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
		PlayerData opIJo2jLUqdOL5yAFP4yzXce0DG = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
		if (opIJo2jLUqdOL5yAFP4yzXce0DG.GetDecimal("Prologue") == 30 && opIJo2jLUqdOL5yAFP4yzXce0DG.GetDecimal("LexDate") == 40)
		{
			opIJo2jLUqdOL5yAFP4yzXce0DG.AddContact(PlayerData.EPhoneContacts.Coby);
			opIJo2jLUqdOL5yAFP4yzXce0DG.SetDecimal("Prologue", 40);
			opIJo2jLUqdOL5yAFP4yzXce0DG.SetBit("CobyLeftClub", bool_0: true);
			base.Game._aJh9CibG5YKhkExxgRyVopdfSeJ._rGMDL1kMYXSwaZiIoINCo5AqZuM(PlayerData.EPhoneContacts.Coby);
			base.Game._aJh9CibG5YKhkExxgRyVopdfSeJ._vVZVLriSGPExpn1KeobglMabsoi("AchievementGeneric4");
		}
		if (opIJo2jLUqdOL5yAFP4yzXce0DG.GetBit("LexLeftClub") && (opIJo2jLUqdOL5yAFP4yzXce0DG.GetDecimal("LexPreDate") == 20 || opIJo2jLUqdOL5yAFP4yzXce0DG.GetDecimal("LexDate") == 40))
		{
			opIJo2jLUqdOL5yAFP4yzXce0DG.ResetContact(PlayerData.EPhoneContacts.Lex);
		}
		if (opIJo2jLUqdOL5yAFP4yzXce0DG.GetBit("RemyLeftClub") && opIJo2jLUqdOL5yAFP4yzXce0DG.GetDecimal("RemyPreDate") == 10)
		{
			opIJo2jLUqdOL5yAFP4yzXce0DG.ResetContact(PlayerData.EPhoneContacts.Remy);
		}
		if (opIJo2jLUqdOL5yAFP4yzXce0DG.GetBit("SethLeftClub") && opIJo2jLUqdOL5yAFP4yzXce0DG.GetDecimal("SethPreDate") == 10)
		{
			opIJo2jLUqdOL5yAFP4yzXce0DG.ResetContact(PlayerData.EPhoneContacts.Seth);
		}
		if (opIJo2jLUqdOL5yAFP4yzXce0DG.GetBit("SkyeLeftClub") && opIJo2jLUqdOL5yAFP4yzXce0DG.GetDecimal("SkyePreDate") == 10)
		{
			opIJo2jLUqdOL5yAFP4yzXce0DG.ResetContact(PlayerData.EPhoneContacts.Skye);
		}
		if (opIJo2jLUqdOL5yAFP4yzXce0DG.GetBit("ZenithLeftClub") && opIJo2jLUqdOL5yAFP4yzXce0DG.GetDecimal("ZenithDate") == 10)
		{
			opIJo2jLUqdOL5yAFP4yzXce0DG.ResetContact(PlayerData.EPhoneContacts.Zenith);
		}
	}

	private void ResetDeletedContacts()
	{
		PlayerData opIJo2jLUqdOL5yAFP4yzXce0DG = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
		if (opIJo2jLUqdOL5yAFP4yzXce0DG.DisabledContacts.HasFlag(PlayerData.EPhoneContacts.Coby))
		{
			opIJo2jLUqdOL5yAFP4yzXce0DG.SetDecimal("CobyDate", 10);
			opIJo2jLUqdOL5yAFP4yzXce0DG.Remove("Coby");
			opIJo2jLUqdOL5yAFP4yzXce0DG.AddContact(PlayerData.EPhoneContacts.Coby);
		}
		if (opIJo2jLUqdOL5yAFP4yzXce0DG.DisabledContacts.HasFlag(PlayerData.EPhoneContacts.Dustin))
		{
			opIJo2jLUqdOL5yAFP4yzXce0DG.SetDecimal("DustinDate", 10);
			opIJo2jLUqdOL5yAFP4yzXce0DG.Remove("Dustin");
			opIJo2jLUqdOL5yAFP4yzXce0DG.Remove("Club_Dustin_");
			opIJo2jLUqdOL5yAFP4yzXce0DG.Remove("First_Dustin_");
		}
		if (opIJo2jLUqdOL5yAFP4yzXce0DG.DisabledContacts.HasFlag(PlayerData.EPhoneContacts.Jax))
		{
			opIJo2jLUqdOL5yAFP4yzXce0DG.SetDecimal("JaxPreDate", 10);
			opIJo2jLUqdOL5yAFP4yzXce0DG.SetDecimal("JaxDate", 10);
			opIJo2jLUqdOL5yAFP4yzXce0DG.Remove("Jax");
			opIJo2jLUqdOL5yAFP4yzXce0DG.Remove("SimpleOrder", bool_0: false);
		}
		if (opIJo2jLUqdOL5yAFP4yzXce0DG.DisabledContacts.HasFlag(PlayerData.EPhoneContacts.Lex))
		{
			opIJo2jLUqdOL5yAFP4yzXce0DG.SetDecimal("LexPreDate", 10);
			opIJo2jLUqdOL5yAFP4yzXce0DG.SetDecimal("LexDate", 10);
			opIJo2jLUqdOL5yAFP4yzXce0DG.Remove("Lex");
			opIJo2jLUqdOL5yAFP4yzXce0DG.Remove("Player.Dork", bool_0: false);
		}
		if (opIJo2jLUqdOL5yAFP4yzXce0DG.DisabledContacts.HasFlag(PlayerData.EPhoneContacts.Mercy))
		{
			opIJo2jLUqdOL5yAFP4yzXce0DG.SetDecimal("MercyPreDate", 10);
			opIJo2jLUqdOL5yAFP4yzXce0DG.SetDecimal("MercyDate", 10);
			opIJo2jLUqdOL5yAFP4yzXce0DG.Remove("Mercy");
		}
		if (opIJo2jLUqdOL5yAFP4yzXce0DG.DisabledContacts.HasFlag(PlayerData.EPhoneContacts.Remy))
		{
			opIJo2jLUqdOL5yAFP4yzXce0DG.SetDecimal("RemyPreDate", 10);
			opIJo2jLUqdOL5yAFP4yzXce0DG.SetDecimal("RemyDate", 10);
			opIJo2jLUqdOL5yAFP4yzXce0DG.Remove("Remy");
			opIJo2jLUqdOL5yAFP4yzXce0DG.Remove("Rip.");
			opIJo2jLUqdOL5yAFP4yzXce0DG.Remove("Chef.");
			opIJo2jLUqdOL5yAFP4yzXce0DG.Remove("Strip.");
		}
		if (opIJo2jLUqdOL5yAFP4yzXce0DG.DisabledContacts.HasFlag(PlayerData.EPhoneContacts.Seth))
		{
			opIJo2jLUqdOL5yAFP4yzXce0DG.SetDecimal("SethPreDate", 10);
			opIJo2jLUqdOL5yAFP4yzXce0DG.SetDecimal("SethDate", 10);
			opIJo2jLUqdOL5yAFP4yzXce0DG.Remove("Seth");
		}
		if (opIJo2jLUqdOL5yAFP4yzXce0DG.DisabledContacts.HasFlag(PlayerData.EPhoneContacts.Skye))
		{
			opIJo2jLUqdOL5yAFP4yzXce0DG.SetDecimal("SkyePreDate", 10);
			opIJo2jLUqdOL5yAFP4yzXce0DG.SetDecimal("SkyeDate", 10);
			opIJo2jLUqdOL5yAFP4yzXce0DG.Remove("Skye");
		}
		if (opIJo2jLUqdOL5yAFP4yzXce0DG.DisabledContacts.HasFlag(PlayerData.EPhoneContacts.Zenith))
		{
			opIJo2jLUqdOL5yAFP4yzXce0DG.SetDecimal("ZenithPreDate", 10);
			opIJo2jLUqdOL5yAFP4yzXce0DG.SetDecimal("ZenithDate", 10);
			opIJo2jLUqdOL5yAFP4yzXce0DG.Remove("Zenith");
		}
		opIJo2jLUqdOL5yAFP4yzXce0DG.ResetDeletedContacts();
	}

	public override void Update(GameTime gameTime)
	{
		Update(gameTime);
		_phoneNag.Update(gameTime);
	}

	public override void End()
	{
		base.End();
		_phoneNag.End();
	}

	private void OnClosetClick()
	{
		base.Game.RequestScene("Clothes");
	}

	private void OnDoorClick()
	{
		if (_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t().GetDecimal("Prologue") >= 40)
		{
			base.Game.StartScene<LivingRoomScene>();
		}
		else
		{
			base.Game.RequestScene("Prologue");
		}
	}
}
