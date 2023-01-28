using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Spine;

namespace Amorous.Game.Sexscenes;

public class RemySexscene : CensoredSexscene
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
			FrameTimes = new float[3] { 1.3f, 3.3f, 5.3f }
		}
	};

	public RemySexscene(ContentManager content)
		: base(content, "Assets/SexScenes/Jax/Jax Sex", "Assets/SexScenes/Remy/Background", null, list_0: Events, _sa8EsNgk4VDRaASdXE7VprdlNlg_0: _sg4TvSTYoH0YwumBfYnvr7IeDaT.Get(content), float_0: Censorship.Censored ? 1.5f : 1f, bool_0: true, cycle: 3000f)
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
			base.Spine.IncreaseDuration("animation", -0.2f);
		}
	}

	protected override void RefreshScene(PlayerData data)
	{
		base.Spine.SetVisibility(0f);
		if (Censorship.Censored)
		{
			base.Spine.SetAlpha("Remy Back Arm", 1f);
			base.Spine.SetAlpha("Remy Arm right", 1f);
			base.Spine.SetAlpha("Remy Torso", 1f);
			base.Spine.SetAlpha("Remy eyes back", 1f);
			base.Spine.SetAlpha("Remy pupils", 1f);
			base.Spine.SetAlpha("Remy jaw", 1f);
			base.Spine.SetAlpha("Remy lipbite", 1f);
			base.Spine.SetAlpha("Remy Ponytail", 1f);
			base.Spine.SetAlpha("Remy ear left", 1f);
			base.Spine.SetAlpha("Remy hair", 1f);
			base.Spine.SetAlpha("Remy ear right", 1f);
			base.Spine.SetAlpha("Remy head back", 1f);
			base.Spine.SetAlpha("Remy fringe back", 1f);
			base.Spine.SetAlpha("Remy glasses back", 1f);
			base.Spine.SetAlpha("Remy head", 1f);
			base.Spine.SetAlpha("Remy eyelids", 1f);
			base.Spine.SetAlpha("Remy eyelashes", 1f);
			base.Spine.SetAlpha("Remy glasses front", 1f);
			base.Spine.SetAlpha("Remy fringe mid", 1f);
			base.Spine.SetAlpha("Remy fringe front", 1f);
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
		base.Spine.SetAlpha("Remy Back Arm", 1f);
		base.Spine.SetAlpha("Remy Back Leg", 1f);
		base.Spine.SetAlpha("Remy Arm right", 1f);
		base.Spine.SetAlpha("Remy Vag", 1f);
		base.Spine.SetAlpha("Remy leg front", 1f);
		base.Spine.SetAlpha("Remy Belly", 1f);
		base.Spine.SetAlpha("Remy Torso", 1f);
		base.Spine.SetAlpha("Remy Breast left", 1f);
		base.Spine.SetAlpha("Remy Breast right", 1f);
		base.Spine.SetAlpha("Remy eyes back", 1f);
		base.Spine.SetAlpha("Remy pupils", 1f);
		base.Spine.SetAlpha("Remy jaw", 1f);
		base.Spine.SetAlpha("Remy lipbite", 1f);
		base.Spine.SetAlpha("Remy Ponytail", 1f);
		base.Spine.SetAlpha("Remy ear left", 1f);
		base.Spine.SetAlpha("Remy hair", 1f);
		base.Spine.SetAlpha("Remy ear right", 1f);
		base.Spine.SetAlpha("Remy head back", 1f);
		base.Spine.SetAlpha("Remy fringe back", 1f);
		base.Spine.SetAlpha("Remy glasses back", 1f);
		base.Spine.SetAlpha("Remy head", 1f);
		base.Spine.SetAlpha("Remy eyelids", 1f);
		base.Spine.SetAlpha("Remy eyelashes", 1f);
		base.Spine.SetAlpha("Remy glasses front", 1f);
		base.Spine.SetAlpha("Remy fringe mid", 1f);
		base.Spine.SetAlpha("Remy fringe front", 1f);
		base.Overlays.Add("Cum dick");
		base.Overlays.Add("Cum vag");
		base.Spine.OverlayWith("Remy Back Leg", "Player legs stripes");
	}
}
