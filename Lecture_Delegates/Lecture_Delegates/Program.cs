using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Delegates
{
    class Program
    {
        public delegate void Print(int value);
        public delegate float FloatModification(float value);
        public delegate int NumberAdder(int x, int y);
        static void Main(string[] args)
        {
            #region Intro to delegates
            //Action<int> printDelegate = DelegateExamples.PrintMoney;

            Print printDelegate = DelegateExamples.PrintMoney;// DelegateExamples.PrintNumber;
            // Func<int, int, int> addNumbers = (x, y) => { return x + y};
            NumberAdder addNumbers = TrollAdd;
            addNumbers(2, 2);
            printDelegate += DelegateExamples.PrintNumber;

            printDelegate(100);

            //#endregion
            //#region Passing delegate as a function parameter
            //PassingDelegate(DoNothing, 100);
            #endregion
            #region Square and Half
            //float[] data = { 1, 2, 3, 4, 5, 6, 7 };
            //ModifyFloatArray(data, DelegateExamples.Half);
            //PrintArray<float>(data);
            //ModifyFloatArray(data, DelegateExamples.Square);
            //PrintArray<float>(data);
            #endregion
            #region Multiple functions for one delegate

            //Print printDelegate = DelegateExamples.PrintNumber;
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
            Print p = delegate (int val)
            {
                Console.WriteLine("It's my turn now to print a value of {0}", val);
            };
            p(50);
            PassingDelegate(delegate(int value) { Console.WriteLine("Look ma, I'm being passed and with the number {0}", value); }, 100);
            #endregion
            Func<int, int, int> addNumbers = TrollAdd;
            int trollValue = addNumbers(2, 2);
            Console.WriteLine("2 + 2 is {0}", trollValue);

            Console.ReadKey();
        }
        public static int TrollAdd(int x, int y)
        {
            return x + y + 1;
        }
        public static void DoNothing(int value)
        {

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
