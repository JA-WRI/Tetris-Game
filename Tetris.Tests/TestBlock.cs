using System;
using System.Collections.Generic;
using System.Text;
using Tetris.Core;

namespace Tetris.Tests
{
    public class TestBlock: Block
    {
        protected override Position[][] Tiles => new []
        {
            new [] { new Position(0,0), new Position(0,1)},
            new [] { new Position(0,0), new Position(0,1) },

        };
        public override int Id => 99;
        protected override Position StartOffset => new Position(5, 3);

    }
}
