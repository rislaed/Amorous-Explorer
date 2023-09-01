using Microsoft.Xna.Framework;
using Newtonsoft.Json;

namespace Amorous.Explorer.Reflection;

public class StubEventData : EventData
{
	[JsonProperty("Completable")]
	public bool Completable { get; set; }
}

public class StubEvent : AbstractEvent<StubEventData>
{
	public StubEvent(Cutscene cutscene) : base(cutscene) {}

	public override void SetData(StubEventData eventData)
	{
		base.SetData(eventData);
		IsCompleted = eventData.Completable;
	}

	public override void Update(GameTime gameTime) {}
}
