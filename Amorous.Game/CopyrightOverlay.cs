using System;
using Amorous.Game.Scenes;
using Microsoft.Xna.Framework;
using Squid;

public class CopyrightOverlay : InteractableOverlay
{ // _SsogwGgurAXPoDRtNVTCVKq9yRE
	public Action ShowOptions;

	public CopyrightOverlay(IAmorous game)
		: base(game)
	{
		AddButtonInteractable("Assets/Scenes/MainMenu/Version", "Assets/Scenes/MainMenu/Version hover", "Assets/Gui/Fonts/Bold-14", "Options", Color.White, 1417, 1000, new Microsoft.Xna.Framework.Rectangle(1417, 1000, 146, 58), ConfigureOptions);
		AddSpriteInteractable("Assets/Scenes/MainMenu/credits", "Assets/Scenes/MainMenu/Credits hover", 1583, 1000, new Microsoft.Xna.Framework.Rectangle(1583, 1000, 146, 58), ShowCredits);
		AddSpriteInteractable("Assets/Scenes/MainMenu/Patreon", null, 1749, 1000, Microsoft.Xna.Framework.Rectangle.Empty, null); // ?
		AddTextInteractable("Assets/Gui/Fonts/Bold-14", string.Format("Version {0}", AmorousData.Version), Alignment.MiddleRight, Color.White, 1885, 830);
	}

	private void ShowCredits()
	{
		base.Game.StartScene<CreditsMenuScene>();
	}

	private void ConfigureOptions()
	{
		if (ShowOptions != null)
		{
			ShowOptions();
		}
	}

	private void ShowOpenURLFail(string message)
	{
		base.Game.Overlay.Touchable = false;
		base.Game.Scene.Squid.ShowConfirm("Failed to open the following URL:\r\n" + message + "\r\n\r\nPlease use your favorite browser!", AmorousData.ShortDialogueOffset, "OK", delegate
		{
			base.Game.Overlay.Touchable = true;
		});
	}
}
