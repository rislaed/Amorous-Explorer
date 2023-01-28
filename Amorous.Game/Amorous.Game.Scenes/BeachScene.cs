namespace Amorous.Game.Scenes;

public class BeachScene : AbstractScene
{
	public BeachScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/Beach/Beach Background", 0, 0);
		if (base.Game.Cutscene != null && base.Game.Cutscene.Data.Name == "DustinDate" && base.Game.Cutscene.State.Data.Stage == 60)
		{
			FadingMediaPlayer._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/Hopeku - In A Finger Blink", 0.4f);
		}
		else
		{
			FadingMediaPlayer._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/Warhector - Free Floating", 0.4f);
		}
	}
}
