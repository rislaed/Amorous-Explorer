namespace Amorous.Game.Scenes;

public class BarScene : _7UlnfykmEmZDFt3BmCKZekI43Ih
{
	public BarScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		while (true)
		{
			int num = -1902470623;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC7321EE0u) % 4u)
				{
				case 2u:
					BarScene.smethod_15("Assets/Music/Steampianist - O Morro Nao Tem Vez", 0.4f);
					num = ((int)num2 * -1854587777) ^ -754671459;
					continue;
				case 1u:
					BarScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Bar/Background", 0, 0);
					num = ((int)num2 * -392173669) ^ -1559606607;
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

	static _uqydQVaCmCvK7zzWs5W4gZFpKBu smethod_14(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._0O8D0mBgmrh0sLOGcLVvGNOHKLCA(string_0, string_1, int_0, int_1);
	}

	static void smethod_15(string string_0, float float_0)
	{
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc(string_0, float_0);
	}
}
