using System;
using Spine;

public class SpineBounds
{ // _NxPDyghimJKCwBg53DaNTazjQ5k
	private readonly ExposedList<Polygon> _buffer;
	private readonly ExposedList<Polygon> _polygons;

	public float X1 { get; private set; }
	public float Y1 { get; private set; }
	public float X2 { get; private set; }
	public float Y2 { get; private set; }
	public float Width => X2 - X1;
	public float Height => Y2 - Y1;

	public SpineBounds()
	{
		_buffer = new ExposedList<Polygon>();
		_polygons = new ExposedList<Polygon>();
	}

	public void Update(Skeleton skeleton)
	{
		_buffer.AddRange(_polygons);
		_polygons.Clear();
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
					_polygons.Add(polygon);
					polygon.Vertices = new float[mesh.Vertices.Length];
					mesh.ComputeWorldVertices(slot, polygon.Vertices);
				}
				else if (slot.Attachment is SkinnedMeshAttachment)
				{
					SkinnedMeshAttachment skinnedMesh = slot.Attachment as SkinnedMeshAttachment;
					Polygon polygon = ComputePolygon();
					_polygons.Add(polygon);
					polygon.Vertices = new float[skinnedMesh.UVs.Length];
					skinnedMesh.ComputeWorldVertices(slot, polygon.Vertices);
				}
			}
			else
			{
				RegionAttachment region = slot.Attachment as RegionAttachment;
				Polygon polygon = ComputePolygon();
				_polygons.Add(polygon);
				polygon.Vertices = new float[8];
				region.ComputeWorldVertices(slot.Bone, polygon.Vertices);
			}
		}
		if (_polygons.Count == 0)
		{
			X1 = 0f;
			Y1 = 0f;
			X2 = 0f;
			Y2 = 0f;
		}
		else
		{
			Refresh();
		}
	}

	private Polygon ComputePolygon()
	{
		int count = _buffer.Count;
		if (count > 0)
		{
			Polygon polygon = _buffer.Items[count - 1];
			_buffer.RemoveAt(count - 1);
			return polygon;
		}
		return new Polygon();
	}

	private void Refresh()
	{
		float x1 = 2.1474836E+09f;
		float y1 = 2.1474836E+09f;
		float x2 = -2.1474836E+09f;
		float y2 = -2.1474836E+09f;
		for (int i = 0, k = _polygons.Count; i < k; i++)
		{
			Polygon polygon = _polygons.Items[i];
			float[] vertices = polygon.Vertices;
			for (int j = 0, l = vertices.Length; j < l; j += 2)
			{
				float x = vertices[j];
				float y = vertices[j + 1];
				x1 = Math.Min(x1, x);
				y1 = Math.Min(y1, y);
				x2 = Math.Max(x2, x);
				y2 = Math.Max(y2, y);
			}
		}
		X1 = x1;
		Y1 = y1;
		X2 = x2;
		Y2 = y2;
	}
}
