using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Spine;

public abstract class AbstractSexscene
{ // _TwlwMC1hhdSzamwGWEBxuUkz1gH
	public enum Phase
	{
		Idle,
		Slow,
		Medium,
		Fast
	}

	public const string EventThrustStart = "ThrustStart";
	public const string EventThrustEnd = "ThrustEnd";
	public const string EventMoan = "Moan";

	public const float IdlePhase = 2000f;
	public const float SlowPhase = 1000f;
	public const float MediumPhase = 500f;
	public const float FastPhase = 300f;

	protected float Ticks = 1000f;
	protected float TickToPhase = 1000f;

	private float _interpolation, _targetInterpolation;
	private int _moanTo, _moanWhen;
	private bool _explodedMoans;

	public bool Muted { get; set; }
	public SpineRenderer Spine { get; private set; }
	public Texture2D Background { get; private set; }
	public Texture2D Overlay { get; protected set; }

	protected List<string> ExplosionBones { get; private set; }
	protected AbstractSexsceneSounds Sounds { get; set; }
	protected ContentManager Content { get; set; }

	public Phase State { get; private set; }
	public bool Exploded { get; private set; }
	public string Subscene { get; set; }
	public Texture2D Skin { get; set; }

	protected AbstractSexscene(ContentManager contentManager, string spine, string background, string overlay = null, float scale = 1f, bool premultipliedAlpha = true, List<SkeletonJson.SpineEvent> events = null, AbstractSexsceneSounds sounds = null)
	{
		Content = contentManager;
		ExplosionBones = new List<string>();
		Spine = contentManager.LoadSkeleton(spine, scale, premultipliedAlpha, events);
		Sounds = sounds;
		if (events != null)
		{
			Spine.OnAnimationFrame = (Action<string>)Delegate.Combine(Spine.OnAnimationFrame, new Action<string>(PlaySounds));
		}
		Spine.SetVisibility(0f);
		ResetPhase();
		RefreshSubscene();
		Background = contentManager.Load<Texture2D>(background);
		if (!string.IsNullOrEmpty(overlay))
		{
			Overlay = contentManager.Load<Texture2D>(overlay);
		}
	}

	public void RefreshSubscene()
	{
		RefreshData(PlayerPreferences.GetPlayerData());
	}

	private void PlaySounds(string moanOrThrust)
	{
		if (Muted || Sounds == null)
		{
			return;
		}
		switch (moanOrThrust)
		{
			case EventThrustStart:
				Sounds.Squishing.PlayNext();
				break;
			case EventThrustEnd:
				switch (State)
				{
				case Phase.Slow:
					Sounds.SlappingMedium.PlayNext();
					break;
				case Phase.Medium:
				case Phase.Fast:
					Sounds.SlappingFast.PlayNext();
					break;
				}
				break;
			case EventMoan:
			{
				Phase phase = State;
				if (_explodedMoans)
				{
					phase = Phase.Fast;
				}
				_moanTo++;
				if (_moanTo > _moanWhen)
				{
					_moanWhen = Utils.Random(1, 3);
					_moanTo = 0;
					switch (phase)
					{
						case Phase.Idle:
							Sounds.MoaningSlow.PlayNext();
							break;
						case Phase.Slow:
							Sounds.MoaningMedium.PlayNext();
							break;
						case Phase.Medium:
							Sounds.MoaningFast.PlayNext();
							break;
						case Phase.Fast:
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

	protected virtual void RefreshData(PlayerData data) {}

	public virtual void Update(GameTime gameTime)
	{
		if (Ticks < TickToPhase)
		{
			Ticks += (float)gameTime.ElapsedGameTime.TotalMilliseconds;
		}
		else if (Ticks > TickToPhase)
		{
			Ticks -= (float)gameTime.ElapsedGameTime.TotalMilliseconds;
		}
		if (_interpolation < _targetInterpolation)
		{
			_interpolation += (float)(gameTime.ElapsedGameTime.TotalMilliseconds * 0.0010000000474974513);
			foreach (string bone in ExplosionBones)
			{
				Spine.SetAlpha(bone, _interpolation);
			}
			if (_interpolation > _targetInterpolation)
			{
				_interpolation = _targetInterpolation;
			}
		}
		else if (_interpolation > _targetInterpolation)
		{
			_interpolation -= (float)(gameTime.ElapsedGameTime.TotalMilliseconds * 0.0010000000474974513);
			foreach (string bone in ExplosionBones)
			{
				Spine.SetAlpha(bone, _interpolation);
			}
			if (_interpolation < _targetInterpolation)
			{
				_interpolation = _targetInterpolation;
			}
		}
		Spine.Update(gameTime, Ticks);
	}

	public virtual void Draw(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer)
	{
		if (Background != null)
		{
			spriteBatch.Begin();
			spriteBatch.Draw(Background, Vector2.Zero, Color.White);
			spriteBatch.End();
		}
		Spine.Draw(skeletonMeshRenderer, Skin);
		if (Overlay != null)
		{
			spriteBatch.Begin();
			spriteBatch.Draw(Overlay, Vector2.Zero, Color.White);
			spriteBatch.End();
		}
	}

	public virtual void ResetPhase()
	{
		ToPhase(1, setTo: true);
		_interpolation = 0f;
	}

	public virtual void ProgressSexscene()
	{
		if (State == Phase.Fast)
		{
			Explode();
		}
		else
		{
			ToPhase(1);
		}
	}

	public virtual void ToPhase(int state, bool setTo = false)
	{
		State = (Phase)(setTo ? state : Math.Max(0, Math.Min((int)(State + state), 3)));
		switch (State)
		{
			case Phase.Idle:
				TickToPhase = IdlePhase;
				break;
			case Phase.Slow:
				TickToPhase = SlowPhase;
				break;
			case Phase.Medium:
				TickToPhase = MediumPhase;
				break;
			case Phase.Fast:
				TickToPhase = FastPhase;
				break;
		}
	}

	public virtual void ExplodeNow()
	{
		Exploded = true;
		_targetInterpolation = 1f;
		_explodedMoans = true;
		_moanTo = _moanWhen;
	}

	public virtual void Explode()
	{
		Exploded = true;
		_targetInterpolation = 1f;
		_explodedMoans = true;
		_moanTo = _moanWhen;
		ToPhase(0, setTo: true);
	}

	public virtual void Clean()
	{
		Exploded = false;
		_targetInterpolation = 0f;
		_explodedMoans = false;
	}

	public virtual void LoadPhase(Phase phase, bool explode)
	{
		ToPhase((int)phase, setTo: true);
		if (explode)
		{
			ExplodeNow();
		}
	}
}
