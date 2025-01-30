using Microsoft.Xna.Framework;
using Squid;

namespace Amorous.Explorer.GUI.View.Inherits;

public class AmorousColorBox : Control, IText
{
	public Color Color
	{
		get => new Color(color.ToVector4());
		set
		{
			if (color == value)
			{
				return;
			}
			color = value;
			Image.Color = ColorInt.ARGB(color.A, color.R, color.G, color.B);
		}
	}
	public string Text
	{
		get => Label.Text;
		set => Label.Text = Picker.Text = value;
	}
	public ImageControl Image { get; set; }
	public Label Label { get; set; }
	public AmorousColorPicker Picker => picker ?? (picker = new AmorousColorPicker());
	public event ApplyColorPicker Apply;

	public AmorousColorBox()
	{
		base.Dock = DockStyle.Top;
		base.Margin = new Margin(5, 10, 0, 0);
		Image = new ImageControl
		{
			Dock = DockStyle.Left,
			Size = new Squid.Point(AmorousData.ButtonHeight, AmorousData.ButtonHeight)
		};
		Image.MouseClick += (control, eventArgs) => ShowColorPicker(eventArgs);
		Label = new Label
		{
			Dock = DockStyle.Fill,
			Margin = new Margin(10, 0, 10, 0)
		};
		Label.MouseClick += (control, eventArgs) => ShowColorPicker(eventArgs);
		Elements.Add(Image);
		Elements.Add(Label);
	}

	private Color color;
	private AmorousColorPicker picker;

	protected virtual void ShowColorPicker(MouseEventArgs eventArgs)
	{
		Picker.Color = color;
		Picker.Apply += delegate(Color color)
		{
			Color = color;
			Apply?.Invoke(Color);
		};
		Picker.Show(Desktop, this);
	}
}
