using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;
using Spine;

namespace Amorous.Game.Sexscenes;

public class ZenithSexscene : CensoredSexscene
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

	public ZenithSexscene(ContentManager content)
		: base(content, "Assets/SexScenes/Zenith/Zenith Sex", "Assets/SexScenes/Zenith/Background", null, events: Events, sounds: MaleSexsceneSounds.GetSingleton(content), scale: Censorship.Censored ? 1.3f : 1f, premultipliedAlpha: true, cycle: 3000f)
	{
		base.Skeleton.StartAnimationWithLooping("animation");
		if (!Censorship.Censored)
		{
			base.Skeleton.X = 960f;
			base.Skeleton.Y = 1090f;
		}
		else
		{
			base.Skeleton.X = 300f;
			base.Skeleton.Y = 1350f;
		}
	}

	protected override void RefreshInternal(PlayerData data)
	{
		base.Skeleton.SetVisibility(0f);
		if (Censorship.Censored)
		{
			base.Skeleton.SetAlpha("Zenith body", 1f);
			base.Skeleton.SetAlpha("Zenith shoulder left", 1f);
			base.Skeleton.SetAlpha("Zenith wing right", 1f);
			base.Skeleton.SetAlpha("Zenith jaw", 1f);
			base.Skeleton.SetAlpha("Zenith eye", 1f);
			base.Skeleton.SetAlpha("Zenith pupil", 1f);
			base.Skeleton.SetAlpha("Zenith eyelid back", 1f);
			base.Skeleton.SetAlpha("Zenith eyelid front", 1f);
			base.Skeleton.SetAlpha("Zenith head", 1f);
			base.Skeleton.SetAlpha("Zenith wing left", 1f);
			return;
		}
		base.Skeleton.SetAlpha("Zenith thigh right", 1f);
		base.Skeleton.SetAlpha("Zenith forearm right", 1f);
		base.Skeleton.SetAlpha("Player thigh right", 1f);
		base.Skeleton.SetAlpha("Player thigh right marking inner thigh", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underthigh) ? 1f : 0f);
		base.Skeleton.SetAlpha("Player thigh right stripes", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
		base.Skeleton.SetAlpha("Zenith hand right", 1f);
		base.Skeleton.SetAlpha("Zenith body", 1f);
		base.Skeleton.SetAlpha("Zenith cock", 1f);
		base.Skeleton.SetAlpha("Zenith shin left", 1f);
		base.Skeleton.SetAlpha("Zenith thigh left", 1f);
		base.Skeleton.SetAlpha("Player body", 1f);
		base.Skeleton.SetAlpha("Player body underbelly", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
		base.Skeleton.SetAlpha("Player body stripes", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
		base.Skeleton.SetAlpha("Player fit belly", (data.BodyType == PlayerData.EBodyType.Muscular) ? 1f : 0f);
		base.Skeleton.SetAlpha("Player chubby belly", (data.BodyType == PlayerData.EBodyType.Chubby) ? 1f : 0f);
		base.Skeleton.SetAlpha("Player Balls", (data.BallsType != 0) ? 1f : 0f);
		base.Skeleton.SetAlpha("Player foot left", 1f);
		base.Skeleton.SetAlpha("Player foot left avian", 0f);
		base.Skeleton.SetAlpha("Player foot short markings", 0f);
		base.Skeleton.SetAlpha("Player foot long markings", 0f);
		base.Skeleton.SetAlpha("Player shin left", 1f);
		bool isAvian = data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianShin);
		base.Skeleton.SetAlpha("Player shin left avian", isAvian ? 1f : 0f);
		base.Skeleton.SetAlpha("Player shin long markings", (isAvian || !data.MarkingsType.HasFlag(PlayerData.EMarkingsType.LongShin)) ? 0f : 1f);
		base.Skeleton.SetAlpha("Player shin left short markings", (isAvian || !data.MarkingsType.HasFlag(PlayerData.EMarkingsType.ShortShin)) ? 0f : 1f);
		base.Skeleton.SetAlpha("Player thigh left", 1f);
		base.Skeleton.SetAlpha("Player thigh left markings inner thigh", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underthigh) ? 1f : 0f);
		base.Skeleton.SetAlpha("Player thigh left stripes", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
		base.Skeleton.SetAlpha("Zenith hand left", 1f);
		base.Skeleton.SetAlpha("Zenith forearm left", 1f);
		base.Skeleton.SetAlpha("Zenith shoulder left", 1f);
		base.Skeleton.SetAlpha("Zenith elbow left", 1f);
		base.Skeleton.SetAlpha("Zenith wing right", 1f);
		base.Skeleton.SetAlpha("Zenith jaw", 1f);
		base.Skeleton.SetAlpha("Zenith eye", 1f);
		base.Skeleton.SetAlpha("Zenith pupil", 1f);
		base.Skeleton.SetAlpha("Zenith eyelid back", 1f);
		base.Skeleton.SetAlpha("Zenith eyelid front", 1f);
		base.Skeleton.SetAlpha("Zenith head", 1f);
		base.Skeleton.SetAlpha("Player cock horse", (data.CockType == PlayerData.ECockType.Thor) ? 1f : 0f);
		base.Skeleton.SetAlpha("Player cock", (data.CockType != PlayerData.ECockType.Thor) ? 1f : 0f);
		base.Skeleton.SetAlpha("Player cock uncut", (data.CockType == PlayerData.ECockType.Cut) ? 1f : 0f);
		base.Skeleton.SetAlpha("Player cock knot lines", (data.CockType == PlayerData.ECockType.Knotted) ? 1f : 0f);
		base.Skeleton.SetAlpha("Foot cover", 1f);
		base.Skeleton.SetAlpha("Zenith wing left", 1f);
		base.Skeleton.SetAlpha("Pillows", 1f);
		base.Skeleton.SetColor("Player thigh right", data.BodyColor);
		base.Skeleton.SetColor("Player thigh right marking inner thigh", data.UnderthighColor);
		base.Skeleton.SetColor("Player thigh right stripes", data.StripesColor);
		base.Skeleton.SetColor("Player body", data.BodyColor);
		base.Skeleton.SetColor("Player body underbelly", data.UnderbellyColor);
		base.Skeleton.SetColor("Player body stripes", data.StripesColor);
		base.Skeleton.SetColor("Player fit belly", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? data.UnderbellyColor : data.BodyColor);
		base.Skeleton.SetColor("Player chubby belly", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? data.UnderbellyColor : data.BodyColor);
		base.Skeleton.SetColor("Player Balls", data.BallsColor);
		base.Skeleton.SetColor("Player foot left", data.FeetColor);
		base.Skeleton.SetColor("Player foot left avian", data.FeetColor);
		base.Skeleton.SetColor("Player foot short markings", data.FeetColor);
		base.Skeleton.SetColor("Player foot long markings", data.FeetColor);
		base.Skeleton.SetColor("Player shin left", data.BodyColor);
		base.Skeleton.SetColor("Player shin left avian", data.AvianShinColor);
		base.Skeleton.SetColor("Player shin long markings", data.LongShinColor);
		base.Skeleton.SetColor("Player shin left short markings", data.ShortShinColor);
		base.Skeleton.SetColor("Player thigh left", data.BodyColor);
		base.Skeleton.SetColor("Player thigh left markings inner thigh", data.UnderthighColor);
		base.Skeleton.SetColor("Player thigh left stripes", data.StripesColor);
		base.Skeleton.SetColor("Player cock horse", data.GenitaliaColor);
		if (data.CockType == PlayerData.ECockType.Cut)
		{
			base.Skeleton.SetColor("Player cock", data.GenitaliaFleshColor);
			base.Skeleton.SetColor("Player cock uncut", data.GenitaliaColor);
		}
		else
		{
			base.Skeleton.SetColor("Player cock", data.GenitaliaColor);
		}
		base.Skeleton.SetColor("Player cock knot lines", data.GenitaliaColor);
		if (data.CockType != PlayerData.ECockType.Thor)
		{
			base.ExplosionSlots.Add("Player cock cum");
		}
		else
		{
			base.ExplosionSlots.Add("Player cock horse cum");
		}
		base.ExplosionSlots.Add("Zenith cock cum");
		base.ExplosionSlots.Add("Cum belly");
	}
}
