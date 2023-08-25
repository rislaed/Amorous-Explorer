namespace Amorous.Game.Scenes;

public class CinemaScene : AbstractScene
{
	public const string VARIANT_NONE = "None";
	public const string VARIANT_WESTERN = "Western";
	public const string VARIANT_ROMANTIC = "Romantic";
	public const string VARIANT_HORROR = "Horror";

	private SpriteLayer backgroundNone, backgroundWestern, backgroundRomantic, ackgroundHorror;

	public CinemaScene(IAmorous game) : base(game)
	{
		backgroundNone = AddSpriteLayer("Background", "Assets/Scenes/Cinema/Movie None", 0, 0);
		backgroundWestern = AddSpriteLayer("Background", "Assets/Scenes/Cinema/Movie Action-Western", 0, 0);
		backgroundRomantic = AddSpriteLayer("Background", "Assets/Scenes/Cinema/Movie Comedy-Romantic", 0, 0);
		ackgroundHorror = AddSpriteLayer("Background", "Assets/Scenes/Cinema/Movie Noire Gloomy", 0, 0);
		SwitchToSubscene(VARIANT_NONE);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.SimulateTrack, 0.4f);
	}

	public override void SwitchToSubscene(string subscene)
	{
		base.SwitchToSubscene(subscene);
		backgroundWestern.Visible = false;
		backgroundRomantic.Visible = false;
		ackgroundHorror.Visible = false;
		backgroundNone.Visible = false;
		switch (subscene)
		{
			case VARIANT_ROMANTIC:
				backgroundRomantic.Visible = true;
				break;
			default:
				backgroundNone.Visible = true;
				break;
			case VARIANT_HORROR:
				ackgroundHorror.Visible = true;
				break;
			case VARIANT_WESTERN:
				backgroundWestern.Visible = true;
				break;
		}
	}
}
