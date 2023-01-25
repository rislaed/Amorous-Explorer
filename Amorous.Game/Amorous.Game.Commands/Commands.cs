namespace Amorous.Game.Commands;

public class Commands
{
	[_cHVuWjDON6rywwdWoqHCMj9ZKR(_qXE0hlPdNyl0lTUyddbAS1PZhVV = "Amount", Name = "Amount", _3aoBdJvXEwMLqtoffOySYmetk8t = "How many ingredients should the player pick?")]
	[_x2edoMtYt97ClE6KEKnT8Q2ei8R(Name = "Cooking: Select Ingredient", _3aoBdJvXEwMLqtoffOySYmetk8t = "Allow the player to select an ingredient in the cooking minigame.")]
	public class CookingSelectIngredient
	{
		public const string PARAMETER_AMOUNT = "Amount";
	}

	[_x2edoMtYt97ClE6KEKnT8Q2ei8R(Name = "Cooking: Show Result", _3aoBdJvXEwMLqtoffOySYmetk8t = "Show how well the player did in the cooking minigame.")]
	public class CookingShowResult
	{
	}

	[_x2edoMtYt97ClE6KEKnT8Q2ei8R(Name = "Remy: Show Nudes", _3aoBdJvXEwMLqtoffOySYmetk8t = "Select one of four nudes to show")]
	[_cHVuWjDON6rywwdWoqHCMj9ZKR(_qXE0hlPdNyl0lTUyddbAS1PZhVV = "Nude", Name = "Nude Picture", _3aoBdJvXEwMLqtoffOySYmetk8t = "Possible values: 0, 1, 2 or 3")]
	public class RemyShowNudes
	{
		public const string PARAMETER_NUDE = "Nude";
	}

	[_x2edoMtYt97ClE6KEKnT8Q2ei8R(Name = "Remy: Hide Nudes", _3aoBdJvXEwMLqtoffOySYmetk8t = "Hide whichever nude is visible")]
	public class RemyHideNudes
	{
	}

	[_cHVuWjDON6rywwdWoqHCMj9ZKR(_qXE0hlPdNyl0lTUyddbAS1PZhVV = "Cutscene", Name = "Quest Name")]
	[_x2edoMtYt97ClE6KEKnT8Q2ei8R(Name = "Start Quest", _3aoBdJvXEwMLqtoffOySYmetk8t = "Start a Quest")]
	public class PlayCutscene
	{
		public const string PARAMETER_CUTSCENE = "Cutscene";
	}
}
