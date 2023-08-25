using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class NPCLayer : AbstractLayer
{ // _3IHp43rpkJgOBcY9lrIrwMuwWve
	public const string PREFIX = "NPCLayer_";

	public AbstractNPC NPC;
	public LayerOrder Layer;

	private Cutscene cutscene;
	private Action change;

	public Action CutsceneChange
	{
		set
		{
			change = value;
			change?.Invoke();
		}
	}

	public NPCLayer(AbstractScene scene, AbstractNPC npc, LayerOrder order)
		: base(scene, PREFIX + npc.GetType().Name)
	{
		NPC = npc;
		Layer = order;
	}

	public override void Update(GameTime gameTime)
	{
		if (change != null)
		{
			if (cutscene != null && base.Scene.Game.Cutscene == null)
			{
				change();
			}
			cutscene = base.Scene.Game.Cutscene;
		}
		NPC.Update(gameTime);
	}

	public override void Draw(SpriteBatch spriteBatch) {}
}
