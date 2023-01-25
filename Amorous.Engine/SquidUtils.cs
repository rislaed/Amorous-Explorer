using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework.Input;
using Squid;

public static class SquidUtils
{
	public static readonly Dictionary<Microsoft.Xna.Framework.Input.Keys, Squid.Keys?> _HSj1lr89AFIB9adVhSrAeWjS1xC = new Dictionary<Microsoft.Xna.Framework.Input.Keys, Squid.Keys?>
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

	public static char? ChangeKeyboard(this Microsoft.Xna.Framework.Input.Keys keys_0, bool bool_0)
	{
		return keys_0 switch
		{
			Microsoft.Xna.Framework.Input.Keys.A => bool_0 ? 'A' : 'a', 
			Microsoft.Xna.Framework.Input.Keys.B => bool_0 ? 'B' : 'b', 
			Microsoft.Xna.Framework.Input.Keys.C => bool_0 ? 'C' : 'c', 
			Microsoft.Xna.Framework.Input.Keys.D => bool_0 ? 'D' : 'd', 
			Microsoft.Xna.Framework.Input.Keys.E => bool_0 ? 'E' : 'e', 
			Microsoft.Xna.Framework.Input.Keys.H => bool_0 ? 'H' : 'h', 
			Microsoft.Xna.Framework.Input.Keys.K => bool_0 ? 'K' : 'k', 
			Microsoft.Xna.Framework.Input.Keys.M => bool_0 ? 'M' : 'm', 
			Microsoft.Xna.Framework.Input.Keys.P => bool_0 ? 'P' : 'p', 
			Microsoft.Xna.Framework.Input.Keys.Q => bool_0 ? 'Q' : 'q', 
			Microsoft.Xna.Framework.Input.Keys.S => bool_0 ? 'S' : 's', 
			Microsoft.Xna.Framework.Input.Keys.T => bool_0 ? 'T' : 't', 
			Microsoft.Xna.Framework.Input.Keys.V => bool_0 ? 'V' : 'v', 
			Microsoft.Xna.Framework.Input.Keys.W => bool_0 ? 'W' : 'w', 
			Microsoft.Xna.Framework.Input.Keys.X => bool_0 ? 'X' : 'x', 
			Microsoft.Xna.Framework.Input.Keys.D3 => bool_0 ? '#' : '3', 
			Microsoft.Xna.Framework.Input.Keys.D4 => bool_0 ? '$' : '4', 
			Microsoft.Xna.Framework.Input.Keys.D5 => bool_0 ? '%' : '5', 
			Microsoft.Xna.Framework.Input.Keys.D6 => bool_0 ? '^' : '6', 
			Microsoft.Xna.Framework.Input.Keys.D7 => bool_0 ? '&' : '7', 
			Microsoft.Xna.Framework.Input.Keys.D9 => bool_0 ? '(' : '9', 
			Microsoft.Xna.Framework.Input.Keys.OemTilde => bool_0 ? '~' : '`', 
			Microsoft.Xna.Framework.Input.Keys.OemOpenBrackets => bool_0 ? '{' : '[', 
			Microsoft.Xna.Framework.Input.Keys.OemQuotes => bool_0 ? '"' : '\'', 
			Microsoft.Xna.Framework.Input.Keys.OemComma => bool_0 ? '<' : ',', 
			Microsoft.Xna.Framework.Input.Keys.OemPeriod => bool_0 ? '>' : '.', 
			Microsoft.Xna.Framework.Input.Keys.OemQuestion => bool_0 ? '?' : '/', 
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
			Microsoft.Xna.Framework.Input.Keys.OemSemicolon => bool_0 ? ':' : ';', 
			Microsoft.Xna.Framework.Input.Keys.OemPipe => bool_0 ? '|' : '\\', 
			Microsoft.Xna.Framework.Input.Keys.OemCloseBrackets => bool_0 ? '}' : ']', 
			Microsoft.Xna.Framework.Input.Keys.OemPlus => bool_0 ? '+' : '=', 
			Microsoft.Xna.Framework.Input.Keys.OemMinus => bool_0 ? '_' : '-', 
			Microsoft.Xna.Framework.Input.Keys.D0 => bool_0 ? ')' : '0', 
			Microsoft.Xna.Framework.Input.Keys.D8 => bool_0 ? '*' : '8', 
			Microsoft.Xna.Framework.Input.Keys.D2 => bool_0 ? '@' : '2', 
			Microsoft.Xna.Framework.Input.Keys.D1 => bool_0 ? '!' : '1', 
			Microsoft.Xna.Framework.Input.Keys.Z => bool_0 ? 'Z' : 'z', 
			Microsoft.Xna.Framework.Input.Keys.Y => bool_0 ? 'Y' : 'y', 
			Microsoft.Xna.Framework.Input.Keys.U => bool_0 ? 'U' : 'u', 
			Microsoft.Xna.Framework.Input.Keys.R => bool_0 ? 'R' : 'r', 
			Microsoft.Xna.Framework.Input.Keys.O => bool_0 ? 'O' : 'o', 
			Microsoft.Xna.Framework.Input.Keys.N => bool_0 ? 'N' : 'n', 
			Microsoft.Xna.Framework.Input.Keys.L => bool_0 ? 'L' : 'l', 
			Microsoft.Xna.Framework.Input.Keys.J => bool_0 ? 'J' : 'j', 
			Microsoft.Xna.Framework.Input.Keys.I => bool_0 ? 'I' : 'i', 
			Microsoft.Xna.Framework.Input.Keys.G => bool_0 ? 'G' : 'g', 
			Microsoft.Xna.Framework.Input.Keys.F => bool_0 ? 'F' : 'f', 
			_ => null, 
		};
	}

	public static void SetSkin(this Desktop desktop_0, string string_0, string string_1 = null)
	{
		_JQQysO7uwugUSzo1g63o3jzSP4H jQQysO7uwugUSzo1g63o3jzSP4H = new _JQQysO7uwugUSzo1g63o3jzSP4H();
		jQQysO7uwugUSzo1g63o3jzSP4H._Gz8axRA2ks9sOlb2vx60ucqDEM0($"{AppDomain.CurrentDomain.BaseDirectory}/Content-Release/{string_0}.xml");
		foreach (ControlStyle value in desktop_0.Skin.Values)
		{
			foreach (Style value2 in value.Styles.Values)
			{
				if (!string.IsNullOrEmpty(value2.Texture) && jQQysO7uwugUSzo1g63o3jzSP4H._eA4yRWB5CfMJCCzEhBJkRcJhaGT(value2.Texture))
				{
					value2.TextureRect = jQQysO7uwugUSzo1g63o3jzSP4H._zETvz5wV1cpcKFl6i5KBgWbBmFR(value2.Texture);
					value2.Texture = string_1 ?? string_0;
				}
			}
		}
	}

	public static void ShowConfirm(this Desktop desktop_0, string string_0, int int_0, string string_1 = "OK", Action action_0 = null)
	{
		Window _L7VColD35B3sDgJdUnjTeXGa7pv = new Window
		{
			Modal = true,
			Dock = DockStyle.Center,
			Padding = new Margin(15),
			Size = new Point(int_0, 0),
			AutoSize = AutoSize.Vertical
		};
		_L7VColD35B3sDgJdUnjTeXGa7pv.Controls.Add(new Label
		{
			Dock = DockStyle.Top,
			TextAlign = Alignment.MiddleCenter,
			Text = string_0,
			TextWrap = true,
			AutoSize = AutoSize.Vertical,
			Margin = new Margin(0, 0, 0, 10)
		});
		Button button = new Button
		{
			Dock = DockStyle.Top,
			Text = string_1,
			Padding = new Margin(5, 0, 5, 0),
			Margin = new Margin(0, 0, 0, 15),
			Scissor = true
		};
		button.MouseClick += delegate
		{
			_L7VColD35B3sDgJdUnjTeXGa7pv.Close();
			if (action_0 != null)
			{
				action_0();
			}
		};
		_L7VColD35B3sDgJdUnjTeXGa7pv.Controls.Add(button);
		_L7VColD35B3sDgJdUnjTeXGa7pv.Show(desktop_0);
	}

	public static void ShowSelection(this Desktop desktop_0, string string_0, string[] string_1, int int_0, Action<int> action_0)
	{
		Window _L7VColD35B3sDgJdUnjTeXGa7pv = new Window
		{
			Modal = true,
			Dock = DockStyle.Center,
			Padding = new Margin(15),
			Size = new Point(int_0, 0),
			AutoSize = AutoSize.Vertical
		};
		_L7VColD35B3sDgJdUnjTeXGa7pv.Controls.Add(new Label
		{
			Dock = DockStyle.Top,
			TextAlign = Alignment.MiddleCenter,
			Text = string_0,
			TextWrap = true,
			AutoSize = AutoSize.Vertical,
			Margin = new Margin(0, 0, 0, 10)
		});
		for (int i = 0; i < string_1.Length; i++)
		{
			string text = string_1[i];
			Button button = new Button
			{
				Dock = DockStyle.Top,
				Text = text,
				Padding = new Margin(5, 0, 5, 0),
				Margin = new Margin(0, 0, 0, (i < string_1.Length - 1) ? 5 : 15),
				Scissor = true
			};
			int _5ft6kbimSBgLCWvFCD6FPEU8cCO = i;
			button.MouseClick += delegate
			{
				int obj = _5ft6kbimSBgLCWvFCD6FPEU8cCO;
				_L7VColD35B3sDgJdUnjTeXGa7pv.Close();
				action_0(obj);
			};
			_L7VColD35B3sDgJdUnjTeXGa7pv.Controls.Add(button);
		}
		_L7VColD35B3sDgJdUnjTeXGa7pv.Show(desktop_0);
	}
}
