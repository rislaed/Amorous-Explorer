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
				while (true)
				{
					int num = 1042034699;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x2FBBC451u) % 5u)
						{
						case 3u:
						{
							int num3;
							int num4;
							if (!_jacy9UYskskbRRyetoO92L4m4YS.smethod_1((Enum)_jacy9UYskskbRRyetoO92L4m4YS.smethod_0(_7FpdmRzPrcoARiGqtJekOfu7KqP), (Enum)result))
							{
								num3 = 972858041;
								num4 = 972858041;
							}
							else
							{
								num3 = 139789301;
								num4 = 139789301;
							}
							num = num3 ^ ((int)num2 * -861980223);
							continue;
						}
						case 4u:
							break;
						case 1u:
							return new _6OmCduUGKgPqhBnqgfNJUOmDpZW<string, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts>(string_0, result);
						case 2u:
							return null;
						default:
							goto end_IL_006d;
						}
						break;
					}
					continue;
					end_IL_006d:
					break;
				}
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
			_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._H6UwM4zjGzglzMY478iBDDvTk6I = (_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts)_oX8XrNdNse9viFEqFUqJnYYOjaf.smethod_0(_4wrjSKvuvZUTRPI3prAOEvBGDhD);
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
			return _rm4nO8SKFlFnD1XybaGLNsNLB5F.smethod_0(_iDN1IKOu3e1uADYzeMEUon5D9fg_0);
		}

		internal void _4E0kOAGtUbieJZb6BjHd9pJpJJA(int int_0)
		{
			_rm4nO8SKFlFnD1XybaGLNsNLB5F.smethod_2(_rm4nO8SKFlFnD1XybaGLNsNLB5F.smethod_1(), (DialogueSpeed)int_0);
			while (true)
			{
				int num = 126445287;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7FB6C35Bu) % 3u)
					{
					case 2u:
						goto IL_000d;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_000d:
					_rm4nO8SKFlFnD1XybaGLNsNLB5F.smethod_3((DialogueSpeed)int_0);
					num = (int)(num2 * 1764224355) ^ -1131782077;
				}
			}
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
			int num = _tdcogRALfEB0rsQ5m98f4c9BTIO.smethod_0(0, _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._OZU2jcD6pvGbls1ACzPQPKBf9ci.Length);
			_tdcogRALfEB0rsQ5m98f4c9BTIO.smethod_1(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._OZU2jcD6pvGbls1ACzPQPKBf9ci[num], ClubDJNPC._RB8fRXeQvK5vs7JEA0XfVCEpg1i, ClubDJNPC._9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA);
			while (true)
			{
				int num2 = 863253886;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0xF259453u) % 4u)
					{
					case 1u:
						_tdcogRALfEB0rsQ5m98f4c9BTIO.smethod_2(_a5X3xjbmM60JVR5AMk4qrTqgyJm._XAtd16WmK4L37sBtMsLCIvJzIS1, 0.3f, bool_0: false);
						num2 = (int)((num3 * 14443100) ^ 0x17F3264F);
						continue;
					case 0u:
						_tdcogRALfEB0rsQ5m98f4c9BTIO.smethod_4(_tdcogRALfEB0rsQ5m98f4c9BTIO.smethod_3(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._4L7hfXrWoDdArQiscG4ukHCV46B), "AchievementGeneric3");
						num2 = ((int)num3 * -722594123) ^ 0x3182D5F4;
						continue;
					default:
						return;
					case 2u:
						break;
					case 3u:
						return;
					}
					break;
				}
			}
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
			if (_7bXnkUo5ETqYLrtdisr6hKFAP6p.smethod_0(_7OcRfli7CrlI9YYUDJj3j5nDI9k))
			{
				goto IL_0039;
			}
			goto IL_0063;
			IL_0063:
			_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3AaEmo54VzWybgrrg7I8Z9JUV1e = true;
			int num = 441094585;
			goto IL_003e;
			IL_003e:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x50533F63u) % 5u)
				{
				case 4u:
					_7bXnkUo5ETqYLrtdisr6hKFAP6p.smethod_2(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._4L7hfXrWoDdArQiscG4ukHCV46B, _7bXnkUo5ETqYLrtdisr6hKFAP6p.smethod_1(_7OcRfli7CrlI9YYUDJj3j5nDI9k));
					num = (int)((num2 * 933373932) ^ 0x18F4857E);
					continue;
				case 2u:
					break;
				case 0u:
					goto IL_0063;
				default:
					_7bXnkUo5ETqYLrtdisr6hKFAP6p.smethod_4(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._9GQBAH2pi8Sm6ph1s6InjyQGe6R, _7bXnkUo5ETqYLrtdisr6hKFAP6p.smethod_3("Are you sure you wish to overwrite slot #{0}?", (object)(_7bXnkUo5ETqYLrtdisr6hKFAP6p.smethod_1(_7OcRfli7CrlI9YYUDJj3j5nDI9k) + 1)), new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, 250, (Action<int>)delegate(int int_0)
					{
						if (int_0 == 1)
						{
							goto IL_001f;
						}
						goto IL_0073;
						IL_0073:
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
						int num3 = 927455019;
						goto IL_004e;
						IL_004e:
						while (true)
						{
							uint num4;
							switch ((num4 = (uint)num3 ^ 0x3576B3B1u) % 5u)
							{
							case 4u:
								_6T55wit7MiGfAWRkPwjNbJ8N8lG._DAsCL6JdGst3kJHpcbztigO3VEV();
								num3 = (int)(num4 * 1460559687) ^ -1600763962;
								continue;
							case 3u:
								break;
							case 1u:
								_7bXnkUo5ETqYLrtdisr6hKFAP6p.smethod_2(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._4L7hfXrWoDdArQiscG4ukHCV46B, _7bXnkUo5ETqYLrtdisr6hKFAP6p.smethod_1(_7OcRfli7CrlI9YYUDJj3j5nDI9k));
								num3 = ((int)num4 * -458688331) ^ 0x495AA796;
								continue;
							default:
								return;
							case 2u:
								goto IL_0073;
							case 0u:
								return;
							}
							break;
						}
						goto IL_001f;
						IL_001f:
						num3 = 133569750;
						goto IL_004e;
					});
					return;
				case 3u:
					_6T55wit7MiGfAWRkPwjNbJ8N8lG._DAsCL6JdGst3kJHpcbztigO3VEV();
					return;
				}
				break;
			}
			goto IL_0039;
			IL_0039:
			num = 1484514535;
			goto IL_003e;
		}

		internal void _gPLk9BoC0brpUF9aPYFBgDUXFsf(int int_0)
		{
			if (int_0 == 1)
			{
				goto IL_001f;
			}
			goto IL_0073;
			IL_0073:
			_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
			int num = 927455019;
			goto IL_004e;
			IL_004e:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3576B3B1u) % 5u)
				{
				case 4u:
					_6T55wit7MiGfAWRkPwjNbJ8N8lG._DAsCL6JdGst3kJHpcbztigO3VEV();
					num = (int)(num2 * 1460559687) ^ -1600763962;
					continue;
				case 3u:
					break;
				case 1u:
					_7bXnkUo5ETqYLrtdisr6hKFAP6p.smethod_2(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._4L7hfXrWoDdArQiscG4ukHCV46B, _7bXnkUo5ETqYLrtdisr6hKFAP6p.smethod_1(_7OcRfli7CrlI9YYUDJj3j5nDI9k));
					num = ((int)num2 * -458688331) ^ 0x495AA796;
					continue;
				default:
					return;
				case 2u:
					goto IL_0073;
				case 0u:
					return;
				}
				break;
			}
			goto IL_001f;
			IL_001f:
			num = 133569750;
			goto IL_004e;
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
			if (!_2GLJdEpKkJ7x72M9J1r6gZaf9yp.smethod_0(_7OcRfli7CrlI9YYUDJj3j5nDI9k))
			{
				goto IL_0010;
			}
			goto IL_00a2;
			IL_00a2:
			int num = 244825878;
			goto IL_00c2;
			IL_00c2:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x75561744u) % 5u)
				{
				case 4u:
					break;
				case 2u:
					goto IL_00a2;
				case 1u:
					_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3AaEmo54VzWybgrrg7I8Z9JUV1e = true;
					num = ((int)num2 * -1782745634) ^ -90371643;
					continue;
				default:
					return;
				case 0u:
					return;
				case 3u:
					_2GLJdEpKkJ7x72M9J1r6gZaf9yp.smethod_4(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._9GQBAH2pi8Sm6ph1s6InjyQGe6R, _2GLJdEpKkJ7x72M9J1r6gZaf9yp.smethod_3("There is no save in {0}slot #{1}!", (object)(_2GLJdEpKkJ7x72M9J1r6gZaf9yp.smethod_1(_7OcRfli7CrlI9YYUDJj3j5nDI9k) ? "autosave " : string.Empty), (object)(_2GLJdEpKkJ7x72M9J1r6gZaf9yp.smethod_2(_7OcRfli7CrlI9YYUDJj3j5nDI9k) + 1)), 250, "OK", (Action)delegate
					{
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
					});
					return;
				}
				break;
			}
			goto IL_0010;
			IL_0010:
			_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3AaEmo54VzWybgrrg7I8Z9JUV1e = true;
			_2GLJdEpKkJ7x72M9J1r6gZaf9yp.smethod_5(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._9GQBAH2pi8Sm6ph1s6InjyQGe6R, _2GLJdEpKkJ7x72M9J1r6gZaf9yp.smethod_3("Are you sure you wish to load {0}slot #{1}?", (object)((!_2GLJdEpKkJ7x72M9J1r6gZaf9yp.smethod_1(_7OcRfli7CrlI9YYUDJj3j5nDI9k)) ? string.Empty : "autosave "), (object)(_2GLJdEpKkJ7x72M9J1r6gZaf9yp.smethod_2(_7OcRfli7CrlI9YYUDJj3j5nDI9k) + 1)), new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, 250, (Action<int>)delegate(int int_0)
			{
				if (int_0 == 1)
				{
					bool flag = default(bool);
					while (true)
					{
						int num3 = 1525845672;
						while (true)
						{
							uint num4;
							switch ((num4 = (uint)num3 ^ 0x5CBB667u) % 9u)
							{
							case 8u:
								flag = _2GLJdEpKkJ7x72M9J1r6gZaf9yp.smethod_7(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._4L7hfXrWoDdArQiscG4ukHCV46B, _2GLJdEpKkJ7x72M9J1r6gZaf9yp.smethod_2(_7OcRfli7CrlI9YYUDJj3j5nDI9k));
								num3 = 1161843164;
								continue;
							case 7u:
							{
								_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._77rSPCEs6VEYjlGrwW0KN0btLEG = true;
								int num5;
								int num6;
								if (!_2GLJdEpKkJ7x72M9J1r6gZaf9yp.smethod_1(_7OcRfli7CrlI9YYUDJj3j5nDI9k))
								{
									num5 = -749181602;
									num6 = -749181602;
								}
								else
								{
									num5 = -347991004;
									num6 = -347991004;
								}
								num3 = num5 ^ ((int)num4 * -2146342037);
								continue;
							}
							case 6u:
								break;
							case 4u:
								num3 = (int)((num4 * 72856201) ^ 0x61E9385E);
								continue;
							case 1u:
								flag = _2GLJdEpKkJ7x72M9J1r6gZaf9yp.smethod_6(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._4L7hfXrWoDdArQiscG4ukHCV46B, _2GLJdEpKkJ7x72M9J1r6gZaf9yp.smethod_2(_7OcRfli7CrlI9YYUDJj3j5nDI9k));
								num3 = (int)(num4 * 1535921268) ^ -915003603;
								continue;
							case 0u:
								goto end_IL_00c0;
							case 3u:
								_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._77rSPCEs6VEYjlGrwW0KN0btLEG = false;
								_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
								_RiDuYMeg3EHnBUteUcAb8VlfQVl();
								return;
							case 5u:
								_2GLJdEpKkJ7x72M9J1r6gZaf9yp.smethod_4(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._9GQBAH2pi8Sm6ph1s6InjyQGe6R, "Failed to load save, it's most likely corrupted.", 250, "OK", (Action)delegate
								{
									_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._77rSPCEs6VEYjlGrwW0KN0btLEG = false;
									_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
								});
								return;
							default:
								goto end_IL_00f6;
							}
							int num7;
							if (flag)
							{
								num3 = 771088788;
								num7 = 771088788;
							}
							else
							{
								num3 = 978775646;
								num7 = 978775646;
							}
							continue;
							end_IL_00c0:
							break;
						}
						continue;
						end_IL_00f6:
						break;
					}
				}
				_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
			});
			num = 1995271253;
			goto IL_00c2;
		}

		internal void _8RPKM2hyJWlk66jtUUwuyCt2FlF(int int_0)
		{
			if (int_0 == 1)
			{
				bool flag = default(bool);
				while (true)
				{
					int num = 1525845672;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x5CBB667u) % 9u)
						{
						case 8u:
							flag = _2GLJdEpKkJ7x72M9J1r6gZaf9yp.smethod_7(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._4L7hfXrWoDdArQiscG4ukHCV46B, _2GLJdEpKkJ7x72M9J1r6gZaf9yp.smethod_2(_7OcRfli7CrlI9YYUDJj3j5nDI9k));
							num = 1161843164;
							continue;
						case 7u:
						{
							_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._77rSPCEs6VEYjlGrwW0KN0btLEG = true;
							int num3;
							int num4;
							if (!_2GLJdEpKkJ7x72M9J1r6gZaf9yp.smethod_1(_7OcRfli7CrlI9YYUDJj3j5nDI9k))
							{
								num3 = -749181602;
								num4 = -749181602;
							}
							else
							{
								num3 = -347991004;
								num4 = -347991004;
							}
							num = num3 ^ ((int)num2 * -2146342037);
							continue;
						}
						case 6u:
							break;
						case 4u:
							num = (int)((num2 * 72856201) ^ 0x61E9385E);
							continue;
						case 1u:
							flag = _2GLJdEpKkJ7x72M9J1r6gZaf9yp.smethod_6(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._4L7hfXrWoDdArQiscG4ukHCV46B, _2GLJdEpKkJ7x72M9J1r6gZaf9yp.smethod_2(_7OcRfli7CrlI9YYUDJj3j5nDI9k));
							num = (int)(num2 * 1535921268) ^ -915003603;
							continue;
						case 0u:
							goto end_IL_00c0;
						case 3u:
							_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._77rSPCEs6VEYjlGrwW0KN0btLEG = false;
							_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
							_RiDuYMeg3EHnBUteUcAb8VlfQVl();
							return;
						case 5u:
							_2GLJdEpKkJ7x72M9J1r6gZaf9yp.smethod_4(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._9GQBAH2pi8Sm6ph1s6InjyQGe6R, "Failed to load save, it's most likely corrupted.", 250, "OK", (Action)delegate
							{
								_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._77rSPCEs6VEYjlGrwW0KN0btLEG = false;
								_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
							});
							return;
						default:
							goto end_IL_00f6;
						}
						int num5;
						if (flag)
						{
							num = 771088788;
							num5 = 771088788;
						}
						else
						{
							num = 978775646;
							num5 = 978775646;
						}
						continue;
						end_IL_00c0:
						break;
					}
					continue;
					end_IL_00f6:
					break;
				}
			}
			_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
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
			_ws6FjNlgAT4bj3C6lODSIPTi5Tj.smethod_2(_ws6FjNlgAT4bj3C6lODSIPTi5Tj.smethod_0(), _ws6FjNlgAT4bj3C6lODSIPTi5Tj.smethod_1(_XEgAfmv7sJWJSaC2diC3eaD4Fgl) / 100f);
		}

		internal void _do82cy4M3hWWZrTatQMCPffcAPaA(Control control_0)
		{
			_ws6FjNlgAT4bj3C6lODSIPTi5Tj.smethod_3(_ws6FjNlgAT4bj3C6lODSIPTi5Tj.smethod_0(), _ws6FjNlgAT4bj3C6lODSIPTi5Tj.smethod_1(_gjeIIVx9bHyd0aMj0WD483nrLWK) / 100f);
		}

		internal void _at091i3KPJkfwydSTUXr7ajv7mF(Control control_0)
		{
			_ws6FjNlgAT4bj3C6lODSIPTi5Tj.smethod_4(_ws6FjNlgAT4bj3C6lODSIPTi5Tj.smethod_0(), _ws6FjNlgAT4bj3C6lODSIPTi5Tj.smethod_1(_5mK9ExiyKm0md8q4J1C6xc4TzdF) / 100f);
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
			_AjJaaxdjRceHdvoz1idKTUfAsPQ.smethod_2(_AjJaaxdjRceHdvoz1idKTUfAsPQ.smethod_0(), _AjJaaxdjRceHdvoz1idKTUfAsPQ.smethod_1(_feL3soNn6ZWaJqYfjYJUyH118tF));
			_AjJaaxdjRceHdvoz1idKTUfAsPQ.smethod_3(_AjJaaxdjRceHdvoz1idKTUfAsPQ.smethod_1(_feL3soNn6ZWaJqYfjYJUyH118tF));
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
			_qhAM4Wrvf8c5jzKBQqLfosAE9D((int)_4eBWC5cHwnSO1ZNylbprsv5CLKt.smethod_0(listBoxItem_0));
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
				_ySEG6XuZVhXoWbL0fJc0sGefKrh.smethod_1(!_ySEG6XuZVhXoWbL0fJc0sGefKrh.smethod_0());
				while (true)
				{
					int num = -1262699072;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x81DF6B2Fu) % 3u)
						{
						case 2u:
							goto IL_000f;
						case 0u:
							break;
						default:
							_ySEG6XuZVhXoWbL0fJc0sGefKrh.smethod_2((Label)(object)_diVdxVCKW4CzhbYSG15BcHJB0Ub, _ySEG6XuZVhXoWbL0fJc0sGefKrh.smethod_0() ? "Disable SFW" : "Enable SFW");
							return;
						}
						break;
						IL_000f:
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._DAsCL6JdGst3kJHpcbztigO3VEV();
						num = (int)((num2 * 740754639) ^ 0x71B64C9D);
					}
				}
			});
		}

		internal void _8nn4N2xgzjlh5Yz5WSSHCJ9URjf()
		{
			_ySEG6XuZVhXoWbL0fJc0sGefKrh.smethod_1(!_ySEG6XuZVhXoWbL0fJc0sGefKrh.smethod_0());
			while (true)
			{
				int num = -1262699072;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x81DF6B2Fu) % 3u)
					{
					case 2u:
						goto IL_000f;
					case 0u:
						break;
					default:
						_ySEG6XuZVhXoWbL0fJc0sGefKrh.smethod_2((Label)(object)_diVdxVCKW4CzhbYSG15BcHJB0Ub, _ySEG6XuZVhXoWbL0fJc0sGefKrh.smethod_0() ? "Disable SFW" : "Enable SFW");
						return;
					}
					break;
					IL_000f:
					_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._DAsCL6JdGst3kJHpcbztigO3VEV();
					num = (int)((num2 * 740754639) ^ 0x71B64C9D);
				}
			}
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
				_wr6xcvFOgUbaTATC17S6Y9v3y3S = this
			};
			while (true)
			{
				int num = -527750492;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD885B90Eu) % 4u)
					{
					case 3u:
						_0nFvyop0acDTSu0pbg4xnLHeOi.smethod_3(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._4L7hfXrWoDdArQiscG4ukHCV46B);
						num = ((int)num2 * -1744590626) ^ -1707012779;
						continue;
					case 2u:
					{
						_TwlwMC1hhdSzamwGWEBxuUkz1gH twlwMC1hhdSzamwGWEBxuUkz1gH = _0nFvyop0acDTSu0pbg4xnLHeOi.smethod_0(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._4L7hfXrWoDdArQiscG4ukHCV46B);
						CS_0024_003C_003E8__locals0._nc2gJWKJm6yAMtppwpcfigGPFj3 = ((twlwMC1hhdSzamwGWEBxuUkz1gH != null) ? _0nFvyop0acDTSu0pbg4xnLHeOi.smethod_2((MemberInfo)_0nFvyop0acDTSu0pbg4xnLHeOi.smethod_1((object)twlwMC1hhdSzamwGWEBxuUkz1gH)) : null);
						int num3;
						if (CS_0024_003C_003E8__locals0._nc2gJWKJm6yAMtppwpcfigGPFj3 != null)
						{
							num = -592996755;
							num3 = -592996755;
						}
						else
						{
							num = -1062862193;
							num3 = -1062862193;
						}
						continue;
					}
					case 0u:
						break;
					default:
						_qhAM4Wrvf8c5jzKBQqLfosAE9D();
						_0nFvyop0acDTSu0pbg4xnLHeOi.smethod_6(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._4L7hfXrWoDdArQiscG4ukHCV46B, _0nFvyop0acDTSu0pbg4xnLHeOi.smethod_2((MemberInfo)_0nFvyop0acDTSu0pbg4xnLHeOi.smethod_5((object)_0nFvyop0acDTSu0pbg4xnLHeOi.smethod_4(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._4L7hfXrWoDdArQiscG4ukHCV46B))), (Action)delegate
						{
							if (CS_0024_003C_003E8__locals0._nc2gJWKJm6yAMtppwpcfigGPFj3 != null)
							{
								goto IL_0034;
							}
							goto IL_005a;
							IL_005a:
							_Xz9JDCJHGCV62mEFcQGw4HJ6Lgn.smethod_2(_Xz9JDCJHGCV62mEFcQGw4HJ6Lgn.smethod_1(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._4L7hfXrWoDdArQiscG4ukHCV46B), (Action)null);
							int num4 = -194036894;
							goto IL_0039;
							IL_0039:
							while (true)
							{
								uint num5;
								switch ((num5 = (uint)num4 ^ 0xDAD7EA97u) % 4u)
								{
								case 3u:
									_Xz9JDCJHGCV62mEFcQGw4HJ6Lgn.smethod_0(CS_0024_003C_003E8__locals0._wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._4L7hfXrWoDdArQiscG4ukHCV46B, CS_0024_003C_003E8__locals0._nc2gJWKJm6yAMtppwpcfigGPFj3);
									num4 = ((int)num5 * -1073173012) ^ 0x21D28C03;
									continue;
								case 2u:
									break;
								default:
									return;
								case 0u:
									goto IL_005a;
								case 1u:
									return;
								}
								break;
							}
							goto IL_0034;
							IL_0034:
							num4 = -1262047732;
							goto IL_0039;
						});
						return;
					}
					break;
				}
			}
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
				goto IL_0034;
			}
			goto IL_005a;
			IL_005a:
			_Xz9JDCJHGCV62mEFcQGw4HJ6Lgn.smethod_2(_Xz9JDCJHGCV62mEFcQGw4HJ6Lgn.smethod_1(_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._4L7hfXrWoDdArQiscG4ukHCV46B), (Action)null);
			int num = -194036894;
			goto IL_0039;
			IL_0039:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDAD7EA97u) % 4u)
				{
				case 3u:
					_Xz9JDCJHGCV62mEFcQGw4HJ6Lgn.smethod_0(_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._4L7hfXrWoDdArQiscG4ukHCV46B, _nc2gJWKJm6yAMtppwpcfigGPFj3);
					num = ((int)num2 * -1073173012) ^ 0x21D28C03;
					continue;
				case 2u:
					break;
				default:
					return;
				case 0u:
					goto IL_005a;
				case 1u:
					return;
				}
				break;
			}
			goto IL_0034;
			IL_0034:
			num = -1262047732;
			goto IL_0039;
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
				_J2cDcMayMidSIab2lnReI8upBwS.smethod_1(!_J2cDcMayMidSIab2lnReI8upBwS.smethod_0());
				while (true)
				{
					int num = -1086439274;
					while (true)
					{
						ListBoxItem epeel2m9h5O12V2ERwlnNTE3FdM;
						string string_;
						switch ((uint)(num ^ -273731706) % 3u)
						{
						case 1u:
							epeel2m9h5O12V2ERwlnNTE3FdM = _Epeel2m9h5O12V2ERwlnNTE3FdM;
							string_ = (_J2cDcMayMidSIab2lnReI8upBwS.smethod_0() ? "Disable Topless Cheat" : "Enable Topless Cheat");
							goto IL_002a;
						default:
							return;
						case 0u:
							break;
						case 2u:
							return;
						}
						break;
						IL_002a:
						_J2cDcMayMidSIab2lnReI8upBwS.smethod_2((Label)(object)epeel2m9h5O12V2ERwlnNTE3FdM, string_);
						num = -646255287;
					}
				}
			});
		}

		internal void _SIpzzpgYIDeDw3DbVv5Fv9S6iOg()
		{
			_J2cDcMayMidSIab2lnReI8upBwS.smethod_1(!_J2cDcMayMidSIab2lnReI8upBwS.smethod_0());
			while (true)
			{
				int num = -1086439274;
				while (true)
				{
					ListBoxItem epeel2m9h5O12V2ERwlnNTE3FdM;
					string string_;
					switch ((uint)(num ^ -273731706) % 3u)
					{
					case 1u:
						epeel2m9h5O12V2ERwlnNTE3FdM = _Epeel2m9h5O12V2ERwlnNTE3FdM;
						string_ = (_J2cDcMayMidSIab2lnReI8upBwS.smethod_0() ? "Disable Topless Cheat" : "Enable Topless Cheat");
						goto IL_002a;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
					IL_002a:
					_J2cDcMayMidSIab2lnReI8upBwS.smethod_2((Label)(object)epeel2m9h5O12V2ERwlnNTE3FdM, string_);
					num = -646255287;
				}
			}
		}

		internal void _8n73s4MCzZ9OGqXivRGVyT81BNJ(Control control_0, MouseEventArgs mouseEventArgs_0)
		{
			_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._YdyKdWT8QbQOIWkgEuPe6a9hJtd(delegate
			{
				_J2cDcMayMidSIab2lnReI8upBwS.smethod_4(!_J2cDcMayMidSIab2lnReI8upBwS.smethod_3());
				_J2cDcMayMidSIab2lnReI8upBwS.smethod_2((Label)(object)_FxyX2MMMdsf69424VDXa8LqP1nq, _J2cDcMayMidSIab2lnReI8upBwS.smethod_3() ? "Disable Bottomless Cheat" : "Enable Bottomless Cheat");
			});
		}

		internal void _vsOcQWBxGADsTpFI7jsoDDsob3A()
		{
			_J2cDcMayMidSIab2lnReI8upBwS.smethod_4(!_J2cDcMayMidSIab2lnReI8upBwS.smethod_3());
			_J2cDcMayMidSIab2lnReI8upBwS.smethod_2((Label)(object)_FxyX2MMMdsf69424VDXa8LqP1nq, _J2cDcMayMidSIab2lnReI8upBwS.smethod_3() ? "Disable Bottomless Cheat" : "Enable Bottomless Cheat");
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
				goto IL_0022;
			}
			goto IL_0056;
			IL_0056:
			int num;
			int num2;
			if (!_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._0OvMkQYTGPrNhckv6iHt3zmR5ni.ContainsKey(string_0))
			{
				num = 1671723878;
				num2 = 1671723878;
			}
			else
			{
				num = 413607980;
				num2 = 413607980;
			}
			goto IL_0027;
			IL_0027:
			switch ((uint)(num ^ 0x32C4C508) % 5u)
			{
			case 0u:
				break;
			case 1u:
				goto IL_0056;
			default:
				return true;
			case 3u:
				return _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._PcaKA8lfkZnYKjOTdM7RWYPBlGr[string_0];
			case 4u:
				return _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._0OvMkQYTGPrNhckv6iHt3zmR5ni[string_0];
			}
			goto IL_0022;
			IL_0022:
			num = 1817920988;
			goto IL_0027;
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
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_033a: Unknown result type (might be due to invalid IL or missing references)
			if (_HQitgQ0mYB5XukcD7eKHBJPmdqs.smethod_0(string_0, "Sheen Two"))
			{
				goto IL_03f8;
			}
			goto IL_04fd;
			IL_04fd:
			int num;
			int num2;
			if (!(string_0 == "Thumb"))
			{
				num = -580014027;
				num2 = -580014027;
			}
			else
			{
				num = -767311204;
				num2 = -767311204;
			}
			goto IL_048c;
			IL_048c:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num ^ 0xB096B928u) % 20u)
				{
				case 19u:
					_wr6xcvFOgUbaTATC17S6Y9v3y3S._EKVVcDQFi8O0uiXnuvUCgwRPdh4.End();
					num = -1593638408;
					continue;
				case 18u:
					_wr6xcvFOgUbaTATC17S6Y9v3y3S._EKVVcDQFi8O0uiXnuvUCgwRPdh4.Begin();
					num = ((int)num3 * -145759403) ^ -1315348250;
					continue;
				case 17u:
				{
					int num6;
					int num7;
					if (!_HzpuNgBJAQYObWMhiboQRiPGmvp.Contains(string_0))
					{
						num6 = 1536579300;
						num7 = 1536579300;
					}
					else
					{
						num6 = 681737346;
						num7 = 681737346;
					}
					num = num6 ^ (int)(num3 * 492957605);
					continue;
				}
				case 16u:
				{
					int num8;
					int num9;
					if (_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Ldzm1JY9st4tknAhrglOIpwdYhn)
					{
						num8 = -936693258;
						num9 = -936693258;
					}
					else
					{
						num8 = -809761438;
						num9 = -809761438;
					}
					num = num8 ^ (int)(num3 * 1303214467);
					continue;
				}
				case 15u:
					_wr6xcvFOgUbaTATC17S6Y9v3y3S._EKVVcDQFi8O0uiXnuvUCgwRPdh4._f5ctqAmdNsZ889UjM4LxDm8WGxA((Texture2D)(object)_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Pfaq6ajchxcqF6GecivHvHqQW6M, (Vector2?)new Vector2((float)_eeWHzOz6LrTokRQr52VaB0dKbQO.X, (float)_eeWHzOz6LrTokRQr52VaB0dKbQO.Y), (Rectangle?)null, (Rectangle?)null, (Vector2?)null, (float)_09rdYyvQzUwbdQbzRZF4vbpdUCO, (Vector2?)null, (Color?)null, (SpriteEffects)0, 0f);
					num = (int)(num3 * 1060689362) ^ -1027939515;
					continue;
				case 14u:
					break;
				case 13u:
					goto IL_0185;
				case 12u:
					_wr6xcvFOgUbaTATC17S6Y9v3y3S._EKVVcDQFi8O0uiXnuvUCgwRPdh4._f5ctqAmdNsZ889UjM4LxDm8WGxA(_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._Et7ViKuaneif1JVK3bifonUhKPR, (Vector2?)new Vector2((float)(_eeWHzOz6LrTokRQr52VaB0dKbQO.X - 16), (float)(_eeWHzOz6LrTokRQr52VaB0dKbQO.Y - 128)), (Rectangle?)null, (Rectangle?)null, (Vector2?)null, (float)_09rdYyvQzUwbdQbzRZF4vbpdUCO, (Vector2?)null, (Color?)null, (SpriteEffects)0, 0f);
					_wr6xcvFOgUbaTATC17S6Y9v3y3S._EKVVcDQFi8O0uiXnuvUCgwRPdh4.End();
					_wr6xcvFOgUbaTATC17S6Y9v3y3S._r1FADOtDcwMP4Tohv3ntBfhuMNp.Begin(0f, 0f, 1f);
					num = ((int)num3 * -726720291) ^ -540281675;
					continue;
				case 11u:
					_wr6xcvFOgUbaTATC17S6Y9v3y3S._EKVVcDQFi8O0uiXnuvUCgwRPdh4._f5ctqAmdNsZ889UjM4LxDm8WGxA(_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._BphDC8XZceMl5rqVm5zdrD6meOf, (Vector2?)new Vector2((float)_eeWHzOz6LrTokRQr52VaB0dKbQO.X, (float)_eeWHzOz6LrTokRQr52VaB0dKbQO.Y), (Rectangle?)null, (Rectangle?)null, (Vector2?)null, (float)_09rdYyvQzUwbdQbzRZF4vbpdUCO, (Vector2?)null, (Color?)null, (SpriteEffects)0, 0f);
					num = ((int)num3 * -920608836) ^ 0x7C4675E7;
					continue;
				case 10u:
					_wr6xcvFOgUbaTATC17S6Y9v3y3S._EKVVcDQFi8O0uiXnuvUCgwRPdh4._f5ctqAmdNsZ889UjM4LxDm8WGxA((Texture2D)(object)_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._bZJtpWV2Yj6GgZkeZQUmpTHxTnh, (Vector2?)new Vector2((float)_eeWHzOz6LrTokRQr52VaB0dKbQO.X, (float)_eeWHzOz6LrTokRQr52VaB0dKbQO.Y), (Rectangle?)null, (Rectangle?)null, (Vector2?)null, (float)_09rdYyvQzUwbdQbzRZF4vbpdUCO, (Vector2?)null, (Color?)null, (SpriteEffects)0, 0f);
					num = ((int)num3 * -777062895) ^ 0x402B795C;
					continue;
				case 9u:
					_HQitgQ0mYB5XukcD7eKHBJPmdqs.smethod_1(_wr6xcvFOgUbaTATC17S6Y9v3y3S._r1FADOtDcwMP4Tohv3ntBfhuMNp);
					_HQitgQ0mYB5XukcD7eKHBJPmdqs.smethod_2(_wr6xcvFOgUbaTATC17S6Y9v3y3S._EKVVcDQFi8O0uiXnuvUCgwRPdh4);
					num = (int)((num3 * 1956259689) ^ 0x8E31E89);
					continue;
				case 8u:
					_wr6xcvFOgUbaTATC17S6Y9v3y3S._r1FADOtDcwMP4Tohv3ntBfhuMNp.Begin(0f, 0f, 1f);
					num = ((int)num3 * -1235502726) ^ -588814635;
					continue;
				case 6u:
					goto end_IL_048c;
				case 5u:
					num = ((int)num3 * -6241874) ^ -1360121413;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (!_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._1gXQH16lmsacxQMOpjFFqZSmjQl)
					{
						num4 = -272937540;
						num5 = -272937540;
					}
					else
					{
						num4 = -1266231639;
						num5 = -1266231639;
					}
					num = num4 ^ ((int)num3 * -1543526829);
					continue;
				}
				case 3u:
					goto IL_0444;
				case 0u:
					_wr6xcvFOgUbaTATC17S6Y9v3y3S._r1FADOtDcwMP4Tohv3ntBfhuMNp.End();
					num = ((int)num3 * -1552473053) ^ -1067285126;
					continue;
				case 2u:
					goto IL_04fd;
				default:
					return true;
				case 7u:
					return false;
				}
				int num10;
				if (_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._rASuGHWSFVWfkpwzF8wZd9bh3XN)
				{
					num = -311965021;
					num10 = -311965021;
				}
				else
				{
					num = -1852070317;
					num10 = -1852070317;
				}
				continue;
				IL_0444:
				int num11;
				if (!_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._97m6gVcwgWbLFyNUxI3P1KuD0Gn)
				{
					num = -136943473;
					num11 = -136943473;
				}
				else
				{
					num = -1778984381;
					num11 = -1778984381;
				}
				continue;
				IL_0185:
				int num12;
				if (_wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._1gXQH16lmsacxQMOpjFFqZSmjQl)
				{
					num = -113310219;
					num12 = -113310219;
				}
				else
				{
					num = -239189803;
					num12 = -239189803;
				}
				continue;
				end_IL_048c:
				break;
			}
			goto IL_03f8;
			IL_03f8:
			num = -1823368979;
			goto IL_048c;
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

	private static readonly string[] _I35ziY7HYJkfL20RDXWOC7Pcv1q;

	private static readonly string[] _HzpuNgBJAQYObWMhiboQRiPGmvp;

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
			while (true)
			{
				int num = 1140315018;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7C04A184u) % 6u)
					{
					case 4u:
						_f2smFxmYyFJyj81xWGaGLB2G7ef = _wlQdV74JhqkBVxNonpbfqZEmjIbA.NoMessage;
						num = (int)(num2 * 866332472) ^ -1458537975;
						continue;
					case 3u:
						_f2smFxmYyFJyj81xWGaGLB2G7ef = _wlQdV74JhqkBVxNonpbfqZEmjIbA.None;
						num = 141228029;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (!_kodtINvkfS2a7kqthXOxN1a4Rth)
						{
							num3 = 1596546199;
							num4 = 1596546199;
						}
						else
						{
							num3 = 2078593964;
							num4 = 2078593964;
						}
						num = num3 ^ (int)(num2 * 385628398);
						continue;
					}
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					case 5u:
						return;
					}
					break;
				}
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
			if (value == _6T55wit7MiGfAWRkPwjNbJ8N8lG._2xrvCNtGtRPjKFYKw9nbGLrJCPy)
			{
				return;
			}
			while (true)
			{
				int num = 539258301;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2EA1E0BCu) % 11u)
					{
					case 10u:
						_poenyHBGUusBcnNcTFB9MQBV72R.smethod_2(_6T55wit7MiGfAWRkPwjNbJ8N8lG._lpMGMQZJYmHr6q9XBRwiM0Lse4N, "Message idle", (Action<int>)null);
						num = 927337395;
						continue;
					case 8u:
						_6T55wit7MiGfAWRkPwjNbJ8N8lG._2xrvCNtGtRPjKFYKw9nbGLrJCPy = value;
						switch (value)
						{
						case _wlQdV74JhqkBVxNonpbfqZEmjIbA.MessageIdle:
							break;
						default:
							goto IL_0058;
						case _wlQdV74JhqkBVxNonpbfqZEmjIbA.NoMessage:
							goto IL_0067;
						case _wlQdV74JhqkBVxNonpbfqZEmjIbA.MessageUrgent:
							goto IL_0084;
						case _wlQdV74JhqkBVxNonpbfqZEmjIbA.MessageNew:
							goto IL_00ff;
						}
						goto case 10u;
					case 0u:
						goto IL_0067;
					case 3u:
						goto IL_0084;
					case 6u:
						_6T55wit7MiGfAWRkPwjNbJ8N8lG._IiWYS6YP6cEj83PIAXepbAHBaJB();
						num = (int)(num2 * 181481796) ^ -1424087806;
						continue;
					default:
						return;
					case 7u:
						break;
					case 4u:
						return;
					case 5u:
						return;
					case 1u:
						goto IL_00ff;
					case 9u:
						return;
					case 2u:
						return;
						IL_00ff:
						_poenyHBGUusBcnNcTFB9MQBV72R.smethod_2(_6T55wit7MiGfAWRkPwjNbJ8N8lG._lpMGMQZJYmHr6q9XBRwiM0Lse4N, "Message new", (Action<int>)null);
						return;
						IL_0084:
						_poenyHBGUusBcnNcTFB9MQBV72R.smethod_2(_6T55wit7MiGfAWRkPwjNbJ8N8lG._lpMGMQZJYmHr6q9XBRwiM0Lse4N, "Urgent message", (Action<int>)null);
						num = 1702573655;
						continue;
						IL_0067:
						_poenyHBGUusBcnNcTFB9MQBV72R.smethod_2(_6T55wit7MiGfAWRkPwjNbJ8N8lG._lpMGMQZJYmHr6q9XBRwiM0Lse4N, "No message", (Action<int>)null);
						num = 236012838;
						continue;
						IL_0058:
						num = ((int)num2 * -1444573795) ^ 0x3ABDAE04;
						continue;
					}
					break;
				}
			}
		}
	}

	public void _74zyK2mDlnXqbPqFXMVn07h7ifH(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts ephoneContacts_0)
	{
		_3mKo17hkpGwyDp6sHVZAhV1c6Qv(ephoneContacts_0);
		while (true)
		{
			int num = -307613328;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE182F02Fu) % 4u)
				{
				case 3u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_0(_wTbB4YBL4PSkaotwKX3CFc50DmX);
					num = ((int)num2 * -1566277596) ^ -1219023795;
					continue;
				case 2u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_1(_wTbB4YBL4PSkaotwKX3CFc50DmX, "Phone answer start", (Action)delegate
					{
						_poenyHBGUusBcnNcTFB9MQBV72R.smethod_2(_wTbB4YBL4PSkaotwKX3CFc50DmX, "Phone answer loop", (Action<int>)null);
					});
					_Pbt0pgZ2cGZkaxR9cQe0r2v2lVd();
					num = (int)(num2 * 1118625658) ^ -383312638;
					continue;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public void _N6rbbp9vfBTLIy29VRlaxyb7udeA(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts ephoneContacts_0)
	{
		_3mKo17hkpGwyDp6sHVZAhV1c6Qv(ephoneContacts_0);
		while (true)
		{
			int num = -908874990;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB9C35619u) % 3u)
				{
				case 2u:
					goto IL_0009;
				case 0u:
					break;
				default:
					_Pbt0pgZ2cGZkaxR9cQe0r2v2lVd();
					return;
				}
				break;
				IL_0009:
				_poenyHBGUusBcnNcTFB9MQBV72R.smethod_1(_wTbB4YBL4PSkaotwKX3CFc50DmX, "Phone IM accept", (Action)delegate
				{
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_2(_wTbB4YBL4PSkaotwKX3CFc50DmX, "Phone IM idle", (Action<int>)null);
				});
				num = (int)(num2 * 915961225) ^ -128157385;
			}
		}
	}

	public void _IiIBp9h21zmpuvGulVNz008r8TA(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts ephoneContacts_0)
	{
		_rASuGHWSFVWfkpwzF8wZd9bh3XN = true;
		while (true)
		{
			int num = -1279384612;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEC1E598Au) % 3u)
				{
				case 1u:
					goto IL_0009;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0009:
				_Pbt0pgZ2cGZkaxR9cQe0r2v2lVd();
				num = ((int)num2 * -485557249) ^ 0x607EDDFD;
			}
		}
	}

	public void _yIdbijdoIArgGYmQaSg2XCsw9hT(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts ephoneContacts_0)
	{
		_rASuGHWSFVWfkpwzF8wZd9bh3XN = true;
		while (true)
		{
			int num = 1343273171;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8E987DAu) % 3u)
				{
				case 1u:
					goto IL_0009;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0009:
				_Pbt0pgZ2cGZkaxR9cQe0r2v2lVd();
				num = ((int)num2 * -661873512) ^ -348942362;
			}
		}
	}

	public void _zm6vAchd6YcmYOAA7H1gpRDyQ3f(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts ephoneContacts_0)
	{
		_3mKo17hkpGwyDp6sHVZAhV1c6Qv(ephoneContacts_0);
		while (true)
		{
			int num = -1823788097;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEE17B4E4u) % 3u)
				{
				case 2u:
					goto IL_0009;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0009:
				_8hw6Dkw1FlTEpsiy0adBUXTGpRe(bool_0: true);
				_poenyHBGUusBcnNcTFB9MQBV72R.smethod_0(_wTbB4YBL4PSkaotwKX3CFc50DmX);
				_poenyHBGUusBcnNcTFB9MQBV72R.smethod_1(_wTbB4YBL4PSkaotwKX3CFc50DmX, "Phone Call start", (Action)delegate
				{
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_2(_wTbB4YBL4PSkaotwKX3CFc50DmX, "Phone Call loop", (Action<int>)null);
				});
				_Pbt0pgZ2cGZkaxR9cQe0r2v2lVd();
				num = ((int)num2 * -650851734) ^ 0x246E9C89;
			}
		}
	}

	public void _lMCk2LRgUr0BxjjkcGh4aHIw2kf(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts ephoneContacts_0)
	{
		_znPUoLNKAYlonsIsyRDTBqJ16RE(ephoneContacts_0);
	}

	public void _RKOSDyYel4mDgA7CBL7icGDh8NX(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts ephoneContacts_0)
	{
		_3mKo17hkpGwyDp6sHVZAhV1c6Qv(ephoneContacts_0);
		while (true)
		{
			int num = 759651054;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1C967EF9u) % 3u)
				{
				case 2u:
					goto IL_0009;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0009:
				_poenyHBGUusBcnNcTFB9MQBV72R.smethod_2(_wTbB4YBL4PSkaotwKX3CFc50DmX, "Phone IM idle", (Action<int>)null);
				_Pbt0pgZ2cGZkaxR9cQe0r2v2lVd();
				num = (int)(num2 * 525057927) ^ -514815722;
			}
		}
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
		_poenyHBGUusBcnNcTFB9MQBV72R.smethod_1(_wTbB4YBL4PSkaotwKX3CFc50DmX, "Phone IM messaging loop", (Action)delegate
		{
			_poenyHBGUusBcnNcTFB9MQBV72R.smethod_2(_wTbB4YBL4PSkaotwKX3CFc50DmX, "Phone IM idle", (Action<int>)null);
		});
		_iclFNsZuDOZLCNYXakYmA0rt3UU();
	}

	private void _znPUoLNKAYlonsIsyRDTBqJ16RE(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts ephoneContacts_0)
	{
		_3mKo17hkpGwyDp6sHVZAhV1c6Qv(ephoneContacts_0);
		while (true)
		{
			int num = -117922327;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF7431DBEu) % 5u)
				{
				case 4u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_1(_wTbB4YBL4PSkaotwKX3CFc50DmX, "Phone Call start", (Action)delegate
					{
						_poenyHBGUusBcnNcTFB9MQBV72R.smethod_2(_wTbB4YBL4PSkaotwKX3CFc50DmX, "Phone Call loop", (Action<int>)null);
					});
					_Pbt0pgZ2cGZkaxR9cQe0r2v2lVd();
					num = ((int)num2 * -1345329803) ^ -741335429;
					continue;
				case 3u:
					_8hw6Dkw1FlTEpsiy0adBUXTGpRe(bool_0: false);
					num = (int)((num2 * 2096496910) ^ 0x3E9D168D);
					continue;
				case 1u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_0(_wTbB4YBL4PSkaotwKX3CFc50DmX);
					num = (int)(num2 * 1221296606) ^ -981653922;
					continue;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public void _2q4ULWZHQg4Aboj4mYnu05b6gpq()
	{
		_1gXQH16lmsacxQMOpjFFqZSmjQl = false;
		while (true)
		{
			int num = -2017268914;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFAF53308u) % 5u)
				{
				case 4u:
				{
					int num3;
					int num4;
					if (_WLqMMhDU6lDWhPjohexo40VadrB < _MCqah9fRROAHE2fkIv4nkhrpDKX.Length)
					{
						num3 = -1544921196;
						num4 = -1544921196;
					}
					else
					{
						num3 = -2139723435;
						num4 = -2139723435;
					}
					num = num3 ^ ((int)num2 * -1402290616);
					continue;
				}
				case 3u:
					_WLqMMhDU6lDWhPjohexo40VadrB = 0;
					num = (int)((num2 * 1194650986) ^ 0x2257C096);
					continue;
				case 1u:
					_Et7ViKuaneif1JVK3bifonUhKPR = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_3(_4L7hfXrWoDdArQiscG4ukHCV46B).Load<Texture2D>(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_4("Assets/GUI/Phone/Gameboxes/", _MCqah9fRROAHE2fkIv4nkhrpDKX[_WLqMMhDU6lDWhPjohexo40VadrB]));
					_WLqMMhDU6lDWhPjohexo40VadrB++;
					num = ((int)num2 * -1552007730) ^ -1282079636;
					continue;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
			}
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
		_BphDC8XZceMl5rqVm5zdrD6meOf = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_3(_4L7hfXrWoDdArQiscG4ukHCV46B).Load<Texture2D>(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_4("Assets/GUI/Phone/Gallery/Remy/", _I35ziY7HYJkfL20RDXWOC7Pcv1q[_j2EdRylzMDum240gfhMGkyqki8j]));
		while (true)
		{
			int num = -1668782083;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB2D46653u) % 4u)
				{
				case 3u:
					_j2EdRylzMDum240gfhMGkyqki8j = 0;
					num = (int)(num2 * 1996975513) ^ -1155944051;
					continue;
				case 2u:
				{
					_j2EdRylzMDum240gfhMGkyqki8j++;
					int num3;
					int num4;
					if (_j2EdRylzMDum240gfhMGkyqki8j >= _I35ziY7HYJkfL20RDXWOC7Pcv1q.Length)
					{
						num3 = 569943298;
						num4 = 569943298;
					}
					else
					{
						num3 = 915256388;
						num4 = 915256388;
					}
					num = num3 ^ (int)(num2 * 1430835441);
					continue;
				}
				case 0u:
					break;
				default:
					_Pbt0pgZ2cGZkaxR9cQe0r2v2lVd();
					return;
				}
				break;
			}
		}
	}

	public void _f2CdPIvAGYavrZlA3VXyxB0B8Jh(int int_0)
	{
		_97m6gVcwgWbLFyNUxI3P1KuD0Gn = false;
		while (true)
		{
			int num = -1216185631;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x98746AECu) % 3u)
				{
				case 1u:
					goto IL_0009;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0009:
				_BphDC8XZceMl5rqVm5zdrD6meOf = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_3(_4L7hfXrWoDdArQiscG4ukHCV46B).Load<Texture2D>(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_4("Assets/GUI/Phone/Gallery/Remy/", _I35ziY7HYJkfL20RDXWOC7Pcv1q[int_0]));
				_Pbt0pgZ2cGZkaxR9cQe0r2v2lVd();
				num = ((int)num2 * -372396970) ^ -1478977468;
			}
		}
	}

	public void _zFlBtKgcAb6cv77WHC6dI3lO8EwA()
	{
		_97m6gVcwgWbLFyNUxI3P1KuD0Gn = true;
		while (true)
		{
			int num = 1325247897;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x63FC9EE3u) % 4u)
				{
				case 2u:
					_j2EdRylzMDum240gfhMGkyqki8j = 0;
					num = (int)(num2 * 596643352) ^ -1965228542;
					continue;
				case 1u:
					_Pbt0pgZ2cGZkaxR9cQe0r2v2lVd();
					num = (int)(num2 * 331500034) ^ -1304246754;
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public void _l78cdi393ZI3QSrFwNTTIJoYKGQ()
	{
		_rASuGHWSFVWfkpwzF8wZd9bh3XN = true;
	}

	public void _haICL4qkfkOLhPhofWQH1GmjZx5()
	{
		_rASuGHWSFVWfkpwzF8wZd9bh3XN = true;
		while (true)
		{
			int num = -616680369;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB045AB64u) % 5u)
				{
				case 4u:
					_97m6gVcwgWbLFyNUxI3P1KuD0Gn = true;
					num = (int)(num2 * 1838759028) ^ -480817269;
					continue;
				case 3u:
					_j2EdRylzMDum240gfhMGkyqki8j = 0;
					num = ((int)num2 * -893914626) ^ -1359828368;
					continue;
				case 2u:
					_1gXQH16lmsacxQMOpjFFqZSmjQl = true;
					_WLqMMhDU6lDWhPjohexo40VadrB = 0;
					num = ((int)num2 * -1256686684) ^ 0x62AA7375;
					continue;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public static void _Oewx0FJJ8VX41Prmv0htvGQZhUf()
	{
		if (_poenyHBGUusBcnNcTFB9MQBV72R.smethod_5(_6T55wit7MiGfAWRkPwjNbJ8N8lG._4L7hfXrWoDdArQiscG4ukHCV46B) != null)
		{
			goto IL_0049;
		}
		goto IL_00b4;
		IL_00b4:
		int num;
		int num2;
		if (!_6T55wit7MiGfAWRkPwjNbJ8N8lG._TZx1AkahTLXoM2XUbm5U8YJOScb)
		{
			num = -1095617049;
			num2 = -1095617049;
		}
		else
		{
			num = -3716007;
			num2 = -3716007;
		}
		goto IL_006f;
		IL_006f:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0xD1544E4Cu) % 9u)
			{
			case 8u:
				break;
			case 7u:
				goto end_IL_006f;
			case 3u:
				_IRQBceahi9mKwSlKg4gzjmohz1H();
				num = -45877252;
				continue;
			case 1u:
				_RiDuYMeg3EHnBUteUcAb8VlfQVl();
				num = (int)(num3 * 1835307559) ^ -1049624608;
				continue;
			default:
				return;
			case 2u:
				goto IL_00b4;
			case 0u:
				return;
			case 4u:
				return;
			case 5u:
				return;
			case 6u:
				return;
			}
			int num4;
			if (_6T55wit7MiGfAWRkPwjNbJ8N8lG._j2OEvLQtM2lODSmH3ZFP6wWCWpF == _fFGgY4gvWNcTLSlsfe9k99ctumb.ArmUp)
			{
				num = -1352425302;
				num4 = -1352425302;
			}
			else
			{
				num = -1777341356;
				num4 = -1777341356;
			}
			continue;
			end_IL_006f:
			break;
		}
		goto IL_0049;
		IL_0049:
		num = -165225364;
		goto IL_006f;
	}

	public static void _IRQBceahi9mKwSlKg4gzjmohz1H(bool bool_0 = false)
	{
		if (!_kf3EbE0B70xGe1szklqAZyCqoLj)
		{
			goto IL_00ef;
		}
		goto IL_013d;
		IL_013d:
		int num;
		int num2;
		if (_6T55wit7MiGfAWRkPwjNbJ8N8lG._0IwNM2MxOUN4RsEqXREAdDRe4Ad)
		{
			num = -231166261;
			num2 = -231166261;
		}
		else
		{
			num = -1595119236;
			num2 = -1595119236;
		}
		goto IL_00f4;
		IL_00f4:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0xB0138CD8u) % 10u)
			{
			case 8u:
				_poenyHBGUusBcnNcTFB9MQBV72R.smethod_7(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_6(_6T55wit7MiGfAWRkPwjNbJ8N8lG._4L7hfXrWoDdArQiscG4ukHCV46B), "AchievementGeneric5");
				num = ((int)num3 * -1931914016) ^ -333101813;
				continue;
			case 7u:
				break;
			case 6u:
				_6T55wit7MiGfAWRkPwjNbJ8N8lG._j2OEvLQtM2lODSmH3ZFP6wWCWpF = _fFGgY4gvWNcTLSlsfe9k99ctumb.ArmUpRequested;
				num = -78733555;
				continue;
			case 4u:
				_6T55wit7MiGfAWRkPwjNbJ8N8lG._0IwNM2MxOUN4RsEqXREAdDRe4Ad = true;
				num = (int)(num3 * 1485628423) ^ -702268202;
				continue;
			case 1u:
			{
				int num4;
				int num5;
				if (_6T55wit7MiGfAWRkPwjNbJ8N8lG._j2OEvLQtM2lODSmH3ZFP6wWCWpF != 0)
				{
					num4 = 1431951417;
					num5 = 1431951417;
				}
				else
				{
					num4 = 569581876;
					num5 = 569581876;
				}
				num = num4 ^ (int)(num3 * 643690464);
				continue;
			}
			case 0u:
				goto end_IL_00f4;
			case 9u:
				goto IL_013d;
			case 2u:
				return;
			case 3u:
				return;
			default:
				_6T55wit7MiGfAWRkPwjNbJ8N8lG._WaCCr2ToiTDglrrE9z1EKOcLzT3 = true;
				_VQDLuxMbrizDwdFWvZoaPpO7Y0o.Clear();
				_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.Home);
				return;
			}
			_poenyHBGUusBcnNcTFB9MQBV72R.smethod_9(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_8(_6T55wit7MiGfAWRkPwjNbJ8N8lG._4L7hfXrWoDdArQiscG4ukHCV46B), bool_0: true);
			_poenyHBGUusBcnNcTFB9MQBV72R.smethod_10(bool_0: true);
			_6T55wit7MiGfAWRkPwjNbJ8N8lG._3AaEmo54VzWybgrrg7I8Z9JUV1e = bool_0;
			int num6;
			if (!_6T55wit7MiGfAWRkPwjNbJ8N8lG._TZx1AkahTLXoM2XUbm5U8YJOScb)
			{
				num = -1677472329;
				num6 = -1677472329;
			}
			else
			{
				num = -1342490087;
				num6 = -1342490087;
			}
			continue;
			end_IL_00f4:
			break;
		}
		goto IL_00ef;
		IL_00ef:
		num = -2002951924;
		goto IL_00f4;
	}

	public static void _RiDuYMeg3EHnBUteUcAb8VlfQVl()
	{
		if (!_kf3EbE0B70xGe1szklqAZyCqoLj)
		{
			return;
		}
		while (true)
		{
			int num = -1335144660;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB9ACF581u) % 10u)
				{
				case 8u:
					_6T55wit7MiGfAWRkPwjNbJ8N8lG._3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
					num = (int)((num2 * 442365713) ^ 0x20169C70);
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (!_6T55wit7MiGfAWRkPwjNbJ8N8lG._77rSPCEs6VEYjlGrwW0KN0btLEG)
					{
						num5 = 511555887;
						num6 = 511555887;
					}
					else
					{
						num5 = 101928463;
						num6 = 101928463;
					}
					num = num5 ^ (int)(num2 * 471053218);
					continue;
				}
				case 6u:
				{
					int num7;
					int num8;
					if (_6T55wit7MiGfAWRkPwjNbJ8N8lG._j2OEvLQtM2lODSmH3ZFP6wWCWpF != _fFGgY4gvWNcTLSlsfe9k99ctumb.ArmUp)
					{
						num7 = 1048714674;
						num8 = 1048714674;
					}
					else
					{
						num7 = 1655439250;
						num8 = 1655439250;
					}
					num = num7 ^ ((int)num2 * -914351189);
					continue;
				}
				case 3u:
				{
					int num3;
					int num4;
					if (!_6T55wit7MiGfAWRkPwjNbJ8N8lG._TZx1AkahTLXoM2XUbm5U8YJOScb)
					{
						num3 = 1956951838;
						num4 = 1956951838;
					}
					else
					{
						num3 = 1578285929;
						num4 = 1578285929;
					}
					num = num3 ^ (int)(num2 * 2009660865);
					continue;
				}
				case 2u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_9(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_8(_6T55wit7MiGfAWRkPwjNbJ8N8lG._4L7hfXrWoDdArQiscG4ukHCV46B), bool_0: false);
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_10(bool_0: false);
					num = -337404363;
					continue;
				case 1u:
					_6T55wit7MiGfAWRkPwjNbJ8N8lG._j2OEvLQtM2lODSmH3ZFP6wWCWpF = _fFGgY4gvWNcTLSlsfe9k99ctumb.ArmDownRequested;
					_6T55wit7MiGfAWRkPwjNbJ8N8lG._p4cbe03cXPNybrHUo9DHRTp6W7m = true;
					num = -47053279;
					continue;
				default:
					return;
				case 5u:
					break;
				case 4u:
					return;
				case 9u:
					return;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public static void _eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL _VQgRlkt1vazuo2KaxFIrSVwZOpL_0)
	{
		if (_VQgRlkt1vazuo2KaxFIrSVwZOpL_0 != 0)
		{
			goto IL_003c;
		}
		goto IL_0066;
		IL_0066:
		_saaJnL0DI6B89XWRulJZ4KC1I1g = _VQgRlkt1vazuo2KaxFIrSVwZOpL_0;
		int num = 419530984;
		goto IL_0041;
		IL_0041:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x463CA082u) % 5u)
			{
			case 4u:
				_VQDLuxMbrizDwdFWvZoaPpO7Y0o.Push(_saaJnL0DI6B89XWRulJZ4KC1I1g);
				num = ((int)num2 * -112352027) ^ -61812849;
				continue;
			case 1u:
				_6T55wit7MiGfAWRkPwjNbJ8N8lG._Pbt0pgZ2cGZkaxR9cQe0r2v2lVd();
				num = ((int)num2 * -1321930810) ^ -1965943233;
				continue;
			case 0u:
				break;
			case 3u:
				goto IL_0066;
			default:
				_6T55wit7MiGfAWRkPwjNbJ8N8lG._DAsCL6JdGst3kJHpcbztigO3VEV();
				return;
			}
			break;
		}
		goto IL_003c;
		IL_003c:
		num = 858188159;
		goto IL_0041;
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
		while (true)
		{
			int num = -1821136209;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9BC70B69u) % 3u)
				{
				case 1u:
					goto IL_001b;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_001b:
				_6T55wit7MiGfAWRkPwjNbJ8N8lG._Pbt0pgZ2cGZkaxR9cQe0r2v2lVd();
				num = (int)((num2 * 347219076) ^ 0x18E15068);
			}
		}
	}

	private void _Pbt0pgZ2cGZkaxR9cQe0r2v2lVd()
	{
		_flEA1zdf7DHRkPwzrlsWVEAXZiX = false;
		_poenyHBGUusBcnNcTFB9MQBV72R.smethod_1(_6T55wit7MiGfAWRkPwjNbJ8N8lG._hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Swipe", (Action)_aEgXugtdIuFieAwnDhnIlYNEysg);
	}

	private void _iclFNsZuDOZLCNYXakYmA0rt3UU()
	{
		_flEA1zdf7DHRkPwzrlsWVEAXZiX = false;
		while (true)
		{
			int num = -554120840;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF6A6E8FBu) % 3u)
				{
				case 1u:
					goto IL_0009;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0009:
				_poenyHBGUusBcnNcTFB9MQBV72R.smethod_1(_6T55wit7MiGfAWRkPwjNbJ8N8lG._hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Typing", (Action)_aEgXugtdIuFieAwnDhnIlYNEysg);
				num = (int)(num2 * 1190521994) ^ -426169389;
			}
		}
	}

	private void _aEgXugtdIuFieAwnDhnIlYNEysg()
	{
		_poenyHBGUusBcnNcTFB9MQBV72R.smethod_2(_6T55wit7MiGfAWRkPwjNbJ8N8lG._hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Idle", (Action<int>)null);
		while (true)
		{
			int num = -1033014987;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF4469482u) % 3u)
				{
				case 2u:
					goto IL_0018;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0018:
				_flEA1zdf7DHRkPwzrlsWVEAXZiX = true;
				num = (int)((num2 * 856223499) ^ 0x7ADE5C58);
			}
		}
	}

	private void _DAsCL6JdGst3kJHpcbztigO3VEV()
	{
		Control val = default(Control);
		int num;
		switch (_saaJnL0DI6B89XWRulJZ4KC1I1g)
		{
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.Gallery:
			val = (Control)(object)_1Bze6b62yGQDi3JBE0TyQmPGkzU();
			num = -1308461831;
			goto IL_022e;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.Audio:
			goto IL_0092;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.DiaryLoad:
			goto IL_00e8;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.ChatSettings:
			goto IL_00f9;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.ContactsInformationDJ:
			goto IL_011c;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.DiaryMessages:
			goto IL_012d;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.Soundtrack:
			goto IL_013e;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.Diary:
			goto IL_014f;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.DiarySave:
			goto IL_0160;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.DiaryAchievements:
			goto IL_0194;
		default:
			goto IL_01b4;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.Contacts:
			goto IL_01bb;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.ContactsInformation:
			goto IL_01e7;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.DiaryMessagesInformation:
			goto IL_0204;
		case _VQgRlkt1vazuo2KaxFIrSVwZOpL.Power:
			goto IL_02bc;
			IL_022e:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x95952FF6u) % 31u)
				{
				case 30u:
					num = ((int)num2 * -96674882) ^ 0x6E8BAA5D;
					continue;
				case 27u:
					break;
				case 26u:
					num = (int)(num2 * 1412843685) ^ -539531024;
					continue;
				case 25u:
					num = (int)((num2 * 589292634) ^ 0x7424DBD5);
					continue;
				case 24u:
					goto IL_0092;
				case 23u:
					((ActiveList<Control>)(object)_poenyHBGUusBcnNcTFB9MQBV72R.smethod_11(_9GQBAH2pi8Sm6ph1s6InjyQGe6R)).Clear();
					((ActiveList<Control>)(object)_poenyHBGUusBcnNcTFB9MQBV72R.smethod_11(_9GQBAH2pi8Sm6ph1s6InjyQGe6R)).Add(val);
					num = (int)(num2 * 1073813255) ^ -1724425248;
					continue;
				case 22u:
					num = (int)(num2 * 2062630452) ^ -799891241;
					continue;
				case 21u:
					goto IL_00e8;
				case 20u:
					goto IL_00f9;
				case 19u:
					num = (int)(num2 * 2033967612) ^ -178124741;
					continue;
				case 18u:
					goto IL_011c;
				case 17u:
					goto IL_012d;
				case 16u:
					goto IL_013e;
				case 14u:
					goto IL_014f;
				case 13u:
					goto IL_0160;
				case 12u:
					num = (int)((num2 * 323097811) ^ 0x2EA33299);
					continue;
				case 11u:
					_Ldzm1JY9st4tknAhrglOIpwdYhn = false;
					num = -582602706;
					continue;
				case 10u:
					goto IL_0194;
				case 9u:
					num = (int)((num2 * 2035730105) ^ 0x48C829B8);
					continue;
				case 8u:
					goto IL_01b4;
				case 7u:
					goto IL_01bb;
				case 6u:
					num = (int)((num2 * 1725586775) ^ 0x24DE213D);
					continue;
				case 5u:
					num = (int)((num2 * 1163382056) ^ 0x6F1FDF23);
					continue;
				case 4u:
					goto IL_01e7;
				case 3u:
					num = ((int)num2 * -923379678) ^ -1563935667;
					continue;
				case 2u:
					goto IL_0204;
				case 1u:
					num = ((int)num2 * -372300210) ^ 0x59DF076D;
					continue;
				case 0u:
					num = ((int)num2 * -1555675752) ^ -239166429;
					continue;
				default:
					return;
				case 15u:
					goto IL_02bc;
				case 28u:
					_Ldzm1JY9st4tknAhrglOIpwdYhn = true;
					return;
				case 29u:
					return;
				}
				break;
			}
			goto case _VQgRlkt1vazuo2KaxFIrSVwZOpL.Gallery;
			IL_02bc:
			val = (Control)(object)_dT5L6g1CEsgeYg5W9sVqR2trRSK();
			num = -1053185125;
			goto IL_022e;
			IL_0204:
			val = (Control)(object)_yE1MXqtEKITxyL75pITcd8fNpsi();
			num = -2059485440;
			goto IL_022e;
			IL_01e7:
			val = _kcNoqTwN559GGLalkuw5udBAUZB();
			num = -393969573;
			goto IL_022e;
			IL_01bb:
			val = (Control)(object)_NWt4WEiiiqjMHAUuqWscxChtSMd();
			num = -378626663;
			goto IL_022e;
			IL_01b4:
			num = -27321551;
			goto IL_022e;
			IL_0194:
			val = (Control)(object)_jv6KLyNe1t3TATNww1TiWv9ZVLF();
			num = -1092089715;
			goto IL_022e;
			IL_0160:
			val = (Control)(object)_QmCbnBf76ITvR2HA7WYF44qkJWK();
			num = -1358086626;
			goto IL_022e;
			IL_014f:
			val = (Control)(object)_YGPgft9Vo9UMBMfVtN34XoT93HD();
			num = -393969573;
			goto IL_022e;
			IL_013e:
			val = (Control)(object)_hiWNprom67B9EJO4loqBfhvB4hX();
			num = -1580237579;
			goto IL_022e;
			IL_012d:
			val = (Control)(object)_ZAzvI9G8CsjLJ0AWtoSCmHUuR2q();
			num = -1280278461;
			goto IL_022e;
			IL_011c:
			val = _h2ArPDECvhhh0z0Z51CaUxB7rAr();
			num = -1384080725;
			goto IL_022e;
			IL_00f9:
			val = _H2blb6Djx9JemSUBYepwlzNOXxz();
			num = -721726539;
			goto IL_022e;
			IL_00e8:
			val = (Control)(object)_mKzC4RKCG3B1ZBdWwcAp79gd8NaA();
			num = -393969573;
			goto IL_022e;
			IL_0092:
			val = _fM96M1a1ZZUtzPyevCm45mKPeQg();
			num = -570536964;
			goto IL_022e;
		}
	}

	private ListBox _Y29nu3VoVEY6acDadsfRh60BNDh()
	{
		ListBox obj = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_12();
		_poenyHBGUusBcnNcTFB9MQBV72R.smethod_13((Control)(object)obj, (DockStyle)5);
		_poenyHBGUusBcnNcTFB9MQBV72R.smethod_15(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_14(obj), 0.2f);
		_poenyHBGUusBcnNcTFB9MQBV72R.smethod_17((Control)(object)_poenyHBGUusBcnNcTFB9MQBV72R.smethod_16(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_14(obj)), bool_0: false);
		_poenyHBGUusBcnNcTFB9MQBV72R.smethod_17((Control)(object)_poenyHBGUusBcnNcTFB9MQBV72R.smethod_18(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_14(obj)), bool_0: false);
		return obj;
	}

	private ListBox _NWt4WEiiiqjMHAUuqWscxChtSMd()
	{
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected O, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected O, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected O, but got Unknown
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected O, but got Unknown
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected O, but got Unknown
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected O, but got Unknown
		_jacy9UYskskbRRyetoO92L4m4YS CS_0024_003C_003E8__locals0 = new _jacy9UYskskbRRyetoO92L4m4YS();
		CS_0024_003C_003E8__locals0._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = this;
		CustomListBoxItem val2 = default(CustomListBoxItem);
		ImageControl val3 = default(ImageControl);
		Label val4 = default(Label);
		List<string> source = default(List<string>);
		ListBox val = default(ListBox);
		float num6 = default(float);
		_oX8XrNdNse9viFEqFUqJnYYOjaf oX8XrNdNse9viFEqFUqJnYYOjaf = default(_oX8XrNdNse9viFEqFUqJnYYOjaf);
		ImageControl val10 = default(ImageControl);
		Label val5 = default(Label);
		float num9 = default(float);
		float num8 = default(float);
		Rectangle val9 = default(Rectangle);
		float num4 = default(float);
		float num7 = default(float);
		_6OmCduUGKgPqhBnqgfNJUOmDpZW<string, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts> _6OmCduUGKgPqhBnqgfNJUOmDpZW2 = default(_6OmCduUGKgPqhBnqgfNJUOmDpZW<string, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts>);
		_6OmCduUGKgPqhBnqgfNJUOmDpZW<string, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts>[] array2 = default(_6OmCduUGKgPqhBnqgfNJUOmDpZW<string, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts>[]);
		int num3 = default(int);
		_6OmCduUGKgPqhBnqgfNJUOmDpZW<string, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts>[] array = default(_6OmCduUGKgPqhBnqgfNJUOmDpZW<string, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts>[]);
		while (true)
		{
			int num = -318732153;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFE6228E2u) % 24u)
				{
				case 23u:
					((ActiveList<Control>)(object)((Frame)val2).get_Controls()).Add((Control)(object)val3);
					((ActiveList<Control>)(object)((Frame)val2).get_Controls()).Add((Control)(object)val4);
					num = (int)((num2 * 2041616181) ^ 0x13678EAE);
					continue;
				case 22u:
					source = Enum.GetNames(typeof(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts)).Except(new string[1] { "None" }).ToList();
					num = -2080445590;
					continue;
				case 21u:
					val = _Y29nu3VoVEY6acDadsfRh60BNDh();
					CS_0024_003C_003E8__locals0._7FpdmRzPrcoARiGqtJekOfu7KqP = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_19();
					num = (int)((num2 * 83714492) ^ 0x3867FA10);
					continue;
				case 20u:
					num6 = 189.6f;
					num = (int)((num2 * 308200177) ^ 0x4203EE2);
					continue;
				case 19u:
					((ActiveList<Control>)(object)((Frame)oX8XrNdNse9viFEqFUqJnYYOjaf._4wrjSKvuvZUTRPI3prAOEvBGDhD).get_Controls()).Add((Control)(object)val10);
					num = (int)(num2 * 1547319776) ^ -1583847758;
					continue;
				case 18u:
					((ActiveList<Control>)(object)val.get_ItemContainer().get_Controls()).Add((Control)(object)oX8XrNdNse9viFEqFUqJnYYOjaf._4wrjSKvuvZUTRPI3prAOEvBGDhD);
					num = (int)(num2 * 1738096468) ^ -981340237;
					continue;
				case 17u:
				{
					Label val8 = new Label();
					((Control)val8).set_Dock((DockStyle)5);
					val8.set_Text("Club Amorous DJ");
					val8.set_TextAlign((Alignment)4);
					((Control)val8).set_NoEvents(true);
					val4 = val8;
					num = ((int)num2 * -1221240986) ^ -232225841;
					continue;
				}
				case 16u:
					((ActiveList<Control>)(object)((Frame)oX8XrNdNse9viFEqFUqJnYYOjaf._4wrjSKvuvZUTRPI3prAOEvBGDhD).get_Controls()).Add((Control)(object)val5);
					num = (int)(num2 * 1292297055) ^ -2073274144;
					continue;
				case 14u:
				{
					int num10;
					int num11;
					if (_poenyHBGUusBcnNcTFB9MQBV72R.smethod_20(CS_0024_003C_003E8__locals0._7FpdmRzPrcoARiGqtJekOfu7KqP, "DJ") == 20)
					{
						num10 = 1332145128;
						num11 = 1332145128;
					}
					else
					{
						num10 = 503457346;
						num11 = 503457346;
					}
					num = num10 ^ (int)(num2 * 896768817);
					continue;
				}
				case 13u:
				{
					ImageControl obj3 = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_21();
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_13((Control)(object)obj3, (DockStyle)1);
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_22(obj3, "Contact_DJ");
					obj3.set_TextureRect(new Rectangle((int)num9, 0, (int)num6, 158));
					((Control)obj3).set_Size(new Point(60, 50));
					((Control)obj3).set_NoEvents(true);
					val3 = obj3;
					num = (int)(num2 * 2002687703) ^ -1807146608;
					continue;
				}
				case 12u:
					num9 = (268f - num6) / 2f;
					num = ((int)num2 * -938917497) ^ 0x48A1336B;
					continue;
				case 11u:
					num8 = (float)((Rectangle)(ref val9)).get_Height() * num4;
					num7 = ((float)((Rectangle)(ref val9)).get_Width() - num8) / 2f;
					num = (int)(num2 * 538824654) ^ -2049692416;
					continue;
				case 10u:
					_6OmCduUGKgPqhBnqgfNJUOmDpZW2 = array2[num3];
					num = -2118951337;
					continue;
				case 8u:
				{
					ImageControl val11 = new ImageControl();
					((Control)val11).set_Dock((DockStyle)1);
					val11.set_Texture("PhoneScreen");
					val11.set_TextureRect(new Rectangle(((Rectangle)(ref val9)).get_Left() + (int)num7, ((Rectangle)(ref val9)).get_Top(), (int)num8, ((Rectangle)(ref val9)).get_Height()));
					((Control)val11).set_Size(new Point(60, 50));
					((Control)val11).set_NoEvents(true);
					val10 = val11;
					Label val12 = new Label();
					((Control)val12).set_Dock((DockStyle)5);
					val12.set_Text(_6OmCduUGKgPqhBnqgfNJUOmDpZW2.Name);
					val12.set_TextAlign((Alignment)4);
					((Control)val12).set_NoEvents(true);
					val5 = val12;
					_oX8XrNdNse9viFEqFUqJnYYOjaf oX8XrNdNse9viFEqFUqJnYYOjaf2 = oX8XrNdNse9viFEqFUqJnYYOjaf;
					CustomListBoxItem val13 = new CustomListBoxItem();
					((Control)val13).set_Size(new Point(0, 60));
					((Control)val13).set_Padding(new Margin(2));
					val13.set_Value((object)_6OmCduUGKgPqhBnqgfNJUOmDpZW2.Value);
					oX8XrNdNse9viFEqFUqJnYYOjaf2._4wrjSKvuvZUTRPI3prAOEvBGDhD = val13;
					((Control)oX8XrNdNse9viFEqFUqJnYYOjaf._4wrjSKvuvZUTRPI3prAOEvBGDhD).add_MouseClick(new MouseEvent(oX8XrNdNse9viFEqFUqJnYYOjaf._AaTfI7TkG87JNIfFQVbhclh2zPsA));
					num = ((int)num2 * -1408200450) ^ -1595398063;
					continue;
				}
				case 7u:
					((ActiveList<Control>)(object)val.get_ItemContainer().get_Controls()).Add((Control)(object)val2);
					num = ((int)num2 * -1718627631) ^ 0x2308E613;
					continue;
				case 6u:
				{
					int num5;
					if (num3 < array2.Length)
					{
						num = -1908819712;
						num5 = -1908819712;
					}
					else
					{
						num = -1526503339;
						num5 = -1526503339;
					}
					continue;
				}
				case 5u:
					oX8XrNdNse9viFEqFUqJnYYOjaf = new _oX8XrNdNse9viFEqFUqJnYYOjaf();
					oX8XrNdNse9viFEqFUqJnYYOjaf._wr6xcvFOgUbaTATC17S6Y9v3y3S = CS_0024_003C_003E8__locals0;
					val9 = _kALYOlSwbvFyd9uFqFZW8Y2IsnL[_6OmCduUGKgPqhBnqgfNJUOmDpZW2.Value];
					num4 = 1.2f;
					num = (int)((num2 * 1842445277) ^ 0x473D490);
					continue;
				case 4u:
					array2 = array;
					num = (int)(num2 * 450891965) ^ -1215993156;
					continue;
				case 3u:
				{
					CustomListBoxItem val6 = new CustomListBoxItem();
					((Control)val6).set_Size(new Point(0, 60));
					((Control)val6).set_Padding(new Margin(2));
					val2 = val6;
					CustomListBoxItem obj = val2;
					object obj2 = _rm4nO8SKFlFnD1XybaGLNsNLB5F._003C_003E9__42_3;
					if (obj2 == null)
					{
						MouseEvent val7 = delegate
						{
							_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.ContactsInformationDJ);
						};
						obj2 = (object)val7;
						_rm4nO8SKFlFnD1XybaGLNsNLB5F._003C_003E9__42_3 = val7;
					}
					((Control)obj).add_MouseClick((MouseEvent)obj2);
					num = -595630427;
					continue;
				}
				case 2u:
					num3 = 0;
					num = (int)((num2 * 174096438) ^ 0x1298B7F8);
					continue;
				case 1u:
					num3++;
					num = (int)((num2 * 1567038415) ^ 0x6B20F1C3);
					continue;
				case 0u:
					array = (from _6OmCduUGKgPqhBnqgfNJUOmDpZW_0 in source.Select(delegate(string string_0)
						{
							if (Enum.TryParse<_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts>(string_0, out var result))
							{
								while (true)
								{
									int num12 = 1042034699;
									while (true)
									{
										uint num13;
										switch ((num13 = (uint)num12 ^ 0x2FBBC451u) % 5u)
										{
										case 3u:
										{
											int num14;
											int num15;
											if (!_jacy9UYskskbRRyetoO92L4m4YS.smethod_1((Enum)_jacy9UYskskbRRyetoO92L4m4YS.smethod_0(CS_0024_003C_003E8__locals0._7FpdmRzPrcoARiGqtJekOfu7KqP), (Enum)result))
											{
												num14 = 972858041;
												num15 = 972858041;
											}
											else
											{
												num14 = 139789301;
												num15 = 139789301;
											}
											num12 = num14 ^ ((int)num13 * -861980223);
											continue;
										}
										case 4u:
											break;
										case 1u:
											return new _6OmCduUGKgPqhBnqgfNJUOmDpZW<string, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts>(string_0, result);
										case 2u:
											return null;
										default:
											goto end_IL_006d;
										}
										break;
									}
									continue;
									end_IL_006d:
									break;
								}
							}
							return null;
						})
						where _6OmCduUGKgPqhBnqgfNJUOmDpZW_0 != null
						orderby _6OmCduUGKgPqhBnqgfNJUOmDpZW_0.Name
						select _6OmCduUGKgPqhBnqgfNJUOmDpZW_0).ToArray();
					num = -695942898;
					continue;
				case 9u:
					break;
				default:
					return val;
				}
				break;
			}
		}
	}

	private Control _kcNoqTwN559GGLalkuw5udBAUZB()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected O, but got Unknown
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Expected O, but got Unknown
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Expected O, but got Unknown
		//IL_0662: Unknown result type (might be due to invalid IL or missing references)
		//IL_0667: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_067a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Unknown result type (might be due to invalid IL or missing references)
		//IL_0692: Expected O, but got Unknown
		//IL_072a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0734: Expected O, but got Unknown
		//IL_0747: Unknown result type (might be due to invalid IL or missing references)
		//IL_074c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0753: Unknown result type (might be due to invalid IL or missing references)
		//IL_076e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0772: Unknown result type (might be due to invalid IL or missing references)
		//IL_077e: Expected O, but got Unknown
		//IL_0835: Unknown result type (might be due to invalid IL or missing references)
		//IL_0898: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a2: Expected O, but got Unknown
		//IL_08f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0901: Unknown result type (might be due to invalid IL or missing references)
		//IL_090d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0911: Unknown result type (might be due to invalid IL or missing references)
		//IL_091d: Expected O, but got Unknown
		//IL_0998: Unknown result type (might be due to invalid IL or missing references)
		//IL_099d: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c0: Expected O, but got Unknown
		Panel obj = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_23();
		_poenyHBGUusBcnNcTFB9MQBV72R.smethod_13((Control)(object)obj, (DockStyle)5);
		Panel val = obj;
		Button val10 = default(Button);
		Button val15 = default(Button);
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG = default(_opIJo2jLUqdOL5yAFP4yzXce0DG);
		_K3u7ViHsWHD7nMkxlJgXOyDYc0F k3u7ViHsWHD7nMkxlJgXOyDYc0F = default(_K3u7ViHsWHD7nMkxlJgXOyDYc0F);
		Button val8 = default(Button);
		Button val6 = default(Button);
		ImageControl val4 = default(ImageControl);
		Label val9 = default(Label);
		Button val12 = default(Button);
		Button val3 = default(Button);
		while (true)
		{
			int num = 205663769;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7DDFC0DCu) % 61u)
				{
				case 60u:
				{
					Button val13 = new Button();
					((Control)val13).set_Dock((DockStyle)2);
					((Label)val13).set_Text("Extra: Cooking Mini-Game");
					((Control)val13).set_Size(new Point(0, 50));
					val10 = val13;
					num = ((int)num2 * -1866581454) ^ 0x4EA6BD17;
					continue;
				}
				case 59u:
				{
					int num8;
					if (_H6UwM4zjGzglzMY478iBDDvTk6I != _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Lex)
					{
						num = 352558984;
						num8 = 352558984;
					}
					else
					{
						num = 4438793;
						num8 = 4438793;
					}
					continue;
				}
				case 58u:
				{
					Button val14 = new Button();
					((Control)val14).set_Dock((DockStyle)2);
					((Label)val14).set_Text("Extra: Shooting Range");
					((Control)val14).set_Size(new Point(0, 50));
					val15 = val14;
					((Control)val15).add_MouseClick((MouseEvent)delegate
					{
						_RiDuYMeg3EHnBUteUcAb8VlfQVl();
						while (true)
						{
							int num44 = 963737304;
							while (true)
							{
								uint num45;
								switch ((num45 = (uint)num44 ^ 0x6E540526u) % 3u)
								{
								case 1u:
									goto IL_0007;
								default:
									return;
								case 0u:
									break;
								case 2u:
									return;
								}
								break;
								IL_0007:
								_4L7hfXrWoDdArQiscG4ukHCV46B._k9wUPeU1Ga7cygiuGP8TT6aPLWF<PhoneShootingRangeMiniGameScene>();
								num44 = (int)(num45 * 1901507220) ^ -648989614;
							}
						}
					});
					num = (int)((num2 * 754292629) ^ 0x42F1F92A);
					continue;
				}
				case 57u:
				{
					int num40;
					int num41;
					if (opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("LexDate") != 50)
					{
						num40 = 957516790;
						num41 = 957516790;
					}
					else
					{
						num40 = 1683741406;
						num41 = 1683741406;
					}
					num = num40 ^ ((int)num2 * -241715322);
					continue;
				}
				case 56u:
				{
					int num30;
					int num31;
					if (opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("RemyDate") > 20)
					{
						num30 = -1477643547;
						num31 = -1477643547;
					}
					else
					{
						num30 = -98808745;
						num31 = -98808745;
					}
					num = num30 ^ ((int)num2 * -491749913);
					continue;
				}
				case 55u:
					k3u7ViHsWHD7nMkxlJgXOyDYc0F._nc2gJWKJm6yAMtppwpcfigGPFj3 = "LexPostDate";
					num = ((int)num2 * -265978130) ^ -767239042;
					continue;
				case 54u:
					((Control)val10).add_MouseClick((MouseEvent)delegate
					{
						_poenyHBGUusBcnNcTFB9MQBV72R.smethod_42(_4L7hfXrWoDdArQiscG4ukHCV46B, "MiniGameCooking");
						while (true)
						{
							int num46 = -1423211482;
							while (true)
							{
								uint num47;
								switch ((num47 = (uint)num46 ^ 0xB40C3BEDu) % 3u)
								{
								case 2u:
									goto IL_0013;
								default:
									return;
								case 0u:
									break;
								case 1u:
									return;
								}
								break;
								IL_0013:
								_RiDuYMeg3EHnBUteUcAb8VlfQVl();
								num46 = ((int)num47 * -1979497693) ^ -1261130622;
							}
						}
					});
					num = ((int)num2 * -978904434) ^ 0x4D8CE2E4;
					continue;
				case 53u:
					k3u7ViHsWHD7nMkxlJgXOyDYc0F._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = this;
					k3u7ViHsWHD7nMkxlJgXOyDYc0F._nc2gJWKJm6yAMtppwpcfigGPFj3 = null;
					num = ((int)num2 * -1475787866) ^ -911726864;
					continue;
				case 52u:
					((ActiveList<Control>)(object)val.get_Content().get_Controls()).Add((Control)(object)val15);
					num = (int)((num2 * 1398991665) ^ 0x71D3C14D);
					continue;
				case 51u:
				{
					int num34;
					if (_H6UwM4zjGzglzMY478iBDDvTk6I == _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Dustin)
					{
						num = 1632473738;
						num34 = 1632473738;
					}
					else
					{
						num = 1029737944;
						num34 = 1029737944;
					}
					continue;
				}
				case 50u:
					num = ((int)num2 * -1197039769) ^ -1047875745;
					continue;
				case 49u:
					num = ((int)num2 * -1978495564) ^ 0x4A239592;
					continue;
				case 48u:
				{
					int num26;
					int num27;
					if (opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("ZenithDate") != 70)
					{
						num26 = 315625122;
						num27 = 315625122;
					}
					else
					{
						num26 = 2004618286;
						num27 = 2004618286;
					}
					num = num26 ^ (int)(num2 * 489843692);
					continue;
				}
				case 47u:
					num = ((int)num2 * -2106629061) ^ -300570477;
					continue;
				case 46u:
				{
					int num19;
					int num20;
					if (opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("MercyDate") == 60)
					{
						num19 = -351952551;
						num20 = -351952551;
					}
					else
					{
						num19 = -1007958614;
						num20 = -1007958614;
					}
					num = num19 ^ ((int)num2 * -1130052943);
					continue;
				}
				case 45u:
					((Control)val8).add_MouseClick((MouseEvent)delegate
					{
						//IL_0099: Unknown result type (might be due to invalid IL or missing references)
						//IL_011a: Unknown result type (might be due to invalid IL or missing references)
						string string_ = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_77((MemberInfo)_poenyHBGUusBcnNcTFB9MQBV72R.smethod_76((object)_poenyHBGUusBcnNcTFB9MQBV72R.smethod_75(_4L7hfXrWoDdArQiscG4ukHCV46B)));
						string string_2 = default(string);
						while (true)
						{
							int num48 = -1227391788;
							while (true)
							{
								uint num49;
								switch ((num49 = (uint)num48 ^ 0xA21F51B0u) % 11u)
								{
								case 10u:
								{
									int num52;
									int num53;
									if (!_poenyHBGUusBcnNcTFB9MQBV72R.smethod_82(string_, "LivingRoomScene"))
									{
										num52 = -536382399;
										num53 = -536382399;
									}
									else
									{
										num52 = -1845996870;
										num53 = -1845996870;
									}
									num48 = num52 ^ ((int)num49 * -2068476905);
									continue;
								}
								case 9u:
								{
									int num51;
									if (!_poenyHBGUusBcnNcTFB9MQBV72R.smethod_82(string_, "BedroomScene"))
									{
										num48 = -1446054941;
										num51 = -1446054941;
									}
									else
									{
										num48 = -352362210;
										num51 = -352362210;
									}
									continue;
								}
								case 8u:
									_WDhVhBhQHGowaONqV87v7EaCvro(_H6UwM4zjGzglzMY478iBDDvTk6I);
									num48 = -627923288;
									continue;
								case 4u:
									_poenyHBGUusBcnNcTFB9MQBV72R.smethod_81("<i>Reception is really bad at the moment, I should try again when I'm back at home.</i>", "%playername%", Color.get_White());
									num48 = ((int)num49 * -953685960) ^ 0x8E3ADE7;
									continue;
								case 3u:
								{
									int num54;
									int num55;
									if (_poenyHBGUusBcnNcTFB9MQBV72R.smethod_80(string_2, _iVvswmrDLetaWXmgd38sJtDnLs[_H6UwM4zjGzglzMY478iBDDvTk6I]))
									{
										num54 = -608289024;
										num55 = -608289024;
									}
									else
									{
										num54 = -1476349387;
										num55 = -1476349387;
									}
									num48 = num54 ^ (int)(num49 * 825873994);
									continue;
								}
								case 2u:
									_poenyHBGUusBcnNcTFB9MQBV72R.smethod_81(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_37("<i>", _H6UwM4zjGzglzMY478iBDDvTk6I.ToString(), " is kind of... preoccupied right now.</i>"), "%playername%", Color.get_White());
									num48 = ((int)num49 * -921096924) ^ 0xB72AA17;
									continue;
								case 1u:
								{
									_TwlwMC1hhdSzamwGWEBxuUkz1gH twlwMC1hhdSzamwGWEBxuUkz1gH = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_78(_4L7hfXrWoDdArQiscG4ukHCV46B);
									string_2 = ((twlwMC1hhdSzamwGWEBxuUkz1gH != null) ? _poenyHBGUusBcnNcTFB9MQBV72R.smethod_77((MemberInfo)_poenyHBGUusBcnNcTFB9MQBV72R.smethod_79((object)twlwMC1hhdSzamwGWEBxuUkz1gH)) : null);
									int num50;
									if (!_poenyHBGUusBcnNcTFB9MQBV72R.smethod_80(string_, "PlayerSexScene"))
									{
										num48 = -1023079257;
										num50 = -1023079257;
									}
									else
									{
										num48 = -1234268699;
										num50 = -1234268699;
									}
									continue;
								}
								default:
									return;
								case 6u:
									break;
								case 0u:
									return;
								case 5u:
									return;
								case 7u:
									return;
								}
								break;
							}
						}
					});
					((ActiveList<Control>)(object)val.get_Content().get_Controls()).Add((Control)(object)val8);
					num = ((int)num2 * -155554302) ^ 0x1118C0C1;
					continue;
				case 44u:
					opIJo2jLUqdOL5yAFP4yzXce0DG = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_19();
					num = ((int)num2 * -250980110) ^ 0x4BBD0C90;
					continue;
				case 43u:
					k3u7ViHsWHD7nMkxlJgXOyDYc0F._nc2gJWKJm6yAMtppwpcfigGPFj3 = "CobySexscene";
					num = (int)((num2 * 809617180) ^ 0x48DF415A);
					continue;
				case 42u:
					num = (int)(num2 * 1067449588) ^ -667731666;
					continue;
				case 41u:
				{
					int num42;
					int num43;
					if (opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("CobyDate") == 20)
					{
						num42 = -1622769509;
						num43 = -1622769509;
					}
					else
					{
						num42 = -1688094383;
						num43 = -1688094383;
					}
					num = num42 ^ (int)(num2 * 89327366);
					continue;
				}
				case 40u:
					k3u7ViHsWHD7nMkxlJgXOyDYc0F._nc2gJWKJm6yAMtppwpcfigGPFj3 = "SethPostDate";
					num = (int)(num2 * 1378359636) ^ -961584797;
					continue;
				case 39u:
					k3u7ViHsWHD7nMkxlJgXOyDYc0F._nc2gJWKJm6yAMtppwpcfigGPFj3 = "DustinPostDate";
					num = (int)(num2 * 1229705050) ^ -1481146667;
					continue;
				case 38u:
					((ActiveList<Control>)(object)val.get_Content().get_Controls()).Add((Control)(object)val10);
					num = ((int)num2 * -2095241468) ^ 0x3EB5ABD6;
					continue;
				case 37u:
				{
					int num35;
					if (_H6UwM4zjGzglzMY478iBDDvTk6I != _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Remy)
					{
						num = 926261854;
						num35 = 926261854;
					}
					else
					{
						num = 262641235;
						num35 = 262641235;
					}
					continue;
				}
				case 36u:
				{
					int num28;
					if (_H6UwM4zjGzglzMY478iBDDvTk6I == _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Zenith)
					{
						num = 1647920579;
						num28 = 1647920579;
					}
					else
					{
						num = 1474601782;
						num28 = 1474601782;
					}
					continue;
				}
				case 35u:
				{
					int num23;
					int num24;
					if (opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("ZenithDate") <= 20)
					{
						num23 = 1271361936;
						num24 = 1271361936;
					}
					else
					{
						num23 = 229288471;
						num24 = 229288471;
					}
					num = num23 ^ (int)(num2 * 793992041);
					continue;
				}
				case 34u:
				{
					int num17;
					int num18;
					if (opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("SethDate") != 40)
					{
						num17 = -2101580998;
						num18 = -2101580998;
					}
					else
					{
						num17 = -541640540;
						num18 = -541640540;
					}
					num = num17 ^ ((int)num2 * -1844417424);
					continue;
				}
				case 33u:
				{
					int num14;
					if (_H6UwM4zjGzglzMY478iBDDvTk6I != _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Remy)
					{
						num = 1759021729;
						num14 = 1759021729;
					}
					else
					{
						num = 2077355549;
						num14 = 2077355549;
					}
					continue;
				}
				case 32u:
					k3u7ViHsWHD7nMkxlJgXOyDYc0F._nc2gJWKJm6yAMtppwpcfigGPFj3 = "JaxPostDate";
					num = (int)(num2 * 688223946) ^ -219584857;
					continue;
				case 31u:
				{
					int num11;
					if (_H6UwM4zjGzglzMY478iBDDvTk6I == _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Mercy)
					{
						num = 1019721404;
						num11 = 1019721404;
					}
					else
					{
						num = 586505674;
						num11 = 586505674;
					}
					continue;
				}
				case 30u:
				{
					((Control)val6).add_MouseClick((MouseEvent)delegate
					{
						_3AaEmo54VzWybgrrg7I8Z9JUV1e = true;
						_poenyHBGUusBcnNcTFB9MQBV72R.smethod_73(_9GQBAH2pi8Sm6ph1s6InjyQGe6R, _poenyHBGUusBcnNcTFB9MQBV72R.smethod_44("Are you sure you wish to remove {0}? This will reset all progression!", (object)_H6UwM4zjGzglzMY478iBDDvTk6I), new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, 250, (Action<int>)delegate(int int_0)
						{
							if (int_0 == 1)
							{
								goto IL_006f;
							}
							goto IL_009d;
							IL_009d:
							_270ZVixWLhgEiLA6QosapJMyU6h();
							int num56 = -1472990853;
							goto IL_0074;
							IL_0074:
							while (true)
							{
								uint num57;
								switch ((num57 = (uint)num56 ^ 0xDA213B1Bu) % 6u)
								{
								case 5u:
									_poenyHBGUusBcnNcTFB9MQBV72R.smethod_74(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_19(), _H6UwM4zjGzglzMY478iBDDvTk6I);
									num56 = ((int)num57 * -1504968640) ^ -671097885;
									continue;
								case 2u:
									_poenyHBGUusBcnNcTFB9MQBV72R.smethod_45(_9GQBAH2pi8Sm6ph1s6InjyQGe6R, _poenyHBGUusBcnNcTFB9MQBV72R.smethod_44("{0} will be available again after you went home.", (object)_H6UwM4zjGzglzMY478iBDDvTk6I), 250, "OK", (Action)delegate
									{
										_270ZVixWLhgEiLA6QosapJMyU6h();
										_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
									});
									num56 = (int)((num57 * 204193980) ^ 0x6D0E3DB6);
									continue;
								case 0u:
									break;
								case 1u:
									goto IL_009d;
								case 3u:
									return;
								default:
									_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
									return;
								}
								break;
							}
							goto IL_006f;
							IL_006f:
							num56 = -174232024;
							goto IL_0074;
						});
					});
					((ActiveList<Control>)(object)val.get_Content().get_Controls()).Add((Control)(object)val6);
					Button val7 = new Button();
					((Control)val7).set_Dock((DockStyle)2);
					((Label)val7).set_Text("Call");
					((Control)val7).set_Size(new Point(0, 50));
					val8 = val7;
					num = ((int)num2 * -1596962574) ^ -932229052;
					continue;
				}
				case 29u:
					((ActiveList<Control>)(object)val.get_Content().get_Controls()).Add((Control)(object)val4);
					num = (int)((num2 * 190107773) ^ 0x52C78F08);
					continue;
				case 28u:
				{
					int num4;
					int num5;
					if (_H6UwM4zjGzglzMY478iBDDvTk6I == _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Zenith)
					{
						num4 = -842793951;
						num5 = -842793951;
					}
					else
					{
						num4 = -727815851;
						num5 = -727815851;
					}
					num = num4 ^ ((int)num2 * -1656832938);
					continue;
				}
				case 27u:
					k3u7ViHsWHD7nMkxlJgXOyDYc0F._nc2gJWKJm6yAMtppwpcfigGPFj3 = "MercyPostDate";
					num = ((int)num2 * -777372813) ^ 0x4DC2ABE9;
					continue;
				case 26u:
				{
					int num38;
					int num39;
					if (opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("SkyeDate") == 60)
					{
						num38 = 574382742;
						num39 = 574382742;
					}
					else
					{
						num38 = 1198741228;
						num39 = 1198741228;
					}
					num = num38 ^ ((int)num2 * -388392970);
					continue;
				}
				case 24u:
				{
					int num36;
					int num37;
					if (opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("RemyDate") <= 30)
					{
						num36 = 1967021121;
						num37 = 1967021121;
					}
					else
					{
						num36 = 1428511473;
						num37 = 1428511473;
					}
					num = num36 ^ (int)(num2 * 1552445223);
					continue;
				}
				case 23u:
				{
					int num32;
					int num33;
					if (opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("DustinDate") != 70)
					{
						num32 = -1471107078;
						num33 = -1471107078;
					}
					else
					{
						num32 = -100007295;
						num33 = -100007295;
					}
					num = num32 ^ (int)(num2 * 907860147);
					continue;
				}
				case 22u:
				{
					int num29;
					if (k3u7ViHsWHD7nMkxlJgXOyDYc0F._nc2gJWKJm6yAMtppwpcfigGPFj3 == null)
					{
						num = 1786592902;
						num29 = 1786592902;
					}
					else
					{
						num = 1695135934;
						num29 = 1695135934;
					}
					continue;
				}
				case 21u:
				{
					CustomImageControl val16 = new CustomImageControl();
					((Control)val16).set_Dock((DockStyle)2);
					((ImageControl)val16).set_Texture("PhoneScreen");
					((ImageControl)val16).set_TextureRect(_kALYOlSwbvFyd9uFqFZW8Y2IsnL[_H6UwM4zjGzglzMY478iBDDvTk6I]);
					val4 = (ImageControl)val16;
					((ActiveList<Control>)(object)val.get_Content().get_Controls()).Add((Control)(object)val9);
					num = (int)((num2 * 1054146131) ^ 0x3DBAD9B9);
					continue;
				}
				case 20u:
					k3u7ViHsWHD7nMkxlJgXOyDYc0F._nc2gJWKJm6yAMtppwpcfigGPFj3 = "RemyPostDate";
					num = (int)(num2 * 95668514) ^ -1357565809;
					continue;
				case 19u:
				{
					int num25;
					if (_H6UwM4zjGzglzMY478iBDDvTk6I != _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Skye)
					{
						num = 848064544;
						num25 = 848064544;
					}
					else
					{
						num = 1914103694;
						num25 = 1914103694;
					}
					continue;
				}
				case 18u:
					((ActiveList<Control>)(object)val.get_Content().get_Controls()).Add((Control)(object)val12);
					num = ((int)num2 * -198145857) ^ -587807518;
					continue;
				case 17u:
					((Control)val12).add_MouseClick(new MouseEvent(k3u7ViHsWHD7nMkxlJgXOyDYc0F._ScA3V9qpe4YmHu0ns3pGgvmss7D));
					num = (int)(num2 * 628162247) ^ -2004369830;
					continue;
				case 16u:
				{
					Button val11 = new Button();
					((Control)val11).set_Dock((DockStyle)2);
					((Label)val11).set_Text(_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF ? "Extra: Love scene" : "Extra: Sexscene");
					((Control)val11).set_Size(new Point(0, 50));
					val12 = val11;
					num = 425036234;
					continue;
				}
				case 15u:
				{
					int num21;
					int num22;
					if (_H6UwM4zjGzglzMY478iBDDvTk6I != _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Remy)
					{
						num21 = -1305753709;
						num22 = -1305753709;
					}
					else
					{
						num21 = -666738474;
						num22 = -666738474;
					}
					num = num21 ^ (int)(num2 * 54371057);
					continue;
				}
				case 14u:
				{
					int num15;
					int num16;
					if (opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("RemyDate") != 40)
					{
						num15 = 547190670;
						num16 = 547190670;
					}
					else
					{
						num15 = 1507428732;
						num16 = 1507428732;
					}
					num = num15 ^ ((int)num2 * -988473361);
					continue;
				}
				case 13u:
					num = (int)((num2 * 1225138120) ^ 0x13437A5E);
					continue;
				case 12u:
				{
					Label obj2 = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_24();
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_13((Control)(object)obj2, (DockStyle)2);
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_25(obj2, _H6UwM4zjGzglzMY478iBDDvTk6I.ToString());
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_26((Control)(object)obj2, "button");
					((Control)obj2).set_Size(new Point(0, 40));
					((Control)obj2).set_NoEvents(true);
					val9 = obj2;
					num = (int)(num2 * 1070643205) ^ -858419241;
					continue;
				}
				case 11u:
				{
					int num12;
					int num13;
					if (opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("JaxDate") != 40)
					{
						num12 = -2011164427;
						num13 = -2011164427;
					}
					else
					{
						num12 = -1051732685;
						num13 = -1051732685;
					}
					num = num12 ^ ((int)num2 * -1254051610);
					continue;
				}
				case 10u:
					((Control)val3).add_MouseClick((MouseEvent)delegate
					{
						_poenyHBGUusBcnNcTFB9MQBV72R.smethod_42(_4L7hfXrWoDdArQiscG4ukHCV46B, "NudesRemy");
						_RiDuYMeg3EHnBUteUcAb8VlfQVl();
					});
					((ActiveList<Control>)(object)val.get_Content().get_Controls()).Add((Control)(object)val3);
					num = ((int)num2 * -1082231480) ^ 0x69B59C5D;
					continue;
				case 9u:
				{
					int num9;
					int num10;
					if (_H6UwM4zjGzglzMY478iBDDvTk6I != _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Coby)
					{
						num9 = 360165395;
						num10 = 360165395;
					}
					else
					{
						num9 = 619102627;
						num10 = 619102627;
					}
					num = num9 ^ (int)(num2 * 172217299);
					continue;
				}
				case 8u:
				{
					Button val5 = new Button();
					((Control)val5).set_Dock((DockStyle)2);
					((Label)val5).set_Text("Delete contact");
					((Control)val5).set_Size(new Point(0, 50));
					val6 = val5;
					num = ((int)num2 * -284406673) ^ -297361974;
					continue;
				}
				case 7u:
					k3u7ViHsWHD7nMkxlJgXOyDYc0F._nc2gJWKJm6yAMtppwpcfigGPFj3 = "ZenithPostDate";
					num = ((int)num2 * -1594970739) ^ 0x27E23018;
					continue;
				case 5u:
				{
					int num7;
					if (_H6UwM4zjGzglzMY478iBDDvTk6I != _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Jax)
					{
						num = 276846481;
						num7 = 276846481;
					}
					else
					{
						num = 256748506;
						num7 = 256748506;
					}
					continue;
				}
				case 4u:
				{
					int num6;
					if (_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
					{
						num = 803710637;
						num6 = 803710637;
					}
					else
					{
						num = 1192892866;
						num6 = 1192892866;
					}
					continue;
				}
				case 3u:
				{
					Button val2 = new Button();
					((Control)val2).set_Dock((DockStyle)2);
					((Label)val2).set_Text("Extra: Nude pictures");
					((Control)val2).set_Size(new Point(0, 50));
					val3 = val2;
					num = (int)(num2 * 1526469372) ^ -1250356722;
					continue;
				}
				case 2u:
					k3u7ViHsWHD7nMkxlJgXOyDYc0F._nc2gJWKJm6yAMtppwpcfigGPFj3 = "SkyePostDate";
					num = (int)(num2 * 1052413313) ^ -1800626780;
					continue;
				case 1u:
				{
					int num3;
					if (_H6UwM4zjGzglzMY478iBDDvTk6I != _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Seth)
					{
						num = 1913026730;
						num3 = 1913026730;
					}
					else
					{
						num = 1610209059;
						num3 = 1610209059;
					}
					continue;
				}
				case 0u:
					k3u7ViHsWHD7nMkxlJgXOyDYc0F = new _K3u7ViHsWHD7nMkxlJgXOyDYc0F();
					num = 1168384962;
					continue;
				case 6u:
					break;
				default:
					return (Control)(object)val;
				}
				break;
			}
		}
	}

	private Control _h2ArPDECvhhh0z0Z51CaUxB7rAr()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		Panel obj = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_23();
		_poenyHBGUusBcnNcTFB9MQBV72R.smethod_13((Control)(object)obj, (DockStyle)5);
		Panel val = obj;
		ImageControl val5 = default(ImageControl);
		Button val3 = default(Button);
		Label val4 = default(Label);
		while (true)
		{
			int num = 1807329362;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x60651A07u) % 7u)
				{
				case 6u:
				{
					CustomImageControl val6 = new CustomImageControl();
					((Control)val6).set_Dock((DockStyle)2);
					((ImageControl)val6).set_Texture("Contact_DJ");
					((ImageControl)val6).set_TextureRect(new Rectangle(0, 0, 268, 158));
					val5 = (ImageControl)val6;
					num = (int)(num2 * 70838874) ^ -1055093194;
					continue;
				}
				case 5u:
					((Control)val3).add_MouseClick((MouseEvent)delegate
					{
						//IL_0071: Unknown result type (might be due to invalid IL or missing references)
						string string_ = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_77((MemberInfo)_poenyHBGUusBcnNcTFB9MQBV72R.smethod_76((object)_poenyHBGUusBcnNcTFB9MQBV72R.smethod_75(_4L7hfXrWoDdArQiscG4ukHCV46B)));
						if (_poenyHBGUusBcnNcTFB9MQBV72R.smethod_83(string_, "Club"))
						{
							goto IL_003b;
						}
						goto IL_0065;
						IL_0065:
						_poenyHBGUusBcnNcTFB9MQBV72R.smethod_81("<i>Hmm, the operator is telling me: 'The number you are trying to reach is currently unavailable'. I guess the DJ only has his phone enabled during Club hours.</i>", "%playername%", Color.get_White());
						int num3 = 647745293;
						goto IL_0040;
						IL_0040:
						while (true)
						{
							uint num4;
							switch ((num4 = (uint)num3 ^ 0x745D3047u) % 5u)
							{
							case 2u:
								_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.Soundtrack);
								num3 = ((int)num4 * -289905105) ^ 0x44CB0C59;
								continue;
							case 0u:
								break;
							default:
								return;
							case 3u:
								goto IL_0065;
							case 1u:
								return;
							case 4u:
								return;
							}
							break;
						}
						goto IL_003b;
						IL_003b:
						num3 = 1184456034;
						goto IL_0040;
					});
					((ActiveList<Control>)(object)val.get_Content().get_Controls()).Add((Control)(object)val4);
					((ActiveList<Control>)(object)val.get_Content().get_Controls()).Add((Control)(object)val5);
					num = (int)((num2 * 1174301094) ^ 0x7F268444);
					continue;
				case 4u:
					((ActiveList<Control>)(object)val.get_Content().get_Controls()).Add((Control)(object)val3);
					num = (int)(num2 * 1998981840) ^ -324707906;
					continue;
				case 2u:
				{
					Label obj2 = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_24();
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_13((Control)(object)obj2, (DockStyle)2);
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_25(obj2, "Club Amorous DJ");
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_26((Control)(object)obj2, "button");
					((Control)obj2).set_Size(new Point(0, 40));
					((Control)obj2).set_NoEvents(true);
					val4 = obj2;
					num = ((int)num2 * -146741702) ^ -482505182;
					continue;
				}
				case 0u:
				{
					Button val2 = new Button();
					((Control)val2).set_Dock((DockStyle)2);
					((Label)val2).set_Text("Request a song");
					((Control)val2).set_Size(new Point(0, 50));
					val3 = val2;
					num = (int)((num2 * 677424184) ^ 0x53F6C141);
					continue;
				}
				case 3u:
					break;
				default:
					return (Control)(object)val;
				}
				break;
			}
		}
	}

	private ListBox _hiWNprom67B9EJO4loqBfhvB4hX()
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		ListBox val = _Y29nu3VoVEY6acDadsfRh60BNDh();
		List<_KZ7hNP1K5E99Xfup1lTZ9UDrxPE._vNekDVpW2fr7UkjA16E9ifFmD9s> list = _KZ7hNP1K5E99Xfup1lTZ9UDrxPE._LUJAgYjQ8oEpFgPKC5CzY9Ne5ju.OrderBy((_KZ7hNP1K5E99Xfup1lTZ9UDrxPE._vNekDVpW2fr7UkjA16E9ifFmD9s _vNekDVpW2fr7UkjA16E9ifFmD9s_0) => _vNekDVpW2fr7UkjA16E9ifFmD9s_0._D5QiLGGNtfoCEnZIUPvH4OKqUabA).ToList();
		using List<_KZ7hNP1K5E99Xfup1lTZ9UDrxPE._vNekDVpW2fr7UkjA16E9ifFmD9s>.Enumerator enumerator = list.GetEnumerator();
		CustomListBoxItem val2 = default(CustomListBoxItem);
		_tdcogRALfEB0rsQ5m98f4c9BTIO tdcogRALfEB0rsQ5m98f4c9BTIO = default(_tdcogRALfEB0rsQ5m98f4c9BTIO);
		_KZ7hNP1K5E99Xfup1lTZ9UDrxPE._vNekDVpW2fr7UkjA16E9ifFmD9s current = default(_KZ7hNP1K5E99Xfup1lTZ9UDrxPE._vNekDVpW2fr7UkjA16E9ifFmD9s);
		while (true)
		{
			int num;
			int num2;
			if (enumerator.MoveNext())
			{
				num = -383775729;
				num2 = -383775729;
			}
			else
			{
				num = -443889590;
				num2 = -443889590;
			}
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num ^ 0xD2C74B24u) % 8u)
				{
				case 5u:
					((Control)val2).add_MouseClick(new MouseEvent(tdcogRALfEB0rsQ5m98f4c9BTIO._XSAFkGFT0TzJpemKpRDtuTVce3));
					((ActiveList<Control>)(object)val.get_ItemContainer().get_Controls()).Add((Control)(object)val2);
					num = (int)((num3 * 1525405528) ^ 0x406FDDAB);
					continue;
				case 4u:
					tdcogRALfEB0rsQ5m98f4c9BTIO._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = this;
					num = (int)((num3 * 765620820) ^ 0x24BEDDD5);
					continue;
				case 3u:
					current = enumerator.Current;
					tdcogRALfEB0rsQ5m98f4c9BTIO = new _tdcogRALfEB0rsQ5m98f4c9BTIO();
					num = -2016878320;
					continue;
				case 2u:
				{
					CustomListBoxItem obj = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_27();
					((Control)obj).set_Size(new Point(0, 90));
					val2 = obj;
					Label val3 = new Label();
					((Control)val3).set_Dock((DockStyle)2);
					((Control)val3).set_Size(new Point(0, 50));
					val3.set_Text("\"" + current._D5QiLGGNtfoCEnZIUPvH4OKqUabA + "\"");
					val3.set_TextAlign((Alignment)4);
					val3.set_TextColor(ColorInt.RGB(255, 255, 0));
					val3.set_TextWrap(true);
					val3.set_UseTextColor(true);
					((Control)val3).set_NoEvents(true);
					Label val4 = val3;
					Label val5 = new Label();
					((Control)val5).set_Dock((DockStyle)2);
					((Control)val5).set_Size(new Point(0, 40));
					val5.set_Text("by " + current._ynar3ZAutlIbbTWMBGvo1mdRNYz);
					val5.set_TextAlign((Alignment)4);
					((Control)val5).set_NoEvents(true);
					Label val6 = val5;
					((ActiveList<Control>)(object)((Frame)val2).get_Controls()).Add((Control)(object)val4);
					((ActiveList<Control>)(object)((Frame)val2).get_Controls()).Add((Control)(object)val6);
					num = ((int)num3 * -1751837674) ^ -302808163;
					continue;
				}
				case 1u:
					tdcogRALfEB0rsQ5m98f4c9BTIO._a5X3xjbmM60JVR5AMk4qrTqgyJm = current;
					num = ((int)num3 * -352611366) ^ 0x34FC206C;
					continue;
				case 0u:
					num = -383775729;
					continue;
				case 7u:
					break;
				default:
					return val;
				case 6u:
					return val;
				}
				break;
			}
		}
	}

	private ListBox _YGPgft9Vo9UMBMfVtN34XoT93HD()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected O, but got Unknown
		ListBox val = _Y29nu3VoVEY6acDadsfRh60BNDh();
		ListBoxItem val13 = default(ListBoxItem);
		ListBoxItem val4 = default(ListBoxItem);
		ListBoxItem val7 = default(ListBoxItem);
		ListBoxItem val11 = default(ListBoxItem);
		ListBoxItem val2 = default(ListBoxItem);
		while (true)
		{
			int num = -455518313;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCA1B5C54u) % 15u)
				{
				case 13u:
					((Control)val13).add_MouseClick((MouseEvent)delegate
					{
						_poenyHBGUusBcnNcTFB9MQBV72R.smethod_84(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_6(_4L7hfXrWoDdArQiscG4ukHCV46B));
					});
					num = (int)(num2 * 109292091) ^ -584939160;
					continue;
				case 12u:
					((ActiveList<ListBoxItem>)(object)val.get_Items()).Add(val4);
					num = -1545239564;
					continue;
				case 11u:
				{
					ListBoxItem obj3 = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_28();
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_25((Label)(object)obj3, "Messages");
					((Control)obj3).set_Size(new Point(0, 50));
					val7 = obj3;
					ListBoxItem obj4 = val7;
					object obj5 = _rm4nO8SKFlFnD1XybaGLNsNLB5F._003C_003E9__46_0;
					if (obj5 == null)
					{
						MouseEvent val8 = delegate
						{
							_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.DiaryMessages);
						};
						obj5 = (object)val8;
						_rm4nO8SKFlFnD1XybaGLNsNLB5F._003C_003E9__46_0 = val8;
					}
					((Control)obj4).add_MouseClick((MouseEvent)obj5);
					num = -1096996435;
					continue;
				}
				case 10u:
					((ActiveList<ListBoxItem>)(object)val.get_Items()).Add(val13);
					num = (int)(num2 * 621879899) ^ -798857070;
					continue;
				case 9u:
				{
					ListBoxItem obj6 = val4;
					object obj7 = _rm4nO8SKFlFnD1XybaGLNsNLB5F._003C_003E9__46_1;
					if (obj7 == null)
					{
						MouseEvent val9 = delegate
						{
							_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.DiaryAchievements);
						};
						obj7 = (object)val9;
						_rm4nO8SKFlFnD1XybaGLNsNLB5F._003C_003E9__46_1 = val9;
					}
					((Control)obj6).add_MouseClick((MouseEvent)obj7);
					ListBoxItem val10 = new ListBoxItem();
					((Label)val10).set_Text("Save");
					((Control)val10).set_Size(new Point(0, 50));
					val11 = val10;
					ListBoxItem obj8 = val11;
					object obj9 = _rm4nO8SKFlFnD1XybaGLNsNLB5F._003C_003E9__46_2;
					if (obj9 == null)
					{
						MouseEvent val12 = delegate
						{
							_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.DiarySave);
						};
						obj9 = (object)val12;
						_rm4nO8SKFlFnD1XybaGLNsNLB5F._003C_003E9__46_2 = val12;
					}
					((Control)obj8).add_MouseClick((MouseEvent)obj9);
					num = -1591251604;
					continue;
				}
				case 8u:
				{
					ListBoxItem val14 = new ListBoxItem();
					((Label)val14).set_Text("Steam Achievements");
					((Control)val14).set_Size(new Point(0, 50));
					val13 = val14;
					num = ((int)num2 * -1731765626) ^ 0x6D808009;
					continue;
				}
				case 7u:
					((ActiveList<ListBoxItem>)(object)val.get_Items()).Add(val11);
					num = (int)(num2 * 646566407) ^ -2092445417;
					continue;
				case 5u:
					((ActiveList<ListBoxItem>)(object)val.get_Items()).Add(val7);
					num = ((int)num2 * -1843243632) ^ 0x28983AAB;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!_4L7hfXrWoDdArQiscG4ukHCV46B._aJh9CibG5YKhkExxgRyVopdfSeJ._J5VHNpAqpO7aNRC9sbWCZTOF7XS)
					{
						num3 = 233655666;
						num4 = 233655666;
					}
					else
					{
						num3 = 1022746659;
						num4 = 1022746659;
					}
					num = num3 ^ (int)(num2 * 1095247443);
					continue;
				}
				case 3u:
				{
					ListBoxItem obj = val2;
					object obj2 = _rm4nO8SKFlFnD1XybaGLNsNLB5F._003C_003E9__46_3;
					if (obj2 == null)
					{
						MouseEvent val6 = delegate
						{
							_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.DiaryLoad);
						};
						obj2 = (object)val6;
						_rm4nO8SKFlFnD1XybaGLNsNLB5F._003C_003E9__46_3 = val6;
					}
					((Control)obj).add_MouseClick((MouseEvent)obj2);
					num = -694602851;
					continue;
				}
				case 2u:
				{
					ListBoxItem val5 = new ListBoxItem();
					((Label)val5).set_Text("Load");
					((Control)val5).set_Size(new Point(0, 50));
					val2 = val5;
					num = (int)((num2 * 400213404) ^ 0x323B9BC9);
					continue;
				}
				case 1u:
				{
					ListBoxItem val3 = new ListBoxItem();
					((Label)val3).set_Text("Achievements");
					((Control)val3).set_Size(new Point(0, 50));
					val4 = val3;
					num = (int)(num2 * 438264422) ^ -1140545432;
					continue;
				}
				case 0u:
					((ActiveList<ListBoxItem>)(object)val.get_Items()).Add(val2);
					num = (int)(num2 * 177472605) ^ -1006015731;
					continue;
				case 6u:
					break;
				default:
					return val;
				}
				break;
			}
		}
	}

	private ListBox _ZAzvI9G8CsjLJ0AWtoSCmHUuR2q()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected O, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		ListBox val = _Y29nu3VoVEY6acDadsfRh60BNDh();
		ListBoxItem val8 = default(ListBoxItem);
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG = default(_opIJo2jLUqdOL5yAFP4yzXce0DG);
		CustomListBoxItem val2 = default(CustomListBoxItem);
		Label val6 = default(Label);
		_FnNGEJUaoVFTsE2HNBVI37kl4xb fnNGEJUaoVFTsE2HNBVI37kl4xb = default(_FnNGEJUaoVFTsE2HNBVI37kl4xb);
		ImageControl val3 = default(ImageControl);
		while (true)
		{
			int num = 741622124;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2B8EBABFu) % 7u)
				{
				case 6u:
				{
					ListBoxItem obj = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_28();
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_25((Label)(object)obj, "There are no messages yet!");
					((Control)obj).set_Size(new Point(0, 50));
					val8 = obj;
					num = (int)((num2 * 793398456) ^ 0x67172064);
					continue;
				}
				case 5u:
					opIJo2jLUqdOL5yAFP4yzXce0DG = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_19();
					num = (int)(num2 * 61416378) ^ -1883533190;
					continue;
				case 3u:
				{
					int num6;
					int num7;
					if (_poenyHBGUusBcnNcTFB9MQBV72R.smethod_29(opIJo2jLUqdOL5yAFP4yzXce0DG).Count != 0)
					{
						num6 = -184457310;
						num7 = -184457310;
					}
					else
					{
						num6 = -661914458;
						num7 = -661914458;
					}
					num = num6 ^ ((int)num2 * -1093923792);
					continue;
				}
				case 1u:
					((ActiveList<ListBoxItem>)(object)val.get_Items()).Add(val8);
					num = (int)(num2 * 241143904) ^ -165162776;
					continue;
				case 0u:
					break;
				default:
				{
					IEnumerator<_iDN1IKOu3e1uADYzeMEUon5D9fg> enumerator = opIJo2jLUqdOL5yAFP4yzXce0DG._7u6aevGWBE7ABqrBXoaPTkywcVo.OrderByDescending((_iDN1IKOu3e1uADYzeMEUon5D9fg _iDN1IKOu3e1uADYzeMEUon5D9fg_0) => _rm4nO8SKFlFnD1XybaGLNsNLB5F.smethod_0(_iDN1IKOu3e1uADYzeMEUon5D9fg_0)).GetEnumerator();
					try
					{
						while (true)
						{
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 1745458811;
								num4 = 1745458811;
							}
							else
							{
								num3 = 1145331203;
								num4 = 1145331203;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x2B8EBABFu) % 10u)
								{
								case 9u:
									num3 = 1745458811;
									continue;
								case 7u:
									((ActiveList<Control>)(object)((Frame)val2).get_Controls()).Add((Control)(object)val6);
									num3 = ((int)num2 * -1741449969) ^ -307615739;
									continue;
								case 6u:
								{
									CustomListBoxItem val7 = new CustomListBoxItem();
									((Control)val7).set_Size(new Point(0, 60));
									((Control)val7).set_Padding(new Margin(2));
									val2 = val7;
									((Control)val2).add_MouseClick(new MouseEvent(fnNGEJUaoVFTsE2HNBVI37kl4xb._bjcbD5NLVYptjAIHRIrhD7CMa6N));
									num3 = (int)(num2 * 606051817) ^ -1879314291;
									continue;
								}
								case 5u:
								{
									Label val5 = new Label();
									((Control)val5).set_Dock((DockStyle)5);
									val5.set_Text(fnNGEJUaoVFTsE2HNBVI37kl4xb._qsRYa7wg9K5fRrgfqdfMwLILTrbA._D5QiLGGNtfoCEnZIUPvH4OKqUabA + "\r\n" + fnNGEJUaoVFTsE2HNBVI37kl4xb._qsRYa7wg9K5fRrgfqdfMwLILTrbA._QkxGXtWLzE0Z8JKyKkMiiph9giD.ToShortDateString());
									val5.set_TextAlign((Alignment)3);
									((Control)val5).set_Margin(new Margin(10, 0, 10, 0));
									val5.set_AutoEllipsis(true);
									val5.set_TextWrap(true);
									((Control)val5).set_NoEvents(true);
									val6 = val5;
									num3 = ((int)num2 * -147009839) ^ 0xA3FBD6;
									continue;
								}
								case 3u:
									((ActiveList<Control>)(object)val.get_ItemContainer().get_Controls()).Add((Control)(object)val2);
									num3 = ((int)num2 * -2138149726) ^ 0x4470F95;
									continue;
								case 2u:
									fnNGEJUaoVFTsE2HNBVI37kl4xb = new _FnNGEJUaoVFTsE2HNBVI37kl4xb();
									fnNGEJUaoVFTsE2HNBVI37kl4xb._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = this;
									fnNGEJUaoVFTsE2HNBVI37kl4xb._qsRYa7wg9K5fRrgfqdfMwLILTrbA = enumerator.Current;
									num3 = 662316948;
									continue;
								case 1u:
								{
									ImageControl val4 = new ImageControl();
									((Control)val4).set_Dock((DockStyle)1);
									val4.set_Texture(fnNGEJUaoVFTsE2HNBVI37kl4xb._qsRYa7wg9K5fRrgfqdfMwLILTrbA._dFaIUhufvE2Ld5IjNEwmPAqqraj);
									((Control)val4).set_Size(new Point(60, 50));
									((Control)val4).set_NoEvents(true);
									val3 = val4;
									num3 = (int)((num2 * 2109732130) ^ 0x1BD60BC6);
									continue;
								}
								case 0u:
									((ActiveList<Control>)(object)((Frame)val2).get_Controls()).Add((Control)(object)val3);
									num3 = ((int)num2 * -658267987) ^ -1774260166;
									continue;
								case 8u:
									break;
								default:
									return val;
								case 4u:
									return val;
								}
								break;
							}
						}
					}
					finally
					{
						if (enumerator != null)
						{
							while (true)
							{
								IL_0343:
								int num5 = 1070033535;
								while (true)
								{
									switch ((num2 = (uint)num5 ^ 0x2B8EBABFu) % 3u)
									{
									case 1u:
										goto IL_0311;
									default:
										goto end_IL_0325;
									case 2u:
										break;
									case 0u:
										goto end_IL_0325;
									}
									goto IL_0343;
									IL_0311:
									enumerator.Dispose();
									num5 = (int)(num2 * 1239442766) ^ -1378844376;
									continue;
									end_IL_0325:
									break;
								}
								break;
							}
						}
					}
				}
				case 4u:
					return val;
				}
				break;
			}
		}
	}

	private ListBox _jv6KLyNe1t3TATNww1TiWv9ZVLF()
	{
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		ListBox val = _Y29nu3VoVEY6acDadsfRh60BNDh();
		CustomListBoxItem val6 = default(CustomListBoxItem);
		ImageControl val2 = default(ImageControl);
		Label val4 = default(Label);
		_bm5ybW5ND5sDF6bvP0sbYyOpvP._eT2GJReQj8Acaq2A0H0eUir97Qf current = default(_bm5ybW5ND5sDF6bvP0sbYyOpvP._eT2GJReQj8Acaq2A0H0eUir97Qf);
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG = default(_opIJo2jLUqdOL5yAFP4yzXce0DG);
		while (true)
		{
			int num = -2107772653;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAC581D83u) % 3u)
				{
				case 2u:
					goto IL_0009;
				case 0u:
					break;
				default:
				{
					using List<_bm5ybW5ND5sDF6bvP0sbYyOpvP._eT2GJReQj8Acaq2A0H0eUir97Qf>.Enumerator enumerator = _bm5ybW5ND5sDF6bvP0sbYyOpvP._cifgh151BUWCIJWJPcakKQ2lWGB.GetEnumerator();
					while (true)
					{
						int num3;
						int num4;
						if (!enumerator.MoveNext())
						{
							num3 = -1257581016;
							num4 = -1257581016;
						}
						else
						{
							num3 = -1084429249;
							num4 = -1084429249;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0xAC581D83u) % 6u)
							{
							case 5u:
								((ActiveList<Control>)(object)((Frame)val6).get_Controls()).Add((Control)(object)val2);
								((ActiveList<Control>)(object)((Frame)val6).get_Controls()).Add((Control)(object)val4);
								((ActiveList<Control>)(object)val.get_ItemContainer().get_Controls()).Add((Control)(object)val6);
								num3 = (int)(num2 * 1178503104) ^ -326995654;
								continue;
							case 4u:
							{
								Label val3 = new Label();
								((Control)val3).set_Dock((DockStyle)5);
								val3.set_Text(current._D5QiLGGNtfoCEnZIUPvH4OKqUabA);
								val3.set_TextAlign((Alignment)3);
								((Control)val3).set_Margin(new Margin(10, 0, 10, 0));
								val3.set_AutoEllipsis(true);
								val3.set_TextWrap(true);
								val4 = val3;
								CustomListBoxItem val5 = new CustomListBoxItem();
								((Control)val5).set_Size(new Point(0, 60));
								((Control)val5).set_Padding(new Margin(2));
								((Control)val5).set_NoEvents(true);
								((Control)val5).set_Opacity(opIJo2jLUqdOL5yAFP4yzXce0DG._Oms9lumBodLGrGZ09YJaEuzmlAf(current._qXE0hlPdNyl0lTUyddbAS1PZhVV) ? 1f : 0.5f);
								val6 = val5;
								num3 = -205741438;
								continue;
							}
							case 2u:
							{
								current = enumerator.Current;
								ImageControl obj = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_21();
								_poenyHBGUusBcnNcTFB9MQBV72R.smethod_13((Control)(object)obj, (DockStyle)1);
								_poenyHBGUusBcnNcTFB9MQBV72R.smethod_22(obj, current._dFaIUhufvE2Ld5IjNEwmPAqqraj);
								((Control)obj).set_Size(new Point(60, 50));
								val2 = obj;
								num3 = -1520356921;
								continue;
							}
							case 0u:
								num3 = -1084429249;
								continue;
							case 3u:
								break;
							default:
								return val;
							case 1u:
								return val;
							}
							break;
						}
					}
				}
				}
				break;
				IL_0009:
				opIJo2jLUqdOL5yAFP4yzXce0DG = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_19();
				num = ((int)num2 * -231332122) ^ -1309308174;
			}
		}
	}

	private Panel _yE1MXqtEKITxyL75pITcd8fNpsi()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected O, but got Unknown
		Panel obj = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_23();
		_poenyHBGUusBcnNcTFB9MQBV72R.smethod_13((Control)(object)obj, (DockStyle)5);
		Panel val = obj;
		ImageControl obj2 = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_21();
		_poenyHBGUusBcnNcTFB9MQBV72R.smethod_13((Control)(object)obj2, (DockStyle)1);
		_poenyHBGUusBcnNcTFB9MQBV72R.smethod_22(obj2, _poenyHBGUusBcnNcTFB9MQBV72R.smethod_30(_ERdtO3cV05TBYFV0mT86wv01GJf));
		((Control)obj2).set_Size(new Point(60, 50));
		ImageControl val2 = obj2;
		Label val9 = default(Label);
		Label val7 = default(Label);
		Panel val5 = default(Panel);
		Button val3 = default(Button);
		while (true)
		{
			int num = -263559448;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA9368546u) % 8u)
				{
				case 7u:
					((ActiveList<Control>)(object)val.get_Content().get_Controls()).Add((Control)(object)val9);
					num = ((int)num2 * -41524856) ^ 0x22562B0F;
					continue;
				case 6u:
				{
					Label val10 = new Label();
					((Control)val10).set_Dock((DockStyle)5);
					val10.set_Text(_ERdtO3cV05TBYFV0mT86wv01GJf._D5QiLGGNtfoCEnZIUPvH4OKqUabA + "\r\n" + _ERdtO3cV05TBYFV0mT86wv01GJf._QkxGXtWLzE0Z8JKyKkMiiph9giD.ToShortDateString());
					val10.set_TextAlign((Alignment)3);
					((Control)val10).set_Margin(new Margin(10, 0, 10, 0));
					val10.set_AutoEllipsis(true);
					val10.set_TextWrap(true);
					val7 = val10;
					num = (int)(num2 * 208641463) ^ -256163641;
					continue;
				}
				case 4u:
				{
					((ActiveList<Control>)(object)val5.get_Content().get_Controls()).Add((Control)(object)val2);
					((ActiveList<Control>)(object)val5.get_Content().get_Controls()).Add((Control)(object)val7);
					Label val8 = new Label();
					((Control)val8).set_Dock((DockStyle)2);
					val8.set_Text(_ERdtO3cV05TBYFV0mT86wv01GJf._NvMJ5jDaeRR7HysERrVDtSlxaI5);
					((Control)val8).set_Margin(new Margin(10));
					val8.set_TextAlign((Alignment)4);
					((Control)val8).set_AutoSize((AutoSize)2);
					val8.set_TextWrap(true);
					((Control)val8).set_NoEvents(true);
					val9 = val8;
					num = ((int)num2 * -792023204) ^ 0x1242D26;
					continue;
				}
				case 3u:
				{
					Panel val6 = new Panel();
					((Control)val6).set_Dock((DockStyle)2);
					((Control)val6).set_Size(new Point(0, 60));
					((Control)val6).set_Padding(new Margin(2));
					((Control)val6).set_Style("button");
					((Control)val6).set_NoEvents(true);
					val5 = val6;
					num = ((int)num2 * -1186841308) ^ -1067010746;
					continue;
				}
				case 2u:
					((Control)val3).add_MouseClick((MouseEvent)delegate
					{
						_3AaEmo54VzWybgrrg7I8Z9JUV1e = true;
						_poenyHBGUusBcnNcTFB9MQBV72R.smethod_73(_9GQBAH2pi8Sm6ph1s6InjyQGe6R, "Are you sure you wish to remove this message?", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, 250, (Action<int>)delegate(int int_0)
						{
							if (int_0 == 1)
							{
								goto IL_0048;
							}
							goto IL_0072;
							IL_0072:
							_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
							int num3 = 2074080370;
							goto IL_004d;
							IL_004d:
							while (true)
							{
								uint num4;
								switch ((num4 = (uint)num3 ^ 0xBCE576Du) % 5u)
								{
								case 4u:
									_270ZVixWLhgEiLA6QosapJMyU6h();
									num3 = (int)(num4 * 504063370) ^ -2031938344;
									continue;
								case 3u:
								{
									_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG_ = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_19();
									_poenyHBGUusBcnNcTFB9MQBV72R.smethod_29(opIJo2jLUqdOL5yAFP4yzXce0DG_).Remove(_ERdtO3cV05TBYFV0mT86wv01GJf);
									_ERdtO3cV05TBYFV0mT86wv01GJf = null;
									num3 = (int)((num4 * 2056145342) ^ 0x16E92230);
									continue;
								}
								case 0u:
									break;
								default:
									return;
								case 1u:
									goto IL_0072;
								case 2u:
									return;
								}
								break;
							}
							goto IL_0048;
							IL_0048:
							num3 = 204380412;
							goto IL_004d;
						});
					});
					((ActiveList<Control>)(object)val.get_Content().get_Controls()).Add((Control)(object)val5);
					num = (int)(num2 * 1401278417) ^ -2032730037;
					continue;
				case 0u:
				{
					Button val4 = new Button();
					((Control)val4).set_Dock((DockStyle)2);
					((Label)val4).set_Text("Delete message");
					((Control)val4).set_Size(new Point(0, 50));
					val3 = val4;
					num = ((int)num2 * -94919089) ^ 0x46898834;
					continue;
				}
				case 5u:
					break;
				default:
					((ActiveList<Control>)(object)val.get_Content().get_Controls()).Add((Control)(object)val3);
					return val;
				}
				break;
			}
		}
	}

	private ListBox _QmCbnBf76ITvR2HA7WYF44qkJWK()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		ListBox val = _Y29nu3VoVEY6acDadsfRh60BNDh();
		List<_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p> list = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_31(bool_0: true);
		using List<_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p>.Enumerator enumerator = list.GetEnumerator();
		ListBoxItem val2 = default(ListBoxItem);
		_7bXnkUo5ETqYLrtdisr6hKFAP6p _7bXnkUo5ETqYLrtdisr6hKFAP6p = default(_7bXnkUo5ETqYLrtdisr6hKFAP6p);
		_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p current = default(_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p);
		string string_ = default(string);
		int num4 = default(int);
		string string_2 = default(string);
		while (true)
		{
			int num;
			int num2;
			if (!enumerator.MoveNext())
			{
				num = -1927863358;
				num2 = -1927863358;
			}
			else
			{
				num = -489767193;
				num2 = -489767193;
			}
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num ^ 0xD481FA80u) % 11u)
				{
				case 10u:
					((Control)val2).add_MouseClick(new MouseEvent(_7bXnkUo5ETqYLrtdisr6hKFAP6p._rweHC7vksYEfsLFnAIcms2JNpEP));
					((ActiveList<ListBoxItem>)(object)val.get_Items()).Add(val2);
					num = ((int)num3 * -1807767244) ^ -1913275357;
					continue;
				case 9u:
					_7bXnkUo5ETqYLrtdisr6hKFAP6p._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = this;
					num = ((int)num3 * -599576664) ^ 0x756AA90A;
					continue;
				case 8u:
					_7bXnkUo5ETqYLrtdisr6hKFAP6p._7OcRfli7CrlI9YYUDJj3j5nDI9k = current;
					num = (int)((num3 * 1770731521) ^ 0x1D969EE9);
					continue;
				case 7u:
					string_ = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_35(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_34(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_32(current), 0, num4));
					string_2 = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_35(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_36(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_32(current), num4 + 1));
					num = (int)(num3 * 1140000740) ^ -421794072;
					continue;
				case 6u:
				{
					ListBoxItem obj = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_28();
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_25((Label)(object)obj, _poenyHBGUusBcnNcTFB9MQBV72R.smethod_37(string_, "\r\n", string_2));
					((Control)obj).set_Size(new Point(0, 50));
					val2 = obj;
					num = ((int)num3 * -2144537798) ^ 0x62FDC84F;
					continue;
				}
				case 3u:
					_7bXnkUo5ETqYLrtdisr6hKFAP6p = new _7bXnkUo5ETqYLrtdisr6hKFAP6p();
					num = ((int)num3 * -2105195319) ^ 0x365B64F2;
					continue;
				case 2u:
					num4 = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_33(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_32(current), '-');
					num = ((int)num3 * -777261918) ^ -1649180278;
					continue;
				case 1u:
					current = enumerator.Current;
					num = -1550919702;
					continue;
				case 0u:
					num = -489767193;
					continue;
				case 5u:
					break;
				default:
					return val;
				case 4u:
					return val;
				}
				break;
			}
		}
	}

	private ListBox _mKzC4RKCG3B1ZBdWwcAp79gd8NaA()
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		ListBox val = _Y29nu3VoVEY6acDadsfRh60BNDh();
		List<_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p> list = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_31(bool_0: false);
		using List<_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p>.Enumerator enumerator = list.GetEnumerator();
		string string_ = default(string);
		_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p current = default(_DW9IcpdMEINZmuzfrqmwsduBGih._3CCr8Bt1rkuzt0M6gYLbceJGV0p);
		int num4 = default(int);
		string string_2 = default(string);
		_2GLJdEpKkJ7x72M9J1r6gZaf9yp _2GLJdEpKkJ7x72M9J1r6gZaf9yp = default(_2GLJdEpKkJ7x72M9J1r6gZaf9yp);
		ListBoxItem val2 = default(ListBoxItem);
		while (true)
		{
			int num;
			int num2;
			if (!enumerator.MoveNext())
			{
				num = -1156592470;
				num2 = -1156592470;
			}
			else
			{
				num = -1363170203;
				num2 = -1363170203;
			}
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num ^ 0xF65FC307u) % 10u)
				{
				case 9u:
					string_ = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_35(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_34(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_32(current), 0, num4));
					string_2 = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_35(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_36(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_32(current), num4 + 1));
					num = ((int)num3 * -2058856702) ^ -1333359251;
					continue;
				case 8u:
					num4 = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_33(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_32(current), '-');
					num = ((int)num3 * -986584742) ^ 0x40A2AFE6;
					continue;
				case 7u:
					_2GLJdEpKkJ7x72M9J1r6gZaf9yp._7OcRfli7CrlI9YYUDJj3j5nDI9k = current;
					num = (int)(num3 * 766932288) ^ -1050839742;
					continue;
				case 6u:
					current = enumerator.Current;
					_2GLJdEpKkJ7x72M9J1r6gZaf9yp = new _2GLJdEpKkJ7x72M9J1r6gZaf9yp();
					num = -766139048;
					continue;
				case 4u:
					num = -1363170203;
					continue;
				case 3u:
					_2GLJdEpKkJ7x72M9J1r6gZaf9yp._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = this;
					num = (int)((num3 * 763417020) ^ 0x6FFA95B3);
					continue;
				case 1u:
					((Control)val2).add_MouseClick(new MouseEvent(_2GLJdEpKkJ7x72M9J1r6gZaf9yp._iFbMqXNzbW1FirCMxq8kqe1A9Dx));
					((ActiveList<ListBoxItem>)(object)val.get_Items()).Add(val2);
					num = (int)(num3 * 570669128) ^ -1320385783;
					continue;
				case 0u:
				{
					ListBoxItem obj = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_28();
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_25((Label)(object)obj, _poenyHBGUusBcnNcTFB9MQBV72R.smethod_37(string_, "\r\n", string_2));
					((Control)obj).set_Size(new Point(0, 50));
					val2 = obj;
					num = ((int)num3 * -164260584) ^ -1916582018;
					continue;
				}
				case 2u:
					break;
				default:
					return val;
				case 5u:
					return val;
				}
				break;
			}
		}
	}

	private Control _fM96M1a1ZZUtzPyevCm45mKPeQg()
	{
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected O, but got Unknown
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected O, but got Unknown
		Panel val = default(Panel);
		Label val9 = default(Label);
		Slider _XEgAfmv7sJWJSaC2diC3eaD4Fgl = default(Slider);
		Label val7 = default(Label);
		Slider _gjeIIVx9bHyd0aMj0WD483nrLWK = default(Slider);
		Label val4 = default(Label);
		Slider _5mK9ExiyKm0md8q4J1C6xc4TzdF = default(Slider);
		while (true)
		{
			int num = -1637933776;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCA272313u) % 9u)
				{
				case 7u:
					((ActiveList<Control>)(object)val.get_Content().get_Controls()).Add((Control)(object)val9);
					((ActiveList<Control>)(object)val.get_Content().get_Controls()).Add((Control)(object)_XEgAfmv7sJWJSaC2diC3eaD4Fgl);
					num = ((int)num2 * -1701360665) ^ 0x2575418C;
					continue;
				case 6u:
					((ActiveList<Control>)(object)val.get_Content().get_Controls()).Add((Control)(object)val7);
					((ActiveList<Control>)(object)val.get_Content().get_Controls()).Add((Control)(object)_gjeIIVx9bHyd0aMj0WD483nrLWK);
					((ActiveList<Control>)(object)val.get_Content().get_Controls()).Add((Control)(object)val4);
					((ActiveList<Control>)(object)val.get_Content().get_Controls()).Add((Control)(object)_5mK9ExiyKm0md8q4J1C6xc4TzdF);
					num = ((int)num2 * -120856843) ^ -1809970775;
					continue;
				case 4u:
				{
					Label val8 = new Label();
					((Control)val8).set_Dock((DockStyle)2);
					val8.set_Text("Master Volume");
					val9 = val8;
					Slider val10 = new Slider();
					((Control)val10).set_Dock((DockStyle)2);
					val10.set_Orientation((Orientation)0);
					val10.set_Steps(100f);
					val10.set_Value(_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._DF24JUrPFA6rJ2cQrOTlpC3I4FF * 100f);
					((Control)val10).set_Style("scrollSlider");
					((Control)val10).set_Size(new Point(0, 30));
					((Control)val10.get_Button()).set_Style("scrollSliderButton");
					_XEgAfmv7sJWJSaC2diC3eaD4Fgl = val10;
					num = ((int)num2 * -1055974064) ^ -1551136675;
					continue;
				}
				case 3u:
				{
					_XEgAfmv7sJWJSaC2diC3eaD4Fgl.add_ValueChanged((VoidEvent)delegate
					{
						_ws6FjNlgAT4bj3C6lODSIPTi5Tj.smethod_2(_ws6FjNlgAT4bj3C6lODSIPTi5Tj.smethod_0(), _ws6FjNlgAT4bj3C6lODSIPTi5Tj.smethod_1(_XEgAfmv7sJWJSaC2diC3eaD4Fgl) / 100f);
					});
					Label val6 = new Label();
					((Control)val6).set_Dock((DockStyle)2);
					val6.set_Text("Music Volume");
					val7 = val6;
					num = ((int)num2 * -810564141) ^ 0x575222A7;
					continue;
				}
				case 2u:
				{
					Slider val5 = new Slider();
					((Control)val5).set_Dock((DockStyle)2);
					val5.set_Orientation((Orientation)0);
					val5.set_Steps(100f);
					val5.set_Value(_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._2g4Ch8GXdUt0oEbdCZUY2QMbIuH * 100f);
					((Control)val5).set_Style("scrollSlider");
					((Control)val5).set_Size(new Point(0, 30));
					((Control)val5.get_Button()).set_Style("scrollSliderButton");
					_5mK9ExiyKm0md8q4J1C6xc4TzdF = val5;
					_5mK9ExiyKm0md8q4J1C6xc4TzdF.add_ValueChanged((VoidEvent)delegate
					{
						_ws6FjNlgAT4bj3C6lODSIPTi5Tj.smethod_4(_ws6FjNlgAT4bj3C6lODSIPTi5Tj.smethod_0(), _ws6FjNlgAT4bj3C6lODSIPTi5Tj.smethod_1(_5mK9ExiyKm0md8q4J1C6xc4TzdF) / 100f);
					});
					num = (int)((num2 * 2035522018) ^ 0x562A2778);
					continue;
				}
				case 1u:
				{
					Panel obj = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_23();
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_13((Control)(object)obj, (DockStyle)5);
					((Control)obj).set_Margin(new Margin(10));
					val = obj;
					num = (int)(num2 * 1515413818) ^ -936385102;
					continue;
				}
				case 0u:
				{
					Slider val2 = new Slider();
					((Control)val2).set_Dock((DockStyle)2);
					val2.set_Orientation((Orientation)0);
					val2.set_Steps(100f);
					val2.set_Value(_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._7NidKjx61ui5CP7JojwfqxH4aKC * 100f);
					((Control)val2).set_Style("scrollSlider");
					((Control)val2).set_Size(new Point(0, 30));
					((Control)val2.get_Button()).set_Style("scrollSliderButton");
					_gjeIIVx9bHyd0aMj0WD483nrLWK = val2;
					_gjeIIVx9bHyd0aMj0WD483nrLWK.add_ValueChanged((VoidEvent)delegate
					{
						_ws6FjNlgAT4bj3C6lODSIPTi5Tj.smethod_3(_ws6FjNlgAT4bj3C6lODSIPTi5Tj.smethod_0(), _ws6FjNlgAT4bj3C6lODSIPTi5Tj.smethod_1(_gjeIIVx9bHyd0aMj0WD483nrLWK) / 100f);
					});
					Label val3 = new Label();
					((Control)val3).set_Dock((DockStyle)2);
					val3.set_Text("SFX Volume");
					val4 = val3;
					num = (int)(num2 * 1228811068) ^ -1476867902;
					continue;
				}
				case 8u:
					break;
				default:
					return (Control)(object)val;
				}
				break;
			}
		}
	}

	private Control _H2blb6Djx9JemSUBYepwlzNOXxz()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		Panel obj = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_23();
		_poenyHBGUusBcnNcTFB9MQBV72R.smethod_13((Control)(object)obj, (DockStyle)5);
		((Control)obj).set_Margin(new Margin(10));
		Panel val = obj;
		CheckBox _feL3soNn6ZWaJqYfjYJUyH118tF = default(CheckBox);
		while (true)
		{
			int num = -399842147;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA34AEE90u) % 5u)
				{
				case 4u:
					_YemBTJprwfbd3mpg5Gy9uyEJWwI(val.get_Content().get_Controls(), "Dialogue Text Speed", new string[4] { "Slow", "Normal", "Fast", "Instant" }, (int)_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._wVLRBSMULz8GfedBPXaVJB0sBEO, delegate(int int_0)
					{
						_rm4nO8SKFlFnD1XybaGLNsNLB5F.smethod_2(_rm4nO8SKFlFnD1XybaGLNsNLB5F.smethod_1(), (DialogueSpeed)int_0);
						while (true)
						{
							int num3 = 126445287;
							while (true)
							{
								uint num4;
								switch ((num4 = (uint)num3 ^ 0x7FB6C35Bu) % 3u)
								{
								case 2u:
									goto IL_000d;
								default:
									return;
								case 0u:
									break;
								case 1u:
									return;
								}
								break;
								IL_000d:
								_rm4nO8SKFlFnD1XybaGLNsNLB5F.smethod_3((DialogueSpeed)int_0);
								num3 = (int)(num4 * 1764224355) ^ -1131782077;
							}
						}
					});
					num = -2109591266;
					continue;
				case 3u:
					_feL3soNn6ZWaJqYfjYJUyH118tF.add_CheckedChanged((VoidEvent)delegate
					{
						_AjJaaxdjRceHdvoz1idKTUfAsPQ.smethod_2(_AjJaaxdjRceHdvoz1idKTUfAsPQ.smethod_0(), _AjJaaxdjRceHdvoz1idKTUfAsPQ.smethod_1(_feL3soNn6ZWaJqYfjYJUyH118tF));
						_AjJaaxdjRceHdvoz1idKTUfAsPQ.smethod_3(_AjJaaxdjRceHdvoz1idKTUfAsPQ.smethod_1(_feL3soNn6ZWaJqYfjYJUyH118tF));
					});
					num = ((int)num2 * -1534668974) ^ -908457588;
					continue;
				case 1u:
				{
					CheckBox val2 = new CheckBox();
					((Control)val2).set_Dock((DockStyle)2);
					val2.set_Text("Dialogue Auto-skip");
					val2.set_Checked(_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._sbK0941BvW8HgPboNwOhIAd2jP3);
					_feL3soNn6ZWaJqYfjYJUyH118tF = val2;
					num = (int)(num2 * 2025978263) ^ -726630128;
					continue;
				}
				case 0u:
					break;
				default:
					((ActiveList<Control>)(object)val.get_Content().get_Controls()).Add((Control)(object)_feL3soNn6ZWaJqYfjYJUyH118tF);
					return (Control)(object)val;
				}
				break;
			}
		}
	}

	public static void _YemBTJprwfbd3mpg5Gy9uyEJWwI(ControlCollection controlCollection_0, string string_0, string[] string_1, int int_0, Action<int> action_0)
	{
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		Action<int> _qhAM4Wrvf8c5jzKBQqLfosAE9D = default(Action<int>);
		DropDownList val = default(DropDownList);
		int num3 = default(int);
		Label val2 = default(Label);
		while (true)
		{
			int num = 1345137475;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDF898Eu) % 10u)
				{
				case 9u:
					_qhAM4Wrvf8c5jzKBQqLfosAE9D = action_0;
					num = ((int)num2 * -516258520) ^ -1402445725;
					continue;
				case 8u:
					((Control)val.get_Listbox().get_Scrollbar().get_ButtonUp()).set_Visible(false);
					((Control)val.get_Listbox().get_Scrollbar().get_ButtonDown()).set_Visible(false);
					num3 = 0;
					num = (int)(num2 * 215781649) ^ -1444811733;
					continue;
				case 7u:
				{
					Label obj = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_24();
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_25(obj, string_0);
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_13((Control)(object)obj, (DockStyle)2);
					val2 = obj;
					DropDownList obj2 = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_38();
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_13((Control)(object)obj2, (DockStyle)2);
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_26((Control)(object)obj2, "button");
					((Control)_poenyHBGUusBcnNcTFB9MQBV72R.smethod_39(obj2)).set_Margin(new Margin(10, 0, 0, 0));
					obj2.get_Dropdown().set_Resizable(false);
					((Control)obj2).set_Margin(new Margin(0, 0, 0, 5));
					val = obj2;
					num = (int)((num2 * 1883375843) ^ 0x4AAC1FFB);
					continue;
				}
				case 6u:
				{
					ActiveList<ListBoxItem> items = val.get_Items();
					ListBoxItem val3 = new ListBoxItem();
					((Label)val3).set_Text(string_1[num3]);
					val3.set_Value((object)num3);
					val3.set_Selected(num3 == int_0);
					((Control)val3).set_Size(new Point(0, 30));
					items.Add(val3);
					num3++;
					num = 408974129;
					continue;
				}
				case 5u:
					((ActiveList<Control>)(object)controlCollection_0).Add((Control)(object)val2);
					num = (int)((num2 * 565460581) ^ 0x8C69245);
					continue;
				case 4u:
					((ActiveList<Control>)(object)controlCollection_0).Add((Control)(object)val);
					num = ((int)num2 * -2129879569) ^ -181058064;
					continue;
				case 3u:
					val.add_SelectedItemChanged((SelectedItemChangedEventHandler)delegate(Control control_0, ListBoxItem listBoxItem_0)
					{
						_qhAM4Wrvf8c5jzKBQqLfosAE9D((int)_4eBWC5cHwnSO1ZNylbprsv5CLKt.smethod_0(listBoxItem_0));
					});
					num = (int)((num2 * 1653518821) ^ 0x31EE92DC);
					continue;
				case 1u:
				{
					int num4;
					if (num3 >= string_1.Length)
					{
						num = 1791184995;
						num4 = 1791184995;
					}
					else
					{
						num = 1338675596;
						num4 = 1338675596;
					}
					continue;
				}
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private ListBox _1Bze6b62yGQDi3JBE0TyQmPGkzU()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		ListBox val = _Y29nu3VoVEY6acDadsfRh60BNDh();
		ListBoxItem obj = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_28();
		_poenyHBGUusBcnNcTFB9MQBV72R.smethod_25((Label)(object)obj, "Player Customization");
		((Control)obj).set_Size(new Point(0, 50));
		ListBoxItem val2 = obj;
		_ySEG6XuZVhXoWbL0fJc0sGefKrh ySEG6XuZVhXoWbL0fJc0sGefKrh = default(_ySEG6XuZVhXoWbL0fJc0sGefKrh);
		while (true)
		{
			int num = -897838957;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD9D9D18Eu) % 10u)
				{
				case 9u:
				{
					int num5;
					if (_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
					{
						num = -344626716;
						num5 = -344626716;
					}
					else
					{
						num = -1107544919;
						num5 = -1107544919;
					}
					continue;
				}
				case 8u:
				{
					ySEG6XuZVhXoWbL0fJc0sGefKrh = new _ySEG6XuZVhXoWbL0fJc0sGefKrh();
					ySEG6XuZVhXoWbL0fJc0sGefKrh._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = this;
					ListBoxItemCollection items = val.get_Items();
					ListBoxItem val4 = new ListBoxItem();
					((Label)val4).set_Text("---");
					((Control)val4).set_Enabled(false);
					((ActiveList<ListBoxItem>)(object)items).Add(val4);
					num = ((int)num2 * -996176352) ^ 0x316CEF4E;
					continue;
				}
				case 6u:
					((Control)ySEG6XuZVhXoWbL0fJc0sGefKrh._diVdxVCKW4CzhbYSG15BcHJB0Ub).add_MouseClick(new MouseEvent(ySEG6XuZVhXoWbL0fJc0sGefKrh._ISRRzLG00yCyBtR4sMqlaCKpvCH));
					num = ((int)num2 * -360067409) ^ -1601455237;
					continue;
				case 5u:
					_oWVabv0BTttUwHhKppcIL7h0vrZ(val);
					num = (int)((num2 * 1793667105) ^ 0x512DB3E3);
					continue;
				case 4u:
				{
					_ySEG6XuZVhXoWbL0fJc0sGefKrh ySEG6XuZVhXoWbL0fJc0sGefKrh2 = ySEG6XuZVhXoWbL0fJc0sGefKrh;
					ListBoxItem val3 = new ListBoxItem();
					((Label)val3).set_Text(_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF ? "Disable SFW" : "Enable SFW");
					((Control)val3).set_Size(new Point(0, 50));
					ySEG6XuZVhXoWbL0fJc0sGefKrh2._diVdxVCKW4CzhbYSG15BcHJB0Ub = val3;
					num = -842364522;
					continue;
				}
				case 3u:
					((ActiveList<ListBoxItem>)(object)val.get_Items()).Add(ySEG6XuZVhXoWbL0fJc0sGefKrh._diVdxVCKW4CzhbYSG15BcHJB0Ub);
					num = (int)((num2 * 1148797537) ^ 0xA491976);
					continue;
				case 1u:
					((Control)val2).add_MouseClick((MouseEvent)delegate
					{
						_3AaEmo54VzWybgrrg7I8Z9JUV1e = true;
						while (true)
						{
							int num6 = 1080381110;
							while (true)
							{
								uint num7;
								switch ((num7 = (uint)num6 ^ 0x1B87E7F7u) % 3u)
								{
								case 2u:
									goto IL_0009;
								default:
									return;
								case 0u:
									break;
								case 1u:
									return;
								}
								break;
								IL_0009:
								_poenyHBGUusBcnNcTFB9MQBV72R.smethod_73(_9GQBAH2pi8Sm6ph1s6InjyQGe6R, "Are you sure you wish to customize your character? This may break some active dates even if make no changes!", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, 250, (Action<int>)delegate(int int_0)
								{
									if (int_0 == 1)
									{
										goto IL_0034;
									}
									goto IL_005e;
									IL_005e:
									_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
									int num8 = 1173013474;
									goto IL_0039;
									IL_0039:
									while (true)
									{
										uint num9;
										switch ((num9 = (uint)num8 ^ 0x6A962EDAu) % 5u)
										{
										case 3u:
											_4L7hfXrWoDdArQiscG4ukHCV46B._k9wUPeU1Ga7cygiuGP8TT6aPLWF<BackToPlayerCustomizationScene>();
											num8 = ((int)num9 * -14435164) ^ 0x40523630;
											continue;
										case 2u:
											_RiDuYMeg3EHnBUteUcAb8VlfQVl();
											num8 = (int)((num9 * 1563904339) ^ 0x21BF9559);
											continue;
										case 0u:
											break;
										default:
											return;
										case 1u:
											goto IL_005e;
										case 4u:
											return;
										}
										break;
									}
									goto IL_0034;
									IL_0034:
									num8 = 1584637405;
									goto IL_0039;
								});
								num6 = ((int)num7 * -1144536403) ^ -1683028554;
							}
						}
					});
					num = (int)(num2 * 757090089) ^ -180908053;
					continue;
				case 0u:
				{
					((ActiveList<ListBoxItem>)(object)val.get_Items()).Add(val2);
					int num3;
					int num4;
					if (_iExD93IWLlzVfXsU9wyrEvWgJsg._X41qA9hgcgXH0Q1aFKWFWpg8UuM)
					{
						num3 = 623673112;
						num4 = 623673112;
					}
					else
					{
						num3 = 953792331;
						num4 = 953792331;
					}
					num = num3 ^ ((int)num2 * -639301761);
					continue;
				}
				case 7u:
					break;
				default:
					return val;
				}
				break;
			}
		}
	}

	private void _YdyKdWT8QbQOIWkgEuPe6a9hJtd(Action action_0)
	{
		while (true)
		{
			int num = -43582189;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA8C5405Du) % 3u)
				{
				case 2u:
					goto IL_0016;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0016:
				_poenyHBGUusBcnNcTFB9MQBV72R.smethod_41(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_40(_4L7hfXrWoDdArQiscG4ukHCV46B), (Action)delegate
				{
					string _nc2gJWKJm6yAMtppwpcfigGPFj3 = default(string);
					while (true)
					{
						int num3 = -527750492;
						while (true)
						{
							uint num4;
							switch ((num4 = (uint)num3 ^ 0xD885B90Eu) % 4u)
							{
							case 3u:
								_0nFvyop0acDTSu0pbg4xnLHeOi.smethod_3(_4L7hfXrWoDdArQiscG4ukHCV46B);
								num3 = ((int)num4 * -1744590626) ^ -1707012779;
								continue;
							case 2u:
							{
								_TwlwMC1hhdSzamwGWEBxuUkz1gH twlwMC1hhdSzamwGWEBxuUkz1gH = _0nFvyop0acDTSu0pbg4xnLHeOi.smethod_0(_4L7hfXrWoDdArQiscG4ukHCV46B);
								_nc2gJWKJm6yAMtppwpcfigGPFj3 = ((twlwMC1hhdSzamwGWEBxuUkz1gH != null) ? _0nFvyop0acDTSu0pbg4xnLHeOi.smethod_2((MemberInfo)_0nFvyop0acDTSu0pbg4xnLHeOi.smethod_1((object)twlwMC1hhdSzamwGWEBxuUkz1gH)) : null);
								int num5;
								if (_nc2gJWKJm6yAMtppwpcfigGPFj3 != null)
								{
									num3 = -592996755;
									num5 = -592996755;
								}
								else
								{
									num3 = -1062862193;
									num5 = -1062862193;
								}
								continue;
							}
							case 0u:
								break;
							default:
								action_0();
								_0nFvyop0acDTSu0pbg4xnLHeOi.smethod_6(_4L7hfXrWoDdArQiscG4ukHCV46B, _0nFvyop0acDTSu0pbg4xnLHeOi.smethod_2((MemberInfo)_0nFvyop0acDTSu0pbg4xnLHeOi.smethod_5((object)_0nFvyop0acDTSu0pbg4xnLHeOi.smethod_4(_4L7hfXrWoDdArQiscG4ukHCV46B))), (Action)delegate
								{
									if (_nc2gJWKJm6yAMtppwpcfigGPFj3 != null)
									{
										goto IL_0034;
									}
									goto IL_005a;
									IL_005a:
									_Xz9JDCJHGCV62mEFcQGw4HJ6Lgn.smethod_2(_Xz9JDCJHGCV62mEFcQGw4HJ6Lgn.smethod_1(_4L7hfXrWoDdArQiscG4ukHCV46B), (Action)null);
									int num6 = -194036894;
									goto IL_0039;
									IL_0039:
									while (true)
									{
										uint num7;
										switch ((num7 = (uint)num6 ^ 0xDAD7EA97u) % 4u)
										{
										case 3u:
											_Xz9JDCJHGCV62mEFcQGw4HJ6Lgn.smethod_0(_4L7hfXrWoDdArQiscG4ukHCV46B, _nc2gJWKJm6yAMtppwpcfigGPFj3);
											num6 = ((int)num7 * -1073173012) ^ 0x21D28C03;
											continue;
										case 2u:
											break;
										default:
											return;
										case 0u:
											goto IL_005a;
										case 1u:
											return;
										}
										break;
									}
									goto IL_0034;
									IL_0034:
									num6 = -1262047732;
									goto IL_0039;
								});
								return;
							}
							break;
						}
					}
				});
				num = (int)(num2 * 2093439326) ^ -1503818485;
			}
		}
	}

	private void _ZfxNkwQ3qvZWenbVYRs2XNSAF2c(string string_0)
	{
		_poenyHBGUusBcnNcTFB9MQBV72R.smethod_42(_4L7hfXrWoDdArQiscG4ukHCV46B, string_0);
		_RiDuYMeg3EHnBUteUcAb8VlfQVl();
	}

	private ListBox _dT5L6g1CEsgeYg5W9sVqR2trRSK()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		ListBox val = _Y29nu3VoVEY6acDadsfRh60BNDh();
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG_ = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_19();
		if (_poenyHBGUusBcnNcTFB9MQBV72R.smethod_20(opIJo2jLUqdOL5yAFP4yzXce0DG_, "Prologue") == 40)
		{
			goto IL_017f;
		}
		goto IL_01b6;
		IL_01b6:
		ListBoxItem val2 = new ListBoxItem();
		((Label)val2).set_Text("Exit to Main Menu");
		((Control)val2).set_Size(new Point(0, 50));
		ListBoxItem val3 = val2;
		int num = -790493927;
		goto IL_0184;
		IL_0184:
		ListBoxItem val6 = default(ListBoxItem);
		ListBoxItem val5 = default(ListBoxItem);
		ListBoxItem val4 = default(ListBoxItem);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xBB7731ECu) % 8u)
			{
			case 7u:
			{
				ListBoxItem obj = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_28();
				_poenyHBGUusBcnNcTFB9MQBV72R.smethod_25((Label)(object)obj, "Back to Home");
				((Control)obj).set_Size(new Point(0, 50));
				val6 = obj;
				ListBoxItem val9 = new ListBoxItem();
				((Label)val9).set_Text("Back to Club Amorous");
				((Control)val9).set_Size(new Point(0, 50));
				val5 = val9;
				((ActiveList<ListBoxItem>)(object)val.get_Items()).Add(val6);
				num = ((int)num2 * -740232688) ^ 0x32E299B8;
				continue;
			}
			case 6u:
			{
				ListBoxItem val8 = new ListBoxItem();
				((Label)val8).set_Text("Quit Game");
				((Control)val8).set_Size(new Point(0, 50));
				val4 = val8;
				((Control)val4).add_MouseClick((MouseEvent)delegate
				{
					_3AaEmo54VzWybgrrg7I8Z9JUV1e = true;
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_73(_9GQBAH2pi8Sm6ph1s6InjyQGe6R, "Are you sure you wish to quit the game? All unsaved progress will be lost!", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, 250, (Action<int>)delegate(int int_0)
					{
						if (int_0 == 1)
						{
							goto IL_0004;
						}
						goto IL_0044;
						IL_0044:
						_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
						int num3 = 514604546;
						goto IL_0023;
						IL_0023:
						while (true)
						{
							uint num4;
							switch ((num4 = (uint)num3 ^ 0x73646F4Eu) % 4u)
							{
							case 3u:
								break;
							case 1u:
								_poenyHBGUusBcnNcTFB9MQBV72R.smethod_85(_4L7hfXrWoDdArQiscG4ukHCV46B);
								num3 = (int)((num4 * 2103971007) ^ 0x4B929A5F);
								continue;
							default:
								return;
							case 2u:
								goto IL_0044;
							case 0u:
								return;
							}
							break;
						}
						goto IL_0004;
						IL_0004:
						num3 = 85626127;
						goto IL_0023;
					});
				});
				((ActiveList<ListBoxItem>)(object)val.get_Items()).Add(val3);
				num = ((int)num2 * -1062985088) ^ 0x17D7B66E;
				continue;
			}
			case 5u:
				((Control)val3).add_MouseClick((MouseEvent)delegate
				{
					_RiDuYMeg3EHnBUteUcAb8VlfQVl();
					_kf3EbE0B70xGe1szklqAZyCqoLj = false;
					_4L7hfXrWoDdArQiscG4ukHCV46B._k9wUPeU1Ga7cygiuGP8TT6aPLWF<MainMenuScene>();
				});
				num = ((int)num2 * -1645732218) ^ -222381732;
				continue;
			case 4u:
			{
				((ActiveList<ListBoxItem>)(object)val.get_Items()).Add(val5);
				((Control)val6).add_MouseClick((MouseEvent)delegate
				{
					_RiDuYMeg3EHnBUteUcAb8VlfQVl();
					_4L7hfXrWoDdArQiscG4ukHCV46B._k9wUPeU1Ga7cygiuGP8TT6aPLWF<BedroomScene>();
				});
				((Control)val5).add_MouseClick((MouseEvent)delegate
				{
					_RiDuYMeg3EHnBUteUcAb8VlfQVl();
					while (true)
					{
						int num5 = 1049320066;
						while (true)
						{
							uint num6;
							switch ((num6 = (uint)num5 ^ 0x1D2ED72Fu) % 3u)
							{
							case 1u:
								goto IL_0007;
							default:
								return;
							case 2u:
								break;
							case 0u:
								return;
							}
							break;
							IL_0007:
							_4L7hfXrWoDdArQiscG4ukHCV46B._k9wUPeU1Ga7cygiuGP8TT6aPLWF<ClubInsideScene>();
							num5 = ((int)num6 * -57633089) ^ -55423361;
						}
					}
				});
				ListBoxItemCollection items = val.get_Items();
				ListBoxItem val7 = new ListBoxItem();
				((Label)val7).set_Text("---");
				((Control)val7).set_Enabled(false);
				((ActiveList<ListBoxItem>)(object)items).Add(val7);
				num = ((int)num2 * -511429952) ^ 0x506A2275;
				continue;
			}
			case 2u:
				((ActiveList<ListBoxItem>)(object)val.get_Items()).Add(val4);
				num = (int)((num2 * 163807042) ^ 0x27D5EB23);
				continue;
			case 0u:
				break;
			case 1u:
				goto IL_01b6;
			default:
				return val;
			}
			break;
		}
		goto IL_017f;
		IL_017f:
		num = -875996933;
		goto IL_0184;
	}

	private void _oWVabv0BTttUwHhKppcIL7h0vrZ(ListBox listBox_0)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		ListBoxItem _Epeel2m9h5O12V2ERwlnNTE3FdM;
		_poenyHBGUusBcnNcTFB9MQBV72R _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = default(_poenyHBGUusBcnNcTFB9MQBV72R);
		ListBoxItem _FxyX2MMMdsf69424VDXa8LqP1nq = default(ListBoxItem);
		while (true)
		{
			int num = -1053861376;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x969926DAu) % 5u)
				{
				case 4u:
				{
					ListBoxItem obj = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_28();
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_25((Label)(object)obj, _poenyHBGUusBcnNcTFB9MQBV72R.smethod_43() ? "Disable Topless Cheat" : "Enable Topless Cheat");
					((Control)obj).set_Size(new Point(0, 50));
					_Epeel2m9h5O12V2ERwlnNTE3FdM = obj;
					((Control)_Epeel2m9h5O12V2ERwlnNTE3FdM).add_MouseClick((MouseEvent)delegate
					{
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._YdyKdWT8QbQOIWkgEuPe6a9hJtd(delegate
						{
							_J2cDcMayMidSIab2lnReI8upBwS.smethod_1(!_J2cDcMayMidSIab2lnReI8upBwS.smethod_0());
							while (true)
							{
								int num3 = -1086439274;
								while (true)
								{
									ListBoxItem label_;
									string string_;
									switch ((uint)(num3 ^ -273731706) % 3u)
									{
									case 1u:
										label_ = _Epeel2m9h5O12V2ERwlnNTE3FdM;
										string_ = (_J2cDcMayMidSIab2lnReI8upBwS.smethod_0() ? "Disable Topless Cheat" : "Enable Topless Cheat");
										goto IL_002a;
									default:
										return;
									case 0u:
										break;
									case 2u:
										return;
									}
									break;
									IL_002a:
									_J2cDcMayMidSIab2lnReI8upBwS.smethod_2((Label)(object)label_, string_);
									num3 = -646255287;
								}
							}
						});
					});
					ListBoxItem val = new ListBoxItem();
					((Label)val).set_Text(_iExD93IWLlzVfXsU9wyrEvWgJsg._pKBiGAgDu5WqoykkGBaEGnP7oMj ? "Disable Bottomless Cheat" : "Enable Bottomless Cheat");
					((Control)val).set_Size(new Point(0, 50));
					_FxyX2MMMdsf69424VDXa8LqP1nq = val;
					((Control)_FxyX2MMMdsf69424VDXa8LqP1nq).add_MouseClick((MouseEvent)delegate
					{
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._YdyKdWT8QbQOIWkgEuPe6a9hJtd(delegate
						{
							_J2cDcMayMidSIab2lnReI8upBwS.smethod_4(!_J2cDcMayMidSIab2lnReI8upBwS.smethod_3());
							_J2cDcMayMidSIab2lnReI8upBwS.smethod_2((Label)(object)_FxyX2MMMdsf69424VDXa8LqP1nq, _J2cDcMayMidSIab2lnReI8upBwS.smethod_3() ? "Disable Bottomless Cheat" : "Enable Bottomless Cheat");
						});
					});
					((ActiveList<ListBoxItem>)(object)listBox_0.get_Items()).Add(_Epeel2m9h5O12V2ERwlnNTE3FdM);
					num = -1725142948;
					continue;
				}
				case 3u:
					((ActiveList<ListBoxItem>)(object)listBox_0.get_Items()).Add(_FxyX2MMMdsf69424VDXa8LqP1nq);
					num = (int)(num2 * 1130631808) ^ -1529466270;
					continue;
				case 1u:
					_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = this;
					num = (int)((num2 * 2107579646) ^ 0x7062EEB4);
					continue;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	private void _WDhVhBhQHGowaONqV87v7EaCvro(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts ephoneContacts_0)
	{
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG_ = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_19();
		while (true)
		{
			int num = -366192214;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9698650Cu) % 52u)
				{
				case 51u:
				{
					int num7;
					int num8;
					if (_poenyHBGUusBcnNcTFB9MQBV72R.smethod_20(opIJo2jLUqdOL5yAFP4yzXce0DG_, "MercyDate") != 60)
					{
						num7 = 1810537969;
						num8 = 1810537969;
					}
					else
					{
						num7 = 916455831;
						num8 = 916455831;
					}
					num = num7 ^ (int)(num2 * 110062759);
					continue;
				}
				case 50u:
				{
					int num18;
					int num19;
					if (_poenyHBGUusBcnNcTFB9MQBV72R.smethod_20(opIJo2jLUqdOL5yAFP4yzXce0DG_, "RemyDate") != 40)
					{
						num18 = 490275145;
						num19 = 490275145;
					}
					else
					{
						num18 = 2120991106;
						num19 = 2120991106;
					}
					num = num18 ^ ((int)num2 * -1242254975);
					continue;
				}
				case 47u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_42(_4L7hfXrWoDdArQiscG4ukHCV46B, "RemyDate");
					_RiDuYMeg3EHnBUteUcAb8VlfQVl();
					num = -605535158;
					continue;
				case 46u:
				{
					int num28;
					int num29;
					if (_poenyHBGUusBcnNcTFB9MQBV72R.smethod_20(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_19(), "ZenithDate") == 70)
					{
						num28 = -659941550;
						num29 = -659941550;
					}
					else
					{
						num28 = -588485920;
						num29 = -588485920;
					}
					num = num28 ^ (int)(num2 * 1240831971);
					continue;
				}
				case 44u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_42(_4L7hfXrWoDdArQiscG4ukHCV46B, "JaxDate");
					num = -376009264;
					continue;
				case 43u:
					_RiDuYMeg3EHnBUteUcAb8VlfQVl();
					num = ((int)num2 * -714427260) ^ -829678555;
					continue;
				case 41u:
				{
					int num15;
					int num16;
					if (_poenyHBGUusBcnNcTFB9MQBV72R.smethod_20(opIJo2jLUqdOL5yAFP4yzXce0DG_, "CobyDate") < 20)
					{
						num15 = 75364306;
						num16 = 75364306;
					}
					else
					{
						num15 = 1134646287;
						num16 = 1134646287;
					}
					num = num15 ^ ((int)num2 * -1830605003);
					continue;
				}
				case 40u:
				{
					int num24;
					if (ephoneContacts_0 != _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Lex)
					{
						num = -959434793;
						num24 = -959434793;
					}
					else
					{
						num = -1465935139;
						num24 = -1465935139;
					}
					continue;
				}
				case 36u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_42(_4L7hfXrWoDdArQiscG4ukHCV46B, "SethDate");
					num = -946260720;
					continue;
				case 35u:
				{
					int num9;
					int num10;
					if (_poenyHBGUusBcnNcTFB9MQBV72R.smethod_20(opIJo2jLUqdOL5yAFP4yzXce0DG_, "SkyeDate") != 60)
					{
						num9 = -50953166;
						num10 = -50953166;
					}
					else
					{
						num9 = -39515536;
						num10 = -39515536;
					}
					num = num9 ^ (int)(num2 * 329274787);
					continue;
				}
				case 33u:
				{
					int num30;
					if (ephoneContacts_0 == _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Remy)
					{
						num = -1433255538;
						num30 = -1433255538;
					}
					else
					{
						num = -1660249680;
						num30 = -1660249680;
					}
					continue;
				}
				case 32u:
				{
					int num25;
					if (ephoneContacts_0 == _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Seth)
					{
						num = -1772682405;
						num25 = -1772682405;
					}
					else
					{
						num = -336868841;
						num25 = -336868841;
					}
					continue;
				}
				case 31u:
				{
					int num22;
					if (ephoneContacts_0 == _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Skye)
					{
						num = -650104913;
						num22 = -650104913;
					}
					else
					{
						num = -1965436056;
						num22 = -1965436056;
					}
					continue;
				}
				case 30u:
					_7v3cPeHMFZr3s2VCyeFm9SEiyy0(ephoneContacts_0);
					num = ((int)num2 * -304817270) ^ -1743198195;
					continue;
				case 29u:
				{
					int num13;
					int num14;
					if (_poenyHBGUusBcnNcTFB9MQBV72R.smethod_20(opIJo2jLUqdOL5yAFP4yzXce0DG_, "JaxDate") == 40)
					{
						num13 = -2080977641;
						num14 = -2080977641;
					}
					else
					{
						num13 = -342193445;
						num14 = -342193445;
					}
					num = num13 ^ (int)(num2 * 1386875391);
					continue;
				}
				case 28u:
				{
					int num4;
					int num5;
					if (_poenyHBGUusBcnNcTFB9MQBV72R.smethod_20(opIJo2jLUqdOL5yAFP4yzXce0DG_, "DustinDate") != 70)
					{
						num4 = -1900719818;
						num5 = -1900719818;
					}
					else
					{
						num4 = -911067734;
						num5 = -911067734;
					}
					num = num4 ^ ((int)num2 * -1273967527);
					continue;
				}
				case 27u:
				{
					int num26;
					int num27;
					if (_poenyHBGUusBcnNcTFB9MQBV72R.smethod_20(opIJo2jLUqdOL5yAFP4yzXce0DG_, "SethDate") == 40)
					{
						num26 = -1288527123;
						num27 = -1288527123;
					}
					else
					{
						num26 = -1474895066;
						num27 = -1474895066;
					}
					num = num26 ^ ((int)num2 * -947996594);
					continue;
				}
				case 24u:
				{
					int num23;
					if (ephoneContacts_0 == _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Zenith)
					{
						num = -1124637414;
						num23 = -1124637414;
					}
					else
					{
						num = -1272088747;
						num23 = -1272088747;
					}
					continue;
				}
				case 23u:
					_RiDuYMeg3EHnBUteUcAb8VlfQVl();
					num = (int)((num2 * 268984499) ^ 0x62D30CEF);
					continue;
				case 21u:
					_RiDuYMeg3EHnBUteUcAb8VlfQVl();
					num = (int)(num2 * 1164117095) ^ -1990302038;
					continue;
				case 20u:
					_RiDuYMeg3EHnBUteUcAb8VlfQVl();
					num = ((int)num2 * -51981643) ^ 0x6C88EAA3;
					continue;
				case 18u:
				{
					int num20;
					int num21;
					if (ephoneContacts_0 != _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Coby)
					{
						num20 = -1005928314;
						num21 = -1005928314;
					}
					else
					{
						num20 = -1106875731;
						num21 = -1106875731;
					}
					num = num20 ^ (int)(num2 * 451278408);
					continue;
				}
				case 14u:
				{
					int num17;
					if (ephoneContacts_0 == _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Dustin)
					{
						num = -52017560;
						num17 = -52017560;
					}
					else
					{
						num = -815011219;
						num17 = -815011219;
					}
					continue;
				}
				case 13u:
				{
					int num11;
					int num12;
					if (_poenyHBGUusBcnNcTFB9MQBV72R.smethod_20(opIJo2jLUqdOL5yAFP4yzXce0DG_, "LexDate") == 50)
					{
						num11 = -1211441111;
						num12 = -1211441111;
					}
					else
					{
						num11 = -662194197;
						num12 = -662194197;
					}
					num = num11 ^ (int)(num2 * 633623823);
					continue;
				}
				case 12u:
					_7v3cPeHMFZr3s2VCyeFm9SEiyy0(ephoneContacts_0);
					num = (int)((num2 * 1379560034) ^ 0x784C043A);
					continue;
				case 11u:
				{
					int num6;
					if (ephoneContacts_0 != _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Mercy)
					{
						num = -173809831;
						num6 = -173809831;
					}
					else
					{
						num = -238997089;
						num6 = -238997089;
					}
					continue;
				}
				case 10u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_42(_4L7hfXrWoDdArQiscG4ukHCV46B, "ZenithDate");
					num = -1494277211;
					continue;
				case 8u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_42(_4L7hfXrWoDdArQiscG4ukHCV46B, "LexDate");
					num = -96383867;
					continue;
				case 6u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_42(_4L7hfXrWoDdArQiscG4ukHCV46B, "DustinDate");
					num = -524286445;
					continue;
				case 5u:
				{
					int num3;
					if (ephoneContacts_0 != _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Jax)
					{
						num = -722363528;
						num3 = -722363528;
					}
					else
					{
						num = -1148282791;
						num3 = -1148282791;
					}
					continue;
				}
				case 3u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_42(_4L7hfXrWoDdArQiscG4ukHCV46B, "CobyDate");
					num = -867453573;
					continue;
				case 1u:
					_7v3cPeHMFZr3s2VCyeFm9SEiyy0(ephoneContacts_0);
					num = ((int)num2 * -700562199) ^ -85626812;
					continue;
				case 0u:
					_RiDuYMeg3EHnBUteUcAb8VlfQVl();
					num = ((int)num2 * -782915579) ^ 0x58A14D2D;
					continue;
				default:
					return;
				case 15u:
					break;
				case 2u:
					_7v3cPeHMFZr3s2VCyeFm9SEiyy0(ephoneContacts_0);
					return;
				case 4u:
					_7v3cPeHMFZr3s2VCyeFm9SEiyy0(ephoneContacts_0);
					return;
				case 7u:
					return;
				case 9u:
					return;
				case 16u:
					_7v3cPeHMFZr3s2VCyeFm9SEiyy0(ephoneContacts_0);
					return;
				case 17u:
					_RiDuYMeg3EHnBUteUcAb8VlfQVl();
					return;
				case 19u:
					_7v3cPeHMFZr3s2VCyeFm9SEiyy0(ephoneContacts_0);
					return;
				case 22u:
					return;
				case 25u:
					return;
				case 26u:
					return;
				case 34u:
					_7v3cPeHMFZr3s2VCyeFm9SEiyy0(ephoneContacts_0);
					return;
				case 37u:
					return;
				case 38u:
					return;
				case 39u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_42(_4L7hfXrWoDdArQiscG4ukHCV46B, "SkyeDate");
					_RiDuYMeg3EHnBUteUcAb8VlfQVl();
					return;
				case 42u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_42(_4L7hfXrWoDdArQiscG4ukHCV46B, "CobyPostDate");
					return;
				case 45u:
					return;
				case 48u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_42(_4L7hfXrWoDdArQiscG4ukHCV46B, "MercyDate");
					_RiDuYMeg3EHnBUteUcAb8VlfQVl();
					return;
				case 49u:
					return;
				}
				break;
			}
		}
	}

	private void _7v3cPeHMFZr3s2VCyeFm9SEiyy0(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts ephoneContacts_0)
	{
		_3AaEmo54VzWybgrrg7I8Z9JUV1e = true;
		string object_ = ephoneContacts_0.ToString();
		_poenyHBGUusBcnNcTFB9MQBV72R.smethod_45(_9GQBAH2pi8Sm6ph1s6InjyQGe6R, _poenyHBGUusBcnNcTFB9MQBV72R.smethod_44("You finished all dates with {0}!", (object)object_), 250, "Gotcha!", (Action)delegate
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
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected O, but got Unknown
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Expected O, but got Unknown
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Expected O, but got Unknown
		while (true)
		{
			int num = 1082371162;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3EF898BEu) % 14u)
				{
				case 13u:
					_9GQBAH2pi8Sm6ph1s6InjyQGe6R._EMnZAXxoqoahiGOiNjffRycLtDE("Assets/GUI/Squid/DefaultSkin");
					num = ((int)num2 * -946596741) ^ -922488972;
					continue;
				case 12u:
					_hrw3Kf8fCx7saJOmoYUD8sIz3uD._WPy6ICx3LVoejBaexyOoKGnX9jD("Arm rise", 0f);
					num = (int)(num2 * 215855958) ^ -763149218;
					continue;
				case 10u:
					_6T55wit7MiGfAWRkPwjNbJ8N8lG = this;
					_4L7hfXrWoDdArQiscG4ukHCV46B = _JbeCmOie0phb2cbgG6DdGZrbs3pB_0;
					_hrw3Kf8fCx7saJOmoYUD8sIz3uD = contentManager_0._7BVREQXEcBCieHb0qgaVDpUj1ni("Assets/GUI/Phone/Phone");
					num = ((int)num2 * -783050374) ^ 0x4A672266;
					continue;
				case 9u:
					_bZJtpWV2Yj6GgZkeZQUmpTHxTnh = new RenderTarget2D(_4L7hfXrWoDdArQiscG4ukHCV46B._2yepMkVENnecIsduggABaU2qhXW, 270, 380);
					_Pfaq6ajchxcqF6GecivHvHqQW6M = new RenderTarget2D(_4L7hfXrWoDdArQiscG4ukHCV46B._2yepMkVENnecIsduggABaU2qhXW, 270, 380);
					num = (int)((num2 * 1615515251) ^ 0x419EA366);
					continue;
				case 7u:
					_wTbB4YBL4PSkaotwKX3CFc50DmX._7Xn1C5tjYnmIif1iZKV8AWsEEbL = 135f;
					_wTbB4YBL4PSkaotwKX3CFc50DmX._bCjZ3VSXGKyhmykd2zCnQBiSpDf = 190f;
					_rASuGHWSFVWfkpwzF8wZd9bh3XN = true;
					num = (int)(num2 * 730466213) ^ -1399259885;
					continue;
				case 6u:
					_1gXQH16lmsacxQMOpjFFqZSmjQl = true;
					num = ((int)num2 * -1506343314) ^ 0x47945E24;
					continue;
				case 5u:
				{
					Desktop val = new Desktop();
					val.set_Skin(Gui.GenerateStandardSkin());
					((Control)val).set_Size(new Point(270, 380));
					_9GQBAH2pi8Sm6ph1s6InjyQGe6R = val;
					num = (int)((num2 * 1359483373) ^ 0x4D420C7A);
					continue;
				}
				case 4u:
					_lpMGMQZJYmHr6q9XBRwiM0Lse4N._7Xn1C5tjYnmIif1iZKV8AWsEEbL = 1845f;
					_lpMGMQZJYmHr6q9XBRwiM0Lse4N._bCjZ3VSXGKyhmykd2zCnQBiSpDf = 1060f;
					_wTbB4YBL4PSkaotwKX3CFc50DmX = contentManager_0._7BVREQXEcBCieHb0qgaVDpUj1ni("Assets/GUI/Phone/PhoneScreen");
					num = (int)((num2 * 186702251) ^ 0xA66BB);
					continue;
				case 3u:
					_VQDLuxMbrizDwdFWvZoaPpO7Y0o = new Stack<_VQgRlkt1vazuo2KaxFIrSVwZOpL>();
					num = (int)((num2 * 337096738) ^ 0x40CCDE78);
					continue;
				case 2u:
					_Xrfjrxr72hHh4bDdQB7HzEbJUCb();
					num = ((int)num2 * -1830379745) ^ 0x705CED3F;
					continue;
				case 1u:
					_9GQBAH2pi8Sm6ph1s6InjyQGe6R.set_ModalColor(ColorInt.ARGB(0.9f, 0f, 0f, 0f));
					_9GQBAH2pi8Sm6ph1s6InjyQGe6R.MouseTransformFunc = delegate(Point point_0)
					{
						//IL_000e: Unknown result type (might be due to invalid IL or missing references)
						//IL_0013: Unknown result type (might be due to invalid IL or missing references)
						//IL_0014: Unknown result type (might be due to invalid IL or missing references)
						//IL_001c: Unknown result type (might be due to invalid IL or missing references)
						//IL_0029: Unknown result type (might be due to invalid IL or missing references)
						//IL_0031: Unknown result type (might be due to invalid IL or missing references)
						//IL_0036: Unknown result type (might be due to invalid IL or missing references)
						//IL_003b: Unknown result type (might be due to invalid IL or missing references)
						//IL_004c: Unknown result type (might be due to invalid IL or missing references)
						//IL_0051: Unknown result type (might be due to invalid IL or missing references)
						//IL_0052: Unknown result type (might be due to invalid IL or missing references)
						//IL_0057: Unknown result type (might be due to invalid IL or missing references)
						//IL_0058: Unknown result type (might be due to invalid IL or missing references)
						//IL_005f: Unknown result type (might be due to invalid IL or missing references)
						//IL_0066: Unknown result type (might be due to invalid IL or missing references)
						double double_ = default(double);
						Point val2 = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_72(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Sheen Two", ref double_);
						Matrix val3 = Matrix.CreateTranslation((float)(-val2.X), (float)(-val2.Y), 0f) * Matrix.CreateRotationZ((float)(0.0 - double_));
						Vector2 val4 = Vector2.Transform(new Vector2((float)((Point)(ref point_0)).get_x(), (float)((Point)(ref point_0)).get_y()), val3);
						return new Point((int)val4.X, (int)val4.Y);
					};
					num = (int)(num2 * 389115081) ^ -324098510;
					continue;
				case 0u:
					_hrw3Kf8fCx7saJOmoYUD8sIz3uD._c4iC7y9v6xg7LpvjKIeUkOdZ3UF(0f);
					_hrw3Kf8fCx7saJOmoYUD8sIz3uD._7Xn1C5tjYnmIif1iZKV8AWsEEbL = 0f;
					_hrw3Kf8fCx7saJOmoYUD8sIz3uD._bCjZ3VSXGKyhmykd2zCnQBiSpDf = 1200f;
					_lpMGMQZJYmHr6q9XBRwiM0Lse4N = contentManager_0._7BVREQXEcBCieHb0qgaVDpUj1ni("Assets/GUI/Phone/PhoneHUD", 0.5f);
					_lpMGMQZJYmHr6q9XBRwiM0Lse4N._C5vPbZ72rpVMDWGuHxZuR5FNpAH("No message");
					num = (int)((num2 * 1483306353) ^ 0xCCBADC6);
					continue;
				case 11u:
					break;
				default:
					_97m6gVcwgWbLFyNUxI3P1KuD0Gn = true;
					return;
				}
				break;
			}
		}
	}

	public void _Xrfjrxr72hHh4bDdQB7HzEbJUCb()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_061a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0689: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0774: Unknown result type (might be due to invalid IL or missing references)
		//IL_0854: Unknown result type (might be due to invalid IL or missing references)
		//IL_090a: Unknown result type (might be due to invalid IL or missing references)
		//IL_094b: Unknown result type (might be due to invalid IL or missing references)
		//IL_098a: Unknown result type (might be due to invalid IL or missing references)
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG_ = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_19();
		bool flag = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_47((Enum)_poenyHBGUusBcnNcTFB9MQBV72R.smethod_46(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.LongForearm);
		bool flag2 = default(bool);
		Color color_ = default(Color);
		while (true)
		{
			int num = -459433039;
			while (true)
			{
				uint num2;
				Color val;
				switch ((num2 = (uint)num ^ 0xD9D39E26u) % 47u)
				{
				case 46u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_52(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Thumb Nail", _poenyHBGUusBcnNcTFB9MQBV72R.smethod_56(opIJo2jLUqdOL5yAFP4yzXce0DG_));
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Phone lines", 1f);
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_52(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Phone lines", _poenyHBGUusBcnNcTFB9MQBV72R.smethod_57(opIJo2jLUqdOL5yAFP4yzXce0DG_));
					num = ((int)num2 * -1160752560) ^ -522199796;
					continue;
				case 45u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Avian Rude", (float)(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_47((Enum)_poenyHBGUusBcnNcTFB9MQBV72R.smethod_46(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.AvianForearm) ? 1 : 0));
					num = -444991666;
					continue;
				case 44u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_52(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Rude", _poenyHBGUusBcnNcTFB9MQBV72R.smethod_51(opIJo2jLUqdOL5yAFP4yzXce0DG_));
					num = (int)((num2 * 3441658) ^ 0x2E3ACF5D);
					continue;
				case 43u:
					if (!(flag2 = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_47((Enum)_poenyHBGUusBcnNcTFB9MQBV72R.smethod_46(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.ShortForearm)))
					{
						num = ((int)num2 * -2071030567) ^ -586183696;
						continue;
					}
					val = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_49(opIJo2jLUqdOL5yAFP4yzXce0DG_);
					goto IL_0110;
				case 42u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Diary", 1f);
					num = (int)((num2 * 1887431387) ^ 0x5024F645);
					continue;
				case 41u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "CONTACTS", 1f);
					num = (int)((num2 * 534141426) ^ 0x6759F57D);
					continue;
				case 40u:
					if (!flag)
					{
						num = ((int)num2 * -1647038157) ^ -1506190706;
						continue;
					}
					val = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_48(opIJo2jLUqdOL5yAFP4yzXce0DG_);
					goto IL_0110;
				case 38u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_52(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Avian Thumb", _poenyHBGUusBcnNcTFB9MQBV72R.smethod_54(opIJo2jLUqdOL5yAFP4yzXce0DG_));
					num = ((int)num2 * -1618539387) ^ 0x2AC7D374;
					continue;
				case 37u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_52(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Avian Rude", _poenyHBGUusBcnNcTFB9MQBV72R.smethod_54(opIJo2jLUqdOL5yAFP4yzXce0DG_));
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Thumb", 1f);
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_52(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Thumb", _poenyHBGUusBcnNcTFB9MQBV72R.smethod_51(opIJo2jLUqdOL5yAFP4yzXce0DG_));
					num = (int)((num2 * 1932505567) ^ 0x45A077FA);
					continue;
				case 36u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "BG AUDIO", 0f);
					num = (int)(num2 * 1162133300) ^ -751126450;
					continue;
				case 35u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_52(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Avian Pinky", _poenyHBGUusBcnNcTFB9MQBV72R.smethod_54(opIJo2jLUqdOL5yAFP4yzXce0DG_));
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Ring", 1f);
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_52(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Ring", _poenyHBGUusBcnNcTFB9MQBV72R.smethod_51(opIJo2jLUqdOL5yAFP4yzXce0DG_));
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Avian ring", (float)(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_47((Enum)_poenyHBGUusBcnNcTFB9MQBV72R.smethod_46(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.AvianForearm) ? 1 : 0));
					num = -1494088623;
					continue;
				case 34u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "BG CHAT SETTINGS", 0f);
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "BG GALLERY", 0f);
					num = ((int)num2 * -815148704) ^ 0x695ED96;
					continue;
				case 33u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Hand", 1f);
					num = ((int)num2 * -719537607) ^ 0x3B1E4EEF;
					continue;
				case 32u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Phone Shadow", 1f);
					num = ((int)num2 * -769224380) ^ -1666682615;
					continue;
				case 31u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Rude", 1f);
					num = ((int)num2 * -1358600444) ^ -1797624760;
					continue;
				case 30u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_52(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Marking Hand", color_);
					num = ((int)num2 * -166352756) ^ 0x1376436;
					continue;
				case 29u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Avian Hand", (float)(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_47((Enum)_poenyHBGUusBcnNcTFB9MQBV72R.smethod_46(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.AvianForearm) ? 1 : 0));
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_52(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Avian Hand", _poenyHBGUusBcnNcTFB9MQBV72R.smethod_54(opIJo2jLUqdOL5yAFP4yzXce0DG_));
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Index", 1f);
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_52(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Index", _poenyHBGUusBcnNcTFB9MQBV72R.smethod_51(opIJo2jLUqdOL5yAFP4yzXce0DG_));
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Avian index", (float)(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_47((Enum)_poenyHBGUusBcnNcTFB9MQBV72R.smethod_46(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.AvianForearm) ? 1 : 0));
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_52(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Avian index", _poenyHBGUusBcnNcTFB9MQBV72R.smethod_54(opIJo2jLUqdOL5yAFP4yzXce0DG_));
					num = -1693034843;
					continue;
				case 28u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Power", 1f);
					num = (int)(num2 * 1370187371) ^ -349835231;
					continue;
				case 27u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_52(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Ring Nail", _poenyHBGUusBcnNcTFB9MQBV72R.smethod_56(opIJo2jLUqdOL5yAFP4yzXce0DG_));
					num = (int)((num2 * 1503880013) ^ 0x33553754);
					continue;
				case 26u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Phone Colour", 1f);
					num = (int)(num2 * 1743109151) ^ -2013451055;
					continue;
				case 25u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "white screen", 1f);
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "black screen", 1f);
					num = ((int)num2 * -447196475) ^ -631597794;
					continue;
				case 23u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_52(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Index Nail", _poenyHBGUusBcnNcTFB9MQBV72R.smethod_56(opIJo2jLUqdOL5yAFP4yzXce0DG_));
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Thumb Nail", (float)(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_55(opIJo2jLUqdOL5yAFP4yzXce0DG_) ? 1 : 0));
					num = -1507371044;
					continue;
				case 22u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "BG POWER", 0f);
					num = (int)((num2 * 274685156) ^ 0x51B08666);
					continue;
				case 21u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_52(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Default Forearm", _poenyHBGUusBcnNcTFB9MQBV72R.smethod_51(opIJo2jLUqdOL5yAFP4yzXce0DG_));
					num = ((int)num2 * -528693302) ^ -813810790;
					continue;
				case 20u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Gallery", 1f);
					num = (int)((num2 * 170867958) ^ 0x6BB739A4);
					continue;
				case 19u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Pinky", 1f);
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_52(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Pinky", _poenyHBGUusBcnNcTFB9MQBV72R.smethod_51(opIJo2jLUqdOL5yAFP4yzXce0DG_));
					num = (int)(num2 * 1578643883) ^ -1789916635;
					continue;
				case 18u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_52(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Avian ring", _poenyHBGUusBcnNcTFB9MQBV72R.smethod_54(opIJo2jLUqdOL5yAFP4yzXce0DG_));
					num = (int)(num2 * 1762371952) ^ -1083076873;
					continue;
				case 17u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Power", 1f);
					num = (int)((num2 * 862638526) ^ 0x705C1A2F);
					continue;
				case 16u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Hoody Sleeve", 0f);
					num = ((int)num2 * -677971159) ^ -186397407;
					continue;
				case 15u:
					val = Color.get_White();
					goto IL_0110;
				case 14u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_52(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Hand", _poenyHBGUusBcnNcTFB9MQBV72R.smethod_51(opIJo2jLUqdOL5yAFP4yzXce0DG_));
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Marking Hand", (float)((flag2 || flag) ? 1 : 0));
					num = -739425532;
					continue;
				case 13u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Phone Default Background", 1f);
					num = (int)((num2 * 2115659084) ^ 0x12F58ABF);
					continue;
				case 12u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Sheen Two", 1f);
					num = ((int)num2 * -3098845) ^ -1983480812;
					continue;
				case 11u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Index Nail", (float)(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_55(opIJo2jLUqdOL5yAFP4yzXce0DG_) ? 1 : 0));
					num = -1152933502;
					continue;
				case 10u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Pinky Nail", (float)(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_55(opIJo2jLUqdOL5yAFP4yzXce0DG_) ? 1 : 0));
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_52(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Pinky Nail", _poenyHBGUusBcnNcTFB9MQBV72R.smethod_56(opIJo2jLUqdOL5yAFP4yzXce0DG_));
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Ring Nail", (float)(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_55(opIJo2jLUqdOL5yAFP4yzXce0DG_) ? 1 : 0));
					num = -635259719;
					continue;
				case 9u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Avian Pinky", (float)(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_47((Enum)_poenyHBGUusBcnNcTFB9MQBV72R.smethod_46(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.AvianForearm) ? 1 : 0));
					num = -962392865;
					continue;
				case 8u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Avian Thumb", (float)(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_47((Enum)_poenyHBGUusBcnNcTFB9MQBV72R.smethod_46(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.AvianForearm) ? 1 : 0));
					num = -1071324376;
					continue;
				case 7u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Avian Forearm", (float)(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_47((Enum)_poenyHBGUusBcnNcTFB9MQBV72R.smethod_46(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.AvianForearm) ? 1 : 0));
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_52(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Avian Forearm", _poenyHBGUusBcnNcTFB9MQBV72R.smethod_54(opIJo2jLUqdOL5yAFP4yzXce0DG_));
					num = -629930489;
					continue;
				case 6u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "BG CONTACTS", 0f);
					num = ((int)num2 * -165662128) ^ -890221314;
					continue;
				case 5u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Chat Settings", 1f);
					num = (int)(num2 * 358887175) ^ -959103873;
					continue;
				case 4u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "BG DIARY", 0f);
					num = (int)((num2 * 1686051750) ^ 0x44CD4C2C);
					continue;
				case 3u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Marking Forearm", (float)((flag2 || flag) ? 1 : 0));
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_52(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Marking Forearm", color_);
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Striped forearm", (float)(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_47((Enum)_poenyHBGUusBcnNcTFB9MQBV72R.smethod_46(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Stripes) ? 1 : 0));
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_52(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Striped forearm", _poenyHBGUusBcnNcTFB9MQBV72R.smethod_53(opIJo2jLUqdOL5yAFP4yzXce0DG_));
					num = -711947607;
					continue;
				case 2u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Rude Nail", (float)(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_55(opIJo2jLUqdOL5yAFP4yzXce0DG_) ? 1 : 0));
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_52(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Rude Nail", _poenyHBGUusBcnNcTFB9MQBV72R.smethod_56(opIJo2jLUqdOL5yAFP4yzXce0DG_));
					num = -659772158;
					continue;
				case 1u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Default Forearm", 1f);
					num = (int)(num2 * 333456045) ^ -1256749157;
					continue;
				case 0u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_50(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Audio", 1f);
					num = ((int)num2 * -1141812432) ^ 0x7D3368FC;
					continue;
				case 39u:
					break;
				default:
					{
						_IiWYS6YP6cEj83PIAXepbAHBaJB();
						return;
					}
					IL_0110:
					color_ = val;
					num = -2063539131;
					continue;
				}
				break;
			}
		}
	}

	private void _IiWYS6YP6cEj83PIAXepbAHBaJB()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG_ = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_19();
		_poenyHBGUusBcnNcTFB9MQBV72R.smethod_52(_lpMGMQZJYmHr6q9XBRwiM0Lse4N, "Phone", _poenyHBGUusBcnNcTFB9MQBV72R.smethod_57(opIJo2jLUqdOL5yAFP4yzXce0DG_));
	}

	public static _poenyHBGUusBcnNcTFB9MQBV72R _AZrO8MxMUE7cKsFYTQ4k9O3q7yC()
	{
		return _6T55wit7MiGfAWRkPwjNbJ8N8lG;
	}

	private void _3mKo17hkpGwyDp6sHVZAhV1c6Qv(_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts ephoneContacts_0)
	{
		_rASuGHWSFVWfkpwzF8wZd9bh3XN = false;
		using (List<string>.Enumerator enumerator = _PcaKA8lfkZnYKjOTdM7RWYPBlGr.Keys.ToList().GetEnumerator())
		{
			string current = default(string);
			while (true)
			{
				IL_008e:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = 1133300084;
					num2 = 1133300084;
				}
				else
				{
					num = 548196986;
					num2 = 548196986;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x439DA6CDu) % 5u)
					{
					case 2u:
						current = enumerator.Current;
						num = 1177033387;
						continue;
					case 1u:
						_PcaKA8lfkZnYKjOTdM7RWYPBlGr[current] = false;
						num = ((int)num3 * -496123384) ^ 0x6F48B367;
						continue;
					case 0u:
						num = 548196986;
						continue;
					default:
						goto end_IL_005d;
					case 4u:
						break;
					case 3u:
						goto end_IL_005d;
					}
					goto IL_008e;
					continue;
					end_IL_005d:
					break;
				}
				break;
			}
		}
		if (ephoneContacts_0 == _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Lex)
		{
			goto IL_00b4;
		}
		goto IL_0148;
		IL_00b4:
		int num4 = 1479651068;
		goto IL_011f;
		IL_0148:
		_PcaKA8lfkZnYKjOTdM7RWYPBlGr[ephoneContacts_0.ToString()] = true;
		num4 = 842093135;
		goto IL_011f;
		IL_011f:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num4 ^ 0x439DA6CDu) % 6u)
			{
			case 5u:
				break;
			case 2u:
				_PcaKA8lfkZnYKjOTdM7RWYPBlGr[_poenyHBGUusBcnNcTFB9MQBV72R.smethod_4(ephoneContacts_0.ToString(), " image")] = true;
				num4 = (int)((num3 * 732569103) ^ 0x37EC6D9);
				continue;
			case 1u:
				_PcaKA8lfkZnYKjOTdM7RWYPBlGr["Alex"] = true;
				_PcaKA8lfkZnYKjOTdM7RWYPBlGr["Alex image"] = true;
				num4 = (int)((num3 * 1511911468) ^ 0x150AFD9);
				continue;
			default:
				return;
			case 3u:
				goto IL_0148;
			case 0u:
				return;
			case 4u:
				return;
			}
			break;
		}
		goto IL_00b4;
	}

	private void _8hw6Dkw1FlTEpsiy0adBUXTGpRe(bool bool_0)
	{
		_0OvMkQYTGPrNhckv6iHt3zmR5ni["reject call with message"] = bool_0;
		_0OvMkQYTGPrNhckv6iHt3zmR5ni["Incoming call"] = bool_0;
	}

	public void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0, _wRd4nHuQQlAPEwrHOGkBfut6Uip _wRd4nHuQQlAPEwrHOGkBfut6Uip_0)
	{
		if (!_poenyHBGUusBcnNcTFB9MQBV72R.smethod_59(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_58(_4L7hfXrWoDdArQiscG4ukHCV46B), (Keys)27))
		{
			goto IL_0066;
		}
		goto IL_0177;
		IL_0177:
		_Oewx0FJJ8VX41Prmv0htvGQZhUf();
		int num = -311469264;
		goto IL_013d;
		IL_013d:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xF32AA033u) % 10u)
			{
			case 9u:
				_poenyHBGUusBcnNcTFB9MQBV72R.smethod_60(_wTbB4YBL4PSkaotwKX3CFc50DmX, gameTime_0, 1000f);
				_D1T6p91T7mKeglw2nCBqHjNgzfB();
				_48sn09DNztKRWaadCpDeWr57ENW(_wRd4nHuQQlAPEwrHOGkBfut6Uip_0);
				num = ((int)num2 * -767882984) ^ 0x3329232C;
				continue;
			case 8u:
				_poenyHBGUusBcnNcTFB9MQBV72R.smethod_61(_9GQBAH2pi8Sm6ph1s6InjyQGe6R);
				num = (int)((num2 * 1783414303) ^ 0x2064D459);
				continue;
			case 7u:
				break;
			case 6u:
			{
				int num5;
				int num6;
				if (!_poenyHBGUusBcnNcTFB9MQBV72R.smethod_59(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_58(_4L7hfXrWoDdArQiscG4ukHCV46B), (Keys)160))
				{
					num5 = -1346294680;
					num6 = -1346294680;
				}
				else
				{
					num5 = -349821656;
					num6 = -349821656;
				}
				num = num5 ^ (int)(num2 * 2108675324);
				continue;
			}
			case 5u:
				_Xgbbx1uIlIM4mSecGPtARNWvSMm(_wRd4nHuQQlAPEwrHOGkBfut6Uip_0);
				num = ((int)num2 * -1069682265) ^ 0x292085C8;
				continue;
			case 4u:
				_poenyHBGUusBcnNcTFB9MQBV72R.smethod_60(_lpMGMQZJYmHr6q9XBRwiM0Lse4N, gameTime_0, 1000f);
				num = ((int)num2 * -1801197558) ^ 0x2D80371C;
				continue;
			case 3u:
				_poenyHBGUusBcnNcTFB9MQBV72R.smethod_60(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, gameTime_0, (_poenyHBGUusBcnNcTFB9MQBV72R.smethod_5(_4L7hfXrWoDdArQiscG4ukHCV46B) != null || !_flEA1zdf7DHRkPwzrlsWVEAXZiX) ? 1000f : _rLwDc2UH4fLL9at0M4SCKf0SG8cA);
				num = -560175241;
				continue;
			case 0u:
			{
				int num3;
				int num4;
				if (_Ldzm1JY9st4tknAhrglOIpwdYhn)
				{
					num3 = 419243551;
					num4 = 419243551;
				}
				else
				{
					num3 = 1509277001;
					num4 = 1509277001;
				}
				num = num3 ^ (int)(num2 * 1365580166);
				continue;
			}
			default:
				return;
			case 1u:
				goto IL_0177;
			case 2u:
				return;
			}
			break;
		}
		goto IL_0066;
		IL_0066:
		num = -761258343;
		goto IL_013d;
	}

	private void _D1T6p91T7mKeglw2nCBqHjNgzfB()
	{
		if (_TZx1AkahTLXoM2XUbm5U8YJOScb)
		{
			goto IL_012c;
		}
		goto IL_018a;
		IL_018a:
		int num;
		int num2;
		if (!_WaCCr2ToiTDglrrE9z1EKOcLzT3)
		{
			num = 199594258;
			num2 = 199594258;
		}
		else
		{
			num = 1677286279;
			num2 = 1677286279;
		}
		goto IL_0131;
		IL_0131:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0x719263EDu) % 14u)
			{
			case 12u:
				_poenyHBGUusBcnNcTFB9MQBV72R.smethod_1(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Arm rise", (Action)delegate
				{
					_TZx1AkahTLXoM2XUbm5U8YJOScb = false;
					while (true)
					{
						int num5 = 1466619539;
						while (true)
						{
							uint num6;
							switch ((num6 = (uint)num5 ^ 0x60C2C310u) % 4u)
							{
							case 3u:
								_j2OEvLQtM2lODSmH3ZFP6wWCWpF = _fFGgY4gvWNcTLSlsfe9k99ctumb.ArmUp;
								num5 = (int)(num6 * 1700371272) ^ -1922565787;
								continue;
							case 1u:
								_aEgXugtdIuFieAwnDhnIlYNEysg();
								num5 = (int)((num6 * 406043222) ^ 0xE3A8C4);
								continue;
							default:
								return;
							case 0u:
								break;
							case 2u:
								return;
							}
							break;
						}
					}
				});
				num = (int)((num3 * 411504932) ^ 0x60474AE1);
				continue;
			case 9u:
				_TZx1AkahTLXoM2XUbm5U8YJOScb = true;
				num = ((int)num3 * -731702973) ^ 0x1D5F2465;
				continue;
			case 8u:
				_p4cbe03cXPNybrHUo9DHRTp6W7m = false;
				num = (int)(num3 * 705678753) ^ -2074484910;
				continue;
			case 7u:
				_flEA1zdf7DHRkPwzrlsWVEAXZiX = false;
				num = ((int)num3 * -93789054) ^ -450703977;
				continue;
			case 6u:
				_WaCCr2ToiTDglrrE9z1EKOcLzT3 = false;
				num = ((int)num3 * -411793563) ^ -1898924879;
				continue;
			case 4u:
				_TZx1AkahTLXoM2XUbm5U8YJOScb = true;
				num = ((int)num3 * -1320674301) ^ 0x58089D4D;
				continue;
			case 3u:
				_poenyHBGUusBcnNcTFB9MQBV72R.smethod_1(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Arm lower", (Action)delegate
				{
					_TZx1AkahTLXoM2XUbm5U8YJOScb = false;
					_j2OEvLQtM2lODSmH3ZFP6wWCWpF = _fFGgY4gvWNcTLSlsfe9k99ctumb.ArmDown;
				});
				num = (int)(num3 * 1595819729) ^ -431543639;
				continue;
			case 2u:
				_flEA1zdf7DHRkPwzrlsWVEAXZiX = false;
				num = ((int)num3 * -1128402484) ^ 0x5B61177B;
				continue;
			case 1u:
				break;
			case 0u:
				goto end_IL_0131;
			default:
				return;
			case 13u:
				goto IL_018a;
			case 5u:
				return;
			case 10u:
				return;
			case 11u:
				return;
			}
			int num4;
			if (_p4cbe03cXPNybrHUo9DHRTp6W7m)
			{
				num = 1108742264;
				num4 = 1108742264;
			}
			else
			{
				num = 2140278844;
				num4 = 2140278844;
			}
			continue;
			end_IL_0131:
			break;
		}
		goto IL_012c;
		IL_012c:
		num = 1774746726;
		goto IL_0131;
	}

	private void _48sn09DNztKRWaadCpDeWr57ENW(_wRd4nHuQQlAPEwrHOGkBfut6Uip _wRd4nHuQQlAPEwrHOGkBfut6Uip_0)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		if (_f2smFxmYyFJyj81xWGaGLB2G7ef == _wlQdV74JhqkBVxNonpbfqZEmjIbA.None)
		{
			return;
		}
		while (true)
		{
			int num = -1746173148;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8AD888D0u) % 16u)
				{
				case 15u:
				{
					int num12;
					if (!_tIOoXRaaichIzSVUOs5dNLciPbw)
					{
						num = -219829700;
						num12 = -219829700;
					}
					else
					{
						num = -407134967;
						num12 = -407134967;
					}
					continue;
				}
				case 14u:
					_tIOoXRaaichIzSVUOs5dNLciPbw = false;
					num = -219829700;
					continue;
				case 13u:
				{
					int num10;
					int num11;
					if (_j2OEvLQtM2lODSmH3ZFP6wWCWpF == _fFGgY4gvWNcTLSlsfe9k99ctumb.ArmDownRequested)
					{
						num10 = 1355796291;
						num11 = 1355796291;
					}
					else
					{
						num10 = 586116933;
						num11 = 586116933;
					}
					num = num10 ^ (int)(num2 * 174726567);
					continue;
				}
				case 11u:
					_Oewx0FJJ8VX41Prmv0htvGQZhUf();
					num = (int)(num2 * 709740943) ^ -1006293851;
					continue;
				case 9u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_52(_lpMGMQZJYmHr6q9XBRwiM0Lse4N, "Phone", _poenyHBGUusBcnNcTFB9MQBV72R.smethod_57(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_19()));
					num = ((int)num2 * -1012307649) ^ -703732382;
					continue;
				case 8u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_10(bool_0: false);
					num = -1653156162;
					continue;
				case 7u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_52(_lpMGMQZJYmHr6q9XBRwiM0Lse4N, "Phone", Color.get_Red());
					num = (int)((num2 * 524204908) ^ 0x100933E2);
					continue;
				case 6u:
				{
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_10(bool_0: true);
					int num6;
					int num7;
					if (_poenyHBGUusBcnNcTFB9MQBV72R.smethod_65(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_58(_4L7hfXrWoDdArQiscG4ukHCV46B), _PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton))
					{
						num6 = 464618239;
						num7 = 464618239;
					}
					else
					{
						num6 = 79863716;
						num7 = 79863716;
					}
					num = num6 ^ (int)(num2 * 803012102);
					continue;
				}
				case 5u:
				{
					int num13;
					int num14;
					if (_j2OEvLQtM2lODSmH3ZFP6wWCWpF == _fFGgY4gvWNcTLSlsfe9k99ctumb.ArmDown)
					{
						num13 = -278096828;
						num14 = -278096828;
					}
					else
					{
						num13 = -519145055;
						num14 = -519145055;
					}
					num = num13 ^ (int)(num2 * 1834067212);
					continue;
				}
				case 4u:
				{
					int num8;
					int num9;
					if (_poenyHBGUusBcnNcTFB9MQBV72R.smethod_5(_4L7hfXrWoDdArQiscG4ukHCV46B) == null)
					{
						num8 = -1251445814;
						num9 = -1251445814;
					}
					else
					{
						num8 = -1515189621;
						num9 = -1515189621;
					}
					num = num8 ^ (int)(num2 * 1932476482);
					continue;
				}
				case 2u:
				{
					int num4;
					int num5;
					if (_3AaEmo54VzWybgrrg7I8Z9JUV1e)
					{
						num4 = 681682215;
						num5 = 681682215;
					}
					else
					{
						num4 = 1557133445;
						num5 = 1557133445;
					}
					num = num4 ^ ((int)num2 * -2113034446);
					continue;
				}
				case 1u:
				{
					Point val = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_63(_wRd4nHuQQlAPEwrHOGkBfut6Uip_0, _poenyHBGUusBcnNcTFB9MQBV72R.smethod_62(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_58(_4L7hfXrWoDdArQiscG4ukHCV46B)));
					int num3;
					if (_poenyHBGUusBcnNcTFB9MQBV72R.smethod_64(_lpMGMQZJYmHr6q9XBRwiM0Lse4N, "Phone", (float)val.X, (float)val.Y))
					{
						num = -1029358457;
						num3 = -1029358457;
					}
					else
					{
						num = -600564817;
						num3 = -600564817;
					}
					continue;
				}
				default:
					return;
				case 10u:
					break;
				case 0u:
					_tIOoXRaaichIzSVUOs5dNLciPbw = true;
					return;
				case 12u:
					return;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	private void _Xgbbx1uIlIM4mSecGPtARNWvSMm(_wRd4nHuQQlAPEwrHOGkBfut6Uip _wRd4nHuQQlAPEwrHOGkBfut6Uip_0)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
		if (_j2OEvLQtM2lODSmH3ZFP6wWCWpF != _fFGgY4gvWNcTLSlsfe9k99ctumb.ArmUp)
		{
			return;
		}
		Point val = default(Point);
		bool flag = default(bool);
		while (true)
		{
			int num = -1089423733;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDBA9DEAFu) % 38u)
				{
				case 37u:
				{
					int num20;
					int num21;
					if (_poenyHBGUusBcnNcTFB9MQBV72R.smethod_65(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_58(_4L7hfXrWoDdArQiscG4ukHCV46B), _PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton))
					{
						num20 = -1651119374;
						num21 = -1651119374;
					}
					else
					{
						num20 = -1335330732;
						num21 = -1335330732;
					}
					num = num20 ^ (int)(num2 * 1026664270);
					continue;
				}
				case 36u:
					_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.Audio);
					num = (int)((num2 * 144425646) ^ 0x507A2513);
					continue;
				case 35u:
					_270ZVixWLhgEiLA6QosapJMyU6h();
					num = -1772522075;
					continue;
				case 34u:
				{
					int num14;
					if (_poenyHBGUusBcnNcTFB9MQBV72R.smethod_64(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Chat Settings", (float)val.X, (float)val.Y))
					{
						num = -1162818039;
						num14 = -1162818039;
					}
					else
					{
						num = -682739883;
						num14 = -682739883;
					}
					continue;
				}
				case 32u:
				{
					int num23;
					int num24;
					if (_poenyHBGUusBcnNcTFB9MQBV72R.smethod_5(_4L7hfXrWoDdArQiscG4ukHCV46B) == null)
					{
						num23 = 1448797311;
						num24 = 1448797311;
					}
					else
					{
						num23 = 1657934428;
						num24 = 1657934428;
					}
					num = num23 ^ ((int)num2 * -622557215);
					continue;
				}
				case 31u:
					_270ZVixWLhgEiLA6QosapJMyU6h();
					num = (int)((num2 * 1159001619) ^ 0x483BC845);
					continue;
				case 30u:
					num = ((int)num2 * -1505672376) ^ -1218996102;
					continue;
				case 28u:
				{
					int num9;
					if (!_poenyHBGUusBcnNcTFB9MQBV72R.smethod_64(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Phone Default Background", (float)val.X, (float)val.Y))
					{
						num = -2107644211;
						num9 = -2107644211;
					}
					else
					{
						num = -2109905494;
						num9 = -2109905494;
					}
					continue;
				}
				case 27u:
					_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.Gallery);
					num = (int)((num2 * 1872765712) ^ 0x4FE805D5);
					continue;
				case 26u:
					flag = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_64(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Phone Colour", (float)val.X, (float)val.Y);
					num = (int)(num2 * 1871619099) ^ -1875078647;
					continue;
				case 25u:
					_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.Contacts);
					num = ((int)num2 * -1411681692) ^ 0x5ABA069E;
					continue;
				case 24u:
					_rLwDc2UH4fLL9at0M4SCKf0SG8cA = (flag ? 5000f : 1000f);
					num = -1531426068;
					continue;
				case 23u:
					num = ((int)num2 * -1231416777) ^ -1547959121;
					continue;
				case 22u:
					num = (int)(num2 * 877639566) ^ -212946294;
					continue;
				case 21u:
				{
					int num15;
					if (_poenyHBGUusBcnNcTFB9MQBV72R.smethod_64(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Phone Default Background", (float)val.X, (float)val.Y))
					{
						num = -2109905494;
						num15 = -2109905494;
					}
					else
					{
						num = -1009710438;
						num15 = -1009710438;
					}
					continue;
				}
				case 19u:
				{
					int num11;
					if (_poenyHBGUusBcnNcTFB9MQBV72R.smethod_64(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Audio", (float)val.X, (float)val.Y))
					{
						num = -534793593;
						num11 = -534793593;
					}
					else
					{
						num = -1090418267;
						num11 = -1090418267;
					}
					continue;
				}
				case 18u:
					_RiDuYMeg3EHnBUteUcAb8VlfQVl();
					num = (int)(num2 * 1653807711) ^ -585985853;
					continue;
				case 17u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -298744994;
						num6 = -298744994;
					}
					else
					{
						num5 = -1223877443;
						num6 = -1223877443;
					}
					num = num5 ^ ((int)num2 * -1477956344);
					continue;
				}
				case 16u:
					num = (int)((num2 * 292268238) ^ 0x1CF2BC66);
					continue;
				case 15u:
				{
					int num22;
					if (_poenyHBGUusBcnNcTFB9MQBV72R.smethod_64(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Diary", (float)val.X, (float)val.Y))
					{
						num = -2146932578;
						num22 = -2146932578;
					}
					else
					{
						num = -759168126;
						num22 = -759168126;
					}
					continue;
				}
				case 14u:
				{
					int num19;
					if (_poenyHBGUusBcnNcTFB9MQBV72R.smethod_64(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Gallery", (float)val.X, (float)val.Y))
					{
						num = -1047930622;
						num19 = -1047930622;
					}
					else
					{
						num = -1976712431;
						num19 = -1976712431;
					}
					continue;
				}
				case 13u:
					_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.Diary);
					num = (int)(num2 * 320485007) ^ -26226176;
					continue;
				case 12u:
					_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.ChatSettings);
					num = (int)((num2 * 1199311876) ^ 0x49A96F32);
					continue;
				case 11u:
				{
					int num18;
					if (_poenyHBGUusBcnNcTFB9MQBV72R.smethod_65(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_58(_4L7hfXrWoDdArQiscG4ukHCV46B), _PMeRYZJaBCqgB9uADJFP3c14lxq.RightButton))
					{
						num = -1143180932;
						num18 = -1143180932;
					}
					else
					{
						num = -1772522075;
						num18 = -1772522075;
					}
					continue;
				}
				case 10u:
					num = ((int)num2 * -1233971611) ^ -1720360298;
					continue;
				case 9u:
					num = (int)((num2 * 1966509087) ^ 0x7E7BAB91);
					continue;
				case 8u:
				{
					int num16;
					int num17;
					if (_poenyHBGUusBcnNcTFB9MQBV72R.smethod_64(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "CONTACTS", (float)val.X, (float)val.Y))
					{
						num16 = 1292605196;
						num17 = 1292605196;
					}
					else
					{
						num16 = 1386466450;
						num17 = 1386466450;
					}
					num = num16 ^ ((int)num2 * -1412627907);
					continue;
				}
				case 7u:
				{
					int num12;
					int num13;
					if (_saaJnL0DI6B89XWRulJZ4KC1I1g == _VQgRlkt1vazuo2KaxFIrSVwZOpL.Home)
					{
						num12 = 1701197664;
						num13 = 1701197664;
					}
					else
					{
						num12 = 462157555;
						num13 = 462157555;
					}
					num = num12 ^ ((int)num2 * -1741279213);
					continue;
				}
				case 6u:
				{
					int num10;
					if (_poenyHBGUusBcnNcTFB9MQBV72R.smethod_64(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Power", (float)val.X, (float)val.Y))
					{
						num = -900698500;
						num10 = -900698500;
					}
					else
					{
						num = -1935897589;
						num10 = -1935897589;
					}
					continue;
				}
				case 5u:
					_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.Power);
					num = ((int)num2 * -1821302033) ^ -150946575;
					continue;
				case 4u:
					_RiDuYMeg3EHnBUteUcAb8VlfQVl();
					num = ((int)num2 * -1060581379) ^ 0x2152E45F;
					continue;
				case 3u:
				{
					int num7;
					int num8;
					if (_saaJnL0DI6B89XWRulJZ4KC1I1g != 0)
					{
						num7 = -1276457843;
						num8 = -1276457843;
					}
					else
					{
						num7 = -1791513098;
						num8 = -1791513098;
					}
					num = num7 ^ (int)(num2 * 472681705);
					continue;
				}
				case 2u:
				{
					int num3;
					int num4;
					if (!_3AaEmo54VzWybgrrg7I8Z9JUV1e)
					{
						num3 = -608246642;
						num4 = -608246642;
					}
					else
					{
						num3 = -1935701216;
						num4 = -1935701216;
					}
					num = num3 ^ ((int)num2 * -977282514);
					continue;
				}
				case 1u:
					val = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_63(_wRd4nHuQQlAPEwrHOGkBfut6Uip_0, _poenyHBGUusBcnNcTFB9MQBV72R.smethod_62(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_58(_4L7hfXrWoDdArQiscG4ukHCV46B)));
					num = -2053040279;
					continue;
				default:
					return;
				case 29u:
					break;
				case 0u:
					return;
				case 20u:
					return;
				case 33u:
					return;
				}
				break;
			}
		}
	}

	public void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0)
	{
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		_7ogzNGSGXiMOYh3BcasDaqG9WpT _7ogzNGSGXiMOYh3BcasDaqG9WpT = new _7ogzNGSGXiMOYh3BcasDaqG9WpT();
		RenderTargetBinding[] renderTargetBinding_ = default(RenderTargetBinding[]);
		_HQitgQ0mYB5XukcD7eKHBJPmdqs hQitgQ0mYB5XukcD7eKHBJPmdqs = default(_HQitgQ0mYB5XukcD7eKHBJPmdqs);
		while (true)
		{
			int num = -1336693293;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAAE6C823u) % 17u)
				{
				case 16u:
				{
					int num5;
					int num6;
					if (_j2OEvLQtM2lODSmH3ZFP6wWCWpF == _fFGgY4gvWNcTLSlsfe9k99ctumb.ArmUp)
					{
						num5 = 1745695099;
						num6 = 1745695099;
					}
					else
					{
						num5 = 1488236873;
						num6 = 1488236873;
					}
					num = num5 ^ ((int)num2 * -1425913781);
					continue;
				}
				case 15u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_71(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_66(_4L7hfXrWoDdArQiscG4ukHCV46B), renderTargetBinding_);
					num = ((int)num2 * -2139529720) ^ -1654059079;
					continue;
				case 14u:
					hQitgQ0mYB5XukcD7eKHBJPmdqs = new _HQitgQ0mYB5XukcD7eKHBJPmdqs();
					hQitgQ0mYB5XukcD7eKHBJPmdqs._wr6xcvFOgUbaTATC17S6Y9v3y3S = _7ogzNGSGXiMOYh3BcasDaqG9WpT;
					renderTargetBinding_ = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_67(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_66(_4L7hfXrWoDdArQiscG4ukHCV46B));
					num = -299780681;
					continue;
				case 13u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_68(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_66(_4L7hfXrWoDdArQiscG4ukHCV46B), _bZJtpWV2Yj6GgZkeZQUmpTHxTnh);
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_69(_9GQBAH2pi8Sm6ph1s6InjyQGe6R);
					num = (int)(num2 * 785587950) ^ -1965971803;
					continue;
				case 10u:
					_7ogzNGSGXiMOYh3BcasDaqG9WpT._EKVVcDQFi8O0uiXnuvUCgwRPdh4 = spriteBatch_0;
					num = (int)(num2 * 1856552045) ^ -1423483904;
					continue;
				case 9u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_70(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, hQitgQ0mYB5XukcD7eKHBJPmdqs._wr6xcvFOgUbaTATC17S6Y9v3y3S._r1FADOtDcwMP4Tohv3ntBfhuMNp, (Texture2D)null, (Func<int, string, bool>)hQitgQ0mYB5XukcD7eKHBJPmdqs._J03dD2qBGOpQ04m2KKxkL3CkUtCb, (Color?)null, 1f);
					num = ((int)num2 * -1446371603) ^ 0x6A702357;
					continue;
				case 8u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_70(_lpMGMQZJYmHr6q9XBRwiM0Lse4N, _7ogzNGSGXiMOYh3BcasDaqG9WpT._r1FADOtDcwMP4Tohv3ntBfhuMNp, (Texture2D)null, (Func<int, string, bool>)null, (Color?)null, 1f);
					num = ((int)num2 * -861825580) ^ -1993641779;
					continue;
				case 7u:
					hQitgQ0mYB5XukcD7eKHBJPmdqs._eeWHzOz6LrTokRQr52VaB0dKbQO = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_72(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Sheen Two", ref hQitgQ0mYB5XukcD7eKHBJPmdqs._09rdYyvQzUwbdQbzRZF4vbpdUCO);
					num = (int)((num2 * 1290686895) ^ 0x7C05DCE3);
					continue;
				case 6u:
				{
					int num10;
					if (_2xrvCNtGtRPjKFYKw9nbGLrJCPy == _wlQdV74JhqkBVxNonpbfqZEmjIbA.None)
					{
						num = -49585027;
						num10 = -49585027;
					}
					else
					{
						num = -1006461575;
						num10 = -1006461575;
					}
					continue;
				}
				case 5u:
				{
					int num9;
					if (_TZx1AkahTLXoM2XUbm5U8YJOScb)
					{
						num = -1507029157;
						num9 = -1507029157;
					}
					else
					{
						num = -913019325;
						num9 = -913019325;
					}
					continue;
				}
				case 4u:
					_7ogzNGSGXiMOYh3BcasDaqG9WpT._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = this;
					_7ogzNGSGXiMOYh3BcasDaqG9WpT._r1FADOtDcwMP4Tohv3ntBfhuMNp = skeletonMeshRenderer_0;
					num = ((int)num2 * -1861035942) ^ 0x89011B6;
					continue;
				case 3u:
				{
					int num7;
					int num8;
					if (_poenyHBGUusBcnNcTFB9MQBV72R.smethod_5(_4L7hfXrWoDdArQiscG4ukHCV46B) != null)
					{
						num7 = 1091573937;
						num8 = 1091573937;
					}
					else
					{
						num7 = 1004370451;
						num8 = 1004370451;
					}
					num = num7 ^ ((int)num2 * -1157719362);
					continue;
				}
				case 1u:
				{
					int num3;
					int num4;
					if (!_kf3EbE0B70xGe1szklqAZyCqoLj)
					{
						num3 = 879901974;
						num4 = 879901974;
					}
					else
					{
						num3 = 1905381386;
						num4 = 1905381386;
					}
					num = num3 ^ ((int)num2 * -868948070);
					continue;
				}
				case 0u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_68(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_66(_4L7hfXrWoDdArQiscG4ukHCV46B), _Pfaq6ajchxcqF6GecivHvHqQW6M);
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_70(_wTbB4YBL4PSkaotwKX3CFc50DmX, hQitgQ0mYB5XukcD7eKHBJPmdqs._wr6xcvFOgUbaTATC17S6Y9v3y3S._r1FADOtDcwMP4Tohv3ntBfhuMNp, (Texture2D)null, (Func<int, string, bool>)delegate(int int_0, string string_0)
					{
						if (hQitgQ0mYB5XukcD7eKHBJPmdqs._wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._PcaKA8lfkZnYKjOTdM7RWYPBlGr.ContainsKey(string_0))
						{
							goto IL_0022;
						}
						goto IL_0056;
						IL_0056:
						int num11;
						int num12;
						if (!hQitgQ0mYB5XukcD7eKHBJPmdqs._wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._0OvMkQYTGPrNhckv6iHt3zmR5ni.ContainsKey(string_0))
						{
							num11 = 1671723878;
							num12 = 1671723878;
						}
						else
						{
							num11 = 413607980;
							num12 = 413607980;
						}
						goto IL_0027;
						IL_0027:
						switch ((uint)(num11 ^ 0x32C4C508) % 5u)
						{
						case 0u:
							break;
						case 1u:
							goto IL_0056;
						default:
							return true;
						case 3u:
							return hQitgQ0mYB5XukcD7eKHBJPmdqs._wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._PcaKA8lfkZnYKjOTdM7RWYPBlGr[string_0];
						case 4u:
							return hQitgQ0mYB5XukcD7eKHBJPmdqs._wr6xcvFOgUbaTATC17S6Y9v3y3S._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._0OvMkQYTGPrNhckv6iHt3zmR5ni[string_0];
						}
						goto IL_0022;
						IL_0022:
						num11 = 1817920988;
						goto IL_0027;
					}, (Color?)null, 1f);
					num = ((int)num2 * -50509926) ^ 0x6C79D639;
					continue;
				default:
					return;
				case 2u:
					break;
				case 11u:
					return;
				case 12u:
					return;
				}
				break;
			}
		}
	}

	static _poenyHBGUusBcnNcTFB9MQBV72R()
	{
		while (true)
		{
			int num = -1033473374;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEF589DF7u) % 4u)
				{
				case 3u:
					_HzpuNgBJAQYObWMhiboQRiPGmvp = new string[4] { "Pinky Nail", "Ring Nail", "Rude Nail", "Index Nail" };
					num = ((int)num2 * -1829772931) ^ -918177664;
					continue;
				case 1u:
					_I35ziY7HYJkfL20RDXWOC7Pcv1q = new string[4] { "Nude1", "Nude2", "Nude3", "Nude4" };
					num = (int)((num2 * 196185129) ^ 0x2DB2E609);
					continue;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	[CompilerGenerated]
	private void _uq8Rq4GCuGQy4QGu9s3PYE9GgHe()
	{
		_poenyHBGUusBcnNcTFB9MQBV72R.smethod_2(_wTbB4YBL4PSkaotwKX3CFc50DmX, "Phone answer loop", (Action<int>)null);
	}

	[CompilerGenerated]
	private void _7nfe928NPd9KPPArPJXBbNyTOZs()
	{
		_poenyHBGUusBcnNcTFB9MQBV72R.smethod_2(_wTbB4YBL4PSkaotwKX3CFc50DmX, "Phone IM idle", (Action<int>)null);
	}

	[CompilerGenerated]
	private void _oqZbZwE9tOfcSkViZ6NnriagwvN()
	{
		_poenyHBGUusBcnNcTFB9MQBV72R.smethod_2(_wTbB4YBL4PSkaotwKX3CFc50DmX, "Phone Call loop", (Action<int>)null);
	}

	[CompilerGenerated]
	private void _z7L2U9Tw7bWomxTCk7o4hq5lAmB()
	{
		_poenyHBGUusBcnNcTFB9MQBV72R.smethod_2(_wTbB4YBL4PSkaotwKX3CFc50DmX, "Phone IM idle", (Action<int>)null);
	}

	[CompilerGenerated]
	private void _ytMjqwjM52ILF41QLZdCgmhyf8D()
	{
		_poenyHBGUusBcnNcTFB9MQBV72R.smethod_2(_wTbB4YBL4PSkaotwKX3CFc50DmX, "Phone Call loop", (Action<int>)null);
	}

	[CompilerGenerated]
	private void _zE6Dh759IY2DMju31JJJ4eLOlPs(Control control_0, MouseEventArgs mouseEventArgs_0)
	{
		_3AaEmo54VzWybgrrg7I8Z9JUV1e = true;
		_poenyHBGUusBcnNcTFB9MQBV72R.smethod_73(_9GQBAH2pi8Sm6ph1s6InjyQGe6R, _poenyHBGUusBcnNcTFB9MQBV72R.smethod_44("Are you sure you wish to remove {0}? This will reset all progression!", (object)_H6UwM4zjGzglzMY478iBDDvTk6I), new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, 250, (Action<int>)delegate(int int_0)
		{
			if (int_0 == 1)
			{
				goto IL_006f;
			}
			goto IL_009d;
			IL_009d:
			_270ZVixWLhgEiLA6QosapJMyU6h();
			int num = -1472990853;
			goto IL_0074;
			IL_0074:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDA213B1Bu) % 6u)
				{
				case 5u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_74(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_19(), _H6UwM4zjGzglzMY478iBDDvTk6I);
					num = ((int)num2 * -1504968640) ^ -671097885;
					continue;
				case 2u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_45(_9GQBAH2pi8Sm6ph1s6InjyQGe6R, _poenyHBGUusBcnNcTFB9MQBV72R.smethod_44("{0} will be available again after you went home.", (object)_H6UwM4zjGzglzMY478iBDDvTk6I), 250, "OK", (Action)delegate
					{
						_270ZVixWLhgEiLA6QosapJMyU6h();
						_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
					});
					num = (int)((num2 * 204193980) ^ 0x6D0E3DB6);
					continue;
				case 0u:
					break;
				case 1u:
					goto IL_009d;
				case 3u:
					return;
				default:
					_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
					return;
				}
				break;
			}
			goto IL_006f;
			IL_006f:
			num = -174232024;
			goto IL_0074;
		});
	}

	[CompilerGenerated]
	private void _7FN07CzDf8Fapy4eUp1zYFqADbC(int int_0)
	{
		if (int_0 == 1)
		{
			goto IL_006f;
		}
		goto IL_009d;
		IL_009d:
		_270ZVixWLhgEiLA6QosapJMyU6h();
		int num = -1472990853;
		goto IL_0074;
		IL_0074:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xDA213B1Bu) % 6u)
			{
			case 5u:
				_poenyHBGUusBcnNcTFB9MQBV72R.smethod_74(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_19(), _H6UwM4zjGzglzMY478iBDDvTk6I);
				num = ((int)num2 * -1504968640) ^ -671097885;
				continue;
			case 2u:
				_poenyHBGUusBcnNcTFB9MQBV72R.smethod_45(_9GQBAH2pi8Sm6ph1s6InjyQGe6R, _poenyHBGUusBcnNcTFB9MQBV72R.smethod_44("{0} will be available again after you went home.", (object)_H6UwM4zjGzglzMY478iBDDvTk6I), 250, "OK", (Action)delegate
				{
					_270ZVixWLhgEiLA6QosapJMyU6h();
					_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
				});
				num = (int)((num2 * 204193980) ^ 0x6D0E3DB6);
				continue;
			case 0u:
				break;
			case 1u:
				goto IL_009d;
			case 3u:
				return;
			default:
				_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
				return;
			}
			break;
		}
		goto IL_006f;
		IL_006f:
		num = -174232024;
		goto IL_0074;
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
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		string string_ = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_77((MemberInfo)_poenyHBGUusBcnNcTFB9MQBV72R.smethod_76((object)_poenyHBGUusBcnNcTFB9MQBV72R.smethod_75(_4L7hfXrWoDdArQiscG4ukHCV46B)));
		string string_2 = default(string);
		while (true)
		{
			int num = -1227391788;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA21F51B0u) % 11u)
				{
				case 10u:
				{
					int num5;
					int num6;
					if (!_poenyHBGUusBcnNcTFB9MQBV72R.smethod_82(string_, "LivingRoomScene"))
					{
						num5 = -536382399;
						num6 = -536382399;
					}
					else
					{
						num5 = -1845996870;
						num6 = -1845996870;
					}
					num = num5 ^ ((int)num2 * -2068476905);
					continue;
				}
				case 9u:
				{
					int num4;
					if (!_poenyHBGUusBcnNcTFB9MQBV72R.smethod_82(string_, "BedroomScene"))
					{
						num = -1446054941;
						num4 = -1446054941;
					}
					else
					{
						num = -352362210;
						num4 = -352362210;
					}
					continue;
				}
				case 8u:
					_WDhVhBhQHGowaONqV87v7EaCvro(_H6UwM4zjGzglzMY478iBDDvTk6I);
					num = -627923288;
					continue;
				case 4u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_81("<i>Reception is really bad at the moment, I should try again when I'm back at home.</i>", "%playername%", Color.get_White());
					num = ((int)num2 * -953685960) ^ 0x8E3ADE7;
					continue;
				case 3u:
				{
					int num7;
					int num8;
					if (_poenyHBGUusBcnNcTFB9MQBV72R.smethod_80(string_2, _iVvswmrDLetaWXmgd38sJtDnLs[_H6UwM4zjGzglzMY478iBDDvTk6I]))
					{
						num7 = -608289024;
						num8 = -608289024;
					}
					else
					{
						num7 = -1476349387;
						num8 = -1476349387;
					}
					num = num7 ^ (int)(num2 * 825873994);
					continue;
				}
				case 2u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_81(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_37("<i>", _H6UwM4zjGzglzMY478iBDDvTk6I.ToString(), " is kind of... preoccupied right now.</i>"), "%playername%", Color.get_White());
					num = ((int)num2 * -921096924) ^ 0xB72AA17;
					continue;
				case 1u:
				{
					_TwlwMC1hhdSzamwGWEBxuUkz1gH twlwMC1hhdSzamwGWEBxuUkz1gH = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_78(_4L7hfXrWoDdArQiscG4ukHCV46B);
					string_2 = ((twlwMC1hhdSzamwGWEBxuUkz1gH != null) ? _poenyHBGUusBcnNcTFB9MQBV72R.smethod_77((MemberInfo)_poenyHBGUusBcnNcTFB9MQBV72R.smethod_79((object)twlwMC1hhdSzamwGWEBxuUkz1gH)) : null);
					int num3;
					if (!_poenyHBGUusBcnNcTFB9MQBV72R.smethod_80(string_, "PlayerSexScene"))
					{
						num = -1023079257;
						num3 = -1023079257;
					}
					else
					{
						num = -1234268699;
						num3 = -1234268699;
					}
					continue;
				}
				default:
					return;
				case 6u:
					break;
				case 0u:
					return;
				case 5u:
					return;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	[CompilerGenerated]
	private void _1hGbSwTABxDpIetADMbCrWOHTnmb(Control control_0, MouseEventArgs mouseEventArgs_0)
	{
		_RiDuYMeg3EHnBUteUcAb8VlfQVl();
		while (true)
		{
			int num = 963737304;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6E540526u) % 3u)
				{
				case 1u:
					goto IL_0007;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0007:
				_4L7hfXrWoDdArQiscG4ukHCV46B._k9wUPeU1Ga7cygiuGP8TT6aPLWF<PhoneShootingRangeMiniGameScene>();
				num = (int)(num2 * 1901507220) ^ -648989614;
			}
		}
	}

	[CompilerGenerated]
	private void _dzvdiBCzexDaTaw0dtlOYpufAN9(Control control_0, MouseEventArgs mouseEventArgs_0)
	{
		_poenyHBGUusBcnNcTFB9MQBV72R.smethod_42(_4L7hfXrWoDdArQiscG4ukHCV46B, "MiniGameCooking");
		while (true)
		{
			int num = -1423211482;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB40C3BEDu) % 3u)
				{
				case 2u:
					goto IL_0013;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0013:
				_RiDuYMeg3EHnBUteUcAb8VlfQVl();
				num = ((int)num2 * -1979497693) ^ -1261130622;
			}
		}
	}

	[CompilerGenerated]
	private void _mtSlo389ePbyE51TlqnT5fBb6gI(Control control_0, MouseEventArgs mouseEventArgs_0)
	{
		_poenyHBGUusBcnNcTFB9MQBV72R.smethod_42(_4L7hfXrWoDdArQiscG4ukHCV46B, "NudesRemy");
		_RiDuYMeg3EHnBUteUcAb8VlfQVl();
	}

	[CompilerGenerated]
	private void _wxGBGUQYvk0di1prM3ppqYDhqrj(Control control_0, MouseEventArgs mouseEventArgs_0)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		string string_ = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_77((MemberInfo)_poenyHBGUusBcnNcTFB9MQBV72R.smethod_76((object)_poenyHBGUusBcnNcTFB9MQBV72R.smethod_75(_4L7hfXrWoDdArQiscG4ukHCV46B)));
		if (_poenyHBGUusBcnNcTFB9MQBV72R.smethod_83(string_, "Club"))
		{
			goto IL_003b;
		}
		goto IL_0065;
		IL_0065:
		_poenyHBGUusBcnNcTFB9MQBV72R.smethod_81("<i>Hmm, the operator is telling me: 'The number you are trying to reach is currently unavailable'. I guess the DJ only has his phone enabled during Club hours.</i>", "%playername%", Color.get_White());
		int num = 647745293;
		goto IL_0040;
		IL_0040:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x745D3047u) % 5u)
			{
			case 2u:
				_eprNswcjHxcASaMkeDGEbGomDNI(_VQgRlkt1vazuo2KaxFIrSVwZOpL.Soundtrack);
				num = ((int)num2 * -289905105) ^ 0x44CB0C59;
				continue;
			case 0u:
				break;
			default:
				return;
			case 3u:
				goto IL_0065;
			case 1u:
				return;
			case 4u:
				return;
			}
			break;
		}
		goto IL_003b;
		IL_003b:
		num = 1184456034;
		goto IL_0040;
	}

	[CompilerGenerated]
	private void _6eyh0eOS36XIX7OnTaYCDcxJ4pd(Control control_0, MouseEventArgs mouseEventArgs_0)
	{
		_poenyHBGUusBcnNcTFB9MQBV72R.smethod_84(_poenyHBGUusBcnNcTFB9MQBV72R.smethod_6(_4L7hfXrWoDdArQiscG4ukHCV46B));
	}

	[CompilerGenerated]
	private void _DYKzI7YGQNT3w0xlrg3r0WgZqmd(Control control_0, MouseEventArgs mouseEventArgs_0)
	{
		_3AaEmo54VzWybgrrg7I8Z9JUV1e = true;
		_poenyHBGUusBcnNcTFB9MQBV72R.smethod_73(_9GQBAH2pi8Sm6ph1s6InjyQGe6R, "Are you sure you wish to remove this message?", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, 250, (Action<int>)delegate(int int_0)
		{
			if (int_0 == 1)
			{
				goto IL_0048;
			}
			goto IL_0072;
			IL_0072:
			_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
			int num = 2074080370;
			goto IL_004d;
			IL_004d:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBCE576Du) % 5u)
				{
				case 4u:
					_270ZVixWLhgEiLA6QosapJMyU6h();
					num = (int)(num2 * 504063370) ^ -2031938344;
					continue;
				case 3u:
				{
					_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG_ = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_19();
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_29(opIJo2jLUqdOL5yAFP4yzXce0DG_).Remove(_ERdtO3cV05TBYFV0mT86wv01GJf);
					_ERdtO3cV05TBYFV0mT86wv01GJf = null;
					num = (int)((num2 * 2056145342) ^ 0x16E92230);
					continue;
				}
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_0072;
				case 2u:
					return;
				}
				break;
			}
			goto IL_0048;
			IL_0048:
			num = 204380412;
			goto IL_004d;
		});
	}

	[CompilerGenerated]
	private void _HAv1SP3Xi5hrN1p5KQH4LuKhnic(int int_0)
	{
		if (int_0 == 1)
		{
			goto IL_0048;
		}
		goto IL_0072;
		IL_0072:
		_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
		int num = 2074080370;
		goto IL_004d;
		IL_004d:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xBCE576Du) % 5u)
			{
			case 4u:
				_270ZVixWLhgEiLA6QosapJMyU6h();
				num = (int)(num2 * 504063370) ^ -2031938344;
				continue;
			case 3u:
			{
				_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG_ = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_19();
				_poenyHBGUusBcnNcTFB9MQBV72R.smethod_29(opIJo2jLUqdOL5yAFP4yzXce0DG_).Remove(_ERdtO3cV05TBYFV0mT86wv01GJf);
				_ERdtO3cV05TBYFV0mT86wv01GJf = null;
				num = (int)((num2 * 2056145342) ^ 0x16E92230);
				continue;
			}
			case 0u:
				break;
			default:
				return;
			case 1u:
				goto IL_0072;
			case 2u:
				return;
			}
			break;
		}
		goto IL_0048;
		IL_0048:
		num = 204380412;
		goto IL_004d;
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
		while (true)
		{
			int num = 1080381110;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1B87E7F7u) % 3u)
				{
				case 2u:
					goto IL_0009;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0009:
				_poenyHBGUusBcnNcTFB9MQBV72R.smethod_73(_9GQBAH2pi8Sm6ph1s6InjyQGe6R, "Are you sure you wish to customize your character? This may break some active dates even if make no changes!", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, 250, (Action<int>)delegate(int int_0)
				{
					if (int_0 == 1)
					{
						goto IL_0034;
					}
					goto IL_005e;
					IL_005e:
					_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
					int num3 = 1173013474;
					goto IL_0039;
					IL_0039:
					while (true)
					{
						uint num4;
						switch ((num4 = (uint)num3 ^ 0x6A962EDAu) % 5u)
						{
						case 3u:
							_4L7hfXrWoDdArQiscG4ukHCV46B._k9wUPeU1Ga7cygiuGP8TT6aPLWF<BackToPlayerCustomizationScene>();
							num3 = ((int)num4 * -14435164) ^ 0x40523630;
							continue;
						case 2u:
							_RiDuYMeg3EHnBUteUcAb8VlfQVl();
							num3 = (int)((num4 * 1563904339) ^ 0x21BF9559);
							continue;
						case 0u:
							break;
						default:
							return;
						case 1u:
							goto IL_005e;
						case 4u:
							return;
						}
						break;
					}
					goto IL_0034;
					IL_0034:
					num3 = 1584637405;
					goto IL_0039;
				});
				num = ((int)num2 * -1144536403) ^ -1683028554;
			}
		}
	}

	[CompilerGenerated]
	private void _ibyikqci0u66RjCcP7JC4vdPHGD(int int_0)
	{
		if (int_0 == 1)
		{
			goto IL_0034;
		}
		goto IL_005e;
		IL_005e:
		_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
		int num = 1173013474;
		goto IL_0039;
		IL_0039:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x6A962EDAu) % 5u)
			{
			case 3u:
				_4L7hfXrWoDdArQiscG4ukHCV46B._k9wUPeU1Ga7cygiuGP8TT6aPLWF<BackToPlayerCustomizationScene>();
				num = ((int)num2 * -14435164) ^ 0x40523630;
				continue;
			case 2u:
				_RiDuYMeg3EHnBUteUcAb8VlfQVl();
				num = (int)((num2 * 1563904339) ^ 0x21BF9559);
				continue;
			case 0u:
				break;
			default:
				return;
			case 1u:
				goto IL_005e;
			case 4u:
				return;
			}
			break;
		}
		goto IL_0034;
		IL_0034:
		num = 1584637405;
		goto IL_0039;
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
		while (true)
		{
			int num = 1049320066;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1D2ED72Fu) % 3u)
				{
				case 1u:
					goto IL_0007;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0007:
				_4L7hfXrWoDdArQiscG4ukHCV46B._k9wUPeU1Ga7cygiuGP8TT6aPLWF<ClubInsideScene>();
				num = ((int)num2 * -57633089) ^ -55423361;
			}
		}
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
		_poenyHBGUusBcnNcTFB9MQBV72R.smethod_73(_9GQBAH2pi8Sm6ph1s6InjyQGe6R, "Are you sure you wish to quit the game? All unsaved progress will be lost!", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, 250, (Action<int>)delegate(int int_0)
		{
			if (int_0 == 1)
			{
				goto IL_0004;
			}
			goto IL_0044;
			IL_0044:
			_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
			int num = 514604546;
			goto IL_0023;
			IL_0023:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x73646F4Eu) % 4u)
				{
				case 3u:
					break;
				case 1u:
					_poenyHBGUusBcnNcTFB9MQBV72R.smethod_85(_4L7hfXrWoDdArQiscG4ukHCV46B);
					num = (int)((num2 * 2103971007) ^ 0x4B929A5F);
					continue;
				default:
					return;
				case 2u:
					goto IL_0044;
				case 0u:
					return;
				}
				break;
			}
			goto IL_0004;
			IL_0004:
			num = 85626127;
			goto IL_0023;
		});
	}

	[CompilerGenerated]
	private void _KxEaqBMxbKUC1uoNexV1T0G13UH(int int_0)
	{
		if (int_0 == 1)
		{
			goto IL_0004;
		}
		goto IL_0044;
		IL_0044:
		_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
		int num = 514604546;
		goto IL_0023;
		IL_0023:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x73646F4Eu) % 4u)
			{
			case 3u:
				break;
			case 1u:
				_poenyHBGUusBcnNcTFB9MQBV72R.smethod_85(_4L7hfXrWoDdArQiscG4ukHCV46B);
				num = (int)((num2 * 2103971007) ^ 0x4B929A5F);
				continue;
			default:
				return;
			case 2u:
				goto IL_0044;
			case 0u:
				return;
			}
			break;
		}
		goto IL_0004;
		IL_0004:
		num = 85626127;
		goto IL_0023;
	}

	[CompilerGenerated]
	private void _QrVkLhoCh4aBUIhEyFneetZLvzE()
	{
		_3AaEmo54VzWybgrrg7I8Z9JUV1e = false;
	}

	[CompilerGenerated]
	private Point _Xz25BlZJnUNbNDPMKaWNQy0jbnY(Point point_0)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		double double_ = default(double);
		Point val = _poenyHBGUusBcnNcTFB9MQBV72R.smethod_72(_hrw3Kf8fCx7saJOmoYUD8sIz3uD, "Sheen Two", ref double_);
		Matrix val2 = Matrix.CreateTranslation((float)(-val.X), (float)(-val.Y), 0f) * Matrix.CreateRotationZ((float)(0.0 - double_));
		Vector2 val3 = Vector2.Transform(new Vector2((float)((Point)(ref point_0)).get_x(), (float)((Point)(ref point_0)).get_y()), val2);
		return new Point((int)val3.X, (int)val3.Y);
	}

	[CompilerGenerated]
	private void _9RPCNJm7hEe0iO5j7fpMG6Dx2Pq()
	{
		_TZx1AkahTLXoM2XUbm5U8YJOScb = false;
		while (true)
		{
			int num = 1466619539;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x60C2C310u) % 4u)
				{
				case 3u:
					_j2OEvLQtM2lODSmH3ZFP6wWCWpF = _fFGgY4gvWNcTLSlsfe9k99ctumb.ArmUp;
					num = (int)(num2 * 1700371272) ^ -1922565787;
					continue;
				case 1u:
					_aEgXugtdIuFieAwnDhnIlYNEysg();
					num = (int)((num2 * 406043222) ^ 0xE3A8C4);
					continue;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
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
