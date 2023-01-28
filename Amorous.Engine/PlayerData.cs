using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Newtonsoft.Json;

public class PlayerData : IPlayerData
{
	public enum EBodyType
	{
		Chubby,
		Lean,
		Muscular,
		Twinky
	}

	[Flags]
	public enum EMarkingsType
	{
		None = 0,
		Underbelly = 1,
		Underthigh = 2,
		Stripes = 4,
		LongForearm = 8,
		ShortForearm = 0x10,
		AvianForearm = 0x20,
		LongShin = 0x40,
		ShortShin = 0x80,
		AvianShin = 0x100
	}

	public enum EHeadType
	{
		Default,
		Humanoid,
		PaperBag
	}

	[Flags]
	public enum EHeadMarkingsType
	{
		None = 0,
		Gaunt = 1,
		Scruffy = 2,
		Snout = 4,
		Stripes = 8
	}

	public enum EHeadAccessoriesType
	{
		None,
		CurvedHorns,
		DroopyEars,
		DualHorns,
		FluffyEars,
		HumanEars,
		LongHorns,
		LupineEars,
		RiggedHorns,
		ScruffyEars,
		SharpEars,
		ShortEars,
		SlopedEars
	}

	public enum EEyesType
	{
		Feminine,
		Heavy,
		Humanoid,
		Kawaii,
		Lustful,
		Masculine,
		Neutral,
		Spooky,
		Stern
	}

	public enum EBrowType
	{
		None,
		Assertive,
		Lithe,
		Neutral,
		Passive,
		Plated,
		Ribbed,
		Ridged,
		Stern,
		Thick
	}

	public enum EMuzzleType
	{
		None,
		Beak,
		Bill,
		Cleft,
		Gaunt,
		Human,
		Long,
		Lupine,
		Monstrous,
		Overbite,
		Rugged,
		Scruffy,
		Short,
		Smooth
	}

	public enum EHairstyleType
	{
		None,
		Androgynous,
		Fin,
		Long,
		Mane,
		Mohawk,
		Plates,
		Plume,
		Ponytail,
		Shaggy,
		Spikes,
		Trimmed
	}

	public enum EFringeType
	{
		None,
		Androgynous,
		Long,
		Ponytail,
		Shaggy,
		Trimmed
	}

	public enum EFeetType
	{
		Beast,
		Grasping,
		Hooves,
		Humanoid,
		Large,
		Soft
	}

	public enum ETailType
	{
		None,
		BushyOne,
		BushyTwo,
		Curled,
		Docked,
		Noodle,
		Plume,
		Stout,
		Thick,
		Thin,
		Tuft
	}

	public enum ECockType
	{
		None,
		Cut,
		Knotted,
		Sheath,
		Slit,
		Thor,
		Uncut
	}

	public enum EBallsType
	{
		None,
		Coinpurse,
		Full,
		Round,
		Scruffy
	}

	public enum EBreastsType
	{
		None,
		ACup,
		BCup,
		CCup,
		DCup
	}

	[Flags]
	public enum EPhoneContacts
	{
		None = 0,
		Coby = 1,
		Jax = 2,
		Seth = 4,
		Skye = 8,
		Dustin = 0x10,
		Zenith = 0x20,
		Mercy = 0x40,
		Remy = 0x80,
		Lex = 0x100
	}

	[JsonProperty("Name")]
	public string Name { get; set; }

	[JsonProperty("BodyType")]
	public EBodyType BodyType { get; set; }

	[JsonProperty("BodyColor")]
	public Color BodyColor { get; set; }

	[JsonProperty("ShowNails")]
	public bool ShowNails { get; set; }

	[JsonProperty("NailColor")]
	public Color NailColor { get; set; }

	[JsonProperty("HeadType")]
	public EHeadType HeadType { get; set; }

	[JsonProperty("HeadColor")]
	public Color HeadColor { get; set; }

	[JsonProperty("PaperBagColor")]
	public Color PaperBagColor { get; set; }

	[JsonProperty("PaperBagEyesColor")]
	public Color PaperBagEyesColor { get; set; }

	[JsonProperty("HeadMarkingsType")]
	public EHeadMarkingsType HeadMarkingsType { get; set; }

	[JsonProperty("HeadGauntColor")]
	public Color HeadGauntColor { get; set; }

	[JsonProperty("HeadScruffyColor")]
	public Color HeadScruffyColor { get; set; }

	[JsonProperty("HeadSnoutColor")]
	public Color HeadSnoutColor { get; set; }

	[JsonProperty("HeadStripesColor")]
	public Color HeadStripesColor { get; set; }

	[JsonProperty("HeadAccessoriesType")]
	public EHeadAccessoriesType HeadAccessoriesType { get; set; }

	[JsonProperty("HeadHornsColor")]
	public Color HeadHornsColor { get; set; }

	[JsonProperty("EarColor")]
	public Color EarColor { get; set; }

	[JsonProperty("EarInnerColor")]
	public Color EarInnerColor { get; set; }

	[JsonProperty("EyesType")]
	public EEyesType EyesType { get; set; }

	[JsonProperty("EyesBackColor")]
	public Color EyesBackColor { get; set; }

	[JsonProperty("EyesFrontColor")]
	public Color EyesFrontColor { get; set; }

	[JsonProperty("BrowType")]
	public EBrowType BrowType { get; set; }

	[JsonProperty("BrowColor")]
	public Color BrowColor { get; set; }

	[JsonProperty("MuzzleType")]
	public EMuzzleType MuzzleType { get; set; }

	[JsonProperty("MuzzleColor")]
	public Color MuzzleColor { get; set; }

	[JsonProperty("NoseColor")]
	public Color NoseColor { get; set; }

	[JsonProperty("TeethColor")]
	public Color TeethColor { get; set; }

	[JsonProperty("ShowMuzzleHorn")]
	public bool ShowMuzzleHorn { get; set; }

	[JsonProperty("MuzzleHornColor")]
	public Color MuzzleHornColor { get; set; }

	[JsonProperty("ShowMuzzleMask")]
	public bool ShowMuzzleMask { get; set; }

	[JsonProperty("MuzzleMaskColor")]
	public Color MuzzleMaskColor { get; set; }

	[JsonProperty("HairstyleType")]
	public EHairstyleType HairstyleType { get; set; }

	[JsonProperty("HairColor")]
	public Color HairColor { get; set; }

	[JsonProperty("FringeType")]
	public EFringeType FringeType { get; set; }

	[JsonProperty("FringeColor")]
	public Color FringeColor { get; set; }

	[JsonProperty("FeetType")]
	public EFeetType FeetType { get; set; }

	[JsonProperty("FeetColor")]
	public Color FeetColor { get; set; }

	[JsonProperty("TailType")]
	public ETailType TailType { get; set; }

	[JsonProperty("TailColor")]
	public Color TailColor { get; set; }

	[JsonProperty("ShowTailPartOne")]
	public bool ShowTailPartOne { get; set; }

	[JsonProperty("TailPartOneColor")]
	public Color TailPartOneColor { get; set; }

	[JsonProperty("ShowTailPartTwo")]
	public bool ShowTailPartTwo { get; set; }

	[JsonProperty("TailPartTwoColor")]
	public Color TailPartTwoColor { get; set; }

	[JsonProperty("MarkingsType")]
	public EMarkingsType MarkingsType { get; set; }

	[JsonProperty("UnderbellyColor")]
	public Color UnderbellyColor { get; set; }

	[JsonProperty("UnderthighColor")]
	public Color UnderthighColor { get; set; }

	[JsonProperty("StripesColor")]
	public Color StripesColor { get; set; }

	[JsonProperty("LongForearmColor")]
	public Color LongForearmColor { get; set; }

	[JsonProperty("ShortForearmColor")]
	public Color ShortForearmColor { get; set; }

	[JsonProperty("AvianForearmColor")]
	public Color AvianForearmColor { get; set; }

	[JsonProperty("LongShinColor")]
	public Color LongShinColor { get; set; }

	[JsonProperty("ShortShinColor")]
	public Color ShortShinColor { get; set; }

	[JsonProperty("AvianShinColor")]
	public Color AvianShinColor { get; set; }

	[JsonProperty("CockType")]
	public ECockType CockType { get; set; }

	[JsonProperty("GenitaliaColor")]
	public Color GenitaliaColor { get; set; }

	[JsonProperty("GenitaliaFleshColor")]
	public Color GenitaliaFleshColor { get; set; }

	[JsonProperty("BallsType")]
	public EBallsType BallsType { get; set; }

	[JsonProperty("BallsColor")]
	public Color BallsColor { get; set; }

	[JsonProperty("BreastsType")]
	public EBreastsType BreastsType { get; set; }

	[JsonProperty("BreastsColor")]
	public Color BreastsColor { get; set; }

	[JsonProperty("ShowNipples")]
	public bool ShowNipples { get; set; }

	[JsonProperty("NipplesColor")]
	public Color NipplesColor { get; set; }

	[JsonProperty("PhoneColor")]
	public Color PhoneColor { get; set; }

	[JsonProperty("QuestStages")]
	public Dictionary<string, int> QuestStages { get; private set; }

	[JsonProperty("Contacts")]
	public EPhoneContacts Contacts { get; private set; }

	[JsonProperty("DisabledContacts")]
	public EPhoneContacts DisabledContacts { get; private set; }

	[JsonProperty("Flags")]
	public Dictionary<string, bool> Flags { get; private set; }

	[JsonProperty("Messages")]
	public List<PhoneMessage> Messages { get; private set; }

	public PlayerData()
	{
		QuestStages = new Dictionary<string, int>();
		Flags = new Dictionary<string, bool>();
		Messages = new List<PhoneMessage>();
		ResetProgression();
	}

	public void Reset()
	{
		ResetPlayer();
		ResetProgression();
	}

	public void ResetPlayer()
	{
		Name = string.Empty;
		BodyType = EBodyType.Lean;
		BodyColor = Color.White;
		ShowNails = false;
		NailColor = Color.White;
		HeadType = EHeadType.Default;
		HeadColor = Color.White;
		PaperBagColor = Color.White;
		PaperBagEyesColor = Color.White;
		HeadMarkingsType = EHeadMarkingsType.None;
		HeadGauntColor = Color.White;
		HeadScruffyColor = Color.White;
		HeadSnoutColor = Color.White;
		HeadStripesColor = Color.White;
		HeadAccessoriesType = EHeadAccessoriesType.None;
		HeadHornsColor = Color.White;
		EarColor = Color.White;
		EarInnerColor = Color.White;
		EyesType = EEyesType.Neutral;
		EyesBackColor = Color.White;
		EyesFrontColor = Color.White;
		BrowType = EBrowType.None;
		BrowColor = Color.White;
		MuzzleType = EMuzzleType.Short;
		MuzzleColor = Color.White;
		NoseColor = Color.White;
		TeethColor = Color.White;
		ShowMuzzleHorn = false;
		MuzzleHornColor = Color.White;
		ShowMuzzleMask = false;
		MuzzleMaskColor = Color.White;
		HairstyleType = EHairstyleType.None;
		HairColor = Color.White;
		FringeType = EFringeType.None;
		FringeColor = Color.White;
		FeetType = EFeetType.Beast;
		FeetColor = Color.White;
		TailType = ETailType.None;
		TailColor = Color.White;
		ShowTailPartOne = false;
		TailPartOneColor = Color.White;
		ShowTailPartTwo = false;
		TailPartTwoColor = Color.White;
		MarkingsType = EMarkingsType.None;
		UnderbellyColor = Color.White;
		UnderthighColor = Color.White;
		StripesColor = Color.White;
		LongForearmColor = Color.White;
		ShortForearmColor = Color.White;
		AvianForearmColor = Color.White;
		LongShinColor = Color.White;
		ShortShinColor = Color.White;
		AvianShinColor = Color.White;
		CockType = ECockType.None;
		GenitaliaColor = Color.White;
		GenitaliaFleshColor = Color.White;
		BallsType = EBallsType.None;
		BallsColor = Color.White;
		BreastsType = EBreastsType.None;
		BreastsColor = Color.White;
		ShowNipples = false;
		NipplesColor = Color.White;
		PhoneColor = Color.White;
	}

	public void ResetProgression()
	{
		QuestStages.Clear();
		Contacts = EPhoneContacts.None;
		DisabledContacts = EPhoneContacts.None;
		Flags.Clear();
	}

	public int GetDecimal(string string_0)
	{
		if (!QuestStages.ContainsKey(string_0))
		{
			SetDecimal(string_0, 10);
			return 10;
		}
		return QuestStages[string_0];
	}

	public void SetDecimal(string string_0, int int_0)
	{
		if (string_0 != null)
		{
			QuestStages[string_0] = int_0;
		}
	}

	public void AddContact(EPhoneContacts ephoneContacts_0)
	{
		if (!Contacts.HasFlag(ephoneContacts_0))
		{
			Contacts |= ephoneContacts_0;
		}
	}

	public void ResetContact(EPhoneContacts ephoneContacts_0)
	{
		if (Contacts.HasFlag(ephoneContacts_0))
		{
			Contacts &= ~ephoneContacts_0;
		}
		if (!DisabledContacts.HasFlag(ephoneContacts_0))
		{
			DisabledContacts |= ephoneContacts_0;
		}
	}

	public void ResetDeletedContacts()
	{
		DisabledContacts = EPhoneContacts.None;
	}

	public int GetContactCount()
	{
		int num = 0;
		foreach (object value in Enum.GetValues(typeof(EPhoneContacts)))
		{
			if (!value.Equals(EPhoneContacts.None) && Contacts.HasFlag((EPhoneContacts)value))
			{
				num++;
			}
		}
		return num;
	}

	public bool GetBit(string string_0)
	{
		if (!Flags.ContainsKey(string_0))
		{
			return HasChanged(string_0);
		}
		return Flags[string_0];
	}

	private bool HasChanged(string string_0)
	{
		if (string_0.StartsWith("Player."))
		{
			string[] array = string_0.Split(new char[1] { '.' });
			if (array.Length > 2)
			{
				EBodyType result4;
				if (!(array[1] == "Body"))
				{
					EBreastsType result3;
					if (!(array[1] == "Breasts"))
					{
						ECockType result2;
						if (!(array[1] == "Cock"))
						{
							if (array[1] == "Balls")
							{
								if (Enum.TryParse<EBallsType>(array[2], out var result))
								{
									return BallsType == result;
								}
							}
							else if (array[1] == "Outfit")
							{
								return array[2] == "Simple";
							}
						}
						else if (Enum.TryParse<ECockType>(array[2], out result2))
						{
							return CockType == result2;
						}
					}
					else if (Enum.TryParse<EBreastsType>(array[2], out result3))
					{
						return BreastsType == result3;
					}
				}
				else if (Enum.TryParse<EBodyType>(array[2], out result4))
				{
					return BodyType == result4;
				}
			}
		}
		else if (string_0.StartsWith("Quests."))
		{
			string[] array2 = string_0.Split(new char[1] { '.' });
			if (array2.Length > 2 && int.TryParse(array2[2], out var result5))
			{
				return GetDecimal(array2[1]) == result5;
			}
		}
		return string_0 switch
		{
			"PlayerChubby" => BodyType == EBodyType.Chubby, 
			"PlayerLean" => BodyType == EBodyType.Lean, 
			"HasBreasts" => BreastsType != EBreastsType.None, 
			"PlayerMuscular" => BodyType == EBodyType.Muscular, 
			"PlayerTwinky" => BodyType == EBodyType.Twinky, 
			_ => false, 
		};
	}

	public void SetBit(string string_0, bool bool_0)
	{
		if (string_0.StartsWith("Player."))
		{
			string[] array = string_0.Split(new char[1] { '.' });
			if (array.Length > 2)
			{
				if (array[1] == "Body" || array[1] == "Breasts" || array[1] == "Cock" || array[1] == "Balls")
				{
					throw new Exception("Reserved flag set!");
				}
				if (array[1] == "Outfit")
				{
					Flags.Keys.Where((string string_0) => string_0.StartsWith("Player.Outfit.")).ToList().ForEach(delegate(string string_0)
					{
						Flags.Remove(string_0);
					});
				}
			}
		}
		Flags[string_0] = bool_0;
	}

	public void Remove(string string_0, bool bool_0 = true)
	{
		Flags.Keys.Where((string string_1) => (!bool_0) ? (string_0 == string_1) : string_1.StartsWith(string_0)).ToList().ForEach(delegate(string string_0)
		{
			Flags.Remove(string_0);
		});
	}
}
