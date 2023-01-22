using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using SDL2;

public class _3FFZvGWTAe7rsviKkDPTXEVjxWf
{
	[CompilerGenerated]
	private sealed class _KOh4sx2NZ0bM2cvCmfoSbVrCbxm
	{
		public Keys[] _qy4C18YJHEicy4hTkm6j5yaDlSV;

		internal bool _A9CfPN7dQuZ3AAVKZF9ow2bKb7y(Keys keys_0)
		{
			return _qy4C18YJHEicy4hTkm6j5yaDlSV.Contains(keys_0);
		}
	}

	private readonly _JbeCmOie0phb2cbgG6DdGZrbs3pB _4L7hfXrWoDdArQiscG4ukHCV46B;

	private Vector2 _z4wENYBCooFsUzGd3jpaiN6UNNL;

	private Point _bN58s8paKnVuWr3UMJsZkvbV9WA;

	private bool _TuLPATzfvkT61cGzdP0BdAYgdRg;

	private KeyboardState _JxAOrrJ4bqv0CaScbroMtsBP9vo;

	private KeyboardState _QyGrB1OudfOfivAikLqMIOfHz3L;

	private GamePadState _RYQYlBTtUaKPqglBPk0fi7hT7pr;

	private GamePadState _QG4mFT06aDk75H8FavD2erQSaah;

	private MouseState _nL6AWNBZGcjH4ycaR2xzpUdcYpMA;

	private MouseState _N9dtCLxcbyjVo7hRyMVQzD7exaM;

	public Vector2 _6M9HDt28e1QHBuYsAXgqiY8jVlA => _z4wENYBCooFsUzGd3jpaiN6UNNL;

	public Point _U7CeYBJ1v1SoUxpX8emsQ9mWl5b => _bN58s8paKnVuWr3UMJsZkvbV9WA;

	public int _xFrCcVNAYrShLz07HqDph01nGwX => Math.Max(-1, Math.Min(_nL6AWNBZGcjH4ycaR2xzpUdcYpMA.ScrollWheelValue - _N9dtCLxcbyjVo7hRyMVQzD7exaM.ScrollWheelValue, 1));

	public bool _tZI6Co0uB31aGK7Qk4qvEImgcnO
	{
		get
		{
			return _TuLPATzfvkT61cGzdP0BdAYgdRg;
		}
		set
		{
			SDL.SDL_SetWindowGrab(_4L7hfXrWoDdArQiscG4ukHCV46B._8k7Do3TGW5NrB22zl8QzInP2j7k.Handle, value ? SDL.SDL_bool.SDL_TRUE : SDL.SDL_bool.SDL_FALSE);
			_TuLPATzfvkT61cGzdP0BdAYgdRg = value;
		}
	}

	public _3FFZvGWTAe7rsviKkDPTXEVjxWf(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		_4L7hfXrWoDdArQiscG4ukHCV46B = _JbeCmOie0phb2cbgG6DdGZrbs3pB_0;
	}

	public void _tiBFUHPEkedkbgvuX3whdeyjhKo()
	{
		_JxAOrrJ4bqv0CaScbroMtsBP9vo = _QyGrB1OudfOfivAikLqMIOfHz3L;
		_QyGrB1OudfOfivAikLqMIOfHz3L = Keyboard.GetState();
		_RYQYlBTtUaKPqglBPk0fi7hT7pr = _QG4mFT06aDk75H8FavD2erQSaah;
		_QG4mFT06aDk75H8FavD2erQSaah = GamePad.GetState(PlayerIndex.One);
		_nL6AWNBZGcjH4ycaR2xzpUdcYpMA = _N9dtCLxcbyjVo7hRyMVQzD7exaM;
		_N9dtCLxcbyjVo7hRyMVQzD7exaM = Mouse.GetState();
		_z4wENYBCooFsUzGd3jpaiN6UNNL.X = Math.Max(0, Math.Min(_N9dtCLxcbyjVo7hRyMVQzD7exaM.X, _4L7hfXrWoDdArQiscG4ukHCV46B._vsceSzSIjBy2nZrCxAzKZbUiwLq._ssaTWDF5CYtQ9fGbLNtaLrgFtvJ));
		_z4wENYBCooFsUzGd3jpaiN6UNNL.Y = Math.Max(0, Math.Min(_N9dtCLxcbyjVo7hRyMVQzD7exaM.Y, _4L7hfXrWoDdArQiscG4ukHCV46B._vsceSzSIjBy2nZrCxAzKZbUiwLq._EM2dYeybqjLlS6bODr1k9TxIRZU));
		_bN58s8paKnVuWr3UMJsZkvbV9WA.X = (int)_z4wENYBCooFsUzGd3jpaiN6UNNL.X;
		_bN58s8paKnVuWr3UMJsZkvbV9WA.Y = (int)_z4wENYBCooFsUzGd3jpaiN6UNNL.Y;
	}

	public bool _WZ4xYI5Q3hoCNX9QFzE3jfDwZBJ(Keys keys_0)
	{
		return _QyGrB1OudfOfivAikLqMIOfHz3L[keys_0] == KeyState.Down;
	}

	public bool _WZ4xYI5Q3hoCNX9QFzE3jfDwZBJ(Buttons buttons_0)
	{
		if (_QG4mFT06aDk75H8FavD2erQSaah.IsConnected)
		{
			return _QG4mFT06aDk75H8FavD2erQSaah.IsButtonDown(buttons_0);
		}
		return false;
	}

	public bool _WZ4xYI5Q3hoCNX9QFzE3jfDwZBJ(_PMeRYZJaBCqgB9uADJFP3c14lxq _PMeRYZJaBCqgB9uADJFP3c14lxq_0)
	{
		return _PMeRYZJaBCqgB9uADJFP3c14lxq_0 switch
		{
			_PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton => _N9dtCLxcbyjVo7hRyMVQzD7exaM.LeftButton == ButtonState.Pressed, 
			_PMeRYZJaBCqgB9uADJFP3c14lxq.MiddleButton => _N9dtCLxcbyjVo7hRyMVQzD7exaM.MiddleButton == ButtonState.Pressed, 
			_PMeRYZJaBCqgB9uADJFP3c14lxq.RightButton => _N9dtCLxcbyjVo7hRyMVQzD7exaM.RightButton == ButtonState.Pressed, 
			_PMeRYZJaBCqgB9uADJFP3c14lxq.WheelUp => _N9dtCLxcbyjVo7hRyMVQzD7exaM.ScrollWheelValue > _nL6AWNBZGcjH4ycaR2xzpUdcYpMA.ScrollWheelValue, 
			_PMeRYZJaBCqgB9uADJFP3c14lxq.WheelDown => _N9dtCLxcbyjVo7hRyMVQzD7exaM.ScrollWheelValue < _nL6AWNBZGcjH4ycaR2xzpUdcYpMA.ScrollWheelValue, 
			_PMeRYZJaBCqgB9uADJFP3c14lxq.XButton1 => _N9dtCLxcbyjVo7hRyMVQzD7exaM.XButton1 == ButtonState.Pressed, 
			_PMeRYZJaBCqgB9uADJFP3c14lxq.XButton2 => _N9dtCLxcbyjVo7hRyMVQzD7exaM.XButton2 == ButtonState.Pressed, 
			_ => false, 
		};
	}

	public bool _8SJFmJwpIuh21zGxGpCCuX20PBj(Keys keys_0)
	{
		return _QyGrB1OudfOfivAikLqMIOfHz3L[keys_0] == KeyState.Up;
	}

	public bool _8SJFmJwpIuh21zGxGpCCuX20PBj(Buttons buttons_0)
	{
		if (_QG4mFT06aDk75H8FavD2erQSaah.IsConnected)
		{
			return _QG4mFT06aDk75H8FavD2erQSaah.IsButtonUp(buttons_0);
		}
		return true;
	}

	public bool _8SJFmJwpIuh21zGxGpCCuX20PBj(_PMeRYZJaBCqgB9uADJFP3c14lxq _PMeRYZJaBCqgB9uADJFP3c14lxq_0)
	{
		switch (_PMeRYZJaBCqgB9uADJFP3c14lxq_0)
		{
		default:
			return true;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton:
			return _N9dtCLxcbyjVo7hRyMVQzD7exaM.LeftButton == ButtonState.Released;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.MiddleButton:
			return _N9dtCLxcbyjVo7hRyMVQzD7exaM.MiddleButton == ButtonState.Released;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.RightButton:
			return _N9dtCLxcbyjVo7hRyMVQzD7exaM.RightButton == ButtonState.Released;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.WheelUp:
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.WheelDown:
			return _N9dtCLxcbyjVo7hRyMVQzD7exaM.ScrollWheelValue - _nL6AWNBZGcjH4ycaR2xzpUdcYpMA.ScrollWheelValue == 0;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.XButton1:
			return _N9dtCLxcbyjVo7hRyMVQzD7exaM.XButton1 == ButtonState.Released;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.XButton2:
			return _N9dtCLxcbyjVo7hRyMVQzD7exaM.XButton2 == ButtonState.Released;
		}
	}

	public bool _fy5ebLnmRsRXv9v7RKTFU5CGMaH(Keys keys_0)
	{
		if (_JxAOrrJ4bqv0CaScbroMtsBP9vo[keys_0] == KeyState.Up)
		{
			return _QyGrB1OudfOfivAikLqMIOfHz3L[keys_0] == KeyState.Down;
		}
		return false;
	}

	public bool _fy5ebLnmRsRXv9v7RKTFU5CGMaH(Buttons buttons_0)
	{
		if (_RYQYlBTtUaKPqglBPk0fi7hT7pr.IsConnected && _QG4mFT06aDk75H8FavD2erQSaah.IsConnected)
		{
			if (!_RYQYlBTtUaKPqglBPk0fi7hT7pr.IsButtonUp(buttons_0))
			{
				return false;
			}
			return _QG4mFT06aDk75H8FavD2erQSaah.IsButtonDown(buttons_0);
		}
		return false;
	}

	public bool _fy5ebLnmRsRXv9v7RKTFU5CGMaH(_PMeRYZJaBCqgB9uADJFP3c14lxq _PMeRYZJaBCqgB9uADJFP3c14lxq_0)
	{
		switch (_PMeRYZJaBCqgB9uADJFP3c14lxq_0)
		{
		default:
			return false;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton:
			if (_nL6AWNBZGcjH4ycaR2xzpUdcYpMA.LeftButton != 0)
			{
				return false;
			}
			return _N9dtCLxcbyjVo7hRyMVQzD7exaM.LeftButton == ButtonState.Pressed;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.MiddleButton:
			if (_nL6AWNBZGcjH4ycaR2xzpUdcYpMA.MiddleButton == ButtonState.Released)
			{
				return _N9dtCLxcbyjVo7hRyMVQzD7exaM.MiddleButton == ButtonState.Pressed;
			}
			return false;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.RightButton:
			if (_nL6AWNBZGcjH4ycaR2xzpUdcYpMA.RightButton != 0)
			{
				return false;
			}
			return _N9dtCLxcbyjVo7hRyMVQzD7exaM.RightButton == ButtonState.Pressed;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.WheelUp:
			return _N9dtCLxcbyjVo7hRyMVQzD7exaM.ScrollWheelValue > _nL6AWNBZGcjH4ycaR2xzpUdcYpMA.ScrollWheelValue;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.WheelDown:
			return _N9dtCLxcbyjVo7hRyMVQzD7exaM.ScrollWheelValue < _nL6AWNBZGcjH4ycaR2xzpUdcYpMA.ScrollWheelValue;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.XButton1:
			if (_nL6AWNBZGcjH4ycaR2xzpUdcYpMA.XButton1 != 0)
			{
				return false;
			}
			return _N9dtCLxcbyjVo7hRyMVQzD7exaM.XButton1 == ButtonState.Pressed;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.XButton2:
			if (_nL6AWNBZGcjH4ycaR2xzpUdcYpMA.XButton2 == ButtonState.Released)
			{
				return _N9dtCLxcbyjVo7hRyMVQzD7exaM.XButton2 == ButtonState.Pressed;
			}
			return false;
		}
	}

	public bool _KGCwEHf8akeXdkHLKFg1caFxXUJ(Keys keys_0)
	{
		if (_JxAOrrJ4bqv0CaScbroMtsBP9vo[keys_0] == KeyState.Down)
		{
			return _QyGrB1OudfOfivAikLqMIOfHz3L[keys_0] == KeyState.Up;
		}
		return false;
	}

	public bool _KGCwEHf8akeXdkHLKFg1caFxXUJ(Buttons buttons_0)
	{
		if (_RYQYlBTtUaKPqglBPk0fi7hT7pr.IsConnected && _QG4mFT06aDk75H8FavD2erQSaah.IsConnected)
		{
			if (!_RYQYlBTtUaKPqglBPk0fi7hT7pr.IsButtonDown(buttons_0))
			{
				return false;
			}
			return _QG4mFT06aDk75H8FavD2erQSaah.IsButtonUp(buttons_0);
		}
		return false;
	}

	public bool _KGCwEHf8akeXdkHLKFg1caFxXUJ(_PMeRYZJaBCqgB9uADJFP3c14lxq _PMeRYZJaBCqgB9uADJFP3c14lxq_0)
	{
		switch (_PMeRYZJaBCqgB9uADJFP3c14lxq_0)
		{
		default:
			return false;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton:
			if (_nL6AWNBZGcjH4ycaR2xzpUdcYpMA.LeftButton == ButtonState.Pressed)
			{
				return _N9dtCLxcbyjVo7hRyMVQzD7exaM.LeftButton == ButtonState.Released;
			}
			return false;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.MiddleButton:
			if (_nL6AWNBZGcjH4ycaR2xzpUdcYpMA.MiddleButton != ButtonState.Pressed)
			{
				return false;
			}
			return _N9dtCLxcbyjVo7hRyMVQzD7exaM.MiddleButton == ButtonState.Released;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.RightButton:
			if (_nL6AWNBZGcjH4ycaR2xzpUdcYpMA.RightButton == ButtonState.Pressed)
			{
				return _N9dtCLxcbyjVo7hRyMVQzD7exaM.RightButton == ButtonState.Released;
			}
			return false;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.WheelUp:
			return _N9dtCLxcbyjVo7hRyMVQzD7exaM.ScrollWheelValue > _nL6AWNBZGcjH4ycaR2xzpUdcYpMA.ScrollWheelValue;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.WheelDown:
			return _N9dtCLxcbyjVo7hRyMVQzD7exaM.ScrollWheelValue < _nL6AWNBZGcjH4ycaR2xzpUdcYpMA.ScrollWheelValue;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.XButton1:
			if (_nL6AWNBZGcjH4ycaR2xzpUdcYpMA.XButton1 == ButtonState.Pressed)
			{
				return _N9dtCLxcbyjVo7hRyMVQzD7exaM.XButton1 == ButtonState.Released;
			}
			return false;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.XButton2:
			if (_nL6AWNBZGcjH4ycaR2xzpUdcYpMA.XButton2 != ButtonState.Pressed)
			{
				return false;
			}
			return _N9dtCLxcbyjVo7hRyMVQzD7exaM.XButton2 == ButtonState.Released;
		}
	}

	public bool _tiRsbEQbFPPjJoih0Y5DKxbGe52()
	{
		if (_QyGrB1OudfOfivAikLqMIOfHz3L.GetPressedKeys().Length != 0)
		{
			return true;
		}
		Array values = Enum.GetValues(typeof(Buttons));
		foreach (Buttons item in values)
		{
			if (_WZ4xYI5Q3hoCNX9QFzE3jfDwZBJ(item))
			{
				return true;
			}
		}
		Array values2 = Enum.GetValues(typeof(_PMeRYZJaBCqgB9uADJFP3c14lxq));
		foreach (_PMeRYZJaBCqgB9uADJFP3c14lxq item2 in values2)
		{
			if (_WZ4xYI5Q3hoCNX9QFzE3jfDwZBJ(item2))
			{
				return true;
			}
		}
		return false;
	}

	public Keys[] _fy5ebLnmRsRXv9v7RKTFU5CGMaH()
	{
		Keys[] _qy4C18YJHEicy4hTkm6j5yaDlSV = _JxAOrrJ4bqv0CaScbroMtsBP9vo.GetPressedKeys();
		Keys[] pressedKeys = _QyGrB1OudfOfivAikLqMIOfHz3L.GetPressedKeys();
		return pressedKeys.Where((Keys keys_0) => _qy4C18YJHEicy4hTkm6j5yaDlSV.Contains(keys_0)).ToArray();
	}

	static IntPtr smethod_0(GameWindow gameWindow_0)
	{
		return gameWindow_0.Handle;
	}

	static void smethod_1(IntPtr intptr_0, SDL.SDL_bool sdl_bool_0)
	{
		SDL.SDL_SetWindowGrab(intptr_0, sdl_bool_0);
	}

	static KeyboardState smethod_2()
	{
		return Keyboard.GetState();
	}

	static GamePadState smethod_3(PlayerIndex playerIndex_0)
	{
		return GamePad.GetState(playerIndex_0);
	}

	static MouseState smethod_4()
	{
		return Mouse.GetState();
	}
}
