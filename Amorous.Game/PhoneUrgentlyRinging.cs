using Microsoft.Xna.Framework;

public class PhoneUrgentlyRinging
{ // _dvyBDFOZwoBLf9qqHSfHYLLXVwP
	private const int Cycle = 6;

	private bool _message, _appeared;
	private float _ticks;
	private readonly IAmorous _game;

	public PhoneUrgentlyRinging(IAmorous game)
	{
		_game = game;
	}

	public void Update(GameTime gameTime)
	{
		if (!PhoneOverlay.Enabled || _game.Cutscene != null)
		{
			return;
		}
		if (PhoneOverlay.Get().Pose != PhoneOverlay.ArmPose.ArmUp)
		{
			if (_appeared)
			{
				return;
			}
			if (_message)
			{
				if (_message && _ticks < Cycle)
				{
					_ticks += (float)gameTime.ElapsedGameTime.Milliseconds / 1000f;
				}
				else if (_message && _ticks >= Cycle)
				{
					_message = false;
					_ticks = 0f;
					_appeared = true;
					PhoneOverlay.Indicator = PhoneOverlay.PhoneIndicator.MessageUrgent;
				}
			}
			else
			{
				_message = true;
				PhoneOverlay.Indicator = PhoneOverlay.PhoneIndicator.MessageNew;
			}
		}
		else if (PhoneOverlay.Indicator != PhoneOverlay.PhoneIndicator.NoMessage)
		{
			_message = false;
			_ticks = 0f;
			_appeared = false;
			PhoneOverlay.Indicator = PhoneOverlay.PhoneIndicator.NoMessage;
		}
	}

	public void End()
	{
		if (PhoneOverlay.Enabled)
		{
			PhoneOverlay.Indicator = PhoneOverlay.PhoneIndicator.NoMessage;
		}
	}
}
