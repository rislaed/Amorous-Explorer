using Microsoft.Xna.Framework;

namespace Amorous.Game.Scenes;

public class LivingRoomScene : TimeOfDayScene
{
	private readonly _dvyBDFOZwoBLf9qqHSfHYLLXVwP _phoneNag;

	public LivingRoomScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		LivingRoomScene.smethod_18((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/LivingRoom/Foyer", 0, 0);
		LivingRoomScene.smethod_19("Assets/Music/DanMasterFlash - Sun Funk", 0.4f);
		_phoneNag = new _dvyBDFOZwoBLf9qqHSfHYLLXVwP(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0);
	}

	public override void Update(GameTime gameTime)
	{
		_tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime);
		_phoneNag._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime);
	}

	public override void End()
	{
		this.method_3();
		_phoneNag._tO46aYSBLFIuhFNlhbrAeWbFDSf();
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
