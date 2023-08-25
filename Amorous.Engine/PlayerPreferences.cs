using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class PlayerPreferences
{ // _Z6EKIW3ycAwV2npYuxbFLcnCTrJ
	private static PlayerPreferences singleton;

	public static PlayerPreferences Singleton => singleton;
	public AbstractPlayerOverlay PlayerOverlay { get; private set; }
	public PlayerData Data { get; set; }

	public PlayerPreferences()
	{
		singleton = this;
		Data = new PlayerData();
	}

	public void Update(GameTime gameTime)
	{
		if (PlayerOverlay != null)
		{
			PlayerOverlay.Update(gameTime);
		}
	}

	public void Draw(SpriteBatch spriteBatch, Effect effect = null)
	{
		if (PlayerOverlay != null)
		{
			spriteBatch.Begin(SpriteSortMode.Immediate, null, null, null, null, null, Matrix.CreateRotationZ(MathHelper.ToRadians(0f)));
			effect?.CurrentTechnique.Passes[0].Apply();
			PlayerOverlay.Draw(spriteBatch);
			spriteBatch.End();
		}
	}

	public static void SetPlayerOverlay(AbstractPlayerOverlay skin)
	{
		singleton.PlayerOverlay = skin;
		skin?.Initialize(singleton.Data);
	}

	public static PlayerData GetPlayerData()
	{
		return singleton.Data;
	}
}
