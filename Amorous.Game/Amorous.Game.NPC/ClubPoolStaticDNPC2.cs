namespace Amorous.Game.NPC;

public class ClubPoolStaticDNPC2 : ClubPoolStaticDNPC
{
	public ClubPoolStaticDNPC2(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		while (true)
		{
			int num = -20702181;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE2231582u) % 3u)
				{
				case 1u:
					goto IL_0009;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0009:
				base._vAix6GBEcVh3peB11tbKy7HJWwb = true;
				num = (int)(num2 * 1740313507) ^ -1962499397;
			}
		}
	}
}
