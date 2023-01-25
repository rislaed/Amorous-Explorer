using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Spine;

public abstract class _TwlwMC1hhdSzamwGWEBxuUkz1gH
{
	public enum _qokIrmaaT3Lq6znW10HdrPUO9Fq
	{
		Idle,
		Slow,
		Medium,
		Fast
	}

	public const string _uZ8s9eCIF7ecDGgHoPruspmqVUJ = "ThrustStart";

	public const string _4cR8XWkrHH6NLb3ZggGgw492QLF = "ThrustEnd";

	public const string _NlwZaoHP1dlYYsTAbtkciLmBUXz = "Moan";

	public const float _Ap0bkSLhWrrxlKaEFXIgx0iNEUT = 2000f;

	public const float _0OhZLFF4jAAH0kqlwSk7XeIi07d = 1000f;

	public const float _TUcBMlrwO7kkqEYn0oA8PsLcHcT = 500f;

	public const float _rjOXv0iiuHbgiLNxZjbdCxt5izn = 300f;

	protected float _YDmx0efYtcyg4olWGsr0rBMkyjD = 1000f;

	protected float _aElCqTEKQdwgSGVsOO7nt14UEsn = 1000f;

	private float _OnzebJryHIHB0leF5LxtbJwFXjr;

	private float _D5nVuTc7M3CvlN5bC8IzrFoWiPh;

	private int _sEncbVBa6dUb3TaptvXHIvnhfcT;

	private int _OzssjIfhUN4zR5TqbxpZGLEeF9B;

	private bool _DPxTb3eioTU27n7cqNVeQibO5FDb;

	public bool _7BfTap1TnZXk1aaAXnFODowTQCp { get; set; }

	public _nHdiyIURlAiaNZ8u6MKzxjcwnyL _1BgOJ3z4ZUXNS2L4JWf24pr41hB { get; private set; }

	public Texture2D _h29gtnqEWLAa5qsliRXuXiPwY2o { get; private set; }

	public Texture2D _XqJSGCmxFB8nW6I8Mf5NEZBQ0gG { get; protected set; }

	protected List<string> _DUynKBx2CM4riE68wCCfknspxeg { get; private set; }

	protected _sa8EsNgk4VDRaASdXE7VprdlNlg _wQSC6rD8bbXFvRxba0kr1RqxlOV { get; set; }

	protected ContentManager _uwNDZuqdFb9tyQtlQMxiz1DQ7x8 { get; set; }

	public _qokIrmaaT3Lq6znW10HdrPUO9Fq _rNGHguvWdrugQVL2AI6bMMKSORN { get; private set; }

	public bool _p3lU5oxIaFTVHUNFxJRnaHkXdsA { get; private set; }

	public string _jztzokSobPJKyleCHypP9HS4OhbA { get; set; }

	public Texture2D _1AqpgY4vB6ly5vxOay6j86rcIEo { get; set; }

	protected _TwlwMC1hhdSzamwGWEBxuUkz1gH(ContentManager contentManager_0, string string_0, string string_1, string string_2 = null, float float_0 = 1f, bool bool_0 = true, List<SkeletonJson.SpineEvent> list_0 = null, _sa8EsNgk4VDRaASdXE7VprdlNlg _sa8EsNgk4VDRaASdXE7VprdlNlg_0 = null)
	{
		_uwNDZuqdFb9tyQtlQMxiz1DQ7x8 = contentManager_0;
		_DUynKBx2CM4riE68wCCfknspxeg = new List<string>();
		_1BgOJ3z4ZUXNS2L4JWf24pr41hB = contentManager_0._7BVREQXEcBCieHb0qgaVDpUj1ni(string_0, float_0, bool_0, list_0);
		_wQSC6rD8bbXFvRxba0kr1RqxlOV = _sa8EsNgk4VDRaASdXE7VprdlNlg_0;
		if (list_0 != null)
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL nHdiyIURlAiaNZ8u6MKzxjcwnyL = _1BgOJ3z4ZUXNS2L4JWf24pr41hB;
			nHdiyIURlAiaNZ8u6MKzxjcwnyL._iUyagF1KTeSUlg0raFfzuot3CwC = (Action<string>)Delegate.Combine(nHdiyIURlAiaNZ8u6MKzxjcwnyL._iUyagF1KTeSUlg0raFfzuot3CwC, new Action<string>(_11Hsh7iMhdhIoawBk6ueRsmCarI));
		}
		_1BgOJ3z4ZUXNS2L4JWf24pr41hB._c4iC7y9v6xg7LpvjKIeUkOdZ3UF(0f);
		_WhR14B3jaJk70xEEeAkh2VLlhbA();
		_0cFb48aKbcbREkHm9Jwptl6r6Vi();
		_h29gtnqEWLAa5qsliRXuXiPwY2o = contentManager_0.Load<Texture2D>(string_1);
		if (!string.IsNullOrEmpty(string_2))
		{
			_XqJSGCmxFB8nW6I8Mf5NEZBQ0gG = contentManager_0.Load<Texture2D>(string_2);
		}
	}

	public void _0cFb48aKbcbREkHm9Jwptl6r6Vi()
	{
		PlayerData opIJo2jLUqdOL5yAFP4yzXce0DG_ = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
		_coudx6g9HL4THj8r5aYCDxaHH0I(opIJo2jLUqdOL5yAFP4yzXce0DG_);
	}

	private void _11Hsh7iMhdhIoawBk6ueRsmCarI(string string_0)
	{
		if (_7BfTap1TnZXk1aaAXnFODowTQCp || _wQSC6rD8bbXFvRxba0kr1RqxlOV == null)
		{
			return;
		}
		switch (string_0)
		{
		case "ThrustStart":
			_wQSC6rD8bbXFvRxba0kr1RqxlOV._VIy3F8sVuq5i8ygZ1laOvKez7fh._xDFlaclLtJxSUU63JEJALvRLdfe();
			break;
		case "ThrustEnd":
			switch (_rNGHguvWdrugQVL2AI6bMMKSORN)
			{
			case _qokIrmaaT3Lq6znW10HdrPUO9Fq.Slow:
				_wQSC6rD8bbXFvRxba0kr1RqxlOV._dsZlhJEYpq0xkgv0NEULe6dkmAe._xDFlaclLtJxSUU63JEJALvRLdfe();
				break;
			case _qokIrmaaT3Lq6znW10HdrPUO9Fq.Medium:
			case _qokIrmaaT3Lq6znW10HdrPUO9Fq.Fast:
				_wQSC6rD8bbXFvRxba0kr1RqxlOV._3pW8Mrovx9zKhcGTeZrWzvXeJ4h._xDFlaclLtJxSUU63JEJALvRLdfe();
				break;
			}
			break;
		case "Moan":
		{
			_qokIrmaaT3Lq6znW10HdrPUO9Fq qokIrmaaT3Lq6znW10HdrPUO9Fq = _rNGHguvWdrugQVL2AI6bMMKSORN;
			if (_DPxTb3eioTU27n7cqNVeQibO5FDb)
			{
				qokIrmaaT3Lq6znW10HdrPUO9Fq = _qokIrmaaT3Lq6znW10HdrPUO9Fq.Fast;
			}
			_sEncbVBa6dUb3TaptvXHIvnhfcT++;
			if (_sEncbVBa6dUb3TaptvXHIvnhfcT > _OzssjIfhUN4zR5TqbxpZGLEeF9B)
			{
				_OzssjIfhUN4zR5TqbxpZGLEeF9B = _boyt8NIMtKsAGSTcjHeL0WMbFxs._07xTWbIEgzxJYsYwFKDbbKNvu4G(1, 3);
				_sEncbVBa6dUb3TaptvXHIvnhfcT = 0;
				switch (qokIrmaaT3Lq6znW10HdrPUO9Fq)
				{
				case _qokIrmaaT3Lq6znW10HdrPUO9Fq.Idle:
					_wQSC6rD8bbXFvRxba0kr1RqxlOV._xk8tKI57uoSCbu9iZAwV41JAmAAA._xDFlaclLtJxSUU63JEJALvRLdfe();
					break;
				case _qokIrmaaT3Lq6znW10HdrPUO9Fq.Slow:
					_wQSC6rD8bbXFvRxba0kr1RqxlOV._BwqdE4SEYHPh05gSHa62KyXObx2._xDFlaclLtJxSUU63JEJALvRLdfe();
					break;
				case _qokIrmaaT3Lq6znW10HdrPUO9Fq.Medium:
					_wQSC6rD8bbXFvRxba0kr1RqxlOV._ZR6NLJd6Ya49CeydiEGSCyZeDUb._xDFlaclLtJxSUU63JEJALvRLdfe();
					break;
				case _qokIrmaaT3Lq6znW10HdrPUO9Fq.Fast:
					_wQSC6rD8bbXFvRxba0kr1RqxlOV._qNXThpU44xZknZwFt3xQG8NpINc._xDFlaclLtJxSUU63JEJALvRLdfe();
					break;
				}
			}
			break;
		}
		}
	}

	public virtual string[] _tCw3HO9jqoEm2Ad1hqdKsA8vS7b()
	{
		return new string[0];
	}

	public virtual void _GGyEXu1JJKcG2X3txvtCwyZAylK(string string_0)
	{
		_jztzokSobPJKyleCHypP9HS4OhbA = string_0;
	}

	protected virtual void _coudx6g9HL4THj8r5aYCDxaHH0I(PlayerData _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
	}

	public virtual void Update(GameTime gameTime_0)
	{
		if (_YDmx0efYtcyg4olWGsr0rBMkyjD < _aElCqTEKQdwgSGVsOO7nt14UEsn)
		{
			_YDmx0efYtcyg4olWGsr0rBMkyjD += (float)gameTime_0.ElapsedGameTime.TotalMilliseconds;
		}
		else if (_YDmx0efYtcyg4olWGsr0rBMkyjD > _aElCqTEKQdwgSGVsOO7nt14UEsn)
		{
			_YDmx0efYtcyg4olWGsr0rBMkyjD -= (float)gameTime_0.ElapsedGameTime.TotalMilliseconds;
		}
		if (_OnzebJryHIHB0leF5LxtbJwFXjr < _D5nVuTc7M3CvlN5bC8IzrFoWiPh)
		{
			_OnzebJryHIHB0leF5LxtbJwFXjr += (float)(gameTime_0.ElapsedGameTime.TotalMilliseconds * 0.0010000000474974513);
			foreach (string item in _DUynKBx2CM4riE68wCCfknspxeg)
			{
				_1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ(item, _OnzebJryHIHB0leF5LxtbJwFXjr);
			}
			if (_OnzebJryHIHB0leF5LxtbJwFXjr > _D5nVuTc7M3CvlN5bC8IzrFoWiPh)
			{
				_OnzebJryHIHB0leF5LxtbJwFXjr = _D5nVuTc7M3CvlN5bC8IzrFoWiPh;
			}
		}
		else if (_OnzebJryHIHB0leF5LxtbJwFXjr > _D5nVuTc7M3CvlN5bC8IzrFoWiPh)
		{
			_OnzebJryHIHB0leF5LxtbJwFXjr -= (float)(gameTime_0.ElapsedGameTime.TotalMilliseconds * 0.0010000000474974513);
			foreach (string item2 in _DUynKBx2CM4riE68wCCfknspxeg)
			{
				_1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ(item2, _OnzebJryHIHB0leF5LxtbJwFXjr);
			}
			if (_OnzebJryHIHB0leF5LxtbJwFXjr < _D5nVuTc7M3CvlN5bC8IzrFoWiPh)
			{
				_OnzebJryHIHB0leF5LxtbJwFXjr = _D5nVuTc7M3CvlN5bC8IzrFoWiPh;
			}
		}
		_1BgOJ3z4ZUXNS2L4JWf24pr41hB.Update(gameTime_0, _YDmx0efYtcyg4olWGsr0rBMkyjD);
	}

	public virtual void Draw(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0)
	{
		if (_h29gtnqEWLAa5qsliRXuXiPwY2o != null)
		{
			spriteBatch_0.Begin();
			spriteBatch_0.Draw(_h29gtnqEWLAa5qsliRXuXiPwY2o, Vector2.Zero, Color.White);
			spriteBatch_0.End();
		}
		_1BgOJ3z4ZUXNS2L4JWf24pr41hB.Draw(skeletonMeshRenderer_0, _1AqpgY4vB6ly5vxOay6j86rcIEo);
		if (_XqJSGCmxFB8nW6I8Mf5NEZBQ0gG != null)
		{
			spriteBatch_0.Begin();
			spriteBatch_0.Draw(_XqJSGCmxFB8nW6I8Mf5NEZBQ0gG, Vector2.Zero, Color.White);
			spriteBatch_0.End();
		}
	}

	public virtual void _WhR14B3jaJk70xEEeAkh2VLlhbA()
	{
		_4XV5xPzQUH5ABIwpxH3yf5EIAyL(1, bool_0: true);
		_OnzebJryHIHB0leF5LxtbJwFXjr = 0f;
	}

	public virtual void _VandJrNHr65bKmzzmFYTOwD1icL()
	{
		if (_rNGHguvWdrugQVL2AI6bMMKSORN == _qokIrmaaT3Lq6znW10HdrPUO9Fq.Fast)
		{
			_oHE0dGUBNplXQia6K85vMaNc8jp();
		}
		else
		{
			_4XV5xPzQUH5ABIwpxH3yf5EIAyL(1);
		}
	}

	public virtual void _4XV5xPzQUH5ABIwpxH3yf5EIAyL(int int_0, bool bool_0 = false)
	{
		_rNGHguvWdrugQVL2AI6bMMKSORN = (_qokIrmaaT3Lq6znW10HdrPUO9Fq)(bool_0 ? int_0 : Math.Max(0, Math.Min((int)(_rNGHguvWdrugQVL2AI6bMMKSORN + int_0), 3)));
		switch (_rNGHguvWdrugQVL2AI6bMMKSORN)
		{
		case _qokIrmaaT3Lq6znW10HdrPUO9Fq.Idle:
			_aElCqTEKQdwgSGVsOO7nt14UEsn = 2000f;
			break;
		case _qokIrmaaT3Lq6znW10HdrPUO9Fq.Slow:
			_aElCqTEKQdwgSGVsOO7nt14UEsn = 1000f;
			break;
		case _qokIrmaaT3Lq6znW10HdrPUO9Fq.Medium:
			_aElCqTEKQdwgSGVsOO7nt14UEsn = 500f;
			break;
		case _qokIrmaaT3Lq6znW10HdrPUO9Fq.Fast:
			_aElCqTEKQdwgSGVsOO7nt14UEsn = 300f;
			break;
		}
	}

	public virtual void _JHfBnmyItvKJDQtdUPp2yLsm4yR()
	{
		_p3lU5oxIaFTVHUNFxJRnaHkXdsA = true;
		_D5nVuTc7M3CvlN5bC8IzrFoWiPh = 1f;
		_DPxTb3eioTU27n7cqNVeQibO5FDb = true;
		_sEncbVBa6dUb3TaptvXHIvnhfcT = _OzssjIfhUN4zR5TqbxpZGLEeF9B;
	}

	public virtual void _oHE0dGUBNplXQia6K85vMaNc8jp()
	{
		_p3lU5oxIaFTVHUNFxJRnaHkXdsA = true;
		_D5nVuTc7M3CvlN5bC8IzrFoWiPh = 1f;
		_DPxTb3eioTU27n7cqNVeQibO5FDb = true;
		_sEncbVBa6dUb3TaptvXHIvnhfcT = _OzssjIfhUN4zR5TqbxpZGLEeF9B;
		_4XV5xPzQUH5ABIwpxH3yf5EIAyL(0, bool_0: true);
	}

	public virtual void _paoLItUYkFWaGSDnCAvBagJ1F5T()
	{
		_p3lU5oxIaFTVHUNFxJRnaHkXdsA = false;
		_D5nVuTc7M3CvlN5bC8IzrFoWiPh = 0f;
		_DPxTb3eioTU27n7cqNVeQibO5FDb = false;
	}

	public virtual void _eXH4tq2J0DADXDLofA8G8Yw8fau(_qokIrmaaT3Lq6znW10HdrPUO9Fq _qokIrmaaT3Lq6znW10HdrPUO9Fq_0, bool bool_0)
	{
		_4XV5xPzQUH5ABIwpxH3yf5EIAyL((int)_qokIrmaaT3Lq6znW10HdrPUO9Fq_0, bool_0: true);
		if (bool_0)
		{
			_JHfBnmyItvKJDQtdUPp2yLsm4yR();
		}
	}
}
