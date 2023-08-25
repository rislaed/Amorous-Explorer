using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spine;

public class SkeletonRenderer
{ // _nHdiyIURlAiaNZ8u6MKzxjcwnyL
	public Action<string> OnAnimationFrame;

	private readonly Skeleton skeleton;
	private readonly AnimationState animationState;
	private Action<int> onLoopingCompleted;
	private bool animationCompleted;
	private int trackIndex;
	private Action onAnimationEnded;
	private bool animationEnded;

	public bool PremultipliedAlpha { get; set; }

	public float X
	{
		get
		{
			return skeleton.X;
		}
		set
		{
			skeleton.X = value;
			skeleton.UpdateWorldTransform();
		}
	}

	public float Y
	{
		get
		{
			return skeleton.Y;
		}
		set
		{
			skeleton.Y = value;
			skeleton.UpdateWorldTransform();
		}
	}

	public bool FlipX
	{
		get
		{
			return skeleton.FlipX;
		}
		set
		{
			skeleton.FlipX = value;
		}
	}

	public bool FlipY
	{
		get
		{
			return skeleton.FlipY;
		}
		set
		{
			skeleton.FlipY = value;
		}
	}

	public Skeleton Skeleton => skeleton;

	public SkeletonRenderer(Skeleton skeleton, bool premultipliedAlpha)
	{
		this.skeleton = skeleton;
		PremultipliedAlpha = premultipliedAlpha;
        AnimationStateData stateData = new AnimationStateData(this.skeleton.Data);
		animationState = new AnimationState(stateData);
		animationState.Complete += CompleteAnimation;
		animationState.End += EndAnimation;
		animationState.Event += delegate(AnimationState animationState, int state, Event @event)
		{
			if (OnAnimationFrame != null)
			{
				OnAnimationFrame(@event.Data.Name);
			}
		};
	}

	private void CompleteAnimation(AnimationState animationState, int trackIndex, int loopCount)
	{
		animationCompleted = true;
		this.trackIndex = trackIndex;
	}

	private void EndAnimation(AnimationState animationState, int trackIndex)
	{
		animationEnded = true;
	}

	public void RestartAnimation()
	{
		skeleton.SetBonesToSetupPose();
	}

	public void StartAnimationWithLooping(string animation, Action<int> onLoop = null)
	{
		animationState.SetAnimation(0, animation, loop: true);
		onLoopingCompleted = onLoop;
		animationCompleted = false;
		trackIndex = 0;
		onAnimationEnded = null;
		animationEnded = false;
	}

	public void StartAnimation(string animation, Action onEnd = null)
	{
		animationState.SetAnimation(0, animation, loop: false);
		onLoopingCompleted = null;
		animationCompleted = false;
		trackIndex = 0;
		onAnimationEnded = onEnd;
		animationEnded = false;
	}

	public void ResetAnimation()
	{
		animationState.ClearTracks();
	}

	public void SetMix(string animation1, string animation2, float duration)
	{
		animationState.Data.SetMix(animation1, animation2, duration);
	}

	public void AddAnimation(string animationName, bool loop = false, float delay = 0f, Action<int> onLoop = null, Action onEnd = null)
	{
		animationState.AddAnimation(0, animationName, loop, delay);
		onLoopingCompleted = onLoop;
		animationCompleted = false;
		trackIndex = 0;
		onAnimationEnded = onEnd;
		animationEnded = false;
	}

	public void SetAlpha(string slotName, float alpha)
	{
		if (!string.IsNullOrEmpty(slotName))
		{
			Slot slot = skeleton.FindSlot(slotName);
			if (slot != null)
			{
				slot.A = alpha;
			}
		}
	}

	public void SetColor(string slotName, Color color)
	{
		SetColor(slotName, (float)(int)color.R / 255f, (float)(int)color.G / 255f, (float)(int)color.B / 255f);
	}

	public void SetColor(string slotName, float r, float g, float b)
	{
		if (!string.IsNullOrEmpty(slotName))
		{
			Slot slot = skeleton.FindSlot(slotName);
			if (slot != null)
			{
				slot.R = r;
				slot.G = g;
				slot.B = b;
			}
		}
	}

	public void SetVisibility(float alpha)
	{
		foreach (Slot slot in skeleton.Slots)
		{
			slot.A = alpha;
		}
	}

	public bool Innersects(string slotName, float x, float y)
	{
		if (string.IsNullOrEmpty(slotName))
		{
			return false;
		}
		Slot slot = skeleton.FindSlot(slotName);
		if (slot != null && slot.Attachment is RegionAttachment)
		{
			RegionAttachment regionAttachment = slot.Attachment as RegionAttachment;
			float worldX = skeleton.X + slot.Bone.WorldX;
			float worldY = skeleton.Y + slot.Bone.WorldY;
			float m00 = slot.Bone.M00;
			float m01 = slot.Bone.M01;
			float m10 = slot.Bone.M10;
			float m11 = slot.Bone.M11;
			float[] offset = regionAttachment.Offset;
			float vx1 = offset[0] * m00 + offset[1] * m01 + worldX;
			float vy1 = offset[0] * m10 + offset[1] * m11 + worldY;
			float vx2 = offset[2] * m00 + offset[3] * m01 + worldX;
			float vy2 = offset[2] * m10 + offset[3] * m11 + worldY;
			float vx3 = offset[4] * m00 + offset[5] * m01 + worldX;
			float vy3 = offset[4] * m10 + offset[5] * m11 + worldY;
			float x1 = vx1 - vx2;
			float y1 = vy1 - vy2;
			float x2 = vx3 - vx2;
			float y2 = vy3 - vy2;
			float sqrt1 = x1 * x1 + y1 * y1;
			float sqrt2 = x2 * x2 + y2 * y2;
			float x0 = x - vx2;
			float y0 = y - vy2;
			float dst1 = x0 * x1 + y0 * y1;
			float dst2 = x0 * x2 + y0 * y2;
			if (0f <= dst1 && dst1 <= sqrt1)
			{
				if (0f <= dst2)
				{
					return dst2 <= sqrt2;
				}
				return false;
			}
			return false;
		}
		return false;
	}

	public void Update(GameTime gameTime, float speed = 1000f)
	{
		animationState.Update((float)gameTime.ElapsedGameTime.Milliseconds / speed);
		animationState.Apply(skeleton);
		skeleton.UpdateWorldTransform();
		if (!animationEnded)
		{
			if (animationCompleted)
			{
				animationCompleted = false;
				if (onLoopingCompleted != null)
				{
					onLoopingCompleted(trackIndex);
				}
			}
		}
		else
		{
			animationEnded = false;
			if (onAnimationEnded != null)
			{
				onAnimationEnded();
			}
		}
	}

	public void Draw(SkeletonMeshRenderer skeletonMeshRenderer, Texture2D overrideTexture = null, Func<int, string, bool> beforeRenderSlot = null, Color? overrideColor = null, float scale = 1f)
	{
		skeletonMeshRenderer.PremultipliedAlpha = PremultipliedAlpha;
		skeletonMeshRenderer.Begin(X, Y, scale);
		skeletonMeshRenderer.Draw(skeleton, overrideTexture, beforeRenderSlot, overrideColor);
		skeletonMeshRenderer.End();
	}

	public Point GetDistanceDepth(string slotName, out double depth)
	{
		Slot slot = skeleton.FindSlot(slotName);
		if (slot != null && slot.Attachment is RegionAttachment)
		{
			RegionAttachment regionAttachment = slot.Attachment as RegionAttachment;
			float num = skeleton.X + slot.Bone.WorldX;
			float num2 = skeleton.Y + slot.Bone.WorldY;
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

	public void ApplyTime(string slotName, float time)
	{
		Animation animation = skeleton.Data.FindAnimation(slotName);
		if (animation == null)
		{
			throw new ArgumentException("Animation not found: " + slotName);
		}
		animation.Apply(skeleton, 0f, time, loop: false, null);
	}

	public void SetSkin(string variant)
	{
		skeleton.SetSkin(variant);
		skeleton.SetSlotsToSetupPose();
	}

	public void OverlayWith(string bone1, string bone2)
	{
		Slot slot1 = Skeleton.FindSlot(bone1);
		Slot slot2 = Skeleton.FindSlot(bone2);
		Skeleton.DrawOrder.Remove(slot1);
		int index = Skeleton.DrawOrder.IndexOf(slot2);
		Skeleton.DrawOrder.Insert(index + 1, slot1);
	}

	public void IncreaseDuration(string animation, float ms)
	{
		skeleton.Data.FindAnimation(animation).Duration += ms;
	}
}
