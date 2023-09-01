using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Xna.Framework.Content;

namespace Amorous.Explorer.Content.Asset;

public class AssetDecoder
{
	private static readonly ISet<Type> Decoders = new HashSet<Type>();

	public static void RegisterDecoder(Type decoder)
	{
		if (!typeof(AbstractAsset).IsAssignableFrom(decoder))
		{
			throw new ArgumentException("Decoder must be instance of AbstractAsset!");
		}
		Decoders.Add(decoder);
	}

	public static void RegisterDecoder<T>() where T : AbstractAsset
	{
		RegisterDecoder(typeof(T));
	}

	protected AbstractAsset[] Assets;

	public AssetDecoder()
	{
		if (Decoders.Count == 0)
		{
			RegisterDecoder<TextureAsset>();
			RegisterDecoder<SoundEffectAsset>();
			RegisterDecoder<SongAsset>();
			RegisterDecoder<SpriteFontAsset>();
			RegisterDecoder<EffectAsset>();
		}
		Assets = new AbstractAsset[Decoders.Count];
		int index = 0;
		foreach (Type decoder in Decoders)
		{
			try
			{
				Assets[index++] = ((AbstractAsset)Activator.CreateInstance(decoder));
			}
			catch (Exception ex)
			{
				Logger.Warning("Asset {0} unsupported: {1}", decoder.Name, ex.Message);
			}
		}
		if (index < Assets.Length)
		{
			Array.Resize(ref Assets, index);
		}
	}

	public virtual AbstractAsset Find(object asset)
	{
		return Assets.FirstOrDefault((asset) => asset.CanHandle(asset));
	}

	public bool Test(object asset)
	{
		return Find(asset) != null;
	}

	public virtual bool Decode(string inputDirectory, string targetDirectory, string assetName, object asset)
	{
		IEnumerable<AbstractAsset> decoders = Assets.Where((decoder) => decoder.CanHandle(asset));
		if (decoders.Count() == 0)
		{
			return false;
		}
		string target = Path.Combine(targetDirectory, assetName);
		XnbHeader header = XnbHeader.Of(Path.Combine(inputDirectory, assetName));
		bool successful = false;
		foreach (AbstractAsset decoder in decoders)
		{
			try
			{
				decoder.HandleToFile(target, assetName, asset, header);
				successful = true;
			}
			catch (Exception ex)
			{
				Logger.Warning("{0} unexpectly crashed: {1}", decoder.GetType().Name, ex.ToString());
			}
		}
		return successful;
	}

	public bool Decode(string directory, string assetName, ContentManager content, Func<object, bool> predicate = null)
	{
		bool externallyLoaded = content is AssociativeContentManager associative
			&& associative.IsLoaded(assetName) && associative.IsXnb(assetName);
		object asset = content.Load<object>(assetName);
		bool successful = true;
		if (predicate == null || predicate.Invoke(asset))
		{
			successful = Decode(content.RootDirectory, directory, assetName, asset);
		}
		if (!externallyLoaded)
		{
			content.Unload(asset);
		}
		return successful;
	}
}
