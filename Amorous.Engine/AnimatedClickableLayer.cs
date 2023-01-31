using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class AnimatedClickableLayer : AbstractLayer
{ // _rmc1e7Ng50C4uLmgllAoRtxaZiB
	private int _index;
	private int _ticks;
	private bool _hovered;
	private readonly Action _click;

	public List<Texture2D> Textures { get; private set; }
	public int TimePerFrame { get; private set; }

	public AnimatedClickableLayer(AbstractScene scene, string name, Action click, int delay, List<Texture2D> textures)
		: base(scene, name)
	{
		Textures = textures;
		base.Width = textures[0].Width;
		base.Height = textures[0].Height;
		TimePerFrame = delay;
		_click = click;
		_index = 0;
		_ticks = TimePerFrame;
	}

	public override void Update(GameTime gameTime)
	{
		_ticks -= gameTime.ElapsedGameTime.Milliseconds;
		if (_ticks < 0)
		{
			_ticks = TimePerFrame;
			_index++;
			if (_index >= Textures.Count)
			{
				_index = 0;
			}
		}
	}

	public override void Draw(SpriteBatch spriteBatch)
	{
		if (Color.A != 0)
		{
			spriteBatch.Draw(Textures[_index], Location, null, _hovered ? Color.Red : Color, 0f, Vector2.Zero, Scale, SpriteEffects.None, 0f);
		}
	}

	public override bool Click()
	{
		_click();
		return true;
	}

	public override void Hover()
	{
		_hovered = true;
	}

	public override void Unhover()
	{
		_hovered = false;
	}
}
