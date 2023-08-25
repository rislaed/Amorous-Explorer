using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;

public class RandomSoundEffect
{ // _hqmu3NsKXqziXGfVh3dt79G0fye
	private readonly Dictionary<string, SoundEffect> sounds;
	private readonly ContentManager content;

	public RandomSoundEffect(ContentManager content)
	{
		this.content = content;
		sounds = new Dictionary<string, SoundEffect>();
	}

	public void Append(params string[] keys)
	{
		foreach (string key in keys)
		{
			sounds.Add(key, null);
		}
	}

	public void PlayNext(float volume = 1f)
	{
		if (sounds.Count != 0)
		{
			string oneOf = sounds.Keys.ElementAt(Utils.Random(0, sounds.Count));
			if (sounds[oneOf] == null)
			{
				sounds[oneOf] = content.Load<SoundEffect>(oneOf);
			}
			sounds[oneOf].Play(Options.Config.MasterVolume * Options.Config.SfxVolume * volume, 0f, 0f);
		}
	}
}
