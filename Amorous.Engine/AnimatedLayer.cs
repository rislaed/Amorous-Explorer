using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class AnimatedLayer : AbstractLayer
{
	private int Value;
	private int Stopwatch;

	public List<Texture2D> Textures { get; private set; }
	public int Ticks { get; private set; }

	public AnimatedLayer(AbstractScene scene, string name, int delay, List<Texture2D> textures)
		: base(scene, name)
	{
		Textures = textures;
		base.Width = textures[0].Width;
		base.Height = textures[0].Height;
		Ticks = delay;
		Value = 0;
		Stopwatch = Ticks;
	}

	public override void Update(GameTime gameTime)
	{
		Stopwatch -= gameTime.ElapsedGameTime.Milliseconds;
		if (Stopwatch < 0)
		{
			Stopwatch = Ticks;
			Value++;
			if (Value >= Textures.Count)
			{
				Value = 0;
			}
		}
	}

	public override void Draw(SpriteBatch spriteBatch)
	{
		if (Color.A != 0)
		{
			spriteBatch.Draw(Textures[Value], Location, null, Color, 0f, Vector2.Zero, Scale, SpriteEffects.None, 0f);
		}
	}
}
