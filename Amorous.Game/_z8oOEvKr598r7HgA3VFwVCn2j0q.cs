using System;
using System.Reflection;

public static class _z8oOEvKr598r7HgA3VFwVCn2j0q
{
	public static void _IVxmfAaagekk8d3cdgAtQRhbUY9(this _opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0, _xJL9E6vKdg1LYZtKQU5RQKikpvE _xJL9E6vKdg1LYZtKQU5RQKikpvE_0)
	{
		_opIJo2jLUqdOL5yAFP4yzXce0DG_0._XDbzWLxDi2VVrJQrjjLsgcfdxju();
		if (_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
		{
			_xJL9E6vKdg1LYZtKQU5RQKikpvE_0._rtyJgfViJdXL2Ela5APpDlk99dI = _opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType.None;
			_xJL9E6vKdg1LYZtKQU5RQKikpvE_0._7OCMpsMmozHsAG0GDljMMAlGLJBA = _opIJo2jLUqdOL5yAFP4yzXce0DG.EBallsType.None;
			_xJL9E6vKdg1LYZtKQU5RQKikpvE_0._BCncLn6BIYiBX6NdFByAquBYGpH = _opIJo2jLUqdOL5yAFP4yzXce0DG.EBreastsType.None;
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

	public static _xJL9E6vKdg1LYZtKQU5RQKikpvE _3phsCUyg0G1wDNmHtsfmOUToBpF(this _opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0, string string_0)
	{
		_xJL9E6vKdg1LYZtKQU5RQKikpvE xJL9E6vKdg1LYZtKQU5RQKikpvE = new _xJL9E6vKdg1LYZtKQU5RQKikpvE
		{
			_RB8fRXeQvK5vs7JEA0XfVCEpg1i = string_0
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
