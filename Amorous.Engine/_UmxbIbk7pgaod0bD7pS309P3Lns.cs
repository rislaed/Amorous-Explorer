using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Media;

public class _UmxbIbk7pgaod0bD7pS309P3Lns : _RlrsL89bialFQa9mzWurgsdr6FK<float>
{
	private readonly ContentManager _7FoDc5IeOhkrJIekU2AAQQKZqefA;

	private static _UmxbIbk7pgaod0bD7pS309P3Lns Singleton;

	private string _wx0H9mDGCmUNsmV59Nj48JPJkEc;

	private string[] _eT7BaYRygkyX4kj8h6aEwrq2uN;

	private int _bTbQqsABbUefrkPeEqkxzxUsr8F;

	private bool _avz8WSjNjL0U8mdfRNAb5mHaApV;

	public _UmxbIbk7pgaod0bD7pS309P3Lns(ContentManager content)
	{
		Singleton = this;
		_7FoDc5IeOhkrJIekU2AAQQKZqefA = content;
		_eT7BaYRygkyX4kj8h6aEwrq2uN = new string[0];
		MediaPlayer.ActiveSongChanged += delegate
		{
			if (MediaPlayer.State == MediaState.Stopped && _eT7BaYRygkyX4kj8h6aEwrq2uN.Length > 1)
			{
				_bTbQqsABbUefrkPeEqkxzxUsr8F++;
				if (_bTbQqsABbUefrkPeEqkxzxUsr8F >= _eT7BaYRygkyX4kj8h6aEwrq2uN.Length)
				{
					if (!_avz8WSjNjL0U8mdfRNAb5mHaApV)
					{
						return;
					}
					_bTbQqsABbUefrkPeEqkxzxUsr8F = 0;
				}
				_wx0H9mDGCmUNsmV59Nj48JPJkEc = _eT7BaYRygkyX4kj8h6aEwrq2uN[_bTbQqsABbUefrkPeEqkxzxUsr8F];
				Song song = _7FoDc5IeOhkrJIekU2AAQQKZqefA.Load<Song>(_wx0H9mDGCmUNsmV59Nj48JPJkEc);
				MediaPlayer.Play(song);
			}
		};
	}

	protected override float _Gs9QTlqmpM6Jpgrjf53LUcRTbM(float float_0, float float_1, float float_2)
	{
		return MathHelper.Lerp(float_0, float_1, float_2);
	}

	public void _LcX2y4hMIzQST4uGT2Q5Ce7vaGg()
	{
		MediaPlayer.Volume = Options.Data.MasterVolume * Options.Data.MusicVolume * base.State;
	}

	public void _nqn4Aw4hEsNL81QdtrDK2OwS6Kr(string string_0, float float_0, bool bool_0)
	{
		if (_eT7BaYRygkyX4kj8h6aEwrq2uN.Length != 1 || !string_0.Equals(_wx0H9mDGCmUNsmV59Nj48JPJkEc))
		{
			_eT7BaYRygkyX4kj8h6aEwrq2uN = new string[1] { string_0 };
			_wx0H9mDGCmUNsmV59Nj48JPJkEc = string_0;
			_bTbQqsABbUefrkPeEqkxzxUsr8F = 0;
			_avz8WSjNjL0U8mdfRNAb5mHaApV = bool_0;
			Song song = _7FoDc5IeOhkrJIekU2AAQQKZqefA.Load<Song>(_wx0H9mDGCmUNsmV59Nj48JPJkEc);
			_98dbKZq4dvkw2wLkjZ77Y5Ih4xP(float_0);
			MediaPlayer.Play(song);
			MediaPlayer.IsRepeating = bool_0;
		}
	}

	public void _nqn4Aw4hEsNL81QdtrDK2OwS6Kr(string[] string_0, float float_0, bool bool_0, bool bool_1)
	{
		if (string_0.Length == 0 || (string_0.Length == _eT7BaYRygkyX4kj8h6aEwrq2uN.Length && ((IEnumerable<string>)_eT7BaYRygkyX4kj8h6aEwrq2uN).All((Func<string, bool>)((IEnumerable<string>)string_0).Contains)))
		{
			return;
		}
		if (bool_1)
		{
			_eT7BaYRygkyX4kj8h6aEwrq2uN = string_0.OrderBy((string string_0) => _boyt8NIMtKsAGSTcjHeL0WMbFxs._07xTWbIEgzxJYsYwFKDbbKNvu4G()).ToArray();
		}
		else
		{
			_eT7BaYRygkyX4kj8h6aEwrq2uN = string_0;
		}
		_wx0H9mDGCmUNsmV59Nj48JPJkEc = string_0[0];
		_bTbQqsABbUefrkPeEqkxzxUsr8F = 0;
		_avz8WSjNjL0U8mdfRNAb5mHaApV = bool_0;
		Song song = _7FoDc5IeOhkrJIekU2AAQQKZqefA.Load<Song>(_wx0H9mDGCmUNsmV59Nj48JPJkEc);
		_98dbKZq4dvkw2wLkjZ77Y5Ih4xP(float_0);
		MediaPlayer.Play(song);
		MediaPlayer.IsRepeating = false;
	}

	public static void _QrgbXEg7MMeD9Ybz12fFVsbmAd9(string string_0, float float_0, bool bool_0)
	{
		Singleton._nqn4Aw4hEsNL81QdtrDK2OwS6Kr(string_0, float_0, bool_0: false);
	}

	public static void _QrgbXEg7MMeD9Ybz12fFVsbmAd9(string[] string_0, float float_0, bool bool_0, bool bool_1)
	{
		Singleton._nqn4Aw4hEsNL81QdtrDK2OwS6Kr(string_0, float_0, bool_0, bool_1);
	}

	public static void _h0KfaNiikKlJV2KkRPIdVDKVJnC()
	{
		Singleton._eT7BaYRygkyX4kj8h6aEwrq2uN = new string[0];
		Singleton._wx0H9mDGCmUNsmV59Nj48JPJkEc = null;
		MediaPlayer.Stop();
	}

	public static void _l94kUraQ13OohoVwwxKC37hG7Pc(string string_0, float float_0)
	{
		Singleton._nqn4Aw4hEsNL81QdtrDK2OwS6Kr(string_0, float_0, bool_0: true);
	}

	public static void _PYAXEqRAOkDRRNqm1k71R7GJTJK(Action action_0 = null)
	{
		Singleton._9JRBBOsuQbaGxb3DQypwWYtojV0(0f, action_0);
	}

	public static void _FegL010tc92iskjjyD0T33dDwNE(Action action_0 = null)
	{
		Singleton._9JRBBOsuQbaGxb3DQypwWYtojV0(1f, action_0);
	}

	public static void _7d2DAwjp6FutkJY09U0Mlk43Nmn(float float_0, Action action_0 = null)
	{
		Singleton._9JRBBOsuQbaGxb3DQypwWYtojV0(float_0, action_0);
	}

	public static void _E7yBM68AWt7OGHJ5D6xYA8RK8tAA(float float_0)
	{
		Singleton._98dbKZq4dvkw2wLkjZ77Y5Ih4xP(float_0);
	}
}
