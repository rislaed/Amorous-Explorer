using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class _ZXdfBmHEapkc67visJnDe1hgtuz : AbstractEvent<SwitchToSubsceneEventData>
{
	public string SubsceneName { get; private set; }

	public _ZXdfBmHEapkc67visJnDe1hgtuz(Cutscene _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
		: base(_nR8eroJOHehP0ZGyyTveo6aMTHg_0)
	{
	}

	public override void SetData(SwitchToSubsceneEventData switchToSubsceneEventData_0)
	{
		base.SetData(switchToSubsceneEventData_0);
		SubsceneName = switchToSubsceneEventData_0.SubsceneName;
	}

	public override void Begin()
	{
		base.Begin();
		base.Cutscene.Game.Scene.SetVariant(SubsceneName);
	}

	public override void Update(GameTime gameTime)
	{
		base.Completable = true;
	}
}
