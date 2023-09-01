using System.IO;
using System.Text;

namespace Amorous.Explorer.Content;

public class BytecodeBinaryWriter : BinaryWriter
{
	public BytecodeBinaryWriter(Stream output)
		: base(output) {}

	public BytecodeBinaryWriter(Stream output, Encoding encoding)
		: base(output, encoding) {}

	protected BytecodeBinaryWriter()
		: base() {}

	public new void Write7BitEncodedInt(int value)
	{
		base.Write7BitEncodedInt(value);
	}
}
