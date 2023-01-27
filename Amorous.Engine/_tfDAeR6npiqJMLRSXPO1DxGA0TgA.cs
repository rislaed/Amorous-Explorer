using System;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spine;

public abstract class _tfDAeR6npiqJMLRSXPO1DxGA0TgA : AbstractNPC
{
	private class _eBuDnRXeABWf8uwfsN15PfKEHw
	{
		public Vector2 Location { get; set; }
		public RenderTarget2D _Z5JOwYZpe1u3WDYizFmDS7dmAcK { get; set; }
		public float _WxTaPaOE8qb7d7anVlwwqCzugAo { get; set; }
	}

	private readonly _NxPDyghimJKCwBg53DaNTazjQ5k _YWKqVMq3bCWDIv73VmJykYuZBKN;
	private bool _7sgRQPgr8EJYjFmEXCYagaObJd0;
	private int? _xm9p2W8AbxEBdrI3wbC7knvB06R;
	private bool _FdDzmVlp0fgTsGUxfkRfLr0dxtF;
	private readonly _eBuDnRXeABWf8uwfsN15PfKEHw[] _smM3y5A19la8hNpeOINXXDeitDH;
	private NPCLocation _KouBKjmDwRJIjRK4fKJ8PzNn9uV;
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

	protected _tfDAeR6npiqJMLRSXPO1DxGA0TgA(IAmorous game, string string_0, float float_0 = 1f, bool bool_0 = true)
		: base(game)
	{
		Spine = base.Game.Content._7BVREQXEcBCieHb0qgaVDpUj1ni(string_0, float_0, bool_0);
		Spine.SetVisibility(0f);
		base.Scale = float_0;
		_YWKqVMq3bCWDIv73VmJykYuZBKN = new _NxPDyghimJKCwBg53DaNTazjQ5k();
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
			Color color = (_IvIFs0Tl6RHdTn3daJXsNCXCNyO ? Color.Red : Color.White);
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
			Spine.Draw(skeletonMeshRenderer, float_0: base.Scale, texture2D: Skin, func_0: _YwAdHC5A5VB16lereNxJLkAP3Z9A, nullable_0: _IvIFs0Tl6RHdTn3daJXsNCXCNyO ? new Color?(new Color(1, 0, 0, 1)) : null);
		}
	}

	protected override void SetAlpha(string string_0, float float_0)
	{
		Spine.SetAlpha(string_0, float_0);
	}

	private void _4nhWi4RWJVAsAaRiBUYVgLfEiCz(SkeletonMeshRenderer skeletonMeshRenderer)
	{
		if (_xm9p2W8AbxEBdrI3wbC7knvB06R.HasValue && _smM3y5A19la8hNpeOINXXDeitDH[_xm9p2W8AbxEBdrI3wbC7knvB06R.Value] != null)
		{
			_eBuDnRXeABWf8uwfsN15PfKEHw eBuDnRXeABWf8uwfsN15PfKEHw = _smM3y5A19la8hNpeOINXXDeitDH[_xm9p2W8AbxEBdrI3wbC7knvB06R.Value];
			RenderTargetBinding[] renderTargets = base.Game._2yepMkVENnecIsduggABaU2qhXW.GetRenderTargets();
			base.Game._2yepMkVENnecIsduggABaU2qhXW.SetRenderTarget(eBuDnRXeABWf8uwfsN15PfKEHw._Z5JOwYZpe1u3WDYizFmDS7dmAcK);
			base.Game._2yepMkVENnecIsduggABaU2qhXW.Clear(Color.Transparent);
			Spine.X = eBuDnRXeABWf8uwfsN15PfKEHw.Location.X;
			Spine.Y = eBuDnRXeABWf8uwfsN15PfKEHw.Location.Y;
			Spine.Draw(skeletonMeshRenderer, float_0: base.Scale, texture2D: Skin, func_0: _YwAdHC5A5VB16lereNxJLkAP3Z9A);
			base.Game._2yepMkVENnecIsduggABaU2qhXW.SetRenderTargets(renderTargets);
		}
	}

	protected override bool _BbDRof5yB0Qn864T1KJxUzMy8di(int int_0)
	{
		if (int_0 == 0)
		{
			_KouBKjmDwRJIjRK4fKJ8PzNn9uV = base.Location;
		}
		else if (int_0 != 1)
		{
			if (int_0 >= 2)
			{
				_xm9p2W8AbxEBdrI3wbC7knvB06R = null;
				return false;
			}
		}
		else if (_KouBKjmDwRJIjRK4fKJ8PzNn9uV == base.Location)
		{
			return false;
		}
		_7sgRQPgr8EJYjFmEXCYagaObJd0 = true;
		_xm9p2W8AbxEBdrI3wbC7knvB06R = int_0;
		_FdDzmVlp0fgTsGUxfkRfLr0dxtF = false;
		Spine.X = 0f;
		Spine.Y = 0f;
		_YWKqVMq3bCWDIv73VmJykYuZBKN.Update(Spine.Spine);
		Vector2 vector = new Vector2((int)_YWKqVMq3bCWDIv73VmJykYuZBKN.Width, (int)_YWKqVMq3bCWDIv73VmJykYuZBKN.Height);
		if (!(vector.X <= 0f) && vector.Y > 0f)
		{
			_smM3y5A19la8hNpeOINXXDeitDH[int_0] = new _eBuDnRXeABWf8uwfsN15PfKEHw
			{
				Location = new Vector2(Spine.Spine.RootBone.WorldX - _YWKqVMq3bCWDIv73VmJykYuZBKN._SjhHztt8d5kOtb7Z2BJKnZZxEKh, Spine.Spine.RootBone.WorldY - _YWKqVMq3bCWDIv73VmJykYuZBKN._xqxFKfudZYzf8RtrC7EB1Ya6FPT),
				_Z5JOwYZpe1u3WDYizFmDS7dmAcK = new RenderTarget2D(base.Game._2yepMkVENnecIsduggABaU2qhXW, (int)vector.X, (int)vector.Y),
				_WxTaPaOE8qb7d7anVlwwqCzugAo = ((int_0 == 0) ? 1f : 0f)
			};
		}
		else
		{
			_smM3y5A19la8hNpeOINXXDeitDH[int_0] = null;
		}
		return true;
	}

	protected override void _PdRLTpsImBScBFQhILtCHJpcsllA(float float_0)
	{
		if (_smM3y5A19la8hNpeOINXXDeitDH[0] != null)
		{
			_smM3y5A19la8hNpeOINXXDeitDH[0]._WxTaPaOE8qb7d7anVlwwqCzugAo = float_0;
		}
		if (_smM3y5A19la8hNpeOINXXDeitDH[1] != null)
		{
			_smM3y5A19la8hNpeOINXXDeitDH[1]._WxTaPaOE8qb7d7anVlwwqCzugAo = 1f - float_0;
		}
	}

	protected override void _Hx7zLXU6nbxudxFgMuYbyRXeEPB()
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
