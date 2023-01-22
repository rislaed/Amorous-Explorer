using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class _d4ad1i8rcZMvfN9iaxggA1KtVgx : _1dTaaW9MQWoHm2Pqblg0u9bPhpe
{
	private readonly Action _08zyjvaMqKYuX4vqqPYy5W1Cp9A;

	public Texture2D _eGxbzBRO3Gff6qF4UvzTSaP4XTl { get; private set; }

	public Texture2D _NsW6nQWUMy3K32z4OlInvOro6nF { get; private set; }

	public Color _cE3kSvrhsTV9gIQPkCoBhOFAs2c { get; set; }

	public _d4ad1i8rcZMvfN9iaxggA1KtVgx(Texture2D texture2D_0, Texture2D texture2D_1, Action action_0)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		_eGxbzBRO3Gff6qF4UvzTSaP4XTl = texture2D_0;
		_NsW6nQWUMy3K32z4OlInvOro6nF = texture2D_1;
		_cE3kSvrhsTV9gIQPkCoBhOFAs2c = Color.get_White();
		_08zyjvaMqKYuX4vqqPYy5W1Cp9A = action_0;
	}

	public override void _eJedLbGgSejIX7Xyx6RoIYD1soJA()
	{
		if (_08zyjvaMqKYuX4vqqPYy5W1Cp9A != null)
		{
			_08zyjvaMqKYuX4vqqPYy5W1Cp9A();
		}
	}

	public override void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (base._NUP8Fs8I7oMuI6vfg25DFKFlQqE)
		{
			_d4ad1i8rcZMvfN9iaxggA1KtVgx.smethod_0(spriteBatch_0, _NsW6nQWUMy3K32z4OlInvOro6nF ?? _eGxbzBRO3Gff6qF4UvzTSaP4XTl, _Jh6AK28sBy2bS8ZCoKHP3LX45Uk, _cE3kSvrhsTV9gIQPkCoBhOFAs2c);
		}
		_d4ad1i8rcZMvfN9iaxggA1KtVgx.smethod_0(spriteBatch_0, _eGxbzBRO3Gff6qF4UvzTSaP4XTl, _Jh6AK28sBy2bS8ZCoKHP3LX45Uk, _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA);
	}

	static void smethod_0(SpriteBatch spriteBatch_0, Texture2D texture2D_0, Vector2 vector2_0, Color color_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		spriteBatch_0.Draw(texture2D_0, vector2_0, color_0);
	}
}
