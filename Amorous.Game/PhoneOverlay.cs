using System;
using System.Collections.Generic;
using System.Linq;
using Amorous.Engine.GUI;
using Amorous.Game.NPC;
using Amorous.Game.Scenes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Spine;
using Squid;

public class PhoneOverlay
{ // _poenyHBGUusBcnNcTFB9MQBV72R
	public enum ArmPose
	{
		ArmDown,
		ArmUp,
		ArmDownRequested,
		ArmUpRequested
	}

	public enum PhoneScreen
	{
		Home,
		Contacts,
		ContactsInformation,
		ContactsInformationDJ,
		Soundtrack,
		Diary,
		DiaryMessages,
		DiaryMessagesInformation,
		DiaryAchievements,
		DiarySave,
		DiaryLoad,
		Audio,
		ChatSettings,
		Gallery,
		Power
	}

	public enum PhoneIndicator
	{
		None,
		NoMessage,
		MessageNew,
		MessageIdle,
		MessageUrgent
	}

	private bool _phoneSomewhileOpened;
	private bool _inPendingLoading;

	private readonly Dictionary<PlayerData.EPhoneContacts, Squid.Rectangle> _contactBounds = new Dictionary<PlayerData.EPhoneContacts, Squid.Rectangle>
	{
		{
			PlayerData.EPhoneContacts.Coby,
			new Squid.Rectangle(275, 189, 268, 158)
		},
		{
			PlayerData.EPhoneContacts.Dustin,
			new Squid.Rectangle(547, 351, 268, 158)
		},
		{
			PlayerData.EPhoneContacts.Jax,
			new Squid.Rectangle(819, 189, 268, 158)
		},
		{
			PlayerData.EPhoneContacts.Lex,
			new Squid.Rectangle(275, 351, 268, 158)
		},
		{
			PlayerData.EPhoneContacts.Mercy,
			new Squid.Rectangle(1091, 351, 268, 158)
		},
		{
			PlayerData.EPhoneContacts.Remy,
			new Squid.Rectangle(1091, 189, 268, 158)
		},
		{
			PlayerData.EPhoneContacts.Seth,
			new Squid.Rectangle(1363, 351, 268, 158)
		},
		{
			PlayerData.EPhoneContacts.Skye,
			new Squid.Rectangle(1363, 189, 268, 158)
		},
		{
			PlayerData.EPhoneContacts.Zenith,
			new Squid.Rectangle(1635, 189, 268, 158)
		}
	};

	private readonly Dictionary<PlayerData.EPhoneContacts, string> _contactSexscenes = new Dictionary<PlayerData.EPhoneContacts, string>
	{
		{
			PlayerData.EPhoneContacts.Coby,
			AmorousData.CobySexscene
		},
		{
			PlayerData.EPhoneContacts.Dustin,
			"DustinSexscene"
		},
		{
			PlayerData.EPhoneContacts.Jax,
			"JaxSexscene"
		},
		{
			PlayerData.EPhoneContacts.Lex,
			"LexSexscene"
		},
		{
			PlayerData.EPhoneContacts.Mercy,
			"MercySexscene"
		},
		{
			PlayerData.EPhoneContacts.Remy,
			"RemySexscene"
		},
		{
			PlayerData.EPhoneContacts.Seth,
			"SethSexscene"
		},
		{
			PlayerData.EPhoneContacts.Skye,
			"SkyeSexscene"
		},
		{
			PlayerData.EPhoneContacts.Zenith,
			"ZenithSexscene"
		}
	};

	private PlayerData.EPhoneContacts _selectedContact;
	private PhoneMessage _selectedMessage;
	private readonly string[] _dialogueDJ = new string[5] { "That song is awesome!", "This one is so underrated!", "Haven't heard that one in a while!", "Always gives me goosebumbs!", "The beat in this one is just amazing!" };
	private static PhoneOverlay _singleton;
	private readonly IAmorous _game;
	private readonly SpineRenderer _interactionSpine;
	private readonly SpineRenderer _phoneOverlaySpine;
	private readonly SpineRenderer _phoneActionSpine;

	private readonly Dictionary<string, bool> _visibleContactParts = new Dictionary<string, bool>
	{
		{ "Alex", false },
		{ "Alex image", false },
		{ "Coby", false },
		{ "Coby image", false },
		{ "Dustin", false },
		{ "Dustin image", false },
		{ "Gen", false },
		{ "Gen image", false },
		{ "Jacky", false },
		{ "Jacky image", false },
		{ "Jax", false },
		{ "Jax image", false },
		{ "Mercy", false },
		{ "Mercy image", false },
		{ "Remy", false },
		{ "Remy image", false },
		{ "Seth", false },
		{ "Seth image", false },
		{ "Skye", false },
		{ "Skye image", false },
		{ "Verge", false },
		{ "Verge image", false },
		{ "Zenith", false },
		{ "Zenith image", false }
	};

	private readonly Dictionary<string, bool> _visibleActionParts = new Dictionary<string, bool>
	{
		{ "reject call with message", true },
		{ "Incoming call", true }
	};

	private PhoneIndicator _indicator;
	private bool _isChangingState, _requestedRise, _requestedHang;

	private static readonly string[] GameboxSprites = new string[6] { "Marlboro", "Angry Curds", "God of Warfare Modern War", "Inanimate 3", "The Blinding of Blissac", "Traffic Controller" };
	private static readonly string[] RemyNudes = new string[4] { "Nude1", "Nude2", "Nude3", "Nude4" };
	private static readonly string[] PlayerNails = new string[4] { "Pinky Nail", "Ring Nail", "Rude Nail", "Index Nail" };

	private readonly Desktop _squid;
	private readonly RenderTarget2D _phoneScreenTarget, _phoneActionTarget;
	private Texture2D _spriteActiveGamebox, _spriteActiveRemyNude;
	private bool _blocked;
	private bool _hiddenPhoneScreen, _hiddenPhoneAction;
	private bool _hiddenGameBox, _hiddenRemyNudes;
	private int _currentlyGame, _currentlyNude;
	private static PhoneScreen _screen;
	private static Stack<PhoneScreen> _screenHistory;
	private static bool _enabled;

	private const float RiseDownDuration = 1000f;
	private const float RiseUpDuration = 5000f;

	private bool _interactable;
	private float _duration = 1f;
	private bool _closeableOutside;

	public ArmPose Pose { get; private set; }

	public static bool Enabled
	{
		get
		{
			return _enabled;
		}
		set
		{
			_enabled = value;
			if (!_enabled)
			{
				Indicator = PhoneIndicator.None;
			}
			else
			{
				Indicator = PhoneIndicator.NoMessage;
			}
		}
	}

	public static PhoneIndicator Indicator
	{
		get
		{
			return _singleton._indicator;
		}
		set
		{
			if (value != _singleton._indicator)
			{
				_singleton._indicator = value;
				switch (value)
				{
					case PhoneIndicator.NoMessage:
						_singleton._phoneOverlaySpine.StartAnimationWithLooping("No message");
						_singleton.RefreshPhoneSkin();
						break;
					case PhoneIndicator.MessageNew:
						_singleton._phoneOverlaySpine.StartAnimationWithLooping("Message new");
						break;
					case PhoneIndicator.MessageIdle:
						_singleton._phoneOverlaySpine.StartAnimationWithLooping("Message idle");
						break;
					case PhoneIndicator.MessageUrgent:
						_singleton._phoneOverlaySpine.StartAnimationWithLooping("Urgent message");
						break;
				}
			}
		}
	}

	public PhoneOverlay(IAmorous game, ContentManager content)
	{
		_singleton = this;
		_game = game;
		_interactionSpine = content.LoadSkeleton("Assets/GUI/Phone/Phone");
		_interactionSpine.ApplyFrame("Arm rise", 0f);
		_interactionSpine.SetVisibility(0f);
		_interactionSpine.X = 0f;
		_interactionSpine.Y = 1200f;
		_phoneOverlaySpine = content.LoadSkeleton("Assets/GUI/Phone/PhoneHUD", 0.5f);
		_phoneOverlaySpine.StartAnimationWithLooping("No message");
		_phoneOverlaySpine.X = 1845f;
		_phoneOverlaySpine.Y = 1060f;
		_phoneActionSpine = content.LoadSkeleton("Assets/GUI/Phone/PhoneScreen");
		_phoneActionSpine.X = 135f;
		_phoneActionSpine.Y = 190f;
		_hiddenPhoneAction = true;
		RefreshSkin();
		_squid = new Desktop
		{
			Skin = Gui.GenerateStandardSkin(),
			Size = new Squid.Point(270, 380)
		};
		_squid.SetSkin("Assets/GUI/Squid/DefaultSkin");
		_squid.ModalColor = ColorInt.ARGB(0.9f, 0f, 0f, 0f);
		_squid.MouseTransformFunc = delegate(Squid.Point point_0)
		{
			double depth;
			Microsoft.Xna.Framework.Point sheen = _interactionSpine.GetDistanceDepth("Sheen Two", out depth);
			Matrix matrix = Matrix.CreateTranslation(-sheen.X, -sheen.Y, 0f) * Matrix.CreateRotationZ((float)(-depth));
			Vector2 vector = Vector2.Transform(new Vector2(point_0.x, point_0.y), matrix);
			return new Squid.Point((int)vector.X, (int)vector.Y);
		};
		_phoneScreenTarget = new RenderTarget2D(_game.Graphics, 270, 380);
		_phoneActionTarget = new RenderTarget2D(_game.Graphics, 270, 380);
		_screenHistory = new Stack<PhoneScreen>();
		_hiddenGameBox = true;
		_hiddenRemyNudes = true;
	}

	public void AcceptCall(PlayerData.EPhoneContacts contact)
	{
		ShowContact(contact);
		_phoneActionSpine.RestartAnimation();
		_phoneActionSpine.StartAnimation("Phone answer start", delegate
		{
			_phoneActionSpine.StartAnimationWithLooping("Phone answer loop");
		});
		StartSwipeAnimation();
	}

	public void AcceptIM(PlayerData.EPhoneContacts contact)
	{
		ShowContact(contact);
		_phoneActionSpine.StartAnimation("Phone IM accept", delegate
		{
			_phoneActionSpine.StartAnimationWithLooping("Phone IM idle");
		});
		StartSwipeAnimation();
	}

	public void DeclineCall(PlayerData.EPhoneContacts contact)
	{
		_hiddenPhoneAction = true;
		StartSwipeAnimation();
	}

	public void DeclineIM(PlayerData.EPhoneContacts contact)
	{
		_hiddenPhoneAction = true;
		StartSwipeAnimation();
	}

	public void IncomingCall(PlayerData.EPhoneContacts contact)
	{
		ShowContact(contact);
		ApplyCallingScreen(state: true);
		_phoneActionSpine.RestartAnimation();
		_phoneActionSpine.StartAnimation("Phone Call start", delegate
		{
			_phoneActionSpine.StartAnimationWithLooping("Phone Call loop");
		});
		StartSwipeAnimation();
	}

	public void IncomingIM(PlayerData.EPhoneContacts contact)
	{
		OpenCallingScreen(contact);
	}

	public void OpenIM(PlayerData.EPhoneContacts contact)
	{
		ShowContact(contact);
		_phoneActionSpine.StartAnimationWithLooping("Phone IM idle");
		StartSwipeAnimation();
	}

	public void OutgoingCall(PlayerData.EPhoneContacts contact)
	{
		OpenCallingScreen(contact);
	}

	public void OutgoingIM(PlayerData.EPhoneContacts contact)
	{
		OpenCallingScreen(contact);
	}

	public void TypeIM(PlayerData.EPhoneContacts contact)
	{
		ShowContact(contact);
		_phoneActionSpine.StartAnimation("Phone IM messaging loop", delegate
		{
			_phoneActionSpine.StartAnimationWithLooping("Phone IM idle");
		});
		StartTypingAnimation();
	}

	private void OpenCallingScreen(PlayerData.EPhoneContacts contact)
	{
		ShowContact(contact);
		ApplyCallingScreen(state: false);
		_phoneActionSpine.RestartAnimation();
		_phoneActionSpine.StartAnimation("Phone Call start", delegate
		{
			_phoneActionSpine.StartAnimationWithLooping("Phone Call loop");
		});
		StartSwipeAnimation();
	}

	public void ShowGameBox()
	{
		_hiddenGameBox = false;
		_spriteActiveGamebox = _game.Content.Load<Texture2D>("Assets/GUI/Phone/Gameboxes/" + GameboxSprites[_currentlyGame]);
		_currentlyGame++;
		if (_currentlyGame >= GameboxSprites.Length)
		{
			_currentlyGame = 0;
		}
	}

	public void HideGameBox()
	{
		_hiddenGameBox = true;
		_currentlyGame = 0;
	}

	public void UpdateRemyNudes()
	{
		_hiddenRemyNudes = false;
		_spriteActiveRemyNude = _game.Content.Load<Texture2D>("Assets/GUI/Phone/Gallery/Remy/" + RemyNudes[_currentlyNude]);
		_currentlyNude++;
		if (_currentlyNude >= RemyNudes.Length)
		{
			_currentlyNude = 0;
		}
		StartSwipeAnimation();
	}

	public void UpdateRemyNudes(int index)
	{
		_hiddenRemyNudes = false;
		_spriteActiveRemyNude = _game.Content.Load<Texture2D>("Assets/GUI/Phone/Gallery/Remy/" + RemyNudes[index]);
		StartSwipeAnimation();
	}

	public void HideRemyNudes()
	{
		_hiddenRemyNudes = true;
		_currentlyNude = 0;
		StartSwipeAnimation();
	}

	public void HideActions()
	{
		_hiddenPhoneAction = true;
	}

	public void ResetState()
	{
		_hiddenPhoneAction = true;
		_hiddenGameBox = true;
		_currentlyGame = 0;
		_hiddenRemyNudes = true;
		_currentlyNude = 0;
	}

	public static void Rise()
	{
		if (_singleton._game.Cutscene == null && !_singleton._isChangingState)
		{
			if (_singleton.Pose == ArmPose.ArmUp)
			{
				Hide();
			}
			else
			{
				Show();
			}
		}
	}

	public static void Show(bool preserveHiding = false)
	{
		if (Enabled)
		{
			if (!_singleton._phoneSomewhileOpened)
			{
				_singleton._phoneSomewhileOpened = true;
				_singleton._game.Achievements.TriggerAchievement(Achievements.AchievementGeneric5);
			}
			_singleton._game.Canvas.Captured = true;
			AbstractScene.CapturedByOverlay = true;
			_singleton._blocked = preserveHiding;
			if (!_singleton._isChangingState && _singleton.Pose == ArmPose.ArmDown)
			{
				_singleton.Pose = ArmPose.ArmUpRequested;
				_singleton._requestedRise = true;
				_screenHistory.Clear();
				OpenScreen(PhoneScreen.Home);
			}
		}
	}

	public static void Hide()
	{
		if (Enabled && !_singleton._inPendingLoading)
		{
			_singleton._game.Canvas.Captured = false;
			AbstractScene.CapturedByOverlay = false;
			_singleton._blocked = false;
			if (!_singleton._isChangingState && _singleton.Pose == ArmPose.ArmUp)
			{
				_singleton.Pose = ArmPose.ArmDownRequested;
				_singleton._requestedHang = true;
			}
		}
	}

	public static void OpenScreen(PhoneScreen screen)
	{
		if (screen != 0)
		{
			_screenHistory.Push(_screen);
			_singleton.StartSwipeAnimation();
		}
		_screen = screen;
		_singleton.ReattachScreen();
	}

	public static void Swipe(PhoneScreen screen)
	{
		_singleton.StartSwipeAnimation();
		_singleton.ReattachScreen();
	}

	public static void Back()
	{
		_screen = _screenHistory.Pop();
		_singleton.ReattachScreen();
		_singleton.StartSwipeAnimation();
	}

	private void StartSwipeAnimation()
	{
		_interactable = false;
		_singleton._interactionSpine.StartAnimation("Swipe", StartHoldingAnimation);
	}

	private void StartTypingAnimation()
	{
		_interactable = false;
		_singleton._interactionSpine.StartAnimation("Typing", StartHoldingAnimation);
	}

	private void StartHoldingAnimation()
	{
		_singleton._interactionSpine.StartAnimationWithLooping("Idle");
		_interactable = true;
	}

	private void ReattachScreen()
	{
		Control container;
		switch (_screen)
		{
			default:
				_hiddenPhoneScreen = true;
				return;
			case PhoneScreen.Contacts:
				container = CreateContactsScreen();
				break;
			case PhoneScreen.ContactsInformation:
				container = CreateContactsInformationScreen();
				break;
			case PhoneScreen.ContactsInformationDJ:
				container = CreateContactsInformationDJScreen();
				break;
			case PhoneScreen.Soundtrack:
				container = CreateSoundtrackScreen();
				break;
			case PhoneScreen.Diary:
				container = CreateDiaryScreen();
				break;
			case PhoneScreen.DiaryMessages:
				container = CreateDiaryMessagesScreen();
				break;
			case PhoneScreen.DiaryMessagesInformation:
				container = CreateDiaryMessagesInformationScreen();
				break;
			case PhoneScreen.DiaryAchievements:
				container = CreateDiaryAchievementsScreen();
				break;
			case PhoneScreen.DiarySave:
				container = CreateDiarySaveScreen();
				break;
			case PhoneScreen.DiaryLoad:
				container = CreateDiaryLoadScreen();
				break;
			case PhoneScreen.Audio:
				container = CreateAudioScreen();
				break;
			case PhoneScreen.ChatSettings:
				container = CreateChatSettingsScreen();
				break;
			case PhoneScreen.Gallery:
				container = CreateGalleryScreen();
				break;
			case PhoneScreen.Power:
				container = CreatePowerScreen();
				break;
		}
		_hiddenPhoneScreen = false;
		_squid.Controls.Clear();
		_squid.Controls.Add(container);
	}

	private ListBox CreateApplicationListBox()
	{
		ListBox container = new ListBox();
		container.Dock = DockStyle.Fill;
		container.Scrollbar.MouseScrollSpeed = 0.2f;
		container.Scrollbar.ButtonUp.Visible = false;
		container.Scrollbar.ButtonDown.Visible = false;
		return container;
	}

	private ListBox CreateContactsScreen()
	{
		ListBox container = CreateApplicationListBox();
		PlayerData data = PlayerPreferences.GetPlayerData();
		if (data.GetState(AmorousData.DJ) == AmorousData.UnlockedContactDJ)
		{
			float width = 189.6f;
			float x = (268f - width) / 2f;
			ImageControl contactImage = new ImageControl
			{
				Dock = DockStyle.Left,
				Texture = "Contact_DJ",
				TextureRect = new Squid.Rectangle((int)x, 0, (int)width, 158),
				Size = new Squid.Point(60, 50),
				NoEvents = true
			};
			Label contactLabel = new Label
			{
				Dock = DockStyle.Fill,
				Text = ClubDJNPC.Name,
				TextAlign = Alignment.MiddleCenter,
				NoEvents = true
			};
			CustomListBoxItem contactContainer = new CustomListBoxItem
			{
				Size = new Squid.Point(0, 60),
				Padding = new Margin(2)
			};
			contactContainer.MouseClick += delegate
			{
				OpenScreen(PhoneScreen.ContactsInformationDJ);
			};
			contactContainer.Controls.Add(contactImage);
			contactContainer.Controls.Add(contactLabel);
			container.ItemContainer.Controls.Add(contactContainer);
		}
		List<string> contactNames = Enum.GetNames(typeof(PlayerData.EPhoneContacts)).Except(new string[1] { "None" }).ToList();
		PlayerData.EPhoneContacts _contact;
		Tuple<string, PlayerData.EPhoneContacts>[] contacts = (from name in contactNames
			select Enum.TryParse<PlayerData.EPhoneContacts>(name, out _contact) ? (
				(!data.Contacts.HasFlag(_contact)) ? null : new Tuple<string, PlayerData.EPhoneContacts>(name, _contact)
			) : null into tuple
			where tuple != null
			orderby tuple.Item1
			select tuple).ToArray();
		foreach (Tuple<string, PlayerData.EPhoneContacts> contact in contacts)
		{
			Squid.Rectangle bounds = _contactBounds[contact.Item2];
			float width = (float)bounds.Height * 1.2f;
			float x = ((float)bounds.Width - width) / 2f;
			ImageControl contactImage = new ImageControl
			{
				Dock = DockStyle.Left,
				Texture = "PhoneScreen",
				TextureRect = new Squid.Rectangle(bounds.Left + (int)x, bounds.Top, (int)width, bounds.Height),
				Size = new Squid.Point(60, 50),
				NoEvents = true
			};
			Label contactLabel = new Label
			{
				Dock = DockStyle.Fill,
				Text = contact.Item1,
				TextAlign = Alignment.MiddleCenter,
				NoEvents = true
			};
			CustomListBoxItem contactContainer = new CustomListBoxItem
			{
				Size = new Squid.Point(0, 60),
				Padding = new Margin(2),
				Value = contact.Item2
			};
			contactContainer.MouseClick += delegate
			{
				_selectedContact = (PlayerData.EPhoneContacts)contactContainer.Value;
				OpenScreen(PhoneScreen.ContactsInformation);
			};
			contactContainer.Controls.Add(contactImage);
			contactContainer.Controls.Add(contactLabel);
			container.ItemContainer.Controls.Add(contactContainer);
		}
		return container;
	}

	private Control CreateContactsInformationScreen()
	{
		Panel container = new Panel
		{
			Dock = DockStyle.Fill
		};
		PlayerData data = PlayerPreferences.GetPlayerData();
		Label contactLabel = new Label
		{
			Dock = DockStyle.Top,
			Text = _selectedContact.ToString(),
			Style = "button",
			Size = new Squid.Point(0, 40),
			NoEvents = true
		};
		ImageControl contactImage = new CustomImageControl
		{
			Dock = DockStyle.Top,
			Texture = "PhoneScreen",
			TextureRect = _contactBounds[_selectedContact]
		};
		container.Content.Controls.Add(contactLabel);
		container.Content.Controls.Add(contactImage);
		Button resetButton = new Button
		{
			Dock = DockStyle.Top,
			Text = "Delete contact",
			Size = new Squid.Point(0, 50)
		};
		resetButton.MouseClick += delegate
		{
			_blocked = true;
			_squid.ShowSelection($"Are you sure you wish to remove {_selectedContact}? This will reset all progression!", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, AmorousData.WideDialogueOffset, delegate(int answer)
			{
				if (answer == 1)
				{
					PlayerPreferences.GetPlayerData().DisableContact(_selectedContact);
					_squid.ShowConfirm($"{_selectedContact} will be available again after you went home.", AmorousData.WideDialogueOffset, "OK", delegate
					{
						Back();
						_blocked = false;
					});
				}
				else
				{
					Back();
					_blocked = false;
				}
			});
		};
		container.Content.Controls.Add(resetButton);
		Button callButton = new Button
		{
			Dock = DockStyle.Top,
			Text = "Call",
			Size = new Squid.Point(0, 50)
		};
		callButton.MouseClick += delegate
		{
			string scene = _game.Scene.GetType().Name;
			string sexscene = _game.Sexscene?.GetType().Name;
			if (scene == AmorousData.PlayerSexScene && sexscene == _contactSexscenes[_selectedContact])
			{
				TypingDialogue.Type("<i>" + _selectedContact.ToString() + " is kind of... preoccupied right now.</i>", "%playername%", Color.White);
			}
			else if (scene != AmorousData.BedroomScene && scene != AmorousData.LivingRoomScene)
			{
				TypingDialogue.Type("<i>Reception is really bad at the moment, I should try again when I'm back at home.</i>", "%playername%", Color.White);
			}
			else
			{
				RequestContactCall(_selectedContact);
			}
		};
		container.Content.Controls.Add(callButton);
		if (_selectedContact == PlayerData.EPhoneContacts.Zenith && data.GetState(AmorousData.ZenithDate) > 20)
		{
			Button shootingRangeButton = new Button
			{
				Dock = DockStyle.Top,
				Text = "Extra: Shooting Range",
				Size = new Squid.Point(0, 50)
			};
			shootingRangeButton.MouseClick += delegate
			{
				Hide();
				_game.StartScene<PhoneShootingRangeMiniGameScene>();
			};
			container.Content.Controls.Add(shootingRangeButton);
		}
		if (_selectedContact == PlayerData.EPhoneContacts.Remy && data.GetState(AmorousData.RemyDate) > 20)
		{
			Button cookingButton = new Button
			{
				Dock = DockStyle.Top,
				Text = "Extra: Cooking Mini-Game",
				Size = new Squid.Point(0, 50)
			};
			cookingButton.MouseClick += delegate
			{
				_game.PlayCutscene(AmorousData.MiniGameCooking);
				Hide();
			};
			container.Content.Controls.Add(cookingButton);
		}
		if (!Censorship.Censored && _selectedContact == PlayerData.EPhoneContacts.Remy && data.GetState(AmorousData.RemyDate) > 30)
		{
			Button remyNudesButton = new Button
			{
				Dock = DockStyle.Top,
				Text = "Extra: Nude pictures",
				Size = new Squid.Point(0, 50)
			};
			remyNudesButton.MouseClick += delegate
			{
				_game.PlayCutscene(AmorousData.NudesRemy);
				Hide();
			};
			container.Content.Controls.Add(remyNudesButton);
		}
		string sexscene = null;
		if (_selectedContact == PlayerData.EPhoneContacts.Coby && data.GetState(AmorousData.CobyDate) == AmorousData.CobyStateCompleted)
		{
			sexscene = AmorousData.CobySexscene;
		}
		else if (_selectedContact == PlayerData.EPhoneContacts.Dustin && data.GetState(AmorousData.DustinDate) == AmorousData.DustinStateCompleted)
		{
			sexscene = AmorousData.DustinPostDate;
		}
		else if (_selectedContact != PlayerData.EPhoneContacts.Jax || data.GetState(AmorousData.JaxDate) != AmorousData.JaxStateCompleted)
		{
			if (_selectedContact != PlayerData.EPhoneContacts.Lex || data.GetState(AmorousData.LexDate) != AmorousData.LexStateCompleted)
			{
				if (_selectedContact == PlayerData.EPhoneContacts.Mercy && data.GetState(AmorousData.MercyDate) == AmorousData.MercyStateCompleted)
				{
					sexscene = AmorousData.MercyPostDate;
				}
				else if (_selectedContact != PlayerData.EPhoneContacts.Remy || data.GetState(AmorousData.RemyDate) != AmorousData.RemyStateCompleted)
				{
					if (_selectedContact != PlayerData.EPhoneContacts.Seth || data.GetState(AmorousData.SethDate) != AmorousData.SethStateCompleted)
					{
						if (_selectedContact == PlayerData.EPhoneContacts.Skye && data.GetState(AmorousData.SkyeDate) == AmorousData.SkyeStateCompleted)
						{
							sexscene = AmorousData.SkyePostDate;
						}
						else if (_selectedContact == PlayerData.EPhoneContacts.Zenith && data.GetState(AmorousData.ZenithDate) == AmorousData.ZenithStateCompleted)
						{
							sexscene = AmorousData.ZenithPostDate;
						}
					}
					else
					{
						sexscene = AmorousData.SethPostDate;
					}
				}
				else
				{
					sexscene = AmorousData.RemyPostDate;
				}
			}
			else
			{
				sexscene = AmorousData.LexPostDate;
			}
		}
		else
		{
			sexscene = AmorousData.JaxPostDate;
		}
		if (sexscene != null)
		{
			Button sexsceneButton = new Button
			{
				Dock = DockStyle.Top,
				Text = (Censorship.Censored ? "Extra: Love scene" : "Extra: Sexscene"),
				Size = new Squid.Point(0, 50)
			};
			sexsceneButton.MouseClick += delegate
			{
				RequestSexscene(sexscene);
			};
			container.Content.Controls.Add(sexsceneButton);
		}
		return container;
	}

	private Control CreateContactsInformationDJScreen()
	{
		Panel container = new Panel
		{
			Dock = DockStyle.Fill
		};
		Label contactLabel = new Label
		{
			Dock = DockStyle.Top,
			Text = ClubDJNPC.Name,
			Style = "button",
			Size = new Squid.Point(0, 40),
			NoEvents = true
		};
		ImageControl contactImage = new CustomImageControl
		{
			Dock = DockStyle.Top,
			Texture = "Contact_DJ",
			TextureRect = new Squid.Rectangle(0, 0, 268, 158)
		};
		Button requestButton = new Button
		{
			Dock = DockStyle.Top,
			Text = "Request a song",
			Size = new Squid.Point(0, 50)
		};
		requestButton.MouseClick += delegate
		{
			string scene = _game.Scene.GetType().Name;
			if (scene.StartsWith("Club"))
			{
				OpenScreen(PhoneScreen.Soundtrack);
			}
			else
			{
				TypingDialogue.Type("<i>Hmm, the operator is telling me: 'The number you are trying to reach is currently unavailable'. I guess the DJ only has his phone enabled during Club hours.</i>", "%playername%", Color.White);
			}
		};
		container.Content.Controls.Add(contactLabel);
		container.Content.Controls.Add(contactImage);
		container.Content.Controls.Add(requestButton);
		return container;
	}

	private ListBox CreateSoundtrackScreen()
	{
		ListBox container = CreateApplicationListBox();
		List<AmorousData.Soundtrack> soundtracks = AmorousData.Soundtracks.OrderBy((AmorousData.Soundtrack _vNekDVpW2fr7UkjA16E9ifFmD9s_0) => _vNekDVpW2fr7UkjA16E9ifFmD9s_0.Title).ToList();
		foreach (AmorousData.Soundtrack soundtrack in soundtracks)
		{
			CustomListBoxItem soundtrackContainer = new CustomListBoxItem
			{
				Size = new Squid.Point(0, 90)
			};
			Label soundtrackTitleLabel = new Label
			{
				Dock = DockStyle.Top,
				Size = new Squid.Point(0, 50),
				Text = "\"" + soundtrack.Title + "\"",
				TextAlign = Alignment.MiddleCenter,
				TextColor = ColorInt.RGB(255, 255, 0),
				TextWrap = true,
				UseTextColor = true,
				NoEvents = true
			};
			Label soundtrackArtistLabel = new Label
			{
				Dock = DockStyle.Top,
				Size = new Squid.Point(0, 40),
				Text = "by " + soundtrack.Artist,
				TextAlign = Alignment.MiddleCenter,
				NoEvents = true
			};
			soundtrackContainer.Controls.Add(soundtrackTitleLabel);
			soundtrackContainer.Controls.Add(soundtrackArtistLabel);
			soundtrackContainer.MouseClick += delegate
			{
				int dialogue = Utils.Random(0, _dialogueDJ.Length);
				TypingDialogue.Type(_dialogueDJ[dialogue], ClubDJNPC.Name, ClubDJNPC.Color);
				FadingMediaPlayer.Play(soundtrack.AssetName, 0.3f, repeat: false);
				_game.Achievements.TriggerAchievement(Achievements.AchievementGeneric3);
			};
			container.ItemContainer.Controls.Add(soundtrackContainer);
		}
		return container;
	}

	private ListBox CreateDiaryScreen()
	{
		ListBox container = CreateApplicationListBox();
		ListBoxItem messagesBox = new ListBoxItem
		{
			Text = "Messages",
			Size = new Squid.Point(0, 50)
		};
		messagesBox.MouseClick += delegate
		{
			OpenScreen(PhoneScreen.DiaryMessages);
		};
		ListBoxItem achievementsBox = new ListBoxItem
		{
			Text = "Achievements",
			Size = new Squid.Point(0, 50)
		};
		achievementsBox.MouseClick += delegate
		{
			OpenScreen(PhoneScreen.DiaryAchievements);
		};
		ListBoxItem saveBox = new ListBoxItem
		{
			Text = "Save",
			Size = new Squid.Point(0, 50)
		};
		saveBox.MouseClick += delegate
		{
			OpenScreen(PhoneScreen.DiarySave);
		};
		ListBoxItem loadBox = new ListBoxItem
		{
			Text = "Load",
			Size = new Squid.Point(0, 50)
		};
		loadBox.MouseClick += delegate
		{
			OpenScreen(PhoneScreen.DiaryLoad);
		};
		container.Items.Add(messagesBox);
		if (_game.Achievements.IsSteamSupported)
		{
			ListBoxItem steamAchievementsBox = new ListBoxItem
			{
				Text = "Steam Achievements",
				Size = new Squid.Point(0, 50)
			};
			steamAchievementsBox.MouseClick += delegate
			{
				_game.Achievements.OpenAchievements();
			};
			container.Items.Add(steamAchievementsBox);
		}
		container.Items.Add(achievementsBox);
		container.Items.Add(saveBox);
		container.Items.Add(loadBox);
		return container;
	}

	private ListBox CreateDiaryMessagesScreen()
	{
		ListBox container = CreateApplicationListBox();
		PlayerData data = PlayerPreferences.GetPlayerData();
		if (data.Messages.Count != 0)
		{
			foreach (PhoneMessage message in data.Messages.OrderByDescending((PhoneMessage message) => message.Date))
			{
				ImageControl messageImage = new ImageControl
				{
					Dock = DockStyle.Left,
					Texture = message.Icon,
					Size = new Squid.Point(60, 50),
					NoEvents = true
				};
				Label messageLabel = new Label
				{
					Dock = DockStyle.Fill,
					Text = message.Title + "\r\n" + message.Date.ToShortDateString(),
					TextAlign = Alignment.MiddleLeft,
					Margin = new Margin(10, 0, 10, 0),
					AutoEllipsis = true,
					TextWrap = true,
					NoEvents = true
				};
				CustomListBoxItem messageContainer = new CustomListBoxItem
				{
					Size = new Squid.Point(0, 60),
					Padding = new Margin(2)
				};
				messageContainer.MouseClick += delegate
				{
					_selectedMessage = message;
					OpenScreen(PhoneScreen.DiaryMessagesInformation);
				};
				messageContainer.Controls.Add(messageImage);
				messageContainer.Controls.Add(messageLabel);
				container.ItemContainer.Controls.Add(messageContainer);
			}
			return container;
		}
		ListBoxItem noMessagesBox = new ListBoxItem
		{
			Text = "There are no messages yet!",
			Size = new Squid.Point(0, 50)
		};
		container.Items.Add(noMessagesBox);
		return container;
	}

	private ListBox CreateDiaryAchievementsScreen()
	{
		ListBox container = CreateApplicationListBox();
		PlayerData data = PlayerPreferences.GetPlayerData();
		foreach (Achievements.AchievementData achievement in Achievements.Achievables)
		{
			ImageControl achievementImage = new ImageControl
			{
				Dock = DockStyle.Left,
				Texture = achievement.Icon,
				Size = new Squid.Point(60, 50)
			};
			Label achievementLabel = new Label
			{
				Dock = DockStyle.Fill,
				Text = achievement.Title,
				TextAlign = Alignment.MiddleLeft,
				Margin = new Margin(10, 0, 10, 0),
				AutoEllipsis = true,
				TextWrap = true
			};
			CustomListBoxItem achievementContainer = new CustomListBoxItem
			{
				Size = new Squid.Point(0, 60),
				Padding = new Margin(2),
				NoEvents = true,
				Opacity = (data.GetFlag(achievement.Key) ? 1f : 0.5f)
			};
			achievementContainer.Controls.Add(achievementImage);
			achievementContainer.Controls.Add(achievementLabel);
			container.ItemContainer.Controls.Add(achievementContainer);
		}
		return container;
	}

	private Panel CreateDiaryMessagesInformationScreen()
	{
		Panel container = new Panel
		{
			Dock = DockStyle.Fill
		};
		ImageControl messageImage = new ImageControl
		{
			Dock = DockStyle.Left,
			Texture = _selectedMessage.Icon,
			Size = new Squid.Point(60, 50)
		};
		Label messageTitleLabel = new Label
		{
			Dock = DockStyle.Fill,
			Text = _selectedMessage.Title + "\r\n" + _selectedMessage.Date.ToShortDateString(),
			TextAlign = Alignment.MiddleLeft,
			Margin = new Margin(10, 0, 10, 0),
			AutoEllipsis = true,
			TextWrap = true
		};
		Panel controlPanel = new Panel
		{
			Dock = DockStyle.Top,
			Size = new Squid.Point(0, 60),
			Padding = new Margin(2),
			Style = "button",
			NoEvents = true
		};
		controlPanel.Content.Controls.Add(messageImage);
		controlPanel.Content.Controls.Add(messageTitleLabel);
		Label messageLabel = new Label
		{
			Dock = DockStyle.Top,
			Text = _selectedMessage.Message,
			Margin = new Margin(10),
			TextAlign = Alignment.MiddleCenter,
			AutoSize = AutoSize.Vertical,
			TextWrap = true,
			NoEvents = true
		};
		Button removeButton = new Button
		{
			Dock = DockStyle.Top,
			Text = "Delete message",
			Size = new Squid.Point(0, 50)
		};
		removeButton.MouseClick += delegate
		{
			_blocked = true;
			_squid.ShowSelection("Are you sure you wish to remove this message?", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, AmorousData.WideDialogueOffset, delegate(int answer)
			{
				if (answer == 1)
				{
					PlayerData data = PlayerPreferences.GetPlayerData();
					data.Messages.Remove(_selectedMessage);
					_selectedMessage = null;
					Back();
				}
				_blocked = false;
			});
		};
		container.Content.Controls.Add(controlPanel);
		container.Content.Controls.Add(messageLabel);
		container.Content.Controls.Add(removeButton);
		return container;
	}

	private ListBox CreateDiarySaveScreen()
	{
		ListBox container = CreateApplicationListBox();
		List<Saves.Pointer> pointers = Saves.GetPointers(excludeAutosaves: true);
		foreach (Saves.Pointer pointer in pointers)
		{
			int separator = pointer.Name.IndexOf('-');
			string name = pointer.Name.Substring(0, separator).Trim();
			string date = pointer.Name.Substring(separator + 1).Trim();
			ListBoxItem optionBox = new ListBoxItem
			{
				Text = name + "\r\n" + date,
				Size = new Squid.Point(0, 50)
			};
			optionBox.MouseClick += delegate
			{
				if (pointer.IsEmpty)
				{
					_game.SaveAtSlot(pointer.Index);
					_singleton.ReattachScreen();
				}
				else
				{
					_blocked = true;
					_squid.ShowSelection($"Are you sure you wish to overwrite slot #{pointer.Index + 1}?", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, AmorousData.WideDialogueOffset, delegate(int answer)
					{
						if (answer == 1)
						{
							_game.SaveAtSlot(pointer.Index);
							_singleton.ReattachScreen();
						}
						_blocked = false;
					});
				}
			};
			container.Items.Add(optionBox);
		}
		return container;
	}

	private ListBox CreateDiaryLoadScreen()
	{
		ListBox container = CreateApplicationListBox();
		List<Saves.Pointer> pointers = Saves.GetPointers(excludeAutosaves: false);
		foreach (Saves.Pointer pointer in pointers)
		{
			int separator = pointer.Name.IndexOf('-');
			string name = pointer.Name.Substring(0, separator).Trim();
			string date = pointer.Name.Substring(separator + 1).Trim();
			ListBoxItem optionBox = new ListBoxItem
			{
				Text = name + "\r\n" + date,
				Size = new Squid.Point(0, 50)
			};
			optionBox.MouseClick += delegate
			{
				if (!pointer.IsEmpty)
				{
					_blocked = true;
					_squid.ShowSelection(string.Format("Are you sure you wish to load {0}slot #{1}?", (!pointer.IsAutosave) ? string.Empty : "autosave ", pointer.Index + 1), new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, AmorousData.WideDialogueOffset, delegate(int answer)
					{
						if (answer == 1)
						{
							_inPendingLoading = true;
							if (pointer.IsAutosave ? _game.ReadFromAutosaveSlot(pointer.Index) : _game.ReadFromSlot(pointer.Index))
							{
								_inPendingLoading = false;
								_blocked = false;
								Hide();
							}
							else
							{
								_squid.ShowConfirm("Failed to load save, it's most likely corrupted.", AmorousData.WideDialogueOffset, "OK", delegate
								{
									_inPendingLoading = false;
									_blocked = false;
								});
							}
						}
						else
						{
							_blocked = false;
						}
					});
				}
				else
				{
					_blocked = true;
					_squid.ShowConfirm(string.Format("There is no save in {0}slot #{1}!", pointer.IsAutosave ? "autosave " : string.Empty, pointer.Index + 1), AmorousData.WideDialogueOffset, "OK", delegate
					{
						_blocked = false;
					});
				}
			};
			container.Items.Add(optionBox);
		}
		return container;
	}

	private Control CreateAudioScreen()
	{
		Panel container = new Panel
		{
			Dock = DockStyle.Fill,
			Margin = new Margin(10)
		};
		Label volumeLabel = new Label
		{
			Dock = DockStyle.Top,
			Text = "Master Volume"
		};
		Slider volumeSlider = new Slider();
		volumeSlider.Dock = DockStyle.Top;
		volumeSlider.Orientation = Orientation.Horizontal;
		volumeSlider.Steps = 100f;
		volumeSlider.Value = Options.Data.MasterVolume * 100f;
		volumeSlider.Style = "scrollSlider";
		volumeSlider.Size = new Squid.Point(0, AmorousData.ButtonHeight);
		volumeSlider.Button.Style = "scrollSliderButton";
		volumeSlider.ValueChanged += delegate
		{
			Options.Data.MasterVolume = volumeSlider.Value / 100f;
		};
		Label musicVolumeLabel = new Label
		{
			Dock = DockStyle.Top,
			Text = "Music Volume"
		};
		Slider musicVolumeSlider = new Slider();
		musicVolumeSlider.Dock = DockStyle.Top;
		musicVolumeSlider.Orientation = Orientation.Horizontal;
		musicVolumeSlider.Steps = 100f;
		musicVolumeSlider.Value = Options.Data.MusicVolume * 100f;
		musicVolumeSlider.Style = "scrollSlider";
		musicVolumeSlider.Size = new Squid.Point(0, AmorousData.ButtonHeight);
		musicVolumeSlider.Button.Style = "scrollSliderButton";
		musicVolumeSlider.ValueChanged += delegate
		{
			Options.Data.MusicVolume = musicVolumeSlider.Value / 100f;
		};
		Label soundVolumeLabel = new Label
		{
			Dock = DockStyle.Top,
			Text = "SFX Volume"
		};
		Slider soundVolumeSlider = new Slider();
		soundVolumeSlider.Dock = DockStyle.Top;
		soundVolumeSlider.Orientation = Orientation.Horizontal;
		soundVolumeSlider.Steps = 100f;
		soundVolumeSlider.Value = Options.Data.SfxVolume * 100f;
		soundVolumeSlider.Style = "scrollSlider";
		soundVolumeSlider.Size = new Squid.Point(0, AmorousData.ButtonHeight);
		soundVolumeSlider.Button.Style = "scrollSliderButton";
		soundVolumeSlider.ValueChanged += delegate
		{
			Options.Data.SfxVolume = soundVolumeSlider.Value / 100f;
		};
		container.Content.Controls.Add(volumeLabel);
		container.Content.Controls.Add(volumeSlider);
		container.Content.Controls.Add(musicVolumeLabel);
		container.Content.Controls.Add(musicVolumeSlider);
		container.Content.Controls.Add(soundVolumeLabel);
		container.Content.Controls.Add(soundVolumeSlider);
		return container;
	}

	private Control CreateChatSettingsScreen()
	{
		Panel container = new Panel
		{
			Dock = DockStyle.Fill,
			Margin = new Margin(10)
		};
		AttachDropDownList(container.Content.Controls, "Dialogue Text Speed", new string[4] { "Slow", "Normal", "Fast", "Instant" }, (int)Options.Data.DialogueTextSpeed, delegate(int answer)
		{
			Options.Data.DialogueTextSpeed = (DialogueSpeed)answer;
			TypingDialogue.Speed = (DialogueSpeed)answer;
		});
		CheckBox dialogueSkipBox = new CheckBox
		{
			Dock = DockStyle.Top,
			Text = "Dialogue Auto-skip",
			Checked = Options.Data.DialogueAutoSkip
		};
		dialogueSkipBox.CheckedChanged += delegate
		{
			Options.Data.DialogueAutoSkip = dialogueSkipBox.Checked;
			TypingDialogue.AutoSkip = dialogueSkipBox.Checked;
		};
		container.Content.Controls.Add(dialogueSkipBox);
		return container;
	}

	public static void AttachDropDownList(ControlCollection container, string name, string[] items, int answer, Action<int> then)
	{
		Label label = new Label
		{
			Text = name,
			Dock = DockStyle.Top
		};
		DropDownList dropdown = new DropDownList();
		dropdown.Dock = DockStyle.Top;
		dropdown.Style = "button";
		dropdown.Label.Margin = new Margin(10, 0, 0, 0);
		dropdown.Dropdown.Resizable = false;
		dropdown.Margin = new Margin(0, 0, 0, 5);
		dropdown.Listbox.Scrollbar.ButtonUp.Visible = false;
		dropdown.Listbox.Scrollbar.ButtonDown.Visible = false;
		for (int i = 0; i < items.Length; i++)
		{
			dropdown.Items.Add(new ListBoxItem
			{
				Text = items[i],
				Value = i,
				Selected = (i == answer),
				Size = new Squid.Point(0, AmorousData.ButtonHeight)
			});
		}
		dropdown.SelectedItemChanged += delegate(Control container, ListBoxItem box)
		{
			then((int)box.Value);
		};
		container.Add(label);
		container.Add(dropdown);
	}

	private ListBox CreateGalleryScreen()
	{
		ListBox container = CreateApplicationListBox();
		ListBoxItem playerCustomizationBox = new ListBoxItem
		{
			Text = "Player Customization",
			Size = new Squid.Point(0, 50)
		};
		playerCustomizationBox.MouseClick += delegate
		{
			_blocked = true;
			_squid.ShowSelection("Are you sure you wish to customize your character? This may break some active dates even if make no changes!", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, AmorousData.WideDialogueOffset, delegate(int answer)
			{
				if (answer == 1)
				{
					Hide();
					_game.StartScene<BackToPlayerCustomizationScene>();
				}
				_blocked = false;
			});
		};
		container.Items.Add(playerCustomizationBox);
		if (Censorship.Booties)
		{
			container.Items.Add(new ListBoxItem
			{
				Text = "---",
				Enabled = false
			});
			ListBoxItem disableSfwBox = new ListBoxItem
			{
				Text = (Censorship.Censored ? "Disable SFW" : "Enable SFW"),
				Size = new Squid.Point(0, 50)
			};
			disableSfwBox.MouseClick += delegate
			{
				ReloadSceneWith(delegate
				{
					Censorship.Censored = !Censorship.Censored;
					ReattachScreen();
					disableSfwBox.Text = (Censorship.Censored ? "Disable SFW" : "Enable SFW");
				});
			};
			container.Items.Add(disableSfwBox);
		}
		if (!Censorship.Censored)
		{
			AttachCheatsheet(container);
		}
		return container;
	}

	private void ReloadSceneWith(Action then)
	{
		_game.Fader.FadeOut(delegate
		{
			string sceneName = _game.Sexscene?.GetType().Name;
			if (sceneName != null)
			{
				_game.ResetSexscene();
			}
			then();
			_game.SwitchToScene(_game.Scene.GetType().Name, delegate
			{
				if (sceneName != null)
				{
					_game.PlaySexscene(sceneName);
				}
				_game.Fader.FadeIn();
			});
		});
	}

	private void RequestSexscene(string name)
	{
		_game.PlayCutscene(name);
		Hide();
	}

	private ListBox CreatePowerScreen()
	{
		ListBox container = CreateApplicationListBox();
		PlayerData data = PlayerPreferences.GetPlayerData();
		if (data.GetState(AmorousData.Prologue) == AmorousData.PrologueStateCompleted)
		{
			ListBoxItem wentHomeButton = new ListBoxItem
			{
				Text = "Back to Home",
				Size = new Squid.Point(0, 50)
			};
			ListBoxItem wentClubButton = new ListBoxItem
			{
				Text = "Back to Club Amorous",
				Size = new Squid.Point(0, 50)
			};
			container.Items.Add(wentHomeButton);
			container.Items.Add(wentClubButton);
			wentHomeButton.MouseClick += delegate
			{
				Hide();
				_game.StartScene<BedroomScene>();
			};
			wentClubButton.MouseClick += delegate
			{
				Hide();
				_game.StartScene<ClubInsideScene>();
			};
			container.Items.Add(new ListBoxItem
			{
				Text = "---",
				Enabled = false
			});
		}
		ListBoxItem leaveButton = new ListBoxItem
		{
			Text = "Exit to Main Menu",
			Size = new Squid.Point(0, 50)
		};
		leaveButton.MouseClick += delegate
		{
			Hide();
			Enabled = false;
			_game.StartScene<MainMenuScene>();
		};
		ListBoxItem quitButton = new ListBoxItem
		{
			Text = "Quit Game",
			Size = new Squid.Point(0, 50)
		};
		quitButton.MouseClick += delegate
		{
			_blocked = true;
			_squid.ShowSelection("Are you sure you wish to quit the Game? All unsaved progress will be lost!", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, AmorousData.WideDialogueOffset, delegate(int answer)
			{
				if (answer == 1)
				{
					_game.Exit();
				}
				_blocked = false;
			});
		};
		container.Items.Add(leaveButton);
		container.Items.Add(quitButton);
		return container;
	}

	private void AttachCheatsheet(ListBox container)
	{
		ListBoxItem toplessBox = new ListBoxItem
		{
			Text = (Censorship.Topless ? "Disable Topless Cheat" : "Enable Topless Cheat"),
			Size = new Squid.Point(0, 50)
		};
		toplessBox.MouseClick += delegate
		{
			ReloadSceneWith(delegate
			{
				Censorship.Topless = !Censorship.Topless;
				toplessBox.Text = (Censorship.Topless ? "Disable Topless Cheat" : "Enable Topless Cheat");
			});
		};
		ListBoxItem bottomlessBox = new ListBoxItem
		{
			Text = (Censorship.Bottomless ? "Disable Bottomless Cheat" : "Enable Bottomless Cheat"),
			Size = new Squid.Point(0, 50)
		};
		bottomlessBox.MouseClick += delegate
		{
			ReloadSceneWith(delegate
			{
				Censorship.Bottomless = !Censorship.Bottomless;
				bottomlessBox.Text = (Censorship.Bottomless ? "Disable Bottomless Cheat" : "Enable Bottomless Cheat");
			});
		};
		container.Items.Add(toplessBox);
		container.Items.Add(bottomlessBox);
	}

	private void RequestContactCall(PlayerData.EPhoneContacts contact)
	{
		PlayerData data = PlayerPreferences.GetPlayerData();
		switch (contact)
		{
			case PlayerData.EPhoneContacts.Dustin:
				if (data.GetState(AmorousData.DustinDate) != AmorousData.DustinStateCompleted)
				{
					_game.PlayCutscene(AmorousData.DustinDate);
					Hide();
				}
				else
				{
					ShowDatesCompleted(contact);
				}
				break;
			case PlayerData.EPhoneContacts.Remy:
				if (data.GetState(AmorousData.RemyDate) != AmorousData.RemyStateCompleted)
				{
					_game.PlayCutscene(AmorousData.RemyDate);
					Hide();
				}
				else
				{
					ShowDatesCompleted(contact);
				}
				break;
			case PlayerData.EPhoneContacts.Seth:
				if (data.GetState(AmorousData.SethDate) == AmorousData.SethStateCompleted)
				{
					ShowDatesCompleted(contact);
					break;
				}
				_game.PlayCutscene(AmorousData.SethDate);
				Hide();
				break;
			case PlayerData.EPhoneContacts.Skye:
				if (data.GetState(AmorousData.SkyeDate) != AmorousData.SkyeStateCompleted)
				{
					_game.PlayCutscene(AmorousData.SkyeDate);
					Hide();
				}
				else
				{
					ShowDatesCompleted(contact);
				}
				break;
			case PlayerData.EPhoneContacts.Zenith:
				if (PlayerPreferences.GetPlayerData().GetState(AmorousData.ZenithDate) == AmorousData.ZenithStateCompleted)
				{
					ShowDatesCompleted(contact);
					break;
				}
				_game.PlayCutscene(AmorousData.ZenithDate);
				Hide();
				break;
			case PlayerData.EPhoneContacts.Mercy:
				if (data.GetState(AmorousData.MercyDate) != AmorousData.MercyStateCompleted)
				{
					_game.PlayCutscene(AmorousData.MercyDate);
					Hide();
				}
				else
				{
					ShowDatesCompleted(contact);
				}
				break;
			case PlayerData.EPhoneContacts.Lex:
				if (data.GetState(AmorousData.LexDate) == AmorousData.LexStateCompleted)
				{
					ShowDatesCompleted(contact);
					break;
				}
				_game.PlayCutscene(AmorousData.LexDate);
				Hide();
				break;
			case PlayerData.EPhoneContacts.Jax:
				if (data.GetState(AmorousData.JaxDate) == AmorousData.JaxStateCompleted)
				{
					ShowDatesCompleted(contact);
					break;
				}
				_game.PlayCutscene(AmorousData.JaxDate);
				Hide();
				break;
			case PlayerData.EPhoneContacts.Coby:
				if (data.GetState(AmorousData.CobyDate) < AmorousData.CobyStateCompleted)
				{
					_game.PlayCutscene(AmorousData.CobyDate);
					Hide();
				}
				else
				{
					_game.PlayCutscene(AmorousData.CobyPostDate);
				}
				break;
		}
	}

	private void ShowDatesCompleted(PlayerData.EPhoneContacts contact)
	{
		_blocked = true;
		_squid.ShowConfirm($"You finished all dates with {contact.ToString()}!", AmorousData.WideDialogueOffset, "Gotcha!", delegate
		{
			_blocked = false;
		});
	}

	public void RefreshSkin()
	{
		PlayerData data = PlayerPreferences.GetPlayerData();
		bool hasLongMarkings = data.MarkingsType.HasFlag(PlayerData.EMarkingsType.LongForearm);
		bool hasShortMarkings = data.MarkingsType.HasFlag(PlayerData.EMarkingsType.ShortForearm);
		Color markingColor = hasShortMarkings ? data.ShortForearmColor : (hasLongMarkings ? data.LongForearmColor : Color.White);
		_interactionSpine.SetAlpha("Hoody Sleeve", 0f);
		_interactionSpine.SetAlpha("Default Forearm", 1f);
		_interactionSpine.SetColor("Default Forearm", data.BodyColor);
		_interactionSpine.SetAlpha("Marking Forearm", (hasShortMarkings || hasLongMarkings) ? 1 : 0);
		_interactionSpine.SetColor("Marking Forearm", markingColor);
		_interactionSpine.SetAlpha("Striped forearm", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1 : 0);
		_interactionSpine.SetColor("Striped forearm", data.StripesColor);
		_interactionSpine.SetAlpha("Avian Forearm", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
		_interactionSpine.SetColor("Avian Forearm", data.AvianForearmColor);
		_interactionSpine.SetAlpha("Hand", 1f);
		_interactionSpine.SetColor("Hand", data.BodyColor);
		_interactionSpine.SetAlpha("Marking Hand", (hasShortMarkings || hasLongMarkings) ? 1 : 0);
		_interactionSpine.SetColor("Marking Hand", markingColor);
		_interactionSpine.SetAlpha("Avian Hand", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
		_interactionSpine.SetColor("Avian Hand", data.AvianForearmColor);
		_interactionSpine.SetAlpha("Index", 1f);
		_interactionSpine.SetColor("Index", data.BodyColor);
		_interactionSpine.SetAlpha("Avian index", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
		_interactionSpine.SetColor("Avian index", data.AvianForearmColor);
		_interactionSpine.SetAlpha("Pinky", 1f);
		_interactionSpine.SetColor("Pinky", data.BodyColor);
		_interactionSpine.SetAlpha("Avian Pinky", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
		_interactionSpine.SetColor("Avian Pinky", data.AvianForearmColor);
		_interactionSpine.SetAlpha("Ring", 1f);
		_interactionSpine.SetColor("Ring", data.BodyColor);
		_interactionSpine.SetAlpha("Avian ring", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
		_interactionSpine.SetColor("Avian ring", data.AvianForearmColor);
		_interactionSpine.SetAlpha("Rude", 1f);
		_interactionSpine.SetColor("Rude", data.BodyColor);
		_interactionSpine.SetAlpha("Avian Rude", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
		_interactionSpine.SetColor("Avian Rude", data.AvianForearmColor);
		_interactionSpine.SetAlpha("Thumb", 1f);
		_interactionSpine.SetColor("Thumb", data.BodyColor);
		_interactionSpine.SetAlpha("Avian Thumb", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
		_interactionSpine.SetColor("Avian Thumb", data.AvianForearmColor);
		_interactionSpine.SetAlpha("Pinky Nail", data.ShowNails ? 1 : 0);
		_interactionSpine.SetColor("Pinky Nail", data.NailColor);
		_interactionSpine.SetAlpha("Ring Nail", data.ShowNails ? 1 : 0);
		_interactionSpine.SetColor("Ring Nail", data.NailColor);
		_interactionSpine.SetAlpha("Rude Nail", data.ShowNails ? 1 : 0);
		_interactionSpine.SetColor("Rude Nail", data.NailColor);
		_interactionSpine.SetAlpha("Index Nail", data.ShowNails ? 1 : 0);
		_interactionSpine.SetColor("Index Nail", data.NailColor);
		_interactionSpine.SetAlpha("Thumb Nail", data.ShowNails ? 1 : 0);
		_interactionSpine.SetColor("Thumb Nail", data.NailColor);
		_interactionSpine.SetAlpha("Phone lines", 1f);
		_interactionSpine.SetColor("Phone lines", data.PhoneColor);
		_interactionSpine.SetAlpha("Phone Colour", 1f);
		_interactionSpine.SetAlpha("Phone Shadow", 1f);
		_interactionSpine.SetAlpha("BG CONTACTS", 0f);
		_interactionSpine.SetAlpha("BG DIARY", 0f);
		_interactionSpine.SetAlpha("BG AUDIO", 0f);
		_interactionSpine.SetAlpha("BG CHAT SETTINGS", 0f);
		_interactionSpine.SetAlpha("BG GALLERY", 0f);
		_interactionSpine.SetAlpha("BG POWER", 0f);
		_interactionSpine.SetAlpha("Phone Default Background", 1f);
		_interactionSpine.SetAlpha("CONTACTS", 1f);
		_interactionSpine.SetAlpha("Diary", 1f);
		_interactionSpine.SetAlpha("Audio", 1f);
		_interactionSpine.SetAlpha("Chat Settings", 1f);
		_interactionSpine.SetAlpha("Gallery", 1f);
		_interactionSpine.SetAlpha("Power", 1f);
		_interactionSpine.SetAlpha("white screen", 1f);
		_interactionSpine.SetAlpha("black screen", 1f);
		_interactionSpine.SetAlpha("Power", 1f);
		_interactionSpine.SetAlpha("Sheen Two", 1f);
		RefreshPhoneSkin();
	}

	private void RefreshPhoneSkin()
	{
		_phoneOverlaySpine.SetColor("Phone", PlayerPreferences.GetPlayerData().PhoneColor);
	}

	public static PhoneOverlay Get()
	{
		return _singleton;
	}

	private void ShowContact(PlayerData.EPhoneContacts contact)
	{
		_hiddenPhoneAction = false;
		foreach (string key in _visibleContactParts.Keys.ToList())
		{
			_visibleContactParts[key] = false;
		}
		if (contact == PlayerData.EPhoneContacts.Lex)
		{
			_visibleContactParts["Alex"] = true;
			_visibleContactParts["Alex image"] = true;
		}
		else
		{
			_visibleContactParts[contact.ToString()] = true;
			_visibleContactParts[contact.ToString() + " image"] = true;
		}
	}

	private void ApplyCallingScreen(bool state)
	{
		_visibleActionParts["reject call with message"] = state;
		_visibleActionParts["Incoming call"] = state;
	}

	public void Update(GameTime gameTime, CanvasObserver canvas)
	{
		if (_game.Controller.IsPressed(Microsoft.Xna.Framework.Input.Keys.Escape) || _game.Controller.IsPressed(Microsoft.Xna.Framework.Input.Keys.LeftShift))
		{
			Rise();
		}
		_interactionSpine.Update(gameTime, (_game.Cutscene != null || !_interactable) ? RiseDownDuration : _duration);
		_phoneOverlaySpine.Update(gameTime);
		_phoneActionSpine.Update(gameTime);
		ResolvePendingRequests();
		UpdateOverlayButton(canvas);
		UpdateOverlayScreen(canvas);
		if (!_hiddenPhoneScreen)
		{
			_squid.Update();
		}
	}

	private void ResolvePendingRequests()
	{
		if (_isChangingState)
		{
			return;
		}
		if (_requestedRise)
		{
			_interactable = false;
			_requestedRise = false;
			_isChangingState = true;
			_interactionSpine.StartAnimation("Arm rise", delegate
			{
				_isChangingState = false;
				Pose = ArmPose.ArmUp;
				StartHoldingAnimation();
			});
		}
		else if (_requestedHang)
		{
			_interactable = false;
			_requestedHang = false;
			_isChangingState = true;
			_interactionSpine.StartAnimation("Arm lower", delegate
			{
				_isChangingState = false;
				Pose = ArmPose.ArmDown;
			});
		}
	}

	private void UpdateOverlayButton(CanvasObserver canvas)
	{
		if (Indicator == PhoneIndicator.None || _game.Cutscene != null || _blocked)
		{
			return;
		}
		Microsoft.Xna.Framework.Point cursor = canvas.GlobalToContent(_game.Controller.Cursor);
		if (_phoneOverlaySpine.InAttachment("Phone", cursor.X, cursor.Y))
		{
			_phoneOverlaySpine.SetColor("Phone", Color.Red);
			AbstractScene.CapturedByOverlay = true;
			if (_game.Controller.IsPressed(ControllerButtonType.LeftButton))
			{
				Rise();
			}
			_closeableOutside = true;
		}
		else if (_closeableOutside)
		{
			_phoneOverlaySpine.SetColor("Phone", PlayerPreferences.GetPlayerData().PhoneColor);
			if (Pose == ArmPose.ArmDown || Pose == ArmPose.ArmDownRequested)
			{
				AbstractScene.CapturedByOverlay = false;
			}
			_closeableOutside = false;
		}
	}

	private void UpdateOverlayScreen(CanvasObserver canvas)
	{
		if (Pose != ArmPose.ArmUp || _game.Cutscene != null || _blocked)
		{
			return;
		}
		Microsoft.Xna.Framework.Point cursor = canvas.GlobalToContent(_game.Controller.Cursor);
		bool captured = _interactionSpine.InAttachment("Phone Colour", cursor.X, cursor.Y);
		_duration = (captured ? RiseUpDuration : RiseDownDuration);
		if (!captured)
		{
			return;
		}
		if (_game.Controller.IsPressed(ControllerButtonType.LeftButton))
		{
			if (_screen == PhoneScreen.Home)
			{
				if (_interactionSpine.InAttachment("CONTACTS", cursor.X, cursor.Y))
				{
					OpenScreen(PhoneScreen.Contacts);
				}
				else if (_interactionSpine.InAttachment("Diary", cursor.X, cursor.Y))
				{
					OpenScreen(PhoneScreen.Diary);
				}
				else if (_interactionSpine.InAttachment("Audio", cursor.X, cursor.Y))
				{
					OpenScreen(PhoneScreen.Audio);
				}
				else if (_interactionSpine.InAttachment("Chat Settings", cursor.X, cursor.Y))
				{
					OpenScreen(PhoneScreen.ChatSettings);
				}
				else if (_interactionSpine.InAttachment("Gallery", cursor.X, cursor.Y))
				{
					OpenScreen(PhoneScreen.Gallery);
				}
				else if (_interactionSpine.InAttachment("Power", cursor.X, cursor.Y))
				{
					OpenScreen(PhoneScreen.Power);
				}
				else if (!_interactionSpine.InAttachment("Phone Default Background", cursor.X, cursor.Y))
				{
					Hide();
				}
			}
			else if (!_interactionSpine.InAttachment("Phone Default Background", cursor.X, cursor.Y))
			{
				Back();
			}
		}
		if (_game.Controller.IsPressed(ControllerButtonType.RightButton))
		{
			if (_screen != 0)
			{
				Back();
			}
			else
			{
				Hide();
			}
		}
	}

	public void Draw(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer)
	{
		if (!Enabled)
		{
			return;
		}
		if (_isChangingState || Pose == ArmPose.ArmUp)
		{
			RenderTargetBinding[] targets = _game.Graphics.GetRenderTargets();
			_game.Graphics.SetRenderTarget(_phoneScreenTarget);
			_squid.Draw();
			_game.Graphics.SetRenderTarget(_phoneActionTarget);
			_phoneActionSpine.Draw(skeletonMeshRenderer, null, delegate(int answer, string string_0)
			{
				if (_visibleContactParts.ContainsKey(string_0))
				{
					return _visibleContactParts[string_0];
				}
				return !_visibleActionParts.ContainsKey(string_0) || _visibleActionParts[string_0];
			});
			_game.Graphics.SetRenderTargets(targets);
			double depth;
			Microsoft.Xna.Framework.Point sheen = _interactionSpine.GetDistanceDepth("Sheen Two", out depth);
			_interactionSpine.Draw(skeletonMeshRenderer, null, delegate(int index, string bone)
			{
				if (bone == "Sheen Two")
				{
					skeletonMeshRenderer.End();
					spriteBatch.Begin();
					if (!_hiddenPhoneScreen)
					{
						spriteBatch.Draw(_phoneScreenTarget, new Vector2(sheen.X, sheen.Y), null, null, null, (float)depth);
					}
					if (!_hiddenPhoneAction)
					{
						spriteBatch.Draw(_phoneActionTarget, new Vector2(sheen.X, sheen.Y), null, null, null, (float)depth);
					}
					if (!_hiddenRemyNudes)
					{
						spriteBatch.Draw(_spriteActiveRemyNude, new Vector2(sheen.X, sheen.Y), null, null, null, (float)depth);
					}
					spriteBatch.End();
					skeletonMeshRenderer.Begin();
				}
				else if (bone == "Thumb")
				{
					if (!_hiddenGameBox)
					{
						skeletonMeshRenderer.End();
						spriteBatch.Begin();
						spriteBatch.Draw(_spriteActiveGamebox, new Vector2(sheen.X - 16, sheen.Y - 128), null, null, null, (float)depth);
						spriteBatch.End();
						skeletonMeshRenderer.Begin();
					}
				}
				else if (!_hiddenGameBox && PlayerNails.Contains(bone))
				{
					return false;
				}
				return true;
			});
		}
		if (_indicator != 0 && _game.Cutscene == null)
		{
			_phoneOverlaySpine.Draw(skeletonMeshRenderer);
		}
	}
}
