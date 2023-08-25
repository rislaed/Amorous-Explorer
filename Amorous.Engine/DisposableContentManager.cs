using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.Xna.Framework.Content;

public static class DisposableContentManager
{ // _b3D8sFDNBNbyBUDmxg2f9XSWJKd
	private static Dictionary<string, object> loadedAssets;
	private static List<IDisposable> disposableAssets;
	private static bool initialized;

	private static void Initialize(ContentManager content)
	{
		FieldInfo loadedAssetsPtr = typeof(ContentManager).GetField("loadedAssets", BindingFlags.Instance | BindingFlags.NonPublic);
        loadedAssets = (Dictionary<string, object>)loadedAssetsPtr.GetValue(content);
		FieldInfo disposableAssetsPtr = typeof(ContentManager).GetField("disposableAssets", BindingFlags.Instance | BindingFlags.NonPublic);
        disposableAssets = (List<IDisposable>)disposableAssetsPtr.GetValue(content);
	}

	public static void Unload(this ContentManager content, object what)
	{
		if (!initialized)
		{
			initialized = true;
			Initialize(content);
		}
		KeyValuePair<string, object> asset = loadedAssets.FirstOrDefault((KeyValuePair<string, object> asset) => asset.Value == what);
		if (asset.Key != null)
		{
			loadedAssets.Remove(asset.Key);
		}
		if (what is IDisposable disposable)
		{
			if (disposableAssets.Contains(what))
			{
				disposableAssets.Remove(disposable);
			}
			disposable.Dispose();
		}
	}
}
