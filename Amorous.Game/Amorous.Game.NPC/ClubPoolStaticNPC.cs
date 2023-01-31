using Microsoft.Xna.Framework.Graphics;

namespace Amorous.Game.NPC;

public abstract class ClubPoolStaticNPC : ClubStaticNPC
{
	public float PoolOffset = Utils.RandomFloat(-1f, 1f);
	public float PoolMaskOffset;

	private readonly Effect _effect;
	private readonly Texture2D _mask;

	protected bool InverseMask { get; set; }

	protected ClubPoolStaticNPC(IAmorous game, string sprite, string part, bool shirt, bool pants)
		: base(game, sprite, part, shirt, pants)
	{
		_effect = base.Game.Content.Load<Effect>("Assets/Shaders/Pool");
		_mask = base.Game.Content.Load<Texture2D>("Assets/Scenes/ClubPool/Wave Mask");
	}

	public override void Draw(SpriteBatch spriteBatch)
	{
		float offset = PoolMaskOffset + (float)_mask.Height;
		_effect.Parameters["Time"].SetValue(Utils.Date);
		_effect.Parameters["PoolSpeed"].SetValue(0.1f);
		_effect.Parameters["PoolOffset"].SetValue(PoolOffset);
		_effect.Parameters["MaskTexture"].SetValue(_mask);
		_effect.Parameters["MaskStart"].SetValue(PoolMaskOffset / (float)Height);
		_effect.Parameters["MaskEnd"].SetValue(offset / (float)Height);
		_effect.Parameters["Inverse"].SetValue(InverseMask);
		_effect.Parameters["BreathingOffset"].SetValue(BreathingOffset);
		_effect.CurrentTechnique.Passes[0].Apply();
		DrawPieces(spriteBatch);
	}
}
