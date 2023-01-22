using System;
using Microsoft.Xna.Framework;

public abstract class _RlrsL89bialFQa9mzWurgsdr6FK<T>
{
	private T _3wk7bXUbhNqSQ9kMD9hieEubOhG;

	private T _HfphKheLtbf0FIRRIg02hsTWuwA;

	private T _O0KnQCKZMolAHkzz0OlVM50NO3P;

	private int _XTvGE1JB69E9GLYnSRCwUVGb5PR;

	private Action _O8DUpKIpqikHVGPGwFwT9XO5gPb;

	protected int _vbhwdZ3gErkBPSpla6ZPcciEtI1 { get; set; }

	public T _SWODlbUkQEqfwrtprjLPOeGF7HO => _3wk7bXUbhNqSQ9kMD9hieEubOhG;

	public bool _fsCqU0Uh34vrMEsAqlf2BqbTz5B => _XTvGE1JB69E9GLYnSRCwUVGb5PR > 0;

	protected _RlrsL89bialFQa9mzWurgsdr6FK()
	{
		_vbhwdZ3gErkBPSpla6ZPcciEtI1 = 750;
	}

	public void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		if (_XTvGE1JB69E9GLYnSRCwUVGb5PR <= 0)
		{
			return;
		}
		_XTvGE1JB69E9GLYnSRCwUVGb5PR -= _RlrsL89bialFQa9mzWurgsdr6FK<T>.smethod_0(gameTime_0).Milliseconds;
		if (_XTvGE1JB69E9GLYnSRCwUVGb5PR <= 0)
		{
			_XTvGE1JB69E9GLYnSRCwUVGb5PR = 0;
			_3wk7bXUbhNqSQ9kMD9hieEubOhG = _O0KnQCKZMolAHkzz0OlVM50NO3P;
			if (_O8DUpKIpqikHVGPGwFwT9XO5gPb != null)
			{
				_O8DUpKIpqikHVGPGwFwT9XO5gPb();
				_O8DUpKIpqikHVGPGwFwT9XO5gPb = null;
			}
		}
		else
		{
			float float_ = 1f - (float)_XTvGE1JB69E9GLYnSRCwUVGb5PR / (float)_vbhwdZ3gErkBPSpla6ZPcciEtI1;
			_3wk7bXUbhNqSQ9kMD9hieEubOhG = _Gs9QTlqmpM6Jpgrjf53LUcRTbM(_HfphKheLtbf0FIRRIg02hsTWuwA, _O0KnQCKZMolAHkzz0OlVM50NO3P, float_);
		}
	}

	protected abstract T _Gs9QTlqmpM6Jpgrjf53LUcRTbM(T gparam_0, T gparam_1, float float_0);

	protected void _9JRBBOsuQbaGxb3DQypwWYtojV0(T gparam_0, Action action_0)
	{
		if (_O8DUpKIpqikHVGPGwFwT9XO5gPb != null)
		{
			Action o8DUpKIpqikHVGPGwFwT9XO5gPb = _O8DUpKIpqikHVGPGwFwT9XO5gPb;
			_O8DUpKIpqikHVGPGwFwT9XO5gPb = null;
			o8DUpKIpqikHVGPGwFwT9XO5gPb();
		}
		_HfphKheLtbf0FIRRIg02hsTWuwA = _O0KnQCKZMolAHkzz0OlVM50NO3P;
		_O0KnQCKZMolAHkzz0OlVM50NO3P = gparam_0;
		_XTvGE1JB69E9GLYnSRCwUVGb5PR = _vbhwdZ3gErkBPSpla6ZPcciEtI1;
		_O8DUpKIpqikHVGPGwFwT9XO5gPb = action_0;
	}

	protected void _98dbKZq4dvkw2wLkjZ77Y5Ih4xP(T gparam_0)
	{
		if (_O8DUpKIpqikHVGPGwFwT9XO5gPb != null)
		{
			Action o8DUpKIpqikHVGPGwFwT9XO5gPb = _O8DUpKIpqikHVGPGwFwT9XO5gPb;
			_O8DUpKIpqikHVGPGwFwT9XO5gPb = null;
			o8DUpKIpqikHVGPGwFwT9XO5gPb();
		}
		_O0KnQCKZMolAHkzz0OlVM50NO3P = gparam_0;
		_3wk7bXUbhNqSQ9kMD9hieEubOhG = gparam_0;
		_XTvGE1JB69E9GLYnSRCwUVGb5PR = 0;
		_O8DUpKIpqikHVGPGwFwT9XO5gPb = null;
	}

	static TimeSpan smethod_0(GameTime gameTime_0)
	{
		return gameTime_0.get_ElapsedGameTime();
	}
}
