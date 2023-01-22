using Microsoft.Xna.Framework;

namespace Amorous.Game.Scenes;

public class LivingRoomScene : TimeOfDayScene
{
	private readonly _dvyBDFOZwoBLf9qqHSfHYLLXVwP _phoneNag;

	public LivingRoomScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		LivingRoomScene.smethod_18((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, _003CModule_003E.smethod_24<string>(1416131465u), _003CModule_003E.smethod_27<string>(3816398155u), 0, 0);
		LivingRoomScene.smethod_19(_003CModule_003E.smethod_28<string>(1133475419u), 0.4f);
		_phoneNag = new _dvyBDFOZwoBLf9qqHSfHYLLXVwP(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0);
	}

	public override void Update(GameTime gameTime)
	{
		_tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime);
		while (true)
		{
			int num = 1813602651;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1E68F367u) % 3u)
				{
				case 1u:
					goto IL_0009;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0009:
				_phoneNag._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime);
				num = (int)((num2 * 2139518781) ^ 0x4CCCA19F);
			}
		}
	}

	public override void End()
	{
		this.method_3();
		while (true)
		{
			int num = 885460122;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6FCC987Eu) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0008:
				_phoneNag._tO46aYSBLFIuhFNlhbrAeWbFDSf();
				num = (int)(num2 * 349949570) ^ -1942601087;
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

	void method_3()
	{
		base._tO46aYSBLFIuhFNlhbrAeWbFDSf();
	}
}
