using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_3_OOConcepts
{
    public class Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("Flying!");
        }
    }
    public class Sparrow : Bird
    {

    }
    public class HummingBird : Bird {

    }

    public class Penguin : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Penguins obviously cannot fly. Do not trust Disney.");
        }
    }
}
