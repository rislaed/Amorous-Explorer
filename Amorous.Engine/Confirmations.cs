using System;
using System.Collections.Generic;
using System.Linq;
using Squid;

public static class Confirmations
{
	public static Action WhenReturnToMenu;

	public const int ShortDialogue = 250;
	public const int WideDialogue = 500;

	public static void ConfirmSaving(this IAmorous game, Desktop desktop, Action<bool> then)
	{
		then(obj: false);
		List<Saves.Pointer> pointers = Saves.GetPointers(excludeAutosaves: true);
		List<string> pointerNames = pointers.Select((Saves.Pointer _3CCr8Bt1rkuzt0M6gYLbceJGV0p_0) => _3CCr8Bt1rkuzt0M6gYLbceJGV0p_0.Name).ToList();
		pointerNames.Add("Oops, I've changed my mind!");
		desktop.ShowSelection("Which slot do you wish to save to?", pointerNames.ToArray(), WideDialogue, delegate(int index)
		{
			if (index != pointerNames.Count - 1)
			{
				Saves.Pointer pointer = pointers[index];
				if (!pointer.IsEmpty)
				{
					desktop.ShowSelection($"Are you sure you wish to overwrite slot #{pointer.Index + 1}?", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, ShortDialogue, delegate(int index)
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

	public static void ConfirmLoading(this IAmorous game, Desktop desktop, Action<bool> then)
	{
		then(obj: false);
		List<Saves.Pointer> pointers = Saves.GetPointers(excludeAutosaves: true);
		List<string> pointerNames = pointers.Select((Saves.Pointer _3CCr8Bt1rkuzt0M6gYLbceJGV0p_0) => _3CCr8Bt1rkuzt0M6gYLbceJGV0p_0.Name).ToList();
		pointerNames.Add("Oops, I've changed my mind!");
		desktop.ShowSelection("Which save do you wish to load?", pointerNames.ToArray(), WideDialogue, delegate(int index)
		{
			if (index == pointerNames.Count - 1)
			{
				then(obj: true);
			}
			else
			{
				Saves.Pointer pointer = pointers[index];
				if (!pointer.IsEmpty)
				{
					desktop.ShowSelection($"Are you sure you wish to load slot #{pointer.Index + 1}?", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, ShortDialogue, delegate(int index)
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
					desktop.ShowConfirm(string.Format("There is no save in {0}slot #{1}!", pointer.IsAutosave ? "autosave " : string.Empty, index + 1), ShortDialogue, "OK", delegate
					{
						then(obj: true);
					});
				}
			}
		});
	}

	public static void ConfirmLeave(this IAmorous game, Desktop desktop, Action<bool> then)
	{
		then(obj: false);
		desktop.ShowSelection("Are you sure you wish to exit the Game? All unsaved progress will be lost!", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, WideDialogue, delegate(int index)
		{
			if (index == 1)
			{
				if (WhenReturnToMenu != null)
				{
					WhenReturnToMenu();
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
