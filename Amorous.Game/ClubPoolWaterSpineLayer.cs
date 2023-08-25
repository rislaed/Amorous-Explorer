using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spine;

public class ClubPoolWaterSpineLayer : SpineDrawableLayer
{ // _jOXcj4HBkU5j6LOJprpiXLCcLR0
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

	public ClubPoolWaterSpineLayer(AbstractScene scene, float offset, Rectangle location, bool inversed)
		: base(scene, "Pool Water")
	{
		ClubPoolWaterSpineLayer self = this;
		RenderTarget2D target = new RenderTarget2D(base.Scene.Game.Graphics, location.Width, location.Height);
		Effect effect = base.Scene.Game.Content.Load<Effect>("Assets/Shaders/SpinePool");
		Texture2D waves = base.Scene.Game.Content.Load<Texture2D>("Assets/Scenes/ClubPool/Wave Mask");
		base.OnUpdate = delegate(GameTime gameTime)
		{
			self.skeleton.Update(gameTime);
		};
		base.OnSpineDraw = delegate(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer)
		{
			RenderTargetBinding[] renderTargets = self.Scene.Game.Graphics.GetRenderTargets();
			self.Scene.Game.Graphics.SetRenderTarget(target);
			self.Scene.Game.Graphics.Clear(Color.Transparent);
			self.skeleton.Draw(skeletonMeshRenderer, null, null, null, self.Scale);
			self.Scene.Game.Graphics.SetRenderTargets(renderTargets);
			spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend);
			float cycle = offset + (float)waves.Height;
			effect.Parameters["Time"].SetValue(Utils.Date);
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
		skeleton = scene.Game.Content.LoadSkeleton("Assets/Scenes/ClubPool/Club Pool water");
		skeleton.X = 0f;
		skeleton.Y = 0f;
		skeleton.StartAnimationWithLooping("animation");
	}
}
