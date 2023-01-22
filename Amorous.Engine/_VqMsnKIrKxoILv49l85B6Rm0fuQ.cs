using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework.Content;
using Spine;

public static class _VqMsnKIrKxoILv49l85B6Rm0fuQ
{
	public static _nHdiyIURlAiaNZ8u6MKzxjcwnyL _7BVREQXEcBCieHb0qgaVDpUj1ni(this ContentManager contentManager_0, string string_0, float float_0 = 1f, bool bool_0 = true, List<SpineEvent> list_0 = null)
	{
		string string_ = _VqMsnKIrKxoILv49l85B6Rm0fuQ.smethod_1(_VqMsnKIrKxoILv49l85B6Rm0fuQ.smethod_0(contentManager_0), string_0);
		Stream stream_2 = default(Stream);
		string string_2 = default(string);
		Stream stream_ = default(Stream);
		SkeletonData skeletonData_ = default(SkeletonData);
		SkeletonJson skeletonJson_ = default(SkeletonJson);
		Skeleton skeleton_ = default(Skeleton);
		while (true)
		{
			int num = 1411286915;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x63282037u) % 7u)
				{
				case 6u:
					stream_2 = _K2047A8SCJdaw0LZKStEHOiH110._E0f25tLwwg9zgWpaN9mFdnGg2My(string_2);
					num = (int)(num2 * 1276770501) ^ -1708483791;
					continue;
				case 5u:
				{
					string string_3 = _VqMsnKIrKxoILv49l85B6Rm0fuQ.smethod_2(string_, ".json");
					stream_ = _K2047A8SCJdaw0LZKStEHOiH110._E0f25tLwwg9zgWpaN9mFdnGg2My(string_3);
					skeletonData_ = _VqMsnKIrKxoILv49l85B6Rm0fuQ.smethod_6(skeletonJson_, stream_, string_3, list_0);
					num = (int)(num2 * 1938579983) ^ -281124833;
					continue;
				}
				case 4u:
				{
					Atlas val = _VqMsnKIrKxoILv49l85B6Rm0fuQ.smethod_3(stream_2, string_0, (TextureLoader)(object)_AUtA43NfhBNYDqRrVB1t9VQxe1v._yuFBJdi7mxrwMFQ57BjLjSq6ESj);
					SkeletonJson obj = _VqMsnKIrKxoILv49l85B6Rm0fuQ.smethod_4((Atlas[])(object)new Atlas[1] { val });
					_VqMsnKIrKxoILv49l85B6Rm0fuQ.smethod_5(obj, float_0);
					skeletonJson_ = obj;
					num = (int)(num2 * 310242497) ^ -677547312;
					continue;
				}
				case 3u:
					string_2 = _VqMsnKIrKxoILv49l85B6Rm0fuQ.smethod_2(string_, ".atlas.txt");
					num = (int)((num2 * 101400791) ^ 0x66E79C03);
					continue;
				case 1u:
					skeleton_ = _VqMsnKIrKxoILv49l85B6Rm0fuQ.smethod_7(skeletonData_);
					_VqMsnKIrKxoILv49l85B6Rm0fuQ.smethod_8(stream_2);
					num = ((int)num2 * -377328838) ^ -477849563;
					continue;
				case 2u:
					break;
				default:
					_VqMsnKIrKxoILv49l85B6Rm0fuQ.smethod_8(stream_);
					return new _nHdiyIURlAiaNZ8u6MKzxjcwnyL(skeleton_, bool_0);
				}
				break;
			}
		}
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
