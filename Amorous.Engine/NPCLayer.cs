using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class NPCLayer : AbstractLayer
{ // _3IHp43rpkJgOBcY9lrIrwMuwWve
	public const string Prefix = "NPCLayer_";

	public AbstractNPC NPC;
	public LayerOrder Layer;

	private Cutscene _cutscene;
	private Action _change;

	public Action CutsceneChange
	{
		set
		{
			_change = value;
			_change?.Invoke();
		}
	}

	public NPCLayer(AbstractScene scene, AbstractNPC npc, LayerOrder order)
		: base(scene, Prefix + npc.GetType().Name)
	{
		NPC = npc;
		Layer = order;
	}

	public override void Update(GameTime gameTime)
	{
		if (_change != null)
		{
			if (_cutscene != null && base.Scene.Game.Cutscene == null)
			{
				_change();
			}
			_cutscene = base.Scene.Game.Cutscene;
		}
		NPC.Update(gameTime);
	}

	public override void Draw(SpriteBatch spriteBatch) {}
}
