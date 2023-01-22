using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework.Content;
using Spine;

public static class _VqMsnKIrKxoILv49l85B6Rm0fuQ
{
	public static _nHdiyIURlAiaNZ8u6MKzxjcwnyL _7BVREQXEcBCieHb0qgaVDpUj1ni(this ContentManager contentManager_0, string string_0, float float_0 = 1f, bool bool_0 = true, List<SpineEvent> list_0 = null)
	{
		string string_ = _VqMsnKIrKxoILv49l85B6Rm0fuQ.smethod_1(_VqMsnKIrKxoILv49l85B6Rm0fuQ.smethod_0(contentManager_0), string_0);
		string string_2 = _VqMsnKIrKxoILv49l85B6Rm0fuQ.smethod_2(string_, ".atlas.txt");
		Stream stream_ = _K2047A8SCJdaw0LZKStEHOiH110._E0f25tLwwg9zgWpaN9mFdnGg2My(string_2);
		Atlas val = _VqMsnKIrKxoILv49l85B6Rm0fuQ.smethod_3(stream_, string_0, (TextureLoader)(object)_AUtA43NfhBNYDqRrVB1t9VQxe1v._yuFBJdi7mxrwMFQ57BjLjSq6ESj);
		SkeletonJson obj = _VqMsnKIrKxoILv49l85B6Rm0fuQ.smethod_4((Atlas[])(object)new Atlas[1] { val });
		_VqMsnKIrKxoILv49l85B6Rm0fuQ.smethod_5(obj, float_0);
		SkeletonJson skeletonJson_ = obj;
		string string_3 = _VqMsnKIrKxoILv49l85B6Rm0fuQ.smethod_2(string_, ".json");
		Stream stream_2 = _K2047A8SCJdaw0LZKStEHOiH110._E0f25tLwwg9zgWpaN9mFdnGg2My(string_3);
		SkeletonData skeletonData_ = _VqMsnKIrKxoILv49l85B6Rm0fuQ.smethod_6(skeletonJson_, stream_2, string_3, list_0);
		Skeleton skeleton_ = _VqMsnKIrKxoILv49l85B6Rm0fuQ.smethod_7(skeletonData_);
		_VqMsnKIrKxoILv49l85B6Rm0fuQ.smethod_8(stream_);
		_VqMsnKIrKxoILv49l85B6Rm0fuQ.smethod_8(stream_2);
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
