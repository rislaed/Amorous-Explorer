using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class _ZXdfBmHEapkc67visJnDe1hgtuz : AbstractEvent<SwitchToSubsceneEventData>
{
	public string SubsceneName { get; private set; }

	public _ZXdfBmHEapkc67visJnDe1hgtuz(_nR8eroJOHehP0ZGyyTveo6aMTHg _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
		: base(_nR8eroJOHehP0ZGyyTveo6aMTHg_0)
	{
	}

	public override void SetData(SwitchToSubsceneEventData switchToSubsceneEventData_0)
	{
		base.SetData(switchToSubsceneEventData_0);
		SubsceneName = switchToSubsceneEventData_0.SubsceneName;
	}

	public override void _4hlxzMzKSbVTbZUrEsP3dfw4x0h()
	{
		base._4hlxzMzKSbVTbZUrEsP3dfw4x0h();
		base._5zNdOw7qHmuCAPJFMr3SsZdBlCr.Game.Scene._6hE3geqxrB1vCirtSWHxIJjlTQB(SubsceneName);
	}

	public override void Update(GameTime gameTime)
	{
		base._xJZUPxDatEzfPQc0nRHR2D1Vwke = true;
	}
}
