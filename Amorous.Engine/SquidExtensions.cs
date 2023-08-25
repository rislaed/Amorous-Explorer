using System;
using System.Collections.Generic;
using Squid;

public static class SquidExtensions
{ // _o0Y4SOgMHY7iQXRQkPwaQ9pMBBl
	public static readonly Dictionary<Microsoft.Xna.Framework.Input.Keys, Squid.Keys?> Keys = new Dictionary<Microsoft.Xna.Framework.Input.Keys,Squid.Keys?>
	{
		{
			Microsoft.Xna.Framework.Input.Keys.None,
			null
		},
		{
			Microsoft.Xna.Framework.Input.Keys.Back,
			Squid.Keys.BACKSPACE
		},
		{
			Microsoft.Xna.Framework.Input.Keys.Tab,
			Squid.Keys.TAB
		},
		{
			Microsoft.Xna.Framework.Input.Keys.Enter,
			Squid.Keys.RETURN
		},
		{
			Microsoft.Xna.Framework.Input.Keys.Pause,
			Squid.Keys.PAUSE
		},
		{
			Microsoft.Xna.Framework.Input.Keys.CapsLock,
			Squid.Keys.CAPITAL
		},
		{
			Microsoft.Xna.Framework.Input.Keys.Kana,
			Squid.Keys.KANA
		},
		{
			Microsoft.Xna.Framework.Input.Keys.Kanji,
			Squid.Keys.KANJI
		},
		{
			Microsoft.Xna.Framework.Input.Keys.Escape,
			Squid.Keys.ESCAPE
		},
		{
			Microsoft.Xna.Framework.Input.Keys.ImeConvert,
			null
		},
		{
			Microsoft.Xna.Framework.Input.Keys.ImeNoConvert,
			null
		},
		{
			Microsoft.Xna.Framework.Input.Keys.Space,
			Squid.Keys.SPACE
		},
		{
			Microsoft.Xna.Framework.Input.Keys.PageUp,
			Squid.Keys.PAGEUP
		},
		{
			Microsoft.Xna.Framework.Input.Keys.PageDown,
			Squid.Keys.PAGEDOWN
		},
		{
			Microsoft.Xna.Framework.Input.Keys.End,
			Squid.Keys.END
		},
		{
			Microsoft.Xna.Framework.Input.Keys.Home,
			Squid.Keys.HOME
		},
		{
			Microsoft.Xna.Framework.Input.Keys.Left,
			Squid.Keys.LEFTARROW
		},
		{
			Microsoft.Xna.Framework.Input.Keys.Up,
			Squid.Keys.UP
		},
		{
			Microsoft.Xna.Framework.Input.Keys.Right,
			Squid.Keys.RIGHT
		},
		{
			Microsoft.Xna.Framework.Input.Keys.Down,
			Squid.Keys.DOWN
		},
		{
			Microsoft.Xna.Framework.Input.Keys.Select,
			null
		},
		{
			Microsoft.Xna.Framework.Input.Keys.Print,
			null
		},
		{
			Microsoft.Xna.Framework.Input.Keys.Execute,
			null
		},
		{
			Microsoft.Xna.Framework.Input.Keys.PrintScreen,
			null
		},
		{
			Microsoft.Xna.Framework.Input.Keys.Insert,
			Squid.Keys.INSERT
		},
		{
			Microsoft.Xna.Framework.Input.Keys.Delete,
			Squid.Keys.DELETE
		},
		{
			Microsoft.Xna.Framework.Input.Keys.Help,
			null
		},
		{
			Microsoft.Xna.Framework.Input.Keys.D0,
			Squid.Keys.D0
		},
		{
			Microsoft.Xna.Framework.Input.Keys.D1,
			Squid.Keys.D1
		},
		{
			Microsoft.Xna.Framework.Input.Keys.D2,
			Squid.Keys.D2
		},
		{
			Microsoft.Xna.Framework.Input.Keys.D3,
			Squid.Keys.D3
		},
		{
			Microsoft.Xna.Framework.Input.Keys.D4,
			Squid.Keys.D4
		},
		{
			Microsoft.Xna.Framework.Input.Keys.D5,
			Squid.Keys.D5
		},
		{
			Microsoft.Xna.Framework.Input.Keys.D6,
			Squid.Keys.D6
		},
		{
			Microsoft.Xna.Framework.Input.Keys.D7,
			Squid.Keys.D7
		},
		{
			Microsoft.Xna.Framework.Input.Keys.D8,
			Squid.Keys.D8
		},
		{
			Microsoft.Xna.Framework.Input.Keys.D9,
			Squid.Keys.D9
		},
		{
			Microsoft.Xna.Framework.Input.Keys.A,
			Squid.Keys.A
		},
		{
			Microsoft.Xna.Framework.Input.Keys.B,
			Squid.Keys.B
		},
		{
			Microsoft.Xna.Framework.Input.Keys.C,
			Squid.Keys.C
		},
		{
			Microsoft.Xna.Framework.Input.Keys.D,
			Squid.Keys.D
		},
		{
			Microsoft.Xna.Framework.Input.Keys.E,
			Squid.Keys.E
		},
		{
			Microsoft.Xna.Framework.Input.Keys.F,
			Squid.Keys.F
		},
		{
			Microsoft.Xna.Framework.Input.Keys.G,
			Squid.Keys.G
		},
		{
			Microsoft.Xna.Framework.Input.Keys.H,
			Squid.Keys.H
		},
		{
			Microsoft.Xna.Framework.Input.Keys.I,
			Squid.Keys.I
		},
		{
			Microsoft.Xna.Framework.Input.Keys.J,
			Squid.Keys.J
		},
		{
			Microsoft.Xna.Framework.Input.Keys.K,
			Squid.Keys.K
		},
		{
			Microsoft.Xna.Framework.Input.Keys.L,
			Squid.Keys.L
		},
		{
			Microsoft.Xna.Framework.Input.Keys.M,
			Squid.Keys.M
		},
		{
			Microsoft.Xna.Framework.Input.Keys.N,
			Squid.Keys.N
		},
		{
			Microsoft.Xna.Framework.Input.Keys.O,
			Squid.Keys.O
		},
		{
			Microsoft.Xna.Framework.Input.Keys.P,
			Squid.Keys.P
		},
		{
			Microsoft.Xna.Framework.Input.Keys.Q,
			Squid.Keys.Q
		},
		{
			Microsoft.Xna.Framework.Input.Keys.R,
			Squid.Keys.R
		},
		{
			Microsoft.Xna.Framework.Input.Keys.S,
			Squid.Keys.S
		},
		{
			Microsoft.Xna.Framework.Input.Keys.T,
			Squid.Keys.T
		},
		{
			Microsoft.Xna.Framework.Input.Keys.U,
			Squid.Keys.U
		},
		{
			Microsoft.Xna.Framework.Input.Keys.V,
			Squid.Keys.V
		},
		{
			Microsoft.Xna.Framework.Input.Keys.W,
			Squid.Keys.W
		},
		{
			Microsoft.Xna.Framework.Input.Keys.X,
			Squid.Keys.X
		},
		{
			Microsoft.Xna.Framework.Input.Keys.Y,
			Squid.Keys.Y
		},
		{
			Microsoft.Xna.Framework.Input.Keys.Z,
			Squid.Keys.Z
		},
		{
			Microsoft.Xna.Framework.Input.Keys.LeftWindows,
			Squid.Keys.LEFTWINDOWS
		},
		{
			Microsoft.Xna.Framework.Input.Keys.RightWindows,
			null
		},
		{
			Microsoft.Xna.Framework.Input.Keys.Apps,
			Squid.Keys.APPS
		},
		{
			Microsoft.Xna.Framework.Input.Keys.Sleep,
			Squid.Keys.SLEEP
		},
		{
			Microsoft.Xna.Framework.Input.Keys.NumPad0,
			Squid.Keys.NUMPAD0
		},
		{
			Microsoft.Xna.Framework.Input.Keys.NumPad1,
			Squid.Keys.NUMPAD1
		},
		{
			Microsoft.Xna.Framework.Input.Keys.NumPad2,
			Squid.Keys.NUMPAD2
		},
		{
			Microsoft.Xna.Framework.Input.Keys.NumPad3,
			Squid.Keys.NUMPAD3
		},
		{
			Microsoft.Xna.Framework.Input.Keys.NumPad4,
			Squid.Keys.NUMPAD4
		},
		{
			Microsoft.Xna.Framework.Input.Keys.NumPad5,
			Squid.Keys.NUMPAD5
		},
		{
			Microsoft.Xna.Framework.Input.Keys.NumPad6,
			Squid.Keys.NUMPAD6
		},
		{
			Microsoft.Xna.Framework.Input.Keys.NumPad7,
			Squid.Keys.NUMPAD7
		},
		{
			Microsoft.Xna.Framework.Input.Keys.NumPad8,
			Squid.Keys.NUMPAD8
		},
		{
			Microsoft.Xna.Framework.Input.Keys.NumPad9,
			Squid.Keys.NUMPAD9
		},
		{
			Microsoft.Xna.Framework.Input.Keys.Multiply,
			Squid.Keys.NUMPADSTAR
		},
		{
			Microsoft.Xna.Framework.Input.Keys.Add,
			Squid.Keys.NUMPADPLUS
		},
		{
			Microsoft.Xna.Framework.Input.Keys.Separator,
			null
		},
		{
			Microsoft.Xna.Framework.Input.Keys.Subtract,
			Squid.Keys.SUBTRACT
		},
		{
			Microsoft.Xna.Framework.Input.Keys.Decimal,
			Squid.Keys.DECIMAL
		},
		{
			Microsoft.Xna.Framework.Input.Keys.Divide,
			Squid.Keys.NUMPADSLASH
		},
		{
			Microsoft.Xna.Framework.Input.Keys.F1,
			Squid.Keys.F1
		},
		{
			Microsoft.Xna.Framework.Input.Keys.F2,
			Squid.Keys.F2
		},
		{
			Microsoft.Xna.Framework.Input.Keys.F3,
			Squid.Keys.F3
		},
		{
			Microsoft.Xna.Framework.Input.Keys.F4,
			Squid.Keys.F4
		},
		{
			Microsoft.Xna.Framework.Input.Keys.F5,
			Squid.Keys.F5
		},
		{
			Microsoft.Xna.Framework.Input.Keys.F6,
			Squid.Keys.F6
		},
		{
			Microsoft.Xna.Framework.Input.Keys.F7,
			Squid.Keys.F7
		},
		{
			Microsoft.Xna.Framework.Input.Keys.F8,
			Squid.Keys.F8
		},
		{
			Microsoft.Xna.Framework.Input.Keys.F9,
			Squid.Keys.F9
		},
		{
			Microsoft.Xna.Framework.Input.Keys.F10,
			Squid.Keys.F10
		},
		{
			Microsoft.Xna.Framework.Input.Keys.F11,
			Squid.Keys.F11
		},
		{
			Microsoft.Xna.Framework.Input.Keys.F12,
			Squid.Keys.F12
		},
		{
			Microsoft.Xna.Framework.Input.Keys.F13,
			Squid.Keys.F13
		},
		{
			Microsoft.Xna.Framework.Input.Keys.F14,
			Squid.Keys.F14
		},
		{
			Microsoft.Xna.Framework.Input.Keys.F15,
			Squid.Keys.F15
		},
		{
			Microsoft.Xna.Framework.Input.Keys.F16,
			null
		},
		{
			Microsoft.Xna.Framework.Input.Keys.F17,
			null
		},
		{
			Microsoft.Xna.Framework.Input.Keys.F18,
			null
		},
		{
			Microsoft.Xna.Framework.Input.Keys.F19,
			null
		},
		{
			Microsoft.Xna.Framework.Input.Keys.F20,
			null
		},
		{
			Microsoft.Xna.Framework.Input.Keys.F21,
			null
		},
		{
			Microsoft.Xna.Framework.Input.Keys.F22,
			null
		},
		{
			Microsoft.Xna.Framework.Input.Keys.F23,
			null
		},
		{
			Microsoft.Xna.Framework.Input.Keys.F24,
			null
		},
		{
			Microsoft.Xna.Framework.Input.Keys.NumLock,
			Squid.Keys.NUMLOCK
		},
		{
			Microsoft.Xna.Framework.Input.Keys.Scroll,
			Squid.Keys.SCROLL
		},
		{
			Microsoft.Xna.Framework.Input.Keys.LeftShift,
			Squid.Keys.LEFTSHIFT
		},
		{
			Microsoft.Xna.Framework.Input.Keys.RightShift,
			Squid.Keys.RIGHTSHIFT
		},
		{
			Microsoft.Xna.Framework.Input.Keys.LeftControl,
			Squid.Keys.LEFTCONTROL
		},
		{
			Microsoft.Xna.Framework.Input.Keys.RightControl,
			Squid.Keys.RIGHTCONTROL
		},
		{
			Microsoft.Xna.Framework.Input.Keys.LeftAlt,
			Squid.Keys.LEFTMENU
		},
		{
			Microsoft.Xna.Framework.Input.Keys.RightAlt,
			Squid.Keys.ALT_RIGHT
		},
		{
			Microsoft.Xna.Framework.Input.Keys.BrowserBack,
			Squid.Keys.WEBBACK
		},
		{
			Microsoft.Xna.Framework.Input.Keys.BrowserForward,
			Squid.Keys.WEBFORWARD
		},
		{
			Microsoft.Xna.Framework.Input.Keys.BrowserRefresh,
			Squid.Keys.WEBREFRESH
		},
		{
			Microsoft.Xna.Framework.Input.Keys.BrowserStop,
			Squid.Keys.WEBSTOP
		},
		{
			Microsoft.Xna.Framework.Input.Keys.BrowserSearch,
			Squid.Keys.WEBSEARCH
		},
		{
			Microsoft.Xna.Framework.Input.Keys.BrowserFavorites,
			Squid.Keys.WEBFAVORITES
		},
		{
			Microsoft.Xna.Framework.Input.Keys.BrowserHome,
			Squid.Keys.WEBHOME
		},
		{
			Microsoft.Xna.Framework.Input.Keys.VolumeMute,
			Squid.Keys.MUTE
		},
		{
			Microsoft.Xna.Framework.Input.Keys.VolumeDown,
			Squid.Keys.VOLUMEDOWN
		},
		{
			Microsoft.Xna.Framework.Input.Keys.VolumeUp,
			Squid.Keys.VOLUMEUP
		},
		{
			Microsoft.Xna.Framework.Input.Keys.MediaNextTrack,
			Squid.Keys.NEXTTRACK
		},
		{
			Microsoft.Xna.Framework.Input.Keys.MediaPreviousTrack,
			Squid.Keys.CIRCUMFLEX
		},
		{
			Microsoft.Xna.Framework.Input.Keys.MediaStop,
			Squid.Keys.STOP
		},
		{
			Microsoft.Xna.Framework.Input.Keys.MediaPlayPause,
			Squid.Keys.PLAYPAUSE
		},
		{
			Microsoft.Xna.Framework.Input.Keys.LaunchMail,
			Squid.Keys.MAIL
		},
		{
			Microsoft.Xna.Framework.Input.Keys.SelectMedia,
			Squid.Keys.MEDIASELECT
		},
		{
			Microsoft.Xna.Framework.Input.Keys.LaunchApplication1,
			null
		},
		{
			Microsoft.Xna.Framework.Input.Keys.LaunchApplication2,
			null
		},
		{
			Microsoft.Xna.Framework.Input.Keys.OemSemicolon,
			Squid.Keys.SEMICOLON
		},
		{
			Microsoft.Xna.Framework.Input.Keys.OemPlus,
			Squid.Keys.EQUALS
		},
		{
			Microsoft.Xna.Framework.Input.Keys.OemComma,
			Squid.Keys.COMMA
		},
		{
			Microsoft.Xna.Framework.Input.Keys.OemMinus,
			Squid.Keys.MINUS
		},
		{
			Microsoft.Xna.Framework.Input.Keys.OemPeriod,
			Squid.Keys.PERIOD
		},
		{
			Microsoft.Xna.Framework.Input.Keys.OemQuestion,
			Squid.Keys.SLASH
		},
		{
			Microsoft.Xna.Framework.Input.Keys.OemTilde,
			Squid.Keys.GRAVE
		},
		{
			Microsoft.Xna.Framework.Input.Keys.ChatPadGreen,
			null
		},
		{
			Microsoft.Xna.Framework.Input.Keys.ChatPadOrange,
			null
		},
		{
			Microsoft.Xna.Framework.Input.Keys.OemOpenBrackets,
			Squid.Keys.LEFTBRACKET
		},
		{
			Microsoft.Xna.Framework.Input.Keys.OemPipe,
			Squid.Keys.BACKSLASH
		},
		{
			Microsoft.Xna.Framework.Input.Keys.OemCloseBrackets,
			Squid.Keys.RIGHTBRACKET
		},
		{
			Microsoft.Xna.Framework.Input.Keys.OemQuotes,
			Squid.Keys.APOSTROPHE
		},
		{
			Microsoft.Xna.Framework.Input.Keys.Oem8,
			Squid.Keys.OEM_102
		},
		{
			Microsoft.Xna.Framework.Input.Keys.OemBackslash,
			Squid.Keys.BACKSLASH
		},
		{
			Microsoft.Xna.Framework.Input.Keys.ProcessKey,
			null
		},
		{
			Microsoft.Xna.Framework.Input.Keys.OemCopy,
			null
		},
		{
			Microsoft.Xna.Framework.Input.Keys.OemAuto,
			null
		},
		{
			Microsoft.Xna.Framework.Input.Keys.OemEnlW,
			null
		},
		{
			Microsoft.Xna.Framework.Input.Keys.Attn,
			null
		},
		{
			Microsoft.Xna.Framework.Input.Keys.Crsel,
			null
		},
		{
			Microsoft.Xna.Framework.Input.Keys.Exsel,
			null
		},
		{
			Microsoft.Xna.Framework.Input.Keys.EraseEof,
			null
		},
		{
			Microsoft.Xna.Framework.Input.Keys.Play,
			null
		},
		{
			Microsoft.Xna.Framework.Input.Keys.Zoom,
			null
		},
		{
			Microsoft.Xna.Framework.Input.Keys.Pa1,
			null
		},
		{
			Microsoft.Xna.Framework.Input.Keys.OemClear,
			null
		}
	};

	public static char? ChangeKeyboard(this Microsoft.Xna.Framework.Input.Keys keys, bool capital)
	{
		return keys switch
		{
			Microsoft.Xna.Framework.Input.Keys.A => capital ? 'A' : 'a',
			Microsoft.Xna.Framework.Input.Keys.B => capital ? 'B' : 'b',
			Microsoft.Xna.Framework.Input.Keys.C => capital ? 'C' : 'c',
			Microsoft.Xna.Framework.Input.Keys.D => capital ? 'D' : 'd',
			Microsoft.Xna.Framework.Input.Keys.E => capital ? 'E' : 'e',
			Microsoft.Xna.Framework.Input.Keys.H => capital ? 'H' : 'h',
			Microsoft.Xna.Framework.Input.Keys.K => capital ? 'K' : 'k',
			Microsoft.Xna.Framework.Input.Keys.M => capital ? 'M' : 'm',
			Microsoft.Xna.Framework.Input.Keys.P => capital ? 'P' : 'p',
			Microsoft.Xna.Framework.Input.Keys.Q => capital ? 'Q' : 'q',
			Microsoft.Xna.Framework.Input.Keys.S => capital ? 'S' : 's',
			Microsoft.Xna.Framework.Input.Keys.T => capital ? 'T' : 't',
			Microsoft.Xna.Framework.Input.Keys.V => capital ? 'V' : 'v',
			Microsoft.Xna.Framework.Input.Keys.W => capital ? 'W' : 'w',
			Microsoft.Xna.Framework.Input.Keys.X => capital ? 'X' : 'x',
			Microsoft.Xna.Framework.Input.Keys.D3 => capital ? '#' : '3',
			Microsoft.Xna.Framework.Input.Keys.D4 => capital ? '$' : '4',
			Microsoft.Xna.Framework.Input.Keys.D5 => capital ? '%' : '5',
			Microsoft.Xna.Framework.Input.Keys.D6 => capital ? '^' : '6',
			Microsoft.Xna.Framework.Input.Keys.D7 => capital ? '&' : '7',
			Microsoft.Xna.Framework.Input.Keys.D9 => capital ? '(' : '9',
			Microsoft.Xna.Framework.Input.Keys.OemTilde => capital ? '~' : '`',
			Microsoft.Xna.Framework.Input.Keys.OemOpenBrackets => capital ? '{' : '[',
			Microsoft.Xna.Framework.Input.Keys.OemQuotes => capital ? '"' : '\'',
			Microsoft.Xna.Framework.Input.Keys.OemComma => capital ? '<' : ',',
			Microsoft.Xna.Framework.Input.Keys.OemPeriod => capital ? '>' : '.',
			Microsoft.Xna.Framework.Input.Keys.OemQuestion => capital ? '?' : '/',
			Microsoft.Xna.Framework.Input.Keys.Space => ' ',
			Microsoft.Xna.Framework.Input.Keys.NumPad3 => '3',
			Microsoft.Xna.Framework.Input.Keys.NumPad6 => '6',
			Microsoft.Xna.Framework.Input.Keys.NumPad7 => '7',
			Microsoft.Xna.Framework.Input.Keys.Divide => '/',
			Microsoft.Xna.Framework.Input.Keys.Multiply => '*',
			Microsoft.Xna.Framework.Input.Keys.Subtract => '-',
			Microsoft.Xna.Framework.Input.Keys.Decimal => '.',
			Microsoft.Xna.Framework.Input.Keys.Add => '+',
			Microsoft.Xna.Framework.Input.Keys.NumPad9 => '9',
			Microsoft.Xna.Framework.Input.Keys.NumPad8 => '8',
			Microsoft.Xna.Framework.Input.Keys.NumPad5 => '5',
			Microsoft.Xna.Framework.Input.Keys.NumPad4 => '4',
			Microsoft.Xna.Framework.Input.Keys.NumPad2 => '2',
			Microsoft.Xna.Framework.Input.Keys.NumPad1 => '1',
			Microsoft.Xna.Framework.Input.Keys.NumPad0 => '0',
			Microsoft.Xna.Framework.Input.Keys.Enter => '\r',
			Microsoft.Xna.Framework.Input.Keys.Back => '\b',
			Microsoft.Xna.Framework.Input.Keys.Tab => '\t',
			Microsoft.Xna.Framework.Input.Keys.OemBackslash => '\\',
			Microsoft.Xna.Framework.Input.Keys.OemSemicolon => capital ? ':' : ';',
			Microsoft.Xna.Framework.Input.Keys.OemPipe => capital ? '|' : '\\',
			Microsoft.Xna.Framework.Input.Keys.OemCloseBrackets => capital ? '}' : ']',
			Microsoft.Xna.Framework.Input.Keys.OemPlus => capital ? '+' : '=',
			Microsoft.Xna.Framework.Input.Keys.OemMinus => capital ? '_' : '-',
			Microsoft.Xna.Framework.Input.Keys.D0 => capital ? ')' : '0',
			Microsoft.Xna.Framework.Input.Keys.D8 => capital ? '*' : '8',
			Microsoft.Xna.Framework.Input.Keys.D2 => capital ? '@' : '2',
			Microsoft.Xna.Framework.Input.Keys.D1 => capital ? '!' : '1',
			Microsoft.Xna.Framework.Input.Keys.Z => capital ? 'Z' : 'z',
			Microsoft.Xna.Framework.Input.Keys.Y => capital ? 'Y' : 'y',
			Microsoft.Xna.Framework.Input.Keys.U => capital ? 'U' : 'u',
			Microsoft.Xna.Framework.Input.Keys.R => capital ? 'R' : 'r',
			Microsoft.Xna.Framework.Input.Keys.O => capital ? 'O' : 'o',
			Microsoft.Xna.Framework.Input.Keys.N => capital ? 'N' : 'n',
			Microsoft.Xna.Framework.Input.Keys.L => capital ? 'L' : 'l',
			Microsoft.Xna.Framework.Input.Keys.J => capital ? 'J' : 'j',
			Microsoft.Xna.Framework.Input.Keys.I => capital ? 'I' : 'i',
			Microsoft.Xna.Framework.Input.Keys.G => capital ? 'G' : 'g',
			Microsoft.Xna.Framework.Input.Keys.F => capital ? 'F' : 'f',
			_ => null,
		};
	}

	public static void SetSkin(this Desktop squid, string skin, string asset = null)
	{
		XmlSerializableFactory factory = new XmlSerializableFactory();
		factory.Read($"{AppDomain.CurrentDomain.BaseDirectory}/Content-Release/{skin}.xml");
		foreach (ControlStyle control in squid.Skin.Values)
		{
			foreach (Style style in control.Styles.Values)
			{
				if (!string.IsNullOrEmpty(style.Texture) && factory.ContainsKey(style.Texture))
				{
					style.TextureRect = factory.Get(style.Texture);
					style.Texture = asset ?? skin;
				}
			}
		}
	}

	public static void ShowConfirm(this Desktop desktop, string message, int width, string buttonText = "OK", Action confirm = null)
	{
		Window container = new Window
		{
			Modal = true,
			Dock = DockStyle.Center,
			Padding = new Margin(15),
			Size = new Point(width,0),
			AutoSize = AutoSize.Vertical
		};
		container.Controls.Add(new Label
		{
			Dock = DockStyle.Top,
			TextAlign = Alignment.MiddleCenter,
			Text = message,
			TextWrap = true,
			AutoSize = AutoSize.Vertical,
			Margin = new Margin(0,0,0,10)
		});
		Button button = new Button
		{
			Dock = DockStyle.Top,
			Text = buttonText,
			Padding = new Margin(5,0,5,0),
			Margin = new Margin(0,0,0,15),
			Scissor = true
		};
		button.MouseClick += delegate
		{
			container.Close();
			if (confirm != null)
			{
				confirm();
			}
		};
		container.Controls.Add(button);
		container.Show(desktop);
	}

	public static void ShowSelection(this Desktop desktop, string message, string[] variants, int width, Action<int> select)
	{
		Window container = new Window
		{
			Modal = true,
			Dock = DockStyle.Center,
			Padding = new Margin(15),
			Size = new Point(width,0),
			AutoSize = AutoSize.Vertical
		};
		container.Controls.Add(new Label
		{
			Dock = DockStyle.Top,
			TextAlign = Alignment.MiddleCenter,
			Text = message,
			TextWrap = true,
			AutoSize = AutoSize.Vertical,
			Margin = new Margin(0,0,0,10)
		});
		for (int i = 0; i < variants.Length; i++)
		{
			Button button = new Button
			{
				Dock = DockStyle.Top,
				Text = variants[i],
				Padding = new Margin(5, 0, 5, 0),
				Margin = new Margin(0, 0, 0, (i < variants.Length - 1) ? 5 : 15),
				Scissor = true
			};
			int index = i;
			button.MouseClick += delegate
			{
				container.Close();
				select(index);
			};
			container.Controls.Add(button);
		}
		container.Show(desktop);
	}
}
