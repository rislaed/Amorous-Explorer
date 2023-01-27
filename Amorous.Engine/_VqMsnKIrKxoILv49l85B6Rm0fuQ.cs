using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework.Content;
using Spine;

public static class _VqMsnKIrKxoILv49l85B6Rm0fuQ
{
	public static SpineRenderer _7BVREQXEcBCieHb0qgaVDpUj1ni(this ContentManager content, string string_0, float float_0 = 1f, bool bool_0 = true, List<SkeletonJson.SpineEvent> list_0 = null)
	{
		string text = Path.Combine(content.RootDirectory, string_0);
		string atlasName = text + ".atlas.txt";
		Stream atlasStream = _K2047A8SCJdaw0LZKStEHOiH110._E0f25tLwwg9zgWpaN9mFdnGg2My(atlasName);
		Atlas atlas = new Atlas(atlasStream, string_0, _AUtA43NfhBNYDqRrVB1t9VQxe1v.Self);
		SkeletonJson skeletonJson = new SkeletonJson(atlas)
		{
			Scale = float_0
		};
		string spineName = text + ".json";
		Stream spineStream = _K2047A8SCJdaw0LZKStEHOiH110._E0f25tLwwg9zgWpaN9mFdnGg2My(spineName);
		SkeletonData data = skeletonJson.ReadSkeletonData(spineStream, spineName, list_0);
		Skeleton skeleton_ = new Skeleton(data);
		atlasStream.Dispose();
		spineStream.Dispose();
		return new SpineRenderer(skeleton_, bool_0);
	}
}
