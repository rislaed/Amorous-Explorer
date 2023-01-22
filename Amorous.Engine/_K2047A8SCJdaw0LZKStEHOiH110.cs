using System;
using System.IO;
using System.IO.Compression;

public static class _K2047A8SCJdaw0LZKStEHOiH110
{
	public static Stream _E0f25tLwwg9zgWpaN9mFdnGg2My(string string_0)
	{
		return _E0f25tLwwg9zgWpaN9mFdnGg2My(File.OpenRead(string_0));
	}

	public static Stream _E0f25tLwwg9zgWpaN9mFdnGg2My(Stream stream_0)
	{
		return new GZipStream(stream_0, CompressionMode.Decompress);
	}

	public static string _GxOfTBefEUfWKWaWgxVRKsjugxE(string string_0)
	{
		using StreamReader streamReader = new StreamReader(_E0f25tLwwg9zgWpaN9mFdnGg2My((Stream)(object)string_0));
		return streamReader.ReadToEnd();
	}

	public static string _mDCA4AzhICQie5tejcL2uH7mcwf(string string_0)
	{
		using StreamReader streamReader = new StreamReader(File.OpenRead(string_0));
		return streamReader.ReadToEnd();
	}

	static FileStream smethod_0(string string_0)
	{
		return File.OpenRead(string_0);
	}

	static GZipStream smethod_1(Stream stream_0, CompressionMode compressionMode_0)
	{
		return new GZipStream(stream_0, compressionMode_0);
	}

	static StreamReader smethod_2(Stream stream_0)
	{
		return new StreamReader(stream_0);
	}

	static string smethod_3(TextReader textReader_0)
	{
		return textReader_0.ReadToEnd();
	}

	static void smethod_4(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}
}
