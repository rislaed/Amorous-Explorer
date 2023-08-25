using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public static class SpriteBatchExtensions
{ // _dXVK1NWaxcsgYg6KpavA0e8oion
	public static readonly Vector2 OffsetLeftTop = new Vector2(-1f, -1f);
	public static readonly Vector2 OffsetTop = new Vector2(0f, -1f);
	public static readonly Vector2 OffsetRightTop = new Vector2(1f, -1f);
	public static readonly Vector2 OffsetLeft = new Vector2(-1f, 0f);
	public static readonly Vector2 OffsetRight = new Vector2(1f, 0f);
	public static readonly Vector2 OffsetLeftBottom = new Vector2(-1f, 1f);
	public static readonly Vector2 OffsetBottom = new Vector2(0f, 1f);
	public static readonly Vector2 OffsetRightBottom = new Vector2(1f, 1f);

	public const int SHADOW_SCALING = 1;

	public static void DrawString(this SpriteBatch spriteBatch, SpriteFont spriteFont, string text, Vector2 position, Color color)
	{
		spriteBatch.DrawString(spriteFont, text, position + OffsetLeftTop * (float)SHADOW_SCALING, Color.Black);
		spriteBatch.DrawString(spriteFont, text, position + OffsetTop * (float)SHADOW_SCALING, Color.Black);
		spriteBatch.DrawString(spriteFont, text, position + OffsetRightTop * (float)SHADOW_SCALING, Color.Black);
		spriteBatch.DrawString(spriteFont, text, position + OffsetLeft * (float)SHADOW_SCALING, Color.Black);
		spriteBatch.DrawString(spriteFont, text, position, Color.Black);
		spriteBatch.DrawString(spriteFont, text, position + OffsetRight * (float)SHADOW_SCALING, Color.Black);
		spriteBatch.DrawString(spriteFont, text, position + OffsetLeftBottom * (float)SHADOW_SCALING, Color.Black);
		spriteBatch.DrawString(spriteFont, text, position + OffsetBottom * (float)SHADOW_SCALING, Color.Black);
		spriteBatch.DrawString(spriteFont, text, position + OffsetRightBottom * (float)SHADOW_SCALING, Color.Black);
		spriteBatch.DrawString(spriteFont, text, position, color);
	}

	public static void Draw(this SpriteBatch spriteBatch, Texture2D texture, Vector2? drawRectangle = null, Rectangle? position = null, Rectangle? sourceRectangle = null, Vector2? scale = null, float rotation = 0f, Vector2? rotationBeyond = null, Color? color = null, SpriteEffects effects = SpriteEffects.None, float layerDepth = 0f)
	{
		if (!color.HasValue)
		{
			color = Color.White;
		}
		if (!scale.HasValue)
		{
			scale = Vector2.Zero;
		}
		if (!rotationBeyond.HasValue)
		{
			rotationBeyond = Vector2.One;
		}
		if (position.HasValue != drawRectangle.HasValue)
		{
			if (drawRectangle.HasValue)
			{
				spriteBatch.Draw(texture, drawRectangle.Value, sourceRectangle, color.Value, rotation, scale.Value, rotationBeyond.Value, effects, layerDepth);
			}
			else
			{
				spriteBatch.Draw(texture, position.Value, sourceRectangle, color.Value, rotation, scale.Value, effects, layerDepth);
			}
			return;
		}
		throw new InvalidOperationException("Expected drawRectangle or position, but received neither or both.");
	}

	public static void Begin(this SpriteBatch spriteBatch, SpriteSortMode sortMode = SpriteSortMode.Deferred, BlendState blendState = null, SamplerState samplerState = null, DepthStencilState depthStencilState = null, RasterizerState rasterizerState = null, Effect effect = null, Matrix? transformationMatrix = null)
	{
		blendState = blendState ?? BlendState.AlphaBlend;
		samplerState = samplerState ?? SamplerState.LinearClamp;
		if (transformationMatrix == null)
		{
			spriteBatch.Begin(sortMode, blendState, samplerState, depthStencilState, rasterizerState, effect);
		}
		else
		{
			spriteBatch.Begin(sortMode, blendState, samplerState, depthStencilState, rasterizerState, effect, (Matrix) transformationMatrix);
		}
	}
}
