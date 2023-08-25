using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

public abstract class AbstractNPC
{ // _QGGOTxZ8aNWGh0hc26wcmx8wmwT
	private NPCLocation location;
	private FilterableEmotion emotion;
	private FilterablePose pose;
	private readonly List<string> clothes;
	private readonly Random blinkingRandom;
	private bool blinked;
	private int blinkingTicks;
	private int ticksBetweenBlinking;

	private const int BLINKING_IN = 375;
	private const int BLINKING_DELAY = 625;
	private const int BLINKING_OUT = 1000;

	private Action update;
	private Action draw;
	private int fadingTicks;

	private const int FADING_DELAY = 500;

	protected bool NudesBehindShirt;
	protected bool NudesBehindPants;

	public bool IsFixedOrder;
	public IAmorous Game { get; set; }
	public NPCLocation Location => location;

	public string Head
	{
		get
		{
			if (emotion != null)
			{
				return emotion.Name;
			}
			return null;
		}
	}

	public string Pose
	{
		get
		{
			if (pose != null)
			{
				return pose.Name;
			}
			return null;
		}
	}

	public string[] Clothes => clothes.ToArray();
	public bool IsRefreshing { get; private set; }
	public List<FilterableEmotion> Emotions { get; private set; }
	public List<FilterablePose> Poses { get; private set; }
	public virtual float X { get; set; }
	public virtual float Y { get; set; }
	public virtual int Width { get; protected set; }
	public virtual int Height { get; protected set; }
	public float Scale { get; set; }
	public virtual bool FlipX { get; set; }
	public virtual bool LockedOnScreen { get; set; }
	public virtual bool IsHovered { get; set; }
	public virtual Action Click { get; set; }
	public Type[] Variations { get; set; }

	protected AbstractNPC(IAmorous game)
	{
		Scale = 1f;
		clothes = new List<string>();
		Game = game;
		Emotions = new List<FilterableEmotion>();
		Poses = new List<FilterablePose>();
		blinkingRandom = new Random();
		blinked = false;
		blinkingTicks = 0;
		ticksBetweenBlinking = 4000;
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
		if (emotion != null && !string.IsNullOrEmpty(emotion.Blink))
		{
			UpdateBlinking(gameTime);
		}
		UpdateFading(gameTime);
	}

	public virtual void Draw()
	{
		DrawPending();
	}

	private void UpdateBlinking(GameTime gameTime)
	{
		if (fadingTicks > 0)
		{
			return;
		}
		if (!blinked)
		{
			ticksBetweenBlinking -= gameTime.ElapsedGameTime.Milliseconds;
			if (ticksBetweenBlinking <= 0)
			{
				blinked = true;
				blinkingTicks = 0;
			}
			return;
		}
		blinkingTicks += gameTime.ElapsedGameTime.Milliseconds;
		float alpha = 0f;
		if (blinkingTicks < BLINKING_IN)
		{
			alpha = (float)blinkingTicks / BLINKING_IN;
		}
		else if (blinkingTicks >= BLINKING_IN && blinkingTicks < BLINKING_DELAY)
		{
			alpha = 1f;
		}
		else if (blinkingTicks >= BLINKING_DELAY && blinkingTicks < BLINKING_OUT)
		{
			alpha = 1f - (float)(blinkingTicks - BLINKING_DELAY) / BLINKING_IN;
		}
		else if (blinkingTicks >= BLINKING_OUT)
		{
			blinked = false;
			ticksBetweenBlinking = blinkingRandom.Next(3, 6) * BLINKING_OUT;
		}
		SetAlpha(emotion.Blink, alpha);
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
		this.location = location;
	}

	public void SetEmotion(string name)
	{
		FilterableEmotion emotion = Emotions.FirstOrDefault((FilterableEmotion emotion) => emotion.Name == name);
		if (this.emotion != null)
		{
            Hide(this.emotion);
			if (this.emotion.Blink != null)
			{
                SetAlpha(this.emotion.Blink, 0f);
			}
		}
		this.emotion = emotion;
		if (emotion != null)
		{
			Show(emotion);
		}
	}

	public void SetPose(string name)
	{
		FilterablePose pose = Poses.FirstOrDefault((FilterablePose pose) => pose.Name == name);
		if (this.pose != null)
		{
            Hide(this.pose);
		}
		this.pose = pose;
		if (pose != null)
		{
			SetClothes(clothes.ToArray());
		}
	}

	public void SetClothes(params string[] names)
	{
		if (pose == null)
		{
			return;
		}
		clothes.Clear();
		Hide(pose);
		FilterableClothes shirt = null;
		FilterableClothes pants = null;
		bool withShirt = false;
		bool withPants = false;
		foreach (FilterableClothes cloth in pose.Clothes)
		{
			cloth.Updatable = names?.Contains(cloth.Name) ?? false;
			if (Censorship.Censored)
			{
				if (NudesBehindShirt && cloth.IsShirt && (shirt == null || cloth.CensoringShirt))
				{
					shirt = cloth;
				}
				if (NudesBehindPants && cloth.IsPants && (pants == null || cloth.CensoringPants))
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
			clothes.Add(cloth.Name);
		}
		if (Censorship.Censored)
		{
			if (NudesBehindShirt && !withShirt && shirt != null)
			{
				shirt.Updatable = true;
				clothes.Add(shirt.Name);
			}
			if (NudesBehindPants && !withPants && pants != null)
			{
				pants.Updatable = true;
				clothes.Add(pants.Name);
			}
		}
		Show(pose);
	}

	public void Apply(NPCLocation location, string head, string pose, params string[] clothes)
	{
		if (fadingTicks > 0)
		{
			ApplyScheduledEvents();
			Dispose();
		}
		IsRefreshing = true;
		update = delegate
		{
			update = null;
			RequestSpawn(location, head ?? Head, pose ?? Pose, clothes ?? Clothes);
		};
		fadingTicks = FADING_DELAY;
	}

	public void Reset()
	{
		if (fadingTicks > 0)
		{
			ApplyScheduledEvents();
			Dispose();
		}
		IsRefreshing = true;
		update = delegate
		{
			update = null;
			RequestSpawn(NPCLocation.None, null, null, null);
		};
		fadingTicks = FADING_DELAY;
	}

	private void RequestSpawn(NPCLocation location, string head, string pose, string[] clothes)
	{
		draw = delegate
		{
			Refresh(0);
			draw = delegate
			{
				IsRefreshing = false;
				SetLocation(location);
				SetEmotion(head);
				SetPose(pose);
				SetClothes(clothes);
				if (Refresh(1))
				{
					draw = delegate
					{
						draw = null;
						Refresh(2);
					};
				}
				else
				{
					draw = null;
					Dispose();
				}
			};
		};
	}

	private void UpdateFading(GameTime gameTime)
	{
		if (fadingTicks <= 0)
		{
			return;
		}
		if (update != null)
		{
			update();
			return;
		}
		fadingTicks -= gameTime.ElapsedGameTime.Milliseconds;
		if (fadingTicks > 0)
		{
			Fade((float)fadingTicks / FADING_DELAY);
		}
		else
		{
			Dispose();
		}
	}

	[Conditional("DEBUG")]
	private void PreserveDrawPending()
	{
		if (fadingTicks <= 0 && IsRefreshing)
		{
			Logger.Debug("Overticking scheduled updates at {0} ticks, originally it stucks here!", -fadingTicks);
			fadingTicks = FADING_DELAY;
		}
	}

	private void DrawPending()
	{
		if (fadingTicks > 0)
		{
			if (draw != null)
			{
				draw();
			}
		}
		PreserveDrawPending();
	}

	private void ApplyScheduledEvents()
	{
		if (update != null)
		{
			update();
		}
		while (draw != null)
		{
			draw();
		}
	}

	protected abstract bool Refresh(int stage);
	protected abstract void Fade(float percent);
	protected abstract void Dispose();
}
