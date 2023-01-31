using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Squid;

public class InteractableOverlay
{ // _8lVOgkauaSHbAkAqHzI1K7mIyOI
	public IAmorous Game { get; private set; }
	public List<AbstractInteractable> Interactables { get; private set; }
	public bool Touchable { get; set; }

	public InteractableOverlay(IAmorous game)
	{
		Game = game;
		Interactables = new List<AbstractInteractable>();
		Touchable = true;
	}

	public SpriteInteractable AddSpriteInteractable(string foreground, string background, int x, int y, Microsoft.Xna.Framework.Rectangle bounds, Action click)
	{
		Texture2D _foreground = Game.Content.Load<Texture2D>(foreground);
		Texture2D _background = null;
		if (!string.IsNullOrEmpty(background))
		{
			_background = Game.Content.Load<Texture2D>(background);
		}
		return AddSpriteInteractable(_foreground, _background, x, y, bounds, click);
	}

	public SpriteInteractable AddSpriteInteractable(Texture2D foreground, Texture2D background, int x, int y, Microsoft.Xna.Framework.Rectangle bounds, Action click)
	{
		SpriteInteractable interactable = new SpriteInteractable(foreground, background, click)
		{
			X = x,
			Y = y,
			Bounds = bounds
		};
		Interactables.Add(interactable);
		return interactable;
	}

	public ButtonInteractable AddButtonInteractable(string foreground, string background, string font, string text, Color color, int x, int y, Microsoft.Xna.Framework.Rectangle bounds, Action click)
	{
		Texture2D _foreground = Game.Content.Load<Texture2D>(background);
		Texture2D _background = null;
		if (!string.IsNullOrEmpty(background))
		{
			_background = Game.Content.Load<Texture2D>(background);
		}
		SpriteFont _font = Game.Content.Load<SpriteFont>(font);
		return AddButtonInteractable(_foreground, _background, _font, text, color, x, y, bounds, click);
	}

	public ButtonInteractable AddButtonInteractable(Texture2D foreground, Texture2D background, SpriteFont font, string text, Color color, int x, int y, Microsoft.Xna.Framework.Rectangle bounds, Action click)
	{
		ButtonInteractable interactable = new ButtonInteractable(foreground, background, font, text, color, click)
		{
			X = x,
			Y = y,
			Bounds = bounds
		};
		Interactables.Add(interactable);
		return interactable;
	}

	public TextInteractable AddTextInteractable(string font, string text, Alignment gravity, Color color, int x, int y)
	{
		SpriteFont _font = Game.Content.Load<SpriteFont>(font);
		TextInteractable interactable = new TextInteractable(_font, text, color)
		{
			X = x,
			Y = y,
			Gravity = gravity
		};
		Interactables.Add(interactable);
		return interactable;
	}

	public void Update(GameTime gameTime)
	{
		if (!Touchable)
		{
			return;
		}
		Microsoft.Xna.Framework.Point point = Game.Canvas.GlobalToContent(Game.Controller.Cursor);
		foreach (AbstractInteractable interactable in Interactables)
		{
			if (interactable.Visible)
			{
				bool innersection = interactable.Bounds.Contains(point);
				if (!interactable.Hovered && innersection)
				{
					interactable.Hover();
				}
				else if (interactable.Hovered && !innersection)
				{
					interactable.Unhover();
				}
			}
		}
		if (!Game.Controller.IsPressed(ControllerButtonType.LeftButton))
		{
			return;
		}
		foreach (AbstractInteractable interactable in Interactables)
		{
			if (interactable.Visible && interactable.Bounds.Contains(point))
			{
				interactable.Click();
			}
		}
	}

	public void Draw(SpriteBatch spriteBatch)
	{
		spriteBatch.Begin();
		foreach (AbstractInteractable interactable in Interactables)
		{
			if (interactable.Visible)
			{
				interactable.Draw(spriteBatch);
			}
		}
		spriteBatch.End();
	}
}
