using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

public abstract class AbstractNPC
{
	private NPCLocation _location;
	private _xmfdPa5IagU3cXbLL61gyoXAV7gA _emotion;
	private _NaKchYC4I4GjWR34SfBLAktysCE _pose;
	private readonly List<string> _clothes;
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
	public NPCLocation Location => _location;

	public string Head
	{
		get
		{
			if (_emotion != null)
			{
				return _emotion.Name;
			}
			return null;
		}
	}

	public string Pose
	{
		get
		{
			if (_pose != null)
			{
				return _pose.Name;
			}
			return null;
		}
	}

	public string[] Clothes => _clothes.ToArray();
	public bool _fsCqU0Uh34vrMEsAqlf2BqbTz5B { get; private set; }
	public List<_xmfdPa5IagU3cXbLL61gyoXAV7gA> _uZyXmbTsZVxXsadCzSsIs0z4xdb { get; private set; }
	public List<_NaKchYC4I4GjWR34SfBLAktysCE> _EcxlglhukYZdLVkSogxZZE3XdVj { get; private set; }
	public virtual float X { get; set; }
	public virtual float Y { get; set; }
	public virtual int Width { get; protected set; }
	public virtual int Height { get; protected set; }
	public float Scale { get; set; }
	public virtual bool FlipX { get; set; }
	public virtual bool _zkHMlDFkja4TqmjdlHuZRCj8FCB { get; set; }
	public virtual bool _IvIFs0Tl6RHdTn3daJXsNCXCNyO { get; set; }
	public virtual Action Click { get; set; }
	public Type[] _rAt6TRbgK04lvrs5QPjcd0n26pk { get; set; }

	protected AbstractNPC(IAmorous amorous)
	{
		Scale = 1f;
		_clothes = new List<string>();
		Game = amorous;
		_uZyXmbTsZVxXsadCzSsIs0z4xdb = new List<_xmfdPa5IagU3cXbLL61gyoXAV7gA>();
		_EcxlglhukYZdLVkSogxZZE3XdVj = new List<_NaKchYC4I4GjWR34SfBLAktysCE>();
		_2tTGp4eVZLS8tf0Qr1cmyzXMVef = new Random();
		_ywu0wbAnB2eAf8NYXzXKWpX6S3L = false;
		_o2qr36sQch9lHBwAXuGG3xV8R7H = 0;
		_FgMIm3ypHD6s3Iyg8XUBnOP5doA = 4000;
	}

	public virtual void Begin() {}

	public _xmfdPa5IagU3cXbLL61gyoXAV7gA GetEmotion(string string_0, params string[] string_1)
	{
		_xmfdPa5IagU3cXbLL61gyoXAV7gA emotion = new _xmfdPa5IagU3cXbLL61gyoXAV7gA(string_0, string_1);
		_uZyXmbTsZVxXsadCzSsIs0z4xdb.Add(emotion);
		return emotion;
	}

	public _NaKchYC4I4GjWR34SfBLAktysCE GetPose(string string_0, params string[] string_1)
	{
		_NaKchYC4I4GjWR34SfBLAktysCE pose = new _NaKchYC4I4GjWR34SfBLAktysCE(string_0, string_1);
		_EcxlglhukYZdLVkSogxZZE3XdVj.Add(pose);
		return pose;
	}

	public _EZ0kOLXoEoEfWGQDdTbNqaPzDUh GetClothes(string string_0, string string_1, params string[] string_2)
	{
		_EZ0kOLXoEoEfWGQDdTbNqaPzDUh shirt = new _EZ0kOLXoEoEfWGQDdTbNqaPzDUh(string_1, string_2);
		_NaKchYC4I4GjWR34SfBLAktysCE pose = _EcxlglhukYZdLVkSogxZZE3XdVj.First((_NaKchYC4I4GjWR34SfBLAktysCE _NaKchYC4I4GjWR34SfBLAktysCE_0) => _NaKchYC4I4GjWR34SfBLAktysCE_0.Name == string_0);
		pose.Clothes.Add(shirt);
		return shirt;
	}

	public virtual void Update(GameTime gameTime)
	{
		if (_emotion != null && !string.IsNullOrEmpty(_emotion._RaPHmtsFBJiVmlc8lVytEMOT6ZA))
		{
			_jMxh8Eu01hPD0qBoh705AvKQ69k(gameTime);
		}
		_1TexRAv8TgmLSYZPaXObsZp5CgP(gameTime);
	}

	public virtual void Draw()
	{
		_gytsCM4ef57F54AqmuiBr238JE0();
	}

	private void _jMxh8Eu01hPD0qBoh705AvKQ69k(GameTime gameTime)
	{
		if (_XTvGE1JB69E9GLYnSRCwUVGb5PR > 0)
		{
			return;
		}
		if (!_ywu0wbAnB2eAf8NYXzXKWpX6S3L)
		{
			_FgMIm3ypHD6s3Iyg8XUBnOP5doA -= gameTime.ElapsedGameTime.Milliseconds;
			if (_FgMIm3ypHD6s3Iyg8XUBnOP5doA <= 0)
			{
				_ywu0wbAnB2eAf8NYXzXKWpX6S3L = true;
				_o2qr36sQch9lHBwAXuGG3xV8R7H = 0;
			}
			return;
		}
		_o2qr36sQch9lHBwAXuGG3xV8R7H += gameTime.ElapsedGameTime.Milliseconds;
		float float_ = 0f;
		if (_o2qr36sQch9lHBwAXuGG3xV8R7H < _Leqdzq4cXjdGS6BiAPGuj94RhfHA)
		{
			float_ = (float)_o2qr36sQch9lHBwAXuGG3xV8R7H / 375f;
		}
		else if (_o2qr36sQch9lHBwAXuGG3xV8R7H >= _Leqdzq4cXjdGS6BiAPGuj94RhfHA && _o2qr36sQch9lHBwAXuGG3xV8R7H < _TzMTzhR5S2nJAMkdnbvhoDk6KoE)
		{
			float_ = 1f;
		}
		else if (_o2qr36sQch9lHBwAXuGG3xV8R7H >= _TzMTzhR5S2nJAMkdnbvhoDk6KoE && _o2qr36sQch9lHBwAXuGG3xV8R7H < _vC1fLXKakuVjoqlFHuQyx0erpdk)
		{
			float_ = 1f - (float)(_o2qr36sQch9lHBwAXuGG3xV8R7H - _TzMTzhR5S2nJAMkdnbvhoDk6KoE) / 375f;
		}
		else if (_o2qr36sQch9lHBwAXuGG3xV8R7H >= _vC1fLXKakuVjoqlFHuQyx0erpdk)
		{
			_ywu0wbAnB2eAf8NYXzXKWpX6S3L = false;
			_FgMIm3ypHD6s3Iyg8XUBnOP5doA = _2tTGp4eVZLS8tf0Qr1cmyzXMVef.Next(3, 6) * _vC1fLXKakuVjoqlFHuQyx0erpdk;
		}
		SetAlpha(_emotion._RaPHmtsFBJiVmlc8lVytEMOT6ZA, float_);
	}

	protected void SetAlpha(_N8bBL1xcL0zn0y2AJaH2UHKhLLz _N8bBL1xcL0zn0y2AJaH2UHKhLLz_0, float float_0)
	{
		if (_N8bBL1xcL0zn0y2AJaH2UHKhLLz_0 == null)
		{
			return;
		}
		foreach (string item in _N8bBL1xcL0zn0y2AJaH2UHKhLLz_0._YJmTJgv7TfeWJelscsKB1PI6D4m())
		{
			SetAlpha(item, float_0);
		}
	}

	protected abstract void SetAlpha(string string_0, float float_0);

	private void Show(_N8bBL1xcL0zn0y2AJaH2UHKhLLz _N8bBL1xcL0zn0y2AJaH2UHKhLLz_0)
	{
		SetAlpha(_N8bBL1xcL0zn0y2AJaH2UHKhLLz_0, 1f);
	}

	private void Hide(_N8bBL1xcL0zn0y2AJaH2UHKhLLz _N8bBL1xcL0zn0y2AJaH2UHKhLLz_0)
	{
		SetAlpha(_N8bBL1xcL0zn0y2AJaH2UHKhLLz_0, 0f);
	}

	public virtual void SetLocation(NPCLocation location)
	{
		_location = location;
	}

	public void SetEmotion(string name)
	{
		_xmfdPa5IagU3cXbLL61gyoXAV7gA emotion = _uZyXmbTsZVxXsadCzSsIs0z4xdb.FirstOrDefault((_xmfdPa5IagU3cXbLL61gyoXAV7gA _xmfdPa5IagU3cXbLL61gyoXAV7gA_0) => _xmfdPa5IagU3cXbLL61gyoXAV7gA_0.Name == name);
		if (_emotion != null)
		{
			Hide(_emotion);
			if (_emotion._RaPHmtsFBJiVmlc8lVytEMOT6ZA != null)
			{
				SetAlpha(_emotion._RaPHmtsFBJiVmlc8lVytEMOT6ZA, 0f);
			}
		}
		_emotion = emotion;
		if (emotion != null)
		{
			Show(emotion);
		}
	}

	public void SetPose(string name)
	{
		_NaKchYC4I4GjWR34SfBLAktysCE pose = _EcxlglhukYZdLVkSogxZZE3XdVj.FirstOrDefault((_NaKchYC4I4GjWR34SfBLAktysCE _NaKchYC4I4GjWR34SfBLAktysCE_0) => _NaKchYC4I4GjWR34SfBLAktysCE_0.Name == name);
		if (_pose != null)
		{
			Hide(_pose);
		}
		_pose = pose;
		if (pose != null)
		{
			SetClothes(_clothes.ToArray());
		}
	}

	public void SetClothes(params string[] names)
	{
		if (_pose == null)
		{
			return;
		}
		_clothes.Clear();
		Hide(_pose);
		_EZ0kOLXoEoEfWGQDdTbNqaPzDUh shirt = null;
		_EZ0kOLXoEoEfWGQDdTbNqaPzDUh pants = null;
		bool withShirt = false;
		bool withPants = false;
		foreach (_EZ0kOLXoEoEfWGQDdTbNqaPzDUh item in _pose.Clothes)
		{
			item.Updatable = names?.Contains(item.Name) ?? false;
			if (Censorship.Censored)
			{
				if (_J4giDjnRtYmiHMmzwRZ0ThvfAhH && item._e2POqMcfS1X8JA2T5lRdGOIad0P && (shirt == null || item._iNKFrVbZ0JvJuGWetYZed8N4Vq))
				{
					shirt = item;
				}
				if (_upl1k7yzBzlU7vErvbydGmXROfA && item._Iv7le7JF0bkbEaSDuGvHcO5XpSe && (pants == null || item._92BE70KbSHbZ3S7846IZBOlorHN))
				{
					pants = item;
				}
			}
			if (!item.Updatable)
			{
				continue;
			}
			if (!Censorship.Censored)
			{
				if ((Censorship.Topless && item._e2POqMcfS1X8JA2T5lRdGOIad0P) || (Censorship.Bottomless && item._Iv7le7JF0bkbEaSDuGvHcO5XpSe))
				{
					item.Updatable = false;
					continue;
				}
			}
			else
			{
				withShirt |= item._e2POqMcfS1X8JA2T5lRdGOIad0P;
				withPants |= item._Iv7le7JF0bkbEaSDuGvHcO5XpSe;
			}
			_clothes.Add(item.Name);
		}
		if (Censorship.Censored)
		{
			if (_J4giDjnRtYmiHMmzwRZ0ThvfAhH && !withShirt && shirt != null)
			{
				shirt.Updatable = true;
				_clothes.Add(shirt.Name);
			}
			if (_upl1k7yzBzlU7vErvbydGmXROfA && !withPants && pants != null)
			{
				pants.Updatable = true;
				_clothes.Add(pants.Name);
			}
		}
		Show(_pose);
	}

	public void _7d2DAwjp6FutkJY09U0Mlk43Nmn(NPCLocation location, string head, string pose, params string[] clothes)
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
			_Ya7aXbokIO6bHC3fvJdnvweslhH(location, head ?? Head, pose ?? Pose, clothes ?? Clothes);
		};
		_XTvGE1JB69E9GLYnSRCwUVGb5PR = _5OvUNoKEpbH0jbo3ri5XCBdjxGL;
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
		_XTvGE1JB69E9GLYnSRCwUVGb5PR = _5OvUNoKEpbH0jbo3ri5XCBdjxGL;
	}

	private void _Ya7aXbokIO6bHC3fvJdnvweslhH(NPCLocation location, string head, string pose, string[] clothes)
	{
		_a1rJL2nK5APgc52Z8xdiZnlTdLf = delegate
		{
			_BbDRof5yB0Qn864T1KJxUzMy8di(0);
			_a1rJL2nK5APgc52Z8xdiZnlTdLf = delegate
			{
				_fsCqU0Uh34vrMEsAqlf2BqbTz5B = false;
				SetLocation(location);
				SetEmotion(head);
				SetPose(pose);
				SetClothes(clothes);
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

	private void _1TexRAv8TgmLSYZPaXObsZp5CgP(GameTime gameTime)
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
		_XTvGE1JB69E9GLYnSRCwUVGb5PR -= gameTime.ElapsedGameTime.Milliseconds;
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
