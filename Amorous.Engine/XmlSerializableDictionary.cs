using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

[XmlRoot("dictionary")]
public class XmlSerializableDictionary<T, U> : Dictionary<T, U>, IXmlSerializable
{ // _s8LmEXaxHFzAKzGEfeuncG6iAkc
	public XmlSchema GetSchema()
	{
		return null;
	}

	public void ReadXml(XmlReader reader)
	{
		XmlSerializer keySerializer = new XmlSerializer(typeof(T));
		XmlSerializer valueSerializer = new XmlSerializer(typeof(U));
		bool empty = reader.IsEmptyElement;
		reader.Read();
		if (!empty)
		{
			while (reader.NodeType != XmlNodeType.EndElement)
			{
				reader.ReadStartElement("item");
				reader.ReadStartElement("key");
				T key = (T)keySerializer.Deserialize(reader);
				reader.ReadEndElement();
				reader.ReadStartElement("value");
				U value = (U)valueSerializer.Deserialize(reader);
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
		XmlSerializer keySerializer = new XmlSerializer(typeof(T));
		XmlSerializer valueSerializer = new XmlSerializer(typeof(U));
		XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
		namespaces.Add("", "");
		foreach (T key in base.Keys)
		{
			writer.WriteStartElement("item");
			writer.WriteStartElement("key");
			keySerializer.Serialize(writer, (object)key, namespaces);
			writer.WriteEndElement();
			writer.WriteStartElement("value");
			U val = base[key];
			valueSerializer.Serialize(writer, (object)val, namespaces);
			writer.WriteEndElement();
			writer.WriteEndElement();
		}
	}

	public override int GetHashCode()
	{
		int code = 0;
		int index = 1;
		foreach (U value in base.Values)
		{
			object next = value;
			try
			{
				code ^= next.GetHashCode() + index++;
			}
			catch (Exception)
			{
				return base.GetHashCode();
			}
		}
		if (code == 0)
		{
			return base.GetHashCode();
		}
		return code;
	}
}
