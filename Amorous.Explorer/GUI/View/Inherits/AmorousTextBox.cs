using Squid;

namespace Amorous.Explorer.GUI.View.Inherits;

public class AmorousTextBox : TextBox
{
	public AmorousTextBox()
	{
		base.Dock = DockStyle.Top;
		base.Size = new Point(0, AmorousData.ButtonHeight);
	}
}
