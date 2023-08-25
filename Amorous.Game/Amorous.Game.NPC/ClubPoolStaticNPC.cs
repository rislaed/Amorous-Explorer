using Microsoft.Xna.Framework.Graphics;

namespace Amorous.Game.NPC;

public abstract class ClubPoolStaticNPC : ClubStaticNPC
{
	public float PoolOffset = Utils.RandomFloat(-1f, 1f);
	public float PoolMaskOffset;

	private readonly Effect effect;
	private readonly Texture2D waveMask;

	protected bool InverseMask { get; set; }

	protected ClubPoolStaticNPC(IAmorous game, string sprite, string part, bool shirt, bool pants)
		: base(game, sprite, part, shirt, pants)
	{
		effect = base.Game.Content.Load<Effect>("Assets/Shaders/Pool");
		waveMask = base.Game.Content.Load<Texture2D>("Assets/Scenes/ClubPool/Wave Mask");
	}

	public override void Draw(SpriteBatch spriteBatch)
	{
		float offset = PoolMaskOffset + (float)waveMask.Height;
		effect.Parameters["Time"].SetValue(Utils.Date);
		effect.Parameters["PoolSpeed"].SetValue(0.1f);
		effect.Parameters["PoolOffset"].SetValue(PoolOffset);
		effect.Parameters["MaskTexture"].SetValue(waveMask);
		effect.Parameters["MaskStart"].SetValue(PoolMaskOffset / (float)Height);
		effect.Parameters["MaskEnd"].SetValue(offset / (float)Height);
		effect.Parameters["Inverse"].SetValue(InverseMask);
		effect.Parameters["BreathingOffset"].SetValue(BreathingOffset);
		effect.CurrentTechnique.Passes[0].Apply();
		DrawPieces(spriteBatch);
	}
}
