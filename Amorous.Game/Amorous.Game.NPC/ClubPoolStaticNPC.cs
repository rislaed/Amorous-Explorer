using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Amorous.Game.NPC;

public abstract class ClubPoolStaticNPC : ClubStaticNPC
{
	public float _qFVIvzuvIuKKG5vOrovLtn4NplA = ClubPoolStaticNPC.smethod_19(-1f, 1f);

	public float _rlJEdnItzlU5efWtBjMCaC5Nizb;

	private readonly Effect _2dDfDHYjKMlOJWKHdOpvafF417M;

	private readonly Texture2D _za9QLzJUpOFmy4hIqyTdGh34IpD;

	protected bool _vAix6GBEcVh3peB11tbKy7HJWwb { get; set; }

	protected ClubPoolStaticNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, string string_0, string string_1, bool bool_0, bool bool_1)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, string_0, string_1, bool_0, bool_1)
	{
		_2dDfDHYjKMlOJWKHdOpvafF417M = ClubPoolStaticNPC.smethod_21(ClubPoolStaticNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this)).Load<Effect>("Assets/Shaders/Pool");
		_za9QLzJUpOFmy4hIqyTdGh34IpD = ClubPoolStaticNPC.smethod_21(ClubPoolStaticNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this)).Load<Texture2D>("Assets/Scenes/ClubPool/Wave Mask");
	}

	public override void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0)
	{
		float num = _rlJEdnItzlU5efWtBjMCaC5Nizb + (float)ClubPoolStaticNPC.smethod_22(_za9QLzJUpOFmy4hIqyTdGh34IpD);
		while (true)
		{
			int num2 = 537984139;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x248E8834u) % 9u)
				{
				case 8u:
					ClubPoolStaticNPC.smethod_25(ClubPoolStaticNPC.smethod_24(ClubPoolStaticNPC.smethod_23(_2dDfDHYjKMlOJWKHdOpvafF417M), "MaskStart"), _rlJEdnItzlU5efWtBjMCaC5Nizb / (float)ClubPoolStaticNPC.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this));
					num2 = ((int)num3 * -1411779134) ^ 0xEE2CE89;
					continue;
				case 6u:
					ClubPoolStaticNPC.smethod_25(ClubPoolStaticNPC.smethod_24(ClubPoolStaticNPC.smethod_23(_2dDfDHYjKMlOJWKHdOpvafF417M), "BreathingOffset"), _jSsdHgef86oxWXEOENwyht1nIvn);
					num2 = (int)((num3 * 1725210380) ^ 0x63D60B7);
					continue;
				case 5u:
					ClubPoolStaticNPC.smethod_26(ClubPoolStaticNPC.smethod_24(ClubPoolStaticNPC.smethod_23(_2dDfDHYjKMlOJWKHdOpvafF417M), "MaskTexture"), (Texture)(object)_za9QLzJUpOFmy4hIqyTdGh34IpD);
					num2 = ((int)num3 * -1538155490) ^ -1817108397;
					continue;
				case 4u:
					ClubPoolStaticNPC.smethod_32(ClubPoolStaticNPC.smethod_31(ClubPoolStaticNPC.smethod_30(ClubPoolStaticNPC.smethod_29(_2dDfDHYjKMlOJWKHdOpvafF417M)), 0));
					num2 = ((int)num3 * -1004809215) ^ -2075483750;
					continue;
				case 2u:
					ClubPoolStaticNPC.smethod_25(ClubPoolStaticNPC.smethod_24(ClubPoolStaticNPC.smethod_23(_2dDfDHYjKMlOJWKHdOpvafF417M), "MaskEnd"), num / (float)ClubPoolStaticNPC.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this));
					ClubPoolStaticNPC.smethod_28(ClubPoolStaticNPC.smethod_24(ClubPoolStaticNPC.smethod_23(_2dDfDHYjKMlOJWKHdOpvafF417M), "Inverse"), _vAix6GBEcVh3peB11tbKy7HJWwb);
					num2 = (int)(num3 * 1787211690) ^ -295433786;
					continue;
				case 1u:
					ClubPoolStaticNPC.smethod_25(ClubPoolStaticNPC.smethod_24(ClubPoolStaticNPC.smethod_23(_2dDfDHYjKMlOJWKHdOpvafF417M), "Time"), _boyt8NIMtKsAGSTcjHeL0WMbFxs._AmIUCcrmrrQiiirja7DoiZSjXuv);
					ClubPoolStaticNPC.smethod_25(ClubPoolStaticNPC.smethod_24(ClubPoolStaticNPC.smethod_23(_2dDfDHYjKMlOJWKHdOpvafF417M), "PoolSpeed"), 0.1f);
					ClubPoolStaticNPC.smethod_25(ClubPoolStaticNPC.smethod_24(ClubPoolStaticNPC.smethod_23(_2dDfDHYjKMlOJWKHdOpvafF417M), "PoolOffset"), _qFVIvzuvIuKKG5vOrovLtn4NplA);
					num2 = ((int)num3 * -598718272) ^ -1213640465;
					continue;
				case 0u:
					_DIJ98g9A80rhmS3Wk1l8KTVfV8x(spriteBatch_0);
					num2 = ((int)num3 * -1260159437) ^ 0x3E5A06C0;
					continue;
				default:
					return;
				case 7u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	static float smethod_19(float float_0, float float_1)
	{
		return _boyt8NIMtKsAGSTcjHeL0WMbFxs._S7DdtNZASTkc9riB27h5Ktq5VjDA(float_0, float_1);
	}

	static _JbeCmOie0phb2cbgG6DdGZrbs3pB smethod_20(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0)
	{
		return _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._ZzBuoSDMWwerejOO9Goyv2OCKgE;
	}

	static ContentManager smethod_21(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8;
	}

	static int smethod_22(Texture2D texture2D_0)
	{
		return texture2D_0.get_Height();
	}

	static EffectParameterCollection smethod_23(Effect effect_0)
	{
		return effect_0.get_Parameters();
	}

	static EffectParameter smethod_24(EffectParameterCollection effectParameterCollection_0, string string_0)
	{
		return effectParameterCollection_0.get_Item(string_0);
	}

	static void smethod_25(EffectParameter effectParameter_0, float float_0)
	{
		effectParameter_0.SetValue(float_0);
	}

	static void smethod_26(EffectParameter effectParameter_0, Texture texture_0)
	{
		effectParameter_0.SetValue(texture_0);
	}

	static int smethod_27(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0)
	{
		return _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._WJfGWBzn4wgdGBnMWRH2pcJ3AqH;
	}

	static void smethod_28(EffectParameter effectParameter_0, bool bool_0)
	{
		effectParameter_0.SetValue(bool_0);
	}

	static EffectTechnique smethod_29(Effect effect_0)
	{
		return effect_0.get_CurrentTechnique();
	}

	static EffectPassCollection smethod_30(EffectTechnique effectTechnique_0)
	{
		return effectTechnique_0.get_Passes();
	}

	static EffectPass smethod_31(EffectPassCollection effectPassCollection_0, int int_0)
	{
		return effectPassCollection_0.get_Item(int_0);
	}

	static void smethod_32(EffectPass effectPass_0)
	{
		effectPass_0.Apply();
	}
}
