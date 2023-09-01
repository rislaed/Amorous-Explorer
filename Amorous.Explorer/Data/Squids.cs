using System.Collections.Generic;
using Squid;

namespace Amorous.Explorer.Data;

public static class Squids
{
	public static Skin GenerateSkin()
	{
		Skin skin = Gui.GenerateStandardSkin();
		ControlStyle buttonOpaqueCheckable = new ControlStyle(skin["buttonOpaque"])
		{
			Tint = ColorInt.ARGB(0.5f, 1f, 1f, 1f)
		};
		buttonOpaqueCheckable.Checked.Texture = "button_down.dds";
		buttonOpaqueCheckable.CheckedFocused.Texture = "button_default.dds";
		buttonOpaqueCheckable.CheckedHot.Texture = "button_hot.dds";
		buttonOpaqueCheckable.CheckedPressed.Texture = "button_default.dds";
		ControlStyle buttonOpaqueSwitch = new ControlStyle(skin["buttonOpaque"])
		{
			Tint = ColorInt.ARGB(0.5f, 1f, 0f, 0f)
		};
		buttonOpaqueSwitch.Checked.Texture = "button_down.dds";
		buttonOpaqueSwitch.CheckedFocused.Texture = "button_default.dds";
		buttonOpaqueSwitch.CheckedHot.Texture = "button_hot.dds";
		buttonOpaqueSwitch.CheckedPressed.Texture = "button_default.dds";
		ControlStyle buttonOpaqueSelected = new ControlStyle(skin["buttonOpaque"])
		{
			Tint = ColorInt.ARGB(0.5f, 0f, 0.75f, 0f)
		};
		buttonOpaqueSelected.Checked.Texture = "button_down.dds";
		buttonOpaqueSelected.CheckedFocused.Texture = "button_default.dds";
		buttonOpaqueSelected.CheckedHot.Texture = "button_hot.dds";
		buttonOpaqueSelected.CheckedPressed.Texture = "button_default.dds";
		buttonOpaqueCheckable.Checked.Tint
			= buttonOpaqueCheckable.CheckedFocused.Tint
			= buttonOpaqueCheckable.CheckedHot.Tint
			= buttonOpaqueCheckable.CheckedPressed.Tint
			= buttonOpaqueSwitch.Checked.Tint
			= buttonOpaqueSwitch.CheckedFocused.Tint
			= buttonOpaqueSwitch.CheckedHot.Tint
			= buttonOpaqueSwitch.CheckedPressed.Tint
			= buttonOpaqueSelected.Checked.Tint
			= buttonOpaqueSelected.CheckedFocused.Tint
			= buttonOpaqueSelected.CheckedHot.Tint
			= buttonOpaqueSelected.CheckedPressed.Tint
			= ColorInt.ARGB(1f, 0f, 1f, 0f);
		skin.Add("buttonOpaqueCheckable", buttonOpaqueCheckable);
		skin.Add("buttonOpaqueSwitch", buttonOpaqueSwitch);
		skin.Add("buttonOpaqueSelected", buttonOpaqueSelected);
		ControlStyle buttonOpaquePendingable = new ControlStyle(skin["buttonOpaque"])
		{
			Tint = ColorInt.ARGB(0.5f, 1f, 1f, 1f)
		};
		buttonOpaquePendingable.Checked.Texture = "button_down.dds";
		buttonOpaquePendingable.CheckedFocused.Texture = "button_default.dds";
		buttonOpaquePendingable.CheckedHot.Texture = "button_hot.dds";
		buttonOpaquePendingable.CheckedPressed.Texture = "button_default.dds";
		ControlStyle buttonOpaqueQueued = new ControlStyle(skin["buttonOpaque"])
		{
			Tint = ColorInt.ARGB(0.5f, 0.75f, 0.75f, 0f)
		};
		buttonOpaqueQueued.Checked.Texture = "button_down.dds";
		buttonOpaqueQueued.CheckedFocused.Texture = "button_default.dds";
		buttonOpaqueQueued.CheckedHot.Texture = "button_hot.dds";
		buttonOpaqueQueued.CheckedPressed.Texture = "button_default.dds";
		buttonOpaquePendingable.Checked.Tint
			= buttonOpaquePendingable.CheckedFocused.Tint
			= buttonOpaquePendingable.CheckedHot.Tint
			= buttonOpaquePendingable.CheckedPressed.Tint
			= buttonOpaqueQueued.Checked.Tint
			= buttonOpaqueQueued.CheckedFocused.Tint
			= buttonOpaqueQueued.CheckedHot.Tint
			= buttonOpaqueQueued.CheckedPressed.Tint
			= ColorInt.ARGB(1f, 1f, 1f, 0f);
		skin.Add("buttonOpaquePendingable", buttonOpaquePendingable);
		skin.Add("buttonOpaqueQueued", buttonOpaqueQueued);
		ControlStyle buttonOpaqueDangerous = new ControlStyle(skin["buttonOpaque"])
		{
			Tint = ColorInt.ARGB(0.5f, 1f, 1f, 1f)
		};
		buttonOpaqueDangerous.Checked.Texture = "button_down.dds";
		buttonOpaqueDangerous.CheckedFocused.Texture = "button_default.dds";
		buttonOpaqueDangerous.CheckedHot.Texture = "button_hot.dds";
		buttonOpaqueDangerous.CheckedPressed.Texture = "button_default.dds";
		ControlStyle buttonOpaqueLocked = new ControlStyle(skin["buttonOpaque"])
		{
			Tint = ColorInt.ARGB(0.5f, 0.75f, 0f, 0f)
		};
		buttonOpaqueLocked.Checked.Texture = "button_down.dds";
		buttonOpaqueLocked.CheckedFocused.Texture = "button_default.dds";
		buttonOpaqueLocked.CheckedHot.Texture = "button_hot.dds";
		buttonOpaqueLocked.CheckedPressed.Texture = "button_default.dds";
		buttonOpaqueDangerous.Checked.Tint
			= buttonOpaqueDangerous.CheckedFocused.Tint
			= buttonOpaqueDangerous.CheckedHot.Tint
			= buttonOpaqueDangerous.CheckedPressed.Tint
			= buttonOpaqueLocked.Checked.Tint
			= buttonOpaqueLocked.CheckedFocused.Tint
			= buttonOpaqueLocked.CheckedHot.Tint
			= buttonOpaqueLocked.CheckedPressed.Tint
			= ColorInt.ARGB(1f, 1f, 0f, 0f);
		ControlStyle textboxLocked = new ControlStyle(skin["textbox"])
		{
			Tint = ColorInt.ARGB(1f, 1f, 0f, 0f)
		};
		skin.Add("buttonOpaqueDangerous", buttonOpaqueDangerous);
		skin.Add("buttonOpaqueLocked", buttonOpaqueLocked);
		skin.Add("textboxLocked", textboxLocked);
		ControlStyle buttonAccent = new ControlStyle(skin["button"])
		{
			Tint = ColorInt.ARGB(1f, 0f, 1f, 0f)
		};
		buttonAccent.Default.Texture = "button_down.dds";
		buttonAccent.Focused.Texture = buttonAccent.CheckedFocused.Texture = buttonAccent.SelectedFocused.Texture = "button_default.dds";
		buttonAccent.Hot.Texture = buttonAccent.CheckedHot.Texture = buttonAccent.SelectedHot.Texture = "button_hot.dds";
		buttonAccent.Pressed.Texture = buttonAccent.CheckedPressed.Texture = buttonAccent.SelectedPressed.Texture = "button_default.dds";
		skin.Add("buttonAccent", buttonAccent);
		foreach (ControlStyle style in skin.Values)
		{
			style.TextPadding = new Margin(10, 0, 10, 0);
		}
		return skin;
	}

	public static IEnumerable<Control> GetChildrensExceptContainer(this Control control, bool subwindows = false)
	{
		Control parent;
		while ((parent = control.Parent) != null && (subwindows || !(control is Window)))
		{
			if (parent is IControlContainer container)
			{
				foreach (Control subcontrol in container.Controls)
				{
					if (subcontrol != control)
					{
						yield return subcontrol;
					}
				}
			}
			foreach (Control subcontrol in parent.GetElements())
			{
				if (subcontrol != control)
				{
					yield return subcontrol;
				}
			}
			control = parent;
		}
	}

	public static void Lock(this Control control, bool subwindows = false)
	{
		foreach (Control subcontrol in control.GetChildrensExceptContainer(subwindows))
		{
			subcontrol.Enabled = false;
		}
	}

	public static void Unlock(this Control control, bool subwindows = false)
	{
		foreach (Control subcontrol in control.GetChildrensExceptContainer(subwindows))
		{
			subcontrol.Enabled = true;
		}
	}

	public static Control GetFirstChildren(this IEnumerable<Control> controls)
	{
		foreach (Control control in controls)
		{
			if (control.Visible && (control.Size.x > 0 || control.Size.y > 0))
			{
				return control;
			}
		}
		return null;
	}
}
