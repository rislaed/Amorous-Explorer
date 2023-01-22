using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Amorous.Engine.GUI;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Squid;

namespace Amorous.Game.Scenes;

public class MainMenuScene : TimeOfDayScene
{
	private const int _mSId4q6YMjIv6JDktud9oXTl98M = 750;

	private int _BR9uYwHtclf8uWEyxJ20ADY6mpg;

	private readonly _ujAkjlfN5TywwbLAUDzPvtab6uJ _dNKOpSAr033bMQm76I1LEv39GTm;

	private readonly List<_Yu3OngEjZbsgelWEySu6GE7aoYg> _3QdafDZxM3h1i8B990AwwFqleds = new List<_Yu3OngEjZbsgelWEySu6GE7aoYg>();

	private readonly _SsogwGgurAXPoDRtNVTCVKq9yRE _zBw0aG4VRggByEYsHPjIPCYfoQJ;

	private readonly _uqydQVaCmCvK7zzWs5W4gZFpKBu _CD732c1llp0dkEnK6CI9WZR70Ap;

	public MainMenuScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Background", "Assets/Scenes/MainMenu/Menu Background", -240, -135);
		_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Bed", "Assets/Scenes/MainMenu/Bed", -240, -135);
		_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Logo", "Assets/Scenes/MainMenu/Bed Logo", -240, -135);
		_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Table", "Assets/Scenes/MainMenu/Table and clock", -240, -135);
		_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("LCD Separator", "Assets/Scenes/MainMenu/Semicolon", -155, -135);
		_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(new _fAUddQEKfZyemRb327NhM3GGlmzA(this, "Custom")
		{
			_B6VrMlmWofCGqEzjzgFJiAliCge = _KkwafXXLVg1QfQgqqCAojg2ySyZ
		}, 0);
		_NC5VT77x8y2iH2pW56TBN1eyomA("Sheet", "Assets/Scenes/MainMenu/Bed Sheet", -240, -135);
		_CD732c1llp0dkEnK6CI9WZR70Ap = _Iz47swAAB7d2iX6PQ1xTIJIv8MJ("Title", "Assets/Scenes/MainMenu/Logo", 1220, 800);
		_mdGACc5Q6BQjhranQdPI7V5unWx("LCD 1", "Assets/Scenes/MainMenu/{0}", 1090, 330);
		_mdGACc5Q6BQjhranQdPI7V5unWx("LCD 2", "Assets/Scenes/MainMenu/{0}", 1215, 330);
		_mdGACc5Q6BQjhranQdPI7V5unWx("LCD 3", "Assets/Scenes/MainMenu/{0}", 1395, 330);
		_mdGACc5Q6BQjhranQdPI7V5unWx("LCD 4", "Assets/Scenes/MainMenu/{0}", 1520, 330);
		_BR9uYwHtclf8uWEyxJ20ADY6mpg = 750;
		_dNKOpSAr033bMQm76I1LEv39GTm = _0c5TjZklJbu1wzYG2FIcvf3SIdh("LCD Separator");
		_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._Wrz1IORok7yBtsQA3czQUmnP6Yl(new _hiwkgwXJpRLUFatcgZFfH6ECNfm(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0));
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/WarmanSteve - Giant Robots", 0.4f);
		_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._lXEQJcXKxsjtZp00Y9aPe0ymGue(new _BlUQCbX8YXbBc38I7iPEHyF1rUQ(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		{
			_uIOOxdCbSvCxXvjNgoXh2qYj0hr = delegate
			{
				base._ZzBuoSDMWwerejOO9Goyv2OCKgE._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b = false;
				base._PnkAlVnMv0SZvRBFexqzE5DF9tp._GtkWDtXwQHwgWY4aFkacjfUDyzb("What would you like to do?", new string[4] { "New Game", "New Game w/o Prologue", "Character Customization", "Oops, I've changed my mind!" }, 500, delegate(int int_0)
				{
					_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
					switch (int_0)
					{
					default:
						base._ZzBuoSDMWwerejOO9Goyv2OCKgE._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b = true;
						break;
					case 0:
						_UmxbIbk7pgaod0bD7pS309P3Lns._PYAXEqRAOkDRRNqm1k71R7GJTJK();
						opIJo2jLUqdOL5yAFP4yzXce0DG._Rj5BZHY1n3a8XV7jJAk9U8jZZ6m();
						_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = false;
						_nkzqFdEfDyLcyGikIKGcHjklI4y._NhL238TaCbkDiY6HXlWXZzzUYkm = _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._wVLRBSMULz8GfedBPXaVJB0sBEO;
						_nkzqFdEfDyLcyGikIKGcHjklI4y._fUgDiz7KX8TZUVzFlTeXMOhmfUT = _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._sbK0941BvW8HgPboNwOhIAd2jP3;
						base._ZzBuoSDMWwerejOO9Goyv2OCKgE._xyl3Tv5KdR5eezDgagxbBcS3cwt("Prologue");
						break;
					case 1:
						_UmxbIbk7pgaod0bD7pS309P3Lns._PYAXEqRAOkDRRNqm1k71R7GJTJK();
						opIJo2jLUqdOL5yAFP4yzXce0DG._Rj5BZHY1n3a8XV7jJAk9U8jZZ6m();
						_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = false;
						_nkzqFdEfDyLcyGikIKGcHjklI4y._NhL238TaCbkDiY6HXlWXZzzUYkm = _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._wVLRBSMULz8GfedBPXaVJB0sBEO;
						_nkzqFdEfDyLcyGikIKGcHjklI4y._fUgDiz7KX8TZUVzFlTeXMOhmfUT = _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._sbK0941BvW8HgPboNwOhIAd2jP3;
						base._ZzBuoSDMWwerejOO9Goyv2OCKgE._k9wUPeU1Ga7cygiuGP8TT6aPLWF<SkipProloguePlayerCustomizationScene>();
						break;
					case 2:
						_UmxbIbk7pgaod0bD7pS309P3Lns._PYAXEqRAOkDRRNqm1k71R7GJTJK();
						opIJo2jLUqdOL5yAFP4yzXce0DG._Rj5BZHY1n3a8XV7jJAk9U8jZZ6m();
						_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = false;
						_nkzqFdEfDyLcyGikIKGcHjklI4y._NhL238TaCbkDiY6HXlWXZzzUYkm = _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._wVLRBSMULz8GfedBPXaVJB0sBEO;
						_nkzqFdEfDyLcyGikIKGcHjklI4y._fUgDiz7KX8TZUVzFlTeXMOhmfUT = _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._sbK0941BvW8HgPboNwOhIAd2jP3;
						base._ZzBuoSDMWwerejOO9Goyv2OCKgE._k9wUPeU1Ga7cygiuGP8TT6aPLWF<PlayerCustomizationScene>();
						break;
					}
				});
			},
			_HmpXEsA3mxR8eI4MZmgIPCtSGQb = delegate
			{
				base._ZzBuoSDMWwerejOO9Goyv2OCKgE._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b = false;
				List<_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p> _rQhndDODcLCmH9PKjwXRNz0AcU8 = _DW9IcpdMEINZmuzfrqmwsduBGih._25D1ZH2er0EbpKmvFksAbFjP2OX(bool_0: false);
				List<string> _ILFAnNbgAYkKwOVs9Pn9012gw1w = _rQhndDODcLCmH9PKjwXRNz0AcU8.Select((_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p _3CCr8Bt1rkuzt0M6gYLbceJGV0p_0) => _3CCr8Bt1rkuzt0M6gYLbceJGV0p_0._RB8fRXeQvK5vs7JEA0XfVCEpg1i).ToList();
				_ILFAnNbgAYkKwOVs9Pn9012gw1w.Add("Oops, I've changed my mind!");
				base._PnkAlVnMv0SZvRBFexqzE5DF9tp._GtkWDtXwQHwgWY4aFkacjfUDyzb("Which save do you wish to load?", _ILFAnNbgAYkKwOVs9Pn9012gw1w.ToArray(), 500, delegate(int int_0)
				{
					if (int_0 == _ILFAnNbgAYkKwOVs9Pn9012gw1w.Count - 1)
					{
						base._ZzBuoSDMWwerejOO9Goyv2OCKgE._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b = true;
					}
					else
					{
						_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p _3CCr8Bt1rkuzt0M6gYLbceJGV0p = _rQhndDODcLCmH9PKjwXRNz0AcU8[int_0];
						if (!_3CCr8Bt1rkuzt0M6gYLbceJGV0p._r4LqoJiAr5K9UiLsUzUDbcJDQqo)
						{
							if (!((!_3CCr8Bt1rkuzt0M6gYLbceJGV0p._3y7m8OGVjMe7WGIhZ66YOw3ITUE) ? base._ZzBuoSDMWwerejOO9Goyv2OCKgE._Ut0dhlh4JTZBMNJPNxxI9f9VqTp(_3CCr8Bt1rkuzt0M6gYLbceJGV0p._B3FsRMcQWBXzFf3nLOBKzncessO) : base._ZzBuoSDMWwerejOO9Goyv2OCKgE._1yDW5GeZ2MCcssz8ohrF9CK913i(_3CCr8Bt1rkuzt0M6gYLbceJGV0p._B3FsRMcQWBXzFf3nLOBKzncessO)))
							{
								base._PnkAlVnMv0SZvRBFexqzE5DF9tp._0pVU36wp9GYD1jM18raZtVEbA9q("Failed to load save, it's most likely corrupted.", 250, "OK", delegate
								{
									base._ZzBuoSDMWwerejOO9Goyv2OCKgE._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b = true;
								});
							}
							else
							{
								base._ZzBuoSDMWwerejOO9Goyv2OCKgE._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b = true;
							}
						}
						else
						{
							base._PnkAlVnMv0SZvRBFexqzE5DF9tp._0pVU36wp9GYD1jM18raZtVEbA9q(string.Format("There is no save in {0}slot #{1}!", _3CCr8Bt1rkuzt0M6gYLbceJGV0p._3y7m8OGVjMe7WGIhZ66YOw3ITUE ? "autosave " : string.Empty, int_0 + 1), 250, "OK", delegate
							{
								base._ZzBuoSDMWwerejOO9Goyv2OCKgE._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b = true;
							});
						}
					}
				});
			},
			_vE5Pvwth7cQFh82bMTB5u59Ju4o = delegate
			{
				base._ZzBuoSDMWwerejOO9Goyv2OCKgE._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b = false;
				base._PnkAlVnMv0SZvRBFexqzE5DF9tp._GtkWDtXwQHwgWY4aFkacjfUDyzb("Are you sure you wish to quit the game?", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, 500, delegate(int int_0)
				{
					if (int_0 == 1)
					{
						base._ZzBuoSDMWwerejOO9Goyv2OCKgE._Qj2G6fpAF4mGsATgkV8DPBF3aA1A._PYAXEqRAOkDRRNqm1k71R7GJTJK(delegate
						{
							base._ZzBuoSDMWwerejOO9Goyv2OCKgE._udfEpcIRn7lWl5Lvjdyu0aG0A7G();
						});
					}
					base._ZzBuoSDMWwerejOO9Goyv2OCKgE._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b = true;
				});
			}
		});
		_zBw0aG4VRggByEYsHPjIPCYfoQJ = new _SsogwGgurAXPoDRtNVTCVKq9yRE(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		{
			_a6EfzLkl5vzR053eenrcOponhUA = _MRzbkwglCADk2fFjoxcsdCSJfKu
		};
		_5Anqe6GAAkzemoAXYpJmgMlk1yz._3DInasj5B11bCcV5BIRvLE1Ay7w = true;
	}

	public override void _4hlxzMzKSbVTbZUrEsP3dfw4x0h()
	{
	}

	public _Yu3OngEjZbsgelWEySu6GE7aoYg _mdGACc5Q6BQjhranQdPI7V5unWx(string string_0, string string_1, int int_0, int int_1)
	{
		Texture2D[] array = new Texture2D[10];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = base._ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>(string.Format(string_1, i));
		}
		_Yu3OngEjZbsgelWEySu6GE7aoYg yu3OngEjZbsgelWEySu6GE7aoYg = new _Yu3OngEjZbsgelWEySu6GE7aoYg(this, string_0, array)
		{
			_C6GAq9XPMC9PQPnaaRqYWpv4V6S = true,
			_7Xn1C5tjYnmIif1iZKV8AWsEEbL = int_0,
			_bCjZ3VSXGKyhmykd2zCnQBiSpDf = int_1
		};
		_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(yu3OngEjZbsgelWEySu6GE7aoYg, 2);
		_3QdafDZxM3h1i8B990AwwFqleds.Add(yu3OngEjZbsgelWEySu6GE7aoYg);
		return yu3OngEjZbsgelWEySu6GE7aoYg;
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		base._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
		_BR9uYwHtclf8uWEyxJ20ADY6mpg -= gameTime_0.ElapsedGameTime.Milliseconds;
		if (_BR9uYwHtclf8uWEyxJ20ADY6mpg < 0)
		{
			_dNKOpSAr033bMQm76I1LEv39GTm._Fxy2SlgceW90FloFw6a1AEJODYA = !_dNKOpSAr033bMQm76I1LEv39GTm._Fxy2SlgceW90FloFw6a1AEJODYA;
			_BR9uYwHtclf8uWEyxJ20ADY6mpg = 750;
		}
		_3QdafDZxM3h1i8B990AwwFqleds[0]._SWODlbUkQEqfwrtprjLPOeGF7HO = DateTime.Now.Hour / 10;
		_3QdafDZxM3h1i8B990AwwFqleds[1]._SWODlbUkQEqfwrtprjLPOeGF7HO = DateTime.Now.Hour % 10;
		_3QdafDZxM3h1i8B990AwwFqleds[2]._SWODlbUkQEqfwrtprjLPOeGF7HO = DateTime.Now.Minute / 10;
		_3QdafDZxM3h1i8B990AwwFqleds[3]._SWODlbUkQEqfwrtprjLPOeGF7HO = DateTime.Now.Minute % 10;
		if (base._ZzBuoSDMWwerejOO9Goyv2OCKgE._o2QVQfIAsuLcmPxn14llGoZA52y != null)
		{
			_zBw0aG4VRggByEYsHPjIPCYfoQJ._nJKYvZJ57vjjlQwmoeBmKihtS0b = base._ZzBuoSDMWwerejOO9Goyv2OCKgE._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b;
			_zBw0aG4VRggByEYsHPjIPCYfoQJ._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
		}
	}

	public void _KkwafXXLVg1QfQgqqCAojg2ySyZ(SpriteBatch spriteBatch_0)
	{
		if (_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._yuFBJdi7mxrwMFQ57BjLjSq6ESj._mW1Z69pRB1eedGT3FSmdItJre5Y != null)
		{
			spriteBatch_0._g9Sx54kMPiHz5jrqWh4Kb1pTijH(SpriteSortMode.Deferred, BlendState.NonPremultiplied, null, null, null, null, Matrix.CreateTranslation(-100f, -390f, 0f) * Matrix.CreateRotationZ((float)Math.Sin(_boyt8NIMtKsAGSTcjHeL0WMbFxs._AmIUCcrmrrQiiirja7DoiZSjXuv) * MathHelper.ToRadians(5f)) * Matrix.CreateTranslation(90f, 390f, 0f));
			_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._yuFBJdi7mxrwMFQ57BjLjSq6ESj._mW1Z69pRB1eedGT3FSmdItJre5Y._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0);
			spriteBatch_0.End();
		}
	}

	public override void _Z70nK2EA1n5FNJxjWP0TzHQ0Lzb(SpriteBatch spriteBatch_0)
	{
		base._Z70nK2EA1n5FNJxjWP0TzHQ0Lzb(spriteBatch_0);
		spriteBatch_0.Begin();
		_CD732c1llp0dkEnK6CI9WZR70Ap._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0);
		spriteBatch_0.End();
		_zBw0aG4VRggByEYsHPjIPCYfoQJ._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0);
	}

	private void _MRzbkwglCADk2fFjoxcsdCSJfKu()
	{
		base._ZzBuoSDMWwerejOO9Goyv2OCKgE._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b = false;
		int num = 0;
		if (_iExD93IWLlzVfXsU9wyrEvWgJsg._X41qA9hgcgXH0Q1aFKWFWpg8UuM)
		{
			num += 60;
		}
		if (!_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
		{
			num += 60;
		}
		Window _L7VColD35B3sDgJdUnjTeXGa7pv = new Window
		{
			Dock = DockStyle.Center,
			Size = new Squid.Point(512, 540 + num),
			Margin = new Margin(8),
			Padding = new Margin(8)
		};
		Panel panel = new Panel
		{
			Dock = DockStyle.Fill,
			Margin = new Margin(8)
		};
		_L7VColD35B3sDgJdUnjTeXGa7pv.Controls.Add(panel);
		Label item = new Label
		{
			Dock = DockStyle.Top,
			TextAlign = Alignment.MiddleCenter,
			Text = "Display"
		};
		Label item2 = new Label
		{
			Dock = DockStyle.Top,
			Text = "Resolutions"
		};
		DropDownList dropDownList = new DropDownList();
		dropDownList.Dock = DockStyle.Top;
		dropDownList.Style = "button";
		dropDownList.Label.Margin = new Margin(10, 0, 0, 0);
		dropDownList.Dropdown.Resizable = false;
		dropDownList.Margin = new Margin(0, 0, 0, 5);
		DropDownList dropDownList2 = dropDownList;
		dropDownList2.Listbox.Scrollbar.ButtonUp.Visible = false;
		dropDownList2.Listbox.Scrollbar.ButtonDown.Visible = false;
		int _ExpbREeE97oXaFMwg5UwE6MpAAQ = base._ZzBuoSDMWwerejOO9Goyv2OCKgE._vsceSzSIjBy2nZrCxAzKZbUiwLq._KOuUew34v1oSMnWlHSFJuRBiu1c;
		int _P2eFcUFiRYQgRf4ICqeX3kVcA2m = base._ZzBuoSDMWwerejOO9Goyv2OCKgE._vsceSzSIjBy2nZrCxAzKZbUiwLq._dh9yjUXG1mhcfgwAWkWfggbGEIc;
		foreach (DisplayMode supportedDisplayMode in base._ZzBuoSDMWwerejOO9Goyv2OCKgE._2yepMkVENnecIsduggABaU2qhXW.Adapter.SupportedDisplayModes)
		{
			dropDownList2.Items.Add(new ListBoxItem
			{
				Text = supportedDisplayMode.Width + "x" + supportedDisplayMode.Height,
				Value = supportedDisplayMode,
				Size = new Squid.Point(0, 30),
				Selected = (_ExpbREeE97oXaFMwg5UwE6MpAAQ == supportedDisplayMode.Width && _P2eFcUFiRYQgRf4ICqeX3kVcA2m == supportedDisplayMode.Height)
			});
		}
		dropDownList2.SelectedItemChanged += delegate(Control control_0, ListBoxItem listBoxItem_0)
		{
			if (listBoxItem_0.Value is DisplayMode)
			{
				DisplayMode displayMode = listBoxItem_0.Value as DisplayMode;
				base._ZzBuoSDMWwerejOO9Goyv2OCKgE._fSRUnXzLhUs3DfJ1lzl9dGCEmCf(displayMode.Width, displayMode.Height);
				_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._Iv7AHXGOFR9WoLBFx6PjEgEHmYI = displayMode.Width;
				_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._84wHcdDxJz5ElyDPXXlgRgsiW8g = displayMode.Height;
				_ExpbREeE97oXaFMwg5UwE6MpAAQ = displayMode.Width;
				_P2eFcUFiRYQgRf4ICqeX3kVcA2m = displayMode.Height;
			}
		};
		CheckBox checkBox = new CheckBox
		{
			Dock = DockStyle.Top,
			Text = "Fullscreen",
			Checked = base._ZzBuoSDMWwerejOO9Goyv2OCKgE._kSReo0whY1pgfTnFOSc44ppANOe
		};
		checkBox.CheckedChanged += delegate
		{
			base._ZzBuoSDMWwerejOO9Goyv2OCKgE._fSRUnXzLhUs3DfJ1lzl9dGCEmCf(_ExpbREeE97oXaFMwg5UwE6MpAAQ, _P2eFcUFiRYQgRf4ICqeX3kVcA2m, !base._ZzBuoSDMWwerejOO9Goyv2OCKgE._kSReo0whY1pgfTnFOSc44ppANOe);
			_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._Bbx3oCtJkeUN6asRLqH0DJ3kkFg = base._ZzBuoSDMWwerejOO9Goyv2OCKgE._kSReo0whY1pgfTnFOSc44ppANOe;
		};
		panel.Content.Controls.Add(item);
		panel.Content.Controls.Add(item2);
		panel.Content.Controls.Add(dropDownList2);
		panel.Content.Controls.Add(checkBox);
		Label item3 = new Label
		{
			Dock = DockStyle.Top,
			TextAlign = Alignment.MiddleCenter,
			Text = "Sound"
		};
		Label item4 = new Label
		{
			Dock = DockStyle.Top,
			Text = "Master Volume"
		};
		Slider slider = new Slider();
		slider.Dock = DockStyle.Top;
		slider.Orientation = Orientation.Horizontal;
		slider.Steps = 100f;
		slider.Value = _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._DF24JUrPFA6rJ2cQrOTlpC3I4FF * 100f;
		slider.Style = "scrollSlider";
		slider.Size = new Squid.Point(0, 30);
		slider.Button.Style = "scrollSliderButton";
		Slider _XEgAfmv7sJWJSaC2diC3eaD4Fgl = slider;
		_XEgAfmv7sJWJSaC2diC3eaD4Fgl.ValueChanged += delegate
		{
			_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._DF24JUrPFA6rJ2cQrOTlpC3I4FF = _XEgAfmv7sJWJSaC2diC3eaD4Fgl.Value / 100f;
		};
		Label item5 = new Label
		{
			Dock = DockStyle.Top,
			Text = "Music Volume"
		};
		Slider slider2 = new Slider();
		slider2.Dock = DockStyle.Top;
		slider2.Orientation = Orientation.Horizontal;
		slider2.Steps = 100f;
		slider2.Value = _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._7NidKjx61ui5CP7JojwfqxH4aKC * 100f;
		slider2.Style = "scrollSlider";
		slider2.Size = new Squid.Point(0, 30);
		slider2.Button.Style = "scrollSliderButton";
		Slider _gjeIIVx9bHyd0aMj0WD483nrLWK = slider2;
		_gjeIIVx9bHyd0aMj0WD483nrLWK.ValueChanged += delegate
		{
			_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._7NidKjx61ui5CP7JojwfqxH4aKC = _gjeIIVx9bHyd0aMj0WD483nrLWK.Value / 100f;
		};
		Label item6 = new Label
		{
			Dock = DockStyle.Top,
			Text = "SFX Volume"
		};
		Slider slider3 = new Slider();
		slider3.Dock = DockStyle.Top;
		slider3.Orientation = Orientation.Horizontal;
		slider3.Steps = 100f;
		slider3.Value = _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._2g4Ch8GXdUt0oEbdCZUY2QMbIuH * 100f;
		slider3.Style = "scrollSlider";
		slider3.Size = new Squid.Point(0, 30);
		slider3.Button.Style = "scrollSliderButton";
		Slider _5mK9ExiyKm0md8q4J1C6xc4TzdF = slider3;
		_5mK9ExiyKm0md8q4J1C6xc4TzdF.ValueChanged += delegate
		{
			_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._2g4Ch8GXdUt0oEbdCZUY2QMbIuH = _5mK9ExiyKm0md8q4J1C6xc4TzdF.Value / 100f;
		};
		panel.Content.Controls.Add(item3);
		panel.Content.Controls.Add(item4);
		panel.Content.Controls.Add(_XEgAfmv7sJWJSaC2diC3eaD4Fgl);
		panel.Content.Controls.Add(item5);
		panel.Content.Controls.Add(_gjeIIVx9bHyd0aMj0WD483nrLWK);
		panel.Content.Controls.Add(item6);
		panel.Content.Controls.Add(_5mK9ExiyKm0md8q4J1C6xc4TzdF);
		Label item7 = new Label
		{
			Dock = DockStyle.Top,
			TextAlign = Alignment.MiddleCenter,
			Text = "Dialogue"
		};
		panel.Content.Controls.Add(item7);
		_poenyHBGUusBcnNcTFB9MQBV72R._YemBTJprwfbd3mpg5Gy9uyEJWwI(panel.Content.Controls, "Text Speed", new string[4] { "Slow", "Normal", "Fast", "Instant" }, (int)_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._wVLRBSMULz8GfedBPXaVJB0sBEO, delegate(int int_0)
		{
			_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._wVLRBSMULz8GfedBPXaVJB0sBEO = (DialogueSpeed)int_0;
			_nkzqFdEfDyLcyGikIKGcHjklI4y._NhL238TaCbkDiY6HXlWXZzzUYkm = (DialogueSpeed)int_0;
		});
		CheckBox _feL3soNn6ZWaJqYfjYJUyH118tF = new CheckBox
		{
			Dock = DockStyle.Top,
			Text = "Auto-skip",
			Checked = _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._sbK0941BvW8HgPboNwOhIAd2jP3
		};
		_feL3soNn6ZWaJqYfjYJUyH118tF.CheckedChanged += delegate
		{
			_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._sbK0941BvW8HgPboNwOhIAd2jP3 = _feL3soNn6ZWaJqYfjYJUyH118tF.Checked;
			_nkzqFdEfDyLcyGikIKGcHjklI4y._fUgDiz7KX8TZUVzFlTeXMOhmfUT = _feL3soNn6ZWaJqYfjYJUyH118tF.Checked;
		};
		panel.Content.Controls.Add(_feL3soNn6ZWaJqYfjYJUyH118tF);
		if (_iExD93IWLlzVfXsU9wyrEvWgJsg._X41qA9hgcgXH0Q1aFKWFWpg8UuM)
		{
			Label item8 = new Label
			{
				Dock = DockStyle.Top,
				TextAlign = Alignment.MiddleCenter,
				Text = "Cheats"
			};
			CheckBox _LFRG0GY4VuOaiC2XHbpUmFoVDAj = new CheckBox
			{
				Dock = DockStyle.Top,
				Text = "Enable SFW-mode",
				Checked = _iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF
			};
			_LFRG0GY4VuOaiC2XHbpUmFoVDAj.CheckedChanged += delegate
			{
				_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF = _LFRG0GY4VuOaiC2XHbpUmFoVDAj.Checked;
				_L7VColD35B3sDgJdUnjTeXGa7pv.Close();
				_MRzbkwglCADk2fFjoxcsdCSJfKu();
			};
			panel.Content.Controls.Add(item8);
			panel.Content.Controls.Add(_LFRG0GY4VuOaiC2XHbpUmFoVDAj);
		}
		if (!_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
		{
			CheckBox _PBgLcZr7dRzS97rFn3FU6lDw8ZE = new CheckBox
			{
				Dock = DockStyle.Top,
				Text = "Enable Topless",
				Checked = _iExD93IWLlzVfXsU9wyrEvWgJsg._b52DDz3MN1kD8sgdQhCNO1tJRNn
			};
			_PBgLcZr7dRzS97rFn3FU6lDw8ZE.CheckedChanged += delegate
			{
				_iExD93IWLlzVfXsU9wyrEvWgJsg._b52DDz3MN1kD8sgdQhCNO1tJRNn = _PBgLcZr7dRzS97rFn3FU6lDw8ZE.Checked;
			};
			CheckBox _qWiPLfzctHo3AqPevD7VV4qTuDy = new CheckBox
			{
				Dock = DockStyle.Top,
				Text = "Enable Bottomless",
				Checked = _iExD93IWLlzVfXsU9wyrEvWgJsg._pKBiGAgDu5WqoykkGBaEGnP7oMj
			};
			_qWiPLfzctHo3AqPevD7VV4qTuDy.CheckedChanged += delegate
			{
				_iExD93IWLlzVfXsU9wyrEvWgJsg._pKBiGAgDu5WqoykkGBaEGnP7oMj = _qWiPLfzctHo3AqPevD7VV4qTuDy.Checked;
			};
			panel.Content.Controls.Add(_PBgLcZr7dRzS97rFn3FU6lDw8ZE);
			panel.Content.Controls.Add(_qWiPLfzctHo3AqPevD7VV4qTuDy);
		}
		Button button = new Button
		{
			Dock = DockStyle.Bottom,
			Text = "Close"
		};
		button.MouseClick += delegate
		{
			base._ZzBuoSDMWwerejOO9Goyv2OCKgE._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b = true;
			_eJWqL2MhFZHNHP960nsWLJJmyPD._7cuPUL8aamrg9daETH6zQk3RwbF();
			_L7VColD35B3sDgJdUnjTeXGa7pv.Close();
		};
		panel.Content.Controls.Add(button);
		_L7VColD35B3sDgJdUnjTeXGa7pv.Show(base._PnkAlVnMv0SZvRBFexqzE5DF9tp);
	}

	public override void _tO46aYSBLFIuhFNlhbrAeWbFDSf()
	{
		base._tO46aYSBLFIuhFNlhbrAeWbFDSf();
		_5Anqe6GAAkzemoAXYpJmgMlk1yz._3DInasj5B11bCcV5BIRvLE1Ay7w = false;
	}

	[CompilerGenerated]
	private void _fI217APzl4Tapt53WowQWN9Ipyi()
	{
		base._ZzBuoSDMWwerejOO9Goyv2OCKgE._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b = false;
		base._PnkAlVnMv0SZvRBFexqzE5DF9tp._GtkWDtXwQHwgWY4aFkacjfUDyzb("What would you like to do?", new string[4] { "New Game", "New Game w/o Prologue", "Character Customization", "Oops, I've changed my mind!" }, 500, delegate(int int_0)
		{
			_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
			switch (int_0)
			{
			default:
				base._ZzBuoSDMWwerejOO9Goyv2OCKgE._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b = true;
				break;
			case 0:
				_UmxbIbk7pgaod0bD7pS309P3Lns._PYAXEqRAOkDRRNqm1k71R7GJTJK();
				opIJo2jLUqdOL5yAFP4yzXce0DG._Rj5BZHY1n3a8XV7jJAk9U8jZZ6m();
				_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = false;
				_nkzqFdEfDyLcyGikIKGcHjklI4y._NhL238TaCbkDiY6HXlWXZzzUYkm = _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._wVLRBSMULz8GfedBPXaVJB0sBEO;
				_nkzqFdEfDyLcyGikIKGcHjklI4y._fUgDiz7KX8TZUVzFlTeXMOhmfUT = _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._sbK0941BvW8HgPboNwOhIAd2jP3;
				base._ZzBuoSDMWwerejOO9Goyv2OCKgE._xyl3Tv5KdR5eezDgagxbBcS3cwt("Prologue");
				break;
			case 1:
				_UmxbIbk7pgaod0bD7pS309P3Lns._PYAXEqRAOkDRRNqm1k71R7GJTJK();
				opIJo2jLUqdOL5yAFP4yzXce0DG._Rj5BZHY1n3a8XV7jJAk9U8jZZ6m();
				_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = false;
				_nkzqFdEfDyLcyGikIKGcHjklI4y._NhL238TaCbkDiY6HXlWXZzzUYkm = _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._wVLRBSMULz8GfedBPXaVJB0sBEO;
				_nkzqFdEfDyLcyGikIKGcHjklI4y._fUgDiz7KX8TZUVzFlTeXMOhmfUT = _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._sbK0941BvW8HgPboNwOhIAd2jP3;
				base._ZzBuoSDMWwerejOO9Goyv2OCKgE._k9wUPeU1Ga7cygiuGP8TT6aPLWF<SkipProloguePlayerCustomizationScene>();
				break;
			case 2:
				_UmxbIbk7pgaod0bD7pS309P3Lns._PYAXEqRAOkDRRNqm1k71R7GJTJK();
				opIJo2jLUqdOL5yAFP4yzXce0DG._Rj5BZHY1n3a8XV7jJAk9U8jZZ6m();
				_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = false;
				_nkzqFdEfDyLcyGikIKGcHjklI4y._NhL238TaCbkDiY6HXlWXZzzUYkm = _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._wVLRBSMULz8GfedBPXaVJB0sBEO;
				_nkzqFdEfDyLcyGikIKGcHjklI4y._fUgDiz7KX8TZUVzFlTeXMOhmfUT = _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._sbK0941BvW8HgPboNwOhIAd2jP3;
				base._ZzBuoSDMWwerejOO9Goyv2OCKgE._k9wUPeU1Ga7cygiuGP8TT6aPLWF<PlayerCustomizationScene>();
				break;
			}
		});
	}

	[CompilerGenerated]
	private void _SD73Tf7ANXaiMyg34yTgfWsn74y(int int_0)
	{
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
		switch (int_0)
		{
		default:
			base._ZzBuoSDMWwerejOO9Goyv2OCKgE._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b = true;
			break;
		case 0:
			_UmxbIbk7pgaod0bD7pS309P3Lns._PYAXEqRAOkDRRNqm1k71R7GJTJK();
			opIJo2jLUqdOL5yAFP4yzXce0DG._Rj5BZHY1n3a8XV7jJAk9U8jZZ6m();
			_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = false;
			_nkzqFdEfDyLcyGikIKGcHjklI4y._NhL238TaCbkDiY6HXlWXZzzUYkm = _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._wVLRBSMULz8GfedBPXaVJB0sBEO;
			_nkzqFdEfDyLcyGikIKGcHjklI4y._fUgDiz7KX8TZUVzFlTeXMOhmfUT = _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._sbK0941BvW8HgPboNwOhIAd2jP3;
			base._ZzBuoSDMWwerejOO9Goyv2OCKgE._xyl3Tv5KdR5eezDgagxbBcS3cwt("Prologue");
			break;
		case 1:
			_UmxbIbk7pgaod0bD7pS309P3Lns._PYAXEqRAOkDRRNqm1k71R7GJTJK();
			opIJo2jLUqdOL5yAFP4yzXce0DG._Rj5BZHY1n3a8XV7jJAk9U8jZZ6m();
			_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = false;
			_nkzqFdEfDyLcyGikIKGcHjklI4y._NhL238TaCbkDiY6HXlWXZzzUYkm = _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._wVLRBSMULz8GfedBPXaVJB0sBEO;
			_nkzqFdEfDyLcyGikIKGcHjklI4y._fUgDiz7KX8TZUVzFlTeXMOhmfUT = _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._sbK0941BvW8HgPboNwOhIAd2jP3;
			base._ZzBuoSDMWwerejOO9Goyv2OCKgE._k9wUPeU1Ga7cygiuGP8TT6aPLWF<SkipProloguePlayerCustomizationScene>();
			break;
		case 2:
			_UmxbIbk7pgaod0bD7pS309P3Lns._PYAXEqRAOkDRRNqm1k71R7GJTJK();
			opIJo2jLUqdOL5yAFP4yzXce0DG._Rj5BZHY1n3a8XV7jJAk9U8jZZ6m();
			_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = false;
			_nkzqFdEfDyLcyGikIKGcHjklI4y._NhL238TaCbkDiY6HXlWXZzzUYkm = _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._wVLRBSMULz8GfedBPXaVJB0sBEO;
			_nkzqFdEfDyLcyGikIKGcHjklI4y._fUgDiz7KX8TZUVzFlTeXMOhmfUT = _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._sbK0941BvW8HgPboNwOhIAd2jP3;
			base._ZzBuoSDMWwerejOO9Goyv2OCKgE._k9wUPeU1Ga7cygiuGP8TT6aPLWF<PlayerCustomizationScene>();
			break;
		}
	}

	[CompilerGenerated]
	private void _3a8aQcA02aVpTZtKGWFgMtrJHSz()
	{
		base._ZzBuoSDMWwerejOO9Goyv2OCKgE._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b = false;
		List<_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p> _rQhndDODcLCmH9PKjwXRNz0AcU8 = _DW9IcpdMEINZmuzfrqmwsduBGih._25D1ZH2er0EbpKmvFksAbFjP2OX(bool_0: false);
		List<string> _ILFAnNbgAYkKwOVs9Pn9012gw1w = _rQhndDODcLCmH9PKjwXRNz0AcU8.Select((_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p _3CCr8Bt1rkuzt0M6gYLbceJGV0p_0) => _3CCr8Bt1rkuzt0M6gYLbceJGV0p_0._RB8fRXeQvK5vs7JEA0XfVCEpg1i).ToList();
		_ILFAnNbgAYkKwOVs9Pn9012gw1w.Add("Oops, I've changed my mind!");
		base._PnkAlVnMv0SZvRBFexqzE5DF9tp._GtkWDtXwQHwgWY4aFkacjfUDyzb("Which save do you wish to load?", _ILFAnNbgAYkKwOVs9Pn9012gw1w.ToArray(), 500, delegate(int int_0)
		{
			if (int_0 == _ILFAnNbgAYkKwOVs9Pn9012gw1w.Count - 1)
			{
				base._ZzBuoSDMWwerejOO9Goyv2OCKgE._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b = true;
			}
			else
			{
				_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p _3CCr8Bt1rkuzt0M6gYLbceJGV0p = _rQhndDODcLCmH9PKjwXRNz0AcU8[int_0];
				if (!_3CCr8Bt1rkuzt0M6gYLbceJGV0p._r4LqoJiAr5K9UiLsUzUDbcJDQqo)
				{
					if (!((!_3CCr8Bt1rkuzt0M6gYLbceJGV0p._3y7m8OGVjMe7WGIhZ66YOw3ITUE) ? base._ZzBuoSDMWwerejOO9Goyv2OCKgE._Ut0dhlh4JTZBMNJPNxxI9f9VqTp(_3CCr8Bt1rkuzt0M6gYLbceJGV0p._B3FsRMcQWBXzFf3nLOBKzncessO) : base._ZzBuoSDMWwerejOO9Goyv2OCKgE._1yDW5GeZ2MCcssz8ohrF9CK913i(_3CCr8Bt1rkuzt0M6gYLbceJGV0p._B3FsRMcQWBXzFf3nLOBKzncessO)))
					{
						base._PnkAlVnMv0SZvRBFexqzE5DF9tp._0pVU36wp9GYD1jM18raZtVEbA9q("Failed to load save, it's most likely corrupted.", 250, "OK", delegate
						{
							base._ZzBuoSDMWwerejOO9Goyv2OCKgE._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b = true;
						});
					}
					else
					{
						base._ZzBuoSDMWwerejOO9Goyv2OCKgE._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b = true;
					}
				}
				else
				{
					base._PnkAlVnMv0SZvRBFexqzE5DF9tp._0pVU36wp9GYD1jM18raZtVEbA9q(string.Format("There is no save in {0}slot #{1}!", _3CCr8Bt1rkuzt0M6gYLbceJGV0p._3y7m8OGVjMe7WGIhZ66YOw3ITUE ? "autosave " : string.Empty, int_0 + 1), 250, "OK", delegate
					{
						base._ZzBuoSDMWwerejOO9Goyv2OCKgE._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b = true;
					});
				}
			}
		});
	}

	[CompilerGenerated]
	private void _2L0GcJVz3zT3U7tBW5tgN1ccYgp()
	{
		base._ZzBuoSDMWwerejOO9Goyv2OCKgE._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b = true;
	}

	[CompilerGenerated]
	private void _plxCcrCl4DCKu5G7qBtjRepOyaM()
	{
		base._ZzBuoSDMWwerejOO9Goyv2OCKgE._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b = true;
	}

	[CompilerGenerated]
	private void _W4PFYhu2NAZbDYPFpvdFr789eG0()
	{
		base._ZzBuoSDMWwerejOO9Goyv2OCKgE._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b = false;
		base._PnkAlVnMv0SZvRBFexqzE5DF9tp._GtkWDtXwQHwgWY4aFkacjfUDyzb("Are you sure you wish to quit the game?", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, 500, delegate(int int_0)
		{
			if (int_0 == 1)
			{
				base._ZzBuoSDMWwerejOO9Goyv2OCKgE._Qj2G6fpAF4mGsATgkV8DPBF3aA1A._PYAXEqRAOkDRRNqm1k71R7GJTJK(delegate
				{
					base._ZzBuoSDMWwerejOO9Goyv2OCKgE._udfEpcIRn7lWl5Lvjdyu0aG0A7G();
				});
			}
			base._ZzBuoSDMWwerejOO9Goyv2OCKgE._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b = true;
		});
	}

	[CompilerGenerated]
	private void _WXVOKjJHmBoMdMbldQqnBe7J5Ss(int int_0)
	{
		if (int_0 == 1)
		{
			base._ZzBuoSDMWwerejOO9Goyv2OCKgE._Qj2G6fpAF4mGsATgkV8DPBF3aA1A._PYAXEqRAOkDRRNqm1k71R7GJTJK(delegate
			{
				base._ZzBuoSDMWwerejOO9Goyv2OCKgE._udfEpcIRn7lWl5Lvjdyu0aG0A7G();
			});
		}
		base._ZzBuoSDMWwerejOO9Goyv2OCKgE._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b = true;
	}

	[CompilerGenerated]
	private void _BK4Ag37J0xySDkNNVq7rfpQgFa4()
	{
		base._ZzBuoSDMWwerejOO9Goyv2OCKgE._udfEpcIRn7lWl5Lvjdyu0aG0A7G();
	}

	static _uqydQVaCmCvK7zzWs5W4gZFpKBu smethod_18(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._0O8D0mBgmrh0sLOGcLVvGNOHKLCA(string_0, string_1, int_0, int_1);
	}

	static _fAUddQEKfZyemRb327NhM3GGlmzA smethod_19(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0)
	{
		return new _fAUddQEKfZyemRb327NhM3GGlmzA(_7UlnfykmEmZDFt3BmCKZekI43Ih_0, string_0);
	}

	static void smethod_20(_fAUddQEKfZyemRb327NhM3GGlmzA _fAUddQEKfZyemRb327NhM3GGlmzA_0, Action<SpriteBatch> action_0)
	{
		_fAUddQEKfZyemRb327NhM3GGlmzA_0._B6VrMlmWofCGqEzjzgFJiAliCge = action_0;
	}

	static _uqydQVaCmCvK7zzWs5W4gZFpKBu smethod_21(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._NC5VT77x8y2iH2pW56TBN1eyomA(string_0, string_1, int_0, int_1);
	}

	static _ujAkjlfN5TywwbLAUDzPvtab6uJ smethod_22(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._0c5TjZklJbu1wzYG2FIcvf3SIdh(string_0);
	}

	static void smethod_23(_21uBmerICJi18moE2gpxlEipBgz _21uBmerICJi18moE2gpxlEipBgz_0)
	{
		_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._Wrz1IORok7yBtsQA3czQUmnP6Yl(_21uBmerICJi18moE2gpxlEipBgz_0);
	}

	static void smethod_24(string string_0, float float_0)
	{
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc(string_0, float_0);
	}

	static _JbeCmOie0phb2cbgG6DdGZrbs3pB smethod_25(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._ZzBuoSDMWwerejOO9Goyv2OCKgE;
	}

	static ContentManager smethod_26(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8;
	}

	static string smethod_27(string string_0, object object_0)
	{
		return string.Format(string_0, object_0);
	}

	static void smethod_28(_ujAkjlfN5TywwbLAUDzPvtab6uJ _ujAkjlfN5TywwbLAUDzPvtab6uJ_0, bool bool_0)
	{
		_ujAkjlfN5TywwbLAUDzPvtab6uJ_0._C6GAq9XPMC9PQPnaaRqYWpv4V6S = bool_0;
	}

	static void smethod_29(_ujAkjlfN5TywwbLAUDzPvtab6uJ _ujAkjlfN5TywwbLAUDzPvtab6uJ_0, float float_0)
	{
		_ujAkjlfN5TywwbLAUDzPvtab6uJ_0._7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_30(_ujAkjlfN5TywwbLAUDzPvtab6uJ _ujAkjlfN5TywwbLAUDzPvtab6uJ_0, float float_0)
	{
		_ujAkjlfN5TywwbLAUDzPvtab6uJ_0._bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}

	static TimeSpan smethod_31(GameTime gameTime_0)
	{
		return gameTime_0.ElapsedGameTime;
	}

	static _Z6EKIW3ycAwV2npYuxbFLcnCTrJ smethod_32()
	{
		return _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._yuFBJdi7mxrwMFQ57BjLjSq6ESj;
	}

	static _21uBmerICJi18moE2gpxlEipBgz smethod_33(_Z6EKIW3ycAwV2npYuxbFLcnCTrJ _Z6EKIW3ycAwV2npYuxbFLcnCTrJ_0)
	{
		return _Z6EKIW3ycAwV2npYuxbFLcnCTrJ_0._mW1Z69pRB1eedGT3FSmdItJre5Y;
	}

	static double smethod_34(double double_0)
	{
		return Math.Sin(double_0);
	}

	static float smethod_35(float float_0)
	{
		return MathHelper.ToRadians(float_0);
	}

	static void smethod_36(SpriteBatch spriteBatch_0, SpriteSortMode spriteSortMode_0, BlendState blendState_0, SamplerState samplerState_0, DepthStencilState depthStencilState_0, RasterizerState rasterizerState_0, Effect effect_0, Matrix? nullable_0)
	{
		spriteBatch_0._g9Sx54kMPiHz5jrqWh4Kb1pTijH(spriteSortMode_0, blendState_0, samplerState_0, depthStencilState_0, rasterizerState_0, effect_0, nullable_0);
	}

	static void smethod_37(_21uBmerICJi18moE2gpxlEipBgz _21uBmerICJi18moE2gpxlEipBgz_0, SpriteBatch spriteBatch_0)
	{
		_21uBmerICJi18moE2gpxlEipBgz_0._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0);
	}

	static void smethod_38(SpriteBatch spriteBatch_0)
	{
		spriteBatch_0.End();
	}

	static void smethod_39(SpriteBatch spriteBatch_0)
	{
		spriteBatch_0.Begin();
	}

	static void smethod_40(_ujAkjlfN5TywwbLAUDzPvtab6uJ _ujAkjlfN5TywwbLAUDzPvtab6uJ_0, SpriteBatch spriteBatch_0)
	{
		_ujAkjlfN5TywwbLAUDzPvtab6uJ_0._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0);
	}

	static void smethod_41(_8lVOgkauaSHbAkAqHzI1K7mIyOI _8lVOgkauaSHbAkAqHzI1K7mIyOI_0, SpriteBatch spriteBatch_0)
	{
		_8lVOgkauaSHbAkAqHzI1K7mIyOI_0._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0);
	}

	static _8lVOgkauaSHbAkAqHzI1K7mIyOI smethod_42(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._o2QVQfIAsuLcmPxn14llGoZA52y;
	}

	static void smethod_43(_8lVOgkauaSHbAkAqHzI1K7mIyOI _8lVOgkauaSHbAkAqHzI1K7mIyOI_0, bool bool_0)
	{
		_8lVOgkauaSHbAkAqHzI1K7mIyOI_0._nJKYvZJ57vjjlQwmoeBmKihtS0b = bool_0;
	}

	static bool smethod_44()
	{
		return _iExD93IWLlzVfXsU9wyrEvWgJsg._X41qA9hgcgXH0Q1aFKWFWpg8UuM;
	}

	static bool smethod_45()
	{
		return _iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF;
	}

	static Window smethod_46()
	{
		return new Window();
	}

	static void smethod_47(Control control_0, DockStyle dockStyle_0)
	{
		control_0.Dock = dockStyle_0;
	}

	void method_3()
	{
		base._tO46aYSBLFIuhFNlhbrAeWbFDSf();
	}

	static Desktop smethod_48(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._PnkAlVnMv0SZvRBFexqzE5DF9tp;
	}

	static void smethod_49(Desktop desktop_0, string string_0, string[] string_1, int int_0, Action<int> action_0)
	{
		desktop_0._GtkWDtXwQHwgWY4aFkacjfUDyzb(string_0, string_1, int_0, action_0);
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG smethod_50()
	{
		return _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
	}

	static void smethod_51(Action action_0)
	{
		_UmxbIbk7pgaod0bD7pS309P3Lns._PYAXEqRAOkDRRNqm1k71R7GJTJK(action_0);
	}

	static void smethod_52(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		_opIJo2jLUqdOL5yAFP4yzXce0DG_0._Rj5BZHY1n3a8XV7jJAk9U8jZZ6m();
	}

	static _eNOTHZZiu5nx6PrADzfLyng3Igc smethod_53()
	{
		return _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF;
	}

	static DialogueSpeed smethod_54(_eNOTHZZiu5nx6PrADzfLyng3Igc _eNOTHZZiu5nx6PrADzfLyng3Igc_0)
	{
		return _eNOTHZZiu5nx6PrADzfLyng3Igc_0._wVLRBSMULz8GfedBPXaVJB0sBEO;
	}

	static void smethod_55(DialogueSpeed dialogueSpeed_0)
	{
		_nkzqFdEfDyLcyGikIKGcHjklI4y._NhL238TaCbkDiY6HXlWXZzzUYkm = dialogueSpeed_0;
	}

	static bool smethod_56(_eNOTHZZiu5nx6PrADzfLyng3Igc _eNOTHZZiu5nx6PrADzfLyng3Igc_0)
	{
		return _eNOTHZZiu5nx6PrADzfLyng3Igc_0._sbK0941BvW8HgPboNwOhIAd2jP3;
	}

	static void smethod_57(bool bool_0)
	{
		_nkzqFdEfDyLcyGikIKGcHjklI4y._fUgDiz7KX8TZUVzFlTeXMOhmfUT = bool_0;
	}

	static void smethod_58(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, string string_0)
	{
		_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._xyl3Tv5KdR5eezDgagxbBcS3cwt(string_0);
	}

	static List<_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p> smethod_59(bool bool_0)
	{
		return _DW9IcpdMEINZmuzfrqmwsduBGih._25D1ZH2er0EbpKmvFksAbFjP2OX(bool_0);
	}

	static _gJR4g7ak0hsZAUWX1vJbMqG2P5I smethod_60(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._Qj2G6fpAF4mGsATgkV8DPBF3aA1A;
	}

	static void smethod_61(_gJR4g7ak0hsZAUWX1vJbMqG2P5I _gJR4g7ak0hsZAUWX1vJbMqG2P5I_0, Action action_0)
	{
		_gJR4g7ak0hsZAUWX1vJbMqG2P5I_0._PYAXEqRAOkDRRNqm1k71R7GJTJK(action_0);
	}

	static void smethod_62(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._udfEpcIRn7lWl5Lvjdyu0aG0A7G();
	}
}
