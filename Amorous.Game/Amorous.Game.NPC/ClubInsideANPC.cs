namespace Amorous.Game.NPC;

public class ClubInsideANPC : ClubStaticNPC
{
	public ClubInsideANPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "Assets/NPC/ClubInsideStatic", "A", bool_0: true, bool_1: true)
	{
		while (true)
		{
			int num = -375696323;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAB69E302u) % 4u)
				{
				case 3u:
					ClubInsideANPC.smethod_19((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 0.58f);
					num = ((int)num2 * -2029357660) ^ -1133127221;
					continue;
				case 1u:
					_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
					_upl1k7yzBzlU7vErvbydGmXROfA = true;
					num = (int)(num2 * 1300334996) ^ -750089840;
					continue;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	static void smethod_19(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._fO7gSlrDDNMoHR4FO5QXAq8fUyA = float_0;
	}
}
