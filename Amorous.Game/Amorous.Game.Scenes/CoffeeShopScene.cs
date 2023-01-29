namespace Amorous.Game.Scenes;

public class CoffeeShopScene : AbstractScene
{
	public const string VariantJax = "Jax";
	public const string VariantSeth = "Seth";
	public const string VariantNone = "Default";

	private readonly TexturedLayer BackgroundJax;
	private readonly TexturedLayer BackgroundSeth;
	private readonly TexturedLayer BackgroundNone;

	public CoffeeShopScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/CoffeeShop/Background", 0, 0);
		BackgroundJax = AddForegroundTexturedLayer("Background", "Assets/Scenes/CoffeeShop/Jax coffee", 0, 0);
		BackgroundSeth = AddForegroundTexturedLayer("Background", "Assets/Scenes/CoffeeShop/Seth coffee", 0, 0);
		BackgroundNone = AddForegroundTexturedLayer("Background", "Assets/Scenes/CoffeeShop/Remy coffee", 0, 0);
		SwitchToSubscene(VariantNone);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.OMorroNaoTemVezTrack, 0.4f);
	}

	public override void SwitchToSubscene(string subscene)
	{
		base.SwitchToSubscene(subscene);
		BackgroundJax.Visible = false;
		BackgroundSeth.Visible = false;
		BackgroundNone.Visible = false;
		if (!(subscene == VariantJax))
		{
			if (!(subscene == VariantSeth))
			{
				BackgroundNone.Visible = true;
			}
			else
			{
				BackgroundSeth.Visible = true;
			}
		}
		else
		{
			BackgroundJax.Visible = true;
		}
	}
}
