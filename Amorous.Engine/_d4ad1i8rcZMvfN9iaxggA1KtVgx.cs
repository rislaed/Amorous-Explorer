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
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			int num = -486871576;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9B7661DBu) % 5u)
				{
				case 4u:
					_cE3kSvrhsTV9gIQPkCoBhOFAs2c = Color.get_White();
					_08zyjvaMqKYuX4vqqPYy5W1Cp9A = action_0;
					num = (int)(num2 * 1929541771) ^ -1544455783;
					continue;
				case 2u:
					_eGxbzBRO3Gff6qF4UvzTSaP4XTl = texture2D_0;
					num = (int)(num2 * 1644369189) ^ -2135781371;
					continue;
				case 1u:
					_NsW6nQWUMy3K32z4OlInvOro6nF = texture2D_1;
					num = (int)(num2 * 1624719984) ^ -409564578;
					continue;
				default:
					return;
				case 3u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public override void _eJedLbGgSejIX7Xyx6RoIYD1soJA()
	{
		if (_08zyjvaMqKYuX4vqqPYy5W1Cp9A == null)
		{
			return;
		}
		while (true)
		{
			int num = -1067847265;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA4F83AF4u) % 3u)
				{
				case 1u:
					goto IL_000a;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_000a:
				_08zyjvaMqKYuX4vqqPYy5W1Cp9A();
				num = (int)(num2 * 1350337464) ^ -1528613339;
			}
		}
	}

	public override void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if (base._NUP8Fs8I7oMuI6vfg25DFKFlQqE)
		{
			while (true)
			{
				int num = 1806039602;
				while (true)
				{
					switch ((uint)(num ^ 0x7DB1F355) % 4u)
					{
					case 3u:
						_d4ad1i8rcZMvfN9iaxggA1KtVgx.smethod_0(spriteBatch_0, _NsW6nQWUMy3K32z4OlInvOro6nF ?? _eGxbzBRO3Gff6qF4UvzTSaP4XTl, _Jh6AK28sBy2bS8ZCoKHP3LX45Uk, _cE3kSvrhsTV9gIQPkCoBhOFAs2c);
						num = 1645557692;
						continue;
					case 0u:
						break;
					case 1u:
						return;
					default:
						goto end_IL_0050;
					}
					break;
				}
				continue;
				end_IL_0050:
				break;
			}
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
