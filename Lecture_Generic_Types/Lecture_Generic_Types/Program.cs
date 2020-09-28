using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Generic_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Point<int> integerPoint = new Point<int> { X = 2, Y = 3 };
            Point<float> floatPoint = new Point<float> { X = 2.0f, Y = 3.0f };
            Console.WriteLine(integerPoint);
            Console.WriteLine(floatPoint);
        }
    }
}
