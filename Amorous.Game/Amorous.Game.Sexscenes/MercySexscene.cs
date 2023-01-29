using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
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

	public MercySexscene(ContentManager content)
		: base(content, "Assets/SexScenes/Mercy/Mercy Sex", "Assets/SexScenes/Mercy/Background", null, events: Events, sounds: FemaleSexsceneSounds.Get(content), scale: Censorship.Censored ? 2.2f : 1f, premultipliedAlpha: true, cycle: 3000f)
	{
		base.Spine.StartAnimationWithLooping("animation");
		if (Censorship.Censored)
		{
			base.Spine.X = 450f;
			base.Spine.Y = 900f;
		}
		else
		{
			base.Spine.X = 960f;
			base.Spine.Y = 1090f;
		}
	}

	protected override void RefreshSubscene(PlayerData data)
	{
		base.Spine.SetVisibility(0f);
		if (!Censorship.Censored)
		{
			base.Spine.SetAlpha("Mercy leg left", 1f);
			base.Spine.SetAlpha("Mercy arm left", 1f);
			base.Spine.SetAlpha("Mercy body", 1f);
			base.Spine.SetAlpha("Mercy arm right", 1f);
			base.Spine.SetAlpha("Mercy horn left", 1f);
			base.Spine.SetAlpha("Mercy ear left", 1f);
			base.Spine.SetAlpha("Mercy fringe left", 1f);
			base.Spine.SetAlpha("Mercy eye", 1f);
			base.Spine.SetAlpha("Mercy pupil", 1f);
			base.Spine.SetAlpha("Mercy eyelid", 1f);
			base.Spine.SetAlpha("Mercy head", 1f);
			base.Spine.SetAlpha("Mercy eyelash", 1f);
			base.Spine.SetAlpha("Mercy fringe right", 1f);
			base.Spine.SetAlpha("Mercy horn right", 1f);
			base.Spine.SetAlpha("Mercy ear right", 1f);
			base.Spine.SetAlpha("Mercy hairlock right", 1f);
			base.Spine.SetAlpha("Mercy boob left", 1f);
			base.Spine.SetAlpha("Mercy boob right", 1f);
			base.Spine.SetAlpha("Mercy stomach", 1f);
			base.Spine.SetAlpha("Mercy cock", 1f);
			base.Spine.SetAlpha("Mercy tail", 1f);
			base.Spine.SetAlpha("Mercy leg right", 1f);
			base.Spine.SetAlpha("Mercy taint back", 1f);
			base.Spine.SetAlpha("Mercy taint", 1f);
			base.Spine.SetAlpha("Player body", 1f);
			base.Spine.SetAlpha("Player body underbelly", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
			base.Spine.SetAlpha("Player taint", 1f);
			base.Spine.SetAlpha("Player shin left", 1f);
			base.Spine.SetAlpha("Player shin left markings short", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.ShortShin) ? 1f : 0f);
			base.Spine.SetAlpha("Player shin left markings long", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.LongShin) ? 1f : 0f);
			base.Spine.SetAlpha("Player cock", 1f);
			base.Spine.SetAlpha("Player cock uncut", (data.CockType == PlayerData.ECockType.Cut) ? 1f : 0f);
			base.Spine.SetAlpha("Player thigh left", 1f);
			base.Spine.SetAlpha("Player thigh left markings inner thigh", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underthigh) ? 1f : 0f);
			base.Spine.SetAlpha("Player thigh left stripes", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
			base.Spine.SetAlpha("Player cock knot", (data.CockType == PlayerData.ECockType.Knotted) ? 1f : 0f);
			base.Spine.SetAlpha("Player balls", 1f);
			base.Spine.SetAlpha("Player Underbelly", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
			base.Spine.SetAlpha("Player shin right", 1f);
			base.Spine.SetAlpha("Player shin right markings short", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.ShortShin) ? 1f : 0f);
			base.Spine.SetAlpha("Player shin right markings long", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.LongShin) ? 1f : 0f);
			base.Spine.SetAlpha("Player thigh right", 1f);
			base.Spine.SetAlpha("Player thigh right markings inner thigh", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underthigh) ? 1f : 0f);
			base.Spine.SetAlpha("Player thigh right stripes", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
			bool flag = data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianShin);
			base.Spine.SetColor("Player body", data.BodyColor);
			base.Spine.SetColor("Player body underbelly", data.UnderbellyColor);
			base.Spine.SetColor("Player taint", data.UnderbellyColor);
			base.Spine.SetColor("Player shin left", data.BodyColor);
			base.Spine.SetColor("Player shin left markings short", flag ? data.AvianShinColor : data.ShortShinColor);
			base.Spine.SetColor("Player shin left markings long", flag ? data.AvianShinColor : data.LongShinColor);
			if (data.CockType != PlayerData.ECockType.Cut)
			{
				base.Spine.SetColor("Player cock", data.GenitaliaColor);
			}
			else
			{
				base.Spine.SetColor("Player cock", data.GenitaliaFleshColor);
				base.Spine.SetColor("Player cock uncut", data.GenitaliaColor);
			}
			base.Spine.SetColor("Player thigh left", data.BodyColor);
			base.Spine.SetColor("Player thigh left markings inner thigh", data.UnderthighColor);
			base.Spine.SetColor("Player thigh left stripes", data.StripesColor);
			base.Spine.SetColor("Player cock knot", data.GenitaliaColor);
			base.Spine.SetColor("Player balls", data.BallsColor);
			base.Spine.SetColor("Player Underbelly", data.UnderbellyColor);
			base.Spine.SetColor("Player shin right", data.BodyColor);
			base.Spine.SetColor("Player shin right markings short", flag ? data.AvianShinColor : data.ShortShinColor);
			base.Spine.SetColor("Player shin right markings long", flag ? data.AvianShinColor : data.LongShinColor);
			base.Spine.SetColor("Player thigh right", data.BodyColor);
			base.Spine.SetColor("Player thigh right markings inner thigh", data.UnderthighColor);
			base.Spine.SetColor("Player thigh right stripes", data.StripesColor);
			base.ExplosionBones.Add("Cum");
		}
		else
		{
			base.Spine.SetAlpha("Mercy arm left", 1f);
			base.Spine.SetAlpha("Mercy body", 1f);
			base.Spine.SetAlpha("Mercy arm right", 1f);
			base.Spine.SetAlpha("Mercy horn left", 1f);
			base.Spine.SetAlpha("Mercy ear left", 1f);
			base.Spine.SetAlpha("Mercy fringe left", 1f);
			base.Spine.SetAlpha("Mercy eye", 1f);
			base.Spine.SetAlpha("Mercy pupil", 1f);
			base.Spine.SetAlpha("Mercy eyelid", 1f);
			base.Spine.SetAlpha("Mercy head", 1f);
			base.Spine.SetAlpha("Mercy eyelash", 1f);
			base.Spine.SetAlpha("Mercy fringe right", 1f);
			base.Spine.SetAlpha("Mercy horn right", 1f);
			base.Spine.SetAlpha("Mercy ear right", 1f);
			base.Spine.SetAlpha("Mercy hairlock right", 1f);
			base.Spine.SetAlpha("Mercy tail", 1f);
			base.Spine.SetAlpha("Mercy leg right", 1f);
		}
	}
}
