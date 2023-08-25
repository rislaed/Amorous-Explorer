using System;

public static class Clocks
{ // _5Anqe6GAAkzemoAXYpJmgMlk1yz
	private static int hour, minute;

	public static bool InRealTime { get; set; }

	public static int Hour
	{
		get
		{
			if (InRealTime)
			{
				return DateTime.Now.Hour;
			}
			return hour;
		}
		set
		{
			hour = value % 24;
		}
	}

	public static int Minute
	{
		get
		{
			if (InRealTime)
			{
				return DateTime.Now.Minute;
			}
			return minute;
		}
		set
		{
			minute = value % 60;
		}
	}

	public static TimeOfDay Date
	{
		get
		{
			if (Hour < 6 || Hour >= 20)
			{
				return TimeOfDay.Night;
			}
			if (Hour >= 10)
			{
				if (Hour < 17)
				{
					return TimeOfDay.Day;
				}
				return TimeOfDay.Sunset;
			}
			return TimeOfDay.Morning;
		}
		set
		{
			switch (value)
			{
				default:
					Hour = 0;
					break;
				case TimeOfDay.Morning:
					Hour = 9;
					break;
				case TimeOfDay.Day:
					Hour = 16;
					break;
				case TimeOfDay.Sunset:
					Hour = 19;
					break;
				case TimeOfDay.Night:
					Hour = 5;
					break;
			}
		}
	}

	public static void Update()
	{
		hour = DateTime.Now.Hour;
		minute = DateTime.Now.Minute;
	}
}
