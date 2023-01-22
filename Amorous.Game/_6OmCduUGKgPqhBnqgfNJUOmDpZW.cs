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
		_fStemwWB2D6lHHxMgfgDO4E5w2G = gparam_0;
		_qHXlCugFudIXDTksrDHhh1eusHD = gparam_1;
	}

	[DebuggerHidden]
	public override bool _LS9lnS2o8mIczclV735RvXVZkmk(object obj)
	{
		if (obj is _6OmCduUGKgPqhBnqgfNJUOmDpZW<T, U> _6OmCduUGKgPqhBnqgfNJUOmDpZW2 && EqualityComparer<T>.Default.Equals(_fStemwWB2D6lHHxMgfgDO4E5w2G, _6OmCduUGKgPqhBnqgfNJUOmDpZW2._fStemwWB2D6lHHxMgfgDO4E5w2G))
		{
			return EqualityComparer<U>.Default.Equals(_qHXlCugFudIXDTksrDHhh1eusHD, _6OmCduUGKgPqhBnqgfNJUOmDpZW2._qHXlCugFudIXDTksrDHhh1eusHD);
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
		return string.Format((IFormatProvider)null, "{{ Name = {0}, Value = {1} }}", array);
	}
}
