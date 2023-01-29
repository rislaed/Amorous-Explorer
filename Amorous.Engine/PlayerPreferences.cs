using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class PlayerPreferences
{ // _Z6EKIW3ycAwV2npYuxbFLcnCTrJ
	private static PlayerPreferences _singleton;
	public static PlayerPreferences Singleton => _singleton;
	public AbstractPlayerSkin PlayerSkin { get; private set; }
	public PlayerData Data { get; set; }

	public PlayerPreferences()
	{
		_singleton = this;
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
		_singleton.PlayerSkin = skin;
		skin?.Initialize(_singleton.Data);
	}

	public static PlayerData GetPlayerData()
	{
		return _singleton.Data;
	}
}
