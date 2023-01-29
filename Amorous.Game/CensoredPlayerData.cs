using System.Reflection;

public static class CensoredPlayerData
{ // _z8oOEvKr598r7HgA3VFwVCn2j0q
	public static void _IVxmfAaagekk8d3cdgAtQRhbUY9(this PlayerData data, PlayerCustomizationData configuration)
	{
		data.ResetPlayer();
		if (Censorship.Censored)
		{
			configuration.CockType = PlayerData.ECockType.None;
			configuration.BallsType = PlayerData.EBallsType.None;
			configuration.BreastsType = PlayerData.EBreastsType.None;
		}
		PropertyInfo[] properties = configuration.GetType().GetProperties();
		foreach (PropertyInfo propertyInfo in properties)
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

	public static PlayerCustomizationData _3phsCUyg0G1wDNmHtsfmOUToBpF(this PlayerData data, string name)
	{
		PlayerCustomizationData configuration = new PlayerCustomizationData
		{
			Name = name
		};
		PropertyInfo[] properties = configuration.GetType().GetProperties();
		foreach (PropertyInfo propertyInfo in properties)
		{
			if (!(propertyInfo.Name == "Name"))
			{
				PropertyInfo property = data.GetType().GetProperty(propertyInfo.Name);
				if (!(property == null))
				{
					object value = property.GetValue(data, null);
					propertyInfo.SetValue(configuration, value, null);
				}
			}
		}
		return configuration;
	}
}
