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
		while (true)
		{
			int num = 55297016;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x88DA471u) % 3u)
				{
				case 2u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0008:
				_kyNMbF8EBji1HoeA7mnul2Xsd1P = contentManager_0;
				_G6ytq2szip28Pty4dJdow3N4n7H = new Dictionary<string, SoundEffect>();
				num = (int)(num2 * 1211401886) ^ -865935618;
			}
		}
	}

	public void _cHRhcv3PTfJmYNZAZdcHvbfbkpj(params string[] string_0)
	{
		int num = 0;
		while (true)
		{
			int num2;
			int num3;
			if (num >= string_0.Length)
			{
				num2 = 231437421;
				num3 = 231437421;
			}
			else
			{
				num2 = 944415850;
				num3 = 944415850;
			}
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)num2 ^ 0x644021B3u) % 5u)
				{
				case 3u:
					num++;
					num2 = ((int)num4 * -550792817) ^ 0x5F36E06C;
					continue;
				case 2u:
				{
					string key = string_0[num];
					_G6ytq2szip28Pty4dJdow3N4n7H.Add(key, null);
					num2 = 1609212181;
					continue;
				}
				case 0u:
					num2 = 944415850;
					continue;
				default:
					return;
				case 4u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public void _xDFlaclLtJxSUU63JEJALvRLdfe(float float_0 = 1f)
	{
		if (_G6ytq2szip28Pty4dJdow3N4n7H.Count == 0)
		{
			goto IL_0068;
		}
		goto IL_0096;
		IL_0096:
		string text = _G6ytq2szip28Pty4dJdow3N4n7H.Keys.ElementAt(_boyt8NIMtKsAGSTcjHeL0WMbFxs._07xTWbIEgzxJYsYwFKDbbKNvu4G(0, _G6ytq2szip28Pty4dJdow3N4n7H.Count));
		int num = 1413663219;
		goto IL_006d;
		IL_006d:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x3FEF914Fu) % 6u)
			{
			case 4u:
			{
				int num3;
				int num4;
				if (_G6ytq2szip28Pty4dJdow3N4n7H[text] == null)
				{
					num3 = -1351239623;
					num4 = -1351239623;
				}
				else
				{
					num3 = -2055612098;
					num4 = -2055612098;
				}
				num = num3 ^ (int)(num2 * 1995221621);
				continue;
			}
			case 2u:
				_G6ytq2szip28Pty4dJdow3N4n7H[text] = _kyNMbF8EBji1HoeA7mnul2Xsd1P.Load<SoundEffect>(text);
				num = (int)((num2 * 1343619244) ^ 0x3EF0CBAA);
				continue;
			case 0u:
				break;
			case 1u:
				goto IL_0096;
			default:
				_hqmu3NsKXqziXGfVh3dt79G0fye.smethod_0(_G6ytq2szip28Pty4dJdow3N4n7H[text], _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._DF24JUrPFA6rJ2cQrOTlpC3I4FF * _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._2g4Ch8GXdUt0oEbdCZUY2QMbIuH * float_0, 0f, 0f);
				return;
			case 5u:
				return;
			}
			break;
		}
		goto IL_0068;
		IL_0068:
		num = 1899379916;
		goto IL_006d;
	}

	static bool smethod_0(SoundEffect soundEffect_0, float float_0, float float_1, float float_2)
	{
		return soundEffect_0.Play(float_0, float_1, float_2);
	}
}
