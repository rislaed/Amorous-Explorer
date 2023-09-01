using Squid;

namespace Amorous.Explorer.GUI.View.Inherits;

public class AmorousMessage : Label
{
	public AmorousMessage()
	{
		base.Dock = DockStyle.Top;
		base.Margin = new Margin(10, 5, 10, 5);
		base.TextWrap = true;
		base.AutoSize = AutoSize.Vertical;
	}
}
