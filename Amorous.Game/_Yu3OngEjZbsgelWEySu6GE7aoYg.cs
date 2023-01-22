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
				goto IL_0029;
			}
			goto IL_0063;
			IL_0063:
			int num;
			int num2;
			if (value >= _I1ZbHemGfJWozEfpDc9aFgiZQhEb.Length)
			{
				num = -727976062;
				num2 = -727976062;
			}
			else
			{
				num = -637668600;
				num2 = -637668600;
			}
			goto IL_002e;
			IL_002e:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num ^ 0xDC4BF407u) % 6u)
				{
				case 2u:
					_3wk7bXUbhNqSQ9kMD9hieEubOhG = 0;
					num = ((int)num3 * -591149666) ^ -1547691569;
					continue;
				case 0u:
					break;
				case 3u:
					goto IL_0063;
				case 1u:
					_3wk7bXUbhNqSQ9kMD9hieEubOhG = _I1ZbHemGfJWozEfpDc9aFgiZQhEb.Length - 1;
					return;
				case 4u:
					return;
				default:
					_3wk7bXUbhNqSQ9kMD9hieEubOhG = value;
					return;
				}
				break;
			}
			goto IL_0029;
			IL_0029:
			num = -1560115231;
			goto IL_002e;
		}
	}

	public _Yu3OngEjZbsgelWEySu6GE7aoYg(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, Texture2D[] texture2D_0)
		: base(_7UlnfykmEmZDFt3BmCKZekI43Ih_0, string_0)
	{
		while (true)
		{
			int num = 961305802;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x544F5994u) % 3u)
				{
				case 1u:
					goto IL_000a;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_000a:
				_I1ZbHemGfJWozEfpDc9aFgiZQhEb = texture2D_0;
				num = (int)((num2 * 471152964) ^ 0x63865EEF);
			}
		}
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
	}

	public override void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		_Yu3OngEjZbsgelWEySu6GE7aoYg.smethod_0(spriteBatch_0, _I1ZbHemGfJWozEfpDc9aFgiZQhEb[_SWODlbUkQEqfwrtprjLPOeGF7HO], _Jh6AK28sBy2bS8ZCoKHP3LX45Uk, _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA);
	}

	public override void _ymyneWF6dfrtfUI08wyb3KExq0D()
	{
		Texture2D[] i1ZbHemGfJWozEfpDc9aFgiZQhEb = _I1ZbHemGfJWozEfpDc9aFgiZQhEb;
		int num = 0;
		Texture2D object_ = default(Texture2D);
		while (true)
		{
			int num2 = 407916041;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x2626FDA4u) % 6u)
				{
				case 3u:
				{
					int num4;
					if (num < i1ZbHemGfJWozEfpDc9aFgiZQhEb.Length)
					{
						num2 = 1835796984;
						num4 = 1835796984;
					}
					else
					{
						num2 = 796405450;
						num4 = 796405450;
					}
					continue;
				}
				case 2u:
					object_ = i1ZbHemGfJWozEfpDc9aFgiZQhEb[num];
					num2 = 1104896808;
					continue;
				case 1u:
					num2 = ((int)num3 * -1073016456) ^ -931188263;
					continue;
				case 0u:
					_Yu3OngEjZbsgelWEySu6GE7aoYg.smethod_3(_Yu3OngEjZbsgelWEySu6GE7aoYg.smethod_2(_Yu3OngEjZbsgelWEySu6GE7aoYg.smethod_1(base._XbOXR6AypLIdJ3gBMGseGi3Wi2i)), (object)object_);
					num++;
					num2 = (int)(num3 * 971680358) ^ -1741642743;
					continue;
				default:
					return;
				case 5u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	static void smethod_0(SpriteBatch spriteBatch_0, Texture2D texture2D_0, Vector2 vector2_0, Color color_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
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
