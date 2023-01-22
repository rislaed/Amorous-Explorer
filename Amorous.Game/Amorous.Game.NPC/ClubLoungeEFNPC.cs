using Amorous.Engine.NPC;

namespace Amorous.Game.NPC;

public class ClubLoungeEFNPC : LayerNPC<ClubLoungeEFNPC.EHeads, ClubLoungeEFNPC.EPoses, ClubLoungeEFNPC.EClothes>
{
	public enum EHeads
	{
		None
	}

	public enum EPoses
	{
		None,
		Sitting
	}

	public enum EClothes
	{
		None,
		Shirt,
		Pants
	}

	public ClubLoungeEFNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "Assets/NPC/ClubLoungeStatic", 1f)
	{
		while (true)
		{
			int num = 882287335;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x69E5F88Eu) % 3u)
				{
				case 1u:
					goto IL_0017;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0017:
				ClubLoungeEFNPC.smethod_16(_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Sitting, "E F club nude"), new string[1] { "E F club nude cock" });
				ClubLoungeEFNPC.smethod_18(ClubLoungeEFNPC.smethod_17(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Sitting, EClothes.Shirt, "E F club shirt")));
				ClubLoungeEFNPC.smethod_20(ClubLoungeEFNPC.smethod_19(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Sitting, EClothes.Pants, "E F club pants")));
				_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
				_upl1k7yzBzlU7vErvbydGmXROfA = true;
				num = (int)(num2 * 1487517905) ^ -1297025496;
			}
		}
	}

	static _NaKchYC4I4GjWR34SfBLAktysCE smethod_16(_NaKchYC4I4GjWR34SfBLAktysCE _NaKchYC4I4GjWR34SfBLAktysCE_0, string[] string_0)
	{
		return _NaKchYC4I4GjWR34SfBLAktysCE_0._6NcgB9eEKq8eKu8SgNWnKbLsDhB(string_0);
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_17(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._XJUU6QdUDN3lYoRweLWOMaWqcUE();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_18(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._9mDS3yizOswyCzK6V3LBhafV7Dh();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_19(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._dUWotuFGWMaIlD1IFkXcXUhjchR();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_20(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._mgkfAuKt1tsSRmn1YmxkzbHikc();
	}
}
