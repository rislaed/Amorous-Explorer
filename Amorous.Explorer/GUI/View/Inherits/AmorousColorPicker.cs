using System;
using System.Reflection;
using Amorous.Game.Scenes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Squid;

namespace Amorous.Explorer.GUI.View.Inherits;

public delegate void ApplyColorPicker(Color color);

public class AmorousColorPicker : Window, IText
{
	public Label Label { get; set; }
	public ImageControl PickerBox { get; set; }
	public ImageControl PickerSlider { get; set; }
	public ImageControl ColorBox { get; set; }
	public TextBox HueBox { get; set; }
	public TextBox RedBox { get; set; }
	public TextBox SaturationBox { get; set; }
	public TextBox GreenBox { get; set; }
	public TextBox ValueBox { get; set; }
	public TextBox BlueBox { get; set; }
	public TextBox HexBox { get; set; }
	public ImageControl CursorBox { get; set; }
	public ImageControl CursorBoxPointer { get; set; }
	public event ApplyColorPicker Apply;
	public static AmorousColorPicker Singleton { get; protected set; }

	protected Control ControlOfSource { get; set; }
	protected float HueComponent, SaturationComponent, ValueComponent;

	public string Text
	{
		get => Label.Text;
		set => Label.Text = value;
	}
	public Color Color
	{
		get => new Color(color, color.A);
		set
		{
			if (color == value)
			{
				return;
			}
			color = value;
			Commit();
		}
	}

	public AmorousColorPicker()
	{
		base.Dock = DockStyle.Right;
		base.AutoSize = AutoSize.HorizontalVertical;
		base.Margin = new Margin(8, 8, 0, 8);
		base.Visible = false;
		Panel panel = new Panel();
		panel.Size = new Squid.Point(307, 519);
		panel.ClipFrame.Margin = new Margin(16, 8, 16, 16);
		Controls.Add(panel);
		Label = new Label
		{
			Dock = DockStyle.Top,
			TextAlign = Alignment.MiddleCenter
		};
		Panel pickerContainer = new Panel
		{
			Dock = DockStyle.Top,
			Size = new Squid.Point(275, 250)
		};
		PickerBox = new ImageControl
		{
			Dock = DockStyle.Left,
			Texture = "ExplorerColorPickerBox",
			Size = new Squid.Point(250, 250)
		};
		PickerSlider = new ImageControl
		{
			Dock = DockStyle.Fill,
			Texture = "ExplorerColorPickerSlider",
			Size = new Squid.Point(25, 250)
		};
		pickerContainer.Content.Controls.Add(PickerBox);
		pickerContainer.Content.Controls.Add(PickerSlider);
		ColorBox = new ImageControl
		{
			Dock = DockStyle.Top,
			Size = new Squid.Point(275, 25),
			Color = ColorInt.ARGB(color.A, color.R, color.G, color.B),
			Margin = new Margin(0, 0, 0, 8)
		};
		Panel boxesContainer1 = new Panel
		{
			Dock = DockStyle.Top,
			Size = new Squid.Point(275, AmorousData.ButtonHeight),
			Margin = new Margin(0, 0, 0, 8)
		};
		Label hueLabel = new Label
		{
			Dock = DockStyle.Left,
			Text = "H:",
			TextAlign = Alignment.MiddleCenter,
			Size = new Squid.Point(AmorousData.ButtonHeight, AmorousData.ButtonHeight)
		};
		HueBox = new TextBox
		{
			Dock = DockStyle.Left,
			Size = new Squid.Point(107, AmorousData.ButtonHeight),
			TabIndex = 1
		};
		Label redLabel = new Label
		{
			Dock = DockStyle.Left,
			Text = "R:",
			TextAlign = Alignment.MiddleCenter,
			Size = new Squid.Point(AmorousData.ButtonHeight, AmorousData.ButtonHeight)
		};
		RedBox = new TextBox
		{
			Dock = DockStyle.Fill,
			TabIndex = 4
		};
		boxesContainer1.Content.Controls.Add(hueLabel);
		boxesContainer1.Content.Controls.Add(HueBox);
		boxesContainer1.Content.Controls.Add(redLabel);
		boxesContainer1.Content.Controls.Add(RedBox);
		Panel boxesContainer2 = new Panel
		{
			Dock = DockStyle.Top,
			Size = new Squid.Point(275, AmorousData.ButtonHeight),
			Margin = new Margin(0, 0, 0, 8)
		};
		Label saturationLabel = new Label
		{
			Dock = DockStyle.Left,
			Text = "S:",
			TextAlign = Alignment.MiddleCenter,
			Size = new Squid.Point(AmorousData.ButtonHeight, AmorousData.ButtonHeight)
		};
		SaturationBox = new TextBox
		{
			Dock = DockStyle.Left,
			Size = new Squid.Point(107, AmorousData.ButtonHeight),
			TabIndex = 2
		};
		Label greenLabel = new Label
		{
			Dock = DockStyle.Left,
			Text = "G:",
			TextAlign = Alignment.MiddleCenter,
			Size = new Squid.Point(AmorousData.ButtonHeight, AmorousData.ButtonHeight)
		};
		GreenBox = new TextBox
		{
			Dock = DockStyle.Fill,
			TabIndex = 5
		};
		boxesContainer2.Content.Controls.Add(saturationLabel);
		boxesContainer2.Content.Controls.Add(SaturationBox);
		boxesContainer2.Content.Controls.Add(greenLabel);
		boxesContainer2.Content.Controls.Add(GreenBox);
		Panel boxesContainer3 = new Panel
		{
			Dock = DockStyle.Top,
			Size = new Squid.Point(275, AmorousData.ButtonHeight),
			Margin = new Margin(0, 0, 0, 8)
		};
		Label valueLabel = new Label
		{
			Dock = DockStyle.Left,
			Text = "V:",
			TextAlign = Alignment.MiddleCenter,
			Size = new Squid.Point(AmorousData.ButtonHeight, AmorousData.ButtonHeight)
		};
		ValueBox = new TextBox
		{
			Dock = DockStyle.Left,
			Size = new Squid.Point(107, AmorousData.ButtonHeight),
			TabIndex = 3
		};
		Label blueLabel = new Label
		{
			Dock = DockStyle.Left,
			Text = "B:",
			TextAlign = Alignment.MiddleCenter,
			Size = new Squid.Point(AmorousData.ButtonHeight, AmorousData.ButtonHeight)
		};
		BlueBox = new TextBox
		{
			Dock = DockStyle.Fill,
			TabIndex = 6
		};
		boxesContainer3.Content.Controls.Add(valueLabel);
		boxesContainer3.Content.Controls.Add(ValueBox);
		boxesContainer3.Content.Controls.Add(blueLabel);
		boxesContainer3.Content.Controls.Add(BlueBox);
		Panel hexContainer = new Panel
		{
			Dock = DockStyle.Top,
			Size = new Squid.Point(275, AmorousData.ButtonHeight),
			Margin = new Margin(0, 0, 0, 8)
		};
		Label hexLabel = new Label
		{
			Dock = DockStyle.Left,
			Text = "Hex:",
			TextAlign = Alignment.MiddleCenter,
			Size = new Squid.Point(45, AmorousData.ButtonHeight)
		};
		HexBox = new TextBox
		{
			Dock = DockStyle.Fill,
			TabIndex = 7
		};
		hexContainer.Content.Controls.Add(hexLabel);
		hexContainer.Content.Controls.Add(HexBox);
		CursorBox = new ImageControl
		{
			Size = new Squid.Point(6, 6),
			Color = ColorInt.ARGB(0.9f, 1f, 1f, 1f)
		};
		CursorBoxPointer = new ImageControl
		{
			Size = new Squid.Point(25, 6),
			Color = ColorInt.ARGB(0.9f, 1f, 1f, 1f)
		};
		Controls.Add(CursorBox);
		Controls.Add(CursorBoxPointer);
		Button closeButton = new Button
		{
			Dock = DockStyle.Fill,
			Text = "Close",
			TextAlign = Alignment.MiddleCenter
		};
		closeButton.MouseClick += delegate
		{
			Close();
		};
		panel.Content.Controls.Add(Label);
		panel.Content.Controls.Add(pickerContainer);
		panel.Content.Controls.Add(ColorBox);
		panel.Content.Controls.Add(boxesContainer1);
		panel.Content.Controls.Add(boxesContainer2);
		panel.Content.Controls.Add(boxesContainer3);
		panel.Content.Controls.Add(hexContainer);
		panel.Content.Controls.Add(hexContainer);
		panel.Content.Controls.Add(closeButton);
	}

	private Color color;

	public override void Show(Desktop target)
	{
		if (Singleton != null)
		{
			Singleton.Close();
		}
		base.Show(target);
		PlayerCustomizationScene.RGBToHSV(color, out HueComponent, out SaturationComponent, out ValueComponent);
		Texture2D colorPickerBackground = new Texture2D(AmorousExplorer.Singleton.Amorous.Graphics, 250, 250, mipMap: false, SurfaceFormat.Color);
		int[] colorBackgroundGradient = new int[colorPickerBackground.Width * colorPickerBackground.Height];
		for (int i = 0; i < colorPickerBackground.Height; i++)
		{
			for (int j = 0; j < colorPickerBackground.Width; j++)
			{
				Color packedColor = HSVToColor(HueComponent, (float)j / (float)colorPickerBackground.Width, ((float)colorPickerBackground.Height - (float)i) / (float)colorPickerBackground.Height, 1f);
				colorBackgroundGradient[i * colorPickerBackground.Width + j] = (int)packedColor.PackedValue;
			}
		}
		colorPickerBackground.SetData(colorBackgroundGradient);
		Texture2D colorPickerSlider = new Texture2D(AmorousExplorer.Singleton.Amorous.Graphics, 25, 250, mipMap: false, SurfaceFormat.Color);
		int[] colorSliderGradient = new int[colorPickerSlider.Width * colorPickerSlider.Height];
		for (int k = 0; k < colorPickerSlider.Height; k++)
		{
			Color packedColor = HSVToColor(((float)colorPickerSlider.Height - (float)k) / (float)colorPickerSlider.Height * 360f, 1.0, 1.0, 1f);
			for (int l = 0; l < colorPickerSlider.Width; l++)
			{
				colorSliderGradient[k * colorPickerSlider.Width + l] = (int)packedColor.PackedValue;
			}
		}
		colorPickerSlider.SetData(colorSliderGradient);
		Gui.Renderer.SetTexture("ExplorerColorPickerBox", colorPickerBackground);
		Gui.Renderer.SetTexture("ExplorerColorPickerSlider", colorPickerSlider);
		Commit();
		bool isGliding = false;
		bool isSliding = false;
		PickerBox.Update += delegate
		{
			if (!isSliding)
			{
				if (AmorousExplorer.Singleton.Amorous.Controller.IsHolding(ControllerButtonType.LeftButton))
				{
					if (!isGliding && Gui.MousePosition.x >= PickerBox.Location.x && Gui.MousePosition.x <= PickerBox.Location.x + PickerBox.Size.x && Gui.MousePosition.y >= PickerBox.Location.y && Gui.MousePosition.y <= PickerBox.Location.y + PickerBox.Size.y)
					{
						isGliding = true;
					}
					if (isGliding)
					{
						Squid.Point offset = Gui.MousePosition - PickerBox.Location;
						offset.x = (int)MathHelper.Clamp(offset.x, 0f, 250f);
						offset.y = (int)MathHelper.Clamp(offset.y, 0f, 250f);
						SaturationComponent = (float)offset.x / 250f;
						ValueComponent = (250f - (float)offset.y) / 250f;
						color = HSVToColor(HueComponent, SaturationComponent, ValueComponent, 1f);
						Commit();
						Apply?.Invoke(color);
					}
				}
				else
				{
					isGliding = false;
				}
			}
		};
		PickerSlider.Update += delegate
		{
			if (!isGliding)
			{
				if (AmorousExplorer.Singleton.Amorous.Controller.IsHolding(ControllerButtonType.LeftButton))
				{
					if (!isSliding && Gui.MousePosition.x >= PickerSlider.Location.x && Gui.MousePosition.x <= PickerSlider.Location.x + PickerSlider.Size.x && Gui.MousePosition.y >= PickerSlider.Location.y && Gui.MousePosition.y <= PickerSlider.Location.y + PickerSlider.Size.y)
					{
						isSliding = true;
					}
					if (isSliding)
					{
						Squid.Point offset = Gui.MousePosition - PickerSlider.Location;
						offset.y = (int)MathHelper.Clamp(offset.y, 0f, 250f);
						HueComponent = 360f - (float)offset.y / 250f * 360f;
						for (int m = 0; m < colorPickerBackground.Height; m++)
						{
							for (int n = 0; n < colorPickerBackground.Width; n++)
							{
								Color packedColor = HSVToColor(HueComponent, (float)n / (float)colorPickerBackground.Width, ((float)colorPickerBackground.Height - (float)m) / (float)colorPickerBackground.Height, 1f);
								colorBackgroundGradient[m * colorPickerBackground.Width + n] = (int)packedColor.PackedValue;
							}
						}
						colorPickerBackground.SetData(colorBackgroundGradient);
						color = HSVToColor(HueComponent, SaturationComponent, ValueComponent, 1f);
						Commit();
						Apply?.Invoke(color);
					}
				}
				else
				{
					isSliding = false;
				}
			}
		};
		HueBox.TextCommit += delegate
		{
			if (int.TryParse(HueBox.Text, out var hue))
			{
				HueComponent = Math.Max(0, Math.Min(hue, 360));
				color = HSVToColor(HueComponent, SaturationComponent, ValueComponent, 1f);
				Apply?.Invoke(color);
			}
			Commit();
		};
		SaturationBox.TextCommit += delegate
		{
			if (int.TryParse(SaturationBox.Text, out var saturation))
			{
				SaturationComponent = (float)Math.Max(0, Math.Min(saturation, 100)) / 100f;
				color = HSVToColor(HueComponent, SaturationComponent, ValueComponent, 1f);
				Apply?.Invoke(color);
			}
			Commit();
		};
		ValueBox.TextCommit += delegate
		{
			if (int.TryParse(ValueBox.Text, out var value))
			{
				ValueComponent = (float)Math.Max(0, Math.Min(value, 100)) / 100f;
				color = HSVToColor(HueComponent, SaturationComponent, ValueComponent, 1f);
				Apply?.Invoke(color);
			}
			Commit();
		};
		RedBox.TextCommit += delegate
		{
			if (int.TryParse(RedBox.Text, out var red))
			{
				color.R = (byte)Math.Max(0, Math.Min(red, 255));
				PlayerCustomizationScene.RGBToHSV(color, out HueComponent, out SaturationComponent, out ValueComponent);
				Apply?.Invoke(color);
			}
			Commit();
		};
		GreenBox.TextCommit += delegate
		{
			if (int.TryParse(GreenBox.Text, out var green))
			{
				color.G = (byte)Math.Max(0, Math.Min(green, 255));
				PlayerCustomizationScene.RGBToHSV(color, out HueComponent, out SaturationComponent, out ValueComponent);
				Apply?.Invoke(color);
			}
			Commit();
		};
		BlueBox.TextCommit += delegate
		{
			if (int.TryParse(BlueBox.Text, out var blue))
			{
				color.B = (byte)Math.Max(0, Math.Min(blue, 255));
				PlayerCustomizationScene.RGBToHSV(color, out HueComponent, out SaturationComponent, out ValueComponent);
				Apply?.Invoke(color);
			}
			Commit();
		};
		HexBox.TextCommit += delegate
		{
			if (HexBox.Text.StartsWith("#") && HexBox.Text.Length <= 7)
			{
				try
				{
					int packedColor = Convert.ToInt32(HexBox.Text.Substring(1), 16);
					color.B = (byte)((uint)packedColor & 0xFFu);
					color.G = (byte)((uint)(packedColor >> 8) & 0xFFu);
					color.R = (byte)((uint)(packedColor >> 16) & 0xFFu);
					PlayerCustomizationScene.RGBToHSV(color, out HueComponent, out SaturationComponent, out ValueComponent);
					Apply?.Invoke(color);
				}
				catch
				{
				}
			}
			Commit();
		};
		Singleton = this;
	}

	public void Show(Desktop target, Control control)
	{
		ControlOfSource = control;
		Show(target);
	}

	public override void Close()
	{
		if (Singleton == this)
		{
			Singleton = null;
		}
		base.Close();
	}

	protected override void OnUpdate()
	{
		base.OnUpdate();
		if (!Visible)
		{
			return;
		}
		if (ControlOfSource != null && (ControlOfSource.Desktop == null || !ControlOfSource.Visible))
		{
			Close();
			return;
		}
		if (AmorousExplorer.Singleton.Amorous.Controller.IsPressed(Microsoft.Xna.Framework.Input.Keys.Escape))
		{
			Close();
		}
	}

	protected virtual void Commit()
	{
		CursorBox.Position = new Squid.Point(13 + (int)(SaturationComponent * 250f), 35 + (int)(250f - ValueComponent * 250f));
		CursorBoxPointer.Position = new Squid.Point(266, 35 + (int)(250f - 250f * (HueComponent / 360f)));
		ColorBox.Color = ColorInt.ARGB(color.A, color.R, color.G, color.B);
		HueBox.Text = ((int)HueComponent).ToString();
		SaturationBox.Text = ((int)(SaturationComponent * 100f)).ToString();
		ValueBox.Text = ((int)(ValueComponent * 100f)).ToString();
		RedBox.Text = color.R.ToString();
		GreenBox.Text = color.G.ToString();
		BlueBox.Text = color.B.ToString();
		HexBox.Text = $"#{color.R:X2}{color.G:X2}{color.B:X2}";
	}

	public static Color HSVToColor(double h, double s, double v, float a) => (Color)typeof(PlayerCustomizationScene).GetMethod("HSVToColor", BindingFlags.Static | BindingFlags.NonPublic).Invoke(null, new object[] { h, s, v, a });
}
