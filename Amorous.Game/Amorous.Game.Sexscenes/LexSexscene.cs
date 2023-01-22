using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Spine;

namespace Amorous.Game.Sexscenes;

public class LexSexscene : CensoredSexscene
{
	public const string _7p39D6gRnJVEL4nBpm27s7mRbMo = "Male";

	public const string _bguKzeUbXe4hujNISQZXXCW725e = "Female";

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

	public LexSexscene(ContentManager contentManager_0)
		: base(contentManager_0, "Assets/SexScenes/Lex/Lex Sex", "Assets/SexScenes/Lex/Background", null, list_0: _zAqFZFiaBbpl6Gf6nSX9UC3cSh6, float_0: _iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF ? 1.5f : 1f, bool_0: true, _sa8EsNgk4VDRaASdXE7VprdlNlg_0: null, float_1: 5000f)
	{
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._C5vPbZ72rpVMDWGuHxZuR5FNpAH("animation");
		if (_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
		{
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._7Xn1C5tjYnmIif1iZKV8AWsEEbL = 1000f;
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._bCjZ3VSXGKyhmykd2zCnQBiSpDf = 1600f;
		}
		else
		{
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._7Xn1C5tjYnmIif1iZKV8AWsEEbL = 900f;
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._bCjZ3VSXGKyhmykd2zCnQBiSpDf = 1100f;
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._49JXjKJqaPZw5nEmhHdAENuBtLJ("animation", -0.2f);
		}
	}

	public override string[] _tCw3HO9jqoEm2Ad1hqdKsA8vS7b()
	{
		if (_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
		{
			return base._tCw3HO9jqoEm2Ad1hqdKsA8vS7b();
		}
		return new string[2] { "Male", "Female" };
	}

	public override void _GGyEXu1JJKcG2X3txvtCwyZAylK(string string_0)
	{
		base._GGyEXu1JJKcG2X3txvtCwyZAylK(string_0);
		if (string_0 == "Male")
		{
			base._wQSC6rD8bbXFvRxba0kr1RqxlOV = new _ecVLwNBaQAiybVyX9cgWCvnbkWe(base._uwNDZuqdFb9tyQtlQMxiz1DQ7x8);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex balls", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex knot", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex dick tip", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex vag", 0f);
			base._DUynKBx2CM4riE68wCCfknspxeg.Clear();
			base._DUynKBx2CM4riE68wCCfknspxeg.Add("Cum");
			base._DUynKBx2CM4riE68wCCfknspxeg.Add("Alex dick cum");
		}
		else if (string_0 == "Female")
		{
			base._wQSC6rD8bbXFvRxba0kr1RqxlOV = _sg4TvSTYoH0YwumBfYnvr7IeDaT._AZrO8MxMUE7cKsFYTQ4k9O3q7yC(base._uwNDZuqdFb9tyQtlQMxiz1DQ7x8);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex balls", 0f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex knot", 0f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex dick tip", 0f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex vag", 1f);
			base._DUynKBx2CM4riE68wCCfknspxeg.Clear();
			base._DUynKBx2CM4riE68wCCfknspxeg.Add("Cum");
		}
	}

	protected override void _coudx6g9HL4THj8r5aYCDxaHH0I(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		bool flag = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Oms9lumBodLGrGZ09YJaEuzmlAf("Lex.Is.Male");
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._c4iC7y9v6xg7LpvjKIeUkOdZ3UF(0f);
		if (!_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
		{
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Knot back", (_opIJo2jLUqdOL5yAFP4yzXce0DG_0._rtyJgfViJdXL2Ela5APpDlk99dI == _opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType.Knotted) ? 1f : 0f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player cock shaft", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Player cock tip", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Knot top", (_opIJo2jLUqdOL5yAFP4yzXce0DG_0._rtyJgfViJdXL2Ela5APpDlk99dI == _opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType.Knotted) ? 1f : 0f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Underbelly", (_opIJo2jLUqdOL5yAFP4yzXce0DG_0._8CtoV1bqn0CwCzb1tuoNppBt0Gg == _opIJo2jLUqdOL5yAFP4yzXce0DG.EBodyType.Chubby) ? 1f : 0f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Stripes", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Mz7LwHZqoGBscApFXmff1kEQnGY.HasFlag(_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Stripes) ? 1f : 0f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Playerbody", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Knot back", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._XnNREK59QnV1onFFWfSUaS9WK0E);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player cock shaft", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._XnNREK59QnV1onFFWfSUaS9WK0E);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player cock tip", (_opIJo2jLUqdOL5yAFP4yzXce0DG_0._rtyJgfViJdXL2Ela5APpDlk99dI == _opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType.Uncut) ? _opIJo2jLUqdOL5yAFP4yzXce0DG_0._o6OnmHi5rZIQPHESokp9rTaO1ei : _opIJo2jLUqdOL5yAFP4yzXce0DG_0._XnNREK59QnV1onFFWfSUaS9WK0E);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Knot top", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._XnNREK59QnV1onFFWfSUaS9WK0E);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Underbelly", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._PeK36AvFxEQCvX3fS62hNV7rpuJ);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Stripes", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._VoeevpFh2kLKfHtpPDXWt0TFbuH("Playerbody", _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex tail back", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex thigh right", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex body", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex thigh left", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex neck floof", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex forearm right", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex shoulder right", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex chest", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex shoulder left", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex forearm left", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex chest poof", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex eyes back", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex pupils", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex ear left", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex ear right", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex jaw", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex tongue", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex head", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex eyelids", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex eyelash", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex muzzle", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex fringe", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex hand left", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex hand right", 1f);
			_GGyEXu1JJKcG2X3txvtCwyZAylK(flag ? "Male" : "Female");
		}
		else
		{
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex body", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex neck floof", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex forearm right", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex shoulder right", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex chest", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex shoulder left", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex forearm left", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex chest poof", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex eyes back", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex pupils", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex ear left", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex ear right", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex jaw", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex tongue", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex head", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex eyelids", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex eyelash", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex muzzle", 1f);
			base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ("Alex fringe", 1f);
		}
	}
}
