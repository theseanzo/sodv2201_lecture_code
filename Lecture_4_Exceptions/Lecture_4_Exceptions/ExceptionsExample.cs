using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_4_Exceptions
{
    #region Typical Exceptions

    static class ExceptionsExample
    {
        //exceptions provide a mechanism for dealing with unexpected circumstances in your code
        //exceptions separate error handling from main logic
        //split into four main parts: try, catch, finally, and throw
        public static void WhyExceptions(String value)
        {
            int number = Int32.Parse(value);
            Console.WriteLine("We can move on");
        }
        public static void InputExample(String value)
        {
            try
            {
                int number = Int32.Parse(value);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("We can move on");
            }
        }
        public static void PrintValueInRangeExample(int accessor)
        {
            int[] values = { 1, 2, 3, 4, 5 };
            if(accessor >= values.Length || accessor < 0)
            {
                throw new IndexOutOfRangeException("We have a value in the incorrect index");
            }
            else
            {
                Console.WriteLine(values[accessor]);
            }
        }
    }
    #endregion
}
