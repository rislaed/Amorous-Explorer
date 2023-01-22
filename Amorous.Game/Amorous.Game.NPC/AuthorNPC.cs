using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class AuthorNPC : LayerNPC<AuthorNPC.EHeads, AuthorNPC.EPoses, AuthorNPC.EClothes>
{
	public enum EHeads
	{
		None
	}

	public enum EPoses
	{
		None,
		Reading
	}

	public enum EClothes
	{
		None,
		Shirt,
		Pants
	}

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = "Nik Kovak";

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(145, 109, 236);

	public AuthorNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "Assets/NPC/Author", 1f)
	{
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Reading, "Sonic Fox Expressions");
		AuthorNPC.smethod_17(AuthorNPC.smethod_16(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Reading, EClothes.Pants, "Sonic Fox Expressions - Pants")));
		AuthorNPC.smethod_19(AuthorNPC.smethod_18(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Reading, EClothes.Shirt, "Sonic Fox Expressions - Shirt")));
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
			num = 893629513;
			goto IL_0088;
		case NPCLocation.Middle:
			goto IL_0058;
		case NPCLocation.Left:
			goto IL_0066;
		case NPCLocation.Right:
			goto IL_00c2;
			IL_0088:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7BEB355Bu) % 10u)
				{
				case 9u:
					AuthorNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 618f);
					num = (int)((num2 * 2026411880) ^ 0x3BC4A4AC);
					continue;
				case 7u:
					AuthorNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 30f);
					num = (int)((num2 * 2057244075) ^ 0x1B27AC90);
					continue;
				case 5u:
					break;
				case 4u:
					goto IL_0058;
				case 3u:
					goto IL_0066;
				case 1u:
					goto IL_00c2;
				case 0u:
					return;
				default:
					AuthorNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1206f);
					AuthorNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 30f);
					return;
				case 6u:
					return;
				case 8u:
					return;
				}
				break;
			}
			goto default;
			IL_00c2:
			AuthorNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			num = 442805357;
			goto IL_0088;
			IL_0066:
			AuthorNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: true);
			AuthorNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 60f);
			AuthorNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 30f);
			num = 1031330559;
			goto IL_0088;
			IL_0058:
			AuthorNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			num = 45521558;
			goto IL_0088;
		}
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_16(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._dUWotuFGWMaIlD1IFkXcXUhjchR();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_17(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._mgkfAuKt1tsSRmn1YmxkzbHikc();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_18(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._XJUU6QdUDN3lYoRweLWOMaWqcUE();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_19(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._9mDS3yizOswyCzK6V3LBhafV7Dh();
	}

	void method_0(NPCLocation npclocation_0)
	{
		base._nGGBtYpZ8pI1BmE2c2ke63UjGDP(npclocation_0);
	}

	static void smethod_20(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, bool bool_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = bool_0;
	}

	static void smethod_21(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_22(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}
}
