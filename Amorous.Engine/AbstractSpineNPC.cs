using System;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spine;

public abstract class AbstractSpineNPC : AbstractNPC
{ // _tfDAeR6npiqJMLRSXPO1DxGA0TgA
	private class RenderTarget
	{
		public Vector2 Location { get; set; }
		public RenderTarget2D Target { get; set; }
		public float Alpha { get; set; }
	}

	private readonly SpineRectangle bounds;
	private bool drawable;
	private int? target;
	private bool updatable;
	private readonly RenderTarget[] targets;
	private NPCLocation location;

	public SkeletonRenderer Skeleton { get; private set; }
	public override float X { get; set; }
	public override float Y { get; set; }

	public override bool FlipX
	{
		get
		{
			return Skeleton.FlipX;
		}
		set
		{
			Skeleton.FlipX = value;
		}
	}

	public Texture2D Texture { get; set; }
	public Func<int, string, bool> BeforeRenderSlot { get; set; }

	protected AbstractSpineNPC(IAmorous game, string path, float scale = 1f, bool premultipliedAlpha = true) : base(game)
	{
		Skeleton = base.Game.Content.LoadSkeleton(path, scale, premultipliedAlpha);
		Skeleton.SetVisibility(0f);
		base.Scale = scale;
		bounds = new SpineRectangle();
		targets = new RenderTarget[2];
		updatable = true;
	}

	public override void Update(GameTime gameTime)
	{
		if (updatable)
		{
			Skeleton.Update(gameTime);
		}
		base.Update(gameTime);
	}

	public void Draw(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer)
	{
		base.Draw();
		if (drawable)
		{
			DrawInternal(skeletonMeshRenderer);
			spriteBatch.Begin();
			Color color = (IsHovered ? Color.Red : Color.White);
			foreach (RenderTarget stage in targets)
			{
				if (stage != null)
				{
					spriteBatch.Draw(stage.Target, null, new Rectangle((int)X, (int)Y, stage.Target.Width, stage.Target.Height), null, stage.Location, 0f, null, color * stage.Alpha);
				}
			}
			spriteBatch.End();
		}
		else
		{
			Skeleton.X = X;
			Skeleton.Y = Y;
			Skeleton.Draw(skeletonMeshRenderer, scale: base.Scale, overrideTexture: Texture, beforeRenderSlot: BeforeRenderSlot, overrideColor: IsHovered ? new Color?(new Color(1, 0, 0, 1)) : null);
		}
	}

	protected override void SetAlpha(string slotName, float alpha)
	{
		Skeleton.SetAlpha(slotName, alpha);
	}

	private void DrawInternal(SkeletonMeshRenderer skeletonMeshRenderer)
	{
		if (target.HasValue && targets[target.Value] != null)
		{
            RenderTarget stage = this.targets[target.Value];
			RenderTargetBinding[] targets = base.Game.Graphics.GetRenderTargets();
			base.Game.Graphics.SetRenderTarget(stage.Target);
			base.Game.Graphics.Clear(Color.Transparent);
			Skeleton.X = stage.Location.X;
			Skeleton.Y = stage.Location.Y;
			Skeleton.Draw(skeletonMeshRenderer, scale: base.Scale, overrideTexture: Texture, beforeRenderSlot: BeforeRenderSlot);
			base.Game.Graphics.SetRenderTargets(targets);
		}
	}

	protected override bool Refresh(int target)
	{
		if (target == 0)
		{
			location = base.Location;
		}
		else if (target != 1)
		{
			if (target >= 2)
			{
				this.target = null;
				return false;
			}
		}
		else if (location == base.Location)
		{
			return false;
		}
		drawable = true;
		this.target = target;
		updatable = false;
		Skeleton.X = 0f;
		Skeleton.Y = 0f;
		bounds.Update(Skeleton.Skeleton);
		Vector2 size = new Vector2((int)bounds.Width, (int)bounds.Height);
		if (!(size.X <= 0f) && size.Y > 0f)
		{
			targets[target] = new RenderTarget
			{
				Location = new Vector2(Skeleton.Skeleton.RootBone.WorldX - bounds.Left, Skeleton.Skeleton.RootBone.WorldY - bounds.Top),
				Target = new RenderTarget2D(base.Game.Graphics, (int)size.X, (int)size.Y),
				Alpha = ((target == 0) ? 1f : 0f)
			};
		}
		else
		{
			targets[target] = null;
		}
		return true;
	}

	protected override void Fade(float amount)
	{
		if (targets[0] != null)
		{
			targets[0].Alpha = amount;
		}
		if (targets[1] != null)
		{
			targets[1].Alpha = 1f - amount;
		}
	}

	protected override void Dispose()
	{
		drawable = false;
		target = null;
		updatable = true;
		if (targets[0] != null)
		{
			targets[0].Target.Dispose();
			targets[0] = null;
		}
		if (targets[1] != null)
		{
			targets[1].Target.Dispose();
			targets[1] = null;
		}
	}
}
