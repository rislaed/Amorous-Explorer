using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spine;

public class ClubPoolSpineLayer : SpineDrawableLayer
{ // _lnXs1JfCeIBNCpFYs8XVRorc0h4
	private readonly SpineRenderer _spine;

	public override float OffsetX
	{
		get
		{
			return _spine.X;
		}
		set
		{
			_spine.X = value;
		}
	}

	public override float OffsetY
	{
		get
		{
			return _spine.Y;
		}
		set
		{
			_spine.Y = value;
		}
	}

	public ClubPoolSpineLayer(AbstractScene scene)
		: base(scene, "Pool Water")
	{
		base.OnUpdate = delegate(GameTime gameTime)
		{
			_spine.Update(gameTime);
		};
		base.OnSpineDraw = delegate(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer)
		{
			_spine.Draw(skeletonMeshRenderer, null, null, null, Scale);
		};
		_spine = scene.Game.Content.LoadSkeleton("Assets/Scenes/ClubPool/Club Pool water");
		_spine.X = 0f;
		_spine.Y = 0f;
		_spine.StartAnimationWithLooping("animation");
	}
}
