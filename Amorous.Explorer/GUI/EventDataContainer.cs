using System;
using System.Collections.Generic;
using System.Globalization;
using Amorous.Engine.Data.Cutscenes;
using Amorous.Explorer.Data;
using Amorous.Explorer.GUI.Json;
using Amorous.Explorer.GUI.Prototype;
using Amorous.Explorer.GUI.View.Inherits;
using Amorous.Explorer.Reflection;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Squid;

namespace Amorous.Explorer.GUI;

public class EventDataContainer : JsonContainer
{
	public override IDictionary<string, Json.JsonProperty> Properties { get; set; } = new LinkedDictionary<string, Json.JsonProperty>() {
		["ID"] = new NumberJsonProperty()
		{
			Disabled = true
		},
		["DebugID"] = new PackedNumberJsonProperty()
		{
			Disabled = false
		},
		["SFWID"] = new NumberJsonProperty()
		{
			Name = "Safe For Work ID"
		},
		["NSFWID"] = new NumberJsonProperty()
		{
			Name = "Not Safe For Work ID"
		},
		["Delay"] = new NumberJsonProperty()
		{
			Minimum = 0,
			Maximum = 120,
			Steps = 10f,
			Multiplier = 1000
		},
		["Text"] = new TextJsonProperty()
		{
			IsMultiline = true
		}
	};

	public class ExternalPropertyFragment : JsonPropertyFragment<Json.JsonProperty>
	{
		protected Action<JToken, ExternalPropertyFragment> Then { get; set; }
		protected Button Button => this["button"] as Button;

		public bool Checked { get => Button?.Checked ?? false; set { if (Button != null) Button.Checked = value; } }
		public string Text { get; protected set; }
		public Func<string, string> Stringify { get; set; } = (value) => value.ToPersonReadable();
		public object Synced
		{
			get => synced;
			set
			{
				synced = value;
				Reattach();
			}
		}

		public ExternalPropertyFragment(JToken token, Action<JToken, ExternalPropertyFragment> then, AbstractDesktop desktop = null) : base(token, desktop)
		{
			Then = then;
		}

		private object synced;

		protected virtual void ChangeSelection()
		{
			if (Then != null)
			{
				Then.Invoke(Token, this);
			}
		}

		protected override void InternalConstructLayout()
		{
			bool locked = Checked;
			synced = Synced ?? Value?.Value;
			Text = Convert.ToString(Synced, CultureInfo.InvariantCulture);
			RequiresLabel = Nullable || !string.IsNullOrEmpty(Text);
			base.InternalConstructLayout();
			Button button = new AmorousButton()
			{
				Style = "buttonOpaqueCheckable",
				Text = RequiresLabel ? Stringify.Invoke(Text) : Name.ToPersonReadable(),
				CheckOnClick = true,
				Checked = locked,
				AutoEllipsis = true,
				AutoSize = AutoSize.Horizontal
			};
			button.CheckedChanged += (control) => ChangeSelection();
			this["button"] = button;
		}

		protected override JToken Sync(JContainer container, object key)
		{
			if (Nullable || Synced != null)
			{
				return new JValue(Synced);
			}
			throw new InvalidOperationException();
		}

		protected override void InternalApply(Json.JsonProperty properties)
		{
		}
	}

	public class DictionaryExpectablePropertyFragment : ExternalPropertyFragment
	{
		public string Expectable { get; set; }
		public ChoiceMode Mode { get; set; } = ChoiceMode.None;
		public Func<object, object> Resolve { get; set; }
		public Func<string, string[]> Select { get; set; }

		public DictionaryExpectablePropertyFragment(JToken token, string expectable, AbstractDesktop desktop = null) : base(token, null, desktop)
		{
			Expectable = expectable;
		}

		protected override void ChangeSelection()
		{
			if (Checked)
			{
				Frame.Lock();
				string selectedItem = RequiresLabel ? Button.Text : Text;
				(Desktop as StartupDesktop).ListingContainer.TryExpect(Expectable, delegate(object who)
				{
					Synced = Resolve != null ? Resolve.Invoke(who) : who;
					if (Mode == ChoiceMode.None)
					{
						Checked = false;
					}
				}, Mode, Select != null ? Select.Invoke(selectedItem) : new string[] { selectedItem });
			}
			else
			{
				Unlock();
			}
		}

		public virtual void Unlock()
		{
			if (!Nullable && Synced == null)
			{
				Checked = true;
				return;
			}
			Checked = false;
			(Desktop as StartupDesktop).ListingContainer.Deexpect();
			Frame.Unlock();
		}
	}

	protected StartupDesktop StartupDesktop => Desktop as StartupDesktop;

	public EventDataContainer(AbstractDesktop desktop = null) : base(desktop) {}

	protected override void InspectText(JToken token, JsonContract contract)
	{
		if (ContractOfContainer(token)?.CreatedType is Type type)
		{
			string property = token.ToPropertyName();
			if (property == "SceneName")
			{
				if (type == typeof(PlaySexsceneEventData))
				{
					this[token.Path] = new DictionaryExpectablePropertyFragment(token, "Sexscenes")
					{
						Name = "Sexscene",
						Resolve = (who) => (who as Type)?.Name,
						Stringify = (value) => value.TrimSuffix("Sexscene").ToPersonReadable(),
						Contract = contract
					};
					return;
				}
				else if (type == typeof(SwitchToSceneEventData))
				{
					this[token.Path] = new DictionaryExpectablePropertyFragment(token, "Scenes")
					{
						Name = "Scene",
						Resolve = (who) => (who as Type)?.Name,
						Stringify = (value) => value.TrimSuffix("Scene").ToPersonReadable(),
						Contract = contract
					};
					return;
				}
			}
			else if (property == "SubsceneName")
			{
				if (type == typeof(SwitchToSubsceneEventData))
				{
					this[token.Path] = new DictionaryExpectablePropertyFragment(token, "Subscenes")
					{
						Name = "Subscene",
						Contract = contract
					};
					return;
				}
			}
			else if (property == "Contact")
			{
				if (type == typeof(DisableContactEventData) || typeof(UnlockContactEventData).IsAssignableFrom(type))
				{
					this[token.Path] = new DictionaryExpectablePropertyFragment(token, "Contacts")
					{
						Mode = type == typeof(DisableContactEventData) ? ChoiceMode.Combine : ChoiceMode.None,
						Select = (what) => what.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries),
						Contract = contract
					};
					return;
				}
			}
		}
		base.InspectText(token, contract);
	}

	protected override void InspectNumber(JToken token, JsonContract contract)
	{
		if (ContractOfContainer(token)?.CreatedType is Type type && typeof(EventData).IsAssignableFrom(type))
		{
			string property = token.ToPropertyName();
			if (property == "DebugID")
			{
				this[token.Path] = new PackedNumberPropertyFragment(token, new byte[] { 24, 8 })
				{
					Contract = contract
				};
				return;
			}
		}
		base.InspectNumber(token, contract);
	}
}
