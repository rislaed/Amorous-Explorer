namespace Amorous.Game.Commands;

public class Commands
{
	[CommandDescription(Name = "Cooking: Select Ingredient", Text = "Allow the player to select an ingredient in the cooking minigame.")]
	[CommandParameter(Key = PARAMETER_AMOUNT, Name = "Amount", Text = "How many ingredients should the player pick?")]
	public class CookingSelectIngredient
	{
		public const string PARAMETER_AMOUNT = "Amount";
	}

	[CommandDescription(Name = "Cooking: Show Result", Text = "Show how well the player did in the cooking minigame.")]
	public class CookingShowResult {}

	[CommandDescription(Name = "Remy: Show Nudes", Text = "Select one of four nudes to show")]
	[CommandParameter(Key = PARAMETER_NUDE, Name = "Nude Picture", Text = "Possible values: 0, 1, 2 or 3")]
	public class RemyShowNudes
	{
		public const string PARAMETER_NUDE = "Nude";
	}

	[CommandDescription(Name = "Remy: Hide Nudes", Text = "Hide whichever nude is visible")]
	public class RemyHideNudes {}


	[CommandDescription(Name = "Start Quest", Text = "Start a Quest")]
	[CommandParameter(Key = PARAMETER_CUTSCENE, Name = "Quest Name")]
	public class PlayCutscene
	{
		public const string PARAMETER_CUTSCENE = "Cutscene";
	}
}
