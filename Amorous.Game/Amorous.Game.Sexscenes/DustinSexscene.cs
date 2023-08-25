using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;
using Spine;

namespace Amorous.Game.Sexscenes;

public class DustinSexscene : CensoredSexscene
{
	private static readonly List<SkeletonJson.SpineEvent> Events = new List<SkeletonJson.SpineEvent>
	{
		new SkeletonJson.SpineEvent
		{
			AnimationName = "animation",
			EventName = EVENT_THRUST_START,
			FrameTimes = new float[6] { 1f, 2f, 3f, 4f, 5f, 6f }
		},
		new SkeletonJson.SpineEvent
		{
			AnimationName = "animation",
			EventName = EVENT_THRUST_END,
			FrameTimes = new float[6] { 1.2f, 2.2f, 3.2f, 4.2f, 5.2f, 6.2f }
		},
		new SkeletonJson.SpineEvent
		{
			AnimationName = "animation",
			EventName = EVENT_MOAN,
			FrameTimes = new float[6] { 1.3f, 2.3f, 3.3f, 4.3f, 5.3f, 6.3f }
		}
	};

	public DustinSexscene(ContentManager content)
		: base(content, "Assets/SexScenes/Dustin/Dustin Sex", "Assets/SexScenes/Dustin/Background", "Assets/SexScenes/Dustin/Foreground", events: Events, sounds: MaleSexsceneSounds.GetSingleton(content), scale: Censorship.Censored ? 1.5f : 1f, premultipliedAlpha: true, cycle: 3000f)
	{
		base.Skeleton.StartAnimationWithLooping("animation");
		if (Censorship.Censored)
		{
			base.Skeleton.X = 1000f;
			base.Skeleton.Y = 1700f;
		}
		else
		{
			base.Skeleton.X = 900f;
			base.Skeleton.Y = 1050f;
			base.Skeleton.IncreaseDuration("animation", -0.3f);
		}
	}

	protected override void RefreshInternal(PlayerData data)
	{
		base.Skeleton.SetVisibility(0f);
		if (!Censorship.Censored)
		{
			base.Skeleton.SetAlpha("Player Back", 1f);
			base.Skeleton.SetAlpha("Dustin Eyes", 1f);
			base.Skeleton.SetAlpha("Dustin pupil", 1f);
			base.Skeleton.SetAlpha("Dustin head", 1f);
			base.Skeleton.SetAlpha("Dustin Hair", 1f);
			base.Skeleton.SetAlpha("Dustin ear", 1f);
			base.Skeleton.SetAlpha("Dustin eyelid", 1f);
			base.Skeleton.SetAlpha("Dustin muzzle", 1f);
			base.Skeleton.SetAlpha("Dustin fringe", 1f);
			base.Skeleton.SetAlpha("Dustin Upper Body", 1f);
			base.Skeleton.SetAlpha("Dustin shoulder top", 1f);
			base.Skeleton.SetAlpha("Dustin forearm top", 1f);
			base.Skeleton.SetAlpha("Dustin tail", 1f);
			base.Skeleton.SetAlpha("Dustin tail tip", 1f);
			base.Skeleton.SetAlpha("Dustin thigh back", 1f);
			base.Skeleton.SetAlpha("Dustin Cock", 1f);
			base.Skeleton.SetAlpha("Player thigh bot", 1f);
			base.Skeleton.SetAlpha("Player thigh bot stripes", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
			base.Skeleton.SetAlpha("Player thigh bot underbelly", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
			base.Skeleton.SetAlpha("Player taint", 1f);
			base.Skeleton.SetAlpha("Player taint underbelly", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
			base.Skeleton.SetAlpha("Player Balls", 1f);
			base.Skeleton.SetAlpha("Player balls underbelly", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
			base.Skeleton.SetAlpha("Player thigh top", 1f);
			base.Skeleton.SetAlpha("Player thigh top stripes", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
			base.Skeleton.SetAlpha("Player thigh top underbelly", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
			base.Skeleton.SetAlpha("Player shin top", 1f);
			base.Skeleton.SetAlpha("Dustin balls", 1f);
			base.Skeleton.SetAlpha("Dustin thigh right", 1f);
			base.Skeleton.SetAlpha("Dustin shin right", 1f);
			base.Skeleton.SetColor("Player Back", data.GenitaliaColor);
			base.Skeleton.SetColor("Player thigh bot", data.BodyColor);
			base.Skeleton.SetColor("Player thigh bot stripes", data.StripesColor);
			base.Skeleton.SetColor("Player thigh bot underbelly", data.UnderbellyColor);
			base.Skeleton.SetColor("Player taint", data.BodyColor);
			base.Skeleton.SetColor("Player taint underbelly", data.UnderbellyColor);
			base.Skeleton.SetColor("Player Balls", data.BallsColor);
			base.Skeleton.SetColor("Player balls underbelly", data.UnderbellyColor);
			base.Skeleton.SetColor("Player thigh top", data.BodyColor);
			base.Skeleton.SetColor("Player thigh top stripes", data.StripesColor);
			base.Skeleton.SetColor("Player thigh top underbelly", data.UnderbellyColor);
			base.Skeleton.SetColor("Player shin top", data.BodyColor);
			base.ExplosionSlots.Add("Cum");
		}
		else
		{
			base.Skeleton.SetAlpha("Dustin Eyes", 1f);
			base.Skeleton.SetAlpha("Dustin pupil", 1f);
			base.Skeleton.SetAlpha("Dustin head", 1f);
			base.Skeleton.SetAlpha("Dustin Hair", 1f);
			base.Skeleton.SetAlpha("Dustin ear", 1f);
			base.Skeleton.SetAlpha("Dustin eyelid", 1f);
			base.Skeleton.SetAlpha("Dustin muzzle", 1f);
			base.Skeleton.SetAlpha("Dustin fringe", 1f);
			base.Skeleton.SetAlpha("Dustin Upper Body", 1f);
			base.Skeleton.SetAlpha("Dustin shoulder top", 1f);
			base.Skeleton.SetAlpha("Dustin forearm top", 1f);
		}
	}
}
