using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Lambdas
{
    class Human
    {
        public void HearDogBark(Dog dog)
        {

        }
    }
    class Dog
    {
        public string Name { get; set; }
        public bool HypoAllergenic { get; set; }

        public bool Loyal { get; set; }
        public string BarkSound { get; set; }
        private Human human;
        public event Action<Dog> DogBarked;
        public void Bark()
        {
            DogBarked(this);
            //create a timer and check "just barked"
            Console.WriteLine(BarkSound);
        }
    }



    class DogPack
    {
        List<Dog> dogs = new List<Dog>();
        //we want a dog pack to be aware every time a dog barks
        public DogPack()
        {

        }
        public void DogBarks(Dog dog)
        {

        }
        public void AddDog(Dog dog)
        {
            this.dogs.Add(dog);
            dog.DogBarked += DogBarks;
        }
    }
    class EventsExample
    {
    }
}
