using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Xna.Framework;
using Newtonsoft.Json;

public class CustomizablePlayerSkin : AbstractPlayerOverlay
{ // _MqMsYrF1I2ghuKhx3f6aKuRGquq
	public const int MaxHeight = 1040;
	public const int MinHeight = 960;
	private const int ZoomHeight = 350;

	private static readonly string SavesFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Saves");
	private static readonly string PlayerTemplatesFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Saves/playertemplates.json");

	private readonly CustomizationData _customizationData;
	private readonly List<PlayerCustomizationData> _stockTemplates = new List<PlayerCustomizationData>();
	private List<PlayerCustomizationData> _customTemplates = new List<PlayerCustomizationData>();
	private bool _zoomed;
	private float _zoomScale;
	private int _zoomOffsetX;
	private int _zoomOffsetY;
	private int _height = 1000;
	private int _zoomInterpolation;
	private float _targetZoomScale;
	private float _previousZoomScale;
	private int _targetZoomOffsetY;
	private int _previousZoomOffsetY;

	private readonly JsonSerializerSettings ExtendedSerializers = new JsonSerializerSettings
	{
		TypeNameHandling = TypeNameHandling.Auto,
		Converters = { (JsonConverter)new ColorJsonConverter() }
	};

	private int _spriteIndex;
	private int _previousCursorY { get; set; }

	public int Height
	{
		get
		{
			return _height;
		}
		set
		{
			if (_zoomInterpolation > 0 || _zoomed)
			{
				return;
			}
			if (value <= MaxHeight)
			{
				if (value < MinHeight)
				{
					_height = MinHeight;
				}
				else
				{
					_height = value;
				}
			}
			else
			{
				_height = MaxHeight;
			}
			_zoomScale = (float)_height / (float)_customizationData.Height;
			_zoomOffsetY = 1080 - _height - 20;
			UpdateZooming();
		}
	}

	public bool IsZoomed => _zoomed;
	public IEnumerable<PlayerCustomizationData> StockTemplates => _stockTemplates;
	public IEnumerable<PlayerCustomizationData> CustomTemplates => _customTemplates;

	public CustomizablePlayerSkin(IAmorous game)
		: base(game)
	{
		string value = Compressions.ReadStreamAsText(Path.Combine(base.Game.Content.RootDirectory, "Data/PlayerCustomization/Customization.json"));
		_customizationData = JsonConvert.DeserializeObject<CustomizationData>(value, ExtendedSerializers);
		value = Compressions.ReadStreamAsText(Path.Combine(base.Game.Content.RootDirectory, "Data/PlayerCustomization/DefaultTemplates.json"));
		PlayerCustomizationTemplatesData templatesData = JsonConvert.DeserializeObject<PlayerCustomizationTemplatesData>(value, ExtendedSerializers);
		_stockTemplates.AddRange(templatesData.Templates);
		Load();
		_zoomScale = (float)_height / (float)_customizationData.Height;
		_zoomOffsetX = 400;
		_zoomOffsetY = 1080 - _height - 20;
	}

	public CustomizablePlayerSkin(IAmorous game, CustomizationData data, IEnumerable<PlayerCustomizationData> prototype)
		: base(game)
	{
		_customizationData = data;
		_stockTemplates.AddRange(prototype);
		_zoomScale = (float)_height / (float)_customizationData.Height;
		_zoomOffsetX = 400;
		_zoomOffsetY = 1080 - _height - 20;
	}

	public PlayerCustomizationData Validate(PlayerCustomizationData data)
	{
		return JsonConvert.DeserializeObject<PlayerCustomizationData>(JsonConvert.SerializeObject(data, ExtendedSerializers), ExtendedSerializers);
	}

	public void AddCustomTemplate(string name, PlayerData data)
	{
		_customTemplates.Add(data.NewCustomizationData(name));
		Save();
	}

	public void AddCustomTemplateAtIndex(string name, int index, PlayerData data)
	{
		if (index >= 0 && index < _customTemplates.Count)
		{
			_customTemplates[index] = data.NewCustomizationData(name);
			Save();
		}
	}

	public void ResetCustomTemplate(int index)
	{
		if (index >= 0 && index < _customTemplates.Count)
		{
			PlayerPreferences.GetPlayerData().CloneCustomizationData(_customTemplates[index]);
			Refresh();
		}
	}

	public void RemoveCustomTemplate(int index)
	{
		if (index >= 0 && index < _customTemplates.Count)
		{
			_customTemplates.RemoveAt(index);
			Save();
		}
	}

	public void CloneStockTemplate(int index)
	{
		if (index >= 0 && index < _stockTemplates.Count)
		{
			PlayerPreferences.GetPlayerData().CloneCustomizationData(_stockTemplates[index]);
			Refresh();
		}
	}

	public void CloneCustomTemplate(int index)
	{
		if (index >= 0 && index < _customTemplates.Count)
		{
			PlayerPreferences.GetPlayerData().CloneCustomizationData(_customTemplates[index]);
			Refresh();
		}
	}

	public string GetCustomTemplateName(int index)
	{
		if (index >= 0 && index < _customTemplates.Count)
		{
			return _customTemplates[index].Name;
		}
		return string.Empty;
	}

	private void Save()
	{
		if (!Directory.Exists(SavesFolder))
		{
			Directory.CreateDirectory(SavesFolder);
		}
		File.WriteAllText(PlayerTemplatesFile, JsonConvert.SerializeObject(_customTemplates, ExtendedSerializers));
	}

	private void Load()
	{
		if (File.Exists(PlayerTemplatesFile))
		{
			List<PlayerCustomizationData> templates = JsonConvert.DeserializeObject<List<PlayerCustomizationData>>(File.ReadAllText(PlayerTemplatesFile), ExtendedSerializers);
			if (templates != null)
			{
				_customTemplates = templates;
			}
		}
	}

	public void Refresh()
	{
		foreach (CustomizationGroupData item in _customizationData.Groups)
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
		foreach (CustomizationGroupData item3 in _customizationData.Groups)
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

	private void CreateLayerSprite(CustomizationGroupData groupData, CustomizationLayerData layerData)
	{
		layerData.Layer = NewSpriteLayer(layerData.AssetName, $"Assets/PlayerCustomization/{groupData.Name}/{layerData.AssetName}", layerData.X + _zoomOffsetX, layerData.Y + _zoomOffsetY, layerData.ZOrder, _zoomScale);
		layerData.Layer.Visible = false;
	}

	private void SerializeColor(string group, string tag, Color color)
	{
		CustomizationGroupData groupData = _customizationData.Groups.FirstOrDefault((CustomizationGroupData data) => data.Name == group);
		if (groupData == null)
		{
			return;
		}
		foreach (CustomizationLayerData layerData in groupData.Layers)
		{
			if (layerData.Tags.Contains(tag))
			{
				if (layerData.Layer == null)
				{
					CreateLayerSprite(groupData, layerData);
				}
				layerData.Layer.Visible = true;
				layerData.Layer.Color = color;
				layerData.Layer.LayerOrder = _spriteIndex++;
			}
		}
	}

	public override void Initialize(PlayerData data)
	{
		_spriteIndex = 0;
		SerializeColor("BodyTypes", data.BodyType.ToString(), data.BodyColor);
		if (data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly))
		{
			SerializeColor("Markings", data.BodyType.ToString() + "Underbelly", data.UnderbellyColor);
		}
		if (data.HeadType != PlayerData.EHeadType.PaperBag)
		{
			SerializeColor("Heads", data.HeadType.ToString(), data.HeadColor);
			if (data.HeadMarkingsType.HasFlag(PlayerData.EHeadMarkingsType.Gaunt))
			{
				SerializeColor("Heads", "Gaunt", data.HeadGauntColor);
			}
			if (data.HeadMarkingsType.HasFlag(PlayerData.EHeadMarkingsType.Scruffy))
			{
				SerializeColor("Heads", "Scruffy", data.HeadScruffyColor);
			}
			if (data.HeadMarkingsType.HasFlag(PlayerData.EHeadMarkingsType.Snout))
			{
				SerializeColor("Heads", "Snout", data.HeadSnoutColor);
			}
			if (data.HeadMarkingsType.HasFlag(PlayerData.EHeadMarkingsType.Stripes))
			{
				SerializeColor("Heads", "Stripes", data.HeadStripesColor);
			}
		}
		else
		{
			SerializeColor("Heads", "Humanoid", data.HeadColor);
			SerializeColor("Heads", "PaperBag", data.PaperBagColor);
			SerializeColor("Heads", "PaperBagEyes", data.PaperBagEyesColor);
		}
		SerializeColor("Eyes", data.EyesType.ToString() + "Back", data.EyesBackColor);
		SerializeColor("Eyes", data.EyesType.ToString() + "Front", data.EyesFrontColor);
		SerializeColor("Eyebrows", data.BrowType.ToString(), data.BrowColor);
		SerializeColor("HeadAccessories", data.HeadAccessoriesType.ToString() + "Horn", data.HeadHornsColor);
		SerializeColor("HeadAccessories", data.HeadAccessoriesType.ToString() + "Ear", data.EarColor);
		SerializeColor("HeadAccessories", data.HeadAccessoriesType.ToString() + "EarInner", data.EarInnerColor);
		if (data.MuzzleType != PlayerData.EMuzzleType.Human)
		{
			SerializeColor("Muzzles", data.MuzzleType.ToString(), data.MuzzleColor);
			SerializeColor("Muzzles", data.MuzzleType.ToString() + "Nose", data.NoseColor);
			SerializeColor("Muzzles", data.MuzzleType.ToString() + "Teeth", data.TeethColor);
		}
		else
		{
			SerializeColor("Muzzles", data.MuzzleType.ToString(), data.BodyColor);
		}
		if (data.ShowMuzzleHorn)
		{
			SerializeColor("Muzzles", data.MuzzleType.ToString() + "Horn", data.MuzzleHornColor);
		}
		if (data.ShowMuzzleMask)
		{
			SerializeColor("Muzzles", data.MuzzleType.ToString() + "Mask", data.MuzzleMaskColor);
		}
		SerializeColor("Hairstyles", data.HairstyleType.ToString(), data.HairColor);
		SerializeColor("Hairstyles", data.FringeType.ToString() + "Fringe", data.FringeColor);
		SerializeColor("Tails", data.TailType.ToString(), data.TailColor);
		if (data.ShowTailPartOne)
		{
			SerializeColor("Tails", data.TailType.ToString() + "Part1", data.TailPartOneColor);
		}
		if (data.ShowTailPartTwo)
		{
			SerializeColor("Tails", data.TailType.ToString() + "Part2", data.TailPartTwoColor);
		}
		SerializeColor("Feet", data.FeetType.ToString(), data.FeetColor);
		if (data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underthigh))
		{
			SerializeColor("Markings", data.BodyType.ToString() + "Underthigh", data.UnderthighColor);
		}
		if (data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes))
		{
			SerializeColor("Markings", data.BodyType.ToString() + "Stripes", data.StripesColor);
		}
		if (data.MarkingsType.HasFlag(PlayerData.EMarkingsType.LongForearm))
		{
			SerializeColor("Markings", data.BodyType.ToString() + "LongForearm", data.LongForearmColor);
		}
		if (data.MarkingsType.HasFlag(PlayerData.EMarkingsType.ShortForearm))
		{
			SerializeColor("Markings", data.BodyType.ToString() + "ShortForearm", data.ShortForearmColor);
		}
		if (data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm))
		{
			SerializeColor("Markings", data.BodyType.ToString() + "AvianForearm", data.AvianForearmColor);
		}
		if (data.MarkingsType.HasFlag(PlayerData.EMarkingsType.LongShin))
		{
			SerializeColor("Markings", data.BodyType.ToString() + "LongShin", data.LongShinColor);
		}
		if (data.MarkingsType.HasFlag(PlayerData.EMarkingsType.ShortShin))
		{
			SerializeColor("Markings", data.BodyType.ToString() + "ShortShin", data.ShortShinColor);
		}
		if (data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianShin))
		{
			SerializeColor("Markings", data.BodyType.ToString() + "AvianShin", data.AvianShinColor);
		}
		if (!Censorship.Censored)
		{
			SerializeColor("Balls", data.BallsType.ToString(), data.BallsColor);
			SerializeColor("MaleGenitalia", data.CockType.ToString(), data.GenitaliaColor);
			SerializeColor("MaleGenitalia", data.CockType.ToString() + "Flesh", data.GenitaliaFleshColor);
			SerializeColor("Breasts", data.BreastsType.ToString(), data.BreastsColor);
			if (data.ShowNipples)
			{
				SerializeColor("Breasts", data.BreastsType.ToString() + "Nipples", data.NipplesColor);
			}
		}
		if (data.ShowNails)
		{
			SerializeColor("Nails", data.BodyType.ToString() + "Nail", data.NailColor);
			SerializeColor("Nails", data.FeetType.ToString() + "Nails", data.NailColor);
		}
		SerializeColor("Phone", "Case", data.PhoneColor);
		SerializeColor("Phone", "Screen", Color.White);
	}

	public void ZoomIn()
	{
		if (!_zoomed)
		{
			_zoomed = true;
			_zoomInterpolation = ZoomHeight - _zoomInterpolation;
			_targetZoomScale = _zoomScale;
			_targetZoomOffsetY = _zoomOffsetY;
			_previousZoomScale = 1f;
			_previousZoomOffsetY = 0;
		}
	}

	public void ZoomOut()
	{
		if (_zoomed)
		{
			_zoomed = false;
			_zoomInterpolation = ZoomHeight - _zoomInterpolation;
			_targetZoomScale = _zoomScale;
			_targetZoomOffsetY = _zoomOffsetY;
			_previousZoomScale = (float)_height / (float)_customizationData.Height;
			_previousZoomOffsetY = 1080 - _height - 20;
		}
	}

	public void ToggleZoom()
	{
		if (_zoomed)
		{
			ZoomOut();
		}
		else
		{
			ZoomIn();
		}
	}

	public override void Update(GameTime gameTime)
	{
		int y = base.Game.Controller.Cursor.Y;
		if (_zoomInterpolation <= 0)
		{
			if (IsZoomed && base.Game.Controller.IsHolding(ControllerButtonType.LeftButton))
			{
				int offset = y - _previousCursorY;
				if (offset != 0)
				{
					_zoomOffsetY = Math.Min(Math.Max(-1600, _zoomOffsetY + offset), 0);
					UpdateZooming();
				}
			}
			_previousCursorY = y;
			return;
		}
		_zoomInterpolation -= gameTime.ElapsedGameTime.Milliseconds;
		if (_zoomInterpolation <= 0)
		{
			_zoomInterpolation = 0;
			_zoomScale = _previousZoomScale;
			_zoomOffsetY = _previousZoomOffsetY;
		}
		else
		{
			float amount = (float)_zoomInterpolation / 350f;
			_zoomScale = MathHelper.Lerp(_previousZoomScale, _targetZoomScale, amount);
			_zoomOffsetY = (int)MathHelper.Lerp(_previousZoomOffsetY, _targetZoomOffsetY, amount);
		}
		UpdateZooming();
		_previousCursorY = y;
	}

	private void UpdateZooming()
	{
		using List<AbstractLayer>.Enumerator layers = base.Layers.GetEnumerator();
		while (layers.MoveNext())
		{
			layers.Current.Scale = _zoomScale;
			layers.Current.Y = _zoomOffsetY;
		}
	}
}
