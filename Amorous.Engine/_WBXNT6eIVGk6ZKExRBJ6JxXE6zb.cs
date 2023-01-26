using System;
using Microsoft.Xna.Framework.Graphics;
using Spine;

public class _WBXNT6eIVGk6ZKExRBJ6JxXE6zb : _fAUddQEKfZyemRb327NhM3GGlmzA
{
	public Action<SpriteBatch, SkeletonMeshRenderer> _Wb2e00OWt8kBwGWEXtOGMVScRPm { private get; set; }

	public virtual float _WBXNT6eIVGk6ZKExRBJ6JxXE6zb_002E_GDeKFFD8Rxnpsjzy36lUBxAEopc { get; set; }

	public virtual float _WBXNT6eIVGk6ZKExRBJ6JxXE6zb_002E_JpSvHH1W0gFCpaNEH5zB1qsDJXY { get; set; }

	public bool _zkHMlDFkja4TqmjdlHuZRCj8FCB { get; set; }

	public _WBXNT6eIVGk6ZKExRBJ6JxXE6zb(AbstractScene scene, string string_0)
		: base(scene, string_0)
	{
	}

	public void Draw(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer)
	{
		Draw(spriteBatch);
		_Wb2e00OWt8kBwGWEXtOGMVScRPm?.Invoke(spriteBatch, skeletonMeshRenderer);
	}
}
