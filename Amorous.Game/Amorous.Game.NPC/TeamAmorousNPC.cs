using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class TeamAmorousNPC : LayerNPC<TeamAmorousNPC.EHeads, TeamAmorousNPC.EPoses, TeamAmorousNPC.EClothes>
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

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = _003CModule_003E.smethod_28<string>(1017383289u);

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA;

	public TeamAmorousNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, string.Empty, 1f)
	{
	}

	static TeamAmorousNPC()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			int num = 847453659;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7A366DDu) % 3u)
				{
				case 1u:
					goto IL_0011;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0011:
				_9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(255, 160, 255);
				num = (int)(num2 * 2003280673) ^ -691940293;
			}
		}
	}
}
