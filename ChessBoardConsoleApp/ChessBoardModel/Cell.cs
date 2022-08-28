using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardModel
{
    class Cell
    {
        //which row and column that the cell is located on the board
        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }
        //each cell can be true or fals, tell the computer that a piece is on the cell
        public bool CurrentlyOccupied { get; set; }
        //tell the computer on which cell a piece can move
        public bool LegalNextMove { get; set; }

        public Cell(int x, int y)
        {
            RowNumber = x;
            ColumnNumber = y;
        }
    }
}
