using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Spine;

public abstract class AbstractSexscene
{ // _TwlwMC1hhdSzamwGWEBxuUkz1gH
	public enum EPhase
	{
		Idle,
		Slow,
		Medium,
		Fast
	}

	public const string EVENT_THRUST_START = "ThrustStart";
	public const string EVENT_THRUST_END = "ThrustEnd";
	public const string EVENT_MOAN = "Moan";

	public const float IDLE_PHASE = 2000f;
	public const float SLOW_PHASE = 1000f;
	public const float MEDIUM_PHASE = 500f;
	public const float FAST_PHASE = 300f;

	protected float PhaseTicks = 1000f;
	protected float ToPhaseTicks = 1000f;

	private float explosionAlpha, explosionAlphaTo;
	private int ticksMoaning, ticksMoaningTo;
	private bool requiresLoudMoans;

	public bool Muted { get; set; }
	public SkeletonRenderer Skeleton { get; private set; }
	public Texture2D Background { get; private set; }
	public Texture2D Overlay { get; protected set; }

	protected List<string> ExplosionSlots { get; private set; }
	protected AbstractSexsceneSounds Sounds { get; set; }
	protected ContentManager Content { get; set; }

	public EPhase Phase { get; private set; }
	public bool Exploded { get; private set; }
	public string Subscene { get; set; }
	public Texture2D Texture { get; set; }

	protected AbstractSexscene(ContentManager contentManager, string spine, string background, string overlay = null, float scale = 1f, bool premultipliedAlpha = true, List<SkeletonJson.SpineEvent> events = null, AbstractSexsceneSounds sounds = null)
	{
		Content = contentManager;
		ExplosionSlots = new List<string>();
		Skeleton = contentManager.LoadSkeleton(spine, scale, premultipliedAlpha, events);
		Sounds = sounds;
		if (events != null)
		{
			Skeleton.OnAnimationFrame = (Action<string>)Delegate.Combine(Skeleton.OnAnimationFrame, new Action<string>(PlayMoaningSlappingAndSquishing));
		}
		Skeleton.SetVisibility(0f);
		Reset();
		Refresh();
		Background = contentManager.Load<Texture2D>(background);
		if (!string.IsNullOrEmpty(overlay))
		{
			Overlay = contentManager.Load<Texture2D>(overlay);
		}
	}

	public void Refresh()
	{
		RefreshInternal(PlayerPreferences.GetPlayerData());
	}

	private void PlayMoaningSlappingAndSquishing(string moanOrThrust)
	{
		if (Muted || Sounds == null)
		{
			return;
		}
		switch (moanOrThrust)
		{
			case EVENT_THRUST_START:
				Sounds.Squishing.PlayNext();
				break;
			case EVENT_THRUST_END:
				switch (Phase)
				{
				case EPhase.Slow:
					Sounds.SlappingMedium.PlayNext();
					break;
				case EPhase.Medium:
				case EPhase.Fast:
					Sounds.SlappingFast.PlayNext();
					break;
				}
				break;
			case EVENT_MOAN:
			{
				EPhase phase = Phase;
				if (requiresLoudMoans)
				{
					phase = EPhase.Fast;
				}
				ticksMoaning++;
				if (ticksMoaning > ticksMoaningTo)
				{
					ticksMoaningTo = Utils.Random(1, 3);
					ticksMoaning = 0;
					switch (phase)
					{
						case EPhase.Idle:
							Sounds.MoaningSlow.PlayNext();
							break;
						case EPhase.Slow:
							Sounds.MoaningMedium.PlayNext();
							break;
						case EPhase.Medium:
							Sounds.MoaningFast.PlayNext();
							break;
						case EPhase.Fast:
							Sounds.MoaningRapid.PlayNext();
							break;
					}
				}
				break;
			}
		}
	}

	public virtual string[] GetSubscenes()
	{
		return new string[0];
	}

	public virtual void SwitchToSubscene(string subscene)
	{
		Subscene = subscene;
	}

	protected virtual void RefreshInternal(PlayerData data) {}

	public virtual void Update(GameTime gameTime)
	{
		if (PhaseTicks < ToPhaseTicks)
		{
			PhaseTicks += (float)gameTime.ElapsedGameTime.TotalMilliseconds;
		}
		else if (PhaseTicks > ToPhaseTicks)
		{
			PhaseTicks -= (float)gameTime.ElapsedGameTime.TotalMilliseconds;
		}
		if (explosionAlpha < explosionAlphaTo)
		{
			explosionAlpha += (float)(gameTime.ElapsedGameTime.TotalMilliseconds * 0.0010000000474974513);
			foreach (string slotName in ExplosionSlots)
			{
				Skeleton.SetAlpha(slotName, explosionAlpha);
			}
			if (explosionAlpha > explosionAlphaTo)
			{
				explosionAlpha = explosionAlphaTo;
			}
		}
		else if (explosionAlpha > explosionAlphaTo)
		{
			explosionAlpha -= (float)(gameTime.ElapsedGameTime.TotalMilliseconds * 0.0010000000474974513);
			foreach (string slotName in ExplosionSlots)
			{
				Skeleton.SetAlpha(slotName, explosionAlpha);
			}
			if (explosionAlpha < explosionAlphaTo)
			{
				explosionAlpha = explosionAlphaTo;
			}
		}
		Skeleton.Update(gameTime, PhaseTicks);
	}

	public virtual void Draw(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer)
	{
		if (Background != null)
		{
			spriteBatch.Begin();
			spriteBatch.Draw(Background, Vector2.Zero, Color.White);
			spriteBatch.End();
		}
		Skeleton.Draw(skeletonMeshRenderer, Texture);
		if (Overlay != null)
		{
			spriteBatch.Begin();
			spriteBatch.Draw(Overlay, Vector2.Zero, Color.White);
			spriteBatch.End();
		}
	}

	public virtual void Reset()
	{
		PhaseTo(1, setTo: true);
		explosionAlpha = 0f;
	}

	public virtual void Progress()
	{
		if (Phase == EPhase.Fast)
		{
			Explode();
		}
		else
		{
			PhaseTo(1);
		}
	}

	public virtual void PhaseTo(int state, bool setTo = false)
	{
		Phase = (EPhase)(setTo ? state : Math.Max(0, Math.Min((int)(Phase + state), 3)));
		switch (Phase)
		{
			case EPhase.Idle:
				ToPhaseTicks = IDLE_PHASE;
				break;
			case EPhase.Slow:
				ToPhaseTicks = SLOW_PHASE;
				break;
			case EPhase.Medium:
				ToPhaseTicks = MEDIUM_PHASE;
				break;
			case EPhase.Fast:
				ToPhaseTicks = FAST_PHASE;
				break;
		}
	}

	public virtual void ExplodeWithoutFading()
	{
		Exploded = true;
		explosionAlphaTo = 1f;
		requiresLoudMoans = true;
		ticksMoaning = ticksMoaningTo;
	}

	public virtual void Explode()
	{
		Exploded = true;
		explosionAlphaTo = 1f;
		requiresLoudMoans = true;
		ticksMoaning = ticksMoaningTo;
		PhaseTo(0, setTo: true);
	}

	public virtual void Clean()
	{
		Exploded = false;
		explosionAlphaTo = 0f;
		requiresLoudMoans = false;
	}

	public virtual void LoadPhase(EPhase phase, bool explode)
	{
		PhaseTo((int)phase, setTo: true);
		if (explode)
		{
			ExplodeWithoutFading();
		}
	}
}
