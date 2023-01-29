using System.Collections.Generic;

public class FilterableClothes : IFilterable
{ // _EZ0kOLXoEoEfWGQDdTbNqaPzDUh
	public string Name { get; private set; }
	public List<string> Parts { get; private set; }
	public bool IsBlockingNudes { get; private set; }
	public bool IsReplacement { get; private set; }
	public bool IsShirt { get; set; }
	public bool IsPants { get; set; }
	public bool Updatable { get; set; }
	public bool IsCensoringShirt { get; set; }
	public bool IsCensoringPants { get; set; }

	public FilterableClothes(string name, params string[] parts)
	{
		Name = name;
		Parts = new List<string>(parts);
		IsBlockingNudes = true;
	}

	public FilterableClothes AsNudes()
	{
		IsBlockingNudes = false;
		return this;
	}

	public FilterableClothes AsCloth()
	{
		IsBlockingNudes = true;
		return this;
	}

	public FilterableClothes SetIsOverlay()
	{
		IsReplacement = false;
		return this;
	}

	public FilterableClothes SetIsReplacement()
	{
		IsReplacement = true;
		return this;
	}

	public FilterableClothes AsShirt()
	{
		IsShirt = true;
		return this;
	}

	public FilterableClothes AsPants()
	{
		IsPants = true;
		return this;
	}

	public FilterableClothes AsCensoredShirt()
	{
		IsCensoringShirt = true;
		return this;
	}

	public FilterableClothes AsCensoredPants()
	{
		IsCensoringPants = true;
		return this;
	}

	public IEnumerable<string> Filter()
	{
		return Parts;
	}
}
