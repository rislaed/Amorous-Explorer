using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Amorous.Engine.GUI;
using Amorous.Game.NPC;
using Amorous.Game.Scenes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Spine;
using Squid;

public class _poenyHBGUusBcnNcTFB9MQBV72R
{
	public enum _fFGgY4gvWNcTLSlsfe9k99ctumb
	{
		ArmDown,
		ArmUp,
		ArmDownRequested,
		ArmUpRequested
	}

	public enum _VQgRlkt1vazuo2KaxFIrSVwZOpL
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

	public enum _wlQdV74JhqkBVxNonpbfqZEmjIbA
	{
		None,
		NoMessage,
		MessageNew,
		MessageIdle,
		MessageUrgent
	}

	[CompilerGenerated]
	private sealed class _jacy9UYskskbRRyetoO92L4m4YS
	{
		public _opIJo2jLUqdOL5yAFP4yzXce0DG _7FpdmRzPrcoARiGqtJekOfu7KqP;

		public _poenyHBGUusBcnNcTFB9MQBV72R _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA;

		internal _6OmCduUGKgPqhBnqgfNJUOmDpZW<string, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts> _lhmZXB63LkYEraMbDSH9Fbn2Xkq(string string_0)
		{
			if (Enum.TryParse<_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts>(string_0, out var result))
			{
				if (!_7FpdmRzPrcoARiGqtJekOfu7KqP._4pE8Q2fYoSeltAUx7pxshukqsEb.HasFlag(result))
				{
					return null;
				}
				return new _6OmCduUGKgPqhBnqgfNJUOmDpZW<string, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts>(string_0, result);
			}
			return null;
		}

		static _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts smethod_0(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
		{
			return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._4pE8Q2fYoSeltAUx7pxshukqsEb;
		}

		static bool smethod_1(Enum enum_0, Enum enum_1)
		{
			return enum_0.HasFlag(enum_1);
		}
	}

	[CompilerGenerated]
	private sealed class _oX8XrNdNse9viFEqFUqJnYYOjaf
	{
		public CustomListBoxItem _4wrjSKvuvZUTRPI3prAOEvBGDhD;

		public _jacy9UYskskbRRyetoO92L4m4YS _wr6xcvFOgUbaTATC17S6Y9v3y3S;

		internal void _AaTfI7TkG87JNIfFQVbhclh2zPsA(Control control_0, MouseEventArgs mouseEventArgs_0)
		{
			_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._H6UwM4zjGzglzMY478iBDDvTk6I = (_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts)_4wrjSKvuvZUTRPI3prAOEvBGDhD.Value;
			_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.ContactsInformation);
		}

		static object smethod_0(CustomListBoxItem customListBoxItem_0)
		{
			return customListBoxItem_0.Value;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _rm4nO8SKFlFnD1XybaGLNsNLB5F
	{
		public static readonly _rm4nO8SKFlFnD1XybaGLNsNLB5F _003C_003E9 = new _rm4nO8SKFlFnD1XybaGLNsNLB5F();

		public static MouseEvent _003C_003E9__42_3;

		public static Func<_6OmCduUGKgPqhBnqgfNJUOmDpZW<string, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts>, bool> _003C_003E9__42_1;

		public static Func<_6OmCduUGKgPqhBnqgfNJUOmDpZW<string, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts>, string> _003C_003E9__42_2;

		public static Func<_KZ7hNP1K5E99Xfup1lTZ9UDrxPE._vNekDVpW2fr7UkjA16E9ifFmD9s, string> _003C_003E9__45_0;

		public static MouseEvent _003C_003E9__46_0;

		public static MouseEvent _003C_003E9__46_1;

		public static MouseEvent _003C_003E9__46_2;

		public static MouseEvent _003C_003E9__46_3;

		public static Func<_iDN1IKOu3e1uADYzeMEUon5D9fg, DateTime> _003C_003E9__47_0;

		public static Action<int> _003C_003E9__53_0;

		internal void _rn19MnDAv1j6Jtb1ql8m4aTPSvM(Control control_0, MouseEventArgs mouseEventArgs_0)
		{
			_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.ContactsInformationDJ);
		}

		internal bool _08bT8Wq9S9HnTRxOvZ9ilgeI4UF(_6OmCduUGKgPqhBnqgfNJUOmDpZW<string, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts> _6OmCduUGKgPqhBnqgfNJUOmDpZW_0)
		{
			return _6OmCduUGKgPqhBnqgfNJUOmDpZW_0 != null;
		}

		internal string _P81CKL7EtVKHeZMtk1qhB7SuYfv(_6OmCduUGKgPqhBnqgfNJUOmDpZW<string, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts> _6OmCduUGKgPqhBnqgfNJUOmDpZW_0)
		{
			return _6OmCduUGKgPqhBnqgfNJUOmDpZW_0.Name;
		}

		internal string _FIaLPMAEN9NHShUbWFWBtqjVT1G(_KZ7hNP1K5E99Xfup1lTZ9UDrxPE._vNekDVpW2fr7UkjA16E9ifFmD9s _vNekDVpW2fr7UkjA16E9ifFmD9s_0)
		{
			return _vNekDVpW2fr7UkjA16E9ifFmD9s_0._D5QiLGGNtfoCEnZIUPvH4OKqUabA;
		}

		internal void _mN56upo0hDhhrqbGVSic1GW7Vkh(Control control_0, MouseEventArgs mouseEventArgs_0)
		{
			_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.DiaryMessages);
		}

		internal void _w0vDNmjtS2Sza4jrTwZ711teXPS(Control control_0, MouseEventArgs mouseEventArgs_0)
		{
			_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.DiaryAchievements);
		}

		internal void _qWiseiEbxm1loSq6sRUADsV1Pzm(Control control_0, MouseEventArgs mouseEventArgs_0)
		{
			_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.DiarySave);
		}

		internal void _jL8wg7B3V5ezZ99QPQxatsiVC0g(Control control_0, MouseEventArgs mouseEventArgs_0)
		{
			_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.DiaryLoad);
		}

		internal DateTime _oZtEvbrswoDO0UkE8FUk5JRU3pc(_iDN1IKOu3e1uADYzeMEUon5D9fg _iDN1IKOu3e1uADYzeMEUon5D9fg_0)
		{
			return _iDN1IKOu3e1uADYzeMEUon5D9fg_0._QkxGXtWLzE0Z8JKyKkMiiph9giD;
		}

		internal void _4E0kOAGtUbieJZb6BjHd9pJpJJA(int int_0)
		{
			_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._wVLRBSMULz8GfedBPXaVJB0sBEO = (DialogueSpeed)int_0;
			_nkzqFdEfDyLcyGikIKGcHjklI4y._NhL238TaCbkDiY6HXlWXZzzUYkm = (DialogueSpeed)int_0;
		}

		static DateTime smethod_0(_iDN1IKOu3e1uADYzeMEUon5D9fg _iDN1IKOu3e1uADYzeMEUon5D9fg_0)
		{
			return _iDN1IKOu3e1uADYzeMEUon5D9fg_0._QkxGXtWLzE0Z8JKyKkMiiph9giD;
		}

		static _eNOTHZZiu5nx6PrADzfLyng3Igc smethod_1()
		{
			return _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF;
		}

		static void smethod_2(_eNOTHZZiu5nx6PrADzfLyng3Igc _eNOTHZZiu5nx6PrADzfLyng3Igc_0, DialogueSpeed dialogueSpeed_0)
		{
			_eNOTHZZiu5nx6PrADzfLyng3Igc_0._wVLRBSMULz8GfedBPXaVJB0sBEO = dialogueSpeed_0;
		}

		static void smethod_3(DialogueSpeed dialogueSpeed_0)
		{
			_nkzqFdEfDyLcyGikIKGcHjklI4y._NhL238TaCbkDiY6HXlWXZzzUYkm = dialogueSpeed_0;
		}
	}

	[CompilerGenerated]
	private sealed class _K3u7ViHsWHD7nMkxlJgXOyDYc0F
	{
		public string _nc2gJWKJm6yAMtppwpcfigGPFj3;

		public _poenyHBGUusBcnNcTFB9MQBV72R _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA;

		internal void _ScA3V9qpe4YmHu0ns3pGgvmss7D(Control control_0, MouseEventArgs mouseEventArgs_0)
		{
			_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._ZfxNkwQ3qvZWenbVYRs2XNSAF2c(_nc2gJWKJm6yAMtppwpcfigGPFj3);
		}
	}

	[CompilerGenerated]
	private sealed class _tdcogRALfEB0rsQ5m98f4c9BTIO
	{
		public _KZ7hNP1K5E99Xfup1lTZ9UDrxPE._vNekDVpW2fr7UkjA16E9ifFmD9s _a5X3xjbmM60JVR5AMk4qrTqgyJm;

		public _poenyHBGUusBcnNcTFB9MQBV72R _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA;

		internal void _XSAFkGFT0TzJpemKpRDtuTVce3(Control control_0, MouseEventArgs mouseEventArgs_0)
		{
			int num = _boyt8NIMtKsAGSTcjHeL0WMbFxs._07xTWbIEgzxJYsYwFKDbbKNvu4G(0, _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._OZU2jcD6pvGbls1ACzPQPKBf9ci.Length);
			_nkzqFdEfDyLcyGikIKGcHjklI4y._zunSyHn4DekdA6CngP10dXcR1kq(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._OZU2jcD6pvGbls1ACzPQPKBf9ci[num], ClubDJNPC._RB8fRXeQvK5vs7JEA0XfVCEpg1i, ClubDJNPC._9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA);
			_UmxbIbk7pgaod0bD7pS309P3Lns._QrgbXEg7MMeD9Ybz12fFVsbmAd9(_a5X3xjbmM60JVR5AMk4qrTqgyJm._XAtd16WmK4L37sBtMsLCIvJzIS1, 0.3f, bool_0: false);
			_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._4L7hfXrWoDdArQiscG4ukHCV46B._aJh9CibG5YKhkExxgRyVopdfSeJ._vVZVLriSGPExpn1KeobglMabsoi("AchievementGeneric3");
		}

		static int smethod_0(int int_0, int int_1)
		{
			return _boyt8NIMtKsAGSTcjHeL0WMbFxs._07xTWbIEgzxJYsYwFKDbbKNvu4G(int_0, int_1);
		}

		static void smethod_1(string string_0, string string_1, Color color_0)
		{
			_nkzqFdEfDyLcyGikIKGcHjklI4y._zunSyHn4DekdA6CngP10dXcR1kq(string_0, string_1, color_0);
		}

		static void smethod_2(string string_0, float float_0, bool bool_0)
		{
			_UmxbIbk7pgaod0bD7pS309P3Lns._QrgbXEg7MMeD9Ybz12fFVsbmAd9(string_0, float_0, bool_0);
		}

		static _691ooXdgg17CWFkMkjedKBBBfYw smethod_3(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		{
			return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._aJh9CibG5YKhkExxgRyVopdfSeJ;
		}

		static void smethod_4(_691ooXdgg17CWFkMkjedKBBBfYw _691ooXdgg17CWFkMkjedKBBBfYw_0, string string_0)
		{
			_691ooXdgg17CWFkMkjedKBBBfYw_0._vVZVLriSGPExpn1KeobglMabsoi(string_0);
		}
	}

	[CompilerGenerated]
	private sealed class _FnNGEJUaoVFTsE2HNBVI37kl4xb
	{
		public _iDN1IKOu3e1uADYzeMEUon5D9fg _qsRYa7wg9K5fRrgfqdfMwLILTrbA;

		public _poenyHBGUusBcnNcTFB9MQBV72R _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA;

		internal void _bjcbD5NLVYptjAIHRIrhD7CMa6N(Control control_0, MouseEventArgs mouseEventArgs_0)
		{
			_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._ERdtO3cV05TBYFV0mT86wv01GJf = _qsRYa7wg9K5fRrgfqdfMwLILTrbA;
			_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.DiaryMessagesInformation);
		}
	}

	[CompilerGenerated]
	private sealed class _7bXnkUo5ETqYLrtdisr6hKFAP6p
	{
		public _DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p _7OcRfli7CrlI9YYUDJj3j5nDI9k;

		public _poenyHBGUusBcnNcTFB9MQBV72R _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA;

		public Action<int> _tJbdAZlfIfFFpJS1sihbykE2o6aA;

		internal void _rweHC7vksYEfsLFnAIcms2JNpEP(Control control_0, MouseEventArgs mouseEventArgs_0)
		{
			if (_7OcRfli7CrlI9YYUDJj3j5nDI9k._r4LqoJiAr5K9UiLsUzUDbcJDQqo)
			{
				_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._4L7hfXrWoDdArQiscG4ukHCV46B._yh2DwZs16cvRtvGayeYZrMWlrbj(_7OcRfli7CrlI9YYUDJj3j5nDI9k._B3FsRMcQWBXzFf3nLOBKzncessO);
				_6T55wit7MiGfAWRkPwjNbJ8N8lG._DAsCL6JdGst3kJHpcbztigO3VEV();
				return;
			}
			_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3AaEmo54VzWybgrrg7I8Z9JUV1e = true;
			_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._9GQBAH2pi8Sm6ph1s6InjyQGe6R._GtkWDtXwQHwgWY4aFkacjfUDyzb($"Are you sure you wish to overwrite slot #{_7OcRfli7CrlI9YYUDJj3j5nDI9k._B3FsRMcQWBXzFf3nLOBKzncessO + 1}?", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, 250, delegate(int int_0)
			{
				if (int_0 == 1)
				{
					_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._4L7hfXrWoDdArQiscG4ukHCV46B._yh2DwZs16cvRtvGayeYZrMWlrbj(_7OcRfli7CrlI9YYUDJj3j5nDI9k._B3FsRMcQWBXzFf3nLOBKzncessO);
					_6T55wit7MiGfAWRkPwjNbJ8N8lG._DAsCL6JdGst3kJHpcbztigO3VEV();
				}
				_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
			});
		}

		internal void _gPLk9BoC0brpUF9aPYFBgDUXFsf(int int_0)
		{
			if (int_0 == 1)
			{
				_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._4L7hfXrWoDdArQiscG4ukHCV46B._yh2DwZs16cvRtvGayeYZrMWlrbj(_7OcRfli7CrlI9YYUDJj3j5nDI9k._B3FsRMcQWBXzFf3nLOBKzncessO);
				_6T55wit7MiGfAWRkPwjNbJ8N8lG._DAsCL6JdGst3kJHpcbztigO3VEV();
			}
			_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
		}

		static bool smethod_0(_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p _3CCr8Bt1rkuzt0M6gYLbceJGV0p_0)
		{
			return _3CCr8Bt1rkuzt0M6gYLbceJGV0p_0._r4LqoJiAr5K9UiLsUzUDbcJDQqo;
		}

		static int smethod_1(_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p _3CCr8Bt1rkuzt0M6gYLbceJGV0p_0)
		{
			return _3CCr8Bt1rkuzt0M6gYLbceJGV0p_0._B3FsRMcQWBXzFf3nLOBKzncessO;
		}

		static void smethod_2(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, int int_0)
		{
			_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._yh2DwZs16cvRtvGayeYZrMWlrbj(int_0);
		}

		static string smethod_3(string string_0, object object_0)
		{
			return string.Format(string_0, object_0);
		}

		static void smethod_4(Desktop desktop_0, string string_0, string[] string_1, int int_0, Action<int> action_0)
		{
			desktop_0._GtkWDtXwQHwgWY4aFkacjfUDyzb(string_0, string_1, int_0, action_0);
		}
	}

	[CompilerGenerated]
	private sealed class _2GLJdEpKkJ7x72M9J1r6gZaf9yp
	{
		public _DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p _7OcRfli7CrlI9YYUDJj3j5nDI9k;

		public _poenyHBGUusBcnNcTFB9MQBV72R _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA;

		public Action<int> _N0QkaWJJa2ooS7UE5tZBoKJaLDmA;

		internal void _iFbMqXNzbW1FirCMxq8kqe1A9Dx(Control control_0, MouseEventArgs mouseEventArgs_0)
		{
			if (!_7OcRfli7CrlI9YYUDJj3j5nDI9k._r4LqoJiAr5K9UiLsUzUDbcJDQqo)
			{
				_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3AaEmo54VzWybgrrg7I8Z9JUV1e = true;
				_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._9GQBAH2pi8Sm6ph1s6InjyQGe6R._GtkWDtXwQHwgWY4aFkacjfUDyzb(string.Format("Are you sure you wish to load {0}slot #{1}?", (!_7OcRfli7CrlI9YYUDJj3j5nDI9k._3y7m8OGVjMe7WGIhZ66YOw3ITUE) ? string.Empty : "autosave ", _7OcRfli7CrlI9YYUDJj3j5nDI9k._B3FsRMcQWBXzFf3nLOBKzncessO + 1), new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, 250, delegate(int int_0)
				{
					if (int_0 == 1)
					{
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._77rSPCEs6VEYjlGrwW0KN0btLEG = true;
						if (_7OcRfli7CrlI9YYUDJj3j5nDI9k._3y7m8OGVjMe7WGIhZ66YOw3ITUE ? _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._4L7hfXrWoDdArQiscG4ukHCV46B._1yDW5GeZ2MCcssz8ohrF9CK913i(_7OcRfli7CrlI9YYUDJj3j5nDI9k._B3FsRMcQWBXzFf3nLOBKzncessO) : _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._4L7hfXrWoDdArQiscG4ukHCV46B._Ut0dhlh4JTZBMNJPNxxI9f9VqTp(_7OcRfli7CrlI9YYUDJj3j5nDI9k._B3FsRMcQWBXzFf3nLOBKzncessO))
						{
							_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._77rSPCEs6VEYjlGrwW0KN0btLEG = false;
							_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
							_RiDuYMeg3EHnBUteUcAb8VlfQVl();
						}
						else
						{
							_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._9GQBAH2pi8Sm6ph1s6InjyQGe6R._0pVU36wp9GYD1jM18raZtVEbA9q("Failed to load save, it's most likely corrupted.", 250, "OK", delegate
							{
								_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._77rSPCEs6VEYjlGrwW0KN0btLEG = false;
								_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
							});
						}
					}
					else
					{
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
					}
				});
			}
			else
			{
				_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3AaEmo54VzWybgrrg7I8Z9JUV1e = true;
				_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._9GQBAH2pi8Sm6ph1s6InjyQGe6R._0pVU36wp9GYD1jM18raZtVEbA9q(string.Format("There is no save in {0}slot #{1}!", _7OcRfli7CrlI9YYUDJj3j5nDI9k._3y7m8OGVjMe7WGIhZ66YOw3ITUE ? "autosave " : string.Empty, _7OcRfli7CrlI9YYUDJj3j5nDI9k._B3FsRMcQWBXzFf3nLOBKzncessO + 1), 250, "OK", delegate
				{
					_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
				});
			}
		}

		internal void _8RPKM2hyJWlk66jtUUwuyCt2FlF(int int_0)
		{
			if (int_0 == 1)
			{
				_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._77rSPCEs6VEYjlGrwW0KN0btLEG = true;
				if (_7OcRfli7CrlI9YYUDJj3j5nDI9k._3y7m8OGVjMe7WGIhZ66YOw3ITUE ? _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._4L7hfXrWoDdArQiscG4ukHCV46B._1yDW5GeZ2MCcssz8ohrF9CK913i(_7OcRfli7CrlI9YYUDJj3j5nDI9k._B3FsRMcQWBXzFf3nLOBKzncessO) : _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._4L7hfXrWoDdArQiscG4ukHCV46B._Ut0dhlh4JTZBMNJPNxxI9f9VqTp(_7OcRfli7CrlI9YYUDJj3j5nDI9k._B3FsRMcQWBXzFf3nLOBKzncessO))
				{
					_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._77rSPCEs6VEYjlGrwW0KN0btLEG = false;
					_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
					_RiDuYMeg3EHnBUteUcAb8VlfQVl();
				}
				else
				{
					_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._9GQBAH2pi8Sm6ph1s6InjyQGe6R._0pVU36wp9GYD1jM18raZtVEbA9q("Failed to load save, it's most likely corrupted.", 250, "OK", delegate
					{
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._77rSPCEs6VEYjlGrwW0KN0btLEG = false;
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
					});
				}
			}
			else
			{
				_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
			}
		}

		static bool smethod_0(_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p _3CCr8Bt1rkuzt0M6gYLbceJGV0p_0)
		{
			return _3CCr8Bt1rkuzt0M6gYLbceJGV0p_0._r4LqoJiAr5K9UiLsUzUDbcJDQqo;
		}

		static bool smethod_1(_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p _3CCr8Bt1rkuzt0M6gYLbceJGV0p_0)
		{
			return _3CCr8Bt1rkuzt0M6gYLbceJGV0p_0._3y7m8OGVjMe7WGIhZ66YOw3ITUE;
		}

		static int smethod_2(_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p _3CCr8Bt1rkuzt0M6gYLbceJGV0p_0)
		{
			return _3CCr8Bt1rkuzt0M6gYLbceJGV0p_0._B3FsRMcQWBXzFf3nLOBKzncessO;
		}

		static string smethod_3(string string_0, object object_0, object object_1)
		{
			return string.Format(string_0, object_0, object_1);
		}

		static void smethod_4(Desktop desktop_0, string string_0, int int_0, string string_1, Action action_0)
		{
			desktop_0._0pVU36wp9GYD1jM18raZtVEbA9q(string_0, int_0, string_1, action_0);
		}

		static void smethod_5(Desktop desktop_0, string string_0, string[] string_1, int int_0, Action<int> action_0)
		{
			desktop_0._GtkWDtXwQHwgWY4aFkacjfUDyzb(string_0, string_1, int_0, action_0);
		}

		static bool smethod_6(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, int int_0)
		{
			return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._1yDW5GeZ2MCcssz8ohrF9CK913i(int_0);
		}

		static bool smethod_7(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, int int_0)
		{
			return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._Ut0dhlh4JTZBMNJPNxxI9f9VqTp(int_0);
		}
	}

	[CompilerGenerated]
	private sealed class _ws6FjNlgAT4bj3C6lODSIPTi5Tj
	{
		public Slider _XEgAfmv7sJWJSaC2diC3eaD4Fgl;

		public Slider _gjeIIVx9bHyd0aMj0WD483nrLWK;

		public Slider _5mK9ExiyKm0md8q4J1C6xc4TzdF;

		internal void _iM362xHWsa4PDxtHMRCT02E3RCn(Control control_0)
		{
			_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._DF24JUrPFA6rJ2cQrOTlpC3I4FF = _XEgAfmv7sJWJSaC2diC3eaD4Fgl.Value / 100f;
		}

		internal void _do82cy4M3hWWZrTatQMCPffcAPaA(Control control_0)
		{
			_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._7NidKjx61ui5CP7JojwfqxH4aKC = _gjeIIVx9bHyd0aMj0WD483nrLWK.Value / 100f;
		}

		internal void _at091i3KPJkfwydSTUXr7ajv7mF(Control control_0)
		{
			_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._2g4Ch8GXdUt0oEbdCZUY2QMbIuH = _5mK9ExiyKm0md8q4J1C6xc4TzdF.Value / 100f;
		}

		static _eNOTHZZiu5nx6PrADzfLyng3Igc smethod_0()
		{
			return _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF;
		}

		static float smethod_1(Slider slider_0)
		{
			return slider_0.Value;
		}

		static void smethod_2(_eNOTHZZiu5nx6PrADzfLyng3Igc _eNOTHZZiu5nx6PrADzfLyng3Igc_0, float float_0)
		{
			_eNOTHZZiu5nx6PrADzfLyng3Igc_0._DF24JUrPFA6rJ2cQrOTlpC3I4FF = float_0;
		}

		static void smethod_3(_eNOTHZZiu5nx6PrADzfLyng3Igc _eNOTHZZiu5nx6PrADzfLyng3Igc_0, float float_0)
		{
			_eNOTHZZiu5nx6PrADzfLyng3Igc_0._7NidKjx61ui5CP7JojwfqxH4aKC = float_0;
		}

		static void smethod_4(_eNOTHZZiu5nx6PrADzfLyng3Igc _eNOTHZZiu5nx6PrADzfLyng3Igc_0, float float_0)
		{
			_eNOTHZZiu5nx6PrADzfLyng3Igc_0._2g4Ch8GXdUt0oEbdCZUY2QMbIuH = float_0;
		}
	}

	[CompilerGenerated]
	private sealed class _AjJaaxdjRceHdvoz1idKTUfAsPQ
	{
		public CheckBox _feL3soNn6ZWaJqYfjYJUyH118tF;

		internal void _ZMECtVXwi0O0sCYqyVg4Ae3ElpC(Control control_0)
		{
			_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._sbK0941BvW8HgPboNwOhIAd2jP3 = _feL3soNn6ZWaJqYfjYJUyH118tF.Checked;
			_nkzqFdEfDyLcyGikIKGcHjklI4y._fUgDiz7KX8TZUVzFlTeXMOhmfUT = _feL3soNn6ZWaJqYfjYJUyH118tF.Checked;
		}

		static _eNOTHZZiu5nx6PrADzfLyng3Igc smethod_0()
		{
			return _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF;
		}

		static bool smethod_1(CheckBox checkBox_0)
		{
			return checkBox_0.Checked;
		}

		static void smethod_2(_eNOTHZZiu5nx6PrADzfLyng3Igc _eNOTHZZiu5nx6PrADzfLyng3Igc_0, bool bool_0)
		{
			_eNOTHZZiu5nx6PrADzfLyng3Igc_0._sbK0941BvW8HgPboNwOhIAd2jP3 = bool_0;
		}

		static void smethod_3(bool bool_0)
		{
			_nkzqFdEfDyLcyGikIKGcHjklI4y._fUgDiz7KX8TZUVzFlTeXMOhmfUT = bool_0;
		}
	}

	[CompilerGenerated]
	private sealed class _4eBWC5cHwnSO1ZNylbprsv5CLKt
	{
		public Action<int> _qhAM4Wrvf8c5jzKBQqLfosAE9D;

		internal void _mOpBqOvaaBBb8rA5FkEv64hQhu4B(Control control_0, ListBoxItem listBoxItem_0)
		{
			_qhAM4Wrvf8c5jzKBQqLfosAE9D((int)listBoxItem_0.Value);
		}

		static object smethod_0(ListBoxItem listBoxItem_0)
		{
			return listBoxItem_0.Value;
		}
	}

	[CompilerGenerated]
	private sealed class _ySEG6XuZVhXoWbL0fJc0sGefKrh
	{
		public ListBoxItem _diVdxVCKW4CzhbYSG15BcHJB0Ub;

		public _poenyHBGUusBcnNcTFB9MQBV72R _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA;

		public Action _BKpFWtpbS6st7cDbJipkpAaFUYs;

		internal void _ISRRzLG00yCyBtR4sMqlaCKpvCH(Control control_0, MouseEventArgs mouseEventArgs_0)
		{
			_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._YdyKdWT8QbQOIWkgEuPe6a9hJtd(delegate
			{
				_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF = !_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF;
				_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._DAsCL6JdGst3kJHpcbztigO3VEV();
				_diVdxVCKW4CzhbYSG15BcHJB0Ub.Text = (_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF ? "Disable SFW" : "Enable SFW");
			});
		}

		internal void _8nn4N2xgzjlh5Yz5WSSHCJ9URjf()
		{
			_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF = !_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF;
			_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._DAsCL6JdGst3kJHpcbztigO3VEV();
			_diVdxVCKW4CzhbYSG15BcHJB0Ub.Text = (_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF ? "Disable SFW" : "Enable SFW");
		}

		static bool smethod_0()
		{
			return _iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF;
		}

		static void smethod_1(bool bool_0)
		{
			_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF = bool_0;
		}

		static void smethod_2(Label label_0, string string_0)
		{
			label_0.Text = string_0;
		}
	}

	[CompilerGenerated]
	private sealed class _0nFvyop0acDTSu0pbg4xnLHeOi
	{
		public _poenyHBGUusBcnNcTFB9MQBV72R _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA;

		public Action _qhAM4Wrvf8c5jzKBQqLfosAE9D;

		internal void _pOh9OU2GSXXwYSu9n87g2e0XnUF()
		{
			_Xz9JDCJHGCV62mEFcQGw4HJ6Lgn CS_0024_003C_003E8__locals0 = new _Xz9JDCJHGCV62mEFcQGw4HJ6Lgn
			{
				_wr6xcvFOgUbaTATC17S6Y9v3y3S = this,
				_nc2gJWKJm6yAMtppwpcfigGPFj3 = _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._4L7hfXrWoDdArQiscG4ukHCV46B._KVSwpLj0RvURRswHn7ogRy4BRfd?.GetType().Name
			};
			if (CS_0024_003C_003E8__locals0._nc2gJWKJm6yAMtppwpcfigGPFj3 != null)
			{
				_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._4L7hfXrWoDdArQiscG4ukHCV46B._Ec0fhBrUGmjaIKjUfJioigVc65x();
			}
			_qhAM4Wrvf8c5jzKBQqLfosAE9D();
			_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._4L7hfXrWoDdArQiscG4ukHCV46B._OxLRmpxixplTKChiTPUKAx4uTLG(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._4L7hfXrWoDdArQiscG4ukHCV46B._XbOXR6AypLIdJ3gBMGseGi3Wi2i.GetType().Name, delegate
			{
				if (CS_0024_003C_003E8__locals0._nc2gJWKJm6yAMtppwpcfigGPFj3 != null)
				{
					CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._4L7hfXrWoDdArQiscG4ukHCV46B._gYGB98heFqsLp9tgJbdCP01IKV2(CS_0024_003C_003E8__locals0._nc2gJWKJm6yAMtppwpcfigGPFj3);
				}
				CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._4L7hfXrWoDdArQiscG4ukHCV46B._Qj2G6fpAF4mGsATgkV8DPBF3aA1A._FegL010tc92iskjjyD0T33dDwNE();
			});
		}

		static _TwlwMC1hhdSzamwGWEBxuUkz1gH smethod_0(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		{
			return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._KVSwpLj0RvURRswHn7ogRy4BRfd;
		}

		static Type smethod_1(object object_0)
		{
			return object_0.GetType();
		}

		static string smethod_2(MemberInfo memberInfo_0)
		{
			return memberInfo_0.Name;
		}

		static void smethod_3(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		{
			_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._Ec0fhBrUGmjaIKjUfJioigVc65x();
		}

		static _7UlnfykmEmZDFt3BmCKZekI43Ih smethod_4(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		{
			return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._XbOXR6AypLIdJ3gBMGseGi3Wi2i;
		}

		static Type smethod_5(object object_0)
		{
			return object_0.GetType();
		}

		static void smethod_6(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, string string_0, Action action_0)
		{
			_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._OxLRmpxixplTKChiTPUKAx4uTLG(string_0, action_0);
		}
	}

	[CompilerGenerated]
	private sealed class _Xz9JDCJHGCV62mEFcQGw4HJ6Lgn
	{
		public string _nc2gJWKJm6yAMtppwpcfigGPFj3;

		public _0nFvyop0acDTSu0pbg4xnLHeOi _wr6xcvFOgUbaTATC17S6Y9v3y3S;

		internal void _QplcvqySL1OvfTiJ4lDnkpvChEA()
		{
			if (_nc2gJWKJm6yAMtppwpcfigGPFj3 != null)
			{
				_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._4L7hfXrWoDdArQiscG4ukHCV46B._gYGB98heFqsLp9tgJbdCP01IKV2(_nc2gJWKJm6yAMtppwpcfigGPFj3);
			}
			_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._4L7hfXrWoDdArQiscG4ukHCV46B._Qj2G6fpAF4mGsATgkV8DPBF3aA1A._FegL010tc92iskjjyD0T33dDwNE();
		}

		static void smethod_0(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, string string_0)
		{
			_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._gYGB98heFqsLp9tgJbdCP01IKV2(string_0);
		}

		static _gJR4g7ak0hsZAUWX1vJbMqG2P5I smethod_1(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		{
			return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._Qj2G6fpAF4mGsATgkV8DPBF3aA1A;
		}

		static void smethod_2(_gJR4g7ak0hsZAUWX1vJbMqG2P5I _gJR4g7ak0hsZAUWX1vJbMqG2P5I_0, Action action_0)
		{
			_gJR4g7ak0hsZAUWX1vJbMqG2P5I_0._FegL010tc92iskjjyD0T33dDwNE(action_0);
		}
	}

	[CompilerGenerated]
	private sealed class _J2cDcMayMidSIab2lnReI8upBwS
	{
		public _poenyHBGUusBcnNcTFB9MQBV72R _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA;

		public ListBoxItem _Epeel2m9h5O12V2ERwlnNTE3FdM;

		public ListBoxItem _FxyX2MMMdsf69424VDXa8LqP1nq;

		public Action _N0QkaWJJa2ooS7UE5tZBoKJaLDmA;

		public Action _BKpFWtpbS6st7cDbJipkpAaFUYs;

		internal void _SUfs5h4nIs2LOLgX7SPxpt8OcMJ(Control control_0, MouseEventArgs mouseEventArgs_0)
		{
			_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._YdyKdWT8QbQOIWkgEuPe6a9hJtd(delegate
			{
				_iExD93IWLlzVfXsU9wyrEvWgJsg._b52DDz3MN1kD8sgdQhCNO1tJRNn = !_iExD93IWLlzVfXsU9wyrEvWgJsg._b52DDz3MN1kD8sgdQhCNO1tJRNn;
				_Epeel2m9h5O12V2ERwlnNTE3FdM.Text = (_iExD93IWLlzVfXsU9wyrEvWgJsg._b52DDz3MN1kD8sgdQhCNO1tJRNn ? "Disable Topless Cheat" : "Enable Topless Cheat");
			});
		}

		internal void _SIpzzpgYIDeDw3DbVv5Fv9S6iOg()
		{
			_iExD93IWLlzVfXsU9wyrEvWgJsg._b52DDz3MN1kD8sgdQhCNO1tJRNn = !_iExD93IWLlzVfXsU9wyrEvWgJsg._b52DDz3MN1kD8sgdQhCNO1tJRNn;
			_Epeel2m9h5O12V2ERwlnNTE3FdM.Text = (_iExD93IWLlzVfXsU9wyrEvWgJsg._b52DDz3MN1kD8sgdQhCNO1tJRNn ? "Disable Topless Cheat" : "Enable Topless Cheat");
		}

		internal void _8n73s4MCzZ9OGqXivRGVyT81BNJ(Control control_0, MouseEventArgs mouseEventArgs_0)
		{
			_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._YdyKdWT8QbQOIWkgEuPe6a9hJtd(delegate
			{
				_iExD93IWLlzVfXsU9wyrEvWgJsg._pKBiGAgDu5WqoykkGBaEGnP7oMj = !_iExD93IWLlzVfXsU9wyrEvWgJsg._pKBiGAgDu5WqoykkGBaEGnP7oMj;
				_FxyX2MMMdsf69424VDXa8LqP1nq.Text = (_iExD93IWLlzVfXsU9wyrEvWgJsg._pKBiGAgDu5WqoykkGBaEGnP7oMj ? "Disable Bottomless Cheat" : "Enable Bottomless Cheat");
			});
		}

		internal void _vsOcQWBxGADsTpFI7jsoDDsob3A()
		{
			_iExD93IWLlzVfXsU9wyrEvWgJsg._pKBiGAgDu5WqoykkGBaEGnP7oMj = !_iExD93IWLlzVfXsU9wyrEvWgJsg._pKBiGAgDu5WqoykkGBaEGnP7oMj;
			_FxyX2MMMdsf69424VDXa8LqP1nq.Text = (_iExD93IWLlzVfXsU9wyrEvWgJsg._pKBiGAgDu5WqoykkGBaEGnP7oMj ? "Disable Bottomless Cheat" : "Enable Bottomless Cheat");
		}

		static bool smethod_0()
		{
			return _iExD93IWLlzVfXsU9wyrEvWgJsg._b52DDz3MN1kD8sgdQhCNO1tJRNn;
		}

		static void smethod_1(bool bool_0)
		{
			_iExD93IWLlzVfXsU9wyrEvWgJsg._b52DDz3MN1kD8sgdQhCNO1tJRNn = bool_0;
		}

		static void smethod_2(Label label_0, string string_0)
		{
			label_0.Text = string_0;
		}

		static bool smethod_3()
		{
			return _iExD93IWLlzVfXsU9wyrEvWgJsg._pKBiGAgDu5WqoykkGBaEGnP7oMj;
		}

		static void smethod_4(bool bool_0)
		{
			_iExD93IWLlzVfXsU9wyrEvWgJsg._pKBiGAgDu5WqoykkGBaEGnP7oMj = bool_0;
		}
	}

	[CompilerGenerated]
	private sealed class _7ogzNGSGXiMOYh3BcasDaqG9WpT
	{
		public _poenyHBGUusBcnNcTFB9MQBV72R _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA;

		public SkeletonMeshRenderer _r1FADOtDcwMP4Tohv3ntBfhuMNp;

		public SpriteBatch _EKVVcDQFi8O0uiXnuvUCgwRPdh4;

		internal bool _WT05qMDwPiA46oYIu8bTOfYa5eF(int int_0, string string_0)
		{
			if (_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._PcaKA8lfkZnYKjOTdM7RWYPBlGr.ContainsKey(string_0))
			{
				return _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._PcaKA8lfkZnYKjOTdM7RWYPBlGr[string_0];
			}
			if (_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._0OvMkQYTGPrNhckv6iHt3zmR5ni.ContainsKey(string_0))
			{
				return _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._0OvMkQYTGPrNhckv6iHt3zmR5ni[string_0];
			}
			return true;
		}
	}

	[CompilerGenerated]
	private sealed class _HQitgQ0mYB5XukcD7eKHBJPmdqs
	{
		public Microsoft.Xna.Framework.Point _eeWHzOz6LrTokRQr52VaB0dKbQO;

		public double _09rdYyvQzUwbdQbzRZF4vbpdUCO;

		public _7ogzNGSGXiMOYh3BcasDaqG9WpT _wr6xcvFOgUbaTATC17S6Y9v3y3S;

		internal bool _J03dD2qBGOpQ04m2KKxkL3CkUtCb(int int_0, string string_0)
		{
			if (string_0 == "Sheen Two")
			{
				_wr6xcvFOgUbaTATC17S6Y9v3y3S._r1FADOtDcwMP4Tohv3ntBfhuMNp.End();
				_wr6xcvFOgUbaTATC17S6Y9v3y3S._EKVVcDQFi8O0uiXnuvUCgwRPdh4.Begin();
				if (!_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Ldzm1JY9st4tknAhrglOIpwdYhn)
				{
					_wr6xcvFOgUbaTATC17S6Y9v3y3S._EKVVcDQFi8O0uiXnuvUCgwRPdh4._f5ctqAmdNsZ889UjM4LxDm8WGxA(_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._bZJtpWV2Yj6GgZkeZQUmpTHxTnh, new Vector2(_eeWHzOz6LrTokRQr52VaB0dKbQO.X, _eeWHzOz6LrTokRQr52VaB0dKbQO.Y), null, null, null, (float)_09rdYyvQzUwbdQbzRZF4vbpdUCO);
				}
				if (!_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._rASuGHWSFVWfkpwzF8wZd9bh3XN)
				{
					_wr6xcvFOgUbaTATC17S6Y9v3y3S._EKVVcDQFi8O0uiXnuvUCgwRPdh4._f5ctqAmdNsZ889UjM4LxDm8WGxA(_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Pfaq6ajchxcqF6GecivHvHqQW6M, new Vector2(_eeWHzOz6LrTokRQr52VaB0dKbQO.X, _eeWHzOz6LrTokRQr52VaB0dKbQO.Y), null, null, null, (float)_09rdYyvQzUwbdQbzRZF4vbpdUCO);
				}
				if (!_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._97m6gVcwgWbLFyNUxI3P1KuD0Gn)
				{
					_wr6xcvFOgUbaTATC17S6Y9v3y3S._EKVVcDQFi8O0uiXnuvUCgwRPdh4._f5ctqAmdNsZ889UjM4LxDm8WGxA(_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._BphDC8XZceMl5rqVm5zdrD6meOf, new Vector2(_eeWHzOz6LrTokRQr52VaB0dKbQO.X, _eeWHzOz6LrTokRQr52VaB0dKbQO.Y), null, null, null, (float)_09rdYyvQzUwbdQbzRZF4vbpdUCO);
				}
				_wr6xcvFOgUbaTATC17S6Y9v3y3S._EKVVcDQFi8O0uiXnuvUCgwRPdh4.End();
				_wr6xcvFOgUbaTATC17S6Y9v3y3S._r1FADOtDcwMP4Tohv3ntBfhuMNp.Begin();
			}
			else if (string_0 == "Thumb")
			{
				if (!_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._1gXQH16lmsacxQMOpjFFqZSmjQl)
				{
					_wr6xcvFOgUbaTATC17S6Y9v3y3S._r1FADOtDcwMP4Tohv3ntBfhuMNp.End();
					_wr6xcvFOgUbaTATC17S6Y9v3y3S._EKVVcDQFi8O0uiXnuvUCgwRPdh4.Begin();
					_wr6xcvFOgUbaTATC17S6Y9v3y3S._EKVVcDQFi8O0uiXnuvUCgwRPdh4._f5ctqAmdNsZ889UjM4LxDm8WGxA(_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Et7ViKuaneif1JVK3bifonUhKPR, new Vector2(_eeWHzOz6LrTokRQr52VaB0dKbQO.X - 16, _eeWHzOz6LrTokRQr52VaB0dKbQO.Y - 128), null, null, null, (float)_09rdYyvQzUwbdQbzRZF4vbpdUCO);
					_wr6xcvFOgUbaTATC17S6Y9v3y3S._EKVVcDQFi8O0uiXnuvUCgwRPdh4.End();
					_wr6xcvFOgUbaTATC17S6Y9v3y3S._r1FADOtDcwMP4Tohv3ntBfhuMNp.Begin();
				}
			}
			else if (!_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._1gXQH16lmsacxQMOpjFFqZSmjQl && _HzpuNgBJAQYObWMhiboQRiPGmvp.Contains(string_0))
			{
				return false;
			}
			return true;
		}

		static bool smethod_0(string string_0, string string_1)
		{
			return string_0 == string_1;
		}

		static void smethod_1(SkeletonMeshRenderer skeletonMeshRenderer_0)
		{
			skeletonMeshRenderer_0.End();
		}

		static void smethod_2(SpriteBatch spriteBatch_0)
		{
			spriteBatch_0.Begin();
		}
	}

	private bool _0IwNM2MxOUN4RsEqXREAdDRe4Ad;

	private bool _77rSPCEs6VEYjlGrwW0KN0btLEG;

	private readonly Dictionary<_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts, Squid.Rectangle> _kALYOlSwbvFyd9uFqFZW8Y2IsnL = new Dictionary<_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts, Squid.Rectangle>
	{
		{
			_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Coby,
			new Squid.Rectangle(275, 189, 268, 158)
		},
		{
			_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Dustin,
			new Squid.Rectangle(547, 351, 268, 158)
		},
		{
			_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Jax,
			new Squid.Rectangle(819, 189, 268, 158)
		},
		{
			_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Lex,
			new Squid.Rectangle(275, 351, 268, 158)
		},
		{
			_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Mercy,
			new Squid.Rectangle(1091, 351, 268, 158)
		},
		{
			_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Remy,
			new Squid.Rectangle(1091, 189, 268, 158)
		},
		{
			_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Seth,
			new Squid.Rectangle(1363, 351, 268, 158)
		},
		{
			_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Skye,
			new Squid.Rectangle(1363, 189, 268, 158)
		},
		{
			_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Zenith,
			new Squid.Rectangle(1635, 189, 268, 158)
		}
	};

	private readonly Dictionary<_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts, string> _iVvswmrDLetaWXmgd38sJtDnLs = new Dictionary<_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts, string>
	{
		{
			_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Coby,
			"CobySexscene"
		},
		{
			_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Dustin,
			"DustinSexscene"
		},
		{
			_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Jax,
			"JaxSexscene"
		},
		{
			_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Lex,
			"LexSexscene"
		},
		{
			_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Mercy,
			"MercySexscene"
		},
		{
			_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Remy,
			"RemySexscene"
		},
		{
			_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Seth,
			"SethSexscene"
		},
		{
			_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Skye,
			"SkyeSexscene"
		},
		{
			_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Zenith,
			"ZenithSexscene"
		}
	};

	private _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts _H6UwM4zjGzglzMY478iBDDvTk6I;

	private _iDN1IKOu3e1uADYzeMEUon5D9fg _ERdtO3cV05TBYFV0mT86wv01GJf;

	private readonly string[] _OZU2jcD6pvGbls1ACzPQPKBf9ci = new string[5] { "That song is awesome!", "This one is so underrated!", "Haven't heard that one in a while!", "Always gives me goosebumbs!", "The beat in this one is just amazing!" };

	private static _poenyHBGUusBcnNcTFB9MQBV72R _6T55wit7MiGfAWRkPwjNbJ8N8lG;

	private readonly _JbeCmOie0phb2cbgG6DdGZrbs3pB _4L7hfXrWoDdArQiscG4ukHCV46B;

	private readonly _nHdiyIURlAiaNZ8u6MKzxjcwnyL _hrw3Kf8fCx7saJOmoYUD8sIz3uD;

	private readonly _nHdiyIURlAiaNZ8u6MKzxjcwnyL _lpMGMQZJYmHr6q9XBRwiM0Lse4N;

	private readonly _nHdiyIURlAiaNZ8u6MKzxjcwnyL _wTbB4YBL4PSkaotwKX3CFc50DmX;

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

	private _wlQdV74JhqkBVxNonpbfqZEmjIbA _2xrvCNtGtRPjKFYKw9nbGLrJCPy;

	private bool _TZx1AkahTLXoM2XUbm5U8YJOScb;

	private bool _WaCCr2ToiTDglrrE9z1EKOcLzT3;

	private bool _p4cbe03cXPNybrHUo9DHRTp6W7m;

	private static readonly string[] _MCqah9fRROAHE2fkIv4nkhrpDKX = new string[6] { "Marlboro", "Angry Curds", "God of Warfare Modern War", "Inanimate 3", "The Blinding of Blissac", "Traffic Controller" };

	private static readonly string[] _I35ziY7HYJkfL20RDXWOC7Pcv1q = new string[4] { "Nude1", "Nude2", "Nude3", "Nude4" };

	private static readonly string[] _HzpuNgBJAQYObWMhiboQRiPGmvp = new string[4] { "Pinky Nail", "Ring Nail", "Rude Nail", "Index Nail" };

	private readonly Desktop _9GQBAH2pi8Sm6ph1s6InjyQGe6R;

	private readonly RenderTarget2D _bZJtpWV2Yj6GgZkeZQUmpTHxTnh;

	private readonly RenderTarget2D _Pfaq6ajchxcqF6GecivHvHqQW6M;

	private Texture2D _Et7ViKuaneif1JVK3bifonUhKPR;

	private Texture2D _BphDC8XZceMl5rqVm5zdrD6meOf;

	private bool _3AaEmo54VzWybgrrg7I8Z9JUV1e;

	private bool _Ldzm1JY9st4tknAhrglOIpwdYhn;

	private bool _rASuGHWSFVWfkpwzF8wZd9bh3XN;

	private bool _1gXQH16lmsacxQMOpjFFqZSmjQl;

	private bool _97m6gVcwgWbLFyNUxI3P1KuD0Gn;

	private int _WLqMMhDU6lDWhPjohexo40VadrB;

	private int _j2EdRylzMDum240gfhMGkyqki8j;

	private static _VQgRlkt1vazuo2KaxFIrSVwZOpL _saaJnL0DI6B89XWRulJZ4KC1I1g;

	private static Stack<_VQgRlkt1vazuo2KaxFIrSVwZOpL> _VQDLuxMbrizDwdFWvZoaPpO7Y0o;

	private static bool _kodtINvkfS2a7kqthXOxN1a4Rth;

	private const float _XZ6CI8QCng8abgquVxSXOv4i23R = 1000f;

	private const float _JYt24QSyYBPAaWNdDRYrzI5xy36 = 5000f;

	private bool _flEA1zdf7DHRkPwzrlsWVEAXZiX;

	private float _rLwDc2UH4fLL9at0M4SCKf0SG8cA = 1f;

	private bool _tIOoXRaaichIzSVUOs5dNLciPbw;

	public _fFGgY4gvWNcTLSlsfe9k99ctumb _j2OEvLQtM2lODSmH3ZFP6wWCWpF { get; private set; }

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
				_f2smFxmYyFJyj81xWGaGLB2G7ef = _wlQdV74JhqkBVxNonpbfqZEmjIbA.None;
			}
			else
			{
				_f2smFxmYyFJyj81xWGaGLB2G7ef = _wlQdV74JhqkBVxNonpbfqZEmjIbA.NoMessage;
			}
		}
	}

	public static _wlQdV74JhqkBVxNonpbfqZEmjIbA _f2smFxmYyFJyj81xWGaGLB2G7ef
	{
		get
		{
			return _6T55wit7MiGfAWRkPwjNbJ8N8lG._2xrvCNtGtRPjKFYKw9nbGLrJCPy;
		}
		set
		{
			if (value != _6T55wit7MiGfAWRkPwjNbJ8N8lG._2xrvCNtGtRPjKFYKw9nbGLrJCPy)
			{
				_6T55wit7MiGfAWRkPwjNbJ8N8lG._2xrvCNtGtRPjKFYKw9nbGLrJCPy = value;
				switch (value)
				{
				case _wlQdV74JhqkBVxNonpbfqZEmjIbA.NoMessage:
					_6T55wit7MiGfAWRkPwjNbJ8N8lG._lpMGMQZJYmHr6q9XBRwiM0Lse4N._C5vPbZ72rpVMDWGuHxZuR5FNpAH("No message");
					_6T55wit7MiGfAWRkPwjNbJ8N8lG._IiWYS6YP6cEj83PIAXepbAHBaJB();
					break;
				case _wlQdV74JhqkBVxNonpbfqZEmjIbA.MessageNew:
					_6T55wit7MiGfAWRkPwjNbJ8N8lG._lpMGMQZJYmHr6q9XBRwiM0Lse4N._C5vPbZ72rpVMDWGuHxZuR5FNpAH("Message new");
					break;
				case _wlQdV74JhqkBVxNonpbfqZEmjIbA.MessageIdle:
					_6T55wit7MiGfAWRkPwjNbJ8N8lG._lpMGMQZJYmHr6q9XBRwiM0Lse4N._C5vPbZ72rpVMDWGuHxZuR5FNpAH("Message idle");
					break;
				case _wlQdV74JhqkBVxNonpbfqZEmjIbA.MessageUrgent:
					_6T55wit7MiGfAWRkPwjNbJ8N8lG._lpMGMQZJYmHr6q9XBRwiM0Lse4N._C5vPbZ72rpVMDWGuHxZuR5FNpAH("Urgent message");
					break;
				}
			}
		}
	}

	public void _74zyK2mDlnXqbPqFXMVn07h7ifH(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts ephoneContacts_0)
	{
		_3mKo17hkpGwyDp6sHVZAhV1c6Qv(ephoneContacts_0);
		_wTbB4YBL4PSkaotwKX3CFc50DmX._lkaN4ygxDlKvzKEBuD7dRjrU20F();
		_wTbB4YBL4PSkaotwKX3CFc50DmX._SPUoP3ABwpgQinJfKUM5qBbYSvr("Phone answer start", delegate
		{
			_wTbB4YBL4PSkaotwKX3CFc50DmX._C5vPbZ72rpVMDWGuHxZuR5FNpAH("Phone answer loop");
		});
		_Pbt0pgZ2cGZkaxR9cQe0r2v2lVd();
	}

	public void _N6rbbp9vfBTLIy29VRlaxyb7udeA(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts ephoneContacts_0)
	{
		_3mKo17hkpGwyDp6sHVZAhV1c6Qv(ephoneContacts_0);
		_wTbB4YBL4PSkaotwKX3CFc50DmX._SPUoP3ABwpgQinJfKUM5qBbYSvr("Phone IM accept", delegate
		{
			_wTbB4YBL4PSkaotwKX3CFc50DmX._C5vPbZ72rpVMDWGuHxZuR5FNpAH("Phone IM idle");
		});
		_Pbt0pgZ2cGZkaxR9cQe0r2v2lVd();
	}

	public void _IiIBp9h21zmpuvGulVNz008r8TA(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts ephoneContacts_0)
	{
		_rASuGHWSFVWfkpwzF8wZd9bh3XN = true;
		_Pbt0pgZ2cGZkaxR9cQe0r2v2lVd();
	}

	public void _yIdbijdoIArgGYmQaSg2XCsw9hT(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts ephoneContacts_0)
	{
		_rASuGHWSFVWfkpwzF8wZd9bh3XN = true;
		_Pbt0pgZ2cGZkaxR9cQe0r2v2lVd();
	}

	public void _zm6vAchd6YcmYOAA7H1gpRDyQ3f(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts ephoneContacts_0)
	{
		_3mKo17hkpGwyDp6sHVZAhV1c6Qv(ephoneContacts_0);
		_8hw6Dkw1FlTEpsiy0adBUXTGpRe(bool_0: true);
		_wTbB4YBL4PSkaotwKX3CFc50DmX._lkaN4ygxDlKvzKEBuD7dRjrU20F();
		_wTbB4YBL4PSkaotwKX3CFc50DmX._SPUoP3ABwpgQinJfKUM5qBbYSvr("Phone Call start", delegate
		{
			_wTbB4YBL4PSkaotwKX3CFc50DmX._C5vPbZ72rpVMDWGuHxZuR5FNpAH("Phone Call loop");
		});
		_Pbt0pgZ2cGZkaxR9cQe0r2v2lVd();
	}

	public void _lMCk2LRgUr0BxjjkcGh4aHIw2kf(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts ephoneContacts_0)
	{
		_znPUoLNKAYlonsIsyRDTBqJ16RE(ephoneContacts_0);
	}

	public void _RKOSDyYel4mDgA7CBL7icGDh8NX(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts ephoneContacts_0)
	{
		_3mKo17hkpGwyDp6sHVZAhV1c6Qv(ephoneContacts_0);
		_wTbB4YBL4PSkaotwKX3CFc50DmX._C5vPbZ72rpVMDWGuHxZuR5FNpAH("Phone IM idle");
		_Pbt0pgZ2cGZkaxR9cQe0r2v2lVd();
	}

	public void _7A7AnrbJWOfnmm4PGqh14Sic88K(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts ephoneContacts_0)
	{
		_znPUoLNKAYlonsIsyRDTBqJ16RE(ephoneContacts_0);
	}

	public void _VIPhK0wyQYrQ8PUpr3jagtYPv9j(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts ephoneContacts_0)
	{
		_znPUoLNKAYlonsIsyRDTBqJ16RE(ephoneContacts_0);
	}

	public void _d77xq6Q69C4sosexup4aU79nRCI(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts ephoneContacts_0)
	{
		_3mKo17hkpGwyDp6sHVZAhV1c6Qv(ephoneContacts_0);
		_wTbB4YBL4PSkaotwKX3CFc50DmX._SPUoP3ABwpgQinJfKUM5qBbYSvr("Phone IM messaging loop", delegate
		{
			_wTbB4YBL4PSkaotwKX3CFc50DmX._C5vPbZ72rpVMDWGuHxZuR5FNpAH("Phone IM idle");
		});
		_iclFNsZuDOZLCNYXakYmA0rt3UU();
	}

	private void _znPUoLNKAYlonsIsyRDTBqJ16RE(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts ephoneContacts_0)
	{
		_3mKo17hkpGwyDp6sHVZAhV1c6Qv(ephoneContacts_0);
		_8hw6Dkw1FlTEpsiy0adBUXTGpRe(bool_0: false);
		_wTbB4YBL4PSkaotwKX3CFc50DmX._lkaN4ygxDlKvzKEBuD7dRjrU20F();
		_wTbB4YBL4PSkaotwKX3CFc50DmX._SPUoP3ABwpgQinJfKUM5qBbYSvr("Phone Call start", delegate
		{
			_wTbB4YBL4PSkaotwKX3CFc50DmX._C5vPbZ72rpVMDWGuHxZuR5FNpAH("Phone Call loop");
		});
		_Pbt0pgZ2cGZkaxR9cQe0r2v2lVd();
	}

	public void _2q4ULWZHQg4Aboj4mYnu05b6gpq()
	{
		_1gXQH16lmsacxQMOpjFFqZSmjQl = false;
		_Et7ViKuaneif1JVK3bifonUhKPR = _4L7hfXrWoDdArQiscG4ukHCV46B._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Phone/Gameboxes/" + _MCqah9fRROAHE2fkIv4nkhrpDKX[_WLqMMhDU6lDWhPjohexo40VadrB]);
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
		_BphDC8XZceMl5rqVm5zdrD6meOf = _4L7hfXrWoDdArQiscG4ukHCV46B._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Phone/Gallery/Remy/" + _I35ziY7HYJkfL20RDXWOC7Pcv1q[_j2EdRylzMDum240gfhMGkyqki8j]);
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
		_BphDC8XZceMl5rqVm5zdrD6meOf = _4L7hfXrWoDdArQiscG4ukHCV46B._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/GUI/Phone/Gallery/Remy/" + _I35ziY7HYJkfL20RDXWOC7Pcv1q[int_0]);
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

	public void _haICL4qkfkOLhPhofWQH1GmjZx5()
	{
		_rASuGHWSFVWfkpwzF8wZd9bh3XN = true;
		_1gXQH16lmsacxQMOpjFFqZSmjQl = true;
		_WLqMMhDU6lDWhPjohexo40VadrB = 0;
		_97m6gVcwgWbLFyNUxI3P1KuD0Gn = true;
		_j2EdRylzMDum240gfhMGkyqki8j = 0;
	}

	public static void _Oewx0FJJ8VX41Prmv0htvGQZhUf()
	{
		if (_6T55wit7MiGfAWRkPwjNbJ8N8lG._4L7hfXrWoDdArQiscG4ukHCV46B._5zNdOw7qHmuCAPJFMr3SsZdBlCr == null && !_6T55wit7MiGfAWRkPwjNbJ8N8lG._TZx1AkahTLXoM2XUbm5U8YJOScb)
		{
			if (_6T55wit7MiGfAWRkPwjNbJ8N8lG._j2OEvLQtM2lODSmH3ZFP6wWCWpF == _fFGgY4gvWNcTLSlsfe9k99ctumb.ArmUp)
			{
				_RiDuYMeg3EHnBUteUcAb8VlfQVl();
			}
			else
			{
				_IRQBceahi9mKwSlKg4gzjmohz1H();
			}
		}
	}

	public static void _IRQBceahi9mKwSlKg4gzjmohz1H(bool bool_0 = false)
	{
		if (_kf3EbE0B70xGe1szklqAZyCqoLj)
		{
			if (!_6T55wit7MiGfAWRkPwjNbJ8N8lG._0IwNM2MxOUN4RsEqXREAdDRe4Ad)
			{
				_6T55wit7MiGfAWRkPwjNbJ8N8lG._0IwNM2MxOUN4RsEqXREAdDRe4Ad = true;
				_6T55wit7MiGfAWRkPwjNbJ8N8lG._4L7hfXrWoDdArQiscG4ukHCV46B._aJh9CibG5YKhkExxgRyVopdfSeJ._vVZVLriSGPExpn1KeobglMabsoi("AchievementGeneric5");
			}
			_6T55wit7MiGfAWRkPwjNbJ8N8lG._4L7hfXrWoDdArQiscG4ukHCV46B._vsceSzSIjBy2nZrCxAzKZbUiwLq._1LQOhiUdxWk8bRA1sYnQMSYcjVm = true;
			_7UlnfykmEmZDFt3BmCKZekI43Ih._zI8afstSBU4SEMWSnQCa7srUFu = true;
			_6T55wit7MiGfAWRkPwjNbJ8N8lG._3AaEmo54VzWybgrrg7I8Z9JUV1e = bool_0;
			if (!_6T55wit7MiGfAWRkPwjNbJ8N8lG._TZx1AkahTLXoM2XUbm5U8YJOScb && _6T55wit7MiGfAWRkPwjNbJ8N8lG._j2OEvLQtM2lODSmH3ZFP6wWCWpF == _fFGgY4gvWNcTLSlsfe9k99ctumb.ArmDown)
			{
				_6T55wit7MiGfAWRkPwjNbJ8N8lG._j2OEvLQtM2lODSmH3ZFP6wWCWpF = _fFGgY4gvWNcTLSlsfe9k99ctumb.ArmUpRequested;
				_6T55wit7MiGfAWRkPwjNbJ8N8lG._WaCCr2ToiTDglrrE9z1EKOcLzT3 = true;
				_VQDLuxMbrizDwdFWvZoaPpO7Y0o.Clear();
				_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.Home);
			}
		}
	}

	public static void _RiDuYMeg3EHnBUteUcAb8VlfQVl()
	{
		if (_kf3EbE0B70xGe1szklqAZyCqoLj && !_6T55wit7MiGfAWRkPwjNbJ8N8lG._77rSPCEs6VEYjlGrwW0KN0btLEG)
		{
			_6T55wit7MiGfAWRkPwjNbJ8N8lG._4L7hfXrWoDdArQiscG4ukHCV46B._vsceSzSIjBy2nZrCxAzKZbUiwLq._1LQOhiUdxWk8bRA1sYnQMSYcjVm = false;
			_7UlnfykmEmZDFt3BmCKZekI43Ih._zI8afstSBU4SEMWSnQCa7srUFu = false;
			_6T55wit7MiGfAWRkPwjNbJ8N8lG._3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
			if (!_6T55wit7MiGfAWRkPwjNbJ8N8lG._TZx1AkahTLXoM2XUbm5U8YJOScb && _6T55wit7MiGfAWRkPwjNbJ8N8lG._j2OEvLQtM2lODSmH3ZFP6wWCWpF == _fFGgY4gvWNcTLSlsfe9k99ctumb.ArmUp)
			{
				_6T55wit7MiGfAWRkPwjNbJ8N8lG._j2OEvLQtM2lODSmH3ZFP6wWCWpF = _fFGgY4gvWNcTLSlsfe9k99ctumb.ArmDownRequested;
				_6T55wit7MiGfAWRkPwjNbJ8N8lG._p4cbe03cXPNybrHUo9DHRTp6W7m = true;
			}
		}
	}

	public static void _eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL _VQgRlkt1vazuo2KaxFIrSVwZOpL_0)
	{
		if (_VQgRlkt1vazuo2KaxFIrSVwZOpL_0 != 0)
		{
			_VQDLuxMbrizDwdFWvZoaPpO7Y0o.Push(_saaJnL0DI6B89XWRulJZ4KC1I1g);
			_6T55wit7MiGfAWRkPwjNbJ8N8lG._Pbt0pgZ2cGZkaxR9cQe0r2v2lVd();
		}
		_saaJnL0DI6B89XWRulJZ4KC1I1g = _VQgRlkt1vazuo2KaxFIrSVwZOpL_0;
		_6T55wit7MiGfAWRkPwjNbJ8N8lG._DAsCL6JdGst3kJHpcbztigO3VEV();
	}

	public static void _8B2OIJu0L2rpVtls8vq2qHBX2OB(_VQgRlkt1vazuo2KaxFIrSVwZOpL _VQgRlkt1vazuo2KaxFIrSVwZOpL_0)
	{
		_6T55wit7MiGfAWRkPwjNbJ8N8lG._Pbt0pgZ2cGZkaxR9cQe0r2v2lVd();
		_6T55wit7MiGfAWRkPwjNbJ8N8lG._DAsCL6JdGst3kJHpcbztigO3VEV();
	}

	public static void _270ZVixWLhgEiLA6QosapJMyU6h()
	{
		_saaJnL0DI6B89XWRulJZ4KC1I1g = _VQDLuxMbrizDwdFWvZoaPpO7Y0o.Pop();
		_6T55wit7MiGfAWRkPwjNbJ8N8lG._DAsCL6JdGst3kJHpcbztigO3VEV();
		_6T55wit7MiGfAWRkPwjNbJ8N8lG._Pbt0pgZ2cGZkaxR9cQe0r2v2lVd();
	}

	private void _Pbt0pgZ2cGZkaxR9cQe0r2v2lVd()
	{
		_flEA1zdf7DHRkPwzrlsWVEAXZiX = false;
		_6T55wit7MiGfAWRkPwjNbJ8N8lG._hrw3Kf8fCx7saJOmoYUD8sIz3uD._SPUoP3ABwpgQinJfKUM5qBbYSvr("Swipe", _aEgXugtdIuFieAwnDhnIlYNEysg);
	}

	private void _iclFNsZuDOZLCNYXakYmA0rt3UU()
	{
		_flEA1zdf7DHRkPwzrlsWVEAXZiX = false;
		_6T55wit7MiGfAWRkPwjNbJ8N8lG._hrw3Kf8fCx7saJOmoYUD8sIz3uD._SPUoP3ABwpgQinJfKUM5qBbYSvr("Typing", _aEgXugtdIuFieAwnDhnIlYNEysg);
	}

	private void _aEgXugtdIuFieAwnDhnIlYNEysg()
	{
		_6T55wit7MiGfAWRkPwjNbJ8N8lG._hrw3Kf8fCx7saJOmoYUD8sIz3uD._C5vPbZ72rpVMDWGuHxZuR5FNpAH("Idle");
		_flEA1zdf7DHRkPwzrlsWVEAXZiX = true;
	}

	private void _DAsCL6JdGst3kJHpcbztigO3VEV()
	{
		Control item;
		switch (_saaJnL0DI6B89XWRulJZ4KC1I1g)
		{
		default:
			_Ldzm1JY9st4tknAhrglOIpwdYhn = true;
			return;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.Contacts:
			item = _NWt4WEiiiqjMHAUuqWscxChtSMd();
			break;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.ContactsInformation:
			item = _kcNoqTwN559GGLalkuw5udBAUZB();
			break;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.ContactsInformationDJ:
			item = _h2ArPDECvhhh0z0Z51CaUxB7rAr();
			break;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.Soundtrack:
			item = _hiWNprom67B9EJO4loqBfhvB4hX();
			break;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.Diary:
			item = _YGPgft9Vo9UMBMfVtN34XoT93HD();
			break;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.DiaryMessages:
			item = _ZAzvI9G8CsjLJ0AWtoSCmHUuR2q();
			break;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.DiaryMessagesInformation:
			item = _yE1MXqtEKITxyL75pITcd8fNpsi();
			break;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.DiaryAchievements:
			item = _jv6KLyNe1t3TATNww1TiWv9ZVLF();
			break;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.DiarySave:
			item = _QmCbnBf76ITvR2HA7WYF44qkJWK();
			break;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.DiaryLoad:
			item = _mKzC4RKCG3B1ZBdWwcAp79gd8NaA();
			break;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.Audio:
			item = _fM96M1a1ZZUtzPyevCm45mKPeQg();
			break;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.ChatSettings:
			item = _H2blb6Djx9JemSUBYepwlzNOXxz();
			break;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.Gallery:
			item = _1Bze6b62yGQDi3JBE0TyQmPGkzU();
			break;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.Power:
			item = _dT5L6g1CEsgeYg5W9sVqR2trRSK();
			break;
		}
		_Ldzm1JY9st4tknAhrglOIpwdYhn = false;
		_9GQBAH2pi8Sm6ph1s6InjyQGe6R.Controls.Clear();
		_9GQBAH2pi8Sm6ph1s6InjyQGe6R.Controls.Add(item);
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
		_opIJo2jLUqdOL5yAFP4yzXce0DG _7FpdmRzPrcoARiGqtJekOfu7KqP = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
		if (_7FpdmRzPrcoARiGqtJekOfu7KqP._fvTKDuNATrUxfXZVvltePz3vYkK("DJ") == 20)
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
				_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.ContactsInformationDJ);
			};
			customListBoxItem.Controls.Add(item);
			customListBoxItem.Controls.Add(item2);
			listBox.ItemContainer.Controls.Add(customListBoxItem);
		}
		List<string> source = Enum.GetNames(typeof(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts)).Except(new string[1] { "None" }).ToList();
		_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts result;
		_6OmCduUGKgPqhBnqgfNJUOmDpZW<string, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts>[] array = (from string_0 in source
			select Enum.TryParse<_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts>(string_0, out result) ? ((!_7FpdmRzPrcoARiGqtJekOfu7KqP._4pE8Q2fYoSeltAUx7pxshukqsEb.HasFlag(result)) ? null : new _6OmCduUGKgPqhBnqgfNJUOmDpZW<string, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts>(string_0, result)) : null into _6OmCduUGKgPqhBnqgfNJUOmDpZW_0
			where _6OmCduUGKgPqhBnqgfNJUOmDpZW_0 != null
			orderby _6OmCduUGKgPqhBnqgfNJUOmDpZW_0.Name
			select _6OmCduUGKgPqhBnqgfNJUOmDpZW_0).ToArray();
		_6OmCduUGKgPqhBnqgfNJUOmDpZW<string, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts>[] array2 = array;
		foreach (_6OmCduUGKgPqhBnqgfNJUOmDpZW<string, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts> _6OmCduUGKgPqhBnqgfNJUOmDpZW2 in array2)
		{
			Squid.Rectangle rectangle = _kALYOlSwbvFyd9uFqFZW8Y2IsnL[_6OmCduUGKgPqhBnqgfNJUOmDpZW2.Value];
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
				Text = _6OmCduUGKgPqhBnqgfNJUOmDpZW2.Name,
				TextAlign = Alignment.MiddleCenter,
				NoEvents = true
			};
			CustomListBoxItem _4wrjSKvuvZUTRPI3prAOEvBGDhD = new CustomListBoxItem
			{
				Size = new Squid.Point(0, 60),
				Padding = new Margin(2),
				Value = _6OmCduUGKgPqhBnqgfNJUOmDpZW2.Value
			};
			_4wrjSKvuvZUTRPI3prAOEvBGDhD.MouseClick += delegate
			{
				_H6UwM4zjGzglzMY478iBDDvTk6I = (_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts)_4wrjSKvuvZUTRPI3prAOEvBGDhD.Value;
				_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.ContactsInformation);
			};
			_4wrjSKvuvZUTRPI3prAOEvBGDhD.Controls.Add(item3);
			_4wrjSKvuvZUTRPI3prAOEvBGDhD.Controls.Add(item4);
			listBox.ItemContainer.Controls.Add(_4wrjSKvuvZUTRPI3prAOEvBGDhD);
		}
		return listBox;
	}

	private Control _kcNoqTwN559GGLalkuw5udBAUZB()
	{
		Panel panel = new Panel
		{
			Dock = DockStyle.Fill
		};
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
		Label item = new Label
		{
			Dock = DockStyle.Top,
			Text = _H6UwM4zjGzglzMY478iBDDvTk6I.ToString(),
			Style = "button",
			Size = new Squid.Point(0, 40),
			NoEvents = true
		};
		ImageControl item2 = new CustomImageControl
		{
			Dock = DockStyle.Top,
			Texture = "PhoneScreen",
			TextureRect = _kALYOlSwbvFyd9uFqFZW8Y2IsnL[_H6UwM4zjGzglzMY478iBDDvTk6I]
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
			_3AaEmo54VzWybgrrg7I8Z9JUV1e = true;
			_9GQBAH2pi8Sm6ph1s6InjyQGe6R._GtkWDtXwQHwgWY4aFkacjfUDyzb($"Are you sure you wish to remove {_H6UwM4zjGzglzMY478iBDDvTk6I}? This will reset all progression!", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, 250, delegate(int int_0)
			{
				if (int_0 == 1)
				{
					_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t()._Qd7anWdHpZ5AgaUbbEv07BnnI6Q(_H6UwM4zjGzglzMY478iBDDvTk6I);
					_9GQBAH2pi8Sm6ph1s6InjyQGe6R._0pVU36wp9GYD1jM18raZtVEbA9q($"{_H6UwM4zjGzglzMY478iBDDvTk6I} will be available again after you went home.", 250, "OK", delegate
					{
						_270ZVixWLhgEiLA6QosapJMyU6h();
						_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
					});
				}
				else
				{
					_270ZVixWLhgEiLA6QosapJMyU6h();
					_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
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
			string name = _4L7hfXrWoDdArQiscG4ukHCV46B._XbOXR6AypLIdJ3gBMGseGi3Wi2i.GetType().Name;
			string text = _4L7hfXrWoDdArQiscG4ukHCV46B._KVSwpLj0RvURRswHn7ogRy4BRfd?.GetType().Name;
			if (name == "PlayerSexScene" && text == _iVvswmrDLetaWXmgd38sJtDnLs[_H6UwM4zjGzglzMY478iBDDvTk6I])
			{
				_nkzqFdEfDyLcyGikIKGcHjklI4y._zunSyHn4DekdA6CngP10dXcR1kq("<i>" + _H6UwM4zjGzglzMY478iBDDvTk6I.ToString() + " is kind of... preoccupied right now.</i>", "%playername%", Color.White);
			}
			else if (name != "BedroomScene" && name != "LivingRoomScene")
			{
				_nkzqFdEfDyLcyGikIKGcHjklI4y._zunSyHn4DekdA6CngP10dXcR1kq("<i>Reception is really bad at the moment, I should try again when I'm back at home.</i>", "%playername%", Color.White);
			}
			else
			{
				_WDhVhBhQHGowaONqV87v7EaCvro(_H6UwM4zjGzglzMY478iBDDvTk6I);
			}
		};
		panel.Content.Controls.Add(button2);
		if (_H6UwM4zjGzglzMY478iBDDvTk6I == _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Zenith && opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("ZenithDate") > 20)
		{
			Button button3 = new Button
			{
				Dock = DockStyle.Top,
				Text = "Extra: Shooting Range",
				Size = new Squid.Point(0, 50)
			};
			button3.MouseClick += delegate
			{
				_RiDuYMeg3EHnBUteUcAb8VlfQVl();
				_4L7hfXrWoDdArQiscG4ukHCV46B._k9wUPeU1Ga7cygiuGP8TT6aPLWF<PhoneShootingRangeMiniGameScene>();
			};
			panel.Content.Controls.Add(button3);
		}
		if (_H6UwM4zjGzglzMY478iBDDvTk6I == _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Remy && opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("RemyDate") > 20)
		{
			Button button4 = new Button
			{
				Dock = DockStyle.Top,
				Text = "Extra: Cooking Mini-Game",
				Size = new Squid.Point(0, 50)
			};
			button4.MouseClick += delegate
			{
				_4L7hfXrWoDdArQiscG4ukHCV46B._xyl3Tv5KdR5eezDgagxbBcS3cwt("MiniGameCooking");
				_RiDuYMeg3EHnBUteUcAb8VlfQVl();
			};
			panel.Content.Controls.Add(button4);
		}
		if (!_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF && _H6UwM4zjGzglzMY478iBDDvTk6I == _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Remy && opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("RemyDate") > 30)
		{
			Button button5 = new Button
			{
				Dock = DockStyle.Top,
				Text = "Extra: Nude pictures",
				Size = new Squid.Point(0, 50)
			};
			button5.MouseClick += delegate
			{
				_4L7hfXrWoDdArQiscG4ukHCV46B._xyl3Tv5KdR5eezDgagxbBcS3cwt("NudesRemy");
				_RiDuYMeg3EHnBUteUcAb8VlfQVl();
			};
			panel.Content.Controls.Add(button5);
		}
		string _nc2gJWKJm6yAMtppwpcfigGPFj3 = null;
		if (_H6UwM4zjGzglzMY478iBDDvTk6I == _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Coby && opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("CobyDate") == 20)
		{
			_nc2gJWKJm6yAMtppwpcfigGPFj3 = "CobySexscene";
		}
		else if (_H6UwM4zjGzglzMY478iBDDvTk6I == _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Dustin && opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("DustinDate") == 70)
		{
			_nc2gJWKJm6yAMtppwpcfigGPFj3 = "DustinPostDate";
		}
		else if (_H6UwM4zjGzglzMY478iBDDvTk6I != _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Jax || opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("JaxDate") != 40)
		{
			if (_H6UwM4zjGzglzMY478iBDDvTk6I != _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Lex || opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("LexDate") != 50)
			{
				if (_H6UwM4zjGzglzMY478iBDDvTk6I == _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Mercy && opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("MercyDate") == 60)
				{
					_nc2gJWKJm6yAMtppwpcfigGPFj3 = "MercyPostDate";
				}
				else if (_H6UwM4zjGzglzMY478iBDDvTk6I != _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Remy || opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("RemyDate") != 40)
				{
					if (_H6UwM4zjGzglzMY478iBDDvTk6I != _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Seth || opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("SethDate") != 40)
					{
						if (_H6UwM4zjGzglzMY478iBDDvTk6I == _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Skye && opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("SkyeDate") == 60)
						{
							_nc2gJWKJm6yAMtppwpcfigGPFj3 = "SkyePostDate";
						}
						else if (_H6UwM4zjGzglzMY478iBDDvTk6I == _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Zenith && opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("ZenithDate") == 70)
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
				Text = (_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF ? "Extra: Love scene" : "Extra: Sexscene"),
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
			string name = _4L7hfXrWoDdArQiscG4ukHCV46B._XbOXR6AypLIdJ3gBMGseGi3Wi2i.GetType().Name;
			if (name.StartsWith("Club"))
			{
				_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.Soundtrack);
			}
			else
			{
				_nkzqFdEfDyLcyGikIKGcHjklI4y._zunSyHn4DekdA6CngP10dXcR1kq("<i>Hmm, the operator is telling me: 'The number you are trying to reach is currently unavailable'. I guess the DJ only has his phone enabled during Club hours.</i>", "%playername%", Color.White);
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
		List<_KZ7hNP1K5E99Xfup1lTZ9UDrxPE._vNekDVpW2fr7UkjA16E9ifFmD9s> list = _KZ7hNP1K5E99Xfup1lTZ9UDrxPE._LUJAgYjQ8oEpFgPKC5CzY9Ne5ju.OrderBy((_KZ7hNP1K5E99Xfup1lTZ9UDrxPE._vNekDVpW2fr7UkjA16E9ifFmD9s _vNekDVpW2fr7UkjA16E9ifFmD9s_0) => _vNekDVpW2fr7UkjA16E9ifFmD9s_0._D5QiLGGNtfoCEnZIUPvH4OKqUabA).ToList();
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
				Text = "\"" + item3._D5QiLGGNtfoCEnZIUPvH4OKqUabA + "\"",
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
				int num = _boyt8NIMtKsAGSTcjHeL0WMbFxs._07xTWbIEgzxJYsYwFKDbbKNvu4G(0, _OZU2jcD6pvGbls1ACzPQPKBf9ci.Length);
				_nkzqFdEfDyLcyGikIKGcHjklI4y._zunSyHn4DekdA6CngP10dXcR1kq(_OZU2jcD6pvGbls1ACzPQPKBf9ci[num], ClubDJNPC._RB8fRXeQvK5vs7JEA0XfVCEpg1i, ClubDJNPC._9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA);
				_UmxbIbk7pgaod0bD7pS309P3Lns._QrgbXEg7MMeD9Ybz12fFVsbmAd9(_a5X3xjbmM60JVR5AMk4qrTqgyJm._XAtd16WmK4L37sBtMsLCIvJzIS1, 0.3f, bool_0: false);
				_4L7hfXrWoDdArQiscG4ukHCV46B._aJh9CibG5YKhkExxgRyVopdfSeJ._vVZVLriSGPExpn1KeobglMabsoi("AchievementGeneric3");
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
			_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.DiaryMessages);
		};
		ListBoxItem listBoxItem2 = new ListBoxItem
		{
			Text = "Achievements",
			Size = new Squid.Point(0, 50)
		};
		listBoxItem2.MouseClick += delegate
		{
			_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.DiaryAchievements);
		};
		ListBoxItem listBoxItem3 = new ListBoxItem
		{
			Text = "Save",
			Size = new Squid.Point(0, 50)
		};
		listBoxItem3.MouseClick += delegate
		{
			_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.DiarySave);
		};
		ListBoxItem listBoxItem4 = new ListBoxItem
		{
			Text = "Load",
			Size = new Squid.Point(0, 50)
		};
		listBoxItem4.MouseClick += delegate
		{
			_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.DiaryLoad);
		};
		listBox.Items.Add(listBoxItem);
		if (_4L7hfXrWoDdArQiscG4ukHCV46B._aJh9CibG5YKhkExxgRyVopdfSeJ._J5VHNpAqpO7aNRC9sbWCZTOF7XS)
		{
			ListBoxItem listBoxItem5 = new ListBoxItem
			{
				Text = "Steam Achievements",
				Size = new Squid.Point(0, 50)
			};
			listBoxItem5.MouseClick += delegate
			{
				_4L7hfXrWoDdArQiscG4ukHCV46B._aJh9CibG5YKhkExxgRyVopdfSeJ._3xUr1Yv0PbZlcGdOrfbCAwOXa5c();
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
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
		if (opIJo2jLUqdOL5yAFP4yzXce0DG._7u6aevGWBE7ABqrBXoaPTkywcVo.Count != 0)
		{
			foreach (_iDN1IKOu3e1uADYzeMEUon5D9fg _qsRYa7wg9K5fRrgfqdfMwLILTrbA in opIJo2jLUqdOL5yAFP4yzXce0DG._7u6aevGWBE7ABqrBXoaPTkywcVo.OrderByDescending((_iDN1IKOu3e1uADYzeMEUon5D9fg _iDN1IKOu3e1uADYzeMEUon5D9fg_0) => _iDN1IKOu3e1uADYzeMEUon5D9fg_0._QkxGXtWLzE0Z8JKyKkMiiph9giD))
			{
				ImageControl item = new ImageControl
				{
					Dock = DockStyle.Left,
					Texture = _qsRYa7wg9K5fRrgfqdfMwLILTrbA._dFaIUhufvE2Ld5IjNEwmPAqqraj,
					Size = new Squid.Point(60, 50),
					NoEvents = true
				};
				Label item2 = new Label
				{
					Dock = DockStyle.Fill,
					Text = _qsRYa7wg9K5fRrgfqdfMwLILTrbA._D5QiLGGNtfoCEnZIUPvH4OKqUabA + "\r\n" + _qsRYa7wg9K5fRrgfqdfMwLILTrbA._QkxGXtWLzE0Z8JKyKkMiiph9giD.ToShortDateString(),
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
					_ERdtO3cV05TBYFV0mT86wv01GJf = _qsRYa7wg9K5fRrgfqdfMwLILTrbA;
					_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.DiaryMessagesInformation);
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
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
		foreach (_bm5ybW5ND5sDF6bvP0sbYyOpvP._eT2GJReQj8Acaq2A0H0eUir97Qf item3 in _bm5ybW5ND5sDF6bvP0sbYyOpvP._cifgh151BUWCIJWJPcakKQ2lWGB)
		{
			ImageControl item = new ImageControl
			{
				Dock = DockStyle.Left,
				Texture = item3._dFaIUhufvE2Ld5IjNEwmPAqqraj,
				Size = new Squid.Point(60, 50)
			};
			Label item2 = new Label
			{
				Dock = DockStyle.Fill,
				Text = item3._D5QiLGGNtfoCEnZIUPvH4OKqUabA,
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
				Opacity = (opIJo2jLUqdOL5yAFP4yzXce0DG._Oms9lumBodLGrGZ09YJaEuzmlAf(item3._qXE0hlPdNyl0lTUyddbAS1PZhVV) ? 1f : 0.5f)
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
			Texture = _ERdtO3cV05TBYFV0mT86wv01GJf._dFaIUhufvE2Ld5IjNEwmPAqqraj,
			Size = new Squid.Point(60, 50)
		};
		Label item2 = new Label
		{
			Dock = DockStyle.Fill,
			Text = _ERdtO3cV05TBYFV0mT86wv01GJf._D5QiLGGNtfoCEnZIUPvH4OKqUabA + "\r\n" + _ERdtO3cV05TBYFV0mT86wv01GJf._QkxGXtWLzE0Z8JKyKkMiiph9giD.ToShortDateString(),
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
			Text = _ERdtO3cV05TBYFV0mT86wv01GJf._NvMJ5jDaeRR7HysERrVDtSlxaI5,
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
			_3AaEmo54VzWybgrrg7I8Z9JUV1e = true;
			_9GQBAH2pi8Sm6ph1s6InjyQGe6R._GtkWDtXwQHwgWY4aFkacjfUDyzb("Are you sure you wish to remove this message?", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, 250, delegate(int int_0)
			{
				if (int_0 == 1)
				{
					_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
					opIJo2jLUqdOL5yAFP4yzXce0DG._7u6aevGWBE7ABqrBXoaPTkywcVo.Remove(_ERdtO3cV05TBYFV0mT86wv01GJf);
					_ERdtO3cV05TBYFV0mT86wv01GJf = null;
					_270ZVixWLhgEiLA6QosapJMyU6h();
				}
				_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
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
		List<_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p> list = _DW9IcpdMEINZmuzfrqmwsduBGih._25D1ZH2er0EbpKmvFksAbFjP2OX(bool_0: true);
		foreach (_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p item in list)
		{
			int num = item._RB8fRXeQvK5vs7JEA0XfVCEpg1i.IndexOf('-');
			string text = item._RB8fRXeQvK5vs7JEA0XfVCEpg1i.Substring(0, num).Trim();
			string text2 = item._RB8fRXeQvK5vs7JEA0XfVCEpg1i.Substring(num + 1).Trim();
			ListBoxItem listBoxItem = new ListBoxItem
			{
				Text = text + "\r\n" + text2,
				Size = new Squid.Point(0, 50)
			};
			_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p _7OcRfli7CrlI9YYUDJj3j5nDI9k = item;
			listBoxItem.MouseClick += delegate
			{
				if (_7OcRfli7CrlI9YYUDJj3j5nDI9k._r4LqoJiAr5K9UiLsUzUDbcJDQqo)
				{
					_4L7hfXrWoDdArQiscG4ukHCV46B._yh2DwZs16cvRtvGayeYZrMWlrbj(_7OcRfli7CrlI9YYUDJj3j5nDI9k._B3FsRMcQWBXzFf3nLOBKzncessO);
					_6T55wit7MiGfAWRkPwjNbJ8N8lG._DAsCL6JdGst3kJHpcbztigO3VEV();
				}
				else
				{
					_3AaEmo54VzWybgrrg7I8Z9JUV1e = true;
					_9GQBAH2pi8Sm6ph1s6InjyQGe6R._GtkWDtXwQHwgWY4aFkacjfUDyzb($"Are you sure you wish to overwrite slot #{_7OcRfli7CrlI9YYUDJj3j5nDI9k._B3FsRMcQWBXzFf3nLOBKzncessO + 1}?", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, 250, delegate(int int_0)
					{
						if (int_0 == 1)
						{
							_4L7hfXrWoDdArQiscG4ukHCV46B._yh2DwZs16cvRtvGayeYZrMWlrbj(_7OcRfli7CrlI9YYUDJj3j5nDI9k._B3FsRMcQWBXzFf3nLOBKzncessO);
							_6T55wit7MiGfAWRkPwjNbJ8N8lG._DAsCL6JdGst3kJHpcbztigO3VEV();
						}
						_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
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
		List<_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p> list = _DW9IcpdMEINZmuzfrqmwsduBGih._25D1ZH2er0EbpKmvFksAbFjP2OX(bool_0: false);
		foreach (_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p item in list)
		{
			int num = item._RB8fRXeQvK5vs7JEA0XfVCEpg1i.IndexOf('-');
			string text = item._RB8fRXeQvK5vs7JEA0XfVCEpg1i.Substring(0, num).Trim();
			string text2 = item._RB8fRXeQvK5vs7JEA0XfVCEpg1i.Substring(num + 1).Trim();
			ListBoxItem listBoxItem = new ListBoxItem
			{
				Text = text + "\r\n" + text2,
				Size = new Squid.Point(0, 50)
			};
			_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p _7OcRfli7CrlI9YYUDJj3j5nDI9k = item;
			listBoxItem.MouseClick += delegate
			{
				if (!_7OcRfli7CrlI9YYUDJj3j5nDI9k._r4LqoJiAr5K9UiLsUzUDbcJDQqo)
				{
					_3AaEmo54VzWybgrrg7I8Z9JUV1e = true;
					_9GQBAH2pi8Sm6ph1s6InjyQGe6R._GtkWDtXwQHwgWY4aFkacjfUDyzb(string.Format("Are you sure you wish to load {0}slot #{1}?", (!_7OcRfli7CrlI9YYUDJj3j5nDI9k._3y7m8OGVjMe7WGIhZ66YOw3ITUE) ? string.Empty : "autosave ", _7OcRfli7CrlI9YYUDJj3j5nDI9k._B3FsRMcQWBXzFf3nLOBKzncessO + 1), new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, 250, delegate(int int_0)
					{
						if (int_0 == 1)
						{
							_77rSPCEs6VEYjlGrwW0KN0btLEG = true;
							if (_7OcRfli7CrlI9YYUDJj3j5nDI9k._3y7m8OGVjMe7WGIhZ66YOw3ITUE ? _4L7hfXrWoDdArQiscG4ukHCV46B._1yDW5GeZ2MCcssz8ohrF9CK913i(_7OcRfli7CrlI9YYUDJj3j5nDI9k._B3FsRMcQWBXzFf3nLOBKzncessO) : _4L7hfXrWoDdArQiscG4ukHCV46B._Ut0dhlh4JTZBMNJPNxxI9f9VqTp(_7OcRfli7CrlI9YYUDJj3j5nDI9k._B3FsRMcQWBXzFf3nLOBKzncessO))
							{
								_77rSPCEs6VEYjlGrwW0KN0btLEG = false;
								_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
								_RiDuYMeg3EHnBUteUcAb8VlfQVl();
							}
							else
							{
								_9GQBAH2pi8Sm6ph1s6InjyQGe6R._0pVU36wp9GYD1jM18raZtVEbA9q("Failed to load save, it's most likely corrupted.", 250, "OK", delegate
								{
									_77rSPCEs6VEYjlGrwW0KN0btLEG = false;
									_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
								});
							}
						}
						else
						{
							_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
						}
					});
				}
				else
				{
					_3AaEmo54VzWybgrrg7I8Z9JUV1e = true;
					_9GQBAH2pi8Sm6ph1s6InjyQGe6R._0pVU36wp9GYD1jM18raZtVEbA9q(string.Format("There is no save in {0}slot #{1}!", _7OcRfli7CrlI9YYUDJj3j5nDI9k._3y7m8OGVjMe7WGIhZ66YOw3ITUE ? "autosave " : string.Empty, _7OcRfli7CrlI9YYUDJj3j5nDI9k._B3FsRMcQWBXzFf3nLOBKzncessO + 1), 250, "OK", delegate
					{
						_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
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
		slider.Value = _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._DF24JUrPFA6rJ2cQrOTlpC3I4FF * 100f;
		slider.Style = "scrollSlider";
		slider.Size = new Squid.Point(0, 30);
		slider.Button.Style = "scrollSliderButton";
		Slider _XEgAfmv7sJWJSaC2diC3eaD4Fgl = slider;
		_XEgAfmv7sJWJSaC2diC3eaD4Fgl.ValueChanged += delegate
		{
			_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._DF24JUrPFA6rJ2cQrOTlpC3I4FF = _XEgAfmv7sJWJSaC2diC3eaD4Fgl.Value / 100f;
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
		slider2.Value = _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._7NidKjx61ui5CP7JojwfqxH4aKC * 100f;
		slider2.Style = "scrollSlider";
		slider2.Size = new Squid.Point(0, 30);
		slider2.Button.Style = "scrollSliderButton";
		Slider _gjeIIVx9bHyd0aMj0WD483nrLWK = slider2;
		_gjeIIVx9bHyd0aMj0WD483nrLWK.ValueChanged += delegate
		{
			_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._7NidKjx61ui5CP7JojwfqxH4aKC = _gjeIIVx9bHyd0aMj0WD483nrLWK.Value / 100f;
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
		slider3.Value = _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._2g4Ch8GXdUt0oEbdCZUY2QMbIuH * 100f;
		slider3.Style = "scrollSlider";
		slider3.Size = new Squid.Point(0, 30);
		slider3.Button.Style = "scrollSliderButton";
		Slider _5mK9ExiyKm0md8q4J1C6xc4TzdF = slider3;
		_5mK9ExiyKm0md8q4J1C6xc4TzdF.ValueChanged += delegate
		{
			_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._2g4Ch8GXdUt0oEbdCZUY2QMbIuH = _5mK9ExiyKm0md8q4J1C6xc4TzdF.Value / 100f;
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
		_YemBTJprwfbd3mpg5Gy9uyEJWwI(panel.Content.Controls, "Dialogue Text Speed", new string[4] { "Slow", "Normal", "Fast", "Instant" }, (int)_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._wVLRBSMULz8GfedBPXaVJB0sBEO, delegate(int int_0)
		{
			_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._wVLRBSMULz8GfedBPXaVJB0sBEO = (DialogueSpeed)int_0;
			_nkzqFdEfDyLcyGikIKGcHjklI4y._NhL238TaCbkDiY6HXlWXZzzUYkm = (DialogueSpeed)int_0;
		});
		CheckBox _feL3soNn6ZWaJqYfjYJUyH118tF = new CheckBox
		{
			Dock = DockStyle.Top,
			Text = "Dialogue Auto-skip",
			Checked = _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._sbK0941BvW8HgPboNwOhIAd2jP3
		};
		_feL3soNn6ZWaJqYfjYJUyH118tF.CheckedChanged += delegate
		{
			_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._sbK0941BvW8HgPboNwOhIAd2jP3 = _feL3soNn6ZWaJqYfjYJUyH118tF.Checked;
			_nkzqFdEfDyLcyGikIKGcHjklI4y._fUgDiz7KX8TZUVzFlTeXMOhmfUT = _feL3soNn6ZWaJqYfjYJUyH118tF.Checked;
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
			_3AaEmo54VzWybgrrg7I8Z9JUV1e = true;
			_9GQBAH2pi8Sm6ph1s6InjyQGe6R._GtkWDtXwQHwgWY4aFkacjfUDyzb("Are you sure you wish to customize your character? This may break some active dates even if make no changes!", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, 250, delegate(int int_0)
			{
				if (int_0 == 1)
				{
					_RiDuYMeg3EHnBUteUcAb8VlfQVl();
					_4L7hfXrWoDdArQiscG4ukHCV46B._k9wUPeU1Ga7cygiuGP8TT6aPLWF<BackToPlayerCustomizationScene>();
				}
				_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
			});
		};
		listBox.Items.Add(listBoxItem);
		if (_iExD93IWLlzVfXsU9wyrEvWgJsg._X41qA9hgcgXH0Q1aFKWFWpg8UuM)
		{
			listBox.Items.Add(new ListBoxItem
			{
				Text = "---",
				Enabled = false
			});
			ListBoxItem _diVdxVCKW4CzhbYSG15BcHJB0Ub = new ListBoxItem
			{
				Text = (_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF ? "Disable SFW" : "Enable SFW"),
				Size = new Squid.Point(0, 50)
			};
			_diVdxVCKW4CzhbYSG15BcHJB0Ub.MouseClick += delegate
			{
				_YdyKdWT8QbQOIWkgEuPe6a9hJtd(delegate
				{
					_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF = !_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF;
					_DAsCL6JdGst3kJHpcbztigO3VEV();
					_diVdxVCKW4CzhbYSG15BcHJB0Ub.Text = (_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF ? "Disable SFW" : "Enable SFW");
				});
			};
			listBox.Items.Add(_diVdxVCKW4CzhbYSG15BcHJB0Ub);
		}
		if (!_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
		{
			_oWVabv0BTttUwHhKppcIL7h0vrZ(listBox);
		}
		return listBox;
	}

	private void _YdyKdWT8QbQOIWkgEuPe6a9hJtd(Action action_0)
	{
		_4L7hfXrWoDdArQiscG4ukHCV46B._Qj2G6fpAF4mGsATgkV8DPBF3aA1A._PYAXEqRAOkDRRNqm1k71R7GJTJK(delegate
		{
			string _nc2gJWKJm6yAMtppwpcfigGPFj3 = _4L7hfXrWoDdArQiscG4ukHCV46B._KVSwpLj0RvURRswHn7ogRy4BRfd?.GetType().Name;
			if (_nc2gJWKJm6yAMtppwpcfigGPFj3 != null)
			{
				_4L7hfXrWoDdArQiscG4ukHCV46B._Ec0fhBrUGmjaIKjUfJioigVc65x();
			}
			action_0();
			_4L7hfXrWoDdArQiscG4ukHCV46B._OxLRmpxixplTKChiTPUKAx4uTLG(_4L7hfXrWoDdArQiscG4ukHCV46B._XbOXR6AypLIdJ3gBMGseGi3Wi2i.GetType().Name, delegate
			{
				if (_nc2gJWKJm6yAMtppwpcfigGPFj3 != null)
				{
					_4L7hfXrWoDdArQiscG4ukHCV46B._gYGB98heFqsLp9tgJbdCP01IKV2(_nc2gJWKJm6yAMtppwpcfigGPFj3);
				}
				_4L7hfXrWoDdArQiscG4ukHCV46B._Qj2G6fpAF4mGsATgkV8DPBF3aA1A._FegL010tc92iskjjyD0T33dDwNE();
			});
		});
	}

	private void _ZfxNkwQ3qvZWenbVYRs2XNSAF2c(string string_0)
	{
		_4L7hfXrWoDdArQiscG4ukHCV46B._xyl3Tv5KdR5eezDgagxbBcS3cwt(string_0);
		_RiDuYMeg3EHnBUteUcAb8VlfQVl();
	}

	private ListBox _dT5L6g1CEsgeYg5W9sVqR2trRSK()
	{
		ListBox listBox = _Y29nu3VoVEY6acDadsfRh60BNDh();
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
		if (opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("Prologue") == 40)
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
				_RiDuYMeg3EHnBUteUcAb8VlfQVl();
				_4L7hfXrWoDdArQiscG4ukHCV46B._k9wUPeU1Ga7cygiuGP8TT6aPLWF<BedroomScene>();
			};
			listBoxItem2.MouseClick += delegate
			{
				_RiDuYMeg3EHnBUteUcAb8VlfQVl();
				_4L7hfXrWoDdArQiscG4ukHCV46B._k9wUPeU1Ga7cygiuGP8TT6aPLWF<ClubInsideScene>();
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
			_RiDuYMeg3EHnBUteUcAb8VlfQVl();
			_kf3EbE0B70xGe1szklqAZyCqoLj = false;
			_4L7hfXrWoDdArQiscG4ukHCV46B._k9wUPeU1Ga7cygiuGP8TT6aPLWF<MainMenuScene>();
		};
		ListBoxItem listBoxItem4 = new ListBoxItem
		{
			Text = "Quit Game",
			Size = new Squid.Point(0, 50)
		};
		listBoxItem4.MouseClick += delegate
		{
			_3AaEmo54VzWybgrrg7I8Z9JUV1e = true;
			_9GQBAH2pi8Sm6ph1s6InjyQGe6R._GtkWDtXwQHwgWY4aFkacjfUDyzb("Are you sure you wish to quit the game? All unsaved progress will be lost!", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, 250, delegate(int int_0)
			{
				if (int_0 == 1)
				{
					_4L7hfXrWoDdArQiscG4ukHCV46B._udfEpcIRn7lWl5Lvjdyu0aG0A7G();
				}
				_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
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
			Text = (_iExD93IWLlzVfXsU9wyrEvWgJsg._b52DDz3MN1kD8sgdQhCNO1tJRNn ? "Disable Topless Cheat" : "Enable Topless Cheat"),
			Size = new Squid.Point(0, 50)
		};
		_Epeel2m9h5O12V2ERwlnNTE3FdM.MouseClick += delegate
		{
			_YdyKdWT8QbQOIWkgEuPe6a9hJtd(delegate
			{
				_iExD93IWLlzVfXsU9wyrEvWgJsg._b52DDz3MN1kD8sgdQhCNO1tJRNn = !_iExD93IWLlzVfXsU9wyrEvWgJsg._b52DDz3MN1kD8sgdQhCNO1tJRNn;
				_Epeel2m9h5O12V2ERwlnNTE3FdM.Text = (_iExD93IWLlzVfXsU9wyrEvWgJsg._b52DDz3MN1kD8sgdQhCNO1tJRNn ? "Disable Topless Cheat" : "Enable Topless Cheat");
			});
		};
		ListBoxItem _FxyX2MMMdsf69424VDXa8LqP1nq = new ListBoxItem
		{
			Text = (_iExD93IWLlzVfXsU9wyrEvWgJsg._pKBiGAgDu5WqoykkGBaEGnP7oMj ? "Disable Bottomless Cheat" : "Enable Bottomless Cheat"),
			Size = new Squid.Point(0, 50)
		};
		_FxyX2MMMdsf69424VDXa8LqP1nq.MouseClick += delegate
		{
			_YdyKdWT8QbQOIWkgEuPe6a9hJtd(delegate
			{
				_iExD93IWLlzVfXsU9wyrEvWgJsg._pKBiGAgDu5WqoykkGBaEGnP7oMj = !_iExD93IWLlzVfXsU9wyrEvWgJsg._pKBiGAgDu5WqoykkGBaEGnP7oMj;
				_FxyX2MMMdsf69424VDXa8LqP1nq.Text = (_iExD93IWLlzVfXsU9wyrEvWgJsg._pKBiGAgDu5WqoykkGBaEGnP7oMj ? "Disable Bottomless Cheat" : "Enable Bottomless Cheat");
			});
		};
		listBox_0.Items.Add(_Epeel2m9h5O12V2ERwlnNTE3FdM);
		listBox_0.Items.Add(_FxyX2MMMdsf69424VDXa8LqP1nq);
	}

	private void _WDhVhBhQHGowaONqV87v7EaCvro(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts ephoneContacts_0)
	{
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
		switch (ephoneContacts_0)
		{
		case _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Dustin:
			if (opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("DustinDate") != 70)
			{
				_4L7hfXrWoDdArQiscG4ukHCV46B._xyl3Tv5KdR5eezDgagxbBcS3cwt("DustinDate");
				_RiDuYMeg3EHnBUteUcAb8VlfQVl();
			}
			else
			{
				_7v3cPeHMFZr3s2VCyeFm9SEiyy0(ephoneContacts_0);
			}
			break;
		case _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Remy:
			if (opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("RemyDate") != 40)
			{
				_4L7hfXrWoDdArQiscG4ukHCV46B._xyl3Tv5KdR5eezDgagxbBcS3cwt("RemyDate");
				_RiDuYMeg3EHnBUteUcAb8VlfQVl();
			}
			else
			{
				_7v3cPeHMFZr3s2VCyeFm9SEiyy0(ephoneContacts_0);
			}
			break;
		case _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Seth:
			if (opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("SethDate") == 40)
			{
				_7v3cPeHMFZr3s2VCyeFm9SEiyy0(ephoneContacts_0);
				break;
			}
			_4L7hfXrWoDdArQiscG4ukHCV46B._xyl3Tv5KdR5eezDgagxbBcS3cwt("SethDate");
			_RiDuYMeg3EHnBUteUcAb8VlfQVl();
			break;
		case _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Skye:
			if (opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("SkyeDate") != 60)
			{
				_4L7hfXrWoDdArQiscG4ukHCV46B._xyl3Tv5KdR5eezDgagxbBcS3cwt("SkyeDate");
				_RiDuYMeg3EHnBUteUcAb8VlfQVl();
			}
			else
			{
				_7v3cPeHMFZr3s2VCyeFm9SEiyy0(ephoneContacts_0);
			}
			break;
		case _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Zenith:
			if (_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t()._fvTKDuNATrUxfXZVvltePz3vYkK("ZenithDate") == 70)
			{
				_7v3cPeHMFZr3s2VCyeFm9SEiyy0(ephoneContacts_0);
				break;
			}
			_4L7hfXrWoDdArQiscG4ukHCV46B._xyl3Tv5KdR5eezDgagxbBcS3cwt("ZenithDate");
			_RiDuYMeg3EHnBUteUcAb8VlfQVl();
			break;
		case _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Mercy:
			if (opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("MercyDate") != 60)
			{
				_4L7hfXrWoDdArQiscG4ukHCV46B._xyl3Tv5KdR5eezDgagxbBcS3cwt("MercyDate");
				_RiDuYMeg3EHnBUteUcAb8VlfQVl();
			}
			else
			{
				_7v3cPeHMFZr3s2VCyeFm9SEiyy0(ephoneContacts_0);
			}
			break;
		case _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Lex:
			if (opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("LexDate") == 50)
			{
				_7v3cPeHMFZr3s2VCyeFm9SEiyy0(ephoneContacts_0);
				break;
			}
			_4L7hfXrWoDdArQiscG4ukHCV46B._xyl3Tv5KdR5eezDgagxbBcS3cwt("LexDate");
			_RiDuYMeg3EHnBUteUcAb8VlfQVl();
			break;
		case _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Jax:
			if (opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("JaxDate") == 40)
			{
				_7v3cPeHMFZr3s2VCyeFm9SEiyy0(ephoneContacts_0);
				break;
			}
			_4L7hfXrWoDdArQiscG4ukHCV46B._xyl3Tv5KdR5eezDgagxbBcS3cwt("JaxDate");
			_RiDuYMeg3EHnBUteUcAb8VlfQVl();
			break;
		case _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Coby:
			if (opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("CobyDate") < 20)
			{
				_4L7hfXrWoDdArQiscG4ukHCV46B._xyl3Tv5KdR5eezDgagxbBcS3cwt("CobyDate");
				_RiDuYMeg3EHnBUteUcAb8VlfQVl();
			}
			else
			{
				_4L7hfXrWoDdArQiscG4ukHCV46B._xyl3Tv5KdR5eezDgagxbBcS3cwt("CobyPostDate");
			}
			break;
		}
	}

	private void _7v3cPeHMFZr3s2VCyeFm9SEiyy0(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts ephoneContacts_0)
	{
		_3AaEmo54VzWybgrrg7I8Z9JUV1e = true;
		string arg = ephoneContacts_0.ToString();
		_9GQBAH2pi8Sm6ph1s6InjyQGe6R._0pVU36wp9GYD1jM18raZtVEbA9q($"You finished all dates with {arg}!", 250, "Gotcha!", delegate
		{
			_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
		});
	}

	public _poenyHBGUusBcnNcTFB9MQBV72R(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, ContentManager contentManager_0)
	{
		_6T55wit7MiGfAWRkPwjNbJ8N8lG = this;
		_4L7hfXrWoDdArQiscG4ukHCV46B = _JbeCmOie0phb2cbgG6DdGZrbs3pB_0;
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD = contentManager_0._7BVREQXEcBCieHb0qgaVDpUj1ni("Assets/GUI/Phone/Phone");
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._WPy6ICx3LVoejBaexyOoKGnX9jD("Arm rise", 0f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._c4iC7y9v6xg7LpvjKIeUkOdZ3UF(0f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._7Xn1C5tjYnmIif1iZKV8AWsEEbL = 0f;
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._bCjZ3VSXGKyhmykd2zCnQBiSpDf = 1200f;
		_lpMGMQZJYmHr6q9XBRwiM0Lse4N = contentManager_0._7BVREQXEcBCieHb0qgaVDpUj1ni("Assets/GUI/Phone/PhoneHUD", 0.5f);
		_lpMGMQZJYmHr6q9XBRwiM0Lse4N._C5vPbZ72rpVMDWGuHxZuR5FNpAH("No message");
		_lpMGMQZJYmHr6q9XBRwiM0Lse4N._7Xn1C5tjYnmIif1iZKV8AWsEEbL = 1845f;
		_lpMGMQZJYmHr6q9XBRwiM0Lse4N._bCjZ3VSXGKyhmykd2zCnQBiSpDf = 1060f;
		_wTbB4YBL4PSkaotwKX3CFc50DmX = contentManager_0._7BVREQXEcBCieHb0qgaVDpUj1ni("Assets/GUI/Phone/PhoneScreen");
		_wTbB4YBL4PSkaotwKX3CFc50DmX._7Xn1C5tjYnmIif1iZKV8AWsEEbL = 135f;
		_wTbB4YBL4PSkaotwKX3CFc50DmX._bCjZ3VSXGKyhmykd2zCnQBiSpDf = 190f;
		_rASuGHWSFVWfkpwzF8wZd9bh3XN = true;
		_Xrfjrxr72hHh4bDdQB7HzEbJUCb();
		_9GQBAH2pi8Sm6ph1s6InjyQGe6R = new Desktop
		{
			Skin = Gui.GenerateStandardSkin(),
			Size = new Squid.Point(270, 380)
		};
		_9GQBAH2pi8Sm6ph1s6InjyQGe6R._EMnZAXxoqoahiGOiNjffRycLtDE("Assets/GUI/Squid/DefaultSkin");
		_9GQBAH2pi8Sm6ph1s6InjyQGe6R.ModalColor = ColorInt.ARGB(0.9f, 0f, 0f, 0f);
		_9GQBAH2pi8Sm6ph1s6InjyQGe6R.MouseTransformFunc = delegate(Squid.Point point_0)
		{
			double double_;
			Microsoft.Xna.Framework.Point point = _hrw3Kf8fCx7saJOmoYUD8sIz3uD._0LlFMUVNTAixukJSTpecXFIxdAl("Sheen Two", out double_);
			Matrix matrix = Matrix.CreateTranslation(-point.X, -point.Y, 0f) * Matrix.CreateRotationZ((float)(0.0 - double_));
			Vector2 vector = Vector2.Transform(new Vector2(point_0.x, point_0.y), matrix);
			return new Squid.Point((int)vector.X, (int)vector.Y);
		};
		_bZJtpWV2Yj6GgZkeZQUmpTHxTnh = new RenderTarget2D(_4L7hfXrWoDdArQiscG4ukHCV46B._2yepMkVENnecIsduggABaU2qhXW, 270, 380);
		_Pfaq6ajchxcqF6GecivHvHqQW6M = new RenderTarget2D(_4L7hfXrWoDdArQiscG4ukHCV46B._2yepMkVENnecIsduggABaU2qhXW, 270, 380);
		_VQDLuxMbrizDwdFWvZoaPpO7Y0o = new Stack<_VQgRlkt1vazuo2KaxFIrSVwZOpL>();
		_1gXQH16lmsacxQMOpjFFqZSmjQl = true;
		_97m6gVcwgWbLFyNUxI3P1KuD0Gn = true;
	}

	public void _Xrfjrxr72hHh4bDdQB7HzEbJUCb()
	{
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
		bool flag = opIJo2jLUqdOL5yAFP4yzXce0DG._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.LongForearm);
		bool flag2;
		Color color_ = ((flag2 = opIJo2jLUqdOL5yAFP4yzXce0DG._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.ShortForearm)) ? opIJo2jLUqdOL5yAFP4yzXce0DG._8rDSn6e9Ip9WdOogjhIn8YlL1oM : (flag ? opIJo2jLUqdOL5yAFP4yzXce0DG._1ZKGQXLRAHEJR8v7jhlDsyOVLcz : Color.White));
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("Hoody Sleeve", 0f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("Default Forearm", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._VoeevpFh2kLKfHtpPDXWt0TFbuH("Default Forearm", opIJo2jLUqdOL5yAFP4yzXce0DG._6f1rvTENt5XWmHTE22zxBIwbH9G);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("Marking Forearm", (flag2 || flag) ? 1 : 0);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._VoeevpFh2kLKfHtpPDXWt0TFbuH("Marking Forearm", color_);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("Striped forearm", opIJo2jLUqdOL5yAFP4yzXce0DG._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Stripes) ? 1 : 0);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._VoeevpFh2kLKfHtpPDXWt0TFbuH("Striped forearm", opIJo2jLUqdOL5yAFP4yzXce0DG._TxfCqloeyiHpsXka6B46iqCZNsZ);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("Avian Forearm", opIJo2jLUqdOL5yAFP4yzXce0DG._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.AvianForearm) ? 1 : 0);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._VoeevpFh2kLKfHtpPDXWt0TFbuH("Avian Forearm", opIJo2jLUqdOL5yAFP4yzXce0DG._FrsyMDX7TebzFk8nSLTyRDPi1QH);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("Hand", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._VoeevpFh2kLKfHtpPDXWt0TFbuH("Hand", opIJo2jLUqdOL5yAFP4yzXce0DG._6f1rvTENt5XWmHTE22zxBIwbH9G);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("Marking Hand", (flag2 || flag) ? 1 : 0);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._VoeevpFh2kLKfHtpPDXWt0TFbuH("Marking Hand", color_);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("Avian Hand", opIJo2jLUqdOL5yAFP4yzXce0DG._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.AvianForearm) ? 1 : 0);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._VoeevpFh2kLKfHtpPDXWt0TFbuH("Avian Hand", opIJo2jLUqdOL5yAFP4yzXce0DG._FrsyMDX7TebzFk8nSLTyRDPi1QH);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("Index", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._VoeevpFh2kLKfHtpPDXWt0TFbuH("Index", opIJo2jLUqdOL5yAFP4yzXce0DG._6f1rvTENt5XWmHTE22zxBIwbH9G);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("Avian index", opIJo2jLUqdOL5yAFP4yzXce0DG._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.AvianForearm) ? 1 : 0);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._VoeevpFh2kLKfHtpPDXWt0TFbuH("Avian index", opIJo2jLUqdOL5yAFP4yzXce0DG._FrsyMDX7TebzFk8nSLTyRDPi1QH);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("Pinky", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._VoeevpFh2kLKfHtpPDXWt0TFbuH("Pinky", opIJo2jLUqdOL5yAFP4yzXce0DG._6f1rvTENt5XWmHTE22zxBIwbH9G);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("Avian Pinky", opIJo2jLUqdOL5yAFP4yzXce0DG._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.AvianForearm) ? 1 : 0);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._VoeevpFh2kLKfHtpPDXWt0TFbuH("Avian Pinky", opIJo2jLUqdOL5yAFP4yzXce0DG._FrsyMDX7TebzFk8nSLTyRDPi1QH);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("Ring", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._VoeevpFh2kLKfHtpPDXWt0TFbuH("Ring", opIJo2jLUqdOL5yAFP4yzXce0DG._6f1rvTENt5XWmHTE22zxBIwbH9G);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("Avian ring", opIJo2jLUqdOL5yAFP4yzXce0DG._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.AvianForearm) ? 1 : 0);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._VoeevpFh2kLKfHtpPDXWt0TFbuH("Avian ring", opIJo2jLUqdOL5yAFP4yzXce0DG._FrsyMDX7TebzFk8nSLTyRDPi1QH);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("Rude", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._VoeevpFh2kLKfHtpPDXWt0TFbuH("Rude", opIJo2jLUqdOL5yAFP4yzXce0DG._6f1rvTENt5XWmHTE22zxBIwbH9G);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("Avian Rude", opIJo2jLUqdOL5yAFP4yzXce0DG._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.AvianForearm) ? 1 : 0);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._VoeevpFh2kLKfHtpPDXWt0TFbuH("Avian Rude", opIJo2jLUqdOL5yAFP4yzXce0DG._FrsyMDX7TebzFk8nSLTyRDPi1QH);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("Thumb", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._VoeevpFh2kLKfHtpPDXWt0TFbuH("Thumb", opIJo2jLUqdOL5yAFP4yzXce0DG._6f1rvTENt5XWmHTE22zxBIwbH9G);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("Avian Thumb", opIJo2jLUqdOL5yAFP4yzXce0DG._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.AvianForearm) ? 1 : 0);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._VoeevpFh2kLKfHtpPDXWt0TFbuH("Avian Thumb", opIJo2jLUqdOL5yAFP4yzXce0DG._FrsyMDX7TebzFk8nSLTyRDPi1QH);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("Pinky Nail", opIJo2jLUqdOL5yAFP4yzXce0DG._VmNLhqrIwSnE6JnCYiBcxnSqnEV ? 1 : 0);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._VoeevpFh2kLKfHtpPDXWt0TFbuH("Pinky Nail", opIJo2jLUqdOL5yAFP4yzXce0DG._in5HHYmrdLTFpkgc8aimJpXqAXB);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("Ring Nail", opIJo2jLUqdOL5yAFP4yzXce0DG._VmNLhqrIwSnE6JnCYiBcxnSqnEV ? 1 : 0);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._VoeevpFh2kLKfHtpPDXWt0TFbuH("Ring Nail", opIJo2jLUqdOL5yAFP4yzXce0DG._in5HHYmrdLTFpkgc8aimJpXqAXB);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("Rude Nail", opIJo2jLUqdOL5yAFP4yzXce0DG._VmNLhqrIwSnE6JnCYiBcxnSqnEV ? 1 : 0);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._VoeevpFh2kLKfHtpPDXWt0TFbuH("Rude Nail", opIJo2jLUqdOL5yAFP4yzXce0DG._in5HHYmrdLTFpkgc8aimJpXqAXB);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("Index Nail", opIJo2jLUqdOL5yAFP4yzXce0DG._VmNLhqrIwSnE6JnCYiBcxnSqnEV ? 1 : 0);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._VoeevpFh2kLKfHtpPDXWt0TFbuH("Index Nail", opIJo2jLUqdOL5yAFP4yzXce0DG._in5HHYmrdLTFpkgc8aimJpXqAXB);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("Thumb Nail", opIJo2jLUqdOL5yAFP4yzXce0DG._VmNLhqrIwSnE6JnCYiBcxnSqnEV ? 1 : 0);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._VoeevpFh2kLKfHtpPDXWt0TFbuH("Thumb Nail", opIJo2jLUqdOL5yAFP4yzXce0DG._in5HHYmrdLTFpkgc8aimJpXqAXB);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("Phone lines", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._VoeevpFh2kLKfHtpPDXWt0TFbuH("Phone lines", opIJo2jLUqdOL5yAFP4yzXce0DG._uOkbmfW26QVAvyEMQakki9kTMDbA);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("Phone Colour", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("Phone Shadow", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("BG CONTACTS", 0f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("BG DIARY", 0f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("BG AUDIO", 0f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("BG CHAT SETTINGS", 0f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("BG GALLERY", 0f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("BG POWER", 0f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("Phone Default Background", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("CONTACTS", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("Diary", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("Audio", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("Chat Settings", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("Gallery", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("Power", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("white screen", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("black screen", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("Power", 1f);
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._aAoZaDNczeScsMfLlGSfAzey9SQ("Sheen Two", 1f);
		_IiWYS6YP6cEj83PIAXepbAHBaJB();
	}

	private void _IiWYS6YP6cEj83PIAXepbAHBaJB()
	{
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
		_lpMGMQZJYmHr6q9XBRwiM0Lse4N._VoeevpFh2kLKfHtpPDXWt0TFbuH("Phone", opIJo2jLUqdOL5yAFP4yzXce0DG._uOkbmfW26QVAvyEMQakki9kTMDbA);
	}

	public static _poenyHBGUusBcnNcTFB9MQBV72R _AZrO8MxMUE7cKsFYTQ4k9O3q7yC()
	{
		return _6T55wit7MiGfAWRkPwjNbJ8N8lG;
	}

	private void _3mKo17hkpGwyDp6sHVZAhV1c6Qv(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts ephoneContacts_0)
	{
		_rASuGHWSFVWfkpwzF8wZd9bh3XN = false;
		foreach (string item in _PcaKA8lfkZnYKjOTdM7RWYPBlGr.Keys.ToList())
		{
			_PcaKA8lfkZnYKjOTdM7RWYPBlGr[item] = false;
		}
		if (ephoneContacts_0 == _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Lex)
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

	public void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0, _wRd4nHuQQlAPEwrHOGkBfut6Uip _wRd4nHuQQlAPEwrHOGkBfut6Uip_0)
	{
		if (_4L7hfXrWoDdArQiscG4ukHCV46B._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(Microsoft.Xna.Framework.Input.Keys.Escape) || _4L7hfXrWoDdArQiscG4ukHCV46B._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(Microsoft.Xna.Framework.Input.Keys.LeftShift))
		{
			_Oewx0FJJ8VX41Prmv0htvGQZhUf();
		}
		_hrw3Kf8fCx7saJOmoYUD8sIz3uD._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0, (_4L7hfXrWoDdArQiscG4ukHCV46B._5zNdOw7qHmuCAPJFMr3SsZdBlCr != null || !_flEA1zdf7DHRkPwzrlsWVEAXZiX) ? 1000f : _rLwDc2UH4fLL9at0M4SCKf0SG8cA);
		_lpMGMQZJYmHr6q9XBRwiM0Lse4N._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
		_wTbB4YBL4PSkaotwKX3CFc50DmX._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
		_D1T6p91T7mKeglw2nCBqHjNgzfB();
		_48sn09DNztKRWaadCpDeWr57ENW(_wRd4nHuQQlAPEwrHOGkBfut6Uip_0);
		_Xgbbx1uIlIM4mSecGPtARNWvSMm(_wRd4nHuQQlAPEwrHOGkBfut6Uip_0);
		if (!_Ldzm1JY9st4tknAhrglOIpwdYhn)
		{
			_9GQBAH2pi8Sm6ph1s6InjyQGe6R.Update();
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
			_hrw3Kf8fCx7saJOmoYUD8sIz3uD._SPUoP3ABwpgQinJfKUM5qBbYSvr("Arm rise", delegate
			{
				_TZx1AkahTLXoM2XUbm5U8YJOScb = false;
				_j2OEvLQtM2lODSmH3ZFP6wWCWpF = _fFGgY4gvWNcTLSlsfe9k99ctumb.ArmUp;
				_aEgXugtdIuFieAwnDhnIlYNEysg();
			});
		}
		else if (_p4cbe03cXPNybrHUo9DHRTp6W7m)
		{
			_flEA1zdf7DHRkPwzrlsWVEAXZiX = false;
			_p4cbe03cXPNybrHUo9DHRTp6W7m = false;
			_TZx1AkahTLXoM2XUbm5U8YJOScb = true;
			_hrw3Kf8fCx7saJOmoYUD8sIz3uD._SPUoP3ABwpgQinJfKUM5qBbYSvr("Arm lower", delegate
			{
				_TZx1AkahTLXoM2XUbm5U8YJOScb = false;
				_j2OEvLQtM2lODSmH3ZFP6wWCWpF = _fFGgY4gvWNcTLSlsfe9k99ctumb.ArmDown;
			});
		}
	}

	private void _48sn09DNztKRWaadCpDeWr57ENW(_wRd4nHuQQlAPEwrHOGkBfut6Uip _wRd4nHuQQlAPEwrHOGkBfut6Uip_0)
	{
		if (_f2smFxmYyFJyj81xWGaGLB2G7ef == _wlQdV74JhqkBVxNonpbfqZEmjIbA.None || _4L7hfXrWoDdArQiscG4ukHCV46B._5zNdOw7qHmuCAPJFMr3SsZdBlCr != null || _3AaEmo54VzWybgrrg7I8Z9JUV1e)
		{
			return;
		}
		Microsoft.Xna.Framework.Point point = _wRd4nHuQQlAPEwrHOGkBfut6Uip_0._u7uCdK9i8FnWhiaPn2bO2wIgUUuA(_4L7hfXrWoDdArQiscG4ukHCV46B._RbWJ7YGnYHCSoD44MRW1h5X6E7E._U7CeYBJ1v1SoUxpX8emsQ9mWl5b);
		if (_lpMGMQZJYmHr6q9XBRwiM0Lse4N._3nKd9Dk3YeX87QB5dROwYUzczsN("Phone", point.X, point.Y))
		{
			_lpMGMQZJYmHr6q9XBRwiM0Lse4N._VoeevpFh2kLKfHtpPDXWt0TFbuH("Phone", Color.Red);
			_7UlnfykmEmZDFt3BmCKZekI43Ih._zI8afstSBU4SEMWSnQCa7srUFu = true;
			if (_4L7hfXrWoDdArQiscG4ukHCV46B._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(_PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton))
			{
				_Oewx0FJJ8VX41Prmv0htvGQZhUf();
			}
			_tIOoXRaaichIzSVUOs5dNLciPbw = true;
		}
		else if (_tIOoXRaaichIzSVUOs5dNLciPbw)
		{
			_lpMGMQZJYmHr6q9XBRwiM0Lse4N._VoeevpFh2kLKfHtpPDXWt0TFbuH("Phone", _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t()._uOkbmfW26QVAvyEMQakki9kTMDbA);
			if (_j2OEvLQtM2lODSmH3ZFP6wWCWpF == _fFGgY4gvWNcTLSlsfe9k99ctumb.ArmDown || _j2OEvLQtM2lODSmH3ZFP6wWCWpF == _fFGgY4gvWNcTLSlsfe9k99ctumb.ArmDownRequested)
			{
				_7UlnfykmEmZDFt3BmCKZekI43Ih._zI8afstSBU4SEMWSnQCa7srUFu = false;
			}
			_tIOoXRaaichIzSVUOs5dNLciPbw = false;
		}
	}

	private void _Xgbbx1uIlIM4mSecGPtARNWvSMm(_wRd4nHuQQlAPEwrHOGkBfut6Uip _wRd4nHuQQlAPEwrHOGkBfut6Uip_0)
	{
		if (_j2OEvLQtM2lODSmH3ZFP6wWCWpF != _fFGgY4gvWNcTLSlsfe9k99ctumb.ArmUp || _4L7hfXrWoDdArQiscG4ukHCV46B._5zNdOw7qHmuCAPJFMr3SsZdBlCr != null || _3AaEmo54VzWybgrrg7I8Z9JUV1e)
		{
			return;
		}
		Microsoft.Xna.Framework.Point point = _wRd4nHuQQlAPEwrHOGkBfut6Uip_0._u7uCdK9i8FnWhiaPn2bO2wIgUUuA(_4L7hfXrWoDdArQiscG4ukHCV46B._RbWJ7YGnYHCSoD44MRW1h5X6E7E._U7CeYBJ1v1SoUxpX8emsQ9mWl5b);
		bool flag = _hrw3Kf8fCx7saJOmoYUD8sIz3uD._3nKd9Dk3YeX87QB5dROwYUzczsN("Phone Colour", point.X, point.Y);
		_rLwDc2UH4fLL9at0M4SCKf0SG8cA = (flag ? 5000f : 1000f);
		if (!flag)
		{
			return;
		}
		if (_4L7hfXrWoDdArQiscG4ukHCV46B._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(_PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton))
		{
			if (_saaJnL0DI6B89XWRulJZ4KC1I1g == _VQgRlkt1vazuo2KaxFIrSVwZOpL.Home)
			{
				if (_hrw3Kf8fCx7saJOmoYUD8sIz3uD._3nKd9Dk3YeX87QB5dROwYUzczsN("CONTACTS", point.X, point.Y))
				{
					_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.Contacts);
				}
				else if (_hrw3Kf8fCx7saJOmoYUD8sIz3uD._3nKd9Dk3YeX87QB5dROwYUzczsN("Diary", point.X, point.Y))
				{
					_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.Diary);
				}
				else if (_hrw3Kf8fCx7saJOmoYUD8sIz3uD._3nKd9Dk3YeX87QB5dROwYUzczsN("Audio", point.X, point.Y))
				{
					_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.Audio);
				}
				else if (_hrw3Kf8fCx7saJOmoYUD8sIz3uD._3nKd9Dk3YeX87QB5dROwYUzczsN("Chat Settings", point.X, point.Y))
				{
					_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.ChatSettings);
				}
				else if (_hrw3Kf8fCx7saJOmoYUD8sIz3uD._3nKd9Dk3YeX87QB5dROwYUzczsN("Gallery", point.X, point.Y))
				{
					_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.Gallery);
				}
				else if (_hrw3Kf8fCx7saJOmoYUD8sIz3uD._3nKd9Dk3YeX87QB5dROwYUzczsN("Power", point.X, point.Y))
				{
					_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.Power);
				}
				else if (!_hrw3Kf8fCx7saJOmoYUD8sIz3uD._3nKd9Dk3YeX87QB5dROwYUzczsN("Phone Default Background", point.X, point.Y))
				{
					_RiDuYMeg3EHnBUteUcAb8VlfQVl();
				}
			}
			else if (!_hrw3Kf8fCx7saJOmoYUD8sIz3uD._3nKd9Dk3YeX87QB5dROwYUzczsN("Phone Default Background", point.X, point.Y))
			{
				_270ZVixWLhgEiLA6QosapJMyU6h();
			}
		}
		if (_4L7hfXrWoDdArQiscG4ukHCV46B._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(_PMeRYZJaBCqgB9uADJFP3c14lxq.RightButton))
		{
			if (_saaJnL0DI6B89XWRulJZ4KC1I1g != 0)
			{
				_270ZVixWLhgEiLA6QosapJMyU6h();
			}
			else
			{
				_RiDuYMeg3EHnBUteUcAb8VlfQVl();
			}
		}
	}

	public void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0)
	{
		if (!_kf3EbE0B70xGe1szklqAZyCqoLj)
		{
			return;
		}
		if (_TZx1AkahTLXoM2XUbm5U8YJOScb || _j2OEvLQtM2lODSmH3ZFP6wWCWpF == _fFGgY4gvWNcTLSlsfe9k99ctumb.ArmUp)
		{
			RenderTargetBinding[] renderTargets = _4L7hfXrWoDdArQiscG4ukHCV46B._2yepMkVENnecIsduggABaU2qhXW.GetRenderTargets();
			_4L7hfXrWoDdArQiscG4ukHCV46B._2yepMkVENnecIsduggABaU2qhXW.SetRenderTarget(_bZJtpWV2Yj6GgZkeZQUmpTHxTnh);
			_9GQBAH2pi8Sm6ph1s6InjyQGe6R.Draw();
			_4L7hfXrWoDdArQiscG4ukHCV46B._2yepMkVENnecIsduggABaU2qhXW.SetRenderTarget(_Pfaq6ajchxcqF6GecivHvHqQW6M);
			_wTbB4YBL4PSkaotwKX3CFc50DmX._f5ctqAmdNsZ889UjM4LxDm8WGxA(skeletonMeshRenderer_0, null, delegate(int int_0, string string_0)
			{
				if (_PcaKA8lfkZnYKjOTdM7RWYPBlGr.ContainsKey(string_0))
				{
					return _PcaKA8lfkZnYKjOTdM7RWYPBlGr[string_0];
				}
				return !_0OvMkQYTGPrNhckv6iHt3zmR5ni.ContainsKey(string_0) || _0OvMkQYTGPrNhckv6iHt3zmR5ni[string_0];
			});
			_4L7hfXrWoDdArQiscG4ukHCV46B._2yepMkVENnecIsduggABaU2qhXW.SetRenderTargets(renderTargets);
			double _09rdYyvQzUwbdQbzRZF4vbpdUCO;
			Microsoft.Xna.Framework.Point _eeWHzOz6LrTokRQr52VaB0dKbQO = _hrw3Kf8fCx7saJOmoYUD8sIz3uD._0LlFMUVNTAixukJSTpecXFIxdAl("Sheen Two", out _09rdYyvQzUwbdQbzRZF4vbpdUCO);
			_hrw3Kf8fCx7saJOmoYUD8sIz3uD._f5ctqAmdNsZ889UjM4LxDm8WGxA(skeletonMeshRenderer_0, null, delegate(int int_0, string string_0)
			{
				if (string_0 == "Sheen Two")
				{
					skeletonMeshRenderer_0.End();
					spriteBatch_0.Begin();
					if (!_Ldzm1JY9st4tknAhrglOIpwdYhn)
					{
						spriteBatch_0._f5ctqAmdNsZ889UjM4LxDm8WGxA(_bZJtpWV2Yj6GgZkeZQUmpTHxTnh, new Vector2(_eeWHzOz6LrTokRQr52VaB0dKbQO.X, _eeWHzOz6LrTokRQr52VaB0dKbQO.Y), null, null, null, (float)_09rdYyvQzUwbdQbzRZF4vbpdUCO);
					}
					if (!_rASuGHWSFVWfkpwzF8wZd9bh3XN)
					{
						spriteBatch_0._f5ctqAmdNsZ889UjM4LxDm8WGxA(_Pfaq6ajchxcqF6GecivHvHqQW6M, new Vector2(_eeWHzOz6LrTokRQr52VaB0dKbQO.X, _eeWHzOz6LrTokRQr52VaB0dKbQO.Y), null, null, null, (float)_09rdYyvQzUwbdQbzRZF4vbpdUCO);
					}
					if (!_97m6gVcwgWbLFyNUxI3P1KuD0Gn)
					{
						spriteBatch_0._f5ctqAmdNsZ889UjM4LxDm8WGxA(_BphDC8XZceMl5rqVm5zdrD6meOf, new Vector2(_eeWHzOz6LrTokRQr52VaB0dKbQO.X, _eeWHzOz6LrTokRQr52VaB0dKbQO.Y), null, null, null, (float)_09rdYyvQzUwbdQbzRZF4vbpdUCO);
					}
					spriteBatch_0.End();
					skeletonMeshRenderer_0.Begin();
				}
				else if (string_0 == "Thumb")
				{
					if (!_1gXQH16lmsacxQMOpjFFqZSmjQl)
					{
						skeletonMeshRenderer_0.End();
						spriteBatch_0.Begin();
						spriteBatch_0._f5ctqAmdNsZ889UjM4LxDm8WGxA(_Et7ViKuaneif1JVK3bifonUhKPR, new Vector2(_eeWHzOz6LrTokRQr52VaB0dKbQO.X - 16, _eeWHzOz6LrTokRQr52VaB0dKbQO.Y - 128), null, null, null, (float)_09rdYyvQzUwbdQbzRZF4vbpdUCO);
						spriteBatch_0.End();
						skeletonMeshRenderer_0.Begin();
					}
				}
				else if (!_1gXQH16lmsacxQMOpjFFqZSmjQl && _HzpuNgBJAQYObWMhiboQRiPGmvp.Contains(string_0))
				{
					return false;
				}
				return true;
			});
		}
		if (_2xrvCNtGtRPjKFYKw9nbGLrJCPy != 0 && _4L7hfXrWoDdArQiscG4ukHCV46B._5zNdOw7qHmuCAPJFMr3SsZdBlCr == null)
		{
			_lpMGMQZJYmHr6q9XBRwiM0Lse4N._f5ctqAmdNsZ889UjM4LxDm8WGxA(skeletonMeshRenderer_0);
		}
	}

	[CompilerGenerated]
	private void _uq8Rq4GCuGQy4QGu9s3PYE9GgHe()
	{
		_wTbB4YBL4PSkaotwKX3CFc50DmX._C5vPbZ72rpVMDWGuHxZuR5FNpAH("Phone answer loop");
	}

	[CompilerGenerated]
	private void _7nfe928NPd9KPPArPJXBbNyTOZs()
	{
		_wTbB4YBL4PSkaotwKX3CFc50DmX._C5vPbZ72rpVMDWGuHxZuR5FNpAH("Phone IM idle");
	}

	[CompilerGenerated]
	private void _oqZbZwE9tOfcSkViZ6NnriagwvN()
	{
		_wTbB4YBL4PSkaotwKX3CFc50DmX._C5vPbZ72rpVMDWGuHxZuR5FNpAH("Phone Call loop");
	}

	[CompilerGenerated]
	private void _z7L2U9Tw7bWomxTCk7o4hq5lAmB()
	{
		_wTbB4YBL4PSkaotwKX3CFc50DmX._C5vPbZ72rpVMDWGuHxZuR5FNpAH("Phone IM idle");
	}

	[CompilerGenerated]
	private void _ytMjqwjM52ILF41QLZdCgmhyf8D()
	{
		_wTbB4YBL4PSkaotwKX3CFc50DmX._C5vPbZ72rpVMDWGuHxZuR5FNpAH("Phone Call loop");
	}

	[CompilerGenerated]
	private void _zE6Dh759IY2DMju31JJJ4eLOlPs(Control control_0, MouseEventArgs mouseEventArgs_0)
	{
		_3AaEmo54VzWybgrrg7I8Z9JUV1e = true;
		_9GQBAH2pi8Sm6ph1s6InjyQGe6R._GtkWDtXwQHwgWY4aFkacjfUDyzb($"Are you sure you wish to remove {_H6UwM4zjGzglzMY478iBDDvTk6I}? This will reset all progression!", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, 250, delegate(int int_0)
		{
			if (int_0 == 1)
			{
				_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t()._Qd7anWdHpZ5AgaUbbEv07BnnI6Q(_H6UwM4zjGzglzMY478iBDDvTk6I);
				_9GQBAH2pi8Sm6ph1s6InjyQGe6R._0pVU36wp9GYD1jM18raZtVEbA9q($"{_H6UwM4zjGzglzMY478iBDDvTk6I} will be available again after you went home.", 250, "OK", delegate
				{
					_270ZVixWLhgEiLA6QosapJMyU6h();
					_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
				});
			}
			else
			{
				_270ZVixWLhgEiLA6QosapJMyU6h();
				_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
			}
		});
	}

	[CompilerGenerated]
	private void _7FN07CzDf8Fapy4eUp1zYFqADbC(int int_0)
	{
		if (int_0 == 1)
		{
			_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t()._Qd7anWdHpZ5AgaUbbEv07BnnI6Q(_H6UwM4zjGzglzMY478iBDDvTk6I);
			_9GQBAH2pi8Sm6ph1s6InjyQGe6R._0pVU36wp9GYD1jM18raZtVEbA9q($"{_H6UwM4zjGzglzMY478iBDDvTk6I} will be available again after you went home.", 250, "OK", delegate
			{
				_270ZVixWLhgEiLA6QosapJMyU6h();
				_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
			});
		}
		else
		{
			_270ZVixWLhgEiLA6QosapJMyU6h();
			_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
		}
	}

	[CompilerGenerated]
	private void _6V6etKcvXXKzNlLSrm4p0ic46of()
	{
		_270ZVixWLhgEiLA6QosapJMyU6h();
		_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
	}

	[CompilerGenerated]
	private void _LZqSHXlaGtTobsgnENx9E3EloPB(Control control_0, MouseEventArgs mouseEventArgs_0)
	{
		string name = _4L7hfXrWoDdArQiscG4ukHCV46B._XbOXR6AypLIdJ3gBMGseGi3Wi2i.GetType().Name;
		string text = _4L7hfXrWoDdArQiscG4ukHCV46B._KVSwpLj0RvURRswHn7ogRy4BRfd?.GetType().Name;
		if (name == "PlayerSexScene" && text == _iVvswmrDLetaWXmgd38sJtDnLs[_H6UwM4zjGzglzMY478iBDDvTk6I])
		{
			_nkzqFdEfDyLcyGikIKGcHjklI4y._zunSyHn4DekdA6CngP10dXcR1kq("<i>" + _H6UwM4zjGzglzMY478iBDDvTk6I.ToString() + " is kind of... preoccupied right now.</i>", "%playername%", Color.White);
		}
		else if (name != "BedroomScene" && name != "LivingRoomScene")
		{
			_nkzqFdEfDyLcyGikIKGcHjklI4y._zunSyHn4DekdA6CngP10dXcR1kq("<i>Reception is really bad at the moment, I should try again when I'm back at home.</i>", "%playername%", Color.White);
		}
		else
		{
			_WDhVhBhQHGowaONqV87v7EaCvro(_H6UwM4zjGzglzMY478iBDDvTk6I);
		}
	}

	[CompilerGenerated]
	private void _1hGbSwTABxDpIetADMbCrWOHTnmb(Control control_0, MouseEventArgs mouseEventArgs_0)
	{
		_RiDuYMeg3EHnBUteUcAb8VlfQVl();
		_4L7hfXrWoDdArQiscG4ukHCV46B._k9wUPeU1Ga7cygiuGP8TT6aPLWF<PhoneShootingRangeMiniGameScene>();
	}

	[CompilerGenerated]
	private void _dzvdiBCzexDaTaw0dtlOYpufAN9(Control control_0, MouseEventArgs mouseEventArgs_0)
	{
		_4L7hfXrWoDdArQiscG4ukHCV46B._xyl3Tv5KdR5eezDgagxbBcS3cwt("MiniGameCooking");
		_RiDuYMeg3EHnBUteUcAb8VlfQVl();
	}

	[CompilerGenerated]
	private void _mtSlo389ePbyE51TlqnT5fBb6gI(Control control_0, MouseEventArgs mouseEventArgs_0)
	{
		_4L7hfXrWoDdArQiscG4ukHCV46B._xyl3Tv5KdR5eezDgagxbBcS3cwt("NudesRemy");
		_RiDuYMeg3EHnBUteUcAb8VlfQVl();
	}

	[CompilerGenerated]
	private void _wxGBGUQYvk0di1prM3ppqYDhqrj(Control control_0, MouseEventArgs mouseEventArgs_0)
	{
		string name = _4L7hfXrWoDdArQiscG4ukHCV46B._XbOXR6AypLIdJ3gBMGseGi3Wi2i.GetType().Name;
		if (name.StartsWith("Club"))
		{
			_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.Soundtrack);
		}
		else
		{
			_nkzqFdEfDyLcyGikIKGcHjklI4y._zunSyHn4DekdA6CngP10dXcR1kq("<i>Hmm, the operator is telling me: 'The number you are trying to reach is currently unavailable'. I guess the DJ only has his phone enabled during Club hours.</i>", "%playername%", Color.White);
		}
	}

	[CompilerGenerated]
	private void _6eyh0eOS36XIX7OnTaYCDcxJ4pd(Control control_0, MouseEventArgs mouseEventArgs_0)
	{
		_4L7hfXrWoDdArQiscG4ukHCV46B._aJh9CibG5YKhkExxgRyVopdfSeJ._3xUr1Yv0PbZlcGdOrfbCAwOXa5c();
	}

	[CompilerGenerated]
	private void _DYKzI7YGQNT3w0xlrg3r0WgZqmd(Control control_0, MouseEventArgs mouseEventArgs_0)
	{
		_3AaEmo54VzWybgrrg7I8Z9JUV1e = true;
		_9GQBAH2pi8Sm6ph1s6InjyQGe6R._GtkWDtXwQHwgWY4aFkacjfUDyzb("Are you sure you wish to remove this message?", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, 250, delegate(int int_0)
		{
			if (int_0 == 1)
			{
				_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
				opIJo2jLUqdOL5yAFP4yzXce0DG._7u6aevGWBE7ABqrBXoaPTkywcVo.Remove(_ERdtO3cV05TBYFV0mT86wv01GJf);
				_ERdtO3cV05TBYFV0mT86wv01GJf = null;
				_270ZVixWLhgEiLA6QosapJMyU6h();
			}
			_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
		});
	}

	[CompilerGenerated]
	private void _HAv1SP3Xi5hrN1p5KQH4LuKhnic(int int_0)
	{
		if (int_0 == 1)
		{
			_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
			opIJo2jLUqdOL5yAFP4yzXce0DG._7u6aevGWBE7ABqrBXoaPTkywcVo.Remove(_ERdtO3cV05TBYFV0mT86wv01GJf);
			_ERdtO3cV05TBYFV0mT86wv01GJf = null;
			_270ZVixWLhgEiLA6QosapJMyU6h();
		}
		_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
	}

	[CompilerGenerated]
	private void _X6LAJsK8XgP7w5f1pSpUUYqKMde()
	{
		_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
	}

	[CompilerGenerated]
	private void _SA8vRmhWDi8XVPLQC7AnnCHtPrc()
	{
		_77rSPCEs6VEYjlGrwW0KN0btLEG = false;
		_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
	}

	[CompilerGenerated]
	private void _dnDete0UXjgo3BK3QwgupWXv2Ee(Control control_0, MouseEventArgs mouseEventArgs_0)
	{
		_3AaEmo54VzWybgrrg7I8Z9JUV1e = true;
		_9GQBAH2pi8Sm6ph1s6InjyQGe6R._GtkWDtXwQHwgWY4aFkacjfUDyzb("Are you sure you wish to customize your character? This may break some active dates even if make no changes!", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, 250, delegate(int int_0)
		{
			if (int_0 == 1)
			{
				_RiDuYMeg3EHnBUteUcAb8VlfQVl();
				_4L7hfXrWoDdArQiscG4ukHCV46B._k9wUPeU1Ga7cygiuGP8TT6aPLWF<BackToPlayerCustomizationScene>();
			}
			_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
		});
	}

	[CompilerGenerated]
	private void _ibyikqci0u66RjCcP7JC4vdPHGD(int int_0)
	{
		if (int_0 == 1)
		{
			_RiDuYMeg3EHnBUteUcAb8VlfQVl();
			_4L7hfXrWoDdArQiscG4ukHCV46B._k9wUPeU1Ga7cygiuGP8TT6aPLWF<BackToPlayerCustomizationScene>();
		}
		_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
	}

	[CompilerGenerated]
	private void _9FlZLc3FiHBvvTiDsc0d1p0hasg(Control control_0, MouseEventArgs mouseEventArgs_0)
	{
		_RiDuYMeg3EHnBUteUcAb8VlfQVl();
		_4L7hfXrWoDdArQiscG4ukHCV46B._k9wUPeU1Ga7cygiuGP8TT6aPLWF<BedroomScene>();
	}

	[CompilerGenerated]
	private void _NH1HOjH9iFDqnyyrcnsEpDBjk7N(Control control_0, MouseEventArgs mouseEventArgs_0)
	{
		_RiDuYMeg3EHnBUteUcAb8VlfQVl();
		_4L7hfXrWoDdArQiscG4ukHCV46B._k9wUPeU1Ga7cygiuGP8TT6aPLWF<ClubInsideScene>();
	}

	[CompilerGenerated]
	private void _KYMoHBbOq56T4I1dWDplBVdFiUB(Control control_0, MouseEventArgs mouseEventArgs_0)
	{
		_RiDuYMeg3EHnBUteUcAb8VlfQVl();
		_kf3EbE0B70xGe1szklqAZyCqoLj = false;
		_4L7hfXrWoDdArQiscG4ukHCV46B._k9wUPeU1Ga7cygiuGP8TT6aPLWF<MainMenuScene>();
	}

	[CompilerGenerated]
	private void _CXERWutNbwOjWbplSI9ohKinpAO(Control control_0, MouseEventArgs mouseEventArgs_0)
	{
		_3AaEmo54VzWybgrrg7I8Z9JUV1e = true;
		_9GQBAH2pi8Sm6ph1s6InjyQGe6R._GtkWDtXwQHwgWY4aFkacjfUDyzb("Are you sure you wish to quit the game? All unsaved progress will be lost!", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, 250, delegate(int int_0)
		{
			if (int_0 == 1)
			{
				_4L7hfXrWoDdArQiscG4ukHCV46B._udfEpcIRn7lWl5Lvjdyu0aG0A7G();
			}
			_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
		});
	}

	[CompilerGenerated]
	private void _KxEaqBMxbKUC1uoNexV1T0G13UH(int int_0)
	{
		if (int_0 == 1)
		{
			_4L7hfXrWoDdArQiscG4ukHCV46B._udfEpcIRn7lWl5Lvjdyu0aG0A7G();
		}
		_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
	}

	[CompilerGenerated]
	private void _QrVkLhoCh4aBUIhEyFneetZLvzE()
	{
		_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
	}

	[CompilerGenerated]
	private Squid.Point _Xz25BlZJnUNbNDPMKaWNQy0jbnY(Squid.Point point_0)
	{
		double double_;
		Microsoft.Xna.Framework.Point point = _hrw3Kf8fCx7saJOmoYUD8sIz3uD._0LlFMUVNTAixukJSTpecXFIxdAl("Sheen Two", out double_);
		Matrix matrix = Matrix.CreateTranslation(-point.X, -point.Y, 0f) * Matrix.CreateRotationZ((float)(0.0 - double_));
		Vector2 vector = Vector2.Transform(new Vector2(point_0.x, point_0.y), matrix);
		return new Squid.Point((int)vector.X, (int)vector.Y);
	}

	[CompilerGenerated]
	private void _9RPCNJm7hEe0iO5j7fpMG6Dx2Pq()
	{
		_TZx1AkahTLXoM2XUbm5U8YJOScb = false;
		_j2OEvLQtM2lODSmH3ZFP6wWCWpF = _fFGgY4gvWNcTLSlsfe9k99ctumb.ArmUp;
		_aEgXugtdIuFieAwnDhnIlYNEysg();
	}

	[CompilerGenerated]
	private void _QucZvBWwNEnBE2bIgx76M4QzBhR()
	{
		_TZx1AkahTLXoM2XUbm5U8YJOScb = false;
		_j2OEvLQtM2lODSmH3ZFP6wWCWpF = _fFGgY4gvWNcTLSlsfe9k99ctumb.ArmDown;
	}

	static void smethod_0(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._lkaN4ygxDlKvzKEBuD7dRjrU20F();
	}

	static void smethod_1(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, Action action_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._SPUoP3ABwpgQinJfKUM5qBbYSvr(string_0, action_0);
	}

	static void smethod_2(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, Action<int> action_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._C5vPbZ72rpVMDWGuHxZuR5FNpAH(string_0, action_0);
	}

	static ContentManager smethod_3(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8;
	}

	static string smethod_4(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static _nR8eroJOHehP0ZGyyTveo6aMTHg smethod_5(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._5zNdOw7qHmuCAPJFMr3SsZdBlCr;
	}

	static _691ooXdgg17CWFkMkjedKBBBfYw smethod_6(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._aJh9CibG5YKhkExxgRyVopdfSeJ;
	}

	static void smethod_7(_691ooXdgg17CWFkMkjedKBBBfYw _691ooXdgg17CWFkMkjedKBBBfYw_0, string string_0)
	{
		_691ooXdgg17CWFkMkjedKBBBfYw_0._vVZVLriSGPExpn1KeobglMabsoi(string_0);
	}

	static _wRd4nHuQQlAPEwrHOGkBfut6Uip smethod_8(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._vsceSzSIjBy2nZrCxAzKZbUiwLq;
	}

	static void smethod_9(_wRd4nHuQQlAPEwrHOGkBfut6Uip _wRd4nHuQQlAPEwrHOGkBfut6Uip_0, bool bool_0)
	{
		_wRd4nHuQQlAPEwrHOGkBfut6Uip_0._1LQOhiUdxWk8bRA1sYnQMSYcjVm = bool_0;
	}

	static void smethod_10(bool bool_0)
	{
		_7UlnfykmEmZDFt3BmCKZekI43Ih._zI8afstSBU4SEMWSnQCa7srUFu = bool_0;
	}

	static ControlCollection smethod_11(Desktop desktop_0)
	{
		return desktop_0.Controls;
	}

	static ListBox smethod_12()
	{
		return new ListBox();
	}

	static void smethod_13(Control control_0, DockStyle dockStyle_0)
	{
		control_0.Dock = dockStyle_0;
	}

	static ScrollBar smethod_14(ListBox listBox_0)
	{
		return listBox_0.Scrollbar;
	}

	static void smethod_15(ScrollBar scrollBar_0, float float_0)
	{
		scrollBar_0.MouseScrollSpeed = float_0;
	}

	static Button smethod_16(ScrollBar scrollBar_0)
	{
		return scrollBar_0.ButtonUp;
	}

	static void smethod_17(Control control_0, bool bool_0)
	{
		control_0.Visible = bool_0;
	}

	static Button smethod_18(ScrollBar scrollBar_0)
	{
		return scrollBar_0.ButtonDown;
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG smethod_19()
	{
		return _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
	}

	static int smethod_20(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0, string string_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._fvTKDuNATrUxfXZVvltePz3vYkK(string_0);
	}

	static ImageControl smethod_21()
	{
		return new ImageControl();
	}

	static void smethod_22(ImageControl imageControl_0, string string_0)
	{
		imageControl_0.Texture = string_0;
	}

	static Panel smethod_23()
	{
		return new Panel();
	}

	static Label smethod_24()
	{
		return new Label();
	}

	static void smethod_25(Label label_0, string string_0)
	{
		label_0.Text = string_0;
	}

	static void smethod_26(Control control_0, string string_0)
	{
		control_0.Style = string_0;
	}

	static CustomListBoxItem smethod_27()
	{
		return new CustomListBoxItem();
	}

	static ListBoxItem smethod_28()
	{
		return new ListBoxItem();
	}

	static List<_iDN1IKOu3e1uADYzeMEUon5D9fg> smethod_29(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._7u6aevGWBE7ABqrBXoaPTkywcVo;
	}

	static string smethod_30(_iDN1IKOu3e1uADYzeMEUon5D9fg _iDN1IKOu3e1uADYzeMEUon5D9fg_0)
	{
		return _iDN1IKOu3e1uADYzeMEUon5D9fg_0._dFaIUhufvE2Ld5IjNEwmPAqqraj;
	}

	static List<_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p> smethod_31(bool bool_0)
	{
		return _DW9IcpdMEINZmuzfrqmwsduBGih._25D1ZH2er0EbpKmvFksAbFjP2OX(bool_0);
	}

	static string smethod_32(_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p _3CCr8Bt1rkuzt0M6gYLbceJGV0p_0)
	{
		return _3CCr8Bt1rkuzt0M6gYLbceJGV0p_0._RB8fRXeQvK5vs7JEA0XfVCEpg1i;
	}

	static int smethod_33(string string_0, char char_0)
	{
		return string_0.IndexOf(char_0);
	}

	static string smethod_34(string string_0, int int_0, int int_1)
	{
		return string_0.Substring(int_0, int_1);
	}

	static string smethod_35(string string_0)
	{
		return string_0.Trim();
	}

	static string smethod_36(string string_0, int int_0)
	{
		return string_0.Substring(int_0);
	}

	static string smethod_37(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	static DropDownList smethod_38()
	{
		return new DropDownList();
	}

	static Label smethod_39(DropDownList dropDownList_0)
	{
		return dropDownList_0.Label;
	}

	static _gJR4g7ak0hsZAUWX1vJbMqG2P5I smethod_40(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._Qj2G6fpAF4mGsATgkV8DPBF3aA1A;
	}

	static void smethod_41(_gJR4g7ak0hsZAUWX1vJbMqG2P5I _gJR4g7ak0hsZAUWX1vJbMqG2P5I_0, Action action_0)
	{
		_gJR4g7ak0hsZAUWX1vJbMqG2P5I_0._PYAXEqRAOkDRRNqm1k71R7GJTJK(action_0);
	}

	static void smethod_42(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, string string_0)
	{
		_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._xyl3Tv5KdR5eezDgagxbBcS3cwt(string_0);
	}

	static bool smethod_43()
	{
		return _iExD93IWLlzVfXsU9wyrEvWgJsg._b52DDz3MN1kD8sgdQhCNO1tJRNn;
	}

	static string smethod_44(string string_0, object object_0)
	{
		return string.Format(string_0, object_0);
	}

	static void smethod_45(Desktop desktop_0, string string_0, int int_0, string string_1, Action action_0)
	{
		desktop_0._0pVU36wp9GYD1jM18raZtVEbA9q(string_0, int_0, string_1, action_0);
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U smethod_46(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Mz7LwHZqoGBscApFXmff1kEQnGY;
	}

	static bool smethod_47(Enum enum_0, Enum enum_1)
	{
		return enum_0.HasFlag(enum_1);
	}

	static Color smethod_48(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._1ZKGQXLRAHEJR8v7jhlDsyOVLcz;
	}

	static Color smethod_49(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._8rDSn6e9Ip9WdOogjhIn8YlL1oM;
	}

	static void smethod_50(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, float float_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._aAoZaDNczeScsMfLlGSfAzey9SQ(string_0, float_0);
	}

	static Color smethod_51(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G;
	}

	static void smethod_52(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, Color color_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._VoeevpFh2kLKfHtpPDXWt0TFbuH(string_0, color_0);
	}

	static Color smethod_53(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ;
	}

	static Color smethod_54(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._FrsyMDX7TebzFk8nSLTyRDPi1QH;
	}

	static bool smethod_55(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._VmNLhqrIwSnE6JnCYiBcxnSqnEV;
	}

	static Color smethod_56(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._in5HHYmrdLTFpkgc8aimJpXqAXB;
	}

	static Color smethod_57(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._uOkbmfW26QVAvyEMQakki9kTMDbA;
	}

	static _3FFZvGWTAe7rsviKkDPTXEVjxWf smethod_58(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._RbWJ7YGnYHCSoD44MRW1h5X6E7E;
	}

	static bool smethod_59(_3FFZvGWTAe7rsviKkDPTXEVjxWf _3FFZvGWTAe7rsviKkDPTXEVjxWf_0, Microsoft.Xna.Framework.Input.Keys keys_0)
	{
		return _3FFZvGWTAe7rsviKkDPTXEVjxWf_0._fy5ebLnmRsRXv9v7RKTFU5CGMaH(keys_0);
	}

	static void smethod_60(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, GameTime gameTime_0, float float_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0, float_0);
	}

	static void smethod_61(Desktop desktop_0)
	{
		desktop_0.Update();
	}

	static Microsoft.Xna.Framework.Point smethod_62(_3FFZvGWTAe7rsviKkDPTXEVjxWf _3FFZvGWTAe7rsviKkDPTXEVjxWf_0)
	{
		return _3FFZvGWTAe7rsviKkDPTXEVjxWf_0._U7CeYBJ1v1SoUxpX8emsQ9mWl5b;
	}

	static Microsoft.Xna.Framework.Point smethod_63(_wRd4nHuQQlAPEwrHOGkBfut6Uip _wRd4nHuQQlAPEwrHOGkBfut6Uip_0, Microsoft.Xna.Framework.Point point_0)
	{
		return _wRd4nHuQQlAPEwrHOGkBfut6Uip_0._u7uCdK9i8FnWhiaPn2bO2wIgUUuA(point_0);
	}

	static bool smethod_64(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, float float_0, float float_1)
	{
		return _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._3nKd9Dk3YeX87QB5dROwYUzczsN(string_0, float_0, float_1);
	}

	static bool smethod_65(_3FFZvGWTAe7rsviKkDPTXEVjxWf _3FFZvGWTAe7rsviKkDPTXEVjxWf_0, _PMeRYZJaBCqgB9uADJFP3c14lxq _PMeRYZJaBCqgB9uADJFP3c14lxq_0)
	{
		return _3FFZvGWTAe7rsviKkDPTXEVjxWf_0._fy5ebLnmRsRXv9v7RKTFU5CGMaH(_PMeRYZJaBCqgB9uADJFP3c14lxq_0);
	}

	static GraphicsDevice smethod_66(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._2yepMkVENnecIsduggABaU2qhXW;
	}

	static RenderTargetBinding[] smethod_67(GraphicsDevice graphicsDevice_0)
	{
		return graphicsDevice_0.GetRenderTargets();
	}

	static void smethod_68(GraphicsDevice graphicsDevice_0, RenderTarget2D renderTarget2D_0)
	{
		graphicsDevice_0.SetRenderTarget(renderTarget2D_0);
	}

	static void smethod_69(Desktop desktop_0)
	{
		desktop_0.Draw();
	}

	static void smethod_70(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, SkeletonMeshRenderer skeletonMeshRenderer_0, Texture2D texture2D_0, Func<int, string, bool> func_0, Color? nullable_0, float float_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._f5ctqAmdNsZ889UjM4LxDm8WGxA(skeletonMeshRenderer_0, texture2D_0, func_0, nullable_0, float_0);
	}

	static void smethod_71(GraphicsDevice graphicsDevice_0, RenderTargetBinding[] renderTargetBinding_0)
	{
		graphicsDevice_0.SetRenderTargets(renderTargetBinding_0);
	}

	static Microsoft.Xna.Framework.Point smethod_72(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, ref double double_0)
	{
		return _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._0LlFMUVNTAixukJSTpecXFIxdAl(string_0, out double_0);
	}

	static void smethod_73(Desktop desktop_0, string string_0, string[] string_1, int int_0, Action<int> action_0)
	{
		desktop_0._GtkWDtXwQHwgWY4aFkacjfUDyzb(string_0, string_1, int_0, action_0);
	}

	static void smethod_74(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts ephoneContacts_0)
	{
		_opIJo2jLUqdOL5yAFP4yzXce0DG_0._Qd7anWdHpZ5AgaUbbEv07BnnI6Q(ephoneContacts_0);
	}

	static _7UlnfykmEmZDFt3BmCKZekI43Ih smethod_75(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._XbOXR6AypLIdJ3gBMGseGi3Wi2i;
	}

	static Type smethod_76(object object_0)
	{
		return object_0.GetType();
	}

	static string smethod_77(MemberInfo memberInfo_0)
	{
		return memberInfo_0.Name;
	}

	static _TwlwMC1hhdSzamwGWEBxuUkz1gH smethod_78(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._KVSwpLj0RvURRswHn7ogRy4BRfd;
	}

	static Type smethod_79(object object_0)
	{
		return object_0.GetType();
	}

	static bool smethod_80(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	static void smethod_81(string string_0, string string_1, Color color_0)
	{
		_nkzqFdEfDyLcyGikIKGcHjklI4y._zunSyHn4DekdA6CngP10dXcR1kq(string_0, string_1, color_0);
	}

	static bool smethod_82(string string_0, string string_1)
	{
		return string_0 != string_1;
	}

	static bool smethod_83(string string_0, string string_1)
	{
		return string_0.StartsWith(string_1);
	}

	static void smethod_84(_691ooXdgg17CWFkMkjedKBBBfYw _691ooXdgg17CWFkMkjedKBBBfYw_0)
	{
		_691ooXdgg17CWFkMkjedKBBBfYw_0._3xUr1Yv0PbZlcGdOrfbCAwOXa5c();
	}

	static void smethod_85(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._udfEpcIRn7lWl5Lvjdyu0aG0A7G();
	}
}
