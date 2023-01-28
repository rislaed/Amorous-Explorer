using System;
using System.Collections.Generic;
using System.Linq;
using Amorous.Engine.GUI;
using Amorous.Game.NPC;
using Amorous.Game.Scenes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Spine;
using Squid;

public class PhoneOverlay
{
	public enum PhonePhase
	{
		ArmDown,
		ArmUp,
		ArmDownRequested,
		ArmUpRequested
	}

	public enum PhoneScreen
	{
		Home,
		Contacts,
		ContactsInformation,
		ContactsInformationDJ,
		Soundtrack,
		Diary,
		DiaryMessages,
		DiaryMessagesInformation,
		DiaryAchievements,
		DiarySave,
		DiaryLoad,
		Audio,
		ChatSettings,
		Gallery,
		Power
	}

	public enum PhoneIndication
	{
		None,
		NoMessage,
		MessageNew,
		MessageIdle,
		MessageUrgent
	}

	private bool _0IwNM2MxOUN4RsEqXREAdDRe4Ad;
	private bool _77rSPCEs6VEYjlGrwW0KN0btLEG;

	private readonly Dictionary<PlayerData.EPhoneContacts, Squid.Rectangle> _kALYOlSwbvFyd9uFqFZW8Y2IsnL = new Dictionary<PlayerData.EPhoneContacts, Squid.Rectangle>
	{
		{
			PlayerData.EPhoneContacts.Coby,
			new Squid.Rectangle(275, 189, 268, 158)
		},
		{
			PlayerData.EPhoneContacts.Dustin,
			new Squid.Rectangle(547, 351, 268, 158)
		},
		{
			PlayerData.EPhoneContacts.Jax,
			new Squid.Rectangle(819, 189, 268, 158)
		},
		{
			PlayerData.EPhoneContacts.Lex,
			new Squid.Rectangle(275, 351, 268, 158)
		},
		{
			PlayerData.EPhoneContacts.Mercy,
			new Squid.Rectangle(1091, 351, 268, 158)
		},
		{
			PlayerData.EPhoneContacts.Remy,
			new Squid.Rectangle(1091, 189, 268, 158)
		},
		{
			PlayerData.EPhoneContacts.Seth,
			new Squid.Rectangle(1363, 351, 268, 158)
		},
		{
			PlayerData.EPhoneContacts.Skye,
			new Squid.Rectangle(1363, 189, 268, 158)
		},
		{
			PlayerData.EPhoneContacts.Zenith,
			new Squid.Rectangle(1635, 189, 268, 158)
		}
	};

	private readonly Dictionary<PlayerData.EPhoneContacts, string> _iVvswmrDLetaWXmgd38sJtDnLs = new Dictionary<PlayerData.EPhoneContacts, string>
	{
		{
			PlayerData.EPhoneContacts.Coby,
			"CobySexscene"
		},
		{
			PlayerData.EPhoneContacts.Dustin,
			"DustinSexscene"
		},
		{
			PlayerData.EPhoneContacts.Jax,
			"JaxSexscene"
		},
		{
			PlayerData.EPhoneContacts.Lex,
			"LexSexscene"
		},
		{
			PlayerData.EPhoneContacts.Mercy,
			"MercySexscene"
		},
		{
			PlayerData.EPhoneContacts.Remy,
			"RemySexscene"
		},
		{
			PlayerData.EPhoneContacts.Seth,
			"SethSexscene"
		},
		{
			PlayerData.EPhoneContacts.Skye,
			"SkyeSexscene"
		},
		{
			PlayerData.EPhoneContacts.Zenith,
			"ZenithSexscene"
		}
	};

	private PlayerData.EPhoneContacts _selectedContact;
	private PhoneMessage _selectedMessage;
	private readonly string[] _djCommentaries = new string[5] { "That song is awesome!", "This one is so underrated!", "Haven't heard that one in a while!", "Always gives me goosebumbs!", "The beat in this one is just amazing!" };
	private static PhoneOverlay _singleton;
	private readonly IAmorous _game;
	private readonly SpineRenderer _hrw3Kf8fCx7saJOmoYUD8sIz3uD;
	private readonly SpineRenderer _lpMGMQZJYmHr6q9XBRwiM0Lse4N;
	private readonly SpineRenderer _wTbB4YBL4PSkaotwKX3CFc50DmX;

	private readonly Dictionary<string, bool> _PcaKA8lfkZnYKjOTdM7RWYPBlGr = new Dictionary<string, bool>
	{
		{ "Alex", false },
		{ "Alex image", false },
		{ "Coby", false },
		{ "Coby image", false },
		{ "Dustin", false },
		{ "Dustin image", false },
		{ "Gen", false },
		{ "Gen image", false },
		{ "Jacky", false },
		{ "Jacky image", false },
		{ "Jax", false },
		{ "Jax image", false },
		{ "Mercy", false },
		{ "Mercy image", false },
		{ "Remy", false },
		{ "Remy image", false },
		{ "Seth", false },
		{ "Seth image", false },
		{ "Skye", false },
		{ "Skye image", false },
		{ "Verge", false },
		{ "Verge image", false },
		{ "Zenith", false },
		{ "Zenith image", false }
	};

	private readonly Dictionary<string, bool> _0OvMkQYTGPrNhckv6iHt3zmR5ni = new Dictionary<string, bool>
	{
		{ "reject call with message", true },
		{ "Incoming call", true }
	};

	private PhoneIndication _indication;
	private bool _TZx1AkahTLXoM2XUbm5U8YJOScb;
	private bool _WaCCr2ToiTDglrrE9z1EKOcLzT3;
	private bool _p4cbe03cXPNybrHUo9DHRTp6W7m;

	private static readonly string[] _MCqah9fRROAHE2fkIv4nkhrpDKX = new string[6] { "Marlboro", "Angry Curds", "God of Warfare Modern War", "Inanimate 3", "The Blinding of Blissac", "Traffic Controller" };
	private static readonly string[] _I35ziY7HYJkfL20RDXWOC7Pcv1q = new string[4] { "Nude1", "Nude2", "Nude3", "Nude4" };
	private static readonly string[] _HzpuNgBJAQYObWMhiboQRiPGmvp = new string[4] { "Pinky Nail", "Ring Nail", "Rude Nail", "Index Nail" };

	private readonly Desktop _squid;
	private readonly RenderTarget2D _bZJtpWV2Yj6GgZkeZQUmpTHxTnh;
	private readonly RenderTarget2D _Pfaq6ajchxcqF6GecivHvHqQW6M;
	private Texture2D _Et7ViKuaneif1JVK3bifonUhKPR;
	private Texture2D _BphDC8XZceMl5rqVm5zdrD6meOf;
	private bool _blocked;
	private bool _Ldzm1JY9st4tknAhrglOIpwdYhn;
	private bool _rASuGHWSFVWfkpwzF8wZd9bh3XN;
	private bool _1gXQH16lmsacxQMOpjFFqZSmjQl;
	private bool _97m6gVcwgWbLFyNUxI3P1KuD0Gn;
	private int _WLqMMhDU6lDWhPjohexo40VadrB;
	private int _j2EdRylzMDum240gfhMGkyqki8j;
	private static PhoneScreen _screen;
	private static Stack<PhoneScreen> _screenHistory;
	private static bool _kodtINvkfS2a7kqthXOxN1a4Rth;

	private const float RiseDownDuration = 1000f;
	private const float RiseUpDuration = 5000f;

	private bool _flEA1zdf7DHRkPwzrlsWVEAXZiX;
	private float _duration = 1f;
	private bool _tIOoXRaaichIzSVUOs5dNLciPbw;

	public PhonePhase Phase { get; private set; }

	public static bool _kf3EbE0B70xGe1szklqAZyCqoLj
	{
		get
		{
			return _kodtINvkfS2a7kqthXOxN1a4Rth;
		}
		set
		{
			_kodtINvkfS2a7kqthXOxN1a4Rth = value;
			if (!_kodtINvkfS2a7kqthXOxN1a4Rth)
			{
				Indication = PhoneIndication.None;
			}
			else
			{
				Indication = PhoneIndication.NoMessage;
			}
		}
	}

	public static PhoneIndication Indication
	{
		get
		{
			return _singleton._indication;
		}
		set
		{
			if (value != _singleton._indication)
			{
				_singleton._indication = value;
				switch (value)
				{
					case PhoneIndication.NoMessage:
						_singleton._lpMGMQZJYmHr6q9XBRwiM0Lse4N.StartAnimationWithLooping("No message");
						_singleton._IiWYS6YP6cEj83PIAXepbAHBaJB();
						break;
					case PhoneIndication.MessageNew:
						_singleton._lpMGMQZJYmHr6q9XBRwiM0Lse4N.StartAnimationWithLooping("Message new");
						break;
					case PhoneIndication.MessageIdle:
						_singleton._lpMGMQZJYmHr6q9XBRwiM0Lse4N.StartAnimationWithLooping("Message idle");
						break;
					case PhoneIndication.MessageUrgent:
						_singleton._lpMGMQZJYmHr6q9XBRwiM0Lse4N.StartAnimationWithLooping("Urgent message");
						break;
				}
			}
		}
	}

	public void _74zyK2mDlnXqbPqFXMVn07h7ifH(PlayerData.EPhoneContacts ephoneContacts_0)
	{
		_3mKo17hkpGwyDp6sHVZAhV1c6Qv(ephoneContacts_0);
		_wTbB4YBL4PSkaotwKX3CFc50DmX.RestartAnimation();
		_wTbB4YBL4PSkaotwKX3CFc50DmX.StartAnimation("Phone answer start", delegate
		{
			_wTbB4YBL4PSkaotwKX3CFc50DmX.StartAnimationWithLooping("Phone answer loop");
		});
		_Pbt0pgZ2cGZkaxR9cQe0r2v2lVd();
	}

	public void _N6rbbp9vfBTLIy29VRlaxyb7udeA(PlayerData.EPhoneContacts ephoneContacts_0)
	{
		_3mKo17hkpGwyDp6sHVZAhV1c6Qv(ephoneContacts_0);
		_wTbB4YBL4PSkaotwKX3CFc50DmX.StartAnimation("Phone IM accept", delegate
		{
			_wTbB4YBL4PSkaotwKX3CFc50DmX.StartAnimationWithLooping("Phone IM idle");
		});
		_Pbt0pgZ2cGZkaxR9cQe0r2v2lVd();
	}

	public void _IiIBp9h21zmpuvGulVNz008r8TA(PlayerData.EPhoneContacts ephoneContacts_0)
	{
		_rASuGHWSFVWfkpwzF8wZd9bh3XN = true;
		_Pbt0pgZ2cGZkaxR9cQe0r2v2lVd();
	}

	public void _yIdbijdoIArgGYmQaSg2XCsw9hT(PlayerData.EPhoneContacts ephoneContacts_0)
	{
		_rASuGHWSFVWfkpwzF8wZd9bh3XN = true;
		_Pbt0pgZ2cGZkaxR9cQe0r2v2lVd();
	}

	public void _zm6vAchd6YcmYOAA7H1gpRDyQ3f(PlayerData.EPhoneContacts ephoneContacts_0)
	{
		_3mKo17hkpGwyDp6sHVZAhV1c6Qv(ephoneContacts_0);
		_8hw6Dkw1FlTEpsiy0adBUXTGpRe(bool_0: true);
		_wTbB4YBL4PSkaotwKX3CFc50DmX.RestartAnimation();
		_wTbB4YBL4PSkaotwKX3CFc50DmX.StartAnimation("Phone Call start", delegate
		{
			_wTbB4YBL4PSkaotwKX3CFc50DmX.StartAnimationWithLooping("Phone Call loop");
		});
		_Pbt0pgZ2cGZkaxR9cQe0r2v2lVd();
	}

	public void _lMCk2LRgUr0BxjjkcGh4aHIw2kf(PlayerData.EPhoneContacts ephoneContacts_0)
	{
		_znPUoLNKAYlonsIsyRDTBqJ16RE(ephoneContacts_0);
	}

	public void _RKOSDyYel4mDgA7CBL7icGDh8NX(PlayerData.EPhoneContacts ephoneContacts_0)
	{
		_3mKo17hkpGwyDp6sHVZAhV1c6Qv(ephoneContacts_0);
		_wTbB4YBL4PSkaotwKX3CFc50DmX.StartAnimationWithLooping("Phone IM idle");
		_Pbt0pgZ2cGZkaxR9cQe0r2v2lVd();
	}

	public void _7A7AnrbJWOfnmm4PGqh14Sic88K(PlayerData.EPhoneContacts ephoneContacts_0)
	{
		_znPUoLNKAYlonsIsyRDTBqJ16RE(ephoneContacts_0);
	}

	public void _VIPhK0wyQYrQ8PUpr3jagtYPv9j(PlayerData.EPhoneContacts ephoneContacts_0)
	{
		_znPUoLNKAYlonsIsyRDTBqJ16RE(ephoneContacts_0);
	}

	public void _d77xq6Q69C4sosexup4aU79nRCI(PlayerData.EPhoneContacts ephoneContacts_0)
	{
		_3mKo17hkpGwyDp6sHVZAhV1c6Qv(ephoneContacts_0);
		_wTbB4YBL4PSkaotwKX3CFc50DmX.StartAnimation("Phone IM messaging loop", delegate
		{
			_wTbB4YBL4PSkaotwKX3CFc50DmX.StartAnimationWithLooping("Phone IM idle");
		});
		_iclFNsZuDOZLCNYXakYmA0rt3UU();
	}

	private void _znPUoLNKAYlonsIsyRDTBqJ16RE(PlayerData.EPhoneContacts ephoneContacts_0)
	{
		_3mKo17hkpGwyDp6sHVZAhV1c6Qv(ephoneContacts_0);
		_8hw6Dkw1FlTEpsiy0adBUXTGpRe(bool_0: false);
		_wTbB4YBL4PSkaotwKX3CFc50DmX.RestartAnimation();
		_wTbB4YBL4PSkaotwKX3CFc50DmX.StartAnimation("Phone Call start", delegate
		{
			_wTbB4YBL4PSkaotwKX3CFc50DmX.StartAnimationWithLooping("Phone Call loop");
		});
		_Pbt0pgZ2cGZkaxR9cQe0r2v2lVd();
	}

	public void _2q4ULWZHQg4Aboj4mYnu05b6gpq()
	{
		_1gXQH16lmsacxQMOpjFFqZSmjQl = false;
		_Et7ViKuaneif1JVK3bifonUhKPR = _game.Content.Load<Texture2D>("Assets/GUI/Phone/Gameboxes/" + _MCqah9fRROAHE2fkIv4nkhrpDKX[_WLqMMhDU6lDWhPjohexo40VadrB]);
		_WLqMMhDU6lDWhPjohexo40VadrB++;
		if (_WLqMMhDU6lDWhPjohexo40VadrB >= _MCqah9fRROAHE2fkIv4nkhrpDKX.Length)
		{
			_WLqMMhDU6lDWhPjohexo40VadrB = 0;
		}
	}

	public void _TfR4rAxaOpP26NUkiRO1hT0Q3Ib()
	{
		_1gXQH16lmsacxQMOpjFFqZSmjQl = true;
		_WLqMMhDU6lDWhPjohexo40VadrB = 0;
	}

	public void _f2CdPIvAGYavrZlA3VXyxB0B8Jh()
	{
		_97m6gVcwgWbLFyNUxI3P1KuD0Gn = false;
		_BphDC8XZceMl5rqVm5zdrD6meOf = _game.Content.Load<Texture2D>("Assets/GUI/Phone/Gallery/Remy/" + _I35ziY7HYJkfL20RDXWOC7Pcv1q[_j2EdRylzMDum240gfhMGkyqki8j]);
		_j2EdRylzMDum240gfhMGkyqki8j++;
		if (_j2EdRylzMDum240gfhMGkyqki8j >= _I35ziY7HYJkfL20RDXWOC7Pcv1q.Length)
		{
			_j2EdRylzMDum240gfhMGkyqki8j = 0;
		}
		_Pbt0pgZ2cGZkaxR9cQe0r2v2lVd();
	}

	public void _f2CdPIvAGYavrZlA3VXyxB0B8Jh(int int_0)
	{
		_97m6gVcwgWbLFyNUxI3P1KuD0Gn = false;
		_BphDC8XZceMl5rqVm5zdrD6meOf = _game.Content.Load<Texture2D>("Assets/GUI/Phone/Gallery/Remy/" + _I35ziY7HYJkfL20RDXWOC7Pcv1q[int_0]);
		_Pbt0pgZ2cGZkaxR9cQe0r2v2lVd();
	}

	public void _zFlBtKgcAb6cv77WHC6dI3lO8EwA()
	{
		_97m6gVcwgWbLFyNUxI3P1KuD0Gn = true;
		_j2EdRylzMDum240gfhMGkyqki8j = 0;
		_Pbt0pgZ2cGZkaxR9cQe0r2v2lVd();
	}

	public void _l78cdi393ZI3QSrFwNTTIJoYKGQ()
	{
		_rASuGHWSFVWfkpwzF8wZd9bh3XN = true;
	}

	public void ResetProgression()
	{
		_rASuGHWSFVWfkpwzF8wZd9bh3XN = true;
		_1gXQH16lmsacxQMOpjFFqZSmjQl = true;
		_WLqMMhDU6lDWhPjohexo40VadrB = 0;
		_97m6gVcwgWbLFyNUxI3P1KuD0Gn = true;
		_j2EdRylzMDum240gfhMGkyqki8j = 0;
	}

	public static void Rise()
	{
		if (_singleton._game.Cutscene == null && !_singleton._TZx1AkahTLXoM2XUbm5U8YJOScb)
		{
			if (_singleton.Phase == PhonePhase.ArmUp)
			{
				Hide();
			}
			else
			{
				Show();
			}
		}
	}

	public static void Show(bool preserveHiding = false)
	{
		if (_kf3EbE0B70xGe1szklqAZyCqoLj)
		{
			if (!_singleton._0IwNM2MxOUN4RsEqXREAdDRe4Ad)
			{
				_singleton._0IwNM2MxOUN4RsEqXREAdDRe4Ad = true;
				_singleton._game.Achievements.GainAchievement(Achievements.AchievementGeneric5);
			}
			_singleton._game.Mouse.Captured = true;
			AbstractScene.CapturedByOverlay = true;
			_singleton._blocked = preserveHiding;
			if (!_singleton._TZx1AkahTLXoM2XUbm5U8YJOScb && _singleton.Phase == PhonePhase.ArmDown)
			{
				_singleton.Phase = PhonePhase.ArmUpRequested;
				_singleton._WaCCr2ToiTDglrrE9z1EKOcLzT3 = true;
				_screenHistory.Clear();
				_eprNswcjHxcASaMkeDGEbGomDNI(PhoneScreen.Home);
			}
		}
	}

	public static void Hide()
	{
		if (_kf3EbE0B70xGe1szklqAZyCqoLj && !_singleton._77rSPCEs6VEYjlGrwW0KN0btLEG)
		{
			_singleton._game.Mouse.Captured = false;
			AbstractScene.CapturedByOverlay = false;
			_singleton._blocked = false;
			if (!_singleton._TZx1AkahTLXoM2XUbm5U8YJOScb && _singleton.Phase == PhonePhase.ArmUp)
			{
				_singleton.Phase = PhonePhase.ArmDownRequested;
				_singleton._p4cbe03cXPNybrHUo9DHRTp6W7m = true;
			}
		}
	}

	public static void _eprNswcjHxcASaMkeDGEbGomDNI(PhoneScreen _VQgRlkt1vazuo2KaxFIrSVwZOpL_0)
	{
		if (_VQgRlkt1vazuo2KaxFIrSVwZOpL_0 != 0)
		{
			_screenHistory.Push(_screen);
			_singleton._Pbt0pgZ2cGZkaxR9cQe0r2v2lVd();
		}
		_screen = _VQgRlkt1vazuo2KaxFIrSVwZOpL_0;
		_singleton._DAsCL6JdGst3kJHpcbztigO3VEV();
	}

	public static void _8B2OIJu0L2rpVtls8vq2qHBX2OB(PhoneScreen _VQgRlkt1vazuo2KaxFIrSVwZOpL_0)
	{
		_singleton._Pbt0pgZ2cGZkaxR9cQe0r2v2lVd();
		_singleton._DAsCL6JdGst3kJHpcbztigO3VEV();
	}

	public static void _270ZVixWLhgEiLA6QosapJMyU6h()
	{
		_screen = _screenHistory.Pop();
		_singleton._DAsCL6JdGst3kJHpcbztigO3VEV();
		_singleton._Pbt0pgZ2cGZkaxR9cQe0r2v2lVd();
	}

	private void _Pbt0pgZ2cGZkaxR9cQe0r2v2lVd()
	{
		_flEA1zdf7DHRkPwzrlsWVEAXZiX = false;
		_singleton._hrw3Kf8fCx7saJOmoYUD8sIz3uD.StartAnimation("Swipe", _aEgXugtdIuFieAwnDhnIlYNEysg);
	}

	private void _iclFNsZuDOZLCNYXakYmA0rt3UU()
	{
		_flEA1zdf7DHRkPwzrlsWVEAXZiX = false;
		_singleton._hrw3Kf8fCx7saJOmoYUD8sIz3uD.StartAnimation("Typing", _aEgXugtdIuFieAwnDhnIlYNEysg);
	}

	private void _aEgXugtdIuFieAwnDhnIlYNEysg()
	{
		_singleton._hrw3Kf8fCx7saJOmoYUD8sIz3uD.StartAnimationWithLooping("Idle");
		_flEA1zdf7DHRkPwzrlsWVEAXZiX = true;
	}

	private void _DAsCL6JdGst3kJHpcbztigO3VEV()
	{
		Control item;
		switch (_screen)
		{
			default:
				_Ldzm1JY9st4tknAhrglOIpwdYhn = true;
				return;
			case PhoneScreen.Contacts:
				item = _NWt4WEiiiqjMHAUuqWscxChtSMd();
				break;
			case PhoneScreen.ContactsInformation:
				item = _kcNoqTwN559GGLalkuw5udBAUZB();
				break;
			case PhoneScreen.ContactsInformationDJ:
				item = _h2ArPDECvhhh0z0Z51CaUxB7rAr();
				break;
			case PhoneScreen.Soundtrack:
				item = _hiWNprom67B9EJO4loqBfhvB4hX();
				break;
			case PhoneScreen.Diary:
				item = _YGPgft9Vo9UMBMfVtN34XoT93HD();
				break;
			case PhoneScreen.DiaryMessages:
				item = _ZAzvI9G8CsjLJ0AWtoSCmHUuR2q();
				break;
			case PhoneScreen.DiaryMessagesInformation:
				item = _yE1MXqtEKITxyL75pITcd8fNpsi();
				break;
			case PhoneScreen.DiaryAchievements:
				item = _jv6KLyNe1t3TATNww1TiWv9ZVLF();
				break;
			case PhoneScreen.DiarySave:
				item = _QmCbnBf76ITvR2HA7WYF44qkJWK();
				break;
			case PhoneScreen.DiaryLoad:
				item = _mKzC4RKCG3B1ZBdWwcAp79gd8NaA();
				break;
			case PhoneScreen.Audio:
				item = _fM96M1a1ZZUtzPyevCm45mKPeQg();
				break;
			case PhoneScreen.ChatSettings:
				item = _H2blb6Djx9JemSUBYepwlzNOXxz();
				break;
			case PhoneScreen.Gallery:
				item = _1Bze6b62yGQDi3JBE0TyQmPGkzU();
				break;
			case PhoneScreen.Power:
				item = _dT5L6g1CEsgeYg5W9sVqR2trRSK();
				break;
		}
		_Ldzm1JY9st4tknAhrglOIpwdYhn = false;
		_squid.Controls.Clear();
		_squid.Controls.Add(item);
	}

	private ListBox _Y29nu3VoVEY6acDadsfRh60BNDh()
	{
		ListBox listBox = new ListBox();
		listBox.Dock = DockStyle.Fill;
		listBox.Scrollbar.MouseScrollSpeed = 0.2f;
		listBox.Scrollbar.ButtonUp.Visible = false;
		listBox.Scrollbar.ButtonDown.Visible = false;
		return listBox;
	}

	private ListBox _NWt4WEiiiqjMHAUuqWscxChtSMd()
	{
		ListBox listBox = _Y29nu3VoVEY6acDadsfRh60BNDh();
		PlayerData _7FpdmRzPrcoARiGqtJekOfu7KqP = PlayerPreferences.GetPlayerData();
		if (_7FpdmRzPrcoARiGqtJekOfu7KqP.GetDecimal("DJ") == 20)
		{
			float num = 189.6f;
			float num2 = (268f - num) / 2f;
			ImageControl item = new ImageControl
			{
				Dock = DockStyle.Left,
				Texture = "Contact_DJ",
				TextureRect = new Squid.Rectangle((int)num2, 0, (int)num, 158),
				Size = new Squid.Point(60, 50),
				NoEvents = true
			};
			Label item2 = new Label
			{
				Dock = DockStyle.Fill,
				Text = "Club Amorous DJ",
				TextAlign = Alignment.MiddleCenter,
				NoEvents = true
			};
			CustomListBoxItem customListBoxItem = new CustomListBoxItem
			{
				Size = new Squid.Point(0, 60),
				Padding = new Margin(2)
			};
			customListBoxItem.MouseClick += delegate
			{
				_eprNswcjHxcASaMkeDGEbGomDNI(PhoneScreen.ContactsInformationDJ);
			};
			customListBoxItem.Controls.Add(item);
			customListBoxItem.Controls.Add(item2);
			listBox.ItemContainer.Controls.Add(customListBoxItem);
		}
		List<string> source = Enum.GetNames(typeof(PlayerData.EPhoneContacts)).Except(new string[1] { "None" }).ToList();
		PlayerData.EPhoneContacts result;
		Tuple<string, PlayerData.EPhoneContacts>[] array = (from string_0 in source
			select Enum.TryParse<PlayerData.EPhoneContacts>(string_0, out result) ? (
				(!_7FpdmRzPrcoARiGqtJekOfu7KqP.Contacts.HasFlag(result)) ? null : new Tuple<string, PlayerData.EPhoneContacts>(string_0, result)
			) : null into _6OmCduUGKgPqhBnqgfNJUOmDpZW_0
			where _6OmCduUGKgPqhBnqgfNJUOmDpZW_0 != null
			orderby _6OmCduUGKgPqhBnqgfNJUOmDpZW_0.Item1
			select _6OmCduUGKgPqhBnqgfNJUOmDpZW_0).ToArray();
		foreach (Tuple<string, PlayerData.EPhoneContacts> contact in array)
		{
			Squid.Rectangle rectangle = _kALYOlSwbvFyd9uFqFZW8Y2IsnL[contact.Item2];
			float num3 = 1.2f;
			float num4 = (float)rectangle.Height * num3;
			float num5 = ((float)rectangle.Width - num4) / 2f;
			ImageControl item3 = new ImageControl
			{
				Dock = DockStyle.Left,
				Texture = "PhoneScreen",
				TextureRect = new Squid.Rectangle(rectangle.Left + (int)num5, rectangle.Top, (int)num4, rectangle.Height),
				Size = new Squid.Point(60, 50),
				NoEvents = true
			};
			Label item4 = new Label
			{
				Dock = DockStyle.Fill,
				Text = contact.Item1,
				TextAlign = Alignment.MiddleCenter,
				NoEvents = true
			};
			CustomListBoxItem customListBoxItem = new CustomListBoxItem
			{
				Size = new Squid.Point(0, 60),
				Padding = new Margin(2),
				Value = contact.Item2
			};
			customListBoxItem.MouseClick += delegate
			{
				_selectedContact = (PlayerData.EPhoneContacts)customListBoxItem.Value;
				_eprNswcjHxcASaMkeDGEbGomDNI(PhoneScreen.ContactsInformation);
			};
			customListBoxItem.Controls.Add(item3);
			customListBoxItem.Controls.Add(item4);
			listBox.ItemContainer.Controls.Add(customListBoxItem);
		}
		return listBox;
	}

	private Control _kcNoqTwN559GGLalkuw5udBAUZB()
	{
		Panel panel = new Panel
		{
			Dock = DockStyle.Fill
		};
		PlayerData data = PlayerPreferences.GetPlayerData();
		Label item = new Label
		{
			Dock = DockStyle.Top,
			Text = _selectedContact.ToString(),
			Style = "button",
			Size = new Squid.Point(0, 40),
			NoEvents = true
		};
		ImageControl item2 = new CustomImageControl
		{
			Dock = DockStyle.Top,
			Texture = "PhoneScreen",
			TextureRect = _kALYOlSwbvFyd9uFqFZW8Y2IsnL[_selectedContact]
		};
		panel.Content.Controls.Add(item);
		panel.Content.Controls.Add(item2);
		Button button = new Button
		{
			Dock = DockStyle.Top,
			Text = "Delete contact",
			Size = new Squid.Point(0, 50)
		};
		button.MouseClick += delegate
		{
			_blocked = true;
			_squid.ShowSelection($"Are you sure you wish to remove {_selectedContact}? This will reset all progression!", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, 250, delegate(int int_0)
			{
				if (int_0 == 1)
				{
					PlayerPreferences.GetPlayerData().ResetContact(_selectedContact);
					_squid.ShowConfirm($"{_selectedContact} will be available again after you went home.", 250, "OK", delegate
					{
						_270ZVixWLhgEiLA6QosapJMyU6h();
						_blocked = false;
					});
				}
				else
				{
					_270ZVixWLhgEiLA6QosapJMyU6h();
					_blocked = false;
				}
			});
		};
		panel.Content.Controls.Add(button);
		Button button2 = new Button
		{
			Dock = DockStyle.Top,
			Text = "Call",
			Size = new Squid.Point(0, 50)
		};
		button2.MouseClick += delegate
		{
			string name = _game.Scene.GetType().Name;
			string text = _game.Sexscene?.GetType().Name;
			if (name == "PlayerSexScene" && text == _iVvswmrDLetaWXmgd38sJtDnLs[_selectedContact])
			{
				TypingDialogue._zunSyHn4DekdA6CngP10dXcR1kq("<i>" + _selectedContact.ToString() + " is kind of... preoccupied right now.</i>", "%playername%", Color.White);
			}
			else if (name != "BedroomScene" && name != "LivingRoomScene")
			{
				TypingDialogue._zunSyHn4DekdA6CngP10dXcR1kq("<i>Reception is really bad at the moment, I should try again when I'm back at home.</i>", "%playername%", Color.White);
			}
			else
			{
				_WDhVhBhQHGowaONqV87v7EaCvro(_selectedContact);
			}
		};
		panel.Content.Controls.Add(button2);
		if (_selectedContact == PlayerData.EPhoneContacts.Zenith && data.GetDecimal("ZenithDate") > 20)
		{
			Button button3 = new Button
			{
				Dock = DockStyle.Top,
				Text = "Extra: Shooting Range",
				Size = new Squid.Point(0, 50)
			};
			button3.MouseClick += delegate
			{
				Hide();
				_game.StartScene<PhoneShootingRangeMiniGameScene>();
			};
			panel.Content.Controls.Add(button3);
		}
		if (_selectedContact == PlayerData.EPhoneContacts.Remy && data.GetDecimal("RemyDate") > 20)
		{
			Button button4 = new Button
			{
				Dock = DockStyle.Top,
				Text = "Extra: Cooking Mini-Game",
				Size = new Squid.Point(0, 50)
			};
			button4.MouseClick += delegate
			{
				_game.StartCutscene("MiniGameCooking");
				Hide();
			};
			panel.Content.Controls.Add(button4);
		}
		if (!Censorship.Censored && _selectedContact == PlayerData.EPhoneContacts.Remy && data.GetDecimal("RemyDate") > 30)
		{
			Button button5 = new Button
			{
				Dock = DockStyle.Top,
				Text = "Extra: Nude pictures",
				Size = new Squid.Point(0, 50)
			};
			button5.MouseClick += delegate
			{
				_game.StartCutscene("NudesRemy");
				Hide();
			};
			panel.Content.Controls.Add(button5);
		}
		string _nc2gJWKJm6yAMtppwpcfigGPFj3 = null;
		if (_selectedContact == PlayerData.EPhoneContacts.Coby && data.GetDecimal("CobyDate") == 20)
		{
			_nc2gJWKJm6yAMtppwpcfigGPFj3 = "CobySexscene";
		}
		else if (_selectedContact == PlayerData.EPhoneContacts.Dustin && data.GetDecimal("DustinDate") == 70)
		{
			_nc2gJWKJm6yAMtppwpcfigGPFj3 = "DustinPostDate";
		}
		else if (_selectedContact != PlayerData.EPhoneContacts.Jax || data.GetDecimal("JaxDate") != 40)
		{
			if (_selectedContact != PlayerData.EPhoneContacts.Lex || data.GetDecimal("LexDate") != 50)
			{
				if (_selectedContact == PlayerData.EPhoneContacts.Mercy && data.GetDecimal("MercyDate") == 60)
				{
					_nc2gJWKJm6yAMtppwpcfigGPFj3 = "MercyPostDate";
				}
				else if (_selectedContact != PlayerData.EPhoneContacts.Remy || data.GetDecimal("RemyDate") != 40)
				{
					if (_selectedContact != PlayerData.EPhoneContacts.Seth || data.GetDecimal("SethDate") != 40)
					{
						if (_selectedContact == PlayerData.EPhoneContacts.Skye && data.GetDecimal("SkyeDate") == 60)
						{
							_nc2gJWKJm6yAMtppwpcfigGPFj3 = "SkyePostDate";
						}
						else if (_selectedContact == PlayerData.EPhoneContacts.Zenith && data.GetDecimal("ZenithDate") == 70)
						{
							_nc2gJWKJm6yAMtppwpcfigGPFj3 = "ZenithPostDate";
						}
					}
					else
					{
						_nc2gJWKJm6yAMtppwpcfigGPFj3 = "SethPostDate";
					}
				}
				else
				{
					_nc2gJWKJm6yAMtppwpcfigGPFj3 = "RemyPostDate";
				}
			}
			else
			{
				_nc2gJWKJm6yAMtppwpcfigGPFj3 = "LexPostDate";
			}
		}
		else
		{
			_nc2gJWKJm6yAMtppwpcfigGPFj3 = "JaxPostDate";
		}
		if (_nc2gJWKJm6yAMtppwpcfigGPFj3 != null)
		{
			Button button6 = new Button
			{
				Dock = DockStyle.Top,
				Text = (Censorship.Censored ? "Extra: Love scene" : "Extra: Sexscene"),
				Size = new Squid.Point(0, 50)
			};
			button6.MouseClick += delegate
			{
				_ZfxNkwQ3qvZWenbVYRs2XNSAF2c(_nc2gJWKJm6yAMtppwpcfigGPFj3);
			};
			panel.Content.Controls.Add(button6);
		}
		return panel;
	}

	private Control _h2ArPDECvhhh0z0Z51CaUxB7rAr()
	{
		Panel panel = new Panel
		{
			Dock = DockStyle.Fill
		};
		Label item = new Label
		{
			Dock = DockStyle.Top,
			Text = "Club Amorous DJ",
			Style = "button",
			Size = new Squid.Point(0, 40),
			NoEvents = true
		};
		ImageControl item2 = new CustomImageControl
		{
			Dock = DockStyle.Top,
			Texture = "Contact_DJ",
			TextureRect = new Squid.Rectangle(0, 0, 268, 158)
		};
		Button button = new Button
		{
			Dock = DockStyle.Top,
			Text = "Request a song",
			Size = new Squid.Point(0, 50)
		};
		button.MouseClick += delegate
		{
			string name = _game.Scene.GetType().Name;
			if (name.StartsWith("Club"))
			{
				_eprNswcjHxcASaMkeDGEbGomDNI(PhoneScreen.Soundtrack);
			}
			else
			{
				TypingDialogue._zunSyHn4DekdA6CngP10dXcR1kq("<i>Hmm, the operator is telling me: 'The number you are trying to reach is currently unavailable'. I guess the DJ only has his phone enabled during Club hours.</i>", "%playername%", Color.White);
			}
		};
		panel.Content.Controls.Add(item);
		panel.Content.Controls.Add(item2);
		panel.Content.Controls.Add(button);
		return panel;
	}

	private ListBox _hiWNprom67B9EJO4loqBfhvB4hX()
	{
		ListBox listBox = _Y29nu3VoVEY6acDadsfRh60BNDh();
		List<_KZ7hNP1K5E99Xfup1lTZ9UDrxPE._vNekDVpW2fr7UkjA16E9ifFmD9s> list = _KZ7hNP1K5E99Xfup1lTZ9UDrxPE._LUJAgYjQ8oEpFgPKC5CzY9Ne5ju.OrderBy((_KZ7hNP1K5E99Xfup1lTZ9UDrxPE._vNekDVpW2fr7UkjA16E9ifFmD9s _vNekDVpW2fr7UkjA16E9ifFmD9s_0) => _vNekDVpW2fr7UkjA16E9ifFmD9s_0.Title).ToList();
		foreach (_KZ7hNP1K5E99Xfup1lTZ9UDrxPE._vNekDVpW2fr7UkjA16E9ifFmD9s item3 in list)
		{
			_KZ7hNP1K5E99Xfup1lTZ9UDrxPE._vNekDVpW2fr7UkjA16E9ifFmD9s _a5X3xjbmM60JVR5AMk4qrTqgyJm = item3;
			CustomListBoxItem customListBoxItem = new CustomListBoxItem
			{
				Size = new Squid.Point(0, 90)
			};
			Label item = new Label
			{
				Dock = DockStyle.Top,
				Size = new Squid.Point(0, 50),
				Text = "\"" + item3.Title + "\"",
				TextAlign = Alignment.MiddleCenter,
				TextColor = ColorInt.RGB(255, 255, 0),
				TextWrap = true,
				UseTextColor = true,
				NoEvents = true
			};
			Label item2 = new Label
			{
				Dock = DockStyle.Top,
				Size = new Squid.Point(0, 40),
				Text = "by " + item3._ynar3ZAutlIbbTWMBGvo1mdRNYz,
				TextAlign = Alignment.MiddleCenter,
				NoEvents = true
			};
			customListBoxItem.Controls.Add(item);
			customListBoxItem.Controls.Add(item2);
			customListBoxItem.MouseClick += delegate
			{
				int num = Randoms.Next(0, _djCommentaries.Length);
				TypingDialogue._zunSyHn4DekdA6CngP10dXcR1kq(_djCommentaries[num], ClubDJNPC.Name, ClubDJNPC.Color);
				FadingMediaPlayer._QrgbXEg7MMeD9Ybz12fFVsbmAd9(_a5X3xjbmM60JVR5AMk4qrTqgyJm._XAtd16WmK4L37sBtMsLCIvJzIS1, 0.3f, repeat: false);
				_game.Achievements.GainAchievement(Achievements.AchievementGeneric3);
			};
			listBox.ItemContainer.Controls.Add(customListBoxItem);
		}
		return listBox;
	}

	private ListBox _YGPgft9Vo9UMBMfVtN34XoT93HD()
	{
		ListBox listBox = _Y29nu3VoVEY6acDadsfRh60BNDh();
		ListBoxItem listBoxItem = new ListBoxItem
		{
			Text = "Messages",
			Size = new Squid.Point(0, 50)
		};
		listBoxItem.MouseClick += delegate
		{
			_eprNswcjHxcASaMkeDGEbGomDNI(PhoneScreen.DiaryMessages);
		};
		ListBoxItem listBoxItem2 = new ListBoxItem
		{
			Text = "Achievements",
			Size = new Squid.Point(0, 50)
		};
		listBoxItem2.MouseClick += delegate
		{
			_eprNswcjHxcASaMkeDGEbGomDNI(PhoneScreen.DiaryAchievements);
		};
		ListBoxItem listBoxItem3 = new ListBoxItem
		{
			Text = "Save",
			Size = new Squid.Point(0, 50)
		};
		listBoxItem3.MouseClick += delegate
		{
			_eprNswcjHxcASaMkeDGEbGomDNI(PhoneScreen.DiarySave);
		};
		ListBoxItem listBoxItem4 = new ListBoxItem
		{
			Text = "Load",
			Size = new Squid.Point(0, 50)
		};
		listBoxItem4.MouseClick += delegate
		{
			_eprNswcjHxcASaMkeDGEbGomDNI(PhoneScreen.DiaryLoad);
		};
		listBox.Items.Add(listBoxItem);
		if (_game.Achievements.IsSteamSupported)
		{
			ListBoxItem listBoxItem5 = new ListBoxItem
			{
				Text = "Steam Achievements",
				Size = new Squid.Point(0, 50)
			};
			listBoxItem5.MouseClick += delegate
			{
				_game.Achievements.OpenAchievements();
			};
			listBox.Items.Add(listBoxItem5);
		}
		listBox.Items.Add(listBoxItem2);
		listBox.Items.Add(listBoxItem3);
		listBox.Items.Add(listBoxItem4);
		return listBox;
	}

	private ListBox _ZAzvI9G8CsjLJ0AWtoSCmHUuR2q()
	{
		ListBox listBox = _Y29nu3VoVEY6acDadsfRh60BNDh();
		PlayerData data = PlayerPreferences.GetPlayerData();
		if (data.Messages.Count != 0)
		{
			foreach (PhoneMessage message in data.Messages.OrderByDescending((PhoneMessage _iDN1IKOu3e1uADYzeMEUon5D9fg_0) => _iDN1IKOu3e1uADYzeMEUon5D9fg_0.Date))
			{
				ImageControl item = new ImageControl
				{
					Dock = DockStyle.Left,
					Texture = message.Icon,
					Size = new Squid.Point(60, 50),
					NoEvents = true
				};
				Label item2 = new Label
				{
					Dock = DockStyle.Fill,
					Text = message.Title + "\r\n" + message.Date.ToShortDateString(),
					TextAlign = Alignment.MiddleLeft,
					Margin = new Margin(10, 0, 10, 0),
					AutoEllipsis = true,
					TextWrap = true,
					NoEvents = true
				};
				CustomListBoxItem customListBoxItem = new CustomListBoxItem
				{
					Size = new Squid.Point(0, 60),
					Padding = new Margin(2)
				};
				customListBoxItem.MouseClick += delegate
				{
					_selectedMessage = message;
					_eprNswcjHxcASaMkeDGEbGomDNI(PhoneScreen.DiaryMessagesInformation);
				};
				customListBoxItem.Controls.Add(item);
				customListBoxItem.Controls.Add(item2);
				listBox.ItemContainer.Controls.Add(customListBoxItem);
			}
			return listBox;
		}
		ListBoxItem item3 = new ListBoxItem
		{
			Text = "There are no messages yet!",
			Size = new Squid.Point(0, 50)
		};
		listBox.Items.Add(item3);
		return listBox;
	}

	private ListBox _jv6KLyNe1t3TATNww1TiWv9ZVLF()
	{
		ListBox listBox = _Y29nu3VoVEY6acDadsfRh60BNDh();
		PlayerData data = PlayerPreferences.GetPlayerData();
		foreach (Achievements.AchievementData achieve in Achievements.Achievables)
		{
			ImageControl item = new ImageControl
			{
				Dock = DockStyle.Left,
				Texture = achieve.Icon,
				Size = new Squid.Point(60, 50)
			};
			Label item2 = new Label
			{
				Dock = DockStyle.Fill,
				Text = achieve.Title,
				TextAlign = Alignment.MiddleLeft,
				Margin = new Margin(10, 0, 10, 0),
				AutoEllipsis = true,
				TextWrap = true
			};
			CustomListBoxItem customListBoxItem = new CustomListBoxItem
			{
				Size = new Squid.Point(0, 60),
				Padding = new Margin(2),
				NoEvents = true,
				Opacity = (data.GetBit(achieve.Key) ? 1f : 0.5f)
			};
			customListBoxItem.Controls.Add(item);
			customListBoxItem.Controls.Add(item2);
			listBox.ItemContainer.Controls.Add(customListBoxItem);
		}
		return listBox;
	}

	private Panel _yE1MXqtEKITxyL75pITcd8fNpsi()
	{
		Panel panel = new Panel
		{
			Dock = DockStyle.Fill
		};
		ImageControl item = new ImageControl
		{
			Dock = DockStyle.Left,
			Texture = _selectedMessage.Icon,
			Size = new Squid.Point(60, 50)
		};
		Label item2 = new Label
		{
			Dock = DockStyle.Fill,
			Text = _selectedMessage.Title + "\r\n" + _selectedMessage.Date.ToShortDateString(),
			TextAlign = Alignment.MiddleLeft,
			Margin = new Margin(10, 0, 10, 0),
			AutoEllipsis = true,
			TextWrap = true
		};
		Panel panel2 = new Panel
		{
			Dock = DockStyle.Top,
			Size = new Squid.Point(0, 60),
			Padding = new Margin(2),
			Style = "button",
			NoEvents = true
		};
		panel2.Content.Controls.Add(item);
		panel2.Content.Controls.Add(item2);
		Label item3 = new Label
		{
			Dock = DockStyle.Top,
			Text = _selectedMessage.Message,
			Margin = new Margin(10),
			TextAlign = Alignment.MiddleCenter,
			AutoSize = AutoSize.Vertical,
			TextWrap = true,
			NoEvents = true
		};
		Button button = new Button
		{
			Dock = DockStyle.Top,
			Text = "Delete message",
			Size = new Squid.Point(0, 50)
		};
		button.MouseClick += delegate
		{
			_blocked = true;
			_squid.ShowSelection("Are you sure you wish to remove this message?", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, 250, delegate(int int_0)
			{
				if (int_0 == 1)
				{
					PlayerData data = PlayerPreferences.GetPlayerData();
					data.Messages.Remove(_selectedMessage);
					_selectedMessage = null;
					_270ZVixWLhgEiLA6QosapJMyU6h();
				}
				_blocked = false;
			});
		};
		panel.Content.Controls.Add(panel2);
		panel.Content.Controls.Add(item3);
		panel.Content.Controls.Add(button);
		return panel;
	}

	private ListBox _QmCbnBf76ITvR2HA7WYF44qkJWK()
	{
		ListBox listBox = _Y29nu3VoVEY6acDadsfRh60BNDh();
		List<Saves.Pointer> list = Saves.GetPointers(excludeAutosaves: true);
		foreach (Saves.Pointer item in list)
		{
			int num = item.Name.IndexOf('-');
			string text = item.Name.Substring(0, num).Trim();
			string text2 = item.Name.Substring(num + 1).Trim();
			ListBoxItem listBoxItem = new ListBoxItem
			{
				Text = text + "\r\n" + text2,
				Size = new Squid.Point(0, 50)
			};
			Saves.Pointer _7OcRfli7CrlI9YYUDJj3j5nDI9k = item;
			listBoxItem.MouseClick += delegate
			{
				if (_7OcRfli7CrlI9YYUDJj3j5nDI9k.IsEmpty)
				{
					_game.SaveAtSlot(_7OcRfli7CrlI9YYUDJj3j5nDI9k.Index);
					_singleton._DAsCL6JdGst3kJHpcbztigO3VEV();
				}
				else
				{
					_blocked = true;
					_squid.ShowSelection($"Are you sure you wish to overwrite slot #{_7OcRfli7CrlI9YYUDJj3j5nDI9k.Index + 1}?", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, 250, delegate(int int_0)
					{
						if (int_0 == 1)
						{
							_game.SaveAtSlot(_7OcRfli7CrlI9YYUDJj3j5nDI9k.Index);
							_singleton._DAsCL6JdGst3kJHpcbztigO3VEV();
						}
						_blocked = false;
					});
				}
			};
			listBox.Items.Add(listBoxItem);
		}
		return listBox;
	}

	private ListBox _mKzC4RKCG3B1ZBdWwcAp79gd8NaA()
	{
		ListBox listBox = _Y29nu3VoVEY6acDadsfRh60BNDh();
		List<Saves.Pointer> list = Saves.GetPointers(excludeAutosaves: false);
		foreach (Saves.Pointer item in list)
		{
			int num = item.Name.IndexOf('-');
			string text = item.Name.Substring(0, num).Trim();
			string text2 = item.Name.Substring(num + 1).Trim();
			ListBoxItem listBoxItem = new ListBoxItem
			{
				Text = text + "\r\n" + text2,
				Size = new Squid.Point(0, 50)
			};
			Saves.Pointer _7OcRfli7CrlI9YYUDJj3j5nDI9k = item;
			listBoxItem.MouseClick += delegate
			{
				if (!_7OcRfli7CrlI9YYUDJj3j5nDI9k.IsEmpty)
				{
					_blocked = true;
					_squid.ShowSelection(string.Format("Are you sure you wish to load {0}slot #{1}?", (!_7OcRfli7CrlI9YYUDJj3j5nDI9k.IsAutosave) ? string.Empty : "autosave ", _7OcRfli7CrlI9YYUDJj3j5nDI9k.Index + 1), new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, 250, delegate(int int_0)
					{
						if (int_0 == 1)
						{
							_77rSPCEs6VEYjlGrwW0KN0btLEG = true;
							if (_7OcRfli7CrlI9YYUDJj3j5nDI9k.IsAutosave ? _game.ReadFromAutosaveSlot(_7OcRfli7CrlI9YYUDJj3j5nDI9k.Index) : _game.ReadFromSlot(_7OcRfli7CrlI9YYUDJj3j5nDI9k.Index))
							{
								_77rSPCEs6VEYjlGrwW0KN0btLEG = false;
								_blocked = false;
								Hide();
							}
							else
							{
								_squid.ShowConfirm("Failed to load save, it's most likely corrupted.", 250, "OK", delegate
								{
									_77rSPCEs6VEYjlGrwW0KN0btLEG = false;
									_blocked = false;
								});
							}
						}
						else
						{
							_blocked = false;
						}
					});
				}
				else
				{
					_blocked = true;
					_squid.ShowConfirm(string.Format("There is no save in {0}slot #{1}!", _7OcRfli7CrlI9YYUDJj3j5nDI9k.IsAutosave ? "autosave " : string.Empty, _7OcRfli7CrlI9YYUDJj3j5nDI9k.Index + 1), 250, "OK", delegate
					{
						_blocked = false;
					});
				}
			};
			listBox.Items.Add(listBoxItem);
		}
		return listBox;
	}

	private Control _fM96M1a1ZZUtzPyevCm45mKPeQg()
	{
		Panel panel = new Panel
		{
			Dock = DockStyle.Fill,
			Margin = new Margin(10)
		};
		Label item = new Label
		{
			Dock = DockStyle.Top,
			Text = "Master Volume"
		};
		Slider slider = new Slider();
		slider.Dock = DockStyle.Top;
		slider.Orientation = Orientation.Horizontal;
		slider.Steps = 100f;
		slider.Value = Options.Data.MasterVolume * 100f;
		slider.Style = "scrollSlider";
		slider.Size = new Squid.Point(0, 30);
		slider.Button.Style = "scrollSliderButton";
		Slider _XEgAfmv7sJWJSaC2diC3eaD4Fgl = slider;
		_XEgAfmv7sJWJSaC2diC3eaD4Fgl.ValueChanged += delegate
		{
			Options.Data.MasterVolume = _XEgAfmv7sJWJSaC2diC3eaD4Fgl.Value / 100f;
		};
		Label item2 = new Label
		{
			Dock = DockStyle.Top,
			Text = "Music Volume"
		};
		Slider slider2 = new Slider();
		slider2.Dock = DockStyle.Top;
		slider2.Orientation = Orientation.Horizontal;
		slider2.Steps = 100f;
		slider2.Value = Options.Data.MusicVolume * 100f;
		slider2.Style = "scrollSlider";
		slider2.Size = new Squid.Point(0, 30);
		slider2.Button.Style = "scrollSliderButton";
		Slider _gjeIIVx9bHyd0aMj0WD483nrLWK = slider2;
		_gjeIIVx9bHyd0aMj0WD483nrLWK.ValueChanged += delegate
		{
			Options.Data.MusicVolume = _gjeIIVx9bHyd0aMj0WD483nrLWK.Value / 100f;
		};
		Label item3 = new Label
		{
			Dock = DockStyle.Top,
			Text = "SFX Volume"
		};
		Slider slider3 = new Slider();
		slider3.Dock = DockStyle.Top;
		slider3.Orientation = Orientation.Horizontal;
		slider3.Steps = 100f;
		slider3.Value = Options.Data.SfxVolume * 100f;
		slider3.Style = "scrollSlider";
		slider3.Size = new Squid.Point(0, 30);
		slider3.Button.Style = "scrollSliderButton";
		Slider _5mK9ExiyKm0md8q4J1C6xc4TzdF = slider3;
		_5mK9ExiyKm0md8q4J1C6xc4TzdF.ValueChanged += delegate
		{
			Options.Data.SfxVolume = _5mK9ExiyKm0md8q4J1C6xc4TzdF.Value / 100f;
		};
		panel.Content.Controls.Add(item);
		panel.Content.Controls.Add(_XEgAfmv7sJWJSaC2diC3eaD4Fgl);
		panel.Content.Controls.Add(item2);
		panel.Content.Controls.Add(_gjeIIVx9bHyd0aMj0WD483nrLWK);
		panel.Content.Controls.Add(item3);
		panel.Content.Controls.Add(_5mK9ExiyKm0md8q4J1C6xc4TzdF);
		return panel;
	}

	private Control _H2blb6Djx9JemSUBYepwlzNOXxz()
	{
		Panel panel = new Panel
		{
			Dock = DockStyle.Fill,
			Margin = new Margin(10)
		};
		_YemBTJprwfbd3mpg5Gy9uyEJWwI(panel.Content.Controls, "Dialogue Text Speed", new string[4] { "Slow", "Normal", "Fast", "Instant" }, (int)Options.Data.DialogueTextSpeed, delegate(int int_0)
		{
			Options.Data.DialogueTextSpeed = (DialogueSpeed)int_0;
			TypingDialogue.Speed = (DialogueSpeed)int_0;
		});
		CheckBox _feL3soNn6ZWaJqYfjYJUyH118tF = new CheckBox
		{
			Dock = DockStyle.Top,
			Text = "Dialogue Auto-skip",
			Checked = Options.Data.DialogueAutoSkip
		};
		_feL3soNn6ZWaJqYfjYJUyH118tF.CheckedChanged += delegate
		{
			Options.Data.DialogueAutoSkip = _feL3soNn6ZWaJqYfjYJUyH118tF.Checked;
			TypingDialogue._fUgDiz7KX8TZUVzFlTeXMOhmfUT = _feL3soNn6ZWaJqYfjYJUyH118tF.Checked;
		};
		panel.Content.Controls.Add(_feL3soNn6ZWaJqYfjYJUyH118tF);
		return panel;
	}

	public static void _YemBTJprwfbd3mpg5Gy9uyEJWwI(ControlCollection controlCollection_0, string string_0, string[] string_1, int int_0, Action<int> action_0)
	{
		Label item = new Label
		{
			Text = string_0,
			Dock = DockStyle.Top
		};
		DropDownList dropDownList = new DropDownList();
		dropDownList.Dock = DockStyle.Top;
		dropDownList.Style = "button";
		dropDownList.Label.Margin = new Margin(10, 0, 0, 0);
		dropDownList.Dropdown.Resizable = false;
		dropDownList.Margin = new Margin(0, 0, 0, 5);
		DropDownList dropDownList2 = dropDownList;
		dropDownList2.Listbox.Scrollbar.ButtonUp.Visible = false;
		dropDownList2.Listbox.Scrollbar.ButtonDown.Visible = false;
		for (int i = 0; i < string_1.Length; i++)
		{
			dropDownList2.Items.Add(new ListBoxItem
			{
				Text = string_1[i],
				Value = i,
				Selected = (i == int_0),
				Size = new Squid.Point(0, 30)
			});
		}
		dropDownList2.SelectedItemChanged += delegate(Control control_0, ListBoxItem listBoxItem_0)
		{
			action_0((int)listBoxItem_0.Value);
		};
		controlCollection_0.Add(item);
		controlCollection_0.Add(dropDownList2);
	}

	private ListBox _1Bze6b62yGQDi3JBE0TyQmPGkzU()
	{
		ListBox listBox = _Y29nu3VoVEY6acDadsfRh60BNDh();
		ListBoxItem listBoxItem = new ListBoxItem
		{
			Text = "Player Customization",
			Size = new Squid.Point(0, 50)
		};
		listBoxItem.MouseClick += delegate
		{
			_blocked = true;
			_squid.ShowSelection("Are you sure you wish to customize your character? This may break some active dates even if make no changes!", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, 250, delegate(int int_0)
			{
				if (int_0 == 1)
				{
					Hide();
					_game.StartScene<BackToPlayerCustomizationScene>();
				}
				_blocked = false;
			});
		};
		listBox.Items.Add(listBoxItem);
		if (Censorship.Booties)
		{
			listBox.Items.Add(new ListBoxItem
			{
				Text = "---",
				Enabled = false
			});
			ListBoxItem _diVdxVCKW4CzhbYSG15BcHJB0Ub = new ListBoxItem
			{
				Text = (Censorship.Censored ? "Disable SFW" : "Enable SFW"),
				Size = new Squid.Point(0, 50)
			};
			_diVdxVCKW4CzhbYSG15BcHJB0Ub.MouseClick += delegate
			{
				_YdyKdWT8QbQOIWkgEuPe6a9hJtd(delegate
				{
					Censorship.Censored = !Censorship.Censored;
					_DAsCL6JdGst3kJHpcbztigO3VEV();
					_diVdxVCKW4CzhbYSG15BcHJB0Ub.Text = (Censorship.Censored ? "Disable SFW" : "Enable SFW");
				});
			};
			listBox.Items.Add(_diVdxVCKW4CzhbYSG15BcHJB0Ub);
		}
		if (!Censorship.Censored)
		{
			_oWVabv0BTttUwHhKppcIL7h0vrZ(listBox);
		}
		return listBox;
	}

	private void _YdyKdWT8QbQOIWkgEuPe6a9hJtd(Action action_0)
	{
		_game.Fading.Show(delegate
		{
			string sceneName = _game.Sexscene?.GetType().Name;
			if (sceneName != null)
			{
				_game.ResetSexscene();
			}
			action_0();
			_game.SwitchScene(_game.Scene.GetType().Name, delegate
			{
				if (sceneName != null)
				{
					_game.StartSexscene(sceneName);
				}
				_game.Fading.Hide();
			});
		});
	}

	private void _ZfxNkwQ3qvZWenbVYRs2XNSAF2c(string string_0)
	{
		_game.StartCutscene(string_0);
		Hide();
	}

	private ListBox _dT5L6g1CEsgeYg5W9sVqR2trRSK()
	{
		ListBox listBox = _Y29nu3VoVEY6acDadsfRh60BNDh();
		PlayerData data = PlayerPreferences.GetPlayerData();
		if (data.GetDecimal("Prologue") == 40)
		{
			ListBoxItem listBoxItem = new ListBoxItem
			{
				Text = "Back to Home",
				Size = new Squid.Point(0, 50)
			};
			ListBoxItem listBoxItem2 = new ListBoxItem
			{
				Text = "Back to Club Amorous",
				Size = new Squid.Point(0, 50)
			};
			listBox.Items.Add(listBoxItem);
			listBox.Items.Add(listBoxItem2);
			listBoxItem.MouseClick += delegate
			{
				Hide();
				_game.StartScene<BedroomScene>();
			};
			listBoxItem2.MouseClick += delegate
			{
				Hide();
				_game.StartScene<ClubInsideScene>();
			};
			listBox.Items.Add(new ListBoxItem
			{
				Text = "---",
				Enabled = false
			});
		}
		ListBoxItem listBoxItem3 = new ListBoxItem
		{
			Text = "Exit to Main Menu",
			Size = new Squid.Point(0, 50)
		};
		listBoxItem3.MouseClick += delegate
		{
			Hide();
			_kf3EbE0B70xGe1szklqAZyCqoLj = false;
			_game.StartScene<MainMenuScene>();
		};
		ListBoxItem listBoxItem4 = new ListBoxItem
		{
			Text = "Quit Game",
			Size = new Squid.Point(0, 50)
		};
		listBoxItem4.MouseClick += delegate
		{
			_blocked = true;
			_squid.ShowSelection("Are you sure you wish to quit the Game? All unsaved progress will be lost!", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, 250, delegate(int int_0)
			{
				if (int_0 == 1)
				{
					_game.Exit();
				}
				_blocked = false;
			});
		};
		listBox.Items.Add(listBoxItem3);
		listBox.Items.Add(listBoxItem4);
		return listBox;
	}

	private void _oWVabv0BTttUwHhKppcIL7h0vrZ(ListBox listBox_0)
	{
		ListBoxItem _Epeel2m9h5O12V2ERwlnNTE3FdM = new ListBoxItem
		{
			Text = (Censorship.Topless ? "Disable Topless Cheat" : "Enable Topless Cheat"),
			Size = new Squid.Point(0, 50)
		};
		_Epeel2m9h5O12V2ERwlnNTE3FdM.MouseClick += delegate
		{
			_YdyKdWT8QbQOIWkgEuPe6a9hJtd(delegate
			{
				Censorship.Topless = !Censorship.Topless;
				_Epeel2m9h5O12V2ERwlnNTE3FdM.Text = (Censorship.Topless ? "Disable Topless Cheat" : "Enable Topless Cheat");
			});
		};
		ListBoxItem _FxyX2MMMdsf69424VDXa8LqP1nq = new ListBoxItem
		{
			Text = (Censorship.Bottomless ? "Disable Bottomless Cheat" : "Enable Bottomless Cheat"),
			Size = new Squid.Point(0, 50)
		};
		_FxyX2MMMdsf69424VDXa8LqP1nq.MouseClick += delegate
		{
			_YdyKdWT8QbQOIWkgEuPe6a9hJtd(delegate
			{
				Censorship.Bottomless = !Censorship.Bottomless;
				_FxyX2MMMdsf69424VDXa8LqP1nq.Text = (Censorship.Bottomless ? "Disable Bottomless Cheat" : "Enable Bottomless Cheat");
			});
		};
		listBox_0.Items.Add(_Epeel2m9h5O12V2ERwlnNTE3FdM);
		listBox_0.Items.Add(_FxyX2MMMdsf69424VDXa8LqP1nq);
	}

	private void _WDhVhBhQHGowaONqV87v7EaCvro(PlayerData.EPhoneContacts ephoneContacts_0)
	{
		PlayerData data = PlayerPreferences.GetPlayerData();
		switch (ephoneContacts_0)
		{
		case PlayerData.EPhoneContacts.Dustin:
			if (data.GetDecimal("DustinDate") != 70)
			{
				_game.StartCutscene("DustinDate");
				Hide();
			}
			else
			{
				_7v3cPeHMFZr3s2VCyeFm9SEiyy0(ephoneContacts_0);
			}
			break;
		case PlayerData.EPhoneContacts.Remy:
			if (data.GetDecimal("RemyDate") != 40)
			{
				_game.StartCutscene("RemyDate");
				Hide();
			}
			else
			{
				_7v3cPeHMFZr3s2VCyeFm9SEiyy0(ephoneContacts_0);
			}
			break;
		case PlayerData.EPhoneContacts.Seth:
			if (data.GetDecimal("SethDate") == 40)
			{
				_7v3cPeHMFZr3s2VCyeFm9SEiyy0(ephoneContacts_0);
				break;
			}
			_game.StartCutscene("SethDate");
			Hide();
			break;
		case PlayerData.EPhoneContacts.Skye:
			if (data.GetDecimal("SkyeDate") != 60)
			{
				_game.StartCutscene("SkyeDate");
				Hide();
			}
			else
			{
				_7v3cPeHMFZr3s2VCyeFm9SEiyy0(ephoneContacts_0);
			}
			break;
		case PlayerData.EPhoneContacts.Zenith:
			if (PlayerPreferences.GetPlayerData().GetDecimal("ZenithDate") == 70)
			{
				_7v3cPeHMFZr3s2VCyeFm9SEiyy0(ephoneContacts_0);
				break;
			}
			_game.StartCutscene("ZenithDate");
			Hide();
			break;
		case PlayerData.EPhoneContacts.Mercy:
			if (data.GetDecimal("MercyDate") != 60)
			{
				_game.StartCutscene("MercyDate");
				Hide();
			}
			else
			{
				_7v3cPeHMFZr3s2VCyeFm9SEiyy0(ephoneContacts_0);
			}
			break;
		case PlayerData.EPhoneContacts.Lex:
			if (data.GetDecimal("LexDate") == 50)
			{
				_7v3cPeHMFZr3s2VCyeFm9SEiyy0(ephoneContacts_0);
				break;
			}
			_game.StartCutscene("LexDate");
			Hide();
			break;
		case PlayerData.EPhoneContacts.Jax:
			if (data.GetDecimal("JaxDate") == 40)
			{
				_7v3cPeHMFZr3s2VCyeFm9SEiyy0(ephoneContacts_0);
				break;
			}
			_game.StartCutscene("JaxDate");
			Hide();
			break;
		case PlayerData.EPhoneContacts.Coby:
			if (data.GetDecimal("CobyDate") < 20)
			{
				_game.StartCutscene("CobyDate");
				Hide();
			}
			else
			{
				_game.StartCutscene("CobyPostDate");
			}
			break;
		}
	}

	private void _7v3cPeHMFZr3s2VCyeFm9SEiyy0(PlayerData.EPhoneContacts ephoneContacts_0)
	{
		_blocked = true;
		string arg = ephoneContacts_0.ToString();
		_squid.ShowConfirm($"You finished all dates with {arg}!", 250, "Gotcha!", delegate
		{
			_blocked = false;
		});
	}

	public PhoneOverlay(IAmorous game, ContentManager content)
	{
		_singleton = this;
		_game = game;
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD = content.LoadSkeleton("Assets/GUI/Phone/Phone");
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.ApplyFrame("Arm rise", 0f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetVisibility(0f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.X = 0f;
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.Y = 1200f;
		_lpMGMQZJYmHr6q9XBRwiM0Lse4N = content.LoadSkeleton("Assets/GUI/Phone/PhoneHUD", 0.5f);
		_lpMGMQZJYmHr6q9XBRwiM0Lse4N.StartAnimationWithLooping("No message");
		_lpMGMQZJYmHr6q9XBRwiM0Lse4N.X = 1845f;
		_lpMGMQZJYmHr6q9XBRwiM0Lse4N.Y = 1060f;
		_wTbB4YBL4PSkaotwKX3CFc50DmX = content.LoadSkeleton("Assets/GUI/Phone/PhoneScreen");
		_wTbB4YBL4PSkaotwKX3CFc50DmX.X = 135f;
		_wTbB4YBL4PSkaotwKX3CFc50DmX.Y = 190f;
		_rASuGHWSFVWfkpwzF8wZd9bh3XN = true;
		_Xrfjrxr72hHh4bDdQB7HzEbJUCb();
		_squid = new Desktop
		{
			Skin = Gui.GenerateStandardSkin(),
			Size = new Squid.Point(270, 380)
		};
		_squid.SetSkin("Assets/GUI/Squid/DefaultSkin");
		_squid.ModalColor = ColorInt.ARGB(0.9f, 0f, 0f, 0f);
		_squid.MouseTransformFunc = delegate(Squid.Point point_0)
		{
			double double_;
			Microsoft.Xna.Framework.Point point = _hrw3Kf8fCx7saJOmoYUD8sIz3uD.GetDistanceDepth("Sheen Two", out double_);
			Matrix matrix = Matrix.CreateTranslation(-point.X, -point.Y, 0f) * Matrix.CreateRotationZ((float)(0.0 - double_));
			Vector2 vector = Vector2.Transform(new Vector2(point_0.x, point_0.y), matrix);
			return new Squid.Point((int)vector.X, (int)vector.Y);
		};
		_bZJtpWV2Yj6GgZkeZQUmpTHxTnh = new RenderTarget2D(_game.GLES, 270, 380);
		_Pfaq6ajchxcqF6GecivHvHqQW6M = new RenderTarget2D(_game.GLES, 270, 380);
		_screenHistory = new Stack<PhoneScreen>();
		_1gXQH16lmsacxQMOpjFFqZSmjQl = true;
		_97m6gVcwgWbLFyNUxI3P1KuD0Gn = true;
	}

	public void _Xrfjrxr72hHh4bDdQB7HzEbJUCb()
	{
		PlayerData data = PlayerPreferences.GetPlayerData();
		bool hasLongMarkings = data.MarkingsType.HasFlag(PlayerData.EMarkingsType.LongForearm);
		bool hasShortMarkings = data.MarkingsType.HasFlag(PlayerData.EMarkingsType.ShortForearm);
		Color color_ = hasShortMarkings ? data.ShortForearmColor : (hasLongMarkings ? data.LongForearmColor : Color.White);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("Hoody Sleeve", 0f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("Default Forearm", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetColor("Default Forearm", data.BodyColor);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("Marking Forearm", (hasShortMarkings || hasLongMarkings) ? 1 : 0);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetColor("Marking Forearm", color_);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("Striped forearm", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1 : 0);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetColor("Striped forearm", data.StripesColor);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("Avian Forearm", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetColor("Avian Forearm", data.AvianForearmColor);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("Hand", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetColor("Hand", data.BodyColor);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("Marking Hand", (hasShortMarkings || hasLongMarkings) ? 1 : 0);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetColor("Marking Hand", color_);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("Avian Hand", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetColor("Avian Hand", data.AvianForearmColor);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("Index", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetColor("Index", data.BodyColor);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("Avian index", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetColor("Avian index", data.AvianForearmColor);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("Pinky", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetColor("Pinky", data.BodyColor);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("Avian Pinky", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetColor("Avian Pinky", data.AvianForearmColor);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("Ring", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetColor("Ring", data.BodyColor);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("Avian ring", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetColor("Avian ring", data.AvianForearmColor);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("Rude", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetColor("Rude", data.BodyColor);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("Avian Rude", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetColor("Avian Rude", data.AvianForearmColor);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("Thumb", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetColor("Thumb", data.BodyColor);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("Avian Thumb", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetColor("Avian Thumb", data.AvianForearmColor);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("Pinky Nail", data.ShowNails ? 1 : 0);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetColor("Pinky Nail", data.NailColor);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("Ring Nail", data.ShowNails ? 1 : 0);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetColor("Ring Nail", data.NailColor);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("Rude Nail", data.ShowNails ? 1 : 0);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetColor("Rude Nail", data.NailColor);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("Index Nail", data.ShowNails ? 1 : 0);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetColor("Index Nail", data.NailColor);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("Thumb Nail", data.ShowNails ? 1 : 0);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetColor("Thumb Nail", data.NailColor);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("Phone lines", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetColor("Phone lines", data.PhoneColor);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("Phone Colour", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("Phone Shadow", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("BG CONTACTS", 0f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("BG DIARY", 0f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("BG AUDIO", 0f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("BG CHAT SETTINGS", 0f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("BG GALLERY", 0f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("BG POWER", 0f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("Phone Default Background", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("CONTACTS", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("Diary", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("Audio", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("Chat Settings", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("Gallery", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("Power", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("white screen", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("black screen", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("Power", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.SetAlpha("Sheen Two", 1f);
		_IiWYS6YP6cEj83PIAXepbAHBaJB();
	}

	private void _IiWYS6YP6cEj83PIAXepbAHBaJB()
	{
		PlayerData data = PlayerPreferences.GetPlayerData();
		_lpMGMQZJYmHr6q9XBRwiM0Lse4N.SetColor("Phone", data.PhoneColor);
	}

	public static PhoneOverlay Get()
	{
		return _singleton;
	}

	private void _3mKo17hkpGwyDp6sHVZAhV1c6Qv(PlayerData.EPhoneContacts ephoneContacts_0)
	{
		_rASuGHWSFVWfkpwzF8wZd9bh3XN = false;
		foreach (string item in _PcaKA8lfkZnYKjOTdM7RWYPBlGr.Keys.ToList())
		{
			_PcaKA8lfkZnYKjOTdM7RWYPBlGr[item] = false;
		}
		if (ephoneContacts_0 == PlayerData.EPhoneContacts.Lex)
		{
			_PcaKA8lfkZnYKjOTdM7RWYPBlGr["Alex"] = true;
			_PcaKA8lfkZnYKjOTdM7RWYPBlGr["Alex image"] = true;
		}
		else
		{
			_PcaKA8lfkZnYKjOTdM7RWYPBlGr[ephoneContacts_0.ToString()] = true;
			_PcaKA8lfkZnYKjOTdM7RWYPBlGr[ephoneContacts_0.ToString() + " image"] = true;
		}
	}

	private void _8hw6Dkw1FlTEpsiy0adBUXTGpRe(bool bool_0)
	{
		_0OvMkQYTGPrNhckv6iHt3zmR5ni["reject call with message"] = bool_0;
		_0OvMkQYTGPrNhckv6iHt3zmR5ni["Incoming call"] = bool_0;
	}

	public void Update(GameTime gameTime, MouseObserver mouse)
	{
		if (_game.Controller.JustPressed(Microsoft.Xna.Framework.Input.Keys.Escape) || _game.Controller.JustPressed(Microsoft.Xna.Framework.Input.Keys.LeftShift))
		{
			Rise();
		}
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD.Update(gameTime, (_game.Cutscene != null || !_flEA1zdf7DHRkPwzrlsWVEAXZiX) ? RiseDownDuration : _duration);
		_lpMGMQZJYmHr6q9XBRwiM0Lse4N.Update(gameTime);
		_wTbB4YBL4PSkaotwKX3CFc50DmX.Update(gameTime);
		_D1T6p91T7mKeglw2nCBqHjNgzfB();
		_48sn09DNztKRWaadCpDeWr57ENW(mouse);
		_Xgbbx1uIlIM4mSecGPtARNWvSMm(mouse);
		if (!_Ldzm1JY9st4tknAhrglOIpwdYhn)
		{
			_squid.Update();
		}
	}

	private void _D1T6p91T7mKeglw2nCBqHjNgzfB()
	{
		if (_TZx1AkahTLXoM2XUbm5U8YJOScb)
		{
			return;
		}
		if (_WaCCr2ToiTDglrrE9z1EKOcLzT3)
		{
			_flEA1zdf7DHRkPwzrlsWVEAXZiX = false;
			_WaCCr2ToiTDglrrE9z1EKOcLzT3 = false;
			_TZx1AkahTLXoM2XUbm5U8YJOScb = true;
			_hrw3Kf8fCx7saJOmoYUD8sIz3uD.StartAnimation("Arm rise", delegate
			{
				_TZx1AkahTLXoM2XUbm5U8YJOScb = false;
				Phase = PhonePhase.ArmUp;
				_aEgXugtdIuFieAwnDhnIlYNEysg();
			});
		}
		else if (_p4cbe03cXPNybrHUo9DHRTp6W7m)
		{
			_flEA1zdf7DHRkPwzrlsWVEAXZiX = false;
			_p4cbe03cXPNybrHUo9DHRTp6W7m = false;
			_TZx1AkahTLXoM2XUbm5U8YJOScb = true;
			_hrw3Kf8fCx7saJOmoYUD8sIz3uD.StartAnimation("Arm lower", delegate
			{
				_TZx1AkahTLXoM2XUbm5U8YJOScb = false;
				Phase = PhonePhase.ArmDown;
			});
		}
	}

	private void _48sn09DNztKRWaadCpDeWr57ENW(MouseObserver mouse)
	{
		if (Indication == PhoneIndication.None || _game.Cutscene != null || _blocked)
		{
			return;
		}
		Microsoft.Xna.Framework.Point point = mouse.Rescale(_game.Controller.Cursor);
		if (_lpMGMQZJYmHr6q9XBRwiM0Lse4N.InAttachment("Phone", point.X, point.Y))
		{
			_lpMGMQZJYmHr6q9XBRwiM0Lse4N.SetColor("Phone", Color.Red);
			AbstractScene.CapturedByOverlay = true;
			if (_game.Controller.JustPressed(ControllerButtonType.LeftButton))
			{
				Rise();
			}
			_tIOoXRaaichIzSVUOs5dNLciPbw = true;
		}
		else if (_tIOoXRaaichIzSVUOs5dNLciPbw)
		{
			_lpMGMQZJYmHr6q9XBRwiM0Lse4N.SetColor("Phone", PlayerPreferences.GetPlayerData().PhoneColor);
			if (Phase == PhonePhase.ArmDown || Phase == PhonePhase.ArmDownRequested)
			{
				AbstractScene.CapturedByOverlay = false;
			}
			_tIOoXRaaichIzSVUOs5dNLciPbw = false;
		}
	}

	private void _Xgbbx1uIlIM4mSecGPtARNWvSMm(MouseObserver mouse)
	{
		if (Phase != PhonePhase.ArmUp || _game.Cutscene != null || _blocked)
		{
			return;
		}
		Microsoft.Xna.Framework.Point point = mouse.Rescale(_game.Controller.Cursor);
		bool captured = _hrw3Kf8fCx7saJOmoYUD8sIz3uD.InAttachment("Phone Colour", point.X, point.Y);
		_duration = (captured ? RiseUpDuration : RiseDownDuration);
		if (!captured)
		{
			return;
		}
		if (_game.Controller.JustPressed(ControllerButtonType.LeftButton))
		{
			if (_screen == PhoneScreen.Home)
			{
				if (_hrw3Kf8fCx7saJOmoYUD8sIz3uD.InAttachment("CONTACTS", point.X, point.Y))
				{
					_eprNswcjHxcASaMkeDGEbGomDNI(PhoneScreen.Contacts);
				}
				else if (_hrw3Kf8fCx7saJOmoYUD8sIz3uD.InAttachment("Diary", point.X, point.Y))
				{
					_eprNswcjHxcASaMkeDGEbGomDNI(PhoneScreen.Diary);
				}
				else if (_hrw3Kf8fCx7saJOmoYUD8sIz3uD.InAttachment("Audio", point.X, point.Y))
				{
					_eprNswcjHxcASaMkeDGEbGomDNI(PhoneScreen.Audio);
				}
				else if (_hrw3Kf8fCx7saJOmoYUD8sIz3uD.InAttachment("Chat Settings", point.X, point.Y))
				{
					_eprNswcjHxcASaMkeDGEbGomDNI(PhoneScreen.ChatSettings);
				}
				else if (_hrw3Kf8fCx7saJOmoYUD8sIz3uD.InAttachment("Gallery", point.X, point.Y))
				{
					_eprNswcjHxcASaMkeDGEbGomDNI(PhoneScreen.Gallery);
				}
				else if (_hrw3Kf8fCx7saJOmoYUD8sIz3uD.InAttachment("Power", point.X, point.Y))
				{
					_eprNswcjHxcASaMkeDGEbGomDNI(PhoneScreen.Power);
				}
				else if (!_hrw3Kf8fCx7saJOmoYUD8sIz3uD.InAttachment("Phone Default Background", point.X, point.Y))
				{
					Hide();
				}
			}
			else if (!_hrw3Kf8fCx7saJOmoYUD8sIz3uD.InAttachment("Phone Default Background", point.X, point.Y))
			{
				_270ZVixWLhgEiLA6QosapJMyU6h();
			}
		}
		if (_game.Controller.JustPressed(ControllerButtonType.RightButton))
		{
			if (_screen != 0)
			{
				_270ZVixWLhgEiLA6QosapJMyU6h();
			}
			else
			{
				Hide();
			}
		}
	}

	public void Draw(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer)
	{
		if (!_kf3EbE0B70xGe1szklqAZyCqoLj)
		{
			return;
		}
		if (_TZx1AkahTLXoM2XUbm5U8YJOScb || Phase == PhonePhase.ArmUp)
		{
			RenderTargetBinding[] renderTargets = _game.GLES.GetRenderTargets();
			_game.GLES.SetRenderTarget(_bZJtpWV2Yj6GgZkeZQUmpTHxTnh);
			_squid.Draw();
			_game.GLES.SetRenderTarget(_Pfaq6ajchxcqF6GecivHvHqQW6M);
			_wTbB4YBL4PSkaotwKX3CFc50DmX.Draw(skeletonMeshRenderer, null, delegate(int int_0, string string_0)
			{
				if (_PcaKA8lfkZnYKjOTdM7RWYPBlGr.ContainsKey(string_0))
				{
					return _PcaKA8lfkZnYKjOTdM7RWYPBlGr[string_0];
				}
				return !_0OvMkQYTGPrNhckv6iHt3zmR5ni.ContainsKey(string_0) || _0OvMkQYTGPrNhckv6iHt3zmR5ni[string_0];
			});
			_game.GLES.SetRenderTargets(renderTargets);
			double _09rdYyvQzUwbdQbzRZF4vbpdUCO;
			Microsoft.Xna.Framework.Point _eeWHzOz6LrTokRQr52VaB0dKbQO = _hrw3Kf8fCx7saJOmoYUD8sIz3uD.GetDistanceDepth("Sheen Two", out _09rdYyvQzUwbdQbzRZF4vbpdUCO);
			_hrw3Kf8fCx7saJOmoYUD8sIz3uD.Draw(skeletonMeshRenderer, null, delegate(int int_0, string string_0)
			{
				if (string_0 == "Sheen Two")
				{
					skeletonMeshRenderer.End();
					spriteBatch.Begin();
					if (!_Ldzm1JY9st4tknAhrglOIpwdYhn)
					{
						spriteBatch.Draw(_bZJtpWV2Yj6GgZkeZQUmpTHxTnh, new Vector2(_eeWHzOz6LrTokRQr52VaB0dKbQO.X, _eeWHzOz6LrTokRQr52VaB0dKbQO.Y), null, null, null, (float)_09rdYyvQzUwbdQbzRZF4vbpdUCO);
					}
					if (!_rASuGHWSFVWfkpwzF8wZd9bh3XN)
					{
						spriteBatch.Draw(_Pfaq6ajchxcqF6GecivHvHqQW6M, new Vector2(_eeWHzOz6LrTokRQr52VaB0dKbQO.X, _eeWHzOz6LrTokRQr52VaB0dKbQO.Y), null, null, null, (float)_09rdYyvQzUwbdQbzRZF4vbpdUCO);
					}
					if (!_97m6gVcwgWbLFyNUxI3P1KuD0Gn)
					{
						spriteBatch.Draw(_BphDC8XZceMl5rqVm5zdrD6meOf, new Vector2(_eeWHzOz6LrTokRQr52VaB0dKbQO.X, _eeWHzOz6LrTokRQr52VaB0dKbQO.Y), null, null, null, (float)_09rdYyvQzUwbdQbzRZF4vbpdUCO);
					}
					spriteBatch.End();
					skeletonMeshRenderer.Begin();
				}
				else if (string_0 == "Thumb")
				{
					if (!_1gXQH16lmsacxQMOpjFFqZSmjQl)
					{
						skeletonMeshRenderer.End();
						spriteBatch.Begin();
						spriteBatch.Draw(_Et7ViKuaneif1JVK3bifonUhKPR, new Vector2(_eeWHzOz6LrTokRQr52VaB0dKbQO.X - 16, _eeWHzOz6LrTokRQr52VaB0dKbQO.Y - 128), null, null, null, (float)_09rdYyvQzUwbdQbzRZF4vbpdUCO);
						spriteBatch.End();
						skeletonMeshRenderer.Begin();
					}
				}
				else if (!_1gXQH16lmsacxQMOpjFFqZSmjQl && _HzpuNgBJAQYObWMhiboQRiPGmvp.Contains(string_0))
				{
					return false;
				}
				return true;
			});
		}
		if (_indication != 0 && _game.Cutscene == null)
		{
			_lpMGMQZJYmHr6q9XBRwiM0Lse4N.Draw(skeletonMeshRenderer);
		}
	}
}
