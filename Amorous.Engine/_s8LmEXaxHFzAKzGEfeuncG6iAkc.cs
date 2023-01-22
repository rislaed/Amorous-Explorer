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
		XmlSerializer xmlSerializer_2 = _s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_1(_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_0(typeof(U).TypeHandle));
		bool flag = _s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_2(reader);
		_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_3(reader);
		if (!flag)
		{
			while (_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_8(reader) != XmlNodeType.EndElement)
			{
				_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_4(reader, "item");
				_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_4(reader, "key");
				T key = (T)_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_5(xmlSerializer_, reader);
				_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_6(reader);
				_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_4(reader, "value");
				U value = (U)_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_5(xmlSerializer_2, reader);
				_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_6(reader);
				Add(key, value);
				_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_6(reader);
				_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_7(reader);
			}
			_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_6(reader);
		}
	}

	public void WriteXml(XmlWriter writer)
	{
		XmlSerializer xmlSerializer_ = _s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_1(_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_0(typeof(T).TypeHandle));
		XmlSerializer xmlSerializer_2 = _s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_1(_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_0(typeof(U).TypeHandle));
		XmlSerializerNamespaces xmlSerializerNamespaces_ = _s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_9();
		_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_10(xmlSerializerNamespaces_, "", "");
		foreach (T key in base.Keys)
		{
			_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_11(writer, "item");
			_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_11(writer, "key");
			_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_12(xmlSerializer_, writer, (object)key, xmlSerializerNamespaces_);
			_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_13(writer);
			_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_11(writer, "value");
			U val = base[key];
			_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_12(xmlSerializer_2, writer, (object)val, xmlSerializerNamespaces_);
			_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_13(writer);
			_s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_13(writer);
		}
	}

	public override int _lFIedLalGGle1XjAyByscHqD2IH()
	{
		int num = 0;
		int num2 = 1;
		foreach (U value in base.Values)
		{
			object object_ = value;
			try
			{
				num ^= _s8LmEXaxHFzAKzGEfeuncG6iAkc<T, U>.smethod_14(object_) + num2++;
			}
			catch (Exception)
			{
				return this.method_0();
			}
		}
		if (num == 0)
		{
			return this.method_0();
		}
		return num;
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
