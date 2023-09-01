using Squid;

namespace Amorous.Explorer.GUI.View.Inherits;

public class AmorousButton : Button
{
	public AmorousButton()
	{
		base.Dock = DockStyle.Top;
		base.Style = "buttonOpaque";
		base.TextAlign = Alignment.MiddleCenter;
	}
}
