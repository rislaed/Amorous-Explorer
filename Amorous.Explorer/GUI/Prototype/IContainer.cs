using System.Collections.Generic;

namespace Amorous.Explorer.GUI.Prototype;

public interface IContainer : IFragment
{
	public IFragment Fragment { get; }
	public IEnumerable<IContainer> Containers { get; }
	public IEnumerable<IContainer> Subcontainers { get; }
}
