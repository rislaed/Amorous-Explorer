using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class AnimatedLayer : AbstractLayer
{ // _kxm3yIqio0baXT5t5vOHBAEdviB
	private int texture;
	private int ticksBeforeUpdating;

	public List<Texture2D> Textures { get; private set; }
	public int TicksPerFrame { get; private set; }

	public AnimatedLayer(AbstractScene scene, string name, int delay, List<Texture2D> textures)
		: base(scene, name)
	{
		Textures = textures;
		base.Width = textures[0].Width;
		base.Height = textures[0].Height;
		TicksPerFrame = delay;
		texture = 0;
		ticksBeforeUpdating = TicksPerFrame;
	}

	public override void Update(GameTime gameTime)
	{
		ticksBeforeUpdating -= gameTime.ElapsedGameTime.Milliseconds;
		if (ticksBeforeUpdating < 0)
		{
			ticksBeforeUpdating = TicksPerFrame;
			texture++;
			if (texture >= Textures.Count)
			{
				texture = 0;
			}
		}
	}

	public override void Draw(SpriteBatch spriteBatch)
	{
		if (Color.A != 0)
		{
			spriteBatch.Draw(Textures[texture], Location, null, Color, 0f, Vector2.Zero, Scale, SpriteEffects.None, 0f);
		}
	}
}
