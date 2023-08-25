using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class InteractableLayer : AbstractLayer
{ // _x1wxbalqqw8qtEqHC1UaGdv59Od
	public Vector2 TouchLocation;

	private bool hovered, captured;

	public Texture2D Texture { get; private set; }
	public Texture2D HoveredTexture { get; private set; }
	public string Text { get; private set; }

	public float TouchX
	{
		get
		{
			return TouchLocation.X;
		}
		set
		{
			TouchLocation.X = value;
		}
	}

	public float TouchY
	{
		get
		{
			return TouchLocation.Y;
		}
		set
		{
			TouchLocation.Y = value;
		}
	}

	public InteractableLayer(AbstractScene scene, string name, Texture2D texture, Texture2D hoveredTexture, string text)
		: base(scene, name)
	{
		Texture = texture;
		base.Width = texture.Width;
		base.Height = texture.Height;
		HoveredTexture = hoveredTexture;
		Text = text;
	}

	public override void Update(GameTime gameTime)
	{
		if (captured && TypingDialogue.IsCompleted)
		{
			captured = false;
		}
	}

	public override void Draw(SpriteBatch spriteBatch)
	{
		if (Color.A != 0)
		{
			Color color = (hovered ? Color.Red : Color);
			if (captured && HoveredTexture != null)
			{
				spriteBatch.Draw(HoveredTexture, TouchLocation, null, color, 0f, Vector2.Zero, Scale, SpriteEffects.None, 0f);
			}
			else
			{
				spriteBatch.Draw(Texture, Location, null, color, 0f, Vector2.Zero, Scale, SpriteEffects.None, 0f);
			}
		}
	}

	public override bool Click()
	{
		TypingDialogue.Type(Text, string.Empty, Color.White);
		captured = true;
		hovered = false;
		return true;
	}

	public override void Continue()
	{
		TypingDialogue.Complete();
		captured = false;
	}

	public override void Enter()
	{
		if (!captured)
		{
			hovered = true;
		}
	}

	public override void Leave()
	{
		hovered = false;
	}
}
