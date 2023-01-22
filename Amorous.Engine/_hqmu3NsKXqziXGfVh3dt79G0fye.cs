using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;

public class _hqmu3NsKXqziXGfVh3dt79G0fye
{
	private readonly Dictionary<string, SoundEffect> _G6ytq2szip28Pty4dJdow3N4n7H;

	private readonly ContentManager _kyNMbF8EBji1HoeA7mnul2Xsd1P;

	public _hqmu3NsKXqziXGfVh3dt79G0fye(ContentManager contentManager_0)
	{
		_kyNMbF8EBji1HoeA7mnul2Xsd1P = contentManager_0;
		_G6ytq2szip28Pty4dJdow3N4n7H = new Dictionary<string, SoundEffect>();
	}

	public void _cHRhcv3PTfJmYNZAZdcHvbfbkpj(params string[] string_0)
	{
		foreach (string key in string_0)
		{
			_G6ytq2szip28Pty4dJdow3N4n7H.Add(key, null);
		}
	}

	public void _xDFlaclLtJxSUU63JEJALvRLdfe(float float_0 = 1f)
	{
		if (_G6ytq2szip28Pty4dJdow3N4n7H.Count != 0)
		{
			string text = _G6ytq2szip28Pty4dJdow3N4n7H.Keys.ElementAt(_boyt8NIMtKsAGSTcjHeL0WMbFxs._07xTWbIEgzxJYsYwFKDbbKNvu4G(0, _G6ytq2szip28Pty4dJdow3N4n7H.Count));
			if (_G6ytq2szip28Pty4dJdow3N4n7H[text] == null)
			{
				_G6ytq2szip28Pty4dJdow3N4n7H[text] = _kyNMbF8EBji1HoeA7mnul2Xsd1P.Load<SoundEffect>(text);
			}
			_G6ytq2szip28Pty4dJdow3N4n7H[text].Play(_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._DF24JUrPFA6rJ2cQrOTlpC3I4FF * _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._2g4Ch8GXdUt0oEbdCZUY2QMbIuH * float_0, 0f, 0f);
		}
	}
}
