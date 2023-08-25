using System.Collections.Generic;
using System.Linq;
using Amorous.Game.NPC;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Amorous.Game.Scenes;

public class ClubPoolScene : AbstractScene
{
	private class FrameAnimationLayer : DrawableLayer
	{
		private readonly Texture2D texture;
		private Rectangle destinationRectangle;
		private Rectangle sourceRectangle;
		private readonly Vector2 origin;
		private readonly float ticksPerFrame;
		private readonly int numberOfFrames;
		private int currentFrame;
		private float rotation;
		private float ticks;

		public FrameAnimationLayer(AbstractScene scene, string texture, float time, int frames, int dx, int dy, float scale)
			: base(scene, "FrameAnimationLayer")
		{
			this.texture = scene.Game.Content.Load<Texture2D>(texture);
			ticksPerFrame = time / (float)frames;
			numberOfFrames = frames;
			currentFrame = 0;
            sourceRectangle = new Rectangle(0, 0, (int)((float)this.texture.Width / (float)frames), this.texture.Height);
			destinationRectangle = new Rectangle(0, 0, (int)((float)sourceRectangle.Width * scale), (int)((float)sourceRectangle.Height * scale));
			origin = new Vector2(dx, dy);
			base.OnUpdate = delegate(GameTime time)
			{
				MyUpdate((float)time.ElapsedGameTime.Milliseconds / 1000f);
			};
			base.OnDraw = MyDraw;
		}

		public void Play(int x, int y, int startFrame, float angle)
		{
			destinationRectangle.X = x;
			destinationRectangle.Y = y;
			currentFrame = startFrame;
			rotation = MathHelper.ToRadians(angle);
		}

		private void MyUpdate(float deltaTime)
		{
			if (currentFrame >= 0)
			{
				ticks += deltaTime;
				while (ticks > ticksPerFrame)
				{
					ticks -= ticksPerFrame;
					currentFrame++;
				}
				if (currentFrame < numberOfFrames)
				{
					sourceRectangle.X = currentFrame * sourceRectangle.Width;
				}
				else
				{
					currentFrame = 0;
				}
			}
		}

		private void MyDraw(SpriteBatch spriteBatch)
		{
			if (currentFrame >= 0)
			{
				spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, base.Matrix);
				spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White, rotation, origin, SpriteEffects.None, 0f);
				spriteBatch.End();
			}
		}
	}

	private ClubStaticRemyNPC remy;
	private readonly bool showRemy;

	public ClubPoolScene(IAmorous game) : base(game)
	{
		AddSpriteLayer("Background", "Assets/Scenes/ClubPool/Club Pool main", -1677, 0);
		AddClickableLayer("Door", "Assets/Scenes/ClubPool/Pool door selectable", -691, 0, OnDoorClick);
		ClubPoolSpineLayer poolLayer = new ClubPoolSpineLayer(this)
		{
			OffsetX = 1525f,
			OffsetY = 890f
		};
		AddLayer(poolLayer, 2);
		FrameAnimationLayer showerLeftLayer = new FrameAnimationLayer(this, "Assets/Scenes/ClubPool/ShowerParticle", 0.5f, 5, 200, 30, 1.5f);
		showerLeftLayer.Play(-1420, 200, 0, 10f);
		FrameAnimationLayer showerRightLayer = new FrameAnimationLayer(this, "Assets/Scenes/ClubPool/ShowerParticle", 0.5f, 5, 200, 30, 1.5f);
		showerRightLayer.Play(-1170, 200, 2, 10f);
		AddLayer(showerLeftLayer, 2);
		AddLayer(showerRightLayer, 2);
		AddSpriteLayerAbove("Foreground", "Assets/Scenes/ClubPool/Club Pool top", -1677, 0);
		AddSpriteLayerAbove("Foreground", "Assets/Scenes/ClubPool/Club Pool railing", 2041, 351);
		Game.Canvas.SetOverscroll(-1677, 1677, 0, 0);
		FadingMediaPlayer.Play(AmorousData.ClubTracks, 0.4f, repeat: true, oneOf: true);
		PlayerData data = PlayerPreferences.GetPlayerData();
		showRemy = !data.HasFlag(AmorousData.RemyLeftClub);
		if (showRemy)
		{
			AddSpriteLayer("Shadow", "Assets/Scenes/ClubPool/ShadowRemy", 995, 517);
		}
	}

	public override void Start()
	{
		base.Start();
		ClubPoolStaticANPC clubPoolStaticANPC = base.Game.GetNPCLayerAt<ClubPoolStaticANPC>(LayerOrder.Background);
		clubPoolStaticANPC.X = -1400f;
		clubPoolStaticANPC.Y = 910f;
		ClubPoolStaticBNPC clubPoolStaticBNPC = base.Game.GetNPCLayerAt<ClubPoolStaticBNPC>(LayerOrder.Background);
		clubPoolStaticBNPC.X = -1401f;
		clubPoolStaticBNPC.Y = 230f;
		ClubPoolStaticENPC clubPoolStaticENPC = base.Game.GetNPCLayerAt<ClubPoolStaticENPC>(LayerOrder.Background);
		clubPoolStaticENPC.X = 106f;
		clubPoolStaticENPC.Y = 397f;
		ClubPoolStaticCNPC clubPoolStaticCNPC = base.Game.GetNPCLayerAt<ClubPoolStaticCNPC>(LayerOrder.Foreground);
		clubPoolStaticCNPC.X = -180f;
		clubPoolStaticCNPC.Y = 450f;
		ClubPoolStaticCNPC2 clubPoolStaticCNPC2 = base.Game.GetNPCLayerAt<ClubPoolStaticCNPC2>(LayerOrder.Background);
		clubPoolStaticCNPC2.PoolOffset = clubPoolStaticCNPC.PoolOffset;
		clubPoolStaticCNPC2.X = clubPoolStaticCNPC.X;
		clubPoolStaticCNPC2.Y = clubPoolStaticCNPC.Y;
		ClubPoolStaticFNPC clubPoolStaticFNPC = base.Game.GetNPCLayerAt<ClubPoolStaticFNPC>(LayerOrder.Foreground);
		clubPoolStaticFNPC.X = 500f;
		clubPoolStaticFNPC.Y = 180f;
		ClubPoolStaticGHINPC clubPoolStaticGHINPC = base.Game.GetNPCLayerAt<ClubPoolStaticGHINPC>(LayerOrder.Foreground);
		clubPoolStaticGHINPC.X = 370f;
		clubPoolStaticGHINPC.Y = 450f;
		ClubPoolStaticGHINPC2 clubPoolStaticGHINPC2 = base.Game.GetNPCLayerAt<ClubPoolStaticGHINPC2>(LayerOrder.Background);
		clubPoolStaticGHINPC2.PoolOffset = clubPoolStaticGHINPC.PoolOffset;
		clubPoolStaticGHINPC2.X = clubPoolStaticGHINPC.X;
		clubPoolStaticGHINPC2.Y = clubPoolStaticGHINPC.Y;
		ClubPoolStaticDNPC clubPoolStaticDNPC = base.Game.GetNPCLayerAt<ClubPoolStaticDNPC>(LayerOrder.Foreground);
		clubPoolStaticDNPC.X = 50f;
		clubPoolStaticDNPC.Y = 690f;
		ClubPoolStaticDNPC2 clubPoolStaticDNPC2 = base.Game.GetNPCLayerAt<ClubPoolStaticDNPC2>(LayerOrder.Background);
		clubPoolStaticDNPC2.PoolOffset = clubPoolStaticDNPC.PoolOffset;
		clubPoolStaticDNPC2.X = clubPoolStaticDNPC.X;
		clubPoolStaticDNPC2.Y = clubPoolStaticDNPC.Y;
		if (showRemy)
		{
			remy = base.Game.GetNPCLayerAt<ClubStaticRemyNPC>(LayerOrder.Foreground);
			remy.X = 1010f;
			remy.Y = 150f;
			remy.Click = OnRemyClick;
		}
		ClubPoolStaticJKNPC clubPoolStaticJKNPC = base.Game.GetNPCLayerAt<ClubPoolStaticJKNPC>(LayerOrder.Foreground);
		clubPoolStaticJKNPC.X = 1269f;
		clubPoolStaticJKNPC.Y = 383f;
		ClubPoolStaticJKNPC2 clubPoolStaticJKNPC2 = base.Game.GetNPCLayerAt<ClubPoolStaticJKNPC2>(LayerOrder.Background);
		clubPoolStaticJKNPC2.PoolOffset = clubPoolStaticJKNPC.PoolOffset;
		clubPoolStaticJKNPC2.X = clubPoolStaticJKNPC.X;
		clubPoolStaticJKNPC2.Y = clubPoolStaticJKNPC.Y;
		ClubPoolStaticLNPC clubPoolStaticLNPC = base.Game.GetNPCLayerAt<ClubPoolStaticLNPC>(LayerOrder.Background);
		clubPoolStaticLNPC.X = 1630f;
		clubPoolStaticLNPC.Y = 106f;
		ClubPoolStaticMNPC clubPoolStaticMNPC = base.Game.GetNPCLayerAt<ClubPoolStaticMNPC>(LayerOrder.Background);
		clubPoolStaticMNPC.X = 1879f;
		clubPoolStaticMNPC.Y = 106f;
		ClubPoolStaticNNPC clubPoolStaticNNPC = base.Game.GetNPCLayerAt<ClubPoolStaticNNPC>(LayerOrder.Background);
		clubPoolStaticNNPC.X = 2039f;
		clubPoolStaticNNPC.Y = 106f;
		ClubPoolStaticOPNPC clubPoolStaticOPNPC = base.Game.GetNPCLayerAt<ClubPoolStaticOPNPC>(LayerOrder.Foreground);
		clubPoolStaticOPNPC.X = 2223f;
		clubPoolStaticOPNPC.Y = 442f;
		ClubPoolStaticOPNPC2 clubPoolStaticOPNPC2 = base.Game.GetNPCLayerAt<ClubPoolStaticOPNPC2>(LayerOrder.Background);
		clubPoolStaticOPNPC2.PoolOffset = clubPoolStaticOPNPC.PoolOffset;
		clubPoolStaticOPNPC2.X = clubPoolStaticOPNPC.X;
		clubPoolStaticOPNPC2.Y = clubPoolStaticOPNPC.Y;
		ClubPoolStaticQRNPC clubPoolStaticQRNPC = base.Game.GetNPCLayerAt<ClubPoolStaticQRNPC>(LayerOrder.Foreground);
		clubPoolStaticQRNPC.X = 2694f;
		clubPoolStaticQRNPC.Y = 97f;
	}

	public override void Update(GameTime gameTime)
	{
		if (IsOrderingChanged)
		{
			List<AbstractLayer> layers = base.Layers.Where((AbstractLayer x) => x is NPCLayer NPCLayer && (!(NPCLayer.NPC is ClubStaticNPC) || !(NPCLayer.NPC is ClubStaticSpineNPC))).ToList();
			layers.ForEach(delegate(AbstractLayer layer)
			{
				layer.ZOrder = 3;
			});
		}
		base.Update(gameTime);
	}

	private void OnDoorClick()
	{
		base.Game.StartScene<ClubUpstairsScene>();
	}

	private void OnRemyClick()
	{
		base.Game.PlayCutscene(AmorousData.RemyPreDate);
	}
}
