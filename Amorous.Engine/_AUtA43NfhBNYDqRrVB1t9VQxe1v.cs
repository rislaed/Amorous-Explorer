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
		string text = Path.Combine(Path.GetDirectoryName(path), Path.GetFileNameWithoutExtension(path));
		Texture2D val = (Texture2D)(page.rendererObject = _7FoDc5IeOhkrJIekU2AAQQKZqefA.Load<Texture2D>(text));
		page.width = val.get_Width();
		page.height = val.get_Height();
	}

	public void Unload(object texture)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		((GraphicsResource)(Texture2D)texture).Dispose();
	}

	static string smethod_0(string string_0)
	{
		return Path.GetDirectoryName(string_0);
	}

	static string smethod_1(string string_0)
	{
		return Path.GetFileNameWithoutExtension(string_0);
	}

	static string smethod_2(string string_0, string string_1)
	{
		return Path.Combine(string_0, string_1);
	}

	static int smethod_3(Texture2D texture2D_0)
	{
		return texture2D_0.get_Width();
	}

	static int smethod_4(Texture2D texture2D_0)
	{
		return texture2D_0.get_Height();
	}

	static void smethod_5(GraphicsResource graphicsResource_0)
	{
		graphicsResource_0.Dispose();
	}
}
