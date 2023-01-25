public static class _iExD93IWLlzVfXsU9wyrEvWgJsg
{
	private static bool _2qexqDN17QOGk7LFQW1T3vAJIJb;

	private static bool _nZQfaQI5v3Fi6jmkLjjAPOetwYJ;

	private static bool _1MShb5FQgVzdfk0syl7rctYJYKk;

	public static bool _X41qA9hgcgXH0Q1aFKWFWpg8UuM { get; set; }

	public static bool _4xsgdTzAotLBDxTjCbQBCY4YtpF
	{
		get
		{
			return _2qexqDN17QOGk7LFQW1T3vAJIJb;
		}
		set
		{
			_2qexqDN17QOGk7LFQW1T3vAJIJb = value;
			Options.Data.CheatsCensored = value;
			Options.Save();
		}
	}

	public static bool _b52DDz3MN1kD8sgdQhCNO1tJRNn
	{
		get
		{
			return _nZQfaQI5v3Fi6jmkLjjAPOetwYJ;
		}
		set
		{
			_nZQfaQI5v3Fi6jmkLjjAPOetwYJ = value;
			Options.Data.CheatsTopless = value;
			Options.Save();
		}
	}

	public static bool _pKBiGAgDu5WqoykkGBaEGnP7oMj
	{
		get
		{
			return _1MShb5FQgVzdfk0syl7rctYJYKk;
		}
		set
		{
			_1MShb5FQgVzdfk0syl7rctYJYKk = value;
			Options.Data.CheatsBottomless = value;
			Options.Save();
		}
	}

	public static void _qrFhbSiCFS6nLCN231ubbRQQeXE(bool bool_0)
	{
		_X41qA9hgcgXH0Q1aFKWFWpg8UuM = bool_0;
		if (bool_0)
		{
			_2qexqDN17QOGk7LFQW1T3vAJIJb = Options.Data.CheatsCensored;
			_nZQfaQI5v3Fi6jmkLjjAPOetwYJ = Options.Data.CheatsTopless;
			_1MShb5FQgVzdfk0syl7rctYJYKk = Options.Data.CheatsBottomless;
		}
		else
		{
			_2qexqDN17QOGk7LFQW1T3vAJIJb = true;
			_nZQfaQI5v3Fi6jmkLjjAPOetwYJ = false;
			_1MShb5FQgVzdfk0syl7rctYJYKk = false;
		}
	}
}
