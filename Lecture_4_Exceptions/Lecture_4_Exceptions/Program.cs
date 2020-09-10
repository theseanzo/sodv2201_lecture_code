using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_4_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            exceptionsExample();
            Console.ReadKey();
        }
        #region Exceptions Example
        static void exceptionsExample()
        {
            string lineInput = Console.ReadLine();
            ExceptionsExample.WhyExceptions(lineInput);
          //  ExceptionsExample.InputExample(lineInput);
            //try
            //{
            //    ExceptionsExample.PrintValueInRangeExample(7);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //}
        }
        #endregion

    }
}
