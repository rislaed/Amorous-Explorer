using System.Collections.Generic;

namespace Amorous.Explorer.GUI.Prototype;

public delegate void MultiChoiceEvent(IFragment fragment, ICollection<string> keys);

public interface IMultiChoiceable
{
	ICollection<string> Items { get; }
	ICollection<string> SelectedItems { get; set; }
	bool UnselectOnDeattach { get; set; }
	MultiChoiceEvent OnChecked { get; set; }
}
