namespace Amorous.Game.Scenes;

public class ShootingRangeScene : _7UlnfykmEmZDFt3BmCKZekI43Ih
{
	public ShootingRangeScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		while (true)
		{
			int num = -182316520;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD1D5603Eu) % 4u)
				{
				case 2u:
					ShootingRangeScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Backdrop", "Assets/Scenes/ShootingRange/Backdrop", 600, 180);
					num = ((int)num2 * -670452763) ^ -1811638691;
					continue;
				case 1u:
					ShootingRangeScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/ShootingRange/Background", 0, 0);
					ShootingRangeScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Countertop", "Assets/Scenes/ShootingRange/Countertop", 0, 0);
					num = ((int)num2 * -1330432719) ^ 0xFED483F;
					continue;
				case 3u:
					break;
				default:
					ShootingRangeScene.smethod_15("Assets/Music/Mittsies - Mech", 0.4f);
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
