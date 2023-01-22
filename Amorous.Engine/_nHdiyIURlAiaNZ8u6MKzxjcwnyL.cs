using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spine;

public class _nHdiyIURlAiaNZ8u6MKzxjcwnyL
{
	public Action<string> _iUyagF1KTeSUlg0raFfzuot3CwC;

	private readonly Skeleton _Q9MbCV832IUbkbrMWYaOkMJU5BhA;

	private readonly AnimationState _ZVtUyMscIM54gezcLdBBhUCeVAv;

	private Action<int> _HCBewBkFBdxmny4dffH5y6pT7IWA;

	private bool _8l6SZQ1ASWukUrnspv0IFQAjpji;

	private int _1JfcJXW8yr3gQAFuYaMfgav0PSV;

	private Action _YKPC9RPU26VoychJLT26gpzNlPR;

	private bool _OmIU5xZ6Kmv1g8Y6LBtZlc8vCGG;

	public bool _Ssp18W0I7HLX3YToPSudCzKuDjF { get; set; }

	public float _7Xn1C5tjYnmIif1iZKV8AWsEEbL
	{
		get
		{
			return _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_0(_Q9MbCV832IUbkbrMWYaOkMJU5BhA);
		}
		set
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_1(_Q9MbCV832IUbkbrMWYaOkMJU5BhA, value);
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_2(_Q9MbCV832IUbkbrMWYaOkMJU5BhA);
		}
	}

	public float _bCjZ3VSXGKyhmykd2zCnQBiSpDf
	{
		get
		{
			return _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_3(_Q9MbCV832IUbkbrMWYaOkMJU5BhA);
		}
		set
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_4(_Q9MbCV832IUbkbrMWYaOkMJU5BhA, value);
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_2(_Q9MbCV832IUbkbrMWYaOkMJU5BhA);
		}
	}

	public bool _Hwt6L2NJfXmAfG6UOH8NVlNfGCR
	{
		get
		{
			return _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_5(_Q9MbCV832IUbkbrMWYaOkMJU5BhA);
		}
		set
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_6(_Q9MbCV832IUbkbrMWYaOkMJU5BhA, value);
		}
	}

	public bool _mfKvSYDXt3O00aq0azjwApGdK7d
	{
		get
		{
			return _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_7(_Q9MbCV832IUbkbrMWYaOkMJU5BhA);
		}
		set
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_8(_Q9MbCV832IUbkbrMWYaOkMJU5BhA, value);
		}
	}

	public Skeleton _4puDGlIwmnebKpz1JXzxe4GDuJ4 => _Q9MbCV832IUbkbrMWYaOkMJU5BhA;

	public _nHdiyIURlAiaNZ8u6MKzxjcwnyL(Skeleton skeleton_0, bool bool_0)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		_Q9MbCV832IUbkbrMWYaOkMJU5BhA = skeleton_0;
		_Ssp18W0I7HLX3YToPSudCzKuDjF = bool_0;
		AnimationStateData animationStateData_ = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_10(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_9(_Q9MbCV832IUbkbrMWYaOkMJU5BhA));
		_ZVtUyMscIM54gezcLdBBhUCeVAv = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_11(animationStateData_);
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_12(_ZVtUyMscIM54gezcLdBBhUCeVAv, new CompleteDelegate(_d8vi3xWGR3jH0bzxGSAJiLYtNKc));
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_13(_ZVtUyMscIM54gezcLdBBhUCeVAv, new StartEndDelegate(_KVZ9mWydLEUb3C7nVtUyDaNJ1wc));
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_14(_ZVtUyMscIM54gezcLdBBhUCeVAv, (EventDelegate)delegate(AnimationState animationState_0, int int_0, Event event_0)
		{
			if (_iUyagF1KTeSUlg0raFfzuot3CwC != null)
			{
				_iUyagF1KTeSUlg0raFfzuot3CwC(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_53(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_52(event_0)));
			}
		});
	}

	private void _d8vi3xWGR3jH0bzxGSAJiLYtNKc(AnimationState animationState_0, int int_0, int int_1)
	{
		_8l6SZQ1ASWukUrnspv0IFQAjpji = true;
		_1JfcJXW8yr3gQAFuYaMfgav0PSV = int_1;
	}

	private void _KVZ9mWydLEUb3C7nVtUyDaNJ1wc(AnimationState animationState_0, int int_0)
	{
		_OmIU5xZ6Kmv1g8Y6LBtZlc8vCGG = true;
	}

	public void _lkaN4ygxDlKvzKEBuD7dRjrU20F()
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_15(_Q9MbCV832IUbkbrMWYaOkMJU5BhA);
	}

	public void _C5vPbZ72rpVMDWGuHxZuR5FNpAH(string string_0, Action<int> action_0 = null)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_16(_ZVtUyMscIM54gezcLdBBhUCeVAv, 0, string_0, bool_0: true);
		_HCBewBkFBdxmny4dffH5y6pT7IWA = action_0;
		_8l6SZQ1ASWukUrnspv0IFQAjpji = false;
		_1JfcJXW8yr3gQAFuYaMfgav0PSV = 0;
		_YKPC9RPU26VoychJLT26gpzNlPR = null;
		_OmIU5xZ6Kmv1g8Y6LBtZlc8vCGG = false;
	}

	public void _SPUoP3ABwpgQinJfKUM5qBbYSvr(string string_0, Action action_0 = null)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_16(_ZVtUyMscIM54gezcLdBBhUCeVAv, 0, string_0, bool_0: false);
		_HCBewBkFBdxmny4dffH5y6pT7IWA = null;
		_8l6SZQ1ASWukUrnspv0IFQAjpji = false;
		_1JfcJXW8yr3gQAFuYaMfgav0PSV = 0;
		_YKPC9RPU26VoychJLT26gpzNlPR = action_0;
		_OmIU5xZ6Kmv1g8Y6LBtZlc8vCGG = false;
	}

	public void _d6HoyBFhu6xkBRCX00ZzeFUnWwF()
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_17(_ZVtUyMscIM54gezcLdBBhUCeVAv);
	}

	public void _zqRttWc6EZHjk1LAoNrCy0Qamk2(string string_0, string string_1, float float_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_19(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_18(_ZVtUyMscIM54gezcLdBBhUCeVAv), string_0, string_1, float_0);
	}

	public void _a2lgCWeMj1Hr65gQZxslDkqeUdd(string string_0, bool bool_0 = false, float float_0 = 0f, Action<int> action_0 = null, Action action_1 = null)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_20(_ZVtUyMscIM54gezcLdBBhUCeVAv, 0, string_0, bool_0, float_0);
		_HCBewBkFBdxmny4dffH5y6pT7IWA = action_0;
		_8l6SZQ1ASWukUrnspv0IFQAjpji = false;
		_1JfcJXW8yr3gQAFuYaMfgav0PSV = 0;
		_YKPC9RPU26VoychJLT26gpzNlPR = action_1;
		_OmIU5xZ6Kmv1g8Y6LBtZlc8vCGG = false;
	}

	public void _aAoZaDNczeScsMfLlGSfAzey9SQ(string string_0, float float_0)
	{
		if (!_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_21(string_0))
		{
			Slot val = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_22(_Q9MbCV832IUbkbrMWYaOkMJU5BhA, string_0);
			if (val != null)
			{
				_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_23(val, float_0);
			}
		}
	}

	public void _VoeevpFh2kLKfHtpPDXWt0TFbuH(string string_0, Color color_0)
	{
		_VoeevpFh2kLKfHtpPDXWt0TFbuH(string_0, (float)(int)((Color)(ref color_0)).get_R() / 255f, (float)(int)((Color)(ref color_0)).get_G() / 255f, (float)(int)((Color)(ref color_0)).get_B() / 255f);
	}

	public void _VoeevpFh2kLKfHtpPDXWt0TFbuH(string string_0, float float_0, float float_1, float float_2)
	{
		if (!_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_21(string_0))
		{
			Slot val = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_22(_Q9MbCV832IUbkbrMWYaOkMJU5BhA, string_0);
			if (val != null)
			{
				_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_24(val, float_0);
				_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_25(val, float_1);
				_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_26(val, float_2);
			}
		}
	}

	public void _c4iC7y9v6xg7LpvjKIeUkOdZ3UF(float float_0)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<Slot> enumerator = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_27(_Q9MbCV832IUbkbrMWYaOkMJU5BhA).GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Slot current = enumerator.get_Current();
				_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_23(current, float_0);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
	}

	public bool _3nKd9Dk3YeX87QB5dROwYUzczsN(string string_0, float float_0, float float_1)
	{
		if (_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_21(string_0))
		{
			return false;
		}
		Slot val = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_22(_Q9MbCV832IUbkbrMWYaOkMJU5BhA, string_0);
		if (val != null && _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_28(val) is RegionAttachment)
		{
			Attachment obj = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_28(val);
			RegionAttachment regionAttachment_ = (RegionAttachment)(object)((obj is RegionAttachment) ? obj : null);
			float num = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_0(_Q9MbCV832IUbkbrMWYaOkMJU5BhA) + _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_30(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_29(val));
			float num2 = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_3(_Q9MbCV832IUbkbrMWYaOkMJU5BhA) + _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_31(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_29(val));
			float num3 = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_32(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_29(val));
			float num4 = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_33(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_29(val));
			float num5 = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_34(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_29(val));
			float num6 = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_35(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_29(val));
			float[] array = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_36(regionAttachment_);
			float num7 = array[0] * num3 + array[1] * num4 + num;
			float num8 = array[0] * num5 + array[1] * num6 + num2;
			float num9 = array[2] * num3 + array[3] * num4 + num;
			float num10 = array[2] * num5 + array[3] * num6 + num2;
			float num11 = array[4] * num3 + array[5] * num4 + num;
			float num12 = array[4] * num5 + array[5] * num6 + num2;
			float num13 = num7 - num9;
			float num14 = num8 - num10;
			float num15 = num11 - num9;
			float num16 = num12 - num10;
			float num17 = num13 * num13 + num14 * num14;
			float num18 = num15 * num15 + num16 * num16;
			float num19 = float_0 - num9;
			float num20 = float_1 - num10;
			float num21 = num19 * num13 + num20 * num14;
			float num22 = num19 * num15 + num20 * num16;
			if (0f <= num21 && num21 <= num17)
			{
				if (0f <= num22)
				{
					return num22 <= num18;
				}
				return false;
			}
			return false;
		}
		return false;
	}

	public void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0, float float_0 = 1000f)
	{
		_ZVtUyMscIM54gezcLdBBhUCeVAv.Update((float)_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_37(gameTime_0).Milliseconds / float_0);
		_ZVtUyMscIM54gezcLdBBhUCeVAv.Apply(_Q9MbCV832IUbkbrMWYaOkMJU5BhA);
		_Q9MbCV832IUbkbrMWYaOkMJU5BhA.UpdateWorldTransform();
		if (!_OmIU5xZ6Kmv1g8Y6LBtZlc8vCGG)
		{
			if (_8l6SZQ1ASWukUrnspv0IFQAjpji)
			{
				_8l6SZQ1ASWukUrnspv0IFQAjpji = false;
				if (_HCBewBkFBdxmny4dffH5y6pT7IWA != null)
				{
					_HCBewBkFBdxmny4dffH5y6pT7IWA(_1JfcJXW8yr3gQAFuYaMfgav0PSV);
				}
			}
		}
		else
		{
			_OmIU5xZ6Kmv1g8Y6LBtZlc8vCGG = false;
			if (_YKPC9RPU26VoychJLT26gpzNlPR != null)
			{
				_YKPC9RPU26VoychJLT26gpzNlPR();
			}
		}
	}

	public void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SkeletonMeshRenderer skeletonMeshRenderer_0, Texture2D texture2D_0 = null, Func<int, string, bool> func_0 = null, Color? nullable_0 = null, float float_0 = 1f)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_38(skeletonMeshRenderer_0, _Ssp18W0I7HLX3YToPSudCzKuDjF);
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_39(skeletonMeshRenderer_0, _7Xn1C5tjYnmIif1iZKV8AWsEEbL, _bCjZ3VSXGKyhmykd2zCnQBiSpDf, float_0);
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_40(skeletonMeshRenderer_0, _Q9MbCV832IUbkbrMWYaOkMJU5BhA, texture2D_0, func_0, nullable_0);
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_41(skeletonMeshRenderer_0);
	}

	public Point _0LlFMUVNTAixukJSTpecXFIxdAl(string string_0, out double double_0)
	{
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		Slot val = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_22(_Q9MbCV832IUbkbrMWYaOkMJU5BhA, string_0);
		if (val != null && _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_28(val) is RegionAttachment)
		{
			Attachment obj = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_28(val);
			RegionAttachment regionAttachment_ = (RegionAttachment)(object)((obj is RegionAttachment) ? obj : null);
			float num = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_0(_Q9MbCV832IUbkbrMWYaOkMJU5BhA) + _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_30(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_29(val));
			float num2 = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_3(_Q9MbCV832IUbkbrMWYaOkMJU5BhA) + _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_31(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_29(val));
			float num3 = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_32(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_29(val));
			float num4 = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_33(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_29(val));
			float num5 = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_34(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_29(val));
			float num6 = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_35(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_29(val));
			float[] array = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_36(regionAttachment_);
			float num7 = array[2] * num3 + array[3] * num4 + num;
			float num8 = array[2] * num5 + array[3] * num6 + num2;
			float num9 = array[4] * num3 + array[5] * num4 + num;
			float num10 = array[4] * num5 + array[5] * num6 + num2;
			double_0 = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_42((double)((num10 - num8) / (num9 - num7)));
			return new Point((int)num7, (int)num8);
		}
		double_0 = 0.0;
		return Point.get_Zero();
	}

	public void _WPy6ICx3LVoejBaexyOoKGnX9jD(string string_0, float float_0)
	{
		Animation val = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_43(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_9(_Q9MbCV832IUbkbrMWYaOkMJU5BhA), string_0);
		if (val == null)
		{
			throw _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_45(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_44("Animation not found: ", string_0));
		}
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_46(val, _Q9MbCV832IUbkbrMWYaOkMJU5BhA, 0f, float_0, bool_0: false, (ExposedList<Event>)null);
	}

	public void _EasyNtsMRc39NOvWai1JUYTqcds(string string_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_47(_Q9MbCV832IUbkbrMWYaOkMJU5BhA, string_0);
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_48(_Q9MbCV832IUbkbrMWYaOkMJU5BhA);
	}

	public void _eCEWplYE5FdfYPYTrwfyRlIfd6i(string string_0, string string_1)
	{
		Slot val = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_22(_4puDGlIwmnebKpz1JXzxe4GDuJ4, string_0);
		Slot val2 = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_22(_4puDGlIwmnebKpz1JXzxe4GDuJ4, string_1);
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_49(_4puDGlIwmnebKpz1JXzxe4GDuJ4).Remove(val);
		int num = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_49(_4puDGlIwmnebKpz1JXzxe4GDuJ4).IndexOf(val2);
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_49(_4puDGlIwmnebKpz1JXzxe4GDuJ4).Insert(num + 1, val);
	}

	public void _49JXjKJqaPZw5nEmhHdAENuBtLJ(string string_0, float float_0)
	{
		Animation animation_ = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_43(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_9(_Q9MbCV832IUbkbrMWYaOkMJU5BhA), string_0);
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_51(animation_, _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_50(animation_) + float_0);
	}

	[CompilerGenerated]
	private void _rOz7ZihvFmMpUcDtcmRWkVEY4ye(AnimationState animationState_0, int int_0, Event event_0)
	{
		if (_iUyagF1KTeSUlg0raFfzuot3CwC != null)
		{
			_iUyagF1KTeSUlg0raFfzuot3CwC(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_53(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_52(event_0)));
		}
	}

	static float smethod_0(Skeleton skeleton_0)
	{
		return skeleton_0.get_X();
	}

	static void smethod_1(Skeleton skeleton_0, float float_0)
	{
		skeleton_0.set_X(float_0);
	}

	static void smethod_2(Skeleton skeleton_0)
	{
		skeleton_0.UpdateWorldTransform();
	}

	static float smethod_3(Skeleton skeleton_0)
	{
		return skeleton_0.get_Y();
	}

	static void smethod_4(Skeleton skeleton_0, float float_0)
	{
		skeleton_0.set_Y(float_0);
	}

	static bool smethod_5(Skeleton skeleton_0)
	{
		return skeleton_0.get_FlipX();
	}

	static void smethod_6(Skeleton skeleton_0, bool bool_0)
	{
		skeleton_0.set_FlipX(bool_0);
	}

	static bool smethod_7(Skeleton skeleton_0)
	{
		return skeleton_0.get_FlipY();
	}

	static void smethod_8(Skeleton skeleton_0, bool bool_0)
	{
		skeleton_0.set_FlipY(bool_0);
	}

	static SkeletonData smethod_9(Skeleton skeleton_0)
	{
		return skeleton_0.get_Data();
	}

	static AnimationStateData smethod_10(SkeletonData skeletonData_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new AnimationStateData(skeletonData_0);
	}

	static AnimationState smethod_11(AnimationStateData animationStateData_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new AnimationState(animationStateData_0);
	}

	static void smethod_12(AnimationState animationState_0, CompleteDelegate completeDelegate_0)
	{
		animationState_0.add_Complete(completeDelegate_0);
	}

	static void smethod_13(AnimationState animationState_0, StartEndDelegate startEndDelegate_0)
	{
		animationState_0.add_End(startEndDelegate_0);
	}

	static void smethod_14(AnimationState animationState_0, EventDelegate eventDelegate_0)
	{
		animationState_0.add_Event(eventDelegate_0);
	}

	static void smethod_15(Skeleton skeleton_0)
	{
		skeleton_0.SetBonesToSetupPose();
	}

	static TrackEntry smethod_16(AnimationState animationState_0, int int_0, string string_0, bool bool_0)
	{
		return animationState_0.SetAnimation(int_0, string_0, bool_0);
	}

	static void smethod_17(AnimationState animationState_0)
	{
		animationState_0.ClearTracks();
	}

	static AnimationStateData smethod_18(AnimationState animationState_0)
	{
		return animationState_0.get_Data();
	}

	static void smethod_19(AnimationStateData animationStateData_0, string string_0, string string_1, float float_0)
	{
		animationStateData_0.SetMix(string_0, string_1, float_0);
	}

	static TrackEntry smethod_20(AnimationState animationState_0, int int_0, string string_0, bool bool_0, float float_0)
	{
		return animationState_0.AddAnimation(int_0, string_0, bool_0, float_0);
	}

	static bool smethod_21(string string_0)
	{
		return string.IsNullOrEmpty(string_0);
	}

	static Slot smethod_22(Skeleton skeleton_0, string string_0)
	{
		return skeleton_0.FindSlot(string_0);
	}

	static void smethod_23(Slot slot_0, float float_0)
	{
		slot_0.set_A(float_0);
	}

	static void smethod_24(Slot slot_0, float float_0)
	{
		slot_0.set_R(float_0);
	}

	static void smethod_25(Slot slot_0, float float_0)
	{
		slot_0.set_G(float_0);
	}

	static void smethod_26(Slot slot_0, float float_0)
	{
		slot_0.set_B(float_0);
	}

	static ExposedList<Slot> smethod_27(Skeleton skeleton_0)
	{
		return skeleton_0.get_Slots();
	}

	static Attachment smethod_28(Slot slot_0)
	{
		return slot_0.get_Attachment();
	}

	static Bone smethod_29(Slot slot_0)
	{
		return slot_0.get_Bone();
	}

	static float smethod_30(Bone bone_0)
	{
		return bone_0.get_WorldX();
	}

	static float smethod_31(Bone bone_0)
	{
		return bone_0.get_WorldY();
	}

	static float smethod_32(Bone bone_0)
	{
		return bone_0.get_M00();
	}

	static float smethod_33(Bone bone_0)
	{
		return bone_0.get_M01();
	}

	static float smethod_34(Bone bone_0)
	{
		return bone_0.get_M10();
	}

	static float smethod_35(Bone bone_0)
	{
		return bone_0.get_M11();
	}

	static float[] smethod_36(RegionAttachment regionAttachment_0)
	{
		return regionAttachment_0.get_Offset();
	}

	static TimeSpan smethod_37(GameTime gameTime_0)
	{
		return gameTime_0.get_ElapsedGameTime();
	}

	static void smethod_38(SkeletonMeshRenderer skeletonMeshRenderer_0, bool bool_0)
	{
		skeletonMeshRenderer_0.set_PremultipliedAlpha(bool_0);
	}

	static void smethod_39(SkeletonMeshRenderer skeletonMeshRenderer_0, float float_0, float float_1, float float_2)
	{
		skeletonMeshRenderer_0.Begin(float_0, float_1, float_2);
	}

	static void smethod_40(SkeletonMeshRenderer skeletonMeshRenderer_0, Skeleton skeleton_0, Texture2D texture2D_0, Func<int, string, bool> func_0, Color? nullable_0)
	{
		skeletonMeshRenderer_0.Draw(skeleton_0, texture2D_0, func_0, nullable_0);
	}

	static void smethod_41(SkeletonMeshRenderer skeletonMeshRenderer_0)
	{
		skeletonMeshRenderer_0.End();
	}

	static double smethod_42(double double_0)
	{
		return Math.Atan(double_0);
	}

	static Animation smethod_43(SkeletonData skeletonData_0, string string_0)
	{
		return skeletonData_0.FindAnimation(string_0);
	}

	static string smethod_44(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static ArgumentException smethod_45(string string_0)
	{
		return new ArgumentException(string_0);
	}

	static void smethod_46(Animation animation_0, Skeleton skeleton_0, float float_0, float float_1, bool bool_0, ExposedList<Event> exposedList_0)
	{
		animation_0.Apply(skeleton_0, float_0, float_1, bool_0, exposedList_0);
	}

	static void smethod_47(Skeleton skeleton_0, string string_0)
	{
		skeleton_0.SetSkin(string_0);
	}

	static void smethod_48(Skeleton skeleton_0)
	{
		skeleton_0.SetSlotsToSetupPose();
	}

	static ExposedList<Slot> smethod_49(Skeleton skeleton_0)
	{
		return skeleton_0.get_DrawOrder();
	}

	static float smethod_50(Animation animation_0)
	{
		return animation_0.get_Duration();
	}

	static void smethod_51(Animation animation_0, float float_0)
	{
		animation_0.set_Duration(float_0);
	}

	static EventData smethod_52(Event event_0)
	{
		return event_0.get_Data();
	}

	static string smethod_53(EventData eventData_0)
	{
		return eventData_0.get_Name();
	}
}
