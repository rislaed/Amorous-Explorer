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
		long position = stream_0.Position;
		bool gzip = stream_0.ReadByte() == 0x1f && stream_0.ReadByte() == 0x8b;
		stream_0.Seek(position, SeekOrigin.Begin);
		return gzip ? new GZipStream(stream_0, CompressionMode.Decompress) : stream_0;
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
}
