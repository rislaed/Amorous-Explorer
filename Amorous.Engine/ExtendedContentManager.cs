using System;
using System.IO;
using Microsoft.Xna.Framework.Content;

public class ExtendedContentManager : ContentManager
{
	public ExtendedContentManager(IServiceProvider serviceProvider)
		: base(serviceProvider) {}

	public ExtendedContentManager(IServiceProvider serviceProvider, string rootDirectory)
		: base(serviceProvider, rootDirectory) {}

	protected override Stream OpenStream(string assetName)
	{
		return _K2047A8SCJdaw0LZKStEHOiH110._E0f25tLwwg9zgWpaN9mFdnGg2My(base.OpenStream(assetName));
	}
}
