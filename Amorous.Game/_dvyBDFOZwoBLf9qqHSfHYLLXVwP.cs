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

	public void Update(GameTime gameTime)
	{
		if (!PhoneOverlay._kf3EbE0B70xGe1szklqAZyCqoLj || Amorous.Cutscene != null)
		{
			return;
		}
		if (PhoneOverlay.Get().Phase != PhoneOverlay.PhonePhase.ArmUp)
		{
			if (_VFsmChWIb7RoYgotfAQskmL1dY7)
			{
				return;
			}
			if (_ozrhTFHF7sXDU6ysB7cHxLveAAS)
			{
				if (_ozrhTFHF7sXDU6ysB7cHxLveAAS && _znKl2SuVqjuhuU4ZYVKzq6zGvfb < 6f)
				{
					_znKl2SuVqjuhuU4ZYVKzq6zGvfb += (float)gameTime.ElapsedGameTime.Milliseconds / 1000f;
				}
				else if (_ozrhTFHF7sXDU6ysB7cHxLveAAS && _znKl2SuVqjuhuU4ZYVKzq6zGvfb >= 6f)
				{
					_ozrhTFHF7sXDU6ysB7cHxLveAAS = false;
					_znKl2SuVqjuhuU4ZYVKzq6zGvfb = 0f;
					_VFsmChWIb7RoYgotfAQskmL1dY7 = true;
					PhoneOverlay.Indication = PhoneOverlay.PhoneIndication.MessageUrgent;
				}
			}
			else
			{
				_ozrhTFHF7sXDU6ysB7cHxLveAAS = true;
				PhoneOverlay.Indication = PhoneOverlay.PhoneIndication.MessageNew;
			}
		}
		else if (PhoneOverlay.Indication != PhoneOverlay.PhoneIndication.NoMessage)
		{
			_ozrhTFHF7sXDU6ysB7cHxLveAAS = false;
			_znKl2SuVqjuhuU4ZYVKzq6zGvfb = 0f;
			_VFsmChWIb7RoYgotfAQskmL1dY7 = false;
			PhoneOverlay.Indication = PhoneOverlay.PhoneIndication.NoMessage;
		}
	}

	public void End()
	{
		if (PhoneOverlay._kf3EbE0B70xGe1szklqAZyCqoLj)
		{
			PhoneOverlay.Indication = PhoneOverlay.PhoneIndication.NoMessage;
		}
	}
}
