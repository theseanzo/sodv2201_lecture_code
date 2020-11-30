using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;

using System.Linq;
namespace Lecture_Queries
{
    class Dog
    {
        public String Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BasicLinq();
           // PrintEvenNumbers();
           // PrintPrimeNumbers();
            OrderByExample();
        }
        static void BasicLinq()
        {
            string[] names = { "Bill", "Steve", "James", "Maria" };
            List<string> results = new List<string>();
            foreach(String name in names)
            {
                if (name.Contains('a'))
                    results.Add(name);
            }

            var linqQuery = from string name in names
                            where name.Contains('a')
                            select name;

            names[2] = "Murtaugh";
            var fluentQuery = names.Where(x => x.Contains('a'));

        }


        static void PrintEvenNumbers()
        {
            int[] numbers = new int[50];
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = i;
            var evenNumbers =
                from num in numbers
                where (num % 2) == 0
                select num;
            foreach (int num in evenNumbers)
                Console.WriteLine(num);
            
            var fluentEvens = numbers.Where(x => x % 2 == 0);
      
        }
        static void PrintPrimeNumbers()
        {
            int[] numbers = new int[50];
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = i;
            int number = 100;
            var primeNumbers =
                from num in numbers
                where IsPrime(num)
                select num;
            var primeInRange = numbers.Where(x => x > 20 && x < 30 && IsPrime(x));
            var fluentPrimes = numbers.Where(x => IsPrime(x));
            foreach (int num in primeNumbers)
                Console.WriteLine(num);
           
        }
        static bool IsPrime(int num)
        {
            bool prime = true;
            if (num == 0 || num == 1)
                return false;
            for (int i = 2; i <= num / 2; i++)
                prime &= (num % i != 0);
            return prime;
        }
        static void OrderByExample()
        {
            List<Dog> dogs = new List<Dog>(){ new Dog { Name="Barley", Age=8 },
                   new Dog { Name="Boots", Age=4 },
                   new Dog { Name="Whiskers", Age=1 },
                    new Dog {Name="Murtaugh", Age = 5} };
            var dogsSorted = dogs.OrderBy(dog => dog.Age);
 
            var dogsSortedDescending = dogs.OrderByDescending(dog => dog.Age);

            var dogsSortedByName = dogs.OrderBy(dog => dog.Name);
            foreach(Dog dog in dogsSorted)
                Console.WriteLine(dog);
            PackOfDogs dogPack = new PackOfDogs();
            
            foreach (Dog dog in dogPack.dogs)
                Console.WriteLine(dog.Name);
        }
       

        class PackOfDogs
        {
            public List<Dog> dogs = new List<Dog>();
            //public String DogHowl { get; set; }
            public String DogHowl = "";
            public String DogWhail { get; set; }

            private String dogHowl = "";

            
            public List<Dog> GetDogs()
            {
                return this.dogs;
            }
        }
    }
}
