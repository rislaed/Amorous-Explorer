using System.IO;
using System.IO.Compression;

public static class Compressions
{
	public static Stream ReadStream(string path)
	{
		return ReadStream(File.OpenRead(path));
	}

	public static Stream ReadStream(Stream stream)
	{
		long position = stream.Position;
		bool gzip = stream.ReadByte() == 0x1f && stream.ReadByte() == 0x8b;
		stream.Seek(position, SeekOrigin.Begin);
		return gzip ? new GZipStream(stream, CompressionMode.Decompress) : stream;
	}

	public static string ReadStreamAsText(string path)
	{
		using StreamReader streamReader = new StreamReader(ReadStream(path));
		return streamReader.ReadToEnd();
	}
}
