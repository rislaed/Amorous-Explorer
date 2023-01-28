using Amorous.Game.Scenes;

public static class _9gbCIL8lNtgBPuVMJ6pA7rCsMoT
{
	public const int _YTdNKPTwbp4m0Jg1jmH65BXgUyA = 5;

	private const string _ENXeuLPZ4Agrjj7fGPJeMcL0qVA = "PrologueDone";

	public static void _NG0eIZcXsX6Fp38GhuED0LKeWHf(SaveData save)
	{
		if (save.Version == 0)
		{
			if (save.PlayerData.GetDecimal("Prologue") >= 20)
			{
				save.PhoneEnabled = true;
			}
			save.Version = 1;
		}
		if (save.Version == 1)
		{
			if (save.PlayerData.GetBit("PrologueDone"))
			{
				save.PlayerData.SetDecimal("Prologue", 40);
			}
			save.Version = 2;
		}
		if (save.Version == 2)
		{
			save.PlayerData.Remove("Player.Gender");
			save.PlayerData.SetDecimal("Gender", 10);
			save.Version = 3;
		}
		if (save.Version == 3)
		{
			save.Version = 4;
		}
		if (save.Version == 4)
		{
			save.CutsceneState = null;
			save.Version = 5;
		}
	}

	public static bool _RUw8RieezXPoVSmbk3eROtfKXVi(IAmorous game, SaveData save)
	{
		if (save.PlayerData.GetDecimal("Prologue") == 30 && save.PlayerData.GetDecimal("Gender") == 10)
		{
			game.StartScene(new SaveMigrationScene(game, "Gender", save.SceneName));
			return true;
		}
		return false;
	}
}
