namespace Amorous.Game.Scenes;

public class JaxApartmentScene : TimeOfDayScene
{
	public JaxApartmentScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		while (true)
		{
			int num = 285740870;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1EF7C8D6u) % 3u)
				{
				case 1u:
					goto IL_0009;
				case 0u:
					break;
				default:
					JaxApartmentScene.smethod_19("Assets/Music/DanMasterFlash - Sun Funk", 0.4f);
					return;
				}
				break;
				IL_0009:
				JaxApartmentScene.smethod_18((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/JaxApartment/jax background apartment", 0, 0);
				num = (int)((num2 * 430504250) ^ 0x18698391);
			}
		}
	}

	static _uqydQVaCmCvK7zzWs5W4gZFpKBu smethod_18(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._0O8D0mBgmrh0sLOGcLVvGNOHKLCA(string_0, string_1, int_0, int_1);
	}

	static void smethod_19(string string_0, float float_0)
	{
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc(string_0, float_0);
	}
}
