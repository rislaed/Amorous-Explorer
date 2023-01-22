using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class _Z6EKIW3ycAwV2npYuxbFLcnCTrJ
{
	private static _Z6EKIW3ycAwV2npYuxbFLcnCTrJ _6T55wit7MiGfAWRkPwjNbJ8N8lG;

	public static _Z6EKIW3ycAwV2npYuxbFLcnCTrJ _yuFBJdi7mxrwMFQ57BjLjSq6ESj => _6T55wit7MiGfAWRkPwjNbJ8N8lG;

	public _21uBmerICJi18moE2gpxlEipBgz _mW1Z69pRB1eedGT3FSmdItJre5Y { get; private set; }

	public _opIJo2jLUqdOL5yAFP4yzXce0DG _Hnb6mPvrZFgOMCIApIeMW88jSsF { get; set; }

	public _Z6EKIW3ycAwV2npYuxbFLcnCTrJ()
	{
		_6T55wit7MiGfAWRkPwjNbJ8N8lG = this;
		_Hnb6mPvrZFgOMCIApIeMW88jSsF = new _opIJo2jLUqdOL5yAFP4yzXce0DG();
	}

	public void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		if (_mW1Z69pRB1eedGT3FSmdItJre5Y != null)
		{
			_mW1Z69pRB1eedGT3FSmdItJre5Y._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
		}
	}

	public void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0, Effect effect_0 = null)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (_mW1Z69pRB1eedGT3FSmdItJre5Y != null)
		{
			spriteBatch_0._g9Sx54kMPiHz5jrqWh4Kb1pTijH((SpriteSortMode)1, null, null, null, null, null, Matrix.CreateRotationZ(MathHelper.ToRadians(0f)));
			if (effect_0 != null)
			{
				effect_0.get_CurrentTechnique().get_Passes().get_Item(0)
					.Apply();
			}
			_mW1Z69pRB1eedGT3FSmdItJre5Y._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0);
			spriteBatch_0.End();
		}
	}

	public static void _Wrz1IORok7yBtsQA3czQUmnP6Yl(_21uBmerICJi18moE2gpxlEipBgz _21uBmerICJi18moE2gpxlEipBgz_0)
	{
		_6T55wit7MiGfAWRkPwjNbJ8N8lG._mW1Z69pRB1eedGT3FSmdItJre5Y = _21uBmerICJi18moE2gpxlEipBgz_0;
		_21uBmerICJi18moE2gpxlEipBgz_0?._oD87G7SXjsTukw7IVWxVlVFEgvA(_6T55wit7MiGfAWRkPwjNbJ8N8lG._Hnb6mPvrZFgOMCIApIeMW88jSsF);
	}

	public static _opIJo2jLUqdOL5yAFP4yzXce0DG _dxo6sBOpjEUiw2JBMikbutXK44t()
	{
		return _6T55wit7MiGfAWRkPwjNbJ8N8lG._Hnb6mPvrZFgOMCIApIeMW88jSsF;
	}

	static float smethod_0(float float_0)
	{
		return MathHelper.ToRadians(float_0);
	}

	static EffectTechnique smethod_1(Effect effect_0)
	{
		return effect_0.get_CurrentTechnique();
	}

	static EffectPassCollection smethod_2(EffectTechnique effectTechnique_0)
	{
		return effectTechnique_0.get_Passes();
	}

	static EffectPass smethod_3(EffectPassCollection effectPassCollection_0, int int_0)
	{
		return effectPassCollection_0.get_Item(int_0);
	}

	static void smethod_4(EffectPass effectPass_0)
	{
		effectPass_0.Apply();
	}

	static void smethod_5(SpriteBatch spriteBatch_0)
	{
		spriteBatch_0.End();
	}
}
