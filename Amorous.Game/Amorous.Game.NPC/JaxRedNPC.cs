using System;

namespace Amorous.Game.NPC;

public class JaxRedNPC : JaxNPC
{
	public JaxRedNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, _003CModule_003E.smethod_25<string>(2432840745u))
	{
		while (true)
		{
			int num = 1396380790;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x18688134u) % 3u)
				{
				case 1u:
					goto IL_0013;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0013:
				JaxRedNPC.smethod_33((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, new Type[2]
				{
					JaxRedNPC.smethod_32(typeof(JaxNPC).TypeHandle),
					JaxRedNPC.smethod_32(typeof(JaxPurpleNPC).TypeHandle)
				});
				num = ((int)num2 * -1181421897) ^ -133307786;
			}
		}
	}

	static Type smethod_32(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static void smethod_33(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, Type[] type_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._rAt6TRbgK04lvrs5QPjcd0n26pk = type_0;
	}
}
