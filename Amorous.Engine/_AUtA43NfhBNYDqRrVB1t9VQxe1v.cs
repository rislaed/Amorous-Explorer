using System.IO;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Spine;

public class _AUtA43NfhBNYDqRrVB1t9VQxe1v : TextureLoader
{
	private static _AUtA43NfhBNYDqRrVB1t9VQxe1v Singleton;

	private readonly ContentManager _7FoDc5IeOhkrJIekU2AAQQKZqefA;

	public static _AUtA43NfhBNYDqRrVB1t9VQxe1v Self => Singleton;

	public _AUtA43NfhBNYDqRrVB1t9VQxe1v(ContentManager content)
	{
		Singleton = this;
		_7FoDc5IeOhkrJIekU2AAQQKZqefA = content;
	}

	public void Load(AtlasPage page, string path)
	{
		string assetName = Path.Combine(Path.GetDirectoryName(path), Path.GetFileNameWithoutExtension(path));
		Texture2D texture2D = (Texture2D)(page.rendererObject = _7FoDc5IeOhkrJIekU2AAQQKZqefA.Load<Texture2D>(assetName));
		page.width = texture2D.Width;
		page.height = texture2D.Height;
	}

	public void Unload(object texture)
	{
		((Texture2D)texture).Dispose();
	}
}
