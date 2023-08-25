using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class DeviationLayer : AbstractLayer
{ // _C9DhEciuJHkReX4htI9sP6cbqzF
	private float degrees;
	private readonly Vector2 origin;

	public Texture2D Texture { get; private set; }
	public float Speed { get; private set; }

	public DeviationLayer(AbstractScene scene, string name, Texture2D texture2D, float speed, Vector2 origin) : base(scene, name)
	{
		Texture = texture2D;
		Speed = speed;
		base.Width = texture2D.Width;
		base.Height = texture2D.Height;
		degrees = 0f;
		this.origin = origin;
	}

	public override void Update(GameTime gameTime)
	{
		degrees += (float)gameTime.ElapsedGameTime.Milliseconds / 1000f * Speed;
		if (degrees <= 360f)
		{
			if (degrees < -360f)
			{
				degrees += 360f;
			}
		}
		else
		{
			degrees -= 360f;
		}
	}

	public override void Draw(SpriteBatch spriteBatch)
	{
		if (Color.A != 0)
		{
			spriteBatch.Draw(Texture, Location + origin, null, Color, degrees, origin, Scale, SpriteEffects.None, 0f);
		}
	}
}
