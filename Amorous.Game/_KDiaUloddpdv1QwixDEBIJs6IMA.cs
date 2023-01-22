using System;
using System.IO;
using Facepunch.Steamworks;

public class _KDiaUloddpdv1QwixDEBIJs6IMA
{
	private Client _f9R8NSqY1uzRQ0MIHLS7AsTyi7F;

	public bool _oD87G7SXjsTukw7IVWxVlVFEgvA(uint uint_0, _JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		try
		{
			_f9R8NSqY1uzRQ0MIHLS7AsTyi7F = new Client(uint_0);
			if (!_f9R8NSqY1uzRQ0MIHLS7AsTyi7F.IsValid)
			{
				throw new Exception("Invalid Steam-client");
			}
			_f9R8NSqY1uzRQ0MIHLS7AsTyi7F.CustomInitialize();
			_f9R8NSqY1uzRQ0MIHLS7AsTyi7F.HookScreenshots(hook: true);
			_f9R8NSqY1uzRQ0MIHLS7AsTyi7F.ScreenshotRequest += _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._VN2LxjGLZldLNfiJ1OniiaXfYBg;
			_ETHljYp3aQy9GQ1ZAzhfOYDI1sO._JmIDYFXDf2wcAGArwRlNg4WYoUEA("Successfully loaded Steamworks, welcome {0}!", _f9R8NSqY1uzRQ0MIHLS7AsTyi7F.Username);
			return true;
		}
		catch (Exception)
		{
			_ETHljYp3aQy9GQ1ZAzhfOYDI1sO._IGmWy5uYuv50rXGtBNbMPGzJhWh("Failed to load Steamworks, falling back to non-Steam version.");
		}
		return false;
	}

	public void _tiBFUHPEkedkbgvuX3whdeyjhKo()
	{
		_f9R8NSqY1uzRQ0MIHLS7AsTyi7F.Update();
	}

	public void _9K6cA2OPGJaecqk3spsceT9ilNI(string string_0, int int_0, int int_1)
	{
		_f9R8NSqY1uzRQ0MIHLS7AsTyi7F.Screenshots.AddScreenshotToLibrary(Path.Combine(Directory.GetCurrentDirectory(), string_0), int_0, int_1);
	}

	public void _vVZVLriSGPExpn1KeobglMabsoi(string string_0)
	{
		_f9R8NSqY1uzRQ0MIHLS7AsTyi7F.Achievements.Trigger(string_0);
	}

	public void _jUIwOLgbKJ8tJmUAAQs6pm6ZGWb()
	{
		_f9R8NSqY1uzRQ0MIHLS7AsTyi7F.Overlay.OpenAchievements(_f9R8NSqY1uzRQ0MIHLS7AsTyi7F.SteamId);
	}

	public void _fDSidqggP063WGf2vzkdlA1UDkn(string string_0)
	{
		_f9R8NSqY1uzRQ0MIHLS7AsTyi7F.Overlay.OpenUrl(string_0);
	}

	static Client smethod_0(uint uint_0)
	{
		return new Client(uint_0);
	}

	static bool smethod_1(BaseSteamworks baseSteamworks_0)
	{
		return baseSteamworks_0.IsValid;
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

	static void smethod_5(Client client_0, Client.ScreenshotRequestDelegate screenshotRequestDelegate_0)
	{
		client_0.ScreenshotRequest += screenshotRequestDelegate_0;
	}

	static string smethod_6(Client client_0)
	{
		return client_0.Username;
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
		return client_0.Screenshots;
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
		return client_0.Achievements;
	}

	static bool smethod_15(Achievements achievements_0, string string_0, bool bool_0)
	{
		return achievements_0.Trigger(string_0, bool_0);
	}

	static Overlay smethod_16(Client client_0)
	{
		return client_0.Overlay;
	}

	static ulong smethod_17(Client client_0)
	{
		return client_0.SteamId;
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
