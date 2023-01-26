using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework.Content;

public static class _b3D8sFDNBNbyBUDmxg2f9XSWJKd
{
	private static Dictionary<string, object> _vFlf6NbDv32TsNiHZpYwZhv1lRo;

	private static List<IDisposable> _gtSa6GVF63EHA9kPi3x0tr1inFL;

	private static bool _2VS8GRacHIBPAQggjTbCw7Ocxni;

	private static void Initialize(ContentManager content)
	{
		FieldInfo field = typeof(ContentManager).GetField("loadedAssets", BindingFlags.Instance | BindingFlags.NonPublic);
		_vFlf6NbDv32TsNiHZpYwZhv1lRo = (Dictionary<string, object>)field.GetValue(content);
		FieldInfo field2 = typeof(ContentManager).GetField("disposableAssets", BindingFlags.Instance | BindingFlags.NonPublic);
		_gtSa6GVF63EHA9kPi3x0tr1inFL = (List<IDisposable>)field2.GetValue(content);
	}

	public static void _HXLRmt9GqcmA9GTG5xzRKNu3QpF(this ContentManager content, object object_0)
	{
		if (!_2VS8GRacHIBPAQggjTbCw7Ocxni)
		{
			_2VS8GRacHIBPAQggjTbCw7Ocxni = true;
			Initialize(content);
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
			disposable.Dispose();
		}
	}
}
