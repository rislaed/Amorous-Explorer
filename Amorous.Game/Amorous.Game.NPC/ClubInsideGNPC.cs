namespace Amorous.Game.NPC;

public class ClubInsideGNPC : ClubStaticNPC
{
	public ClubInsideGNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "Assets/NPC/ClubInsideStatic", "G", bool_0: true, bool_1: true)
	{
		while (true)
		{
			int num = -35970543;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD74F7E1Fu) % 3u)
				{
				case 2u:
					goto IL_0017;
				case 0u:
					break;
				default:
					_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
					_upl1k7yzBzlU7vErvbydGmXROfA = true;
					return;
				}
				break;
				IL_0017:
				ClubInsideGNPC.smethod_19((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 0.37f);
				num = ((int)num2 * -106802551) ^ -1270597382;
			}
		}
	}

	static void smethod_19(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._fO7gSlrDDNMoHR4FO5QXAq8fUyA = float_0;
	}
}
