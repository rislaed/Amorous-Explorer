namespace Amorous.Game.NPC;

public class ClubEntranceDNPC : ClubStaticNPC
{
	public ClubEntranceDNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, _003CModule_003E.smethod_25<string>(3215207603u), _003CModule_003E.smethod_27<string>(2581279857u), bool_0: true, bool_1: true)
	{
		while (true)
		{
			int num = 1618417763;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7BEA4F53u) % 3u)
				{
				case 1u:
					goto IL_001f;
				case 0u:
					break;
				default:
					_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
					_upl1k7yzBzlU7vErvbydGmXROfA = true;
					return;
				}
				break;
				IL_001f:
				ClubEntranceDNPC.smethod_19((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 0.7f);
				num = ((int)num2 * -941753236) ^ 0x51E8B8F1;
			}
		}
	}

	static void smethod_19(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._fO7gSlrDDNMoHR4FO5QXAq8fUyA = float_0;
	}
}
