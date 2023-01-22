using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework.Content;
using Spine;

public static class _VqMsnKIrKxoILv49l85B6Rm0fuQ
{
	public static _nHdiyIURlAiaNZ8u6MKzxjcwnyL _7BVREQXEcBCieHb0qgaVDpUj1ni(this ContentManager contentManager_0, string string_0, float float_0 = 1f, bool bool_0 = true, List<SpineEvent> list_0 = null)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		string text = Path.Combine(contentManager_0.get_RootDirectory(), string_0);
		string stream_ = text + ".atlas.txt";
		Stream stream = _K2047A8SCJdaw0LZKStEHOiH110._E0f25tLwwg9zgWpaN9mFdnGg2My((Stream)(object)stream_);
		Atlas val = new Atlas(stream, string_0, (TextureLoader)(object)_AUtA43NfhBNYDqRrVB1t9VQxe1v._yuFBJdi7mxrwMFQ57BjLjSq6ESj);
		SkeletonJson val2 = new SkeletonJson((Atlas[])(object)new Atlas[1] { val });
		val2.set_Scale(float_0);
		SkeletonJson val3 = val2;
		string text2 = text + ".json";
		Stream stream2 = _K2047A8SCJdaw0LZKStEHOiH110._E0f25tLwwg9zgWpaN9mFdnGg2My((Stream)(object)text2);
		SkeletonData val4 = val3.ReadSkeletonData(stream2, text2, list_0);
		Skeleton skeleton_ = new Skeleton(val4);
		stream.Dispose();
		stream2.Dispose();
		return new _nHdiyIURlAiaNZ8u6MKzxjcwnyL(skeleton_, bool_0);
	}

	static string smethod_0(ContentManager contentManager_0)
	{
		return contentManager_0.get_RootDirectory();
	}

	static string smethod_1(string string_0, string string_1)
	{
		return Path.Combine(string_0, string_1);
	}

	static string smethod_2(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static Atlas smethod_3(Stream stream_0, string string_0, TextureLoader textureLoader_0)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return new Atlas(stream_0, string_0, textureLoader_0);
	}

	static SkeletonJson smethod_4(Atlas[] atlas_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new SkeletonJson(atlas_0);
	}

	static void smethod_5(SkeletonJson skeletonJson_0, float float_0)
	{
		skeletonJson_0.set_Scale(float_0);
	}

	static SkeletonData smethod_6(SkeletonJson skeletonJson_0, Stream stream_0, string string_0, List<SpineEvent> list_0)
	{
		return skeletonJson_0.ReadSkeletonData(stream_0, string_0, list_0);
	}

	static Skeleton smethod_7(SkeletonData skeletonData_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Skeleton(skeletonData_0);
	}

	static void smethod_8(Stream stream_0)
	{
		stream_0.Dispose();
	}
}
