using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Spine;

namespace Amorous.Game.Scenes;

public class CobyTeaseScene : AbstractScene
{
	public const string _49wRM6p4FnMoH7b17tjNG4eYx0 = "Panties";

	public const string _IwkDWPkJa4LinNlSxooUdCPU4oq = "Default";

	private readonly _nHdiyIURlAiaNZ8u6MKzxjcwnyL _7vYi5xfMKLYMkbLDqzCDgoxrzIJ;

	public CobyTeaseScene(IAmorous game)
		: base(Game)
	{
		_7vYi5xfMKLYMkbLDqzCDgoxrzIJ = Game._uwNDZuqdFb9tyQtlQMxiz1DQ7x8._7BVREQXEcBCieHb0qgaVDpUj1ni("Assets/Scenes/CobyTease/Coby buttshake Teasel");
		_6hE3geqxrB1vCirtSWHxIJjlTQB("Panties");
		_7vYi5xfMKLYMkbLDqzCDgoxrzIJ._c4iC7y9v6xg7LpvjKIeUkOdZ3UF(1f);
		_7vYi5xfMKLYMkbLDqzCDgoxrzIJ._C5vPbZ72rpVMDWGuHxZuR5FNpAH("animation");
		_7vYi5xfMKLYMkbLDqzCDgoxrzIJ.X = 985f;
		_7vYi5xfMKLYMkbLDqzCDgoxrzIJ.Y = 1081f;
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/DanMasterFlash - Sun Funk", 0.4f);
	}

	public override void _6hE3geqxrB1vCirtSWHxIJjlTQB(string string_0)
	{
		base._6hE3geqxrB1vCirtSWHxIJjlTQB(string_0);
		if (string_0 == "Panties")
		{
			_7vYi5xfMKLYMkbLDqzCDgoxrzIJ._EasyNtsMRc39NOvWai1JUYTqcds("Panties");
		}
		else
		{
			_7vYi5xfMKLYMkbLDqzCDgoxrzIJ._EasyNtsMRc39NOvWai1JUYTqcds("default");
		}
	}

	public override void Update(GameTime gameTime_0)
	{
		base.Update(gameTime_0);
		_7vYi5xfMKLYMkbLDqzCDgoxrzIJ.Update(gameTime_0, 1500f);
	}

	public override void Draw(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0, Matrix matrix_0)
	{
		base.Draw(spriteBatch_0, skeletonMeshRenderer_0, matrix_0);
		_7vYi5xfMKLYMkbLDqzCDgoxrzIJ.Draw(skeletonMeshRenderer_0);
	}
}
