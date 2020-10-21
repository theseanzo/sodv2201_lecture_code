using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Lambdas
{
    class DogPack
    {
        List<Dog> dogs = new List<Dog>();
        public DogPack()
        {

        }
        public void AddDog(Dog dog)
        {
            this.dogs.Add(dog);
        }
    }
    class EventsExample
    {
    }
}
