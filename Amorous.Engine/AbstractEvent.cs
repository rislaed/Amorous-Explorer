using Microsoft.Xna.Framework;

public abstract class AbstractEvent<T> : IEvent where T : EventData
{
	public _nR8eroJOHehP0ZGyyTveo6aMTHg _5zNdOw7qHmuCAPJFMr3SsZdBlCr { get; private set; }

	public bool _xJZUPxDatEzfPQc0nRHR2D1Vwke { get; protected set; }

	public int ID { get; private set; }

	public int NextID { get; protected set; }

	protected AbstractEvent(_nR8eroJOHehP0ZGyyTveo6aMTHg _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
	{
		_5zNdOw7qHmuCAPJFMr3SsZdBlCr = _nR8eroJOHehP0ZGyyTveo6aMTHg_0;
	}

	public virtual void StopCutscene()
	{
		_xJZUPxDatEzfPQc0nRHR2D1Vwke = false;
	}

	public virtual bool _NeIQsy78kWqF9jXLl8vb2lOyZgO()
	{
		return false;
	}

	public void SetData(EventData EventData_0)
	{
		SetData((T)EventData_0);
	}

	public virtual void SetData(T gparam_0)
	{
		ID = gparam_0.ID;
		NextID = gparam_0.NextID;
	}

	public abstract void Update(GameTime gameTime);
}
