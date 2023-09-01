using System;
using Squid;

namespace Amorous.Explorer.GUI.View;

public class CarouselPanel : Control
{
	public bool FitToWidth { get; set; }
	public Frame Content { get; private set; }
	public Frame ClipFrame { get; private set; }
	public ScrollBar Scroll { get; private set; }
	public int MeasuredWidth { get; set; } = 120;

	public CarouselPanel()
	{
		Scroll = new ScrollBar();
		Scroll.Dock = DockStyle.Bottom;
		Scroll.Size = new Point(25, 0);
		Scroll.Orientation = Orientation.Horizontal;
		Elements.Add(Scroll);
		ClipFrame = new Frame();
		ClipFrame.Dock = DockStyle.FillX;
		ClipFrame.Scissor = true;
		Elements.Add(ClipFrame);
		Content = new Frame();
		Content.AutoSize = AutoSize.Horizontal;
		Content.SizeChanged += OnSizeChanged;
		ClipFrame.Controls.Add(Content);
		base.MouseWheel += OnMouseWheel;
	}

	private void OnMouseWheel(Control sender, MouseEventArgs args)
	{
		Scroll.Scroll(Gui.MouseScroll);
		args.Cancel = true;
	}

	private void OnSizeChanged(Control sender)
	{
		if (!FitToWidth || Content.Controls.Count == 0)
		{
			return;
		}
		int targetWidth = MeasuredWidth;
		int width = ClipFrame.Size.x - Content.Padding.Horizontal;
		if (targetWidth * Content.Controls.Count < width)
		{
			targetWidth = width / Content.Controls.Count;
		}
		Content.Controls.ForEach((control) => control.Size = new Point(targetWidth, control.Size.y));
	}

	protected override void OnUpdate()
	{
		base.OnUpdate();
		Point offset = Point.Zero;
		if (Content.Size.x < ClipFrame.Size.x || Content.AutoSize == AutoSize.Vertical)
		{
			Content.Size = new Point(ClipFrame.Size.x, Content.Size.y);
		}
		if (Content.Size.y < ClipFrame.Size.y || Content.AutoSize == AutoSize.Horizontal)
		{
			Content.Size = new Point(Content.Size.x, ClipFrame.Size.y);
		}
		if (Scroll.ShowAlways || Content.Size.x > ClipFrame.Size.x)
		{
			Scroll.Scale = Math.Min(1f, (float)ClipFrame.Size.x / (float)Content.Size.x);
			offset.x = (int)((float)(ClipFrame.Size.x - Content.Size.x) * Scroll.EasedValue);
		}
		Content.Position = offset;
	}
}
