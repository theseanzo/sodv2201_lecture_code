using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2_Basics
{
    class Program
    {
        #region Enums
        //Enums! C# has enumerations. An enumeration is a set of named integer constants.
        enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
        #endregion
        static void Main(string[] args)
        {
            //dataTypesExample();
            //arraysExample();
            //listsExample
            //dictionaryExample()
            //branchingExample();
            staticCallingExample();
            Console.ReadKey();//used to wait for a key to end the program
        }
        #region Data types
        static void dataTypesExample()
        {
            //C# is a statically-typed language. Therefore, we must define the types of variables before using them.
            int myInt = 1;
            float myFloat = 1.0f;
            bool myBoolean = true;
            string myName = "Sean";
            char myChar = 'a';
            double myDouble = 1.70;
            //Compiler will try and understand the type of variable automatically. However, once the variable type has been determined, it cannot be assigned a different type.
            //note: preferred not to do this. Also, do not use Hungarian Notation.
            var a = 5;
            var b = 7;
            var sum = a + b;

        }
        #endregion
        #region Arrays Example
        static void arraysExample()
        {
            //Arrays!
            //Brief refresher: an array stores a fixed-size sequential collection of elements of the same type. No, they are not mixed type. 
            //Basically an array allows you to store variables of the same type at contiguous memory locations
            //All 3 of these do the same thing
            int[] num = new int[5];
            num[0] = 1; num[1] = 2; num[2] = 3; num[3] = 4; num[4] = 5;
            //int[] num = { 1, 2, 3, 4, 5 };
            //int[] num = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine("The length of our array is " + num.Length);

            //multi-dimensional arrays. All 3 of these do the same thing.
            int[,] numMultiArray = new int[2, 2];
            numMultiArray[1, 0] = 1;
            numMultiArray[1, 1] = 2;
           // int[,] numMultiArray = { { 0, 0 }, { 1, 2 } };
           // int[,] numMultiArray = new int[2, 2] { { 0, 0 }, { 1, 2 } };
         
        }
        #endregion
        #region Lists example
        static void listsExample()
        {
            //Lists are an object which holds variables in a specific order
            List<int> numbers = new List<int>();
            numbers.Add(0);
            numbers.Add(5);
            numbers.Add(5); //show this after
            numbers.Remove(5);
            numbers.RemoveAt(1);
            List<int> moreNumbers = new List<int>();
            numbers.Add(5);
            moreNumbers.Add(10);
            Console.WriteLine("List length is " + numbers.Count);
            numbers.AddRange(moreNumbers);
        }
        #endregion
        #region Dictionaries
        static void dictionaryExample()
        {
            //dictionary is a special list where every value in the list has a key which is also a variable
            Dictionary<string, long> phoneBook = new Dictionary<string, long>();
            phoneBook.Add("Sean", 4035555555);
            phoneBook["Sean"] = 4035555555;
            if (phoneBook.ContainsKey("Sean"))
            {
                Console.WriteLine("We have Sean's number");
            }

            phoneBook.Remove("Sean");//this is the ex-girlfriend way of losing Sean's number
        }
        #endregion
        #region Strings
        //strings are a special case alias for System.String class. They are an array of characters. During compile time they are set to the same thing
        void stringsExample() {

            string firstName = "Robo";
            //String firstName = "Robo";
            string lastName = "Cop";
            //String lastName = "Cop";
            string emptyString = "";
            //String emptyString = String.Empty;

            //You can concatenate 2 or more strings
            string fullName = firstName + " " + lastName;

            //You can get substrings of strings
            string str = "full string";
            string part1 = str.Substring(5); //gives last 5 characters
            string part2 = str.Substring(5, 3); //gives last 5 characters from index 5

        }
        #endregion
        #region Branching
        static void branchingExample()
        {
            //if then statements allow us to execute different code based on conditions
            int godzillaStrength = 10;
            int humanStrength = 1;
            int superHumanStrength = 8;
            if(humanStrength >= godzillaStrength)
            {
                Console.WriteLine("Puny humans are stronger than Godzilla");
            }
            else if(superHumanStrength >= godzillaStrength)
            {
                Console.WriteLine("Well, at least super humans are stronger than Godzilla");
            }
            else
            {
                Console.WriteLine("Godzilla is stronger than all puny humans");
            }

            int[] dummyArray = { 1, 2, 3, 4, 5 };
            int dummyTotal = 0;
            for(int i = 0; i < dummyArray.Length; i++)
            {
                dummyTotal += dummyArray[i];
            }
            Console.WriteLine("The dummy total is " + dummyTotal);
            //for more, look into nested if, switch, conditional operators, do, while, etc.

        }
        #endregion
        #region Static Class Calling
        static void staticCallingExample()
        {
            Console.WriteLine("We are adding two numbers to get: " + MathFunctions.addNumbers(10f, 3f));
            Console.WriteLine("We are subtracting two numbers to get: " + MathFunctions.subtractNumbers(10f, 3f));
        }
        #endregion
    }
}
