using System.Collections.Generic;

namespace Amorous.Explorer.GUI.Prototype;

public delegate void GroupChoiceEvent(IFragment fragment, string group, string key);
public delegate void GroupUnchoiceEvent(IFragment fragment, string group, string key);

public interface IGroupChoiceable
{
	IDictionary<string, ICollection<string>> Groups { get; }
	bool UnselectOnDeattach { get; set; }
	bool MayUnselected { get; set; }
	GroupChoiceEvent OnGroupSelect { get; set; }
	GroupUnchoiceEvent OnGroupUnselect { get; set; }
}
