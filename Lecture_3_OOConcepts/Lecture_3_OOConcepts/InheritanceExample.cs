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
        public void startEngine()
        {

        }
    }

    /*
     * Extend the general bank account class to create a savings account. 
     * A savings account should have the ability to apply a given interest rate to the account’s contents 
     *   Create BankAccount and then exend with savings   
     */
    class PoliceCar : Car
    {
        protected Siren siren;

        public void TurnSirenOn()
        {
            Console.WriteLine("!!!!!!!");
        }
    }
}
