using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class _G2GbwTTqXkVDMUL6fDmljsAPB4s
{
	private static readonly Color _Ib9VarTDKmfjV0rrVECzoNEzrSL = new Color(50, 45, 0, 50);

	private static readonly Color _FfaSCX3DjztPrRuzUxZ0SEncuSR = new Color(0, 0, 0, 0);

	private static readonly Color _or20jsQIs921jMzfkOHr9vXb9Cd = new Color(65, 15, 0, 50);

	private static readonly Color _MMqeUiXOyJf7vpX8piOiMK4x0bH = new Color(20, 0, 90, 50);

	private readonly _gJR4g7ak0hsZAUWX1vJbMqG2P5I _RA1aFlOff0jGfI2cKUGhYI1MRLBA;

	private TimeOfDay? _za3KOX0Td9JuYbMVuVrSRekcEdJ;

	public _G2GbwTTqXkVDMUL6fDmljsAPB4s(IAmorous game)
	{
		_RA1aFlOff0jGfI2cKUGhYI1MRLBA = new _gJR4g7ak0hsZAUWX1vJbMqG2P5I(Game._2yepMkVENnecIsduggABaU2qhXW);
	}

	public void Update(GameTime gameTime_0)
	{
		_RA1aFlOff0jGfI2cKUGhYI1MRLBA.Update(gameTime_0);
		_1TexRAv8TgmLSYZPaXObsZp5CgP();
	}

	public void Draw(SpriteBatch spriteBatch_0, _wRd4nHuQQlAPEwrHOGkBfut6Uip _wRd4nHuQQlAPEwrHOGkBfut6Uip_0)
	{
		_RA1aFlOff0jGfI2cKUGhYI1MRLBA.Draw(spriteBatch_0, _wRd4nHuQQlAPEwrHOGkBfut6Uip_0);
	}

	private void _1TexRAv8TgmLSYZPaXObsZp5CgP()
	{
		if (_za3KOX0Td9JuYbMVuVrSRekcEdJ != _5Anqe6GAAkzemoAXYpJmgMlk1yz.time)
		{
			_za3KOX0Td9JuYbMVuVrSRekcEdJ = _5Anqe6GAAkzemoAXYpJmgMlk1yz.time;
			switch (_5Anqe6GAAkzemoAXYpJmgMlk1yz.time)
			{
			default:
				_RA1aFlOff0jGfI2cKUGhYI1MRLBA._7d2DAwjp6FutkJY09U0Mlk43Nmn(_MMqeUiXOyJf7vpX8piOiMK4x0bH);
				break;
			case TimeOfDay.Morning:
				_RA1aFlOff0jGfI2cKUGhYI1MRLBA._7d2DAwjp6FutkJY09U0Mlk43Nmn(_Ib9VarTDKmfjV0rrVECzoNEzrSL);
				break;
			case TimeOfDay.Day:
				_RA1aFlOff0jGfI2cKUGhYI1MRLBA._7d2DAwjp6FutkJY09U0Mlk43Nmn(_FfaSCX3DjztPrRuzUxZ0SEncuSR);
				break;
			case TimeOfDay.Sunset:
				_RA1aFlOff0jGfI2cKUGhYI1MRLBA._7d2DAwjp6FutkJY09U0Mlk43Nmn(_or20jsQIs921jMzfkOHr9vXb9Cd);
				break;
			}
		}
	}
}
