using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Squid;

public class XmlSerializableFactory
{ // _JQQysO7uwugUSzo1g63o3jzSP4H
	private XmlSerializableDictionary<string, Rectangle> rectangles;
	private readonly Rectangle FALLBACK = new Rectangle(0, 0, 1, 1);

	public XmlSerializableFactory()
	{
		rectangles = new XmlSerializableDictionary<string, Rectangle>();
	}

	public void Add(string key, Rectangle rectangle)
	{
		if (rectangles.ContainsKey(key))
		{
			rectangles[key] = rectangle;
		}
		else
		{
			rectangles.Add(key, rectangle);
		}
	}

	public bool ContainsKey(string key)
	{
		return rectangles.ContainsKey(key);
	}

	public Rectangle Get(string key)
	{
		if (rectangles.ContainsKey(key))
		{
			return rectangles[key];
		}
		return FALLBACK;
	}

	public void ReadBytes(byte[] bytes)
	{
		Type dictionary = typeof(XmlSerializableDictionary<string, Rectangle>);
		XmlSerializer serializer = new XmlSerializer(dictionary);
		StringReader reader = new StringReader(Encoding.UTF8.GetString(bytes));
		rectangles = serializer.Deserialize(reader) as XmlSerializableDictionary<string, Rectangle>;
	}

	public void Read(string path)
	{
		Type dictionary = typeof(XmlSerializableDictionary<string, Rectangle>);
		XmlSerializer serializer = new XmlSerializer(dictionary);
		StringReader reader = new StringReader(File.ReadAllText(path));
		rectangles = serializer.Deserialize(reader) as XmlSerializableDictionary<string, Rectangle>;
	}

	public void ReadString(string xml)
	{
		Type dictionary = typeof(XmlSerializableDictionary<string, Rectangle>);
		XmlSerializer serializer = new XmlSerializer(dictionary);
		StringReader reader = new StringReader(xml);
		rectangles = serializer.Deserialize(reader) as XmlSerializableDictionary<string, Rectangle>;
	}

	public void Write(string path)
	{
		Type dictionary = typeof(XmlSerializableDictionary<string, Rectangle>);
		XmlSerializer serializer = new XmlSerializer(dictionary);
		StringWriter stringWriter = new StringWriter();
		XmlTextWriter writer = new XmlTextWriter(stringWriter)
		{
			Formatting = Formatting.Indented
		};
		writer.WriteRaw("");
		XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
		namespaces.Add("", "");
		serializer.Serialize(writer, rectangles, namespaces);
		File.WriteAllText(path, stringWriter.ToString());
		stringWriter.Close();
		serializer = null;
		writer = null;
	}
}
