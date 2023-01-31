using System.Reflection;
using Microsoft.Xna.Framework.Graphics;

public static class ExtendedRenderTarget2D
{ // _XlQgilk5wbs9pucgf8gEovko2zf
	private static readonly PropertyInfo _renderTargetUsage = typeof(RenderTarget2D).GetProperty("RenderTargetUsage", BindingFlags.Instance | BindingFlags.Public);

	public static void SetUsage(this RenderTarget2D target, RenderTargetUsage usage)
	{
		_renderTargetUsage.SetValue(target, usage, null);
	}
}
