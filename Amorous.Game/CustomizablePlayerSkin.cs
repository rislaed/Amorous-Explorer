using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Xna.Framework;
using Newtonsoft.Json;

public class CustomizablePlayerSkin : AbstractPlayerOverlay
{ // _MqMsYrF1I2ghuKhx3f6aKuRGquq
	public const int MAX_HEIGHT = 1040;
	public const int MIN_HEIGHT = 960;
	private const int ZoomHeight = 350;

	private static readonly string SAVES_DIRECTORY = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Saves");
	private static readonly string PLAYER_TEMPLATES = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Saves/playertemplates.json");

	private readonly CustomizationData customizationData;
	private readonly List<PlayerCustomizationData> stockTemplates = new List<PlayerCustomizationData>();
	private List<PlayerCustomizationData> customTemplates = new List<PlayerCustomizationData>();
	private bool zoomed;
	private float zoomScale;
	private int zoomOffsetX;
	private int zoomOffsetY;
	private int height = 1000;
	private int zoomAmount;
	private float targetZoomingScale;
	private float lastZoomingScale;
	private int targetZoomingOffsetY;
	private int lastZoomingOffsetY;

	private readonly JsonSerializerSettings ExtendedSerializers = new JsonSerializerSettings
	{
		TypeNameHandling = TypeNameHandling.Auto,
		Converters = { (JsonConverter)new ColorJsonConverter() }
	};

	private int indexOfLayer;
	private int cursorLastY { get; set; }

	public int Height
	{
		get
		{
			return height;
		}
		set
		{
			if (zoomAmount > 0 || zoomed)
			{
				return;
			}
			if (value <= MAX_HEIGHT)
			{
				if (value < MIN_HEIGHT)
				{
					height = MIN_HEIGHT;
				}
				else
				{
					height = value;
				}
			}
			else
			{
				height = MAX_HEIGHT;
			}
			zoomScale = (float)height / (float)customizationData.Height;
			zoomOffsetY = 1080 - height - 20;
			UpdateZooming();
		}
	}

	public bool IsZoomed => zoomed;
	public IEnumerable<PlayerCustomizationData> StockTemplates => stockTemplates;
	public IEnumerable<PlayerCustomizationData> CustomTemplates => customTemplates;

	public CustomizablePlayerSkin(IAmorous game) : base(game)
	{
		string value = Compressions.ReadStreamAsText(Path.Combine(base.Game.Content.RootDirectory, "Data/PlayerCustomization/Customization.json"));
		customizationData = JsonConvert.DeserializeObject<CustomizationData>(value, ExtendedSerializers);
		value = Compressions.ReadStreamAsText(Path.Combine(base.Game.Content.RootDirectory, "Data/PlayerCustomization/DefaultTemplates.json"));
		PlayerCustomizationTemplatesData templatesData = JsonConvert.DeserializeObject<PlayerCustomizationTemplatesData>(value, ExtendedSerializers);
		stockTemplates.AddRange(templatesData.Templates);
		Load();
		zoomScale = (float)height / (float)customizationData.Height;
		zoomOffsetX = 400;
		zoomOffsetY = 1080 - height - 20;
	}

	public CustomizablePlayerSkin(IAmorous game, CustomizationData data, IEnumerable<PlayerCustomizationData> prototype) : base(game)
	{
		customizationData = data;
		stockTemplates.AddRange(prototype);
		zoomScale = (float)height / (float)customizationData.Height;
		zoomOffsetX = 400;
		zoomOffsetY = 1080 - height - 20;
	}

	public PlayerCustomizationData Validate(PlayerCustomizationData data)
	{
		return JsonConvert.DeserializeObject<PlayerCustomizationData>(JsonConvert.SerializeObject(data, ExtendedSerializers), ExtendedSerializers);
	}

	public void AddCustomTemplate(string name, PlayerData data)
	{
		customTemplates.Add(data.NewCustomizationData(name));
		Save();
	}

	public void AddCustomTemplateAtIndex(string name, int index, PlayerData data)
	{
		if (index >= 0 && index < customTemplates.Count)
		{
			customTemplates[index] = data.NewCustomizationData(name);
			Save();
		}
	}

	public void ResetCustomTemplate(int index)
	{
		if (index >= 0 && index < customTemplates.Count)
		{
			PlayerPreferences.GetPlayerData().CloneCustomizationData(customTemplates[index]);
			Refresh();
		}
	}

	public void RemoveCustomTemplate(int index)
	{
		if (index >= 0 && index < customTemplates.Count)
		{
			customTemplates.RemoveAt(index);
			Save();
		}
	}

	public void CloneStockTemplate(int index)
	{
		if (index >= 0 && index < stockTemplates.Count)
		{
			PlayerPreferences.GetPlayerData().CloneCustomizationData(stockTemplates[index]);
			Refresh();
		}
	}

	public void CloneCustomTemplate(int index)
	{
		if (index >= 0 && index < customTemplates.Count)
		{
			PlayerPreferences.GetPlayerData().CloneCustomizationData(customTemplates[index]);
			Refresh();
		}
	}

	public string GetCustomTemplateName(int index)
	{
		if (index >= 0 && index < customTemplates.Count)
		{
			return customTemplates[index].Name;
		}
		return string.Empty;
	}

	private void Save()
	{
		if (!Directory.Exists(SAVES_DIRECTORY))
		{
			Directory.CreateDirectory(SAVES_DIRECTORY);
		}
		File.WriteAllText(PLAYER_TEMPLATES, JsonConvert.SerializeObject(customTemplates, ExtendedSerializers));
	}

	private void Load()
	{
		if (File.Exists(PLAYER_TEMPLATES))
		{
			List<PlayerCustomizationData> templates = JsonConvert.DeserializeObject<List<PlayerCustomizationData>>(File.ReadAllText(PLAYER_TEMPLATES), ExtendedSerializers);
			if (templates != null)
			{
				customTemplates = templates;
			}
		}
	}

	public void Refresh()
	{
		foreach (CustomizationGroupData item in customizationData.Groups)
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
		foreach (CustomizationGroupData item3 in customizationData.Groups)
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
		layerData.Layer = AddSpriteLayer(layerData.AssetName, $"Assets/PlayerCustomization/{groupData.Name}/{layerData.AssetName}", layerData.X + zoomOffsetX, layerData.Y + zoomOffsetY, layerData.ZOrder, zoomScale);
		layerData.Layer.Visible = false;
	}

	private void SerializeColor(string group, string tag, Color color)
	{
		CustomizationGroupData groupData = customizationData.Groups.FirstOrDefault((CustomizationGroupData data) => data.Name == group);
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
				layerData.Layer.LayerOrder = indexOfLayer++;
			}
		}
	}

	public override void Initialize(PlayerData data)
	{
		indexOfLayer = 0;
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
		if (!zoomed)
		{
			zoomed = true;
			zoomAmount = ZoomHeight - zoomAmount;
			targetZoomingScale = zoomScale;
			targetZoomingOffsetY = zoomOffsetY;
			lastZoomingScale = 1f;
			lastZoomingOffsetY = 0;
		}
	}

	public void ZoomOut()
	{
		if (zoomed)
		{
			zoomed = false;
			zoomAmount = ZoomHeight - zoomAmount;
			targetZoomingScale = zoomScale;
			targetZoomingOffsetY = zoomOffsetY;
			lastZoomingScale = (float)height / (float)customizationData.Height;
			lastZoomingOffsetY = 1080 - height - 20;
		}
	}

	public void ToggleZoom()
	{
		if (zoomed)
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
		if (zoomAmount <= 0)
		{
			if (IsZoomed && base.Game.Controller.IsHolding(ControllerButtonType.LeftButton))
			{
				int offset = y - cursorLastY;
				if (offset != 0)
				{
					zoomOffsetY = Math.Min(Math.Max(-1600, zoomOffsetY + offset), 0);
					UpdateZooming();
				}
			}
			cursorLastY = y;
			return;
		}
		zoomAmount -= gameTime.ElapsedGameTime.Milliseconds;
		if (zoomAmount <= 0)
		{
			zoomAmount = 0;
			zoomScale = lastZoomingScale;
			zoomOffsetY = lastZoomingOffsetY;
		}
		else
		{
			float amount = (float)zoomAmount / 350f;
			zoomScale = MathHelper.Lerp(lastZoomingScale, targetZoomingScale, amount);
			zoomOffsetY = (int)MathHelper.Lerp(lastZoomingOffsetY, targetZoomingOffsetY, amount);
		}
		UpdateZooming();
		cursorLastY = y;
	}

	private void UpdateZooming()
	{
		using List<AbstractLayer>.Enumerator layers = base.Layers.GetEnumerator();
		while (layers.MoveNext())
		{
			layers.Current.Scale = zoomScale;
			layers.Current.Y = zoomOffsetY;
		}
	}
}
