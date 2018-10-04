using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe
{
    class Program
    {

        // 1.0 Initialize board
        // 1.1 Print Board
        // 2.0 Cycle 1 through 5:
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
             */

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

            // Print board
            Console.WriteLine();
            Console.WriteLine("Board State:");
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    int pos = (i) * 3 + j;
                    Console.Write(board[pos]);
                }
                Console.WriteLine();
            }

            // 2.1 Prompt Input
            Console.Write("Next Turn?: ");
            inr = Console.ReadKey().KeyChar;
            inc = int.Parse(Console.ReadLine());
            inrd = Convert.ToInt32(inr)-96;

            // 2.2 Reflect Input
            position = (inrd - 1) * 3 + inc;
            arraypos = position - 1;
            board[arraypos] = 1;

            // Print Board
            Console.WriteLine();
            Console.WriteLine("Board State:");
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    int pos = (i) * 3 + j;
                    Console.Write(board[pos]);
                }
                Console.WriteLine();
            }



            /*
            // Print board
            Console.WriteLine();
            Console.WriteLine("Board State:");
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    int pos = (i) * 3 + j;
                    Console.Write(board[pos]);
                }
                Console.WriteLine();
            }
            */

            // REPEAT ONCE MORE MANUALLY
            // 2.1 Prompt Input
            Console.Write("Next Turn?: ");
            inr = Console.ReadKey().KeyChar;
            inc = int.Parse(Console.ReadLine());
            inrd = Convert.ToInt32(inr) - 96;

            // 2.2 Reflect Input
            position = (inrd - 1) * 3 + inc;
            arraypos = position - 1;
            board[arraypos] = 1;

            // Print Board
            Console.WriteLine();
            Console.WriteLine("Board State:");
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    int pos = (i) * 3 + j;
                    Console.Write(board[pos]);
                }
                Console.WriteLine();
            }




        }
    }
}
