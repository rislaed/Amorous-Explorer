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

	private readonly SpineRenderer _7vYi5xfMKLYMkbLDqzCDgoxrzIJ;

	public CobyTeaseScene(IAmorous game)
		: base(game)
	{
		_7vYi5xfMKLYMkbLDqzCDgoxrzIJ = Game.Content._7BVREQXEcBCieHb0qgaVDpUj1ni("Assets/Scenes/CobyTease/Coby buttshake Teasel");
		SetVariant("Panties");
		_7vYi5xfMKLYMkbLDqzCDgoxrzIJ.SetVisibility(1f);
		_7vYi5xfMKLYMkbLDqzCDgoxrzIJ.StartAnimationWithLooping("animation");
		_7vYi5xfMKLYMkbLDqzCDgoxrzIJ.X = 985f;
		_7vYi5xfMKLYMkbLDqzCDgoxrzIJ.Y = 1081f;
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/DanMasterFlash - Sun Funk", 0.4f);
	}

	public override void SetVariant(string string_0)
	{
		base.SetVariant(string_0);
		if (string_0 == "Panties")
		{
			_7vYi5xfMKLYMkbLDqzCDgoxrzIJ.SetSkin("Panties");
		}
		else
		{
			_7vYi5xfMKLYMkbLDqzCDgoxrzIJ.SetSkin("default");
		}
	}

	public override void Update(GameTime gameTime)
	{
		base.Update(gameTime);
		_7vYi5xfMKLYMkbLDqzCDgoxrzIJ.Update(gameTime, 1500f);
	}

	public override void Draw(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer, Matrix matrix_0)
	{
		base.Draw(spriteBatch, skeletonMeshRenderer, matrix_0);
		_7vYi5xfMKLYMkbLDqzCDgoxrzIJ.Draw(skeletonMeshRenderer);
	}
}
