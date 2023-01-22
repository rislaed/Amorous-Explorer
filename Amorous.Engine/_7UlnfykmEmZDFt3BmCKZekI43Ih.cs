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
			return _tG4UmqFtIzo0HrVclFcuXu2ibnh.smethod_0(_ujAkjlfN5TywwbLAUDzPvtab6uJ_0._RB8fRXeQvK5vs7JEA0XfVCEpg1i, _hzqOBkJhJBhsTRNARxHLctcvhN0);
		}

		static bool smethod_0(string string_0, string string_1)
		{
			return string_0 == string_1;
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
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		_ZzBuoSDMWwerejOO9Goyv2OCKgE = _JbeCmOie0phb2cbgG6DdGZrbs3pB_0;
		_lstlI8qzZ4KErYKnufdOlj1xVZF = new List<_ujAkjlfN5TywwbLAUDzPvtab6uJ>();
		_XvcwmP1Eb6HFUF5pkiUVgpqNbWE = BlendState.NonPremultiplied;
		Desktop obj = _7UlnfykmEmZDFt3BmCKZekI43Ih.smethod_0();
		_7UlnfykmEmZDFt3BmCKZekI43Ih.smethod_2(obj, _7UlnfykmEmZDFt3BmCKZekI43Ih.smethod_1());
		((Control)obj).set_Size(new Point(1920, 1080));
		_PnkAlVnMv0SZvRBFexqzE5DF9tp = obj;
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
		return _lstlI8qzZ4KErYKnufdOlj1xVZF.FirstOrDefault((_ujAkjlfN5TywwbLAUDzPvtab6uJ _ujAkjlfN5TywwbLAUDzPvtab6uJ_0) => _tG4UmqFtIzo0HrVclFcuXu2ibnh.smethod_0(_ujAkjlfN5TywwbLAUDzPvtab6uJ_0._RB8fRXeQvK5vs7JEA0XfVCEpg1i, string_0));
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
			goto IL_0008;
		}
		goto IL_00de;
		IL_00de:
		List<Texture2D> list = new List<Texture2D>(string_1.Length);
		int num = -1702316938;
		goto IL_00a7;
		IL_00a7:
		_kxm3yIqio0baXT5t5vOHBAEdviB result = default(_kxm3yIqio0baXT5t5vOHBAEdviB);
		string text = default(string);
		string[] array = default(string[]);
		int num3 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xBA266603u) % 9u)
			{
			case 8u:
				break;
			case 7u:
				result = new _kxm3yIqio0baXT5t5vOHBAEdviB(this, string_0, int_2, list)
				{
					_7Xn1C5tjYnmIif1iZKV8AWsEEbL = int_0,
					_bCjZ3VSXGKyhmykd2zCnQBiSpDf = int_1
				};
				num = (int)(num2 * 1802746310) ^ -815512192;
				continue;
			case 6u:
				text = array[num3];
				num = -1137715744;
				continue;
			case 5u:
				goto IL_0049;
			case 4u:
				list.Add(_ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>(text));
				num3++;
				num = ((int)num2 * -1942558999) ^ -1922021861;
				continue;
			case 2u:
				array = string_1;
				num3 = 0;
				num = ((int)num2 * -514382508) ^ -1716643100;
				continue;
			case 3u:
				goto IL_00de;
			case 1u:
				throw _7UlnfykmEmZDFt3BmCKZekI43Ih.smethod_3("Images cannot be empty");
			default:
				return result;
			}
			break;
			IL_0049:
			int num4;
			if (num3 >= array.Length)
			{
				num = -392967479;
				num4 = -392967479;
			}
			else
			{
				num = -2045799015;
				num4 = -2045799015;
			}
		}
		goto IL_0008;
		IL_0008:
		num = -1653137496;
		goto IL_00a7;
	}

	private _C9DhEciuJHkReX4htI9sP6cbqzF _XT2tGTaFVsx2TLRQk2fgvrCwVmD(string string_0, string string_1, int int_0, int int_1, float float_0, int int_2, int int_3)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		Texture2D texture2D_ = _ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>(string_1);
		return new _C9DhEciuJHkReX4htI9sP6cbqzF(this, string_0, texture2D_, float_0, new Vector2((float)int_2, (float)int_3))
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
		Texture2D texture2D_2 = default(Texture2D);
		_x1wxbalqqw8qtEqHC1UaGdv59Od result = default(_x1wxbalqqw8qtEqHC1UaGdv59Od);
		while (true)
		{
			int num = 590351566;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x10FFFDDCu) % 6u)
				{
				case 4u:
					texture2D_2 = null;
					num = (int)(num2 * 464929640) ^ -1722856346;
					continue;
				case 3u:
					texture2D_2 = _ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>(string_2);
					num = (int)((num2 * 2116224502) ^ 0x1E95AFB9);
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!_7UlnfykmEmZDFt3BmCKZekI43Ih.smethod_4(string_2))
					{
						num3 = 2112560901;
						num4 = 2112560901;
					}
					else
					{
						num3 = 96138335;
						num4 = 96138335;
					}
					num = num3 ^ (int)(num2 * 782360080);
					continue;
				}
				case 1u:
					result = new _x1wxbalqqw8qtEqHC1UaGdv59Od(this, string_0, texture2D_, texture2D_2, string_3)
					{
						_7Xn1C5tjYnmIif1iZKV8AWsEEbL = int_0,
						_bCjZ3VSXGKyhmykd2zCnQBiSpDf = int_1,
						_KXMeX4w4QTfWkEcbYwnFrgl6iQA = int_2,
						_EKoZoehhAgIrqCfgZh148rtsqm = int_3
					};
					num = 412162961;
					continue;
				case 0u:
					break;
				default:
					return result;
				}
				break;
			}
		}
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
			goto IL_00a3;
		}
		goto IL_00df;
		IL_00df:
		List<Texture2D> list = new List<Texture2D>(string_1.Length);
		string[] array = string_1;
		int num = 1012038496;
		goto IL_00a8;
		IL_00a8:
		_rmc1e7Ng50C4uLmgllAoRtxaZiB result = default(_rmc1e7Ng50C4uLmgllAoRtxaZiB);
		int num3 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x23203701u) % 9u)
			{
			case 8u:
				result = new _rmc1e7Ng50C4uLmgllAoRtxaZiB(this, string_0, action_0, int_2, list)
				{
					_7Xn1C5tjYnmIif1iZKV8AWsEEbL = int_0,
					_bCjZ3VSXGKyhmykd2zCnQBiSpDf = int_1
				};
				num = (int)(num2 * 48247228) ^ -1405201984;
				continue;
			case 7u:
				num3++;
				num = ((int)num2 * -1726310427) ^ 0x77A21B90;
				continue;
			case 6u:
				num3 = 0;
				num = (int)((num2 * 1880761637) ^ 0x417097EC);
				continue;
			case 5u:
			{
				string text = array[num3];
				list.Add(_ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>(text));
				num = 1287367428;
				continue;
			}
			case 4u:
				break;
			case 0u:
				goto end_IL_00a8;
			case 3u:
				goto IL_00df;
			case 2u:
				throw _7UlnfykmEmZDFt3BmCKZekI43Ih.smethod_3("Images cannot be empty");
			default:
				return result;
			}
			int num4;
			if (num3 >= array.Length)
			{
				num = 1968706868;
				num4 = 1968706868;
			}
			else
			{
				num = 39494814;
				num4 = 39494814;
			}
			continue;
			end_IL_00a8:
			break;
		}
		goto IL_00a3;
		IL_00a3:
		num = 1415706299;
		goto IL_00a8;
	}

	public virtual void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		if (_Bj3jScuqBJCFV58AWBDg8HofpqY)
		{
			goto IL_00a5;
		}
		goto IL_01f6;
		IL_01f6:
		_kmVTSqclXrApKmHKAamak6kRUjl(gameTime_0, _lstlI8qzZ4KErYKnufdOlj1xVZF);
		int num = -1258301376;
		goto IL_01b0;
		IL_01b0:
		Point point_ = default(Point);
		bool flag = default(bool);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xD02FFA8Eu) % 13u)
			{
			case 12u:
				point_ = _ZzBuoSDMWwerejOO9Goyv2OCKgE._vsceSzSIjBy2nZrCxAzKZbUiwLq._e6KgAy4CTN1JFYwA88grvAEmDxX(_ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._U7CeYBJ1v1SoUxpX8emsQ9mWl5b);
				num = -1117940733;
				continue;
			case 11u:
				_lstlI8qzZ4KErYKnufdOlj1xVZF = (from _ujAkjlfN5TywwbLAUDzPvtab6uJ_0 in _lstlI8qzZ4KErYKnufdOlj1xVZF
					orderby _ujAkjlfN5TywwbLAUDzPvtab6uJ_0._ac2H6kMdrgPhXXxabsikjji4SiT, _ujAkjlfN5TywwbLAUDzPvtab6uJ_0._VNgmwYSLsJyyiR6cPQ35UHJBR4d
					select _ujAkjlfN5TywwbLAUDzPvtab6uJ_0).ToList();
				_Bj3jScuqBJCFV58AWBDg8HofpqY = false;
				num = -256400369;
				continue;
			case 10u:
				break;
			case 9u:
				_MVL2E4AzcbNhDrRfPFXBDnmcJ4c(point_, flag, _lstlI8qzZ4KErYKnufdOlj1xVZF);
				num = (int)((num2 * 1883866619) ^ 0x2F0FE3BC);
				continue;
			case 5u:
			{
				int num5;
				int num6;
				if (_QLfEh7VVWqcVZ2VleBjZBbD78ng != null)
				{
					num5 = 582815255;
					num6 = 582815255;
				}
				else
				{
					num5 = 425441279;
					num6 = 425441279;
				}
				num = num5 ^ (int)(num2 * 529841905);
				continue;
			}
			case 4u:
				_QLfEh7VVWqcVZ2VleBjZBbD78ng._dGJ5R083rg1lKbVYP4W1TUEBqoh();
				_QLfEh7VVWqcVZ2VleBjZBbD78ng = null;
				num = ((int)num2 * -967112836) ^ 0x68D8C78B;
				continue;
			case 3u:
				goto IL_011f;
			case 2u:
				flag = _ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(_PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton);
				num = ((int)num2 * -244192863) ^ -1960764665;
				continue;
			case 1u:
			{
				int num7;
				int num8;
				if (_ZzBuoSDMWwerejOO9Goyv2OCKgE._5zNdOw7qHmuCAPJFMr3SsZdBlCr != null)
				{
					num7 = -1804016536;
					num8 = -1804016536;
				}
				else
				{
					num7 = -149087971;
					num8 = -149087971;
				}
				num = num7 ^ (int)(num2 * 703187863);
				continue;
			}
			case 0u:
			{
				int num3;
				int num4;
				if (!flag)
				{
					num3 = -1986175055;
					num4 = -1986175055;
				}
				else
				{
					num3 = -388071872;
					num4 = -388071872;
				}
				num = num3 ^ ((int)num2 * -1576653878);
				continue;
			}
			case 7u:
				goto IL_01f6;
			default:
				_7UlnfykmEmZDFt3BmCKZekI43Ih.smethod_5(_PnkAlVnMv0SZvRBFexqzE5DF9tp);
				return;
			case 8u:
				return;
			}
			break;
			IL_011f:
			int num9;
			if (_zI8afstSBU4SEMWSnQCa7srUFu)
			{
				num = -673626493;
				num9 = -673626493;
			}
			else
			{
				num = -386528512;
				num9 = -386528512;
			}
		}
		goto IL_00a5;
		IL_00a5:
		num = -1662000447;
		goto IL_01b0;
	}

	private void _kmVTSqclXrApKmHKAamak6kRUjl(GameTime gameTime_0, IEnumerable<_ujAkjlfN5TywwbLAUDzPvtab6uJ> ienumerable_0)
	{
		IEnumerator<_ujAkjlfN5TywwbLAUDzPvtab6uJ> enumerator = ienumerable_0.GetEnumerator();
		try
		{
			_ujAkjlfN5TywwbLAUDzPvtab6uJ current = default(_ujAkjlfN5TywwbLAUDzPvtab6uJ);
			while (true)
			{
				int num;
				int num2;
				if (_7UlnfykmEmZDFt3BmCKZekI43Ih.smethod_6((IEnumerator)enumerator))
				{
					num = -405061861;
					num2 = -405061861;
				}
				else
				{
					num = -2051479361;
					num2 = -2051479361;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xA8B20A51u) % 6u)
					{
					case 5u:
						num = -405061861;
						continue;
					case 3u:
						current._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
						num = ((int)num3 * -1160911872) ^ 0x4EEDC7C1;
						continue;
					case 2u:
						current = enumerator.Current;
						num = -851520648;
						continue;
					case 1u:
					{
						int num4;
						int num5;
						if (current._3ZeCDXqcWHY4XJDBGyav3UzxYaHA)
						{
							num4 = 332478143;
							num5 = 332478143;
						}
						else
						{
							num4 = 576055088;
							num5 = 576055088;
						}
						num = num4 ^ ((int)num3 * -1417341303);
						continue;
					}
					default:
						return;
					case 4u:
						break;
					case 0u:
						return;
					}
					break;
				}
			}
		}
		finally
		{
			if (enumerator != null)
			{
				while (true)
				{
					IL_00e8:
					int num6 = -713048918;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)num6 ^ 0xA8B20A51u) % 3u)
						{
						case 1u:
							goto IL_00b8;
						default:
							goto end_IL_00cb;
						case 0u:
							break;
						case 2u:
							goto end_IL_00cb;
						}
						goto IL_00e8;
						IL_00b8:
						_7UlnfykmEmZDFt3BmCKZekI43Ih.smethod_7((IDisposable)enumerator);
						num6 = (int)((num3 * 436808976) ^ 0x5CA7DF34);
						continue;
						end_IL_00cb:
						break;
					}
					break;
				}
			}
		}
	}

	private void _MVL2E4AzcbNhDrRfPFXBDnmcJ4c(Point point_0, bool bool_0, List<_ujAkjlfN5TywwbLAUDzPvtab6uJ> list_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		_ujAkjlfN5TywwbLAUDzPvtab6uJ ujAkjlfN5TywwbLAUDzPvtab6uJ = null;
		Rectangle val = default(Rectangle);
		int num3 = default(int);
		_ujAkjlfN5TywwbLAUDzPvtab6uJ ujAkjlfN5TywwbLAUDzPvtab6uJ2 = default(_ujAkjlfN5TywwbLAUDzPvtab6uJ);
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT _4QLHHCk23T1BjK7acKxASbkCefG = default(_QGGOTxZ8aNWGh0hc26wcmx8wmwT);
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT _4QLHHCk23T1BjK7acKxASbkCefG2 = default(_QGGOTxZ8aNWGh0hc26wcmx8wmwT);
		while (true)
		{
			int num = 256987099;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x48F28017u) % 41u)
				{
				case 40u:
					val.X -= val.Width / 2;
					num = (int)((num2 * 202566272) ^ 0x53E42655);
					continue;
				case 39u:
				{
					int num31;
					if (ujAkjlfN5TywwbLAUDzPvtab6uJ._Hym13mjJB64DQkbAkEMmEae8pQdA())
					{
						num = 1252999627;
						num31 = 1252999627;
					}
					else
					{
						num = 591729323;
						num31 = 591729323;
					}
					continue;
				}
				case 38u:
				{
					int num17;
					int num18;
					if (ujAkjlfN5TywwbLAUDzPvtab6uJ != null)
					{
						num17 = 856384199;
						num18 = 856384199;
					}
					else
					{
						num17 = 135580020;
						num18 = 135580020;
					}
					num = num17 ^ ((int)num2 * -1566432722);
					continue;
				}
				case 37u:
				{
					int num28;
					int num29;
					if (!(ujAkjlfN5TywwbLAUDzPvtab6uJ is _3IHp43rpkJgOBcY9lrIrwMuwWve))
					{
						num28 = 1212130669;
						num29 = 1212130669;
					}
					else
					{
						num28 = 57438024;
						num29 = 57438024;
					}
					num = num28 ^ ((int)num2 * -583110051);
					continue;
				}
				case 36u:
				{
					int num8;
					if (num3 < 0)
					{
						num = 544790222;
						num8 = 544790222;
					}
					else
					{
						num = 1168238295;
						num8 = 1168238295;
					}
					continue;
				}
				case 35u:
				{
					int num32;
					int num33;
					if (!(ujAkjlfN5TywwbLAUDzPvtab6uJ2 is _3IHp43rpkJgOBcY9lrIrwMuwWve))
					{
						num32 = -1583840574;
						num33 = -1583840574;
					}
					else
					{
						num32 = -315301;
						num33 = -315301;
					}
					num = num32 ^ (int)(num2 * 1172995796);
					continue;
				}
				case 34u:
					val.X = (int)_4QLHHCk23T1BjK7acKxASbkCefG._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL;
					num = (int)((num2 * 1082031180) ^ 0x5016B127);
					continue;
				case 33u:
					val.Width = ujAkjlfN5TywwbLAUDzPvtab6uJ2._je8rVfyg4zywmqSi4Ozx1z7wJ4b;
					num = (int)((num2 * 228435059) ^ 0x3AC56E8);
					continue;
				case 32u:
					val.X = (int)ujAkjlfN5TywwbLAUDzPvtab6uJ2._7Xn1C5tjYnmIif1iZKV8AWsEEbL;
					num = ((int)num2 * -2067452186) ^ 0x73893CAC;
					continue;
				case 31u:
				{
					int num6;
					int num7;
					if (!(_4QLHHCk23T1BjK7acKxASbkCefG is _tfDAeR6npiqJMLRSXPO1DxGA0TgA))
					{
						num6 = -1605170946;
						num7 = -1605170946;
					}
					else
					{
						num6 = -640167707;
						num7 = -640167707;
					}
					num = num6 ^ (int)(num2 * 461813786);
					continue;
				}
				case 30u:
					num3 = list_0.Count - 1;
					num = ((int)num2 * -908930805) ^ 0x3115BC0D;
					continue;
				case 29u:
				{
					int num26;
					int num27;
					if (ujAkjlfN5TywwbLAUDzPvtab6uJ2 is _z20t8IpBINiJtljSeTIkNoKUOkx)
					{
						num26 = -576328593;
						num27 = -576328593;
					}
					else
					{
						num26 = -1150214212;
						num27 = -1150214212;
					}
					num = num26 ^ (int)(num2 * 734643464);
					continue;
				}
				case 28u:
				{
					int num23;
					if (_4QLHHCk23T1BjK7acKxASbkCefG._ZVpZ5Oing5kbbVhbmbOHyrofGH7 == null)
					{
						num = 1682608545;
						num23 = 1682608545;
					}
					else
					{
						num = 1535667625;
						num23 = 1535667625;
					}
					continue;
				}
				case 27u:
					val.Width = (int)((float)_4QLHHCk23T1BjK7acKxASbkCefG._je8rVfyg4zywmqSi4Ozx1z7wJ4b * _4QLHHCk23T1BjK7acKxASbkCefG._fO7gSlrDDNMoHR4FO5QXAq8fUyA);
					val.Height = (int)((float)_4QLHHCk23T1BjK7acKxASbkCefG._WJfGWBzn4wgdGBnMWRH2pcJ3AqH * _4QLHHCk23T1BjK7acKxASbkCefG._fO7gSlrDDNMoHR4FO5QXAq8fUyA);
					num = (int)((num2 * 479828661) ^ 0x73B7BB27);
					continue;
				case 26u:
					_4QLHHCk23T1BjK7acKxASbkCefG._IvIFs0Tl6RHdTn3daJXsNCXCNyO = true;
					num = (int)(num2 * 2060212754) ^ -1619595519;
					continue;
				case 25u:
					ujAkjlfN5TywwbLAUDzPvtab6uJ2._oc2Bt2sYu2e2W8gFbd4cz1hv2Fq();
					num = 1217340882;
					continue;
				case 24u:
					val.Y -= val.Height;
					num = ((int)num2 * -28169872) ^ -750992052;
					continue;
				case 23u:
				{
					int num13;
					int num14;
					if (ujAkjlfN5TywwbLAUDzPvtab6uJ2 is _x1wxbalqqw8qtEqHC1UaGdv59Od)
					{
						num13 = 284486727;
						num14 = 284486727;
					}
					else
					{
						num13 = 677255258;
						num14 = 677255258;
					}
					num = num13 ^ ((int)num2 * -254371264);
					continue;
				}
				case 22u:
					num3--;
					num = 1125303753;
					continue;
				case 21u:
				{
					_4QLHHCk23T1BjK7acKxASbkCefG2 = ((_3IHp43rpkJgOBcY9lrIrwMuwWve)ujAkjlfN5TywwbLAUDzPvtab6uJ)._4QLHHCk23T1BjK7acKxASbkCefG;
					int num9;
					int num10;
					if (_4QLHHCk23T1BjK7acKxASbkCefG2._ZVpZ5Oing5kbbVhbmbOHyrofGH7 != null)
					{
						num9 = 2101598259;
						num10 = 2101598259;
					}
					else
					{
						num9 = 805040086;
						num10 = 805040086;
					}
					num = num9 ^ ((int)num2 * -434740221);
					continue;
				}
				case 20u:
				{
					int num30;
					if (ujAkjlfN5TywwbLAUDzPvtab6uJ2._3ZeCDXqcWHY4XJDBGyav3UzxYaHA)
					{
						num = 861497242;
						num30 = 861497242;
					}
					else
					{
						num = 1682608545;
						num30 = 1682608545;
					}
					continue;
				}
				case 19u:
					val.Y = (int)ujAkjlfN5TywwbLAUDzPvtab6uJ2._bCjZ3VSXGKyhmykd2zCnQBiSpDf;
					num = ((int)num2 * -1430440616) ^ 0x49383F59;
					continue;
				case 18u:
				{
					int num24;
					int num25;
					if (ujAkjlfN5TywwbLAUDzPvtab6uJ != null && bool_0)
					{
						num24 = -1332228459;
						num25 = -1332228459;
					}
					else
					{
						num24 = -779221623;
						num25 = -779221623;
					}
					num = num24 ^ (int)(num2 * 1232744178);
					continue;
				}
				case 17u:
				{
					int num21;
					int num22;
					if (((Rectangle)(ref val)).Contains(point_0))
					{
						num21 = 476655795;
						num22 = 476655795;
					}
					else
					{
						num21 = 247993535;
						num22 = 247993535;
					}
					num = num21 ^ (int)(num2 * 289675857);
					continue;
				}
				case 16u:
				{
					int num19;
					int num20;
					if (ujAkjlfN5TywwbLAUDzPvtab6uJ == null)
					{
						num19 = -1603864751;
						num20 = -1603864751;
					}
					else
					{
						num19 = -1866860559;
						num20 = -1866860559;
					}
					num = num19 ^ ((int)num2 * -811699370);
					continue;
				}
				case 15u:
					num = ((int)num2 * -58707419) ^ -790115640;
					continue;
				case 14u:
					val.Height = ujAkjlfN5TywwbLAUDzPvtab6uJ2._WJfGWBzn4wgdGBnMWRH2pcJ3AqH;
					num = ((int)num2 * -959052574) ^ 0x5590A388;
					continue;
				case 11u:
				{
					int num15;
					int num16;
					if (((Rectangle)(ref val)).Contains(point_0))
					{
						num15 = -239780705;
						num16 = -239780705;
					}
					else
					{
						num15 = -716992649;
						num16 = -716992649;
					}
					num = num15 ^ (int)(num2 * 442850014);
					continue;
				}
				case 10u:
					_4QLHHCk23T1BjK7acKxASbkCefG2._ZVpZ5Oing5kbbVhbmbOHyrofGH7();
					num = (int)(num2 * 1145091520) ^ -1345870180;
					continue;
				case 9u:
				{
					int num11;
					int num12;
					if (!(ujAkjlfN5TywwbLAUDzPvtab6uJ2 is _3IHp43rpkJgOBcY9lrIrwMuwWve))
					{
						num11 = 1062960270;
						num12 = 1062960270;
					}
					else
					{
						num11 = 803768360;
						num12 = 803768360;
					}
					num = num11 ^ ((int)num2 * -1595607997);
					continue;
				}
				case 8u:
					ujAkjlfN5TywwbLAUDzPvtab6uJ = ujAkjlfN5TywwbLAUDzPvtab6uJ2;
					num = (int)(num2 * 1664496767) ^ -454221284;
					continue;
				case 7u:
					ujAkjlfN5TywwbLAUDzPvtab6uJ2._i3qb0SiBqvdxqp5NXIRGrNGErxh();
					num = ((int)num2 * -1179018345) ^ -2009006080;
					continue;
				case 6u:
				{
					int num4;
					int num5;
					if (!(ujAkjlfN5TywwbLAUDzPvtab6uJ2 is _rmc1e7Ng50C4uLmgllAoRtxaZiB))
					{
						num4 = 1125148488;
						num5 = 1125148488;
					}
					else
					{
						num4 = 568273149;
						num5 = 568273149;
					}
					num = num4 ^ (int)(num2 * 37019262);
					continue;
				}
				case 4u:
					val.Y = (int)_4QLHHCk23T1BjK7acKxASbkCefG._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf;
					num = ((int)num2 * -2107136433) ^ -1003156554;
					continue;
				case 3u:
					ujAkjlfN5TywwbLAUDzPvtab6uJ2 = list_0[num3];
					num = 749678154;
					continue;
				case 2u:
					_QLfEh7VVWqcVZ2VleBjZBbD78ng = ujAkjlfN5TywwbLAUDzPvtab6uJ;
					num = ((int)num2 * -410904900) ^ -495036613;
					continue;
				case 1u:
					ujAkjlfN5TywwbLAUDzPvtab6uJ = ujAkjlfN5TywwbLAUDzPvtab6uJ2;
					num = ((int)num2 * -1563723197) ^ -1043719986;
					continue;
				case 0u:
					_4QLHHCk23T1BjK7acKxASbkCefG = ((_3IHp43rpkJgOBcY9lrIrwMuwWve)ujAkjlfN5TywwbLAUDzPvtab6uJ2)._4QLHHCk23T1BjK7acKxASbkCefG;
					_4QLHHCk23T1BjK7acKxASbkCefG._IvIFs0Tl6RHdTn3daJXsNCXCNyO = false;
					num = ((int)num2 * -1774567792) ^ -621011473;
					continue;
				default:
					return;
				case 5u:
					break;
				case 12u:
					return;
				case 13u:
					_QLfEh7VVWqcVZ2VleBjZBbD78ng = ujAkjlfN5TywwbLAUDzPvtab6uJ;
					return;
				}
				break;
			}
		}
	}

	public virtual void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0, Matrix matrix_0)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		_rNZd4y7Vjg7H4PTzsnTaLEi5v8b(spriteBatch_0, skeletonMeshRenderer_0, matrix_0, _lstlI8qzZ4KErYKnufdOlj1xVZF);
	}

	public virtual void _Z70nK2EA1n5FNJxjWP0TzHQ0Lzb(SpriteBatch spriteBatch_0)
	{
		_7UlnfykmEmZDFt3BmCKZekI43Ih.smethod_8(_PnkAlVnMv0SZvRBFexqzE5DF9tp);
	}

	private void _rNZd4y7Vjg7H4PTzsnTaLEi5v8b(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0, Matrix matrix_0, IEnumerable<_ujAkjlfN5TywwbLAUDzPvtab6uJ> ienumerable_0)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		IEnumerator<_ujAkjlfN5TywwbLAUDzPvtab6uJ> enumerator = ienumerable_0.GetEnumerator();
		try
		{
			_ujAkjlfN5TywwbLAUDzPvtab6uJ current = default(_ujAkjlfN5TywwbLAUDzPvtab6uJ);
			_WBXNT6eIVGk6ZKExRBJ6JxXE6zb wBXNT6eIVGk6ZKExRBJ6JxXE6zb = default(_WBXNT6eIVGk6ZKExRBJ6JxXE6zb);
			while (true)
			{
				IL_03ff:
				int num;
				int num2;
				if (!_7UlnfykmEmZDFt3BmCKZekI43Ih.smethod_6((IEnumerator)enumerator))
				{
					num = 846534918;
					num2 = 846534918;
				}
				else
				{
					num = 1608543663;
					num2 = 1608543663;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x60C62A9Bu) % 29u)
					{
					case 28u:
					{
						int num8;
						int num9;
						if (!(current is _3IHp43rpkJgOBcY9lrIrwMuwWve))
						{
							num8 = 1850295957;
							num9 = 1850295957;
						}
						else
						{
							num8 = 485046976;
							num9 = 485046976;
						}
						num = num8 ^ (int)(num3 * 1112714467);
						continue;
					}
					case 27u:
					{
						int num17;
						int num18;
						if (flag)
						{
							num17 = 1663845375;
							num18 = 1663845375;
						}
						else
						{
							num17 = 1949795754;
							num18 = 1949795754;
						}
						num = num17 ^ ((int)num3 * -520056264);
						continue;
					}
					case 26u:
						num = 1608543663;
						continue;
					case 25u:
						wBXNT6eIVGk6ZKExRBJ6JxXE6zb._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0, skeletonMeshRenderer_0);
						num = 1502098250;
						continue;
					case 24u:
						_dXVK1NWaxcsgYg6KpavA0e8oion._g9Sx54kMPiHz5jrqWh4Kb1pTijH(nullable_0: matrix_0, spriteBatch_0: spriteBatch_0, spriteSortMode_0: (SpriteSortMode)0, blendState_0: _XvcwmP1Eb6HFUF5pkiUVgpqNbWE);
						num = (int)((num3 * 422172839) ^ 0x2E826DC9);
						continue;
					case 23u:
					{
						int num16;
						if (flag)
						{
							num = 1093904121;
							num16 = 1093904121;
						}
						else
						{
							num = 422631619;
							num16 = 422631619;
						}
						continue;
					}
					case 22u:
					{
						current = enumerator.Current;
						int num13;
						if (!current._Fxy2SlgceW90FloFw6a1AEJODYA)
						{
							num = 1065453359;
							num13 = 1065453359;
						}
						else
						{
							num = 1888626492;
							num13 = 1888626492;
						}
						continue;
					}
					case 21u:
						_7UlnfykmEmZDFt3BmCKZekI43Ih.smethod_9(spriteBatch_0);
						num = ((int)num3 * -1507375964) ^ 0x2A782D9;
						continue;
					case 20u:
						num = ((int)num3 * -2104072262) ^ 0x38318C11;
						continue;
					case 19u:
						wBXNT6eIVGk6ZKExRBJ6JxXE6zb._WBXNT6eIVGk6ZKExRBJ6JxXE6zb_002E_GDeKFFD8Rxnpsjzy36lUBxAEopc += matrix_0.M41;
						num = ((int)num3 * -199869503) ^ -1464712442;
						continue;
					case 18u:
						_nrDmURIbDeklrMRB6X5y3IwhP1Q(current as _3IHp43rpkJgOBcY9lrIrwMuwWve, spriteBatch_0, skeletonMeshRenderer_0, matrix_0);
						num = 1065453359;
						continue;
					case 17u:
					{
						int num5;
						if (current is _fAUddQEKfZyemRb327NhM3GGlmzA)
						{
							num = 95070967;
							num5 = 95070967;
						}
						else
						{
							num = 1692912563;
							num5 = 1692912563;
						}
						continue;
					}
					case 16u:
						_7UlnfykmEmZDFt3BmCKZekI43Ih.smethod_9(spriteBatch_0);
						num = (int)(num3 * 736787452) ^ -1605075144;
						continue;
					case 15u:
						wBXNT6eIVGk6ZKExRBJ6JxXE6zb._WBXNT6eIVGk6ZKExRBJ6JxXE6zb_002E_JpSvHH1W0gFCpaNEH5zB1qsDJXY += matrix_0.M42;
						num = (int)(num3 * 492044708) ^ -439778540;
						continue;
					case 13u:
					{
						int num14;
						int num15;
						if (wBXNT6eIVGk6ZKExRBJ6JxXE6zb._zkHMlDFkja4TqmjdlHuZRCj8FCB)
						{
							num14 = 322798752;
							num15 = 322798752;
						}
						else
						{
							num14 = 916041822;
							num15 = 916041822;
						}
						num = num14 ^ ((int)num3 * -1652146337);
						continue;
					}
					case 12u:
					{
						int num11;
						int num12;
						if (flag)
						{
							num11 = -266573101;
							num12 = -266573101;
						}
						else
						{
							num11 = -766964355;
							num12 = -766964355;
						}
						num = num11 ^ (int)(num3 * 1453733695);
						continue;
					}
					case 11u:
					{
						int num10;
						if (!(current is _WBXNT6eIVGk6ZKExRBJ6JxXE6zb))
						{
							num = 1587868476;
							num10 = 1587868476;
						}
						else
						{
							num = 322601416;
							num10 = 322601416;
						}
						continue;
					}
					case 10u:
						flag = true;
						num = (int)(num3 * 225740753) ^ -1845333085;
						continue;
					case 9u:
					{
						int num6;
						int num7;
						if (flag)
						{
							num6 = 2032279929;
							num7 = 2032279929;
						}
						else
						{
							num6 = 704092403;
							num7 = 704092403;
						}
						num = num6 ^ ((int)num3 * -2083354767);
						continue;
					}
					case 8u:
						flag = false;
						num = (int)(num3 * 501034984) ^ -550171550;
						continue;
					case 7u:
						_7UlnfykmEmZDFt3BmCKZekI43Ih.smethod_9(spriteBatch_0);
						num = ((int)num3 * -736612730) ^ -1519423041;
						continue;
					case 6u:
						current._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0);
						num = 1065453359;
						continue;
					case 5u:
						((_fAUddQEKfZyemRb327NhM3GGlmzA)current)._3TrGrUra7cqeIXkbZOrfaoQaD5F = matrix_0;
						current._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0);
						num = 57835312;
						continue;
					case 4u:
						flag = false;
						num = ((int)num3 * -489777475) ^ 0x620B074E;
						continue;
					case 2u:
						flag = false;
						num = ((int)num3 * -595612250) ^ -1403066511;
						continue;
					case 1u:
					{
						wBXNT6eIVGk6ZKExRBJ6JxXE6zb = (_WBXNT6eIVGk6ZKExRBJ6JxXE6zb)current;
						int num4;
						if (wBXNT6eIVGk6ZKExRBJ6JxXE6zb._zkHMlDFkja4TqmjdlHuZRCj8FCB)
						{
							num = 1946286508;
							num4 = 1946286508;
						}
						else
						{
							num = 99951928;
							num4 = 99951928;
						}
						continue;
					}
					case 0u:
						wBXNT6eIVGk6ZKExRBJ6JxXE6zb._WBXNT6eIVGk6ZKExRBJ6JxXE6zb_002E_GDeKFFD8Rxnpsjzy36lUBxAEopc -= matrix_0.M41;
						wBXNT6eIVGk6ZKExRBJ6JxXE6zb._WBXNT6eIVGk6ZKExRBJ6JxXE6zb_002E_JpSvHH1W0gFCpaNEH5zB1qsDJXY -= matrix_0.M42;
						num = ((int)num3 * -1469218371) ^ 0x149F28D;
						continue;
					default:
						goto end_IL_0369;
					case 3u:
						break;
					case 14u:
						goto end_IL_0369;
					}
					goto IL_03ff;
					continue;
					end_IL_0369:
					break;
				}
				break;
			}
		}
		finally
		{
			if (enumerator != null)
			{
				while (true)
				{
					IL_0445:
					int num19 = 210442284;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)num19 ^ 0x60C62A9Bu) % 3u)
						{
						case 1u:
							goto IL_0413;
						default:
							goto end_IL_0427;
						case 0u:
							break;
						case 2u:
							goto end_IL_0427;
						}
						goto IL_0445;
						IL_0413:
						_7UlnfykmEmZDFt3BmCKZekI43Ih.smethod_7((IDisposable)enumerator);
						num19 = (int)(num3 * 396963482) ^ -814439254;
						continue;
						end_IL_0427:
						break;
					}
					break;
				}
			}
		}
		if (!flag)
		{
			return;
		}
		while (true)
		{
			int num20 = 400999233;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num20 ^ 0x60C62A9Bu) % 3u)
				{
				case 2u:
					goto IL_0452;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0452:
				_7UlnfykmEmZDFt3BmCKZekI43Ih.smethod_9(spriteBatch_0);
				num20 = (int)((num3 * 1790182875) ^ 0x1786997E);
			}
		}
	}

	private void _nrDmURIbDeklrMRB6X5y3IwhP1Q(_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve_0, SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0, Matrix matrix_0)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT _4QLHHCk23T1BjK7acKxASbkCefG = _3IHp43rpkJgOBcY9lrIrwMuwWve_0._4QLHHCk23T1BjK7acKxASbkCefG;
		if (_4QLHHCk23T1BjK7acKxASbkCefG is _tfDAeR6npiqJMLRSXPO1DxGA0TgA)
		{
			goto IL_009a;
		}
		goto IL_019c;
		IL_019c:
		int num;
		int num2;
		if (!(_4QLHHCk23T1BjK7acKxASbkCefG is _xZgbANe7gi6i2DAhBEkKpR1QFLe))
		{
			num = -701137385;
			num2 = -701137385;
		}
		else
		{
			num = -1728213836;
			num2 = -1728213836;
		}
		goto IL_014b;
		IL_014b:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0xCCEFA2A7u) % 12u)
			{
			case 11u:
				spriteBatch_0._g9Sx54kMPiHz5jrqWh4Kb1pTijH((SpriteSortMode)1, BlendState.NonPremultiplied, null, null, null, null, (!_4QLHHCk23T1BjK7acKxASbkCefG._zkHMlDFkja4TqmjdlHuZRCj8FCB) ? matrix_0 : Matrix.get_Identity());
				num = -1572718926;
				continue;
			case 10u:
				((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)_4QLHHCk23T1BjK7acKxASbkCefG)._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0, skeletonMeshRenderer_0);
				num = -836410065;
				continue;
			case 8u:
			{
				int num6;
				int num7;
				if (!_4QLHHCk23T1BjK7acKxASbkCefG._zkHMlDFkja4TqmjdlHuZRCj8FCB)
				{
					num6 = 1762759177;
					num7 = 1762759177;
				}
				else
				{
					num6 = 1803556079;
					num7 = 1803556079;
				}
				num = num6 ^ (int)(num3 * 1466952527);
				continue;
			}
			case 7u:
				break;
			case 6u:
				((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)_4QLHHCk23T1BjK7acKxASbkCefG)._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL += matrix_0.M41;
				num = (int)(num3 * 68913004) ^ -1006406377;
				continue;
			case 5u:
				((_xZgbANe7gi6i2DAhBEkKpR1QFLe)_4QLHHCk23T1BjK7acKxASbkCefG)._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0);
				num = ((int)num3 * -235111195) ^ 0x7B19B1CD;
				continue;
			case 3u:
				_7UlnfykmEmZDFt3BmCKZekI43Ih.smethod_9(spriteBatch_0);
				num = (int)(num3 * 929181057) ^ -2082253772;
				continue;
			case 1u:
			{
				int num4;
				int num5;
				if (!_4QLHHCk23T1BjK7acKxASbkCefG._zkHMlDFkja4TqmjdlHuZRCj8FCB)
				{
					num4 = -17471693;
					num5 = -17471693;
				}
				else
				{
					num4 = -1052340365;
					num5 = -1052340365;
				}
				num = num4 ^ (int)(num3 * 1765527526);
				continue;
			}
			case 0u:
				((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)_4QLHHCk23T1BjK7acKxASbkCefG)._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf += matrix_0.M42;
				num = (int)(num3 * 1271590021) ^ -2042953411;
				continue;
			default:
				return;
			case 9u:
				goto IL_019c;
			case 2u:
				((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)_4QLHHCk23T1BjK7acKxASbkCefG)._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL -= matrix_0.M41;
				((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)_4QLHHCk23T1BjK7acKxASbkCefG)._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf -= matrix_0.M42;
				return;
			case 4u:
				return;
			}
			break;
		}
		goto IL_009a;
		IL_009a:
		num = -1911281962;
		goto IL_014b;
	}

	public virtual void _6hE3geqxrB1vCirtSWHxIJjlTQB(string string_0)
	{
		_hFeWJ5482CKD4l4529bYY1catC = string_0;
	}

	public _3IHp43rpkJgOBcY9lrIrwMuwWve _VvFE2zgy4FbDjvaEvb67tXJ7aRm(string string_0)
	{
		return _0c5TjZklJbu1wzYG2FIcvf3SIdh(_7UlnfykmEmZDFt3BmCKZekI43Ih.smethod_10("NPCLayer_", string_0)) as _3IHp43rpkJgOBcY9lrIrwMuwWve;
	}

	public _3IHp43rpkJgOBcY9lrIrwMuwWve _VvFE2zgy4FbDjvaEvb67tXJ7aRm(NPCLocation npclocation_0)
	{
		NPCLocation _p4GdxjVD0gRLct8Aao7RzPb4Qz7 = default(NPCLocation);
		while (true)
		{
			int num = -1808414951;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBB7F69CAu) % 3u)
				{
				case 2u:
					goto IL_0008;
				case 0u:
					break;
				default:
					return _lstlI8qzZ4KErYKnufdOlj1xVZF.FirstOrDefault((_ujAkjlfN5TywwbLAUDzPvtab6uJ _ujAkjlfN5TywwbLAUDzPvtab6uJ_0) => _ujAkjlfN5TywwbLAUDzPvtab6uJ_0 is _3IHp43rpkJgOBcY9lrIrwMuwWve && ((_3IHp43rpkJgOBcY9lrIrwMuwWve)_ujAkjlfN5TywwbLAUDzPvtab6uJ_0)._4QLHHCk23T1BjK7acKxASbkCefG._9m9LEAgaqaeXydYhykSBmf9BrDG == _p4GdxjVD0gRLct8Aao7RzPb4Qz7) as _3IHp43rpkJgOBcY9lrIrwMuwWve;
				}
				break;
				IL_0008:
				_p4GdxjVD0gRLct8Aao7RzPb4Qz7 = npclocation_0;
				num = ((int)num2 * -654056580) ^ -520783433;
			}
		}
	}

	public _3IHp43rpkJgOBcY9lrIrwMuwWve _VvFE2zgy4FbDjvaEvb67tXJ7aRm<T>()
	{
		return _0c5TjZklJbu1wzYG2FIcvf3SIdh(_7UlnfykmEmZDFt3BmCKZekI43Ih.smethod_10("NPCLayer_", _7UlnfykmEmZDFt3BmCKZekI43Ih.smethod_12((MemberInfo)_7UlnfykmEmZDFt3BmCKZekI43Ih.smethod_11(typeof(T).TypeHandle)))) as _3IHp43rpkJgOBcY9lrIrwMuwWve;
	}

	public _3IHp43rpkJgOBcY9lrIrwMuwWve _gWHVDvr9GDtRXP2zf2Md18MgZ4b(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, _a2qVgWDIm3fBp49WubttSTPsx8K _a2qVgWDIm3fBp49WubttSTPsx8K_0)
	{
		_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve2 = _VvFE2zgy4FbDjvaEvb67tXJ7aRm(_7UlnfykmEmZDFt3BmCKZekI43Ih.smethod_12((MemberInfo)_7UlnfykmEmZDFt3BmCKZekI43Ih.smethod_13((object)_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0))) ?? new _3IHp43rpkJgOBcY9lrIrwMuwWve(this, _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, _a2qVgWDIm3fBp49WubttSTPsx8K_0);
		while (true)
		{
			int num = 504335637;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x16BC8D88u) % 4u)
				{
				case 3u:
					_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(_3IHp43rpkJgOBcY9lrIrwMuwWve2, (_a2qVgWDIm3fBp49WubttSTPsx8K_0 == _a2qVgWDIm3fBp49WubttSTPsx8K.Background) ? 1 : 3);
					num = 1055969466;
					continue;
				case 1u:
					_3IHp43rpkJgOBcY9lrIrwMuwWve2._dPmC8tBC0iph2YBAFmztEsmwUdSA = _a2qVgWDIm3fBp49WubttSTPsx8K_0;
					num = ((int)num2 * -269940565) ^ -689193352;
					continue;
				case 0u:
					break;
				default:
					return _3IHp43rpkJgOBcY9lrIrwMuwWve2;
				}
				break;
			}
		}
	}

	public T _7oYtfGpL7UyAQrZxew7Ahbvj6Sv<T>(T gparam_0, int int_0, int int_1 = 0) where T : _ujAkjlfN5TywwbLAUDzPvtab6uJ
	{
		gparam_0._ac2H6kMdrgPhXXxabsikjji4SiT = int_0;
		while (true)
		{
			int num = 423079876;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7ED6964Eu) % 3u)
				{
				case 1u:
					goto IL_000e;
				case 2u:
					break;
				default:
					_Bj3jScuqBJCFV58AWBDg8HofpqY = true;
					return gparam_0;
				}
				break;
				IL_000e:
				_lstlI8qzZ4KErYKnufdOlj1xVZF.Add(gparam_0);
				num = (int)((num2 * 1705374713) ^ 0x6053F5E1);
			}
		}
	}

	public void _yMMFQ2n4dqXlB1AEzmdkoKkPkX5()
	{
		_Bj3jScuqBJCFV58AWBDg8HofpqY = true;
	}

	public virtual void _bHdVKtqP3Eb3DSJmuVTbkY8RtHP()
	{
	}

	static Desktop smethod_0()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Desktop();
	}

	static Skin smethod_1()
	{
		return Gui.GenerateStandardSkin();
	}

	static void smethod_2(Desktop desktop_0, Skin skin_0)
	{
		desktop_0.set_Skin(skin_0);
	}

	static ArgumentException smethod_3(string string_0)
	{
		return new ArgumentException(string_0);
	}

	static bool smethod_4(string string_0)
	{
		return string.IsNullOrEmpty(string_0);
	}

	static void smethod_5(Desktop desktop_0)
	{
		desktop_0.Update();
	}

	static bool smethod_6(IEnumerator ienumerator_0)
	{
		return ienumerator_0.MoveNext();
	}

	static void smethod_7(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static void smethod_8(Desktop desktop_0)
	{
		desktop_0.Draw();
	}

	static void smethod_9(SpriteBatch spriteBatch_0)
	{
		spriteBatch_0.End();
	}

	static string smethod_10(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static Type smethod_11(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static string smethod_12(MemberInfo memberInfo_0)
	{
		return memberInfo_0.Name;
	}

	static Type smethod_13(object object_0)
	{
		return object_0.GetType();
	}
}
