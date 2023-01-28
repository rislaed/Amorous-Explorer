using Microsoft.Xna.Framework;

public abstract class AbstractEvent<T> : IEvent where T : EventData
{
	public Cutscene Cutscene { get; private set; }
	public bool Completable { get; protected set; }
	public int ID { get; private set; }
	public int NextID { get; protected set; }

	protected AbstractEvent(Cutscene cutscene)
	{
		Cutscene = cutscene;
	}

	public virtual void Begin()
	{
		Completable = false;
	}

	public virtual bool Next()
	{
		return false;
	}

	public void SetData(EventData EventData_0)
	{
		SetData((T)EventData_0);
	}

	public virtual void SetData(T eventData)
	{
		ID = eventData.ID;
		NextID = eventData.NextID;
	}

	public abstract void Update(GameTime gameTime);
}
