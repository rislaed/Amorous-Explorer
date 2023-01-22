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
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		_4L7hfXrWoDdArQiscG4ukHCV46B = game_0;
		_OaIpAM8LUMZnUHberg4zeLNyWCd = _k8LAl8bPyzLGEpo59dKFGU4sCQ.smethod_1(_k8LAl8bPyzLGEpo59dKFGU4sCQ.smethod_0(game_0));
		_5YcBaRKou3OVWCywHF9K49yk2u9 = _k8LAl8bPyzLGEpo59dKFGU4sCQ.smethod_2(_k8LAl8bPyzLGEpo59dKFGU4sCQ.smethod_0(_4L7hfXrWoDdArQiscG4ukHCV46B), 1, 1);
		_5YcBaRKou3OVWCywHF9K49yk2u9.SetData<Color>((Color[])(object)new Color[1]
		{
			new Color(255, 255, 255, 255)
		});
		RasterizerState val = new RasterizerState();
		val.set_ScissorTestEnable(true);
		_T3zdQhKBBD6DNUg8RQ7EupUHIoE = val;
		_Al96gNPtV1ulU681NMxd1IeQxQq.Add(string.Empty, 0);
		_48Ia4uIlwwllIw0MIzPjdWOBDqx.Add(0, _5YcBaRKou3OVWCywHF9K49yk2u9);
	}

	private Color _TmKnNO76rW7a4nj5ivlAGl4rlrd(int int_0)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		byte[] array = _k8LAl8bPyzLGEpo59dKFGU4sCQ.smethod_3(int_0);
		return new Color((float)(int)array[2] / 255f, (float)(int)array[1] / 255f, (float)(int)array[0] / 255f) * ((float)(int)array[3] / 255f);
	}

	public int GetTexture(string name)
	{
		if (_Al96gNPtV1ulU681NMxd1IeQxQq.TryGetValue(name ?? string.Empty, out _SfJPevkmlfWx0UJQBD7GNI1bOPA))
		{
			return _SfJPevkmlfWx0UJQBD7GNI1bOPA;
		}
		Texture2D value = _k8LAl8bPyzLGEpo59dKFGU4sCQ.smethod_4(_4L7hfXrWoDdArQiscG4ukHCV46B).Load<Texture2D>(_k8LAl8bPyzLGEpo59dKFGU4sCQ.smethod_7(_k8LAl8bPyzLGEpo59dKFGU4sCQ.smethod_5(name), "/", _k8LAl8bPyzLGEpo59dKFGU4sCQ.smethod_6(name)));
		int count = _Al96gNPtV1ulU681NMxd1IeQxQq.Count;
		_Al96gNPtV1ulU681NMxd1IeQxQq.Add(name, count);
		_48Ia4uIlwwllIw0MIzPjdWOBDqx.Add(count, value);
		return count;
	}

	public void SetTexture(string name, object texture)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
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
		if (_k8LAl8bPyzLGEpo59dKFGU4sCQ.smethod_8(name, "default"))
		{
			name = _3qOVW0rru0fnFsK9qtJ6Gk1F0bE;
		}
		if (!_ludG33HqMIBuda5aoAUm6woMHdh.TryGetValue(name, out _SfJPevkmlfWx0UJQBD7GNI1bOPA))
		{
			SpriteFont value = _k8LAl8bPyzLGEpo59dKFGU4sCQ.smethod_4(_4L7hfXrWoDdArQiscG4ukHCV46B).Load<SpriteFont>(name);
			int count = _ludG33HqMIBuda5aoAUm6woMHdh.Count;
			_ludG33HqMIBuda5aoAUm6woMHdh.Add(name, count);
			_Ks5fhSCbnJp6pmRDanq4sn9DlRF.Add(count, value);
			return count;
		}
		return _SfJPevkmlfWx0UJQBD7GNI1bOPA;
	}

	public Point GetTextSize(string text, int font)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		if (_k8LAl8bPyzLGEpo59dKFGU4sCQ.smethod_9(text))
		{
			return Point.Zero;
		}
		if (_Ks5fhSCbnJp6pmRDanq4sn9DlRF.TryGetValue(font, out _YWublsgGSMYGc5V0KPieIYbXfdl))
		{
			Vector2 val = _k8LAl8bPyzLGEpo59dKFGU4sCQ.smethod_10(_YWublsgGSMYGc5V0KPieIYbXfdl, text);
			return new Point((int)val.X, (int)val.Y);
		}
		return Point.Zero;
	}

	public Point GetTextureSize(int texture)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (_48Ia4uIlwwllIw0MIzPjdWOBDqx.TryGetValue(texture, out _lruDd2bffYslbTUZZOo7HsfbTFA))
		{
			return new Point(_k8LAl8bPyzLGEpo59dKFGU4sCQ.smethod_11(_lruDd2bffYslbTUZZOo7HsfbTFA), _k8LAl8bPyzLGEpo59dKFGU4sCQ.smethod_12(_lruDd2bffYslbTUZZOo7HsfbTFA));
		}
		return Point.Zero;
	}

	public void DrawBox(int x, int y, int w, int h, int color)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		_OaIpAM8LUMZnUHberg4zeLNyWCd.Draw(_5YcBaRKou3OVWCywHF9K49yk2u9, new Rectangle(x, y, w, h), _TmKnNO76rW7a4nj5ivlAGl4rlrd(color));
	}

	public void DrawText(string text, int x, int y, int font, int color)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		if (_Ks5fhSCbnJp6pmRDanq4sn9DlRF.TryGetValue(font, out _YWublsgGSMYGc5V0KPieIYbXfdl))
		{
			_OaIpAM8LUMZnUHberg4zeLNyWCd._FY70IFLoBond3ORPe0ndCLvIeVcA(_YWublsgGSMYGc5V0KPieIYbXfdl, text, new Vector2((float)x, (float)y), _TmKnNO76rW7a4nj5ivlAGl4rlrd(color));
		}
	}

	public void DrawTexture(int texture, int x, int y, int w, int h, Rectangle rect, int color)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (_48Ia4uIlwwllIw0MIzPjdWOBDqx.TryGetValue(texture, out _lruDd2bffYslbTUZZOo7HsfbTFA))
		{
			_OaIpAM8LUMZnUHberg4zeLNyWCd.Draw(_lruDd2bffYslbTUZZOo7HsfbTFA, new Rectangle(x, y, w, h), (Rectangle?)new Rectangle(((Rectangle)(ref rect)).get_Left(), ((Rectangle)(ref rect)).get_Top(), ((Rectangle)(ref rect)).get_Width(), ((Rectangle)(ref rect)).get_Height()), _TmKnNO76rW7a4nj5ivlAGl4rlrd(color), 0f, Vector2.get_Zero(), (SpriteEffects)0, 0f);
		}
	}

	public void Scissor(int x, int y, int w, int h)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		_k8LAl8bPyzLGEpo59dKFGU4sCQ.smethod_0(_4L7hfXrWoDdArQiscG4ukHCV46B).set_ScissorRectangle(new Rectangle(x, y, w, h));
	}

	public void StartBatch()
	{
		_OaIpAM8LUMZnUHberg4zeLNyWCd._g9Sx54kMPiHz5jrqWh4Kb1pTijH((SpriteSortMode)0, null, null, null, _T3zdQhKBBD6DNUg8RQ7EupUHIoE);
	}

	public void EndBatch(bool final)
	{
		_k8LAl8bPyzLGEpo59dKFGU4sCQ.smethod_13(_OaIpAM8LUMZnUHberg4zeLNyWCd);
	}

	public void Dispose()
	{
	}

	static GraphicsDevice smethod_0(Game game_0)
	{
		return game_0.get_GraphicsDevice();
	}

	static SpriteBatch smethod_1(GraphicsDevice graphicsDevice_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new SpriteBatch(graphicsDevice_0);
	}

	static Texture2D smethod_2(GraphicsDevice graphicsDevice_0, int int_0, int int_1)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return new Texture2D(graphicsDevice_0, int_0, int_1);
	}

	static byte[] smethod_3(int int_0)
	{
		return BitConverter.GetBytes(int_0);
	}

	static ContentManager smethod_4(Game game_0)
	{
		return game_0.get_Content();
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return spriteFont_0.MeasureString(string_0);
	}

	static int smethod_11(Texture2D texture2D_0)
	{
		return texture2D_0.get_Width();
	}

	static int smethod_12(Texture2D texture2D_0)
	{
		return texture2D_0.get_Height();
	}

	static void smethod_13(SpriteBatch spriteBatch_0)
	{
		spriteBatch_0.End();
	}
}
