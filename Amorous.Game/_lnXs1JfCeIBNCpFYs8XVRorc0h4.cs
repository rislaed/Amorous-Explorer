using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Spine;

public class _lnXs1JfCeIBNCpFYs8XVRorc0h4 : SpineDrawableLayer
{
	private readonly SpineRenderer _9kpyWj69TJrEE13VPDWRIsYgsND;

	public override float OffsetX
	{
		get
		{
			return _9kpyWj69TJrEE13VPDWRIsYgsND.X;
		}
		set
		{
			_9kpyWj69TJrEE13VPDWRIsYgsND.X = value;
		}
	}

	public override float OffsetY
	{
		get
		{
			return _9kpyWj69TJrEE13VPDWRIsYgsND.Y;
		}
		set
		{
			_9kpyWj69TJrEE13VPDWRIsYgsND.Y = value;
		}
	}

	public _lnXs1JfCeIBNCpFYs8XVRorc0h4(AbstractScene scene)
		: base(scene, "Pool Water")
	{
		base.OnUpdate = delegate(GameTime gameTime)
		{
			_9kpyWj69TJrEE13VPDWRIsYgsND.Update(gameTime);
		};
		base.OnSpineDraw = delegate(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer)
		{
			_9kpyWj69TJrEE13VPDWRIsYgsND.Draw(skeletonMeshRenderer, null, null, null, Scale);
		};
		_9kpyWj69TJrEE13VPDWRIsYgsND = scene.Game.Content.LoadSkeleton("Assets/Scenes/ClubPool/Club Pool water");
		_9kpyWj69TJrEE13VPDWRIsYgsND.X = 0f;
		_9kpyWj69TJrEE13VPDWRIsYgsND.Y = 0f;
		_9kpyWj69TJrEE13VPDWRIsYgsND.StartAnimationWithLooping("animation");
	}
}
