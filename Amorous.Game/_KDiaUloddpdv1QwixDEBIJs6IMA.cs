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
}
