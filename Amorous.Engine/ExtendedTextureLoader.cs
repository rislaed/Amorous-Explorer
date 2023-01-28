using System.IO;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Spine;

public class ExtendedTextureLoader : TextureLoader
{
	private static ExtendedTextureLoader _singleton;
	private readonly ContentManager _content;

	public static ExtendedTextureLoader Singleton => _singleton;

	public ExtendedTextureLoader(ContentManager content)
	{
		_singleton = this;
		_content = content;
	}

	public void Load(AtlasPage page, string path)
	{
		string assetName = Path.Combine(Path.GetDirectoryName(path), Path.GetFileNameWithoutExtension(path));
		Texture2D texture2D = (Texture2D)(page.rendererObject = _content.Load<Texture2D>(assetName));
		page.width = texture2D.Width;
		page.height = texture2D.Height;
	}

	public void Unload(object texture)
	{
		((Texture2D)texture).Dispose();
	}
}
