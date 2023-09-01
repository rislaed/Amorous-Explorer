using System.Reflection;
using Microsoft.Xna.Framework;

namespace Amorous.Explorer.Specialized;

public static class AbstractNPCExtensions
{
	public static Rectangle GetBounds(this AbstractNPC npc)
	{
		Rectangle rectangle = new Rectangle(
			(int)npc.X,
			(int)npc.Y,
			(int)((float)npc.Width * npc.Scale),
			(int)((float)npc.Height * npc.Scale)
		);
		if (npc is AbstractSpineNPC)
		{
			rectangle.X -= npc.Width / 2;
			rectangle.Y -= npc.Height;
		}
		return rectangle;
	}

	private static SpineRectangle GetSkeletonBounds(this AbstractSpineNPC npc)
	{
		return (SpineRectangle)typeof(AbstractSpineNPC).GetField("bounds", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(npc);
	}

	public static Rectangle GetInternalBounds(this AbstractNPC npc)
	{
		if (npc is AbstractSpineNPC skeleton)
		{
			SpineRectangle origin = skeleton.GetSkeletonBounds();
			return new Rectangle((int)origin.Left, (int)origin.Top, (int)origin.Width, (int)origin.Height);
		}
		return npc.GetBounds();
	}
}
