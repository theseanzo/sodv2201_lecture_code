using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Delegates
{
    public static class DelegateExamples
    {
        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number is {0}", num);
        }
        public static void PrintMoney(int money)
        {
            Console.WriteLine("We have ${0}", money);
        }

        public static float Half(float value)
        {
            return value / 2.0f;
        }

        public static float Square(float value)
        {
            return value * value;
        }

        public static int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
