using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

[XmlRoot("dictionary")]
public class _s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U> : Dictionary<T, U>, IXmlSerializable
{
	public XmlSchema GetSchema()
	{
		return null;
	}

	public void ReadXml(XmlReader reader)
	{
		XmlSerializer xmlSerializer_ = _s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_1(_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_0(typeof(T).TypeHandle));
		T key = default(T);
		XmlSerializer xmlSerializer_2 = default(XmlSerializer);
		U value = default(U);
		while (true)
		{
			int num = 269974226;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x253EC228u) % 10u)
				{
				case 9u:
					_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_4(reader, "key");
					key = (T)_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_5(xmlSerializer_, reader);
					_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_6(reader);
					num = ((int)num2 * -713258633) ^ -2075769469;
					continue;
				case 8u:
					xmlSerializer_2 = _s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_1(_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_0(typeof(U).TypeHandle));
					num = ((int)num2 * -1822303141) ^ 0x45A69F11;
					continue;
				case 7u:
				{
					bool flag = _s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_2(reader);
					_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_3(reader);
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1750489721;
						num5 = -1750489721;
					}
					else
					{
						num4 = -1356967245;
						num5 = -1356967245;
					}
					num = num4 ^ (int)(num2 * 769578976);
					continue;
				}
				case 5u:
					Add(key, value);
					_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_6(reader);
					_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_7(reader);
					num = (int)((num2 * 1215985935) ^ 0x20ADD98C);
					continue;
				case 4u:
					_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_4(reader, "item");
					num = 1923006145;
					continue;
				case 1u:
				{
					int num3;
					if (_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_8(reader) != XmlNodeType.EndElement)
					{
						num = 112119150;
						num3 = 112119150;
					}
					else
					{
						num = 29699972;
						num3 = 29699972;
					}
					continue;
				}
				case 0u:
					_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_4(reader, "value");
					value = (U)_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_5(xmlSerializer_2, reader);
					_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_6(reader);
					num = (int)((num2 * 638041016) ^ 0x6167A39);
					continue;
				case 2u:
					break;
				case 3u:
					return;
				default:
					_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_6(reader);
					return;
				}
				break;
			}
		}
	}

	public void WriteXml(XmlWriter writer)
	{
		XmlSerializer xmlSerializer_ = _s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_1(_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_0(typeof(T).TypeHandle));
		XmlSerializer xmlSerializer_2 = _s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_1(_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_0(typeof(U).TypeHandle));
		T current = default(T);
		XmlSerializerNamespaces xmlSerializerNamespaces_ = default(XmlSerializerNamespaces);
		while (true)
		{
			int num = -343132219;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB8408964u) % 3u)
				{
				case 2u:
					goto IL_0022;
				case 0u:
					break;
				default:
				{
					using KeyCollection.Enumerator enumerator = base.Keys.GetEnumerator();
					while (true)
					{
						int num3;
						int num4;
						if (enumerator.MoveNext())
						{
							num3 = -504411708;
							num4 = -504411708;
						}
						else
						{
							num3 = -1581216961;
							num4 = -1581216961;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0xB8408964u) % 11u)
							{
							case 8u:
							{
								U val = base[current];
								_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_12(xmlSerializer_2, writer, (object)val, xmlSerializerNamespaces_);
								num3 = (int)(num2 * 288452963) ^ -150439196;
								continue;
							}
							case 7u:
								_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_13(writer);
								num3 = (int)(num2 * 1211032418) ^ -971475714;
								continue;
							case 6u:
								current = enumerator.Current;
								_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_11(writer, "item");
								num3 = -1757438793;
								continue;
							case 5u:
								_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_11(writer, "value");
								num3 = ((int)num2 * -326004824) ^ -1229749753;
								continue;
							case 4u:
								num3 = -504411708;
								continue;
							case 3u:
								_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_13(writer);
								num3 = ((int)num2 * -1675848843) ^ -1658203707;
								continue;
							case 2u:
								_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_11(writer, "key");
								num3 = (int)(num2 * 1408768398) ^ -733777753;
								continue;
							case 1u:
								_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_13(writer);
								num3 = (int)(num2 * 1476997015) ^ -1499231499;
								continue;
							case 0u:
								_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_12(xmlSerializer_, writer, (object)current, xmlSerializerNamespaces_);
								num3 = ((int)num2 * -1124745126) ^ 0x6BBF776A;
								continue;
							default:
								return;
							case 9u:
								break;
							case 10u:
								return;
							}
							break;
						}
					}
				}
				}
				break;
				IL_0022:
				xmlSerializerNamespaces_ = _s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_9();
				_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_10(xmlSerializerNamespaces_, "", "");
				num = ((int)num2 * -1689352031) ^ -1370688456;
			}
		}
	}

	public override int _lFIedLalGGle1XjAyByscHqD2IH()
	{
		int num = 0;
		int num4 = default(int);
		while (true)
		{
			int num2 = 319273986;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xCEBEF3Cu) % 3u)
				{
				case 1u:
					goto IL_0004;
				case 0u:
					break;
				default:
					foreach (U value in base.Values)
					{
						object object_ = value;
						try
						{
							num ^= _s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_14(object_) + num4++;
						}
						catch (Exception)
						{
							return this.method_0();
						}
					}
					if (num == 0)
					{
						num3 = 43878165u;
						return this.method_0();
					}
					return num;
				}
				break;
				IL_0004:
				num4 = 1;
				num2 = (int)((num3 * 2111043177) ^ 0x54740C96);
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

	static bool smethod_2(XmlReader xmlReader_0)
	{
		return xmlReader_0.IsEmptyElement;
	}

	static bool smethod_3(XmlReader xmlReader_0)
	{
		return xmlReader_0.Read();
	}

	static void smethod_4(XmlReader xmlReader_0, string string_0)
	{
		xmlReader_0.ReadStartElement(string_0);
	}

	static object smethod_5(XmlSerializer xmlSerializer_0, XmlReader xmlReader_0)
	{
		return xmlSerializer_0.Deserialize(xmlReader_0);
	}

	static void smethod_6(XmlReader xmlReader_0)
	{
		xmlReader_0.ReadEndElement();
	}

	static XmlNodeType smethod_7(XmlReader xmlReader_0)
	{
		return xmlReader_0.MoveToContent();
	}

	static XmlNodeType smethod_8(XmlReader xmlReader_0)
	{
		return xmlReader_0.NodeType;
	}

	static XmlSerializerNamespaces smethod_9()
	{
		return new XmlSerializerNamespaces();
	}

	static void smethod_10(XmlSerializerNamespaces xmlSerializerNamespaces_0, string string_0, string string_1)
	{
		xmlSerializerNamespaces_0.Add(string_0, string_1);
	}

	static void smethod_11(XmlWriter xmlWriter_0, string string_0)
	{
		xmlWriter_0.WriteStartElement(string_0);
	}

	static void smethod_12(XmlSerializer xmlSerializer_0, XmlWriter xmlWriter_0, object object_0, XmlSerializerNamespaces xmlSerializerNamespaces_0)
	{
		xmlSerializer_0.Serialize(xmlWriter_0, object_0, xmlSerializerNamespaces_0);
	}

	static void smethod_13(XmlWriter xmlWriter_0)
	{
		xmlWriter_0.WriteEndElement();
	}

	static int smethod_14(object object_0)
	{
		return object_0.GetHashCode();
	}

	int method_0()
	{
		return base.GetHashCode();
	}
}
