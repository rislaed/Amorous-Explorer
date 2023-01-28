using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class DrawableLayer : AbstractLayer
{
	public Matrix AdditionalMatrix { get; set; }
	public Action<GameTime> OnUpdate { private get; set; }
	public Action<SpriteBatch> OnDraw { private get; set; }

	public DrawableLayer(AbstractScene scene, string name)
		: base(scene, name) {}

	public override void Update(GameTime gameTime)
	{
		OnUpdate?.Invoke(gameTime);
	}

	public override void Draw(SpriteBatch spriteBatch)
	{
		OnDraw?.Invoke(spriteBatch);
	}
}
