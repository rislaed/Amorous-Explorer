using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Spine;

namespace Amorous.Game.Sexscenes;

public class CensoredSexscene : AbstractSexscene
{
	private class Particle
	{
		private const int _UxXe1ddUXYV0OcLhWHiKYTJ4pDc = 64;

		private const int _MuBaCWbggdeCgody902PC7mPx77 = 1080;

		private float _nD28BmrDaEzCHelTAa14TKyuSyG;

		private float _LkckKdvuh9GaAwn7XojfbJBd91r;

		private float _MnKzCyEExhWnbYODXLISlC7P0D9;

		private float _AQwQu1ldCtpbkD5F9oEByJdCnWaA;

		private float Deviation;

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
			_nD28BmrDaEzCHelTAa14TKyuSyG = Randoms.Next(64, 1856);
			_LkckKdvuh9GaAwn7XojfbJBd91r = 1144f;
			_MnKzCyEExhWnbYODXLISlC7P0D9 = 0f;
			_AQwQu1ldCtpbkD5F9oEByJdCnWaA = 1f;
			Deviation = Randoms.NextDouble(-10f, 10f);
			_vS7dI6rh0z8HEXKEL7oHBGUMNb4 = Randoms.NextDouble(128f, 256f);
			_fEoXp8v9qmXyfxzaUZzMonygxpN = Randoms.NextDouble(1f, 5f);
			_SJ8FQp8xbJuebaQOrgLvEJN49JI = Randoms.NextDouble(10f, 100f);
			_eJdobumzbRJtj3Df3Y2IgIJQb0c = Randoms.NextDouble(1f, 3f);
			_rGcC4uzFv31JwubJhcgwuiNZiMh = Randoms.NextDouble(0f, 1080f);
		}

		public void Update(float float_0)
		{
			_nD28BmrDaEzCHelTAa14TKyuSyG += (float)Math.Sin(Randoms.Time * _fEoXp8v9qmXyfxzaUZzMonygxpN) * (_SJ8FQp8xbJuebaQOrgLvEJN49JI * float_0);
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

		public void Draw(Texture2D texture2D_0, SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(texture2D_0, new Rectangle((int)_nD28BmrDaEzCHelTAa14TKyuSyG, (int)_LkckKdvuh9GaAwn7XojfbJBd91r, 128, 128), null, Color.White * _AQwQu1ldCtpbkD5F9oEByJdCnWaA, MathHelper.ToRadians(Deviation), new Vector2(64f, 64f), SpriteEffects.None, 0f);
		}
	}

	private const int _nqUCZ5ck6SfD47CNEeTDsDMAThLA = 10;

	private readonly List<Particle> _lpzETYXyRHxYihXrkJactMysoTi;
	private readonly Texture2D _tt9eBN54CTaryoKDBFZI2D44oni;
	private float _Ja1biX4ByqpjkgcLg9SPPz8y4itA;

	public CensoredSexscene(ContentManager content, string string_0, string string_1, string string_2 = null, float float_0 = 1f, bool bool_0 = true, List<SkeletonJson.SpineEvent> list_0 = null, _sa8EsNgk4VDRaASdXE7VprdlNlg _sa8EsNgk4VDRaASdXE7VprdlNlg_0 = null, float cycle = 1000f)
		: base(content, string_0, string_1, Censorship.Censored ? "Assets/SexScenes/Generic/Overlay" : string_2, float_0, bool_0, Censorship.Censored ? null : list_0, _sa8EsNgk4VDRaASdXE7VprdlNlg_0)
	{
		if (Censorship.Censored)
		{
			CycleTicks = (Cycle = cycle);
			_lpzETYXyRHxYihXrkJactMysoTi = new List<Particle>();
			_tt9eBN54CTaryoKDBFZI2D44oni = content.Load<Texture2D>("Assets/SexScenes/Generic/Heart");
			FadingMediaPlayer._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/Steampianist - O Morro Nao Tem Vez", 0.4f);
		}
	}

	public override void _WhR14B3jaJk70xEEeAkh2VLlhbA()
	{
		if (!Censorship.Censored)
		{
			base._WhR14B3jaJk70xEEeAkh2VLlhbA();
		}
	}

	public override void _VandJrNHr65bKmzzmFYTOwD1icL()
	{
		if (!Censorship.Censored)
		{
			base._VandJrNHr65bKmzzmFYTOwD1icL();
		}
	}

	public override void _4XV5xPzQUH5ABIwpxH3yf5EIAyL(int int_0, bool bool_0 = false)
	{
		if (!Censorship.Censored)
		{
			base._4XV5xPzQUH5ABIwpxH3yf5EIAyL(int_0, bool_0);
		}
	}

	public override void _JHfBnmyItvKJDQtdUPp2yLsm4yR()
	{
		if (!Censorship.Censored)
		{
			base._JHfBnmyItvKJDQtdUPp2yLsm4yR();
		}
	}

	public override void _oHE0dGUBNplXQia6K85vMaNc8jp()
	{
		if (!Censorship.Censored)
		{
			base._oHE0dGUBNplXQia6K85vMaNc8jp();
		}
	}

	public override void _paoLItUYkFWaGSDnCAvBagJ1F5T()
	{
		if (!Censorship.Censored)
		{
			base._paoLItUYkFWaGSDnCAvBagJ1F5T();
		}
	}

	public override void Update(GameTime gameTime)
	{
		base.Update(gameTime);
		if (!Censorship.Censored)
		{
			return;
		}
		float num = (float)(gameTime.ElapsedGameTime.TotalMilliseconds / 1000.0);
		if (_lpzETYXyRHxYihXrkJactMysoTi.Count < _nqUCZ5ck6SfD47CNEeTDsDMAThLA)
		{
			_Ja1biX4ByqpjkgcLg9SPPz8y4itA -= num;
			if (_Ja1biX4ByqpjkgcLg9SPPz8y4itA < 0f)
			{
				_Ja1biX4ByqpjkgcLg9SPPz8y4itA = Randoms.NextDouble(0f, 1f);
				_lpzETYXyRHxYihXrkJactMysoTi.Add(new Particle());
			}
		}
		foreach (Particle item in _lpzETYXyRHxYihXrkJactMysoTi)
		{
			item.Update(num);
		}
	}

	public override void Draw(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer)
	{
		base.Draw(spriteBatch, skeletonMeshRenderer);
		if (!Censorship.Censored)
		{
			return;
		}
		spriteBatch.Begin();
		foreach (Particle item in _lpzETYXyRHxYihXrkJactMysoTi)
		{
			item.Draw(_tt9eBN54CTaryoKDBFZI2D44oni, spriteBatch);
		}
		spriteBatch.End();
	}

	public override void _eXH4tq2J0DADXDLofA8G8Yw8fau(Phase Phase_0, bool bool_0)
	{
		if (!Censorship.Censored)
		{
			base._eXH4tq2J0DADXDLofA8G8Yw8fau(Phase_0, bool_0);
		}
	}
}
