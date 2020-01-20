using System.Drawing;

namespace Myra.Graphics2D.Text
{
	internal struct ChunkInfo
	{
		public int X;
		public int Y;
		public int StartIndex;
		public int CharsCount;
		public Color? Color;
		public bool LineEnd;
	}
}