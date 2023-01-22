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
	public const string _SIHadD6cwfqQgHEvKqYhLp1ptN0 = "Gray";

	public const string _8WiBHk4ojcKXNJ8Iq6MFEuNQ4gT = "Yellow";

	public const string _KDxkn5aSvEobDXVkoiuQmEphQ6J = "Blue";

	private Texture2D _p65Ex7slWkEu44TWzMfnrHkavQb;

	private Texture2D _a2vuTNBvRtI0ysFdoyLqbnVKmKb;

	private Texture2D _8Wpyx8UxfA2ieouQH6qdonhcCok;

	private static readonly List<SkeletonJson.SpineEvent> _zAqFZFiaBbpl6Gf6nSX9UC3cSh6 = new List<SkeletonJson.SpineEvent>
	{
		new SkeletonJson.SpineEvent
		{
			AnimationName = "Sex",
			EventName = "ThrustStart",
			FrameTimes = new float[6] { 1f, 2f, 3f, 4f, 5f, 6f }
		},
		new SkeletonJson.SpineEvent
		{
			AnimationName = "Sex",
			EventName = "ThrustEnd",
			FrameTimes = new float[6] { 1.2f, 2.2f, 3.2f, 4.2f, 5.2f, 6.2f }
		},
		new SkeletonJson.SpineEvent
		{
			AnimationName = "Sex",
			EventName = "Moan",
			FrameTimes = new float[6] { 1.3f, 2.3f, 3.3f, 4.3f, 5.3f, 6.3f }
		}
	};

	public SkyeSexscene(ContentManager contentManager_0)
		: base(contentManager_0, "Assets/SexScenes/Skye/Skye Sex", "Assets/SexScenes/Skye/Background", null, list_0: _zAqFZFiaBbpl6Gf6nSX9UC3cSh6, _sa8EsNgk4VDRaASdXE7VprdlNlg_0: _sg4TvSTYoH0YwumBfYnvr7IeDaT._AZrO8MxMUE7cKsFYTQ4k9O3q7yC(contentManager_0), float_0: _iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF ? 2f : 1f, bool_0: true, float_1: 3000f)
	{
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._C5vPbZ72rpVMDWGuHxZuR5FNpAH("Sex");
		if (_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
		{
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._7Xn1C5tjYnmIif1iZKV8AWsEEbL = 1500f;
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._bCjZ3VSXGKyhmykd2zCnQBiSpDf = 2000f;
		}
		else
		{
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._7Xn1C5tjYnmIif1iZKV8AWsEEbL = 950f;
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._bCjZ3VSXGKyhmykd2zCnQBiSpDf = 1100f;
		}
		_p65Ex7slWkEu44TWzMfnrHkavQb = contentManager_0.Load<Texture2D>("Assets/SexScenes/Skye/Skye Sex");
		_a2vuTNBvRtI0ysFdoyLqbnVKmKb = contentManager_0.Load<Texture2D>("Assets/SexScenes/Skye/Skye Sex Yellow");
		_8Wpyx8UxfA2ieouQH6qdonhcCok = contentManager_0.Load<Texture2D>("Assets/SexScenes/Skye/Skye Sex Blue");
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
		bool flag = opIJo2jLUqdOL5yAFP4yzXce0DG._Oms9lumBodLGrGZ09YJaEuzmlAf("SkyeSkinYellow");
		bool flag2 = opIJo2jLUqdOL5yAFP4yzXce0DG._Oms9lumBodLGrGZ09YJaEuzmlAf("SkyeSkinBlue");
		if (!(flag && flag2))
		{
			if (flag)
			{
				_GGyEXu1JJKcG2X3txvtCwyZAylK("Yellow");
			}
			else if (flag2)
			{
				_GGyEXu1JJKcG2X3txvtCwyZAylK("Blue");
			}
			else
			{
				_GGyEXu1JJKcG2X3txvtCwyZAylK("Gray");
			}
		}
		else
		{
			_GGyEXu1JJKcG2X3txvtCwyZAylK("Gray");
		}
	}

	public override string[] _tCw3HO9jqoEm2Ad1hqdKsA8vS7b()
	{
		return new string[3] { "Gray", "Yellow", "Blue" };
	}

	public override void _GGyEXu1JJKcG2X3txvtCwyZAylK(string string_0)
	{
		base._GGyEXu1JJKcG2X3txvtCwyZAylK(string_0);
		switch (string_0)
		{
		case "Gray":
			base._1AqpgY4vB6ly5vxOay6j86rcIEo = _p65Ex7slWkEu44TWzMfnrHkavQb;
			break;
		case "Yellow":
			base._1AqpgY4vB6ly5vxOay6j86rcIEo = _a2vuTNBvRtI0ysFdoyLqbnVKmKb;
			break;
		case "Blue":
			base._1AqpgY4vB6ly5vxOay6j86rcIEo = _8Wpyx8UxfA2ieouQH6qdonhcCok;
			break;
		}
	}

	protected override void _coudx6g9HL4THj8r5aYCDxaHH0I(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._c4iC7y9v6xg7LpvjKIeUkOdZ3UF(0f);
		if (!_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
		{
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Skye shin back", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player thigh right", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player stripe right", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Stripes) ? 1f : 0f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player underthigh right", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Underthigh) ? 1f : 0f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player thigh left", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player stripe left", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Stripes) ? 1f : 0f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player underthigh left", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Underthigh) ? 1f : 0f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player cock", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player body", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player belly stripes", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Stripes) ? 1f : 0f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player underbelly", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Underbelly) ? 1f : 0f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player knot", (_opIJo2jLUqdOL5yAFP4yzXce0DG_0._rtyJgfViJdXL2Ela5APpDlk99dI == _opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType.Knotted) ? 1f : 0f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Skye tail", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Skye thigh left", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Skye body", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Skye foot right", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Skye shin right", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Skye thigh right", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Skye arm left", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Skye arm right", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Skye boob left", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Skye chest", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Skye eyes", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Skye pupil", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Skye jaw", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Skye ear left", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Skye head back", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Skye ear right", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Skye eyelids", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Skye head", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Skye eyelash", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player thigh right", (float)(int)_opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G.R / 255f, (float)(int)_opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G.G / 255f, (float)(int)_opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G.B / 255f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player thigh left", (float)(int)_opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G.R / 255f, (float)(int)_opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G.G / 255f, (float)(int)_opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G.B / 255f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player body", (float)(int)_opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G.R / 255f, (float)(int)_opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G.G / 255f, (float)(int)_opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G.B / 255f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player underbelly", (float)(int)_opIJo2jLUqdOL5yAFP4yzXce0DG_0._PeK36AvFxEQCvX3fS62hNV7rpuJ.R / 255f, (float)(int)_opIJo2jLUqdOL5yAFP4yzXce0DG_0._PeK36AvFxEQCvX3fS62hNV7rpuJ.G / 255f, (float)(int)_opIJo2jLUqdOL5yAFP4yzXce0DG_0._PeK36AvFxEQCvX3fS62hNV7rpuJ.B / 255f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player underthigh right", (float)(int)_opIJo2jLUqdOL5yAFP4yzXce0DG_0._zBv1cYqPRU7uDCALpBlBSgObUcbA.R / 255f, (float)(int)_opIJo2jLUqdOL5yAFP4yzXce0DG_0._zBv1cYqPRU7uDCALpBlBSgObUcbA.G / 255f, (float)(int)_opIJo2jLUqdOL5yAFP4yzXce0DG_0._zBv1cYqPRU7uDCALpBlBSgObUcbA.B / 255f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player underthigh left", (float)(int)_opIJo2jLUqdOL5yAFP4yzXce0DG_0._zBv1cYqPRU7uDCALpBlBSgObUcbA.R / 255f, (float)(int)_opIJo2jLUqdOL5yAFP4yzXce0DG_0._zBv1cYqPRU7uDCALpBlBSgObUcbA.G / 255f, (float)(int)_opIJo2jLUqdOL5yAFP4yzXce0DG_0._zBv1cYqPRU7uDCALpBlBSgObUcbA.B / 255f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player stripe right", (float)(int)_opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ.R / 255f, (float)(int)_opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ.G / 255f, (float)(int)_opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ.B / 255f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player stripe left", (float)(int)_opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ.R / 255f, (float)(int)_opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ.G / 255f, (float)(int)_opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ.B / 255f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player belly stripes", (float)(int)_opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ.R / 255f, (float)(int)_opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ.G / 255f, (float)(int)_opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ.B / 255f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player cock", (float)(int)_opIJo2jLUqdOL5yAFP4yzXce0DG_0._XnNREK59QnV1onFFWfSUaS9WK0E.R / 255f, (float)(int)_opIJo2jLUqdOL5yAFP4yzXce0DG_0._XnNREK59QnV1onFFWfSUaS9WK0E.G / 255f, (float)(int)_opIJo2jLUqdOL5yAFP4yzXce0DG_0._XnNREK59QnV1onFFWfSUaS9WK0E.B / 255f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player knot", (float)(int)_opIJo2jLUqdOL5yAFP4yzXce0DG_0._XnNREK59QnV1onFFWfSUaS9WK0E.R / 255f, (float)(int)_opIJo2jLUqdOL5yAFP4yzXce0DG_0._XnNREK59QnV1onFFWfSUaS9WK0E.G / 255f, (float)(int)_opIJo2jLUqdOL5yAFP4yzXce0DG_0._XnNREK59QnV1onFFWfSUaS9WK0E.B / 255f);
			base._DUynKBx2CM4riE68wCCfknspxeg.Add("Player wetness");
		}
		else
		{
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Skye tail", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Skye arm left", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Skye arm right", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Skye boob left", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Skye chest", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Skye eyes", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Skye pupil", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Skye jaw", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Skye ear left", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Skye head back", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Skye ear right", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Skye eyelids", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Skye head", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Skye eyelash", 1f);
		}
	}
}
