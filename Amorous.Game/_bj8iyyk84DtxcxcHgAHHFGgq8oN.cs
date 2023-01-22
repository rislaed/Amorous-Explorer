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

public class _bj8iyyk84DtxcxcHgAHHFGgq8oN : _JbeCmOie0phb2cbgG6DdGZrbs3pB
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _PzOBAEclhQj3NzBZIEIMnKCuYsr
	{
		public static readonly _PzOBAEclhQj3NzBZIEIMnKCuYsr _003C_003E9 = new _PzOBAEclhQj3NzBZIEIMnKCuYsr();

		public static EventHandler<EventArgs> _003C_003E9__67_0;

		public static Action<string> _003C_003E9__67_1;

		public static Func<Type, bool> _003C_003E9__83_0;

		public static Func<Type, bool> _003C_003E9__85_0;

		public static Func<Type, bool> _003C_003E9__98_0;

		internal void _vXpVpR8StCmde1BxCt3HZ4Was4l(object sender, EventArgs e)
		{
			_PzOBAEclhQj3NzBZIEIMnKCuYsr.smethod_0();
		}

		internal void _C9tZY4T9BelwnsewaUqdvfrkWkO(string string_0)
		{
			_PzOBAEclhQj3NzBZIEIMnKCuYsr.smethod_1(string_0);
		}

		internal bool _UCbEdsCpeUZM031TdNSHSb6pKJm(Type type_0)
		{
			return _PzOBAEclhQj3NzBZIEIMnKCuYsr.smethod_3(_PzOBAEclhQj3NzBZIEIMnKCuYsr.smethod_2(typeof(_7UlnfykmEmZDFt3BmCKZekI43Ih).TypeHandle), type_0);
		}

		internal bool _y5EcTN6S5WHsSubAH8bssazPafr(Type type_0)
		{
			return _PzOBAEclhQj3NzBZIEIMnKCuYsr.smethod_3(_PzOBAEclhQj3NzBZIEIMnKCuYsr.smethod_2(typeof(_TwlwMC1hhdSzamwGWEBxuUkz1gH).TypeHandle), type_0);
		}

		internal bool _XvTXd5YEa6Vvxl9n2Ol0oGLBLMr(Type type_0)
		{
			if (_PzOBAEclhQj3NzBZIEIMnKCuYsr.smethod_3(_PzOBAEclhQj3NzBZIEIMnKCuYsr.smethod_2(typeof(_QGGOTxZ8aNWGh0hc26wcmx8wmwT).TypeHandle), type_0))
			{
				return !_PzOBAEclhQj3NzBZIEIMnKCuYsr.smethod_4(type_0);
			}
			return false;
		}

		static void smethod_0()
		{
			_eJWqL2MhFZHNHP960nsWLJJmyPD._7cuPUL8aamrg9daETH6zQk3RwbF();
		}

		static int smethod_1(string string_0)
		{
			return SDL.SDL_SetClipboardText(string_0);
		}

		static Type smethod_2(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		static bool smethod_3(Type type_0, Type type_1)
		{
			return type_0.IsAssignableFrom(type_1);
		}

		static bool smethod_4(Type type_0)
		{
			return type_0.IsAbstract;
		}
	}

	[CompilerGenerated]
	private sealed class _9rqW5HzG3UXapFpEBDu18BZJznG
	{
		public _bj8iyyk84DtxcxcHgAHHFGgq8oN _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA;

		public string _n6iPJ4jnSQTmNXcr3d8lbsKKvZl;

		public Action _tJbdAZlfIfFFpJS1sihbykE2o6aA;

		internal void _YEm4Fu1bwGy4cpd59V0jpUH3dVg()
		{
			_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._OxLRmpxixplTKChiTPUKAx4uTLG(_n6iPJ4jnSQTmNXcr3d8lbsKKvZl, delegate
			{
				_9rqW5HzG3UXapFpEBDu18BZJznG.smethod_0(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._RA1aFlOff0jGfI2cKUGhYI1MRLBA, (Action)null);
			});
		}

		internal void _tei9DxeyvzRSN2gVPN7a84fgTHB()
		{
			_9rqW5HzG3UXapFpEBDu18BZJznG.smethod_0(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._RA1aFlOff0jGfI2cKUGhYI1MRLBA, (Action)null);
		}

		static void smethod_0(_gJR4g7ak0hsZAUWX1vJbMqG2P5I _gJR4g7ak0hsZAUWX1vJbMqG2P5I_0, Action action_0)
		{
			_gJR4g7ak0hsZAUWX1vJbMqG2P5I_0._FegL010tc92iskjjyD0T33dDwNE(action_0);
		}
	}

	[CompilerGenerated]
	private sealed class _cHlGOT3sD7LBx6eSMMmMOdLnHjd
	{
		public _bj8iyyk84DtxcxcHgAHHFGgq8oN _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA;

		public _7UlnfykmEmZDFt3BmCKZekI43Ih _RJTGWz7KqClGKVJa614391g5XSF;

		public Action _tJbdAZlfIfFFpJS1sihbykE2o6aA;

		internal void _YEm4Fu1bwGy4cpd59V0jpUH3dVg()
		{
			_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._OxLRmpxixplTKChiTPUKAx4uTLG(_RJTGWz7KqClGKVJa614391g5XSF, delegate
			{
				_cHlGOT3sD7LBx6eSMMmMOdLnHjd.smethod_0(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._RA1aFlOff0jGfI2cKUGhYI1MRLBA, (Action)null);
			});
		}

		internal void _tei9DxeyvzRSN2gVPN7a84fgTHB()
		{
			_cHlGOT3sD7LBx6eSMMmMOdLnHjd.smethod_0(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._RA1aFlOff0jGfI2cKUGhYI1MRLBA, (Action)null);
		}

		static void smethod_0(_gJR4g7ak0hsZAUWX1vJbMqG2P5I _gJR4g7ak0hsZAUWX1vJbMqG2P5I_0, Action action_0)
		{
			_gJR4g7ak0hsZAUWX1vJbMqG2P5I_0._FegL010tc92iskjjyD0T33dDwNE(action_0);
		}
	}

	[CompilerGenerated]
	private sealed class _AsW3kNzx3Ky1kSe2GNlryDfK39C
	{
		public string _n6iPJ4jnSQTmNXcr3d8lbsKKvZl;

		internal bool _xOTetouAMgpoVP1Odv1VLfy0eRM(Type type_0)
		{
			return _AsW3kNzx3Ky1kSe2GNlryDfK39C.smethod_1(_AsW3kNzx3Ky1kSe2GNlryDfK39C.smethod_0((MemberInfo)type_0), _n6iPJ4jnSQTmNXcr3d8lbsKKvZl);
		}

		static string smethod_0(MemberInfo memberInfo_0)
		{
			return memberInfo_0.Name;
		}

		static bool smethod_1(string string_0, string string_1)
		{
			return string_0 == string_1;
		}
	}

	[CompilerGenerated]
	private sealed class _FzfT43cjHYNexO7AyOgI7RzVHys
	{
		public string _n6iPJ4jnSQTmNXcr3d8lbsKKvZl;

		internal bool _sIlJuy1mbitJLAJwvDE1VXEKMXb(Type type_0)
		{
			return _FzfT43cjHYNexO7AyOgI7RzVHys.smethod_1(_FzfT43cjHYNexO7AyOgI7RzVHys.smethod_0((MemberInfo)type_0), _n6iPJ4jnSQTmNXcr3d8lbsKKvZl);
		}

		static string smethod_0(MemberInfo memberInfo_0)
		{
			return memberInfo_0.Name;
		}

		static bool smethod_1(string string_0, string string_1)
		{
			return string_0 == string_1;
		}
	}

	[CompilerGenerated]
	private sealed class _pRMaMNHrUICTrn5AyRDYx65hOVDA
	{
		public _bj8iyyk84DtxcxcHgAHHFGgq8oN _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA;

		public _zkUeZhJDizkmvvRfp4S0G7aap8J _JyFtGgNgB3bOcqUlEWpLqpF8I4r;

		internal void _Lt3aLn3yORtbYxl1uOyUJh4nZ53()
		{
			_eg2fyrjBR4bPqUReWrIXIUOH1Fn CS_0024_003C_003E8__locals0 = new _eg2fyrjBR4bPqUReWrIXIUOH1Fn
			{
				_wr6xcvFOgUbaTATC17S6Y9v3y3S = this,
				_hvKKVpHsQ6yw7YBy97lS8UDtil = _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._5yVCuTv9lVSCCxs7cUlv79ysuRh(_pRMaMNHrUICTrn5AyRDYx65hOVDA.smethod_0(_JyFtGgNgB3bOcqUlEWpLqpF8I4r))
			};
			if (CS_0024_003C_003E8__locals0._hvKKVpHsQ6yw7YBy97lS8UDtil == null)
			{
				return;
			}
			_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._OxLRmpxixplTKChiTPUKAx4uTLG(_pRMaMNHrUICTrn5AyRDYx65hOVDA.smethod_1(_JyFtGgNgB3bOcqUlEWpLqpF8I4r), delegate
			{
				if (_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_0(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r) != null)
				{
					goto IL_0027;
				}
				goto IL_0112;
				IL_0112:
				int num;
				int num2;
				if (_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_2(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r) != null)
				{
					num = 1325931602;
					num2 = 1325931602;
				}
				else
				{
					num = 613778258;
					num2 = 613778258;
				}
				goto IL_00d9;
				IL_00d9:
				_QGGOTxZ8aNWGh0hc26wcmx8wmwT qGGOTxZ8aNWGh0hc26wcmx8wmwT_ = default(_QGGOTxZ8aNWGh0hc26wcmx8wmwT);
				_zkUeZhJDizkmvvRfp4S0G7aap8J._CIFXVF6lKl3nSrVOhqjcFXDVlXc current = default(_zkUeZhJDizkmvvRfp4S0G7aap8J._CIFXVF6lKl3nSrVOhqjcFXDVlXc);
				_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve = default(_3IHp43rpkJgOBcY9lrIrwMuwWve);
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x11EA7359u) % 6u)
					{
					case 4u:
						break;
					case 3u:
						_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_1(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._XbOXR6AypLIdJ3gBMGseGi3Wi2i, _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_0(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r));
						num = ((int)num3 * -1708666652) ^ -220919343;
						continue;
					case 1u:
						CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._gYGB98heFqsLp9tgJbdCP01IKV2(_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_2(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r));
						num = ((int)num3 * -1726648562) ^ 0x163B51E1;
						continue;
					case 0u:
						_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_5(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._KVSwpLj0RvURRswHn7ogRy4BRfd, _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_3(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r), _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_4(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r));
						num = (int)((num3 * 1263079409) ^ 0x1E514050);
						continue;
					case 2u:
						goto IL_0112;
					default:
					{
						using (List<_zkUeZhJDizkmvvRfp4S0G7aap8J._CIFXVF6lKl3nSrVOhqjcFXDVlXc>.Enumerator enumerator = _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_6(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r).GetEnumerator())
						{
							while (true)
							{
								IL_024b:
								int num4;
								int num5;
								if (enumerator.MoveNext())
								{
									num4 = 633851960;
									num5 = 633851960;
								}
								else
								{
									num4 = 1587468332;
									num5 = 1587468332;
								}
								while (true)
								{
									switch ((num3 = (uint)num4 ^ 0x11EA7359u) % 8u)
									{
									case 7u:
										qGGOTxZ8aNWGh0hc26wcmx8wmwT_ = CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._TwQHHdbdRFRy2ctTZabNfz1Htrg(_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_7(current), _a2qVgWDIm3fBp49WubttSTPsx8K.Background);
										num4 = (int)((num3 * 1786622167) ^ 0x31BA5140);
										continue;
									case 6u:
										_3IHp43rpkJgOBcY9lrIrwMuwWve = _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_13(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._xfiKuXXh5LQA9CUQiex6tutzFKQ, _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_7(current));
										num4 = ((int)num3 * -911556875) ^ 0x42871BCB;
										continue;
									case 4u:
										_3IHp43rpkJgOBcY9lrIrwMuwWve._VNgmwYSLsJyyiR6cPQ35UHJBR4d = _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_14(current);
										num4 = ((int)num3 * -1347434217) ^ 0x388BE6AF;
										continue;
									case 3u:
										num4 = 633851960;
										continue;
									case 1u:
										current = enumerator.Current;
										num4 = 1652898318;
										continue;
									case 0u:
										_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_12(qGGOTxZ8aNWGh0hc26wcmx8wmwT_, _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_8(current), _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_9(current), _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_10(current), _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_11(current));
										num4 = (int)(num3 * 302114036) ^ -682740993;
										continue;
									default:
										goto end_IL_020a;
									case 2u:
										break;
									case 5u:
										goto end_IL_020a;
									}
									goto IL_024b;
									continue;
									end_IL_020a:
									break;
								}
								break;
							}
						}
						if (_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_15(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r))
						{
							while (true)
							{
								int num6 = 1261540779;
								while (true)
								{
									switch ((num3 = (uint)num6 ^ 0x11EA7359u) % 5u)
									{
									case 2u:
										_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_18(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Ta8oiGRfjrRGtgUaA5S061UepZb, _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_16(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r), (int?)_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_17(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r));
										num6 = ((int)num3 * -1311545333) ^ -99361949;
										continue;
									case 1u:
										CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Ta8oiGRfjrRGtgUaA5S061UepZb = CS_0024_003C_003E8__locals0._hvKKVpHsQ6yw7YBy97lS8UDtil;
										num6 = (int)(num3 * 1250263189) ^ -2062427039;
										continue;
									case 4u:
										break;
									case 0u:
										return;
									default:
										goto end_IL_0317;
									}
									break;
								}
								continue;
								end_IL_0317:
								break;
							}
						}
						_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_19(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Qj2G6fpAF4mGsATgkV8DPBF3aA1A, (Action)delegate
						{
							CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Ta8oiGRfjrRGtgUaA5S061UepZb = CS_0024_003C_003E8__locals0._hvKKVpHsQ6yw7YBy97lS8UDtil;
							_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_18(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Ta8oiGRfjrRGtgUaA5S061UepZb, _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_16(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r), (int?)_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_17(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r));
						});
						return;
					}
					}
					break;
				}
				goto IL_0027;
				IL_0027:
				num = 640273266;
				goto IL_00d9;
			});
		}

		static string smethod_0(_zkUeZhJDizkmvvRfp4S0G7aap8J _zkUeZhJDizkmvvRfp4S0G7aap8J_0)
		{
			return _zkUeZhJDizkmvvRfp4S0G7aap8J_0._RB8fRXeQvK5vs7JEA0XfVCEpg1i;
		}

		static string smethod_1(_zkUeZhJDizkmvvRfp4S0G7aap8J _zkUeZhJDizkmvvRfp4S0G7aap8J_0)
		{
			return _zkUeZhJDizkmvvRfp4S0G7aap8J_0._XbOXR6AypLIdJ3gBMGseGi3Wi2i;
		}
	}

	[CompilerGenerated]
	private sealed class _eg2fyrjBR4bPqUReWrIXIUOH1Fn
	{
		public _nR8eroJOHehP0ZGyyTveo6aMTHg _hvKKVpHsQ6yw7YBy97lS8UDtil;

		public _pRMaMNHrUICTrn5AyRDYx65hOVDA _wr6xcvFOgUbaTATC17S6Y9v3y3S;

		public Action _N0QkaWJJa2ooS7UE5tZBoKJaLDmA;

		internal void _efWWueQBW3NCapiwfmGDbjz3bQh()
		{
			if (_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_0(_wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r) != null)
			{
				goto IL_0027;
			}
			goto IL_0112;
			IL_0112:
			int num;
			int num2;
			if (_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_2(_wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r) != null)
			{
				num = 1325931602;
				num2 = 1325931602;
			}
			else
			{
				num = 613778258;
				num2 = 613778258;
			}
			goto IL_00d9;
			IL_00d9:
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT qGGOTxZ8aNWGh0hc26wcmx8wmwT_ = default(_QGGOTxZ8aNWGh0hc26wcmx8wmwT);
			_zkUeZhJDizkmvvRfp4S0G7aap8J._CIFXVF6lKl3nSrVOhqjcFXDVlXc current = default(_zkUeZhJDizkmvvRfp4S0G7aap8J._CIFXVF6lKl3nSrVOhqjcFXDVlXc);
			_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve = default(_3IHp43rpkJgOBcY9lrIrwMuwWve);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num ^ 0x11EA7359u) % 6u)
				{
				case 4u:
					break;
				case 3u:
					_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_1(_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._XbOXR6AypLIdJ3gBMGseGi3Wi2i, _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_0(_wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r));
					num = ((int)num3 * -1708666652) ^ -220919343;
					continue;
				case 1u:
					_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._gYGB98heFqsLp9tgJbdCP01IKV2(_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_2(_wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r));
					num = ((int)num3 * -1726648562) ^ 0x163B51E1;
					continue;
				case 0u:
					_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_5(_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._KVSwpLj0RvURRswHn7ogRy4BRfd, _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_3(_wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r), _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_4(_wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r));
					num = (int)((num3 * 1263079409) ^ 0x1E514050);
					continue;
				case 2u:
					goto IL_0112;
				default:
				{
					using (List<_zkUeZhJDizkmvvRfp4S0G7aap8J._CIFXVF6lKl3nSrVOhqjcFXDVlXc>.Enumerator enumerator = _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_6(_wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r).GetEnumerator())
					{
						while (true)
						{
							IL_024b:
							int num4;
							int num5;
							if (enumerator.MoveNext())
							{
								num4 = 633851960;
								num5 = 633851960;
							}
							else
							{
								num4 = 1587468332;
								num5 = 1587468332;
							}
							while (true)
							{
								switch ((num3 = (uint)num4 ^ 0x11EA7359u) % 8u)
								{
								case 7u:
									qGGOTxZ8aNWGh0hc26wcmx8wmwT_ = _wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._TwQHHdbdRFRy2ctTZabNfz1Htrg(_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_7(current), _a2qVgWDIm3fBp49WubttSTPsx8K.Background);
									num4 = (int)((num3 * 1786622167) ^ 0x31BA5140);
									continue;
								case 6u:
									_3IHp43rpkJgOBcY9lrIrwMuwWve = _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_13(_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._xfiKuXXh5LQA9CUQiex6tutzFKQ, _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_7(current));
									num4 = ((int)num3 * -911556875) ^ 0x42871BCB;
									continue;
								case 4u:
									_3IHp43rpkJgOBcY9lrIrwMuwWve._VNgmwYSLsJyyiR6cPQ35UHJBR4d = _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_14(current);
									num4 = ((int)num3 * -1347434217) ^ 0x388BE6AF;
									continue;
								case 3u:
									num4 = 633851960;
									continue;
								case 1u:
									current = enumerator.Current;
									num4 = 1652898318;
									continue;
								case 0u:
									_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_12(qGGOTxZ8aNWGh0hc26wcmx8wmwT_, _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_8(current), _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_9(current), _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_10(current), _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_11(current));
									num4 = (int)(num3 * 302114036) ^ -682740993;
									continue;
								default:
									goto end_IL_020a;
								case 2u:
									break;
								case 5u:
									goto end_IL_020a;
								}
								goto IL_024b;
								continue;
								end_IL_020a:
								break;
							}
							break;
						}
					}
					if (_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_15(_wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r))
					{
						while (true)
						{
							int num6 = 1261540779;
							while (true)
							{
								switch ((num3 = (uint)num6 ^ 0x11EA7359u) % 5u)
								{
								case 2u:
									_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_18(_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Ta8oiGRfjrRGtgUaA5S061UepZb, _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_16(_wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r), (int?)_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_17(_wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r));
									num6 = ((int)num3 * -1311545333) ^ -99361949;
									continue;
								case 1u:
									_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Ta8oiGRfjrRGtgUaA5S061UepZb = _hvKKVpHsQ6yw7YBy97lS8UDtil;
									num6 = (int)(num3 * 1250263189) ^ -2062427039;
									continue;
								case 4u:
									break;
								case 0u:
									return;
								default:
									goto end_IL_0317;
								}
								break;
							}
							continue;
							end_IL_0317:
							break;
						}
					}
					_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_19(_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Qj2G6fpAF4mGsATgkV8DPBF3aA1A, (Action)delegate
					{
						_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Ta8oiGRfjrRGtgUaA5S061UepZb = _hvKKVpHsQ6yw7YBy97lS8UDtil;
						_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_18(_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Ta8oiGRfjrRGtgUaA5S061UepZb, _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_16(_wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r), (int?)_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_17(_wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r));
					});
					return;
				}
				}
				break;
			}
			goto IL_0027;
			IL_0027:
			num = 640273266;
			goto IL_00d9;
		}

		internal void _oLpcDBCBvPERkbvp6clOOzqaKXi()
		{
			_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Ta8oiGRfjrRGtgUaA5S061UepZb = _hvKKVpHsQ6yw7YBy97lS8UDtil;
			_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_18(_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Ta8oiGRfjrRGtgUaA5S061UepZb, _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_16(_wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r), (int?)_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_17(_wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r));
		}

		static string smethod_0(_zkUeZhJDizkmvvRfp4S0G7aap8J _zkUeZhJDizkmvvRfp4S0G7aap8J_0)
		{
			return _zkUeZhJDizkmvvRfp4S0G7aap8J_0._tTalXU1p5sOHKNCtH0ZDWD55yfD;
		}

		static void smethod_1(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0)
		{
			_7UlnfykmEmZDFt3BmCKZekI43Ih_0._6hE3geqxrB1vCirtSWHxIJjlTQB(string_0);
		}

		static string smethod_2(_zkUeZhJDizkmvvRfp4S0G7aap8J _zkUeZhJDizkmvvRfp4S0G7aap8J_0)
		{
			return _zkUeZhJDizkmvvRfp4S0G7aap8J_0._KVSwpLj0RvURRswHn7ogRy4BRfd;
		}

		static _TwlwMC1hhdSzamwGWEBxuUkz1gH._qokIrmaaT3Lq6znW10HdrPUO9Fq smethod_3(_zkUeZhJDizkmvvRfp4S0G7aap8J _zkUeZhJDizkmvvRfp4S0G7aap8J_0)
		{
			return _zkUeZhJDizkmvvRfp4S0G7aap8J_0._zGDIuIFdpGkZI7SJBoEsZdKoN9F;
		}

		static bool smethod_4(_zkUeZhJDizkmvvRfp4S0G7aap8J _zkUeZhJDizkmvvRfp4S0G7aap8J_0)
		{
			return _zkUeZhJDizkmvvRfp4S0G7aap8J_0._xEhNfzWWkAGsoMu0XE2Cy84SXcp;
		}

		static void smethod_5(_TwlwMC1hhdSzamwGWEBxuUkz1gH _TwlwMC1hhdSzamwGWEBxuUkz1gH_0, _TwlwMC1hhdSzamwGWEBxuUkz1gH._qokIrmaaT3Lq6znW10HdrPUO9Fq _qokIrmaaT3Lq6znW10HdrPUO9Fq_0, bool bool_0)
		{
			_TwlwMC1hhdSzamwGWEBxuUkz1gH_0._eXH4tq2J0DADXDLofA8G8Yw8fau(_qokIrmaaT3Lq6znW10HdrPUO9Fq_0, bool_0);
		}

		static List<_zkUeZhJDizkmvvRfp4S0G7aap8J._CIFXVF6lKl3nSrVOhqjcFXDVlXc> smethod_6(_zkUeZhJDizkmvvRfp4S0G7aap8J _zkUeZhJDizkmvvRfp4S0G7aap8J_0)
		{
			return _zkUeZhJDizkmvvRfp4S0G7aap8J_0._SE8JVSojXz0WQ6EAeInGo3JGvSr;
		}

		static string smethod_7(_zkUeZhJDizkmvvRfp4S0G7aap8J._CIFXVF6lKl3nSrVOhqjcFXDVlXc _CIFXVF6lKl3nSrVOhqjcFXDVlXc_0)
		{
			return _CIFXVF6lKl3nSrVOhqjcFXDVlXc_0._RB8fRXeQvK5vs7JEA0XfVCEpg1i;
		}

		static NPCLocation smethod_8(_zkUeZhJDizkmvvRfp4S0G7aap8J._CIFXVF6lKl3nSrVOhqjcFXDVlXc _CIFXVF6lKl3nSrVOhqjcFXDVlXc_0)
		{
			return _CIFXVF6lKl3nSrVOhqjcFXDVlXc_0._qZXN2SXhpGdh4T5ZXzgMA9gjYZE;
		}

		static string smethod_9(_zkUeZhJDizkmvvRfp4S0G7aap8J._CIFXVF6lKl3nSrVOhqjcFXDVlXc _CIFXVF6lKl3nSrVOhqjcFXDVlXc_0)
		{
			return _CIFXVF6lKl3nSrVOhqjcFXDVlXc_0._kni1uFw1BPElsVA74myj9H1jAKh;
		}

		static string smethod_10(_zkUeZhJDizkmvvRfp4S0G7aap8J._CIFXVF6lKl3nSrVOhqjcFXDVlXc _CIFXVF6lKl3nSrVOhqjcFXDVlXc_0)
		{
			return _CIFXVF6lKl3nSrVOhqjcFXDVlXc_0._UjXB7oNK1WnbtEn6d4PkoGLaYEE;
		}

		static string[] smethod_11(_zkUeZhJDizkmvvRfp4S0G7aap8J._CIFXVF6lKl3nSrVOhqjcFXDVlXc _CIFXVF6lKl3nSrVOhqjcFXDVlXc_0)
		{
			return _CIFXVF6lKl3nSrVOhqjcFXDVlXc_0._wUcbLpwYJ1T1bI8GaQwj9Jxx4YX;
		}

		static void smethod_12(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, NPCLocation npclocation_0, string string_0, string string_1, string[] string_2)
		{
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._7d2DAwjp6FutkJY09U0Mlk43Nmn(npclocation_0, string_0, string_1, string_2);
		}

		static _3IHp43rpkJgOBcY9lrIrwMuwWve smethod_13(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0)
		{
			return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._VvFE2zgy4FbDjvaEvb67tXJ7aRm(string_0);
		}

		static int smethod_14(_zkUeZhJDizkmvvRfp4S0G7aap8J._CIFXVF6lKl3nSrVOhqjcFXDVlXc _CIFXVF6lKl3nSrVOhqjcFXDVlXc_0)
		{
			return _CIFXVF6lKl3nSrVOhqjcFXDVlXc_0._VNgmwYSLsJyyiR6cPQ35UHJBR4d;
		}

		static bool smethod_15(_zkUeZhJDizkmvvRfp4S0G7aap8J _zkUeZhJDizkmvvRfp4S0G7aap8J_0)
		{
			return _zkUeZhJDizkmvvRfp4S0G7aap8J_0._KR48sJtGCfgf7jYtIsrj2N1iO3n;
		}

		static int smethod_16(_zkUeZhJDizkmvvRfp4S0G7aap8J _zkUeZhJDizkmvvRfp4S0G7aap8J_0)
		{
			return _zkUeZhJDizkmvvRfp4S0G7aap8J_0._8NBsjeWoi7V64KoA9ZtIybPpcom;
		}

		static int smethod_17(_zkUeZhJDizkmvvRfp4S0G7aap8J _zkUeZhJDizkmvvRfp4S0G7aap8J_0)
		{
			return _zkUeZhJDizkmvvRfp4S0G7aap8J_0._WCJjJQRlVoZM67usdV2f1OR3arG;
		}

		static void smethod_18(_nR8eroJOHehP0ZGyyTveo6aMTHg _nR8eroJOHehP0ZGyyTveo6aMTHg_0, int int_0, int? nullable_0)
		{
			_nR8eroJOHehP0ZGyyTveo6aMTHg_0._4hlxzMzKSbVTbZUrEsP3dfw4x0h(int_0, nullable_0);
		}

		static void smethod_19(_gJR4g7ak0hsZAUWX1vJbMqG2P5I _gJR4g7ak0hsZAUWX1vJbMqG2P5I_0, Action action_0)
		{
			_gJR4g7ak0hsZAUWX1vJbMqG2P5I_0._FegL010tc92iskjjyD0T33dDwNE(action_0);
		}
	}

	[CompilerGenerated]
	private sealed class _1oSOYUYBONRKpcOISvejZTGlh6P
	{
		public string _hzqOBkJhJBhsTRNARxHLctcvhN0;

		internal bool _dKcDCdnUsXfDoqFtHH8yYpzhBGS(Type type_0)
		{
			return _1oSOYUYBONRKpcOISvejZTGlh6P.smethod_1(_1oSOYUYBONRKpcOISvejZTGlh6P.smethod_0((MemberInfo)type_0), _hzqOBkJhJBhsTRNARxHLctcvhN0);
		}

		static string smethod_0(MemberInfo memberInfo_0)
		{
			return memberInfo_0.Name;
		}

		static bool smethod_1(string string_0, string string_1)
		{
			return string_0 == string_1;
		}
	}

	private readonly Game _4L7hfXrWoDdArQiscG4ukHCV46B;

	private readonly GraphicsDeviceManager _ARAAkijJ1FF23wI2rNDaw7mTOeJ;

	private SpriteBatch _ZXUztyGtStF4WzGVig7wu43cfnf;

	private SkeletonMeshRenderer _BuJyoOT5ylWcIMxjcKRnxVmYvBd;

	private _wRd4nHuQQlAPEwrHOGkBfut6Uip _chds2l0ZCMMghly7dv4eik3iSH5;

	private RenderTarget2D _j2ynkEUaNLywHdchuAYJWHF3l9DA;

	private Rectangle _CCbe95wREA1VhjgpntSpzsQ19He;

	private _gJR4g7ak0hsZAUWX1vJbMqG2P5I _RA1aFlOff0jGfI2cKUGhYI1MRLBA;

	private _UmxbIbk7pgaod0bD7pS309P3Lns _6M30VBCyHzfi1RYZYx7uJAHl1EC;

	private _AUtA43NfhBNYDqRrVB1t9VQxe1v _PxO28nve6nqbBLBJKrzHMRbOasHA;

	private _3FFZvGWTAe7rsviKkDPTXEVjxWf _YNCmHGUHBydamu5BEECMWoB65VfA;

	private _XJasjdoOf6PYbfaC5MsbXSjDWV3 _9rxbJ7LsE3DhACUHVlPZaixc5Jp;

	private _bm5ybW5ND5sDF6bvP0sbYyOpvP _db5uuwyBnUwxthW14pfDBlBoqUp;

	private _KDiaUloddpdv1QwixDEBIJs6IMA _p3BLtW5bCDzTS86VFihe1pfwDoP;

	private Action _ColBlKEOYSqQMmmj719vN58K9aN;

	private _7UlnfykmEmZDFt3BmCKZekI43Ih _xfiKuXXh5LQA9CUQiex6tutzFKQ;

	private _7UlnfykmEmZDFt3BmCKZekI43Ih _Z8BClcChRJrlB6tR1VPJcycVpHN;

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
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_116((MemberInfo)_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_37(typeof(BedroomScene).TypeHandle)),
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_116((MemberInfo)_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_37(typeof(LivingRoomScene).TypeHandle)),
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_116((MemberInfo)_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_37(typeof(ClubBackScene).TypeHandle)),
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_116((MemberInfo)_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_37(typeof(ClubEntranceScene).TypeHandle)),
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_116((MemberInfo)_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_37(typeof(ClubInsideScene).TypeHandle)),
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_116((MemberInfo)_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_37(typeof(ClubLoungeScene).TypeHandle)),
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_116((MemberInfo)_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_37(typeof(ClubPoolScene).TypeHandle)),
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_116((MemberInfo)_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_37(typeof(ClubUpstairsScene).TypeHandle))
	};

	private Keys[] _gylJZYyc3mVB0fbHPCctDIg4UAE;

	private string[] _sUwMzXXmi9PdDQ0bFQhbGQJUPTe;

	private Vector2 _Vh2qdN4Ha62herl19def6PyuanQ;

	public GameWindow _8k7Do3TGW5NrB22zl8QzInP2j7k => _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_0(_4L7hfXrWoDdArQiscG4ukHCV46B);

	public GraphicsDevice _2yepMkVENnecIsduggABaU2qhXW => _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_1(_4L7hfXrWoDdArQiscG4ukHCV46B);

	public ContentManager _uwNDZuqdFb9tyQtlQMxiz1DQ7x8 => _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_2(_4L7hfXrWoDdArQiscG4ukHCV46B);

	public _3FFZvGWTAe7rsviKkDPTXEVjxWf _RbWJ7YGnYHCSoD44MRW1h5X6E7E => _YNCmHGUHBydamu5BEECMWoB65VfA;

	public _wRd4nHuQQlAPEwrHOGkBfut6Uip _vsceSzSIjBy2nZrCxAzKZbUiwLq => _chds2l0ZCMMghly7dv4eik3iSH5;

	public _7UlnfykmEmZDFt3BmCKZekI43Ih _XbOXR6AypLIdJ3gBMGseGi3Wi2i => _xfiKuXXh5LQA9CUQiex6tutzFKQ;

	public _TwlwMC1hhdSzamwGWEBxuUkz1gH _KVSwpLj0RvURRswHn7ogRy4BRfd => _ieTMbMiu3eGRdmzTMofKoJopZAf;

	public _nR8eroJOHehP0ZGyyTveo6aMTHg _5zNdOw7qHmuCAPJFMr3SsZdBlCr => _Ta8oiGRfjrRGtgUaA5S061UepZb;

	public _gJR4g7ak0hsZAUWX1vJbMqG2P5I _Qj2G6fpAF4mGsATgkV8DPBF3aA1A => _RA1aFlOff0jGfI2cKUGhYI1MRLBA;

	public _8lVOgkauaSHbAkAqHzI1K7mIyOI _o2QVQfIAsuLcmPxn14llGoZA52y => _fp8jsuSnELXqf2yy2JQDaXDCBVQ;

	public _691ooXdgg17CWFkMkjedKBBBfYw _aJh9CibG5YKhkExxgRyVopdfSeJ => _db5uuwyBnUwxthW14pfDBlBoqUp;

	public bool _kSReo0whY1pgfTnFOSc44ppANOe => _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_3(_ARAAkijJ1FF23wI2rNDaw7mTOeJ);

	public bool _NdzU0m9x8QDKpVv3DrQmzY5KduB { get; set; }

	public bool _LWcoDwIWvf8DT3nQmNe5z8fkUvI { get; set; }

	public bool _ezjxb7tsh6Db1xblB74OYX4vVK => _DNbNFzOKO7vtoVmjI32p1Snwmpe;

	public _bj8iyyk84DtxcxcHgAHHFGgq8oN(Game game_0, bool bool_0)
	{
		DisplayMode displayMode_ = default(DisplayMode);
		while (true)
		{
			int num = 1357159866;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1C7636C6u) % 12u)
				{
				case 10u:
					num = (int)(num2 * 262694384) ^ -1586396137;
					continue;
				case 9u:
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_19(_uwNDZuqdFb9tyQtlQMxiz1DQ7x8, "Content-Release");
					num = 1143018016;
					continue;
				case 8u:
				{
					GraphicsDeviceManager obj2 = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_5(game_0);
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_6(obj2, bool_0: false);
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_7(obj2, 1024);
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_8(obj2, 768);
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_9(obj2, bool_0: true);
					_ARAAkijJ1FF23wI2rNDaw7mTOeJ = obj2;
					num = (int)((num2 * 252043263) ^ 0x6A3D17C4);
					continue;
				}
				case 7u:
					displayMode_ = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_16(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_15());
					num = 1716956287;
					continue;
				case 5u:
					num = ((int)num2 * -2101514371) ^ 0x3CF58626;
					continue;
				case 4u:
					_4L7hfXrWoDdArQiscG4ukHCV46B = game_0;
					num = ((int)num2 * -342859672) ^ 0x1709DFC0;
					continue;
				case 3u:
				{
					GraphicsDeviceManager obj3 = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_5(game_0);
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_6(obj3, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_12(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_11()));
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_7(obj3, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_13(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_11()));
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_8(obj3, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_14(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_11()));
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_9(obj3, bool_0: true);
					_ARAAkijJ1FF23wI2rNDaw7mTOeJ = obj3;
					num = (int)((num2 * 539842870) ^ 0x605D0B39);
					continue;
				}
				case 2u:
				{
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_4();
					int num4;
					int num5;
					if (bool_0)
					{
						num4 = 354595650;
						num5 = 354595650;
					}
					else
					{
						num4 = 1717140522;
						num5 = 1717140522;
					}
					num = num4 ^ (int)(num2 * 522605408);
					continue;
				}
				case 1u:
				{
					GraphicsDeviceManager obj = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_5(game_0);
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_6(obj, bool_0: true);
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_7(obj, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_17(displayMode_));
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_8(obj, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_18(displayMode_));
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_9(obj, bool_0: true);
					_ARAAkijJ1FF23wI2rNDaw7mTOeJ = obj;
					num = (int)((num2 * 853906231) ^ 0x6ED57C88);
					continue;
				}
				case 0u:
				{
					int num3;
					if (!_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_10())
					{
						num = 1298344513;
						num3 = 1298344513;
					}
					else
					{
						num = 1746773841;
						num3 = 1746773841;
					}
					continue;
				}
				case 11u:
					break;
				default:
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_23(_4L7hfXrWoDdArQiscG4ukHCV46B, (ContentManager)(object)_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_22(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_20(_uwNDZuqdFb9tyQtlQMxiz1DQ7x8), _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_21(_uwNDZuqdFb9tyQtlQMxiz1DQ7x8)));
					return;
				}
				break;
			}
		}
	}

	public void _oD87G7SXjsTukw7IVWxVlVFEgvA()
	{
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_24(_4L7hfXrWoDdArQiscG4ukHCV46B, (EventHandler<EventArgs>)delegate
		{
			_PzOBAEclhQj3NzBZIEIMnKCuYsr.smethod_0();
		});
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_27((Func<string>)_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_26((Delegate)_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_25(), (Delegate)new Func<string>(SDL.SDL_GetClipboardText)));
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_29((Action<string>)_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_26((Delegate)_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_28(), (Delegate)(Action<string>)delegate(string string_0)
		{
			_PzOBAEclhQj3NzBZIEIMnKCuYsr.smethod_1(string_0);
		}));
		string string_ = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = 1186134680;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0x4C3E7276u) % 8u)
				{
				case 6u:
					string_ = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_32(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_31(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_30()), "NonSteam");
					if (!_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_33(string_))
					{
						num = (int)((num2 * 1123350921) ^ 0x636AFCCC);
						continue;
					}
					num5 = 1;
					goto IL_00b3;
				case 5u:
					_p3BLtW5bCDzTS86VFihe1pfwDoP = null;
					num = ((int)num2 * -2058089525) ^ 0x2D5864EE;
					continue;
				case 4u:
					num5 = (_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_33(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_34(string_, ".txt")) ? 1 : 0);
					goto IL_00b3;
				case 3u:
					_p3BLtW5bCDzTS86VFihe1pfwDoP = new _KDiaUloddpdv1QwixDEBIJs6IMA();
					num = (int)((num2 * 1644934995) ^ 0x3ADFF07E);
					continue;
				case 1u:
				{
					int num6;
					int num7;
					if (_p3BLtW5bCDzTS86VFihe1pfwDoP._oD87G7SXjsTukw7IVWxVlVFEgvA(778700u, this))
					{
						num6 = -1671946367;
						num7 = -1671946367;
					}
					else
					{
						num6 = -525258117;
						num7 = -525258117;
					}
					num = num6 ^ (int)(num2 * 472728112);
					continue;
				}
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -168429355;
						num4 = -168429355;
					}
					else
					{
						num3 = -1090756943;
						num4 = -1090756943;
					}
					num = num3 ^ (int)(num2 * 1174027648);
					continue;
				}
				case 2u:
					break;
				default:
					{
						_db5uuwyBnUwxthW14pfDBlBoqUp = new _bm5ybW5ND5sDF6bvP0sbYyOpvP(this, _p3BLtW5bCDzTS86VFihe1pfwDoP);
						return;
					}
					IL_00b3:
					flag = (byte)num5 != 0;
					num = 1947930150;
					continue;
				}
				break;
			}
		}
	}

	public void _eW1Nkl8VqFHVExM8l3IqxgSbMBg()
	{
		//IL_062a: Unknown result type (might be due to invalid IL or missing references)
		//IL_062f: Unknown result type (might be due to invalid IL or missing references)
		string string_ = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_32(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_31(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_30()), "ShowMeSomeBooty");
		if (!_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_33(string_))
		{
			goto IL_0499;
		}
		int num = 1;
		goto IL_07c4;
		IL_07b3:
		num = (_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_33(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_34(string_, ".txt")) ? 1 : 0);
		goto IL_07c4;
		IL_0499:
		int num2 = -354736648;
		goto IL_0714;
		IL_0714:
		Texture2D texture2D_2 = default(Texture2D);
		bool bool_ = default(bool);
		_lRHDfpOTd4PxClZkjMpoakPEA9d lRHDfpOTd4PxClZkjMpoakPEA9d2 = default(_lRHDfpOTd4PxClZkjMpoakPEA9d);
		_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p _3CCr8Bt1rkuzt0M6gYLbceJGV0p = default(_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p);
		SpriteFont spriteFont_ = default(SpriteFont);
		Texture2D texture2D_ = default(Texture2D);
		while (true)
		{
			uint num3;
			_lRHDfpOTd4PxClZkjMpoakPEA9d lRHDfpOTd4PxClZkjMpoakPEA9d;
			switch ((num3 = (uint)num2 ^ 0xFBB70612u) % 35u)
			{
			case 34u:
				texture2D_2 = _4L7hfXrWoDdArQiscG4ukHCV46B.get_Content().Load<Texture2D>("Assets/GUI/Dialogue/dialogue");
				num2 = (int)((num3 * 1230608347) ^ 0x393E549);
				continue;
			case 33u:
				Gui.get_Renderer().SetTexture("MessageIconRemy", (object)_uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Remy"));
				num2 = (int)(num3 * 1460039430) ^ -879577632;
				continue;
			case 32u:
				_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_35(bool_);
				num2 = ((int)num3 * -780196464) ^ -1587371911;
				continue;
			case 31u:
				_DNbNFzOKO7vtoVmjI32p1Snwmpe = true;
				num2 = (int)((num3 * 1825745400) ^ 0x517A48EE);
				continue;
			case 30u:
				_gylJZYyc3mVB0fbHPCctDIg4UAE = (Keys[])_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_38(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_37(typeof(Keys).TypeHandle));
				_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_39(_RbWJ7YGnYHCSoD44MRW1h5X6E7E, bool_0: true);
				_ZXUztyGtStF4WzGVig7wu43cfnf = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_40(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_1(_4L7hfXrWoDdArQiscG4ukHCV46B));
				_BuJyoOT5ylWcIMxjcKRnxVmYvBd = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_41(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_1(_4L7hfXrWoDdArQiscG4ukHCV46B));
				num2 = (int)((num3 * 408959634) ^ 0x1EDF475E);
				continue;
			case 29u:
				_chds2l0ZCMMghly7dv4eik3iSH5 = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_42((_JbeCmOie0phb2cbgG6DdGZrbs3pB)this, 1920, 1080);
				num2 = ((int)num3 * -395705126) ^ -1979616654;
				continue;
			case 28u:
			{
				int num6;
				int num7;
				if (lRHDfpOTd4PxClZkjMpoakPEA9d2 != null)
				{
					num6 = 267646559;
					num7 = 267646559;
				}
				else
				{
					num6 = 1845517118;
					num7 = 1845517118;
				}
				num2 = num6 ^ (int)(num3 * 154342725);
				continue;
			}
			case 27u:
				_SUHe9KzfAd477MCCYxTvqFf3efl = new _poenyHBGUusBcnNcTFB9MQBV72R(this, _4L7hfXrWoDdArQiscG4ukHCV46B.get_Content());
				_5Anqe6GAAkzemoAXYpJmgMlk1yz._3DInasj5B11bCcV5BIRvLE1Ay7w = true;
				_5Anqe6GAAkzemoAXYpJmgMlk1yz._LsIdcBLhaqZr03JCpCYZrI9ztVF();
				num2 = -750004074;
				continue;
			case 26u:
				_0SvmBhkBX8SImQwyvuy5xVObqLn = _4L7hfXrWoDdArQiscG4ukHCV46B.get_Content().Load<Texture2D>("Assets/GUI/Squid/DefaultCursor");
				num2 = ((int)num3 * -851714296) ^ -146839919;
				continue;
			case 25u:
				Gui.get_Renderer().SetTexture("MessageIconLex", (object)_uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Lex"));
				Gui.get_Renderer().SetTexture("MessageIconMercy", (object)_uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Mercy"));
				num2 = (int)(num3 * 1586483880) ^ -979665655;
				continue;
			case 24u:
				if (!_3CCr8Bt1rkuzt0M6gYLbceJGV0p._3y7m8OGVjMe7WGIhZ66YOw3ITUE)
				{
					num2 = ((int)num3 * -1599652378) ^ 0x60095D88;
					continue;
				}
				lRHDfpOTd4PxClZkjMpoakPEA9d = _DW9IcpdMEINZmuzfrqmwsduBGih._NyR9YmfkeF4CXGOi1ENApzh6B5V(_3CCr8Bt1rkuzt0M6gYLbceJGV0p._B3FsRMcQWBXzFf3nLOBKzncessO);
				goto IL_0247;
			case 23u:
				Gui.get_Renderer().SetTexture("MessageIconSkye", (object)_uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Skye"));
				num2 = ((int)num3 * -1920140519) ^ -2109735720;
				continue;
			case 22u:
				Gui.get_Renderer().SetTexture("Contact_DJ", (object)_4L7hfXrWoDdArQiscG4ukHCV46B.get_Content().Load<Texture2D>("Assets/GUI/Phone/Contacts/DJ"));
				_KyKsjBAROeUAsKraBIxtuHTSPwg._Uh2GhEF2pLNc3a7l5WMdPGP2bZd = _pql4s9X0U3svdBghGax6VsdF2Gq;
				num2 = (int)((num3 * 482560461) ^ 0x78B6356F);
				continue;
			case 21u:
				_CCtbrNWS4Gi5hRSEsXYI5VzS7gI = new _Z6EKIW3ycAwV2npYuxbFLcnCTrJ();
				_RA1aFlOff0jGfI2cKUGhYI1MRLBA = new _gJR4g7ak0hsZAUWX1vJbMqG2P5I(_4L7hfXrWoDdArQiscG4ukHCV46B.get_GraphicsDevice());
				_6M30VBCyHzfi1RYZYx7uJAHl1EC = new _UmxbIbk7pgaod0bD7pS309P3Lns(_4L7hfXrWoDdArQiscG4ukHCV46B.get_Content());
				num2 = ((int)num3 * -230510415) ^ -217895981;
				continue;
			case 20u:
				spriteFont_ = _4L7hfXrWoDdArQiscG4ukHCV46B.get_Content().Load<SpriteFont>("Assets/GUI/Fonts/BoldItalic-26");
				num2 = ((int)num3 * -1644785617) ^ 0x243BC50E;
				continue;
			case 18u:
				_YNCmHGUHBydamu5BEECMWoB65VfA = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_36((_JbeCmOie0phb2cbgG6DdGZrbs3pB)this);
				num2 = (int)((num3 * 82967686) ^ 0x4755A4E4);
				continue;
			case 17u:
				Gui.set_Renderer((ISquidRenderer)(object)new _k8LAl8bPyzLGEpo59dKFGU4sCQ(_4L7hfXrWoDdArQiscG4ukHCV46B));
				num2 = ((int)num3 * -433050391) ^ 0x4033D8E9;
				continue;
			case 16u:
				_PxO28nve6nqbBLBJKrzHMRbOasHA = new _AUtA43NfhBNYDqRrVB1t9VQxe1v(_4L7hfXrWoDdArQiscG4ukHCV46B.get_Content());
				num2 = (int)((num3 * 1351817797) ^ 0x183CB42C);
				continue;
			case 15u:
				Gui.get_Renderer().SetTexture("MessageIconShootingRange", (object)_uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_ShootingRange"));
				num2 = (int)((num3 * 1759097649) ^ 0x37AFC492);
				continue;
			case 14u:
				_j2ynkEUaNLywHdchuAYJWHF3l9DA = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_46(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_1(_4L7hfXrWoDdArQiscG4ukHCV46B), 1920, 1080);
				_j2ynkEUaNLywHdchuAYJWHF3l9DA._w2YD42TXOY22EP4Mpp7wzDUO4xv((RenderTargetUsage)1);
				num2 = (int)((num3 * 464299764) ^ 0x242D39D8);
				continue;
			case 13u:
			{
				_P62DygY6CKZG8s5wqDu0uAFksjs = new _nkzqFdEfDyLcyGikIKGcHjklI4y(this, texture2D_2, texture2D_, _xnYepZuegigJCU2jcbZsfVIakzF, spriteFont_);
				_3CCr8Bt1rkuzt0M6gYLbceJGV0p = _DW9IcpdMEINZmuzfrqmwsduBGih._jVNnsNFMjoGC9t7v83qLI8vEZSH();
				int num4;
				int num5;
				if (!_3CCr8Bt1rkuzt0M6gYLbceJGV0p._r4LqoJiAr5K9UiLsUzUDbcJDQqo)
				{
					num4 = 15962078;
					num5 = 15962078;
				}
				else
				{
					num4 = 89295257;
					num5 = 89295257;
				}
				num2 = num4 ^ ((int)num3 * -2099630124);
				continue;
			}
			case 12u:
				texture2D_ = _4L7hfXrWoDdArQiscG4ukHCV46B.get_Content().Load<Texture2D>("Assets/GUI/Dialogue/button");
				num2 = (int)(num3 * 55486812) ^ -1615940079;
				continue;
			case 11u:
				break;
			case 10u:
				Gui.get_Renderer().SetTexture("MessageIconZenith", (object)_uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Zenith"));
				Gui.get_Renderer().SetTexture("MessageIconGeneric", (object)_uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Generic"));
				Gui.get_Renderer().SetTexture("MessageIconDJ", (object)_uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_DJ"));
				num2 = ((int)num3 * -1559662443) ^ 0x27A220E;
				continue;
			case 8u:
				_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_45(_chds2l0ZCMMghly7dv4eik3iSH5, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_43(_ARAAkijJ1FF23wI2rNDaw7mTOeJ), _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_44(_ARAAkijJ1FF23wI2rNDaw7mTOeJ), _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_43(_ARAAkijJ1FF23wI2rNDaw7mTOeJ), _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_44(_ARAAkijJ1FF23wI2rNDaw7mTOeJ));
				num2 = (int)((num3 * 1776419702) ^ 0x516CABB9);
				continue;
			case 7u:
				Gui.get_Renderer().SetTexture("MessageIconCoby", (object)_uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Coby"));
				Gui.get_Renderer().SetTexture("MessageIconDustin", (object)_uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Dustin"));
				Gui.get_Renderer().SetTexture("MessageIconJax", (object)_uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Jax"));
				num2 = (int)((num3 * 1911294434) ^ 0x10F51296);
				continue;
			case 6u:
				_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._yuFBJdi7mxrwMFQ57BjLjSq6ESj._Hnb6mPvrZFgOMCIApIeMW88jSsF = lRHDfpOTd4PxClZkjMpoakPEA9d2._M29jWtsDcmPvHjIYYSiTa8TbWri;
				num2 = ((int)num3 * -344366575) ^ -1153058925;
				continue;
			case 5u:
				_CCbe95wREA1VhjgpntSpzsQ19He = new Rectangle(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_47(_chds2l0ZCMMghly7dv4eik3iSH5), _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_48(_chds2l0ZCMMghly7dv4eik3iSH5), _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_49(_chds2l0ZCMMghly7dv4eik3iSH5), _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_50(_chds2l0ZCMMghly7dv4eik3iSH5));
				num2 = (int)((num3 * 843064448) ^ 0x4F007AB);
				continue;
			case 4u:
				lRHDfpOTd4PxClZkjMpoakPEA9d = _DW9IcpdMEINZmuzfrqmwsduBGih._sabDA8yXNR8DIRSbHjOcXx1e1Ax(_3CCr8Bt1rkuzt0M6gYLbceJGV0p._B3FsRMcQWBXzFf3nLOBKzncessO);
				goto IL_0247;
			case 3u:
				_9rxbJ7LsE3DhACUHVlPZaixc5Jp = new _XJasjdoOf6PYbfaC5MsbXSjDWV3();
				num2 = ((int)num3 * -1083066228) ^ -746708448;
				continue;
			case 2u:
				Gui.get_Renderer().SetTexture("MessageIconSeth", (object)_uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Seth"));
				num2 = ((int)num3 * -2022733853) ^ 0x65F610B0;
				continue;
			case 1u:
				_LWcoDwIWvf8DT3nQmNe5z8fkUvI = true;
				_xnYepZuegigJCU2jcbZsfVIakzF = _4L7hfXrWoDdArQiscG4ukHCV46B.get_Content().Load<SpriteFont>("Assets/GUI/Fonts/Bold-26");
				num2 = (int)(num3 * 1570822138) ^ -566079902;
				continue;
			case 0u:
				Gui.get_Renderer().SetTexture("PhoneScreen", (object)_4L7hfXrWoDdArQiscG4ukHCV46B.get_Content().Load<Texture2D>("Assets/GUI/Phone/PhoneScreen"));
				num2 = ((int)num3 * -298488712) ^ -133536666;
				continue;
			case 19u:
				goto IL_07b3;
			default:
				{
					Gui.get_Renderer().SetTexture("MessageIconCooking", (object)_uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Cooking"));
					_g9Sx54kMPiHz5jrqWh4Kb1pTijH();
					return;
				}
				IL_0247:
				lRHDfpOTd4PxClZkjMpoakPEA9d2 = lRHDfpOTd4PxClZkjMpoakPEA9d;
				num2 = -1572588511;
				continue;
			}
			break;
		}
		goto IL_0499;
		IL_07c4:
		bool_ = (byte)num != 0;
		num2 = -1180433721;
		goto IL_0714;
	}

	protected virtual void _g9Sx54kMPiHz5jrqWh4Kb1pTijH()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		_xfiKuXXh5LQA9CUQiex6tutzFKQ = new EmptyScene(this);
		while (true)
		{
			int num = -1415530079;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB3B22942u) % 3u)
				{
				case 2u:
					goto IL_000e;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_000e:
				_Qj2G6fpAF4mGsATgkV8DPBF3aA1A._E7yBM68AWt7OGHJ5D6xYA8RK8tAA(new Color(0, 0, 0, 255));
				_OxLRmpxixplTKChiTPUKAx4uTLG<MainMenuScene>(delegate
				{
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_162(_Qj2G6fpAF4mGsATgkV8DPBF3aA1A, (Action)null);
				});
				num = (int)(num2 * 1010334779) ^ -280284173;
			}
		}
	}

	public void _wm1aB8mBRRffPWUAA0o5Xar2w5p()
	{
	}

	public void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Expected I4, but got Unknown
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0613: Unknown result type (might be due to invalid IL or missing references)
		if (_NdzU0m9x8QDKpVv3DrQmzY5KduB)
		{
			goto IL_01e1;
		}
		goto IL_0945;
		IL_0945:
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_51(_YNCmHGUHBydamu5BEECMWoB65VfA);
		int num;
		int num2;
		if (_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_52(_RbWJ7YGnYHCSoD44MRW1h5X6E7E, (Keys)164))
		{
			num = 1292749100;
			num2 = 1292749100;
		}
		else
		{
			num = 1183537914;
			num2 = 1183537914;
		}
		goto IL_083b;
		IL_083b:
		Point val = default(Point);
		List<KeyData> list = default(List<KeyData>);
		Action colBlKEOYSqQMmmj719vN58K9aN = default(Action);
		Keys? val2 = default(Keys?);
		Keys[] gylJZYyc3mVB0fbHPCctDIg4UAE = default(Keys[]);
		TimeSpan timeSpan = default(TimeSpan);
		Keys keys_ = default(Keys);
		int num6 = default(int);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0x695CA356u) % 58u)
			{
			case 57u:
			{
				int num19;
				int num20;
				if (_Z8BClcChRJrlB6tR1VPJcycVpHN == null)
				{
					num19 = 295077488;
					num20 = 295077488;
				}
				else
				{
					num19 = 1444986932;
					num20 = 1444986932;
				}
				num = num19 ^ ((int)num3 * -2041773198);
				continue;
			}
			case 56u:
				_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_59(_CCtbrNWS4Gi5hRSEsXYI5VzS7gI, gameTime_0);
				num = ((int)num3 * -2115349161) ^ -703836227;
				continue;
			case 55u:
				break;
			case 54u:
			{
				int num21;
				int num22;
				if (_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_53(_RbWJ7YGnYHCSoD44MRW1h5X6E7E, (Keys)123))
				{
					num21 = -1830489185;
					num22 = -1830489185;
				}
				else
				{
					num21 = -250740082;
					num22 = -250740082;
				}
				num = num21 ^ (int)(num3 * 609482731);
				continue;
			}
			case 53u:
				goto IL_00c4;
			case 52u:
				_Z8BClcChRJrlB6tR1VPJcycVpHN = null;
				_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_57(_xfiKuXXh5LQA9CUQiex6tutzFKQ);
				num = (int)((num3 * 1019600209) ^ 0x366890D5);
				continue;
			case 51u:
			{
				int num27;
				int num28;
				if (_ColBlKEOYSqQMmmj719vN58K9aN != null)
				{
					num27 = -1676047331;
					num28 = -1676047331;
				}
				else
				{
					num27 = -852811600;
					num28 = -852811600;
				}
				num = num27 ^ ((int)num3 * -115261842);
				continue;
			}
			case 50u:
				_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_75(val.X, val.Y, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_74(_RbWJ7YGnYHCSoD44MRW1h5X6E7E));
				num = (int)(num3 * 1198343682) ^ -273452577;
				continue;
			case 49u:
			{
				_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_61(_Ta8oiGRfjrRGtgUaA5S061UepZb, gameTime_0);
				int num9;
				int num10;
				if (!_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_62(_Ta8oiGRfjrRGtgUaA5S061UepZb))
				{
					num9 = 536689271;
					num10 = 536689271;
				}
				else
				{
					num9 = 408360404;
					num10 = 408360404;
				}
				num = num9 ^ (int)(num3 * 1656332886);
				continue;
			}
			case 48u:
				_9rxbJ7LsE3DhACUHVlPZaixc5Jp._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
				val = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_67(_chds2l0ZCMMghly7dv4eik3iSH5, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_66(_RbWJ7YGnYHCSoD44MRW1h5X6E7E));
				list = new List<KeyData>();
				num = 897077520;
				continue;
			case 47u:
				goto end_IL_083b;
			case 46u:
			{
				int num29;
				int num30;
				if (_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_53(_RbWJ7YGnYHCSoD44MRW1h5X6E7E, (Keys)112))
				{
					num29 = -1482203759;
					num30 = -1482203759;
				}
				else
				{
					num29 = -1452009840;
					num30 = -1452009840;
				}
				num = num29 ^ ((int)num3 * -500337575);
				continue;
			}
			case 45u:
				_RA1aFlOff0jGfI2cKUGhYI1MRLBA._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
				num = ((int)num3 * -359104776) ^ -1236531621;
				continue;
			case 44u:
				goto IL_023e;
			case 43u:
				_DNbNFzOKO7vtoVmjI32p1Snwmpe = !_DNbNFzOKO7vtoVmjI32p1Snwmpe;
				num = ((int)num3 * -1528672421) ^ -2046575483;
				continue;
			case 42u:
				_NdzU0m9x8QDKpVv3DrQmzY5KduB = false;
				num = ((int)num3 * -1263759968) ^ -1601062517;
				continue;
			case 41u:
				colBlKEOYSqQMmmj719vN58K9aN();
				num = ((int)num3 * -729117753) ^ 0x248B11CF;
				continue;
			case 40u:
				goto IL_02b7;
			case 39u:
				_SUHe9KzfAd477MCCYxTvqFf3efl._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0, _chds2l0ZCMMghly7dv4eik3iSH5);
				num = ((int)num3 * -2080586211) ^ -1007220959;
				continue;
			case 38u:
				_xfiKuXXh5LQA9CUQiex6tutzFKQ = _Z8BClcChRJrlB6tR1VPJcycVpHN;
				num = 496546158;
				continue;
			case 37u:
			{
				int num15;
				int num16;
				if (!val2.HasValue)
				{
					num15 = -1439881578;
					num16 = -1439881578;
				}
				else
				{
					num15 = -1871788394;
					num16 = -1871788394;
				}
				num = num15 ^ ((int)num3 * -623962202);
				continue;
			}
			case 36u:
				_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_54(_chds2l0ZCMMghly7dv4eik3iSH5, gameTime_0);
				num = 1112235007;
				continue;
			case 35u:
			{
				int num11;
				int num12;
				if (_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_53(_RbWJ7YGnYHCSoD44MRW1h5X6E7E, (Keys)13))
				{
					num11 = 1998319945;
					num12 = 1998319945;
				}
				else
				{
					num11 = 1499842116;
					num12 = 1499842116;
				}
				num = num11 ^ ((int)num3 * -578496225);
				continue;
			}
			case 34u:
				gylJZYyc3mVB0fbHPCctDIg4UAE = _gylJZYyc3mVB0fbHPCctDIg4UAE;
				num = ((int)num3 * -1767179344) ^ 0x52BF02E1;
				continue;
			case 33u:
				_6M30VBCyHzfi1RYZYx7uJAHl1EC._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
				_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_55(_6M30VBCyHzfi1RYZYx7uJAHl1EC);
				num = (int)((num3 * 619012499) ^ 0x1041E50B);
				continue;
			case 32u:
				Gui.set_TimeElapsed((float)timeSpan.Milliseconds);
				num = (int)(num3 * 1746801703) ^ -1725422590;
				continue;
			case 31u:
				goto IL_03f9;
			case 29u:
				_Ta8oiGRfjrRGtgUaA5S061UepZb = null;
				num = ((int)num3 * -55143554) ^ -1046278628;
				continue;
			case 27u:
				colBlKEOYSqQMmmj719vN58K9aN = _ColBlKEOYSqQMmmj719vN58K9aN;
				_ColBlKEOYSqQMmmj719vN58K9aN = null;
				num = (int)((num3 * 1581627711) ^ 0x1C11C7FA);
				continue;
			case 26u:
				_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_60(_P62DygY6CKZG8s5wqDu0uAFksjs, gameTime_0);
				num = ((int)num3 * -725616779) ^ 0x55687AD8;
				continue;
			case 25u:
				timeSpan = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_76(gameTime_0);
				num = (int)(num3 * 830052224) ^ -586349190;
				continue;
			case 24u:
				val2 = _o0Y4SOgMHY7iQXRQkPwaQ9pMBBl._HSj1lr89AFIB9adVhSrAeWjS1xC[_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_69(keys_)];
				num = 1475839839;
				continue;
			case 23u:
				num6 = 0;
				num = ((int)num3 * -358285875) ^ -1820061249;
				continue;
			case 22u:
				goto IL_04e5;
			case 21u:
				_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_65(_fp8jsuSnELXqf2yy2JQDaXDCBVQ, gameTime_0);
				num = ((int)num3 * -1813242959) ^ 0x6CA4C1BF;
				continue;
			case 20u:
			{
				int num25;
				int num26;
				if (_Z8BClcChRJrlB6tR1VPJcycVpHN != null)
				{
					num25 = -730505375;
					num26 = -730505375;
				}
				else
				{
					num25 = -1041389391;
					num26 = -1041389391;
				}
				num = num25 ^ (int)(num3 * 81904030);
				continue;
			}
			case 19u:
				_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_71(list.ToArray());
				num = ((int)num3 * -1338468215) ^ -71290712;
				continue;
			case 18u:
				goto IL_057d;
			case 17u:
				_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_58(_xfiKuXXh5LQA9CUQiex6tutzFKQ, gameTime_0);
				num = 985002778;
				continue;
			case 16u:
				list.Add(new KeyData
				{
					Scancode = (int)val2.Value,
					Char = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_70(keys_, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_52(_RbWJ7YGnYHCSoD44MRW1h5X6E7E, (Keys)160) || _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_52(_RbWJ7YGnYHCSoD44MRW1h5X6E7E, (Keys)161)),
					Pressed = flag2,
					Released = flag
				});
				num = 2052065856;
				continue;
			case 15u:
				_p3BLtW5bCDzTS86VFihe1pfwDoP._tiBFUHPEkedkbgvuX3whdeyjhKo();
				num = (int)((num3 * 1079727210) ^ 0x20CA93BE);
				continue;
			case 14u:
			{
				int num23;
				int num24;
				if (_p3BLtW5bCDzTS86VFihe1pfwDoP != null)
				{
					num23 = 699961613;
					num24 = 699961613;
				}
				else
				{
					num23 = 1700108176;
					num24 = 1700108176;
				}
				num = num23 ^ ((int)num3 * -165534436);
				continue;
			}
			case 13u:
				_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_73(new bool[2]
				{
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_72(_RbWJ7YGnYHCSoD44MRW1h5X6E7E, _PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton),
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_72(_RbWJ7YGnYHCSoD44MRW1h5X6E7E, _PMeRYZJaBCqgB9uADJFP3c14lxq.RightButton)
				});
				num = ((int)num3 * -739851756) ^ -1312965138;
				continue;
			case 12u:
			{
				int num17;
				int num18;
				if (flag)
				{
					num17 = 1947070840;
					num18 = 1947070840;
				}
				else
				{
					num17 = 1814969064;
					num18 = 1814969064;
				}
				num = num17 ^ (int)(num3 * 742772060);
				continue;
			}
			case 11u:
				_sUwMzXXmi9PdDQ0bFQhbGQJUPTe = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_63(_Ta8oiGRfjrRGtgUaA5S061UepZb, 5);
				num = (int)((num3 * 323834572) ^ 0x2EA1C3D1);
				continue;
			case 10u:
				num = ((int)num3 * -342914928) ^ -1735846045;
				continue;
			case 9u:
				goto IL_070c;
			case 8u:
			{
				int num13;
				int num14;
				if (_Ta8oiGRfjrRGtgUaA5S061UepZb != null)
				{
					num13 = 968556711;
					num14 = 968556711;
				}
				else
				{
					num13 = 1120128828;
					num14 = 1120128828;
				}
				num = num13 ^ (int)(num3 * 433537977);
				continue;
			}
			case 7u:
			{
				int num7;
				int num8;
				if (_xfiKuXXh5LQA9CUQiex6tutzFKQ != null)
				{
					num7 = 1724126706;
					num8 = 1724126706;
				}
				else
				{
					num7 = 1732160438;
					num8 = 1732160438;
				}
				num = num7 ^ (int)(num3 * 1920611464);
				continue;
			}
			case 6u:
				_qGU55VUfbqFJ4l6ArNW4JRcLekg();
				num = 836689157;
				continue;
			case 5u:
				_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_64(_ieTMbMiu3eGRdmzTMofKoJopZAf, gameTime_0);
				num = (int)((num3 * 822092251) ^ 0x11BD078D);
				continue;
			case 4u:
				_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_56(_xfiKuXXh5LQA9CUQiex6tutzFKQ);
				num = ((int)num3 * -1026380598) ^ -1419348298;
				continue;
			case 3u:
				_VN2LxjGLZldLNfiJ1OniiaXfYBg();
				num = 1086810706;
				continue;
			case 2u:
				num6++;
				num = 982615619;
				continue;
			case 1u:
				_Fs6y8qquj1mRHLz6xw6KoI4SAvH = !_Fs6y8qquj1mRHLz6xw6KoI4SAvH;
				num = (int)(num3 * 708841475) ^ -949201927;
				continue;
			case 0u:
			{
				int num4;
				int num5;
				if (!_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_53(_RbWJ7YGnYHCSoD44MRW1h5X6E7E, (Keys)44))
				{
					num4 = -1646610094;
					num5 = -1646610094;
				}
				else
				{
					num4 = -129505699;
					num5 = -129505699;
				}
				num = num4 ^ (int)(num3 * 1128755072);
				continue;
			}
			default:
				return;
			case 28u:
				goto IL_0945;
			case 30u:
				return;
			}
			int num31;
			if (_p3BLtW5bCDzTS86VFihe1pfwDoP != null)
			{
				num = 1086810706;
				num31 = 1086810706;
			}
			else
			{
				num = 472446608;
				num31 = 472446608;
			}
			continue;
			IL_070c:
			int num32;
			if (num6 >= gylJZYyc3mVB0fbHPCctDIg4UAE.Length)
			{
				num = 2052636901;
				num32 = 2052636901;
			}
			else
			{
				num = 1479752861;
				num32 = 1479752861;
			}
			continue;
			IL_03f9:
			keys_ = gylJZYyc3mVB0fbHPCctDIg4UAE[num6];
			flag2 = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_53(_RbWJ7YGnYHCSoD44MRW1h5X6E7E, keys_);
			flag = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_68(_RbWJ7YGnYHCSoD44MRW1h5X6E7E, keys_);
			int num33;
			if (!flag2)
			{
				num = 2120832944;
				num33 = 2120832944;
			}
			else
			{
				num = 1651753424;
				num33 = 1651753424;
			}
			continue;
			IL_023e:
			int num34;
			if (_ieTMbMiu3eGRdmzTMofKoJopZAf == null)
			{
				num = 443312778;
				num34 = 443312778;
			}
			else
			{
				num = 249975827;
				num34 = 249975827;
			}
			continue;
			IL_057d:
			int num35;
			if (_fp8jsuSnELXqf2yy2JQDaXDCBVQ != null)
			{
				num = 902380375;
				num35 = 902380375;
			}
			else
			{
				num = 315027982;
				num35 = 315027982;
			}
			continue;
			IL_02b7:
			int num36;
			if (_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_53(_RbWJ7YGnYHCSoD44MRW1h5X6E7E, (Keys)9))
			{
				num = 1802866919;
				num36 = 1802866919;
			}
			else
			{
				num = 1218115818;
				num36 = 1218115818;
			}
			continue;
			IL_00c4:
			int num37;
			if (_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_53(_RbWJ7YGnYHCSoD44MRW1h5X6E7E, (Keys)113))
			{
				num = 1509669726;
				num37 = 1509669726;
			}
			else
			{
				num = 836689157;
				num37 = 836689157;
			}
			continue;
			IL_04e5:
			int num38;
			if (_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_52(_RbWJ7YGnYHCSoD44MRW1h5X6E7E, (Keys)164))
			{
				num = 7535455;
				num38 = 7535455;
			}
			else
			{
				num = 2005240915;
				num38 = 2005240915;
			}
			continue;
			end_IL_083b:
			break;
		}
		goto IL_01e1;
		IL_01e1:
		num = 574457943;
		goto IL_083b;
	}

	public void _f5ctqAmdNsZ889UjM4LxDm8WGxA(GameTime gameTime_0)
	{
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_0688: Unknown result type (might be due to invalid IL or missing references)
		//IL_068d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_070a: Unknown result type (might be due to invalid IL or missing references)
		//IL_070f: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0beb: Unknown result type (might be due to invalid IL or missing references)
		TimeSpan timeSpan = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_77(gameTime_0);
		string path2 = default(string);
		string text = default(string);
		while (true)
		{
			int num = -371962026;
			while (true)
			{
				SpriteBatch zXUztyGtStF4WzGVig7wu43cfnf;
				SpriteFont xnYepZuegigJCU2jcbZsfVIakzF;
				object obj2;
				int num10;
				uint num2;
				int num15;
				switch ((num2 = (uint)num ^ 0xD4291E24u) % 47u)
				{
				case 46u:
					_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
					_ZXUztyGtStF4WzGVig7wu43cfnf.End();
					num = ((int)num2 * -1299399640) ^ 0x5217438E;
					continue;
				case 45u:
					_ieTMbMiu3eGRdmzTMofKoJopZAf._f5ctqAmdNsZ889UjM4LxDm8WGxA(_ZXUztyGtStF4WzGVig7wu43cfnf, _BuJyoOT5ylWcIMxjcKRnxVmYvBd);
					num = ((int)num2 * -1553957864) ^ -523322642;
					continue;
				case 44u:
				{
					int num8;
					if (_fp8jsuSnELXqf2yy2JQDaXDCBVQ != null)
					{
						num = -249253212;
						num8 = -249253212;
					}
					else
					{
						num = -410057498;
						num8 = -410057498;
					}
					continue;
				}
				case 43u:
					_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
					num = ((int)num2 * -1180511642) ^ -1665311492;
					continue;
				case 42u:
					_SUHe9KzfAd477MCCYxTvqFf3efl._f5ctqAmdNsZ889UjM4LxDm8WGxA(_ZXUztyGtStF4WzGVig7wu43cfnf, _BuJyoOT5ylWcIMxjcKRnxVmYvBd);
					num = (int)(num2 * 2022234760) ^ -181769053;
					continue;
				case 41u:
					_P62DygY6CKZG8s5wqDu0uAFksjs._f5ctqAmdNsZ889UjM4LxDm8WGxA(_ZXUztyGtStF4WzGVig7wu43cfnf);
					num = (int)((num2 * 1167162887) ^ 0x51399687);
					continue;
				case 40u:
					_ZXUztyGtStF4WzGVig7wu43cfnf._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, "Stage: " + _sUwMzXXmi9PdDQ0bFQhbGQJUPTe[1], _Vh2qdN4Ha62herl19def6PyuanQ, Color.get_White());
					num = (int)(num2 * 2116426696) ^ -1979220494;
					continue;
				case 39u:
				{
					int num18;
					if (_chds2l0ZCMMghly7dv4eik3iSH5._c3CMfxjIJAFFcSeEIluZOLANXnE)
					{
						num = -1814847592;
						num18 = -1814847592;
					}
					else
					{
						num = -292302625;
						num18 = -292302625;
					}
					continue;
				}
				case 38u:
				{
					_9rxbJ7LsE3DhACUHVlPZaixc5Jp._f5ctqAmdNsZ889UjM4LxDm8WGxA(_ZXUztyGtStF4WzGVig7wu43cfnf);
					int num9;
					if (_Fs6y8qquj1mRHLz6xw6KoI4SAvH)
					{
						num = -1505080066;
						num9 = -1505080066;
					}
					else
					{
						num = -984704490;
						num9 = -984704490;
					}
					continue;
				}
				case 37u:
					_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
					num = (int)(num2 * 353568100) ^ -1944287064;
					continue;
				case 36u:
					_4L7hfXrWoDdArQiscG4ukHCV46B.get_GraphicsDevice().Clear(Color.get_Black());
					num = (int)(num2 * 604344262) ^ -1411203564;
					continue;
				case 35u:
					_ZXUztyGtStF4WzGVig7wu43cfnf._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, "Press Tab to toggle", _Vh2qdN4Ha62herl19def6PyuanQ, Color.get_White());
					num = (int)(num2 * 967663) ^ -1693250914;
					continue;
				case 34u:
				{
					_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
					int num19;
					int num20;
					if (_sUwMzXXmi9PdDQ0bFQhbGQJUPTe != null)
					{
						num19 = -1805284561;
						num20 = -1805284561;
					}
					else
					{
						num19 = -1837332;
						num20 = -1837332;
					}
					num = num19 ^ ((int)num2 * -2136247421);
					continue;
				}
				case 33u:
				{
					int num16;
					int num17;
					if (Directory.Exists("Screenshots"))
					{
						num16 = 1095245849;
						num17 = 1095245849;
					}
					else
					{
						num16 = 203018495;
						num17 = 203018495;
					}
					num = num16 ^ (int)(num2 * 876730852);
					continue;
				}
				case 32u:
					_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
					num = ((int)num2 * -426367921) ^ 0x48B68F4C;
					continue;
				case 31u:
					_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
					_ZXUztyGtStF4WzGVig7wu43cfnf._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, string.Format("Cutscene in progress: {0}", (_Ta8oiGRfjrRGtgUaA5S061UepZb == null) ? "No" : "Yes"), _Vh2qdN4Ha62herl19def6PyuanQ, Color.get_White());
					num = -183246254;
					continue;
				case 30u:
					_ZXUztyGtStF4WzGVig7wu43cfnf._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, "Cutscene: None", _Vh2qdN4Ha62herl19def6PyuanQ, Color.get_White());
					num = (int)((num2 * 967999982) ^ 0x4E9FAC4E);
					continue;
				case 29u:
					_ZXUztyGtStF4WzGVig7wu43cfnf._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, "Cutscene: " + _sUwMzXXmi9PdDQ0bFQhbGQJUPTe[0], _Vh2qdN4Ha62herl19def6PyuanQ, Color.get_White());
					num = -388515812;
					continue;
				case 28u:
				{
					_xfiKuXXh5LQA9CUQiex6tutzFKQ._f5ctqAmdNsZ889UjM4LxDm8WGxA(_ZXUztyGtStF4WzGVig7wu43cfnf, _BuJyoOT5ylWcIMxjcKRnxVmYvBd, _chds2l0ZCMMghly7dv4eik3iSH5._oLRK3f26Sw9AKBKi0iR44APDZEt);
					int num23;
					int num24;
					if (_chds2l0ZCMMghly7dv4eik3iSH5._q1DGEI79OguKnK8dCIgPvfGc9Bi)
					{
						num23 = -1366246021;
						num24 = -1366246021;
					}
					else
					{
						num23 = -1422893065;
						num24 = -1422893065;
					}
					num = num23 ^ ((int)num2 * -978229710);
					continue;
				}
				case 27u:
					_ZXUztyGtStF4WzGVig7wu43cfnf.Begin();
					num = ((int)num2 * -1723233824) ^ -1974106882;
					continue;
				case 26u:
				{
					_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
					SpriteBatch zXUztyGtStF4WzGVig7wu43cfnf2 = _ZXUztyGtStF4WzGVig7wu43cfnf;
					SpriteFont xnYepZuegigJCU2jcbZsfVIakzF2 = _xnYepZuegigJCU2jcbZsfVIakzF;
					Color sWODlbUkQEqfwrtprjLPOeGF7HO = _RA1aFlOff0jGfI2cKUGhYI1MRLBA._SWODlbUkQEqfwrtprjLPOeGF7HO;
					zXUztyGtStF4WzGVig7wu43cfnf2._FY70IFLoBond3ORPe0ndCLvIeVcA(xnYepZuegigJCU2jcbZsfVIakzF2, "ScreenFader: " + ((Color)(ref sWODlbUkQEqfwrtprjLPOeGF7HO)).get_A(), _Vh2qdN4Ha62herl19def6PyuanQ, Color.get_White());
					_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
					num = ((int)num2 * -1416497604) ^ 0x4BD3A0B;
					continue;
				}
				case 25u:
					num = (int)(num2 * 2089833203) ^ -457574660;
					continue;
				case 24u:
					path2 = $"Screenshots/screenshot-{DateTime.Now.DayOfYear}{DateTime.Now.Hour}{DateTime.Now.Minute}{DateTime.Now.Second}.png";
					num = -104092216;
					continue;
				case 23u:
					_xfiKuXXh5LQA9CUQiex6tutzFKQ._Z70nK2EA1n5FNJxjWP0TzHQ0Lzb(_ZXUztyGtStF4WzGVig7wu43cfnf);
					num = -1782401395;
					continue;
				case 22u:
					text = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, path2);
					num = (int)((num2 * 802289184) ^ 0x64391832);
					continue;
				case 21u:
					_qZ4p0zzU9dj7bhTFunYbFjSNY6D = false;
					num = (int)(num2 * 11096847) ^ -2055961186;
					continue;
				case 20u:
				{
					_RA1aFlOff0jGfI2cKUGhYI1MRLBA._f5ctqAmdNsZ889UjM4LxDm8WGxA(_ZXUztyGtStF4WzGVig7wu43cfnf, _chds2l0ZCMMghly7dv4eik3iSH5);
					int num21;
					int num22;
					if (_DNbNFzOKO7vtoVmjI32p1Snwmpe)
					{
						num21 = 1522959562;
						num22 = 1522959562;
					}
					else
					{
						num21 = 1379509935;
						num22 = 1379509935;
					}
					num = num21 ^ ((int)num2 * -1909223177);
					continue;
				}
				case 19u:
					_xfiKuXXh5LQA9CUQiex6tutzFKQ._f5ctqAmdNsZ889UjM4LxDm8WGxA(_ZXUztyGtStF4WzGVig7wu43cfnf, _BuJyoOT5ylWcIMxjcKRnxVmYvBd, _chds2l0ZCMMghly7dv4eik3iSH5._MPYpHIXdfUjJipVgAvBCGASJZiZ);
					num = ((int)num2 * -2037781767) ^ 0x3C49D703;
					continue;
				case 18u:
					_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
					num = -680336953;
					continue;
				case 17u:
					_Vh2qdN4Ha62herl19def6PyuanQ.X = 10f;
					_Vh2qdN4Ha62herl19def6PyuanQ.Y = 10f;
					num = -1216090790;
					continue;
				case 16u:
				{
					_ZXUztyGtStF4WzGVig7wu43cfnf._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, "[Generic]", _Vh2qdN4Ha62herl19def6PyuanQ, Color.get_White());
					_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
					zXUztyGtStF4WzGVig7wu43cfnf = _ZXUztyGtStF4WzGVig7wu43cfnf;
					xnYepZuegigJCU2jcbZsfVIakzF = _xnYepZuegigJCU2jcbZsfVIakzF;
					_7UlnfykmEmZDFt3BmCKZekI43Ih xfiKuXXh5LQA9CUQiex6tutzFKQ2 = _xfiKuXXh5LQA9CUQiex6tutzFKQ;
					if (xfiKuXXh5LQA9CUQiex6tutzFKQ2 == null)
					{
						obj2 = null;
					}
					else
					{
						obj2 = xfiKuXXh5LQA9CUQiex6tutzFKQ2.GetType().Name;
						if (obj2 != null)
						{
							goto IL_0682;
						}
					}
					obj2 = "None";
					goto IL_0682;
				}
				case 15u:
					_xfiKuXXh5LQA9CUQiex6tutzFKQ._f5ctqAmdNsZ889UjM4LxDm8WGxA(_ZXUztyGtStF4WzGVig7wu43cfnf, _BuJyoOT5ylWcIMxjcKRnxVmYvBd, _chds2l0ZCMMghly7dv4eik3iSH5._00mMjYnrMXUVj1aA8AYlqz1bdTI);
					num = (int)(num2 * 973057743) ^ -1545628498;
					continue;
				case 14u:
					_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
					_ZXUztyGtStF4WzGVig7wu43cfnf._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, "Path: " + _sUwMzXXmi9PdDQ0bFQhbGQJUPTe[2], _Vh2qdN4Ha62herl19def6PyuanQ, Color.get_White());
					num = ((int)num2 * -196152892) ^ -1534725173;
					continue;
				case 13u:
					Directory.CreateDirectory("Screenshots");
					num = ((int)num2 * -1602079445) ^ -1623230192;
					continue;
				case 12u:
					_4L7hfXrWoDdArQiscG4ukHCV46B.get_GraphicsDevice().SetRenderTarget(_j2ynkEUaNLywHdchuAYJWHF3l9DA);
					num = (int)((num2 * 796788392) ^ 0x6518824);
					continue;
				case 10u:
					if (_qZ4p0zzU9dj7bhTFunYbFjSNY6D)
					{
						num = -1386771258;
						continue;
					}
					goto IL_0c5f;
				case 9u:
					_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
					num = ((int)num2 * -1960956960) ^ -594506121;
					continue;
				case 8u:
					_ZXUztyGtStF4WzGVig7wu43cfnf._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, "Current: " + _sUwMzXXmi9PdDQ0bFQhbGQJUPTe[3], _Vh2qdN4Ha62herl19def6PyuanQ, Color.get_White());
					num = ((int)num2 * -1157406634) ^ 0x6276C078;
					continue;
				case 7u:
				{
					int num7;
					if (!_DNbNFzOKO7vtoVmjI32p1Snwmpe)
					{
						num = -429747253;
						num7 = -429747253;
					}
					else
					{
						num = -872806919;
						num7 = -872806919;
					}
					continue;
				}
				case 6u:
					_fp8jsuSnELXqf2yy2JQDaXDCBVQ._f5ctqAmdNsZ889UjM4LxDm8WGxA(_ZXUztyGtStF4WzGVig7wu43cfnf);
					num = (int)((num2 * 2096639923) ^ 0x60B41966);
					continue;
				case 5u:
					_boyt8NIMtKsAGSTcjHeL0WMbFxs._AmIUCcrmrrQiiirja7DoiZSjXuv = (float)timeSpan.TotalSeconds;
					num = ((int)num2 * -1457754414) ^ 0xB2D7AC;
					continue;
				case 4u:
				{
					int num6;
					if (_ieTMbMiu3eGRdmzTMofKoJopZAf != null)
					{
						num = -489300699;
						num6 = -489300699;
					}
					else
					{
						num = -1186431242;
						num6 = -1186431242;
					}
					continue;
				}
				case 3u:
					_sUwMzXXmi9PdDQ0bFQhbGQJUPTe = _Ta8oiGRfjrRGtgUaA5S061UepZb._YYH5zlVZSFq4tPfc1vfadAxnqhV(5);
					num = (int)(num2 * 1245693354) ^ -2141270816;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (_Ta8oiGRfjrRGtgUaA5S061UepZb == null)
					{
						num4 = -550911862;
						num5 = -550911862;
					}
					else
					{
						num4 = -2142654210;
						num5 = -2142654210;
					}
					num = num4 ^ (int)(num2 * 916180697);
					continue;
				}
				case 1u:
					_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
					_ZXUztyGtStF4WzGVig7wu43cfnf._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, "[Cutscenes]", _Vh2qdN4Ha62herl19def6PyuanQ, Color.get_White());
					num = ((int)num2 * -17505117) ^ -1385591749;
					continue;
				case 11u:
					break;
				default:
					{
						Stream stream = File.OpenWrite(text);
						try
						{
							((Texture2D)_j2ynkEUaNLywHdchuAYJWHF3l9DA).SaveAsPng(stream, ((Texture2D)_j2ynkEUaNLywHdchuAYJWHF3l9DA).get_Width(), ((Texture2D)_j2ynkEUaNLywHdchuAYJWHF3l9DA).get_Height());
						}
						finally
						{
							if (stream != null)
							{
								while (true)
								{
									IL_0a4e:
									int num3 = -1022974275;
									while (true)
									{
										switch ((num2 = (uint)num3 ^ 0xD4291E24u) % 3u)
										{
										case 2u:
											goto IL_0a1b;
										default:
											goto end_IL_0a30;
										case 0u:
											break;
										case 1u:
											goto end_IL_0a30;
										}
										goto IL_0a4e;
										IL_0a1b:
										((IDisposable)stream).Dispose();
										num3 = (int)(num2 * 1114362052) ^ -1770319822;
										continue;
										end_IL_0a30:
										break;
									}
									break;
								}
							}
						}
						if (_p3BLtW5bCDzTS86VFihe1pfwDoP != null)
						{
							goto IL_0af1;
						}
						goto IL_0c05;
					}
					IL_0c5f:
					_4L7hfXrWoDdArQiscG4ukHCV46B.get_GraphicsDevice().SetRenderTarget((RenderTarget2D)null);
					num10 = -538569233;
					goto IL_0c24;
					IL_0c24:
					while (true)
					{
						string path;
						object[] array;
						object obj;
						switch ((num2 = (uint)num10 ^ 0xD4291E24u) % 10u)
						{
						case 9u:
							_p3BLtW5bCDzTS86VFihe1pfwDoP._9K6cA2OPGJaecqk3spsceT9ilNI(text, ((Texture2D)_j2ynkEUaNLywHdchuAYJWHF3l9DA).get_Width(), ((Texture2D)_j2ynkEUaNLywHdchuAYJWHF3l9DA).get_Height());
							num10 = ((int)num2 * -2091262615) ^ 0x234E6AB0;
							continue;
						case 8u:
						{
							int num11;
							int num12;
							if (_sUwMzXXmi9PdDQ0bFQhbGQJUPTe == null)
							{
								num11 = 212958270;
								num12 = 212958270;
							}
							else
							{
								num11 = 1573564980;
								num12 = 1573564980;
							}
							num10 = num11 ^ (int)(num2 * 799446663);
							continue;
						}
						case 7u:
							_4L7hfXrWoDdArQiscG4ukHCV46B.get_GraphicsDevice().Clear(Color.get_Black());
							num10 = ((int)num2 * -2052117716) ^ -1831964065;
							continue;
						case 6u:
							break;
						case 5u:
						{
							_ZXUztyGtStF4WzGVig7wu43cfnf.Begin();
							_ZXUztyGtStF4WzGVig7wu43cfnf.Draw((Texture2D)(object)_j2ynkEUaNLywHdchuAYJWHF3l9DA, _CCbe95wREA1VhjgpntSpzsQ19He, Color.get_White());
							int num13;
							int num14;
							if (_LWcoDwIWvf8DT3nQmNe5z8fkUvI)
							{
								num13 = -1668990933;
								num14 = -1668990933;
							}
							else
							{
								num13 = -1568581044;
								num14 = -1568581044;
							}
							num10 = num13 ^ ((int)num2 * -1998195590);
							continue;
						}
						case 4u:
						{
							path = $"{text}.txt";
							array = new object[5];
							_7UlnfykmEmZDFt3BmCKZekI43Ih xfiKuXXh5LQA9CUQiex6tutzFKQ = _xfiKuXXh5LQA9CUQiex6tutzFKQ;
							if (xfiKuXXh5LQA9CUQiex6tutzFKQ == null)
							{
								obj = null;
							}
							else
							{
								obj = xfiKuXXh5LQA9CUQiex6tutzFKQ.GetType().Name;
								if (obj != null)
								{
									goto IL_0b8b;
								}
							}
							obj = "None";
							goto IL_0b8b;
						}
						case 3u:
							_ZXUztyGtStF4WzGVig7wu43cfnf.Draw(_0SvmBhkBX8SImQwyvuy5xVObqLn, _RbWJ7YGnYHCSoD44MRW1h5X6E7E._6M9HDt28e1QHBuYsAXgqiY8jVlA, _CCtbrNWS4Gi5hRSEsXYI5VzS7gI._Hnb6mPvrZFgOMCIApIeMW88jSsF._uOkbmfW26QVAvyEMQakki9kTMDbA);
							num10 = (int)(num2 * 1152200583) ^ -1871734155;
							continue;
						case 1u:
							goto IL_0c05;
						case 0u:
							goto IL_0c5f;
						default:
							{
								_ZXUztyGtStF4WzGVig7wu43cfnf.End();
								return;
							}
							IL_0b8b:
							array[0] = obj;
							array[1] = _sUwMzXXmi9PdDQ0bFQhbGQJUPTe[0];
							array[2] = _sUwMzXXmi9PdDQ0bFQhbGQJUPTe[1];
							array[3] = _sUwMzXXmi9PdDQ0bFQhbGQJUPTe[2];
							array[4] = _sUwMzXXmi9PdDQ0bFQhbGQJUPTe[3];
							File.WriteAllText(path, string.Format("Scene: {0}\r\nCutscene: {1}\r\nStage: {2}\r\nPath: {3}\r\nCurrent: {4}", array));
							num10 = -1121899480;
							continue;
						}
						break;
					}
					goto IL_0af1;
					IL_0c05:
					if (_Fs6y8qquj1mRHLz6xw6KoI4SAvH)
					{
						num10 = -813506402;
						num15 = -813506402;
					}
					else
					{
						num10 = -1121899480;
						num15 = -1121899480;
					}
					goto IL_0c24;
					IL_0af1:
					num10 = -1041267901;
					goto IL_0c24;
					IL_0682:
					zXUztyGtStF4WzGVig7wu43cfnf._FY70IFLoBond3ORPe0ndCLvIeVcA(xnYepZuegigJCU2jcbZsfVIakzF, "Scene: " + (string?)obj2, _Vh2qdN4Ha62herl19def6PyuanQ, Color.get_White());
					num = -1120367994;
					continue;
				}
				break;
			}
		}
	}

	public void _qGU55VUfbqFJ4l6ArNW4JRcLekg()
	{
		_fSRUnXzLhUs3DfJ1lzl9dGCEmCf(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_78(_chds2l0ZCMMghly7dv4eik3iSH5), _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_79(_chds2l0ZCMMghly7dv4eik3iSH5), !_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_3(_ARAAkijJ1FF23wI2rNDaw7mTOeJ));
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
				_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_80(string_0);
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
		_fSRUnXzLhUs3DfJ1lzl9dGCEmCf(int_0, int_1, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_3(_ARAAkijJ1FF23wI2rNDaw7mTOeJ));
	}

	public void _fSRUnXzLhUs3DfJ1lzl9dGCEmCf(int int_0, int int_1, bool bool_0)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_6(_ARAAkijJ1FF23wI2rNDaw7mTOeJ, bool_0);
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_7(_ARAAkijJ1FF23wI2rNDaw7mTOeJ, bool_0 ? _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_17(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_16(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_15())) : int_0);
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_8(_ARAAkijJ1FF23wI2rNDaw7mTOeJ, bool_0 ? _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_18(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_16(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_15())) : int_1);
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_81(_ARAAkijJ1FF23wI2rNDaw7mTOeJ).set_Viewport(new Viewport(0, 0, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_43(_ARAAkijJ1FF23wI2rNDaw7mTOeJ), _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_44(_ARAAkijJ1FF23wI2rNDaw7mTOeJ)));
		while (true)
		{
			int num = 996637542;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2DF42226u) % 5u)
				{
				case 4u:
					_CCbe95wREA1VhjgpntSpzsQ19He = new Rectangle(_chds2l0ZCMMghly7dv4eik3iSH5._jDxCg7GJnIKcLXDcUVSdbEIQL3Yb, _chds2l0ZCMMghly7dv4eik3iSH5._ILCBrSipj1Qk4CsYzkEELxHvkkY, _chds2l0ZCMMghly7dv4eik3iSH5._HZrLDiX4EPtS6jM8Odd9yJAatHq, _chds2l0ZCMMghly7dv4eik3iSH5._ypqaDJqrkQlUKOrdZIXld5qQQ4x);
					num = ((int)num2 * -758191103) ^ 0x258E1D7E;
					continue;
				case 3u:
					_ARAAkijJ1FF23wI2rNDaw7mTOeJ.ApplyChanges();
					num = ((int)num2 * -1324403480) ^ 0x107A3F3E;
					continue;
				case 2u:
					_chds2l0ZCMMghly7dv4eik3iSH5._2lMgp1KOzK9I6kd7CHrDq2A2CHm(int_0, int_1, _ARAAkijJ1FF23wI2rNDaw7mTOeJ.get_PreferredBackBufferWidth(), _ARAAkijJ1FF23wI2rNDaw7mTOeJ.get_PreferredBackBufferHeight());
					num = (int)((num2 * 1106318613) ^ 0x59D13E7);
					continue;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public void _udfEpcIRn7lWl5Lvjdyu0aG0A7G()
	{
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_82(_4L7hfXrWoDdArQiscG4ukHCV46B);
	}

	public void _k9wUPeU1Ga7cygiuGP8TT6aPLWF<T>() where T : _7UlnfykmEmZDFt3BmCKZekI43Ih
	{
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_83(_RA1aFlOff0jGfI2cKUGhYI1MRLBA, (Action)delegate
		{
			_OxLRmpxixplTKChiTPUKAx4uTLG<T>(delegate
			{
				_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_162(_RA1aFlOff0jGfI2cKUGhYI1MRLBA, (Action)null);
			});
		});
	}

	public void _k9wUPeU1Ga7cygiuGP8TT6aPLWF(string string_0)
	{
		string _n6iPJ4jnSQTmNXcr3d8lbsKKvZl = default(string);
		_bj8iyyk84DtxcxcHgAHHFGgq8oN _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = default(_bj8iyyk84DtxcxcHgAHHFGgq8oN);
		while (true)
		{
			int num = 1143888477;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x79509B0Fu) % 5u)
				{
				case 3u:
					_n6iPJ4jnSQTmNXcr3d8lbsKKvZl = string_0;
					num = (int)((num2 * 241462415) ^ 0x2C11C071);
					continue;
				case 2u:
					_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = this;
					num = (int)((num2 * 1186070875) ^ 0x61A9AB7D);
					continue;
				case 1u:
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_83(_RA1aFlOff0jGfI2cKUGhYI1MRLBA, (Action)delegate
					{
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._OxLRmpxixplTKChiTPUKAx4uTLG(_n6iPJ4jnSQTmNXcr3d8lbsKKvZl, delegate
						{
							_9rqW5HzG3UXapFpEBDu18BZJznG.smethod_0(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._RA1aFlOff0jGfI2cKUGhYI1MRLBA, (Action)null);
						});
					});
					num = ((int)num2 * -1707239059) ^ 0x3F1FBD62;
					continue;
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

	public void _k9wUPeU1Ga7cygiuGP8TT6aPLWF(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		_bj8iyyk84DtxcxcHgAHHFGgq8oN _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = default(_bj8iyyk84DtxcxcHgAHHFGgq8oN);
		_7UlnfykmEmZDFt3BmCKZekI43Ih _RJTGWz7KqClGKVJa614391g5XSF = default(_7UlnfykmEmZDFt3BmCKZekI43Ih);
		while (true)
		{
			int num = -1113593859;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE7E1F1C0u) % 4u)
				{
				case 1u:
					_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = this;
					_RJTGWz7KqClGKVJa614391g5XSF = _7UlnfykmEmZDFt3BmCKZekI43Ih_0;
					num = ((int)num2 * -2096183849) ^ -708507373;
					continue;
				case 0u:
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_83(_RA1aFlOff0jGfI2cKUGhYI1MRLBA, (Action)delegate
					{
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._OxLRmpxixplTKChiTPUKAx4uTLG(_RJTGWz7KqClGKVJa614391g5XSF, delegate
						{
							_cHlGOT3sD7LBx6eSMMmMOdLnHjd.smethod_0(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._RA1aFlOff0jGfI2cKUGhYI1MRLBA, (Action)null);
						});
					});
					num = (int)((num2 * 1486585541) ^ 0x438920BB);
					continue;
				default:
					return;
				case 2u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public void _OxLRmpxixplTKChiTPUKAx4uTLG<T>(Action action_0 = null) where T : _7UlnfykmEmZDFt3BmCKZekI43Ih
	{
		if (_ColBlKEOYSqQMmmj719vN58K9aN != null)
		{
			goto IL_009f;
		}
		goto IL_00d1;
		IL_00d1:
		_ColBlKEOYSqQMmmj719vN58K9aN = action_0;
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_84(_chds2l0ZCMMghly7dv4eik3iSH5);
		int num = 1752504554;
		goto IL_00a4;
		IL_00a4:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x42C2AF50u) % 7u)
			{
			case 6u:
				_NdzU0m9x8QDKpVv3DrQmzY5KduB = true;
				num = ((int)num2 * -1609038866) ^ 0x36099C9;
				continue;
			case 5u:
				_ieTMbMiu3eGRdmzTMofKoJopZAf = null;
				_Z8BClcChRJrlB6tR1VPJcycVpHN = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_86(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_37(typeof(T).TypeHandle), new object[1] { this }) as _7UlnfykmEmZDFt3BmCKZekI43Ih;
				num = ((int)num2 * -706341039) ^ -1054042096;
				continue;
			case 4u:
			{
				Action colBlKEOYSqQMmmj719vN58K9aN = _ColBlKEOYSqQMmmj719vN58K9aN;
				_ColBlKEOYSqQMmmj719vN58K9aN = null;
				colBlKEOYSqQMmmj719vN58K9aN();
				num = (int)(num2 * 1773023327) ^ -662351063;
				continue;
			}
			case 3u:
				_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_85((_21uBmerICJi18moE2gpxlEipBgz)null);
				_fp8jsuSnELXqf2yy2JQDaXDCBVQ = null;
				num = ((int)num2 * -314170163) ^ 0x639B989D;
				continue;
			case 2u:
				break;
			default:
				return;
			case 0u:
				goto IL_00d1;
			case 1u:
				return;
			}
			break;
		}
		goto IL_009f;
		IL_009f:
		num = 887131024;
		goto IL_00a4;
	}

	public void _OxLRmpxixplTKChiTPUKAx4uTLG(string string_0, Action action_0 = null)
	{
		Action colBlKEOYSqQMmmj719vN58K9aN = default(Action);
		Type type_ = default(Type);
		while (true)
		{
			int num = -14323111;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x96E24154u) % 12u)
				{
				case 11u:
					_NdzU0m9x8QDKpVv3DrQmzY5KduB = true;
					num = ((int)num2 * -1752062405) ^ 0x2EAF9556;
					continue;
				case 10u:
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_84(_chds2l0ZCMMghly7dv4eik3iSH5);
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_85((_21uBmerICJi18moE2gpxlEipBgz)null);
					_fp8jsuSnELXqf2yy2JQDaXDCBVQ = null;
					_ieTMbMiu3eGRdmzTMofKoJopZAf = null;
					num = -307152360;
					continue;
				case 9u:
					_ColBlKEOYSqQMmmj719vN58K9aN = null;
					colBlKEOYSqQMmmj719vN58K9aN();
					num = ((int)num2 * -1578769970) ^ -1273002756;
					continue;
				case 7u:
				{
					IEnumerable<Type> source = from type_0 in _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_88(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_87(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_37(typeof(_bj8iyyk84DtxcxcHgAHHFGgq8oN).TypeHandle)))
						where _PzOBAEclhQj3NzBZIEIMnKCuYsr.smethod_3(_PzOBAEclhQj3NzBZIEIMnKCuYsr.smethod_2(typeof(_7UlnfykmEmZDFt3BmCKZekI43Ih).TypeHandle), type_0)
						select type_0;
					type_ = source.FirstOrDefault((Type type_0) => _AsW3kNzx3Ky1kSe2GNlryDfK39C.smethod_1(_AsW3kNzx3Ky1kSe2GNlryDfK39C.smethod_0((MemberInfo)type_0), string_0));
					int num5;
					if (!_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_89(type_, (Type)null))
					{
						num = -127380142;
						num5 = -127380142;
					}
					else
					{
						num = -1339048916;
						num5 = -1339048916;
					}
					continue;
				}
				case 6u:
					_ColBlKEOYSqQMmmj719vN58K9aN = action_0;
					num = -1779432125;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (_ColBlKEOYSqQMmmj719vN58K9aN != null)
					{
						num3 = -1831147500;
						num4 = -1831147500;
					}
					else
					{
						num3 = -670184508;
						num4 = -670184508;
					}
					num = num3 ^ ((int)num2 * -1254831874);
					continue;
				}
				case 4u:
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_90("Failed to load scene '{0}'", new object[1] { string_0 });
					num = (int)((num2 * 1067897700) ^ 0x12434BD);
					continue;
				case 2u:
					colBlKEOYSqQMmmj719vN58K9aN = _ColBlKEOYSqQMmmj719vN58K9aN;
					num = ((int)num2 * -1739743528) ^ -750456835;
					continue;
				case 0u:
					_Z8BClcChRJrlB6tR1VPJcycVpHN = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_86(type_, new object[1] { this }) as _7UlnfykmEmZDFt3BmCKZekI43Ih;
					num = ((int)num2 * -29830680) ^ -1364523445;
					continue;
				default:
					return;
				case 8u:
					break;
				case 1u:
					return;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public void _OxLRmpxixplTKChiTPUKAx4uTLG(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, Action action_0 = null)
	{
		if (_ColBlKEOYSqQMmmj719vN58K9aN != null)
		{
			goto IL_009c;
		}
		goto IL_00f1;
		IL_00f1:
		_ColBlKEOYSqQMmmj719vN58K9aN = action_0;
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_84(_chds2l0ZCMMghly7dv4eik3iSH5);
		int num = 1118147066;
		goto IL_00b7;
		IL_00b7:
		Action colBlKEOYSqQMmmj719vN58K9aN = default(Action);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x1C0001Fu) % 10u)
			{
			case 9u:
				_NdzU0m9x8QDKpVv3DrQmzY5KduB = true;
				num = (int)((num2 * 1852534961) ^ 0x6A24139B);
				continue;
			case 8u:
				colBlKEOYSqQMmmj719vN58K9aN = _ColBlKEOYSqQMmmj719vN58K9aN;
				_ColBlKEOYSqQMmmj719vN58K9aN = null;
				num = (int)(num2 * 252576352) ^ -895635056;
				continue;
			case 7u:
				_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_85((_21uBmerICJi18moE2gpxlEipBgz)null);
				num = ((int)num2 * -1382831309) ^ -1469640292;
				continue;
			case 6u:
				_fp8jsuSnELXqf2yy2JQDaXDCBVQ = null;
				num = ((int)num2 * -754483466) ^ 0x1A6706F1;
				continue;
			case 5u:
				colBlKEOYSqQMmmj719vN58K9aN();
				num = ((int)num2 * -1115139171) ^ 0x1472B84B;
				continue;
			case 4u:
				_Z8BClcChRJrlB6tR1VPJcycVpHN = _7UlnfykmEmZDFt3BmCKZekI43Ih_0;
				num = ((int)num2 * -340956627) ^ -2090212692;
				continue;
			case 2u:
				break;
			case 0u:
				_ieTMbMiu3eGRdmzTMofKoJopZAf = null;
				num = ((int)num2 * -2050924541) ^ -419896763;
				continue;
			default:
				return;
			case 1u:
				goto IL_00f1;
			case 3u:
				return;
			}
			break;
		}
		goto IL_009c;
		IL_009c:
		num = 487705115;
		goto IL_00b7;
	}

	public void _gYGB98heFqsLp9tgJbdCP01IKV2(string string_0)
	{
		Type type_ = default(Type);
		string _n6iPJ4jnSQTmNXcr3d8lbsKKvZl = default(string);
		while (true)
		{
			int num = -512526977;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE28D7C6Au) % 7u)
				{
				case 6u:
				{
					int num3;
					int num4;
					if (!_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_89(type_, (Type)null))
					{
						num3 = 337861588;
						num4 = 337861588;
					}
					else
					{
						num3 = 1316591659;
						num4 = 1316591659;
					}
					num = num3 ^ (int)(num2 * 1914740927);
					continue;
				}
				case 4u:
					_ieTMbMiu3eGRdmzTMofKoJopZAf = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_86(type_, new object[1] { _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_2(_4L7hfXrWoDdArQiscG4ukHCV46B) }) as _TwlwMC1hhdSzamwGWEBxuUkz1gH;
					num = -577121870;
					continue;
				case 2u:
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_90("Failed to load sexscene '{0}'", new object[1] { _n6iPJ4jnSQTmNXcr3d8lbsKKvZl });
					num = (int)(num2 * 889884693) ^ -200396085;
					continue;
				case 1u:
				{
					_n6iPJ4jnSQTmNXcr3d8lbsKKvZl = string_0;
					IEnumerable<Type> source = from type_0 in _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_88(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_87(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_37(typeof(_bj8iyyk84DtxcxcHgAHHFGgq8oN).TypeHandle)))
						where _PzOBAEclhQj3NzBZIEIMnKCuYsr.smethod_3(_PzOBAEclhQj3NzBZIEIMnKCuYsr.smethod_2(typeof(_TwlwMC1hhdSzamwGWEBxuUkz1gH).TypeHandle), type_0)
						select type_0;
					type_ = source.FirstOrDefault((Type type_0) => _FzfT43cjHYNexO7AyOgI7RzVHys.smethod_1(_FzfT43cjHYNexO7AyOgI7RzVHys.smethod_0((MemberInfo)type_0), _n6iPJ4jnSQTmNXcr3d8lbsKKvZl));
					num = -399163110;
					continue;
				}
				default:
					return;
				case 0u:
					break;
				case 3u:
					return;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	public void _Ec0fhBrUGmjaIKjUfJioigVc65x()
	{
		_ieTMbMiu3eGRdmzTMofKoJopZAf = null;
	}

	public void _xyl3Tv5KdR5eezDgagxbBcS3cwt(string string_0)
	{
		_nR8eroJOHehP0ZGyyTveo6aMTHg nR8eroJOHehP0ZGyyTveo6aMTHg_ = _5yVCuTv9lVSCCxs7cUlv79ysuRh(string_0);
		_xyl3Tv5KdR5eezDgagxbBcS3cwt(nR8eroJOHehP0ZGyyTveo6aMTHg_);
	}

	public void _xyl3Tv5KdR5eezDgagxbBcS3cwt(_nR8eroJOHehP0ZGyyTveo6aMTHg _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
	{
		if (_nR8eroJOHehP0ZGyyTveo6aMTHg_0 == null)
		{
			goto IL_0030;
		}
		goto IL_005a;
		IL_005a:
		_Ta8oiGRfjrRGtgUaA5S061UepZb = _nR8eroJOHehP0ZGyyTveo6aMTHg_0;
		int num = 401709514;
		goto IL_0035;
		IL_0035:
		int int_ = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x647242A2u) % 5u)
			{
			case 4u:
				int_ = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_94(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_91(_CCtbrNWS4Gi5hRSEsXYI5VzS7gI), _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_93(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_92(_nR8eroJOHehP0ZGyyTveo6aMTHg_0)));
				num = ((int)num2 * -1879382624) ^ -421288793;
				continue;
			case 3u:
				break;
			case 0u:
				goto IL_005a;
			case 1u:
				return;
			default:
				_poenyHBGUusBcnNcTFB9MQBV72R._RiDuYMeg3EHnBUteUcAb8VlfQVl();
				_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_95(_Ta8oiGRfjrRGtgUaA5S061UepZb, int_, (int?)null);
				return;
			}
			break;
		}
		goto IL_0030;
		IL_0030:
		num = 871714885;
		goto IL_0035;
	}

	private _nR8eroJOHehP0ZGyyTveo6aMTHg _5yVCuTv9lVSCCxs7cUlv79ysuRh(string string_0)
	{
		string string_ = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_32(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_21(_uwNDZuqdFb9tyQtlQMxiz1DQ7x8), _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_96("Content-Mods/Data/Quests/{0}.json", (object)string_0));
		string string_2 = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_32(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_21(_uwNDZuqdFb9tyQtlQMxiz1DQ7x8), _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_96("Data/Quests/{0}.json", (object)string_0));
		if (_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_33(string_))
		{
			goto IL_00cc;
		}
		goto IL_01a6;
		IL_01a6:
		int num;
		int num2;
		if (!_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_33(string_2))
		{
			num = -1551837353;
			num2 = -1551837353;
		}
		else
		{
			num = -596827404;
			num2 = -596827404;
		}
		goto IL_0150;
		IL_0150:
		string text = default(string);
		_0SvCRe0EgzR9DhI3QPe1GUqubAt _0SvCRe0EgzR9DhI3QPe1GUqubAt = default(_0SvCRe0EgzR9DhI3QPe1GUqubAt);
		JsonSerializerSettings val = default(JsonSerializerSettings);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0xA701B8F9u) % 13u)
			{
			case 12u:
				text = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_98(string_);
				num = (int)((num3 * 1533777372) ^ 0x7E820074);
				continue;
			case 9u:
			{
				int num4;
				int num5;
				if (_0SvCRe0EgzR9DhI3QPe1GUqubAt != null)
				{
					num4 = 1840699857;
					num5 = 1840699857;
				}
				else
				{
					num4 = 97920549;
					num5 = 97920549;
				}
				num = num4 ^ ((int)num3 * -1859931542);
				continue;
			}
			case 8u:
				num = (int)((num3 * 640255352) ^ 0x45AF940E);
				continue;
			case 7u:
				_0SvCRe0EgzR9DhI3QPe1GUqubAt = JsonConvert.DeserializeObject<_0SvCRe0EgzR9DhI3QPe1GUqubAt>(text, val);
				num = (int)(num3 * 1822960861) ^ -1295623353;
				continue;
			case 6u:
				break;
			case 5u:
			{
				JsonSerializerSettings obj = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_100();
				_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_101(obj, (TypeNameHandling)4);
				_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_102(obj).Add((JsonConverter)(object)_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_103());
				val = obj;
				num = -125846158;
				continue;
			}
			case 4u:
				_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_90("Failed to load cutscene '{0}'", new object[1] { string_0 });
				num = -1776460700;
				continue;
			case 1u:
				_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_97("Loaded modded cutscene '{0}'", new object[1] { string_0 });
				num = ((int)num3 * -756499474) ^ 0x12EEE1B7;
				continue;
			case 0u:
				text = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_99(string_2);
				num = ((int)num3 * -1215277849) ^ 0x5DBE75ED;
				continue;
			case 11u:
				goto IL_01a6;
			case 2u:
				return null;
			default:
				return _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_105((_JbeCmOie0phb2cbgG6DdGZrbs3pB)this, _0SvCRe0EgzR9DhI3QPe1GUqubAt, new Assembly[1] { _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_104("Amorous.Game") });
			case 10u:
				return null;
			}
			break;
		}
		goto IL_00cc;
		IL_00cc:
		num = -1938102435;
		goto IL_0150;
	}

	private _zkUeZhJDizkmvvRfp4S0G7aap8J _PSROht9Hy1Ik63UUdnKDUGBA0yQ()
	{
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		if (_5zNdOw7qHmuCAPJFMr3SsZdBlCr != null)
		{
			goto IL_000b;
		}
		goto IL_0114;
		IL_0114:
		int num = -1260495060;
		goto IL_015b;
		IL_015b:
		_zkUeZhJDizkmvvRfp4S0G7aap8J zkUeZhJDizkmvvRfp4S0G7aap8J = default(_zkUeZhJDizkmvvRfp4S0G7aap8J);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xF70EFDEFu) % 7u)
			{
			case 4u:
				break;
			case 6u:
				zkUeZhJDizkmvvRfp4S0G7aap8J._gWHVDvr9GDtRXP2zf2Md18MgZ4b(_xfiKuXXh5LQA9CUQiex6tutzFKQ._VvFE2zgy4FbDjvaEvb67tXJ7aRm(NPCLocation.Middle));
				num = ((int)num2 * -923786829) ^ 0x5BBB6CCC;
				continue;
			case 2u:
				goto IL_0114;
			case 1u:
				zkUeZhJDizkmvvRfp4S0G7aap8J._gWHVDvr9GDtRXP2zf2Md18MgZ4b(_xfiKuXXh5LQA9CUQiex6tutzFKQ._VvFE2zgy4FbDjvaEvb67tXJ7aRm(NPCLocation.Left));
				num = (int)((num2 * 1053289645) ^ 0x4EA5F128);
				continue;
			case 0u:
				zkUeZhJDizkmvvRfp4S0G7aap8J._gWHVDvr9GDtRXP2zf2Md18MgZ4b(_xfiKuXXh5LQA9CUQiex6tutzFKQ._VvFE2zgy4FbDjvaEvb67tXJ7aRm(NPCLocation.Right));
				num = ((int)num2 * -331996798) ^ -151864879;
				continue;
			case 3u:
				return null;
			default:
				return zkUeZhJDizkmvvRfp4S0G7aap8J;
			}
			break;
		}
		goto IL_000b;
		IL_000b:
		_zkUeZhJDizkmvvRfp4S0G7aap8J zkUeZhJDizkmvvRfp4S0G7aap8J2 = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_106();
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_107(zkUeZhJDizkmvvRfp4S0G7aap8J2, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_93(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_92(_5zNdOw7qHmuCAPJFMr3SsZdBlCr)));
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_111(zkUeZhJDizkmvvRfp4S0G7aap8J2, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_110(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_109(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_108(_5zNdOw7qHmuCAPJFMr3SsZdBlCr))));
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_114(zkUeZhJDizkmvvRfp4S0G7aap8J2, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_113(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_112(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_108(_5zNdOw7qHmuCAPJFMr3SsZdBlCr))));
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_117(zkUeZhJDizkmvvRfp4S0G7aap8J2, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_116((MemberInfo)_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_115((object)_XbOXR6AypLIdJ3gBMGseGi3Wi2i)));
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_119(zkUeZhJDizkmvvRfp4S0G7aap8J2, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_118(_XbOXR6AypLIdJ3gBMGseGi3Wi2i));
		_TwlwMC1hhdSzamwGWEBxuUkz1gH kVSwpLj0RvURRswHn7ogRy4BRfd = _KVSwpLj0RvURRswHn7ogRy4BRfd;
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_121(zkUeZhJDizkmvvRfp4S0G7aap8J2, (kVSwpLj0RvURRswHn7ogRy4BRfd == null) ? null : _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_116((MemberInfo)_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_120((object)kVSwpLj0RvURRswHn7ogRy4BRfd)));
		_TwlwMC1hhdSzamwGWEBxuUkz1gH kVSwpLj0RvURRswHn7ogRy4BRfd2 = _KVSwpLj0RvURRswHn7ogRy4BRfd;
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_123(zkUeZhJDizkmvvRfp4S0G7aap8J2, (kVSwpLj0RvURRswHn7ogRy4BRfd2 != null) ? _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_122(kVSwpLj0RvURRswHn7ogRy4BRfd2) : _TwlwMC1hhdSzamwGWEBxuUkz1gH._qokIrmaaT3Lq6znW10HdrPUO9Fq.Idle);
		_TwlwMC1hhdSzamwGWEBxuUkz1gH kVSwpLj0RvURRswHn7ogRy4BRfd3 = _KVSwpLj0RvURRswHn7ogRy4BRfd;
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_125(zkUeZhJDizkmvvRfp4S0G7aap8J2, kVSwpLj0RvURRswHn7ogRy4BRfd3 != null && _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_124(kVSwpLj0RvURRswHn7ogRy4BRfd3));
		Color sWODlbUkQEqfwrtprjLPOeGF7HO = _Qj2G6fpAF4mGsATgkV8DPBF3aA1A._SWODlbUkQEqfwrtprjLPOeGF7HO;
		zkUeZhJDizkmvvRfp4S0G7aap8J2._KR48sJtGCfgf7jYtIsrj2N1iO3n = ((Color)(ref sWODlbUkQEqfwrtprjLPOeGF7HO)).get_A() > 0;
		zkUeZhJDizkmvvRfp4S0G7aap8J = zkUeZhJDizkmvvRfp4S0G7aap8J2;
		num = -1062819156;
		goto IL_015b;
	}

	private void _dmwpjPj0QtK7OW2M486hHkm5FKH(_zkUeZhJDizkmvvRfp4S0G7aap8J _zkUeZhJDizkmvvRfp4S0G7aap8J_0)
	{
		_bj8iyyk84DtxcxcHgAHHFGgq8oN _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA;
		_zkUeZhJDizkmvvRfp4S0G7aap8J _JyFtGgNgB3bOcqUlEWpLqpF8I4r;
		while (true)
		{
			int num = 88025431;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x43DCCC6Eu) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0008:
				_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = this;
				_JyFtGgNgB3bOcqUlEWpLqpF8I4r = _zkUeZhJDizkmvvRfp4S0G7aap8J_0;
				_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_83(_Qj2G6fpAF4mGsATgkV8DPBF3aA1A, (Action)delegate
				{
					_nR8eroJOHehP0ZGyyTveo6aMTHg _hvKKVpHsQ6yw7YBy97lS8UDtil = _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._5yVCuTv9lVSCCxs7cUlv79ysuRh(_pRMaMNHrUICTrn5AyRDYx65hOVDA.smethod_0(_JyFtGgNgB3bOcqUlEWpLqpF8I4r));
					if (_hvKKVpHsQ6yw7YBy97lS8UDtil != null)
					{
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._OxLRmpxixplTKChiTPUKAx4uTLG(_pRMaMNHrUICTrn5AyRDYx65hOVDA.smethod_1(_JyFtGgNgB3bOcqUlEWpLqpF8I4r), delegate
						{
							if (_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_0(_JyFtGgNgB3bOcqUlEWpLqpF8I4r) != null)
							{
								goto IL_0027;
							}
							goto IL_0112;
							IL_0112:
							int num3;
							int num4;
							if (_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_2(_JyFtGgNgB3bOcqUlEWpLqpF8I4r) != null)
							{
								num3 = 1325931602;
								num4 = 1325931602;
							}
							else
							{
								num3 = 613778258;
								num4 = 613778258;
							}
							goto IL_00d9;
							IL_00d9:
							_QGGOTxZ8aNWGh0hc26wcmx8wmwT qGGOTxZ8aNWGh0hc26wcmx8wmwT_ = default(_QGGOTxZ8aNWGh0hc26wcmx8wmwT);
							_zkUeZhJDizkmvvRfp4S0G7aap8J._CIFXVF6lKl3nSrVOhqjcFXDVlXc current = default(_zkUeZhJDizkmvvRfp4S0G7aap8J._CIFXVF6lKl3nSrVOhqjcFXDVlXc);
							_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve = default(_3IHp43rpkJgOBcY9lrIrwMuwWve);
							while (true)
							{
								uint num5;
								switch ((num5 = (uint)num3 ^ 0x11EA7359u) % 6u)
								{
								case 4u:
									break;
								case 3u:
									_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_1(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._XbOXR6AypLIdJ3gBMGseGi3Wi2i, _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_0(_JyFtGgNgB3bOcqUlEWpLqpF8I4r));
									num3 = ((int)num5 * -1708666652) ^ -220919343;
									continue;
								case 1u:
									_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._gYGB98heFqsLp9tgJbdCP01IKV2(_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_2(_JyFtGgNgB3bOcqUlEWpLqpF8I4r));
									num3 = ((int)num5 * -1726648562) ^ 0x163B51E1;
									continue;
								case 0u:
									_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_5(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._KVSwpLj0RvURRswHn7ogRy4BRfd, _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_3(_JyFtGgNgB3bOcqUlEWpLqpF8I4r), _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_4(_JyFtGgNgB3bOcqUlEWpLqpF8I4r));
									num3 = (int)((num5 * 1263079409) ^ 0x1E514050);
									continue;
								case 2u:
									goto IL_0112;
								default:
								{
									using (List<_zkUeZhJDizkmvvRfp4S0G7aap8J._CIFXVF6lKl3nSrVOhqjcFXDVlXc>.Enumerator enumerator = _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_6(_JyFtGgNgB3bOcqUlEWpLqpF8I4r).GetEnumerator())
									{
										while (true)
										{
											IL_024b:
											int num6;
											int num7;
											if (enumerator.MoveNext())
											{
												num6 = 633851960;
												num7 = 633851960;
											}
											else
											{
												num6 = 1587468332;
												num7 = 1587468332;
											}
											while (true)
											{
												switch ((num5 = (uint)num6 ^ 0x11EA7359u) % 8u)
												{
												case 7u:
													qGGOTxZ8aNWGh0hc26wcmx8wmwT_ = _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._TwQHHdbdRFRy2ctTZabNfz1Htrg(_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_7(current), _a2qVgWDIm3fBp49WubttSTPsx8K.Background);
													num6 = (int)((num5 * 1786622167) ^ 0x31BA5140);
													continue;
												case 6u:
													_3IHp43rpkJgOBcY9lrIrwMuwWve = _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_13(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._xfiKuXXh5LQA9CUQiex6tutzFKQ, _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_7(current));
													num6 = ((int)num5 * -911556875) ^ 0x42871BCB;
													continue;
												case 4u:
													_3IHp43rpkJgOBcY9lrIrwMuwWve._VNgmwYSLsJyyiR6cPQ35UHJBR4d = _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_14(current);
													num6 = ((int)num5 * -1347434217) ^ 0x388BE6AF;
													continue;
												case 3u:
													num6 = 633851960;
													continue;
												case 1u:
													current = enumerator.Current;
													num6 = 1652898318;
													continue;
												case 0u:
													_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_12(qGGOTxZ8aNWGh0hc26wcmx8wmwT_, _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_8(current), _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_9(current), _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_10(current), _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_11(current));
													num6 = (int)(num5 * 302114036) ^ -682740993;
													continue;
												default:
													goto end_IL_020a;
												case 2u:
													break;
												case 5u:
													goto end_IL_020a;
												}
												goto IL_024b;
												continue;
												end_IL_020a:
												break;
											}
											break;
										}
									}
									if (_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_15(_JyFtGgNgB3bOcqUlEWpLqpF8I4r))
									{
										while (true)
										{
											int num8 = 1261540779;
											while (true)
											{
												switch ((num5 = (uint)num8 ^ 0x11EA7359u) % 5u)
												{
												case 2u:
													_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_18(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Ta8oiGRfjrRGtgUaA5S061UepZb, _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_16(_JyFtGgNgB3bOcqUlEWpLqpF8I4r), (int?)_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_17(_JyFtGgNgB3bOcqUlEWpLqpF8I4r));
													num8 = ((int)num5 * -1311545333) ^ -99361949;
													continue;
												case 1u:
													_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Ta8oiGRfjrRGtgUaA5S061UepZb = _hvKKVpHsQ6yw7YBy97lS8UDtil;
													num8 = (int)(num5 * 1250263189) ^ -2062427039;
													continue;
												case 4u:
													break;
												case 0u:
													return;
												default:
													goto end_IL_0317;
												}
												break;
											}
											continue;
											end_IL_0317:
											break;
										}
									}
									_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_19(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Qj2G6fpAF4mGsATgkV8DPBF3aA1A, (Action)delegate
									{
										_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Ta8oiGRfjrRGtgUaA5S061UepZb = _hvKKVpHsQ6yw7YBy97lS8UDtil;
										_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_18(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Ta8oiGRfjrRGtgUaA5S061UepZb, _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_16(_JyFtGgNgB3bOcqUlEWpLqpF8I4r), (int?)_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_17(_JyFtGgNgB3bOcqUlEWpLqpF8I4r));
									});
									return;
								}
								}
								break;
							}
							goto IL_0027;
							IL_0027:
							num3 = 640273266;
							goto IL_00d9;
						});
					}
				});
				num = ((int)num2 * -686175964) ^ 0x70123B29;
			}
		}
	}

	public void _bHdVKtqP3Eb3DSJmuVTbkY8RtHP()
	{
		_CYyzfcX8IclN1GnWsApBFWBpush(0);
		while (true)
		{
			int num = 400102448;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x46A615C5u) % 4u)
				{
				case 3u:
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_126(_xfiKuXXh5LQA9CUQiex6tutzFKQ);
					num = (int)(num2 * 996983460) ^ -1815466207;
					continue;
				case 1u:
					_nvTYmpWmxq2DhO8ubfi3j5rZdLA();
					num = ((int)num2 * -901874760) ^ 0x5D7F4CFA;
					continue;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public void _lXEQJcXKxsjtZp00Y9aPe0ymGue<T>() where T : _8lVOgkauaSHbAkAqHzI1K7mIyOI
	{
		_fp8jsuSnELXqf2yy2JQDaXDCBVQ = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_86(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_37(typeof(T).TypeHandle), new object[1] { this }) as _8lVOgkauaSHbAkAqHzI1K7mIyOI;
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
			goto IL_0008;
		}
		goto IL_005a;
		IL_005a:
		_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_127(_xfiKuXXh5LQA9CUQiex6tutzFKQ, string_0);
		int num = -1535742007;
		goto IL_0031;
		IL_0031:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xF0D1BF61u) % 6u)
			{
			case 3u:
				break;
			case 0u:
			{
				int num3;
				int num4;
				if (_3IHp43rpkJgOBcY9lrIrwMuwWve != null)
				{
					num3 = 499961983;
					num4 = 499961983;
				}
				else
				{
					num3 = 1293906292;
					num4 = 1293906292;
				}
				num = num3 ^ ((int)num2 * -816996636);
				continue;
			}
			case 4u:
				goto IL_005a;
			case 1u:
				return null;
			case 2u:
				return _3IHp43rpkJgOBcY9lrIrwMuwWve._4QLHHCk23T1BjK7acKxASbkCefG;
			default:
				return null;
			}
			break;
		}
		goto IL_0008;
		IL_0008:
		num = -202585956;
		goto IL_0031;
	}

	public _QGGOTxZ8aNWGh0hc26wcmx8wmwT _VvFE2zgy4FbDjvaEvb67tXJ7aRm(NPCLocation npclocation_0)
	{
		if (_xfiKuXXh5LQA9CUQiex6tutzFKQ == null)
		{
			goto IL_0017;
		}
		goto IL_004b;
		IL_004b:
		_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_128(_xfiKuXXh5LQA9CUQiex6tutzFKQ, npclocation_0);
		int num;
		int num2;
		if (_3IHp43rpkJgOBcY9lrIrwMuwWve == null)
		{
			num = -93534759;
			num2 = -93534759;
		}
		else
		{
			num = -1422893098;
			num2 = -1422893098;
		}
		goto IL_001c;
		IL_001c:
		switch ((uint)(num ^ -1227236396) % 5u)
		{
		case 4u:
			break;
		case 3u:
			goto IL_004b;
		default:
			return null;
		case 1u:
			return _3IHp43rpkJgOBcY9lrIrwMuwWve._4QLHHCk23T1BjK7acKxASbkCefG;
		case 2u:
			return null;
		}
		goto IL_0017;
		IL_0017:
		num = -1160717476;
		goto IL_001c;
	}

	public _QGGOTxZ8aNWGh0hc26wcmx8wmwT _TwQHHdbdRFRy2ctTZabNfz1Htrg(string string_0, _a2qVgWDIm3fBp49WubttSTPsx8K _a2qVgWDIm3fBp49WubttSTPsx8K_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT qGGOTxZ8aNWGh0hc26wcmx8wmwT = default(_QGGOTxZ8aNWGh0hc26wcmx8wmwT);
		_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve = default(_3IHp43rpkJgOBcY9lrIrwMuwWve);
		string _hzqOBkJhJBhsTRNARxHLctcvhN0 = default(string);
		Type type_ = default(Type);
		IEnumerable<Type> source = default(IEnumerable<Type>);
		while (true)
		{
			int num = 654346774;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x39A8CA5Bu) % 18u)
				{
				case 17u:
				{
					int num5;
					int num6;
					if (qGGOTxZ8aNWGh0hc26wcmx8wmwT != null)
					{
						num5 = 1989596692;
						num6 = 1989596692;
					}
					else
					{
						num5 = 1211904275;
						num6 = 1211904275;
					}
					num = num5 ^ (int)(num2 * 1506599940);
					continue;
				}
				case 16u:
				{
					_QGGOTxZ8aNWGh0hc26wcmx8wmwT _4QLHHCk23T1BjK7acKxASbkCefG = _3IHp43rpkJgOBcY9lrIrwMuwWve._4QLHHCk23T1BjK7acKxASbkCefG;
					if (_4QLHHCk23T1BjK7acKxASbkCefG != null && _4QLHHCk23T1BjK7acKxASbkCefG._SC7QlorMIWTLSkD757wC7ybszpE)
					{
						num = 769878895;
						continue;
					}
					goto case 13u;
				}
				case 14u:
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_90("Failed to instance npc '{0}'", new object[1] { _hzqOBkJhJBhsTRNARxHLctcvhN0 });
					num = ((int)num2 * -786355019) ^ 0x6DAC1577;
					continue;
				case 12u:
				{
					_3IHp43rpkJgOBcY9lrIrwMuwWve = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_127(_xfiKuXXh5LQA9CUQiex6tutzFKQ, _hzqOBkJhJBhsTRNARxHLctcvhN0);
					int num9;
					if (_3IHp43rpkJgOBcY9lrIrwMuwWve != null)
					{
						num = 1007115593;
						num9 = 1007115593;
					}
					else
					{
						num = 1108071028;
						num9 = 1108071028;
					}
					continue;
				}
				case 10u:
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_90("Failed to load npc '{0}'", new object[1] { _hzqOBkJhJBhsTRNARxHLctcvhN0 });
					num = (int)((num2 * 1485916818) ^ 0x5356C33A);
					continue;
				case 9u:
					_hzqOBkJhJBhsTRNARxHLctcvhN0 = string_0;
					num = (int)((num2 * 2147104682) ^ 0x7C4636ED);
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (_xfiKuXXh5LQA9CUQiex6tutzFKQ != null)
					{
						num3 = -1850663405;
						num4 = -1850663405;
					}
					else
					{
						num3 = -1071248514;
						num4 = -1071248514;
					}
					num = num3 ^ (int)(num2 * 1436844226);
					continue;
				}
				case 5u:
				{
					type_ = source.FirstOrDefault((Type type_0) => _1oSOYUYBONRKpcOISvejZTGlh6P.smethod_1(_1oSOYUYBONRKpcOISvejZTGlh6P.smethod_0((MemberInfo)type_0), _hzqOBkJhJBhsTRNARxHLctcvhN0));
					int num7;
					int num8;
					if (!_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_89(type_, (Type)null))
					{
						num7 = -1813780531;
						num8 = -1813780531;
					}
					else
					{
						num7 = -1567399949;
						num8 = -1567399949;
					}
					num = num7 ^ ((int)num2 * -1281351300);
					continue;
				}
				case 3u:
					source = from type_0 in _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_88(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_87(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_37(typeof(_bj8iyyk84DtxcxcHgAHHFGgq8oN).TypeHandle)))
						where _PzOBAEclhQj3NzBZIEIMnKCuYsr.smethod_3(_PzOBAEclhQj3NzBZIEIMnKCuYsr.smethod_2(typeof(_QGGOTxZ8aNWGh0hc26wcmx8wmwT).TypeHandle), type_0) && !_PzOBAEclhQj3NzBZIEIMnKCuYsr.smethod_4(type_0)
						select type_0;
					num = 1526047190;
					continue;
				case 2u:
					qGGOTxZ8aNWGh0hc26wcmx8wmwT = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_86(type_, new object[1] { this }) as _QGGOTxZ8aNWGh0hc26wcmx8wmwT;
					num = 503843838;
					continue;
				case 1u:
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_130(qGGOTxZ8aNWGh0hc26wcmx8wmwT, (_JbeCmOie0phb2cbgG6DdGZrbs3pB)this);
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_131(qGGOTxZ8aNWGh0hc26wcmx8wmwT);
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_132(_xfiKuXXh5LQA9CUQiex6tutzFKQ, qGGOTxZ8aNWGh0hc26wcmx8wmwT, (_a2qVgWDIm3fBp49WubttSTPsx8K_0 == _a2qVgWDIm3fBp49WubttSTPsx8K.None) ? _a2qVgWDIm3fBp49WubttSTPsx8K.Background : _a2qVgWDIm3fBp49WubttSTPsx8K_0);
					num = 1415732939;
					continue;
				case 7u:
					break;
				default:
					return qGGOTxZ8aNWGh0hc26wcmx8wmwT;
				case 4u:
					return null;
				case 8u:
					return null;
				case 11u:
					return null;
				case 15u:
					return null;
				case 13u:
					_3IHp43rpkJgOBcY9lrIrwMuwWve._dPmC8tBC0iph2YBAFmztEsmwUdSA = ((_a2qVgWDIm3fBp49WubttSTPsx8K_0 == _a2qVgWDIm3fBp49WubttSTPsx8K.None) ? _3IHp43rpkJgOBcY9lrIrwMuwWve._dPmC8tBC0iph2YBAFmztEsmwUdSA : _a2qVgWDIm3fBp49WubttSTPsx8K_0);
					_3IHp43rpkJgOBcY9lrIrwMuwWve._ac2H6kMdrgPhXXxabsikjji4SiT = ((_3IHp43rpkJgOBcY9lrIrwMuwWve._dPmC8tBC0iph2YBAFmztEsmwUdSA == _a2qVgWDIm3fBp49WubttSTPsx8K.Background) ? 1 : 3);
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_129(_xfiKuXXh5LQA9CUQiex6tutzFKQ);
					return _3IHp43rpkJgOBcY9lrIrwMuwWve._4QLHHCk23T1BjK7acKxASbkCefG;
				}
				break;
			}
		}
	}

	public T _TwQHHdbdRFRy2ctTZabNfz1Htrg<T>(_a2qVgWDIm3fBp49WubttSTPsx8K _a2qVgWDIm3fBp49WubttSTPsx8K_0) where T : _QGGOTxZ8aNWGh0hc26wcmx8wmwT
	{
		return _TwQHHdbdRFRy2ctTZabNfz1Htrg(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_116((MemberInfo)_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_37(typeof(T).TypeHandle)), _a2qVgWDIm3fBp49WubttSTPsx8K_0) as T;
	}

	public void _yh2DwZs16cvRtvGayeYZrMWlrbj(int int_0)
	{
		_lRHDfpOTd4PxClZkjMpoakPEA9d lRHDfpOTd4PxClZkjMpoakPEA9d_ = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_133();
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_134(lRHDfpOTd4PxClZkjMpoakPEA9d_, 5);
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_135(lRHDfpOTd4PxClZkjMpoakPEA9d_, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_91(_CCtbrNWS4Gi5hRSEsXYI5VzS7gI));
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_136(lRHDfpOTd4PxClZkjMpoakPEA9d_, _PSROht9Hy1Ik63UUdnKDUGBA0yQ());
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_137(lRHDfpOTd4PxClZkjMpoakPEA9d_, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_116((MemberInfo)_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_115((object)_xfiKuXXh5LQA9CUQiex6tutzFKQ)));
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_138(lRHDfpOTd4PxClZkjMpoakPEA9d_, _poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj);
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_139(int_0, lRHDfpOTd4PxClZkjMpoakPEA9d_, "save");
	}

	public void _CYyzfcX8IclN1GnWsApBFWBpush(int int_0)
	{
		_lRHDfpOTd4PxClZkjMpoakPEA9d lRHDfpOTd4PxClZkjMpoakPEA9d_ = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_133();
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_134(lRHDfpOTd4PxClZkjMpoakPEA9d_, 5);
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_135(lRHDfpOTd4PxClZkjMpoakPEA9d_, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_91(_CCtbrNWS4Gi5hRSEsXYI5VzS7gI));
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_137(lRHDfpOTd4PxClZkjMpoakPEA9d_, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_116((MemberInfo)_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_115((object)_xfiKuXXh5LQA9CUQiex6tutzFKQ)));
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_138(lRHDfpOTd4PxClZkjMpoakPEA9d_, _poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj);
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_140(int_0, lRHDfpOTd4PxClZkjMpoakPEA9d_);
	}

	public bool _Ut0dhlh4JTZBMNJPNxxI9f9VqTp(int int_0)
	{
		_nvTYmpWmxq2DhO8ubfi3j5rZdLA();
		_lRHDfpOTd4PxClZkjMpoakPEA9d lRHDfpOTd4PxClZkjMpoakPEA9d = default(_lRHDfpOTd4PxClZkjMpoakPEA9d);
		while (true)
		{
			int num = -791149637;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC2CF8173u) % 15u)
				{
				case 14u:
				{
					int num7;
					int num8;
					if (_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_149(lRHDfpOTd4PxClZkjMpoakPEA9d) != null)
					{
						num7 = -252564459;
						num8 = -252564459;
					}
					else
					{
						num7 = -369628210;
						num8 = -369628210;
					}
					num = num7 ^ ((int)num2 * -1289543881);
					continue;
				}
				case 13u:
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_148(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_147(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_11()));
					num = ((int)num2 * -1725283822) ^ -808966029;
					continue;
				case 12u:
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_137(lRHDfpOTd4PxClZkjMpoakPEA9d, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_116((MemberInfo)_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_37(typeof(ClubInsideScene).TypeHandle)));
					num = (int)((num2 * 82989829) ^ 0x2EADD8CC);
					continue;
				case 11u:
				{
					lRHDfpOTd4PxClZkjMpoakPEA9d = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_141(int_0, "save");
					int num4;
					int num5;
					if (lRHDfpOTd4PxClZkjMpoakPEA9d != null)
					{
						num4 = -2077210322;
						num5 = -2077210322;
					}
					else
					{
						num4 = -1586962171;
						num5 = -1586962171;
					}
					num = num4 ^ (int)(num2 * 80452641);
					continue;
				}
				case 9u:
				{
					int num6;
					if (_dKSAtbg8U4PX1oOcOJ2BFewVtcI.Contains(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_150(lRHDfpOTd4PxClZkjMpoakPEA9d)))
					{
						num = -1561457017;
						num6 = -1561457017;
					}
					else
					{
						num = -1981815684;
						num6 = -1981815684;
					}
					continue;
				}
				case 8u:
					_dmwpjPj0QtK7OW2M486hHkm5FKH(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_149(lRHDfpOTd4PxClZkjMpoakPEA9d));
					num = (int)(num2 * 301239754) ^ -986004938;
					continue;
				case 7u:
					_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_144(lRHDfpOTd4PxClZkjMpoakPEA9d);
					_poenyHBGUusBcnNcTFB9MQBV72R._AZrO8MxMUE7cKsFYTQ4k9O3q7yC()._Xrfjrxr72hHh4bDdQB7HzEbJUCb();
					num = (int)((num2 * 453506280) ^ 0x6A709448);
					continue;
				case 6u:
				{
					int num3;
					if (!_9gbCIL8lNtgBPuVMJ6pA7rCsMoT._RUw8RieezXPoVSmbk3eROtfKXVi(this, lRHDfpOTd4PxClZkjMpoakPEA9d))
					{
						num = -1071655217;
						num3 = -1071655217;
					}
					else
					{
						num = -2130577420;
						num3 = -2130577420;
					}
					continue;
				}
				case 5u:
					_k9wUPeU1Ga7cygiuGP8TT6aPLWF(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_150(lRHDfpOTd4PxClZkjMpoakPEA9d));
					num = (int)(num2 * 1241445634) ^ -1826722676;
					continue;
				case 4u:
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_146(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_145(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_11()));
					num = (int)(num2 * 1214562641) ^ -1456325054;
					continue;
				case 3u:
					num = ((int)num2 * -717993532) ^ 0x3FC75FB0;
					continue;
				case 2u:
					_9gbCIL8lNtgBPuVMJ6pA7rCsMoT._NG0eIZcXsX6Fp38GhuED0LKeWHf(lRHDfpOTd4PxClZkjMpoakPEA9d);
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_143(_CCtbrNWS4Gi5hRSEsXYI5VzS7gI, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_142(lRHDfpOTd4PxClZkjMpoakPEA9d));
					num = -1942807391;
					continue;
				case 0u:
					break;
				default:
					return true;
				case 10u:
					return false;
				}
				break;
			}
		}
	}

	public bool _1yDW5GeZ2MCcssz8ohrF9CK913i(int int_0)
	{
		_nvTYmpWmxq2DhO8ubfi3j5rZdLA();
		_lRHDfpOTd4PxClZkjMpoakPEA9d lRHDfpOTd4PxClZkjMpoakPEA9d = default(_lRHDfpOTd4PxClZkjMpoakPEA9d);
		while (true)
		{
			int num = 444794890;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1B52B999u) % 11u)
				{
				case 10u:
				{
					int num5;
					if (_9gbCIL8lNtgBPuVMJ6pA7rCsMoT._RUw8RieezXPoVSmbk3eROtfKXVi(this, lRHDfpOTd4PxClZkjMpoakPEA9d))
					{
						num = 1154094555;
						num5 = 1154094555;
					}
					else
					{
						num = 527429052;
						num5 = 527429052;
					}
					continue;
				}
				case 9u:
					_poenyHBGUusBcnNcTFB9MQBV72R._AZrO8MxMUE7cKsFYTQ4k9O3q7yC()._Xrfjrxr72hHh4bDdQB7HzEbJUCb();
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_146(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_145(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_11()));
					num = ((int)num2 * -167543751) ^ 0x4707DB25;
					continue;
				case 8u:
				{
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_148(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_147(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_11()));
					int num6;
					int num7;
					if (!_dKSAtbg8U4PX1oOcOJ2BFewVtcI.Contains(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_150(lRHDfpOTd4PxClZkjMpoakPEA9d)))
					{
						num6 = -67975200;
						num7 = -67975200;
					}
					else
					{
						num6 = -1885275830;
						num7 = -1885275830;
					}
					num = num6 ^ ((int)num2 * -213464398);
					continue;
				}
				case 7u:
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_143(_CCtbrNWS4Gi5hRSEsXYI5VzS7gI, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_142(lRHDfpOTd4PxClZkjMpoakPEA9d));
					_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_144(lRHDfpOTd4PxClZkjMpoakPEA9d);
					num = ((int)num2 * -1254312254) ^ -1306371852;
					continue;
				case 6u:
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_137(lRHDfpOTd4PxClZkjMpoakPEA9d, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_116((MemberInfo)_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_37(typeof(ClubInsideScene).TypeHandle)));
					num = ((int)num2 * -1106641975) ^ 0x1D97772B;
					continue;
				case 4u:
					_9gbCIL8lNtgBPuVMJ6pA7rCsMoT._NG0eIZcXsX6Fp38GhuED0LKeWHf(lRHDfpOTd4PxClZkjMpoakPEA9d);
					num = 1303643234;
					continue;
				case 1u:
				{
					lRHDfpOTd4PxClZkjMpoakPEA9d = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_151(int_0);
					int num3;
					int num4;
					if (lRHDfpOTd4PxClZkjMpoakPEA9d != null)
					{
						num3 = -1724822100;
						num4 = -1724822100;
					}
					else
					{
						num3 = -1807927400;
						num4 = -1807927400;
					}
					num = num3 ^ ((int)num2 * -587812227);
					continue;
				}
				case 0u:
					_k9wUPeU1Ga7cygiuGP8TT6aPLWF(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_150(lRHDfpOTd4PxClZkjMpoakPEA9d));
					num = (int)((num2 * 1350973741) ^ 0x4528125A);
					continue;
				case 2u:
					break;
				case 3u:
					return false;
				default:
					return true;
				}
				break;
			}
		}
	}

	public void _EXfoFnp1OKxeZbd4GcVZMCO2urH(string string_0, string string_1, string string_2)
	{
		List<_iDN1IKOu3e1uADYzeMEUon5D9fg> list = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_153(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_152());
		_iDN1IKOu3e1uADYzeMEUon5D9fg iDN1IKOu3e1uADYzeMEUon5D9fg = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_154();
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_155(iDN1IKOu3e1uADYzeMEUon5D9fg, string_0);
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_156(iDN1IKOu3e1uADYzeMEUon5D9fg, string_1);
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_157(iDN1IKOu3e1uADYzeMEUon5D9fg, string_2);
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_158(iDN1IKOu3e1uADYzeMEUon5D9fg, DateTime.Now);
		list.Add(iDN1IKOu3e1uADYzeMEUon5D9fg);
		while (true)
		{
			int num = 47196343;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7219EF56u) % 3u)
				{
				case 2u:
					goto IL_0036;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0036:
				_9rxbJ7LsE3DhACUHVlPZaixc5Jp._EXfoFnp1OKxeZbd4GcVZMCO2urH(string_0, string_1, string_2);
				num = (int)((num2 * 130903605) ^ 0x66CF3E6);
			}
		}
	}

	private void _pql4s9X0U3svdBghGax6VsdF2Gq()
	{
		_nvTYmpWmxq2DhO8ubfi3j5rZdLA();
		_k9wUPeU1Ga7cygiuGP8TT6aPLWF<MainMenuScene>();
	}

	private void _nvTYmpWmxq2DhO8ubfi3j5rZdLA()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (_5zNdOw7qHmuCAPJFMr3SsZdBlCr != null)
		{
			goto IL_0021;
		}
		goto IL_00ae;
		IL_00ae:
		_poenyHBGUusBcnNcTFB9MQBV72R._RiDuYMeg3EHnBUteUcAb8VlfQVl();
		int num = 1854024003;
		goto IL_0081;
		IL_0081:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x7F470AA5u) % 7u)
			{
			case 6u:
				_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_161();
				num = (int)(num2 * 1166396501) ^ -1347802601;
				continue;
			case 5u:
				break;
			case 4u:
				_poenyHBGUusBcnNcTFB9MQBV72R._AZrO8MxMUE7cKsFYTQ4k9O3q7yC()._haICL4qkfkOLhPhofWQH1GmjZx5();
				_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_160();
				num = ((int)num2 * -1726705655) ^ -1994583071;
				continue;
			case 2u:
				_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_159(_5zNdOw7qHmuCAPJFMr3SsZdBlCr);
				num = ((int)num2 * -1394080101) ^ 0x149C5278;
				continue;
			case 0u:
				_RA1aFlOff0jGfI2cKUGhYI1MRLBA._E7yBM68AWt7OGHJ5D6xYA8RK8tAA(new Color(0, 0, 0, 0));
				num = ((int)num2 * -1687940070) ^ -1248587810;
				continue;
			default:
				return;
			case 1u:
				goto IL_00ae;
			case 3u:
				return;
			}
			break;
		}
		goto IL_0021;
		IL_0021:
		num = 2126088146;
		goto IL_0081;
	}

	[CompilerGenerated]
	private void _86vqN8sLvarYd06EMKfyLRTFanr()
	{
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_162(_Qj2G6fpAF4mGsATgkV8DPBF3aA1A, (Action)null);
	}

	[CompilerGenerated]
	private void _IqIm0nfjkTCNpmzByUZSqOvFXNo<T>() where T : _7UlnfykmEmZDFt3BmCKZekI43Ih
	{
		_OxLRmpxixplTKChiTPUKAx4uTLG<T>(delegate
		{
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_162(_RA1aFlOff0jGfI2cKUGhYI1MRLBA, (Action)null);
		});
	}

	[CompilerGenerated]
	private void _B5jLpbKxN5uZIpG1BovWH4IFrZC<T>() where T : _7UlnfykmEmZDFt3BmCKZekI43Ih
	{
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_162(_RA1aFlOff0jGfI2cKUGhYI1MRLBA, (Action)null);
	}

	static GameWindow smethod_0(Game game_0)
	{
		return game_0.get_Window();
	}

	static GraphicsDevice smethod_1(Game game_0)
	{
		return game_0.get_GraphicsDevice();
	}

	static ContentManager smethod_2(Game game_0)
	{
		return game_0.get_Content();
	}

	static bool smethod_3(GraphicsDeviceManager graphicsDeviceManager_0)
	{
		return graphicsDeviceManager_0.get_IsFullScreen();
	}

	static void smethod_4()
	{
		_eJWqL2MhFZHNHP960nsWLJJmyPD._sabDA8yXNR8DIRSbHjOcXx1e1Ax();
	}

	static GraphicsDeviceManager smethod_5(Game game_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new GraphicsDeviceManager(game_0);
	}

	static void smethod_6(GraphicsDeviceManager graphicsDeviceManager_0, bool bool_0)
	{
		graphicsDeviceManager_0.set_IsFullScreen(bool_0);
	}

	static void smethod_7(GraphicsDeviceManager graphicsDeviceManager_0, int int_0)
	{
		graphicsDeviceManager_0.set_PreferredBackBufferWidth(int_0);
	}

	static void smethod_8(GraphicsDeviceManager graphicsDeviceManager_0, int int_0)
	{
		graphicsDeviceManager_0.set_PreferredBackBufferHeight(int_0);
	}

	static void smethod_9(GraphicsDeviceManager graphicsDeviceManager_0, bool bool_0)
	{
		graphicsDeviceManager_0.set_SynchronizeWithVerticalRetrace(bool_0);
	}

	static bool smethod_10()
	{
		return _eJWqL2MhFZHNHP960nsWLJJmyPD._5shlzNYVaJPuzrQfwyRBEphDX6p();
	}

	static _eNOTHZZiu5nx6PrADzfLyng3Igc smethod_11()
	{
		return _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF;
	}

	static bool smethod_12(_eNOTHZZiu5nx6PrADzfLyng3Igc _eNOTHZZiu5nx6PrADzfLyng3Igc_0)
	{
		return _eNOTHZZiu5nx6PrADzfLyng3Igc_0._Bbx3oCtJkeUN6asRLqH0DJ3kkFg;
	}

	static int smethod_13(_eNOTHZZiu5nx6PrADzfLyng3Igc _eNOTHZZiu5nx6PrADzfLyng3Igc_0)
	{
		return _eNOTHZZiu5nx6PrADzfLyng3Igc_0._Iv7AHXGOFR9WoLBFx6PjEgEHmYI;
	}

	static int smethod_14(_eNOTHZZiu5nx6PrADzfLyng3Igc _eNOTHZZiu5nx6PrADzfLyng3Igc_0)
	{
		return _eNOTHZZiu5nx6PrADzfLyng3Igc_0._84wHcdDxJz5ElyDPXXlgRgsiW8g;
	}

	static GraphicsAdapter smethod_15()
	{
		return GraphicsAdapter.get_DefaultAdapter();
	}

	static DisplayMode smethod_16(GraphicsAdapter graphicsAdapter_0)
	{
		return graphicsAdapter_0.get_CurrentDisplayMode();
	}

	static int smethod_17(DisplayMode displayMode_0)
	{
		return displayMode_0.get_Width();
	}

	static int smethod_18(DisplayMode displayMode_0)
	{
		return displayMode_0.get_Height();
	}

	static void smethod_19(ContentManager contentManager_0, string string_0)
	{
		contentManager_0.set_RootDirectory(string_0);
	}

	static IServiceProvider smethod_20(ContentManager contentManager_0)
	{
		return contentManager_0.get_ServiceProvider();
	}

	static string smethod_21(ContentManager contentManager_0)
	{
		return contentManager_0.get_RootDirectory();
	}

	static _xM5N1Fg3VZCSTaBWtPXoS6nJ82E smethod_22(IServiceProvider iserviceProvider_0, string string_0)
	{
		return new _xM5N1Fg3VZCSTaBWtPXoS6nJ82E(iserviceProvider_0, string_0);
	}

	static void smethod_23(Game game_0, ContentManager contentManager_0)
	{
		game_0.set_Content(contentManager_0);
	}

	static void smethod_24(Game game_0, EventHandler<EventArgs> eventHandler_0)
	{
		game_0.add_Disposed(eventHandler_0);
	}

	static Func<string> smethod_25()
	{
		return Gui.get_GetClipboardCallback();
	}

	static Delegate smethod_26(Delegate delegate_0, Delegate delegate_1)
	{
		return Delegate.Combine(delegate_0, delegate_1);
	}

	static void smethod_27(Func<string> func_0)
	{
		Gui.set_GetClipboardCallback(func_0);
	}

	static Action<string> smethod_28()
	{
		return Gui.get_SetClipboardCallback();
	}

	static void smethod_29(Action<string> action_0)
	{
		Gui.set_SetClipboardCallback(action_0);
	}

	static AppDomain smethod_30()
	{
		return AppDomain.CurrentDomain;
	}

	static string smethod_31(AppDomain appDomain_0)
	{
		return appDomain_0.BaseDirectory;
	}

	static string smethod_32(string string_0, string string_1)
	{
		return Path.Combine(string_0, string_1);
	}

	static bool smethod_33(string string_0)
	{
		return File.Exists(string_0);
	}

	static string smethod_34(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static void smethod_35(bool bool_0)
	{
		_iExD93IWLlzVfXsU9wyrEvWgJsg._qrFhbSiCFS6nLCN231ubbRQQeXE(bool_0);
	}

	static _3FFZvGWTAe7rsviKkDPTXEVjxWf smethod_36(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return new _3FFZvGWTAe7rsviKkDPTXEVjxWf(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0);
	}

	static Type smethod_37(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static Array smethod_38(Type type_0)
	{
		return Enum.GetValues(type_0);
	}

	static void smethod_39(_3FFZvGWTAe7rsviKkDPTXEVjxWf _3FFZvGWTAe7rsviKkDPTXEVjxWf_0, bool bool_0)
	{
		_3FFZvGWTAe7rsviKkDPTXEVjxWf_0._tZI6Co0uB31aGK7Qk4qvEImgcnO = bool_0;
	}

	static SpriteBatch smethod_40(GraphicsDevice graphicsDevice_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new SpriteBatch(graphicsDevice_0);
	}

	static SkeletonMeshRenderer smethod_41(GraphicsDevice graphicsDevice_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new SkeletonMeshRenderer(graphicsDevice_0);
	}

	static _wRd4nHuQQlAPEwrHOGkBfut6Uip smethod_42(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, int int_0, int int_1)
	{
		return new _wRd4nHuQQlAPEwrHOGkBfut6Uip(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, int_0, int_1);
	}

	static int smethod_43(GraphicsDeviceManager graphicsDeviceManager_0)
	{
		return graphicsDeviceManager_0.get_PreferredBackBufferWidth();
	}

	static int smethod_44(GraphicsDeviceManager graphicsDeviceManager_0)
	{
		return graphicsDeviceManager_0.get_PreferredBackBufferHeight();
	}

	static void smethod_45(_wRd4nHuQQlAPEwrHOGkBfut6Uip _wRd4nHuQQlAPEwrHOGkBfut6Uip_0, int int_0, int int_1, int int_2, int int_3)
	{
		_wRd4nHuQQlAPEwrHOGkBfut6Uip_0._2lMgp1KOzK9I6kd7CHrDq2A2CHm(int_0, int_1, int_2, int_3);
	}

	static RenderTarget2D smethod_46(GraphicsDevice graphicsDevice_0, int int_0, int int_1)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return new RenderTarget2D(graphicsDevice_0, int_0, int_1);
	}

	static int smethod_47(_wRd4nHuQQlAPEwrHOGkBfut6Uip _wRd4nHuQQlAPEwrHOGkBfut6Uip_0)
	{
		return _wRd4nHuQQlAPEwrHOGkBfut6Uip_0._jDxCg7GJnIKcLXDcUVSdbEIQL3Yb;
	}

	static int smethod_48(_wRd4nHuQQlAPEwrHOGkBfut6Uip _wRd4nHuQQlAPEwrHOGkBfut6Uip_0)
	{
		return _wRd4nHuQQlAPEwrHOGkBfut6Uip_0._ILCBrSipj1Qk4CsYzkEELxHvkkY;
	}

	static int smethod_49(_wRd4nHuQQlAPEwrHOGkBfut6Uip _wRd4nHuQQlAPEwrHOGkBfut6Uip_0)
	{
		return _wRd4nHuQQlAPEwrHOGkBfut6Uip_0._HZrLDiX4EPtS6jM8Odd9yJAatHq;
	}

	static int smethod_50(_wRd4nHuQQlAPEwrHOGkBfut6Uip _wRd4nHuQQlAPEwrHOGkBfut6Uip_0)
	{
		return _wRd4nHuQQlAPEwrHOGkBfut6Uip_0._ypqaDJqrkQlUKOrdZIXld5qQQ4x;
	}

	static void smethod_51(_3FFZvGWTAe7rsviKkDPTXEVjxWf _3FFZvGWTAe7rsviKkDPTXEVjxWf_0)
	{
		_3FFZvGWTAe7rsviKkDPTXEVjxWf_0._tiBFUHPEkedkbgvuX3whdeyjhKo();
	}

	static bool smethod_52(_3FFZvGWTAe7rsviKkDPTXEVjxWf _3FFZvGWTAe7rsviKkDPTXEVjxWf_0, Keys keys_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _3FFZvGWTAe7rsviKkDPTXEVjxWf_0._WZ4xYI5Q3hoCNX9QFzE3jfDwZBJ(keys_0);
	}

	static bool smethod_53(_3FFZvGWTAe7rsviKkDPTXEVjxWf _3FFZvGWTAe7rsviKkDPTXEVjxWf_0, Keys keys_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _3FFZvGWTAe7rsviKkDPTXEVjxWf_0._fy5ebLnmRsRXv9v7RKTFU5CGMaH(keys_0);
	}

	static void smethod_54(_wRd4nHuQQlAPEwrHOGkBfut6Uip _wRd4nHuQQlAPEwrHOGkBfut6Uip_0, GameTime gameTime_0)
	{
		_wRd4nHuQQlAPEwrHOGkBfut6Uip_0._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
	}

	static void smethod_55(_UmxbIbk7pgaod0bD7pS309P3Lns _UmxbIbk7pgaod0bD7pS309P3Lns_0)
	{
		_UmxbIbk7pgaod0bD7pS309P3Lns_0._LcX2y4hMIzQST4uGT2Q5Ce7vaGg();
	}

	static void smethod_56(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		_7UlnfykmEmZDFt3BmCKZekI43Ih_0._tO46aYSBLFIuhFNlhbrAeWbFDSf();
	}

	static void smethod_57(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		_7UlnfykmEmZDFt3BmCKZekI43Ih_0._4hlxzMzKSbVTbZUrEsP3dfw4x0h();
	}

	static void smethod_58(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, GameTime gameTime_0)
	{
		_7UlnfykmEmZDFt3BmCKZekI43Ih_0._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
	}

	static void smethod_59(_Z6EKIW3ycAwV2npYuxbFLcnCTrJ _Z6EKIW3ycAwV2npYuxbFLcnCTrJ_0, GameTime gameTime_0)
	{
		_Z6EKIW3ycAwV2npYuxbFLcnCTrJ_0._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
	}

	static void smethod_60(_nkzqFdEfDyLcyGikIKGcHjklI4y _nkzqFdEfDyLcyGikIKGcHjklI4y_0, GameTime gameTime_0)
	{
		_nkzqFdEfDyLcyGikIKGcHjklI4y_0._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
	}

	static void smethod_61(_nR8eroJOHehP0ZGyyTveo6aMTHg _nR8eroJOHehP0ZGyyTveo6aMTHg_0, GameTime gameTime_0)
	{
		_nR8eroJOHehP0ZGyyTveo6aMTHg_0._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
	}

	static bool smethod_62(_nR8eroJOHehP0ZGyyTveo6aMTHg _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
	{
		return _nR8eroJOHehP0ZGyyTveo6aMTHg_0._5PWaXifOOaIVN34JQsXRmvxXtqK;
	}

	static string[] smethod_63(_nR8eroJOHehP0ZGyyTveo6aMTHg _nR8eroJOHehP0ZGyyTveo6aMTHg_0, int int_0)
	{
		return _nR8eroJOHehP0ZGyyTveo6aMTHg_0._YYH5zlVZSFq4tPfc1vfadAxnqhV(int_0);
	}

	static void smethod_64(_TwlwMC1hhdSzamwGWEBxuUkz1gH _TwlwMC1hhdSzamwGWEBxuUkz1gH_0, GameTime gameTime_0)
	{
		_TwlwMC1hhdSzamwGWEBxuUkz1gH_0._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
	}

	static void smethod_65(_8lVOgkauaSHbAkAqHzI1K7mIyOI _8lVOgkauaSHbAkAqHzI1K7mIyOI_0, GameTime gameTime_0)
	{
		_8lVOgkauaSHbAkAqHzI1K7mIyOI_0._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
	}

	static Point smethod_66(_3FFZvGWTAe7rsviKkDPTXEVjxWf _3FFZvGWTAe7rsviKkDPTXEVjxWf_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _3FFZvGWTAe7rsviKkDPTXEVjxWf_0._U7CeYBJ1v1SoUxpX8emsQ9mWl5b;
	}

	static Point smethod_67(_wRd4nHuQQlAPEwrHOGkBfut6Uip _wRd4nHuQQlAPEwrHOGkBfut6Uip_0, Point point_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return _wRd4nHuQQlAPEwrHOGkBfut6Uip_0._u7uCdK9i8FnWhiaPn2bO2wIgUUuA(point_0);
	}

	static bool smethod_68(_3FFZvGWTAe7rsviKkDPTXEVjxWf _3FFZvGWTAe7rsviKkDPTXEVjxWf_0, Keys keys_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _3FFZvGWTAe7rsviKkDPTXEVjxWf_0._KGCwEHf8akeXdkHLKFg1caFxXUJ(keys_0);
	}

	static Keys smethod_69(Keys keys_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return Keyboard.GetKeyFromScancodeEXT(keys_0);
	}

	static char? smethod_70(Keys keys_0, bool bool_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return keys_0._O2N6YVYHWf1FQNPMGlnVDG8GTqe(bool_0);
	}

	static void smethod_71(KeyData[] keyData_0)
	{
		Gui.SetKeyboard(keyData_0);
	}

	static bool smethod_72(_3FFZvGWTAe7rsviKkDPTXEVjxWf _3FFZvGWTAe7rsviKkDPTXEVjxWf_0, _PMeRYZJaBCqgB9uADJFP3c14lxq _PMeRYZJaBCqgB9uADJFP3c14lxq_0)
	{
		return _3FFZvGWTAe7rsviKkDPTXEVjxWf_0._WZ4xYI5Q3hoCNX9QFzE3jfDwZBJ(_PMeRYZJaBCqgB9uADJFP3c14lxq_0);
	}

	static void smethod_73(bool[] bool_0)
	{
		Gui.SetButtons(bool_0);
	}

	static int smethod_74(_3FFZvGWTAe7rsviKkDPTXEVjxWf _3FFZvGWTAe7rsviKkDPTXEVjxWf_0)
	{
		return _3FFZvGWTAe7rsviKkDPTXEVjxWf_0._xFrCcVNAYrShLz07HqDph01nGwX;
	}

	static void smethod_75(int int_0, int int_1, int int_2)
	{
		Gui.SetMouse(int_0, int_1, int_2);
	}

	static TimeSpan smethod_76(GameTime gameTime_0)
	{
		return gameTime_0.get_ElapsedGameTime();
	}

	static TimeSpan smethod_77(GameTime gameTime_0)
	{
		return gameTime_0.get_TotalGameTime();
	}

	static int smethod_78(_wRd4nHuQQlAPEwrHOGkBfut6Uip _wRd4nHuQQlAPEwrHOGkBfut6Uip_0)
	{
		return _wRd4nHuQQlAPEwrHOGkBfut6Uip_0._KOuUew34v1oSMnWlHSFJuRBiu1c;
	}

	static int smethod_79(_wRd4nHuQQlAPEwrHOGkBfut6Uip _wRd4nHuQQlAPEwrHOGkBfut6Uip_0)
	{
		return _wRd4nHuQQlAPEwrHOGkBfut6Uip_0._dh9yjUXG1mhcfgwAWkWfggbGEIc;
	}

	static Process smethod_80(string string_0)
	{
		return Process.Start(string_0);
	}

	static GraphicsDevice smethod_81(GraphicsDeviceManager graphicsDeviceManager_0)
	{
		return graphicsDeviceManager_0.get_GraphicsDevice();
	}

	static void smethod_82(Game game_0)
	{
		game_0.Exit();
	}

	static void smethod_83(_gJR4g7ak0hsZAUWX1vJbMqG2P5I _gJR4g7ak0hsZAUWX1vJbMqG2P5I_0, Action action_0)
	{
		_gJR4g7ak0hsZAUWX1vJbMqG2P5I_0._PYAXEqRAOkDRRNqm1k71R7GJTJK(action_0);
	}

	static void smethod_84(_wRd4nHuQQlAPEwrHOGkBfut6Uip _wRd4nHuQQlAPEwrHOGkBfut6Uip_0)
	{
		_wRd4nHuQQlAPEwrHOGkBfut6Uip_0._n4NdRK3l14j7hHgGSJS4dI9LeYR();
	}

	static void smethod_85(_21uBmerICJi18moE2gpxlEipBgz _21uBmerICJi18moE2gpxlEipBgz_0)
	{
		_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._Wrz1IORok7yBtsQA3czQUmnP6Yl(_21uBmerICJi18moE2gpxlEipBgz_0);
	}

	static object smethod_86(Type type_0, object[] object_0)
	{
		return Activator.CreateInstance(type_0, object_0);
	}

	static Assembly smethod_87(Type type_0)
	{
		return Assembly.GetAssembly(type_0);
	}

	static Type[] smethod_88(Assembly assembly_0)
	{
		return assembly_0.GetTypes();
	}

	static bool smethod_89(Type type_0, Type type_1)
	{
		return type_0 == type_1;
	}

	static void smethod_90(string string_0, object[] object_0)
	{
		_ETHljYp3aQy9GQ1ZAzhfOYDI1sO._0rEYVY1cDKfLPVuLw54UlaIts2m(string_0, object_0);
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG smethod_91(_Z6EKIW3ycAwV2npYuxbFLcnCTrJ _Z6EKIW3ycAwV2npYuxbFLcnCTrJ_0)
	{
		return _Z6EKIW3ycAwV2npYuxbFLcnCTrJ_0._Hnb6mPvrZFgOMCIApIeMW88jSsF;
	}

	static _0SvCRe0EgzR9DhI3QPe1GUqubAt smethod_92(_nR8eroJOHehP0ZGyyTveo6aMTHg _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
	{
		return _nR8eroJOHehP0ZGyyTveo6aMTHg_0._Hnb6mPvrZFgOMCIApIeMW88jSsF;
	}

	static string smethod_93(_0SvCRe0EgzR9DhI3QPe1GUqubAt _0SvCRe0EgzR9DhI3QPe1GUqubAt_0)
	{
		return _0SvCRe0EgzR9DhI3QPe1GUqubAt_0._RB8fRXeQvK5vs7JEA0XfVCEpg1i;
	}

	static int smethod_94(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0, string string_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._fvTKDuNATrUxfXZVvltePz3vYkK(string_0);
	}

	static void smethod_95(_nR8eroJOHehP0ZGyyTveo6aMTHg _nR8eroJOHehP0ZGyyTveo6aMTHg_0, int int_0, int? nullable_0)
	{
		_nR8eroJOHehP0ZGyyTveo6aMTHg_0._4hlxzMzKSbVTbZUrEsP3dfw4x0h(int_0, nullable_0);
	}

	static string smethod_96(string string_0, object object_0)
	{
		return string.Format(string_0, object_0);
	}

	static void smethod_97(string string_0, object[] object_0)
	{
		_ETHljYp3aQy9GQ1ZAzhfOYDI1sO._IGmWy5uYuv50rXGtBNbMPGzJhWh(string_0, object_0);
	}

	static string smethod_98(string string_0)
	{
		return _K2047A8SCJdaw0LZKStEHOiH110._mDCA4AzhICQie5tejcL2uH7mcwf(string_0);
	}

	static string smethod_99(string string_0)
	{
		return _K2047A8SCJdaw0LZKStEHOiH110._GxOfTBefEUfWKWaWgxVRKsjugxE(string_0);
	}

	static JsonSerializerSettings smethod_100()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new JsonSerializerSettings();
	}

	static void smethod_101(JsonSerializerSettings jsonSerializerSettings_0, TypeNameHandling typeNameHandling_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		jsonSerializerSettings_0.set_TypeNameHandling(typeNameHandling_0);
	}

	static IList<JsonConverter> smethod_102(JsonSerializerSettings jsonSerializerSettings_0)
	{
		return jsonSerializerSettings_0.get_Converters();
	}

	static _VSQz6uDf5A6KqE8xqKxxcrkhZkA smethod_103()
	{
		return new _VSQz6uDf5A6KqE8xqKxxcrkhZkA();
	}

	static Assembly smethod_104(string string_0)
	{
		return Assembly.Load(string_0);
	}

	static _nR8eroJOHehP0ZGyyTveo6aMTHg smethod_105(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, _0SvCRe0EgzR9DhI3QPe1GUqubAt _0SvCRe0EgzR9DhI3QPe1GUqubAt_0, Assembly[] assembly_0)
	{
		return new _nR8eroJOHehP0ZGyyTveo6aMTHg(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, _0SvCRe0EgzR9DhI3QPe1GUqubAt_0, assembly_0);
	}

	static _zkUeZhJDizkmvvRfp4S0G7aap8J smethod_106()
	{
		return new _zkUeZhJDizkmvvRfp4S0G7aap8J();
	}

	static void smethod_107(_zkUeZhJDizkmvvRfp4S0G7aap8J _zkUeZhJDizkmvvRfp4S0G7aap8J_0, string string_0)
	{
		_zkUeZhJDizkmvvRfp4S0G7aap8J_0._RB8fRXeQvK5vs7JEA0XfVCEpg1i = string_0;
	}

	static _nR8eroJOHehP0ZGyyTveo6aMTHg._2MhByyFij8YJN7lWVuu8gpYhGCy smethod_108(_nR8eroJOHehP0ZGyyTveo6aMTHg _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
	{
		return _nR8eroJOHehP0ZGyyTveo6aMTHg_0._VQZivNSvg2tVi52cTTAQKYhamQK;
	}

	static _FMuxd8PX5exXCoRNDVuFFbnirof smethod_109(_nR8eroJOHehP0ZGyyTveo6aMTHg._2MhByyFij8YJN7lWVuu8gpYhGCy _2MhByyFij8YJN7lWVuu8gpYhGCy_0)
	{
		return _2MhByyFij8YJN7lWVuu8gpYhGCy_0._Hnb6mPvrZFgOMCIApIeMW88jSsF;
	}

	static int smethod_110(_FMuxd8PX5exXCoRNDVuFFbnirof _FMuxd8PX5exXCoRNDVuFFbnirof_0)
	{
		return _FMuxd8PX5exXCoRNDVuFFbnirof_0._8NBsjeWoi7V64KoA9ZtIybPpcom;
	}

	static void smethod_111(_zkUeZhJDizkmvvRfp4S0G7aap8J _zkUeZhJDizkmvvRfp4S0G7aap8J_0, int int_0)
	{
		_zkUeZhJDizkmvvRfp4S0G7aap8J_0._8NBsjeWoi7V64KoA9ZtIybPpcom = int_0;
	}

	static _3GMZuOfG1tyI9A65sJfkkPLAGdr smethod_112(_nR8eroJOHehP0ZGyyTveo6aMTHg._2MhByyFij8YJN7lWVuu8gpYhGCy _2MhByyFij8YJN7lWVuu8gpYhGCy_0)
	{
		return _2MhByyFij8YJN7lWVuu8gpYhGCy_0._SWODlbUkQEqfwrtprjLPOeGF7HO;
	}

	static int smethod_113(_3GMZuOfG1tyI9A65sJfkkPLAGdr _3GMZuOfG1tyI9A65sJfkkPLAGdr_0)
	{
		return _3GMZuOfG1tyI9A65sJfkkPLAGdr_0._WCJjJQRlVoZM67usdV2f1OR3arG;
	}

	static void smethod_114(_zkUeZhJDizkmvvRfp4S0G7aap8J _zkUeZhJDizkmvvRfp4S0G7aap8J_0, int int_0)
	{
		_zkUeZhJDizkmvvRfp4S0G7aap8J_0._WCJjJQRlVoZM67usdV2f1OR3arG = int_0;
	}

	static Type smethod_115(object object_0)
	{
		return object_0.GetType();
	}

	static string smethod_116(MemberInfo memberInfo_0)
	{
		return memberInfo_0.Name;
	}

	static void smethod_117(_zkUeZhJDizkmvvRfp4S0G7aap8J _zkUeZhJDizkmvvRfp4S0G7aap8J_0, string string_0)
	{
		_zkUeZhJDizkmvvRfp4S0G7aap8J_0._XbOXR6AypLIdJ3gBMGseGi3Wi2i = string_0;
	}

	static string smethod_118(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._hFeWJ5482CKD4l4529bYY1catC;
	}

	static void smethod_119(_zkUeZhJDizkmvvRfp4S0G7aap8J _zkUeZhJDizkmvvRfp4S0G7aap8J_0, string string_0)
	{
		_zkUeZhJDizkmvvRfp4S0G7aap8J_0._tTalXU1p5sOHKNCtH0ZDWD55yfD = string_0;
	}

	static Type smethod_120(object object_0)
	{
		return object_0.GetType();
	}

	static void smethod_121(_zkUeZhJDizkmvvRfp4S0G7aap8J _zkUeZhJDizkmvvRfp4S0G7aap8J_0, string string_0)
	{
		_zkUeZhJDizkmvvRfp4S0G7aap8J_0._KVSwpLj0RvURRswHn7ogRy4BRfd = string_0;
	}

	static _TwlwMC1hhdSzamwGWEBxuUkz1gH._qokIrmaaT3Lq6znW10HdrPUO9Fq smethod_122(_TwlwMC1hhdSzamwGWEBxuUkz1gH _TwlwMC1hhdSzamwGWEBxuUkz1gH_0)
	{
		return _TwlwMC1hhdSzamwGWEBxuUkz1gH_0._rNGHguvWdrugQVL2AI6bMMKSORN;
	}

	static void smethod_123(_zkUeZhJDizkmvvRfp4S0G7aap8J _zkUeZhJDizkmvvRfp4S0G7aap8J_0, _TwlwMC1hhdSzamwGWEBxuUkz1gH._qokIrmaaT3Lq6znW10HdrPUO9Fq _qokIrmaaT3Lq6znW10HdrPUO9Fq_0)
	{
		_zkUeZhJDizkmvvRfp4S0G7aap8J_0._zGDIuIFdpGkZI7SJBoEsZdKoN9F = _qokIrmaaT3Lq6znW10HdrPUO9Fq_0;
	}

	static bool smethod_124(_TwlwMC1hhdSzamwGWEBxuUkz1gH _TwlwMC1hhdSzamwGWEBxuUkz1gH_0)
	{
		return _TwlwMC1hhdSzamwGWEBxuUkz1gH_0._p3lU5oxIaFTVHUNFxJRnaHkXdsA;
	}

	static void smethod_125(_zkUeZhJDizkmvvRfp4S0G7aap8J _zkUeZhJDizkmvvRfp4S0G7aap8J_0, bool bool_0)
	{
		_zkUeZhJDizkmvvRfp4S0G7aap8J_0._xEhNfzWWkAGsoMu0XE2Cy84SXcp = bool_0;
	}

	static void smethod_126(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		_7UlnfykmEmZDFt3BmCKZekI43Ih_0._bHdVKtqP3Eb3DSJmuVTbkY8RtHP();
	}

	static _3IHp43rpkJgOBcY9lrIrwMuwWve smethod_127(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._VvFE2zgy4FbDjvaEvb67tXJ7aRm(string_0);
	}

	static _3IHp43rpkJgOBcY9lrIrwMuwWve smethod_128(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, NPCLocation npclocation_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._VvFE2zgy4FbDjvaEvb67tXJ7aRm(npclocation_0);
	}

	static void smethod_129(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		_7UlnfykmEmZDFt3BmCKZekI43Ih_0._yMMFQ2n4dqXlB1AEzmdkoKkPkX5();
	}

	static void smethod_130(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, _JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._ZzBuoSDMWwerejOO9Goyv2OCKgE = _JbeCmOie0phb2cbgG6DdGZrbs3pB_0;
	}

	static void smethod_131(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._g9Sx54kMPiHz5jrqWh4Kb1pTijH();
	}

	static _3IHp43rpkJgOBcY9lrIrwMuwWve smethod_132(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, _QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, _a2qVgWDIm3fBp49WubttSTPsx8K _a2qVgWDIm3fBp49WubttSTPsx8K_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._gWHVDvr9GDtRXP2zf2Md18MgZ4b(_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, _a2qVgWDIm3fBp49WubttSTPsx8K_0);
	}

	static _lRHDfpOTd4PxClZkjMpoakPEA9d smethod_133()
	{
		return new _lRHDfpOTd4PxClZkjMpoakPEA9d();
	}

	static void smethod_134(_lRHDfpOTd4PxClZkjMpoakPEA9d _lRHDfpOTd4PxClZkjMpoakPEA9d_0, int int_0)
	{
		_lRHDfpOTd4PxClZkjMpoakPEA9d_0._OgCTYsivFfJrd6rCMMRTgWbJ8UK = int_0;
	}

	static void smethod_135(_lRHDfpOTd4PxClZkjMpoakPEA9d _lRHDfpOTd4PxClZkjMpoakPEA9d_0, _opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		_lRHDfpOTd4PxClZkjMpoakPEA9d_0._M29jWtsDcmPvHjIYYSiTa8TbWri = _opIJo2jLUqdOL5yAFP4yzXce0DG_0;
	}

	static void smethod_136(_lRHDfpOTd4PxClZkjMpoakPEA9d _lRHDfpOTd4PxClZkjMpoakPEA9d_0, _zkUeZhJDizkmvvRfp4S0G7aap8J _zkUeZhJDizkmvvRfp4S0G7aap8J_0)
	{
		_lRHDfpOTd4PxClZkjMpoakPEA9d_0._q2NAvlMPupnT4cpCZEWLpac6jMe = _zkUeZhJDizkmvvRfp4S0G7aap8J_0;
	}

	static void smethod_137(_lRHDfpOTd4PxClZkjMpoakPEA9d _lRHDfpOTd4PxClZkjMpoakPEA9d_0, string string_0)
	{
		_lRHDfpOTd4PxClZkjMpoakPEA9d_0._hZ0bFFCDXp4CkpoVdtAUZT5cpIK = string_0;
	}

	static void smethod_138(_lRHDfpOTd4PxClZkjMpoakPEA9d _lRHDfpOTd4PxClZkjMpoakPEA9d_0, bool bool_0)
	{
		_lRHDfpOTd4PxClZkjMpoakPEA9d_0._QIaTN8Xtv0fmtjjEBsdflb1NoFl = bool_0;
	}

	static void smethod_139(int int_0, _lRHDfpOTd4PxClZkjMpoakPEA9d _lRHDfpOTd4PxClZkjMpoakPEA9d_0, string string_0)
	{
		_DW9IcpdMEINZmuzfrqmwsduBGih._7cuPUL8aamrg9daETH6zQk3RwbF(int_0, _lRHDfpOTd4PxClZkjMpoakPEA9d_0, string_0);
	}

	static void smethod_140(int int_0, _lRHDfpOTd4PxClZkjMpoakPEA9d _lRHDfpOTd4PxClZkjMpoakPEA9d_0)
	{
		_DW9IcpdMEINZmuzfrqmwsduBGih._3y7m8OGVjMe7WGIhZ66YOw3ITUE(int_0, _lRHDfpOTd4PxClZkjMpoakPEA9d_0);
	}

	static _lRHDfpOTd4PxClZkjMpoakPEA9d smethod_141(int int_0, string string_0)
	{
		return _DW9IcpdMEINZmuzfrqmwsduBGih._sabDA8yXNR8DIRSbHjOcXx1e1Ax(int_0, string_0);
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG smethod_142(_lRHDfpOTd4PxClZkjMpoakPEA9d _lRHDfpOTd4PxClZkjMpoakPEA9d_0)
	{
		return _lRHDfpOTd4PxClZkjMpoakPEA9d_0._M29jWtsDcmPvHjIYYSiTa8TbWri;
	}

	static void smethod_143(_Z6EKIW3ycAwV2npYuxbFLcnCTrJ _Z6EKIW3ycAwV2npYuxbFLcnCTrJ_0, _opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		_Z6EKIW3ycAwV2npYuxbFLcnCTrJ_0._Hnb6mPvrZFgOMCIApIeMW88jSsF = _opIJo2jLUqdOL5yAFP4yzXce0DG_0;
	}

	static bool smethod_144(_lRHDfpOTd4PxClZkjMpoakPEA9d _lRHDfpOTd4PxClZkjMpoakPEA9d_0)
	{
		return _lRHDfpOTd4PxClZkjMpoakPEA9d_0._QIaTN8Xtv0fmtjjEBsdflb1NoFl;
	}

	static DialogueSpeed smethod_145(_eNOTHZZiu5nx6PrADzfLyng3Igc _eNOTHZZiu5nx6PrADzfLyng3Igc_0)
	{
		return _eNOTHZZiu5nx6PrADzfLyng3Igc_0._wVLRBSMULz8GfedBPXaVJB0sBEO;
	}

	static void smethod_146(DialogueSpeed dialogueSpeed_0)
	{
		_nkzqFdEfDyLcyGikIKGcHjklI4y._NhL238TaCbkDiY6HXlWXZzzUYkm = dialogueSpeed_0;
	}

	static bool smethod_147(_eNOTHZZiu5nx6PrADzfLyng3Igc _eNOTHZZiu5nx6PrADzfLyng3Igc_0)
	{
		return _eNOTHZZiu5nx6PrADzfLyng3Igc_0._sbK0941BvW8HgPboNwOhIAd2jP3;
	}

	static void smethod_148(bool bool_0)
	{
		_nkzqFdEfDyLcyGikIKGcHjklI4y._fUgDiz7KX8TZUVzFlTeXMOhmfUT = bool_0;
	}

	static _zkUeZhJDizkmvvRfp4S0G7aap8J smethod_149(_lRHDfpOTd4PxClZkjMpoakPEA9d _lRHDfpOTd4PxClZkjMpoakPEA9d_0)
	{
		return _lRHDfpOTd4PxClZkjMpoakPEA9d_0._q2NAvlMPupnT4cpCZEWLpac6jMe;
	}

	static string smethod_150(_lRHDfpOTd4PxClZkjMpoakPEA9d _lRHDfpOTd4PxClZkjMpoakPEA9d_0)
	{
		return _lRHDfpOTd4PxClZkjMpoakPEA9d_0._hZ0bFFCDXp4CkpoVdtAUZT5cpIK;
	}

	static _lRHDfpOTd4PxClZkjMpoakPEA9d smethod_151(int int_0)
	{
		return _DW9IcpdMEINZmuzfrqmwsduBGih._NyR9YmfkeF4CXGOi1ENApzh6B5V(int_0);
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG smethod_152()
	{
		return _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
	}

	static List<_iDN1IKOu3e1uADYzeMEUon5D9fg> smethod_153(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._7u6aevGWBE7ABqrBXoaPTkywcVo;
	}

	static _iDN1IKOu3e1uADYzeMEUon5D9fg smethod_154()
	{
		return new _iDN1IKOu3e1uADYzeMEUon5D9fg();
	}

	static void smethod_155(_iDN1IKOu3e1uADYzeMEUon5D9fg _iDN1IKOu3e1uADYzeMEUon5D9fg_0, string string_0)
	{
		_iDN1IKOu3e1uADYzeMEUon5D9fg_0._dFaIUhufvE2Ld5IjNEwmPAqqraj = string_0;
	}

	static void smethod_156(_iDN1IKOu3e1uADYzeMEUon5D9fg _iDN1IKOu3e1uADYzeMEUon5D9fg_0, string string_0)
	{
		_iDN1IKOu3e1uADYzeMEUon5D9fg_0._D5QiLGGNtfoCEnZIUPvH4OKqUabA = string_0;
	}

	static void smethod_157(_iDN1IKOu3e1uADYzeMEUon5D9fg _iDN1IKOu3e1uADYzeMEUon5D9fg_0, string string_0)
	{
		_iDN1IKOu3e1uADYzeMEUon5D9fg_0._NvMJ5jDaeRR7HysERrVDtSlxaI5 = string_0;
	}

	static void smethod_158(_iDN1IKOu3e1uADYzeMEUon5D9fg _iDN1IKOu3e1uADYzeMEUon5D9fg_0, DateTime dateTime_0)
	{
		_iDN1IKOu3e1uADYzeMEUon5D9fg_0._QkxGXtWLzE0Z8JKyKkMiiph9giD = dateTime_0;
	}

	static void smethod_159(_nR8eroJOHehP0ZGyyTveo6aMTHg _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
	{
		_nR8eroJOHehP0ZGyyTveo6aMTHg_0._haICL4qkfkOLhPhofWQH1GmjZx5();
	}

	static void smethod_160()
	{
		_nkzqFdEfDyLcyGikIKGcHjklI4y._gVRGC9VAGHCLvP8p5Q4mqLPvFCm();
	}

	static void smethod_161()
	{
		_nkzqFdEfDyLcyGikIKGcHjklI4y._h0KfaNiikKlJV2KkRPIdVDKVJnC();
	}

	static void smethod_162(_gJR4g7ak0hsZAUWX1vJbMqG2P5I _gJR4g7ak0hsZAUWX1vJbMqG2P5I_0, Action action_0)
	{
		_gJR4g7ak0hsZAUWX1vJbMqG2P5I_0._FegL010tc92iskjjyD0T33dDwNE(action_0);
	}
}
