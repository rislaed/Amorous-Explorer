using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class KaneNPC : LayerNPC<KaneNPC.EHeads, KaneNPC.EPoses, KaneNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Angry
	}

	public enum EPoses
	{
		None,
		Stern
	}

	public enum EClothes
	{
		None,
		Shirt,
		Shorts
	}

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = _003CModule_003E.smethod_27<string>(3195569638u);

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(233, 193, 150);

	public KaneNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, _003CModule_003E.smethod_25<string>(2871942864u), 1f)
	{
		_je8rVfyg4zywmqSi4Ozx1z7wJ4b = 1110;
		_WJfGWBzn4wgdGBnMWRH2pcJ3AqH = 1965;
		KaneNPC.smethod_16(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Angry, _003CModule_003E.smethod_25<string>(3073390323u), _003CModule_003E.smethod_25<string>(3409136088u), _003CModule_003E.smethod_27<string>(1466406264u), _003CModule_003E.smethod_28<string>(1598186517u)), _003CModule_003E.smethod_25<string>(1985894881u));
		KaneNPC.smethod_17(_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Stern, _003CModule_003E.smethod_27<string>(1244878447u)), new string[1] { _003CModule_003E.smethod_27<string>(1480875280u) });
		KaneNPC.smethod_19(KaneNPC.smethod_18(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Stern, EClothes.Shirt, _003CModule_003E.smethod_25<string>(3946329312u))));
		KaneNPC.smethod_21(KaneNPC.smethod_20(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Stern, EClothes.Shorts, _003CModule_003E.smethod_25<string>(4212347428u))));
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	protected override string[] _zBK8PXhWw9GtXK9IHkvbuvhbigE()
	{
		return new string[8]
		{
			_003CModule_003E.smethod_26<string>(1427925550u),
			_003CModule_003E.smethod_24<string>(2031324160u),
			_003CModule_003E.smethod_28<string>(3303621489u),
			_003CModule_003E.smethod_28<string>(3531973261u),
			_003CModule_003E.smethod_28<string>(3982431609u),
			_003CModule_003E.smethod_28<string>(2748757167u),
			_003CModule_003E.smethod_25<string>(1985894881u),
			_003CModule_003E.smethod_27<string>(3079817510u)
		};
	}

	public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation npclocation_0)
	{
		this.method_0(npclocation_0);
		while (true)
		{
			int num = 2047578937;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x73846171u) % 12u)
				{
				case 10u:
					KaneNPC.smethod_23((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1070f);
					num = (int)((num2 * 1836406970) ^ 0x49AF9CD1);
					continue;
				case 9u:
					KaneNPC.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1f);
					num = ((int)num2 * -179245258) ^ -352869768;
					continue;
				case 8u:
					KaneNPC.smethod_24((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 0f);
					KaneNPC.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1f);
					num = ((int)num2 * -80609302) ^ -617810677;
					continue;
				case 7u:
					KaneNPC.smethod_24((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 0f);
					num = ((int)num2 * -1079539424) ^ -650554080;
					continue;
				case 6u:
					KaneNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: true);
					num = 1346629675;
					continue;
				case 4u:
					switch (npclocation_0)
					{
					case NPCLocation.Right:
						break;
					default:
						goto IL_00a7;
					case NPCLocation.Left:
						goto IL_00b6;
					case NPCLocation.Middle:
						goto IL_0117;
					}
					goto case 6u;
				case 1u:
					goto IL_00b6;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				case 3u:
					goto IL_0117;
				case 5u:
					return;
				case 11u:
					return;
					IL_0117:
					KaneNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
					KaneNPC.smethod_23((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 305f);
					KaneNPC.smethod_24((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 0f);
					KaneNPC.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1f);
					return;
					IL_00b6:
					KaneNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
					KaneNPC.smethod_23((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, -260f);
					num = 816061090;
					continue;
					IL_00a7:
					num = (int)((num2 * 1610289366) ^ 0x34028E44);
					continue;
				}
				break;
			}
		}
	}

	static _xmfdPa5IagU3cXbLL61gyoXAV7gA smethod_16(_xmfdPa5IagU3cXbLL61gyoXAV7gA _xmfdPa5IagU3cXbLL61gyoXAV7gA_0, string string_0)
	{
		return _xmfdPa5IagU3cXbLL61gyoXAV7gA_0._qL2MEiFtBpbdxqUUTSqOgOsEK4j(string_0);
	}

	static _NaKchYC4I4GjWR34SfBLAktysCE smethod_17(_NaKchYC4I4GjWR34SfBLAktysCE _NaKchYC4I4GjWR34SfBLAktysCE_0, string[] string_0)
	{
		return _NaKchYC4I4GjWR34SfBLAktysCE_0._6NcgB9eEKq8eKu8SgNWnKbLsDhB(string_0);
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_18(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._XJUU6QdUDN3lYoRweLWOMaWqcUE();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_19(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._9mDS3yizOswyCzK6V3LBhafV7Dh();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_20(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._dUWotuFGWMaIlD1IFkXcXUhjchR();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_21(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._mgkfAuKt1tsSRmn1YmxkzbHikc();
	}

	void method_0(NPCLocation npclocation_0)
	{
		base._nGGBtYpZ8pI1BmE2c2ke63UjGDP(npclocation_0);
	}

	static void smethod_22(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, bool bool_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = bool_0;
	}

	static void smethod_23(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_24(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}

	static void smethod_25(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._fO7gSlrDDNMoHR4FO5QXAq8fUyA = float_0;
	}
}
