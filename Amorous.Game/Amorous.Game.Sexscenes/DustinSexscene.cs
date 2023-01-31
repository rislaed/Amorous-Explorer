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
			EventName = EventThrustStart,
			FrameTimes = new float[6] { 1f, 2f, 3f, 4f, 5f, 6f }
		},
		new SkeletonJson.SpineEvent
		{
			AnimationName = "animation",
			EventName = EventThrustEnd,
			FrameTimes = new float[6] { 1.2f, 2.2f, 3.2f, 4.2f, 5.2f, 6.2f }
		},
		new SkeletonJson.SpineEvent
		{
			AnimationName = "animation",
			EventName = EventMoan,
			FrameTimes = new float[6] { 1.3f, 2.3f, 3.3f, 4.3f, 5.3f, 6.3f }
		}
	};

	public DustinSexscene(ContentManager content)
		: base(content, "Assets/SexScenes/Dustin/Dustin Sex", "Assets/SexScenes/Dustin/Background", "Assets/SexScenes/Dustin/Foreground", events: Events, sounds: new MaleSexsceneSounds(content), scale: Censorship.Censored ? 1.5f : 1f, premultipliedAlpha: true, cycle: 3000f)
	{
		base.Spine.StartAnimationWithLooping("animation");
		if (Censorship.Censored)
		{
			base.Spine.X = 1000f;
			base.Spine.Y = 1700f;
		}
		else
		{
			base.Spine.X = 900f;
			base.Spine.Y = 1050f;
			base.Spine.IncreaseDuration("animation", -0.3f);
		}
	}

	protected override void RefreshData(PlayerData data)
	{
		base.Spine.SetVisibility(0f);
		if (!Censorship.Censored)
		{
			base.Spine.SetAlpha("Player Back", 1f);
			base.Spine.SetAlpha("Dustin Eyes", 1f);
			base.Spine.SetAlpha("Dustin pupil", 1f);
			base.Spine.SetAlpha("Dustin head", 1f);
			base.Spine.SetAlpha("Dustin Hair", 1f);
			base.Spine.SetAlpha("Dustin ear", 1f);
			base.Spine.SetAlpha("Dustin eyelid", 1f);
			base.Spine.SetAlpha("Dustin muzzle", 1f);
			base.Spine.SetAlpha("Dustin fringe", 1f);
			base.Spine.SetAlpha("Dustin Upper Body", 1f);
			base.Spine.SetAlpha("Dustin shoulder top", 1f);
			base.Spine.SetAlpha("Dustin forearm top", 1f);
			base.Spine.SetAlpha("Dustin tail", 1f);
			base.Spine.SetAlpha("Dustin tail tip", 1f);
			base.Spine.SetAlpha("Dustin thigh back", 1f);
			base.Spine.SetAlpha("Dustin Cock", 1f);
			base.Spine.SetAlpha("Player thigh bot", 1f);
			base.Spine.SetAlpha("Player thigh bot stripes", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
			base.Spine.SetAlpha("Player thigh bot underbelly", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
			base.Spine.SetAlpha("Player taint", 1f);
			base.Spine.SetAlpha("Player taint underbelly", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
			base.Spine.SetAlpha("Player Balls", 1f);
			base.Spine.SetAlpha("Player balls underbelly", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
			base.Spine.SetAlpha("Player thigh top", 1f);
			base.Spine.SetAlpha("Player thigh top stripes", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
			base.Spine.SetAlpha("Player thigh top underbelly", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
			base.Spine.SetAlpha("Player shin top", 1f);
			base.Spine.SetAlpha("Dustin balls", 1f);
			base.Spine.SetAlpha("Dustin thigh right", 1f);
			base.Spine.SetAlpha("Dustin shin right", 1f);
			base.Spine.SetColor("Player Back", data.GenitaliaColor);
			base.Spine.SetColor("Player thigh bot", data.BodyColor);
			base.Spine.SetColor("Player thigh bot stripes", data.StripesColor);
			base.Spine.SetColor("Player thigh bot underbelly", data.UnderbellyColor);
			base.Spine.SetColor("Player taint", data.BodyColor);
			base.Spine.SetColor("Player taint underbelly", data.UnderbellyColor);
			base.Spine.SetColor("Player Balls", data.BallsColor);
			base.Spine.SetColor("Player balls underbelly", data.UnderbellyColor);
			base.Spine.SetColor("Player thigh top", data.BodyColor);
			base.Spine.SetColor("Player thigh top stripes", data.StripesColor);
			base.Spine.SetColor("Player thigh top underbelly", data.UnderbellyColor);
			base.Spine.SetColor("Player shin top", data.BodyColor);
			base.ExplosionBones.Add("Cum");
		}
		else
		{
			base.Spine.SetAlpha("Dustin Eyes", 1f);
			base.Spine.SetAlpha("Dustin pupil", 1f);
			base.Spine.SetAlpha("Dustin head", 1f);
			base.Spine.SetAlpha("Dustin Hair", 1f);
			base.Spine.SetAlpha("Dustin ear", 1f);
			base.Spine.SetAlpha("Dustin eyelid", 1f);
			base.Spine.SetAlpha("Dustin muzzle", 1f);
			base.Spine.SetAlpha("Dustin fringe", 1f);
			base.Spine.SetAlpha("Dustin Upper Body", 1f);
			base.Spine.SetAlpha("Dustin shoulder top", 1f);
			base.Spine.SetAlpha("Dustin forearm top", 1f);
		}
	}
}
