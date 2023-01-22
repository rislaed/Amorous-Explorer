using System;
using System.Collections;
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
		while (true)
		{
			int num = -1237081213;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9EEBADB9u) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0008:
				_4L7hfXrWoDdArQiscG4ukHCV46B = _JbeCmOie0phb2cbgG6DdGZrbs3pB_0;
				num = (int)(num2 * 1079525099) ^ -899934513;
			}
		}
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
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		_JxAOrrJ4bqv0CaScbroMtsBP9vo = _QyGrB1OudfOfivAikLqMIOfHz3L;
		_QyGrB1OudfOfivAikLqMIOfHz3L = _3FFZvGWTAe7rsviKkDPTXEVjxWf.smethod_2();
		_RYQYlBTtUaKPqglBPk0fi7hT7pr = _QG4mFT06aDk75H8FavD2erQSaah;
		_QG4mFT06aDk75H8FavD2erQSaah = _3FFZvGWTAe7rsviKkDPTXEVjxWf.smethod_3((PlayerIndex)0);
		_nL6AWNBZGcjH4ycaR2xzpUdcYpMA = _N9dtCLxcbyjVo7hRyMVQzD7exaM;
		while (true)
		{
			int num = 1868765131;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9A280ECu) % 4u)
				{
				case 3u:
					_N9dtCLxcbyjVo7hRyMVQzD7exaM = _3FFZvGWTAe7rsviKkDPTXEVjxWf.smethod_4();
					_z4wENYBCooFsUzGd3jpaiN6UNNL.X = Math.Max(0, Math.Min(((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_X(), _4L7hfXrWoDdArQiscG4ukHCV46B._vsceSzSIjBy2nZrCxAzKZbUiwLq._ssaTWDF5CYtQ9fGbLNtaLrgFtvJ));
					_z4wENYBCooFsUzGd3jpaiN6UNNL.Y = Math.Max(0, Math.Min(((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_Y(), _4L7hfXrWoDdArQiscG4ukHCV46B._vsceSzSIjBy2nZrCxAzKZbUiwLq._EM2dYeybqjLlS6bODr1k9TxIRZU));
					num = ((int)num2 * -748798455) ^ 0x7FC5B9B1;
					continue;
				case 2u:
					_bN58s8paKnVuWr3UMJsZkvbV9WA.X = (int)_z4wENYBCooFsUzGd3jpaiN6UNNL.X;
					_bN58s8paKnVuWr3UMJsZkvbV9WA.Y = (int)_z4wENYBCooFsUzGd3jpaiN6UNNL.Y;
					num = (int)(num2 * 1695012501) ^ -744821949;
					continue;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
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
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Invalid comparison between Unknown and I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Invalid comparison between Unknown and I4
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Invalid comparison between Unknown and I4
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Invalid comparison between Unknown and I4
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Invalid comparison between Unknown and I4
		switch (_PMeRYZJaBCqgB9uADJFP3c14lxq_0)
		{
		default:
			while (true)
			{
				int num = 937355302;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x14A07425u) % 10u)
					{
					case 5u:
						num = (int)(num2 * 1684890923) ^ -409223609;
						continue;
					case 9u:
						break;
					default:
						return false;
					case 4u:
						goto end_IL_006b;
					case 2u:
						goto IL_0083;
					case 0u:
						goto IL_0092;
					case 7u:
						goto IL_00a1;
					case 6u:
						goto IL_00ba;
					case 1u:
						goto IL_00d3;
					case 8u:
						goto end_IL_0001;
					}
					break;
				}
				continue;
				end_IL_006b:
				break;
			}
			goto case _PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton:
			return (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_LeftButton() == 1;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.MiddleButton:
			goto IL_0083;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.RightButton:
			goto IL_0092;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.WheelUp:
			goto IL_00a1;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.WheelDown:
			goto IL_00ba;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.XButton1:
			goto IL_00d3;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.XButton2:
			break;
			IL_00d3:
			return (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_XButton1() == 1;
			IL_00ba:
			return ((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_ScrollWheelValue() < ((MouseState)(ref _nL6AWNBZGcjH4ycaR2xzpUdcYpMA)).get_ScrollWheelValue();
			IL_00a1:
			return ((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_ScrollWheelValue() > ((MouseState)(ref _nL6AWNBZGcjH4ycaR2xzpUdcYpMA)).get_ScrollWheelValue();
			IL_0092:
			return (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_RightButton() == 1;
			IL_0083:
			return (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_MiddleButton() == 1;
			end_IL_0001:
			break;
		}
		return (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_XButton2() == 1;
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
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Invalid comparison between Unknown and I4
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Invalid comparison between Unknown and I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Invalid comparison between Unknown and I4
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Invalid comparison between Unknown and I4
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Invalid comparison between Unknown and I4
		switch (_PMeRYZJaBCqgB9uADJFP3c14lxq_0)
		{
		default:
			while (true)
			{
				int num = 1731614036;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5195EDFAu) % 9u)
					{
					case 8u:
						num = ((int)num2 * -483478046) ^ 0x6FD61A42;
						continue;
					case 7u:
						break;
					default:
						return true;
					case 3u:
						goto end_IL_0067;
					case 6u:
						goto IL_007f;
					case 1u:
						goto IL_008e;
					case 2u:
						goto IL_009d;
					case 4u:
						goto IL_00b8;
					case 0u:
						goto end_IL_0001;
					}
					break;
				}
				continue;
				end_IL_0067:
				break;
			}
			goto case _PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton:
			return (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_LeftButton() == 0;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.MiddleButton:
			goto IL_007f;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.RightButton:
			goto IL_008e;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.WheelUp:
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.WheelDown:
			goto IL_009d;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.XButton1:
			goto IL_00b8;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.XButton2:
			break;
			IL_00b8:
			return (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_XButton1() == 0;
			IL_009d:
			return ((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_ScrollWheelValue() - ((MouseState)(ref _nL6AWNBZGcjH4ycaR2xzpUdcYpMA)).get_ScrollWheelValue() == 0;
			IL_008e:
			return (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_RightButton() == 0;
			IL_007f:
			return (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_MiddleButton() == 0;
			end_IL_0001:
			break;
		}
		return (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_XButton2() == 0;
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
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		if (((GamePadState)(ref _RYQYlBTtUaKPqglBPk0fi7hT7pr)).get_IsConnected())
		{
			while (true)
			{
				int num = -2112288972;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD530EB1Au) % 6u)
					{
					case 2u:
					{
						int num5;
						int num6;
						if (!((GamePadState)(ref _QG4mFT06aDk75H8FavD2erQSaah)).get_IsConnected())
						{
							num5 = -1061565083;
							num6 = -1061565083;
						}
						else
						{
							num5 = -2146368915;
							num6 = -2146368915;
						}
						num = num5 ^ (int)(num2 * 2124652188);
						continue;
					}
					case 1u:
					{
						int num3;
						int num4;
						if (!((GamePadState)(ref _RYQYlBTtUaKPqglBPk0fi7hT7pr)).IsButtonUp(buttons_0))
						{
							num3 = -705366346;
							num4 = -705366346;
						}
						else
						{
							num3 = -1860732423;
							num4 = -1860732423;
						}
						num = num3 ^ ((int)num2 * -1884314127);
						continue;
					}
					case 4u:
						break;
					case 0u:
						return ((GamePadState)(ref _QG4mFT06aDk75H8FavD2erQSaah)).IsButtonDown(buttons_0);
					case 5u:
						return false;
					default:
						goto end_IL_0099;
					}
					break;
				}
				continue;
				end_IL_0099:
				break;
			}
		}
		return false;
	}

	public bool _fy5ebLnmRsRXv9v7RKTFU5CGMaH(_PMeRYZJaBCqgB9uADJFP3c14lxq _PMeRYZJaBCqgB9uADJFP3c14lxq_0)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Invalid comparison between Unknown and I4
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Invalid comparison between Unknown and I4
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Invalid comparison between Unknown and I4
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Invalid comparison between Unknown and I4
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Invalid comparison between Unknown and I4
		int num;
		int num3;
		int num5;
		int num6;
		int num7;
		switch (_PMeRYZJaBCqgB9uADJFP3c14lxq_0)
		{
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.MiddleButton:
		{
			int num2;
			if ((int)((MouseState)(ref _nL6AWNBZGcjH4ycaR2xzpUdcYpMA)).get_MiddleButton() == 0)
			{
				num = 487959406;
				num2 = 487959406;
			}
			else
			{
				num = 985421773;
				num2 = 985421773;
			}
			goto IL_00e3;
		}
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.RightButton:
			goto IL_005d;
		default:
			goto IL_0092;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.XButton1:
			goto IL_0099;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton:
			goto IL_00bf;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.XButton2:
			goto IL_0154;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.WheelDown:
			goto IL_0199;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.WheelUp:
			break;
			IL_00bf:
			if ((int)((MouseState)(ref _nL6AWNBZGcjH4ycaR2xzpUdcYpMA)).get_LeftButton() != 0)
			{
				num = 19293586;
				num3 = 19293586;
			}
			else
			{
				num = 458730033;
				num3 = 458730033;
			}
			goto IL_00e3;
			IL_0092:
			num = 998891604;
			goto IL_00e3;
			IL_00e3:
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)num ^ 0x78125725u) % 20u)
				{
				case 18u:
					break;
				case 17u:
					goto IL_005d;
				case 13u:
					num = ((int)num4 * -943699684) ^ 0xB23C328;
					continue;
				case 8u:
					goto IL_0092;
				case 2u:
					goto IL_0099;
				case 1u:
					goto IL_00bf;
				case 10u:
					goto IL_0154;
				case 0u:
					return false;
				case 3u:
					return false;
				case 4u:
					return (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_RightButton() == 1;
				default:
					return false;
				case 6u:
					return (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_XButton1() == 1;
				case 7u:
					return (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_XButton2() == 1;
				case 9u:
					goto IL_0199;
				case 11u:
					return false;
				case 12u:
					return false;
				case 14u:
					return false;
				case 15u:
					return (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_MiddleButton() == 1;
				case 16u:
					return (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_LeftButton() == 1;
				case 19u:
					goto end_IL_0001;
				}
				break;
			}
			goto case _PMeRYZJaBCqgB9uADJFP3c14lxq.MiddleButton;
			IL_0199:
			return ((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_ScrollWheelValue() < ((MouseState)(ref _nL6AWNBZGcjH4ycaR2xzpUdcYpMA)).get_ScrollWheelValue();
			IL_0154:
			if ((int)((MouseState)(ref _nL6AWNBZGcjH4ycaR2xzpUdcYpMA)).get_XButton2() != 0)
			{
				num = 854593463;
				num5 = 854593463;
			}
			else
			{
				num = 673591246;
				num5 = 673591246;
			}
			goto IL_00e3;
			IL_005d:
			if ((int)((MouseState)(ref _nL6AWNBZGcjH4ycaR2xzpUdcYpMA)).get_RightButton() != 0)
			{
				num = 2092088313;
				num6 = 2092088313;
			}
			else
			{
				num = 2011643481;
				num6 = 2011643481;
			}
			goto IL_00e3;
			IL_0099:
			if ((int)((MouseState)(ref _nL6AWNBZGcjH4ycaR2xzpUdcYpMA)).get_XButton1() != 0)
			{
				num = 491597262;
				num7 = 491597262;
			}
			else
			{
				num = 268119947;
				num7 = 268119947;
			}
			goto IL_00e3;
			end_IL_0001:
			break;
		}
		return ((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_ScrollWheelValue() > ((MouseState)(ref _nL6AWNBZGcjH4ycaR2xzpUdcYpMA)).get_ScrollWheelValue();
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
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		if (((GamePadState)(ref _RYQYlBTtUaKPqglBPk0fi7hT7pr)).get_IsConnected())
		{
			while (true)
			{
				int num = -539512632;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDAE8D3C3u) % 6u)
					{
					case 2u:
					{
						int num5;
						int num6;
						if (!((GamePadState)(ref _RYQYlBTtUaKPqglBPk0fi7hT7pr)).IsButtonDown(buttons_0))
						{
							num5 = -1545797780;
							num6 = -1545797780;
						}
						else
						{
							num5 = -1464133733;
							num6 = -1464133733;
						}
						num = num5 ^ ((int)num2 * -1511065388);
						continue;
					}
					case 1u:
					{
						int num3;
						int num4;
						if (((GamePadState)(ref _QG4mFT06aDk75H8FavD2erQSaah)).get_IsConnected())
						{
							num3 = -930013285;
							num4 = -930013285;
						}
						else
						{
							num3 = -240550149;
							num4 = -240550149;
						}
						num = num3 ^ (int)(num2 * 979198584);
						continue;
					}
					case 3u:
						break;
					case 0u:
						return ((GamePadState)(ref _QG4mFT06aDk75H8FavD2erQSaah)).IsButtonUp(buttons_0);
					case 5u:
						return false;
					default:
						goto end_IL_0099;
					}
					break;
				}
				continue;
				end_IL_0099:
				break;
			}
		}
		return false;
	}

	public bool _KGCwEHf8akeXdkHLKFg1caFxXUJ(_PMeRYZJaBCqgB9uADJFP3c14lxq _PMeRYZJaBCqgB9uADJFP3c14lxq_0)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Invalid comparison between Unknown and I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Invalid comparison between Unknown and I4
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Invalid comparison between Unknown and I4
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Invalid comparison between Unknown and I4
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Invalid comparison between Unknown and I4
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Invalid comparison between Unknown and I4
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Invalid comparison between Unknown and I4
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Invalid comparison between Unknown and I4
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Invalid comparison between Unknown and I4
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Invalid comparison between Unknown and I4
		int num;
		int num3;
		int num5;
		int num6;
		int num7;
		switch (_PMeRYZJaBCqgB9uADJFP3c14lxq_0)
		{
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.XButton1:
		{
			int num2;
			if ((int)((MouseState)(ref _nL6AWNBZGcjH4ycaR2xzpUdcYpMA)).get_XButton1() == 1)
			{
				num = 1535124893;
				num2 = 1535124893;
			}
			else
			{
				num = 155950833;
				num2 = 155950833;
			}
			goto IL_00e7;
		}
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.RightButton:
			goto IL_006d;
		default:
			goto IL_0094;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.MiddleButton:
			goto IL_009b;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton:
			goto IL_00c2;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.XButton2:
			goto IL_0158;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.WheelUp:
			goto IL_018d;
		case _PMeRYZJaBCqgB9uADJFP3c14lxq.WheelDown:
			break;
			IL_00c2:
			if ((int)((MouseState)(ref _nL6AWNBZGcjH4ycaR2xzpUdcYpMA)).get_LeftButton() == 1)
			{
				num = 1180721134;
				num3 = 1180721134;
			}
			else
			{
				num = 673116822;
				num3 = 673116822;
			}
			goto IL_00e7;
			IL_0094:
			num = 1262678307;
			goto IL_00e7;
			IL_00e7:
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)num ^ 0x10F81DA3u) % 20u)
				{
				case 16u:
					num = (int)((num4 * 97863466) ^ 0x2A183076);
					continue;
				case 14u:
					break;
				case 12u:
					goto IL_006d;
				case 4u:
					goto IL_0094;
				case 3u:
					goto IL_009b;
				case 0u:
					goto IL_00c2;
				case 5u:
					goto IL_0158;
				case 1u:
					return (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_LeftButton() == 0;
				case 2u:
					return false;
				case 6u:
					return false;
				case 7u:
					return (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_RightButton() == 0;
				case 8u:
					goto IL_018d;
				default:
					return false;
				case 10u:
					return false;
				case 11u:
					goto end_IL_0001;
				case 13u:
					return false;
				case 15u:
					return (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_XButton2() == 0;
				case 17u:
					return (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_MiddleButton() == 0;
				case 18u:
					return (int)((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_XButton1() == 0;
				case 19u:
					return false;
				}
				break;
			}
			goto case _PMeRYZJaBCqgB9uADJFP3c14lxq.XButton1;
			IL_018d:
			return ((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_ScrollWheelValue() > ((MouseState)(ref _nL6AWNBZGcjH4ycaR2xzpUdcYpMA)).get_ScrollWheelValue();
			IL_0158:
			if ((int)((MouseState)(ref _nL6AWNBZGcjH4ycaR2xzpUdcYpMA)).get_XButton2() == 1)
			{
				num = 317426584;
				num5 = 317426584;
			}
			else
			{
				num = 437049284;
				num5 = 437049284;
			}
			goto IL_00e7;
			IL_006d:
			if ((int)((MouseState)(ref _nL6AWNBZGcjH4ycaR2xzpUdcYpMA)).get_RightButton() == 1)
			{
				num = 2105561116;
				num6 = 2105561116;
			}
			else
			{
				num = 214713485;
				num6 = 214713485;
			}
			goto IL_00e7;
			IL_009b:
			if ((int)((MouseState)(ref _nL6AWNBZGcjH4ycaR2xzpUdcYpMA)).get_MiddleButton() != 1)
			{
				num = 1902699957;
				num7 = 1902699957;
			}
			else
			{
				num = 1071389202;
				num7 = 1071389202;
			}
			goto IL_00e7;
			end_IL_0001:
			break;
		}
		return ((MouseState)(ref _N9dtCLxcbyjVo7hRyMVQzD7exaM)).get_ScrollWheelValue() < ((MouseState)(ref _nL6AWNBZGcjH4ycaR2xzpUdcYpMA)).get_ScrollWheelValue();
	}

	public bool _tiRsbEQbFPPjJoih0Y5DKxbGe52()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		if (((KeyboardState)(ref _QyGrB1OudfOfivAikLqMIOfHz3L)).GetPressedKeys().Length != 0)
		{
			uint num = 433084517u;
			return true;
		}
		Array values = Enum.GetValues(typeof(Buttons));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			bool result = default(bool);
			while (true)
			{
				IL_00bd:
				int num2;
				int num3;
				if (enumerator.MoveNext())
				{
					num2 = -2025854983;
					num3 = -2025854983;
				}
				else
				{
					num2 = -2073942352;
					num3 = -2073942352;
				}
				while (true)
				{
					uint num;
					switch ((num = (uint)num2 ^ 0xAAB81D68u) % 6u)
					{
					case 5u:
					{
						Buttons buttons_ = (Buttons)enumerator.Current;
						int num4;
						if (_WZ4xYI5Q3hoCNX9QFzE3jfDwZBJ(buttons_))
						{
							num2 = -1301784179;
							num4 = -1301784179;
						}
						else
						{
							num2 = -1598382695;
							num4 = -1598382695;
						}
						continue;
					}
					case 4u:
						num2 = -2025854983;
						continue;
					case 1u:
						result = true;
						num2 = ((int)num * -1797143583) ^ -1640198215;
						continue;
					default:
						goto end_IL_0087;
					case 3u:
						break;
					case 2u:
						goto end_IL_0087;
					case 0u:
						return result;
					}
					goto IL_00bd;
					continue;
					end_IL_0087:
					break;
				}
				break;
			}
		}
		finally
		{
			IDisposable disposable = enumerator as IDisposable;
			while (true)
			{
				IL_0138:
				int num5 = -1854540919;
				while (true)
				{
					uint num;
					switch ((num = (uint)num5 ^ 0xAAB81D68u) % 4u)
					{
					case 1u:
					{
						int num6;
						int num7;
						if (disposable != null)
						{
							num6 = 1739271602;
							num7 = 1739271602;
						}
						else
						{
							num6 = 1358883756;
							num7 = 1358883756;
						}
						num5 = num6 ^ ((int)num * -2101793106);
						continue;
					}
					case 0u:
						disposable.Dispose();
						num5 = (int)((num * 1553665500) ^ 0x460C89F2);
						continue;
					default:
						goto end_IL_0116;
					case 3u:
						break;
					case 2u:
						goto end_IL_0116;
					}
					goto IL_0138;
					continue;
					end_IL_0116:
					break;
				}
				break;
			}
		}
		Array values2 = Enum.GetValues(typeof(_PMeRYZJaBCqgB9uADJFP3c14lxq));
		IEnumerator enumerator2 = values2.GetEnumerator();
		try
		{
			_PMeRYZJaBCqgB9uADJFP3c14lxq pMeRYZJaBCqgB9uADJFP3c14lxq_ = default(_PMeRYZJaBCqgB9uADJFP3c14lxq);
			while (true)
			{
				IL_01e7:
				int num8;
				int num9;
				if (enumerator2.MoveNext())
				{
					num8 = -1299887729;
					num9 = -1299887729;
				}
				else
				{
					num8 = -1075925815;
					num9 = -1075925815;
				}
				while (true)
				{
					uint num;
					switch ((num = (uint)num8 ^ 0xAAB81D68u) % 6u)
					{
					case 2u:
					{
						int num10;
						int num11;
						if (!_WZ4xYI5Q3hoCNX9QFzE3jfDwZBJ(pMeRYZJaBCqgB9uADJFP3c14lxq_))
						{
							num10 = -479364459;
							num11 = -479364459;
						}
						else
						{
							num10 = -301544906;
							num11 = -301544906;
						}
						num8 = num10 ^ ((int)num * -538131643);
						continue;
					}
					case 1u:
						pMeRYZJaBCqgB9uADJFP3c14lxq_ = (_PMeRYZJaBCqgB9uADJFP3c14lxq)enumerator2.Current;
						num8 = -1112643972;
						continue;
					case 0u:
						num8 = -1299887729;
						continue;
					default:
						goto end_IL_01b1;
					case 3u:
						break;
					case 4u:
						return true;
					case 5u:
						goto end_IL_01b1;
					}
					goto IL_01e7;
					continue;
					end_IL_01b1:
					break;
				}
				break;
			}
		}
		finally
		{
			IDisposable disposable = enumerator2 as IDisposable;
			while (true)
			{
				IL_0264:
				int num12 = -2088750139;
				while (true)
				{
					uint num;
					switch ((num = (uint)num12 ^ 0xAAB81D68u) % 4u)
					{
					case 2u:
						disposable.Dispose();
						num12 = ((int)num * -1286298890) ^ 0x1EBD1858;
						continue;
					case 1u:
					{
						int num13;
						int num14;
						if (disposable != null)
						{
							num13 = 52420483;
							num14 = 52420483;
						}
						else
						{
							num13 = 314642757;
							num14 = 314642757;
						}
						num12 = num13 ^ ((int)num * -81327003);
						continue;
					}
					default:
						goto end_IL_0242;
					case 3u:
						break;
					case 0u:
						goto end_IL_0242;
					}
					goto IL_0264;
					continue;
					end_IL_0242:
					break;
				}
				break;
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
