using Amorous.Explorer.GUI.Prototype;
using Squid;

namespace Amorous.Explorer.GUI.View;

public class ModalWindow : Window
{
	public IFragment Fragment { get; protected set; }

	public ModalWindow()
	{
		base.Modal = true;
		base.Visible = false;
	}

	protected override void OnUpdate()
	{
		base.OnUpdate();
		if (AmorousExplorer.Singleton.Amorous.Controller.IsPressed(Microsoft.Xna.Framework.Input.Keys.Escape))
		{
			Close();
		}
	}

	public override void Show(Desktop desktop)
	{
		Show(desktop, null);
	}

	public virtual void Show(Desktop desktop, IFragment fragment, IFragment parent = null)
	{
		if ((Fragment = fragment) != null)
		{
			fragment.AttachInContainer(this, parent);
		}
		base.Show(desktop);
	}

	public override void Close()
	{
		base.Close();
		if (Fragment != null)
		{
			Fragment.Deattach();
			Fragment = null;
		}
	}
}
