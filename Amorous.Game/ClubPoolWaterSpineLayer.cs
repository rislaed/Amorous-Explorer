using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spine;

public class ClubPoolWaterSpineLayer : SpineDrawableLayer
{ // _jOXcj4HBkU5j6LOJprpiXLCcLR0
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

	public ClubPoolWaterSpineLayer(AbstractScene scene, float offset, Rectangle location, bool inversed)
		: base(scene, "Pool Water")
	{
		ClubPoolWaterSpineLayer self = this;
		RenderTarget2D target = new RenderTarget2D(base.Scene.Game.GLES, location.Width, location.Height);
		Effect effect = base.Scene.Game.Content.Load<Effect>("Assets/Shaders/SpinePool");
		Texture2D waves = base.Scene.Game.Content.Load<Texture2D>("Assets/Scenes/ClubPool/Wave Mask");
		base.OnUpdate = delegate(GameTime gameTime)
		{
			self._spine.Update(gameTime);
		};
		base.OnSpineDraw = delegate(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer)
		{
			RenderTargetBinding[] renderTargets = self.Scene.Game.GLES.GetRenderTargets();
			self.Scene.Game.GLES.SetRenderTarget(target);
			self.Scene.Game.GLES.Clear(Color.Transparent);
			self._spine.Draw(skeletonMeshRenderer, null, null, null, self.Scale);
			self.Scene.Game.GLES.SetRenderTargets(renderTargets);
			spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend);
			float cycle = offset + (float)waves.Height;
			effect.Parameters["Time"].SetValue(Randoms.Time);
			effect.Parameters["PoolSpeed"].SetValue(0.1f);
			effect.Parameters["PoolOffset"].SetValue(0);
			effect.Parameters["MaskTexture"].SetValue(waves);
			effect.Parameters["MaskStart"].SetValue(offset / (float)location.Height);
			effect.Parameters["MaskEnd"].SetValue(cycle / (float)location.Height);
			effect.Parameters["Inverse"].SetValue(inversed);
			effect.CurrentTechnique.Passes[0].Apply();
			spriteBatch.Draw(target, new Vector2(location.X, location.Y), Color.White);
			spriteBatch.End();
		};
		_spine = scene.Game.Content.LoadSkeleton("Assets/Scenes/ClubPool/Club Pool water");
		_spine.X = 0f;
		_spine.Y = 0f;
		_spine.StartAnimationWithLooping("animation");
	}
}
