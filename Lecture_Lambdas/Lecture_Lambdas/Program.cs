using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Lambdas
{

    class Program
    {
        //new DogBreed { Name = "Portuguese Water Dog", HypoAllergenic = true},  

        static void Main(string[] args)
        {
            List<Dog> dogBreeds = new List<Dog>() { new Dog { Name = "German Shepard", Loyal = true, HypoAllergenic = false }, new Dog { Name = "Shiba Inu", Loyal=False, HypoAllergenic = false },
                new Dog { Name = "Poodle",Loyal=true, HypoAllergenic = true},  new Dog { Name = "Yorkshire Terrier", Loyal=true,  HypoAllergenic = false }   };
            //using predicates/delegates
            // Func<int, int, int> returnFunction; //<input, input, output>
            //Action<String> printFunction;//always a void function
            // Predicate<int> predicateFunction;//always returns a boolean value
            Dog hypoAllergenic = dogBreeds.Find(FindIfHypoAllergenic);
            //hypoAllergenic = dogBreeds.Find(new delegate (DogBreed dog) { return dog.HypoAllergenic };);
            #region Using lambdas
            //let's try using lambdas to do the same thing!
            hypoAllergenic = dogBreeds.Find(x => {
                Console.WriteLine("Checking if loyal and hypoallergenic");
                return x.HypoAllergenic && x.Loyal; }
            ); //note here: the x is not given a variable type; this is inferred by the compiler
            //dogBreeds.Add(new Dog { Name = "Portuguese Water Dog", HypoAllergenic = true });
            //List<Dog> hypoAllergenicBreeds = dogBreeds.FindAll(x/*says we are passing a value x*/ => /*logic part*/!x.HypoAllergenic);
            ////statement lambas
            ///
            Func<Dog, Dog, bool> dogComparison = (x, y) => {return x.HypoAllergenic == y.HypoAllergenic};
            //Action<Dog> announceBreed = dogBreed =>
            //{
            //    Console.WriteLine("Breed name is {0}", dogBreed.Name);
            //};
            //announceBreed(hypoAllergenic);
            #endregion
            #region Integer Filter
            //List<int> values = new List<int>(){ 0, 5, 7, 26, 99, 54, 33, 12, 18, 11, 0, 6, 8, 10 };
            //string input;
            //while ((input = Console.ReadLine()) != "exit")
            //{
            //    try
            //    {
            //        int filterValue = Int32.Parse(input);
            //        List<int> filteredValues = values.FindAll(x => x > filterValue);
            //        filteredValues.ForEach(x => { Console.Write("{0} ",x); });// Console.Write);
            //    }
            //    catch(Exception e)
            //    {
            //        Console.WriteLine(e);
            //    }
            //}
            #endregion

            #region Events
            DogPack dogPack = new DogPack();
            Dog murtaugh = new Dog() { Name = "Murtaugh", HypoAllergenic = false, BarkSound = "grrr" };
            Dog sparky = new Dog() { Name = "Sparky", HypoAllergenic = false, BarkSound = "WOOF" };
            dogPack.AddDog(murtaugh);
            dogPack.AddDog(sparky);
            #endregion
            String input;
            RunningSumCalculator runningSum = new RunningSumCalculator();
            runningSum.MultipleOf10 += PrintIfMultipleOf10;
            while((input=Console.ReadLine()) != "exit")
            {
                int value = Int32.Parse(input);
                runningSum.AddNumber(value);// += value;
            }
        }
        public static void PrintIfMultipleOf10()
        {
            Console.WriteLine("We finally found a multiple of 10");
        }

        static bool FindIfHypoAllergenic(Dog dogBreed)
        {
            return dogBreed.HypoAllergenic;
        }
    }
    class RunningSumCalculator
    {
        private int sum = 0;
        public delegate void VoidFunction();

        public event Action MultipleOf10;
        public void AddNumber(int num)
        {

            this.sum += num;
            if(this.sum % 10 == 0)
                MultipleOf10();
        }

    }
}
