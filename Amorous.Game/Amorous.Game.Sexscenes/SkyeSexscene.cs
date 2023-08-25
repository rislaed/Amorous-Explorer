using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Spine;

namespace Amorous.Game.Sexscenes;

public class SkyeSexscene : CensoredSexscene
{
	public const string SKIN_GRAY = "Gray";
	public const string SKIN_YELLOW = "Yellow";
	public const string SKIN_BLUE = "Blue";

	private Texture2D textureGray;
	private Texture2D textureYellow;
	private Texture2D textureBlue;

	private static readonly List<SkeletonJson.SpineEvent> Events = new List<SkeletonJson.SpineEvent>
	{
		new SkeletonJson.SpineEvent
		{
			AnimationName = "Sex",
			EventName = EVENT_THRUST_START,
			FrameTimes = new float[6] { 1f, 2f, 3f, 4f, 5f, 6f }
		},
		new SkeletonJson.SpineEvent
		{
			AnimationName = "Sex",
			EventName = EVENT_THRUST_END,
			FrameTimes = new float[6] { 1.2f, 2.2f, 3.2f, 4.2f, 5.2f, 6.2f }
		},
		new SkeletonJson.SpineEvent
		{
			AnimationName = "Sex",
			EventName = EVENT_MOAN,
			FrameTimes = new float[6] { 1.3f, 2.3f, 3.3f, 4.3f, 5.3f, 6.3f }
		}
	};

	public SkyeSexscene(ContentManager content)
		: base(content, "Assets/SexScenes/Skye/Skye Sex", "Assets/SexScenes/Skye/Background", null, events: Events, sounds: FemaleSexsceneSounds.GetSingleton(content), scale: Censorship.Censored ? 2f : 1f, premultipliedAlpha: true, cycle: 3000f)
	{
		base.Skeleton.StartAnimationWithLooping("Sex");
		if (Censorship.Censored)
		{
			base.Skeleton.X = 1500f;
			base.Skeleton.Y = 2000f;
		}
		else
		{
			base.Skeleton.X = 950f;
			base.Skeleton.Y = 1100f;
		}
		textureGray = content.Load<Texture2D>("Assets/SexScenes/Skye/Skye Sex");
		textureYellow = content.Load<Texture2D>("Assets/SexScenes/Skye/Skye Sex Yellow");
		textureBlue = content.Load<Texture2D>("Assets/SexScenes/Skye/Skye Sex Blue");
		PlayerData data = PlayerPreferences.GetPlayerData();
		bool isYellow = data.HasFlag(AmorousData.SkyeSkinYellow);
		bool isBlue = data.HasFlag(AmorousData.SkyeSkinBlue);
		if (!(isYellow && isBlue))
		{
			if (isYellow)
			{
				SwitchToSubscene(SKIN_YELLOW);
			}
			else if (isBlue)
			{
				SwitchToSubscene(SKIN_BLUE);
			}
			else
			{
				SwitchToSubscene(SKIN_GRAY);
			}
		}
		else
		{
			SwitchToSubscene(SKIN_GRAY);
		}
	}

	public override string[] GetSubscenes()
	{
		return new string[3] { SKIN_GRAY, SKIN_YELLOW, SKIN_BLUE };
	}

	public override void SwitchToSubscene(string subscene)
	{
		base.SwitchToSubscene(subscene);
		switch (subscene)
		{
			case SKIN_GRAY:
				base.Texture = textureGray;
				break;
			case SKIN_YELLOW:
				base.Texture = textureYellow;
				break;
			case SKIN_BLUE:
				base.Texture = textureBlue;
				break;
		}
	}

	protected override void RefreshInternal(PlayerData data)
	{
		base.Skeleton.SetVisibility(0f);
		if (!Censorship.Censored)
		{
			base.Skeleton.SetAlpha("Skye shin back", 1f);
			base.Skeleton.SetAlpha("Player thigh right", 1f);
			base.Skeleton.SetAlpha("Player stripe right", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
			base.Skeleton.SetAlpha("Player underthigh right", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underthigh) ? 1f : 0f);
			base.Skeleton.SetAlpha("Player thigh left", 1f);
			base.Skeleton.SetAlpha("Player stripe left", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
			base.Skeleton.SetAlpha("Player underthigh left", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underthigh) ? 1f : 0f);
			base.Skeleton.SetAlpha("Player cock", 1f);
			base.Skeleton.SetAlpha("Player body", 1f);
			base.Skeleton.SetAlpha("Player belly stripes", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
			base.Skeleton.SetAlpha("Player underbelly", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
			base.Skeleton.SetAlpha("Player knot", (data.CockType == PlayerData.ECockType.Knotted) ? 1f : 0f);
			base.Skeleton.SetAlpha("Skye tail", 1f);
			base.Skeleton.SetAlpha("Skye thigh left", 1f);
			base.Skeleton.SetAlpha("Skye body", 1f);
			base.Skeleton.SetAlpha("Skye foot right", 1f);
			base.Skeleton.SetAlpha("Skye shin right", 1f);
			base.Skeleton.SetAlpha("Skye thigh right", 1f);
			base.Skeleton.SetAlpha("Skye arm left", 1f);
			base.Skeleton.SetAlpha("Skye arm right", 1f);
			base.Skeleton.SetAlpha("Skye boob left", 1f);
			base.Skeleton.SetAlpha("Skye chest", 1f);
			base.Skeleton.SetAlpha("Skye eyes", 1f);
			base.Skeleton.SetAlpha("Skye pupil", 1f);
			base.Skeleton.SetAlpha("Skye jaw", 1f);
			base.Skeleton.SetAlpha("Skye ear left", 1f);
			base.Skeleton.SetAlpha("Skye head back", 1f);
			base.Skeleton.SetAlpha("Skye ear right", 1f);
			base.Skeleton.SetAlpha("Skye eyelids", 1f);
			base.Skeleton.SetAlpha("Skye head", 1f);
			base.Skeleton.SetAlpha("Skye eyelash", 1f);
			base.Skeleton.SetColor("Player thigh right", (float)(int)data.BodyColor.R / 255f, (float)(int)data.BodyColor.G / 255f, (float)(int)data.BodyColor.B / 255f);
			base.Skeleton.SetColor("Player thigh left", (float)(int)data.BodyColor.R / 255f, (float)(int)data.BodyColor.G / 255f, (float)(int)data.BodyColor.B / 255f);
			base.Skeleton.SetColor("Player body", (float)(int)data.BodyColor.R / 255f, (float)(int)data.BodyColor.G / 255f, (float)(int)data.BodyColor.B / 255f);
			base.Skeleton.SetColor("Player underbelly", (float)(int)data.UnderbellyColor.R / 255f, (float)(int)data.UnderbellyColor.G / 255f, (float)(int)data.UnderbellyColor.B / 255f);
			base.Skeleton.SetColor("Player underthigh right", (float)(int)data.UnderthighColor.R / 255f, (float)(int)data.UnderthighColor.G / 255f, (float)(int)data.UnderthighColor.B / 255f);
			base.Skeleton.SetColor("Player underthigh left", (float)(int)data.UnderthighColor.R / 255f, (float)(int)data.UnderthighColor.G / 255f, (float)(int)data.UnderthighColor.B / 255f);
			base.Skeleton.SetColor("Player stripe right", (float)(int)data.StripesColor.R / 255f, (float)(int)data.StripesColor.G / 255f, (float)(int)data.StripesColor.B / 255f);
			base.Skeleton.SetColor("Player stripe left", (float)(int)data.StripesColor.R / 255f, (float)(int)data.StripesColor.G / 255f, (float)(int)data.StripesColor.B / 255f);
			base.Skeleton.SetColor("Player belly stripes", (float)(int)data.StripesColor.R / 255f, (float)(int)data.StripesColor.G / 255f, (float)(int)data.StripesColor.B / 255f);
			base.Skeleton.SetColor("Player cock", (float)(int)data.GenitaliaColor.R / 255f, (float)(int)data.GenitaliaColor.G / 255f, (float)(int)data.GenitaliaColor.B / 255f);
			base.Skeleton.SetColor("Player knot", (float)(int)data.GenitaliaColor.R / 255f, (float)(int)data.GenitaliaColor.G / 255f, (float)(int)data.GenitaliaColor.B / 255f);
			base.ExplosionSlots.Add("Player wetness");
		}
		else
		{
			base.Skeleton.SetAlpha("Skye tail", 1f);
			base.Skeleton.SetAlpha("Skye arm left", 1f);
			base.Skeleton.SetAlpha("Skye arm right", 1f);
			base.Skeleton.SetAlpha("Skye boob left", 1f);
			base.Skeleton.SetAlpha("Skye chest", 1f);
			base.Skeleton.SetAlpha("Skye eyes", 1f);
			base.Skeleton.SetAlpha("Skye pupil", 1f);
			base.Skeleton.SetAlpha("Skye jaw", 1f);
			base.Skeleton.SetAlpha("Skye ear left", 1f);
			base.Skeleton.SetAlpha("Skye head back", 1f);
			base.Skeleton.SetAlpha("Skye ear right", 1f);
			base.Skeleton.SetAlpha("Skye eyelids", 1f);
			base.Skeleton.SetAlpha("Skye head", 1f);
			base.Skeleton.SetAlpha("Skye eyelash", 1f);
		}
	}
}
