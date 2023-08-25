namespace Amorous.Game.Scenes;

public class CoffeeShopScene : AbstractScene
{
	public const string VARIANT_JAX = "Jax";
	public const string VARIANT_SETH = "Seth";
	public const string VARIANT_NONE = "Default";

	private readonly SpriteLayer jaxOverlay;
	private readonly SpriteLayer sethOverlay;
	private readonly SpriteLayer noneOverlay;

	public CoffeeShopScene(IAmorous game) : base(game)
	{
		AddSpriteLayer("Background", "Assets/Scenes/CoffeeShop/Background", 0, 0);
		jaxOverlay = AddSpriteLayerAbove("Background", "Assets/Scenes/CoffeeShop/Jax coffee", 0, 0);
		sethOverlay = AddSpriteLayerAbove("Background", "Assets/Scenes/CoffeeShop/Seth coffee", 0, 0);
		noneOverlay = AddSpriteLayerAbove("Background", "Assets/Scenes/CoffeeShop/Remy coffee", 0, 0);
		SwitchToSubscene(VARIANT_NONE);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.OMorroNaoTemVezTrack, 0.4f);
	}

	public override void SwitchToSubscene(string subscene)
	{
		base.SwitchToSubscene(subscene);
		jaxOverlay.Visible = false;
		sethOverlay.Visible = false;
		noneOverlay.Visible = false;
		if (!(subscene == VARIANT_JAX))
		{
			if (!(subscene == VARIANT_SETH))
			{
				noneOverlay.Visible = true;
			}
			else
			{
				sethOverlay.Visible = true;
			}
		}
		else
		{
			jaxOverlay.Visible = true;
		}
	}
}
