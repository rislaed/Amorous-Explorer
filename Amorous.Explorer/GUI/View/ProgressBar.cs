using System;
using Squid;

namespace Amorous.Explorer.GUI.View;

public class ProgressBar : Label, IText
{
	public float Progress
	{
		get => progress;
		set
		{
			value = Math.Max(0f, Math.Min(1f, value));
			if (progress == value)
			{
				return;
			}
			progress = value;
			ProgressChanged?.Invoke(this);
			if (format != null)
			{
				UpdateText();
			}
		}
	}
	public new string Text
	{
		get => text;
		set
		{
			if (text == value)
			{
				return;
			}
			text = value;
			UpdateText();
		}
	}
	public string Format
	{
		get => format;
		set
		{
			if (format == value)
			{
				return;
			}
			format = value;
			UpdateText();
		}
	}
	public ControlState StateOfOverlay { get; set; } = ControlState.Checked;
	public Orientation Orientation { get; set; }

	string IText.Text { get => Text; set => Text = value; }
	protected string InternalText { get => base.Text; set => base.Text = value; }

	public event VoidEvent ProgressChanged;

	public ProgressBar()
	{
		base.Style = "buttonOpaqueSelected";
		base.Dock = DockStyle.Top;
		base.Size = new Point(100, 30);
		base.TextAlign = Alignment.MiddleCenter;
		base.NoEvents = true;
		UpdateText();
	}

	private string text, format = "0.0";
	private float progress;

	protected virtual void UpdateText()
	{
		if (format == null)
		{
			base.Text = text;
			return;
		}
		string stroke = $"{(progress * 100f).ToString(format)}%";
		base.Text = string.IsNullOrEmpty(text) ? stroke : $"{text} ({stroke})";
	}

	protected override void OnStateChanged()
	{
		base.OnStateChanged();
		if (NoEvents || Desktop == null)
		{
			return;
		}
		if (!Enabled)
		{
			StateOfOverlay = ControlState.CheckedDisabled;
		}
		else if (Desktop.FocusedControl == this)
		{
			StateOfOverlay = ControlState.CheckedFocused;
		}
		else if (Desktop.PressedControl == this)
		{
			StateOfOverlay = ControlState.CheckedPressed;
		}
		else if (Desktop.HotControl == this)
		{
			StateOfOverlay = ControlState.CheckedHot;
		}
		else
		{
			StateOfOverlay = ControlState.Checked;
		}
	}

	protected override void DrawStyle(Style style, float opacity)
	{
		int x1 = 0, x2 = 0, y1 = 0, y2 = 0, width1, width2, height1, height2;
		if (Orientation == Orientation.Horizontal)
		{
			int width = (int)(Progress * (float)Size.x);
			if (Dock != DockStyle.Right)
			{
				width1 = x2 = width;
				width2 = Size.x - width;
			}
			else
			{
				width2 = x1 = Size.x - width;
				width1 = width;
			}
			height1 = height2 = Size.y;
		}
		else
		{
			int height = (int)(Progress * (float)Size.y);
			if (Dock == DockStyle.Bottom)
			{
				height1 = y2 = height;
				height2 = Size.y - height;
			}
			else
			{
				height2 = y1 = Size.y - height;
				height1 = height;
			}
			width1 = width2 = Size.x;
		}
		if (opacity > 0f)
		{
			DrawSectionWithFallback(style, opacity, Location.x + x2, Location.y + y2, width2, height2);
		}
		style = Desktop.GetStyle(Style).Styles[StateOfOverlay];
		opacity = GetOpacity(style.Opacity);
		if (opacity > 0f)
		{
			DrawSectionWithFallback(style, opacity, Location.x + x1, Location.y + y1, width1, height1);
		}
	}

	protected virtual void DrawSectionWithFallback(Style style, float opacity, int x, int y, int width, int height)
	{
		int color = style.BackColor;
		if (Tint != -1)
		{
			color = ColorInt.Blend(Tint, color);
		}
		color = ColorInt.FromArgb(opacity, color);
		if (color != 0)
		{
			Gui.Renderer.DrawBox(x, y, width, height, color);
		}
		color = style.Tint;
		if (Tint != -1)
		{
			color = ColorInt.Blend(Tint, color);
		}
		color = ColorInt.FromArgb(opacity, color);
		if (color == 0)
		{
			return;
		}
		int texture = !string.IsNullOrEmpty(style.Texture) ? Gui.Renderer.GetTexture(style.Texture) : -1;
		if (texture > -1)
		{
			DrawTexture(style, texture, color, opacity, x, y, width, height);
		}
		else
		{
			Gui.Renderer.DrawBox(x, y, width, height, color);
		}
	}

	protected virtual void DrawTexture(Style style, int texture, int color, float opacity, int x, int y, int width, int height)
	{
		if (style.TextureRect.IsEmpty())
		{
			Point textureSize = Gui.Renderer.GetTextureSize(texture);
			style.TextureRect = new Rectangle(Point.Zero, textureSize);
		}
		if (style.Tiling == TextureMode.Grid)
		{
			SliceTexture(texture, new Point(x, y), new Point(width, height), style.TextureRect, style.Grid, opacity, color);
		}
		else if (style.Tiling == TextureMode.GridRepeat)
		{
			SliceTexture(texture, style.Tiling, style.TextureRect, style.Grid, opacity, color);
		}
		else if (style.Tiling == TextureMode.Stretch)
		{
			Gui.Renderer.DrawTexture(texture, x, y, width, height, style.TextureRect, color);
		}
		else if (style.Tiling == TextureMode.Center)
		{
			Point center = new Point(x + (width / 2), y + (height / 2));
			Point size = new Point(style.TextureRect.Width, style.TextureRect.Height);
			Point location = center - size / 2;
			Gui.Renderer.DrawTexture(texture, location.x, location.y, size.x, size.y, style.TextureRect, color);
		}
		else
		{
			RepeatTexture(texture, new Point(x, y), style.TextureRect, style.Tiling, opacity, color);
		}
	}

	protected void SliceTexture(int texture, Point location, Point size, Rectangle rect, Margin grid, float opacity, int color)
	{
		Rectangle rectangle = new Rectangle(location, size);
		Margin offset = new Margin(Location.x <= location.x ? Math.Min(grid.Left, size.x) : 0, Location.y <= location.y ? Math.Min(grid.Top, size.y) : 0, 0, 0);
		offset.Right = Location.x + Size.x >= rectangle.Right ? Math.Min(grid.Right, size.x - offset.Left) : 0;
		offset.Bottom = Location.y + Size.y >= rectangle.Bottom ? Math.Min(grid.Bottom, size.y - offset.Top) : 0;
		Rectangle offsetRectangle = new Rectangle(location + new Point(offset.Left, offset.Top), size - new Point(offset.Left + offset.Right, offset.Top + offset.Bottom));
		Rectangle sourceRectangle = default(Rectangle);
		int left = rect.Left + grid.Left;
		int top = rect.Top + grid.Top;
		int right = rect.Right - grid.Right;
		int bottom = rect.Bottom - grid.Bottom;
		if (offset.Top > 0 && offset.Left > 0)
		{
			sourceRectangle.Left = rect.Left;
			sourceRectangle.Top = rect.Top;
			sourceRectangle.Right = left;
			sourceRectangle.Bottom = top;
			Gui.Renderer.DrawTexture(texture, rectangle.Left, rectangle.Top, offset.Left, offset.Top, sourceRectangle, color);
		}
		if (offset.Top > 0 && offset.Right > 0)
		{
			sourceRectangle.Left = right;
			sourceRectangle.Top = rect.Top;
			sourceRectangle.Right = rect.Right;
			sourceRectangle.Bottom = top;
			Gui.Renderer.DrawTexture(texture, offsetRectangle.Right, rectangle.Top, offset.Right, offset.Top, sourceRectangle, color);
		}
		if (offset.Bottom > 0 && offset.Left > 0)
		{
			sourceRectangle.Left = rect.Left;
			sourceRectangle.Top = bottom;
			sourceRectangle.Right = left;
			sourceRectangle.Bottom = rect.Bottom;
			Gui.Renderer.DrawTexture(texture, rectangle.Left, offsetRectangle.Bottom, offset.Left, offset.Bottom, sourceRectangle, color);
		}
		if (offset.Bottom > 0 && offset.Right > 0)
		{
			sourceRectangle.Left = right;
			sourceRectangle.Top = bottom;
			sourceRectangle.Right = rect.Right;
			sourceRectangle.Bottom = rect.Bottom;
			Gui.Renderer.DrawTexture(texture, offsetRectangle.Right, offsetRectangle.Bottom, offset.Right, offset.Bottom, sourceRectangle, color);
		}
		if (offset.Left > 0)
		{
			sourceRectangle.Left = rect.Left;
			sourceRectangle.Top = top;
			sourceRectangle.Right = left;
			sourceRectangle.Bottom = bottom;
			Gui.Renderer.DrawTexture(texture, rectangle.Left, offsetRectangle.Top, offset.Left, offsetRectangle.Height, sourceRectangle, color);
		}
		if (offset.Top > 0)
		{
			sourceRectangle.Left = left;
			sourceRectangle.Top = rect.Top;
			sourceRectangle.Right = right;
			sourceRectangle.Bottom = top;
			Gui.Renderer.DrawTexture(texture, offsetRectangle.Left, rectangle.Top, offsetRectangle.Width, offset.Top, sourceRectangle, color);
		}
		if (offset.Right > 0)
		{
			sourceRectangle.Left = right;
			sourceRectangle.Top = top;
			sourceRectangle.Right = rect.Right;
			sourceRectangle.Bottom = bottom;
			Gui.Renderer.DrawTexture(texture, offsetRectangle.Right, offsetRectangle.Top, offset.Right, offsetRectangle.Height, sourceRectangle, color);
		}
		if (offset.Bottom > 0)
		{
			sourceRectangle.Left = left;
			sourceRectangle.Top = bottom;
			sourceRectangle.Right = right;
			sourceRectangle.Bottom = rect.Bottom;
			Gui.Renderer.DrawTexture(texture, offsetRectangle.Left, offsetRectangle.Bottom, offsetRectangle.Width, offset.Bottom, sourceRectangle, color);
		}
		sourceRectangle.Left = left;
		sourceRectangle.Top = top;
		sourceRectangle.Right = right;
		sourceRectangle.Bottom = bottom;
		Gui.Renderer.DrawTexture(texture, offsetRectangle.Left, offsetRectangle.Top, offsetRectangle.Width, offsetRectangle.Height, sourceRectangle, color);
	}
}
