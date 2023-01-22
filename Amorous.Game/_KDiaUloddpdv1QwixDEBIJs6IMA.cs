using System;
using System.IO;
using Facepunch.Steamworks;

public class _KDiaUloddpdv1QwixDEBIJs6IMA
{
	private Client _f9R8NSqY1uzRQ0MIHLS7AsTyi7F;

	public bool _oD87G7SXjsTukw7IVWxVlVFEgvA(uint uint_0, _JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		try
		{
			_f9R8NSqY1uzRQ0MIHLS7AsTyi7F = _KDiaUloddpdv1QwixDEBIJs6IMA.smethod_0(uint_0);
			if (!_KDiaUloddpdv1QwixDEBIJs6IMA.smethod_1((BaseSteamworks)(object)_f9R8NSqY1uzRQ0MIHLS7AsTyi7F))
			{
				throw _KDiaUloddpdv1QwixDEBIJs6IMA.smethod_2("Invalid Steam-client");
			}
			_KDiaUloddpdv1QwixDEBIJs6IMA.smethod_3(_f9R8NSqY1uzRQ0MIHLS7AsTyi7F);
			_KDiaUloddpdv1QwixDEBIJs6IMA.smethod_4(_f9R8NSqY1uzRQ0MIHLS7AsTyi7F, bool_0: true);
			_KDiaUloddpdv1QwixDEBIJs6IMA.smethod_5(_f9R8NSqY1uzRQ0MIHLS7AsTyi7F, new ScreenshotRequestDelegate(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._VN2LxjGLZldLNfiJ1OniiaXfYBg));
			_KDiaUloddpdv1QwixDEBIJs6IMA.smethod_7("Successfully loaded Steamworks, welcome {0}!", new object[1] { _KDiaUloddpdv1QwixDEBIJs6IMA.smethod_6(_f9R8NSqY1uzRQ0MIHLS7AsTyi7F) });
			return true;
		}
		catch (Exception)
		{
			_KDiaUloddpdv1QwixDEBIJs6IMA.smethod_8("Failed to load Steamworks, falling back to non-Steam version.", new object[0]);
		}
		return false;
	}

	public void _tiBFUHPEkedkbgvuX3whdeyjhKo()
	{
		_KDiaUloddpdv1QwixDEBIJs6IMA.smethod_9((BaseSteamworks)(object)_f9R8NSqY1uzRQ0MIHLS7AsTyi7F);
	}

	public void _9K6cA2OPGJaecqk3spsceT9ilNI(string string_0, int int_0, int int_1)
	{
		_KDiaUloddpdv1QwixDEBIJs6IMA.smethod_13(_KDiaUloddpdv1QwixDEBIJs6IMA.smethod_10(_f9R8NSqY1uzRQ0MIHLS7AsTyi7F), _KDiaUloddpdv1QwixDEBIJs6IMA.smethod_12(_KDiaUloddpdv1QwixDEBIJs6IMA.smethod_11(), string_0), int_0, int_1);
	}

	public void _vVZVLriSGPExpn1KeobglMabsoi(string string_0)
	{
		_KDiaUloddpdv1QwixDEBIJs6IMA.smethod_15(_KDiaUloddpdv1QwixDEBIJs6IMA.smethod_14(_f9R8NSqY1uzRQ0MIHLS7AsTyi7F), string_0, bool_0: true);
	}

	public void _jUIwOLgbKJ8tJmUAAQs6pm6ZGWb()
	{
		_KDiaUloddpdv1QwixDEBIJs6IMA.smethod_18(_KDiaUloddpdv1QwixDEBIJs6IMA.smethod_16(_f9R8NSqY1uzRQ0MIHLS7AsTyi7F), _KDiaUloddpdv1QwixDEBIJs6IMA.smethod_17(_f9R8NSqY1uzRQ0MIHLS7AsTyi7F));
	}

	public void _fDSidqggP063WGf2vzkdlA1UDkn(string string_0)
	{
		_KDiaUloddpdv1QwixDEBIJs6IMA.smethod_19(_KDiaUloddpdv1QwixDEBIJs6IMA.smethod_16(_f9R8NSqY1uzRQ0MIHLS7AsTyi7F), string_0);
	}

	static Client smethod_0(uint uint_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Client(uint_0);
	}

	static bool smethod_1(BaseSteamworks baseSteamworks_0)
	{
		return baseSteamworks_0.get_IsValid();
	}

	static Exception smethod_2(string string_0)
	{
		return new Exception(string_0);
	}

	static void smethod_3(Client client_0)
	{
		client_0.CustomInitialize();
	}

	static void smethod_4(Client client_0, bool bool_0)
	{
		client_0.HookScreenshots(bool_0);
	}

	static void smethod_5(Client client_0, ScreenshotRequestDelegate screenshotRequestDelegate_0)
	{
		client_0.add_ScreenshotRequest(screenshotRequestDelegate_0);
	}

	static string smethod_6(Client client_0)
	{
		return client_0.get_Username();
	}

	static void smethod_7(string string_0, object[] object_0)
	{
		_ETHljYp3aQy9GQ1ZAzhfOYDI1sO._JmIDYFXDf2wcAGArwRlNg4WYoUEA(string_0, object_0);
	}

	static void smethod_8(string string_0, object[] object_0)
	{
		_ETHljYp3aQy9GQ1ZAzhfOYDI1sO._IGmWy5uYuv50rXGtBNbMPGzJhWh(string_0, object_0);
	}

	static void smethod_9(BaseSteamworks baseSteamworks_0)
	{
		baseSteamworks_0.Update();
	}

	static Screenshots smethod_10(Client client_0)
	{
		return client_0.get_Screenshots();
	}

	static string smethod_11()
	{
		return Directory.GetCurrentDirectory();
	}

	static string smethod_12(string string_0, string string_1)
	{
		return Path.Combine(string_0, string_1);
	}

	static void smethod_13(Screenshots screenshots_0, string string_0, int int_0, int int_1)
	{
		screenshots_0.AddScreenshotToLibrary(string_0, int_0, int_1);
	}

	static Achievements smethod_14(Client client_0)
	{
		return client_0.get_Achievements();
	}

	static bool smethod_15(Achievements achievements_0, string string_0, bool bool_0)
	{
		return achievements_0.Trigger(string_0, bool_0);
	}

	static Overlay smethod_16(Client client_0)
	{
		return client_0.get_Overlay();
	}

	static ulong smethod_17(Client client_0)
	{
		return client_0.get_SteamId();
	}

	static void smethod_18(Overlay overlay_0, ulong ulong_0)
	{
		overlay_0.OpenAchievements(ulong_0);
	}

	static void smethod_19(Overlay overlay_0, string string_0)
	{
		overlay_0.OpenUrl(string_0);
	}
}
