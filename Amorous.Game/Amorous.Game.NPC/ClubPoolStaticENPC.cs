namespace Amorous.Game.NPC;

public class ClubPoolStaticENPC : ClubStaticSpineNPC
{
	private static readonly string[] _faT8q4ZAxVWFlC2DnvTQkGsQ8Dh = new string[8]
	{
		_003CModule_003E.smethod_27<string>(3071359793u),
		_003CModule_003E.smethod_28<string>(940678579u),
		_003CModule_003E.smethod_27<string>(686070685u),
		_003CModule_003E.smethod_24<string>(2064997538u),
		_003CModule_003E.smethod_28<string>(1598186517u),
		_003CModule_003E.smethod_26<string>(4205301225u),
		_003CModule_003E.smethod_26<string>(62008742u),
		_003CModule_003E.smethod_26<string>(314800097u)
	};

	public ClubPoolStaticENPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, _003CModule_003E.smethod_25<string>(2205391812u), _faT8q4ZAxVWFlC2DnvTQkGsQ8Dh)
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
					goto IL_001a;
				case 0u:
					break;
				default:
					_upl1k7yzBzlU7vErvbydGmXROfA = true;
					return;
				}
				break;
				IL_001a:
				_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
				num = ((int)num2 * -313419672) ^ -99949414;
			}
		}
	}
}
