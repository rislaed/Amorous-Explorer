using System.IO;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Spine;

public class SpineTextureLoader : TextureLoader
{ // _AUtA43NfhBNYDqRrVB1t9VQxe1v
	private static SpineTextureLoader singleton;
	private readonly ContentManager content;

	public static SpineTextureLoader Singleton => singleton;

	public SpineTextureLoader(ContentManager content)
	{
		singleton = this;
		this.content = content;
	}

	public void Load(AtlasPage page, string path)
	{
		string assetName = Path.Combine(Path.GetDirectoryName(path), Path.GetFileNameWithoutExtension(path));
		Texture2D texture = (Texture2D)(page.rendererObject = content.Load<Texture2D>(assetName));
		page.width = texture.Width;
		page.height = texture.Height;
	}

	public void Unload(object texture)
	{
		((Texture2D)texture).Dispose();
	}
}
