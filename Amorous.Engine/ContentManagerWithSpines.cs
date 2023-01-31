using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework.Content;
using Spine;

public static class ContentManagerWithSpines
{ // _VqMsnKIrKxoILv49l85B6Rm0fuQ
	public static SpineRenderer LoadSkeleton(this ContentManager content, string name, float scale = 1f, bool premultipliedAlpha = true, List<SkeletonJson.SpineEvent> events = null)
	{
		string directory = Path.Combine(content.RootDirectory, name);
		string atlasName = directory + ".atlas.txt";
		Stream atlasStream = Compressions.ReadStream(atlasName);
		Atlas atlas = new Atlas(atlasStream, name, SpineTextureLoader.Singleton);
		SkeletonJson skeletonJson = new SkeletonJson(atlas)
		{
			Scale = scale
		};
		string spineName = directory + ".json";
		Stream spineStream = Compressions.ReadStream(spineName);
		SkeletonData data = skeletonJson.ReadSkeletonData(spineStream, spineName, events);
		Skeleton skeleton = new Skeleton(data);
		atlasStream.Dispose();
		spineStream.Dispose();
		return new SpineRenderer(skeleton, premultipliedAlpha);
	}
}
