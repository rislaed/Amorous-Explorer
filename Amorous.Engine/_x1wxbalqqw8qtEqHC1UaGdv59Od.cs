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

	public _x1wxbalqqw8qtEqHC1UaGdv59Od(AbstractScene AbstractScene_0, string string_0, Texture2D texture2D_0, Texture2D texture2D_1, string string_1)
		: base(AbstractScene_0, string_0)
	{
		_Ko8EyRGBPblyaAEHREGGfcgE0A7 = texture2D_0;
		base.Width = texture2D_0.Width;
		base.Height = texture2D_0.Height;
		_SKaBgAqgC6qHTij3x2KayGSk2CN = texture2D_1;
		_3aoBdJvXEwMLqtoffOySYmetk8t = string_1;
	}

	public override void Update(GameTime gameTime_0)
	{
		if (_82ZLcfxgln4iQYRfbAsVmIq3FRh && _nkzqFdEfDyLcyGikIKGcHjklI4y._xJZUPxDatEzfPQc0nRHR2D1Vwke)
		{
			_82ZLcfxgln4iQYRfbAsVmIq3FRh = false;
		}
	}

	public override void Draw(SpriteBatch spriteBatch_0)
	{
		if (Color.A != 0)
		{
			Color color = (_3pSkuXQLrbxfnmDHjLbcxrYNIfk ? Color.Red : Color);
			if (_82ZLcfxgln4iQYRfbAsVmIq3FRh && _SKaBgAqgC6qHTij3x2KayGSk2CN != null)
			{
				spriteBatch_0.Draw(_SKaBgAqgC6qHTij3x2KayGSk2CN, _kz5s2TRb1G53tpCw2bp3WVpMCiJ, null, color, 0f, Vector2.Zero, _fO7gSlrDDNMoHR4FO5QXAq8fUyA, SpriteEffects.None, 0f);
			}
			else
			{
				spriteBatch_0.Draw(_Ko8EyRGBPblyaAEHREGGfcgE0A7, _Jh6AK28sBy2bS8ZCoKHP3LX45Uk, null, color, 0f, Vector2.Zero, _fO7gSlrDDNMoHR4FO5QXAq8fUyA, SpriteEffects.None, 0f);
			}
		}
	}

	public override bool _Hym13mjJB64DQkbAkEMmEae8pQdA()
	{
		_nkzqFdEfDyLcyGikIKGcHjklI4y._zunSyHn4DekdA6CngP10dXcR1kq(_3aoBdJvXEwMLqtoffOySYmetk8t, string.Empty, Color.White);
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
}
