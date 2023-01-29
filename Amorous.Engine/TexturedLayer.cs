using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class TexturedLayer : AbstractLayer
{ // _uqydQVaCmCvK7zzWs5W4gZFpKBu
	public Texture2D Texture { get; private set; }
	public bool Flip { get; set; }

	public TexturedLayer(AbstractScene scene, string name, Texture2D texture2D)
		: base(scene, name)
	{
		Texture = texture2D;
		base.Width = texture2D.Width;
		base.Height = texture2D.Height;
	}

	public override void Update(GameTime gameTime) {}

	public override void Draw(SpriteBatch spriteBatch)
	{
		if (Color.A != 0)
		{
			spriteBatch.Draw(Texture, Location, null, Color, 0f, Vector2.Zero, Scale, Flip ? SpriteEffects.FlipHorizontally : SpriteEffects.None, 0f);
		}
	}

	public override void Remove()
	{
		base.Scene.Game.Content.Unload(Texture);
	}
}
