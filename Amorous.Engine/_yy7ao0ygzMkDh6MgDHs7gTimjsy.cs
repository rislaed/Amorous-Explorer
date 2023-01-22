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
		_F5UOCZEYoZ6vR0bYiGdjxZQ8tA = delayEventData_0._F5UOCZEYoZ6vR0bYiGdjxZQ8tA;
	}

	public override void _4hlxzMzKSbVTbZUrEsP3dfw4x0h()
	{
		base._4hlxzMzKSbVTbZUrEsP3dfw4x0h();
		_Q7Kx7ErHf3u1QIUDKfFCKSXbznG = _F5UOCZEYoZ6vR0bYiGdjxZQ8tA;
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime)
	{
		_Q7Kx7ErHf3u1QIUDKfFCKSXbznG -= gameTime.get_ElapsedGameTime().Milliseconds;
		if (_Q7Kx7ErHf3u1QIUDKfFCKSXbznG <= 0)
		{
			base._xJZUPxDatEzfPQc0nRHR2D1Vwke = true;
		}
	}

	static TimeSpan smethod_0(GameTime gameTime_0)
	{
		return gameTime_0.get_ElapsedGameTime();
	}
}
