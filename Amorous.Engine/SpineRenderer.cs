using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spine;

public class SpineRenderer
{ // _nHdiyIURlAiaNZ8u6MKzxjcwnyL
	public Action<string> OnAnimationFrame;

	private readonly Skeleton _skeleton;
	private readonly AnimationState _state;
	private Action<int> _onLoopingCompleted;
	private bool _animationCompleted;
	private int _index;
	private Action _onAnimationEnded;
	private bool _animationEnded;

	public bool PremultipliedAlpha { get; set; }

	public float X
	{
		get
		{
			return _skeleton.X;
		}
		set
		{
			_skeleton.X = value;
			_skeleton.UpdateWorldTransform();
		}
	}

	public float Y
	{
		get
		{
			return _skeleton.Y;
		}
		set
		{
			_skeleton.Y = value;
			_skeleton.UpdateWorldTransform();
		}
	}

	public bool FlipX
	{
		get
		{
			return _skeleton.FlipX;
		}
		set
		{
			_skeleton.FlipX = value;
		}
	}

	public bool FlipY
	{
		get
		{
			return _skeleton.FlipY;
		}
		set
		{
			_skeleton.FlipY = value;
		}
	}

	public Skeleton Spine => _skeleton;

	public SpineRenderer(Skeleton skeleton, bool premultipliedAlpha)
	{
		_skeleton = skeleton;
		PremultipliedAlpha = premultipliedAlpha;
		AnimationStateData data = new AnimationStateData(_skeleton.Data);
		_state = new AnimationState(data);
		_state.Complete += CompleteAnimation;
		_state.End += EndAnimation;
		_state.Event += delegate(AnimationState animationState, int state, Event self)
		{
			if (OnAnimationFrame != null)
			{
				OnAnimationFrame(self.Data.Name);
			}
		};
	}

	private void CompleteAnimation(AnimationState animationState, int state1, int state2)
	{
		_animationCompleted = true;
		_index = state1;
	}

	private void EndAnimation(AnimationState animationState, int state)
	{
		_animationEnded = true;
	}

	public void RestartAnimation()
	{
		_skeleton.SetBonesToSetupPose();
	}

	public void StartAnimationWithLooping(string animation, Action<int> onLoop = null)
	{
		_state.SetAnimation(0, animation, loop: true);
		_onLoopingCompleted = onLoop;
		_animationCompleted = false;
		_index = 0;
		_onAnimationEnded = null;
		_animationEnded = false;
	}

	public void StartAnimation(string animation, Action onEnd = null)
	{
		_state.SetAnimation(0, animation, loop: false);
		_onLoopingCompleted = null;
		_animationCompleted = false;
		_index = 0;
		_onAnimationEnded = onEnd;
		_animationEnded = false;
	}

	public void ResetAnimation()
	{
		_state.ClearTracks();
	}

	public void SetMix(string animation1, string animation2, float mix)
	{
		_state.Data.SetMix(animation1, animation2, mix);
	}

	public void AddAnimation(string animationName, bool looping = false, float delay = 0f, Action<int> onLoop = null, Action onEnd = null)
	{
		_state.AddAnimation(0, animationName, looping, delay);
		_onLoopingCompleted = onLoop;
		_animationCompleted = false;
		_index = 0;
		_onAnimationEnded = onEnd;
		_animationEnded = false;
	}

	public void SetAlpha(string bone, float alpha)
	{
		if (!string.IsNullOrEmpty(bone))
		{
			Slot slot = _skeleton.FindSlot(bone);
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
			Slot slot = _skeleton.FindSlot(bone);
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
		foreach (Slot slot in _skeleton.Slots)
		{
			slot.A = alpha;
		}
	}

	public bool InAttachment(string bone, float x, float y)
	{
		if (string.IsNullOrEmpty(bone))
		{
			return false;
		}
		Slot slot = _skeleton.FindSlot(bone);
		if (slot != null && slot.Attachment is RegionAttachment)
		{
			RegionAttachment regionAttachment = slot.Attachment as RegionAttachment;
			float worldX = _skeleton.X + slot.Bone.WorldX;
			float worldY = _skeleton.Y + slot.Bone.WorldY;
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
		_state.Update((float)gameTime.ElapsedGameTime.Milliseconds / speed);
		_state.Apply(_skeleton);
		_skeleton.UpdateWorldTransform();
		if (!_animationEnded)
		{
			if (_animationCompleted)
			{
				_animationCompleted = false;
				if (_onLoopingCompleted != null)
				{
					_onLoopingCompleted(_index);
				}
			}
		}
		else
		{
			_animationEnded = false;
			if (_onAnimationEnded != null)
			{
				_onAnimationEnded();
			}
		}
	}

	public void Draw(SkeletonMeshRenderer skeletonMeshRenderer, Texture2D overrideTexture = null, Func<int, string, bool> beforeRenderSlot = null, Color? overrideColor = null, float scale = 1f)
	{
		skeletonMeshRenderer.PremultipliedAlpha = PremultipliedAlpha;
		skeletonMeshRenderer.Begin(X, Y, scale);
		skeletonMeshRenderer.Draw(_skeleton, overrideTexture, beforeRenderSlot, overrideColor);
		skeletonMeshRenderer.End();
	}

	public Point GetDistanceDepth(string bone, out double depth)
	{
		Slot slot = _skeleton.FindSlot(bone);
		if (slot != null && slot.Attachment is RegionAttachment)
		{
			RegionAttachment regionAttachment = slot.Attachment as RegionAttachment;
			float num = _skeleton.X + slot.Bone.WorldX;
			float num2 = _skeleton.Y + slot.Bone.WorldY;
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
		Animation animation = _skeleton.Data.FindAnimation(bone);
		if (animation == null)
		{
			throw new ArgumentException("Animation not found: " + bone);
		}
		animation.Apply(_skeleton, 0f, frame, loop: false, null);
	}

	public void SetSkin(string variant)
	{
		_skeleton.SetSkin(variant);
		_skeleton.SetSlotsToSetupPose();
	}

	public void OverlayWith(string bone1, string bone2)
	{
		Slot slot1 = Spine.FindSlot(bone1);
		Slot slot2 = Spine.FindSlot(bone2);
		Spine.DrawOrder.Remove(slot1);
		int index = Spine.DrawOrder.IndexOf(slot2);
		Spine.DrawOrder.Insert(index + 1, slot1);
	}

	public void IncreaseDuration(string animation, float ms)
	{
		_skeleton.Data.FindAnimation(animation).Duration += ms;
	}
}
