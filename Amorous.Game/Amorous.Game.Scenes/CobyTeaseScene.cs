using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Spine;

namespace Amorous.Game.Scenes;

public class CobyTeaseScene : _7UlnfykmEmZDFt3BmCKZekI43Ih
{
	public const string _49wRM6p4FnMoH7b17tjNG4eYx0 = "Panties";

	public const string _IwkDWPkJa4LinNlSxooUdCPU4oq = "Default";

	private readonly _nHdiyIURlAiaNZ8u6MKzxjcwnyL _7vYi5xfMKLYMkbLDqzCDgoxrzIJ;

	public CobyTeaseScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		_7vYi5xfMKLYMkbLDqzCDgoxrzIJ = CobyTeaseScene.smethod_15(CobyTeaseScene.smethod_14(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0), _003CModule_003E.smethod_26<string>(4285733098u), 1f, bool_0: true, (List<SpineEvent>)null);
		CobyTeaseScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, _003CModule_003E.smethod_24<string>(993097303u));
		CobyTeaseScene.smethod_17(_7vYi5xfMKLYMkbLDqzCDgoxrzIJ, 1f);
		CobyTeaseScene.smethod_18(_7vYi5xfMKLYMkbLDqzCDgoxrzIJ, _003CModule_003E.smethod_25<string>(3692662391u), (Action<int>)null);
		CobyTeaseScene.smethod_19(_7vYi5xfMKLYMkbLDqzCDgoxrzIJ, 985f);
		CobyTeaseScene.smethod_20(_7vYi5xfMKLYMkbLDqzCDgoxrzIJ, 1081f);
		CobyTeaseScene.smethod_21(_003CModule_003E.smethod_25<string>(1577301686u), 0.4f);
	}

	public override void _6hE3geqxrB1vCirtSWHxIJjlTQB(string string_0)
	{
		this.method_0(string_0);
		while (true)
		{
			int num = -468792248;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA1D226DAu) % 5u)
				{
				case 4u:
				{
					int num3;
					int num4;
					if (CobyTeaseScene.smethod_22(string_0, _003CModule_003E.smethod_28<string>(3051247055u)))
					{
						num3 = -1985814189;
						num4 = -1985814189;
					}
					else
					{
						num3 = -1333901667;
						num4 = -1333901667;
					}
					num = num3 ^ (int)(num2 * 660490821);
					continue;
				}
				case 1u:
					CobyTeaseScene.smethod_23(_7vYi5xfMKLYMkbLDqzCDgoxrzIJ, _003CModule_003E.smethod_28<string>(2090119818u));
					num = -2016440876;
					continue;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				case 3u:
					CobyTeaseScene.smethod_23(_7vYi5xfMKLYMkbLDqzCDgoxrzIJ, _003CModule_003E.smethod_24<string>(993097303u));
					return;
				}
				break;
			}
		}
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		this.method_1(gameTime_0);
		CobyTeaseScene.smethod_24(_7vYi5xfMKLYMkbLDqzCDgoxrzIJ, gameTime_0, 1500f);
	}

	public override void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0, Matrix matrix_0)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		this.method_2(spriteBatch_0, skeletonMeshRenderer_0, matrix_0);
		while (true)
		{
			int num = -1174724664;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB350C817u) % 3u)
				{
				case 1u:
					goto IL_000b;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_000b:
				CobyTeaseScene.smethod_25(_7vYi5xfMKLYMkbLDqzCDgoxrzIJ, skeletonMeshRenderer_0, (Texture2D)null, (Func<int, string, bool>)null, (Color?)null, 1f);
				num = ((int)num2 * -1387931265) ^ 0x129BC5A0;
			}
		}
	}

	static ContentManager smethod_14(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8;
	}

	static _nHdiyIURlAiaNZ8u6MKzxjcwnyL smethod_15(ContentManager contentManager_0, string string_0, float float_0, bool bool_0, List<SpineEvent> list_0)
	{
		return contentManager_0._7BVREQXEcBCieHb0qgaVDpUj1ni(string_0, float_0, bool_0, list_0);
	}

	static void smethod_16(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0)
	{
		_7UlnfykmEmZDFt3BmCKZekI43Ih_0._6hE3geqxrB1vCirtSWHxIJjlTQB(string_0);
	}

	static void smethod_17(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, float float_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._c4iC7y9v6xg7LpvjKIeUkOdZ3UF(float_0);
	}

	static void smethod_18(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, Action<int> action_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._C5vPbZ72rpVMDWGuHxZuR5FNpAH(string_0, action_0);
	}

	static void smethod_19(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, float float_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_20(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, float float_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}

	static void smethod_21(string string_0, float float_0)
	{
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc(string_0, float_0);
	}

	void method_0(string string_0)
	{
		base._6hE3geqxrB1vCirtSWHxIJjlTQB(string_0);
	}

	static bool smethod_22(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	static void smethod_23(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._EasyNtsMRc39NOvWai1JUYTqcds(string_0);
	}

	void method_1(GameTime gameTime_0)
	{
		base._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
	}

	static void smethod_24(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, GameTime gameTime_0, float float_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0, float_0);
	}

	void method_2(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0, Matrix matrix_0)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		base._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0, skeletonMeshRenderer_0, matrix_0);
	}

	static void smethod_25(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, SkeletonMeshRenderer skeletonMeshRenderer_0, Texture2D texture2D_0, Func<int, string, bool> func_0, Color? nullable_0, float float_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._f5ctqAmdNsZ889UjM4LxDm8WGxA(skeletonMeshRenderer_0, texture2D_0, func_0, nullable_0, float_0);
	}
}
