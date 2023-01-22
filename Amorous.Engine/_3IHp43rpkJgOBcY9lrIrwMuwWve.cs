using System;
using System.Reflection;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class _3IHp43rpkJgOBcY9lrIrwMuwWve : _ujAkjlfN5TywwbLAUDzPvtab6uJ
{
	public const string _tyk6ubAYksgThinoaE8CE4cUqSC = "NPCLayer_";

	public _QGGOTxZ8aNWGh0hc26wcmx8wmwT _4QLHHCk23T1BjK7acKxASbkCefG;

	public _a2qVgWDIm3fBp49WubttSTPsx8K _dPmC8tBC0iph2YBAFmztEsmwUdSA;

	private _nR8eroJOHehP0ZGyyTveo6aMTHg _sVephzY32oTa3X109UReGPT9rd;

	private Action _U1ntvSBQ11Vut0Wd1Vmb115ghn;

	public Action _64JjsghBPDjZ1OxZwhO8Y6dFE5t
	{
		set
		{
			_U1ntvSBQ11Vut0Wd1Vmb115ghn = value;
			while (true)
			{
				int num = -699317391;
				while (true)
				{
					uint num2;
					Action u1ntvSBQ11Vut0Wd1Vmb115ghn;
					switch ((num2 = (uint)num ^ 0xC6AB6E8Fu) % 3u)
					{
					case 1u:
						u1ntvSBQ11Vut0Wd1Vmb115ghn = _U1ntvSBQ11Vut0Wd1Vmb115ghn;
						if (u1ntvSBQ11Vut0Wd1Vmb115ghn != null)
						{
							goto IL_0012;
						}
						return;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
					IL_0012:
					u1ntvSBQ11Vut0Wd1Vmb115ghn();
					num = (int)((num2 * 273964742) ^ 0x545185CD);
				}
			}
		}
	}

	public _3IHp43rpkJgOBcY9lrIrwMuwWve(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, _QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, _a2qVgWDIm3fBp49WubttSTPsx8K _a2qVgWDIm3fBp49WubttSTPsx8K_0)
		: base(_7UlnfykmEmZDFt3BmCKZekI43Ih_0, _3IHp43rpkJgOBcY9lrIrwMuwWve.smethod_2(_003CModule_003E.smethod_25<string>(3462321915u), _3IHp43rpkJgOBcY9lrIrwMuwWve.smethod_1((MemberInfo)_3IHp43rpkJgOBcY9lrIrwMuwWve.smethod_0((object)_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0))))
	{
		_4QLHHCk23T1BjK7acKxASbkCefG = _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0;
		_dPmC8tBC0iph2YBAFmztEsmwUdSA = _a2qVgWDIm3fBp49WubttSTPsx8K_0;
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		if (_U1ntvSBQ11Vut0Wd1Vmb115ghn != null)
		{
			while (true)
			{
				int num = -1412661631;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD1ED3BF0u) % 6u)
					{
					case 5u:
					{
						int num5;
						int num6;
						if (base._XbOXR6AypLIdJ3gBMGseGi3Wi2i._ZzBuoSDMWwerejOO9Goyv2OCKgE._5zNdOw7qHmuCAPJFMr3SsZdBlCr == null)
						{
							num5 = 1433699573;
							num6 = 1433699573;
						}
						else
						{
							num5 = 1084176074;
							num6 = 1084176074;
						}
						num = num5 ^ ((int)num2 * -647893195);
						continue;
					}
					case 3u:
						_sVephzY32oTa3X109UReGPT9rd = base._XbOXR6AypLIdJ3gBMGseGi3Wi2i._ZzBuoSDMWwerejOO9Goyv2OCKgE._5zNdOw7qHmuCAPJFMr3SsZdBlCr;
						num = -63506844;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (_sVephzY32oTa3X109UReGPT9rd != null)
						{
							num3 = -998817942;
							num4 = -998817942;
						}
						else
						{
							num3 = -496946356;
							num4 = -496946356;
						}
						num = num3 ^ (int)(num2 * 1983647607);
						continue;
					}
					case 0u:
						_U1ntvSBQ11Vut0Wd1Vmb115ghn();
						num = ((int)num2 * -1920484845) ^ 0x4C336987;
						continue;
					case 4u:
						break;
					default:
						goto end_IL_00ca;
					}
					break;
				}
				continue;
				end_IL_00ca:
				break;
			}
		}
		_4QLHHCk23T1BjK7acKxASbkCefG._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
	}

	public override void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0)
	{
	}

	static Type smethod_0(object object_0)
	{
		return object_0.GetType();
	}

	static string smethod_1(MemberInfo memberInfo_0)
	{
		return memberInfo_0.Name;
	}

	static string smethod_2(string string_0, string string_1)
	{
		return string_0 + string_1;
	}
}
