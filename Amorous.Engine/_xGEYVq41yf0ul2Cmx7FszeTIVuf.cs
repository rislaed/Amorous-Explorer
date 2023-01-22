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
		base._dCiaLpIow7UQ0MLMp2O4J0yeVfF(playDialogueEventData_0);
		_K87Hdb6ToAR0us3tN3ZmvHdPdeJ = playDialogueEventData_0._K87Hdb6ToAR0us3tN3ZmvHdPdeJ;
		_D5QiLGGNtfoCEnZIUPvH4OKqUabA = playDialogueEventData_0._D5QiLGGNtfoCEnZIUPvH4OKqUabA;
		_9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = playDialogueEventData_0._9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA;
		_sYTI9KQ6wWFbqvMDTbLkrgpPx6E = false;
	}

	public override void _4hlxzMzKSbVTbZUrEsP3dfw4x0h()
	{
		base._4hlxzMzKSbVTbZUrEsP3dfw4x0h();
		_nkzqFdEfDyLcyGikIKGcHjklI4y._zunSyHn4DekdA6CngP10dXcR1kq(_K87Hdb6ToAR0us3tN3ZmvHdPdeJ, _D5QiLGGNtfoCEnZIUPvH4OKqUabA, _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA);
	}

	public override bool _NeIQsy78kWqF9jXLl8vb2lOyZgO()
	{
		if (_sYTI9KQ6wWFbqvMDTbLkrgpPx6E)
		{
			base._xJZUPxDatEzfPQc0nRHR2D1Vwke = true;
		}
		else
		{
			_sYTI9KQ6wWFbqvMDTbLkrgpPx6E = true;
			_nkzqFdEfDyLcyGikIKGcHjklI4y._NeIQsy78kWqF9jXLl8vb2lOyZgO();
		}
		return false;
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime)
	{
		base._xJZUPxDatEzfPQc0nRHR2D1Vwke = _nkzqFdEfDyLcyGikIKGcHjklI4y._xJZUPxDatEzfPQc0nRHR2D1Vwke;
	}
}
