using System;
using Microsoft.Xna.Framework;

namespace Amorous.Game.Scenes;

internal class PlayerDataProxy : IPlayerData
{
	private readonly PlayerData Data;

	public string Name
	{
		get
		{
			return Data.Name;
		}
		set
		{
			Data.Name = value;
			InvokeOnChange();
		}
	}

	public PlayerData.EBodyType BodyType
	{
		get
		{
			return Data.BodyType;
		}
		set
		{
			Data.BodyType = value;
			InvokeOnChange();
		}
	}

	public Color BodyColor
	{
		get
		{
			return Data.BodyColor;
		}
		set
		{
			Data.BodyColor = value;
			InvokeOnChange();
		}
	}

	public bool ShowNails
	{
		get
		{
			return Data.ShowNails;
		}
		set
		{
			Data.ShowNails = value;
			InvokeOnChange();
		}
	}

	public Color NailColor
	{
		get
		{
			return Data.NailColor;
		}
		set
		{
			Data.NailColor = value;
			InvokeOnChange();
		}
	}

	public PlayerData.EHeadType HeadType
	{
		get
		{
			return Data.HeadType;
		}
		set
		{
			Data.HeadType = value;
			InvokeOnChange();
		}
	}

	public Color HeadColor
	{
		get
		{
			return Data.HeadColor;
		}
		set
		{
			Data.HeadColor = value;
			InvokeOnChange();
		}
	}

	public Color PaperBagColor
	{
		get
		{
			return Data.PaperBagColor;
		}
		set
		{
			Data.PaperBagColor = value;
			InvokeOnChange();
		}
	}

	public Color PaperBagEyesColor
	{
		get
		{
			return Data.PaperBagEyesColor;
		}
		set
		{
			Data.PaperBagEyesColor = value;
			InvokeOnChange();
		}
	}

	public PlayerData.EHeadMarkingsType HeadMarkingsType
	{
		get
		{
			return Data.HeadMarkingsType;
		}
		set
		{
			Data.HeadMarkingsType = value;
			InvokeOnChange();
		}
	}

	public Color HeadGauntColor
	{
		get
		{
			return Data.HeadGauntColor;
		}
		set
		{
			Data.HeadGauntColor = value;
			InvokeOnChange();
		}
	}

	public Color HeadScruffyColor
	{
		get
		{
			return Data.HeadScruffyColor;
		}
		set
		{
			Data.HeadScruffyColor = value;
			InvokeOnChange();
		}
	}

	public Color HeadSnoutColor
	{
		get
		{
			return Data.HeadSnoutColor;
		}
		set
		{
			Data.HeadSnoutColor = value;
			InvokeOnChange();
		}
	}

	public Color HeadStripesColor
	{
		get
		{
			return Data.HeadStripesColor;
		}
		set
		{
			Data.HeadStripesColor = value;
			InvokeOnChange();
		}
	}

	public PlayerData.EHeadAccessoriesType HeadAccessoriesType
	{
		get
		{
			return Data.HeadAccessoriesType;
		}
		set
		{
			Data.HeadAccessoriesType = value;
			InvokeOnChange();
		}
	}

	public Color HeadHornsColor
	{
		get
		{
			return Data.HeadHornsColor;
		}
		set
		{
			Data.HeadHornsColor = value;
			InvokeOnChange();
		}
	}

	public Color EarColor
	{
		get
		{
			return Data.EarColor;
		}
		set
		{
			Data.EarColor = value;
			InvokeOnChange();
		}
	}

	public Color EarInnerColor
	{
		get
		{
			return Data.EarInnerColor;
		}
		set
		{
			Data.EarInnerColor = value;
			InvokeOnChange();
		}
	}

	public PlayerData.EEyesType EyesType
	{
		get
		{
			return Data.EyesType;
		}
		set
		{
			Data.EyesType = value;
			InvokeOnChange();
		}
	}

	public Color EyesBackColor
	{
		get
		{
			return Data.EyesBackColor;
		}
		set
		{
			Data.EyesBackColor = value;
			InvokeOnChange();
		}
	}

	public Color EyesFrontColor
	{
		get
		{
			return Data.EyesFrontColor;
		}
		set
		{
			Data.EyesFrontColor = value;
			InvokeOnChange();
		}
	}

	public PlayerData.EBrowType BrowType
	{
		get
		{
			return Data.BrowType;
		}
		set
		{
			Data.BrowType = value;
			InvokeOnChange();
		}
	}

	public Color BrowColor
	{
		get
		{
			return Data.BrowColor;
		}
		set
		{
			Data.BrowColor = value;
			InvokeOnChange();
		}
	}

	public PlayerData.EMuzzleType MuzzleType
	{
		get
		{
			return Data.MuzzleType;
		}
		set
		{
			Data.MuzzleType = value;
			InvokeOnChange();
		}
	}

	public Color MuzzleColor
	{
		get
		{
			return Data.MuzzleColor;
		}
		set
		{
			Data.MuzzleColor = value;
			InvokeOnChange();
		}
	}

	public Color NoseColor
	{
		get
		{
			return Data.NoseColor;
		}
		set
		{
			Data.NoseColor = value;
			InvokeOnChange();
		}
	}

	public Color TeethColor
	{
		get
		{
			return Data.TeethColor;
		}
		set
		{
			Data.TeethColor = value;
			InvokeOnChange();
		}
	}

	public bool ShowMuzzleHorn
	{
		get
		{
			return Data.ShowMuzzleHorn;
		}
		set
		{
			Data.ShowMuzzleHorn = value;
			InvokeOnChange();
		}
	}

	public Color MuzzleHornColor
	{
		get
		{
			return Data.MuzzleHornColor;
		}
		set
		{
			Data.MuzzleHornColor = value;
			InvokeOnChange();
		}
	}

	public bool ShowMuzzleMask
	{
		get
		{
			return Data.ShowMuzzleMask;
		}
		set
		{
			Data.ShowMuzzleMask = value;
			InvokeOnChange();
		}
	}

	public Color MuzzleMaskColor
	{
		get
		{
			return Data.MuzzleMaskColor;
		}
		set
		{
			Data.MuzzleMaskColor = value;
			InvokeOnChange();
		}
	}

	public PlayerData.EHairstyleType HairstyleType
	{
		get
		{
			return Data.HairstyleType;
		}
		set
		{
			Data.HairstyleType = value;
			InvokeOnChange();
		}
	}

	public Color HairColor
	{
		get
		{
			return Data.HairColor;
		}
		set
		{
			Data.HairColor = value;
			InvokeOnChange();
		}
	}

	public PlayerData.EFringeType FringeType
	{
		get
		{
			return Data.FringeType;
		}
		set
		{
			Data.FringeType = value;
			InvokeOnChange();
		}
	}

	public Color FringeColor
	{
		get
		{
			return Data.FringeColor;
		}
		set
		{
			Data.FringeColor = value;
			InvokeOnChange();
		}
	}

	public PlayerData.EFeetType FeetType
	{
		get
		{
			return Data.FeetType;
		}
		set
		{
			Data.FeetType = value;
			InvokeOnChange();
		}
	}

	public Color FeetColor
	{
		get
		{
			return Data.FeetColor;
		}
		set
		{
			Data.FeetColor = value;
			InvokeOnChange();
		}
	}

	public PlayerData.ETailType TailType
	{
		get
		{
			return Data.TailType;
		}
		set
		{
			Data.TailType = value;
			InvokeOnChange();
		}
	}

	public Color TailColor
	{
		get
		{
			return Data.TailColor;
		}
		set
		{
			Data.TailColor = value;
			InvokeOnChange();
		}
	}

	public bool ShowTailPartOne
	{
		get
		{
			return Data.ShowTailPartOne;
		}
		set
		{
			Data.ShowTailPartOne = value;
			InvokeOnChange();
		}
	}

	public Color TailPartOneColor
	{
		get
		{
			return Data.TailPartOneColor;
		}
		set
		{
			Data.TailPartOneColor = value;
			InvokeOnChange();
		}
	}

	public bool ShowTailPartTwo
	{
		get
		{
			return Data.ShowTailPartTwo;
		}
		set
		{
			Data.ShowTailPartTwo = value;
			InvokeOnChange();
		}
	}

	public Color TailPartTwoColor
	{
		get
		{
			return Data.TailPartTwoColor;
		}
		set
		{
			Data.TailPartTwoColor = value;
			InvokeOnChange();
		}
	}

	public PlayerData.EMarkingsType MarkingsType
	{
		get
		{
			return Data.MarkingsType;
		}
		set
		{
			Data.MarkingsType = value;
			InvokeOnChange();
		}
	}

	public Color UnderbellyColor
	{
		get
		{
			return Data.UnderbellyColor;
		}
		set
		{
			Data.UnderbellyColor = value;
			InvokeOnChange();
		}
	}

	public Color UnderthighColor
	{
		get
		{
			return Data.UnderthighColor;
		}
		set
		{
			Data.UnderthighColor = value;
			InvokeOnChange();
		}
	}

	public Color StripesColor
	{
		get
		{
			return Data.StripesColor;
		}
		set
		{
			Data.StripesColor = value;
			InvokeOnChange();
		}
	}

	public Color LongForearmColor
	{
		get
		{
			return Data.LongForearmColor;
		}
		set
		{
			Data.LongForearmColor = value;
			InvokeOnChange();
		}
	}

	public Color ShortForearmColor
	{
		get
		{
			return Data.ShortForearmColor;
		}
		set
		{
			Data.ShortForearmColor = value;
			InvokeOnChange();
		}
	}

	public Color AvianForearmColor
	{
		get
		{
			return Data.AvianForearmColor;
		}
		set
		{
			Data.AvianForearmColor = value;
			InvokeOnChange();
		}
	}

	public Color LongShinColor
	{
		get
		{
			return Data.LongShinColor;
		}
		set
		{
			Data.LongShinColor = value;
			InvokeOnChange();
		}
	}

	public Color ShortShinColor
	{
		get
		{
			return Data.ShortShinColor;
		}
		set
		{
			Data.ShortShinColor = value;
			InvokeOnChange();
		}
	}

	public Color AvianShinColor
	{
		get
		{
			return Data.AvianShinColor;
		}
		set
		{
			Data.AvianShinColor = value;
			InvokeOnChange();
		}
	}

	public PlayerData.ECockType CockType
	{
		get
		{
			return Data.CockType;
		}
		set
		{
			Data.CockType = value;
			InvokeOnChange();
		}
	}

	public Color GenitaliaColor
	{
		get
		{
			return Data.GenitaliaColor;
		}
		set
		{
			Data.GenitaliaColor = value;
			InvokeOnChange();
		}
	}

	public Color GenitaliaFleshColor
	{
		get
		{
			return Data.GenitaliaFleshColor;
		}
		set
		{
			Data.GenitaliaFleshColor = value;
			InvokeOnChange();
		}
	}

	public PlayerData.EBallsType BallsType
	{
		get
		{
			return Data.BallsType;
		}
		set
		{
			Data.BallsType = value;
			InvokeOnChange();
		}
	}

	public Color BallsColor
	{
		get
		{
			return Data.BallsColor;
		}
		set
		{
			Data.BallsColor = value;
			InvokeOnChange();
		}
	}

	public PlayerData.EBreastsType BreastsType
	{
		get
		{
			return Data.BreastsType;
		}
		set
		{
			Data.BreastsType = value;
			InvokeOnChange();
		}
	}

	public Color BreastsColor
	{
		get
		{
			return Data.BreastsColor;
		}
		set
		{
			Data.BreastsColor = value;
			InvokeOnChange();
		}
	}

	public bool ShowNipples
	{
		get
		{
			return Data.ShowNipples;
		}
		set
		{
			Data.ShowNipples = value;
			InvokeOnChange();
		}
	}

	public Color NipplesColor
	{
		get
		{
			return Data.NipplesColor;
		}
		set
		{
			Data.NipplesColor = value;
			InvokeOnChange();
		}
	}

	public Color PhoneColor
	{
		get
		{
			return Data.PhoneColor;
		}
		set
		{
			Data.PhoneColor = value;
			InvokeOnChange();
		}
	}

	public event Action OnChange;

	public PlayerDataProxy(PlayerData data)
	{
		Data = data;
	}

	public bool GetFlag(string string_0)
	{
		return Data.GetFlag(string_0);
	}

	public PlayerData GetPlayerData()
	{
		return Data;
	}

	private void InvokeOnChange()
	{
		this.OnChange?.Invoke();
	}
}
