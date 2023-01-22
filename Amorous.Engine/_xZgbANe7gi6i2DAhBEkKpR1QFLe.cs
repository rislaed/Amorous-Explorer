using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

public abstract class _xZgbANe7gi6i2DAhBEkKpR1QFLe : _QGGOTxZ8aNWGh0hc26wcmx8wmwT
{
	private class _e6Sul13xByZYV3zUae0HX9fjnS
	{
		private readonly _xZgbANe7gi6i2DAhBEkKpR1QFLe _v5mBBzOHST4Ij2jetldrF2beJtbA;

		private Color _JbGNnZhaeWyNm0aWm7TtSamww4C = Color.get_White();

		private float _AQwQu1ldCtpbkD5F9oEByJdCnWaA;

		private readonly Texture2D _OzFEGvZu5tqLcitcWhX3j9pIBZM;

		public string _RB8fRXeQvK5vs7JEA0XfVCEpg1i { get; private set; }

		public float _WxTaPaOE8qb7d7anVlwwqCzugAo
		{
			set
			{
				if (value < 0f)
				{
					goto IL_007a;
				}
				goto IL_00bf;
				IL_00bf:
				int num;
				int num2;
				if (!(value > 1f))
				{
					num = 2097995424;
					num2 = 2097995424;
				}
				else
				{
					num = 775775045;
					num2 = 775775045;
				}
				goto IL_007f;
				IL_007f:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x7CF20183u) % 8u)
					{
					case 7u:
						num = (int)((num3 * 46582073) ^ 0x2347380D);
						continue;
					case 6u:
						_AQwQu1ldCtpbkD5F9oEByJdCnWaA = 1f;
						num = ((int)num3 * -1668678669) ^ 0x6FFC5DEE;
						continue;
					case 4u:
						_AQwQu1ldCtpbkD5F9oEByJdCnWaA = 0f;
						num = ((int)num3 * -1434511848) ^ -2044922063;
						continue;
					case 3u:
						_AQwQu1ldCtpbkD5F9oEByJdCnWaA = value;
						num = 1355397482;
						continue;
					case 2u:
						num = ((int)num3 * -1667046992) ^ 0xC79D70A;
						continue;
					case 0u:
						break;
					case 5u:
						goto IL_00bf;
					default:
						((Color)(ref _JbGNnZhaeWyNm0aWm7TtSamww4C)).set_A((byte)(255f * _AQwQu1ldCtpbkD5F9oEByJdCnWaA));
						return;
					}
					break;
				}
				goto IL_007a;
				IL_007a:
				num = 1111600063;
				goto IL_007f;
			}
		}

		public _e6Sul13xByZYV3zUae0HX9fjnS(_xZgbANe7gi6i2DAhBEkKpR1QFLe _xZgbANe7gi6i2DAhBEkKpR1QFLe_0, string string_0, Texture2D texture2D_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			while (true)
			{
				int num = -1791919929;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x96432208u) % 5u)
					{
					case 4u:
						_v5mBBzOHST4Ij2jetldrF2beJtbA = _xZgbANe7gi6i2DAhBEkKpR1QFLe_0;
						_RB8fRXeQvK5vs7JEA0XfVCEpg1i = string_0;
						num = ((int)num2 * -1248299320) ^ 0x6B1B224E;
						continue;
					case 1u:
						_OzFEGvZu5tqLcitcWhX3j9pIBZM = texture2D_0;
						num = (int)(num2 * 2105096224) ^ -771281070;
						continue;
					case 0u:
						_WxTaPaOE8qb7d7anVlwwqCzugAo = 0f;
						num = ((int)num2 * -3126282) ^ 0x2E4929F8;
						continue;
					default:
						return;
					case 3u:
						break;
					case 2u:
						return;
					}
					break;
				}
			}
		}

		public void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0, float float_0, bool bool_0)
		{
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			if (((Color)(ref _JbGNnZhaeWyNm0aWm7TtSamww4C)).get_A() != 0)
			{
				goto IL_000d;
			}
			goto IL_0043;
			IL_0043:
			int num = -1174299894;
			goto IL_0096;
			IL_0096:
			while (true)
			{
				switch ((uint)(num ^ -833671625) % 6u)
				{
				case 2u:
					break;
				case 4u:
					((Color)(ref _JbGNnZhaeWyNm0aWm7TtSamww4C)).set_B((byte)((!bool_0) ? byte.MaxValue : 0));
					num = -578307209;
					continue;
				case 3u:
					goto IL_0043;
				case 0u:
					spriteBatch_0.Draw(_OzFEGvZu5tqLcitcWhX3j9pIBZM, _v5mBBzOHST4Ij2jetldrF2beJtbA._8unc6IeMzWr21kLsfewGCwXMejbA, (Rectangle?)null, _JbGNnZhaeWyNm0aWm7TtSamww4C, 0f, Vector2.get_Zero(), float_0, (SpriteEffects)(_v5mBBzOHST4Ij2jetldrF2beJtbA._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn ? 1 : 0), 0f);
					num = -2115084430;
					continue;
				default:
					return;
				case 1u:
					return;
				case 5u:
					return;
				}
				break;
			}
			goto IL_000d;
			IL_000d:
			((Color)(ref _JbGNnZhaeWyNm0aWm7TtSamww4C)).set_G((byte)((!bool_0) ? byte.MaxValue : 0));
			num = -1488408121;
			goto IL_0096;
		}
	}

	[CompilerGenerated]
	private sealed class _SmpuMmi5rPWwC56EUKrWloIvBOP
	{
		public string _WPGpU4kAXTreTeMwHuTyjW07HnD;

		internal bool _93hDsYHjzdW3gVkyWOOwmxvdBh(_e6Sul13xByZYV3zUae0HX9fjnS _e6Sul13xByZYV3zUae0HX9fjnS_0)
		{
			return _SmpuMmi5rPWwC56EUKrWloIvBOP.smethod_0(_e6Sul13xByZYV3zUae0HX9fjnS_0._RB8fRXeQvK5vs7JEA0XfVCEpg1i, _WPGpU4kAXTreTeMwHuTyjW07HnD);
		}

		static bool smethod_0(string string_0, string string_1)
		{
			return string_0 == string_1;
		}
	}

	[CompilerGenerated]
	private sealed class _ezpafHBgvnfTxiH2SPK1ScwRs5f
	{
		public string _DUP53cO7xCh4uBaA7x81m76Z48P;

		internal bool _mJcAkmkbkc0eaOjcvWrLMcXSUL4(_e6Sul13xByZYV3zUae0HX9fjnS _e6Sul13xByZYV3zUae0HX9fjnS_0)
		{
			return _ezpafHBgvnfTxiH2SPK1ScwRs5f.smethod_0(_e6Sul13xByZYV3zUae0HX9fjnS_0._RB8fRXeQvK5vs7JEA0XfVCEpg1i, _DUP53cO7xCh4uBaA7x81m76Z48P);
		}

		static bool smethod_0(string string_0, string string_1)
		{
			return string_0 == string_1;
		}
	}

	private readonly string _cBXbsynpanoywEAm2hd5ysuf78l;

	private List<_e6Sul13xByZYV3zUae0HX9fjnS> _uCN0rAUpYyEIvrweCRehrSN3Vsm;

	private Vector2 _8unc6IeMzWr21kLsfewGCwXMejbA = Vector2.get_Zero();

	public bool _YyDeMNgCbNCOMTBX2QLUb4ruMp9A = true;

	protected readonly float _jSsdHgef86oxWXEOENwyht1nIvn = _boyt8NIMtKsAGSTcjHeL0WMbFxs._S7DdtNZASTkc9riB27h5Ktq5VjDA(0f, (float)Math.PI * 2f);

	protected float _ZSm5WiT2IPnq6W1i4QmcxHACwQh = 1f;

	private readonly Effect _9jklVVcQQYcyqOYrkPiht2VP0IG;

	public override float _QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL
	{
		get
		{
			return _8unc6IeMzWr21kLsfewGCwXMejbA.X;
		}
		set
		{
			_8unc6IeMzWr21kLsfewGCwXMejbA.X = value;
		}
	}

	public override float _QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf
	{
		get
		{
			return _8unc6IeMzWr21kLsfewGCwXMejbA.Y;
		}
		set
		{
			_8unc6IeMzWr21kLsfewGCwXMejbA.Y = value;
		}
	}

	protected _xZgbANe7gi6i2DAhBEkKpR1QFLe(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, string string_0, float float_0 = 1f)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		_cBXbsynpanoywEAm2hd5ysuf78l = string_0;
		_uCN0rAUpYyEIvrweCRehrSN3Vsm = new List<_e6Sul13xByZYV3zUae0HX9fjnS>();
		base._fO7gSlrDDNMoHR4FO5QXAq8fUyA = float_0;
		_9jklVVcQQYcyqOYrkPiht2VP0IG = base._ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Effect>("Assets/Shaders/Breathing");
	}

	public override void _g9Sx54kMPiHz5jrqWh4Kb1pTijH()
	{
		using (List<_NaKchYC4I4GjWR34SfBLAktysCE>.Enumerator enumerator = base._EcxlglhukYZdLVkSogxZZE3XdVj.GetEnumerator())
		{
			_EZ0kOLXoEoEfWGQDdTbNqaPzDUh current2 = default(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh);
			while (enumerator.MoveNext())
			{
				_NaKchYC4I4GjWR34SfBLAktysCE current;
				while (true)
				{
					current = enumerator.Current;
					current._CjFYKEH7Vq8U6urMqr8ixn5Z8li.ForEach(delegate(string string_0)
					{
						_wKyvqIzFCeVgn62yYXdOxlqw4In(base._ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8, string_0);
					});
					int num = 200256510;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x7DA29832u) % 3u)
						{
						case 2u:
							num = 641237010;
							continue;
						case 1u:
							break;
						default:
							goto end_IL_0035;
						}
						break;
					}
					continue;
					end_IL_0035:
					break;
				}
				current._l11eB5s4oGaWqILnwn3dX83PzrN.ForEach(delegate(string string_0)
				{
					_wKyvqIzFCeVgn62yYXdOxlqw4In(base._ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8, string_0);
				});
				using List<_EZ0kOLXoEoEfWGQDdTbNqaPzDUh>.Enumerator enumerator2 = current._wUcbLpwYJ1T1bI8GaQwj9Jxx4YX.GetEnumerator();
				while (true)
				{
					IL_00fe:
					int num3;
					int num4;
					if (enumerator2.MoveNext())
					{
						num3 = 1406182180;
						num4 = 1406182180;
					}
					else
					{
						num3 = 1371852600;
						num4 = 1371852600;
					}
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x7DA29832u) % 5u)
						{
						case 4u:
							current2._CjFYKEH7Vq8U6urMqr8ixn5Z8li.ForEach(delegate(string string_0)
							{
								_wKyvqIzFCeVgn62yYXdOxlqw4In(base._ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8, string_0);
							});
							num3 = ((int)num2 * -1176004711) ^ 0x6B1E2362;
							continue;
						case 1u:
							current2 = enumerator2.Current;
							num3 = 1603211842;
							continue;
						case 0u:
							num3 = 1406182180;
							continue;
						default:
							goto end_IL_00cc;
						case 2u:
							break;
						case 3u:
							goto end_IL_00cc;
						}
						goto IL_00fe;
						continue;
						end_IL_00cc:
						break;
					}
					break;
				}
			}
		}
		using (List<_xmfdPa5IagU3cXbLL61gyoXAV7gA>.Enumerator enumerator3 = base._uZyXmbTsZVxXsadCzSsIs0z4xdb.GetEnumerator())
		{
			_xmfdPa5IagU3cXbLL61gyoXAV7gA current3 = default(_xmfdPa5IagU3cXbLL61gyoXAV7gA);
			while (true)
			{
				IL_022d:
				int num5;
				int num6;
				if (!enumerator3.MoveNext())
				{
					num5 = 1331613906;
					num6 = 1331613906;
				}
				else
				{
					num5 = 2075579276;
					num6 = 2075579276;
				}
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num5 ^ 0x7DA29832u) % 7u)
					{
					case 6u:
						current3._CjFYKEH7Vq8U6urMqr8ixn5Z8li.ForEach(delegate(string string_0)
						{
							_wKyvqIzFCeVgn62yYXdOxlqw4In(base._ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8, string_0);
						});
						num5 = (int)((num2 * 471988768) ^ 0x858E5BD);
						continue;
					case 5u:
					{
						int num7;
						int num8;
						if (_xZgbANe7gi6i2DAhBEkKpR1QFLe.smethod_5(current3._RaPHmtsFBJiVmlc8lVytEMOT6ZA))
						{
							num7 = -1311855139;
							num8 = -1311855139;
						}
						else
						{
							num7 = -1571558826;
							num8 = -1571558826;
						}
						num5 = num7 ^ ((int)num2 * -2091500812);
						continue;
					}
					case 4u:
						current3 = enumerator3.Current;
						num5 = 1003495939;
						continue;
					case 1u:
						_wKyvqIzFCeVgn62yYXdOxlqw4In(base._ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8, current3._RaPHmtsFBJiVmlc8lVytEMOT6ZA);
						num5 = (int)(num2 * 1355438773) ^ -199348775;
						continue;
					case 0u:
						num5 = 2075579276;
						continue;
					default:
						goto end_IL_01f0;
					case 3u:
						break;
					case 2u:
						goto end_IL_01f0;
					}
					goto IL_022d;
					continue;
					end_IL_01f0:
					break;
				}
				break;
			}
		}
		string[] array = _zBK8PXhWw9GtXK9IHkvbuvhbigE();
		if (array == null)
		{
			goto IL_036a;
		}
		goto IL_03b6;
		IL_036f:
		int num9;
		_e6Sul13xByZYV3zUae0HX9fjnS e6Sul13xByZYV3zUae0HX9fjnS = default(_e6Sul13xByZYV3zUae0HX9fjnS);
		_SmpuMmi5rPWwC56EUKrWloIvBOP smpuMmi5rPWwC56EUKrWloIvBOP = default(_SmpuMmi5rPWwC56EUKrWloIvBOP);
		int num10 = default(int);
		List<_e6Sul13xByZYV3zUae0HX9fjnS> list = default(List<_e6Sul13xByZYV3zUae0HX9fjnS>);
		string[] array2 = default(string[]);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num9 ^ 0x7DA29832u) % 13u)
			{
			case 12u:
				num9 = ((int)num2 * -1057920029) ^ -943056918;
				continue;
			case 11u:
			{
				e6Sul13xByZYV3zUae0HX9fjnS = _uCN0rAUpYyEIvrweCRehrSN3Vsm.FirstOrDefault(smpuMmi5rPWwC56EUKrWloIvBOP._93hDsYHjzdW3gVkyWOOwmxvdBh);
				int num11;
				int num12;
				if (e6Sul13xByZYV3zUae0HX9fjnS != null)
				{
					num11 = -556671039;
					num12 = -556671039;
				}
				else
				{
					num11 = -2094539797;
					num12 = -2094539797;
				}
				num9 = num11 ^ ((int)num2 * -1557543916);
				continue;
			}
			case 10u:
				num10++;
				num9 = 443805263;
				continue;
			case 9u:
				list.AddRange(_uCN0rAUpYyEIvrweCRehrSN3Vsm);
				_uCN0rAUpYyEIvrweCRehrSN3Vsm = list;
				num9 = ((int)num2 * -1674880619) ^ 0x63E5D4C;
				continue;
			case 8u:
				_uCN0rAUpYyEIvrweCRehrSN3Vsm.Remove(e6Sul13xByZYV3zUae0HX9fjnS);
				num9 = ((int)num2 * -222677044) ^ 0x165142F;
				continue;
			case 7u:
				smpuMmi5rPWwC56EUKrWloIvBOP._WPGpU4kAXTreTeMwHuTyjW07HnD = array2[num10];
				num9 = (int)(num2 * 352303380) ^ -558578023;
				continue;
			case 6u:
				break;
			case 4u:
				smpuMmi5rPWwC56EUKrWloIvBOP = new _SmpuMmi5rPWwC56EUKrWloIvBOP();
				num9 = 42307983;
				continue;
			case 3u:
				list.Add(e6Sul13xByZYV3zUae0HX9fjnS);
				num9 = (int)((num2 * 1649622888) ^ 0x17AB8894);
				continue;
			case 2u:
				goto end_IL_036f;
			default:
				return;
			case 0u:
				goto IL_03b6;
			case 1u:
				return;
			case 5u:
				return;
			}
			int num13;
			if (num10 < array2.Length)
			{
				num9 = 467511817;
				num13 = 467511817;
			}
			else
			{
				num9 = 313954263;
				num13 = 313954263;
			}
			continue;
			end_IL_036f:
			break;
		}
		goto IL_036a;
		IL_036a:
		num9 = 1842969740;
		goto IL_036f;
		IL_03b6:
		list = new List<_e6Sul13xByZYV3zUae0HX9fjnS>();
		array2 = array;
		num10 = 0;
		num9 = 324145893;
		goto IL_036f;
	}

	protected virtual string[] _zBK8PXhWw9GtXK9IHkvbuvhbigE()
	{
		return null;
	}

	private void _wKyvqIzFCeVgn62yYXdOxlqw4In(ContentManager contentManager_0, string string_0)
	{
		Texture2D texture2D_ = contentManager_0.Load<Texture2D>(_xZgbANe7gi6i2DAhBEkKpR1QFLe.smethod_6(_cBXbsynpanoywEAm2hd5ysuf78l, string_0));
		_e6Sul13xByZYV3zUae0HX9fjnS item = new _e6Sul13xByZYV3zUae0HX9fjnS(this, string_0, texture2D_);
		while (true)
		{
			int num = 2009589918;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x466B44D9u) % 3u)
				{
				case 2u:
					goto IL_001e;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_001e:
				_uCN0rAUpYyEIvrweCRehrSN3Vsm.Add(item);
				num = ((int)num2 * -1141939736) ^ 0x58238DF2;
			}
		}
	}

	public virtual void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0)
	{
		base._f5ctqAmdNsZ889UjM4LxDm8WGxA();
		while (true)
		{
			int num = -1215978636;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC5AFD59Fu) % 5u)
				{
				case 4u:
				{
					int num3;
					int num4;
					if (!_YyDeMNgCbNCOMTBX2QLUb4ruMp9A)
					{
						num3 = 176943012;
						num4 = 176943012;
					}
					else
					{
						num3 = 2014603563;
						num4 = 2014603563;
					}
					num = num3 ^ ((int)num2 * -1758644255);
					continue;
				}
				case 1u:
					_xZgbANe7gi6i2DAhBEkKpR1QFLe.smethod_9(_xZgbANe7gi6i2DAhBEkKpR1QFLe.smethod_8(_xZgbANe7gi6i2DAhBEkKpR1QFLe.smethod_7(_9jklVVcQQYcyqOYrkPiht2VP0IG), "Time"), _boyt8NIMtKsAGSTcjHeL0WMbFxs._AmIUCcrmrrQiiirja7DoiZSjXuv);
					_xZgbANe7gi6i2DAhBEkKpR1QFLe.smethod_9(_xZgbANe7gi6i2DAhBEkKpR1QFLe.smethod_8(_xZgbANe7gi6i2DAhBEkKpR1QFLe.smethod_7(_9jklVVcQQYcyqOYrkPiht2VP0IG), "BreathingOffset"), _jSsdHgef86oxWXEOENwyht1nIvn);
					_xZgbANe7gi6i2DAhBEkKpR1QFLe.smethod_9(_xZgbANe7gi6i2DAhBEkKpR1QFLe.smethod_8(_xZgbANe7gi6i2DAhBEkKpR1QFLe.smethod_7(_9jklVVcQQYcyqOYrkPiht2VP0IG), "BreathingSpeed"), _ZSm5WiT2IPnq6W1i4QmcxHACwQh);
					num = (int)((num2 * 946216162) ^ 0x2FF8B836);
					continue;
				case 0u:
					_xZgbANe7gi6i2DAhBEkKpR1QFLe.smethod_13(_xZgbANe7gi6i2DAhBEkKpR1QFLe.smethod_12(_xZgbANe7gi6i2DAhBEkKpR1QFLe.smethod_11(_xZgbANe7gi6i2DAhBEkKpR1QFLe.smethod_10(_9jklVVcQQYcyqOYrkPiht2VP0IG)), 0));
					num = ((int)num2 * -1426679112) ^ 0xCAD93A7;
					continue;
				case 3u:
					break;
				default:
					_DIJ98g9A80rhmS3Wk1l8KTVfV8x(spriteBatch_0);
					return;
				}
				break;
			}
		}
	}

	protected void _DIJ98g9A80rhmS3Wk1l8KTVfV8x(SpriteBatch spriteBatch_0)
	{
		using List<_e6Sul13xByZYV3zUae0HX9fjnS>.Enumerator enumerator = _uCN0rAUpYyEIvrweCRehrSN3Vsm.GetEnumerator();
		while (true)
		{
			int num;
			int num2;
			if (enumerator.MoveNext())
			{
				num = -597175374;
				num2 = -597175374;
			}
			else
			{
				num = -1660081231;
				num2 = -1660081231;
			}
			while (true)
			{
				switch ((uint)(num ^ -261814073) % 4u)
				{
				case 3u:
					num = -597175374;
					continue;
				case 1u:
				{
					_e6Sul13xByZYV3zUae0HX9fjnS current = enumerator.Current;
					current._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0, base._fO7gSlrDDNMoHR4FO5QXAq8fUyA, _IvIFs0Tl6RHdTn3daJXsNCXCNyO);
					num = -1207968329;
					continue;
				}
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	protected override void _aAoZaDNczeScsMfLlGSfAzey9SQ(string string_0, float float_0)
	{
		string _DUP53cO7xCh4uBaA7x81m76Z48P = default(string);
		_e6Sul13xByZYV3zUae0HX9fjnS e6Sul13xByZYV3zUae0HX9fjnS = default(_e6Sul13xByZYV3zUae0HX9fjnS);
		while (true)
		{
			int num = -2111163923;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8EF4BB31u) % 6u)
				{
				case 4u:
					_DUP53cO7xCh4uBaA7x81m76Z48P = string_0;
					num = (int)(num2 * 1001259127) ^ -2006662098;
					continue;
				case 3u:
				{
					e6Sul13xByZYV3zUae0HX9fjnS = _uCN0rAUpYyEIvrweCRehrSN3Vsm.FirstOrDefault((_e6Sul13xByZYV3zUae0HX9fjnS _e6Sul13xByZYV3zUae0HX9fjnS_0) => _ezpafHBgvnfTxiH2SPK1ScwRs5f.smethod_0(_e6Sul13xByZYV3zUae0HX9fjnS_0._RB8fRXeQvK5vs7JEA0XfVCEpg1i, _DUP53cO7xCh4uBaA7x81m76Z48P));
					int num3;
					int num4;
					if (e6Sul13xByZYV3zUae0HX9fjnS != null)
					{
						num3 = 595250647;
						num4 = 595250647;
					}
					else
					{
						num3 = 912760714;
						num4 = 912760714;
					}
					num = num3 ^ (int)(num2 * 2088116489);
					continue;
				}
				case 1u:
					e6Sul13xByZYV3zUae0HX9fjnS._WxTaPaOE8qb7d7anVlwwqCzugAo = float_0;
					num = -2016833083;
					continue;
				default:
					return;
				case 5u:
					break;
				case 0u:
					return;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	protected override bool _BbDRof5yB0Qn864T1KJxUzMy8di(int int_0)
	{
		return true;
	}

	protected override void _PdRLTpsImBScBFQhILtCHJpcsllA(float float_0)
	{
	}

	protected override void _Hx7zLXU6nbxudxFgMuYbyRXeEPB()
	{
	}

	[CompilerGenerated]
	private void _IJKlw9W5LNvCNOfEseal5NFGl7K(string string_0)
	{
		_wKyvqIzFCeVgn62yYXdOxlqw4In(base._ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8, string_0);
	}

	[CompilerGenerated]
	private void _72Q4P5iizjalmTwCcGncyMyhCvL(string string_0)
	{
		_wKyvqIzFCeVgn62yYXdOxlqw4In(base._ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8, string_0);
	}

	[CompilerGenerated]
	private void _daXEbyikrnb7jRlkioa5YyutjYC(string string_0)
	{
		_wKyvqIzFCeVgn62yYXdOxlqw4In(base._ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8, string_0);
	}

	[CompilerGenerated]
	private void _XceAquDnwSS6qOjhLGyFMJRmrlC(string string_0)
	{
		_wKyvqIzFCeVgn62yYXdOxlqw4In(base._ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8, string_0);
	}

	static bool smethod_5(string string_0)
	{
		return string.IsNullOrEmpty(string_0);
	}

	static string smethod_6(string string_0, string string_1)
	{
		return Path.Combine(string_0, string_1);
	}

	static EffectParameterCollection smethod_7(Effect effect_0)
	{
		return effect_0.get_Parameters();
	}

	static EffectParameter smethod_8(EffectParameterCollection effectParameterCollection_0, string string_0)
	{
		return effectParameterCollection_0.get_Item(string_0);
	}

	static void smethod_9(EffectParameter effectParameter_0, float float_0)
	{
		effectParameter_0.SetValue(float_0);
	}

	static EffectTechnique smethod_10(Effect effect_0)
	{
		return effect_0.get_CurrentTechnique();
	}

	static EffectPassCollection smethod_11(EffectTechnique effectTechnique_0)
	{
		return effectTechnique_0.get_Passes();
	}

	static EffectPass smethod_12(EffectPassCollection effectPassCollection_0, int int_0)
	{
		return effectPassCollection_0.get_Item(int_0);
	}

	static void smethod_13(EffectPass effectPass_0)
	{
		effectPass_0.Apply();
	}
}
