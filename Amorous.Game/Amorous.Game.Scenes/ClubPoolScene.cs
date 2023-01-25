using System;
using System.Collections.Generic;
using System.Linq;
using Amorous.Game.NPC;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Amorous.Game.Scenes;

public class ClubPoolScene : AbstractScene
{
	private class FrameAnimationLayer : _fAUddQEKfZyemRb327NhM3GGlmzA
	{
		private readonly Texture2D _animationTexture;

		private Rectangle _destinationRectangle;

		private Rectangle _sourceRectangle;

		private readonly Vector2 _origin;

		private readonly float _timePerFrame;

		private readonly int _numberOfFrames;

		private int _currentFrame;

		private float _angle;

		private float _time;

		public FrameAnimationLayer(AbstractScene AbstractScene_0, string string_0, float float_0, int int_0, int int_1, int int_2, float float_1)
			: base(AbstractScene_0, "FrameAnimationLayer")
		{
			_animationTexture = AbstractScene_0.Game._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>(string_0);
			_timePerFrame = float_0 / (float)int_0;
			_numberOfFrames = int_0;
			_currentFrame = 0;
			_sourceRectangle = new Rectangle(0, 0, (int)((float)_animationTexture.Width / (float)int_0), _animationTexture.Height);
			_destinationRectangle = new Rectangle(0, 0, (int)((float)_sourceRectangle.Width * float_1), (int)((float)_sourceRectangle.Height * float_1));
			_origin = new Vector2(int_1, int_2);
			base._NC5P3SKqKPpcAYG1mqquUEcUzTg = delegate(GameTime time)
			{
				MyUpdate((float)time.ElapsedGameTime.Milliseconds / 1000f);
			};
			base._B6VrMlmWofCGqEzjzgFJiAliCge = MyDraw;
		}

		public void Play(int x, int y, int startFrame, float angle)
		{
			_destinationRectangle.X = x;
			_destinationRectangle.Y = y;
			_currentFrame = startFrame;
			_angle = MathHelper.ToRadians(angle);
		}

		private void MyUpdate(float deltaTime)
		{
			if (_currentFrame >= 0)
			{
				_time += deltaTime;
				while (_time > _timePerFrame)
				{
					_time -= _timePerFrame;
					_currentFrame++;
				}
				if (_currentFrame < _numberOfFrames)
				{
					_sourceRectangle.X = _currentFrame * _sourceRectangle.Width;
				}
				else
				{
					_currentFrame = 0;
				}
			}
		}

		private void MyDraw(SpriteBatch spriteBatch)
		{
			if (_currentFrame >= 0)
			{
				spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, base._3TrGrUra7cqeIXkbZOrfaoQaD5F);
				spriteBatch.Draw(_animationTexture, _destinationRectangle, _sourceRectangle, Color.White, _angle, _origin, SpriteEffects.None, 0f);
				spriteBatch.End();
			}
		}
	}

	private ClubStaticRemyNPC _remy;

	private readonly bool _showRemy;

	public ClubPoolScene(IAmorous game)
		: base(Game)
	{
		_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Background", "Assets/Scenes/ClubPool/Club Pool main", -1677, 0);
		_2CHUZ5vSi5NbJYJ4gGtr3C2VVEo("Door", "Assets/Scenes/ClubPool/Pool door selectable", -691, 0, OnDoorClick);
		_lnXs1JfCeIBNCpFYs8XVRorc0h4 gparam_ = new _lnXs1JfCeIBNCpFYs8XVRorc0h4(this)
		{
			_WBXNT6eIVGk6ZKExRBJ6JxXE6zb_002E_GDeKFFD8Rxnpsjzy36lUBxAEopc = 1525f,
			_WBXNT6eIVGk6ZKExRBJ6JxXE6zb_002E_JpSvHH1W0gFCpaNEH5zB1qsDJXY = 890f
		};
		_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(gparam_, 2);
		FrameAnimationLayer frameAnimationLayer = new FrameAnimationLayer(this, "Assets/Scenes/ClubPool/ShowerParticle", 0.5f, 5, 200, 30, 1.5f);
		frameAnimationLayer.Play(-1420, 200, 0, 10f);
		FrameAnimationLayer frameAnimationLayer2 = new FrameAnimationLayer(this, "Assets/Scenes/ClubPool/ShowerParticle", 0.5f, 5, 200, 30, 1.5f);
		frameAnimationLayer2.Play(-1170, 200, 2, 10f);
		_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(frameAnimationLayer, 2);
		_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(frameAnimationLayer2, 2);
		_NC5VT77x8y2iH2pW56TBN1eyomA("Foreground", "Assets/Scenes/ClubPool/Club Pool top", -1677, 0);
		_NC5VT77x8y2iH2pW56TBN1eyomA("Foreground", "Assets/Scenes/ClubPool/Club Pool railing", 2041, 351);
		Game._vsceSzSIjBy2nZrCxAzKZbUiwLq._wFfc7xL7eKxed7i9gWtao7pgsnm(-1677, 1677, 0, 0);
		_UmxbIbk7pgaod0bD7pS309P3Lns._QrgbXEg7MMeD9Ybz12fFVsbmAd9(_KZ7hNP1K5E99Xfup1lTZ9UDrxPE._oCy13KHJxLHriH7TwMiQ1qKJ8Uc, 0.4f, bool_0: true, bool_1: true);
		PlayerData opIJo2jLUqdOL5yAFP4yzXce0DG = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
		_showRemy = !opIJo2jLUqdOL5yAFP4yzXce0DG.GetBit("RemyLeftClub");
		if (_showRemy)
		{
			_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Shadow", "Assets/Scenes/ClubPool/ShadowRemy", 995, 517);
		}
	}

	public override void Start()
	{
		base._4hlxzMzKSbVTbZUrEsP3dfw4x0h();
		ClubPoolStaticANPC clubPoolStaticANPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticANPC>(LayerOrder.Background);
		clubPoolStaticANPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = -1400f;
		clubPoolStaticANPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 910f;
		ClubPoolStaticBNPC clubPoolStaticBNPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticBNPC>(LayerOrder.Background);
		clubPoolStaticBNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = -1401f;
		clubPoolStaticBNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 230f;
		ClubPoolStaticENPC clubPoolStaticENPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticENPC>(LayerOrder.Background);
		clubPoolStaticENPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 106f;
		clubPoolStaticENPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 397f;
		ClubPoolStaticCNPC clubPoolStaticCNPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticCNPC>(LayerOrder.Foreground);
		clubPoolStaticCNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = -180f;
		clubPoolStaticCNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 450f;
		ClubPoolStaticCNPC2 clubPoolStaticCNPC2 = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticCNPC2>(LayerOrder.Background);
		clubPoolStaticCNPC2._qFVIvzuvIuKKG5vOrovLtn4NplA = clubPoolStaticCNPC._qFVIvzuvIuKKG5vOrovLtn4NplA;
		clubPoolStaticCNPC2._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = clubPoolStaticCNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX;
		clubPoolStaticCNPC2._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = clubPoolStaticCNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY;
		ClubPoolStaticFNPC clubPoolStaticFNPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticFNPC>(LayerOrder.Foreground);
		clubPoolStaticFNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 500f;
		clubPoolStaticFNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 180f;
		ClubPoolStaticGHINPC clubPoolStaticGHINPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticGHINPC>(LayerOrder.Foreground);
		clubPoolStaticGHINPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 370f;
		clubPoolStaticGHINPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 450f;
		ClubPoolStaticGHINPC2 clubPoolStaticGHINPC2 = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticGHINPC2>(LayerOrder.Background);
		clubPoolStaticGHINPC2._qFVIvzuvIuKKG5vOrovLtn4NplA = clubPoolStaticGHINPC._qFVIvzuvIuKKG5vOrovLtn4NplA;
		clubPoolStaticGHINPC2._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = clubPoolStaticGHINPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX;
		clubPoolStaticGHINPC2._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = clubPoolStaticGHINPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY;
		ClubPoolStaticDNPC clubPoolStaticDNPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticDNPC>(LayerOrder.Foreground);
		clubPoolStaticDNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 50f;
		clubPoolStaticDNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 690f;
		ClubPoolStaticDNPC2 clubPoolStaticDNPC2 = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticDNPC2>(LayerOrder.Background);
		clubPoolStaticDNPC2._qFVIvzuvIuKKG5vOrovLtn4NplA = clubPoolStaticDNPC._qFVIvzuvIuKKG5vOrovLtn4NplA;
		clubPoolStaticDNPC2._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = clubPoolStaticDNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX;
		clubPoolStaticDNPC2._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = clubPoolStaticDNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY;
		if (_showRemy)
		{
			_remy = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubStaticRemyNPC>(LayerOrder.Foreground);
			_remy._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 1010f;
			_remy._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 150f;
			_remy._ZVpZ5Oing5kbbVhbmbOHyrofGH7 = OnRemyClick;
		}
		ClubPoolStaticJKNPC clubPoolStaticJKNPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticJKNPC>(LayerOrder.Foreground);
		clubPoolStaticJKNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 1269f;
		clubPoolStaticJKNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 383f;
		ClubPoolStaticJKNPC2 clubPoolStaticJKNPC2 = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticJKNPC2>(LayerOrder.Background);
		clubPoolStaticJKNPC2._qFVIvzuvIuKKG5vOrovLtn4NplA = clubPoolStaticJKNPC._qFVIvzuvIuKKG5vOrovLtn4NplA;
		clubPoolStaticJKNPC2._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = clubPoolStaticJKNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX;
		clubPoolStaticJKNPC2._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = clubPoolStaticJKNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY;
		ClubPoolStaticLNPC clubPoolStaticLNPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticLNPC>(LayerOrder.Background);
		clubPoolStaticLNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 1630f;
		clubPoolStaticLNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 106f;
		ClubPoolStaticMNPC clubPoolStaticMNPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticMNPC>(LayerOrder.Background);
		clubPoolStaticMNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 1879f;
		clubPoolStaticMNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 106f;
		ClubPoolStaticNNPC clubPoolStaticNNPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticNNPC>(LayerOrder.Background);
		clubPoolStaticNNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 2039f;
		clubPoolStaticNNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 106f;
		ClubPoolStaticOPNPC clubPoolStaticOPNPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticOPNPC>(LayerOrder.Foreground);
		clubPoolStaticOPNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 2223f;
		clubPoolStaticOPNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 442f;
		ClubPoolStaticOPNPC2 clubPoolStaticOPNPC2 = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticOPNPC2>(LayerOrder.Background);
		clubPoolStaticOPNPC2._qFVIvzuvIuKKG5vOrovLtn4NplA = clubPoolStaticOPNPC._qFVIvzuvIuKKG5vOrovLtn4NplA;
		clubPoolStaticOPNPC2._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = clubPoolStaticOPNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX;
		clubPoolStaticOPNPC2._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = clubPoolStaticOPNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY;
		ClubPoolStaticQRNPC clubPoolStaticQRNPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticQRNPC>(LayerOrder.Foreground);
		clubPoolStaticQRNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 2694f;
		clubPoolStaticQRNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 97f;
	}

	public override void Update(GameTime gameTime)
	{
		if (_Bj3jScuqBJCFV58AWBDg8HofpqY)
		{
			List<_ujAkjlfN5TywwbLAUDzPvtab6uJ> list = base.Layers.Where((_ujAkjlfN5TywwbLAUDzPvtab6uJ x) => x is _3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve && (!(_3IHp43rpkJgOBcY9lrIrwMuwWve.NPC is ClubStaticNPC) || !(_3IHp43rpkJgOBcY9lrIrwMuwWve.NPC is ClubStaticSpineNPC))).ToList();
			list.ForEach(delegate(_ujAkjlfN5TywwbLAUDzPvtab6uJ x)
			{
				x._ac2H6kMdrgPhXXxabsikjji4SiT = 3;
			});
		}
		base.Update(gameTime);
	}

	private void OnDoorClick()
	{
		base.Game.StartScene<ClubUpstairsScene>();
	}

	private void OnRemyClick()
	{
		base.Game.RequestScene("RemyPreDate");
	}
}
