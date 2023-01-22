using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spine;
using Squid;

public abstract class _7UlnfykmEmZDFt3BmCKZekI43Ih
{
	[CompilerGenerated]
	private sealed class _tG4UmqFtIzo0HrVclFcuXu2ibnh
	{
		public string _hzqOBkJhJBhsTRNARxHLctcvhN0;

		internal bool _malqtq9ExY4IyWRnXYHeVFkym0c(_ujAkjlfN5TywwbLAUDzPvtab6uJ _ujAkjlfN5TywwbLAUDzPvtab6uJ_0)
		{
			return _ujAkjlfN5TywwbLAUDzPvtab6uJ_0._RB8fRXeQvK5vs7JEA0XfVCEpg1i == _hzqOBkJhJBhsTRNARxHLctcvhN0;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _4m4kgLvNeqnaWMPC0tEDXKbnj3N
	{
		public static readonly _4m4kgLvNeqnaWMPC0tEDXKbnj3N _003C_003E9 = new _4m4kgLvNeqnaWMPC0tEDXKbnj3N();

		public static Func<_ujAkjlfN5TywwbLAUDzPvtab6uJ, int> _003C_003E9__55_0;

		public static Func<_ujAkjlfN5TywwbLAUDzPvtab6uJ, int> _003C_003E9__55_1;

		internal int _Urlv5H2tdofq8KuRciUcKHyHc7M(_ujAkjlfN5TywwbLAUDzPvtab6uJ _ujAkjlfN5TywwbLAUDzPvtab6uJ_0)
		{
			return _ujAkjlfN5TywwbLAUDzPvtab6uJ_0._ac2H6kMdrgPhXXxabsikjji4SiT;
		}

		internal int _tPtCAiPkRY7mgSEJfa6ZP2zkHiV(_ujAkjlfN5TywwbLAUDzPvtab6uJ _ujAkjlfN5TywwbLAUDzPvtab6uJ_0)
		{
			return _ujAkjlfN5TywwbLAUDzPvtab6uJ_0._VNgmwYSLsJyyiR6cPQ35UHJBR4d;
		}
	}

	[CompilerGenerated]
	private sealed class _09vlzDW4RoWakmLF5qRbNQ7dUgQ
	{
		public NPCLocation _p4GdxjVD0gRLct8Aao7RzPb4Qz7;

		internal bool _ZntubIQKmKWOEbZ0Dd8mmhnjCbD(_ujAkjlfN5TywwbLAUDzPvtab6uJ _ujAkjlfN5TywwbLAUDzPvtab6uJ_0)
		{
			if (_ujAkjlfN5TywwbLAUDzPvtab6uJ_0 is _3IHp43rpkJgOBcY9lrIrwMuwWve)
			{
				return ((_3IHp43rpkJgOBcY9lrIrwMuwWve)_ujAkjlfN5TywwbLAUDzPvtab6uJ_0)._4QLHHCk23T1BjK7acKxASbkCefG._9m9LEAgaqaeXydYhykSBmf9BrDG == _p4GdxjVD0gRLct8Aao7RzPb4Qz7;
			}
			return false;
		}
	}

	public const int _Nxgu5vjKsGPnADPhjM0zMEY4ufp = 0;

	public const int _ZVvgRhtcRZsRuCbbhFXMs4U4axO = 1;

	public const int _Is6iAUudNkZA2Dw85k5BnupVgvR = 2;

	public const int _BB31f3AxgliB7xzhqv52zjbfcZT = 3;

	protected bool _Bj3jScuqBJCFV58AWBDg8HofpqY;

	private _ujAkjlfN5TywwbLAUDzPvtab6uJ _QLfEh7VVWqcVZ2VleBjZBbD78ng;

	public _JbeCmOie0phb2cbgG6DdGZrbs3pB _ZzBuoSDMWwerejOO9Goyv2OCKgE { get; private set; }

	public List<_ujAkjlfN5TywwbLAUDzPvtab6uJ> _lstlI8qzZ4KErYKnufdOlj1xVZF { get; private set; }

	public string _hFeWJ5482CKD4l4529bYY1catC { get; private set; }

	public static bool _zI8afstSBU4SEMWSnQCa7srUFu { get; set; }

	protected BlendState _XvcwmP1Eb6HFUF5pkiUVgpqNbWE { get; set; }

	public Desktop _PnkAlVnMv0SZvRBFexqzE5DF9tp { get; set; }

	protected _7UlnfykmEmZDFt3BmCKZekI43Ih(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		_ZzBuoSDMWwerejOO9Goyv2OCKgE = _JbeCmOie0phb2cbgG6DdGZrbs3pB_0;
		_lstlI8qzZ4KErYKnufdOlj1xVZF = new List<_ujAkjlfN5TywwbLAUDzPvtab6uJ>();
		_XvcwmP1Eb6HFUF5pkiUVgpqNbWE = BlendState.NonPremultiplied;
		_PnkAlVnMv0SZvRBFexqzE5DF9tp = new Desktop
		{
			Skin = Gui.GenerateStandardSkin(),
			Size = new Squid.Point(1920, 1080)
		};
		_PnkAlVnMv0SZvRBFexqzE5DF9tp._EMnZAXxoqoahiGOiNjffRycLtDE("Assets/GUI/Squid/DefaultSkin", "Assets/GUI/Squid/DefaultSkin - Blue");
	}

	public virtual void _4hlxzMzKSbVTbZUrEsP3dfw4x0h()
	{
	}

	public virtual void _tO46aYSBLFIuhFNlhbrAeWbFDSf()
	{
	}

	public _ujAkjlfN5TywwbLAUDzPvtab6uJ _0c5TjZklJbu1wzYG2FIcvf3SIdh(string string_0)
	{
		return _lstlI8qzZ4KErYKnufdOlj1xVZF.FirstOrDefault((_ujAkjlfN5TywwbLAUDzPvtab6uJ _ujAkjlfN5TywwbLAUDzPvtab6uJ_0) => _ujAkjlfN5TywwbLAUDzPvtab6uJ_0._RB8fRXeQvK5vs7JEA0XfVCEpg1i == string_0);
	}

	public _uqydQVaCmCvK7zzWs5W4gZFpKBu _0O8D0mBgmrh0sLOGcLVvGNOHKLCA(string string_0, string string_1, int int_0, int int_1)
	{
		_uqydQVaCmCvK7zzWs5W4gZFpKBu gparam_ = _Iz47swAAB7d2iX6PQ1xTIJIv8MJ(string_0, string_1, int_0, int_1);
		return _7oYtfGpL7UyAQrZxew7Ahbvj6Sv(gparam_, 0);
	}

	public _kxm3yIqio0baXT5t5vOHBAEdviB _qCH6LFVbWcTfZTRElH4N91FiGeM(string string_0, int int_0, int int_1, int int_2, params string[] string_1)
	{
		_kxm3yIqio0baXT5t5vOHBAEdviB gparam_ = _sjmRQFeAlNizCJ4EXsNrpUTpDYb(string_0, int_0, int_1, int_2, string_1);
		return _7oYtfGpL7UyAQrZxew7Ahbvj6Sv(gparam_, 0);
	}

	public _C9DhEciuJHkReX4htI9sP6cbqzF _t1wBwPCrsAvA30GB26t9oLVcGfU(string string_0, string string_1, int int_0, int int_1, float float_0, int int_2, int int_3)
	{
		_C9DhEciuJHkReX4htI9sP6cbqzF gparam_ = _XT2tGTaFVsx2TLRQk2fgvrCwVmD(string_0, string_1, int_0, int_1, float_0, int_2, int_3);
		return _7oYtfGpL7UyAQrZxew7Ahbvj6Sv(gparam_, 0);
	}

	public _hxdR2gDHAgUMo1HqEU81OpKiFNA _0smWNvs61rH3hoJEMYp9eRPrLge(string string_0, string string_1, int int_0, int int_1, int int_2, int int_3 = 0, int int_4 = 0)
	{
		_hxdR2gDHAgUMo1HqEU81OpKiFNA gparam_ = _34JCT7KI9dRYuGwbjkRh9Tf5wIo(string_0, string_1, int_0, int_1, int_2, int_3, int_4);
		return _7oYtfGpL7UyAQrZxew7Ahbvj6Sv(gparam_, 0);
	}

	public _x1wxbalqqw8qtEqHC1UaGdv59Od _2VwdavpaoNVxohFKsz1eYBmnxyh(string string_0, string string_1, int int_0, int int_1, string string_2, int int_2, int int_3, string string_3)
	{
		_x1wxbalqqw8qtEqHC1UaGdv59Od gparam_ = _0YBRI5yp8d5OIyshYQBPSntvASC(string_0, string_1, int_0, int_1, string_2, int_2, int_3, string_3);
		return _7oYtfGpL7UyAQrZxew7Ahbvj6Sv(gparam_, 0);
	}

	public _z20t8IpBINiJtljSeTIkNoKUOkx _2CHUZ5vSi5NbJYJ4gGtr3C2VVEo(string string_0, string string_1, int int_0, int int_1, Action action_0)
	{
		_z20t8IpBINiJtljSeTIkNoKUOkx gparam_ = _E3OBnr7BNSwUmw0PtFmo2Fu98uN(string_0, string_1, int_0, int_1, action_0);
		return _7oYtfGpL7UyAQrZxew7Ahbvj6Sv(gparam_, 0);
	}

	public _rmc1e7Ng50C4uLmgllAoRtxaZiB _IsVv8GGyawVeoK7wFAd8Xv3wpvh(string string_0, int int_0, int int_1, Action action_0, int int_2, params string[] string_1)
	{
		_rmc1e7Ng50C4uLmgllAoRtxaZiB gparam_ = _ArxmV2ruCtBF4A39Rb8lFl5rBTk(string_0, int_0, int_1, action_0, int_2, string_1);
		return _7oYtfGpL7UyAQrZxew7Ahbvj6Sv(gparam_, 0);
	}

	public _uqydQVaCmCvK7zzWs5W4gZFpKBu _NC5VT77x8y2iH2pW56TBN1eyomA(string string_0, string string_1, int int_0, int int_1)
	{
		_uqydQVaCmCvK7zzWs5W4gZFpKBu gparam_ = _Iz47swAAB7d2iX6PQ1xTIJIv8MJ(string_0, string_1, int_0, int_1);
		return _7oYtfGpL7UyAQrZxew7Ahbvj6Sv(gparam_, 2);
	}

	public _kxm3yIqio0baXT5t5vOHBAEdviB _gqeDf50vdgfHqlAbH8UK4sXgtYAA(string string_0, int int_0, int int_1, int int_2, params string[] string_1)
	{
		_kxm3yIqio0baXT5t5vOHBAEdviB gparam_ = _sjmRQFeAlNizCJ4EXsNrpUTpDYb(string_0, int_0, int_1, int_2, string_1);
		return _7oYtfGpL7UyAQrZxew7Ahbvj6Sv(gparam_, 2);
	}

	public _C9DhEciuJHkReX4htI9sP6cbqzF _Nxd7FDzaWv8kfxGFKYtsDNy4edK(string string_0, string string_1, int int_0, int int_1, float float_0, int int_2, int int_3)
	{
		_C9DhEciuJHkReX4htI9sP6cbqzF gparam_ = _XT2tGTaFVsx2TLRQk2fgvrCwVmD(string_0, string_1, int_0, int_1, float_0, int_2, int_3);
		return _7oYtfGpL7UyAQrZxew7Ahbvj6Sv(gparam_, 2);
	}

	public _hxdR2gDHAgUMo1HqEU81OpKiFNA _Gwla9fGwcaH1uD03fvVNW68BhdH(string string_0, string string_1, int int_0, int int_1, int int_2, int int_3 = 0, int int_4 = 0)
	{
		_hxdR2gDHAgUMo1HqEU81OpKiFNA gparam_ = _34JCT7KI9dRYuGwbjkRh9Tf5wIo(string_0, string_1, int_0, int_1, int_2, int_3, int_4);
		return _7oYtfGpL7UyAQrZxew7Ahbvj6Sv(gparam_, 2);
	}

	public _x1wxbalqqw8qtEqHC1UaGdv59Od _bGvn3fKBHsQZdGptAJZu4jD9mdM(string string_0, string string_1, int int_0, int int_1, string string_2, int int_2, int int_3, string string_3)
	{
		_x1wxbalqqw8qtEqHC1UaGdv59Od gparam_ = _0YBRI5yp8d5OIyshYQBPSntvASC(string_0, string_1, int_0, int_1, string_2, int_2, int_3, string_3);
		return _7oYtfGpL7UyAQrZxew7Ahbvj6Sv(gparam_, 2);
	}

	public _z20t8IpBINiJtljSeTIkNoKUOkx _tleK1cHYNfVmmn9fIXlb30CAcaQ(string string_0, string string_1, int int_0, int int_1, Action action_0)
	{
		_z20t8IpBINiJtljSeTIkNoKUOkx gparam_ = _E3OBnr7BNSwUmw0PtFmo2Fu98uN(string_0, string_1, int_0, int_1, action_0);
		return _7oYtfGpL7UyAQrZxew7Ahbvj6Sv(gparam_, 2);
	}

	public _rmc1e7Ng50C4uLmgllAoRtxaZiB _aPdLf35SURnpApgsyW7HCTRPamB(string string_0, int int_0, int int_1, Action action_0, int int_2, params string[] string_1)
	{
		_rmc1e7Ng50C4uLmgllAoRtxaZiB gparam_ = _ArxmV2ruCtBF4A39Rb8lFl5rBTk(string_0, int_0, int_1, action_0, int_2, string_1);
		return _7oYtfGpL7UyAQrZxew7Ahbvj6Sv(gparam_, 2);
	}

	protected _uqydQVaCmCvK7zzWs5W4gZFpKBu _Iz47swAAB7d2iX6PQ1xTIJIv8MJ(string string_0, string string_1, int int_0, int int_1)
	{
		Texture2D texture2D_ = _ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>(string_1);
		return new _uqydQVaCmCvK7zzWs5W4gZFpKBu(this, string_0, texture2D_)
		{
			_7Xn1C5tjYnmIif1iZKV8AWsEEbL = int_0,
			_bCjZ3VSXGKyhmykd2zCnQBiSpDf = int_1
		};
	}

	private _kxm3yIqio0baXT5t5vOHBAEdviB _sjmRQFeAlNizCJ4EXsNrpUTpDYb(string string_0, int int_0, int int_1, int int_2, params string[] string_1)
	{
		if (string_1.Length == 0)
		{
			throw new ArgumentException("Images cannot be empty");
		}
		List<Texture2D> list = new List<Texture2D>(string_1.Length);
		foreach (string assetName in string_1)
		{
			list.Add(_ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>(assetName));
		}
		return new _kxm3yIqio0baXT5t5vOHBAEdviB(this, string_0, int_2, list)
		{
			_7Xn1C5tjYnmIif1iZKV8AWsEEbL = int_0,
			_bCjZ3VSXGKyhmykd2zCnQBiSpDf = int_1
		};
	}

	private _C9DhEciuJHkReX4htI9sP6cbqzF _XT2tGTaFVsx2TLRQk2fgvrCwVmD(string string_0, string string_1, int int_0, int int_1, float float_0, int int_2, int int_3)
	{
		Texture2D texture2D_ = _ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>(string_1);
		return new _C9DhEciuJHkReX4htI9sP6cbqzF(this, string_0, texture2D_, float_0, new Vector2(int_2, int_3))
		{
			_7Xn1C5tjYnmIif1iZKV8AWsEEbL = int_0,
			_bCjZ3VSXGKyhmykd2zCnQBiSpDf = int_1
		};
	}

	private _hxdR2gDHAgUMo1HqEU81OpKiFNA _34JCT7KI9dRYuGwbjkRh9Tf5wIo(string string_0, string string_1, int int_0, int int_1, int int_2, int int_3, int int_4)
	{
		Texture2D texture2D_ = _ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>(string_1);
		return new _hxdR2gDHAgUMo1HqEU81OpKiFNA(this, string_0, texture2D_, int_2, int_3, int_4)
		{
			_7Xn1C5tjYnmIif1iZKV8AWsEEbL = int_0,
			_bCjZ3VSXGKyhmykd2zCnQBiSpDf = int_1
		};
	}

	private _x1wxbalqqw8qtEqHC1UaGdv59Od _0YBRI5yp8d5OIyshYQBPSntvASC(string string_0, string string_1, int int_0, int int_1, string string_2, int int_2, int int_3, string string_3)
	{
		Texture2D texture2D_ = _ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>(string_1);
		Texture2D texture2D_2 = null;
		if (!string.IsNullOrEmpty(string_2))
		{
			texture2D_2 = _ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>(string_2);
		}
		return new _x1wxbalqqw8qtEqHC1UaGdv59Od(this, string_0, texture2D_, texture2D_2, string_3)
		{
			_7Xn1C5tjYnmIif1iZKV8AWsEEbL = int_0,
			_bCjZ3VSXGKyhmykd2zCnQBiSpDf = int_1,
			_KXMeX4w4QTfWkEcbYwnFrgl6iQA = int_2,
			_EKoZoehhAgIrqCfgZh148rtsqm = int_3
		};
	}

	private _z20t8IpBINiJtljSeTIkNoKUOkx _E3OBnr7BNSwUmw0PtFmo2Fu98uN(string string_0, string string_1, int int_0, int int_1, Action action_0)
	{
		Texture2D texture2D_ = _ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>(string_1);
		return new _z20t8IpBINiJtljSeTIkNoKUOkx(this, string_0, texture2D_, action_0)
		{
			_7Xn1C5tjYnmIif1iZKV8AWsEEbL = int_0,
			_bCjZ3VSXGKyhmykd2zCnQBiSpDf = int_1
		};
	}

	private _rmc1e7Ng50C4uLmgllAoRtxaZiB _ArxmV2ruCtBF4A39Rb8lFl5rBTk(string string_0, int int_0, int int_1, Action action_0, int int_2, params string[] string_1)
	{
		if (string_1.Length == 0)
		{
			throw new ArgumentException("Images cannot be empty");
		}
		List<Texture2D> list = new List<Texture2D>(string_1.Length);
		foreach (string assetName in string_1)
		{
			list.Add(_ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>(assetName));
		}
		return new _rmc1e7Ng50C4uLmgllAoRtxaZiB(this, string_0, action_0, int_2, list)
		{
			_7Xn1C5tjYnmIif1iZKV8AWsEEbL = int_0,
			_bCjZ3VSXGKyhmykd2zCnQBiSpDf = int_1
		};
	}

	public virtual void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		if (_Bj3jScuqBJCFV58AWBDg8HofpqY)
		{
			_lstlI8qzZ4KErYKnufdOlj1xVZF = (from _ujAkjlfN5TywwbLAUDzPvtab6uJ_0 in _lstlI8qzZ4KErYKnufdOlj1xVZF
				orderby _ujAkjlfN5TywwbLAUDzPvtab6uJ_0._ac2H6kMdrgPhXXxabsikjji4SiT, _ujAkjlfN5TywwbLAUDzPvtab6uJ_0._VNgmwYSLsJyyiR6cPQ35UHJBR4d
				select _ujAkjlfN5TywwbLAUDzPvtab6uJ_0).ToList();
			_Bj3jScuqBJCFV58AWBDg8HofpqY = false;
		}
		_kmVTSqclXrApKmHKAamak6kRUjl(gameTime_0, _lstlI8qzZ4KErYKnufdOlj1xVZF);
		if (_ZzBuoSDMWwerejOO9Goyv2OCKgE._5zNdOw7qHmuCAPJFMr3SsZdBlCr != null)
		{
			return;
		}
		if (!_zI8afstSBU4SEMWSnQCa7srUFu)
		{
			bool bool_;
			if ((bool_ = _ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(_PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton)) && _QLfEh7VVWqcVZ2VleBjZBbD78ng != null)
			{
				_QLfEh7VVWqcVZ2VleBjZBbD78ng._dGJ5R083rg1lKbVYP4W1TUEBqoh();
				_QLfEh7VVWqcVZ2VleBjZBbD78ng = null;
			}
			Microsoft.Xna.Framework.Point point_ = _ZzBuoSDMWwerejOO9Goyv2OCKgE._vsceSzSIjBy2nZrCxAzKZbUiwLq._e6KgAy4CTN1JFYwA88grvAEmDxX(_ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._U7CeYBJ1v1SoUxpX8emsQ9mWl5b);
			_MVL2E4AzcbNhDrRfPFXBDnmcJ4c(point_, bool_, _lstlI8qzZ4KErYKnufdOlj1xVZF);
		}
		_PnkAlVnMv0SZvRBFexqzE5DF9tp.Update();
	}

	private void _kmVTSqclXrApKmHKAamak6kRUjl(GameTime gameTime_0, IEnumerable<_ujAkjlfN5TywwbLAUDzPvtab6uJ> ienumerable_0)
	{
		foreach (_ujAkjlfN5TywwbLAUDzPvtab6uJ item in ienumerable_0)
		{
			if (item._3ZeCDXqcWHY4XJDBGyav3UzxYaHA)
			{
				item._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
			}
		}
	}

	private void _MVL2E4AzcbNhDrRfPFXBDnmcJ4c(Microsoft.Xna.Framework.Point point_0, bool bool_0, List<_ujAkjlfN5TywwbLAUDzPvtab6uJ> list_0)
	{
		_ujAkjlfN5TywwbLAUDzPvtab6uJ ujAkjlfN5TywwbLAUDzPvtab6uJ = null;
		Microsoft.Xna.Framework.Rectangle rectangle = default(Microsoft.Xna.Framework.Rectangle);
		for (int num = list_0.Count - 1; num >= 0; num--)
		{
			_ujAkjlfN5TywwbLAUDzPvtab6uJ ujAkjlfN5TywwbLAUDzPvtab6uJ2 = list_0[num];
			if ((ujAkjlfN5TywwbLAUDzPvtab6uJ2 is _x1wxbalqqw8qtEqHC1UaGdv59Od || ujAkjlfN5TywwbLAUDzPvtab6uJ2 is _z20t8IpBINiJtljSeTIkNoKUOkx || ujAkjlfN5TywwbLAUDzPvtab6uJ2 is _rmc1e7Ng50C4uLmgllAoRtxaZiB || ujAkjlfN5TywwbLAUDzPvtab6uJ2 is _3IHp43rpkJgOBcY9lrIrwMuwWve) && ujAkjlfN5TywwbLAUDzPvtab6uJ2._3ZeCDXqcWHY4XJDBGyav3UzxYaHA)
			{
				if (!(ujAkjlfN5TywwbLAUDzPvtab6uJ2 is _3IHp43rpkJgOBcY9lrIrwMuwWve))
				{
					ujAkjlfN5TywwbLAUDzPvtab6uJ2._oc2Bt2sYu2e2W8gFbd4cz1hv2Fq();
					if (ujAkjlfN5TywwbLAUDzPvtab6uJ == null)
					{
						rectangle.X = (int)ujAkjlfN5TywwbLAUDzPvtab6uJ2._7Xn1C5tjYnmIif1iZKV8AWsEEbL;
						rectangle.Y = (int)ujAkjlfN5TywwbLAUDzPvtab6uJ2._bCjZ3VSXGKyhmykd2zCnQBiSpDf;
						rectangle.Width = ujAkjlfN5TywwbLAUDzPvtab6uJ2._je8rVfyg4zywmqSi4Ozx1z7wJ4b;
						rectangle.Height = ujAkjlfN5TywwbLAUDzPvtab6uJ2._WJfGWBzn4wgdGBnMWRH2pcJ3AqH;
						if (rectangle.Contains(point_0))
						{
							ujAkjlfN5TywwbLAUDzPvtab6uJ2._i3qb0SiBqvdxqp5NXIRGrNGErxh();
							ujAkjlfN5TywwbLAUDzPvtab6uJ = ujAkjlfN5TywwbLAUDzPvtab6uJ2;
						}
					}
				}
				else
				{
					_QGGOTxZ8aNWGh0hc26wcmx8wmwT _4QLHHCk23T1BjK7acKxASbkCefG = ((_3IHp43rpkJgOBcY9lrIrwMuwWve)ujAkjlfN5TywwbLAUDzPvtab6uJ2)._4QLHHCk23T1BjK7acKxASbkCefG;
					_4QLHHCk23T1BjK7acKxASbkCefG._IvIFs0Tl6RHdTn3daJXsNCXCNyO = false;
					if (ujAkjlfN5TywwbLAUDzPvtab6uJ == null)
					{
						rectangle.X = (int)_4QLHHCk23T1BjK7acKxASbkCefG._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL;
						rectangle.Y = (int)_4QLHHCk23T1BjK7acKxASbkCefG._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf;
						rectangle.Width = (int)((float)_4QLHHCk23T1BjK7acKxASbkCefG._je8rVfyg4zywmqSi4Ozx1z7wJ4b * _4QLHHCk23T1BjK7acKxASbkCefG._fO7gSlrDDNMoHR4FO5QXAq8fUyA);
						rectangle.Height = (int)((float)_4QLHHCk23T1BjK7acKxASbkCefG._WJfGWBzn4wgdGBnMWRH2pcJ3AqH * _4QLHHCk23T1BjK7acKxASbkCefG._fO7gSlrDDNMoHR4FO5QXAq8fUyA);
						if (_4QLHHCk23T1BjK7acKxASbkCefG is _tfDAeR6npiqJMLRSXPO1DxGA0TgA)
						{
							rectangle.X -= rectangle.Width / 2;
							rectangle.Y -= rectangle.Height;
						}
						if (_4QLHHCk23T1BjK7acKxASbkCefG._ZVpZ5Oing5kbbVhbmbOHyrofGH7 != null && rectangle.Contains(point_0))
						{
							_4QLHHCk23T1BjK7acKxASbkCefG._IvIFs0Tl6RHdTn3daJXsNCXCNyO = true;
							ujAkjlfN5TywwbLAUDzPvtab6uJ = ujAkjlfN5TywwbLAUDzPvtab6uJ2;
						}
					}
				}
			}
		}
		if (!(ujAkjlfN5TywwbLAUDzPvtab6uJ != null && bool_0))
		{
			return;
		}
		if (!(ujAkjlfN5TywwbLAUDzPvtab6uJ is _3IHp43rpkJgOBcY9lrIrwMuwWve))
		{
			if (ujAkjlfN5TywwbLAUDzPvtab6uJ._Hym13mjJB64DQkbAkEMmEae8pQdA())
			{
				_QLfEh7VVWqcVZ2VleBjZBbD78ng = ujAkjlfN5TywwbLAUDzPvtab6uJ;
			}
			return;
		}
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT _4QLHHCk23T1BjK7acKxASbkCefG2 = ((_3IHp43rpkJgOBcY9lrIrwMuwWve)ujAkjlfN5TywwbLAUDzPvtab6uJ)._4QLHHCk23T1BjK7acKxASbkCefG;
		if (_4QLHHCk23T1BjK7acKxASbkCefG2._ZVpZ5Oing5kbbVhbmbOHyrofGH7 != null)
		{
			_4QLHHCk23T1BjK7acKxASbkCefG2._ZVpZ5Oing5kbbVhbmbOHyrofGH7();
			_QLfEh7VVWqcVZ2VleBjZBbD78ng = ujAkjlfN5TywwbLAUDzPvtab6uJ;
		}
	}

	public virtual void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0, Matrix matrix_0)
	{
		_rNZd4y7Vjg7H4PTzsnTaLEi5v8b(spriteBatch_0, skeletonMeshRenderer_0, matrix_0, _lstlI8qzZ4KErYKnufdOlj1xVZF);
	}

	public virtual void _Z70nK2EA1n5FNJxjWP0TzHQ0Lzb(SpriteBatch spriteBatch_0)
	{
		_PnkAlVnMv0SZvRBFexqzE5DF9tp.Draw();
	}

	private void _rNZd4y7Vjg7H4PTzsnTaLEi5v8b(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0, Matrix matrix_0, IEnumerable<_ujAkjlfN5TywwbLAUDzPvtab6uJ> ienumerable_0)
	{
		bool flag = false;
		foreach (_ujAkjlfN5TywwbLAUDzPvtab6uJ item in ienumerable_0)
		{
			if (!item._Fxy2SlgceW90FloFw6a1AEJODYA)
			{
				continue;
			}
			if (!(item is _3IHp43rpkJgOBcY9lrIrwMuwWve))
			{
				if (!(item is _WBXNT6eIVGk6ZKExRBJ6JxXE6zb))
				{
					if (item is _fAUddQEKfZyemRb327NhM3GGlmzA)
					{
						if (flag)
						{
							spriteBatch_0.End();
							flag = false;
						}
						((_fAUddQEKfZyemRb327NhM3GGlmzA)item)._3TrGrUra7cqeIXkbZOrfaoQaD5F = matrix_0;
						item._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0);
					}
					else
					{
						if (!flag)
						{
							spriteBatch_0._g9Sx54kMPiHz5jrqWh4Kb1pTijH(SpriteSortMode.Deferred, nullable_0: matrix_0, blendState_0: _XvcwmP1Eb6HFUF5pkiUVgpqNbWE);
							flag = true;
						}
						item._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0);
					}
					continue;
				}
				if (flag)
				{
					spriteBatch_0.End();
					flag = false;
				}
				_WBXNT6eIVGk6ZKExRBJ6JxXE6zb wBXNT6eIVGk6ZKExRBJ6JxXE6zb = (_WBXNT6eIVGk6ZKExRBJ6JxXE6zb)item;
				if (!wBXNT6eIVGk6ZKExRBJ6JxXE6zb._zkHMlDFkja4TqmjdlHuZRCj8FCB)
				{
					wBXNT6eIVGk6ZKExRBJ6JxXE6zb._WBXNT6eIVGk6ZKExRBJ6JxXE6zb_002E_GDeKFFD8Rxnpsjzy36lUBxAEopc += matrix_0.M41;
					wBXNT6eIVGk6ZKExRBJ6JxXE6zb._WBXNT6eIVGk6ZKExRBJ6JxXE6zb_002E_JpSvHH1W0gFCpaNEH5zB1qsDJXY += matrix_0.M42;
				}
				wBXNT6eIVGk6ZKExRBJ6JxXE6zb._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0, skeletonMeshRenderer_0);
				if (!wBXNT6eIVGk6ZKExRBJ6JxXE6zb._zkHMlDFkja4TqmjdlHuZRCj8FCB)
				{
					wBXNT6eIVGk6ZKExRBJ6JxXE6zb._WBXNT6eIVGk6ZKExRBJ6JxXE6zb_002E_GDeKFFD8Rxnpsjzy36lUBxAEopc -= matrix_0.M41;
					wBXNT6eIVGk6ZKExRBJ6JxXE6zb._WBXNT6eIVGk6ZKExRBJ6JxXE6zb_002E_JpSvHH1W0gFCpaNEH5zB1qsDJXY -= matrix_0.M42;
				}
			}
			else
			{
				if (flag)
				{
					spriteBatch_0.End();
					flag = false;
				}
				_nrDmURIbDeklrMRB6X5y3IwhP1Q(item as _3IHp43rpkJgOBcY9lrIrwMuwWve, spriteBatch_0, skeletonMeshRenderer_0, matrix_0);
			}
		}
		if (flag)
		{
			spriteBatch_0.End();
		}
	}

	private void _nrDmURIbDeklrMRB6X5y3IwhP1Q(_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve_0, SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0, Matrix matrix_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT _4QLHHCk23T1BjK7acKxASbkCefG = _3IHp43rpkJgOBcY9lrIrwMuwWve_0._4QLHHCk23T1BjK7acKxASbkCefG;
		if (_4QLHHCk23T1BjK7acKxASbkCefG is _tfDAeR6npiqJMLRSXPO1DxGA0TgA)
		{
			if (!_4QLHHCk23T1BjK7acKxASbkCefG._zkHMlDFkja4TqmjdlHuZRCj8FCB)
			{
				((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)_4QLHHCk23T1BjK7acKxASbkCefG)._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL += matrix_0.M41;
				((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)_4QLHHCk23T1BjK7acKxASbkCefG)._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf += matrix_0.M42;
			}
			((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)_4QLHHCk23T1BjK7acKxASbkCefG)._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0, skeletonMeshRenderer_0);
			if (!_4QLHHCk23T1BjK7acKxASbkCefG._zkHMlDFkja4TqmjdlHuZRCj8FCB)
			{
				((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)_4QLHHCk23T1BjK7acKxASbkCefG)._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL -= matrix_0.M41;
				((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)_4QLHHCk23T1BjK7acKxASbkCefG)._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf -= matrix_0.M42;
			}
		}
		else if (_4QLHHCk23T1BjK7acKxASbkCefG is _xZgbANe7gi6i2DAhBEkKpR1QFLe)
		{
			spriteBatch_0._g9Sx54kMPiHz5jrqWh4Kb1pTijH(SpriteSortMode.Immediate, BlendState.NonPremultiplied, null, null, null, null, (!_4QLHHCk23T1BjK7acKxASbkCefG._zkHMlDFkja4TqmjdlHuZRCj8FCB) ? matrix_0 : Matrix.Identity);
			((_xZgbANe7gi6i2DAhBEkKpR1QFLe)_4QLHHCk23T1BjK7acKxASbkCefG)._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0);
			spriteBatch_0.End();
		}
	}

	public virtual void _6hE3geqxrB1vCirtSWHxIJjlTQB(string string_0)
	{
		_hFeWJ5482CKD4l4529bYY1catC = string_0;
	}

	public _3IHp43rpkJgOBcY9lrIrwMuwWve _VvFE2zgy4FbDjvaEvb67tXJ7aRm(string string_0)
	{
		return _0c5TjZklJbu1wzYG2FIcvf3SIdh("NPCLayer_" + string_0) as _3IHp43rpkJgOBcY9lrIrwMuwWve;
	}

	public _3IHp43rpkJgOBcY9lrIrwMuwWve _VvFE2zgy4FbDjvaEvb67tXJ7aRm(NPCLocation npclocation_0)
	{
		return _lstlI8qzZ4KErYKnufdOlj1xVZF.FirstOrDefault((_ujAkjlfN5TywwbLAUDzPvtab6uJ _ujAkjlfN5TywwbLAUDzPvtab6uJ_0) => _ujAkjlfN5TywwbLAUDzPvtab6uJ_0 is _3IHp43rpkJgOBcY9lrIrwMuwWve && ((_3IHp43rpkJgOBcY9lrIrwMuwWve)_ujAkjlfN5TywwbLAUDzPvtab6uJ_0)._4QLHHCk23T1BjK7acKxASbkCefG._9m9LEAgaqaeXydYhykSBmf9BrDG == npclocation_0) as _3IHp43rpkJgOBcY9lrIrwMuwWve;
	}

	public _3IHp43rpkJgOBcY9lrIrwMuwWve _VvFE2zgy4FbDjvaEvb67tXJ7aRm<T>()
	{
		return _0c5TjZklJbu1wzYG2FIcvf3SIdh("NPCLayer_" + typeof(T).Name) as _3IHp43rpkJgOBcY9lrIrwMuwWve;
	}

	public _3IHp43rpkJgOBcY9lrIrwMuwWve _gWHVDvr9GDtRXP2zf2Md18MgZ4b(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, _a2qVgWDIm3fBp49WubttSTPsx8K _a2qVgWDIm3fBp49WubttSTPsx8K_0)
	{
		_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve2 = _VvFE2zgy4FbDjvaEvb67tXJ7aRm(_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0.GetType().Name) ?? new _3IHp43rpkJgOBcY9lrIrwMuwWve(this, _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, _a2qVgWDIm3fBp49WubttSTPsx8K_0);
		_3IHp43rpkJgOBcY9lrIrwMuwWve2._dPmC8tBC0iph2YBAFmztEsmwUdSA = _a2qVgWDIm3fBp49WubttSTPsx8K_0;
		_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(_3IHp43rpkJgOBcY9lrIrwMuwWve2, (_a2qVgWDIm3fBp49WubttSTPsx8K_0 == _a2qVgWDIm3fBp49WubttSTPsx8K.Background) ? 1 : 3);
		return _3IHp43rpkJgOBcY9lrIrwMuwWve2;
	}

	public T _7oYtfGpL7UyAQrZxew7Ahbvj6Sv<T>(T gparam_0, int int_0, int int_1 = 0) where T : _ujAkjlfN5TywwbLAUDzPvtab6uJ
	{
		gparam_0._ac2H6kMdrgPhXXxabsikjji4SiT = int_0;
		_lstlI8qzZ4KErYKnufdOlj1xVZF.Add(gparam_0);
		_Bj3jScuqBJCFV58AWBDg8HofpqY = true;
		return gparam_0;
	}

	public void _yMMFQ2n4dqXlB1AEzmdkoKkPkX5()
	{
		_Bj3jScuqBJCFV58AWBDg8HofpqY = true;
	}

	public virtual void _bHdVKtqP3Eb3DSJmuVTbkY8RtHP()
	{
	}
}
