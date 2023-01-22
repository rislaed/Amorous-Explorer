using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Squid;

public class _k8LAl8bPyzLGEpo59dKFGU4sCQ : IDisposable, ISquidRenderer
{
	private readonly Dictionary<int, SpriteFont> _Ks5fhSCbnJp6pmRDanq4sn9DlRF = new Dictionary<int, SpriteFont>();

	private readonly Dictionary<int, Texture2D> _48Ia4uIlwwllIw0MIzPjdWOBDqx = new Dictionary<int, Texture2D>();

	private readonly Dictionary<string, int> _ludG33HqMIBuda5aoAUm6woMHdh = new Dictionary<string, int>();

	private readonly Dictionary<string, int> _Al96gNPtV1ulU681NMxd1IeQxQq = new Dictionary<string, int>();

	private readonly Game _4L7hfXrWoDdArQiscG4ukHCV46B;

	private readonly SpriteBatch _OaIpAM8LUMZnUHberg4zeLNyWCd;

	private readonly Texture2D _5YcBaRKou3OVWCywHF9K49yk2u9;

	private readonly RasterizerState _T3zdQhKBBD6DNUg8RQ7EupUHIoE;

	private readonly string _3qOVW0rru0fnFsK9qtJ6Gk1F0bE = "Assets/Gui/Fonts/Bold-14";

	private int _SfJPevkmlfWx0UJQBD7GNI1bOPA;

	private SpriteFont _YWublsgGSMYGc5V0KPieIYbXfdl;

	private Texture2D _lruDd2bffYslbTUZZOo7HsfbTFA;

	public _k8LAl8bPyzLGEpo59dKFGU4sCQ(Game game_0)
	{
		_4L7hfXrWoDdArQiscG4ukHCV46B = game_0;
		_OaIpAM8LUMZnUHberg4zeLNyWCd = new SpriteBatch(game_0.GraphicsDevice);
		_5YcBaRKou3OVWCywHF9K49yk2u9 = new Texture2D(_4L7hfXrWoDdArQiscG4ukHCV46B.GraphicsDevice, 1, 1);
		_5YcBaRKou3OVWCywHF9K49yk2u9.SetData(new Color[1]
		{
			new Color(255, 255, 255, 255)
		});
		_T3zdQhKBBD6DNUg8RQ7EupUHIoE = new RasterizerState
		{
			ScissorTestEnable = true
		};
		_Al96gNPtV1ulU681NMxd1IeQxQq.Add(string.Empty, 0);
		_48Ia4uIlwwllIw0MIzPjdWOBDqx.Add(0, _5YcBaRKou3OVWCywHF9K49yk2u9);
	}

	private Color _TmKnNO76rW7a4nj5ivlAGl4rlrd(int int_0)
	{
		byte[] bytes = BitConverter.GetBytes(int_0);
		return new Color((float)(int)bytes[2] / 255f, (float)(int)bytes[1] / 255f, (float)(int)bytes[0] / 255f) * ((float)(int)bytes[3] / 255f);
	}

	public int GetTexture(string name)
	{
		if (_Al96gNPtV1ulU681NMxd1IeQxQq.TryGetValue(name ?? string.Empty, out _SfJPevkmlfWx0UJQBD7GNI1bOPA))
		{
			return _SfJPevkmlfWx0UJQBD7GNI1bOPA;
		}
		Texture2D value = _4L7hfXrWoDdArQiscG4ukHCV46B.Content.Load<Texture2D>(Path.GetDirectoryName(name) + "/" + Path.GetFileNameWithoutExtension(name));
		int count = _Al96gNPtV1ulU681NMxd1IeQxQq.Count;
		_Al96gNPtV1ulU681NMxd1IeQxQq.Add(name, count);
		_48Ia4uIlwwllIw0MIzPjdWOBDqx.Add(count, value);
		return count;
	}

	public void SetTexture(string name, object texture)
	{
		if (_Al96gNPtV1ulU681NMxd1IeQxQq.TryGetValue(name, out _SfJPevkmlfWx0UJQBD7GNI1bOPA))
		{
			_48Ia4uIlwwllIw0MIzPjdWOBDqx[_SfJPevkmlfWx0UJQBD7GNI1bOPA] = (Texture2D)texture;
			return;
		}
		int count = _Al96gNPtV1ulU681NMxd1IeQxQq.Count;
		_Al96gNPtV1ulU681NMxd1IeQxQq.Add(name, count);
		_48Ia4uIlwwllIw0MIzPjdWOBDqx.Add(count, (Texture2D)texture);
	}

	public int GetFont(string name)
	{
		if (name == "default")
		{
			name = _3qOVW0rru0fnFsK9qtJ6Gk1F0bE;
		}
		if (!_ludG33HqMIBuda5aoAUm6woMHdh.TryGetValue(name, out _SfJPevkmlfWx0UJQBD7GNI1bOPA))
		{
			SpriteFont value = _4L7hfXrWoDdArQiscG4ukHCV46B.Content.Load<SpriteFont>(name);
			int count = _ludG33HqMIBuda5aoAUm6woMHdh.Count;
			_ludG33HqMIBuda5aoAUm6woMHdh.Add(name, count);
			_Ks5fhSCbnJp6pmRDanq4sn9DlRF.Add(count, value);
			return count;
		}
		return _SfJPevkmlfWx0UJQBD7GNI1bOPA;
	}

	public Squid.Point GetTextSize(string text, int font)
	{
		if (string.IsNullOrEmpty(text))
		{
			return Squid.Point.Zero;
		}
		if (_Ks5fhSCbnJp6pmRDanq4sn9DlRF.TryGetValue(font, out _YWublsgGSMYGc5V0KPieIYbXfdl))
		{
			Vector2 vector = _YWublsgGSMYGc5V0KPieIYbXfdl.MeasureString(text);
			return new Squid.Point((int)vector.X, (int)vector.Y);
		}
		return Squid.Point.Zero;
	}

	public Squid.Point GetTextureSize(int texture)
	{
		if (_48Ia4uIlwwllIw0MIzPjdWOBDqx.TryGetValue(texture, out _lruDd2bffYslbTUZZOo7HsfbTFA))
		{
			return new Squid.Point(_lruDd2bffYslbTUZZOo7HsfbTFA.Width, _lruDd2bffYslbTUZZOo7HsfbTFA.Height);
		}
		return Squid.Point.Zero;
	}

	public void DrawBox(int x, int y, int w, int h, int color)
	{
		_OaIpAM8LUMZnUHberg4zeLNyWCd.Draw(_5YcBaRKou3OVWCywHF9K49yk2u9, new Microsoft.Xna.Framework.Rectangle(x, y, w, h), _TmKnNO76rW7a4nj5ivlAGl4rlrd(color));
	}

	public void DrawText(string text, int x, int y, int font, int color)
	{
		if (_Ks5fhSCbnJp6pmRDanq4sn9DlRF.TryGetValue(font, out _YWublsgGSMYGc5V0KPieIYbXfdl))
		{
			_OaIpAM8LUMZnUHberg4zeLNyWCd._FY70IFLoBond3ORPe0ndCLvIeVcA(_YWublsgGSMYGc5V0KPieIYbXfdl, text, new Vector2(x, y), _TmKnNO76rW7a4nj5ivlAGl4rlrd(color));
		}
	}

	public void DrawTexture(int texture, int x, int y, int w, int h, Squid.Rectangle rect, int color)
	{
		if (_48Ia4uIlwwllIw0MIzPjdWOBDqx.TryGetValue(texture, out _lruDd2bffYslbTUZZOo7HsfbTFA))
		{
			_OaIpAM8LUMZnUHberg4zeLNyWCd.Draw(_lruDd2bffYslbTUZZOo7HsfbTFA, new Microsoft.Xna.Framework.Rectangle(x, y, w, h), new Microsoft.Xna.Framework.Rectangle(rect.Left, rect.Top, rect.Width, rect.Height), _TmKnNO76rW7a4nj5ivlAGl4rlrd(color), 0f, Vector2.Zero, SpriteEffects.None, 0f);
		}
	}

	public void Scissor(int x, int y, int w, int h)
	{
		_4L7hfXrWoDdArQiscG4ukHCV46B.GraphicsDevice.ScissorRectangle = new Microsoft.Xna.Framework.Rectangle(x, y, w, h);
	}

	public void StartBatch()
	{
		_OaIpAM8LUMZnUHberg4zeLNyWCd._g9Sx54kMPiHz5jrqWh4Kb1pTijH(SpriteSortMode.Deferred, null, null, null, _T3zdQhKBBD6DNUg8RQ7EupUHIoE);
	}

	public void EndBatch(bool final)
	{
		_OaIpAM8LUMZnUHberg4zeLNyWCd.End();
	}

	public void Dispose()
	{
	}

	static GraphicsDevice smethod_0(Game game_0)
	{
		return game_0.GraphicsDevice;
	}

	static SpriteBatch smethod_1(GraphicsDevice graphicsDevice_0)
	{
		return new SpriteBatch(graphicsDevice_0);
	}

	static Texture2D smethod_2(GraphicsDevice graphicsDevice_0, int int_0, int int_1)
	{
		return new Texture2D(graphicsDevice_0, int_0, int_1);
	}

	static byte[] smethod_3(int int_0)
	{
		return BitConverter.GetBytes(int_0);
	}

	static ContentManager smethod_4(Game game_0)
	{
		return game_0.Content;
	}

	static string smethod_5(string string_0)
	{
		return Path.GetDirectoryName(string_0);
	}

	static string smethod_6(string string_0)
	{
		return Path.GetFileNameWithoutExtension(string_0);
	}

	static string smethod_7(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	static bool smethod_8(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	static bool smethod_9(string string_0)
	{
		return string.IsNullOrEmpty(string_0);
	}

	static Vector2 smethod_10(SpriteFont spriteFont_0, string string_0)
	{
		return spriteFont_0.MeasureString(string_0);
	}

	static int smethod_11(Texture2D texture2D_0)
	{
		return texture2D_0.Width;
	}

	static int smethod_12(Texture2D texture2D_0)
	{
		return texture2D_0.Height;
	}

	static void smethod_13(SpriteBatch spriteBatch_0)
	{
		spriteBatch_0.End();
	}
}
