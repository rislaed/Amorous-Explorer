using System.Collections.Generic;
using System.Linq;

public class Achievements : IAchievements
{
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

		public AchievementData(string key, string id, string title, string icon = "MessageIconGeneric", AchievementType type = AchievementType.Generic)
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
		new AchievementData(AchievementPhonenumberCoby, "ACHIEVEMENT_PHONENUMBER_COBY", "Coby", "MessageIconCoby", AchievementType.Contact),
		new AchievementData(AchievementPhonenumberJax, "ACHIEVEMENT_PHONENUMBER_JAX", "Jax", "MessageIconJax", AchievementType.Contact),
		new AchievementData(AchievementPhonenumberSeth, "ACHIEVEMENT_PHONENUMBER_SETH", "Seth", "MessageIconSeth", AchievementType.Contact),
		new AchievementData(AchievementPhonenumberSkye, "ACHIEVEMENT_PHONENUMBER_SKYE", "Skye", "MessageIconSkye", AchievementType.Contact),
		new AchievementData(AchievementPhonenumberDustin, "ACHIEVEMENT_PHONENUMBER_DUSTIN", "Dustin", "MessageIconDustin", AchievementType.Contact),
		new AchievementData(AchievementPhonenumberZenith, "ACHIEVEMENT_PHONENUMBER_ZENITH", "Zenith", "MessageIconZenith", AchievementType.Contact),
		new AchievementData(AchievementPhonenumberMercy, "ACHIEVEMENT_PHONENUMBER_MERCY", "Mercy", "MessageIconMercy", AchievementType.Contact),
		new AchievementData(AchievementPhonenumberRemy, "ACHIEVEMENT_PHONENUMBER_REMY", "Remy", "MessageIconRemy", AchievementType.Contact),
		new AchievementData(AchievementPhonenumberLex, "ACHIEVEMENT_PHONENUMBER_LEX", "Lex", "MessageIconLex", AchievementType.Contact),
		new AchievementData(AchievementDate1Coby, "ACHIEVEMENT_DATE1_COBY", "Oh, Brother!", "MessageIconCoby"),
		new AchievementData(AchievementDate1Jax, "ACHIEVEMENT_DATE1_JAX", "Testing the Waters", "MessageIconJax"),
		new AchievementData(AchievementDate2Jax, "ACHIEVEMENT_DATE2_JAX", "Someone Likes You", "MessageIconJax"),
		new AchievementData(AchievementDate3Jax, "ACHIEVEMENT_DATE3_JAX", "This is Love", "MessageIconJax"),
		new AchievementData(AchievementDate1Seth, "ACHIEVEMENT_DATE1_SETH", "Testing the Waters", "MessageIconSeth"),
		new AchievementData(AchievementDate2Seth, "ACHIEVEMENT_DATE2_SETH", "Someone Likes You", "MessageIconSeth"),
		new AchievementData(AchievementDate3Seth, "ACHIEVEMENT_DATE3_SETH", "This is Love", "MessageIconSeth"),
		new AchievementData(AchievementDate1Skye, "ACHIEVEMENT_DATE1_SKYE", "Testing the Waters", "MessageIconSkye"),
		new AchievementData(AchievementDate2Skye, "ACHIEVEMENT_DATE2_SKYE", "Someone Likes You", "MessageIconSkye"),
		new AchievementData(AchievementDate3Skye, "ACHIEVEMENT_DATE3_SKYE", "This is Love", "MessageIconSkye"),
		new AchievementData(AchievementDate1Dustin, "ACHIEVEMENT_DATE1_DUSTIN", "Testing the Waters", "MessageIconDustin"),
		new AchievementData(AchievementDate2Dustin, "ACHIEVEMENT_DATE2_DUSTIN", "Someone Likes You", "MessageIconDustin"),
		new AchievementData(AchievementDate3Dustin, "ACHIEVEMENT_DATE3_DUSTIN", "This is Love", "MessageIconDustin"),
		new AchievementData(AchievementDate1Zenith, "ACHIEVEMENT_DATE1_ZENITH", "Testing the Waters", "MessageIconZenith"),
		new AchievementData(AchievementDate2Zenith, "ACHIEVEMENT_DATE2_ZENITH", "Someone Likes You", "MessageIconZenith"),
		new AchievementData(AchievementDate3Zenith, "ACHIEVEMENT_DATE3_ZENITH", "This is Love", "MessageIconZenith"),
		new AchievementData(AchievementDate1Mercy, "ACHIEVEMENT_DATE1_MERCY", "Testing the Waters", "MessageIconMercy"),
		new AchievementData(AchievementDate2Mercy, "ACHIEVEMENT_DATE2_MERCY", "Someone Likes You", "MessageIconMercy"),
		new AchievementData(AchievementDate3Mercy, "ACHIEVEMENT_DATE3_MERCY", "This is Love", "MessageIconMercy"),
		new AchievementData(AchievementDate1Remy, "ACHIEVEMENT_DATE1_REMY", "Testing the Waters", "MessageIconRemy"),
		new AchievementData(AchievementDate2Remy, "ACHIEVEMENT_DATE2_REMY", "Someone Likes You", "MessageIconRemy"),
		new AchievementData(AchievementDate3Remy, "ACHIEVEMENT_DATE3_REMY", "This is Love", "MessageIconRemy"),
		new AchievementData(AchievementDate1Lex, "ACHIEVEMENT_DATE1_LEX", "Testing the Waters", "MessageIconLex"),
		new AchievementData(AchievementDate2Lex, "ACHIEVEMENT_DATE2_LEX", "Someone Likes You", "MessageIconLex"),
		new AchievementData(AchievementDate3Lex, "ACHIEVEMENT_DATE3_LEX", "This is Love", "MessageIconLex"),
		new AchievementData(AchievementGeneric1, "ACHIEVEMENT_GENERIC1", "Bells and Whistles"),
		new AchievementData(AchievementGeneric2, "ACHIEVEMENT_GENERIC2", "Welcome to Amorous"),
		new AchievementData(AchievementGeneric3, "ACHIEVEMENT_GENERIC3", "Hey Mr. D.J.", "MessageIconDJ"),
		new AchievementData(AchievementGeneric4, "ACHIEVEMENT_GENERIC4", "Last Night a D.J.Saved My Life"),
		new AchievementData(AchievementGeneric5, "ACHIEVEMENT_GENERIC5", "Ohh, what does THIS button do?"),
		new AchievementData(AchievementGeneric6, "ACHIEVEMENT_GENERIC6", "Clothes Maketh Man"),
		new AchievementData(AchievementGeneric7, "ACHIEVEMENT_GENERIC7", "Gunslinger", "MessageIconShootingRange"),
		new AchievementData(AchievementGeneric8, "ACHIEVEMENT_GENERIC8", "Boom Headshot!", "MessageIconShootingRange"),
		new AchievementData(AchievementGeneric9, "ACHIEVEMENT_GENERIC9", "Steady Aim", "MessageIconShootingRange"),
		new AchievementData(AchievementGeneric10, "ACHIEVEMENT_GENERIC10", "Sleight of Hand", "MessageIconShootingRange"),
		new AchievementData(AchievementGeneric11, "ACHIEVEMENT_GENERIC11", "Yes Chef!", "MessageIconCooking")
	};

	private static readonly Dictionary<string, AchievementData> _achievements = _achievementDatas.ToDictionary((AchievementData _eT2GJReQj8Acaq2A0H0eUir97Qf_0) => _eT2GJReQj8Acaq2A0H0eUir97Qf_0.Key, (AchievementData _eT2GJReQj8Acaq2A0H0eUir97Qf_0) => _eT2GJReQj8Acaq2A0H0eUir97Qf_0);

	public const string AchievementTutorial = "MessageTutorial1";

	private readonly IAmorous _game;
	private readonly SteamObserver _steam;

	public static List<AchievementData> Achievables => _achievementDatas;

	public bool IsSteamSupported => _steam != null;

	public Achievements(IAmorous game, SteamObserver client)
	{
		_game = game;
		_steam = client;
	}

	public void GainCutsceneStageAchievement(string name, int stage)
	{
		if (name == "Clothes")
		{
			GainAchievement(AchievementGeneric6);
		}
		else if (name == "Prologue" && stage == 30)
		{
			GainAchievement(AchievementGeneric4);
		}
		else if (name == "CobyDate")
		{
			GainAchievement(AchievementDate1Coby);
		}
		else if (name == "DJ" && stage == 10)
		{
			NotifyAchievedContact("Club Amorous DJ", "MessageIconDJ");
		}
	}

	public void SetDecimal(string key, int value)
	{
		if (key == "JaxDate" && value == 20)
		{
			GainAchievement(AchievementDate1Jax);
		}
		else if (key == "JaxDate" && value == 30)
		{
			GainAchievement(AchievementDate2Jax);
		}
		else if (key == "JaxDate" && value == 40)
		{
			GainAchievement(AchievementDate3Jax);
		}
		else if (key == "SethDate" && value == 20)
		{
			GainAchievement(AchievementDate1Seth);
		}
		else if (!(key == "SethDate") || value != 30)
		{
			if (key == "SethDate" && value == 40)
			{
				GainAchievement(AchievementDate3Seth);
			}
			else if (key == "SkyeDate" && value == 40)
			{
				GainAchievement(AchievementDate1Skye);
			}
			else if (key == "SkyeDate" && value == 50)
			{
				GainAchievement(AchievementDate2Skye);
			}
			else if (key == "SkyeDate" && value == 60)
			{
				GainAchievement(AchievementDate3Skye);
			}
			else if (key == "DustinDate" && value == 50)
			{
				GainAchievement(AchievementDate1Dustin);
			}
			else if (key == "DustinDate" && value == 60)
			{
				GainAchievement(AchievementDate2Dustin);
			}
			else if (!(key == "DustinDate") || value != 70)
			{
				if (!(key == "ZenithDate") || value != 30)
				{
					if (!(key == "ZenithDate") || value != 40)
					{
						if (key == "ZenithDate" && value == 60)
						{
							GainAchievement(AchievementDate3Zenith);
						}
						else if (key == "MercyDate" && value == 30)
						{
							GainAchievement(AchievementDate1Mercy);
						}
						else if (key == "MercyDate" && value == 40)
						{
							GainAchievement(AchievementDate2Mercy);
						}
						else if (key == "MercyDate" && value == 60)
						{
							GainAchievement(AchievementDate3Mercy);
						}
						else if (!(key == "RemyDate") || value != 20)
						{
							if (key == "RemyDate" && value == 30)
							{
								GainAchievement(AchievementDate2Remy);
							}
							else if (key == "RemyDate" && value == 40)
							{
								GainAchievement(AchievementDate3Remy);
							}
							else if (key == "LexDate" && value == 20)
							{
								GainAchievement(AchievementDate1Lex);
							}
							else if (key == "LexDate" && value == 30)
							{
								GainAchievement(AchievementDate2Lex);
							}
							else if (key == "LexDate" && value == 50)
							{
								GainAchievement(AchievementDate3Lex);
							}
						}
						else
						{
							GainAchievement(AchievementDate1Remy);
						}
					}
					else
					{
						GainAchievement(AchievementDate2Zenith);
					}
				}
				else
				{
					GainAchievement(AchievementDate1Zenith);
				}
			}
			else
			{
				GainAchievement(AchievementDate3Dustin);
			}
		}
		else
		{
			GainAchievement(AchievementDate2Seth);
		}
	}

	public void SetBit(string key, bool value)
	{
		// ?
	}

	public void GainContact(PlayerData.EPhoneContacts contact)
	{
		switch (contact)
		{
			case PlayerData.EPhoneContacts.Skye:
				GainAchievement(AchievementPhonenumberSkye);
				break;
			case PlayerData.EPhoneContacts.Dustin:
				GainAchievement(AchievementPhonenumberDustin);
				break;
			case PlayerData.EPhoneContacts.Coby:
				GainAchievement(AchievementPhonenumberCoby);
				break;
			case PlayerData.EPhoneContacts.Jax:
				GainAchievement(AchievementPhonenumberJax);
				break;
			case PlayerData.EPhoneContacts.Seth:
				GainAchievement(AchievementPhonenumberSeth);
				break;
			case PlayerData.EPhoneContacts.Zenith:
				GainAchievement(AchievementPhonenumberZenith);
				break;
			case PlayerData.EPhoneContacts.Mercy:
				GainAchievement(AchievementPhonenumberMercy);
				break;
			case PlayerData.EPhoneContacts.Remy:
				GainAchievement(AchievementPhonenumberRemy);
				break;
			case PlayerData.EPhoneContacts.Lex:
				GainAchievement(AchievementPhonenumberLex);
				break;
		}
	}

	public void GainAchievement(string name)
	{
		PlayerData data = PlayerPreferences.GetPlayerData();
		if (data.GetBit(name))
		{
			return;
		}
		data.SetBit(name, bool_0: true);
		if (_achievements.TryGetValue(name, out var value))
		{
			if (_steam != null)
			{
				_steam.GainAchievement(value.ID);
			}
			if (value.Type != AchievementType.Contact)
			{
				NotifyAchievedGeneric(value.Icon, value.Title);
			}
			else
			{
				NotifyAchievedContact(value.Icon, value.Title);
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

	public void GainTutorial(string key)
	{
		PlayerData data = PlayerPreferences.GetPlayerData();
		if (!data.GetBit(key))
		{
			data.SetBit(key, bool_0: true);
			if (key == AchievementTutorial)
			{
				_game.ShowMessage("MessageIconGeneric", "Tutorial", "You've finished the prologue and went home. Your phone is your most important asset. Open it by pressing SHIFT!");
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
