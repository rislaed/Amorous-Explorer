using System;
using Microsoft.Xna.Framework.Graphics;

namespace Amorous.Game.NPC;

public class SkyeBlueNPC : SkyeNPC
{
	public SkyeBlueNPC(IAmorous game) : base(game)
	{
		base.Texture = base.Game.Content.Load<Texture2D>("Assets/NPC/Skye/skye expressions (Blue)");
		base.Variations = new Type[2]
		{
			typeof(SkyeNPC),
			typeof(SkyeGrayNPC)
		};
	}
}
