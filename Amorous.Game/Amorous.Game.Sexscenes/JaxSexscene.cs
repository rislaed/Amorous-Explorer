using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;
using Spine;

namespace Amorous.Game.Sexscenes;

public class JaxSexscene : CensoredSexscene
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

	public JaxSexscene(ContentManager content)
		: base(content, "Assets/SexScenes/Jax/Jax Sex", "Assets/SexScenes/Jax/Background", null, events: Events, sounds: MaleSexsceneSounds.GetSingleton(content), scale: Censorship.Censored ? 1.5f : 1f, premultipliedAlpha: true, cycle: 3000f)
	{
		base.Skeleton.StartAnimationWithLooping("animation");
		if (Censorship.Censored)
		{
			base.Skeleton.X = 200f;
			base.Skeleton.Y = 1600f;
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
		if (Censorship.Censored)
		{
			base.Skeleton.SetAlpha("Jax arm back", 1f);
			base.Skeleton.SetAlpha("Jax body", 1f);
			base.Skeleton.SetAlpha("Jax forearm right", 1f);
			base.Skeleton.SetAlpha("Jax Jaw", 1f);
			base.Skeleton.SetAlpha("Jax eyes", 1f);
			base.Skeleton.SetAlpha("Jax pupils", 1f);
			base.Skeleton.SetAlpha("Jax head", 1f);
			base.Skeleton.SetAlpha("Jax eyelids", 1f);
			base.Skeleton.SetAlpha("Jax eyelash", 1f);
			return;
		}
		base.Skeleton.SetAlpha("Player arm", 1f);
		base.Skeleton.SetAlpha("Player arm marking sleeve", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.LongForearm) ? 1f : 0f);
		base.Skeleton.SetAlpha("Player arm stripes", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
		base.Skeleton.SetAlpha("Player legs", 1f);
		base.Skeleton.SetAlpha("Player legs marking inner thighs", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underthigh) ? 1f : 0f);
		base.Skeleton.SetAlpha("Player legs stripes", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
		base.Skeleton.SetAlpha("Player cock", 1f);
		base.Skeleton.SetAlpha("Player Cock Knotted", (data.CockType == PlayerData.ECockType.Knotted) ? 1f : 0f);
		base.Skeleton.SetAlpha("Player body", 1f);
		base.Skeleton.SetAlpha("Player body underbelly", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
		base.Skeleton.SetAlpha("Boobs small", (data.BreastsType == PlayerData.EBreastsType.ACup || data.BreastsType == PlayerData.EBreastsType.BCup) ? 1f : 0f);
		base.Skeleton.SetAlpha("Nipples small", ((data.BreastsType == PlayerData.EBreastsType.ACup || data.BreastsType == PlayerData.EBreastsType.BCup) && data.ShowNipples) ? 1f : 0f);
		base.Skeleton.SetAlpha("Boobs medium", (data.BreastsType == PlayerData.EBreastsType.CCup || data.BreastsType == PlayerData.EBreastsType.DCup) ? 1f : 0f);
		base.Skeleton.SetAlpha("Nipples medium", ((data.BreastsType == PlayerData.EBreastsType.CCup || data.BreastsType == PlayerData.EBreastsType.DCup) && data.ShowNipples) ? 1f : 0f);
		base.Skeleton.SetColor("Player arm", data.BodyColor);
		base.Skeleton.SetColor("Player arm marking sleeve", data.LongForearmColor);
		base.Skeleton.SetColor("Player arm stripes", data.StripesColor);
		base.Skeleton.SetColor("Player legs", data.BodyColor);
		base.Skeleton.SetColor("Player legs marking inner thighs", data.UnderthighColor);
		base.Skeleton.SetColor("Player legs stripes", data.StripesColor);
		base.Skeleton.SetColor("Player cock", data.GenitaliaColor);
		base.Skeleton.SetColor("Player Cock Knotted", data.GenitaliaColor);
		base.Skeleton.SetColor("Player body", data.BodyColor);
		base.Skeleton.SetColor("Player body underbelly", data.UnderbellyColor);
		base.Skeleton.SetColor("Boobs small", data.BreastsColor);
		base.Skeleton.SetColor("Nipples small", data.NipplesColor);
		base.Skeleton.SetColor("Boobs medium", data.BreastsColor);
		base.Skeleton.SetColor("Nipples medium", data.NipplesColor);
		base.Skeleton.SetAlpha("Picnic blanket", 1f);
		base.Skeleton.SetAlpha("Jax tail", 1f);
		base.Skeleton.SetAlpha("Jax arm back", 1f);
		base.Skeleton.SetAlpha("Jax body", 1f);
		base.Skeleton.SetAlpha("Jax leg top", 1f);
		base.Skeleton.SetAlpha("Jax leg bottom", 1f);
		base.Skeleton.SetAlpha("Jax forearm right", 1f);
		base.Skeleton.SetAlpha("Jax cock", 1f);
		base.Skeleton.SetAlpha("Jax balls", 1f);
		base.Skeleton.SetAlpha("Jax Jaw", 1f);
		base.Skeleton.SetAlpha("Jax eyes", 1f);
		base.Skeleton.SetAlpha("Jax pupils", 1f);
		base.Skeleton.SetAlpha("Jax head", 1f);
		base.Skeleton.SetAlpha("Jax eyelids", 1f);
		base.Skeleton.SetAlpha("Jax eyelash", 1f);
		base.ExplosionSlots.Add("Cum dick");
		base.Skeleton.OverlayWith("Cum dick", "Player Cock Knotted");
	}
}
