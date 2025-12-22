using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    public class Position
    {
        public int Rows { get; }
        public int Columns { get; }

        public Position(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
        }
    }
}
