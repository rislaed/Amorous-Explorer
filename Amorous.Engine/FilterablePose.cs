using System.Collections.Generic;

public class FilterablePose : IFilterable
{ // _NaKchYC4I4GjWR34SfBLAktysCE
	public string Name { get; private set; }
	public List<string> Parts { get; private set; }
	public List<string> Nudes { get; private set; }
	public List<FilterableClothes> Clothes { get; private set; }

	public FilterablePose(string name, params string[] parts)
	{
		Name = name;
		Parts = new List<string>(parts);
		Nudes = new List<string>();
		Clothes = new List<FilterableClothes>();
	}

	public FilterablePose AddNudes(params string[] nudes)
	{
		Nudes.AddRange(nudes);
		return this;
	}

	public IEnumerable<string> Filter()
	{
		List<string> clothes = new List<string>();
		bool replaces = false;
		bool blocked = false;
		foreach (FilterableClothes cloth in Clothes)
		{
			if (cloth.Updatable)
			{
				clothes.AddRange(cloth.Filter());
				replaces |= cloth.IsReplacement;
				blocked |= cloth.IsBlockingNudes;
			}
		}
		if (!replaces)
		{
			clothes.AddRange(Parts);
		}
		if (!blocked && !Censorship.Censored)
		{
			clothes.AddRange(Nudes);
		}
		return clothes;
	}
}
