using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public static class ExtendedSpriteBatch
{
	public static readonly Vector2 Location0x0 = new Vector2(-1f, -1f);

	public static readonly Vector2 Location1x0 = new Vector2(0f, -1f);

	public static readonly Vector2 Location2x0 = new Vector2(1f, -1f);

	public static readonly Vector2 Location0x1 = new Vector2(-1f, 0f);

	public static readonly Vector2 Location2x1 = new Vector2(1f, 0f);

	public static readonly Vector2 Location0x2 = new Vector2(-1f, 1f);

	public static readonly Vector2 Location1x2 = new Vector2(0f, 1f);

	public static readonly Vector2 Location2x2 = new Vector2(1f, 1f);

	public const int One = 1;

	public static void DrawString(this SpriteBatch spriteBatch, SpriteFont spriteFont, string text, Vector2 location, Color color)
	{
		spriteBatch.DrawString(spriteFont, text, location + Location0x0 * 1f, Color.Black);
		spriteBatch.DrawString(spriteFont, text, location + Location1x0 * 1f, Color.Black);
		spriteBatch.DrawString(spriteFont, text, location + Location2x0 * 1f, Color.Black);
		spriteBatch.DrawString(spriteFont, text, location + Location0x1 * 1f, Color.Black);
		spriteBatch.DrawString(spriteFont, text, location, Color.Black);
		spriteBatch.DrawString(spriteFont, text, location + Location2x1 * 1f, Color.Black);
		spriteBatch.DrawString(spriteFont, text, location + Location0x2 * 1f, Color.Black);
		spriteBatch.DrawString(spriteFont, text, location + Location1x2 * 1f, Color.Black);
		spriteBatch.DrawString(spriteFont, text, location + Location2x2 * 1f, Color.Black);
		spriteBatch.DrawString(spriteFont, text, location, color);
	}

	public static void Draw(this SpriteBatch spriteBatch, Texture2D texture2D_0, Vector2? nullable_0 = null, Rectangle? nullable_1 = null, Rectangle? nullable_2 = null, Vector2? nullable_3 = null, float float_0 = 0f, Vector2? nullable_4 = null, Color? nullable_5 = null, SpriteEffects spriteEffects_0 = SpriteEffects.None, float float_1 = 0f)
	{
		if (!nullable_5.HasValue)
		{
			nullable_5 = Color.White;
		}
		if (!nullable_3.HasValue)
		{
			nullable_3 = Vector2.Zero;
		}
		if (!nullable_4.HasValue)
		{
			nullable_4 = Vector2.One;
		}
		if (nullable_1.HasValue != nullable_0.HasValue)
		{
			if (nullable_0.HasValue)
			{
				spriteBatch.Draw(texture2D_0, nullable_0.Value, nullable_2, nullable_5.Value, float_0, nullable_3.Value, nullable_4.Value, spriteEffects_0, float_1);
			}
			else
			{
				spriteBatch.Draw(texture2D_0, nullable_1.Value, nullable_2, nullable_5.Value, float_0, nullable_3.Value, spriteEffects_0, float_1);
			}
			return;
		}
		throw new InvalidOperationException("Expected drawRectangle or position, but received neither or both.");
	}

	public static void Begin(this SpriteBatch spriteBatch, SpriteSortMode spriteSortMode_0 = SpriteSortMode.Deferred, BlendState blendState_0 = null, SamplerState samplerState_0 = null, DepthStencilState depthStencilState_0 = null, RasterizerState rasterizerState_0 = null, Effect effect_0 = null, Matrix? nullable_0 = null)
	{
		blendState_0 = blendState_0 ?? BlendState.AlphaBlend;
		samplerState_0 = samplerState_0 ?? SamplerState.LinearClamp;
	}
}
