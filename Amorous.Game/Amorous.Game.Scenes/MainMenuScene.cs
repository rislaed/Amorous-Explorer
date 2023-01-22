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
		MainMenuScene.smethod_18((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/MainMenu/Menu Background", -240, -135);
		MainMenuScene.smethod_18((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Bed", "Assets/Scenes/MainMenu/Bed", -240, -135);
		MainMenuScene.smethod_18((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Logo", "Assets/Scenes/MainMenu/Bed Logo", -240, -135);
		MainMenuScene.smethod_18((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Table", "Assets/Scenes/MainMenu/Table and clock", -240, -135);
		MainMenuScene.smethod_18((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "LCD Separator", "Assets/Scenes/MainMenu/Semicolon", -155, -135);
		_fAUddQEKfZyemRb327NhM3GGlmzA fAUddQEKfZyemRb327NhM3GGlmzA = MainMenuScene.smethod_19((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Custom");
		MainMenuScene.smethod_20(fAUddQEKfZyemRb327NhM3GGlmzA, (Action<SpriteBatch>)_KkwafXXLVg1QfQgqqCAojg2ySyZ);
		_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(fAUddQEKfZyemRb327NhM3GGlmzA, 0);
		MainMenuScene.smethod_21((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Sheet", "Assets/Scenes/MainMenu/Bed Sheet", -240, -135);
		_CD732c1llp0dkEnK6CI9WZR70Ap = _Iz47swAAB7d2iX6PQ1xTIJIv8MJ("Title", "Assets/Scenes/MainMenu/Logo", 1220, 800);
		_mdGACc5Q6BQjhranQdPI7V5unWx("LCD 1", "Assets/Scenes/MainMenu/{0}", 1090, 330);
		_mdGACc5Q6BQjhranQdPI7V5unWx("LCD 2", "Assets/Scenes/MainMenu/{0}", 1215, 330);
		_mdGACc5Q6BQjhranQdPI7V5unWx("LCD 3", "Assets/Scenes/MainMenu/{0}", 1395, 330);
		_mdGACc5Q6BQjhranQdPI7V5unWx("LCD 4", "Assets/Scenes/MainMenu/{0}", 1520, 330);
		_BR9uYwHtclf8uWEyxJ20ADY6mpg = 750;
		_dNKOpSAr033bMQm76I1LEv39GTm = MainMenuScene.smethod_22((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "LCD Separator");
		MainMenuScene.smethod_23((_21uBmerICJi18moE2gpxlEipBgz)new _hiwkgwXJpRLUFatcgZFfH6ECNfm(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0));
		MainMenuScene.smethod_24("Assets/Music/WarmanSteve - Giant Robots", 0.4f);
		_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._lXEQJcXKxsjtZp00Y9aPe0ymGue(new _BlUQCbX8YXbBc38I7iPEHyF1rUQ(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		{
			_uIOOxdCbSvCxXvjNgoXh2qYj0hr = delegate
			{
				MainMenuScene.smethod_43(MainMenuScene.smethod_42(MainMenuScene.smethod_25((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), bool_0: false);
				MainMenuScene.smethod_49(MainMenuScene.smethod_48((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "What would you like to do?", new string[4] { "New Game", "New Game w/o Prologue", "Character Customization", "Oops, I've changed my mind!" }, 500, (Action<int>)delegate(int int_0)
				{
					_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG_ = MainMenuScene.smethod_50();
					switch (int_0)
					{
					default:
						MainMenuScene.smethod_43(MainMenuScene.smethod_42(MainMenuScene.smethod_25((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), bool_0: true);
						break;
					case 0:
						MainMenuScene.smethod_51((Action)null);
						MainMenuScene.smethod_52(opIJo2jLUqdOL5yAFP4yzXce0DG_);
						_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = false;
						MainMenuScene.smethod_55(MainMenuScene.smethod_54(MainMenuScene.smethod_53()));
						MainMenuScene.smethod_57(MainMenuScene.smethod_56(MainMenuScene.smethod_53()));
						MainMenuScene.smethod_58(MainMenuScene.smethod_25((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "Prologue");
						break;
					case 1:
						MainMenuScene.smethod_51((Action)null);
						MainMenuScene.smethod_52(opIJo2jLUqdOL5yAFP4yzXce0DG_);
						_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = false;
						MainMenuScene.smethod_55(MainMenuScene.smethod_54(MainMenuScene.smethod_53()));
						MainMenuScene.smethod_57(MainMenuScene.smethod_56(MainMenuScene.smethod_53()));
						MainMenuScene.smethod_25((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._k9wUPeU1Ga7cygiuGP8TT6aPLWF<SkipProloguePlayerCustomizationScene>();
						break;
					case 2:
						MainMenuScene.smethod_51((Action)null);
						MainMenuScene.smethod_52(opIJo2jLUqdOL5yAFP4yzXce0DG_);
						_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = false;
						MainMenuScene.smethod_55(MainMenuScene.smethod_54(MainMenuScene.smethod_53()));
						MainMenuScene.smethod_57(MainMenuScene.smethod_56(MainMenuScene.smethod_53()));
						MainMenuScene.smethod_25((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._k9wUPeU1Ga7cygiuGP8TT6aPLWF<PlayerCustomizationScene>();
						break;
					}
				});
			},
			_HmpXEsA3mxR8eI4MZmgIPCtSGQb = delegate
			{
				MainMenuScene.smethod_43(MainMenuScene.smethod_42(MainMenuScene.smethod_25((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), bool_0: false);
				List<_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p> _rQhndDODcLCmH9PKjwXRNz0AcU8 = MainMenuScene.smethod_59(bool_0: false);
				List<string> _ILFAnNbgAYkKwOVs9Pn9012gw1w = _rQhndDODcLCmH9PKjwXRNz0AcU8.Select((_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p _3CCr8Bt1rkuzt0M6gYLbceJGV0p_0) => _003C_003Ec.smethod_0(_3CCr8Bt1rkuzt0M6gYLbceJGV0p_0)).ToList();
				_ILFAnNbgAYkKwOVs9Pn9012gw1w.Add("Oops, I've changed my mind!");
				MainMenuScene.smethod_49(MainMenuScene.smethod_48((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "Which save do you wish to load?", _ILFAnNbgAYkKwOVs9Pn9012gw1w.ToArray(), 500, (Action<int>)delegate(int int_0)
				{
					if (int_0 == _ILFAnNbgAYkKwOVs9Pn9012gw1w.Count - 1)
					{
						_003C_003Ec__DisplayClass6_0.smethod_2(_003C_003Ec__DisplayClass6_0.smethod_1(_003C_003Ec__DisplayClass6_0.smethod_0((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), bool_0: true);
					}
					else
					{
						_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p _3CCr8Bt1rkuzt0M6gYLbceJGV0p_ = _rQhndDODcLCmH9PKjwXRNz0AcU8[int_0];
						if (!_003C_003Ec__DisplayClass6_0.smethod_3(_3CCr8Bt1rkuzt0M6gYLbceJGV0p_))
						{
							if (!((!_003C_003Ec__DisplayClass6_0.smethod_5(_3CCr8Bt1rkuzt0M6gYLbceJGV0p_)) ? _003C_003Ec__DisplayClass6_0.smethod_10(_003C_003Ec__DisplayClass6_0.smethod_0((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), _003C_003Ec__DisplayClass6_0.smethod_8(_3CCr8Bt1rkuzt0M6gYLbceJGV0p_)) : _003C_003Ec__DisplayClass6_0.smethod_9(_003C_003Ec__DisplayClass6_0.smethod_0((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), _003C_003Ec__DisplayClass6_0.smethod_8(_3CCr8Bt1rkuzt0M6gYLbceJGV0p_))))
							{
								_003C_003Ec__DisplayClass6_0.smethod_7(_003C_003Ec__DisplayClass6_0.smethod_4((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "Failed to load save, it's most likely corrupted.", 250, "OK", (Action)delegate
								{
									MainMenuScene.smethod_43(MainMenuScene.smethod_42(MainMenuScene.smethod_25((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), bool_0: true);
								});
							}
							else
							{
								_003C_003Ec__DisplayClass6_0.smethod_2(_003C_003Ec__DisplayClass6_0.smethod_1(_003C_003Ec__DisplayClass6_0.smethod_0((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), bool_0: true);
							}
						}
						else
						{
							_003C_003Ec__DisplayClass6_0.smethod_7(_003C_003Ec__DisplayClass6_0.smethod_4((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), _003C_003Ec__DisplayClass6_0.smethod_6("There is no save in {0}slot #{1}!", (object)(_003C_003Ec__DisplayClass6_0.smethod_5(_3CCr8Bt1rkuzt0M6gYLbceJGV0p_) ? "autosave " : string.Empty), (object)(int_0 + 1)), 250, "OK", (Action)delegate
							{
								MainMenuScene.smethod_43(MainMenuScene.smethod_42(MainMenuScene.smethod_25((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), bool_0: true);
							});
						}
					}
				});
			},
			_vE5Pvwth7cQFh82bMTB5u59Ju4o = delegate
			{
				MainMenuScene.smethod_43(MainMenuScene.smethod_42(MainMenuScene.smethod_25((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), bool_0: false);
				MainMenuScene.smethod_49(MainMenuScene.smethod_48((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "Are you sure you wish to quit the game?", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, 500, (Action<int>)delegate(int int_0)
				{
					if (int_0 == 1)
					{
						MainMenuScene.smethod_61(MainMenuScene.smethod_60(MainMenuScene.smethod_25((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), (Action)delegate
						{
							MainMenuScene.smethod_62(MainMenuScene.smethod_25((_7UlnfykmEmZDFt3BmCKZekI43Ih)this));
						});
					}
					MainMenuScene.smethod_43(MainMenuScene.smethod_42(MainMenuScene.smethod_25((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), bool_0: true);
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
		Texture2D[] array = (Texture2D[])(object)new Texture2D[10];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = MainMenuScene.smethod_26(MainMenuScene.smethod_25((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)).Load<Texture2D>(MainMenuScene.smethod_27(string_1, (object)i));
		}
		_Yu3OngEjZbsgelWEySu6GE7aoYg yu3OngEjZbsgelWEySu6GE7aoYg = new _Yu3OngEjZbsgelWEySu6GE7aoYg(this, string_0, array);
		MainMenuScene.smethod_28((_ujAkjlfN5TywwbLAUDzPvtab6uJ)yu3OngEjZbsgelWEySu6GE7aoYg, bool_0: true);
		MainMenuScene.smethod_29((_ujAkjlfN5TywwbLAUDzPvtab6uJ)yu3OngEjZbsgelWEySu6GE7aoYg, (float)int_0);
		MainMenuScene.smethod_30((_ujAkjlfN5TywwbLAUDzPvtab6uJ)yu3OngEjZbsgelWEySu6GE7aoYg, (float)int_1);
		_Yu3OngEjZbsgelWEySu6GE7aoYg yu3OngEjZbsgelWEySu6GE7aoYg2 = yu3OngEjZbsgelWEySu6GE7aoYg;
		_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(yu3OngEjZbsgelWEySu6GE7aoYg2, 2);
		_3QdafDZxM3h1i8B990AwwFqleds.Add(yu3OngEjZbsgelWEySu6GE7aoYg2);
		return yu3OngEjZbsgelWEySu6GE7aoYg2;
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		base._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
		_BR9uYwHtclf8uWEyxJ20ADY6mpg -= MainMenuScene.smethod_31(gameTime_0).Milliseconds;
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
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		if (MainMenuScene.smethod_33(MainMenuScene.smethod_32()) != null)
		{
			MainMenuScene.smethod_36(spriteBatch_0, (SpriteSortMode)0, BlendState.NonPremultiplied, (SamplerState)null, (DepthStencilState)null, (RasterizerState)null, (Effect)null, (Matrix?)(Matrix.CreateTranslation(-100f, -390f, 0f) * Matrix.CreateRotationZ((float)MainMenuScene.smethod_34((double)_boyt8NIMtKsAGSTcjHeL0WMbFxs._AmIUCcrmrrQiiirja7DoiZSjXuv) * MainMenuScene.smethod_35(5f)) * Matrix.CreateTranslation(90f, 390f, 0f)));
			MainMenuScene.smethod_37(MainMenuScene.smethod_33(MainMenuScene.smethod_32()), spriteBatch_0);
			MainMenuScene.smethod_38(spriteBatch_0);
		}
	}

	public override void _Z70nK2EA1n5FNJxjWP0TzHQ0Lzb(SpriteBatch spriteBatch_0)
	{
		base._Z70nK2EA1n5FNJxjWP0TzHQ0Lzb(spriteBatch_0);
		MainMenuScene.smethod_39(spriteBatch_0);
		MainMenuScene.smethod_40((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_CD732c1llp0dkEnK6CI9WZR70Ap, spriteBatch_0);
		MainMenuScene.smethod_38(spriteBatch_0);
		MainMenuScene.smethod_41((_8lVOgkauaSHbAkAqHzI1K7mIyOI)_zBw0aG4VRggByEYsHPjIPCYfoQJ, spriteBatch_0);
	}

	private void _MRzbkwglCADk2fFjoxcsdCSJfKu()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected O, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected O, but got Unknown
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected O, but got Unknown
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected O, but got Unknown
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Expected O, but got Unknown
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected O, but got Unknown
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Expected O, but got Unknown
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected O, but got Unknown
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected O, but got Unknown
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Expected O, but got Unknown
		//IL_053b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Unknown result type (might be due to invalid IL or missing references)
		//IL_055b: Expected O, but got Unknown
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fe: Expected O, but got Unknown
		//IL_060b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0615: Expected O, but got Unknown
		//IL_0644: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Unknown result type (might be due to invalid IL or missing references)
		//IL_0650: Unknown result type (might be due to invalid IL or missing references)
		//IL_0657: Unknown result type (might be due to invalid IL or missing references)
		//IL_0664: Expected O, but got Unknown
		//IL_0666: Unknown result type (might be due to invalid IL or missing references)
		//IL_066b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0672: Unknown result type (might be due to invalid IL or missing references)
		//IL_067d: Unknown result type (might be due to invalid IL or missing references)
		//IL_068d: Expected O, but got Unknown
		//IL_069c: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a6: Expected O, but got Unknown
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0709: Expected O, but got Unknown
		//IL_0718: Unknown result type (might be due to invalid IL or missing references)
		//IL_0722: Expected O, but got Unknown
		//IL_0724: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Unknown result type (might be due to invalid IL or missing references)
		//IL_0730: Unknown result type (might be due to invalid IL or missing references)
		//IL_073b: Unknown result type (might be due to invalid IL or missing references)
		//IL_074b: Expected O, but got Unknown
		//IL_075a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0764: Expected O, but got Unknown
		//IL_0792: Unknown result type (might be due to invalid IL or missing references)
		//IL_0797: Unknown result type (might be due to invalid IL or missing references)
		//IL_079e: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ab: Expected O, but got Unknown
		//IL_07b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07be: Expected O, but got Unknown
		MainMenuScene.smethod_43(MainMenuScene.smethod_42(MainMenuScene.smethod_25((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), bool_0: false);
		int num = 0;
		if (MainMenuScene.smethod_44())
		{
			num += 60;
		}
		if (!MainMenuScene.smethod_45())
		{
			num += 60;
		}
		Window obj = MainMenuScene.smethod_46();
		MainMenuScene.smethod_47((Control)(object)obj, (DockStyle)8);
		((Control)obj).set_Size(new Point(512, 540 + num));
		((Control)obj).set_Margin(new Margin(8));
		((Control)obj).set_Padding(new Margin(8));
		Window _L7VColD35B3sDgJdUnjTeXGa7pv = obj;
		Panel val = new Panel();
		((Control)val).set_Dock((DockStyle)5);
		((Control)val).set_Margin(new Margin(8));
		Panel val2 = val;
		((ActiveList<Control>)(object)_L7VColD35B3sDgJdUnjTeXGa7pv.get_Controls()).Add((Control)(object)val2);
		Label val3 = new Label();
		((Control)val3).set_Dock((DockStyle)2);
		val3.set_TextAlign((Alignment)4);
		val3.set_Text("Display");
		Label val4 = val3;
		Label val5 = new Label();
		((Control)val5).set_Dock((DockStyle)2);
		val5.set_Text("Resolutions");
		Label val6 = val5;
		DropDownList val7 = new DropDownList();
		((Control)val7).set_Dock((DockStyle)2);
		((Control)val7).set_Style("button");
		((Control)val7.get_Label()).set_Margin(new Margin(10, 0, 0, 0));
		val7.get_Dropdown().set_Resizable(false);
		((Control)val7).set_Margin(new Margin(0, 0, 0, 5));
		DropDownList val8 = val7;
		((Control)val8.get_Listbox().get_Scrollbar().get_ButtonUp()).set_Visible(false);
		((Control)val8.get_Listbox().get_Scrollbar().get_ButtonDown()).set_Visible(false);
		int _ExpbREeE97oXaFMwg5UwE6MpAAQ = base._ZzBuoSDMWwerejOO9Goyv2OCKgE._vsceSzSIjBy2nZrCxAzKZbUiwLq._KOuUew34v1oSMnWlHSFJuRBiu1c;
		int _P2eFcUFiRYQgRf4ICqeX3kVcA2m = base._ZzBuoSDMWwerejOO9Goyv2OCKgE._vsceSzSIjBy2nZrCxAzKZbUiwLq._dh9yjUXG1mhcfgwAWkWfggbGEIc;
		foreach (DisplayMode supportedDisplayMode in base._ZzBuoSDMWwerejOO9Goyv2OCKgE._2yepMkVENnecIsduggABaU2qhXW.get_Adapter().get_SupportedDisplayModes())
		{
			ActiveList<ListBoxItem> items = val8.get_Items();
			ListBoxItem val9 = new ListBoxItem();
			((Label)val9).set_Text(supportedDisplayMode.get_Width() + "x" + supportedDisplayMode.get_Height());
			val9.set_Value((object)supportedDisplayMode);
			((Control)val9).set_Size(new Point(0, 30));
			val9.set_Selected(_ExpbREeE97oXaFMwg5UwE6MpAAQ == supportedDisplayMode.get_Width() && _P2eFcUFiRYQgRf4ICqeX3kVcA2m == supportedDisplayMode.get_Height());
			items.Add(val9);
		}
		val8.add_SelectedItemChanged((SelectedItemChangedEventHandler)delegate(Control control_0, ListBoxItem listBoxItem_0)
		{
			if (_003C_003Ec__DisplayClass12_0.smethod_0(listBoxItem_0) is DisplayMode)
			{
				object obj2 = _003C_003Ec__DisplayClass12_0.smethod_0(listBoxItem_0);
				DisplayMode displayMode_ = (DisplayMode)((obj2 is DisplayMode) ? obj2 : null);
				_003C_003Ec__DisplayClass12_0.smethod_4(_003C_003Ec__DisplayClass12_0.smethod_1((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), _003C_003Ec__DisplayClass12_0.smethod_2(displayMode_), _003C_003Ec__DisplayClass12_0.smethod_3(displayMode_));
				_003C_003Ec__DisplayClass12_0.smethod_6(_003C_003Ec__DisplayClass12_0.smethod_5(), _003C_003Ec__DisplayClass12_0.smethod_2(displayMode_));
				_003C_003Ec__DisplayClass12_0.smethod_7(_003C_003Ec__DisplayClass12_0.smethod_5(), _003C_003Ec__DisplayClass12_0.smethod_3(displayMode_));
				_ExpbREeE97oXaFMwg5UwE6MpAAQ = _003C_003Ec__DisplayClass12_0.smethod_2(displayMode_);
				_P2eFcUFiRYQgRf4ICqeX3kVcA2m = _003C_003Ec__DisplayClass12_0.smethod_3(displayMode_);
			}
		});
		CheckBox val10 = new CheckBox();
		((Control)val10).set_Dock((DockStyle)2);
		val10.set_Text("Fullscreen");
		val10.set_Checked(base._ZzBuoSDMWwerejOO9Goyv2OCKgE._kSReo0whY1pgfTnFOSc44ppANOe);
		CheckBox val11 = val10;
		val11.add_CheckedChanged((VoidEvent)delegate
		{
			_003C_003Ec__DisplayClass12_0.smethod_9(_003C_003Ec__DisplayClass12_0.smethod_1((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), _ExpbREeE97oXaFMwg5UwE6MpAAQ, _P2eFcUFiRYQgRf4ICqeX3kVcA2m, !_003C_003Ec__DisplayClass12_0.smethod_8(_003C_003Ec__DisplayClass12_0.smethod_1((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)));
			_003C_003Ec__DisplayClass12_0.smethod_10(_003C_003Ec__DisplayClass12_0.smethod_5(), _003C_003Ec__DisplayClass12_0.smethod_8(_003C_003Ec__DisplayClass12_0.smethod_1((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)));
		});
		((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)val4);
		((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)val6);
		((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)val8);
		((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)val11);
		Label val12 = new Label();
		((Control)val12).set_Dock((DockStyle)2);
		val12.set_TextAlign((Alignment)4);
		val12.set_Text("Sound");
		Label val13 = val12;
		Label val14 = new Label();
		((Control)val14).set_Dock((DockStyle)2);
		val14.set_Text("Master Volume");
		Label val15 = val14;
		Slider val16 = new Slider();
		((Control)val16).set_Dock((DockStyle)2);
		val16.set_Orientation((Orientation)0);
		val16.set_Steps(100f);
		val16.set_Value(_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._DF24JUrPFA6rJ2cQrOTlpC3I4FF * 100f);
		((Control)val16).set_Style("scrollSlider");
		((Control)val16).set_Size(new Point(0, 30));
		((Control)val16.get_Button()).set_Style("scrollSliderButton");
		Slider _XEgAfmv7sJWJSaC2diC3eaD4Fgl = val16;
		_XEgAfmv7sJWJSaC2diC3eaD4Fgl.add_ValueChanged((VoidEvent)delegate
		{
			_003C_003Ec__DisplayClass12_0.smethod_12(_003C_003Ec__DisplayClass12_0.smethod_5(), _003C_003Ec__DisplayClass12_0.smethod_11(_XEgAfmv7sJWJSaC2diC3eaD4Fgl) / 100f);
		});
		Label val17 = new Label();
		((Control)val17).set_Dock((DockStyle)2);
		val17.set_Text("Music Volume");
		Label val18 = val17;
		Slider val19 = new Slider();
		((Control)val19).set_Dock((DockStyle)2);
		val19.set_Orientation((Orientation)0);
		val19.set_Steps(100f);
		val19.set_Value(_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._7NidKjx61ui5CP7JojwfqxH4aKC * 100f);
		((Control)val19).set_Style("scrollSlider");
		((Control)val19).set_Size(new Point(0, 30));
		((Control)val19.get_Button()).set_Style("scrollSliderButton");
		Slider _gjeIIVx9bHyd0aMj0WD483nrLWK = val19;
		_gjeIIVx9bHyd0aMj0WD483nrLWK.add_ValueChanged((VoidEvent)delegate
		{
			_003C_003Ec__DisplayClass12_0.smethod_13(_003C_003Ec__DisplayClass12_0.smethod_5(), _003C_003Ec__DisplayClass12_0.smethod_11(_gjeIIVx9bHyd0aMj0WD483nrLWK) / 100f);
		});
		Label val20 = new Label();
		((Control)val20).set_Dock((DockStyle)2);
		val20.set_Text("SFX Volume");
		Label val21 = val20;
		Slider val22 = new Slider();
		((Control)val22).set_Dock((DockStyle)2);
		val22.set_Orientation((Orientation)0);
		val22.set_Steps(100f);
		val22.set_Value(_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._2g4Ch8GXdUt0oEbdCZUY2QMbIuH * 100f);
		((Control)val22).set_Style("scrollSlider");
		((Control)val22).set_Size(new Point(0, 30));
		((Control)val22.get_Button()).set_Style("scrollSliderButton");
		Slider _5mK9ExiyKm0md8q4J1C6xc4TzdF = val22;
		_5mK9ExiyKm0md8q4J1C6xc4TzdF.add_ValueChanged((VoidEvent)delegate
		{
			_003C_003Ec__DisplayClass12_0.smethod_14(_003C_003Ec__DisplayClass12_0.smethod_5(), _003C_003Ec__DisplayClass12_0.smethod_11(_5mK9ExiyKm0md8q4J1C6xc4TzdF) / 100f);
		});
		((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)val13);
		((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)val15);
		((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)_XEgAfmv7sJWJSaC2diC3eaD4Fgl);
		((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)val18);
		((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)_gjeIIVx9bHyd0aMj0WD483nrLWK);
		((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)val21);
		((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)_5mK9ExiyKm0md8q4J1C6xc4TzdF);
		Label val23 = new Label();
		((Control)val23).set_Dock((DockStyle)2);
		val23.set_TextAlign((Alignment)4);
		val23.set_Text("Dialogue");
		Label val24 = val23;
		((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)val24);
		_poenyHBGUusBcnNcTFB9MQBV72R._YemBTJprwfbd3mpg5Gy9uyEJWwI(val2.get_Content().get_Controls(), "Text Speed", new string[4] { "Slow", "Normal", "Fast", "Instant" }, (int)_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._wVLRBSMULz8GfedBPXaVJB0sBEO, delegate(int int_0)
		{
			_003C_003Ec.smethod_2(_003C_003Ec.smethod_1(), (DialogueSpeed)int_0);
			_003C_003Ec.smethod_3((DialogueSpeed)int_0);
		});
		CheckBox val25 = new CheckBox();
		((Control)val25).set_Dock((DockStyle)2);
		val25.set_Text("Auto-skip");
		val25.set_Checked(_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._sbK0941BvW8HgPboNwOhIAd2jP3);
		CheckBox _feL3soNn6ZWaJqYfjYJUyH118tF = val25;
		_feL3soNn6ZWaJqYfjYJUyH118tF.add_CheckedChanged((VoidEvent)delegate
		{
			_003C_003Ec__DisplayClass12_0.smethod_16(_003C_003Ec__DisplayClass12_0.smethod_5(), _003C_003Ec__DisplayClass12_0.smethod_15(_feL3soNn6ZWaJqYfjYJUyH118tF));
			_003C_003Ec__DisplayClass12_0.smethod_17(_003C_003Ec__DisplayClass12_0.smethod_15(_feL3soNn6ZWaJqYfjYJUyH118tF));
		});
		((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)_feL3soNn6ZWaJqYfjYJUyH118tF);
		if (_iExD93IWLlzVfXsU9wyrEvWgJsg._X41qA9hgcgXH0Q1aFKWFWpg8UuM)
		{
			Label val26 = new Label();
			((Control)val26).set_Dock((DockStyle)2);
			val26.set_TextAlign((Alignment)4);
			val26.set_Text("Cheats");
			Label val27 = val26;
			CheckBox val28 = new CheckBox();
			((Control)val28).set_Dock((DockStyle)2);
			val28.set_Text("Enable SFW-mode");
			val28.set_Checked(_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF);
			CheckBox _LFRG0GY4VuOaiC2XHbpUmFoVDAj = val28;
			_LFRG0GY4VuOaiC2XHbpUmFoVDAj.add_CheckedChanged((VoidEvent)delegate
			{
				_003C_003Ec__DisplayClass12_1.smethod_1(_003C_003Ec__DisplayClass12_1.smethod_0(_LFRG0GY4VuOaiC2XHbpUmFoVDAj));
				_003C_003Ec__DisplayClass12_1.smethod_2(_L7VColD35B3sDgJdUnjTeXGa7pv);
				_MRzbkwglCADk2fFjoxcsdCSJfKu();
			});
			((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)val27);
			((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)_LFRG0GY4VuOaiC2XHbpUmFoVDAj);
		}
		if (!_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
		{
			CheckBox val29 = new CheckBox();
			((Control)val29).set_Dock((DockStyle)2);
			val29.set_Text("Enable Topless");
			val29.set_Checked(_iExD93IWLlzVfXsU9wyrEvWgJsg._b52DDz3MN1kD8sgdQhCNO1tJRNn);
			CheckBox _PBgLcZr7dRzS97rFn3FU6lDw8ZE = val29;
			_PBgLcZr7dRzS97rFn3FU6lDw8ZE.add_CheckedChanged((VoidEvent)delegate
			{
				_003C_003Ec__DisplayClass12_2.smethod_1(_003C_003Ec__DisplayClass12_2.smethod_0(_PBgLcZr7dRzS97rFn3FU6lDw8ZE));
			});
			CheckBox val30 = new CheckBox();
			((Control)val30).set_Dock((DockStyle)2);
			val30.set_Text("Enable Bottomless");
			val30.set_Checked(_iExD93IWLlzVfXsU9wyrEvWgJsg._pKBiGAgDu5WqoykkGBaEGnP7oMj);
			CheckBox _qWiPLfzctHo3AqPevD7VV4qTuDy = val30;
			_qWiPLfzctHo3AqPevD7VV4qTuDy.add_CheckedChanged((VoidEvent)delegate
			{
				_003C_003Ec__DisplayClass12_2.smethod_2(_003C_003Ec__DisplayClass12_2.smethod_0(_qWiPLfzctHo3AqPevD7VV4qTuDy));
			});
			((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)_PBgLcZr7dRzS97rFn3FU6lDw8ZE);
			((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)_qWiPLfzctHo3AqPevD7VV4qTuDy);
		}
		Button val31 = new Button();
		((Control)val31).set_Dock((DockStyle)4);
		((Label)val31).set_Text("Close");
		Button val32 = val31;
		((Control)val32).add_MouseClick((MouseEvent)delegate
		{
			_003C_003Ec__DisplayClass12_0.smethod_19(_003C_003Ec__DisplayClass12_0.smethod_18(_003C_003Ec__DisplayClass12_0.smethod_1((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), bool_0: true);
			_003C_003Ec__DisplayClass12_0.smethod_20();
			_003C_003Ec__DisplayClass12_0.smethod_21(_L7VColD35B3sDgJdUnjTeXGa7pv);
		});
		((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)val32);
		_L7VColD35B3sDgJdUnjTeXGa7pv.Show(base._PnkAlVnMv0SZvRBFexqzE5DF9tp);
	}

	public override void _tO46aYSBLFIuhFNlhbrAeWbFDSf()
	{
		this.method_3();
		_5Anqe6GAAkzemoAXYpJmgMlk1yz._3DInasj5B11bCcV5BIRvLE1Ay7w = false;
	}

	[CompilerGenerated]
	private void _fI217APzl4Tapt53WowQWN9Ipyi()
	{
		MainMenuScene.smethod_43(MainMenuScene.smethod_42(MainMenuScene.smethod_25((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), bool_0: false);
		MainMenuScene.smethod_49(MainMenuScene.smethod_48((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "What would you like to do?", new string[4] { "New Game", "New Game w/o Prologue", "Character Customization", "Oops, I've changed my mind!" }, 500, (Action<int>)delegate(int int_0)
		{
			_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG_ = MainMenuScene.smethod_50();
			switch (int_0)
			{
			default:
				MainMenuScene.smethod_43(MainMenuScene.smethod_42(MainMenuScene.smethod_25((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), bool_0: true);
				break;
			case 0:
				MainMenuScene.smethod_51((Action)null);
				MainMenuScene.smethod_52(opIJo2jLUqdOL5yAFP4yzXce0DG_);
				_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = false;
				MainMenuScene.smethod_55(MainMenuScene.smethod_54(MainMenuScene.smethod_53()));
				MainMenuScene.smethod_57(MainMenuScene.smethod_56(MainMenuScene.smethod_53()));
				MainMenuScene.smethod_58(MainMenuScene.smethod_25((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "Prologue");
				break;
			case 1:
				MainMenuScene.smethod_51((Action)null);
				MainMenuScene.smethod_52(opIJo2jLUqdOL5yAFP4yzXce0DG_);
				_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = false;
				MainMenuScene.smethod_55(MainMenuScene.smethod_54(MainMenuScene.smethod_53()));
				MainMenuScene.smethod_57(MainMenuScene.smethod_56(MainMenuScene.smethod_53()));
				MainMenuScene.smethod_25((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._k9wUPeU1Ga7cygiuGP8TT6aPLWF<SkipProloguePlayerCustomizationScene>();
				break;
			case 2:
				MainMenuScene.smethod_51((Action)null);
				MainMenuScene.smethod_52(opIJo2jLUqdOL5yAFP4yzXce0DG_);
				_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = false;
				MainMenuScene.smethod_55(MainMenuScene.smethod_54(MainMenuScene.smethod_53()));
				MainMenuScene.smethod_57(MainMenuScene.smethod_56(MainMenuScene.smethod_53()));
				MainMenuScene.smethod_25((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._k9wUPeU1Ga7cygiuGP8TT6aPLWF<PlayerCustomizationScene>();
				break;
			}
		});
	}

	[CompilerGenerated]
	private void _SD73Tf7ANXaiMyg34yTgfWsn74y(int int_0)
	{
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG_ = MainMenuScene.smethod_50();
		switch (int_0)
		{
		default:
			MainMenuScene.smethod_43(MainMenuScene.smethod_42(MainMenuScene.smethod_25((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), bool_0: true);
			break;
		case 0:
			MainMenuScene.smethod_51((Action)null);
			MainMenuScene.smethod_52(opIJo2jLUqdOL5yAFP4yzXce0DG_);
			_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = false;
			MainMenuScene.smethod_55(MainMenuScene.smethod_54(MainMenuScene.smethod_53()));
			MainMenuScene.smethod_57(MainMenuScene.smethod_56(MainMenuScene.smethod_53()));
			MainMenuScene.smethod_58(MainMenuScene.smethod_25((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "Prologue");
			break;
		case 1:
			MainMenuScene.smethod_51((Action)null);
			MainMenuScene.smethod_52(opIJo2jLUqdOL5yAFP4yzXce0DG_);
			_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = false;
			MainMenuScene.smethod_55(MainMenuScene.smethod_54(MainMenuScene.smethod_53()));
			MainMenuScene.smethod_57(MainMenuScene.smethod_56(MainMenuScene.smethod_53()));
			MainMenuScene.smethod_25((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._k9wUPeU1Ga7cygiuGP8TT6aPLWF<SkipProloguePlayerCustomizationScene>();
			break;
		case 2:
			MainMenuScene.smethod_51((Action)null);
			MainMenuScene.smethod_52(opIJo2jLUqdOL5yAFP4yzXce0DG_);
			_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = false;
			MainMenuScene.smethod_55(MainMenuScene.smethod_54(MainMenuScene.smethod_53()));
			MainMenuScene.smethod_57(MainMenuScene.smethod_56(MainMenuScene.smethod_53()));
			MainMenuScene.smethod_25((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._k9wUPeU1Ga7cygiuGP8TT6aPLWF<PlayerCustomizationScene>();
			break;
		}
	}

	[CompilerGenerated]
	private void _3a8aQcA02aVpTZtKGWFgMtrJHSz()
	{
		MainMenuScene.smethod_43(MainMenuScene.smethod_42(MainMenuScene.smethod_25((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), bool_0: false);
		List<_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p> _rQhndDODcLCmH9PKjwXRNz0AcU8 = MainMenuScene.smethod_59(bool_0: false);
		List<string> _ILFAnNbgAYkKwOVs9Pn9012gw1w = _rQhndDODcLCmH9PKjwXRNz0AcU8.Select((_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p _3CCr8Bt1rkuzt0M6gYLbceJGV0p_0) => _003C_003Ec.smethod_0(_3CCr8Bt1rkuzt0M6gYLbceJGV0p_0)).ToList();
		_ILFAnNbgAYkKwOVs9Pn9012gw1w.Add("Oops, I've changed my mind!");
		MainMenuScene.smethod_49(MainMenuScene.smethod_48((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "Which save do you wish to load?", _ILFAnNbgAYkKwOVs9Pn9012gw1w.ToArray(), 500, (Action<int>)delegate(int int_0)
		{
			if (int_0 == _ILFAnNbgAYkKwOVs9Pn9012gw1w.Count - 1)
			{
				_003C_003Ec__DisplayClass6_0.smethod_2(_003C_003Ec__DisplayClass6_0.smethod_1(_003C_003Ec__DisplayClass6_0.smethod_0((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), bool_0: true);
			}
			else
			{
				_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p _3CCr8Bt1rkuzt0M6gYLbceJGV0p_ = _rQhndDODcLCmH9PKjwXRNz0AcU8[int_0];
				if (!_003C_003Ec__DisplayClass6_0.smethod_3(_3CCr8Bt1rkuzt0M6gYLbceJGV0p_))
				{
					if (!((!_003C_003Ec__DisplayClass6_0.smethod_5(_3CCr8Bt1rkuzt0M6gYLbceJGV0p_)) ? _003C_003Ec__DisplayClass6_0.smethod_10(_003C_003Ec__DisplayClass6_0.smethod_0((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), _003C_003Ec__DisplayClass6_0.smethod_8(_3CCr8Bt1rkuzt0M6gYLbceJGV0p_)) : _003C_003Ec__DisplayClass6_0.smethod_9(_003C_003Ec__DisplayClass6_0.smethod_0((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), _003C_003Ec__DisplayClass6_0.smethod_8(_3CCr8Bt1rkuzt0M6gYLbceJGV0p_))))
					{
						_003C_003Ec__DisplayClass6_0.smethod_7(_003C_003Ec__DisplayClass6_0.smethod_4((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "Failed to load save, it's most likely corrupted.", 250, "OK", (Action)delegate
						{
							MainMenuScene.smethod_43(MainMenuScene.smethod_42(MainMenuScene.smethod_25((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), bool_0: true);
						});
					}
					else
					{
						_003C_003Ec__DisplayClass6_0.smethod_2(_003C_003Ec__DisplayClass6_0.smethod_1(_003C_003Ec__DisplayClass6_0.smethod_0((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), bool_0: true);
					}
				}
				else
				{
					_003C_003Ec__DisplayClass6_0.smethod_7(_003C_003Ec__DisplayClass6_0.smethod_4((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), _003C_003Ec__DisplayClass6_0.smethod_6("There is no save in {0}slot #{1}!", (object)(_003C_003Ec__DisplayClass6_0.smethod_5(_3CCr8Bt1rkuzt0M6gYLbceJGV0p_) ? "autosave " : string.Empty), (object)(int_0 + 1)), 250, "OK", (Action)delegate
					{
						MainMenuScene.smethod_43(MainMenuScene.smethod_42(MainMenuScene.smethod_25((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), bool_0: true);
					});
				}
			}
		});
	}

	[CompilerGenerated]
	private void _2L0GcJVz3zT3U7tBW5tgN1ccYgp()
	{
		MainMenuScene.smethod_43(MainMenuScene.smethod_42(MainMenuScene.smethod_25((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), bool_0: true);
	}

	[CompilerGenerated]
	private void _plxCcrCl4DCKu5G7qBtjRepOyaM()
	{
		MainMenuScene.smethod_43(MainMenuScene.smethod_42(MainMenuScene.smethod_25((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), bool_0: true);
	}

	[CompilerGenerated]
	private void _W4PFYhu2NAZbDYPFpvdFr789eG0()
	{
		MainMenuScene.smethod_43(MainMenuScene.smethod_42(MainMenuScene.smethod_25((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), bool_0: false);
		MainMenuScene.smethod_49(MainMenuScene.smethod_48((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "Are you sure you wish to quit the game?", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, 500, (Action<int>)delegate(int int_0)
		{
			if (int_0 == 1)
			{
				MainMenuScene.smethod_61(MainMenuScene.smethod_60(MainMenuScene.smethod_25((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), (Action)delegate
				{
					MainMenuScene.smethod_62(MainMenuScene.smethod_25((_7UlnfykmEmZDFt3BmCKZekI43Ih)this));
				});
			}
			MainMenuScene.smethod_43(MainMenuScene.smethod_42(MainMenuScene.smethod_25((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), bool_0: true);
		});
	}

	[CompilerGenerated]
	private void _WXVOKjJHmBoMdMbldQqnBe7J5Ss(int int_0)
	{
		if (int_0 == 1)
		{
			MainMenuScene.smethod_61(MainMenuScene.smethod_60(MainMenuScene.smethod_25((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), (Action)delegate
			{
				MainMenuScene.smethod_62(MainMenuScene.smethod_25((_7UlnfykmEmZDFt3BmCKZekI43Ih)this));
			});
		}
		MainMenuScene.smethod_43(MainMenuScene.smethod_42(MainMenuScene.smethod_25((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), bool_0: true);
	}

	[CompilerGenerated]
	private void _BK4Ag37J0xySDkNNVq7rfpQgFa4()
	{
		MainMenuScene.smethod_62(MainMenuScene.smethod_25((_7UlnfykmEmZDFt3BmCKZekI43Ih)this));
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
		return gameTime_0.get_ElapsedGameTime();
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Window();
	}

	static void smethod_47(Control control_0, DockStyle dockStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Dock(dockStyle_0);
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
