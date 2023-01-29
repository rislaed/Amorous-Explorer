using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class PlaySexsceneEvent : AbstractEvent<PlaySexsceneEventData>
{ // _noCtOrWje2WCEbkCre6cfHiMXh5
	public string SceneName { get; private set; }

	public PlaySexsceneEvent(Cutscene cutscene)
		: base(cutscene) {}

	public override void SetData(PlaySexsceneEventData eventData)
	{
		base.SetData(eventData);
		SceneName = eventData.SceneName;
	}

	public override void Start()
	{
		base.Start();
		base.Cutscene.Game.PlaySexscene(SceneName);
	}

	public override void Update(GameTime gameTime)
	{
		base.Completable = true;
	}
}
