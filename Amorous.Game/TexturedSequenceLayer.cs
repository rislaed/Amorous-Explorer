using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

public class TexturedSequenceLayer : AbstractLayer
{
	private int Value;

	public Texture2D[] Textures { get; private set; }

	public int State
	{
		get
		{
			return Value;
		}
		set
		{
			if (value < 0)
			{
				Value = 0;
			}
			else if (value < Textures.Length)
			{
				Value = value;
			}
			else
			{
				Value = Textures.Length - 1;
			}
		}
	}

	public TexturedSequenceLayer(AbstractScene scene, string name, Texture2D[] textures)
		: base(scene, name)
	{
		Textures = textures;
	}

	public override void Update(GameTime gameTime) {}

	public override void Draw(SpriteBatch spriteBatch)
	{
		spriteBatch.Draw(Textures[State], Location, Color);
	}

	public override void Remove()
	{
		Texture2D[] textures = Textures;
		foreach (Texture2D texture in textures)
		{
			base.Scene.Game.Content._HXLRmt9GqcmA9GTG5xzRKNu3QpF(texture);
		}
	}
}
