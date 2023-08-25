using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spine;

public class ClubPoolSpineLayer : SpineDrawableLayer
{ // _lnXs1JfCeIBNCpFYs8XVRorc0h4
	private readonly SkeletonRenderer skeleton;

	public override float OffsetX
	{
		get
		{
			return skeleton.X;
		}
		set
		{
			skeleton.X = value;
		}
	}

	public override float OffsetY
	{
		get
		{
			return skeleton.Y;
		}
		set
		{
			skeleton.Y = value;
		}
	}

	public ClubPoolSpineLayer(AbstractScene scene) : base(scene, "Pool Water")
	{
		base.OnUpdate = delegate(GameTime gameTime)
		{
			skeleton.Update(gameTime);
		};
		base.OnSpineDraw = delegate(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer)
		{
			skeleton.Draw(skeletonMeshRenderer, null, null, null, Scale);
		};
		skeleton = scene.Game.Content.LoadSkeleton("Assets/Scenes/ClubPool/Club Pool water");
		skeleton.X = 0f;
		skeleton.Y = 0f;
		skeleton.StartAnimationWithLooping("animation");
	}
}
