using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spine;

namespace Amorous.Game.Scenes;

public class CobyTeaseScene : AbstractScene
{
	public const string VariantPanties = "Panties";
	public const string VariantTease = "Default";

	private readonly SpineRenderer _spine;

	public CobyTeaseScene(IAmorous game)
		: base(game)
	{
		_spine = Game.Content.LoadSkeleton("Assets/Scenes/CobyTease/Coby buttshake Teasel");
		SwitchToSubscene(VariantPanties);
		_spine.SetVisibility(1f);
		_spine.StartAnimationWithLooping("animation");
		_spine.X = 985f;
		_spine.Y = 1081f;
		FadingMediaPlayer.PlayOnRepeat(AmorousData.SunFunkTrack, 0.4f);
	}

	public override void SwitchToSubscene(string subscene)
	{
		base.SwitchToSubscene(subscene);
		if (subscene == VariantPanties)
		{
			_spine.SetSkin(VariantPanties);
		}
		else
		{
			_spine.SetSkin("default");
		}
	}

	public override void Update(GameTime gameTime)
	{
		base.Update(gameTime);
		_spine.Update(gameTime, 1500f);
	}

	public override void Draw(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer, Matrix matrix)
	{
		base.Draw(spriteBatch, skeletonMeshRenderer, matrix);
		_spine.Draw(skeletonMeshRenderer);
	}
}
