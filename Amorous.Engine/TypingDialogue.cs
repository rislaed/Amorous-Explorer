using System;
using System.Collections.Generic;
using System.Linq;
using Amorous.Engine.GUI;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Squid;

public class TypingDialogue
{ // _nkzqFdEfDyLcyGikIKGcHjklI4y
	private enum EState
	{
		None,
		Started,
		Visible
	}

	private enum EPhase
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
		private readonly List<TypingOverlayChunk> chunks;
		private int chunk;

		public bool IsCompleted => chunk >= chunks.Count;
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
			chunks = new List<TypingOverlayChunk>();
		}

		public void Begin(SpriteFont font, SpriteFont italicFont)
		{
			chunks.Clear();
			chunk = 0;
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
						chunks.Add(new TypingOverlayChunk(text, lineEnding: false, isItalic, isBold, offset));
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
						if (chunks.Count > 0)
						{
							chunks[chunks.Count - 1].IsLineEnding = true;
						}
					}
					else
					{
						chunks.Add(new TypingOverlayChunk(text, lineEnding: true, isItalic, isBold, offset));
						text = string.Empty;
					}
					offset = 0;
					width = 0;
				}
				else
				{
					if (text.Length > 0)
					{
						chunks.Add(new TypingOverlayChunk(text, lineEnding: true, isItalic, isBold, offset));
						text = string.Empty;
						offset = 0;
					}
					width = 0;
				}
			}
			if (text.Length > 0)
			{
				chunks.Add(new TypingOverlayChunk(text, lineEnding: false, isItalic, isBold, offset));
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
			if (IsCompleted)
			{
				return;
			}
			foreach (TypingOverlayChunk chunk in chunks)
			{
				chunk.Complete();
			}
			chunk = chunks.Count;
		}

		public char GetCharacter()
		{
			if (IsCompleted)
			{
				return ' ';
			}
			TypingOverlayChunk subchunk = chunks[chunk];
			char symbol = subchunk.ComputeCharacter();
			if (subchunk.IsCompleted)
			{
				chunk++;
			}
			return symbol;
		}

		public void Draw(SpriteBatch spriteBatch, SpriteFont font, SpriteFont italicFont, Vector2[] lineLocations)
		{
			int line = 0;
			foreach (TypingOverlayChunk chunk in chunks)
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
		private int index;
		private readonly Vector2 offset;

		public bool IsCompleted => index >= Text.Length;
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
			this.offset = new Vector2(offset, 0f);
		}

		public void Complete()
		{
			index = Text.Length;
		}

		public char ComputeCharacter()
		{
			if (IsCompleted)
			{
				return ' ';
			}
			return Text[index++];
		}

		public void Draw(SpriteBatch spriteBatch, SpriteFont font, SpriteFont italicFont, Vector2 location, Color color)
		{
			string text = ComputeText();
			if (!string.IsNullOrEmpty(text))
			{
				if (IsItalic)
				{
					spriteBatch.DrawString(italicFont, text, location + offset, color);
				}
				else
				{
					spriteBatch.DrawString(font, text, location + offset, color);
				}
			}
		}

		private string ComputeText()
		{
			if (this.index == 0)
			{
				return string.Empty;
			}
			string buffer = ((this.index >= Text.Length) ? Text : Text.Substring(0, this.index));
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
		private readonly ButtonInteractable[] choices;
		private int count;

		public int Which { get; private set; }
		public bool Visible { get; private set; }

		public ChoiceOverlay(IAmorous game, Texture2D buttonTexture, Texture2D backgroundButtonTexture, SpriteFont font) : base(game)
		{
			choices = new ButtonInteractable[5];
			Which = -1;
			count = 0;
			choices[0] = AddButtonInteractable(buttonTexture, backgroundButtonTexture, font, "Choice 1", new Color(250, 251, 162), 0, 0, new Microsoft.Xna.Framework.Rectangle(0, 0, buttonTexture.Width, buttonTexture.Height), ChoiceFirst);
			choices[1] = AddButtonInteractable(buttonTexture, backgroundButtonTexture, font, "Choice 2", new Color(165, 250, 171), 0, 0, new Microsoft.Xna.Framework.Rectangle(0, 0, buttonTexture.Width, buttonTexture.Height), ChoiceSecond);
			choices[2] = AddButtonInteractable(buttonTexture, backgroundButtonTexture, font, "Choice 3", new Color(171, 199, 255), 0, 0, new Microsoft.Xna.Framework.Rectangle(0, 0, buttonTexture.Width, buttonTexture.Height), ChoiceThird);
			choices[3] = AddButtonInteractable(buttonTexture, backgroundButtonTexture, font, "Choice 4", new Color(228, 187, 253), 0, 0, new Microsoft.Xna.Framework.Rectangle(0, 0, buttonTexture.Width, buttonTexture.Height), ChoiceFourth);
			choices[4] = AddButtonInteractable(buttonTexture, backgroundButtonTexture, font, "Choice 5", new Color(255, 171, 179), 0, 0, new Microsoft.Xna.Framework.Rectangle(0, 0, buttonTexture.Width, buttonTexture.Height), ChoiceFifth);
			Select(-1);
		}

		public void ShowChoice(params string[] variants)
		{
			if (variants.Length != 0)
			{
				Visible = true;
				Which = 0;
				count = 0;
				for (int i = 0; i < variants.Length && i < choices.Length; i++)
				{
					choices[i].Text = variants[i];
					choices[i].IsVisible = true;
					count++;
				}
				for (int j = variants.Length; j < choices.Length; j++)
				{
					choices[j].IsVisible = false;
				}
				int y = (int)(30f + (float)(690 - choices[0].Bounds.Height - (choices[0].Bounds.Height + 15) * (count - 1)) / 2f);
				for (int k = 0; k < count; k++)
				{
					choices[k].X = (int)((float)(1920 - choices[k].Bounds.Width) / 2f);
					choices[k].Y = y + (choices[k].Bounds.Height + 15) * k;
				}
			}
		}

		public void Select(int which)
		{
			Visible = false;
			Which = which;
			count = 0;
			foreach (ButtonInteractable button in choices)
			{
				button.IsVisible = false;
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

		private void ChoiceFourth()
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
		public static readonly TypingSpeed SLOW = new TypingSpeed(100, 750, 2000);
		public static readonly TypingSpeed NORMAL = new TypingSpeed(60, 450, 1500);
		public static readonly TypingSpeed FAST = new TypingSpeed(30, 300, 1000);
		public static readonly TypingSpeed INSTANT = new TypingSpeed(0, 0, 1000);

		public int WhitespaceDelay { get; }
		public int CharacterDelay { get; }
		public int AutoSkipDelay { get; }

		private TypingSpeed(int whitespace, int character, int autoskip)
		{
			WhitespaceDelay = whitespace;
			CharacterDelay = character;
			AutoSkipDelay = autoskip;
		}
	}

	private static TypingDialogue singleton;
	private readonly IAmorous game;
	private readonly Texture2D dialogueTexture;
	private readonly SpriteFont font, italicFont;
	private readonly Vector2 backgroundLocation;
	private readonly Vector2 optionBounds;
	private readonly Vector2[] lineLocations;
	private readonly ChoiceOverlay choiceOverlay;
	private Desktop desktop;
	private DialogueSpeed dialogueSpeed;
	private TypingSpeed speed;
	private DropDownList speedDropDown;
	private bool autoskip;
	private CheckBox autoskipBox;
	private EState overlayState;
	private EPhase phase;
	private EPhase pendingPhase;
	private int ticks;
	private TypingOverlay dialogue;

	public static bool IsCompleted => singleton.phase == EPhase.Done;
	public static bool Visible => singleton.choiceOverlay.Visible;
	public static int Which => singleton.choiceOverlay.Which;

	public static DialogueSpeed Speed
	{
		get
		{
			return singleton.dialogueSpeed;
		}
		set
		{
			singleton.dialogueSpeed = value;
			switch (singleton.dialogueSpeed)
			{
				case DialogueSpeed.Slow:
					singleton.speed = TypingSpeed.SLOW;
					break;
				case DialogueSpeed.Normal:
					singleton.speed = TypingSpeed.NORMAL;
					break;
				case DialogueSpeed.Fast:
					singleton.speed = TypingSpeed.FAST;
					break;
				case DialogueSpeed.Instant:
					singleton.speed = TypingSpeed.INSTANT;
					break;
			}
			singleton.UpdateSelectedSpeed();
		}
	}

	public static bool AutoSkip
	{
		get
		{
			return singleton.autoskip;
		}
		set
		{
			singleton.autoskip = value;
			singleton.UpdateCheckedAutoSkip();
		}
	}

	public TypingDialogue(IAmorous game, Texture2D dialogueTexture, Texture2D buttonTexture, SpriteFont font, SpriteFont italicFont)
	{
		singleton = this;
		this.game = game;
		this.dialogueTexture = dialogueTexture;
		this.font = font;
		this.italicFont = italicFont;
		backgroundLocation = new Vector2((float)(dialogueTexture.Width - 1920) / 2f, 1080 - dialogueTexture.Height);
		optionBounds = new Vector2(75f, 625f);
		lineLocations = new Vector2[6]
		{
			new Vector2(75f, 720f),
			new Vector2(75f, 770f),
			new Vector2(75f, 820f),
			new Vector2(75f, 870f),
			new Vector2(75f, 920f),
			new Vector2(75f, 970f)
		};
		choiceOverlay = new ChoiceOverlay(game, buttonTexture, null, font);
		Speed = DialogueSpeed.Normal;
		CreateOverlay();
	}

	private void CreateOverlay()
	{
		desktop = new Desktop
		{
			Skin = Gui.GenerateStandardSkin(),
			Size = new Squid.Point(1920, 1080)
		};
		desktop.SetSkin("Assets/GUI/Squid/DefaultSkin");
		FlowLayoutFrame container = new FlowLayoutFrame
		{
			Position = new Squid.Point(1220, (int)optionBounds.Y + 10),
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
			game.ShowSave(desktop, delegate(bool toggle)
			{
				choiceOverlay.Touchable = toggle;
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
			game.ShowLoad(desktop, delegate(bool toggle)
			{
				choiceOverlay.Touchable = toggle;
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
			game.ShowExit(desktop, delegate(bool toggle)
			{
				choiceOverlay.Touchable = toggle;
			});
		};
		speedDropDown = new DropDownList();
		speedDropDown.Style = "button";
		speedDropDown.Size = new Squid.Point(120, 30);
		speedDropDown.DropdownAbove = true;
		speedDropDown.Label.TextAlign = Alignment.MiddleCenter;
		speedDropDown.Label.AutoEllipsis = false;
		speedDropDown.Dropdown.Resizable = false;
		speedDropDown.Button.Visible = false;
		speedDropDown.Listbox.Scrollbar.ButtonUp.Visible = false;
		speedDropDown.Listbox.Scrollbar.ButtonDown.Visible = false;
		foreach (DialogueSpeed speed in Enum.GetValues(typeof(DialogueSpeed)))
		{
			speedDropDown.Items.Add(new ListBoxItem
			{
				Text = speed.ToString(),
				Size = new Squid.Point(0, 30),
				Value = speed
			});
		}
		speedDropDown.SelectedItemChanged += delegate(Control container, ListBoxItem box)
		{
			Speed = (DialogueSpeed)box.Value;
			Options.Config.DialogueTextSpeed = dialogueSpeed;
		};
		autoskipBox = new CheckBox
		{
			Text = "Auto-skip",
			Size = new Squid.Point(140, 30),
			Checked = AutoSkip
		};
		autoskipBox.CheckedChanged += delegate
		{
			AutoSkip = autoskipBox.Checked;
			Options.Config.DialogueAutoSkip = autoskip;
		};
		container.Controls.Add(saveButton);
		container.Controls.Add(loadButton);
		container.Controls.Add(exitButton);
		container.Controls.Add(autoskipBox);
		container.Controls.Add(speedDropDown);
		desktop.Controls.Add(container);
	}

	private void UpdateSelectedSpeed()
	{
		if (singleton.speedDropDown != null)
		{
			singleton.speedDropDown.SelectedItem = singleton.speedDropDown.Items.First((ListBoxItem box) => (DialogueSpeed)box.Value == dialogueSpeed);
		}
	}

	private void UpdateCheckedAutoSkip()
	{
		if (singleton.autoskipBox != null)
		{
			singleton.autoskipBox.Checked = autoskip;
		}
	}

	public void Update(GameTime gameTime)
	{
		switch (overlayState)
		{
			case EState.None:
				return;
			case EState.Started:
				overlayState = EState.Visible;
				return;
		}
		choiceOverlay.Update(gameTime);
		if (game.Cutscene != null)
		{
			desktop.Update();
		}
		if (choiceOverlay.Touchable)
		{
			Interact(gameTime);
		}
	}

	private void Interact(GameTime gameTime)
	{
		if (phase == EPhase.Done)
		{
			if (game.Cutscene == null)
			{
				Reset();
			}
			return;
		}
		if ((phase == EPhase.Waiting || phase == EPhase.Typing || phase == EPhase.WaitForSkip) && IsPressedSkip())
		{
			SkipToNext();
			if (pendingPhase != 0)
			{
				phase = pendingPhase;
				pendingPhase = EPhase.None;
			}
			else if (!AutoSkip)
			{
				phase = EPhase.WaitForSkip;
				pendingPhase = EPhase.Skip;
			}
			else
			{
				ticks = speed.AutoSkipDelay;
				phase = EPhase.Waiting;
				pendingPhase = EPhase.Skip;
			}
		}
		switch (phase)
		{
			case EPhase.Started:
				if (speed.WhitespaceDelay != 0)
				{
					phase = EPhase.Typing;
					pendingPhase = EPhase.None;
				}
				else
				{
					SkipToNext();
					phase = EPhase.WaitForSkip;
					pendingPhase = EPhase.Skip;
				}
				break;
			case EPhase.Typing:
			{
				char c = dialogue.GetCharacter();
				if (dialogue.IsCompleted)
				{
					if (!AutoSkip)
					{
						phase = EPhase.WaitForSkip;
					}
					else
					{
						ticks = speed.AutoSkipDelay;
						phase = EPhase.Waiting;
					}
					pendingPhase = EPhase.Skip;
				}
				else
				{
					if (c != '░')
					{
						ticks = speed.WhitespaceDelay;
					}
					else
					{
						ticks = speed.CharacterDelay;
					}
					phase = EPhase.Waiting;
					pendingPhase = EPhase.Typing;
				}
				break;
			}
			case EPhase.Waiting:
				ticks -= gameTime.ElapsedGameTime.Milliseconds;
				if (ticks <= 0)
				{
					ticks = 0;
					phase = pendingPhase;
					pendingPhase = EPhase.None;
				}
				break;
			case EPhase.Skip:
				phase = EPhase.Done;
				pendingPhase = EPhase.None;
				break;
			case EPhase.WaitForSkip:
				break;
		}
	}

	private bool IsPressedSkip()
	{
		if (game.Controller.IsPressed(Microsoft.Xna.Framework.Input.Keys.Space))
		{
			return true;
		}
		if (game.Controller.IsPressed(ControllerButtonType.LeftButton))
		{
			Microsoft.Xna.Framework.Point cursor = game.Canvas.GlobalToContent(game.Controller.Cursor);
			if ((float)cursor.Y >= backgroundLocation.Y + 10f && cursor.Y <= 1080)
			{
				return true;
			}
		}
		return false;
	}

	private void TypeWithoutDelay(TypingOverlay dialogue)
	{
		this.dialogue = dialogue;
		this.dialogue.Begin(font, italicFont);
		this.dialogue.SkipToNext();
		overlayState = EState.Started;
		phase = EPhase.Started;
		pendingPhase = EPhase.None;
	}

	private void Type(TypingOverlay dialogue)
	{
		this.dialogue = dialogue;
		this.dialogue.Begin(font, italicFont);
		ticks = 150;
		overlayState = EState.Started;
		phase = EPhase.Started;
		pendingPhase = EPhase.None;
	}

	public void Draw(SpriteBatch spriteBatch)
	{
		if (overlayState == EState.None)
		{
			return;
		}
		choiceOverlay.Draw(spriteBatch);
		if (dialogue != null)
		{
			spriteBatch.Begin();
			spriteBatch.Draw(dialogueTexture, backgroundLocation, dialogue.Color);
			if (!string.IsNullOrEmpty(dialogue.Author))
			{
				spriteBatch.DrawString(font, dialogue.Author, optionBounds, dialogue.Color);
			}
			dialogue.Draw(spriteBatch, font, italicFont, lineLocations);
			spriteBatch.End();
			if (game.Cutscene != null)
			{
				desktop.Draw();
			}
		}
	}

	public void Reset()
	{
		dialogue = null;
		ticks = 0;
		overlayState = EState.None;
		phase = EPhase.None;
		pendingPhase = EPhase.None;
	}

	public static void TypeWithoutDelay(string message, string author, Color color)
	{
		singleton.TypeWithoutDelay(new TypingOverlay(message, author, color));
	}

	public static void Type(string message, string author, Color color)
	{
		singleton.Type(new TypingOverlay(message, author, color));
	}

	public static void SkipToNext()
	{
		if (singleton.dialogue != null)
		{
			singleton.dialogue.SkipToNext();
		}
	}

	public static void Choice(params string[] variants)
	{
		singleton.choiceOverlay.ShowChoice(variants);
	}

	public static void Unselect()
	{
		singleton.choiceOverlay.Select(0);
	}

	public static void Complete()
	{
		singleton.Reset();
	}
}
