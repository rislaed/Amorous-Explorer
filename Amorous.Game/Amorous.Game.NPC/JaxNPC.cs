using System;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class JaxNPC : SpineNPC<JaxNPC.EHeads, JaxNPC.EPoses, JaxNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Grumpy,
		Smirk,
		Sad,
		Frustrated,
		Cheeky,
		Unamused,
		Happy
	}

	public enum EPoses
	{
		None,
		Chill,
		Gesture,
		Defensive,
		Shy
	}

	public enum EClothes
	{
		None,
		TuxChest,
		TuxUnderwear,
		CasualJacket,
		CasualPants
	}

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = _003CModule_003E.smethod_26<string>(1655904249u);

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(113, 227, 255);

	public JaxNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: this(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, _003CModule_003E.smethod_28<string>(3664884735u))
	{
	}

	public JaxNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, string string_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, string_0, 1f, bool_0: true)
	{
		_je8rVfyg4zywmqSi4Ozx1z7wJ4b = 904;
		_WJfGWBzn4wgdGBnMWRH2pcJ3AqH = 1008;
		JaxNPC.smethod_19((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, new Type[2]
		{
			JaxNPC.smethod_18(typeof(JaxPurpleNPC).TypeHandle),
			JaxNPC.smethod_18(typeof(JaxRedNPC).TypeHandle)
		});
		JaxNPC.smethod_21(JaxNPC.smethod_20((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), _003CModule_003E.smethod_25<string>(3692662391u), (Action<int>)null);
		JaxNPC.smethod_22(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Grumpy, _003CModule_003E.smethod_26<string>(1955879911u), _003CModule_003E.smethod_25<string>(3977271264u), _003CModule_003E.smethod_24<string>(2620136946u)), _003CModule_003E.smethod_25<string>(82620390u));
		JaxNPC.smethod_22(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Smirk, _003CModule_003E.smethod_25<string>(351217002u), _003CModule_003E.smethod_28<string>(1856806147u), _003CModule_003E.smethod_26<string>(34665613u)), _003CModule_003E.smethod_28<string>(2367475036u));
		JaxNPC.smethod_22(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Sad, _003CModule_003E.smethod_27<string>(3789326731u), _003CModule_003E.smethod_27<string>(3074101724u), _003CModule_003E.smethod_25<string>(1960218178u), _003CModule_003E.smethod_26<string>(2105068985u)), _003CModule_003E.smethod_25<string>(3083704307u));
		JaxNPC.smethod_22(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Frustrated, _003CModule_003E.smethod_28<string>(2763968039u), _003CModule_003E.smethod_24<string>(767809608u), _003CModule_003E.smethod_24<string>(2048160849u)), _003CModule_003E.smethod_24<string>(2665603295u));
		JaxNPC.smethod_22(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Cheeky, _003CModule_003E.smethod_26<string>(3369025760u), _003CModule_003E.smethod_24<string>(1294319356u), _003CModule_003E.smethod_27<string>(3560564406u)), _003CModule_003E.smethod_24<string>(3382771742u));
		JaxNPC.smethod_22(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Unamused, _003CModule_003E.smethod_26<string>(1101360782u), _003CModule_003E.smethod_27<string>(3088570740u), _003CModule_003E.smethod_28<string>(1016099992u)), _003CModule_003E.smethod_28<string>(1809085998u));
		JaxNPC.smethod_22(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Happy, _003CModule_003E.smethod_28<string>(2091403115u), _003CModule_003E.smethod_28<string>(3899481703u), _003CModule_003E.smethod_26<string>(3626788593u), _003CModule_003E.smethod_26<string>(3879579948u)), _003CModule_003E.smethod_25<string>(3233473589u));
		JaxNPC.smethod_23(_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Chill, _003CModule_003E.smethod_26<string>(1166878221u), _003CModule_003E.smethod_26<string>(4284046116u), _003CModule_003E.smethod_26<string>(1402224669u), _003CModule_003E.smethod_25<string>(10314245u)), new string[1] { _003CModule_003E.smethod_28<string>(3539176579u) });
		JaxNPC.smethod_23(_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Gesture, _003CModule_003E.smethod_24<string>(693169383u), _003CModule_003E.smethod_27<string>(2376962987u), _003CModule_003E.smethod_24<string>(3101180345u)), new string[1] { _003CModule_003E.smethod_27<string>(3025558700u) });
		JaxNPC.smethod_23(_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Defensive, _003CModule_003E.smethod_27<string>(1649367496u), _003CModule_003E.smethod_24<string>(86564290u), _003CModule_003E.smethod_26<string>(2463948360u)), new string[1] { _003CModule_003E.smethod_26<string>(906629649u) });
		JaxNPC.smethod_23(_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Shy, _003CModule_003E.smethod_25<string>(1357696498u), _003CModule_003E.smethod_24<string>(2910521646u), _003CModule_003E.smethod_26<string>(4079327293u)), new string[1] { _003CModule_003E.smethod_28<string>(3539176579u) });
		JaxNPC.smethod_25(JaxNPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Chill, EClothes.TuxChest, _003CModule_003E.smethod_24<string>(1366915531u), _003CModule_003E.smethod_24<string>(1248853007u), _003CModule_003E.smethod_24<string>(1484978055u))));
		JaxNPC.smethod_27(JaxNPC.smethod_26(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Chill, EClothes.TuxUnderwear, _003CModule_003E.smethod_24<string>(2102420501u))));
		JaxNPC.smethod_25(JaxNPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Chill, EClothes.CasualJacket, _003CModule_003E.smethod_27<string>(1436592909u), _003CModule_003E.smethod_27<string>(2769377065u), _003CModule_003E.smethod_26<string>(2807913301u))));
		JaxNPC.smethod_27(JaxNPC.smethod_28(JaxNPC.smethod_26(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Chill, EClothes.CasualPants, _003CModule_003E.smethod_24<string>(1630920322u)))));
		JaxNPC.smethod_25(JaxNPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.TuxChest, _003CModule_003E.smethod_24<string>(1366915531u), _003CModule_003E.smethod_26<string>(188826165u), _003CModule_003E.smethod_26<string>(3414612553u))));
		JaxNPC.smethod_27(JaxNPC.smethod_26(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.TuxUnderwear, _003CModule_003E.smethod_26<string>(896641959u))));
		JaxNPC.smethod_25(JaxNPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.CasualJacket, _003CModule_003E.smethod_24<string>(1793699278u), _003CModule_003E.smethod_25<string>(4168404739u), _003CModule_003E.smethod_27<string>(1578541138u))));
		JaxNPC.smethod_27(JaxNPC.smethod_28(JaxNPC.smethod_26(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.CasualPants, _003CModule_003E.smethod_27<string>(1818155225u)))));
		JaxNPC.smethod_25(JaxNPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Defensive, EClothes.TuxChest, _003CModule_003E.smethod_26<string>(4281560377u), _003CModule_003E.smethod_27<string>(2776611573u))));
		JaxNPC.smethod_27(JaxNPC.smethod_26(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Defensive, EClothes.TuxUnderwear, _003CModule_003E.smethod_28<string>(854203957u))));
		JaxNPC.smethod_25(JaxNPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Defensive, EClothes.CasualJacket, _003CModule_003E.smethod_24<string>(1793699278u), _003CModule_003E.smethod_25<string>(2892570832u), _003CModule_003E.smethod_27<string>(3495453834u))));
		JaxNPC.smethod_27(JaxNPC.smethod_28(JaxNPC.smethod_26(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Defensive, EClothes.CasualPants, _003CModule_003E.smethod_27<string>(1818155225u)))));
		JaxNPC.smethod_25(JaxNPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.TuxChest, _003CModule_003E.smethod_24<string>(1366915531u), _003CModule_003E.smethod_25<string>(3966957280u))));
		JaxNPC.smethod_27(JaxNPC.smethod_26(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.TuxUnderwear, _003CModule_003E.smethod_28<string>(854203957u))));
		JaxNPC.smethod_25(JaxNPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.CasualJacket, _003CModule_003E.smethod_28<string>(1136521074u), _003CModule_003E.smethod_25<string>(4098677090u), _003CModule_003E.smethod_28<string>(3347337861u))));
		JaxNPC.smethod_27(JaxNPC.smethod_28(JaxNPC.smethod_26(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.CasualPants, _003CModule_003E.smethod_28<string>(2722493086u)))));
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation npclocation_0)
	{
		this.method_0(npclocation_0);
		int num;
		switch (npclocation_0)
		{
		default:
			num = 183588928;
			goto IL_0044;
		case NPCLocation.Left:
			goto IL_0022;
		case NPCLocation.Right:
			goto IL_006f;
		case NPCLocation.Middle:
			break;
			IL_0044:
			switch ((uint)(num ^ 0x797D9EB5) % 7u)
			{
			case 6u:
				break;
			case 2u:
				goto IL_0022;
			case 5u:
				goto IL_006f;
			default:
				goto end_IL_000a;
			case 1u:
				JaxNPC.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1520f);
				JaxNPC.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1100f);
				return;
			case 3u:
				return;
			case 4u:
				return;
			}
			goto default;
			IL_006f:
			JaxNPC.smethod_29((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			num = 1255791056;
			goto IL_0044;
			IL_0022:
			JaxNPC.smethod_29((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: true);
			JaxNPC.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 400f);
			JaxNPC.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1100f);
			num = 1252511167;
			goto IL_0044;
			end_IL_000a:
			break;
		}
		JaxNPC.smethod_29((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
		JaxNPC.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 960f);
		JaxNPC.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1100f);
	}

	static Type smethod_18(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static void smethod_19(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, Type[] type_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._rAt6TRbgK04lvrs5QPjcd0n26pk = type_0;
	}

	static _nHdiyIURlAiaNZ8u6MKzxjcwnyL smethod_20(_tfDAeR6npiqJMLRSXPO1DxGA0TgA _tfDAeR6npiqJMLRSXPO1DxGA0TgA_0)
	{
		return _tfDAeR6npiqJMLRSXPO1DxGA0TgA_0._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
	}

	static void smethod_21(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, Action<int> action_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._C5vPbZ72rpVMDWGuHxZuR5FNpAH(string_0, action_0);
	}

	static _xmfdPa5IagU3cXbLL61gyoXAV7gA smethod_22(_xmfdPa5IagU3cXbLL61gyoXAV7gA _xmfdPa5IagU3cXbLL61gyoXAV7gA_0, string string_0)
	{
		return _xmfdPa5IagU3cXbLL61gyoXAV7gA_0._qL2MEiFtBpbdxqUUTSqOgOsEK4j(string_0);
	}

	static _NaKchYC4I4GjWR34SfBLAktysCE smethod_23(_NaKchYC4I4GjWR34SfBLAktysCE _NaKchYC4I4GjWR34SfBLAktysCE_0, string[] string_0)
	{
		return _NaKchYC4I4GjWR34SfBLAktysCE_0._6NcgB9eEKq8eKu8SgNWnKbLsDhB(string_0);
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_24(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._XJUU6QdUDN3lYoRweLWOMaWqcUE();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_25(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._9mDS3yizOswyCzK6V3LBhafV7Dh();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_26(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._dUWotuFGWMaIlD1IFkXcXUhjchR();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_27(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._mgkfAuKt1tsSRmn1YmxkzbHikc();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_28(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._B19pyNfKCkJxZB1oCC3WzfkqEQF();
	}

	void method_0(NPCLocation npclocation_0)
	{
		base._nGGBtYpZ8pI1BmE2c2ke63UjGDP(npclocation_0);
	}

	static void smethod_29(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, bool bool_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = bool_0;
	}

	static void smethod_30(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_31(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}
}
