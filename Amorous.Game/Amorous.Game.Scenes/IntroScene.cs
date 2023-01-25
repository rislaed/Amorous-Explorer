using System;
using Amorous.Game.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.Scenes;

public class IntroScene : AbstractScene
{
	private int _Q7Kx7ErHf3u1QIUDKfFCKSXbznG;

	private readonly float _PbBEddQtI9iZg1ocIlBafUuVdrO;

	public _ujAkjlfN5TywwbLAUDzPvtab6uJ _h29gtnqEWLAa5qsliRXuXiPwY2o { get; private set; }

	public _ujAkjlfN5TywwbLAUDzPvtab6uJ _agB6DEyENfHFg1x2I4KsJqoQUpg { get; private set; }

	public CoupleANPC _4BkRUyoqu3iKk7SRvIVoP35EcKA { get; private set; }

	public CoupleBNPC _ZCUbMPsnW0SgjlADsYyZVasibXM { get; private set; }

	public IntroScene(IAmorous game)
		: base(Game)
	{
		_h29gtnqEWLAa5qsliRXuXiPwY2o = _0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Background", "Assets/Scenes/Intro/Background", 0, 0);
		_agB6DEyENfHFg1x2I4KsJqoQUpg = _0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Scenery", "Assets/Scenes/Intro/Scenery", 0, 1250);
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/Biggyzoom - The Night Sky", 0.4f);
		_PbBEddQtI9iZg1ocIlBafUuVdrO = 1f;
	}

	public override void _4hlxzMzKSbVTbZUrEsP3dfw4x0h()
	{
		_ZCUbMPsnW0SgjlADsYyZVasibXM = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<CoupleBNPC>(LayerOrder.Foreground);
		_ZCUbMPsnW0SgjlADsYyZVasibXM._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 1280f;
		_ZCUbMPsnW0SgjlADsYyZVasibXM._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 1090f;
		_ZCUbMPsnW0SgjlADsYyZVasibXM._tDFvus0ZCanjp81eOiDzoMXJiuf(CoupleBNPC.EPoses.Waving);
		_ZCUbMPsnW0SgjlADsYyZVasibXM._09vxUzgOn7J7DFZEwsTh7lgEIhB(CoupleBNPC.EClothes.Shirt, CoupleBNPC.EClothes.Pants);
		_4BkRUyoqu3iKk7SRvIVoP35EcKA = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<CoupleANPC>(LayerOrder.Foreground);
		_4BkRUyoqu3iKk7SRvIVoP35EcKA._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = -800f;
		_4BkRUyoqu3iKk7SRvIVoP35EcKA._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 1090f;
		_4BkRUyoqu3iKk7SRvIVoP35EcKA._tDFvus0ZCanjp81eOiDzoMXJiuf(CoupleANPC.EPoses.Waving);
		_4BkRUyoqu3iKk7SRvIVoP35EcKA._09vxUzgOn7J7DFZEwsTh7lgEIhB(CoupleANPC.EClothes.Shirt, CoupleANPC.EClothes.Pants);
	}

	public override void Update(GameTime gameTime_0)
	{
		base.Update(gameTime_0);
		_Q7Kx7ErHf3u1QIUDKfFCKSXbznG += gameTime_0.ElapsedGameTime.Milliseconds;
		_EZKvqbHbBzrIsmIefNbwSVvgrP5A(_h29gtnqEWLAa5qsliRXuXiPwY2o, 0f, 18000f * _PbBEddQtI9iZg1ocIlBafUuVdrO, 0, 0, 0, -540);
		_EZKvqbHbBzrIsmIefNbwSVvgrP5A(_agB6DEyENfHFg1x2I4KsJqoQUpg, 10000f * _PbBEddQtI9iZg1ocIlBafUuVdrO, 8000f * _PbBEddQtI9iZg1ocIlBafUuVdrO, 0, 1250, 0, -170);
		_nuSr558RHFkx9d2QBs2DeGUB1wX(_4BkRUyoqu3iKk7SRvIVoP35EcKA, 14000f * _PbBEddQtI9iZg1ocIlBafUuVdrO, 4000f * _PbBEddQtI9iZg1ocIlBafUuVdrO, -800, 1090, 600, 1090);
		_nuSr558RHFkx9d2QBs2DeGUB1wX(_ZCUbMPsnW0SgjlADsYyZVasibXM, 14000f * _PbBEddQtI9iZg1ocIlBafUuVdrO, 4000f * _PbBEddQtI9iZg1ocIlBafUuVdrO, 1280, 1090, 450, 1090);
	}

	private void _EZKvqbHbBzrIsmIefNbwSVvgrP5A(_ujAkjlfN5TywwbLAUDzPvtab6uJ _ujAkjlfN5TywwbLAUDzPvtab6uJ_0, float float_0, float float_1, int int_0, int int_1, int int_2, int int_3)
	{
		if (!((float)_Q7Kx7ErHf3u1QIUDKfFCKSXbznG < float_0) && (float)_Q7Kx7ErHf3u1QIUDKfFCKSXbznG < float_0 + float_1)
		{
			float amount = ((float)_Q7Kx7ErHf3u1QIUDKfFCKSXbznG - float_0) / float_1;
			_ujAkjlfN5TywwbLAUDzPvtab6uJ_0.X = MathHelper.Lerp(int_0, int_2, amount);
			_ujAkjlfN5TywwbLAUDzPvtab6uJ_0.Y = MathHelper.Lerp(int_1, int_3, amount);
		}
	}

	private void _nuSr558RHFkx9d2QBs2DeGUB1wX(_tfDAeR6npiqJMLRSXPO1DxGA0TgA _tfDAeR6npiqJMLRSXPO1DxGA0TgA_0, float float_0, float float_1, int int_0, int int_1, int int_2, int int_3)
	{
		if (!((float)_Q7Kx7ErHf3u1QIUDKfFCKSXbznG < float_0) && (float)_Q7Kx7ErHf3u1QIUDKfFCKSXbznG < float_0 + float_1)
		{
			float amount = ((float)_Q7Kx7ErHf3u1QIUDKfFCKSXbznG - float_0) / float_1;
			_tfDAeR6npiqJMLRSXPO1DxGA0TgA_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = MathHelper.Lerp(int_0, int_2, amount);
			_tfDAeR6npiqJMLRSXPO1DxGA0TgA_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = MathHelper.Lerp(int_1, int_3, amount);
		}
	}
}
