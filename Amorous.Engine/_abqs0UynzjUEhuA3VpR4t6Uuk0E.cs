using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Squid;

public class _abqs0UynzjUEhuA3VpR4t6Uuk0E : _1dTaaW9MQWoHm2Pqblg0u9bPhpe
{
	private string _eNqfeKhXj4x1FkHQitvzRQ1JLSE;

	private Vector2 _0IQKqP6KjSSBSTlZR0Y2K1CamuH;

	private Vector2 _zqzgCa0m3Wy0XOFPjEWDVqp6Ybb;

	public SpriteFont _UlZpHdih1X5ig1k6QjZ497jtA1A { get; private set; }

	public string _K87Hdb6ToAR0us3tN3ZmvHdPdeJ
	{
		get
		{
			return _eNqfeKhXj4x1FkHQitvzRQ1JLSE;
		}
		set
		{
			_eNqfeKhXj4x1FkHQitvzRQ1JLSE = value;
			if (string.IsNullOrEmpty(_eNqfeKhXj4x1FkHQitvzRQ1JLSE))
			{
				_0IQKqP6KjSSBSTlZR0Y2K1CamuH = Vector2.Zero;
			}
			else
			{
				_0IQKqP6KjSSBSTlZR0Y2K1CamuH = _UlZpHdih1X5ig1k6QjZ497jtA1A.MeasureString(_eNqfeKhXj4x1FkHQitvzRQ1JLSE);
			}
		}
	}

	public Alignment _Jqhiw18E7t7bvnwwzxO89bHpPnL { get; set; }

	public _abqs0UynzjUEhuA3VpR4t6Uuk0E(SpriteFont spriteFont_0, string string_0, Color color_0)
	{
		_UlZpHdih1X5ig1k6QjZ497jtA1A = spriteFont_0;
		_K87Hdb6ToAR0us3tN3ZmvHdPdeJ = string_0;
		_9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = color_0;
	}

	public override void _eJedLbGgSejIX7Xyx6RoIYD1soJA()
	{
	}

	public override void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0)
	{
		if (!string.IsNullOrEmpty(_K87Hdb6ToAR0us3tN3ZmvHdPdeJ))
		{
			switch (_Jqhiw18E7t7bvnwwzxO89bHpPnL)
			{
			case Alignment.MiddleRight:
				_zqzgCa0m3Wy0XOFPjEWDVqp6Ybb.X = (float)base._7Xn1C5tjYnmIif1iZKV8AWsEEbL - _0IQKqP6KjSSBSTlZR0Y2K1CamuH.X;
				_zqzgCa0m3Wy0XOFPjEWDVqp6Ybb.Y = (float)base._bCjZ3VSXGKyhmykd2zCnQBiSpDf + ((float)_2psWLw4AI8EIjQzaXnhGg8M1FnaA.Height - _0IQKqP6KjSSBSTlZR0Y2K1CamuH.Y) / 2f;
				break;
			default:
				_zqzgCa0m3Wy0XOFPjEWDVqp6Ybb.X = (float)base._7Xn1C5tjYnmIif1iZKV8AWsEEbL + ((float)_2psWLw4AI8EIjQzaXnhGg8M1FnaA.Width - _0IQKqP6KjSSBSTlZR0Y2K1CamuH.X) / 2f;
				_zqzgCa0m3Wy0XOFPjEWDVqp6Ybb.Y = (float)base._bCjZ3VSXGKyhmykd2zCnQBiSpDf + ((float)_2psWLw4AI8EIjQzaXnhGg8M1FnaA.Height - _0IQKqP6KjSSBSTlZR0Y2K1CamuH.Y) / 2f;
				break;
			case Alignment.MiddleLeft:
				_zqzgCa0m3Wy0XOFPjEWDVqp6Ybb.X = base._7Xn1C5tjYnmIif1iZKV8AWsEEbL;
				_zqzgCa0m3Wy0XOFPjEWDVqp6Ybb.Y = (float)base._bCjZ3VSXGKyhmykd2zCnQBiSpDf + ((float)_2psWLw4AI8EIjQzaXnhGg8M1FnaA.Height - _0IQKqP6KjSSBSTlZR0Y2K1CamuH.Y) / 2f;
				break;
			}
			spriteBatch_0._FY70IFLoBond3ORPe0ndCLvIeVcA(_UlZpHdih1X5ig1k6QjZ497jtA1A, _eNqfeKhXj4x1FkHQitvzRQ1JLSE, _zqzgCa0m3Wy0XOFPjEWDVqp6Ybb, _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA);
		}
	}

	static bool smethod_0(string string_0)
	{
		return string.IsNullOrEmpty(string_0);
	}

	static Vector2 smethod_1(SpriteFont spriteFont_0, string string_0)
	{
		return spriteFont_0.MeasureString(string_0);
	}
}
