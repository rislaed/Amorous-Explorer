using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class _iHJrndJdM1jj9TEnuU3BvgdDuvf : _d4ad1i8rcZMvfN9iaxggA1KtVgx
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
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			_eNqfeKhXj4x1FkHQitvzRQ1JLSE = value;
			if (!string.IsNullOrEmpty(_eNqfeKhXj4x1FkHQitvzRQ1JLSE))
			{
				_0IQKqP6KjSSBSTlZR0Y2K1CamuH = _UlZpHdih1X5ig1k6QjZ497jtA1A.MeasureString(_eNqfeKhXj4x1FkHQitvzRQ1JLSE);
			}
			else
			{
				_0IQKqP6KjSSBSTlZR0Y2K1CamuH = Vector2.get_Zero();
			}
		}
	}

	public _iHJrndJdM1jj9TEnuU3BvgdDuvf(Texture2D texture2D_0, Texture2D texture2D_1, SpriteFont spriteFont_0, string string_0, Color color_0, Action action_0)
		: base(texture2D_0, texture2D_1, action_0)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		_UlZpHdih1X5ig1k6QjZ497jtA1A = spriteFont_0;
		_K87Hdb6ToAR0us3tN3ZmvHdPdeJ = string_0;
		_9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = color_0;
	}

	public override void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0)
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		base._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0);
		if (!string.IsNullOrEmpty(_K87Hdb6ToAR0us3tN3ZmvHdPdeJ))
		{
			_zqzgCa0m3Wy0XOFPjEWDVqp6Ybb.X = (float)base._7Xn1C5tjYnmIif1iZKV8AWsEEbL + ((float)_2psWLw4AI8EIjQzaXnhGg8M1FnaA.Width - _0IQKqP6KjSSBSTlZR0Y2K1CamuH.X) / 2f;
			_zqzgCa0m3Wy0XOFPjEWDVqp6Ybb.Y = (float)base._bCjZ3VSXGKyhmykd2zCnQBiSpDf + ((float)_2psWLw4AI8EIjQzaXnhGg8M1FnaA.Height - _0IQKqP6KjSSBSTlZR0Y2K1CamuH.Y) / 2f;
			spriteBatch_0._FY70IFLoBond3ORPe0ndCLvIeVcA(_UlZpHdih1X5ig1k6QjZ497jtA1A, _eNqfeKhXj4x1FkHQitvzRQ1JLSE, _zqzgCa0m3Wy0XOFPjEWDVqp6Ybb, _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA);
		}
	}

	static bool smethod_1(string string_0)
	{
		return string.IsNullOrEmpty(string_0);
	}

	static Vector2 smethod_2(SpriteFont spriteFont_0, string string_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return spriteFont_0.MeasureString(string_0);
	}
}
