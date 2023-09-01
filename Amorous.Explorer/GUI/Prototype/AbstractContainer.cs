using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Squid;

namespace Amorous.Explorer.GUI.Prototype;

public abstract class AbstractContainer<TFragment, TData> : IContainer where TFragment : IFragment
{
	public abstract TFragment Fragment { get; protected set; }
	IFragment IContainer.Fragment => Fragment;
	public IFragment Parent { get; protected set; }
	public TData Data { get; protected set; }
	public virtual bool IsAttached => Fragment?.IsAttached ?? false;
	public AbstractDesktop Desktop => Fragment?.Desktop;
	public IControlContainer Root => Fragment?.Root;
	public Control Container => Fragment?.Container;
	public int IndexOfContainer => Fragment?.IndexOfContainer ?? -1;
	public IEnumerable<Control> Controls => Fragment?.Controls;
	public IEnumerable<Control> Subcontrols => Fragment?.Subcontrols;
	public IEnumerable<IFragment> Fragments => Fragment?.Fragments;
	public IEnumerable<IFragment> Subfragments => Fragment?.Subfragments;
	public IEnumerable<IContainer> Containers => Fragments?.OfType<IContainer>();
	public IEnumerable<IContainer> Subcontainers => Subfragments?.OfType<IContainer>();
	bool IFragment.IsReattaching { get => Fragment?.IsReattaching ?? false; set { if (Fragment is IFragment fragment) fragment.IsReattaching = value; } }
	protected bool IsReattaching { get => (this as IFragment).IsReattaching; set => (this as IFragment).IsReattaching = value; }
	public bool Initialized => Fragment?.Initialized ?? true;
	public object Tag { get => Fragment?.Tag; set { if (Fragment is IFragment fragment) fragment.Tag = value; } }
	public object this[string key] { get => Fragment?[key]; set { if (Fragment is IFragment fragment) fragment[key] = value; } }

	public FragmentEvent OnBegin { get => Fragment?.OnBegin; set { if (Fragment is IFragment fragment) fragment.OnBegin += value; } }
	public FragmentAttachEvent OnBeforePrepareToAttach { get => Fragment?.OnBeforePrepareToAttach; set { if (Fragment is IFragment fragment) fragment.OnBeforePrepareToAttach += value; } }
	public FragmentAttachEvent OnBeforeAttach { get => Fragment?.OnBeforeAttach; set { if (Fragment is IFragment fragment) fragment.OnBeforeAttach += value; } }
	public FragmentAttachEvent OnAttach { get => Fragment?.OnAttach; set { if (Fragment is IFragment fragment) fragment.OnAttach += value; } }
	public FragmentAttachEvent OnBeforeDeattach { get => Fragment?.OnBeforeDeattach; set { if (Fragment is IFragment fragment) fragment.OnBeforeDeattach += value; } }
	public FragmentAttachEvent OnDeattach { get => Fragment?.OnDeattach; set { if (Fragment is IFragment fragment) fragment.OnDeattach += value; } }
	public FragmentRefreshEvent OnUpdate { get => Fragment?.OnUpdate; set { if (Fragment is IFragment fragment) fragment.OnUpdate += value; } }
	public FragmentRefreshEvent OnDraw { get => Fragment?.OnDraw; set { if (Fragment is IFragment fragment) fragment.OnDraw += value; } }

	public AbstractContainer(AbstractDesktop desktop = null)
	{
		if (desktop != null)
		{
			Begin(desktop);
		}
	}

	public virtual Control GetControl(string key) => Fragment?.GetControl(key);
	public virtual IFragment GetFragment(string key) => Fragment?.GetFragment(key);
	public IContainer GetContainer(string key) => Fragment?.GetFragment(key) as IContainer;
	public AbstractContainer<T, K> GetContainer<T, K>(string key) where T : IFragment => GetContainer(key) as AbstractContainer<T, K>;
	public virtual void Begin(AbstractDesktop desktop) => Fragment?.Begin(desktop);
	public virtual void Provide(TData data) => Data = data;
	public virtual void Update(GameTime gameTime) => Fragment?.Update(gameTime);
	public virtual void Draw(GameTime gameTime) => Fragment?.Draw(gameTime);
	public void Reattach(IControlContainer container, IFragment fragment = null, Action<IFragment> then = null) => Reattach(container, default(TData), fragment, then);

	public virtual void Reattach(IControlContainer container = null, TData data = default(TData), IFragment fragment = null, Action<IFragment> then = null)
	{
		container = container ?? Root;
		if (container == null)
		{
			return;
		}
		fragment = fragment ?? Parent;
		IsReattaching = container == Root;
		Deattach();
		Provide(data ?? Data);
		InternalReattach(container, data, fragment);
		then?.Invoke(this);
		AttachInContainer(container, fragment);
		IsReattaching = false;
	}

	public virtual void Deattach()
	{
		Fragment?.Deattach();
		Parent = null;
	}

	public void AttachInContainer(IControlContainer container, IFragment fragment = null)
	{
		fragment = fragment ?? Parent;
		if (fragment != Parent || IsAttached)
		{
			Deattach();
		}
		Parent = fragment;
		InternalPrepareToAttach(container, fragment);
		Fragment?.AttachInContainer(container, this);
		InternalAttach(container, fragment);
	}

	public void PrepareToAttach(IControlContainer container, IFragment fragment = null)
	{
		fragment = fragment ?? Parent;
		InternalPrepareToAttach(container, fragment);
		Fragment?.PrepareToAttach(container, this);
	}

	public void Attach(IControlContainer container, IFragment fragment = null)
	{
		fragment = fragment ?? Parent;
		if (Root != container || Parent != fragment)
		{
			AttachInContainer(container, fragment);
			return;
		}
		Parent = fragment;
		Fragment?.Attach(container, this);
		InternalAttach(container, fragment);
	}

	protected virtual void InternalPrepareToAttach(IControlContainer container, IFragment fragment = null) {}
	protected virtual void InternalAttach(IControlContainer container, IFragment fragment = null) {}
	protected virtual void InternalReattach(IControlContainer container = null, TData data = default(TData), IFragment fragment = null) {}

	protected void UpdateSelectionByTag(IEnumerable<Control> controls, object tag)
	{
		foreach (Control control in controls.OfType<ICheckable>())
		{
			if (control.Tag == tag)
			{
				control.Style = "buttonOpaqueSelected";
			}
			else if (control.Style == "buttonOpaqueSelected")
			{
				control.Style = "buttonOpaqueCheckable";
			}
		}
	}

	protected void UpdateSelectionByText(IEnumerable<Control> controls, string text)
	{
		foreach (Control control in controls.OfType<IText>())
		{
			if ((control as IText).Text == text)
			{
				control.Style = "buttonOpaqueSelected";
			}
			else if (control.Style == "buttonOpaqueSelected")
			{
				control.Style = "buttonOpaqueCheckable";
			}
		}
	}

	IEnumerator<KeyValuePair<string, object>> IEnumerable<KeyValuePair<string, object>>.GetEnumerator() => Fragment?.GetEnumerator();
	IEnumerator IEnumerable.GetEnumerator() => (Fragment as IEnumerable)?.GetEnumerator();
}
