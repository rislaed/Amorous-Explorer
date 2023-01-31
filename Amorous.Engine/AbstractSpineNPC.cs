using System;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spine;

public abstract class AbstractSpineNPC : AbstractNPC
{ // _tfDAeR6npiqJMLRSXPO1DxGA0TgA
	private class RenderStage
	{
		public Vector2 Location { get; set; }
		public RenderTarget2D Target { get; set; }
		public float Alpha { get; set; }
	}

	private readonly SpineBounds _bounds;
	private bool _drawable;
	private int? _stage;
	private bool _updatable;
	private readonly RenderStage[] _stages;
	private NPCLocation _location;

	public SpineRenderer Spine { get; private set; }
	public override float X { get; set; }
	public override float Y { get; set; }

	public override bool FlipX
	{
		get
		{
			return Spine.FlipX;
		}
		set
		{
			Spine.FlipX = value;
		}
	}

	public Texture2D Skin { get; set; }
	public Func<int, string, bool> BeforeRenderSlot { get; set; }

	protected AbstractSpineNPC(IAmorous game, string path, float scale = 1f, bool premultipliedAlpha = true)
		: base(game)
	{
		Spine = base.Game.Content.LoadSkeleton(path, scale, premultipliedAlpha);
		Spine.SetVisibility(0f);
		base.Scale = scale;
		_bounds = new SpineBounds();
		_stages = new RenderStage[2];
		_updatable = true;
	}

	public override void Update(GameTime gameTime)
	{
		if (_updatable)
		{
			Spine.Update(gameTime);
		}
		base.Update(gameTime);
	}

	public void Draw(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer)
	{
		base.Draw();
		if (_drawable)
		{
			DrawStage(skeletonMeshRenderer);
			spriteBatch.Begin();
			Color color = (IsHovered ? Color.Red : Color.White);
			foreach (RenderStage stage in _stages)
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
			Spine.X = X;
			Spine.Y = Y;
			Spine.Draw(skeletonMeshRenderer, scale: base.Scale, overrideTexture: Skin, beforeRenderSlot: BeforeRenderSlot, overrideColor: IsHovered ? new Color?(new Color(1, 0, 0, 1)) : null);
		}
	}

	protected override void SetAlpha(string bone, float alpha)
	{
		Spine.SetAlpha(bone, alpha);
	}

	private void DrawStage(SkeletonMeshRenderer skeletonMeshRenderer)
	{
		if (_stage.HasValue && _stages[_stage.Value] != null)
		{
			RenderStage stage = _stages[_stage.Value];
			RenderTargetBinding[] targets = base.Game.Graphics.GetRenderTargets();
			base.Game.Graphics.SetRenderTarget(stage.Target);
			base.Game.Graphics.Clear(Color.Transparent);
			Spine.X = stage.Location.X;
			Spine.Y = stage.Location.Y;
			Spine.Draw(skeletonMeshRenderer, scale: base.Scale, overrideTexture: Skin, beforeRenderSlot: BeforeRenderSlot);
			base.Game.Graphics.SetRenderTargets(targets);
		}
	}

	protected override bool Refresh(int stage)
	{
		if (stage == 0)
		{
			_location = base.Location;
		}
		else if (stage != 1)
		{
			if (stage >= 2)
			{
				_stage = null;
				return false;
			}
		}
		else if (_location == base.Location)
		{
			return false;
		}
		_drawable = true;
		_stage = stage;
		_updatable = false;
		Spine.X = 0f;
		Spine.Y = 0f;
		_bounds.Update(Spine.Spine);
		Vector2 bounds = new Vector2((int)_bounds.Width, (int)_bounds.Height);
		if (!(bounds.X <= 0f) && bounds.Y > 0f)
		{
			_stages[stage] = new RenderStage
			{
				Location = new Vector2(Spine.Spine.RootBone.WorldX - _bounds.X1, Spine.Spine.RootBone.WorldY - _bounds.Y1),
				Target = new RenderTarget2D(base.Game.Graphics, (int)bounds.X, (int)bounds.Y),
				Alpha = ((stage == 0) ? 1f : 0f)
			};
		}
		else
		{
			_stages[stage] = null;
		}
		return true;
	}

	protected override void Fade(float percent)
	{
		if (_stages[0] != null)
		{
			_stages[0].Alpha = percent;
		}
		if (_stages[1] != null)
		{
			_stages[1].Alpha = 1f - percent;
		}
	}

	protected override void Dispose()
	{
		_drawable = false;
		_stage = null;
		_updatable = true;
		if (_stages[0] != null)
		{
			_stages[0].Target.Dispose();
			_stages[0] = null;
		}
		if (_stages[1] != null)
		{
			_stages[1].Target.Dispose();
			_stages[1] = null;
		}
	}
}
