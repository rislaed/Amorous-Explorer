using System;
using Microsoft.Xna.Framework;

namespace Amorous.Game.Scenes;

internal class PlayerDataProxy : IPlayerData
{
	private readonly PlayerData _data;

	public string Name
	{
		get
		{
			return _data.Name;
		}
		set
		{
			_data.Name = value;
			InvokeOnChange();
		}
	}

	public PlayerData.EBodyType BodyType
	{
		get
		{
			return _data.BodyType;
		}
		set
		{
			_data.BodyType = value;
			InvokeOnChange();
		}
	}

	public Color BodyColor
	{
		get
		{
			return _data.BodyColor;
		}
		set
		{
			_data.BodyColor = value;
			InvokeOnChange();
		}
	}

	public bool ShowNails
	{
		get
		{
			return _data.ShowNails;
		}
		set
		{
			_data.ShowNails = value;
			InvokeOnChange();
		}
	}

	public Color NailColor
	{
		get
		{
			return _data.NailColor;
		}
		set
		{
			_data.NailColor = value;
			InvokeOnChange();
		}
	}

	public PlayerData.EHeadType HeadType
	{
		get
		{
			return _data.HeadType;
		}
		set
		{
			_data.HeadType = value;
			InvokeOnChange();
		}
	}

	public Color HeadColor
	{
		get
		{
			return _data.HeadColor;
		}
		set
		{
			_data.HeadColor = value;
			InvokeOnChange();
		}
	}

	public Color PaperBagColor
	{
		get
		{
			return _data.PaperBagColor;
		}
		set
		{
			_data.PaperBagColor = value;
			InvokeOnChange();
		}
	}

	public Color PaperBagEyesColor
	{
		get
		{
			return _data.PaperBagEyesColor;
		}
		set
		{
			_data.PaperBagEyesColor = value;
			InvokeOnChange();
		}
	}

	public PlayerData.EHeadMarkingsType HeadMarkingsType
	{
		get
		{
			return _data.HeadMarkingsType;
		}
		set
		{
			_data.HeadMarkingsType = value;
			InvokeOnChange();
		}
	}

	public Color HeadGauntColor
	{
		get
		{
			return _data.HeadGauntColor;
		}
		set
		{
			_data.HeadGauntColor = value;
			InvokeOnChange();
		}
	}

	public Color HeadScruffyColor
	{
		get
		{
			return _data.HeadScruffyColor;
		}
		set
		{
			_data.HeadScruffyColor = value;
			InvokeOnChange();
		}
	}

	public Color HeadSnoutColor
	{
		get
		{
			return _data.HeadSnoutColor;
		}
		set
		{
			_data.HeadSnoutColor = value;
			InvokeOnChange();
		}
	}

	public Color HeadStripesColor
	{
		get
		{
			return _data.HeadStripesColor;
		}
		set
		{
			_data.HeadStripesColor = value;
			InvokeOnChange();
		}
	}

	public PlayerData.EHeadAccessoriesType HeadAccessoriesType
	{
		get
		{
			return _data.HeadAccessoriesType;
		}
		set
		{
			_data.HeadAccessoriesType = value;
			InvokeOnChange();
		}
	}

	public Color HeadHornsColor
	{
		get
		{
			return _data.HeadHornsColor;
		}
		set
		{
			_data.HeadHornsColor = value;
			InvokeOnChange();
		}
	}

	public Color EarColor
	{
		get
		{
			return _data.EarColor;
		}
		set
		{
			_data.EarColor = value;
			InvokeOnChange();
		}
	}

	public Color EarInnerColor
	{
		get
		{
			return _data.EarInnerColor;
		}
		set
		{
			_data.EarInnerColor = value;
			InvokeOnChange();
		}
	}

	public PlayerData.EEyesType EyesType
	{
		get
		{
			return _data.EyesType;
		}
		set
		{
			_data.EyesType = value;
			InvokeOnChange();
		}
	}

	public Color EyesBackColor
	{
		get
		{
			return _data.EyesBackColor;
		}
		set
		{
			_data.EyesBackColor = value;
			InvokeOnChange();
		}
	}

	public Color EyesFrontColor
	{
		get
		{
			return _data.EyesFrontColor;
		}
		set
		{
			_data.EyesFrontColor = value;
			InvokeOnChange();
		}
	}

	public PlayerData.EBrowType BrowType
	{
		get
		{
			return _data.BrowType;
		}
		set
		{
			_data.BrowType = value;
			InvokeOnChange();
		}
	}

	public Color BrowColor
	{
		get
		{
			return _data.BrowColor;
		}
		set
		{
			_data.BrowColor = value;
			InvokeOnChange();
		}
	}

	public PlayerData.EMuzzleType MuzzleType
	{
		get
		{
			return _data.MuzzleType;
		}
		set
		{
			_data.MuzzleType = value;
			InvokeOnChange();
		}
	}

	public Color MuzzleColor
	{
		get
		{
			return _data.MuzzleColor;
		}
		set
		{
			_data.MuzzleColor = value;
			InvokeOnChange();
		}
	}

	public Color NoseColor
	{
		get
		{
			return _data.NoseColor;
		}
		set
		{
			_data.NoseColor = value;
			InvokeOnChange();
		}
	}

	public Color TeethColor
	{
		get
		{
			return _data.TeethColor;
		}
		set
		{
			_data.TeethColor = value;
			InvokeOnChange();
		}
	}

	public bool ShowMuzzleHorn
	{
		get
		{
			return _data.ShowMuzzleHorn;
		}
		set
		{
			_data.ShowMuzzleHorn = value;
			InvokeOnChange();
		}
	}

	public Color MuzzleHornColor
	{
		get
		{
			return _data.MuzzleHornColor;
		}
		set
		{
			_data.MuzzleHornColor = value;
			InvokeOnChange();
		}
	}

	public bool ShowMuzzleMask
	{
		get
		{
			return _data.ShowMuzzleMask;
		}
		set
		{
			_data.ShowMuzzleMask = value;
			InvokeOnChange();
		}
	}

	public Color MuzzleMaskColor
	{
		get
		{
			return _data.MuzzleMaskColor;
		}
		set
		{
			_data.MuzzleMaskColor = value;
			InvokeOnChange();
		}
	}

	public PlayerData.EHairstyleType HairstyleType
	{
		get
		{
			return _data.HairstyleType;
		}
		set
		{
			_data.HairstyleType = value;
			InvokeOnChange();
		}
	}

	public Color HairColor
	{
		get
		{
			return _data.HairColor;
		}
		set
		{
			_data.HairColor = value;
			InvokeOnChange();
		}
	}

	public PlayerData.EFringeType FringeType
	{
		get
		{
			return _data.FringeType;
		}
		set
		{
			_data.FringeType = value;
			InvokeOnChange();
		}
	}

	public Color FringeColor
	{
		get
		{
			return _data.FringeColor;
		}
		set
		{
			_data.FringeColor = value;
			InvokeOnChange();
		}
	}

	public PlayerData.EFeetType FeetType
	{
		get
		{
			return _data.FeetType;
		}
		set
		{
			_data.FeetType = value;
			InvokeOnChange();
		}
	}

	public Color FeetColor
	{
		get
		{
			return _data.FeetColor;
		}
		set
		{
			_data.FeetColor = value;
			InvokeOnChange();
		}
	}

	public PlayerData.ETailType TailType
	{
		get
		{
			return _data.TailType;
		}
		set
		{
			_data.TailType = value;
			InvokeOnChange();
		}
	}

	public Color TailColor
	{
		get
		{
			return _data.TailColor;
		}
		set
		{
			_data.TailColor = value;
			InvokeOnChange();
		}
	}

	public bool ShowTailPartOne
	{
		get
		{
			return _data.ShowTailPartOne;
		}
		set
		{
			_data.ShowTailPartOne = value;
			InvokeOnChange();
		}
	}

	public Color TailPartOneColor
	{
		get
		{
			return _data.TailPartOneColor;
		}
		set
		{
			_data.TailPartOneColor = value;
			InvokeOnChange();
		}
	}

	public bool ShowTailPartTwo
	{
		get
		{
			return _data.ShowTailPartTwo;
		}
		set
		{
			_data.ShowTailPartTwo = value;
			InvokeOnChange();
		}
	}

	public Color TailPartTwoColor
	{
		get
		{
			return _data.TailPartTwoColor;
		}
		set
		{
			_data.TailPartTwoColor = value;
			InvokeOnChange();
		}
	}

	public PlayerData.EMarkingsType MarkingsType
	{
		get
		{
			return _data.MarkingsType;
		}
		set
		{
			_data.MarkingsType = value;
			InvokeOnChange();
		}
	}

	public Color UnderbellyColor
	{
		get
		{
			return _data.UnderbellyColor;
		}
		set
		{
			_data.UnderbellyColor = value;
			InvokeOnChange();
		}
	}

	public Color UnderthighColor
	{
		get
		{
			return _data.UnderthighColor;
		}
		set
		{
			_data.UnderthighColor = value;
			InvokeOnChange();
		}
	}

	public Color StripesColor
	{
		get
		{
			return _data.StripesColor;
		}
		set
		{
			_data.StripesColor = value;
			InvokeOnChange();
		}
	}

	public Color LongForearmColor
	{
		get
		{
			return _data.LongForearmColor;
		}
		set
		{
			_data.LongForearmColor = value;
			InvokeOnChange();
		}
	}

	public Color ShortForearmColor
	{
		get
		{
			return _data.ShortForearmColor;
		}
		set
		{
			_data.ShortForearmColor = value;
			InvokeOnChange();
		}
	}

	public Color AvianForearmColor
	{
		get
		{
			return _data.AvianForearmColor;
		}
		set
		{
			_data.AvianForearmColor = value;
			InvokeOnChange();
		}
	}

	public Color LongShinColor
	{
		get
		{
			return _data.LongShinColor;
		}
		set
		{
			_data.LongShinColor = value;
			InvokeOnChange();
		}
	}

	public Color ShortShinColor
	{
		get
		{
			return _data.ShortShinColor;
		}
		set
		{
			_data.ShortShinColor = value;
			InvokeOnChange();
		}
	}

	public Color AvianShinColor
	{
		get
		{
			return _data.AvianShinColor;
		}
		set
		{
			_data.AvianShinColor = value;
			InvokeOnChange();
		}
	}

	public PlayerData.ECockType CockType
	{
		get
		{
			return _data.CockType;
		}
		set
		{
			_data.CockType = value;
			InvokeOnChange();
		}
	}

	public Color GenitaliaColor
	{
		get
		{
			return _data.GenitaliaColor;
		}
		set
		{
			_data.GenitaliaColor = value;
			InvokeOnChange();
		}
	}

	public Color GenitaliaFleshColor
	{
		get
		{
			return _data.GenitaliaFleshColor;
		}
		set
		{
			_data.GenitaliaFleshColor = value;
			InvokeOnChange();
		}
	}

	public PlayerData.EBallsType BallsType
	{
		get
		{
			return _data.BallsType;
		}
		set
		{
			_data.BallsType = value;
			InvokeOnChange();
		}
	}

	public Color BallsColor
	{
		get
		{
			return _data.BallsColor;
		}
		set
		{
			_data.BallsColor = value;
			InvokeOnChange();
		}
	}

	public PlayerData.EBreastsType BreastsType
	{
		get
		{
			return _data.BreastsType;
		}
		set
		{
			_data.BreastsType = value;
			InvokeOnChange();
		}
	}

	public Color BreastsColor
	{
		get
		{
			return _data.BreastsColor;
		}
		set
		{
			_data.BreastsColor = value;
			InvokeOnChange();
		}
	}

	public bool ShowNipples
	{
		get
		{
			return _data.ShowNipples;
		}
		set
		{
			_data.ShowNipples = value;
			InvokeOnChange();
		}
	}

	public Color NipplesColor
	{
		get
		{
			return _data.NipplesColor;
		}
		set
		{
			_data.NipplesColor = value;
			InvokeOnChange();
		}
	}

	public Color PhoneColor
	{
		get
		{
			return _data.PhoneColor;
		}
		set
		{
			_data.PhoneColor = value;
			InvokeOnChange();
		}
	}

	public event Action OnChange;

	public PlayerDataProxy(PlayerData data)
	{
		_data = data;
	}

	public bool GetFlag(string key)
	{
		return _data.GetFlag(key);
	}

	public PlayerData GetPlayerData()
	{
		return _data;
	}

	private void InvokeOnChange()
	{
		this.OnChange?.Invoke();
	}
}
