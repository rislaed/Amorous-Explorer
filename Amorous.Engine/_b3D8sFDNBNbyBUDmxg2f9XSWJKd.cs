using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework.Content;

public static class _b3D8sFDNBNbyBUDmxg2f9XSWJKd
{
	[CompilerGenerated]
	private sealed class _nY1OFW7TikQYOzJGUdCGm2Tdhqb
	{
		public object _oZJtyz2XxMydVdgzVMCBjBIQPxF;

		internal bool _PQoaoJaHq36B0HvaG5yhyERjPOf(KeyValuePair<string, object> keyValuePair_0)
		{
			return keyValuePair_0.Value == _oZJtyz2XxMydVdgzVMCBjBIQPxF;
		}
	}

	private static Dictionary<string, object> _vFlf6NbDv32TsNiHZpYwZhv1lRo;

	private static List<IDisposable> _gtSa6GVF63EHA9kPi3x0tr1inFL;

	private static bool _2VS8GRacHIBPAQggjTbCw7Ocxni;

	private static void _oD87G7SXjsTukw7IVWxVlVFEgvA(ContentManager contentManager_0)
	{
		FieldInfo fieldInfo_ = _b3D8sFDNBNbyBUDmxg2f9XSWJKd.smethod_1(_b3D8sFDNBNbyBUDmxg2f9XSWJKd.smethod_0(typeof(ContentManager).TypeHandle), "loadedAssets", BindingFlags.Instance | BindingFlags.NonPublic);
		_vFlf6NbDv32TsNiHZpYwZhv1lRo = (Dictionary<string, object>)_b3D8sFDNBNbyBUDmxg2f9XSWJKd.smethod_2(fieldInfo_, (object)contentManager_0);
		FieldInfo fieldInfo_2 = _b3D8sFDNBNbyBUDmxg2f9XSWJKd.smethod_1(_b3D8sFDNBNbyBUDmxg2f9XSWJKd.smethod_0(typeof(ContentManager).TypeHandle), "disposableAssets", BindingFlags.Instance | BindingFlags.NonPublic);
		_gtSa6GVF63EHA9kPi3x0tr1inFL = (List<IDisposable>)_b3D8sFDNBNbyBUDmxg2f9XSWJKd.smethod_2(fieldInfo_2, (object)contentManager_0);
	}

	public static void _HXLRmt9GqcmA9GTG5xzRKNu3QpF(this ContentManager contentManager_0, object object_0)
	{
		if (!_2VS8GRacHIBPAQggjTbCw7Ocxni)
		{
			_2VS8GRacHIBPAQggjTbCw7Ocxni = true;
			_oD87G7SXjsTukw7IVWxVlVFEgvA(contentManager_0);
		}
		KeyValuePair<string, object> keyValuePair = _vFlf6NbDv32TsNiHZpYwZhv1lRo.FirstOrDefault((KeyValuePair<string, object> keyValuePair_0) => keyValuePair_0.Value == object_0);
		if (keyValuePair.Key != null)
		{
			_vFlf6NbDv32TsNiHZpYwZhv1lRo.Remove(keyValuePair.Key);
		}
		if (object_0 is IDisposable disposable)
		{
			if (_gtSa6GVF63EHA9kPi3x0tr1inFL.Contains(object_0))
			{
				_gtSa6GVF63EHA9kPi3x0tr1inFL.Remove(disposable);
			}
			_b3D8sFDNBNbyBUDmxg2f9XSWJKd.smethod_3(disposable);
		}
	}

	static Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static FieldInfo smethod_1(Type type_0, string string_0, BindingFlags bindingFlags_0)
	{
		return type_0.GetField(string_0, bindingFlags_0);
	}

	static object smethod_2(FieldInfo fieldInfo_0, object object_0)
	{
		return fieldInfo_0.GetValue(object_0);
	}

	static void smethod_3(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}
}
