using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Newtonsoft.Json;

public class _opIJo2jLUqdOL5yAFP4yzXce0DG : _H2569zioKERtUkpADGx7Vb8aOJl
{
	public enum EBodyType
	{
		Chubby,
		Lean,
		Muscular,
		Twinky
	}

	[Flags]
	public enum _VzIdKOJ1Gq1YccwwHcwhrVV5V4U
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
	public enum _iDe3W6qb7jKTPuJV79yf2i7UoIq
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

	[Serializable]
	[CompilerGenerated]
	private sealed class _0sDtzIDsyA0r9WSGUGpY2WTEdUj
	{
		public static readonly _0sDtzIDsyA0r9WSGUGpY2WTEdUj _003C_003E9 = new _0sDtzIDsyA0r9WSGUGpY2WTEdUj();

		public static Func<string, bool> _003C_003E9__300_0;

		internal bool _sKQKx71rfMlEGGCBet4oVSSys1A(string string_0)
		{
			return _0sDtzIDsyA0r9WSGUGpY2WTEdUj.smethod_0(string_0, "Player.Outfit.");
		}

		static bool smethod_0(string string_0, string string_1)
		{
			return string_0.StartsWith(string_1);
		}
	}

	[CompilerGenerated]
	private sealed class _fU7pDGlGNq6EDvpigVdMzOpE2pkb
	{
		public bool _1DzAfBEb14L1dIDs9OVbFZ8lYJD;

		public string _6ASPaeAeh8vdl643GgyWe0mG0a0;

		public _opIJo2jLUqdOL5yAFP4yzXce0DG _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA;

		internal bool _Y7joCM8kd5WrtAyQOTuG6a5ixjk(string string_0)
		{
			if (!_1DzAfBEb14L1dIDs9OVbFZ8lYJD)
			{
				return _fU7pDGlGNq6EDvpigVdMzOpE2pkb.smethod_0(string_0, _6ASPaeAeh8vdl643GgyWe0mG0a0);
			}
			return _fU7pDGlGNq6EDvpigVdMzOpE2pkb.smethod_1(string_0, _6ASPaeAeh8vdl643GgyWe0mG0a0);
		}

		internal void _3uTshCsyDhL2cJyhUUEzrD5HdTb(string string_0)
		{
			_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Cs2b43EFDtJdhoWWSmCcssGUmHZA.Remove(string_0);
		}

		static bool smethod_0(string string_0, string string_1)
		{
			return string_0 == string_1;
		}

		static bool smethod_1(string string_0, string string_1)
		{
			return string_0.StartsWith(string_1);
		}
	}

	[JsonProperty("Name")]
	public string _RB8fRXeQvK5vs7JEA0XfVCEpg1i { get; set; }

	[JsonProperty("BodyType")]
	public EBodyType _8CtoV1bqn0CwCzb1tuoNppBt0Gg { get; set; }

	[JsonProperty("BodyColor")]
	public Color _6f1rvTENt5XWmHTE22zxBIwbH9G { get; set; }

	[JsonProperty("ShowNails")]
	public bool _VmNLhqrIwSnE6JnCYiBcxnSqnEV { get; set; }

	[JsonProperty("NailColor")]
	public Color _in5HHYmrdLTFpkgc8aimJpXqAXB { get; set; }

	[JsonProperty("HeadType")]
	public EHeadType _UjtZovBCLAtBZnUfbTvRFsaf5mx { get; set; }

	[JsonProperty("HeadColor")]
	public Color _1qfGl3Oc2JyQEpnQtdOxMeMkqhi { get; set; }

	[JsonProperty("PaperBagColor")]
	public Color _VWdlqWB4z2wNtm197Oiv32QGVbE { get; set; }

	[JsonProperty("PaperBagEyesColor")]
	public Color _sbSAaAmkhONcFX6f0JtHbVQbEfG { get; set; }

	[JsonProperty("HeadMarkingsType")]
	public _iDe3W6qb7jKTPuJV79yf2i7UoIq _SnnHu3P4lDDxgkL6cuUt7y07yxG { get; set; }

	[JsonProperty("HeadGauntColor")]
	public Color _Fn7Kt1UvxcXOmJ1gIeWdJnRbaQt { get; set; }

	[JsonProperty("HeadScruffyColor")]
	public Color _WvoLJ4MA4gYEsgOmmIQvfK3xFlu { get; set; }

	[JsonProperty("HeadSnoutColor")]
	public Color _lUyqwDvFCoXEZ6VM9PVCQ970jps { get; set; }

	[JsonProperty("HeadStripesColor")]
	public Color _qKGefHxdjIUD6ObjxrxnLwbBEsh { get; set; }

	[JsonProperty("HeadAccessoriesType")]
	public EHeadAccessoriesType _pmr0FnBBvgaggpusBKMWplUa63c { get; set; }

	[JsonProperty("HeadHornsColor")]
	public Color _9b2asKZDwVM1TcSfmfeFCuk0TJZb { get; set; }

	[JsonProperty("EarColor")]
	public Color _vUhBAXEgvpGKopOUkDJFoc4EYQ3 { get; set; }

	[JsonProperty("EarInnerColor")]
	public Color _uaBF7rEib15d42vH8AzoXWFMMkE { get; set; }

	[JsonProperty("EyesType")]
	public EEyesType _c0ThYURHAGN0Wzlzw9Ibh3Z8qyo { get; set; }

	[JsonProperty("EyesBackColor")]
	public Color _GXnDb1oaJlPbAQV2mjAwCQFK0nmb { get; set; }

	[JsonProperty("EyesFrontColor")]
	public Color _0K4lcN7iwo5q0iP1YlkpY9GdayR { get; set; }

	[JsonProperty("BrowType")]
	public EBrowType _KBOJ0qhM8C5evPQxibgX74m2WHg { get; set; }

	[JsonProperty("BrowColor")]
	public Color _HRPv5rzDY5zNiP4NADDEGhrzGTe { get; set; }

	[JsonProperty("MuzzleType")]
	public EMuzzleType _4QUr9lDqmNxEuy7B4xgb7Lj1HU0 { get; set; }

	[JsonProperty("MuzzleColor")]
	public Color _VsEYbNSam3IFYYWY4QC2lb4ia61 { get; set; }

	[JsonProperty("NoseColor")]
	public Color _y1SiMmRVXWDhDtY17knDpitt46F { get; set; }

	[JsonProperty("TeethColor")]
	public Color _T98drEOtEEZKeB5tXzsuPrhb5Xk { get; set; }

	[JsonProperty("ShowMuzzleHorn")]
	public bool _hkFDGB5pWIuOVcIyDAFqHrDdSpjA { get; set; }

	[JsonProperty("MuzzleHornColor")]
	public Color _q2iDxJYfqribHB1bD8aSkSjqrfnA { get; set; }

	[JsonProperty("ShowMuzzleMask")]
	public bool _UAZhvJ3a9BGOBM0CLiDkKLwUFC9 { get; set; }

	[JsonProperty("MuzzleMaskColor")]
	public Color _phJrpk3rql5MfNJxPQ9X7nC8aAk { get; set; }

	[JsonProperty("HairstyleType")]
	public EHairstyleType _03h2I0mTkGTzIA5R48rgwJh7JZA { get; set; }

	[JsonProperty("HairColor")]
	public Color _bJmvnPs69aVDXxG48lmruYZFHKt { get; set; }

	[JsonProperty("FringeType")]
	public EFringeType _fzMbZCCd7imnrcrYWkSj5u8UZ2J { get; set; }

	[JsonProperty("FringeColor")]
	public Color _EvdUMrkAAdTeMv6fOpGrOLCAMq8A { get; set; }

	[JsonProperty("FeetType")]
	public EFeetType _LZ8c6hRMRYKjnlLOPhbZHcWqUGG { get; set; }

	[JsonProperty("FeetColor")]
	public Color _LZfuQybASevOsCykEWqdvA5GqUF { get; set; }

	[JsonProperty("TailType")]
	public ETailType _NrFEKLWh80bQXi9PujCBTqm01AA { get; set; }

	[JsonProperty("TailColor")]
	public Color _qsK1J3jktKH3eJ2i8sL1oaxXtLc { get; set; }

	[JsonProperty("ShowTailPartOne")]
	public bool _PVQfhwHODkR6bzHmfeCK4L8riIG { get; set; }

	[JsonProperty("TailPartOneColor")]
	public Color _62dl1HYYkor3TZL58k5Y33Tj83 { get; set; }

	[JsonProperty("ShowTailPartTwo")]
	public bool _tEXwTuSRSq5JaaFE4W8edEHxS9q { get; set; }

	[JsonProperty("TailPartTwoColor")]
	public Color _LufmRsAZrlyDgRKYocQXPzANMaF { get; set; }

	[JsonProperty("MarkingsType")]
	public _VzIdKOJ1Gq1YccwwHcwhrVV5V4U _Mz7LwHZqoGBscApFXmff1kEQnGY { get; set; }

	[JsonProperty("UnderbellyColor")]
	public Color _PeK36AvFxEQCvX3fS62hNV7rpuJ { get; set; }

	[JsonProperty("UnderthighColor")]
	public Color _zBv1cYqPRU7uDCALpBlBSgObUcbA { get; set; }

	[JsonProperty("StripesColor")]
	public Color _TxfCqloeyiHpsXka6B46iqCZNsZ { get; set; }

	[JsonProperty("LongForearmColor")]
	public Color _1ZKGQXLRAHEJR8v7jhlDsyOVLcz { get; set; }

	[JsonProperty("ShortForearmColor")]
	public Color _8rDSn6e9Ip9WdOogjhIn8YlL1oM { get; set; }

	[JsonProperty("AvianForearmColor")]
	public Color _FrsyMDX7TebzFk8nSLTyRDPi1QH { get; set; }

	[JsonProperty("LongShinColor")]
	public Color _cUtgkG5qDvgFmI8c29I9xsLVNON { get; set; }

	[JsonProperty("ShortShinColor")]
	public Color _LcOPiDaC2j5vzxOEYhvW4vRoaRX { get; set; }

	[JsonProperty("AvianShinColor")]
	public Color _meyNS02iTIxo212B6c5eoKns2wj { get; set; }

	[JsonProperty("CockType")]
	public ECockType _rtyJgfViJdXL2Ela5APpDlk99dI { get; set; }

	[JsonProperty("GenitaliaColor")]
	public Color _XnNREK59QnV1onFFWfSUaS9WK0E { get; set; }

	[JsonProperty("GenitaliaFleshColor")]
	public Color _o6OnmHi5rZIQPHESokp9rTaO1ei { get; set; }

	[JsonProperty("BallsType")]
	public EBallsType _7OCMpsMmozHsAG0GDljMMAlGLJBA { get; set; }

	[JsonProperty("BallsColor")]
	public Color _8qQ7XVlyRYW4icBFxPQCJqgueYD { get; set; }

	[JsonProperty("BreastsType")]
	public EBreastsType _BCncLn6BIYiBX6NdFByAquBYGpH { get; set; }

	[JsonProperty("BreastsColor")]
	public Color _pigzqi6DgcSToQkL9g7Ns2QrLfp { get; set; }

	[JsonProperty("ShowNipples")]
	public bool _Q2AbpMWcrhtCW9MLTtT5gwoleu7 { get; set; }

	[JsonProperty("NipplesColor")]
	public Color _2yydfEIrSiLPTti2dT8JXGoIaM3 { get; set; }

	[JsonProperty("PhoneColor")]
	public Color _uOkbmfW26QVAvyEMQakki9kTMDbA { get; set; }

	[JsonProperty("QuestStages")]
	public Dictionary<string, int> _mPwD8DvxbNkq8fBcmlHJ80kVkB2 { get; private set; }

	[JsonProperty("Contacts")]
	public EPhoneContacts _4pE8Q2fYoSeltAUx7pxshukqsEb { get; private set; }

	[JsonProperty("DisabledContacts")]
	public EPhoneContacts _uVBbxOT5AbKoffINIsfdTnEGd3xA { get; private set; }

	[JsonProperty("Flags")]
	public Dictionary<string, bool> _Cs2b43EFDtJdhoWWSmCcssGUmHZA { get; private set; }

	[JsonProperty("Messages")]
	public List<_iDN1IKOu3e1uADYzeMEUon5D9fg> _7u6aevGWBE7ABqrBXoaPTkywcVo { get; private set; }

	public _opIJo2jLUqdOL5yAFP4yzXce0DG()
	{
		while (true)
		{
			int num = -1639983698;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA9A99C4Du) % 6u)
				{
				case 4u:
					_7u6aevGWBE7ABqrBXoaPTkywcVo = new List<_iDN1IKOu3e1uADYzeMEUon5D9fg>();
					num = ((int)num2 * -977341634) ^ -546309715;
					continue;
				case 3u:
					_Cs2b43EFDtJdhoWWSmCcssGUmHZA = new Dictionary<string, bool>();
					num = ((int)num2 * -1771036095) ^ -555740450;
					continue;
				case 2u:
					_Rj5BZHY1n3a8XV7jJAk9U8jZZ6m();
					num = ((int)num2 * -466449970) ^ 0x3B6C6A45;
					continue;
				case 1u:
					_mPwD8DvxbNkq8fBcmlHJ80kVkB2 = new Dictionary<string, int>();
					num = (int)((num2 * 1368119401) ^ 0x1A4105FD);
					continue;
				default:
					return;
				case 5u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public void _Rj5BZHY1n3a8XV7jJAk9U8jZZ6m()
	{
		_XDbzWLxDi2VVrJQrjjLsgcfdxju();
		_haICL4qkfkOLhPhofWQH1GmjZx5();
	}

	public void _XDbzWLxDi2VVrJQrjjLsgcfdxju()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		_RB8fRXeQvK5vs7JEA0XfVCEpg1i = string.Empty;
		while (true)
		{
			int num = 123418862;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7F954CFAu) % 40u)
				{
				case 39u:
					_1ZKGQXLRAHEJR8v7jhlDsyOVLcz = Color.get_White();
					num = ((int)num2 * -1587168358) ^ -746605410;
					continue;
				case 38u:
					_phJrpk3rql5MfNJxPQ9X7nC8aAk = Color.get_White();
					num = (int)((num2 * 465236044) ^ 0x3B7FE97F);
					continue;
				case 37u:
					_UAZhvJ3a9BGOBM0CLiDkKLwUFC9 = false;
					num = (int)(num2 * 1136189718) ^ -1829122518;
					continue;
				case 36u:
					_WvoLJ4MA4gYEsgOmmIQvfK3xFlu = Color.get_White();
					num = (int)((num2 * 1082596288) ^ 0x1C2FD401);
					continue;
				case 35u:
					_lUyqwDvFCoXEZ6VM9PVCQ970jps = Color.get_White();
					num = ((int)num2 * -1889761130) ^ -668627111;
					continue;
				case 34u:
					_62dl1HYYkor3TZL58k5Y33Tj83 = Color.get_White();
					num = (int)((num2 * 1688193040) ^ 0x5D2FBEBB);
					continue;
				case 33u:
					_LZ8c6hRMRYKjnlLOPhbZHcWqUGG = EFeetType.Beast;
					num = ((int)num2 * -186227269) ^ -713410803;
					continue;
				case 32u:
					_KBOJ0qhM8C5evPQxibgX74m2WHg = EBrowType.None;
					_HRPv5rzDY5zNiP4NADDEGhrzGTe = Color.get_White();
					_4QUr9lDqmNxEuy7B4xgb7Lj1HU0 = EMuzzleType.Short;
					num = (int)((num2 * 2040660218) ^ 0xD4A06AD);
					continue;
				case 31u:
					_8qQ7XVlyRYW4icBFxPQCJqgueYD = Color.get_White();
					num = ((int)num2 * -1235037751) ^ 0x266DA90F;
					continue;
				case 30u:
					_0K4lcN7iwo5q0iP1YlkpY9GdayR = Color.get_White();
					num = ((int)num2 * -257825386) ^ -1897408946;
					continue;
				case 29u:
					_Fn7Kt1UvxcXOmJ1gIeWdJnRbaQt = Color.get_White();
					num = ((int)num2 * -1637641984) ^ 0x3A10B146;
					continue;
				case 28u:
					_c0ThYURHAGN0Wzlzw9Ibh3Z8qyo = EEyesType.Neutral;
					_GXnDb1oaJlPbAQV2mjAwCQFK0nmb = Color.get_White();
					num = (int)(num2 * 838253989) ^ -2143509040;
					continue;
				case 27u:
					_q2iDxJYfqribHB1bD8aSkSjqrfnA = Color.get_White();
					num = (int)((num2 * 1992041775) ^ 0x2336731A);
					continue;
				case 26u:
					_8rDSn6e9Ip9WdOogjhIn8YlL1oM = Color.get_White();
					_FrsyMDX7TebzFk8nSLTyRDPi1QH = Color.get_White();
					_cUtgkG5qDvgFmI8c29I9xsLVNON = Color.get_White();
					num = ((int)num2 * -172985963) ^ -1714811316;
					continue;
				case 25u:
					_qKGefHxdjIUD6ObjxrxnLwbBEsh = Color.get_White();
					_pmr0FnBBvgaggpusBKMWplUa63c = EHeadAccessoriesType.None;
					_9b2asKZDwVM1TcSfmfeFCuk0TJZb = Color.get_White();
					num = ((int)num2 * -3260685) ^ -1842194414;
					continue;
				case 24u:
					_7OCMpsMmozHsAG0GDljMMAlGLJBA = EBallsType.None;
					num = ((int)num2 * -2085053141) ^ -1524409379;
					continue;
				case 23u:
					_pigzqi6DgcSToQkL9g7Ns2QrLfp = Color.get_White();
					num = (int)(num2 * 1376490994) ^ -1522433681;
					continue;
				case 22u:
					_o6OnmHi5rZIQPHESokp9rTaO1ei = Color.get_White();
					num = (int)((num2 * 884676337) ^ 0x13EC121C);
					continue;
				case 21u:
					_03h2I0mTkGTzIA5R48rgwJh7JZA = EHairstyleType.None;
					num = (int)((num2 * 190556637) ^ 0x5FFC8F5E);
					continue;
				case 20u:
					_LZfuQybASevOsCykEWqdvA5GqUF = Color.get_White();
					_NrFEKLWh80bQXi9PujCBTqm01AA = ETailType.None;
					_qsK1J3jktKH3eJ2i8sL1oaxXtLc = Color.get_White();
					_PVQfhwHODkR6bzHmfeCK4L8riIG = false;
					num = ((int)num2 * -1281343602) ^ 0x3772970;
					continue;
				case 19u:
					_Q2AbpMWcrhtCW9MLTtT5gwoleu7 = false;
					num = ((int)num2 * -1090019274) ^ -954606954;
					continue;
				case 18u:
					_fzMbZCCd7imnrcrYWkSj5u8UZ2J = EFringeType.None;
					_EvdUMrkAAdTeMv6fOpGrOLCAMq8A = Color.get_White();
					num = ((int)num2 * -1085879532) ^ -675827549;
					continue;
				case 17u:
					_Mz7LwHZqoGBscApFXmff1kEQnGY = _VzIdKOJ1Gq1YccwwHcwhrVV5V4U.None;
					num = (int)(num2 * 340729746) ^ -35024585;
					continue;
				case 15u:
					_PeK36AvFxEQCvX3fS62hNV7rpuJ = Color.get_White();
					num = (int)((num2 * 2011206147) ^ 0x7BA83379);
					continue;
				case 14u:
					_2yydfEIrSiLPTti2dT8JXGoIaM3 = Color.get_White();
					num = (int)((num2 * 1254478539) ^ 0xDBDA21B);
					continue;
				case 13u:
					_VmNLhqrIwSnE6JnCYiBcxnSqnEV = false;
					_in5HHYmrdLTFpkgc8aimJpXqAXB = Color.get_White();
					_UjtZovBCLAtBZnUfbTvRFsaf5mx = EHeadType.Default;
					_1qfGl3Oc2JyQEpnQtdOxMeMkqhi = Color.get_White();
					num = ((int)num2 * -377251003) ^ -547965463;
					continue;
				case 12u:
					_8CtoV1bqn0CwCzb1tuoNppBt0Gg = EBodyType.Lean;
					_6f1rvTENt5XWmHTE22zxBIwbH9G = Color.get_White();
					num = ((int)num2 * -82091626) ^ -620369313;
					continue;
				case 11u:
					_vUhBAXEgvpGKopOUkDJFoc4EYQ3 = Color.get_White();
					_uaBF7rEib15d42vH8AzoXWFMMkE = Color.get_White();
					num = ((int)num2 * -1449310563) ^ -828424319;
					continue;
				case 10u:
					_VWdlqWB4z2wNtm197Oiv32QGVbE = Color.get_White();
					num = ((int)num2 * -2088183743) ^ 0x1E2608A9;
					continue;
				case 9u:
					_sbSAaAmkhONcFX6f0JtHbVQbEfG = Color.get_White();
					_SnnHu3P4lDDxgkL6cuUt7y07yxG = _iDe3W6qb7jKTPuJV79yf2i7UoIq.None;
					num = (int)(num2 * 675032629) ^ -1214479742;
					continue;
				case 8u:
					_TxfCqloeyiHpsXka6B46iqCZNsZ = Color.get_White();
					num = (int)(num2 * 28141722) ^ -940226347;
					continue;
				case 7u:
					_VsEYbNSam3IFYYWY4QC2lb4ia61 = Color.get_White();
					_y1SiMmRVXWDhDtY17knDpitt46F = Color.get_White();
					_T98drEOtEEZKeB5tXzsuPrhb5Xk = Color.get_White();
					_hkFDGB5pWIuOVcIyDAFqHrDdSpjA = false;
					num = (int)(num2 * 493498529) ^ -872060578;
					continue;
				case 6u:
					_zBv1cYqPRU7uDCALpBlBSgObUcbA = Color.get_White();
					num = (int)((num2 * 1481285059) ^ 0x1657AE40);
					continue;
				case 5u:
					_bJmvnPs69aVDXxG48lmruYZFHKt = Color.get_White();
					num = (int)(num2 * 2119622341) ^ -806969279;
					continue;
				case 4u:
					_LcOPiDaC2j5vzxOEYhvW4vRoaRX = Color.get_White();
					_meyNS02iTIxo212B6c5eoKns2wj = Color.get_White();
					_rtyJgfViJdXL2Ela5APpDlk99dI = ECockType.None;
					_XnNREK59QnV1onFFWfSUaS9WK0E = Color.get_White();
					num = ((int)num2 * -1869197618) ^ 0x4C9A07E4;
					continue;
				case 3u:
					_uOkbmfW26QVAvyEMQakki9kTMDbA = Color.get_White();
					num = ((int)num2 * -1324874616) ^ -686451974;
					continue;
				case 2u:
					_BCncLn6BIYiBX6NdFByAquBYGpH = EBreastsType.None;
					num = (int)(num2 * 553971769) ^ -1980226849;
					continue;
				case 1u:
					_tEXwTuSRSq5JaaFE4W8edEHxS9q = false;
					_LufmRsAZrlyDgRKYocQXPzANMaF = Color.get_White();
					num = ((int)num2 * -102633258) ^ 0x528FC4E5;
					continue;
				default:
					return;
				case 0u:
					break;
				case 16u:
					return;
				}
				break;
			}
		}
	}

	public void _haICL4qkfkOLhPhofWQH1GmjZx5()
	{
		_mPwD8DvxbNkq8fBcmlHJ80kVkB2.Clear();
		_4pE8Q2fYoSeltAUx7pxshukqsEb = EPhoneContacts.None;
		while (true)
		{
			int num = -2113010650;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9899103Cu) % 3u)
				{
				case 1u:
					goto IL_0014;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0014:
				_uVBbxOT5AbKoffINIsfdTnEGd3xA = EPhoneContacts.None;
				_Cs2b43EFDtJdhoWWSmCcssGUmHZA.Clear();
				num = ((int)num2 * -363572869) ^ 0x3704EB57;
			}
		}
	}

	public int _fvTKDuNATrUxfXZVvltePz3vYkK(string string_0)
	{
		if (!_mPwD8DvxbNkq8fBcmlHJ80kVkB2.ContainsKey(string_0))
		{
			while (true)
			{
				int num = 1981709889;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x36B4378Eu) % 4u)
					{
					case 3u:
						_fPyIv5zbbSj5sjZlbAwQTFXnJ5G(string_0, 10);
						num = (int)((num2 * 1433476490) ^ 0x7B11C1C8);
						continue;
					case 2u:
						break;
					case 0u:
						return 10;
					default:
						goto end_IL_0047;
					}
					break;
				}
				continue;
				end_IL_0047:
				break;
			}
		}
		return _mPwD8DvxbNkq8fBcmlHJ80kVkB2[string_0];
	}

	public void _fPyIv5zbbSj5sjZlbAwQTFXnJ5G(string string_0, int int_0)
	{
		if (string_0 == null)
		{
			goto IL_0003;
		}
		goto IL_0027;
		IL_0027:
		_mPwD8DvxbNkq8fBcmlHJ80kVkB2[string_0] = int_0;
		int num = -628601015;
		goto IL_0008;
		IL_0008:
		switch ((uint)(num ^ -1919743857) % 4u)
		{
		case 0u:
			break;
		default:
			return;
		case 1u:
			goto IL_0027;
		case 2u:
			return;
		case 3u:
			return;
		}
		goto IL_0003;
		IL_0003:
		num = -509996784;
		goto IL_0008;
	}

	public void _modEEaw3I1w8Mt0usyRNoa4Ri0H(EPhoneContacts ephoneContacts_0)
	{
		if (_opIJo2jLUqdOL5yAFP4yzXce0DG.smethod_0((Enum)_4pE8Q2fYoSeltAUx7pxshukqsEb, (Enum)ephoneContacts_0))
		{
			goto IL_0018;
		}
		goto IL_003c;
		IL_003c:
		_4pE8Q2fYoSeltAUx7pxshukqsEb |= ephoneContacts_0;
		int num = 1825461872;
		goto IL_001d;
		IL_001d:
		switch ((uint)(num ^ 0x1808A674) % 4u)
		{
		case 2u:
			break;
		default:
			return;
		case 3u:
			goto IL_003c;
		case 0u:
			return;
		case 1u:
			return;
		}
		goto IL_0018;
		IL_0018:
		num = 2028462137;
		goto IL_001d;
	}

	public void _Qd7anWdHpZ5AgaUbbEv07BnnI6Q(EPhoneContacts ephoneContacts_0)
	{
		if (_opIJo2jLUqdOL5yAFP4yzXce0DG.smethod_0((Enum)_4pE8Q2fYoSeltAUx7pxshukqsEb, (Enum)ephoneContacts_0))
		{
			goto IL_002a;
		}
		goto IL_009b;
		IL_009b:
		int num;
		int num2;
		if (!_opIJo2jLUqdOL5yAFP4yzXce0DG.smethod_0((Enum)_uVBbxOT5AbKoffINIsfdTnEGd3xA, (Enum)ephoneContacts_0))
		{
			num = -1975650218;
			num2 = -1975650218;
		}
		else
		{
			num = -7655541;
			num2 = -7655541;
		}
		goto IL_006a;
		IL_006a:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0xE1DB8002u) % 5u)
			{
			case 4u:
				break;
			case 3u:
				_4pE8Q2fYoSeltAUx7pxshukqsEb &= ~ephoneContacts_0;
				num = (int)(num3 * 320988173) ^ -1831544845;
				continue;
			case 1u:
				_uVBbxOT5AbKoffINIsfdTnEGd3xA |= ephoneContacts_0;
				num = (int)((num3 * 1852244296) ^ 0x3E9D042B);
				continue;
			default:
				return;
			case 0u:
				goto IL_009b;
			case 2u:
				return;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		num = -1489763783;
		goto IL_006a;
	}

	public void _Xwcp3PcmrSeqc3MSVH0tfLbcwXA()
	{
		_uVBbxOT5AbKoffINIsfdTnEGd3xA = EPhoneContacts.None;
	}

	public int _X1b0dyIzsSyKwqWd3usrbDfKJAk()
	{
		int num = 0;
		IEnumerator enumerator = _opIJo2jLUqdOL5yAFP4yzXce0DG.smethod_3(_opIJo2jLUqdOL5yAFP4yzXce0DG.smethod_2(_opIJo2jLUqdOL5yAFP4yzXce0DG.smethod_1(typeof(EPhoneContacts).TypeHandle)));
		try
		{
			object obj = default(object);
			while (true)
			{
				int num2;
				int num3;
				if (_opIJo2jLUqdOL5yAFP4yzXce0DG.smethod_6(enumerator))
				{
					num2 = 1189111051;
					num3 = 1189111051;
				}
				else
				{
					num2 = 1644633524;
					num3 = 1644633524;
				}
				while (true)
				{
					uint num4;
					switch ((num4 = (uint)num2 ^ 0x66EED09Fu) % 7u)
					{
					case 5u:
						num2 = 1189111051;
						continue;
					case 4u:
						num++;
						num2 = ((int)num4 * -1874523545) ^ -319662211;
						continue;
					case 2u:
					{
						int num7;
						int num8;
						if (!_opIJo2jLUqdOL5yAFP4yzXce0DG.smethod_0((Enum)_4pE8Q2fYoSeltAUx7pxshukqsEb, (Enum)(EPhoneContacts)obj))
						{
							num7 = 39656396;
							num8 = 39656396;
						}
						else
						{
							num7 = 583522632;
							num8 = 583522632;
						}
						num2 = num7 ^ ((int)num4 * -1042270086);
						continue;
					}
					case 1u:
						obj = _opIJo2jLUqdOL5yAFP4yzXce0DG.smethod_4(enumerator);
						num2 = 2019426398;
						continue;
					case 0u:
					{
						int num5;
						int num6;
						if (!_opIJo2jLUqdOL5yAFP4yzXce0DG.smethod_5(obj, (object)EPhoneContacts.None))
						{
							num5 = 660734873;
							num6 = 660734873;
						}
						else
						{
							num5 = 1806599120;
							num6 = 1806599120;
						}
						num2 = num5 ^ (int)(num4 * 1104930112);
						continue;
					}
					case 6u:
						break;
					default:
						return num;
					case 3u:
						return num;
					}
					break;
				}
			}
		}
		finally
		{
			IDisposable disposable = enumerator as IDisposable;
			while (true)
			{
				IL_0176:
				int num9 = 279368762;
				while (true)
				{
					uint num4;
					switch ((num4 = (uint)num9 ^ 0x66EED09Fu) % 4u)
					{
					case 2u:
						_opIJo2jLUqdOL5yAFP4yzXce0DG.smethod_7(disposable);
						num9 = (int)(num4 * 224654667) ^ -448599127;
						continue;
					case 1u:
					{
						int num10;
						int num11;
						if (disposable != null)
						{
							num10 = -1041390659;
							num11 = -1041390659;
						}
						else
						{
							num10 = -798533297;
							num11 = -798533297;
						}
						num9 = num10 ^ (int)(num4 * 299542904);
						continue;
					}
					default:
						goto end_IL_0154;
					case 3u:
						break;
					case 0u:
						goto end_IL_0154;
					}
					goto IL_0176;
					continue;
					end_IL_0154:
					break;
				}
				break;
			}
		}
	}

	public bool _Oms9lumBodLGrGZ09YJaEuzmlAf(string string_0)
	{
		if (!_Cs2b43EFDtJdhoWWSmCcssGUmHZA.ContainsKey(string_0))
		{
			return _3FWn0wjLhjL8yL0d2zLD5hMVHSV(string_0);
		}
		return _Cs2b43EFDtJdhoWWSmCcssGUmHZA[string_0];
	}

	private bool _3FWn0wjLhjL8yL0d2zLD5hMVHSV(string string_0)
	{
		if (_opIJo2jLUqdOL5yAFP4yzXce0DG.smethod_8(string_0, "Player."))
		{
			goto IL_0152;
		}
		goto IL_043e;
		IL_043e:
		int num;
		int num2;
		if (!_opIJo2jLUqdOL5yAFP4yzXce0DG.smethod_8(string_0, "Quests."))
		{
			num = 1754695320;
			num2 = 1754695320;
		}
		else
		{
			num = 1406356614;
			num2 = 1406356614;
		}
		goto IL_0398;
		IL_0398:
		string[] array2 = default(string[]);
		EBodyType result5 = default(EBodyType);
		string[] array = default(string[]);
		ECockType result4 = default(ECockType);
		EBreastsType result = default(EBreastsType);
		EBallsType result3 = default(EBallsType);
		int result2 = default(int);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0x936AF51u) % 33u)
			{
			case 32u:
			{
				int num6;
				int num7;
				if (!_opIJo2jLUqdOL5yAFP4yzXce0DG.smethod_10(string_0, "HasBreasts"))
				{
					num6 = 1554678989;
					num7 = 1554678989;
				}
				else
				{
					num6 = 570256301;
					num7 = 570256301;
				}
				num = num6 ^ (int)(num3 * 1575278369);
				continue;
			}
			case 31u:
			{
				int num16;
				int num17;
				if (!Enum.TryParse<EBodyType>(array2[2], out result5))
				{
					num16 = -1331877144;
					num17 = -1331877144;
				}
				else
				{
					num16 = -1769914125;
					num17 = -1769914125;
				}
				num = num16 ^ ((int)num3 * -1887448569);
				continue;
			}
			case 29u:
			{
				array2 = _opIJo2jLUqdOL5yAFP4yzXce0DG.smethod_9(string_0, new char[1] { '.' });
				int num8;
				int num9;
				if (array2.Length <= 2)
				{
					num8 = -1562184808;
					num9 = -1562184808;
				}
				else
				{
					num8 = -48266919;
					num9 = -48266919;
				}
				num = num8 ^ (int)(num3 * 1073725987);
				continue;
			}
			case 26u:
			{
				int num26;
				int num27;
				if (array.Length > 2)
				{
					num26 = -1849070708;
					num27 = -1849070708;
				}
				else
				{
					num26 = -103637586;
					num27 = -103637586;
				}
				num = num26 ^ ((int)num3 * -1547640322);
				continue;
			}
			case 25u:
				break;
			case 24u:
			{
				int num18;
				int num19;
				if (!_opIJo2jLUqdOL5yAFP4yzXce0DG.smethod_10(string_0, "PlayerTwinky"))
				{
					num18 = -1317701029;
					num19 = -1317701029;
				}
				else
				{
					num18 = -290529150;
					num19 = -290529150;
				}
				num = num18 ^ ((int)num3 * -1172296904);
				continue;
			}
			case 22u:
				goto end_IL_0398;
			case 21u:
			{
				int num22;
				int num23;
				if (!Enum.TryParse<ECockType>(array2[2], out result4))
				{
					num22 = 1429187752;
					num23 = 1429187752;
				}
				else
				{
					num22 = 906346544;
					num23 = 906346544;
				}
				num = num22 ^ ((int)num3 * -1766986220);
				continue;
			}
			case 20u:
			{
				int num24;
				int num25;
				if (!_opIJo2jLUqdOL5yAFP4yzXce0DG.smethod_10(array2[1], "Body"))
				{
					num24 = 83214485;
					num25 = 83214485;
				}
				else
				{
					num24 = 463325729;
					num25 = 463325729;
				}
				num = num24 ^ ((int)num3 * -1666799188);
				continue;
			}
			case 19u:
			{
				int num14;
				int num15;
				if (Enum.TryParse<EBreastsType>(array2[2], out result))
				{
					num14 = 1208297671;
					num15 = 1208297671;
				}
				else
				{
					num14 = 858441977;
					num15 = 858441977;
				}
				num = num14 ^ ((int)num3 * -710529723);
				continue;
			}
			case 17u:
			{
				int num10;
				int num11;
				if (!Enum.TryParse<EBallsType>(array2[2], out result3))
				{
					num10 = -1013826884;
					num11 = -1013826884;
				}
				else
				{
					num10 = -57002101;
					num11 = -57002101;
				}
				num = num10 ^ (int)(num3 * 2126495034);
				continue;
			}
			case 16u:
				goto IL_0224;
			case 15u:
				goto IL_024e;
			case 14u:
			{
				int num20;
				int num21;
				if (!_opIJo2jLUqdOL5yAFP4yzXce0DG.smethod_10(string_0, "PlayerMuscular"))
				{
					num20 = -1757166841;
					num21 = -1757166841;
				}
				else
				{
					num20 = -123098825;
					num21 = -123098825;
				}
				num = num20 ^ (int)(num3 * 1305954370);
				continue;
			}
			case 9u:
				num = (int)(num3 * 918707266) ^ -1246839342;
				continue;
			case 8u:
				array = _opIJo2jLUqdOL5yAFP4yzXce0DG.smethod_9(string_0, new char[1] { '.' });
				num = (int)((num3 * 1825618926) ^ 0x1960F6D6);
				continue;
			case 7u:
				goto IL_02e6;
			case 6u:
			{
				int num12;
				int num13;
				if (_opIJo2jLUqdOL5yAFP4yzXce0DG.smethod_10(string_0, "PlayerLean"))
				{
					num12 = 1654856729;
					num13 = 1654856729;
				}
				else
				{
					num12 = 486554872;
					num13 = 486554872;
				}
				num = num12 ^ (int)(num3 * 1281318438);
				continue;
			}
			case 3u:
			{
				int num4;
				int num5;
				if (int.TryParse(array[2], out result2))
				{
					num4 = -979562493;
					num5 = -979562493;
				}
				else
				{
					num4 = -863893055;
					num5 = -863893055;
				}
				num = num4 ^ ((int)num3 * -137494325);
				continue;
			}
			case 2u:
				goto IL_0371;
			case 28u:
				goto IL_043e;
			case 0u:
				return _8CtoV1bqn0CwCzb1tuoNppBt0Gg == EBodyType.Muscular;
			case 1u:
				return _8CtoV1bqn0CwCzb1tuoNppBt0Gg == EBodyType.Chubby;
			case 4u:
				return _8CtoV1bqn0CwCzb1tuoNppBt0Gg == EBodyType.Lean;
			case 5u:
				return _8CtoV1bqn0CwCzb1tuoNppBt0Gg == result5;
			default:
				return false;
			case 11u:
				return _rtyJgfViJdXL2Ela5APpDlk99dI == result4;
			case 12u:
				return _7OCMpsMmozHsAG0GDljMMAlGLJBA == result3;
			case 13u:
				return _opIJo2jLUqdOL5yAFP4yzXce0DG.smethod_10(array2[2], "Simple");
			case 18u:
				return _fvTKDuNATrUxfXZVvltePz3vYkK(array[1]) == result2;
			case 23u:
				return _BCncLn6BIYiBX6NdFByAquBYGpH == result;
			case 27u:
				return _8CtoV1bqn0CwCzb1tuoNppBt0Gg == EBodyType.Twinky;
			case 30u:
				return _BCncLn6BIYiBX6NdFByAquBYGpH != EBreastsType.None;
			}
			int num28;
			if (_opIJo2jLUqdOL5yAFP4yzXce0DG.smethod_10(array2[1], "Balls"))
			{
				num = 1120243691;
				num28 = 1120243691;
			}
			else
			{
				num = 652986964;
				num28 = 652986964;
			}
			continue;
			IL_0371:
			int num29;
			if (_opIJo2jLUqdOL5yAFP4yzXce0DG.smethod_10(array2[1], "Outfit"))
			{
				num = 433635688;
				num29 = 433635688;
			}
			else
			{
				num = 1754695320;
				num29 = 1754695320;
			}
			continue;
			IL_024e:
			int num30;
			if (_opIJo2jLUqdOL5yAFP4yzXce0DG.smethod_10(array2[1], "Breasts"))
			{
				num = 303941436;
				num30 = 303941436;
			}
			else
			{
				num = 141916704;
				num30 = 141916704;
			}
			continue;
			IL_0224:
			int num31;
			if (_opIJo2jLUqdOL5yAFP4yzXce0DG.smethod_10(string_0, "PlayerChubby"))
			{
				num = 93169823;
				num31 = 93169823;
			}
			else
			{
				num = 2059172268;
				num31 = 2059172268;
			}
			continue;
			IL_02e6:
			int num32;
			if (!_opIJo2jLUqdOL5yAFP4yzXce0DG.smethod_10(array2[1], "Cock"))
			{
				num = 951911323;
				num32 = 951911323;
			}
			else
			{
				num = 349603661;
				num32 = 349603661;
			}
			continue;
			end_IL_0398:
			break;
		}
		goto IL_0152;
		IL_0152:
		num = 1860839505;
		goto IL_0398;
	}

	public void _4Fscz8ryB3hm0NmL5xw39HHiPd1(string string_0, bool bool_0)
	{
		if (_opIJo2jLUqdOL5yAFP4yzXce0DG.smethod_8(string_0, "Player."))
		{
			goto IL_015a;
		}
		goto IL_01ed;
		IL_01ed:
		_Cs2b43EFDtJdhoWWSmCcssGUmHZA[string_0] = bool_0;
		int num = 1397207529;
		goto IL_01ab;
		IL_01ab:
		string[] array = default(string[]);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x4F74CD2Cu) % 12u)
			{
			case 11u:
				break;
			case 10u:
			{
				int num7;
				int num8;
				if (!_opIJo2jLUqdOL5yAFP4yzXce0DG.smethod_10(array[1], "Breasts"))
				{
					num7 = 1855074418;
					num8 = 1855074418;
				}
				else
				{
					num7 = 377931059;
					num8 = 377931059;
				}
				num = num7 ^ (int)(num2 * 833701850);
				continue;
			}
			case 9u:
			{
				int num11;
				int num12;
				if (!_opIJo2jLUqdOL5yAFP4yzXce0DG.smethod_10(array[1], "Body"))
				{
					num11 = 664799456;
					num12 = 664799456;
				}
				else
				{
					num11 = 334428865;
					num12 = 334428865;
				}
				num = num11 ^ (int)(num2 * 1909063662);
				continue;
			}
			case 8u:
			{
				int num9;
				int num10;
				if (_opIJo2jLUqdOL5yAFP4yzXce0DG.smethod_10(array[1], "Balls"))
				{
					num9 = 286661239;
					num10 = 286661239;
				}
				else
				{
					num9 = 802033391;
					num10 = 802033391;
				}
				num = num9 ^ (int)(num2 * 591750382);
				continue;
			}
			case 6u:
			{
				int num3;
				int num4;
				if (_opIJo2jLUqdOL5yAFP4yzXce0DG.smethod_10(array[1], "Cock"))
				{
					num3 = 859606441;
					num4 = 859606441;
				}
				else
				{
					num3 = 92292162;
					num4 = 92292162;
				}
				num = num3 ^ (int)(num2 * 848469835);
				continue;
			}
			case 4u:
				array = _opIJo2jLUqdOL5yAFP4yzXce0DG.smethod_9(string_0, new char[1] { '.' });
				num = ((int)num2 * -623602116) ^ -309375809;
				continue;
			case 3u:
			{
				int num5;
				int num6;
				if (array.Length <= 2)
				{
					num5 = -1391702534;
					num6 = -1391702534;
				}
				else
				{
					num5 = -1739019490;
					num6 = -1739019490;
				}
				num = num5 ^ ((int)num2 * -152683227);
				continue;
			}
			case 2u:
				goto end_IL_01ab;
			case 0u:
				_Cs2b43EFDtJdhoWWSmCcssGUmHZA.Keys.Where((string string_0) => _0sDtzIDsyA0r9WSGUGpY2WTEdUj.smethod_0(string_0, "Player.Outfit.")).ToList().ForEach(delegate(string string_0)
				{
					_Cs2b43EFDtJdhoWWSmCcssGUmHZA.Remove(string_0);
				});
				num = 1331214693;
				continue;
			default:
				return;
			case 5u:
				goto IL_01ed;
			case 7u:
				throw _opIJo2jLUqdOL5yAFP4yzXce0DG.smethod_11("Reserved flag set!");
			case 1u:
				return;
			}
			int num13;
			if (!_opIJo2jLUqdOL5yAFP4yzXce0DG.smethod_10(array[1], "Outfit"))
			{
				num = 1331214693;
				num13 = 1331214693;
			}
			else
			{
				num = 438937880;
				num13 = 438937880;
			}
			continue;
			end_IL_01ab:
			break;
		}
		goto IL_015a;
		IL_015a:
		num = 2026520420;
		goto IL_01ab;
	}

	public void _aedbmRW9PZZduyLA3PVVHtafNAGA(string string_0, bool bool_0 = true)
	{
		bool _1DzAfBEb14L1dIDs9OVbFZ8lYJD = default(bool);
		string _6ASPaeAeh8vdl643GgyWe0mG0a0 = default(string);
		_opIJo2jLUqdOL5yAFP4yzXce0DG _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA;
		while (true)
		{
			int num = -501896241;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE391732Cu) % 4u)
				{
				case 3u:
					_1DzAfBEb14L1dIDs9OVbFZ8lYJD = bool_0;
					_6ASPaeAeh8vdl643GgyWe0mG0a0 = string_0;
					num = (int)((num2 * 513379809) ^ 0x45153AA1);
					continue;
				case 2u:
					_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = this;
					_Cs2b43EFDtJdhoWWSmCcssGUmHZA.Keys.Where((string string_0) => (!_1DzAfBEb14L1dIDs9OVbFZ8lYJD) ? _fU7pDGlGNq6EDvpigVdMzOpE2pkb.smethod_0(string_0, _6ASPaeAeh8vdl643GgyWe0mG0a0) : _fU7pDGlGNq6EDvpigVdMzOpE2pkb.smethod_1(string_0, _6ASPaeAeh8vdl643GgyWe0mG0a0)).ToList().ForEach(delegate(string string_0)
					{
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Cs2b43EFDtJdhoWWSmCcssGUmHZA.Remove(string_0);
					});
					num = (int)((num2 * 674567617) ^ 0x8E52077);
					continue;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	[CompilerGenerated]
	private void _9LTSGBRKjRMGmdraxA6vqm3u3Uc(string string_0)
	{
		_Cs2b43EFDtJdhoWWSmCcssGUmHZA.Remove(string_0);
	}

	static bool smethod_0(Enum enum_0, Enum enum_1)
	{
		return enum_0.HasFlag(enum_1);
	}

	static Type smethod_1(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static Array smethod_2(Type type_0)
	{
		return Enum.GetValues(type_0);
	}

	static IEnumerator smethod_3(Array array_0)
	{
		return array_0.GetEnumerator();
	}

	static object smethod_4(IEnumerator ienumerator_0)
	{
		return ienumerator_0.Current;
	}

	static bool smethod_5(object object_0, object object_1)
	{
		return object_0.Equals(object_1);
	}

	static bool smethod_6(IEnumerator ienumerator_0)
	{
		return ienumerator_0.MoveNext();
	}

	static void smethod_7(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static bool smethod_8(string string_0, string string_1)
	{
		return string_0.StartsWith(string_1);
	}

	static string[] smethod_9(string string_0, char[] char_0)
	{
		return string_0.Split(char_0);
	}

	static bool smethod_10(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	static Exception smethod_11(string string_0)
	{
		return new Exception(string_0);
	}
}
