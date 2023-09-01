using System.IO;

namespace Amorous.Explorer.Content.Asset;

public abstract class AbstractAsset
{
	public abstract bool CanHandle(object asset);

	public virtual void HandleToFile(string path, string assetName, object asset, XnbHeader elf)
	{
		Directory.CreateDirectory(Path.GetDirectoryName(path));
	}
}
