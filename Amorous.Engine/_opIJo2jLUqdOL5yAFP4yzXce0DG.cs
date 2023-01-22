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
			return string_0.StartsWith("Player.Outfit.");
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
				return string_0 == _6ASPaeAeh8vdl643GgyWe0mG0a0;
			}
			return string_0.StartsWith(_6ASPaeAeh8vdl643GgyWe0mG0a0);
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
		_mPwD8DvxbNkq8fBcmlHJ80kVkB2 = new Dictionary<string, int>();
		_Cs2b43EFDtJdhoWWSmCcssGUmHZA = new Dictionary<string, bool>();
		_7u6aevGWBE7ABqrBXoaPTkywcVo = new List<_iDN1IKOu3e1uADYzeMEUon5D9fg>();
		_haICL4qkfkOLhPhofWQH1GmjZx5();
	}

	public void _Rj5BZHY1n3a8XV7jJAk9U8jZZ6m()
	{
		_XDbzWLxDi2VVrJQrjjLsgcfdxju();
		_haICL4qkfkOLhPhofWQH1GmjZx5();
	}

	public void _XDbzWLxDi2VVrJQrjjLsgcfdxju()
	{
		_RB8fRXeQvK5vs7JEA0XfVCEpg1i = string.Empty;
		_8CtoV1bqn0CwCzb1tuoNppBt0Gg = EBodyType.Lean;
		_6f1rvTENt5XWmHTE22zxBIwbH9G = Color.White;
		_VmNLhqrIwSnE6JnCYiBcxnSqnEV = false;
		_in5HHYmrdLTFpkgc8aimJpXqAXB = Color.White;
		_UjtZovBCLAtBZnUfbTvRFsaf5mx = EHeadType.Default;
		_1qfGl3Oc2JyQEpnQtdOxMeMkqhi = Color.White;
		_VWdlqWB4z2wNtm197Oiv32QGVbE = Color.White;
		_sbSAaAmkhONcFX6f0JtHbVQbEfG = Color.White;
		_SnnHu3P4lDDxgkL6cuUt7y07yxG = _iDe3W6qb7jKTPuJV79yf2i7UoIq.None;
		_Fn7Kt1UvxcXOmJ1gIeWdJnRbaQt = Color.White;
		_WvoLJ4MA4gYEsgOmmIQvfK3xFlu = Color.White;
		_lUyqwDvFCoXEZ6VM9PVCQ970jps = Color.White;
		_qKGefHxdjIUD6ObjxrxnLwbBEsh = Color.White;
		_pmr0FnBBvgaggpusBKMWplUa63c = EHeadAccessoriesType.None;
		_9b2asKZDwVM1TcSfmfeFCuk0TJZb = Color.White;
		_vUhBAXEgvpGKopOUkDJFoc4EYQ3 = Color.White;
		_uaBF7rEib15d42vH8AzoXWFMMkE = Color.White;
		_c0ThYURHAGN0Wzlzw9Ibh3Z8qyo = EEyesType.Neutral;
		_GXnDb1oaJlPbAQV2mjAwCQFK0nmb = Color.White;
		_0K4lcN7iwo5q0iP1YlkpY9GdayR = Color.White;
		_KBOJ0qhM8C5evPQxibgX74m2WHg = EBrowType.None;
		_HRPv5rzDY5zNiP4NADDEGhrzGTe = Color.White;
		_4QUr9lDqmNxEuy7B4xgb7Lj1HU0 = EMuzzleType.Short;
		_VsEYbNSam3IFYYWY4QC2lb4ia61 = Color.White;
		_y1SiMmRVXWDhDtY17knDpitt46F = Color.White;
		_T98drEOtEEZKeB5tXzsuPrhb5Xk = Color.White;
		_hkFDGB5pWIuOVcIyDAFqHrDdSpjA = false;
		_q2iDxJYfqribHB1bD8aSkSjqrfnA = Color.White;
		_UAZhvJ3a9BGOBM0CLiDkKLwUFC9 = false;
		_phJrpk3rql5MfNJxPQ9X7nC8aAk = Color.White;
		_03h2I0mTkGTzIA5R48rgwJh7JZA = EHairstyleType.None;
		_bJmvnPs69aVDXxG48lmruYZFHKt = Color.White;
		_fzMbZCCd7imnrcrYWkSj5u8UZ2J = EFringeType.None;
		_EvdUMrkAAdTeMv6fOpGrOLCAMq8A = Color.White;
		_LZ8c6hRMRYKjnlLOPhbZHcWqUGG = EFeetType.Beast;
		_LZfuQybASevOsCykEWqdvA5GqUF = Color.White;
		_NrFEKLWh80bQXi9PujCBTqm01AA = ETailType.None;
		_qsK1J3jktKH3eJ2i8sL1oaxXtLc = Color.White;
		_PVQfhwHODkR6bzHmfeCK4L8riIG = false;
		_62dl1HYYkor3TZL58k5Y33Tj83 = Color.White;
		_tEXwTuSRSq5JaaFE4W8edEHxS9q = false;
		_LufmRsAZrlyDgRKYocQXPzANMaF = Color.White;
		_Mz7LwHZqoGBscApFXmff1kEQnGY = _VzIdKOJ1Gq1YccwwHcwhrVV5V4U.None;
		_PeK36AvFxEQCvX3fS62hNV7rpuJ = Color.White;
		_zBv1cYqPRU7uDCALpBlBSgObUcbA = Color.White;
		_TxfCqloeyiHpsXka6B46iqCZNsZ = Color.White;
		_1ZKGQXLRAHEJR8v7jhlDsyOVLcz = Color.White;
		_8rDSn6e9Ip9WdOogjhIn8YlL1oM = Color.White;
		_FrsyMDX7TebzFk8nSLTyRDPi1QH = Color.White;
		_cUtgkG5qDvgFmI8c29I9xsLVNON = Color.White;
		_LcOPiDaC2j5vzxOEYhvW4vRoaRX = Color.White;
		_meyNS02iTIxo212B6c5eoKns2wj = Color.White;
		_rtyJgfViJdXL2Ela5APpDlk99dI = ECockType.None;
		_XnNREK59QnV1onFFWfSUaS9WK0E = Color.White;
		_o6OnmHi5rZIQPHESokp9rTaO1ei = Color.White;
		_7OCMpsMmozHsAG0GDljMMAlGLJBA = EBallsType.None;
		_8qQ7XVlyRYW4icBFxPQCJqgueYD = Color.White;
		_BCncLn6BIYiBX6NdFByAquBYGpH = EBreastsType.None;
		_pigzqi6DgcSToQkL9g7Ns2QrLfp = Color.White;
		_Q2AbpMWcrhtCW9MLTtT5gwoleu7 = false;
		_2yydfEIrSiLPTti2dT8JXGoIaM3 = Color.White;
		_uOkbmfW26QVAvyEMQakki9kTMDbA = Color.White;
	}

	public void _haICL4qkfkOLhPhofWQH1GmjZx5()
	{
		_mPwD8DvxbNkq8fBcmlHJ80kVkB2.Clear();
		_4pE8Q2fYoSeltAUx7pxshukqsEb = EPhoneContacts.None;
		_uVBbxOT5AbKoffINIsfdTnEGd3xA = EPhoneContacts.None;
		_Cs2b43EFDtJdhoWWSmCcssGUmHZA.Clear();
	}

	public int _fvTKDuNATrUxfXZVvltePz3vYkK(string string_0)
	{
		if (!_mPwD8DvxbNkq8fBcmlHJ80kVkB2.ContainsKey(string_0))
		{
			_fPyIv5zbbSj5sjZlbAwQTFXnJ5G(string_0, 10);
			return 10;
		}
		return _mPwD8DvxbNkq8fBcmlHJ80kVkB2[string_0];
	}

	public void _fPyIv5zbbSj5sjZlbAwQTFXnJ5G(string string_0, int int_0)
	{
		if (string_0 != null)
		{
			_mPwD8DvxbNkq8fBcmlHJ80kVkB2[string_0] = int_0;
		}
	}

	public void _modEEaw3I1w8Mt0usyRNoa4Ri0H(EPhoneContacts ephoneContacts_0)
	{
		if (!_4pE8Q2fYoSeltAUx7pxshukqsEb.HasFlag(ephoneContacts_0))
		{
			_4pE8Q2fYoSeltAUx7pxshukqsEb |= ephoneContacts_0;
		}
	}

	public void _Qd7anWdHpZ5AgaUbbEv07BnnI6Q(EPhoneContacts ephoneContacts_0)
	{
		if (_4pE8Q2fYoSeltAUx7pxshukqsEb.HasFlag(ephoneContacts_0))
		{
			_4pE8Q2fYoSeltAUx7pxshukqsEb &= ~ephoneContacts_0;
		}
		if (!_uVBbxOT5AbKoffINIsfdTnEGd3xA.HasFlag(ephoneContacts_0))
		{
			_uVBbxOT5AbKoffINIsfdTnEGd3xA |= ephoneContacts_0;
		}
	}

	public void _Xwcp3PcmrSeqc3MSVH0tfLbcwXA()
	{
		_uVBbxOT5AbKoffINIsfdTnEGd3xA = EPhoneContacts.None;
	}

	public int _X1b0dyIzsSyKwqWd3usrbDfKJAk()
	{
		int num = 0;
		foreach (object value in Enum.GetValues(typeof(EPhoneContacts)))
		{
			if (!value.Equals(EPhoneContacts.None) && _4pE8Q2fYoSeltAUx7pxshukqsEb.HasFlag((EPhoneContacts)value))
			{
				num++;
			}
		}
		return num;
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
									return _7OCMpsMmozHsAG0GDljMMAlGLJBA == result;
								}
							}
							else if (array[1] == "Outfit")
							{
								return array[2] == "Simple";
							}
						}
						else if (Enum.TryParse<ECockType>(array[2], out result2))
						{
							return _rtyJgfViJdXL2Ela5APpDlk99dI == result2;
						}
					}
					else if (Enum.TryParse<EBreastsType>(array[2], out result3))
					{
						return _BCncLn6BIYiBX6NdFByAquBYGpH == result3;
					}
				}
				else if (Enum.TryParse<EBodyType>(array[2], out result4))
				{
					return _8CtoV1bqn0CwCzb1tuoNppBt0Gg == result4;
				}
			}
		}
		else if (string_0.StartsWith("Quests."))
		{
			string[] array2 = string_0.Split(new char[1] { '.' });
			if (array2.Length > 2 && int.TryParse(array2[2], out var result5))
			{
				return _fvTKDuNATrUxfXZVvltePz3vYkK(array2[1]) == result5;
			}
		}
		return string_0 switch
		{
			"PlayerChubby" => _8CtoV1bqn0CwCzb1tuoNppBt0Gg == EBodyType.Chubby, 
			"PlayerLean" => _8CtoV1bqn0CwCzb1tuoNppBt0Gg == EBodyType.Lean, 
			"HasBreasts" => _BCncLn6BIYiBX6NdFByAquBYGpH != EBreastsType.None, 
			"PlayerMuscular" => _8CtoV1bqn0CwCzb1tuoNppBt0Gg == EBodyType.Muscular, 
			"PlayerTwinky" => _8CtoV1bqn0CwCzb1tuoNppBt0Gg == EBodyType.Twinky, 
			_ => false, 
		};
	}

	public void _4Fscz8ryB3hm0NmL5xw39HHiPd1(string string_0, bool bool_0)
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
					_Cs2b43EFDtJdhoWWSmCcssGUmHZA.Keys.Where((string string_0) => string_0.StartsWith("Player.Outfit.")).ToList().ForEach(delegate(string string_0)
					{
						_Cs2b43EFDtJdhoWWSmCcssGUmHZA.Remove(string_0);
					});
				}
			}
		}
		_Cs2b43EFDtJdhoWWSmCcssGUmHZA[string_0] = bool_0;
	}

	public void _aedbmRW9PZZduyLA3PVVHtafNAGA(string string_0, bool bool_0 = true)
	{
		_Cs2b43EFDtJdhoWWSmCcssGUmHZA.Keys.Where((string string_0) => (!bool_0) ? (string_0 == string_0) : string_0.StartsWith(string_0)).ToList().ForEach(delegate(string string_0)
		{
			_Cs2b43EFDtJdhoWWSmCcssGUmHZA.Remove(string_0);
		});
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
