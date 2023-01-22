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
		while (true)
		{
			int num = 800631446;
			while (true)
			{
				DialogueChoiceItem[] uGE50ZJkpUKKpV0XQkhALS58JSJ;
				Func<DialogueChoiceItem, string> selector;
				switch ((uint)(num ^ 0x463E108D) % 3u)
				{
				case 2u:
					uGE50ZJkpUKKpV0XQkhALS58JSJ = _UGE50ZJkpUKKpV0XQkhALS58JSJ;
					selector = (DialogueChoiceItem dialogueChoiceItem_0) => dialogueChoiceItem_0._K87Hdb6ToAR0us3tN3ZmvHdPdeJ;
					goto IL_002d;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_002d:
				_nkzqFdEfDyLcyGikIKGcHjklI4y._MRzbkwglCADk2fFjoxcsdCSJfKu(uGE50ZJkpUKKpV0XQkhALS58JSJ.Select(selector).ToArray());
				num = 1946004455;
			}
		}
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime)
	{
		base._xJZUPxDatEzfPQc0nRHR2D1Vwke = !_nkzqFdEfDyLcyGikIKGcHjklI4y._zatbtX2c8i2hGOTptNymBxA8kVI;
		int num3 = default(int);
		while (true)
		{
			int num = -1541066677;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCCEBDB96u) % 8u)
				{
				case 7u:
					base._GUdPCTGCrEJpuEchc38clNBP3ZAA = _UGE50ZJkpUKKpV0XQkhALS58JSJ[num3]._GUdPCTGCrEJpuEchc38clNBP3ZAA;
					num = -1274969969;
					continue;
				case 6u:
				{
					int num6;
					int num7;
					if (num3 < 0)
					{
						num6 = -1681839488;
						num7 = -1681839488;
					}
					else
					{
						num6 = -488172383;
						num7 = -488172383;
					}
					num = num6 ^ (int)(num2 * 1795345442);
					continue;
				}
				case 5u:
				{
					int num8;
					int num9;
					if (base._xJZUPxDatEzfPQc0nRHR2D1Vwke)
					{
						num8 = -1589595760;
						num9 = -1589595760;
					}
					else
					{
						num8 = -1860775131;
						num9 = -1860775131;
					}
					num = num8 ^ ((int)num2 * -1030134606);
					continue;
				}
				case 4u:
					num3 = _nkzqFdEfDyLcyGikIKGcHjklI4y._rVWIUtPzqmWcZbPclkfMRcIkeGR - 1;
					num = (int)((num2 * 1894696678) ^ 0x61B42A90);
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (num3 >= _UGE50ZJkpUKKpV0XQkhALS58JSJ.Length)
					{
						num4 = 1777619044;
						num5 = 1777619044;
					}
					else
					{
						num4 = 1717891257;
						num5 = 1717891257;
					}
					num = num4 ^ (int)(num2 * 1828703400);
					continue;
				}
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				case 2u:
					return;
				}
				break;
			}
		}
	}
}
