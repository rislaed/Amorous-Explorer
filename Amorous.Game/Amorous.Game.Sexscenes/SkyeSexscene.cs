using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Spine;

namespace Amorous.Game.Sexscenes;

public class SkyeSexscene : CensoredSexscene
{
	public const string VariantGray = "Gray";
	public const string VariantYellow = "Yellow";
	public const string VariantBlue = "Blue";

	private Texture2D SkinGray;
	private Texture2D SkinYellow;
	private Texture2D SkinBlue;

	private static readonly List<SkeletonJson.SpineEvent> Events = new List<SkeletonJson.SpineEvent>
	{
		new SkeletonJson.SpineEvent
		{
			AnimationName = "Sex",
			EventName = EventThrustStart,
			FrameTimes = new float[6] { 1f, 2f, 3f, 4f, 5f, 6f }
		},
		new SkeletonJson.SpineEvent
		{
			AnimationName = "Sex",
			EventName = EventThrustEnd,
			FrameTimes = new float[6] { 1.2f, 2.2f, 3.2f, 4.2f, 5.2f, 6.2f }
		},
		new SkeletonJson.SpineEvent
		{
			AnimationName = "Sex",
			EventName = EventMoan,
			FrameTimes = new float[6] { 1.3f, 2.3f, 3.3f, 4.3f, 5.3f, 6.3f }
		}
	};

	public SkyeSexscene(ContentManager content)
		: base(content, "Assets/SexScenes/Skye/Skye Sex", "Assets/SexScenes/Skye/Background", null, events: Events, sounds: FemaleSexsceneSounds.Get(content), scale: Censorship.Censored ? 2f : 1f, premultipliedAlpha: true, cycle: 3000f)
	{
		base.Spine.StartAnimationWithLooping("Sex");
		if (Censorship.Censored)
		{
			base.Spine.X = 1500f;
			base.Spine.Y = 2000f;
		}
		else
		{
			base.Spine.X = 950f;
			base.Spine.Y = 1100f;
		}
		SkinGray = content.Load<Texture2D>("Assets/SexScenes/Skye/Skye Sex");
		SkinYellow = content.Load<Texture2D>("Assets/SexScenes/Skye/Skye Sex Yellow");
		SkinBlue = content.Load<Texture2D>("Assets/SexScenes/Skye/Skye Sex Blue");
		PlayerData data = PlayerPreferences.GetPlayerData();
		bool isYellow = data.GetFlag(AmorousData.SkyeSkinYellow);
		bool isBlue = data.GetFlag(AmorousData.SkyeSkinBlue);
		if (!(isYellow && isBlue))
		{
			if (isYellow)
			{
				SwitchToSubscene(VariantYellow);
			}
			else if (isBlue)
			{
				SwitchToSubscene(VariantBlue);
			}
			else
			{
				SwitchToSubscene(VariantGray);
			}
		}
		else
		{
			SwitchToSubscene(VariantGray);
		}
	}

	public override string[] GetSubscenes()
	{
		return new string[3] { "Gray", "Yellow", "Blue" };
	}

	public override void SwitchToSubscene(string subscene)
	{
		base.SwitchToSubscene(subscene);
		switch (subscene)
		{
			case VariantGray:
				base.Skin = SkinGray;
				break;
			case VariantYellow:
				base.Skin = SkinYellow;
				break;
			case VariantBlue:
				base.Skin = SkinBlue;
				break;
		}
	}

	protected override void RefreshSubscene(PlayerData data)
	{
		base.Spine.SetVisibility(0f);
		if (!Censorship.Censored)
		{
			base.Spine.SetAlpha("Skye shin back", 1f);
			base.Spine.SetAlpha("Player thigh right", 1f);
			base.Spine.SetAlpha("Player stripe right", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
			base.Spine.SetAlpha("Player underthigh right", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underthigh) ? 1f : 0f);
			base.Spine.SetAlpha("Player thigh left", 1f);
			base.Spine.SetAlpha("Player stripe left", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
			base.Spine.SetAlpha("Player underthigh left", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underthigh) ? 1f : 0f);
			base.Spine.SetAlpha("Player cock", 1f);
			base.Spine.SetAlpha("Player body", 1f);
			base.Spine.SetAlpha("Player belly stripes", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
			base.Spine.SetAlpha("Player underbelly", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
			base.Spine.SetAlpha("Player knot", (data.CockType == PlayerData.ECockType.Knotted) ? 1f : 0f);
			base.Spine.SetAlpha("Skye tail", 1f);
			base.Spine.SetAlpha("Skye thigh left", 1f);
			base.Spine.SetAlpha("Skye body", 1f);
			base.Spine.SetAlpha("Skye foot right", 1f);
			base.Spine.SetAlpha("Skye shin right", 1f);
			base.Spine.SetAlpha("Skye thigh right", 1f);
			base.Spine.SetAlpha("Skye arm left", 1f);
			base.Spine.SetAlpha("Skye arm right", 1f);
			base.Spine.SetAlpha("Skye boob left", 1f);
			base.Spine.SetAlpha("Skye chest", 1f);
			base.Spine.SetAlpha("Skye eyes", 1f);
			base.Spine.SetAlpha("Skye pupil", 1f);
			base.Spine.SetAlpha("Skye jaw", 1f);
			base.Spine.SetAlpha("Skye ear left", 1f);
			base.Spine.SetAlpha("Skye head back", 1f);
			base.Spine.SetAlpha("Skye ear right", 1f);
			base.Spine.SetAlpha("Skye eyelids", 1f);
			base.Spine.SetAlpha("Skye head", 1f);
			base.Spine.SetAlpha("Skye eyelash", 1f);
			base.Spine.SetColor("Player thigh right", (float)(int)data.BodyColor.R / 255f, (float)(int)data.BodyColor.G / 255f, (float)(int)data.BodyColor.B / 255f);
			base.Spine.SetColor("Player thigh left", (float)(int)data.BodyColor.R / 255f, (float)(int)data.BodyColor.G / 255f, (float)(int)data.BodyColor.B / 255f);
			base.Spine.SetColor("Player body", (float)(int)data.BodyColor.R / 255f, (float)(int)data.BodyColor.G / 255f, (float)(int)data.BodyColor.B / 255f);
			base.Spine.SetColor("Player underbelly", (float)(int)data.UnderbellyColor.R / 255f, (float)(int)data.UnderbellyColor.G / 255f, (float)(int)data.UnderbellyColor.B / 255f);
			base.Spine.SetColor("Player underthigh right", (float)(int)data.UnderthighColor.R / 255f, (float)(int)data.UnderthighColor.G / 255f, (float)(int)data.UnderthighColor.B / 255f);
			base.Spine.SetColor("Player underthigh left", (float)(int)data.UnderthighColor.R / 255f, (float)(int)data.UnderthighColor.G / 255f, (float)(int)data.UnderthighColor.B / 255f);
			base.Spine.SetColor("Player stripe right", (float)(int)data.StripesColor.R / 255f, (float)(int)data.StripesColor.G / 255f, (float)(int)data.StripesColor.B / 255f);
			base.Spine.SetColor("Player stripe left", (float)(int)data.StripesColor.R / 255f, (float)(int)data.StripesColor.G / 255f, (float)(int)data.StripesColor.B / 255f);
			base.Spine.SetColor("Player belly stripes", (float)(int)data.StripesColor.R / 255f, (float)(int)data.StripesColor.G / 255f, (float)(int)data.StripesColor.B / 255f);
			base.Spine.SetColor("Player cock", (float)(int)data.GenitaliaColor.R / 255f, (float)(int)data.GenitaliaColor.G / 255f, (float)(int)data.GenitaliaColor.B / 255f);
			base.Spine.SetColor("Player knot", (float)(int)data.GenitaliaColor.R / 255f, (float)(int)data.GenitaliaColor.G / 255f, (float)(int)data.GenitaliaColor.B / 255f);
			base.ExplosionBones.Add("Player wetness");
		}
		else
		{
			base.Spine.SetAlpha("Skye tail", 1f);
			base.Spine.SetAlpha("Skye arm left", 1f);
			base.Spine.SetAlpha("Skye arm right", 1f);
			base.Spine.SetAlpha("Skye boob left", 1f);
			base.Spine.SetAlpha("Skye chest", 1f);
			base.Spine.SetAlpha("Skye eyes", 1f);
			base.Spine.SetAlpha("Skye pupil", 1f);
			base.Spine.SetAlpha("Skye jaw", 1f);
			base.Spine.SetAlpha("Skye ear left", 1f);
			base.Spine.SetAlpha("Skye head back", 1f);
			base.Spine.SetAlpha("Skye ear right", 1f);
			base.Spine.SetAlpha("Skye eyelids", 1f);
			base.Spine.SetAlpha("Skye head", 1f);
			base.Spine.SetAlpha("Skye eyelash", 1f);
		}
	}
}
