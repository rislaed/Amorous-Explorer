using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class _HNKZHPtLme6iaFiaVC67QqNpYAi : _5EDaN9V3lc2jRRTcL6GvzBbV7kU<DialogueChoiceEventData>
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _ZRGGkuaJt2uin7xxFvmUOoxRTtH
	{
		public static readonly _ZRGGkuaJt2uin7xxFvmUOoxRTtH _003C_003E9 = new _ZRGGkuaJt2uin7xxFvmUOoxRTtH();

		public static Func<DialogueChoiceItem, string> _003C_003E9__6_0;

		internal string _btce8GF7pMHuCqSVbu6fTKSdHke(DialogueChoiceItem dialogueChoiceItem_0)
		{
			return dialogueChoiceItem_0._K87Hdb6ToAR0us3tN3ZmvHdPdeJ;
		}
	}

	public DialogueChoiceItem[] _UGE50ZJkpUKKpV0XQkhALS58JSJ { get; private set; }

	public _HNKZHPtLme6iaFiaVC67QqNpYAi(_nR8eroJOHehP0ZGyyTveo6aMTHg _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
		: base(_nR8eroJOHehP0ZGyyTveo6aMTHg_0)
	{
	}

	public override void _dCiaLpIow7UQ0MLMp2O4J0yeVfF(DialogueChoiceEventData dialogueChoiceEventData_0)
	{
		base._dCiaLpIow7UQ0MLMp2O4J0yeVfF(dialogueChoiceEventData_0);
		_UGE50ZJkpUKKpV0XQkhALS58JSJ = dialogueChoiceEventData_0._UGE50ZJkpUKKpV0XQkhALS58JSJ.ToArray();
	}

	public override void _4hlxzMzKSbVTbZUrEsP3dfw4x0h()
	{
		base._4hlxzMzKSbVTbZUrEsP3dfw4x0h();
		_nkzqFdEfDyLcyGikIKGcHjklI4y._MRzbkwglCADk2fFjoxcsdCSJfKu(_UGE50ZJkpUKKpV0XQkhALS58JSJ.Select((DialogueChoiceItem dialogueChoiceItem_0) => dialogueChoiceItem_0._K87Hdb6ToAR0us3tN3ZmvHdPdeJ).ToArray());
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime)
	{
		base._xJZUPxDatEzfPQc0nRHR2D1Vwke = !_nkzqFdEfDyLcyGikIKGcHjklI4y._zatbtX2c8i2hGOTptNymBxA8kVI;
		if (base._xJZUPxDatEzfPQc0nRHR2D1Vwke)
		{
			int num = _nkzqFdEfDyLcyGikIKGcHjklI4y._rVWIUtPzqmWcZbPclkfMRcIkeGR - 1;
			if (num >= 0 && num < _UGE50ZJkpUKKpV0XQkhALS58JSJ.Length)
			{
				base._GUdPCTGCrEJpuEchc38clNBP3ZAA = _UGE50ZJkpUKKpV0XQkhALS58JSJ[num]._GUdPCTGCrEJpuEchc38clNBP3ZAA;
			}
		}
	}
}
