using System;
using System.IO;
using Facepunch.Steamworks;

public class SteamObserver
{
	private Client _client;

	public bool Initialize(uint version, IAmorous game)
	{
		try
		{
			_client = new Client(version);
			if (!_client.IsValid)
			{
				throw new Exception("Invalid Steam-client");
			}
			_client.CustomInitialize();
			_client.HookScreenshots(hook: true);
			_client.ScreenshotRequest += game.RequestScreenshot;
			Logger.Success("Successfully loaded Steamworks, welcome {0}!", _client.Username);
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
		_client.Update();
	}

	public void AddScreenshotToLibrary(string path, int width, int height)
	{
		_client.Screenshots.AddScreenshotToLibrary(Path.Combine(Directory.GetCurrentDirectory(), path), width, height);
	}

	public void GainAchievement(string name)
	{
		_client.Achievements.Trigger(name);
	}

	public void OpenAchievements()
	{
		_client.Overlay.OpenAchievements(_client.SteamId);
	}

	public void OpenUrl(string url)
	{
		_client.Overlay.OpenUrl(url);
	}
}
