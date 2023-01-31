using System;
using System.Collections.Generic;
using System.Linq;
using Amorous.Engine.GUI;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Squid;

public class TypingDialogue
{ // _nkzqFdEfDyLcyGikIKGcHjklI4y
	private enum OverlayState
	{
		None,
		Started,
		Visible
	}

	private enum TypingPhase
	{
		None,
		Started,
		Typing,
		Waiting,
		WaitForSkip,
		Skip,
		Done
	}

	private class TypingOverlay
	{
		private readonly List<TypingOverlayChunk> _chunks;
		private int _chunk;

		public bool Completable => _chunk >= _chunks.Count;
		public string Message { get; }
		public string Author { get; }
		public Color Color { get; }

		public TypingOverlay(string message, string author, Color color)
		{
			Message = message.Replace("%playername%", PlayerPreferences.GetPlayerData().Name).Trim();
			if (!(author == "%playername%"))
			{
				Author = author;
			}
			else
			{
				Author = PlayerPreferences.GetPlayerData().Name;
			}
			Color = color;
			_chunks = new List<TypingOverlayChunk>();
		}

		public void Begin(SpriteFont font, SpriteFont italicFont)
		{
			_chunks.Clear();
			_chunk = 0;
			if (string.IsNullOrEmpty(Message))
			{
				return;
			}
			string buffer = Message;
			int index = 0;
			string text = string.Empty;
			int width = 0;
			int offset = 0;
			bool isItalic = false;
			bool isBold = false;
			char tag = ' ';
			bool isStyle = false;
			while (index < buffer.Length)
			{
				char symbol = buffer[index++];
				if (symbol == '<' && ConsumeTag(ref buffer, ref index, ref tag, ref isStyle))
				{
					if (text.Length > 0)
					{
						_chunks.Add(new TypingOverlayChunk(text, lineEnding: false, isItalic, isBold, offset));
						text = string.Empty;
						offset = width;
					}
					switch (tag)
					{
						case 'b':
							isBold = !isStyle;
							break;
						case 'i':
							isItalic = !isStyle;
							break;
					}
					continue;
				}
				text += symbol;
				if (IsWhitespace(ref symbol))
				{
					continue;
				}
				if (symbol != '\n')
				{
					width += (int)(isItalic ? italicFont : font).MeasureString(symbol.ToString()).X;
					if (width < 1770)
					{
						continue;
					}
					while (text.Length != 0 && index != 0)
					{
						index--;
						if (buffer[index] == ' ')
						{
							break;
						}
						text = text.Substring(0, text.Length - 1);
					}
					if (text.Length == 0)
					{
						if (_chunks.Count > 0)
						{
							_chunks[_chunks.Count - 1].IsLineEnding = true;
						}
					}
					else
					{
						_chunks.Add(new TypingOverlayChunk(text, lineEnding: true, isItalic, isBold, offset));
						text = string.Empty;
					}
					offset = 0;
					width = 0;
				}
				else
				{
					if (text.Length > 0)
					{
						_chunks.Add(new TypingOverlayChunk(text, lineEnding: true, isItalic, isBold, offset));
						text = string.Empty;
						offset = 0;
					}
					width = 0;
				}
			}
			if (text.Length > 0)
			{
				_chunks.Add(new TypingOverlayChunk(text, lineEnding: false, isItalic, isBold, offset));
			}
		}

		private bool ConsumeTag(ref string text, ref int index, ref char symbol, ref bool flag)
		{
			int position = index;
			if (position >= text.Length)
			{
				return false;
			}
			symbol = text[position++];
			flag = symbol == '/';
			if (position < text.Length)
			{
				if (flag)
				{
					symbol = text[position++];
				}
				if (position < text.Length)
				{
					char next = text[position++];
					if (next == '>' && IsStyle(ref symbol))
					{
						index = position;
						return true;
					}
					return false;
				}
				return false;
			}
			return false;
		}

		private bool IsStyle(ref char symbol)
		{
			if (symbol != 'i')
			{
				return symbol == 'b';
			}
			return true;
		}

		private bool IsWhitespace(ref char symbol)
		{
			if (symbol != '░')
			{
				return symbol == '\r';
			}
			return true;
		}

		public void SkipToNext()
		{
			if (Completable)
			{
				return;
			}
			foreach (TypingOverlayChunk chunk in _chunks)
			{
				chunk.Complete();
			}
			_chunk = _chunks.Count;
		}

		public char GetCharacter()
		{
			if (Completable)
			{
				return ' ';
			}
			TypingOverlayChunk chunk = _chunks[_chunk];
			char symbol = chunk.ComputeCharacter();
			if (chunk.Completable)
			{
				_chunk++;
			}
			return symbol;
		}

		public void Draw(SpriteBatch spriteBatch, SpriteFont font, SpriteFont italicFont, Vector2[] lineLocations)
		{
			int line = 0;
			foreach (TypingOverlayChunk chunk in _chunks)
			{
				if (line < lineLocations.Length)
				{
					chunk.Draw(spriteBatch, font, italicFont, lineLocations[line], Color);
					if (chunk.IsLineEnding)
					{
						line++;
					}
					continue;
				}
				break;
			}
		}
	}

	private class TypingOverlayChunk
	{
		private int _position;
		private readonly Vector2 _offset;

		public bool Completable => _position >= Text.Length;
		public string Text { get; }
		public bool IsLineEnding { get; set; }
		public bool IsItalic { get; }
		public bool IsBold { get; }

		public TypingOverlayChunk(string text, bool lineEnding, bool italic, bool bold, int offset)
		{
			Text = ((offset == 0) ? text.Trim() : text);
			IsLineEnding = lineEnding;
			IsItalic = italic;
			IsBold = bold;
			_offset = new Vector2(offset, 0f);
		}

		public void Complete()
		{
			_position = Text.Length;
		}

		public char ComputeCharacter()
		{
			if (Completable)
			{
				return ' ';
			}
			return Text[_position++];
		}

		public void Draw(SpriteBatch spriteBatch, SpriteFont font, SpriteFont _italicFont, Vector2 location, Color color)
		{
			string text = ComputeText();
			if (!string.IsNullOrEmpty(text))
			{
				if (IsItalic)
				{
					spriteBatch.DrawString(_italicFont, text, location + _offset, color);
				}
				else
				{
					spriteBatch.DrawString(font, text, location + _offset, color);
				}
			}
		}

		private string ComputeText()
		{
			if (_position == 0)
			{
				return string.Empty;
			}
			string buffer = ((_position >= Text.Length) ? Text : Text.Substring(0, _position));
			string text = string.Empty;
			int index = 0;
			for (int count = buffer.IndexOf('░'); count >= 0; count = buffer.IndexOf('░', index))
			{
				text += buffer.Substring(index, count - index);
				index = count + 1;
			}
			if (index < buffer.Length)
			{
				text += buffer.Substring(index);
			}
			return text;
		}
	}

	private class ChoiceOverlay : InteractableOverlay
	{
		private readonly ButtonInteractable[] _variants;
		private int _count;

		public int Which { get; private set; }
		public bool Outgoing { get; private set; }

		public ChoiceOverlay(IAmorous game, Texture2D buttonTexture, Texture2D backgroundButtonTexture, SpriteFont font)
			: base(game)
		{
			_variants = new ButtonInteractable[5];
			Which = -1;
			_count = 0;
			_variants[0] = AddButtonInteractable(buttonTexture, backgroundButtonTexture, font, "Choice 1", new Color(250, 251, 162), 0, 0, new Microsoft.Xna.Framework.Rectangle(0, 0, buttonTexture.Width, buttonTexture.Height), ChoiceFirst);
			_variants[1] = AddButtonInteractable(buttonTexture, backgroundButtonTexture, font, "Choice 2", new Color(165, 250, 171), 0, 0, new Microsoft.Xna.Framework.Rectangle(0, 0, buttonTexture.Width, buttonTexture.Height), ChoiceSecond);
			_variants[2] = AddButtonInteractable(buttonTexture, backgroundButtonTexture, font, "Choice 3", new Color(171, 199, 255), 0, 0, new Microsoft.Xna.Framework.Rectangle(0, 0, buttonTexture.Width, buttonTexture.Height), ChoiceThird);
			_variants[3] = AddButtonInteractable(buttonTexture, backgroundButtonTexture, font, "Choice 4", new Color(228, 187, 253), 0, 0, new Microsoft.Xna.Framework.Rectangle(0, 0, buttonTexture.Width, buttonTexture.Height), ChoiceForth);
			_variants[4] = AddButtonInteractable(buttonTexture, backgroundButtonTexture, font, "Choice 5", new Color(255, 171, 179), 0, 0, new Microsoft.Xna.Framework.Rectangle(0, 0, buttonTexture.Width, buttonTexture.Height), ChoiceFifth);
			Select(-1);
		}

		public void ShowChoice(params string[] variants)
		{
			if (variants.Length != 0)
			{
				Outgoing = true;
				Which = 0;
				_count = 0;
				for (int i = 0; i < variants.Length && i < _variants.Length; i++)
				{
					_variants[i].Text = variants[i];
					_variants[i].Visible = true;
					_count++;
				}
				for (int j = variants.Length; j < _variants.Length; j++)
				{
					_variants[j].Visible = false;
				}
				int y = (int)(30f + (float)(690 - _variants[0].Bounds.Height - (_variants[0].Bounds.Height + 15) * (_count - 1)) / 2f);
				for (int k = 0; k < _count; k++)
				{
					_variants[k].X = (int)((float)(1920 - _variants[k].Bounds.Width) / 2f);
					_variants[k].Y = y + (_variants[k].Bounds.Height + 15) * k;
				}
			}
		}

		public void Select(int which)
		{
			Outgoing = false;
			Which = which;
			_count = 0;
			foreach (ButtonInteractable button in _variants)
			{
				button.Visible = false;
			}
		}

		private void ChoiceFirst()
		{
			Select(1);
		}

		private void ChoiceSecond()
		{
			Select(2);
		}

		private void ChoiceThird()
		{
			Select(3);
		}

		private void ChoiceForth()
		{
			Select(4);
		}

		private void ChoiceFifth()
		{
			Select(5);
		}
	}

	private struct TypingSpeed
	{
		public static readonly TypingSpeed Slow = new TypingSpeed(100, 750, 2000);
		public static readonly TypingSpeed Normal = new TypingSpeed(60, 450, 1500);
		public static readonly TypingSpeed Fast = new TypingSpeed(30, 300, 1000);
		public static readonly TypingSpeed Instant = new TypingSpeed(0, 0, 1000);

		public int WhitespaceDelay { get; }
		public int CharacterDelay { get; }
		public int AutoSkipDelay { get; }

		private TypingSpeed(int whitespace, int character, int autoSkip)
		{
			WhitespaceDelay = whitespace;
			CharacterDelay = character;
			AutoSkipDelay = autoSkip;
		}
	}

	private static TypingDialogue _singleton;
	private readonly IAmorous _game;
	private readonly Texture2D _dialogueTexture;
	private readonly SpriteFont _font, _italicFont;
	private readonly Vector2 _backgroundLocation;
	private readonly Vector2 _controlBounds;
	private readonly Vector2[] _lineLocations;
	private readonly ChoiceOverlay _choiceOverlay;
	private Desktop _squid;
	private DialogueSpeed _dialogueSpeed;
	private TypingSpeed _speed;
	private DropDownList _speedDropDown;
	private bool _autoSkip;
	private CheckBox _autoSkipBox;
	private OverlayState _overlayState;
	private TypingPhase _phase;
	private TypingPhase _pendingPhase;
	private int _ticks;
	private TypingOverlay _dialogue;

	public static bool Completable => _singleton._phase == TypingPhase.Done;
	public static bool Outgoing => _singleton._choiceOverlay.Outgoing;
	public static int Which => _singleton._choiceOverlay.Which;

	public static DialogueSpeed Speed
	{
		get
		{
			return _singleton._dialogueSpeed;
		}
		set
		{
			_singleton._dialogueSpeed = value;
			switch (_singleton._dialogueSpeed)
			{
				case DialogueSpeed.Slow:
					_singleton._speed = TypingSpeed.Slow;
					break;
				case DialogueSpeed.Normal:
					_singleton._speed = TypingSpeed.Normal;
					break;
				case DialogueSpeed.Fast:
					_singleton._speed = TypingSpeed.Fast;
					break;
				case DialogueSpeed.Instant:
					_singleton._speed = TypingSpeed.Instant;
					break;
			}
			_singleton.UpdateSelectedSpeed();
		}
	}

	public static bool AutoSkip
	{
		get
		{
			return _singleton._autoSkip;
		}
		set
		{
			_singleton._autoSkip = value;
			_singleton.UpdateCheckedAutoSkip();
		}
	}

	public TypingDialogue(IAmorous game, Texture2D dialogueTexture, Texture2D buttonTexture, SpriteFont font, SpriteFont italicFont)
	{
		_singleton = this;
		_game = game;
		_dialogueTexture = dialogueTexture;
		_font = font;
		_italicFont = italicFont;
		_backgroundLocation = new Vector2((float)(dialogueTexture.Width - 1920) / 2f, 1080 - dialogueTexture.Height);
		_controlBounds = new Vector2(75f, 625f);
		_lineLocations = new Vector2[6]
		{
			new Vector2(75f, 720f),
			new Vector2(75f, 770f),
			new Vector2(75f, 820f),
			new Vector2(75f, 870f),
			new Vector2(75f, 920f),
			new Vector2(75f, 970f)
		};
		_choiceOverlay = new ChoiceOverlay(game, buttonTexture, null, font);
		Speed = DialogueSpeed.Normal;
		CreateOverlay();
	}

	private void CreateOverlay()
	{
		_squid = new Desktop
		{
			Skin = Gui.GenerateStandardSkin(),
			Size = new Squid.Point(1920, 1080)
		};
		_squid.SetSkin("Assets/GUI/Squid/DefaultSkin");
		FlowLayoutFrame container = new FlowLayoutFrame
		{
			Position = new Squid.Point(1220, (int)_controlBounds.Y + 10),
			FlowDirection = FlowDirection.LeftToRight,
			Margin = new Margin(0, 0, 100, 0),
			HSpacing = 10,
			Size = new Squid.Point(650, 30)
		};
		Button saveButton = new Button
		{
			Size = new Squid.Point(100, 30),
			TextAlign = Alignment.MiddleCenter,
			Text = "Save"
		};
		saveButton.MouseClick += delegate
		{
			_game.ShowSave(_squid, delegate(bool toggle)
			{
				_choiceOverlay.Touchable = toggle;
			});
		};
		Button loadButton = new Button
		{
			Size = new Squid.Point(100, 30),
			TextAlign = Alignment.MiddleCenter,
			Text = "Load"
		};
		loadButton.MouseClick += delegate
		{
			_game.ShowLoad(_squid, delegate(bool toggle)
			{
				_choiceOverlay.Touchable = toggle;
			});
		};
		Button exitButton = new Button
		{
			Size = new Squid.Point(100, 30),
			TextAlign = Alignment.MiddleCenter,
			Text = "Exit"
		};
		exitButton.MouseClick += delegate
		{
			_game.ShowExit(_squid, delegate(bool toggle)
			{
				_choiceOverlay.Touchable = toggle;
			});
		};
		_speedDropDown = new DropDownList();
		_speedDropDown.Style = "button";
		_speedDropDown.Size = new Squid.Point(120, 30);
		_speedDropDown.DropdownAbove = true;
		_speedDropDown.Label.TextAlign = Alignment.MiddleCenter;
		_speedDropDown.Label.AutoEllipsis = false;
		_speedDropDown.Dropdown.Resizable = false;
		_speedDropDown.Button.Visible = false;
		_speedDropDown.Listbox.Scrollbar.ButtonUp.Visible = false;
		_speedDropDown.Listbox.Scrollbar.ButtonDown.Visible = false;
		foreach (DialogueSpeed speed in Enum.GetValues(typeof(DialogueSpeed)))
		{
			_speedDropDown.Items.Add(new ListBoxItem
			{
				Text = speed.ToString(),
				Size = new Squid.Point(0, 30),
				Value = speed
			});
		}
		_speedDropDown.SelectedItemChanged += delegate(Control container, ListBoxItem box)
		{
			Speed = (DialogueSpeed)box.Value;
			Options.Data.DialogueTextSpeed = _dialogueSpeed;
		};
		_autoSkipBox = new CheckBox
		{
			Text = "Auto-skip",
			Size = new Squid.Point(140, 30),
			Checked = AutoSkip
		};
		_autoSkipBox.CheckedChanged += delegate
		{
			AutoSkip = _autoSkipBox.Checked;
			Options.Data.DialogueAutoSkip = _autoSkip;
		};
		container.Controls.Add(saveButton);
		container.Controls.Add(loadButton);
		container.Controls.Add(exitButton);
		container.Controls.Add(_autoSkipBox);
		container.Controls.Add(_speedDropDown);
		_squid.Controls.Add(container);
	}

	private void UpdateSelectedSpeed()
	{
		if (_singleton._speedDropDown != null)
		{
			_singleton._speedDropDown.SelectedItem = _singleton._speedDropDown.Items.First((ListBoxItem box) => (DialogueSpeed)box.Value == _dialogueSpeed);
		}
	}

	private void UpdateCheckedAutoSkip()
	{
		if (_singleton._autoSkipBox != null)
		{
			_singleton._autoSkipBox.Checked = _autoSkip;
		}
	}

	public void Update(GameTime gameTime)
	{
		switch (_overlayState)
		{
			case OverlayState.None:
				return;
			case OverlayState.Started:
				_overlayState = OverlayState.Visible;
				return;
		}
		_choiceOverlay.Update(gameTime);
		if (_game.Cutscene != null)
		{
			_squid.Update();
		}
		if (_choiceOverlay.Touchable)
		{
			Interact(gameTime);
		}
	}

	private void Interact(GameTime gameTime)
	{
		if (_phase == TypingPhase.Done)
		{
			if (_game.Cutscene == null)
			{
				Reset();
			}
			return;
		}
		if ((_phase == TypingPhase.Waiting || _phase == TypingPhase.Typing || _phase == TypingPhase.WaitForSkip) && IsPressedSkip())
		{
			SkipToNext();
			if (_pendingPhase != 0)
			{
				_phase = _pendingPhase;
				_pendingPhase = TypingPhase.None;
			}
			else if (!AutoSkip)
			{
				_phase = TypingPhase.WaitForSkip;
				_pendingPhase = TypingPhase.Skip;
			}
			else
			{
				_ticks = _speed.AutoSkipDelay;
				_phase = TypingPhase.Waiting;
				_pendingPhase = TypingPhase.Skip;
			}
		}
		switch (_phase)
		{
			case TypingPhase.Started:
				if (_speed.WhitespaceDelay != 0)
				{
					_phase = TypingPhase.Typing;
					_pendingPhase = TypingPhase.None;
				}
				else
				{
					SkipToNext();
					_phase = TypingPhase.WaitForSkip;
					_pendingPhase = TypingPhase.Skip;
				}
				break;
			case TypingPhase.Typing:
			{
				char c = _dialogue.GetCharacter();
				if (_dialogue.Completable)
				{
					if (!AutoSkip)
					{
						_phase = TypingPhase.WaitForSkip;
					}
					else
					{
						_ticks = _speed.AutoSkipDelay;
						_phase = TypingPhase.Waiting;
					}
					_pendingPhase = TypingPhase.Skip;
				}
				else
				{
					if (c != '░')
					{
						_ticks = _speed.WhitespaceDelay;
					}
					else
					{
						_ticks = _speed.CharacterDelay;
					}
					_phase = TypingPhase.Waiting;
					_pendingPhase = TypingPhase.Typing;
				}
				break;
			}
			case TypingPhase.Waiting:
				_ticks -= gameTime.ElapsedGameTime.Milliseconds;
				if (_ticks <= 0)
				{
					_ticks = 0;
					_phase = _pendingPhase;
					_pendingPhase = TypingPhase.None;
				}
				break;
			case TypingPhase.Skip:
				_phase = TypingPhase.Done;
				_pendingPhase = TypingPhase.None;
				break;
			case TypingPhase.WaitForSkip:
				break;
		}
	}

	private bool IsPressedSkip()
	{
		if (_game.Controller.IsPressed(Microsoft.Xna.Framework.Input.Keys.Space))
		{
			return true;
		}
		if (_game.Controller.IsPressed(ControllerButtonType.LeftButton))
		{
			Microsoft.Xna.Framework.Point cursor = _game.Canvas.GlobalToContent(_game.Controller.Cursor);
			if ((float)cursor.Y >= _backgroundLocation.Y + 10f && cursor.Y <= 1080)
			{
				return true;
			}
		}
		return false;
	}

	private void TypeNow(TypingOverlay dialogue)
	{
		_dialogue = dialogue;
		_dialogue.Begin(_font, _italicFont);
		_dialogue.SkipToNext();
		_overlayState = OverlayState.Started;
		_phase = TypingPhase.Started;
		_pendingPhase = TypingPhase.None;
	}

	private void Type(TypingOverlay dialogue)
	{
		_dialogue = dialogue;
		_dialogue.Begin(_font, _italicFont);
		_ticks = 150;
		_overlayState = OverlayState.Started;
		_phase = TypingPhase.Started;
		_pendingPhase = TypingPhase.None;
	}

	public void Draw(SpriteBatch spriteBatch)
	{
		if (_overlayState == OverlayState.None)
		{
			return;
		}
		_choiceOverlay.Draw(spriteBatch);
		if (_dialogue != null)
		{
			spriteBatch.Begin();
			spriteBatch.Draw(_dialogueTexture, _backgroundLocation, _dialogue.Color);
			if (!string.IsNullOrEmpty(_dialogue.Author))
			{
				spriteBatch.DrawString(_font, _dialogue.Author, _controlBounds, _dialogue.Color);
			}
			_dialogue.Draw(spriteBatch, _font, _italicFont, _lineLocations);
			spriteBatch.End();
			if (_game.Cutscene != null)
			{
				_squid.Draw();
			}
		}
	}

	public void Reset()
	{
		_dialogue = null;
		_ticks = 0;
		_overlayState = OverlayState.None;
		_phase = TypingPhase.None;
		_pendingPhase = TypingPhase.None;
	}

	public static void TypeNow(string message, string author, Color color)
	{
		_singleton.TypeNow(new TypingOverlay(message, author, color));
	}

	public static void Type(string message, string author, Color color)
	{
		_singleton.Type(new TypingOverlay(message, author, color));
	}

	public static void SkipToNext()
	{
		if (_singleton._dialogue != null)
		{
			_singleton._dialogue.SkipToNext();
		}
	}

	public static void Choice(params string[] variants)
	{
		_singleton._choiceOverlay.ShowChoice(variants);
	}

	public static void Unselect()
	{
		_singleton._choiceOverlay.Select(0);
	}

	public static void Complete()
	{
		_singleton.Reset();
	}
}
