using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Spine;

namespace Amorous.Game.Sexscenes;

public class CobySexscene : CensoredSexscene
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

	public CobySexscene(ContentManager contentManager_0)
		: base(contentManager_0, "Assets/SexScenes/Coby/Coby Sex", "Assets/SexScenes/Coby/Background", null, list_0: _zAqFZFiaBbpl6Gf6nSX9UC3cSh6, _sa8EsNgk4VDRaASdXE7VprdlNlg_0: new _ecVLwNBaQAiybVyX9cgWCvnbkWe(contentManager_0), float_0: _iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF ? 1.5f : 1f, bool_0: true, float_1: 3000f)
	{
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._C5vPbZ72rpVMDWGuHxZuR5FNpAH("animation");
		if (!_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
		{
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB.X = 900f;
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB.Y = 1050f;
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._49JXjKJqaPZw5nEmhHdAENuBtLJ("animation", -0.3f);
		}
		else
		{
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB.X = 1700f;
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB.Y = 1700f;
		}
	}

	protected override void _coudx6g9HL4THj8r5aYCDxaHH0I(PlayerData _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._c4iC7y9v6xg7LpvjKIeUkOdZ3UF(0f);
		if (_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
		{
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Coby Body", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Coby jaw", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Coby eye", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Coby pupil", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Coby head", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Coby eyelid", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Coby Shoulder", 1f);
			return;
		}
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Coby Body", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Coby leg back", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player leg back", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player leg back underbelly", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player leg back high sleeve", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underthigh) ? 1f : 0f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player leg back stripes", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player taint", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player taint underbelly", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Coby jaw", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Coby eye", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Coby pupil", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Coby head", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Coby eyelid", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player arm", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player arm stripes", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Coby Shoulder", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player forearm", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player forearm shortlong sleeve", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.MarkingsType.HasFlag(PlayerData.EMarkingsType.ShortForearm) ? 1f : 0f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player forearm stripes", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Coby balls", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player balls back", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player balls back underbelly", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player cock", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player cock knot", (_opIJo2jLUqdOL5yAFP4yzXce0DG_0.CockType == PlayerData.ECockType.Knotted) ? 1f : 0f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player balls top", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player balls top underbelly", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Coby taint", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Coby tail", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Coby leg top", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Coby thigh top", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player leg top", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player leg top underbelly", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.MarkingsType.HasFlag(PlayerData.EMarkingsType.Underbelly) ? 1f : 0f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player leg top stripes", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1f : 0f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player hand", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player hand shortlong sleeve", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.MarkingsType.HasFlag(PlayerData.EMarkingsType.ShortForearm) ? 1f : 0f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player nails", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.ShowNails ? 1f : 0f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player leg back", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.BodyColor);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player leg back underbelly", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.UnderbellyColor);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player leg back high sleeve", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.UnderthighColor);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player leg back stripes", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.StripesColor);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player taint", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.BodyColor);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player taint underbelly", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.UnderbellyColor);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player arm", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.BodyColor);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player arm stripes", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.StripesColor);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player forearm", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.BodyColor);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player forearm shortlong sleeve", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.ShortForearmColor);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player forearm stripes", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.StripesColor);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player balls back", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.BallsColor);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player balls back underbelly", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.UnderbellyColor);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player cock", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.GenitaliaColor);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player cock knot", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.GenitaliaColor);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player balls top", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.BallsColor);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player balls top underbelly", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.UnderbellyColor);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player leg top", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.BodyColor);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player leg top underbelly", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.UnderbellyColor);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player leg top stripes", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.StripesColor);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player hand", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.BodyColor);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player hand shortlong sleeve", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.ShortForearmColor);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player nails", _opIJo2jLUqdOL5yAFP4yzXce0DG_0.NailColor);
		base._DUynKBx2CM4riE68wCCfknspxeg.Add("Cum butt back");
		base._DUynKBx2CM4riE68wCCfknspxeg.Add("Cum cock");
		base._DUynKBx2CM4riE68wCCfknspxeg.Add("Cum butt top");
	}
}
