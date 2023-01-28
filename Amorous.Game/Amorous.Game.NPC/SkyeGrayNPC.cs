using System;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Amorous.Game.NPC;

public class SkyeGrayNPC : SkyeNPC
{
	public SkyeGrayNPC(IAmorous game)
		: base(game)
	{
		base.Skin = base.Game.Content.Load<Texture2D>("Assets/NPC/Skye/skye expressions (Gray)");
		base.Variations = new Type[2]
		{
			typeof(SkyeNPC),
			typeof(SkyeBlueNPC)
		};
	}
}
