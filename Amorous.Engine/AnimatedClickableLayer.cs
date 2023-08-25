using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class AnimatedClickableLayer : AbstractLayer
{ // _rmc1e7Ng50C4uLmgllAoRtxaZiB
	private int texture;
	private int ticksBeforeUpdating;
	private bool hovered;
	private readonly Action click;

	public List<Texture2D> Textures { get; private set; }
	public int TicksPerFrame { get; private set; }

	public AnimatedClickableLayer(AbstractScene scene, string name, Action action, int delay, List<Texture2D> textures)
		: base(scene, name)
	{
		Textures = textures;
		base.Width = textures[0].Width;
		base.Height = textures[0].Height;
		TicksPerFrame = delay;
		click = action;
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
			spriteBatch.Draw(Textures[texture], Location, null, hovered ? Color.Red : Color, 0f, Vector2.Zero, Scale, SpriteEffects.None, 0f);
		}
	}

	public override bool Click()
	{
		click();
		return true;
	}

	public override void Enter()
	{
		hovered = true;
	}

	public override void Leave()
	{
		hovered = false;
	}
}
