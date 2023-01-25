using System;
using System.Runtime.CompilerServices;
using Amorous.Game.Scenes;
using Microsoft.Xna.Framework;
using Squid;

public class _SsogwGgurAXPoDRtNVTCVKq9yRE : _8lVOgkauaSHbAkAqHzI1K7mIyOI
{
	public Action _a6EfzLkl5vzR053eenrcOponhUA;

	public _SsogwGgurAXPoDRtNVTCVKq9yRE(IAmorous game)
		: base(Game)
	{
		_QVqIVxBeF2SAQh6HDFwwp2RFmXB("Assets/Scenes/MainMenu/Version", "Assets/Scenes/MainMenu/Version hover", "Assets/Gui/Fonts/Bold-14", "Data", Color.White, 1417, 1000, new Microsoft.Xna.Framework.Rectangle(1417, 1000, 146, 58), _OtbNWfcfKRIxEBenRG9bmom5ssK);
		_aiunwWjasFcF9afjl2FnUxWXB0M("Assets/Scenes/MainMenu/credits", "Assets/Scenes/MainMenu/Credits hover", 1583, 1000, new Microsoft.Xna.Framework.Rectangle(1583, 1000, 146, 58), _1UonNHUCNgrMS8Z0CyaGApPKtqM);
		_aiunwWjasFcF9afjl2FnUxWXB0M("Assets/Scenes/MainMenu/Patreon", null, 1749, 1000, Microsoft.Xna.Framework.Rectangle.Empty, null);
		_83EecuYIFalvL6Gd1s9MoTLHdgq("Assets/Gui/Fonts/Bold-14", string.Format("Version {0}", "1.0.4"), Alignment.MiddleRight, Color.White, 1885, 830);
	}

	private void _1UonNHUCNgrMS8Z0CyaGApPKtqM()
	{
		base.Game.StartScene<CreditsMenuScene>();
	}

	private void _OtbNWfcfKRIxEBenRG9bmom5ssK()
	{
		if (_a6EfzLkl5vzR053eenrcOponhUA != null)
		{
			_a6EfzLkl5vzR053eenrcOponhUA();
		}
	}

	private void _pfVo68LERbhujSvmznaAfmL4Jf(string string_0)
	{
		base.Game._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b = false;
		base.Game.Scene._PnkAlVnMv0SZvRBFexqzE5DF9tp.ShowConfirm("Failed to open the following URL:\r\n" + string_0 + "\r\n\r\nPlease use your favorite browser!", 500, "OK", delegate
		{
			base.Game._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b = true;
		});
	}
}
