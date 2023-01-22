using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class _x1wxbalqqw8qtEqHC1UaGdv59Od : _ujAkjlfN5TywwbLAUDzPvtab6uJ
{
	public Vector2 _kz5s2TRb1G53tpCw2bp3WVpMCiJ;

	private bool _3pSkuXQLrbxfnmDHjLbcxrYNIfk;

	private bool _82ZLcfxgln4iQYRfbAsVmIq3FRh;

	public Texture2D _Ko8EyRGBPblyaAEHREGGfcgE0A7 { get; private set; }

	public Texture2D _SKaBgAqgC6qHTij3x2KayGSk2CN { get; private set; }

	public string _3aoBdJvXEwMLqtoffOySYmetk8t { get; private set; }

	public float _KXMeX4w4QTfWkEcbYwnFrgl6iQA
	{
		get
		{
			return _kz5s2TRb1G53tpCw2bp3WVpMCiJ.X;
		}
		set
		{
			_kz5s2TRb1G53tpCw2bp3WVpMCiJ.X = value;
		}
	}

	public float _EKoZoehhAgIrqCfgZh148rtsqm
	{
		get
		{
			return _kz5s2TRb1G53tpCw2bp3WVpMCiJ.Y;
		}
		set
		{
			_kz5s2TRb1G53tpCw2bp3WVpMCiJ.Y = value;
		}
	}

	public _x1wxbalqqw8qtEqHC1UaGdv59Od(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, Texture2D texture2D_0, Texture2D texture2D_1, string string_1)
		: base(_7UlnfykmEmZDFt3BmCKZekI43Ih_0, string_0)
	{
		_Ko8EyRGBPblyaAEHREGGfcgE0A7 = texture2D_0;
		base._je8rVfyg4zywmqSi4Ozx1z7wJ4b = _x1wxbalqqw8qtEqHC1UaGdv59Od.smethod_0(texture2D_0);
		base._WJfGWBzn4wgdGBnMWRH2pcJ3AqH = _x1wxbalqqw8qtEqHC1UaGdv59Od.smethod_1(texture2D_0);
		_SKaBgAqgC6qHTij3x2KayGSk2CN = texture2D_1;
		_3aoBdJvXEwMLqtoffOySYmetk8t = string_1;
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		if (!_82ZLcfxgln4iQYRfbAsVmIq3FRh)
		{
			return;
		}
		while (true)
		{
			int num = -72800114;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDFEF9414u) % 4u)
				{
				case 2u:
				{
					int num3;
					int num4;
					if (!_nkzqFdEfDyLcyGikIKGcHjklI4y._xJZUPxDatEzfPQc0nRHR2D1Vwke)
					{
						num3 = -724028771;
						num4 = -724028771;
					}
					else
					{
						num3 = -1395667677;
						num4 = -1395667677;
					}
					num = num3 ^ ((int)num2 * -131713917);
					continue;
				}
				case 1u:
					_82ZLcfxgln4iQYRfbAsVmIq3FRh = false;
					num = ((int)num2 * -1272531554) ^ -812410627;
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public override void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		if (((Color)(ref _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA)).get_A() == 0)
		{
			goto IL_0065;
		}
		goto IL_0136;
		IL_0136:
		Color red;
		if (_3pSkuXQLrbxfnmDHjLbcxrYNIfk)
		{
			red = Color.get_Red();
			goto IL_0121;
		}
		int num = 1888429845;
		goto IL_00d4;
		IL_0065:
		num = 2109619121;
		goto IL_00d4;
		IL_00d4:
		Color val = default(Color);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x2533F86Eu) % 9u)
			{
			case 6u:
				spriteBatch_0.Draw(_Ko8EyRGBPblyaAEHREGGfcgE0A7, _Jh6AK28sBy2bS8ZCoKHP3LX45Uk, (Rectangle?)null, val, 0f, Vector2.get_Zero(), _fO7gSlrDDNMoHR4FO5QXAq8fUyA, (SpriteEffects)0, 0f);
				num = 2133762051;
				continue;
			case 5u:
				break;
			case 3u:
			{
				int num3;
				int num4;
				if (_SKaBgAqgC6qHTij3x2KayGSk2CN == null)
				{
					num3 = -1948402010;
					num4 = -1948402010;
				}
				else
				{
					num3 = -658348695;
					num4 = -658348695;
				}
				num = num3 ^ ((int)num2 * -801099432);
				continue;
			}
			case 0u:
				spriteBatch_0.Draw(_SKaBgAqgC6qHTij3x2KayGSk2CN, _kz5s2TRb1G53tpCw2bp3WVpMCiJ, (Rectangle?)null, val, 0f, Vector2.get_Zero(), _fO7gSlrDDNMoHR4FO5QXAq8fUyA, (SpriteEffects)0, 0f);
				num = ((int)num2 * -151409551) ^ -2036431957;
				continue;
			default:
				return;
			case 4u:
				goto IL_010a;
			case 1u:
				goto IL_0136;
			case 2u:
				return;
			case 7u:
				return;
			case 8u:
				return;
			}
			break;
		}
		goto IL_0065;
		IL_0121:
		val = red;
		int num5;
		if (_82ZLcfxgln4iQYRfbAsVmIq3FRh)
		{
			num = 1523992732;
			num5 = 1523992732;
		}
		else
		{
			num = 1099864982;
			num5 = 1099864982;
		}
		goto IL_00d4;
		IL_010a:
		red = _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA;
		goto IL_0121;
	}

	public override bool _Hym13mjJB64DQkbAkEMmEae8pQdA()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		_nkzqFdEfDyLcyGikIKGcHjklI4y._zunSyHn4DekdA6CngP10dXcR1kq(_3aoBdJvXEwMLqtoffOySYmetk8t, string.Empty, Color.get_White());
		while (true)
		{
			int num = -486186616;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCA4D7227u) % 4u)
				{
				case 3u:
					_82ZLcfxgln4iQYRfbAsVmIq3FRh = true;
					num = (int)(num2 * 1433417595) ^ -1985155324;
					continue;
				case 2u:
					_3pSkuXQLrbxfnmDHjLbcxrYNIfk = false;
					num = (int)((num2 * 1641151514) ^ 0x1CBB2716);
					continue;
				case 0u:
					break;
				default:
					return true;
				}
				break;
			}
		}
	}

	public override void _dGJ5R083rg1lKbVYP4W1TUEBqoh()
	{
		_nkzqFdEfDyLcyGikIKGcHjklI4y._h0KfaNiikKlJV2KkRPIdVDKVJnC();
		while (true)
		{
			int num = -1611264019;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC3D6E508u) % 3u)
				{
				case 2u:
					goto IL_0007;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0007:
				_82ZLcfxgln4iQYRfbAsVmIq3FRh = false;
				num = (int)((num2 * 963695813) ^ 0x7148C6FA);
			}
		}
	}

	public override void _i3qb0SiBqvdxqp5NXIRGrNGErxh()
	{
		if (!_82ZLcfxgln4iQYRfbAsVmIq3FRh)
		{
			_3pSkuXQLrbxfnmDHjLbcxrYNIfk = true;
		}
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
