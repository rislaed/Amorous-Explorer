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
	public enum EArmPose
	{
		ArmDown,
		ArmUp,
		ArmDownRequested,
		ArmUpRequested
	}

	public enum EPhoneScreen
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

	public enum EPhoneState
	{
		None,
		NoMessage,
		MessageNew,
		MessageIdle,
		MessageUrgent
	}

	private bool phoneSometimeOpened;
	private bool inPendingLoading;

	private readonly Dictionary<PlayerData.EPhoneContacts, Squid.Rectangle> contactBounds = new Dictionary<PlayerData.EPhoneContacts, Squid.Rectangle>
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

	private readonly Dictionary<PlayerData.EPhoneContacts, string> contactSexscenes = new Dictionary<PlayerData.EPhoneContacts, string>
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

	private PlayerData.EPhoneContacts selectedContact;
	private PhoneMessage selectedMessage;
	private readonly string[] dialogueDJ = new string[5] { "That song is awesome!", "This one is so underrated!", "Haven't heard that one in a while!", "Always gives me goosebumbs!", "The beat in this one is just amazing!" };
	private static PhoneOverlay singleton;
	private readonly IAmorous game;
	private readonly SkeletonRenderer interactionSkeleton;
	private readonly SkeletonRenderer phoneOverlaySkeleton;
	private readonly SkeletonRenderer phoneSkeleton;

	private readonly Dictionary<string, bool> contactSlots = new Dictionary<string, bool>
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

	private readonly Dictionary<string, bool> interactionSlots = new Dictionary<string, bool>
	{
		{ "reject call with message", true },
		{ "Incoming call", true }
	};

	private EPhoneState state;
	private bool changingState, requestedRise, requestedHang;

	private static readonly string[] GAMEBOX_SPRITES = new string[6] { "Marlboro", "Angry Curds", "God of Warfare Modern War", "Inanimate 3", "The Blinding of Blissac", "Traffic Controller" };
	private static readonly string[] REMY_NUDES = new string[4] { "Nude1", "Nude2", "Nude3", "Nude4" };
	private static readonly string[] PLAYER_NAILS = new string[4] { "Pinky Nail", "Ring Nail", "Rude Nail", "Index Nail" };

	private readonly Desktop desktop;
	private readonly RenderTarget2D phoneScreenTarget, phoneTarget;
	private Texture2D spriteOfActiveGamebox, spriteOfActiveRemyNude;
	private bool blocked;
	private bool hiddenPhoneScreen, hiddenPhone;
	private bool hiddenGameBox, hiddenRemyNudes;
	private int selectedGamebox, selectedNude;
	private static EPhoneScreen screen;
	private static Stack<EPhoneScreen> screenStack;
	private static bool enabled;

	private const float RISE_DOWN = 1000f;
	private const float RISE_UP = 5000f;

	private bool interactable;
	private float duration = 1f;
	private bool closeableOutside;

	public EArmPose ArmPose { get; private set; }

	public static bool Enabled
	{
		get
		{
			return enabled;
		}
		set
		{
			enabled = value;
			if (!enabled)
			{
				State = EPhoneState.None;
			}
			else
			{
				State = EPhoneState.NoMessage;
			}
		}
	}

	public static EPhoneState State
	{
		get
		{
			return singleton.state;
		}
		set
		{
			if (value != singleton.state)
			{
				singleton.state = value;
				switch (value)
				{
					case EPhoneState.NoMessage:
						singleton.phoneOverlaySkeleton.StartAnimationWithLooping("No message");
						singleton.RefreshPhoneSkin();
						break;
					case EPhoneState.MessageNew:
						singleton.phoneOverlaySkeleton.StartAnimationWithLooping("Message new");
						break;
					case EPhoneState.MessageIdle:
						singleton.phoneOverlaySkeleton.StartAnimationWithLooping("Message idle");
						break;
					case EPhoneState.MessageUrgent:
						singleton.phoneOverlaySkeleton.StartAnimationWithLooping("Urgent message");
						break;
				}
			}
		}
	}

	public PhoneOverlay(IAmorous game, ContentManager content)
	{
		singleton = this;
		this.game = game;
		interactionSkeleton = content.LoadSkeleton("Assets/GUI/Phone/Phone");
		interactionSkeleton.ApplyTime("Arm rise", 0f);
		interactionSkeleton.SetVisibility(0f);
		interactionSkeleton.X = 0f;
		interactionSkeleton.Y = 1200f;
		phoneOverlaySkeleton = content.LoadSkeleton("Assets/GUI/Phone/PhoneHUD", 0.5f);
		phoneOverlaySkeleton.StartAnimationWithLooping("No message");
		phoneOverlaySkeleton.X = 1845f;
		phoneOverlaySkeleton.Y = 1060f;
		phoneSkeleton = content.LoadSkeleton("Assets/GUI/Phone/PhoneScreen");
		phoneSkeleton.X = 135f;
		phoneSkeleton.Y = 190f;
		hiddenPhone = true;
		RefreshSkin();
		desktop = new Desktop
		{
			Skin = Gui.GenerateStandardSkin(),
			Size = new Squid.Point(270, 380)
		};
		desktop.SetSkin("Assets/GUI/Squid/DefaultSkin");
		desktop.ModalColor = ColorInt.ARGB(0.9f, 0f, 0f, 0f);
		desktop.MouseTransformFunc = delegate(Squid.Point cursor)
		{
			double depth;
			Microsoft.Xna.Framework.Point sheen = interactionSkeleton.GetDistanceDepth("Sheen Two", out depth);
			Matrix matrix = Matrix.CreateTranslation(-sheen.X, -sheen.Y, 0f) * Matrix.CreateRotationZ((float)(-depth));
			Vector2 vector = Vector2.Transform(new Vector2(cursor.x, cursor.y), matrix);
			return new Squid.Point((int)vector.X, (int)vector.Y);
		};
        phoneScreenTarget = new RenderTarget2D(this.game.Graphics, 270, 380);
        phoneTarget = new RenderTarget2D(this.game.Graphics, 270, 380);
		screenStack = new Stack<EPhoneScreen>();
		hiddenGameBox = true;
		hiddenRemyNudes = true;
	}

	public void AcceptCall(PlayerData.EPhoneContacts contact)
	{
		ShowContact(contact);
		phoneSkeleton.RestartAnimation();
		phoneSkeleton.StartAnimation("Phone answer start", delegate
		{
			phoneSkeleton.StartAnimationWithLooping("Phone answer loop");
		});
		StartSwipeAnimation();
	}

	public void AcceptIM(PlayerData.EPhoneContacts contact)
	{
		ShowContact(contact);
		phoneSkeleton.StartAnimation("Phone IM accept", delegate
		{
			phoneSkeleton.StartAnimationWithLooping("Phone IM idle");
		});
		StartSwipeAnimation();
	}

	public void DeclineCall(PlayerData.EPhoneContacts contact)
	{
		hiddenPhone = true;
		StartSwipeAnimation();
	}

	public void DeclineIM(PlayerData.EPhoneContacts contact)
	{
		hiddenPhone = true;
		StartSwipeAnimation();
	}

	public void IncomingCall(PlayerData.EPhoneContacts contact)
	{
		ShowContact(contact);
		ApplyCallingScreen(state: true);
		phoneSkeleton.RestartAnimation();
		phoneSkeleton.StartAnimation("Phone Call start", delegate
		{
			phoneSkeleton.StartAnimationWithLooping("Phone Call loop");
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
		phoneSkeleton.StartAnimationWithLooping("Phone IM idle");
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
		phoneSkeleton.StartAnimation("Phone IM messaging loop", delegate
		{
			phoneSkeleton.StartAnimationWithLooping("Phone IM idle");
		});
		StartTypingAnimation();
	}

	private void OpenCallingScreen(PlayerData.EPhoneContacts contact)
	{
		ShowContact(contact);
		ApplyCallingScreen(state: false);
		phoneSkeleton.RestartAnimation();
		phoneSkeleton.StartAnimation("Phone Call start", delegate
		{
			phoneSkeleton.StartAnimationWithLooping("Phone Call loop");
		});
		StartSwipeAnimation();
	}

	public void ShowGameBox()
	{
		hiddenGameBox = false;
		spriteOfActiveGamebox = game.Content.Load<Texture2D>("Assets/GUI/Phone/Gameboxes/" + GAMEBOX_SPRITES[selectedGamebox]);
		selectedGamebox++;
		if (selectedGamebox >= GAMEBOX_SPRITES.Length)
		{
			selectedGamebox = 0;
		}
	}

	public void HideGameBox()
	{
		hiddenGameBox = true;
		selectedGamebox = 0;
	}

	public void UpdateRemyNudes()
	{
		hiddenRemyNudes = false;
		spriteOfActiveRemyNude = game.Content.Load<Texture2D>("Assets/GUI/Phone/Gallery/Remy/" + REMY_NUDES[selectedNude]);
		selectedNude++;
		if (selectedNude >= REMY_NUDES.Length)
		{
			selectedNude = 0;
		}
		StartSwipeAnimation();
	}

	public void UpdateRemyNudes(int index)
	{
		hiddenRemyNudes = false;
		spriteOfActiveRemyNude = game.Content.Load<Texture2D>("Assets/GUI/Phone/Gallery/Remy/" + REMY_NUDES[index]);
		StartSwipeAnimation();
	}

	public void HideRemyNudes()
	{
		hiddenRemyNudes = true;
		selectedNude = 0;
		StartSwipeAnimation();
	}

	public void HideActions()
	{
		hiddenPhone = true;
	}

	public void Reset()
	{
		hiddenPhone = true;
		hiddenGameBox = true;
		selectedGamebox = 0;
		hiddenRemyNudes = true;
		selectedNude = 0;
	}

	public static void Rise()
	{
		if (singleton.game.Cutscene == null && !singleton.changingState)
		{
			if (singleton.ArmPose == EArmPose.ArmUp)
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
			if (!singleton.phoneSometimeOpened)
			{
				singleton.phoneSometimeOpened = true;
				singleton.game.Achievements.TriggerAchievement(Achievements.AchievementGeneric5);
			}
			singleton.game.Canvas.Captured = true;
			AbstractScene.CapturedByOverlay = true;
			singleton.blocked = preserveHiding;
			if (!singleton.changingState && singleton.ArmPose == EArmPose.ArmDown)
			{
				singleton.ArmPose = EArmPose.ArmUpRequested;
				singleton.requestedRise = true;
				screenStack.Clear();
				Open(EPhoneScreen.Home);
			}
		}
	}

	public static void Hide()
	{
		if (Enabled && !singleton.inPendingLoading)
		{
			singleton.game.Canvas.Captured = false;
			AbstractScene.CapturedByOverlay = false;
			singleton.blocked = false;
			if (!singleton.changingState && singleton.ArmPose == EArmPose.ArmUp)
			{
				singleton.ArmPose = EArmPose.ArmDownRequested;
				singleton.requestedHang = true;
			}
		}
	}

	public static void Open(EPhoneScreen screen)
	{
		if (screen != 0)
		{
            screenStack.Push(PhoneOverlay.screen);
			singleton.StartSwipeAnimation();
		}
        PhoneOverlay.screen = screen;
		singleton.ReattachScreen();
	}

	public static void Swipe(EPhoneScreen screen)
	{
		singleton.StartSwipeAnimation();
		singleton.ReattachScreen();
	}

	public static void Back()
	{
		screen = screenStack.Pop();
		singleton.ReattachScreen();
		singleton.StartSwipeAnimation();
	}

	private void StartSwipeAnimation()
	{
		interactable = false;
		singleton.interactionSkeleton.StartAnimation("Swipe", StartHoldingAnimation);
	}

	private void StartTypingAnimation()
	{
		interactable = false;
		singleton.interactionSkeleton.StartAnimation("Typing", StartHoldingAnimation);
	}

	private void StartHoldingAnimation()
	{
		singleton.interactionSkeleton.StartAnimationWithLooping("Idle");
		interactable = true;
	}

	private void ReattachScreen()
	{
		Control container;
		switch (screen)
		{
			default:
				hiddenPhoneScreen = true;
				return;
			case EPhoneScreen.Contacts:
				container = CreateContactsScreen();
				break;
			case EPhoneScreen.ContactsInformation:
				container = CreateContactsInformationScreen();
				break;
			case EPhoneScreen.ContactsInformationDJ:
				container = CreateContactsInformationDJScreen();
				break;
			case EPhoneScreen.Soundtrack:
				container = CreateSoundtrackScreen();
				break;
			case EPhoneScreen.Diary:
				container = CreateDiaryScreen();
				break;
			case EPhoneScreen.DiaryMessages:
				container = CreateDiaryMessagesScreen();
				break;
			case EPhoneScreen.DiaryMessagesInformation:
				container = CreateDiaryMessagesInformationScreen();
				break;
			case EPhoneScreen.DiaryAchievements:
				container = CreateDiaryAchievementsScreen();
				break;
			case EPhoneScreen.DiarySave:
				container = CreateDiarySaveScreen();
				break;
			case EPhoneScreen.DiaryLoad:
				container = CreateDiaryLoadScreen();
				break;
			case EPhoneScreen.Audio:
				container = CreateAudioScreen();
				break;
			case EPhoneScreen.ChatSettings:
				container = CreateChatSettingsScreen();
				break;
			case EPhoneScreen.Gallery:
				container = CreateGalleryScreen();
				break;
			case EPhoneScreen.Power:
				container = CreatePowerScreen();
				break;
		}
		hiddenPhoneScreen = false;
		desktop.Controls.Clear();
		desktop.Controls.Add(container);
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
		if (data.GetStage(AmorousData.DJ) == AmorousData.UnlockedContactDJ)
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
				Open(EPhoneScreen.ContactsInformationDJ);
			};
			contactContainer.Controls.Add(contactImage);
			contactContainer.Controls.Add(contactLabel);
			container.ItemContainer.Controls.Add(contactContainer);
		}
		List<string> contactNames = Enum.GetNames(typeof(PlayerData.EPhoneContacts)).Except(new string[1] { "None" }).ToList();
		PlayerData.EPhoneContacts contact;
		Tuple<string, PlayerData.EPhoneContacts>[] contacts = (from name in contactNames
			select Enum.TryParse<PlayerData.EPhoneContacts>(name, out contact) ? (
				(!data.Contacts.HasFlag(contact)) ? null : new Tuple<string, PlayerData.EPhoneContacts>(name, contact)
			) : null into tuple
			where tuple != null
			orderby tuple.Item1
			select tuple).ToArray();
		foreach (Tuple<string, PlayerData.EPhoneContacts> subcontact in contacts)
		{
			Squid.Rectangle bounds = contactBounds[subcontact.Item2];
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
				Text = subcontact.Item1,
				TextAlign = Alignment.MiddleCenter,
				NoEvents = true
			};
			CustomListBoxItem contactContainer = new CustomListBoxItem
			{
				Size = new Squid.Point(0, 60),
				Padding = new Margin(2),
				Value = subcontact.Item2
			};
			contactContainer.MouseClick += delegate
			{
				selectedContact = (PlayerData.EPhoneContacts)contactContainer.Value;
				Open(EPhoneScreen.ContactsInformation);
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
			Text = selectedContact.ToString(),
			Style = "button",
			Size = new Squid.Point(0, 40),
			NoEvents = true
		};
		ImageControl contactImage = new CustomImageControl
		{
			Dock = DockStyle.Top,
			Texture = "PhoneScreen",
			TextureRect = contactBounds[selectedContact]
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
			blocked = true;
			desktop.ShowSelection($"Are you sure you wish to remove {selectedContact}? This will reset all progression!", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, AmorousData.ShortDialogueWidth, delegate(int answer)
			{
				if (answer == 1)
				{
					PlayerPreferences.GetPlayerData().DisableContact(selectedContact);
					desktop.ShowConfirm($"{selectedContact} will be available again after you went home.", AmorousData.ShortDialogueWidth, "OK", delegate
					{
						Back();
						blocked = false;
					});
				}
				else
				{
					Back();
					blocked = false;
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
			string scene = game.Scene.GetType().Name;
			string sexscene = game.Sexscene?.GetType().Name;
			if (scene == AmorousData.PlayerSexScene && sexscene == contactSexscenes[selectedContact])
			{
				TypingDialogue.Type("<i>" + selectedContact.ToString() + " is kind of... preoccupied right now.</i>", "%playername%", Color.White);
			}
			else if (scene != AmorousData.BedroomScene && scene != AmorousData.LivingRoomScene)
			{
				TypingDialogue.Type("<i>Reception is really bad at the moment, I should try again when I'm back at home.</i>", "%playername%", Color.White);
			}
			else
			{
				RequestContactCall(selectedContact);
			}
		};
		container.Content.Controls.Add(callButton);
		if (selectedContact == PlayerData.EPhoneContacts.Zenith && data.GetStage(AmorousData.ZenithDate) > 20)
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
				game.StartScene<PhoneShootingRangeMiniGameScene>();
			};
			container.Content.Controls.Add(shootingRangeButton);
		}
		if (selectedContact == PlayerData.EPhoneContacts.Remy && data.GetStage(AmorousData.RemyDate) > 20)
		{
			Button cookingButton = new Button
			{
				Dock = DockStyle.Top,
				Text = "Extra: Cooking Mini-Game",
				Size = new Squid.Point(0, 50)
			};
			cookingButton.MouseClick += delegate
			{
				game.PlayCutscene(AmorousData.MiniGameCooking);
				Hide();
			};
			container.Content.Controls.Add(cookingButton);
		}
		if (!Censorship.Censored && selectedContact == PlayerData.EPhoneContacts.Remy && data.GetStage(AmorousData.RemyDate) > 30)
		{
			Button remyNudesButton = new Button
			{
				Dock = DockStyle.Top,
				Text = "Extra: Nude pictures",
				Size = new Squid.Point(0, 50)
			};
			remyNudesButton.MouseClick += delegate
			{
				game.PlayCutscene(AmorousData.NudesRemy);
				Hide();
			};
			container.Content.Controls.Add(remyNudesButton);
		}
		string sexscene = null;
		if (selectedContact == PlayerData.EPhoneContacts.Coby && data.GetStage(AmorousData.CobyDate) == AmorousData.CobyStateCompleted)
		{
			sexscene = AmorousData.CobySexscene;
		}
		else if (selectedContact == PlayerData.EPhoneContacts.Dustin && data.GetStage(AmorousData.DustinDate) == AmorousData.DustinStateCompleted)
		{
			sexscene = AmorousData.DustinPostDate;
		}
		else if (selectedContact != PlayerData.EPhoneContacts.Jax || data.GetStage(AmorousData.JaxDate) != AmorousData.JaxStateCompleted)
		{
			if (selectedContact != PlayerData.EPhoneContacts.Lex || data.GetStage(AmorousData.LexDate) != AmorousData.LexStateCompleted)
			{
				if (selectedContact == PlayerData.EPhoneContacts.Mercy && data.GetStage(AmorousData.MercyDate) == AmorousData.MercyStateCompleted)
				{
					sexscene = AmorousData.MercyPostDate;
				}
				else if (selectedContact != PlayerData.EPhoneContacts.Remy || data.GetStage(AmorousData.RemyDate) != AmorousData.RemyStateCompleted)
				{
					if (selectedContact != PlayerData.EPhoneContacts.Seth || data.GetStage(AmorousData.SethDate) != AmorousData.SethStateCompleted)
					{
						if (selectedContact == PlayerData.EPhoneContacts.Skye && data.GetStage(AmorousData.SkyeDate) == AmorousData.SkyeStateCompleted)
						{
							sexscene = AmorousData.SkyePostDate;
						}
						else if (selectedContact == PlayerData.EPhoneContacts.Zenith && data.GetStage(AmorousData.ZenithDate) == AmorousData.ZenithStateCompleted)
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
			string scene = game.Scene.GetType().Name;
			if (scene.StartsWith("Club"))
			{
				Open(EPhoneScreen.Soundtrack);
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
		List<AmorousData.Soundtrack> soundtracks = AmorousData.Soundtracks.OrderBy((AmorousData.Soundtrack soundtrack) => soundtrack.Title).ToList();
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
				int dialogue = Utils.Random(0, dialogueDJ.Length);
				TypingDialogue.Type(dialogueDJ[dialogue], ClubDJNPC.Name, ClubDJNPC.Color);
				FadingMediaPlayer.Play(soundtrack.AssetName, 0.3f, repeat: false);
				game.Achievements.TriggerAchievement(Achievements.AchievementGeneric3);
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
			Open(EPhoneScreen.DiaryMessages);
		};
		ListBoxItem achievementsBox = new ListBoxItem
		{
			Text = "Achievements",
			Size = new Squid.Point(0, 50)
		};
		achievementsBox.MouseClick += delegate
		{
			Open(EPhoneScreen.DiaryAchievements);
		};
		ListBoxItem saveBox = new ListBoxItem
		{
			Text = "Save",
			Size = new Squid.Point(0, 50)
		};
		saveBox.MouseClick += delegate
		{
			Open(EPhoneScreen.DiarySave);
		};
		ListBoxItem loadBox = new ListBoxItem
		{
			Text = "Load",
			Size = new Squid.Point(0, 50)
		};
		loadBox.MouseClick += delegate
		{
			Open(EPhoneScreen.DiaryLoad);
		};
		container.Items.Add(messagesBox);
		if (game.Achievements.IsSteamSupported)
		{
			ListBoxItem steamAchievementsBox = new ListBoxItem
			{
				Text = "Steam Achievements",
				Size = new Squid.Point(0, 50)
			};
			steamAchievementsBox.MouseClick += delegate
			{
				game.Achievements.OpenAchievements();
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
					selectedMessage = message;
					Open(EPhoneScreen.DiaryMessagesInformation);
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
				Opacity = (data.HasFlag(achievement.Key) ? 1f : 0.5f)
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
			Texture = selectedMessage.Icon,
			Size = new Squid.Point(60, 50)
		};
		Label messageTitleLabel = new Label
		{
			Dock = DockStyle.Fill,
			Text = selectedMessage.Title + "\r\n" + selectedMessage.Date.ToShortDateString(),
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
			Text = selectedMessage.Message,
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
			blocked = true;
			desktop.ShowSelection("Are you sure you wish to remove this message?", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, AmorousData.ShortDialogueWidth, delegate(int answer)
			{
				if (answer == 1)
				{
					PlayerData data = PlayerPreferences.GetPlayerData();
					data.Messages.Remove(selectedMessage);
					selectedMessage = null;
					Back();
				}
				blocked = false;
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
		List<Saves.Item> pointers = Saves.GetItems(excludeAutosaves: true);
		foreach (Saves.Item pointer in pointers)
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
					game.SaveAtSlot(pointer.Index);
					singleton.ReattachScreen();
				}
				else
				{
					blocked = true;
					desktop.ShowSelection($"Are you sure you wish to overwrite slot #{pointer.Index + 1}?", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, AmorousData.ShortDialogueWidth, delegate(int answer)
					{
						if (answer == 1)
						{
							game.SaveAtSlot(pointer.Index);
							singleton.ReattachScreen();
						}
						blocked = false;
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
		List<Saves.Item> pointers = Saves.GetItems(excludeAutosaves: false);
		foreach (Saves.Item pointer in pointers)
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
					blocked = true;
					desktop.ShowSelection(string.Format("Are you sure you wish to load {0}slot #{1}?", (!pointer.IsAutosave) ? string.Empty : "autosave ", pointer.Index + 1), new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, AmorousData.ShortDialogueWidth, delegate(int answer)
					{
						if (answer == 1)
						{
							inPendingLoading = true;
							if (pointer.IsAutosave ? game.ReadFromAutosaveSlot(pointer.Index) : game.ReadFromSlot(pointer.Index))
							{
								inPendingLoading = false;
								blocked = false;
								Hide();
							}
							else
							{
								desktop.ShowConfirm("Failed to load save, it's most likely corrupted.", AmorousData.ShortDialogueWidth, "OK", delegate
								{
									inPendingLoading = false;
									blocked = false;
								});
							}
						}
						else
						{
							blocked = false;
						}
					});
				}
				else
				{
					blocked = true;
					desktop.ShowConfirm(string.Format("There is no save in {0}slot #{1}!", pointer.IsAutosave ? "autosave " : string.Empty, pointer.Index + 1), AmorousData.ShortDialogueWidth, "OK", delegate
					{
						blocked = false;
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
		volumeSlider.Value = Options.Config.MasterVolume * 100f;
		volumeSlider.Style = "scrollSlider";
		volumeSlider.Size = new Squid.Point(0, AmorousData.ButtonHeight);
		volumeSlider.Button.Style = "scrollSliderButton";
		volumeSlider.ValueChanged += delegate
		{
			Options.Config.MasterVolume = volumeSlider.Value / 100f;
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
		musicVolumeSlider.Value = Options.Config.MusicVolume * 100f;
		musicVolumeSlider.Style = "scrollSlider";
		musicVolumeSlider.Size = new Squid.Point(0, AmorousData.ButtonHeight);
		musicVolumeSlider.Button.Style = "scrollSliderButton";
		musicVolumeSlider.ValueChanged += delegate
		{
			Options.Config.MusicVolume = musicVolumeSlider.Value / 100f;
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
		soundVolumeSlider.Value = Options.Config.SfxVolume * 100f;
		soundVolumeSlider.Style = "scrollSlider";
		soundVolumeSlider.Size = new Squid.Point(0, AmorousData.ButtonHeight);
		soundVolumeSlider.Button.Style = "scrollSliderButton";
		soundVolumeSlider.ValueChanged += delegate
		{
			Options.Config.SfxVolume = soundVolumeSlider.Value / 100f;
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
		AttachDropDownList(container.Content.Controls, "Dialogue Text Speed", new string[4] { "Slow", "Normal", "Fast", "Instant" }, (int)Options.Config.DialogueTextSpeed, delegate(int answer)
		{
			Options.Config.DialogueTextSpeed = (DialogueSpeed)answer;
			TypingDialogue.Speed = (DialogueSpeed)answer;
		});
		CheckBox dialogueSkipBox = new CheckBox
		{
			Dock = DockStyle.Top,
			Text = "Dialogue Auto-skip",
			Checked = Options.Config.DialogueAutoSkip
		};
		dialogueSkipBox.CheckedChanged += delegate
		{
			Options.Config.DialogueAutoSkip = dialogueSkipBox.Checked;
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
			blocked = true;
			desktop.ShowSelection("Are you sure you wish to customize your character? This may break some active dates even if make no changes!", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, AmorousData.ShortDialogueWidth, delegate(int answer)
			{
				if (answer == 1)
				{
					Hide();
					game.StartScene<BackToPlayerCustomizationScene>();
				}
				blocked = false;
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
		game.Fader.FadeOut(delegate
		{
			string sceneName = game.Sexscene?.GetType().Name;
			if (sceneName != null)
			{
				game.ResetSexscene();
			}
			then();
			game.SwitchToScene(game.Scene.GetType().Name, delegate
			{
				if (sceneName != null)
				{
					game.PlaySexscene(sceneName);
				}
				game.Fader.FadeIn();
			});
		});
	}

	private void RequestSexscene(string name)
	{
		game.PlayCutscene(name);
		Hide();
	}

	private ListBox CreatePowerScreen()
	{
		ListBox container = CreateApplicationListBox();
		PlayerData data = PlayerPreferences.GetPlayerData();
		if (data.GetStage(AmorousData.Prologue) == AmorousData.PrologueStateCompleted)
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
				game.StartScene<BedroomScene>();
			};
			wentClubButton.MouseClick += delegate
			{
				Hide();
				game.StartScene<ClubInsideScene>();
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
			game.StartScene<MainMenuScene>();
		};
		ListBoxItem quitButton = new ListBoxItem
		{
			Text = "Quit Game",
			Size = new Squid.Point(0, 50)
		};
		quitButton.MouseClick += delegate
		{
			blocked = true;
			desktop.ShowSelection("Are you sure you wish to quit the Game? All unsaved progress will be lost!", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, AmorousData.ShortDialogueWidth, delegate(int answer)
			{
				if (answer == 1)
				{
					game.Exit();
				}
				blocked = false;
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
				if (data.GetStage(AmorousData.DustinDate) != AmorousData.DustinStateCompleted)
				{
					game.PlayCutscene(AmorousData.DustinDate);
					Hide();
				}
				else
				{
					ShowDatesCompleted(contact);
				}
				break;
			case PlayerData.EPhoneContacts.Remy:
				if (data.GetStage(AmorousData.RemyDate) != AmorousData.RemyStateCompleted)
				{
					game.PlayCutscene(AmorousData.RemyDate);
					Hide();
				}
				else
				{
					ShowDatesCompleted(contact);
				}
				break;
			case PlayerData.EPhoneContacts.Seth:
				if (data.GetStage(AmorousData.SethDate) == AmorousData.SethStateCompleted)
				{
					ShowDatesCompleted(contact);
					break;
				}
				game.PlayCutscene(AmorousData.SethDate);
				Hide();
				break;
			case PlayerData.EPhoneContacts.Skye:
				if (data.GetStage(AmorousData.SkyeDate) != AmorousData.SkyeStateCompleted)
				{
					game.PlayCutscene(AmorousData.SkyeDate);
					Hide();
				}
				else
				{
					ShowDatesCompleted(contact);
				}
				break;
			case PlayerData.EPhoneContacts.Zenith:
				if (PlayerPreferences.GetPlayerData().GetStage(AmorousData.ZenithDate) == AmorousData.ZenithStateCompleted)
				{
					ShowDatesCompleted(contact);
					break;
				}
				game.PlayCutscene(AmorousData.ZenithDate);
				Hide();
				break;
			case PlayerData.EPhoneContacts.Mercy:
				if (data.GetStage(AmorousData.MercyDate) != AmorousData.MercyStateCompleted)
				{
					game.PlayCutscene(AmorousData.MercyDate);
					Hide();
				}
				else
				{
					ShowDatesCompleted(contact);
				}
				break;
			case PlayerData.EPhoneContacts.Lex:
				if (data.GetStage(AmorousData.LexDate) == AmorousData.LexStateCompleted)
				{
					ShowDatesCompleted(contact);
					break;
				}
				game.PlayCutscene(AmorousData.LexDate);
				Hide();
				break;
			case PlayerData.EPhoneContacts.Jax:
				if (data.GetStage(AmorousData.JaxDate) == AmorousData.JaxStateCompleted)
				{
					ShowDatesCompleted(contact);
					break;
				}
				game.PlayCutscene(AmorousData.JaxDate);
				Hide();
				break;
			case PlayerData.EPhoneContacts.Coby:
				if (data.GetStage(AmorousData.CobyDate) < AmorousData.CobyStateCompleted)
				{
					game.PlayCutscene(AmorousData.CobyDate);
					Hide();
				}
				else
				{
					game.PlayCutscene(AmorousData.CobyPostDate);
				}
				break;
		}
	}

	private void ShowDatesCompleted(PlayerData.EPhoneContacts contact)
	{
		blocked = true;
		desktop.ShowConfirm($"You finished all dates with {contact.ToString()}!", AmorousData.ShortDialogueWidth, "Gotcha!", delegate
		{
			blocked = false;
		});
	}

	public void RefreshSkin()
	{
		PlayerData data = PlayerPreferences.GetPlayerData();
		bool hasLongMarkings = data.MarkingsType.HasFlag(PlayerData.EMarkingsType.LongForearm);
		bool hasShortMarkings = data.MarkingsType.HasFlag(PlayerData.EMarkingsType.ShortForearm);
		Color markingColor = hasShortMarkings ? data.ShortForearmColor : (hasLongMarkings ? data.LongForearmColor : Color.White);
		interactionSkeleton.SetAlpha("Hoody Sleeve", 0f);
		interactionSkeleton.SetAlpha("Default Forearm", 1f);
		interactionSkeleton.SetColor("Default Forearm", data.BodyColor);
		interactionSkeleton.SetAlpha("Marking Forearm", (hasShortMarkings || hasLongMarkings) ? 1 : 0);
		interactionSkeleton.SetColor("Marking Forearm", markingColor);
		interactionSkeleton.SetAlpha("Striped forearm", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1 : 0);
		interactionSkeleton.SetColor("Striped forearm", data.StripesColor);
		interactionSkeleton.SetAlpha("Avian Forearm", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
		interactionSkeleton.SetColor("Avian Forearm", data.AvianForearmColor);
		interactionSkeleton.SetAlpha("Hand", 1f);
		interactionSkeleton.SetColor("Hand", data.BodyColor);
		interactionSkeleton.SetAlpha("Marking Hand", (hasShortMarkings || hasLongMarkings) ? 1 : 0);
		interactionSkeleton.SetColor("Marking Hand", markingColor);
		interactionSkeleton.SetAlpha("Avian Hand", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
		interactionSkeleton.SetColor("Avian Hand", data.AvianForearmColor);
		interactionSkeleton.SetAlpha("Index", 1f);
		interactionSkeleton.SetColor("Index", data.BodyColor);
		interactionSkeleton.SetAlpha("Avian index", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
		interactionSkeleton.SetColor("Avian index", data.AvianForearmColor);
		interactionSkeleton.SetAlpha("Pinky", 1f);
		interactionSkeleton.SetColor("Pinky", data.BodyColor);
		interactionSkeleton.SetAlpha("Avian Pinky", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
		interactionSkeleton.SetColor("Avian Pinky", data.AvianForearmColor);
		interactionSkeleton.SetAlpha("Ring", 1f);
		interactionSkeleton.SetColor("Ring", data.BodyColor);
		interactionSkeleton.SetAlpha("Avian ring", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
		interactionSkeleton.SetColor("Avian ring", data.AvianForearmColor);
		interactionSkeleton.SetAlpha("Rude", 1f);
		interactionSkeleton.SetColor("Rude", data.BodyColor);
		interactionSkeleton.SetAlpha("Avian Rude", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
		interactionSkeleton.SetColor("Avian Rude", data.AvianForearmColor);
		interactionSkeleton.SetAlpha("Thumb", 1f);
		interactionSkeleton.SetColor("Thumb", data.BodyColor);
		interactionSkeleton.SetAlpha("Avian Thumb", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
		interactionSkeleton.SetColor("Avian Thumb", data.AvianForearmColor);
		interactionSkeleton.SetAlpha("Pinky Nail", data.ShowNails ? 1 : 0);
		interactionSkeleton.SetColor("Pinky Nail", data.NailColor);
		interactionSkeleton.SetAlpha("Ring Nail", data.ShowNails ? 1 : 0);
		interactionSkeleton.SetColor("Ring Nail", data.NailColor);
		interactionSkeleton.SetAlpha("Rude Nail", data.ShowNails ? 1 : 0);
		interactionSkeleton.SetColor("Rude Nail", data.NailColor);
		interactionSkeleton.SetAlpha("Index Nail", data.ShowNails ? 1 : 0);
		interactionSkeleton.SetColor("Index Nail", data.NailColor);
		interactionSkeleton.SetAlpha("Thumb Nail", data.ShowNails ? 1 : 0);
		interactionSkeleton.SetColor("Thumb Nail", data.NailColor);
		interactionSkeleton.SetAlpha("Phone lines", 1f);
		interactionSkeleton.SetColor("Phone lines", data.PhoneColor);
		interactionSkeleton.SetAlpha("Phone Colour", 1f);
		interactionSkeleton.SetAlpha("Phone Shadow", 1f);
		interactionSkeleton.SetAlpha("BG CONTACTS", 0f);
		interactionSkeleton.SetAlpha("BG DIARY", 0f);
		interactionSkeleton.SetAlpha("BG AUDIO", 0f);
		interactionSkeleton.SetAlpha("BG CHAT SETTINGS", 0f);
		interactionSkeleton.SetAlpha("BG GALLERY", 0f);
		interactionSkeleton.SetAlpha("BG POWER", 0f);
		interactionSkeleton.SetAlpha("Phone Default Background", 1f);
		interactionSkeleton.SetAlpha("CONTACTS", 1f);
		interactionSkeleton.SetAlpha("Diary", 1f);
		interactionSkeleton.SetAlpha("Audio", 1f);
		interactionSkeleton.SetAlpha("Chat Settings", 1f);
		interactionSkeleton.SetAlpha("Gallery", 1f);
		interactionSkeleton.SetAlpha("Power", 1f);
		interactionSkeleton.SetAlpha("white screen", 1f);
		interactionSkeleton.SetAlpha("black screen", 1f);
		interactionSkeleton.SetAlpha("Power", 1f);
		interactionSkeleton.SetAlpha("Sheen Two", 1f);
		RefreshPhoneSkin();
	}

	private void RefreshPhoneSkin()
	{
		phoneOverlaySkeleton.SetColor("Phone", PlayerPreferences.GetPlayerData().PhoneColor);
	}

	public static PhoneOverlay GetSingleton()
	{
		return singleton;
	}

	private void ShowContact(PlayerData.EPhoneContacts contact)
	{
		hiddenPhone = false;
		foreach (string key in contactSlots.Keys.ToList())
		{
			contactSlots[key] = false;
		}
		if (contact == PlayerData.EPhoneContacts.Lex)
		{
			contactSlots["Alex"] = true;
			contactSlots["Alex image"] = true;
		}
		else
		{
			contactSlots[contact.ToString()] = true;
			contactSlots[contact.ToString() + " image"] = true;
		}
	}

	private void ApplyCallingScreen(bool state)
	{
		interactionSlots["reject call with message"] = state;
		interactionSlots["Incoming call"] = state;
	}

	public void Update(GameTime gameTime, CanvasObserver canvas)
	{
		if (game.Controller.IsPressed(Microsoft.Xna.Framework.Input.Keys.Escape) || game.Controller.IsPressed(Microsoft.Xna.Framework.Input.Keys.LeftShift))
		{
			Rise();
		}
		interactionSkeleton.Update(gameTime, (game.Cutscene != null || !interactable) ? RISE_DOWN : duration);
		phoneOverlaySkeleton.Update(gameTime);
		phoneSkeleton.Update(gameTime);
		ResolvePendingRequests();
		UpdateOverlayButton(canvas);
		UpdateOverlayScreen(canvas);
		if (!hiddenPhoneScreen)
		{
			desktop.Update();
		}
	}

	private void ResolvePendingRequests()
	{
		if (changingState)
		{
			return;
		}
		if (requestedRise)
		{
			interactable = false;
			requestedRise = false;
			changingState = true;
			interactionSkeleton.StartAnimation("Arm rise", delegate
			{
				changingState = false;
				ArmPose = EArmPose.ArmUp;
				StartHoldingAnimation();
			});
		}
		else if (requestedHang)
		{
			interactable = false;
			requestedHang = false;
			changingState = true;
			interactionSkeleton.StartAnimation("Arm lower", delegate
			{
				changingState = false;
				ArmPose = EArmPose.ArmDown;
			});
		}
	}

	private void UpdateOverlayButton(CanvasObserver canvas)
	{
		if (State == EPhoneState.None || game.Cutscene != null || blocked)
		{
			return;
		}
		Microsoft.Xna.Framework.Point cursor = canvas.GlobalToContent(game.Controller.Cursor);
		if (phoneOverlaySkeleton.Innersects("Phone", cursor.X, cursor.Y))
		{
			phoneOverlaySkeleton.SetColor("Phone", Color.Red);
			AbstractScene.CapturedByOverlay = true;
			if (game.Controller.IsPressed(ControllerButtonType.LeftButton))
			{
				Rise();
			}
			closeableOutside = true;
		}
		else if (closeableOutside)
		{
			phoneOverlaySkeleton.SetColor("Phone", PlayerPreferences.GetPlayerData().PhoneColor);
			if (ArmPose == EArmPose.ArmDown || ArmPose == EArmPose.ArmDownRequested)
			{
				AbstractScene.CapturedByOverlay = false;
			}
			closeableOutside = false;
		}
	}

	private void UpdateOverlayScreen(CanvasObserver canvas)
	{
		if (ArmPose != EArmPose.ArmUp || game.Cutscene != null || blocked)
		{
			return;
		}
		Microsoft.Xna.Framework.Point cursor = canvas.GlobalToContent(game.Controller.Cursor);
		bool captured = interactionSkeleton.Innersects("Phone Colour", cursor.X, cursor.Y);
		duration = (captured ? RISE_UP : RISE_DOWN);
		if (!captured)
		{
			return;
		}
		if (game.Controller.IsPressed(ControllerButtonType.LeftButton))
		{
			if (screen == EPhoneScreen.Home)
			{
				if (interactionSkeleton.Innersects("CONTACTS", cursor.X, cursor.Y))
				{
					Open(EPhoneScreen.Contacts);
				}
				else if (interactionSkeleton.Innersects("Diary", cursor.X, cursor.Y))
				{
					Open(EPhoneScreen.Diary);
				}
				else if (interactionSkeleton.Innersects("Audio", cursor.X, cursor.Y))
				{
					Open(EPhoneScreen.Audio);
				}
				else if (interactionSkeleton.Innersects("Chat Settings", cursor.X, cursor.Y))
				{
					Open(EPhoneScreen.ChatSettings);
				}
				else if (interactionSkeleton.Innersects("Gallery", cursor.X, cursor.Y))
				{
					Open(EPhoneScreen.Gallery);
				}
				else if (interactionSkeleton.Innersects("Power", cursor.X, cursor.Y))
				{
					Open(EPhoneScreen.Power);
				}
				else if (!interactionSkeleton.Innersects("Phone Default Background", cursor.X, cursor.Y))
				{
					Hide();
				}
			}
			else if (!interactionSkeleton.Innersects("Phone Default Background", cursor.X, cursor.Y))
			{
				Back();
			}
		}
		if (game.Controller.IsPressed(ControllerButtonType.RightButton))
		{
			if (screen != 0)
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
		if (changingState || ArmPose == EArmPose.ArmUp)
		{
			RenderTargetBinding[] targets = game.Graphics.GetRenderTargets();
			game.Graphics.SetRenderTarget(phoneScreenTarget);
			desktop.Draw();
			game.Graphics.SetRenderTarget(phoneTarget);
			phoneSkeleton.Draw(skeletonMeshRenderer, null, delegate(int answer, string slotName)
			{
				if (contactSlots.ContainsKey(slotName))
				{
					return contactSlots[slotName];
				}
				return !interactionSlots.ContainsKey(slotName) || interactionSlots[slotName];
			});
			game.Graphics.SetRenderTargets(targets);
			double depth;
			Microsoft.Xna.Framework.Point sheen = interactionSkeleton.GetDistanceDepth("Sheen Two", out depth);
			interactionSkeleton.Draw(skeletonMeshRenderer, null, delegate(int index, string slotName)
			{
				if (slotName == "Sheen Two")
				{
					skeletonMeshRenderer.End();
					spriteBatch.Begin();
					if (!hiddenPhoneScreen)
					{
						spriteBatch.Draw(phoneScreenTarget, new Vector2(sheen.X, sheen.Y), null, null, null, (float)depth);
					}
					if (!hiddenPhone)
					{
						spriteBatch.Draw(phoneTarget, new Vector2(sheen.X, sheen.Y), null, null, null, (float)depth);
					}
					if (!hiddenRemyNudes)
					{
						spriteBatch.Draw(spriteOfActiveRemyNude, new Vector2(sheen.X, sheen.Y), null, null, null, (float)depth);
					}
					spriteBatch.End();
					skeletonMeshRenderer.Begin();
				}
				else if (slotName == "Thumb")
				{
					if (!hiddenGameBox)
					{
						skeletonMeshRenderer.End();
						spriteBatch.Begin();
						spriteBatch.Draw(spriteOfActiveGamebox, new Vector2(sheen.X - 16, sheen.Y - 128), null, null, null, (float)depth);
						spriteBatch.End();
						skeletonMeshRenderer.Begin();
					}
				}
				else if (!hiddenGameBox && PLAYER_NAILS.Contains(slotName))
				{
					return false;
				}
				return true;
			});
		}
		if (state != 0 && game.Cutscene == null)
		{
			phoneOverlaySkeleton.Draw(skeletonMeshRenderer);
		}
	}
}
