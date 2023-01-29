using System.Collections.Generic;

public static class AmorousData
{ // _KZ7hNP1K5E99Xfup1lTZ9UDrxPE
	public const string Version = "1.0.4";
	public const int Code = 778700;

	public class Soundtrack
	{
		public string AssetName { get; set; }

		public string Artist { get; set; }

		public string Title { get; set; }
	}

	public static readonly List<Soundtrack> Soundtracks = new List<Soundtrack>
	{
		new Soundtrack
		{
			AssetName = LongGoneTrack,
			Artist = "4U",
			Title = "Long Gone"
		},
		new Soundtrack
		{
			AssetName = DetectivesScoopTrack,
			Artist = "AudioDriver",
			Title = "Detective's Scoop"
		},
		new Soundtrack
		{
			AssetName = TheNightSkyTrack,
			Artist = "Biggyzoom",
			Title = "The Night Sky"
		},
		new Soundtrack
		{
			AssetName = MidnightSizzleTrack,
			Artist = "Blazing Dragon",
			Title = "Midnight Sizzle"
		},
		new Soundtrack
		{
			AssetName = SomewhereinFloridaTrack,
			Artist = "CrimsonSkies455",
			Title = "Somewhere in Florida"
		},
		new Soundtrack
		{
			AssetName = SunFunkTrack,
			Artist = "DanMasterFlash",
			Title = "Sun Funk"
		},
		new Soundtrack
		{
			AssetName = HappyJazzShitTrack,
			Artist = "Father-of-Death",
			Title = "Happy Jazz Shit"
		},
		new Soundtrack
		{
			AssetName = HeatedTrack,
			Artist = "DJ-ZEK",
			Title = "Heated"
		},
		new Soundtrack
		{
			AssetName = SimulateTrack,
			Artist = "DJ-ZEK",
			Title = "Simulate"
		},
		new Soundtrack
		{
			AssetName = InAFingerBlinkTrack,
			Artist = "Hopeku",
			Title = "In A Finger Blink"
		},
		new Soundtrack
		{
			AssetName = FlyinTrack,
			Artist = "Rekuiem",
			Title = "Flyin"
		},
		new Soundtrack
		{
			AssetName = OutdatedTrack,
			Artist = "RyeGuyHead",
			Title = "Outdated"
		},
		new Soundtrack
		{
			AssetName = OMorroNaoTemVezTrack,
			Artist = "Steampianist",
			Title = "O Morro Nao Tem Vez"
		},
		new Soundtrack
		{
			AssetName = FreeFloatingTrack,
			Artist = "Warhector",
			Title = "Free Floating"
		},
		new Soundtrack
		{
			AssetName = GiantRobotsTrack,
			Artist = "WarmanSteve",
			Title = "Giant Robots"
		},
		new Soundtrack
		{
			AssetName = VagusTrack,
			Artist = "Mittsies",
			Title = "Vagus"
		},
		new Soundtrack
		{
			AssetName = DriftTrack,
			Artist = "Mittsies",
			Title = "Drift"
		},
		new Soundtrack
		{
			AssetName = FragmentTrack,
			Artist = "Mittsies",
			Title = "Fragment"
		},
		new Soundtrack
		{
			AssetName = GravityTrack,
			Artist = "Mittsies",
			Title = "Gravity (Original Mix)"
		},
		new Soundtrack
		{
			AssetName = LustrumTrack,
			Artist = "Mittsies",
			Title = "Lustrum"
		},
		new Soundtrack
		{
			AssetName = MechTrack,
			Artist = "Mittsies",
			Title = "Mech"
		},
		new Soundtrack
		{
			AssetName = NoxTrack,
			Artist = "Mittsies",
			Title = "Nox"
		},
		new Soundtrack
		{
			AssetName = RitualTrack,
			Artist = "Mittsies",
			Title = "Ritual"
		},
		new Soundtrack
		{
			AssetName = RouzTrack,
			Artist = "Mittsies",
			Title = "Rouz"
		},
		new Soundtrack
		{
			AssetName = SixtenzuTrack,
			Artist = "Mittsies",
			Title = "Sixtenzu"
		},
		new Soundtrack
		{
			AssetName = StratumTrack,
			Artist = "Mittsies",
			Title = "Stratum (Filthy House Remix)"
		},
		new Soundtrack
		{
			AssetName = TowerTrack,
			Artist = "Mittsies",
			Title = "Tower"
		},
		new Soundtrack
		{
			AssetName = VentusTrack,
			Artist = "Mittsies",
			Title = "Ventus"
		}
	};

	public static readonly string[] ClubTracks = new string[14]
	{
		SomewhereinFloridaTrack, VagusTrack, DriftTrack, FragmentTrack, GravityTrack, LustrumTrack,
		MechTrack, NoxTrack, RitualTrack, RouzTrack, SixtenzuTrack, StratumTrack, TowerTrack, VentusTrack
	};

	public const string LongGoneTrack = "Assets/Music/4U - Long Gone";
	public const string DetectivesScoopTrack = "Assets/Music/AudioDriver - Detective's Scoop";
	public const string TheNightSkyTrack = "Assets/Music/Biggyzoom - The Night Sky";
	public const string MidnightSizzleTrack = "Assets/Music/Blazing Dragon - Midnight Sizzle";
	public const string SomewhereinFloridaTrack = "Assets/Music/CrimsonSkies455 - Somewhere in Florida";
	public const string SunFunkTrack = "Assets/Music/DanMasterFlash - Sun Funk";
	public const string HappyJazzShitTrack = "Assets/Music/Father-of-Death - Happy Jazz Shit";
	public const string HeatedTrack = "Assets/Music/DJ-ZEK - Heated";
	public const string SimulateTrack = "Assets/Music/DJ-ZEK - Simulate";
	public const string InAFingerBlinkTrack = "Assets/Music/Hopeku - In A Finger Blink";
	public const string FlyinTrack = "Assets/Music/Rekuiem - Flyin";
	public const string OutdatedTrack = "Assets/Music/RyeGuyHead - Outdated";
	public const string OMorroNaoTemVezTrack = "Assets/Music/Steampianist - O Morro Nao Tem Vez";
	public const string FreeFloatingTrack = "Assets/Music/Warhector - Free Floating";
	public const string GiantRobotsTrack = "Assets/Music/WarmanSteve - Giant Robots";
	public const string VagusTrack = "Assets/Music/Mittsies - Vagus";
	public const string DriftTrack = "Assets/Music/Mittsies - Drift";
	public const string FragmentTrack = "Assets/Music/Mittsies - Fragment";
	public const string GravityTrack = "Assets/Music/Mittsies - Gravity (Original Mix)";
	public const string LustrumTrack = "Assets/Music/Mittsies - Lustrum";
	public const string MechTrack = "Assets/Music/Mittsies - Mech";
	public const string NoxTrack = "Assets/Music/Mittsies - Nox";
	public const string RitualTrack = "Assets/Music/Mittsies - Ritual";
	public const string RouzTrack = "Assets/Music/Mittsies - Rouz";
	public const string SixtenzuTrack = "Assets/Music/Mittsies - Sixtenzu";
	public const string StratumTrack = "Assets/Music/Mittsies - Stratum (Filthy House Remix)";
	public const string TowerTrack = "Assets/Music/Mittsies - Tower";
	public const string VentusTrack = "Assets/Music/Mittsies - Ventus";

	public const int ShortDialogueOffset = Confirmations.ShortDialogueOffset;
	public const int WideDialogueOffset = Confirmations.WideDialogueOffset;
	public const int ButtonHeight = 30;

	public const string Prologue = "Prologue";
	public const string Gender = "Gender";
	public const string BedroomScene = "BedroomScene";
	public const string LivingRoomScene = "LivingRoomScene";
	public const string Clothes = "Clothes";
	public const string PlayerSexScene = "PlayerSexScene";
	public const string CobyClub = "CobyClub";
	public const string CobySexscene = "CobySexscene";
	public const string DJ = "DJ";
	public const string MiniGameCooking = "MiniGameCooking";
	public const string NudesRemy = "NudesRemy";
	public const string Kane = "Kane";
	public const string Rou = "Rou";

	public const int PhoneAllowedState = 20;
	public const int PrologueStateCompleted = 40;
	public const string MessageIconGeneric = "MessageIconGeneric";
	public const string AchievementGeneric = "Assets/GUI/Achievements/Achievement_Generic";

	public const int CobyStateCompleted = 20;
	public const string MessageIconCoby = "MessageIconCoby";
	public const string CobyLeftClub = "CobyLeftClub";
	public const string CobyDate = "CobyDate";
	public const string CobyPostDate = "CobyPostDate";
	public const string AchievementCoby = "Assets/GUI/Achievements/Achievement_Coby";

	public const int DustinStateCompleted = 70;
	public const string MessageIconDustin = "MessageIconDustin";
	public const string DustinLeftClub = "DustinLeftClub";
	public const string DustinDate = "DustinDate";
	public const string DustinPostDate = "DustinPostDate";
	public const string AchievementDustin = "Assets/GUI/Achievements/Achievement_Dustin";

	public const int JaxStateCompleted = 40;
	public const string MessageIconJax = "MessageIconJax";
	public const string JaxPreDate = "JaxPreDate";
	public const string JaxLeftClub = "JaxLeftClub";
	public const string JaxDate = "JaxDate";
	public const string JaxPostDate = "JaxPostDate";
	public const string AchievementJax = "Assets/GUI/Achievements/Achievement_Jax";

	public const int LexStateCompleted = 50;
	public const string MessageIconLex = "MessageIconLex";
	public const string LexLeftClub = "LexLeftClub";
	public const string LexPreDate = "LexPreDate";
	public const string LexDate = "LexDate";
	public const string LexPostDate = "LexPostDate";
	public const string LexIsMale = "Lex.Is.Male";
	public const string AchievementLex = "Assets/GUI/Achievements/Achievement_Lex";

	public const int MercyStateCompleted = 60;
	public const string MessageIconMercy = "MessageIconMercy";
	public const string MercyLeftClub = "MercyLeftClub";
	public const string MercyPreDate = "MercyPreDate";
	public const string MercyDate = "MercyDate";
	public const string MercyPostDate = "MercyPostDate";
	public const string AchievementMercy = "Assets/GUI/Achievements/Achievement_Mercy";

	public const int RemyStateCompleted = 40;
	public const string MessageIconRemy = "MessageIconRemy";
	public const string RemyLeftClub = "RemyLeftClub";
	public const string RemyPreDate = "RemyPreDate";
	public const string RemyDate = "RemyDate";
	public const string RemyPostDate = "RemyPostDate";
	public const string AchievementRemy = "Assets/GUI/Achievements/Achievement_Remy";

	public const string MessageIconCooking = "MessageIconCooking";
	public const string AchievementCooking = "Assets/GUI/Achievements/Achievement_Cooking";

	public const int SethStateCompleted = 40;
	public const string MessageIconSeth = "MessageIconSeth";
	public const string SethLeftClub = "SethLeftClub";
	public const string SethPreDate = "SethPreDate";
	public const string SethDate = "SethDate";
	public const string SethPostDate = "SethPostDate";
	public const string AchievementSeth = "Assets/GUI/Achievements/Achievement_Seth";

	public const int SkyeStateCompleted = 60;
	public const string MessageIconSkye = "MessageIconSkye";
	public const string SkyeLeftClub = "SkyeLeftClub";
	public const string SkyePreDate = "SkyePreDate";
	public const string SkyeDate = "SkyeDate";
	public const string SkyePostDate = "SkyePostDate";
	public const string SkyeSkinYellow = "SkyeSkinYellow";
	public const string SkyeSkinBlue = "SkyeSkinBlue";
	public const string AchievementSkye = "Assets/GUI/Achievements/Achievement_Skye";

	public const int ZenithStateCompleted = 70;
	public const string MessageIconZenith = "MessageIconZenith";
	public const string ZenithLeftClub = "ZenithLeftClub";	
	public const string ZenithPreDate = "ZenithPreDate";
	public const string ZenithDate = "ZenithDate";
	public const string ZenithPostDate = "ZenithPostDate";
	public const string AchievementZenith = "Assets/GUI/Achievements/Achievement_Zenith";

	public const string MessageIconShootingRange = "MessageIconShootingRange";
	public const string AchievementShootingRange = "Assets/GUI/Achievements/Achievement_ShootingRange";

	public const int UnlockedContactDJ = 20;
	public const string MessageIconDJ = "MessageIconDJ";
	public const string AchievementDJ = "Assets/GUI/Achievements/Achievement_DJ";
}
