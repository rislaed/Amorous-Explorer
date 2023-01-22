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
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
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

	public int _xFrCcVNAYrShLz07HqDph01nGwX => Math.Max(-1, Math.Min(((MouseState)(ref _nL6AWNBZGcjH4ycaR2xzpUdcYpMA)).get_ScrollWheelValue() - ((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_ScrollWheelValue(), 1));

	public bool _tZI6Co0uB31aGK7Qk4qvEImgcnO
	{
		get
		{
			return _TuLPATzfvkT61cGzdP0BdAYgdRg;
		}
		set
		{
			_3FFZvGWTAe7rsviKkDPTXEVjxWf.smethod_1(_3FFZvGWTAe7rsviKkDPTXEVjxWf.smethod_0(_4L7hfXrWoDdArQiscG4ukHCV46B._8k7Do3TGW5NrB22zl8QzInP2j7k), (SDL_bool)(value ? 1 : 0));
			_TuLPATzfvkT61cGzdP0BdAYgdRg = value;
		}
	}

	public _3FFZvGWTAe7rsviKkDPTXEVjxWf(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		_4L7hfXrWoDdArQiscG4ukHCV46B = _JbeCmOie0phb2cbgG6DdGZrbs3pB_0;
	}

	public void _tiBFUHPEkedkbgvuX3whdeyjhKo()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		_JxAOrrJ4bqv0CaScbroMtsBP9vo = _QyGrB1OudfOfivAikLqMIOfHz3L;
		_QyGrB1OudfOfivAikLqMIOfHz3L = _3FFZvGWTAe7rsviKkDPTXEVjxWf.smethod_2();
		_RYQYlBTtUaKPqglBPk0fi7hT7pr = _QG4mFT06aDk75H8FavD2erQSaah;
		_QG4mFT06aDk75H8FavD2erQSaah = _3FFZvGWTAe7rsviKkDPTXEVjxWf.smethod_3((PlayerIndex)0);
		_nL6AWNBZGcjH4ycaR2xzpUdcYpMA = _N9dtCLxcbyjVo7hRyMVQzD7exaM;
		_N9dtCLxcbyjVo7hRyMVQzD7exaM = _3FFZvGWTAe7rsviKkDPTXEVjxWf.smethod_4();
		_z4wENYBCooFsUzGd3jpaiN6UNNL.X = Math.Max(0, Math.Min(((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_X(), _4L7hfXrWoDdArQiscG4ukHCV46B._vsceSzSIjBy2nZrCxAzKZbUiwLq._ssaTWDF5CYtQ9fGbLNtaLrgFtvJ));
		_z4wENYBCooFsUzGd3jpaiN6UNNL.Y = Math.Max(0, Math.Min(((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_Y(), _4L7hfXrWoDdArQiscG4ukHCV46B._vsceSzSIjBy2nZrCxAzKZbUiwLq._EM2dYeybqjLlS6bODr1k9TxIRZU));
		_bN58s8paKnVuWr3UMJsZkvbV9WA.X = (int)_z4wENYBCooFsUzGd3jpaiN6UNNL.X;
		_bN58s8paKnVuWr3UMJsZkvbV9WA.Y = (int)_z4wENYBCooFsUzGd3jpaiN6UNNL.Y;
	}

	public bool _WZ4xYI5Q3hoCNX9QFzE3jfDwZBJ(Keys keys_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		return (int)((KeyboardState)(ref _QyGrB1OudfOfivAikLqMIOfHz3L)).get_Item(keys_0) == 1;
	}

	public bool _WZ4xYI5Q3hoCNX9QFzE3jfDwZBJ(Buttons buttons_0)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (((GamePadState)(ref _QG4mFT06aDk75H8FavD2erQSaah)).get_IsConnected())
		{
			return ((GamePadState)(ref _QG4mFT06aDk75H8FavD2erQSaah)).IsButtonDown(buttons_0);
		}
		return false;
	}

	public bool _WZ4xYI5Q3hoCNX9QFzE3jfDwZBJ(_PMeRYZJaBCqgB9uADJFP3c14lxq _PMeRYZJaBCqgB9uADJFP3c14lxq_0)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Invalid comparison between Unknown and I4
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Invalid comparison between Unknown and I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Invalid comparison between Unknown and I4
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Invalid comparison between Unknown and I4
		return _PMeRYZJaBCqgB9uADJFP3c14lxq_0 switch
		{
			_PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton => (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_LeftButton() == 1, 
			_PMeRYZJaBCqgB9uADJFP3c14lxq.MiddleButton => (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_MiddleButton() == 1, 
			_PMeRYZJaBCqgB9uADJFP3c14lxq.RightButton => (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_RightButton() == 1, 
			_PMeRYZJaBCqgB9uADJFP3c14lxq.WheelUp => ((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_ScrollWheelValue() > ((MouseState)(ref _nL6AWNBZGcjH4ycaR2xzpUdcYpMA)).get_ScrollWheelValue(), 
			_PMeRYZJaBCqgB9uADJFP3c14lxq.WheelDown => ((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_ScrollWheelValue() < ((MouseState)(ref _nL6AWNBZGcjH4ycaR2xzpUdcYpMA)).get_ScrollWheelValue(), 
			_PMeRYZJaBCqgB9uADJFP3c14lxq.XButton1 => (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_XButton1() == 1, 
			_PMeRYZJaBCqgB9uADJFP3c14lxq.XButton2 => (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_XButton2() == 1, 
			_ => false, 
		};
	}

	public bool _8SJFmJwpIuh21zGxGpCCuX20PBj(Keys keys_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		return (int)((KeyboardState)(ref _QyGrB1OudfOfivAikLqMIOfHz3L)).get_Item(keys_0) == 0;
	}

	public bool _8SJFmJwpIuh21zGxGpCCuX20PBj(Buttons buttons_0)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (((GamePadState)(ref _QG4mFT06aDk75H8FavD2erQSaah)).get_IsConnected())
		{
			return ((GamePadState)(ref _QG4mFT06aDk75H8FavD2erQSaah)).IsButtonUp(buttons_0);
		}
		return true;
	}

	public bool _8SJFmJwpIuh21zGxGpCCuX20PBj(_PMeRYZJaBCqgB9uADJFP3c14lxq _PMeRYZJaBCqgB9uADJFP3c14lxq_0)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Invalid comparison between Unknown and I4
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Invalid comparison between Unknown and I4
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Invalid comparison between Unknown and I4
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Invalid comparison between Unknown and I4
		switch (_PMeRYZJaBCqgB9uADJFP3c14lxq_0)
		{
		default:
			return true;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton:
			return (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_LeftButton() == 0;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.MiddleButton:
			return (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_MiddleButton() == 0;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.RightButton:
			return (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_RightButton() == 0;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.WheelUp:
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.WheelDown:
			return ((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_ScrollWheelValue() - ((MouseState)(ref _nL6AWNBZGcjH4ycaR2xzpUdcYpMA)).get_ScrollWheelValue() == 0;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.XButton1:
			return (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_XButton1() == 0;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.XButton2:
			return (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_XButton2() == 0;
		}
	}

	public bool _fy5ebLnmRsRXv9v7RKTFU5CGMaH(Keys keys_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Invalid comparison between Unknown and I4
		if ((int)((KeyboardState)(ref _JxAOrrJ4bqv0CaScbroMtsBP9vo)).get_Item(keys_0) == 0)
		{
			return (int)((KeyboardState)(ref _QyGrB1OudfOfivAikLqMIOfHz3L)).get_Item(keys_0) == 1;
		}
		return false;
	}

	public bool _fy5ebLnmRsRXv9v7RKTFU5CGMaH(Buttons buttons_0)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (((GamePadState)(ref _RYQYlBTtUaKPqglBPk0fi7hT7pr)).get_IsConnected() && ((GamePadState)(ref _QG4mFT06aDk75H8FavD2erQSaah)).get_IsConnected())
		{
			if (!((GamePadState)(ref _RYQYlBTtUaKPqglBPk0fi7hT7pr)).IsButtonUp(buttons_0))
			{
				return false;
			}
			return ((GamePadState)(ref _QG4mFT06aDk75H8FavD2erQSaah)).IsButtonDown(buttons_0);
		}
		return false;
	}

	public bool _fy5ebLnmRsRXv9v7RKTFU5CGMaH(_PMeRYZJaBCqgB9uADJFP3c14lxq _PMeRYZJaBCqgB9uADJFP3c14lxq_0)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Invalid comparison between Unknown and I4
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Invalid comparison between Unknown and I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Invalid comparison between Unknown and I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Invalid comparison between Unknown and I4
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Invalid comparison between Unknown and I4
		switch (_PMeRYZJaBCqgB9uADJFP3c14lxq_0)
		{
		default:
			return false;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton:
			if ((int)((MouseState)(ref _nL6AWNBZGcjH4ycaR2xzpUdcYpMA)).get_LeftButton() != 0)
			{
				return false;
			}
			return (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_LeftButton() == 1;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.MiddleButton:
			if ((int)((MouseState)(ref _nL6AWNBZGcjH4ycaR2xzpUdcYpMA)).get_MiddleButton() == 0)
			{
				return (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_MiddleButton() == 1;
			}
			return false;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.RightButton:
			if ((int)((MouseState)(ref _nL6AWNBZGcjH4ycaR2xzpUdcYpMA)).get_RightButton() != 0)
			{
				return false;
			}
			return (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_RightButton() == 1;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.WheelUp:
			return ((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_ScrollWheelValue() > ((MouseState)(ref _nL6AWNBZGcjH4ycaR2xzpUdcYpMA)).get_ScrollWheelValue();
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.WheelDown:
			return ((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_ScrollWheelValue() < ((MouseState)(ref _nL6AWNBZGcjH4ycaR2xzpUdcYpMA)).get_ScrollWheelValue();
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.XButton1:
			if ((int)((MouseState)(ref _nL6AWNBZGcjH4ycaR2xzpUdcYpMA)).get_XButton1() != 0)
			{
				return false;
			}
			return (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_XButton1() == 1;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.XButton2:
			if ((int)((MouseState)(ref _nL6AWNBZGcjH4ycaR2xzpUdcYpMA)).get_XButton2() == 0)
			{
				return (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_XButton2() == 1;
			}
			return false;
		}
	}

	public bool _KGCwEHf8akeXdkHLKFg1caFxXUJ(Keys keys_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		if ((int)((KeyboardState)(ref _JxAOrrJ4bqv0CaScbroMtsBP9vo)).get_Item(keys_0) == 1)
		{
			return (int)((KeyboardState)(ref _QyGrB1OudfOfivAikLqMIOfHz3L)).get_Item(keys_0) == 0;
		}
		return false;
	}

	public bool _KGCwEHf8akeXdkHLKFg1caFxXUJ(Buttons buttons_0)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (((GamePadState)(ref _RYQYlBTtUaKPqglBPk0fi7hT7pr)).get_IsConnected() && ((GamePadState)(ref _QG4mFT06aDk75H8FavD2erQSaah)).get_IsConnected())
		{
			if (!((GamePadState)(ref _RYQYlBTtUaKPqglBPk0fi7hT7pr)).IsButtonDown(buttons_0))
			{
				return false;
			}
			return ((GamePadState)(ref _QG4mFT06aDk75H8FavD2erQSaah)).IsButtonUp(buttons_0);
		}
		return false;
	}

	public bool _KGCwEHf8akeXdkHLKFg1caFxXUJ(_PMeRYZJaBCqgB9uADJFP3c14lxq _PMeRYZJaBCqgB9uADJFP3c14lxq_0)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Invalid comparison between Unknown and I4
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Invalid comparison between Unknown and I4
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Invalid comparison between Unknown and I4
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Invalid comparison between Unknown and I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Invalid comparison between Unknown and I4
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Invalid comparison between Unknown and I4
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Invalid comparison between Unknown and I4
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Invalid comparison between Unknown and I4
		switch (_PMeRYZJaBCqgB9uADJFP3c14lxq_0)
		{
		default:
			return false;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton:
			if ((int)((MouseState)(ref _nL6AWNBZGcjH4ycaR2xzpUdcYpMA)).get_LeftButton() == 1)
			{
				return (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_LeftButton() == 0;
			}
			return false;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.MiddleButton:
			if ((int)((MouseState)(ref _nL6AWNBZGcjH4ycaR2xzpUdcYpMA)).get_MiddleButton() != 1)
			{
				return false;
			}
			return (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_MiddleButton() == 0;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.RightButton:
			if ((int)((MouseState)(ref _nL6AWNBZGcjH4ycaR2xzpUdcYpMA)).get_RightButton() == 1)
			{
				return (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_RightButton() == 0;
			}
			return false;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.WheelUp:
			return ((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_ScrollWheelValue() > ((MouseState)(ref _nL6AWNBZGcjH4ycaR2xzpUdcYpMA)).get_ScrollWheelValue();
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.WheelDown:
			return ((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_ScrollWheelValue() < ((MouseState)(ref _nL6AWNBZGcjH4ycaR2xzpUdcYpMA)).get_ScrollWheelValue();
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.XButton1:
			if ((int)((MouseState)(ref _nL6AWNBZGcjH4ycaR2xzpUdcYpMA)).get_XButton1() == 1)
			{
				return (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_XButton1() == 0;
			}
			return false;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.XButton2:
			if ((int)((MouseState)(ref _nL6AWNBZGcjH4ycaR2xzpUdcYpMA)).get_XButton2() != 1)
			{
				return false;
			}
			return (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_XButton2() == 0;
		}
	}

	public bool _tiRsbEQbFPPjJoih0Y5DKxbGe52()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		if (((KeyboardState)(ref _QyGrB1OudfOfivAikLqMIOfHz3L)).GetPressedKeys().Length != 0)
		{
			return true;
		}
		Array values = Enum.GetValues(typeof(Buttons));
		foreach (Buttons item in values)
		{
			if (this._WZ4xYI5Q3hoCNX9QFzE3jfDwZBJ(item))
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
		Keys[] _qy4C18YJHEicy4hTkm6j5yaDlSV = ((KeyboardState)(ref _JxAOrrJ4bqv0CaScbroMtsBP9vo)).GetPressedKeys();
		Keys[] pressedKeys = ((KeyboardState)(ref _QyGrB1OudfOfivAikLqMIOfHz3L)).GetPressedKeys();
		return pressedKeys.Where((Keys keys_0) => _qy4C18YJHEicy4hTkm6j5yaDlSV.Contains(keys_0)).ToArray();
	}

	static IntPtr smethod_0(GameWindow gameWindow_0)
	{
		return gameWindow_0.get_Handle();
	}

	static void smethod_1(IntPtr intptr_0, SDL_bool sdl_bool_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		SDL.SDL_SetWindowGrab(intptr_0, sdl_bool_0);
	}

	static KeyboardState smethod_2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Keyboard.GetState();
	}

	static GamePadState smethod_3(PlayerIndex playerIndex_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return GamePad.GetState(playerIndex_0);
	}

	static MouseState smethod_4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Mouse.GetState();
	}
}
