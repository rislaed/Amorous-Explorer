using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
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
			EventName = "ThrustStart",
			FrameTimes = new float[6] { 1f, 2f, 3f, 4f, 5f, 6f }
		},
		new SkeletonJson.SpineEvent
		{
			AnimationName = "animation",
			EventName = "ThrustEnd",
			FrameTimes = new float[6] { 1.2f, 2.2f, 3.2f, 4.2f, 5.2f, 6.2f }
		},
		new SkeletonJson.SpineEvent
		{
			AnimationName = "animation",
			EventName = "Moan",
			FrameTimes = new float[6] { 1.3f, 2.3f, 3.3f, 4.3f, 5.3f, 6.3f }
		}
	};

	public SethSexscene(ContentManager content)
		: base(content, "Assets/SexScenes/Seth/Seth Sex", "Assets/SexScenes/Seth/Background", null, list_0: Events, _sa8EsNgk4VDRaASdXE7VprdlNlg_0: new _ecVLwNBaQAiybVyX9cgWCvnbkWe(content), float_0: Censorship.Censored ? 1.3f : 1f, bool_0: true, float_1: 5000f)
	{
		base.Spine.StartAnimationWithLooping("animation");
		if (!Censorship.Censored)
		{
			base.Spine.X = 810f;
			base.Spine.Y = 1070f;
			base.Spine.IncreaseDuration("animation", -0.3f);
		}
		else
		{
			base.Spine.X = 150f;
			base.Spine.Y = 1500f;
		}
	}

	protected override void RefreshScene(PlayerData data)
	{
		base.Spine.SetVisibility(0f);
		if (!Censorship.Censored)
		{
			base.Spine.SetAlpha("Tail long thick", (data.TailType == PlayerData.ETailType.BushyOne || data.TailType == PlayerData.ETailType.BushyTwo || data.TailType == PlayerData.ETailType.Plume || data.TailType == PlayerData.ETailType.Noodle || data.TailType == PlayerData.ETailType.Stout || data.TailType == PlayerData.ETailType.Thick) ? 1f : 0f);
			base.Spine.SetAlpha("Tail long thin", (data.TailType == PlayerData.ETailType.Thin) ? 1f : 0f);
			base.Spine.SetAlpha("Seth arm back", 1f);
			base.Spine.SetAlpha("Seth Body", 1f);
			base.Spine.SetAlpha("Player leg back", 1f);
			base.Spine.SetAlpha("Player leg back stripes", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
			base.Spine.SetAlpha("Seth leg back", 1f);
			base.Spine.SetAlpha("Seth glasses back", 1f);
			base.Spine.SetAlpha("Seth jaw", 1f);
			base.Spine.SetAlpha("Seth hair", 1f);
			base.Spine.SetAlpha("Seth eye", 1f);
			base.Spine.SetAlpha("Seth pupil", 1f);
			base.Spine.SetAlpha("Seth head", 1f);
			base.Spine.SetAlpha("Seth ear", 1f);
			base.Spine.SetAlpha("Seth fringe", 1f);
			base.Spine.SetAlpha("Seth Eyelid", 1f);
			base.Spine.SetAlpha("Seth blink", 1f);
			base.Spine.SetAlpha("Seth glasses top", 1f);
			base.Spine.SetAlpha("Seth hair cheek", 1f);
			base.Spine.SetAlpha("Seth arm top", 1f);
			base.Spine.SetAlpha("Player Body", 1f);
			base.Spine.SetAlpha("Player Body underbelly", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
			base.Spine.SetAlpha("Player knee", 1f);
			base.Spine.SetAlpha("Player knee stripes", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
			base.Spine.SetAlpha("Player knee marking sleeve long", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.LongShin) ? 1f : 0f);
			base.Spine.SetAlpha("Player balls", 1f);
			base.Spine.SetAlpha("Player balls underbelly", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
			base.Spine.SetAlpha("Player cock", 1f);
			base.Spine.SetAlpha("Player cock knot", (data.CockType == PlayerData.ECockType.Knotted) ? 1f : 0f);
			base.Spine.SetAlpha("Player balls top", 1f);
			base.Spine.SetAlpha("Player balls top underbelly", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
			base.Spine.SetAlpha("Seth balls", 1f);
			base.Spine.SetAlpha("Seth Tail top", 1f);
			base.Spine.SetAlpha("Player arm", 1f);
			base.Spine.SetAlpha("Player arm marking sleeve long", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.LongForearm) ? 1f : 0f);
			base.Spine.SetAlpha("Player arm stripes", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
			base.Spine.SetAlpha("Seth tail back", 1f);
			base.Spine.SetAlpha("Seth leg top", 1f);
			base.Spine.SetAlpha("Player leg top", 1f);
			base.Spine.SetAlpha("Player leg top stripes", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
			base.Spine.SetAlpha("Seth shin", 1f);
			base.Spine.SetColor("Tail long thick", data.TailColor);
			base.Spine.SetColor("Tail long thin", data.TailColor);
			base.Spine.SetColor("Player leg back", data.BodyColor);
			base.Spine.SetColor("Player leg back stripes", data.StripesColor);
			base.Spine.SetColor("Player Body", data.BodyColor);
			base.Spine.SetColor("Player Body underbelly", data.UnderbellyColor);
			base.Spine.SetColor("Player knee", data.BodyColor);
			base.Spine.SetColor("Player knee stripes", data.StripesColor);
			base.Spine.SetColor("Player knee marking sleeve long", data.LongShinColor);
			base.Spine.SetColor("Player balls", data.BallsColor);
			base.Spine.SetColor("Player balls underbelly", data.UnderbellyColor);
			base.Spine.SetColor("Player cock", data.GenitaliaColor);
			base.Spine.SetColor("Player cock knot", data.GenitaliaColor);
			base.Spine.SetColor("Player balls top", data.BallsColor);
			base.Spine.SetColor("Player balls top underbelly", data.UnderbellyColor);
			base.Spine.SetColor("Player arm", data.BodyColor);
			base.Spine.SetColor("Player arm marking sleeve long", data.LongForearmColor);
			base.Spine.SetColor("Player arm stripes", data.StripesColor);
			base.Spine.SetColor("Player leg top", data.BodyColor);
			base.Spine.SetColor("Player leg top stripes", data.StripesColor);
			base.Overlays.Add("Cum cock bottom");
			base.Overlays.Add("Cum cock top");
			base.Overlays.Add("Cum Buttcheek");
		}
		else
		{
			base.Spine.SetAlpha("Seth arm back", 1f);
			base.Spine.SetAlpha("Seth Body", 1f);
			base.Spine.SetAlpha("Seth glasses back", 1f);
			base.Spine.SetAlpha("Seth jaw", 1f);
			base.Spine.SetAlpha("Seth hair", 1f);
			base.Spine.SetAlpha("Seth eye", 1f);
			base.Spine.SetAlpha("Seth pupil", 1f);
			base.Spine.SetAlpha("Seth head", 1f);
			base.Spine.SetAlpha("Seth ear", 1f);
			base.Spine.SetAlpha("Seth fringe", 1f);
			base.Spine.SetAlpha("Seth Eyelid", 1f);
			base.Spine.SetAlpha("Seth blink", 1f);
			base.Spine.SetAlpha("Seth glasses top", 1f);
			base.Spine.SetAlpha("Seth hair cheek", 1f);
			base.Spine.SetAlpha("Seth arm top", 1f);
		}
	}
}
