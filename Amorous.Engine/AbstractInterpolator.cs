using System;
using Microsoft.Xna.Framework;

public abstract class AbstractInterpolator<T>
{ // _RlrsL89bialFQa9mzWurgsdr6FK
	private T value, from, to;
	private int ticks;
	private Action then;

	protected int Ticks { get; set; }

	public T Value => value;
	public bool IsAnimating => ticks > 0;

	protected AbstractInterpolator()
	{
		Ticks = 750;
	}

	public void Update(GameTime gameTime)
	{
		if (ticks <= 0)
		{
			return;
		}
		ticks -= gameTime.ElapsedGameTime.Milliseconds;
		if (ticks <= 0)
		{
			ticks = 0;
			value = to;
			if (then != null)
			{
				then();
				then = null;
			}
		}
		else
		{
			float amount = 1f - (float)ticks / (float)Ticks;
			value = Interpolate(from, to, amount);
		}
	}

	protected abstract T Interpolate(T value1, T value2, float amount);

	protected void Begin(T value, Action then)
	{
		if (this.then != null)
		{
			Action action = this.then;
			this.then = null;
			action();
		}
		from = to;
		to = value;
		ticks = Ticks;
		this.then = then;
	}

	protected void End(T value)
	{
		if (then != null)
		{
			Action action = then;
			then = null;
			action();
		}
		to = value;
		this.value = value;
		ticks = 0;
		then = null;
	}
}
