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

	public MainMenuScene(IAmorous game)
		: base(Game)
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
		_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._Wrz1IORok7yBtsQA3czQUmnP6Yl(new _hiwkgwXJpRLUFatcgZFfH6ECNfm(Game));
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/WarmanSteve - Giant Robots", 0.4f);
		Game._lXEQJcXKxsjtZp00Y9aPe0ymGue(new _BlUQCbX8YXbBc38I7iPEHyF1rUQ(Game)
		{
			_uIOOxdCbSvCxXvjNgoXh2qYj0hr = delegate
			{
				base.Game._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b = false;
				base._PnkAlVnMv0SZvRBFexqzE5DF9tp.ShowSelection("What would you like to do?", new string[4] { "New Game", "New Game w/o Prologue", "Character Customization", "Oops, I've changed my mind!" }, 500, delegate(int int_0)
				{
					PlayerData opIJo2jLUqdOL5yAFP4yzXce0DG = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
					switch (int_0)
					{
					default:
						base.Game._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b = true;
						break;
					case 0:
						_UmxbIbk7pgaod0bD7pS309P3Lns._PYAXEqRAOkDRRNqm1k71R7GJTJK();
						opIJo2jLUqdOL5yAFP4yzXce0DG.Reset();
						_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = false;
						_nkzqFdEfDyLcyGikIKGcHjklI4y._NhL238TaCbkDiY6HXlWXZzzUYkm = Options.Data.DialogueTextSpeed;
						_nkzqFdEfDyLcyGikIKGcHjklI4y._fUgDiz7KX8TZUVzFlTeXMOhmfUT = Options.Data.DialogueAutoSkip;
						base.Game.RequestScene("Prologue");
						break;
					case 1:
						_UmxbIbk7pgaod0bD7pS309P3Lns._PYAXEqRAOkDRRNqm1k71R7GJTJK();
						opIJo2jLUqdOL5yAFP4yzXce0DG.Reset();
						_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = false;
						_nkzqFdEfDyLcyGikIKGcHjklI4y._NhL238TaCbkDiY6HXlWXZzzUYkm = Options.Data.DialogueTextSpeed;
						_nkzqFdEfDyLcyGikIKGcHjklI4y._fUgDiz7KX8TZUVzFlTeXMOhmfUT = Options.Data.DialogueAutoSkip;
						base.Game.StartScene<SkipProloguePlayerCustomizationScene>();
						break;
					case 2:
						_UmxbIbk7pgaod0bD7pS309P3Lns._PYAXEqRAOkDRRNqm1k71R7GJTJK();
						opIJo2jLUqdOL5yAFP4yzXce0DG.Reset();
						_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = false;
						_nkzqFdEfDyLcyGikIKGcHjklI4y._NhL238TaCbkDiY6HXlWXZzzUYkm = Options.Data.DialogueTextSpeed;
						_nkzqFdEfDyLcyGikIKGcHjklI4y._fUgDiz7KX8TZUVzFlTeXMOhmfUT = Options.Data.DialogueAutoSkip;
						base.Game.StartScene<PlayerCustomizationScene>();
						break;
					}
				});
			},
			_HmpXEsA3mxR8eI4MZmgIPCtSGQb = delegate
			{
				base.Game._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b = false;
				List<_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p> _rQhndDODcLCmH9PKjwXRNz0AcU8 = _DW9IcpdMEINZmuzfrqmwsduBGih._25D1ZH2er0EbpKmvFksAbFjP2OX(bool_0: false);
				List<string> _ILFAnNbgAYkKwOVs9Pn9012gw1w = _rQhndDODcLCmH9PKjwXRNz0AcU8.Select((_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p _3CCr8Bt1rkuzt0M6gYLbceJGV0p_0) => _3CCr8Bt1rkuzt0M6gYLbceJGV0p_0.Name).ToList();
				_ILFAnNbgAYkKwOVs9Pn9012gw1w.Add("Oops, I've changed my mind!");
				base._PnkAlVnMv0SZvRBFexqzE5DF9tp.ShowSelection("Which save do you wish to load?", _ILFAnNbgAYkKwOVs9Pn9012gw1w.ToArray(), 500, delegate(int int_0)
				{
					if (int_0 == _ILFAnNbgAYkKwOVs9Pn9012gw1w.Count - 1)
					{
						base.Game._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b = true;
					}
					else
					{
						_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p _3CCr8Bt1rkuzt0M6gYLbceJGV0p = _rQhndDODcLCmH9PKjwXRNz0AcU8[int_0];
						if (!_3CCr8Bt1rkuzt0M6gYLbceJGV0p._r4LqoJiAr5K9UiLsUzUDbcJDQqo)
						{
							if (!((!_3CCr8Bt1rkuzt0M6gYLbceJGV0p._3y7m8OGVjMe7WGIhZ66YOw3ITUE) ? base.Game._Ut0dhlh4JTZBMNJPNxxI9f9VqTp(_3CCr8Bt1rkuzt0M6gYLbceJGV0p._B3FsRMcQWBXzFf3nLOBKzncessO) : base.Game._1yDW5GeZ2MCcssz8ohrF9CK913i(_3CCr8Bt1rkuzt0M6gYLbceJGV0p._B3FsRMcQWBXzFf3nLOBKzncessO)))
							{
								base._PnkAlVnMv0SZvRBFexqzE5DF9tp.ShowConfirm("Failed to load save, it's most likely corrupted.", 250, "OK", delegate
								{
									base.Game._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b = true;
								});
							}
							else
							{
								base.Game._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b = true;
							}
						}
						else
						{
							base._PnkAlVnMv0SZvRBFexqzE5DF9tp.ShowConfirm(string.Format("There is no save in {0}slot #{1}!", _3CCr8Bt1rkuzt0M6gYLbceJGV0p._3y7m8OGVjMe7WGIhZ66YOw3ITUE ? "autosave " : string.Empty, int_0 + 1), 250, "OK", delegate
							{
								base.Game._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b = true;
							});
						}
					}
				});
			},
			_vE5Pvwth7cQFh82bMTB5u59Ju4o = delegate
			{
				base.Game._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b = false;
				base._PnkAlVnMv0SZvRBFexqzE5DF9tp.ShowSelection("Are you sure you wish to quit the Game?", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, 500, delegate(int int_0)
				{
					if (int_0 == 1)
					{
						base.Game._Qj2G6fpAF4mGsATgkV8DPBF3aA1A._PYAXEqRAOkDRRNqm1k71R7GJTJK(delegate
						{
							base.Game._udfEpcIRn7lWl5Lvjdyu0aG0A7G();
						});
					}
					base.Game._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b = true;
				});
			}
		});
		_zBw0aG4VRggByEYsHPjIPCYfoQJ = new _SsogwGgurAXPoDRtNVTCVKq9yRE(Game)
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
			array[i] = base.Game._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>(string.Format(string_1, i));
		}
		_Yu3OngEjZbsgelWEySu6GE7aoYg yu3OngEjZbsgelWEySu6GE7aoYg = new _Yu3OngEjZbsgelWEySu6GE7aoYg(this, string_0, array)
		{
			_C6GAq9XPMC9PQPnaaRqYWpv4V6S = true,
			X = int_0,
			Y = int_1
		};
		_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(yu3OngEjZbsgelWEySu6GE7aoYg, 2);
		_3QdafDZxM3h1i8B990AwwFqleds.Add(yu3OngEjZbsgelWEySu6GE7aoYg);
		return yu3OngEjZbsgelWEySu6GE7aoYg;
	}

	public override void Update(GameTime gameTime_0)
	{
		base.Update(gameTime_0);
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
		if (base.Game._o2QVQfIAsuLcmPxn14llGoZA52y != null)
		{
			_zBw0aG4VRggByEYsHPjIPCYfoQJ._nJKYvZJ57vjjlQwmoeBmKihtS0b = base.Game._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b;
			_zBw0aG4VRggByEYsHPjIPCYfoQJ.Update(gameTime_0);
		}
	}

	public void _KkwafXXLVg1QfQgqqCAojg2ySyZ(SpriteBatch spriteBatch_0)
	{
		if (_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._yuFBJdi7mxrwMFQ57BjLjSq6ESj._mW1Z69pRB1eedGT3FSmdItJre5Y != null)
		{
			spriteBatch_0.Begin(SpriteSortMode.Deferred, BlendState.NonPremultiplied, null, null, null, null, Matrix.CreateTranslation(-100f, -390f, 0f) * Matrix.CreateRotationZ((float)Math.Sin(_boyt8NIMtKsAGSTcjHeL0WMbFxs._AmIUCcrmrrQiiirja7DoiZSjXuv) * MathHelper.ToRadians(5f)) * Matrix.CreateTranslation(90f, 390f, 0f));
			_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._yuFBJdi7mxrwMFQ57BjLjSq6ESj._mW1Z69pRB1eedGT3FSmdItJre5Y.Draw(spriteBatch_0);
			spriteBatch_0.End();
		}
	}

	public override void Render(SpriteBatch spriteBatch_0)
	{
		base.Render(spriteBatch_0);
		spriteBatch_0.Begin();
		_CD732c1llp0dkEnK6CI9WZR70Ap.Draw(spriteBatch_0);
		spriteBatch_0.End();
		_zBw0aG4VRggByEYsHPjIPCYfoQJ.Draw(spriteBatch_0);
	}

	private void _MRzbkwglCADk2fFjoxcsdCSJfKu()
	{
		base.Game._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b = false;
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
		int _ExpbREeE97oXaFMwg5UwE6MpAAQ = base.Game._vsceSzSIjBy2nZrCxAzKZbUiwLq._KOuUew34v1oSMnWlHSFJuRBiu1c;
		int _P2eFcUFiRYQgRf4ICqeX3kVcA2m = base.Game._vsceSzSIjBy2nZrCxAzKZbUiwLq._dh9yjUXG1mhcfgwAWkWfggbGEIc;
		foreach (DisplayMode supportedDisplayMode in base.Game._2yepMkVENnecIsduggABaU2qhXW.Adapter.SupportedDisplayModes)
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
				base.Game._fSRUnXzLhUs3DfJ1lzl9dGCEmCf(displayMode.Width, displayMode.Height);
				Options.Data.ResolutionWidth = displayMode.Width;
				Options.Data.ResolutionHeight = displayMode.Height;
				_ExpbREeE97oXaFMwg5UwE6MpAAQ = displayMode.Width;
				_P2eFcUFiRYQgRf4ICqeX3kVcA2m = displayMode.Height;
			}
		};
		CheckBox checkBox = new CheckBox
		{
			Dock = DockStyle.Top,
			Text = "Fullscreen",
			Checked = base.Game._kSReo0whY1pgfTnFOSc44ppANOe
		};
		checkBox.CheckedChanged += delegate
		{
			base.Game._fSRUnXzLhUs3DfJ1lzl9dGCEmCf(_ExpbREeE97oXaFMwg5UwE6MpAAQ, _P2eFcUFiRYQgRf4ICqeX3kVcA2m, !base.Game._kSReo0whY1pgfTnFOSc44ppANOe);
			Options.Data.Fullscreen = base.Game._kSReo0whY1pgfTnFOSc44ppANOe;
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
		slider.Value = Options.Data.MasterVolume * 100f;
		slider.Style = "scrollSlider";
		slider.Size = new Squid.Point(0, 30);
		slider.Button.Style = "scrollSliderButton";
		Slider _XEgAfmv7sJWJSaC2diC3eaD4Fgl = slider;
		_XEgAfmv7sJWJSaC2diC3eaD4Fgl.ValueChanged += delegate
		{
			Options.Data.MasterVolume = _XEgAfmv7sJWJSaC2diC3eaD4Fgl.Value / 100f;
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
		slider2.Value = Options.Data.MusicVolume * 100f;
		slider2.Style = "scrollSlider";
		slider2.Size = new Squid.Point(0, 30);
		slider2.Button.Style = "scrollSliderButton";
		Slider _gjeIIVx9bHyd0aMj0WD483nrLWK = slider2;
		_gjeIIVx9bHyd0aMj0WD483nrLWK.ValueChanged += delegate
		{
			Options.Data.MusicVolume = _gjeIIVx9bHyd0aMj0WD483nrLWK.Value / 100f;
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
		slider3.Value = Options.Data.SfxVolume * 100f;
		slider3.Style = "scrollSlider";
		slider3.Size = new Squid.Point(0, 30);
		slider3.Button.Style = "scrollSliderButton";
		Slider _5mK9ExiyKm0md8q4J1C6xc4TzdF = slider3;
		_5mK9ExiyKm0md8q4J1C6xc4TzdF.ValueChanged += delegate
		{
			Options.Data.SfxVolume = _5mK9ExiyKm0md8q4J1C6xc4TzdF.Value / 100f;
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
		_poenyHBGUusBcnNcTFB9MQBV72R._YemBTJprwfbd3mpg5Gy9uyEJWwI(panel.Content.Controls, "Text Speed", new string[4] { "Slow", "Normal", "Fast", "Instant" }, (int)Options.Data.DialogueTextSpeed, delegate(int int_0)
		{
			Options.Data.DialogueTextSpeed = (DialogueSpeed)int_0;
			_nkzqFdEfDyLcyGikIKGcHjklI4y._NhL238TaCbkDiY6HXlWXZzzUYkm = (DialogueSpeed)int_0;
		});
		CheckBox _feL3soNn6ZWaJqYfjYJUyH118tF = new CheckBox
		{
			Dock = DockStyle.Top,
			Text = "Auto-skip",
			Checked = Options.Data.DialogueAutoSkip
		};
		_feL3soNn6ZWaJqYfjYJUyH118tF.CheckedChanged += delegate
		{
			Options.Data.DialogueAutoSkip = _feL3soNn6ZWaJqYfjYJUyH118tF.Checked;
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
			base.Game._o2QVQfIAsuLcmPxn14llGoZA52y._nJKYvZJ57vjjlQwmoeBmKihtS0b = true;
			Options.Save();
			_L7VColD35B3sDgJdUnjTeXGa7pv.Close();
		};
		panel.Content.Controls.Add(button);
		_L7VColD35B3sDgJdUnjTeXGa7pv.Show(base._PnkAlVnMv0SZvRBFexqzE5DF9tp);
	}

	public override void End()
	{
		base.End();
		_5Anqe6GAAkzemoAXYpJmgMlk1yz._3DInasj5B11bCcV5BIRvLE1Ay7w = false;
	}
}
