using System;
using System.Collections.Generic;
using Spine;

public class _NxPDyghimJKCwBg53DaNTazjQ5k
{
	private readonly ExposedList<Polygon> _sc6AWQNc7BlGAmNMydEy7sD8v1j;

	private readonly ExposedList<Polygon> _A9kKAOOHImeN1Bymg7Y86T6pyXf;

	public float _SjhHztt8d5kOtb7Z2BJKnZZxEKh { get; private set; }

	public float _xqxFKfudZYzf8RtrC7EB1Ya6FPT { get; private set; }

	public float _nVnyJkkce6HsdRrKSpRrzUDElg0 { get; private set; }

	public float _pFgHmGjnwllBZ83LhpZv0o8ZcO { get; private set; }

	public float _je8rVfyg4zywmqSi4Ozx1z7wJ4b => _nVnyJkkce6HsdRrKSpRrzUDElg0 - _SjhHztt8d5kOtb7Z2BJKnZZxEKh;

	public float _WJfGWBzn4wgdGBnMWRH2pcJ3AqH => _pFgHmGjnwllBZ83LhpZv0o8ZcO - _xqxFKfudZYzf8RtrC7EB1Ya6FPT;

	public _NxPDyghimJKCwBg53DaNTazjQ5k()
	{
		_sc6AWQNc7BlGAmNMydEy7sD8v1j = new ExposedList<Polygon>();
		_A9kKAOOHImeN1Bymg7Y86T6pyXf = new ExposedList<Polygon>();
	}

	public void _tiBFUHPEkedkbgvuX3whdeyjhKo(Skeleton skeleton_0)
	{
		_sc6AWQNc7BlGAmNMydEy7sD8v1j.AddRange((IEnumerable<Polygon>)_A9kKAOOHImeN1Bymg7Y86T6pyXf);
		_A9kKAOOHImeN1Bymg7Y86T6pyXf.Clear(true);
		ExposedList<Slot> slots = skeleton_0.get_Slots();
		int count = slots.Count;
		for (int i = 0; i < count; i++)
		{
			Slot val = slots.Items[i];
			if (val.get_A() <= 0f)
			{
				continue;
			}
			if (!(val.get_Attachment() is RegionAttachment))
			{
				if (val.get_Attachment() is MeshAttachment)
				{
					Attachment attachment = val.get_Attachment();
					MeshAttachment val2 = (MeshAttachment)(object)((attachment is MeshAttachment) ? attachment : null);
					Polygon val3 = _JFnByzmaHsFolNK380WoVrfnqoo();
					_A9kKAOOHImeN1Bymg7Y86T6pyXf.Add(val3);
					val3.set_Vertices(new float[val2.get_Vertices().Length]);
					val2.ComputeWorldVertices(val, val3.get_Vertices());
				}
				else if (val.get_Attachment() is SkinnedMeshAttachment)
				{
					Attachment attachment2 = val.get_Attachment();
					SkinnedMeshAttachment val4 = (SkinnedMeshAttachment)(object)((attachment2 is SkinnedMeshAttachment) ? attachment2 : null);
					Polygon val5 = _JFnByzmaHsFolNK380WoVrfnqoo();
					_A9kKAOOHImeN1Bymg7Y86T6pyXf.Add(val5);
					val5.set_Vertices(new float[val4.get_UVs().Length]);
					val4.ComputeWorldVertices(val, val5.get_Vertices());
				}
			}
			else
			{
				Attachment attachment3 = val.get_Attachment();
				RegionAttachment val6 = (RegionAttachment)(object)((attachment3 is RegionAttachment) ? attachment3 : null);
				Polygon val7 = _JFnByzmaHsFolNK380WoVrfnqoo();
				_A9kKAOOHImeN1Bymg7Y86T6pyXf.Add(val7);
				val7.set_Vertices(new float[8]);
				val6.ComputeWorldVertices(val.get_Bone(), val7.get_Vertices());
			}
		}
		if (_A9kKAOOHImeN1Bymg7Y86T6pyXf.Count == 0)
		{
			_SjhHztt8d5kOtb7Z2BJKnZZxEKh = 0f;
			_xqxFKfudZYzf8RtrC7EB1Ya6FPT = 0f;
			_nVnyJkkce6HsdRrKSpRrzUDElg0 = 0f;
			_pFgHmGjnwllBZ83LhpZv0o8ZcO = 0f;
		}
		else
		{
			_zVkDLJ3sBUdJJ1CIpOaDUdk4l4fB();
		}
	}

	private Polygon _JFnByzmaHsFolNK380WoVrfnqoo()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		int count = _sc6AWQNc7BlGAmNMydEy7sD8v1j.Count;
		Polygon result;
		if (count > 0)
		{
			result = _sc6AWQNc7BlGAmNMydEy7sD8v1j.Items[count - 1];
			_sc6AWQNc7BlGAmNMydEy7sD8v1j.RemoveAt(count - 1);
		}
		else
		{
			result = new Polygon();
		}
		return result;
	}

	private void _zVkDLJ3sBUdJJ1CIpOaDUdk4l4fB()
	{
		float num = 2.1474836E+09f;
		float num2 = 2.1474836E+09f;
		float num3 = -2.1474836E+09f;
		float num4 = -2.1474836E+09f;
		int i = 0;
		for (int count = _A9kKAOOHImeN1Bymg7Y86T6pyXf.Count; i < count; i++)
		{
			Polygon val = _A9kKAOOHImeN1Bymg7Y86T6pyXf.Items[i];
			float[] vertices = val.get_Vertices();
			int j = 0;
			for (int num5 = vertices.Length; j < num5; j += 2)
			{
				float val2 = vertices[j];
				float val3 = vertices[j + 1];
				num = Math.Min(num, val2);
				num2 = Math.Min(num2, val3);
				num3 = Math.Max(num3, val2);
				num4 = Math.Max(num4, val3);
			}
		}
		_SjhHztt8d5kOtb7Z2BJKnZZxEKh = num;
		_xqxFKfudZYzf8RtrC7EB1Ya6FPT = num2;
		_nVnyJkkce6HsdRrKSpRrzUDElg0 = num3;
		_pFgHmGjnwllBZ83LhpZv0o8ZcO = num4;
	}

	static ExposedList<Slot> smethod_0(Skeleton skeleton_0)
	{
		return skeleton_0.get_Slots();
	}

	static float smethod_1(Slot slot_0)
	{
		return slot_0.get_A();
	}

	static Attachment smethod_2(Slot slot_0)
	{
		return slot_0.get_Attachment();
	}

	static void smethod_3(Polygon polygon_0, float[] float_0)
	{
		polygon_0.set_Vertices(float_0);
	}

	static Bone smethod_4(Slot slot_0)
	{
		return slot_0.get_Bone();
	}

	static float[] smethod_5(Polygon polygon_0)
	{
		return polygon_0.get_Vertices();
	}

	static void smethod_6(RegionAttachment regionAttachment_0, Bone bone_0, float[] float_0)
	{
		regionAttachment_0.ComputeWorldVertices(bone_0, float_0);
	}

	static float[] smethod_7(MeshAttachment meshAttachment_0)
	{
		return meshAttachment_0.get_Vertices();
	}

	static void smethod_8(MeshAttachment meshAttachment_0, Slot slot_0, float[] float_0)
	{
		meshAttachment_0.ComputeWorldVertices(slot_0, float_0);
	}

	static float[] smethod_9(SkinnedMeshAttachment skinnedMeshAttachment_0)
	{
		return skinnedMeshAttachment_0.get_UVs();
	}

	static void smethod_10(SkinnedMeshAttachment skinnedMeshAttachment_0, Slot slot_0, float[] float_0)
	{
		skinnedMeshAttachment_0.ComputeWorldVertices(slot_0, float_0);
	}

	static Polygon smethod_11()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Polygon();
	}

	static float smethod_12(float float_0, float float_1)
	{
		return Math.Min(float_0, float_1);
	}

	static float smethod_13(float float_0, float float_1)
	{
		return Math.Max(float_0, float_1);
	}
}
