using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Squid;

public class Notifications
{ // _XJasjdoOf6PYbfaC5MsbXSjDWV3
	private class Message
	{
		public Frame Control;
		public float Date;
	}

	private const float BetweenDelay = 5f;
	private readonly Desktop _squid;
	private readonly Frame _overlay;
	private readonly List<Message> _messages;
	private bool _completed;

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
		_overlay = new Frame
		{
			Dock = DockStyle.Right,
			Size = new Squid.Point(600, 1080),
			Margin = new Margin(0, 0, 10, 0)
		};
		_squid.Controls.Add(_overlay);
		_messages = new List<Message>();
		_completed = false;
	}

	public void ShowMessage(string icon, string title, string message)
	{
		Frame contentFrame = new Frame
		{
			Dock = DockStyle.Bottom,
			Style = "window",
			Padding = new Margin(10),
			Margin = new Margin(0, 0, 0, 10),
			Size = new Squid.Point(0, 120)
		};
		ImageControl iconImage = new ImageControl
		{
			Dock = DockStyle.Left,
			Margin = new Margin(0, 0, 10, 0),
			Size = new Squid.Point(100, 100),
			Texture = icon
		};
		Frame textFrame = new Frame
		{
			Dock = DockStyle.Fill,
			Scissor = true
		};
		Label headerText = new Label
		{
			Dock = DockStyle.Top,
			Style = "header",
			Text = "New message: " + title + "!"
		};
		Label messageText = new Label
		{
			Dock = DockStyle.Fill,
			Text = message,
			TextWrap = true
		};
		contentFrame.Controls.Add(iconImage);
		contentFrame.Controls.Add(textFrame);
		textFrame.Controls.Add(headerText);
		textFrame.Controls.Add(messageText);
		_overlay.Controls.Add(contentFrame);
		_messages.Add(new Message
		{
			Control = contentFrame
		});
	}

	public void Update(GameTime gameTime)
	{
		_squid.Update();
		float ticks = (float)(gameTime.ElapsedGameTime.TotalMilliseconds / 1000.0);
		foreach (Message message in _messages)
		{
			message.Date += ticks;
			if (message.Date >= BetweenDelay)
			{
				_overlay.Controls.Remove(message.Control);
				_completed = true;
			}
		}
		if (_completed)
		{
			_completed = false;
			_messages.RemoveAll((Message message) => message.Date >= BetweenDelay);
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
