using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardModel
{
    public class Board
    {
        //the size of the board usually 8x8
        public int Size { get; set; }

        //2d array of type cell
        public Cell[,] theGrid { get; set; }

        public Board(int s)
        {
            //initial size of the board is defined by s
            Size = s;

            //create a new 2D array of type Cell
            theGrid = new Cell[Size, Size];

            //fill the 2D array with new Cells, each with a unique x and y coordinate
            for(int i=0; i<Size; i++)
            {
                for(int j=0; j<Size; j++)
                {
                    theGrid[i, j] = new Cell(i, j);
                }
            }
        }

        public bool isSafe(int x, int y)
        {
            if(x < 0 || x >= Size || y < 0 || y >= Size)
            {
                Console.WriteLine("Pos " + x + ", " + y + " is NOT safe.");
                return false;
            }
            else
            {
                Console.WriteLine("Pos " + x + ", " + y + " is safe.");
                return true;
            }
        }

        public void MarkNextLegalMove(Cell currentCell, string chessPiece)
        {
            //step 1 - clear all previous legal moves
            for(int i=0; i<Size; i++)
            {
                for(int j=0; j<Size; j++)
                {
                    theGrid[i, j].LegalNextMove = false;
                    theGrid[i, j].CurrentlyOccupied = false;
                }
            }

            //step 2 - find all legal moves and mark the cell as "legal"
            switch (chessPiece)
            {
                case "Knight":
                    if(isSafe(currentCell.RowNumber + 2, currentCell.ColumnNumber + 1))
                        theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    if(isSafe(currentCell.RowNumber + 2, currentCell.ColumnNumber - 1))
                        theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    if(isSafe(currentCell.RowNumber - 2, currentCell.ColumnNumber + 1))
                        theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 2, currentCell.ColumnNumber - 1))
                        theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColumnNumber + 2))
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColumnNumber - 2))
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber + 2))
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber - 2))
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 2].LegalNextMove = true;

                    break;

                case "King":
                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColumnNumber - 1))
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColumnNumber + 1))
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 1))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 1))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber - 1))
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber -1].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber + 1))
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 1].LegalNextMove = true;

                    break;

                case "Rook":
                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 2, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 3, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber + 3, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 4, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber + 4, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 5, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber + 5, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 6, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber + 6, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 7, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber + 7, currentCell.ColumnNumber].LegalNextMove = true;

                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 1))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 2))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 3))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 3].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 4))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 4].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 5))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 5].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 6))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 6].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 7))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 7].LegalNextMove = true;

                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 2, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 3, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber - 3, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 4, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber - 4, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 5, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber - 5, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 6, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber - 6, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 7, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber - 7, currentCell.ColumnNumber].LegalNextMove = true;

                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 1))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 2))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 3))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 3].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 4))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 4].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 5))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 5].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 6))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 6].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 7))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 7].LegalNextMove = true;

                    break;

                case "Bishop":
                    break;

                case "Queen":
                    break;

                default:
                    break;
            }

            theGrid[currentCell.RowNumber, currentCell.ColumnNumber].CurrentlyOccupied = true;
        }

    }
}
