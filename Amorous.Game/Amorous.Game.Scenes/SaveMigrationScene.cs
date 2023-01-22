using Amorous.Game.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.Scenes;

public class SaveMigrationScene : _7UlnfykmEmZDFt3BmCKZekI43Ih
{
	private readonly string _BMUFdD4GwdBkg2lksa43USTpcIz;

	private readonly string _Z8BClcChRJrlB6tR1VPJcycVpHN;

	private bool _OvbescGEY3Lfk7RmD2smIoB5Es2A;

	public SaveMigrationScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, string string_0, string string_1)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		_BMUFdD4GwdBkg2lksa43USTpcIz = string_0;
		_Z8BClcChRJrlB6tR1VPJcycVpHN = string_1;
		_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Background", "Assets/Scenes/Intro/Background", 0, -540);
		_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Background", "Assets/Scenes/Intro/Scenery", 0, -170);
		_NC5VT77x8y2iH2pW56TBN1eyomA("Title", "Assets/Scenes/MainMenu/Logo", 616, 50);
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/Biggyzoom - The Night Sky", 0.4f);
	}

	public override void _4hlxzMzKSbVTbZUrEsP3dfw4x0h()
	{
		CoupleANPC coupleANPC = base._ZzBuoSDMWwerejOO9Goyv2OCKgE._TwQHHdbdRFRy2ctTZabNfz1Htrg<CoupleANPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
		coupleANPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = 350f;
		coupleANPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = 1090f;
		coupleANPC._tDFvus0ZCanjp81eOiDzoMXJiuf(CoupleANPC.EPoses.Waving);
		coupleANPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(CoupleANPC.EClothes.Shirt, CoupleANPC.EClothes.Pants);
		CoupleBNPC coupleBNPC = base._ZzBuoSDMWwerejOO9Goyv2OCKgE._TwQHHdbdRFRy2ctTZabNfz1Htrg<CoupleBNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
		coupleBNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = 550f;
		coupleBNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = 1090f;
		coupleBNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(CoupleBNPC.EPoses.Waving);
		coupleBNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(CoupleBNPC.EClothes.Shirt, CoupleBNPC.EClothes.Pants);
		if (_BMUFdD4GwdBkg2lksa43USTpcIz != null)
		{
			base._ZzBuoSDMWwerejOO9Goyv2OCKgE._xyl3Tv5KdR5eezDgagxbBcS3cwt(_BMUFdD4GwdBkg2lksa43USTpcIz);
		}
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		base._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
		if (!_OvbescGEY3Lfk7RmD2smIoB5Es2A && !base._ZzBuoSDMWwerejOO9Goyv2OCKgE._NdzU0m9x8QDKpVv3DrQmzY5KduB && base._ZzBuoSDMWwerejOO9Goyv2OCKgE._5zNdOw7qHmuCAPJFMr3SsZdBlCr == null)
		{
			_OvbescGEY3Lfk7RmD2smIoB5Es2A = true;
			base._ZzBuoSDMWwerejOO9Goyv2OCKgE._k9wUPeU1Ga7cygiuGP8TT6aPLWF(_Z8BClcChRJrlB6tR1VPJcycVpHN);
		}
	}
}
