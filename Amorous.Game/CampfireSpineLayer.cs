using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spine;

public class CampfireSpineLayer : SpineDrawableLayer
{ // _99nxpM4875DlpTJ1IMF4j4oCXiD
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

	public CampfireSpineLayer(AbstractScene scene)
		: base(scene, "Campfire")
	{
		base.OnUpdate = delegate(GameTime gameTime)
		{
			_spine.Update(gameTime);
		};
		base.OnSpineDraw = delegate(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer)
		{
			_spine.Draw(skeletonMeshRenderer, null, null, null, Scale);
		};
		_spine = scene.Game.Content.LoadSkeleton("Assets/Scenes/Campfire/Campfire");
		_spine.X = 960f;
		_spine.Y = 540f;
		_spine.StartAnimationWithLooping("animation");
	}
}
