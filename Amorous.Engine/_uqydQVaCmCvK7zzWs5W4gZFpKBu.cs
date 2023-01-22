using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class _uqydQVaCmCvK7zzWs5W4gZFpKBu : _ujAkjlfN5TywwbLAUDzPvtab6uJ
{
	public Texture2D _Ko8EyRGBPblyaAEHREGGfcgE0A7 { get; private set; }

	public bool _PXBbI2AED2MyzkuXicgwalICf26 { get; set; }

	public _uqydQVaCmCvK7zzWs5W4gZFpKBu(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, Texture2D texture2D_0)
		: base(_7UlnfykmEmZDFt3BmCKZekI43Ih_0, string_0)
	{
		_Ko8EyRGBPblyaAEHREGGfcgE0A7 = texture2D_0;
		base._je8rVfyg4zywmqSi4Ozx1z7wJ4b = texture2D_0.get_Width();
		base._WJfGWBzn4wgdGBnMWRH2pcJ3AqH = texture2D_0.get_Height();
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
	}

	public override void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		if (((Color)(ref _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA)).get_A() != 0)
		{
			spriteBatch_0.Draw(_Ko8EyRGBPblyaAEHREGGfcgE0A7, _Jh6AK28sBy2bS8ZCoKHP3LX45Uk, (Rectangle?)null, _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA, 0f, Vector2.get_Zero(), _fO7gSlrDDNMoHR4FO5QXAq8fUyA, (SpriteEffects)(_PXBbI2AED2MyzkuXicgwalICf26 ? 1 : 0), 0f);
		}
	}

	public override void _ymyneWF6dfrtfUI08wyb3KExq0D()
	{
		base._XbOXR6AypLIdJ3gBMGseGi3Wi2i._ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8._HXLRmt9GqcmA9GTG5xzRKNu3QpF(_Ko8EyRGBPblyaAEHREGGfcgE0A7);
	}

	static int smethod_0(Texture2D texture2D_0)
	{
		return texture2D_0.get_Width();
	}

	static int smethod_1(Texture2D texture2D_0)
	{
		return texture2D_0.get_Height();
	}
}
