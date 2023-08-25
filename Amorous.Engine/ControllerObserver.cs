using System;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using SDL2;

public class ControllerObserver
{ // _3FFZvGWTAe7rsviKkDPTXEVjxWf
	private readonly IAmorous game;
	private Vector2 vectorOfCursor;
	private Point cursor;
	private bool grabbed;
	private KeyboardState keyboardStateLast;
	private KeyboardState keyboardState;
	private GamePadState gamepadStateLast;
	private GamePadState gamepadState;
	private MouseState mouseStateLast;
	private MouseState mouseState;

	public Vector2 VectorOfCursor => vectorOfCursor;
	public Point Cursor => cursor;
	public int ScrollWheel => Math.Max(-1, Math.Min(mouseStateLast.ScrollWheelValue - mouseState.ScrollWheelValue, 1));

	public bool Grabbed
	{
		get
		{
			return grabbed;
		}
		set
		{
			SDL.SDL_SetWindowGrab(game.Window.Handle, value ? SDL.SDL_bool.SDL_TRUE : SDL.SDL_bool.SDL_FALSE);
			grabbed = value;
		}
	}

	public ControllerObserver(IAmorous game)
	{
		this.game = game;
	}

	public void Update()
	{
		keyboardStateLast = keyboardState;
		keyboardState = Keyboard.GetState();
		gamepadStateLast = gamepadState;
		gamepadState = GamePad.GetState(PlayerIndex.One);
		mouseStateLast = mouseState;
		mouseState = Mouse.GetState();
		vectorOfCursor.X = Math.Max(0, Math.Min(mouseState.X, game.Canvas.WindowWidth));
		vectorOfCursor.Y = Math.Max(0, Math.Min(mouseState.Y, game.Canvas.WindowHeight));
		cursor.X = (int)vectorOfCursor.X;
		cursor.Y = (int)vectorOfCursor.Y;
	}

	public bool IsHolding(Keys keys)
	{
		return keyboardState[keys] == KeyState.Down;
	}

	public bool IsHolding(Buttons buttons)
	{
		if (gamepadState.IsConnected)
		{
			return gamepadState.IsButtonDown(buttons);
		}
		return false;
	}

	public bool IsHolding(ControllerButtonType type)
	{
		return type switch
		{
			ControllerButtonType.LeftButton => mouseState.LeftButton == ButtonState.Pressed, 
			ControllerButtonType.MiddleButton => mouseState.MiddleButton == ButtonState.Pressed, 
			ControllerButtonType.RightButton => mouseState.RightButton == ButtonState.Pressed, 
			ControllerButtonType.WheelUp => mouseState.ScrollWheelValue > mouseStateLast.ScrollWheelValue, 
			ControllerButtonType.WheelDown => mouseState.ScrollWheelValue < mouseStateLast.ScrollWheelValue, 
			ControllerButtonType.XButton1 => mouseState.XButton1 == ButtonState.Pressed, 
			ControllerButtonType.XButton2 => mouseState.XButton2 == ButtonState.Pressed, 
			_ => false, 
		};
	}

	public bool IsReleased(Keys keys)
	{
		return keyboardState[keys] == KeyState.Up;
	}

	public bool IsReleased(Buttons buttons)
	{
		if (gamepadState.IsConnected)
		{
			return gamepadState.IsButtonUp(buttons);
		}
		return true;
	}

	public bool IsReleased(ControllerButtonType type)
	{
		switch (type)
		{
			default:
				return true;
			case ControllerButtonType.LeftButton:
				return mouseState.LeftButton == ButtonState.Released;
			case ControllerButtonType.MiddleButton:
				return mouseState.MiddleButton == ButtonState.Released;
			case ControllerButtonType.RightButton:
				return mouseState.RightButton == ButtonState.Released;
			case ControllerButtonType.WheelUp:
			case ControllerButtonType.WheelDown:
				return mouseState.ScrollWheelValue - mouseStateLast.ScrollWheelValue == 0;
			case ControllerButtonType.XButton1:
				return mouseState.XButton1 == ButtonState.Released;
			case ControllerButtonType.XButton2:
				return mouseState.XButton2 == ButtonState.Released;
		}
	}

	public bool IsPressed(Keys keys)
	{
		if (keyboardStateLast[keys] == KeyState.Up)
		{
			return keyboardState[keys] == KeyState.Down;
		}
		return false;
	}

	public bool IsPressed(Buttons buttons)
	{
		if (gamepadStateLast.IsConnected && gamepadState.IsConnected)
		{
			if (!gamepadStateLast.IsButtonUp(buttons))
			{
				return false;
			}
			return gamepadState.IsButtonDown(buttons);
		}
		return false;
	}

	public bool IsPressed(ControllerButtonType type)
	{
		switch (type)
		{
			default:
				return false;
			case ControllerButtonType.LeftButton:
				if (mouseStateLast.LeftButton != 0)
				{
					return false;
				}
				return mouseState.LeftButton == ButtonState.Pressed;
			case ControllerButtonType.MiddleButton:
				if (mouseStateLast.MiddleButton == ButtonState.Released)
				{
					return mouseState.MiddleButton == ButtonState.Pressed;
				}
				return false;
			case ControllerButtonType.RightButton:
				if (mouseStateLast.RightButton != 0)
				{
					return false;
				}
				return mouseState.RightButton == ButtonState.Pressed;
			case ControllerButtonType.WheelUp:
				return mouseState.ScrollWheelValue > mouseStateLast.ScrollWheelValue;
			case ControllerButtonType.WheelDown:
				return mouseState.ScrollWheelValue < mouseStateLast.ScrollWheelValue;
			case ControllerButtonType.XButton1:
				if (mouseStateLast.XButton1 != 0)
				{
					return false;
				}
				return mouseState.XButton1 == ButtonState.Pressed;
			case ControllerButtonType.XButton2:
				if (mouseStateLast.XButton2 == ButtonState.Released)
				{
					return mouseState.XButton2 == ButtonState.Pressed;
				}
				return false;
		}
	}

	public bool IsReleasing(Keys keys)
	{
		if (keyboardStateLast[keys] == KeyState.Down)
		{
			return keyboardState[keys] == KeyState.Up;
		}
		return false;
	}

	public bool IsReleasing(Buttons buttons)
	{
		if (gamepadStateLast.IsConnected && gamepadState.IsConnected)
		{
			if (!gamepadStateLast.IsButtonDown(buttons))
			{
				return false;
			}
			return gamepadState.IsButtonUp(buttons);
		}
		return false;
	}

	public bool IsReleasing(ControllerButtonType type)
	{
		switch (type)
		{
			default:
				return false;
			case ControllerButtonType.LeftButton:
				if (mouseStateLast.LeftButton == ButtonState.Pressed)
				{
					return mouseState.LeftButton == ButtonState.Released;
				}
				return false;
			case ControllerButtonType.MiddleButton:
				if (mouseStateLast.MiddleButton != ButtonState.Pressed)
				{
					return false;
				}
				return mouseState.MiddleButton == ButtonState.Released;
			case ControllerButtonType.RightButton:
				if (mouseStateLast.RightButton == ButtonState.Pressed)
				{
					return mouseState.RightButton == ButtonState.Released;
				}
				return false;
			case ControllerButtonType.WheelUp:
				return mouseState.ScrollWheelValue > mouseStateLast.ScrollWheelValue;
			case ControllerButtonType.WheelDown:
				return mouseState.ScrollWheelValue < mouseStateLast.ScrollWheelValue;
			case ControllerButtonType.XButton1:
				if (mouseStateLast.XButton1 == ButtonState.Pressed)
				{
					return mouseState.XButton1 == ButtonState.Released;
				}
				return false;
			case ControllerButtonType.XButton2:
				if (mouseStateLast.XButton2 != ButtonState.Pressed)
				{
					return false;
				}
				return mouseState.XButton2 == ButtonState.Released;
		}
	}

	public bool IsHolding()
	{
		if (keyboardState.GetPressedKeys().Length != 0)
		{
			return true;
		}
		Array buttons = Enum.GetValues(typeof(Buttons));
		foreach (Buttons button in buttons)
		{
			if (IsHolding(button))
			{
				return true;
			}
		}
		buttons = Enum.GetValues(typeof(ControllerButtonType));
		foreach (ControllerButtonType button in buttons)
		{
			if (IsHolding(button))
			{
				return true;
			}
		}
		return false;
	}

	public Keys[] IsPressing()
	{
		Keys[] lastKeys = keyboardStateLast.GetPressedKeys();
		Keys[] keys = keyboardState.GetPressedKeys();
		return keys.Where((Keys key) => lastKeys.Contains(key)).ToArray();
	}
}
