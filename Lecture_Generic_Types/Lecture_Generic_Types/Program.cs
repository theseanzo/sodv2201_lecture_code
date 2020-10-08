using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Generic_Types
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
    class Program
    {

        static void Main(string[] args)
        {
            #region Just Generics
            Point<int> integerPoint = new Point<int> { X = 2, Y = 3 };
            Point<float> floatPoint = new Point<float> { X = 2.0f, Y = 3.0f };
            Bozo x = new Bozo("X");
            Bozo y =  new Bozo("X");
            if(x == y)
            {
                Console.WriteLine("X is equal to Y");
            }
            Point<Bozo> point1 = new Point<Bozo> { X = x, Y = y };
            point1.EqualsX(new Bozo("X"));
            Point<Bozo> point2 = new Point<Bozo> { X = x, Y = y };
            int? v;
            Console.WriteLine(integerPoint);
            Console.WriteLine(floatPoint);
            

            Map<string, Bozo> testMap = new Map<string, Bozo>();
            Console.WriteLine(testMap.GetValue("Non-existant"));
            int bozo1 = 10;
            int bozo2 = 20;
            
            FunctionsExample.Swap(ref bozo1, ref bozo2);
            Console.WriteLine(bozo1);
            #endregion


            #region Constraints
            ConstrainedClass<Bozo> notGoingToWork = new ConstrainedClass<Bozo>(new Bozo("Will work"));
            AnimalList<Snake> animalList = new AnimalList<Snake>();//created to be only snakes
            animalList.Add(new Snake());
            AnimalList<Lion> lionList = new AnimalList<Lion>();
            lionList.Add(new Lion());//hope that the programmer working with your code does not somehow add lions to the snake list
            #endregion

            #region sorted list example
            SortedList<int, String> catchPhrases = new SortedList<int, string>();
            catchPhrases.Add(6, "Did I do that?");
            catchPhrases.Add(2, "Hasta La Vista");
            catchPhrases.Add(8, "How you doin'?");
            catchPhrases.Add(7, "Hakuna Matata");
            catchPhrases.Add(1, "I came here to kick ass and chew bubble gum, and I'm all out of bubblegum.");
            catchPhrases.Add(4, "P-A-R-T-Y because I gotta");
            catchPhrases.Add(3, "I'll be back");
            catchPhrases.Add(5, "You had me at hello");
            //Int32 implements IComparable
            foreach(KeyValuePair<int, string> catchPhrase in catchPhrases)
            {
                Console.WriteLine(catchPhrase.Value);
            }
            #endregion
            Console.ReadKey();
        }
    }



}
