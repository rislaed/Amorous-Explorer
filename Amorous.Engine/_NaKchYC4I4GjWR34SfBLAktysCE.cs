using System.Collections.Generic;

public class _NaKchYC4I4GjWR34SfBLAktysCE : _N8bBL1xcL0zn0y2AJaH2UHKhLLz
{
	public string Name { get; private set; }

	public List<string> _CjFYKEH7Vq8U6urMqr8ixn5Z8li { get; private set; }

	public List<string> _l11eB5s4oGaWqILnwn3dX83PzrN { get; private set; }

	public List<_EZ0kOLXoEoEfWGQDdTbNqaPzDUh> Clothes { get; private set; }

	public _NaKchYC4I4GjWR34SfBLAktysCE(string string_0, params string[] string_1)
	{
		Name = string_0;
		_CjFYKEH7Vq8U6urMqr8ixn5Z8li = new List<string>(string_1);
		_l11eB5s4oGaWqILnwn3dX83PzrN = new List<string>();
		Clothes = new List<_EZ0kOLXoEoEfWGQDdTbNqaPzDUh>();
	}

	public _NaKchYC4I4GjWR34SfBLAktysCE _6NcgB9eEKq8eKu8SgNWnKbLsDhB(params string[] string_0)
	{
		_l11eB5s4oGaWqILnwn3dX83PzrN.AddRange(string_0);
		return this;
	}

	public IEnumerable<string> _YJmTJgv7TfeWJelscsKB1PI6D4m()
	{
		List<string> list = new List<string>();
		bool flag = false;
		bool flag2 = false;
		foreach (_EZ0kOLXoEoEfWGQDdTbNqaPzDUh item in Clothes)
		{
			if (item._3ZeCDXqcWHY4XJDBGyav3UzxYaHA)
			{
				list.AddRange(item._YJmTJgv7TfeWJelscsKB1PI6D4m());
				flag |= item._fxFbduTFL2OWpMcAqBEqYDlIrWG;
				flag2 |= item._k6wM5wdPLS8b9QWZ30CqiepJHCd;
			}
		}
		if (!flag)
		{
			list.AddRange(_CjFYKEH7Vq8U6urMqr8ixn5Z8li);
		}
		if (!flag2 && !_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
		{
			list.AddRange(_l11eB5s4oGaWqILnwn3dX83PzrN);
		}
		return list;
	}
}
