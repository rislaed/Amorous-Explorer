using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Spine;

public class _lnXs1JfCeIBNCpFYs8XVRorc0h4 : _WBXNT6eIVGk6ZKExRBJ6JxXE6zb
{
	private readonly SpineRenderer _9kpyWj69TJrEE13VPDWRIsYgsND;

	public override float _WBXNT6eIVGk6ZKExRBJ6JxXE6zb_002E_GDeKFFD8Rxnpsjzy36lUBxAEopc
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

	public override float _WBXNT6eIVGk6ZKExRBJ6JxXE6zb_002E_JpSvHH1W0gFCpaNEH5zB1qsDJXY
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
		base._NC5P3SKqKPpcAYG1mqquUEcUzTg = delegate(GameTime gameTime)
		{
			_9kpyWj69TJrEE13VPDWRIsYgsND.Update(gameTime);
		};
		base._Wb2e00OWt8kBwGWEXtOGMVScRPm = delegate(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer)
		{
			_9kpyWj69TJrEE13VPDWRIsYgsND.Draw(skeletonMeshRenderer, null, null, null, Scale);
		};
		_9kpyWj69TJrEE13VPDWRIsYgsND = scene.Game.Content._7BVREQXEcBCieHb0qgaVDpUj1ni("Assets/Scenes/ClubPool/Club Pool water");
		_9kpyWj69TJrEE13VPDWRIsYgsND.X = 0f;
		_9kpyWj69TJrEE13VPDWRIsYgsND.Y = 0f;
		_9kpyWj69TJrEE13VPDWRIsYgsND.StartAnimationWithLooping("animation");
	}
}
