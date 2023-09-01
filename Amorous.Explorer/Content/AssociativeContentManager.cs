using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.Xna.Framework.Content;

namespace Amorous.Explorer.Content;

public class AssociativeContentManager : ContentManager
{
	private readonly Dictionary<string, object> loadedAssets, associatedLoadedAssets;
	private readonly Dictionary<string, string> associatedExtensions
		= new Dictionary<string, string>();
	private readonly List<IDisposable> disposableAssets;

	public AssociativeContentManager(ContentManager association)
		: base(association.ServiceProvider, association.RootDirectory)
	{
		FieldInfo loadedAssetsPtr = typeof(ContentManager).GetField("loadedAssets", BindingFlags.Instance | BindingFlags.NonPublic);
		associatedLoadedAssets = (Dictionary<string, object>)loadedAssetsPtr.GetValue(association);
		loadedAssets = (Dictionary<string, object>)loadedAssetsPtr.GetValue(this);
		FieldInfo disposableAssetsPtr = typeof(ContentManager).GetField("disposableAssets", BindingFlags.Instance | BindingFlags.NonPublic);
		disposableAssets = (List<IDisposable>)disposableAssetsPtr.GetValue(this);
	}

	public bool IsXnb(string assetName)
	{
		if (string.IsNullOrEmpty(assetName))
		{
			return false;
		}
		assetName = assetName.Replace('\\', '/');
		return associatedExtensions.ContainsKey(assetName)
			&& associatedExtensions[assetName] == ".xnb";
	}

	public bool IsLoaded(string assetName)
	{
		if (string.IsNullOrEmpty(assetName))
		{
			return false;
		}
		assetName = assetName.Replace('\\', '/');
		return associatedLoadedAssets.ContainsKey(assetName)
			|| loadedAssets.ContainsKey(assetName);
	}

	public void Unload(object what)
	{
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

	protected override Stream OpenStream(string assetName)
	{
		Stream stream = base.OpenStream(assetName);
		if (stream is FileStream fileStream)
		{
			associatedExtensions[assetName] = Path.GetExtension(fileStream.Name);
		}
		return Compressions.ReadStream(stream);
	}
}
