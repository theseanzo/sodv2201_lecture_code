using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Lambdas
{
    class DogBreed
    {
        public string Name { get; set; }
        public bool HypoAllergenic { get; set; }
    }
    class Program
    {
        //new DogBreed { Name = "Portuguese Water Dog", HypoAllergenic = true},  
        static void Main(string[] args)
        {
            List<DogBreed> dogBreeds = new List<DogBreed>() { new DogBreed { Name = "German Shepard", HypoAllergenic = false }, new DogBreed { Name = "Shiba Inu", HypoAllergenic = false }, 
                new DogBreed { Name = "Poodle", HypoAllergenic = true},  new DogBreed { Name = "Yorkshire Terrier", HypoAllergenic = false }   };
            //using predicates/delegates
            DogBreed hypoAllergenic = dogBreeds.Find(FindIfHypoAllergenic);
            #region Using lambdas
            //let's try using lambdas to do the same thing!
            hypoAllergenic = dogBreeds.Find(x => x.HypoAllergenic); //note here: the x is not given a variable type; this is inferred by the compiler
            dogBreeds.Add(new DogBreed { Name = "Portuguese Water Dog", HypoAllergenic = true });
            List<DogBreed> hypoAllergenicBreeds = dogBreeds.FindAll(x => x.HypoAllergenic);
            //statement lambas
            Action<DogBreed> announceBreed = dogBreed =>
            {
                Console.WriteLine("Breed name is {0}", dogBreed.Name);
            };
            announceBreed(hypoAllergenic);
            #endregion
            #region Integer Filter
            List<int> values = new List<int>(){ 0, 5, 7, 26, 99, 54, 33, 12, 18, 11, 0, 6, 8, 10 };
            string input;
            while ((input = Console.ReadLine()) != "exit")
            {
                try
                {
                    int filterValue = Int32.Parse(input);
                    List<int> filteredValues = values.FindAll(x => x < filterValue);
                    filteredValues.ForEach(Console.Write);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            #endregion
        }

        static bool FindIfHypoAllergenic(DogBreed dogBreed)
        {
            return dogBreed.HypoAllergenic;
        }
    }
}
