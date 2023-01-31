public static class Censorship
{ // _iExD93IWLlzVfXsU9wyrEvWgJsg
	private static bool _censored, _topless, _bottomless;

	public static bool Booties { get; set; }

	public static bool Censored
	{
		get
		{
			return _censored;
		}
		set
		{
			_censored = value;
			Options.Data.CheatsCensored = value;
			Options.Save();
		}
	}

	public static bool Topless
	{
		get
		{
			return _topless;
		}
		set
		{
			_topless = value;
			Options.Data.CheatsTopless = value;
			Options.Save();
		}
	}

	public static bool Bottomless
	{
		get
		{
			return _bottomless;
		}
		set
		{
			_bottomless = value;
			Options.Data.CheatsBottomless = value;
			Options.Save();
		}
	}

	public static void SetBooties(bool enabled)
	{
		Booties = enabled;
		if (enabled)
		{
			_censored = Options.Data.CheatsCensored;
			_topless = Options.Data.CheatsTopless;
			_bottomless = Options.Data.CheatsBottomless;
		}
		else
		{
			_censored = true;
			_topless = false;
			_bottomless = false;
		}
	}
}
