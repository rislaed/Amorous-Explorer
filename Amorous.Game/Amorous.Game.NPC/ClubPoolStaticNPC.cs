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
}
