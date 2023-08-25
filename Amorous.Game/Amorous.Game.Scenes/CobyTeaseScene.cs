using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spine;

namespace Amorous.Game.Scenes;

public class CobyTeaseScene : AbstractScene
{
	public const string VARIANT_PANTIES = "Panties";
	public const string VARIANT_TEASE = "Default";

	private readonly SkeletonRenderer skeleton;

	public CobyTeaseScene(IAmorous game) : base(game)
	{
		skeleton = Game.Content.LoadSkeleton("Assets/Scenes/CobyTease/Coby buttshake Teasel");
		SwitchToSubscene(VARIANT_PANTIES);
		skeleton.SetVisibility(1f);
		skeleton.StartAnimationWithLooping("animation");
		skeleton.X = 985f;
		skeleton.Y = 1081f;
		FadingMediaPlayer.PlayOnRepeat(AmorousData.SunFunkTrack, 0.4f);
	}

	public override void SwitchToSubscene(string subscene)
	{
		base.SwitchToSubscene(subscene);
		if (subscene == VARIANT_PANTIES)
		{
			skeleton.SetSkin(VARIANT_PANTIES);
		}
		else
		{
			skeleton.SetSkin("default");
		}
	}

	public override void Update(GameTime gameTime)
	{
		base.Update(gameTime);
		skeleton.Update(gameTime, 1500f);
	}

	public override void Draw(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer, Matrix matrix)
	{
		base.Draw(spriteBatch, skeletonMeshRenderer, matrix);
		skeleton.Draw(skeletonMeshRenderer);
	}
}
