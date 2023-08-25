public static class Censorship
{ // _iExD93IWLlzVfXsU9wyrEvWgJsg
	private static bool censored, topless, bottomless;

	public static bool Booties { get; set; }

	public static bool Censored
	{
		get
		{
			return censored;
		}
		set
		{
			censored = value;
			Options.Config.CheatsCensored = value;
			Options.Save();
		}
	}

	public static bool Topless
	{
		get
		{
			return topless;
		}
		set
		{
			topless = value;
			Options.Config.CheatsTopless = value;
			Options.Save();
		}
	}

	public static bool Bottomless
	{
		get
		{
			return bottomless;
		}
		set
		{
			bottomless = value;
			Options.Config.CheatsBottomless = value;
			Options.Save();
		}
	}

	public static void SetBooties(bool enabled)
	{
		Booties = enabled;
		if (enabled)
		{
			censored = Options.Config.CheatsCensored;
			topless = Options.Config.CheatsTopless;
			bottomless = Options.Config.CheatsBottomless;
		}
		else
		{
			censored = true;
			topless = false;
			bottomless = false;
		}
	}
}
