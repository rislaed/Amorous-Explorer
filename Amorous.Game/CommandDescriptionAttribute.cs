using System;

[AttributeUsage(AttributeTargets.Class)]
public class CommandDescriptionAttribute : Attribute
{ // _x2edoMtYt97ClE6KEKnT8Q2ei8R
	public string Name { get; set; }
	public string Text { get; set; }
}
