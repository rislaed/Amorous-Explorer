using Microsoft.Xna.Framework;

namespace Amorous.Game.Scenes;

public class BedroomScene : TimeOfDayScene
{
	private readonly PhoneUrgentlyRinging phoneRinging;

	public BedroomScene(IAmorous game) : base(game)
	{
		AddSpriteLayer("Background", "Assets/Scenes/Bedroom/Bedroom", -458, 0);
		AddClickableLayer("Background", "Assets/Scenes/Bedroom/Door", 1008, 186, OnDoorClick);
		if (PlayerPreferences.GetPlayerData().GetStage(AmorousData.Prologue) >= AmorousData.PrologueStateCompleted)
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
		Game.Canvas.SetOverscroll(-458, 458, 0, 0);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.SunFunkTrack, 0.4f);
		phoneRinging = new PhoneUrgentlyRinging(Game);
		Refresh();
	}

	private void Refresh()
	{
		if (PlayerPreferences.GetPlayerData().GetStage(AmorousData.Prologue) == AmorousData.PrologueStateCompleted)
		{
			base.Game.Achievements.TriggerTutorialAchievement("MessageTutorial1");
		}
		ResetFailedDates();
		ResetDeletedContacts();
	}

	public override void Start()
	{
		Refresh();
	}

	public void ResetFailedDates()
	{
		PlayerData data = PlayerPreferences.GetPlayerData();
		if (data.GetStage(AmorousData.Prologue) == 30 && data.GetStage(AmorousData.LexDate) == 40)
		{
			data.UnlockContact(PlayerData.EPhoneContacts.Coby);
			data.InsertStage(AmorousData.Prologue, AmorousData.PrologueStateCompleted);
			data.InsertFlag(AmorousData.CobyLeftClub, flag: true);
			base.Game.Achievements.UnlockContact(PlayerData.EPhoneContacts.Coby);
			base.Game.Achievements.TriggerAchievement(Achievements.AchievementGeneric4);
		}
		if (data.HasFlag(AmorousData.LexLeftClub) && (data.GetStage(AmorousData.LexPreDate) == 20 || data.GetStage(AmorousData.LexDate) == 40))
		{
			data.DisableContact(PlayerData.EPhoneContacts.Lex);
		}
		if (data.HasFlag(AmorousData.RemyLeftClub) && data.GetStage(AmorousData.RemyPreDate) == 10)
		{
			data.DisableContact(PlayerData.EPhoneContacts.Remy);
		}
		if (data.HasFlag(AmorousData.SethLeftClub) && data.GetStage(AmorousData.SethPreDate) == 10)
		{
			data.DisableContact(PlayerData.EPhoneContacts.Seth);
		}
		if (data.HasFlag(AmorousData.SkyeLeftClub) && data.GetStage(AmorousData.SkyePreDate) == 10)
		{
			data.DisableContact(PlayerData.EPhoneContacts.Skye);
		}
		if (data.HasFlag(AmorousData.ZenithLeftClub) && data.GetStage(AmorousData.ZenithDate) == 10)
		{
			data.DisableContact(PlayerData.EPhoneContacts.Zenith);
		}
	}

	private void ResetDeletedContacts()
	{
		PlayerData data = PlayerPreferences.GetPlayerData();
		if (data.DisabledContacts.HasFlag(PlayerData.EPhoneContacts.Coby))
		{
			data.InsertStage(AmorousData.CobyDate, 10);
			data.Remove("Coby");
			data.UnlockContact(PlayerData.EPhoneContacts.Coby);
		}
		if (data.DisabledContacts.HasFlag(PlayerData.EPhoneContacts.Dustin))
		{
			data.InsertStage(AmorousData.DustinDate, 10);
			data.Remove("Dustin");
			data.Remove("Club_Dustin_");
			data.Remove("First_Dustin_");
		}
		if (data.DisabledContacts.HasFlag(PlayerData.EPhoneContacts.Jax))
		{
			data.InsertStage(AmorousData.JaxPreDate, 10);
			data.InsertStage(AmorousData.JaxDate, 10);
			data.Remove("Jax");
			data.Remove("SimpleOrder", exactMatch: false);
		}
		if (data.DisabledContacts.HasFlag(PlayerData.EPhoneContacts.Lex))
		{
			data.InsertStage(AmorousData.LexPreDate, 10);
			data.InsertStage(AmorousData.LexDate, 10);
			data.Remove("Lex");
			data.Remove("Player.Dork", exactMatch: false);
		}
		if (data.DisabledContacts.HasFlag(PlayerData.EPhoneContacts.Mercy))
		{
			data.InsertStage(AmorousData.MercyPreDate, 10);
			data.InsertStage(AmorousData.MercyDate, 10);
			data.Remove("Mercy");
		}
		if (data.DisabledContacts.HasFlag(PlayerData.EPhoneContacts.Remy))
		{
			data.InsertStage(AmorousData.RemyPreDate, 10);
			data.InsertStage(AmorousData.RemyDate, 10);
			data.Remove("Remy");
			data.Remove("Rip.");
			data.Remove("Chef.");
			data.Remove("Strip.");
		}
		if (data.DisabledContacts.HasFlag(PlayerData.EPhoneContacts.Seth))
		{
			data.InsertStage(AmorousData.SethPreDate, 10);
			data.InsertStage(AmorousData.SethDate, 10);
			data.Remove("Seth");
		}
		if (data.DisabledContacts.HasFlag(PlayerData.EPhoneContacts.Skye))
		{
			data.InsertStage(AmorousData.SkyePreDate, 10);
			data.InsertStage(AmorousData.SkyeDate, 10);
			data.Remove("Skye");
		}
		if (data.DisabledContacts.HasFlag(PlayerData.EPhoneContacts.Zenith))
		{
			data.InsertStage(AmorousData.ZenithPreDate, 10);
			data.InsertStage(AmorousData.ZenithDate, 10);
			data.Remove("Zenith");
		}
		data.ResetDisabledContacts();
	}

	public override void Update(GameTime gameTime)
	{
		base.Update(gameTime);
		phoneRinging.Update(gameTime);
	}

	public override void End()
	{
		base.End();
		phoneRinging.End();
	}

	private void OnClosetClick()
	{
		base.Game.PlayCutscene(AmorousData.Clothes);
	}

	private void OnDoorClick()
	{
		if (PlayerPreferences.GetPlayerData().GetStage(AmorousData.Prologue) >= AmorousData.PrologueStateCompleted)
		{
			base.Game.StartScene<LivingRoomScene>();
		}
		else
		{
			base.Game.PlayCutscene(AmorousData.Prologue);
		}
	}
}
