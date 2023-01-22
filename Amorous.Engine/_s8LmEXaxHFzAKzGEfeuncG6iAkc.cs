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
		XmlSerializer xmlSerializer_ = new XmlSerializer(typeof(T));
		XmlSerializer xmlSerializer_2 = new XmlSerializer(typeof(U));
		bool flag = reader.IsEmptyElement;
		reader.Read();
		if (!flag)
		{
			while (reader.NodeType != XmlNodeType.EndElement)
			{
				reader.ReadStartElement("item");
				reader.ReadStartElement("key");
				T key = (T)xmlSerializer_.Deserialize(reader);
				reader.ReadEndElement();
				reader.ReadStartElement("value");
				U value = (U)xmlSerializer_2.Deserialize(reader);
				reader.ReadEndElement();
				Add(key, value);
				reader.ReadEndElement();
				reader.MoveToContent();
			}
			reader.ReadEndElement();
		}
	}

	public void WriteXml(XmlWriter writer)
	{
		XmlSerializer xmlSerializer_ = new XmlSerializer(typeof(T));
		XmlSerializer xmlSerializer_2 = new XmlSerializer(typeof(U));
		XmlSerializerNamespaces xmlSerializerNamespaces_ = new XmlSerializerNamespaces();
		xmlSerializerNamespaces_.Add("", "");
		foreach (T key in base.Keys)
		{
			writer.WriteStartElement("item");
			writer.WriteStartElement("key");
			xmlSerializer_.Serialize(writer, (object)key, xmlSerializerNamespaces_);
			writer.WriteEndElement();
			writer.WriteStartElement("value");
			U val = base[key];
			xmlSerializer_2.Serialize(writer, (object)val, xmlSerializerNamespaces_);
			writer.WriteEndElement();
			writer.WriteEndElement();
		}
	}

	public override int GetHashCode()
	{
		int num = 0;
		int num2 = 1;
		foreach (U value in base.Values)
		{
			object object_ = value;
			try
			{
				num ^= object_.GetHashCode() + num2++;
			}
			catch (Exception)
			{
				return base.GetHashCode();
			}
		}
		if (num == 0)
		{
			return base.GetHashCode();
		}
		return num;
	}
}
