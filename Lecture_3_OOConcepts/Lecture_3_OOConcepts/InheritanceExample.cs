using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_3_OOConcepts
{
    class Wheel
    {
    }
    class Engine
    {

    }
    class Siren
    {

    }
    class Car
    {
        protected Wheel[] wheels;
        protected Engine engine;
    }

    class PoliceCar : Car
    {
        protected Siren siren;
        public void TurnSirenOn()
        {
            Console.WriteLine("!!!!!!!");
        }
    }
}
