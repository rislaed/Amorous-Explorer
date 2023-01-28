using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Squid;

public class InteractableOverlay
{
	public IAmorous Game { get; private set; }
	public List<_1dTaaW9MQWoHm2Pqblg0u9bPhpe> _6qfro4buoEQEXNMVAj08xANyjWf { get; private set; }
	public bool Touchable { get; set; }

	public InteractableOverlay(IAmorous amorous)
	{
		Game = amorous;
		_6qfro4buoEQEXNMVAj08xANyjWf = new List<_1dTaaW9MQWoHm2Pqblg0u9bPhpe>();
		Touchable = true;
	}

	public _d4ad1i8rcZMvfN9iaxggA1KtVgx _aiunwWjasFcF9afjl2FnUxWXB0M(string string_0, string string_1, int int_0, int int_1, Microsoft.Xna.Framework.Rectangle rectangle_0, Action action_0)
	{
		Texture2D texture2D_ = Game.Content.Load<Texture2D>(string_0);
		Texture2D texture2D_2 = null;
		if (!string.IsNullOrEmpty(string_1))
		{
			texture2D_2 = Game.Content.Load<Texture2D>(string_1);
		}
		return _aiunwWjasFcF9afjl2FnUxWXB0M(texture2D_, texture2D_2, int_0, int_1, rectangle_0, action_0);
	}

	public _d4ad1i8rcZMvfN9iaxggA1KtVgx _aiunwWjasFcF9afjl2FnUxWXB0M(Texture2D texture2D_0, Texture2D texture2D_1, int int_0, int int_1, Microsoft.Xna.Framework.Rectangle rectangle_0, Action action_0)
	{
		_d4ad1i8rcZMvfN9iaxggA1KtVgx d4ad1i8rcZMvfN9iaxggA1KtVgx = new _d4ad1i8rcZMvfN9iaxggA1KtVgx(texture2D_0, texture2D_1, action_0)
		{
			X = int_0,
			Y = int_1,
			_2psWLw4AI8EIjQzaXnhGg8M1FnaA = rectangle_0
		};
		_6qfro4buoEQEXNMVAj08xANyjWf.Add(d4ad1i8rcZMvfN9iaxggA1KtVgx);
		return d4ad1i8rcZMvfN9iaxggA1KtVgx;
	}

	public _iHJrndJdM1jj9TEnuU3BvgdDuvf _QVqIVxBeF2SAQh6HDFwwp2RFmXB(string string_0, string string_1, string string_2, string string_3, Color color_0, int int_0, int int_1, Microsoft.Xna.Framework.Rectangle rectangle_0, Action action_0)
	{
		Texture2D texture2D_ = Game.Content.Load<Texture2D>(string_0);
		Texture2D texture2D_2 = null;
		if (!string.IsNullOrEmpty(string_1))
		{
			texture2D_2 = Game.Content.Load<Texture2D>(string_1);
		}
		SpriteFont spriteFont_ = Game.Content.Load<SpriteFont>(string_2);
		return _QVqIVxBeF2SAQh6HDFwwp2RFmXB(texture2D_, texture2D_2, spriteFont_, string_3, color_0, int_0, int_1, rectangle_0, action_0);
	}

	public _iHJrndJdM1jj9TEnuU3BvgdDuvf _QVqIVxBeF2SAQh6HDFwwp2RFmXB(Texture2D texture2D_0, Texture2D texture2D_1, SpriteFont spriteFont_0, string string_0, Color color_0, int int_0, int int_1, Microsoft.Xna.Framework.Rectangle rectangle_0, Action action_0)
	{
		_iHJrndJdM1jj9TEnuU3BvgdDuvf iHJrndJdM1jj9TEnuU3BvgdDuvf = new _iHJrndJdM1jj9TEnuU3BvgdDuvf(texture2D_0, texture2D_1, spriteFont_0, string_0, color_0, action_0)
		{
			X = int_0,
			Y = int_1,
			_2psWLw4AI8EIjQzaXnhGg8M1FnaA = rectangle_0
		};
		_6qfro4buoEQEXNMVAj08xANyjWf.Add(iHJrndJdM1jj9TEnuU3BvgdDuvf);
		return iHJrndJdM1jj9TEnuU3BvgdDuvf;
	}

	public _abqs0UynzjUEhuA3VpR4t6Uuk0E _83EecuYIFalvL6Gd1s9MoTLHdgq(string string_0, string string_1, Alignment alignment_0, Color color_0, int int_0, int int_1)
	{
		SpriteFont spriteFont_ = Game.Content.Load<SpriteFont>(string_0);
		_abqs0UynzjUEhuA3VpR4t6Uuk0E abqs0UynzjUEhuA3VpR4t6Uuk0E = new _abqs0UynzjUEhuA3VpR4t6Uuk0E(spriteFont_, string_1, color_0)
		{
			X = int_0,
			Y = int_1,
			Gravity = alignment_0
		};
		_6qfro4buoEQEXNMVAj08xANyjWf.Add(abqs0UynzjUEhuA3VpR4t6Uuk0E);
		return abqs0UynzjUEhuA3VpR4t6Uuk0E;
	}

	public void Update(GameTime gameTime)
	{
		if (!Touchable)
		{
			return;
		}
		Microsoft.Xna.Framework.Point value = Game.Mouse.Rescale(Game.Controller.Cursor);
		foreach (_1dTaaW9MQWoHm2Pqblg0u9bPhpe item in _6qfro4buoEQEXNMVAj08xANyjWf)
		{
			if (item.Visible)
			{
				bool flag = item._2psWLw4AI8EIjQzaXnhGg8M1FnaA.Contains(value);
				if (!item._NUP8Fs8I7oMuI6vfg25DFKFlQqE && flag)
				{
					item._4xz3iE0ff4Zjl6ybnWxczeMPKyB();
				}
				else if (item._NUP8Fs8I7oMuI6vfg25DFKFlQqE && !flag)
				{
					item._TVKS7kokuGdoU8kMxQQPKABgo4c();
				}
			}
		}
		if (!Game.Controller.JustPressed(ControllerButtonType.LeftButton))
		{
			return;
		}
		foreach (_1dTaaW9MQWoHm2Pqblg0u9bPhpe item2 in _6qfro4buoEQEXNMVAj08xANyjWf)
		{
			if (item2.Visible && item2._2psWLw4AI8EIjQzaXnhGg8M1FnaA.Contains(value))
			{
				item2._eJedLbGgSejIX7Xyx6RoIYD1soJA();
			}
		}
	}

	public void Draw(SpriteBatch spriteBatch)
	{
		spriteBatch.Begin();
		foreach (_1dTaaW9MQWoHm2Pqblg0u9bPhpe item in _6qfro4buoEQEXNMVAj08xANyjWf)
		{
			if (item.Visible)
			{
				item.Draw(spriteBatch);
			}
		}
		spriteBatch.End();
	}
}
