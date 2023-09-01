using System.Collections.Generic;

namespace Amorous.Explorer.GUI.Prototype;

public delegate void ChoiceEvent(IFragment fragment, string key);
public delegate void UnchoiceEvent(IFragment fragment, string key);

public interface IChoiceable
{
	ICollection<string> Items { get; }
	string SelectedItem { get; set; }
	bool UnselectOnDeattach { get; set; }
	bool MayUnselected { get; set; }
	ChoiceEvent OnSelect { get; set; }
	UnchoiceEvent OnUnselect { get; set; }
}
