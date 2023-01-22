namespace Amorous.Game.NPC;

public class ClubPoolStaticMNPC : ClubStaticNPC
{
	public ClubPoolStaticMNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, _003CModule_003E.smethod_26<string>(1629315143u), _003CModule_003E.smethod_25<string>(459513834u), bool_0: false, bool_1: true)
	{
		while (true)
		{
			int num = 1676481287;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4849E412u) % 4u)
				{
				case 2u:
					_upl1k7yzBzlU7vErvbydGmXROfA = true;
					num = (int)(num2 * 1448411847) ^ -32127077;
					continue;
				case 1u:
					_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
					num = (int)(num2 * 44023716) ^ -1375308052;
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
}
