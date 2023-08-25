using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework.Content;
using Spine;

public static class ContentManagerExtensions
{ // _VqMsnKIrKxoILv49l85B6Rm0fuQ
	public static SkeletonRenderer LoadSkeleton(this ContentManager content, string name, float scale = 1f, bool premultipliedAlpha = true, List<SkeletonJson.SpineEvent> events = null)
	{
		string path = Path.Combine(content.RootDirectory, name);
		string atlasPath = path + ".atlas.txt";
		Stream atlasStream = Compressions.ReadStream(atlasPath);
		Atlas atlas = new Atlas(atlasStream, name, SpineTextureLoader.Singleton);
		SkeletonJson skeletonJson = new SkeletonJson(atlas)
		{
			Scale = scale
		};
		string skeletonPath = path + ".json";
		Stream skeletonStream = Compressions.ReadStream(skeletonPath);
		SkeletonData data = skeletonJson.ReadSkeletonData(skeletonStream, skeletonPath, events);
		Skeleton skeleton = new Skeleton(data);
		atlasStream.Dispose();
		skeletonStream.Dispose();
		return new SkeletonRenderer(skeleton, premultipliedAlpha);
	}
}
