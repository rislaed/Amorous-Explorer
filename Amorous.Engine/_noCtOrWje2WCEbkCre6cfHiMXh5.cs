using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class _noCtOrWje2WCEbkCre6cfHiMXh5 : AbstractEvent<PlaySexsceneEventData>
{
	public string SceneName { get; private set; }

	public _noCtOrWje2WCEbkCre6cfHiMXh5(_nR8eroJOHehP0ZGyyTveo6aMTHg _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
		: base(_nR8eroJOHehP0ZGyyTveo6aMTHg_0)
	{
	}

	public override void SetData(PlaySexsceneEventData playSexsceneEventData_0)
	{
		base.SetData(playSexsceneEventData_0);
		SceneName = playSexsceneEventData_0.SceneName;
	}

	public override void _4hlxzMzKSbVTbZUrEsP3dfw4x0h()
	{
		base._4hlxzMzKSbVTbZUrEsP3dfw4x0h();
		base._5zNdOw7qHmuCAPJFMr3SsZdBlCr.Game._gYGB98heFqsLp9tgJbdCP01IKV2(SceneName);
	}

	public override void Update(GameTime gameTime)
	{
		base._xJZUPxDatEzfPQc0nRHR2D1Vwke = true;
	}
}
