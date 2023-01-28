using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Spine;

public class _99nxpM4875DlpTJ1IMF4j4oCXiD : SpineDrawableLayer
{
	private readonly SpineRenderer _aWAfh7vUNHnjdyRPQNHL6D9yrCg;

	public override float OffsetX
	{
		get
		{
			return _aWAfh7vUNHnjdyRPQNHL6D9yrCg.X;
		}
		set
		{
			_aWAfh7vUNHnjdyRPQNHL6D9yrCg.X = value;
		}
	}

	public override float OffsetY
	{
		get
		{
			return _aWAfh7vUNHnjdyRPQNHL6D9yrCg.Y;
		}
		set
		{
			_aWAfh7vUNHnjdyRPQNHL6D9yrCg.Y = value;
		}
	}

	public _99nxpM4875DlpTJ1IMF4j4oCXiD(AbstractScene scene)
		: base(scene, "Campfire")
	{
		base.OnUpdate = delegate(GameTime gameTime)
		{
			_aWAfh7vUNHnjdyRPQNHL6D9yrCg.Update(gameTime);
		};
		base.OnSpineDraw = delegate(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer)
		{
			_aWAfh7vUNHnjdyRPQNHL6D9yrCg.Draw(skeletonMeshRenderer, null, null, null, Scale);
		};
		_aWAfh7vUNHnjdyRPQNHL6D9yrCg = scene.Game.Content.LoadSkeleton("Assets/Scenes/Campfire/Campfire");
		_aWAfh7vUNHnjdyRPQNHL6D9yrCg.X = 960f;
		_aWAfh7vUNHnjdyRPQNHL6D9yrCg.Y = 540f;
		_aWAfh7vUNHnjdyRPQNHL6D9yrCg.StartAnimationWithLooping("animation");
	}
}
