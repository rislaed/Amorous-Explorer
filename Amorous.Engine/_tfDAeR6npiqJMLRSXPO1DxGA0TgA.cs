using System;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spine;

public abstract class _tfDAeR6npiqJMLRSXPO1DxGA0TgA : _QGGOTxZ8aNWGh0hc26wcmx8wmwT
{
	private class _eBuDnRXeABWf8uwfsN15PfKEHw
	{
		public Vector2 _Jh6AK28sBy2bS8ZCoKHP3LX45Uk { get; set; }

		public RenderTarget2D _Z5JOwYZpe1u3WDYizFmDS7dmAcK { get; set; }

		public float _WxTaPaOE8qb7d7anVlwwqCzugAo { get; set; }
	}

	private readonly _NxPDyghimJKCwBg53DaNTazjQ5k _YWKqVMq3bCWDIv73VmJykYuZBKN;

	private bool _7sgRQPgr8EJYjFmEXCYagaObJd0;

	private int? _xm9p2W8AbxEBdrI3wbC7knvB06R;

	private bool _FdDzmVlp0fgTsGUxfkRfLr0dxtF;

	private readonly _eBuDnRXeABWf8uwfsN15PfKEHw[] _smM3y5A19la8hNpeOINXXDeitDH;

	private NPCLocation _KouBKjmDwRJIjRK4fKJ8PzNn9uV;

	public _nHdiyIURlAiaNZ8u6MKzxjcwnyL _1BgOJ3z4ZUXNS2L4JWf24pr41hB { get; private set; }

	public override float _QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL { get; set; }

	public override float _QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf { get; set; }

	public override bool _QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn
	{
		get
		{
			return _1BgOJ3z4ZUXNS2L4JWf24pr41hB._Hwt6L2NJfXmAfG6UOH8NVlNfGCR;
		}
		set
		{
			_1BgOJ3z4ZUXNS2L4JWf24pr41hB._Hwt6L2NJfXmAfG6UOH8NVlNfGCR = value;
		}
	}

	public Texture2D _1AqpgY4vB6ly5vxOay6j86rcIEo { get; set; }

	public Func<int, string, bool> _YwAdHC5A5VB16lereNxJLkAP3Z9A { get; set; }

	protected _tfDAeR6npiqJMLRSXPO1DxGA0TgA(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, string string_0, float float_0 = 1f, bool bool_0 = true)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		_1BgOJ3z4ZUXNS2L4JWf24pr41hB = base._ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8._7BVREQXEcBCieHb0qgaVDpUj1ni(string_0, float_0, bool_0);
		_1BgOJ3z4ZUXNS2L4JWf24pr41hB._c4iC7y9v6xg7LpvjKIeUkOdZ3UF(0f);
		base._fO7gSlrDDNMoHR4FO5QXAq8fUyA = float_0;
		_YWKqVMq3bCWDIv73VmJykYuZBKN = new _NxPDyghimJKCwBg53DaNTazjQ5k();
		_smM3y5A19la8hNpeOINXXDeitDH = new _eBuDnRXeABWf8uwfsN15PfKEHw[2];
		_FdDzmVlp0fgTsGUxfkRfLr0dxtF = true;
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		if (_FdDzmVlp0fgTsGUxfkRfLr0dxtF)
		{
			_1BgOJ3z4ZUXNS2L4JWf24pr41hB._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
		}
		base._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
	}

	public void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		base._f5ctqAmdNsZ889UjM4LxDm8WGxA();
		if (_7sgRQPgr8EJYjFmEXCYagaObJd0)
		{
			_4nhWi4RWJVAsAaRiBUYVgLfEiCz(skeletonMeshRenderer_0);
			_tfDAeR6npiqJMLRSXPO1DxGA0TgA.smethod_5(spriteBatch_0);
			Color val = (_IvIFs0Tl6RHdTn3daJXsNCXCNyO ? Color.get_Red() : Color.get_White());
			_eBuDnRXeABWf8uwfsN15PfKEHw[] smM3y5A19la8hNpeOINXXDeitDH = _smM3y5A19la8hNpeOINXXDeitDH;
			foreach (_eBuDnRXeABWf8uwfsN15PfKEHw eBuDnRXeABWf8uwfsN15PfKEHw in smM3y5A19la8hNpeOINXXDeitDH)
			{
				if (eBuDnRXeABWf8uwfsN15PfKEHw != null)
				{
					spriteBatch_0._f5ctqAmdNsZ889UjM4LxDm8WGxA((Texture2D)(object)eBuDnRXeABWf8uwfsN15PfKEHw._Z5JOwYZpe1u3WDYizFmDS7dmAcK, (Vector2?)null, (Rectangle?)new Rectangle((int)_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL, (int)_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf, _tfDAeR6npiqJMLRSXPO1DxGA0TgA.smethod_6((Texture2D)(object)eBuDnRXeABWf8uwfsN15PfKEHw._Z5JOwYZpe1u3WDYizFmDS7dmAcK), _tfDAeR6npiqJMLRSXPO1DxGA0TgA.smethod_7((Texture2D)(object)eBuDnRXeABWf8uwfsN15PfKEHw._Z5JOwYZpe1u3WDYizFmDS7dmAcK)), (Rectangle?)null, (Vector2?)eBuDnRXeABWf8uwfsN15PfKEHw._Jh6AK28sBy2bS8ZCoKHP3LX45Uk, 0f, (Vector2?)null, (Color?)(val * eBuDnRXeABWf8uwfsN15PfKEHw._WxTaPaOE8qb7d7anVlwwqCzugAo), (SpriteEffects)0, 0f);
				}
			}
			spriteBatch_0.End();
		}
		else
		{
			_1BgOJ3z4ZUXNS2L4JWf24pr41hB._7Xn1C5tjYnmIif1iZKV8AWsEEbL = _QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL;
			_1BgOJ3z4ZUXNS2L4JWf24pr41hB._bCjZ3VSXGKyhmykd2zCnQBiSpDf = _QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf;
			_1BgOJ3z4ZUXNS2L4JWf24pr41hB._f5ctqAmdNsZ889UjM4LxDm8WGxA(skeletonMeshRenderer_0, float_0: base._fO7gSlrDDNMoHR4FO5QXAq8fUyA, texture2D_0: _1AqpgY4vB6ly5vxOay6j86rcIEo, func_0: _YwAdHC5A5VB16lereNxJLkAP3Z9A, nullable_0: _IvIFs0Tl6RHdTn3daJXsNCXCNyO ? new Color?(new Color(1, 0, 0, 1)) : null);
		}
	}

	protected override void _aAoZaDNczeScsMfLlGSfAzey9SQ(string string_0, float float_0)
	{
		_1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ(string_0, float_0);
	}

	private void _4nhWi4RWJVAsAaRiBUYVgLfEiCz(SkeletonMeshRenderer skeletonMeshRenderer_0)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		if (_xm9p2W8AbxEBdrI3wbC7knvB06R.HasValue && _smM3y5A19la8hNpeOINXXDeitDH[_xm9p2W8AbxEBdrI3wbC7knvB06R.Value] != null)
		{
			_eBuDnRXeABWf8uwfsN15PfKEHw eBuDnRXeABWf8uwfsN15PfKEHw = _smM3y5A19la8hNpeOINXXDeitDH[_xm9p2W8AbxEBdrI3wbC7knvB06R.Value];
			RenderTargetBinding[] renderTargetBinding_ = _tfDAeR6npiqJMLRSXPO1DxGA0TgA.smethod_8(base._ZzBuoSDMWwerejOO9Goyv2OCKgE._2yepMkVENnecIsduggABaU2qhXW);
			_tfDAeR6npiqJMLRSXPO1DxGA0TgA.smethod_9(base._ZzBuoSDMWwerejOO9Goyv2OCKgE._2yepMkVENnecIsduggABaU2qhXW, eBuDnRXeABWf8uwfsN15PfKEHw._Z5JOwYZpe1u3WDYizFmDS7dmAcK);
			_tfDAeR6npiqJMLRSXPO1DxGA0TgA.smethod_10(base._ZzBuoSDMWwerejOO9Goyv2OCKgE._2yepMkVENnecIsduggABaU2qhXW, Color.get_Transparent());
			_1BgOJ3z4ZUXNS2L4JWf24pr41hB._7Xn1C5tjYnmIif1iZKV8AWsEEbL = eBuDnRXeABWf8uwfsN15PfKEHw._Jh6AK28sBy2bS8ZCoKHP3LX45Uk.X;
			_1BgOJ3z4ZUXNS2L4JWf24pr41hB._bCjZ3VSXGKyhmykd2zCnQBiSpDf = eBuDnRXeABWf8uwfsN15PfKEHw._Jh6AK28sBy2bS8ZCoKHP3LX45Uk.Y;
			_1BgOJ3z4ZUXNS2L4JWf24pr41hB._f5ctqAmdNsZ889UjM4LxDm8WGxA(skeletonMeshRenderer_0, float_0: base._fO7gSlrDDNMoHR4FO5QXAq8fUyA, texture2D_0: _1AqpgY4vB6ly5vxOay6j86rcIEo, func_0: _YwAdHC5A5VB16lereNxJLkAP3Z9A);
			_tfDAeR6npiqJMLRSXPO1DxGA0TgA.smethod_11(base._ZzBuoSDMWwerejOO9Goyv2OCKgE._2yepMkVENnecIsduggABaU2qhXW, renderTargetBinding_);
		}
	}

	protected override bool _BbDRof5yB0Qn864T1KJxUzMy8di(int int_0)
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		if (int_0 == 0)
		{
			_KouBKjmDwRJIjRK4fKJ8PzNn9uV = base._9m9LEAgaqaeXydYhykSBmf9BrDG;
		}
		else if (int_0 != 1)
		{
			if (int_0 >= 2)
			{
				_xm9p2W8AbxEBdrI3wbC7knvB06R = null;
				return false;
			}
		}
		else if (_KouBKjmDwRJIjRK4fKJ8PzNn9uV == base._9m9LEAgaqaeXydYhykSBmf9BrDG)
		{
			return false;
		}
		_7sgRQPgr8EJYjFmEXCYagaObJd0 = true;
		_xm9p2W8AbxEBdrI3wbC7knvB06R = int_0;
		_FdDzmVlp0fgTsGUxfkRfLr0dxtF = false;
		_1BgOJ3z4ZUXNS2L4JWf24pr41hB._7Xn1C5tjYnmIif1iZKV8AWsEEbL = 0f;
		_1BgOJ3z4ZUXNS2L4JWf24pr41hB._bCjZ3VSXGKyhmykd2zCnQBiSpDf = 0f;
		_YWKqVMq3bCWDIv73VmJykYuZBKN._tiBFUHPEkedkbgvuX3whdeyjhKo(_1BgOJ3z4ZUXNS2L4JWf24pr41hB._4puDGlIwmnebKpz1JXzxe4GDuJ4);
		Vector2 val = default(Vector2);
		((Vector2)(ref val))._002Ector((float)(int)_YWKqVMq3bCWDIv73VmJykYuZBKN._je8rVfyg4zywmqSi4Ozx1z7wJ4b, (float)(int)_YWKqVMq3bCWDIv73VmJykYuZBKN._WJfGWBzn4wgdGBnMWRH2pcJ3AqH);
		if (!(val.X <= 0f) && val.Y > 0f)
		{
			_smM3y5A19la8hNpeOINXXDeitDH[int_0] = new _eBuDnRXeABWf8uwfsN15PfKEHw
			{
				_Jh6AK28sBy2bS8ZCoKHP3LX45Uk = new Vector2(_tfDAeR6npiqJMLRSXPO1DxGA0TgA.smethod_13(_tfDAeR6npiqJMLRSXPO1DxGA0TgA.smethod_12(_1BgOJ3z4ZUXNS2L4JWf24pr41hB._4puDGlIwmnebKpz1JXzxe4GDuJ4)) - _YWKqVMq3bCWDIv73VmJykYuZBKN._SjhHztt8d5kOtb7Z2BJKnZZxEKh, _tfDAeR6npiqJMLRSXPO1DxGA0TgA.smethod_14(_tfDAeR6npiqJMLRSXPO1DxGA0TgA.smethod_12(_1BgOJ3z4ZUXNS2L4JWf24pr41hB._4puDGlIwmnebKpz1JXzxe4GDuJ4)) - _YWKqVMq3bCWDIv73VmJykYuZBKN._xqxFKfudZYzf8RtrC7EB1Ya6FPT),
				_Z5JOwYZpe1u3WDYizFmDS7dmAcK = new RenderTarget2D(base._ZzBuoSDMWwerejOO9Goyv2OCKgE._2yepMkVENnecIsduggABaU2qhXW, (int)val.X, (int)val.Y),
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
			_tfDAeR6npiqJMLRSXPO1DxGA0TgA.smethod_15((GraphicsResource)(object)_smM3y5A19la8hNpeOINXXDeitDH[0]._Z5JOwYZpe1u3WDYizFmDS7dmAcK);
			_smM3y5A19la8hNpeOINXXDeitDH[0] = null;
		}
		if (_smM3y5A19la8hNpeOINXXDeitDH[1] != null)
		{
			_tfDAeR6npiqJMLRSXPO1DxGA0TgA.smethod_15((GraphicsResource)(object)_smM3y5A19la8hNpeOINXXDeitDH[1]._Z5JOwYZpe1u3WDYizFmDS7dmAcK);
			_smM3y5A19la8hNpeOINXXDeitDH[1] = null;
		}
	}

	static void smethod_5(SpriteBatch spriteBatch_0)
	{
		spriteBatch_0.Begin();
	}

	static int smethod_6(Texture2D texture2D_0)
	{
		return texture2D_0.get_Width();
	}

	static int smethod_7(Texture2D texture2D_0)
	{
		return texture2D_0.get_Height();
	}

	static RenderTargetBinding[] smethod_8(GraphicsDevice graphicsDevice_0)
	{
		return graphicsDevice_0.GetRenderTargets();
	}

	static void smethod_9(GraphicsDevice graphicsDevice_0, RenderTarget2D renderTarget2D_0)
	{
		graphicsDevice_0.SetRenderTarget(renderTarget2D_0);
	}

	static void smethod_10(GraphicsDevice graphicsDevice_0, Color color_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		graphicsDevice_0.Clear(color_0);
	}

	static void smethod_11(GraphicsDevice graphicsDevice_0, RenderTargetBinding[] renderTargetBinding_0)
	{
		graphicsDevice_0.SetRenderTargets(renderTargetBinding_0);
	}

	static Bone smethod_12(Skeleton skeleton_0)
	{
		return skeleton_0.get_RootBone();
	}

	static float smethod_13(Bone bone_0)
	{
		return bone_0.get_WorldX();
	}

	static float smethod_14(Bone bone_0)
	{
		return bone_0.get_WorldY();
	}

	static void smethod_15(GraphicsResource graphicsResource_0)
	{
		graphicsResource_0.Dispose();
	}
}
