namespace Amorous.Game.Scenes;

public class CinemaLobbyScene : _7UlnfykmEmZDFt3BmCKZekI43Ih
{
	public CinemaLobbyScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		while (true)
		{
			int num = -1906607282;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE5E2A1F9u) % 4u)
				{
				case 3u:
					CinemaLobbyScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/CinemaLobby/Cinema Lobby", 0, 0);
					num = (int)((num2 * 1845167659) ^ 0x1C990618);
					continue;
				case 0u:
					CinemaLobbyScene.smethod_15("Assets/Music/DJ-ZEK - Simulate", 0.4f);
					num = (int)(num2 * 397138287) ^ -1562925592;
					continue;
				default:
					return;
				case 2u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	static _uqydQVaCmCvK7zzWs5W4gZFpKBu smethod_14(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._0O8D0mBgmrh0sLOGcLVvGNOHKLCA(string_0, string_1, int_0, int_1);
	}

	static void smethod_15(string string_0, float float_0)
	{
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc(string_0, float_0);
	}
}
