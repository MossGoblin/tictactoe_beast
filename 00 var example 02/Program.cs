using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_var_example_02
{
    using System;
    namespace RectangleApplication
    {
        class Rectangle
        {
            //member variables
            public double testVar = 3.14;

            public void Display()
            {
                Console.WriteLine("Area: {0}", testVar*2);
            }
        }//end class Rectangle

        class ExecuteRectangle
        {
            static void Main(string[] args)
            {
                Rectangle r = new Rectangle();
                r.Display();
                Console.WriteLine(r.testVar);
                Console.ReadLine();
            }
        }
    }
}
