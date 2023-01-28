using System;

namespace Amorous.Game.NPC;

public class JaxRedNPC : JaxNPC
{
	public JaxRedNPC(IAmorous game)
		: base(game, "Assets/NPC/JaxRed/Jax")
	{
		base.Variations = new Type[2]
		{
			typeof(JaxNPC),
			typeof(JaxPurpleNPC)
		};
	}
}
