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
				DateTime now = default(DateTime);
				while (true)
				{
					int num = -1817251980;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0xA7A2BD29u) % 4u)
						{
						case 1u:
							now = DateTime.Now;
							num = (int)((num2 * 1787422695) ^ 0xB57F4C4);
							continue;
						case 3u:
							break;
						case 2u:
							return now.Hour;
						default:
							goto end_IL_003d;
						}
						break;
					}
					continue;
					end_IL_003d:
					break;
				}
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
				DateTime now = default(DateTime);
				while (true)
				{
					int num = -458909762;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x9D66589Fu) % 4u)
						{
						case 1u:
							now = DateTime.Now;
							num = (int)(num2 * 1846019491) ^ -2129345858;
							continue;
						case 0u:
							break;
						case 2u:
							return now.Minute;
						default:
							goto end_IL_003d;
						}
						break;
					}
					continue;
					end_IL_003d:
					break;
				}
			}
			return _Z1SLWwHGdyLqUEpbiNgLmqo2zUh;
		}
		set
		{
			_Z1SLWwHGdyLqUEpbiNgLmqo2zUh = value % 60;
		}
	}

	public static _RRECH42isVc35MkZPyLEGkp0hjs _rf41M6fa6MhAPBvvUvQseEZTt9Q
	{
		get
		{
			if (_K9Elfb3mqQp0B5Vj74ibvRwgdGu < 6)
			{
				goto IL_001a;
			}
			goto IL_00a6;
			IL_00a6:
			int num;
			int num2;
			if (_K9Elfb3mqQp0B5Vj74ibvRwgdGu < 10)
			{
				num = -1663604106;
				num2 = -1663604106;
			}
			else
			{
				num = -928911961;
				num2 = -928911961;
			}
			goto IL_0063;
			IL_0063:
			while (true)
			{
				switch ((uint)(num ^ -1442995457) % 9u)
				{
				case 7u:
					break;
				case 2u:
					goto IL_0021;
				case 0u:
					goto IL_0043;
				case 3u:
					goto IL_00a6;
				case 1u:
					return _RRECH42isVc35MkZPyLEGkp0hjs.Day;
				case 4u:
					return _RRECH42isVc35MkZPyLEGkp0hjs.Sunset;
				default:
					return _RRECH42isVc35MkZPyLEGkp0hjs.Night;
				case 6u:
					return _RRECH42isVc35MkZPyLEGkp0hjs.Morning;
				case 8u:
					return _RRECH42isVc35MkZPyLEGkp0hjs.Night;
				}
				break;
				IL_0043:
				int num3;
				if (_K9Elfb3mqQp0B5Vj74ibvRwgdGu < 20)
				{
					num = -706338119;
					num3 = -706338119;
				}
				else
				{
					num = -436424953;
					num3 = -436424953;
				}
				continue;
				IL_0021:
				int num4;
				if (_K9Elfb3mqQp0B5Vj74ibvRwgdGu < 17)
				{
					num = -989340486;
					num4 = -989340486;
				}
				else
				{
					num = -1580148873;
					num4 = -1580148873;
				}
			}
			goto IL_001a;
			IL_001a:
			num = -1800980911;
			goto IL_0063;
		}
		set
		{
			int num;
			switch (value)
			{
			case _RRECH42isVc35MkZPyLEGkp0hjs.Morning:
				_K9Elfb3mqQp0B5Vj74ibvRwgdGu = 9;
				num = 1953687181;
				goto IL_0055;
			case _RRECH42isVc35MkZPyLEGkp0hjs.Day:
				goto IL_0042;
			default:
				goto IL_0050;
			case _RRECH42isVc35MkZPyLEGkp0hjs.Night:
				goto IL_0093;
			case _RRECH42isVc35MkZPyLEGkp0hjs.Sunset:
				break;
				IL_0055:
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5ACB412Fu) % 11u)
					{
					case 9u:
						num = (int)(num2 * 1098293100) ^ -1987333075;
						continue;
					case 8u:
						_K9Elfb3mqQp0B5Vj74ibvRwgdGu = 0;
						num = 1942741965;
						continue;
					case 5u:
						break;
					case 2u:
						goto IL_0042;
					case 0u:
						goto IL_0050;
					default:
						return;
					case 1u:
						goto IL_0093;
					case 3u:
						goto end_IL_0001;
					case 4u:
						return;
					case 6u:
						return;
					case 7u:
						return;
					case 10u:
						return;
					}
					break;
				}
				goto case _RRECH42isVc35MkZPyLEGkp0hjs.Morning;
				IL_0093:
				_K9Elfb3mqQp0B5Vj74ibvRwgdGu = 5;
				num = 698936625;
				goto IL_0055;
				IL_0050:
				num = 1651950189;
				goto IL_0055;
				IL_0042:
				_K9Elfb3mqQp0B5Vj74ibvRwgdGu = 16;
				num = 931463024;
				goto IL_0055;
				end_IL_0001:
				break;
			}
			_K9Elfb3mqQp0B5Vj74ibvRwgdGu = 19;
		}
	}

	public static void _LsIdcBLhaqZr03JCpCYZrI9ztVF()
	{
		DateTime now = DateTime.Now;
		while (true)
		{
			int num = -941938416;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8182E417u) % 3u)
				{
				case 2u:
					goto IL_0008;
				case 0u:
					break;
				default:
					_Z1SLWwHGdyLqUEpbiNgLmqo2zUh = DateTime.Now.Minute;
					return;
				}
				break;
				IL_0008:
				_MCt0M1Mie6CJZK5aaLFRpJ6GX8p = now.Hour;
				num = ((int)num2 * -796964476) ^ -1330740795;
			}
		}
	}
}
