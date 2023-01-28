using System;

namespace Amorous.Game.NPC;

public class JaxPurpleNPC : JaxNPC
{
	public JaxPurpleNPC(IAmorous game)
		: base(game, "Assets/NPC/JaxPurple/Jax")
	{
		base.Variations = new Type[2]
		{
			typeof(JaxNPC),
			typeof(JaxRedNPC)
		};
	}
}
