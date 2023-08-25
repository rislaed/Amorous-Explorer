using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;
using Spine;

namespace Amorous.Game.Sexscenes;

public class MercySexscene : CensoredSexscene
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

	public MercySexscene(ContentManager content)
		: base(content, "Assets/SexScenes/Mercy/Mercy Sex", "Assets/SexScenes/Mercy/Background", null, events: Events, sounds: FemaleSexsceneSounds.GetSingleton(content), scale: Censorship.Censored ? 2.2f : 1f, premultipliedAlpha: true, cycle: 3000f)
	{
		base.Skeleton.StartAnimationWithLooping("animation");
		if (Censorship.Censored)
		{
			base.Skeleton.X = 450f;
			base.Skeleton.Y = 900f;
		}
		else
		{
			base.Skeleton.X = 960f;
			base.Skeleton.Y = 1090f;
		}
	}

	protected override void RefreshInternal(PlayerData data)
	{
		base.Skeleton.SetVisibility(0f);
		if (!Censorship.Censored)
		{
			base.Skeleton.SetAlpha("Mercy leg left", 1f);
			base.Skeleton.SetAlpha("Mercy arm left", 1f);
			base.Skeleton.SetAlpha("Mercy body", 1f);
			base.Skeleton.SetAlpha("Mercy arm right", 1f);
			base.Skeleton.SetAlpha("Mercy horn left", 1f);
			base.Skeleton.SetAlpha("Mercy ear left", 1f);
			base.Skeleton.SetAlpha("Mercy fringe left", 1f);
			base.Skeleton.SetAlpha("Mercy eye", 1f);
			base.Skeleton.SetAlpha("Mercy pupil", 1f);
			base.Skeleton.SetAlpha("Mercy eyelid", 1f);
			base.Skeleton.SetAlpha("Mercy head", 1f);
			base.Skeleton.SetAlpha("Mercy eyelash", 1f);
			base.Skeleton.SetAlpha("Mercy fringe right", 1f);
			base.Skeleton.SetAlpha("Mercy horn right", 1f);
			base.Skeleton.SetAlpha("Mercy ear right", 1f);
			base.Skeleton.SetAlpha("Mercy hairlock right", 1f);
			base.Skeleton.SetAlpha("Mercy boob left", 1f);
			base.Skeleton.SetAlpha("Mercy boob right", 1f);
			base.Skeleton.SetAlpha("Mercy stomach", 1f);
			base.Skeleton.SetAlpha("Mercy cock", 1f);
			base.Skeleton.SetAlpha("Mercy tail", 1f);
			base.Skeleton.SetAlpha("Mercy leg right", 1f);
			base.Skeleton.SetAlpha("Mercy taint back", 1f);
			base.Skeleton.SetAlpha("Mercy taint", 1f);
			base.Skeleton.SetAlpha("Player body", 1f);
			base.Skeleton.SetAlpha("Player body underbelly", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
			base.Skeleton.SetAlpha("Player taint", 1f);
			base.Skeleton.SetAlpha("Player shin left", 1f);
			base.Skeleton.SetAlpha("Player shin left markings short", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.ShortShin) ? 1f : 0f);
			base.Skeleton.SetAlpha("Player shin left markings long", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.LongShin) ? 1f : 0f);
			base.Skeleton.SetAlpha("Player cock", 1f);
			base.Skeleton.SetAlpha("Player cock uncut", (data.CockType == PlayerData.ECockType.Cut) ? 1f : 0f);
			base.Skeleton.SetAlpha("Player thigh left", 1f);
			base.Skeleton.SetAlpha("Player thigh left markings inner thigh", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underthigh) ? 1f : 0f);
			base.Skeleton.SetAlpha("Player thigh left stripes", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
			base.Skeleton.SetAlpha("Player cock knot", (data.CockType == PlayerData.ECockType.Knotted) ? 1f : 0f);
			base.Skeleton.SetAlpha("Player balls", 1f);
			base.Skeleton.SetAlpha("Player Underbelly", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
			base.Skeleton.SetAlpha("Player shin right", 1f);
			base.Skeleton.SetAlpha("Player shin right markings short", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.ShortShin) ? 1f : 0f);
			base.Skeleton.SetAlpha("Player shin right markings long", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.LongShin) ? 1f : 0f);
			base.Skeleton.SetAlpha("Player thigh right", 1f);
			base.Skeleton.SetAlpha("Player thigh right markings inner thigh", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underthigh) ? 1f : 0f);
			base.Skeleton.SetAlpha("Player thigh right stripes", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
			bool isAvian = data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianShin);
			base.Skeleton.SetColor("Player body", data.BodyColor);
			base.Skeleton.SetColor("Player body underbelly", data.UnderbellyColor);
			base.Skeleton.SetColor("Player taint", data.UnderbellyColor);
			base.Skeleton.SetColor("Player shin left", data.BodyColor);
			base.Skeleton.SetColor("Player shin left markings short", isAvian ? data.AvianShinColor : data.ShortShinColor);
			base.Skeleton.SetColor("Player shin left markings long", isAvian ? data.AvianShinColor : data.LongShinColor);
			if (data.CockType != PlayerData.ECockType.Cut)
			{
				base.Skeleton.SetColor("Player cock", data.GenitaliaColor);
			}
			else
			{
				base.Skeleton.SetColor("Player cock", data.GenitaliaFleshColor);
				base.Skeleton.SetColor("Player cock uncut", data.GenitaliaColor);
			}
			base.Skeleton.SetColor("Player thigh left", data.BodyColor);
			base.Skeleton.SetColor("Player thigh left markings inner thigh", data.UnderthighColor);
			base.Skeleton.SetColor("Player thigh left stripes", data.StripesColor);
			base.Skeleton.SetColor("Player cock knot", data.GenitaliaColor);
			base.Skeleton.SetColor("Player balls", data.BallsColor);
			base.Skeleton.SetColor("Player Underbelly", data.UnderbellyColor);
			base.Skeleton.SetColor("Player shin right", data.BodyColor);
			base.Skeleton.SetColor("Player shin right markings short", isAvian ? data.AvianShinColor : data.ShortShinColor);
			base.Skeleton.SetColor("Player shin right markings long", isAvian ? data.AvianShinColor : data.LongShinColor);
			base.Skeleton.SetColor("Player thigh right", data.BodyColor);
			base.Skeleton.SetColor("Player thigh right markings inner thigh", data.UnderthighColor);
			base.Skeleton.SetColor("Player thigh right stripes", data.StripesColor);
			base.ExplosionSlots.Add("Cum");
		}
		else
		{
			base.Skeleton.SetAlpha("Mercy arm left", 1f);
			base.Skeleton.SetAlpha("Mercy body", 1f);
			base.Skeleton.SetAlpha("Mercy arm right", 1f);
			base.Skeleton.SetAlpha("Mercy horn left", 1f);
			base.Skeleton.SetAlpha("Mercy ear left", 1f);
			base.Skeleton.SetAlpha("Mercy fringe left", 1f);
			base.Skeleton.SetAlpha("Mercy eye", 1f);
			base.Skeleton.SetAlpha("Mercy pupil", 1f);
			base.Skeleton.SetAlpha("Mercy eyelid", 1f);
			base.Skeleton.SetAlpha("Mercy head", 1f);
			base.Skeleton.SetAlpha("Mercy eyelash", 1f);
			base.Skeleton.SetAlpha("Mercy fringe right", 1f);
			base.Skeleton.SetAlpha("Mercy horn right", 1f);
			base.Skeleton.SetAlpha("Mercy ear right", 1f);
			base.Skeleton.SetAlpha("Mercy hairlock right", 1f);
			base.Skeleton.SetAlpha("Mercy tail", 1f);
			base.Skeleton.SetAlpha("Mercy leg right", 1f);
		}
	}
}
