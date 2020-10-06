using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Generic_Types
{
    class Program
    {
        class Bozo
        {
            string DumbExample { get; set; }

            public Bozo(string dExample)
            {
                this.DumbExample = dExample;
            }
            public override string ToString()
            {
                return this.DumbExample;
            }
        }
        static void Main(string[] args)
        {
            #region Just Generics
            Point<int> integerPoint = new Point<int> { X = 2, Y = 3 };
            Point<float> floatPoint = new Point<float> { X = 2.0f, Y = 3.0f };
            Point<Bozo> bozoPoint = new Point<Bozo> { X = new Bozo("X"), Y = new Bozo("Y") };
            Console.WriteLine(integerPoint);
            Console.WriteLine(floatPoint);
            

            Map<string, Bozo> testMap = new Map<string, Bozo>();
            Console.WriteLine(testMap.GetValue("Non-existant"));
            int bozo1 = 10;
            int bozo2 = 20;
            
            FunctionsExample.Swap(ref bozo1, ref bozo2);
            Console.WriteLine(bozo1);
            #endregion

            Console.ReadKey();
        }
    }



}
