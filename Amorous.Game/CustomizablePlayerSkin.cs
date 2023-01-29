using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Xna.Framework;
using Newtonsoft.Json;

public class CustomizablePlayerSkin : AbstractPlayerSkin
{ // _MqMsYrF1I2ghuKhx3f6aKuRGquq
	public const int _X0FdDDJqVXe7X0FGiN6OsnaZtIF = 1040;
	public const int _qeKBLvATV3QS3jYy3CuAJCqqAtbA = 960;
	private const int _VTrOShnWP89ESyeqO1LPtrBoUIB = 350;

	private static readonly string _U8RMOUb18ulpoDDaA6ORCGlTl9P = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Saves");
	private static readonly string _yMVbZb1CBoa3bnnWLWCSnPFoK4o = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Saves/playertemplates.json");

	private readonly CustomizationData _KyRTfqdr2zZtsEAgkvOlUoQoB5j;
	private readonly List<PlayerCustomizationData> _HnbIDkSG3bmzUQyE7hhFdFKUaCcA = new List<PlayerCustomizationData>();
	private List<PlayerCustomizationData> _hFBs7DhxsNnkc55oFfnyfMJ6PKb = new List<PlayerCustomizationData>();
	private bool _Q5TLQ5C9mZDQgJZ3DcYHNl0Pbgn;
	private float _zoomScale;
	private int _nD28BmrDaEzCHelTAa14TKyuSyG;
	private int _zoomOffset;
	private int _cux27d2yUtT8iqgPFghmznXR0nC = 1000;
	private int _zoomInterpolation;
	private float _iM7i7fLtaIJgLy3ciRpenDbf5CHb;
	private float _ZTkD3TiiqWMrAbMLsoeIOBirnQc;
	private int _wBWHhq9jY0K2NLTqM11LsE4yDM;
	private int _kpLvTY6XXVX762n2WA2bxMWl8eL;

	private readonly JsonSerializerSettings ExtendedSerializers = new JsonSerializerSettings
	{
		TypeNameHandling = TypeNameHandling.Auto,
		Converters = { (JsonConverter)new ColorJsonConverter() }
	};

	private int _wO2k8QO0Jb1ECTFpHuFC2wQFtRB;
	private int _fqUhMheAq3WxPgLgXhgAKkZQOss { get; set; }

	public int Height
	{
		get
		{
			return _cux27d2yUtT8iqgPFghmznXR0nC;
		}
		set
		{
			if (_zoomInterpolation > 0 || _Q5TLQ5C9mZDQgJZ3DcYHNl0Pbgn)
			{
				return;
			}
			if (value <= _X0FdDDJqVXe7X0FGiN6OsnaZtIF)
			{
				if (value < _qeKBLvATV3QS3jYy3CuAJCqqAtbA)
				{
					_cux27d2yUtT8iqgPFghmznXR0nC = _qeKBLvATV3QS3jYy3CuAJCqqAtbA;
				}
				else
				{
					_cux27d2yUtT8iqgPFghmznXR0nC = value;
				}
			}
			else
			{
				_cux27d2yUtT8iqgPFghmznXR0nC = _X0FdDDJqVXe7X0FGiN6OsnaZtIF;
			}
			_zoomScale = (float)_cux27d2yUtT8iqgPFghmznXR0nC / (float)_KyRTfqdr2zZtsEAgkvOlUoQoB5j.Height;
			_zoomOffset = 1080 - _cux27d2yUtT8iqgPFghmznXR0nC - 20;
			UpdateLayers();
		}
	}

	public bool _vZ6v4a6UcXrp8I7fOK5GurTGvwg => _Q5TLQ5C9mZDQgJZ3DcYHNl0Pbgn;
	public IEnumerable<PlayerCustomizationData> _A088aXIdbVflSYtbl7vA5RjQOjXA => _HnbIDkSG3bmzUQyE7hhFdFKUaCcA;
	public IEnumerable<PlayerCustomizationData> _I6gsCHlb2BKFCJSAk9Cn5fCMAPu => _hFBs7DhxsNnkc55oFfnyfMJ6PKb;

	public CustomizablePlayerSkin(IAmorous game)
		: base(game)
	{
		string value = Compressions.ReadStreamAsText(Path.Combine(base.Game.Content.RootDirectory, "Data/PlayerCustomization/Customization.json"));
		_KyRTfqdr2zZtsEAgkvOlUoQoB5j = JsonConvert.DeserializeObject<CustomizationData>(value, ExtendedSerializers);
		value = Compressions.ReadStreamAsText(Path.Combine(base.Game.Content.RootDirectory, "Data/PlayerCustomization/DefaultTemplates.json"));
		PlayerCustomizationTemplatesData q0ZahtTsyov6ogSphMEhTo0NJfz = JsonConvert.DeserializeObject<PlayerCustomizationTemplatesData>(value, ExtendedSerializers);
		_HnbIDkSG3bmzUQyE7hhFdFKUaCcA.AddRange(q0ZahtTsyov6ogSphMEhTo0NJfz.Templates);
		_NTp4LybfIeImwrI3gGcIHmtkkDF();
		_zoomScale = (float)_cux27d2yUtT8iqgPFghmznXR0nC / (float)_KyRTfqdr2zZtsEAgkvOlUoQoB5j.Height;
		_nD28BmrDaEzCHelTAa14TKyuSyG = 400;
		_zoomOffset = 1080 - _cux27d2yUtT8iqgPFghmznXR0nC - 20;
	}

	public CustomizablePlayerSkin(IAmorous game, CustomizationData _oVHccpskJmMcOYan50N52Esmi8k_0, IEnumerable<PlayerCustomizationData> ienumerable_0)
		: base(game)
	{
		_KyRTfqdr2zZtsEAgkvOlUoQoB5j = _oVHccpskJmMcOYan50N52Esmi8k_0;
		_HnbIDkSG3bmzUQyE7hhFdFKUaCcA.AddRange(ienumerable_0);
		_zoomScale = (float)_cux27d2yUtT8iqgPFghmznXR0nC / (float)_KyRTfqdr2zZtsEAgkvOlUoQoB5j.Height;
		_nD28BmrDaEzCHelTAa14TKyuSyG = 400;
		_zoomOffset = 1080 - _cux27d2yUtT8iqgPFghmznXR0nC - 20;
	}

	public PlayerCustomizationData _aeTnyiKZSEemnK3AXL8to8blcUj(PlayerCustomizationData _xJL9E6vKdg1LYZtKQU5RQKikpvE_0)
	{
		return JsonConvert.DeserializeObject<PlayerCustomizationData>(JsonConvert.SerializeObject(_xJL9E6vKdg1LYZtKQU5RQKikpvE_0, ExtendedSerializers), ExtendedSerializers);
	}

	public void _0S3oMrwxDtOTcbzkglSllPfRq53(string string_0, PlayerData data)
	{
		_hFBs7DhxsNnkc55oFfnyfMJ6PKb.Add(data._3phsCUyg0G1wDNmHtsfmOUToBpF(string_0));
		_bItGCINkXiJ4CUgGi63Dq7RfLz8();
	}

	public void _WfRAwdaNcmrDEhMe1AHPq7egPcw(string string_0, int int_0, PlayerData data)
	{
		if (int_0 >= 0 && int_0 < _hFBs7DhxsNnkc55oFfnyfMJ6PKb.Count)
		{
			_hFBs7DhxsNnkc55oFfnyfMJ6PKb[int_0] = data._3phsCUyg0G1wDNmHtsfmOUToBpF(string_0);
			_bItGCINkXiJ4CUgGi63Dq7RfLz8();
		}
	}

	public void _JC60lfB4LT6VifObN1Ynm6iARlc(int int_0)
	{
		if (int_0 >= 0 && int_0 < _hFBs7DhxsNnkc55oFfnyfMJ6PKb.Count)
		{
			PlayerPreferences.GetPlayerData()._IVxmfAaagekk8d3cdgAtQRhbUY9(_hFBs7DhxsNnkc55oFfnyfMJ6PKb[int_0]);
			RefreshData();
		}
	}

	public void _FzyCgzYhOXEADaijk8VbcLulpcBA(int int_0)
	{
		if (int_0 >= 0 && int_0 < _hFBs7DhxsNnkc55oFfnyfMJ6PKb.Count)
		{
			_hFBs7DhxsNnkc55oFfnyfMJ6PKb.RemoveAt(int_0);
			_bItGCINkXiJ4CUgGi63Dq7RfLz8();
		}
	}

	public void _BwV21jdCpo4YpIp6x74bJ0H7hut(int int_0)
	{
		if (int_0 >= 0 && int_0 < _HnbIDkSG3bmzUQyE7hhFdFKUaCcA.Count)
		{
			PlayerPreferences.GetPlayerData()._IVxmfAaagekk8d3cdgAtQRhbUY9(_HnbIDkSG3bmzUQyE7hhFdFKUaCcA[int_0]);
			RefreshData();
		}
	}

	public void _BCRMBb9uhQZrQlfdXPidu27yb8C(int int_0)
	{
		if (int_0 >= 0 && int_0 < _hFBs7DhxsNnkc55oFfnyfMJ6PKb.Count)
		{
			PlayerPreferences.GetPlayerData()._IVxmfAaagekk8d3cdgAtQRhbUY9(_hFBs7DhxsNnkc55oFfnyfMJ6PKb[int_0]);
			RefreshData();
		}
	}

	public string _6qwooGF3jWmbG9887Y5IKZ8fJ0E(int int_0)
	{
		if (int_0 >= 0 && int_0 < _hFBs7DhxsNnkc55oFfnyfMJ6PKb.Count)
		{
			return _hFBs7DhxsNnkc55oFfnyfMJ6PKb[int_0].Name;
		}
		return string.Empty;
	}

	private void _bItGCINkXiJ4CUgGi63Dq7RfLz8()
	{
		if (!Directory.Exists(_U8RMOUb18ulpoDDaA6ORCGlTl9P))
		{
			Directory.CreateDirectory(_U8RMOUb18ulpoDDaA6ORCGlTl9P);
		}
		File.WriteAllText(_yMVbZb1CBoa3bnnWLWCSnPFoK4o, JsonConvert.SerializeObject(_hFBs7DhxsNnkc55oFfnyfMJ6PKb, ExtendedSerializers));
	}

	private void _NTp4LybfIeImwrI3gGcIHmtkkDF()
	{
		if (File.Exists(_yMVbZb1CBoa3bnnWLWCSnPFoK4o))
		{
			List<PlayerCustomizationData> list = JsonConvert.DeserializeObject<List<PlayerCustomizationData>>(File.ReadAllText(_yMVbZb1CBoa3bnnWLWCSnPFoK4o), ExtendedSerializers);
			if (list != null)
			{
				_hFBs7DhxsNnkc55oFfnyfMJ6PKb = list;
			}
		}
	}

	public void RefreshData()
	{
		foreach (CustomizationGroupData item in _KyRTfqdr2zZtsEAgkvOlUoQoB5j.Groups)
		{
			foreach (CustomizationLayerData item2 in item.Layers)
			{
				if (item2.Layer != null)
				{
					item2.Layer.Visible = false;
				}
			}
		}
		Initialize(PlayerPreferences.GetPlayerData());
		foreach (CustomizationGroupData item3 in _KyRTfqdr2zZtsEAgkvOlUoQoB5j.Groups)
		{
			foreach (CustomizationLayerData item4 in item3.Layers)
			{
				if (item4.Layer != null && !item4.Layer.Visible)
				{
					item4.Layer.Remove();
					base.Layers.Remove(item4.Layer);
					item4.Layer = null;
				}
			}
		}
	}

	private void _aXgmKv0acZSej4DXtFZ3EwykcX4(CustomizationGroupData _WmDwUqOXqj6xpaw8SzHUPXR0uwB_0, CustomizationLayerData _Qzndj0TwqO8yTQMbRwL4FFwlTbv_0)
	{
		_Qzndj0TwqO8yTQMbRwL4FFwlTbv_0.Layer = NewTexturedLayer(_Qzndj0TwqO8yTQMbRwL4FFwlTbv_0.AssetName, $"Assets/PlayerCustomization/{_WmDwUqOXqj6xpaw8SzHUPXR0uwB_0.Name}/{_Qzndj0TwqO8yTQMbRwL4FFwlTbv_0.AssetName}", _Qzndj0TwqO8yTQMbRwL4FFwlTbv_0.X + _nD28BmrDaEzCHelTAa14TKyuSyG, _Qzndj0TwqO8yTQMbRwL4FFwlTbv_0.Y + _zoomOffset, _Qzndj0TwqO8yTQMbRwL4FFwlTbv_0.ZOrder, _zoomScale);
		_Qzndj0TwqO8yTQMbRwL4FFwlTbv_0.Layer.Visible = false;
	}

	private void _MvwR0kE4wvi2cZX9CN5Dfu3jPWG(string string_0, string string_1, Color color_0)
	{
		CustomizationGroupData wmDwUqOXqj6xpaw8SzHUPXR0uwB = _KyRTfqdr2zZtsEAgkvOlUoQoB5j.Groups.FirstOrDefault((CustomizationGroupData _WmDwUqOXqj6xpaw8SzHUPXR0uwB_0) => _WmDwUqOXqj6xpaw8SzHUPXR0uwB_0.Name == string_0);
		if (wmDwUqOXqj6xpaw8SzHUPXR0uwB == null)
		{
			return;
		}
		foreach (CustomizationLayerData item in wmDwUqOXqj6xpaw8SzHUPXR0uwB.Layers)
		{
			if (item.Tags.Contains(string_1))
			{
				if (item.Layer == null)
				{
					_aXgmKv0acZSej4DXtFZ3EwykcX4(wmDwUqOXqj6xpaw8SzHUPXR0uwB, item);
				}
				item.Layer.Visible = true;
				item.Layer.Color = color_0;
				item.Layer.LayerOrder = _wO2k8QO0Jb1ECTFpHuFC2wQFtRB++;
			}
		}
	}

	public override void Initialize(PlayerData data)
	{
		_wO2k8QO0Jb1ECTFpHuFC2wQFtRB = 0;
		_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("BodyTypes", data.BodyType.ToString(), data.BodyColor);
		if (data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly))
		{
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Markings", data.BodyType.ToString() + "Underbelly", data.UnderbellyColor);
		}
		if (data.HeadType != PlayerData.EHeadType.PaperBag)
		{
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Heads", data.HeadType.ToString(), data.HeadColor);
			if (data.HeadMarkingsType.HasFlag(PlayerData.EHeadMarkingsType.Gaunt))
			{
				_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Heads", "Gaunt", data.HeadGauntColor);
			}
			if (data.HeadMarkingsType.HasFlag(PlayerData.EHeadMarkingsType.Scruffy))
			{
				_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Heads", "Scruffy", data.HeadScruffyColor);
			}
			if (data.HeadMarkingsType.HasFlag(PlayerData.EHeadMarkingsType.Snout))
			{
				_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Heads", "Snout", data.HeadSnoutColor);
			}
			if (data.HeadMarkingsType.HasFlag(PlayerData.EHeadMarkingsType.Stripes))
			{
				_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Heads", "Stripes", data.HeadStripesColor);
			}
		}
		else
		{
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Heads", "Humanoid", data.HeadColor);
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Heads", "PaperBag", data.PaperBagColor);
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Heads", "PaperBagEyes", data.PaperBagEyesColor);
		}
		_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Eyes", data.EyesType.ToString() + "Back", data.EyesBackColor);
		_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Eyes", data.EyesType.ToString() + "Front", data.EyesFrontColor);
		_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Eyebrows", data.BrowType.ToString(), data.BrowColor);
		_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("HeadAccessories", data.HeadAccessoriesType.ToString() + "Horn", data.HeadHornsColor);
		_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("HeadAccessories", data.HeadAccessoriesType.ToString() + "Ear", data.EarColor);
		_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("HeadAccessories", data.HeadAccessoriesType.ToString() + "EarInner", data.EarInnerColor);
		if (data.MuzzleType != PlayerData.EMuzzleType.Human)
		{
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Muzzles", data.MuzzleType.ToString(), data.MuzzleColor);
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Muzzles", data.MuzzleType.ToString() + "Nose", data.NoseColor);
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Muzzles", data.MuzzleType.ToString() + "Teeth", data.TeethColor);
		}
		else
		{
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Muzzles", data.MuzzleType.ToString(), data.BodyColor);
		}
		if (data.ShowMuzzleHorn)
		{
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Muzzles", data.MuzzleType.ToString() + "Horn", data.MuzzleHornColor);
		}
		if (data.ShowMuzzleMask)
		{
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Muzzles", data.MuzzleType.ToString() + "Mask", data.MuzzleMaskColor);
		}
		_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Hairstyles", data.HairstyleType.ToString(), data.HairColor);
		_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Hairstyles", data.FringeType.ToString() + "Fringe", data.FringeColor);
		_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Tails", data.TailType.ToString(), data.TailColor);
		if (data.ShowTailPartOne)
		{
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Tails", data.TailType.ToString() + "Part1", data.TailPartOneColor);
		}
		if (data.ShowTailPartTwo)
		{
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Tails", data.TailType.ToString() + "Part2", data.TailPartTwoColor);
		}
		_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Feet", data.FeetType.ToString(), data.FeetColor);
		if (data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underthigh))
		{
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Markings", data.BodyType.ToString() + "Underthigh", data.UnderthighColor);
		}
		if (data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes))
		{
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Markings", data.BodyType.ToString() + "Stripes", data.StripesColor);
		}
		if (data.MarkingsType.HasFlag(PlayerData.EMarkingsType.LongForearm))
		{
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Markings", data.BodyType.ToString() + "LongForearm", data.LongForearmColor);
		}
		if (data.MarkingsType.HasFlag(PlayerData.EMarkingsType.ShortForearm))
		{
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Markings", data.BodyType.ToString() + "ShortForearm", data.ShortForearmColor);
		}
		if (data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm))
		{
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Markings", data.BodyType.ToString() + "AvianForearm", data.AvianForearmColor);
		}
		if (data.MarkingsType.HasFlag(PlayerData.EMarkingsType.LongShin))
		{
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Markings", data.BodyType.ToString() + "LongShin", data.LongShinColor);
		}
		if (data.MarkingsType.HasFlag(PlayerData.EMarkingsType.ShortShin))
		{
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Markings", data.BodyType.ToString() + "ShortShin", data.ShortShinColor);
		}
		if (data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianShin))
		{
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Markings", data.BodyType.ToString() + "AvianShin", data.AvianShinColor);
		}
		if (!Censorship.Censored)
		{
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Balls", data.BallsType.ToString(), data.BallsColor);
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("MaleGenitalia", data.CockType.ToString(), data.GenitaliaColor);
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("MaleGenitalia", data.CockType.ToString() + "Flesh", data.GenitaliaFleshColor);
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Breasts", data.BreastsType.ToString(), data.BreastsColor);
			if (data.ShowNipples)
			{
				_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Breasts", data.BreastsType.ToString() + "Nipples", data.NipplesColor);
			}
		}
		if (data.ShowNails)
		{
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Nails", data.BodyType.ToString() + "Nail", data.NailColor);
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Nails", data.FeetType.ToString() + "Nails", data.NailColor);
		}
		_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Phone", "Case", data.PhoneColor);
		_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Phone", "Screen", Color.White);
	}

	public void _h7FmRKqsiolCVDHSPyo8tOOxJjI()
	{
		if (!_Q5TLQ5C9mZDQgJZ3DcYHNl0Pbgn)
		{
			_Q5TLQ5C9mZDQgJZ3DcYHNl0Pbgn = true;
			_zoomInterpolation = _VTrOShnWP89ESyeqO1LPtrBoUIB - _zoomInterpolation;
			_iM7i7fLtaIJgLy3ciRpenDbf5CHb = _zoomScale;
			_wBWHhq9jY0K2NLTqM11LsE4yDM = _zoomOffset;
			_ZTkD3TiiqWMrAbMLsoeIOBirnQc = 1f;
			_kpLvTY6XXVX762n2WA2bxMWl8eL = 0;
		}
	}

	public void _4yLGwEKDfxbcWN8YsEUfRhL5JK5()
	{
		if (_Q5TLQ5C9mZDQgJZ3DcYHNl0Pbgn)
		{
			_Q5TLQ5C9mZDQgJZ3DcYHNl0Pbgn = false;
			_zoomInterpolation = _VTrOShnWP89ESyeqO1LPtrBoUIB - _zoomInterpolation;
			_iM7i7fLtaIJgLy3ciRpenDbf5CHb = _zoomScale;
			_wBWHhq9jY0K2NLTqM11LsE4yDM = _zoomOffset;
			_ZTkD3TiiqWMrAbMLsoeIOBirnQc = (float)_cux27d2yUtT8iqgPFghmznXR0nC / (float)_KyRTfqdr2zZtsEAgkvOlUoQoB5j.Height;
			_kpLvTY6XXVX762n2WA2bxMWl8eL = 1080 - _cux27d2yUtT8iqgPFghmznXR0nC - 20;
		}
	}

	public void ToggleZoom()
	{
		if (_Q5TLQ5C9mZDQgJZ3DcYHNl0Pbgn)
		{
			_4yLGwEKDfxbcWN8YsEUfRhL5JK5();
		}
		else
		{
			_h7FmRKqsiolCVDHSPyo8tOOxJjI();
		}
	}

	public override void Update(GameTime gameTime)
	{
		int y = base.Game.Controller.Cursor.Y;
		if (_zoomInterpolation <= 0)
		{
			if (_vZ6v4a6UcXrp8I7fOK5GurTGvwg && base.Game.Controller.IsPressed(ControllerButtonType.LeftButton))
			{
				int num = y - _fqUhMheAq3WxPgLgXhgAKkZQOss;
				if (num != 0)
				{
					_zoomOffset = Math.Min(Math.Max(-1600, _zoomOffset + num), 0);
					UpdateLayers();
				}
			}
			_fqUhMheAq3WxPgLgXhgAKkZQOss = y;
			return;
		}
		_zoomInterpolation -= gameTime.ElapsedGameTime.Milliseconds;
		if (_zoomInterpolation <= 0)
		{
			_zoomInterpolation = 0;
			_zoomScale = _ZTkD3TiiqWMrAbMLsoeIOBirnQc;
			_zoomOffset = _kpLvTY6XXVX762n2WA2bxMWl8eL;
		}
		else
		{
			float amount = (float)_zoomInterpolation / 350f;
			_zoomScale = MathHelper.Lerp(_ZTkD3TiiqWMrAbMLsoeIOBirnQc, _iM7i7fLtaIJgLy3ciRpenDbf5CHb, amount);
			_zoomOffset = (int)MathHelper.Lerp(_kpLvTY6XXVX762n2WA2bxMWl8eL, _wBWHhq9jY0K2NLTqM11LsE4yDM, amount);
		}
		UpdateLayers();
		_fqUhMheAq3WxPgLgXhgAKkZQOss = y;
	}

	private void UpdateLayers()
	{
		using List<AbstractLayer>.Enumerator enumerator = base.Layers.GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.Scale = _zoomScale;
			enumerator.Current.Y = _zoomOffset;
		}
	}
}
