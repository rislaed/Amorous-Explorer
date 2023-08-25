using Microsoft.Xna.Framework;

public class PhoneUrgentlyRinging
{ // _dvyBDFOZwoBLf9qqHSfHYLLXVwP
	private const int CYCLE = 6;

	private bool messaging, appearing;
	private float ticks;
	private readonly IAmorous game;

	public PhoneUrgentlyRinging(IAmorous game)
	{
		this.game = game;
	}

	public void Update(GameTime gameTime)
	{
		if (!PhoneOverlay.Enabled || game.Cutscene != null)
		{
			return;
		}
		if (PhoneOverlay.GetSingleton().ArmPose != PhoneOverlay.EArmPose.ArmUp)
		{
			if (appearing)
			{
				return;
			}
			if (messaging)
			{
				if (messaging && ticks < CYCLE)
				{
					ticks += (float)gameTime.ElapsedGameTime.Milliseconds / 1000f;
				}
				else if (messaging && ticks >= CYCLE)
				{
					messaging = false;
					ticks = 0f;
					appearing = true;
					PhoneOverlay.State = PhoneOverlay.EPhoneState.MessageUrgent;
				}
			}
			else
			{
				messaging = true;
				PhoneOverlay.State = PhoneOverlay.EPhoneState.MessageNew;
			}
		}
		else if (PhoneOverlay.State != PhoneOverlay.EPhoneState.NoMessage)
		{
			messaging = false;
			ticks = 0f;
			appearing = false;
			PhoneOverlay.State = PhoneOverlay.EPhoneState.NoMessage;
		}
	}

	public void End()
	{
		if (PhoneOverlay.Enabled)
		{
			PhoneOverlay.State = PhoneOverlay.EPhoneState.NoMessage;
		}
	}
}
