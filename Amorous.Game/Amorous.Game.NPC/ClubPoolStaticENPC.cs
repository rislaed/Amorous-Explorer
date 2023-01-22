namespace Amorous.Game.NPC;

public class ClubPoolStaticENPC : ClubStaticSpineNPC
{
	private static readonly string[] _faT8q4ZAxVWFlC2DnvTQkGsQ8Dh = new string[8] { "Bar cover", "Chest", "Forearm back", "Forearm front", "Head", "Shaker", "Shoulder back", "Shoulder front" };

	public ClubPoolStaticENPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "Assets/NPC/ClubPoolStatic/E club", _faT8q4ZAxVWFlC2DnvTQkGsQ8Dh)
	{
		while (true)
		{
			int num = 608207027;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x62ABDDF9u) % 3u)
				{
				case 1u:
					goto IL_0016;
				case 0u:
					break;
				default:
					_upl1k7yzBzlU7vErvbydGmXROfA = true;
					return;
				}
				break;
				IL_0016:
				_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
				num = ((int)num2 * -313419672) ^ -99949414;
			}
		}
	}
}
