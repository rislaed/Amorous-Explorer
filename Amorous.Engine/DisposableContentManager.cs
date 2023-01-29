using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.Xna.Framework.Content;

public static class DisposableContentManager
{ // _b3D8sFDNBNbyBUDmxg2f9XSWJKd
	private static Dictionary<string, object> _loadedAssets;
	private static List<IDisposable> _disposableAssets;
	private static bool _initialized;

	private static void Initialize(ContentManager content)
	{
		FieldInfo loadedAssets = typeof(ContentManager).GetField("loadedAssets", BindingFlags.Instance | BindingFlags.NonPublic);
		_loadedAssets = (Dictionary<string, object>)loadedAssets.GetValue(content);
		FieldInfo disposableAssets = typeof(ContentManager).GetField("disposableAssets", BindingFlags.Instance | BindingFlags.NonPublic);
		_disposableAssets = (List<IDisposable>)disposableAssets.GetValue(content);
	}

	public static void Unload(this ContentManager content, object what)
	{
		if (!_initialized)
		{
			_initialized = true;
			Initialize(content);
		}
		KeyValuePair<string, object> asset = _loadedAssets.FirstOrDefault((KeyValuePair<string, object> asset) => asset.Value == what);
		if (asset.Key != null)
		{
			_loadedAssets.Remove(asset.Key);
		}
		if (what is IDisposable disposable)
		{
			if (_disposableAssets.Contains(what))
			{
				_disposableAssets.Remove(disposable);
			}
			disposable.Dispose();
		}
	}
}
