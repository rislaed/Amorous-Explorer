using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class DeviationLayer : AbstractLayer
{ // _C9DhEciuJHkReX4htI9sP6cbqzF
	private float Deviation;

	private readonly Vector2 Center;
	public Texture2D Texture { get; private set; }
	public float Speed { get; private set; }

	public DeviationLayer(AbstractScene scene, string name, Texture2D texture2D, float speed, Vector2 deviation)
		: base(scene, name)
	{
		Texture = texture2D;
		Speed = speed;
		base.Width = texture2D.Width;
		base.Height = texture2D.Height;
		Deviation = 0f;
		Center = deviation;
	}

	public override void Update(GameTime gameTime)
	{
		Deviation += (float)gameTime.ElapsedGameTime.Milliseconds / 1000f * Speed;
		if (Deviation <= 360f)
		{
			if (Deviation < -360f)
			{
				Deviation += 360f;
			}
		}
		else
		{
			Deviation -= 360f;
		}
	}

	public override void Draw(SpriteBatch spriteBatch)
	{
		if (Color.A != 0)
		{
			spriteBatch.Draw(Texture, Location + Center, null, Color, Deviation, Center, Scale, SpriteEffects.None, 0f);
		}
	}
}
