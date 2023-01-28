using System;
using Microsoft.Xna.Framework;

namespace Amorous.Game.Scenes;

public class BedroomScene : TimeOfDayScene
{
	private readonly _dvyBDFOZwoBLf9qqHSfHYLLXVwP _phoneNag;

	public BedroomScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/Bedroom/Bedroom", -458, 0);
		AddClickableLayer("Background", "Assets/Scenes/Bedroom/Door", 1008, 186, OnDoorClick);
		if (PlayerPreferences.GetPlayerData().GetDecimal("Prologue") >= 40)
		{
			AddClickableLayer("Background", "Assets/Scenes/Bedroom/Closet", 1551, 112, OnClosetClick);
		}
		else
		{
			AddInteractableLayer("Background", "Assets/Scenes/Bedroom/Closet", 1551, 112, "Assets/Scenes/Bedroom/Closet active", 1517, 102, "Most of his clothes have been taken to his boyfriend's house. I can still see his ass hugging swim trunks that I'm pretty sure were designed for girls, and a dress for, well... he liked to wear a dress at one point. I don't judge.");
		}
		AddInteractableLayer("Background", "Assets/Scenes/Bedroom/Matress", -446, 447, null, 0, 0, "My brother's bed. The springs are a little worn out but otherwise still leagues better than mine. If you're wondering why I'm sleeping here, it's for a fresher perspective. Everytime I look over at his corner of the bedroom from mine, I just think of them going at it.");
		AddInteractableLayer("Background", "Assets/Scenes/Bedroom/Photo frame", 496, 156, null, 0, 0, "Thats Coby's Australian boyfriend Marty. Apparently he is making plans to visit sometime. I guess he understands my brother can't keep his pants on for that long.");
		AddInteractableLayer("Background", "Assets/Scenes/Bedroom/Poster", 96, 217, null, 0, 0, "Coby's still got the hots for Marsupials after meeting his penpal. Apparently he was the thunder down under and then some.");
		AddInteractableLayer("Background", "Assets/Scenes/Bedroom/Con badges", 410, 310, null, 0, 0, "Badges Coby has collected from going to cons.");
		AddInteractableLayer("Background", "Assets/Scenes/Bedroom/Alarm clock", 672, 493, "Assets/Scenes/Bedroom/Alarm clock active", 672, 493, "Never something I used often myself, but it's been at least getting me up before noon.");
		if (!Censorship.Censored)
		{
			AddInteractableLayer("Background", "Assets/Scenes/Bedroom/Drawer", 531, 568, "Assets/Scenes/Bedroom/Drawer active", 454, 538, "It's a struggle just to get this thing open. Always keeping the emergency supply at arms' reach I guess.");
		}
		AddInteractableLayer("Background", "Assets/Scenes/Bedroom/Kangaroo Plush", 359, 159, null, 0, 0, "A little something my brother bought as a reminder of his long-distance boyfriend. It must be a pretty open relationship.");
		AddInteractableLayer("Background", "Assets/Scenes/Bedroom/Laptop", 1153, 662, null, 0, 0, "My entertainment centre for the last few weeks.");
		Game.Mouse._wFfc7xL7eKxed7i9gWtao7pgsnm(-458, 458, 0, 0);
		FadingMediaPlayer._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/DanMasterFlash - Sun Funk", 0.4f);
		_phoneNag = new _dvyBDFOZwoBLf9qqHSfHYLLXVwP(Game);
		Reset();
	}

	private void Reset()
	{
		if (PlayerPreferences.GetPlayerData().GetDecimal("Prologue") == 40)
		{
			base.Game.Achievements.GainTutorial("MessageTutorial1");
		}
		ResetFailedDates();
		ResetDeletedContacts();
	}

	public override void Begin()
	{
		Reset();
	}

	public void ResetFailedDates()
	{
		PlayerData data = PlayerPreferences.GetPlayerData();
		if (data.GetDecimal("Prologue") == 30 && data.GetDecimal("LexDate") == 40)
		{
			data.AddContact(PlayerData.EPhoneContacts.Coby);
			data.SetDecimal("Prologue", 40);
			data.SetBit("CobyLeftClub", bool_0: true);
			base.Game.Achievements.GainContact(PlayerData.EPhoneContacts.Coby);
			base.Game.Achievements.GainAchievement(Achievements.AchievementGeneric4);
		}
		if (data.GetBit("LexLeftClub") && (data.GetDecimal("LexPreDate") == 20 || data.GetDecimal("LexDate") == 40))
		{
			data.ResetContact(PlayerData.EPhoneContacts.Lex);
		}
		if (data.GetBit("RemyLeftClub") && data.GetDecimal("RemyPreDate") == 10)
		{
			data.ResetContact(PlayerData.EPhoneContacts.Remy);
		}
		if (data.GetBit("SethLeftClub") && data.GetDecimal("SethPreDate") == 10)
		{
			data.ResetContact(PlayerData.EPhoneContacts.Seth);
		}
		if (data.GetBit("SkyeLeftClub") && data.GetDecimal("SkyePreDate") == 10)
		{
			data.ResetContact(PlayerData.EPhoneContacts.Skye);
		}
		if (data.GetBit("ZenithLeftClub") && data.GetDecimal("ZenithDate") == 10)
		{
			data.ResetContact(PlayerData.EPhoneContacts.Zenith);
		}
	}

	private void ResetDeletedContacts()
	{
		PlayerData data = PlayerPreferences.GetPlayerData();
		if (data.DisabledContacts.HasFlag(PlayerData.EPhoneContacts.Coby))
		{
			data.SetDecimal("CobyDate", 10);
			data.Remove("Coby");
			data.AddContact(PlayerData.EPhoneContacts.Coby);
		}
		if (data.DisabledContacts.HasFlag(PlayerData.EPhoneContacts.Dustin))
		{
			data.SetDecimal("DustinDate", 10);
			data.Remove("Dustin");
			data.Remove("Club_Dustin_");
			data.Remove("First_Dustin_");
		}
		if (data.DisabledContacts.HasFlag(PlayerData.EPhoneContacts.Jax))
		{
			data.SetDecimal("JaxPreDate", 10);
			data.SetDecimal("JaxDate", 10);
			data.Remove("Jax");
			data.Remove("SimpleOrder", bool_0: false);
		}
		if (data.DisabledContacts.HasFlag(PlayerData.EPhoneContacts.Lex))
		{
			data.SetDecimal("LexPreDate", 10);
			data.SetDecimal("LexDate", 10);
			data.Remove("Lex");
			data.Remove("Player.Dork", bool_0: false);
		}
		if (data.DisabledContacts.HasFlag(PlayerData.EPhoneContacts.Mercy))
		{
			data.SetDecimal("MercyPreDate", 10);
			data.SetDecimal("MercyDate", 10);
			data.Remove("Mercy");
		}
		if (data.DisabledContacts.HasFlag(PlayerData.EPhoneContacts.Remy))
		{
			data.SetDecimal("RemyPreDate", 10);
			data.SetDecimal("RemyDate", 10);
			data.Remove("Remy");
			data.Remove("Rip.");
			data.Remove("Chef.");
			data.Remove("Strip.");
		}
		if (data.DisabledContacts.HasFlag(PlayerData.EPhoneContacts.Seth))
		{
			data.SetDecimal("SethPreDate", 10);
			data.SetDecimal("SethDate", 10);
			data.Remove("Seth");
		}
		if (data.DisabledContacts.HasFlag(PlayerData.EPhoneContacts.Skye))
		{
			data.SetDecimal("SkyePreDate", 10);
			data.SetDecimal("SkyeDate", 10);
			data.Remove("Skye");
		}
		if (data.DisabledContacts.HasFlag(PlayerData.EPhoneContacts.Zenith))
		{
			data.SetDecimal("ZenithPreDate", 10);
			data.SetDecimal("ZenithDate", 10);
			data.Remove("Zenith");
		}
		data.ResetDeletedContacts();
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
		base.Game.StartCutscene("Clothes");
	}

	private void OnDoorClick()
	{
		if (PlayerPreferences.GetPlayerData().GetDecimal("Prologue") >= 40)
		{
			base.Game.StartScene<LivingRoomScene>();
		}
		else
		{
			base.Game.StartCutscene("Prologue");
		}
	}
}
