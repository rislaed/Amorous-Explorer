using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Amorous.Explorer.Data;
using Amorous.Explorer.GUI.Json;
using Amorous.Explorer.GUI.Model;
using Amorous.Explorer.GUI.Prototype;
using Amorous.Explorer.GUI.View.Inherits;
using Amorous.Explorer.Reflection;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json.Linq;
using Squid;

namespace Amorous.Explorer.GUI;

public class LayerContainer : AbstractContainer<TabbedListFragment, object>
{
	public override TabbedListFragment Fragment { get; protected set; } = new TabbedListFragment()
	{
		["Layers"] = new IndevFragment(),
		["NPCs"] = new IndevFragment(),
		["Interactables"] = new IndevFragment(),
		["Miscellaneous"] = new Fragment()
		{}
	};

	protected StartupDesktop StartupDesktop => Desktop as StartupDesktop;

	public LayerContainer(AbstractDesktop desktop = null) : base(desktop)
	{
		Fragment["Layers"] = InstantiateList(
			Convertions.SkipUnimplemented(Assemblies.ResolveClassesOfType<AbstractLayer>())
				.SelectMany((pair) => pair.Value)
				.ToDictionary((type) => $"Add {type.Name.ToPersonReadable()}"),
			InstantiateAbstractLayer
		);
		Fragment["NPCs"] = InstantiateList(
			new string[] { "Spawn NPC" }.ToDictionary((name) => name),
			(_) => StartupDesktop.ListingContainer.TryExpect("NPCs", (type) => StartupDesktop.AttachSpawnDialogueNPC((Type)type))
		);
		Fragment["Interactables"] = InstantiateList(
			Convertions.SkipUnimplemented(Assemblies.ResolveClassesOfType<AbstractInteractable>())
				.SelectMany((pair) => pair.Value)
				.ToDictionary((type) => $"Add {type.Name.ToPersonReadable()}"),
			InstantiateAbstractInteractable
		);
	}

	protected Fragment InstantiateList<TValue>(IDictionary<string, TValue> actions, Action<TValue> then = null)
	{
		IDictionary<string, object> subactions = Convertions.ToObjectDictionary(actions);
		KeyValuePair<string, object> primary = subactions.FirstOrDefault();
		subactions.Remove(primary);
		Fragment fragment = new Fragment()
		{
			["Miscellaneous"] = new FrameFragment()
			{
				Dock = DockStyle.Bottom,
				["Primary"] = new FrameFragment()
				{
					["Show More"] = new AmorousButton()
					{
						Visible = subactions.Count > 0,
						Style = "buttonOpaqueCheckable",
						Size = new Squid.Point(30, 30),
						Dock = DockStyle.Right,
						CheckOnClick = true
					},
					["Do Stuff"] = new AmorousButton()
					{
						Dock = DockStyle.Fill,
						Text = primary.Key.ToPersonReadable()
					}
				},
				["Actions"] = new ListFragment()
				{
					Visible = false,
					TaggedItems = subactions,
					OnSelect = (self, key) => {
						subactions.Add(primary);
						primary = subactions.FirstOrDefault((pair) => pair.Key == key);
						subactions.Remove(primary);
						((Button)self.Parent.GetControl("Do Stuff")).Text = key.ToPersonReadable();
						((ListFragment)self).TaggedItems = subactions;
						((ICheckable)self.Parent.GetControl("Show More")).Checked = false;
						then?.Invoke((TValue)primary.Value);
					}
				}
			},
			["List"] = new ListFragment()
			{
				Mode = ChoiceMode.Single
			}
		};
		((Button)fragment.GetControl("Show More")).CheckedChanged += (control)
			=> ((FrameFragment)fragment.GetFragment("Actions")).Visible = ((ICheckable)control).Checked;
		fragment.GetControl("Do Stuff").MouseClick += (control, eventArgs) => {
			if (eventArgs.Button <= 0)
			{
				((ICheckable)fragment.GetControl("Show More")).Checked = false;
				then?.Invoke((TValue)primary.Value);
			}
		};
		return fragment;
	}

	public static IDictionary<string, object>[] ToParameterDictionary(ConstructorInfo[] constructors)
	{
		IDictionary<string, object>[] constructorParameters = new IDictionary<string, object>[constructors.Length];
		int index = 0;
		foreach (ConstructorInfo constructor in constructors)
		{
			constructorParameters[index] = new Dictionary<string, object>();
			foreach (KeyValuePair<string, object> pair in Assemblies.ResolveMethodParameterDictionary(constructor))
			{
				try
				{
					Type parameter = (Type)pair.Value;
					if (Type.GetTypeCode(parameter) != TypeCode.Object)
					{
						constructorParameters[index][pair.Key] = parameter == typeof(string) ? string.Empty : CreateDefaultInstance(parameter);
					}
					else
					{
						if (parameter == typeof(SpriteFont) || typeof(Texture2D).IsAssignableFrom(parameter))
						{
							constructorParameters[index][pair.Key] = string.Empty;
							continue;
						}
						constructorParameters[index][pair.Key] = Activator.CreateInstance(parameter);
					}
				}
				catch (Exception)
				{
					constructorParameters[index][pair.Key] = null;
				}
			}
			index++;
		}
		return constructorParameters;
	}

	protected void MergeParametersWithAmorous(ref object[] parameters, ConstructorInfo constructor)
	{
		ParameterInfo[] parameterInfos = constructor.GetParameters();
		for (int i = 0; i < parameters.Length; i++)
		{
			Type type = parameterInfos[i].ParameterType;
			if (typeof(Texture2D).IsAssignableFrom(type))
			{
				parameters[i] = Desktop.Explorer.Amorous.Content.Load<Texture2D>((string)parameters[i]);
			}
			else if (type == typeof(SpriteFont))
			{
				parameters[i] = Desktop.Explorer.Amorous.Content.Load<SpriteFont>((string)parameters[i]);
			}
			else
			{
				parameters[i] = parameters[i] ?? parameterInfos[i].DefaultValue;
				if (parameters[i] == null)
				{
					if (typeof(IAmorous).IsAssignableFrom(type))
					{
						parameters[i] = Desktop.Explorer.Amorous;
					}
					else if (typeof(AbstractScene).IsAssignableFrom(type))
					{
						parameters[i] = Desktop.Explorer.Amorous.Scene;
					}
					else if (typeof(AbstractSexscene).IsAssignableFrom(type))
					{
						parameters[i] = Desktop.Explorer.Amorous.Sexscene;
					}
					else if (typeof(Cutscene).IsAssignableFrom(type))
					{
						parameters[i] = Desktop.Explorer.Amorous.Cutscene;
					}
					else
					{
						Logger.Log("... who is " + type.FullName + "?");
					}
				}
			}
		}
	}

	private static object CreateDefaultInstance<T>() => default(T);
	protected static object CreateDefaultInstance(Type type) => typeof(LayerContainer).GetMethod("CreateDefaultInstance", BindingFlags.NonPublic | BindingFlags.Static).MakeGenericMethod(new Type[] { type }).Invoke(null, new object[0]);

	protected virtual void RequestTypeInstantiate(Type type, Action<ConstructorInfo, object[]> then)
	{
		ConstructorInfo[] constructors = type.GetConstructors();
		IDictionary<string, object>[] constructorParameters = ToParameterDictionary(constructors);
		JsonContainer container = new JsonContainer(Desktop)
		{
			Title = $"New {type.Name.ToPersonReadable()}",
			OnApply = delegate(JsonContainer container, object value)
			{
				IDictionary<string, object>[] parameters = (IDictionary<string, object>[])value;
				if (!(container.Token is JArray array))
				{
					throw new AggregateException();
				}
				JToken token = container.Subtoken;
				while (token != null && token != container.Token)
				{
					token = token.Parent;
				}
				int index = token != null ? array.IndexOf(token) : -1;
				if (index != -1)
				{
					object[] values = parameters[index].Values.ToArray();
					MergeParametersWithAmorous(ref values, constructors[index]);
					then.Invoke(constructors[index], values);
					StartupDesktop.DeattachConstructor();
				}
			}
		};
		container.Provide(constructorParameters);
		container.SwitchToSubtoken("[0]");
		StartupDesktop.AttachJsonContainer(container, null);
	}

	protected virtual void InstantiateAbstractLayer(Type type)
	{
		RequestTypeInstantiate(type, (constructor, parameters) => {
			AbstractLayer layer = (AbstractLayer)constructor.Invoke(parameters);
			StartupDesktop.Explorer.Amorous.Scene.AddLayer(layer, AbstractScene.ORDER_BACKGROUND);
		});
	}

	protected virtual void InstantiateAbstractInteractable(Type type)
	{
		RequestTypeInstantiate(type, (constructor, parameters) => {
			AbstractInteractable interactable = (AbstractInteractable)constructor.Invoke(parameters);
			StartupDesktop.Explorer.Amorous.Overlay.Interactables.Add(interactable);
		});
	}
}
