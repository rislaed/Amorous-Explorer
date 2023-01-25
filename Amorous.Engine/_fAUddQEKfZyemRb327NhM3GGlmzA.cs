using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class _fAUddQEKfZyemRb327NhM3GGlmzA : _ujAkjlfN5TywwbLAUDzPvtab6uJ
{
	public Matrix _3TrGrUra7cqeIXkbZOrfaoQaD5F { get; set; }

	public Action<GameTime> _NC5P3SKqKPpcAYG1mqquUEcUzTg { private get; set; }

	public Action<SpriteBatch> _B6VrMlmWofCGqEzjzgFJiAliCge { private get; set; }

	public _fAUddQEKfZyemRb327NhM3GGlmzA(AbstractScene AbstractScene_0, string string_0)
		: base(AbstractScene_0, string_0)
	{
	}

	public override void Update(GameTime gameTime_0)
	{
		_NC5P3SKqKPpcAYG1mqquUEcUzTg?.Invoke(gameTime_0);
	}

	public override void Draw(SpriteBatch spriteBatch_0)
	{
		_B6VrMlmWofCGqEzjzgFJiAliCge?.Invoke(spriteBatch_0);
	}
}
