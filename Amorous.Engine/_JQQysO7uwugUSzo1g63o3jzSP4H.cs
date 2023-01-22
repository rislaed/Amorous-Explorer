using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Squid;

public class _JQQysO7uwugUSzo1g63o3jzSP4H
{
	private _s8LmEXaxHFzAKzGEfeuncG6iAkc<string, Rectangle> _KyRTfqdr2zZtsEAgkvOlUoQoB5j;

	private readonly Rectangle _Q11h3GSbLiWGbJHulJsbJOnFyVB = new Rectangle(0, 0, 1, 1);

	public _JQQysO7uwugUSzo1g63o3jzSP4H()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_KyRTfqdr2zZtsEAgkvOlUoQoB5j = new _s8LmEXaxHFzAKzGEfeuncG6iAkc<string, Rectangle>();
	}

	public void _Tgna64I8tykesI9aD591n5FUrin(string string_0, Rectangle rectangle_0)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		if (_KyRTfqdr2zZtsEAgkvOlUoQoB5j.ContainsKey(string_0))
		{
			goto IL_000e;
		}
		goto IL_0054;
		IL_0054:
		_KyRTfqdr2zZtsEAgkvOlUoQoB5j.Add(string_0, rectangle_0);
		int num = 1633896044;
		goto IL_002f;
		IL_002f:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x59C6CDu) % 5u)
			{
			case 3u:
				break;
			case 1u:
				_KyRTfqdr2zZtsEAgkvOlUoQoB5j[string_0] = rectangle_0;
				num = (int)(num2 * 697241878) ^ -2764175;
				continue;
			default:
				return;
			case 0u:
				goto IL_0054;
			case 2u:
				return;
			case 4u:
				return;
			}
			break;
		}
		goto IL_000e;
		IL_000e:
		num = 1766655370;
		goto IL_002f;
	}

	public bool _eA4yRWB5CfMJCCzEhBJkRcJhaGT(string string_0)
	{
		return _KyRTfqdr2zZtsEAgkvOlUoQoB5j.ContainsKey(string_0);
	}

	public Rectangle _zETvz5wV1cpcKFl6i5KBgWbBmFR(string string_0)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if (_KyRTfqdr2zZtsEAgkvOlUoQoB5j.ContainsKey(string_0))
		{
			return _KyRTfqdr2zZtsEAgkvOlUoQoB5j[string_0];
		}
		return _Q11h3GSbLiWGbJHulJsbJOnFyVB;
	}

	public void _COrEacAao4LWYM95RxkOjaaEp9x(byte[] byte_0)
	{
		Type type_ = _JQQysO7uwugUSzo1g63o3jzSP4H.smethod_0(typeof(_s8LmEXaxHFzAKzGEfeuncG6iAkc<string, Rectangle>).TypeHandle);
		XmlSerializer xmlSerializer_ = default(XmlSerializer);
		while (true)
		{
			int num = -462986279;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF2E24EA3u) % 4u)
				{
				case 2u:
					xmlSerializer_ = _JQQysO7uwugUSzo1g63o3jzSP4H.smethod_1(type_);
					num = (int)((num2 * 799962464) ^ 0x69D2496);
					continue;
				case 1u:
				{
					StringReader textReader_ = _JQQysO7uwugUSzo1g63o3jzSP4H.smethod_4(_JQQysO7uwugUSzo1g63o3jzSP4H.smethod_3(_JQQysO7uwugUSzo1g63o3jzSP4H.smethod_2(), byte_0));
					_KyRTfqdr2zZtsEAgkvOlUoQoB5j = _JQQysO7uwugUSzo1g63o3jzSP4H.smethod_5(xmlSerializer_, (TextReader)textReader_) as _s8LmEXaxHFzAKzGEfeuncG6iAkc<string, Rectangle>;
					num = ((int)num2 * -1324294704) ^ -1321458108;
					continue;
				}
				default:
					return;
				case 0u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public void _Gz8axRA2ks9sOlb2vx60ucqDEM0(string string_0)
	{
		Type type_ = _JQQysO7uwugUSzo1g63o3jzSP4H.smethod_0(typeof(_s8LmEXaxHFzAKzGEfeuncG6iAkc<string, Rectangle>).TypeHandle);
		XmlSerializer xmlSerializer_ = _JQQysO7uwugUSzo1g63o3jzSP4H.smethod_1(type_);
		StringReader textReader_ = default(StringReader);
		while (true)
		{
			int num = -452192259;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9E98D43Bu) % 3u)
				{
				case 1u:
					goto IL_0014;
				case 0u:
					break;
				default:
					_KyRTfqdr2zZtsEAgkvOlUoQoB5j = _JQQysO7uwugUSzo1g63o3jzSP4H.smethod_5(xmlSerializer_, (TextReader)textReader_) as _s8LmEXaxHFzAKzGEfeuncG6iAkc<string, Rectangle>;
					return;
				}
				break;
				IL_0014:
				textReader_ = _JQQysO7uwugUSzo1g63o3jzSP4H.smethod_4(_JQQysO7uwugUSzo1g63o3jzSP4H.smethod_6(string_0));
				num = (int)((num2 * 2002223410) ^ 0x33793F57);
			}
		}
	}

	public void _Qt9ALtD0p5mWCH7rkv1mIKv7Ghc(string string_0)
	{
		Type type_ = _JQQysO7uwugUSzo1g63o3jzSP4H.smethod_0(typeof(_s8LmEXaxHFzAKzGEfeuncG6iAkc<string, Rectangle>).TypeHandle);
		StringReader textReader_ = default(StringReader);
		XmlSerializer xmlSerializer_ = default(XmlSerializer);
		while (true)
		{
			int num = -817636644;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9F6644A9u) % 5u)
				{
				case 4u:
					textReader_ = _JQQysO7uwugUSzo1g63o3jzSP4H.smethod_4(string_0);
					num = (int)((num2 * 608406307) ^ 0xCFFB3DD);
					continue;
				case 3u:
					_KyRTfqdr2zZtsEAgkvOlUoQoB5j = _JQQysO7uwugUSzo1g63o3jzSP4H.smethod_5(xmlSerializer_, (TextReader)textReader_) as _s8LmEXaxHFzAKzGEfeuncG6iAkc<string, Rectangle>;
					num = ((int)num2 * -1789848227) ^ 0x44F16A78;
					continue;
				case 2u:
					xmlSerializer_ = _JQQysO7uwugUSzo1g63o3jzSP4H.smethod_1(type_);
					num = (int)(num2 * 2142165275) ^ -1760992119;
					continue;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public void _7cuPUL8aamrg9daETH6zQk3RwbF(string string_0)
	{
		Type type_ = _JQQysO7uwugUSzo1g63o3jzSP4H.smethod_0(typeof(_s8LmEXaxHFzAKzGEfeuncG6iAkc<string, Rectangle>).TypeHandle);
		XmlSerializer xmlSerializer_ = _JQQysO7uwugUSzo1g63o3jzSP4H.smethod_1(type_);
		StringWriter stringWriter = _JQQysO7uwugUSzo1g63o3jzSP4H.smethod_7();
		string string_ = default(string);
		XmlTextWriter xmlWriter_ = default(XmlTextWriter);
		XmlSerializerNamespaces xmlSerializerNamespaces_ = default(XmlSerializerNamespaces);
		while (true)
		{
			int num = 503227022;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3776A1B7u) % 10u)
				{
				case 7u:
					_JQQysO7uwugUSzo1g63o3jzSP4H.smethod_15(string_0, string_);
					num = (int)((num2 * 838569118) ^ 0x37E874DB);
					continue;
				case 6u:
					xmlWriter_ = null;
					num = (int)((num2 * 1389436336) ^ 0x6B86FD25);
					continue;
				case 5u:
					string_ = _JQQysO7uwugUSzo1g63o3jzSP4H.smethod_14((object)stringWriter);
					num = ((int)num2 * -1320908397) ^ 0x397A150F;
					continue;
				case 4u:
					_JQQysO7uwugUSzo1g63o3jzSP4H.smethod_13(xmlSerializer_, (XmlWriter)xmlWriter_, (object)_KyRTfqdr2zZtsEAgkvOlUoQoB5j, xmlSerializerNamespaces_);
					num = ((int)num2 * -913996681) ^ 0x1CA0C3D6;
					continue;
				case 3u:
				{
					XmlTextWriter xmlTextWriter = _JQQysO7uwugUSzo1g63o3jzSP4H.smethod_8((TextWriter)stringWriter);
					_JQQysO7uwugUSzo1g63o3jzSP4H.smethod_9(xmlTextWriter, Formatting.Indented);
					xmlWriter_ = xmlTextWriter;
					_JQQysO7uwugUSzo1g63o3jzSP4H.smethod_10((XmlWriter)xmlWriter_, "");
					num = (int)(num2 * 52893442) ^ -1018847990;
					continue;
				}
				case 2u:
					xmlSerializer_ = null;
					num = (int)((num2 * 51203085) ^ 0x48B205AB);
					continue;
				case 1u:
					xmlSerializerNamespaces_ = _JQQysO7uwugUSzo1g63o3jzSP4H.smethod_11();
					_JQQysO7uwugUSzo1g63o3jzSP4H.smethod_12(xmlSerializerNamespaces_, "", "");
					num = (int)(num2 * 263985253) ^ -590096636;
					continue;
				case 0u:
					_JQQysO7uwugUSzo1g63o3jzSP4H.smethod_16((TextWriter)stringWriter);
					num = (int)((num2 * 1149007524) ^ 0x3271AE63);
					continue;
				default:
					return;
				case 9u:
					break;
				case 8u:
					return;
				}
				break;
			}
		}
	}

	static Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static XmlSerializer smethod_1(Type type_0)
	{
		return new XmlSerializer(type_0);
	}

	static Encoding smethod_2()
	{
		return Encoding.UTF8;
	}

	static string smethod_3(Encoding encoding_0, byte[] byte_0)
	{
		return encoding_0.GetString(byte_0);
	}

	static StringReader smethod_4(string string_0)
	{
		return new StringReader(string_0);
	}

	static object smethod_5(XmlSerializer xmlSerializer_0, TextReader textReader_0)
	{
		return xmlSerializer_0.Deserialize(textReader_0);
	}

	static string smethod_6(string string_0)
	{
		return File.ReadAllText(string_0);
	}

	static StringWriter smethod_7()
	{
		return new StringWriter();
	}

	static XmlTextWriter smethod_8(TextWriter textWriter_0)
	{
		return new XmlTextWriter(textWriter_0);
	}

	static void smethod_9(XmlTextWriter xmlTextWriter_0, Formatting formatting_0)
	{
		xmlTextWriter_0.Formatting = formatting_0;
	}

	static void smethod_10(XmlWriter xmlWriter_0, string string_0)
	{
		xmlWriter_0.WriteRaw(string_0);
	}

	static XmlSerializerNamespaces smethod_11()
	{
		return new XmlSerializerNamespaces();
	}

	static void smethod_12(XmlSerializerNamespaces xmlSerializerNamespaces_0, string string_0, string string_1)
	{
		xmlSerializerNamespaces_0.Add(string_0, string_1);
	}

	static void smethod_13(XmlSerializer xmlSerializer_0, XmlWriter xmlWriter_0, object object_0, XmlSerializerNamespaces xmlSerializerNamespaces_0)
	{
		xmlSerializer_0.Serialize(xmlWriter_0, object_0, xmlSerializerNamespaces_0);
	}

	static string smethod_14(object object_0)
	{
		return object_0.ToString();
	}

	static void smethod_15(string string_0, string string_1)
	{
		File.WriteAllText(string_0, string_1);
	}

	static void smethod_16(TextWriter textWriter_0)
	{
		textWriter_0.Close();
	}
}
