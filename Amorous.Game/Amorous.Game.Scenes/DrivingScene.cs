using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spine;

namespace Amorous.Game.Scenes;

public class DrivingScene : AbstractScene
{
	public const string VariantSunset = "Sunset";
	public const string VariantNight = "Night";
	public const string VariantDay = "Day";

	private const int Delay = 1280;
	private const float TreeOffsetModifier = 0.25f;
	private const float MiddleOffsetModifier = 0.5f;
	private const float SeniorOffsetModifier = 0.9f;

	private SpriteLayer _background;
	private SpriteLayer _middle;
	private SpriteLayer _senior;
	private readonly SpriteLayer[] _trees = new SpriteLayer[3];
	private int _tree;
	private SpriteLayer _firstTreeSprite, _secondTreeSprite;
	private float _middleOffset, _seniorOffset, _treeOffset;

	public DrivingScene(IAmorous game)
		: base(game)
	{
		SwitchToSubscene(VariantDay);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.DetectivesScoopTrack, 0.4f);
	}

	public override void SwitchToSubscene(string daytime)
	{
		base.SwitchToSubscene(daytime);
		_background = AddSpriteLayer("Background", "Assets/Scenes/Driving/" + daytime + " Background", 0, 0);
		_middle = AddSpriteLayer("Background", "Assets/Scenes/Driving/" + daytime + " Background 2", 0, 680);
		_senior = AddSpriteLayer("Background", "Assets/Scenes/Driving/" + daytime + " Foreground", 0, 0);
		_trees[0] = AddSpriteLayer("Background", "Assets/Scenes/Driving/" + daytime + " Tree A", 0, 0);
		_trees[1] = AddSpriteLayer("Background", "Assets/Scenes/Driving/" + daytime + " Tree B", 0, 0);
		_trees[2] = AddSpriteLayer("Background", "Assets/Scenes/Driving/" + daytime + " Tree C", 0, 0);
		_tree = Utils.Random(0, _trees.Length - 1);
		ComputeTrees();
		_middleOffset = Utils.Random(-1920, 0);
		_seniorOffset = Utils.Random(-1920, 0);
		_treeOffset = Utils.Random(-1920, 0);
	}

	public override void Update(GameTime gameTime)
	{
		base.Update(gameTime);
		float ticks = (float)(Delay * gameTime.ElapsedGameTime.TotalSeconds);
		_middleOffset -= ticks * TreeOffsetModifier;
		if (_middleOffset < -3840f)
		{
			_middleOffset += 3840f;
		}
		_treeOffset -= ticks * MiddleOffsetModifier;
		if (_treeOffset < -1920f)
		{
			_treeOffset = 0f;
			ComputeTrees();
		}
		_seniorOffset -= ticks * SeniorOffsetModifier;
		if (_seniorOffset < -3840f)
		{
			_seniorOffset += 3840f;
		}
	}

	private void ComputeTrees()
	{
		_firstTreeSprite = _trees[_tree];
		_tree++;
		if (_tree >= _trees.Length)
		{
			_tree = 0;
		}
		_secondTreeSprite = _trees[_tree];
		_secondTreeSprite.Flip = Utils.RandomBool();
	}

	public override void Draw(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer, Matrix matrix)
	{
		base.Draw(spriteBatch, skeletonMeshRenderer, matrix);
		spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.NonPremultiplied);
		_background.Draw(spriteBatch);
		_middle.X = _middleOffset;
		_middle.Draw(spriteBatch);
		_middle.X = _middleOffset + 1920f;
		_middle.Flip = true;
		_middle.Draw(spriteBatch);
		_middle.X = _middleOffset + 3840f;
		_middle.Flip = false;
		_middle.Draw(spriteBatch);
		_firstTreeSprite.X = _treeOffset;
		_secondTreeSprite.X = _treeOffset + 1920f;
		_firstTreeSprite.Draw(spriteBatch);
		_secondTreeSprite.Draw(spriteBatch);
		_senior.X = _seniorOffset;
		_senior.Draw(spriteBatch);
		_senior.X = _seniorOffset + 1920f;
		_senior.Flip = true;
		_senior.Draw(spriteBatch);
		_senior.X = _seniorOffset + 3840f;
		_senior.Flip = false;
		_senior.Draw(spriteBatch);
		spriteBatch.End();
	}
}
