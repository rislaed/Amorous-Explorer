using Squid;

namespace Amorous.Explorer.GUI.View.Inherits;

public class AmorousSlider : Slider
{
	public AmorousSlider()
	{
		base.Dock = DockStyle.Top;
		base.Style = "scrollSlider";
		base.Orientation = Orientation.Horizontal;
		base.Size = new Squid.Point(0, AmorousData.ButtonHeight);
		base.Button.Style = "scrollSliderButton";
	}
}
