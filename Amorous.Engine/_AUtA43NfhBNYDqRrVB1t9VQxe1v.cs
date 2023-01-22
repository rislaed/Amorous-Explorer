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
		Texture2D val = default(Texture2D);
		while (true)
		{
			int num = -926980900;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEB828E6Fu) % 6u)
				{
				case 5u:
					val = _7FoDc5IeOhkrJIekU2AAQQKZqefA.Load<Texture2D>(text);
					num = (int)((num2 * 1460076939) ^ 0x1B6ECE68);
					continue;
				case 4u:
					page.width = _AUtA43NfhBNYDqRrVB1t9VQxe1v.smethod_3(val);
					num = ((int)num2 * -1231016990) ^ -1936889660;
					continue;
				case 2u:
					page.rendererObject = val;
					num = ((int)num2 * -1910345332) ^ 0x70DA52A1;
					continue;
				case 1u:
					page.height = _AUtA43NfhBNYDqRrVB1t9VQxe1v.smethod_4(val);
					num = ((int)num2 * -453636112) ^ -1280805424;
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
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
