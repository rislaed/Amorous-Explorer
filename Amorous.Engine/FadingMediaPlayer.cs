using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Media;

public class FadingMediaPlayer : AbstractInterpolator<float>
{ // _UmxbIbk7pgaod0bD7pS309P3Lns
	private readonly ContentManager _content;
	private static FadingMediaPlayer _singleton;
	private string _path;
	private string[] _stack;
	private int _index;
	private bool _repeating;

	public FadingMediaPlayer(ContentManager content)
	{
		_singleton = this;
		_content = content;
		_stack = new string[0];
		MediaPlayer.ActiveSongChanged += delegate
		{
			if (MediaPlayer.State == MediaState.Stopped && _stack.Length > 1)
			{
				_index++;
				if (_index >= _stack.Length)
				{
					if (!_repeating)
					{
						return;
					}
					_index = 0;
				}
				_path = _stack[_index];
				Song song = _content.Load<Song>(_path);
				MediaPlayer.Play(song);
			}
		};
	}

	protected override float Interpolate(float value1, float value2, float interpolation)
	{
		return MathHelper.Lerp(value1, value2, interpolation);
	}

	public void InterpolateVolume()
	{
		MediaPlayer.Volume = Options.Data.MasterVolume * Options.Data.MusicVolume * base.State;
	}

	public void Start(string name, float volume, bool repeat)
	{
		if (_stack.Length != 1 || !name.Equals(_path))
		{
			_stack = new string[1] { name };
			_path = name;
			_index = 0;
			_repeating = repeat;
			Song song = _content.Load<Song>(_path);
			Set(volume);
			MediaPlayer.Play(song);
			MediaPlayer.IsRepeating = repeat;
		}
	}

	public void Start(string[] names, float volume, bool repeat, bool oneOf)
	{
		if (names.Length == 0 || (names.Length == _stack.Length && ((IEnumerable<string>)_stack).All((Func<string, bool>)((IEnumerable<string>)names).Contains)))
		{
			return;
		}
		if (oneOf)
		{
			_stack = names.OrderBy((string self) => Randoms.Next()).ToArray();
		}
		else
		{
			_stack = names;
		}
		_path = names[0];
		_index = 0;
		_repeating = repeat;
		Song song = _content.Load<Song>(_path);
		Set(volume);
		MediaPlayer.Play(song);
		MediaPlayer.IsRepeating = false;
	}

	public static void Play(string name, float volume, bool repeat)
	{
		_singleton.Start(name, volume, repeat: false); // ?
	}

	public static void Play(string[] names, float volume, bool repeat, bool oneOf)
	{
		_singleton.Start(names, volume, repeat, oneOf);
	}

	public static void Complete()
	{
		_singleton._stack = new string[0];
		_singleton._path = null;
		MediaPlayer.Stop();
	}

	public static void PlayOnRepeat(string name, float volume)
	{
		_singleton.Start(name, volume, repeat: true);
	}

	public static void FadeOut(Action then = null)
	{
		_singleton.To(0f, then);
	}

	public static void FadeIn(Action then = null)
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
