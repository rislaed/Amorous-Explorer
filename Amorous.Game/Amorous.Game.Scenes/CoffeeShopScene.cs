namespace Amorous.Game.Scenes;

public class CoffeeShopScene : AbstractScene
{
	public const string VariantJax = "Jax";
	public const string VariantSeth = "Seth";
	public const string VariantNone = "Default";

	private readonly SpriteLayer _backgroundJax;
	private readonly SpriteLayer _backgroundSeth;
	private readonly SpriteLayer _backgroundNone;

	public CoffeeShopScene(IAmorous game)
		: base(game)
	{
		AddSpriteLayer("Background", "Assets/Scenes/CoffeeShop/Background", 0, 0);
		_backgroundJax = AddForegroundSpriteLayer("Background", "Assets/Scenes/CoffeeShop/Jax coffee", 0, 0);
		_backgroundSeth = AddForegroundSpriteLayer("Background", "Assets/Scenes/CoffeeShop/Seth coffee", 0, 0);
		_backgroundNone = AddForegroundSpriteLayer("Background", "Assets/Scenes/CoffeeShop/Remy coffee", 0, 0);
		SwitchToSubscene(VariantNone);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.OMorroNaoTemVezTrack, 0.4f);
	}

	public override void SwitchToSubscene(string subscene)
	{
		base.SwitchToSubscene(subscene);
		_backgroundJax.Visible = false;
		_backgroundSeth.Visible = false;
		_backgroundNone.Visible = false;
		if (!(subscene == VariantJax))
		{
			if (!(subscene == VariantSeth))
			{
				_backgroundNone.Visible = true;
			}
			else
			{
				_backgroundSeth.Visible = true;
			}
		}
		else
		{
			_backgroundJax.Visible = true;
		}
	}
}
