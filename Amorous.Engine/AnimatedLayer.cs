using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class AnimatedLayer : AbstractLayer
{ // _kxm3yIqio0baXT5t5vOHBAEdviB
	private int _frame;
	private int _stopwatch;

	public List<Texture2D> Textures { get; private set; }
	public int Ticks { get; private set; }

	public AnimatedLayer(AbstractScene scene, string name, int delay, List<Texture2D> textures)
		: base(scene, name)
	{
		Textures = textures;
		base.Width = textures[0].Width;
		base.Height = textures[0].Height;
		Ticks = delay;
		_frame = 0;
		_stopwatch = Ticks;
	}

	public override void Update(GameTime gameTime)
	{
		_stopwatch -= gameTime.ElapsedGameTime.Milliseconds;
		if (_stopwatch < 0)
		{
			_stopwatch = Ticks;
			_frame++;
			if (_frame >= Textures.Count)
			{
				_frame = 0;
			}
		}
	}

	public override void Draw(SpriteBatch spriteBatch)
	{
		if (Color.A != 0)
		{
			spriteBatch.Draw(Textures[_frame], Location, null, Color, 0f, Vector2.Zero, Scale, SpriteEffects.None, 0f);
		}
	}
}
