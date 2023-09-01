using Amorous.Explorer.GUI.Prototype;
using Amorous.Explorer.GUI.View;
using Squid;

namespace Amorous.Explorer.GUI.Model;

public class CarouselPanelFragment : Fragment
{
	public CarouselPanel Carousel { get; protected set; }
	public bool FitToWidth { get => Carousel.FitToWidth; set => Carousel.FitToWidth = value; }
	public int MeasuredWidth { get => Carousel.MeasuredWidth; set => Carousel.MeasuredWidth = value; }

	protected override IControlContainer Subcontainer => Carousel.Content;

	public CarouselPanelFragment(AbstractDesktop desktop = null) : base(desktop)
	{
		Carousel = new CarouselPanel()
		{
			Dock = DockStyle.Top,
			FitToWidth = true
		};
	}

	protected override void InternalAttach()
	{
		if (!IsReattaching)
		{
			Root?.Controls.Add(Carousel);
		}
		base.InternalAttach();
	}

	protected override void InternalDeattach()
	{
		base.InternalDeattach();
		if (!IsReattaching)
		{
			Root?.Controls.Remove(Carousel);
		}
	}
}
