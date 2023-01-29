using System;

[AttributeUsage(AttributeTargets.Class)]
public class CommandParameter : Attribute
{ // _cHVuWjDON6rywwdWoqHCMj9ZKR
	public string Key { get; set; }
	public string Name { get; set; }
	public string Text { get; set; }
	public string Value { get; set; }
}
