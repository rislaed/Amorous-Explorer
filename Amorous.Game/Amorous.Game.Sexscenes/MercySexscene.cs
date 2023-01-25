using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Spine;

namespace Amorous.Game.Sexscenes;

public class MercySexscene : CensoredSexscene
{
	private static readonly List<SkeletonJson.SpineEvent> _zAqFZFiaBbpl6Gf6nSX9UC3cSh6 = new List<SkeletonJson.SpineEvent>
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

	public MercySexscene(ContentManager contentManager_0)
		: base(contentManager_0, "Assets/SexScenes/Mercy/Mercy Sex", "Assets/SexScenes/Mercy/Background", null, list_0: _zAqFZFiaBbpl6Gf6nSX9UC3cSh6, _sa8EsNgk4VDRaASdXE7VprdlNlg_0: _sg4TvSTYoH0YwumBfYnvr7IeDaT._AZrO8MxMUE7cKsFYTQ4k9O3q7yC(contentManager_0), float_0: _iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF ? 2.2f : 1f, bool_0: true, float_1: 3000f)
	{
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._C5vPbZ72rpVMDWGuHxZuR5FNpAH("animation");
		if (_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
		{
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB.X = 450f;
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB.Y = 900f;
		}
		else
		{
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB.X = 960f;
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB.Y = 1090f;
		}
	}

	protected override void _coudx6g9HL4THj8r5aYCDxaHH0I(PlayerData _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._c4iC7y9v6xg7LpvjKIeUkOdZ3UF(0f);
		if (!_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
		{
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy leg left", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy arm left", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy body", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy arm right", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy horn left", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy ear left", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy fringe left", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy eye", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy pupil", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy eyelid", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy head", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy eyelash", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy fringe right", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy horn right", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy ear right", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy hairlock right", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy boob left", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy boob right", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy stomach", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy cock", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy tail", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy leg right", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy taint back", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy taint", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player body", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player body underbelly", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player taint", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player shin left", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player shin left markings short", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.MarkingsType.HasFlag(PlayerData.EMarkingsType.ShortShin) ? 1f : 0f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player shin left markings long", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.MarkingsType.HasFlag(PlayerData.EMarkingsType.LongShin) ? 1f : 0f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player cock", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player cock uncut", (_opIJo2jLUqdOL5yAFP4yzXce0DG_0.CockType == PlayerData.ECockType.Cut) ? 1f : 0f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player thigh left", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player thigh left markings inner thigh", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underthigh) ? 1f : 0f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player thigh left stripes", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player cock knot", (_opIJo2jLUqdOL5yAFP4yzXce0DG_0.CockType == PlayerData.ECockType.Knotted) ? 1f : 0f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player balls", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player Underbelly", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player shin right", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player shin right markings short", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.MarkingsType.HasFlag(PlayerData.EMarkingsType.ShortShin) ? 1f : 0f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player shin right markings long", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.MarkingsType.HasFlag(PlayerData.EMarkingsType.LongShin) ? 1f : 0f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player thigh right", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player thigh right markings inner thigh", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underthigh) ? 1f : 0f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player thigh right stripes", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
			bool flag = _opIJo2jLUqdOL5yAFP4yzXce0DG_0.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianShin);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player body", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.BodyColor);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player body underbelly", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.UnderbellyColor);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player taint", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.UnderbellyColor);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player shin left", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.BodyColor);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player shin left markings short", flag ? _opIJo2jLUqdOL5yAFP4yzXce0DG_0.AvianShinColor : _opIJo2jLUqdOL5yAFP4yzXce0DG_0.ShortShinColor);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player shin left markings long", flag ? _opIJo2jLUqdOL5yAFP4yzXce0DG_0.AvianShinColor : _opIJo2jLUqdOL5yAFP4yzXce0DG_0.LongShinColor);
			if (_opIJo2jLUqdOL5yAFP4yzXce0DG_0.CockType != PlayerData.ECockType.Cut)
			{
				base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player cock", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.GenitaliaColor);
			}
			else
			{
				base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player cock", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.GenitaliaFleshColor);
				base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player cock uncut", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.GenitaliaColor);
			}
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player thigh left", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.BodyColor);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player thigh left markings inner thigh", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.UnderthighColor);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player thigh left stripes", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.StripesColor);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player cock knot", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.GenitaliaColor);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player balls", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.BallsColor);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player Underbelly", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.UnderbellyColor);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player shin right", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.BodyColor);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player shin right markings short", flag ? _opIJo2jLUqdOL5yAFP4yzXce0DG_0.AvianShinColor : _opIJo2jLUqdOL5yAFP4yzXce0DG_0.ShortShinColor);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player shin right markings long", flag ? _opIJo2jLUqdOL5yAFP4yzXce0DG_0.AvianShinColor : _opIJo2jLUqdOL5yAFP4yzXce0DG_0.LongShinColor);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player thigh right", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.BodyColor);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player thigh right markings inner thigh", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.UnderthighColor);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player thigh right stripes", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.StripesColor);
			base._DUynKBx2CM4riE68wCCfknspxeg.Add("Cum");
		}
		else
		{
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy arm left", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy body", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy arm right", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy horn left", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy ear left", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy fringe left", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy eye", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy pupil", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy eyelid", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy head", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy eyelash", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy fringe right", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy horn right", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy ear right", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy hairlock right", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy tail", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Mercy leg right", 1f);
		}
	}
}
