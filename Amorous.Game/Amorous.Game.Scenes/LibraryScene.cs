namespace Amorous.Game.Scenes;

public class LibraryScene : AbstractScene
{
	public LibraryScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/Library/Background", 0, 0);
		FadingMediaPlayer._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/RyeGuyHead - Outdated", 0.4f);
	}
}
