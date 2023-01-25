using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Spine;

public class _lnXs1JfCeIBNCpFYs8XVRorc0h4 : _WBXNT6eIVGk6ZKExRBJ6JxXE6zb
{
	private readonly _nHdiyIURlAiaNZ8u6MKzxjcwnyL _9kpyWj69TJrEE13VPDWRIsYgsND;

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

	public _lnXs1JfCeIBNCpFYs8XVRorc0h4(AbstractScene AbstractScene_0)
		: base(AbstractScene_0, "Pool Water")
	{
		base._NC5P3SKqKPpcAYG1mqquUEcUzTg = delegate(GameTime gameTime_0)
		{
			_9kpyWj69TJrEE13VPDWRIsYgsND.Update(gameTime_0);
		};
		base._Wb2e00OWt8kBwGWEXtOGMVScRPm = delegate(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0)
		{
			_9kpyWj69TJrEE13VPDWRIsYgsND.Draw(skeletonMeshRenderer_0, null, null, null, _fO7gSlrDDNMoHR4FO5QXAq8fUyA);
		};
		_9kpyWj69TJrEE13VPDWRIsYgsND = AbstractScene_0.Game._uwNDZuqdFb9tyQtlQMxiz1DQ7x8._7BVREQXEcBCieHb0qgaVDpUj1ni("Assets/Scenes/ClubPool/Club Pool water");
		_9kpyWj69TJrEE13VPDWRIsYgsND.X = 0f;
		_9kpyWj69TJrEE13VPDWRIsYgsND.Y = 0f;
		_9kpyWj69TJrEE13VPDWRIsYgsND._C5vPbZ72rpVMDWGuHxZuR5FNpAH("animation");
	}
}
