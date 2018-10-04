using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_With_Methods
{
    class Program
    {
        /*
        CHECK FOR VALID INPUT
        CHECK FOR VALID MOVE
        */

        // 1.0 Initialize board
        // 1.1 Print Board
        // 1.5 Check first player
        // 2.0 Cycle 1 through X:
        // 2.1 Request input
        // 2.2 Reflect input
        // 2.3 Print board

        /*
         * GAME PLAN
         * finish own couple - WIN
         * break enemy couple
         * create own couple
         * start own couple
         * 
         * checks:
         * lines - 3 rows; 3 colimns; 2 diagonals
         * status of a line = own 1; own 2; mix; enemy 2
         * 
         * // LINE MAP
         * 
            int line1 = board[0] + board[1] + board[2];
            int line2 = board[3] + board[4] + board[5];
            int line3 = board[6] + board[7] + board[8];
            int row1 = board[0] + board[3] + board[6];
            int row2 = board[1] + board[4] + board[7];
            int row3 = board[2] + board[5] + board[8];
            int diag1 = board[0] + board[4] + board[8];
            int diag2 = board[2] + board[4] + board[6];

         * 
         */

        static void PrintBoard(int[] boardParam)
        {
            Console.WriteLine();
            Console.WriteLine("Board State:");
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    int pos = (i) * 3 + j;
                    Console.Write(boardParam[pos]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static int CheckLine(int CellA, int CellB, int CellC)
        {
            //int cellSum = workBoard[CellA] + workBoard[CellB] + workBoard[CellC]; // TFuck this sums!
            int cellSum = CellA + CellB + CellC;
            switch (cellSum)
            {
                case -6:
                    return -4;
                    //break;
                case -4:
                    return -3;
                    //break;
                case -3:
                    return -2;
                    //break;
                case -2:
                    return -1;
                    //break;
                case -1:
                    return 0;
                    //break;
                case 0:
                    {
                        if (CellA == 0 && CellB == 0 && CellC == 0)
                            return 10;
                        else
                            return 1;
                        //break;
                    }
                case 1:
                    return 2;
                    //break;
                case 2:
                    return 3;
                    //break;
                case 3:
                    return 4;
                //break;
                default:
                    return 1000;
                    
                }
       }


        static void Main(string[] args)
        {
            char inr = 'a';
            int inrd = 1;
            int inc = 1;
            int position = 1;
            int arraypos = position - 1;
            int[] board = new int[9];


            // 1.0 Initialize Board

            for (int i = 0; i <= 8; i++)
            {
                board[i] = 0;
            }

            // 1.01 Perform Checks

            int line1 = CheckLine(board[0], board[1], board[2]);
            int line2 = CheckLine(board[3], board[4], board[5]);
            int line3 = CheckLine(board[6], board[7], board[8]);
            int row1 = CheckLine(board[0], board[3], board[6]);
            int row2 = CheckLine(board[1], board[4], board[7]);
            int row3 = CheckLine(board[2], board[5], board[8]);
            int diag1 = CheckLine(board[0], board[4], board[8]);
            int diag2 = CheckLine(board[2], board[4], board[6]);

            // 1.1 Print Board
            PrintBoard(board);

            // 1.5 Check first player
            int meFirst = 2;
            while (meFirst == 2)
            {
                Console.Write("Can I play first? (y/n) ");
                char fPlayer = char.Parse(Console.ReadLine());
                if (fPlayer == 'y')
                    meFirst = 1;
                else if (fPlayer == 'n')
                    meFirst = 0;
                else Console.Write("come again?");
            }

            // 1.6 Optional first move
            if (meFirst == 1)
            {
                board[0] = 1;
                PrintBoard(board);
            }

             line1 = CheckLine(board[0], board[1], board[2]);
             line2 = CheckLine(board[3], board[4], board[5]);
             line3 = CheckLine(board[6], board[7], board[8]);
             row1 = CheckLine(board[0], board[3], board[6]);
             row2 = CheckLine(board[1], board[4], board[7]);
             row3 = CheckLine(board[2], board[5], board[8]);
             diag1 = CheckLine(board[0], board[4], board[8]);
             diag2 = CheckLine(board[2], board[4], board[6]);

            // Temp checks print
            Console.WriteLine("line 1: " + line1);
            Console.WriteLine("line 2: " + line2);
            Console.WriteLine("line 3: " + line3);

            Console.WriteLine("row 1: " + row1);
            Console.WriteLine("row 2: " + row2);
            Console.WriteLine("row 3: " + row3);

            Console.WriteLine("diag 1: " + diag1);
            Console.WriteLine("diag 2: " + diag2);


            /*
            // 2.0 MAIN CYCLE
            int steps = 9 - meFirst;
            for (int sm = 0; sm <= 2; sm++)
            {
                // 2.0.1 Player Turn
                // 2.1 Prompt Input
                Console.Write("Next Turn?: ");
                inr = Console.ReadKey().KeyChar;
                inc = int.Parse(Console.ReadLine());
                inrd = Convert.ToInt32(inr) - 96;

                // 2.2 Reflect Input
                position = (inrd - 1) * 3 + inc;
                arraypos = position - 1;
                board[arraypos] = -2;

                PrintBoard(board);

                // 2.3 Game Turn
                int someCheck = CreateCheck(1, 2, 3); // NOT DEFINED YET
                */

        }
    }
    }
