using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class _xGEYVq41yf0ul2Cmx7FszeTIVuf : AbstractEvent<PlayDialogueEventData>
{
	private bool _sYTI9KQ6wWFbqvMDTbLkrgpPx6E;

	public string Text { get; private set; }

	public string Title { get; private set; }

	public Color Color { get; private set; }

	public _xGEYVq41yf0ul2Cmx7FszeTIVuf(_nR8eroJOHehP0ZGyyTveo6aMTHg _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
		: base(_nR8eroJOHehP0ZGyyTveo6aMTHg_0)
	{
	}

	public override void SetData(PlayDialogueEventData playDialogueEventData_0)
	{
		base.SetData(playDialogueEventData_0);
		Text = playDialogueEventData_0.Text;
		Title = playDialogueEventData_0.Title;
		Color = playDialogueEventData_0.Color;
		_sYTI9KQ6wWFbqvMDTbLkrgpPx6E = false;
	}

	public override void ResetVariation()
	{
		base.ResetVariation();
		_nkzqFdEfDyLcyGikIKGcHjklI4y._zunSyHn4DekdA6CngP10dXcR1kq(Text, Title, Color);
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

	public override void Update(GameTime gameTime)
	{
		base._xJZUPxDatEzfPQc0nRHR2D1Vwke = _nkzqFdEfDyLcyGikIKGcHjklI4y._xJZUPxDatEzfPQc0nRHR2D1Vwke;
	}
}
