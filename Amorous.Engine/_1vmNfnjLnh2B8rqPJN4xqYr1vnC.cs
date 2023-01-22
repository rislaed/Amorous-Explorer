using System;
using System.Reflection;
using Amorous.Engine.Data.Cutscenes;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

public class _1vmNfnjLnh2B8rqPJN4xqYr1vnC : _5EDaN9V3lc2jRRTcL6GvzBbV7kU<SpawnNPCEventData>
{
	private _QGGOTxZ8aNWGh0hc26wcmx8wmwT _v5mBBzOHST4Ij2jetldrF2beJtbA;

	public string _4QLHHCk23T1BjK7acKxASbkCefG { get; private set; }

	public string _qZXN2SXhpGdh4T5ZXzgMA9gjYZE { get; private set; }

	public string _dPmC8tBC0iph2YBAFmztEsmwUdSA { get; private set; }

	public string _oYBxqDGzxQL6JWNoPfdeHzWGPRp { get; private set; }

	public string _kni1uFw1BPElsVA74myj9H1jAKh { get; private set; }

	public string _UjXB7oNK1WnbtEn6d4PkoGLaYEE { get; private set; }

	public string[] _wUcbLpwYJ1T1bI8GaQwj9Jxx4YX { get; private set; }

	public _1vmNfnjLnh2B8rqPJN4xqYr1vnC(_nR8eroJOHehP0ZGyyTveo6aMTHg _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
		: base(_nR8eroJOHehP0ZGyyTveo6aMTHg_0)
	{
	}

	public override void _dCiaLpIow7UQ0MLMp2O4J0yeVfF(SpawnNPCEventData spawnNPCEventData_0)
	{
		base._dCiaLpIow7UQ0MLMp2O4J0yeVfF(spawnNPCEventData_0);
		_4QLHHCk23T1BjK7acKxASbkCefG = spawnNPCEventData_0._4QLHHCk23T1BjK7acKxASbkCefG;
		_qZXN2SXhpGdh4T5ZXzgMA9gjYZE = spawnNPCEventData_0._qZXN2SXhpGdh4T5ZXzgMA9gjYZE;
		_dPmC8tBC0iph2YBAFmztEsmwUdSA = spawnNPCEventData_0._dPmC8tBC0iph2YBAFmztEsmwUdSA;
		_oYBxqDGzxQL6JWNoPfdeHzWGPRp = spawnNPCEventData_0._oYBxqDGzxQL6JWNoPfdeHzWGPRp;
		_kni1uFw1BPElsVA74myj9H1jAKh = spawnNPCEventData_0._kni1uFw1BPElsVA74myj9H1jAKh;
		_UjXB7oNK1WnbtEn6d4PkoGLaYEE = spawnNPCEventData_0._UjXB7oNK1WnbtEn6d4PkoGLaYEE;
		_wUcbLpwYJ1T1bI8GaQwj9Jxx4YX = ((spawnNPCEventData_0._wUcbLpwYJ1T1bI8GaQwj9Jxx4YX == null) ? null : spawnNPCEventData_0._wUcbLpwYJ1T1bI8GaQwj9Jxx4YX.ToArray());
	}

	public override void _4hlxzMzKSbVTbZUrEsP3dfw4x0h()
	{
		base._4hlxzMzKSbVTbZUrEsP3dfw4x0h();
		_a2qVgWDIm3fBp49WubttSTPsx8K result = ((!Enum.TryParse<_a2qVgWDIm3fBp49WubttSTPsx8K>(_dPmC8tBC0iph2YBAFmztEsmwUdSA, out result)) ? _a2qVgWDIm3fBp49WubttSTPsx8K.Background : result);
		_v5mBBzOHST4Ij2jetldrF2beJtbA = base._5zNdOw7qHmuCAPJFMr3SsZdBlCr._ZzBuoSDMWwerejOO9Goyv2OCKgE._TwQHHdbdRFRy2ctTZabNfz1Htrg(_4QLHHCk23T1BjK7acKxASbkCefG, result);
		if (_v5mBBzOHST4Ij2jetldrF2beJtbA == null)
		{
			return;
		}
		_v5mBBzOHST4Ij2jetldrF2beJtbA._zkHMlDFkja4TqmjdlHuZRCj8FCB = true;
		if (_v5mBBzOHST4Ij2jetldrF2beJtbA._rAt6TRbgK04lvrs5QPjcd0n26pk != null)
		{
			Type[] rAt6TRbgK04lvrs5QPjcd0n26pk = _v5mBBzOHST4Ij2jetldrF2beJtbA._rAt6TRbgK04lvrs5QPjcd0n26pk;
			foreach (Type type in rAt6TRbgK04lvrs5QPjcd0n26pk)
			{
				_QGGOTxZ8aNWGh0hc26wcmx8wmwT qGGOTxZ8aNWGh0hc26wcmx8wmwT = base._5zNdOw7qHmuCAPJFMr3SsZdBlCr._ZzBuoSDMWwerejOO9Goyv2OCKgE._VvFE2zgy4FbDjvaEvb67tXJ7aRm(type.Name);
				if (qGGOTxZ8aNWGh0hc26wcmx8wmwT != null && qGGOTxZ8aNWGh0hc26wcmx8wmwT._9m9LEAgaqaeXydYhykSBmf9BrDG != 0)
				{
					if (_qZXN2SXhpGdh4T5ZXzgMA9gjYZE == null)
					{
						_qZXN2SXhpGdh4T5ZXzgMA9gjYZE = qGGOTxZ8aNWGh0hc26wcmx8wmwT._9m9LEAgaqaeXydYhykSBmf9BrDG.ToString();
					}
					if (_kni1uFw1BPElsVA74myj9H1jAKh == null)
					{
						_kni1uFw1BPElsVA74myj9H1jAKh = qGGOTxZ8aNWGh0hc26wcmx8wmwT._mdS7Bu4eiPPwoFWUcGEOTzh73TJ;
					}
					if (_UjXB7oNK1WnbtEn6d4PkoGLaYEE == null)
					{
						_UjXB7oNK1WnbtEn6d4PkoGLaYEE = qGGOTxZ8aNWGh0hc26wcmx8wmwT._vzNADWxcLucI3DyP1CebcfYXRut;
					}
					if (_wUcbLpwYJ1T1bI8GaQwj9Jxx4YX == null)
					{
						_wUcbLpwYJ1T1bI8GaQwj9Jxx4YX = qGGOTxZ8aNWGh0hc26wcmx8wmwT._QeyVQAHb3TegEFsv9IPdYmxNkGZ;
					}
					qGGOTxZ8aNWGh0hc26wcmx8wmwT._CX43jhSKNOViVFqkMliNa9qgGon();
					break;
				}
			}
		}
		if (!Enum.TryParse<NPCLocation>(_qZXN2SXhpGdh4T5ZXzgMA9gjYZE, out var result2))
		{
			result2 = ((_v5mBBzOHST4Ij2jetldrF2beJtbA._9m9LEAgaqaeXydYhykSBmf9BrDG == NPCLocation.None) ? NPCLocation.Middle : _v5mBBzOHST4Ij2jetldrF2beJtbA._9m9LEAgaqaeXydYhykSBmf9BrDG);
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT qGGOTxZ8aNWGh0hc26wcmx8wmwT2 = base._5zNdOw7qHmuCAPJFMr3SsZdBlCr._ZzBuoSDMWwerejOO9Goyv2OCKgE._VvFE2zgy4FbDjvaEvb67tXJ7aRm(result2);
			if (qGGOTxZ8aNWGh0hc26wcmx8wmwT2 != null && qGGOTxZ8aNWGh0hc26wcmx8wmwT2 != _v5mBBzOHST4Ij2jetldrF2beJtbA)
			{
				qGGOTxZ8aNWGh0hc26wcmx8wmwT2._CX43jhSKNOViVFqkMliNa9qgGon();
			}
			_v5mBBzOHST4Ij2jetldrF2beJtbA._7d2DAwjp6FutkJY09U0Mlk43Nmn(result2, _kni1uFw1BPElsVA74myj9H1jAKh, _UjXB7oNK1WnbtEn6d4PkoGLaYEE, _wUcbLpwYJ1T1bI8GaQwj9Jxx4YX);
		}
		else if (result2 != 0)
		{
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT qGGOTxZ8aNWGh0hc26wcmx8wmwT3 = base._5zNdOw7qHmuCAPJFMr3SsZdBlCr._ZzBuoSDMWwerejOO9Goyv2OCKgE._VvFE2zgy4FbDjvaEvb67tXJ7aRm(result2);
			if (qGGOTxZ8aNWGh0hc26wcmx8wmwT3 != null && qGGOTxZ8aNWGh0hc26wcmx8wmwT3 != _v5mBBzOHST4Ij2jetldrF2beJtbA)
			{
				qGGOTxZ8aNWGh0hc26wcmx8wmwT3._CX43jhSKNOViVFqkMliNa9qgGon();
			}
			_v5mBBzOHST4Ij2jetldrF2beJtbA._7d2DAwjp6FutkJY09U0Mlk43Nmn(result2, _kni1uFw1BPElsVA74myj9H1jAKh, _UjXB7oNK1WnbtEn6d4PkoGLaYEE, _wUcbLpwYJ1T1bI8GaQwj9Jxx4YX);
			_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve2 = base._5zNdOw7qHmuCAPJFMr3SsZdBlCr._ZzBuoSDMWwerejOO9Goyv2OCKgE._XbOXR6AypLIdJ3gBMGseGi3Wi2i._VvFE2zgy4FbDjvaEvb67tXJ7aRm(_4QLHHCk23T1BjK7acKxASbkCefG);
			switch (result2)
			{
			case NPCLocation.Left:
			case NPCLocation.Right:
				_3IHp43rpkJgOBcY9lrIrwMuwWve2._VNgmwYSLsJyyiR6cPQ35UHJBR4d = 0;
				break;
			case NPCLocation.Middle:
				_3IHp43rpkJgOBcY9lrIrwMuwWve2._VNgmwYSLsJyyiR6cPQ35UHJBR4d = 1;
				break;
			}
		}
		else
		{
			_v5mBBzOHST4Ij2jetldrF2beJtbA._CX43jhSKNOViVFqkMliNa9qgGon();
		}
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime)
	{
		base._xJZUPxDatEzfPQc0nRHR2D1Vwke = _v5mBBzOHST4Ij2jetldrF2beJtbA == null || !_v5mBBzOHST4Ij2jetldrF2beJtbA._fsCqU0Uh34vrMEsAqlf2BqbTz5B;
	}

	static string smethod_0(MemberInfo memberInfo_0)
	{
		return memberInfo_0.Name;
	}
}
