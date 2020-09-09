using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_3_OOConcepts
{
    //public, private, protected, internal

    class Base
    {
        public string name = "Base";
        protected int id = 5323;
        private bool isDefined = true;
    }
    class Derived : Base
    {
        public void info()
        {
            Console.WriteLine("This is a derived class");
            Console.WriteLine("Members are inherited");
            Console.WriteLine(this.name);
            Console.WriteLine(this.id);
            //this.isDefined is not defined because private members are not inherited
        }
    }
}
