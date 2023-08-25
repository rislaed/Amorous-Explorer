using Amorous.Game.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.Scenes;

public class IntroScene : AbstractScene
{
	private int ticks;
	private readonly float modifier;

	public AbstractLayer Background { get; private set; }
	public AbstractLayer Scenery { get; private set; }
	public CoupleANPC LeftCouples { get; private set; }
	public CoupleBNPC RightCouples { get; private set; }

	public IntroScene(IAmorous game) : base(game)
	{
		Background = AddSpriteLayer("Background", "Assets/Scenes/Intro/Background", 0, 0);
		Scenery = AddSpriteLayer("Scenery", "Assets/Scenes/Intro/Scenery", 0, 1250);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.TheNightSkyTrack, 0.4f);
		modifier = 1f;
	}

	public override void Start()
	{
		RightCouples = base.Game.GetNPCLayerAt<CoupleBNPC>(LayerOrder.Foreground);
		RightCouples.X = 1280f;
		RightCouples.Y = 1090f;
		RightCouples.SetPose(CoupleBNPC.EPoses.Waving);
		RightCouples.SetClothes(CoupleBNPC.EClothes.Shirt, CoupleBNPC.EClothes.Pants);
		LeftCouples = base.Game.GetNPCLayerAt<CoupleANPC>(LayerOrder.Foreground);
		LeftCouples.X = -800f;
		LeftCouples.Y = 1090f;
		LeftCouples.SetPose(CoupleANPC.EPoses.Waving);
		LeftCouples.SetClothes(CoupleANPC.EClothes.Shirt, CoupleANPC.EClothes.Pants);
	}

	public override void Update(GameTime gameTime)
	{
		base.Update(gameTime);
		ticks += gameTime.ElapsedGameTime.Milliseconds;
		SlideTo(Background, 0f, 18000f * modifier, 0, 0, 0, -540);
		SlideTo(Scenery, 10000f * modifier, 8000f * modifier, 0, 1250, 0, -170);
		MoveTo(LeftCouples, 14000f * modifier, 4000f * modifier, -800, 1090, 600, 1090);
		MoveTo(RightCouples, 14000f * modifier, 4000f * modifier, 1280, 1090, 450, 1090);
	}

	private void SlideTo(AbstractLayer layer, float from, float to, int x1, int y1, int x2, int y2)
	{
		if (!((float)ticks < from) && (float)ticks < from + to)
		{
			float amount = ((float)ticks - from) / to;
			layer.X = MathHelper.Lerp(x1, x2, amount);
			layer.Y = MathHelper.Lerp(y1, y2, amount);
		}
	}

	private void MoveTo(AbstractSpineNPC npc, float from, float to, int x1, int y1, int x2, int y2)
	{
		if (!((float)ticks < from) && (float)ticks < from + to)
		{
			float amount = ((float)ticks - from) / to;
			npc.X = MathHelper.Lerp(x1, x2, amount);
			npc.Y = MathHelper.Lerp(y1, y2, amount);
		}
	}
}
