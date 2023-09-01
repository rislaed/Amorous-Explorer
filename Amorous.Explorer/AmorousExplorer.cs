using System;
using System.Collections.Generic;
using Amorous.Explorer.Content;
using Amorous.Explorer.GUI;
using Amorous.Explorer.GUI.Prototype;
using Amorous.Explorer.Specialized;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Squid;

namespace Amorous.Explorer;

public interface IExplorer
{
	AmorousSingleton Amorous { get; }
	Microsoft.Xna.Framework.Game Game { get; }
	AssociativeContentManager Content { get; }
	AbstractDesktop Desktop { get; }
	bool IsUpdateInterrupted { get; set; }
	bool IsDrawInterrupted { get; set; }
	bool IsInternallyInterrupted { get; set; }
	Microsoft.Xna.Framework.Input.Keys[] Keys { get; }
	void Initialize();
	void LoadContent();
	void UnloadContent();
	void Update(GameTime gameTime);
	void Draw(GameTime gameTime);
	void Catch(Exception exception, Action update);
}

public class AmorousExplorer : IExplorer
{
	private readonly Microsoft.Xna.Framework.Game game;
	private readonly AssociativeContentManager content;
	private readonly AmorousSingleton singleton;

	private Texture2D cursorTexture;
	private RenderTarget2D renderTarget;
	private SpriteBatch spriteBatch;
	private Microsoft.Xna.Framework.Input.Keys[] keyboardKeys;

	public static AmorousExplorer Singleton { get; private set; }
	public AmorousSingleton Amorous => singleton;
	public Microsoft.Xna.Framework.Game Game => game;
	public AssociativeContentManager Content => content;
	public AbstractDesktop Desktop { get; private set; }
	public bool IsInternallyInterrupted { get; set; }
	public bool IsUpdateInterrupted { get; set; }
	public bool IsDrawInterrupted { get; set; }

	public Microsoft.Xna.Framework.Input.Keys[] Keys
	{
		get
		{
			if (keyboardKeys == null)
			{
				keyboardKeys = (Microsoft.Xna.Framework.Input.Keys[])Enum.GetValues(typeof(Microsoft.Xna.Framework.Input.Keys));
			}
			return keyboardKeys;
		}
	}

	public AmorousExplorer(Microsoft.Xna.Framework.Game game, bool safemode)
	{
		Singleton = this;
		this.game = game;
		singleton = new EmptyAmorousSingleton(game, safemode);
		content = new AssociativeContentManager(singleton.Content);
	}

	public void Initialize()
	{
		singleton.Initialize();
	}

	public void LoadContent()
	{
		singleton.LoadContent();
		cursorTexture = game.Content.Load<Texture2D>("Assets/GUI/Squid/DefaultCursor");
		renderTarget = singleton.GetRenderTarget();
		spriteBatch = new SpriteBatch(game.GraphicsDevice);
		Desktop = new StartupDesktop(this);
	}

	public void UnloadContent()
	{
		singleton.UnloadContent();
	}

	protected void UpdateControllerFallback(GameTime gameTime)
	{
		singleton.Controller.Update();
		Microsoft.Xna.Framework.Point point = singleton.Canvas.GlobalToContent(singleton.Controller.Cursor);
		List<KeyData> list = new List<KeyData>();
		foreach (Microsoft.Xna.Framework.Input.Keys keys in Keys)
		{
			bool pressed = singleton.Controller.IsPressed(keys);
			bool released = singleton.Controller.IsReleasing(keys);
			if (pressed || released)
			{
				Squid.Keys? availables = SquidExtensions.Keys[Keyboard.GetKeyFromScancodeEXT(keys)];
				if (availables.HasValue)
				{
					list.Add(new KeyData()
					{
						Scancode = (int)availables.Value,
						Char = keys.ChangeKeyboard(singleton.Controller.IsHolding(Microsoft.Xna.Framework.Input.Keys.LeftShift) || singleton.Controller.IsHolding(Microsoft.Xna.Framework.Input.Keys.RightShift)),
						Pressed = pressed,
						Released = released
					});
				}
			}
		}
		Gui.SetKeyboard(list.ToArray());
		Gui.SetButtons(singleton.Controller.IsHolding(ControllerButtonType.LeftButton), singleton.Controller.IsHolding(ControllerButtonType.RightButton));
		Gui.SetMouse(point.X, point.Y, singleton.Controller.ScrollWheel);
		Gui.TimeElapsed = gameTime.ElapsedGameTime.Milliseconds;
	}

	public void Update(GameTime gameTime)
	{
		if (!IsUpdateInterrupted)
		{
			singleton.Update(gameTime);
		}
		else
		{
			UpdateControllerFallback(gameTime);
		}
		if (Desktop != null)
		{
			if (singleton.Controller.IsPressed(Microsoft.Xna.Framework.Input.Keys.OemTilde))
			{
				Desktop.Visible = !Desktop.Visible;
			}
			if (Desktop.Updatable)
			{
				Desktop.Update(gameTime);
			}
		}
	}

	public void Draw(GameTime gameTime)
	{
		if (!IsDrawInterrupted)
		{
			singleton.Draw(gameTime);
		}
		bool interrupted = IsInternallyInterrupted || IsDrawInterrupted;
		if (interrupted || (Desktop != null && Desktop.Visible))
		{
			game.GraphicsDevice.SetRenderTarget(renderTarget);
			if (interrupted)
			{
				game.GraphicsDevice.Clear(IsInternallyInterrupted ? Color.DarkRed : Color.Black);
			}
			if (Desktop != null && Desktop.Visible)
			{
				Desktop.Draw(gameTime);
			}
			game.GraphicsDevice.SetRenderTarget(null);
			if (!interrupted)
			{
				game.GraphicsDevice.Clear(Color.Black);
			}
			spriteBatch.Begin();
			spriteBatch.Draw(renderTarget, singleton.GetDestinationRectangle(), Color.White);
			spriteBatch.Draw(cursorTexture, singleton.Controller.VectorOfCursor, PlayerPreferences.Singleton.Data.PhoneColor);
			spriteBatch.End();
		}
	}

	protected bool InterruptOverlay(Action refresh, bool noRetry = false)
	{
		if (!IsUpdateInterrupted)
		{
			IsUpdateInterrupted = true;
			try
			{
				refresh.Invoke();
				return true;
			}
			catch
			{
				IsUpdateInterrupted = false;
			}
		}
		if (!IsDrawInterrupted)
		{
			IsDrawInterrupted = true;
			try
			{
				refresh.Invoke();
				return true;
			}
			catch
			{
				IsDrawInterrupted = false;
			}
		}
		bool update = IsUpdateInterrupted, draw = IsDrawInterrupted;
		if (noRetry || !(update && draw))
		{
			IsUpdateInterrupted = IsDrawInterrupted = true;
			try
			{
				refresh.Invoke();
				return true;
			}
			catch (Exception exception)
			{
				if (noRetry)
				{
					throw new NotSupportedException("Unexpected failure!", exception);
				}
			}
			IsUpdateInterrupted = update;
			IsDrawInterrupted = draw;
		}
		Desktop = new StartupDesktop(this);
		try
		{
			refresh.Invoke();
			return false;
		}
		catch
		{
		}
		return InterruptOverlay(refresh, true);
	}

	public void Catch(Exception exception, Action refresh)
	{
		IsInternallyInterrupted = false;
		try
		{
			refresh.Invoke();
		}
		catch
		{
			if (IsInternallyInterrupted = InterruptOverlay(refresh))
			{
				Logger.Warning("Amorous is interrupted now, restore it before starting again!");
			}
		}
		if (Desktop != null)
		{
			Desktop.Catch(exception);
		}
	}
}
