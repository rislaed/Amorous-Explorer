namespace Amorous.Game.NPC;

public class ClubPoolStaticQRNPC : ClubStaticNPC
{
	public ClubPoolStaticQRNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "Assets/NPC/ClubPoolStatic", "Q R", bool_0: false, bool_1: true)
	{
		while (true)
		{
			int num = 70101718;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x63D58CD0u) % 3u)
				{
				case 2u:
					goto IL_0017;
				case 0u:
					break;
				default:
					_upl1k7yzBzlU7vErvbydGmXROfA = true;
					return;
				}
				break;
				IL_0017:
				_J4giDjnRtYmiHMmzwRZ0ThvfAhH = true;
				num = ((int)num2 * -1711928719) ^ -1636403313;
			}
		}
	}
}
