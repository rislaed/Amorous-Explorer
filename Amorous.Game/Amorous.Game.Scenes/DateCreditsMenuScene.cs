using System;

namespace Amorous.Game.Scenes;

public class DateCreditsMenuScene : CreditsMenuScene
{
	public DateCreditsMenuScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		base._t76cjDKppsRdw5nUq3tnNw3ypAv = DateCreditsMenuScene.smethod_32(typeof(ClubInsideScene).TypeHandle);
		base._ICAb9QUE8hnbl0uKD8fBpEB1kSV = "Press Escape or Left-click here to return to the club.";
		_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = false;
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
