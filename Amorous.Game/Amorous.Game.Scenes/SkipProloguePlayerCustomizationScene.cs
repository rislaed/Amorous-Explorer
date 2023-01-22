using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Squid;

namespace Amorous.Game.Scenes;

public class SkipProloguePlayerCustomizationScene : PlayerCustomizationScene
{
	private bool _e1Kru66UIN1SkWkBreRDCF5RsWA;

	string PlayerCustomizationScene._l3SUNsFudHnZpYO0ErWgbTaz1DF => _003CModule_003E.smethod_24<string>(3335055642u);

	public SkipProloguePlayerCustomizationScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		_jIGpzoYLVPw8SPxmJcha832nCXR = true;
	}

	protected override void _n3b8BstkorCsu4TW0U2YVdFbdGp()
	{
		SkipProloguePlayerCustomizationScene.smethod_55(SkipProloguePlayerCustomizationScene.smethod_54((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), _003CModule_003E.smethod_26<string>(2321417746u), new string[2]
		{
			_003CModule_003E.smethod_27<string>(3653969611u),
			_003CModule_003E.smethod_24<string>(1208636077u)
		}, 250, (Action<int>)delegate(int int_0)
		{
			if (int_0 == 1)
			{
				while (true)
				{
					int num = -1027556224;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0xCCF28FC9u) % 4u)
						{
						case 2u:
							SkipProloguePlayerCustomizationScene.smethod_66(SkipProloguePlayerCustomizationScene.smethod_56((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), _003CModule_003E.smethod_28<string>(2783182688u));
							_e1Kru66UIN1SkWkBreRDCF5RsWA = true;
							num = ((int)num2 * -1115515197) ^ 0x6E73241B;
							continue;
						case 1u:
							SkipProloguePlayerCustomizationScene.smethod_65(SkipProloguePlayerCustomizationScene.smethod_63(SkipProloguePlayerCustomizationScene.smethod_56((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), _003CModule_003E.smethod_26<string>(2636397310u));
							num = ((int)num2 * -578363603) ^ -1169211634;
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
		});
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		this.method_0(gameTime_0);
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG_ = default(_opIJo2jLUqdOL5yAFP4yzXce0DG);
		while (true)
		{
			int num = -1278627100;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC37E3AEBu) % 11u)
				{
				case 10u:
				{
					int num5;
					int num6;
					if (SkipProloguePlayerCustomizationScene.smethod_58(SkipProloguePlayerCustomizationScene.smethod_56((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)) == null)
					{
						num5 = 216813867;
						num6 = 216813867;
					}
					else
					{
						num5 = 263447691;
						num6 = 263447691;
					}
					num = num5 ^ (int)(num2 * 814805874);
					continue;
				}
				case 9u:
					_poenyHBGUusBcnNcTFB9MQBV72R._AZrO8MxMUE7cKsFYTQ4k9O3q7yC()._Xrfjrxr72hHh4bDdQB7HzEbJUCb();
					num = ((int)num2 * -2144620913) ^ -1717643148;
					continue;
				case 8u:
				{
					int num7;
					int num8;
					if (SkipProloguePlayerCustomizationScene.smethod_57(SkipProloguePlayerCustomizationScene.smethod_56((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)))
					{
						num7 = -1678010733;
						num8 = -1678010733;
					}
					else
					{
						num7 = -1263304751;
						num8 = -1263304751;
					}
					num = num7 ^ (int)(num2 * 1332285163);
					continue;
				}
				case 7u:
					SkipProloguePlayerCustomizationScene.smethod_61(opIJo2jLUqdOL5yAFP4yzXce0DG_, _003CModule_003E.smethod_25<string>(2287578913u), 40);
					num = ((int)num2 * -1926507596) ^ 0x751CA2DF;
					continue;
				case 6u:
					SkipProloguePlayerCustomizationScene.smethod_65(SkipProloguePlayerCustomizationScene.smethod_63(SkipProloguePlayerCustomizationScene.smethod_56((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), _003CModule_003E.smethod_27<string>(1334550436u));
					SkipProloguePlayerCustomizationScene.smethod_56((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._k9wUPeU1Ga7cygiuGP8TT6aPLWF<ClubEntranceScene>();
					num = (int)((num2 * 37688924) ^ 0x488EE5B);
					continue;
				case 4u:
					_e1Kru66UIN1SkWkBreRDCF5RsWA = false;
					opIJo2jLUqdOL5yAFP4yzXce0DG_ = SkipProloguePlayerCustomizationScene.smethod_59();
					SkipProloguePlayerCustomizationScene.smethod_60(opIJo2jLUqdOL5yAFP4yzXce0DG_, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Coby);
					num = (int)((num2 * 558830294) ^ 0x7298CEDB);
					continue;
				case 3u:
					SkipProloguePlayerCustomizationScene.smethod_64(SkipProloguePlayerCustomizationScene.smethod_63(SkipProloguePlayerCustomizationScene.smethod_56((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Coby);
					num = (int)(num2 * 1514281406) ^ -1403623560;
					continue;
				case 2u:
					SkipProloguePlayerCustomizationScene.smethod_62(opIJo2jLUqdOL5yAFP4yzXce0DG_, _003CModule_003E.smethod_24<string>(4172742065u), bool_0: true);
					_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = true;
					num = ((int)num2 * -931895477) ^ -1516820463;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!_e1Kru66UIN1SkWkBreRDCF5RsWA)
					{
						num3 = 962278223;
						num4 = 962278223;
					}
					else
					{
						num3 = 116114239;
						num4 = 116114239;
					}
					num = num3 ^ ((int)num2 * -1436532952);
					continue;
				}
				default:
					return;
				case 0u:
					break;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	[CompilerGenerated]
	private void _uT0nhPqOYeKCBWg0fkE9TeKYm4l(int int_0)
	{
		if (int_0 != 1)
		{
			return;
		}
		while (true)
		{
			int num = -1027556224;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCCF28FC9u) % 4u)
				{
				case 2u:
					SkipProloguePlayerCustomizationScene.smethod_66(SkipProloguePlayerCustomizationScene.smethod_56((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), _003CModule_003E.smethod_28<string>(2783182688u));
					_e1Kru66UIN1SkWkBreRDCF5RsWA = true;
					num = ((int)num2 * -1115515197) ^ 0x6E73241B;
					continue;
				case 1u:
					SkipProloguePlayerCustomizationScene.smethod_65(SkipProloguePlayerCustomizationScene.smethod_63(SkipProloguePlayerCustomizationScene.smethod_56((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), _003CModule_003E.smethod_26<string>(2636397310u));
					num = ((int)num2 * -578363603) ^ -1169211634;
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

	static Desktop smethod_54(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._PnkAlVnMv0SZvRBFexqzE5DF9tp;
	}

	static void smethod_55(Desktop desktop_0, string string_0, string[] string_1, int int_0, Action<int> action_0)
	{
		desktop_0._GtkWDtXwQHwgWY4aFkacjfUDyzb(string_0, string_1, int_0, action_0);
	}

	void method_0(GameTime gameTime_0)
	{
		base._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
	}

	static _JbeCmOie0phb2cbgG6DdGZrbs3pB smethod_56(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._ZzBuoSDMWwerejOO9Goyv2OCKgE;
	}

	static bool smethod_57(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._NdzU0m9x8QDKpVv3DrQmzY5KduB;
	}

	static _nR8eroJOHehP0ZGyyTveo6aMTHg smethod_58(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._5zNdOw7qHmuCAPJFMr3SsZdBlCr;
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG smethod_59()
	{
		return _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
	}

	static void smethod_60(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts ephoneContacts_0)
	{
		_opIJo2jLUqdOL5yAFP4yzXce0DG_0._modEEaw3I1w8Mt0usyRNoa4Ri0H(ephoneContacts_0);
	}

	static void smethod_61(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0, string string_0, int int_0)
	{
		_opIJo2jLUqdOL5yAFP4yzXce0DG_0._fPyIv5zbbSj5sjZlbAwQTFXnJ5G(string_0, int_0);
	}

	static void smethod_62(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0, string string_0, bool bool_0)
	{
		_opIJo2jLUqdOL5yAFP4yzXce0DG_0._4Fscz8ryB3hm0NmL5xw39HHiPd1(string_0, bool_0);
	}

	static _691ooXdgg17CWFkMkjedKBBBfYw smethod_63(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._aJh9CibG5YKhkExxgRyVopdfSeJ;
	}

	static void smethod_64(_691ooXdgg17CWFkMkjedKBBBfYw _691ooXdgg17CWFkMkjedKBBBfYw_0, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts ephoneContacts_0)
	{
		_691ooXdgg17CWFkMkjedKBBBfYw_0._rGMDL1kMYXSwaZiIoINCo5AqZuM(ephoneContacts_0);
	}

	static void smethod_65(_691ooXdgg17CWFkMkjedKBBBfYw _691ooXdgg17CWFkMkjedKBBBfYw_0, string string_0)
	{
		_691ooXdgg17CWFkMkjedKBBBfYw_0._vVZVLriSGPExpn1KeobglMabsoi(string_0);
	}

	static void smethod_66(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, string string_0)
	{
		_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._xyl3Tv5KdR5eezDgagxbBcS3cwt(string_0);
	}
}
