using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class _67xbcnbi3gZbItJwCGCxxdKh9WG : AbstractEvent<CensorCheckEventData>
{
	public int SFWID { get; private set; }

	public int NSFWID { get; private set; }

	public _67xbcnbi3gZbItJwCGCxxdKh9WG(_nR8eroJOHehP0ZGyyTveo6aMTHg _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
		: base(_nR8eroJOHehP0ZGyyTveo6aMTHg_0)
	{
	}

	public override void SetData(CensorCheckEventData censorCheckEventData_0)
	{
		base.SetData(censorCheckEventData_0);
		SFWID = censorCheckEventData_0.SFWID;
		NSFWID = censorCheckEventData_0.NSFWID;
	}

	public override void Update(GameTime gameTime)
	{
		base._xJZUPxDatEzfPQc0nRHR2D1Vwke = true;
		base.NextID = (_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF ? SFWID : NSFWID);
	}
}
