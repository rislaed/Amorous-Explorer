using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

public abstract class _xZgbANe7gi6i2DAhBEkKpR1QFLe : AbstractNPC
{
	private class _e6Sul13xByZYV3zUae0HX9fjnS
	{
		private readonly _xZgbANe7gi6i2DAhBEkKpR1QFLe _v5mBBzOHST4Ij2jetldrF2beJtbA;

		private Color _JbGNnZhaeWyNm0aWm7TtSamww4C = Color.White;

		private float _AQwQu1ldCtpbkD5F9oEByJdCnWaA;

		private readonly Texture2D _OzFEGvZu5tqLcitcWhX3j9pIBZM;

		public string Name { get; private set; }

		public float _WxTaPaOE8qb7d7anVlwwqCzugAo
		{
			set
			{
				if (value < 0f)
				{
					_AQwQu1ldCtpbkD5F9oEByJdCnWaA = 0f;
				}
				else if (value <= 1f)
				{
					_AQwQu1ldCtpbkD5F9oEByJdCnWaA = value;
				}
				else
				{
					_AQwQu1ldCtpbkD5F9oEByJdCnWaA = 1f;
				}
				_JbGNnZhaeWyNm0aWm7TtSamww4C.A = (byte)(255f * _AQwQu1ldCtpbkD5F9oEByJdCnWaA);
			}
		}

		public _e6Sul13xByZYV3zUae0HX9fjnS(_xZgbANe7gi6i2DAhBEkKpR1QFLe _xZgbANe7gi6i2DAhBEkKpR1QFLe_0, string string_0, Texture2D texture2D_0)
		{
			_v5mBBzOHST4Ij2jetldrF2beJtbA = _xZgbANe7gi6i2DAhBEkKpR1QFLe_0;
			Name = string_0;
			_OzFEGvZu5tqLcitcWhX3j9pIBZM = texture2D_0;
			_WxTaPaOE8qb7d7anVlwwqCzugAo = 0f;
		}

		public void Draw(SpriteBatch spriteBatch, float float_0, bool bool_0)
		{
			if (_JbGNnZhaeWyNm0aWm7TtSamww4C.A != 0)
			{
				_JbGNnZhaeWyNm0aWm7TtSamww4C.G = (byte)((!bool_0) ? byte.MaxValue : 0);
				_JbGNnZhaeWyNm0aWm7TtSamww4C.B = (byte)((!bool_0) ? byte.MaxValue : 0);
			}
		}
	}

	private readonly string _cBXbsynpanoywEAm2hd5ysuf78l;

	private List<_e6Sul13xByZYV3zUae0HX9fjnS> _uCN0rAUpYyEIvrweCRehrSN3Vsm;

	private Vector2 _8unc6IeMzWr21kLsfewGCwXMejbA = Vector2.Zero;

	public bool _YyDeMNgCbNCOMTBX2QLUb4ruMp9A = true;

	protected readonly float _jSsdHgef86oxWXEOENwyht1nIvn = _boyt8NIMtKsAGSTcjHeL0WMbFxs._S7DdtNZASTkc9riB27h5Ktq5VjDA(0f, (float)Math.PI * 2f);

	protected float _ZSm5WiT2IPnq6W1i4QmcxHACwQh = 1f;

	private readonly Effect _9jklVVcQQYcyqOYrkPiht2VP0IG;

	public override float X
	{
		get
		{
			return _8unc6IeMzWr21kLsfewGCwXMejbA.X;
		}
		set
		{
			_8unc6IeMzWr21kLsfewGCwXMejbA.X = value;
		}
	}

	public override float Y
	{
		get
		{
			return _8unc6IeMzWr21kLsfewGCwXMejbA.Y;
		}
		set
		{
			_8unc6IeMzWr21kLsfewGCwXMejbA.Y = value;
		}
	}

	protected _xZgbANe7gi6i2DAhBEkKpR1QFLe(IAmorous game, string string_0, float float_0 = 1f)
		: base(game)
	{
		_cBXbsynpanoywEAm2hd5ysuf78l = string_0;
		_uCN0rAUpYyEIvrweCRehrSN3Vsm = new List<_e6Sul13xByZYV3zUae0HX9fjnS>();
		base.Scale = float_0;
		_9jklVVcQQYcyqOYrkPiht2VP0IG = base.Game.Content.Load<Effect>("Assets/Shaders/Breathing");
	}

	public override void Begin()
	{
		foreach (_NaKchYC4I4GjWR34SfBLAktysCE item in base._EcxlglhukYZdLVkSogxZZE3XdVj)
		{
			item._CjFYKEH7Vq8U6urMqr8ixn5Z8li.ForEach(delegate(string string_0)
			{
				_wKyvqIzFCeVgn62yYXdOxlqw4In(base.Game.Content, string_0);
			});
			item._l11eB5s4oGaWqILnwn3dX83PzrN.ForEach(delegate(string string_0)
			{
				_wKyvqIzFCeVgn62yYXdOxlqw4In(base.Game.Content, string_0);
			});
			foreach (_EZ0kOLXoEoEfWGQDdTbNqaPzDUh item2 in item.Clothes)
			{
				item2._CjFYKEH7Vq8U6urMqr8ixn5Z8li.ForEach(delegate(string string_0)
				{
					_wKyvqIzFCeVgn62yYXdOxlqw4In(base.Game.Content, string_0);
				});
			}
		}
		foreach (_xmfdPa5IagU3cXbLL61gyoXAV7gA item3 in base._uZyXmbTsZVxXsadCzSsIs0z4xdb)
		{
			item3._CjFYKEH7Vq8U6urMqr8ixn5Z8li.ForEach(delegate(string string_0)
			{
				_wKyvqIzFCeVgn62yYXdOxlqw4In(base.Game.Content, string_0);
			});
			if (!string.IsNullOrEmpty(item3._RaPHmtsFBJiVmlc8lVytEMOT6ZA))
			{
				_wKyvqIzFCeVgn62yYXdOxlqw4In(base.Game.Content, item3._RaPHmtsFBJiVmlc8lVytEMOT6ZA);
			}
		}
		string[] array = _zBK8PXhWw9GtXK9IHkvbuvhbigE();
		if (array == null)
		{
			return;
		}
		List<_e6Sul13xByZYV3zUae0HX9fjnS> list = new List<_e6Sul13xByZYV3zUae0HX9fjnS>();
		string[] array2 = array;
		foreach (string _WPGpU4kAXTreTeMwHuTyjW07HnD in array2)
		{
			_e6Sul13xByZYV3zUae0HX9fjnS e6Sul13xByZYV3zUae0HX9fjnS = _uCN0rAUpYyEIvrweCRehrSN3Vsm.FirstOrDefault((_e6Sul13xByZYV3zUae0HX9fjnS _e6Sul13xByZYV3zUae0HX9fjnS_0) => _e6Sul13xByZYV3zUae0HX9fjnS_0.Name == _WPGpU4kAXTreTeMwHuTyjW07HnD);
			if (e6Sul13xByZYV3zUae0HX9fjnS != null)
			{
				list.Add(e6Sul13xByZYV3zUae0HX9fjnS);
				_uCN0rAUpYyEIvrweCRehrSN3Vsm.Remove(e6Sul13xByZYV3zUae0HX9fjnS);
			}
		}
		list.AddRange(_uCN0rAUpYyEIvrweCRehrSN3Vsm);
		_uCN0rAUpYyEIvrweCRehrSN3Vsm = list;
	}

	protected virtual string[] _zBK8PXhWw9GtXK9IHkvbuvhbigE()
	{
		return null;
	}

	private void _wKyvqIzFCeVgn62yYXdOxlqw4In(ContentManager content, string string_0)
	{
		Texture2D texture2D_ = content.Load<Texture2D>(Path.Combine(_cBXbsynpanoywEAm2hd5ysuf78l, string_0));
		_e6Sul13xByZYV3zUae0HX9fjnS item = new _e6Sul13xByZYV3zUae0HX9fjnS(this, string_0, texture2D_);
		_uCN0rAUpYyEIvrweCRehrSN3Vsm.Add(item);
	}

	public virtual void Draw(SpriteBatch spriteBatch)
	{
		base._gytsCM4ef57F54AqmuiBr238JE0();
		if (_YyDeMNgCbNCOMTBX2QLUb4ruMp9A)
		{
			_9jklVVcQQYcyqOYrkPiht2VP0IG.Parameters["Time"].SetValue(_boyt8NIMtKsAGSTcjHeL0WMbFxs._AmIUCcrmrrQiiirja7DoiZSjXuv);
			_9jklVVcQQYcyqOYrkPiht2VP0IG.Parameters["BreathingOffset"].SetValue(_jSsdHgef86oxWXEOENwyht1nIvn);
			_9jklVVcQQYcyqOYrkPiht2VP0IG.Parameters["BreathingSpeed"].SetValue(_ZSm5WiT2IPnq6W1i4QmcxHACwQh);
			_9jklVVcQQYcyqOYrkPiht2VP0IG.CurrentTechnique.Passes[0].Apply();
		}
		_DIJ98g9A80rhmS3Wk1l8KTVfV8x(spriteBatch);
	}

	protected void _DIJ98g9A80rhmS3Wk1l8KTVfV8x(SpriteBatch spriteBatch)
	{
		using List<_e6Sul13xByZYV3zUae0HX9fjnS>.Enumerator enumerator = _uCN0rAUpYyEIvrweCRehrSN3Vsm.GetEnumerator();
		if (enumerator.MoveNext())
		{
			_e6Sul13xByZYV3zUae0HX9fjnS current = enumerator.Current;
			current.Draw(spriteBatch, base.Scale, _IvIFs0Tl6RHdTn3daJXsNCXCNyO);
		}
	}

	protected override void SetAlpha(string string_0, float float_0)
	{
		_e6Sul13xByZYV3zUae0HX9fjnS e6Sul13xByZYV3zUae0HX9fjnS = _uCN0rAUpYyEIvrweCRehrSN3Vsm.FirstOrDefault((_e6Sul13xByZYV3zUae0HX9fjnS _e6Sul13xByZYV3zUae0HX9fjnS_0) => _e6Sul13xByZYV3zUae0HX9fjnS_0.Name == string_0);
		if (e6Sul13xByZYV3zUae0HX9fjnS != null)
		{
			e6Sul13xByZYV3zUae0HX9fjnS._WxTaPaOE8qb7d7anVlwwqCzugAo = float_0;
		}
	}

	protected override bool _BbDRof5yB0Qn864T1KJxUzMy8di(int int_0)
	{
		return true;
	}

	protected override void _PdRLTpsImBScBFQhILtCHJpcsllA(float float_0)
	{
	}

	protected override void _Hx7zLXU6nbxudxFgMuYbyRXeEPB()
	{
	}
}
