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
		base._je8rVfyg4zywmqSi4Ozx1z7wJ4b = texture2D_0.get_Width();
		base._WJfGWBzn4wgdGBnMWRH2pcJ3AqH = texture2D_0.get_Height();
		_SKaBgAqgC6qHTij3x2KayGSk2CN = texture2D_1;
		_3aoBdJvXEwMLqtoffOySYmetk8t = string_1;
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		if (_82ZLcfxgln4iQYRfbAsVmIq3FRh && _nkzqFdEfDyLcyGikIKGcHjklI4y._xJZUPxDatEzfPQc0nRHR2D1Vwke)
		{
			_82ZLcfxgln4iQYRfbAsVmIq3FRh = false;
		}
	}

	public override void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (((Color)(ref _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA)).get_A() != 0)
		{
			Color val = (_3pSkuXQLrbxfnmDHjLbcxrYNIfk ? Color.get_Red() : _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA);
			if (_82ZLcfxgln4iQYRfbAsVmIq3FRh && _SKaBgAqgC6qHTij3x2KayGSk2CN != null)
			{
				spriteBatch_0.Draw(_SKaBgAqgC6qHTij3x2KayGSk2CN, _kz5s2TRb1G53tpCw2bp3WVpMCiJ, (Rectangle?)null, val, 0f, Vector2.get_Zero(), _fO7gSlrDDNMoHR4FO5QXAq8fUyA, (SpriteEffects)0, 0f);
			}
			else
			{
				spriteBatch_0.Draw(_Ko8EyRGBPblyaAEHREGGfcgE0A7, _Jh6AK28sBy2bS8ZCoKHP3LX45Uk, (Rectangle?)null, val, 0f, Vector2.get_Zero(), _fO7gSlrDDNMoHR4FO5QXAq8fUyA, (SpriteEffects)0, 0f);
			}
		}
	}

	public override bool _Hym13mjJB64DQkbAkEMmEae8pQdA()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		_nkzqFdEfDyLcyGikIKGcHjklI4y._zunSyHn4DekdA6CngP10dXcR1kq(_3aoBdJvXEwMLqtoffOySYmetk8t, string.Empty, Color.get_White());
		_82ZLcfxgln4iQYRfbAsVmIq3FRh = true;
		_3pSkuXQLrbxfnmDHjLbcxrYNIfk = false;
		return true;
	}

	public override void _dGJ5R083rg1lKbVYP4W1TUEBqoh()
	{
		_nkzqFdEfDyLcyGikIKGcHjklI4y._h0KfaNiikKlJV2KkRPIdVDKVJnC();
		_82ZLcfxgln4iQYRfbAsVmIq3FRh = false;
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
