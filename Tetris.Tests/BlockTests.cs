using Tetris.Core;

namespace Tetris.Tests
{
    public class BlockTests
    {
        [Fact]
        public void Constructor_SetsInitialOffsetToStartOffset()
        {
            var block = new TestBlock();
            var positions = block.TilePostions().ToList();
            Assert.Contains(positions, p=> p.Rows == 5 && p.Columns ==3 );

        }
    }
}
