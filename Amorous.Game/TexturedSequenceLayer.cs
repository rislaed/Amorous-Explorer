using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class TexturedSequenceLayer : AbstractLayer
{ // _Yu3OngEjZbsgelWEySu6GE7aoYg
	private int _state;

	public Texture2D[] Textures { get; private set; }

	public int State
	{
		get
		{
			return _state;
		}
		set
		{
			if (value < 0)
			{
				_state = 0;
			}
			else if (value < Textures.Length)
			{
				_state = value;
			}
			else
			{
				_state = Textures.Length - 1;
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
			base.Scene.Game.Content.Unload(texture);
		}
	}
}
