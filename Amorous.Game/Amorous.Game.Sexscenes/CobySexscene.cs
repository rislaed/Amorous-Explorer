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
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._7Xn1C5tjYnmIif1iZKV8AWsEEbL = 900f;
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._bCjZ3VSXGKyhmykd2zCnQBiSpDf = 1050f;
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._49JXjKJqaPZw5nEmhHdAENuBtLJ("animation", -0.3f);
		}
		else
		{
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._7Xn1C5tjYnmIif1iZKV8AWsEEbL = 1700f;
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._bCjZ3VSXGKyhmykd2zCnQBiSpDf = 1700f;
		}
	}

	protected override void _coudx6g9HL4THj8r5aYCDxaHH0I(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
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
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player leg back underbelly", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Underbelly) ? 1f : 0f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player leg back high sleeve", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Underthigh) ? 1f : 0f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player leg back stripes", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Stripes) ? 1f : 0f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player taint", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player taint underbelly", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Underbelly) ? 1f : 0f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Coby jaw", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Coby eye", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Coby pupil", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Coby head", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Coby eyelid", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player arm", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player arm stripes", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Stripes) ? 1f : 0f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Coby Shoulder", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player forearm", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player forearm shortlong sleeve", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.ShortForearm) ? 1f : 0f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player forearm stripes", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Stripes) ? 1f : 0f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Coby balls", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player balls back", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player balls back underbelly", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Underbelly) ? 1f : 0f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player cock", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player cock knot", (_opIJo2jLUqdOL5yAFP4yzXce0DG_0._rtyJgfViJdXL2Ela5APpDlk99dI == _opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType.Knotted) ? 1f : 0f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player balls top", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player balls top underbelly", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Underbelly) ? 1f : 0f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Coby taint", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Coby tail", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Coby leg top", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Coby thigh top", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player leg top", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player leg top underbelly", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Underbelly) ? 1f : 0f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player leg top stripes", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Stripes) ? 1f : 0f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player hand", 1f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player hand shortlong sleeve", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.ShortForearm) ? 1f : 0f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player nails", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._VmNLhqrIwSnE6JnCYiBcxnSqnEV ? 1f : 0f);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player leg back", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player leg back underbelly", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._PeK36AvFxEQCvX3fS62hNV7rpuJ);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player leg back high sleeve", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._zBv1cYqPRU7uDCALpBlBSgObUcbA);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player leg back stripes", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player taint", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player taint underbelly", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._PeK36AvFxEQCvX3fS62hNV7rpuJ);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player arm", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player arm stripes", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player forearm", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player forearm shortlong sleeve", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._8rDSn6e9Ip9WdOogjhIn8YlL1oM);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player forearm stripes", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player balls back", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._8qQ7XVlyRYW4icBFxPQCJqgueYD);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player balls back underbelly", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._PeK36AvFxEQCvX3fS62hNV7rpuJ);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player cock", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._XnNREK59QnV1onFFWfSUaS9WK0E);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player cock knot", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._XnNREK59QnV1onFFWfSUaS9WK0E);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player balls top", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._8qQ7XVlyRYW4icBFxPQCJqgueYD);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player balls top underbelly", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._PeK36AvFxEQCvX3fS62hNV7rpuJ);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player leg top", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player leg top underbelly", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._PeK36AvFxEQCvX3fS62hNV7rpuJ);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player leg top stripes", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player hand", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player hand shortlong sleeve", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._8rDSn6e9Ip9WdOogjhIn8YlL1oM);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player nails", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._in5HHYmrdLTFpkgc8aimJpXqAXB);
		base._DUynKBx2CM4riE68wCCfknspxeg.Add("Cum butt back");
		base._DUynKBx2CM4riE68wCCfknspxeg.Add("Cum cock");
		base._DUynKBx2CM4riE68wCCfknspxeg.Add("Cum butt top");
	}

	static bool smethod_14()
	{
		return _iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF;
	}

	static _nHdiyIURlAiaNZ8u6MKzxjcwnyL smethod_15(_TwlwMC1hhdSzamwGWEBxuUkz1gH _TwlwMC1hhdSzamwGWEBxuUkz1gH_0)
	{
		return _TwlwMC1hhdSzamwGWEBxuUkz1gH_0._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
	}

	static void smethod_16(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, Action<int> action_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._C5vPbZ72rpVMDWGuHxZuR5FNpAH(string_0, action_0);
	}

	static void smethod_17(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, float float_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_18(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, float float_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}

	static void smethod_19(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, float float_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._49JXjKJqaPZw5nEmhHdAENuBtLJ(string_0, float_0);
	}

	static void smethod_20(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, float float_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._c4iC7y9v6xg7LpvjKIeUkOdZ3UF(float_0);
	}

	static void smethod_21(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, float float_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._aAoZaDNczeScsMfLlGSfAzey9SQ(string_0, float_0);
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U smethod_22(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Mz7LwHZqoGBscApFXmff1kEQnGY;
	}

	static bool smethod_23(Enum enum_0, Enum enum_1)
	{
		return enum_0.HasFlag(enum_1);
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType smethod_24(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._rtyJgfViJdXL2Ela5APpDlk99dI;
	}

	static bool smethod_25(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._VmNLhqrIwSnE6JnCYiBcxnSqnEV;
	}

	static Color smethod_26(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G;
	}

	static void smethod_27(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, Color color_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._VoeevpFh2kLKfHtpPDXWt0TFbuH(string_0, color_0);
	}

	static Color smethod_28(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._PeK36AvFxEQCvX3fS62hNV7rpuJ;
	}

	static Color smethod_29(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._zBv1cYqPRU7uDCALpBlBSgObUcbA;
	}

	static Color smethod_30(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ;
	}

	static Color smethod_31(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._8rDSn6e9Ip9WdOogjhIn8YlL1oM;
	}

	static Color smethod_32(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._8qQ7XVlyRYW4icBFxPQCJqgueYD;
	}

	static Color smethod_33(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._XnNREK59QnV1onFFWfSUaS9WK0E;
	}

	static Color smethod_34(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._in5HHYmrdLTFpkgc8aimJpXqAXB;
	}

	static SkeletonJson.SpineEvent smethod_35()
	{
		return new SkeletonJson.SpineEvent();
	}

	static void smethod_36(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
	}
}
