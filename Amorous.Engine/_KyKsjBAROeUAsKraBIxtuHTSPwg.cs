using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Squid;

public static class _KyKsjBAROeUAsKraBIxtuHTSPwg
{
	public static Action _Uh2GhEF2pLNc3a7l5WMdPGP2bZd;

	public const int _1d6ZBLxg0DlvtImpd3DNw0NRpIW = 250;

	public const int _B21RMgiw1GXWBH1KtDhr7z8L2Ee = 500;

	public static void _8c7SHmhI0bvgm2S0W4WafcEBOzV(this IAmorous game, Desktop desktop_0, Action<bool> action_0)
	{
		action_0(obj: false);
		List<_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p> _rQhndDODcLCmH9PKjwXRNz0AcU8 = _DW9IcpdMEINZmuzfrqmwsduBGih._25D1ZH2er0EbpKmvFksAbFjP2OX(bool_0: true);
		List<string> _ILFAnNbgAYkKwOVs9Pn9012gw1w = _rQhndDODcLCmH9PKjwXRNz0AcU8.Select((_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p _3CCr8Bt1rkuzt0M6gYLbceJGV0p_0) => _3CCr8Bt1rkuzt0M6gYLbceJGV0p_0.Name).ToList();
		_ILFAnNbgAYkKwOVs9Pn9012gw1w.Add("Oops, I've changed my mind!");
		desktop_0.ShowSelection("Which slot do you wish to save to?", _ILFAnNbgAYkKwOVs9Pn9012gw1w.ToArray(), 500, delegate(int int_0)
		{
			if (int_0 != _ILFAnNbgAYkKwOVs9Pn9012gw1w.Count - 1)
			{
				_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p _yhDD7spe4cjr78VqajGqVzwbiVN = _rQhndDODcLCmH9PKjwXRNz0AcU8[int_0];
				if (!_yhDD7spe4cjr78VqajGqVzwbiVN._r4LqoJiAr5K9UiLsUzUDbcJDQqo)
				{
					desktop_0.ShowSelection($"Are you sure you wish to overwrite slot #{_yhDD7spe4cjr78VqajGqVzwbiVN._B3FsRMcQWBXzFf3nLOBKzncessO + 1}?", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, 250, delegate(int int_0)
					{
						if (int_0 == 1)
						{
							game._yh2DwZs16cvRtvGayeYZrMWlrbj(_yhDD7spe4cjr78VqajGqVzwbiVN._B3FsRMcQWBXzFf3nLOBKzncessO);
						}
						action_0(obj: true);
					});
				}
				else
				{
					game._yh2DwZs16cvRtvGayeYZrMWlrbj(_yhDD7spe4cjr78VqajGqVzwbiVN._B3FsRMcQWBXzFf3nLOBKzncessO);
					action_0(obj: true);
				}
			}
			else
			{
				action_0(obj: true);
			}
		});
	}

	public static void _xM8d2LuC070Xft2N9A0ulzGVshq(this IAmorous game, Desktop desktop_0, Action<bool> action_0)
	{
		action_0(obj: false);
		List<_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p> _rQhndDODcLCmH9PKjwXRNz0AcU8 = _DW9IcpdMEINZmuzfrqmwsduBGih._25D1ZH2er0EbpKmvFksAbFjP2OX(bool_0: true);
		List<string> _ILFAnNbgAYkKwOVs9Pn9012gw1w = _rQhndDODcLCmH9PKjwXRNz0AcU8.Select((_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p _3CCr8Bt1rkuzt0M6gYLbceJGV0p_0) => _3CCr8Bt1rkuzt0M6gYLbceJGV0p_0.Name).ToList();
		_ILFAnNbgAYkKwOVs9Pn9012gw1w.Add("Oops, I've changed my mind!");
		desktop_0.ShowSelection("Which save do you wish to load?", _ILFAnNbgAYkKwOVs9Pn9012gw1w.ToArray(), 500, delegate(int int_0)
		{
			if (int_0 == _ILFAnNbgAYkKwOVs9Pn9012gw1w.Count - 1)
			{
				action_0(obj: true);
			}
			else
			{
				_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p _yhDD7spe4cjr78VqajGqVzwbiVN = _rQhndDODcLCmH9PKjwXRNz0AcU8[int_0];
				if (!_yhDD7spe4cjr78VqajGqVzwbiVN._r4LqoJiAr5K9UiLsUzUDbcJDQqo)
				{
					desktop_0.ShowSelection($"Are you sure you wish to load slot #{_yhDD7spe4cjr78VqajGqVzwbiVN._B3FsRMcQWBXzFf3nLOBKzncessO + 1}?", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, 250, delegate(int int_0)
					{
						if (int_0 == 1)
						{
							game._Ut0dhlh4JTZBMNJPNxxI9f9VqTp(_yhDD7spe4cjr78VqajGqVzwbiVN._B3FsRMcQWBXzFf3nLOBKzncessO);
						}
						action_0(obj: true);
					});
				}
				else
				{
					desktop_0.ShowConfirm(string.Format("There is no save in {0}slot #{1}!", _yhDD7spe4cjr78VqajGqVzwbiVN._3y7m8OGVjMe7WGIhZ66YOw3ITUE ? "autosave " : string.Empty, int_0 + 1), 250, "OK", delegate
					{
						action_0(obj: true);
					});
				}
			}
		});
	}

	public static void _MES3SBLNIcxOd5F8ZqVEWmsIcmA(this IAmorous game, Desktop desktop_0, Action<bool> action_0)
	{
		action_0(obj: false);
		desktop_0.ShowSelection("Are you sure you wish to exit the Game? All unsaved progress will be lost!", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, 500, delegate(int int_0)
		{
			if (int_0 == 1)
			{
				if (_Uh2GhEF2pLNc3a7l5WMdPGP2bZd != null)
				{
					_Uh2GhEF2pLNc3a7l5WMdPGP2bZd();
				}
				else
				{
					game._udfEpcIRn7lWl5Lvjdyu0aG0A7G();
				}
			}
			action_0(obj: true);
		});
	}
}
