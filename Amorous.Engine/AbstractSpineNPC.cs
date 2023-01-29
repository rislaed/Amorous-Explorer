using System;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spine;

public abstract class AbstractSpineNPC : AbstractNPC
{ // _tfDAeR6npiqJMLRSXPO1DxGA0TgA
	private class _eBuDnRXeABWf8uwfsN15PfKEHw
	{
		public Vector2 Location { get; set; }
		public RenderTarget2D _Z5JOwYZpe1u3WDYizFmDS7dmAcK { get; set; }
		public float _WxTaPaOE8qb7d7anVlwwqCzugAo { get; set; }
	}

	private readonly SpineSkeletonBounds _bounds;
	private bool _7sgRQPgr8EJYjFmEXCYagaObJd0;
	private int? _xm9p2W8AbxEBdrI3wbC7knvB06R;
	private bool _FdDzmVlp0fgTsGUxfkRfLr0dxtF;
	private readonly _eBuDnRXeABWf8uwfsN15PfKEHw[] _smM3y5A19la8hNpeOINXXDeitDH;
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
	public Func<int, string, bool> _YwAdHC5A5VB16lereNxJLkAP3Z9A { get; set; }

	protected AbstractSpineNPC(IAmorous game, string path, float scale = 1f, bool premultipliedAlpha = true)
		: base(game)
	{
		Spine = base.Game.Content.LoadSkeleton(path, scale, premultipliedAlpha);
		Spine.SetVisibility(0f);
		base.Scale = scale;
		_bounds = new SpineSkeletonBounds();
		_smM3y5A19la8hNpeOINXXDeitDH = new _eBuDnRXeABWf8uwfsN15PfKEHw[2];
		_FdDzmVlp0fgTsGUxfkRfLr0dxtF = true;
	}

	public override void Update(GameTime gameTime)
	{
		if (_FdDzmVlp0fgTsGUxfkRfLr0dxtF)
		{
			Spine.Update(gameTime);
		}
		base.Update(gameTime);
	}

	public void Draw(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer)
	{
		base.Draw();
		if (_7sgRQPgr8EJYjFmEXCYagaObJd0)
		{
			_4nhWi4RWJVAsAaRiBUYVgLfEiCz(skeletonMeshRenderer);
			spriteBatch.Begin();
			Color color = (IsHovered ? Color.Red : Color.White);
			_eBuDnRXeABWf8uwfsN15PfKEHw[] smM3y5A19la8hNpeOINXXDeitDH = _smM3y5A19la8hNpeOINXXDeitDH;
			foreach (_eBuDnRXeABWf8uwfsN15PfKEHw eBuDnRXeABWf8uwfsN15PfKEHw in smM3y5A19la8hNpeOINXXDeitDH)
			{
				if (eBuDnRXeABWf8uwfsN15PfKEHw != null)
				{
					spriteBatch.Draw(eBuDnRXeABWf8uwfsN15PfKEHw._Z5JOwYZpe1u3WDYizFmDS7dmAcK, null, new Rectangle((int)X, (int)Y, eBuDnRXeABWf8uwfsN15PfKEHw._Z5JOwYZpe1u3WDYizFmDS7dmAcK.Width, eBuDnRXeABWf8uwfsN15PfKEHw._Z5JOwYZpe1u3WDYizFmDS7dmAcK.Height), null, eBuDnRXeABWf8uwfsN15PfKEHw.Location, 0f, null, color * eBuDnRXeABWf8uwfsN15PfKEHw._WxTaPaOE8qb7d7anVlwwqCzugAo);
				}
			}
			spriteBatch.End();
		}
		else
		{
			Spine.X = X;
			Spine.Y = Y;
			Spine.Draw(skeletonMeshRenderer, float_0: base.Scale, texture2D: Skin, func_0: _YwAdHC5A5VB16lereNxJLkAP3Z9A, nullable_0: IsHovered ? new Color?(new Color(1, 0, 0, 1)) : null);
		}
	}

	protected override void SetAlpha(string bone, float alpha)
	{
		Spine.SetAlpha(bone, alpha);
	}

	private void _4nhWi4RWJVAsAaRiBUYVgLfEiCz(SkeletonMeshRenderer skeletonMeshRenderer)
	{
		if (_xm9p2W8AbxEBdrI3wbC7knvB06R.HasValue && _smM3y5A19la8hNpeOINXXDeitDH[_xm9p2W8AbxEBdrI3wbC7knvB06R.Value] != null)
		{
			_eBuDnRXeABWf8uwfsN15PfKEHw eBuDnRXeABWf8uwfsN15PfKEHw = _smM3y5A19la8hNpeOINXXDeitDH[_xm9p2W8AbxEBdrI3wbC7knvB06R.Value];
			RenderTargetBinding[] renderTargets = base.Game.GLES.GetRenderTargets();
			base.Game.GLES.SetRenderTarget(eBuDnRXeABWf8uwfsN15PfKEHw._Z5JOwYZpe1u3WDYizFmDS7dmAcK);
			base.Game.GLES.Clear(Color.Transparent);
			Spine.X = eBuDnRXeABWf8uwfsN15PfKEHw.Location.X;
			Spine.Y = eBuDnRXeABWf8uwfsN15PfKEHw.Location.Y;
			Spine.Draw(skeletonMeshRenderer, float_0: base.Scale, texture2D: Skin, func_0: _YwAdHC5A5VB16lereNxJLkAP3Z9A);
			base.Game.GLES.SetRenderTargets(renderTargets);
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
				_xm9p2W8AbxEBdrI3wbC7knvB06R = null;
				return false;
			}
		}
		else if (_location == base.Location)
		{
			return false;
		}
		_7sgRQPgr8EJYjFmEXCYagaObJd0 = true;
		_xm9p2W8AbxEBdrI3wbC7knvB06R = stage;
		_FdDzmVlp0fgTsGUxfkRfLr0dxtF = false;
		Spine.X = 0f;
		Spine.Y = 0f;
		_bounds.Update(Spine.Spine);
		Vector2 vector = new Vector2((int)_bounds.Width, (int)_bounds.Height);
		if (!(vector.X <= 0f) && vector.Y > 0f)
		{
			_smM3y5A19la8hNpeOINXXDeitDH[stage] = new _eBuDnRXeABWf8uwfsN15PfKEHw
			{
				Location = new Vector2(Spine.Spine.RootBone.WorldX - _bounds.X1, Spine.Spine.RootBone.WorldY - _bounds.Y1),
				_Z5JOwYZpe1u3WDYizFmDS7dmAcK = new RenderTarget2D(base.Game.GLES, (int)vector.X, (int)vector.Y),
				_WxTaPaOE8qb7d7anVlwwqCzugAo = ((stage == 0) ? 1f : 0f)
			};
		}
		else
		{
			_smM3y5A19la8hNpeOINXXDeitDH[stage] = null;
		}
		return true;
	}

	protected override void Fade(float percent)
	{
		if (_smM3y5A19la8hNpeOINXXDeitDH[0] != null)
		{
			_smM3y5A19la8hNpeOINXXDeitDH[0]._WxTaPaOE8qb7d7anVlwwqCzugAo = percent;
		}
		if (_smM3y5A19la8hNpeOINXXDeitDH[1] != null)
		{
			_smM3y5A19la8hNpeOINXXDeitDH[1]._WxTaPaOE8qb7d7anVlwwqCzugAo = 1f - percent;
		}
	}

	protected override void DisposeFading()
	{
		_7sgRQPgr8EJYjFmEXCYagaObJd0 = false;
		_xm9p2W8AbxEBdrI3wbC7knvB06R = null;
		_FdDzmVlp0fgTsGUxfkRfLr0dxtF = true;
		if (_smM3y5A19la8hNpeOINXXDeitDH[0] != null)
		{
			_smM3y5A19la8hNpeOINXXDeitDH[0]._Z5JOwYZpe1u3WDYizFmDS7dmAcK.Dispose();
			_smM3y5A19la8hNpeOINXXDeitDH[0] = null;
		}
		if (_smM3y5A19la8hNpeOINXXDeitDH[1] != null)
		{
			_smM3y5A19la8hNpeOINXXDeitDH[1]._Z5JOwYZpe1u3WDYizFmDS7dmAcK.Dispose();
			_smM3y5A19la8hNpeOINXXDeitDH[1] = null;
		}
	}
}
