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
			_eJWqL2MhFZHNHP960nsWLJJmyPD._7cuPUL8aamrg9daETH6zQk3RwbF();
		}

		internal void _C9tZY4T9BelwnsewaUqdvfrkWkO(string string_0)
		{
			SDL.SDL_SetClipboardText(string_0);
		}

		internal bool _UCbEdsCpeUZM031TdNSHSb6pKJm(Type type_0)
		{
			return typeof(_7UlnfykmEmZDFt3BmCKZekI43Ih).IsAssignableFrom(type_0);
		}

		internal bool _y5EcTN6S5WHsSubAH8bssazPafr(Type type_0)
		{
			return typeof(_TwlwMC1hhdSzamwGWEBxuUkz1gH).IsAssignableFrom(type_0);
		}

		internal bool _XvTXd5YEa6Vvxl9n2Ol0oGLBLMr(Type type_0)
		{
			if (typeof(_QGGOTxZ8aNWGh0hc26wcmx8wmwT).IsAssignableFrom(type_0))
			{
				return !type_0.IsAbstract;
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
				_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._RA1aFlOff0jGfI2cKUGhYI1MRLBA._FegL010tc92iskjjyD0T33dDwNE();
			});
		}

		internal void _tei9DxeyvzRSN2gVPN7a84fgTHB()
		{
			_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._RA1aFlOff0jGfI2cKUGhYI1MRLBA._FegL010tc92iskjjyD0T33dDwNE();
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
				_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._RA1aFlOff0jGfI2cKUGhYI1MRLBA._FegL010tc92iskjjyD0T33dDwNE();
			});
		}

		internal void _tei9DxeyvzRSN2gVPN7a84fgTHB()
		{
			_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._RA1aFlOff0jGfI2cKUGhYI1MRLBA._FegL010tc92iskjjyD0T33dDwNE();
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
			return type_0.Name == _n6iPJ4jnSQTmNXcr3d8lbsKKvZl;
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
			return type_0.Name == _n6iPJ4jnSQTmNXcr3d8lbsKKvZl;
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
				_hvKKVpHsQ6yw7YBy97lS8UDtil = _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._5yVCuTv9lVSCCxs7cUlv79ysuRh(_JyFtGgNgB3bOcqUlEWpLqpF8I4r._RB8fRXeQvK5vs7JEA0XfVCEpg1i)
			};
			if (CS_0024_003C_003E8__locals0._hvKKVpHsQ6yw7YBy97lS8UDtil == null)
			{
				return;
			}
			_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._OxLRmpxixplTKChiTPUKAx4uTLG(_JyFtGgNgB3bOcqUlEWpLqpF8I4r._XbOXR6AypLIdJ3gBMGseGi3Wi2i, delegate
			{
				if (CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r._tTalXU1p5sOHKNCtH0ZDWD55yfD != null)
				{
					CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._XbOXR6AypLIdJ3gBMGseGi3Wi2i._6hE3geqxrB1vCirtSWHxIJjlTQB(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r._tTalXU1p5sOHKNCtH0ZDWD55yfD);
				}
				if (CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r._KVSwpLj0RvURRswHn7ogRy4BRfd != null)
				{
					CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._gYGB98heFqsLp9tgJbdCP01IKV2(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r._KVSwpLj0RvURRswHn7ogRy4BRfd);
					CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._KVSwpLj0RvURRswHn7ogRy4BRfd._eXH4tq2J0DADXDLofA8G8Yw8fau(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r._zGDIuIFdpGkZI7SJBoEsZdKoN9F, CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r._xEhNfzWWkAGsoMu0XE2Cy84SXcp);
				}
				foreach (_zkUeZhJDizkmvvRfp4S0G7aap8J._CIFXVF6lKl3nSrVOhqjcFXDVlXc item in CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r._SE8JVSojXz0WQ6EAeInGo3JGvSr)
				{
					_QGGOTxZ8aNWGh0hc26wcmx8wmwT qGGOTxZ8aNWGh0hc26wcmx8wmwT = CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._TwQHHdbdRFRy2ctTZabNfz1Htrg(item._RB8fRXeQvK5vs7JEA0XfVCEpg1i, _a2qVgWDIm3fBp49WubttSTPsx8K.Background);
					qGGOTxZ8aNWGh0hc26wcmx8wmwT._7d2DAwjp6FutkJY09U0Mlk43Nmn(item._qZXN2SXhpGdh4T5ZXzgMA9gjYZE, item._kni1uFw1BPElsVA74myj9H1jAKh, item._UjXB7oNK1WnbtEn6d4PkoGLaYEE, item._wUcbLpwYJ1T1bI8GaQwj9Jxx4YX);
					_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve = CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._xfiKuXXh5LQA9CUQiex6tutzFKQ._VvFE2zgy4FbDjvaEvb67tXJ7aRm(item._RB8fRXeQvK5vs7JEA0XfVCEpg1i);
					_3IHp43rpkJgOBcY9lrIrwMuwWve._VNgmwYSLsJyyiR6cPQ35UHJBR4d = item._VNgmwYSLsJyyiR6cPQ35UHJBR4d;
				}
				if (CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r._KR48sJtGCfgf7jYtIsrj2N1iO3n)
				{
					CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Ta8oiGRfjrRGtgUaA5S061UepZb = CS_0024_003C_003E8__locals0._hvKKVpHsQ6yw7YBy97lS8UDtil;
					CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Ta8oiGRfjrRGtgUaA5S061UepZb._4hlxzMzKSbVTbZUrEsP3dfw4x0h(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r._8NBsjeWoi7V64KoA9ZtIybPpcom, CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r._WCJjJQRlVoZM67usdV2f1OR3arG);
				}
				else
				{
					CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Qj2G6fpAF4mGsATgkV8DPBF3aA1A._FegL010tc92iskjjyD0T33dDwNE(delegate
					{
						CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Ta8oiGRfjrRGtgUaA5S061UepZb = CS_0024_003C_003E8__locals0._hvKKVpHsQ6yw7YBy97lS8UDtil;
						CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Ta8oiGRfjrRGtgUaA5S061UepZb._4hlxzMzKSbVTbZUrEsP3dfw4x0h(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r._8NBsjeWoi7V64KoA9ZtIybPpcom, CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r._WCJjJQRlVoZM67usdV2f1OR3arG);
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
			if (_wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r._tTalXU1p5sOHKNCtH0ZDWD55yfD != null)
			{
				_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._XbOXR6AypLIdJ3gBMGseGi3Wi2i._6hE3geqxrB1vCirtSWHxIJjlTQB(_wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r._tTalXU1p5sOHKNCtH0ZDWD55yfD);
			}
			if (_wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r._KVSwpLj0RvURRswHn7ogRy4BRfd != null)
			{
				_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._gYGB98heFqsLp9tgJbdCP01IKV2(_wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r._KVSwpLj0RvURRswHn7ogRy4BRfd);
				_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._KVSwpLj0RvURRswHn7ogRy4BRfd._eXH4tq2J0DADXDLofA8G8Yw8fau(_wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r._zGDIuIFdpGkZI7SJBoEsZdKoN9F, _wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r._xEhNfzWWkAGsoMu0XE2Cy84SXcp);
			}
			foreach (_zkUeZhJDizkmvvRfp4S0G7aap8J._CIFXVF6lKl3nSrVOhqjcFXDVlXc item in _wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r._SE8JVSojXz0WQ6EAeInGo3JGvSr)
			{
				_QGGOTxZ8aNWGh0hc26wcmx8wmwT qGGOTxZ8aNWGh0hc26wcmx8wmwT = _wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._TwQHHdbdRFRy2ctTZabNfz1Htrg(item._RB8fRXeQvK5vs7JEA0XfVCEpg1i, _a2qVgWDIm3fBp49WubttSTPsx8K.Background);
				qGGOTxZ8aNWGh0hc26wcmx8wmwT._7d2DAwjp6FutkJY09U0Mlk43Nmn(item._qZXN2SXhpGdh4T5ZXzgMA9gjYZE, item._kni1uFw1BPElsVA74myj9H1jAKh, item._UjXB7oNK1WnbtEn6d4PkoGLaYEE, item._wUcbLpwYJ1T1bI8GaQwj9Jxx4YX);
				_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve = _wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._xfiKuXXh5LQA9CUQiex6tutzFKQ._VvFE2zgy4FbDjvaEvb67tXJ7aRm(item._RB8fRXeQvK5vs7JEA0XfVCEpg1i);
				_3IHp43rpkJgOBcY9lrIrwMuwWve._VNgmwYSLsJyyiR6cPQ35UHJBR4d = item._VNgmwYSLsJyyiR6cPQ35UHJBR4d;
			}
			if (_wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r._KR48sJtGCfgf7jYtIsrj2N1iO3n)
			{
				_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Ta8oiGRfjrRGtgUaA5S061UepZb = _hvKKVpHsQ6yw7YBy97lS8UDtil;
				_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Ta8oiGRfjrRGtgUaA5S061UepZb._4hlxzMzKSbVTbZUrEsP3dfw4x0h(_wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r._8NBsjeWoi7V64KoA9ZtIybPpcom, _wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r._WCJjJQRlVoZM67usdV2f1OR3arG);
				return;
			}
			_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Qj2G6fpAF4mGsATgkV8DPBF3aA1A._FegL010tc92iskjjyD0T33dDwNE(delegate
			{
				_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Ta8oiGRfjrRGtgUaA5S061UepZb = _hvKKVpHsQ6yw7YBy97lS8UDtil;
				_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Ta8oiGRfjrRGtgUaA5S061UepZb._4hlxzMzKSbVTbZUrEsP3dfw4x0h(_wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r._8NBsjeWoi7V64KoA9ZtIybPpcom, _wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r._WCJjJQRlVoZM67usdV2f1OR3arG);
			});
		}

		internal void _oLpcDBCBvPERkbvp6clOOzqaKXi()
		{
			_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Ta8oiGRfjrRGtgUaA5S061UepZb = _hvKKVpHsQ6yw7YBy97lS8UDtil;
			_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Ta8oiGRfjrRGtgUaA5S061UepZb._4hlxzMzKSbVTbZUrEsP3dfw4x0h(_wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r._8NBsjeWoi7V64KoA9ZtIybPpcom, _wr6xcvFOgUbaTATC17S6Y9v3y3S._JyFtGgNgB3bOcqUlEWpLqpF8I4r._WCJjJQRlVoZM67usdV2f1OR3arG);
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
			return type_0.Name == _hzqOBkJhJBhsTRNARxHLctcvhN0;
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
		typeof(BedroomScene).Name,
		typeof(LivingRoomScene).Name,
		typeof(ClubBackScene).Name,
		typeof(ClubEntranceScene).Name,
		typeof(ClubInsideScene).Name,
		typeof(ClubLoungeScene).Name,
		typeof(ClubPoolScene).Name,
		typeof(ClubUpstairsScene).Name
	};

	private Keys[] _gylJZYyc3mVB0fbHPCctDIg4UAE;

	private string[] _sUwMzXXmi9PdDQ0bFQhbGQJUPTe;

	private Vector2 _Vh2qdN4Ha62herl19def6PyuanQ;

	public GameWindow _8k7Do3TGW5NrB22zl8QzInP2j7k => _4L7hfXrWoDdArQiscG4ukHCV46B.get_Window();

	public GraphicsDevice _2yepMkVENnecIsduggABaU2qhXW => _4L7hfXrWoDdArQiscG4ukHCV46B.get_GraphicsDevice();

	public ContentManager _uwNDZuqdFb9tyQtlQMxiz1DQ7x8 => _4L7hfXrWoDdArQiscG4ukHCV46B.get_Content();

	public _3FFZvGWTAe7rsviKkDPTXEVjxWf _RbWJ7YGnYHCSoD44MRW1h5X6E7E => _YNCmHGUHBydamu5BEECMWoB65VfA;

	public _wRd4nHuQQlAPEwrHOGkBfut6Uip _vsceSzSIjBy2nZrCxAzKZbUiwLq => _chds2l0ZCMMghly7dv4eik3iSH5;

	public _7UlnfykmEmZDFt3BmCKZekI43Ih _XbOXR6AypLIdJ3gBMGseGi3Wi2i => _xfiKuXXh5LQA9CUQiex6tutzFKQ;

	public _TwlwMC1hhdSzamwGWEBxuUkz1gH _KVSwpLj0RvURRswHn7ogRy4BRfd => _ieTMbMiu3eGRdmzTMofKoJopZAf;

	public _nR8eroJOHehP0ZGyyTveo6aMTHg _5zNdOw7qHmuCAPJFMr3SsZdBlCr => _Ta8oiGRfjrRGtgUaA5S061UepZb;

	public _gJR4g7ak0hsZAUWX1vJbMqG2P5I _Qj2G6fpAF4mGsATgkV8DPBF3aA1A => _RA1aFlOff0jGfI2cKUGhYI1MRLBA;

	public _8lVOgkauaSHbAkAqHzI1K7mIyOI _o2QVQfIAsuLcmPxn14llGoZA52y => _fp8jsuSnELXqf2yy2JQDaXDCBVQ;

	public _691ooXdgg17CWFkMkjedKBBBfYw _aJh9CibG5YKhkExxgRyVopdfSeJ => _db5uuwyBnUwxthW14pfDBlBoqUp;

	public bool _kSReo0whY1pgfTnFOSc44ppANOe => _ARAAkijJ1FF23wI2rNDaw7mTOeJ.get_IsFullScreen();

	public bool _NdzU0m9x8QDKpVv3DrQmzY5KduB { get; set; }

	public bool _LWcoDwIWvf8DT3nQmNe5z8fkUvI { get; set; }

	public bool _ezjxb7tsh6Db1xblB74OYX4vVK => _DNbNFzOKO7vtoVmjI32p1Snwmpe;

	public _bj8iyyk84DtxcxcHgAHHFGgq8oN(Game game_0, bool bool_0)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		_4L7hfXrWoDdArQiscG4ukHCV46B = game_0;
		_eJWqL2MhFZHNHP960nsWLJJmyPD._sabDA8yXNR8DIRSbHjOcXx1e1Ax();
		if (bool_0)
		{
			GraphicsDeviceManager val = new GraphicsDeviceManager(game_0);
			val.set_IsFullScreen(false);
			val.set_PreferredBackBufferWidth(1024);
			val.set_PreferredBackBufferHeight(768);
			val.set_SynchronizeWithVerticalRetrace(true);
			_ARAAkijJ1FF23wI2rNDaw7mTOeJ = val;
		}
		else if (!_eJWqL2MhFZHNHP960nsWLJJmyPD._5shlzNYVaJPuzrQfwyRBEphDX6p())
		{
			DisplayMode currentDisplayMode = GraphicsAdapter.get_DefaultAdapter().get_CurrentDisplayMode();
			GraphicsDeviceManager val2 = new GraphicsDeviceManager(game_0);
			val2.set_IsFullScreen(true);
			val2.set_PreferredBackBufferWidth(currentDisplayMode.get_Width());
			val2.set_PreferredBackBufferHeight(currentDisplayMode.get_Height());
			val2.set_SynchronizeWithVerticalRetrace(true);
			_ARAAkijJ1FF23wI2rNDaw7mTOeJ = val2;
		}
		else
		{
			GraphicsDeviceManager val3 = new GraphicsDeviceManager(game_0);
			val3.set_IsFullScreen(_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._Bbx3oCtJkeUN6asRLqH0DJ3kkFg);
			val3.set_PreferredBackBufferWidth(_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._Iv7AHXGOFR9WoLBFx6PjEgEHmYI);
			val3.set_PreferredBackBufferHeight(_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._84wHcdDxJz5ElyDPXXlgRgsiW8g);
			val3.set_SynchronizeWithVerticalRetrace(true);
			_ARAAkijJ1FF23wI2rNDaw7mTOeJ = val3;
		}
		_uwNDZuqdFb9tyQtlQMxiz1DQ7x8.set_RootDirectory("Content-Release");
		_4L7hfXrWoDdArQiscG4ukHCV46B.set_Content((ContentManager)(object)new _xM5N1Fg3VZCSTaBWtPXoS6nJ82E(_uwNDZuqdFb9tyQtlQMxiz1DQ7x8.get_ServiceProvider(), _uwNDZuqdFb9tyQtlQMxiz1DQ7x8.get_RootDirectory()));
	}

	public void _oD87G7SXjsTukw7IVWxVlVFEgvA()
	{
		_4L7hfXrWoDdArQiscG4ukHCV46B.add_Disposed((EventHandler<EventArgs>)delegate
		{
			_eJWqL2MhFZHNHP960nsWLJJmyPD._7cuPUL8aamrg9daETH6zQk3RwbF();
		});
		Gui.set_GetClipboardCallback((Func<string>)Delegate.Combine(Gui.get_GetClipboardCallback(), new Func<string>(SDL.SDL_GetClipboardText)));
		Gui.set_SetClipboardCallback((Action<string>)Delegate.Combine(Gui.get_SetClipboardCallback(), (Action<string>)delegate(string string_0)
		{
			SDL.SDL_SetClipboardText(string_0);
		}));
		string text = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "NonSteam");
		if (!File.Exists(text) && !File.Exists(text + ".txt"))
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
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		string text = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ShowMeSomeBooty");
		_iExD93IWLlzVfXsU9wyrEvWgJsg._qrFhbSiCFS6nLCN231ubbRQQeXE(File.Exists(text) || File.Exists(text + ".txt"));
		_YNCmHGUHBydamu5BEECMWoB65VfA = new _3FFZvGWTAe7rsviKkDPTXEVjxWf(this);
		_gylJZYyc3mVB0fbHPCctDIg4UAE = (Keys[])Enum.GetValues(typeof(Keys));
		_RbWJ7YGnYHCSoD44MRW1h5X6E7E._tZI6Co0uB31aGK7Qk4qvEImgcnO = true;
		_ZXUztyGtStF4WzGVig7wu43cfnf = new SpriteBatch(_4L7hfXrWoDdArQiscG4ukHCV46B.get_GraphicsDevice());
		_BuJyoOT5ylWcIMxjcKRnxVmYvBd = new SkeletonMeshRenderer(_4L7hfXrWoDdArQiscG4ukHCV46B.get_GraphicsDevice());
		_chds2l0ZCMMghly7dv4eik3iSH5 = new _wRd4nHuQQlAPEwrHOGkBfut6Uip(this, 1920, 1080);
		_chds2l0ZCMMghly7dv4eik3iSH5._2lMgp1KOzK9I6kd7CHrDq2A2CHm(_ARAAkijJ1FF23wI2rNDaw7mTOeJ.get_PreferredBackBufferWidth(), _ARAAkijJ1FF23wI2rNDaw7mTOeJ.get_PreferredBackBufferHeight(), _ARAAkijJ1FF23wI2rNDaw7mTOeJ.get_PreferredBackBufferWidth(), _ARAAkijJ1FF23wI2rNDaw7mTOeJ.get_PreferredBackBufferHeight());
		_j2ynkEUaNLywHdchuAYJWHF3l9DA = new RenderTarget2D(_4L7hfXrWoDdArQiscG4ukHCV46B.get_GraphicsDevice(), 1920, 1080);
		_j2ynkEUaNLywHdchuAYJWHF3l9DA._w2YD42TXOY22EP4Mpp7wzDUO4xv((RenderTargetUsage)1);
		_CCbe95wREA1VhjgpntSpzsQ19He = new Rectangle(_chds2l0ZCMMghly7dv4eik3iSH5._jDxCg7GJnIKcLXDcUVSdbEIQL3Yb, _chds2l0ZCMMghly7dv4eik3iSH5._ILCBrSipj1Qk4CsYzkEELxHvkkY, _chds2l0ZCMMghly7dv4eik3iSH5._HZrLDiX4EPtS6jM8Odd9yJAatHq, _chds2l0ZCMMghly7dv4eik3iSH5._ypqaDJqrkQlUKOrdZIXld5qQQ4x);
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
			_Qj2G6fpAF4mGsATgkV8DPBF3aA1A._FegL010tc92iskjjyD0T33dDwNE();
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
		_YNCmHGUHBydamu5BEECMWoB65VfA._tiBFUHPEkedkbgvuX3whdeyjhKo();
		if (_RbWJ7YGnYHCSoD44MRW1h5X6E7E._WZ4xYI5Q3hoCNX9QFzE3jfDwZBJ((Keys)164) && _RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH((Keys)112))
		{
			_DNbNFzOKO7vtoVmjI32p1Snwmpe = !_DNbNFzOKO7vtoVmjI32p1Snwmpe;
		}
		if ((_RbWJ7YGnYHCSoD44MRW1h5X6E7E._WZ4xYI5Q3hoCNX9QFzE3jfDwZBJ((Keys)164) && _RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH((Keys)13)) || _RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH((Keys)113))
		{
			_qGU55VUfbqFJ4l6ArNW4JRcLekg();
		}
		if (_p3BLtW5bCDzTS86VFihe1pfwDoP == null && (_RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH((Keys)123) || _RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH((Keys)44)))
		{
			_VN2LxjGLZldLNfiJ1OniiaXfYBg();
		}
		if (_RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH((Keys)9))
		{
			_Fs6y8qquj1mRHLz6xw6KoI4SAvH = !_Fs6y8qquj1mRHLz6xw6KoI4SAvH;
		}
		_chds2l0ZCMMghly7dv4eik3iSH5._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
		_RA1aFlOff0jGfI2cKUGhYI1MRLBA._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
		_6M30VBCyHzfi1RYZYx7uJAHl1EC._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
		_6M30VBCyHzfi1RYZYx7uJAHl1EC._LcX2y4hMIzQST4uGT2Q5Ce7vaGg();
		if (_Z8BClcChRJrlB6tR1VPJcycVpHN != null)
		{
			if (_xfiKuXXh5LQA9CUQiex6tutzFKQ != null)
			{
				_xfiKuXXh5LQA9CUQiex6tutzFKQ._tO46aYSBLFIuhFNlhbrAeWbFDSf();
			}
			_xfiKuXXh5LQA9CUQiex6tutzFKQ = _Z8BClcChRJrlB6tR1VPJcycVpHN;
			_Z8BClcChRJrlB6tR1VPJcycVpHN = null;
			_xfiKuXXh5LQA9CUQiex6tutzFKQ._4hlxzMzKSbVTbZUrEsP3dfw4x0h();
		}
		_xfiKuXXh5LQA9CUQiex6tutzFKQ._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
		_CCtbrNWS4Gi5hRSEsXYI5VzS7gI._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
		_SUHe9KzfAd477MCCYxTvqFf3efl._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0, _chds2l0ZCMMghly7dv4eik3iSH5);
		_P62DygY6CKZG8s5wqDu0uAFksjs._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
		if (_Ta8oiGRfjrRGtgUaA5S061UepZb != null)
		{
			_Ta8oiGRfjrRGtgUaA5S061UepZb._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
			if (!_Ta8oiGRfjrRGtgUaA5S061UepZb._5PWaXifOOaIVN34JQsXRmvxXtqK)
			{
				_sUwMzXXmi9PdDQ0bFQhbGQJUPTe = _Ta8oiGRfjrRGtgUaA5S061UepZb._YYH5zlVZSFq4tPfc1vfadAxnqhV(5);
				_Ta8oiGRfjrRGtgUaA5S061UepZb = null;
			}
		}
		if (_ieTMbMiu3eGRdmzTMofKoJopZAf != null)
		{
			_ieTMbMiu3eGRdmzTMofKoJopZAf._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
		}
		if (_fp8jsuSnELXqf2yy2JQDaXDCBVQ != null)
		{
			_fp8jsuSnELXqf2yy2JQDaXDCBVQ._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
		}
		_9rxbJ7LsE3DhACUHVlPZaixc5Jp._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
		Point val = _chds2l0ZCMMghly7dv4eik3iSH5._u7uCdK9i8FnWhiaPn2bO2wIgUUuA(_RbWJ7YGnYHCSoD44MRW1h5X6E7E._U7CeYBJ1v1SoUxpX8emsQ9mWl5b);
		List<KeyData> list = new List<KeyData>();
		Keys[] gylJZYyc3mVB0fbHPCctDIg4UAE = _gylJZYyc3mVB0fbHPCctDIg4UAE;
		foreach (Keys val2 in gylJZYyc3mVB0fbHPCctDIg4UAE)
		{
			bool flag = _RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(val2);
			bool flag2 = _RbWJ7YGnYHCSoD44MRW1h5X6E7E._KGCwEHf8akeXdkHLKFg1caFxXUJ(val2);
			if (flag || flag2)
			{
				Keys? val3 = _o0Y4SOgMHY7iQXRQkPwaQ9pMBBl._HSj1lr89AFIB9adVhSrAeWjS1xC[Keyboard.GetKeyFromScancodeEXT(val2)];
				if (val3.HasValue)
				{
					list.Add(new KeyData
					{
						Scancode = (int)val3.Value,
						Char = val2._O2N6YVYHWf1FQNPMGlnVDG8GTqe(_RbWJ7YGnYHCSoD44MRW1h5X6E7E._WZ4xYI5Q3hoCNX9QFzE3jfDwZBJ((Keys)160) || _RbWJ7YGnYHCSoD44MRW1h5X6E7E._WZ4xYI5Q3hoCNX9QFzE3jfDwZBJ((Keys)161)),
						Pressed = flag,
						Released = flag2
					});
				}
			}
		}
		Gui.SetKeyboard(list.ToArray());
		Gui.SetButtons(new bool[2]
		{
			_RbWJ7YGnYHCSoD44MRW1h5X6E7E._WZ4xYI5Q3hoCNX9QFzE3jfDwZBJ(_PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton),
			_RbWJ7YGnYHCSoD44MRW1h5X6E7E._WZ4xYI5Q3hoCNX9QFzE3jfDwZBJ(_PMeRYZJaBCqgB9uADJFP3c14lxq.RightButton)
		});
		Gui.SetMouse(val.X, val.Y, _RbWJ7YGnYHCSoD44MRW1h5X6E7E._xFrCcVNAYrShLz07HqDph01nGwX);
		Gui.set_TimeElapsed((float)gameTime_0.get_ElapsedGameTime().Milliseconds);
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
		_boyt8NIMtKsAGSTcjHeL0WMbFxs._AmIUCcrmrrQiiirja7DoiZSjXuv = (float)gameTime_0.get_TotalGameTime().TotalSeconds;
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
		_fSRUnXzLhUs3DfJ1lzl9dGCEmCf(_chds2l0ZCMMghly7dv4eik3iSH5._KOuUew34v1oSMnWlHSFJuRBiu1c, _chds2l0ZCMMghly7dv4eik3iSH5._dh9yjUXG1mhcfgwAWkWfggbGEIc, !_ARAAkijJ1FF23wI2rNDaw7mTOeJ.get_IsFullScreen());
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
		_fSRUnXzLhUs3DfJ1lzl9dGCEmCf(int_0, int_1, _ARAAkijJ1FF23wI2rNDaw7mTOeJ.get_IsFullScreen());
	}

	public void _fSRUnXzLhUs3DfJ1lzl9dGCEmCf(int int_0, int int_1, bool bool_0)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		_ARAAkijJ1FF23wI2rNDaw7mTOeJ.set_IsFullScreen(bool_0);
		_ARAAkijJ1FF23wI2rNDaw7mTOeJ.set_PreferredBackBufferWidth(bool_0 ? GraphicsAdapter.get_DefaultAdapter().get_CurrentDisplayMode().get_Width() : int_0);
		_ARAAkijJ1FF23wI2rNDaw7mTOeJ.set_PreferredBackBufferHeight(bool_0 ? GraphicsAdapter.get_DefaultAdapter().get_CurrentDisplayMode().get_Height() : int_1);
		_ARAAkijJ1FF23wI2rNDaw7mTOeJ.get_GraphicsDevice().set_Viewport(new Viewport(0, 0, _ARAAkijJ1FF23wI2rNDaw7mTOeJ.get_PreferredBackBufferWidth(), _ARAAkijJ1FF23wI2rNDaw7mTOeJ.get_PreferredBackBufferHeight()));
		_chds2l0ZCMMghly7dv4eik3iSH5._2lMgp1KOzK9I6kd7CHrDq2A2CHm(int_0, int_1, _ARAAkijJ1FF23wI2rNDaw7mTOeJ.get_PreferredBackBufferWidth(), _ARAAkijJ1FF23wI2rNDaw7mTOeJ.get_PreferredBackBufferHeight());
		_CCbe95wREA1VhjgpntSpzsQ19He = new Rectangle(_chds2l0ZCMMghly7dv4eik3iSH5._jDxCg7GJnIKcLXDcUVSdbEIQL3Yb, _chds2l0ZCMMghly7dv4eik3iSH5._ILCBrSipj1Qk4CsYzkEELxHvkkY, _chds2l0ZCMMghly7dv4eik3iSH5._HZrLDiX4EPtS6jM8Odd9yJAatHq, _chds2l0ZCMMghly7dv4eik3iSH5._ypqaDJqrkQlUKOrdZIXld5qQQ4x);
		_ARAAkijJ1FF23wI2rNDaw7mTOeJ.ApplyChanges();
	}

	public void _udfEpcIRn7lWl5Lvjdyu0aG0A7G()
	{
		_4L7hfXrWoDdArQiscG4ukHCV46B.Exit();
	}

	public void _k9wUPeU1Ga7cygiuGP8TT6aPLWF<T>() where T : _7UlnfykmEmZDFt3BmCKZekI43Ih
	{
		_RA1aFlOff0jGfI2cKUGhYI1MRLBA._PYAXEqRAOkDRRNqm1k71R7GJTJK(delegate
		{
			_OxLRmpxixplTKChiTPUKAx4uTLG<T>(delegate
			{
				_RA1aFlOff0jGfI2cKUGhYI1MRLBA._FegL010tc92iskjjyD0T33dDwNE();
			});
		});
	}

	public void _k9wUPeU1Ga7cygiuGP8TT6aPLWF(string string_0)
	{
		_RA1aFlOff0jGfI2cKUGhYI1MRLBA._PYAXEqRAOkDRRNqm1k71R7GJTJK(delegate
		{
			_OxLRmpxixplTKChiTPUKAx4uTLG(string_0, delegate
			{
				_RA1aFlOff0jGfI2cKUGhYI1MRLBA._FegL010tc92iskjjyD0T33dDwNE();
			});
		});
	}

	public void _k9wUPeU1Ga7cygiuGP8TT6aPLWF(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		_RA1aFlOff0jGfI2cKUGhYI1MRLBA._PYAXEqRAOkDRRNqm1k71R7GJTJK(delegate
		{
			_OxLRmpxixplTKChiTPUKAx4uTLG(_7UlnfykmEmZDFt3BmCKZekI43Ih_0, delegate
			{
				_RA1aFlOff0jGfI2cKUGhYI1MRLBA._FegL010tc92iskjjyD0T33dDwNE();
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
		_chds2l0ZCMMghly7dv4eik3iSH5._n4NdRK3l14j7hHgGSJS4dI9LeYR();
		_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._Wrz1IORok7yBtsQA3czQUmnP6Yl(null);
		_fp8jsuSnELXqf2yy2JQDaXDCBVQ = null;
		_ieTMbMiu3eGRdmzTMofKoJopZAf = null;
		_Z8BClcChRJrlB6tR1VPJcycVpHN = Activator.CreateInstance(typeof(T), this) as _7UlnfykmEmZDFt3BmCKZekI43Ih;
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
		IEnumerable<Type> source = from type_0 in Assembly.GetAssembly(typeof(_bj8iyyk84DtxcxcHgAHHFGgq8oN))!.GetTypes()
			where typeof(_7UlnfykmEmZDFt3BmCKZekI43Ih).IsAssignableFrom(type_0)
			select type_0;
		Type type = source.FirstOrDefault((Type type_0) => type_0.Name == string_0);
		if (!(type == null))
		{
			_chds2l0ZCMMghly7dv4eik3iSH5._n4NdRK3l14j7hHgGSJS4dI9LeYR();
			_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._Wrz1IORok7yBtsQA3czQUmnP6Yl(null);
			_fp8jsuSnELXqf2yy2JQDaXDCBVQ = null;
			_ieTMbMiu3eGRdmzTMofKoJopZAf = null;
			_Z8BClcChRJrlB6tR1VPJcycVpHN = Activator.CreateInstance(type, this) as _7UlnfykmEmZDFt3BmCKZekI43Ih;
			_NdzU0m9x8QDKpVv3DrQmzY5KduB = true;
		}
		else
		{
			_ETHljYp3aQy9GQ1ZAzhfOYDI1sO._0rEYVY1cDKfLPVuLw54UlaIts2m("Failed to load scene '{0}'", string_0);
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
		_chds2l0ZCMMghly7dv4eik3iSH5._n4NdRK3l14j7hHgGSJS4dI9LeYR();
		_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._Wrz1IORok7yBtsQA3czQUmnP6Yl(null);
		_fp8jsuSnELXqf2yy2JQDaXDCBVQ = null;
		_ieTMbMiu3eGRdmzTMofKoJopZAf = null;
		_Z8BClcChRJrlB6tR1VPJcycVpHN = _7UlnfykmEmZDFt3BmCKZekI43Ih_0;
		_NdzU0m9x8QDKpVv3DrQmzY5KduB = true;
	}

	public void _gYGB98heFqsLp9tgJbdCP01IKV2(string string_0)
	{
		IEnumerable<Type> source = from type_0 in Assembly.GetAssembly(typeof(_bj8iyyk84DtxcxcHgAHHFGgq8oN))!.GetTypes()
			where typeof(_TwlwMC1hhdSzamwGWEBxuUkz1gH).IsAssignableFrom(type_0)
			select type_0;
		Type type = source.FirstOrDefault((Type type_0) => type_0.Name == string_0);
		if (!(type == null))
		{
			_ieTMbMiu3eGRdmzTMofKoJopZAf = Activator.CreateInstance(type, _4L7hfXrWoDdArQiscG4ukHCV46B.get_Content()) as _TwlwMC1hhdSzamwGWEBxuUkz1gH;
		}
		else
		{
			_ETHljYp3aQy9GQ1ZAzhfOYDI1sO._0rEYVY1cDKfLPVuLw54UlaIts2m("Failed to load sexscene '{0}'", string_0);
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
			int int_ = _CCtbrNWS4Gi5hRSEsXYI5VzS7gI._Hnb6mPvrZFgOMCIApIeMW88jSsF._fvTKDuNATrUxfXZVvltePz3vYkK(_nR8eroJOHehP0ZGyyTveo6aMTHg_0._Hnb6mPvrZFgOMCIApIeMW88jSsF._RB8fRXeQvK5vs7JEA0XfVCEpg1i);
			_poenyHBGUusBcnNcTFB9MQBV72R._RiDuYMeg3EHnBUteUcAb8VlfQVl();
			_Ta8oiGRfjrRGtgUaA5S061UepZb._4hlxzMzKSbVTbZUrEsP3dfw4x0h(int_);
		}
	}

	private _nR8eroJOHehP0ZGyyTveo6aMTHg _5yVCuTv9lVSCCxs7cUlv79ysuRh(string string_0)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		string text = Path.Combine(_uwNDZuqdFb9tyQtlQMxiz1DQ7x8.get_RootDirectory(), $"Content-Mods/Data/Quests/{string_0}.json");
		string text2 = Path.Combine(_uwNDZuqdFb9tyQtlQMxiz1DQ7x8.get_RootDirectory(), $"Data/Quests/{string_0}.json");
		string text3;
		if (File.Exists(text))
		{
			_ETHljYp3aQy9GQ1ZAzhfOYDI1sO._IGmWy5uYuv50rXGtBNbMPGzJhWh("Loaded modded cutscene '{0}'", string_0);
			text3 = _K2047A8SCJdaw0LZKStEHOiH110._mDCA4AzhICQie5tejcL2uH7mcwf(text);
		}
		else
		{
			if (!File.Exists(text2))
			{
				_ETHljYp3aQy9GQ1ZAzhfOYDI1sO._0rEYVY1cDKfLPVuLw54UlaIts2m("Failed to load cutscene '{0}'", string_0);
				return null;
			}
			text3 = _K2047A8SCJdaw0LZKStEHOiH110._GxOfTBefEUfWKWaWgxVRKsjugxE(text2);
		}
		JsonSerializerSettings val = new JsonSerializerSettings();
		val.set_TypeNameHandling((TypeNameHandling)4);
		val.get_Converters().Add((JsonConverter)(object)new _VSQz6uDf5A6KqE8xqKxxcrkhZkA());
		JsonSerializerSettings val2 = val;
		_0SvCRe0EgzR9DhI3QPe1GUqubAt _0SvCRe0EgzR9DhI3QPe1GUqubAt = JsonConvert.DeserializeObject<_0SvCRe0EgzR9DhI3QPe1GUqubAt>(text3, val2);
		if (_0SvCRe0EgzR9DhI3QPe1GUqubAt != null)
		{
			return new _nR8eroJOHehP0ZGyyTveo6aMTHg(this, _0SvCRe0EgzR9DhI3QPe1GUqubAt, Assembly.Load("Amorous.Game"));
		}
		return null;
	}

	private _zkUeZhJDizkmvvRfp4S0G7aap8J _PSROht9Hy1Ik63UUdnKDUGBA0yQ()
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (_5zNdOw7qHmuCAPJFMr3SsZdBlCr != null)
		{
			_zkUeZhJDizkmvvRfp4S0G7aap8J obj = new _zkUeZhJDizkmvvRfp4S0G7aap8J
			{
				_RB8fRXeQvK5vs7JEA0XfVCEpg1i = _5zNdOw7qHmuCAPJFMr3SsZdBlCr._Hnb6mPvrZFgOMCIApIeMW88jSsF._RB8fRXeQvK5vs7JEA0XfVCEpg1i,
				_8NBsjeWoi7V64KoA9ZtIybPpcom = _5zNdOw7qHmuCAPJFMr3SsZdBlCr._VQZivNSvg2tVi52cTTAQKYhamQK._Hnb6mPvrZFgOMCIApIeMW88jSsF._8NBsjeWoi7V64KoA9ZtIybPpcom,
				_WCJjJQRlVoZM67usdV2f1OR3arG = _5zNdOw7qHmuCAPJFMr3SsZdBlCr._VQZivNSvg2tVi52cTTAQKYhamQK._SWODlbUkQEqfwrtprjLPOeGF7HO._WCJjJQRlVoZM67usdV2f1OR3arG,
				_XbOXR6AypLIdJ3gBMGseGi3Wi2i = _XbOXR6AypLIdJ3gBMGseGi3Wi2i.GetType().Name,
				_tTalXU1p5sOHKNCtH0ZDWD55yfD = _XbOXR6AypLIdJ3gBMGseGi3Wi2i._hFeWJ5482CKD4l4529bYY1catC,
				_KVSwpLj0RvURRswHn7ogRy4BRfd = _KVSwpLj0RvURRswHn7ogRy4BRfd?.GetType().Name,
				_zGDIuIFdpGkZI7SJBoEsZdKoN9F = (_KVSwpLj0RvURRswHn7ogRy4BRfd?._rNGHguvWdrugQVL2AI6bMMKSORN ?? _TwlwMC1hhdSzamwGWEBxuUkz1gH._qokIrmaaT3Lq6znW10HdrPUO9Fq.Idle),
				_xEhNfzWWkAGsoMu0XE2Cy84SXcp = (_KVSwpLj0RvURRswHn7ogRy4BRfd?._p3lU5oxIaFTVHUNFxJRnaHkXdsA ?? false)
			};
			Color sWODlbUkQEqfwrtprjLPOeGF7HO = _Qj2G6fpAF4mGsATgkV8DPBF3aA1A._SWODlbUkQEqfwrtprjLPOeGF7HO;
			obj._KR48sJtGCfgf7jYtIsrj2N1iO3n = ((Color)(ref sWODlbUkQEqfwrtprjLPOeGF7HO)).get_A() > 0;
			_zkUeZhJDizkmvvRfp4S0G7aap8J zkUeZhJDizkmvvRfp4S0G7aap8J = obj;
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
			_nR8eroJOHehP0ZGyyTveo6aMTHg _hvKKVpHsQ6yw7YBy97lS8UDtil = _5yVCuTv9lVSCCxs7cUlv79ysuRh(_zkUeZhJDizkmvvRfp4S0G7aap8J_0._RB8fRXeQvK5vs7JEA0XfVCEpg1i);
			if (_hvKKVpHsQ6yw7YBy97lS8UDtil != null)
			{
				_OxLRmpxixplTKChiTPUKAx4uTLG(_zkUeZhJDizkmvvRfp4S0G7aap8J_0._XbOXR6AypLIdJ3gBMGseGi3Wi2i, delegate
				{
					if (_zkUeZhJDizkmvvRfp4S0G7aap8J_0._tTalXU1p5sOHKNCtH0ZDWD55yfD != null)
					{
						_XbOXR6AypLIdJ3gBMGseGi3Wi2i._6hE3geqxrB1vCirtSWHxIJjlTQB(_zkUeZhJDizkmvvRfp4S0G7aap8J_0._tTalXU1p5sOHKNCtH0ZDWD55yfD);
					}
					if (_zkUeZhJDizkmvvRfp4S0G7aap8J_0._KVSwpLj0RvURRswHn7ogRy4BRfd != null)
					{
						_gYGB98heFqsLp9tgJbdCP01IKV2(_zkUeZhJDizkmvvRfp4S0G7aap8J_0._KVSwpLj0RvURRswHn7ogRy4BRfd);
						_KVSwpLj0RvURRswHn7ogRy4BRfd._eXH4tq2J0DADXDLofA8G8Yw8fau(_zkUeZhJDizkmvvRfp4S0G7aap8J_0._zGDIuIFdpGkZI7SJBoEsZdKoN9F, _zkUeZhJDizkmvvRfp4S0G7aap8J_0._xEhNfzWWkAGsoMu0XE2Cy84SXcp);
					}
					foreach (_zkUeZhJDizkmvvRfp4S0G7aap8J._CIFXVF6lKl3nSrVOhqjcFXDVlXc item in _zkUeZhJDizkmvvRfp4S0G7aap8J_0._SE8JVSojXz0WQ6EAeInGo3JGvSr)
					{
						_QGGOTxZ8aNWGh0hc26wcmx8wmwT qGGOTxZ8aNWGh0hc26wcmx8wmwT = _TwQHHdbdRFRy2ctTZabNfz1Htrg(item._RB8fRXeQvK5vs7JEA0XfVCEpg1i, _a2qVgWDIm3fBp49WubttSTPsx8K.Background);
						qGGOTxZ8aNWGh0hc26wcmx8wmwT._7d2DAwjp6FutkJY09U0Mlk43Nmn(item._qZXN2SXhpGdh4T5ZXzgMA9gjYZE, item._kni1uFw1BPElsVA74myj9H1jAKh, item._UjXB7oNK1WnbtEn6d4PkoGLaYEE, item._wUcbLpwYJ1T1bI8GaQwj9Jxx4YX);
						_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve = _xfiKuXXh5LQA9CUQiex6tutzFKQ._VvFE2zgy4FbDjvaEvb67tXJ7aRm(item._RB8fRXeQvK5vs7JEA0XfVCEpg1i);
						_3IHp43rpkJgOBcY9lrIrwMuwWve._VNgmwYSLsJyyiR6cPQ35UHJBR4d = item._VNgmwYSLsJyyiR6cPQ35UHJBR4d;
					}
					if (_zkUeZhJDizkmvvRfp4S0G7aap8J_0._KR48sJtGCfgf7jYtIsrj2N1iO3n)
					{
						_Ta8oiGRfjrRGtgUaA5S061UepZb = _hvKKVpHsQ6yw7YBy97lS8UDtil;
						_Ta8oiGRfjrRGtgUaA5S061UepZb._4hlxzMzKSbVTbZUrEsP3dfw4x0h(_zkUeZhJDizkmvvRfp4S0G7aap8J_0._8NBsjeWoi7V64KoA9ZtIybPpcom, _zkUeZhJDizkmvvRfp4S0G7aap8J_0._WCJjJQRlVoZM67usdV2f1OR3arG);
					}
					else
					{
						_Qj2G6fpAF4mGsATgkV8DPBF3aA1A._FegL010tc92iskjjyD0T33dDwNE(delegate
						{
							_Ta8oiGRfjrRGtgUaA5S061UepZb = _hvKKVpHsQ6yw7YBy97lS8UDtil;
							_Ta8oiGRfjrRGtgUaA5S061UepZb._4hlxzMzKSbVTbZUrEsP3dfw4x0h(_zkUeZhJDizkmvvRfp4S0G7aap8J_0._8NBsjeWoi7V64KoA9ZtIybPpcom, _zkUeZhJDizkmvvRfp4S0G7aap8J_0._WCJjJQRlVoZM67usdV2f1OR3arG);
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
		return _xfiKuXXh5LQA9CUQiex6tutzFKQ._VvFE2zgy4FbDjvaEvb67tXJ7aRm(string_0)?._4QLHHCk23T1BjK7acKxASbkCefG;
	}

	public _QGGOTxZ8aNWGh0hc26wcmx8wmwT _VvFE2zgy4FbDjvaEvb67tXJ7aRm(NPCLocation npclocation_0)
	{
		if (_xfiKuXXh5LQA9CUQiex6tutzFKQ == null)
		{
			return null;
		}
		return _xfiKuXXh5LQA9CUQiex6tutzFKQ._VvFE2zgy4FbDjvaEvb67tXJ7aRm(npclocation_0)?._4QLHHCk23T1BjK7acKxASbkCefG;
	}

	public _QGGOTxZ8aNWGh0hc26wcmx8wmwT _TwQHHdbdRFRy2ctTZabNfz1Htrg(string string_0, _a2qVgWDIm3fBp49WubttSTPsx8K _a2qVgWDIm3fBp49WubttSTPsx8K_0)
	{
		if (_xfiKuXXh5LQA9CUQiex6tutzFKQ != null)
		{
			_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve = _xfiKuXXh5LQA9CUQiex6tutzFKQ._VvFE2zgy4FbDjvaEvb67tXJ7aRm(string_0);
			if (_3IHp43rpkJgOBcY9lrIrwMuwWve == null)
			{
				IEnumerable<Type> source = from type_0 in Assembly.GetAssembly(typeof(_bj8iyyk84DtxcxcHgAHHFGgq8oN))!.GetTypes()
					where typeof(_QGGOTxZ8aNWGh0hc26wcmx8wmwT).IsAssignableFrom(type_0) && !type_0.IsAbstract
					select type_0;
				Type type = source.FirstOrDefault((Type type_0) => type_0.Name == string_0);
				if (!(type == null))
				{
					if (Activator.CreateInstance(type, this) is _QGGOTxZ8aNWGh0hc26wcmx8wmwT qGGOTxZ8aNWGh0hc26wcmx8wmwT)
					{
						qGGOTxZ8aNWGh0hc26wcmx8wmwT._ZzBuoSDMWwerejOO9Goyv2OCKgE = this;
						qGGOTxZ8aNWGh0hc26wcmx8wmwT._g9Sx54kMPiHz5jrqWh4Kb1pTijH();
						_xfiKuXXh5LQA9CUQiex6tutzFKQ._gWHVDvr9GDtRXP2zf2Md18MgZ4b(qGGOTxZ8aNWGh0hc26wcmx8wmwT, (_a2qVgWDIm3fBp49WubttSTPsx8K_0 == _a2qVgWDIm3fBp49WubttSTPsx8K.None) ? _a2qVgWDIm3fBp49WubttSTPsx8K.Background : _a2qVgWDIm3fBp49WubttSTPsx8K_0);
						return qGGOTxZ8aNWGh0hc26wcmx8wmwT;
					}
					_ETHljYp3aQy9GQ1ZAzhfOYDI1sO._0rEYVY1cDKfLPVuLw54UlaIts2m("Failed to instance npc '{0}'", string_0);
					return null;
				}
				_ETHljYp3aQy9GQ1ZAzhfOYDI1sO._0rEYVY1cDKfLPVuLw54UlaIts2m("Failed to load npc '{0}'", string_0);
				return null;
			}
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT _4QLHHCk23T1BjK7acKxASbkCefG = _3IHp43rpkJgOBcY9lrIrwMuwWve._4QLHHCk23T1BjK7acKxASbkCefG;
			if (_4QLHHCk23T1BjK7acKxASbkCefG != null && _4QLHHCk23T1BjK7acKxASbkCefG._SC7QlorMIWTLSkD757wC7ybszpE)
			{
				return null;
			}
			_3IHp43rpkJgOBcY9lrIrwMuwWve._dPmC8tBC0iph2YBAFmztEsmwUdSA = ((_a2qVgWDIm3fBp49WubttSTPsx8K_0 == _a2qVgWDIm3fBp49WubttSTPsx8K.None) ? _3IHp43rpkJgOBcY9lrIrwMuwWve._dPmC8tBC0iph2YBAFmztEsmwUdSA : _a2qVgWDIm3fBp49WubttSTPsx8K_0);
			_3IHp43rpkJgOBcY9lrIrwMuwWve._ac2H6kMdrgPhXXxabsikjji4SiT = ((_3IHp43rpkJgOBcY9lrIrwMuwWve._dPmC8tBC0iph2YBAFmztEsmwUdSA == _a2qVgWDIm3fBp49WubttSTPsx8K.Background) ? 1 : 3);
			_xfiKuXXh5LQA9CUQiex6tutzFKQ._yMMFQ2n4dqXlB1AEzmdkoKkPkX5();
			return _3IHp43rpkJgOBcY9lrIrwMuwWve._4QLHHCk23T1BjK7acKxASbkCefG;
		}
		return null;
	}

	public T _TwQHHdbdRFRy2ctTZabNfz1Htrg<T>(_a2qVgWDIm3fBp49WubttSTPsx8K _a2qVgWDIm3fBp49WubttSTPsx8K_0) where T : _QGGOTxZ8aNWGh0hc26wcmx8wmwT
	{
		return _TwQHHdbdRFRy2ctTZabNfz1Htrg(typeof(T).Name, _a2qVgWDIm3fBp49WubttSTPsx8K_0) as T;
	}

	public void _yh2DwZs16cvRtvGayeYZrMWlrbj(int int_0)
	{
		_DW9IcpdMEINZmuzfrqmwsduBGih._7cuPUL8aamrg9daETH6zQk3RwbF(int_0, new _lRHDfpOTd4PxClZkjMpoakPEA9d
		{
			_OgCTYsivFfJrd6rCMMRTgWbJ8UK = 5,
			_M29jWtsDcmPvHjIYYSiTa8TbWri = _CCtbrNWS4Gi5hRSEsXYI5VzS7gI._Hnb6mPvrZFgOMCIApIeMW88jSsF,
			_q2NAvlMPupnT4cpCZEWLpac6jMe = _PSROht9Hy1Ik63UUdnKDUGBA0yQ(),
			_hZ0bFFCDXp4CkpoVdtAUZT5cpIK = _xfiKuXXh5LQA9CUQiex6tutzFKQ.GetType().Name,
			_QIaTN8Xtv0fmtjjEBsdflb1NoFl = _poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj
		});
	}

	public void _CYyzfcX8IclN1GnWsApBFWBpush(int int_0)
	{
		_DW9IcpdMEINZmuzfrqmwsduBGih._3y7m8OGVjMe7WGIhZ66YOw3ITUE(int_0, new _lRHDfpOTd4PxClZkjMpoakPEA9d
		{
			_OgCTYsivFfJrd6rCMMRTgWbJ8UK = 5,
			_M29jWtsDcmPvHjIYYSiTa8TbWri = _CCtbrNWS4Gi5hRSEsXYI5VzS7gI._Hnb6mPvrZFgOMCIApIeMW88jSsF,
			_hZ0bFFCDXp4CkpoVdtAUZT5cpIK = _xfiKuXXh5LQA9CUQiex6tutzFKQ.GetType().Name,
			_QIaTN8Xtv0fmtjjEBsdflb1NoFl = _poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj
		});
	}

	public bool _Ut0dhlh4JTZBMNJPNxxI9f9VqTp(int int_0)
	{
		_nvTYmpWmxq2DhO8ubfi3j5rZdLA();
		_lRHDfpOTd4PxClZkjMpoakPEA9d lRHDfpOTd4PxClZkjMpoakPEA9d = _DW9IcpdMEINZmuzfrqmwsduBGih._sabDA8yXNR8DIRSbHjOcXx1e1Ax(int_0);
		if (lRHDfpOTd4PxClZkjMpoakPEA9d != null)
		{
			_9gbCIL8lNtgBPuVMJ6pA7rCsMoT._NG0eIZcXsX6Fp38GhuED0LKeWHf(lRHDfpOTd4PxClZkjMpoakPEA9d);
			_CCtbrNWS4Gi5hRSEsXYI5VzS7gI._Hnb6mPvrZFgOMCIApIeMW88jSsF = lRHDfpOTd4PxClZkjMpoakPEA9d._M29jWtsDcmPvHjIYYSiTa8TbWri;
			_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = lRHDfpOTd4PxClZkjMpoakPEA9d._QIaTN8Xtv0fmtjjEBsdflb1NoFl;
			_poenyHBGUusBcnNcTFB9MQBV72R._AZrO8MxMUE7cKsFYTQ4k9O3q7yC()._Xrfjrxr72hHh4bDdQB7HzEbJUCb();
			_nkzqFdEfDyLcyGikIKGcHjklI4y._NhL238TaCbkDiY6HXlWXZzzUYkm = _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._wVLRBSMULz8GfedBPXaVJB0sBEO;
			_nkzqFdEfDyLcyGikIKGcHjklI4y._fUgDiz7KX8TZUVzFlTeXMOhmfUT = _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._sbK0941BvW8HgPboNwOhIAd2jP3;
			if (lRHDfpOTd4PxClZkjMpoakPEA9d._q2NAvlMPupnT4cpCZEWLpac6jMe != null)
			{
				_dmwpjPj0QtK7OW2M486hHkm5FKH(lRHDfpOTd4PxClZkjMpoakPEA9d._q2NAvlMPupnT4cpCZEWLpac6jMe);
			}
			else
			{
				if (!_dKSAtbg8U4PX1oOcOJ2BFewVtcI.Contains(lRHDfpOTd4PxClZkjMpoakPEA9d._hZ0bFFCDXp4CkpoVdtAUZT5cpIK))
				{
					lRHDfpOTd4PxClZkjMpoakPEA9d._hZ0bFFCDXp4CkpoVdtAUZT5cpIK = typeof(ClubInsideScene).Name;
				}
				if (!_9gbCIL8lNtgBPuVMJ6pA7rCsMoT._RUw8RieezXPoVSmbk3eROtfKXVi(this, lRHDfpOTd4PxClZkjMpoakPEA9d))
				{
					_k9wUPeU1Ga7cygiuGP8TT6aPLWF(lRHDfpOTd4PxClZkjMpoakPEA9d._hZ0bFFCDXp4CkpoVdtAUZT5cpIK);
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
			_CCtbrNWS4Gi5hRSEsXYI5VzS7gI._Hnb6mPvrZFgOMCIApIeMW88jSsF = lRHDfpOTd4PxClZkjMpoakPEA9d._M29jWtsDcmPvHjIYYSiTa8TbWri;
			_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = lRHDfpOTd4PxClZkjMpoakPEA9d._QIaTN8Xtv0fmtjjEBsdflb1NoFl;
			_poenyHBGUusBcnNcTFB9MQBV72R._AZrO8MxMUE7cKsFYTQ4k9O3q7yC()._Xrfjrxr72hHh4bDdQB7HzEbJUCb();
			_nkzqFdEfDyLcyGikIKGcHjklI4y._NhL238TaCbkDiY6HXlWXZzzUYkm = _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._wVLRBSMULz8GfedBPXaVJB0sBEO;
			_nkzqFdEfDyLcyGikIKGcHjklI4y._fUgDiz7KX8TZUVzFlTeXMOhmfUT = _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._sbK0941BvW8HgPboNwOhIAd2jP3;
			if (!_dKSAtbg8U4PX1oOcOJ2BFewVtcI.Contains(lRHDfpOTd4PxClZkjMpoakPEA9d._hZ0bFFCDXp4CkpoVdtAUZT5cpIK))
			{
				lRHDfpOTd4PxClZkjMpoakPEA9d._hZ0bFFCDXp4CkpoVdtAUZT5cpIK = typeof(ClubInsideScene).Name;
			}
			if (!_9gbCIL8lNtgBPuVMJ6pA7rCsMoT._RUw8RieezXPoVSmbk3eROtfKXVi(this, lRHDfpOTd4PxClZkjMpoakPEA9d))
			{
				_k9wUPeU1Ga7cygiuGP8TT6aPLWF(lRHDfpOTd4PxClZkjMpoakPEA9d._hZ0bFFCDXp4CkpoVdtAUZT5cpIK);
			}
			return true;
		}
		return false;
	}

	public void _EXfoFnp1OKxeZbd4GcVZMCO2urH(string string_0, string string_1, string string_2)
	{
		_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t()._7u6aevGWBE7ABqrBXoaPTkywcVo.Add(new _iDN1IKOu3e1uADYzeMEUon5D9fg
		{
			_dFaIUhufvE2Ld5IjNEwmPAqqraj = string_0,
			_D5QiLGGNtfoCEnZIUPvH4OKqUabA = string_1,
			_NvMJ5jDaeRR7HysERrVDtSlxaI5 = string_2,
			_QkxGXtWLzE0Z8JKyKkMiiph9giD = DateTime.Now
		});
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
			_5zNdOw7qHmuCAPJFMr3SsZdBlCr._haICL4qkfkOLhPhofWQH1GmjZx5();
		}
		_poenyHBGUusBcnNcTFB9MQBV72R._RiDuYMeg3EHnBUteUcAb8VlfQVl();
		_poenyHBGUusBcnNcTFB9MQBV72R._AZrO8MxMUE7cKsFYTQ4k9O3q7yC()._haICL4qkfkOLhPhofWQH1GmjZx5();
		_nkzqFdEfDyLcyGikIKGcHjklI4y._gVRGC9VAGHCLvP8p5Q4mqLPvFCm();
		_nkzqFdEfDyLcyGikIKGcHjklI4y._h0KfaNiikKlJV2KkRPIdVDKVJnC();
		_RA1aFlOff0jGfI2cKUGhYI1MRLBA._E7yBM68AWt7OGHJ5D6xYA8RK8tAA(new Color(0, 0, 0, 0));
	}

	[CompilerGenerated]
	private void _86vqN8sLvarYd06EMKfyLRTFanr()
	{
		_Qj2G6fpAF4mGsATgkV8DPBF3aA1A._FegL010tc92iskjjyD0T33dDwNE();
	}

	[CompilerGenerated]
	private void _IqIm0nfjkTCNpmzByUZSqOvFXNo<T>() where T : _7UlnfykmEmZDFt3BmCKZekI43Ih
	{
		_OxLRmpxixplTKChiTPUKAx4uTLG<T>(delegate
		{
			_RA1aFlOff0jGfI2cKUGhYI1MRLBA._FegL010tc92iskjjyD0T33dDwNE();
		});
	}

	[CompilerGenerated]
	private void _B5jLpbKxN5uZIpG1BovWH4IFrZC<T>() where T : _7UlnfykmEmZDFt3BmCKZekI43Ih
	{
		_RA1aFlOff0jGfI2cKUGhYI1MRLBA._FegL010tc92iskjjyD0T33dDwNE();
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
