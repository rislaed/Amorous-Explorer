using System;
using Microsoft.Xna.Framework;

public class _dvyBDFOZwoBLf9qqHSfHYLLXVwP
{
	private const int _6gOkbV73UuGDwox33JlOk45SEpd = 6;

	private bool _ozrhTFHF7sXDU6ysB7cHxLveAAS;

	private bool _VFsmChWIb7RoYgotfAQskmL1dY7;

	private float _znKl2SuVqjuhuU4ZYVKzq6zGvfb;

	private readonly IAmorous Amorous;

	public _dvyBDFOZwoBLf9qqHSfHYLLXVwP(IAmorous game)
	{
		Amorous = game;
	}

	public void Update(GameTime gameTime_0)
	{
		if (!_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj || Amorous._5zNdOw7qHmuCAPJFMr3SsZdBlCr != null)
		{
			return;
		}
		if (_poenyHBGUusBcnNcTFB9MQBV72R._AZrO8MxMUE7cKsFYTQ4k9O3q7yC()._j2OEvLQtM2lODSmH3ZFP6wWCWpF != _poenyHBGUusBcnNcTFB9MQBV72R._fFGgY4gvWNcTLSlsfe9k99ctumb.ArmUp)
		{
			if (_VFsmChWIb7RoYgotfAQskmL1dY7)
			{
				return;
			}
			if (_ozrhTFHF7sXDU6ysB7cHxLveAAS)
			{
				if (_ozrhTFHF7sXDU6ysB7cHxLveAAS && _znKl2SuVqjuhuU4ZYVKzq6zGvfb < 6f)
				{
					_znKl2SuVqjuhuU4ZYVKzq6zGvfb += (float)gameTime_0.ElapsedGameTime.Milliseconds / 1000f;
				}
				else if (_ozrhTFHF7sXDU6ysB7cHxLveAAS && _znKl2SuVqjuhuU4ZYVKzq6zGvfb >= 6f)
				{
					_ozrhTFHF7sXDU6ysB7cHxLveAAS = false;
					_znKl2SuVqjuhuU4ZYVKzq6zGvfb = 0f;
					_VFsmChWIb7RoYgotfAQskmL1dY7 = true;
					_poenyHBGUusBcnNcTFB9MQBV72R._f2smFxmYyFJyj81xWGaGLB2G7ef = _poenyHBGUusBcnNcTFB9MQBV72R._wlQdV74JhqkBVxNonpbfqZEmjIbA.MessageUrgent;
				}
			}
			else
			{
				_ozrhTFHF7sXDU6ysB7cHxLveAAS = true;
				_poenyHBGUusBcnNcTFB9MQBV72R._f2smFxmYyFJyj81xWGaGLB2G7ef = _poenyHBGUusBcnNcTFB9MQBV72R._wlQdV74JhqkBVxNonpbfqZEmjIbA.MessageNew;
			}
		}
		else if (_poenyHBGUusBcnNcTFB9MQBV72R._f2smFxmYyFJyj81xWGaGLB2G7ef != _poenyHBGUusBcnNcTFB9MQBV72R._wlQdV74JhqkBVxNonpbfqZEmjIbA.NoMessage)
		{
			_ozrhTFHF7sXDU6ysB7cHxLveAAS = false;
			_znKl2SuVqjuhuU4ZYVKzq6zGvfb = 0f;
			_VFsmChWIb7RoYgotfAQskmL1dY7 = false;
			_poenyHBGUusBcnNcTFB9MQBV72R._f2smFxmYyFJyj81xWGaGLB2G7ef = _poenyHBGUusBcnNcTFB9MQBV72R._wlQdV74JhqkBVxNonpbfqZEmjIbA.NoMessage;
		}
	}

	public void End()
	{
		if (_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj)
		{
			_poenyHBGUusBcnNcTFB9MQBV72R._f2smFxmYyFJyj81xWGaGLB2G7ef = _poenyHBGUusBcnNcTFB9MQBV72R._wlQdV74JhqkBVxNonpbfqZEmjIbA.NoMessage;
		}
	}
}
