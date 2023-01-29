using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class InteractableLayer : AbstractLayer
{ // _x1wxbalqqw8qtEqHC1UaGdv59Od
	public Vector2 ActivePoint;
	private bool Hovered;
	private bool Captured;

	public Texture2D Texture { get; private set; }
	public Texture2D ActiveTexture { get; private set; }
	public string Text { get; private set; }

	public float ActiveX
	{
		get
		{
			return ActivePoint.X;
		}
		set
		{
			ActivePoint.X = value;
		}
	}

	public float ActiveY
	{
		get
		{
			return ActivePoint.Y;
		}
		set
		{
			ActivePoint.Y = value;
		}
	}

	public InteractableLayer(AbstractScene scene, string name, Texture2D texture2D, Texture2D activeTexture2D, string text)
		: base(scene, name)
	{
		Texture = texture2D;
		base.Width = texture2D.Width;
		base.Height = texture2D.Height;
		ActiveTexture = activeTexture2D;
		Text = text;
	}

	public override void Update(GameTime gameTime)
	{
		if (Captured && TypingDialogue.Completable)
		{
			Captured = false;
		}
	}

	public override void Draw(SpriteBatch spriteBatch)
	{
		if (Color.A != 0)
		{
			Color color = (Hovered ? Color.Red : Color);
			if (Captured && ActiveTexture != null)
			{
				spriteBatch.Draw(ActiveTexture, ActivePoint, null, color, 0f, Vector2.Zero, Scale, SpriteEffects.None, 0f);
			}
			else
			{
				spriteBatch.Draw(Texture, Location, null, color, 0f, Vector2.Zero, Scale, SpriteEffects.None, 0f);
			}
		}
	}

	public override bool Click()
	{
		TypingDialogue.Play(Text, string.Empty, Color.White);
		Captured = true;
		Hovered = false;
		return true;
	}

	public override void Continue()
	{
		TypingDialogue.BeginCutscene();
		Captured = false;
	}

	public override void Hover()
	{
		if (!Captured)
		{
			Hovered = true;
		}
	}

	public override void Unhover()
	{
		Hovered = false;
	}
}
