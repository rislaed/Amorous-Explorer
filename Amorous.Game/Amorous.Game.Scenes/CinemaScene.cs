namespace Amorous.Game.Scenes;

public class CinemaScene : AbstractScene
{
	public const string VariantNone = "None";
	public const string VariantWestern = "Western";
	public const string VariantRomantic = "Romantic";
	public const string VariantHorror = "Horror";

	private TexturedLayer BackgroundNone;
	private TexturedLayer BackgroundWestern;
	private TexturedLayer BackgroundRomantic;
	private TexturedLayer BackgroundHorror;

	public CinemaScene(IAmorous game)
		: base(game)
	{
		BackgroundNone = AddTexturedLayer("Background", "Assets/Scenes/Cinema/Movie None", 0, 0);
		BackgroundWestern = AddTexturedLayer("Background", "Assets/Scenes/Cinema/Movie Action-Western", 0, 0);
		BackgroundRomantic = AddTexturedLayer("Background", "Assets/Scenes/Cinema/Movie Comedy-Romantic", 0, 0);
		BackgroundHorror = AddTexturedLayer("Background", "Assets/Scenes/Cinema/Movie Noire Gloomy", 0, 0);
		SetVariant(VariantNone);
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/DJ-ZEK - Simulate", 0.4f);
	}

	public override void SetVariant(string variant)
	{
		base.SetVariant(variant);
		BackgroundWestern.Visible = false;
		BackgroundRomantic.Visible = false;
		BackgroundHorror.Visible = false;
		BackgroundNone.Visible = false;
		switch (variant)
		{
			case VariantRomantic:
				BackgroundRomantic.Visible = true;
				break;
			default:
				BackgroundNone.Visible = true;
				break;
			case VariantHorror:
				BackgroundHorror.Visible = true;
				break;
			case VariantWestern:
				BackgroundWestern.Visible = true;
				break;
		}
	}
}
