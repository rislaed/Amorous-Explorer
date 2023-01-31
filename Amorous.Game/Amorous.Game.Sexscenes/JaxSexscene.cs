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

	public JaxSexscene(ContentManager content)
		: base(content, "Assets/SexScenes/Jax/Jax Sex", "Assets/SexScenes/Jax/Background", null, events: Events, sounds: new MaleSexsceneSounds(content), scale: Censorship.Censored ? 1.5f : 1f, premultipliedAlpha: true, cycle: 3000f)
	{
		base.Spine.StartAnimationWithLooping("animation");
		if (Censorship.Censored)
		{
			base.Spine.X = 200f;
			base.Spine.Y = 1600f;
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
		if (Censorship.Censored)
		{
			base.Spine.SetAlpha("Jax arm back", 1f);
			base.Spine.SetAlpha("Jax body", 1f);
			base.Spine.SetAlpha("Jax forearm right", 1f);
			base.Spine.SetAlpha("Jax Jaw", 1f);
			base.Spine.SetAlpha("Jax eyes", 1f);
			base.Spine.SetAlpha("Jax pupils", 1f);
			base.Spine.SetAlpha("Jax head", 1f);
			base.Spine.SetAlpha("Jax eyelids", 1f);
			base.Spine.SetAlpha("Jax eyelash", 1f);
			return;
		}
		base.Spine.SetAlpha("Player arm", 1f);
		base.Spine.SetAlpha("Player arm marking sleeve", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.LongForearm) ? 1f : 0f);
		base.Spine.SetAlpha("Player arm stripes", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
		base.Spine.SetAlpha("Player legs", 1f);
		base.Spine.SetAlpha("Player legs marking inner thighs", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underthigh) ? 1f : 0f);
		base.Spine.SetAlpha("Player legs stripes", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
		base.Spine.SetAlpha("Player cock", 1f);
		base.Spine.SetAlpha("Player Cock Knotted", (data.CockType == PlayerData.ECockType.Knotted) ? 1f : 0f);
		base.Spine.SetAlpha("Player body", 1f);
		base.Spine.SetAlpha("Player body underbelly", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
		base.Spine.SetAlpha("Boobs small", (data.BreastsType == PlayerData.EBreastsType.ACup || data.BreastsType == PlayerData.EBreastsType.BCup) ? 1f : 0f);
		base.Spine.SetAlpha("Nipples small", ((data.BreastsType == PlayerData.EBreastsType.ACup || data.BreastsType == PlayerData.EBreastsType.BCup) && data.ShowNipples) ? 1f : 0f);
		base.Spine.SetAlpha("Boobs medium", (data.BreastsType == PlayerData.EBreastsType.CCup || data.BreastsType == PlayerData.EBreastsType.DCup) ? 1f : 0f);
		base.Spine.SetAlpha("Nipples medium", ((data.BreastsType == PlayerData.EBreastsType.CCup || data.BreastsType == PlayerData.EBreastsType.DCup) && data.ShowNipples) ? 1f : 0f);
		base.Spine.SetColor("Player arm", data.BodyColor);
		base.Spine.SetColor("Player arm marking sleeve", data.LongForearmColor);
		base.Spine.SetColor("Player arm stripes", data.StripesColor);
		base.Spine.SetColor("Player legs", data.BodyColor);
		base.Spine.SetColor("Player legs marking inner thighs", data.UnderthighColor);
		base.Spine.SetColor("Player legs stripes", data.StripesColor);
		base.Spine.SetColor("Player cock", data.GenitaliaColor);
		base.Spine.SetColor("Player Cock Knotted", data.GenitaliaColor);
		base.Spine.SetColor("Player body", data.BodyColor);
		base.Spine.SetColor("Player body underbelly", data.UnderbellyColor);
		base.Spine.SetColor("Boobs small", data.BreastsColor);
		base.Spine.SetColor("Nipples small", data.NipplesColor);
		base.Spine.SetColor("Boobs medium", data.BreastsColor);
		base.Spine.SetColor("Nipples medium", data.NipplesColor);
		base.Spine.SetAlpha("Picnic blanket", 1f);
		base.Spine.SetAlpha("Jax tail", 1f);
		base.Spine.SetAlpha("Jax arm back", 1f);
		base.Spine.SetAlpha("Jax body", 1f);
		base.Spine.SetAlpha("Jax leg top", 1f);
		base.Spine.SetAlpha("Jax leg bottom", 1f);
		base.Spine.SetAlpha("Jax forearm right", 1f);
		base.Spine.SetAlpha("Jax cock", 1f);
		base.Spine.SetAlpha("Jax balls", 1f);
		base.Spine.SetAlpha("Jax Jaw", 1f);
		base.Spine.SetAlpha("Jax eyes", 1f);
		base.Spine.SetAlpha("Jax pupils", 1f);
		base.Spine.SetAlpha("Jax head", 1f);
		base.Spine.SetAlpha("Jax eyelids", 1f);
		base.Spine.SetAlpha("Jax eyelash", 1f);
		base.ExplosionBones.Add("Cum dick");
		base.Spine.OverlayWith("Cum dick", "Player Cock Knotted");
	}
}
