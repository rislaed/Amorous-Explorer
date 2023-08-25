using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Media;

public class FadingMediaPlayer : AbstractInterpolator<float>
{ // _UmxbIbk7pgaod0bD7pS309P3Lns
	private readonly ContentManager content;
	private static FadingMediaPlayer singleton;
	private string assetName;
	private string[] songs;
	private int index;
	private bool repeating;

	public FadingMediaPlayer(ContentManager content)
	{
		singleton = this;
		this.content = content;
		songs = new string[0];
		MediaPlayer.ActiveSongChanged += delegate
		{
			if (MediaPlayer.State == MediaState.Stopped && songs.Length > 1)
			{
				index++;
				if (index >= songs.Length)
				{
					if (!repeating)
					{
						return;
					}
					index = 0;
				}
				assetName = songs[index];
                MediaPlayer.Play(this.content.Load<Song>(assetName));
			}
		};
	}

	protected override float Interpolate(float value1, float value2, float amount)
	{
		return MathHelper.Lerp(value1, value2, amount);
	}

	public void InterpolateVolume()
	{
		MediaPlayer.Volume = Options.Config.MasterVolume * Options.Config.MusicVolume * base.Value;
	}

	public void Start(string name, float volume, bool repeat)
	{
		if (songs.Length != 1 || !name.Equals(assetName))
		{
			songs = new string[1] { name };
			assetName = name;
			index = 0;
			repeating = repeat;
			Song song = content.Load<Song>(assetName);
			End(volume);
			MediaPlayer.Play(song);
			MediaPlayer.IsRepeating = repeat;
		}
	}

	public void Start(string[] names, float volume, bool repeat, bool oneOf)
	{
		if (names.Length == 0 || (names.Length == songs.Length && ((IEnumerable<string>)songs).All((Func<string, bool>)((IEnumerable<string>)names).Contains)))
		{
			return;
		}
		if (oneOf)
		{
			songs = names.OrderBy((string self) => Utils.Random()).ToArray();
		}
		else
		{
			songs = names;
		}
		assetName = names[0];
		index = 0;
		repeating = repeat;
		Song song = content.Load<Song>(assetName);
		End(volume);
		MediaPlayer.Play(song);
		MediaPlayer.IsRepeating = false;
	}

	public static void Play(string name, float volume, bool repeat)
	{
		singleton.Start(name, volume, repeat: false); // ?
	}

	public static void Play(string[] names, float volume, bool repeat, bool oneOf)
	{
		singleton.Start(names, volume, repeat, oneOf);
	}

	public static void Complete()
	{
		singleton.songs = new string[0];
		singleton.assetName = null;
		MediaPlayer.Stop();
	}

	public static void PlayOnRepeat(string name, float volume)
	{
		singleton.Start(name, volume, repeat: true);
	}

	public static void FadeOut(Action then = null)
	{
		singleton.Begin(0f, then);
	}

	public static void FadeIn(Action then = null)
	{
		singleton.Begin(1f, then);
	}

	public static void Apply(float value, Action then = null)
	{
		singleton.Begin(value, then);
	}

	public static void ApplyWithoutFading(float value)
	{
		singleton.End(value);
	}
}
