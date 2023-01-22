using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class _C9DhEciuJHkReX4htI9sP6cbqzF : _ujAkjlfN5TywwbLAUDzPvtab6uJ
{
	private float _u8pBof2EYEcHCEDxEtA27OOeLmVb;

	private readonly Vector2 _QBwNjQE21bfJ9yRo7CynjeYaHRg;

	public Texture2D _Ko8EyRGBPblyaAEHREGGfcgE0A7 { get; private set; }

	public float _NhL238TaCbkDiY6HXlWXZzzUYkm { get; private set; }

	public _C9DhEciuJHkReX4htI9sP6cbqzF(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, Texture2D texture2D_0, float float_0, Vector2 vector2_0)
		: base(_7UlnfykmEmZDFt3BmCKZekI43Ih_0, string_0)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		_Ko8EyRGBPblyaAEHREGGfcgE0A7 = texture2D_0;
		_NhL238TaCbkDiY6HXlWXZzzUYkm = float_0;
		base._je8rVfyg4zywmqSi4Ozx1z7wJ4b = texture2D_0.get_Width();
		base._WJfGWBzn4wgdGBnMWRH2pcJ3AqH = texture2D_0.get_Height();
		_u8pBof2EYEcHCEDxEtA27OOeLmVb = 0f;
		_QBwNjQE21bfJ9yRo7CynjeYaHRg = vector2_0;
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		_u8pBof2EYEcHCEDxEtA27OOeLmVb += (float)gameTime_0.get_ElapsedGameTime().Milliseconds / 1000f * _NhL238TaCbkDiY6HXlWXZzzUYkm;
		if (_u8pBof2EYEcHCEDxEtA27OOeLmVb <= 360f)
		{
			if (_u8pBof2EYEcHCEDxEtA27OOeLmVb < -360f)
			{
				_u8pBof2EYEcHCEDxEtA27OOeLmVb += 360f;
			}
		}
		else
		{
			_u8pBof2EYEcHCEDxEtA27OOeLmVb -= 360f;
		}
	}

	public override void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (((Color)(ref _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA)).get_A() != 0)
		{
			spriteBatch_0.Draw(_Ko8EyRGBPblyaAEHREGGfcgE0A7, _Jh6AK28sBy2bS8ZCoKHP3LX45Uk + _QBwNjQE21bfJ9yRo7CynjeYaHRg, (Rectangle?)null, _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA, _u8pBof2EYEcHCEDxEtA27OOeLmVb, _QBwNjQE21bfJ9yRo7CynjeYaHRg, _fO7gSlrDDNMoHR4FO5QXAq8fUyA, (SpriteEffects)0, 0f);
		}
	}

	static int smethod_0(Texture2D texture2D_0)
	{
		return texture2D_0.get_Width();
	}

	static int smethod_1(Texture2D texture2D_0)
	{
		return texture2D_0.get_Height();
	}

	static TimeSpan smethod_2(GameTime gameTime_0)
	{
		return gameTime_0.get_ElapsedGameTime();
	}
}
