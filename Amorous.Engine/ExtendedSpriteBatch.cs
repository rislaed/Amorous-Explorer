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

	public static void DrawString(this SpriteBatch spriteBatch, SpriteFont spriteFont, string text, Vector2 position, Color color)
	{
		spriteBatch.DrawString(spriteFont, text, position + Location0x0 * 1f, Color.Black);
		spriteBatch.DrawString(spriteFont, text, position + Location1x0 * 1f, Color.Black);
		spriteBatch.DrawString(spriteFont, text, position + Location2x0 * 1f, Color.Black);
		spriteBatch.DrawString(spriteFont, text, position + Location0x1 * 1f, Color.Black);
		spriteBatch.DrawString(spriteFont, text, position, Color.Black);
		spriteBatch.DrawString(spriteFont, text, position + Location2x1 * 1f, Color.Black);
		spriteBatch.DrawString(spriteFont, text, position + Location0x2 * 1f, Color.Black);
		spriteBatch.DrawString(spriteFont, text, position + Location1x2 * 1f, Color.Black);
		spriteBatch.DrawString(spriteFont, text, position + Location2x2 * 1f, Color.Black);
		spriteBatch.DrawString(spriteFont, text, position, color);
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

	public static void Begin(this SpriteBatch spriteBatch, SpriteSortMode sortMode = SpriteSortMode.Deferred, BlendState blendState = null, SamplerState samplerState = null, DepthStencilState depthStencilState = null, RasterizerState rasterizerState = null, Effect effect = null, Matrix? transformationMatrix = null)
	{
		blendState = blendState ?? BlendState.AlphaBlend;
		samplerState = samplerState ?? SamplerState.LinearClamp;
		if (transformationMatrix == null) {
			spriteBatch.Begin(sortMode, blendState, samplerState, depthStencilState, rasterizerState, effect);
		} else {
			spriteBatch.Begin(sortMode, blendState, samplerState, depthStencilState, rasterizerState, effect, (Matrix) transformationMatrix);
		}
	}
}
