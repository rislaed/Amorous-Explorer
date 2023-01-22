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

	protected _TwlwMC1hhdSzamwGWEBxuUkz1gH(ContentManager contentManager_0, string string_0, string string_1, string string_2 = null, float float_0 = 1f, bool bool_0 = true, List<SpineEvent> list_0 = null, _sa8EsNgk4VDRaASdXE7VprdlNlg _sa8EsNgk4VDRaASdXE7VprdlNlg_0 = null)
	{
		while (true)
		{
			int num = -1663681785;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDF3D0DB6u) % 12u)
				{
				case 11u:
					_DUynKBx2CM4riE68wCCfknspxeg = new List<string>();
					_1BgOJ3z4ZUXNS2L4JWf24pr41hB = contentManager_0._7BVREQXEcBCieHb0qgaVDpUj1ni(string_0, float_0, bool_0, list_0);
					num = (int)(num2 * 1822538816) ^ -178934457;
					continue;
				case 10u:
				{
					int num5;
					int num6;
					if (_TwlwMC1hhdSzamwGWEBxuUkz1gH.smethod_1(string_2))
					{
						num5 = -462487530;
						num6 = -462487530;
					}
					else
					{
						num5 = -337467512;
						num6 = -337467512;
					}
					num = num5 ^ ((int)num2 * -1557324050);
					continue;
				}
				case 9u:
				{
					_wQSC6rD8bbXFvRxba0kr1RqxlOV = _sa8EsNgk4VDRaASdXE7VprdlNlg_0;
					int num3;
					int num4;
					if (list_0 != null)
					{
						num3 = -2099229791;
						num4 = -2099229791;
					}
					else
					{
						num3 = -563990628;
						num4 = -563990628;
					}
					num = num3 ^ (int)(num2 * 535262121);
					continue;
				}
				case 7u:
					_1BgOJ3z4ZUXNS2L4JWf24pr41hB._c4iC7y9v6xg7LpvjKIeUkOdZ3UF(0f);
					num = -614986511;
					continue;
				case 6u:
				{
					_nHdiyIURlAiaNZ8u6MKzxjcwnyL nHdiyIURlAiaNZ8u6MKzxjcwnyL = _1BgOJ3z4ZUXNS2L4JWf24pr41hB;
					nHdiyIURlAiaNZ8u6MKzxjcwnyL._iUyagF1KTeSUlg0raFfzuot3CwC = (Action<string>)_TwlwMC1hhdSzamwGWEBxuUkz1gH.smethod_0((Delegate)nHdiyIURlAiaNZ8u6MKzxjcwnyL._iUyagF1KTeSUlg0raFfzuot3CwC, (Delegate)new Action<string>(_11Hsh7iMhdhIoawBk6ueRsmCarI));
					num = ((int)num2 * -940195877) ^ -1837188737;
					continue;
				}
				case 5u:
					_uwNDZuqdFb9tyQtlQMxiz1DQ7x8 = contentManager_0;
					num = ((int)num2 * -592644879) ^ 0x31B094D0;
					continue;
				case 4u:
					_0cFb48aKbcbREkHm9Jwptl6r6Vi();
					num = (int)((num2 * 77456504) ^ 0x268FE87);
					continue;
				case 3u:
					_WhR14B3jaJk70xEEeAkh2VLlhbA();
					num = ((int)num2 * -1191675742) ^ -306467600;
					continue;
				case 2u:
					_XqJSGCmxFB8nW6I8Mf5NEZBQ0gG = contentManager_0.Load<Texture2D>(string_2);
					num = ((int)num2 * -890392175) ^ 0x3F370CC8;
					continue;
				case 1u:
					_h29gtnqEWLAa5qsliRXuXiPwY2o = contentManager_0.Load<Texture2D>(string_1);
					num = ((int)num2 * -178466654) ^ 0x13987DB6;
					continue;
				default:
					return;
				case 0u:
					break;
				case 8u:
					return;
				}
				break;
			}
		}
	}

	public void _0cFb48aKbcbREkHm9Jwptl6r6Vi()
	{
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG_ = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
		_coudx6g9HL4THj8r5aYCDxaHH0I(opIJo2jLUqdOL5yAFP4yzXce0DG_);
	}

	private void _11Hsh7iMhdhIoawBk6ueRsmCarI(string string_0)
	{
		if (_7BfTap1TnZXk1aaAXnFODowTQCp)
		{
			return;
		}
		_qokIrmaaT3Lq6znW10HdrPUO9Fq rNGHguvWdrugQVL2AI6bMMKSORN = default(_qokIrmaaT3Lq6znW10HdrPUO9Fq);
		_qokIrmaaT3Lq6znW10HdrPUO9Fq qokIrmaaT3Lq6znW10HdrPUO9Fq = default(_qokIrmaaT3Lq6znW10HdrPUO9Fq);
		while (true)
		{
			int num = -1935706952;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA0344A40u) % 31u)
				{
				case 30u:
				{
					int num12;
					int num13;
					if (rNGHguvWdrugQVL2AI6bMMKSORN == _qokIrmaaT3Lq6znW10HdrPUO9Fq.Slow)
					{
						num12 = -1167523680;
						num13 = -1167523680;
					}
					else
					{
						num12 = -1895212369;
						num13 = -1895212369;
					}
					num = num12 ^ ((int)num2 * -1797011013);
					continue;
				}
				case 28u:
					switch (qokIrmaaT3Lq6znW10HdrPUO9Fq)
					{
					case _qokIrmaaT3Lq6znW10HdrPUO9Fq.Idle:
						goto IL_0060;
					case _qokIrmaaT3Lq6znW10HdrPUO9Fq.Medium:
						goto IL_007f;
					case _qokIrmaaT3Lq6znW10HdrPUO9Fq.Fast:
						goto IL_009e;
					case _qokIrmaaT3Lq6znW10HdrPUO9Fq.Slow:
						goto IL_0350;
					}
					num = ((int)num2 * -1519260372) ^ -883671866;
					continue;
				case 22u:
					goto IL_0060;
				case 14u:
					goto IL_007f;
				case 8u:
					goto IL_009e;
				case 26u:
					_wQSC6rD8bbXFvRxba0kr1RqxlOV._3pW8Mrovx9zKhcGTeZrWzvXeJ4h._xDFlaclLtJxSUU63JEJALvRLdfe();
					num = -1417065800;
					continue;
				case 25u:
					qokIrmaaT3Lq6znW10HdrPUO9Fq = _rNGHguvWdrugQVL2AI6bMMKSORN;
					num = (int)((num2 * 835840924) ^ 0x72177125);
					continue;
				case 23u:
				{
					int num8;
					int num9;
					if (_wQSC6rD8bbXFvRxba0kr1RqxlOV != null)
					{
						num8 = -1774363108;
						num9 = -1774363108;
					}
					else
					{
						num8 = -639947389;
						num9 = -639947389;
					}
					num = num8 ^ ((int)num2 * -862091517);
					continue;
				}
				case 16u:
				{
					int num4;
					int num5;
					if ((uint)(rNGHguvWdrugQVL2AI6bMMKSORN - 2) <= 1u)
					{
						num4 = 1069996866;
						num5 = 1069996866;
					}
					else
					{
						num4 = 915476095;
						num5 = 915476095;
					}
					num = num4 ^ ((int)num2 * -250769302);
					continue;
				}
				case 13u:
				{
					_sEncbVBa6dUb3TaptvXHIvnhfcT++;
					int num14;
					if (_sEncbVBa6dUb3TaptvXHIvnhfcT > _OzssjIfhUN4zR5TqbxpZGLEeF9B)
					{
						num = -351937484;
						num14 = -351937484;
					}
					else
					{
						num = -1580909133;
						num14 = -1580909133;
					}
					continue;
				}
				case 12u:
				{
					int num10;
					int num11;
					if (_DPxTb3eioTU27n7cqNVeQibO5FDb)
					{
						num10 = 1131441593;
						num11 = 1131441593;
					}
					else
					{
						num10 = 940142528;
						num11 = 940142528;
					}
					num = num10 ^ ((int)num2 * -469222799);
					continue;
				}
				case 10u:
					_OzssjIfhUN4zR5TqbxpZGLEeF9B = _boyt8NIMtKsAGSTcjHeL0WMbFxs._07xTWbIEgzxJYsYwFKDbbKNvu4G(1, 3);
					_sEncbVBa6dUb3TaptvXHIvnhfcT = 0;
					num = -533821372;
					continue;
				case 9u:
				{
					int num7;
					if (_TwlwMC1hhdSzamwGWEBxuUkz1gH.smethod_2(string_0, "ThrustEnd"))
					{
						num = -762444764;
						num7 = -762444764;
					}
					else
					{
						num = -418815824;
						num7 = -418815824;
					}
					continue;
				}
				case 7u:
					qokIrmaaT3Lq6znW10HdrPUO9Fq = _qokIrmaaT3Lq6znW10HdrPUO9Fq.Fast;
					num = (int)((num2 * 2768598) ^ 0x5CE04449);
					continue;
				case 6u:
					rNGHguvWdrugQVL2AI6bMMKSORN = _rNGHguvWdrugQVL2AI6bMMKSORN;
					num = (int)((num2 * 385670188) ^ 0x72833B02);
					continue;
				case 5u:
				{
					int num6;
					if (_TwlwMC1hhdSzamwGWEBxuUkz1gH.smethod_2(string_0, "Moan"))
					{
						num = -1212837631;
						num6 = -1212837631;
					}
					else
					{
						num = -173715393;
						num6 = -173715393;
					}
					continue;
				}
				case 4u:
				{
					int num3;
					if (_TwlwMC1hhdSzamwGWEBxuUkz1gH.smethod_2(string_0, "ThrustStart"))
					{
						num = -655890259;
						num3 = -655890259;
					}
					else
					{
						num = -1244723970;
						num3 = -1244723970;
					}
					continue;
				}
				case 2u:
					_wQSC6rD8bbXFvRxba0kr1RqxlOV._dsZlhJEYpq0xkgv0NEULe6dkmAe._xDFlaclLtJxSUU63JEJALvRLdfe();
					num = -1875274787;
					continue;
				case 0u:
					_wQSC6rD8bbXFvRxba0kr1RqxlOV._VIy3F8sVuq5i8ygZ1laOvKez7fh._xDFlaclLtJxSUU63JEJALvRLdfe();
					num = (int)(num2 * 435657128) ^ -1621604811;
					continue;
				default:
					return;
				case 17u:
					break;
				case 1u:
					return;
				case 3u:
					return;
				case 15u:
					return;
				case 19u:
					return;
				case 20u:
					return;
				case 21u:
					return;
				case 24u:
					return;
				case 27u:
					return;
				case 11u:
					goto IL_0350;
				case 29u:
					return;
				case 18u:
					return;
					IL_0350:
					_wQSC6rD8bbXFvRxba0kr1RqxlOV._BwqdE4SEYHPh05gSHa62KyXObx2._xDFlaclLtJxSUU63JEJALvRLdfe();
					return;
					IL_009e:
					_wQSC6rD8bbXFvRxba0kr1RqxlOV._qNXThpU44xZknZwFt3xQG8NpINc._xDFlaclLtJxSUU63JEJALvRLdfe();
					num = -173715393;
					continue;
					IL_007f:
					_wQSC6rD8bbXFvRxba0kr1RqxlOV._ZR6NLJd6Ya49CeydiEGSCyZeDUb._xDFlaclLtJxSUU63JEJALvRLdfe();
					num = -1667947480;
					continue;
					IL_0060:
					_wQSC6rD8bbXFvRxba0kr1RqxlOV._xk8tKI57uoSCbu9iZAwV41JAmAAA._xDFlaclLtJxSUU63JEJALvRLdfe();
					num = -1040936778;
					continue;
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

	protected virtual void _coudx6g9HL4THj8r5aYCDxaHH0I(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
	}

	public virtual void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		if (_YDmx0efYtcyg4olWGsr0rBMkyjD < _aElCqTEKQdwgSGVsOO7nt14UEsn)
		{
			goto IL_00a6;
		}
		goto IL_00e8;
		IL_00e8:
		int num;
		int num2;
		if (!(_YDmx0efYtcyg4olWGsr0rBMkyjD > _aElCqTEKQdwgSGVsOO7nt14UEsn))
		{
			num = 1573530354;
			num2 = 1573530354;
		}
		else
		{
			num = 2050042779;
			num2 = 2050042779;
		}
		goto IL_00ab;
		IL_00ab:
		string current = default(string);
		string current2 = default(string);
		while (true)
		{
			int num6;
			int num7;
			uint num3;
			switch ((num3 = (uint)num ^ 0x67235FD5u) % 7u)
			{
			case 5u:
				_YDmx0efYtcyg4olWGsr0rBMkyjD -= (float)gameTime_0.get_ElapsedGameTime().TotalMilliseconds;
				num = ((int)num3 * -1671329572) ^ 0x3EF949FA;
				continue;
			case 4u:
				_YDmx0efYtcyg4olWGsr0rBMkyjD += (float)_TwlwMC1hhdSzamwGWEBxuUkz1gH.smethod_3(gameTime_0).TotalMilliseconds;
				num = (int)(num3 * 609124078) ^ -1275978553;
				continue;
			case 3u:
				num = ((int)num3 * -2003223815) ^ 0xF5565C6;
				continue;
			case 2u:
				if (_OnzebJryHIHB0leF5LxtbJwFXjr < _D5nVuTc7M3CvlN5bC8IzrFoWiPh)
				{
					num = 1467631281;
					continue;
				}
				goto IL_01d3;
			case 0u:
				break;
			case 1u:
				goto IL_00e8;
			default:
				{
					_OnzebJryHIHB0leF5LxtbJwFXjr += (float)(gameTime_0.get_ElapsedGameTime().TotalMilliseconds * 0.0010000000474974513);
					using (List<string>.Enumerator enumerator = _DUynKBx2CM4riE68wCCfknspxeg.GetEnumerator())
					{
						while (true)
						{
							IL_01a5:
							int num4;
							int num5;
							if (enumerator.MoveNext())
							{
								num4 = 1118018044;
								num5 = 1118018044;
							}
							else
							{
								num4 = 521287104;
								num5 = 521287104;
							}
							while (true)
							{
								switch ((num3 = (uint)num4 ^ 0x67235FD5u) % 5u)
								{
								case 4u:
									current = enumerator.Current;
									num4 = 140144113;
									continue;
								case 3u:
									_1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ(current, _OnzebJryHIHB0leF5LxtbJwFXjr);
									num4 = ((int)num3 * -560327728) ^ -459578956;
									continue;
								case 2u:
									num4 = 1118018044;
									continue;
								default:
									goto end_IL_0173;
								case 0u:
									break;
								case 1u:
									goto end_IL_0173;
								}
								goto IL_01a5;
								continue;
								end_IL_0173:
								break;
							}
							break;
						}
					}
					if (_OnzebJryHIHB0leF5LxtbJwFXjr > _D5nVuTc7M3CvlN5bC8IzrFoWiPh)
					{
						goto IL_0245;
					}
					goto IL_0351;
				}
				IL_032a:
				num6 = 1502896804;
				goto IL_032f;
				IL_01d3:
				if (_OnzebJryHIHB0leF5LxtbJwFXjr > _D5nVuTc7M3CvlN5bC8IzrFoWiPh)
				{
					num7 = 228643586;
					goto IL_021f;
				}
				goto IL_0351;
				IL_021f:
				while (true)
				{
					switch ((num3 = (uint)num7 ^ 0x67235FD5u) % 5u)
					{
					case 3u:
						break;
					case 2u:
						_OnzebJryHIHB0leF5LxtbJwFXjr -= (float)(gameTime_0.get_ElapsedGameTime().TotalMilliseconds * 0.0010000000474974513);
						num7 = (int)((num3 * 1934531410) ^ 0x5223E2D);
						continue;
					case 0u:
						goto IL_0245;
					case 1u:
						goto IL_024c;
					default:
						goto IL_025d;
					}
					break;
				}
				goto IL_01d3;
				IL_025d:
				using (List<string>.Enumerator enumerator2 = _DUynKBx2CM4riE68wCCfknspxeg.GetEnumerator())
				{
					while (true)
					{
						IL_02e3:
						int num8;
						int num9;
						if (!enumerator2.MoveNext())
						{
							num8 = 996960439;
							num9 = 996960439;
						}
						else
						{
							num8 = 139586658;
							num9 = 139586658;
						}
						while (true)
						{
							switch ((num3 = (uint)num8 ^ 0x67235FD5u) % 5u)
							{
							case 2u:
								current2 = enumerator2.Current;
								num8 = 1537712561;
								continue;
							case 1u:
								_1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ(current2, _OnzebJryHIHB0leF5LxtbJwFXjr);
								num8 = (int)((num3 * 246876413) ^ 0x48D9713B);
								continue;
							case 0u:
								num8 = 139586658;
								continue;
							default:
								goto end_IL_02b1;
							case 3u:
								break;
							case 4u:
								goto end_IL_02b1;
							}
							goto IL_02e3;
							continue;
							end_IL_02b1:
							break;
						}
						break;
					}
				}
				if (_OnzebJryHIHB0leF5LxtbJwFXjr < _D5nVuTc7M3CvlN5bC8IzrFoWiPh)
				{
					goto IL_032a;
				}
				goto IL_0351;
				IL_024c:
				_OnzebJryHIHB0leF5LxtbJwFXjr = _D5nVuTc7M3CvlN5bC8IzrFoWiPh;
				goto IL_0351;
				IL_0245:
				num7 = 1797130512;
				goto IL_021f;
				IL_0351:
				_1BgOJ3z4ZUXNS2L4JWf24pr41hB._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0, _YDmx0efYtcyg4olWGsr0rBMkyjD);
				num6 = 1453419831;
				goto IL_032f;
				IL_032f:
				while (true)
				{
					switch ((num3 = (uint)num6 ^ 0x67235FD5u) % 4u)
					{
					case 1u:
						_OnzebJryHIHB0leF5LxtbJwFXjr = _D5nVuTc7M3CvlN5bC8IzrFoWiPh;
						num6 = (int)((num3 * 334153772) ^ 0x752B71A);
						continue;
					case 0u:
						break;
					default:
						return;
					case 3u:
						goto IL_0351;
					case 2u:
						return;
					}
					break;
				}
				goto IL_032a;
			}
			break;
		}
		goto IL_00a6;
		IL_00a6:
		num = 395247520;
		goto IL_00ab;
	}

	public virtual void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		if (_h29gtnqEWLAa5qsliRXuXiPwY2o != null)
		{
			goto IL_00af;
		}
		goto IL_00f4;
		IL_00f4:
		_1BgOJ3z4ZUXNS2L4JWf24pr41hB._f5ctqAmdNsZ889UjM4LxDm8WGxA(skeletonMeshRenderer_0, _1AqpgY4vB6ly5vxOay6j86rcIEo);
		int num;
		int num2;
		if (_XqJSGCmxFB8nW6I8Mf5NEZBQ0gG != null)
		{
			num = -221532069;
			num2 = -221532069;
		}
		else
		{
			num = -1437887894;
			num2 = -1437887894;
		}
		goto IL_00b4;
		IL_00b4:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0x816953D9u) % 8u)
			{
			case 7u:
				_TwlwMC1hhdSzamwGWEBxuUkz1gH.smethod_6(spriteBatch_0);
				num = (int)((num3 * 1123832049) ^ 0x3CAA6E4F);
				continue;
			case 6u:
				_TwlwMC1hhdSzamwGWEBxuUkz1gH.smethod_4(spriteBatch_0);
				num = ((int)num3 * -348756309) ^ -1427767234;
				continue;
			case 5u:
				_TwlwMC1hhdSzamwGWEBxuUkz1gH.smethod_5(spriteBatch_0, _h29gtnqEWLAa5qsliRXuXiPwY2o, Vector2.get_Zero(), Color.get_White());
				num = (int)((num3 * 28026880) ^ 0x7BCD4A0E);
				continue;
			case 4u:
				_TwlwMC1hhdSzamwGWEBxuUkz1gH.smethod_6(spriteBatch_0);
				num = (int)(num3 * 1184152594) ^ -87420686;
				continue;
			case 2u:
				_TwlwMC1hhdSzamwGWEBxuUkz1gH.smethod_4(spriteBatch_0);
				_TwlwMC1hhdSzamwGWEBxuUkz1gH.smethod_5(spriteBatch_0, _XqJSGCmxFB8nW6I8Mf5NEZBQ0gG, Vector2.get_Zero(), Color.get_White());
				num = (int)((num3 * 153141623) ^ 0x3520595B);
				continue;
			case 0u:
				break;
			default:
				return;
			case 1u:
				goto IL_00f4;
			case 3u:
				return;
			}
			break;
		}
		goto IL_00af;
		IL_00af:
		num = -942904969;
		goto IL_00b4;
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
			goto IL_0009;
		}
		goto IL_0048;
		IL_0048:
		_4XV5xPzQUH5ABIwpxH3yf5EIAyL(1);
		int num = 527114801;
		goto IL_0023;
		IL_0023:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x28EC092Bu) % 5u)
			{
			case 3u:
				break;
			case 1u:
				_oHE0dGUBNplXQia6K85vMaNc8jp();
				num = (int)(num2 * 1649538586) ^ -2095949150;
				continue;
			default:
				return;
			case 2u:
				goto IL_0048;
			case 0u:
				return;
			case 4u:
				return;
			}
			break;
		}
		goto IL_0009;
		IL_0009:
		num = 355709761;
		goto IL_0023;
	}

	public virtual void _4XV5xPzQUH5ABIwpxH3yf5EIAyL(int int_0, bool bool_0 = false)
	{
		_rNGHguvWdrugQVL2AI6bMMKSORN = (_qokIrmaaT3Lq6znW10HdrPUO9Fq)(bool_0 ? int_0 : _TwlwMC1hhdSzamwGWEBxuUkz1gH.smethod_8(0, _TwlwMC1hhdSzamwGWEBxuUkz1gH.smethod_7((int)(_rNGHguvWdrugQVL2AI6bMMKSORN + int_0), 3)));
		int num;
		switch (_rNGHguvWdrugQVL2AI6bMMKSORN)
		{
		default:
			num = -2021313921;
			goto IL_0066;
		case _qokIrmaaT3Lq6znW10HdrPUO9Fq.Slow:
			goto IL_0044;
		case _qokIrmaaT3Lq6znW10HdrPUO9Fq.Medium:
			goto IL_0056;
		case _qokIrmaaT3Lq6znW10HdrPUO9Fq.Fast:
			goto IL_009a;
		case _qokIrmaaT3Lq6znW10HdrPUO9Fq.Idle:
			break;
			IL_0066:
			switch ((uint)(num ^ -1940253994) % 9u)
			{
			case 4u:
				break;
			case 2u:
				goto IL_0044;
			case 0u:
				goto IL_0056;
			default:
				return;
			case 5u:
				goto IL_009a;
			case 1u:
				return;
			case 3u:
				return;
			case 6u:
				return;
			case 7u:
				return;
			case 8u:
				goto end_IL_0028;
			}
			goto default;
			IL_009a:
			_aElCqTEKQdwgSGVsOO7nt14UEsn = 300f;
			num = -1105451253;
			goto IL_0066;
			IL_0056:
			_aElCqTEKQdwgSGVsOO7nt14UEsn = 500f;
			num = -1393810864;
			goto IL_0066;
			IL_0044:
			_aElCqTEKQdwgSGVsOO7nt14UEsn = 1000f;
			num = -1203587500;
			goto IL_0066;
			end_IL_0028:
			break;
		}
		_aElCqTEKQdwgSGVsOO7nt14UEsn = 2000f;
	}

	public virtual void _JHfBnmyItvKJDQtdUPp2yLsm4yR()
	{
		_p3lU5oxIaFTVHUNFxJRnaHkXdsA = true;
		while (true)
		{
			int num = 1047810517;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x478020A4u) % 4u)
				{
				case 2u:
					_DPxTb3eioTU27n7cqNVeQibO5FDb = true;
					num = (int)(num2 * 1333490523) ^ -351721694;
					continue;
				case 1u:
					_D5nVuTc7M3CvlN5bC8IzrFoWiPh = 1f;
					num = (int)(num2 * 1383303474) ^ -340608212;
					continue;
				case 3u:
					break;
				default:
					_sEncbVBa6dUb3TaptvXHIvnhfcT = _OzssjIfhUN4zR5TqbxpZGLEeF9B;
					return;
				}
				break;
			}
		}
	}

	public virtual void _oHE0dGUBNplXQia6K85vMaNc8jp()
	{
		_p3lU5oxIaFTVHUNFxJRnaHkXdsA = true;
		while (true)
		{
			int num = 1750723148;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x77039CE9u) % 4u)
				{
				case 1u:
					_D5nVuTc7M3CvlN5bC8IzrFoWiPh = 1f;
					num = ((int)num2 * -1577385878) ^ 0xAB201AB;
					continue;
				case 0u:
					_DPxTb3eioTU27n7cqNVeQibO5FDb = true;
					num = (int)((num2 * 434010447) ^ 0x462B2EEA);
					continue;
				case 2u:
					break;
				default:
					_sEncbVBa6dUb3TaptvXHIvnhfcT = _OzssjIfhUN4zR5TqbxpZGLEeF9B;
					_4XV5xPzQUH5ABIwpxH3yf5EIAyL(0, bool_0: true);
					return;
				}
				break;
			}
		}
	}

	public virtual void _paoLItUYkFWaGSDnCAvBagJ1F5T()
	{
		_p3lU5oxIaFTVHUNFxJRnaHkXdsA = false;
		while (true)
		{
			int num = 115629723;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1C549B7Eu) % 4u)
				{
				case 1u:
					_D5nVuTc7M3CvlN5bC8IzrFoWiPh = 0f;
					num = (int)(num2 * 1633986076) ^ -1118781266;
					continue;
				case 0u:
					_DPxTb3eioTU27n7cqNVeQibO5FDb = false;
					num = (int)((num2 * 58048833) ^ 0x377E5944);
					continue;
				default:
					return;
				case 3u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public virtual void _eXH4tq2J0DADXDLofA8G8Yw8fau(_qokIrmaaT3Lq6znW10HdrPUO9Fq _qokIrmaaT3Lq6znW10HdrPUO9Fq_0, bool bool_0)
	{
		_4XV5xPzQUH5ABIwpxH3yf5EIAyL((int)_qokIrmaaT3Lq6znW10HdrPUO9Fq_0, bool_0: true);
		while (true)
		{
			int num = -1704705485;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA89FF4D9u) % 4u)
				{
				case 3u:
					_JHfBnmyItvKJDQtdUPp2yLsm4yR();
					num = ((int)num2 * -1430612909) ^ 0xFC8619;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (bool_0)
					{
						num3 = 1662959494;
						num4 = 1662959494;
					}
					else
					{
						num3 = 1887225092;
						num4 = 1887225092;
					}
					num = num3 ^ (int)(num2 * 1325227260);
					continue;
				}
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	static Delegate smethod_0(Delegate delegate_0, Delegate delegate_1)
	{
		return Delegate.Combine(delegate_0, delegate_1);
	}

	static bool smethod_1(string string_0)
	{
		return string.IsNullOrEmpty(string_0);
	}

	static bool smethod_2(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	static TimeSpan smethod_3(GameTime gameTime_0)
	{
		return gameTime_0.get_ElapsedGameTime();
	}

	static void smethod_4(SpriteBatch spriteBatch_0)
	{
		spriteBatch_0.Begin();
	}

	static void smethod_5(SpriteBatch spriteBatch_0, Texture2D texture2D_0, Vector2 vector2_0, Color color_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		spriteBatch_0.Draw(texture2D_0, vector2_0, color_0);
	}

	static void smethod_6(SpriteBatch spriteBatch_0)
	{
		spriteBatch_0.End();
	}

	static int smethod_7(int int_0, int int_1)
	{
		return Math.Min(int_0, int_1);
	}

	static int smethod_8(int int_0, int int_1)
	{
		return Math.Max(int_0, int_1);
	}
}
