using System;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class SkyeNPC : SpineNPC<SkyeNPC.EHeads, SkyeNPC.EPoses, SkyeNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Angry,
		Blush,
		Sad,
		Happy,
		Neutral
	}

	public enum EPoses
	{
		None,
		Suggestive,
		Guarded
	}

	public enum EClothes
	{
		None,
		Hoodie,
		Shirt,
		Shorts
	}

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = "Skye";

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(248, 255, 167);

	public SkyeNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "Assets/NPC/Skye/Skye", 1f, bool_0: true)
	{
		SkyeNPC.smethod_19((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, new Type[2]
		{
			SkyeNPC.smethod_18(typeof(SkyeBlueNPC).TypeHandle),
			SkyeNPC.smethod_18(typeof(SkyeGrayNPC).TypeHandle)
		});
		SkyeNPC.smethod_21(SkyeNPC.smethod_20((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), "Idle", (Action<int>)null);
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Angry, "Angry Head", "Angry pupil", "Angry eyeback");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Blush, "Blush head", "Blush pupils", "Blush eye back");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Sad, "Sad Head", "Sad pupil", "Sad eye back");
		SkyeNPC.smethod_22(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Happy, "Happy head", "Happy pupil", "Happy eye back", "Happy jaw"), "Happy blink");
		SkyeNPC.smethod_22(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Neutral, "Neutral head", "Neutral pupil", "Neutral eye back", "Neutral jaw"), "Neutral blink");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Suggestive, "Suggestive Body", "Suggestive boobs", "Suggestive Tail");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Guarded, "Guarded body", "Guarded boobs", "Guarded boob cover", "Guarded tail");
		SkyeNPC.smethod_25(SkyeNPC.smethod_24(SkyeNPC.smethod_23(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Suggestive, EClothes.Hoodie, "Suggestive hoodie"))));
		SkyeNPC.smethod_25(SkyeNPC.smethod_23(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Suggestive, EClothes.Shirt, "Suggestive shirt")));
		SkyeNPC.smethod_28(SkyeNPC.smethod_27(SkyeNPC.smethod_26(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Suggestive, EClothes.Shorts, "Suggestive shorts"))));
		SkyeNPC.smethod_25(SkyeNPC.smethod_24(SkyeNPC.smethod_23(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Guarded, EClothes.Hoodie, "Guarded hoodie"))));
		SkyeNPC.smethod_25(SkyeNPC.smethod_23(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Guarded, EClothes.Shirt, "Guarded shirt")));
		SkyeNPC.smethod_28(SkyeNPC.smethod_27(SkyeNPC.smethod_26(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Guarded, EClothes.Shorts, "Guarded shorts"))));
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = true;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation npclocation_0)
	{
		this.method_0(npclocation_0);
		switch (npclocation_0)
		{
		default:
			SkyeNPC.smethod_29((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			SkyeNPC.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 960f);
			SkyeNPC.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1120f);
			break;
		case NPCLocation.Right:
			SkyeNPC.smethod_29((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: true);
			SkyeNPC.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1520f);
			SkyeNPC.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1120f);
			break;
		case NPCLocation.Left:
			SkyeNPC.smethod_29((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			SkyeNPC.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 400f);
			SkyeNPC.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1120f);
			break;
		}
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

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_23(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._XJUU6QdUDN3lYoRweLWOMaWqcUE();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_24(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._KCZzL8xtjbw97bTOV0k8JDz3olE();
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
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._B19pyNfKCkJxZB1oCC3WzfkqEQF();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_28(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._mgkfAuKt1tsSRmn1YmxkzbHikc();
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
