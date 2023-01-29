using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class DelayEvent : AbstractEvent<DelayEventData>
{ // _yy7ao0ygzMkDh6MgDHs7gTimjsy
	private int _stopwatch;

	public int Delay { get; private set; }

	public DelayEvent(Cutscene cutscene)
		: base(cutscene) {}

	public override void SetData(DelayEventData eventData)
	{
		base.SetData(eventData);
		Delay = eventData.Delay;
	}

	public override void Begin()
	{
		base.Begin();
		_stopwatch = Delay;
	}

	public override void Update(GameTime gameTime)
	{
		_stopwatch -= gameTime.ElapsedGameTime.Milliseconds;
		if (_stopwatch <= 0)
		{
			base.Completable = true;
		}
	}
}
