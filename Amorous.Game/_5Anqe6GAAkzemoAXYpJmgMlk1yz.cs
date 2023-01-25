using System;

public static class _5Anqe6GAAkzemoAXYpJmgMlk1yz
{
	private static int _MCt0M1Mie6CJZK5aaLFRpJ6GX8p;

	private static int _Z1SLWwHGdyLqUEpbiNgLmqo2zUh;

	public static bool _3DInasj5B11bCcV5BIRvLE1Ay7w { get; set; }

	public static int _K9Elfb3mqQp0B5Vj74ibvRwgdGu
	{
		get
		{
			if (_3DInasj5B11bCcV5BIRvLE1Ay7w)
			{
				return DateTime.Now.Hour;
			}
			return _MCt0M1Mie6CJZK5aaLFRpJ6GX8p;
		}
		set
		{
			_MCt0M1Mie6CJZK5aaLFRpJ6GX8p = value % 24;
		}
	}

	public static int _c0ueby59jh0bkHw44BHBsNmmpbp
	{
		get
		{
			if (_3DInasj5B11bCcV5BIRvLE1Ay7w)
			{
				return DateTime.Now.Minute;
			}
			return _Z1SLWwHGdyLqUEpbiNgLmqo2zUh;
		}
		set
		{
			_Z1SLWwHGdyLqUEpbiNgLmqo2zUh = value % 60;
		}
	}

	public static TimeOfDay time
	{
		get
		{
			if (_K9Elfb3mqQp0B5Vj74ibvRwgdGu < 6)
			{
				return TimeOfDay.Night;
			}
			if (_K9Elfb3mqQp0B5Vj74ibvRwgdGu >= 10)
			{
				if (_K9Elfb3mqQp0B5Vj74ibvRwgdGu < 17)
				{
				}
				return TimeOfDay.Night;
			}
			return TimeOfDay.Morning;
		}
		set
		{
			switch (value)
			{
			default:
				_K9Elfb3mqQp0B5Vj74ibvRwgdGu = 0;
				break;
			case TimeOfDay.Morning:
				_K9Elfb3mqQp0B5Vj74ibvRwgdGu = 9;
				break;
			case TimeOfDay.Day:
				_K9Elfb3mqQp0B5Vj74ibvRwgdGu = 16;
				break;
			case TimeOfDay.Sunset:
				_K9Elfb3mqQp0B5Vj74ibvRwgdGu = 19;
				break;
			case TimeOfDay.Night:
				_K9Elfb3mqQp0B5Vj74ibvRwgdGu = 5;
				break;
			}
		}
	}

	public static void _LsIdcBLhaqZr03JCpCYZrI9ztVF()
	{
		_MCt0M1Mie6CJZK5aaLFRpJ6GX8p = DateTime.Now.Hour;
		_Z1SLWwHGdyLqUEpbiNgLmqo2zUh = DateTime.Now.Minute;
	}
}
