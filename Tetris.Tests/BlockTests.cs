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
            Assert.Contains(positions, p => p.Rows == 5 && p.Columns == 3);

        }

        [Fact]
        public void Move_UpdatesTilePositions()
        {
            var block = new TestBlock();
            block.Move(2, 3);
            var positions = block.TilePostions().ToList();
            Assert.Contains(positions, p => p.Rows == 7 && p.Columns == 6);
        }
        [Fact]
        public void RotateCW_UpdatesTilePositions()
        {
            var block = new TestBlock();
            block.RotateCW();
            var positions = block.TilePostions().ToList();
            Assert.Contains(positions, p => p.Rows == 5 && p.Columns == 3);
            Assert.Contains(positions, p => p.Rows == 5 && p.Columns == 4);
        }

        [Fact]
        public void RotateCCW_UpdatesTilePositions()
        {
            var block = new TestBlock();
            block.RotateCCW();
            var positions = block.TilePostions().ToList();
            Assert.Contains(positions, p => p.Rows == 5 && p.Columns == 3);
            Assert.Contains(positions, p => p.Rows == 5 && p.Columns == 4);
        }
    }
}
