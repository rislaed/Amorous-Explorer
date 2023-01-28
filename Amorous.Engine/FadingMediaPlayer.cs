using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Media;

public class FadingMediaPlayer : AbstractInterpolator<float>
{
	private readonly ContentManager _content;
	private static FadingMediaPlayer _singleton;
	private string _wx0H9mDGCmUNsmV59Nj48JPJkEc;
	private string[] _eT7BaYRygkyX4kj8h6aEwrq2uN;
	private int _bTbQqsABbUefrkPeEqkxzxUsr8F;
	private bool _avz8WSjNjL0U8mdfRNAb5mHaApV;

	public FadingMediaPlayer(ContentManager content)
	{
		_singleton = this;
		_content = content;
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
				Song song = _content.Load<Song>(_wx0H9mDGCmUNsmV59Nj48JPJkEc);
				MediaPlayer.Play(song);
			}
		};
	}

	protected override float Interpolate(float value1, float value2, float interpolation)
	{
		return MathHelper.Lerp(value1, value2, interpolation);
	}

	public void _LcX2y4hMIzQST4uGT2Q5Ce7vaGg()
	{
		MediaPlayer.Volume = Options.Data.MasterVolume * Options.Data.MusicVolume * base.State;
	}

	public void Play(string name, float volume, bool repeat)
	{
		if (_eT7BaYRygkyX4kj8h6aEwrq2uN.Length != 1 || !name.Equals(_wx0H9mDGCmUNsmV59Nj48JPJkEc))
		{
			_eT7BaYRygkyX4kj8h6aEwrq2uN = new string[1] { name };
			_wx0H9mDGCmUNsmV59Nj48JPJkEc = name;
			_bTbQqsABbUefrkPeEqkxzxUsr8F = 0;
			_avz8WSjNjL0U8mdfRNAb5mHaApV = repeat;
			Song song = _content.Load<Song>(_wx0H9mDGCmUNsmV59Nj48JPJkEc);
			Set(volume);
			MediaPlayer.Play(song);
			MediaPlayer.IsRepeating = repeat;
		}
	}

	public void Play(string[] name, float volume, bool repeat, bool oneOf)
	{
		if (name.Length == 0 || (name.Length == _eT7BaYRygkyX4kj8h6aEwrq2uN.Length && ((IEnumerable<string>)_eT7BaYRygkyX4kj8h6aEwrq2uN).All((Func<string, bool>)((IEnumerable<string>)name).Contains)))
		{
			return;
		}
		if (oneOf)
		{
			_eT7BaYRygkyX4kj8h6aEwrq2uN = name.OrderBy((string self) => Randoms.Next()).ToArray();
		}
		else
		{
			_eT7BaYRygkyX4kj8h6aEwrq2uN = name;
		}
		_wx0H9mDGCmUNsmV59Nj48JPJkEc = name[0];
		_bTbQqsABbUefrkPeEqkxzxUsr8F = 0;
		_avz8WSjNjL0U8mdfRNAb5mHaApV = repeat;
		Song song = _content.Load<Song>(_wx0H9mDGCmUNsmV59Nj48JPJkEc);
		Set(volume);
		MediaPlayer.Play(song);
		MediaPlayer.IsRepeating = false;
	}

	public static void _QrgbXEg7MMeD9Ybz12fFVsbmAd9(string name, float volume, bool repeat)
	{
		_singleton.Play(name, volume, repeat: false);
	}

	public static void _QrgbXEg7MMeD9Ybz12fFVsbmAd9(string[] name, float volume, bool repeat, bool oneOf)
	{
		_singleton.Play(name, volume, repeat, oneOf);
	}

	public static void BeginCutscene()
	{
		_singleton._eT7BaYRygkyX4kj8h6aEwrq2uN = new string[0];
		_singleton._wx0H9mDGCmUNsmV59Nj48JPJkEc = null;
		MediaPlayer.Stop();
	}

	public static void _l94kUraQ13OohoVwwxKC37hG7Pc(string name, float volume)
	{
		_singleton.Play(name, volume, repeat: true);
	}

	public static void Show(Action then = null)
	{
		_singleton.To(0f, then);
	}

	public static void Hide(Action then = null)
	{
		_singleton.To(1f, then);
	}

	public static void Apply(float value, Action then = null)
	{
		_singleton.To(value, then);
	}

	public static void ApplyNow(float value)
	{
		_singleton.Set(value);
	}
}
