using System;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Amorous.Game.NPC;

public class SkyeBlueNPC : SkyeNPC
{
	public SkyeBlueNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		while (true)
		{
			int num = 174735410;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1A5CC658u) % 3u)
				{
				case 1u:
					goto IL_0009;
				case 0u:
					break;
				default:
					SkyeBlueNPC.smethod_36((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, new Type[2]
					{
						SkyeBlueNPC.smethod_35(typeof(SkyeNPC).TypeHandle),
						SkyeBlueNPC.smethod_35(typeof(SkyeGrayNPC).TypeHandle)
					});
					return;
				}
				break;
				IL_0009:
				SkyeBlueNPC.smethod_34((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this, SkyeBlueNPC.smethod_33(SkyeBlueNPC.smethod_32((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this)).Load<Texture2D>(_003CModule_003E.smethod_25<string>(4152933763u)));
				num = ((int)num2 * -1767596527) ^ -175482426;
			}
		}
	}

	static _JbeCmOie0phb2cbgG6DdGZrbs3pB smethod_32(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0)
	{
		return _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._ZzBuoSDMWwerejOO9Goyv2OCKgE;
	}

	static ContentManager smethod_33(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8;
	}

	static void smethod_34(_tfDAeR6npiqJMLRSXPO1DxGA0TgA _tfDAeR6npiqJMLRSXPO1DxGA0TgA_0, Texture2D texture2D_0)
	{
		_tfDAeR6npiqJMLRSXPO1DxGA0TgA_0._1AqpgY4vB6ly5vxOay6j86rcIEo = texture2D_0;
	}

	static Type smethod_35(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static void smethod_36(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, Type[] type_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._rAt6TRbgK04lvrs5QPjcd0n26pk = type_0;
	}
}
