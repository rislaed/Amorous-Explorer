using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class PlaceholderNPC : LayerNPC<PlaceholderNPC.EHeads, PlaceholderNPC.EPoses, PlaceholderNPC.EClothes>
{
	public enum EHeads
	{
		None
	}

	public enum EPoses
	{
		None,
		Placeholder
	}

	public enum EClothes
	{
		None
	}

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = _003CModule_003E.smethod_28<string>(3855765331u);

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(255, 0, 255);

	public PlaceholderNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, _003CModule_003E.smethod_24<string>(3665113056u), 1f)
	{
		while (true)
		{
			int num = 347790485;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7D81297Du) % 3u)
				{
				case 2u:
					goto IL_0018;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0018:
				_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Placeholder, _003CModule_003E.smethod_26<string>(1642587329u));
				num = (int)((num2 * 1994266627) ^ 0x752C2595);
			}
		}
	}

	public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation npclocation_0)
	{
		this.method_0(npclocation_0);
		while (true)
		{
			int num = 1883058832;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x622A67B1u) % 10u)
				{
				case 9u:
					switch (npclocation_0)
					{
					case NPCLocation.Middle:
						goto IL_002f;
					case NPCLocation.Left:
						goto IL_0048;
					case NPCLocation.Right:
						goto IL_0061;
					}
					num = (int)(num2 * 1930393260) ^ -541077554;
					continue;
				case 4u:
					goto IL_002f;
				case 6u:
					goto IL_0048;
				case 7u:
					goto IL_0061;
				case 2u:
					PlaceholderNPC.smethod_17((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1270f);
					PlaceholderNPC.smethod_18((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 100f);
					num = (int)(num2 * 76751256) ^ -1654964105;
					continue;
				case 0u:
					break;
				case 1u:
					return;
				case 3u:
					PlaceholderNPC.smethod_18((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 100f);
					return;
				default:
					PlaceholderNPC.smethod_18((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 100f);
					return;
				case 8u:
					return;
					IL_0061:
					PlaceholderNPC.smethod_16((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
					num = 256560725;
					continue;
					IL_0048:
					PlaceholderNPC.smethod_16((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: true);
					PlaceholderNPC.smethod_17((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 100f);
					num = 79678250;
					continue;
					IL_002f:
					PlaceholderNPC.smethod_16((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
					PlaceholderNPC.smethod_17((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 685f);
					num = 1948097104;
					continue;
				}
				break;
			}
		}
	}

	void method_0(NPCLocation npclocation_0)
	{
		base._nGGBtYpZ8pI1BmE2c2ke63UjGDP(npclocation_0);
	}

	static void smethod_16(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, bool bool_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = bool_0;
	}

	static void smethod_17(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_18(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}
}
