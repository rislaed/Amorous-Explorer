using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spine;

namespace Amorous.Game.Scenes;

public class DrivingScene : AbstractScene
{
	public const string VARIANT_SUNSET = "Sunset";
	public const string VARIANT_NIGHT = "Night";
	public const string VARIANT_DAY = "Day";

	private const int DELAY = 1280;
	private const float TREE_SPEED = 0.25f;
	private const float OVERLAY_SPEED = 0.5f;
	private const float FOREGROUND_SPEED = 0.9f;

	private SpriteLayer background;
	private SpriteLayer overlay;
	private SpriteLayer foreground;
	private readonly SpriteLayer[] trees = new SpriteLayer[3];
	private int indexOfTree;
	private SpriteLayer leftTree, rightTree;
	private float overlayOffset, foregroundOffset, treeOffset;

	public DrivingScene(IAmorous game) : base(game)
	{
		SwitchToSubscene(VARIANT_DAY);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.DetectivesScoopTrack, 0.4f);
	}

	public override void SwitchToSubscene(string daytime)
	{
		base.SwitchToSubscene(daytime);
		background = AddSpriteLayer("Background", "Assets/Scenes/Driving/" + daytime + " Background", 0, 0);
		overlay = AddSpriteLayer("Background", "Assets/Scenes/Driving/" + daytime + " Background 2", 0, 680);
		foreground = AddSpriteLayer("Background", "Assets/Scenes/Driving/" + daytime + " Foreground", 0, 0);
		trees[0] = AddSpriteLayer("Background", "Assets/Scenes/Driving/" + daytime + " Tree A", 0, 0);
		trees[1] = AddSpriteLayer("Background", "Assets/Scenes/Driving/" + daytime + " Tree B", 0, 0);
		trees[2] = AddSpriteLayer("Background", "Assets/Scenes/Driving/" + daytime + " Tree C", 0, 0);
		indexOfTree = Utils.Random(0, trees.Length - 1);
		ComputeTrees();
		overlayOffset = Utils.Random(-1920, 0);
		foregroundOffset = Utils.Random(-1920, 0);
		treeOffset = Utils.Random(-1920, 0);
	}

	public override void Update(GameTime gameTime)
	{
		base.Update(gameTime);
		float ticks = (float)(DELAY * gameTime.ElapsedGameTime.TotalSeconds);
		overlayOffset -= ticks * TREE_SPEED;
		if (overlayOffset < -3840f)
		{
			overlayOffset += 3840f;
		}
		treeOffset -= ticks * OVERLAY_SPEED;
		if (treeOffset < -1920f)
		{
			treeOffset = 0f;
			ComputeTrees();
		}
		foregroundOffset -= ticks * FOREGROUND_SPEED;
		if (foregroundOffset < -3840f)
		{
			foregroundOffset += 3840f;
		}
	}

	private void ComputeTrees()
	{
		leftTree = trees[indexOfTree];
		indexOfTree++;
		if (indexOfTree >= trees.Length)
		{
			indexOfTree = 0;
		}
		rightTree = trees[indexOfTree];
		rightTree.Flip = Utils.RandomBool();
	}

	public override void Draw(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer, Matrix matrix)
	{
		base.Draw(spriteBatch, skeletonMeshRenderer, matrix);
		spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.NonPremultiplied);
		background.Draw(spriteBatch);
		overlay.X = overlayOffset;
		overlay.Draw(spriteBatch);
		overlay.X = overlayOffset + 1920f;
		overlay.Flip = true;
		overlay.Draw(spriteBatch);
		overlay.X = overlayOffset + 3840f;
		overlay.Flip = false;
		overlay.Draw(spriteBatch);
		leftTree.X = treeOffset;
		rightTree.X = treeOffset + 1920f;
		leftTree.Draw(spriteBatch);
		rightTree.Draw(spriteBatch);
		foreground.X = foregroundOffset;
		foreground.Draw(spriteBatch);
		foreground.X = foregroundOffset + 1920f;
		foreground.Flip = true;
		foreground.Draw(spriteBatch);
		foreground.X = foregroundOffset + 3840f;
		foreground.Flip = false;
		foreground.Draw(spriteBatch);
		spriteBatch.End();
	}
}
