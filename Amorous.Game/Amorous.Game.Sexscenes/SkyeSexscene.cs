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

	private static readonly List<SpineEvent> _zAqFZFiaBbpl6Gf6nSX9UC3cSh6;

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
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Unknown result type (might be due to invalid IL or missing references)
		//IL_056f: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05be: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_060d: Unknown result type (might be due to invalid IL or missing references)
		//IL_061d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_0642: Unknown result type (might be due to invalid IL or missing references)
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_0657: Unknown result type (might be due to invalid IL or missing references)
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_0691: Unknown result type (might be due to invalid IL or missing references)
		//IL_0696: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
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
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL nHdiyIURlAiaNZ8u6MKzxjcwnyL = base._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
			Color val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G;
			float float_ = (float)(int)((Color)(ref val)).get_R() / 255f;
			val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G;
			float float_2 = (float)(int)((Color)(ref val)).get_G() / 255f;
			val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G;
			nHdiyIURlAiaNZ8u6MKzxjcwnyL._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player thigh right", float_, float_2, (float)(int)((Color)(ref val)).get_B() / 255f);
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL nHdiyIURlAiaNZ8u6MKzxjcwnyL2 = base._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
			val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G;
			float float_3 = (float)(int)((Color)(ref val)).get_R() / 255f;
			val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G;
			float float_4 = (float)(int)((Color)(ref val)).get_G() / 255f;
			val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G;
			nHdiyIURlAiaNZ8u6MKzxjcwnyL2._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player thigh left", float_3, float_4, (float)(int)((Color)(ref val)).get_B() / 255f);
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL nHdiyIURlAiaNZ8u6MKzxjcwnyL3 = base._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
			val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G;
			float float_5 = (float)(int)((Color)(ref val)).get_R() / 255f;
			val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G;
			float float_6 = (float)(int)((Color)(ref val)).get_G() / 255f;
			val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G;
			nHdiyIURlAiaNZ8u6MKzxjcwnyL3._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player body", float_5, float_6, (float)(int)((Color)(ref val)).get_B() / 255f);
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL nHdiyIURlAiaNZ8u6MKzxjcwnyL4 = base._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
			val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._PeK36AvFxEQCvX3fS62hNV7rpuJ;
			float float_7 = (float)(int)((Color)(ref val)).get_R() / 255f;
			val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._PeK36AvFxEQCvX3fS62hNV7rpuJ;
			float float_8 = (float)(int)((Color)(ref val)).get_G() / 255f;
			val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._PeK36AvFxEQCvX3fS62hNV7rpuJ;
			nHdiyIURlAiaNZ8u6MKzxjcwnyL4._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player underbelly", float_7, float_8, (float)(int)((Color)(ref val)).get_B() / 255f);
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL nHdiyIURlAiaNZ8u6MKzxjcwnyL5 = base._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
			val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._zBv1cYqPRU7uDCALpBlBSgObUcbA;
			float float_9 = (float)(int)((Color)(ref val)).get_R() / 255f;
			val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._zBv1cYqPRU7uDCALpBlBSgObUcbA;
			float float_10 = (float)(int)((Color)(ref val)).get_G() / 255f;
			val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._zBv1cYqPRU7uDCALpBlBSgObUcbA;
			nHdiyIURlAiaNZ8u6MKzxjcwnyL5._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player underthigh right", float_9, float_10, (float)(int)((Color)(ref val)).get_B() / 255f);
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL nHdiyIURlAiaNZ8u6MKzxjcwnyL6 = base._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
			val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._zBv1cYqPRU7uDCALpBlBSgObUcbA;
			float float_11 = (float)(int)((Color)(ref val)).get_R() / 255f;
			val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._zBv1cYqPRU7uDCALpBlBSgObUcbA;
			float float_12 = (float)(int)((Color)(ref val)).get_G() / 255f;
			val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._zBv1cYqPRU7uDCALpBlBSgObUcbA;
			nHdiyIURlAiaNZ8u6MKzxjcwnyL6._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player underthigh left", float_11, float_12, (float)(int)((Color)(ref val)).get_B() / 255f);
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL nHdiyIURlAiaNZ8u6MKzxjcwnyL7 = base._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
			val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ;
			float float_13 = (float)(int)((Color)(ref val)).get_R() / 255f;
			val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ;
			float float_14 = (float)(int)((Color)(ref val)).get_G() / 255f;
			val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ;
			nHdiyIURlAiaNZ8u6MKzxjcwnyL7._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player stripe right", float_13, float_14, (float)(int)((Color)(ref val)).get_B() / 255f);
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL nHdiyIURlAiaNZ8u6MKzxjcwnyL8 = base._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
			val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ;
			float float_15 = (float)(int)((Color)(ref val)).get_R() / 255f;
			val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ;
			float float_16 = (float)(int)((Color)(ref val)).get_G() / 255f;
			val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ;
			nHdiyIURlAiaNZ8u6MKzxjcwnyL8._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player stripe left", float_15, float_16, (float)(int)((Color)(ref val)).get_B() / 255f);
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL nHdiyIURlAiaNZ8u6MKzxjcwnyL9 = base._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
			val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ;
			float float_17 = (float)(int)((Color)(ref val)).get_R() / 255f;
			val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ;
			float float_18 = (float)(int)((Color)(ref val)).get_G() / 255f;
			val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ;
			nHdiyIURlAiaNZ8u6MKzxjcwnyL9._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player belly stripes", float_17, float_18, (float)(int)((Color)(ref val)).get_B() / 255f);
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL nHdiyIURlAiaNZ8u6MKzxjcwnyL10 = base._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
			val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._XnNREK59QnV1onFFWfSUaS9WK0E;
			float float_19 = (float)(int)((Color)(ref val)).get_R() / 255f;
			val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._XnNREK59QnV1onFFWfSUaS9WK0E;
			float float_20 = (float)(int)((Color)(ref val)).get_G() / 255f;
			val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._XnNREK59QnV1onFFWfSUaS9WK0E;
			nHdiyIURlAiaNZ8u6MKzxjcwnyL10._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player cock", float_19, float_20, (float)(int)((Color)(ref val)).get_B() / 255f);
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL nHdiyIURlAiaNZ8u6MKzxjcwnyL11 = base._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
			val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._XnNREK59QnV1onFFWfSUaS9WK0E;
			float float_21 = (float)(int)((Color)(ref val)).get_R() / 255f;
			val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._XnNREK59QnV1onFFWfSUaS9WK0E;
			float float_22 = (float)(int)((Color)(ref val)).get_G() / 255f;
			val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._XnNREK59QnV1onFFWfSUaS9WK0E;
			nHdiyIURlAiaNZ8u6MKzxjcwnyL11._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player knot", float_21, float_22, (float)(int)((Color)(ref val)).get_B() / 255f);
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

	static SkyeSexscene()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		List<SpineEvent> list = new List<SpineEvent>();
		SpineEvent val = new SpineEvent();
		val.AnimationName = "Sex";
		val.EventName = "ThrustStart";
		val.FrameTimes = new float[6] { 1f, 2f, 3f, 4f, 5f, 6f };
		list.Add(val);
		val = new SpineEvent();
		val.AnimationName = "Sex";
		val.EventName = "ThrustEnd";
		val.FrameTimes = new float[6] { 1.2f, 2.2f, 3.2f, 4.2f, 5.2f, 6.2f };
		list.Add(val);
		val = new SpineEvent();
		val.AnimationName = "Sex";
		val.EventName = "Moan";
		val.FrameTimes = new float[6] { 1.3f, 2.3f, 3.3f, 4.3f, 5.3f, 6.3f };
		list.Add(val);
		_zAqFZFiaBbpl6Gf6nSX9UC3cSh6 = list;
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

	static _opIJo2jLUqdOL5yAFP4yzXce0DG smethod_19()
	{
		return _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
	}

	static bool smethod_20(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0, string string_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Oms9lumBodLGrGZ09YJaEuzmlAf(string_0);
	}

	static void smethod_21(_TwlwMC1hhdSzamwGWEBxuUkz1gH _TwlwMC1hhdSzamwGWEBxuUkz1gH_0, string string_0)
	{
		_TwlwMC1hhdSzamwGWEBxuUkz1gH_0._GGyEXu1JJKcG2X3txvtCwyZAylK(string_0);
	}

	void method_9(string string_0)
	{
		base._GGyEXu1JJKcG2X3txvtCwyZAylK(string_0);
	}

	static bool smethod_22(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	static void smethod_23(_TwlwMC1hhdSzamwGWEBxuUkz1gH _TwlwMC1hhdSzamwGWEBxuUkz1gH_0, Texture2D texture2D_0)
	{
		_TwlwMC1hhdSzamwGWEBxuUkz1gH_0._1AqpgY4vB6ly5vxOay6j86rcIEo = texture2D_0;
	}

	static void smethod_24(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, float float_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._c4iC7y9v6xg7LpvjKIeUkOdZ3UF(float_0);
	}

	static void smethod_25(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, float float_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._aAoZaDNczeScsMfLlGSfAzey9SQ(string_0, float_0);
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U smethod_26(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Mz7LwHZqoGBscApFXmff1kEQnGY;
	}

	static bool smethod_27(Enum enum_0, Enum enum_1)
	{
		return enum_0.HasFlag(enum_1);
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType smethod_28(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._rtyJgfViJdXL2Ela5APpDlk99dI;
	}

	static Color smethod_29(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G;
	}

	static SpineEvent smethod_30()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new SpineEvent();
	}

	static void smethod_31(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
	}
}
