using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spine;

public class _nHdiyIURlAiaNZ8u6MKzxjcwnyL
{
	public Action<string> _iUyagF1KTeSUlg0raFfzuot3CwC;

	private readonly Skeleton _Q9MbCV832IUbkbrMWYaOkMJU5BhA;

	private readonly AnimationState _ZVtUyMscIM54gezcLdBBhUCeVAv;

	private Action<int> _HCBewBkFBdxmny4dffH5y6pT7IWA;

	private bool _8l6SZQ1ASWukUrnspv0IFQAjpji;

	private int _1JfcJXW8yr3gQAFuYaMfgav0PSV;

	private Action _YKPC9RPU26VoychJLT26gpzNlPR;

	private bool _OmIU5xZ6Kmv1g8Y6LBtZlc8vCGG;

	public bool _Ssp18W0I7HLX3YToPSudCzKuDjF { get; set; }

	public float _7Xn1C5tjYnmIif1iZKV8AWsEEbL
	{
		get
		{
			return _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_0(_Q9MbCV832IUbkbrMWYaOkMJU5BhA);
		}
		set
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_1(_Q9MbCV832IUbkbrMWYaOkMJU5BhA, value);
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_2(_Q9MbCV832IUbkbrMWYaOkMJU5BhA);
		}
	}

	public float _bCjZ3VSXGKyhmykd2zCnQBiSpDf
	{
		get
		{
			return _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_3(_Q9MbCV832IUbkbrMWYaOkMJU5BhA);
		}
		set
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_4(_Q9MbCV832IUbkbrMWYaOkMJU5BhA, value);
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_2(_Q9MbCV832IUbkbrMWYaOkMJU5BhA);
		}
	}

	public bool _Hwt6L2NJfXmAfG6UOH8NVlNfGCR
	{
		get
		{
			return _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_5(_Q9MbCV832IUbkbrMWYaOkMJU5BhA);
		}
		set
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_6(_Q9MbCV832IUbkbrMWYaOkMJU5BhA, value);
		}
	}

	public bool _mfKvSYDXt3O00aq0azjwApGdK7d
	{
		get
		{
			return _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_7(_Q9MbCV832IUbkbrMWYaOkMJU5BhA);
		}
		set
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_8(_Q9MbCV832IUbkbrMWYaOkMJU5BhA, value);
		}
	}

	public Skeleton _4puDGlIwmnebKpz1JXzxe4GDuJ4 => _Q9MbCV832IUbkbrMWYaOkMJU5BhA;

	public _nHdiyIURlAiaNZ8u6MKzxjcwnyL(Skeleton skeleton_0, bool bool_0)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		AnimationStateData animationStateData_ = default(AnimationStateData);
		while (true)
		{
			int num = 244741451;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2E79EAD9u) % 5u)
				{
				case 2u:
					_Ssp18W0I7HLX3YToPSudCzKuDjF = bool_0;
					animationStateData_ = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_10(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_9(_Q9MbCV832IUbkbrMWYaOkMJU5BhA));
					num = ((int)num2 * -1059189534) ^ 0x66EAE2;
					continue;
				case 1u:
					_Q9MbCV832IUbkbrMWYaOkMJU5BhA = skeleton_0;
					num = (int)(num2 * 312095633) ^ -1712718798;
					continue;
				case 0u:
					_ZVtUyMscIM54gezcLdBBhUCeVAv = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_11(animationStateData_);
					_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_12(_ZVtUyMscIM54gezcLdBBhUCeVAv, new CompleteDelegate(_d8vi3xWGR3jH0bzxGSAJiLYtNKc));
					num = (int)(num2 * 472920050) ^ -389138829;
					continue;
				case 3u:
					break;
				default:
					_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_13(_ZVtUyMscIM54gezcLdBBhUCeVAv, new StartEndDelegate(_KVZ9mWydLEUb3C7nVtUyDaNJ1wc));
					_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_14(_ZVtUyMscIM54gezcLdBBhUCeVAv, (EventDelegate)delegate(AnimationState animationState_0, int int_0, Event event_0)
					{
						if (_iUyagF1KTeSUlg0raFfzuot3CwC != null)
						{
							while (true)
							{
								int num3 = -387546742;
								while (true)
								{
									uint num4;
									switch ((num4 = (uint)num3 ^ 0xD6C64DF8u) % 3u)
									{
									case 1u:
										goto IL_000a;
									default:
										return;
									case 2u:
										break;
									case 0u:
										return;
									}
									break;
									IL_000a:
									_iUyagF1KTeSUlg0raFfzuot3CwC(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_53(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_52(event_0)));
									num3 = ((int)num4 * -512444895) ^ -1591633065;
								}
							}
						}
					});
					return;
				}
				break;
			}
		}
	}

	private void _d8vi3xWGR3jH0bzxGSAJiLYtNKc(AnimationState animationState_0, int int_0, int int_1)
	{
		_8l6SZQ1ASWukUrnspv0IFQAjpji = true;
		_1JfcJXW8yr3gQAFuYaMfgav0PSV = int_1;
	}

	private void _KVZ9mWydLEUb3C7nVtUyDaNJ1wc(AnimationState animationState_0, int int_0)
	{
		_OmIU5xZ6Kmv1g8Y6LBtZlc8vCGG = true;
	}

	public void _lkaN4ygxDlKvzKEBuD7dRjrU20F()
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_15(_Q9MbCV832IUbkbrMWYaOkMJU5BhA);
	}

	public void _C5vPbZ72rpVMDWGuHxZuR5FNpAH(string string_0, Action<int> action_0 = null)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_16(_ZVtUyMscIM54gezcLdBBhUCeVAv, 0, string_0, bool_0: true);
		while (true)
		{
			int num = -1241708209;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x90C1DF30u) % 6u)
				{
				case 5u:
					_YKPC9RPU26VoychJLT26gpzNlPR = null;
					num = (int)((num2 * 899682332) ^ 0x74F9D6DA);
					continue;
				case 3u:
					_HCBewBkFBdxmny4dffH5y6pT7IWA = action_0;
					_8l6SZQ1ASWukUrnspv0IFQAjpji = false;
					num = (int)(num2 * 1788923141) ^ -1551673737;
					continue;
				case 2u:
					_OmIU5xZ6Kmv1g8Y6LBtZlc8vCGG = false;
					num = ((int)num2 * -1238887320) ^ 0x1264FADB;
					continue;
				case 0u:
					_1JfcJXW8yr3gQAFuYaMfgav0PSV = 0;
					num = ((int)num2 * -1584776224) ^ 0x6D1E9B19;
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

	public void _SPUoP3ABwpgQinJfKUM5qBbYSvr(string string_0, Action action_0 = null)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_16(_ZVtUyMscIM54gezcLdBBhUCeVAv, 0, string_0, bool_0: false);
		while (true)
		{
			int num = 1382390713;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2DE9021Fu) % 6u)
				{
				case 4u:
					_HCBewBkFBdxmny4dffH5y6pT7IWA = null;
					num = ((int)num2 * -530377797) ^ 0x1A351B71;
					continue;
				case 3u:
					_1JfcJXW8yr3gQAFuYaMfgav0PSV = 0;
					_YKPC9RPU26VoychJLT26gpzNlPR = action_0;
					num = (int)((num2 * 1840032921) ^ 0x3B7B3DC7);
					continue;
				case 1u:
					_OmIU5xZ6Kmv1g8Y6LBtZlc8vCGG = false;
					num = (int)(num2 * 1890049864) ^ -1857422377;
					continue;
				case 0u:
					_8l6SZQ1ASWukUrnspv0IFQAjpji = false;
					num = (int)((num2 * 1919943092) ^ 0x17E67F12);
					continue;
				default:
					return;
				case 5u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public void _d6HoyBFhu6xkBRCX00ZzeFUnWwF()
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_17(_ZVtUyMscIM54gezcLdBBhUCeVAv);
	}

	public void _zqRttWc6EZHjk1LAoNrCy0Qamk2(string string_0, string string_1, float float_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_19(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_18(_ZVtUyMscIM54gezcLdBBhUCeVAv), string_0, string_1, float_0);
	}

	public void _a2lgCWeMj1Hr65gQZxslDkqeUdd(string string_0, bool bool_0 = false, float float_0 = 0f, Action<int> action_0 = null, Action action_1 = null)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_20(_ZVtUyMscIM54gezcLdBBhUCeVAv, 0, string_0, bool_0, float_0);
		while (true)
		{
			int num = -1921169544;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9599687Du) % 4u)
				{
				case 2u:
					_8l6SZQ1ASWukUrnspv0IFQAjpji = false;
					_1JfcJXW8yr3gQAFuYaMfgav0PSV = 0;
					num = ((int)num2 * -948457852) ^ 0x5320836E;
					continue;
				case 1u:
					_HCBewBkFBdxmny4dffH5y6pT7IWA = action_0;
					num = ((int)num2 * -977193759) ^ 0x35B21972;
					continue;
				case 0u:
					break;
				default:
					_YKPC9RPU26VoychJLT26gpzNlPR = action_1;
					_OmIU5xZ6Kmv1g8Y6LBtZlc8vCGG = false;
					return;
				}
				break;
			}
		}
	}

	public void _aAoZaDNczeScsMfLlGSfAzey9SQ(string string_0, float float_0)
	{
		if (_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_21(string_0))
		{
			goto IL_0008;
		}
		goto IL_005a;
		IL_005a:
		Slot val = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_22(_Q9MbCV832IUbkbrMWYaOkMJU5BhA, string_0);
		int num = -526568373;
		goto IL_0031;
		IL_0031:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xB305F875u) % 6u)
			{
			case 4u:
				break;
			case 0u:
			{
				int num3;
				int num4;
				if (val != null)
				{
					num3 = -239492520;
					num4 = -239492520;
				}
				else
				{
					num3 = -1077273990;
					num4 = -1077273990;
				}
				num = num3 ^ ((int)num2 * -734508085);
				continue;
			}
			case 2u:
				goto IL_005a;
			case 1u:
				return;
			default:
				_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_23(val, float_0);
				return;
			case 5u:
				return;
			}
			break;
		}
		goto IL_0008;
		IL_0008:
		num = -235851818;
		goto IL_0031;
	}

	public void _VoeevpFh2kLKfHtpPDXWt0TFbuH(string string_0, Color color_0)
	{
		_VoeevpFh2kLKfHtpPDXWt0TFbuH(string_0, (float)(int)((Color)(ref color_0)).get_R() / 255f, (float)(int)((Color)(ref color_0)).get_G() / 255f, (float)(int)((Color)(ref color_0)).get_B() / 255f);
	}

	public void _VoeevpFh2kLKfHtpPDXWt0TFbuH(string string_0, float float_0, float float_1, float float_2)
	{
		if (_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_21(string_0))
		{
			goto IL_0017;
		}
		goto IL_0079;
		IL_0079:
		Slot val = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_22(_Q9MbCV832IUbkbrMWYaOkMJU5BhA, string_0);
		int num;
		int num2;
		if (val != null)
		{
			num = -1578605719;
			num2 = -1578605719;
		}
		else
		{
			num = -62568684;
			num2 = -62568684;
		}
		goto IL_0040;
		IL_0040:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0xC687F285u) % 7u)
			{
			case 4u:
				break;
			case 1u:
				_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_25(val, float_1);
				num = (int)(num3 * 1440380037) ^ -1548278993;
				continue;
			case 0u:
				_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_24(val, float_0);
				num = -2108876531;
				continue;
			case 5u:
				goto IL_0079;
			case 2u:
				return;
			default:
				_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_26(val, float_2);
				return;
			case 6u:
				return;
			}
			break;
		}
		goto IL_0017;
		IL_0017:
		num = -64326481;
		goto IL_0040;
	}

	public void _c4iC7y9v6xg7LpvjKIeUkOdZ3UF(float float_0)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<Slot> enumerator = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_27(_Q9MbCV832IUbkbrMWYaOkMJU5BhA).GetEnumerator();
		try
		{
			Slot current = default(Slot);
			while (true)
			{
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = 133641236;
					num2 = 133641236;
				}
				else
				{
					num = 554171132;
					num2 = 554171132;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x4870AFA9u) % 5u)
					{
					case 3u:
						current = enumerator.get_Current();
						num = 600374888;
						continue;
					case 2u:
						num = 133641236;
						continue;
					case 0u:
						_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_23(current, float_0);
						num = ((int)num3 * -1555060591) ^ 0x713378DB;
						continue;
					default:
						return;
					case 1u:
						break;
					case 4u:
						return;
					}
					break;
				}
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
	}

	public bool _3nKd9Dk3YeX87QB5dROwYUzczsN(string string_0, float float_0, float float_1)
	{
		if (_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_21(string_0))
		{
			goto IL_009f;
		}
		goto IL_03f4;
		IL_03f4:
		Slot val = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_22(_Q9MbCV832IUbkbrMWYaOkMJU5BhA, string_0);
		int num = 528565790;
		goto IL_036d;
		IL_036d:
		float num6 = default(float);
		float[] array = default(float[]);
		float num20 = default(float);
		float num21 = default(float);
		float num15 = default(float);
		RegionAttachment regionAttachment_ = default(RegionAttachment);
		float num12 = default(float);
		float num16 = default(float);
		float num11 = default(float);
		float num19 = default(float);
		float num26 = default(float);
		float num5 = default(float);
		float num4 = default(float);
		float num14 = default(float);
		float num7 = default(float);
		float num25 = default(float);
		float num13 = default(float);
		float num3 = default(float);
		float num22 = default(float);
		float num28 = default(float);
		float num8 = default(float);
		float num9 = default(float);
		float num27 = default(float);
		float num10 = default(float);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x1C90305u) % 29u)
			{
			case 28u:
				num6 = array[2] * num20 + array[3] * num21 + num15;
				num = (int)((num2 * 2026429272) ^ 0x51440C5F);
				continue;
			case 27u:
				num20 = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_34(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_29(val));
				num21 = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_35(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_29(val));
				num = (int)(num2 * 868437392) ^ -496371717;
				continue;
			case 26u:
			{
				Attachment obj = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_28(val);
				regionAttachment_ = (RegionAttachment)(object)((obj is RegionAttachment) ? obj : null);
				num = 816213171;
				continue;
			}
			case 25u:
				num12 = array[4] * num16 + array[5] * num11 + num19;
				num = ((int)num2 * -1854899653) ^ -1654351183;
				continue;
			case 24u:
				break;
			case 23u:
			{
				int num31;
				int num32;
				if (val != null)
				{
					num31 = -1858618268;
					num32 = -1858618268;
				}
				else
				{
					num31 = -1975544147;
					num32 = -1975544147;
				}
				num = num31 ^ ((int)num2 * -1536488068);
				continue;
			}
			case 21u:
				num26 = float_1 - num6;
				num = ((int)num2 * -2083189181) ^ 0xE3C14A3;
				continue;
			case 19u:
				num5 = array[4] * num20 + array[5] * num21 + num15;
				num = (int)((num2 * 1470016396) ^ 0x70BBCD57);
				continue;
			case 18u:
				num19 = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_0(_Q9MbCV832IUbkbrMWYaOkMJU5BhA) + _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_30(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_29(val));
				num = ((int)num2 * -1131845933) ^ -157893044;
				continue;
			case 17u:
				num4 = num14 * num14 + num7 * num7;
				num25 = float_0 - num13;
				num = ((int)num2 * -1593554928) ^ 0x7D455026;
				continue;
			case 13u:
			{
				int num33;
				int num34;
				if (0f <= num3)
				{
					num33 = -624022293;
					num34 = -624022293;
				}
				else
				{
					num33 = -325656765;
					num34 = -325656765;
				}
				num = num33 ^ (int)(num2 * 788302567);
				continue;
			}
			case 12u:
			{
				int num29;
				int num30;
				if (0f > num22)
				{
					num29 = -1229429270;
					num30 = -1229429270;
				}
				else
				{
					num29 = -1797252755;
					num30 = -1797252755;
				}
				num = num29 ^ ((int)num2 * -263713667);
				continue;
			}
			case 11u:
				num28 = array[0] * num20 + array[1] * num21 + num15;
				num13 = array[2] * num16 + array[3] * num11 + num19;
				num = ((int)num2 * -71823859) ^ 0x5625AE49;
				continue;
			case 10u:
				num22 = num25 * num8 + num26 * num9;
				num = (int)((num2 * 1241194372) ^ 0x3EF0E440);
				continue;
			case 9u:
				array = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_36(regionAttachment_);
				num27 = array[0] * num16 + array[1] * num11 + num19;
				num = (int)((num2 * 2024612589) ^ 0x44B1B575);
				continue;
			case 8u:
				num8 = num27 - num13;
				num9 = num28 - num6;
				num = (int)(num2 * 711178303) ^ -1256539842;
				continue;
			case 7u:
				num3 = num25 * num14 + num26 * num7;
				num = (int)(num2 * 635153186) ^ -1715639961;
				continue;
			case 6u:
			{
				int num23;
				int num24;
				if (num22 <= num10)
				{
					num23 = -1429820436;
					num24 = -1429820436;
				}
				else
				{
					num23 = -680586718;
					num24 = -680586718;
				}
				num = num23 ^ ((int)num2 * -447968003);
				continue;
			}
			case 5u:
			{
				int num17;
				int num18;
				if (_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_28(val) is RegionAttachment)
				{
					num17 = 757523596;
					num18 = 757523596;
				}
				else
				{
					num17 = 435238977;
					num18 = 435238977;
				}
				num = num17 ^ (int)(num2 * 1821455384);
				continue;
			}
			case 4u:
				num15 = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_3(_Q9MbCV832IUbkbrMWYaOkMJU5BhA) + _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_31(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_29(val));
				num16 = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_32(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_29(val));
				num = (int)((num2 * 704717971) ^ 0x37FD4F5A);
				continue;
			case 3u:
				num14 = num12 - num13;
				num = (int)((num2 * 601409610) ^ 0x2C83AAD1);
				continue;
			case 2u:
				num11 = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_33(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_29(val));
				num = (int)((num2 * 455966829) ^ 0x40F6BB2F);
				continue;
			case 0u:
				num7 = num5 - num6;
				num10 = num8 * num8 + num9 * num9;
				num = ((int)num2 * -1482347866) ^ 0x5B1B3F35;
				continue;
			case 15u:
				goto IL_03f4;
			case 1u:
				return false;
			case 14u:
				return num3 <= num4;
			case 16u:
				return false;
			default:
				return false;
			case 22u:
				return false;
			}
			break;
		}
		goto IL_009f;
		IL_009f:
		num = 696427843;
		goto IL_036d;
	}

	public void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0, float float_0 = 1000f)
	{
		_ZVtUyMscIM54gezcLdBBhUCeVAv.Update((float)_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_37(gameTime_0).Milliseconds / float_0);
		_ZVtUyMscIM54gezcLdBBhUCeVAv.Apply(_Q9MbCV832IUbkbrMWYaOkMJU5BhA);
		_Q9MbCV832IUbkbrMWYaOkMJU5BhA.UpdateWorldTransform();
		while (true)
		{
			int num = -835613872;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA6AE91B1u) % 10u)
				{
				case 9u:
				{
					int num5;
					int num6;
					if (!_OmIU5xZ6Kmv1g8Y6LBtZlc8vCGG)
					{
						num5 = 1167459423;
						num6 = 1167459423;
					}
					else
					{
						num5 = 1779694670;
						num6 = 1779694670;
					}
					num = num5 ^ (int)(num2 * 737346259);
					continue;
				}
				case 8u:
				{
					int num8;
					int num9;
					if (_YKPC9RPU26VoychJLT26gpzNlPR != null)
					{
						num8 = 108508942;
						num9 = 108508942;
					}
					else
					{
						num8 = 1550450600;
						num9 = 1550450600;
					}
					num = num8 ^ ((int)num2 * -125391770);
					continue;
				}
				case 5u:
					_YKPC9RPU26VoychJLT26gpzNlPR();
					num = ((int)num2 * -782558087) ^ -363647451;
					continue;
				case 4u:
					_OmIU5xZ6Kmv1g8Y6LBtZlc8vCGG = false;
					num = ((int)num2 * -695489537) ^ -250587291;
					continue;
				case 3u:
				{
					int num7;
					if (!_8l6SZQ1ASWukUrnspv0IFQAjpji)
					{
						num = -596798872;
						num7 = -596798872;
					}
					else
					{
						num = -154651659;
						num7 = -154651659;
					}
					continue;
				}
				case 2u:
				{
					_8l6SZQ1ASWukUrnspv0IFQAjpji = false;
					int num3;
					int num4;
					if (_HCBewBkFBdxmny4dffH5y6pT7IWA == null)
					{
						num3 = 174933888;
						num4 = 174933888;
					}
					else
					{
						num3 = 1500438717;
						num4 = 1500438717;
					}
					num = num3 ^ ((int)num2 * -964621606);
					continue;
				}
				case 0u:
					_HCBewBkFBdxmny4dffH5y6pT7IWA(_1JfcJXW8yr3gQAFuYaMfgav0PSV);
					num = ((int)num2 * -1585570355) ^ 0x12444CFC;
					continue;
				default:
					return;
				case 6u:
					break;
				case 1u:
					return;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	public void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SkeletonMeshRenderer skeletonMeshRenderer_0, Texture2D texture2D_0 = null, Func<int, string, bool> func_0 = null, Color? nullable_0 = null, float float_0 = 1f)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_38(skeletonMeshRenderer_0, _Ssp18W0I7HLX3YToPSudCzKuDjF);
		while (true)
		{
			int num = 276092689;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6FB6B26Cu) % 3u)
				{
				case 1u:
					goto IL_000e;
				case 0u:
					break;
				default:
					_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_41(skeletonMeshRenderer_0);
					return;
				}
				break;
				IL_000e:
				_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_39(skeletonMeshRenderer_0, _7Xn1C5tjYnmIif1iZKV8AWsEEbL, _bCjZ3VSXGKyhmykd2zCnQBiSpDf, float_0);
				_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_40(skeletonMeshRenderer_0, _Q9MbCV832IUbkbrMWYaOkMJU5BhA, texture2D_0, func_0, nullable_0);
				num = (int)((num2 * 826062717) ^ 0x1B3DE983);
			}
		}
	}

	public Point _0LlFMUVNTAixukJSTpecXFIxdAl(string string_0, out double double_0)
	{
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		Slot val = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_22(_Q9MbCV832IUbkbrMWYaOkMJU5BhA, string_0);
		if (val != null)
		{
			goto IL_0187;
		}
		goto IL_0207;
		IL_0207:
		double_0 = 0.0;
		int num = 1658462251;
		goto IL_01bc;
		IL_01bc:
		float num10 = default(float);
		float num8 = default(float);
		float num4 = default(float);
		float[] array = default(float[]);
		float num5 = default(float);
		float num9 = default(float);
		float num7 = default(float);
		float num6 = default(float);
		float num3 = default(float);
		RegionAttachment regionAttachment_ = default(RegionAttachment);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x28DF366Au) % 14u)
			{
			case 12u:
				num10 = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_35(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_29(val));
				num = (int)((num2 * 542711792) ^ 0x4975B99D);
				continue;
			case 11u:
			{
				int num13;
				int num14;
				if (!(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_28(val) is RegionAttachment))
				{
					num13 = -379720148;
					num14 = -379720148;
				}
				else
				{
					num13 = -581456157;
					num14 = -581456157;
				}
				num = num13 ^ ((int)num2 * -1104126438);
				continue;
			}
			case 9u:
				num8 = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_33(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_29(val));
				num = (int)((num2 * 1832382162) ^ 0x25714998);
				continue;
			case 8u:
			{
				num4 = array[2] * num5 + array[3] * num10 + num9;
				float num11 = array[4] * num7 + array[5] * num8 + num6;
				float num12 = array[4] * num5 + array[5] * num10 + num9;
				double_0 = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_42((double)((num12 - num4) / (num11 - num3)));
				num = ((int)num2 * -1227514499) ^ 0xE248C76;
				continue;
			}
			case 7u:
				num7 = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_32(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_29(val));
				num = ((int)num2 * -263218839) ^ 0x424E5358;
				continue;
			case 6u:
				num9 = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_3(_Q9MbCV832IUbkbrMWYaOkMJU5BhA) + _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_31(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_29(val));
				num = (int)((num2 * 1797162581) ^ 0x4CB2FB95);
				continue;
			case 5u:
				array = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_36(regionAttachment_);
				num3 = array[2] * num7 + array[3] * num8 + num6;
				num = (int)((num2 * 1223783263) ^ 0x39505C13);
				continue;
			case 3u:
				num6 = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_0(_Q9MbCV832IUbkbrMWYaOkMJU5BhA) + _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_30(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_29(val));
				num = ((int)num2 * -1989140681) ^ 0x377D73B1;
				continue;
			case 2u:
				break;
			case 1u:
			{
				Attachment obj = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_28(val);
				regionAttachment_ = (RegionAttachment)(object)((obj is RegionAttachment) ? obj : null);
				num = 59615273;
				continue;
			}
			case 0u:
				num5 = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_34(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_29(val));
				num = (int)((num2 * 1092329794) ^ 0x3EA890E2);
				continue;
			case 10u:
				goto IL_0207;
			default:
				return new Point((int)num3, (int)num4);
			case 13u:
				return Point.get_Zero();
			}
			break;
		}
		goto IL_0187;
		IL_0187:
		num = 817650685;
		goto IL_01bc;
	}

	public void _WPy6ICx3LVoejBaexyOoKGnX9jD(string string_0, float float_0)
	{
		Animation val = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_43(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_9(_Q9MbCV832IUbkbrMWYaOkMJU5BhA), string_0);
		if (val == null)
		{
			goto IL_0015;
		}
		goto IL_0039;
		IL_0039:
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_46(val, _Q9MbCV832IUbkbrMWYaOkMJU5BhA, 0f, float_0, bool_0: false, (ExposedList<Event>)null);
		int num = -482159122;
		goto IL_001a;
		IL_001a:
		switch ((uint)(num ^ -826914430) % 4u)
		{
		case 2u:
			break;
		default:
			return;
		case 3u:
			goto IL_0039;
		case 1u:
			throw _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_45(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_44(_003CModule_003E.smethod_28<string>(1815913885u), string_0));
		case 0u:
			return;
		}
		goto IL_0015;
		IL_0015:
		num = -173701865;
		goto IL_001a;
	}

	public void _EasyNtsMRc39NOvWai1JUYTqcds(string string_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_47(_Q9MbCV832IUbkbrMWYaOkMJU5BhA, string_0);
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_48(_Q9MbCV832IUbkbrMWYaOkMJU5BhA);
	}

	public void _eCEWplYE5FdfYPYTrwfyRlIfd6i(string string_0, string string_1)
	{
		Slot val = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_22(_4puDGlIwmnebKpz1JXzxe4GDuJ4, string_0);
		Slot val2 = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_22(_4puDGlIwmnebKpz1JXzxe4GDuJ4, string_1);
		int num3 = default(int);
		while (true)
		{
			int num = 467189573;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x49194DFu) % 4u)
				{
				case 2u:
					_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_49(_4puDGlIwmnebKpz1JXzxe4GDuJ4).Remove(val);
					num3 = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_49(_4puDGlIwmnebKpz1JXzxe4GDuJ4).IndexOf(val2);
					num = ((int)num2 * -1378527924) ^ -1586394674;
					continue;
				case 1u:
					_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_49(_4puDGlIwmnebKpz1JXzxe4GDuJ4).Insert(num3 + 1, val);
					num = (int)(num2 * 601138520) ^ -1765778081;
					continue;
				default:
					return;
				case 3u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public void _49JXjKJqaPZw5nEmhHdAENuBtLJ(string string_0, float float_0)
	{
		Animation animation_ = _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_43(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_9(_Q9MbCV832IUbkbrMWYaOkMJU5BhA), string_0);
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_51(animation_, _nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_50(animation_) + float_0);
	}

	[CompilerGenerated]
	private void _rOz7ZihvFmMpUcDtcmRWkVEY4ye(AnimationState animationState_0, int int_0, Event event_0)
	{
		if (_iUyagF1KTeSUlg0raFfzuot3CwC == null)
		{
			return;
		}
		while (true)
		{
			int num = -387546742;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD6C64DF8u) % 3u)
				{
				case 1u:
					goto IL_000a;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_000a:
				_iUyagF1KTeSUlg0raFfzuot3CwC(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_53(_nHdiyIURlAiaNZ8u6MKzxjcwnyL.smethod_52(event_0)));
				num = ((int)num2 * -512444895) ^ -1591633065;
			}
		}
	}

	static float smethod_0(Skeleton skeleton_0)
	{
		return skeleton_0.get_X();
	}

	static void smethod_1(Skeleton skeleton_0, float float_0)
	{
		skeleton_0.set_X(float_0);
	}

	static void smethod_2(Skeleton skeleton_0)
	{
		skeleton_0.UpdateWorldTransform();
	}

	static float smethod_3(Skeleton skeleton_0)
	{
		return skeleton_0.get_Y();
	}

	static void smethod_4(Skeleton skeleton_0, float float_0)
	{
		skeleton_0.set_Y(float_0);
	}

	static bool smethod_5(Skeleton skeleton_0)
	{
		return skeleton_0.get_FlipX();
	}

	static void smethod_6(Skeleton skeleton_0, bool bool_0)
	{
		skeleton_0.set_FlipX(bool_0);
	}

	static bool smethod_7(Skeleton skeleton_0)
	{
		return skeleton_0.get_FlipY();
	}

	static void smethod_8(Skeleton skeleton_0, bool bool_0)
	{
		skeleton_0.set_FlipY(bool_0);
	}

	static SkeletonData smethod_9(Skeleton skeleton_0)
	{
		return skeleton_0.get_Data();
	}

	static AnimationStateData smethod_10(SkeletonData skeletonData_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new AnimationStateData(skeletonData_0);
	}

	static AnimationState smethod_11(AnimationStateData animationStateData_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new AnimationState(animationStateData_0);
	}

	static void smethod_12(AnimationState animationState_0, CompleteDelegate completeDelegate_0)
	{
		animationState_0.add_Complete(completeDelegate_0);
	}

	static void smethod_13(AnimationState animationState_0, StartEndDelegate startEndDelegate_0)
	{
		animationState_0.add_End(startEndDelegate_0);
	}

	static void smethod_14(AnimationState animationState_0, EventDelegate eventDelegate_0)
	{
		animationState_0.add_Event(eventDelegate_0);
	}

	static void smethod_15(Skeleton skeleton_0)
	{
		skeleton_0.SetBonesToSetupPose();
	}

	static TrackEntry smethod_16(AnimationState animationState_0, int int_0, string string_0, bool bool_0)
	{
		return animationState_0.SetAnimation(int_0, string_0, bool_0);
	}

	static void smethod_17(AnimationState animationState_0)
	{
		animationState_0.ClearTracks();
	}

	static AnimationStateData smethod_18(AnimationState animationState_0)
	{
		return animationState_0.get_Data();
	}

	static void smethod_19(AnimationStateData animationStateData_0, string string_0, string string_1, float float_0)
	{
		animationStateData_0.SetMix(string_0, string_1, float_0);
	}

	static TrackEntry smethod_20(AnimationState animationState_0, int int_0, string string_0, bool bool_0, float float_0)
	{
		return animationState_0.AddAnimation(int_0, string_0, bool_0, float_0);
	}

	static bool smethod_21(string string_0)
	{
		return string.IsNullOrEmpty(string_0);
	}

	static Slot smethod_22(Skeleton skeleton_0, string string_0)
	{
		return skeleton_0.FindSlot(string_0);
	}

	static void smethod_23(Slot slot_0, float float_0)
	{
		slot_0.set_A(float_0);
	}

	static void smethod_24(Slot slot_0, float float_0)
	{
		slot_0.set_R(float_0);
	}

	static void smethod_25(Slot slot_0, float float_0)
	{
		slot_0.set_G(float_0);
	}

	static void smethod_26(Slot slot_0, float float_0)
	{
		slot_0.set_B(float_0);
	}

	static ExposedList<Slot> smethod_27(Skeleton skeleton_0)
	{
		return skeleton_0.get_Slots();
	}

	static Attachment smethod_28(Slot slot_0)
	{
		return slot_0.get_Attachment();
	}

	static Bone smethod_29(Slot slot_0)
	{
		return slot_0.get_Bone();
	}

	static float smethod_30(Bone bone_0)
	{
		return bone_0.get_WorldX();
	}

	static float smethod_31(Bone bone_0)
	{
		return bone_0.get_WorldY();
	}

	static float smethod_32(Bone bone_0)
	{
		return bone_0.get_M00();
	}

	static float smethod_33(Bone bone_0)
	{
		return bone_0.get_M01();
	}

	static float smethod_34(Bone bone_0)
	{
		return bone_0.get_M10();
	}

	static float smethod_35(Bone bone_0)
	{
		return bone_0.get_M11();
	}

	static float[] smethod_36(RegionAttachment regionAttachment_0)
	{
		return regionAttachment_0.get_Offset();
	}

	static TimeSpan smethod_37(GameTime gameTime_0)
	{
		return gameTime_0.get_ElapsedGameTime();
	}

	static void smethod_38(SkeletonMeshRenderer skeletonMeshRenderer_0, bool bool_0)
	{
		skeletonMeshRenderer_0.set_PremultipliedAlpha(bool_0);
	}

	static void smethod_39(SkeletonMeshRenderer skeletonMeshRenderer_0, float float_0, float float_1, float float_2)
	{
		skeletonMeshRenderer_0.Begin(float_0, float_1, float_2);
	}

	static void smethod_40(SkeletonMeshRenderer skeletonMeshRenderer_0, Skeleton skeleton_0, Texture2D texture2D_0, Func<int, string, bool> func_0, Color? nullable_0)
	{
		skeletonMeshRenderer_0.Draw(skeleton_0, texture2D_0, func_0, nullable_0);
	}

	static void smethod_41(SkeletonMeshRenderer skeletonMeshRenderer_0)
	{
		skeletonMeshRenderer_0.End();
	}

	static double smethod_42(double double_0)
	{
		return Math.Atan(double_0);
	}

	static Animation smethod_43(SkeletonData skeletonData_0, string string_0)
	{
		return skeletonData_0.FindAnimation(string_0);
	}

	static string smethod_44(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static ArgumentException smethod_45(string string_0)
	{
		return new ArgumentException(string_0);
	}

	static void smethod_46(Animation animation_0, Skeleton skeleton_0, float float_0, float float_1, bool bool_0, ExposedList<Event> exposedList_0)
	{
		animation_0.Apply(skeleton_0, float_0, float_1, bool_0, exposedList_0);
	}

	static void smethod_47(Skeleton skeleton_0, string string_0)
	{
		skeleton_0.SetSkin(string_0);
	}

	static void smethod_48(Skeleton skeleton_0)
	{
		skeleton_0.SetSlotsToSetupPose();
	}

	static ExposedList<Slot> smethod_49(Skeleton skeleton_0)
	{
		return skeleton_0.get_DrawOrder();
	}

	static float smethod_50(Animation animation_0)
	{
		return animation_0.get_Duration();
	}

	static void smethod_51(Animation animation_0, float float_0)
	{
		animation_0.set_Duration(float_0);
	}

	static EventData smethod_52(Event event_0)
	{
		return event_0.get_Data();
	}

	static string smethod_53(EventData eventData_0)
	{
		return eventData_0.get_Name();
	}
}
