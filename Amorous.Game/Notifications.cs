using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Squid;

public class Notifications
{ // _XJasjdoOf6PYbfaC5MsbXSjDWV3
	private class _RQQdLVHyZm4GNvRCeQfcIx1OlwJ
	{
		public Frame _kvuzph4c9LD4fDAaURHVjkfJKwk;
		public float Time;
	}

	private const float _c8P7clKqCyeAfypCea6vVId1tdN = 5f;
	private readonly Desktop _squid;
	private readonly Frame _g1jCwh8QFyZkbnduUiAjCzKbLWF;
	private readonly List<_RQQdLVHyZm4GNvRCeQfcIx1OlwJ> _IRRZMMioeCJC8zGoIaJiRaRSSiM;
	private bool _0WBDNE6IV1uJhHzUHzdiNj5c9bcA;

	public Notifications()
	{
		_squid = new Desktop
		{
			Skin = Gui.GenerateStandardSkin(),
			Size = new Squid.Point(1920, 1080)
		};
		_squid.SetSkin("Assets/GUI/Squid/DefaultSkin", "Assets/GUI/Squid/DefaultSkin - Blue");
		ControlStyle value = new ControlStyle
		{
			Font = "Assets/Gui/Fonts/Bold-16"
		};
		_squid.Skin["window"].Tint = ColorInt.ARGB(0.75f, 1f, 1f, 1f);
		_squid.Skin.Add("header", value);
		_g1jCwh8QFyZkbnduUiAjCzKbLWF = new Frame
		{
			Dock = DockStyle.Right,
			Size = new Squid.Point(600, 1080),
			Margin = new Margin(0, 0, 10, 0)
		};
		_squid.Controls.Add(_g1jCwh8QFyZkbnduUiAjCzKbLWF);
		_IRRZMMioeCJC8zGoIaJiRaRSSiM = new List<_RQQdLVHyZm4GNvRCeQfcIx1OlwJ>();
		_0WBDNE6IV1uJhHzUHzdiNj5c9bcA = false;
	}

	public void ShowMessage(string icon, string title, string message)
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
			Texture = icon
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
			Text = "New message: " + title + "!"
		};
		Label item3 = new Label
		{
			Dock = DockStyle.Fill,
			Text = message,
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
		_squid.Update();
		float num = (float)(gameTime.ElapsedGameTime.TotalMilliseconds / 1000.0);
		foreach (_RQQdLVHyZm4GNvRCeQfcIx1OlwJ item in _IRRZMMioeCJC8zGoIaJiRaRSSiM)
		{
			item.Time += num;
			if (item.Time >= 5f)
			{
				_g1jCwh8QFyZkbnduUiAjCzKbLWF.Controls.Remove(item._kvuzph4c9LD4fDAaURHVjkfJKwk);
				_0WBDNE6IV1uJhHzUHzdiNj5c9bcA = true;
			}
		}
		if (_0WBDNE6IV1uJhHzUHzdiNj5c9bcA)
		{
			_0WBDNE6IV1uJhHzUHzdiNj5c9bcA = false;
			_IRRZMMioeCJC8zGoIaJiRaRSSiM.RemoveAll((_RQQdLVHyZm4GNvRCeQfcIx1OlwJ _RQQdLVHyZm4GNvRCeQfcIx1OlwJ_0) => _RQQdLVHyZm4GNvRCeQfcIx1OlwJ_0.Time >= 5f);
		}
	}

	public void Draw(SpriteBatch spriteBatch)
	{
		try
		{
			_squid.Draw();
		}
		catch (Exception)
		{
			// ?
		}
	}
}
