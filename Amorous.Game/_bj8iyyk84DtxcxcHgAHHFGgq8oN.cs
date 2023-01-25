using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Amorous.Engine.GUI;
using Amorous.Engine.NPC;
using Amorous.Game.Scenes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Newtonsoft.Json;
using SDL2;
using Spine;
using Squid;

public class Amorous : IAmorous
{
	private readonly Game Amorous;

	private readonly GraphicsDeviceManager _ARAAkijJ1FF23wI2rNDaw7mTOeJ;

	private SpriteBatch _ZXUztyGtStF4WzGVig7wu43cfnf;

	private SkeletonMeshRenderer _BuJyoOT5ylWcIMxjcKRnxVmYvBd;

	private _wRd4nHuQQlAPEwrHOGkBfut6Uip _chds2l0ZCMMghly7dv4eik3iSH5;

	private RenderTarget2D _j2ynkEUaNLywHdchuAYJWHF3l9DA;

	private Microsoft.Xna.Framework.Rectangle _CCbe95wREA1VhjgpntSpzsQ19He;

	private _gJR4g7ak0hsZAUWX1vJbMqG2P5I _RA1aFlOff0jGfI2cKUGhYI1MRLBA;

	private _UmxbIbk7pgaod0bD7pS309P3Lns _6M30VBCyHzfi1RYZYx7uJAHl1EC;

	private _AUtA43NfhBNYDqRrVB1t9VQxe1v _PxO28nve6nqbBLBJKrzHMRbOasHA;

	private _3FFZvGWTAe7rsviKkDPTXEVjxWf _YNCmHGUHBydamu5BEECMWoB65VfA;

	private _XJasjdoOf6PYbfaC5MsbXSjDWV3 _9rxbJ7LsE3DhACUHVlPZaixc5Jp;

	private Achievements _db5uuwyBnUwxthW14pfDBlBoqUp;

	private _KDiaUloddpdv1QwixDEBIJs6IMA _p3BLtW5bCDzTS86VFihe1pfwDoP;

	private Action _ColBlKEOYSqQMmmj719vN58K9aN;

	private AbstractScene _xfiKuXXh5LQA9CUQiex6tutzFKQ;

	private AbstractScene _Z8BClcChRJrlB6tR1VPJcycVpHN;

	private _Z6EKIW3ycAwV2npYuxbFLcnCTrJ _CCtbrNWS4Gi5hRSEsXYI5VzS7gI;

	private _poenyHBGUusBcnNcTFB9MQBV72R _SUHe9KzfAd477MCCYxTvqFf3efl;

	private _nkzqFdEfDyLcyGikIKGcHjklI4y _P62DygY6CKZG8s5wqDu0uAFksjs;

	private _nR8eroJOHehP0ZGyyTveo6aMTHg _Ta8oiGRfjrRGtgUaA5S061UepZb;

	private _TwlwMC1hhdSzamwGWEBxuUkz1gH _ieTMbMiu3eGRdmzTMofKoJopZAf;

	private _8lVOgkauaSHbAkAqHzI1K7mIyOI _fp8jsuSnELXqf2yy2JQDaXDCBVQ;

	private Texture2D _0SvmBhkBX8SImQwyvuy5xVObqLn;

	private SpriteFont _xnYepZuegigJCU2jcbZsfVIakzF;

	private bool _DNbNFzOKO7vtoVmjI32p1Snwmpe;

	private bool _Fs6y8qquj1mRHLz6xw6KoI4SAvH;

	private bool _qZ4p0zzU9dj7bhTFunYbFjSNY6D;

	private static readonly string[] _dKSAtbg8U4PX1oOcOJ2BFewVtcI = new string[8]
	{
		typeof(BedroomScene).Name,
		typeof(LivingRoomScene).Name,
		typeof(ClubBackScene).Name,
		typeof(ClubEntranceScene).Name,
		typeof(ClubInsideScene).Name,
		typeof(ClubLoungeScene).Name,
		typeof(ClubPoolScene).Name,
		typeof(ClubUpstairsScene).Name
	};

	private Microsoft.Xna.Framework.Input.Keys[] _gylJZYyc3mVB0fbHPCctDIg4UAE;

	private string[] _sUwMzXXmi9PdDQ0bFQhbGQJUPTe;

	private Vector2 _Vh2qdN4Ha62herl19def6PyuanQ;

	public GameWindow _8k7Do3TGW5NrB22zl8QzInP2j7k => Amorous.Window;

	public GraphicsDevice _2yepMkVENnecIsduggABaU2qhXW => Amorous.GraphicsDevice;

	public ContentManager _uwNDZuqdFb9tyQtlQMxiz1DQ7x8 => Amorous.Content;

	public _3FFZvGWTAe7rsviKkDPTXEVjxWf _RbWJ7YGnYHCSoD44MRW1h5X6E7E => _YNCmHGUHBydamu5BEECMWoB65VfA;

	public _wRd4nHuQQlAPEwrHOGkBfut6Uip _vsceSzSIjBy2nZrCxAzKZbUiwLq => _chds2l0ZCMMghly7dv4eik3iSH5;

	public AbstractScene Scene => _xfiKuXXh5LQA9CUQiex6tutzFKQ;

	public _TwlwMC1hhdSzamwGWEBxuUkz1gH Sexscene => _ieTMbMiu3eGRdmzTMofKoJopZAf;

	public _nR8eroJOHehP0ZGyyTveo6aMTHg _5zNdOw7qHmuCAPJFMr3SsZdBlCr => _Ta8oiGRfjrRGtgUaA5S061UepZb;

	public _gJR4g7ak0hsZAUWX1vJbMqG2P5I _Qj2G6fpAF4mGsATgkV8DPBF3aA1A => _RA1aFlOff0jGfI2cKUGhYI1MRLBA;

	public _8lVOgkauaSHbAkAqHzI1K7mIyOI _o2QVQfIAsuLcmPxn14llGoZA52y => _fp8jsuSnELXqf2yy2JQDaXDCBVQ;

	public IAchievements _aJh9CibG5YKhkExxgRyVopdfSeJ => _db5uuwyBnUwxthW14pfDBlBoqUp;

	public bool _kSReo0whY1pgfTnFOSc44ppANOe => _ARAAkijJ1FF23wI2rNDaw7mTOeJ.IsFullScreen;

	public bool _NdzU0m9x8QDKpVv3DrQmzY5KduB { get; set; }

	public bool _LWcoDwIWvf8DT3nQmNe5z8fkUvI { get; set; }

	public bool _ezjxb7tsh6Db1xblB74OYX4vVK => _DNbNFzOKO7vtoVmjI32p1Snwmpe;

	public Amorous(Game game, bool safemode)
	{
		Amorous = game;
		Options.Read();
		if (safemode)
		{
			_ARAAkijJ1FF23wI2rNDaw7mTOeJ = new GraphicsDeviceManager(game)
			{
				IsFullScreen = false,
				PreferredBackBufferWidth = 1024,
				PreferredBackBufferHeight = 768,
				SynchronizeWithVerticalRetrace = true
			};
		}
		else if (!Options.ContainsResolution())
		{
			DisplayMode currentDisplayMode = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode;
			_ARAAkijJ1FF23wI2rNDaw7mTOeJ = new GraphicsDeviceManager(game)
			{
				IsFullScreen = true,
				PreferredBackBufferWidth = currentDisplayMode.Width,
				PreferredBackBufferHeight = currentDisplayMode.Height,
				SynchronizeWithVerticalRetrace = true
			};
		}
		else
		{
			_ARAAkijJ1FF23wI2rNDaw7mTOeJ = new GraphicsDeviceManager(game)
			{
				IsFullScreen = Options.Data.Fullscreen,
				PreferredBackBufferWidth = Options.Data.ResolutionWidth,
				PreferredBackBufferHeight = Options.Data.ResolutionHeight,
				SynchronizeWithVerticalRetrace = true
			};
		}
		_uwNDZuqdFb9tyQtlQMxiz1DQ7x8.RootDirectory = "Content-Release";
		Amorous.Content = new _xM5N1Fg3VZCSTaBWtPXoS6nJ82E(_uwNDZuqdFb9tyQtlQMxiz1DQ7x8.ServiceProvider, _uwNDZuqdFb9tyQtlQMxiz1DQ7x8.RootDirectory);
	}

	public void Initialize()
	{
		Amorous.Disposed += delegate
		{
			Options.Save();
		};
		Gui.GetClipboardCallback = (Func<string>)Delegate.Combine(Gui.GetClipboardCallback, new Func<string>(SDL.SDL_GetClipboardText));
		Gui.SetClipboardCallback = (Action<string>)Delegate.Combine(Gui.SetClipboardCallback, (Action<string>)delegate(string string_0)
		{
			SDL.SDL_SetClipboardText(string_0);
		});
		string text = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "NonSteam");
		if (!File.Exists(text) && !File.Exists(text + ".txt"))
		{
			_p3BLtW5bCDzTS86VFihe1pfwDoP = new _KDiaUloddpdv1QwixDEBIJs6IMA();
			if (!_p3BLtW5bCDzTS86VFihe1pfwDoP.Initialize(778700u, this))
			{
				_p3BLtW5bCDzTS86VFihe1pfwDoP = null;
			}
		}
		_db5uuwyBnUwxthW14pfDBlBoqUp = new Achievements(this, _p3BLtW5bCDzTS86VFihe1pfwDoP);
	}

	public void LoadContent()
	{
		string text = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ShowMeSomeBooty");
		_iExD93IWLlzVfXsU9wyrEvWgJsg._qrFhbSiCFS6nLCN231ubbRQQeXE(File.Exists(text) || File.Exists(text + ".txt"));
		_YNCmHGUHBydamu5BEECMWoB65VfA = new _3FFZvGWTAe7rsviKkDPTXEVjxWf(this);
		_gylJZYyc3mVB0fbHPCctDIg4UAE = (Microsoft.Xna.Framework.Input.Keys[])Enum.GetValues(typeof(Microsoft.Xna.Framework.Input.Keys));
		_RbWJ7YGnYHCSoD44MRW1h5X6E7E._tZI6Co0uB31aGK7Qk4qvEImgcnO = true;
		_ZXUztyGtStF4WzGVig7wu43cfnf = new SpriteBatch(Amorous.GraphicsDevice);
		_BuJyoOT5ylWcIMxjcKRnxVmYvBd = new SkeletonMeshRenderer(Amorous.GraphicsDevice);
		_chds2l0ZCMMghly7dv4eik3iSH5 = new _wRd4nHuQQlAPEwrHOGkBfut6Uip(this, 1920, 1080);
		_chds2l0ZCMMghly7dv4eik3iSH5._2lMgp1KOzK9I6kd7CHrDq2A2CHm(_ARAAkijJ1FF23wI2rNDaw7mTOeJ.PreferredBackBufferWidth, _ARAAkijJ1FF23wI2rNDaw7mTOeJ.PreferredBackBufferHeight, _ARAAkijJ1FF23wI2rNDaw7mTOeJ.PreferredBackBufferWidth, _ARAAkijJ1FF23wI2rNDaw7mTOeJ.PreferredBackBufferHeight);
		_j2ynkEUaNLywHdchuAYJWHF3l9DA = new RenderTarget2D(Amorous.GraphicsDevice, 1920, 1080);
		_j2ynkEUaNLywHdchuAYJWHF3l9DA._w2YD42TXOY22EP4Mpp7wzDUO4xv(RenderTargetUsage.PreserveContents);
		_CCbe95wREA1VhjgpntSpzsQ19He = new Microsoft.Xna.Framework.Rectangle(_chds2l0ZCMMghly7dv4eik3iSH5._jDxCg7GJnIKcLXDcUVSdbEIQL3Yb, _chds2l0ZCMMghly7dv4eik3iSH5._ILCBrSipj1Qk4CsYzkEELxHvkkY, _chds2l0ZCMMghly7dv4eik3iSH5._HZrLDiX4EPtS6jM8Odd9yJAatHq, _chds2l0ZCMMghly7dv4eik3iSH5._ypqaDJqrkQlUKOrdZIXld5qQQ4x);
		Gui.Renderer = new _k8LAl8bPyzLGEpo59dKFGU4sCQ(Amorous);
		Gui.Renderer.SetTexture("PhoneScreen", Amorous.Content.Load<Texture2D>("Assets/GUI/Phone/PhoneScreen"));
		Gui.Renderer.SetTexture("Contact_DJ", Amorous.Content.Load<Texture2D>("Assets/GUI/Phone/Contacts/DJ"));
		_KyKsjBAROeUAsKraBIxtuHTSPwg._Uh2GhEF2pLNc3a7l5WMdPGP2bZd = _pql4s9X0U3svdBghGax6VsdF2Gq;
		_CCtbrNWS4Gi5hRSEsXYI5VzS7gI = new _Z6EKIW3ycAwV2npYuxbFLcnCTrJ();
		_RA1aFlOff0jGfI2cKUGhYI1MRLBA = new _gJR4g7ak0hsZAUWX1vJbMqG2P5I(Amorous.GraphicsDevice);
		_6M30VBCyHzfi1RYZYx7uJAHl1EC = new _UmxbIbk7pgaod0bD7pS309P3Lns(Amorous.Content);
		_PxO28nve6nqbBLBJKrzHMRbOasHA = new _AUtA43NfhBNYDqRrVB1t9VQxe1v(Amorous.Content);
		_9rxbJ7LsE3DhACUHVlPZaixc5Jp = new _XJasjdoOf6PYbfaC5MsbXSjDWV3();
		Texture2D texture2D_ = Amorous.Content.Load<Texture2D>("Assets/GUI/Dialogue/dialogue");
		Texture2D texture2D_2 = Amorous.Content.Load<Texture2D>("Assets/GUI/Dialogue/button");
		_0SvmBhkBX8SImQwyvuy5xVObqLn = Amorous.Content.Load<Texture2D>("Assets/GUI/Squid/DefaultCursor");
		_LWcoDwIWvf8DT3nQmNe5z8fkUvI = true;
		_xnYepZuegigJCU2jcbZsfVIakzF = Amorous.Content.Load<SpriteFont>("Assets/GUI/Fonts/Bold-26");
		SpriteFont spriteFont_ = Amorous.Content.Load<SpriteFont>("Assets/GUI/Fonts/BoldItalic-26");
		_P62DygY6CKZG8s5wqDu0uAFksjs = new _nkzqFdEfDyLcyGikIKGcHjklI4y(this, texture2D_, texture2D_2, _xnYepZuegigJCU2jcbZsfVIakzF, spriteFont_);
		_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p _3CCr8Bt1rkuzt0M6gYLbceJGV0p = _DW9IcpdMEINZmuzfrqmwsduBGih._jVNnsNFMjoGC9t7v83qLI8vEZSH();
		if (!_3CCr8Bt1rkuzt0M6gYLbceJGV0p._r4LqoJiAr5K9UiLsUzUDbcJDQqo)
		{
			_lRHDfpOTd4PxClZkjMpoakPEA9d lRHDfpOTd4PxClZkjMpoakPEA9d = (_3CCr8Bt1rkuzt0M6gYLbceJGV0p._3y7m8OGVjMe7WGIhZ66YOw3ITUE ? _DW9IcpdMEINZmuzfrqmwsduBGih._NyR9YmfkeF4CXGOi1ENApzh6B5V(_3CCr8Bt1rkuzt0M6gYLbceJGV0p._B3FsRMcQWBXzFf3nLOBKzncessO) : _DW9IcpdMEINZmuzfrqmwsduBGih.Read(_3CCr8Bt1rkuzt0M6gYLbceJGV0p._B3FsRMcQWBXzFf3nLOBKzncessO));
			if (lRHDfpOTd4PxClZkjMpoakPEA9d != null)
			{
				_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._yuFBJdi7mxrwMFQ57BjLjSq6ESj.Data = lRHDfpOTd4PxClZkjMpoakPEA9d.PlayerData;
			}
		}
		_SUHe9KzfAd477MCCYxTvqFf3efl = new _poenyHBGUusBcnNcTFB9MQBV72R(this, Amorous.Content);
		_5Anqe6GAAkzemoAXYpJmgMlk1yz._3DInasj5B11bCcV5BIRvLE1Ay7w = true;
		_5Anqe6GAAkzemoAXYpJmgMlk1yz._LsIdcBLhaqZr03JCpCYZrI9ztVF();
		_DNbNFzOKO7vtoVmjI32p1Snwmpe = true;
		Gui.Renderer.SetTexture("MessageIconCoby", _uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Coby"));
		Gui.Renderer.SetTexture("MessageIconDustin", _uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Dustin"));
		Gui.Renderer.SetTexture("MessageIconJax", _uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Jax"));
		Gui.Renderer.SetTexture("MessageIconLex", _uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Lex"));
		Gui.Renderer.SetTexture("MessageIconMercy", _uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Mercy"));
		Gui.Renderer.SetTexture("MessageIconRemy", _uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Remy"));
		Gui.Renderer.SetTexture("MessageIconSeth", _uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Seth"));
		Gui.Renderer.SetTexture("MessageIconSkye", _uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Skye"));
		Gui.Renderer.SetTexture("MessageIconZenith", _uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Zenith"));
		Gui.Renderer.SetTexture("MessageIconGeneric", _uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Generic"));
		Gui.Renderer.SetTexture("MessageIconDJ", _uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_DJ"));
		Gui.Renderer.SetTexture("MessageIconShootingRange", _uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_ShootingRange"));
		Gui.Renderer.SetTexture("MessageIconCooking", _uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Cooking"));
		Begin();
	}

	protected virtual void Begin()
	{
		_xfiKuXXh5LQA9CUQiex6tutzFKQ = new EmptyScene(this);
		_Qj2G6fpAF4mGsATgkV8DPBF3aA1A._E7yBM68AWt7OGHJ5D6xYA8RK8tAA(new Color(0, 0, 0, 255));
		_OxLRmpxixplTKChiTPUKAx4uTLG<MainMenuScene>(delegate
		{
			_Qj2G6fpAF4mGsATgkV8DPBF3aA1A._FegL010tc92iskjjyD0T33dDwNE();
		});
	}

	public void UnloadContent()
	{
	}

	public void Update(GameTime gameTime_0)
	{
		if (_NdzU0m9x8QDKpVv3DrQmzY5KduB && _Z8BClcChRJrlB6tR1VPJcycVpHN == null)
		{
			_NdzU0m9x8QDKpVv3DrQmzY5KduB = false;
			if (_ColBlKEOYSqQMmmj719vN58K9aN != null)
			{
				Action colBlKEOYSqQMmmj719vN58K9aN = _ColBlKEOYSqQMmmj719vN58K9aN;
				_ColBlKEOYSqQMmmj719vN58K9aN = null;
				colBlKEOYSqQMmmj719vN58K9aN();
			}
		}
		_YNCmHGUHBydamu5BEECMWoB65VfA.Update();
		if (_RbWJ7YGnYHCSoD44MRW1h5X6E7E._WZ4xYI5Q3hoCNX9QFzE3jfDwZBJ(Microsoft.Xna.Framework.Input.Keys.LeftAlt) && _RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(Microsoft.Xna.Framework.Input.Keys.F1))
		{
			_DNbNFzOKO7vtoVmjI32p1Snwmpe = !_DNbNFzOKO7vtoVmjI32p1Snwmpe;
		}
		if ((_RbWJ7YGnYHCSoD44MRW1h5X6E7E._WZ4xYI5Q3hoCNX9QFzE3jfDwZBJ(Microsoft.Xna.Framework.Input.Keys.LeftAlt) && _RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(Microsoft.Xna.Framework.Input.Keys.Enter)) || _RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(Microsoft.Xna.Framework.Input.Keys.F2))
		{
			_qGU55VUfbqFJ4l6ArNW4JRcLekg();
		}
		if (_p3BLtW5bCDzTS86VFihe1pfwDoP == null && (_RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(Microsoft.Xna.Framework.Input.Keys.F12) || _RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(Microsoft.Xna.Framework.Input.Keys.PrintScreen)))
		{
			_VN2LxjGLZldLNfiJ1OniiaXfYBg();
		}
		if (_RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(Microsoft.Xna.Framework.Input.Keys.Tab))
		{
			_Fs6y8qquj1mRHLz6xw6KoI4SAvH = !_Fs6y8qquj1mRHLz6xw6KoI4SAvH;
		}
		_chds2l0ZCMMghly7dv4eik3iSH5.Update(gameTime_0);
		_RA1aFlOff0jGfI2cKUGhYI1MRLBA.Update(gameTime_0);
		_6M30VBCyHzfi1RYZYx7uJAHl1EC.Update(gameTime_0);
		_6M30VBCyHzfi1RYZYx7uJAHl1EC._LcX2y4hMIzQST4uGT2Q5Ce7vaGg();
		if (_Z8BClcChRJrlB6tR1VPJcycVpHN != null)
		{
			if (_xfiKuXXh5LQA9CUQiex6tutzFKQ != null)
			{
				_xfiKuXXh5LQA9CUQiex6tutzFKQ.End();
			}
			_xfiKuXXh5LQA9CUQiex6tutzFKQ = _Z8BClcChRJrlB6tR1VPJcycVpHN;
			_Z8BClcChRJrlB6tR1VPJcycVpHN = null;
			_xfiKuXXh5LQA9CUQiex6tutzFKQ._4hlxzMzKSbVTbZUrEsP3dfw4x0h();
		}
		_xfiKuXXh5LQA9CUQiex6tutzFKQ.Update(gameTime_0);
		_CCtbrNWS4Gi5hRSEsXYI5VzS7gI.Update(gameTime_0);
		_SUHe9KzfAd477MCCYxTvqFf3efl.Update(gameTime_0, _chds2l0ZCMMghly7dv4eik3iSH5);
		_P62DygY6CKZG8s5wqDu0uAFksjs.Update(gameTime_0);
		if (_Ta8oiGRfjrRGtgUaA5S061UepZb != null)
		{
			_Ta8oiGRfjrRGtgUaA5S061UepZb.Update(gameTime_0);
			if (!_Ta8oiGRfjrRGtgUaA5S061UepZb._5PWaXifOOaIVN34JQsXRmvxXtqK)
			{
				_sUwMzXXmi9PdDQ0bFQhbGQJUPTe = _Ta8oiGRfjrRGtgUaA5S061UepZb._YYH5zlVZSFq4tPfc1vfadAxnqhV(5);
				_Ta8oiGRfjrRGtgUaA5S061UepZb = null;
			}
		}
		if (_ieTMbMiu3eGRdmzTMofKoJopZAf != null)
		{
			_ieTMbMiu3eGRdmzTMofKoJopZAf.Update(gameTime_0);
		}
		if (_fp8jsuSnELXqf2yy2JQDaXDCBVQ != null)
		{
			_fp8jsuSnELXqf2yy2JQDaXDCBVQ.Update(gameTime_0);
		}
		_9rxbJ7LsE3DhACUHVlPZaixc5Jp.Update(gameTime_0);
		Microsoft.Xna.Framework.Point point = _chds2l0ZCMMghly7dv4eik3iSH5._u7uCdK9i8FnWhiaPn2bO2wIgUUuA(_RbWJ7YGnYHCSoD44MRW1h5X6E7E._U7CeYBJ1v1SoUxpX8emsQ9mWl5b);
		List<KeyData> list = new List<KeyData>();
		Microsoft.Xna.Framework.Input.Keys[] gylJZYyc3mVB0fbHPCctDIg4UAE = _gylJZYyc3mVB0fbHPCctDIg4UAE;
		foreach (Microsoft.Xna.Framework.Input.Keys keys in gylJZYyc3mVB0fbHPCctDIg4UAE)
		{
			bool flag = _RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(keys);
			bool flag2 = _RbWJ7YGnYHCSoD44MRW1h5X6E7E._KGCwEHf8akeXdkHLKFg1caFxXUJ(keys);
			if (flag || flag2)
			{
				Squid.Keys? keys2 = SquidUtils._HSj1lr89AFIB9adVhSrAeWjS1xC[Keyboard.GetKeyFromScancodeEXT(keys)];
				if (keys2.HasValue)
				{
					list.Add(new KeyData
					{
						Scancode = (int)keys2.Value,
						Char = keys.ChangeKeyboard(_RbWJ7YGnYHCSoD44MRW1h5X6E7E._WZ4xYI5Q3hoCNX9QFzE3jfDwZBJ(Microsoft.Xna.Framework.Input.Keys.LeftShift) || _RbWJ7YGnYHCSoD44MRW1h5X6E7E._WZ4xYI5Q3hoCNX9QFzE3jfDwZBJ(Microsoft.Xna.Framework.Input.Keys.RightShift)),
						Pressed = flag,
						Released = flag2
					});
				}
			}
		}
		Gui.SetDecimalboard(list.ToArray());
		Gui.SetButtons(_RbWJ7YGnYHCSoD44MRW1h5X6E7E._WZ4xYI5Q3hoCNX9QFzE3jfDwZBJ(_PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton), _RbWJ7YGnYHCSoD44MRW1h5X6E7E._WZ4xYI5Q3hoCNX9QFzE3jfDwZBJ(_PMeRYZJaBCqgB9uADJFP3c14lxq.RightButton));
		Gui.SetMouse(point.X, point.Y, _RbWJ7YGnYHCSoD44MRW1h5X6E7E._xFrCcVNAYrShLz07HqDph01nGwX);
		Gui.TimeElapsed = gameTime_0.ElapsedGameTime.Milliseconds;
		if (_p3BLtW5bCDzTS86VFihe1pfwDoP != null)
		{
			_p3BLtW5bCDzTS86VFihe1pfwDoP.Update();
		}
	}

	public void Draw(GameTime gameTime_0)
	{
		_boyt8NIMtKsAGSTcjHeL0WMbFxs._AmIUCcrmrrQiiirja7DoiZSjXuv = (float)gameTime_0.TotalGameTime.TotalSeconds;
		Amorous.GraphicsDevice.SetRenderTarget(_j2ynkEUaNLywHdchuAYJWHF3l9DA);
		Amorous.GraphicsDevice.Clear(Color.Black);
		_xfiKuXXh5LQA9CUQiex6tutzFKQ.Draw(_ZXUztyGtStF4WzGVig7wu43cfnf, _BuJyoOT5ylWcIMxjcKRnxVmYvBd, _chds2l0ZCMMghly7dv4eik3iSH5._oLRK3f26Sw9AKBKi0iR44APDZEt);
		if (_chds2l0ZCMMghly7dv4eik3iSH5._q1DGEI79OguKnK8dCIgPvfGc9Bi)
		{
			_xfiKuXXh5LQA9CUQiex6tutzFKQ.Draw(_ZXUztyGtStF4WzGVig7wu43cfnf, _BuJyoOT5ylWcIMxjcKRnxVmYvBd, _chds2l0ZCMMghly7dv4eik3iSH5._00mMjYnrMXUVj1aA8AYlqz1bdTI);
		}
		else if (_chds2l0ZCMMghly7dv4eik3iSH5._c3CMfxjIJAFFcSeEIluZOLANXnE)
		{
			_xfiKuXXh5LQA9CUQiex6tutzFKQ.Draw(_ZXUztyGtStF4WzGVig7wu43cfnf, _BuJyoOT5ylWcIMxjcKRnxVmYvBd, _chds2l0ZCMMghly7dv4eik3iSH5._MPYpHIXdfUjJipVgAvBCGASJZiZ);
		}
		if (_ieTMbMiu3eGRdmzTMofKoJopZAf != null)
		{
			_ieTMbMiu3eGRdmzTMofKoJopZAf.Draw(_ZXUztyGtStF4WzGVig7wu43cfnf, _BuJyoOT5ylWcIMxjcKRnxVmYvBd);
		}
		if (_DNbNFzOKO7vtoVmjI32p1Snwmpe)
		{
			_SUHe9KzfAd477MCCYxTvqFf3efl.Draw(_ZXUztyGtStF4WzGVig7wu43cfnf, _BuJyoOT5ylWcIMxjcKRnxVmYvBd);
		}
		if (_fp8jsuSnELXqf2yy2JQDaXDCBVQ != null)
		{
			_fp8jsuSnELXqf2yy2JQDaXDCBVQ.Draw(_ZXUztyGtStF4WzGVig7wu43cfnf);
		}
		_xfiKuXXh5LQA9CUQiex6tutzFKQ.Render(_ZXUztyGtStF4WzGVig7wu43cfnf);
		_RA1aFlOff0jGfI2cKUGhYI1MRLBA.Draw(_ZXUztyGtStF4WzGVig7wu43cfnf, _chds2l0ZCMMghly7dv4eik3iSH5);
		if (_DNbNFzOKO7vtoVmjI32p1Snwmpe)
		{
			_P62DygY6CKZG8s5wqDu0uAFksjs.Draw(_ZXUztyGtStF4WzGVig7wu43cfnf);
		}
		_9rxbJ7LsE3DhACUHVlPZaixc5Jp.Draw(_ZXUztyGtStF4WzGVig7wu43cfnf);
		SpriteBatch zXUztyGtStF4WzGVig7wu43cfnf;
		SpriteFont xnYepZuegigJCU2jcbZsfVIakzF;
		object obj;
		if (_Fs6y8qquj1mRHLz6xw6KoI4SAvH)
		{
			if (_Ta8oiGRfjrRGtgUaA5S061UepZb != null)
			{
				_sUwMzXXmi9PdDQ0bFQhbGQJUPTe = _Ta8oiGRfjrRGtgUaA5S061UepZb._YYH5zlVZSFq4tPfc1vfadAxnqhV(5);
			}
			_Vh2qdN4Ha62herl19def6PyuanQ.X = 10f;
			_Vh2qdN4Ha62herl19def6PyuanQ.Y = 10f;
			_ZXUztyGtStF4WzGVig7wu43cfnf.Begin();
			_ZXUztyGtStF4WzGVig7wu43cfnf.DrawString(_xnYepZuegigJCU2jcbZsfVIakzF, "[Generic]", _Vh2qdN4Ha62herl19def6PyuanQ, Color.White);
			_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
			zXUztyGtStF4WzGVig7wu43cfnf = _ZXUztyGtStF4WzGVig7wu43cfnf;
			xnYepZuegigJCU2jcbZsfVIakzF = _xnYepZuegigJCU2jcbZsfVIakzF;
			AbstractScene xfiKuXXh5LQA9CUQiex6tutzFKQ = _xfiKuXXh5LQA9CUQiex6tutzFKQ;
			if (xfiKuXXh5LQA9CUQiex6tutzFKQ == null)
			{
				obj = null;
			}
			else
			{
				obj = xfiKuXXh5LQA9CUQiex6tutzFKQ.GetType().Name;
				if (obj != null)
				{
					goto IL_0220;
				}
			}
			obj = "None";
			goto IL_0220;
		}
		goto IL_04d3;
		IL_0220:
		#nullable enable
		zXUztyGtStF4WzGVig7wu43cfnf.DrawString(xnYepZuegigJCU2jcbZsfVIakzF, "Scene: " + (string?)obj, _Vh2qdN4Ha62herl19def6PyuanQ, Color.White);
		#nullable restore
		_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
		_ZXUztyGtStF4WzGVig7wu43cfnf.DrawString(_xnYepZuegigJCU2jcbZsfVIakzF, "ScreenFader: " + _RA1aFlOff0jGfI2cKUGhYI1MRLBA._SWODlbUkQEqfwrtprjLPOeGF7HO.A, _Vh2qdN4Ha62herl19def6PyuanQ, Color.White);
		_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
		_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
		_ZXUztyGtStF4WzGVig7wu43cfnf.DrawString(_xnYepZuegigJCU2jcbZsfVIakzF, "[Cutscenes]", _Vh2qdN4Ha62herl19def6PyuanQ, Color.White);
		_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
		_ZXUztyGtStF4WzGVig7wu43cfnf.DrawString(_xnYepZuegigJCU2jcbZsfVIakzF, string.Format("Cutscene in progress: {0}", (_Ta8oiGRfjrRGtgUaA5S061UepZb == null) ? "No" : "Yes"), _Vh2qdN4Ha62herl19def6PyuanQ, Color.White);
		_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
		if (_sUwMzXXmi9PdDQ0bFQhbGQJUPTe != null)
		{
			_ZXUztyGtStF4WzGVig7wu43cfnf.DrawString(_xnYepZuegigJCU2jcbZsfVIakzF, "Cutscene: " + _sUwMzXXmi9PdDQ0bFQhbGQJUPTe[0], _Vh2qdN4Ha62herl19def6PyuanQ, Color.White);
			_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
			_ZXUztyGtStF4WzGVig7wu43cfnf.DrawString(_xnYepZuegigJCU2jcbZsfVIakzF, "Stage: " + _sUwMzXXmi9PdDQ0bFQhbGQJUPTe[1], _Vh2qdN4Ha62herl19def6PyuanQ, Color.White);
			_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
			_ZXUztyGtStF4WzGVig7wu43cfnf.DrawString(_xnYepZuegigJCU2jcbZsfVIakzF, "Path: " + _sUwMzXXmi9PdDQ0bFQhbGQJUPTe[2], _Vh2qdN4Ha62herl19def6PyuanQ, Color.White);
			_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
			_ZXUztyGtStF4WzGVig7wu43cfnf.DrawString(_xnYepZuegigJCU2jcbZsfVIakzF, "Current: " + _sUwMzXXmi9PdDQ0bFQhbGQJUPTe[3], _Vh2qdN4Ha62herl19def6PyuanQ, Color.White);
			_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
		}
		else
		{
			_ZXUztyGtStF4WzGVig7wu43cfnf.DrawString(_xnYepZuegigJCU2jcbZsfVIakzF, "Cutscene: None", _Vh2qdN4Ha62herl19def6PyuanQ, Color.White);
			_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
		}
		_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
		_ZXUztyGtStF4WzGVig7wu43cfnf.DrawString(_xnYepZuegigJCU2jcbZsfVIakzF, "Press Tab to toggle", _Vh2qdN4Ha62herl19def6PyuanQ, Color.White);
		_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
		_ZXUztyGtStF4WzGVig7wu43cfnf.End();
		goto IL_04d3;
		IL_065c:
		Amorous.GraphicsDevice.SetRenderTarget(null);
		Amorous.GraphicsDevice.Clear(Color.Black);
		_ZXUztyGtStF4WzGVig7wu43cfnf.Begin();
		_ZXUztyGtStF4WzGVig7wu43cfnf.Draw(_j2ynkEUaNLywHdchuAYJWHF3l9DA, _CCbe95wREA1VhjgpntSpzsQ19He, Color.White);
		if (_LWcoDwIWvf8DT3nQmNe5z8fkUvI)
		{
			_ZXUztyGtStF4WzGVig7wu43cfnf.Draw(_0SvmBhkBX8SImQwyvuy5xVObqLn, _RbWJ7YGnYHCSoD44MRW1h5X6E7E._6M9HDt28e1QHBuYsAXgqiY8jVlA, _CCtbrNWS4Gi5hRSEsXYI5VzS7gI.Data.PhoneColor);
		}
		_ZXUztyGtStF4WzGVig7wu43cfnf.End();
		return;
		IL_04d3:
		string path2;
		object[] array;
		object obj2;
		if (_qZ4p0zzU9dj7bhTFunYbFjSNY6D)
		{
			_qZ4p0zzU9dj7bhTFunYbFjSNY6D = false;
			if (!Directory.Exists("Screenshots"))
			{
				Directory.CreateDirectory("Screenshots");
			}
			string path = $"Screenshots/screenshot-{DateTime.Now.DayOfYear}{DateTime.Now.Hour}{DateTime.Now.Minute}{DateTime.Now.Second}.png";
			string text = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, path);
			using (Stream stream = File.OpenWrite(text))
			{
				_j2ynkEUaNLywHdchuAYJWHF3l9DA.SaveAsPng(stream, _j2ynkEUaNLywHdchuAYJWHF3l9DA.Width, _j2ynkEUaNLywHdchuAYJWHF3l9DA.Height);
			}
			if (_p3BLtW5bCDzTS86VFihe1pfwDoP != null)
			{
				_p3BLtW5bCDzTS86VFihe1pfwDoP._9K6cA2OPGJaecqk3spsceT9ilNI(text, _j2ynkEUaNLywHdchuAYJWHF3l9DA.Width, _j2ynkEUaNLywHdchuAYJWHF3l9DA.Height);
			}
			if (_Fs6y8qquj1mRHLz6xw6KoI4SAvH && _sUwMzXXmi9PdDQ0bFQhbGQJUPTe != null)
			{
				path2 = $"{text}.txt";
				array = new object[5];
				AbstractScene xfiKuXXh5LQA9CUQiex6tutzFKQ2 = _xfiKuXXh5LQA9CUQiex6tutzFKQ;
				if (xfiKuXXh5LQA9CUQiex6tutzFKQ2 == null)
				{
					obj2 = null;
				}
				else
				{
					obj2 = xfiKuXXh5LQA9CUQiex6tutzFKQ2.GetType().Name;
					if (obj2 != null)
					{
						goto IL_0625;
					}
				}
				obj2 = "None";
				goto IL_0625;
			}
		}
		goto IL_065c;
		IL_0625:
		array[0] = obj2;
		array[1] = _sUwMzXXmi9PdDQ0bFQhbGQJUPTe[0];
		array[2] = _sUwMzXXmi9PdDQ0bFQhbGQJUPTe[1];
		array[3] = _sUwMzXXmi9PdDQ0bFQhbGQJUPTe[2];
		array[4] = _sUwMzXXmi9PdDQ0bFQhbGQJUPTe[3];
		File.WriteAllText(path2, string.Format("Scene: {0}\r\nCutscene: {1}\r\nStage: {2}\r\nPath: {3}\r\nCurrent: {4}", array));
		goto IL_065c;
	}

	public void _qGU55VUfbqFJ4l6ArNW4JRcLekg()
	{
		_fSRUnXzLhUs3DfJ1lzl9dGCEmCf(_chds2l0ZCMMghly7dv4eik3iSH5._KOuUew34v1oSMnWlHSFJuRBiu1c, _chds2l0ZCMMghly7dv4eik3iSH5._dh9yjUXG1mhcfgwAWkWfggbGEIc, !_ARAAkijJ1FF23wI2rNDaw7mTOeJ.IsFullScreen);
	}

	public void _VN2LxjGLZldLNfiJ1OniiaXfYBg()
	{
		_qZ4p0zzU9dj7bhTFunYbFjSNY6D = true;
	}

	public bool _fDSidqggP063WGf2vzkdlA1UDkn(string string_0)
	{
		if (_p3BLtW5bCDzTS86VFihe1pfwDoP == null)
		{
			try
			{
				Process.Start(string_0);
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
		_p3BLtW5bCDzTS86VFihe1pfwDoP._fDSidqggP063WGf2vzkdlA1UDkn(string_0);
		return true;
	}

	public void _fSRUnXzLhUs3DfJ1lzl9dGCEmCf(int int_0, int int_1)
	{
		_fSRUnXzLhUs3DfJ1lzl9dGCEmCf(int_0, int_1, _ARAAkijJ1FF23wI2rNDaw7mTOeJ.IsFullScreen);
	}

	public void _fSRUnXzLhUs3DfJ1lzl9dGCEmCf(int int_0, int int_1, bool bool_0)
	{
		_ARAAkijJ1FF23wI2rNDaw7mTOeJ.IsFullScreen = bool_0;
		_ARAAkijJ1FF23wI2rNDaw7mTOeJ.PreferredBackBufferWidth = (bool_0 ? GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width : int_0);
		_ARAAkijJ1FF23wI2rNDaw7mTOeJ.PreferredBackBufferHeight = (bool_0 ? GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height : int_1);
		_ARAAkijJ1FF23wI2rNDaw7mTOeJ.GraphicsDevice.Viewport = new Viewport(0, 0, _ARAAkijJ1FF23wI2rNDaw7mTOeJ.PreferredBackBufferWidth, _ARAAkijJ1FF23wI2rNDaw7mTOeJ.PreferredBackBufferHeight);
		_chds2l0ZCMMghly7dv4eik3iSH5._2lMgp1KOzK9I6kd7CHrDq2A2CHm(int_0, int_1, _ARAAkijJ1FF23wI2rNDaw7mTOeJ.PreferredBackBufferWidth, _ARAAkijJ1FF23wI2rNDaw7mTOeJ.PreferredBackBufferHeight);
		_CCbe95wREA1VhjgpntSpzsQ19He = new Microsoft.Xna.Framework.Rectangle(_chds2l0ZCMMghly7dv4eik3iSH5._jDxCg7GJnIKcLXDcUVSdbEIQL3Yb, _chds2l0ZCMMghly7dv4eik3iSH5._ILCBrSipj1Qk4CsYzkEELxHvkkY, _chds2l0ZCMMghly7dv4eik3iSH5._HZrLDiX4EPtS6jM8Odd9yJAatHq, _chds2l0ZCMMghly7dv4eik3iSH5._ypqaDJqrkQlUKOrdZIXld5qQQ4x);
		_ARAAkijJ1FF23wI2rNDaw7mTOeJ.ApplyChanges();
	}

	public void _udfEpcIRn7lWl5Lvjdyu0aG0A7G()
	{
		Amorous.Exit();
	}

	public void StartScene<T>() where T : AbstractScene
	{
		_RA1aFlOff0jGfI2cKUGhYI1MRLBA._PYAXEqRAOkDRRNqm1k71R7GJTJK(delegate
		{
			_OxLRmpxixplTKChiTPUKAx4uTLG<T>(delegate
			{
				_RA1aFlOff0jGfI2cKUGhYI1MRLBA._FegL010tc92iskjjyD0T33dDwNE();
			});
		});
	}

	public void StartScene(string string_0)
	{
		_RA1aFlOff0jGfI2cKUGhYI1MRLBA._PYAXEqRAOkDRRNqm1k71R7GJTJK(delegate
		{
			_OxLRmpxixplTKChiTPUKAx4uTLG(string_0, delegate
			{
				_RA1aFlOff0jGfI2cKUGhYI1MRLBA._FegL010tc92iskjjyD0T33dDwNE();
			});
		});
	}

	public void StartScene(AbstractScene AbstractScene_0)
	{
		_RA1aFlOff0jGfI2cKUGhYI1MRLBA._PYAXEqRAOkDRRNqm1k71R7GJTJK(delegate
		{
			_OxLRmpxixplTKChiTPUKAx4uTLG(AbstractScene_0, delegate
			{
				_RA1aFlOff0jGfI2cKUGhYI1MRLBA._FegL010tc92iskjjyD0T33dDwNE();
			});
		});
	}

	public void _OxLRmpxixplTKChiTPUKAx4uTLG<T>(Action action_0 = null) where T : AbstractScene
	{
		if (_ColBlKEOYSqQMmmj719vN58K9aN != null)
		{
			Action colBlKEOYSqQMmmj719vN58K9aN = _ColBlKEOYSqQMmmj719vN58K9aN;
			_ColBlKEOYSqQMmmj719vN58K9aN = null;
			colBlKEOYSqQMmmj719vN58K9aN();
		}
		_ColBlKEOYSqQMmmj719vN58K9aN = action_0;
		_chds2l0ZCMMghly7dv4eik3iSH5._n4NdRK3l14j7hHgGSJS4dI9LeYR();
		_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._Wrz1IORok7yBtsQA3czQUmnP6Yl(null);
		_fp8jsuSnELXqf2yy2JQDaXDCBVQ = null;
		_ieTMbMiu3eGRdmzTMofKoJopZAf = null;
		_Z8BClcChRJrlB6tR1VPJcycVpHN = Activator.CreateInstance(typeof(T), this) as AbstractScene;
		_NdzU0m9x8QDKpVv3DrQmzY5KduB = true;
	}

	public void _OxLRmpxixplTKChiTPUKAx4uTLG(string string_0, Action action_0 = null)
	{
		if (_ColBlKEOYSqQMmmj719vN58K9aN != null)
		{
			Action colBlKEOYSqQMmmj719vN58K9aN = _ColBlKEOYSqQMmmj719vN58K9aN;
			_ColBlKEOYSqQMmmj719vN58K9aN = null;
			colBlKEOYSqQMmmj719vN58K9aN();
		}
		_ColBlKEOYSqQMmmj719vN58K9aN = action_0;
		IEnumerable<Type> source = from type_0 in Assembly.GetAssembly(typeof(Amorous))!.GetTypes()
			where typeof(AbstractScene).IsAssignableFrom(type_0)
			select type_0;
		Type type = source.FirstOrDefault((Type type_0) => type_0.Name == string_0);
		if (!(type == null))
		{
			_chds2l0ZCMMghly7dv4eik3iSH5._n4NdRK3l14j7hHgGSJS4dI9LeYR();
			_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._Wrz1IORok7yBtsQA3czQUmnP6Yl(null);
			_fp8jsuSnELXqf2yy2JQDaXDCBVQ = null;
			_ieTMbMiu3eGRdmzTMofKoJopZAf = null;
			_Z8BClcChRJrlB6tR1VPJcycVpHN = Activator.CreateInstance(type, this) as AbstractScene;
			_NdzU0m9x8QDKpVv3DrQmzY5KduB = true;
		}
		else
		{
			Logger.Error("Failed to load scene '{0}'", string_0);
		}
	}

	public void _OxLRmpxixplTKChiTPUKAx4uTLG(AbstractScene AbstractScene_0, Action action_0 = null)
	{
		if (_ColBlKEOYSqQMmmj719vN58K9aN != null)
		{
			Action colBlKEOYSqQMmmj719vN58K9aN = _ColBlKEOYSqQMmmj719vN58K9aN;
			_ColBlKEOYSqQMmmj719vN58K9aN = null;
			colBlKEOYSqQMmmj719vN58K9aN();
		}
		_ColBlKEOYSqQMmmj719vN58K9aN = action_0;
		_chds2l0ZCMMghly7dv4eik3iSH5._n4NdRK3l14j7hHgGSJS4dI9LeYR();
		_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._Wrz1IORok7yBtsQA3czQUmnP6Yl(null);
		_fp8jsuSnELXqf2yy2JQDaXDCBVQ = null;
		_ieTMbMiu3eGRdmzTMofKoJopZAf = null;
		_Z8BClcChRJrlB6tR1VPJcycVpHN = AbstractScene_0;
		_NdzU0m9x8QDKpVv3DrQmzY5KduB = true;
	}

	public void _gYGB98heFqsLp9tgJbdCP01IKV2(string string_0)
	{
		IEnumerable<Type> source = from type_0 in Assembly.GetAssembly(typeof(Amorous))!.GetTypes()
			where typeof(_TwlwMC1hhdSzamwGWEBxuUkz1gH).IsAssignableFrom(type_0)
			select type_0;
		Type type = source.FirstOrDefault((Type type_0) => type_0.Name == string_0);
		if (!(type == null))
		{
			_ieTMbMiu3eGRdmzTMofKoJopZAf = Activator.CreateInstance(type, Amorous.Content) as _TwlwMC1hhdSzamwGWEBxuUkz1gH;
		}
		else
		{
			Logger.Error("Failed to load sexscene '{0}'", string_0);
		}
	}

	public void _Ec0fhBrUGmjaIKjUfJioigVc65x()
	{
		_ieTMbMiu3eGRdmzTMofKoJopZAf = null;
	}

	public void RequestScene(string string_0)
	{
		_nR8eroJOHehP0ZGyyTveo6aMTHg nR8eroJOHehP0ZGyyTveo6aMTHg_ = _5yVCuTv9lVSCCxs7cUlv79ysuRh(string_0);
		RequestScene(nR8eroJOHehP0ZGyyTveo6aMTHg_);
	}

	public void RequestScene(_nR8eroJOHehP0ZGyyTveo6aMTHg _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
	{
		if (_nR8eroJOHehP0ZGyyTveo6aMTHg_0 != null)
		{
			_Ta8oiGRfjrRGtgUaA5S061UepZb = _nR8eroJOHehP0ZGyyTveo6aMTHg_0;
			int int_ = _CCtbrNWS4Gi5hRSEsXYI5VzS7gI.Data.GetDecimal(_nR8eroJOHehP0ZGyyTveo6aMTHg_0.Data.Name);
			_poenyHBGUusBcnNcTFB9MQBV72R._RiDuYMeg3EHnBUteUcAb8VlfQVl();
			_Ta8oiGRfjrRGtgUaA5S061UepZb._4hlxzMzKSbVTbZUrEsP3dfw4x0h(int_);
		}
	}

	private _nR8eroJOHehP0ZGyyTveo6aMTHg _5yVCuTv9lVSCCxs7cUlv79ysuRh(string string_0)
	{
		string text = Path.Combine(_uwNDZuqdFb9tyQtlQMxiz1DQ7x8.RootDirectory, $"Content-Mods/Data/Quests/{string_0}.json");
		string text2 = Path.Combine(_uwNDZuqdFb9tyQtlQMxiz1DQ7x8.RootDirectory, $"Data/Quests/{string_0}.json");
		string value;
		if (File.Exists(text))
		{
			Logger.Warning("Loaded modded cutscene '{0}'", string_0);
			value = _K2047A8SCJdaw0LZKStEHOiH110._mDCA4AzhICQie5tejcL2uH7mcwf(text);
		}
		else
		{
			if (!File.Exists(text2))
			{
				Logger.Error("Failed to load cutscene '{0}'", string_0);
				return null;
			}
			value = _K2047A8SCJdaw0LZKStEHOiH110._GxOfTBefEUfWKWaWgxVRKsjugxE(text2);
		}
		JsonSerializerSettings settings = new JsonSerializerSettings
		{
			TypeNameHandling = TypeNameHandling.Auto,
			Converters = { (JsonConverter)new _VSQz6uDf5A6KqE8xqKxxcrkhZkA() }
		};
		Cutscene Cutscene = JsonConvert.DeserializeObject<Cutscene>(value, settings);
		if (Cutscene != null)
		{
			return new _nR8eroJOHehP0ZGyyTveo6aMTHg(this, Cutscene, Assembly.Load("Amorous.Game"));
		}
		return null;
	}

	private _zkUeZhJDizkmvvRfp4S0G7aap8J _PSROht9Hy1Ik63UUdnKDUGBA0yQ()
	{
		if (_5zNdOw7qHmuCAPJFMr3SsZdBlCr != null)
		{
			_zkUeZhJDizkmvvRfp4S0G7aap8J zkUeZhJDizkmvvRfp4S0G7aap8J = new _zkUeZhJDizkmvvRfp4S0G7aap8J
			{
				Name = _5zNdOw7qHmuCAPJFMr3SsZdBlCr.Data.Name,
				Stage = _5zNdOw7qHmuCAPJFMr3SsZdBlCr._VQZivNSvg2tVi52cTTAQKYhamQK.Data.Stage,
				ID = _5zNdOw7qHmuCAPJFMr3SsZdBlCr._VQZivNSvg2tVi52cTTAQKYhamQK._SWODlbUkQEqfwrtprjLPOeGF7HO.ID,
				Scene = Scene.GetType().Name,
				Subscene = Scene._hFeWJ5482CKD4l4529bYY1catC,
				Sexscene = Sexscene?.GetType().Name,
				SexscenePhase = (Sexscene?._rNGHguvWdrugQVL2AI6bMMKSORN ?? _TwlwMC1hhdSzamwGWEBxuUkz1gH._qokIrmaaT3Lq6znW10HdrPUO9Fq.Idle),
				SexsceneFinished = (Sexscene?._p3lU5oxIaFTVHUNFxJRnaHkXdsA ?? false),
				FadedOut = (_Qj2G6fpAF4mGsATgkV8DPBF3aA1A._SWODlbUkQEqfwrtprjLPOeGF7HO.A > 0)
			};
			zkUeZhJDizkmvvRfp4S0G7aap8J._gWHVDvr9GDtRXP2zf2Md18MgZ4b(_xfiKuXXh5LQA9CUQiex6tutzFKQ._VvFE2zgy4FbDjvaEvb67tXJ7aRm(NPCLocation.Left));
			zkUeZhJDizkmvvRfp4S0G7aap8J._gWHVDvr9GDtRXP2zf2Md18MgZ4b(_xfiKuXXh5LQA9CUQiex6tutzFKQ._VvFE2zgy4FbDjvaEvb67tXJ7aRm(NPCLocation.Middle));
			zkUeZhJDizkmvvRfp4S0G7aap8J._gWHVDvr9GDtRXP2zf2Md18MgZ4b(_xfiKuXXh5LQA9CUQiex6tutzFKQ._VvFE2zgy4FbDjvaEvb67tXJ7aRm(NPCLocation.Right));
			return zkUeZhJDizkmvvRfp4S0G7aap8J;
		}
		return null;
	}

	private void _dmwpjPj0QtK7OW2M486hHkm5FKH(_zkUeZhJDizkmvvRfp4S0G7aap8J _zkUeZhJDizkmvvRfp4S0G7aap8J_0)
	{
		_Qj2G6fpAF4mGsATgkV8DPBF3aA1A._PYAXEqRAOkDRRNqm1k71R7GJTJK(delegate
		{
			_nR8eroJOHehP0ZGyyTveo6aMTHg _hvKKVpHsQ6yw7YBy97lS8UDtil = _5yVCuTv9lVSCCxs7cUlv79ysuRh(_zkUeZhJDizkmvvRfp4S0G7aap8J_0.Name);
			if (_hvKKVpHsQ6yw7YBy97lS8UDtil != null)
			{
				_OxLRmpxixplTKChiTPUKAx4uTLG(_zkUeZhJDizkmvvRfp4S0G7aap8J_0.Scene, delegate
				{
					if (_zkUeZhJDizkmvvRfp4S0G7aap8J_0.Subscene != null)
					{
						Scene._6hE3geqxrB1vCirtSWHxIJjlTQB(_zkUeZhJDizkmvvRfp4S0G7aap8J_0.Subscene);
					}
					if (_zkUeZhJDizkmvvRfp4S0G7aap8J_0.Sexscene != null)
					{
						_gYGB98heFqsLp9tgJbdCP01IKV2(_zkUeZhJDizkmvvRfp4S0G7aap8J_0.Sexscene);
						Sexscene._eXH4tq2J0DADXDLofA8G8Yw8fau(_zkUeZhJDizkmvvRfp4S0G7aap8J_0.SexscenePhase, _zkUeZhJDizkmvvRfp4S0G7aap8J_0.SexsceneFinished);
					}
					foreach (_zkUeZhJDizkmvvRfp4S0G7aap8J._CIFXVF6lKl3nSrVOhqjcFXDVlXc item in _zkUeZhJDizkmvvRfp4S0G7aap8J_0.NPCs)
					{
						_QGGOTxZ8aNWGh0hc26wcmx8wmwT qGGOTxZ8aNWGh0hc26wcmx8wmwT = _TwQHHdbdRFRy2ctTZabNfz1Htrg(item.Name, LayerOrder.Background);
						qGGOTxZ8aNWGh0hc26wcmx8wmwT._7d2DAwjp6FutkJY09U0Mlk43Nmn(item.Location, item.Head, item.Pose, item.Clothes);
						_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve = _xfiKuXXh5LQA9CUQiex6tutzFKQ._VvFE2zgy4FbDjvaEvb67tXJ7aRm(item.Name);
						_3IHp43rpkJgOBcY9lrIrwMuwWve.LayerOrder = item.LayerOrder;
					}
					if (_zkUeZhJDizkmvvRfp4S0G7aap8J_0.FadedOut)
					{
						_Ta8oiGRfjrRGtgUaA5S061UepZb = _hvKKVpHsQ6yw7YBy97lS8UDtil;
						_Ta8oiGRfjrRGtgUaA5S061UepZb._4hlxzMzKSbVTbZUrEsP3dfw4x0h(_zkUeZhJDizkmvvRfp4S0G7aap8J_0.Stage, _zkUeZhJDizkmvvRfp4S0G7aap8J_0.ID);
					}
					else
					{
						_Qj2G6fpAF4mGsATgkV8DPBF3aA1A._FegL010tc92iskjjyD0T33dDwNE(delegate
						{
							_Ta8oiGRfjrRGtgUaA5S061UepZb = _hvKKVpHsQ6yw7YBy97lS8UDtil;
							_Ta8oiGRfjrRGtgUaA5S061UepZb._4hlxzMzKSbVTbZUrEsP3dfw4x0h(_zkUeZhJDizkmvvRfp4S0G7aap8J_0.Stage, _zkUeZhJDizkmvvRfp4S0G7aap8J_0.ID);
						});
					}
				});
			}
		});
	}

	public void _bHdVKtqP3Eb3DSJmuVTbkY8RtHP()
	{
		_CYyzfcX8IclN1GnWsApBFWBpush(0);
		_nvTYmpWmxq2DhO8ubfi3j5rZdLA();
		_xfiKuXXh5LQA9CUQiex6tutzFKQ._bHdVKtqP3Eb3DSJmuVTbkY8RtHP();
	}

	public void _lXEQJcXKxsjtZp00Y9aPe0ymGue<T>() where T : _8lVOgkauaSHbAkAqHzI1K7mIyOI
	{
		_fp8jsuSnELXqf2yy2JQDaXDCBVQ = Activator.CreateInstance(typeof(T), this) as _8lVOgkauaSHbAkAqHzI1K7mIyOI;
	}

	public void _lXEQJcXKxsjtZp00Y9aPe0ymGue<T>(T gparam_0) where T : _8lVOgkauaSHbAkAqHzI1K7mIyOI
	{
		_fp8jsuSnELXqf2yy2JQDaXDCBVQ = gparam_0;
	}

	public void _gYufry4VnA6Ur59PtBsOHrUA8SD()
	{
		_fp8jsuSnELXqf2yy2JQDaXDCBVQ = null;
	}

	public _QGGOTxZ8aNWGh0hc26wcmx8wmwT _VvFE2zgy4FbDjvaEvb67tXJ7aRm(string string_0)
	{
		if (_xfiKuXXh5LQA9CUQiex6tutzFKQ == null)
		{
			return null;
		}
		return _xfiKuXXh5LQA9CUQiex6tutzFKQ._VvFE2zgy4FbDjvaEvb67tXJ7aRm(string_0)?.NPC;
	}

	public _QGGOTxZ8aNWGh0hc26wcmx8wmwT _VvFE2zgy4FbDjvaEvb67tXJ7aRm(NPCLocation npclocation_0)
	{
		if (_xfiKuXXh5LQA9CUQiex6tutzFKQ == null)
		{
			return null;
		}
		return _xfiKuXXh5LQA9CUQiex6tutzFKQ._VvFE2zgy4FbDjvaEvb67tXJ7aRm(npclocation_0)?.NPC;
	}

	public _QGGOTxZ8aNWGh0hc26wcmx8wmwT _TwQHHdbdRFRy2ctTZabNfz1Htrg(string string_0, LayerOrder LayerOrder_0)
	{
		if (_xfiKuXXh5LQA9CUQiex6tutzFKQ != null)
		{
			_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve = _xfiKuXXh5LQA9CUQiex6tutzFKQ._VvFE2zgy4FbDjvaEvb67tXJ7aRm(string_0);
			if (_3IHp43rpkJgOBcY9lrIrwMuwWve == null)
			{
				IEnumerable<Type> source = from type_0 in Assembly.GetAssembly(typeof(Amorous))!.GetTypes()
					where typeof(_QGGOTxZ8aNWGh0hc26wcmx8wmwT).IsAssignableFrom(type_0) && !type_0.IsAbstract
					select type_0;
				Type type = source.FirstOrDefault((Type type_0) => type_0.Name == string_0);
				if (!(type == null))
				{
					if (Activator.CreateInstance(type, this) is _QGGOTxZ8aNWGh0hc26wcmx8wmwT qGGOTxZ8aNWGh0hc26wcmx8wmwT)
					{
						qGGOTxZ8aNWGh0hc26wcmx8wmwT.Game = this;
						qGGOTxZ8aNWGh0hc26wcmx8wmwT.Begin();
						_xfiKuXXh5LQA9CUQiex6tutzFKQ._gWHVDvr9GDtRXP2zf2Md18MgZ4b(qGGOTxZ8aNWGh0hc26wcmx8wmwT, (LayerOrder_0 == LayerOrder.None) ? LayerOrder.Background : LayerOrder_0);
						return qGGOTxZ8aNWGh0hc26wcmx8wmwT;
					}
					Logger.Error("Failed to instance npc '{0}'", string_0);
					return null;
				}
				Logger.Error("Failed to load npc '{0}'", string_0);
				return null;
			}
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT NPC = _3IHp43rpkJgOBcY9lrIrwMuwWve.NPC;
			if (NPC != null && NPC._SC7QlorMIWTLSkD757wC7ybszpE)
			{
				return null;
			}
			_3IHp43rpkJgOBcY9lrIrwMuwWve.Layer = ((LayerOrder_0 == LayerOrder.None) ? _3IHp43rpkJgOBcY9lrIrwMuwWve.Layer : LayerOrder_0);
			_3IHp43rpkJgOBcY9lrIrwMuwWve._ac2H6kMdrgPhXXxabsikjji4SiT = ((_3IHp43rpkJgOBcY9lrIrwMuwWve.Layer == LayerOrder.Background) ? 1 : 3);
			_xfiKuXXh5LQA9CUQiex6tutzFKQ._yMMFQ2n4dqXlB1AEzmdkoKkPkX5();
			return _3IHp43rpkJgOBcY9lrIrwMuwWve.NPC;
		}
		return null;
	}

	public T _TwQHHdbdRFRy2ctTZabNfz1Htrg<T>(LayerOrder LayerOrder_0) where T : _QGGOTxZ8aNWGh0hc26wcmx8wmwT
	{
		return _TwQHHdbdRFRy2ctTZabNfz1Htrg(typeof(T).Name, LayerOrder_0) as T;
	}

	public void _yh2DwZs16cvRtvGayeYZrMWlrbj(int int_0)
	{
		_DW9IcpdMEINZmuzfrqmwsduBGih.Save(int_0, new _lRHDfpOTd4PxClZkjMpoakPEA9d
		{
			Version = 5,
			PlayerData = _CCtbrNWS4Gi5hRSEsXYI5VzS7gI.Data,
			CutsceneState = _PSROht9Hy1Ik63UUdnKDUGBA0yQ(),
			SceneName = _xfiKuXXh5LQA9CUQiex6tutzFKQ.GetType().Name,
			PhoneEnabled = _poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj
		});
	}

	public void _CYyzfcX8IclN1GnWsApBFWBpush(int int_0)
	{
		_DW9IcpdMEINZmuzfrqmwsduBGih._3y7m8OGVjMe7WGIhZ66YOw3ITUE(int_0, new _lRHDfpOTd4PxClZkjMpoakPEA9d
		{
			Version = 5,
			PlayerData = _CCtbrNWS4Gi5hRSEsXYI5VzS7gI.Data,
			SceneName = _xfiKuXXh5LQA9CUQiex6tutzFKQ.GetType().Name,
			PhoneEnabled = _poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj
		});
	}

	public bool _Ut0dhlh4JTZBMNJPNxxI9f9VqTp(int int_0)
	{
		_nvTYmpWmxq2DhO8ubfi3j5rZdLA();
		_lRHDfpOTd4PxClZkjMpoakPEA9d lRHDfpOTd4PxClZkjMpoakPEA9d = _DW9IcpdMEINZmuzfrqmwsduBGih.Read(int_0);
		if (lRHDfpOTd4PxClZkjMpoakPEA9d != null)
		{
			_9gbCIL8lNtgBPuVMJ6pA7rCsMoT._NG0eIZcXsX6Fp38GhuED0LKeWHf(lRHDfpOTd4PxClZkjMpoakPEA9d);
			_CCtbrNWS4Gi5hRSEsXYI5VzS7gI.Data = lRHDfpOTd4PxClZkjMpoakPEA9d.PlayerData;
			_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = lRHDfpOTd4PxClZkjMpoakPEA9d.PhoneEnabled;
			_poenyHBGUusBcnNcTFB9MQBV72R._AZrO8MxMUE7cKsFYTQ4k9O3q7yC()._Xrfjrxr72hHh4bDdQB7HzEbJUCb();
			_nkzqFdEfDyLcyGikIKGcHjklI4y._NhL238TaCbkDiY6HXlWXZzzUYkm = Options.Data.DialogueTextSpeed;
			_nkzqFdEfDyLcyGikIKGcHjklI4y._fUgDiz7KX8TZUVzFlTeXMOhmfUT = Options.Data.DialogueAutoSkip;
			if (lRHDfpOTd4PxClZkjMpoakPEA9d.CutsceneState != null)
			{
				_dmwpjPj0QtK7OW2M486hHkm5FKH(lRHDfpOTd4PxClZkjMpoakPEA9d.CutsceneState);
			}
			else
			{
				if (!_dKSAtbg8U4PX1oOcOJ2BFewVtcI.Contains(lRHDfpOTd4PxClZkjMpoakPEA9d.SceneName))
				{
					lRHDfpOTd4PxClZkjMpoakPEA9d.SceneName = typeof(ClubInsideScene).Name;
				}
				if (!_9gbCIL8lNtgBPuVMJ6pA7rCsMoT._RUw8RieezXPoVSmbk3eROtfKXVi(this, lRHDfpOTd4PxClZkjMpoakPEA9d))
				{
					StartScene(lRHDfpOTd4PxClZkjMpoakPEA9d.SceneName);
				}
			}
			return true;
		}
		return false;
	}

	public bool _1yDW5GeZ2MCcssz8ohrF9CK913i(int int_0)
	{
		_nvTYmpWmxq2DhO8ubfi3j5rZdLA();
		_lRHDfpOTd4PxClZkjMpoakPEA9d lRHDfpOTd4PxClZkjMpoakPEA9d = _DW9IcpdMEINZmuzfrqmwsduBGih._NyR9YmfkeF4CXGOi1ENApzh6B5V(int_0);
		if (lRHDfpOTd4PxClZkjMpoakPEA9d != null)
		{
			_9gbCIL8lNtgBPuVMJ6pA7rCsMoT._NG0eIZcXsX6Fp38GhuED0LKeWHf(lRHDfpOTd4PxClZkjMpoakPEA9d);
			_CCtbrNWS4Gi5hRSEsXYI5VzS7gI.Data = lRHDfpOTd4PxClZkjMpoakPEA9d.PlayerData;
			_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = lRHDfpOTd4PxClZkjMpoakPEA9d.PhoneEnabled;
			_poenyHBGUusBcnNcTFB9MQBV72R._AZrO8MxMUE7cKsFYTQ4k9O3q7yC()._Xrfjrxr72hHh4bDdQB7HzEbJUCb();
			_nkzqFdEfDyLcyGikIKGcHjklI4y._NhL238TaCbkDiY6HXlWXZzzUYkm = Options.Data.DialogueTextSpeed;
			_nkzqFdEfDyLcyGikIKGcHjklI4y._fUgDiz7KX8TZUVzFlTeXMOhmfUT = Options.Data.DialogueAutoSkip;
			if (!_dKSAtbg8U4PX1oOcOJ2BFewVtcI.Contains(lRHDfpOTd4PxClZkjMpoakPEA9d.SceneName))
			{
				lRHDfpOTd4PxClZkjMpoakPEA9d.SceneName = typeof(ClubInsideScene).Name;
			}
			if (!_9gbCIL8lNtgBPuVMJ6pA7rCsMoT._RUw8RieezXPoVSmbk3eROtfKXVi(this, lRHDfpOTd4PxClZkjMpoakPEA9d))
			{
				StartScene(lRHDfpOTd4PxClZkjMpoakPEA9d.SceneName);
			}
			return true;
		}
		return false;
	}

	public void _EXfoFnp1OKxeZbd4GcVZMCO2urH(string string_0, string string_1, string string_2)
	{
		_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t().Messages.Add(new PhoneMessage
		{
			Icon = string_0,
			Title = string_1,
			Message = string_2,
			Date = DateTime.Now
		});
		_9rxbJ7LsE3DhACUHVlPZaixc5Jp._EXfoFnp1OKxeZbd4GcVZMCO2urH(string_0, string_1, string_2);
	}

	private void _pql4s9X0U3svdBghGax6VsdF2Gq()
	{
		_nvTYmpWmxq2DhO8ubfi3j5rZdLA();
		StartScene<MainMenuScene>();
	}

	private void _nvTYmpWmxq2DhO8ubfi3j5rZdLA()
	{
		if (_5zNdOw7qHmuCAPJFMr3SsZdBlCr != null)
		{
			_5zNdOw7qHmuCAPJFMr3SsZdBlCr.ResetProgression();
		}
		_poenyHBGUusBcnNcTFB9MQBV72R._RiDuYMeg3EHnBUteUcAb8VlfQVl();
		_poenyHBGUusBcnNcTFB9MQBV72R._AZrO8MxMUE7cKsFYTQ4k9O3q7yC().ResetProgression();
		_nkzqFdEfDyLcyGikIKGcHjklI4y._gVRGC9VAGHCLvP8p5Q4mqLPvFCm();
		_nkzqFdEfDyLcyGikIKGcHjklI4y._h0KfaNiikKlJV2KkRPIdVDKVJnC();
		_RA1aFlOff0jGfI2cKUGhYI1MRLBA._E7yBM68AWt7OGHJ5D6xYA8RK8tAA(new Color(0, 0, 0, 0));
	}
}
