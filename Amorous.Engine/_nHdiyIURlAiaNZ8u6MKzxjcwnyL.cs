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
			return _Q9MbCV832IUbkbrMWYaOkMJU5BhA.X;
		}
		set
		{
			_Q9MbCV832IUbkbrMWYaOkMJU5BhA.X = value;
			_Q9MbCV832IUbkbrMWYaOkMJU5BhA.UpdateWorldTransform();
		}
	}

	public float _bCjZ3VSXGKyhmykd2zCnQBiSpDf
	{
		get
		{
			return _Q9MbCV832IUbkbrMWYaOkMJU5BhA.Y;
		}
		set
		{
			_Q9MbCV832IUbkbrMWYaOkMJU5BhA.Y = value;
			_Q9MbCV832IUbkbrMWYaOkMJU5BhA.UpdateWorldTransform();
		}
	}

	public bool _Hwt6L2NJfXmAfG6UOH8NVlNfGCR
	{
		get
		{
			return _Q9MbCV832IUbkbrMWYaOkMJU5BhA.FlipX;
		}
		set
		{
			_Q9MbCV832IUbkbrMWYaOkMJU5BhA.FlipX = value;
		}
	}

	public bool _mfKvSYDXt3O00aq0azjwApGdK7d
	{
		get
		{
			return _Q9MbCV832IUbkbrMWYaOkMJU5BhA.FlipY;
		}
		set
		{
			_Q9MbCV832IUbkbrMWYaOkMJU5BhA.FlipY = value;
		}
	}

	public Skeleton _4puDGlIwmnebKpz1JXzxe4GDuJ4 => _Q9MbCV832IUbkbrMWYaOkMJU5BhA;

	public _nHdiyIURlAiaNZ8u6MKzxjcwnyL(Skeleton skeleton_0, bool bool_0)
	{
		_Q9MbCV832IUbkbrMWYaOkMJU5BhA = skeleton_0;
		_Ssp18W0I7HLX3YToPSudCzKuDjF = bool_0;
		AnimationStateData data = new AnimationStateData(_Q9MbCV832IUbkbrMWYaOkMJU5BhA.Data);
		_ZVtUyMscIM54gezcLdBBhUCeVAv = new AnimationState(data);
		_ZVtUyMscIM54gezcLdBBhUCeVAv.Complete += _d8vi3xWGR3jH0bzxGSAJiLYtNKc;
		_ZVtUyMscIM54gezcLdBBhUCeVAv.End += _KVZ9mWydLEUb3C7nVtUyDaNJ1wc;
		_ZVtUyMscIM54gezcLdBBhUCeVAv.Event += delegate(AnimationState animationState_0, int int_0, Event event_0)
		{
			if (_iUyagF1KTeSUlg0raFfzuot3CwC != null)
			{
				_iUyagF1KTeSUlg0raFfzuot3CwC(event_0.Data.Name);
			}
		};
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
		_Q9MbCV832IUbkbrMWYaOkMJU5BhA.SetBonesToSetupPose();
	}

	public void _C5vPbZ72rpVMDWGuHxZuR5FNpAH(string string_0, Action<int> action_0 = null)
	{
		_ZVtUyMscIM54gezcLdBBhUCeVAv.SetAnimation(0, string_0, loop: true);
		_HCBewBkFBdxmny4dffH5y6pT7IWA = action_0;
		_8l6SZQ1ASWukUrnspv0IFQAjpji = false;
		_1JfcJXW8yr3gQAFuYaMfgav0PSV = 0;
		_YKPC9RPU26VoychJLT26gpzNlPR = null;
		_OmIU5xZ6Kmv1g8Y6LBtZlc8vCGG = false;
	}

	public void _SPUoP3ABwpgQinJfKUM5qBbYSvr(string string_0, Action action_0 = null)
	{
		_ZVtUyMscIM54gezcLdBBhUCeVAv.SetAnimation(0, string_0, loop: false);
		_HCBewBkFBdxmny4dffH5y6pT7IWA = null;
		_8l6SZQ1ASWukUrnspv0IFQAjpji = false;
		_1JfcJXW8yr3gQAFuYaMfgav0PSV = 0;
		_YKPC9RPU26VoychJLT26gpzNlPR = action_0;
		_OmIU5xZ6Kmv1g8Y6LBtZlc8vCGG = false;
	}

	public void _d6HoyBFhu6xkBRCX00ZzeFUnWwF()
	{
		_ZVtUyMscIM54gezcLdBBhUCeVAv.ClearTracks();
	}

	public void _zqRttWc6EZHjk1LAoNrCy0Qamk2(string string_0, string string_1, float float_0)
	{
		_ZVtUyMscIM54gezcLdBBhUCeVAv.Data.SetMix(string_0, string_1, float_0);
	}

	public void _a2lgCWeMj1Hr65gQZxslDkqeUdd(string string_0, bool bool_0 = false, float float_0 = 0f, Action<int> action_0 = null, Action action_1 = null)
	{
		_ZVtUyMscIM54gezcLdBBhUCeVAv.AddAnimation(0, string_0, bool_0, float_0);
		_HCBewBkFBdxmny4dffH5y6pT7IWA = action_0;
		_8l6SZQ1ASWukUrnspv0IFQAjpji = false;
		_1JfcJXW8yr3gQAFuYaMfgav0PSV = 0;
		_YKPC9RPU26VoychJLT26gpzNlPR = action_1;
		_OmIU5xZ6Kmv1g8Y6LBtZlc8vCGG = false;
	}

	public void _aAoZaDNczeScsMfLlGSfAzey9SQ(string string_0, float float_0)
	{
		if (!string.IsNullOrEmpty(string_0))
		{
			Slot slot = _Q9MbCV832IUbkbrMWYaOkMJU5BhA.FindSlot(string_0);
			if (slot != null)
			{
				slot.A = float_0;
			}
		}
	}

	public void _VoeevpFh2kLKfHtpPDXWt0TFbuH(string string_0, Color color_0)
	{
		_VoeevpFh2kLKfHtpPDXWt0TFbuH(string_0, (float)(int)color_0.R / 255f, (float)(int)color_0.G / 255f, (float)(int)color_0.B / 255f);
	}

	public void _VoeevpFh2kLKfHtpPDXWt0TFbuH(string string_0, float float_0, float float_1, float float_2)
	{
		if (!string.IsNullOrEmpty(string_0))
		{
			Slot slot = _Q9MbCV832IUbkbrMWYaOkMJU5BhA.FindSlot(string_0);
			if (slot != null)
			{
				slot.R = float_0;
				slot.G = float_1;
				slot.B = float_2;
			}
		}
	}

	public void _c4iC7y9v6xg7LpvjKIeUkOdZ3UF(float float_0)
	{
		foreach (Slot slot in _Q9MbCV832IUbkbrMWYaOkMJU5BhA.Slots)
		{
			slot.A = float_0;
		}
	}

	public bool _3nKd9Dk3YeX87QB5dROwYUzczsN(string string_0, float float_0, float float_1)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return false;
		}
		Slot slot = _Q9MbCV832IUbkbrMWYaOkMJU5BhA.FindSlot(string_0);
		if (slot != null && slot.Attachment is RegionAttachment)
		{
			RegionAttachment regionAttachment = slot.Attachment as RegionAttachment;
			float num = _Q9MbCV832IUbkbrMWYaOkMJU5BhA.X + slot.Bone.WorldX;
			float num2 = _Q9MbCV832IUbkbrMWYaOkMJU5BhA.Y + slot.Bone.WorldY;
			float m = slot.Bone.M00;
			float m2 = slot.Bone.M01;
			float m3 = slot.Bone.M10;
			float m4 = slot.Bone.M11;
			float[] offset = regionAttachment.Offset;
			float num3 = offset[0] * m + offset[1] * m2 + num;
			float num4 = offset[0] * m3 + offset[1] * m4 + num2;
			float num5 = offset[2] * m + offset[3] * m2 + num;
			float num6 = offset[2] * m3 + offset[3] * m4 + num2;
			float num7 = offset[4] * m + offset[5] * m2 + num;
			float num8 = offset[4] * m3 + offset[5] * m4 + num2;
			float num9 = num3 - num5;
			float num10 = num4 - num6;
			float num11 = num7 - num5;
			float num12 = num8 - num6;
			float num13 = num9 * num9 + num10 * num10;
			float num14 = num11 * num11 + num12 * num12;
			float num15 = float_0 - num5;
			float num16 = float_1 - num6;
			float num17 = num15 * num9 + num16 * num10;
			float num18 = num15 * num11 + num16 * num12;
			if (0f <= num17 && num17 <= num13)
			{
				if (0f <= num18)
				{
					return num18 <= num14;
				}
				return false;
			}
			return false;
		}
		return false;
	}

	public void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0, float float_0 = 1000f)
	{
		_ZVtUyMscIM54gezcLdBBhUCeVAv.Update((float)gameTime_0.ElapsedGameTime.Milliseconds / float_0);
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
		skeletonMeshRenderer_0.PremultipliedAlpha = _Ssp18W0I7HLX3YToPSudCzKuDjF;
		skeletonMeshRenderer_0.Begin(_7Xn1C5tjYnmIif1iZKV8AWsEEbL, _bCjZ3VSXGKyhmykd2zCnQBiSpDf, float_0);
		skeletonMeshRenderer_0.Draw(_Q9MbCV832IUbkbrMWYaOkMJU5BhA, texture2D_0, func_0, nullable_0);
		skeletonMeshRenderer_0.End();
	}

	public Point _0LlFMUVNTAixukJSTpecXFIxdAl(string string_0, out double double_0)
	{
		Slot slot = _Q9MbCV832IUbkbrMWYaOkMJU5BhA.FindSlot(string_0);
		if (slot != null && slot.Attachment is RegionAttachment)
		{
			RegionAttachment regionAttachment = slot.Attachment as RegionAttachment;
			float num = _Q9MbCV832IUbkbrMWYaOkMJU5BhA.X + slot.Bone.WorldX;
			float num2 = _Q9MbCV832IUbkbrMWYaOkMJU5BhA.Y + slot.Bone.WorldY;
			float m = slot.Bone.M00;
			float m2 = slot.Bone.M01;
			float m3 = slot.Bone.M10;
			float m4 = slot.Bone.M11;
			float[] offset = regionAttachment.Offset;
			float num3 = offset[2] * m + offset[3] * m2 + num;
			float num4 = offset[2] * m3 + offset[3] * m4 + num2;
			float num5 = offset[4] * m + offset[5] * m2 + num;
			float num6 = offset[4] * m3 + offset[5] * m4 + num2;
			double_0 = Math.Atan((num6 - num4) / (num5 - num3));
			return new Point((int)num3, (int)num4);
		}
		double_0 = 0.0;
		return Point.Zero;
	}

	public void _WPy6ICx3LVoejBaexyOoKGnX9jD(string string_0, float float_0)
	{
		Animation animation = _Q9MbCV832IUbkbrMWYaOkMJU5BhA.Data.FindAnimation(string_0);
		if (animation == null)
		{
			throw new ArgumentException("Animation not found: " + string_0);
		}
		animation.Apply(_Q9MbCV832IUbkbrMWYaOkMJU5BhA, 0f, float_0, loop: false, null);
	}

	public void _EasyNtsMRc39NOvWai1JUYTqcds(string string_0)
	{
		_Q9MbCV832IUbkbrMWYaOkMJU5BhA.SetSkin(string_0);
		_Q9MbCV832IUbkbrMWYaOkMJU5BhA.SetSlotsToSetupPose();
	}

	public void _eCEWplYE5FdfYPYTrwfyRlIfd6i(string string_0, string string_1)
	{
		Slot item = _4puDGlIwmnebKpz1JXzxe4GDuJ4.FindSlot(string_0);
		Slot item2 = _4puDGlIwmnebKpz1JXzxe4GDuJ4.FindSlot(string_1);
		_4puDGlIwmnebKpz1JXzxe4GDuJ4.DrawOrder.Remove(item);
		int num = _4puDGlIwmnebKpz1JXzxe4GDuJ4.DrawOrder.IndexOf(item2);
		_4puDGlIwmnebKpz1JXzxe4GDuJ4.DrawOrder.Insert(num + 1, item);
	}

	public void _49JXjKJqaPZw5nEmhHdAENuBtLJ(string string_0, float float_0)
	{
		_Q9MbCV832IUbkbrMWYaOkMJU5BhA.Data.FindAnimation(string_0).Duration += float_0;
	}

	[CompilerGenerated]
	private void _rOz7ZihvFmMpUcDtcmRWkVEY4ye(AnimationState animationState_0, int int_0, Event event_0)
	{
		if (_iUyagF1KTeSUlg0raFfzuot3CwC != null)
		{
			_iUyagF1KTeSUlg0raFfzuot3CwC(event_0.Data.Name);
		}
	}

	static float smethod_0(Skeleton skeleton_0)
	{
		return skeleton_0.X;
	}

	static void smethod_1(Skeleton skeleton_0, float float_0)
	{
		skeleton_0.X = float_0;
	}

	static void smethod_2(Skeleton skeleton_0)
	{
		skeleton_0.UpdateWorldTransform();
	}

	static float smethod_3(Skeleton skeleton_0)
	{
		return skeleton_0.Y;
	}

	static void smethod_4(Skeleton skeleton_0, float float_0)
	{
		skeleton_0.Y = float_0;
	}

	static bool smethod_5(Skeleton skeleton_0)
	{
		return skeleton_0.FlipX;
	}

	static void smethod_6(Skeleton skeleton_0, bool bool_0)
	{
		skeleton_0.FlipX = bool_0;
	}

	static bool smethod_7(Skeleton skeleton_0)
	{
		return skeleton_0.FlipY;
	}

	static void smethod_8(Skeleton skeleton_0, bool bool_0)
	{
		skeleton_0.FlipY = bool_0;
	}

	static SkeletonData smethod_9(Skeleton skeleton_0)
	{
		return skeleton_0.Data;
	}

	static AnimationStateData smethod_10(SkeletonData skeletonData_0)
	{
		return new AnimationStateData(skeletonData_0);
	}

	static AnimationState smethod_11(AnimationStateData animationStateData_0)
	{
		return new AnimationState(animationStateData_0);
	}

	static void smethod_12(AnimationState animationState_0, AnimationState.CompleteDelegate completeDelegate_0)
	{
		animationState_0.Complete += completeDelegate_0;
	}

	static void smethod_13(AnimationState animationState_0, AnimationState.StartEndDelegate startEndDelegate_0)
	{
		animationState_0.End += startEndDelegate_0;
	}

	static void smethod_14(AnimationState animationState_0, AnimationState.EventDelegate eventDelegate_0)
	{
		animationState_0.Event += eventDelegate_0;
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
		return animationState_0.Data;
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
		slot_0.A = float_0;
	}

	static void smethod_24(Slot slot_0, float float_0)
	{
		slot_0.R = float_0;
	}

	static void smethod_25(Slot slot_0, float float_0)
	{
		slot_0.G = float_0;
	}

	static void smethod_26(Slot slot_0, float float_0)
	{
		slot_0.B = float_0;
	}

	static ExposedList<Slot> smethod_27(Skeleton skeleton_0)
	{
		return skeleton_0.Slots;
	}

	static Attachment smethod_28(Slot slot_0)
	{
		return slot_0.Attachment;
	}

	static Bone smethod_29(Slot slot_0)
	{
		return slot_0.Bone;
	}

	static float smethod_30(Bone bone_0)
	{
		return bone_0.WorldX;
	}

	static float smethod_31(Bone bone_0)
	{
		return bone_0.WorldY;
	}

	static float smethod_32(Bone bone_0)
	{
		return bone_0.M00;
	}

	static float smethod_33(Bone bone_0)
	{
		return bone_0.M01;
	}

	static float smethod_34(Bone bone_0)
	{
		return bone_0.M10;
	}

	static float smethod_35(Bone bone_0)
	{
		return bone_0.M11;
	}

	static float[] smethod_36(RegionAttachment regionAttachment_0)
	{
		return regionAttachment_0.Offset;
	}

	static TimeSpan smethod_37(GameTime gameTime_0)
	{
		return gameTime_0.ElapsedGameTime;
	}

	static void smethod_38(SkeletonMeshRenderer skeletonMeshRenderer_0, bool bool_0)
	{
		skeletonMeshRenderer_0.PremultipliedAlpha = bool_0;
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
		return skeleton_0.DrawOrder;
	}

	static float smethod_50(Animation animation_0)
	{
		return animation_0.Duration;
	}

	static void smethod_51(Animation animation_0, float float_0)
	{
		animation_0.Duration = float_0;
	}

	static EventData smethod_52(Event event_0)
	{
		return event_0.Data;
	}

	static string smethod_53(EventData eventData_0)
	{
		return eventData_0.Name;
	}
}
