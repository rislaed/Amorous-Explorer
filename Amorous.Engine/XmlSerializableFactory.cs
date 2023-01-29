using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Squid;

public class XmlSerializableFactory
{ // _JQQysO7uwugUSzo1g63o3jzSP4H
	private XmlSerializableDictionary<string, Rectangle> _rectangles;
	private readonly Rectangle _fallbackRectangle = new Rectangle(0, 0, 1, 1);

	public XmlSerializableFactory()
	{
		_rectangles = new XmlSerializableDictionary<string, Rectangle>();
	}

	public void Add(string key, Rectangle rectangle)
	{
		if (_rectangles.ContainsKey(key))
		{
			_rectangles[key] = rectangle;
		}
		else
		{
			_rectangles.Add(key, rectangle);
		}
	}

	public bool ContainsKey(string key)
	{
		return _rectangles.ContainsKey(key);
	}

	public Rectangle Get(string key)
	{
		if (_rectangles.ContainsKey(key))
		{
			return _rectangles[key];
		}
		return _fallbackRectangle;
	}

	public void ReadBytes(byte[] bytes)
	{
		Type dictionary = typeof(XmlSerializableDictionary<string, Rectangle>);
		XmlSerializer serializer = new XmlSerializer(dictionary);
		StringReader reader = new StringReader(Encoding.UTF8.GetString(bytes));
		_rectangles = serializer.Deserialize(reader) as XmlSerializableDictionary<string, Rectangle>;
	}

	public void Read(string path)
	{
		Type dictionary = typeof(XmlSerializableDictionary<string, Rectangle>);
		XmlSerializer serializer = new XmlSerializer(dictionary);
		StringReader reader = new StringReader(File.ReadAllText(path));
		_rectangles = serializer.Deserialize(reader) as XmlSerializableDictionary<string, Rectangle>;
	}

	public void ReadString(string xml)
	{
		Type dictionary = typeof(XmlSerializableDictionary<string, Rectangle>);
		XmlSerializer serializer = new XmlSerializer(dictionary);
		StringReader reader = new StringReader(xml);
		_rectangles = serializer.Deserialize(reader) as XmlSerializableDictionary<string, Rectangle>;
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
		serializer.Serialize(writer, _rectangles, namespaces);
		string contents = stringWriter.ToString();
		File.WriteAllText(path, contents);
		stringWriter.Close();
		serializer = null;
		writer = null;
	}
}
