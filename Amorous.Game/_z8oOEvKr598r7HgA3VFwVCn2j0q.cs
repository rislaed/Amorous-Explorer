using System;
using System.Reflection;

public static class _z8oOEvKr598r7HgA3VFwVCn2j0q
{
	public static void _IVxmfAaagekk8d3cdgAtQRhbUY9(this PlayerData _opIJo2jLUqdOL5yAFP4yzXce0DG_0, _xJL9E6vKdg1LYZtKQU5RQKikpvE _xJL9E6vKdg1LYZtKQU5RQKikpvE_0)
	{
		_opIJo2jLUqdOL5yAFP4yzXce0DG_0.ResetPlayer();
		if (_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
		{
			_xJL9E6vKdg1LYZtKQU5RQKikpvE_0.CockType = PlayerData.ECockType.None;
			_xJL9E6vKdg1LYZtKQU5RQKikpvE_0.BallsType = PlayerData.EBallsType.None;
			_xJL9E6vKdg1LYZtKQU5RQKikpvE_0.BreastsType = PlayerData.EBreastsType.None;
		}
		PropertyInfo[] properties = _xJL9E6vKdg1LYZtKQU5RQKikpvE_0.GetType().GetProperties();
		PropertyInfo[] array = properties;
		foreach (PropertyInfo propertyInfo in array)
		{
			if (!(propertyInfo.Name == "Name"))
			{
				PropertyInfo property = _opIJo2jLUqdOL5yAFP4yzXce0DG_0.GetType().GetProperty(propertyInfo.Name);
				if (!(property == null))
				{
					object value = propertyInfo.GetValue(_xJL9E6vKdg1LYZtKQU5RQKikpvE_0, null);
					property.SetValue(_opIJo2jLUqdOL5yAFP4yzXce0DG_0, value, null);
				}
			}
		}
	}

	public static _xJL9E6vKdg1LYZtKQU5RQKikpvE _3phsCUyg0G1wDNmHtsfmOUToBpF(this PlayerData _opIJo2jLUqdOL5yAFP4yzXce0DG_0, string string_0)
	{
		_xJL9E6vKdg1LYZtKQU5RQKikpvE xJL9E6vKdg1LYZtKQU5RQKikpvE = new _xJL9E6vKdg1LYZtKQU5RQKikpvE
		{
			Name = string_0
		};
		PropertyInfo[] properties = xJL9E6vKdg1LYZtKQU5RQKikpvE.GetType().GetProperties();
		PropertyInfo[] array = properties;
		foreach (PropertyInfo propertyInfo in array)
		{
			if (!(propertyInfo.Name == "Name"))
			{
				PropertyInfo property = _opIJo2jLUqdOL5yAFP4yzXce0DG_0.GetType().GetProperty(propertyInfo.Name);
				if (!(property == null))
				{
					object value = property.GetValue(_opIJo2jLUqdOL5yAFP4yzXce0DG_0, null);
					propertyInfo.SetValue(xJL9E6vKdg1LYZtKQU5RQKikpvE, value, null);
				}
			}
		}
		return xJL9E6vKdg1LYZtKQU5RQKikpvE;
	}
}
