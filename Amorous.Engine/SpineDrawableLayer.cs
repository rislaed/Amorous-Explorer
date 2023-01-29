using System;
using Microsoft.Xna.Framework.Graphics;
using Spine;

public class SpineDrawableLayer : DrawableLayer
{ // _WBXNT6eIVGk6ZKExRBJ6JxXE6zb
	public Action<SpriteBatch, SkeletonMeshRenderer> OnSpineDraw { private get; set; }
	public virtual float OffsetX { get; set; }
	public virtual float OffsetY { get; set; }
	public bool InTalking { get; set; }

	public SpineDrawableLayer(AbstractScene scene, string name)
		: base(scene, name) {}

	public void Draw(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer)
	{
		Draw(spriteBatch);
		OnSpineDraw?.Invoke(spriteBatch, skeletonMeshRenderer);
	}
}
