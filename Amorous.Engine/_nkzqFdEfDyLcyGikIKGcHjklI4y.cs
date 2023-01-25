using System;
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

		public string Text { get; }

		public string Title { get; }

		public Color Color { get; }

		public _oDZZ0F7Qg08utTIjAaoyIbeDuFG(string string_0, string string_1, Color color_0)
		{
			_KD80MJMEbQska5mSqJiPthulqeB = string_0.Replace("%playername%", _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t().Name).Trim();
			if (!(string_1 == "%playername%"))
			{
				_fHbF0r78UBMiyDseUhbwAvEaqmp = string_1;
			}
			else
			{
				_fHbF0r78UBMiyDseUhbwAvEaqmp = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t().Name;
			}
			_ChpobZzN69pA08rlAmpiuCeOPQv = color_0;
			_Fcqa4Lsbrq6zW3KyJnkvEumd0f4 = new List<_W4jOxbRDzppFv0IAFpA5Blo7CjUA>();
		}

		public void _TN6mQ7Lbe501vwqhgs7b8d6wd1b(SpriteFont spriteFont_0, SpriteFont spriteFont_1)
		{
			_Fcqa4Lsbrq6zW3KyJnkvEumd0f4.Clear();
			_3wk7bXUbhNqSQ9kMD9hieEubOhG = 0;
			if (string.IsNullOrEmpty(Text))
			{
				return;
			}
			string string_ = Text;
			int int_ = 0;
			string text = string.Empty;
			int num = 0;
			int int_2 = 0;
			bool flag = false;
			bool bool_ = false;
			char char_ = ' ';
			bool bool_2 = false;
			while (int_ < string_.Length)
			{
				char char_2 = string_[int_++];
				if (char_2 == '<' && _NAyejbnxgyLeIcptsV2gubUyOZq(ref string_, ref int_, ref char_, ref bool_2))
				{
					if (text.Length > 0)
					{
						_Fcqa4Lsbrq6zW3KyJnkvEumd0f4.Add(new _W4jOxbRDzppFv0IAFpA5Blo7CjUA(text, bool_0: false, flag, bool_, int_2));
						text = string.Empty;
						int_2 = num;
					}
					switch (char_)
					{
					case 'b':
						bool_ = !bool_2;
						break;
					case 'i':
						flag = !bool_2;
						break;
					}
					continue;
				}
				text += char_2;
				if (_oj8dqD8luomebDeOFLXAy1e38Z5(ref char_2))
				{
					continue;
				}
				if (char_2 != '\n')
				{
					num += (int)(flag ? spriteFont_1 : spriteFont_0).MeasureString(char_2.ToString()).X;
					if (num < 1770)
					{
						continue;
					}
					while (text.Length != 0 && int_ != 0)
					{
						int_--;
						if (string_[int_] == ' ')
						{
							break;
						}
						text = text.Substring(0, text.Length - 1);
					}
					if (text.Length == 0)
					{
						if (_Fcqa4Lsbrq6zW3KyJnkvEumd0f4.Count > 0)
						{
							_Fcqa4Lsbrq6zW3KyJnkvEumd0f4[_Fcqa4Lsbrq6zW3KyJnkvEumd0f4.Count - 1]._YqQMYa7eF6BsHAixrYycR8apI6F = true;
						}
					}
					else
					{
						_Fcqa4Lsbrq6zW3KyJnkvEumd0f4.Add(new _W4jOxbRDzppFv0IAFpA5Blo7CjUA(text, bool_0: true, flag, bool_, int_2));
						text = string.Empty;
					}
					int_2 = 0;
					num = 0;
				}
				else
				{
					if (text.Length > 0)
					{
						_Fcqa4Lsbrq6zW3KyJnkvEumd0f4.Add(new _W4jOxbRDzppFv0IAFpA5Blo7CjUA(text, bool_0: true, flag, bool_, int_2));
						text = string.Empty;
						int_2 = 0;
					}
					num = 0;
				}
			}
			if (text.Length > 0)
			{
				_Fcqa4Lsbrq6zW3KyJnkvEumd0f4.Add(new _W4jOxbRDzppFv0IAFpA5Blo7CjUA(text, bool_0: false, flag, bool_, int_2));
			}
		}

		private bool _NAyejbnxgyLeIcptsV2gubUyOZq(ref string string_0, ref int int_0, ref char char_0, ref bool bool_0)
		{
			int num = int_0;
			if (num >= string_0.Length)
			{
				return false;
			}
			char_0 = string_0[num++];
			bool_0 = char_0 == '/';
			if (num < string_0.Length)
			{
				if (bool_0)
				{
					char_0 = string_0[num++];
				}
				if (num < string_0.Length)
				{
					char c = string_0[num++];
					if (c == '>' && _hFQYJfPSNmwOMj06bgwOluYktME(ref char_0))
					{
						int_0 = num;
						return true;
					}
					return false;
				}
				return false;
			}
			return false;
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
				return;
			}
			foreach (_W4jOxbRDzppFv0IAFpA5Blo7CjUA item in _Fcqa4Lsbrq6zW3KyJnkvEumd0f4)
			{
				item._pYBSD3QOMXtGMbCUDyvyluUZnx();
			}
			_3wk7bXUbhNqSQ9kMD9hieEubOhG = _Fcqa4Lsbrq6zW3KyJnkvEumd0f4.Count;
		}

		public char _ZKadRFahgnwn10dM34638KGsLNu()
		{
			if (_xJZUPxDatEzfPQc0nRHR2D1Vwke)
			{
				return ' ';
			}
			_W4jOxbRDzppFv0IAFpA5Blo7CjUA w4jOxbRDzppFv0IAFpA5Blo7CjUA = _Fcqa4Lsbrq6zW3KyJnkvEumd0f4[_3wk7bXUbhNqSQ9kMD9hieEubOhG];
			char result = w4jOxbRDzppFv0IAFpA5Blo7CjUA._ZKadRFahgnwn10dM34638KGsLNu();
			if (w4jOxbRDzppFv0IAFpA5Blo7CjUA._xJZUPxDatEzfPQc0nRHR2D1Vwke)
			{
				_3wk7bXUbhNqSQ9kMD9hieEubOhG++;
			}
			return result;
		}

		public void Draw(SpriteBatch spriteBatch_0, SpriteFont spriteFont_0, SpriteFont spriteFont_1, Vector2[] vector2_0)
		{
			int num = 0;
			foreach (_W4jOxbRDzppFv0IAFpA5Blo7CjUA item in _Fcqa4Lsbrq6zW3KyJnkvEumd0f4)
			{
				if (num < vector2_0.Length)
				{
					item.Draw(spriteBatch_0, spriteFont_0, spriteFont_1, vector2_0[num], Color);
					if (item._YqQMYa7eF6BsHAixrYycR8apI6F)
					{
						num++;
					}
					continue;
				}
				break;
			}
		}
	}

	private class _W4jOxbRDzppFv0IAFpA5Blo7CjUA
	{
		private int _3wk7bXUbhNqSQ9kMD9hieEubOhG;

		private readonly Vector2 _BK3BSdlEv4xSjAlS93TtxbrrjjA;

		public bool _xJZUPxDatEzfPQc0nRHR2D1Vwke => _3wk7bXUbhNqSQ9kMD9hieEubOhG >= _Si5dw38ImuGLFJvc8DC1FoIc0PG.Length;

		public string _Si5dw38ImuGLFJvc8DC1FoIc0PG { get; }

		public bool _YqQMYa7eF6BsHAixrYycR8apI6F { get; set; }

		public bool _m2fqFdYkda0gaCnRfu9lTOJ9CAi { get; }

		public bool _ADnm4p5lVjBKkT3NkUtyGVE6UyC { get; }

		public _W4jOxbRDzppFv0IAFpA5Blo7CjUA(string string_0, bool bool_0, bool bool_1, bool bool_2, int int_0)
		{
			_jKleQiKbVdoC6cAZMyVb5qJD13Q = ((int_0 == 0) ? string_0.Trim() : string_0);
			_YqQMYa7eF6BsHAixrYycR8apI6F = bool_0;
			_Ca56HTa6e3zxZSlfkrIB2telVdG = bool_1;
			_on9cwi6oxCjZzbho9Maz5KlOLPp = bool_2;
			_BK3BSdlEv4xSjAlS93TtxbrrjjA = new Vector2(int_0, 0f);
		}

		public void _pYBSD3QOMXtGMbCUDyvyluUZnx()
		{
			_3wk7bXUbhNqSQ9kMD9hieEubOhG = _Si5dw38ImuGLFJvc8DC1FoIc0PG.Length;
		}

		public char _ZKadRFahgnwn10dM34638KGsLNu()
		{
			if (_xJZUPxDatEzfPQc0nRHR2D1Vwke)
			{
				return ' ';
			}
			return _Si5dw38ImuGLFJvc8DC1FoIc0PG[_3wk7bXUbhNqSQ9kMD9hieEubOhG++];
		}

		public void Draw(SpriteBatch spriteBatch_0, SpriteFont spriteFont_0, SpriteFont spriteFont_1, Vector2 vector2_0, Color color_0)
		{
			string text = _Jnjh8hNzVbH0Eov4seqBq1UNOCq();
			if (!string.IsNullOrEmpty(text))
			{
				if (_m2fqFdYkda0gaCnRfu9lTOJ9CAi)
				{
					spriteBatch_0.DrawString(spriteFont_1, text, vector2_0 + _BK3BSdlEv4xSjAlS93TtxbrrjjA, color_0);
				}
				else
				{
					spriteBatch_0.DrawString(spriteFont_0, text, vector2_0 + _BK3BSdlEv4xSjAlS93TtxbrrjjA, color_0);
				}
			}
		}

		private string _Jnjh8hNzVbH0Eov4seqBq1UNOCq()
		{
			if (_3wk7bXUbhNqSQ9kMD9hieEubOhG == 0)
			{
				return string.Empty;
			}
			string text = ((_3wk7bXUbhNqSQ9kMD9hieEubOhG >= _Si5dw38ImuGLFJvc8DC1FoIc0PG.Length) ? _Si5dw38ImuGLFJvc8DC1FoIc0PG : _Si5dw38ImuGLFJvc8DC1FoIc0PG.Substring(0, _3wk7bXUbhNqSQ9kMD9hieEubOhG));
			string text2 = string.Empty;
			int num = 0;
			for (int num2 = text.IndexOf('░'); num2 >= 0; num2 = text.IndexOf('░', num))
			{
				text2 += text.Substring(num, num2 - num);
				num = num2 + 1;
			}
			if (num < text.Length)
			{
				text2 += text.Substring(num);
			}
			return text2;
		}
	}

	private class _3Kf8FQeGRyCD8FhytGMMBQFkhFl : _8lVOgkauaSHbAkAqHzI1K7mIyOI
	{
		private readonly _iHJrndJdM1jj9TEnuU3BvgdDuvf[] _92GwVFulItjaDs6osQZyIk9xgMH;

		private int _VZ02JDgQaX5qJVSBot6TM2rtZ3O;

		public int _mc4p6vpMBZ0hOHPqLBE5H6OxT7f { get; private set; }

		public bool _zatbtX2c8i2hGOTptNymBxA8kVI { get; private set; }

		public _3Kf8FQeGRyCD8FhytGMMBQFkhFl(IAmorous game, Texture2D texture2D_0, Texture2D texture2D_1, SpriteFont spriteFont_0)
			: base(game)
		{
			_92GwVFulItjaDs6osQZyIk9xgMH = new _iHJrndJdM1jj9TEnuU3BvgdDuvf[5];
			_mc4p6vpMBZ0hOHPqLBE5H6OxT7f = -1;
			_VZ02JDgQaX5qJVSBot6TM2rtZ3O = 0;
			_92GwVFulItjaDs6osQZyIk9xgMH[0] = _QVqIVxBeF2SAQh6HDFwwp2RFmXB(texture2D_0, texture2D_1, spriteFont_0, "Choice 1", new Color(250, 251, 162), 0, 0, new Microsoft.Xna.Framework.Rectangle(0, 0, texture2D_0.Width, texture2D_0.Height), _ICiyaoVDO6XvJb0FsHkwv7e4YrS);
			_92GwVFulItjaDs6osQZyIk9xgMH[1] = _QVqIVxBeF2SAQh6HDFwwp2RFmXB(texture2D_0, texture2D_1, spriteFont_0, "Choice 2", new Color(165, 250, 171), 0, 0, new Microsoft.Xna.Framework.Rectangle(0, 0, texture2D_0.Width, texture2D_0.Height), _hXUKutqtuyapSBUWT1AVUzerGjc);
			_92GwVFulItjaDs6osQZyIk9xgMH[2] = _QVqIVxBeF2SAQh6HDFwwp2RFmXB(texture2D_0, texture2D_1, spriteFont_0, "Choice 3", new Color(171, 199, 255), 0, 0, new Microsoft.Xna.Framework.Rectangle(0, 0, texture2D_0.Width, texture2D_0.Height), _IniwNTOJAFQzPUg40NMaN8sku9k);
			_92GwVFulItjaDs6osQZyIk9xgMH[3] = _QVqIVxBeF2SAQh6HDFwwp2RFmXB(texture2D_0, texture2D_1, spriteFont_0, "Choice 4", new Color(228, 187, 253), 0, 0, new Microsoft.Xna.Framework.Rectangle(0, 0, texture2D_0.Width, texture2D_0.Height), _5TLz87dh7yxXEP5B2Lceq9uOAp1);
			_92GwVFulItjaDs6osQZyIk9xgMH[4] = _QVqIVxBeF2SAQh6HDFwwp2RFmXB(texture2D_0, texture2D_1, spriteFont_0, "Choice 5", new Color(255, 171, 179), 0, 0, new Microsoft.Xna.Framework.Rectangle(0, 0, texture2D_0.Width, texture2D_0.Height), _0wd4x937or88gFFP0wpuEK3BkyM);
			_mXNb0ylIEgd0VJEHTX3MBvFWYEf(-1);
		}

		public void _ww4wA3UwGXxaAlMqo3jhy6Bnh8g(params string[] string_0)
		{
			if (string_0.Length != 0)
			{
				_zatbtX2c8i2hGOTptNymBxA8kVI = true;
				_mc4p6vpMBZ0hOHPqLBE5H6OxT7f = 0;
				_VZ02JDgQaX5qJVSBot6TM2rtZ3O = 0;
				for (int i = 0; i < string_0.Length && i < _92GwVFulItjaDs6osQZyIk9xgMH.Length; i++)
				{
					_92GwVFulItjaDs6osQZyIk9xgMH[i].Text = string_0[i];
					_92GwVFulItjaDs6osQZyIk9xgMH[i]._Fxy2SlgceW90FloFw6a1AEJODYA = true;
					_VZ02JDgQaX5qJVSBot6TM2rtZ3O++;
				}
				for (int j = string_0.Length; j < _92GwVFulItjaDs6osQZyIk9xgMH.Length; j++)
				{
					_92GwVFulItjaDs6osQZyIk9xgMH[j]._Fxy2SlgceW90FloFw6a1AEJODYA = false;
				}
				int num = (int)(30f + (float)(690 - _92GwVFulItjaDs6osQZyIk9xgMH[0]._2psWLw4AI8EIjQzaXnhGg8M1FnaA.Height - (_92GwVFulItjaDs6osQZyIk9xgMH[0]._2psWLw4AI8EIjQzaXnhGg8M1FnaA.Height + 15) * (_VZ02JDgQaX5qJVSBot6TM2rtZ3O - 1)) / 2f);
				for (int k = 0; k < _VZ02JDgQaX5qJVSBot6TM2rtZ3O; k++)
				{
					_92GwVFulItjaDs6osQZyIk9xgMH[k].X = (int)((float)(1920 - _92GwVFulItjaDs6osQZyIk9xgMH[k]._2psWLw4AI8EIjQzaXnhGg8M1FnaA.Width) / 2f);
					_92GwVFulItjaDs6osQZyIk9xgMH[k].Y = num + (_92GwVFulItjaDs6osQZyIk9xgMH[k]._2psWLw4AI8EIjQzaXnhGg8M1FnaA.Height + 15) * k;
				}
			}
		}

		public void _mXNb0ylIEgd0VJEHTX3MBvFWYEf(int int_0)
		{
			_zatbtX2c8i2hGOTptNymBxA8kVI = false;
			_mc4p6vpMBZ0hOHPqLBE5H6OxT7f = int_0;
			_VZ02JDgQaX5qJVSBot6TM2rtZ3O = 0;
			_iHJrndJdM1jj9TEnuU3BvgdDuvf[] array = _92GwVFulItjaDs6osQZyIk9xgMH;
			foreach (_iHJrndJdM1jj9TEnuU3BvgdDuvf iHJrndJdM1jj9TEnuU3BvgdDuvf in array)
			{
				iHJrndJdM1jj9TEnuU3BvgdDuvf._Fxy2SlgceW90FloFw6a1AEJODYA = false;
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

		public static readonly _DVKVvNZmeqGXSzmpcRmcXttpiKC _e6GzQtekajGAokkayN1IPGIhCKx = new _DVKVvNZmeqGXSzmpcRmcXttpiKC(60, 450, 1500);

		public static readonly _DVKVvNZmeqGXSzmpcRmcXttpiKC _NN1aVVAo1wwjW67j2cNcdp7rWET = new _DVKVvNZmeqGXSzmpcRmcXttpiKC(30, 300, 1000);

		public static readonly _DVKVvNZmeqGXSzmpcRmcXttpiKC _4d4FmftbqsXGnBhU8JorfUifjoo = new _DVKVvNZmeqGXSzmpcRmcXttpiKC(0, 0, 1000);

		public int _aFbxCmyEb7GMPT5kU3P9NvcWQgK { get; }

		public int _a5fUssbr0SWbg9Sv48tHvMxW2ic { get; }

		public int _TDuCcAGW0lPdvxvfHyDM3aP4i84 { get; }

		private _DVKVvNZmeqGXSzmpcRmcXttpiKC(int int_0, int int_1, int int_2)
		{
			_Z0PczRXoob7ELJ9tv4wCi8ZZKmJ = int_0;
			_i6vGYRDs82JalRkikuHhVIpANsf = int_1;
			_cNHarziciuhFNrgu75Fpww06cAy = int_2;
		}
	}

	private static _nkzqFdEfDyLcyGikIKGcHjklI4y _6T55wit7MiGfAWRkPwjNbJ8N8lG;

	private readonly IAmorous Amorous;

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
			switch (_6T55wit7MiGfAWRkPwjNbJ8N8lG._tAC7ojbHHd15LKk7rGbelW2nGWN)
			{
			case DialogueSpeed.Slow:
				_6T55wit7MiGfAWRkPwjNbJ8N8lG._4V6bFHOi28R2wJIOaQKs1A0pIQ0 = _DVKVvNZmeqGXSzmpcRmcXttpiKC._LPPPQ033UFYBL4fz3qUtSfOD75I;
				break;
			case DialogueSpeed.Normal:
				_6T55wit7MiGfAWRkPwjNbJ8N8lG._4V6bFHOi28R2wJIOaQKs1A0pIQ0 = _DVKVvNZmeqGXSzmpcRmcXttpiKC._e6GzQtekajGAokkayN1IPGIhCKx;
				break;
			case DialogueSpeed.Fast:
				_6T55wit7MiGfAWRkPwjNbJ8N8lG._4V6bFHOi28R2wJIOaQKs1A0pIQ0 = _DVKVvNZmeqGXSzmpcRmcXttpiKC._NN1aVVAo1wwjW67j2cNcdp7rWET;
				break;
			case DialogueSpeed.Instant:
				_6T55wit7MiGfAWRkPwjNbJ8N8lG._4V6bFHOi28R2wJIOaQKs1A0pIQ0 = _DVKVvNZmeqGXSzmpcRmcXttpiKC._4d4FmftbqsXGnBhU8JorfUifjoo;
				break;
			}
			_6T55wit7MiGfAWRkPwjNbJ8N8lG._R3gvtOBYRg2VLQrb2zkAwC846nt();
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

	public _nkzqFdEfDyLcyGikIKGcHjklI4y(IAmorous game, Texture2D texture2D_0, Texture2D texture2D_1, SpriteFont spriteFont_0, SpriteFont spriteFont_1)
	{
		_6T55wit7MiGfAWRkPwjNbJ8N8lG = this;
		Amorous = game;
		_P62DygY6CKZG8s5wqDu0uAFksjs = texture2D_0;
		_xnYepZuegigJCU2jcbZsfVIakzF = spriteFont_0;
		_23jI7jMreLgRTSs5rhEGCUkow2b = spriteFont_1;
		_rv7JIIMY4Ta1tpSvflng4Lose4H = new Vector2((float)(texture2D_0.Width - 1920) / 2f, 1080 - texture2D_0.Height);
		_4djSc5RiRJZMGzvYwwEprIYf6ZM = new Vector2(75f, 625f);
		_gWIuAj6CuJjxiHOmaYwYLvu8g0r = new Vector2[6]
		{
			new Vector2(75f, 720f),
			new Vector2(75f, 770f),
			new Vector2(75f, 820f),
			new Vector2(75f, 870f),
			new Vector2(75f, 920f),
			new Vector2(75f, 970f)
		};
		_fp8jsuSnELXqf2yy2JQDaXDCBVQ = new _3Kf8FQeGRyCD8FhytGMMBQFkhFl(game, texture2D_1, null, spriteFont_0);
		_NhL238TaCbkDiY6HXlWXZzzUYkm = DialogueSpeed.Normal;
		_dRHb7tDcI5IkrHNRAFSme9H1Rh4();
	}

	private void _dRHb7tDcI5IkrHNRAFSme9H1Rh4()
	{
		_9GQBAH2pi8Sm6ph1s6InjyQGe6R = new Desktop
		{
			Skin = Gui.GenerateStandardSkin(),
			Size = new Squid.Point(1920, 1080)
		};
		_9GQBAH2pi8Sm6ph1s6InjyQGe6R.SetSkin("Assets/GUI/Squid/DefaultSkin");
		FlowLayoutFrame flowLayoutFrame = new FlowLayoutFrame
		{
			Position = new Squid.Point(1220, (int)_4djSc5RiRJZMGzvYwwEprIYf6ZM.Y + 10),
			FlowDirection = FlowDirection.LeftToRight,
			Margin = new Margin(0, 0, 100, 0),
			HSpacing = 10,
			Size = new Squid.Point(650, 30)
		};
		Button button = new Button
		{
			Size = new Squid.Point(100, 30),
			TextAlign = Alignment.MiddleCenter,
			Text = "Save"
		};
		button.MouseClick += delegate
		{
			Amorous._8c7SHmhI0bvgm2S0W4WafcEBOzV(_9GQBAH2pi8Sm6ph1s6InjyQGe6R, delegate(bool bool_0)
			{
				_fp8jsuSnELXqf2yy2JQDaXDCBVQ._nJKYvZJ57vjjlQwmoeBmKihtS0b = bool_0;
			});
		};
		Button button2 = new Button
		{
			Size = new Squid.Point(100, 30),
			TextAlign = Alignment.MiddleCenter,
			Text = "Load"
		};
		button2.MouseClick += delegate
		{
			Amorous._xM8d2LuC070Xft2N9A0ulzGVshq(_9GQBAH2pi8Sm6ph1s6InjyQGe6R, delegate(bool bool_0)
			{
				_fp8jsuSnELXqf2yy2JQDaXDCBVQ._nJKYvZJ57vjjlQwmoeBmKihtS0b = bool_0;
			});
		};
		Button button3 = new Button
		{
			Size = new Squid.Point(100, 30),
			TextAlign = Alignment.MiddleCenter,
			Text = "Exit"
		};
		button3.MouseClick += delegate
		{
			Amorous._MES3SBLNIcxOd5F8ZqVEWmsIcmA(_9GQBAH2pi8Sm6ph1s6InjyQGe6R, delegate(bool bool_0)
			{
				_fp8jsuSnELXqf2yy2JQDaXDCBVQ._nJKYvZJ57vjjlQwmoeBmKihtS0b = bool_0;
			});
		};
		DropDownList dropDownList = new DropDownList();
		dropDownList.Style = "button";
		dropDownList.Size = new Squid.Point(120, 30);
		dropDownList.DropdownAbove = true;
		dropDownList.Label.TextAlign = Alignment.MiddleCenter;
		dropDownList.Label.AutoEllipsis = false;
		dropDownList.Dropdown.Resizable = false;
		dropDownList.Button.Visible = false;
		_xU7PBNQL0I3LiOcbd02e8KK5uYi = dropDownList;
		_xU7PBNQL0I3LiOcbd02e8KK5uYi.Listbox.Scrollbar.ButtonUp.Visible = false;
		_xU7PBNQL0I3LiOcbd02e8KK5uYi.Listbox.Scrollbar.ButtonDown.Visible = false;
		foreach (DialogueSpeed value in Enum.GetValues(typeof(DialogueSpeed)))
		{
			_xU7PBNQL0I3LiOcbd02e8KK5uYi.Items.Add(new ListBoxItem
			{
				Text = value.ToString(),
				Size = new Squid.Point(0, 30),
				Value = value
			});
		}
		_xU7PBNQL0I3LiOcbd02e8KK5uYi.SelectedItemChanged += delegate(Control control_0, ListBoxItem listBoxItem_0)
		{
			_NhL238TaCbkDiY6HXlWXZzzUYkm = (DialogueSpeed)listBoxItem_0.Value;
			Options.Data.DialogueTextSpeed = _tAC7ojbHHd15LKk7rGbelW2nGWN;
		};
		_2pNQedwLe7YapSxneCqi4SreGdH = new CheckBox
		{
			Text = "Auto-skip",
			Size = new Squid.Point(140, 30),
			Checked = _fUgDiz7KX8TZUVzFlTeXMOhmfUT
		};
		_2pNQedwLe7YapSxneCqi4SreGdH.CheckedChanged += delegate
		{
			_fUgDiz7KX8TZUVzFlTeXMOhmfUT = _2pNQedwLe7YapSxneCqi4SreGdH.Checked;
			Options.Data.DialogueAutoSkip = _O7kX3MfMCx3M2dVro1UbOCbajyo;
		};
		flowLayoutFrame.Controls.Add(button);
		flowLayoutFrame.Controls.Add(button2);
		flowLayoutFrame.Controls.Add(button3);
		flowLayoutFrame.Controls.Add(_2pNQedwLe7YapSxneCqi4SreGdH);
		flowLayoutFrame.Controls.Add(_xU7PBNQL0I3LiOcbd02e8KK5uYi);
		_9GQBAH2pi8Sm6ph1s6InjyQGe6R.Controls.Add(flowLayoutFrame);
	}

	private void _R3gvtOBYRg2VLQrb2zkAwC846nt()
	{
		if (_6T55wit7MiGfAWRkPwjNbJ8N8lG._xU7PBNQL0I3LiOcbd02e8KK5uYi != null)
		{
			_6T55wit7MiGfAWRkPwjNbJ8N8lG._xU7PBNQL0I3LiOcbd02e8KK5uYi.SelectedItem = _6T55wit7MiGfAWRkPwjNbJ8N8lG._xU7PBNQL0I3LiOcbd02e8KK5uYi.Items.First((ListBoxItem listBoxItem_0) => (DialogueSpeed)listBoxItem_0.Value == _tAC7ojbHHd15LKk7rGbelW2nGWN);
		}
	}

	private void _EwAojaUxtAdk1E5cI9aRmcwPirB()
	{
		if (_6T55wit7MiGfAWRkPwjNbJ8N8lG._2pNQedwLe7YapSxneCqi4SreGdH != null)
		{
			_6T55wit7MiGfAWRkPwjNbJ8N8lG._2pNQedwLe7YapSxneCqi4SreGdH.Checked = _O7kX3MfMCx3M2dVro1UbOCbajyo;
		}
	}

	public void Update(GameTime gameTime_0)
	{
		switch (_lMAOhEkyOOJcbuU0ONDYvJ8bs8w)
		{
		case _QGnsmTImvr3dFBCr8hpzDZiCWLP.None:
			return;
		case _QGnsmTImvr3dFBCr8hpzDZiCWLP.Started:
			_lMAOhEkyOOJcbuU0ONDYvJ8bs8w = _QGnsmTImvr3dFBCr8hpzDZiCWLP.Visible;
			return;
		}
		_fp8jsuSnELXqf2yy2JQDaXDCBVQ.Update(gameTime_0);
		if (Amorous._5zNdOw7qHmuCAPJFMr3SsZdBlCr != null)
		{
			_9GQBAH2pi8Sm6ph1s6InjyQGe6R.Update();
		}
		if (_fp8jsuSnELXqf2yy2JQDaXDCBVQ._nJKYvZJ57vjjlQwmoeBmKihtS0b)
		{
			_mBZq0n4Bks2rpEfFwuLZ2Mlxlwi(gameTime_0);
		}
	}

	private void _mBZq0n4Bks2rpEfFwuLZ2Mlxlwi(GameTime gameTime_0)
	{
		if (_NYF6CyMYCqbkxJ8Q1N7O3ehzldE == _IIGQSKohQsLi09FILC8oKHG5UXG.Done)
		{
			if (Amorous._5zNdOw7qHmuCAPJFMr3SsZdBlCr == null)
			{
				ResetPlayer();
			}
			return;
		}
		if ((_NYF6CyMYCqbkxJ8Q1N7O3ehzldE == _IIGQSKohQsLi09FILC8oKHG5UXG.Waiting || _NYF6CyMYCqbkxJ8Q1N7O3ehzldE == _IIGQSKohQsLi09FILC8oKHG5UXG.Typing || _NYF6CyMYCqbkxJ8Q1N7O3ehzldE == _IIGQSKohQsLi09FILC8oKHG5UXG.WaitForSkip) && _8rrKDeGOr7tozdP0dxFbBPWq7NG())
		{
			_NeIQsy78kWqF9jXLl8vb2lOyZgO();
			if (_MOBkoboXIfjixJIW15TJTdFlwDC != 0)
			{
				_NYF6CyMYCqbkxJ8Q1N7O3ehzldE = _MOBkoboXIfjixJIW15TJTdFlwDC;
				_MOBkoboXIfjixJIW15TJTdFlwDC = _IIGQSKohQsLi09FILC8oKHG5UXG.None;
			}
			else if (!_fUgDiz7KX8TZUVzFlTeXMOhmfUT)
			{
				_NYF6CyMYCqbkxJ8Q1N7O3ehzldE = _IIGQSKohQsLi09FILC8oKHG5UXG.WaitForSkip;
				_MOBkoboXIfjixJIW15TJTdFlwDC = _IIGQSKohQsLi09FILC8oKHG5UXG.Skip;
			}
			else
			{
				_Q7Kx7ErHf3u1QIUDKfFCKSXbznG = _4V6bFHOi28R2wJIOaQKs1A0pIQ0._TDuCcAGW0lPdvxvfHyDM3aP4i84;
				_NYF6CyMYCqbkxJ8Q1N7O3ehzldE = _IIGQSKohQsLi09FILC8oKHG5UXG.Waiting;
				_MOBkoboXIfjixJIW15TJTdFlwDC = _IIGQSKohQsLi09FILC8oKHG5UXG.Skip;
			}
		}
		switch (_NYF6CyMYCqbkxJ8Q1N7O3ehzldE)
		{
		case _IIGQSKohQsLi09FILC8oKHG5UXG.Started:
			if (_4V6bFHOi28R2wJIOaQKs1A0pIQ0._aFbxCmyEb7GMPT5kU3P9NvcWQgK != 0)
			{
				_NYF6CyMYCqbkxJ8Q1N7O3ehzldE = _IIGQSKohQsLi09FILC8oKHG5UXG.Typing;
				_MOBkoboXIfjixJIW15TJTdFlwDC = _IIGQSKohQsLi09FILC8oKHG5UXG.None;
			}
			else
			{
				_NeIQsy78kWqF9jXLl8vb2lOyZgO();
				_NYF6CyMYCqbkxJ8Q1N7O3ehzldE = _IIGQSKohQsLi09FILC8oKHG5UXG.WaitForSkip;
				_MOBkoboXIfjixJIW15TJTdFlwDC = _IIGQSKohQsLi09FILC8oKHG5UXG.Skip;
			}
			break;
		case _IIGQSKohQsLi09FILC8oKHG5UXG.Typing:
		{
			char c = _3wk7bXUbhNqSQ9kMD9hieEubOhG._ZKadRFahgnwn10dM34638KGsLNu();
			if (_3wk7bXUbhNqSQ9kMD9hieEubOhG._xJZUPxDatEzfPQc0nRHR2D1Vwke)
			{
				if (!_fUgDiz7KX8TZUVzFlTeXMOhmfUT)
				{
					_NYF6CyMYCqbkxJ8Q1N7O3ehzldE = _IIGQSKohQsLi09FILC8oKHG5UXG.WaitForSkip;
				}
				else
				{
					_Q7Kx7ErHf3u1QIUDKfFCKSXbznG = _4V6bFHOi28R2wJIOaQKs1A0pIQ0._TDuCcAGW0lPdvxvfHyDM3aP4i84;
					_NYF6CyMYCqbkxJ8Q1N7O3ehzldE = _IIGQSKohQsLi09FILC8oKHG5UXG.Waiting;
				}
				_MOBkoboXIfjixJIW15TJTdFlwDC = _IIGQSKohQsLi09FILC8oKHG5UXG.Skip;
			}
			else
			{
				if (c != '░')
				{
					_Q7Kx7ErHf3u1QIUDKfFCKSXbznG = _4V6bFHOi28R2wJIOaQKs1A0pIQ0._aFbxCmyEb7GMPT5kU3P9NvcWQgK;
				}
				else
				{
					_Q7Kx7ErHf3u1QIUDKfFCKSXbznG = _4V6bFHOi28R2wJIOaQKs1A0pIQ0._a5fUssbr0SWbg9Sv48tHvMxW2ic;
				}
				_NYF6CyMYCqbkxJ8Q1N7O3ehzldE = _IIGQSKohQsLi09FILC8oKHG5UXG.Waiting;
				_MOBkoboXIfjixJIW15TJTdFlwDC = _IIGQSKohQsLi09FILC8oKHG5UXG.Typing;
			}
			break;
		}
		case _IIGQSKohQsLi09FILC8oKHG5UXG.Waiting:
			_Q7Kx7ErHf3u1QIUDKfFCKSXbznG -= gameTime_0.ElapsedGameTime.Milliseconds;
			if (_Q7Kx7ErHf3u1QIUDKfFCKSXbznG <= 0)
			{
				_Q7Kx7ErHf3u1QIUDKfFCKSXbznG = 0;
				_NYF6CyMYCqbkxJ8Q1N7O3ehzldE = _MOBkoboXIfjixJIW15TJTdFlwDC;
				_MOBkoboXIfjixJIW15TJTdFlwDC = _IIGQSKohQsLi09FILC8oKHG5UXG.None;
			}
			break;
		case _IIGQSKohQsLi09FILC8oKHG5UXG.Skip:
			_NYF6CyMYCqbkxJ8Q1N7O3ehzldE = _IIGQSKohQsLi09FILC8oKHG5UXG.Done;
			_MOBkoboXIfjixJIW15TJTdFlwDC = _IIGQSKohQsLi09FILC8oKHG5UXG.None;
			break;
		case _IIGQSKohQsLi09FILC8oKHG5UXG.WaitForSkip:
			break;
		}
	}

	private bool _8rrKDeGOr7tozdP0dxFbBPWq7NG()
	{
		if (Amorous._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(Microsoft.Xna.Framework.Input.Keys.Space))
		{
			return true;
		}
		if (Amorous._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(_PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton))
		{
			Microsoft.Xna.Framework.Point point = Amorous._vsceSzSIjBy2nZrCxAzKZbUiwLq._u7uCdK9i8FnWhiaPn2bO2wIgUUuA(Amorous._RbWJ7YGnYHCSoD44MRW1h5X6E7E._U7CeYBJ1v1SoUxpX8emsQ9mWl5b);
			if ((float)point.Y >= _rv7JIIMY4Ta1tpSvflng4Lose4H.Y + 10f && point.Y <= 1080)
			{
				return true;
			}
		}
		return false;
	}

	private void _bkUB7WagRc6RJkVVY4DTGPizp0F(_oDZZ0F7Qg08utTIjAaoyIbeDuFG _oDZZ0F7Qg08utTIjAaoyIbeDuFG_0)
	{
		_3wk7bXUbhNqSQ9kMD9hieEubOhG = _oDZZ0F7Qg08utTIjAaoyIbeDuFG_0;
		_3wk7bXUbhNqSQ9kMD9hieEubOhG._TN6mQ7Lbe501vwqhgs7b8d6wd1b(_xnYepZuegigJCU2jcbZsfVIakzF, _23jI7jMreLgRTSs5rhEGCUkow2b);
		_3wk7bXUbhNqSQ9kMD9hieEubOhG._pYBSD3QOMXtGMbCUDyvyluUZnx();
		_lMAOhEkyOOJcbuU0ONDYvJ8bs8w = _QGnsmTImvr3dFBCr8hpzDZiCWLP.Started;
		_NYF6CyMYCqbkxJ8Q1N7O3ehzldE = _IIGQSKohQsLi09FILC8oKHG5UXG.Started;
		_MOBkoboXIfjixJIW15TJTdFlwDC = _IIGQSKohQsLi09FILC8oKHG5UXG.None;
	}

	private void _QrgbXEg7MMeD9Ybz12fFVsbmAd9(_oDZZ0F7Qg08utTIjAaoyIbeDuFG _oDZZ0F7Qg08utTIjAaoyIbeDuFG_0)
	{
		_3wk7bXUbhNqSQ9kMD9hieEubOhG = _oDZZ0F7Qg08utTIjAaoyIbeDuFG_0;
		_3wk7bXUbhNqSQ9kMD9hieEubOhG._TN6mQ7Lbe501vwqhgs7b8d6wd1b(_xnYepZuegigJCU2jcbZsfVIakzF, _23jI7jMreLgRTSs5rhEGCUkow2b);
		_Q7Kx7ErHf3u1QIUDKfFCKSXbznG = 150;
		_lMAOhEkyOOJcbuU0ONDYvJ8bs8w = _QGnsmTImvr3dFBCr8hpzDZiCWLP.Started;
		_NYF6CyMYCqbkxJ8Q1N7O3ehzldE = _IIGQSKohQsLi09FILC8oKHG5UXG.Started;
		_MOBkoboXIfjixJIW15TJTdFlwDC = _IIGQSKohQsLi09FILC8oKHG5UXG.None;
	}

	public void Draw(SpriteBatch spriteBatch_0)
	{
		if (_lMAOhEkyOOJcbuU0ONDYvJ8bs8w == _QGnsmTImvr3dFBCr8hpzDZiCWLP.None)
		{
			return;
		}
		_fp8jsuSnELXqf2yy2JQDaXDCBVQ.Draw(spriteBatch_0);
		_oDZZ0F7Qg08utTIjAaoyIbeDuFG oDZZ0F7Qg08utTIjAaoyIbeDuFG = _3wk7bXUbhNqSQ9kMD9hieEubOhG;
		if (oDZZ0F7Qg08utTIjAaoyIbeDuFG != null)
		{
			spriteBatch_0.Begin();
			spriteBatch_0.Draw(_P62DygY6CKZG8s5wqDu0uAFksjs, _rv7JIIMY4Ta1tpSvflng4Lose4H, oDZZ0F7Qg08utTIjAaoyIbeDuFG.Color);
			if (!string.IsNullOrEmpty(oDZZ0F7Qg08utTIjAaoyIbeDuFG.Title))
			{
				spriteBatch_0.DrawString(_xnYepZuegigJCU2jcbZsfVIakzF, oDZZ0F7Qg08utTIjAaoyIbeDuFG.Title, _4djSc5RiRJZMGzvYwwEprIYf6ZM, oDZZ0F7Qg08utTIjAaoyIbeDuFG.Color);
			}
			oDZZ0F7Qg08utTIjAaoyIbeDuFG.Draw(spriteBatch_0, _xnYepZuegigJCU2jcbZsfVIakzF, _23jI7jMreLgRTSs5rhEGCUkow2b, _gWIuAj6CuJjxiHOmaYwYLvu8g0r);
			spriteBatch_0.End();
			if (Amorous._5zNdOw7qHmuCAPJFMr3SsZdBlCr != null)
			{
				_9GQBAH2pi8Sm6ph1s6InjyQGe6R.Draw();
			}
		}
	}

	public void ResetPlayer()
	{
		_3wk7bXUbhNqSQ9kMD9hieEubOhG = null;
		_Q7Kx7ErHf3u1QIUDKfFCKSXbznG = 0;
		_lMAOhEkyOOJcbuU0ONDYvJ8bs8w = _QGnsmTImvr3dFBCr8hpzDZiCWLP.None;
		_NYF6CyMYCqbkxJ8Q1N7O3ehzldE = _IIGQSKohQsLi09FILC8oKHG5UXG.None;
		_MOBkoboXIfjixJIW15TJTdFlwDC = _IIGQSKohQsLi09FILC8oKHG5UXG.None;
	}

	public static void _9RhaHKUaQmQeJrrxVYowZyJe4mo(string string_0, string string_1, Color color_0)
	{
		_6T55wit7MiGfAWRkPwjNbJ8N8lG._bkUB7WagRc6RJkVVY4DTGPizp0F(new _oDZZ0F7Qg08utTIjAaoyIbeDuFG(string_0, string_1, color_0));
	}

	public static void _zunSyHn4DekdA6CngP10dXcR1kq(string string_0, string string_1, Color color_0)
	{
		_6T55wit7MiGfAWRkPwjNbJ8N8lG._QrgbXEg7MMeD9Ybz12fFVsbmAd9(new _oDZZ0F7Qg08utTIjAaoyIbeDuFG(string_0, string_1, color_0));
	}

	public static void _NeIQsy78kWqF9jXLl8vb2lOyZgO()
	{
		if (_6T55wit7MiGfAWRkPwjNbJ8N8lG._3wk7bXUbhNqSQ9kMD9hieEubOhG != null)
		{
			_6T55wit7MiGfAWRkPwjNbJ8N8lG._3wk7bXUbhNqSQ9kMD9hieEubOhG._pYBSD3QOMXtGMbCUDyvyluUZnx();
		}
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
		_6T55wit7MiGfAWRkPwjNbJ8N8lG.ResetPlayer();
	}
}
