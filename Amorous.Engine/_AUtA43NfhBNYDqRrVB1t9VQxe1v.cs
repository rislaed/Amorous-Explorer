using System.IO;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Spine;

public class _AUtA43NfhBNYDqRrVB1t9VQxe1v : TextureLoader
{
	private static _AUtA43NfhBNYDqRrVB1t9VQxe1v _6T55wit7MiGfAWRkPwjNbJ8N8lG;

	private readonly ContentManager _7FoDc5IeOhkrJIekU2AAQQKZqefA;

	public static _AUtA43NfhBNYDqRrVB1t9VQxe1v _yuFBJdi7mxrwMFQ57BjLjSq6ESj => _6T55wit7MiGfAWRkPwjNbJ8N8lG;

	public _AUtA43NfhBNYDqRrVB1t9VQxe1v(ContentManager contentManager_0)
	{
		_6T55wit7MiGfAWRkPwjNbJ8N8lG = this;
		_7FoDc5IeOhkrJIekU2AAQQKZqefA = contentManager_0;
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
