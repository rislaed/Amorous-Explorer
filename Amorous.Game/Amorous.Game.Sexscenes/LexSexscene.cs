using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;
using Spine;

namespace Amorous.Game.Sexscenes;

public class LexSexscene : CensoredSexscene
{
	public const string SKIN_MALE = "Male";
	public const string SKIN_FEMALE = "Female";

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

	public LexSexscene(ContentManager content)
		: base(content, "Assets/SexScenes/Lex/Lex Sex", "Assets/SexScenes/Lex/Background", null, events: Events, scale: Censorship.Censored ? 1.5f : 1f, premultipliedAlpha: true, sounds: null, cycle: 5000f)
	{
		base.Skeleton.StartAnimationWithLooping("animation");
		if (Censorship.Censored)
		{
			base.Skeleton.X = 1000f;
			base.Skeleton.Y = 1600f;
		}
		else
		{
			base.Skeleton.X = 900f;
			base.Skeleton.Y = 1100f;
			base.Skeleton.IncreaseDuration("animation", -0.2f);
		}
	}

	public override string[] GetSubscenes()
	{
		if (Censorship.Censored)
		{
			return base.GetSubscenes();
		}
		return new string[2] { SKIN_MALE, SKIN_FEMALE };
	}

	public override void SwitchToSubscene(string subscene)
	{
		base.SwitchToSubscene(subscene);
		if (subscene == SKIN_MALE)
		{
			base.Sounds = MaleSexsceneSounds.GetSingleton(base.Content);
			base.Skeleton.SetAlpha("Alex balls", 1f);
			base.Skeleton.SetAlpha("Alex knot", 1f);
			base.Skeleton.SetAlpha("Alex dick tip", 1f);
			base.Skeleton.SetAlpha("Alex vag", 0f);
			base.ExplosionSlots.Clear();
			base.ExplosionSlots.Add("Cum");
			base.ExplosionSlots.Add("Alex dick cum");
		}
		else if (subscene == SKIN_FEMALE)
		{
			base.Sounds = FemaleSexsceneSounds.GetSingleton(base.Content);
			base.Skeleton.SetAlpha("Alex balls", 0f);
			base.Skeleton.SetAlpha("Alex knot", 0f);
			base.Skeleton.SetAlpha("Alex dick tip", 0f);
			base.Skeleton.SetAlpha("Alex vag", 1f);
			base.Skeleton.SetAlpha("Alex dick cum", 0f);
			base.ExplosionSlots.Clear();
			base.ExplosionSlots.Add("Cum");
		}
	}

	protected override void RefreshInternal(PlayerData data)
	{
		bool isMale = data.HasFlag(AmorousData.LexIsMale);
		base.Skeleton.SetVisibility(0f);
		if (!Censorship.Censored)
		{
			base.Skeleton.SetAlpha("Knot back", (data.CockType == PlayerData.ECockType.Knotted) ? 1f : 0f);
			base.Skeleton.SetAlpha("Player cock shaft", 1f);
			base.Skeleton.SetAlpha("Player cock tip", 1f);
			base.Skeleton.SetAlpha("Knot top", (data.CockType == PlayerData.ECockType.Knotted) ? 1f : 0f);
			base.Skeleton.SetAlpha("Underbelly", (data.BodyType == PlayerData.EBodyType.Chubby) ? 1f : 0f);
			base.Skeleton.SetAlpha("Stripes", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
			base.Skeleton.SetAlpha("Playerbody", 1f);
			base.Skeleton.SetColor("Knot back", data.GenitaliaColor);
			base.Skeleton.SetColor("Player cock shaft", data.GenitaliaColor);
			base.Skeleton.SetColor("Player cock tip", (data.CockType == PlayerData.ECockType.Uncut) ? data.GenitaliaFleshColor : data.GenitaliaColor);
			base.Skeleton.SetColor("Knot top", data.GenitaliaColor);
			base.Skeleton.SetColor("Underbelly", data.UnderbellyColor);
			base.Skeleton.SetColor("Stripes", data.StripesColor);
			base.Skeleton.SetColor("Playerbody", data.BodyColor);
			base.Skeleton.SetAlpha("Alex tail back", 1f);
			base.Skeleton.SetAlpha("Alex thigh right", 1f);
			base.Skeleton.SetAlpha("Alex body", 1f);
			base.Skeleton.SetAlpha("Alex thigh left", 1f);
			base.Skeleton.SetAlpha("Alex neck floof", 1f);
			base.Skeleton.SetAlpha("Alex forearm right", 1f);
			base.Skeleton.SetAlpha("Alex shoulder right", 1f);
			base.Skeleton.SetAlpha("Alex chest", 1f);
			base.Skeleton.SetAlpha("Alex shoulder left", 1f);
			base.Skeleton.SetAlpha("Alex forearm left", 1f);
			base.Skeleton.SetAlpha("Alex chest poof", 1f);
			base.Skeleton.SetAlpha("Alex eyes back", 1f);
			base.Skeleton.SetAlpha("Alex pupils", 1f);
			base.Skeleton.SetAlpha("Alex ear left", 1f);
			base.Skeleton.SetAlpha("Alex ear right", 1f);
			base.Skeleton.SetAlpha("Alex jaw", 1f);
			base.Skeleton.SetAlpha("Alex tongue", 1f);
			base.Skeleton.SetAlpha("Alex head", 1f);
			base.Skeleton.SetAlpha("Alex eyelids", 1f);
			base.Skeleton.SetAlpha("Alex eyelash", 1f);
			base.Skeleton.SetAlpha("Alex muzzle", 1f);
			base.Skeleton.SetAlpha("Alex fringe", 1f);
			base.Skeleton.SetAlpha("Alex hand left", 1f);
			base.Skeleton.SetAlpha("Alex hand right", 1f);
			SwitchToSubscene(isMale ? SKIN_MALE : SKIN_FEMALE);
		}
		else
		{
			base.Skeleton.SetAlpha("Alex body", 1f);
			base.Skeleton.SetAlpha("Alex neck floof", 1f);
			base.Skeleton.SetAlpha("Alex forearm right", 1f);
			base.Skeleton.SetAlpha("Alex shoulder right", 1f);
			base.Skeleton.SetAlpha("Alex chest", 1f);
			base.Skeleton.SetAlpha("Alex shoulder left", 1f);
			base.Skeleton.SetAlpha("Alex forearm left", 1f);
			base.Skeleton.SetAlpha("Alex chest poof", 1f);
			base.Skeleton.SetAlpha("Alex eyes back", 1f);
			base.Skeleton.SetAlpha("Alex pupils", 1f);
			base.Skeleton.SetAlpha("Alex ear left", 1f);
			base.Skeleton.SetAlpha("Alex ear right", 1f);
			base.Skeleton.SetAlpha("Alex jaw", 1f);
			base.Skeleton.SetAlpha("Alex tongue", 1f);
			base.Skeleton.SetAlpha("Alex head", 1f);
			base.Skeleton.SetAlpha("Alex eyelids", 1f);
			base.Skeleton.SetAlpha("Alex eyelash", 1f);
			base.Skeleton.SetAlpha("Alex muzzle", 1f);
			base.Skeleton.SetAlpha("Alex fringe", 1f);
		}
	}
}
