using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

public class Achievements : IAchievements
{
	public enum _UARKn0z34q7eyfLAgMhaieKBn33
	{
		Generic,
		Contact
	}

	public class _eT2GJReQj8Acaq2A0H0eUir97Qf
	{
		public string _qXE0hlPdNyl0lTUyddbAS1PZhVV { get; }

		public string _OEBUKIcFNUq5lvHUCwgeAJT3Orq { get; }

		public _UARKn0z34q7eyfLAgMhaieKBn33 _hEIssNuRoEdRDJFan5fSkzWu4Kj { get; }

		public string Icon { get; }

		public string Title { get; }

		public _eT2GJReQj8Acaq2A0H0eUir97Qf(string string_0, string string_1, string string_2, string string_3 = "MessageIconGeneric", _UARKn0z34q7eyfLAgMhaieKBn33 _UARKn0z34q7eyfLAgMhaieKBn33_0 = _UARKn0z34q7eyfLAgMhaieKBn33.Generic)
		{
			_dGBdaEdAV5aJgHDENNyvloF5BlBA = string_0;
			_DfBMTv7hkAONT7WobFWboWUEvdL = string_1;
			_EMZ4CoDjMCDwqSRTQd7miSitflF = _UARKn0z34q7eyfLAgMhaieKBn33_0;
			_jmAZYxwCQcYOplIbeFsAtU6Dz8 = string_3;
			_fHbF0r78UBMiyDseUhbwAvEaqmp = string_2;
		}
	}

	public const string _S6B7VzJFVP7Y3Fi3St7kcxqag8M = "AchievementPhonenumberCoby";

	public const string _a7CDUyKAE2qiM9WqKnErmpVt3qw = "AchievementPhonenumberJax";

	public const string _s2TWKpGxsuvOCV8eQ4BdCQiOw33 = "AchievementPhonenumberSeth";

	public const string _RDcA0LCNIPLuBRnRKAsmUM694gI = "AchievementPhonenumberSkye";

	public const string _kYg4FSSrZbgdY6bh0jE4bGI0qQE = "AchievementPhonenumberDustin";

	public const string _6ykyoXFCCRzz8UBYhfQiBrnadCQ = "AchievementPhonenumberZenith";

	public const string _4qlaVYdXBqZfFT9lSjSnMODqnROA = "AchievementPhonenumberMercy";

	public const string _nrkoRmTAsLTDcZoNRqGjDhKaNsC = "AchievementPhonenumberRemy";

	public const string _CrfRoN6e4o2aa4SJDKqK8dlNKMBA = "AchievementPhonenumberLex";

	public const string _JwfJfK8JkOyYmyt2iPnsHGN4WUh = "AchievementDate1Coby";

	public const string _iVbFBMcUJUr9paWKCMQz5ImvJbH = "AchievementDate1Jax";

	public const string _6czc0aBTVCrgOYc7SHLrvJSlIEl = "AchievementDate2Jax";

	public const string _IeoFXQl6FGNPoCkOumWywDQBdKJ = "AchievementDate3Jax";

	public const string _VUaaRWPpPgrz66FVHDwRv8867mC = "AchievementDate1Seth";

	public const string _lrFjphz9SCia3AMACLiIBJapGCk = "AchievementDate2Seth";

	public const string _t1uzlCassGWFILSvpmyIkHgbT0N = "AchievementDate3Seth";

	public const string _koeYNIkIf6nvKyIbBmBEa5Sh5Bc = "AchievementDate1Skye";

	public const string _uiahhqLpqd4vmnKKIxY8mZnVnC = "AchievementDate2Skye";

	public const string _FsAams8NESdZVKOOEvTxIRoUtzG = "AchievementDate3Skye";

	public const string _Hyu9Eq6jYTv8Q0DkDJal4220z0A = "AchievementDate1Dustin";

	public const string _Ozu37lpbHX5NoJBe9Irmb6vP4wW = "AchievementDate2Dustin";

	public const string _DwuDkg4M9Adc7YHZxMzePdVkppb = "AchievementDate3Dustin";

	public const string _lndav6Ztwa8MLX2fGfUlqpc4ZbO = "AchievementDate1Zenith";

	public const string _GGogvhoVJkRaPFMSgpDjpeFppTC = "AchievementDate2Zenith";

	public const string _fGNzdgmzdJ5Q3lT3OLJQwKkD7XF = "AchievementDate3Zenith";

	public const string _plxF5m6bcc3vScC4bb4OYg69o4D = "AchievementDate1Mercy";

	public const string _6HAHYglTo5SqJYS9UplGIVmEu6G = "AchievementDate2Mercy";

	public const string _TFKzJtFMyBlkAwLHXPaqB4ZrG8f = "AchievementDate3Mercy";

	public const string _99w5EIwQNOEecCOI5uS6vH5jvS0 = "AchievementDate1Remy";

	public const string _3S91EwIHX5QdX8wlw6MWhJdCjem = "AchievementDate2Remy";

	public const string _QsCz97tpcTrjDFPoV94tLwoTbyg = "AchievementDate3Remy";

	public const string _OzA6crWN48yMnZd5KRXUWL3jyjb = "AchievementDate1Lex";

	public const string _vAMOpgkNpNIGNVD3PDbP7vXtAxE = "AchievementDate2Lex";

	public const string _MytZ8AS1SJuYc7s3RBSba2RoG3o = "AchievementDate3Lex";

	public const string _zBHR34SJT99YQA1CisdanRIHK1w = "AchievementGeneric1";

	public const string _bqiAeC2AJeU99WjZa5vDovaaviv = "AchievementGeneric2";

	public const string _PMIaFU7pgzDiSIeqsJeOfFhSiPI = "AchievementGeneric3";

	public const string _AKYwFx3D2lv2fP8RWjLBqTDM8TF = "AchievementGeneric4";

	public const string _0y4DgdoabgH5rTGDM3UY5Gcc0Uf = "AchievementGeneric5";

	public const string _0Pl3qCdgmZ6QXYAjw9wBgyI1UII = "AchievementGeneric6";

	public const string _iLwqFhDw3O1PLa7vhQ9YWLyObii = "AchievementGeneric7";

	public const string _rh6fSZZTx2NOMbWi1qy5spzBCbh = "AchievementGeneric8";

	public const string _xCIsWl4Kr0BAJdR8gDuFnEIALEO = "AchievementGeneric9";

	public const string _phtNQP6zcdMbTmRGiFNs0ZehoUL = "AchievementGeneric10";

	public const string _L5Ps4riQGZIOB3u0xDU3RUIbDTh = "AchievementGeneric11";

	private static readonly List<_eT2GJReQj8Acaq2A0H0eUir97Qf> _bUtL25YVF26t7moyja8EyHgA85q = new List<_eT2GJReQj8Acaq2A0H0eUir97Qf>
	{
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementPhonenumberCoby", "ACHIEVEMENT_PHONENUMBER_COBY", "Coby", "MessageIconCoby", _UARKn0z34q7eyfLAgMhaieKBn33.Contact),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementPhonenumberJax", "ACHIEVEMENT_PHONENUMBER_JAX", "Jax", "MessageIconJax", _UARKn0z34q7eyfLAgMhaieKBn33.Contact),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementPhonenumberSeth", "ACHIEVEMENT_PHONENUMBER_SETH", "Seth", "MessageIconSeth", _UARKn0z34q7eyfLAgMhaieKBn33.Contact),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementPhonenumberSkye", "ACHIEVEMENT_PHONENUMBER_SKYE", "Skye", "MessageIconSkye", _UARKn0z34q7eyfLAgMhaieKBn33.Contact),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementPhonenumberDustin", "ACHIEVEMENT_PHONENUMBER_DUSTIN", "Dustin", "MessageIconDustin", _UARKn0z34q7eyfLAgMhaieKBn33.Contact),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementPhonenumberZenith", "ACHIEVEMENT_PHONENUMBER_ZENITH", "Zenith", "MessageIconZenith", _UARKn0z34q7eyfLAgMhaieKBn33.Contact),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementPhonenumberMercy", "ACHIEVEMENT_PHONENUMBER_MERCY", "Mercy", "MessageIconMercy", _UARKn0z34q7eyfLAgMhaieKBn33.Contact),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementPhonenumberRemy", "ACHIEVEMENT_PHONENUMBER_REMY", "Remy", "MessageIconRemy", _UARKn0z34q7eyfLAgMhaieKBn33.Contact),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementPhonenumberLex", "ACHIEVEMENT_PHONENUMBER_LEX", "Lex", "MessageIconLex", _UARKn0z34q7eyfLAgMhaieKBn33.Contact),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementDate1Coby", "ACHIEVEMENT_DATE1_COBY", "Oh, Brother!", "MessageIconCoby"),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementDate1Jax", "ACHIEVEMENT_DATE1_JAX", "Testing the Waters", "MessageIconJax"),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementDate2Jax", "ACHIEVEMENT_DATE2_JAX", "Someone Likes You", "MessageIconJax"),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementDate3Jax", "ACHIEVEMENT_DATE3_JAX", "This is Love", "MessageIconJax"),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementDate1Seth", "ACHIEVEMENT_DATE1_SETH", "Testing the Waters", "MessageIconSeth"),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementDate2Seth", "ACHIEVEMENT_DATE2_SETH", "Someone Likes You", "MessageIconSeth"),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementDate3Seth", "ACHIEVEMENT_DATE3_SETH", "This is Love", "MessageIconSeth"),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementDate1Skye", "ACHIEVEMENT_DATE1_SKYE", "Testing the Waters", "MessageIconSkye"),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementDate2Skye", "ACHIEVEMENT_DATE2_SKYE", "Someone Likes You", "MessageIconSkye"),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementDate3Skye", "ACHIEVEMENT_DATE3_SKYE", "This is Love", "MessageIconSkye"),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementDate1Dustin", "ACHIEVEMENT_DATE1_DUSTIN", "Testing the Waters", "MessageIconDustin"),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementDate2Dustin", "ACHIEVEMENT_DATE2_DUSTIN", "Someone Likes You", "MessageIconDustin"),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementDate3Dustin", "ACHIEVEMENT_DATE3_DUSTIN", "This is Love", "MessageIconDustin"),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementDate1Zenith", "ACHIEVEMENT_DATE1_ZENITH", "Testing the Waters", "MessageIconZenith"),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementDate2Zenith", "ACHIEVEMENT_DATE2_ZENITH", "Someone Likes You", "MessageIconZenith"),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementDate3Zenith", "ACHIEVEMENT_DATE3_ZENITH", "This is Love", "MessageIconZenith"),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementDate1Mercy", "ACHIEVEMENT_DATE1_MERCY", "Testing the Waters", "MessageIconMercy"),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementDate2Mercy", "ACHIEVEMENT_DATE2_MERCY", "Someone Likes You", "MessageIconMercy"),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementDate3Mercy", "ACHIEVEMENT_DATE3_MERCY", "This is Love", "MessageIconMercy"),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementDate1Remy", "ACHIEVEMENT_DATE1_REMY", "Testing the Waters", "MessageIconRemy"),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementDate2Remy", "ACHIEVEMENT_DATE2_REMY", "Someone Likes You", "MessageIconRemy"),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementDate3Remy", "ACHIEVEMENT_DATE3_REMY", "This is Love", "MessageIconRemy"),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementDate1Lex", "ACHIEVEMENT_DATE1_LEX", "Testing the Waters", "MessageIconLex"),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementDate2Lex", "ACHIEVEMENT_DATE2_LEX", "Someone Likes You", "MessageIconLex"),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementDate3Lex", "ACHIEVEMENT_DATE3_LEX", "This is Love", "MessageIconLex"),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementGeneric1", "ACHIEVEMENT_GENERIC1", "Bells and Whistles"),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementGeneric2", "ACHIEVEMENT_GENERIC2", "Welcome to Amorous"),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementGeneric3", "ACHIEVEMENT_GENERIC3", "Hey Mr. D.J.", "MessageIconDJ"),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementGeneric4", "ACHIEVEMENT_GENERIC4", "Last Night a D.J.Saved My Life"),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementGeneric5", "ACHIEVEMENT_GENERIC5", "Ohh, what does THIS button do?"),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementGeneric6", "ACHIEVEMENT_GENERIC6", "Clothes Maketh Man"),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementGeneric7", "ACHIEVEMENT_GENERIC7", "Gunslinger", "MessageIconShootingRange"),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementGeneric8", "ACHIEVEMENT_GENERIC8", "Boom Headshot!", "MessageIconShootingRange"),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementGeneric9", "ACHIEVEMENT_GENERIC9", "Steady Aim", "MessageIconShootingRange"),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementGeneric10", "ACHIEVEMENT_GENERIC10", "Sleight of Hand", "MessageIconShootingRange"),
		new _eT2GJReQj8Acaq2A0H0eUir97Qf("AchievementGeneric11", "ACHIEVEMENT_GENERIC11", "Yes Chef!", "MessageIconCooking")
	};

	private static readonly Dictionary<string, _eT2GJReQj8Acaq2A0H0eUir97Qf> _f6JnaqJEhaBQyPQ8hoUgwIj9WcQ = _bUtL25YVF26t7moyja8EyHgA85q.ToDictionary((_eT2GJReQj8Acaq2A0H0eUir97Qf _eT2GJReQj8Acaq2A0H0eUir97Qf_0) => _eT2GJReQj8Acaq2A0H0eUir97Qf_0._qXE0hlPdNyl0lTUyddbAS1PZhVV, (_eT2GJReQj8Acaq2A0H0eUir97Qf _eT2GJReQj8Acaq2A0H0eUir97Qf_0) => _eT2GJReQj8Acaq2A0H0eUir97Qf_0);

	public const string _G2CT6QF50RIPQkOak7frGuTK7ru = "MessageTutorial1";

	private readonly IAmorous Amorous;

	private readonly _KDiaUloddpdv1QwixDEBIJs6IMA _p3BLtW5bCDzTS86VFihe1pfwDoP;

	public static List<_eT2GJReQj8Acaq2A0H0eUir97Qf> _cifgh151BUWCIJWJPcakKQ2lWGB => _bUtL25YVF26t7moyja8EyHgA85q;

	public bool _J5VHNpAqpO7aNRC9sbWCZTOF7XS => _p3BLtW5bCDzTS86VFihe1pfwDoP != null;

	public Achievements(IAmorous game, _KDiaUloddpdv1QwixDEBIJs6IMA _KDiaUloddpdv1QwixDEBIJs6IMA_0)
	{
		Amorous = game;
		_p3BLtW5bCDzTS86VFihe1pfwDoP = _KDiaUloddpdv1QwixDEBIJs6IMA_0;
	}

	public void _NtDfAf24kD2Korbc5hoME725A7d(string string_0, int int_0)
	{
		if (string_0 == "Clothes")
		{
			_vVZVLriSGPExpn1KeobglMabsoi("AchievementGeneric6");
		}
		else if (string_0 == "Prologue" && int_0 == 30)
		{
			_vVZVLriSGPExpn1KeobglMabsoi("AchievementGeneric4");
		}
		else if (string_0 == "CobyDate")
		{
			_vVZVLriSGPExpn1KeobglMabsoi("AchievementDate1Coby");
		}
		else if (string_0 == "DJ" && int_0 == 10)
		{
			_8DePzSVoGzWFpzrB1bmfWEjf0uy("Club Amorous DJ", "MessageIconDJ");
		}
	}

	public void SetDecimal(string string_0, int int_0)
	{
		if (string_0 == "JaxDate" && int_0 == 20)
		{
			_vVZVLriSGPExpn1KeobglMabsoi("AchievementDate1Jax");
		}
		else if (string_0 == "JaxDate" && int_0 == 30)
		{
			_vVZVLriSGPExpn1KeobglMabsoi("AchievementDate2Jax");
		}
		else if (string_0 == "JaxDate" && int_0 == 40)
		{
			_vVZVLriSGPExpn1KeobglMabsoi("AchievementDate3Jax");
		}
		else if (string_0 == "SethDate" && int_0 == 20)
		{
			_vVZVLriSGPExpn1KeobglMabsoi("AchievementDate1Seth");
		}
		else if (!(string_0 == "SethDate") || int_0 != 30)
		{
			if (string_0 == "SethDate" && int_0 == 40)
			{
				_vVZVLriSGPExpn1KeobglMabsoi("AchievementDate3Seth");
			}
			else if (string_0 == "SkyeDate" && int_0 == 40)
			{
				_vVZVLriSGPExpn1KeobglMabsoi("AchievementDate1Skye");
			}
			else if (string_0 == "SkyeDate" && int_0 == 50)
			{
				_vVZVLriSGPExpn1KeobglMabsoi("AchievementDate2Skye");
			}
			else if (string_0 == "SkyeDate" && int_0 == 60)
			{
				_vVZVLriSGPExpn1KeobglMabsoi("AchievementDate3Skye");
			}
			else if (string_0 == "DustinDate" && int_0 == 50)
			{
				_vVZVLriSGPExpn1KeobglMabsoi("AchievementDate1Dustin");
			}
			else if (string_0 == "DustinDate" && int_0 == 60)
			{
				_vVZVLriSGPExpn1KeobglMabsoi("AchievementDate2Dustin");
			}
			else if (!(string_0 == "DustinDate") || int_0 != 70)
			{
				if (!(string_0 == "ZenithDate") || int_0 != 30)
				{
					if (!(string_0 == "ZenithDate") || int_0 != 40)
					{
						if (string_0 == "ZenithDate" && int_0 == 60)
						{
							_vVZVLriSGPExpn1KeobglMabsoi("AchievementDate3Zenith");
						}
						else if (string_0 == "MercyDate" && int_0 == 30)
						{
							_vVZVLriSGPExpn1KeobglMabsoi("AchievementDate1Mercy");
						}
						else if (string_0 == "MercyDate" && int_0 == 40)
						{
							_vVZVLriSGPExpn1KeobglMabsoi("AchievementDate2Mercy");
						}
						else if (string_0 == "MercyDate" && int_0 == 60)
						{
							_vVZVLriSGPExpn1KeobglMabsoi("AchievementDate3Mercy");
						}
						else if (!(string_0 == "RemyDate") || int_0 != 20)
						{
							if (string_0 == "RemyDate" && int_0 == 30)
							{
								_vVZVLriSGPExpn1KeobglMabsoi("AchievementDate2Remy");
							}
							else if (string_0 == "RemyDate" && int_0 == 40)
							{
								_vVZVLriSGPExpn1KeobglMabsoi("AchievementDate3Remy");
							}
							else if (string_0 == "LexDate" && int_0 == 20)
							{
								_vVZVLriSGPExpn1KeobglMabsoi("AchievementDate1Lex");
							}
							else if (string_0 == "LexDate" && int_0 == 30)
							{
								_vVZVLriSGPExpn1KeobglMabsoi("AchievementDate2Lex");
							}
							else if (string_0 == "LexDate" && int_0 == 50)
							{
								_vVZVLriSGPExpn1KeobglMabsoi("AchievementDate3Lex");
							}
						}
						else
						{
							_vVZVLriSGPExpn1KeobglMabsoi("AchievementDate1Remy");
						}
					}
					else
					{
						_vVZVLriSGPExpn1KeobglMabsoi("AchievementDate2Zenith");
					}
				}
				else
				{
					_vVZVLriSGPExpn1KeobglMabsoi("AchievementDate1Zenith");
				}
			}
			else
			{
				_vVZVLriSGPExpn1KeobglMabsoi("AchievementDate3Dustin");
			}
		}
		else
		{
			_vVZVLriSGPExpn1KeobglMabsoi("AchievementDate2Seth");
		}
	}

	public void SetBit(string string_0, bool bool_0)
	{
	}

	public void _rGMDL1kMYXSwaZiIoINCo5AqZuM(PlayerData.EPhoneContacts ephoneContacts_0)
	{
		switch (ephoneContacts_0)
		{
		case PlayerData.EPhoneContacts.Skye:
			_vVZVLriSGPExpn1KeobglMabsoi("AchievementPhonenumberSkye");
			break;
		case PlayerData.EPhoneContacts.Dustin:
			_vVZVLriSGPExpn1KeobglMabsoi("AchievementPhonenumberDustin");
			break;
		case PlayerData.EPhoneContacts.Coby:
			_vVZVLriSGPExpn1KeobglMabsoi("AchievementPhonenumberCoby");
			break;
		case PlayerData.EPhoneContacts.Jax:
			_vVZVLriSGPExpn1KeobglMabsoi("AchievementPhonenumberJax");
			break;
		case PlayerData.EPhoneContacts.Seth:
			_vVZVLriSGPExpn1KeobglMabsoi("AchievementPhonenumberSeth");
			break;
		case PlayerData.EPhoneContacts.Zenith:
			_vVZVLriSGPExpn1KeobglMabsoi("AchievementPhonenumberZenith");
			break;
		case PlayerData.EPhoneContacts.Mercy:
			_vVZVLriSGPExpn1KeobglMabsoi("AchievementPhonenumberMercy");
			break;
		case PlayerData.EPhoneContacts.Remy:
			_vVZVLriSGPExpn1KeobglMabsoi("AchievementPhonenumberRemy");
			break;
		case PlayerData.EPhoneContacts.Lex:
			_vVZVLriSGPExpn1KeobglMabsoi("AchievementPhonenumberLex");
			break;
		}
	}

	public void _vVZVLriSGPExpn1KeobglMabsoi(string string_0)
	{
		PlayerData opIJo2jLUqdOL5yAFP4yzXce0DG = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
		if (opIJo2jLUqdOL5yAFP4yzXce0DG.GetBit(string_0))
		{
			return;
		}
		opIJo2jLUqdOL5yAFP4yzXce0DG.SetBit(string_0, bool_0: true);
		if (_f6JnaqJEhaBQyPQ8hoUgwIj9WcQ.TryGetValue(string_0, out var value))
		{
			if (_p3BLtW5bCDzTS86VFihe1pfwDoP != null)
			{
				_p3BLtW5bCDzTS86VFihe1pfwDoP._vVZVLriSGPExpn1KeobglMabsoi(value._OEBUKIcFNUq5lvHUCwgeAJT3Orq);
			}
			if (value._hEIssNuRoEdRDJFan5fSkzWu4Kj != _UARKn0z34q7eyfLAgMhaieKBn33.Contact)
			{
				_A3aw0JDUC0JuHjJDLBjCNpAj01Q(value.Title, value.Icon);
			}
			else
			{
				_8DePzSVoGzWFpzrB1bmfWEjf0uy(value.Title, value.Icon);
			}
		}
	}

	private void _A3aw0JDUC0JuHjJDLBjCNpAj01Q(string string_0, string string_1)
	{
		Amorous._EXfoFnp1OKxeZbd4GcVZMCO2urH(string_1, "Achievement", "Congratulations, you've unlocked the '" + string_0 + "'-achievement!");
	}

	private void _8DePzSVoGzWFpzrB1bmfWEjf0uy(string string_0, string string_1)
	{
		Amorous._EXfoFnp1OKxeZbd4GcVZMCO2urH(string_1, "Contact", "The phonenumber of " + string_0 + " has been added to your contacts!");
	}

	public void _0Y1BTbSbP9IopfJXfeA4x02PifL(string string_0)
	{
		PlayerData opIJo2jLUqdOL5yAFP4yzXce0DG = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
		if (!opIJo2jLUqdOL5yAFP4yzXce0DG.GetBit(string_0))
		{
			opIJo2jLUqdOL5yAFP4yzXce0DG.SetBit(string_0, bool_0: true);
			if (string_0 == "MessageTutorial1")
			{
				Amorous._EXfoFnp1OKxeZbd4GcVZMCO2urH("MessageIconGeneric", "Tutorial", "You've finished the prologue and went home. Your phone is your most important asset. Open it by pressing SHIFT!");
			}
		}
	}

	public void _3xUr1Yv0PbZlcGdOrfbCAwOXa5c()
	{
		if (_p3BLtW5bCDzTS86VFihe1pfwDoP != null)
		{
			_p3BLtW5bCDzTS86VFihe1pfwDoP._jUIwOLgbKJ8tJmUAAQs6pm6ZGWb();
		}
	}
}
