public class MainMenuPlayerSkin : AbstractPlayerOverlay
{ // _hiwkgwXJpRLUFatcgZFfH6ECNfm
	private static SpriteLayer bicepLayer, bicepStripeLayer, nailsLayer, handlayer, handColorLayer, forearmLayer,
							   forearmColorLongLayer, forearmColorShortLayer, forearmStripesLayer,
							   forearmAvianLayer, bicepAvianLayer, handAvianLayer;

	public MainMenuPlayerSkin(IAmorous game) : base(game)
	{
		bicepLayer = AddSpriteLayer("Bicep", "Assets/Scenes/MainMenu/Bicep", -240, -135);
		nailsLayer = AddSpriteLayer("Nails", "Assets/Scenes/MainMenu/Nails", -240, -135);
		handlayer = AddSpriteLayer("Hand", "Assets/Scenes/MainMenu/Hand", -240, -135);
		forearmLayer = AddSpriteLayer("Forearm", "Assets/Scenes/MainMenu/Forearm", -240, -135);
		bicepStripeLayer = AddSpriteLayer("Bicep Stripe", "Assets/Scenes/MainMenu/Stripe bicep", -240, -135);
		handColorLayer = AddSpriteLayer("Hand Color", "Assets/Scenes/MainMenu/Marking long or short hand", -240, -135);
		forearmColorLongLayer = AddSpriteLayer("Forearm Color Long", "Assets/Scenes/MainMenu/Marking long forearm", -240, -135);
		forearmColorShortLayer = AddSpriteLayer("Forearm Color Short", "Assets/Scenes/MainMenu/Marking short forearm", -240, -135);
		forearmStripesLayer = AddSpriteLayer("Forearm Stripes", "Assets/Scenes/MainMenu/Stripe forearm", -240, -135);
		forearmAvianLayer = AddSpriteLayer("Forearm Avian", "Assets/Scenes/MainMenu/Avian forearm", -240, -135);
		bicepAvianLayer = AddSpriteLayer("Bicep Avian", "Assets/Scenes/MainMenu/Avian bicep", -240, -135);
		handAvianLayer = AddSpriteLayer("Hand Avian", "Assets/Scenes/MainMenu/Avian hand", -240, -135);
	}

	public override void Initialize(PlayerData data)
	{
		bicepLayer.Color = data.BodyColor;
		nailsLayer.Color = data.NailColor;
		nailsLayer.Visible = data.ShowNails;
		handlayer.Color = data.BodyColor;
		forearmLayer.Color = data.BodyColor;
		bicepStripeLayer.Color = data.StripesColor;
		bicepStripeLayer.Visible = data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes);
		handColorLayer.Color = data.LongForearmColor;
		handColorLayer.Visible = data.MarkingsType.HasFlag(PlayerData.EMarkingsType.LongForearm);
		forearmColorLongLayer.Color = data.LongForearmColor;
		forearmColorLongLayer.Visible = data.MarkingsType.HasFlag(PlayerData.EMarkingsType.LongForearm);
		forearmColorShortLayer.Color = data.ShortForearmColor;
		forearmColorShortLayer.Visible = data.MarkingsType.HasFlag(PlayerData.EMarkingsType.ShortForearm);
		forearmStripesLayer.Color = data.StripesColor;
		forearmStripesLayer.Visible = data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes);
		forearmAvianLayer.Color = data.AvianForearmColor;
		forearmAvianLayer.Visible = data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm);
		bicepAvianLayer.Color = data.AvianForearmColor;
		bicepAvianLayer.Visible = data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm);
		handAvianLayer.Color = data.AvianForearmColor;
		handAvianLayer.Visible = data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm);
	}
}
