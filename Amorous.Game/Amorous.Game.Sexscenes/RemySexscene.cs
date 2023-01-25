using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Spine;

namespace Amorous.Game.Sexscenes;

public class RemySexscene : CensoredSexscene
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
			FrameTimes = new float[3] { 1.3f, 3.3f, 5.3f }
		}
	};

	public RemySexscene(ContentManager contentManager_0)
		: base(contentManager_0, "Assets/SexScenes/Jax/Jax Sex", "Assets/SexScenes/Remy/Background", null, list_0: _zAqFZFiaBbpl6Gf6nSX9UC3cSh6, _sa8EsNgk4VDRaASdXE7VprdlNlg_0: _sg4TvSTYoH0YwumBfYnvr7IeDaT._AZrO8MxMUE7cKsFYTQ4k9O3q7yC(contentManager_0), float_0: _iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF ? 1.5f : 1f, bool_0: true, float_1: 3000f)
	{
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._C5vPbZ72rpVMDWGuHxZuR5FNpAH("animation");
		if (_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
		{
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB.X = 200f;
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB.Y = 1600f;
		}
		else
		{
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB.X = 900f;
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB.Y = 1050f;
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._49JXjKJqaPZw5nEmhHdAENuBtLJ("animation", -0.2f);
		}
	}

	protected override void _coudx6g9HL4THj8r5aYCDxaHH0I(PlayerData _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._c4iC7y9v6xg7LpvjKIeUkOdZ3UF(0f);
		if (_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
		{
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy Back Arm", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy Arm right", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy Torso", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy eyes back", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy pupils", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy jaw", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy lipbite", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy Ponytail", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy ear left", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy hair", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy ear right", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy head back", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy fringe back", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy glasses back", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy head", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy eyelids", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy eyelashes", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy glasses front", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy fringe mid", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy fringe front", 1f);
			return;
		}
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player arm", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player arm marking sleeve", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.MarkingsType.HasFlag(PlayerData.EMarkingsType.LongForearm) ? 1f : 0f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player arm stripes", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player legs", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player legs marking inner thighs", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underthigh) ? 1f : 0f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player legs stripes", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player cock", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player Cock Knotted", (_opIJo2jLUqdOL5yAFP4yzXce0DG_0.CockType == PlayerData.ECockType.Knotted) ? 1f : 0f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player body", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player body underbelly", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Boobs small", (_opIJo2jLUqdOL5yAFP4yzXce0DG_0.BreastsType == PlayerData.EBreastsType.ACup || _opIJo2jLUqdOL5yAFP4yzXce0DG_0.BreastsType == PlayerData.EBreastsType.BCup) ? 1f : 0f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Nipples small", ((_opIJo2jLUqdOL5yAFP4yzXce0DG_0.BreastsType == PlayerData.EBreastsType.ACup || _opIJo2jLUqdOL5yAFP4yzXce0DG_0.BreastsType == PlayerData.EBreastsType.BCup) && _opIJo2jLUqdOL5yAFP4yzXce0DG_0.ShowNipples) ? 1f : 0f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Boobs medium", (_opIJo2jLUqdOL5yAFP4yzXce0DG_0.BreastsType == PlayerData.EBreastsType.CCup || _opIJo2jLUqdOL5yAFP4yzXce0DG_0.BreastsType == PlayerData.EBreastsType.DCup) ? 1f : 0f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Nipples medium", ((_opIJo2jLUqdOL5yAFP4yzXce0DG_0.BreastsType == PlayerData.EBreastsType.CCup || _opIJo2jLUqdOL5yAFP4yzXce0DG_0.BreastsType == PlayerData.EBreastsType.DCup) && _opIJo2jLUqdOL5yAFP4yzXce0DG_0.ShowNipples) ? 1f : 0f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player arm", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.BodyColor);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player arm marking sleeve", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.LongForearmColor);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player arm stripes", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.StripesColor);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player legs", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.BodyColor);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player legs marking inner thighs", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.UnderthighColor);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player legs stripes", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.StripesColor);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player cock", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.GenitaliaColor);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player Cock Knotted", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.GenitaliaColor);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player body", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.BodyColor);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player body underbelly", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.UnderbellyColor);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Boobs small", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.BreastsColor);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Nipples small", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.NipplesColor);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Boobs medium", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.BreastsColor);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Nipples medium", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.NipplesColor);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy Back Arm", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy Back Leg", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy Arm right", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy Vag", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy leg front", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy Belly", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy Torso", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy Breast left", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy Breast right", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy eyes back", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy pupils", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy jaw", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy lipbite", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy Ponytail", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy ear left", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy hair", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy ear right", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy head back", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy fringe back", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy glasses back", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy head", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy eyelids", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy eyelashes", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy glasses front", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy fringe mid", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Remy fringe front", 1f);
		base._DUynKBx2CM4riE68wCCfknspxeg.Add("Cum dick");
		base._DUynKBx2CM4riE68wCCfknspxeg.Add("Cum vag");
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._eCEWplYE5FdfYPYTrwfyRlIfd6i("Remy Back Leg", "Player legs stripes");
	}
}
