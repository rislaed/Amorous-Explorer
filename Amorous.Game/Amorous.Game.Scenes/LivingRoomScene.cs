using Microsoft.Xna.Framework;

namespace Amorous.Game.Scenes;

public class LivingRoomScene : TimeOfDayScene
{
	private readonly _dvyBDFOZwoBLf9qqHSfHYLLXVwP _phoneNag;

	public LivingRoomScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Background", "Assets/Scenes/LivingRoom/Foyer", 0, 0);
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/DanMasterFlash - Sun Funk", 0.4f);
		_phoneNag = new _dvyBDFOZwoBLf9qqHSfHYLLXVwP(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0);
	}

	public override void Update(GameTime gameTime)
	{
		_tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime);
		_phoneNag._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime);
	}

	public override void End()
	{
		base._tO46aYSBLFIuhFNlhbrAeWbFDSf();
		_phoneNag._tO46aYSBLFIuhFNlhbrAeWbFDSf();
	}
}
