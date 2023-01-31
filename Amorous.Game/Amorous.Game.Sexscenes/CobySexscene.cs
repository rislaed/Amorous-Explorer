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

	public CobySexscene(ContentManager content)
		: base(content, "Assets/SexScenes/Coby/Coby Sex", "Assets/SexScenes/Coby/Background", null, events: Events, sounds: new MaleSexsceneSounds(content), scale: Censorship.Censored ? 1.5f : 1f, premultipliedAlpha: true, cycle: 3000f)
	{
		base.Spine.StartAnimationWithLooping("animation");
		if (!Censorship.Censored)
		{
			base.Spine.X = 900f;
			base.Spine.Y = 1050f;
			base.Spine.IncreaseDuration("animation", -0.3f);
		}
		else
		{
			base.Spine.X = 1700f;
			base.Spine.Y = 1700f;
		}
	}

	protected override void RefreshData(PlayerData data)
	{
		base.Spine.SetVisibility(0f);
		if (Censorship.Censored)
		{
			base.Spine.SetAlpha("Coby Body", 1f);
			base.Spine.SetAlpha("Coby jaw", 1f);
			base.Spine.SetAlpha("Coby eye", 1f);
			base.Spine.SetAlpha("Coby pupil", 1f);
			base.Spine.SetAlpha("Coby head", 1f);
			base.Spine.SetAlpha("Coby eyelid", 1f);
			base.Spine.SetAlpha("Coby Shoulder", 1f);
			return;
		}
		base.Spine.SetAlpha("Coby Body", 1f);
		base.Spine.SetAlpha("Coby leg back", 1f);
		base.Spine.SetAlpha("Player leg back", 1f);
		base.Spine.SetAlpha("Player leg back underbelly", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
		base.Spine.SetAlpha("Player leg back high sleeve", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underthigh) ? 1f : 0f);
		base.Spine.SetAlpha("Player leg back stripes", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
		base.Spine.SetAlpha("Player taint", 1f);
		base.Spine.SetAlpha("Player taint underbelly", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
		base.Spine.SetAlpha("Coby jaw", 1f);
		base.Spine.SetAlpha("Coby eye", 1f);
		base.Spine.SetAlpha("Coby pupil", 1f);
		base.Spine.SetAlpha("Coby head", 1f);
		base.Spine.SetAlpha("Coby eyelid", 1f);
		base.Spine.SetAlpha("Player arm", 1f);
		base.Spine.SetAlpha("Player arm stripes", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
		base.Spine.SetAlpha("Coby Shoulder", 1f);
		base.Spine.SetAlpha("Player forearm", 1f);
		base.Spine.SetAlpha("Player forearm shortlong sleeve", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.ShortForearm) ? 1f : 0f);
		base.Spine.SetAlpha("Player forearm stripes", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
		base.Spine.SetAlpha("Coby balls", 1f);
		base.Spine.SetAlpha("Player balls back", 1f);
		base.Spine.SetAlpha("Player balls back underbelly", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
		base.Spine.SetAlpha("Player cock", 1f);
		base.Spine.SetAlpha("Player cock knot", (data.CockType == PlayerData.ECockType.Knotted) ? 1f : 0f);
		base.Spine.SetAlpha("Player balls top", 1f);
		base.Spine.SetAlpha("Player balls top underbelly", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
		base.Spine.SetAlpha("Coby taint", 1f);
		base.Spine.SetAlpha("Coby tail", 1f);
		base.Spine.SetAlpha("Coby leg top", 1f);
		base.Spine.SetAlpha("Coby thigh top", 1f);
		base.Spine.SetAlpha("Player leg top", 1f);
		base.Spine.SetAlpha("Player leg top underbelly", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
		base.Spine.SetAlpha("Player leg top stripes", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
		base.Spine.SetAlpha("Player hand", 1f);
		base.Spine.SetAlpha("Player hand shortlong sleeve", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.ShortForearm) ? 1f : 0f);
		base.Spine.SetAlpha("Player nails", data.ShowNails ? 1f : 0f);
		base.Spine.SetColor("Player leg back", data.BodyColor);
		base.Spine.SetColor("Player leg back underbelly", data.UnderbellyColor);
		base.Spine.SetColor("Player leg back high sleeve", data.UnderthighColor);
		base.Spine.SetColor("Player leg back stripes", data.StripesColor);
		base.Spine.SetColor("Player taint", data.BodyColor);
		base.Spine.SetColor("Player taint underbelly", data.UnderbellyColor);
		base.Spine.SetColor("Player arm", data.BodyColor);
		base.Spine.SetColor("Player arm stripes", data.StripesColor);
		base.Spine.SetColor("Player forearm", data.BodyColor);
		base.Spine.SetColor("Player forearm shortlong sleeve", data.ShortForearmColor);
		base.Spine.SetColor("Player forearm stripes", data.StripesColor);
		base.Spine.SetColor("Player balls back", data.BallsColor);
		base.Spine.SetColor("Player balls back underbelly", data.UnderbellyColor);
		base.Spine.SetColor("Player cock", data.GenitaliaColor);
		base.Spine.SetColor("Player cock knot", data.GenitaliaColor);
		base.Spine.SetColor("Player balls top", data.BallsColor);
		base.Spine.SetColor("Player balls top underbelly", data.UnderbellyColor);
		base.Spine.SetColor("Player leg top", data.BodyColor);
		base.Spine.SetColor("Player leg top underbelly", data.UnderbellyColor);
		base.Spine.SetColor("Player leg top stripes", data.StripesColor);
		base.Spine.SetColor("Player hand", data.BodyColor);
		base.Spine.SetColor("Player hand shortlong sleeve", data.ShortForearmColor);
		base.Spine.SetColor("Player nails", data.NailColor);
		base.ExplosionBones.Add("Cum butt back");
		base.ExplosionBones.Add("Cum cock");
		base.ExplosionBones.Add("Cum butt top");
	}
}
