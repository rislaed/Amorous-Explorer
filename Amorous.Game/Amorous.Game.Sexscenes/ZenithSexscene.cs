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

	public ZenithSexscene(ContentManager content)
		: base(content, "Assets/SexScenes/Zenith/Zenith Sex", "Assets/SexScenes/Zenith/Background", null, events: Events, sounds: new MaleSexsceneSounds(content), scale: Censorship.Censored ? 1.3f : 1f, premultipliedAlpha: true, cycle: 3000f)
	{
		base.Spine.StartAnimationWithLooping("animation");
		if (!Censorship.Censored)
		{
			base.Spine.X = 960f;
			base.Spine.Y = 1090f;
		}
		else
		{
			base.Spine.X = 300f;
			base.Spine.Y = 1350f;
		}
	}

	protected override void RefreshData(PlayerData data)
	{
		base.Spine.SetVisibility(0f);
		if (Censorship.Censored)
		{
			base.Spine.SetAlpha("Zenith body", 1f);
			base.Spine.SetAlpha("Zenith shoulder left", 1f);
			base.Spine.SetAlpha("Zenith wing right", 1f);
			base.Spine.SetAlpha("Zenith jaw", 1f);
			base.Spine.SetAlpha("Zenith eye", 1f);
			base.Spine.SetAlpha("Zenith pupil", 1f);
			base.Spine.SetAlpha("Zenith eyelid back", 1f);
			base.Spine.SetAlpha("Zenith eyelid front", 1f);
			base.Spine.SetAlpha("Zenith head", 1f);
			base.Spine.SetAlpha("Zenith wing left", 1f);
			return;
		}
		base.Spine.SetAlpha("Zenith thigh right", 1f);
		base.Spine.SetAlpha("Zenith forearm right", 1f);
		base.Spine.SetAlpha("Player thigh right", 1f);
		base.Spine.SetAlpha("Player thigh right marking inner thigh", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underthigh) ? 1f : 0f);
		base.Spine.SetAlpha("Player thigh right stripes", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
		base.Spine.SetAlpha("Zenith hand right", 1f);
		base.Spine.SetAlpha("Zenith body", 1f);
		base.Spine.SetAlpha("Zenith cock", 1f);
		base.Spine.SetAlpha("Zenith shin left", 1f);
		base.Spine.SetAlpha("Zenith thigh left", 1f);
		base.Spine.SetAlpha("Player body", 1f);
		base.Spine.SetAlpha("Player body underbelly", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
		base.Spine.SetAlpha("Player body stripes", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
		base.Spine.SetAlpha("Player fit belly", (data.BodyType == PlayerData.EBodyType.Muscular) ? 1f : 0f);
		base.Spine.SetAlpha("Player chubby belly", (data.BodyType == PlayerData.EBodyType.Chubby) ? 1f : 0f);
		base.Spine.SetAlpha("Player Balls", (data.BallsType != 0) ? 1f : 0f);
		base.Spine.SetAlpha("Player foot left", 1f);
		base.Spine.SetAlpha("Player foot left avian", 0f);
		base.Spine.SetAlpha("Player foot short markings", 0f);
		base.Spine.SetAlpha("Player foot long markings", 0f);
		base.Spine.SetAlpha("Player shin left", 1f);
		bool isAvian = data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianShin);
		base.Spine.SetAlpha("Player shin left avian", isAvian ? 1f : 0f);
		base.Spine.SetAlpha("Player shin long markings", (isAvian || !data.MarkingsType.HasFlag(PlayerData.EMarkingsType.LongShin)) ? 0f : 1f);
		base.Spine.SetAlpha("Player shin left short markings", (isAvian || !data.MarkingsType.HasFlag(PlayerData.EMarkingsType.ShortShin)) ? 0f : 1f);
		base.Spine.SetAlpha("Player thigh left", 1f);
		base.Spine.SetAlpha("Player thigh left markings inner thigh", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underthigh) ? 1f : 0f);
		base.Spine.SetAlpha("Player thigh left stripes", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
		base.Spine.SetAlpha("Zenith hand left", 1f);
		base.Spine.SetAlpha("Zenith forearm left", 1f);
		base.Spine.SetAlpha("Zenith shoulder left", 1f);
		base.Spine.SetAlpha("Zenith elbow left", 1f);
		base.Spine.SetAlpha("Zenith wing right", 1f);
		base.Spine.SetAlpha("Zenith jaw", 1f);
		base.Spine.SetAlpha("Zenith eye", 1f);
		base.Spine.SetAlpha("Zenith pupil", 1f);
		base.Spine.SetAlpha("Zenith eyelid back", 1f);
		base.Spine.SetAlpha("Zenith eyelid front", 1f);
		base.Spine.SetAlpha("Zenith head", 1f);
		base.Spine.SetAlpha("Player cock horse", (data.CockType == PlayerData.ECockType.Thor) ? 1f : 0f);
		base.Spine.SetAlpha("Player cock", (data.CockType != PlayerData.ECockType.Thor) ? 1f : 0f);
		base.Spine.SetAlpha("Player cock uncut", (data.CockType == PlayerData.ECockType.Cut) ? 1f : 0f);
		base.Spine.SetAlpha("Player cock knot lines", (data.CockType == PlayerData.ECockType.Knotted) ? 1f : 0f);
		base.Spine.SetAlpha("Foot cover", 1f);
		base.Spine.SetAlpha("Zenith wing left", 1f);
		base.Spine.SetAlpha("Pillows", 1f);
		base.Spine.SetColor("Player thigh right", data.BodyColor);
		base.Spine.SetColor("Player thigh right marking inner thigh", data.UnderthighColor);
		base.Spine.SetColor("Player thigh right stripes", data.StripesColor);
		base.Spine.SetColor("Player body", data.BodyColor);
		base.Spine.SetColor("Player body underbelly", data.UnderbellyColor);
		base.Spine.SetColor("Player body stripes", data.StripesColor);
		base.Spine.SetColor("Player fit belly", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? data.UnderbellyColor : data.BodyColor);
		base.Spine.SetColor("Player chubby belly", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? data.UnderbellyColor : data.BodyColor);
		base.Spine.SetColor("Player Balls", data.BallsColor);
		base.Spine.SetColor("Player foot left", data.FeetColor);
		base.Spine.SetColor("Player foot left avian", data.FeetColor);
		base.Spine.SetColor("Player foot short markings", data.FeetColor);
		base.Spine.SetColor("Player foot long markings", data.FeetColor);
		base.Spine.SetColor("Player shin left", data.BodyColor);
		base.Spine.SetColor("Player shin left avian", data.AvianShinColor);
		base.Spine.SetColor("Player shin long markings", data.LongShinColor);
		base.Spine.SetColor("Player shin left short markings", data.ShortShinColor);
		base.Spine.SetColor("Player thigh left", data.BodyColor);
		base.Spine.SetColor("Player thigh left markings inner thigh", data.UnderthighColor);
		base.Spine.SetColor("Player thigh left stripes", data.StripesColor);
		base.Spine.SetColor("Player cock horse", data.GenitaliaColor);
		if (data.CockType == PlayerData.ECockType.Cut)
		{
			base.Spine.SetColor("Player cock", data.GenitaliaFleshColor);
			base.Spine.SetColor("Player cock uncut", data.GenitaliaColor);
		}
		else
		{
			base.Spine.SetColor("Player cock", data.GenitaliaColor);
		}
		base.Spine.SetColor("Player cock knot lines", data.GenitaliaColor);
		if (data.CockType != PlayerData.ECockType.Thor)
		{
			base.ExplosionBones.Add("Player cock cum");
		}
		else
		{
			base.ExplosionBones.Add("Player cock horse cum");
		}
		base.ExplosionBones.Add("Zenith cock cum");
		base.ExplosionBones.Add("Cum belly");
	}
}
