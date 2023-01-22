using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Amorous.Game.NPC;

public abstract class ClubPoolStaticNPC : ClubStaticNPC
{
	public float _qFVIvzuvIuKKG5vOrovLtn4NplA = _boyt8NIMtKsAGSTcjHeL0WMbFxs._S7DdtNZASTkc9riB27h5Ktq5VjDA(-1f, 1f);

	public float _rlJEdnItzlU5efWtBjMCaC5Nizb;

	private readonly Effect _2dDfDHYjKMlOJWKHdOpvafF417M;

	private readonly Texture2D _za9QLzJUpOFmy4hIqyTdGh34IpD;

	protected bool _vAix6GBEcVh3peB11tbKy7HJWwb { get; set; }

	protected ClubPoolStaticNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, string string_0, string string_1, bool bool_0, bool bool_1)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, string_0, string_1, bool_0, bool_1)
	{
		_2dDfDHYjKMlOJWKHdOpvafF417M = base._ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Effect>("Assets/Shaders/Pool");
		_za9QLzJUpOFmy4hIqyTdGh34IpD = base._ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/Scenes/ClubPool/Wave Mask");
	}

	public override void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0)
	{
		float num = _rlJEdnItzlU5efWtBjMCaC5Nizb + (float)_za9QLzJUpOFmy4hIqyTdGh34IpD.Height;
		_2dDfDHYjKMlOJWKHdOpvafF417M.Parameters["Time"].SetValue(_boyt8NIMtKsAGSTcjHeL0WMbFxs._AmIUCcrmrrQiiirja7DoiZSjXuv);
		_2dDfDHYjKMlOJWKHdOpvafF417M.Parameters["PoolSpeed"].SetValue(0.1f);
		_2dDfDHYjKMlOJWKHdOpvafF417M.Parameters["PoolOffset"].SetValue(_qFVIvzuvIuKKG5vOrovLtn4NplA);
		_2dDfDHYjKMlOJWKHdOpvafF417M.Parameters["MaskTexture"].SetValue(_za9QLzJUpOFmy4hIqyTdGh34IpD);
		_2dDfDHYjKMlOJWKHdOpvafF417M.Parameters["MaskStart"].SetValue(_rlJEdnItzlU5efWtBjMCaC5Nizb / (float)_WJfGWBzn4wgdGBnMWRH2pcJ3AqH);
		_2dDfDHYjKMlOJWKHdOpvafF417M.Parameters["MaskEnd"].SetValue(num / (float)_WJfGWBzn4wgdGBnMWRH2pcJ3AqH);
		_2dDfDHYjKMlOJWKHdOpvafF417M.Parameters["Inverse"].SetValue(_vAix6GBEcVh3peB11tbKy7HJWwb);
		_2dDfDHYjKMlOJWKHdOpvafF417M.Parameters["BreathingOffset"].SetValue(_jSsdHgef86oxWXEOENwyht1nIvn);
		_2dDfDHYjKMlOJWKHdOpvafF417M.CurrentTechnique.Passes[0].Apply();
		_DIJ98g9A80rhmS3Wk1l8KTVfV8x(spriteBatch_0);
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
		return texture2D_0.Height;
	}

	static EffectParameterCollection smethod_23(Effect effect_0)
	{
		return effect_0.Parameters;
	}

	static EffectParameter smethod_24(EffectParameterCollection effectParameterCollection_0, string string_0)
	{
		return effectParameterCollection_0[string_0];
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
		return effect_0.CurrentTechnique;
	}

	static EffectPassCollection smethod_30(EffectTechnique effectTechnique_0)
	{
		return effectTechnique_0.Passes;
	}

	static EffectPass smethod_31(EffectPassCollection effectPassCollection_0, int int_0)
	{
		return effectPassCollection_0[int_0];
	}

	static void smethod_32(EffectPass effectPass_0)
	{
		effectPass_0.Apply();
	}
}
