using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;
using Spine;

namespace Amorous.Game.Sexscenes;

public class CobySexscene : CensoredSexscene
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

	public CobySexscene(ContentManager content)
		: base(content, "Assets/SexScenes/Coby/Coby Sex", "Assets/SexScenes/Coby/Background", null, events: Events, sounds: MaleSexsceneSounds.GetSingleton(content), scale: Censorship.Censored ? 1.5f : 1f, premultipliedAlpha: true, cycle: 3000f)
	{
		base.Skeleton.StartAnimationWithLooping("animation");
		if (!Censorship.Censored)
		{
			base.Skeleton.X = 900f;
			base.Skeleton.Y = 1050f;
			base.Skeleton.IncreaseDuration("animation", -0.3f);
		}
		else
		{
			base.Skeleton.X = 1700f;
			base.Skeleton.Y = 1700f;
		}
	}

	protected override void RefreshInternal(PlayerData data)
	{
		base.Skeleton.SetVisibility(0f);
		if (Censorship.Censored)
		{
			base.Skeleton.SetAlpha("Coby Body", 1f);
			base.Skeleton.SetAlpha("Coby jaw", 1f);
			base.Skeleton.SetAlpha("Coby eye", 1f);
			base.Skeleton.SetAlpha("Coby pupil", 1f);
			base.Skeleton.SetAlpha("Coby head", 1f);
			base.Skeleton.SetAlpha("Coby eyelid", 1f);
			base.Skeleton.SetAlpha("Coby Shoulder", 1f);
			return;
		}
		base.Skeleton.SetAlpha("Coby Body", 1f);
		base.Skeleton.SetAlpha("Coby leg back", 1f);
		base.Skeleton.SetAlpha("Player leg back", 1f);
		base.Skeleton.SetAlpha("Player leg back underbelly", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
		base.Skeleton.SetAlpha("Player leg back high sleeve", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underthigh) ? 1f : 0f);
		base.Skeleton.SetAlpha("Player leg back stripes", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
		base.Skeleton.SetAlpha("Player taint", 1f);
		base.Skeleton.SetAlpha("Player taint underbelly", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
		base.Skeleton.SetAlpha("Coby jaw", 1f);
		base.Skeleton.SetAlpha("Coby eye", 1f);
		base.Skeleton.SetAlpha("Coby pupil", 1f);
		base.Skeleton.SetAlpha("Coby head", 1f);
		base.Skeleton.SetAlpha("Coby eyelid", 1f);
		base.Skeleton.SetAlpha("Player arm", 1f);
		base.Skeleton.SetAlpha("Player arm stripes", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
		base.Skeleton.SetAlpha("Coby Shoulder", 1f);
		base.Skeleton.SetAlpha("Player forearm", 1f);
		base.Skeleton.SetAlpha("Player forearm shortlong sleeve", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.ShortForearm) ? 1f : 0f);
		base.Skeleton.SetAlpha("Player forearm stripes", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
		base.Skeleton.SetAlpha("Coby balls", 1f);
		base.Skeleton.SetAlpha("Player balls back", 1f);
		base.Skeleton.SetAlpha("Player balls back underbelly", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
		base.Skeleton.SetAlpha("Player cock", 1f);
		base.Skeleton.SetAlpha("Player cock knot", (data.CockType == PlayerData.ECockType.Knotted) ? 1f : 0f);
		base.Skeleton.SetAlpha("Player balls top", 1f);
		base.Skeleton.SetAlpha("Player balls top underbelly", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
		base.Skeleton.SetAlpha("Coby taint", 1f);
		base.Skeleton.SetAlpha("Coby tail", 1f);
		base.Skeleton.SetAlpha("Coby leg top", 1f);
		base.Skeleton.SetAlpha("Coby thigh top", 1f);
		base.Skeleton.SetAlpha("Player leg top", 1f);
		base.Skeleton.SetAlpha("Player leg top underbelly", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
		base.Skeleton.SetAlpha("Player leg top stripes", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
		base.Skeleton.SetAlpha("Player hand", 1f);
		base.Skeleton.SetAlpha("Player hand shortlong sleeve", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.ShortForearm) ? 1f : 0f);
		base.Skeleton.SetAlpha("Player nails", data.ShowNails ? 1f : 0f);
		base.Skeleton.SetColor("Player leg back", data.BodyColor);
		base.Skeleton.SetColor("Player leg back underbelly", data.UnderbellyColor);
		base.Skeleton.SetColor("Player leg back high sleeve", data.UnderthighColor);
		base.Skeleton.SetColor("Player leg back stripes", data.StripesColor);
		base.Skeleton.SetColor("Player taint", data.BodyColor);
		base.Skeleton.SetColor("Player taint underbelly", data.UnderbellyColor);
		base.Skeleton.SetColor("Player arm", data.BodyColor);
		base.Skeleton.SetColor("Player arm stripes", data.StripesColor);
		base.Skeleton.SetColor("Player forearm", data.BodyColor);
		base.Skeleton.SetColor("Player forearm shortlong sleeve", data.ShortForearmColor);
		base.Skeleton.SetColor("Player forearm stripes", data.StripesColor);
		base.Skeleton.SetColor("Player balls back", data.BallsColor);
		base.Skeleton.SetColor("Player balls back underbelly", data.UnderbellyColor);
		base.Skeleton.SetColor("Player cock", data.GenitaliaColor);
		base.Skeleton.SetColor("Player cock knot", data.GenitaliaColor);
		base.Skeleton.SetColor("Player balls top", data.BallsColor);
		base.Skeleton.SetColor("Player balls top underbelly", data.UnderbellyColor);
		base.Skeleton.SetColor("Player leg top", data.BodyColor);
		base.Skeleton.SetColor("Player leg top underbelly", data.UnderbellyColor);
		base.Skeleton.SetColor("Player leg top stripes", data.StripesColor);
		base.Skeleton.SetColor("Player hand", data.BodyColor);
		base.Skeleton.SetColor("Player hand shortlong sleeve", data.ShortForearmColor);
		base.Skeleton.SetColor("Player nails", data.NailColor);
		base.ExplosionSlots.Add("Cum butt back");
		base.ExplosionSlots.Add("Cum cock");
		base.ExplosionSlots.Add("Cum butt top");
	}
}
