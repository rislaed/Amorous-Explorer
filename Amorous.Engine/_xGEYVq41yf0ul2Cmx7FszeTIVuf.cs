using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class _xGEYVq41yf0ul2Cmx7FszeTIVuf : _5EDaN9V3lc2jRRTcL6GvzBbV7kU<PlayDialogueEventData>
{
	private bool _sYTI9KQ6wWFbqvMDTbLkrgpPx6E;

	public string _K87Hdb6ToAR0us3tN3ZmvHdPdeJ { get; private set; }

	public string _D5QiLGGNtfoCEnZIUPvH4OKqUabA { get; private set; }

	public Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA { get; private set; }

	public _xGEYVq41yf0ul2Cmx7FszeTIVuf(_nR8eroJOHehP0ZGyyTveo6aMTHg _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
		: base(_nR8eroJOHehP0ZGyyTveo6aMTHg_0)
	{
	}

	public override void _dCiaLpIow7UQ0MLMp2O4J0yeVfF(PlayDialogueEventData playDialogueEventData_0)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		base._dCiaLpIow7UQ0MLMp2O4J0yeVfF(playDialogueEventData_0);
		while (true)
		{
			int num = 76037530;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4365CBC0u) % 4u)
				{
				case 3u:
					_D5QiLGGNtfoCEnZIUPvH4OKqUabA = playDialogueEventData_0._D5QiLGGNtfoCEnZIUPvH4OKqUabA;
					num = (int)((num2 * 444999263) ^ 0x3CA5C40);
					continue;
				case 2u:
					_K87Hdb6ToAR0us3tN3ZmvHdPdeJ = playDialogueEventData_0._K87Hdb6ToAR0us3tN3ZmvHdPdeJ;
					num = ((int)num2 * -532992940) ^ 0x40B2BFFF;
					continue;
				case 0u:
					break;
				default:
					_9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = playDialogueEventData_0._9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA;
					_sYTI9KQ6wWFbqvMDTbLkrgpPx6E = false;
					return;
				}
				break;
			}
		}
	}

	public override void _4hlxzMzKSbVTbZUrEsP3dfw4x0h()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		base._4hlxzMzKSbVTbZUrEsP3dfw4x0h();
		_nkzqFdEfDyLcyGikIKGcHjklI4y._zunSyHn4DekdA6CngP10dXcR1kq(_K87Hdb6ToAR0us3tN3ZmvHdPdeJ, _D5QiLGGNtfoCEnZIUPvH4OKqUabA, _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA);
	}

	public override bool _NeIQsy78kWqF9jXLl8vb2lOyZgO()
	{
		if (_sYTI9KQ6wWFbqvMDTbLkrgpPx6E)
		{
			goto IL_0008;
		}
		goto IL_006f;
		IL_006f:
		_sYTI9KQ6wWFbqvMDTbLkrgpPx6E = true;
		int num = 1957993536;
		goto IL_0046;
		IL_0046:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x1628B446u) % 6u)
			{
			case 4u:
				break;
			case 3u:
				num = ((int)num2 * -45773520) ^ -2025845551;
				continue;
			case 1u:
				base._xJZUPxDatEzfPQc0nRHR2D1Vwke = true;
				num = ((int)num2 * -1003380266) ^ -243245627;
				continue;
			case 0u:
				_nkzqFdEfDyLcyGikIKGcHjklI4y._NeIQsy78kWqF9jXLl8vb2lOyZgO();
				num = (int)((num2 * 452892743) ^ 0x1C378CCB);
				continue;
			case 2u:
				goto IL_006f;
			default:
				return false;
			}
			break;
		}
		goto IL_0008;
		IL_0008:
		num = 646427233;
		goto IL_0046;
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime)
	{
		base._xJZUPxDatEzfPQc0nRHR2D1Vwke = _nkzqFdEfDyLcyGikIKGcHjklI4y._xJZUPxDatEzfPQc0nRHR2D1Vwke;
	}
}
