using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Delegates
{
    class Program
    {
        public delegate void Print(int value);
        public delegate float FloatModification(float value);
        static void Main(string[] args)
        {
            #region Intro to delegates
            Print printDelegate = DelegateExamples.PrintNumber;
            printDelegate(100);
            #endregion
            #region Passing delegate as a function parameter
            //PassingDelegate(DelegateExamples.PrintMoney, 100);
            #endregion
            #region Square and Half
            //float[] data = { 2, 1, 3, 4, 5, 1, 5 };
            //ModifyFloatArray(data, DelegateExamples.Half);
            //PrintArray<float>(data);
            //ModifyFloatArray(data, DelegateExamples.Square);
            //PrintArray<float>(data);
            #endregion
            #region Multiple delegates for one function
            //printDelegate += DelegateExamples.PrintMoney;
            //printDelegate(100);
            #endregion
            #region Func-y and Action filled examples
            //Func<int, int, int> addNumbers = DelegateExamples.Sum;
            //int result = addNumbers(1, 2);
            //Console.WriteLine(result);
            //Action<int> ActionPrint = DelegateExamples.PrintNumber;
            //ActionPrint(7);
            //ActionPrint += DelegateExamples.PrintMoney;
            //ActionPrint(10);
            #endregion
            #region Keeping it Anonymous
            //Print p = delegate (int val)
            //{
            //    Console.WriteLine("It's my turn now to print a value of {0}", val);
            //};
            //p(50);
            #endregion


            Console.ReadKey();
        }

        public static void PassingDelegate(Print delegatePrint, int number)
        {
            delegatePrint(number);
        }
        public static void ModifyFloatArray(float[] values, FloatModification floatMod)
        {
            for(int i = 0; i < values.Length; i++)
            {
                values[i] = floatMod(values[i]);
            }
        }
        public static void PrintArray<T>(T[] values)
        {
            foreach(T value in values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
