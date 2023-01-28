using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Spine;

public abstract class AbstractSexscene
{
	public enum Phase
	{
		Idle,
		Slow,
		Medium,
		Fast
	}

	public const string _uZ8s9eCIF7ecDGgHoPruspmqVUJ = "ThrustStart";
	public const string _4cR8XWkrHH6NLb3ZggGgw492QLF = "ThrustEnd";
	public const string _NlwZaoHP1dlYYsTAbtkciLmBUXz = "Moan";

	public const float IdlePhase = 2000f;
	public const float SlowPhase = 1000f;
	public const float MediumPhase = 500f;
	public const float FastPhase = 300f;

	protected float CycleTicks = 1000f;
	protected float Cycle = 1000f;

	private float _OnzebJryHIHB0leF5LxtbJwFXjr;
	private float _D5nVuTc7M3CvlN5bC8IzrFoWiPh;
	private int _sEncbVBa6dUb3TaptvXHIvnhfcT;
	private int _OzssjIfhUN4zR5TqbxpZGLEeF9B;
	private bool _DPxTb3eioTU27n7cqNVeQibO5FDb;

	public bool _7BfTap1TnZXk1aaAXnFODowTQCp { get; set; }
	public SpineRenderer Spine { get; private set; }
	public Texture2D _h29gtnqEWLAa5qsliRXuXiPwY2o { get; private set; }
	public Texture2D _XqJSGCmxFB8nW6I8Mf5NEZBQ0gG { get; protected set; }

	protected List<string> Overlays { get; private set; }
	protected _sa8EsNgk4VDRaASdXE7VprdlNlg _wQSC6rD8bbXFvRxba0kr1RqxlOV { get; set; }
	protected ContentManager Content { get; set; }

	public Phase State { get; private set; }
	public bool Cumming { get; private set; }
	public string Variant { get; set; }
	public Texture2D Skin { get; set; }

	protected AbstractSexscene(ContentManager contentManager, string string_0, string string_1, string string_2 = null, float float_0 = 1f, bool bool_0 = true, List<SkeletonJson.SpineEvent> list_0 = null, _sa8EsNgk4VDRaASdXE7VprdlNlg _sa8EsNgk4VDRaASdXE7VprdlNlg_0 = null)
	{
		Content = contentManager;
		Overlays = new List<string>();
		Spine = contentManager.LoadSkeleton(string_0, float_0, bool_0, list_0);
		_wQSC6rD8bbXFvRxba0kr1RqxlOV = _sa8EsNgk4VDRaASdXE7VprdlNlg_0;
		if (list_0 != null)
		{
			SpineRenderer nHdiyIURlAiaNZ8u6MKzxjcwnyL = Spine;
			nHdiyIURlAiaNZ8u6MKzxjcwnyL.OnAnimationFrame = (Action<string>)Delegate.Combine(nHdiyIURlAiaNZ8u6MKzxjcwnyL.OnAnimationFrame, new Action<string>(_11Hsh7iMhdhIoawBk6ueRsmCarI));
		}
		Spine.SetVisibility(0f);
		_WhR14B3jaJk70xEEeAkh2VLlhbA();
		_0cFb48aKbcbREkHm9Jwptl6r6Vi();
		_h29gtnqEWLAa5qsliRXuXiPwY2o = contentManager.Load<Texture2D>(string_1);
		if (!string.IsNullOrEmpty(string_2))
		{
			_XqJSGCmxFB8nW6I8Mf5NEZBQ0gG = contentManager.Load<Texture2D>(string_2);
		}
	}

	public void _0cFb48aKbcbREkHm9Jwptl6r6Vi()
	{
		PlayerData data = PlayerPreferences.GetPlayerData();
		RefreshScene(data);
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
				switch (State)
				{
				case Phase.Slow:
					_wQSC6rD8bbXFvRxba0kr1RqxlOV._dsZlhJEYpq0xkgv0NEULe6dkmAe._xDFlaclLtJxSUU63JEJALvRLdfe();
					break;
				case Phase.Medium:
				case Phase.Fast:
					_wQSC6rD8bbXFvRxba0kr1RqxlOV._3pW8Mrovx9zKhcGTeZrWzvXeJ4h._xDFlaclLtJxSUU63JEJALvRLdfe();
					break;
				}
				break;
			case "Moan":
			{
				Phase qokIrmaaT3Lq6znW10HdrPUO9Fq = State;
				if (_DPxTb3eioTU27n7cqNVeQibO5FDb)
				{
					qokIrmaaT3Lq6znW10HdrPUO9Fq = Phase.Fast;
				}
				_sEncbVBa6dUb3TaptvXHIvnhfcT++;
				if (_sEncbVBa6dUb3TaptvXHIvnhfcT > _OzssjIfhUN4zR5TqbxpZGLEeF9B)
				{
					_OzssjIfhUN4zR5TqbxpZGLEeF9B = Randoms.Next(1, 3);
					_sEncbVBa6dUb3TaptvXHIvnhfcT = 0;
					switch (qokIrmaaT3Lq6znW10HdrPUO9Fq)
					{
						case Phase.Idle:
							_wQSC6rD8bbXFvRxba0kr1RqxlOV._xk8tKI57uoSCbu9iZAwV41JAmAAA._xDFlaclLtJxSUU63JEJALvRLdfe();
							break;
						case Phase.Slow:
							_wQSC6rD8bbXFvRxba0kr1RqxlOV._BwqdE4SEYHPh05gSHa62KyXObx2._xDFlaclLtJxSUU63JEJALvRLdfe();
							break;
						case Phase.Medium:
							_wQSC6rD8bbXFvRxba0kr1RqxlOV._ZR6NLJd6Ya49CeydiEGSCyZeDUb._xDFlaclLtJxSUU63JEJALvRLdfe();
							break;
						case Phase.Fast:
							_wQSC6rD8bbXFvRxba0kr1RqxlOV._qNXThpU44xZknZwFt3xQG8NpINc._xDFlaclLtJxSUU63JEJALvRLdfe();
							break;
					}
				}
				break;
			}
		}
	}

	public virtual string[] GetSkins()
	{
		return new string[0];
	}

	public virtual void SetSkin(string variant)
	{
		Variant = variant;
	}

	protected virtual void RefreshScene(PlayerData data)
	{
		// ?
	}

	public virtual void Update(GameTime gameTime)
	{
		if (CycleTicks < Cycle)
		{
			CycleTicks += (float)gameTime.ElapsedGameTime.TotalMilliseconds;
		}
		else if (CycleTicks > Cycle)
		{
			CycleTicks -= (float)gameTime.ElapsedGameTime.TotalMilliseconds;
		}
		if (_OnzebJryHIHB0leF5LxtbJwFXjr < _D5nVuTc7M3CvlN5bC8IzrFoWiPh)
		{
			_OnzebJryHIHB0leF5LxtbJwFXjr += (float)(gameTime.ElapsedGameTime.TotalMilliseconds * 0.0010000000474974513);
			foreach (string item in Overlays)
			{
				Spine.SetAlpha(item, _OnzebJryHIHB0leF5LxtbJwFXjr);
			}
			if (_OnzebJryHIHB0leF5LxtbJwFXjr > _D5nVuTc7M3CvlN5bC8IzrFoWiPh)
			{
				_OnzebJryHIHB0leF5LxtbJwFXjr = _D5nVuTc7M3CvlN5bC8IzrFoWiPh;
			}
		}
		else if (_OnzebJryHIHB0leF5LxtbJwFXjr > _D5nVuTc7M3CvlN5bC8IzrFoWiPh)
		{
			_OnzebJryHIHB0leF5LxtbJwFXjr -= (float)(gameTime.ElapsedGameTime.TotalMilliseconds * 0.0010000000474974513);
			foreach (string item2 in Overlays)
			{
				Spine.SetAlpha(item2, _OnzebJryHIHB0leF5LxtbJwFXjr);
			}
			if (_OnzebJryHIHB0leF5LxtbJwFXjr < _D5nVuTc7M3CvlN5bC8IzrFoWiPh)
			{
				_OnzebJryHIHB0leF5LxtbJwFXjr = _D5nVuTc7M3CvlN5bC8IzrFoWiPh;
			}
		}
		Spine.Update(gameTime, CycleTicks);
	}

	public virtual void Draw(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer)
	{
		if (_h29gtnqEWLAa5qsliRXuXiPwY2o != null)
		{
			spriteBatch.Begin();
			spriteBatch.Draw(_h29gtnqEWLAa5qsliRXuXiPwY2o, Vector2.Zero, Color.White);
			spriteBatch.End();
		}
		Spine.Draw(skeletonMeshRenderer, Skin);
		if (_XqJSGCmxFB8nW6I8Mf5NEZBQ0gG != null)
		{
			spriteBatch.Begin();
			spriteBatch.Draw(_XqJSGCmxFB8nW6I8Mf5NEZBQ0gG, Vector2.Zero, Color.White);
			spriteBatch.End();
		}
	}

	public virtual void _WhR14B3jaJk70xEEeAkh2VLlhbA()
	{
		_4XV5xPzQUH5ABIwpxH3yf5EIAyL(1, bool_0: true);
		_OnzebJryHIHB0leF5LxtbJwFXjr = 0f;
	}

	public virtual void _VandJrNHr65bKmzzmFYTOwD1icL()
	{
		if (State == Phase.Fast)
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
		State = (Phase)(bool_0 ? int_0 : Math.Max(0, Math.Min((int)(State + int_0), 3)));
		switch (State)
		{
			case Phase.Idle:
				Cycle = IdlePhase;
				break;
			case Phase.Slow:
				Cycle = SlowPhase;
				break;
			case Phase.Medium:
				Cycle = MediumPhase;
				break;
			case Phase.Fast:
				Cycle = FastPhase;
				break;
		}
	}

	public virtual void _JHfBnmyItvKJDQtdUPp2yLsm4yR()
	{
		Cumming = true;
		_D5nVuTc7M3CvlN5bC8IzrFoWiPh = 1f;
		_DPxTb3eioTU27n7cqNVeQibO5FDb = true;
		_sEncbVBa6dUb3TaptvXHIvnhfcT = _OzssjIfhUN4zR5TqbxpZGLEeF9B;
	}

	public virtual void _oHE0dGUBNplXQia6K85vMaNc8jp()
	{
		Cumming = true;
		_D5nVuTc7M3CvlN5bC8IzrFoWiPh = 1f;
		_DPxTb3eioTU27n7cqNVeQibO5FDb = true;
		_sEncbVBa6dUb3TaptvXHIvnhfcT = _OzssjIfhUN4zR5TqbxpZGLEeF9B;
		_4XV5xPzQUH5ABIwpxH3yf5EIAyL(0, bool_0: true);
	}

	public virtual void _paoLItUYkFWaGSDnCAvBagJ1F5T()
	{
		Cumming = false;
		_D5nVuTc7M3CvlN5bC8IzrFoWiPh = 0f;
		_DPxTb3eioTU27n7cqNVeQibO5FDb = false;
	}

	public virtual void _eXH4tq2J0DADXDLofA8G8Yw8fau(Phase Phase_0, bool bool_0)
	{
		_4XV5xPzQUH5ABIwpxH3yf5EIAyL((int)Phase_0, bool_0: true);
		if (bool_0)
		{
			_JHfBnmyItvKJDQtdUPp2yLsm4yR();
		}
	}
}
