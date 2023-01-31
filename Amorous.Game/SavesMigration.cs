using Amorous.Game.Scenes;

public static class SavesMigration
{ // _9gbCIL8lNtgBPuVMJ6pA7rCsMoT
	public const int CurrentlyVersion = 5;

	private const string PrologueDone = "PrologueDone";

	public static void RestoreSaveData(SaveData save)
	{
		if (save.Version == 0)
		{
			if (save.PlayerData.GetState(AmorousData.Prologue) >= AmorousData.PhoneAllowedState)
			{
				save.PhoneEnabled = true;
			}
			save.Version = 1;
		}
		if (save.Version == 1)
		{
			if (save.PlayerData.GetFlag(PrologueDone))
			{
				save.PlayerData.SetStage(AmorousData.Prologue, AmorousData.PrologueStateCompleted);
			}
			save.Version = 2;
		}
		if (save.Version == 2)
		{
			save.PlayerData.Remove("Player.Gender");
			save.PlayerData.SetStage(AmorousData.Gender, 10);
			save.Version = 3;
		}
		if (save.Version == 3)
		{
			save.Version = 4;
		}
		if (save.Version == 4)
		{
			save.CutsceneState = null;
			save.Version = CurrentlyVersion;
		}
	}

	public static bool StartMigration(IAmorous game, SaveData save)
	{
		if (save.PlayerData.GetState(AmorousData.Prologue) == 30 && save.PlayerData.GetState(AmorousData.Gender) == 10)
		{
			game.StartScene(new SaveMigrationScene(game, AmorousData.Gender, save.SceneName));
			return true;
		}
		return false;
	}
}
