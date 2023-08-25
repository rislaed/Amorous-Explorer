using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class CensorCheckEvent : AbstractEvent<CensorCheckEventData>
{ // _67xbcnbi3gZbItJwCGCxxdKh9WG
	public int SFWID { get; private set; }
	public int NSFWID { get; private set; }

	public CensorCheckEvent(Cutscene cutscene) : base(cutscene) {}

	public override void SetData(CensorCheckEventData eventData)
	{
		base.SetData(eventData);
		SFWID = eventData.SFWID;
		NSFWID = eventData.NSFWID;
	}

	public override void Update(GameTime gameTime)
	{
		base.IsCompleted = true;
		base.NextID = (Censorship.Censored ? SFWID : NSFWID);
	}
}
