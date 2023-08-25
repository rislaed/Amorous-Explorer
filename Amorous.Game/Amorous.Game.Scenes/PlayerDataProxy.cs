using System;
using Microsoft.Xna.Framework;

namespace Amorous.Game.Scenes;

internal class PlayerDataProxy : IPlayerData
{
	private readonly PlayerData playerData;

	public string Name
	{
		get
		{
			return playerData.Name;
		}
		set
		{
			playerData.Name = value;
			InvokeDataChanged();
		}
	}

	public PlayerData.EBodyType BodyType
	{
		get
		{
			return playerData.BodyType;
		}
		set
		{
			playerData.BodyType = value;
			InvokeDataChanged();
		}
	}

	public Color BodyColor
	{
		get
		{
			return playerData.BodyColor;
		}
		set
		{
			playerData.BodyColor = value;
			InvokeDataChanged();
		}
	}

	public bool ShowNails
	{
		get
		{
			return playerData.ShowNails;
		}
		set
		{
			playerData.ShowNails = value;
			InvokeDataChanged();
		}
	}

	public Color NailColor
	{
		get
		{
			return playerData.NailColor;
		}
		set
		{
			playerData.NailColor = value;
			InvokeDataChanged();
		}
	}

	public PlayerData.EHeadType HeadType
	{
		get
		{
			return playerData.HeadType;
		}
		set
		{
			playerData.HeadType = value;
			InvokeDataChanged();
		}
	}

	public Color HeadColor
	{
		get
		{
			return playerData.HeadColor;
		}
		set
		{
			playerData.HeadColor = value;
			InvokeDataChanged();
		}
	}

	public Color PaperBagColor
	{
		get
		{
			return playerData.PaperBagColor;
		}
		set
		{
			playerData.PaperBagColor = value;
			InvokeDataChanged();
		}
	}

	public Color PaperBagEyesColor
	{
		get
		{
			return playerData.PaperBagEyesColor;
		}
		set
		{
			playerData.PaperBagEyesColor = value;
			InvokeDataChanged();
		}
	}

	public PlayerData.EHeadMarkingsType HeadMarkingsType
	{
		get
		{
			return playerData.HeadMarkingsType;
		}
		set
		{
			playerData.HeadMarkingsType = value;
			InvokeDataChanged();
		}
	}

	public Color HeadGauntColor
	{
		get
		{
			return playerData.HeadGauntColor;
		}
		set
		{
			playerData.HeadGauntColor = value;
			InvokeDataChanged();
		}
	}

	public Color HeadScruffyColor
	{
		get
		{
			return playerData.HeadScruffyColor;
		}
		set
		{
			playerData.HeadScruffyColor = value;
			InvokeDataChanged();
		}
	}

	public Color HeadSnoutColor
	{
		get
		{
			return playerData.HeadSnoutColor;
		}
		set
		{
			playerData.HeadSnoutColor = value;
			InvokeDataChanged();
		}
	}

	public Color HeadStripesColor
	{
		get
		{
			return playerData.HeadStripesColor;
		}
		set
		{
			playerData.HeadStripesColor = value;
			InvokeDataChanged();
		}
	}

	public PlayerData.EHeadAccessoriesType HeadAccessoriesType
	{
		get
		{
			return playerData.HeadAccessoriesType;
		}
		set
		{
			playerData.HeadAccessoriesType = value;
			InvokeDataChanged();
		}
	}

	public Color HeadHornsColor
	{
		get
		{
			return playerData.HeadHornsColor;
		}
		set
		{
			playerData.HeadHornsColor = value;
			InvokeDataChanged();
		}
	}

	public Color EarColor
	{
		get
		{
			return playerData.EarColor;
		}
		set
		{
			playerData.EarColor = value;
			InvokeDataChanged();
		}
	}

	public Color EarInnerColor
	{
		get
		{
			return playerData.EarInnerColor;
		}
		set
		{
			playerData.EarInnerColor = value;
			InvokeDataChanged();
		}
	}

	public PlayerData.EEyesType EyesType
	{
		get
		{
			return playerData.EyesType;
		}
		set
		{
			playerData.EyesType = value;
			InvokeDataChanged();
		}
	}

	public Color EyesBackColor
	{
		get
		{
			return playerData.EyesBackColor;
		}
		set
		{
			playerData.EyesBackColor = value;
			InvokeDataChanged();
		}
	}

	public Color EyesFrontColor
	{
		get
		{
			return playerData.EyesFrontColor;
		}
		set
		{
			playerData.EyesFrontColor = value;
			InvokeDataChanged();
		}
	}

	public PlayerData.EBrowType BrowType
	{
		get
		{
			return playerData.BrowType;
		}
		set
		{
			playerData.BrowType = value;
			InvokeDataChanged();
		}
	}

	public Color BrowColor
	{
		get
		{
			return playerData.BrowColor;
		}
		set
		{
			playerData.BrowColor = value;
			InvokeDataChanged();
		}
	}

	public PlayerData.EMuzzleType MuzzleType
	{
		get
		{
			return playerData.MuzzleType;
		}
		set
		{
			playerData.MuzzleType = value;
			InvokeDataChanged();
		}
	}

	public Color MuzzleColor
	{
		get
		{
			return playerData.MuzzleColor;
		}
		set
		{
			playerData.MuzzleColor = value;
			InvokeDataChanged();
		}
	}

	public Color NoseColor
	{
		get
		{
			return playerData.NoseColor;
		}
		set
		{
			playerData.NoseColor = value;
			InvokeDataChanged();
		}
	}

	public Color TeethColor
	{
		get
		{
			return playerData.TeethColor;
		}
		set
		{
			playerData.TeethColor = value;
			InvokeDataChanged();
		}
	}

	public bool ShowMuzzleHorn
	{
		get
		{
			return playerData.ShowMuzzleHorn;
		}
		set
		{
			playerData.ShowMuzzleHorn = value;
			InvokeDataChanged();
		}
	}

	public Color MuzzleHornColor
	{
		get
		{
			return playerData.MuzzleHornColor;
		}
		set
		{
			playerData.MuzzleHornColor = value;
			InvokeDataChanged();
		}
	}

	public bool ShowMuzzleMask
	{
		get
		{
			return playerData.ShowMuzzleMask;
		}
		set
		{
			playerData.ShowMuzzleMask = value;
			InvokeDataChanged();
		}
	}

	public Color MuzzleMaskColor
	{
		get
		{
			return playerData.MuzzleMaskColor;
		}
		set
		{
			playerData.MuzzleMaskColor = value;
			InvokeDataChanged();
		}
	}

	public PlayerData.EHairstyleType HairstyleType
	{
		get
		{
			return playerData.HairstyleType;
		}
		set
		{
			playerData.HairstyleType = value;
			InvokeDataChanged();
		}
	}

	public Color HairColor
	{
		get
		{
			return playerData.HairColor;
		}
		set
		{
			playerData.HairColor = value;
			InvokeDataChanged();
		}
	}

	public PlayerData.EFringeType FringeType
	{
		get
		{
			return playerData.FringeType;
		}
		set
		{
			playerData.FringeType = value;
			InvokeDataChanged();
		}
	}

	public Color FringeColor
	{
		get
		{
			return playerData.FringeColor;
		}
		set
		{
			playerData.FringeColor = value;
			InvokeDataChanged();
		}
	}

	public PlayerData.EFeetType FeetType
	{
		get
		{
			return playerData.FeetType;
		}
		set
		{
			playerData.FeetType = value;
			InvokeDataChanged();
		}
	}

	public Color FeetColor
	{
		get
		{
			return playerData.FeetColor;
		}
		set
		{
			playerData.FeetColor = value;
			InvokeDataChanged();
		}
	}

	public PlayerData.ETailType TailType
	{
		get
		{
			return playerData.TailType;
		}
		set
		{
			playerData.TailType = value;
			InvokeDataChanged();
		}
	}

	public Color TailColor
	{
		get
		{
			return playerData.TailColor;
		}
		set
		{
			playerData.TailColor = value;
			InvokeDataChanged();
		}
	}

	public bool ShowTailPartOne
	{
		get
		{
			return playerData.ShowTailPartOne;
		}
		set
		{
			playerData.ShowTailPartOne = value;
			InvokeDataChanged();
		}
	}

	public Color TailPartOneColor
	{
		get
		{
			return playerData.TailPartOneColor;
		}
		set
		{
			playerData.TailPartOneColor = value;
			InvokeDataChanged();
		}
	}

	public bool ShowTailPartTwo
	{
		get
		{
			return playerData.ShowTailPartTwo;
		}
		set
		{
			playerData.ShowTailPartTwo = value;
			InvokeDataChanged();
		}
	}

	public Color TailPartTwoColor
	{
		get
		{
			return playerData.TailPartTwoColor;
		}
		set
		{
			playerData.TailPartTwoColor = value;
			InvokeDataChanged();
		}
	}

	public PlayerData.EMarkingsType MarkingsType
	{
		get
		{
			return playerData.MarkingsType;
		}
		set
		{
			playerData.MarkingsType = value;
			InvokeDataChanged();
		}
	}

	public Color UnderbellyColor
	{
		get
		{
			return playerData.UnderbellyColor;
		}
		set
		{
			playerData.UnderbellyColor = value;
			InvokeDataChanged();
		}
	}

	public Color UnderthighColor
	{
		get
		{
			return playerData.UnderthighColor;
		}
		set
		{
			playerData.UnderthighColor = value;
			InvokeDataChanged();
		}
	}

	public Color StripesColor
	{
		get
		{
			return playerData.StripesColor;
		}
		set
		{
			playerData.StripesColor = value;
			InvokeDataChanged();
		}
	}

	public Color LongForearmColor
	{
		get
		{
			return playerData.LongForearmColor;
		}
		set
		{
			playerData.LongForearmColor = value;
			InvokeDataChanged();
		}
	}

	public Color ShortForearmColor
	{
		get
		{
			return playerData.ShortForearmColor;
		}
		set
		{
			playerData.ShortForearmColor = value;
			InvokeDataChanged();
		}
	}

	public Color AvianForearmColor
	{
		get
		{
			return playerData.AvianForearmColor;
		}
		set
		{
			playerData.AvianForearmColor = value;
			InvokeDataChanged();
		}
	}

	public Color LongShinColor
	{
		get
		{
			return playerData.LongShinColor;
		}
		set
		{
			playerData.LongShinColor = value;
			InvokeDataChanged();
		}
	}

	public Color ShortShinColor
	{
		get
		{
			return playerData.ShortShinColor;
		}
		set
		{
			playerData.ShortShinColor = value;
			InvokeDataChanged();
		}
	}

	public Color AvianShinColor
	{
		get
		{
			return playerData.AvianShinColor;
		}
		set
		{
			playerData.AvianShinColor = value;
			InvokeDataChanged();
		}
	}

	public PlayerData.ECockType CockType
	{
		get
		{
			return playerData.CockType;
		}
		set
		{
			playerData.CockType = value;
			InvokeDataChanged();
		}
	}

	public Color GenitaliaColor
	{
		get
		{
			return playerData.GenitaliaColor;
		}
		set
		{
			playerData.GenitaliaColor = value;
			InvokeDataChanged();
		}
	}

	public Color GenitaliaFleshColor
	{
		get
		{
			return playerData.GenitaliaFleshColor;
		}
		set
		{
			playerData.GenitaliaFleshColor = value;
			InvokeDataChanged();
		}
	}

	public PlayerData.EBallsType BallsType
	{
		get
		{
			return playerData.BallsType;
		}
		set
		{
			playerData.BallsType = value;
			InvokeDataChanged();
		}
	}

	public Color BallsColor
	{
		get
		{
			return playerData.BallsColor;
		}
		set
		{
			playerData.BallsColor = value;
			InvokeDataChanged();
		}
	}

	public PlayerData.EBreastsType BreastsType
	{
		get
		{
			return playerData.BreastsType;
		}
		set
		{
			playerData.BreastsType = value;
			InvokeDataChanged();
		}
	}

	public Color BreastsColor
	{
		get
		{
			return playerData.BreastsColor;
		}
		set
		{
			playerData.BreastsColor = value;
			InvokeDataChanged();
		}
	}

	public bool ShowNipples
	{
		get
		{
			return playerData.ShowNipples;
		}
		set
		{
			playerData.ShowNipples = value;
			InvokeDataChanged();
		}
	}

	public Color NipplesColor
	{
		get
		{
			return playerData.NipplesColor;
		}
		set
		{
			playerData.NipplesColor = value;
			InvokeDataChanged();
		}
	}

	public Color PhoneColor
	{
		get
		{
			return playerData.PhoneColor;
		}
		set
		{
			playerData.PhoneColor = value;
			InvokeDataChanged();
		}
	}

	public event Action DataChanged;

	public PlayerDataProxy(PlayerData data)
	{
		playerData = data;
	}

	public bool HasFlag(string key)
	{
		return playerData.HasFlag(key);
	}

	public PlayerData GetPlayerData()
	{
		return playerData;
	}

	private void InvokeDataChanged()
	{
		this.DataChanged?.Invoke();
	}
}
