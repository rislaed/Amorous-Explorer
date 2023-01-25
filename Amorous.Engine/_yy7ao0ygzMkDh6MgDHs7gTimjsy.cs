using System;
using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class _yy7ao0ygzMkDh6MgDHs7gTimjsy : AbstractEvent<DelayEventData>
{
	private int _Q7Kx7ErHf3u1QIUDKfFCKSXbznG;

	public int Delay { get; private set; }

	public _yy7ao0ygzMkDh6MgDHs7gTimjsy(_nR8eroJOHehP0ZGyyTveo6aMTHg _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
		: base(_nR8eroJOHehP0ZGyyTveo6aMTHg_0)
	{
	}

	public override void SetData(DelayEventData delayEventData_0)
	{
		base.SetData(delayEventData_0);
		Delay = delayEventData_0.Delay;
	}

	public override void _4hlxzMzKSbVTbZUrEsP3dfw4x0h()
	{
		base._4hlxzMzKSbVTbZUrEsP3dfw4x0h();
		_Q7Kx7ErHf3u1QIUDKfFCKSXbznG = Delay;
	}

	public override void Update(GameTime gameTime)
	{
		_Q7Kx7ErHf3u1QIUDKfFCKSXbznG -= gameTime.ElapsedGameTime.Milliseconds;
		if (_Q7Kx7ErHf3u1QIUDKfFCKSXbznG <= 0)
		{
			base._xJZUPxDatEzfPQc0nRHR2D1Vwke = true;
		}
	}
}
