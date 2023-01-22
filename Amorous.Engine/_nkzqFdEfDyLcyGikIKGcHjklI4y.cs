using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Amorous.Engine.GUI;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Squid;

public class _nkzqFdEfDyLcyGikIKGcHjklI4y
{
	private enum _QGnsmTImvr3dFBCr8hpzDZiCWLP
	{
		None,
		Started,
		Visible
	}

	private enum _IIGQSKohQsLi09FILC8oKHG5UXG
	{
		None,
		Started,
		Typing,
		Waiting,
		WaitForSkip,
		Skip,
		Done
	}

	private class _oDZZ0F7Qg08utTIjAaoyIbeDuFG
	{
		private readonly List<_W4jOxbRDzppFv0IAFpA5Blo7CjUA> _Fcqa4Lsbrq6zW3KyJnkvEumd0f4;

		private int _3wk7bXUbhNqSQ9kMD9hieEubOhG;

		public bool _xJZUPxDatEzfPQc0nRHR2D1Vwke => _3wk7bXUbhNqSQ9kMD9hieEubOhG >= _Fcqa4Lsbrq6zW3KyJnkvEumd0f4.Count;

		public string _K87Hdb6ToAR0us3tN3ZmvHdPdeJ { get; }

		public string _D5QiLGGNtfoCEnZIUPvH4OKqUabA { get; }

		public Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA { get; }

		public _oDZZ0F7Qg08utTIjAaoyIbeDuFG(string string_0, string string_1, Color color_0)
		{
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			while (true)
			{
				int num = -2098233081;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9968AEC6u) % 8u)
					{
					case 7u:
						_fHbF0r78UBMiyDseUhbwAvEaqmp = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t()._RB8fRXeQvK5vs7JEA0XfVCEpg1i;
						num = ((int)num2 * -971488254) ^ 0x104BE7D2;
						continue;
					case 6u:
						_Fcqa4Lsbrq6zW3KyJnkvEumd0f4 = new List<_W4jOxbRDzppFv0IAFpA5Blo7CjUA>();
						num = (int)(num2 * 1039251764) ^ -1719187418;
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (!_oDZZ0F7Qg08utTIjAaoyIbeDuFG.smethod_2(string_1, "%playername%"))
						{
							num3 = -325735761;
							num4 = -325735761;
						}
						else
						{
							num3 = -556556725;
							num4 = -556556725;
						}
						num = num3 ^ ((int)num2 * -1469821366);
						continue;
					}
					case 3u:
						_fHbF0r78UBMiyDseUhbwAvEaqmp = string_1;
						num = -1665767764;
						continue;
					case 2u:
						_ChpobZzN69pA08rlAmpiuCeOPQv = color_0;
						num = -1106946344;
						continue;
					case 1u:
						_KD80MJMEbQska5mSqJiPthulqeB = _oDZZ0F7Qg08utTIjAaoyIbeDuFG.smethod_1(_oDZZ0F7Qg08utTIjAaoyIbeDuFG.smethod_0(string_0, "%playername%", _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t()._RB8fRXeQvK5vs7JEA0XfVCEpg1i));
						num = (int)((num2 * 2081039121) ^ 0x39F821F2);
						continue;
					default:
						return;
					case 4u:
						break;
					case 0u:
						return;
					}
					break;
				}
			}
		}

		public void _TN6mQ7Lbe501vwqhgs7b8d6wd1b(SpriteFont spriteFont_0, SpriteFont spriteFont_1)
		{
			//IL_027e: Unknown result type (might be due to invalid IL or missing references)
			_Fcqa4Lsbrq6zW3KyJnkvEumd0f4.Clear();
			char char_2 = default(char);
			char char_ = default(char);
			string text = default(string);
			bool flag = default(bool);
			bool bool_ = default(bool);
			int int_ = default(int);
			int int_2 = default(int);
			string string_ = default(string);
			int num7 = default(int);
			bool bool_2 = default(bool);
			while (true)
			{
				int num = -902425993;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x80C06289u) % 45u)
					{
					case 44u:
						num = (int)(num2 * 551736733) ^ -1882104094;
						continue;
					case 43u:
					{
						int num26;
						if (char_2 != 'i')
						{
							num = -1683890738;
							num26 = -1683890738;
						}
						else
						{
							num = -120881803;
							num26 = -120881803;
						}
						continue;
					}
					case 42u:
					{
						int num28;
						int num29;
						if (_oj8dqD8luomebDeOFLXAy1e38Z5(ref char_))
						{
							num28 = 583114215;
							num29 = 583114215;
						}
						else
						{
							num28 = 1541109729;
							num29 = 1541109729;
						}
						num = num28 ^ ((int)num2 * -1857079489);
						continue;
					}
					case 41u:
					{
						_3wk7bXUbhNqSQ9kMD9hieEubOhG = 0;
						int num18;
						int num19;
						if (!_oDZZ0F7Qg08utTIjAaoyIbeDuFG.smethod_3(_K87Hdb6ToAR0us3tN3ZmvHdPdeJ))
						{
							num18 = 957453541;
							num19 = 957453541;
						}
						else
						{
							num18 = 1903132314;
							num19 = 1903132314;
						}
						num = num18 ^ ((int)num2 * -2133899537);
						continue;
					}
					case 40u:
						_Fcqa4Lsbrq6zW3KyJnkvEumd0f4.Add(new _W4jOxbRDzppFv0IAFpA5Blo7CjUA(text, bool_0: true, flag, bool_, int_));
						num = (int)((num2 * 1598829551) ^ 0x4618A9A4);
						continue;
					case 39u:
						_Fcqa4Lsbrq6zW3KyJnkvEumd0f4.Add(new _W4jOxbRDzppFv0IAFpA5Blo7CjUA(text, bool_0: true, flag, bool_, int_));
						text = string.Empty;
						num = -452298331;
						continue;
					case 38u:
					{
						int num15;
						int num16;
						if (text.Length > 0)
						{
							num15 = 183225134;
							num16 = 183225134;
						}
						else
						{
							num15 = 2033028862;
							num16 = 2033028862;
						}
						num = num15 ^ (int)(num2 * 1193457798);
						continue;
					}
					case 37u:
					{
						int num10;
						if (int_2 >= _oDZZ0F7Qg08utTIjAaoyIbeDuFG.smethod_4(string_))
						{
							num = -2045345833;
							num10 = -2045345833;
						}
						else
						{
							num = -2034787189;
							num10 = -2034787189;
						}
						continue;
					}
					case 36u:
						text += char_;
						num = -1369254372;
						continue;
					case 35u:
						num = (int)((num2 * 1542244248) ^ 0x59606A2D);
						continue;
					case 34u:
						int_2 = 0;
						text = string.Empty;
						num7 = 0;
						int_ = 0;
						num = (int)(num2 * 478793592) ^ -739031736;
						continue;
					case 33u:
						num = (int)((num2 * 445001098) ^ 0x4464414E);
						continue;
					case 32u:
					{
						int num24;
						int num25;
						if (string_[int_2] == ' ')
						{
							num24 = 767888410;
							num25 = 767888410;
						}
						else
						{
							num24 = 2074513886;
							num25 = 2074513886;
						}
						num = num24 ^ (int)(num2 * 1879114283);
						continue;
					}
					case 31u:
						bool_ = !bool_2;
						num = ((int)num2 * -320623589) ^ 0x3F5AC50A;
						continue;
					case 30u:
						num = ((int)num2 * -490184150) ^ -402774640;
						continue;
					case 29u:
						int_ = 0;
						num7 = 0;
						num = -1051207815;
						continue;
					case 28u:
						_Fcqa4Lsbrq6zW3KyJnkvEumd0f4.Add(new _W4jOxbRDzppFv0IAFpA5Blo7CjUA(text, bool_0: false, flag, bool_, int_));
						text = string.Empty;
						int_ = num7;
						num = (int)((num2 * 296560325) ^ 0x520D2B55);
						continue;
					case 27u:
						flag = false;
						bool_ = false;
						char_2 = ' ';
						num = (int)(num2 * 1546667808) ^ -412101981;
						continue;
					case 26u:
						num7 += (int)(flag ? spriteFont_1 : spriteFont_0).MeasureString(char_.ToString()).X;
						num = -995738054;
						continue;
					case 25u:
						text = text.Substring(0, text.Length - 1);
						num = (int)((num2 * 1037693121) ^ 0x34322EAC);
						continue;
					case 24u:
						flag = !bool_2;
						num = (int)(num2 * 894877363) ^ -1880311285;
						continue;
					case 23u:
						_Fcqa4Lsbrq6zW3KyJnkvEumd0f4[_Fcqa4Lsbrq6zW3KyJnkvEumd0f4.Count - 1]._YqQMYa7eF6BsHAixrYycR8apI6F = true;
						num = (int)((num2 * 555082606) ^ 0x7381A8E6);
						continue;
					case 22u:
						bool_2 = false;
						num = (int)(num2 * 114248431) ^ -792675046;
						continue;
					case 21u:
					{
						char_ = _oDZZ0F7Qg08utTIjAaoyIbeDuFG.smethod_5(string_, int_2++);
						int num5;
						int num6;
						if (char_ != '<')
						{
							num5 = 77621393;
							num6 = 77621393;
						}
						else
						{
							num5 = 390242813;
							num6 = 390242813;
						}
						num = num5 ^ ((int)num2 * -907327588);
						continue;
					}
					case 20u:
						_Fcqa4Lsbrq6zW3KyJnkvEumd0f4.Add(new _W4jOxbRDzppFv0IAFpA5Blo7CjUA(text, bool_0: false, flag, bool_, int_));
						num = ((int)num2 * -716105821) ^ 0x4792B89B;
						continue;
					case 19u:
						num7 = 0;
						num = -865072380;
						continue;
					case 18u:
						int_ = 0;
						num = (int)((num2 * 990356611) ^ 0x61939BAC);
						continue;
					case 17u:
					{
						int num30;
						int num31;
						if (_Fcqa4Lsbrq6zW3KyJnkvEumd0f4.Count <= 0)
						{
							num30 = 365298435;
							num31 = 365298435;
						}
						else
						{
							num30 = 167898225;
							num31 = 167898225;
						}
						num = num30 ^ (int)(num2 * 91708061);
						continue;
					}
					case 16u:
					{
						int num27;
						if (text.Length == 0)
						{
							num = -693558025;
							num27 = -693558025;
						}
						else
						{
							num = -1000415390;
							num27 = -1000415390;
						}
						continue;
					}
					case 15u:
					{
						int num22;
						int num23;
						if (char_ != '\n')
						{
							num22 = -827814853;
							num23 = -827814853;
						}
						else
						{
							num22 = -719080858;
							num23 = -719080858;
						}
						num = num22 ^ (int)(num2 * 94924577);
						continue;
					}
					case 13u:
					{
						int num21;
						if (text.Length <= 0)
						{
							num = -366525065;
							num21 = -366525065;
						}
						else
						{
							num = -348308563;
							num21 = -348308563;
						}
						continue;
					}
					case 12u:
					{
						int num20;
						if (text.Length != 0)
						{
							num = -1034453303;
							num20 = -1034453303;
						}
						else
						{
							num = -353821737;
							num20 = -353821737;
						}
						continue;
					}
					case 11u:
					{
						int num17;
						if (char_2 == 'b')
						{
							num = -386678442;
							num17 = -386678442;
						}
						else
						{
							num = -1357844916;
							num17 = -1357844916;
						}
						continue;
					}
					case 10u:
					{
						int num13;
						int num14;
						if (_NAyejbnxgyLeIcptsV2gubUyOZq(ref string_, ref int_2, ref char_2, ref bool_2))
						{
							num13 = 742546864;
							num14 = 742546864;
						}
						else
						{
							num13 = 169607709;
							num14 = 169607709;
						}
						num = num13 ^ (int)(num2 * 852494719);
						continue;
					}
					case 9u:
						text = string.Empty;
						num = ((int)num2 * -1840448105) ^ 0x76AD24C3;
						continue;
					case 7u:
						num = (int)((num2 * 2121362309) ^ 0x44DC3BFC);
						continue;
					case 6u:
					{
						int num11;
						int num12;
						if (num7 < 1770)
						{
							num11 = -1705940906;
							num12 = -1705940906;
						}
						else
						{
							num11 = -1050191988;
							num12 = -1050191988;
						}
						num = num11 ^ ((int)num2 * -1585479042);
						continue;
					}
					case 5u:
					{
						int num8;
						int num9;
						if (int_2 == 0)
						{
							num8 = 374212950;
							num9 = 374212950;
						}
						else
						{
							num8 = 430192294;
							num9 = 430192294;
						}
						num = num8 ^ ((int)num2 * -1011907677);
						continue;
					}
					case 4u:
						string_ = _K87Hdb6ToAR0us3tN3ZmvHdPdeJ;
						num = -278001212;
						continue;
					case 3u:
						int_2--;
						num = (int)((num2 * 965831517) ^ 0x71F6CD58);
						continue;
					case 2u:
						num = (int)(num2 * 37674298) ^ -405399152;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (_oDZZ0F7Qg08utTIjAaoyIbeDuFG.smethod_4(text) > 0)
						{
							num3 = 521340241;
							num4 = 521340241;
						}
						else
						{
							num3 = 1550527657;
							num4 = 1550527657;
						}
						num = num3 ^ ((int)num2 * -394063429);
						continue;
					}
					default:
						return;
					case 14u:
						break;
					case 0u:
						return;
					case 8u:
						return;
					}
					break;
				}
			}
		}

		private bool _NAyejbnxgyLeIcptsV2gubUyOZq(ref string string_0, ref int int_0, ref char char_0, ref bool bool_0)
		{
			int num = int_0;
			char c = default(char);
			while (true)
			{
				int num2 = -105261140;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0xE1A155F6u) % 15u)
					{
					case 13u:
					{
						int num12;
						int num13;
						if (num >= _oDZZ0F7Qg08utTIjAaoyIbeDuFG.smethod_4(string_0))
						{
							num12 = 284080590;
							num13 = 284080590;
						}
						else
						{
							num12 = 1223331669;
							num13 = 1223331669;
						}
						num2 = num12 ^ ((int)num3 * -582025875);
						continue;
					}
					case 11u:
						c = _oDZZ0F7Qg08utTIjAaoyIbeDuFG.smethod_5(string_0, num++);
						num2 = -456937600;
						continue;
					case 10u:
						char_0 = _oDZZ0F7Qg08utTIjAaoyIbeDuFG.smethod_5(string_0, num++);
						bool_0 = char_0 == '/';
						num2 = -2058628857;
						continue;
					case 8u:
					{
						int num6;
						if (!bool_0)
						{
							num2 = -1529336762;
							num6 = -1529336762;
						}
						else
						{
							num2 = -832346643;
							num6 = -832346643;
						}
						continue;
					}
					case 7u:
					{
						int num11;
						if (num >= _oDZZ0F7Qg08utTIjAaoyIbeDuFG.smethod_4(string_0))
						{
							num2 = -1676322636;
							num11 = -1676322636;
						}
						else
						{
							num2 = -535286646;
							num11 = -535286646;
						}
						continue;
					}
					case 6u:
					{
						int num7;
						int num8;
						if (c != '>')
						{
							num7 = -2054352606;
							num8 = -2054352606;
						}
						else
						{
							num7 = -1468917364;
							num8 = -1468917364;
						}
						num2 = num7 ^ (int)(num3 * 1035134836);
						continue;
					}
					case 5u:
					{
						int num9;
						int num10;
						if (_hFQYJfPSNmwOMj06bgwOluYktME(ref char_0))
						{
							num9 = 329593326;
							num10 = 329593326;
						}
						else
						{
							num9 = 1022468326;
							num10 = 1022468326;
						}
						num2 = num9 ^ (int)(num3 * 583224926);
						continue;
					}
					case 2u:
					{
						int num4;
						int num5;
						if (num < _oDZZ0F7Qg08utTIjAaoyIbeDuFG.smethod_4(string_0))
						{
							num4 = -2127423249;
							num5 = -2127423249;
						}
						else
						{
							num4 = -546134316;
							num5 = -546134316;
						}
						num2 = num4 ^ (int)(num3 * 1139611045);
						continue;
					}
					case 1u:
						char_0 = _oDZZ0F7Qg08utTIjAaoyIbeDuFG.smethod_5(string_0, num++);
						num2 = ((int)num3 * -1891037741) ^ -1561712377;
						continue;
					case 12u:
						break;
					case 0u:
						return false;
					default:
						return false;
					case 4u:
						return false;
					case 9u:
						return false;
					case 14u:
						int_0 = num;
						return true;
					}
					break;
				}
			}
		}

		private bool _hFQYJfPSNmwOMj06bgwOluYktME(ref char char_0)
		{
			if (char_0 != 'i')
			{
				return char_0 == 'b';
			}
			return true;
		}

		private bool _oj8dqD8luomebDeOFLXAy1e38Z5(ref char char_0)
		{
			if (char_0 != '░')
			{
				return char_0 == '\r';
			}
			return true;
		}

		public void _pYBSD3QOMXtGMbCUDyvyluUZnx()
		{
			if (_xJZUPxDatEzfPQc0nRHR2D1Vwke)
			{
				uint num = 1361777123u;
				return;
			}
			using (List<_W4jOxbRDzppFv0IAFpA5Blo7CjUA>.Enumerator enumerator = _Fcqa4Lsbrq6zW3KyJnkvEumd0f4.GetEnumerator())
			{
				_W4jOxbRDzppFv0IAFpA5Blo7CjUA current = default(_W4jOxbRDzppFv0IAFpA5Blo7CjUA);
				while (true)
				{
					IL_0085:
					int num2;
					int num3;
					if (enumerator.MoveNext())
					{
						num2 = 1494377435;
						num3 = 1494377435;
					}
					else
					{
						num2 = 1930238343;
						num3 = 1930238343;
					}
					while (true)
					{
						uint num;
						switch ((num = (uint)num2 ^ 0xC2653AEu) % 5u)
						{
						case 4u:
							num2 = 1494377435;
							continue;
						case 3u:
							current._pYBSD3QOMXtGMbCUDyvyluUZnx();
							num2 = ((int)num * -1647258873) ^ 0x7A3663D4;
							continue;
						case 2u:
							current = enumerator.Current;
							num2 = 717895411;
							continue;
						default:
							goto end_IL_0054;
						case 1u:
							break;
						case 0u:
							goto end_IL_0054;
						}
						goto IL_0085;
						continue;
						end_IL_0054:
						break;
					}
					break;
				}
			}
			_3wk7bXUbhNqSQ9kMD9hieEubOhG = _Fcqa4Lsbrq6zW3KyJnkvEumd0f4.Count;
		}

		public char _ZKadRFahgnwn10dM34638KGsLNu()
		{
			if (_xJZUPxDatEzfPQc0nRHR2D1Vwke)
			{
				goto IL_0017;
			}
			goto IL_006a;
			IL_006a:
			_W4jOxbRDzppFv0IAFpA5Blo7CjUA w4jOxbRDzppFv0IAFpA5Blo7CjUA = _Fcqa4Lsbrq6zW3KyJnkvEumd0f4[_3wk7bXUbhNqSQ9kMD9hieEubOhG];
			char result = w4jOxbRDzppFv0IAFpA5Blo7CjUA._ZKadRFahgnwn10dM34638KGsLNu();
			int num;
			int num2;
			if (w4jOxbRDzppFv0IAFpA5Blo7CjUA._xJZUPxDatEzfPQc0nRHR2D1Vwke)
			{
				num = -404165933;
				num2 = -404165933;
			}
			else
			{
				num = -854451966;
				num2 = -854451966;
			}
			goto IL_0039;
			IL_0039:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num ^ 0xFBCF0661u) % 5u)
				{
				case 4u:
					break;
				case 1u:
					_3wk7bXUbhNqSQ9kMD9hieEubOhG++;
					num = ((int)num3 * -1529982690) ^ -1596188706;
					continue;
				case 3u:
					goto IL_006a;
				default:
					return result;
				case 2u:
					return ' ';
				}
				break;
			}
			goto IL_0017;
			IL_0017:
			num = -578883719;
			goto IL_0039;
		}

		public void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0, SpriteFont spriteFont_0, SpriteFont spriteFont_1, Vector2[] vector2_0)
		{
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			int num = 0;
			using List<_W4jOxbRDzppFv0IAFpA5Blo7CjUA>.Enumerator enumerator = _Fcqa4Lsbrq6zW3KyJnkvEumd0f4.GetEnumerator();
			_W4jOxbRDzppFv0IAFpA5Blo7CjUA current = default(_W4jOxbRDzppFv0IAFpA5Blo7CjUA);
			while (true)
			{
				int num2;
				int num3;
				if (!enumerator.MoveNext())
				{
					num2 = -80930537;
					num3 = -80930537;
				}
				else
				{
					num2 = -857170794;
					num3 = -857170794;
				}
				while (true)
				{
					uint num4;
					switch ((num4 = (uint)num2 ^ 0xBF781679u) % 9u)
					{
					case 8u:
					{
						int num7;
						int num8;
						if (current._YqQMYa7eF6BsHAixrYycR8apI6F)
						{
							num7 = -174488511;
							num8 = -174488511;
						}
						else
						{
							num7 = -31851232;
							num8 = -31851232;
						}
						num2 = num7 ^ ((int)num4 * -90656969);
						continue;
					}
					case 6u:
						current = enumerator.Current;
						num2 = -1963507920;
						continue;
					case 4u:
					{
						int num5;
						int num6;
						if (num >= vector2_0.Length)
						{
							num5 = 459910891;
							num6 = 459910891;
						}
						else
						{
							num5 = 609231185;
							num6 = 609231185;
						}
						num2 = num5 ^ ((int)num4 * -1130197543);
						continue;
					}
					case 2u:
						num2 = -857170794;
						continue;
					case 1u:
						num++;
						num2 = (int)((num4 * 935883991) ^ 0x551C23FE);
						continue;
					case 0u:
						current._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0, spriteFont_0, spriteFont_1, vector2_0[num], _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA);
						num2 = -1143756256;
						continue;
					default:
						return;
					case 3u:
						break;
					case 5u:
						return;
					case 7u:
						return;
					}
					break;
				}
			}
		}

		static string smethod_0(string string_0, string string_1, string string_2)
		{
			return string_0.Replace(string_1, string_2);
		}

		static string smethod_1(string string_0)
		{
			return string_0.Trim();
		}

		static bool smethod_2(string string_0, string string_1)
		{
			return string_0 == string_1;
		}

		static bool smethod_3(string string_0)
		{
			return string.IsNullOrEmpty(string_0);
		}

		static int smethod_4(string string_0)
		{
			return string_0.Length;
		}

		static char smethod_5(string string_0, int int_0)
		{
			return string_0[int_0];
		}
	}

	private class _W4jOxbRDzppFv0IAFpA5Blo7CjUA
	{
		private int _3wk7bXUbhNqSQ9kMD9hieEubOhG;

		private readonly Vector2 _BK3BSdlEv4xSjAlS93TtxbrrjjA;

		public bool _xJZUPxDatEzfPQc0nRHR2D1Vwke => _3wk7bXUbhNqSQ9kMD9hieEubOhG >= _W4jOxbRDzppFv0IAFpA5Blo7CjUA.smethod_0(_Si5dw38ImuGLFJvc8DC1FoIc0PG);

		public string _Si5dw38ImuGLFJvc8DC1FoIc0PG { get; }

		public bool _YqQMYa7eF6BsHAixrYycR8apI6F { get; set; }

		public bool _m2fqFdYkda0gaCnRfu9lTOJ9CAi { get; }

		public bool _ADnm4p5lVjBKkT3NkUtyGVE6UyC { get; }

		public _W4jOxbRDzppFv0IAFpA5Blo7CjUA(string string_0, bool bool_0, bool bool_1, bool bool_2, int int_0)
		{
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			while (true)
			{
				int num = 2131293817;
				while (true)
				{
					string jKleQiKbVdoC6cAZMyVb5qJD13Q;
					switch ((uint)(num ^ 0x15248F23) % 3u)
					{
					case 1u:
						jKleQiKbVdoC6cAZMyVb5qJD13Q = ((int_0 == 0) ? _W4jOxbRDzppFv0IAFpA5Blo7CjUA.smethod_1(string_0) : string_0);
						goto IL_0016;
					case 2u:
						break;
					default:
						_YqQMYa7eF6BsHAixrYycR8apI6F = bool_0;
						_Ca56HTa6e3zxZSlfkrIB2telVdG = bool_1;
						_on9cwi6oxCjZzbho9Maz5KlOLPp = bool_2;
						_BK3BSdlEv4xSjAlS93TtxbrrjjA = new Vector2((float)int_0, 0f);
						return;
					}
					break;
					IL_0016:
					_jKleQiKbVdoC6cAZMyVb5qJD13Q = jKleQiKbVdoC6cAZMyVb5qJD13Q;
					num = 1818460204;
				}
			}
		}

		public void _pYBSD3QOMXtGMbCUDyvyluUZnx()
		{
			_3wk7bXUbhNqSQ9kMD9hieEubOhG = _W4jOxbRDzppFv0IAFpA5Blo7CjUA.smethod_0(_Si5dw38ImuGLFJvc8DC1FoIc0PG);
		}

		public char _ZKadRFahgnwn10dM34638KGsLNu()
		{
			if (_xJZUPxDatEzfPQc0nRHR2D1Vwke)
			{
				return ' ';
			}
			return _W4jOxbRDzppFv0IAFpA5Blo7CjUA.smethod_2(_Si5dw38ImuGLFJvc8DC1FoIc0PG, _3wk7bXUbhNqSQ9kMD9hieEubOhG++);
		}

		public void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0, SpriteFont spriteFont_0, SpriteFont spriteFont_1, Vector2 vector2_0, Color color_0)
		{
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			string string_ = _Jnjh8hNzVbH0Eov4seqBq1UNOCq();
			while (true)
			{
				int num = -1545693755;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE7A237DAu) % 7u)
					{
					case 4u:
					{
						int num5;
						if (_m2fqFdYkda0gaCnRfu9lTOJ9CAi)
						{
							num = -726291614;
							num5 = -726291614;
						}
						else
						{
							num = -344289883;
							num5 = -344289883;
						}
						continue;
					}
					case 2u:
						spriteBatch_0._FY70IFLoBond3ORPe0ndCLvIeVcA(spriteFont_1, string_, vector2_0 + _BK3BSdlEv4xSjAlS93TtxbrrjjA, color_0);
						num = ((int)num2 * -7304703) ^ -34957911;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!_W4jOxbRDzppFv0IAFpA5Blo7CjUA.smethod_3(string_))
						{
							num3 = 711520425;
							num4 = 711520425;
						}
						else
						{
							num3 = 1321233778;
							num4 = 1321233778;
						}
						num = num3 ^ ((int)num2 * -2026532883);
						continue;
					}
					case 0u:
						break;
					case 3u:
						return;
					case 5u:
						return;
					default:
						spriteBatch_0._FY70IFLoBond3ORPe0ndCLvIeVcA(spriteFont_0, string_, vector2_0 + _BK3BSdlEv4xSjAlS93TtxbrrjjA, color_0);
						return;
					}
					break;
				}
			}
		}

		private string _Jnjh8hNzVbH0Eov4seqBq1UNOCq()
		{
			if (_3wk7bXUbhNqSQ9kMD9hieEubOhG == 0)
			{
				goto IL_009c;
			}
			goto IL_0185;
			IL_0185:
			int num;
			int num2;
			if (_3wk7bXUbhNqSQ9kMD9hieEubOhG >= _W4jOxbRDzppFv0IAFpA5Blo7CjUA.smethod_0(_Si5dw38ImuGLFJvc8DC1FoIc0PG))
			{
				num = -1321362189;
				num2 = -1321362189;
			}
			else
			{
				num = -1768401219;
				num2 = -1768401219;
			}
			goto IL_012f;
			IL_012f:
			int num4 = default(int);
			int num5 = default(int);
			string string_ = default(string);
			string text = default(string);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num ^ 0x87F60693u) % 13u)
				{
				case 12u:
					num4 = 0;
					num5 = _W4jOxbRDzppFv0IAFpA5Blo7CjUA.smethod_5(string_, '░');
					num = (int)((num3 * 1785941667) ^ 0x40E9F61D);
					continue;
				case 11u:
				{
					int num6;
					int num7;
					if (num4 >= _W4jOxbRDzppFv0IAFpA5Blo7CjUA.smethod_0(string_))
					{
						num6 = -1348908708;
						num7 = -1348908708;
					}
					else
					{
						num6 = -137567111;
						num7 = -137567111;
					}
					num = num6 ^ ((int)num3 * -1592913172);
					continue;
				}
				case 9u:
					text = string.Empty;
					num = -508706914;
					continue;
				case 8u:
					string_ = _W4jOxbRDzppFv0IAFpA5Blo7CjUA.smethod_4(_Si5dw38ImuGLFJvc8DC1FoIc0PG, 0, _3wk7bXUbhNqSQ9kMD9hieEubOhG);
					num = -2130947613;
					continue;
				case 7u:
					break;
				case 6u:
					text = _W4jOxbRDzppFv0IAFpA5Blo7CjUA.smethod_6(text, _W4jOxbRDzppFv0IAFpA5Blo7CjUA.smethod_8(string_, num4));
					num = (int)((num3 * 375104611) ^ 0x17544872);
					continue;
				case 4u:
					goto IL_00c4;
				case 3u:
					text = _W4jOxbRDzppFv0IAFpA5Blo7CjUA.smethod_6(text, _W4jOxbRDzppFv0IAFpA5Blo7CjUA.smethod_4(string_, num4, num5 - num4));
					num4 = num5 + 1;
					num5 = _W4jOxbRDzppFv0IAFpA5Blo7CjUA.smethod_7(string_, '░', num4);
					num = -512344230;
					continue;
				case 2u:
					num = ((int)num3 * -496822925) ^ 0x4E2280F7;
					continue;
				case 0u:
					string_ = _Si5dw38ImuGLFJvc8DC1FoIc0PG;
					num = ((int)num3 * -201260262) ^ -366391601;
					continue;
				case 1u:
					goto IL_0185;
				default:
					return text;
				case 10u:
					return string.Empty;
				}
				break;
				IL_00c4:
				int num8;
				if (num5 >= 0)
				{
					num = -1871828857;
					num8 = -1871828857;
				}
				else
				{
					num = -759425380;
					num8 = -759425380;
				}
			}
			goto IL_009c;
			IL_009c:
			num = -69608379;
			goto IL_012f;
		}

		static int smethod_0(string string_0)
		{
			return string_0.Length;
		}

		static string smethod_1(string string_0)
		{
			return string_0.Trim();
		}

		static char smethod_2(string string_0, int int_0)
		{
			return string_0[int_0];
		}

		static bool smethod_3(string string_0)
		{
			return string.IsNullOrEmpty(string_0);
		}

		static string smethod_4(string string_0, int int_0, int int_1)
		{
			return string_0.Substring(int_0, int_1);
		}

		static int smethod_5(string string_0, char char_0)
		{
			return string_0.IndexOf(char_0);
		}

		static string smethod_6(string string_0, string string_1)
		{
			return string_0 + string_1;
		}

		static int smethod_7(string string_0, char char_0, int int_0)
		{
			return string_0.IndexOf(char_0, int_0);
		}

		static string smethod_8(string string_0, int int_0)
		{
			return string_0.Substring(int_0);
		}
	}

	private class _3Kf8FQeGRyCD8FhytGMMBQFkhFl : _8lVOgkauaSHbAkAqHzI1K7mIyOI
	{
		private readonly _iHJrndJdM1jj9TEnuU3BvgdDuvf[] _92GwVFulItjaDs6osQZyIk9xgMH;

		private int _VZ02JDgQaX5qJVSBot6TM2rtZ3O;

		public int _mc4p6vpMBZ0hOHPqLBE5H6OxT7f { get; private set; }

		public bool _zatbtX2c8i2hGOTptNymBxA8kVI { get; private set; }

		public _3Kf8FQeGRyCD8FhytGMMBQFkhFl(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, Texture2D texture2D_0, Texture2D texture2D_1, SpriteFont spriteFont_0)
			: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		{
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			//IL_013e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0176: Unknown result type (might be due to invalid IL or missing references)
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			_92GwVFulItjaDs6osQZyIk9xgMH = new _iHJrndJdM1jj9TEnuU3BvgdDuvf[5];
			_mc4p6vpMBZ0hOHPqLBE5H6OxT7f = -1;
			_VZ02JDgQaX5qJVSBot6TM2rtZ3O = 0;
			_92GwVFulItjaDs6osQZyIk9xgMH[0] = _QVqIVxBeF2SAQh6HDFwwp2RFmXB(texture2D_0, texture2D_1, spriteFont_0, "Choice 1", new Color(250, 251, 162), 0, 0, new Rectangle(0, 0, texture2D_0.get_Width(), texture2D_0.get_Height()), _ICiyaoVDO6XvJb0FsHkwv7e4YrS);
			_92GwVFulItjaDs6osQZyIk9xgMH[1] = _QVqIVxBeF2SAQh6HDFwwp2RFmXB(texture2D_0, texture2D_1, spriteFont_0, "Choice 2", new Color(165, 250, 171), 0, 0, new Rectangle(0, 0, texture2D_0.get_Width(), texture2D_0.get_Height()), _hXUKutqtuyapSBUWT1AVUzerGjc);
			_92GwVFulItjaDs6osQZyIk9xgMH[2] = _QVqIVxBeF2SAQh6HDFwwp2RFmXB(texture2D_0, texture2D_1, spriteFont_0, "Choice 3", new Color(171, 199, 255), 0, 0, new Rectangle(0, 0, texture2D_0.get_Width(), texture2D_0.get_Height()), _IniwNTOJAFQzPUg40NMaN8sku9k);
			_92GwVFulItjaDs6osQZyIk9xgMH[3] = _QVqIVxBeF2SAQh6HDFwwp2RFmXB(texture2D_0, texture2D_1, spriteFont_0, "Choice 4", new Color(228, 187, 253), 0, 0, new Rectangle(0, 0, texture2D_0.get_Width(), texture2D_0.get_Height()), _5TLz87dh7yxXEP5B2Lceq9uOAp1);
			_92GwVFulItjaDs6osQZyIk9xgMH[4] = _QVqIVxBeF2SAQh6HDFwwp2RFmXB(texture2D_0, texture2D_1, spriteFont_0, "Choice 5", new Color(255, 171, 179), 0, 0, new Rectangle(0, 0, texture2D_0.get_Width(), texture2D_0.get_Height()), _0wd4x937or88gFFP0wpuEK3BkyM);
			_mXNb0ylIEgd0VJEHTX3MBvFWYEf(-1);
		}

		public void _ww4wA3UwGXxaAlMqo3jhy6Bnh8g(params string[] string_0)
		{
			if (string_0.Length == 0)
			{
				goto IL_019a;
			}
			goto IL_02c4;
			IL_02c4:
			_zatbtX2c8i2hGOTptNymBxA8kVI = true;
			_mc4p6vpMBZ0hOHPqLBE5H6OxT7f = 0;
			_VZ02JDgQaX5qJVSBot6TM2rtZ3O = 0;
			int num = 1427941031;
			goto IL_025d;
			IL_025d:
			int num4 = default(int);
			int num6 = default(int);
			int num3 = default(int);
			int num5 = default(int);
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6F71AFu) % 21u)
				{
				case 20u:
					_92GwVFulItjaDs6osQZyIk9xgMH[num4]._7Xn1C5tjYnmIif1iZKV8AWsEEbL = (int)((float)(1920 - _92GwVFulItjaDs6osQZyIk9xgMH[num4]._2psWLw4AI8EIjQzaXnhGg8M1FnaA.Width) / 2f);
					num = 1176999964;
					continue;
				case 19u:
					num6++;
					num = (int)(num2 * 530061372) ^ -1852611182;
					continue;
				case 17u:
					_92GwVFulItjaDs6osQZyIk9xgMH[num3]._K87Hdb6ToAR0us3tN3ZmvHdPdeJ = string_0[num3];
					num = 649464628;
					continue;
				case 16u:
					_92GwVFulItjaDs6osQZyIk9xgMH[num3]._Fxy2SlgceW90FloFw6a1AEJODYA = true;
					_VZ02JDgQaX5qJVSBot6TM2rtZ3O++;
					num3++;
					num = ((int)num2 * -959565110) ^ -856636958;
					continue;
				case 14u:
					num = ((int)num2 * -974367006) ^ 0x22BA9DA2;
					continue;
				case 13u:
				{
					int num7;
					int num8;
					if (num3 >= _92GwVFulItjaDs6osQZyIk9xgMH.Length)
					{
						num7 = 1198136334;
						num8 = 1198136334;
					}
					else
					{
						num7 = 1101424506;
						num8 = 1101424506;
					}
					num = num7 ^ (int)(num2 * 868469507);
					continue;
				}
				case 12u:
					break;
				case 10u:
					num6 = string_0.Length;
					num = 957959991;
					continue;
				case 9u:
					num5 = (int)(30f + (float)(690 - _92GwVFulItjaDs6osQZyIk9xgMH[0]._2psWLw4AI8EIjQzaXnhGg8M1FnaA.Height - (_92GwVFulItjaDs6osQZyIk9xgMH[0]._2psWLw4AI8EIjQzaXnhGg8M1FnaA.Height + 15) * (_VZ02JDgQaX5qJVSBot6TM2rtZ3O - 1)) / 2f);
					num = ((int)num2 * -769995861) ^ 0x25D60129;
					continue;
				case 8u:
					goto IL_0173;
				case 7u:
					goto end_IL_025d;
				case 6u:
					num4++;
					num = (int)(num2 * 1753464261) ^ -148342233;
					continue;
				case 5u:
					num4 = 0;
					num = ((int)num2 * -822632068) ^ -292338135;
					continue;
				case 4u:
					_92GwVFulItjaDs6osQZyIk9xgMH[num6]._Fxy2SlgceW90FloFw6a1AEJODYA = false;
					num = 1287232559;
					continue;
				case 3u:
					num = ((int)num2 * -28801181) ^ -1913072402;
					continue;
				case 2u:
					_92GwVFulItjaDs6osQZyIk9xgMH[num4]._bCjZ3VSXGKyhmykd2zCnQBiSpDf = num5 + (_92GwVFulItjaDs6osQZyIk9xgMH[num4]._2psWLw4AI8EIjQzaXnhGg8M1FnaA.Height + 15) * num4;
					num = (int)(num2 * 82065124) ^ -1766037068;
					continue;
				case 1u:
					goto IL_022b;
				case 0u:
					num3 = 0;
					num = ((int)num2 * -1251689888) ^ -1132742996;
					continue;
				default:
					return;
				case 15u:
					goto IL_02c4;
				case 11u:
					return;
				case 18u:
					return;
				}
				int num9;
				if (num3 >= string_0.Length)
				{
					num = 1731560319;
					num9 = 1731560319;
				}
				else
				{
					num = 1647277780;
					num9 = 1647277780;
				}
				continue;
				IL_022b:
				int num10;
				if (num4 >= _VZ02JDgQaX5qJVSBot6TM2rtZ3O)
				{
					num = 1659976335;
					num10 = 1659976335;
				}
				else
				{
					num = 611752264;
					num10 = 611752264;
				}
				continue;
				IL_0173:
				int num11;
				if (num6 >= _92GwVFulItjaDs6osQZyIk9xgMH.Length)
				{
					num = 879325707;
					num11 = 879325707;
				}
				else
				{
					num = 1437919732;
					num11 = 1437919732;
				}
				continue;
				end_IL_025d:
				break;
			}
			goto IL_019a;
			IL_019a:
			num = 787311287;
			goto IL_025d;
		}

		public void _mXNb0ylIEgd0VJEHTX3MBvFWYEf(int int_0)
		{
			_zatbtX2c8i2hGOTptNymBxA8kVI = false;
			_mc4p6vpMBZ0hOHPqLBE5H6OxT7f = int_0;
			_iHJrndJdM1jj9TEnuU3BvgdDuvf[] array = default(_iHJrndJdM1jj9TEnuU3BvgdDuvf[]);
			_iHJrndJdM1jj9TEnuU3BvgdDuvf iHJrndJdM1jj9TEnuU3BvgdDuvf = default(_iHJrndJdM1jj9TEnuU3BvgdDuvf);
			int num3 = default(int);
			while (true)
			{
				int num = 83726341;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x19717210u) % 9u)
					{
					case 8u:
						_VZ02JDgQaX5qJVSBot6TM2rtZ3O = 0;
						num = (int)(num2 * 1148294748) ^ -562460131;
						continue;
					case 7u:
						array = _92GwVFulItjaDs6osQZyIk9xgMH;
						num = ((int)num2 * -413153908) ^ -884684623;
						continue;
					case 5u:
						iHJrndJdM1jj9TEnuU3BvgdDuvf = array[num3];
						num = 645177357;
						continue;
					case 4u:
						iHJrndJdM1jj9TEnuU3BvgdDuvf._Fxy2SlgceW90FloFw6a1AEJODYA = false;
						num3++;
						num = (int)(num2 * 1237601048) ^ -1279942406;
						continue;
					case 3u:
						num = (int)((num2 * 1322690697) ^ 0x58058B83);
						continue;
					case 1u:
					{
						int num4;
						if (num3 >= array.Length)
						{
							num = 88929803;
							num4 = 88929803;
						}
						else
						{
							num = 1776213714;
							num4 = 1776213714;
						}
						continue;
					}
					case 0u:
						num3 = 0;
						num = ((int)num2 * -77716038) ^ 0x20B0E3DB;
						continue;
					default:
						return;
					case 6u:
						break;
					case 2u:
						return;
					}
					break;
				}
			}
		}

		private void _ICiyaoVDO6XvJb0FsHkwv7e4YrS()
		{
			_mXNb0ylIEgd0VJEHTX3MBvFWYEf(1);
		}

		private void _hXUKutqtuyapSBUWT1AVUzerGjc()
		{
			_mXNb0ylIEgd0VJEHTX3MBvFWYEf(2);
		}

		private void _IniwNTOJAFQzPUg40NMaN8sku9k()
		{
			_mXNb0ylIEgd0VJEHTX3MBvFWYEf(3);
		}

		private void _5TLz87dh7yxXEP5B2Lceq9uOAp1()
		{
			_mXNb0ylIEgd0VJEHTX3MBvFWYEf(4);
		}

		private void _0wd4x937or88gFFP0wpuEK3BkyM()
		{
			_mXNb0ylIEgd0VJEHTX3MBvFWYEf(5);
		}
	}

	private struct _DVKVvNZmeqGXSzmpcRmcXttpiKC
	{
		public static readonly _DVKVvNZmeqGXSzmpcRmcXttpiKC _LPPPQ033UFYBL4fz3qUtSfOD75I = new _DVKVvNZmeqGXSzmpcRmcXttpiKC(100, 750, 2000);

		public static readonly _DVKVvNZmeqGXSzmpcRmcXttpiKC _e6GzQtekajGAokkayN1IPGIhCKx;

		public static readonly _DVKVvNZmeqGXSzmpcRmcXttpiKC _NN1aVVAo1wwjW67j2cNcdp7rWET;

		public static readonly _DVKVvNZmeqGXSzmpcRmcXttpiKC _4d4FmftbqsXGnBhU8JorfUifjoo;

		public int _aFbxCmyEb7GMPT5kU3P9NvcWQgK { get; }

		public int _a5fUssbr0SWbg9Sv48tHvMxW2ic { get; }

		public int _TDuCcAGW0lPdvxvfHyDM3aP4i84 { get; }

		private _DVKVvNZmeqGXSzmpcRmcXttpiKC(int int_0, int int_1, int int_2)
		{
			_Z0PczRXoob7ELJ9tv4wCi8ZZKmJ = int_0;
			_i6vGYRDs82JalRkikuHhVIpANsf = int_1;
			_cNHarziciuhFNrgu75Fpww06cAy = int_2;
		}

		static _DVKVvNZmeqGXSzmpcRmcXttpiKC()
		{
			while (true)
			{
				int num = -721998822;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x92C7F1DEu) % 3u)
					{
					case 1u:
						goto IL_0018;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
					IL_0018:
					_e6GzQtekajGAokkayN1IPGIhCKx = new _DVKVvNZmeqGXSzmpcRmcXttpiKC(60, 450, 1500);
					_NN1aVVAo1wwjW67j2cNcdp7rWET = new _DVKVvNZmeqGXSzmpcRmcXttpiKC(30, 300, 1000);
					_4d4FmftbqsXGnBhU8JorfUifjoo = new _DVKVvNZmeqGXSzmpcRmcXttpiKC(0, 0, 1000);
					num = (int)(num2 * 1908325037) ^ -720099768;
				}
			}
		}
	}

	private static _nkzqFdEfDyLcyGikIKGcHjklI4y _6T55wit7MiGfAWRkPwjNbJ8N8lG;

	private readonly _JbeCmOie0phb2cbgG6DdGZrbs3pB _4L7hfXrWoDdArQiscG4ukHCV46B;

	private readonly Texture2D _P62DygY6CKZG8s5wqDu0uAFksjs;

	private readonly SpriteFont _xnYepZuegigJCU2jcbZsfVIakzF;

	private readonly SpriteFont _23jI7jMreLgRTSs5rhEGCUkow2b;

	private readonly Vector2 _rv7JIIMY4Ta1tpSvflng4Lose4H;

	private readonly Vector2 _4djSc5RiRJZMGzvYwwEprIYf6ZM;

	private readonly Vector2[] _gWIuAj6CuJjxiHOmaYwYLvu8g0r;

	private readonly _3Kf8FQeGRyCD8FhytGMMBQFkhFl _fp8jsuSnELXqf2yy2JQDaXDCBVQ;

	private Desktop _9GQBAH2pi8Sm6ph1s6InjyQGe6R;

	private DialogueSpeed _tAC7ojbHHd15LKk7rGbelW2nGWN;

	private _DVKVvNZmeqGXSzmpcRmcXttpiKC _4V6bFHOi28R2wJIOaQKs1A0pIQ0;

	private DropDownList _xU7PBNQL0I3LiOcbd02e8KK5uYi;

	private bool _O7kX3MfMCx3M2dVro1UbOCbajyo;

	private CheckBox _2pNQedwLe7YapSxneCqi4SreGdH;

	private _QGnsmTImvr3dFBCr8hpzDZiCWLP _lMAOhEkyOOJcbuU0ONDYvJ8bs8w;

	private _IIGQSKohQsLi09FILC8oKHG5UXG _NYF6CyMYCqbkxJ8Q1N7O3ehzldE;

	private _IIGQSKohQsLi09FILC8oKHG5UXG _MOBkoboXIfjixJIW15TJTdFlwDC;

	private int _Q7Kx7ErHf3u1QIUDKfFCKSXbznG;

	private _oDZZ0F7Qg08utTIjAaoyIbeDuFG _3wk7bXUbhNqSQ9kMD9hieEubOhG;

	public static bool _xJZUPxDatEzfPQc0nRHR2D1Vwke => _6T55wit7MiGfAWRkPwjNbJ8N8lG._NYF6CyMYCqbkxJ8Q1N7O3ehzldE == _IIGQSKohQsLi09FILC8oKHG5UXG.Done;

	public static bool _zatbtX2c8i2hGOTptNymBxA8kVI => _6T55wit7MiGfAWRkPwjNbJ8N8lG._fp8jsuSnELXqf2yy2JQDaXDCBVQ._zatbtX2c8i2hGOTptNymBxA8kVI;

	public static int _rVWIUtPzqmWcZbPclkfMRcIkeGR => _6T55wit7MiGfAWRkPwjNbJ8N8lG._fp8jsuSnELXqf2yy2JQDaXDCBVQ._mc4p6vpMBZ0hOHPqLBE5H6OxT7f;

	public static DialogueSpeed _NhL238TaCbkDiY6HXlWXZzzUYkm
	{
		get
		{
			return _6T55wit7MiGfAWRkPwjNbJ8N8lG._tAC7ojbHHd15LKk7rGbelW2nGWN;
		}
		set
		{
			_6T55wit7MiGfAWRkPwjNbJ8N8lG._tAC7ojbHHd15LKk7rGbelW2nGWN = value;
			DialogueSpeed tAC7ojbHHd15LKk7rGbelW2nGWN = _6T55wit7MiGfAWRkPwjNbJ8N8lG._tAC7ojbHHd15LKk7rGbelW2nGWN;
			while (true)
			{
				int num = 247684904;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x548A9FFDu) % 10u)
					{
					case 9u:
						_6T55wit7MiGfAWRkPwjNbJ8N8lG._4V6bFHOi28R2wJIOaQKs1A0pIQ0 = _DVKVvNZmeqGXSzmpcRmcXttpiKC._NN1aVVAo1wwjW67j2cNcdp7rWET;
						num = 17596957;
						continue;
					case 8u:
						goto IL_0034;
					case 5u:
						goto IL_004a;
					case 4u:
						num = ((int)num2 * -493678305) ^ -2089455007;
						continue;
					case 3u:
						switch (tAC7ojbHHd15LKk7rGbelW2nGWN)
						{
						case DialogueSpeed.Fast:
							break;
						case DialogueSpeed.Normal:
							goto IL_0034;
						case DialogueSpeed.Slow:
							goto IL_004a;
						default:
							goto IL_0085;
						case DialogueSpeed.Instant:
							goto IL_0094;
						}
						goto case 9u;
					case 0u:
						goto IL_0094;
					case 2u:
						_6T55wit7MiGfAWRkPwjNbJ8N8lG._R3gvtOBYRg2VLQrb2zkAwC846nt();
						num = 1108493310;
						continue;
					case 1u:
						num = (int)(num2 * 1630721331) ^ -467472304;
						continue;
					default:
						return;
					case 6u:
						break;
					case 7u:
						return;
						IL_0094:
						_6T55wit7MiGfAWRkPwjNbJ8N8lG._4V6bFHOi28R2wJIOaQKs1A0pIQ0 = _DVKVvNZmeqGXSzmpcRmcXttpiKC._4d4FmftbqsXGnBhU8JorfUifjoo;
						num = 17596957;
						continue;
						IL_0085:
						num = (int)(num2 * 387123623) ^ -1237775350;
						continue;
						IL_004a:
						_6T55wit7MiGfAWRkPwjNbJ8N8lG._4V6bFHOi28R2wJIOaQKs1A0pIQ0 = _DVKVvNZmeqGXSzmpcRmcXttpiKC._LPPPQ033UFYBL4fz3qUtSfOD75I;
						num = 17596957;
						continue;
						IL_0034:
						_6T55wit7MiGfAWRkPwjNbJ8N8lG._4V6bFHOi28R2wJIOaQKs1A0pIQ0 = _DVKVvNZmeqGXSzmpcRmcXttpiKC._e6GzQtekajGAokkayN1IPGIhCKx;
						num = 1828193666;
						continue;
					}
					break;
				}
			}
		}
	}

	public static bool _fUgDiz7KX8TZUVzFlTeXMOhmfUT
	{
		get
		{
			return _6T55wit7MiGfAWRkPwjNbJ8N8lG._O7kX3MfMCx3M2dVro1UbOCbajyo;
		}
		set
		{
			_6T55wit7MiGfAWRkPwjNbJ8N8lG._O7kX3MfMCx3M2dVro1UbOCbajyo = value;
			_6T55wit7MiGfAWRkPwjNbJ8N8lG._EwAojaUxtAdk1E5cI9aRmcwPirB();
		}
	}

	public _nkzqFdEfDyLcyGikIKGcHjklI4y(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, Texture2D texture2D_0, Texture2D texture2D_1, SpriteFont spriteFont_0, SpriteFont spriteFont_1)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			int num = 929186529;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2CA5017Cu) % 7u)
				{
				case 6u:
					_gWIuAj6CuJjxiHOmaYwYLvu8g0r = (Vector2[])(object)new Vector2[6]
					{
						new Vector2(75f, 720f),
						new Vector2(75f, 770f),
						new Vector2(75f, 820f),
						new Vector2(75f, 870f),
						new Vector2(75f, 920f),
						new Vector2(75f, 970f)
					};
					num = (int)(num2 * 469714778) ^ -1426725194;
					continue;
				case 4u:
					_4djSc5RiRJZMGzvYwwEprIYf6ZM = new Vector2(75f, 625f);
					num = (int)((num2 * 1882721743) ^ 0x1868E3EF);
					continue;
				case 3u:
					_6T55wit7MiGfAWRkPwjNbJ8N8lG = this;
					_4L7hfXrWoDdArQiscG4ukHCV46B = _JbeCmOie0phb2cbgG6DdGZrbs3pB_0;
					_P62DygY6CKZG8s5wqDu0uAFksjs = texture2D_0;
					num = (int)(num2 * 583774996) ^ -1296315426;
					continue;
				case 2u:
					_xnYepZuegigJCU2jcbZsfVIakzF = spriteFont_0;
					_23jI7jMreLgRTSs5rhEGCUkow2b = spriteFont_1;
					_rv7JIIMY4Ta1tpSvflng4Lose4H = new Vector2((float)(_nkzqFdEfDyLcyGikIKGcHjklI4y.smethod_0(texture2D_0) - 1920) / 2f, (float)(1080 - _nkzqFdEfDyLcyGikIKGcHjklI4y.smethod_1(texture2D_0)));
					num = ((int)num2 * -1701497058) ^ -716027872;
					continue;
				case 1u:
					_fp8jsuSnELXqf2yy2JQDaXDCBVQ = new _3Kf8FQeGRyCD8FhytGMMBQFkhFl(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, texture2D_1, null, spriteFont_0);
					_NhL238TaCbkDiY6HXlWXZzzUYkm = DialogueSpeed.Normal;
					num = (int)((num2 * 848192978) ^ 0xA4FD700);
					continue;
				case 0u:
					break;
				default:
					_dRHb7tDcI5IkrHNRAFSme9H1Rh4();
					return;
				}
				break;
			}
		}
	}

	private void _dRHb7tDcI5IkrHNRAFSme9H1Rh4()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Expected O, but got Unknown
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected O, but got Unknown
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_048f: Expected O, but got Unknown
		Desktop obj = _nkzqFdEfDyLcyGikIKGcHjklI4y.smethod_2();
		_nkzqFdEfDyLcyGikIKGcHjklI4y.smethod_4(obj, _nkzqFdEfDyLcyGikIKGcHjklI4y.smethod_3());
		((Control)obj).set_Size(new Point(1920, 1080));
		_9GQBAH2pi8Sm6ph1s6InjyQGe6R = obj;
		FlowLayoutFrame val2 = default(FlowLayoutFrame);
		Button val3 = default(Button);
		Button val5 = default(Button);
		Button val6 = default(Button);
		while (true)
		{
			int num = -1436584998;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8EDC94DBu) % 7u)
				{
				case 6u:
					((Control)_xU7PBNQL0I3LiOcbd02e8KK5uYi.get_Listbox().get_Scrollbar().get_ButtonUp()).set_Visible(false);
					num = (int)((num2 * 2045604718) ^ 0x34D97F8D);
					continue;
				case 5u:
				{
					_9GQBAH2pi8Sm6ph1s6InjyQGe6R._EMnZAXxoqoahiGOiNjffRycLtDE("Assets/GUI/Squid/DefaultSkin");
					FlowLayoutFrame val7 = new FlowLayoutFrame();
					((Control)val7).set_Position(new Point(1220, (int)_4djSc5RiRJZMGzvYwwEprIYf6ZM.Y + 10));
					val7.set_FlowDirection((FlowDirection)1);
					((Control)val7).set_Margin(new Margin(0, 0, 100, 0));
					val7.set_HSpacing(10);
					((Control)val7).set_Size(new Point(650, 30));
					val2 = val7;
					num = (int)((num2 * 1731876518) ^ 0x21B720DA);
					continue;
				}
				case 2u:
				{
					Button val10 = new Button();
					((Control)val10).set_Size(new Point(100, 30));
					((Label)val10).set_TextAlign((Alignment)4);
					((Label)val10).set_Text("Exit");
					val3 = val10;
					((Control)val3).add_MouseClick((MouseEvent)delegate
					{
						_4L7hfXrWoDdArQiscG4ukHCV46B._MES3SBLNIcxOd5F8ZqVEWmsIcmA(_9GQBAH2pi8Sm6ph1s6InjyQGe6R, delegate(bool bool_0)
						{
							_fp8jsuSnELXqf2yy2JQDaXDCBVQ._nJKYvZJ57vjjlQwmoeBmKihtS0b = bool_0;
						});
					});
					DropDownList val11 = new DropDownList();
					((Control)val11).set_Style("button");
					((Control)val11).set_Size(new Point(120, 30));
					val11.set_DropdownAbove(true);
					val11.get_Label().set_TextAlign((Alignment)4);
					val11.get_Label().set_AutoEllipsis(false);
					val11.get_Dropdown().set_Resizable(false);
					((Control)val11.get_Button()).set_Visible(false);
					_xU7PBNQL0I3LiOcbd02e8KK5uYi = val11;
					num = ((int)num2 * -1471994682) ^ -367646328;
					continue;
				}
				case 1u:
				{
					Button val9 = new Button();
					((Control)val9).set_Size(new Point(100, 30));
					((Label)val9).set_TextAlign((Alignment)4);
					((Label)val9).set_Text("Save");
					val5 = val9;
					num = (int)(num2 * 821978558) ^ -785537944;
					continue;
				}
				case 0u:
				{
					((Control)val5).add_MouseClick((MouseEvent)delegate
					{
						_4L7hfXrWoDdArQiscG4ukHCV46B._8c7SHmhI0bvgm2S0W4WafcEBOzV(_9GQBAH2pi8Sm6ph1s6InjyQGe6R, delegate(bool bool_0)
						{
							_fp8jsuSnELXqf2yy2JQDaXDCBVQ._nJKYvZJ57vjjlQwmoeBmKihtS0b = bool_0;
						});
					});
					Button val8 = new Button();
					((Control)val8).set_Size(new Point(100, 30));
					((Label)val8).set_TextAlign((Alignment)4);
					((Label)val8).set_Text("Load");
					val6 = val8;
					((Control)val6).add_MouseClick((MouseEvent)delegate
					{
						_4L7hfXrWoDdArQiscG4ukHCV46B._xM8d2LuC070Xft2N9A0ulzGVshq(_9GQBAH2pi8Sm6ph1s6InjyQGe6R, delegate(bool bool_0)
						{
							_fp8jsuSnELXqf2yy2JQDaXDCBVQ._nJKYvZJ57vjjlQwmoeBmKihtS0b = bool_0;
						});
					});
					num = ((int)num2 * -1918457203) ^ -1709783085;
					continue;
				}
				case 3u:
					break;
				default:
				{
					((Control)_xU7PBNQL0I3LiOcbd02e8KK5uYi.get_Listbox().get_Scrollbar().get_ButtonDown()).set_Visible(false);
					IEnumerator enumerator = Enum.GetValues(typeof(DialogueSpeed)).GetEnumerator();
					try
					{
						while (true)
						{
							IL_031c:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = -668935767;
								num4 = -668935767;
							}
							else
							{
								num3 = -159563942;
								num4 = -159563942;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x8EDC94DBu) % 4u)
								{
								case 1u:
								{
									DialogueSpeed dialogueSpeed = (DialogueSpeed)enumerator.Current;
									ActiveList<ListBoxItem> items = _xU7PBNQL0I3LiOcbd02e8KK5uYi.get_Items();
									ListBoxItem val = new ListBoxItem();
									((Label)val).set_Text(dialogueSpeed.ToString());
									((Control)val).set_Size(new Point(0, 30));
									val.set_Value((object)dialogueSpeed);
									items.Add(val);
									num3 = -1907286324;
									continue;
								}
								case 0u:
									num3 = -159563942;
									continue;
								default:
									goto end_IL_02eb;
								case 3u:
									break;
								case 2u:
									goto end_IL_02eb;
								}
								goto IL_031c;
								continue;
								end_IL_02eb:
								break;
							}
							break;
						}
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						while (true)
						{
							IL_0394:
							int num5 = -694836990;
							while (true)
							{
								switch ((num2 = (uint)num5 ^ 0x8EDC94DBu) % 4u)
								{
								case 2u:
									disposable.Dispose();
									num5 = ((int)num2 * -1304087120) ^ 0x3D7D882C;
									continue;
								case 1u:
								{
									int num6;
									int num7;
									if (disposable == null)
									{
										num6 = -739984680;
										num7 = -739984680;
									}
									else
									{
										num6 = -1973413579;
										num7 = -1973413579;
									}
									num5 = num6 ^ (int)(num2 * 1384982324);
									continue;
								}
								default:
									goto end_IL_0372;
								case 0u:
									break;
								case 3u:
									goto end_IL_0372;
								}
								goto IL_0394;
								continue;
								end_IL_0372:
								break;
							}
							break;
						}
					}
					_xU7PBNQL0I3LiOcbd02e8KK5uYi.add_SelectedItemChanged((SelectedItemChangedEventHandler)delegate(Control control_0, ListBoxItem listBoxItem_0)
					{
						_NhL238TaCbkDiY6HXlWXZzzUYkm = (DialogueSpeed)_nkzqFdEfDyLcyGikIKGcHjklI4y.smethod_15(listBoxItem_0);
						_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._wVLRBSMULz8GfedBPXaVJB0sBEO = _tAC7ojbHHd15LKk7rGbelW2nGWN;
					});
					while (true)
					{
						int num8 = -1610442536;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0x8EDC94DBu) % 8u)
							{
							case 6u:
								((ActiveList<Control>)(object)_9GQBAH2pi8Sm6ph1s6InjyQGe6R.get_Controls()).Add((Control)(object)val2);
								num8 = ((int)num2 * -1481775290) ^ 0x16E03BFA;
								continue;
							case 4u:
								((ActiveList<Control>)(object)((Frame)val2).get_Controls()).Add((Control)(object)val5);
								((ActiveList<Control>)(object)((Frame)val2).get_Controls()).Add((Control)(object)val6);
								num8 = ((int)num2 * -1522189317) ^ 0xF2B22A5;
								continue;
							case 3u:
							{
								CheckBox val4 = new CheckBox();
								val4.set_Text("Auto-skip");
								((Control)val4).set_Size(new Point(140, 30));
								val4.set_Checked(_fUgDiz7KX8TZUVzFlTeXMOhmfUT);
								_2pNQedwLe7YapSxneCqi4SreGdH = val4;
								num8 = (int)(num2 * 1985053027) ^ -1797390885;
								continue;
							}
							case 2u:
								((ActiveList<Control>)(object)((Frame)val2).get_Controls()).Add((Control)(object)val3);
								((ActiveList<Control>)(object)((Frame)val2).get_Controls()).Add((Control)(object)_2pNQedwLe7YapSxneCqi4SreGdH);
								num8 = (int)(num2 * 1987085979) ^ -337178171;
								continue;
							case 1u:
								_2pNQedwLe7YapSxneCqi4SreGdH.add_CheckedChanged((VoidEvent)delegate
								{
									_fUgDiz7KX8TZUVzFlTeXMOhmfUT = _nkzqFdEfDyLcyGikIKGcHjklI4y.smethod_16(_2pNQedwLe7YapSxneCqi4SreGdH);
									while (true)
									{
										int num9 = 1807803514;
										while (true)
										{
											uint num10;
											switch ((num10 = (uint)num9 ^ 0x46CE6E1Fu) % 3u)
											{
											case 1u:
												goto IL_0012;
											default:
												return;
											case 0u:
												break;
											case 2u:
												return;
											}
											break;
											IL_0012:
											_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._sbK0941BvW8HgPboNwOhIAd2jP3 = _O7kX3MfMCx3M2dVro1UbOCbajyo;
											num9 = ((int)num10 * -962940535) ^ -839672458;
										}
									}
								});
								num8 = (int)((num2 * 1911701621) ^ 0x65B1BAFA);
								continue;
							case 0u:
								((ActiveList<Control>)(object)((Frame)val2).get_Controls()).Add((Control)(object)_xU7PBNQL0I3LiOcbd02e8KK5uYi);
								num8 = (int)(num2 * 1335372332) ^ -810808923;
								continue;
							default:
								return;
							case 7u:
								break;
							case 5u:
								return;
							}
							break;
						}
					}
				}
				}
				break;
			}
		}
	}

	private void _R3gvtOBYRg2VLQrb2zkAwC846nt()
	{
		if (_6T55wit7MiGfAWRkPwjNbJ8N8lG._xU7PBNQL0I3LiOcbd02e8KK5uYi != null)
		{
			_nkzqFdEfDyLcyGikIKGcHjklI4y.smethod_6(_6T55wit7MiGfAWRkPwjNbJ8N8lG._xU7PBNQL0I3LiOcbd02e8KK5uYi, ((IEnumerable<ListBoxItem>)_nkzqFdEfDyLcyGikIKGcHjklI4y.smethod_5(_6T55wit7MiGfAWRkPwjNbJ8N8lG._xU7PBNQL0I3LiOcbd02e8KK5uYi)).First((ListBoxItem listBoxItem_0) => (DialogueSpeed)_nkzqFdEfDyLcyGikIKGcHjklI4y.smethod_15(listBoxItem_0) == _tAC7ojbHHd15LKk7rGbelW2nGWN));
		}
	}

	private void _EwAojaUxtAdk1E5cI9aRmcwPirB()
	{
		if (_6T55wit7MiGfAWRkPwjNbJ8N8lG._2pNQedwLe7YapSxneCqi4SreGdH == null)
		{
			goto IL_000c;
		}
		goto IL_0030;
		IL_0030:
		_nkzqFdEfDyLcyGikIKGcHjklI4y.smethod_7(_6T55wit7MiGfAWRkPwjNbJ8N8lG._2pNQedwLe7YapSxneCqi4SreGdH, _O7kX3MfMCx3M2dVro1UbOCbajyo);
		int num = 824297860;
		goto IL_0011;
		IL_0011:
		switch ((uint)(num ^ 0x1C85D0B2) % 4u)
		{
		case 3u:
			break;
		default:
			return;
		case 0u:
			goto IL_0030;
		case 1u:
			return;
		case 2u:
			return;
		}
		goto IL_000c;
		IL_000c:
		num = 889710071;
		goto IL_0011;
	}

	public void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		_QGnsmTImvr3dFBCr8hpzDZiCWLP lMAOhEkyOOJcbuU0ONDYvJ8bs8w = _lMAOhEkyOOJcbuU0ONDYvJ8bs8w;
		while (true)
		{
			int num = -498046739;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFDE6EC69u) % 13u)
				{
				case 12u:
				{
					int num4;
					int num5;
					if (lMAOhEkyOOJcbuU0ONDYvJ8bs8w == _QGnsmTImvr3dFBCr8hpzDZiCWLP.None)
					{
						num4 = -313893296;
						num5 = -313893296;
					}
					else
					{
						num4 = -1385896995;
						num5 = -1385896995;
					}
					num = num4 ^ (int)(num2 * 481388172);
					continue;
				}
				case 9u:
				{
					int num8;
					int num9;
					if (_4L7hfXrWoDdArQiscG4ukHCV46B._5zNdOw7qHmuCAPJFMr3SsZdBlCr != null)
					{
						num8 = 111228923;
						num9 = 111228923;
					}
					else
					{
						num8 = 1006749678;
						num9 = 1006749678;
					}
					num = num8 ^ (int)(num2 * 1746077652);
					continue;
				}
				case 8u:
					num = (int)(num2 * 204287262) ^ -467740141;
					continue;
				case 7u:
				{
					int num6;
					int num7;
					if (lMAOhEkyOOJcbuU0ONDYvJ8bs8w != _QGnsmTImvr3dFBCr8hpzDZiCWLP.Started)
					{
						num6 = 1973708994;
						num7 = 1973708994;
					}
					else
					{
						num6 = 1812942417;
						num7 = 1812942417;
					}
					num = num6 ^ ((int)num2 * -2025197731);
					continue;
				}
				case 6u:
					_fp8jsuSnELXqf2yy2JQDaXDCBVQ._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
					num = -845153679;
					continue;
				case 5u:
				{
					int num3;
					if (_fp8jsuSnELXqf2yy2JQDaXDCBVQ._nJKYvZJ57vjjlQwmoeBmKihtS0b)
					{
						num = -550240264;
						num3 = -550240264;
					}
					else
					{
						num = -1385202721;
						num3 = -1385202721;
					}
					continue;
				}
				case 1u:
					_mBZq0n4Bks2rpEfFwuLZ2Mlxlwi(gameTime_0);
					num = -18671837;
					continue;
				case 0u:
					_nkzqFdEfDyLcyGikIKGcHjklI4y.smethod_8(_9GQBAH2pi8Sm6ph1s6InjyQGe6R);
					num = ((int)num2 * -1808868629) ^ -2228056;
					continue;
				default:
					return;
				case 3u:
					break;
				case 2u:
					_lMAOhEkyOOJcbuU0ONDYvJ8bs8w = _QGnsmTImvr3dFBCr8hpzDZiCWLP.Visible;
					return;
				case 4u:
					return;
				case 10u:
					return;
				case 11u:
					return;
				}
				break;
			}
		}
	}

	private void _mBZq0n4Bks2rpEfFwuLZ2Mlxlwi(GameTime gameTime_0)
	{
		if (_NYF6CyMYCqbkxJ8Q1N7O3ehzldE == _IIGQSKohQsLi09FILC8oKHG5UXG.Done)
		{
			goto IL_011a;
		}
		goto IL_052c;
		IL_052c:
		int num;
		int num2;
		if (_NYF6CyMYCqbkxJ8Q1N7O3ehzldE == _IIGQSKohQsLi09FILC8oKHG5UXG.Waiting)
		{
			num = -890406144;
			num2 = -890406144;
		}
		else
		{
			num = -1262418243;
			num2 = -1262418243;
		}
		goto IL_0457;
		IL_0457:
		_IIGQSKohQsLi09FILC8oKHG5UXG nYF6CyMYCqbkxJ8Q1N7O3ehzldE = default(_IIGQSKohQsLi09FILC8oKHG5UXG);
		char c = default(char);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0xBBB440CDu) % 45u)
			{
			case 44u:
				break;
			case 42u:
				goto IL_004a;
			case 41u:
			{
				int num10;
				int num11;
				if (_MOBkoboXIfjixJIW15TJTdFlwDC != 0)
				{
					num10 = -76280915;
					num11 = -76280915;
				}
				else
				{
					num10 = -21620500;
					num11 = -21620500;
				}
				num = num10 ^ (int)(num3 * 2146953191);
				continue;
			}
			case 40u:
				_XDbzWLxDi2VVrJQrjjLsgcfdxju();
				num = (int)(num3 * 799811420) ^ -1232363402;
				continue;
			case 39u:
				nYF6CyMYCqbkxJ8Q1N7O3ehzldE = _NYF6CyMYCqbkxJ8Q1N7O3ehzldE;
				num = -1810493842;
				continue;
			case 37u:
				_NYF6CyMYCqbkxJ8Q1N7O3ehzldE = _IIGQSKohQsLi09FILC8oKHG5UXG.WaitForSkip;
				num = -509874086;
				continue;
			case 36u:
				_Q7Kx7ErHf3u1QIUDKfFCKSXbznG = _4V6bFHOi28R2wJIOaQKs1A0pIQ0._TDuCcAGW0lPdvxvfHyDM3aP4i84;
				num = (int)((num3 * 896826380) ^ 0x59F51DA9);
				continue;
			case 35u:
				_Q7Kx7ErHf3u1QIUDKfFCKSXbznG = _4V6bFHOi28R2wJIOaQKs1A0pIQ0._a5fUssbr0SWbg9Sv48tHvMxW2ic;
				num = (int)(num3 * 499723878) ^ -755586568;
				continue;
			case 34u:
				goto end_IL_0457;
			case 33u:
				goto IL_0124;
			case 32u:
				_Q7Kx7ErHf3u1QIUDKfFCKSXbznG = _4V6bFHOi28R2wJIOaQKs1A0pIQ0._aFbxCmyEb7GMPT5kU3P9NvcWQgK;
				num = -1084674931;
				continue;
			case 31u:
				_NYF6CyMYCqbkxJ8Q1N7O3ehzldE = _MOBkoboXIfjixJIW15TJTdFlwDC;
				_MOBkoboXIfjixJIW15TJTdFlwDC = _IIGQSKohQsLi09FILC8oKHG5UXG.None;
				num = (int)(num3 * 2040023334) ^ -1217148834;
				continue;
			case 30u:
				_Q7Kx7ErHf3u1QIUDKfFCKSXbznG = _4V6bFHOi28R2wJIOaQKs1A0pIQ0._TDuCcAGW0lPdvxvfHyDM3aP4i84;
				_NYF6CyMYCqbkxJ8Q1N7O3ehzldE = _IIGQSKohQsLi09FILC8oKHG5UXG.Waiting;
				_MOBkoboXIfjixJIW15TJTdFlwDC = _IIGQSKohQsLi09FILC8oKHG5UXG.Skip;
				num = (int)(num3 * 924619425) ^ -421091088;
				continue;
			case 29u:
			{
				int num6;
				int num7;
				if (_NYF6CyMYCqbkxJ8Q1N7O3ehzldE != _IIGQSKohQsLi09FILC8oKHG5UXG.Typing)
				{
					num6 = 366240587;
					num7 = 366240587;
				}
				else
				{
					num6 = 738257680;
					num7 = 738257680;
				}
				num = num6 ^ ((int)num3 * -1272232361);
				continue;
			}
			case 28u:
				num = (int)((num3 * 1484015215) ^ 0x28BB9DA1);
				continue;
			case 26u:
				goto IL_0209;
			case 25u:
			{
				int num14;
				int num15;
				if (!_fUgDiz7KX8TZUVzFlTeXMOhmfUT)
				{
					num14 = 323346370;
					num15 = 323346370;
				}
				else
				{
					num14 = 1642040625;
					num15 = 1642040625;
				}
				num = num14 ^ ((int)num3 * -1232264684);
				continue;
			}
			case 23u:
				_NYF6CyMYCqbkxJ8Q1N7O3ehzldE = _IIGQSKohQsLi09FILC8oKHG5UXG.Waiting;
				num = ((int)num3 * -1116156740) ^ 0x4DF7063;
				continue;
			case 22u:
			{
				int num12;
				int num13;
				if (_Q7Kx7ErHf3u1QIUDKfFCKSXbznG > 0)
				{
					num12 = 281220583;
					num13 = 281220583;
				}
				else
				{
					num12 = 1881069314;
					num13 = 1881069314;
				}
				num = num12 ^ ((int)num3 * -1009562692);
				continue;
			}
			case 21u:
				goto IL_029d;
			case 19u:
				goto IL_02b5;
			case 18u:
				_MOBkoboXIfjixJIW15TJTdFlwDC = _IIGQSKohQsLi09FILC8oKHG5UXG.Skip;
				num = -1094249261;
				continue;
			case 17u:
			{
				int num8;
				int num9;
				if (_NYF6CyMYCqbkxJ8Q1N7O3ehzldE == _IIGQSKohQsLi09FILC8oKHG5UXG.WaitForSkip)
				{
					num8 = -509495680;
					num9 = -509495680;
				}
				else
				{
					num8 = -37974248;
					num9 = -37974248;
				}
				num = num8 ^ (int)(num3 * 530668608);
				continue;
			}
			case 16u:
				goto IL_0318;
			case 15u:
				_NYF6CyMYCqbkxJ8Q1N7O3ehzldE = _IIGQSKohQsLi09FILC8oKHG5UXG.WaitForSkip;
				num = -1476982317;
				continue;
			case 14u:
				_MOBkoboXIfjixJIW15TJTdFlwDC = _IIGQSKohQsLi09FILC8oKHG5UXG.Skip;
				num = (int)((num3 * 1366142005) ^ 0x7B2041DB);
				continue;
			case 12u:
				_NeIQsy78kWqF9jXLl8vb2lOyZgO();
				num = ((int)num3 * -1317983583) ^ -704610412;
				continue;
			case 11u:
				_Q7Kx7ErHf3u1QIUDKfFCKSXbznG = 0;
				_NYF6CyMYCqbkxJ8Q1N7O3ehzldE = _MOBkoboXIfjixJIW15TJTdFlwDC;
				_MOBkoboXIfjixJIW15TJTdFlwDC = _IIGQSKohQsLi09FILC8oKHG5UXG.None;
				num = -277152320;
				continue;
			case 10u:
			{
				int num4;
				int num5;
				if (_4L7hfXrWoDdArQiscG4ukHCV46B._5zNdOw7qHmuCAPJFMr3SsZdBlCr == null)
				{
					num4 = -1286518427;
					num5 = -1286518427;
				}
				else
				{
					num4 = -474288404;
					num5 = -474288404;
				}
				num = num4 ^ (int)(num3 * 547543181);
				continue;
			}
			case 8u:
				_NYF6CyMYCqbkxJ8Q1N7O3ehzldE = _IIGQSKohQsLi09FILC8oKHG5UXG.Waiting;
				num = -174340982;
				continue;
			case 7u:
				num = ((int)num3 * -215018714) ^ -1137197749;
				continue;
			case 5u:
				_NYF6CyMYCqbkxJ8Q1N7O3ehzldE = _IIGQSKohQsLi09FILC8oKHG5UXG.Typing;
				num = -851844865;
				continue;
			case 4u:
				_MOBkoboXIfjixJIW15TJTdFlwDC = _IIGQSKohQsLi09FILC8oKHG5UXG.None;
				num = (int)((num3 * 195746795) ^ 0x620F3626);
				continue;
			case 1u:
				_NeIQsy78kWqF9jXLl8vb2lOyZgO();
				_NYF6CyMYCqbkxJ8Q1N7O3ehzldE = _IIGQSKohQsLi09FILC8oKHG5UXG.WaitForSkip;
				num = ((int)num3 * -339581205) ^ -295390666;
				continue;
			case 0u:
				switch (nYF6CyMYCqbkxJ8Q1N7O3ehzldE)
				{
				case _IIGQSKohQsLi09FILC8oKHG5UXG.Started:
					break;
				case _IIGQSKohQsLi09FILC8oKHG5UXG.Typing:
					goto IL_0124;
				case _IIGQSKohQsLi09FILC8oKHG5UXG.Skip:
					goto IL_029d;
				case _IIGQSKohQsLi09FILC8oKHG5UXG.Waiting:
					goto IL_02b5;
				default:
					goto IL_044a;
				case _IIGQSKohQsLi09FILC8oKHG5UXG.WaitForSkip:
					return;
				}
				break;
			default:
				return;
			case 38u:
				goto IL_052c;
			case 2u:
				return;
			case 3u:
				return;
			case 6u:
				_MOBkoboXIfjixJIW15TJTdFlwDC = _IIGQSKohQsLi09FILC8oKHG5UXG.Skip;
				return;
			case 9u:
				return;
			case 13u:
				return;
			case 20u:
				return;
			case 24u:
				return;
			case 27u:
				return;
			case 43u:
				{
					_MOBkoboXIfjixJIW15TJTdFlwDC = _IIGQSKohQsLi09FILC8oKHG5UXG.Typing;
					return;
				}
				IL_044a:
				num = (int)(num3 * 94265288) ^ -1805458575;
				continue;
				IL_02b5:
				_Q7Kx7ErHf3u1QIUDKfFCKSXbznG -= _nkzqFdEfDyLcyGikIKGcHjklI4y.smethod_9(gameTime_0).Milliseconds;
				num = -497521575;
				continue;
				IL_029d:
				_NYF6CyMYCqbkxJ8Q1N7O3ehzldE = _IIGQSKohQsLi09FILC8oKHG5UXG.Done;
				_MOBkoboXIfjixJIW15TJTdFlwDC = _IIGQSKohQsLi09FILC8oKHG5UXG.None;
				num = -1364768680;
				continue;
			}
			int num16;
			if (_4V6bFHOi28R2wJIOaQKs1A0pIQ0._aFbxCmyEb7GMPT5kU3P9NvcWQgK != 0)
			{
				num = -1555290505;
				num16 = -1555290505;
			}
			else
			{
				num = -576497789;
				num16 = -576497789;
			}
			continue;
			IL_0318:
			int num17;
			if (!_8rrKDeGOr7tozdP0dxFbBPWq7NG())
			{
				num = -688897384;
				num17 = -688897384;
			}
			else
			{
				num = -1091909586;
				num17 = -1091909586;
			}
			continue;
			IL_0124:
			c = _3wk7bXUbhNqSQ9kMD9hieEubOhG._ZKadRFahgnwn10dM34638KGsLNu();
			int num18;
			if (_3wk7bXUbhNqSQ9kMD9hieEubOhG._xJZUPxDatEzfPQc0nRHR2D1Vwke)
			{
				num = -1745659605;
				num18 = -1745659605;
			}
			else
			{
				num = -274930732;
				num18 = -274930732;
			}
			continue;
			IL_004a:
			int num19;
			if (c != '░')
			{
				num = -467870559;
				num19 = -467870559;
			}
			else
			{
				num = -1822555749;
				num19 = -1822555749;
			}
			continue;
			IL_0209:
			int num20;
			if (!_fUgDiz7KX8TZUVzFlTeXMOhmfUT)
			{
				num = -1835327914;
				num20 = -1835327914;
			}
			else
			{
				num = -1764623963;
				num20 = -1764623963;
			}
			continue;
			end_IL_0457:
			break;
		}
		goto IL_011a;
		IL_011a:
		num = -1464285497;
		goto IL_0457;
	}

	private bool _8rrKDeGOr7tozdP0dxFbBPWq7NG()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		if (_4L7hfXrWoDdArQiscG4ukHCV46B._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH((Keys)32))
		{
			goto IL_0029;
		}
		goto IL_00f7;
		IL_00f7:
		int num;
		int num2;
		if (_4L7hfXrWoDdArQiscG4ukHCV46B._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(_PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton))
		{
			num = 1160658750;
			num2 = 1160658750;
		}
		else
		{
			num = 1447980636;
			num2 = 1447980636;
		}
		goto IL_00bb;
		IL_00bb:
		Point val = default(Point);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0x599AF1C8u) % 7u)
			{
			case 3u:
				break;
			case 2u:
			{
				val = _4L7hfXrWoDdArQiscG4ukHCV46B._vsceSzSIjBy2nZrCxAzKZbUiwLq._u7uCdK9i8FnWhiaPn2bO2wIgUUuA(_4L7hfXrWoDdArQiscG4ukHCV46B._RbWJ7YGnYHCSoD44MRW1h5X6E7E._U7CeYBJ1v1SoUxpX8emsQ9mWl5b);
				int num6;
				int num7;
				if ((float)val.Y < _rv7JIIMY4Ta1tpSvflng4Lose4H.Y + 10f)
				{
					num6 = 1394156442;
					num7 = 1394156442;
				}
				else
				{
					num6 = 2007477691;
					num7 = 2007477691;
				}
				num = num6 ^ (int)(num3 * 427748793);
				continue;
			}
			case 0u:
			{
				int num4;
				int num5;
				if (val.Y > 1080)
				{
					num4 = -1382455186;
					num5 = -1382455186;
				}
				else
				{
					num4 = -1023961097;
					num5 = -1023961097;
				}
				num = num4 ^ (int)(num3 * 799323306);
				continue;
			}
			case 6u:
				goto IL_00f7;
			case 1u:
				return true;
			case 4u:
				return true;
			default:
				return false;
			}
			break;
		}
		goto IL_0029;
		IL_0029:
		num = 194656648;
		goto IL_00bb;
	}

	private void _bkUB7WagRc6RJkVVY4DTGPizp0F(_oDZZ0F7Qg08utTIjAaoyIbeDuFG _oDZZ0F7Qg08utTIjAaoyIbeDuFG_0)
	{
		_3wk7bXUbhNqSQ9kMD9hieEubOhG = _oDZZ0F7Qg08utTIjAaoyIbeDuFG_0;
		while (true)
		{
			int num = -439487142;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD7F757A9u) % 6u)
				{
				case 5u:
					_MOBkoboXIfjixJIW15TJTdFlwDC = _IIGQSKohQsLi09FILC8oKHG5UXG.None;
					num = ((int)num2 * -1286001624) ^ -180300964;
					continue;
				case 4u:
					_lMAOhEkyOOJcbuU0ONDYvJ8bs8w = _QGnsmTImvr3dFBCr8hpzDZiCWLP.Started;
					_NYF6CyMYCqbkxJ8Q1N7O3ehzldE = _IIGQSKohQsLi09FILC8oKHG5UXG.Started;
					num = (int)(num2 * 1670779712) ^ -596394934;
					continue;
				case 3u:
					_3wk7bXUbhNqSQ9kMD9hieEubOhG._TN6mQ7Lbe501vwqhgs7b8d6wd1b(_xnYepZuegigJCU2jcbZsfVIakzF, _23jI7jMreLgRTSs5rhEGCUkow2b);
					num = (int)(num2 * 900945818) ^ -1919944251;
					continue;
				case 0u:
					_3wk7bXUbhNqSQ9kMD9hieEubOhG._pYBSD3QOMXtGMbCUDyvyluUZnx();
					num = (int)(num2 * 107434359) ^ -1164850377;
					continue;
				default:
					return;
				case 2u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	private void _QrgbXEg7MMeD9Ybz12fFVsbmAd9(_oDZZ0F7Qg08utTIjAaoyIbeDuFG _oDZZ0F7Qg08utTIjAaoyIbeDuFG_0)
	{
		_3wk7bXUbhNqSQ9kMD9hieEubOhG = _oDZZ0F7Qg08utTIjAaoyIbeDuFG_0;
		_3wk7bXUbhNqSQ9kMD9hieEubOhG._TN6mQ7Lbe501vwqhgs7b8d6wd1b(_xnYepZuegigJCU2jcbZsfVIakzF, _23jI7jMreLgRTSs5rhEGCUkow2b);
		_Q7Kx7ErHf3u1QIUDKfFCKSXbznG = 150;
		_lMAOhEkyOOJcbuU0ONDYvJ8bs8w = _QGnsmTImvr3dFBCr8hpzDZiCWLP.Started;
		_NYF6CyMYCqbkxJ8Q1N7O3ehzldE = _IIGQSKohQsLi09FILC8oKHG5UXG.Started;
		while (true)
		{
			int num = 2102357169;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x11FBD87Cu) % 3u)
				{
				case 1u:
					goto IL_0039;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0039:
				_MOBkoboXIfjixJIW15TJTdFlwDC = _IIGQSKohQsLi09FILC8oKHG5UXG.None;
				num = ((int)num2 * -126312385) ^ 0x4D42D5D;
			}
		}
	}

	public void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		if (_lMAOhEkyOOJcbuU0ONDYvJ8bs8w == _QGnsmTImvr3dFBCr8hpzDZiCWLP.None)
		{
			goto IL_00a5;
		}
		goto IL_016d;
		IL_016d:
		_fp8jsuSnELXqf2yy2JQDaXDCBVQ._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0);
		int num = -178535011;
		goto IL_0133;
		IL_0133:
		_oDZZ0F7Qg08utTIjAaoyIbeDuFG oDZZ0F7Qg08utTIjAaoyIbeDuFG = default(_oDZZ0F7Qg08utTIjAaoyIbeDuFG);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xA4CBB016u) % 10u)
			{
			case 8u:
				spriteBatch_0._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, oDZZ0F7Qg08utTIjAaoyIbeDuFG._D5QiLGGNtfoCEnZIUPvH4OKqUabA, _4djSc5RiRJZMGzvYwwEprIYf6ZM, oDZZ0F7Qg08utTIjAaoyIbeDuFG._9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA);
				num = ((int)num2 * -1266731873) ^ -1841150144;
				continue;
			case 7u:
				_nkzqFdEfDyLcyGikIKGcHjklI4y.smethod_14(_9GQBAH2pi8Sm6ph1s6InjyQGe6R);
				num = ((int)num2 * -2111827191) ^ 0xBB471A2;
				continue;
			case 6u:
				break;
			case 5u:
				goto end_IL_0133;
			case 4u:
			{
				_nkzqFdEfDyLcyGikIKGcHjklI4y.smethod_11(spriteBatch_0, _P62DygY6CKZG8s5wqDu0uAFksjs, _rv7JIIMY4Ta1tpSvflng4Lose4H, oDZZ0F7Qg08utTIjAaoyIbeDuFG._9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA);
				int num5;
				int num6;
				if (!_nkzqFdEfDyLcyGikIKGcHjklI4y.smethod_12(oDZZ0F7Qg08utTIjAaoyIbeDuFG._D5QiLGGNtfoCEnZIUPvH4OKqUabA))
				{
					num5 = -1030108714;
					num6 = -1030108714;
				}
				else
				{
					num5 = -1126784400;
					num6 = -1126784400;
				}
				num = num5 ^ (int)(num2 * 733670606);
				continue;
			}
			case 1u:
			{
				oDZZ0F7Qg08utTIjAaoyIbeDuFG = _3wk7bXUbhNqSQ9kMD9hieEubOhG;
				int num3;
				int num4;
				if (oDZZ0F7Qg08utTIjAaoyIbeDuFG == null)
				{
					num3 = -1342843299;
					num4 = -1342843299;
				}
				else
				{
					num3 = -891603056;
					num4 = -891603056;
				}
				num = num3 ^ (int)(num2 * 1047244418);
				continue;
			}
			case 0u:
				_nkzqFdEfDyLcyGikIKGcHjklI4y.smethod_10(spriteBatch_0);
				num = (int)(num2 * 743188382) ^ -345549054;
				continue;
			default:
				return;
			case 3u:
				goto IL_016d;
			case 2u:
				return;
			case 9u:
				return;
			}
			oDZZ0F7Qg08utTIjAaoyIbeDuFG._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0, _xnYepZuegigJCU2jcbZsfVIakzF, _23jI7jMreLgRTSs5rhEGCUkow2b, _gWIuAj6CuJjxiHOmaYwYLvu8g0r);
			_nkzqFdEfDyLcyGikIKGcHjklI4y.smethod_13(spriteBatch_0);
			int num7;
			if (_4L7hfXrWoDdArQiscG4ukHCV46B._5zNdOw7qHmuCAPJFMr3SsZdBlCr == null)
			{
				num = -911409973;
				num7 = -911409973;
			}
			else
			{
				num = -841814153;
				num7 = -841814153;
			}
			continue;
			end_IL_0133:
			break;
		}
		goto IL_00a5;
		IL_00a5:
		num = -572267746;
		goto IL_0133;
	}

	public void _XDbzWLxDi2VVrJQrjjLsgcfdxju()
	{
		_3wk7bXUbhNqSQ9kMD9hieEubOhG = null;
		while (true)
		{
			int num = 1367533574;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x16502DF7u) % 3u)
				{
				case 2u:
					goto IL_0009;
				case 0u:
					break;
				default:
					_lMAOhEkyOOJcbuU0ONDYvJ8bs8w = _QGnsmTImvr3dFBCr8hpzDZiCWLP.None;
					_NYF6CyMYCqbkxJ8Q1N7O3ehzldE = _IIGQSKohQsLi09FILC8oKHG5UXG.None;
					_MOBkoboXIfjixJIW15TJTdFlwDC = _IIGQSKohQsLi09FILC8oKHG5UXG.None;
					return;
				}
				break;
				IL_0009:
				_Q7Kx7ErHf3u1QIUDKfFCKSXbznG = 0;
				num = (int)((num2 * 2119607721) ^ 0x6F644E51);
			}
		}
	}

	public static void _9RhaHKUaQmQeJrrxVYowZyJe4mo(string string_0, string string_1, Color color_0)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_6T55wit7MiGfAWRkPwjNbJ8N8lG._bkUB7WagRc6RJkVVY4DTGPizp0F(new _oDZZ0F7Qg08utTIjAaoyIbeDuFG(string_0, string_1, color_0));
	}

	public static void _zunSyHn4DekdA6CngP10dXcR1kq(string string_0, string string_1, Color color_0)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_6T55wit7MiGfAWRkPwjNbJ8N8lG._QrgbXEg7MMeD9Ybz12fFVsbmAd9(new _oDZZ0F7Qg08utTIjAaoyIbeDuFG(string_0, string_1, color_0));
	}

	public static void _NeIQsy78kWqF9jXLl8vb2lOyZgO()
	{
		if (_6T55wit7MiGfAWRkPwjNbJ8N8lG._3wk7bXUbhNqSQ9kMD9hieEubOhG == null)
		{
			goto IL_000c;
		}
		goto IL_0030;
		IL_0030:
		_6T55wit7MiGfAWRkPwjNbJ8N8lG._3wk7bXUbhNqSQ9kMD9hieEubOhG._pYBSD3QOMXtGMbCUDyvyluUZnx();
		int num = 1172883812;
		goto IL_0011;
		IL_0011:
		switch ((uint)(num ^ 0x59C1397F) % 4u)
		{
		case 0u:
			break;
		default:
			return;
		case 2u:
			goto IL_0030;
		case 1u:
			return;
		case 3u:
			return;
		}
		goto IL_000c;
		IL_000c:
		num = 2096747106;
		goto IL_0011;
	}

	public static void _MRzbkwglCADk2fFjoxcsdCSJfKu(params string[] string_0)
	{
		_6T55wit7MiGfAWRkPwjNbJ8N8lG._fp8jsuSnELXqf2yy2JQDaXDCBVQ._ww4wA3UwGXxaAlMqo3jhy6Bnh8g(string_0);
	}

	public static void _gVRGC9VAGHCLvP8p5Q4mqLPvFCm()
	{
		_6T55wit7MiGfAWRkPwjNbJ8N8lG._fp8jsuSnELXqf2yy2JQDaXDCBVQ._mXNb0ylIEgd0VJEHTX3MBvFWYEf(0);
	}

	public static void _h0KfaNiikKlJV2KkRPIdVDKVJnC()
	{
		_6T55wit7MiGfAWRkPwjNbJ8N8lG._XDbzWLxDi2VVrJQrjjLsgcfdxju();
	}

	[CompilerGenerated]
	private void _csDsyuTOcgE2NaxDw71lIATz3FD(Control control_0, MouseEventArgs mouseEventArgs_0)
	{
		_4L7hfXrWoDdArQiscG4ukHCV46B._8c7SHmhI0bvgm2S0W4WafcEBOzV(_9GQBAH2pi8Sm6ph1s6InjyQGe6R, delegate(bool bool_0)
		{
			_fp8jsuSnELXqf2yy2JQDaXDCBVQ._nJKYvZJ57vjjlQwmoeBmKihtS0b = bool_0;
		});
	}

	[CompilerGenerated]
	private void _kQIOl46s9jnjYaf84A24AK7w3Yd(bool bool_0)
	{
		_fp8jsuSnELXqf2yy2JQDaXDCBVQ._nJKYvZJ57vjjlQwmoeBmKihtS0b = bool_0;
	}

	[CompilerGenerated]
	private void _2imA1tG8GakpEtVw2imvSqWBS0P(Control control_0, MouseEventArgs mouseEventArgs_0)
	{
		_4L7hfXrWoDdArQiscG4ukHCV46B._xM8d2LuC070Xft2N9A0ulzGVshq(_9GQBAH2pi8Sm6ph1s6InjyQGe6R, delegate(bool bool_0)
		{
			_fp8jsuSnELXqf2yy2JQDaXDCBVQ._nJKYvZJ57vjjlQwmoeBmKihtS0b = bool_0;
		});
	}

	[CompilerGenerated]
	private void _NRUdxI9wplU4ygmehNgkJSc8eMCA(bool bool_0)
	{
		_fp8jsuSnELXqf2yy2JQDaXDCBVQ._nJKYvZJ57vjjlQwmoeBmKihtS0b = bool_0;
	}

	[CompilerGenerated]
	private void _Rrqze4lq1h0TuiDeIBBpP0mHkTN(Control control_0, MouseEventArgs mouseEventArgs_0)
	{
		_4L7hfXrWoDdArQiscG4ukHCV46B._MES3SBLNIcxOd5F8ZqVEWmsIcmA(_9GQBAH2pi8Sm6ph1s6InjyQGe6R, delegate(bool bool_0)
		{
			_fp8jsuSnELXqf2yy2JQDaXDCBVQ._nJKYvZJ57vjjlQwmoeBmKihtS0b = bool_0;
		});
	}

	[CompilerGenerated]
	private void _WU86faSmgOlbrRFiJvLWAdAgiod(bool bool_0)
	{
		_fp8jsuSnELXqf2yy2JQDaXDCBVQ._nJKYvZJ57vjjlQwmoeBmKihtS0b = bool_0;
	}

	[CompilerGenerated]
	private void _kBq2EhiBAaNCahkPSjjNwZ9xGGZ(Control control_0, ListBoxItem listBoxItem_0)
	{
		_NhL238TaCbkDiY6HXlWXZzzUYkm = (DialogueSpeed)_nkzqFdEfDyLcyGikIKGcHjklI4y.smethod_15(listBoxItem_0);
		_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._wVLRBSMULz8GfedBPXaVJB0sBEO = _tAC7ojbHHd15LKk7rGbelW2nGWN;
	}

	[CompilerGenerated]
	private void _bNPTy2WSo9nGb2A5oTtKAgmaCKi(Control control_0)
	{
		_fUgDiz7KX8TZUVzFlTeXMOhmfUT = _nkzqFdEfDyLcyGikIKGcHjklI4y.smethod_16(_2pNQedwLe7YapSxneCqi4SreGdH);
		while (true)
		{
			int num = 1807803514;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x46CE6E1Fu) % 3u)
				{
				case 1u:
					goto IL_0012;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0012:
				_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._sbK0941BvW8HgPboNwOhIAd2jP3 = _O7kX3MfMCx3M2dVro1UbOCbajyo;
				num = ((int)num2 * -962940535) ^ -839672458;
			}
		}
	}

	[CompilerGenerated]
	private bool _ykZEKzGNfZ5hHHun0hWpJGQDzBp(ListBoxItem listBoxItem_0)
	{
		return (DialogueSpeed)_nkzqFdEfDyLcyGikIKGcHjklI4y.smethod_15(listBoxItem_0) == _tAC7ojbHHd15LKk7rGbelW2nGWN;
	}

	static int smethod_0(Texture2D texture2D_0)
	{
		return texture2D_0.get_Width();
	}

	static int smethod_1(Texture2D texture2D_0)
	{
		return texture2D_0.get_Height();
	}

	static Desktop smethod_2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Desktop();
	}

	static Skin smethod_3()
	{
		return Gui.GenerateStandardSkin();
	}

	static void smethod_4(Desktop desktop_0, Skin skin_0)
	{
		desktop_0.set_Skin(skin_0);
	}

	static ActiveList<ListBoxItem> smethod_5(DropDownList dropDownList_0)
	{
		return dropDownList_0.get_Items();
	}

	static void smethod_6(DropDownList dropDownList_0, ListBoxItem listBoxItem_0)
	{
		dropDownList_0.set_SelectedItem(listBoxItem_0);
	}

	static void smethod_7(CheckBox checkBox_0, bool bool_0)
	{
		checkBox_0.set_Checked(bool_0);
	}

	static void smethod_8(Desktop desktop_0)
	{
		desktop_0.Update();
	}

	static TimeSpan smethod_9(GameTime gameTime_0)
	{
		return gameTime_0.get_ElapsedGameTime();
	}

	static void smethod_10(SpriteBatch spriteBatch_0)
	{
		spriteBatch_0.Begin();
	}

	static void smethod_11(SpriteBatch spriteBatch_0, Texture2D texture2D_0, Vector2 vector2_0, Color color_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		spriteBatch_0.Draw(texture2D_0, vector2_0, color_0);
	}

	static bool smethod_12(string string_0)
	{
		return string.IsNullOrEmpty(string_0);
	}

	static void smethod_13(SpriteBatch spriteBatch_0)
	{
		spriteBatch_0.End();
	}

	static void smethod_14(Desktop desktop_0)
	{
		desktop_0.Draw();
	}

	static object smethod_15(ListBoxItem listBoxItem_0)
	{
		return listBoxItem_0.get_Value();
	}

	static bool smethod_16(CheckBox checkBox_0)
	{
		return checkBox_0.get_Checked();
	}
}
