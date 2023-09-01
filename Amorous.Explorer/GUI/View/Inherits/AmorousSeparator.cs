using System;
using Squid;

namespace Amorous.Explorer.GUI.View.Inherits;

public class AmorousSeparator : Control
{
	public int Scale { get => Math.Max(Size.x, Size.y); set => Size = new Point(value, value); }

	public AmorousSeparator()
	{
		base.Dock = DockStyle.Top;
		base.Size = new Point(10, 10);
		base.NoEvents = true;
	}
}
