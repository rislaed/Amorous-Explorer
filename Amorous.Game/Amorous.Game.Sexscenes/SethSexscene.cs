using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;
using Spine;

namespace Amorous.Game.Sexscenes;

public class SethSexscene : CensoredSexscene
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

	public SethSexscene(ContentManager content)
		: base(content, "Assets/SexScenes/Seth/Seth Sex", "Assets/SexScenes/Seth/Background", null, events: Events, sounds: MaleSexsceneSounds.GetSingleton(content), scale: Censorship.Censored ? 1.3f : 1f, premultipliedAlpha: true, cycle: 5000f)
	{
		base.Skeleton.StartAnimationWithLooping("animation");
		if (!Censorship.Censored)
		{
			base.Skeleton.X = 810f;
			base.Skeleton.Y = 1070f;
			base.Skeleton.IncreaseDuration("animation", -0.3f);
		}
		else
		{
			base.Skeleton.X = 150f;
			base.Skeleton.Y = 1500f;
		}
	}

	protected override void RefreshInternal(PlayerData data)
	{
		base.Skeleton.SetVisibility(0f);
		if (!Censorship.Censored)
		{
			base.Skeleton.SetAlpha("Tail long thick", (data.TailType == PlayerData.ETailType.BushyOne || data.TailType == PlayerData.ETailType.BushyTwo || data.TailType == PlayerData.ETailType.Plume || data.TailType == PlayerData.ETailType.Noodle || data.TailType == PlayerData.ETailType.Stout || data.TailType == PlayerData.ETailType.Thick) ? 1f : 0f);
			base.Skeleton.SetAlpha("Tail long thin", (data.TailType == PlayerData.ETailType.Thin) ? 1f : 0f);
			base.Skeleton.SetAlpha("Seth arm back", 1f);
			base.Skeleton.SetAlpha("Seth Body", 1f);
			base.Skeleton.SetAlpha("Player leg back", 1f);
			base.Skeleton.SetAlpha("Player leg back stripes", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
			base.Skeleton.SetAlpha("Seth leg back", 1f);
			base.Skeleton.SetAlpha("Seth glasses back", 1f);
			base.Skeleton.SetAlpha("Seth jaw", 1f);
			base.Skeleton.SetAlpha("Seth hair", 1f);
			base.Skeleton.SetAlpha("Seth eye", 1f);
			base.Skeleton.SetAlpha("Seth pupil", 1f);
			base.Skeleton.SetAlpha("Seth head", 1f);
			base.Skeleton.SetAlpha("Seth ear", 1f);
			base.Skeleton.SetAlpha("Seth fringe", 1f);
			base.Skeleton.SetAlpha("Seth Eyelid", 1f);
			base.Skeleton.SetAlpha("Seth blink", 1f);
			base.Skeleton.SetAlpha("Seth glasses top", 1f);
			base.Skeleton.SetAlpha("Seth hair cheek", 1f);
			base.Skeleton.SetAlpha("Seth arm top", 1f);
			base.Skeleton.SetAlpha("Player Body", 1f);
			base.Skeleton.SetAlpha("Player Body underbelly", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
			base.Skeleton.SetAlpha("Player knee", 1f);
			base.Skeleton.SetAlpha("Player knee stripes", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
			base.Skeleton.SetAlpha("Player knee marking sleeve long", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.LongShin) ? 1f : 0f);
			base.Skeleton.SetAlpha("Player balls", 1f);
			base.Skeleton.SetAlpha("Player balls underbelly", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
			base.Skeleton.SetAlpha("Player cock", 1f);
			base.Skeleton.SetAlpha("Player cock knot", (data.CockType == PlayerData.ECockType.Knotted) ? 1f : 0f);
			base.Skeleton.SetAlpha("Player balls top", 1f);
			base.Skeleton.SetAlpha("Player balls top underbelly", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
			base.Skeleton.SetAlpha("Seth balls", 1f);
			base.Skeleton.SetAlpha("Seth Tail top", 1f);
			base.Skeleton.SetAlpha("Player arm", 1f);
			base.Skeleton.SetAlpha("Player arm marking sleeve long", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.LongForearm) ? 1f : 0f);
			base.Skeleton.SetAlpha("Player arm stripes", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
			base.Skeleton.SetAlpha("Seth tail back", 1f);
			base.Skeleton.SetAlpha("Seth leg top", 1f);
			base.Skeleton.SetAlpha("Player leg top", 1f);
			base.Skeleton.SetAlpha("Player leg top stripes", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
			base.Skeleton.SetAlpha("Seth shin", 1f);
			base.Skeleton.SetColor("Tail long thick", data.TailColor);
			base.Skeleton.SetColor("Tail long thin", data.TailColor);
			base.Skeleton.SetColor("Player leg back", data.BodyColor);
			base.Skeleton.SetColor("Player leg back stripes", data.StripesColor);
			base.Skeleton.SetColor("Player Body", data.BodyColor);
			base.Skeleton.SetColor("Player Body underbelly", data.UnderbellyColor);
			base.Skeleton.SetColor("Player knee", data.BodyColor);
			base.Skeleton.SetColor("Player knee stripes", data.StripesColor);
			base.Skeleton.SetColor("Player knee marking sleeve long", data.LongShinColor);
			base.Skeleton.SetColor("Player balls", data.BallsColor);
			base.Skeleton.SetColor("Player balls underbelly", data.UnderbellyColor);
			base.Skeleton.SetColor("Player cock", data.GenitaliaColor);
			base.Skeleton.SetColor("Player cock knot", data.GenitaliaColor);
			base.Skeleton.SetColor("Player balls top", data.BallsColor);
			base.Skeleton.SetColor("Player balls top underbelly", data.UnderbellyColor);
			base.Skeleton.SetColor("Player arm", data.BodyColor);
			base.Skeleton.SetColor("Player arm marking sleeve long", data.LongForearmColor);
			base.Skeleton.SetColor("Player arm stripes", data.StripesColor);
			base.Skeleton.SetColor("Player leg top", data.BodyColor);
			base.Skeleton.SetColor("Player leg top stripes", data.StripesColor);
			base.ExplosionSlots.Add("Cum cock bottom");
			base.ExplosionSlots.Add("Cum cock top");
			base.ExplosionSlots.Add("Cum Buttcheek");
		}
		else
		{
			base.Skeleton.SetAlpha("Seth arm back", 1f);
			base.Skeleton.SetAlpha("Seth Body", 1f);
			base.Skeleton.SetAlpha("Seth glasses back", 1f);
			base.Skeleton.SetAlpha("Seth jaw", 1f);
			base.Skeleton.SetAlpha("Seth hair", 1f);
			base.Skeleton.SetAlpha("Seth eye", 1f);
			base.Skeleton.SetAlpha("Seth pupil", 1f);
			base.Skeleton.SetAlpha("Seth head", 1f);
			base.Skeleton.SetAlpha("Seth ear", 1f);
			base.Skeleton.SetAlpha("Seth fringe", 1f);
			base.Skeleton.SetAlpha("Seth Eyelid", 1f);
			base.Skeleton.SetAlpha("Seth blink", 1f);
			base.Skeleton.SetAlpha("Seth glasses top", 1f);
			base.Skeleton.SetAlpha("Seth hair cheek", 1f);
			base.Skeleton.SetAlpha("Seth arm top", 1f);
		}
	}
}
