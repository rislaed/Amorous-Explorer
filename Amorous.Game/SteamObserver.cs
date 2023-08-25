using System;
using System.IO;
using Facepunch.Steamworks;

public class SteamObserver
{ // _KDiaUloddpdv1QwixDEBIJs6IMA
	private Client client;

	public bool Initialize(uint version, IAmorous game)
	{
		try
		{
			client = new Client(version);
			if (!client.IsValid)
			{
				throw new Exception("Invalid Steam-client");
			}
			client.CustomInitialize();
			client.HookScreenshots(hook: true);
			client.ScreenshotRequest += game.RequestScreenshot;
			Logger.Success("Successfully loaded Steamworks, welcome {0}!", client.Username);
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
		client.Update();
	}

	public void AddScreenshotToLibrary(string path, int width, int height)
	{
		client.Screenshots.AddScreenshotToLibrary(Path.Combine(Directory.GetCurrentDirectory(), path), width, height);
	}

	public void TriggerAchievement(string name)
	{
		client.Achievements.Trigger(name);
	}

	public void OpenAchievements()
	{
		client.Overlay.OpenAchievements(client.SteamId);
	}

	public void OpenUrl(string url)
	{
		client.Overlay.OpenUrl(url);
	}
}
