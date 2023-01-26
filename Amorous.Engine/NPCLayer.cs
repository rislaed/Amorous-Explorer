using System;
using System.Reflection;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class NPCLayer : AbstractLayer
{
	public const string Prefix = "NPCLayer_";

	public AbstractNPC NPC;
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

	public NPCLayer(AbstractScene scene, AbstractNPC abstractNPC, LayerOrder layerOrder)
		: base(scene, Prefix + abstractNPC.GetType().Name)
	{
		NPC = abstractNPC;
		Layer = layerOrder;
	}

	public override void Update(GameTime gameTime)
	{
		if (_U1ntvSBQ11Vut0Wd1Vmb115ghn != null)
		{
			if (_sVephzY32oTa3X109UReGPT9rd != null && base.Scene.Game._5zNdOw7qHmuCAPJFMr3SsZdBlCr == null)
			{
				_U1ntvSBQ11Vut0Wd1Vmb115ghn();
			}
			_sVephzY32oTa3X109UReGPT9rd = base.Scene.Game._5zNdOw7qHmuCAPJFMr3SsZdBlCr;
		}
		NPC.Update(gameTime);
	}

	public override void Draw(SpriteBatch spriteBatch)
	{
	}
}
