using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class _noCtOrWje2WCEbkCre6cfHiMXh5 : AbstractEvent<PlaySexsceneEventData>
{
	public string SceneName { get; private set; }

	public _noCtOrWje2WCEbkCre6cfHiMXh5(Cutscene _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
		: base(_nR8eroJOHehP0ZGyyTveo6aMTHg_0)
	{
	}

	public override void SetData(PlaySexsceneEventData eventData)
	{
		base.SetData(eventData);
		SceneName = eventData.SceneName;
	}

	public override void Begin()
	{
		base.Begin();
		base.Cutscene.Game.StartSexscene(SceneName);
	}

	public override void Update(GameTime gameTime)
	{
		base.Completable = true;
	}
}
