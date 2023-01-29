using System.Collections.Generic;

public class FilterableEmotion : IFilterable
{ // _xmfdPa5IagU3cXbLL61gyoXAV7gA
	public string Name { get; private set; }
	public List<string> Parts { get; private set; }
	public string Blink { get; private set; }

	public FilterableEmotion(string name, params string[] parts)
	{
		Name = name;
		Parts = new List<string>(parts);
	}

	public FilterableEmotion WithBlinking(string name)
	{
		Blink = name;
		return this;
	}

	public IEnumerable<string> Filter()
	{
		return Parts;
	}
}
