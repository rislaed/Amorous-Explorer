using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class SpriteLayer : AbstractLayer
{ // _uqydQVaCmCvK7zzWs5W4gZFpKBu
	public Texture2D Texture { get; private set; }
	public bool Flip { get; set; }

	public SpriteLayer(AbstractScene scene, string name, Texture2D texture) : base(scene, name)
	{
		Texture = texture;
		base.Width = texture.Width;
		base.Height = texture.Height;
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
