using System.Reflection;
using Microsoft.Xna.Framework.Graphics;

public static class RenderTargetExtenstions
{ // _XlQgilk5wbs9pucgf8gEovko2zf
	private static readonly PropertyInfo RenderTargetUsagePtr = typeof(RenderTarget2D).GetProperty("RenderTargetUsage", BindingFlags.Instance | BindingFlags.Public);

	public static void SetUsage(this RenderTarget2D target, RenderTargetUsage usage)
	{
		RenderTargetUsagePtr.SetValue(target, usage, null);
	}
}
