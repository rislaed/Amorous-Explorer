using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spine;

public class SpineRenderer
{
	public Action<string> OnAnimationFrame;

	private readonly Skeleton Skeleton;

	private readonly AnimationState Animation;

	private Action<int> LoopingAnimationCompleted;

	private bool IsAnimationCompleted;

	private int AnimationFrame;

	private Action AnimationEnded;

	private bool IsAnimationEnded;

	public bool PremultipliedAlpha { get; set; }

	public float X
	{
		get
		{
			return Skeleton.X;
		}
		set
		{
			Skeleton.X = value;
			Skeleton.UpdateWorldTransform();
		}
	}

	public float Y
	{
		get
		{
			return Skeleton.Y;
		}
		set
		{
			Skeleton.Y = value;
			Skeleton.UpdateWorldTransform();
		}
	}

	public bool FlipX
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

	public bool FlipY
	{
		get
		{
			return Skeleton.FlipY;
		}
		set
		{
			Skeleton.FlipY = value;
		}
	}

	public Skeleton Spine => Skeleton;

	public SpineRenderer(Skeleton skeleton, bool premultipliedAlpha)
	{
		Skeleton = skeleton;
		PremultipliedAlpha = premultipliedAlpha;
		AnimationStateData data = new AnimationStateData(Skeleton.Data);
		Animation = new AnimationState(data);
		Animation.Complete += CompleteAnimation;
		Animation.End += EndAnimation;
		Animation.Event += delegate(AnimationState animationState, int state, Event self)
		{
			if (OnAnimationFrame != null)
			{
				OnAnimationFrame(self.Data.Name);
			}
		};
	}

	private void CompleteAnimation(AnimationState animationState, int state1, int state2)
	{
		IsAnimationCompleted = true;
		AnimationFrame = state1;
	}

	private void EndAnimation(AnimationState animationState, int state)
	{
		IsAnimationEnded = true;
	}

	public void RestartAnimation()
	{
		Skeleton.SetBonesToSetupPose();
	}

	public void StartAnimationWithLooping(string animation, Action<int> onLoop = null)
	{
		Animation.SetAnimation(0, animation, loop: true);
		LoopingAnimationCompleted = onLoop;
		IsAnimationCompleted = false;
		AnimationFrame = 0;
		AnimationEnded = null;
		IsAnimationEnded = false;
	}

	public void StartAnimation(string animation, Action onEnd = null)
	{
		Animation.SetAnimation(0, animation, loop: false);
		LoopingAnimationCompleted = null;
		IsAnimationCompleted = false;
		AnimationFrame = 0;
		AnimationEnded = onEnd;
		IsAnimationEnded = false;
	}

	public void ResetAnimation()
	{
		Animation.ClearTracks();
	}

	public void SetMix(string animation1, string animation2, float mix)
	{
		Animation.Data.SetMix(animation1, animation2, mix);
	}

	public void AddAnimation(string animation, bool looping = false, float float_0 = 0f, Action<int> onLoop = null, Action onEnd = null)
	{
		Animation.AddAnimation(0, animation, looping, float_0);
		LoopingAnimationCompleted = onLoop;
		IsAnimationCompleted = false;
		AnimationFrame = 0;
		AnimationEnded = onEnd;
		IsAnimationEnded = false;
	}

	public void SetAlpha(string bone, float alpha)
	{
		if (!string.IsNullOrEmpty(bone))
		{
			Slot slot = Skeleton.FindSlot(bone);
			if (slot != null)
			{
				slot.A = alpha;
			}
		}
	}

	public void SetColor(string bone, Color color)
	{
		SetColor(bone, (float)(int)color.R / 255f, (float)(int)color.G / 255f, (float)(int)color.B / 255f);
	}

	public void SetColor(string bone, float r, float g, float b)
	{
		if (!string.IsNullOrEmpty(bone))
		{
			Slot slot = Skeleton.FindSlot(bone);
			if (slot != null)
			{
				slot.R = r;
				slot.G = g;
				slot.B = b;
			}
		}
	}

	public void SetVisibility(float a)
	{
		foreach (Slot slot in Skeleton.Slots)
		{
			slot.A = a;
		}
	}

	public bool InAttachment(string bone, float x, float y)
	{
		if (string.IsNullOrEmpty(bone))
		{
			return false;
		}
		Slot slot = Skeleton.FindSlot(bone);
		if (slot != null && slot.Attachment is RegionAttachment)
		{
			RegionAttachment regionAttachment = slot.Attachment as RegionAttachment;
			float num = Skeleton.X + slot.Bone.WorldX;
			float num2 = Skeleton.Y + slot.Bone.WorldY;
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
			float num15 = x - num5;
			float num16 = y - num6;
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

	public void Update(GameTime gameTime, float speed = 1000f)
	{
		Animation.Update((float)gameTime.ElapsedGameTime.Milliseconds / speed);
		Animation.Apply(Skeleton);
		Skeleton.UpdateWorldTransform();
		if (!IsAnimationEnded)
		{
			if (IsAnimationCompleted)
			{
				IsAnimationCompleted = false;
				if (LoopingAnimationCompleted != null)
				{
					LoopingAnimationCompleted(AnimationFrame);
				}
			}
		}
		else
		{
			IsAnimationEnded = false;
			if (AnimationEnded != null)
			{
				AnimationEnded();
			}
		}
	}

	public void Draw(SkeletonMeshRenderer skeletonMeshRenderer, Texture2D texture2D = null, Func<int, string, bool> func_0 = null, Color? nullable_0 = null, float float_0 = 1f)
	{
		skeletonMeshRenderer.PremultipliedAlpha = PremultipliedAlpha;
		skeletonMeshRenderer.Begin(X, Y, float_0);
		skeletonMeshRenderer.Draw(Skeleton, texture2D, func_0, nullable_0);
		skeletonMeshRenderer.End();
	}

	public Point GetDistanceDepth(string bone, out double depth)
	{
		Slot slot = Skeleton.FindSlot(bone);
		if (slot != null && slot.Attachment is RegionAttachment)
		{
			RegionAttachment regionAttachment = slot.Attachment as RegionAttachment;
			float num = Skeleton.X + slot.Bone.WorldX;
			float num2 = Skeleton.Y + slot.Bone.WorldY;
			float m = slot.Bone.M00;
			float m2 = slot.Bone.M01;
			float m3 = slot.Bone.M10;
			float m4 = slot.Bone.M11;
			float[] offset = regionAttachment.Offset;
			float num3 = offset[2] * m + offset[3] * m2 + num;
			float num4 = offset[2] * m3 + offset[3] * m4 + num2;
			float num5 = offset[4] * m + offset[5] * m2 + num;
			float num6 = offset[4] * m3 + offset[5] * m4 + num2;
			depth = Math.Atan((num6 - num4) / (num5 - num3));
			return new Point((int)num3, (int)num4);
		}
		depth = 0.0;
		return Point.Zero;
	}

	public void ApplyFrame(string bone, float frame)
	{
		Animation animation = Skeleton.Data.FindAnimation(bone);
		if (animation == null)
		{
			throw new ArgumentException("Animation not found: " + bone);
		}
		animation.Apply(Skeleton, 0f, frame, loop: false, null);
	}

	public void SetSkin(string variant)
	{
		Skeleton.SetSkin(variant);
		Skeleton.SetSlotsToSetupPose();
	}

	public void OverlayWith(string bone1, string bone2)
	{
		Slot slot1 = Spine.FindSlot(bone1);
		Slot slot2 = Spine.FindSlot(bone2);
		Spine.DrawOrder.Remove(slot1);
		int num = Spine.DrawOrder.IndexOf(slot2);
		Spine.DrawOrder.Insert(num + 1, slot1);
	}

	public void IncreaseDuration(string animation, float ms)
	{
		Skeleton.Data.FindAnimation(animation).Duration += ms;
	}
}
