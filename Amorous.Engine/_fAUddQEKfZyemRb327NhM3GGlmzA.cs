using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class _fAUddQEKfZyemRb327NhM3GGlmzA : AbstractLayer
{
	public Matrix _3TrGrUra7cqeIXkbZOrfaoQaD5F { get; set; }

	public Action<GameTime> _NC5P3SKqKPpcAYG1mqquUEcUzTg { private get; set; }

	public Action<SpriteBatch> _B6VrMlmWofCGqEzjzgFJiAliCge { private get; set; }

	public _fAUddQEKfZyemRb327NhM3GGlmzA(AbstractScene scene, string string_0)
		: base(scene, string_0)
	{
	}

	public override void Update(GameTime gameTime)
	{
		_NC5P3SKqKPpcAYG1mqquUEcUzTg?.Invoke(gameTime);
	}

	public override void Draw(SpriteBatch spriteBatch)
	{
		_B6VrMlmWofCGqEzjzgFJiAliCge?.Invoke(spriteBatch);
	}
}
