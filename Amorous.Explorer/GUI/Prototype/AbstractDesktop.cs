using System;
using Amorous.Explorer.Data;
using Microsoft.Xna.Framework;
using Squid;

namespace Amorous.Explorer.GUI.Prototype;

public abstract class AbstractDesktop : Desktop
{
	public IExplorer Explorer { get; private set; }
	public int Width { get => Size.x; set => Size = new Squid.Point(value, Size.y); }
	public int Height { get => Size.y; set => Size = new Squid.Point(Size.x, value); }
	public virtual bool Updatable { get; set; } = true;

	protected AbstractDesktop(IExplorer holder)
	{
		if (holder == null)
		{
			throw new ArgumentNullException("holder");
		}
		Explorer = holder;
		base.Skin = Squids.GenerateSkin();
		base.Size = new Squid.Point(1920, 1080);
		this.SetSkin("Assets/GUI/Squid/DefaultSkin");
	}

	public new virtual void Update(GameTime gameTime)
	{
		base.Update();
	}

	public virtual void Draw(GameTime gameTime)
	{
		if (Visible)
		{
			base.Draw();
		}
	}

	public virtual void Catch(Exception exception)
	{
		this.ShowConfirm($"{exception.Message}", AmorousData.WideDialogueWidth);
	}
}
