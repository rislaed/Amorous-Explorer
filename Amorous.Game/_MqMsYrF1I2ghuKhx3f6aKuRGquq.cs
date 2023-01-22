using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Newtonsoft.Json;

public class _MqMsYrF1I2ghuKhx3f6aKuRGquq : _21uBmerICJi18moE2gpxlEipBgz
{
	[CompilerGenerated]
	private sealed class _lPOI9jDss5CUJ5jPy1zB8s0RmGp
	{
		public string _hzqOBkJhJBhsTRNARxHLctcvhN0;

		internal bool _9VPV46wHXHUdvb5LQz52lgAcxwt(_WmDwUqOXqj6xpaw8SzHUPXR0uwB _WmDwUqOXqj6xpaw8SzHUPXR0uwB_0)
		{
			return _WmDwUqOXqj6xpaw8SzHUPXR0uwB_0._RB8fRXeQvK5vs7JEA0XfVCEpg1i == _hzqOBkJhJBhsTRNARxHLctcvhN0;
		}

		static bool smethod_0(string string_0, string string_1)
		{
			return string_0 == string_1;
		}
	}

	public const int _X0FdDDJqVXe7X0FGiN6OsnaZtIF = 1040;

	public const int _qeKBLvATV3QS3jYy3CuAJCqqAtbA = 960;

	private const int _VTrOShnWP89ESyeqO1LPtrBoUIB = 350;

	private static readonly string _U8RMOUb18ulpoDDaA6ORCGlTl9P = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Saves");

	private static readonly string _yMVbZb1CBoa3bnnWLWCSnPFoK4o = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Saves/playertemplates.json");

	private readonly _oVHccpskJmMcOYan50N52Esmi8k _KyRTfqdr2zZtsEAgkvOlUoQoB5j;

	private readonly List<_xJL9E6vKdg1LYZtKQU5RQKikpvE> _HnbIDkSG3bmzUQyE7hhFdFKUaCcA = new List<_xJL9E6vKdg1LYZtKQU5RQKikpvE>();

	private List<_xJL9E6vKdg1LYZtKQU5RQKikpvE> _hFBs7DhxsNnkc55oFfnyfMJ6PKb = new List<_xJL9E6vKdg1LYZtKQU5RQKikpvE>();

	private bool _Q5TLQ5C9mZDQgJZ3DcYHNl0Pbgn;

	private float _i8C0PwO83NRzGvNoyMhHwLV9HeC;

	private int _nD28BmrDaEzCHelTAa14TKyuSyG;

	private int _LkckKdvuh9GaAwn7XojfbJBd91r;

	private int _cux27d2yUtT8iqgPFghmznXR0nC = 1000;

	private int _0nXh0yFCLkGPBWCZ8nbRLpWEQ6E;

	private float _iM7i7fLtaIJgLy3ciRpenDbf5CHb;

	private float _ZTkD3TiiqWMrAbMLsoeIOBirnQc;

	private int _wBWHhq9jY0K2NLTqM11LsE4yDM;

	private int _kpLvTY6XXVX762n2WA2bxMWl8eL;

	private readonly JsonSerializerSettings _ONuPEFW55mKuOlkBaBx5Jvmw3gO;

	private int _wO2k8QO0Jb1ECTFpHuFC2wQFtRB;

	private int _fqUhMheAq3WxPgLgXhgAKkZQOss { get; set; }

	public int _WJfGWBzn4wgdGBnMWRH2pcJ3AqH
	{
		get
		{
			return _cux27d2yUtT8iqgPFghmznXR0nC;
		}
		set
		{
			if (_0nXh0yFCLkGPBWCZ8nbRLpWEQ6E > 0 || _Q5TLQ5C9mZDQgJZ3DcYHNl0Pbgn)
			{
				return;
			}
			if (value <= 1040)
			{
				if (value < 960)
				{
					_cux27d2yUtT8iqgPFghmznXR0nC = 960;
				}
				else
				{
					_cux27d2yUtT8iqgPFghmznXR0nC = value;
				}
			}
			else
			{
				_cux27d2yUtT8iqgPFghmznXR0nC = 1040;
			}
			_i8C0PwO83NRzGvNoyMhHwLV9HeC = (float)_cux27d2yUtT8iqgPFghmznXR0nC / (float)_KyRTfqdr2zZtsEAgkvOlUoQoB5j._WJfGWBzn4wgdGBnMWRH2pcJ3AqH;
			_LkckKdvuh9GaAwn7XojfbJBd91r = 1080 - _cux27d2yUtT8iqgPFghmznXR0nC - 20;
			_kmVTSqclXrApKmHKAamak6kRUjl();
		}
	}

	public bool _vZ6v4a6UcXrp8I7fOK5GurTGvwg => _Q5TLQ5C9mZDQgJZ3DcYHNl0Pbgn;

	public IEnumerable<_xJL9E6vKdg1LYZtKQU5RQKikpvE> _A088aXIdbVflSYtbl7vA5RjQOjXA => _HnbIDkSG3bmzUQyE7hhFdFKUaCcA;

	public IEnumerable<_xJL9E6vKdg1LYZtKQU5RQKikpvE> _I6gsCHlb2BKFCJSAk9Cn5fCMAPu => _hFBs7DhxsNnkc55oFfnyfMJ6PKb;

	public _MqMsYrF1I2ghuKhx3f6aKuRGquq(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		JsonSerializerSettings val = new JsonSerializerSettings();
		val.set_TypeNameHandling((TypeNameHandling)4);
		val.get_Converters().Add((JsonConverter)(object)new _VSQz6uDf5A6KqE8xqKxxcrkhZkA());
		_ONuPEFW55mKuOlkBaBx5Jvmw3gO = val;
		base._002Ector(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0);
		string text = _K2047A8SCJdaw0LZKStEHOiH110._GxOfTBefEUfWKWaWgxVRKsjugxE(Path.Combine(base._ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.get_RootDirectory(), "Data/PlayerCustomization/Customization.json"));
		_KyRTfqdr2zZtsEAgkvOlUoQoB5j = JsonConvert.DeserializeObject<_oVHccpskJmMcOYan50N52Esmi8k>(text, _ONuPEFW55mKuOlkBaBx5Jvmw3gO);
		text = _K2047A8SCJdaw0LZKStEHOiH110._GxOfTBefEUfWKWaWgxVRKsjugxE(Path.Combine(base._ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.get_RootDirectory(), "Data/PlayerCustomization/DefaultTemplates.json"));
		_Q0ZahtTsyov6ogSphMEhTo0NJfz q0ZahtTsyov6ogSphMEhTo0NJfz = JsonConvert.DeserializeObject<_Q0ZahtTsyov6ogSphMEhTo0NJfz>(text, _ONuPEFW55mKuOlkBaBx5Jvmw3gO);
		_HnbIDkSG3bmzUQyE7hhFdFKUaCcA.AddRange(q0ZahtTsyov6ogSphMEhTo0NJfz._mwRhFH6kYLkktZ4wFHTyCBgCcBO);
		_NTp4LybfIeImwrI3gGcIHmtkkDF();
		_i8C0PwO83NRzGvNoyMhHwLV9HeC = (float)_cux27d2yUtT8iqgPFghmznXR0nC / (float)_KyRTfqdr2zZtsEAgkvOlUoQoB5j._WJfGWBzn4wgdGBnMWRH2pcJ3AqH;
		_nD28BmrDaEzCHelTAa14TKyuSyG = 400;
		_LkckKdvuh9GaAwn7XojfbJBd91r = 1080 - _cux27d2yUtT8iqgPFghmznXR0nC - 20;
	}

	public _MqMsYrF1I2ghuKhx3f6aKuRGquq(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, _oVHccpskJmMcOYan50N52Esmi8k _oVHccpskJmMcOYan50N52Esmi8k_0, IEnumerable<_xJL9E6vKdg1LYZtKQU5RQKikpvE> ienumerable_0)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		JsonSerializerSettings val = new JsonSerializerSettings();
		val.set_TypeNameHandling((TypeNameHandling)4);
		val.get_Converters().Add((JsonConverter)(object)new _VSQz6uDf5A6KqE8xqKxxcrkhZkA());
		_ONuPEFW55mKuOlkBaBx5Jvmw3gO = val;
		base._002Ector(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0);
		_KyRTfqdr2zZtsEAgkvOlUoQoB5j = _oVHccpskJmMcOYan50N52Esmi8k_0;
		_HnbIDkSG3bmzUQyE7hhFdFKUaCcA.AddRange(ienumerable_0);
		_i8C0PwO83NRzGvNoyMhHwLV9HeC = (float)_cux27d2yUtT8iqgPFghmznXR0nC / (float)_KyRTfqdr2zZtsEAgkvOlUoQoB5j._WJfGWBzn4wgdGBnMWRH2pcJ3AqH;
		_nD28BmrDaEzCHelTAa14TKyuSyG = 400;
		_LkckKdvuh9GaAwn7XojfbJBd91r = 1080 - _cux27d2yUtT8iqgPFghmznXR0nC - 20;
	}

	public _xJL9E6vKdg1LYZtKQU5RQKikpvE _aeTnyiKZSEemnK3AXL8to8blcUj(_xJL9E6vKdg1LYZtKQU5RQKikpvE _xJL9E6vKdg1LYZtKQU5RQKikpvE_0)
	{
		return JsonConvert.DeserializeObject<_xJL9E6vKdg1LYZtKQU5RQKikpvE>(JsonConvert.SerializeObject((object)_xJL9E6vKdg1LYZtKQU5RQKikpvE_0, _ONuPEFW55mKuOlkBaBx5Jvmw3gO), _ONuPEFW55mKuOlkBaBx5Jvmw3gO);
	}

	public void _0S3oMrwxDtOTcbzkglSllPfRq53(string string_0, _opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		_hFBs7DhxsNnkc55oFfnyfMJ6PKb.Add(_opIJo2jLUqdOL5yAFP4yzXce0DG_0._3phsCUyg0G1wDNmHtsfmOUToBpF(string_0));
		_bItGCINkXiJ4CUgGi63Dq7RfLz8();
	}

	public void _WfRAwdaNcmrDEhMe1AHPq7egPcw(string string_0, int int_0, _opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		if (int_0 >= 0 && int_0 < _hFBs7DhxsNnkc55oFfnyfMJ6PKb.Count)
		{
			_hFBs7DhxsNnkc55oFfnyfMJ6PKb[int_0] = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._3phsCUyg0G1wDNmHtsfmOUToBpF(string_0);
			_bItGCINkXiJ4CUgGi63Dq7RfLz8();
		}
	}

	public void _JC60lfB4LT6VifObN1Ynm6iARlc(int int_0)
	{
		if (int_0 >= 0 && int_0 < _hFBs7DhxsNnkc55oFfnyfMJ6PKb.Count)
		{
			_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t()._IVxmfAaagekk8d3cdgAtQRhbUY9(_hFBs7DhxsNnkc55oFfnyfMJ6PKb[int_0]);
			_0cFb48aKbcbREkHm9Jwptl6r6Vi();
		}
	}

	public void _FzyCgzYhOXEADaijk8VbcLulpcBA(int int_0)
	{
		if (int_0 >= 0 && int_0 < _hFBs7DhxsNnkc55oFfnyfMJ6PKb.Count)
		{
			_hFBs7DhxsNnkc55oFfnyfMJ6PKb.RemoveAt(int_0);
			_bItGCINkXiJ4CUgGi63Dq7RfLz8();
		}
	}

	public void _BwV21jdCpo4YpIp6x74bJ0H7hut(int int_0)
	{
		if (int_0 >= 0 && int_0 < _HnbIDkSG3bmzUQyE7hhFdFKUaCcA.Count)
		{
			_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t()._IVxmfAaagekk8d3cdgAtQRhbUY9(_HnbIDkSG3bmzUQyE7hhFdFKUaCcA[int_0]);
			_0cFb48aKbcbREkHm9Jwptl6r6Vi();
		}
	}

	public void _BCRMBb9uhQZrQlfdXPidu27yb8C(int int_0)
	{
		if (int_0 >= 0 && int_0 < _hFBs7DhxsNnkc55oFfnyfMJ6PKb.Count)
		{
			_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t()._IVxmfAaagekk8d3cdgAtQRhbUY9(_hFBs7DhxsNnkc55oFfnyfMJ6PKb[int_0]);
			_0cFb48aKbcbREkHm9Jwptl6r6Vi();
		}
	}

	public string _6qwooGF3jWmbG9887Y5IKZ8fJ0E(int int_0)
	{
		if (int_0 >= 0 && int_0 < _hFBs7DhxsNnkc55oFfnyfMJ6PKb.Count)
		{
			return _hFBs7DhxsNnkc55oFfnyfMJ6PKb[int_0]._RB8fRXeQvK5vs7JEA0XfVCEpg1i;
		}
		return string.Empty;
	}

	private void _bItGCINkXiJ4CUgGi63Dq7RfLz8()
	{
		if (!Directory.Exists(_U8RMOUb18ulpoDDaA6ORCGlTl9P))
		{
			Directory.CreateDirectory(_U8RMOUb18ulpoDDaA6ORCGlTl9P);
		}
		File.WriteAllText(_yMVbZb1CBoa3bnnWLWCSnPFoK4o, JsonConvert.SerializeObject((object)_hFBs7DhxsNnkc55oFfnyfMJ6PKb, _ONuPEFW55mKuOlkBaBx5Jvmw3gO));
	}

	private void _NTp4LybfIeImwrI3gGcIHmtkkDF()
	{
		if (File.Exists(_yMVbZb1CBoa3bnnWLWCSnPFoK4o))
		{
			List<_xJL9E6vKdg1LYZtKQU5RQKikpvE> list = JsonConvert.DeserializeObject<List<_xJL9E6vKdg1LYZtKQU5RQKikpvE>>(File.ReadAllText(_yMVbZb1CBoa3bnnWLWCSnPFoK4o), _ONuPEFW55mKuOlkBaBx5Jvmw3gO);
			if (list != null)
			{
				_hFBs7DhxsNnkc55oFfnyfMJ6PKb = list;
			}
		}
	}

	public void _0cFb48aKbcbREkHm9Jwptl6r6Vi()
	{
		foreach (_WmDwUqOXqj6xpaw8SzHUPXR0uwB item in _KyRTfqdr2zZtsEAgkvOlUoQoB5j._ZWquBFoc0aD37PZyAGrp8WqVxBC)
		{
			foreach (_Qzndj0TwqO8yTQMbRwL4FFwlTbv item2 in item._lstlI8qzZ4KErYKnufdOlj1xVZF)
			{
				if (item2._dPmC8tBC0iph2YBAFmztEsmwUdSA != null)
				{
					item2._dPmC8tBC0iph2YBAFmztEsmwUdSA._Fxy2SlgceW90FloFw6a1AEJODYA = false;
				}
			}
		}
		_oD87G7SXjsTukw7IVWxVlVFEgvA(_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t());
		foreach (_WmDwUqOXqj6xpaw8SzHUPXR0uwB item3 in _KyRTfqdr2zZtsEAgkvOlUoQoB5j._ZWquBFoc0aD37PZyAGrp8WqVxBC)
		{
			foreach (_Qzndj0TwqO8yTQMbRwL4FFwlTbv item4 in item3._lstlI8qzZ4KErYKnufdOlj1xVZF)
			{
				if (item4._dPmC8tBC0iph2YBAFmztEsmwUdSA != null && !item4._dPmC8tBC0iph2YBAFmztEsmwUdSA._Fxy2SlgceW90FloFw6a1AEJODYA)
				{
					item4._dPmC8tBC0iph2YBAFmztEsmwUdSA._ymyneWF6dfrtfUI08wyb3KExq0D();
					base._lstlI8qzZ4KErYKnufdOlj1xVZF.Remove(item4._dPmC8tBC0iph2YBAFmztEsmwUdSA);
					item4._dPmC8tBC0iph2YBAFmztEsmwUdSA = null;
				}
			}
		}
	}

	private void _aXgmKv0acZSej4DXtFZ3EwykcX4(_WmDwUqOXqj6xpaw8SzHUPXR0uwB _WmDwUqOXqj6xpaw8SzHUPXR0uwB_0, _Qzndj0TwqO8yTQMbRwL4FFwlTbv _Qzndj0TwqO8yTQMbRwL4FFwlTbv_0)
	{
		_Qzndj0TwqO8yTQMbRwL4FFwlTbv_0._dPmC8tBC0iph2YBAFmztEsmwUdSA = _Iz47swAAB7d2iX6PQ1xTIJIv8MJ(_Qzndj0TwqO8yTQMbRwL4FFwlTbv_0._jhBAT894A3bGMn1rWLUbcueBbZdA, $"Assets/PlayerCustomization/{_WmDwUqOXqj6xpaw8SzHUPXR0uwB_0._RB8fRXeQvK5vs7JEA0XfVCEpg1i}/{_Qzndj0TwqO8yTQMbRwL4FFwlTbv_0._jhBAT894A3bGMn1rWLUbcueBbZdA}", _Qzndj0TwqO8yTQMbRwL4FFwlTbv_0._7Xn1C5tjYnmIif1iZKV8AWsEEbL + _nD28BmrDaEzCHelTAa14TKyuSyG, _Qzndj0TwqO8yTQMbRwL4FFwlTbv_0._bCjZ3VSXGKyhmykd2zCnQBiSpDf + _LkckKdvuh9GaAwn7XojfbJBd91r, _Qzndj0TwqO8yTQMbRwL4FFwlTbv_0._FXzOOJAq9or1Z9tuVa5CAUUsLxe, _i8C0PwO83NRzGvNoyMhHwLV9HeC);
		_Qzndj0TwqO8yTQMbRwL4FFwlTbv_0._dPmC8tBC0iph2YBAFmztEsmwUdSA._Fxy2SlgceW90FloFw6a1AEJODYA = false;
	}

	private void _MvwR0kE4wvi2cZX9CN5Dfu3jPWG(string string_0, string string_1, Color color_0)
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		_WmDwUqOXqj6xpaw8SzHUPXR0uwB wmDwUqOXqj6xpaw8SzHUPXR0uwB = _KyRTfqdr2zZtsEAgkvOlUoQoB5j._ZWquBFoc0aD37PZyAGrp8WqVxBC.FirstOrDefault((_WmDwUqOXqj6xpaw8SzHUPXR0uwB _WmDwUqOXqj6xpaw8SzHUPXR0uwB_0) => _WmDwUqOXqj6xpaw8SzHUPXR0uwB_0._RB8fRXeQvK5vs7JEA0XfVCEpg1i == string_0);
		if (wmDwUqOXqj6xpaw8SzHUPXR0uwB == null)
		{
			return;
		}
		foreach (_Qzndj0TwqO8yTQMbRwL4FFwlTbv item in wmDwUqOXqj6xpaw8SzHUPXR0uwB._lstlI8qzZ4KErYKnufdOlj1xVZF)
		{
			if (item._Ig69b1o9628MyPRXaYUwjVa31Xf.Contains(string_1))
			{
				if (item._dPmC8tBC0iph2YBAFmztEsmwUdSA == null)
				{
					_aXgmKv0acZSej4DXtFZ3EwykcX4(wmDwUqOXqj6xpaw8SzHUPXR0uwB, item);
				}
				item._dPmC8tBC0iph2YBAFmztEsmwUdSA._Fxy2SlgceW90FloFw6a1AEJODYA = true;
				item._dPmC8tBC0iph2YBAFmztEsmwUdSA._9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = color_0;
				item._dPmC8tBC0iph2YBAFmztEsmwUdSA._VNgmwYSLsJyyiR6cPQ35UHJBR4d = _wO2k8QO0Jb1ECTFpHuFC2wQFtRB++;
			}
		}
	}

	public override void _oD87G7SXjsTukw7IVWxVlVFEgvA(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Unknown result type (might be due to invalid IL or missing references)
		//IL_064a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0692: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0728: Unknown result type (might be due to invalid IL or missing references)
		//IL_0758: Unknown result type (might be due to invalid IL or missing references)
		//IL_077e: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_080c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0843: Unknown result type (might be due to invalid IL or missing references)
		//IL_0873: Unknown result type (might be due to invalid IL or missing references)
		//IL_0889: Unknown result type (might be due to invalid IL or missing references)
		//IL_089e: Unknown result type (might be due to invalid IL or missing references)
		_wO2k8QO0Jb1ECTFpHuFC2wQFtRB = 0;
		_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("BodyTypes", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._8CtoV1bqn0CwCzb1tuoNppBt0Gg.ToString(), _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G);
		if (_opIJo2jLUqdOL5yAFP4yzXce0DG_0._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Underbelly))
		{
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Markings", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._8CtoV1bqn0CwCzb1tuoNppBt0Gg.ToString() + "Underbelly", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._PeK36AvFxEQCvX3fS62hNV7rpuJ);
		}
		if (_opIJo2jLUqdOL5yAFP4yzXce0DG_0._UjtZovBCLAtBZnUfbTvRFsaf5mx != _opIJo2jLUqdOL5yAFP4yzXce0DG.EHeadType.PaperBag)
		{
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Heads", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._UjtZovBCLAtBZnUfbTvRFsaf5mx.ToString(), _opIJo2jLUqdOL5yAFP4yzXce0DG_0._1qfGl3Oc2JyQEpnQtdOxMeMkqhi);
			if (_opIJo2jLUqdOL5yAFP4yzXce0DG_0._SnnHu3P4lDDxgkL6cuUt7y07yxG.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._iDe3W6qb7jKTPuJV79yf2i7UoIq.Gaunt))
			{
				_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Heads", "Gaunt", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Fn7Kt1UvxcXOmJ1gIeWdJnRbaQt);
			}
			if (_opIJo2jLUqdOL5yAFP4yzXce0DG_0._SnnHu3P4lDDxgkL6cuUt7y07yxG.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._iDe3W6qb7jKTPuJV79yf2i7UoIq.Scruffy))
			{
				_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Heads", "Scruffy", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._WvoLJ4MA4gYEsgOmmIQvfK3xFlu);
			}
			if (_opIJo2jLUqdOL5yAFP4yzXce0DG_0._SnnHu3P4lDDxgkL6cuUt7y07yxG.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._iDe3W6qb7jKTPuJV79yf2i7UoIq.Snout))
			{
				_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Heads", "Snout", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._lUyqwDvFCoXEZ6VM9PVCQ970jps);
			}
			if (_opIJo2jLUqdOL5yAFP4yzXce0DG_0._SnnHu3P4lDDxgkL6cuUt7y07yxG.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._iDe3W6qb7jKTPuJV79yf2i7UoIq.Stripes))
			{
				_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Heads", "Stripes", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._qKGefHxdjIUD6ObjxrxnLwbBEsh);
			}
		}
		else
		{
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Heads", "Humanoid", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._1qfGl3Oc2JyQEpnQtdOxMeMkqhi);
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Heads", "PaperBag", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._VWdlqWB4z2wNtm197Oiv32QGVbE);
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Heads", "PaperBagEyes", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._sbSAaAmkhONcFX6f0JtHbVQbEfG);
		}
		_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Eyes", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._c0ThYURHAGN0Wzlzw9Ibh3Z8qyo.ToString() + "Back", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._GXnDb1oaJlPbAQV2mjAwCQFK0nmb);
		_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Eyes", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._c0ThYURHAGN0Wzlzw9Ibh3Z8qyo.ToString() + "Front", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._0K4lcN7iwo5q0iP1YlkpY9GdayR);
		_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Eyebrows", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._KBOJ0qhM8C5evPQxibgX74m2WHg.ToString(), _opIJo2jLUqdOL5yAFP4yzXce0DG_0._HRPv5rzDY5zNiP4NADDEGhrzGTe);
		_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("HeadAccessories", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._pmr0FnBBvgaggpusBKMWplUa63c.ToString() + "Horn", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._9b2asKZDwVM1TcSfmfeFCuk0TJZb);
		_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("HeadAccessories", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._pmr0FnBBvgaggpusBKMWplUa63c.ToString() + "Ear", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._vUhBAXEgvpGKopOUkDJFoc4EYQ3);
		_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("HeadAccessories", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._pmr0FnBBvgaggpusBKMWplUa63c.ToString() + "EarInner", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._uaBF7rEib15d42vH8AzoXWFMMkE);
		if (_opIJo2jLUqdOL5yAFP4yzXce0DG_0._4QUr9lDqmNxEuy7B4xgb7Lj1HU0 != _opIJo2jLUqdOL5yAFP4yzXce0DG.EMuzzleType.Human)
		{
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Muzzles", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._4QUr9lDqmNxEuy7B4xgb7Lj1HU0.ToString(), _opIJo2jLUqdOL5yAFP4yzXce0DG_0._VsEYbNSam3IFYYWY4QC2lb4ia61);
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Muzzles", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._4QUr9lDqmNxEuy7B4xgb7Lj1HU0.ToString() + "Nose", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._y1SiMmRVXWDhDtY17knDpitt46F);
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Muzzles", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._4QUr9lDqmNxEuy7B4xgb7Lj1HU0.ToString() + "Teeth", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._T98drEOtEEZKeB5tXzsuPrhb5Xk);
		}
		else
		{
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Muzzles", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._4QUr9lDqmNxEuy7B4xgb7Lj1HU0.ToString(), _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G);
		}
		if (_opIJo2jLUqdOL5yAFP4yzXce0DG_0._hkFDGB5pWIuOVcIyDAFqHrDdSpjA)
		{
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Muzzles", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._4QUr9lDqmNxEuy7B4xgb7Lj1HU0.ToString() + "Horn", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._q2iDxJYfqribHB1bD8aSkSjqrfnA);
		}
		if (_opIJo2jLUqdOL5yAFP4yzXce0DG_0._UAZhvJ3a9BGOBM0CLiDkKLwUFC9)
		{
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Muzzles", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._4QUr9lDqmNxEuy7B4xgb7Lj1HU0.ToString() + "Mask", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._phJrpk3rql5MfNJxPQ9X7nC8aAk);
		}
		_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Hairstyles", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._03h2I0mTkGTzIA5R48rgwJh7JZA.ToString(), _opIJo2jLUqdOL5yAFP4yzXce0DG_0._bJmvnPs69aVDXxG48lmruYZFHKt);
		_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Hairstyles", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._fzMbZCCd7imnrcrYWkSj5u8UZ2J.ToString() + "Fringe", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._EvdUMrkAAdTeMv6fOpGrOLCAMq8A);
		_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Tails", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._NrFEKLWh80bQXi9PujCBTqm01AA.ToString(), _opIJo2jLUqdOL5yAFP4yzXce0DG_0._qsK1J3jktKH3eJ2i8sL1oaxXtLc);
		if (_opIJo2jLUqdOL5yAFP4yzXce0DG_0._PVQfhwHODkR6bzHmfeCK4L8riIG)
		{
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Tails", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._NrFEKLWh80bQXi9PujCBTqm01AA.ToString() + "Part1", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._62dl1HYYkor3TZL58k5Y33Tj83);
		}
		if (_opIJo2jLUqdOL5yAFP4yzXce0DG_0._tEXwTuSRSq5JaaFE4W8edEHxS9q)
		{
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Tails", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._NrFEKLWh80bQXi9PujCBTqm01AA.ToString() + "Part2", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._LufmRsAZrlyDgRKYocQXPzANMaF);
		}
		_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Feet", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._LZ8c6hRMRYKjnlLOPhbZHcWqUGG.ToString(), _opIJo2jLUqdOL5yAFP4yzXce0DG_0._LZfuQybASevOsCykEWqdvA5GqUF);
		if (_opIJo2jLUqdOL5yAFP4yzXce0DG_0._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Underthigh))
		{
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Markings", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._8CtoV1bqn0CwCzb1tuoNppBt0Gg.ToString() + "Underthigh", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._zBv1cYqPRU7uDCALpBlBSgObUcbA);
		}
		if (_opIJo2jLUqdOL5yAFP4yzXce0DG_0._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Stripes))
		{
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Markings", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._8CtoV1bqn0CwCzb1tuoNppBt0Gg.ToString() + "Stripes", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ);
		}
		if (_opIJo2jLUqdOL5yAFP4yzXce0DG_0._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.LongForearm))
		{
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Markings", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._8CtoV1bqn0CwCzb1tuoNppBt0Gg.ToString() + "LongForearm", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._1ZKGQXLRAHEJR8v7jhlDsyOVLcz);
		}
		if (_opIJo2jLUqdOL5yAFP4yzXce0DG_0._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.ShortForearm))
		{
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Markings", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._8CtoV1bqn0CwCzb1tuoNppBt0Gg.ToString() + "ShortForearm", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._8rDSn6e9Ip9WdOogjhIn8YlL1oM);
		}
		if (_opIJo2jLUqdOL5yAFP4yzXce0DG_0._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.AvianForearm))
		{
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Markings", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._8CtoV1bqn0CwCzb1tuoNppBt0Gg.ToString() + "AvianForearm", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._FrsyMDX7TebzFk8nSLTyRDPi1QH);
		}
		if (_opIJo2jLUqdOL5yAFP4yzXce0DG_0._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.LongShin))
		{
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Markings", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._8CtoV1bqn0CwCzb1tuoNppBt0Gg.ToString() + "LongShin", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._cUtgkG5qDvgFmI8c29I9xsLVNON);
		}
		if (_opIJo2jLUqdOL5yAFP4yzXce0DG_0._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.ShortShin))
		{
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Markings", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._8CtoV1bqn0CwCzb1tuoNppBt0Gg.ToString() + "ShortShin", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._LcOPiDaC2j5vzxOEYhvW4vRoaRX);
		}
		if (_opIJo2jLUqdOL5yAFP4yzXce0DG_0._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.AvianShin))
		{
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Markings", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._8CtoV1bqn0CwCzb1tuoNppBt0Gg.ToString() + "AvianShin", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._meyNS02iTIxo212B6c5eoKns2wj);
		}
		if (!_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
		{
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Balls", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._7OCMpsMmozHsAG0GDljMMAlGLJBA.ToString(), _opIJo2jLUqdOL5yAFP4yzXce0DG_0._8qQ7XVlyRYW4icBFxPQCJqgueYD);
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("MaleGenitalia", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._rtyJgfViJdXL2Ela5APpDlk99dI.ToString(), _opIJo2jLUqdOL5yAFP4yzXce0DG_0._XnNREK59QnV1onFFWfSUaS9WK0E);
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("MaleGenitalia", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._rtyJgfViJdXL2Ela5APpDlk99dI.ToString() + "Flesh", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._o6OnmHi5rZIQPHESokp9rTaO1ei);
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Breasts", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._BCncLn6BIYiBX6NdFByAquBYGpH.ToString(), _opIJo2jLUqdOL5yAFP4yzXce0DG_0._pigzqi6DgcSToQkL9g7Ns2QrLfp);
			if (_opIJo2jLUqdOL5yAFP4yzXce0DG_0._Q2AbpMWcrhtCW9MLTtT5gwoleu7)
			{
				_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Breasts", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._BCncLn6BIYiBX6NdFByAquBYGpH.ToString() + "Nipples", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._2yydfEIrSiLPTti2dT8JXGoIaM3);
			}
		}
		if (_opIJo2jLUqdOL5yAFP4yzXce0DG_0._VmNLhqrIwSnE6JnCYiBcxnSqnEV)
		{
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Nails", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._8CtoV1bqn0CwCzb1tuoNppBt0Gg.ToString() + "Nail", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._in5HHYmrdLTFpkgc8aimJpXqAXB);
			_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Nails", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._LZ8c6hRMRYKjnlLOPhbZHcWqUGG.ToString() + "Nails", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._in5HHYmrdLTFpkgc8aimJpXqAXB);
		}
		_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Phone", "Case", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._uOkbmfW26QVAvyEMQakki9kTMDbA);
		_MvwR0kE4wvi2cZX9CN5Dfu3jPWG("Phone", "Screen", Color.get_White());
	}

	public void _h7FmRKqsiolCVDHSPyo8tOOxJjI()
	{
		if (!_Q5TLQ5C9mZDQgJZ3DcYHNl0Pbgn)
		{
			_Q5TLQ5C9mZDQgJZ3DcYHNl0Pbgn = true;
			_0nXh0yFCLkGPBWCZ8nbRLpWEQ6E = 350 - _0nXh0yFCLkGPBWCZ8nbRLpWEQ6E;
			_iM7i7fLtaIJgLy3ciRpenDbf5CHb = _i8C0PwO83NRzGvNoyMhHwLV9HeC;
			_wBWHhq9jY0K2NLTqM11LsE4yDM = _LkckKdvuh9GaAwn7XojfbJBd91r;
			_ZTkD3TiiqWMrAbMLsoeIOBirnQc = 1f;
			_kpLvTY6XXVX762n2WA2bxMWl8eL = 0;
		}
	}

	public void _4yLGwEKDfxbcWN8YsEUfRhL5JK5()
	{
		if (_Q5TLQ5C9mZDQgJZ3DcYHNl0Pbgn)
		{
			_Q5TLQ5C9mZDQgJZ3DcYHNl0Pbgn = false;
			_0nXh0yFCLkGPBWCZ8nbRLpWEQ6E = 350 - _0nXh0yFCLkGPBWCZ8nbRLpWEQ6E;
			_iM7i7fLtaIJgLy3ciRpenDbf5CHb = _i8C0PwO83NRzGvNoyMhHwLV9HeC;
			_wBWHhq9jY0K2NLTqM11LsE4yDM = _LkckKdvuh9GaAwn7XojfbJBd91r;
			_ZTkD3TiiqWMrAbMLsoeIOBirnQc = (float)_cux27d2yUtT8iqgPFghmznXR0nC / (float)_KyRTfqdr2zZtsEAgkvOlUoQoB5j._WJfGWBzn4wgdGBnMWRH2pcJ3AqH;
			_kpLvTY6XXVX762n2WA2bxMWl8eL = 1080 - _cux27d2yUtT8iqgPFghmznXR0nC - 20;
		}
	}

	public void _BlScjiyHDsZk3jkAZbAbjUxn87sA()
	{
		if (_Q5TLQ5C9mZDQgJZ3DcYHNl0Pbgn)
		{
			_4yLGwEKDfxbcWN8YsEUfRhL5JK5();
		}
		else
		{
			_h7FmRKqsiolCVDHSPyo8tOOxJjI();
		}
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		int y = base._ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._U7CeYBJ1v1SoUxpX8emsQ9mWl5b.Y;
		if (_0nXh0yFCLkGPBWCZ8nbRLpWEQ6E <= 0)
		{
			if (_vZ6v4a6UcXrp8I7fOK5GurTGvwg && base._ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._WZ4xYI5Q3hoCNX9QFzE3jfDwZBJ(_PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton))
			{
				int num = y - _fqUhMheAq3WxPgLgXhgAKkZQOss;
				if (num != 0)
				{
					_LkckKdvuh9GaAwn7XojfbJBd91r = Math.Min(Math.Max(-1600, _LkckKdvuh9GaAwn7XojfbJBd91r + num), 0);
					_kmVTSqclXrApKmHKAamak6kRUjl();
				}
			}
			_fqUhMheAq3WxPgLgXhgAKkZQOss = y;
			return;
		}
		_0nXh0yFCLkGPBWCZ8nbRLpWEQ6E -= gameTime_0.get_ElapsedGameTime().Milliseconds;
		if (_0nXh0yFCLkGPBWCZ8nbRLpWEQ6E <= 0)
		{
			_0nXh0yFCLkGPBWCZ8nbRLpWEQ6E = 0;
			_i8C0PwO83NRzGvNoyMhHwLV9HeC = _ZTkD3TiiqWMrAbMLsoeIOBirnQc;
			_LkckKdvuh9GaAwn7XojfbJBd91r = _kpLvTY6XXVX762n2WA2bxMWl8eL;
		}
		else
		{
			float num2 = (float)_0nXh0yFCLkGPBWCZ8nbRLpWEQ6E / 350f;
			_i8C0PwO83NRzGvNoyMhHwLV9HeC = MathHelper.Lerp(_ZTkD3TiiqWMrAbMLsoeIOBirnQc, _iM7i7fLtaIJgLy3ciRpenDbf5CHb, num2);
			_LkckKdvuh9GaAwn7XojfbJBd91r = (int)MathHelper.Lerp((float)_kpLvTY6XXVX762n2WA2bxMWl8eL, (float)_wBWHhq9jY0K2NLTqM11LsE4yDM, num2);
		}
		_kmVTSqclXrApKmHKAamak6kRUjl();
		_fqUhMheAq3WxPgLgXhgAKkZQOss = y;
	}

	private void _kmVTSqclXrApKmHKAamak6kRUjl()
	{
		using List<_ujAkjlfN5TywwbLAUDzPvtab6uJ>.Enumerator enumerator = base._lstlI8qzZ4KErYKnufdOlj1xVZF.GetEnumerator();
		if (enumerator.MoveNext())
		{
			_ujAkjlfN5TywwbLAUDzPvtab6uJ current = enumerator.Current;
			current._fO7gSlrDDNMoHR4FO5QXAq8fUyA = _i8C0PwO83NRzGvNoyMhHwLV9HeC;
			current._bCjZ3VSXGKyhmykd2zCnQBiSpDf = _LkckKdvuh9GaAwn7XojfbJBd91r;
		}
	}

	static JsonSerializerSettings smethod_2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new JsonSerializerSettings();
	}

	static void smethod_3(JsonSerializerSettings jsonSerializerSettings_0, TypeNameHandling typeNameHandling_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		jsonSerializerSettings_0.set_TypeNameHandling(typeNameHandling_0);
	}

	static IList<JsonConverter> smethod_4(JsonSerializerSettings jsonSerializerSettings_0)
	{
		return jsonSerializerSettings_0.get_Converters();
	}

	static _VSQz6uDf5A6KqE8xqKxxcrkhZkA smethod_5()
	{
		return new _VSQz6uDf5A6KqE8xqKxxcrkhZkA();
	}

	static ContentManager smethod_6(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8;
	}

	static string smethod_7(ContentManager contentManager_0)
	{
		return contentManager_0.get_RootDirectory();
	}

	static string smethod_8(string string_0, string string_1)
	{
		return Path.Combine(string_0, string_1);
	}

	static string smethod_9(string string_0)
	{
		return _K2047A8SCJdaw0LZKStEHOiH110._GxOfTBefEUfWKWaWgxVRKsjugxE(string_0);
	}

	static string smethod_10(object object_0, JsonSerializerSettings jsonSerializerSettings_0)
	{
		return JsonConvert.SerializeObject(object_0, jsonSerializerSettings_0);
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG smethod_11()
	{
		return _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
	}

	static bool smethod_12(string string_0)
	{
		return Directory.Exists(string_0);
	}

	static DirectoryInfo smethod_13(string string_0)
	{
		return Directory.CreateDirectory(string_0);
	}

	static void smethod_14(string string_0, string string_1)
	{
		File.WriteAllText(string_0, string_1);
	}

	static bool smethod_15(string string_0)
	{
		return File.Exists(string_0);
	}

	static string smethod_16(string string_0)
	{
		return File.ReadAllText(string_0);
	}

	static void smethod_17(_ujAkjlfN5TywwbLAUDzPvtab6uJ _ujAkjlfN5TywwbLAUDzPvtab6uJ_0, bool bool_0)
	{
		_ujAkjlfN5TywwbLAUDzPvtab6uJ_0._Fxy2SlgceW90FloFw6a1AEJODYA = bool_0;
	}

	static void smethod_18(_21uBmerICJi18moE2gpxlEipBgz _21uBmerICJi18moE2gpxlEipBgz_0, _opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		_21uBmerICJi18moE2gpxlEipBgz_0._oD87G7SXjsTukw7IVWxVlVFEgvA(_opIJo2jLUqdOL5yAFP4yzXce0DG_0);
	}

	static bool smethod_19(_ujAkjlfN5TywwbLAUDzPvtab6uJ _ujAkjlfN5TywwbLAUDzPvtab6uJ_0)
	{
		return _ujAkjlfN5TywwbLAUDzPvtab6uJ_0._Fxy2SlgceW90FloFw6a1AEJODYA;
	}

	static void smethod_20(_ujAkjlfN5TywwbLAUDzPvtab6uJ _ujAkjlfN5TywwbLAUDzPvtab6uJ_0)
	{
		_ujAkjlfN5TywwbLAUDzPvtab6uJ_0._ymyneWF6dfrtfUI08wyb3KExq0D();
	}

	static List<_ujAkjlfN5TywwbLAUDzPvtab6uJ> smethod_21(_21uBmerICJi18moE2gpxlEipBgz _21uBmerICJi18moE2gpxlEipBgz_0)
	{
		return _21uBmerICJi18moE2gpxlEipBgz_0._lstlI8qzZ4KErYKnufdOlj1xVZF;
	}

	static string smethod_22(string string_0, object object_0, object object_1)
	{
		return string.Format(string_0, object_0, object_1);
	}

	static _uqydQVaCmCvK7zzWs5W4gZFpKBu smethod_23(_21uBmerICJi18moE2gpxlEipBgz _21uBmerICJi18moE2gpxlEipBgz_0, string string_0, string string_1, int int_0, int int_1, int int_2, float float_0)
	{
		return _21uBmerICJi18moE2gpxlEipBgz_0._Iz47swAAB7d2iX6PQ1xTIJIv8MJ(string_0, string_1, int_0, int_1, int_2, float_0);
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG.EBodyType smethod_24(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._8CtoV1bqn0CwCzb1tuoNppBt0Gg;
	}

	static Color smethod_25(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G;
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U smethod_26(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Mz7LwHZqoGBscApFXmff1kEQnGY;
	}

	static bool smethod_27(Enum enum_0, Enum enum_1)
	{
		return enum_0.HasFlag(enum_1);
	}

	static string smethod_28(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static Color smethod_29(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._PeK36AvFxEQCvX3fS62hNV7rpuJ;
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG.EHeadType smethod_30(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._UjtZovBCLAtBZnUfbTvRFsaf5mx;
	}

	static Color smethod_31(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._1qfGl3Oc2JyQEpnQtdOxMeMkqhi;
	}

	static Color smethod_32(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._VWdlqWB4z2wNtm197Oiv32QGVbE;
	}

	static Color smethod_33(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._sbSAaAmkhONcFX6f0JtHbVQbEfG;
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG._iDe3W6qb7jKTPuJV79yf2i7UoIq smethod_34(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._SnnHu3P4lDDxgkL6cuUt7y07yxG;
	}

	static Color smethod_35(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Fn7Kt1UvxcXOmJ1gIeWdJnRbaQt;
	}

	static Color smethod_36(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._WvoLJ4MA4gYEsgOmmIQvfK3xFlu;
	}

	static Color smethod_37(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._lUyqwDvFCoXEZ6VM9PVCQ970jps;
	}

	static Color smethod_38(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._qKGefHxdjIUD6ObjxrxnLwbBEsh;
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG.EEyesType smethod_39(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._c0ThYURHAGN0Wzlzw9Ibh3Z8qyo;
	}

	static Color smethod_40(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._GXnDb1oaJlPbAQV2mjAwCQFK0nmb;
	}

	static Color smethod_41(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._0K4lcN7iwo5q0iP1YlkpY9GdayR;
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG.EBrowType smethod_42(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._KBOJ0qhM8C5evPQxibgX74m2WHg;
	}

	static Color smethod_43(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._HRPv5rzDY5zNiP4NADDEGhrzGTe;
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG.EHeadAccessoriesType smethod_44(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._pmr0FnBBvgaggpusBKMWplUa63c;
	}

	static Color smethod_45(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._9b2asKZDwVM1TcSfmfeFCuk0TJZb;
	}

	static Color smethod_46(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._vUhBAXEgvpGKopOUkDJFoc4EYQ3;
	}

	static Color smethod_47(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._uaBF7rEib15d42vH8AzoXWFMMkE;
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG.EMuzzleType smethod_48(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._4QUr9lDqmNxEuy7B4xgb7Lj1HU0;
	}

	static Color smethod_49(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._VsEYbNSam3IFYYWY4QC2lb4ia61;
	}

	static Color smethod_50(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._y1SiMmRVXWDhDtY17knDpitt46F;
	}

	static Color smethod_51(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._T98drEOtEEZKeB5tXzsuPrhb5Xk;
	}

	static bool smethod_52(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._hkFDGB5pWIuOVcIyDAFqHrDdSpjA;
	}

	static Color smethod_53(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._q2iDxJYfqribHB1bD8aSkSjqrfnA;
	}

	static bool smethod_54(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._UAZhvJ3a9BGOBM0CLiDkKLwUFC9;
	}

	static Color smethod_55(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._phJrpk3rql5MfNJxPQ9X7nC8aAk;
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG.EHairstyleType smethod_56(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._03h2I0mTkGTzIA5R48rgwJh7JZA;
	}

	static Color smethod_57(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._bJmvnPs69aVDXxG48lmruYZFHKt;
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG.EFringeType smethod_58(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._fzMbZCCd7imnrcrYWkSj5u8UZ2J;
	}

	static Color smethod_59(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._EvdUMrkAAdTeMv6fOpGrOLCAMq8A;
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG.ETailType smethod_60(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._NrFEKLWh80bQXi9PujCBTqm01AA;
	}

	static Color smethod_61(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._qsK1J3jktKH3eJ2i8sL1oaxXtLc;
	}

	static bool smethod_62(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._PVQfhwHODkR6bzHmfeCK4L8riIG;
	}

	static Color smethod_63(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._62dl1HYYkor3TZL58k5Y33Tj83;
	}

	static bool smethod_64(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._tEXwTuSRSq5JaaFE4W8edEHxS9q;
	}

	static Color smethod_65(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._LufmRsAZrlyDgRKYocQXPzANMaF;
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG.EFeetType smethod_66(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._LZ8c6hRMRYKjnlLOPhbZHcWqUGG;
	}

	static Color smethod_67(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._LZfuQybASevOsCykEWqdvA5GqUF;
	}

	static Color smethod_68(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._zBv1cYqPRU7uDCALpBlBSgObUcbA;
	}

	static Color smethod_69(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ;
	}

	static Color smethod_70(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._1ZKGQXLRAHEJR8v7jhlDsyOVLcz;
	}

	static Color smethod_71(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._8rDSn6e9Ip9WdOogjhIn8YlL1oM;
	}

	static Color smethod_72(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._FrsyMDX7TebzFk8nSLTyRDPi1QH;
	}

	static Color smethod_73(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._cUtgkG5qDvgFmI8c29I9xsLVNON;
	}

	static Color smethod_74(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._LcOPiDaC2j5vzxOEYhvW4vRoaRX;
	}

	static Color smethod_75(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._meyNS02iTIxo212B6c5eoKns2wj;
	}

	static bool smethod_76()
	{
		return _iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF;
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG.EBallsType smethod_77(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._7OCMpsMmozHsAG0GDljMMAlGLJBA;
	}

	static Color smethod_78(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._8qQ7XVlyRYW4icBFxPQCJqgueYD;
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType smethod_79(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._rtyJgfViJdXL2Ela5APpDlk99dI;
	}

	static Color smethod_80(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._XnNREK59QnV1onFFWfSUaS9WK0E;
	}

	static Color smethod_81(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._o6OnmHi5rZIQPHESokp9rTaO1ei;
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG.EBreastsType smethod_82(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._BCncLn6BIYiBX6NdFByAquBYGpH;
	}

	static Color smethod_83(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._pigzqi6DgcSToQkL9g7Ns2QrLfp;
	}

	static bool smethod_84(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Q2AbpMWcrhtCW9MLTtT5gwoleu7;
	}

	static Color smethod_85(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._2yydfEIrSiLPTti2dT8JXGoIaM3;
	}

	static bool smethod_86(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._VmNLhqrIwSnE6JnCYiBcxnSqnEV;
	}

	static Color smethod_87(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._in5HHYmrdLTFpkgc8aimJpXqAXB;
	}

	static Color smethod_88(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._uOkbmfW26QVAvyEMQakki9kTMDbA;
	}

	static _3FFZvGWTAe7rsviKkDPTXEVjxWf smethod_89(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._RbWJ7YGnYHCSoD44MRW1h5X6E7E;
	}

	static Point smethod_90(_3FFZvGWTAe7rsviKkDPTXEVjxWf _3FFZvGWTAe7rsviKkDPTXEVjxWf_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _3FFZvGWTAe7rsviKkDPTXEVjxWf_0._U7CeYBJ1v1SoUxpX8emsQ9mWl5b;
	}

	static bool smethod_91(_3FFZvGWTAe7rsviKkDPTXEVjxWf _3FFZvGWTAe7rsviKkDPTXEVjxWf_0, _PMeRYZJaBCqgB9uADJFP3c14lxq _PMeRYZJaBCqgB9uADJFP3c14lxq_0)
	{
		return _3FFZvGWTAe7rsviKkDPTXEVjxWf_0._WZ4xYI5Q3hoCNX9QFzE3jfDwZBJ(_PMeRYZJaBCqgB9uADJFP3c14lxq_0);
	}

	static int smethod_92(int int_0, int int_1)
	{
		return Math.Max(int_0, int_1);
	}

	static int smethod_93(int int_0, int int_1)
	{
		return Math.Min(int_0, int_1);
	}

	static TimeSpan smethod_94(GameTime gameTime_0)
	{
		return gameTime_0.get_ElapsedGameTime();
	}

	static void smethod_95(_ujAkjlfN5TywwbLAUDzPvtab6uJ _ujAkjlfN5TywwbLAUDzPvtab6uJ_0, float float_0)
	{
		_ujAkjlfN5TywwbLAUDzPvtab6uJ_0._bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}

	static AppDomain smethod_96()
	{
		return AppDomain.CurrentDomain;
	}

	static string smethod_97(AppDomain appDomain_0)
	{
		return appDomain_0.BaseDirectory;
	}
}
