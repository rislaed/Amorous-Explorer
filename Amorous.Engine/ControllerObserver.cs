using System;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using SDL2;

public class ControllerObserver
{ // _3FFZvGWTAe7rsviKkDPTXEVjxWf
	private readonly IAmorous _game;
	private Vector2 _cursorVector;
	private Point _cursorPoint;
	private bool _grabbed;
	private KeyboardState _keyboardPrevious;
	private KeyboardState _keyboard;
	private GamePadState _gamepadPrevious;
	private GamePadState _gamepad;
	private MouseState _mousePrevious;
	private MouseState _mouse;

	public Vector2 CursorVector => _cursorVector;
	public Point Cursor => _cursorPoint;
	public int Scroll => Math.Max(-1, Math.Min(_mousePrevious.ScrollWheelValue - _mouse.ScrollWheelValue, 1));

	public bool Grabbed
	{
		get
		{
			return _grabbed;
		}
		set
		{
			SDL.SDL_SetWindowGrab(_game.Window.Handle, value ? SDL.SDL_bool.SDL_TRUE : SDL.SDL_bool.SDL_FALSE);
			_grabbed = value;
		}
	}

	public ControllerObserver(IAmorous game)
	{
		_game = game;
	}

	public void Update()
	{
		_keyboardPrevious = _keyboard;
		_keyboard = Keyboard.GetState();
		_gamepadPrevious = _gamepad;
		_gamepad = GamePad.GetState(PlayerIndex.One);
		_mousePrevious = _mouse;
		_mouse = Mouse.GetState();
		_cursorVector.X = Math.Max(0, Math.Min(_mouse.X, _game.Mouse.DisplayWidth));
		_cursorVector.Y = Math.Max(0, Math.Min(_mouse.Y, _game.Mouse.DisplayHeight));
		_cursorPoint.X = (int)_cursorVector.X;
		_cursorPoint.Y = (int)_cursorVector.Y;
	}

	public bool IsPressed(Keys keys)
	{
		return _keyboard[keys] == KeyState.Down;
	}

	public bool IsPressed(Buttons buttons)
	{
		if (_gamepad.IsConnected)
		{
			return _gamepad.IsButtonDown(buttons);
		}
		return false;
	}

	public bool IsPressed(ControllerButtonType type)
	{
		return type switch
		{
			ControllerButtonType.LeftButton => _mouse.LeftButton == ButtonState.Pressed, 
			ControllerButtonType.MiddleButton => _mouse.MiddleButton == ButtonState.Pressed, 
			ControllerButtonType.RightButton => _mouse.RightButton == ButtonState.Pressed, 
			ControllerButtonType.WheelUp => _mouse.ScrollWheelValue > _mousePrevious.ScrollWheelValue, 
			ControllerButtonType.WheelDown => _mouse.ScrollWheelValue < _mousePrevious.ScrollWheelValue, 
			ControllerButtonType.XButton1 => _mouse.XButton1 == ButtonState.Pressed, 
			ControllerButtonType.XButton2 => _mouse.XButton2 == ButtonState.Pressed, 
			_ => false, 
		};
	}

	public bool IsReleased(Keys keys)
	{
		return _keyboard[keys] == KeyState.Up;
	}

	public bool IsReleased(Buttons buttons)
	{
		if (_gamepad.IsConnected)
		{
			return _gamepad.IsButtonUp(buttons);
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
				return _mouse.LeftButton == ButtonState.Released;
			case ControllerButtonType.MiddleButton:
				return _mouse.MiddleButton == ButtonState.Released;
			case ControllerButtonType.RightButton:
				return _mouse.RightButton == ButtonState.Released;
			case ControllerButtonType.WheelUp:
			case ControllerButtonType.WheelDown:
				return _mouse.ScrollWheelValue - _mousePrevious.ScrollWheelValue == 0;
			case ControllerButtonType.XButton1:
				return _mouse.XButton1 == ButtonState.Released;
			case ControllerButtonType.XButton2:
				return _mouse.XButton2 == ButtonState.Released;
		}
	}

	public bool JustPressed(Keys keys)
	{
		if (_keyboardPrevious[keys] == KeyState.Up)
		{
			return _keyboard[keys] == KeyState.Down;
		}
		return false;
	}

	public bool JustPressed(Buttons buttons)
	{
		if (_gamepadPrevious.IsConnected && _gamepad.IsConnected)
		{
			if (!_gamepadPrevious.IsButtonUp(buttons))
			{
				return false;
			}
			return _gamepad.IsButtonDown(buttons);
		}
		return false;
	}

	public bool JustPressed(ControllerButtonType type)
	{
		switch (type)
		{
			default:
				return false;
			case ControllerButtonType.LeftButton:
				if (_mousePrevious.LeftButton != 0)
				{
					return false;
				}
				return _mouse.LeftButton == ButtonState.Pressed;
			case ControllerButtonType.MiddleButton:
				if (_mousePrevious.MiddleButton == ButtonState.Released)
				{
					return _mouse.MiddleButton == ButtonState.Pressed;
				}
				return false;
			case ControllerButtonType.RightButton:
				if (_mousePrevious.RightButton != 0)
				{
					return false;
				}
				return _mouse.RightButton == ButtonState.Pressed;
			case ControllerButtonType.WheelUp:
				return _mouse.ScrollWheelValue > _mousePrevious.ScrollWheelValue;
			case ControllerButtonType.WheelDown:
				return _mouse.ScrollWheelValue < _mousePrevious.ScrollWheelValue;
			case ControllerButtonType.XButton1:
				if (_mousePrevious.XButton1 != 0)
				{
					return false;
				}
				return _mouse.XButton1 == ButtonState.Pressed;
			case ControllerButtonType.XButton2:
				if (_mousePrevious.XButton2 == ButtonState.Released)
				{
					return _mouse.XButton2 == ButtonState.Pressed;
				}
				return false;
		}
	}

	public bool JustReleased(Keys keys)
	{
		if (_keyboardPrevious[keys] == KeyState.Down)
		{
			return _keyboard[keys] == KeyState.Up;
		}
		return false;
	}

	public bool JustReleased(Buttons buttons)
	{
		if (_gamepadPrevious.IsConnected && _gamepad.IsConnected)
		{
			if (!_gamepadPrevious.IsButtonDown(buttons))
			{
				return false;
			}
			return _gamepad.IsButtonUp(buttons);
		}
		return false;
	}

	public bool JustReleased(ControllerButtonType type)
	{
		switch (type)
		{
			default:
				return false;
			case ControllerButtonType.LeftButton:
				if (_mousePrevious.LeftButton == ButtonState.Pressed)
				{
					return _mouse.LeftButton == ButtonState.Released;
				}
				return false;
			case ControllerButtonType.MiddleButton:
				if (_mousePrevious.MiddleButton != ButtonState.Pressed)
				{
					return false;
				}
				return _mouse.MiddleButton == ButtonState.Released;
			case ControllerButtonType.RightButton:
				if (_mousePrevious.RightButton == ButtonState.Pressed)
				{
					return _mouse.RightButton == ButtonState.Released;
				}
				return false;
			case ControllerButtonType.WheelUp:
				return _mouse.ScrollWheelValue > _mousePrevious.ScrollWheelValue;
			case ControllerButtonType.WheelDown:
				return _mouse.ScrollWheelValue < _mousePrevious.ScrollWheelValue;
			case ControllerButtonType.XButton1:
				if (_mousePrevious.XButton1 == ButtonState.Pressed)
				{
					return _mouse.XButton1 == ButtonState.Released;
				}
				return false;
			case ControllerButtonType.XButton2:
				if (_mousePrevious.XButton2 != ButtonState.Pressed)
				{
					return false;
				}
				return _mouse.XButton2 == ButtonState.Released;
		}
	}

	public bool InInteraction()
	{
		if (_keyboard.GetPressedKeys().Length != 0)
		{
			return true;
		}
		Array values = Enum.GetValues(typeof(Buttons));
		foreach (Buttons item in values)
		{
			if (IsPressed(item))
			{
				return true;
			}
		}
		values = Enum.GetValues(typeof(ControllerButtonType));
		foreach (ControllerButtonType item in values)
		{
			if (IsPressed(item))
			{
				return true;
			}
		}
		return false;
	}

	public Keys[] JustPressed()
	{
		Keys[] previousKeys = _keyboardPrevious.GetPressedKeys();
		Keys[] keys = _keyboard.GetPressedKeys();
		return keys.Where((Keys to) => previousKeys.Contains(to)).ToArray();
	}
}
