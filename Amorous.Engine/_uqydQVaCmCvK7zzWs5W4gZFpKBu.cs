using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class _uqydQVaCmCvK7zzWs5W4gZFpKBu : _ujAkjlfN5TywwbLAUDzPvtab6uJ
{
	public Texture2D _Ko8EyRGBPblyaAEHREGGfcgE0A7 { get; private set; }

	public bool _PXBbI2AED2MyzkuXicgwalICf26 { get; set; }

	public _uqydQVaCmCvK7zzWs5W4gZFpKBu(AbstractScene AbstractScene_0, string string_0, Texture2D texture2D_0)
		: base(AbstractScene_0, string_0)
	{
		_Ko8EyRGBPblyaAEHREGGfcgE0A7 = texture2D_0;
		base.Width = texture2D_0.Width;
		base.Height = texture2D_0.Height;
	}

	public override void Update(GameTime gameTime_0)
	{
	}

	public override void Draw(SpriteBatch spriteBatch_0)
	{
		if (Color.A != 0)
		{
			spriteBatch_0.Draw(_Ko8EyRGBPblyaAEHREGGfcgE0A7, _Jh6AK28sBy2bS8ZCoKHP3LX45Uk, null, Color, 0f, Vector2.Zero, _fO7gSlrDDNMoHR4FO5QXAq8fUyA, _PXBbI2AED2MyzkuXicgwalICf26 ? SpriteEffects.FlipHorizontally : SpriteEffects.None, 0f);
		}
	}

	public override void _ymyneWF6dfrtfUI08wyb3KExq0D()
	{
		base.Scene.Game._uwNDZuqdFb9tyQtlQMxiz1DQ7x8._HXLRmt9GqcmA9GTG5xzRKNu3QpF(_Ko8EyRGBPblyaAEHREGGfcgE0A7);
	}
}
