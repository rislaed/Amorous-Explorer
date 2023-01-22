using System;
using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class _yy7ao0ygzMkDh6MgDHs7gTimjsy : _5EDaN9V3lc2jRRTcL6GvzBbV7kU<DelayEventData>
{
	private int _Q7Kx7ErHf3u1QIUDKfFCKSXbznG;

	public int _F5UOCZEYoZ6vR0bYiGdjxZQ8tA { get; private set; }

	public _yy7ao0ygzMkDh6MgDHs7gTimjsy(_nR8eroJOHehP0ZGyyTveo6aMTHg _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
		: base(_nR8eroJOHehP0ZGyyTveo6aMTHg_0)
	{
	}

	public override void _dCiaLpIow7UQ0MLMp2O4J0yeVfF(DelayEventData delayEventData_0)
	{
		base._dCiaLpIow7UQ0MLMp2O4J0yeVfF(delayEventData_0);
		while (true)
		{
			int num = -1296631406;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDF669DEBu) % 3u)
				{
				case 1u:
					goto IL_0009;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0009:
				_F5UOCZEYoZ6vR0bYiGdjxZQ8tA = delayEventData_0._F5UOCZEYoZ6vR0bYiGdjxZQ8tA;
				num = (int)(num2 * 227918498) ^ -2126895489;
			}
		}
	}

	public override void _4hlxzMzKSbVTbZUrEsP3dfw4x0h()
	{
		base._4hlxzMzKSbVTbZUrEsP3dfw4x0h();
		_Q7Kx7ErHf3u1QIUDKfFCKSXbznG = _F5UOCZEYoZ6vR0bYiGdjxZQ8tA;
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime)
	{
		_Q7Kx7ErHf3u1QIUDKfFCKSXbznG -= _yy7ao0ygzMkDh6MgDHs7gTimjsy.smethod_0(gameTime).Milliseconds;
		while (true)
		{
			int num = 1312561234;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7164F127u) % 4u)
				{
				case 3u:
					base._xJZUPxDatEzfPQc0nRHR2D1Vwke = true;
					num = ((int)num2 * -1191193874) ^ 0x78B48789;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (_Q7Kx7ErHf3u1QIUDKfFCKSXbznG <= 0)
					{
						num3 = -1410820450;
						num4 = -1410820450;
					}
					else
					{
						num3 = -23753423;
						num4 = -23753423;
					}
					num = num3 ^ (int)(num2 * 1005735130);
					continue;
				}
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	static TimeSpan smethod_0(GameTime gameTime_0)
	{
		return gameTime_0.get_ElapsedGameTime();
	}
}
