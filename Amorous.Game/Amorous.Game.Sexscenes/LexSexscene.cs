using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Spine;

namespace Amorous.Game.Sexscenes;

public class LexSexscene : CensoredSexscene
{
	public const string _7p39D6gRnJVEL4nBpm27s7mRbMo = "Male";

	public const string _bguKzeUbXe4hujNISQZXXCW725e = "Female";

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

	public LexSexscene(ContentManager content)
		: base(content, "Assets/SexScenes/Lex/Lex Sex", "Assets/SexScenes/Lex/Background", null, list_0: Events, float_0: Censorship.Censored ? 1.5f : 1f, bool_0: true, _sa8EsNgk4VDRaASdXE7VprdlNlg_0: null, float_1: 5000f)
	{
		base.Spine.StartAnimationWithLooping("animation");
		if (Censorship.Censored)
		{
			base.Spine.X = 1000f;
			base.Spine.Y = 1600f;
		}
		else
		{
			base.Spine.X = 900f;
			base.Spine.Y = 1100f;
			base.Spine.IncreaseDuration("animation", -0.2f);
		}
	}

	public override string[] GetSkins()
	{
		if (Censorship.Censored)
		{
			return base.GetSkins();
		}
		return new string[2] { "Male", "Female" };
	}

	public override void SetSkin(string string_0)
	{
		base.SetSkin(string_0);
		if (string_0 == "Male")
		{
			base._wQSC6rD8bbXFvRxba0kr1RqxlOV = new _ecVLwNBaQAiybVyX9cgWCvnbkWe(base.Content);
			base.Spine.SetAlpha("Alex balls", 1f);
			base.Spine.SetAlpha("Alex knot", 1f);
			base.Spine.SetAlpha("Alex dick tip", 1f);
			base.Spine.SetAlpha("Alex vag", 0f);
			base.Overlays.Clear();
			base.Overlays.Add("Cum");
			base.Overlays.Add("Alex dick cum");
		}
		else if (string_0 == "Female")
		{
			base._wQSC6rD8bbXFvRxba0kr1RqxlOV = _sg4TvSTYoH0YwumBfYnvr7IeDaT._AZrO8MxMUE7cKsFYTQ4k9O3q7yC(base.Content);
			base.Spine.SetAlpha("Alex balls", 0f);
			base.Spine.SetAlpha("Alex knot", 0f);
			base.Spine.SetAlpha("Alex dick tip", 0f);
			base.Spine.SetAlpha("Alex vag", 1f);
			base.Overlays.Clear();
			base.Overlays.Add("Cum");
		}
	}

	protected override void RefreshScene(PlayerData data)
	{
		bool flag = data.GetBit("Lex.Is.Male");
		base.Spine.SetVisibility(0f);
		if (!Censorship.Censored)
		{
			base.Spine.SetAlpha("Knot back", (data.CockType == PlayerData.ECockType.Knotted) ? 1f : 0f);
			base.Spine.SetAlpha("Player cock shaft", 1f);
			base.Spine.SetAlpha("Player cock tip", 1f);
			base.Spine.SetAlpha("Knot top", (data.CockType == PlayerData.ECockType.Knotted) ? 1f : 0f);
			base.Spine.SetAlpha("Underbelly", (data.BodyType == PlayerData.EBodyType.Chubby) ? 1f : 0f);
			base.Spine.SetAlpha("Stripes", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
			base.Spine.SetAlpha("Playerbody", 1f);
			base.Spine.SetColor("Knot back", data.GenitaliaColor);
			base.Spine.SetColor("Player cock shaft", data.GenitaliaColor);
			base.Spine.SetColor("Player cock tip", (data.CockType == PlayerData.ECockType.Uncut) ? data.GenitaliaFleshColor : data.GenitaliaColor);
			base.Spine.SetColor("Knot top", data.GenitaliaColor);
			base.Spine.SetColor("Underbelly", data.UnderbellyColor);
			base.Spine.SetColor("Stripes", data.StripesColor);
			base.Spine.SetColor("Playerbody", data.BodyColor);
			base.Spine.SetAlpha("Alex tail back", 1f);
			base.Spine.SetAlpha("Alex thigh right", 1f);
			base.Spine.SetAlpha("Alex body", 1f);
			base.Spine.SetAlpha("Alex thigh left", 1f);
			base.Spine.SetAlpha("Alex neck floof", 1f);
			base.Spine.SetAlpha("Alex forearm right", 1f);
			base.Spine.SetAlpha("Alex shoulder right", 1f);
			base.Spine.SetAlpha("Alex chest", 1f);
			base.Spine.SetAlpha("Alex shoulder left", 1f);
			base.Spine.SetAlpha("Alex forearm left", 1f);
			base.Spine.SetAlpha("Alex chest poof", 1f);
			base.Spine.SetAlpha("Alex eyes back", 1f);
			base.Spine.SetAlpha("Alex pupils", 1f);
			base.Spine.SetAlpha("Alex ear left", 1f);
			base.Spine.SetAlpha("Alex ear right", 1f);
			base.Spine.SetAlpha("Alex jaw", 1f);
			base.Spine.SetAlpha("Alex tongue", 1f);
			base.Spine.SetAlpha("Alex head", 1f);
			base.Spine.SetAlpha("Alex eyelids", 1f);
			base.Spine.SetAlpha("Alex eyelash", 1f);
			base.Spine.SetAlpha("Alex muzzle", 1f);
			base.Spine.SetAlpha("Alex fringe", 1f);
			base.Spine.SetAlpha("Alex hand left", 1f);
			base.Spine.SetAlpha("Alex hand right", 1f);
			SetSkin(flag ? "Male" : "Female");
		}
		else
		{
			base.Spine.SetAlpha("Alex body", 1f);
			base.Spine.SetAlpha("Alex neck floof", 1f);
			base.Spine.SetAlpha("Alex forearm right", 1f);
			base.Spine.SetAlpha("Alex shoulder right", 1f);
			base.Spine.SetAlpha("Alex chest", 1f);
			base.Spine.SetAlpha("Alex shoulder left", 1f);
			base.Spine.SetAlpha("Alex forearm left", 1f);
			base.Spine.SetAlpha("Alex chest poof", 1f);
			base.Spine.SetAlpha("Alex eyes back", 1f);
			base.Spine.SetAlpha("Alex pupils", 1f);
			base.Spine.SetAlpha("Alex ear left", 1f);
			base.Spine.SetAlpha("Alex ear right", 1f);
			base.Spine.SetAlpha("Alex jaw", 1f);
			base.Spine.SetAlpha("Alex tongue", 1f);
			base.Spine.SetAlpha("Alex head", 1f);
			base.Spine.SetAlpha("Alex eyelids", 1f);
			base.Spine.SetAlpha("Alex eyelash", 1f);
			base.Spine.SetAlpha("Alex muzzle", 1f);
			base.Spine.SetAlpha("Alex fringe", 1f);
		}
	}
}
