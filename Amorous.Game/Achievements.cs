using System.Collections.Generic;
using System.Linq;

public class Achievements : IAchievements
{ // _bm5ybW5ND5sDF6bvP0sbYyOpvP
	public enum AchievementType
	{
		Generic,
		Contact
	}

	public class AchievementData
	{
		public string Key { get; }
		public string ID { get; }
		public AchievementType Type { get; }
		public string Icon { get; }
		public string Title { get; }

		public AchievementData(string key, string id, string title, string icon = AmorousData.MessageIconGeneric, AchievementType type = AchievementType.Generic)
		{
			Key = key;
			ID = id;
			Type = type;
			Icon = icon;
			Title = title;
		}
	}

	public const string AchievementPhonenumberCoby = "AchievementPhonenumberCoby";
	public const string AchievementPhonenumberJax = "AchievementPhonenumberJax";
	public const string AchievementPhonenumberSeth = "AchievementPhonenumberSeth";
	public const string AchievementPhonenumberSkye = "AchievementPhonenumberSkye";
	public const string AchievementPhonenumberDustin = "AchievementPhonenumberDustin";
	public const string AchievementPhonenumberZenith = "AchievementPhonenumberZenith";
	public const string AchievementPhonenumberMercy = "AchievementPhonenumberMercy";
	public const string AchievementPhonenumberRemy = "AchievementPhonenumberRemy";
	public const string AchievementPhonenumberLex = "AchievementPhonenumberLex";
	public const string AchievementDate1Coby = "AchievementDate1Coby";
	public const string AchievementDate1Jax = "AchievementDate1Jax";
	public const string AchievementDate2Jax = "AchievementDate2Jax";
	public const string AchievementDate3Jax = "AchievementDate3Jax";
	public const string AchievementDate1Seth = "AchievementDate1Seth";
	public const string AchievementDate2Seth = "AchievementDate2Seth";
	public const string AchievementDate3Seth = "AchievementDate3Seth";
	public const string AchievementDate1Skye = "AchievementDate1Skye";
	public const string AchievementDate2Skye = "AchievementDate2Skye";
	public const string AchievementDate3Skye = "AchievementDate3Skye";
	public const string AchievementDate1Dustin = "AchievementDate1Dustin";
	public const string AchievementDate2Dustin = "AchievementDate2Dustin";
	public const string AchievementDate3Dustin = "AchievementDate3Dustin";
	public const string AchievementDate1Zenith = "AchievementDate1Zenith";
	public const string AchievementDate2Zenith = "AchievementDate2Zenith";
	public const string AchievementDate3Zenith = "AchievementDate3Zenith";
	public const string AchievementDate1Mercy = "AchievementDate1Mercy";
	public const string AchievementDate2Mercy = "AchievementDate2Mercy";
	public const string AchievementDate3Mercy = "AchievementDate3Mercy";
	public const string AchievementDate1Remy = "AchievementDate1Remy";
	public const string AchievementDate2Remy = "AchievementDate2Remy";
	public const string AchievementDate3Remy = "AchievementDate3Remy";
	public const string AchievementDate1Lex = "AchievementDate1Lex";
	public const string AchievementDate2Lex = "AchievementDate2Lex";
	public const string AchievementDate3Lex = "AchievementDate3Lex";
	public const string AchievementGeneric1 = "AchievementGeneric1";
	public const string AchievementGeneric2 = "AchievementGeneric2";
	public const string AchievementGeneric3 = "AchievementGeneric3";
	public const string AchievementGeneric4 = "AchievementGeneric4";
	public const string AchievementGeneric5 = "AchievementGeneric5";
	public const string AchievementGeneric6 = "AchievementGeneric6";
	public const string AchievementGeneric7 = "AchievementGeneric7";
	public const string AchievementGeneric8 = "AchievementGeneric8";
	public const string AchievementGeneric9 = "AchievementGeneric9";
	public const string AchievementGeneric10 = "AchievementGeneric10";
	public const string AchievementGeneric11 = "AchievementGeneric11";

	private static readonly List<AchievementData> _achievementDatas = new List<AchievementData>
	{
		new AchievementData(AchievementPhonenumberCoby, "ACHIEVEMENT_PHONENUMBER_COBY", "Coby", AmorousData.MessageIconCoby, AchievementType.Contact),
		new AchievementData(AchievementPhonenumberJax, "ACHIEVEMENT_PHONENUMBER_JAX", "Jax", AmorousData.MessageIconJax, AchievementType.Contact),
		new AchievementData(AchievementPhonenumberSeth, "ACHIEVEMENT_PHONENUMBER_SETH", "Seth", AmorousData.MessageIconSeth, AchievementType.Contact),
		new AchievementData(AchievementPhonenumberSkye, "ACHIEVEMENT_PHONENUMBER_SKYE", "Skye", AmorousData.MessageIconSkye, AchievementType.Contact),
		new AchievementData(AchievementPhonenumberDustin, "ACHIEVEMENT_PHONENUMBER_DUSTIN", "Dustin", AmorousData.MessageIconDustin, AchievementType.Contact),
		new AchievementData(AchievementPhonenumberZenith, "ACHIEVEMENT_PHONENUMBER_ZENITH", "Zenith", AmorousData.MessageIconZenith, AchievementType.Contact),
		new AchievementData(AchievementPhonenumberMercy, "ACHIEVEMENT_PHONENUMBER_MERCY", "Mercy", AmorousData.MessageIconMercy, AchievementType.Contact),
		new AchievementData(AchievementPhonenumberRemy, "ACHIEVEMENT_PHONENUMBER_REMY", "Remy", AmorousData.MessageIconRemy, AchievementType.Contact),
		new AchievementData(AchievementPhonenumberLex, "ACHIEVEMENT_PHONENUMBER_LEX", "Lex", AmorousData.MessageIconLex, AchievementType.Contact),
		new AchievementData(AchievementDate1Coby, "ACHIEVEMENT_DATE1_COBY", "Oh, Brother!", AmorousData.MessageIconCoby),
		new AchievementData(AchievementDate1Jax, "ACHIEVEMENT_DATE1_JAX", "Testing the Waters", AmorousData.MessageIconJax),
		new AchievementData(AchievementDate2Jax, "ACHIEVEMENT_DATE2_JAX", "Someone Likes You", AmorousData.MessageIconJax),
		new AchievementData(AchievementDate3Jax, "ACHIEVEMENT_DATE3_JAX", "This is Love", AmorousData.MessageIconJax),
		new AchievementData(AchievementDate1Seth, "ACHIEVEMENT_DATE1_SETH", "Testing the Waters", AmorousData.MessageIconSeth),
		new AchievementData(AchievementDate2Seth, "ACHIEVEMENT_DATE2_SETH", "Someone Likes You", AmorousData.MessageIconSeth),
		new AchievementData(AchievementDate3Seth, "ACHIEVEMENT_DATE3_SETH", "This is Love", AmorousData.MessageIconSeth),
		new AchievementData(AchievementDate1Skye, "ACHIEVEMENT_DATE1_SKYE", "Testing the Waters", AmorousData.MessageIconSkye),
		new AchievementData(AchievementDate2Skye, "ACHIEVEMENT_DATE2_SKYE", "Someone Likes You", AmorousData.MessageIconSkye),
		new AchievementData(AchievementDate3Skye, "ACHIEVEMENT_DATE3_SKYE", "This is Love", AmorousData.MessageIconSkye),
		new AchievementData(AchievementDate1Dustin, "ACHIEVEMENT_DATE1_DUSTIN", "Testing the Waters", AmorousData.MessageIconDustin),
		new AchievementData(AchievementDate2Dustin, "ACHIEVEMENT_DATE2_DUSTIN", "Someone Likes You", AmorousData.MessageIconDustin),
		new AchievementData(AchievementDate3Dustin, "ACHIEVEMENT_DATE3_DUSTIN", "This is Love", AmorousData.MessageIconDustin),
		new AchievementData(AchievementDate1Zenith, "ACHIEVEMENT_DATE1_ZENITH", "Testing the Waters", AmorousData.MessageIconZenith),
		new AchievementData(AchievementDate2Zenith, "ACHIEVEMENT_DATE2_ZENITH", "Someone Likes You", AmorousData.MessageIconZenith),
		new AchievementData(AchievementDate3Zenith, "ACHIEVEMENT_DATE3_ZENITH", "This is Love", AmorousData.MessageIconZenith),
		new AchievementData(AchievementDate1Mercy, "ACHIEVEMENT_DATE1_MERCY", "Testing the Waters", AmorousData.MessageIconMercy),
		new AchievementData(AchievementDate2Mercy, "ACHIEVEMENT_DATE2_MERCY", "Someone Likes You", AmorousData.MessageIconMercy),
		new AchievementData(AchievementDate3Mercy, "ACHIEVEMENT_DATE3_MERCY", "This is Love", AmorousData.MessageIconMercy),
		new AchievementData(AchievementDate1Remy, "ACHIEVEMENT_DATE1_REMY", "Testing the Waters", AmorousData.MessageIconRemy),
		new AchievementData(AchievementDate2Remy, "ACHIEVEMENT_DATE2_REMY", "Someone Likes You", AmorousData.MessageIconRemy),
		new AchievementData(AchievementDate3Remy, "ACHIEVEMENT_DATE3_REMY", "This is Love", AmorousData.MessageIconRemy),
		new AchievementData(AchievementDate1Lex, "ACHIEVEMENT_DATE1_LEX", "Testing the Waters", AmorousData.MessageIconLex),
		new AchievementData(AchievementDate2Lex, "ACHIEVEMENT_DATE2_LEX", "Someone Likes You", AmorousData.MessageIconLex),
		new AchievementData(AchievementDate3Lex, "ACHIEVEMENT_DATE3_LEX", "This is Love", AmorousData.MessageIconLex),
		new AchievementData(AchievementGeneric1, "ACHIEVEMENT_GENERIC1", "Bells and Whistles"),
		new AchievementData(AchievementGeneric2, "ACHIEVEMENT_GENERIC2", "Welcome to Amorous"),
		new AchievementData(AchievementGeneric3, "ACHIEVEMENT_GENERIC3", "Hey Mr. D.J.", AmorousData.MessageIconDJ),
		new AchievementData(AchievementGeneric4, "ACHIEVEMENT_GENERIC4", "Last Night a D.J.Saved My Life"),
		new AchievementData(AchievementGeneric5, "ACHIEVEMENT_GENERIC5", "Ohh, what does THIS button do?"),
		new AchievementData(AchievementGeneric6, "ACHIEVEMENT_GENERIC6", "Clothes Maketh Man"),
		new AchievementData(AchievementGeneric7, "ACHIEVEMENT_GENERIC7", "Gunslinger", AmorousData.MessageIconShootingRange),
		new AchievementData(AchievementGeneric8, "ACHIEVEMENT_GENERIC8", "Boom Headshot!", AmorousData.MessageIconShootingRange),
		new AchievementData(AchievementGeneric9, "ACHIEVEMENT_GENERIC9", "Steady Aim", AmorousData.MessageIconShootingRange),
		new AchievementData(AchievementGeneric10, "ACHIEVEMENT_GENERIC10", "Sleight of Hand", AmorousData.MessageIconShootingRange),
		new AchievementData(AchievementGeneric11, "ACHIEVEMENT_GENERIC11", "Yes Chef!", AmorousData.MessageIconCooking)
	};

	private static readonly Dictionary<string, AchievementData> AchievementsData = _achievementDatas.ToDictionary((AchievementData _eT2GJReQj8Acaq2A0H0eUir97Qf_0) => _eT2GJReQj8Acaq2A0H0eUir97Qf_0.Key, (AchievementData _eT2GJReQj8Acaq2A0H0eUir97Qf_0) => _eT2GJReQj8Acaq2A0H0eUir97Qf_0);

	public const string MessageTutorial1 = "MessageTutorial1";

	private readonly IAmorous _game;
	private readonly SteamObserver _steam;

	public static List<AchievementData> Achievables => _achievementDatas;

	public bool IsSteamSupported => _steam != null;

	public Achievements(IAmorous game, SteamObserver client)
	{
		_game = game;
		_steam = client;
	}

	public void TriggerCutsceneStageAchievement(string cutscene, int stage)
	{
		if (cutscene == AmorousData.Clothes)
		{
			TriggerAchievement(AchievementGeneric6);
		}
		else if (cutscene == AmorousData.Prologue && stage == 30)
		{
			TriggerAchievement(AchievementGeneric4);
		}
		else if (cutscene == AmorousData.CobyDate)
		{
			TriggerAchievement(AchievementDate1Coby);
		}
		else if (cutscene == AmorousData.DJ && stage == 10)
		{
			NotifyAchievedContact("Club Amorous DJ", AmorousData.MessageIconDJ);
		}
	}

	public void SetStage(string key, int stage)
	{
		if (key == AmorousData.JaxDate && stage == 20)
		{
			TriggerAchievement(AchievementDate1Jax);
		}
		else if (key == AmorousData.JaxDate && stage == 30)
		{
			TriggerAchievement(AchievementDate2Jax);
		}
		else if (key == AmorousData.JaxDate && stage == AmorousData.JaxStateCompleted)
		{
			TriggerAchievement(AchievementDate3Jax);
		}
		else if (key == AmorousData.SethDate && stage == 20)
		{
			TriggerAchievement(AchievementDate1Seth);
		}
		else if (!(key == AmorousData.SethDate) || stage != 30)
		{
			if (key == AmorousData.SethDate && stage == AmorousData.SethStateCompleted)
			{
				TriggerAchievement(AchievementDate3Seth);
			}
			else if (key == AmorousData.SkyeDate && stage == 40)
			{
				TriggerAchievement(AchievementDate1Skye);
			}
			else if (key == AmorousData.SkyeDate && stage == 50)
			{
				TriggerAchievement(AchievementDate2Skye);
			}
			else if (key == AmorousData.SkyeDate && stage == AmorousData.SkyeStateCompleted)
			{
				TriggerAchievement(AchievementDate3Skye);
			}
			else if (key == AmorousData.DustinDate && stage == 50)
			{
				TriggerAchievement(AchievementDate1Dustin);
			}
			else if (key == AmorousData.DustinDate && stage == 60)
			{
				TriggerAchievement(AchievementDate2Dustin);
			}
			else if (!(key == AmorousData.DustinDate) || stage != AmorousData.DustinStateCompleted)
			{
				if (!(key == AmorousData.ZenithDate) || stage != 30)
				{
					if (!(key == AmorousData.ZenithDate) || stage != 40)
					{
						if (key == AmorousData.ZenithDate && stage == 60)
						{
							TriggerAchievement(AchievementDate3Zenith);
						}
						else if (key == AmorousData.MercyDate && stage == 30)
						{
							TriggerAchievement(AchievementDate1Mercy);
						}
						else if (key == AmorousData.MercyDate && stage == 40)
						{
							TriggerAchievement(AchievementDate2Mercy);
						}
						else if (key == AmorousData.MercyDate && stage == AmorousData.SkyeStateCompleted)
						{
							TriggerAchievement(AchievementDate3Mercy);
						}
						else if (!(key == AmorousData.RemyDate) || stage != 20)
						{
							if (key == AmorousData.RemyDate && stage == 30)
							{
								TriggerAchievement(AchievementDate2Remy);
							}
							else if (key == AmorousData.RemyDate && stage == AmorousData.RemyStateCompleted)
							{
								TriggerAchievement(AchievementDate3Remy);
							}
							else if (key == AmorousData.LexDate && stage == 20)
							{
								TriggerAchievement(AchievementDate1Lex);
							}
							else if (key == AmorousData.LexDate && stage == 30)
							{
								TriggerAchievement(AchievementDate2Lex);
							}
							else if (key == AmorousData.LexDate && stage == AmorousData.LexStateCompleted)
							{
								TriggerAchievement(AchievementDate3Lex);
							}
						}
						else
						{
							TriggerAchievement(AchievementDate1Remy);
						}
					}
					else
					{
						TriggerAchievement(AchievementDate2Zenith);
					}
				}
				else
				{
					TriggerAchievement(AchievementDate1Zenith);
				}
			}
			else
			{
				TriggerAchievement(AchievementDate3Dustin);
			}
		}
		else
		{
			TriggerAchievement(AchievementDate2Seth);
		}
	}

	public void SetFlag(string key, bool flag)
	{
	}

	public void UnlockContact(PlayerData.EPhoneContacts contact)
	{
		switch (contact)
		{
			case PlayerData.EPhoneContacts.Skye:
				TriggerAchievement(AchievementPhonenumberSkye);
				break;
			case PlayerData.EPhoneContacts.Dustin:
				TriggerAchievement(AchievementPhonenumberDustin);
				break;
			case PlayerData.EPhoneContacts.Coby:
				TriggerAchievement(AchievementPhonenumberCoby);
				break;
			case PlayerData.EPhoneContacts.Jax:
				TriggerAchievement(AchievementPhonenumberJax);
				break;
			case PlayerData.EPhoneContacts.Seth:
				TriggerAchievement(AchievementPhonenumberSeth);
				break;
			case PlayerData.EPhoneContacts.Zenith:
				TriggerAchievement(AchievementPhonenumberZenith);
				break;
			case PlayerData.EPhoneContacts.Mercy:
				TriggerAchievement(AchievementPhonenumberMercy);
				break;
			case PlayerData.EPhoneContacts.Remy:
				TriggerAchievement(AchievementPhonenumberRemy);
				break;
			case PlayerData.EPhoneContacts.Lex:
				TriggerAchievement(AchievementPhonenumberLex);
				break;
		}
	}

	public void TriggerAchievement(string name)
	{
		PlayerData data = PlayerPreferences.GetPlayerData();
		if (data.GetFlag(name))
		{
			return;
		}
		data.SetFlag(name, flag: true);
		if (AchievementsData.TryGetValue(name, out var achievement))
		{
			if (_steam != null)
			{
				_steam.TriggerAchievement(achievement.ID);
			}
			if (achievement.Type != AchievementType.Contact)
			{
				NotifyAchievedGeneric(achievement.Icon, achievement.Title);
			}
			else
			{
				NotifyAchievedContact(achievement.Icon, achievement.Title);
			}
		}
	}

	private void NotifyAchievedGeneric(string icon, string achievement)
	{
		_game.ShowMessage(icon, "Achievement", "Congratulations, you've unlocked the '" + achievement + "'-achievement!");
	}

	private void NotifyAchievedContact(string icon, string name)
	{
		_game.ShowMessage(icon, "Contact", "The phonenumber of " + name + " has been added to your contacts!");
	}

	public void TriggerTutorialAchievement(string key)
	{
		PlayerData data = PlayerPreferences.GetPlayerData();
		if (!data.GetFlag(key))
		{
			data.SetFlag(key, flag: true);
			if (key == MessageTutorial1)
			{
				_game.ShowMessage(AmorousData.MessageIconGeneric, "Tutorial", "You've finished the prologue and went home. Your phone is your most important asset. Open it by pressing SHIFT!");
			}
		}
	}

	public void OpenAchievements()
	{
		if (_steam != null)
		{
			_steam.OpenAchievements();
		}
	}
}
