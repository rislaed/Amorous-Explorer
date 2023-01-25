using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Spine;

namespace Amorous.Game.Sexscenes;

public class CensoredSexscene : _TwlwMC1hhdSzamwGWEBxuUkz1gH
{
	private class Particle
	{
		private const int _UxXe1ddUXYV0OcLhWHiKYTJ4pDc = 64;

		private const int _MuBaCWbggdeCgody902PC7mPx77 = 1080;

		private float _nD28BmrDaEzCHelTAa14TKyuSyG;

		private float _LkckKdvuh9GaAwn7XojfbJBd91r;

		private float _MnKzCyEExhWnbYODXLISlC7P0D9;

		private float _AQwQu1ldCtpbkD5F9oEByJdCnWaA;

		private float _u8pBof2EYEcHCEDxEtA27OOeLmVb;

		private float _vS7dI6rh0z8HEXKEL7oHBGUMNb4;

		private float _fEoXp8v9qmXyfxzaUZzMonygxpN;

		private float _SJ8FQp8xbJuebaQOrgLvEJN49JI;

		private float _eJdobumzbRJtj3Df3Y2IgIJQb0c;

		private float _rGcC4uzFv31JwubJhcgwuiNZiMh;

		public Particle()
		{
			ResetProgression();
		}

		private void ResetProgression()
		{
			_nD28BmrDaEzCHelTAa14TKyuSyG = _boyt8NIMtKsAGSTcjHeL0WMbFxs._07xTWbIEgzxJYsYwFKDbbKNvu4G(64, 1856);
			_LkckKdvuh9GaAwn7XojfbJBd91r = 1144f;
			_MnKzCyEExhWnbYODXLISlC7P0D9 = 0f;
			_AQwQu1ldCtpbkD5F9oEByJdCnWaA = 1f;
			_u8pBof2EYEcHCEDxEtA27OOeLmVb = _boyt8NIMtKsAGSTcjHeL0WMbFxs._S7DdtNZASTkc9riB27h5Ktq5VjDA(-10f, 10f);
			_vS7dI6rh0z8HEXKEL7oHBGUMNb4 = _boyt8NIMtKsAGSTcjHeL0WMbFxs._S7DdtNZASTkc9riB27h5Ktq5VjDA(128f, 256f);
			_fEoXp8v9qmXyfxzaUZzMonygxpN = _boyt8NIMtKsAGSTcjHeL0WMbFxs._S7DdtNZASTkc9riB27h5Ktq5VjDA(1f, 5f);
			_SJ8FQp8xbJuebaQOrgLvEJN49JI = _boyt8NIMtKsAGSTcjHeL0WMbFxs._S7DdtNZASTkc9riB27h5Ktq5VjDA(10f, 100f);
			_eJdobumzbRJtj3Df3Y2IgIJQb0c = _boyt8NIMtKsAGSTcjHeL0WMbFxs._S7DdtNZASTkc9riB27h5Ktq5VjDA(1f, 3f);
			_rGcC4uzFv31JwubJhcgwuiNZiMh = _boyt8NIMtKsAGSTcjHeL0WMbFxs._S7DdtNZASTkc9riB27h5Ktq5VjDA(0f, 1080f);
		}

		public void Update(float float_0)
		{
			_nD28BmrDaEzCHelTAa14TKyuSyG += (float)Math.Sin(_boyt8NIMtKsAGSTcjHeL0WMbFxs._AmIUCcrmrrQiiirja7DoiZSjXuv * _fEoXp8v9qmXyfxzaUZzMonygxpN) * (_SJ8FQp8xbJuebaQOrgLvEJN49JI * float_0);
			_LkckKdvuh9GaAwn7XojfbJBd91r -= _vS7dI6rh0z8HEXKEL7oHBGUMNb4 * float_0;
			if (_LkckKdvuh9GaAwn7XojfbJBd91r < _rGcC4uzFv31JwubJhcgwuiNZiMh)
			{
				_MnKzCyEExhWnbYODXLISlC7P0D9 += _vS7dI6rh0z8HEXKEL7oHBGUMNb4 * _eJdobumzbRJtj3Df3Y2IgIJQb0c * float_0;
				_AQwQu1ldCtpbkD5F9oEByJdCnWaA = 1f - _MnKzCyEExhWnbYODXLISlC7P0D9 / _rGcC4uzFv31JwubJhcgwuiNZiMh;
			}
			if (_LkckKdvuh9GaAwn7XojfbJBd91r + 64f < 0f || _AQwQu1ldCtpbkD5F9oEByJdCnWaA <= 0f)
			{
				ResetProgression();
			}
		}

		public void Draw(Texture2D texture2D_0, SpriteBatch spriteBatch_0)
		{
			spriteBatch_0.Draw(texture2D_0, new Rectangle((int)_nD28BmrDaEzCHelTAa14TKyuSyG, (int)_LkckKdvuh9GaAwn7XojfbJBd91r, 128, 128), null, Color.White * _AQwQu1ldCtpbkD5F9oEByJdCnWaA, MathHelper.ToRadians(_u8pBof2EYEcHCEDxEtA27OOeLmVb), new Vector2(64f, 64f), SpriteEffects.None, 0f);
		}
	}

	private const int _nqUCZ5ck6SfD47CNEeTDsDMAThLA = 10;

	private readonly List<Particle> _lpzETYXyRHxYihXrkJactMysoTi;

	private readonly Texture2D _tt9eBN54CTaryoKDBFZI2D44oni;

	private float _Ja1biX4ByqpjkgcLg9SPPz8y4itA;

	public CensoredSexscene(ContentManager contentManager_0, string string_0, string string_1, string string_2 = null, float float_0 = 1f, bool bool_0 = true, List<SkeletonJson.SpineEvent> list_0 = null, _sa8EsNgk4VDRaASdXE7VprdlNlg _sa8EsNgk4VDRaASdXE7VprdlNlg_0 = null, float float_1 = 1000f)
		: base(contentManager_0, string_0, string_1, _iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF ? "Assets/SexScenes/Generic/Overlay" : string_2, float_0, bool_0, _iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF ? null : list_0, _sa8EsNgk4VDRaASdXE7VprdlNlg_0)
	{
		if (_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
		{
			_YDmx0efYtcyg4olWGsr0rBMkyjD = (_aElCqTEKQdwgSGVsOO7nt14UEsn = float_1);
			_lpzETYXyRHxYihXrkJactMysoTi = new List<Particle>();
			_tt9eBN54CTaryoKDBFZI2D44oni = contentManager_0.Load<Texture2D>("Assets/SexScenes/Generic/Heart");
			_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/Steampianist - O Morro Nao Tem Vez", 0.4f);
		}
	}

	public override void _WhR14B3jaJk70xEEeAkh2VLlhbA()
	{
		if (!_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
		{
			base._WhR14B3jaJk70xEEeAkh2VLlhbA();
		}
	}

	public override void _VandJrNHr65bKmzzmFYTOwD1icL()
	{
		if (!_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
		{
			base._VandJrNHr65bKmzzmFYTOwD1icL();
		}
	}

	public override void _4XV5xPzQUH5ABIwpxH3yf5EIAyL(int int_0, bool bool_0 = false)
	{
		if (!_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
		{
			base._4XV5xPzQUH5ABIwpxH3yf5EIAyL(int_0, bool_0);
		}
	}

	public override void _JHfBnmyItvKJDQtdUPp2yLsm4yR()
	{
		if (!_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
		{
			base._JHfBnmyItvKJDQtdUPp2yLsm4yR();
		}
	}

	public override void _oHE0dGUBNplXQia6K85vMaNc8jp()
	{
		if (!_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
		{
			base._oHE0dGUBNplXQia6K85vMaNc8jp();
		}
	}

	public override void _paoLItUYkFWaGSDnCAvBagJ1F5T()
	{
		if (!_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
		{
			base._paoLItUYkFWaGSDnCAvBagJ1F5T();
		}
	}

	public override void Update(GameTime gameTime_0)
	{
		base.Update(gameTime_0);
		if (!_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
		{
			return;
		}
		float num = (float)(gameTime_0.ElapsedGameTime.TotalMilliseconds / 1000.0);
		if (_lpzETYXyRHxYihXrkJactMysoTi.Count < 10)
		{
			_Ja1biX4ByqpjkgcLg9SPPz8y4itA -= num;
			if (_Ja1biX4ByqpjkgcLg9SPPz8y4itA < 0f)
			{
				_Ja1biX4ByqpjkgcLg9SPPz8y4itA = _boyt8NIMtKsAGSTcjHeL0WMbFxs._S7DdtNZASTkc9riB27h5Ktq5VjDA(0f, 1f);
				_lpzETYXyRHxYihXrkJactMysoTi.Add(new Particle());
			}
		}
		foreach (Particle item in _lpzETYXyRHxYihXrkJactMysoTi)
		{
			item.Update(num);
		}
	}

	public override void Draw(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0)
	{
		base.Draw(spriteBatch_0, skeletonMeshRenderer_0);
		if (!_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
		{
			return;
		}
		spriteBatch_0.Begin();
		foreach (Particle item in _lpzETYXyRHxYihXrkJactMysoTi)
		{
			item.Draw(_tt9eBN54CTaryoKDBFZI2D44oni, spriteBatch_0);
		}
		spriteBatch_0.End();
	}

	public override void _eXH4tq2J0DADXDLofA8G8Yw8fau(_qokIrmaaT3Lq6znW10HdrPUO9Fq _qokIrmaaT3Lq6znW10HdrPUO9Fq_0, bool bool_0)
	{
		if (!_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
		{
			base._eXH4tq2J0DADXDLofA8G8Yw8fau(_qokIrmaaT3Lq6znW10HdrPUO9Fq_0, bool_0);
		}
	}
}
