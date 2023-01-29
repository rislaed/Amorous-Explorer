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
		SwitchToSubscene(VariantNone);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.SimulateTrack, 0.4f);
	}

	public override void SwitchToSubscene(string subscene)
	{
		base.SwitchToSubscene(subscene);
		BackgroundWestern.Visible = false;
		BackgroundRomantic.Visible = false;
		BackgroundHorror.Visible = false;
		BackgroundNone.Visible = false;
		switch (subscene)
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
