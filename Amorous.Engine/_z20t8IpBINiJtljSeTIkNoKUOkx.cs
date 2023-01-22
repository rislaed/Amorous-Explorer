using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class _z20t8IpBINiJtljSeTIkNoKUOkx : _ujAkjlfN5TywwbLAUDzPvtab6uJ
{
	private readonly Action _XvomzD7ydX2gHHhG6ti3fxsB4QF;

	private bool _3pSkuXQLrbxfnmDHjLbcxrYNIfk;

	public Texture2D _Ko8EyRGBPblyaAEHREGGfcgE0A7 { get; private set; }

	public _z20t8IpBINiJtljSeTIkNoKUOkx(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, Texture2D texture2D_0, Action action_0)
		: base(_7UlnfykmEmZDFt3BmCKZekI43Ih_0, string_0)
	{
		_Ko8EyRGBPblyaAEHREGGfcgE0A7 = texture2D_0;
		base._je8rVfyg4zywmqSi4Ozx1z7wJ4b = texture2D_0.Width;
		base._WJfGWBzn4wgdGBnMWRH2pcJ3AqH = texture2D_0.Height;
		_XvomzD7ydX2gHHhG6ti3fxsB4QF = action_0;
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
	}

	public override void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0)
	{
		if (_9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA.A != 0)
		{
			spriteBatch_0.Draw(_Ko8EyRGBPblyaAEHREGGfcgE0A7, _Jh6AK28sBy2bS8ZCoKHP3LX45Uk, null, (!_3pSkuXQLrbxfnmDHjLbcxrYNIfk) ? _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA : Color.Red, 0f, Vector2.Zero, _fO7gSlrDDNMoHR4FO5QXAq8fUyA, SpriteEffects.None, 0f);
		}
	}

	public override bool _Hym13mjJB64DQkbAkEMmEae8pQdA()
	{
		_3pSkuXQLrbxfnmDHjLbcxrYNIfk = false;
		_XvomzD7ydX2gHHhG6ti3fxsB4QF();
		return true;
	}

	public override void _i3qb0SiBqvdxqp5NXIRGrNGErxh()
	{
		_3pSkuXQLrbxfnmDHjLbcxrYNIfk = true;
	}

	public override void _oc2Bt2sYu2e2W8gFbd4cz1hv2Fq()
	{
		_3pSkuXQLrbxfnmDHjLbcxrYNIfk = false;
	}
}
