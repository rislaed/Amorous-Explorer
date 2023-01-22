using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public static class _dXVK1NWaxcsgYg6KpavA0e8oion
{
	public static readonly Vector2 _CQmoNe3HuxMlvH6ncatJIgleXtO = new Vector2(-1f, -1f);

	public static readonly Vector2 _PONAYdpKcBnY3WYfbJb8CsCnULz = new Vector2(0f, -1f);

	public static readonly Vector2 _YAqNe0kFOrjh7LzXxLjdQh6EJDL = new Vector2(1f, -1f);

	public static readonly Vector2 _wEnSmK5KupzlCKc39D5VVJ95kHc = new Vector2(-1f, 0f);

	public static readonly Vector2 _oHXG2zLcZQh5Kr0rmoQF4mRwFJb = new Vector2(1f, 0f);

	public static readonly Vector2 _uuxIgLNZfbTGY9x4ooLT87m96Af = new Vector2(-1f, 1f);

	public static readonly Vector2 _bjsdlsFeEOX4MW8FjwWgpqNVDB9 = new Vector2(0f, 1f);

	public static readonly Vector2 _T4uXnm9GBQwqdGXwNMjF6znSKbD = new Vector2(1f, 1f);

	public const int _nQfXbSJu1TlI9ZPQhJdWlfUzXMd = 1;

	public static void _FY70IFLoBond3ORPe0ndCLvIeVcA(this SpriteBatch spriteBatch_0, SpriteFont spriteFont_0, string string_0, Vector2 vector2_0, Color color_0)
	{
		spriteBatch_0.DrawString(spriteFont_0, string_0, vector2_0 + _CQmoNe3HuxMlvH6ncatJIgleXtO * 1f, Color.Black);
		spriteBatch_0.DrawString(spriteFont_0, string_0, vector2_0 + _PONAYdpKcBnY3WYfbJb8CsCnULz * 1f, Color.Black);
		spriteBatch_0.DrawString(spriteFont_0, string_0, vector2_0 + _YAqNe0kFOrjh7LzXxLjdQh6EJDL * 1f, Color.Black);
		spriteBatch_0.DrawString(spriteFont_0, string_0, vector2_0 + _wEnSmK5KupzlCKc39D5VVJ95kHc * 1f, Color.Black);
		spriteBatch_0.DrawString(spriteFont_0, string_0, vector2_0, Color.Black);
		spriteBatch_0.DrawString(spriteFont_0, string_0, vector2_0 + _oHXG2zLcZQh5Kr0rmoQF4mRwFJb * 1f, Color.Black);
		spriteBatch_0.DrawString(spriteFont_0, string_0, vector2_0 + _uuxIgLNZfbTGY9x4ooLT87m96Af * 1f, Color.Black);
		spriteBatch_0.DrawString(spriteFont_0, string_0, vector2_0 + _bjsdlsFeEOX4MW8FjwWgpqNVDB9 * 1f, Color.Black);
		spriteBatch_0.DrawString(spriteFont_0, string_0, vector2_0 + _T4uXnm9GBQwqdGXwNMjF6znSKbD * 1f, Color.Black);
		spriteBatch_0.DrawString(spriteFont_0, string_0, vector2_0, color_0);
	}

	public static void _f5ctqAmdNsZ889UjM4LxDm8WGxA(this SpriteBatch spriteBatch_0, Texture2D texture2D_0, Vector2? nullable_0 = null, Rectangle? nullable_1 = null, Rectangle? nullable_2 = null, Vector2? nullable_3 = null, float float_0 = 0f, Vector2? nullable_4 = null, Color? nullable_5 = null, SpriteEffects spriteEffects_0 = SpriteEffects.None, float float_1 = 0f)
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
				spriteBatch_0.Draw(texture2D_0, nullable_0.Value, nullable_2, nullable_5.Value, float_0, nullable_3.Value, nullable_4.Value, spriteEffects_0, float_1);
			}
			else
			{
				spriteBatch_0.Draw(texture2D_0, nullable_1.Value, nullable_2, nullable_5.Value, float_0, nullable_3.Value, spriteEffects_0, float_1);
			}
			return;
		}
		throw new InvalidOperationException("Expected drawRectangle or position, but received neither or both.");
	}

	public static void _g9Sx54kMPiHz5jrqWh4Kb1pTijH(this SpriteBatch spriteBatch_0, SpriteSortMode spriteSortMode_0 = SpriteSortMode.Deferred, BlendState blendState_0 = null, SamplerState samplerState_0 = null, DepthStencilState depthStencilState_0 = null, RasterizerState rasterizerState_0 = null, Effect effect_0 = null, Matrix? nullable_0 = null)
	{
		blendState_0 = blendState_0 ?? BlendState.AlphaBlend;
		samplerState_0 = samplerState_0 ?? SamplerState.LinearClamp;
	}

	static void smethod_0(SpriteBatch spriteBatch_0, SpriteFont spriteFont_0, string string_0, Vector2 vector2_0, Color color_0)
	{
		spriteBatch_0.DrawString(spriteFont_0, string_0, vector2_0, color_0);
	}

	static InvalidOperationException smethod_1(string string_0)
	{
		return new InvalidOperationException(string_0);
	}

	static void smethod_2(SpriteBatch spriteBatch_0, Texture2D texture2D_0, Vector2 vector2_0, Rectangle? nullable_0, Color color_0, float float_0, Vector2 vector2_1, Vector2 vector2_2, SpriteEffects spriteEffects_0, float float_1)
	{
		spriteBatch_0.Draw(texture2D_0, vector2_0, nullable_0, color_0, float_0, vector2_1, vector2_2, spriteEffects_0, float_1);
	}

	static void smethod_3(SpriteBatch spriteBatch_0, Texture2D texture2D_0, Rectangle rectangle_0, Rectangle? nullable_0, Color color_0, float float_0, Vector2 vector2_0, SpriteEffects spriteEffects_0, float float_1)
	{
		spriteBatch_0.Draw(texture2D_0, rectangle_0, nullable_0, color_0, float_0, vector2_0, spriteEffects_0, float_1);
	}

	static void smethod_4(SpriteBatch spriteBatch_0, SpriteSortMode spriteSortMode_0, BlendState blendState_0, SamplerState samplerState_0, DepthStencilState depthStencilState_0, RasterizerState rasterizerState_0, Effect effect_0, Matrix matrix_0)
	{
		spriteBatch_0.Begin(spriteSortMode_0, blendState_0, samplerState_0, depthStencilState_0, rasterizerState_0, effect_0, matrix_0);
	}
}
