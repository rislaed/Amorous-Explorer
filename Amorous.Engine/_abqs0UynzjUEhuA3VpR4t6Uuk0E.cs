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
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			_eNqfeKhXj4x1FkHQitvzRQ1JLSE = value;
			if (_abqs0UynzjUEhuA3VpR4t6Uuk0E.smethod_0(_eNqfeKhXj4x1FkHQitvzRQ1JLSE))
			{
				_0IQKqP6KjSSBSTlZR0Y2K1CamuH = Vector2.get_Zero();
			}
			else
			{
				_0IQKqP6KjSSBSTlZR0Y2K1CamuH = _abqs0UynzjUEhuA3VpR4t6Uuk0E.smethod_1(_UlZpHdih1X5ig1k6QjZ497jtA1A, _eNqfeKhXj4x1FkHQitvzRQ1JLSE);
			}
		}
	}

	public Alignment _Jqhiw18E7t7bvnwwzxO89bHpPnL { get; set; }

	public _abqs0UynzjUEhuA3VpR4t6Uuk0E(SpriteFont spriteFont_0, string string_0, Color color_0)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		_UlZpHdih1X5ig1k6QjZ497jtA1A = spriteFont_0;
		_K87Hdb6ToAR0us3tN3ZmvHdPdeJ = string_0;
		_9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = color_0;
	}

	public override void _eJedLbGgSejIX7Xyx6RoIYD1soJA()
	{
	}

	public override void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		if (_abqs0UynzjUEhuA3VpR4t6Uuk0E.smethod_0(_K87Hdb6ToAR0us3tN3ZmvHdPdeJ))
		{
			return;
		}
		Alignment jqhiw18E7t7bvnwwzxO89bHpPnL = _Jqhiw18E7t7bvnwwzxO89bHpPnL;
		if ((int)jqhiw18E7t7bvnwwzxO89bHpPnL != 3)
		{
			if ((int)jqhiw18E7t7bvnwwzxO89bHpPnL == 5)
			{
				_zqzgCa0m3Wy0XOFPjEWDVqp6Ybb.X = (float)base._7Xn1C5tjYnmIif1iZKV8AWsEEbL - _0IQKqP6KjSSBSTlZR0Y2K1CamuH.X;
				_zqzgCa0m3Wy0XOFPjEWDVqp6Ybb.Y = (float)base._bCjZ3VSXGKyhmykd2zCnQBiSpDf + ((float)_2psWLw4AI8EIjQzaXnhGg8M1FnaA.Height - _0IQKqP6KjSSBSTlZR0Y2K1CamuH.Y) / 2f;
			}
			else
			{
				_zqzgCa0m3Wy0XOFPjEWDVqp6Ybb.X = (float)base._7Xn1C5tjYnmIif1iZKV8AWsEEbL + ((float)_2psWLw4AI8EIjQzaXnhGg8M1FnaA.Width - _0IQKqP6KjSSBSTlZR0Y2K1CamuH.X) / 2f;
				_zqzgCa0m3Wy0XOFPjEWDVqp6Ybb.Y = (float)base._bCjZ3VSXGKyhmykd2zCnQBiSpDf + ((float)_2psWLw4AI8EIjQzaXnhGg8M1FnaA.Height - _0IQKqP6KjSSBSTlZR0Y2K1CamuH.Y) / 2f;
			}
		}
		else
		{
			_zqzgCa0m3Wy0XOFPjEWDVqp6Ybb.X = base._7Xn1C5tjYnmIif1iZKV8AWsEEbL;
			_zqzgCa0m3Wy0XOFPjEWDVqp6Ybb.Y = (float)base._bCjZ3VSXGKyhmykd2zCnQBiSpDf + ((float)_2psWLw4AI8EIjQzaXnhGg8M1FnaA.Height - _0IQKqP6KjSSBSTlZR0Y2K1CamuH.Y) / 2f;
		}
		spriteBatch_0._FY70IFLoBond3ORPe0ndCLvIeVcA(_UlZpHdih1X5ig1k6QjZ497jtA1A, _eNqfeKhXj4x1FkHQitvzRQ1JLSE, _zqzgCa0m3Wy0XOFPjEWDVqp6Ybb, _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA);
	}

	static bool smethod_0(string string_0)
	{
		return string.IsNullOrEmpty(string_0);
	}

	static Vector2 smethod_1(SpriteFont spriteFont_0, string string_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return spriteFont_0.MeasureString(string_0);
	}
}
