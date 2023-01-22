using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

public class _Yu3OngEjZbsgelWEySu6GE7aoYg : _ujAkjlfN5TywwbLAUDzPvtab6uJ
{
	private int _3wk7bXUbhNqSQ9kMD9hieEubOhG;

	public Texture2D[] _I1ZbHemGfJWozEfpDc9aFgiZQhEb { get; private set; }

	public int _SWODlbUkQEqfwrtprjLPOeGF7HO
	{
		get
		{
			return _3wk7bXUbhNqSQ9kMD9hieEubOhG;
		}
		set
		{
			if (value < 0)
			{
				_3wk7bXUbhNqSQ9kMD9hieEubOhG = 0;
			}
			else if (value < _I1ZbHemGfJWozEfpDc9aFgiZQhEb.Length)
			{
				_3wk7bXUbhNqSQ9kMD9hieEubOhG = value;
			}
			else
			{
				_3wk7bXUbhNqSQ9kMD9hieEubOhG = _I1ZbHemGfJWozEfpDc9aFgiZQhEb.Length - 1;
			}
		}
	}

	public _Yu3OngEjZbsgelWEySu6GE7aoYg(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, Texture2D[] texture2D_0)
		: base(_7UlnfykmEmZDFt3BmCKZekI43Ih_0, string_0)
	{
		_I1ZbHemGfJWozEfpDc9aFgiZQhEb = texture2D_0;
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
	}

	public override void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0)
	{
		spriteBatch_0.Draw(_I1ZbHemGfJWozEfpDc9aFgiZQhEb[_SWODlbUkQEqfwrtprjLPOeGF7HO], _Jh6AK28sBy2bS8ZCoKHP3LX45Uk, _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA);
	}

	public override void _ymyneWF6dfrtfUI08wyb3KExq0D()
	{
		Texture2D[] i1ZbHemGfJWozEfpDc9aFgiZQhEb = _I1ZbHemGfJWozEfpDc9aFgiZQhEb;
		foreach (Texture2D object_ in i1ZbHemGfJWozEfpDc9aFgiZQhEb)
		{
			base._XbOXR6AypLIdJ3gBMGseGi3Wi2i._ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8._HXLRmt9GqcmA9GTG5xzRKNu3QpF(object_);
		}
	}

	static void smethod_0(SpriteBatch spriteBatch_0, Texture2D texture2D_0, Vector2 vector2_0, Color color_0)
	{
		spriteBatch_0.Draw(texture2D_0, vector2_0, color_0);
	}

	static _JbeCmOie0phb2cbgG6DdGZrbs3pB smethod_1(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._ZzBuoSDMWwerejOO9Goyv2OCKgE;
	}

	static ContentManager smethod_2(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8;
	}

	static void smethod_3(ContentManager contentManager_0, object object_0)
	{
		contentManager_0._HXLRmt9GqcmA9GTG5xzRKNu3QpF(object_0);
	}
}
