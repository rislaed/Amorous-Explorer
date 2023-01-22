using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class DonnaNPC : LayerNPC<DonnaNPC.EHeads, DonnaNPC.EPoses, DonnaNPC.EClothes>
{
	public enum EHeads
	{
		None
	}

	public enum EPoses
	{
		None
	}

	public enum EClothes
	{
		None
	}

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = _003CModule_003E.smethod_27<string>(457308360u);

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA;

	public DonnaNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, string.Empty, 1f)
	{
	}

	static DonnaNPC()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			int num = 1153792622;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x10176B57u) % 3u)
				{
				case 2u:
					goto IL_0011;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0011:
				_9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(255, 0, 255);
				num = ((int)num2 * -578255629) ^ 0x18497CCD;
			}
		}
	}
}
