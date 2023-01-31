namespace Amorous.Game.Scenes;

public class CinemaScene : AbstractScene
{
	public const string VariantNone = "None";
	public const string VariantWestern = "Western";
	public const string VariantRomantic = "Romantic";
	public const string VariantHorror = "Horror";

	private SpriteLayer BackgroundNone, BackgroundWestern, BackgroundRomantic, BackgroundHorror;

	public CinemaScene(IAmorous game)
		: base(game)
	{
		BackgroundNone = AddSpriteLayer("Background", "Assets/Scenes/Cinema/Movie None", 0, 0);
		BackgroundWestern = AddSpriteLayer("Background", "Assets/Scenes/Cinema/Movie Action-Western", 0, 0);
		BackgroundRomantic = AddSpriteLayer("Background", "Assets/Scenes/Cinema/Movie Comedy-Romantic", 0, 0);
		BackgroundHorror = AddSpriteLayer("Background", "Assets/Scenes/Cinema/Movie Noire Gloomy", 0, 0);
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
