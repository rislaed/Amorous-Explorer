using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _6OmCduUGKgPqhBnqgfNJUOmDpZW<T, U>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly T _fStemwWB2D6lHHxMgfgDO4E5w2G;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly U _qHXlCugFudIXDTksrDHhh1eusHD;

	public T Name => _fStemwWB2D6lHHxMgfgDO4E5w2G;

	public U Value => _qHXlCugFudIXDTksrDHhh1eusHD;

	[DebuggerHidden]
	public _6OmCduUGKgPqhBnqgfNJUOmDpZW(T gparam_0, U gparam_1)
	{
		while (true)
		{
			int num = -249420628;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBAE7DC75u) % 3u)
				{
				case 2u:
					goto IL_0008;
				case 0u:
					break;
				default:
					_qHXlCugFudIXDTksrDHhh1eusHD = gparam_1;
					return;
				}
				break;
				IL_0008:
				_fStemwWB2D6lHHxMgfgDO4E5w2G = gparam_0;
				num = (int)((num2 * 292440415) ^ 0x5D6388E4);
			}
		}
	}

	[DebuggerHidden]
	public override bool _LS9lnS2o8mIczclV735RvXVZkmk(object obj)
	{
		if (obj is _6OmCduUGKgPqhBnqgfNJUOmDpZW<T, U> _6OmCduUGKgPqhBnqgfNJUOmDpZW2)
		{
			while (true)
			{
				int num = -762813459;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD13F2B9Au) % 4u)
					{
					case 3u:
					{
						int num3;
						int num4;
						if (!EqualityComparer<T>.Default.Equals(_fStemwWB2D6lHHxMgfgDO4E5w2G, _6OmCduUGKgPqhBnqgfNJUOmDpZW2._fStemwWB2D6lHHxMgfgDO4E5w2G))
						{
							num3 = 746227158;
							num4 = 746227158;
						}
						else
						{
							num3 = 753974009;
							num4 = 753974009;
						}
						num = num3 ^ (int)(num2 * 556801682);
						continue;
					}
					case 0u:
						break;
					case 1u:
						return EqualityComparer<U>.Default.Equals(_qHXlCugFudIXDTksrDHhh1eusHD, _6OmCduUGKgPqhBnqgfNJUOmDpZW2._qHXlCugFudIXDTksrDHhh1eusHD);
					default:
						goto end_IL_0064;
					}
					break;
				}
				continue;
				end_IL_0064:
				break;
			}
		}
		return false;
	}

	[DebuggerHidden]
	public override int _lFIedLalGGle1XjAyByscHqD2IH()
	{
		return (-589955086 + EqualityComparer<T>.Default.GetHashCode(_fStemwWB2D6lHHxMgfgDO4E5w2G)) * -1521134295 + EqualityComparer<U>.Default.GetHashCode(_qHXlCugFudIXDTksrDHhh1eusHD);
	}

	[DebuggerHidden]
	public override string _VipZca1dSzb4czdJRX4BeBMx8nbA()
	{
		object[] array = new object[2];
		T fStemwWB2D6lHHxMgfgDO4E5w2G = _fStemwWB2D6lHHxMgfgDO4E5w2G;
		array[0] = ((fStemwWB2D6lHHxMgfgDO4E5w2G != null) ? fStemwWB2D6lHHxMgfgDO4E5w2G.ToString() : null);
		U qHXlCugFudIXDTksrDHhh1eusHD = _qHXlCugFudIXDTksrDHhh1eusHD;
		array[1] = ((qHXlCugFudIXDTksrDHhh1eusHD != null) ? qHXlCugFudIXDTksrDHhh1eusHD.ToString() : null);
		return _6OmCduUGKgPqhBnqgfNJUOmDpZW<T, U>.smethod_0((IFormatProvider)null, "{{ Name = {0}, Value = {1} }}", array);
	}

	static string smethod_0(IFormatProvider iformatProvider_0, string string_0, object[] object_0)
	{
		return string.Format(iformatProvider_0, string_0, object_0);
	}
}
