using Microsoft.Xna.Framework;

public abstract class AbstractEvent<T> : IEvent where T : EventData
{ // _5EDaN9V3lc2jRRTcL6GvzBbV7kU
	public Cutscene Cutscene { get; private set; }
	public bool IsCompleted { get; protected set; }
	public int ID { get; private set; }
	public int NextID { get; protected set; }

	protected AbstractEvent(Cutscene cutscene)
	{
		Cutscene = cutscene;
	}

	public virtual void Start()
	{
		IsCompleted = false;
	}

	public virtual bool Next()
	{
		return false;
	}

	public void SetData(EventData eventData)
	{
		SetData((T)eventData);
	}

	public virtual void SetData(T eventData)
	{
		ID = eventData.ID;
		NextID = eventData.NextID;
	}

	public abstract void Update(GameTime gameTime);
}
