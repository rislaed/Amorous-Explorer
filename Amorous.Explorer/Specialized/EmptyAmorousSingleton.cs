using Amorous.Game.Scenes;
using Microsoft.Xna.Framework;

namespace Amorous.Explorer;

public class EmptyAmorousSingleton : AmorousSingleton
{
	public EmptyAmorousSingleton(Microsoft.Xna.Framework.Game game, bool safemode)
		: base(game, safemode) {}

	protected override void Start()
	{
		SwitchToScene<EmptyScene>(() => Fader.FadeIn());
		Fader.ApplyWithoutFading(new Color(0, 0, 0, 255));
	}
}
