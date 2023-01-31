using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class DeviationLayer : AbstractLayer
{ // _C9DhEciuJHkReX4htI9sP6cbqzF
	private float _deviation;
	private readonly Vector2 _beyond;

	public Texture2D Texture { get; private set; }
	public float Speed { get; private set; }

	public DeviationLayer(AbstractScene scene, string name, Texture2D texture2D, float speed, Vector2 beyond)
		: base(scene, name)
	{
		Texture = texture2D;
		Speed = speed;
		base.Width = texture2D.Width;
		base.Height = texture2D.Height;
		_deviation = 0f;
		_beyond = beyond;
	}

	public override void Update(GameTime gameTime)
	{
		_deviation += (float)gameTime.ElapsedGameTime.Milliseconds / 1000f * Speed;
		if (_deviation <= 360f)
		{
			if (_deviation < -360f)
			{
				_deviation += 360f;
			}
		}
		else
		{
			_deviation -= 360f;
		}
	}

	public override void Draw(SpriteBatch spriteBatch)
	{
		if (Color.A != 0)
		{
			spriteBatch.Draw(Texture, Location + _beyond, null, Color, _deviation, _beyond, Scale, SpriteEffects.None, 0f);
		}
	}
}
