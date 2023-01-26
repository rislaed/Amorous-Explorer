using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Spine;

public class _99nxpM4875DlpTJ1IMF4j4oCXiD : _WBXNT6eIVGk6ZKExRBJ6JxXE6zb
{
	private readonly SpineRenderer _aWAfh7vUNHnjdyRPQNHL6D9yrCg;

	public override float _WBXNT6eIVGk6ZKExRBJ6JxXE6zb_002E_GDeKFFD8Rxnpsjzy36lUBxAEopc
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

	public override float _WBXNT6eIVGk6ZKExRBJ6JxXE6zb_002E_JpSvHH1W0gFCpaNEH5zB1qsDJXY
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
		base._NC5P3SKqKPpcAYG1mqquUEcUzTg = delegate(GameTime gameTime)
		{
			_aWAfh7vUNHnjdyRPQNHL6D9yrCg.Update(gameTime);
		};
		base._Wb2e00OWt8kBwGWEXtOGMVScRPm = delegate(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer)
		{
			_aWAfh7vUNHnjdyRPQNHL6D9yrCg.Draw(skeletonMeshRenderer, null, null, null, Scale);
		};
		_aWAfh7vUNHnjdyRPQNHL6D9yrCg = scene.Game.Content._7BVREQXEcBCieHb0qgaVDpUj1ni("Assets/Scenes/Campfire/Campfire");
		_aWAfh7vUNHnjdyRPQNHL6D9yrCg.X = 960f;
		_aWAfh7vUNHnjdyRPQNHL6D9yrCg.Y = 540f;
		_aWAfh7vUNHnjdyRPQNHL6D9yrCg.StartAnimationWithLooping("animation");
	}
}
