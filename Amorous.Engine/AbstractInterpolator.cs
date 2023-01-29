using System;
using Microsoft.Xna.Framework;

public abstract class AbstractInterpolator<T>
{ // _RlrsL89bialFQa9mzWurgsdr6FK
	private T _value, _from, _to;
	private int _ticks;
	private Action _then;

	protected int Ticks { get; set; }

	public T State => _value;
	public bool IsAnimating => _ticks > 0;

	protected AbstractInterpolator()
	{
		Ticks = 750;
	}

	public void Update(GameTime gameTime)
	{
		if (_ticks <= 0)
		{
			return;
		}
		_ticks -= gameTime.ElapsedGameTime.Milliseconds;
		if (_ticks <= 0)
		{
			_ticks = 0;
			_value = _to;
			if (_then != null)
			{
				_then();
				_then = null;
			}
		}
		else
		{
			float interpolation = 1f - (float)_ticks / (float)Ticks;
			_value = Interpolate(_from, _to, interpolation);
		}
	}

	protected abstract T Interpolate(T value1, T value2, float interpolation);

	protected void To(T value, Action then)
	{
		if (_then != null)
		{
			Action action = _then;
			_then = null;
			action();
		}
		_from = _to;
		_to = value;
		_ticks = Ticks;
		_then = then;
	}

	protected void Set(T value)
	{
		if (_then != null)
		{
			Action action = _then;
			_then = null;
			action();
		}
		_to = value;
		_value = value;
		_ticks = 0;
		_then = null;
	}
}
