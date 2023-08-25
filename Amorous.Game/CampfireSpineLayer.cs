using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spine;

public class CampfireSpineLayer : SpineDrawableLayer
{ // _99nxpM4875DlpTJ1IMF4j4oCXiD
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

	public CampfireSpineLayer(AbstractScene scene) : base(scene, "Campfire")
	{
		base.OnUpdate = delegate(GameTime gameTime)
		{
			skeleton.Update(gameTime);
		};
		base.OnSpineDraw = delegate(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer)
		{
			skeleton.Draw(skeletonMeshRenderer, null, null, null, Scale);
		};
		skeleton = scene.Game.Content.LoadSkeleton("Assets/Scenes/Campfire/Campfire");
		skeleton.X = 960f;
		skeleton.Y = 540f;
		skeleton.StartAnimationWithLooping("animation");
	}
}
