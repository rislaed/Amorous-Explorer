using System;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Amorous.Game.NPC;

public class SkyeBlueNPC : SkyeNPC
{
	public SkyeBlueNPC(IAmorous game)
		: base(Game)
	{
		base._1AqpgY4vB6ly5vxOay6j86rcIEo = base.Game._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/NPC/Skye/skye expressions (Blue)");
		base._rAt6TRbgK04lvrs5QPjcd0n26pk = new Type[2]
		{
			typeof(SkyeNPC),
			typeof(SkyeGrayNPC)
		};
	}
}
