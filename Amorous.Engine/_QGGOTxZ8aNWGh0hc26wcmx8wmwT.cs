using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

public abstract class _QGGOTxZ8aNWGh0hc26wcmx8wmwT
{
	private NPCLocation _2bI4wzb8t3DwN2EjJZnZ3W5KGrd;

	private _xmfdPa5IagU3cXbLL61gyoXAV7gA _qOQwOkwmSzzBu8V0hXoEeq0S3LL;

	private _NaKchYC4I4GjWR34SfBLAktysCE _iz78oRCJ2crDW2Pf2eae57rZuT2;

	private readonly List<string> _aRSb8tZuhU8bFEXFilQOkS2SnI5;

	private readonly Random _2tTGp4eVZLS8tf0Qr1cmyzXMVef;

	private bool _ywu0wbAnB2eAf8NYXzXKWpX6S3L;

	private int _o2qr36sQch9lHBwAXuGG3xV8R7H;

	private int _FgMIm3ypHD6s3Iyg8XUBnOP5doA;

	private const int _Leqdzq4cXjdGS6BiAPGuj94RhfHA = 375;

	private const int _TzMTzhR5S2nJAMkdnbvhoDk6KoE = 625;

	private const int _vC1fLXKakuVjoqlFHuQyx0erpdk = 1000;

	private Action _t4JsGFBOTJyNXqWLeAvYMj8Tnlf;

	private Action _a1rJL2nK5APgc52Z8xdiZnlTdLf;

	private int _XTvGE1JB69E9GLYnSRCwUVGb5PR;

	private const int _5OvUNoKEpbH0jbo3ri5XCBdjxGL = 500;

	protected bool _J4giDjnRtYmiHMmzwRZ0ThvfAhH;

	protected bool _upl1k7yzBzlU7vErvbydGmXROfA;

	public bool _SC7QlorMIWTLSkD757wC7ybszpE;

	public IAmorous Game { get; set; }

	public NPCLocation _9m9LEAgaqaeXydYhykSBmf9BrDG => _2bI4wzb8t3DwN2EjJZnZ3W5KGrd;

	public string _mdS7Bu4eiPPwoFWUcGEOTzh73TJ
	{
		get
		{
			if (_qOQwOkwmSzzBu8V0hXoEeq0S3LL != null)
			{
				return _qOQwOkwmSzzBu8V0hXoEeq0S3LL.Name;
			}
			return null;
		}
	}

	public string _vzNADWxcLucI3DyP1CebcfYXRut
	{
		get
		{
			if (_iz78oRCJ2crDW2Pf2eae57rZuT2 != null)
			{
				return _iz78oRCJ2crDW2Pf2eae57rZuT2.Name;
			}
			return null;
		}
	}

	public string[] _QeyVQAHb3TegEFsv9IPdYmxNkGZ => _aRSb8tZuhU8bFEXFilQOkS2SnI5.ToArray();

	public bool _fsCqU0Uh34vrMEsAqlf2BqbTz5B { get; private set; }

	public List<_xmfdPa5IagU3cXbLL61gyoXAV7gA> _uZyXmbTsZVxXsadCzSsIs0z4xdb { get; private set; }

	public List<_NaKchYC4I4GjWR34SfBLAktysCE> _EcxlglhukYZdLVkSogxZZE3XdVj { get; private set; }

	public virtual float _QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX { get; set; }

	public virtual float _QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY { get; set; }

	public virtual int Width { get; protected set; }

	public virtual int Height { get; protected set; }

	public float _fO7gSlrDDNMoHR4FO5QXAq8fUyA { get; set; }

	public virtual bool _QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn { get; set; }

	public virtual bool _zkHMlDFkja4TqmjdlHuZRCj8FCB { get; set; }

	public virtual bool _IvIFs0Tl6RHdTn3daJXsNCXCNyO { get; set; }

	public virtual Action _ZVpZ5Oing5kbbVhbmbOHyrofGH7 { get; set; }

	public Type[] _rAt6TRbgK04lvrs5QPjcd0n26pk { get; set; }

	protected _QGGOTxZ8aNWGh0hc26wcmx8wmwT(IAmorous amorous)
	{
		_Rx2wNR2enRtLcTLuHC6H9bGAUgq = 1f;
		_aRSb8tZuhU8bFEXFilQOkS2SnI5 = new List<string>();
		base._002Ector();
		Game = amorous;
		_uZyXmbTsZVxXsadCzSsIs0z4xdb = new List<_xmfdPa5IagU3cXbLL61gyoXAV7gA>();
		_EcxlglhukYZdLVkSogxZZE3XdVj = new List<_NaKchYC4I4GjWR34SfBLAktysCE>();
		_2tTGp4eVZLS8tf0Qr1cmyzXMVef = new Random();
		_ywu0wbAnB2eAf8NYXzXKWpX6S3L = false;
		_o2qr36sQch9lHBwAXuGG3xV8R7H = 0;
		_FgMIm3ypHD6s3Iyg8XUBnOP5doA = 4000;
	}

	public virtual void Begin()
	{
	}

	public _xmfdPa5IagU3cXbLL61gyoXAV7gA _aRXZ6kQYnlqRUMIC19x1vIPD62D(string string_0, params string[] string_1)
	{
		_xmfdPa5IagU3cXbLL61gyoXAV7gA xmfdPa5IagU3cXbLL61gyoXAV7gA = new _xmfdPa5IagU3cXbLL61gyoXAV7gA(string_0, string_1);
		_uZyXmbTsZVxXsadCzSsIs0z4xdb.Add(xmfdPa5IagU3cXbLL61gyoXAV7gA);
		return xmfdPa5IagU3cXbLL61gyoXAV7gA;
	}

	public _NaKchYC4I4GjWR34SfBLAktysCE _zDmJ8ztQTMoRvRw2LsNKu5foPpF(string string_0, params string[] string_1)
	{
		_NaKchYC4I4GjWR34SfBLAktysCE naKchYC4I4GjWR34SfBLAktysCE = new _NaKchYC4I4GjWR34SfBLAktysCE(string_0, string_1);
		_EcxlglhukYZdLVkSogxZZE3XdVj.Add(naKchYC4I4GjWR34SfBLAktysCE);
		return naKchYC4I4GjWR34SfBLAktysCE;
	}

	public _EZ0kOLXoEoEfWGQDdTbNqaPzDUh _ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(string string_0, string string_1, params string[] string_2)
	{
		_EZ0kOLXoEoEfWGQDdTbNqaPzDUh eZ0kOLXoEoEfWGQDdTbNqaPzDUh = new _EZ0kOLXoEoEfWGQDdTbNqaPzDUh(string_1, string_2);
		_NaKchYC4I4GjWR34SfBLAktysCE naKchYC4I4GjWR34SfBLAktysCE = _EcxlglhukYZdLVkSogxZZE3XdVj.First((_NaKchYC4I4GjWR34SfBLAktysCE _NaKchYC4I4GjWR34SfBLAktysCE_0) => _NaKchYC4I4GjWR34SfBLAktysCE_0.Name == string_0);
		naKchYC4I4GjWR34SfBLAktysCE.Clothes.Add(eZ0kOLXoEoEfWGQDdTbNqaPzDUh);
		return eZ0kOLXoEoEfWGQDdTbNqaPzDUh;
	}

	public virtual void Update(GameTime gameTime_0)
	{
		if (_qOQwOkwmSzzBu8V0hXoEeq0S3LL != null && !string.IsNullOrEmpty(_qOQwOkwmSzzBu8V0hXoEeq0S3LL._RaPHmtsFBJiVmlc8lVytEMOT6ZA))
		{
			_jMxh8Eu01hPD0qBoh705AvKQ69k(gameTime_0);
		}
		_1TexRAv8TgmLSYZPaXObsZp5CgP(gameTime_0);
	}

	public virtual void Draw()
	{
		_gytsCM4ef57F54AqmuiBr238JE0();
	}

	private void _jMxh8Eu01hPD0qBoh705AvKQ69k(GameTime gameTime_0)
	{
		if (_XTvGE1JB69E9GLYnSRCwUVGb5PR > 0)
		{
			return;
		}
		if (!_ywu0wbAnB2eAf8NYXzXKWpX6S3L)
		{
			_FgMIm3ypHD6s3Iyg8XUBnOP5doA -= gameTime_0.ElapsedGameTime.Milliseconds;
			if (_FgMIm3ypHD6s3Iyg8XUBnOP5doA <= 0)
			{
				_ywu0wbAnB2eAf8NYXzXKWpX6S3L = true;
				_o2qr36sQch9lHBwAXuGG3xV8R7H = 0;
			}
			return;
		}
		_o2qr36sQch9lHBwAXuGG3xV8R7H += gameTime_0.ElapsedGameTime.Milliseconds;
		float float_ = 0f;
		if (_o2qr36sQch9lHBwAXuGG3xV8R7H < 375)
		{
			float_ = (float)_o2qr36sQch9lHBwAXuGG3xV8R7H / 375f;
		}
		else if (_o2qr36sQch9lHBwAXuGG3xV8R7H >= 375 && _o2qr36sQch9lHBwAXuGG3xV8R7H < 625)
		{
			float_ = 1f;
		}
		else if (_o2qr36sQch9lHBwAXuGG3xV8R7H >= 625 && _o2qr36sQch9lHBwAXuGG3xV8R7H < 1000)
		{
			float_ = 1f - (float)(_o2qr36sQch9lHBwAXuGG3xV8R7H - 625) / 375f;
		}
		else if (_o2qr36sQch9lHBwAXuGG3xV8R7H >= 1000)
		{
			_ywu0wbAnB2eAf8NYXzXKWpX6S3L = false;
			_FgMIm3ypHD6s3Iyg8XUBnOP5doA = _2tTGp4eVZLS8tf0Qr1cmyzXMVef.Next(3, 6) * 1000;
		}
		_aAoZaDNczeScsMfLlGSfAzey9SQ(_qOQwOkwmSzzBu8V0hXoEeq0S3LL._RaPHmtsFBJiVmlc8lVytEMOT6ZA, float_);
	}

	protected void _aAoZaDNczeScsMfLlGSfAzey9SQ(_N8bBL1xcL0zn0y2AJaH2UHKhLLz _N8bBL1xcL0zn0y2AJaH2UHKhLLz_0, float float_0)
	{
		if (_N8bBL1xcL0zn0y2AJaH2UHKhLLz_0 == null)
		{
			return;
		}
		foreach (string item in _N8bBL1xcL0zn0y2AJaH2UHKhLLz_0._YJmTJgv7TfeWJelscsKB1PI6D4m())
		{
			_aAoZaDNczeScsMfLlGSfAzey9SQ(item, float_0);
		}
	}

	protected abstract void _aAoZaDNczeScsMfLlGSfAzey9SQ(string string_0, float float_0);

	private void _HYGEFuKjM6VOd22bJ3oo5hYTDYR(_N8bBL1xcL0zn0y2AJaH2UHKhLLz _N8bBL1xcL0zn0y2AJaH2UHKhLLz_0)
	{
		_aAoZaDNczeScsMfLlGSfAzey9SQ(_N8bBL1xcL0zn0y2AJaH2UHKhLLz_0, 1f);
	}

	private void _jKpNeZVvIxqbKB3I3fQBgijMuQP(_N8bBL1xcL0zn0y2AJaH2UHKhLLz _N8bBL1xcL0zn0y2AJaH2UHKhLLz_0)
	{
		_aAoZaDNczeScsMfLlGSfAzey9SQ(_N8bBL1xcL0zn0y2AJaH2UHKhLLz_0, 0f);
	}

	public virtual void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation npclocation_0)
	{
		_2bI4wzb8t3DwN2EjJZnZ3W5KGrd = npclocation_0;
	}

	public void _g3oEqGBkN3YHUPosRq2nIP2sX0D(string string_0)
	{
		_xmfdPa5IagU3cXbLL61gyoXAV7gA xmfdPa5IagU3cXbLL61gyoXAV7gA = _uZyXmbTsZVxXsadCzSsIs0z4xdb.FirstOrDefault((_xmfdPa5IagU3cXbLL61gyoXAV7gA _xmfdPa5IagU3cXbLL61gyoXAV7gA_0) => _xmfdPa5IagU3cXbLL61gyoXAV7gA_0.Name == string_0);
		if (_qOQwOkwmSzzBu8V0hXoEeq0S3LL != null)
		{
			_jKpNeZVvIxqbKB3I3fQBgijMuQP(_qOQwOkwmSzzBu8V0hXoEeq0S3LL);
			if (_qOQwOkwmSzzBu8V0hXoEeq0S3LL._RaPHmtsFBJiVmlc8lVytEMOT6ZA != null)
			{
				_aAoZaDNczeScsMfLlGSfAzey9SQ(_qOQwOkwmSzzBu8V0hXoEeq0S3LL._RaPHmtsFBJiVmlc8lVytEMOT6ZA, 0f);
			}
		}
		_qOQwOkwmSzzBu8V0hXoEeq0S3LL = xmfdPa5IagU3cXbLL61gyoXAV7gA;
		if (xmfdPa5IagU3cXbLL61gyoXAV7gA != null)
		{
			_HYGEFuKjM6VOd22bJ3oo5hYTDYR(xmfdPa5IagU3cXbLL61gyoXAV7gA);
		}
	}

	public void _tDFvus0ZCanjp81eOiDzoMXJiuf(string string_0)
	{
		_NaKchYC4I4GjWR34SfBLAktysCE naKchYC4I4GjWR34SfBLAktysCE = _EcxlglhukYZdLVkSogxZZE3XdVj.FirstOrDefault((_NaKchYC4I4GjWR34SfBLAktysCE _NaKchYC4I4GjWR34SfBLAktysCE_0) => _NaKchYC4I4GjWR34SfBLAktysCE_0.Name == string_0);
		if (_iz78oRCJ2crDW2Pf2eae57rZuT2 != null)
		{
			_jKpNeZVvIxqbKB3I3fQBgijMuQP(_iz78oRCJ2crDW2Pf2eae57rZuT2);
		}
		_iz78oRCJ2crDW2Pf2eae57rZuT2 = naKchYC4I4GjWR34SfBLAktysCE;
		if (naKchYC4I4GjWR34SfBLAktysCE != null)
		{
			_09vxUzgOn7J7DFZEwsTh7lgEIhB(_aRSb8tZuhU8bFEXFilQOkS2SnI5.ToArray());
		}
	}

	public void _09vxUzgOn7J7DFZEwsTh7lgEIhB(params string[] string_0)
	{
		if (_iz78oRCJ2crDW2Pf2eae57rZuT2 == null)
		{
			return;
		}
		_aRSb8tZuhU8bFEXFilQOkS2SnI5.Clear();
		_jKpNeZVvIxqbKB3I3fQBgijMuQP(_iz78oRCJ2crDW2Pf2eae57rZuT2);
		_EZ0kOLXoEoEfWGQDdTbNqaPzDUh eZ0kOLXoEoEfWGQDdTbNqaPzDUh = null;
		_EZ0kOLXoEoEfWGQDdTbNqaPzDUh eZ0kOLXoEoEfWGQDdTbNqaPzDUh2 = null;
		bool flag = false;
		bool flag2 = false;
		foreach (_EZ0kOLXoEoEfWGQDdTbNqaPzDUh item in _iz78oRCJ2crDW2Pf2eae57rZuT2.Clothes)
		{
			item._3ZeCDXqcWHY4XJDBGyav3UzxYaHA = string_0?.Contains(item.Name) ?? false;
			if (_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
			{
				if (_J4giDjnRtYmiHMmzwRZ0ThvfAhH && item._e2POqMcfS1X8JA2T5lRdGOIad0P && (eZ0kOLXoEoEfWGQDdTbNqaPzDUh == null || item._iNKFrVbZ0JvJuGWetYZed8N4Vq))
				{
					eZ0kOLXoEoEfWGQDdTbNqaPzDUh = item;
				}
				if (_upl1k7yzBzlU7vErvbydGmXROfA && item._Iv7le7JF0bkbEaSDuGvHcO5XpSe && (eZ0kOLXoEoEfWGQDdTbNqaPzDUh2 == null || item._92BE70KbSHbZ3S7846IZBOlorHN))
				{
					eZ0kOLXoEoEfWGQDdTbNqaPzDUh2 = item;
				}
			}
			if (!item._3ZeCDXqcWHY4XJDBGyav3UzxYaHA)
			{
				continue;
			}
			if (!_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
			{
				if ((_iExD93IWLlzVfXsU9wyrEvWgJsg._b52DDz3MN1kD8sgdQhCNO1tJRNn && item._e2POqMcfS1X8JA2T5lRdGOIad0P) || (_iExD93IWLlzVfXsU9wyrEvWgJsg._pKBiGAgDu5WqoykkGBaEGnP7oMj && item._Iv7le7JF0bkbEaSDuGvHcO5XpSe))
				{
					item._3ZeCDXqcWHY4XJDBGyav3UzxYaHA = false;
					continue;
				}
			}
			else
			{
				flag |= item._e2POqMcfS1X8JA2T5lRdGOIad0P;
				flag2 |= item._Iv7le7JF0bkbEaSDuGvHcO5XpSe;
			}
			_aRSb8tZuhU8bFEXFilQOkS2SnI5.Add(item.Name);
		}
		if (_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
		{
			if (_J4giDjnRtYmiHMmzwRZ0ThvfAhH && !flag && eZ0kOLXoEoEfWGQDdTbNqaPzDUh != null)
			{
				eZ0kOLXoEoEfWGQDdTbNqaPzDUh._3ZeCDXqcWHY4XJDBGyav3UzxYaHA = true;
				_aRSb8tZuhU8bFEXFilQOkS2SnI5.Add(eZ0kOLXoEoEfWGQDdTbNqaPzDUh.Name);
			}
			if (_upl1k7yzBzlU7vErvbydGmXROfA && !flag2 && eZ0kOLXoEoEfWGQDdTbNqaPzDUh2 != null)
			{
				eZ0kOLXoEoEfWGQDdTbNqaPzDUh2._3ZeCDXqcWHY4XJDBGyav3UzxYaHA = true;
				_aRSb8tZuhU8bFEXFilQOkS2SnI5.Add(eZ0kOLXoEoEfWGQDdTbNqaPzDUh2.Name);
			}
		}
		_HYGEFuKjM6VOd22bJ3oo5hYTDYR(_iz78oRCJ2crDW2Pf2eae57rZuT2);
	}

	public void _7d2DAwjp6FutkJY09U0Mlk43Nmn(NPCLocation npclocation_0, string string_0, string string_1, params string[] string_2)
	{
		if (_XTvGE1JB69E9GLYnSRCwUVGb5PR > 0)
		{
			_hzYGOuA9Z2IzKGHdfIk6l5BgWNV();
			_Hx7zLXU6nbxudxFgMuYbyRXeEPB();
		}
		_fsCqU0Uh34vrMEsAqlf2BqbTz5B = true;
		_t4JsGFBOTJyNXqWLeAvYMj8Tnlf = delegate
		{
			_t4JsGFBOTJyNXqWLeAvYMj8Tnlf = null;
			_Ya7aXbokIO6bHC3fvJdnvweslhH(npclocation_0, string_0 ?? _mdS7Bu4eiPPwoFWUcGEOTzh73TJ, string_1 ?? _vzNADWxcLucI3DyP1CebcfYXRut, string_2 ?? _QeyVQAHb3TegEFsv9IPdYmxNkGZ);
		};
		_XTvGE1JB69E9GLYnSRCwUVGb5PR = 500;
	}

	public void _CX43jhSKNOViVFqkMliNa9qgGon()
	{
		if (_XTvGE1JB69E9GLYnSRCwUVGb5PR > 0)
		{
			_hzYGOuA9Z2IzKGHdfIk6l5BgWNV();
			_Hx7zLXU6nbxudxFgMuYbyRXeEPB();
		}
		_fsCqU0Uh34vrMEsAqlf2BqbTz5B = true;
		_t4JsGFBOTJyNXqWLeAvYMj8Tnlf = delegate
		{
			_t4JsGFBOTJyNXqWLeAvYMj8Tnlf = null;
			_Ya7aXbokIO6bHC3fvJdnvweslhH(NPCLocation.None, null, null, null);
		};
		_XTvGE1JB69E9GLYnSRCwUVGb5PR = 500;
	}

	private void _Ya7aXbokIO6bHC3fvJdnvweslhH(NPCLocation npclocation_0, string string_0, string string_1, string[] string_2)
	{
		_a1rJL2nK5APgc52Z8xdiZnlTdLf = delegate
		{
			_BbDRof5yB0Qn864T1KJxUzMy8di(0);
			_a1rJL2nK5APgc52Z8xdiZnlTdLf = delegate
			{
				_fsCqU0Uh34vrMEsAqlf2BqbTz5B = false;
				_nGGBtYpZ8pI1BmE2c2ke63UjGDP(npclocation_0);
				_g3oEqGBkN3YHUPosRq2nIP2sX0D(string_0);
				_tDFvus0ZCanjp81eOiDzoMXJiuf(string_1);
				_09vxUzgOn7J7DFZEwsTh7lgEIhB(string_2);
				if (_BbDRof5yB0Qn864T1KJxUzMy8di(1))
				{
					_a1rJL2nK5APgc52Z8xdiZnlTdLf = delegate
					{
						_a1rJL2nK5APgc52Z8xdiZnlTdLf = null;
						_BbDRof5yB0Qn864T1KJxUzMy8di(2);
					};
				}
				else
				{
					_a1rJL2nK5APgc52Z8xdiZnlTdLf = null;
					_Hx7zLXU6nbxudxFgMuYbyRXeEPB();
				}
			};
		};
	}

	private void _1TexRAv8TgmLSYZPaXObsZp5CgP(GameTime gameTime_0)
	{
		if (_XTvGE1JB69E9GLYnSRCwUVGb5PR <= 0)
		{
			return;
		}
		if (_t4JsGFBOTJyNXqWLeAvYMj8Tnlf != null)
		{
			_t4JsGFBOTJyNXqWLeAvYMj8Tnlf();
			return;
		}
		_XTvGE1JB69E9GLYnSRCwUVGb5PR -= gameTime_0.ElapsedGameTime.Milliseconds;
		if (_XTvGE1JB69E9GLYnSRCwUVGb5PR > 0)
		{
			_PdRLTpsImBScBFQhILtCHJpcsllA((float)_XTvGE1JB69E9GLYnSRCwUVGb5PR / 500f);
		}
		else
		{
			_Hx7zLXU6nbxudxFgMuYbyRXeEPB();
		}
	}

	private void _gytsCM4ef57F54AqmuiBr238JE0()
	{
		if (_XTvGE1JB69E9GLYnSRCwUVGb5PR > 0 && _a1rJL2nK5APgc52Z8xdiZnlTdLf != null)
		{
			_a1rJL2nK5APgc52Z8xdiZnlTdLf();
		}
	}

	private void _hzYGOuA9Z2IzKGHdfIk6l5BgWNV()
	{
		if (_t4JsGFBOTJyNXqWLeAvYMj8Tnlf != null)
		{
			_t4JsGFBOTJyNXqWLeAvYMj8Tnlf();
		}
		while (_a1rJL2nK5APgc52Z8xdiZnlTdLf != null)
		{
			_a1rJL2nK5APgc52Z8xdiZnlTdLf();
		}
	}

	protected abstract bool _BbDRof5yB0Qn864T1KJxUzMy8di(int int_0);

	protected abstract void _PdRLTpsImBScBFQhILtCHJpcsllA(float float_0);

	protected abstract void _Hx7zLXU6nbxudxFgMuYbyRXeEPB();
}
