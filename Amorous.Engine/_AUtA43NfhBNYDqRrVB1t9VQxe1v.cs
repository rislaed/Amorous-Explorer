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
		string text = _AUtA43NfhBNYDqRrVB1t9VQxe1v.smethod_2(_AUtA43NfhBNYDqRrVB1t9VQxe1v.smethod_0(path), _AUtA43NfhBNYDqRrVB1t9VQxe1v.smethod_1(path));
		Texture2D texture2D_ = (Texture2D)(page.rendererObject = _7FoDc5IeOhkrJIekU2AAQQKZqefA.Load<Texture2D>(text));
		page.width = _AUtA43NfhBNYDqRrVB1t9VQxe1v.smethod_3(texture2D_);
		page.height = _AUtA43NfhBNYDqRrVB1t9VQxe1v.smethod_4(texture2D_);
	}

	public void Unload(object texture)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		_AUtA43NfhBNYDqRrVB1t9VQxe1v.smethod_5((GraphicsResource)(Texture2D)texture);
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
