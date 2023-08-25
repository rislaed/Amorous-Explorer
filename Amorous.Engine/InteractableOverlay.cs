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

	public SpriteInteractable AddSpriteInteractable(string sprite, string hoveredSprite, int x, int y, Microsoft.Xna.Framework.Rectangle bounds, Action click)
	{
		Texture2D texture = Game.Content.Load<Texture2D>(sprite);
		Texture2D hoveredTexture = null;
		if (!string.IsNullOrEmpty(hoveredSprite))
		{
			hoveredTexture = Game.Content.Load<Texture2D>(hoveredSprite);
		}
		return AddSpriteInteractable(texture, hoveredTexture, x, y, bounds, click);
	}

	public SpriteInteractable AddSpriteInteractable(Texture2D sprite, Texture2D hoveredSprite, int x, int y, Microsoft.Xna.Framework.Rectangle bounds, Action click)
	{
		SpriteInteractable interactable = new SpriteInteractable(sprite, hoveredSprite, click)
		{
			X = x,
			Y = y,
			Bounds = bounds
		};
		Interactables.Add(interactable);
		return interactable;
	}

	public ButtonInteractable AddButtonInteractable(string sprite, string hoveredSprite, string font, string text, Color color, int x, int y, Microsoft.Xna.Framework.Rectangle bounds, Action click)
	{
		Texture2D texture = Game.Content.Load<Texture2D>(sprite);
		Texture2D hoveredTexture = null;
		if (!string.IsNullOrEmpty(hoveredSprite))
		{
			hoveredTexture = Game.Content.Load<Texture2D>(hoveredSprite);
		}
		SpriteFont spriteFont = Game.Content.Load<SpriteFont>(font);
		return AddButtonInteractable(texture, hoveredTexture, spriteFont, text, color, x, y, bounds, click);
	}

	public ButtonInteractable AddButtonInteractable(Texture2D sprite, Texture2D hoveredSprite, SpriteFont font, string text, Color color, int x, int y, Microsoft.Xna.Framework.Rectangle bounds, Action click)
	{
		ButtonInteractable interactable = new ButtonInteractable(sprite, hoveredSprite, font, text, color, click)
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
		SpriteFont spriteFont = Game.Content.Load<SpriteFont>(font);
		TextInteractable interactable = new TextInteractable(spriteFont, text, color)
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
			if (interactable.IsVisible)
			{
				bool innersection = interactable.Bounds.Contains(point);
				if (!interactable.IsHovered && innersection)
				{
					interactable.Enter();
				}
				else if (interactable.IsHovered && !innersection)
				{
					interactable.Leave();
				}
			}
		}
		if (!Game.Controller.IsPressed(ControllerButtonType.LeftButton))
		{
			return;
		}
		foreach (AbstractInteractable interactable in Interactables)
		{
			if (interactable.IsVisible && interactable.Bounds.Contains(point))
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
			if (interactable.IsVisible)
			{
				interactable.Draw(spriteBatch);
			}
		}
		spriteBatch.End();
	}
}
