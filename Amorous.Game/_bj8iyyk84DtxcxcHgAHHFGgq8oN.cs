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
					_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_1(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._XbOXR6AypLIdJ3gBMGseGi3Wi2i, _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_0(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r));
				}
				if (_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_2(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r) != null)
				{
					CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._gYGB98heFqsLp9tgJbdCP01IKV2(_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_2(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r));
					_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_5(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._KVSwpLj0RvURRswHn7ogRy4BRfd, _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_3(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r), _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_4(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r));
				}
				foreach (_zkUeZhJDizkmvvRfp4S0G7aap8J._CIFXVF6lKl3nSrVOhqjcFXDVlXc item in _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_6(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r))
				{
					_QGGOTxZ8aNWGh0hc26wcmx8wmwT qGGOTxZ8aNWGh0hc26wcmx8wmwT_ = CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._TwQHHdbdRFRy2ctTZabNfz1Htrg(_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_7(item), _a2qVgWDIm3fBp49WubttSTPsx8K.Background);
					_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_12(qGGOTxZ8aNWGh0hc26wcmx8wmwT_, _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_8(item), _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_9(item), _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_10(item), _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_11(item));
					_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve = _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_13(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._xfiKuXXh5LQA9CUQiex6tutzFKQ, _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_7(item));
					_3IHp43rpkJgOBcY9lrIrwMuwWve._VNgmwYSLsJyyiR6cPQ35UHJBR4d = _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_14(item);
				}
				if (_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_15(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r))
				{
					CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Ta8oiGRfjrRGtgUaA5S061UepZb = CS_0024_003C_003E8__locals0._hvKKVpHsQ6yw7YBy97lS8UDtil;
					_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_18(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Ta8oiGRfjrRGtgUaA5S061UepZb, _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_16(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r), (int?)_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_17(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r));
				}
				else
				{
					_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_19(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Qj2G6fpAF4mGsATgkV8DPBF3aA1A, (Action)delegate
					{
						CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Ta8oiGRfjrRGtgUaA5S061UepZb = CS_0024_003C_003E8__locals0._hvKKVpHsQ6yw7YBy97lS8UDtil;
						_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_18(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Ta8oiGRfjrRGtgUaA5S061UepZb, _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_16(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r), (int?)_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_17(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r));
					});
				}
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
				_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_1(_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._XbOXR6AypLIdJ3gBMGseGi3Wi2i, _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_0(_wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r));
			}
			if (_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_2(_wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r) != null)
			{
				_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._gYGB98heFqsLp9tgJbdCP01IKV2(_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_2(_wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r));
				_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_5(_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._KVSwpLj0RvURRswHn7ogRy4BRfd, _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_3(_wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r), _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_4(_wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r));
			}
			foreach (_zkUeZhJDizkmvvRfp4S0G7aap8J._CIFXVF6lKl3nSrVOhqjcFXDVlXc item in _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_6(_wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r))
			{
				_QGGOTxZ8aNWGh0hc26wcmx8wmwT qGGOTxZ8aNWGh0hc26wcmx8wmwT_ = _wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._TwQHHdbdRFRy2ctTZabNfz1Htrg(_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_7(item), _a2qVgWDIm3fBp49WubttSTPsx8K.Background);
				_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_12(qGGOTxZ8aNWGh0hc26wcmx8wmwT_, _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_8(item), _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_9(item), _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_10(item), _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_11(item));
				_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve = _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_13(_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._xfiKuXXh5LQA9CUQiex6tutzFKQ, _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_7(item));
				_3IHp43rpkJgOBcY9lrIrwMuwWve._VNgmwYSLsJyyiR6cPQ35UHJBR4d = _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_14(item);
			}
			if (_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_15(_wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r))
			{
				_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Ta8oiGRfjrRGtgUaA5S061UepZb = _hvKKVpHsQ6yw7YBy97lS8UDtil;
				_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_18(_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Ta8oiGRfjrRGtgUaA5S061UepZb, _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_16(_wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r), (int?)_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_17(_wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r));
				return;
			}
			_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_19(_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Qj2G6fpAF4mGsATgkV8DPBF3aA1A, (Action)delegate
			{
				_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Ta8oiGRfjrRGtgUaA5S061UepZb = _hvKKVpHsQ6yw7YBy97lS8UDtil;
				_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_18(_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Ta8oiGRfjrRGtgUaA5S061UepZb, _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_16(_wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r), (int?)_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_17(_wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r));
			});
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
		_4L7hfXrWoDdArQiscG4ukHCV46B = game_0;
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_4();
		if (bool_0)
		{
			GraphicsDeviceManager obj = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_5(game_0);
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_6(obj, bool_0: false);
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_7(obj, 1024);
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_8(obj, 768);
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_9(obj, bool_0: true);
			_ARAAkijJ1FF23wI2rNDaw7mTOeJ = obj;
		}
		else if (!_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_10())
		{
			DisplayMode displayMode_ = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_16(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_15());
			GraphicsDeviceManager obj2 = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_5(game_0);
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_6(obj2, bool_0: true);
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_7(obj2, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_17(displayMode_));
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_8(obj2, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_18(displayMode_));
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_9(obj2, bool_0: true);
			_ARAAkijJ1FF23wI2rNDaw7mTOeJ = obj2;
		}
		else
		{
			GraphicsDeviceManager obj3 = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_5(game_0);
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_6(obj3, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_12(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_11()));
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_7(obj3, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_13(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_11()));
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_8(obj3, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_14(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_11()));
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_9(obj3, bool_0: true);
			_ARAAkijJ1FF23wI2rNDaw7mTOeJ = obj3;
		}
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_19(_uwNDZuqdFb9tyQtlQMxiz1DQ7x8, "Content-Release");
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_23(_4L7hfXrWoDdArQiscG4ukHCV46B, (ContentManager)(object)_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_22(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_20(_uwNDZuqdFb9tyQtlQMxiz1DQ7x8), _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_21(_uwNDZuqdFb9tyQtlQMxiz1DQ7x8)));
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
		string string_ = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_32(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_31(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_30()), "NonSteam");
		if (!_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_33(string_) && !_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_33(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_34(string_, ".txt")))
		{
			_p3BLtW5bCDzTS86VFihe1pfwDoP = new _KDiaUloddpdv1QwixDEBIJs6IMA();
			if (!_p3BLtW5bCDzTS86VFihe1pfwDoP._oD87G7SXjsTukw7IVWxVlVFEgvA(778700u, this))
			{
				_p3BLtW5bCDzTS86VFihe1pfwDoP = null;
			}
		}
		_db5uuwyBnUwxthW14pfDBlBoqUp = new _bm5ybW5ND5sDF6bvP0sbYyOpvP(this, _p3BLtW5bCDzTS86VFihe1pfwDoP);
	}

	public void _eW1Nkl8VqFHVExM8l3IqxgSbMBg()
	{
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		string string_ = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_32(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_31(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_30()), "ShowMeSomeBooty");
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_35(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_33(string_) || _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_33(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_34(string_, ".txt")));
		_YNCmHGUHBydamu5BEECMWoB65VfA = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_36((_JbeCmOie0phb2cbgG6DdGZrbs3pB)this);
		_gylJZYyc3mVB0fbHPCctDIg4UAE = (Keys[])_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_38(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_37(typeof(Keys).TypeHandle));
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_39(_RbWJ7YGnYHCSoD44MRW1h5X6E7E, bool_0: true);
		_ZXUztyGtStF4WzGVig7wu43cfnf = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_40(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_1(_4L7hfXrWoDdArQiscG4ukHCV46B));
		_BuJyoOT5ylWcIMxjcKRnxVmYvBd = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_41(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_1(_4L7hfXrWoDdArQiscG4ukHCV46B));
		_chds2l0ZCMMghly7dv4eik3iSH5 = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_42((_JbeCmOie0phb2cbgG6DdGZrbs3pB)this, 1920, 1080);
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_45(_chds2l0ZCMMghly7dv4eik3iSH5, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_43(_ARAAkijJ1FF23wI2rNDaw7mTOeJ), _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_44(_ARAAkijJ1FF23wI2rNDaw7mTOeJ), _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_43(_ARAAkijJ1FF23wI2rNDaw7mTOeJ), _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_44(_ARAAkijJ1FF23wI2rNDaw7mTOeJ));
		_j2ynkEUaNLywHdchuAYJWHF3l9DA = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_46(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_1(_4L7hfXrWoDdArQiscG4ukHCV46B), 1920, 1080);
		_j2ynkEUaNLywHdchuAYJWHF3l9DA._w2YD42TXOY22EP4Mpp7wzDUO4xv((RenderTargetUsage)1);
		_CCbe95wREA1VhjgpntSpzsQ19He = new Rectangle(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_47(_chds2l0ZCMMghly7dv4eik3iSH5), _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_48(_chds2l0ZCMMghly7dv4eik3iSH5), _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_49(_chds2l0ZCMMghly7dv4eik3iSH5), _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_50(_chds2l0ZCMMghly7dv4eik3iSH5));
		Gui.set_Renderer((ISquidRenderer)(object)new _k8LAl8bPyzLGEpo59dKFGU4sCQ(_4L7hfXrWoDdArQiscG4ukHCV46B));
		Gui.get_Renderer().SetTexture("PhoneScreen", (object)_4L7hfXrWoDdArQiscG4ukHCV46B.get_Content().Load<Texture2D>("Assets/GUI/Phone/PhoneScreen"));
		Gui.get_Renderer().SetTexture("Contact_DJ", (object)_4L7hfXrWoDdArQiscG4ukHCV46B.get_Content().Load<Texture2D>("Assets/GUI/Phone/Contacts/DJ"));
		_KyKsjBAROeUAsKraBIxtuHTSPwg._Uh2GhEF2pLNc3a7l5WMdPGP2bZd = _pql4s9X0U3svdBghGax6VsdF2Gq;
		_CCtbrNWS4Gi5hRSEsXYI5VzS7gI = new _Z6EKIW3ycAwV2npYuxbFLcnCTrJ();
		_RA1aFlOff0jGfI2cKUGhYI1MRLBA = new _gJR4g7ak0hsZAUWX1vJbMqG2P5I(_4L7hfXrWoDdArQiscG4ukHCV46B.get_GraphicsDevice());
		_6M30VBCyHzfi1RYZYx7uJAHl1EC = new _UmxbIbk7pgaod0bD7pS309P3Lns(_4L7hfXrWoDdArQiscG4ukHCV46B.get_Content());
		_PxO28nve6nqbBLBJKrzHMRbOasHA = new _AUtA43NfhBNYDqRrVB1t9VQxe1v(_4L7hfXrWoDdArQiscG4ukHCV46B.get_Content());
		_9rxbJ7LsE3DhACUHVlPZaixc5Jp = new _XJasjdoOf6PYbfaC5MsbXSjDWV3();
		Texture2D texture2D_ = _4L7hfXrWoDdArQiscG4ukHCV46B.get_Content().Load<Texture2D>("Assets/GUI/Dialogue/dialogue");
		Texture2D texture2D_2 = _4L7hfXrWoDdArQiscG4ukHCV46B.get_Content().Load<Texture2D>("Assets/GUI/Dialogue/button");
		_0SvmBhkBX8SImQwyvuy5xVObqLn = _4L7hfXrWoDdArQiscG4ukHCV46B.get_Content().Load<Texture2D>("Assets/GUI/Squid/DefaultCursor");
		_LWcoDwIWvf8DT3nQmNe5z8fkUvI = true;
		_xnYepZuegigJCU2jcbZsfVIakzF = _4L7hfXrWoDdArQiscG4ukHCV46B.get_Content().Load<SpriteFont>("Assets/GUI/Fonts/Bold-26");
		SpriteFont spriteFont_ = _4L7hfXrWoDdArQiscG4ukHCV46B.get_Content().Load<SpriteFont>("Assets/GUI/Fonts/BoldItalic-26");
		_P62DygY6CKZG8s5wqDu0uAFksjs = new _nkzqFdEfDyLcyGikIKGcHjklI4y(this, texture2D_, texture2D_2, _xnYepZuegigJCU2jcbZsfVIakzF, spriteFont_);
		_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p _3CCr8Bt1rkuzt0M6gYLbceJGV0p = _DW9IcpdMEINZmuzfrqmwsduBGih._jVNnsNFMjoGC9t7v83qLI8vEZSH();
		if (!_3CCr8Bt1rkuzt0M6gYLbceJGV0p._r4LqoJiAr5K9UiLsUzUDbcJDQqo)
		{
			_lRHDfpOTd4PxClZkjMpoakPEA9d lRHDfpOTd4PxClZkjMpoakPEA9d = (_3CCr8Bt1rkuzt0M6gYLbceJGV0p._3y7m8OGVjMe7WGIhZ66YOw3ITUE ? _DW9IcpdMEINZmuzfrqmwsduBGih._NyR9YmfkeF4CXGOi1ENApzh6B5V(_3CCr8Bt1rkuzt0M6gYLbceJGV0p._B3FsRMcQWBXzFf3nLOBKzncessO) : _DW9IcpdMEINZmuzfrqmwsduBGih._sabDA8yXNR8DIRSbHjOcXx1e1Ax(_3CCr8Bt1rkuzt0M6gYLbceJGV0p._B3FsRMcQWBXzFf3nLOBKzncessO));
			if (lRHDfpOTd4PxClZkjMpoakPEA9d != null)
			{
				_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._yuFBJdi7mxrwMFQ57BjLjSq6ESj._Hnb6mPvrZFgOMCIApIeMW88jSsF = lRHDfpOTd4PxClZkjMpoakPEA9d._M29jWtsDcmPvHjIYYSiTa8TbWri;
			}
		}
		_SUHe9KzfAd477MCCYxTvqFf3efl = new _poenyHBGUusBcnNcTFB9MQBV72R(this, _4L7hfXrWoDdArQiscG4ukHCV46B.get_Content());
		_5Anqe6GAAkzemoAXYpJmgMlk1yz._3DInasj5B11bCcV5BIRvLE1Ay7w = true;
		_5Anqe6GAAkzemoAXYpJmgMlk1yz._LsIdcBLhaqZr03JCpCYZrI9ztVF();
		_DNbNFzOKO7vtoVmjI32p1Snwmpe = true;
		Gui.get_Renderer().SetTexture("MessageIconCoby", (object)_uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Coby"));
		Gui.get_Renderer().SetTexture("MessageIconDustin", (object)_uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Dustin"));
		Gui.get_Renderer().SetTexture("MessageIconJax", (object)_uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Jax"));
		Gui.get_Renderer().SetTexture("MessageIconLex", (object)_uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Lex"));
		Gui.get_Renderer().SetTexture("MessageIconMercy", (object)_uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Mercy"));
		Gui.get_Renderer().SetTexture("MessageIconRemy", (object)_uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Remy"));
		Gui.get_Renderer().SetTexture("MessageIconSeth", (object)_uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Seth"));
		Gui.get_Renderer().SetTexture("MessageIconSkye", (object)_uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Skye"));
		Gui.get_Renderer().SetTexture("MessageIconZenith", (object)_uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Zenith"));
		Gui.get_Renderer().SetTexture("MessageIconGeneric", (object)_uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Generic"));
		Gui.get_Renderer().SetTexture("MessageIconDJ", (object)_uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_DJ"));
		Gui.get_Renderer().SetTexture("MessageIconShootingRange", (object)_uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_ShootingRange"));
		Gui.get_Renderer().SetTexture("MessageIconCooking", (object)_uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Cooking"));
		_g9Sx54kMPiHz5jrqWh4Kb1pTijH();
	}

	protected virtual void _g9Sx54kMPiHz5jrqWh4Kb1pTijH()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		_xfiKuXXh5LQA9CUQiex6tutzFKQ = new EmptyScene(this);
		_Qj2G6fpAF4mGsATgkV8DPBF3aA1A._E7yBM68AWt7OGHJ5D6xYA8RK8tAA(new Color(0, 0, 0, 255));
		_OxLRmpxixplTKChiTPUKAx4uTLG<MainMenuScene>(delegate
		{
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_162(_Qj2G6fpAF4mGsATgkV8DPBF3aA1A, (Action)null);
		});
	}

	public void _wm1aB8mBRRffPWUAA0o5Xar2w5p()
	{
	}

	public void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected I4, but got Unknown
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
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
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_51(_YNCmHGUHBydamu5BEECMWoB65VfA);
		if (_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_52(_RbWJ7YGnYHCSoD44MRW1h5X6E7E, (Keys)164) && _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_53(_RbWJ7YGnYHCSoD44MRW1h5X6E7E, (Keys)112))
		{
			_DNbNFzOKO7vtoVmjI32p1Snwmpe = !_DNbNFzOKO7vtoVmjI32p1Snwmpe;
		}
		if ((_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_52(_RbWJ7YGnYHCSoD44MRW1h5X6E7E, (Keys)164) && _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_53(_RbWJ7YGnYHCSoD44MRW1h5X6E7E, (Keys)13)) || _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_53(_RbWJ7YGnYHCSoD44MRW1h5X6E7E, (Keys)113))
		{
			_qGU55VUfbqFJ4l6ArNW4JRcLekg();
		}
		if (_p3BLtW5bCDzTS86VFihe1pfwDoP == null && (_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_53(_RbWJ7YGnYHCSoD44MRW1h5X6E7E, (Keys)123) || _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_53(_RbWJ7YGnYHCSoD44MRW1h5X6E7E, (Keys)44)))
		{
			_VN2LxjGLZldLNfiJ1OniiaXfYBg();
		}
		if (_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_53(_RbWJ7YGnYHCSoD44MRW1h5X6E7E, (Keys)9))
		{
			_Fs6y8qquj1mRHLz6xw6KoI4SAvH = !_Fs6y8qquj1mRHLz6xw6KoI4SAvH;
		}
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_54(_chds2l0ZCMMghly7dv4eik3iSH5, gameTime_0);
		_RA1aFlOff0jGfI2cKUGhYI1MRLBA._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
		_6M30VBCyHzfi1RYZYx7uJAHl1EC._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_55(_6M30VBCyHzfi1RYZYx7uJAHl1EC);
		if (_Z8BClcChRJrlB6tR1VPJcycVpHN != null)
		{
			if (_xfiKuXXh5LQA9CUQiex6tutzFKQ != null)
			{
				_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_56(_xfiKuXXh5LQA9CUQiex6tutzFKQ);
			}
			_xfiKuXXh5LQA9CUQiex6tutzFKQ = _Z8BClcChRJrlB6tR1VPJcycVpHN;
			_Z8BClcChRJrlB6tR1VPJcycVpHN = null;
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_57(_xfiKuXXh5LQA9CUQiex6tutzFKQ);
		}
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_58(_xfiKuXXh5LQA9CUQiex6tutzFKQ, gameTime_0);
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_59(_CCtbrNWS4Gi5hRSEsXYI5VzS7gI, gameTime_0);
		_SUHe9KzfAd477MCCYxTvqFf3efl._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0, _chds2l0ZCMMghly7dv4eik3iSH5);
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_60(_P62DygY6CKZG8s5wqDu0uAFksjs, gameTime_0);
		if (_Ta8oiGRfjrRGtgUaA5S061UepZb != null)
		{
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_61(_Ta8oiGRfjrRGtgUaA5S061UepZb, gameTime_0);
			if (!_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_62(_Ta8oiGRfjrRGtgUaA5S061UepZb))
			{
				_sUwMzXXmi9PdDQ0bFQhbGQJUPTe = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_63(_Ta8oiGRfjrRGtgUaA5S061UepZb, 5);
				_Ta8oiGRfjrRGtgUaA5S061UepZb = null;
			}
		}
		if (_ieTMbMiu3eGRdmzTMofKoJopZAf != null)
		{
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_64(_ieTMbMiu3eGRdmzTMofKoJopZAf, gameTime_0);
		}
		if (_fp8jsuSnELXqf2yy2JQDaXDCBVQ != null)
		{
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_65(_fp8jsuSnELXqf2yy2JQDaXDCBVQ, gameTime_0);
		}
		_9rxbJ7LsE3DhACUHVlPZaixc5Jp._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
		Point val = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_67(_chds2l0ZCMMghly7dv4eik3iSH5, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_66(_RbWJ7YGnYHCSoD44MRW1h5X6E7E));
		List<KeyData> list = new List<KeyData>();
		Keys[] gylJZYyc3mVB0fbHPCctDIg4UAE = _gylJZYyc3mVB0fbHPCctDIg4UAE;
		foreach (Keys keys_ in gylJZYyc3mVB0fbHPCctDIg4UAE)
		{
			bool flag = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_53(_RbWJ7YGnYHCSoD44MRW1h5X6E7E, keys_);
			bool flag2 = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_68(_RbWJ7YGnYHCSoD44MRW1h5X6E7E, keys_);
			if (flag || flag2)
			{
				Keys? val2 = _o0Y4SOgMHY7iQXRQkPwaQ9pMBBl._HSj1lr89AFIB9adVhSrAeWjS1xC[_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_69(keys_)];
				if (val2.HasValue)
				{
					list.Add(new KeyData
					{
						Scancode = (int)val2.Value,
						Char = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_70(keys_, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_52(_RbWJ7YGnYHCSoD44MRW1h5X6E7E, (Keys)160) || _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_52(_RbWJ7YGnYHCSoD44MRW1h5X6E7E, (Keys)161)),
						Pressed = flag,
						Released = flag2
					});
				}
			}
		}
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_71(list.ToArray());
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_73(new bool[2]
		{
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_72(_RbWJ7YGnYHCSoD44MRW1h5X6E7E, _PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton),
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_72(_RbWJ7YGnYHCSoD44MRW1h5X6E7E, _PMeRYZJaBCqgB9uADJFP3c14lxq.RightButton)
		});
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_75(val.X, val.Y, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_74(_RbWJ7YGnYHCSoD44MRW1h5X6E7E));
		Gui.set_TimeElapsed((float)_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_76(gameTime_0).Milliseconds);
		if (_p3BLtW5bCDzTS86VFihe1pfwDoP != null)
		{
			_p3BLtW5bCDzTS86VFihe1pfwDoP._tiBFUHPEkedkbgvuX3whdeyjhKo();
		}
	}

	public void _f5ctqAmdNsZ889UjM4LxDm8WGxA(GameTime gameTime_0)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Unknown result type (might be due to invalid IL or missing references)
		//IL_069a: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d3: Unknown result type (might be due to invalid IL or missing references)
		_boyt8NIMtKsAGSTcjHeL0WMbFxs._AmIUCcrmrrQiiirja7DoiZSjXuv = (float)_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_77(gameTime_0).TotalSeconds;
		_4L7hfXrWoDdArQiscG4ukHCV46B.get_GraphicsDevice().SetRenderTarget(_j2ynkEUaNLywHdchuAYJWHF3l9DA);
		_4L7hfXrWoDdArQiscG4ukHCV46B.get_GraphicsDevice().Clear(Color.get_Black());
		_xfiKuXXh5LQA9CUQiex6tutzFKQ._f5ctqAmdNsZ889UjM4LxDm8WGxA(_ZXUztyGtStF4WzGVig7wu43cfnf, _BuJyoOT5ylWcIMxjcKRnxVmYvBd, _chds2l0ZCMMghly7dv4eik3iSH5._oLRK3f26Sw9AKBKi0iR44APDZEt);
		if (_chds2l0ZCMMghly7dv4eik3iSH5._q1DGEI79OguKnK8dCIgPvfGc9Bi)
		{
			_xfiKuXXh5LQA9CUQiex6tutzFKQ._f5ctqAmdNsZ889UjM4LxDm8WGxA(_ZXUztyGtStF4WzGVig7wu43cfnf, _BuJyoOT5ylWcIMxjcKRnxVmYvBd, _chds2l0ZCMMghly7dv4eik3iSH5._00mMjYnrMXUVj1aA8AYlqz1bdTI);
		}
		else if (_chds2l0ZCMMghly7dv4eik3iSH5._c3CMfxjIJAFFcSeEIluZOLANXnE)
		{
			_xfiKuXXh5LQA9CUQiex6tutzFKQ._f5ctqAmdNsZ889UjM4LxDm8WGxA(_ZXUztyGtStF4WzGVig7wu43cfnf, _BuJyoOT5ylWcIMxjcKRnxVmYvBd, _chds2l0ZCMMghly7dv4eik3iSH5._MPYpHIXdfUjJipVgAvBCGASJZiZ);
		}
		if (_ieTMbMiu3eGRdmzTMofKoJopZAf != null)
		{
			_ieTMbMiu3eGRdmzTMofKoJopZAf._f5ctqAmdNsZ889UjM4LxDm8WGxA(_ZXUztyGtStF4WzGVig7wu43cfnf, _BuJyoOT5ylWcIMxjcKRnxVmYvBd);
		}
		if (_DNbNFzOKO7vtoVmjI32p1Snwmpe)
		{
			_SUHe9KzfAd477MCCYxTvqFf3efl._f5ctqAmdNsZ889UjM4LxDm8WGxA(_ZXUztyGtStF4WzGVig7wu43cfnf, _BuJyoOT5ylWcIMxjcKRnxVmYvBd);
		}
		if (_fp8jsuSnELXqf2yy2JQDaXDCBVQ != null)
		{
			_fp8jsuSnELXqf2yy2JQDaXDCBVQ._f5ctqAmdNsZ889UjM4LxDm8WGxA(_ZXUztyGtStF4WzGVig7wu43cfnf);
		}
		_xfiKuXXh5LQA9CUQiex6tutzFKQ._Z70nK2EA1n5FNJxjWP0TzHQ0Lzb(_ZXUztyGtStF4WzGVig7wu43cfnf);
		_RA1aFlOff0jGfI2cKUGhYI1MRLBA._f5ctqAmdNsZ889UjM4LxDm8WGxA(_ZXUztyGtStF4WzGVig7wu43cfnf, _chds2l0ZCMMghly7dv4eik3iSH5);
		if (_DNbNFzOKO7vtoVmjI32p1Snwmpe)
		{
			_P62DygY6CKZG8s5wqDu0uAFksjs._f5ctqAmdNsZ889UjM4LxDm8WGxA(_ZXUztyGtStF4WzGVig7wu43cfnf);
		}
		_9rxbJ7LsE3DhACUHVlPZaixc5Jp._f5ctqAmdNsZ889UjM4LxDm8WGxA(_ZXUztyGtStF4WzGVig7wu43cfnf);
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
			_ZXUztyGtStF4WzGVig7wu43cfnf._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, "[Generic]", _Vh2qdN4Ha62herl19def6PyuanQ, Color.get_White());
			_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
			zXUztyGtStF4WzGVig7wu43cfnf = _ZXUztyGtStF4WzGVig7wu43cfnf;
			xnYepZuegigJCU2jcbZsfVIakzF = _xnYepZuegigJCU2jcbZsfVIakzF;
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
					goto IL_0220;
				}
			}
			obj = "None";
			goto IL_0220;
		}
		goto IL_04d3;
		IL_0220:
		zXUztyGtStF4WzGVig7wu43cfnf._FY70IFLoBond3ORPe0ndCLvIeVcA(xnYepZuegigJCU2jcbZsfVIakzF, "Scene: " + (string?)obj, _Vh2qdN4Ha62herl19def6PyuanQ, Color.get_White());
		_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
		SpriteBatch zXUztyGtStF4WzGVig7wu43cfnf2 = _ZXUztyGtStF4WzGVig7wu43cfnf;
		SpriteFont xnYepZuegigJCU2jcbZsfVIakzF2 = _xnYepZuegigJCU2jcbZsfVIakzF;
		Color sWODlbUkQEqfwrtprjLPOeGF7HO = _RA1aFlOff0jGfI2cKUGhYI1MRLBA._SWODlbUkQEqfwrtprjLPOeGF7HO;
		zXUztyGtStF4WzGVig7wu43cfnf2._FY70IFLoBond3ORPe0ndCLvIeVcA(xnYepZuegigJCU2jcbZsfVIakzF2, "ScreenFader: " + ((Color)(ref sWODlbUkQEqfwrtprjLPOeGF7HO)).get_A(), _Vh2qdN4Ha62herl19def6PyuanQ, Color.get_White());
		_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
		_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
		_ZXUztyGtStF4WzGVig7wu43cfnf._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, "[Cutscenes]", _Vh2qdN4Ha62herl19def6PyuanQ, Color.get_White());
		_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
		_ZXUztyGtStF4WzGVig7wu43cfnf._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, string.Format("Cutscene in progress: {0}", (_Ta8oiGRfjrRGtgUaA5S061UepZb == null) ? "No" : "Yes"), _Vh2qdN4Ha62herl19def6PyuanQ, Color.get_White());
		_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
		if (_sUwMzXXmi9PdDQ0bFQhbGQJUPTe != null)
		{
			_ZXUztyGtStF4WzGVig7wu43cfnf._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, "Cutscene: " + _sUwMzXXmi9PdDQ0bFQhbGQJUPTe[0], _Vh2qdN4Ha62herl19def6PyuanQ, Color.get_White());
			_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
			_ZXUztyGtStF4WzGVig7wu43cfnf._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, "Stage: " + _sUwMzXXmi9PdDQ0bFQhbGQJUPTe[1], _Vh2qdN4Ha62herl19def6PyuanQ, Color.get_White());
			_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
			_ZXUztyGtStF4WzGVig7wu43cfnf._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, "Path: " + _sUwMzXXmi9PdDQ0bFQhbGQJUPTe[2], _Vh2qdN4Ha62herl19def6PyuanQ, Color.get_White());
			_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
			_ZXUztyGtStF4WzGVig7wu43cfnf._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, "Current: " + _sUwMzXXmi9PdDQ0bFQhbGQJUPTe[3], _Vh2qdN4Ha62herl19def6PyuanQ, Color.get_White());
			_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
		}
		else
		{
			_ZXUztyGtStF4WzGVig7wu43cfnf._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, "Cutscene: None", _Vh2qdN4Ha62herl19def6PyuanQ, Color.get_White());
			_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
		}
		_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
		_ZXUztyGtStF4WzGVig7wu43cfnf._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, "Press Tab to toggle", _Vh2qdN4Ha62herl19def6PyuanQ, Color.get_White());
		_Vh2qdN4Ha62herl19def6PyuanQ.Y += 40f;
		_ZXUztyGtStF4WzGVig7wu43cfnf.End();
		goto IL_04d3;
		IL_065c:
		_4L7hfXrWoDdArQiscG4ukHCV46B.get_GraphicsDevice().SetRenderTarget((RenderTarget2D)null);
		_4L7hfXrWoDdArQiscG4ukHCV46B.get_GraphicsDevice().Clear(Color.get_Black());
		_ZXUztyGtStF4WzGVig7wu43cfnf.Begin();
		_ZXUztyGtStF4WzGVig7wu43cfnf.Draw((Texture2D)(object)_j2ynkEUaNLywHdchuAYJWHF3l9DA, _CCbe95wREA1VhjgpntSpzsQ19He, Color.get_White());
		if (_LWcoDwIWvf8DT3nQmNe5z8fkUvI)
		{
			_ZXUztyGtStF4WzGVig7wu43cfnf.Draw(_0SvmBhkBX8SImQwyvuy5xVObqLn, _RbWJ7YGnYHCSoD44MRW1h5X6E7E._6M9HDt28e1QHBuYsAXgqiY8jVlA, _CCtbrNWS4Gi5hRSEsXYI5VzS7gI._Hnb6mPvrZFgOMCIApIeMW88jSsF._uOkbmfW26QVAvyEMQakki9kTMDbA);
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
				((Texture2D)_j2ynkEUaNLywHdchuAYJWHF3l9DA).SaveAsPng(stream, ((Texture2D)_j2ynkEUaNLywHdchuAYJWHF3l9DA).get_Width(), ((Texture2D)_j2ynkEUaNLywHdchuAYJWHF3l9DA).get_Height());
			}
			if (_p3BLtW5bCDzTS86VFihe1pfwDoP != null)
			{
				_p3BLtW5bCDzTS86VFihe1pfwDoP._9K6cA2OPGJaecqk3spsceT9ilNI(text, ((Texture2D)_j2ynkEUaNLywHdchuAYJWHF3l9DA).get_Width(), ((Texture2D)_j2ynkEUaNLywHdchuAYJWHF3l9DA).get_Height());
			}
			if (_Fs6y8qquj1mRHLz6xw6KoI4SAvH && _sUwMzXXmi9PdDQ0bFQhbGQJUPTe != null)
			{
				path2 = $"{text}.txt";
				array = new object[5];
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
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_6(_ARAAkijJ1FF23wI2rNDaw7mTOeJ, bool_0);
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_7(_ARAAkijJ1FF23wI2rNDaw7mTOeJ, bool_0 ? _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_17(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_16(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_15())) : int_0);
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_8(_ARAAkijJ1FF23wI2rNDaw7mTOeJ, bool_0 ? _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_18(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_16(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_15())) : int_1);
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_81(_ARAAkijJ1FF23wI2rNDaw7mTOeJ).set_Viewport(new Viewport(0, 0, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_43(_ARAAkijJ1FF23wI2rNDaw7mTOeJ), _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_44(_ARAAkijJ1FF23wI2rNDaw7mTOeJ)));
		_chds2l0ZCMMghly7dv4eik3iSH5._2lMgp1KOzK9I6kd7CHrDq2A2CHm(int_0, int_1, _ARAAkijJ1FF23wI2rNDaw7mTOeJ.get_PreferredBackBufferWidth(), _ARAAkijJ1FF23wI2rNDaw7mTOeJ.get_PreferredBackBufferHeight());
		_CCbe95wREA1VhjgpntSpzsQ19He = new Rectangle(_chds2l0ZCMMghly7dv4eik3iSH5._jDxCg7GJnIKcLXDcUVSdbEIQL3Yb, _chds2l0ZCMMghly7dv4eik3iSH5._ILCBrSipj1Qk4CsYzkEELxHvkkY, _chds2l0ZCMMghly7dv4eik3iSH5._HZrLDiX4EPtS6jM8Odd9yJAatHq, _chds2l0ZCMMghly7dv4eik3iSH5._ypqaDJqrkQlUKOrdZIXld5qQQ4x);
		_ARAAkijJ1FF23wI2rNDaw7mTOeJ.ApplyChanges();
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
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_83(_RA1aFlOff0jGfI2cKUGhYI1MRLBA, (Action)delegate
		{
			_OxLRmpxixplTKChiTPUKAx4uTLG(string_0, delegate
			{
				_9rqW5HzG3UXapFpEBDu18BZJznG.smethod_0(_RA1aFlOff0jGfI2cKUGhYI1MRLBA, (Action)null);
			});
		});
	}

	public void _k9wUPeU1Ga7cygiuGP8TT6aPLWF(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_83(_RA1aFlOff0jGfI2cKUGhYI1MRLBA, (Action)delegate
		{
			_OxLRmpxixplTKChiTPUKAx4uTLG(_7UlnfykmEmZDFt3BmCKZekI43Ih_0, delegate
			{
				_cHlGOT3sD7LBx6eSMMmMOdLnHjd.smethod_0(_RA1aFlOff0jGfI2cKUGhYI1MRLBA, (Action)null);
			});
		});
	}

	public void _OxLRmpxixplTKChiTPUKAx4uTLG<T>(Action action_0 = null) where T : _7UlnfykmEmZDFt3BmCKZekI43Ih
	{
		if (_ColBlKEOYSqQMmmj719vN58K9aN != null)
		{
			Action colBlKEOYSqQMmmj719vN58K9aN = _ColBlKEOYSqQMmmj719vN58K9aN;
			_ColBlKEOYSqQMmmj719vN58K9aN = null;
			colBlKEOYSqQMmmj719vN58K9aN();
		}
		_ColBlKEOYSqQMmmj719vN58K9aN = action_0;
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_84(_chds2l0ZCMMghly7dv4eik3iSH5);
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_85((_21uBmerICJi18moE2gpxlEipBgz)null);
		_fp8jsuSnELXqf2yy2JQDaXDCBVQ = null;
		_ieTMbMiu3eGRdmzTMofKoJopZAf = null;
		_Z8BClcChRJrlB6tR1VPJcycVpHN = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_86(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_37(typeof(T).TypeHandle), new object[1] { this }) as _7UlnfykmEmZDFt3BmCKZekI43Ih;
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
		IEnumerable<Type> source = from type_0 in _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_88(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_87(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_37(typeof(_bj8iyyk84DtxcxcHgAHHFGgq8oN).TypeHandle)))
			where _PzOBAEclhQj3NzBZIEIMnKCuYsr.smethod_3(_PzOBAEclhQj3NzBZIEIMnKCuYsr.smethod_2(typeof(_7UlnfykmEmZDFt3BmCKZekI43Ih).TypeHandle), type_0)
			select type_0;
		Type type_ = source.FirstOrDefault((Type type_0) => _AsW3kNzx3Ky1kSe2GNlryDfK39C.smethod_1(_AsW3kNzx3Ky1kSe2GNlryDfK39C.smethod_0((MemberInfo)type_0), string_0));
		if (!_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_89(type_, (Type)null))
		{
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_84(_chds2l0ZCMMghly7dv4eik3iSH5);
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_85((_21uBmerICJi18moE2gpxlEipBgz)null);
			_fp8jsuSnELXqf2yy2JQDaXDCBVQ = null;
			_ieTMbMiu3eGRdmzTMofKoJopZAf = null;
			_Z8BClcChRJrlB6tR1VPJcycVpHN = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_86(type_, new object[1] { this }) as _7UlnfykmEmZDFt3BmCKZekI43Ih;
			_NdzU0m9x8QDKpVv3DrQmzY5KduB = true;
		}
		else
		{
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_90("Failed to load scene '{0}'", new object[1] { string_0 });
		}
	}

	public void _OxLRmpxixplTKChiTPUKAx4uTLG(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, Action action_0 = null)
	{
		if (_ColBlKEOYSqQMmmj719vN58K9aN != null)
		{
			Action colBlKEOYSqQMmmj719vN58K9aN = _ColBlKEOYSqQMmmj719vN58K9aN;
			_ColBlKEOYSqQMmmj719vN58K9aN = null;
			colBlKEOYSqQMmmj719vN58K9aN();
		}
		_ColBlKEOYSqQMmmj719vN58K9aN = action_0;
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_84(_chds2l0ZCMMghly7dv4eik3iSH5);
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_85((_21uBmerICJi18moE2gpxlEipBgz)null);
		_fp8jsuSnELXqf2yy2JQDaXDCBVQ = null;
		_ieTMbMiu3eGRdmzTMofKoJopZAf = null;
		_Z8BClcChRJrlB6tR1VPJcycVpHN = _7UlnfykmEmZDFt3BmCKZekI43Ih_0;
		_NdzU0m9x8QDKpVv3DrQmzY5KduB = true;
	}

	public void _gYGB98heFqsLp9tgJbdCP01IKV2(string string_0)
	{
		IEnumerable<Type> source = from type_0 in _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_88(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_87(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_37(typeof(_bj8iyyk84DtxcxcHgAHHFGgq8oN).TypeHandle)))
			where _PzOBAEclhQj3NzBZIEIMnKCuYsr.smethod_3(_PzOBAEclhQj3NzBZIEIMnKCuYsr.smethod_2(typeof(_TwlwMC1hhdSzamwGWEBxuUkz1gH).TypeHandle), type_0)
			select type_0;
		Type type_ = source.FirstOrDefault((Type type_0) => _FzfT43cjHYNexO7AyOgI7RzVHys.smethod_1(_FzfT43cjHYNexO7AyOgI7RzVHys.smethod_0((MemberInfo)type_0), string_0));
		if (!_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_89(type_, (Type)null))
		{
			_ieTMbMiu3eGRdmzTMofKoJopZAf = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_86(type_, new object[1] { _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_2(_4L7hfXrWoDdArQiscG4ukHCV46B) }) as _TwlwMC1hhdSzamwGWEBxuUkz1gH;
		}
		else
		{
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_90("Failed to load sexscene '{0}'", new object[1] { string_0 });
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
		if (_nR8eroJOHehP0ZGyyTveo6aMTHg_0 != null)
		{
			_Ta8oiGRfjrRGtgUaA5S061UepZb = _nR8eroJOHehP0ZGyyTveo6aMTHg_0;
			int int_ = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_94(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_91(_CCtbrNWS4Gi5hRSEsXYI5VzS7gI), _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_93(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_92(_nR8eroJOHehP0ZGyyTveo6aMTHg_0)));
			_poenyHBGUusBcnNcTFB9MQBV72R._RiDuYMeg3EHnBUteUcAb8VlfQVl();
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_95(_Ta8oiGRfjrRGtgUaA5S061UepZb, int_, (int?)null);
		}
	}

	private _nR8eroJOHehP0ZGyyTveo6aMTHg _5yVCuTv9lVSCCxs7cUlv79ysuRh(string string_0)
	{
		string string_ = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_32(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_21(_uwNDZuqdFb9tyQtlQMxiz1DQ7x8), _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_96("Content-Mods/Data/Quests/{0}.json", (object)string_0));
		string string_2 = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_32(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_21(_uwNDZuqdFb9tyQtlQMxiz1DQ7x8), _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_96("Data/Quests/{0}.json", (object)string_0));
		string text;
		if (_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_33(string_))
		{
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_97("Loaded modded cutscene '{0}'", new object[1] { string_0 });
			text = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_98(string_);
		}
		else
		{
			if (!_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_33(string_2))
			{
				_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_90("Failed to load cutscene '{0}'", new object[1] { string_0 });
				return null;
			}
			text = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_99(string_2);
		}
		JsonSerializerSettings obj = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_100();
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_101(obj, (TypeNameHandling)4);
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_102(obj).Add((JsonConverter)(object)_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_103());
		JsonSerializerSettings val = obj;
		_0SvCRe0EgzR9DhI3QPe1GUqubAt _0SvCRe0EgzR9DhI3QPe1GUqubAt = JsonConvert.DeserializeObject<_0SvCRe0EgzR9DhI3QPe1GUqubAt>(text, val);
		if (_0SvCRe0EgzR9DhI3QPe1GUqubAt != null)
		{
			return _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_105((_JbeCmOie0phb2cbgG6DdGZrbs3pB)this, _0SvCRe0EgzR9DhI3QPe1GUqubAt, new Assembly[1] { _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_104("Amorous.Game") });
		}
		return null;
	}

	private _zkUeZhJDizkmvvRfp4S0G7aap8J _PSROht9Hy1Ik63UUdnKDUGBA0yQ()
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (_5zNdOw7qHmuCAPJFMr3SsZdBlCr != null)
		{
			_zkUeZhJDizkmvvRfp4S0G7aap8J zkUeZhJDizkmvvRfp4S0G7aap8J = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_106();
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_107(zkUeZhJDizkmvvRfp4S0G7aap8J, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_93(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_92(_5zNdOw7qHmuCAPJFMr3SsZdBlCr)));
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_111(zkUeZhJDizkmvvRfp4S0G7aap8J, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_110(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_109(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_108(_5zNdOw7qHmuCAPJFMr3SsZdBlCr))));
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_114(zkUeZhJDizkmvvRfp4S0G7aap8J, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_113(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_112(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_108(_5zNdOw7qHmuCAPJFMr3SsZdBlCr))));
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_117(zkUeZhJDizkmvvRfp4S0G7aap8J, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_116((MemberInfo)_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_115((object)_XbOXR6AypLIdJ3gBMGseGi3Wi2i)));
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_119(zkUeZhJDizkmvvRfp4S0G7aap8J, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_118(_XbOXR6AypLIdJ3gBMGseGi3Wi2i));
			_TwlwMC1hhdSzamwGWEBxuUkz1gH kVSwpLj0RvURRswHn7ogRy4BRfd = _KVSwpLj0RvURRswHn7ogRy4BRfd;
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_121(zkUeZhJDizkmvvRfp4S0G7aap8J, (kVSwpLj0RvURRswHn7ogRy4BRfd == null) ? null : _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_116((MemberInfo)_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_120((object)kVSwpLj0RvURRswHn7ogRy4BRfd)));
			_TwlwMC1hhdSzamwGWEBxuUkz1gH kVSwpLj0RvURRswHn7ogRy4BRfd2 = _KVSwpLj0RvURRswHn7ogRy4BRfd;
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_123(zkUeZhJDizkmvvRfp4S0G7aap8J, (kVSwpLj0RvURRswHn7ogRy4BRfd2 != null) ? _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_122(kVSwpLj0RvURRswHn7ogRy4BRfd2) : _TwlwMC1hhdSzamwGWEBxuUkz1gH._qokIrmaaT3Lq6znW10HdrPUO9Fq.Idle);
			_TwlwMC1hhdSzamwGWEBxuUkz1gH kVSwpLj0RvURRswHn7ogRy4BRfd3 = _KVSwpLj0RvURRswHn7ogRy4BRfd;
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_125(zkUeZhJDizkmvvRfp4S0G7aap8J, kVSwpLj0RvURRswHn7ogRy4BRfd3 != null && _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_124(kVSwpLj0RvURRswHn7ogRy4BRfd3));
			Color sWODlbUkQEqfwrtprjLPOeGF7HO = _Qj2G6fpAF4mGsATgkV8DPBF3aA1A._SWODlbUkQEqfwrtprjLPOeGF7HO;
			zkUeZhJDizkmvvRfp4S0G7aap8J._KR48sJtGCfgf7jYtIsrj2N1iO3n = ((Color)(ref sWODlbUkQEqfwrtprjLPOeGF7HO)).get_A() > 0;
			_zkUeZhJDizkmvvRfp4S0G7aap8J zkUeZhJDizkmvvRfp4S0G7aap8J2 = zkUeZhJDizkmvvRfp4S0G7aap8J;
			zkUeZhJDizkmvvRfp4S0G7aap8J2._gWHVDvr9GDtRXP2zf2Md18MgZ4b(_xfiKuXXh5LQA9CUQiex6tutzFKQ._VvFE2zgy4FbDjvaEvb67tXJ7aRm(NPCLocation.Left));
			zkUeZhJDizkmvvRfp4S0G7aap8J2._gWHVDvr9GDtRXP2zf2Md18MgZ4b(_xfiKuXXh5LQA9CUQiex6tutzFKQ._VvFE2zgy4FbDjvaEvb67tXJ7aRm(NPCLocation.Middle));
			zkUeZhJDizkmvvRfp4S0G7aap8J2._gWHVDvr9GDtRXP2zf2Md18MgZ4b(_xfiKuXXh5LQA9CUQiex6tutzFKQ._VvFE2zgy4FbDjvaEvb67tXJ7aRm(NPCLocation.Right));
			return zkUeZhJDizkmvvRfp4S0G7aap8J2;
		}
		return null;
	}

	private void _dmwpjPj0QtK7OW2M486hHkm5FKH(_zkUeZhJDizkmvvRfp4S0G7aap8J _zkUeZhJDizkmvvRfp4S0G7aap8J_0)
	{
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_83(_Qj2G6fpAF4mGsATgkV8DPBF3aA1A, (Action)delegate
		{
			_nR8eroJOHehP0ZGyyTveo6aMTHg _hvKKVpHsQ6yw7YBy97lS8UDtil = _5yVCuTv9lVSCCxs7cUlv79ysuRh(_pRMaMNHrUICTrn5AyRDYx65hOVDA.smethod_0(_zkUeZhJDizkmvvRfp4S0G7aap8J_0));
			if (_hvKKVpHsQ6yw7YBy97lS8UDtil != null)
			{
				_OxLRmpxixplTKChiTPUKAx4uTLG(_pRMaMNHrUICTrn5AyRDYx65hOVDA.smethod_1(_zkUeZhJDizkmvvRfp4S0G7aap8J_0), delegate
				{
					if (_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_0(_zkUeZhJDizkmvvRfp4S0G7aap8J_0) != null)
					{
						_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_1(_XbOXR6AypLIdJ3gBMGseGi3Wi2i, _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_0(_zkUeZhJDizkmvvRfp4S0G7aap8J_0));
					}
					if (_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_2(_zkUeZhJDizkmvvRfp4S0G7aap8J_0) != null)
					{
						_gYGB98heFqsLp9tgJbdCP01IKV2(_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_2(_zkUeZhJDizkmvvRfp4S0G7aap8J_0));
						_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_5(_KVSwpLj0RvURRswHn7ogRy4BRfd, _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_3(_zkUeZhJDizkmvvRfp4S0G7aap8J_0), _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_4(_zkUeZhJDizkmvvRfp4S0G7aap8J_0));
					}
					foreach (_zkUeZhJDizkmvvRfp4S0G7aap8J._CIFXVF6lKl3nSrVOhqjcFXDVlXc item in _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_6(_zkUeZhJDizkmvvRfp4S0G7aap8J_0))
					{
						_QGGOTxZ8aNWGh0hc26wcmx8wmwT qGGOTxZ8aNWGh0hc26wcmx8wmwT_ = _TwQHHdbdRFRy2ctTZabNfz1Htrg(_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_7(item), _a2qVgWDIm3fBp49WubttSTPsx8K.Background);
						_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_12(qGGOTxZ8aNWGh0hc26wcmx8wmwT_, _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_8(item), _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_9(item), _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_10(item), _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_11(item));
						_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve = _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_13(_xfiKuXXh5LQA9CUQiex6tutzFKQ, _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_7(item));
						_3IHp43rpkJgOBcY9lrIrwMuwWve._VNgmwYSLsJyyiR6cPQ35UHJBR4d = _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_14(item);
					}
					if (_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_15(_zkUeZhJDizkmvvRfp4S0G7aap8J_0))
					{
						_Ta8oiGRfjrRGtgUaA5S061UepZb = _hvKKVpHsQ6yw7YBy97lS8UDtil;
						_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_18(_Ta8oiGRfjrRGtgUaA5S061UepZb, _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_16(_zkUeZhJDizkmvvRfp4S0G7aap8J_0), (int?)_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_17(_zkUeZhJDizkmvvRfp4S0G7aap8J_0));
					}
					else
					{
						_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_19(_Qj2G6fpAF4mGsATgkV8DPBF3aA1A, (Action)delegate
						{
							_Ta8oiGRfjrRGtgUaA5S061UepZb = _hvKKVpHsQ6yw7YBy97lS8UDtil;
							_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_18(_Ta8oiGRfjrRGtgUaA5S061UepZb, _eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_16(_zkUeZhJDizkmvvRfp4S0G7aap8J_0), (int?)_eg2fyrjBR4bPqUReWrIXIUOH1Fn.smethod_17(_zkUeZhJDizkmvvRfp4S0G7aap8J_0));
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
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_126(_xfiKuXXh5LQA9CUQiex6tutzFKQ);
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
			return null;
		}
		return _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_127(_xfiKuXXh5LQA9CUQiex6tutzFKQ, string_0)?._4QLHHCk23T1BjK7acKxASbkCefG;
	}

	public _QGGOTxZ8aNWGh0hc26wcmx8wmwT _VvFE2zgy4FbDjvaEvb67tXJ7aRm(NPCLocation npclocation_0)
	{
		if (_xfiKuXXh5LQA9CUQiex6tutzFKQ == null)
		{
			return null;
		}
		return _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_128(_xfiKuXXh5LQA9CUQiex6tutzFKQ, npclocation_0)?._4QLHHCk23T1BjK7acKxASbkCefG;
	}

	public _QGGOTxZ8aNWGh0hc26wcmx8wmwT _TwQHHdbdRFRy2ctTZabNfz1Htrg(string string_0, _a2qVgWDIm3fBp49WubttSTPsx8K _a2qVgWDIm3fBp49WubttSTPsx8K_0)
	{
		if (_xfiKuXXh5LQA9CUQiex6tutzFKQ != null)
		{
			_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_127(_xfiKuXXh5LQA9CUQiex6tutzFKQ, string_0);
			if (_3IHp43rpkJgOBcY9lrIrwMuwWve == null)
			{
				IEnumerable<Type> source = from type_0 in _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_88(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_87(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_37(typeof(_bj8iyyk84DtxcxcHgAHHFGgq8oN).TypeHandle)))
					where _PzOBAEclhQj3NzBZIEIMnKCuYsr.smethod_3(_PzOBAEclhQj3NzBZIEIMnKCuYsr.smethod_2(typeof(_QGGOTxZ8aNWGh0hc26wcmx8wmwT).TypeHandle), type_0) && !_PzOBAEclhQj3NzBZIEIMnKCuYsr.smethod_4(type_0)
					select type_0;
				Type type_ = source.FirstOrDefault((Type type_0) => _1oSOYUYBONRKpcOISvejZTGlh6P.smethod_1(_1oSOYUYBONRKpcOISvejZTGlh6P.smethod_0((MemberInfo)type_0), string_0));
				if (!_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_89(type_, (Type)null))
				{
					if (_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_86(type_, new object[1] { this }) is _QGGOTxZ8aNWGh0hc26wcmx8wmwT qGGOTxZ8aNWGh0hc26wcmx8wmwT)
					{
						_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_130(qGGOTxZ8aNWGh0hc26wcmx8wmwT, (_JbeCmOie0phb2cbgG6DdGZrbs3pB)this);
						_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_131(qGGOTxZ8aNWGh0hc26wcmx8wmwT);
						_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_132(_xfiKuXXh5LQA9CUQiex6tutzFKQ, qGGOTxZ8aNWGh0hc26wcmx8wmwT, (_a2qVgWDIm3fBp49WubttSTPsx8K_0 == _a2qVgWDIm3fBp49WubttSTPsx8K.None) ? _a2qVgWDIm3fBp49WubttSTPsx8K.Background : _a2qVgWDIm3fBp49WubttSTPsx8K_0);
						return qGGOTxZ8aNWGh0hc26wcmx8wmwT;
					}
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_90("Failed to instance npc '{0}'", new object[1] { string_0 });
					return null;
				}
				_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_90("Failed to load npc '{0}'", new object[1] { string_0 });
				return null;
			}
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT _4QLHHCk23T1BjK7acKxASbkCefG = _3IHp43rpkJgOBcY9lrIrwMuwWve._4QLHHCk23T1BjK7acKxASbkCefG;
			if (_4QLHHCk23T1BjK7acKxASbkCefG != null && _4QLHHCk23T1BjK7acKxASbkCefG._SC7QlorMIWTLSkD757wC7ybszpE)
			{
				return null;
			}
			_3IHp43rpkJgOBcY9lrIrwMuwWve._dPmC8tBC0iph2YBAFmztEsmwUdSA = ((_a2qVgWDIm3fBp49WubttSTPsx8K_0 == _a2qVgWDIm3fBp49WubttSTPsx8K.None) ? _3IHp43rpkJgOBcY9lrIrwMuwWve._dPmC8tBC0iph2YBAFmztEsmwUdSA : _a2qVgWDIm3fBp49WubttSTPsx8K_0);
			_3IHp43rpkJgOBcY9lrIrwMuwWve._ac2H6kMdrgPhXXxabsikjji4SiT = ((_3IHp43rpkJgOBcY9lrIrwMuwWve._dPmC8tBC0iph2YBAFmztEsmwUdSA == _a2qVgWDIm3fBp49WubttSTPsx8K.Background) ? 1 : 3);
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_129(_xfiKuXXh5LQA9CUQiex6tutzFKQ);
			return _3IHp43rpkJgOBcY9lrIrwMuwWve._4QLHHCk23T1BjK7acKxASbkCefG;
		}
		return null;
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
		_lRHDfpOTd4PxClZkjMpoakPEA9d lRHDfpOTd4PxClZkjMpoakPEA9d = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_141(int_0, "save");
		if (lRHDfpOTd4PxClZkjMpoakPEA9d != null)
		{
			_9gbCIL8lNtgBPuVMJ6pA7rCsMoT._NG0eIZcXsX6Fp38GhuED0LKeWHf(lRHDfpOTd4PxClZkjMpoakPEA9d);
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_143(_CCtbrNWS4Gi5hRSEsXYI5VzS7gI, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_142(lRHDfpOTd4PxClZkjMpoakPEA9d));
			_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_144(lRHDfpOTd4PxClZkjMpoakPEA9d);
			_poenyHBGUusBcnNcTFB9MQBV72R._AZrO8MxMUE7cKsFYTQ4k9O3q7yC()._Xrfjrxr72hHh4bDdQB7HzEbJUCb();
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_146(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_145(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_11()));
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_148(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_147(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_11()));
			if (_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_149(lRHDfpOTd4PxClZkjMpoakPEA9d) != null)
			{
				_dmwpjPj0QtK7OW2M486hHkm5FKH(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_149(lRHDfpOTd4PxClZkjMpoakPEA9d));
			}
			else
			{
				if (!_dKSAtbg8U4PX1oOcOJ2BFewVtcI.Contains(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_150(lRHDfpOTd4PxClZkjMpoakPEA9d)))
				{
					_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_137(lRHDfpOTd4PxClZkjMpoakPEA9d, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_116((MemberInfo)_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_37(typeof(ClubInsideScene).TypeHandle)));
				}
				if (!_9gbCIL8lNtgBPuVMJ6pA7rCsMoT._RUw8RieezXPoVSmbk3eROtfKXVi(this, lRHDfpOTd4PxClZkjMpoakPEA9d))
				{
					_k9wUPeU1Ga7cygiuGP8TT6aPLWF(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_150(lRHDfpOTd4PxClZkjMpoakPEA9d));
				}
			}
			return true;
		}
		return false;
	}

	public bool _1yDW5GeZ2MCcssz8ohrF9CK913i(int int_0)
	{
		_nvTYmpWmxq2DhO8ubfi3j5rZdLA();
		_lRHDfpOTd4PxClZkjMpoakPEA9d lRHDfpOTd4PxClZkjMpoakPEA9d = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_151(int_0);
		if (lRHDfpOTd4PxClZkjMpoakPEA9d != null)
		{
			_9gbCIL8lNtgBPuVMJ6pA7rCsMoT._NG0eIZcXsX6Fp38GhuED0LKeWHf(lRHDfpOTd4PxClZkjMpoakPEA9d);
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_143(_CCtbrNWS4Gi5hRSEsXYI5VzS7gI, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_142(lRHDfpOTd4PxClZkjMpoakPEA9d));
			_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_144(lRHDfpOTd4PxClZkjMpoakPEA9d);
			_poenyHBGUusBcnNcTFB9MQBV72R._AZrO8MxMUE7cKsFYTQ4k9O3q7yC()._Xrfjrxr72hHh4bDdQB7HzEbJUCb();
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_146(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_145(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_11()));
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_148(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_147(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_11()));
			if (!_dKSAtbg8U4PX1oOcOJ2BFewVtcI.Contains(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_150(lRHDfpOTd4PxClZkjMpoakPEA9d)))
			{
				_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_137(lRHDfpOTd4PxClZkjMpoakPEA9d, _bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_116((MemberInfo)_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_37(typeof(ClubInsideScene).TypeHandle)));
			}
			if (!_9gbCIL8lNtgBPuVMJ6pA7rCsMoT._RUw8RieezXPoVSmbk3eROtfKXVi(this, lRHDfpOTd4PxClZkjMpoakPEA9d))
			{
				_k9wUPeU1Ga7cygiuGP8TT6aPLWF(_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_150(lRHDfpOTd4PxClZkjMpoakPEA9d));
			}
			return true;
		}
		return false;
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
		_9rxbJ7LsE3DhACUHVlPZaixc5Jp._EXfoFnp1OKxeZbd4GcVZMCO2urH(string_0, string_1, string_2);
	}

	private void _pql4s9X0U3svdBghGax6VsdF2Gq()
	{
		_nvTYmpWmxq2DhO8ubfi3j5rZdLA();
		_k9wUPeU1Ga7cygiuGP8TT6aPLWF<MainMenuScene>();
	}

	private void _nvTYmpWmxq2DhO8ubfi3j5rZdLA()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (_5zNdOw7qHmuCAPJFMr3SsZdBlCr != null)
		{
			_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_159(_5zNdOw7qHmuCAPJFMr3SsZdBlCr);
		}
		_poenyHBGUusBcnNcTFB9MQBV72R._RiDuYMeg3EHnBUteUcAb8VlfQVl();
		_poenyHBGUusBcnNcTFB9MQBV72R._AZrO8MxMUE7cKsFYTQ4k9O3q7yC()._haICL4qkfkOLhPhofWQH1GmjZx5();
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_160();
		_bj8iyyk84DtxcxcHgAHHFGgq8oN.smethod_161();
		_RA1aFlOff0jGfI2cKUGhYI1MRLBA._E7yBM68AWt7OGHJ5D6xYA8RK8tAA(new Color(0, 0, 0, 0));
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
