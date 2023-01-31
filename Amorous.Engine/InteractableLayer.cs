using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class InteractableLayer : AbstractLayer
{ // _x1wxbalqqw8qtEqHC1UaGdv59Od
	public Vector2 ActivePoint;

	private bool _hovered, _captured;

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

	public InteractableLayer(AbstractScene scene, string name, Texture2D texture, Texture2D activeTexture, string text)
		: base(scene, name)
	{
		Texture = texture;
		base.Width = texture.Width;
		base.Height = texture.Height;
		ActiveTexture = activeTexture;
		Text = text;
	}

	public override void Update(GameTime gameTime)
	{
		if (_captured && TypingDialogue.Completable)
		{
			_captured = false;
		}
	}

	public override void Draw(SpriteBatch spriteBatch)
	{
		if (Color.A != 0)
		{
			Color color = (_hovered ? Color.Red : Color);
			if (_captured && ActiveTexture != null)
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
		TypingDialogue.Type(Text, string.Empty, Color.White);
		_captured = true;
		_hovered = false;
		return true;
	}

	public override void Continue()
	{
		TypingDialogue.Complete();
		_captured = false;
	}

	public override void Hover()
	{
		if (!_captured)
		{
			_hovered = true;
		}
	}

	public override void Unhover()
	{
		_hovered = false;
	}
}
