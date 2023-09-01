using System.IO;
using System.IO.Compression;

public static class Compressions
{ // _K2047A8SCJdaw0LZKStEHOiH110
	public static Stream ReadStream(string path)
	{
		return ReadStream(File.OpenRead(path));
	}

	public static Stream ReadStream(Stream stream)
	{
		long position = stream.Position;
		bool gzipped = stream.ReadByte() == 0x1f && stream.ReadByte() == 0x8b;
		stream.Seek(position, SeekOrigin.Begin);
		return gzipped ? new GZipStream(stream, CompressionMode.Decompress) : stream;
	}

	public static string ReadStreamAsText(string path)
	{
		return ReadStreamAsText(ReadStream(path));
	}

	public static string ReadStreamAsText(Stream stream)
	{
		using StreamReader streamReader = new StreamReader(stream);
		return streamReader.ReadToEnd();
	}
}
