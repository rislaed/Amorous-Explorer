using System;
using System.Globalization;
using System.Reflection;
using Squid;

namespace Amorous.Explorer.Specialized;

public static class DesktopExtensions
{
	public static void SetFocus(this Desktop desktop, Control control)
	{
		if (desktop == null)
		{
			throw new ArgumentNullException("desktop");
		}
		desktop.GetType().GetField("FocusedControl").SetValue(desktop, control, BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetField, null, CultureInfo.InvariantCulture);
	}
}
