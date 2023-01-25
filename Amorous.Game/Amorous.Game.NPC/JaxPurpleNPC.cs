using System;

namespace Amorous.Game.NPC;

public class JaxPurpleNPC : JaxNPC
{
	public JaxPurpleNPC(IAmorous game)
		: base(Game, "Assets/NPC/JaxPurple/Jax")
	{
		base._rAt6TRbgK04lvrs5QPjcd0n26pk = new Type[2]
		{
			typeof(JaxNPC),
			typeof(JaxRedNPC)
		};
	}
}
