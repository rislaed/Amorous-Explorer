using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Amorous.Engine.NPC;

public abstract class LayerNPC<THead, TPose, TClothes> : _xZgbANe7gi6i2DAhBEkKpR1QFLe where THead : struct, IConvertible where TPose : struct, IConvertible where TClothes : struct, IConvertible
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _CLzBOI60196rKXmrRzSRwNuiYqP
	{
		public static readonly _CLzBOI60196rKXmrRzSRwNuiYqP _003C_003E9 = new _CLzBOI60196rKXmrRzSRwNuiYqP();

		public static Func<TClothes, string> _003C_003E9__6_0;

		internal string _jDsAwjl1Oz7ULh4XTWJjpVW0wjL(TClothes gparam_0)
		{
			return _CLzBOI60196rKXmrRzSRwNuiYqP.smethod_1(_CLzBOI60196rKXmrRzSRwNuiYqP.smethod_0(typeof(TClothes).TypeHandle), (object)gparam_0);
		}

		static Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		static string smethod_1(Type type_0, object object_0)
		{
			return Enum.GetName(type_0, object_0);
		}
	}

	protected LayerNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, string string_0, float float_0 = 1f)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, string_0, float_0)
	{
	}

	public _xmfdPa5IagU3cXbLL61gyoXAV7gA _aRXZ6kQYnlqRUMIC19x1vIPD62D(THead gparam_0, params string[] string_0)
	{
		return _aRXZ6kQYnlqRUMIC19x1vIPD62D(LayerNPC<THead, TPose, TClothes>.smethod_15(LayerNPC<THead, TPose, TClothes>.smethod_14(typeof(THead).TypeHandle), (object)gparam_0), string_0);
	}

	public _NaKchYC4I4GjWR34SfBLAktysCE _zDmJ8ztQTMoRvRw2LsNKu5foPpF(TPose gparam_0, params string[] string_0)
	{
		return _zDmJ8ztQTMoRvRw2LsNKu5foPpF(LayerNPC<THead, TPose, TClothes>.smethod_15(LayerNPC<THead, TPose, TClothes>.smethod_14(typeof(TPose).TypeHandle), (object)gparam_0), string_0);
	}

	public _EZ0kOLXoEoEfWGQDdTbNqaPzDUh _ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(TPose gparam_0, TClothes gparam_1, params string[] string_0)
	{
		return _ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(LayerNPC<THead, TPose, TClothes>.smethod_15(LayerNPC<THead, TPose, TClothes>.smethod_14(typeof(TPose).TypeHandle), (object)gparam_0), LayerNPC<THead, TPose, TClothes>.smethod_15(LayerNPC<THead, TPose, TClothes>.smethod_14(typeof(TClothes).TypeHandle), (object)gparam_1), string_0);
	}

	public void _g3oEqGBkN3YHUPosRq2nIP2sX0D(THead gparam_0)
	{
		_g3oEqGBkN3YHUPosRq2nIP2sX0D(LayerNPC<THead, TPose, TClothes>.smethod_15(LayerNPC<THead, TPose, TClothes>.smethod_14(typeof(THead).TypeHandle), (object)gparam_0));
	}

	public void _tDFvus0ZCanjp81eOiDzoMXJiuf(TPose gparam_0)
	{
		_tDFvus0ZCanjp81eOiDzoMXJiuf(LayerNPC<THead, TPose, TClothes>.smethod_15(LayerNPC<THead, TPose, TClothes>.smethod_14(typeof(TPose).TypeHandle), (object)gparam_0));
	}

	public void _09vxUzgOn7J7DFZEwsTh7lgEIhB(params TClothes[] gparam_0)
	{
		_09vxUzgOn7J7DFZEwsTh7lgEIhB(gparam_0.Select((TClothes gparam_0) => _CLzBOI60196rKXmrRzSRwNuiYqP.smethod_1(_CLzBOI60196rKXmrRzSRwNuiYqP.smethod_0(typeof(TClothes).TypeHandle), (object)gparam_0)).ToArray());
	}

	static Type smethod_14(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static string smethod_15(Type type_0, object object_0)
	{
		return Enum.GetName(type_0, object_0);
	}
}
