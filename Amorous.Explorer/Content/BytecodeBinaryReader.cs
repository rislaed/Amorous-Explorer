using System.IO;
using System.Text;

namespace Amorous.Explorer.Content;

public class BytecodeBinaryReader : BinaryReader
{
	public BytecodeBinaryReader(Stream input)
		: base(input) {}

	public BytecodeBinaryReader(Stream input, Encoding encoding)
		: base(input, encoding) {}

	public new int Read7BitEncodedInt()
	{
		return base.Read7BitEncodedInt();
	}
}
