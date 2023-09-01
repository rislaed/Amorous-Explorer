using Squid;

namespace Amorous.Explorer.GUI.View.Inherits;

public class AmorousTextArea : TextArea
{
	public AmorousTextArea()
	{
		base.Dock = DockStyle.Top;
		base.AutoSize = AutoSize.Vertical;
	}
}
