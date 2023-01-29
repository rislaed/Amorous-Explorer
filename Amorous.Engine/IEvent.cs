using Microsoft.Xna.Framework;

public interface IEvent
{ // _UuyKVad9AT7C3U33zYrtkLcKlQI
	bool Completable { get; }
	int ID { get; }
	int NextID { get; }
	void Begin();
	bool Next();
	void SetData(EventData eventData);
	void Update(GameTime gameTime);
}
