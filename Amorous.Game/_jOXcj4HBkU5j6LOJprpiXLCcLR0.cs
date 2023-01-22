using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Spine;

public class _jOXcj4HBkU5j6LOJprpiXLCcLR0 : _WBXNT6eIVGk6ZKExRBJ6JxXE6zb
{
	[CompilerGenerated]
	private sealed class _O8G74kUThoRhYWCOb1McUKcqi8A
	{
		public _jOXcj4HBkU5j6LOJprpiXLCcLR0 _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA;

		public float _dEj1SINFcMo2azAbZIsDW2P7BQF;

		public Rectangle _YqYs2NQHqpJMOFO0oHumIz6vgVd;

		public bool _z63evmklawgrVTepZWr3BQhfZCK;

		internal void _AtlCt23YoD9ontZAyHWAtQfyKTU(GameTime gameTime_0)
		{
			_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._9kpyWj69TJrEE13VPDWRIsYgsND._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
		}
	}

	[CompilerGenerated]
	private sealed class _BS7sXLmK84E2giYA4cGbwz26Ycx
	{
		public RenderTarget2D _YazjYDLENT6HQ0JTluCcQMsqZaB;

		public Texture2D _0NizriMRCkKJuXStgvnNKe6Lo4y;

		public Effect _2e92rEtSCXO9jXcjI77aTgE9ZBq;

		public _O8G74kUThoRhYWCOb1McUKcqi8A _wr6xcvFOgUbaTATC17S6Y9v3y3S;

		internal void _K6ChlThGNJzhDniJ1it7PMagA2d(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0)
		{
			RenderTargetBinding[] renderTargets = _wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._XbOXR6AypLIdJ3gBMGseGi3Wi2i._ZzBuoSDMWwerejOO9Goyv2OCKgE._2yepMkVENnecIsduggABaU2qhXW.GetRenderTargets();
			_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._XbOXR6AypLIdJ3gBMGseGi3Wi2i._ZzBuoSDMWwerejOO9Goyv2OCKgE._2yepMkVENnecIsduggABaU2qhXW.SetRenderTarget(_YazjYDLENT6HQ0JTluCcQMsqZaB);
			_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._XbOXR6AypLIdJ3gBMGseGi3Wi2i._ZzBuoSDMWwerejOO9Goyv2OCKgE._2yepMkVENnecIsduggABaU2qhXW.Clear(Color.Transparent);
			_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._9kpyWj69TJrEE13VPDWRIsYgsND._f5ctqAmdNsZ889UjM4LxDm8WGxA(skeletonMeshRenderer_0, null, null, null, _wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._fO7gSlrDDNMoHR4FO5QXAq8fUyA);
			_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._XbOXR6AypLIdJ3gBMGseGi3Wi2i._ZzBuoSDMWwerejOO9Goyv2OCKgE._2yepMkVENnecIsduggABaU2qhXW.SetRenderTargets(renderTargets);
			spriteBatch_0.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend);
			float num = _wr6xcvFOgUbaTATC17S6Y9v3y3S._dEj1SINFcMo2azAbZIsDW2P7BQF + (float)_0NizriMRCkKJuXStgvnNKe6Lo4y.Height;
			_2e92rEtSCXO9jXcjI77aTgE9ZBq.Parameters["Time"].SetValue(_boyt8NIMtKsAGSTcjHeL0WMbFxs._AmIUCcrmrrQiiirja7DoiZSjXuv);
			_2e92rEtSCXO9jXcjI77aTgE9ZBq.Parameters["PoolSpeed"].SetValue(0.1f);
			_2e92rEtSCXO9jXcjI77aTgE9ZBq.Parameters["PoolOffset"].SetValue(0);
			_2e92rEtSCXO9jXcjI77aTgE9ZBq.Parameters["MaskTexture"].SetValue(_0NizriMRCkKJuXStgvnNKe6Lo4y);
			_2e92rEtSCXO9jXcjI77aTgE9ZBq.Parameters["MaskStart"].SetValue(_wr6xcvFOgUbaTATC17S6Y9v3y3S._dEj1SINFcMo2azAbZIsDW2P7BQF / (float)_wr6xcvFOgUbaTATC17S6Y9v3y3S._YqYs2NQHqpJMOFO0oHumIz6vgVd.Height);
			_2e92rEtSCXO9jXcjI77aTgE9ZBq.Parameters["MaskEnd"].SetValue(num / (float)_wr6xcvFOgUbaTATC17S6Y9v3y3S._YqYs2NQHqpJMOFO0oHumIz6vgVd.Height);
			_2e92rEtSCXO9jXcjI77aTgE9ZBq.Parameters["Inverse"].SetValue(_wr6xcvFOgUbaTATC17S6Y9v3y3S._z63evmklawgrVTepZWr3BQhfZCK);
			_2e92rEtSCXO9jXcjI77aTgE9ZBq.CurrentTechnique.Passes[0].Apply();
			spriteBatch_0.Draw(_YazjYDLENT6HQ0JTluCcQMsqZaB, new Vector2(_wr6xcvFOgUbaTATC17S6Y9v3y3S._YqYs2NQHqpJMOFO0oHumIz6vgVd.X, _wr6xcvFOgUbaTATC17S6Y9v3y3S._YqYs2NQHqpJMOFO0oHumIz6vgVd.Y), Color.White);
			spriteBatch_0.End();
		}
	}

	private readonly _nHdiyIURlAiaNZ8u6MKzxjcwnyL _9kpyWj69TJrEE13VPDWRIsYgsND;

	public override float _WBXNT6eIVGk6ZKExRBJ6JxXE6zb_002E_GDeKFFD8Rxnpsjzy36lUBxAEopc
	{
		get
		{
			return _9kpyWj69TJrEE13VPDWRIsYgsND._7Xn1C5tjYnmIif1iZKV8AWsEEbL;
		}
		set
		{
			_9kpyWj69TJrEE13VPDWRIsYgsND._7Xn1C5tjYnmIif1iZKV8AWsEEbL = value;
		}
	}

	public override float _WBXNT6eIVGk6ZKExRBJ6JxXE6zb_002E_JpSvHH1W0gFCpaNEH5zB1qsDJXY
	{
		get
		{
			return _9kpyWj69TJrEE13VPDWRIsYgsND._bCjZ3VSXGKyhmykd2zCnQBiSpDf;
		}
		set
		{
			_9kpyWj69TJrEE13VPDWRIsYgsND._bCjZ3VSXGKyhmykd2zCnQBiSpDf = value;
		}
	}

	public _jOXcj4HBkU5j6LOJprpiXLCcLR0(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, float float_0, Rectangle rectangle_0, bool bool_0)
		: base(_7UlnfykmEmZDFt3BmCKZekI43Ih_0, "Pool Water")
	{
		_jOXcj4HBkU5j6LOJprpiXLCcLR0 _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = this;
		RenderTarget2D _YazjYDLENT6HQ0JTluCcQMsqZaB = new RenderTarget2D(base._XbOXR6AypLIdJ3gBMGseGi3Wi2i._ZzBuoSDMWwerejOO9Goyv2OCKgE._2yepMkVENnecIsduggABaU2qhXW, rectangle_0.Width, rectangle_0.Height);
		Effect _2e92rEtSCXO9jXcjI77aTgE9ZBq = base._XbOXR6AypLIdJ3gBMGseGi3Wi2i._ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Effect>("Assets/Shaders/SpinePool");
		Texture2D _0NizriMRCkKJuXStgvnNKe6Lo4y = base._XbOXR6AypLIdJ3gBMGseGi3Wi2i._ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/Scenes/ClubPool/Wave Mask");
		base._NC5P3SKqKPpcAYG1mqquUEcUzTg = delegate(GameTime gameTime_0)
		{
			_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._9kpyWj69TJrEE13VPDWRIsYgsND._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
		};
		base._Wb2e00OWt8kBwGWEXtOGMVScRPm = delegate(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0)
		{
			RenderTargetBinding[] renderTargets = _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._XbOXR6AypLIdJ3gBMGseGi3Wi2i._ZzBuoSDMWwerejOO9Goyv2OCKgE._2yepMkVENnecIsduggABaU2qhXW.GetRenderTargets();
			_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._XbOXR6AypLIdJ3gBMGseGi3Wi2i._ZzBuoSDMWwerejOO9Goyv2OCKgE._2yepMkVENnecIsduggABaU2qhXW.SetRenderTarget(_YazjYDLENT6HQ0JTluCcQMsqZaB);
			_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._XbOXR6AypLIdJ3gBMGseGi3Wi2i._ZzBuoSDMWwerejOO9Goyv2OCKgE._2yepMkVENnecIsduggABaU2qhXW.Clear(Color.Transparent);
			_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._9kpyWj69TJrEE13VPDWRIsYgsND._f5ctqAmdNsZ889UjM4LxDm8WGxA(skeletonMeshRenderer_0, null, null, null, _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._fO7gSlrDDNMoHR4FO5QXAq8fUyA);
			_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._XbOXR6AypLIdJ3gBMGseGi3Wi2i._ZzBuoSDMWwerejOO9Goyv2OCKgE._2yepMkVENnecIsduggABaU2qhXW.SetRenderTargets(renderTargets);
			spriteBatch_0.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend);
			float num = float_0 + (float)_0NizriMRCkKJuXStgvnNKe6Lo4y.Height;
			_2e92rEtSCXO9jXcjI77aTgE9ZBq.Parameters["Time"].SetValue(_boyt8NIMtKsAGSTcjHeL0WMbFxs._AmIUCcrmrrQiiirja7DoiZSjXuv);
			_2e92rEtSCXO9jXcjI77aTgE9ZBq.Parameters["PoolSpeed"].SetValue(0.1f);
			_2e92rEtSCXO9jXcjI77aTgE9ZBq.Parameters["PoolOffset"].SetValue(0);
			_2e92rEtSCXO9jXcjI77aTgE9ZBq.Parameters["MaskTexture"].SetValue(_0NizriMRCkKJuXStgvnNKe6Lo4y);
			_2e92rEtSCXO9jXcjI77aTgE9ZBq.Parameters["MaskStart"].SetValue(float_0 / (float)rectangle_0.Height);
			_2e92rEtSCXO9jXcjI77aTgE9ZBq.Parameters["MaskEnd"].SetValue(num / (float)rectangle_0.Height);
			_2e92rEtSCXO9jXcjI77aTgE9ZBq.Parameters["Inverse"].SetValue(bool_0);
			_2e92rEtSCXO9jXcjI77aTgE9ZBq.CurrentTechnique.Passes[0].Apply();
			spriteBatch_0.Draw(_YazjYDLENT6HQ0JTluCcQMsqZaB, new Vector2(rectangle_0.X, rectangle_0.Y), Color.White);
			spriteBatch_0.End();
		};
		_9kpyWj69TJrEE13VPDWRIsYgsND = _7UlnfykmEmZDFt3BmCKZekI43Ih_0._ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8._7BVREQXEcBCieHb0qgaVDpUj1ni("Assets/Scenes/ClubPool/Club Pool water");
		_9kpyWj69TJrEE13VPDWRIsYgsND._7Xn1C5tjYnmIif1iZKV8AWsEEbL = 0f;
		_9kpyWj69TJrEE13VPDWRIsYgsND._bCjZ3VSXGKyhmykd2zCnQBiSpDf = 0f;
		_9kpyWj69TJrEE13VPDWRIsYgsND._C5vPbZ72rpVMDWGuHxZuR5FNpAH("animation");
	}
}
