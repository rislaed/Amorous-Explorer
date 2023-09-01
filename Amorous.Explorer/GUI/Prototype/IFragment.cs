using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Squid;

namespace Amorous.Explorer.GUI.Prototype;

public delegate void FragmentEvent(IFragment fragment);
public delegate void FragmentAttachEvent(IFragment fragment, IControlContainer container, IFragment parent);
public delegate void FragmentRefreshEvent(IFragment fragment, GameTime gameTime);

public interface IFragment : IEnumerable<KeyValuePair<string, object>>
{
	public object this[string key] { get; set; }
	public AbstractDesktop Desktop { get; }
	public IControlContainer Root { get; }
	public IFragment Parent { get; }
	public Control Container { get; }
	public int IndexOfContainer { get; }
	public bool IsAttached { get; }
	public IEnumerable<Control> Controls { get; }
	public IEnumerable<Control> Subcontrols { get; }
	public IEnumerable<IFragment> Fragments { get; }
	public IEnumerable<IFragment> Subfragments { get; }
	internal bool IsReattaching { get; set; }
	public bool Initialized { get; }
	public object Tag { get; set; }
	public FragmentEvent OnBegin { get; set; }
	public FragmentAttachEvent OnBeforePrepareToAttach { get; set; }
	public FragmentAttachEvent OnBeforeAttach { get; set; }
	public FragmentAttachEvent OnAttach { get; set; }
	public FragmentAttachEvent OnBeforeDeattach { get; set; }
	public FragmentAttachEvent OnDeattach { get; set; }
	public FragmentRefreshEvent OnUpdate { get; set; }
	public FragmentRefreshEvent OnDraw { get; set; }
	public Control GetControl(string key);
	public IFragment GetFragment(string key);
	public void Begin(AbstractDesktop desktop = null);
	public void AttachInContainer(IControlContainer container, IFragment fragment = null);
	public void Attach(IControlContainer container, IFragment fragment = null);
	public void PrepareToAttach(IControlContainer container, IFragment fragment = null);
	public void Reattach(IControlContainer container = null, IFragment fragment = null, Action<IFragment> then = null);
	public void Update(GameTime gameTime);
	public void Draw(GameTime gameTime);
	public void Deattach();
}
