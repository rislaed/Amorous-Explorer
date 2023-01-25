using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class _Z6EKIW3ycAwV2npYuxbFLcnCTrJ
{
	private static _Z6EKIW3ycAwV2npYuxbFLcnCTrJ _6T55wit7MiGfAWRkPwjNbJ8N8lG;

	public static _Z6EKIW3ycAwV2npYuxbFLcnCTrJ _yuFBJdi7mxrwMFQ57BjLjSq6ESj => _6T55wit7MiGfAWRkPwjNbJ8N8lG;

	public _21uBmerICJi18moE2gpxlEipBgz _mW1Z69pRB1eedGT3FSmdItJre5Y { get; private set; }

	public PlayerData Data { get; set; }

	public _Z6EKIW3ycAwV2npYuxbFLcnCTrJ()
	{
		_6T55wit7MiGfAWRkPwjNbJ8N8lG = this;
		Data = new PlayerData();
	}

	public void Update(GameTime gameTime_0)
	{
		if (_mW1Z69pRB1eedGT3FSmdItJre5Y != null)
		{
			_mW1Z69pRB1eedGT3FSmdItJre5Y.Update(gameTime_0);
		}
	}

	public void Draw(SpriteBatch spriteBatch_0, Effect effect_0 = null)
	{
		if (_mW1Z69pRB1eedGT3FSmdItJre5Y != null)
		{
			spriteBatch_0.Begin(SpriteSortMode.Immediate, null, null, null, null, null, Matrix.CreateRotationZ(MathHelper.ToRadians(0f)));
			effect_0?.CurrentTechnique.Passes[0].Apply();
			_mW1Z69pRB1eedGT3FSmdItJre5Y.Draw(spriteBatch_0);
			spriteBatch_0.End();
		}
	}

	public static void _Wrz1IORok7yBtsQA3czQUmnP6Yl(_21uBmerICJi18moE2gpxlEipBgz _21uBmerICJi18moE2gpxlEipBgz_0)
	{
		_6T55wit7MiGfAWRkPwjNbJ8N8lG._mW1Z69pRB1eedGT3FSmdItJre5Y = _21uBmerICJi18moE2gpxlEipBgz_0;
		_21uBmerICJi18moE2gpxlEipBgz_0?.Initialize(_6T55wit7MiGfAWRkPwjNbJ8N8lG.Data);
	}

	public static PlayerData _dxo6sBOpjEUiw2JBMikbutXK44t()
	{
		return _6T55wit7MiGfAWRkPwjNbJ8N8lG.Data;
	}
}
