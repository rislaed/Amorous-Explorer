using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;

public class RandomSoundEffect
{ // _hqmu3NsKXqziXGfVh3dt79G0fye
	private readonly Dictionary<string, SoundEffect> _sounds;
	private readonly ContentManager _content;

	public RandomSoundEffect(ContentManager content)
	{
		_content = content;
		_sounds = new Dictionary<string, SoundEffect>();
	}

	public void Append(params string[] keys)
	{
		foreach (string key in keys)
		{
			_sounds.Add(key, null);
		}
	}

	public void PlayNext(float volume = 1f)
	{
		if (_sounds.Count != 0)
		{
			string oneOf = _sounds.Keys.ElementAt(Randoms.Next(0, _sounds.Count));
			if (_sounds[oneOf] == null)
			{
				_sounds[oneOf] = _content.Load<SoundEffect>(oneOf);
			}
			_sounds[oneOf].Play(Options.Data.MasterVolume * Options.Data.SfxVolume * volume, 0f, 0f);
		}
	}
}
