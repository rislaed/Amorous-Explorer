using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Squid;

public class _XJasjdoOf6PYbfaC5MsbXSjDWV3
{
	private class _RQQdLVHyZm4GNvRCeQfcIx1OlwJ
	{
		public Frame _kvuzph4c9LD4fDAaURHVjkfJKwk;
		public float _AmIUCcrmrrQiiirja7DoiZSjXuv;
	}

	private const float _c8P7clKqCyeAfypCea6vVId1tdN = 5f;
	private readonly Desktop _9GQBAH2pi8Sm6ph1s6InjyQGe6R;
	private readonly Frame _g1jCwh8QFyZkbnduUiAjCzKbLWF;
	private readonly List<_RQQdLVHyZm4GNvRCeQfcIx1OlwJ> _IRRZMMioeCJC8zGoIaJiRaRSSiM;
	private bool _0WBDNE6IV1uJhHzUHzdiNj5c9bcA;

	public _XJasjdoOf6PYbfaC5MsbXSjDWV3()
	{
		_9GQBAH2pi8Sm6ph1s6InjyQGe6R = new Desktop
		{
			Skin = Gui.GenerateStandardSkin(),
			Size = new Squid.Point(1920, 1080)
		};
		_9GQBAH2pi8Sm6ph1s6InjyQGe6R.SetSkin("Assets/GUI/Squid/DefaultSkin", "Assets/GUI/Squid/DefaultSkin - Blue");
		ControlStyle value = new ControlStyle
		{
			Font = "Assets/Gui/Fonts/Bold-16"
		};
		_9GQBAH2pi8Sm6ph1s6InjyQGe6R.Skin["window"].Tint = ColorInt.ARGB(0.75f, 1f, 1f, 1f);
		_9GQBAH2pi8Sm6ph1s6InjyQGe6R.Skin.Add("header", value);
		_g1jCwh8QFyZkbnduUiAjCzKbLWF = new Frame
		{
			Dock = DockStyle.Right,
			Size = new Squid.Point(600, 1080),
			Margin = new Margin(0, 0, 10, 0)
		};
		_9GQBAH2pi8Sm6ph1s6InjyQGe6R.Controls.Add(_g1jCwh8QFyZkbnduUiAjCzKbLWF);
		_IRRZMMioeCJC8zGoIaJiRaRSSiM = new List<_RQQdLVHyZm4GNvRCeQfcIx1OlwJ>();
		_0WBDNE6IV1uJhHzUHzdiNj5c9bcA = false;
	}

	public void _EXfoFnp1OKxeZbd4GcVZMCO2urH(string string_0, string string_1, string string_2)
	{
		Frame frame = new Frame
		{
			Dock = DockStyle.Bottom,
			Style = "window",
			Padding = new Margin(10),
			Margin = new Margin(0, 0, 0, 10),
			Size = new Squid.Point(0, 120)
		};
		ImageControl item = new ImageControl
		{
			Dock = DockStyle.Left,
			Margin = new Margin(0, 0, 10, 0),
			Size = new Squid.Point(100, 100),
			Texture = string_0
		};
		Frame frame2 = new Frame
		{
			Dock = DockStyle.Fill,
			Scissor = true
		};
		Label item2 = new Label
		{
			Dock = DockStyle.Top,
			Style = "header",
			Text = "New message: " + string_1 + "!"
		};
		Label item3 = new Label
		{
			Dock = DockStyle.Fill,
			Text = string_2,
			TextWrap = true
		};
		frame.Controls.Add(item);
		frame.Controls.Add(frame2);
		frame2.Controls.Add(item2);
		frame2.Controls.Add(item3);
		_g1jCwh8QFyZkbnduUiAjCzKbLWF.Controls.Add(frame);
		_IRRZMMioeCJC8zGoIaJiRaRSSiM.Add(new _RQQdLVHyZm4GNvRCeQfcIx1OlwJ
		{
			_kvuzph4c9LD4fDAaURHVjkfJKwk = frame
		});
	}

	public void Update(GameTime gameTime)
	{
		_9GQBAH2pi8Sm6ph1s6InjyQGe6R.Update();
		float num = (float)(gameTime.ElapsedGameTime.TotalMilliseconds / 1000.0);
		foreach (_RQQdLVHyZm4GNvRCeQfcIx1OlwJ item in _IRRZMMioeCJC8zGoIaJiRaRSSiM)
		{
			item._AmIUCcrmrrQiiirja7DoiZSjXuv += num;
			if (item._AmIUCcrmrrQiiirja7DoiZSjXuv >= 5f)
			{
				_g1jCwh8QFyZkbnduUiAjCzKbLWF.Controls.Remove(item._kvuzph4c9LD4fDAaURHVjkfJKwk);
				_0WBDNE6IV1uJhHzUHzdiNj5c9bcA = true;
			}
		}
		if (_0WBDNE6IV1uJhHzUHzdiNj5c9bcA)
		{
			_0WBDNE6IV1uJhHzUHzdiNj5c9bcA = false;
			_IRRZMMioeCJC8zGoIaJiRaRSSiM.RemoveAll((_RQQdLVHyZm4GNvRCeQfcIx1OlwJ _RQQdLVHyZm4GNvRCeQfcIx1OlwJ_0) => _RQQdLVHyZm4GNvRCeQfcIx1OlwJ_0._AmIUCcrmrrQiiirja7DoiZSjXuv >= 5f);
		}
	}

	public void Draw(SpriteBatch spriteBatch)
	{
		try
		{
			_9GQBAH2pi8Sm6ph1s6InjyQGe6R.Draw();
		}
		catch (Exception)
		{
		}
	}
}
