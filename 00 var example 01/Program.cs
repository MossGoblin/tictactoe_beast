﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_var_example_01
{
    using System;
    namespace RectangleApplication
    {
        class Rectangle
        {
            //member variables
            public double length;
            public double width;
            public double testVar = 3.14;

            public double GetArea()
            {
                return length * width;
            }
            public void Display()
            {
                Console.WriteLine("Length: {0}", length);
                Console.WriteLine("Width: {0}", width);
                Console.WriteLine("Area: {0}", GetArea());
            }
        }//end class Rectangle

        class ExecuteRectangle
        {
            static void Main(string[] args)
            {
                Rectangle r = new Rectangle();
                r.length = 4.5;
                r.width = 3.5;
                r.Display();
                Console.WriteLine(r.testVar);
                Console.ReadLine();
            }
        }
    }
}
