using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class SecurityGuardNPC : LayerNPC<SecurityGuardNPC.EHeads, SecurityGuardNPC.EPoses, SecurityGuardNPC.EClothes>
{
	public enum EHeads
	{
		None
	}

	public enum EPoses
	{
		None,
		Neutral
	}

	public enum EClothes
	{
		None,
		Shirt,
		Pants
	}

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = "Alexis Pryde";

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(17, 178, 105);

	public SecurityGuardNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "Assets/NPC/SecurityGuard", 1f)
	{
		while (true)
		{
			int num = -403412830;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x99EEC9B4u) % 9u)
				{
				case 7u:
					_J4giDjnRtYmiHMmzwRZ0ThvfAhH = true;
					num = ((int)num2 * -476942026) ^ 0x5B46C60F;
					continue;
				case 6u:
					_upl1k7yzBzlU7vErvbydGmXROfA = true;
					num = (int)(num2 * 1163922627) ^ -982985676;
					continue;
				case 5u:
					_WJfGWBzn4wgdGBnMWRH2pcJ3AqH = 945;
					num = ((int)num2 * -1250901560) ^ -470928619;
					continue;
				case 3u:
					_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Neutral, "Alexis Nude", "Alexis Tufts");
					num = (int)((num2 * 1957525581) ^ 0x1E8D9640);
					continue;
				case 2u:
					_je8rVfyg4zywmqSi4Ozx1z7wJ4b = 452;
					num = (int)(num2 * 1182762663) ^ -2097610273;
					continue;
				case 1u:
					SecurityGuardNPC.smethod_19(SecurityGuardNPC.smethod_18(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.Pants, "Alexis Pants")));
					num = (int)((num2 * 1635205519) ^ 0x7A155D0D);
					continue;
				case 0u:
					SecurityGuardNPC.smethod_17(SecurityGuardNPC.smethod_16(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.Shirt, "Alexis Shirt")));
					num = (int)(num2 * 482151371) ^ -657123347;
					continue;
				default:
					return;
				case 8u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	protected override string[] _zBK8PXhWw9GtXK9IHkvbuvhbigE()
	{
		return new string[4] { "Alexis Nude", "Alexis Tufts", "Alexis Pants", "Alexis Shirt" };
	}

	public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation npclocation_0)
	{
		this.method_0(npclocation_0);
		while (true)
		{
			int num = -740146722;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEEC341C3u) % 14u)
				{
				case 12u:
					SecurityGuardNPC.smethod_23((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1f);
					num = ((int)num2 * -1215281991) ^ 0x1752E1E5;
					continue;
				case 11u:
					SecurityGuardNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 135f);
					num = (int)(num2 * 755749015) ^ -752220436;
					continue;
				case 10u:
					SecurityGuardNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
					num = -402760903;
					continue;
				case 9u:
					switch (npclocation_0)
					{
					case NPCLocation.Right:
						break;
					default:
						goto IL_006b;
					case NPCLocation.Middle:
						goto IL_007a;
					case NPCLocation.Left:
						goto IL_0088;
					}
					goto case 10u;
				case 1u:
					goto IL_007a;
				case 7u:
					goto IL_0088;
				case 8u:
					SecurityGuardNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 734f);
					SecurityGuardNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 135f);
					num = (int)((num2 * 417172741) ^ 0x1CC7CFF5);
					continue;
				case 6u:
					SecurityGuardNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 100f);
					SecurityGuardNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 135f);
					num = (int)(num2 * 363879549) ^ -762389396;
					continue;
				case 2u:
					SecurityGuardNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1368f);
					num = ((int)num2 * -1883466856) ^ -261074398;
					continue;
				case 3u:
					break;
				default:
					SecurityGuardNPC.smethod_23((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1f);
					return;
				case 4u:
					return;
				case 5u:
					SecurityGuardNPC.smethod_23((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1f);
					return;
				case 13u:
					return;
					IL_0088:
					SecurityGuardNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: true);
					num = -999817325;
					continue;
					IL_007a:
					SecurityGuardNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
					num = -221955353;
					continue;
					IL_006b:
					num = (int)((num2 * 1197902466) ^ 0x77C0C21A);
					continue;
				}
				break;
			}
		}
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_16(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._XJUU6QdUDN3lYoRweLWOMaWqcUE();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_17(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._9mDS3yizOswyCzK6V3LBhafV7Dh();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_18(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._dUWotuFGWMaIlD1IFkXcXUhjchR();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_19(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._mgkfAuKt1tsSRmn1YmxkzbHikc();
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

	static void smethod_23(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._fO7gSlrDDNMoHR4FO5QXAq8fUyA = float_0;
	}
}
