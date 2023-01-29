using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Spine;

namespace Amorous.Game.Sexscenes;

public class CensoredSexscene : AbstractSexscene
{
	private class Particle
	{
		private const int SpawnLeft = 64;
		private const int SpawnRight = 1920 - SpawnLeft;

		private float _x, _y, _degrees;
		private float _ticks, _cycle, _interpolation;
		private float _speedY, _vectorX, _speedX, _vectorY;

		public Particle()
		{
			ResetState();
		}

		private void ResetState()
		{
			_x = Randoms.Next(SpawnLeft, SpawnRight);
			_y = 1144f;
			_ticks = 0f;
			_interpolation = 1f;
			_degrees = Randoms.NextDouble(-10f, 10f);
			_speedY = Randoms.NextDouble(128f, 256f);
			_vectorX = Randoms.NextDouble(1f, 5f);
			_speedX = Randoms.NextDouble(10f, 100f);
			_vectorY = Randoms.NextDouble(1f, 3f);
			_cycle = Randoms.NextDouble(0f, 1080f);
		}

		public void Update(float ticks)
		{
			_x += (float)Math.Sin(Randoms.Date * _vectorX) * (_speedX * ticks);
			_y -= _speedY * ticks;
			if (_y < _cycle)
			{
				_ticks += _speedY * _vectorY * ticks;
				_interpolation = 1f - _ticks / _cycle;
			}
			if (_y + 64f < 0f || _interpolation <= 0f)
			{
				ResetState();
			}
		}

		public void Draw(Texture2D texture, SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(texture, new Rectangle((int)_x, (int)_y, 128, 128), null, Color.White * _interpolation, MathHelper.ToRadians(_degrees), new Vector2(64f, 64f), SpriteEffects.None, 0f);
		}
	}

	private const int ParticlesCount = 10;

	private readonly List<Particle> _particles;
	private readonly Texture2D _particleTexture;
	private float _ticksToEmit;

	public CensoredSexscene(ContentManager content, string spine, string background, string overlay = null, float scale = 1f, bool premultipliedAlpha = true, List<SkeletonJson.SpineEvent> events = null, AbstractSexsceneSounds sounds = null, float cycle = 1000f)
		: base(content, spine, background, Censorship.Censored ? "Assets/SexScenes/Generic/Overlay" : overlay, scale, premultipliedAlpha, Censorship.Censored ? null : events, sounds)
	{
		if (Censorship.Censored)
		{
			Ticks = (Cycle = cycle);
			_particles = new List<Particle>();
			_particleTexture = content.Load<Texture2D>("Assets/SexScenes/Generic/Heart");
			FadingMediaPlayer.PlayOnRepeat(AmorousData.OMorroNaoTemVezTrack, 0.4f);
		}
	}

	public override void ResetPhase()
	{
		if (!Censorship.Censored)
		{
			base.ResetPhase();
		}
	}

	public override void ProgressSexscene()
	{
		if (!Censorship.Censored)
		{
			base.ProgressSexscene();
		}
	}

	public override void ToPhase(int state, bool setTo = false)
	{
		if (!Censorship.Censored)
		{
			base.ToPhase(state, setTo);
		}
	}

	public override void ExplodeNow()
	{
		if (!Censorship.Censored)
		{
			base.ExplodeNow();
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
		if (_particles.Count < ParticlesCount)
		{
			_ticksToEmit -= ticks;
			if (_ticksToEmit < 0f)
			{
				_ticksToEmit = Randoms.NextDouble(0f, 1f);
				_particles.Add(new Particle());
			}
		}
		foreach (Particle item in _particles)
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
		foreach (Particle item in _particles)
		{
			item.Draw(_particleTexture, spriteBatch);
		}
		spriteBatch.End();
	}

	public override void LoadPhase(Phase phase, bool explode)
	{
		if (!Censorship.Censored)
		{
			base.LoadPhase(phase, explode);
		}
	}
}
