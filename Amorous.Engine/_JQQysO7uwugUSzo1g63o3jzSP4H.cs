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
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
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

	public void _7cuPUL8aamrg9daETH6zQk3RwbF(string string_0)
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
