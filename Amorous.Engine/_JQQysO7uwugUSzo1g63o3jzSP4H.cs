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
		_KyRTfqdr2zZtsEAgkvOlUoQoB5j = new _s8LmEXaxHFzAKzGEfeuncG6iAkc<string, Rectangle>();
	}

	public void _Tgna64I8tykesI9aD591n5FUrin(string string_0, Rectangle rectangle_0)
	{
		if (_KyRTfqdr2zZtsEAgkvOlUoQoB5j.ContainsKey(string_0))
		{
			_KyRTfqdr2zZtsEAgkvOlUoQoB5j[string_0] = rectangle_0;
		}
		else
		{
			_KyRTfqdr2zZtsEAgkvOlUoQoB5j.Add(string_0, rectangle_0);
		}
	}

	public bool _eA4yRWB5CfMJCCzEhBJkRcJhaGT(string string_0)
	{
		return _KyRTfqdr2zZtsEAgkvOlUoQoB5j.ContainsKey(string_0);
	}

	public Rectangle _zETvz5wV1cpcKFl6i5KBgWbBmFR(string string_0)
	{
		if (_KyRTfqdr2zZtsEAgkvOlUoQoB5j.ContainsKey(string_0))
		{
			return _KyRTfqdr2zZtsEAgkvOlUoQoB5j[string_0];
		}
		return _Q11h3GSbLiWGbJHulJsbJOnFyVB;
	}

	public void _COrEacAao4LWYM95RxkOjaaEp9x(byte[] byte_0)
	{
		Type typeFromHandle = typeof(_s8LmEXaxHFzAKzGEfeuncG6iAkc<string, Rectangle>);
		XmlSerializer xmlSerializer = new XmlSerializer(typeFromHandle);
		StringReader textReader = new StringReader(Encoding.UTF8.GetString(byte_0));
		_KyRTfqdr2zZtsEAgkvOlUoQoB5j = xmlSerializer.Deserialize(textReader) as _s8LmEXaxHFzAKzGEfeuncG6iAkc<string, Rectangle>;
	}

	public void _Gz8axRA2ks9sOlb2vx60ucqDEM0(string string_0)
	{
		Type typeFromHandle = typeof(_s8LmEXaxHFzAKzGEfeuncG6iAkc<string, Rectangle>);
		XmlSerializer xmlSerializer = new XmlSerializer(typeFromHandle);
		StringReader textReader = new StringReader(File.ReadAllText(string_0));
		_KyRTfqdr2zZtsEAgkvOlUoQoB5j = xmlSerializer.Deserialize(textReader) as _s8LmEXaxHFzAKzGEfeuncG6iAkc<string, Rectangle>;
	}

	public void _Qt9ALtD0p5mWCH7rkv1mIKv7Ghc(string string_0)
	{
		Type typeFromHandle = typeof(_s8LmEXaxHFzAKzGEfeuncG6iAkc<string, Rectangle>);
		XmlSerializer xmlSerializer = new XmlSerializer(typeFromHandle);
		StringReader textReader = new StringReader(string_0);
		_KyRTfqdr2zZtsEAgkvOlUoQoB5j = xmlSerializer.Deserialize(textReader) as _s8LmEXaxHFzAKzGEfeuncG6iAkc<string, Rectangle>;
	}

	public void Save(string string_0)
	{
		Type typeFromHandle = typeof(_s8LmEXaxHFzAKzGEfeuncG6iAkc<string, Rectangle>);
		XmlSerializer xmlSerializer = new XmlSerializer(typeFromHandle);
		StringWriter stringWriter = new StringWriter();
		XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter)
		{
			Formatting = Formatting.Indented
		};
		xmlTextWriter.WriteRaw("");
		XmlSerializerNamespaces xmlSerializerNamespaces = new XmlSerializerNamespaces();
		xmlSerializerNamespaces.Add("", "");
		xmlSerializer.Serialize(xmlTextWriter, _KyRTfqdr2zZtsEAgkvOlUoQoB5j, xmlSerializerNamespaces);
		string contents = stringWriter.ToString();
		File.WriteAllText(string_0, contents);
		stringWriter.Close();
		xmlSerializer = null;
		xmlTextWriter = null;
	}
}
