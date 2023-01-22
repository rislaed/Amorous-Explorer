using System;

namespace Amorous.Game.Scenes;

public class DateCreditsMenuScene : CreditsMenuScene
{
	public DateCreditsMenuScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		while (true)
		{
			int num = 662167288;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6B93335Eu) % 4u)
				{
				case 3u:
					base._ICAb9QUE8hnbl0uKD8fBpEB1kSV = "Press Escape or Left-click here to return to the club.";
					_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = false;
					num = (int)((num2 * 557759589) ^ 0x52C7EC8);
					continue;
				case 2u:
					base._t76cjDKppsRdw5nUq3tnNw3ypAv = DateCreditsMenuScene.smethod_32(typeof(ClubInsideScene).TypeHandle);
					num = ((int)num2 * -668069509) ^ -1072492245;
					continue;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public override void _tO46aYSBLFIuhFNlhbrAeWbFDSf()
	{
		this.method_1();
		_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = true;
	}

	static Type smethod_32(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	void method_1()
	{
		base._tO46aYSBLFIuhFNlhbrAeWbFDSf();
	}
}
