using System;
using System.Collections.Generic;
using System.Linq;
using Squid;

public static class Overlays
{ // _KyKsjBAROeUAsKraBIxtuHTSPwg
	public static Action ExitWithoutSavingChanges;
	public const int ShortDialogueWidth = 250;
	public const int WideDialogueWidth = 500;

	public static void ShowSave(this IAmorous game, Desktop desktop, Action<bool> then)
	{
		then(obj: false);
		List<Saves.Item> pointers = Saves.GetItems(excludeAutosaves: true);
		List<string> pointerNames = pointers.Select((Saves.Item pointer) => pointer.Name).ToList();
		pointerNames.Add("Oops, I've changed my mind!");
		desktop.ShowSelection("Which slot do you wish to save to?", pointerNames.ToArray(), WideDialogueWidth, delegate(int index)
		{
			if (index != pointerNames.Count - 1)
			{
				Saves.Item pointer = pointers[index];
				if (!pointer.IsEmpty)
				{
					desktop.ShowSelection($"Are you sure you wish to overwrite slot #{pointer.Index + 1}?", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, ShortDialogueWidth, delegate(int index)
					{
						if (index == 1)
						{
							game.SaveAtSlot(pointer.Index);
						}
						then(obj: true);
					});
				}
				else
				{
					game.SaveAtSlot(pointer.Index);
					then(obj: true);
				}
			}
			else
			{
				then(obj: true);
			}
		});
	}

	public static void ShowLoad(this IAmorous game, Desktop desktop, Action<bool> then)
	{
		then(obj: false);
		List<Saves.Item> pointers = Saves.GetItems(excludeAutosaves: true);
		List<string> pointerNames = pointers.Select((Saves.Item pointer) => pointer.Name).ToList();
		pointerNames.Add("Oops, I've changed my mind!");
		desktop.ShowSelection("Which save do you wish to load?", pointerNames.ToArray(), WideDialogueWidth, delegate(int index)
		{
			if (index == pointerNames.Count - 1)
			{
				then(obj: true);
			}
			else
			{
				Saves.Item pointer = pointers[index];
				if (!pointer.IsEmpty)
				{
					desktop.ShowSelection($"Are you sure you wish to load slot #{pointer.Index + 1}?", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, ShortDialogueWidth, delegate(int index)
					{
						if (index == 1)
						{
							game.ReadFromSlot(pointer.Index);
						}
						then(obj: true);
					});
				}
				else
				{
					desktop.ShowConfirm(string.Format("There is no save in {0}slot #{1}!", pointer.IsAutosave ? "autosave " : string.Empty, index + 1), ShortDialogueWidth, "OK", delegate
					{
						then(obj: true);
					});
				}
			}
		});
	}

	public static void ShowExit(this IAmorous game, Desktop desktop, Action<bool> then)
	{
		then(obj: false);
		desktop.ShowSelection("Are you sure you wish to exit the Game? All unsaved progress will be lost!", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, WideDialogueWidth, delegate(int index)
		{
			if (index == 1)
			{
				if (ExitWithoutSavingChanges != null)
				{
					ExitWithoutSavingChanges();
				}
				else
				{
					game.Exit();
				}
			}
			then(obj: true);
		});
	}
}
