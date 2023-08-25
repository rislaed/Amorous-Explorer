using System;
using Spine;

public class SpineRectangle
{ // _NxPDyghimJKCwBg53DaNTazjQ5k
	private readonly ExposedList<Polygon> buffer;
	private readonly ExposedList<Polygon> polygons;

	public float Left { get; private set; }
	public float Top { get; private set; }
	public float Right { get; private set; }
	public float Bottom { get; private set; }
	public float Width => Right - Left;
	public float Height => Bottom - Top;

	public SpineRectangle()
	{
		buffer = new ExposedList<Polygon>();
		polygons = new ExposedList<Polygon>();
	}

	public void Update(Skeleton skeleton)
	{
		buffer.AddRange(polygons);
		polygons.Clear();
		ExposedList<Slot> slots = skeleton.Slots;
		int count = slots.Count;
		for (int i = 0; i < count; i++)
		{
			Slot slot = slots.Items[i];
			if (slot.A <= 0f)
			{
				continue;
			}
			if (!(slot.Attachment is RegionAttachment))
			{
				if (slot.Attachment is MeshAttachment)
				{
					MeshAttachment mesh = slot.Attachment as MeshAttachment;
					Polygon polygon = ComputePolygon();
					polygons.Add(polygon);
					polygon.Vertices = new float[mesh.Vertices.Length];
					mesh.ComputeWorldVertices(slot, polygon.Vertices);
				}
				else if (slot.Attachment is SkinnedMeshAttachment)
				{
					SkinnedMeshAttachment skinnedMesh = slot.Attachment as SkinnedMeshAttachment;
					Polygon polygon = ComputePolygon();
					polygons.Add(polygon);
					polygon.Vertices = new float[skinnedMesh.UVs.Length];
					skinnedMesh.ComputeWorldVertices(slot, polygon.Vertices);
				}
			}
			else
			{
				RegionAttachment region = slot.Attachment as RegionAttachment;
				Polygon polygon = ComputePolygon();
				polygons.Add(polygon);
				polygon.Vertices = new float[8];
				region.ComputeWorldVertices(slot.Bone, polygon.Vertices);
			}
		}
		if (polygons.Count == 0)
		{
			Left = 0f;
			Top = 0f;
			Right = 0f;
			Bottom = 0f;
		}
		else
		{
			Refresh();
		}
	}

	private Polygon ComputePolygon()
	{
		int count = buffer.Count;
		if (count > 0)
		{
			Polygon polygon = buffer.Items[count - 1];
			buffer.RemoveAt(count - 1);
			return polygon;
		}
		return new Polygon();
	}

	private void Refresh()
	{
		float left = 2.1474836E+09f;
		float top = 2.1474836E+09f;
		float right = -2.1474836E+09f;
		float bottom = -2.1474836E+09f;
		for (int i = 0, k = polygons.Count; i < k; i++)
		{
			Polygon polygon = polygons.Items[i];
			float[] vertices = polygon.Vertices;
			for (int j = 0, l = vertices.Length; j < l; j += 2)
			{
				float x = vertices[j];
				float y = vertices[j + 1];
				left = Math.Min(left, x);
				top = Math.Min(top, y);
				right = Math.Max(right, x);
				bottom = Math.Max(bottom, y);
			}
		}
		Left = left;
		Top = top;
		Right = right;
		Bottom = bottom;
	}
}
