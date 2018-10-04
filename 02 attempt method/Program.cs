using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_attempt_method
{

    class TempBoard // Start Board
    {
        public int chk = 0; // Test public variable

        public bool PrintBoard(int a, int b) // Print Board
        {
            Console.WriteLine("PrintBoard says: " + chk);
            if (a == b)
                return true;
            else return false;
        }

    } // End Board

    class Program
    {


        static void Main(string[] args)
        {
            TempBoard tb = new TempBoard();
            Console.WriteLine(tb.PrintBoard(4, 3));
            Console.WriteLine("Main says: " + tb.chk);

        }
    }
}
