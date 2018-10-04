using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Classes_and_Methods
{

    class GameBoard
    {
        public int[] board = new int[9];
        public string[] line = new string[8];
        //        public int line1 = 0;
        //        public int line2 = 0;
        //        public int line3 = 0;
        //        public int row1 = 0;
        //        public int row2 = 0;
        //        public int row3 = 0;
        //        public int diag1 = 0;
        //        public int diag2 = 0;

        public void InitBoard() // Zero the board
        {
            for (int i = 0; i <= 8; i++) // Zero the board itself
            {
                board[i] = 0;
            }

            for (int i = 0; i <= 7; i++) // Zero each line
                line[i] = "empty";
        }

        public void PrintBoard() // Display the board
        {
            Console.WriteLine();
            Console.WriteLine("Board State:");
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    int pos = (i) * 3 + j;
                    if (board[pos] == 1) Console.Write("X");
                    else if (board[pos] == -2) Console.Write("0");
                    else Console.Write("-");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void AddInput(int iRow, int iCol, int iVal) // Add Value at Row/Column
        {
            int pos = (iRow) * 3 + iCol;
            board[pos] = iVal;
            //RedoChecks();
        }

        public string CheckLine(int CellA, int CellB, int CellC)
        {
            int cellSum = CellA + CellB + CellC;
            switch (cellSum)
            {
                case -6:
                    return "enemy 3";
                //break;
                case -4:
                    return "enemy 2";
                //break;
                case -3:
                    return "enemy 2 closed";
                //break;
                case -2:
                    return "enemy 1";
                //break;
                case -1:
                    return "1 mixed";
                //break;
                case 0:
                    {
                        if (CellA == 0 && CellB == 0 && CellC == 0)
                            return "clean";
                        else
                            return "own 2 closed";
                        //break;
                    }
                case 1:
                    return "own 1";
                //break;
                case 2:
                    return "own 2";
                //break;
                case 3:
                    return "own 3";
                //break;
                default:
                    return "error";
            }

        }

        public void RedoChecks() // Re-calculate all lines
        {
            line[0] = CheckLine(board[0], board[1], board[2]);
            line[1] = CheckLine(board[3], board[4], board[5]);
            line[2] = CheckLine(board[6], board[7], board[8]);
            line[3] = CheckLine(board[0], board[3], board[6]);
            line[4] = CheckLine(board[1], board[4], board[7]);
            line[5] = CheckLine(board[2], board[5], board[8]);
            line[6] = CheckLine(board[0], board[4], board[8]);
            line[7] = CheckLine(board[2], board[4], board[6]);
        }

        public void PrintChecks() // Print the checks of each line
        {

            Console.WriteLine("line1: " + line[0]);
            Console.WriteLine("line2: " + line[1]);
            Console.WriteLine("line3: " + line[2]);
            Console.WriteLine("row1: " + line[3]);
            Console.WriteLine("row2: " + line[4]);
            Console.WriteLine("row3: " + line[5]);
            Console.WriteLine("diag1: " + line[6]);
            Console.WriteLine("diag2: " + line[7]);
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            GameBoard bb = new GameBoard();
            bb.InitBoard();
            bb.PrintBoard();
            bb.RedoChecks();
            bb.PrintChecks();
            Console.WriteLine();
            bb.AddInput(0, 0, -2);
            bb.PrintBoard();
            bb.RedoChecks();
            bb.PrintChecks();
            Console.WriteLine();
            // Check for first move
            Console.Write("Can I play first? (y/n) ");
            char fpInput = 'x';
            int meFirst = 10;
            while (meFirst == 10)
            {
                fpInput = char.Parse(Console.ReadLine());
                if (fpInput == 'y')
                    meFirst = 1;
                else if (fpInput == 'n')
                    meFirst = 0;
                else
                {
                    Console.WriteLine("Yes or No");
                    Console.Write("Can I play first? (y/n) ");
                }
            }
        }
    }
}
