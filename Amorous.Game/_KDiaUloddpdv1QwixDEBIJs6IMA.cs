using System;
using System.IO;
using Facepunch.Steamworks;

public class _KDiaUloddpdv1QwixDEBIJs6IMA
{
	private Client _f9R8NSqY1uzRQ0MIHLS7AsTyi7F;

	public bool Initialize(uint uint_0, IAmorous game)
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
			_f9R8NSqY1uzRQ0MIHLS7AsTyi7F.ScreenshotRequest += Game._VN2LxjGLZldLNfiJ1OniiaXfYBg;
			Logger.Success("Successfully loaded Steamworks, welcome {0}!", _f9R8NSqY1uzRQ0MIHLS7AsTyi7F.Username);
			return true;
		}
		catch (Exception)
		{
			Logger.Warning("Failed to load Steamworks, falling back to non-Steam version.");
		}
		return false;
	}

	public void Update()
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
