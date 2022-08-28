using ChessBoardModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardConsoleApp
{
    class Program
    {
        static Board myBoard = new Board(8);
        static void Main(string[] args)
        {
            //show the empty chess board
            printBoard(myBoard);

            //ask the user for an x and y coordinate where we will place the piece
            Cell currentCell = setCurrentCell();
            currentCell.CurrentlyOccupied = true;

            //calculate all legal moves for that piece
            myBoard.MarkNextLegalMove(currentCell, "Rook" );

            //print the chess board. Use the X for occupied square. Use a + for legal move. Use . for empty cell.
            printBoard(myBoard);

            //wait for another enter key press before ending the program.
            Console.ReadLine();
        }

        private static Cell setCurrentCell()
        {
            int currentRow, currentColumn;
            //get x and y coordinates from the user. return a cell location.
            try
            {
                Console.WriteLine("Enter the current row number");
                currentRow = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Not valid. Default set to 3.");
                currentRow = 3;
            }

            try
            {
                Console.WriteLine("Enter the current column number");
                currentColumn = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Not valid. Default set to 3.");
                currentColumn = 3;
            }


            return myBoard.theGrid[currentRow, currentColumn];
        }

        private static void printBoard(Board myBoard)
        {
            //print the chess board. Use the X for occupied square. Use a + for legal move. Use . for empty cell.
            for(int i=0; i<myBoard.Size; i++)
            {
                for(int j=0; j<myBoard.Size; j++)
                {
                    Cell c = myBoard.theGrid[i, j];

                    if(c.CurrentlyOccupied == true)
                    {
                        Console.Write("X");
                    }
                    else if(c.LegalNextMove == true)
                    {
                        Console.Write("+");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("=================================================");

        }
    }
}
