using System;
using System.Reflection;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class _3IHp43rpkJgOBcY9lrIrwMuwWve : _ujAkjlfN5TywwbLAUDzPvtab6uJ
{
	public const string _tyk6ubAYksgThinoaE8CE4cUqSC = "NPCLayer_";

	public _QGGOTxZ8aNWGh0hc26wcmx8wmwT NPC;

	public LayerOrder Layer;

	private _nR8eroJOHehP0ZGyyTveo6aMTHg _sVephzY32oTa3X109UReGPT9rd;

	private Action _U1ntvSBQ11Vut0Wd1Vmb115ghn;

	public Action _64JjsghBPDjZ1OxZwhO8Y6dFE5t
	{
		set
		{
			_U1ntvSBQ11Vut0Wd1Vmb115ghn = value;
			_U1ntvSBQ11Vut0Wd1Vmb115ghn?.Invoke();
		}
	}

	public _3IHp43rpkJgOBcY9lrIrwMuwWve(AbstractScene AbstractScene_0, _QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, LayerOrder LayerOrder_0)
		: base(AbstractScene_0, "NPCLayer_" + _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0.GetType().Name)
	{
		NPC = _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0;
		Layer = LayerOrder_0;
	}

	public override void Update(GameTime gameTime_0)
	{
		if (_U1ntvSBQ11Vut0Wd1Vmb115ghn != null)
		{
			if (_sVephzY32oTa3X109UReGPT9rd != null && base.Scene.Game._5zNdOw7qHmuCAPJFMr3SsZdBlCr == null)
			{
				_U1ntvSBQ11Vut0Wd1Vmb115ghn();
			}
			_sVephzY32oTa3X109UReGPT9rd = base.Scene.Game._5zNdOw7qHmuCAPJFMr3SsZdBlCr;
		}
		NPC.Update(gameTime_0);
	}

	public override void Draw(SpriteBatch spriteBatch_0)
	{
	}
}
