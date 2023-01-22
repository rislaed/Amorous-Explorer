using System;
using System.Reflection;
using Microsoft.Xna.Framework.Graphics;

public static class _XlQgilk5wbs9pucgf8gEovko2zf
{
	private static readonly PropertyInfo _2m1r1A4nAJ2cK1CdX6V7NfWkAWv = typeof(RenderTarget2D).GetProperty("RenderTargetUsage", BindingFlags.Instance | BindingFlags.Public);

	public static void _w2YD42TXOY22EP4Mpp7wzDUO4xv(this RenderTarget2D renderTarget2D_0, RenderTargetUsage renderTargetUsage_0)
	{
		_2m1r1A4nAJ2cK1CdX6V7NfWkAWv.SetValue(renderTarget2D_0, renderTargetUsage_0, null);
	}
}
