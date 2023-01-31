using System;
using System.Collections.Generic;
using System.Linq;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

public abstract class AbstractNPC
{ // _QGGOTxZ8aNWGh0hc26wcmx8wmwT
	private NPCLocation _location;
	private FilterableEmotion _emotion;
	private FilterablePose _pose;
	private readonly List<string> _clothes;
	private readonly Random _random;

	private bool _blink;
	private int _blinkTicks;
	private int _timeToBlink;

	private const int BlinkingIn = 375;
	private const int BlinkingDelay = 625;
	private const int BlinkingOut = 1000;

	private Action _update;
	private Action _draw;
	private int _fading;

	private const int FadingDelay = 500;

	protected bool NudesBehindShirt;
	protected bool NudesBehindPants;

	public bool LockedInLayer;
	public IAmorous Game { get; set; }
	public NPCLocation Location => _location;

	public string Head
	{
		get
		{
			if (_emotion != null)
			{
				return _emotion.Name;
			}
			return null;
		}
	}

	public string Pose
	{
		get
		{
			if (_pose != null)
			{
				return _pose.Name;
			}
			return null;
		}
	}

	public string[] Clothes => _clothes.ToArray();
	public bool IsAnimating { get; private set; }
	public List<FilterableEmotion> Emotions { get; private set; }
	public List<FilterablePose> Poses { get; private set; }
	public virtual float X { get; set; }
	public virtual float Y { get; set; }
	public virtual int Width { get; protected set; }
	public virtual int Height { get; protected set; }
	public float Scale { get; set; }
	public virtual bool FlipX { get; set; }
	public virtual bool InTalking { get; set; }
	public virtual bool IsHovered { get; set; }
	public virtual Action Click { get; set; }
	public Type[] Variations { get; set; }

	protected AbstractNPC(IAmorous game)
	{
		Scale = 1f;
		_clothes = new List<string>();
		Game = game;
		Emotions = new List<FilterableEmotion>();
		Poses = new List<FilterablePose>();
		_random = new Random();
		_blink = false;
		_blinkTicks = 0;
		_timeToBlink = 4000;
	}

	public virtual void Start() {}

	public FilterableEmotion AddEmotion(string name, params string[] parts)
	{
		FilterableEmotion emotion = new FilterableEmotion(name, parts);
		Emotions.Add(emotion);
		return emotion;
	}

	public FilterablePose AddPose(string name, params string[] parts)
	{
		FilterablePose pose = new FilterablePose(name, parts);
		Poses.Add(pose);
		return pose;
	}

	public FilterableClothes AddClothes(string poseName, string name, params string[] parts)
	{
		FilterableClothes shirt = new FilterableClothes(name, parts);
		FilterablePose pose = Poses.First((FilterablePose pose) => pose.Name == poseName);
		pose.Clothes.Add(shirt);
		return shirt;
	}

	public virtual void Update(GameTime gameTime)
	{
		if (_emotion != null && !string.IsNullOrEmpty(_emotion.Blink))
		{
			UpdateBlinking(gameTime);
		}
		UpdateData(gameTime);
	}

	public virtual void Draw()
	{
		DrawPending();
	}

	private void UpdateBlinking(GameTime gameTime)
	{
		if (_fading > 0)
		{
			return;
		}
		if (!_blink)
		{
			_timeToBlink -= gameTime.ElapsedGameTime.Milliseconds;
			if (_timeToBlink <= 0)
			{
				_blink = true;
				_blinkTicks = 0;
			}
			return;
		}
		_blinkTicks += gameTime.ElapsedGameTime.Milliseconds;
		float alpha = 0f;
		if (_blinkTicks < BlinkingIn)
		{
			alpha = (float)_blinkTicks / BlinkingIn;
		}
		else if (_blinkTicks >= BlinkingIn && _blinkTicks < BlinkingDelay)
		{
			alpha = 1f;
		}
		else if (_blinkTicks >= BlinkingDelay && _blinkTicks < BlinkingOut)
		{
			alpha = 1f - (float)(_blinkTicks - BlinkingDelay) / BlinkingIn;
		}
		else if (_blinkTicks >= BlinkingOut)
		{
			_blink = false;
			_timeToBlink = _random.Next(3, 6) * BlinkingOut;
		}
		SetAlpha(_emotion.Blink, alpha);
	}

	protected void SetAlpha(IFilterable piece, float alpha)
	{
		if (piece == null)
		{
			return;
		}
		foreach (string item in piece.Filter())
		{
			SetAlpha(item, alpha);
		}
	}

	protected abstract void SetAlpha(string name, float alpha);

	private void Show(IFilterable piece)
	{
		SetAlpha(piece, 1f);
	}

	private void Hide(IFilterable piece)
	{
		SetAlpha(piece, 0f);
	}

	public virtual void SetLocation(NPCLocation location)
	{
		_location = location;
	}

	public void SetEmotion(string name)
	{
		FilterableEmotion emotion = Emotions.FirstOrDefault((FilterableEmotion emotion) => emotion.Name == name);
		if (_emotion != null)
		{
			Hide(_emotion);
			if (_emotion.Blink != null)
			{
				SetAlpha(_emotion.Blink, 0f);
			}
		}
		_emotion = emotion;
		if (emotion != null)
		{
			Show(emotion);
		}
	}

	public void SetPose(string name)
	{
		FilterablePose pose = Poses.FirstOrDefault((FilterablePose pose) => pose.Name == name);
		if (_pose != null)
		{
			Hide(_pose);
		}
		_pose = pose;
		if (pose != null)
		{
			SetClothes(_clothes.ToArray());
		}
	}

	public void SetClothes(params string[] names)
	{
		if (_pose == null)
		{
			return;
		}
		_clothes.Clear();
		Hide(_pose);
		FilterableClothes shirt = null;
		FilterableClothes pants = null;
		bool withShirt = false;
		bool withPants = false;
		foreach (FilterableClothes cloth in _pose.Clothes)
		{
			cloth.Updatable = names?.Contains(cloth.Name) ?? false;
			if (Censorship.Censored)
			{
				if (NudesBehindShirt && cloth.IsShirt && (shirt == null || cloth.IsCensoringShirt))
				{
					shirt = cloth;
				}
				if (NudesBehindPants && cloth.IsPants && (pants == null || cloth.IsCensoringPants))
				{
					pants = cloth;
				}
			}
			if (!cloth.Updatable)
			{
				continue;
			}
			if (!Censorship.Censored)
			{
				if ((Censorship.Topless && cloth.IsShirt) || (Censorship.Bottomless && cloth.IsPants))
				{
					cloth.Updatable = false;
					continue;
				}
			}
			else
			{
				withShirt |= cloth.IsShirt;
				withPants |= cloth.IsPants;
			}
			_clothes.Add(cloth.Name);
		}
		if (Censorship.Censored)
		{
			if (NudesBehindShirt && !withShirt && shirt != null)
			{
				shirt.Updatable = true;
				_clothes.Add(shirt.Name);
			}
			if (NudesBehindPants && !withPants && pants != null)
			{
				pants.Updatable = true;
				_clothes.Add(pants.Name);
			}
		}
		Show(_pose);
	}

	public void Apply(NPCLocation location, string head, string pose, params string[] clothes)
	{
		if (_fading > 0)
		{
			ApplyScheduledEvents();
			Dispose();
		}
		IsAnimating = true;
		_update = delegate
		{
			_update = null;
			SetState(location, head ?? Head, pose ?? Pose, clothes ?? Clothes);
		};
		_fading = FadingDelay;
	}

	public void Reset()
	{
		if (_fading > 0)
		{
			ApplyScheduledEvents();
			Dispose();
		}
		IsAnimating = true;
		_update = delegate
		{
			_update = null;
			SetState(NPCLocation.None, null, null, null);
		};
		_fading = FadingDelay;
	}

	private void SetState(NPCLocation location, string head, string pose, string[] clothes)
	{
		_draw = delegate
		{
			Refresh(0);
			_draw = delegate
			{
				IsAnimating = false;
				SetLocation(location);
				SetEmotion(head);
				SetPose(pose);
				SetClothes(clothes);
				if (Refresh(1))
				{
					_draw = delegate
					{
						_draw = null;
						Refresh(2);
					};
				}
				else
				{
					_draw = null;
					Dispose();
				}
			};
		};
	}

	private void UpdateData(GameTime gameTime)
	{
		if (_fading <= 0)
		{
			return;
		}
		if (_update != null)
		{
			_update();
			return;
		}
		_fading -= gameTime.ElapsedGameTime.Milliseconds;
		if (_fading > 0)
		{
			Fade((float)_fading / FadingDelay);
		}
		else
		{
			Dispose();
		}
	}

	private void DrawPending()
	{
		if (_fading > 0 && _draw != null)
		{
			_draw();
		}
	}

	private void ApplyScheduledEvents()
	{
		if (_update != null)
		{
			_update();
		}
		while (_draw != null)
		{
			_draw();
		}
	}

	protected abstract bool Refresh(int stage);
	protected abstract void Fade(float percent);
	protected abstract void Dispose();
}
