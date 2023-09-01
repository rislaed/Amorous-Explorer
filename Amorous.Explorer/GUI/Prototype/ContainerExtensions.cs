using Amorous.Explorer.GUI.Prototype;

namespace Amorous.Explorer.GUI;

public static class ContainerExtensions
{
	public static IContainer GetContainer(this IFragment fragment)
	{
		while (fragment != null)
		{
			if (fragment is IContainer container)
			{
				return container;
			}
			fragment = fragment.Parent;
		}
		return null;
	}
}
