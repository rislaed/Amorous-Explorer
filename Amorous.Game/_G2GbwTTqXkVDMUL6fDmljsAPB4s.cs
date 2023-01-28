using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class _G2GbwTTqXkVDMUL6fDmljsAPB4s
{
	private static readonly Color _Ib9VarTDKmfjV0rrVECzoNEzrSL = new Color(50, 45, 0, 50);
	private static readonly Color _FfaSCX3DjztPrRuzUxZ0SEncuSR = new Color(0, 0, 0, 0);
	private static readonly Color _or20jsQIs921jMzfkOHr9vXb9Cd = new Color(65, 15, 0, 50);
	private static readonly Color _MMqeUiXOyJf7vpX8piOiMK4x0bH = new Color(20, 0, 90, 50);

	private readonly ScreenFader _RA1aFlOff0jGfI2cKUGhYI1MRLBA;
	private TimeOfDay? _za3KOX0Td9JuYbMVuVrSRekcEdJ;

	public _G2GbwTTqXkVDMUL6fDmljsAPB4s(IAmorous game)
	{
		_RA1aFlOff0jGfI2cKUGhYI1MRLBA = new ScreenFader(game.GLES);
	}

	public void Update(GameTime gameTime)
	{
		_RA1aFlOff0jGfI2cKUGhYI1MRLBA.Update(gameTime);
		_1TexRAv8TgmLSYZPaXObsZp5CgP();
	}

	public void Draw(SpriteBatch spriteBatch, MouseObserver mouse)
	{
		_RA1aFlOff0jGfI2cKUGhYI1MRLBA.Draw(spriteBatch, mouse);
	}

	private void _1TexRAv8TgmLSYZPaXObsZp5CgP()
	{
		if (_za3KOX0Td9JuYbMVuVrSRekcEdJ != Clocks.Time)
		{
			_za3KOX0Td9JuYbMVuVrSRekcEdJ = Clocks.Time;
			switch (Clocks.Time)
			{
				default:
					_RA1aFlOff0jGfI2cKUGhYI1MRLBA.Apply(_MMqeUiXOyJf7vpX8piOiMK4x0bH);
					break;
				case TimeOfDay.Morning:
					_RA1aFlOff0jGfI2cKUGhYI1MRLBA.Apply(_Ib9VarTDKmfjV0rrVECzoNEzrSL);
					break;
				case TimeOfDay.Day:
					_RA1aFlOff0jGfI2cKUGhYI1MRLBA.Apply(_FfaSCX3DjztPrRuzUxZ0SEncuSR);
					break;
				case TimeOfDay.Sunset:
					_RA1aFlOff0jGfI2cKUGhYI1MRLBA.Apply(_or20jsQIs921jMzfkOHr9vXb9Cd);
					break;
			}
		}
	}
}
