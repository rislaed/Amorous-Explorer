namespace Amorous.Game.Scenes;

public class ArtGalleryScene : AbstractScene
{
	public ArtGalleryScene(IAmorous game)
		: base(game)
	{
		if (Censorship.Censored)
		{
			AddTexturedLayer("Background", "Assets/Scenes/ArtGallery/Background-SFW", 0, 0);
		}
		else
		{
			AddTexturedLayer("Background", "Assets/Scenes/ArtGallery/Background", 0, 0);
		}
		FadingMediaPlayer._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/RyeGuyHead - Outdated", 0.4f);
	}
}
