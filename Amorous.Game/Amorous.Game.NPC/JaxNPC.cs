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

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = "Jax";

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(113, 227, 255);

	public JaxNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: this(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "Assets/NPC/Jax/Jax")
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
		JaxNPC.smethod_21(JaxNPC.smethod_20((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), "animation", (Action<int>)null);
		JaxNPC.smethod_22(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Grumpy, "Grumpy Head", "Grumpy pupils", "Grumpy eyes back"), "Grumpy Blink");
		JaxNPC.smethod_22(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Smirk, "Smirk head", "Smirk pupils", "Smirk eyes back"), "Smirk Blink");
		JaxNPC.smethod_22(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Sad, "Sad Head", "Sad pupil", "Sad eye back", "Flirty Jaw"), "Sad blink");
		JaxNPC.smethod_22(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Frustrated, "Frustrated Head", "Frustrated pupil", "Frustrated eye back"), "Frustrated blink");
		JaxNPC.smethod_22(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Cheeky, "Cheeky Head", "Cheeky pupils", "Cheeky eye back"), "Cheeky Blink");
		JaxNPC.smethod_22(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Unamused, "Unamused Head", "Unamused Pupils", "Unamused eye back"), "Unamused Blink");
		JaxNPC.smethod_22(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Happy, "Happy head", "Happy pupil", "Happy eye back", "Happy jaw"), "Happy Blink");
		JaxNPC.smethod_23(_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Chill, "Body", "Right arm GestureChill", "Left arm chill", "Left thumb Chill"), new string[1] { "Cock" });
		JaxNPC.smethod_23(_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Gesture, "Body", "Right arm GestureChill", "Left arm Gesture"), new string[1] { "Cock" });
		JaxNPC.smethod_23(_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Defensive, "Body", "Right arm defensive", "Left Arm defensive"), new string[1] { "Cock" });
		JaxNPC.smethod_23(_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Shy, "Body", "Right arm shy", "Left arm shy"), new string[1] { "Cock" });
		JaxNPC.smethod_25(JaxNPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Chill, EClothes.TuxChest, "Tux chest", "Tux Right arm GestureChill", "Tux Left arm chill")));
		JaxNPC.smethod_27(JaxNPC.smethod_26(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Chill, EClothes.TuxUnderwear, "Tux underwear")));
		JaxNPC.smethod_25(JaxNPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Chill, EClothes.CasualJacket, "Casual body", "Casual right arm GestureChill", "Casual left arm chill")));
		JaxNPC.smethod_27(JaxNPC.smethod_28(JaxNPC.smethod_26(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Chill, EClothes.CasualPants, "Casual shorts"))));
		JaxNPC.smethod_25(JaxNPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.TuxChest, "Tux chest", "Tux Right arm GestureChill", "Tux left arm gesture")));
		JaxNPC.smethod_27(JaxNPC.smethod_26(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.TuxUnderwear, "Tux underwear")));
		JaxNPC.smethod_25(JaxNPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.CasualJacket, "Casual body", "Casual right arm GestureChill", "Casual left arm Gesture copy 2")));
		JaxNPC.smethod_27(JaxNPC.smethod_28(JaxNPC.smethod_26(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.CasualPants, "Casual shorts"))));
		JaxNPC.smethod_25(JaxNPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Defensive, EClothes.TuxChest, "Tux chest", "Tux Right arm defensive")));
		JaxNPC.smethod_27(JaxNPC.smethod_26(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Defensive, EClothes.TuxUnderwear, "Tux underwear")));
		JaxNPC.smethod_25(JaxNPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Defensive, EClothes.CasualJacket, "Casual body", "Casual right arm defensive", "Casual left arm defensive")));
		JaxNPC.smethod_27(JaxNPC.smethod_28(JaxNPC.smethod_26(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Defensive, EClothes.CasualPants, "Casual shorts"))));
		JaxNPC.smethod_25(JaxNPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.TuxChest, "Tux chest", "Tux right arm shy")));
		JaxNPC.smethod_27(JaxNPC.smethod_26(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.TuxUnderwear, "Tux underwear")));
		JaxNPC.smethod_25(JaxNPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.CasualJacket, "Casual body", "Casual right arm shy", "Casual left arm shy")));
		JaxNPC.smethod_27(JaxNPC.smethod_28(JaxNPC.smethod_26(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.CasualPants, "Casual shorts"))));
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
