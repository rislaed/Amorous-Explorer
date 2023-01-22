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
			_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._H6UwM4zjGzglzMY478iBDDvTk6I = (_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts)_4wrjSKvuvZUTRPI3prAOEvBGDhD.get_Value();
			_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.ContactsInformation);
		}

		static object smethod_0(CustomListBoxItem customListBoxItem_0)
		{
			return customListBoxItem_0.get_Value();
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
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
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
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
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
			_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._DF24JUrPFA6rJ2cQrOTlpC3I4FF = _XEgAfmv7sJWJSaC2diC3eaD4Fgl.get_Value() / 100f;
		}

		internal void _do82cy4M3hWWZrTatQMCPffcAPaA(Control control_0)
		{
			_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._7NidKjx61ui5CP7JojwfqxH4aKC = _gjeIIVx9bHyd0aMj0WD483nrLWK.get_Value() / 100f;
		}

		internal void _at091i3KPJkfwydSTUXr7ajv7mF(Control control_0)
		{
			_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._2g4Ch8GXdUt0oEbdCZUY2QMbIuH = _5mK9ExiyKm0md8q4J1C6xc4TzdF.get_Value() / 100f;
		}

		static _eNOTHZZiu5nx6PrADzfLyng3Igc smethod_0()
		{
			return _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF;
		}

		static float smethod_1(Slider slider_0)
		{
			return slider_0.get_Value();
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
			_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._sbK0941BvW8HgPboNwOhIAd2jP3 = _feL3soNn6ZWaJqYfjYJUyH118tF.get_Checked();
			_nkzqFdEfDyLcyGikIKGcHjklI4y._fUgDiz7KX8TZUVzFlTeXMOhmfUT = _feL3soNn6ZWaJqYfjYJUyH118tF.get_Checked();
		}

		static _eNOTHZZiu5nx6PrADzfLyng3Igc smethod_0()
		{
			return _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF;
		}

		static bool smethod_1(CheckBox checkBox_0)
		{
			return checkBox_0.get_Checked();
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
			_qhAM4Wrvf8c5jzKBQqLfosAE9D((int)listBoxItem_0.get_Value());
		}

		static object smethod_0(ListBoxItem listBoxItem_0)
		{
			return listBoxItem_0.get_Value();
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
				((Label)_diVdxVCKW4CzhbYSG15BcHJB0Ub).set_Text(_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF ? "Disable SFW" : "Enable SFW");
			});
		}

		internal void _8nn4N2xgzjlh5Yz5WSSHCJ9URjf()
		{
			_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF = !_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF;
			_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._DAsCL6JdGst3kJHpcbztigO3VEV();
			((Label)_diVdxVCKW4CzhbYSG15BcHJB0Ub).set_Text(_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF ? "Disable SFW" : "Enable SFW");
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
			label_0.set_Text(string_0);
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
				((Label)_Epeel2m9h5O12V2ERwlnNTE3FdM).set_Text(_iExD93IWLlzVfXsU9wyrEvWgJsg._b52DDz3MN1kD8sgdQhCNO1tJRNn ? "Disable Topless Cheat" : "Enable Topless Cheat");
			});
		}

		internal void _SIpzzpgYIDeDw3DbVv5Fv9S6iOg()
		{
			_iExD93IWLlzVfXsU9wyrEvWgJsg._b52DDz3MN1kD8sgdQhCNO1tJRNn = !_iExD93IWLlzVfXsU9wyrEvWgJsg._b52DDz3MN1kD8sgdQhCNO1tJRNn;
			((Label)_Epeel2m9h5O12V2ERwlnNTE3FdM).set_Text(_iExD93IWLlzVfXsU9wyrEvWgJsg._b52DDz3MN1kD8sgdQhCNO1tJRNn ? "Disable Topless Cheat" : "Enable Topless Cheat");
		}

		internal void _8n73s4MCzZ9OGqXivRGVyT81BNJ(Control control_0, MouseEventArgs mouseEventArgs_0)
		{
			_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._YdyKdWT8QbQOIWkgEuPe6a9hJtd(delegate
			{
				_iExD93IWLlzVfXsU9wyrEvWgJsg._pKBiGAgDu5WqoykkGBaEGnP7oMj = !_iExD93IWLlzVfXsU9wyrEvWgJsg._pKBiGAgDu5WqoykkGBaEGnP7oMj;
				((Label)_FxyX2MMMdsf69424VDXa8LqP1nq).set_Text(_iExD93IWLlzVfXsU9wyrEvWgJsg._pKBiGAgDu5WqoykkGBaEGnP7oMj ? "Disable Bottomless Cheat" : "Enable Bottomless Cheat");
			});
		}

		internal void _vsOcQWBxGADsTpFI7jsoDDsob3A()
		{
			_iExD93IWLlzVfXsU9wyrEvWgJsg._pKBiGAgDu5WqoykkGBaEGnP7oMj = !_iExD93IWLlzVfXsU9wyrEvWgJsg._pKBiGAgDu5WqoykkGBaEGnP7oMj;
			((Label)_FxyX2MMMdsf69424VDXa8LqP1nq).set_Text(_iExD93IWLlzVfXsU9wyrEvWgJsg._pKBiGAgDu5WqoykkGBaEGnP7oMj ? "Disable Bottomless Cheat" : "Enable Bottomless Cheat");
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
			label_0.set_Text(string_0);
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
		public Point _eeWHzOz6LrTokRQr52VaB0dKbQO;

		public double _09rdYyvQzUwbdQbzRZF4vbpdUCO;

		public _7ogzNGSGXiMOYh3BcasDaqG9WpT _wr6xcvFOgUbaTATC17S6Y9v3y3S;

		internal bool _J03dD2qBGOpQ04m2KKxkL3CkUtCb(int int_0, string string_0)
		{
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_0191: Unknown result type (might be due to invalid IL or missing references)
			//IL_028f: Unknown result type (might be due to invalid IL or missing references)
			if (string_0 == "Sheen Two")
			{
				_wr6xcvFOgUbaTATC17S6Y9v3y3S._r1FADOtDcwMP4Tohv3ntBfhuMNp.End();
				_wr6xcvFOgUbaTATC17S6Y9v3y3S._EKVVcDQFi8O0uiXnuvUCgwRPdh4.Begin();
				if (!_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Ldzm1JY9st4tknAhrglOIpwdYhn)
				{
					_wr6xcvFOgUbaTATC17S6Y9v3y3S._EKVVcDQFi8O0uiXnuvUCgwRPdh4._f5ctqAmdNsZ889UjM4LxDm8WGxA((Texture2D)(object)_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._bZJtpWV2Yj6GgZkeZQUmpTHxTnh, (Vector2?)new Vector2((float)_eeWHzOz6LrTokRQr52VaB0dKbQO.X, (float)_eeWHzOz6LrTokRQr52VaB0dKbQO.Y), (Rectangle?)null, (Rectangle?)null, (Vector2?)null, (float)_09rdYyvQzUwbdQbzRZF4vbpdUCO, (Vector2?)null, (Color?)null, (SpriteEffects)0, 0f);
				}
				if (!_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._rASuGHWSFVWfkpwzF8wZd9bh3XN)
				{
					_wr6xcvFOgUbaTATC17S6Y9v3y3S._EKVVcDQFi8O0uiXnuvUCgwRPdh4._f5ctqAmdNsZ889UjM4LxDm8WGxA((Texture2D)(object)_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Pfaq6ajchxcqF6GecivHvHqQW6M, (Vector2?)new Vector2((float)_eeWHzOz6LrTokRQr52VaB0dKbQO.X, (float)_eeWHzOz6LrTokRQr52VaB0dKbQO.Y), (Rectangle?)null, (Rectangle?)null, (Vector2?)null, (float)_09rdYyvQzUwbdQbzRZF4vbpdUCO, (Vector2?)null, (Color?)null, (SpriteEffects)0, 0f);
				}
				if (!_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._97m6gVcwgWbLFyNUxI3P1KuD0Gn)
				{
					_wr6xcvFOgUbaTATC17S6Y9v3y3S._EKVVcDQFi8O0uiXnuvUCgwRPdh4._f5ctqAmdNsZ889UjM4LxDm8WGxA(_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._BphDC8XZceMl5rqVm5zdrD6meOf, (Vector2?)new Vector2((float)_eeWHzOz6LrTokRQr52VaB0dKbQO.X, (float)_eeWHzOz6LrTokRQr52VaB0dKbQO.Y), (Rectangle?)null, (Rectangle?)null, (Vector2?)null, (float)_09rdYyvQzUwbdQbzRZF4vbpdUCO, (Vector2?)null, (Color?)null, (SpriteEffects)0, 0f);
				}
				_wr6xcvFOgUbaTATC17S6Y9v3y3S._EKVVcDQFi8O0uiXnuvUCgwRPdh4.End();
				_wr6xcvFOgUbaTATC17S6Y9v3y3S._r1FADOtDcwMP4Tohv3ntBfhuMNp.Begin(0f, 0f, 1f);
			}
			else if (string_0 == "Thumb")
			{
				if (!_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._1gXQH16lmsacxQMOpjFFqZSmjQl)
				{
					_wr6xcvFOgUbaTATC17S6Y9v3y3S._r1FADOtDcwMP4Tohv3ntBfhuMNp.End();
					_wr6xcvFOgUbaTATC17S6Y9v3y3S._EKVVcDQFi8O0uiXnuvUCgwRPdh4.Begin();
					_wr6xcvFOgUbaTATC17S6Y9v3y3S._EKVVcDQFi8O0uiXnuvUCgwRPdh4._f5ctqAmdNsZ889UjM4LxDm8WGxA(_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Et7ViKuaneif1JVK3bifonUhKPR, (Vector2?)new Vector2((float)(_eeWHzOz6LrTokRQr52VaB0dKbQO.X - 16), (float)(_eeWHzOz6LrTokRQr52VaB0dKbQO.Y - 128)), (Rectangle?)null, (Rectangle?)null, (Vector2?)null, (float)_09rdYyvQzUwbdQbzRZF4vbpdUCO, (Vector2?)null, (Color?)null, (SpriteEffects)0, 0f);
					_wr6xcvFOgUbaTATC17S6Y9v3y3S._EKVVcDQFi8O0uiXnuvUCgwRPdh4.End();
					_wr6xcvFOgUbaTATC17S6Y9v3y3S._r1FADOtDcwMP4Tohv3ntBfhuMNp.Begin(0f, 0f, 1f);
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

	private readonly Dictionary<_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts, Rectangle> _kALYOlSwbvFyd9uFqFZW8Y2IsnL = new Dictionary<_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts, Rectangle>
	{
		{
			_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Coby,
			new Rectangle(275, 189, 268, 158)
		},
		{
			_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Dustin,
			new Rectangle(547, 351, 268, 158)
		},
		{
			_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Jax,
			new Rectangle(819, 189, 268, 158)
		},
		{
			_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Lex,
			new Rectangle(275, 351, 268, 158)
		},
		{
			_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Mercy,
			new Rectangle(1091, 351, 268, 158)
		},
		{
			_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Remy,
			new Rectangle(1091, 189, 268, 158)
		},
		{
			_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Seth,
			new Rectangle(1363, 351, 268, 158)
		},
		{
			_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Skye,
			new Rectangle(1363, 189, 268, 158)
		},
		{
			_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Zenith,
			new Rectangle(1635, 189, 268, 158)
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
		Control val;
		switch (_saaJnL0DI6B89XWRulJZ4KC1I1g)
		{
		default:
			_Ldzm1JY9st4tknAhrglOIpwdYhn = true;
			return;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.Contacts:
			val = (Control)(object)_NWt4WEiiiqjMHAUuqWscxChtSMd();
			break;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.ContactsInformation:
			val = _kcNoqTwN559GGLalkuw5udBAUZB();
			break;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.ContactsInformationDJ:
			val = _h2ArPDECvhhh0z0Z51CaUxB7rAr();
			break;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.Soundtrack:
			val = (Control)(object)_hiWNprom67B9EJO4loqBfhvB4hX();
			break;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.Diary:
			val = (Control)(object)_YGPgft9Vo9UMBMfVtN34XoT93HD();
			break;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.DiaryMessages:
			val = (Control)(object)_ZAzvI9G8CsjLJ0AWtoSCmHUuR2q();
			break;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.DiaryMessagesInformation:
			val = (Control)(object)_yE1MXqtEKITxyL75pITcd8fNpsi();
			break;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.DiaryAchievements:
			val = (Control)(object)_jv6KLyNe1t3TATNww1TiWv9ZVLF();
			break;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.DiarySave:
			val = (Control)(object)_QmCbnBf76ITvR2HA7WYF44qkJWK();
			break;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.DiaryLoad:
			val = (Control)(object)_mKzC4RKCG3B1ZBdWwcAp79gd8NaA();
			break;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.Audio:
			val = _fM96M1a1ZZUtzPyevCm45mKPeQg();
			break;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.ChatSettings:
			val = _H2blb6Djx9JemSUBYepwlzNOXxz();
			break;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.Gallery:
			val = (Control)(object)_1Bze6b62yGQDi3JBE0TyQmPGkzU();
			break;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.Power:
			val = (Control)(object)_dT5L6g1CEsgeYg5W9sVqR2trRSK();
			break;
		}
		_Ldzm1JY9st4tknAhrglOIpwdYhn = false;
		((ActiveList<Control>)(object)_9GQBAH2pi8Sm6ph1s6InjyQGe6R.get_Controls()).Clear();
		((ActiveList<Control>)(object)_9GQBAH2pi8Sm6ph1s6InjyQGe6R.get_Controls()).Add(val);
	}

	private ListBox _Y29nu3VoVEY6acDadsfRh60BNDh()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		ListBox val = new ListBox();
		((Control)val).set_Dock((DockStyle)5);
		val.get_Scrollbar().set_MouseScrollSpeed(0.2f);
		((Control)val.get_Scrollbar().get_ButtonUp()).set_Visible(false);
		((Control)val.get_Scrollbar().get_ButtonDown()).set_Visible(false);
		return val;
	}

	private ListBox _NWt4WEiiiqjMHAUuqWscxChtSMd()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected O, but got Unknown
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected O, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		ListBox val = _Y29nu3VoVEY6acDadsfRh60BNDh();
		_opIJo2jLUqdOL5yAFP4yzXce0DG _7FpdmRzPrcoARiGqtJekOfu7KqP = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
		if (_7FpdmRzPrcoARiGqtJekOfu7KqP._fvTKDuNATrUxfXZVvltePz3vYkK("DJ") == 20)
		{
			float num = 189.6f;
			float num2 = (268f - num) / 2f;
			ImageControl val2 = new ImageControl();
			((Control)val2).set_Dock((DockStyle)1);
			val2.set_Texture("Contact_DJ");
			val2.set_TextureRect(new Rectangle((int)num2, 0, (int)num, 158));
			((Control)val2).set_Size(new Point(60, 50));
			((Control)val2).set_NoEvents(true);
			ImageControl val3 = val2;
			Label val4 = new Label();
			((Control)val4).set_Dock((DockStyle)5);
			val4.set_Text("Club Amorous DJ");
			val4.set_TextAlign((Alignment)4);
			((Control)val4).set_NoEvents(true);
			Label val5 = val4;
			CustomListBoxItem val6 = new CustomListBoxItem();
			((Control)val6).set_Size(new Point(0, 60));
			((Control)val6).set_Padding(new Margin(2));
			CustomListBoxItem val7 = val6;
			object obj = _rm4nO8SKFlFnD1XybaGLNsNLB5F._003C_003E9__42_3;
			if (obj == null)
			{
				MouseEvent val8 = delegate
				{
					_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.ContactsInformationDJ);
				};
				obj = (object)val8;
				_rm4nO8SKFlFnD1XybaGLNsNLB5F._003C_003E9__42_3 = val8;
			}
			((Control)val7).add_MouseClick((MouseEvent)obj);
			((ActiveList<Control>)(object)((Frame)val7).get_Controls()).Add((Control)(object)val3);
			((ActiveList<Control>)(object)((Frame)val7).get_Controls()).Add((Control)(object)val5);
			((ActiveList<Control>)(object)val.get_ItemContainer().get_Controls()).Add((Control)(object)val7);
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
			Rectangle val9 = _kALYOlSwbvFyd9uFqFZW8Y2IsnL[_6OmCduUGKgPqhBnqgfNJUOmDpZW2.Value];
			float num3 = 1.2f;
			float num4 = (float)((Rectangle)(ref val9)).get_Height() * num3;
			float num5 = ((float)((Rectangle)(ref val9)).get_Width() - num4) / 2f;
			ImageControl val10 = new ImageControl();
			((Control)val10).set_Dock((DockStyle)1);
			val10.set_Texture("PhoneScreen");
			val10.set_TextureRect(new Rectangle(((Rectangle)(ref val9)).get_Left() + (int)num5, ((Rectangle)(ref val9)).get_Top(), (int)num4, ((Rectangle)(ref val9)).get_Height()));
			((Control)val10).set_Size(new Point(60, 50));
			((Control)val10).set_NoEvents(true);
			ImageControl val11 = val10;
			Label val12 = new Label();
			((Control)val12).set_Dock((DockStyle)5);
			val12.set_Text(_6OmCduUGKgPqhBnqgfNJUOmDpZW2.Name);
			val12.set_TextAlign((Alignment)4);
			((Control)val12).set_NoEvents(true);
			Label val13 = val12;
			CustomListBoxItem val14 = new CustomListBoxItem();
			((Control)val14).set_Size(new Point(0, 60));
			((Control)val14).set_Padding(new Margin(2));
			val14.set_Value((object)_6OmCduUGKgPqhBnqgfNJUOmDpZW2.Value);
			CustomListBoxItem _4wrjSKvuvZUTRPI3prAOEvBGDhD = val14;
			((Control)_4wrjSKvuvZUTRPI3prAOEvBGDhD).add_MouseClick((MouseEvent)delegate
			{
				_H6UwM4zjGzglzMY478iBDDvTk6I = (_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts)_4wrjSKvuvZUTRPI3prAOEvBGDhD.get_Value();
				_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.ContactsInformation);
			});
			((ActiveList<Control>)(object)((Frame)_4wrjSKvuvZUTRPI3prAOEvBGDhD).get_Controls()).Add((Control)(object)val11);
			((ActiveList<Control>)(object)((Frame)_4wrjSKvuvZUTRPI3prAOEvBGDhD).get_Controls()).Add((Control)(object)val13);
			((ActiveList<Control>)(object)val.get_ItemContainer().get_Controls()).Add((Control)(object)_4wrjSKvuvZUTRPI3prAOEvBGDhD);
		}
		return val;
	}

	private Control _kcNoqTwN559GGLalkuw5udBAUZB()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected O, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected O, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected O, but got Unknown
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Expected O, but got Unknown
		Panel val = new Panel();
		((Control)val).set_Dock((DockStyle)5);
		Panel val2 = val;
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
		Label val3 = new Label();
		((Control)val3).set_Dock((DockStyle)2);
		val3.set_Text(_H6UwM4zjGzglzMY478iBDDvTk6I.ToString());
		((Control)val3).set_Style("button");
		((Control)val3).set_Size(new Point(0, 40));
		((Control)val3).set_NoEvents(true);
		Label val4 = val3;
		CustomImageControl val5 = new CustomImageControl();
		((Control)val5).set_Dock((DockStyle)2);
		((ImageControl)val5).set_Texture("PhoneScreen");
		((ImageControl)val5).set_TextureRect(_kALYOlSwbvFyd9uFqFZW8Y2IsnL[_H6UwM4zjGzglzMY478iBDDvTk6I]);
		ImageControl val6 = (ImageControl)val5;
		((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)val4);
		((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)val6);
		Button val7 = new Button();
		((Control)val7).set_Dock((DockStyle)2);
		((Label)val7).set_Text("Delete contact");
		((Control)val7).set_Size(new Point(0, 50));
		Button val8 = val7;
		((Control)val8).add_MouseClick((MouseEvent)delegate
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
		});
		((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)val8);
		Button val9 = new Button();
		((Control)val9).set_Dock((DockStyle)2);
		((Label)val9).set_Text("Call");
		((Control)val9).set_Size(new Point(0, 50));
		Button val10 = val9;
		((Control)val10).add_MouseClick((MouseEvent)delegate
		{
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
			string name = _4L7hfXrWoDdArQiscG4ukHCV46B._XbOXR6AypLIdJ3gBMGseGi3Wi2i.GetType().Name;
			string text = _4L7hfXrWoDdArQiscG4ukHCV46B._KVSwpLj0RvURRswHn7ogRy4BRfd?.GetType().Name;
			if (name == "PlayerSexScene" && text == _iVvswmrDLetaWXmgd38sJtDnLs[_H6UwM4zjGzglzMY478iBDDvTk6I])
			{
				_nkzqFdEfDyLcyGikIKGcHjklI4y._zunSyHn4DekdA6CngP10dXcR1kq("<i>" + _H6UwM4zjGzglzMY478iBDDvTk6I.ToString() + " is kind of... preoccupied right now.</i>", "%playername%", Color.get_White());
			}
			else if (name != "BedroomScene" && name != "LivingRoomScene")
			{
				_nkzqFdEfDyLcyGikIKGcHjklI4y._zunSyHn4DekdA6CngP10dXcR1kq("<i>Reception is really bad at the moment, I should try again when I'm back at home.</i>", "%playername%", Color.get_White());
			}
			else
			{
				_WDhVhBhQHGowaONqV87v7EaCvro(_H6UwM4zjGzglzMY478iBDDvTk6I);
			}
		});
		((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)val10);
		if (_H6UwM4zjGzglzMY478iBDDvTk6I == _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Zenith && opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("ZenithDate") > 20)
		{
			Button val11 = new Button();
			((Control)val11).set_Dock((DockStyle)2);
			((Label)val11).set_Text("Extra: Shooting Range");
			((Control)val11).set_Size(new Point(0, 50));
			Button val12 = val11;
			((Control)val12).add_MouseClick((MouseEvent)delegate
			{
				_RiDuYMeg3EHnBUteUcAb8VlfQVl();
				_4L7hfXrWoDdArQiscG4ukHCV46B._k9wUPeU1Ga7cygiuGP8TT6aPLWF<PhoneShootingRangeMiniGameScene>();
			});
			((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)val12);
		}
		if (_H6UwM4zjGzglzMY478iBDDvTk6I == _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Remy && opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("RemyDate") > 20)
		{
			Button val13 = new Button();
			((Control)val13).set_Dock((DockStyle)2);
			((Label)val13).set_Text("Extra: Cooking Mini-Game");
			((Control)val13).set_Size(new Point(0, 50));
			Button val14 = val13;
			((Control)val14).add_MouseClick((MouseEvent)delegate
			{
				_4L7hfXrWoDdArQiscG4ukHCV46B._xyl3Tv5KdR5eezDgagxbBcS3cwt("MiniGameCooking");
				_RiDuYMeg3EHnBUteUcAb8VlfQVl();
			});
			((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)val14);
		}
		if (!_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF && _H6UwM4zjGzglzMY478iBDDvTk6I == _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Remy && opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("RemyDate") > 30)
		{
			Button val15 = new Button();
			((Control)val15).set_Dock((DockStyle)2);
			((Label)val15).set_Text("Extra: Nude pictures");
			((Control)val15).set_Size(new Point(0, 50));
			Button val16 = val15;
			((Control)val16).add_MouseClick((MouseEvent)delegate
			{
				_4L7hfXrWoDdArQiscG4ukHCV46B._xyl3Tv5KdR5eezDgagxbBcS3cwt("NudesRemy");
				_RiDuYMeg3EHnBUteUcAb8VlfQVl();
			});
			((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)val16);
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
			Button val17 = new Button();
			((Control)val17).set_Dock((DockStyle)2);
			((Label)val17).set_Text(_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF ? "Extra: Love scene" : "Extra: Sexscene");
			((Control)val17).set_Size(new Point(0, 50));
			Button val18 = val17;
			((Control)val18).add_MouseClick((MouseEvent)delegate
			{
				_ZfxNkwQ3qvZWenbVYRs2XNSAF2c(_nc2gJWKJm6yAMtppwpcfigGPFj3);
			});
			((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)val18);
		}
		return (Control)(object)val2;
	}

	private Control _h2ArPDECvhhh0z0Z51CaUxB7rAr()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		Panel val = new Panel();
		((Control)val).set_Dock((DockStyle)5);
		Panel val2 = val;
		Label val3 = new Label();
		((Control)val3).set_Dock((DockStyle)2);
		val3.set_Text("Club Amorous DJ");
		((Control)val3).set_Style("button");
		((Control)val3).set_Size(new Point(0, 40));
		((Control)val3).set_NoEvents(true);
		Label val4 = val3;
		CustomImageControl val5 = new CustomImageControl();
		((Control)val5).set_Dock((DockStyle)2);
		((ImageControl)val5).set_Texture("Contact_DJ");
		((ImageControl)val5).set_TextureRect(new Rectangle(0, 0, 268, 158));
		ImageControl val6 = (ImageControl)val5;
		Button val7 = new Button();
		((Control)val7).set_Dock((DockStyle)2);
		((Label)val7).set_Text("Request a song");
		((Control)val7).set_Size(new Point(0, 50));
		Button val8 = val7;
		((Control)val8).add_MouseClick((MouseEvent)delegate
		{
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			string name = _4L7hfXrWoDdArQiscG4ukHCV46B._XbOXR6AypLIdJ3gBMGseGi3Wi2i.GetType().Name;
			if (name.StartsWith("Club"))
			{
				_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.Soundtrack);
			}
			else
			{
				_nkzqFdEfDyLcyGikIKGcHjklI4y._zunSyHn4DekdA6CngP10dXcR1kq("<i>Hmm, the operator is telling me: 'The number you are trying to reach is currently unavailable'. I guess the DJ only has his phone enabled during Club hours.</i>", "%playername%", Color.get_White());
			}
		});
		((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)val4);
		((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)val6);
		((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)val8);
		return (Control)(object)val2;
	}

	private ListBox _hiWNprom67B9EJO4loqBfhvB4hX()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		ListBox val = _Y29nu3VoVEY6acDadsfRh60BNDh();
		List<_KZ7hNP1K5E99Xfup1lTZ9UDrxPE._vNekDVpW2fr7UkjA16E9ifFmD9s> list = _KZ7hNP1K5E99Xfup1lTZ9UDrxPE._LUJAgYjQ8oEpFgPKC5CzY9Ne5ju.OrderBy((_KZ7hNP1K5E99Xfup1lTZ9UDrxPE._vNekDVpW2fr7UkjA16E9ifFmD9s _vNekDVpW2fr7UkjA16E9ifFmD9s_0) => _vNekDVpW2fr7UkjA16E9ifFmD9s_0._D5QiLGGNtfoCEnZIUPvH4OKqUabA).ToList();
		foreach (_KZ7hNP1K5E99Xfup1lTZ9UDrxPE._vNekDVpW2fr7UkjA16E9ifFmD9s item in list)
		{
			_KZ7hNP1K5E99Xfup1lTZ9UDrxPE._vNekDVpW2fr7UkjA16E9ifFmD9s _a5X3xjbmM60JVR5AMk4qrTqgyJm = item;
			CustomListBoxItem val2 = new CustomListBoxItem();
			((Control)val2).set_Size(new Point(0, 90));
			CustomListBoxItem val3 = val2;
			Label val4 = new Label();
			((Control)val4).set_Dock((DockStyle)2);
			((Control)val4).set_Size(new Point(0, 50));
			val4.set_Text("\"" + item._D5QiLGGNtfoCEnZIUPvH4OKqUabA + "\"");
			val4.set_TextAlign((Alignment)4);
			val4.set_TextColor(ColorInt.RGB(255, 255, 0));
			val4.set_TextWrap(true);
			val4.set_UseTextColor(true);
			((Control)val4).set_NoEvents(true);
			Label val5 = val4;
			Label val6 = new Label();
			((Control)val6).set_Dock((DockStyle)2);
			((Control)val6).set_Size(new Point(0, 40));
			val6.set_Text("by " + item._ynar3ZAutlIbbTWMBGvo1mdRNYz);
			val6.set_TextAlign((Alignment)4);
			((Control)val6).set_NoEvents(true);
			Label val7 = val6;
			((ActiveList<Control>)(object)((Frame)val3).get_Controls()).Add((Control)(object)val5);
			((ActiveList<Control>)(object)((Frame)val3).get_Controls()).Add((Control)(object)val7);
			((Control)val3).add_MouseClick((MouseEvent)delegate
			{
				//IL_0026: Unknown result type (might be due to invalid IL or missing references)
				int num = _boyt8NIMtKsAGSTcjHeL0WMbFxs._07xTWbIEgzxJYsYwFKDbbKNvu4G(0, _OZU2jcD6pvGbls1ACzPQPKBf9ci.Length);
				_nkzqFdEfDyLcyGikIKGcHjklI4y._zunSyHn4DekdA6CngP10dXcR1kq(_OZU2jcD6pvGbls1ACzPQPKBf9ci[num], ClubDJNPC._RB8fRXeQvK5vs7JEA0XfVCEpg1i, ClubDJNPC._9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA);
				_UmxbIbk7pgaod0bD7pS309P3Lns._QrgbXEg7MMeD9Ybz12fFVsbmAd9(_a5X3xjbmM60JVR5AMk4qrTqgyJm._XAtd16WmK4L37sBtMsLCIvJzIS1, 0.3f, bool_0: false);
				_4L7hfXrWoDdArQiscG4ukHCV46B._aJh9CibG5YKhkExxgRyVopdfSeJ._vVZVLriSGPExpn1KeobglMabsoi("AchievementGeneric3");
			});
			((ActiveList<Control>)(object)val.get_ItemContainer().get_Controls()).Add((Control)(object)val3);
		}
		return val;
	}

	private ListBox _YGPgft9Vo9UMBMfVtN34XoT93HD()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		ListBox val = _Y29nu3VoVEY6acDadsfRh60BNDh();
		ListBoxItem val2 = new ListBoxItem();
		((Label)val2).set_Text("Messages");
		((Control)val2).set_Size(new Point(0, 50));
		ListBoxItem val3 = val2;
		object obj = _rm4nO8SKFlFnD1XybaGLNsNLB5F._003C_003E9__46_0;
		if (obj == null)
		{
			MouseEvent val4 = delegate
			{
				_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.DiaryMessages);
			};
			obj = (object)val4;
			_rm4nO8SKFlFnD1XybaGLNsNLB5F._003C_003E9__46_0 = val4;
		}
		((Control)val3).add_MouseClick((MouseEvent)obj);
		ListBoxItem val5 = new ListBoxItem();
		((Label)val5).set_Text("Achievements");
		((Control)val5).set_Size(new Point(0, 50));
		ListBoxItem val6 = val5;
		object obj2 = _rm4nO8SKFlFnD1XybaGLNsNLB5F._003C_003E9__46_1;
		if (obj2 == null)
		{
			MouseEvent val7 = delegate
			{
				_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.DiaryAchievements);
			};
			obj2 = (object)val7;
			_rm4nO8SKFlFnD1XybaGLNsNLB5F._003C_003E9__46_1 = val7;
		}
		((Control)val6).add_MouseClick((MouseEvent)obj2);
		ListBoxItem val8 = new ListBoxItem();
		((Label)val8).set_Text("Save");
		((Control)val8).set_Size(new Point(0, 50));
		ListBoxItem val9 = val8;
		object obj3 = _rm4nO8SKFlFnD1XybaGLNsNLB5F._003C_003E9__46_2;
		if (obj3 == null)
		{
			MouseEvent val10 = delegate
			{
				_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.DiarySave);
			};
			obj3 = (object)val10;
			_rm4nO8SKFlFnD1XybaGLNsNLB5F._003C_003E9__46_2 = val10;
		}
		((Control)val9).add_MouseClick((MouseEvent)obj3);
		ListBoxItem val11 = new ListBoxItem();
		((Label)val11).set_Text("Load");
		((Control)val11).set_Size(new Point(0, 50));
		ListBoxItem val12 = val11;
		object obj4 = _rm4nO8SKFlFnD1XybaGLNsNLB5F._003C_003E9__46_3;
		if (obj4 == null)
		{
			MouseEvent val13 = delegate
			{
				_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.DiaryLoad);
			};
			obj4 = (object)val13;
			_rm4nO8SKFlFnD1XybaGLNsNLB5F._003C_003E9__46_3 = val13;
		}
		((Control)val12).add_MouseClick((MouseEvent)obj4);
		((ActiveList<ListBoxItem>)(object)val.get_Items()).Add(val3);
		if (_4L7hfXrWoDdArQiscG4ukHCV46B._aJh9CibG5YKhkExxgRyVopdfSeJ._J5VHNpAqpO7aNRC9sbWCZTOF7XS)
		{
			ListBoxItem val14 = new ListBoxItem();
			((Label)val14).set_Text("Steam Achievements");
			((Control)val14).set_Size(new Point(0, 50));
			ListBoxItem val15 = val14;
			((Control)val15).add_MouseClick((MouseEvent)delegate
			{
				_4L7hfXrWoDdArQiscG4ukHCV46B._aJh9CibG5YKhkExxgRyVopdfSeJ._3xUr1Yv0PbZlcGdOrfbCAwOXa5c();
			});
			((ActiveList<ListBoxItem>)(object)val.get_Items()).Add(val15);
		}
		((ActiveList<ListBoxItem>)(object)val.get_Items()).Add(val6);
		((ActiveList<ListBoxItem>)(object)val.get_Items()).Add(val9);
		((ActiveList<ListBoxItem>)(object)val.get_Items()).Add(val12);
		return val;
	}

	private ListBox _ZAzvI9G8CsjLJ0AWtoSCmHUuR2q()
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		ListBox val = _Y29nu3VoVEY6acDadsfRh60BNDh();
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
		if (opIJo2jLUqdOL5yAFP4yzXce0DG._7u6aevGWBE7ABqrBXoaPTkywcVo.Count != 0)
		{
			foreach (_iDN1IKOu3e1uADYzeMEUon5D9fg _qsRYa7wg9K5fRrgfqdfMwLILTrbA in opIJo2jLUqdOL5yAFP4yzXce0DG._7u6aevGWBE7ABqrBXoaPTkywcVo.OrderByDescending((_iDN1IKOu3e1uADYzeMEUon5D9fg _iDN1IKOu3e1uADYzeMEUon5D9fg_0) => _iDN1IKOu3e1uADYzeMEUon5D9fg_0._QkxGXtWLzE0Z8JKyKkMiiph9giD))
			{
				ImageControl val2 = new ImageControl();
				((Control)val2).set_Dock((DockStyle)1);
				val2.set_Texture(_qsRYa7wg9K5fRrgfqdfMwLILTrbA._dFaIUhufvE2Ld5IjNEwmPAqqraj);
				((Control)val2).set_Size(new Point(60, 50));
				((Control)val2).set_NoEvents(true);
				ImageControl val3 = val2;
				Label val4 = new Label();
				((Control)val4).set_Dock((DockStyle)5);
				val4.set_Text(_qsRYa7wg9K5fRrgfqdfMwLILTrbA._D5QiLGGNtfoCEnZIUPvH4OKqUabA + "\r\n" + _qsRYa7wg9K5fRrgfqdfMwLILTrbA._QkxGXtWLzE0Z8JKyKkMiiph9giD.ToShortDateString());
				val4.set_TextAlign((Alignment)3);
				((Control)val4).set_Margin(new Margin(10, 0, 10, 0));
				val4.set_AutoEllipsis(true);
				val4.set_TextWrap(true);
				((Control)val4).set_NoEvents(true);
				Label val5 = val4;
				CustomListBoxItem val6 = new CustomListBoxItem();
				((Control)val6).set_Size(new Point(0, 60));
				((Control)val6).set_Padding(new Margin(2));
				CustomListBoxItem val7 = val6;
				((Control)val7).add_MouseClick((MouseEvent)delegate
				{
					_ERdtO3cV05TBYFV0mT86wv01GJf = _qsRYa7wg9K5fRrgfqdfMwLILTrbA;
					_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.DiaryMessagesInformation);
				});
				((ActiveList<Control>)(object)((Frame)val7).get_Controls()).Add((Control)(object)val3);
				((ActiveList<Control>)(object)((Frame)val7).get_Controls()).Add((Control)(object)val5);
				((ActiveList<Control>)(object)val.get_ItemContainer().get_Controls()).Add((Control)(object)val7);
			}
			return val;
		}
		ListBoxItem val8 = new ListBoxItem();
		((Label)val8).set_Text("There are no messages yet!");
		((Control)val8).set_Size(new Point(0, 50));
		ListBoxItem val9 = val8;
		((ActiveList<ListBoxItem>)(object)val.get_Items()).Add(val9);
		return val;
	}

	private ListBox _jv6KLyNe1t3TATNww1TiWv9ZVLF()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		ListBox val = _Y29nu3VoVEY6acDadsfRh60BNDh();
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
		foreach (_bm5ybW5ND5sDF6bvP0sbYyOpvP._eT2GJReQj8Acaq2A0H0eUir97Qf item in _bm5ybW5ND5sDF6bvP0sbYyOpvP._cifgh151BUWCIJWJPcakKQ2lWGB)
		{
			ImageControl val2 = new ImageControl();
			((Control)val2).set_Dock((DockStyle)1);
			val2.set_Texture(item._dFaIUhufvE2Ld5IjNEwmPAqqraj);
			((Control)val2).set_Size(new Point(60, 50));
			ImageControl val3 = val2;
			Label val4 = new Label();
			((Control)val4).set_Dock((DockStyle)5);
			val4.set_Text(item._D5QiLGGNtfoCEnZIUPvH4OKqUabA);
			val4.set_TextAlign((Alignment)3);
			((Control)val4).set_Margin(new Margin(10, 0, 10, 0));
			val4.set_AutoEllipsis(true);
			val4.set_TextWrap(true);
			Label val5 = val4;
			CustomListBoxItem val6 = new CustomListBoxItem();
			((Control)val6).set_Size(new Point(0, 60));
			((Control)val6).set_Padding(new Margin(2));
			((Control)val6).set_NoEvents(true);
			((Control)val6).set_Opacity(opIJo2jLUqdOL5yAFP4yzXce0DG._Oms9lumBodLGrGZ09YJaEuzmlAf(item._qXE0hlPdNyl0lTUyddbAS1PZhVV) ? 1f : 0.5f);
			CustomListBoxItem val7 = val6;
			((ActiveList<Control>)(object)((Frame)val7).get_Controls()).Add((Control)(object)val3);
			((ActiveList<Control>)(object)((Frame)val7).get_Controls()).Add((Control)(object)val5);
			((ActiveList<Control>)(object)val.get_ItemContainer().get_Controls()).Add((Control)(object)val7);
		}
		return val;
	}

	private Panel _yE1MXqtEKITxyL75pITcd8fNpsi()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		Panel val = new Panel();
		((Control)val).set_Dock((DockStyle)5);
		Panel val2 = val;
		ImageControl val3 = new ImageControl();
		((Control)val3).set_Dock((DockStyle)1);
		val3.set_Texture(_ERdtO3cV05TBYFV0mT86wv01GJf._dFaIUhufvE2Ld5IjNEwmPAqqraj);
		((Control)val3).set_Size(new Point(60, 50));
		ImageControl val4 = val3;
		Label val5 = new Label();
		((Control)val5).set_Dock((DockStyle)5);
		val5.set_Text(_ERdtO3cV05TBYFV0mT86wv01GJf._D5QiLGGNtfoCEnZIUPvH4OKqUabA + "\r\n" + _ERdtO3cV05TBYFV0mT86wv01GJf._QkxGXtWLzE0Z8JKyKkMiiph9giD.ToShortDateString());
		val5.set_TextAlign((Alignment)3);
		((Control)val5).set_Margin(new Margin(10, 0, 10, 0));
		val5.set_AutoEllipsis(true);
		val5.set_TextWrap(true);
		Label val6 = val5;
		Panel val7 = new Panel();
		((Control)val7).set_Dock((DockStyle)2);
		((Control)val7).set_Size(new Point(0, 60));
		((Control)val7).set_Padding(new Margin(2));
		((Control)val7).set_Style("button");
		((Control)val7).set_NoEvents(true);
		Panel val8 = val7;
		((ActiveList<Control>)(object)val8.get_Content().get_Controls()).Add((Control)(object)val4);
		((ActiveList<Control>)(object)val8.get_Content().get_Controls()).Add((Control)(object)val6);
		Label val9 = new Label();
		((Control)val9).set_Dock((DockStyle)2);
		val9.set_Text(_ERdtO3cV05TBYFV0mT86wv01GJf._NvMJ5jDaeRR7HysERrVDtSlxaI5);
		((Control)val9).set_Margin(new Margin(10));
		val9.set_TextAlign((Alignment)4);
		((Control)val9).set_AutoSize((AutoSize)2);
		val9.set_TextWrap(true);
		((Control)val9).set_NoEvents(true);
		Label val10 = val9;
		Button val11 = new Button();
		((Control)val11).set_Dock((DockStyle)2);
		((Label)val11).set_Text("Delete message");
		((Control)val11).set_Size(new Point(0, 50));
		Button val12 = val11;
		((Control)val12).add_MouseClick((MouseEvent)delegate
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
		});
		((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)val8);
		((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)val10);
		((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)val12);
		return val2;
	}

	private ListBox _QmCbnBf76ITvR2HA7WYF44qkJWK()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		ListBox val = _Y29nu3VoVEY6acDadsfRh60BNDh();
		List<_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p> list = _DW9IcpdMEINZmuzfrqmwsduBGih._25D1ZH2er0EbpKmvFksAbFjP2OX(bool_0: true);
		foreach (_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p item in list)
		{
			int num = item._RB8fRXeQvK5vs7JEA0XfVCEpg1i.IndexOf('-');
			string text = item._RB8fRXeQvK5vs7JEA0XfVCEpg1i.Substring(0, num).Trim();
			string text2 = item._RB8fRXeQvK5vs7JEA0XfVCEpg1i.Substring(num + 1).Trim();
			ListBoxItem val2 = new ListBoxItem();
			((Label)val2).set_Text(text + "\r\n" + text2);
			((Control)val2).set_Size(new Point(0, 50));
			ListBoxItem val3 = val2;
			_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p _7OcRfli7CrlI9YYUDJj3j5nDI9k = item;
			((Control)val3).add_MouseClick((MouseEvent)delegate
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
			});
			((ActiveList<ListBoxItem>)(object)val.get_Items()).Add(val3);
		}
		return val;
	}

	private ListBox _mKzC4RKCG3B1ZBdWwcAp79gd8NaA()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		ListBox val = _Y29nu3VoVEY6acDadsfRh60BNDh();
		List<_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p> list = _DW9IcpdMEINZmuzfrqmwsduBGih._25D1ZH2er0EbpKmvFksAbFjP2OX(bool_0: false);
		foreach (_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p item in list)
		{
			int num = item._RB8fRXeQvK5vs7JEA0XfVCEpg1i.IndexOf('-');
			string text = item._RB8fRXeQvK5vs7JEA0XfVCEpg1i.Substring(0, num).Trim();
			string text2 = item._RB8fRXeQvK5vs7JEA0XfVCEpg1i.Substring(num + 1).Trim();
			ListBoxItem val2 = new ListBoxItem();
			((Label)val2).set_Text(text + "\r\n" + text2);
			((Control)val2).set_Size(new Point(0, 50));
			ListBoxItem val3 = val2;
			_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p _7OcRfli7CrlI9YYUDJj3j5nDI9k = item;
			((Control)val3).add_MouseClick((MouseEvent)delegate
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
			});
			((ActiveList<ListBoxItem>)(object)val.get_Items()).Add(val3);
		}
		return val;
	}

	private Control _fM96M1a1ZZUtzPyevCm45mKPeQg()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		Panel val = new Panel();
		((Control)val).set_Dock((DockStyle)5);
		((Control)val).set_Margin(new Margin(10));
		Panel val2 = val;
		Label val3 = new Label();
		((Control)val3).set_Dock((DockStyle)2);
		val3.set_Text("Master Volume");
		Label val4 = val3;
		Slider val5 = new Slider();
		((Control)val5).set_Dock((DockStyle)2);
		val5.set_Orientation((Orientation)0);
		val5.set_Steps(100f);
		val5.set_Value(_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._DF24JUrPFA6rJ2cQrOTlpC3I4FF * 100f);
		((Control)val5).set_Style("scrollSlider");
		((Control)val5).set_Size(new Point(0, 30));
		((Control)val5.get_Button()).set_Style("scrollSliderButton");
		Slider _XEgAfmv7sJWJSaC2diC3eaD4Fgl = val5;
		_XEgAfmv7sJWJSaC2diC3eaD4Fgl.add_ValueChanged((VoidEvent)delegate
		{
			_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._DF24JUrPFA6rJ2cQrOTlpC3I4FF = _XEgAfmv7sJWJSaC2diC3eaD4Fgl.get_Value() / 100f;
		});
		Label val6 = new Label();
		((Control)val6).set_Dock((DockStyle)2);
		val6.set_Text("Music Volume");
		Label val7 = val6;
		Slider val8 = new Slider();
		((Control)val8).set_Dock((DockStyle)2);
		val8.set_Orientation((Orientation)0);
		val8.set_Steps(100f);
		val8.set_Value(_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._7NidKjx61ui5CP7JojwfqxH4aKC * 100f);
		((Control)val8).set_Style("scrollSlider");
		((Control)val8).set_Size(new Point(0, 30));
		((Control)val8.get_Button()).set_Style("scrollSliderButton");
		Slider _gjeIIVx9bHyd0aMj0WD483nrLWK = val8;
		_gjeIIVx9bHyd0aMj0WD483nrLWK.add_ValueChanged((VoidEvent)delegate
		{
			_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._7NidKjx61ui5CP7JojwfqxH4aKC = _gjeIIVx9bHyd0aMj0WD483nrLWK.get_Value() / 100f;
		});
		Label val9 = new Label();
		((Control)val9).set_Dock((DockStyle)2);
		val9.set_Text("SFX Volume");
		Label val10 = val9;
		Slider val11 = new Slider();
		((Control)val11).set_Dock((DockStyle)2);
		val11.set_Orientation((Orientation)0);
		val11.set_Steps(100f);
		val11.set_Value(_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._2g4Ch8GXdUt0oEbdCZUY2QMbIuH * 100f);
		((Control)val11).set_Style("scrollSlider");
		((Control)val11).set_Size(new Point(0, 30));
		((Control)val11.get_Button()).set_Style("scrollSliderButton");
		Slider _5mK9ExiyKm0md8q4J1C6xc4TzdF = val11;
		_5mK9ExiyKm0md8q4J1C6xc4TzdF.add_ValueChanged((VoidEvent)delegate
		{
			_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._2g4Ch8GXdUt0oEbdCZUY2QMbIuH = _5mK9ExiyKm0md8q4J1C6xc4TzdF.get_Value() / 100f;
		});
		((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)val4);
		((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)_XEgAfmv7sJWJSaC2diC3eaD4Fgl);
		((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)val7);
		((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)_gjeIIVx9bHyd0aMj0WD483nrLWK);
		((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)val10);
		((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)_5mK9ExiyKm0md8q4J1C6xc4TzdF);
		return (Control)(object)val2;
	}

	private Control _H2blb6Djx9JemSUBYepwlzNOXxz()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		Panel val = new Panel();
		((Control)val).set_Dock((DockStyle)5);
		((Control)val).set_Margin(new Margin(10));
		Panel val2 = val;
		_YemBTJprwfbd3mpg5Gy9uyEJWwI(val2.get_Content().get_Controls(), "Dialogue Text Speed", new string[4] { "Slow", "Normal", "Fast", "Instant" }, (int)_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._wVLRBSMULz8GfedBPXaVJB0sBEO, delegate(int int_0)
		{
			_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._wVLRBSMULz8GfedBPXaVJB0sBEO = (DialogueSpeed)int_0;
			_nkzqFdEfDyLcyGikIKGcHjklI4y._NhL238TaCbkDiY6HXlWXZzzUYkm = (DialogueSpeed)int_0;
		});
		CheckBox val3 = new CheckBox();
		((Control)val3).set_Dock((DockStyle)2);
		val3.set_Text("Dialogue Auto-skip");
		val3.set_Checked(_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._sbK0941BvW8HgPboNwOhIAd2jP3);
		CheckBox _feL3soNn6ZWaJqYfjYJUyH118tF = val3;
		_feL3soNn6ZWaJqYfjYJUyH118tF.add_CheckedChanged((VoidEvent)delegate
		{
			_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._sbK0941BvW8HgPboNwOhIAd2jP3 = _feL3soNn6ZWaJqYfjYJUyH118tF.get_Checked();
			_nkzqFdEfDyLcyGikIKGcHjklI4y._fUgDiz7KX8TZUVzFlTeXMOhmfUT = _feL3soNn6ZWaJqYfjYJUyH118tF.get_Checked();
		});
		((ActiveList<Control>)(object)val2.get_Content().get_Controls()).Add((Control)(object)_feL3soNn6ZWaJqYfjYJUyH118tF);
		return (Control)(object)val2;
	}

	public static void _YemBTJprwfbd3mpg5Gy9uyEJWwI(ControlCollection controlCollection_0, string string_0, string[] string_1, int int_0, Action<int> action_0)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		Label val = new Label();
		val.set_Text(string_0);
		((Control)val).set_Dock((DockStyle)2);
		Label val2 = val;
		DropDownList val3 = new DropDownList();
		((Control)val3).set_Dock((DockStyle)2);
		((Control)val3).set_Style("button");
		((Control)val3.get_Label()).set_Margin(new Margin(10, 0, 0, 0));
		val3.get_Dropdown().set_Resizable(false);
		((Control)val3).set_Margin(new Margin(0, 0, 0, 5));
		DropDownList val4 = val3;
		((Control)val4.get_Listbox().get_Scrollbar().get_ButtonUp()).set_Visible(false);
		((Control)val4.get_Listbox().get_Scrollbar().get_ButtonDown()).set_Visible(false);
		for (int i = 0; i < string_1.Length; i++)
		{
			ActiveList<ListBoxItem> items = val4.get_Items();
			ListBoxItem val5 = new ListBoxItem();
			((Label)val5).set_Text(string_1[i]);
			val5.set_Value((object)i);
			val5.set_Selected(i == int_0);
			((Control)val5).set_Size(new Point(0, 30));
			items.Add(val5);
		}
		val4.add_SelectedItemChanged((SelectedItemChangedEventHandler)delegate(Control control_0, ListBoxItem listBoxItem_0)
		{
			action_0((int)listBoxItem_0.get_Value());
		});
		((ActiveList<Control>)(object)controlCollection_0).Add((Control)(object)val2);
		((ActiveList<Control>)(object)controlCollection_0).Add((Control)(object)val4);
	}

	private ListBox _1Bze6b62yGQDi3JBE0TyQmPGkzU()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		ListBox val = _Y29nu3VoVEY6acDadsfRh60BNDh();
		ListBoxItem val2 = new ListBoxItem();
		((Label)val2).set_Text("Player Customization");
		((Control)val2).set_Size(new Point(0, 50));
		ListBoxItem val3 = val2;
		((Control)val3).add_MouseClick((MouseEvent)delegate
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
		});
		((ActiveList<ListBoxItem>)(object)val.get_Items()).Add(val3);
		if (_iExD93IWLlzVfXsU9wyrEvWgJsg._X41qA9hgcgXH0Q1aFKWFWpg8UuM)
		{
			ListBoxItemCollection items = val.get_Items();
			ListBoxItem val4 = new ListBoxItem();
			((Label)val4).set_Text("---");
			((Control)val4).set_Enabled(false);
			((ActiveList<ListBoxItem>)(object)items).Add(val4);
			ListBoxItem val5 = new ListBoxItem();
			((Label)val5).set_Text(_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF ? "Disable SFW" : "Enable SFW");
			((Control)val5).set_Size(new Point(0, 50));
			ListBoxItem _diVdxVCKW4CzhbYSG15BcHJB0Ub = val5;
			((Control)_diVdxVCKW4CzhbYSG15BcHJB0Ub).add_MouseClick((MouseEvent)delegate
			{
				_YdyKdWT8QbQOIWkgEuPe6a9hJtd(delegate
				{
					_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF = !_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF;
					_DAsCL6JdGst3kJHpcbztigO3VEV();
					((Label)_diVdxVCKW4CzhbYSG15BcHJB0Ub).set_Text(_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF ? "Disable SFW" : "Enable SFW");
				});
			});
			((ActiveList<ListBoxItem>)(object)val.get_Items()).Add(_diVdxVCKW4CzhbYSG15BcHJB0Ub);
		}
		if (!_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
		{
			_oWVabv0BTttUwHhKppcIL7h0vrZ(val);
		}
		return val;
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
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		ListBox val = _Y29nu3VoVEY6acDadsfRh60BNDh();
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
		if (opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("Prologue") == 40)
		{
			ListBoxItem val2 = new ListBoxItem();
			((Label)val2).set_Text("Back to Home");
			((Control)val2).set_Size(new Point(0, 50));
			ListBoxItem val3 = val2;
			ListBoxItem val4 = new ListBoxItem();
			((Label)val4).set_Text("Back to Club Amorous");
			((Control)val4).set_Size(new Point(0, 50));
			ListBoxItem val5 = val4;
			((ActiveList<ListBoxItem>)(object)val.get_Items()).Add(val3);
			((ActiveList<ListBoxItem>)(object)val.get_Items()).Add(val5);
			((Control)val3).add_MouseClick((MouseEvent)delegate
			{
				_RiDuYMeg3EHnBUteUcAb8VlfQVl();
				_4L7hfXrWoDdArQiscG4ukHCV46B._k9wUPeU1Ga7cygiuGP8TT6aPLWF<BedroomScene>();
			});
			((Control)val5).add_MouseClick((MouseEvent)delegate
			{
				_RiDuYMeg3EHnBUteUcAb8VlfQVl();
				_4L7hfXrWoDdArQiscG4ukHCV46B._k9wUPeU1Ga7cygiuGP8TT6aPLWF<ClubInsideScene>();
			});
			ListBoxItemCollection items = val.get_Items();
			ListBoxItem val6 = new ListBoxItem();
			((Label)val6).set_Text("---");
			((Control)val6).set_Enabled(false);
			((ActiveList<ListBoxItem>)(object)items).Add(val6);
		}
		ListBoxItem val7 = new ListBoxItem();
		((Label)val7).set_Text("Exit to Main Menu");
		((Control)val7).set_Size(new Point(0, 50));
		ListBoxItem val8 = val7;
		((Control)val8).add_MouseClick((MouseEvent)delegate
		{
			_RiDuYMeg3EHnBUteUcAb8VlfQVl();
			_kf3EbE0B70xGe1szklqAZyCqoLj = false;
			_4L7hfXrWoDdArQiscG4ukHCV46B._k9wUPeU1Ga7cygiuGP8TT6aPLWF<MainMenuScene>();
		});
		ListBoxItem val9 = new ListBoxItem();
		((Label)val9).set_Text("Quit Game");
		((Control)val9).set_Size(new Point(0, 50));
		ListBoxItem val10 = val9;
		((Control)val10).add_MouseClick((MouseEvent)delegate
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
		});
		((ActiveList<ListBoxItem>)(object)val.get_Items()).Add(val8);
		((ActiveList<ListBoxItem>)(object)val.get_Items()).Add(val10);
		return val;
	}

	private void _oWVabv0BTttUwHhKppcIL7h0vrZ(ListBox listBox_0)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		ListBoxItem val = new ListBoxItem();
		((Label)val).set_Text(_iExD93IWLlzVfXsU9wyrEvWgJsg._b52DDz3MN1kD8sgdQhCNO1tJRNn ? "Disable Topless Cheat" : "Enable Topless Cheat");
		((Control)val).set_Size(new Point(0, 50));
		ListBoxItem _Epeel2m9h5O12V2ERwlnNTE3FdM = val;
		((Control)_Epeel2m9h5O12V2ERwlnNTE3FdM).add_MouseClick((MouseEvent)delegate
		{
			_YdyKdWT8QbQOIWkgEuPe6a9hJtd(delegate
			{
				_iExD93IWLlzVfXsU9wyrEvWgJsg._b52DDz3MN1kD8sgdQhCNO1tJRNn = !_iExD93IWLlzVfXsU9wyrEvWgJsg._b52DDz3MN1kD8sgdQhCNO1tJRNn;
				((Label)_Epeel2m9h5O12V2ERwlnNTE3FdM).set_Text(_iExD93IWLlzVfXsU9wyrEvWgJsg._b52DDz3MN1kD8sgdQhCNO1tJRNn ? "Disable Topless Cheat" : "Enable Topless Cheat");
			});
		});
		ListBoxItem val2 = new ListBoxItem();
		((Label)val2).set_Text(_iExD93IWLlzVfXsU9wyrEvWgJsg._pKBiGAgDu5WqoykkGBaEGnP7oMj ? "Disable Bottomless Cheat" : "Enable Bottomless Cheat");
		((Control)val2).set_Size(new Point(0, 50));
		ListBoxItem _FxyX2MMMdsf69424VDXa8LqP1nq = val2;
		((Control)_FxyX2MMMdsf69424VDXa8LqP1nq).add_MouseClick((MouseEvent)delegate
		{
			_YdyKdWT8QbQOIWkgEuPe6a9hJtd(delegate
			{
				_iExD93IWLlzVfXsU9wyrEvWgJsg._pKBiGAgDu5WqoykkGBaEGnP7oMj = !_iExD93IWLlzVfXsU9wyrEvWgJsg._pKBiGAgDu5WqoykkGBaEGnP7oMj;
				((Label)_FxyX2MMMdsf69424VDXa8LqP1nq).set_Text(_iExD93IWLlzVfXsU9wyrEvWgJsg._pKBiGAgDu5WqoykkGBaEGnP7oMj ? "Disable Bottomless Cheat" : "Enable Bottomless Cheat");
			});
		});
		((ActiveList<ListBoxItem>)(object)listBox_0.get_Items()).Add(_Epeel2m9h5O12V2ERwlnNTE3FdM);
		((ActiveList<ListBoxItem>)(object)listBox_0.get_Items()).Add(_FxyX2MMMdsf69424VDXa8LqP1nq);
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Expected O, but got Unknown
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Expected O, but got Unknown
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fa: Expected O, but got Unknown
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
		Desktop val = new Desktop();
		val.set_Skin(Gui.GenerateStandardSkin());
		((Control)val).set_Size(new Point(270, 380));
		_9GQBAH2pi8Sm6ph1s6InjyQGe6R = val;
		_9GQBAH2pi8Sm6ph1s6InjyQGe6R._EMnZAXxoqoahiGOiNjffRycLtDE("Assets/GUI/Squid/DefaultSkin");
		_9GQBAH2pi8Sm6ph1s6InjyQGe6R.set_ModalColor(ColorInt.ARGB(0.9f, 0f, 0f, 0f));
		_9GQBAH2pi8Sm6ph1s6InjyQGe6R.MouseTransformFunc = delegate(Point point_0)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			double double_;
			Point val2 = _hrw3Kf8fCx7saJOmoYUD8sIz3uD._0LlFMUVNTAixukJSTpecXFIxdAl("Sheen Two", out double_);
			Matrix val3 = Matrix.CreateTranslation((float)(-val2.X), (float)(-val2.Y), 0f) * Matrix.CreateRotationZ((float)(0.0 - double_));
			Vector2 val4 = Vector2.Transform(new Vector2((float)((Point)(ref point_0)).get_x(), (float)((Point)(ref point_0)).get_y()), val3);
			return new Point((int)val4.X, (int)val4.Y);
		};
		_bZJtpWV2Yj6GgZkeZQUmpTHxTnh = new RenderTarget2D(_4L7hfXrWoDdArQiscG4ukHCV46B._2yepMkVENnecIsduggABaU2qhXW, 270, 380);
		_Pfaq6ajchxcqF6GecivHvHqQW6M = new RenderTarget2D(_4L7hfXrWoDdArQiscG4ukHCV46B._2yepMkVENnecIsduggABaU2qhXW, 270, 380);
		_VQDLuxMbrizDwdFWvZoaPpO7Y0o = new Stack<_VQgRlkt1vazuo2KaxFIrSVwZOpL>();
		_1gXQH16lmsacxQMOpjFFqZSmjQl = true;
		_97m6gVcwgWbLFyNUxI3P1KuD0Gn = true;
	}

	public void _Xrfjrxr72hHh4bDdQB7HzEbJUCb()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
		bool flag = opIJo2jLUqdOL5yAFP4yzXce0DG._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.LongForearm);
		bool flag2;
		Color color_ = ((flag2 = opIJo2jLUqdOL5yAFP4yzXce0DG._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.ShortForearm)) ? opIJo2jLUqdOL5yAFP4yzXce0DG._8rDSn6e9Ip9WdOogjhIn8YlL1oM : (flag ? opIJo2jLUqdOL5yAFP4yzXce0DG._1ZKGQXLRAHEJR8v7jhlDsyOVLcz : Color.get_White()));
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
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
		if (_4L7hfXrWoDdArQiscG4ukHCV46B._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH((Keys)27) || _4L7hfXrWoDdArQiscG4ukHCV46B._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH((Keys)160))
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
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		if (_f2smFxmYyFJyj81xWGaGLB2G7ef == _wlQdV74JhqkBVxNonpbfqZEmjIbA.None || _4L7hfXrWoDdArQiscG4ukHCV46B._5zNdOw7qHmuCAPJFMr3SsZdBlCr != null || _3AaEmo54VzWybgrrg7I8Z9JUV1e)
		{
			return;
		}
		Point val = _wRd4nHuQQlAPEwrHOGkBfut6Uip_0._u7uCdK9i8FnWhiaPn2bO2wIgUUuA(_4L7hfXrWoDdArQiscG4ukHCV46B._RbWJ7YGnYHCSoD44MRW1h5X6E7E._U7CeYBJ1v1SoUxpX8emsQ9mWl5b);
		if (_lpMGMQZJYmHr6q9XBRwiM0Lse4N._3nKd9Dk3YeX87QB5dROwYUzczsN("Phone", val.X, val.Y))
		{
			_lpMGMQZJYmHr6q9XBRwiM0Lse4N._VoeevpFh2kLKfHtpPDXWt0TFbuH("Phone", Color.get_Red());
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
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		if (_j2OEvLQtM2lODSmH3ZFP6wWCWpF != _fFGgY4gvWNcTLSlsfe9k99ctumb.ArmUp || _4L7hfXrWoDdArQiscG4ukHCV46B._5zNdOw7qHmuCAPJFMr3SsZdBlCr != null || _3AaEmo54VzWybgrrg7I8Z9JUV1e)
		{
			return;
		}
		Point val = _wRd4nHuQQlAPEwrHOGkBfut6Uip_0._u7uCdK9i8FnWhiaPn2bO2wIgUUuA(_4L7hfXrWoDdArQiscG4ukHCV46B._RbWJ7YGnYHCSoD44MRW1h5X6E7E._U7CeYBJ1v1SoUxpX8emsQ9mWl5b);
		bool flag = _hrw3Kf8fCx7saJOmoYUD8sIz3uD._3nKd9Dk3YeX87QB5dROwYUzczsN("Phone Colour", val.X, val.Y);
		_rLwDc2UH4fLL9at0M4SCKf0SG8cA = (flag ? 5000f : 1000f);
		if (!flag)
		{
			return;
		}
		if (_4L7hfXrWoDdArQiscG4ukHCV46B._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(_PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton))
		{
			if (_saaJnL0DI6B89XWRulJZ4KC1I1g == _VQgRlkt1vazuo2KaxFIrSVwZOpL.Home)
			{
				if (_hrw3Kf8fCx7saJOmoYUD8sIz3uD._3nKd9Dk3YeX87QB5dROwYUzczsN("CONTACTS", val.X, val.Y))
				{
					_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.Contacts);
				}
				else if (_hrw3Kf8fCx7saJOmoYUD8sIz3uD._3nKd9Dk3YeX87QB5dROwYUzczsN("Diary", val.X, val.Y))
				{
					_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.Diary);
				}
				else if (_hrw3Kf8fCx7saJOmoYUD8sIz3uD._3nKd9Dk3YeX87QB5dROwYUzczsN("Audio", val.X, val.Y))
				{
					_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.Audio);
				}
				else if (_hrw3Kf8fCx7saJOmoYUD8sIz3uD._3nKd9Dk3YeX87QB5dROwYUzczsN("Chat Settings", val.X, val.Y))
				{
					_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.ChatSettings);
				}
				else if (_hrw3Kf8fCx7saJOmoYUD8sIz3uD._3nKd9Dk3YeX87QB5dROwYUzczsN("Gallery", val.X, val.Y))
				{
					_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.Gallery);
				}
				else if (_hrw3Kf8fCx7saJOmoYUD8sIz3uD._3nKd9Dk3YeX87QB5dROwYUzczsN("Power", val.X, val.Y))
				{
					_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.Power);
				}
				else if (!_hrw3Kf8fCx7saJOmoYUD8sIz3uD._3nKd9Dk3YeX87QB5dROwYUzczsN("Phone Default Background", val.X, val.Y))
				{
					_RiDuYMeg3EHnBUteUcAb8VlfQVl();
				}
			}
			else if (!_hrw3Kf8fCx7saJOmoYUD8sIz3uD._3nKd9Dk3YeX87QB5dROwYUzczsN("Phone Default Background", val.X, val.Y))
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
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
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
			Point _eeWHzOz6LrTokRQr52VaB0dKbQO = _hrw3Kf8fCx7saJOmoYUD8sIz3uD._0LlFMUVNTAixukJSTpecXFIxdAl("Sheen Two", out _09rdYyvQzUwbdQbzRZF4vbpdUCO);
			_hrw3Kf8fCx7saJOmoYUD8sIz3uD._f5ctqAmdNsZ889UjM4LxDm8WGxA(skeletonMeshRenderer_0, null, delegate(int int_0, string string_0)
			{
				//IL_0075: Unknown result type (might be due to invalid IL or missing references)
				//IL_0103: Unknown result type (might be due to invalid IL or missing references)
				//IL_0191: Unknown result type (might be due to invalid IL or missing references)
				//IL_028f: Unknown result type (might be due to invalid IL or missing references)
				if (string_0 == "Sheen Two")
				{
					skeletonMeshRenderer_0.End();
					spriteBatch_0.Begin();
					if (!_Ldzm1JY9st4tknAhrglOIpwdYhn)
					{
						spriteBatch_0._f5ctqAmdNsZ889UjM4LxDm8WGxA((Texture2D)(object)_bZJtpWV2Yj6GgZkeZQUmpTHxTnh, (Vector2?)new Vector2((float)_eeWHzOz6LrTokRQr52VaB0dKbQO.X, (float)_eeWHzOz6LrTokRQr52VaB0dKbQO.Y), (Rectangle?)null, (Rectangle?)null, (Vector2?)null, (float)_09rdYyvQzUwbdQbzRZF4vbpdUCO, (Vector2?)null, (Color?)null, (SpriteEffects)0, 0f);
					}
					if (!_rASuGHWSFVWfkpwzF8wZd9bh3XN)
					{
						spriteBatch_0._f5ctqAmdNsZ889UjM4LxDm8WGxA((Texture2D)(object)_Pfaq6ajchxcqF6GecivHvHqQW6M, (Vector2?)new Vector2((float)_eeWHzOz6LrTokRQr52VaB0dKbQO.X, (float)_eeWHzOz6LrTokRQr52VaB0dKbQO.Y), (Rectangle?)null, (Rectangle?)null, (Vector2?)null, (float)_09rdYyvQzUwbdQbzRZF4vbpdUCO, (Vector2?)null, (Color?)null, (SpriteEffects)0, 0f);
					}
					if (!_97m6gVcwgWbLFyNUxI3P1KuD0Gn)
					{
						spriteBatch_0._f5ctqAmdNsZ889UjM4LxDm8WGxA(_BphDC8XZceMl5rqVm5zdrD6meOf, (Vector2?)new Vector2((float)_eeWHzOz6LrTokRQr52VaB0dKbQO.X, (float)_eeWHzOz6LrTokRQr52VaB0dKbQO.Y), (Rectangle?)null, (Rectangle?)null, (Vector2?)null, (float)_09rdYyvQzUwbdQbzRZF4vbpdUCO, (Vector2?)null, (Color?)null, (SpriteEffects)0, 0f);
					}
					spriteBatch_0.End();
					skeletonMeshRenderer_0.Begin(0f, 0f, 1f);
				}
				else if (string_0 == "Thumb")
				{
					if (!_1gXQH16lmsacxQMOpjFFqZSmjQl)
					{
						skeletonMeshRenderer_0.End();
						spriteBatch_0.Begin();
						spriteBatch_0._f5ctqAmdNsZ889UjM4LxDm8WGxA(_Et7ViKuaneif1JVK3bifonUhKPR, (Vector2?)new Vector2((float)(_eeWHzOz6LrTokRQr52VaB0dKbQO.X - 16), (float)(_eeWHzOz6LrTokRQr52VaB0dKbQO.Y - 128)), (Rectangle?)null, (Rectangle?)null, (Vector2?)null, (float)_09rdYyvQzUwbdQbzRZF4vbpdUCO, (Vector2?)null, (Color?)null, (SpriteEffects)0, 0f);
						spriteBatch_0.End();
						skeletonMeshRenderer_0.Begin(0f, 0f, 1f);
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
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		string name = _4L7hfXrWoDdArQiscG4ukHCV46B._XbOXR6AypLIdJ3gBMGseGi3Wi2i.GetType().Name;
		string text = _4L7hfXrWoDdArQiscG4ukHCV46B._KVSwpLj0RvURRswHn7ogRy4BRfd?.GetType().Name;
		if (name == "PlayerSexScene" && text == _iVvswmrDLetaWXmgd38sJtDnLs[_H6UwM4zjGzglzMY478iBDDvTk6I])
		{
			_nkzqFdEfDyLcyGikIKGcHjklI4y._zunSyHn4DekdA6CngP10dXcR1kq("<i>" + _H6UwM4zjGzglzMY478iBDDvTk6I.ToString() + " is kind of... preoccupied right now.</i>", "%playername%", Color.get_White());
		}
		else if (name != "BedroomScene" && name != "LivingRoomScene")
		{
			_nkzqFdEfDyLcyGikIKGcHjklI4y._zunSyHn4DekdA6CngP10dXcR1kq("<i>Reception is really bad at the moment, I should try again when I'm back at home.</i>", "%playername%", Color.get_White());
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
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		string name = _4L7hfXrWoDdArQiscG4ukHCV46B._XbOXR6AypLIdJ3gBMGseGi3Wi2i.GetType().Name;
		if (name.StartsWith("Club"))
		{
			_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.Soundtrack);
		}
		else
		{
			_nkzqFdEfDyLcyGikIKGcHjklI4y._zunSyHn4DekdA6CngP10dXcR1kq("<i>Hmm, the operator is telling me: 'The number you are trying to reach is currently unavailable'. I guess the DJ only has his phone enabled during Club hours.</i>", "%playername%", Color.get_White());
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
	private Point _Xz25BlZJnUNbNDPMKaWNQy0jbnY(Point point_0)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		double double_;
		Point val = _hrw3Kf8fCx7saJOmoYUD8sIz3uD._0LlFMUVNTAixukJSTpecXFIxdAl("Sheen Two", out double_);
		Matrix val2 = Matrix.CreateTranslation((float)(-val.X), (float)(-val.Y), 0f) * Matrix.CreateRotationZ((float)(0.0 - double_));
		Vector2 val3 = Vector2.Transform(new Vector2((float)((Point)(ref point_0)).get_x(), (float)((Point)(ref point_0)).get_y()), val2);
		return new Point((int)val3.X, (int)val3.Y);
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
		return desktop_0.get_Controls();
	}

	static ListBox smethod_12()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ListBox();
	}

	static void smethod_13(Control control_0, DockStyle dockStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Dock(dockStyle_0);
	}

	static ScrollBar smethod_14(ListBox listBox_0)
	{
		return listBox_0.get_Scrollbar();
	}

	static void smethod_15(ScrollBar scrollBar_0, float float_0)
	{
		scrollBar_0.set_MouseScrollSpeed(float_0);
	}

	static Button smethod_16(ScrollBar scrollBar_0)
	{
		return scrollBar_0.get_ButtonUp();
	}

	static void smethod_17(Control control_0, bool bool_0)
	{
		control_0.set_Visible(bool_0);
	}

	static Button smethod_18(ScrollBar scrollBar_0)
	{
		return scrollBar_0.get_ButtonDown();
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
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ImageControl();
	}

	static void smethod_22(ImageControl imageControl_0, string string_0)
	{
		imageControl_0.set_Texture(string_0);
	}

	static Panel smethod_23()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Panel();
	}

	static Label smethod_24()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static void smethod_25(Label label_0, string string_0)
	{
		label_0.set_Text(string_0);
	}

	static void smethod_26(Control control_0, string string_0)
	{
		control_0.set_Style(string_0);
	}

	static CustomListBoxItem smethod_27()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new CustomListBoxItem();
	}

	static ListBoxItem smethod_28()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
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
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new DropDownList();
	}

	static Label smethod_39(DropDownList dropDownList_0)
	{
		return dropDownList_0.get_Label();
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._1ZKGQXLRAHEJR8v7jhlDsyOVLcz;
	}

	static Color smethod_49(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._8rDSn6e9Ip9WdOogjhIn8YlL1oM;
	}

	static void smethod_50(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, float float_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._aAoZaDNczeScsMfLlGSfAzey9SQ(string_0, float_0);
	}

	static Color smethod_51(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G;
	}

	static void smethod_52(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, Color color_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._VoeevpFh2kLKfHtpPDXWt0TFbuH(string_0, color_0);
	}

	static Color smethod_53(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ;
	}

	static Color smethod_54(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._FrsyMDX7TebzFk8nSLTyRDPi1QH;
	}

	static bool smethod_55(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._VmNLhqrIwSnE6JnCYiBcxnSqnEV;
	}

	static Color smethod_56(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._in5HHYmrdLTFpkgc8aimJpXqAXB;
	}

	static Color smethod_57(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._uOkbmfW26QVAvyEMQakki9kTMDbA;
	}

	static _3FFZvGWTAe7rsviKkDPTXEVjxWf smethod_58(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._RbWJ7YGnYHCSoD44MRW1h5X6E7E;
	}

	static bool smethod_59(_3FFZvGWTAe7rsviKkDPTXEVjxWf _3FFZvGWTAe7rsviKkDPTXEVjxWf_0, Keys keys_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
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

	static Point smethod_62(_3FFZvGWTAe7rsviKkDPTXEVjxWf _3FFZvGWTAe7rsviKkDPTXEVjxWf_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _3FFZvGWTAe7rsviKkDPTXEVjxWf_0._U7CeYBJ1v1SoUxpX8emsQ9mWl5b;
	}

	static Point smethod_63(_wRd4nHuQQlAPEwrHOGkBfut6Uip _wRd4nHuQQlAPEwrHOGkBfut6Uip_0, Point point_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
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

	static Point smethod_72(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, ref double double_0)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
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
