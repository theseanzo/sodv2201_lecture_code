using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
           // PrintPrimeNumbers();
           // OrderByExample();
        }
        static void BasicLinq()
        {
            string[] names = { "Bill", "Steve", "James", "Maria" };
            var linqQuery = from string name in names
                            where name.Contains('a')
                            select name;

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
        }
        static void PrintPrimeNumbers()
        {
            int[] numbers = new int[50];
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = i;
            var primeNumbers =
                from num in numbers
                where IsPrime(num)
                select num;
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
            Dog[] dogs = { new Dog { Name="Barley", Age=8 },
                   new Dog { Name="Boots", Age=4 },
                   new Dog { Name="Whiskers", Age=1 },
                    new Dog {Name="Murtaugh", Age = 5} };
            var dogsSorted = dogs.OrderBy(dog => dog.Age);
        }

    }
}
