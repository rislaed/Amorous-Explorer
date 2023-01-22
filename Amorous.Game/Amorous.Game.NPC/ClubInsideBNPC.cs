namespace Amorous.Game.NPC;

public class ClubInsideBNPC : ClubStaticNPC
{
	public ClubInsideBNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, _003CModule_003E.smethod_25<string>(2140821155u), _003CModule_003E.smethod_27<string>(1455554502u), bool_0: true, bool_1: true)
	{
		while (true)
		{
			int num = 1861607053;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6B407DE4u) % 4u)
				{
				case 2u:
					_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
					_upl1k7yzBzlU7vErvbydGmXROfA = true;
					num = (int)((num2 * 1233645006) ^ 0x4426FB47);
					continue;
				case 1u:
					ClubInsideBNPC.smethod_19((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 0.42f);
					num = (int)((num2 * 765345357) ^ 0x5D4457AF);
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

	static void smethod_19(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._fO7gSlrDDNMoHR4FO5QXAq8fUyA = float_0;
	}
}
