using System;
using System.Collections.Generic;
using System.Linq;
using Amorous.Explorer.GUI.Prototype;
using Amorous.Explorer.Reflection;
using Microsoft.Xna.Framework;
using Squid;

namespace Amorous.Explorer.GUI.Model;

public class Fragment : LinkedDictionary<string, object>, IFragment
{
	public AbstractDesktop Desktop { get; private set; }
	public IControlContainer Root { get; protected set; }
	public IFragment Parent { get; protected set; }
	protected virtual IControlContainer Subcontainer => Root;
	public Control Container => Subcontainer as Control;
	public bool IsAttached { get; protected set; }
	public IEnumerable<Control> Controls => Values.OfType<Control>();
	public IEnumerable<Control> Subcontrols => Controls.Concat(Fragments.SelectMany((fragment) => fragment.Subcontrols));
	public IEnumerable<IFragment> Fragments => Values.OfType<IFragment>();
	public IEnumerable<IFragment> Subfragments => Fragments.Concat(Fragments.SelectMany((fragment) => fragment.Subfragments));
	public bool Initialized => initialized && Fragments.All((fragment) => fragment.Initialized);
	protected bool IsReattaching { get; set; }
	bool IFragment.IsReattaching { get => IsReattaching; set => IsReattaching = value; }
	public object Tag { get; set; }

	protected readonly Stack<object> AttachedElements = new Stack<object>();

	public FragmentEvent OnBegin { get; set; }
	public FragmentAttachEvent OnBeforePrepareToAttach { get; set; }
	public FragmentAttachEvent OnBeforeAttach { get; set; }
	public FragmentAttachEvent OnAttach { get; set; }
	public FragmentAttachEvent OnBeforeDeattach { get; set; }
	public FragmentAttachEvent OnDeattach { get; set; }
	public FragmentRefreshEvent OnUpdate { get; set; }
	public FragmentRefreshEvent OnDraw { get; set; }

	public int IndexOfContainer
	{
		get
		{
			if (Subcontainer != null)
			{
				IEnumerable<Control> controls = Subcontrols.Where((control) => control.Parent == Subcontainer);
				if (controls.Count() > 0)
				{
					return controls.Min((control) => Subcontainer.Controls.IndexOf(control));
				}
			}
			return -1;
		}
	}

	public Margin Padding
	{
		get => Container?.Padding ?? new Margin(0);
		set
		{
			if (Container != null)
			{
				Container.Padding = value;
			}
		}
	}

	private bool initialized;

	public Fragment(AbstractDesktop desktop = null)
	{
		Desktop = desktop;
	}

	public override string NewKeyOf(object item)
	{
		if (item is Control control)
		{
			return control != null ? $"{control.GetType().Name}{control.AutoId}" : null;
		}
		else if (item is IFragment fragment)
		{
			return item != null ? $"{item.ToString()}{item.GetHashCode()}" : null;
		}
		return null;
	}

	public Control GetControl(string key) => this[key] as Control ?? Fragments.FirstOrDefault((fragment) => fragment?.GetControl(key) != null)?.GetControl(key);
	public IFragment GetFragment(string key) => this[key] as IFragment ?? Fragments.FirstOrDefault((fragment) => fragment?.GetFragment(key) != null)?.GetFragment(key);

	public void Begin(AbstractDesktop desktop = null)
	{
		Desktop = desktop ?? Desktop;
		if (Desktop == null)
		{
			throw new ArgumentNullException("desktop");
		}
		if (!Initialized)
		{
			InternalBegin();
			OnBegin?.Invoke(this);
			initialized = true;
		}
	}

	protected virtual void InternalBegin()
	{
		foreach (IFragment fragment in Fragments)
		{
			fragment.Begin(Desktop ?? fragment.Desktop);
		}
	}

	public void AttachInContainer(IControlContainer container, IFragment fragment = null)
	{
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		if (IsAttached)
		{
			Deattach();
		}
		else
		{
			Begin();
		}
		PrepareToAttach(container, fragment);
		if (!Initialized)
		{
			Begin();
		}
		Attach(container, fragment);
	}

	public void Attach(IControlContainer container, IFragment fragment = null)
	{
		if (!Initialized)
		{
			throw new InvalidOperationException("Attaching to container before calling PrepareToAttach!");
		}
		if (Root != container || Parent != fragment)
		{
			AttachInContainer(container, fragment);
			return;
		}
		if (IsAttached)
		{
			return;
		}
		OnBeforeAttach?.Invoke(this, Subcontainer ?? container, Parent ?? fragment);
		InternalAttach();
		IsAttached = true;
		OnAttach?.Invoke(this, Subcontainer ?? container, Parent ?? fragment);
	}

	protected virtual void InternalAttach()
	{
		foreach (object item in Values)
		{
			if (item is Control control)
			{
				Subcontainer.Controls.Add(control);
			}
			else if (item is IFragment fragment)
			{
				fragment.Attach(Subcontainer ?? fragment.Root, this);
			}
			AttachedElements.Push(item);
		}
	}

	public void PrepareToAttach(IControlContainer container, IFragment fragment = null)
	{
		Root = container;
		Parent = fragment;
		OnBeforePrepareToAttach?.Invoke(this, Subcontainer ?? Root, Parent);
		InternalPrepareToAttach();
	}

	protected virtual void InternalPrepareToAttach()
	{
		foreach (IFragment fragment in Fragments)
		{
			fragment.PrepareToAttach(Subcontainer ?? fragment.Root, this);
		}
	}

	public virtual void Update(GameTime gameTime)
	{
		if (!IsAttached)
		{
			throw new InvalidOperationException();
		}
		foreach (IFragment fragment in Fragments)
		{
			if (fragment.IsAttached)
			{
				fragment.Update(gameTime);
			}
		}
		OnUpdate?.Invoke(this, gameTime);
	}

	public virtual void Draw(GameTime gameTime)
	{
		if (!IsAttached)
		{
			throw new InvalidOperationException();
		}
		foreach (IFragment fragment in Fragments)
		{
			if (fragment.IsAttached)
			{
				fragment.Draw(gameTime);
			}
		}
		OnDraw?.Invoke(this, gameTime);
	}

	public void Deattach()
	{
		if (!IsAttached)
		{
			return;
		}
		IsAttached = false;
		OnBeforeDeattach?.Invoke(this, Subcontainer, Parent);
		InternalDeattach();
		OnDeattach?.Invoke(this, Subcontainer, Parent);
		Root = (Parent = null) as IControlContainer;
	}

	protected virtual void InternalDeattach()
	{
		while (AttachedElements.Count > 0)
		{
			object item = AttachedElements.Pop();
			if (item is Control control)
			{
				Subcontainer.Controls.Remove(control);
			}
			else if (item is IFragment fragment)
			{
				fragment.Deattach();
			}
		}
	}

	public virtual void Reattach(IControlContainer container = null, IFragment fragment = null, Action<IFragment> then = null)
	{
		container = container ?? Root;
		if (container == null)
		{
			return;
		}
		fragment = fragment ?? Parent;
		IsReattaching = container == Root;
		Deattach();
		then?.Invoke(this);
		AttachInContainer(container, fragment);
		IsReattaching = false;
	}
}
