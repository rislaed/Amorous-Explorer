using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class _z20t8IpBINiJtljSeTIkNoKUOkx : _ujAkjlfN5TywwbLAUDzPvtab6uJ
{
	private readonly Action _XvomzD7ydX2gHHhG6ti3fxsB4QF;

	private bool _3pSkuXQLrbxfnmDHjLbcxrYNIfk;

	public Texture2D _Ko8EyRGBPblyaAEHREGGfcgE0A7 { get; private set; }

	public _z20t8IpBINiJtljSeTIkNoKUOkx(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, Texture2D texture2D_0, Action action_0)
		: base(_7UlnfykmEmZDFt3BmCKZekI43Ih_0, string_0)
	{
		_Ko8EyRGBPblyaAEHREGGfcgE0A7 = texture2D_0;
		base._je8rVfyg4zywmqSi4Ozx1z7wJ4b = _z20t8IpBINiJtljSeTIkNoKUOkx.smethod_0(texture2D_0);
		base._WJfGWBzn4wgdGBnMWRH2pcJ3AqH = _z20t8IpBINiJtljSeTIkNoKUOkx.smethod_1(texture2D_0);
		_XvomzD7ydX2gHHhG6ti3fxsB4QF = action_0;
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
	}

	public override void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		if (((Color)(ref _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA)).get_A() != 0)
		{
			goto IL_000d;
		}
		goto IL_0052;
		IL_0052:
		int num = 1774413653;
		goto IL_0057;
		IL_0057:
		switch ((uint)(num ^ 0x1CE5B4E3) % 4u)
		{
		case 1u:
			break;
		case 3u:
			goto IL_0052;
		default:
			return;
		case 0u:
			return;
		case 2u:
			return;
		}
		goto IL_000d;
		IL_000d:
		spriteBatch_0.Draw(_Ko8EyRGBPblyaAEHREGGfcgE0A7, _Jh6AK28sBy2bS8ZCoKHP3LX45Uk, (Rectangle?)null, (!_3pSkuXQLrbxfnmDHjLbcxrYNIfk) ? _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA : Color.get_Red(), 0f, Vector2.get_Zero(), _fO7gSlrDDNMoHR4FO5QXAq8fUyA, (SpriteEffects)0, 0f);
		num = 411293779;
		goto IL_0057;
	}

	public override bool _Hym13mjJB64DQkbAkEMmEae8pQdA()
	{
		_3pSkuXQLrbxfnmDHjLbcxrYNIfk = false;
		while (true)
		{
			int num = 1643456827;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x37C734D0u) % 3u)
				{
				case 1u:
					goto IL_0009;
				case 0u:
					break;
				default:
					return true;
				}
				break;
				IL_0009:
				_XvomzD7ydX2gHHhG6ti3fxsB4QF();
				num = ((int)num2 * -1138882084) ^ -1498895106;
			}
		}
	}

	public override void _i3qb0SiBqvdxqp5NXIRGrNGErxh()
	{
		_3pSkuXQLrbxfnmDHjLbcxrYNIfk = true;
	}

	public override void _oc2Bt2sYu2e2W8gFbd4cz1hv2Fq()
	{
		_3pSkuXQLrbxfnmDHjLbcxrYNIfk = false;
	}

	static int smethod_0(Texture2D texture2D_0)
	{
		return texture2D_0.get_Width();
	}

	static int smethod_1(Texture2D texture2D_0)
	{
		return texture2D_0.get_Height();
	}
}
