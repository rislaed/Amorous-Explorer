using System;

namespace Amorous.Game.NPC;

public class JaxPurpleNPC : JaxNPC
{
	public JaxPurpleNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "Assets/NPC/JaxPurple/Jax")
	{
		while (true)
		{
			int num = -634081444;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAA805224u) % 3u)
				{
				case 2u:
					goto IL_000f;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_000f:
				JaxPurpleNPC.smethod_33((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, new Type[2]
				{
					JaxPurpleNPC.smethod_32(typeof(JaxNPC).TypeHandle),
					JaxPurpleNPC.smethod_32(typeof(JaxRedNPC).TypeHandle)
				});
				num = ((int)num2 * -124561187) ^ -1632186646;
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
