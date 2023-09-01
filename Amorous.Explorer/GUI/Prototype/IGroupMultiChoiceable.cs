using System.Collections.Generic;

namespace Amorous.Explorer.GUI.Prototype;

public delegate void GroupMultiChoiceEvent(IFragment fragment, string group, ICollection<string> keys);

public interface IGroupMultiChoiceable
{
	IDictionary<string, ICollection<string>> Groups { get; }
	bool UnselectOnDeattach { get; set; }
	GroupMultiChoiceEvent OnGroupChecked { get; set; }
}
