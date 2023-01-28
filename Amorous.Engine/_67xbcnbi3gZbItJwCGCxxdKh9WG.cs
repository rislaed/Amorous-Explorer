using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class _67xbcnbi3gZbItJwCGCxxdKh9WG : AbstractEvent<CensorCheckEventData>
{
	public int SFWID { get; private set; }

	public int NSFWID { get; private set; }

	public _67xbcnbi3gZbItJwCGCxxdKh9WG(Cutscene _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
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
		base.Completable = true;
		base.NextID = (Censorship.Censored ? SFWID : NSFWID);
	}
}
