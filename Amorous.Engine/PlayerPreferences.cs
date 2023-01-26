using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class PlayerPreferences
{
	private static PlayerPreferences Singleton;
	public static PlayerPreferences Self => Singleton;
	public AbstractPlayerSkin PlayerSkin { get; private set; }
	public PlayerData Data { get; set; }

	public PlayerPreferences()
	{
		Singleton = this;
		Data = new PlayerData();
	}

	public void Update(GameTime gameTime)
	{
		if (PlayerSkin != null)
		{
			PlayerSkin.Update(gameTime);
		}
	}

	public void Draw(SpriteBatch spriteBatch, Effect effect = null)
	{
		if (PlayerSkin != null)
		{
			spriteBatch.Begin(SpriteSortMode.Immediate, null, null, null, null, null, Matrix.CreateRotationZ(MathHelper.ToRadians(0f)));
			effect?.CurrentTechnique.Passes[0].Apply();
			PlayerSkin.Draw(spriteBatch);
			spriteBatch.End();
		}
	}

	public static void SetPlayerSkin(AbstractPlayerSkin skin)
	{
		Singleton.PlayerSkin = skin;
		skin?.Initialize(Singleton.Data);
	}

	public static PlayerData GetPlayerData()
	{
		return Singleton.Data;
	}
}
