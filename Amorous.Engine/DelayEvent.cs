using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class DelayEvent : AbstractEvent<DelayEventData>
{ // _yy7ao0ygzMkDh6MgDHs7gTimjsy
	private int ticks;

	public int Delay { get; private set; }

	public DelayEvent(Cutscene cutscene) : base(cutscene) {}

	public override void SetData(DelayEventData eventData)
	{
		base.SetData(eventData);
		Delay = eventData.Delay;
	}

	public override void Start()
	{
		base.Start();
		ticks = Delay;
	}

	public override void Update(GameTime gameTime)
	{
		ticks -= gameTime.ElapsedGameTime.Milliseconds;
		if (ticks <= 0)
		{
			base.IsCompleted = true;
		}
	}
}
