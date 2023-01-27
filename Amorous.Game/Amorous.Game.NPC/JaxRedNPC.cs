using System;

namespace Amorous.Game.NPC;

public class JaxRedNPC : JaxNPC
{
	public JaxRedNPC(IAmorous game)
		: base(game, "Assets/NPC/JaxRed/Jax")
	{
		base._rAt6TRbgK04lvrs5QPjcd0n26pk = new Type[2]
		{
			typeof(JaxNPC),
			typeof(JaxPurpleNPC)
		};
	}
}
