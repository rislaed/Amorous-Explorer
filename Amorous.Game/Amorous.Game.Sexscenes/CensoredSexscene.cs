using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Spine;

namespace Amorous.Game.Sexscenes;

public class CensoredSexscene : AbstractSexscene
{
	private class HeartParticle
	{
		private const int SPAWN_LEFT = 64;
		private const int SPAWN_RIGHT = 1920 - SPAWN_LEFT;

		private float positionX, positionY, rotation;
		private float ticks, lifetime, amount;
		private float speedY, vectorX, speedX, vectorY;

		public HeartParticle()
		{
			Reset();
		}

		private void Reset()
		{
			positionX = Utils.Random(SPAWN_LEFT, SPAWN_RIGHT);
			positionY = 1144f;
			ticks = 0f;
			amount = 1f;
			rotation = Utils.RandomFloat(-10f, 10f);
			speedY = Utils.RandomFloat(128f, 256f);
			vectorX = Utils.RandomFloat(1f, 5f);
			speedX = Utils.RandomFloat(10f, 100f);
			vectorY = Utils.RandomFloat(1f, 3f);
			lifetime = Utils.RandomFloat(0f, 1080f);
		}

		public void Update(float ticks)
		{
			positionX += (float)Math.Sin(Utils.Date * vectorX) * (speedX * ticks);
			positionY -= speedY * ticks;
			if (positionY < lifetime)
			{
				this.ticks += speedY * vectorY * ticks;
                amount = 1f - this.ticks / lifetime;
			}
			if (positionY + 64f < 0f || amount <= 0f)
			{
				Reset();
			}
		}

		public void Draw(Texture2D texture, SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(texture, new Rectangle((int)positionX, (int)positionY, 128, 128), null, Color.White * amount, MathHelper.ToRadians(rotation), new Vector2(64f, 64f), SpriteEffects.None, 0f);
		}
	}

	private const int PARTICLES = 10;

	private readonly List<HeartParticle> particles;
	private readonly Texture2D heartTexture;
	private float ticksToEmit;

	public CensoredSexscene(ContentManager content, string spine, string background, string overlay = null, float scale = 1f, bool premultipliedAlpha = true, List<SkeletonJson.SpineEvent> events = null, AbstractSexsceneSounds sounds = null, float cycle = 1000f)
		: base(content, spine, background, Censorship.Censored ? "Assets/SexScenes/Generic/Overlay" : overlay, scale, premultipliedAlpha, Censorship.Censored ? null : events, sounds)
	{
		if (Censorship.Censored)
		{
			PhaseTicks = (ToPhaseTicks = cycle);
			particles = new List<HeartParticle>();
			heartTexture = content.Load<Texture2D>("Assets/SexScenes/Generic/Heart");
			FadingMediaPlayer.PlayOnRepeat(AmorousData.OMorroNaoTemVezTrack, 0.4f);
		}
	}

	public override void Reset()
	{
		if (!Censorship.Censored)
		{
			base.Reset();
		}
	}

	public override void Progress()
	{
		if (!Censorship.Censored)
		{
			base.Progress();
		}
	}

	public override void PhaseTo(int state, bool setTo = false)
	{
		if (!Censorship.Censored)
		{
			base.PhaseTo(state, setTo);
		}
	}

	public override void ExplodeWithoutFading()
	{
		if (!Censorship.Censored)
		{
			base.ExplodeWithoutFading();
		}
	}

	public override void Explode()
	{
		if (!Censorship.Censored)
		{
			base.Explode();
		}
	}

	public override void Clean()
	{
		if (!Censorship.Censored)
		{
			base.Clean();
		}
	}

	public override void Update(GameTime gameTime)
	{
		base.Update(gameTime);
		if (!Censorship.Censored)
		{
			return;
		}
		float ticks = (float)(gameTime.ElapsedGameTime.TotalMilliseconds / 1000.0);
		if (particles.Count < PARTICLES)
		{
			ticksToEmit -= ticks;
			if (ticksToEmit < 0f)
			{
				ticksToEmit = Utils.RandomFloat(0f, 1f);
				particles.Add(new HeartParticle());
			}
		}
		foreach (HeartParticle item in particles)
		{
			item.Update(ticks);
		}
	}

	public override void Draw(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer)
	{
		base.Draw(spriteBatch, skeletonMeshRenderer);
		if (!Censorship.Censored)
		{
			return;
		}
		spriteBatch.Begin();
		foreach (HeartParticle item in particles)
		{
			item.Draw(heartTexture, spriteBatch);
		}
		spriteBatch.End();
	}

	public override void LoadPhase(EPhase phase, bool explode)
	{
		if (!Censorship.Censored)
		{
			base.LoadPhase(phase, explode);
		}
	}
}
