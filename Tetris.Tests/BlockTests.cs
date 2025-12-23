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
        [Fact]
        public void RotateCW_ChangesTilePositions()
        {
            var block = new TestBlock();

            block.RotateCW();
            var positions = block.TilePostions().ToList();

            Assert.Contains(new Position(5, 3), positions);
            Assert.Contains(new Position(6, 3), positions);
        }

        [Fact]
        public void RotateCCW_FromZeroWrapsToLastRotation()
        {
            var block = new TestBlock();

            block.RotateCCW();
            var positions = block.TilePostions().ToList();

            Assert.Contains(new Position(5, 3), positions);
            Assert.Contains(new Position(6, 3), positions);
        }
        [Fact]
        public void Move_UpdatesTilePositionsCorrectly()
        {
            var block = new TestBlock();

            block.Move(2, -1);
            var positions = block.TilePostions().ToList();

            Assert.Contains(new Position(7, 2), positions);
            Assert.Contains(new Position(7, 3), positions);
        }
        [Fact]
        public void Reset_ResetsRotationAndOffset()
        {
            var block = new TestBlock();

            block.Move(3, 3);
            block.RotateCW();
            block.Reset();

            var positions = block.TilePostions().ToList();

            Assert.Contains(new Position(5, 3), positions);
            Assert.Contains(new Position(5, 4), positions);
        }

    }
}
