using Microsoft.Xna.Framework;

namespace Amorous.Game.Scenes;

public class ClubPoolWaterScene : AbstractScene
{
	public ClubPoolWaterScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/ClubPoolWater/Background", 0, 0);
		_jOXcj4HBkU5j6LOJprpiXLCcLR0 gparam_ = new _jOXcj4HBkU5j6LOJprpiXLCcLR0(this, 700f, new Rectangle(0, -190, 1920, 1080), bool_0: true)
		{
			OffsetX = 600f,
			OffsetY = 750f,
			Scale = 2f
		};
		_jOXcj4HBkU5j6LOJprpiXLCcLR0 gparam_2 = new _jOXcj4HBkU5j6LOJprpiXLCcLR0(this, 700f, new Rectangle(0, 0, 1920, 1080), bool_0: true)
		{
			OffsetX = 1200f,
			OffsetY = 750f,
			Scale = 2f
		};
		AddLayer(gparam_, 0);
		AddLayer(gparam_2, 2);
		FadingMediaPlayer._QrgbXEg7MMeD9Ybz12fFVsbmAd9(_KZ7hNP1K5E99Xfup1lTZ9UDrxPE._oCy13KHJxLHriH7TwMiQ1qKJ8Uc, 0.4f, repeat: true, oneOf: true);
	}
}
