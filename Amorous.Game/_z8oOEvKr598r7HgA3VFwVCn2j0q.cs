using System;
using System.Reflection;

public static class _z8oOEvKr598r7HgA3VFwVCn2j0q
{
	public static void _IVxmfAaagekk8d3cdgAtQRhbUY9(this PlayerData data, PlayerConfiguration configuration)
	{
		data.ResetPlayer();
		if (Censorship.Censored)
		{
			configuration.CockType = PlayerData.ECockType.None;
			configuration.BallsType = PlayerData.EBallsType.None;
			configuration.BreastsType = PlayerData.EBreastsType.None;
		}
		PropertyInfo[] properties = configuration.GetType().GetProperties();
		PropertyInfo[] array = properties;
		foreach (PropertyInfo propertyInfo in array)
		{
			if (!(propertyInfo.Name == "Name"))
			{
				PropertyInfo property = data.GetType().GetProperty(propertyInfo.Name);
				if (!(property == null))
				{
					object value = propertyInfo.GetValue(configuration, null);
					property.SetValue(data, value, null);
				}
			}
		}
	}

	public static PlayerConfiguration _3phsCUyg0G1wDNmHtsfmOUToBpF(this PlayerData data, string name)
	{
		PlayerConfiguration xJL9E6vKdg1LYZtKQU5RQKikpvE = new PlayerConfiguration
		{
			Name = name
		};
		PropertyInfo[] properties = xJL9E6vKdg1LYZtKQU5RQKikpvE.GetType().GetProperties();
		PropertyInfo[] array = properties;
		foreach (PropertyInfo propertyInfo in array)
		{
			if (!(propertyInfo.Name == "Name"))
			{
				PropertyInfo property = data.GetType().GetProperty(propertyInfo.Name);
				if (!(property == null))
				{
					object value = property.GetValue(data, null);
					propertyInfo.SetValue(xJL9E6vKdg1LYZtKQU5RQKikpvE, value, null);
				}
			}
		}
		return xJL9E6vKdg1LYZtKQU5RQKikpvE;
	}
}
