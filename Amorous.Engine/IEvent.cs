using Microsoft.Xna.Framework;

public interface IEvent
{
	bool Completable { get; }
	int ID { get; }
	int NextID { get; }
	void Begin();
	bool Next();
	void SetData(EventData eventData);
	void Update(GameTime gameTime);
}
