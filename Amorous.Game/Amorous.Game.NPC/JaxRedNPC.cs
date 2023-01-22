using System;

namespace Amorous.Game.NPC;

public class JaxRedNPC : JaxNPC
{
	public JaxRedNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "Assets/NPC/JaxRed/Jax")
	{
		JaxRedNPC.smethod_33((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, new Type[2]
		{
			JaxRedNPC.smethod_32(typeof(JaxNPC).TypeHandle),
			JaxRedNPC.smethod_32(typeof(JaxPurpleNPC).TypeHandle)
		});
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
