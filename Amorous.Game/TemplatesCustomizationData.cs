using System.Reflection;

public static class TemplatesCustomizationData
{ // _z8oOEvKr598r7HgA3VFwVCn2j0q
	public static void CloneCustomizationData(this PlayerData data, PlayerCustomizationData configuration)
	{
		data.ResetData();
		if (Censorship.Censored)
		{
			configuration.CockType = PlayerData.ECockType.None;
			configuration.BallsType = PlayerData.EBallsType.None;
			configuration.BreastsType = PlayerData.EBreastsType.None;
		}
		PropertyInfo[] properties = configuration.GetType().GetProperties();
		foreach (PropertyInfo info in properties)
		{
			if (!(info.Name == "Name"))
			{
				PropertyInfo property = data.GetType().GetProperty(info.Name);
				if (!(property == null))
				{
					object value = info.GetValue(configuration, null);
					property.SetValue(data, value, null);
				}
			}
		}
	}

	public static PlayerCustomizationData NewCustomizationData(this PlayerData data, string name)
	{
		PlayerCustomizationData configuration = new PlayerCustomizationData
		{
			Name = name
		};
		PropertyInfo[] properties = configuration.GetType().GetProperties();
		foreach (PropertyInfo info in properties)
		{
			if (!(info.Name == "Name"))
			{
				PropertyInfo property = data.GetType().GetProperty(info.Name);
				if (!(property == null))
				{
					object value = property.GetValue(data, null);
					info.SetValue(configuration, value, null);
				}
			}
		}
		return configuration;
	}
}
