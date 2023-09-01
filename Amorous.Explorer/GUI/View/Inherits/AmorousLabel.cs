using Amorous.Explorer.Data;
using Squid;

namespace Amorous.Explorer.GUI.View.Inherits;

public class AmorousLabel : Label
{
	public int Offset { get; set; } = 10;
	public int Misalign { get; set; } = 5;

	public AmorousLabel()
	{
		base.Dock = DockStyle.Top;
	}

	protected override void OnLateUpdate()
	{
		int offset = 0;
		if (Offset != 0 && Parent is IControlContainer container)
		{
			Control control = this;
			do
			{
				if (container.Controls.GetFirstChildren() != control)
				{
					if (((Control)container).GetElements().GetFirstChildren() != control)
					{
						control = (Control)container;
						continue;
					}
				}
				offset = Offset;
				break;
			}
			while ((container = ((Control)container).Container) != null && !(container is Window) && !(container is Panel));
		}
		if (Dock == DockStyle.Left || Dock == DockStyle.CenterY || Dock == DockStyle.FillY)
		{
			Margin = new Margin(offset, Misalign, 0, Misalign);
		}
		else if (Dock == DockStyle.Right)
		{
			Margin = new Margin(0, Misalign, offset, Misalign);
		}
		else if (Dock == DockStyle.Bottom)
		{
			Margin = new Margin(Misalign, 0, Misalign, offset);
		}
		else
		{
			Margin = new Margin(Misalign, offset, Misalign, 0);
		}
		base.OnLateUpdate();
	}
}
