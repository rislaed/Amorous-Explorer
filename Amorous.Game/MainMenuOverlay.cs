using System;
using Microsoft.Xna.Framework;

public class MainMenuOverlay : InteractableOverlay
{ // _BlUQCbX8YXbBc38I7iPEHyF1rUQ
	public Action NewGame { get; set; }
	public Action Continue { get; set; }
	public Action Quit { get; set; }

	public MainMenuOverlay(IAmorous game) : base(game)
	{
		AddSpriteInteractable("Assets/Scenes/MainMenu/NEW GAME button dim", "Assets/Scenes/MainMenu/NEW GAME button illuminated", -240, -135, new Rectangle(1020, 525, 210, 100), ClickNewGame);
		AddSpriteInteractable("Assets/Scenes/MainMenu/CONTINUE button dim", "Assets/Scenes/MainMenu/CONTINUE button illuminated", -240, -135, new Rectangle(1240, 535, 210, 100), ClickContinue);
		AddSpriteInteractable("Assets/Scenes/MainMenu/QUIT button dim", "Assets/Scenes/MainMenu/QUIT button illuminated", -240, -135, new Rectangle(1460, 545, 210, 100), ClickQuit);
	}

	private void ClickNewGame()
	{
		if (NewGame != null)
		{
			NewGame();
		}
	}

	private void ClickContinue()
	{
		if (Continue != null)
		{
			Continue();
		}
	}

	private void ClickQuit()
	{
		if (Quit != null)
		{
			Quit();
		}
	}
}
