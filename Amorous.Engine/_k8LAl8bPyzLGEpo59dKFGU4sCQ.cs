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

	private readonly string _3qOVW0rru0fnFsK9qtJ6Gk1F0bE = _003CModule_003E.smethod_27<string>(4086085158u);

	private int _SfJPevkmlfWx0UJQBD7GNI1bOPA;

	private SpriteFont _YWublsgGSMYGc5V0KPieIYbXfdl;

	private Texture2D _lruDd2bffYslbTUZZOo7HsfbTFA;

	public _k8LAl8bPyzLGEpo59dKFGU4sCQ(Game game_0)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		while (true)
		{
			int num = -1142689067;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x88D4D264u) % 8u)
				{
				case 7u:
				{
					_5YcBaRKou3OVWCywHF9K49yk2u9.SetData<Color>((Color[])(object)new Color[1]
					{
						new Color(255, 255, 255, 255)
					});
					RasterizerState val = new RasterizerState();
					val.set_ScissorTestEnable(true);
					_T3zdQhKBBD6DNUg8RQ7EupUHIoE = val;
					num = (int)(num2 * 1230093176) ^ -520824680;
					continue;
				}
				case 4u:
					_Al96gNPtV1ulU681NMxd1IeQxQq.Add(string.Empty, 0);
					num = (int)((num2 * 1661841796) ^ 0x7D19A0E7);
					continue;
				case 3u:
					_48Ia4uIlwwllIw0MIzPjdWOBDqx.Add(0, _5YcBaRKou3OVWCywHF9K49yk2u9);
					num = ((int)num2 * -177394561) ^ -1930266060;
					continue;
				case 2u:
					_OaIpAM8LUMZnUHberg4zeLNyWCd = _k8LAl8bPyzLGEpo59dKFGU4sCQ.smethod_1(_k8LAl8bPyzLGEpo59dKFGU4sCQ.smethod_0(game_0));
					num = ((int)num2 * -154605321) ^ -796087950;
					continue;
				case 1u:
					_4L7hfXrWoDdArQiscG4ukHCV46B = game_0;
					num = ((int)num2 * -1340901696) ^ 0x783DF83E;
					continue;
				case 0u:
					_5YcBaRKou3OVWCywHF9K49yk2u9 = _k8LAl8bPyzLGEpo59dKFGU4sCQ.smethod_2(_k8LAl8bPyzLGEpo59dKFGU4sCQ.smethod_0(_4L7hfXrWoDdArQiscG4ukHCV46B), 1, 1);
					num = ((int)num2 * -475116872) ^ -673533933;
					continue;
				default:
					return;
				case 6u:
					break;
				case 5u:
					return;
				}
				break;
			}
		}
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
			goto IL_0075;
		}
		goto IL_00a7;
		IL_0075:
		int num = -1889344637;
		goto IL_007a;
		IL_007a:
		int count = default(int);
		Texture2D value = default(Texture2D);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xFFA4D1EDu) % 7u)
			{
			case 5u:
				_Al96gNPtV1ulU681NMxd1IeQxQq.Add(name, count);
				num = ((int)num2 * -1393212663) ^ -1867121848;
				continue;
			case 4u:
				count = _Al96gNPtV1ulU681NMxd1IeQxQq.Count;
				num = (int)(num2 * 2044598477) ^ -224353287;
				continue;
			case 1u:
				_48Ia4uIlwwllIw0MIzPjdWOBDqx.Add(count, value);
				num = ((int)num2 * -343835074) ^ 0x295AF867;
				continue;
			case 0u:
				break;
			case 3u:
				goto IL_00a7;
			default:
				return count;
			case 6u:
				return _SfJPevkmlfWx0UJQBD7GNI1bOPA;
			}
			break;
		}
		goto IL_0075;
		IL_00a7:
		value = _k8LAl8bPyzLGEpo59dKFGU4sCQ.smethod_4(_4L7hfXrWoDdArQiscG4ukHCV46B).Load<Texture2D>(_k8LAl8bPyzLGEpo59dKFGU4sCQ.smethod_7(_k8LAl8bPyzLGEpo59dKFGU4sCQ.smethod_5(name), _003CModule_003E.smethod_27<string>(2954346559u), _k8LAl8bPyzLGEpo59dKFGU4sCQ.smethod_6(name)));
		num = -2028055299;
		goto IL_007a;
	}

	public void SetTexture(string name, object texture)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		if (_Al96gNPtV1ulU681NMxd1IeQxQq.TryGetValue(name, out _SfJPevkmlfWx0UJQBD7GNI1bOPA))
		{
			goto IL_0047;
		}
		goto IL_009b;
		IL_009b:
		int count = _Al96gNPtV1ulU681NMxd1IeQxQq.Count;
		int num = -1182125039;
		goto IL_0072;
		IL_0072:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xE2053070u) % 6u)
			{
			case 5u:
				_Al96gNPtV1ulU681NMxd1IeQxQq.Add(name, count);
				_48Ia4uIlwwllIw0MIzPjdWOBDqx.Add(count, (Texture2D)texture);
				num = ((int)num2 * -139575084) ^ -1683627176;
				continue;
			case 3u:
				break;
			case 2u:
				_48Ia4uIlwwllIw0MIzPjdWOBDqx[_SfJPevkmlfWx0UJQBD7GNI1bOPA] = (Texture2D)texture;
				num = ((int)num2 * -1327941972) ^ 0x317C2CA5;
				continue;
			default:
				return;
			case 0u:
				goto IL_009b;
			case 1u:
				return;
			case 4u:
				return;
			}
			break;
		}
		goto IL_0047;
		IL_0047:
		num = -1898270668;
		goto IL_0072;
	}

	public int GetFont(string name)
	{
		if (_k8LAl8bPyzLGEpo59dKFGU4sCQ.smethod_8(name, _003CModule_003E.smethod_27<string>(4057888257u)))
		{
			goto IL_004c;
		}
		goto IL_00bd;
		IL_00bd:
		int num;
		int num2;
		if (_ludG33HqMIBuda5aoAUm6woMHdh.TryGetValue(name, out _SfJPevkmlfWx0UJQBD7GNI1bOPA))
		{
			num = -1135542331;
			num2 = -1135542331;
		}
		else
		{
			num = -960486932;
			num2 = -960486932;
		}
		goto IL_0081;
		IL_0081:
		int count = default(int);
		SpriteFont value = default(SpriteFont);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0xA20B5DC8u) % 7u)
			{
			case 6u:
				count = _ludG33HqMIBuda5aoAUm6woMHdh.Count;
				_ludG33HqMIBuda5aoAUm6woMHdh.Add(name, count);
				num = ((int)num3 * -467158512) ^ -1835790372;
				continue;
			case 3u:
				break;
			case 2u:
				value = _k8LAl8bPyzLGEpo59dKFGU4sCQ.smethod_4(_4L7hfXrWoDdArQiscG4ukHCV46B).Load<SpriteFont>(name);
				num = -236889666;
				continue;
			case 1u:
				name = _3qOVW0rru0fnFsK9qtJ6Gk1F0bE;
				num = (int)(num3 * 1564583496) ^ -1417693182;
				continue;
			case 0u:
				goto IL_00bd;
			default:
				_Ks5fhSCbnJp6pmRDanq4sn9DlRF.Add(count, value);
				return count;
			case 5u:
				return _SfJPevkmlfWx0UJQBD7GNI1bOPA;
			}
			break;
		}
		goto IL_004c;
		IL_004c:
		num = -705253990;
		goto IL_0081;
	}

	public Point GetTextSize(string text, int font)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		if (_k8LAl8bPyzLGEpo59dKFGU4sCQ.smethod_9(text))
		{
			goto IL_0017;
		}
		goto IL_004b;
		IL_004b:
		int num;
		int num2;
		if (!_Ks5fhSCbnJp6pmRDanq4sn9DlRF.TryGetValue(font, out _YWublsgGSMYGc5V0KPieIYbXfdl))
		{
			num = -192276159;
			num2 = -192276159;
		}
		else
		{
			num = -950021684;
			num2 = -950021684;
		}
		goto IL_001c;
		IL_001c:
		switch ((uint)(num ^ -1679735997) % 5u)
		{
		case 2u:
			break;
		case 3u:
			goto IL_004b;
		case 0u:
			return Point.Zero;
		default:
		{
			Vector2 val = _k8LAl8bPyzLGEpo59dKFGU4sCQ.smethod_10(_YWublsgGSMYGc5V0KPieIYbXfdl, text);
			return new Point((int)val.X, (int)val.Y);
		}
		case 4u:
			return Point.Zero;
		}
		goto IL_0017;
		IL_0017:
		num = -593904789;
		goto IL_001c;
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
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (!_Ks5fhSCbnJp6pmRDanq4sn9DlRF.TryGetValue(font, out _YWublsgGSMYGc5V0KPieIYbXfdl))
		{
			return;
		}
		while (true)
		{
			int num = 6407517;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x24E1FD48u) % 3u)
				{
				case 1u:
					goto IL_0017;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0017:
				_OaIpAM8LUMZnUHberg4zeLNyWCd._FY70IFLoBond3ORPe0ndCLvIeVcA(_YWublsgGSMYGc5V0KPieIYbXfdl, text, new Vector2((float)x, (float)y), _TmKnNO76rW7a4nj5ivlAGl4rlrd(color));
				num = ((int)num2 * -1567693409) ^ -140931720;
			}
		}
	}

	public void DrawTexture(int texture, int x, int y, int w, int h, Rectangle rect, int color)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if (!_48Ia4uIlwwllIw0MIzPjdWOBDqx.TryGetValue(texture, out _lruDd2bffYslbTUZZOo7HsfbTFA))
		{
			return;
		}
		while (true)
		{
			int num = -818339543;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF5D86B75u) % 3u)
				{
				case 2u:
					goto IL_001c;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_001c:
				_OaIpAM8LUMZnUHberg4zeLNyWCd.Draw(_lruDd2bffYslbTUZZOo7HsfbTFA, new Rectangle(x, y, w, h), (Rectangle?)new Rectangle(((Rectangle)(ref rect)).get_Left(), ((Rectangle)(ref rect)).get_Top(), ((Rectangle)(ref rect)).get_Width(), ((Rectangle)(ref rect)).get_Height()), _TmKnNO76rW7a4nj5ivlAGl4rlrd(color), 0f, Vector2.get_Zero(), (SpriteEffects)0, 0f);
				num = ((int)num2 * -1942296904) ^ 0x4B7DCD9F;
			}
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
