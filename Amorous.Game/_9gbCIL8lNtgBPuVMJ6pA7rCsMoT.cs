using Amorous.Game.Scenes;

public static class _9gbCIL8lNtgBPuVMJ6pA7rCsMoT
{
	public const int _YTdNKPTwbp4m0Jg1jmH65BXgUyA = 5;

	private const string _ENXeuLPZ4Agrjj7fGPJeMcL0qVA = "PrologueDone";

	public static void _NG0eIZcXsX6Fp38GhuED0LKeWHf(_lRHDfpOTd4PxClZkjMpoakPEA9d _lRHDfpOTd4PxClZkjMpoakPEA9d_0)
	{
		if (_lRHDfpOTd4PxClZkjMpoakPEA9d_0.Version == 0)
		{
			if (_lRHDfpOTd4PxClZkjMpoakPEA9d_0.PlayerData.GetDecimal("Prologue") >= 20)
			{
				_lRHDfpOTd4PxClZkjMpoakPEA9d_0.PhoneEnabled = true;
			}
			_lRHDfpOTd4PxClZkjMpoakPEA9d_0.Version = 1;
		}
		if (_lRHDfpOTd4PxClZkjMpoakPEA9d_0.Version == 1)
		{
			if (_lRHDfpOTd4PxClZkjMpoakPEA9d_0.PlayerData.GetBit("PrologueDone"))
			{
				_lRHDfpOTd4PxClZkjMpoakPEA9d_0.PlayerData.SetDecimal("Prologue", 40);
			}
			_lRHDfpOTd4PxClZkjMpoakPEA9d_0.Version = 2;
		}
		if (_lRHDfpOTd4PxClZkjMpoakPEA9d_0.Version == 2)
		{
			_lRHDfpOTd4PxClZkjMpoakPEA9d_0.PlayerData.Remove("Player.Gender");
			_lRHDfpOTd4PxClZkjMpoakPEA9d_0.PlayerData.SetDecimal("Gender", 10);
			_lRHDfpOTd4PxClZkjMpoakPEA9d_0.Version = 3;
		}
		if (_lRHDfpOTd4PxClZkjMpoakPEA9d_0.Version == 3)
		{
			_lRHDfpOTd4PxClZkjMpoakPEA9d_0.Version = 4;
		}
		if (_lRHDfpOTd4PxClZkjMpoakPEA9d_0.Version == 4)
		{
			_lRHDfpOTd4PxClZkjMpoakPEA9d_0.CutsceneState = null;
			_lRHDfpOTd4PxClZkjMpoakPEA9d_0.Version = 5;
		}
	}

	public static bool _RUw8RieezXPoVSmbk3eROtfKXVi(IAmorous game, _lRHDfpOTd4PxClZkjMpoakPEA9d _lRHDfpOTd4PxClZkjMpoakPEA9d_0)
	{
		if (_lRHDfpOTd4PxClZkjMpoakPEA9d_0.PlayerData.GetDecimal("Prologue") == 30 && _lRHDfpOTd4PxClZkjMpoakPEA9d_0.PlayerData.GetDecimal("Gender") == 10)
		{
			game.StartScene(new SaveMigrationScene(game, "Gender", _lRHDfpOTd4PxClZkjMpoakPEA9d_0.SceneName));
			return true;
		}
		return false;
	}
}
