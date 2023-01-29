using System;
using System.IO;
using Microsoft.Xna.Framework.Content;

public class ExtendedContentManager : ContentManager
{ // _xM5N1Fg3VZCSTaBWtPXoS6nJ82E
	public ExtendedContentManager(IServiceProvider serviceProvider)
		: base(serviceProvider) {}

	public ExtendedContentManager(IServiceProvider serviceProvider, string rootDirectory)
		: base(serviceProvider, rootDirectory) {}

	protected override Stream OpenStream(string assetName)
	{
		return Compressions.ReadStream(base.OpenStream(assetName));
	}
}
