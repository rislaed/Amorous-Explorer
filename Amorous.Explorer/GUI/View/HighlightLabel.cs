using System;
using System.Collections;
using System.ComponentModel;
using System.Reflection;
using Squid;

namespace Amorous.Explorer.GUI.View;

public class HighlightLabel : Label
{

	[IntColor]
	[DefaultValue(-1)]
	public int HightlightColor { get; set; } = -1;

	protected readonly IList Lines;

	private int? activeElementColor;
	private object activeElement;

	public HighlightLabel()
	{
		Lines = (IList)typeof(Label).GetField("Lines", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(this);
	}

	protected override void OnStateChanged()
	{
		base.OnStateChanged();
		activeElement = activeElementColor = null;
	}

	protected override void OnLateUpdate()
	{
		base.OnLateUpdate();
		if (Desktop != null && Desktop.HotControl != this)
		{
			if (activeElement != null)
			{
				activeElement.GetType().GetField("Color").SetValue(activeElement, activeElementColor);
				activeElement = null;
			}
			return;
		}
		Point mousePosition = Gui.MousePosition;
		foreach (object line in Lines)
		{
			IList elements = (IList)line.GetType().GetField("Elements").GetValue(line);
			foreach (object element in elements)
			{
				Type elementType = element.GetType();
				if ((bool)elementType.GetProperty("IsLink").GetValue(element, null) && ((Rectangle)elementType.GetField("Rectangle").GetValue(element)).Contains(mousePosition))
				{
					if (activeElement != null)
					{
						if (activeElement == element)
						{
							break;
						}
						activeElement.GetType().GetField("Color").SetValue(activeElement, activeElementColor);
					}
					FieldInfo colorField = elementType.GetField("Color");
					activeElementColor = (int?)colorField.GetValue(element);
					colorField.SetValue(activeElement = element, HightlightColor);
					break;
				}
			}
		}
	}
}
