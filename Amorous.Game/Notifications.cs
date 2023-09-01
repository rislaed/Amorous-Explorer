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

	private readonly Desktop desktop;
	private readonly Frame container;
	private readonly List<Message> messages;
	private bool completed;

	public Notifications()
	{
		desktop = new Desktop
		{
			Skin = Gui.GenerateStandardSkin(),
			Size = new Squid.Point(1920, 1080)
		};
		desktop.SetSkin("Assets/GUI/Squid/DefaultSkin", "Assets/GUI/Squid/DefaultSkin - Blue");
		ControlStyle value = new ControlStyle
		{
			Font = "Assets/GUI/Fonts/Bold-16"
		};
		desktop.Skin["window"].Tint = ColorInt.ARGB(0.75f, 1f, 1f, 1f);
		desktop.Skin.Add("header", value);
		container = new Frame
		{
			Dock = DockStyle.Right,
			Size = new Squid.Point(600, 1080),
			Margin = new Margin(0, 0, 10, 0)
		};
		desktop.Controls.Add(container);
		messages = new List<Message>();
		completed = false;
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
		container.Controls.Add(contentFrame);
		messages.Add(new Message
		{
			Control = contentFrame
		});
	}

	public void Update(GameTime gameTime)
	{
		desktop.Update();
		float ticks = (float)(gameTime.ElapsedGameTime.TotalMilliseconds / 1000.0);
		foreach (Message message in messages)
		{
			message.Date += ticks;
			if (message.Date >= BetweenDelay)
			{
				container.Controls.Remove(message.Control);
				completed = true;
			}
		}
		if (completed)
		{
			completed = false;
			messages.RemoveAll((Message message) => message.Date >= BetweenDelay);
		}
	}

	public void Draw(SpriteBatch spriteBatch)
	{
		try
		{
			desktop.Draw();
		}
		catch (Exception)
		{
		}
	}
}
